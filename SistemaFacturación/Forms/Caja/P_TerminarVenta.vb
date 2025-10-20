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
        Friend imprimir_factura As Boolean

        ' Variables para el contenido de la factura (impresión)
        Friend encabezadoFactura As String
        Friend encabezadoProds As String
        Friend facturaContenido As New List(Of String)()
        Friend finFactura As String

        Private btnTotalesList As List(Of Guna2TileButton)
        Private btnRestanteList As List(Of Guna2TileButton)
        Private txtEntregaCliente As List(Of Guna2TextBox)
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

            txtEntregaCliente = New List(Of Guna2TextBox) From {
                TXT_ECliente,
                TXT_TCliente,
                TXT_SCliente,
                TXT_DCliente,
                TXT_MEfectivo,
                TXT_MTarjeta
            }
            txtShowTotal = New List(Of Guna2TextBox) From {
                TXT_ETotal,
                TXT_TTotal,
                TXT_STotal,
                TXT_DTotal,
                TXT_MTotal
            }
            ' Valida el estado inicial del pago y habilita/deshabilita los botones de venta
            Dim entregaCliente As Decimal = If(Integer.TryParse(TXT_ECliente.Text, entregaCliente), entregaCliente, 0)
            BTN_TVenta.Enabled = entregaCliente > venta.Saldo_total
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
            For Each txt As Guna2TextBox In txtEntregaCliente
                AddHandler txt.TextChanged, AddressOf RecalcularVueltoYValidar
                AddHandler txt.KeyPress, AddressOf verifyNumericOnKeyPress
            Next

            Dim saldo = If(isCuentaPorCobrar, venta.Saldo_restante, venta.Saldo_total)
            'Se coloca el total en todas las textbox de total
            For Each txt As Guna2TextBox In txtShowTotal
                txt.Text = saldo
            Next
        End Sub

#Region "Calculos y validaciones"

        Private Sub GetVuelto(entregaCliente As Decimal, txtVuelto As Guna2TextBox)
            venta.Vuelto = entregaCliente - venta.Saldo_total
            If venta.Vuelto > 0 Then
                txtVuelto.Text = venta.Formated_vuelto
            Else
                txtVuelto.Text = "0"
            End If
        End Sub

        ' Manjeador de evento unificado para la verificación de los montos ingresados
        Private Sub verifyNumericOnKeyPress(sender As Object, e As KeyPressEventArgs)
            ' 1. Permitir el uso de teclas de control (como Backspace)
            If Char.IsControl(e.KeyChar) Then
                e.Handled = False
                Exit Sub
            End If

            ' Obtener el separador decimal de la configuración regional (',' o '.')
            Dim separadorDecimal As Char = Convert.ToChar(System.Globalization.CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)

            ' 2. Bloquear cualquier cosa que NO sea un dígito y NO sea el separador decimal.
            If Not Char.IsDigit(e.KeyChar) AndAlso e.KeyChar <> separadorDecimal Then
                e.Handled = True ' Bloquear la entrada del carácter

                ' 3. Si es el separador decimal, verificar si ya existe uno en la caja de texto.
            ElseIf e.KeyChar = separadorDecimal Then
                Dim txtBox As TextBox = DirectCast(sender, TextBox)

                If txtBox.Text.Contains(separadorDecimal) Then
                    e.Handled = True ' Bloquear si ya existe un separador (solo se permite uno)
                Else
                    e.Handled = False ' Permitir el separador
                End If
            End If
        End Sub

        ' Manejador de evento unificado para los cambios en los TextBox de pago
        Private Sub RecalcularVueltoYValidar(sender As Object, e As EventArgs)
            ' Convierte el objeto sender al tipo de control Guna2TextBox
            Dim txt As Guna2TextBox = CType(sender, Guna2TextBox)
            Dim entregaCliente As Decimal
            Dim txtVuelto As Guna2TextBox

            Try
                Select Case txt.Name
                    Case "TXT_ECliente"
                        txtVuelto = TXT_EVuelto
                    Case "TXT_TCliente"
                        txtVuelto = TXT_TVuelto
                    Case "TXT_SCliente"
                        txtVuelto = TXT_SVuelto
                    Case "TXT_DCliente"
                        txtVuelto = TXT_DVuelto
                    Case Else
                        txtVuelto = TXT_MVuelto
                End Select
                If Not Decimal.TryParse(If(String.IsNullOrEmpty(txt.Text), 0, txt.Text), entregaCliente) Then
                    MsgError($"El monto ingresado no es válido. No se puede pasar a Decimal el monto: {txt.Text}")
                    Exit Sub
                End If
                Dim efectivo As Decimal
                Dim tarjeta As Decimal
                If txt.Name = "TXT_MEfectivo" Or txt.Name = "TXT_MTarjeta" Then
                    If Not Decimal.TryParse(TXT_MEfectivo.Text, efectivo) Then
                        MsgError($"El monto en efectivo ingresado no es válido. No se puede pasar a Decimal el monto: {TXT_MEfectivo.Text}")
                        Exit Sub
                    End If
                    If Not Decimal.TryParse(TXT_MTarjeta.Text, tarjeta) Then
                        MsgError($"El monto en tarjeta ingresado no es válido. No se puede pasar a Decimal el monto: {TXT_MTarjeta.Text}")
                        Exit Sub
                    End If

                    entregaCliente = efectivo + tarjeta
                End If

                BTN_TVenta.Enabled = entregaCliente >= venta.Saldo_total

                GetVuelto(txt.Text, txtVuelto)
            Catch ex As Exception
                MsgError("Error al recalcular el vuelto y validar: " & ex.Message)
                GetVuelto(0, txtVuelto)
            End Try
        End Sub
        ' Manejador de evento unificado para los botones de "Colocar Total"
        ' "sender" es el botón que ha sido presionado
        Private Sub ColocarTotal(sender As Object, e As EventArgs)
            ' Convierte el objeto sender al tipo de control Guna2Button
            Dim btn As Guna2Button = CType(sender, Guna2Button)
            Dim txtEntregaCliente As Guna2TextBox
            ' Usa un Select Case para identificar qué botón se hizo clic y actualizar el TextBox correcto
            Select Case btn.Name
                Case "BTN_TColocarTotal"
                    txtEntregaCliente = TXT_TCliente
                Case "BTN_SColocarTotal"
                    txtEntregaCliente = TXT_SCliente
                Case "BTN_DColocarTotal"
                    txtEntregaCliente = TXT_DCliente
                Case Else
                    txtEntregaCliente = TXT_ECliente
            End Select

            txtEntregaCliente.Text = venta.Saldo_total
        End Sub

        ' Calcula el monto restante para pago mixto
        Private Sub CargarRestante(fromEfectivo As Boolean)
            Dim restante As Decimal
            Dim dineroColocado As Decimal
            Dim txtMontoActual As Guna2TextBox = If(Not fromEfectivo, TXT_MEfectivo, TXT_MTarjeta)
            Dim txtCargarRestante As Guna2TextBox = If(fromEfectivo, TXT_MEfectivo, TXT_MTarjeta)

            Try
                If Not Decimal.TryParse(txtMontoActual.Text, dineroColocado) Then
                    Throw New Exception($"El monto ingresado no es válido. No se puede pasar a Decimal el monto: {txtMontoActual.Text}")
                End If

                restante = venta.Saldo_total - dineroColocado
            Catch ex As Exception
                MsgError("Error al calcular el restante: " & ex.Message)
            End Try

            txtCargarRestante.Text = If(restante < 0, 0, restante)
        End Sub

        'Se agrega el restante al campo correspondiente
        Private Sub AgregarRestante(sender As Object, e As EventArgs)
            ' Convierte el objeto sender al tipo de control Guna2Button
            Dim btn As Guna.UI2.WinForms.Guna2Button = CType(sender, Guna.UI2.WinForms.Guna2Button)
            ' Usa un Select Case para identificar qué botón se hizo clic y actualizar el TextBox correcto
            Select Case btn.Name
                Case "BTN_RestanteTarjeta"
                    CargarRestante(False)
                Case "BTN_RestanteEfectivo"
                    CargarRestante(True)
            End Select

            Dim efectivo As Decimal
            Dim tarjeta As Decimal
            Dim entregaCliente As Decimal

            Try
                If Not Decimal.TryParse(TXT_MEfectivo.Text, efectivo) Then
                    Throw New Exception($"El monto en efectivo ingresado no es válido. No se puede pasar a Decimal el monto: {TXT_MEfectivo.Text}")
                End If
                If Not Decimal.TryParse(TXT_MTarjeta.Text, tarjeta) Then
                    Throw New Exception($"El monto en tarjeta ingresado no es válido. No se puede pasar a Decimal el monto: {TXT_MTarjeta.Text}")
                End If
                entregaCliente = efectivo + tarjeta
            Catch ex As Exception
                MsgError("Error al calcular el monto restante: " & ex.Message)
                entregaCliente = 0
            End Try

            ' Recalcula el vuelto y valida los montos después de agregar el restante
            GetVuelto(entregaCliente, TXT_MVuelto)
        End Sub
#End Region


#Region "TerminarVenta_ImprimirFactura"

        Private Sub TerminarVenta(imprimir As Boolean)
            venta.Tipo_pago = TabControlTVenta.SelectedIndex

            Select Case venta.Tipo_pago
                Case 0 ' Efectivo
                    If Not Decimal.TryParse(TXT_ECliente.Text, venta.Efectivo) Then
                        MsgError("El monto en efectivo no es válido: " & TXT_ECliente.Text)
                        Exit Sub
                    End If
                    venta.Tarjeta = 0

                Case 1, 2, 3 ' Tarjeta, Sinpe, Depósito (Se usa el mismo patrón para el monto de la Tarjeta)
                    Dim txtControl As Guna2TextBox = TXT_TCliente
                    Select Case venta.Tipo_pago
                        Case 2 : txtControl = TXT_SCliente
                        Case 3 : txtControl = TXT_DCliente
                    End Select

                    If Not Decimal.TryParse(txtControl.Text, venta.Tarjeta) Then
                        MsgError($"El monto de pago (Tipo {venta.Tipo_pago}) no es válido: {txtControl.Text}")
                        Exit Sub
                    End If
                    venta.Efectivo = 0

                Case 4 ' Mixto
                    ' 1. Validar Efectivo
                    If Not Decimal.TryParse(TXT_MEfectivo.Text, venta.Efectivo) Then
                        MsgError("El monto en efectivo para el pago mixto no es válido: " & TXT_MEfectivo.Text)
                        Exit Sub
                    End If

                    ' 2. Validar Tarjeta
                    If Not Decimal.TryParse(TXT_MTarjeta.Text, venta.Tarjeta) Then
                        MsgError("El monto de tarjeta para el pago mixto no es válido: " & TXT_MTarjeta.Text)
                        Exit Sub
                    End If

                Case Else
                    ' Manejar cualquier otro caso, si aplica. Por ejemplo:
                    MsgError("Tipo de pago no reconocido.")
                    Exit Sub
            End Select

            imprimir_factura = imprimir
            Me.DialogResult = DialogResult.OK
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