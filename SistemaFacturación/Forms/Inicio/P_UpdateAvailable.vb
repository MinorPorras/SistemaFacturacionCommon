Public Class P_UpdateAvailable
    Private Sub BTN_Login_Click(sender As Object, e As EventArgs) Handles BTN_Login.Click
        Me.DialogResult = DialogResult.OK
        Me.Close()
    End Sub

    Private Sub BTN_RegresarLogin_Click(sender As Object, e As EventArgs) Handles BTN_RegresarLogin.Click
        Me.DialogResult = DialogResult.Cancel
        Me.Close()
    End Sub

    Friend Sub LoadReleaseNotes(ByVal version As String, ByVal htmlNotes As String)
        ' Se muestra la versión
        LBL_Version.Text = $"Nueva versión disponible: {version}"

        ' Se cargan las notas de la versión
        WB_ReleaseNotes.DocumentText = htmlNotes

        ' Se configura el título del formulario
        Me.Text = $"Instalación de la versión: {version}"
    End Sub
End Class