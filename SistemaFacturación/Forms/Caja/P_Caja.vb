Imports System.ComponentModel
Imports System.Configuration
Imports System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder
Imports System.Data.SQLite
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports Guna.UI2.WinForms
Imports Syncfusion.Windows.Forms.Diagram
Imports SistemaFacturaciónCommon.SistemaFacturacion.Forms.Busqueda
Imports SistemaFacturaciónCommon.SistemaFacturacion.Forms.Dialogos
Imports SistemaFacturaciónCommon.SistemaFacturacion.Forms.Inicio
Imports SistemaFacturaciónCommon.SistemaFacturacion.Forms.CuentasXCobrar
Imports SistemaFacturaciónCommon.SistemaFacturacion.Modules
Imports SistemaFacturaciónCommon.SistemaFacturacion.Data
Imports System.Globalization
Imports Syncfusion.PivotAnalysis.Base
Imports Syncfusion.XlsIO
Namespace SistemaFacturacion.Forms.Caja
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
        Friend idEncabezadoCC As Integer = 0
        Friend isDialogOpen As Boolean
        Friend prodList As New List(Of Cls_ProductoCaja)
        Private binCaja As New BindingSource
        Private culturaCR As New CultureInfo("es-CR")

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
                idCliente = 1

                binCaja.DataSource = prodList
                DGV_Caja.DataSource = binCaja

                ' Añadir los botones de productos favoritos de forma dinpamica
                LoadBtnFav()
                LBL_Hora.Text = DateTime.Now.ToString("hh:mm:ss tt")
                LBL_Fecha.Text = DateTime.Now.ToString("dd/MM/yyyy")
                Timer1.Start()
                Me.Select()
                TXT_BuscarProducto.SelectAll()

                Dim logoPath As String = GetAppSetting("Logo")

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
        Private Sub DGV_Caja_DataBindingComplete(sender As Object, e As DataGridViewBindingCompleteEventArgs) Handles DGV_Caja.DataBindingComplete
            Dim hiddenColumns As New List(Of String) From {
                {"ID"},
                {"Precio"},
                {"Total"}
            }
            Dim formatedNames As New Dictionary(Of String, String) From {
                {"formated_precio", "Precio"},
                {"formated_total", "Total"}
            }
            Dim columnSize As New Dictionary(Of String, Integer) From {
                {"Cod", 60},
                {"Producto", 200},
                {"formated_precio", 70},
                {"Cant.", 70},
                {"formated_total", 70}
            }

            formatDGV(DGV_Caja, hiddenColumns, formatedNames, columnSize)

            DGV_Caja.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(255, 128, 0)
            DGV_Caja.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(220, 120, 30)
            DGV_Caja.Font = New Font("Arial", 11)
            DGV_Caja.ColumnHeadersHeight = 25
            DGV_Caja.ColumnHeadersDefaultCellStyle.WrapMode = DataGridViewTriState.True
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
                " WHERE p.ID = @ID"
            Dim paramList As New List(Of SQLiteParameter) From {{New SQLiteParameter("@ID", btnFav.Tag.ToString())}}
            CargarTablaParam(T, SQL, paramList)

            ' Verificar si se encontró el producto
            If T.Tables(0).Rows.Count <= 0 Then
                msgError("No se encontró el producto")
                Return
            End If

            ' Agregar el producto a la lista o manejar la variable según corresponda
            Dim isVariable = T.Tables(0).Rows(0).Item(1) = 1
            If Not isVariable Then
                'Si el producto no es variable
                Dim producto As New Cls_ProductoCaja With {
                    .ID = btnFav.Tag,
                    .Codigo = T.Tables(0).Rows(0).Item("codigo"),
                    .Producto = btnFav.Text,
                    .Precio = T.Tables(0).Rows(0).Item("precio_venta"),
                    .Cantidad = 1
                }

                AddProduct(producto)
                Exit Sub
            End If

            'Si es variable
            Using prodVariableForm As New E_ProductoVariable
                prodVariableForm.LBL_Cod.Text = T.Tables(0).Rows(0).Item("Codigo")
                prodVariableForm.LBL_Producto.Text = btnFav.Text
                prodVariableForm.LBL_ID.Text = btnFav.Tag
                prodVariableForm.Owner = Me
                prodVariableForm.cant = 1
                Dim result As DialogResult = prodVariableForm.ShowDialog()
                If result = DialogResult.OK Then
                    AddProduct(prodVariableForm.producto)
                End If
                Exit Sub
            End Using

        End Sub

        Friend Sub CargarNumFactura()
            Try
                T.Tables.Clear()
                SQL = "SELECT num_factura FROM factura ORDER BY CAST(num_factura AS INTEGER) DESC LIMIT 1;"
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

#Region "Funciones generales"
        Friend Sub LIMPIAR()

            'Se desabilitann botones que tiene activaciones condicionales
            BTN_TVenta.Enabled = False
            BTN_GuardarCuenta.Enabled = False

            TXT_BuscarProducto.Clear()
            TXT_Total.Clear()
            TXT_BuscarCliente.Text = "0001"
            idCliente = 1
            StrNumFactura = ""
            idEncabezadoCC = 0
            NumFactura = 0
            totalCaja = 0
            Comentario = ""
            DGV_Caja.Rows.Clear()

            'Se carga el último número de factura que se haya agregado, que va a ser el mas alto
            CargarNumFactura()

            TXT_BuscarProducto.SelectAll()
            BTN_GuardarCuenta.Text = "[F6] Guardar cuenta"

            ValidarListView()
            getTotal()

        End Sub

        Private Sub P_Caja_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
            Me.Select()
            TXT_BuscarProducto.Select()
            TXT_BuscarProducto.SelectAll()
        End Sub

        Private Sub P_Caja_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
            ManejarCierreONavegacion(e)
        End Sub
#End Region

#Region "Manejo de productos"


        Private Sub BTN_NProd_Click(sender As Object, e As EventArgs) Handles BTN_NProd.Click
            T.Tables.Clear()
            SQL = "SELECT p.ID, p.variable, v.precio_venta, p.nombre FROM producto p LEFT JOIN producto_precioVenta v ON p.ID = v.ID_Producto" +
                " WHERE p.codigo = '" & TXT_BuscarProducto.Text & "';"
            Cargar_Tabla(T, SQL)
            If T.Tables(0).Rows.Count > 0 Then
                If T.Tables(0).Rows(0).Item("variable") = 0 Then
                    Buscar_DatosProd(TXT_BuscarProducto, 1)
                Else
                    Using prodVariableForm As New E_ProductoVariable
                        prodVariableForm.LBL_Cod.Text = TXT_BuscarProducto.Text
                        prodVariableForm.LBL_Producto.Text = T.Tables(0).Rows(0).Item("nombre")
                        prodVariableForm.LBL_ID.Text = T.Tables(0).Rows(0).Item("ID")
                        prodVariableForm.Owner = Me
                        prodVariableForm.cant = 1
                        Dim result As DialogResult = prodVariableForm.ShowDialog()
                        If result = DialogResult.OK Then
                            AddProduct(prodVariableForm.producto)
                        End If
                    End Using
                End If

            Else
                msgError("El código que colocó está mal escrito o no existe")
            End If
        End Sub

        Friend Sub Buscar_DatosProd(txtCodProd As Guna.UI2.WinForms.Guna2TextBox, cant As Integer)
            Try
                T.Tables.Clear()
                SQL = "SELECT p.ID, p.nombre, pv.precio_venta FROM producto p LEFT JOIN producto_precioVenta pv ON p.ID = pv.ID_Producto" +
                " WHERE p.codigo = '" & txtCodProd.Text & "'"
                Cargar_Tabla(T, SQL)
                If T.Tables(0).Rows.Count > 0 Then
                    Dim producto As New Cls_ProductoCaja With {
                        .ID = T.Tables(0).Rows(0).Item("ID"),
                        .Codigo = txtCodProd.Text,
                        .Producto = T.Tables(0).Rows(0).Item("nombre"),
                        .Precio = T.Tables(0).Rows(0).Item("precio_venta"),
                        .Cantidad = cant
                    }
                    AddProduct(producto)
                    TXT_BuscarProducto.SelectAll()
                Else
                    msgError("El código que colocó está mal escrito o no existe")
                End If

            Catch ex As Exception
                msgError("El código que colocó está mal escrito o no existe" + ex.Message)
            End Try
        End Sub

        Friend Sub AddProduct(producto As Cls_ProductoCaja)
            Dim productoExistente As Cls_ProductoCaja = prodList.FirstOrDefault(Function(p) p.ID = producto.ID)
            If productoExistente IsNot Nothing Then
                ' 2. Si el producto ya existe, actualiza la cantidad y el total
                productoExistente.Cantidad += producto.Cantidad

                ' Notificar al BindingSource que un elemento fue modificado
                binCaja.ResetBindings(False)
            Else
                prodList.Add(producto)
                binCaja.ResetBindings(False)
            End If

            TXT_BuscarProducto.Clear()
            TXT_BuscarProducto.Focus()
            ValidarListView()
            getTotal()
        End Sub

        Private Sub EditProduct(newProd As Cls_ProductoCaja, index As Integer)

            If index >= 0 Then
                ' 2. Reemplazar el objeto antiguo en la lista con el objeto nuevo
                prodList(index) = newProd

                ' 3. Notificar al BindingSource
                '    Usamos ResetItem(index) para que el BindingSource solo recargue esa fila.
                binCaja.ResetItem(index)

                ' Acciones posteriores
                GetTotal()
            Else
                msgError($"No se encontró el producto con ID {newProd.ID}.")
            End If
        End Sub

        Private Sub GetTotal()
            totalCaja = 0
            For Each producto As Cls_ProductoCaja In prodList
                totalCaja += producto.Total
            Next
            TXT_Total.Text = totalCaja.ToString("C", culturaCR)
        End Sub

        Private Sub TXT_BuscarProducto_TextChanged(sender As Object, e As EventArgs) Handles TXT_BuscarProducto.TextChanged
            If Not String.IsNullOrEmpty(TXT_BuscarProducto.Text) Then
                BTN_NProd.Enabled = True
            Else
                BTN_NProd.Enabled = False
            End If
        End Sub

        Friend Sub ValidarListView()
            itemCount = prodList.Count
            If itemCount >= 1 Then
                BTN_TVenta.Enabled = True
                BTN_GuardarCuenta.Enabled = True
                MNU_CONTX.Enabled = True
            Else
                BTN_GuardarCuenta.Enabled = False
                BTN_TVenta.Enabled = False
                MNU_CONTX.Enabled = False
            End If
        End Sub

        Private Sub DGV_Caja_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGV_Caja.CellClick
            ' Validar que el clic no fue en el encabezado de las columnas
            If e.RowIndex >= 0 Then
                ' Obtener la fila en la que se hizo clic
                Dim filaSeleccionada As DataGridViewRow = DGV_Caja.Rows(e.RowIndex)

                ' Asegurar que la celda 4 exista en la fila
                If filaSeleccionada.Cells.Count > 5 Then
                    ' Seleccionar la celda en la columna 4
                    filaSeleccionada.Cells("Cantidad").Selected = True

                    ' Poner el DGV en modo de edición y activar la celda 4
                    DGV_Caja.CurrentCell = filaSeleccionada.Cells("Cantidad")
                    DGV_Caja.BeginEdit(True)
                End If
            End If
        End Sub

        Private Sub DGV_Caja_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles DGV_Caja.CellEndEdit
            ' Nos aseguramos de que no estamos en una fila de encabezado, ni la fila de inserción, y que hay un objeto
            If e.RowIndex < 0 OrElse e.RowIndex >= prodList.Count Then
                getTotal()
                TXT_BuscarProducto.Focus()
                Exit Sub
            End If

            Dim productoAEditar As Cls_ProductoCaja = prodList(e.RowIndex)
            Dim valorCelda As Object = DGV_Caja.Rows(e.RowIndex).Cells("Cantidad").Value
            Dim nuevaCantidad As Integer = 0

            If valorCelda Is Nothing OrElse Not Integer.TryParse(valorCelda.ToString(), nuevaCantidad) Then
                ' Restaurar el valor antiguo del DGV usando el BindingSource.
                binCaja.ResetItem(e.RowIndex)
                msgError("El valor ingresado debe ser un número entero válido para la cantidad.")
                Return
            End If

            productoAEditar.Cantidad = nuevaCantidad

            binCaja.ResetItem(e.RowIndex)

            ' Recalcula el total de la factura
            getTotal()
        End Sub

        Private Sub DGV_Caja_CellValidated(sender As Object, e As DataGridViewCellEventArgs) Handles DGV_Caja.CellValidated

            ' 1. Verificamos que se editó la celda de Cantidad
            Dim colName As String = DGV_Caja.Columns(e.ColumnIndex).Name

            If colName = "Cantidad" Then
                ' 2. Forzamos el enfoque del TextBox. 
                ' Usamos BeginInvoke para asegurarnos de que se ejecute al final de la cola de eventos.
                Me.BeginInvoke(Sub()
                                   TXT_BuscarProducto.Focus()
                                   TXT_BuscarProducto.SelectAll()
                               End Sub)
            End If
        End Sub

        Private Sub MNU_MODIFICAR_Click(sender As Object, e As EventArgs) Handles MNU_MODIFICAR.Click
            'Si no hay una fila seleccionada o si la fila selecionada es la fila nueva se devuelve un error indicando que debe de seleccionar una fila
            If DGV_Caja.SelectedRows.Count <= 0 Or DGV_Caja.SelectedRows(0).IsNewRow Then
                msgError("Se debe de seleccionar un producto, no se puede modificar una fila vacía")
                Return
            End If

            Using searchProd As New B_Producto
                searchProd.ModProd = True
                searchProd.producto = New Cls_ProductoCaja With {
                    .ID = DGV_Caja.SelectedRows(0).Cells("ID").Value,
                    .Producto = DGV_Caja.SelectedRows(0).Cells("Producto").Value,
                    .Cantidad = DGV_Caja.SelectedRows(0).Cells("Cantidad").Value,
                    .Codigo = DGV_Caja.SelectedRows(0).Cells("Codigo").Value,
                    .Precio = DGV_Caja.SelectedRows(0).Cells("Precio").Value
                }
                searchProd.idModProd = DGV_Caja.SelectedRows(0).Cells("ID").Value.ToString()
                Dim result As DialogResult = searchProd.ShowDialog()
                If result = DialogResult.OK Then
                    EditProduct(searchProd.producto, DGV_Caja.SelectedRows(0).Index)
                End If
            End Using

            ValidarListView()
            getTotal()
        End Sub

        Private Sub MNU_ELIMINAR_Click(sender As Object, e As EventArgs) Handles MNU_ELIMINAR.Click
            'Si no hay una fila seleccionada o si la fila selecionada es la fila nueva se devuelve un error indicando que debe de seleccionar una fila
            If DGV_Caja.SelectedRows.Count <= 0 Or DGV_Caja.SelectedRows(0).IsNewRow Then
                msgError("Se debe de seleccionar un producto, no se puede modificar una fila vacía")
                Exit Sub
            End If

            binCaja.RemoveCurrent()

            ValidarListView()
            getTotal()
        End Sub


#End Region

#Region "Cuentas por cobrar"

        ' En el formulario P_Caja (archivo P_Caja.vb)
        Public Sub CargarFacturaDesdeCuentas(productos As DataTable, num_factura As String, totalFactura As Double, idEncabezadoCC As String, idCliente As String, comentario As String)
            ' 1. Limpia los datos de la venta actual
            Me.LIMPIAR()

            ' 2. Asigna las variables de la clase con los datos de la factura
            Me.totalCaja = totalFactura
            Me.idEncabezadoCC = idEncabezadoCC
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

                Dim repetido = False
                For i = 0 To DGV_Caja.Rows.Count - 1
                    Dim id = DGV_Caja.Rows(i).Cells(0).Value
                    If id = fila.Item("ID_Producto") Then
                        Dim cantidadActual As Integer = Convert.ToInt32(DGV_Caja.Rows(i).Cells(4).Value)
                        cantidadActual += Convert.ToInt32(fila.Item("cant"))
                        DGV_Caja.Rows(i).Cells(4).Value = cantidadActual.ToString()
                        Dim subtotalActual As Double = Convert.ToDouble(DGV_Caja.Rows(i).Cells(3).Value) * cantidadActual
                        DGV_Caja.Rows(i).Cells(5).Value = subtotalActual
                        repetido = True
                        Continue For
                    End If
                Next

                ' Agregar la fila al DataGridView
                If Not repetido Then
                    Me.DGV_Caja.Rows.Add(idProd, codigoProd, nombreProd, precioVenta, cantidad, Convert.ToDouble(precioVenta) * Convert.ToDouble(cantidad))
                End If
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
        Private Sub BTN_RegresarCaja_Click(sender As Object, e As EventArgs) Handles BTN_RegresarCaja.Click
            ' Se incia la navegación hacia el formulario de inicio
            isNavigating = True
            M_Inicio.Show()
            Me.Close()
        End Sub

        Private Sub BTN_CuentaCobrar_Click(sender As Object, e As EventArgs) Handles BTN_CuentaCobrar.Click
            ' Establece P_Caja (Me) como el dueño de frmCuentasCobrar
            Dim frmCuentasCobrar As New P_CuentasCobrar With {.Owner = Me}
            isDialogOpen = True
            ' Muestra el formulario de cuentas por cobrar
            frmCuentasCobrar.Show()
            Me.Hide()
        End Sub

        Private Async Sub BTN_GuardarCuenta_Click(sender As Object, e As EventArgs) Handles BTN_GuardarCuenta.Click
            If DGV_Caja.Rows.Count <= 0 Then
                msgError("No se puede Guardar una factura vacía")
                Exit Sub
            End If
            Using dlg As New D_GuardarCuenta()
                isDialogOpen = True
                ' Muestra el diálogo
                Dim result As DialogResult = dlg.ShowDialog()

                ' Verifica el resultado del dialogo
                If result = DialogResult.OK Then
                    Console.WriteLine("Se presionó el botón OK")
                    Comentario = dlg.ComentarioIngresado

                    'Se obtiene la lista de productos
                    Dim listaProductos As New List(Of Cls_DetalleProductoCxC)
                    For Each row As DataGridViewRow In DGV_Caja.Rows
                        Dim prod As New Cls_DetalleProductoCxC With {
                            .ID = row.Cells("ID").Value,
                            .Cantidad = row.Cells("Cantidad").Value,
                            .Precio = row.Cells("Precio").Value
                        }

                        listaProductos.Add(prod)
                    Next

                    'Se crea el objeto de la nueva cuenta por cobrar con los datos básicos
                    Dim cuentaXCobrar As New Cls_CuentasXCobrar With {
                        .ID_Cliente = idCliente,
                        .Fecha_creacion = DateTime.Now,
                        .Saldo_total = totalCaja,
                        .Comentario = Comentario,
                        .ListaPagos = New List(Of Cls_CxCPagos),
                        .ListaProductos = listaProductos
                    }

                    'Se Guarda el resultado del return de la función de guardado, si es una actualización o un guardado nuevo y la lista de productos
                    Dim resultado As String = Await cuentaXCobrar.AgregarActualizarCuenta(False)
                    'Si devuelve OK la acción de guardado se limpia la información se cierra el dialogo y se termina la ejecución de la función
                    If resultado Is "OK" Then
                        LIMPIAR()
                        mensaje("Cuenta por cobrar guardada correctamente en la base de datos", vbOKOnly, "Cuenta por cobrar guardada")
                        Exit Sub
                    End If
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
        End Sub

        Private Async Sub BTN_TVenta_Click(sender As Object, e As EventArgs) Handles BTN_TVenta.Click
            Using endVentaForm As New P_TerminarVenta
                endVentaForm.Owner = Me
                If DGV_Caja.Rows.Count < 1 Then
                    Exit Sub
                End If

                endVentaForm.venta = New Cls_Ventas With {
                    .ID = OBTENERPK("factura", "ID"),
                    .ID_Cliente = idCliente,
                    .ID_Cajero = idUsu,
                    .Fecha_creacion = Date.Now,
                    .ListaProductos = prodList,
                    .Saldo_total = totalCaja,
                    .Num_factura = NumFactura,
                    .Tipo_pago = 1,
                    .Excluir_de_cierre = 0
                }
                endVentaForm.isCuentaPorCobrar = False

                'Se pasa el datagrid completo para obtener los datos
                Dim result As DialogResult = endVentaForm.ShowDialog()
                If result = DialogResult.Cancel Then
                    Exit Sub
                End If

                If Await endVentaForm.venta.GuardarFactura(endVentaForm.imprimir_factura) Then
                    ' Limpia la interfaz de la caja y la prepara para una nueva venta
                    LIMPIAR()
                    CargarNumFactura()
                    Me.Refresh()
                    BTN_GuardarCuenta.Text = "[F6] Guardar cuenta"

                    Mensaje("Vuelto: ₡ " & endVentaForm.venta.Vuelto, vbOKOnly, "Venta completada")
                    TXT_BuscarProducto.Select()
                    TXT_BuscarProducto.SelectAll()
                End If
            End Using
        End Sub

        Private Sub BTN_DelFactura_Click(sender As Object, e As EventArgs) Handles BTN_DelFactura.Click
            LIMPIAR()
        End Sub

        Private Sub BTN_ConfigCaja_Click(sender As Object, e As EventArgs) Handles BTN_ConfigCaja.Click
            entrarConfig(4, Me)
        End Sub

        Private Sub P_Caja_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
            Select Case e.KeyCode
                Case Keys.F1
                    BTN_Reprint.PerformClick()
                Case Keys.F2
                    BTN_RegistrarIngreso.PerformClick()
                Case Keys.F3
                    BTN_TVenta.PerformClick()
                Case Keys.F4
                    BTN_AperturaCaja.PerformClick()
                Case Keys.F5
                    BTN_RegistrarSalida.PerformClick()
                Case Keys.F6
                    BTN_CierreCaja.PerformClick()
                Case Keys.F7
                    BTN_RegresarCaja.PerformClick()
                Case Keys.F8
                    BTN_CuentaCobrar.PerformClick()
                Case Keys.F9
                    BTN_GuardarCuenta.PerformClick()
            End Select
        End Sub
#End Region

#Region "Busquedas"
        Private Sub TXT_BuscarCliente_DoubleClick(sender As Object, e As EventArgs) Handles TXT_BuscarCliente.DoubleClick
            Using searchCliente As New B_Cliente
                searchCliente.Owner = Me
                searchCliente.LIMPIAR()
                Dim result As DialogResult = searchCliente.ShowDialog()
                If result = DialogResult.OK Then
                    idCliente = searchCliente.DGV_BCliente.SelectedRows(0).Cells(0).Value.ToString()
                    TXT_BuscarCliente.Text = searchCliente.TXT_Nombre.Text
                End If
            End Using
        End Sub

        Private Sub TXT_BuscarProducto_DoubleClick(sender As Object, e As EventArgs) Handles TXT_BuscarProducto.DoubleClick
            Using searchProd As New B_Producto
                searchProd.Owner = Me
                searchProd.LIMPIAR()
                Dim result As DialogResult = searchProd.ShowDialog()
                If result = DialogResult.OK Then
                    AddProduct(searchProd.producto)
                End If
            End Using
        End Sub

#End Region

#Region "Movimientos caja"
        Private Sub BTN_AperturaCaja_Click(sender As Object, e As EventArgs) Handles BTN_AperturaCaja.Click
            ShowAperturaDialog(Me, New Cls_SaldoCaja)
        End Sub

        Private Sub BTN_RegistrarIngreso_Click(sender As Object, e As EventArgs) Handles BTN_RegistrarIngreso.Click
            RegistroMovimientos(True, Me)
        End Sub

        Private Sub BTN_RegistrarSalida_Click(sender As Object, e As EventArgs) Handles BTN_RegistrarSalida.Click
            RegistroMovimientos(False, Me)
        End Sub

        Private Sub BTN_CierreCaja_Click(sender As Object, e As EventArgs) Handles BTN_CierreCaja.Click
            ShowCierreDialog(Me)
        End Sub
#End Region

    End Class

End Namespace