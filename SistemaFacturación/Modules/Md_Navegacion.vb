Imports Guna.UI2.WinForms
Imports SistemaFacturaciónCommon.SistemaFacturacion.Data
Imports SistemaFacturaciónCommon.SistemaFacturacion.Forms.Caja
Imports SistemaFacturaciónCommon.SistemaFacturacion.Forms.Inicio
Imports SistemaFacturaciónCommon.SistemaFacturacion.Modules.Md_Inicializacion
Namespace SistemaFacturacion.Modules
    Module Md_Navegacion
        ''' <summary>
        ''' Cierra la sesión del usuario actual, limpia la etiqueta de usuario si se proporciona,
        ''' muestra el formulario de inicio de sesión y opcionalmente cierra el formulario llamador.
        ''' </summary>
        ''' <param name="closeForm">Indica si se debe cerrar el formulario llamador.</param>
        ''' <param name="callerForm">Formulario desde el cual se invoca el cierre de sesión.</param>
        ''' <param name="lbl_usu">Etiqueta HTML opcional para mostrar el usuario actual (se limpia si se proporciona).</param>
        ''' <param name="fromArqueo">Indica si el cierre de sesión proviene del proceso de arqueo.</param>
        Friend Sub LogOut(closeForm As Boolean, callerForm As Form, Optional lbl_usu As Guna2HtmlLabel = Nothing, Optional fromArqueo As Boolean = False, Optional denominaciones As Cls_SaldoCaja = Nothing)
            If lbl_usu IsNot Nothing Then
                lbl_usu.Text = ""
            End If
            Dim loginform As New P_Login With {
                .FromArqueo = fromArqueo,
                .denominaciones_caja_anterior = If(denominaciones, New Cls_SaldoCaja)
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

