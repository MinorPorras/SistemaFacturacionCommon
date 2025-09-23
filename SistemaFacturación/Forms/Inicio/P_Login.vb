Imports SistemaFacturaciónCommon.SistemaFacturacion.Modules
Namespace SistemaFacturacion.Forms.Inicio

    Public Class P_Login
        Friend idUsu As Integer

        Private Sub BTN_Login_Click(sender As Object, e As EventArgs) Handles BTN_Login.Click
            T.Tables.Clear()
            SQL = "SELECT nombre, telefono, email, logo FROM sucursal"
            Cargar_Tabla(T, SQL)
            If Not IsDBNull(T.Tables(0).Rows(0).Item(0)) Then
                If T.Tables(0).Rows.Count > 0 Then
                    SetAppSetting("Empresa", T.Tables(0).Rows(0).Item(0).ToString())
                    SetAppSetting("Telefono", T.Tables(0).Rows(0).Item(1).ToString())
                    SetAppSetting("Correo", T.Tables(0).Rows(0).Item(2).ToString())
                    SetAppSetting("Logo", T.Tables(0).Rows(0).Item(3).ToString())
                End If
            End If
            T.Tables.Clear()
            SQL = "SELECT clave, tipo FROM usuario WHERE ID = " & idUsu
            Cargar_Tabla(T, SQL)
            If T.Tables(0).Rows.Count > 0 Then
                If T.Tables(0).Rows(0).Item(0) = TXT_Clave.Text Then
                    idUsuActual = idUsu
                    nomUsuActual = LBL_Usu.Text
                    If T.Tables(0).Rows(0).Item(1) = 0 Then
                        CuentaAdmin = False
                    Else
                        CuentaAdmin = True
                    End If
                    M_Inicio.Show()
                    M_Inicio.Select()
                    P_SelectUsu.Close()
                    Me.Close()
                Else
                    MsgBox("Usuario o contraseña incorrecta", vbCritical + vbOKOnly, "Error")
                    TXT_Clave.Select()
                    TXT_Clave.SelectAll()
                End If
            End If
        End Sub

        Private Sub BTN_RegresarLogin_Click(sender As Object, e As EventArgs) Handles BTN_RegresarLogin.Click
            P_SelectUsu.Show()
            P_SelectUsu.Select()
            Me.Close()
        End Sub

        Private Sub P_Login_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
            CenterLoginGroupBox()
        End Sub

        Private Sub CenterLoginGroupBox()
            ' Calcula la nueva posición X.
            Dim x As Integer = (Me.ClientSize.Width / 2) - (GBX_Login.Width / 2)
            ' Calcula la nueva posición Y.
            Dim y As Integer = (Me.ClientSize.Height / 2) - (GBX_Login.Height / 2)

            ' Establece la nueva ubicación del GroupBox.
            GBX_Login.Location = New Point(x, y)
        End Sub

        Private Sub BTN_CerrarApp_Click(sender As Object, e As EventArgs) Handles BTN_CerrarApp.Click
            msgCerrarApp()
        End Sub

        Private Sub P_Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        End Sub
    End Class

End Namespace