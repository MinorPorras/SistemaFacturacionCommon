
Imports Serilog

Namespace SistemaFacturacion.Modules

    Module MSG
        Public Sub Mensaje(texto As String, controles As MsgBoxStyle, Titulo As String)
            MsgBox(texto, controles, Titulo)
        End Sub

        Public Function MsgGuardar() As Boolean
            If MsgBox("¿Desea guardar los cambios? ", vbOKCancel, "Confirmar cambios") = MsgBoxResult.Ok Then
                Return True
            Else
                Return False
            End If
        End Function

        Public Function MsgCambiarEstadoCuenta(estado As String, especificacion As String) As Boolean
            If MsgBox($"Desea {estado} la cuenta: {especificacion}", vbOKCancel, "Cambio de estado de la cuenta por cobrar") = MsgBoxResult.Ok Then
                Return True
            Else
                Return False
            End If
        End Function

        Public Function MsgEliminar(objeto As String) As Boolean
            If MsgBox("Desea eliminar " & objeto, vbOKCancel, "Eliminar") = MsgBoxResult.Ok Then
                Return True
            Else
                Return False
            End If
        End Function
        Public Sub MsgCerrarApp()
            If MsgBox("¿Desea cerra la aplicación?", vbOKCancel + vbQuestion, "Cerrar sistema") = MsgBoxResult.Ok Then
                CerrarAplicacion()
            End If
        End Sub

        Public Sub MsgError(texto As String)
            Log.Error(texto)
            MsgBox(texto, vbOKOnly + vbCritical, "Error")
        End Sub

        Public Sub MsgDatoAlm()
            MsgBox("Información almacenada satisfactoriamente", vbInformation + vbOKOnly, "Transacción exitosa")
        End Sub

        Public Sub MsgDatoDel()
            MsgBox("Información eliminada satisfactoriamente", vbInformation + vbOKOnly, "Transacción exitosa")
        End Sub

        Public Sub MsgRestart()
            If MsgBox("Acción realizada exitosamente, para reflejar los cambios se debe de reiniciar la app, desea reiniciarla?", vbOKCancel + vbQuestion, "Confirmación") = MsgBoxResult.Ok Then
                Application.Restart()
            End If
        End Sub

        Public Function MsgGuardarCierre()
            If MsgBox("Desea guardar el cierre de caja? ", vbOKCancel, "Guardar Cierre") = MsgBoxResult.Ok Then
                Return True
            Else
                Return False
            End If
        End Function
    End Module
End Namespace