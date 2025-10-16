Imports Velopack

Public Class P_SplashScreen

    Public Sub SwitchStateProgressIndicator(isActive As Boolean)
        If Not Me.PrgIndicator.InvokeRequired Then
            If isActive Then
                PrgIndicator.Stop()
            Else
                PrgIndicator.Start()
            End If
            Exit Sub
        End If
        Me.Invoke(Sub()
                      If isActive Then
                          PrgIndicator.Stop()
                      Else
                          PrgIndicator.Start()
                      End If
                  End Sub)
    End Sub
    Public Sub UpdateStatus(text As String)
        ' Verifica si es necesario invocar. Si el hilo actual NO es el hilo
        ' de la UI, InvokeRequired será True.
        If LBL_Info.InvokeRequired Then
            ' Si se requiere invocación, crea un delegado (Action) para
            ' ejecutar el código de la UI
            Me.Invoke(Sub()
                          LBL_Info.Text = text
                          LBL_Info.Refresh()
                      End Sub)
        Else
            ' Si ya estamos en el hilo de la UI simplemente actualiza el texto
            LBL_Info.Text = text
            LBL_Info.Refresh()
        End If
    End Sub
    Public Sub setVersionLabel(ver As String)
        If LBL_Version.InvokeRequired Then
            Me.Invoke(Sub()
                          LBL_Version.Text += ver
                      End Sub)
        Else
            LBL_Version.Text += ver
        End If
    End Sub
End Class