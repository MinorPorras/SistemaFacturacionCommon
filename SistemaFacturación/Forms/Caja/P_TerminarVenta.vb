Imports SistemaFacturaciónCommon.SistemaFacturacion.Modules
Imports System.Data.SQLite
Namespace SistemaFacturacion.Forms.Caja

    Public Class P_TerminarVenta
        ' Declaración de variables a nivel de la clase
        ' Estas variables se mantienen durante todo el ciclo de vida del formulario
        Friend idFactura As Integer
        Friend total As Double ' El total de la factura
        Private vuelto As Double ' El vuelto a devolver al cliente
        Private TipoPago As Integer ' El tipo de pago seleccionado (Efectivo, Tarjeta, etc.)
        Friend NumFactura As String ' El número de la factura
        Friend idCLiente As Integer ' El ID del cliente asociado a la factura
        Friend isCuentaPorCobrar As Boolean
        Friend dgvProductos As Guna.UI2.WinForms.Guna2DataGridView ' El DataGridView con los productos de la venta

        ' Variables para el contenido de la factura (impresión)
        Friend encabezadoFactura As String
        Friend encabezadoProds As String
        Friend facturaContenido As New List(Of String)()
        Friend finFactura As String

        ' Manejador del evento Load del formulario
        Private Sub P_TerminarVenta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
            ' Si no se trata de una cuenta por cobrar obtiene el próximo ID de factura disponible
            If Not isCuentaPorCobrar Then
                idFactura = OBTENERPK("factura", "ID")
            End If
            ' Valida el estado inicial del pago y habilita/deshabilita los botones de venta
            VALIDAR(TXT_ECliente, TXT_ECliente, total, False)

            ' Añade los manejadores de eventos (handlers) para los botones de "Colocar Total"
            ' Esto evita tener que crear una subrutina para cada botón y centraliza la lógica
            AddHandler BTN_EColocarTotal.Click, AddressOf ColocarTotal
            AddHandler BTN_TColocarTotal.Click, AddressOf ColocarTotal
            AddHandler BTN_SColocarTotal.Click, AddressOf ColocarTotal
            AddHandler BTN_DColocarTotal.Click, AddressOf ColocarTotal

            ' Se añade los manejadores de eventos para los botones de "Restante"
            AddHandler BTN_RestanteEfectivo.Click, AddressOf AgregarRestante
            AddHandler BTN_RestanteTarjeta.Click, AddressOf AgregarRestante

            ' Añade los manejadores de eventos para los cambios en los TextBox de pago
            ' Esto asegura que el cálculo del vuelto y la validación se actualicen automáticamente
            AddHandler TXT_ECliente.TextChanged, AddressOf RecalcularVueltoYValidar
            AddHandler TXT_TCliente.TextChanged, AddressOf RecalcularVueltoYValidar
            AddHandler TXT_SCliente.TextChanged, AddressOf RecalcularVueltoYValidar
            AddHandler TXT_DCliente.TextChanged, AddressOf RecalcularVueltoYValidar
            AddHandler TXT_PagoTarjeta.TextChanged, AddressOf RecalcularVueltoYValidar
            AddHandler TXT_PagoEfectivo.TextChanged, AddressOf RecalcularVueltoYValidar
        End Sub

        ' Manejador de evento unificado para los botones de "Colocar Total"
        ' "sender" es el botón que ha sido presionado
        Private Sub ColocarTotal(sender As Object, e As EventArgs)
            ' Convierte el objeto sender al tipo de control Guna2Button
            Dim btn As Guna.UI2.WinForms.Guna2Button = CType(sender, Guna.UI2.WinForms.Guna2Button)

            ' Usa un Select Case para identificar qué botón se hizo clic y actualizar el TextBox correcto
            Select Case btn.Name
                Case "BTN_EColocarTotal"
                    TXT_ECliente.Text = total
                Case "BTN_TColocarTotal"
                    TXT_TCliente.Text = total
                Case "BTN_SColocarTotal"
                    TXT_SCliente.Text = total
                Case "BTN_DColocarTotal"
                    TXT_DCliente.Text = total
            End Select
        End Sub

        ' Manejador de evento unificado para los cambios en los TextBox de pago
        Private Sub RecalcularVueltoYValidar(sender As Object, e As EventArgs)
            ' Convierte el objeto sender al tipo de control Guna2TextBox
            Dim txt As Guna.UI2.WinForms.Guna2TextBox = CType(sender, Guna.UI2.WinForms.Guna2TextBox)

            ' Usa un Select Case para determinar qué TextBox se modificó
            Select Case txt.Name
                Case "TXT_ECliente"
                    CalcVuelto(TXT_ECliente, TXT_EVuelto)
                    VALIDAR(TXT_ECliente, TXT_ECliente, total, False)
                Case "TXT_TCliente"
                    CalcVuelto(TXT_TCliente, TXT_TVuelto)
                    VALIDAR(TXT_TCliente, TXT_TCliente, total, False)
                Case "TXT_SCliente"
                    CalcVuelto(TXT_SCliente, TXT_SVuelto)
                    VALIDAR(TXT_SCliente, TXT_SCliente, total, False)
                Case "TXT_DCliente"
                    CalcVuelto(TXT_DCliente, TXT_DVuelto)
                    VALIDAR(TXT_DCliente, TXT_DCliente, total, False)
                Case "TXT_PagoTarjeta", "TXT_PagoEfectivo"
                    ' El cálculo para el pago mixto se maneja con ambos TextBox
                    CalcVuelto(TXT_DCliente, TXT_MVuelto) ' Se usa TXT_DCliente como placeholder para la primera caja, ya que su valor no es relevante aquí
                    VALIDAR(TXT_PagoTarjeta, TXT_PagoEfectivo, total, True)
            End Select
        End Sub

        ' Calcula el vuelto basado en el monto entregado por el cliente
        Private Sub CalcVuelto(txtEntregaCliente As Guna.UI2.WinForms.Guna2TextBox, txtVuelto As Guna.UI2.WinForms.Guna2TextBox)
            Dim eCliente As Double
            Dim eCliente2 As Double

            ' Lógica para tipos de pago no mixtos (Efectivo, Tarjeta, Sinpe, Depósito)
            If Not TabControlTVenta.SelectedIndex = 4 Then
                If Double.TryParse(txtEntregaCliente.Text, eCliente) Then
                    vuelto = eCliente - total
                    If vuelto > 0 Then
                        txtVuelto.Text = vuelto.ToString()
                    Else
                        txtVuelto.Text = "0"
                    End If
                End If
            Else ' Lógica para el pago mixto
                If Double.TryParse(TXT_PagoTarjeta.Text, eCliente) AndAlso Double.TryParse(TXT_PagoEfectivo.Text, eCliente2) Then
                    Dim EntregaCliente As Double = eCliente + eCliente2
                    vuelto = EntregaCliente - total
                    If vuelto > 0 Then
                        txtVuelto.Text = vuelto.ToString()
                    Else
                        txtVuelto.Text = "0"
                    End If
                End If
            End If
        End Sub

        ' Valida si el monto de pago es suficiente para habilitar los botones de venta
        Private Sub VALIDAR(txtEntregaCliente As Guna.UI2.WinForms.Guna2TextBox, txtEntregaCliente2 As Guna.UI2.WinForms.Guna2TextBox, Total As Double, mixto As Boolean)
            Try
                ' Si el TextBox principal está vacío, lo inicializa a 0 para evitar errores de conversión
                If String.IsNullOrEmpty(txtEntregaCliente.Text) Then
                    txtEntregaCliente.Text = 0
                End If

                If mixto Then ' Lógica de validación para pago mixto
                    If String.IsNullOrEmpty(txtEntregaCliente2.Text) Then
                        txtEntregaCliente2.Text = 0
                    End If

                    If Convert.ToDouble(txtEntregaCliente.Text) + Convert.ToDouble(txtEntregaCliente2.Text) >= Total Then
                        BTN_TVenta.Enabled = True
                        BTN_TVentaImp.Enabled = True
                    Else
                        BTN_TVenta.Enabled = False
                        BTN_TVentaImp.Enabled = False
                    End If
                Else ' Lógica de validación para pagos únicos
                    If Convert.ToDouble(txtEntregaCliente.Text) >= Total Then
                        BTN_TVenta.Enabled = True
                        BTN_TVentaImp.Enabled = True
                    Else
                        BTN_TVenta.Enabled = False
                        BTN_TVentaImp.Enabled = False
                    End If
                End If
            Catch ex As Exception
                MsgBox("Error: " & ex.Message, vbCritical + vbOKOnly, "Error")
            End Try
        End Sub

#Region "TerminarVenta_ImprimirFactura"
        Private Async Function GuardarFacturaDB(idFactura As Integer, NumFactura As Integer, idCliente As Integer, idUsu As Integer, total As Double, efectivo As Double, tarjeta As Double, vuelto As Double, TipoPago As Integer, comentario As String, esCuentaPorCobrar As Boolean) As Task(Of String)
            Return Await Task.Run(Function()

                                      Using db As New SQLiteConnection(GetConnectionString())
                                          db.Open()
                                          Dim transaction As SQLiteTransaction = db.BeginTransaction()

                                          Try
                                              ' 1. Guardar o actualizar la factura principal.
                                              GuardarOActualizarFactura(db, transaction, idFactura, NumFactura, idCliente, idUsu, total, efectivo, tarjeta, vuelto, TipoPago, esCuentaPorCobrar)

                                              ' 2. Guardar los productos y actualizar el inventario.
                                              GuardarProductos(db, transaction, idFactura)

                                              ' 3. Guardar el comentario.
                                              GuardarComentario(db, transaction, idFactura, comentario)

                                              transaction.Commit()
                                              Return "OK"

                                          Catch ex As Exception
                                              transaction.Rollback()
                                              Return "Error en la transacción: " & ex.Message
                                          End Try
                                      End Using
                                  End Function)
        End Function

        ' Guarda o actualiza los datos principales de la factura.
        Private Sub GuardarOActualizarFactura(db As SQLiteConnection, transaction As SQLiteTransaction, idFactura As Integer, NumFactura As Integer, idCliente As Integer, idUsu As Integer, total As Double, efectivo As Double, tarjeta As Double, vuelto As Double, TipoPago As Integer, esCuentaPorCobrar As Boolean)
            If esCuentaPorCobrar Then
                Dim updateFacturaSQL As String = "UPDATE factura SET 
            fecha_emision = @fecha, 
            total = @total, 
            efectivo_cliente = @efectivo, 
            tarjeta_cliente = @tarjeta, 
            vuelto = @vuelto, 
            tipo_venta = @tipo_venta, 
            cobrada = 1 
            WHERE ID = @id"
                Using cmd As New SQLiteCommand(updateFacturaSQL, db, transaction)
                    cmd.Parameters.AddWithValue("@id", idFactura)
                    cmd.Parameters.AddWithValue("@fecha", DateTime.Now)
                    cmd.Parameters.AddWithValue("@total", total)
                    cmd.Parameters.AddWithValue("@efectivo", efectivo)
                    cmd.Parameters.AddWithValue("@tarjeta", tarjeta)
                    cmd.Parameters.AddWithValue("@vuelto", vuelto)
                    cmd.Parameters.AddWithValue("@tipo_venta", TipoPago)
                    cmd.ExecuteNonQuery()
                End Using
            Else
                Dim insertFacturaSQL As String = "INSERT INTO factura 
            (ID, num_factura, fecha_emision, ID_Cliente, ID_usuario, total, efectivo_cliente, tarjeta_cliente, vuelto, tipo_venta, cobrada) 
            VALUES (@id, @num_factura, @fecha, @idCliente, @idUsu, @total, @efectivo, @tarjeta, @vuelto, @tipo_venta, 1)"
                Using cmd As New SQLiteCommand(insertFacturaSQL, db, transaction)
                    cmd.Parameters.AddWithValue("@id", idFactura)
                    cmd.Parameters.AddWithValue("@num_factura", NumFactura)
                    cmd.Parameters.AddWithValue("@fecha", DateTime.Now)
                    cmd.Parameters.AddWithValue("@idCliente", idCliente)
                    cmd.Parameters.AddWithValue("@idUsu", idUsu)
                    cmd.Parameters.AddWithValue("@total", total)
                    cmd.Parameters.AddWithValue("@efectivo", efectivo)
                    cmd.Parameters.AddWithValue("@tarjeta", tarjeta)
                    cmd.Parameters.AddWithValue("@vuelto", vuelto)
                    cmd.Parameters.AddWithValue("@tipo_venta", TipoPago)
                    cmd.ExecuteNonQuery()
                End Using
            End If
        End Sub

        ' Elimina los productos anteriores y guarda los nuevos, actualizando el inventario.
        ' Elimina los productos anteriores y guarda los nuevos, actualizando el inventario.
        Private Sub GuardarProductos(db As SQLiteConnection, transaction As SQLiteTransaction, idFactura As Integer)
            Dim deleteProductosSQL As String = "DELETE FROM factura_producto WHERE ID_Factura = @idFactura"
            Using cmd As New SQLiteCommand(deleteProductosSQL, db, transaction)
                cmd.Parameters.AddWithValue("@idFactura", idFactura)
                cmd.ExecuteNonQuery()
            End Using

            ' Recorre las filas de la DataGridView. Se usa dgvProductos.Rows.Count - 2 para evitar la fila vacía de "nueva entrada".
            For i As Integer = 0 To dgvProductos.Rows.Count - 2
                ' Obtiene los valores de las celdas directamente del DataGridView pasado como argumento.
                Dim productoID As Integer = Convert.ToInt32(dgvProductos.Rows(i).Cells(0).Value)
                Dim cantidad As Integer = Convert.ToInt32(dgvProductos.Rows(i).Cells(4).Value)
                Dim precioVenta As Double = Convert.ToDouble(dgvProductos.Rows(i).Cells(3).Value)

                Dim insertProductoSQL As String = "INSERT INTO factura_producto (ID_Factura, ID_Producto, cant, precio_venta) VALUES (@idFactura, @idProducto, @cantidad, @precioVenta)"
                Using cmd As New SQLiteCommand(insertProductoSQL, db, transaction)
                    cmd.Parameters.AddWithValue("@idFactura", idFactura)
                    cmd.Parameters.AddWithValue("@idProducto", productoID)
                    cmd.Parameters.AddWithValue("@cantidad", cantidad)
                    cmd.Parameters.AddWithValue("@precioVenta", precioVenta)
                    cmd.ExecuteNonQuery()
                End Using

                Dim updateInventarioSQL As String = "UPDATE producto SET inventario = inventario - @cantidad WHERE ID = @idProducto"
                Using cmd As New SQLiteCommand(updateInventarioSQL, db, transaction)
                    cmd.Parameters.AddWithValue("@cantidad", cantidad)
                    cmd.Parameters.AddWithValue("@idProducto", productoID)
                    cmd.ExecuteNonQuery()
                End Using
            Next
        End Sub

        ' Guarda o actualiza el comentario de la factura.
        Private Sub GuardarComentario(db As SQLiteConnection, transaction As SQLiteTransaction, idFactura As Integer, comentario As String)
            Dim countComentario As Integer = 0
            Using cmd As New SQLiteCommand("SELECT COUNT(*) FROM factura_comentario WHERE ID_Factura = @idFactura", db, transaction)
                cmd.Parameters.AddWithValue("@idFactura", idFactura)
                countComentario = Convert.ToInt32(cmd.ExecuteScalar())
            End Using

            If countComentario > 0 Then
                Using cmd As New SQLiteCommand("UPDATE factura_comentario SET comentario = @comentario WHERE ID_Factura = @idFactura", db, transaction)
                    cmd.Parameters.AddWithValue("@comentario", comentario)
                    cmd.Parameters.AddWithValue("@idFactura", idFactura)
                    cmd.ExecuteNonQuery()
                End Using
            ElseIf Not String.IsNullOrEmpty(comentario) Then
                Using cmd As New SQLiteCommand("INSERT INTO factura_comentario (ID_Factura, comentario) VALUES (@idFactura, @comentario)", db, transaction)
                    cmd.Parameters.AddWithValue("@comentario", comentario)
                    cmd.Parameters.AddWithValue("@idFactura", idFactura)
                    cmd.ExecuteNonQuery()
                End Using
            End If
        End Sub

        ' Subrutina principal para guardar la factura
        Private Async Sub GuardarFactura(txtTotal As Guna.UI2.WinForms.Guna2TextBox, txtEntregaCliente As Guna.UI2.WinForms.Guna2TextBox,
                                         txtVuelto As Guna.UI2.WinForms.Guna2TextBox, imprimir As Boolean, esCuentaPorCobrar As Boolean,
                                         TipoPago As Integer)
            If MsgBox("¿Desea terminar la venta?", vbOKCancel + vbDefaultButton1, "Confirmar") = MsgBoxResult.Cancel Then
                Return
            End If

            If P_Caja.DGV_Caja.Rows.Count <= 1 Then
                msgError("No se puede Guardar una factura vacía.")
                Return
            End If

            Try
                Dim tarjeta As Double
                Dim efectivo As Double
                ' Asigna los montos de pago según el tipo de pago
                If TipoPago = 4 Then
                    efectivo = Convert.ToDouble(TXT_PagoEfectivo.Text)
                    tarjeta = Convert.ToDouble(TXT_PagoTarjeta.Text)
                ElseIf TipoPago = 1 Or TipoPago = 2 Or TipoPago = 3 Then
                    tarjeta = Convert.ToDouble(txtEntregaCliente.Text)
                    efectivo = 0
                Else
                    efectivo = Convert.ToDouble(txtEntregaCliente.Text)
                    tarjeta = 0
                End If
                Dim vuelto As Double = Convert.ToDouble(txtVuelto.Text)
                Dim total As Double = Convert.ToDouble(txtTotal.Text.Replace("₡ ", ""))
                Dim comentario As String = TXT_Comentario.Text

                Dim resultado As String = Await GuardarFacturaDB(idFactura, NumFactura, idCLiente, P_Caja.idUsu, total, efectivo, tarjeta, vuelto, TipoPago, comentario, esCuentaPorCobrar)
                'Si dió algún tipo de error al guardar la factura, se muestra el mensaje y se sale del sub
                If resultado <> "OK" Then
                    msgError("Error al guardar la factura: " & resultado)
                    Return
                End If

                ' Si se seleccionó la opción de imprimir, genera e imprime la factura
                If imprimir Then
                    GENERAR_FACTURA(idFactura)
                End If

                ' Limpia la interfaz de la caja y la prepara para una nueva venta
                P_Caja.LIMPIAR()
                P_Caja.CargarNumFactura()
                P_Caja.Show()
                P_Caja.Refresh()
                P_Caja.Select()
                P_Caja.BTN_GuardarCuenta.Text = "[F6] Guardar cuenta"

                mensaje("Vuelto: ₡ " & vuelto, vbOKOnly, "Venta completada")
                P_Caja.TXT_BuscarProducto.Select()
                P_Caja.TXT_BuscarProducto.SelectAll()
                Me.Close()
            Catch ex As Exception
                msgError("Error: " & ex.Message)
            End Try
        End Sub

        Private Sub TerminarVenta(imprimir As Boolean)
            Dim TipoPago As Integer = TabControlTVenta.SelectedIndex
            Select Case TipoPago
                Case 0 ' Efectivo
                    GuardarFactura(TXT_ETotal, TXT_ECliente, TXT_EVuelto, imprimir, isCuentaPorCobrar, TipoPago)
                Case 1 ' Tarjeta
                    GuardarFactura(TXT_TTotal, TXT_TCliente, TXT_TVuelto, imprimir, isCuentaPorCobrar, TipoPago)
                Case 2 ' Sinpe
                    GuardarFactura(TXT_STotal, TXT_SCliente, TXT_SVuelto, imprimir, isCuentaPorCobrar, TipoPago)
                Case 3 ' Depósito
                    GuardarFactura(TXT_DTotal, TXT_DCliente, TXT_DVuelto, imprimir, isCuentaPorCobrar, TipoPago)
                Case 4 ' Mixto
                    GuardarFactura(TXT_MTotal, TXT_PagoEfectivo, TXT_MVuelto, imprimir, isCuentaPorCobrar, TipoPago)
            End Select
        End Sub

        Private Sub BTN_TVenta_Click(sender As Object, e As EventArgs) Handles BTN_TVenta.Click
            TerminarVenta(False)
        End Sub

        Private Sub BTN_TVentaImp_Click(sender As Object, e As EventArgs) Handles BTN_TVentaImp.Click
            TerminarVenta(True)
        End Sub
#End Region

        ' Manejador del clic para el botón "Regresar Venta"
        Private Sub BTN_RegresarVenta_Click(sender As Object, e As EventArgs) Handles BTN_RegresarVenta.Click
            P_Caja.Select()
            P_Caja.TXT_BuscarProducto.Select()
            P_Caja.TXT_BuscarProducto.SelectAll()
            Me.Close()
        End Sub

        ' Manejador del cambio de pestaña en el TabControl
        Private Sub TabControlTVenta_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TabControlTVenta.SelectedIndexChanged
            LIMPIAR()
        End Sub

        Friend Sub LIMPIAR()
            ' Obtener la letra identificadora de la pestaña actual (E, T, S, D, M)
            Dim tipoPago As Integer = TabControlTVenta.SelectedIndex
            Dim prefijoActivo As String
            Select Case tipoPago
                Case 0 ' Efectivo
                    prefijoActivo = "E"
                Case 1 ' Tarjeta
                    prefijoActivo = "T"
                Case 2 ' Sinpe
                    prefijoActivo = "S"
                Case 3 ' Depósito
                    prefijoActivo = "D"
                Case 4 ' Mixto
                    ' Para el pago mixto, los prefijos son "PagoEfectivo", "PagoTarjeta" y "M" para el vuelto
                    prefijoActivo = "Pago" ' Usaremos un prefijo que capture ambos
                Case Else
                    prefijoActivo = ""
            End Select

            ' Recorrer todos los TextBox y limpiarlos, excepto los de la pestaña activa
            Dim txtsToClear As New List(Of Guna.UI2.WinForms.Guna2TextBox) From {
                TXT_ECliente, TXT_EVuelto,
                TXT_TCliente, TXT_TVuelto,
                TXT_SCliente, TXT_SVuelto,
                TXT_DCliente, TXT_DVuelto,
                TXT_PagoEfectivo, TXT_PagoTarjeta, TXT_MVuelto
            }

            For Each txt As Guna.UI2.WinForms.Guna2TextBox In txtsToClear
                ' Si la pestaña es Mixto, limpia los campos que no tienen los prefijos de Mixto
                If tipoPago = 4 Then
                    If Not txt.Name.StartsWith("TXT_Pago") AndAlso Not txt.Name.StartsWith("TXT_M") Then
                        txt.Text = "0"
                    End If
                Else
                    ' Si el prefijo del nombre del TextBox no coincide con el prefijo de la pestaña activa
                    If Not txt.Name.StartsWith("TXT_" & prefijoActivo) Then
                        txt.Text = "0"
                    End If
                End If
            Next

            ' Finalmente, enfocarse en el TextBox correcto de la pestaña activa y seleccionar su texto
            Select Case tipoPago
                Case 0 ' Efectivo
                    TXT_ECliente.Select()
                    TXT_ECliente.SelectAll()
                Case 1 ' Tarjeta
                    TXT_TCliente.Select()
                    TXT_TCliente.SelectAll()
                Case 2 ' Sinpe
                    TXT_SCliente.Select()
                    TXT_SCliente.SelectAll()
                Case 3 ' Depósito
                    TXT_DCliente.Select()
                    TXT_DCliente.SelectAll()
                Case 4 ' Mixto
                    TXT_PagoEfectivo.Select()
                    TXT_PagoEfectivo.SelectAll()
            End Select
        End Sub

        ' Calcula el monto restante para pago mixto
        Private Function CargarRestante(efectivo As Boolean) As Double
            ' Si los campos están vacíos, los inicializa a 0
            If String.IsNullOrEmpty(TXT_PagoEfectivo.Text) Then
                TXT_PagoEfectivo.Text = 0
            End If
            If String.IsNullOrEmpty(TXT_PagoTarjeta.Text) Then
                TXT_PagoTarjeta.Text = 0
            End If

            Dim restante As Double
            Dim pEfectivo As Double = Convert.ToDouble(TXT_PagoEfectivo.Text)
            Dim pTarjeta As Double = Convert.ToDouble(TXT_PagoTarjeta.Text)

            If efectivo Then ' Si el botón de efectivo restante fue presionado
                restante = total - pTarjeta
                If restante < 0 Then
                    restante = 0
                End If
                Return restante
            Else ' Si el botón de tarjeta restante fue presionado
                restante = total - pEfectivo
                If restante < 0 Then
                    restante = 0
                End If
                Return restante
            End If

        End Function

        'Se agrega el restante al campo correspondiente
        Private Sub AgregarRestante(sender As Object, e As EventArgs)
            ' Convierte el objeto sender al tipo de control Guna2Button
            Dim btn As Guna.UI2.WinForms.Guna2Button = CType(sender, Guna.UI2.WinForms.Guna2Button)
            ' Usa un Select Case para identificar qué botón se hizo clic y actualizar el TextBox correcto
            Select Case btn.Name
                Case "BTN_RestanteTarjeta"
                    TXT_PagoTarjeta.Text = CargarRestante(False)
                Case "BTN_RestanteEfectivo"
                    TXT_PagoEfectivo.Text = CargarRestante(True)
            End Select
            ' Recalcula el vuelto y valida los montos después de agregar el restante
            CalcVuelto(TXT_DCliente, TXT_MVuelto)
            VALIDAR(TXT_PagoTarjeta, TXT_PagoEfectivo, total, True)
        End Sub

        ' Manejador de eventos de teclado para atajos de teclado
        Private Sub P_TerminarVenta_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
            Select Case e.KeyCode
                Case Keys.F3
                    BTN_RegresarVenta.PerformClick()
                Case Keys.F7
                    BTN_TVenta.PerformClick()
                Case Keys.F4
                    BTN_TVentaImp.PerformClick()
            End Select
        End Sub
    End Class

End Namespace