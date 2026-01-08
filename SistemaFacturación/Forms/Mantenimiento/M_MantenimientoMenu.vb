Imports SistemaFacturaciónCommon.SistemaFacturacion.Forms.Inicio
Imports SistemaFacturaciónCommon.SistemaFacturacion.Modules
Imports SistemaFacturaciónCommon.SistemaFacturacion.Helper.NavigationHelper

Namespace SistemaFacturacion.Forms.Mantenimiento

    Public Class M_MantenimientoMenu
        Private Sub Guna2Button9_Click(sender As Object, e As EventArgs) Handles BTN_RegresarMant.Click
            M_Inicio.Show()
            isNavigating = True
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

        Private Sub OpenForm(form As Form)
            form.Show()
            form.Select()
            isNavigating = True
            Me.Close()
        End Sub

        Private Sub BTN_Sucursal_Click(sender As Object, e As EventArgs) Handles BTN_Sucursal.Click
            Dim frmSuc As New C_Sucursal
            openForm(frmSuc)
        End Sub

        Private Sub BTN_Usuario_Click(sender As Object, e As EventArgs) Handles BTN_Usuario.Click
            Dim frmUsuarios As New C_Usuarios
            openForm(frmUsuarios)
        End Sub

        Private Sub BTN_Cliente_Click(sender As Object, e As EventArgs) Handles BTN_Cliente.Click
            Dim frmClientes As New C_Clientes
            openForm(frmClientes)
        End Sub

        Private Sub BTN_Proveedor_Click(sender As Object, e As EventArgs) Handles BTN_Proveedor.Click
            Dim frmProveedor As New C_Proveedor
            openForm(frmProveedor)
        End Sub

        Private Sub BTN_Impuesto_Click(sender As Object, e As EventArgs) Handles BTN_Impuesto.Click
            Dim frmImpuestos As New C_Impuestos
            openForm(frmImpuestos)
        End Sub

        Private Sub BTN_Categoria_Click(sender As Object, e As EventArgs) Handles BTN_Categoria.Click
            Dim frmCategoria As New C_Categoria
            openForm(frmCategoria)
        End Sub

        Private Sub BTN_Producto_Click(sender As Object, e As EventArgs) Handles BTN_Producto.Click
            Dim frmProductos As New C_Productos
            openForm(frmProductos)
        End Sub
        Private Sub BTN_Marca_Click(sender As Object, e As EventArgs) Handles BTN_Marca.Click
            Dim frmMarca As New C_Marca
            openForm(frmMarca)
        End Sub

        Private Sub BTN_Conceptos_Click(sender As Object, e As EventArgs) Handles BTN_Conceptos.Click
            Dim frmConceptos As New C_ConceptosCaja
            openForm(frmConceptos)
        End Sub

        Private Sub BTN_LogOut_Click(sender As Object, e As EventArgs) Handles BTN_LogOut.Click
            LogOut(True, Me)
        End Sub

        Private Sub BTN_Config_Click(sender As Object, e As EventArgs) Handles BTN_Config.Click
            entrarConfig(0, Me)
        End Sub
        Private Sub BTN_CerrarApp_Click(sender As Object, e As EventArgs) Handles BTN_CerrarApp.Click
            isNavigating = False
            Me.Close()
        End Sub

        Private Sub M_MantenimientoMenu_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
            ManejarCierreONavegacion(e)
        End Sub
    End Class

End Namespace