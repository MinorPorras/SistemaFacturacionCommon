Public Class P_Sucursal
    Friend idSucursal As Integer = 1
    Friend logo As String
    Private Sub P_Sucursal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        REFRESCAR()
    End Sub

    Private Sub BTN_GuardarNSucursal_Click(sender As Object, e As EventArgs) Handles BTN_GuardarNSucursal.Click
        Try
            E_NuevaSucursal.idSucursal = 1
            E_NuevaSucursal.TXT_CodSucursal.Text = TXT_CodSucursal.Text
            E_NuevaSucursal.TXT_NombreSucursal.Text = TXT_NombreSucursal.Text
            E_NuevaSucursal.TXT_CedJuridicaSucursal.Text = TXT_CedJuridicaSucursal.Text
            E_NuevaSucursal.TXT_DireccionSucursal.Text = TXT_DireccionSucursal.Text
            E_NuevaSucursal.TXT_TelefonoSucursal.Text = TXT_TelefonoSucursal.Text
            E_NuevaSucursal.TXT_EmailSucursal.Text = TXT_EmailSucursal.Text
            E_NuevaSucursal.OFD_LogoSucursal.FileName = logo
            E_NuevaSucursal.BTN_LogoSucursal.Image = Image.FromFile(logo)
            E_NuevaSucursal.RutaLogo = logo
            E_NuevaSucursal.ModSuc = True
            E_NuevaSucursal.Show()
            E_NuevaSucursal.Select()
            Me.Close()
        Catch ex As Exception
            msgError("Error: " & ex.Message)
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
            PIC_Logo.Image = Image.FromFile(logo)
        Catch ex As Exception
            msgError("Error: " & ex.Message)
        End Try
    End Sub

    Private Sub BTN_RegresarNSuc_Click(sender As Object, e As EventArgs) Handles BTN_RegresarNSuc.Click
        M_Mantenimiento.Show()
        M_Mantenimiento.Select()
        Me.Close()
    End Sub

    Private Sub BTN_CerrarApp_Click(sender As Object, e As EventArgs) Handles BTN_CerrarApp.Click
        msgCerrarApp()
    End Sub
End Class