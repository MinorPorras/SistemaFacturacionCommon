Imports System.ComponentModel
Imports System.Data.SQLite
Imports System.Globalization
Imports Guna.UI2.WinForms
Imports SistemaFacturaciónCommon.SistemaFacturacion.Data
Imports SistemaFacturaciónCommon.SistemaFacturacion.Forms
Imports SistemaFacturaciónCommon.SistemaFacturacion.Forms.Busqueda
Imports SistemaFacturaciónCommon.SistemaFacturacion.Forms.Caja
Imports SistemaFacturaciónCommon.SistemaFacturacion.Forms.Dialogos
Imports SistemaFacturaciónCommon.SistemaFacturacion.Modules

Public Class P_CajaCxC
    Private Const Provider As String = "D15"
    Friend idCuenta As Integer
    Friend Cuenta As New Cls_CuentasXCobrar
    Friend prodList As New List(Of Cls_ProductoCaja)
    Private binCaja As New BindingSource
    Private culturaCR As New CultureInfo("es-CR")



    Private Sub P_CajaCxC_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Cuenta.GetDetailsWithID(idCuenta)

        For Each prod In Cuenta.ListaProductos
            Dim producto As New Cls_ProductoCaja With {
                .ID = prod.ID,
                .Codigo = prod.Codigo,
                .Producto = prod.Nombre,
                .Precio = prod.Precio,
                .Cantidad = prod.cantidad
            }

            prodList.Add(producto)
        Next

        binCaja.DataSource = prodList
        DGV_Caja.DataSource = binCaja

        TXT_Total.Text = Cuenta.Formated_saldo_total
        TXT_BuscarCliente.Text = Cuenta.Cliente
        TXT_Comentario.Text = Cuenta.Comentario
        GetSaldoRestante()

        ' Añadir los botones de productos favoritos de forma dinpamica
        LoadBtnFav()
        LBL_Hora.Text = DateTime.Now.ToString("hh:mm:ss tt")
        LBL_Fecha.Text = DateTime.Now.ToString("dd/MM/yyyy")
        Timer1.Start()

        TXT_BuscarProducto.SelectAll()

        Dim logoPath As String = GetAppSetting("Logo")

        If Not String.IsNullOrWhiteSpace(logoPath) Then
            PIC_Logo.ImageLocation = logoPath
        Else
            PIC_Logo.Image = Nothing
            PIC_Logo.ImageLocation = ""
        End If
    End Sub

    Private Sub GetSaldoRestante()
        TXT_SaldoRestante.Text = Cuenta.Saldo_restante.ToString("C", culturaCR)
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
        GetTotal()
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
        Cuenta.Saldo_total = 0
        For Each producto As Cls_ProductoCaja In prodList
            Cuenta.Saldo_total += producto.Total
        Next
        TXT_Total.Text = Cuenta.Formated_saldo_total
        GetSaldoRestante()
    End Sub

    Private Sub TXT_BuscarProducto_TextChanged(sender As Object, e As EventArgs) Handles TXT_BuscarProducto.TextChanged
        If Not String.IsNullOrEmpty(TXT_BuscarProducto.Text) Then
            BTN_NProd.Enabled = True
        Else
            BTN_NProd.Enabled = False
        End If
    End Sub

    Friend Sub ValidarListView()
        Dim itemCount = prodList.Count
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
            GetTotal()
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
        GetTotal()
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
        GetTotal()
    End Sub

    Private Sub MNU_ELIMINAR_Click(sender As Object, e As EventArgs) Handles MNU_ELIMINAR.Click
        'Si no hay una fila seleccionada o si la fila selecionada es la fila nueva se devuelve un error indicando que debe de seleccionar una fila
        If DGV_Caja.SelectedRows.Count <= 0 Or DGV_Caja.SelectedRows(0).IsNewRow Then
            msgError("Se debe de seleccionar un producto, no se puede modificar una fila vacía")
            Exit Sub
        End If

        binCaja.RemoveCurrent()

        ValidarListView()
        GetTotal()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        BackgroundWorker1.RunWorkerAsync()
    End Sub

    Private Sub BTN_RegresarCaja_Click(sender As Object, e As EventArgs) Handles BTN_RegresarCaja.Click
        Me.DialogResult = DialogResult.Cancel
    End Sub

    Private Async Sub BTN_TVenta_Click(sender As Object, e As EventArgs)
        Using endVentaForm As New P_TerminarVenta
            endVentaForm.Owner = Me
            If DGV_Caja.Rows.Count < 1 Then
                Exit Sub
            End If

            Dim numFactura As Integer = CargarNumFactura()
            endVentaForm.venta = New Cls_Ventas With {
                .ID = OBTENERPK("factura", "ID"),
                .ID_Cliente = Cuenta.ID_Cliente,
                .ID_Cajero = idUsuActual,
                .Fecha_creacion = Date.Now,
                .ListaProductos = prodList,
                .Saldo_total = Cuenta.Saldo_total,
                .Num_factura = numFactura,
                .Tipo_pago = 1,
                .ID_CxC = idCuenta,
                .Saldo_restante = Cuenta.Saldo_restante
            }
            endVentaForm.isCuentaPorCobrar = True

            'Se pasa el datagrid completo para obtener los datos
            Dim result As DialogResult = endVentaForm.ShowDialog()
            If result = DialogResult.Cancel Then
                Me.DialogResult = DialogResult.Cancel
                Exit Sub
            End If

            If Await endVentaForm.venta.GuardarFactura(endVentaForm.imprimir_factura, True) Then
                Me.DialogResult = DialogResult.OK
            End If
        End Using
    End Sub

    Friend Function CargarNumFactura() As String
        Try
            T.Tables.Clear()
            SQL = "SELECT num_factura FROM factura ORDER BY CAST(num_factura AS INTEGER) DESC LIMIT 1;"
            Cargar_Tabla(T, SQL)
            If T.Tables(0).Rows.Count > 0 Then
                Dim NumFactura = If(IsDBNull(T.Tables(0).Rows(0).Item(0)), 1, Convert.ToInt32(T.Tables(0).Rows(0).Item(0)))
                NumFactura += 1
                Return NumFactura
            End If
            Return 0
        Catch ex As Exception
            msgError("Error al cargar el número de factura." + vbCrLf + "Error: " + ex.Message)
            Return 0
        End Try
    End Function


    Private Sub BTN_NProd_Click(sender As Object, e As EventArgs) Handles BTN_NProd.Click
        T.Tables.Clear()
        SQL = "SELECT p.ID, p.variable, v.precio_venta, p.nombre FROM producto p LEFT JOIN producto_precioVenta v ON p.ID = v.ID_Producto" +
            " WHERE p.codigo = '" & TXT_BuscarProducto.Text & "';"
        Cargar_Tabla(T, SQL)
        If T.Tables(0).Rows.Count > 0 Then
            If T.Tables(0).Rows(0).Item("variable") = 0 Then
                Buscar_DatosProd(TXT_BuscarProducto, False)
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

    Private Sub TXT_BuscarCliente_DoubleClick(sender As Object, e As EventArgs) Handles TXT_BuscarCliente.DoubleClick
        Using searchCliente As New B_Cliente
            searchCliente.Owner = Me
            searchCliente.LIMPIAR()
            Dim result As DialogResult = searchCliente.ShowDialog()
            If result = DialogResult.OK Then
                Cuenta.ID_Cliente = searchCliente.DGV_BCliente.SelectedRows(0).Cells(0).Value.ToString()
                Cuenta.Cliente = searchCliente.TXT_Nombre.Text
                TXT_BuscarCliente.Text = Cuenta.Cliente
            End If
        End Using
    End Sub

    Private Sub P_CajaCxC_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        Select Case e.KeyCode
            Case Keys.F1
                BTN_RegresarCaja.PerformClick()
            Case Keys.F2
                BTN_Abonar.PerformClick()
            Case Keys.F3
                BTN_GuardarCuenta.PerformClick()
            Case Keys.F4
                BTN_TVenta.PerformClick()
        End Select
    End Sub

    Private Sub BTN_ConfigCaja_Click(sender As Object, e As EventArgs) Handles BTN_ConfigCaja.Click
        entrarConfig(4, Me)
    End Sub

    Private Async Sub BTN_GuardarCuenta_Click(sender As Object, e As EventArgs) Handles BTN_GuardarCuenta.Click
        If prodList.Count <= 1 Then
            msgError("No se puede Guardar una factura vacía")
            Exit Sub
        End If

        If Not msgGuardar() Then
            Exit Sub
        End If
        Dim listaProds As New List(Of Cls_DetalleProductoCxC)
        For Each prod As Cls_ProductoCaja In prodList
            Dim producto As New Cls_DetalleProductoCxC With {
                .ID = prod.ID,
                .Codigo = prod.Codigo,
                .Precio = prod.Precio,
                .Cantidad = prod.Cantidad
            }
            listaProds.Add(producto)
        Next

        'Se crea el objeto de la nueva cuenta por cobrar con los datos básicos
        Dim cuentaXCobrar As New Cls_CuentasXCobrar With {
            .ID = Cuenta.ID,
            .ID_Cliente = Cuenta.ID_Cliente,
            .Fecha_creacion = Cuenta.Fecha_creacion,
            .Saldo_total = Cuenta.Saldo_total,
            .Comentario = TXT_Comentario.Text,
            .ListaPagos = New List(Of Cls_CxCPagos),
            .ListaProductos = listaProds,
            .Estado = Cuenta.Estado
        }

        Dim resultado As String = Await cuentaXCobrar.AgregarActualizarCuenta(True)

        msgDatoAlm()
    End Sub

    Private Async Sub BTN_Abonar_Click(sender As Object, e As EventArgs) Handles BTN_Abonar.Click
        Using abonarForm As New P_AbonarCxC
            abonarForm.Owner = Me
            abonarForm.venta = New Cls_Ventas With {
                .ID_CxC = Cuenta.ID,
                .ID_Cajero = idUsuActual,
                .ID_Cliente = Cuenta.ID_Cliente,
                .Fecha_creacion = Date.Now,
                .Saldo_restante = Cuenta.Saldo_restante
            }

            Dim result As DialogResult = abonarForm.ShowDialog()

            If result = DialogResult.Cancel Then
                Exit Sub
            End If

            'Pasar venta a cls_pagosCxC
            Dim abono As New Cls_CxCPagos With {
                .Fecha = Date.Now,
                .ID_CxC = Cuenta.ID,
                .ID_Usuario = idUsuActual,
                .Monto_efectivo = abonarForm.venta.Efectivo,
                .Monto_tarjeta = abonarForm.venta.Tarjeta,
                .Tipo_venta = abonarForm.venta.Tipo_pago,
                .Vuelto = abonarForm.venta.Vuelto,
                .Comentario = abonarForm.TXT_Comentario.Text
            }

            'Guardar El pago en la BD
            Dim ID_Pago = Await abono.Guardar()
            If ID_Pago = 0 Then
                msgError("Error al guardar el pago abonado a esta cuenta por cobrar")
                Exit Sub
            End If

            If abonarForm.Terminar_venta Then
                Dim numFactura As Integer = CargarNumFactura()
                Dim venta As New Cls_Ventas With {
                    .ID = OBTENERPK("factura", "ID"),
                    .ID_Cliente = Cuenta.ID_Cliente,
                    .ID_Cajero = idUsuActual,
                    .Fecha_creacion = Date.Now,
                    .ListaProductos = prodList,
                    .Saldo_total = Cuenta.Saldo_total,
                    .Num_factura = numFactura,
                    .Tipo_pago = 1,
                    .ID_CxC = idCuenta,
                    .Saldo_restante = Cuenta.Saldo_restante,
                    .Efectivo = abonarForm.venta.Efectivo,
                    .Tarjeta = abonarForm.venta.Tarjeta,
                    .Vuelto = abonarForm.venta.Vuelto
                }

                If Await venta.GuardarFactura(abonarForm.imprimir_factura, True) Then
                    Me.DialogResult = DialogResult.OK
                End If

                SwitchEstadoCuenta(Cuenta.ID, 2) ' Se pasa el estado a cobrada
                Me.DialogResult = DialogResult.OK
            Else
                'En caso de que se necesite imprimir la factura Se imprime de la siguiente forma
                Using db As New SQLiteConnection(GetConnectionString())
                    Try
                        If abonarForm.imprimir_factura Then
                            db.Open()
                            GENERAR_FACTURA(ID_Pago, "Abono")
                        End If
                    Catch ex As Exception
                        msgError($"Error al imprimir la factura: {ex.Message}")
                    Finally
                        db.Close()
                    End Try
                End Using

                binCaja.ResetBindings(False)
                Cuenta.ListaPagos = Cuenta.GetListaPagos(Cuenta.ID)
                GetSaldoRestante()
                mensaje("Vuelto: ₡ " & abonarForm.venta.Vuelto, vbOKOnly, "Venta completada")
                TXT_BuscarProducto.Select()
                TXT_BuscarProducto.SelectAll()
            End If
        End Using
    End Sub

    Friend Sub LIMPIAR()

        'Se desabilitann botones que tiene activaciones condicionales
        BTN_TVenta.Enabled = False
        BTN_GuardarCuenta.Enabled = False

        TXT_BuscarProducto.Clear()
        TXT_Total.Clear()
        TXT_BuscarCliente.Text = "0001"
        DGV_Caja.Rows.Clear()

        TXT_BuscarProducto.SelectAll()
        BTN_GuardarCuenta.Text = "[F6] Guardar cuenta"

        ValidarListView()
        GetTotal()

    End Sub
End Class