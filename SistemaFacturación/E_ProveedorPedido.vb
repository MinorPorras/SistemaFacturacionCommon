Public Class E_ProveedorPedido
    Private Sub BTN_RegresarPed_Click(sender As Object, e As EventArgs) Handles BTN_RegresarPed.Click
        E_NuevoProveedor.Show()
        E_NuevoProveedor.Select()
        Me.Close()
    End Sub

    Private Sub E_ProveedorPedido_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        REFRESCAR()
        VALIDAR()
    End Sub

    Public Sub REFRESCAR()
        Try
            DGV_Pedido.Rows.Clear()
            MNU_ELIMINAR.Visible = False
            If E_NuevoProveedor.LHacerPed.Count > 0 Then
                For i As Integer = 0 To E_NuevoProveedor.LHacerPed.Count - 1
                    DGV_Pedido.Rows.Add(E_NuevoProveedor.LHacerPed(i), E_NuevoProveedor.LRebPed(i))
                Next
                MNU_ELIMINAR.Visible = True
            End If
        Catch ex As Exception
            If ex.Message <> "InvalidArgument=El valor de '0' no es válido para 'index'." & vbCrLf & "Nombre del parámetro: index" Then
                ' Mostrar un mensaje de error genérico
                msgError("Error al cargar la lista de categorías: " & ex.Message)
            End If
        End Try
    End Sub

    Private Sub BTN_NProv_Click(sender As Object, e As EventArgs) Handles BTN_NProv.Click
        If Not String.IsNullOrEmpty(CBX_DiaPedido.Text) Or Not String.IsNullOrEmpty(CBX_RecibirPedido.Text) Then
            E_NuevoProveedor.LHacerPed.Add(CBX_DiaPedido.Text)
            E_NuevoProveedor.LRebPed.Add(CBX_RecibirPedido.Text)
            LIMPIAR()
        End If
        REFRESCAR()
        VALIDAR()
    End Sub

    Private Sub LIMPIAR()
        CBX_DiaPedido.SelectedIndex = 0
        CBX_RecibirPedido.SelectedIndex = 0
    End Sub

    Private Sub VALIDAR()
        If Not String.IsNullOrEmpty(CBX_DiaPedido.Text) And Not String.IsNullOrEmpty(CBX_RecibirPedido.Text) Then
            BTN_NProv.Enabled = True
        Else
            BTN_NProv.Enabled = False
        End If
    End Sub

    Private Sub CBX_RecibirPedido_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBX_RecibirPedido.SelectedIndexChanged
        VALIDAR()
    End Sub

    Private Sub CBX_DiaPedido_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBX_DiaPedido.SelectedIndexChanged
        VALIDAR()
    End Sub

    Private Sub MNU_ELIMINAR_Click(sender As Object, e As EventArgs) Handles MNU_ELIMINAR.Click
        If DGV_Pedido.SelectedRows.Count > 0 Then
            E_NuevoProveedor.LHacerPed.RemoveAt(DGV_Pedido.SelectedRows(0).Index)
            E_NuevoProveedor.LRebPed.RemoveAt(DGV_Pedido.SelectedRows(0).Index)
            REFRESCAR()
            VALIDAR()
        Else
            msgError("Ninguna fila fue seleccionada")
        End If

    End Sub
End Class