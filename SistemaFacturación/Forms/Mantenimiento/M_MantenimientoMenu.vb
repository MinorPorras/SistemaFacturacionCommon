Imports SistemaFacturaciónCommon.SistemaFacturacion.Forms.Inicio
Imports SistemaFacturaciónCommon.SistemaFacturacion.Modules
Namespace SistemaFacturacion.Forms.Mantenimiento

    Public Class M_MantenimientoMenu
        Private Sub Guna2Button9_Click(sender As Object, e As EventArgs) Handles BTN_RegresarMant.Click
            M_Inicio.Show()
            Me.Close()
        End Sub

        Private Sub M_Mantenimiento_KeyPress(sender As Object, e As KeyPressEventArgs) Handles MyBase.KeyPress
            Select Case e.KeyChar
                Case "1"c
                    BTN_Sucursal.PerformClick()
                Case "2"c
                    BTN_Usuario.PerformClick()
                Case "3"c
                    BTN_Cliente.PerformClick()
                Case "4"c
                    BTN_Proveedor.PerformClick()
                Case "5"c
                    BTN_Impuesto.PerformClick()
                Case "6"c
                    BTN_Conceptos.PerformClick()
                Case "7"c
                    BTN_Categoria.PerformClick()
                Case "8"c
                    BTN_Marca.PerformClick()
                Case "9"c
                    BTN_Producto.PerformClick()
                Case "0"c
                    BTN_RegresarMant.PerformClick()
            End Select
        End Sub

        Private Sub openForm(form As Form)
            form.Show()
            form.Select()
            Me.Close()
        End Sub

        Private Sub BTN_Sucursal_Click(sender As Object, e As EventArgs) Handles BTN_Sucursal.Click
            openForm(C_Sucursal)
        End Sub

        Private Sub BTN_Usuario_Click(sender As Object, e As EventArgs) Handles BTN_Usuario.Click
            openForm(C_Usuarios)
        End Sub

        Private Sub BTN_Cliente_Click(sender As Object, e As EventArgs) Handles BTN_Cliente.Click
            openForm(C_Clientes)
        End Sub

        Private Sub BTN_Proveedor_Click(sender As Object, e As EventArgs) Handles BTN_Proveedor.Click
            openForm(C_Proveedor)
        End Sub

        Private Sub BTN_Impuesto_Click(sender As Object, e As EventArgs) Handles BTN_Impuesto.Click
            openForm(C_Impuestos)
        End Sub

        Private Sub BTN_Categoria_Click(sender As Object, e As EventArgs) Handles BTN_Categoria.Click
            openForm(C_Categoria)
        End Sub

        Private Sub BTN_Producto_Click(sender As Object, e As EventArgs) Handles BTN_Producto.Click
            openForm(C_Productos)
        End Sub
        Private Sub BTN_Marca_Click(sender As Object, e As EventArgs) Handles BTN_Marca.Click
            openForm(C_Marca)
        End Sub

        Private Sub BTN_Conceptos_Click(sender As Object, e As EventArgs) Handles BTN_Conceptos.Click
            openForm(C_ConceptosCaja)
        End Sub

        Private Sub BTN_LogOut_Click(sender As Object, e As EventArgs) Handles BTN_LogOut.Click
            M_Inicio.LBL_Usu.Text = ""
            openForm(P_SelectUsu)
        End Sub

        Private Sub BTN_Config_Click(sender As Object, e As EventArgs) Handles BTN_Config.Click
            entrarConfig(0, Me)
        End Sub
        Private Sub BTN_CerrarApp_Click(sender As Object, e As EventArgs) Handles BTN_CerrarApp.Click
            msgCerrarApp()
        End Sub
    End Class

End Namespace