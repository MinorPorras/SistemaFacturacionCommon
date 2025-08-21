Module MSG
    Public Sub mensaje(texto As String, controles As MsgBoxStyle, Titulo As String)
        MsgBox(texto, controles, Titulo)
    End Sub

    Public Function msgGuardar() As Boolean
        If MsgBox("¿Desea guardar los cambios? ", vbOKCancel, "Confirmar cambios") = MsgBoxResult.Ok Then
            Return True
        Else
            Return False
        End If
    End Function

    Public Function msgEliminar(objeto As String) As Boolean
        If MsgBox("Desea eliminar " & objeto, vbOKCancel, "Eliminar") = MsgBoxResult.Ok Then
            Return True
        Else
            Return False
        End If
    End Function
    Public Sub msgCerrarApp()
        If MsgBox("¿Desea cerra la aplicación?", vbOKCancel + vbQuestion, "Cerrar sistema") = MsgBoxResult.Ok Then
            Application.Exit()
        End If
    End Sub

    Public Sub msgError(texto As String)
        MsgBox(texto, vbOKOnly + vbCritical, "Error")
    End Sub

    Public Sub msgDatoAlm()
        MsgBox("Información almacenada satisfactoriamente", vbInformation + vbOKOnly, "Transacción exitosa")
    End Sub

    Public Sub msgDatoDel()
        MsgBox("Información eliminada satisfactoriamente", vbInformation + vbOKOnly, "Transacción exitosa")
    End Sub

    Public Sub msgRestart()
        If MsgBox("Acción realizada exitosamente, para reflejar los cambios se debe de reiniciar la app, desea reiniciarla?", vbOKCancel + vbQuestion, "Confirmación") = MsgBoxResult.Ok Then
            Application.Restart()
        End If
    End Sub

End Module
