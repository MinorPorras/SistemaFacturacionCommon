Imports Guna.UI2.WinForms
Imports SistemaFacturaciónCommon.SistemaFacturacion.Data
Imports SistemaFacturaciónCommon.SistemaFacturacion.Forms.Busqueda
Imports SistemaFacturaciónCommon.SistemaFacturacion.Modules.Md_Inicializacion

Public Class P_AbonarCxC

    Friend venta As Cls_Ventas
    Friend imprimir_factura As Boolean
    Friend Terminar_venta As Boolean

    ' Variables para el contenido de la factura (impresión)
    Friend encabezadoFactura As String
    Friend encabezadoProds As String
    Friend facturaContenido As New List(Of String)()
    Friend finFactura As String

    Private btnTotalesList As List(Of Guna2TileButton)
    Private btnRestanteList As List(Of Guna2TileButton)
    Private nudcalcVuelto As List(Of Guna2NumericUpDown)
    Private txtShowTotal As List(Of Guna2TextBox)
    Private Sub P_AbonarCxC_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Inicialización de las listas (Solución)
        btnTotalesList = New List(Of Guna2TileButton) From {
            BTN_EColocarTotal,
            BTN_TColocarTotal,
            BTN_SColocarTotal,
            BTN_DColocarTotal
        }
        btnRestanteList = New List(Of Guna2TileButton) From {BTN_RestanteEfectivo, BTN_RestanteTarjeta}

        nudcalcVuelto = New List(Of Guna2NumericUpDown) From {
            NUD_ECliente,
            NUD_TCliente,
            NUD_SCliente,
            NUD_DCliente,
            NUD_MEfectivo,
            NUD_MTarjeta
        }
        txtShowTotal = New List(Of Guna2TextBox) From {
            TXT_ETotal,
            TXT_TTotal,
            TXT_STotal,
            TXT_DTotal,
            TXT_MTotal
        }
        ' Valida el estado inicial del pago y habilita/deshabilita los botones de venta
        BTN_TVenta.Enabled = NUD_ECliente.Value > 0
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
        For Each txt As Guna2NumericUpDown In nudcalcVuelto
            AddHandler txt.ValueChanged, AddressOf RecalcularVueltoYValidar
        Next
        'Se coloca el total en todas las textbox de total
        For Each txt As Guna2TextBox In txtShowTotal
            txt.Text = venta.Formated_saldo_restante
        Next
    End Sub


    ' Manejador de evento unificado para los cambios en los TextBox de pago
    Private Sub RecalcularVueltoYValidar(sender As Object, e As EventArgs)
        ' Convierte el objeto sender al tipo de control Guna2TextBox
        Dim nud As Guna2NumericUpDown = CType(sender, Guna2NumericUpDown)

        Dim entregaCliente As Decimal = nud.Value
        If nud.Name = "TXT_PagoTarjeta" Or nud.Name = "TXT_PagoEfectivo" Then
            entregaCliente = NUD_MEfectivo.Value + NUD_MTarjeta.Value
        End If
        Dim txtVuelto As Guna2TextBox

        Select Case nud.Name
            Case "NUD_ECliente"
                entregaCliente = nud.Value
                txtVuelto = TXT_EVuelto
            Case "NUD_TCliente"
                entregaCliente = nud.Value
                txtVuelto = TXT_TVuelto
            Case "NUD_SCliente"
                entregaCliente = nud.Value
                txtVuelto = TXT_SVuelto
            Case "NUD_DCliente"
                entregaCliente = nud.Value
                txtVuelto = TXT_DVuelto
            Case Else
                entregaCliente = NUD_MEfectivo.Value + NUD_MTarjeta.Value
                txtVuelto = TXT_MVuelto
        End Select

        GetVuelto(nud.Value, txtVuelto)
        BTN_TVenta.Enabled = nud.Value > 0
    End Sub

    Private Sub GetVuelto(entregaCliente As Decimal, txtVuelto As Guna2TextBox)
        If entregaCliente >= venta.Saldo_restante Then
            venta.Vuelto = entregaCliente - venta.Saldo_restante
        Else
            venta.Vuelto = 0
        End If

        txtVuelto.Text = venta.Formated_vuelto
    End Sub

    ' Manejador de evento unificado para los botones de "Colocar Total"
    ' "sender" es el botón que ha sido presionado
    Private Sub ColocarTotal(sender As Object, e As EventArgs)
        ' Convierte el objeto sender al tipo de control Guna2Button
        Dim btn As Guna.UI2.WinForms.Guna2Button = CType(sender, Guna.UI2.WinForms.Guna2Button)

        ' Usa un Select Case para identificar qué botón se hizo clic y actualizar el TextBox correcto
        Select Case btn.Name
            Case "BTN_EColocarTotal"
                NUD_ECliente.Value = venta.Saldo_restante
            Case "BTN_TColocarTotal"
                NUD_TCliente.Value = venta.Saldo_restante
            Case "BTN_SColocarTotal"
                NUD_SCliente.Value = venta.Saldo_restante
            Case "BTN_DColocarTotal"
                NUD_DCliente.Value = venta.Saldo_restante
        End Select
    End Sub

    ' Calcula el monto restante para pago mixto
    Private Sub CargarRestante(efectivo As Boolean)
        Dim restante As Double
        If efectivo Then ' Si el botón de efectivo restante fue presionado
            restante = venta.Saldo_restante - NUD_MEfectivo.Value
            If restante < 0 Then
                restante = 0
            End If
            NUD_MTarjeta.Value = restante
        Else ' Si el botón de tarjeta restante fue presionado
            restante = venta.Saldo_restante - NUD_MTarjeta.Value
            If restante < 0 Then
                restante = 0
            End If
            NUD_MEfectivo.Value = restante
        End If
    End Sub

    'Se agrega el restante al campo correspondiente
    Private Sub AgregarRestante(sender As Object, e As EventArgs)
        ' Convierte el objeto sender al tipo de control Guna2Button
        Dim btn As Guna.UI2.WinForms.Guna2Button = CType(sender, Guna.UI2.WinForms.Guna2Button)
        ' Usa un Select Case para identificar qué botón se hizo clic y actualizar el TextBox correcto
        Select Case btn.Name
            Case "BTN_RestanteTarjeta"
                CargarRestante(True)
            Case "BTN_RestanteEfectivo"
                CargarRestante(False)
        End Select
        Dim entregaCliente As Decimal = NUD_MEfectivo.Value + NUD_MTarjeta.Value
        ' Recalcula el vuelto y valida los montos después de agregar el restante
        getVuelto(entregaCliente, TXT_MVuelto)
    End Sub

    Private Sub BTN_RegresarVenta_Click(sender As Object, e As EventArgs) Handles BTN_RegresarVenta.Click
        isNavigating = True
        Me.DialogResult = DialogResult.Cancel
    End Sub

    Private Sub TerminarVenta(imprimir As Boolean)
        venta.Tipo_pago = TabControlTVenta.SelectedIndex
        Select Case venta.Tipo_pago
            Case 0 ' Efectivo
                venta.Efectivo = NUD_ECliente.Value
                venta.Vuelto = Convert.ToDecimal(venta.Vuelto)
            Case 1 ' Tarjeta
                venta.Tarjeta = NUD_TCliente.Value
                venta.Vuelto = Convert.ToDecimal(venta.Vuelto)
            Case 2 ' Sinpe
                venta.Tarjeta = NUD_SCliente.Value
                venta.Vuelto = Convert.ToDecimal(venta.Vuelto)
            Case 3 ' Depósito
                venta.Tarjeta = NUD_DCliente.Value
                venta.Vuelto = Convert.ToDecimal(venta.Vuelto)
            Case 4 ' Mixto
                venta.Efectivo = NUD_MEfectivo.Value
                venta.Tarjeta = NUD_MTarjeta.Value
                venta.Vuelto = Convert.ToDecimal(venta.Vuelto)
        End Select
        Terminar_venta = (venta.Efectivo + venta.Tarjeta) >= venta.Saldo_restante
        imprimir_factura = imprimir
        isNavigating = True
        Me.DialogResult = DialogResult.OK
    End Sub

    Private Sub BTN_TVentaImp_Click(sender As Object, e As EventArgs) Handles BTN_TVentaImp.Click
        TerminarVenta(True)
    End Sub
    Private Sub BTN_TVenta_Click(sender As Object, e As EventArgs) Handles BTN_TVenta.Click
        TerminarVenta(False)
    End Sub

    ' Manejador de eventos de teclado para atajos de teclado
    Private Sub P_TerminarVenta_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        Select Case e.KeyCode
            Case Keys.F1
                BTN_RegresarVenta.PerformClick()
            Case Keys.F2
                BTN_TVenta.PerformClick()
        End Select
    End Sub
End Class