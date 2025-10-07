Imports Guna.UI2.WinForms
Imports SistemaFacturaciónCommon.SistemaFacturacion.Data
Imports SistemaFacturaciónCommon.SistemaFacturacion.Modules
Imports System.Data.SQLite
Namespace SistemaFacturacion.Forms.Caja

    Public Class P_TerminarVenta
        ' Declaración de variables a nivel de la clase
        ' Estas variables se mantienen durante todo el ciclo de vida del formulario
        Friend isCuentaPorCobrar As Boolean
        Friend venta As Cls_Ventas

        ' Variables para el contenido de la factura (impresión)
        Friend encabezadoFactura As String
        Friend encabezadoProds As String
        Friend facturaContenido As New List(Of String)()
        Friend finFactura As String

        Private btnTotalesList As List(Of Guna2TileButton)
        Private btnRestanteList As List(Of Guna2TileButton)
        Private txtcalcVuelto As List(Of Guna2TextBox)
        Private txtShowTotal As List(Of Guna2TextBox)

        ' Manejador del evento Load del formulario
        Private Sub P_TerminarVenta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
            ' Inicialización de las listas (Solución)
            btnTotalesList = New List(Of Guna2TileButton) From {
                BTN_EColocarTotal,
                BTN_TColocarTotal,
                BTN_SColocarTotal,
                BTN_DColocarTotal
            }
            btnRestanteList = New List(Of Guna2TileButton) From {BTN_RestanteEfectivo, BTN_RestanteTarjeta}

            txtcalcVuelto = New List(Of Guna2TextBox) From {
                TXT_ECliente,
                TXT_TCliente,
                TXT_SCliente,
                TXT_DCliente,
                TXT_PagoTarjeta,
                TXT_PagoEfectivo
            }
            txtShowTotal = New List(Of Guna2TextBox) From {
                TXT_ETotal,
                TXT_TTotal,
                TXT_STotal,
                TXT_DTotal,
                TXT_MTotal
            }
            ' Valida el estado inicial del pago y habilita/deshabilita los botones de venta
            VALIDAR(TXT_ECliente, TXT_ECliente, venta.Saldo_total, False)
        End Sub
        Private Sub P_TerminarVenta_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
            ' Añade los manejadores de eventos (handlers) para los botones de "Colocar Total"
            ' Esto evita tener que crear una subrutina para cada botón y centraliza la lógica
            For Each btn As Guna2TileButton In btnTotalesList
                AddHandler btn.Click, AddressOf ColocarTotal
            Next

            ' Se añade los manejadores de eventos para los botones de "Restante"
            For Each btn As Guna2TileButton In btnRestanteList
                AddHandler btn.Click, AddressOf AgregarRestante
            Next

            ' Añade los manejadores de eventos para los cambios en los TextBox de pago
            ' Esto asegura que el cálculo del vuelto y la validación se actualicen automáticamente
            For Each txt As Guna2TextBox In txtcalcVuelto
                AddHandler txt.TextChanged, AddressOf RecalcularVueltoYValidar
            Next

            'Se coloca el total en todas las textbox de total
            For Each txt As Guna2TextBox In txtShowTotal
                txt.Text = venta.Saldo_total
            Next
        End Sub

        ' Manejador de evento unificado para los botones de "Colocar Total"
        ' "sender" es el botón que ha sido presionado
        Private Sub ColocarTotal(sender As Object, e As EventArgs)
            ' Convierte el objeto sender al tipo de control Guna2Button
            Dim btn As Guna.UI2.WinForms.Guna2Button = CType(sender, Guna.UI2.WinForms.Guna2Button)

            ' Usa un Select Case para identificar qué botón se hizo clic y actualizar el TextBox correcto
            Select Case btn.Name
                Case "BTN_EColocarTotal"
                    TXT_ECliente.Text = venta.saldo_total
                Case "BTN_TColocarTotal"
                    TXT_TCliente.Text = venta.saldo_total
                Case "BTN_SColocarTotal"
                    TXT_SCliente.Text = venta.saldo_total
                Case "BTN_DColocarTotal"
                    TXT_DCliente.Text = venta.saldo_total
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
                    VALIDAR(TXT_ECliente, TXT_ECliente, venta.saldo_total, False)
                Case "TXT_TCliente"
                    CalcVuelto(TXT_TCliente, TXT_TVuelto)
                    VALIDAR(TXT_TCliente, TXT_TCliente, venta.saldo_total, False)
                Case "TXT_SCliente"
                    CalcVuelto(TXT_SCliente, TXT_SVuelto)
                    VALIDAR(TXT_SCliente, TXT_SCliente, venta.saldo_total, False)
                Case "TXT_DCliente"
                    CalcVuelto(TXT_DCliente, TXT_DVuelto)
                    VALIDAR(TXT_DCliente, TXT_DCliente, venta.saldo_total, False)
                Case "TXT_PagoTarjeta", "TXT_PagoEfectivo"
                    ' El cálculo para el pago mixto se maneja con ambos TextBox
                    CalcVuelto(TXT_DCliente, TXT_MVuelto) ' Se usa TXT_DCliente como placeholder para la primera caja, ya que su valor no es relevante aquí
                    VALIDAR(TXT_PagoTarjeta, TXT_PagoEfectivo, venta.saldo_total, True)
            End Select
        End Sub

        ' Calcula el vuelto basado en el monto entregado por el cliente
        Private Sub CalcVuelto(txtEntregaCliente As Guna.UI2.WinForms.Guna2TextBox, txtVuelto As Guna.UI2.WinForms.Guna2TextBox)
            Dim eCliente As Double
            ' Lógica para tipos de pago no mixtos (Efectivo, Tarjeta, Sinpe, Depósito)
            If Not TabControlTVenta.SelectedIndex = 4 Then
                If Double.TryParse(txtEntregaCliente.Text, eCliente) Then
                    venta.Vuelto = eCliente - venta.Saldo_total
                    If venta.Vuelto > 0 Then
                        txtVuelto.Text = venta.Vuelto.ToString()
                    Else
                        txtVuelto.Text = "0"
                    End If
                End If
            Else ' Lógica para el pago mixto
                Dim eCliente2 As Double
                If Double.TryParse(TXT_PagoTarjeta.Text, eCliente) AndAlso Double.TryParse(TXT_PagoEfectivo.Text, eCliente2) Then
                    Dim EntregaCliente As Double = eCliente + eCliente2
                    venta.Vuelto = EntregaCliente - venta.Saldo_total
                    If venta.Vuelto > 0 Then
                        txtVuelto.Text = venta.Vuelto.ToString()
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

        ' Subrutina principal para guardar la factura
        Private Async Sub GuardarFactura(imprimir As Boolean, esCuentaPorCobrar As Boolean)
            If MsgBox("¿Desea terminar la venta?", vbOKCancel + vbDefaultButton1, "Confirmar") = MsgBoxResult.Cancel Then
                Exit Sub
            End If

            If venta.ListaProductos.Count < 1 Then
                msgError("No se puede Guardar una factura vacía.")
                Exit Sub
            End If

            Try
                venta.Comentario = TXT_Comentario.Text

                Dim resultado As String = Await venta.GuardarFacturaDB(esCuentaPorCobrar)
                'Si dió algún tipo de error al guardar la factura, se muestra el mensaje y se sale del sub
                If resultado <> "OK" Then
                    msgError("Error al guardar la factura: " & resultado)
                    Return
                End If

                ' Si se seleccionó la opción de imprimir, genera e imprime la factura
                If imprimir Then
                    GENERAR_FACTURA(venta.ID)
                End If

                Me.DialogResult = DialogResult.OK
            Catch ex As Exception
                msgError("Error: " & ex.Message)
                Me.DialogResult = DialogResult.Cancel
            End Try
        End Sub

        Private Sub TerminarVenta(imprimir As Boolean)
            venta.tipo_pago = TabControlTVenta.SelectedIndex
            Select Case venta.Tipo_pago
                Case 0 ' Efectivo
                    venta.Efectivo = Convert.ToDecimal(TXT_ECliente.Text)
                    venta.Vuelto = Convert.ToDecimal(TXT_EVuelto.Text)
                    GuardarFactura(imprimir, isCuentaPorCobrar)
                Case 1 ' Tarjeta
                    venta.Tarjeta = Convert.ToDecimal(TXT_TCliente.Text)
                    venta.Vuelto = Convert.ToDecimal(TXT_TVuelto.Text)
                    GuardarFactura(imprimir, isCuentaPorCobrar)
                Case 2 ' Sinpe
                    venta.Tarjeta = Convert.ToDecimal(TXT_TCliente.Text)
                    venta.Vuelto = Convert.ToDecimal(TXT_TVuelto.Text)
                    GuardarFactura(imprimir, isCuentaPorCobrar)
                Case 3 ' Depósito
                    venta.Tarjeta = Convert.ToDecimal(TXT_TCliente.Text)
                    venta.Vuelto = Convert.ToDecimal(TXT_TVuelto.Text)
                    GuardarFactura(imprimir, isCuentaPorCobrar)
                Case 4 ' Mixto
                    venta.Efectivo = Convert.ToDecimal(TXT_TCliente.Text)
                    venta.Tarjeta = Convert.ToDecimal(TXT_TCliente.Text)
                    venta.Vuelto = Convert.ToDecimal(TXT_TVuelto.Text)
                    GuardarFactura(imprimir, isCuentaPorCobrar)
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
            Me.DialogResult = DialogResult.Cancel
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
                restante = venta.saldo_total - pTarjeta
                If restante < 0 Then
                    restante = 0
                End If
                Return restante
            Else ' Si el botón de tarjeta restante fue presionado
                restante = venta.saldo_total - pEfectivo
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
            VALIDAR(TXT_PagoTarjeta, TXT_PagoEfectivo, venta.saldo_total, True)
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