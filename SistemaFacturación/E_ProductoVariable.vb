Public Class E_ProductoVariable
    Dim cant As Integer
    Private Sub E_ProductoVariable_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        VALIDAR()
        TXT_PrecioVenta.Select()
    End Sub

    Private Sub BTN_RegresarPrd_Click(sender As Object, e As EventArgs) Handles BTN_RegresarPrd.Click
        P_Caja.Show()
        P_Caja.Select()
        Me.Close()
    End Sub

    Private Sub BTN_SelectProd_Click(sender As Object, e As EventArgs) Handles BTN_SelectProd.Click
        P_Caja.agregarProd(LBL_ID.Text, LBL_Cod.Text, LBL_Producto.Text, TXT_PrecioVenta.Text, 1)
        TXT_PrecioVenta.Clear()
        P_Caja.Show()
        P_Caja.Select()
        Me.Close()
    End Sub

    Private Sub TXT_PrecioVenta_TextChanged(sender As Object, e As EventArgs) Handles TXT_PrecioVenta.TextChanged
        VALIDAR()
    End Sub

    Private Sub VALIDAR()
        Try
            Dim pVenta As Double
            If Not String.IsNullOrEmpty(TXT_PrecioVenta.Text) And Double.TryParse(TXT_PrecioVenta.Text, pVenta) Then
                BTN_SelectProd.Enabled = True
            Else
                BTN_SelectProd.Enabled = False
            End If
        Catch ex As Exception
            MsgBox("El precio no es un formato numerico correcto", vbCritical + vbOKOnly, "Formato número incorrecto")
        End Try
    End Sub
End Class