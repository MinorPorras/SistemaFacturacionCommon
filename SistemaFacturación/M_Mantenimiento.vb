Public Class M_Mantenimiento
    Private Sub Guna2Button9_Click(sender As Object, e As EventArgs) Handles BTN_RegresarMant.Click
        M_Inicio.Show()
        Me.Close()
    End Sub

    Private Sub M_Mantenimiento_KeyPress(sender As Object, e As KeyPressEventArgs) Handles MyBase.KeyPress
        If e.KeyChar = "1"c Then
            BTN_Sucursal.PerformClick()
        ElseIf e.KeyChar = "2"c Then
            BTN_Usuario.PerformClick()
        ElseIf e.KeyChar = "3"c Then
            BTN_Cliente.PerformClick()
        ElseIf e.KeyChar = "4"c Then
            BTN_Proveedor.PerformClick()
        ElseIf e.KeyChar = "5"c Then
            BTN_Impuesto.PerformClick()
        ElseIf e.KeyChar = "6"c Then
            BTN_Categoria.PerformClick()
        ElseIf e.KeyChar = "7"c Then
            BTN_Marca.PerformClick()
        ElseIf e.KeyChar = "8"c Then
            BTN_Producto.PerformClick()
        ElseIf e.KeyChar = "0"c Then
            BTN_RegresarMant.PerformClick()
        End If
    End Sub

    Private Sub BTN_Sucursal_Click(sender As Object, e As EventArgs) Handles BTN_Sucursal.Click
        P_Sucursal.Show()
        P_Sucursal.Select()
        Me.Close()
    End Sub

    Private Sub BTN_Usuario_Click(sender As Object, e As EventArgs) Handles BTN_Usuario.Click
        P_Usuarios.Show()
        P_Usuarios.Select()
        Me.Close()
    End Sub

    Private Sub BTN_Cliente_Click(sender As Object, e As EventArgs) Handles BTN_Cliente.Click
        P_Clientes.Show()
        P_Clientes.Select()
        Me.Close()
    End Sub

    Private Sub BTN_Proveedor_Click(sender As Object, e As EventArgs) Handles BTN_Proveedor.Click
        P_Proveedor.Show()
        P_Proveedor.Select()
        Me.Close()
    End Sub

    Private Sub BTN_Impuesto_Click(sender As Object, e As EventArgs) Handles BTN_Impuesto.Click
        P_Impuestos.Show()
        P_Impuestos.Select()
        Me.Close()
    End Sub

    Private Sub BTN_Categoria_Click(sender As Object, e As EventArgs) Handles BTN_Categoria.Click
        P_Categoria.Show()
        P_Categoria.Select()
        Me.Close()
    End Sub

    Private Sub BTN_Marca_Click(sender As Object, e As EventArgs) Handles BTN_Marca.Click
        P_Marca.Show()
        P_Marca.Select()
        Me.Close()
    End Sub

    Private Sub BTN_Producto_Click(sender As Object, e As EventArgs) Handles BTN_Producto.Click
        P_Productos.Show()
        P_Productos.Select()
        Me.Close()
    End Sub

    Private Sub BTN_CerrarApp_Click(sender As Object, e As EventArgs) Handles BTN_CerrarApp.Click
        msgCerrarApp()
    End Sub

    Private Sub BTN_Config_Click(sender As Object, e As EventArgs) Handles BTN_Config.Click
        entrarConfig(0)
    End Sub
    Private Sub BTN_LogOut_Click(sender As Object, e As EventArgs) Handles BTN_LogOut.Click
        M_Inicio.LBL_Usu.Text = ""
        P_SelectUsu.Show()
        P_SelectUsu.Select()
        Me.Close()
    End Sub
End Class