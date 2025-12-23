Imports Guna.UI2.WinForms
Imports SistemaFacturaciónCommon.SistemaFacturacion.Forms.Caja
Imports SistemaFacturaciónCommon.SistemaFacturacion.Forms.Inicio
Imports SistemaFacturaciónCommon.SistemaFacturacion.Modules.Md_Inicializacion
Namespace SistemaFacturacion.Modules
    Module Md_Navegacion
        Friend Sub LogOut(closeForm As Boolean, callerForm As Form, Optional lbl_usu As Guna2HtmlLabel = Nothing, Optional fromArqueo As Boolean = False)
            If lbl_usu IsNot Nothing Then
                lbl_usu.Text = ""
            End If
            Dim loginform As New P_Login With {
                .FromArqueo = fromArqueo
            }
            loginform.Show()
            loginform.Select()
            isNavigating = True
            If closeForm Then
                callerForm.Close()
            End If
        End Sub
    End Module
End Namespace

