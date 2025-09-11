Public Class D_GuardarCuenta
    Public Property ResultadoDelDialogo As DialogResult

    Public ReadOnly Property ComentarioIngresado As String
        Get
            Return Me.TXT_Comentario.Text
        End Get
    End Property

    Private Sub BTN_ConfirmGuardarCuenta_Click(sender As Object, e As EventArgs) Handles BTN_ConfirmGuardarCuenta.Click
        If TXT_Comentario.Text.Length > 200 Then
            MessageBox.Show("El comentario no puede exceder los 200 caracteres.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf TXT_Comentario.Text.Length < 5 Then
            MessageBox.Show("El comentario debe tener al menos 5 caracteres.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            ' Si la validación es exitosa, establece el resultado y cierra el formulario.
            Me.ResultadoDelDialogo = DialogResult.OK
            Me.Close()
        End If
    End Sub

    Private Sub BTN_RegresarMarca_Click(sender As Object, e As EventArgs) Handles BTN_RegresarMarca.Click
        ' Establece el resultado en Cancel y cierra el formulario.
        Me.ResultadoDelDialogo = DialogResult.Cancel
        Me.Close()
    End Sub
End Class