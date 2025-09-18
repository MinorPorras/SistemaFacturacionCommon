Imports System.ComponentModel
Imports System.Configuration
Imports System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder
Imports System.Data.SQLite
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports Guna.UI2.WinForms
Imports Syncfusion.Windows.Forms.Diagram

Public Class P_Caja
#Region "Variables y constantes"
    Friend idCliente As Integer
    Private editingItem As ListViewItem
    Private editingSubItemIndex As Integer
    Private itemCount As Integer
    Private NumFactura As Integer
    Friend StrNumFactura As String
    Friend cantProd As Integer = 1
    Friend idUsu As Integer
    Friend totalCaja As Double = 0
    Friend Comentario As String = ""
    ' Este ID es para cuando se carga una factura desde cuentas por cobrar
    'Con esta se verifica que la cuenta que se está cargando no se vuelva a guardar
    Friend idFactura As Integer = 0

    ' Variable del formulario a nivel de clase para mantener una sola instancia
    'Permite la confuguración los productos favoritos
    Private frmfavProd As P_ConfigFavProd
#End Region

#Region "Carga y validaciones"
    Private Sub P_Caja_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Me.Bounds = Screen.PrimaryScreen.Bounds'
        Me.WindowState = FormWindowState.Maximized

        'Se desabilitann botones que tiene activaciones condicionales
        BTN_TVenta.Enabled = False
        BTN_GuardarCuenta.Enabled = False
        MNU_CONTX.Enabled = True
        Try
            'Se carga el último número de factura que se haya agregado, que va a ser el mas alto
            CargarNumFactura()

            TXT_BuscarCliente.Text = "0001"
            If DGV_Caja IsNot Nothing Then
                DGV_Caja.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(255, 128, 0)
                DGV_Caja.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(220, 120, 30)
                DGV_Caja.Columns(3).DefaultCellStyle.Format = "#,##"
                DGV_Caja.Columns(5).DefaultCellStyle.Format = "#,##"
                DGV_Caja.Font = New Font("Arial", 11)
                DGV_Caja.ColumnHeadersHeight = 25
                DGV_Caja.ColumnHeadersDefaultCellStyle.WrapMode = DataGridViewTriState.True
                idCliente = 1

                DGV_Caja.Columns(1).Width = (DGV_Caja.Width * 0.18)
                DGV_Caja.Columns(2).Width = (DGV_Caja.Width * 0.5)
                DGV_Caja.Columns(3).Width = (DGV_Caja.Width * 0.11)
                DGV_Caja.Columns(4).Width = (DGV_Caja.Width * 0.1)
                DGV_Caja.Columns(5).Width = (DGV_Caja.Width * 0.11)
            End If

            ' Añadir los botones de productos favoritos de forma dinpamica
            LoadBtnFav()
            LBL_Hora.Text = DateTime.Now.ToString("hh:mm:ss tt")
            LBL_Fecha.Text = DateTime.Now.ToString("dd/MM/yyyy")
            Timer1.Start()
            Me.Select()
            TXT_BuscarProducto.SelectAll()

            Dim logoPath As String = Md_Inicializacion.GetAppSetting("Logo")

            If Not String.IsNullOrWhiteSpace(logoPath) Then
                PIC_Logo.ImageLocation = logoPath
            Else
                PIC_Logo.Image = Nothing
                PIC_Logo.ImageLocation = ""
            End If
        Catch ex As Exception
            msgError("Error al cargar la información inicial de la caja." + vbCrLf + "Error: " + ex.Message)
        End Try
    End Sub

    Private Async Sub P_Caja_Async_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Esperar un pequeño retraso para asegurarse de que el formulario está completamente cargado
        Await Task.Delay(100)
        Me.Select()
        ' Seleccionar todo el texto en el TextBox
        TXT_BuscarProducto.Select()
        TXT_BuscarProducto.SelectAll()
    End Sub

    Friend Sub LoadBtnFav()
        'Se limpian los controles que ya existan
        PAN_FavProdBTNContainer.Controls.Clear()

        'Se restablecen algunas propiedades importantes
        PAN_FavProdBTNContainer.AutoScroll = True
        PAN_FavProdBTNContainer.Padding = New Padding(5)
        PAN_FavProdBTNContainer.Margin = New Padding(5)

        'Se cargan los productos favoritos
        T.Tables.Clear()
        SQL = "SELECT pf.ID_Producto as 'ID', p.nombre as 'Nombre', pf.BTN_Color as 'color'" &
              " FROM producto_favorito pf" &
              " JOIN producto p ON pf.ID_Producto = p.ID" &
              " ORDER BY pf.Posicion ASC;"
        Cargar_Tabla(T, SQL)
        If T.Tables(0).Rows.Count > 0 Then

            'Por cada fila que exista en la tabla se crea un botón con las características deseadas
            For Each row As DataRow In T.Tables(0).Rows
                'Se recupera el color de la DB
                Dim colorDb As String = Convert.ToInt32(row("color"))
                Dim colorBtn As Color = Color.FromArgb(colorDb)

                ' Para asegurar que el texto sea visible
                Dim brightness As Single = colorBtn.GetBrightness()

                Dim newFavBtn As New Guna2TileButton With {
                    .Text = row("nombre").ToString(),
                    .Tag = row("ID").ToString(),
                    .Name = "BTN_Fav_" & row("ID").ToString(),
                    .Size = New Size(200, 50),
                    .Margin = New Padding(5),
                    .FillColor = colorBtn,
                    .ForeColor = If(brightness > 0.5F, Color.Black, Color.White),
                    .Font = New Font("Segoe UI", 10, Drawing.FontStyle.Bold),
                    .ImageAlign = HorizontalAlignment.Center,
                    .Cursor = Cursors.Hand,
                    .Animated = True,
                    .BorderRadius = 10
                }

                AddHandler newFavBtn.Click, AddressOf AgregarProdFav
                PAN_FavProdBTNContainer.Controls.Add(newFavBtn)
            Next
        End If
    End Sub

    ' Subrutina única para manejar el clic de todos los botones de favoritos
    Private Sub AgregarProdFav(sender As Object, e As EventArgs)
        ' Obtener el botón que fue clickeado
        Dim btnFav As Guna.UI2.WinForms.Guna2Button = CType(sender, Guna.UI2.WinForms.Guna2Button)
        If String.IsNullOrEmpty(btnFav.Tag) Then
            ' El botón no tiene un ID de producto asignado
            msgError("No se encontró el producto")
            Return
        End If
        ' Buscar el producto en la base de datos usando el ID almacenado en la propiedad Tag del botón
        T.Tables.Clear()
        SQL = "SELECT p.codigo, p.variable, v.precio_venta FROM producto p LEFT JOIN producto_precioVenta v ON p.ID = v.ID_Producto" +
                " WHERE p.ID = " + btnFav.Tag.ToString()
        Cargar_Tabla(T, SQL)
        ' Verificar si se encontró el producto
        If T.Tables(0).Rows.Count <= 0 Then
            msgError("No se encontró el producto")
            Return
        End If
        ' Agregar el producto a la lista o manejar la variable según corresponda
        If T.Tables(0).Rows(0).Item(1) = 0 Then
            AgregarProd(btnFav.Tag.ToString(), T.Tables(0).Rows(0).Item(0), btnFav.Text, T.Tables(0).Rows(0).Item(2), 1)
        Else
            E_ProductoVariable.LBL_Cod.Text = T.Tables(0).Rows(0).Item(0)
            E_ProductoVariable.LBL_Producto.Text = btnFav.Text
            E_ProductoVariable.LBL_ID.Text = btnFav.Tag
            E_ProductoVariable.Show()
        End If
    End Sub

    Friend Sub CargarNumFactura()
        Try
            T.Tables.Clear()
            SQL = "SELECT num_factura FROM factura ORDER BY CAST(num_factura AS INTEGER) DESC;"
            Cargar_Tabla(T, SQL)
            If T.Tables(0).Rows.Count > 0 Then
                NumFactura = If(IsDBNull(T.Tables(0).Rows(0).Item(0)), 1, Convert.ToInt32(T.Tables(0).Rows(0).Item(0)))
                NumFactura += 1
                StrNumFactura = NumFactura.ToString("D15")
            End If
        Catch ex As Exception
            msgError("Error al cargar el número de factura." + vbCrLf + "Error: " + ex.Message)
        End Try
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        BackgroundWorker1.RunWorkerAsync()
    End Sub

    Private Sub BackgroundWorker1_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles BackgroundWorker1.RunWorkerCompleted
        LBL_Hora.Text = DateTime.Now.ToString("hh:mm:ss tt")
        LBL_Fecha.Text = DateTime.Now.ToString("dd/MM/yyyy")
    End Sub

#End Region

    Private Sub BTN_NProd_Click(sender As Object, e As EventArgs) Handles BTN_NProd.Click
        T.Tables.Clear()
        SQL = "SELECT p.ID, p.variable, v.precio_venta, p.nombre FROM producto p LEFT JOIN producto_precioVenta v ON p.ID = v.ID_Producto" +
                " WHERE p.codigo = '" & TXT_BuscarProducto.Text & "';"
        Cargar_Tabla(T, SQL)
        If T.Tables(0).Rows.Count > 0 Then
            If T.Tables(0).Rows(0).Item(1) = 0 Then
                Buscar_DatosProd(TXT_BuscarProducto, False)
            Else
                E_ProductoVariable.LBL_Cod.Text = TXT_BuscarProducto.Text
                E_ProductoVariable.LBL_Producto.Text = T.Tables(0).Rows(0).Item(3)
                E_ProductoVariable.LBL_ID.Text = T.Tables(0).Rows(0).Item(0)
                E_ProductoVariable.Show()
            End If

        Else
            msgError("El código que colocó está mal escrito o no existe")
        End If
    End Sub

    Friend Sub Buscar_DatosProd(txtCodProd As Guna.UI2.WinForms.Guna2TextBox, buscado As Boolean)
        Try
            T.Tables.Clear()
            SQL = "SELECT p.ID, p.nombre, pv.precio_venta FROM producto p LEFT JOIN producto_precioVenta pv ON p.ID = pv.ID_Producto" +
                " WHERE p.codigo = '" & txtCodProd.Text & "'"
            Cargar_Tabla(T, SQL)
            If T.Tables(0).Rows.Count > 0 Then
                If Not buscado Then
                    cantProd = 1
                End If
                AgregarProd(T.Tables(0).Rows(0).Item(0).ToString(), txtCodProd.Text, T.Tables(0).Rows(0).Item(1).ToString(), T.Tables(0).Rows(0).Item(2).ToString(), cantProd)
                DGV_Caja.Columns(3).DefaultCellStyle.Format = "#,##"
                DGV_Caja.Columns(5).DefaultCellStyle.Format = "#,##"
                cantProd = 1
                TXT_BuscarProducto.SelectAll()
            Else
                msgError("El código que colocó está mal escrito o no existe")
            End If

        Catch ex As Exception
            msgError("El código que colocó está mal escrito o no existe" + ex.Message)
        End Try
    End Sub


    Friend Sub AgregarProd(ID As String, codigo As String, nombre As String, precioVenta As String, cant As String)
        Dim filaExistente As DataGridViewRow = Nothing

        ' 1. Busca si el producto ya existe en el DataGridView por su ID
        For Each fila As DataGridViewRow In DGV_Caja.Rows
            If fila.Cells(0).Value IsNot Nothing AndAlso fila.Cells(0).Value.ToString() = ID Then
                filaExistente = fila
                Exit For ' Sal del bucle tan pronto como encuentres la fila
            End If
        Next

        If filaExistente IsNot Nothing Then
            ' 2. Si el producto ya existe, aumenta la cantidad y recalcula el subtotal
            Dim cantidadActual As Integer = 0
            If Not Integer.TryParse(filaExistente.Cells(4).Value.ToString(), cantidadActual) Then
                msgError("Error al leer la cantidad actual del producto.")
                Return
            End If

            'Se suma a la cantidad actual la nueva cantidad que se está agregando
            cantidadActual += Integer.Parse(cant)
            filaExistente.Cells(4).Value = cantidadActual.ToString()

            'Se actualiza el subtotal
            Dim subtotalActual As Double = Convert.ToDouble(filaExistente.Cells(3).Value) * cantidadActual
            filaExistente.Cells(5).Value = subtotalActual
        Else
            ' 3. Si el producto no existe, agrega una nueva fila como lo hacías antes
            Dim Subtotal As Double = Convert.ToInt32(cant) * Convert.ToInt32(precioVenta)
            Dim row As String() = {ID, codigo, nombre, precioVenta, cant, Subtotal.ToString()}

            DGV_Caja.Rows.Add(row)
        End If

        ' Acciones que se ejecutan en ambos casos
        TXT_BuscarProducto.Clear()
        TXT_BuscarProducto.Focus()
        ValidarListView()
        CargarTotal()
    End Sub

    Friend Sub CargarTotal()
        totalCaja = 0
        For i As Integer = 0 To DGV_Caja.Rows.Count - 2
            totalCaja += Convert.ToDouble(DGV_Caja.Rows(i).Cells(5).Value)
        Next
        TXT_Total.Text = "₡ " + totalCaja.ToString()
    End Sub

    Private Sub TXT_BuscarProducto_TextChanged(sender As Object, e As EventArgs) Handles TXT_BuscarProducto.TextChanged
        If Not String.IsNullOrEmpty(TXT_BuscarProducto.Text) Then
            BTN_NProd.Enabled = True
        Else
            BTN_NProd.Enabled = False
        End If
    End Sub

    Friend Sub ValidarListView()
        itemCount = DGV_Caja.Rows.Count
        If itemCount > 1 Then
            BTN_TVenta.Enabled = True
            BTN_GuardarCuenta.Enabled = True
            MNU_MODIFICAR.Visible = True
            MNU_ELIMINAR.Visible = True
        Else
            MNU_ELIMINAR.Visible = False
            BTN_GuardarCuenta.Enabled = False
            MNU_MODIFICAR.Visible = False
            BTN_TVenta.Enabled = False
        End If
    End Sub

    Friend Sub LIMPIAR()

        'Se desabilitann botones que tiene activaciones condicionales
        BTN_TVenta.Enabled = False
        BTN_GuardarCuenta.Enabled = False

        BTN_DelFactura.PerformClick()
        TXT_BuscarProducto.Clear()
        TXT_Total.Clear()
        TXT_BuscarCliente.Text = "0001"
        idCliente = 1
        StrNumFactura = ""
        idFactura = 0
        NumFactura = 0
        totalCaja = 0
        Comentario = ""

        'Se carga el último número de factura que se haya agregado, que va a ser el mas alto
        CargarNumFactura()

    End Sub

    Private Sub DGV_Caja_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles DGV_Caja.CellEndEdit
        ' Se asegura de que no estamos en una fila de encabezado o de inserción
        If e.RowIndex >= 0 AndAlso DGV_Caja.Rows(e.RowIndex).Cells(4).Value IsNot Nothing Then
            ' Obtiene los valores de la cantidad y el precio de la fila que se está editando
            Dim cant As Double = Convert.ToDouble(DGV_Caja.Rows(e.RowIndex).Cells(4).Value)
            Dim precioVenta As Double = Convert.ToDouble(DGV_Caja.Rows(e.RowIndex).Cells(3).Value)

            ' Calcula el subtotal
            Dim subTotal As Double = precioVenta * cant

            ' Asigna el subtotal a la celda 5 de la fila actual
            DGV_Caja.Rows(e.RowIndex).Cells(5).Value = subTotal
        End If

        ' Recalcula el total de la factura
        CargarTotal()
        TXT_BuscarProducto.Focus()
    End Sub

    Private Sub DGV_Caja_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGV_Caja.CellClick
        ' Validar que el clic no fue en el encabezado de las columnas
        If e.RowIndex >= 0 Then
            ' Obtener la fila en la que se hizo clic
            Dim filaSeleccionada As DataGridViewRow = DGV_Caja.Rows(e.RowIndex)

            ' Asegurar que la celda 4 exista en la fila
            If filaSeleccionada.Cells.Count > 4 Then
                ' Seleccionar la celda en la columna 4
                filaSeleccionada.Cells(4).Selected = True

                ' Poner el DGV en modo de edición y activar la celda 4
                DGV_Caja.CurrentCell = filaSeleccionada.Cells(4)
                DGV_Caja.BeginEdit(True)
            End If
        End If
    End Sub

    Private Sub P_Caja_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        Me.Select()
        TXT_BuscarProducto.Select()
        TXT_BuscarProducto.SelectAll()
    End Sub

#Region "Cuentas por cobrar"

    ' Modifica la función GuardarCuenta para usar la nueva función asíncrona
    Private Async Sub GuardarCuenta(comentarioRecibido As String, actualizar_factura_cobrar As Boolean)
        Console.WriteLine("Se guarda la cuenta en la DB")
        'Se Guarda el resultado del return de la función de guardado, enviandole el comentario y si es una actualización o un guardado nuevo
        Dim resultado As String = Await GuardarOActualizarCuenta(comentarioRecibido, actualizar_factura_cobrar)

        ' En caso de que el resultado se OK, se muestra un mensaje, se limpia la caja y se carga el nuevo número de factura
        If resultado = "OK" Then
            mensaje("Cuenta guardada con éxito", vbOKOnly, "Cuenta por cobrar")
            LIMPIAR()
            CargarNumFactura()
        Else
            msgError(resultado) ' Muestra el mensaje de error de la transacción
        End If
    End Sub

    Private Async Function GuardarOActualizarCuenta(comentarioRecibido As String, actualizar_factura_cobrar As Boolean) As Task(Of String)
        Return Await Task.Run(Function()
                                  ' Iniciar una transacción de base de datos
                                  Dim dbConnection As New SQLiteConnection(GetConnectionString())
                                  dbConnection.Open()
                                  Dim transaction As SQLiteTransaction = dbConnection.BeginTransaction()

                                  Try
                                      If Not actualizar_factura_cobrar Then
                                          ' Caso: Guardar por primera vez
                                          idFactura = OBTENERPK("factura", "ID")
                                          Dim insertFacturaSQL As String = "INSERT INTO factura 
                                        (ID, num_factura, fecha_emision, ID_Cliente, ID_usuario, total, efectivo_cliente, tarjeta_cliente, vuelto, tipo_venta, cobrada)
                                        VALUES (@id, @numFactura, @fecha, @idCliente, @idUsu, @total, 0, 0, 0, 0, 0)"
                                          Dim parametrosFactura As New Dictionary(Of String, Object) From {
                                              {"id", idFactura},
                                              {"numFactura", NumFactura},
                                              {"fecha", DateTime.Now},
                                              {"idCliente", idCliente},
                                              {"idUsu", idUsu},
                                              {"total", totalCaja}
                                          }
                                          Using cmd As New SQLiteCommand(insertFacturaSQL, dbConnection, transaction)
                                              'Se agrega cada uno de los parámetros al comando
                                              For Each p In parametrosFactura
                                                  cmd.Parameters.AddWithValue("@" & p.Key, p.Value)
                                              Next
                                              cmd.ExecuteNonQuery()
                                          End Using

                                      Else
                                          ' Caso: Actualizar factura existente
                                          Dim updateFacturaSQL As String = "UPDATE factura SET 
                                            num_factura = @num_factura, 
                                            fecha_emision = @fecha_emision, 
                                            ID_Cliente = @ID_Cliente, 
                                            ID_usuario = @ID_usuario, 
                                            total = @total 
                                            WHERE ID = @idFactura"
                                          Dim parametrosUpdate As New Dictionary(Of String, Object) From {
                                              {"num_factura", NumFactura},
                                              {"fecha_emision", DateTime.Now},
                                              {"ID_Cliente", idCliente},
                                              {"ID_usuario", idUsu},
                                              {"total", totalCaja},
                                              {"idFactura", idFactura}
                                          }
                                          Using cmd As New SQLiteCommand(updateFacturaSQL, dbConnection, transaction)
                                              For Each p In parametrosUpdate
                                                  'Se agrega cada uno de los parámetros al comando
                                                  cmd.Parameters.AddWithValue("@" & p.Key, p.Value)
                                              Next
                                              cmd.ExecuteNonQuery()
                                          End Using

                                          ' Eliminar productos anteriores
                                          Dim deleteProductosSQL As String = "DELETE FROM factura_producto WHERE ID_Factura = @idFactura"
                                          Using cmd As New SQLiteCommand(deleteProductosSQL, dbConnection, transaction)
                                              cmd.Parameters.AddWithValue("@idFactura", idFactura)
                                              cmd.ExecuteNonQuery()
                                          End Using
                                      End If

                                      ' Insertar productos de la factura (para ambos casos)
                                      For i As Integer = 0 To DGV_Caja.Rows.Count - 2
                                          Dim producto As New Cls_ProductoCaja With {
                                            .ID = Convert.ToInt32(DGV_Caja.Rows(i).Cells(0).Value.ToString()),
                                            .Cantidad = Convert.ToInt32(DGV_Caja.Rows(i).Cells(4).Value.ToString()),
                                            .Precio = Convert.ToDecimal(DGV_Caja.Rows(i).Cells(3).Value.ToString())
                                        }
                                          Dim insertProductoSQL As String = "INSERT INTO factura_producto (ID_Factura, ID_Producto, cant, precio_venta) VALUES (@idFactura, @idProducto, @cantidad, @precio)"
                                          Using cmd As New SQLiteCommand(insertProductoSQL, dbConnection, transaction)
                                              cmd.Parameters.AddWithValue("@idFactura", idFactura)
                                              cmd.Parameters.AddWithValue("@idProducto", producto.ID)
                                              cmd.Parameters.AddWithValue("@cantidad", producto.Cantidad)
                                              cmd.Parameters.AddWithValue("@precio", producto.Precio)
                                              cmd.ExecuteNonQuery()
                                          End Using
                                      Next

                                      ' Insertar o actualizar comentario
                                      Dim comentarioSQL As String
                                      If Not actualizar_factura_cobrar Then
                                          comentarioSQL = "INSERT INTO factura_comentario (ID_Factura, comentario) VALUES (@idFactura, @comentario)"
                                      Else
                                          comentarioSQL = "UPDATE factura_comentario SET comentario = @comentario WHERE ID_Factura = @idFactura"
                                      End If

                                      Using cmd As New SQLiteCommand(comentarioSQL, dbConnection, transaction)
                                          cmd.Parameters.AddWithValue("@comentario", comentarioRecibido)
                                          cmd.Parameters.AddWithValue("@idFactura", idFactura)
                                          cmd.ExecuteNonQuery()
                                      End Using

                                      transaction.Commit()
                                      Return "OK"

                                  Catch ex As Exception
                                      transaction.Rollback()
                                      Return "Error en la transacción: " & ex.Message
                                  Finally
                                      If dbConnection.State = ConnectionState.Open Then
                                          dbConnection.Close()
                                      End If
                                  End Try
                              End Function)
    End Function

    ' En el formulario P_Caja (archivo P_Caja.vb)
    Public Sub CargarFacturaDesdeCuentas(productos As DataTable, num_factura As String, totalFactura As Double, idFactura As String, idCliente As String, comentario As String)
        ' 1. Limpia los datos de la venta actual
        Me.LIMPIAR()

        ' 2. Asigna las variables de la clase con los datos de la factura
        Me.totalCaja = totalFactura
        Me.idFactura = idFactura
        Me.idCliente = idCliente
        Me.NumFactura = num_factura ' Se asume que el ID de la factura es también el número de factura
        Me.Comentario = comentario

        BTN_GuardarCuenta.Text = "[F6] Actualizar cuenta"

        ' 3. Llenar el DataGridView de la caja con los productos
        For Each fila As DataRow In productos.Rows
            Dim idProd As String = fila("ID_Producto").ToString()
            Dim cantidad As String = fila("cant").ToString()
            Dim precioVenta As String = fila("precio_venta").ToString()

            ' Aquí debes buscar el nombre del producto
            ' Puedes hacer una consulta a la base de datos para obtener el nombre
            SQL = $"SELECT nombre, codigo FROM producto WHERE ID = {idProd}"
            T2.Tables.Clear()
            Cargar_Tabla(T2, SQL)
            Dim nombreProd As String = ""
            Dim codigoProd As String = ""
            If T2.Tables(0).Rows.Count > 0 Then
                nombreProd = T2.Tables(0).Rows(0)("nombre").ToString()
                codigoProd = T2.Tables(0).Rows(0)("codigo").ToString()
            End If

            ' Agregar la fila al DataGridView
            Me.DGV_Caja.Rows.Add(idProd, codigoProd, nombreProd, precioVenta, cantidad, Convert.ToDouble(precioVenta) * Convert.ToDouble(cantidad))
        Next

        ' 4. Actualizar la interfaz con el total de la factura
        Me.TXT_Total.Text = totalFactura.ToString("N2") ' Formatear a dos decimales

        ' Se asegura de que el formulario esté en primer plano
        ValidarListView()
        Me.Show()
        Me.Select()
    End Sub
#End Region

#Region "Acciones de botones"

    Private Sub BTN_CerrarApp_Click(sender As Object, e As EventArgs)
        msgCerrarApp()
    End Sub

    Private Sub BTN_EditFavProd_Click(sender As Object, e As EventArgs) Handles BTN_EditFavProd.Click
        ' Verifica si la instancia del formulario existe o si se ha cerrado
        If frmfavProd Is Nothing OrElse frmfavProd.IsDisposed Then
            ' Si no existe o se cerró, crea una nueva instancia
            frmfavProd = New P_ConfigFavProd With {
            .Owner = Me
        }
            frmfavProd.Show()
        Else
            ' Si ya existe, simplemente tráelo al frente
            frmfavProd.BringToFront()
        End If
    End Sub

    Private Sub BTN_DelFactura_Click(sender As Object, e As EventArgs) Handles BTN_DelFactura.Click
        DGV_Caja.Rows.Clear()
        TXT_BuscarProducto.Clear()
        TXT_BuscarProducto.SelectAll()
        BTN_GuardarCuenta.Text = "[F6] Guardar cuenta"
        ValidarListView()
        CargarTotal()
    End Sub

    Private Sub BTN_CuentaCobrar_Click(sender As Object, e As EventArgs) Handles BTN_CuentaCobrar.Click
        ' Establece P_Caja (Me) como el dueño de frmCuentasCobrar
        Dim frmCuentasCobrar As New P_CuentasCobrar With {
            .Owner = Me
        }
        ' Muestra el formulario de cuentas por cobrar
        frmCuentasCobrar.Show()
    End Sub

    Private Sub BTN_GuardarCuenta_Click(sender As Object, e As EventArgs) Handles BTN_GuardarCuenta.Click
        If DGV_Caja.Rows.Count <= 1 Then
            msgError("No se puede Guardar una factura vacía")
            Return
        End If
        Using dlg As New D_GuardarCuenta()
            ' Establece el propietario del diálogo
            dlg.Owner = Me
            Dim actualizar_factura_cobrar As Boolean = Not String.IsNullOrEmpty(Comentario)
            ' Si está vació sigifica que la cuenta no se ha guardado antes = false
            ' Si no está vacio significa que la cuenta si se ha guardado antes, por lo que = true

            If actualizar_factura_cobrar Then
                ' Se trata de una cuenta por cobrar ya registrada
                dlg.TXT_Comentario.Text = Comentario
            End If
            ' Muestra el diálogo
            dlg.ShowDialog()

            ' Verifica el resultado del dialogo
            If dlg.ResultadoDelDialogo = DialogResult.OK Then
                Console.WriteLine("Se presionó el botón OK")
                Comentario = dlg.ComentarioIngresado
                GuardarCuenta(Comentario, actualizar_factura_cobrar)
            Else
                Console.WriteLine("Se presionó el botón Cancel")
                Return
            End If
        End Using
    End Sub

    Private Sub BTN_Reprint_Click(sender As Object, e As EventArgs) Handles BTN_Reprint.Click
        ' Establece P_Caja (Me) como el dueño de frmReimprimirFact
        Dim frmReimprimirFact As New P_ReimprimirFact With {
            .Owner = Me
        }
        frmReimprimirFact.Show()
        frmReimprimirFact.Select()
        Me.Hide()
    End Sub

    Private Sub BTN_TVenta_Click(sender As Object, e As EventArgs) Handles BTN_TVenta.Click
        P_TerminarVenta.Owner = Me
        P_TerminarVenta.LIMPIAR()
        Dim precio As String() = TXT_Total.Text.Split(" "c)
        'Si se está terminando la venta de una cuenta por cobrar se asigna el ID que ya existe
        If idFactura <> 0 Then
            P_TerminarVenta.idFactura = idFactura
            P_TerminarVenta.isCuentaPorCobrar = True
        End If
        If DGV_Caja.Rows.Count > 1 Then
            P_TerminarVenta.total = totalCaja
            P_TerminarVenta.TXT_ETotal.Text = TXT_Total.Text
            P_TerminarVenta.TXT_TTotal.Text = TXT_Total.Text
            P_TerminarVenta.TXT_STotal.Text = TXT_Total.Text
            P_TerminarVenta.TXT_DTotal.Text = TXT_Total.Text
            P_TerminarVenta.TXT_MTotal.Text = TXT_Total.Text
            P_TerminarVenta.NumFactura = NumFactura
            P_TerminarVenta.idCLiente = idCliente
            'Se pasa el datagrid completo para obtener los datos
            P_TerminarVenta.dgvProductos = DGV_Caja
            P_TerminarVenta.Show()
            P_TerminarVenta.Select()
            P_TerminarVenta.TXT_ECliente.SelectAll()
        End If
    End Sub

    Private Sub MNU_MODIFICAR_Click(sender As Object, e As EventArgs) Handles MNU_MODIFICAR.Click
        'Si no hay una fila seleccionada o si la fila selecionada es la fila nueva se devuelve un error indicando que debe de seleccionar una fila
        If DGV_Caja.SelectedRows.Count <= 0 Or DGV_Caja.SelectedRows(0).IsNewRow Then
            msgError("Se debe de seleccionar un producto, no se puede modificar una fila vacía")
            Return
        End If

        B_Producto.ModProd = True
        B_Producto.Show()
        B_Producto.Select()
        B_Producto.LBL_IDProd.Text = DGV_Caja.SelectedRows(0).Cells(0).Value.ToString()
        B_Producto.idModProd = DGV_Caja.SelectedRows(0).Cells(0).Value.ToString()
        B_Producto.TXT_BuscarProd.Text = DGV_Caja.SelectedRows(0).Cells(2).Value.ToString()
        B_Producto.TXT_CantProd.Text = DGV_Caja.SelectedRows(0).Cells(4).Value.ToString()
        ValidarListView()
        CargarTotal()
    End Sub

    Private Sub MNU_ELIMINAR_Click(sender As Object, e As EventArgs) Handles MNU_ELIMINAR.Click
        'Si no hay una fila seleccionada o si la fila selecionada es la fila nueva se devuelve un error indicando que debe de seleccionar una fila
        If DGV_Caja.SelectedRows.Count <= 0 Or DGV_Caja.SelectedRows(0).IsNewRow Then
            msgError("Se debe de seleccionar un producto, no se puede eliminar una fila vacía")
            Return
        End If

        'Se remuevela fila en el indice seleccionado
        DGV_Caja.Rows.RemoveAt(DGV_Caja.SelectedRows(0).Index)

        'Se valida la información de datagrid y se actualiza elt otal de la factura
        ValidarListView()
        CargarTotal()
    End Sub

    Private Sub P_Caja_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        Select Case e.KeyCode
            Case Keys.F3
                BTN_RegresarCaja.PerformClick()
            Case Keys.F4
                BTN_TVenta.PerformClick()
            Case Keys.F5
                BTN_TVenta.PerformClick()
            Case Keys.F6
                BTN_GuardarCuenta.PerformClick()
            Case Keys.F7
                BTN_Reprint.PerformClick()
            Case Keys.F8
                BTN_DelFactura.PerformClick()
        End Select
    End Sub

    Private Sub BTN_RegresarCliente_Click(sender As Object, e As EventArgs)
        Timer1.Stop()
        M_Inicio.Show()
        M_Inicio.Select()
        Me.Close()
    End Sub
#End Region

#Region "Busquedas"
    Private Sub TXT_BuscarCliente_DoubleClick(sender As Object, e As EventArgs) Handles TXT_BuscarCliente.DoubleClick
        B_Cliente.Show()
        B_Cliente.Select()
        B_Cliente.LIMPIAR()
    End Sub

    Private Sub TXT_BuscarProducto_DoubleClick(sender As Object, e As EventArgs) Handles TXT_BuscarProducto.DoubleClick
        B_Producto.Show()
        B_Producto.Select()
        B_Producto.LIMPIAR()
    End Sub

#End Region
End Class