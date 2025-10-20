Public Class P_UpdateAvailable
    Private Sub BTN_Login_Click(sender As Object, e As EventArgs) Handles BTN_Login.Click
        ' 1. Señalizar que se debe proceder con la actualización
        Me.DialogResult = DialogResult.OK

        ' 2. Deshabilitar los botones para evitar doble clic o cambio de opinión
        BTN_Login.Enabled = False
        BTN_RegresarLogin.Enabled = False

        ' 3. Configurar la UI para el estado de descarga
        LBL_Version.Text = "Iniciando descarga..."
        PB_DownloadProgress.Visible = True
        LBL_Percent.Visible = True
    End Sub

    Private Sub BTN_RegresarLogin_Click(sender As Object, e As EventArgs) Handles BTN_RegresarLogin.Click
        Me.DialogResult = DialogResult.Cancel
    End Sub

    Friend Sub LoadReleaseNotes(ByVal version As String, ByVal htmlNotes As String)
        ' Se muestra la versión
        LBL_Version.Text = $"Nueva versión disponible: {version}"

        ' Se cargan las notas de la versión
        WB_ReleaseNotes.DocumentText = htmlNotes

        ' Se configura el título del formulario
        Me.Text = $"Instalación de la versión: {version}"
    End Sub

    Friend Sub UpdateDownloadProgress(ByVal progress As Integer)
        ' Patron de WinForms para actualizar UI desde cualquier hilo
        If PB_DownloadProgress.InvokeRequired Then
            ' Usamos Me.Invoke para simplificar y asegurar que se actualicen ambos controles.
            PB_DownloadProgress.Invoke(Sub()
                                           PB_DownloadProgress.Value = progress
                                           LBL_Percent.Text = $"{progress}%"
                                       End Sub)
            Return
        Else
            ' Si ya estamos en el hilo de la UI
            PB_DownloadProgress.Value = progress
            LBL_Percent.Text = $"{progress}%"
        End If
    End Sub
End Class