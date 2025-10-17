Imports SistemaFacturaciónCommon.SistemaFacturacion.Modules
Namespace SistemaFacturacion.Forms.Mantenimiento

    Public Class C_Sucursal
        Friend idSucursal As Integer = 1
        Friend logo As String
        Private Sub P_Sucursal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
            REFRESCAR()
        End Sub

        Private Sub BTN_GuardarNSucursal_Click(sender As Object, e As EventArgs) Handles BTN_GuardarNSucursal.Click
            Try
                Dim frmNewSucursal As New E_NuevaSucursal With {
                    .idSucursal = 1,
                    .ModSuc = True
                }
                frmNewSucursal.TXT_CodSucursal.Text = TXT_CodSucursal.Text
                frmNewSucursal.TXT_NombreSucursal.Text = TXT_NombreSucursal.Text
                frmNewSucursal.TXT_CedJuridicaSucursal.Text = TXT_CedJuridicaSucursal.Text
                frmNewSucursal.TXT_DireccionSucursal.Text = TXT_DireccionSucursal.Text
                frmNewSucursal.TXT_TelefonoSucursal.Text = TXT_TelefonoSucursal.Text
                frmNewSucursal.TXT_EmailSucursal.Text = TXT_EmailSucursal.Text

                If Not String.IsNullOrEmpty(logo) And IO.File.Exists(logo) Then
                    frmNewSucursal.OFD_LogoSucursal.FileName = logo
                    frmNewSucursal.BTN_LogoSucursal.Image = Image.FromFile(logo)
                    frmNewSucursal.RutaLogo = logo
                Else
                    frmNewSucursal.OFD_LogoSucursal.FileName = ""
                    frmNewSucursal.BTN_LogoSucursal.Image = Nothing
                    frmNewSucursal.RutaLogo = ""
                End If
                frmNewSucursal.Show()
                frmNewSucursal.Select()
                isNavigating = True
                Me.Close()
            Catch ex As Exception
                MsgError("Error: " & ex.Message)
            End Try
        End Sub

        Friend Sub REFRESCAR()
            Try
                T.Tables.Clear()
                SQL = "SELECT ID, codigo, nombre, direccion, ced_juridica, telefono, email, logo FROM sucursal"
                Cargar_Tabla(T, SQL)

                TXT_CodSucursal.Text = T.Tables(0).Rows(0).Item(1)
                TXT_NombreSucursal.Text = T.Tables(0).Rows(0).Item(2)
                TXT_DireccionSucursal.Text = T.Tables(0).Rows(0).Item(3)
                TXT_CedJuridicaSucursal.Text = T.Tables(0).Rows(0).Item(4)
                TXT_TelefonoSucursal.Text = T.Tables(0).Rows(0).Item(5)
                TXT_EmailSucursal.Text = T.Tables(0).Rows(0).Item(6)
                logo = T.Tables(0).Rows(0).Item(7)
                If Not String.IsNullOrEmpty(logo) And IO.File.Exists(logo) Then
                    PIC_Logo.Image = Image.FromFile(logo)
                Else
                    PIC_Logo.Image = Nothing
                End If

            Catch ex As Exception
                msgError("Error: " & ex.Message)
            End Try
        End Sub

        Private Sub BTN_RegresarNSuc_Click(sender As Object, e As EventArgs) Handles BTN_RegresarNSuc.Click
            Dim mantMenu As New M_MantenimientoMenu
            mantMenu.Show()
            mantMenu.Select()
            isNavigating = True
            Me.Close()
        End Sub

        Private Sub BTN_CerrarApp_Click(sender As Object, e As EventArgs) Handles BTN_CerrarApp.Click
            isNavigating = False
            Me.Close()
        End Sub

        Private Sub C_Sucursal_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
            ManejarCierreONavegacion(e)
        End Sub
    End Class

End Namespace