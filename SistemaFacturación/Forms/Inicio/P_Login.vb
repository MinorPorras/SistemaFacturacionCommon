Imports System.Data.SQLite
Imports SistemaFacturaciónCommon.SistemaFacturacion.Data
Imports SistemaFacturaciónCommon.SistemaFacturacion.Forms.Caja
Imports SistemaFacturaciónCommon.SistemaFacturacion.Modules.Md_Arqueos
Imports SistemaFacturaciónCommon.SistemaFacturacion.Modules.Md_CONEXION
Imports SistemaFacturaciónCommon.SistemaFacturacion.Modules.Md_Inicializacion
Imports SistemaFacturaciónCommon.SistemaFacturacion.Modules.MSG

Namespace SistemaFacturacion.Forms.Inicio

    Public Class P_Login

        Friend NextForm As Form

        'Variables utilizadas para los cierres de caja
        Friend FromArqueo As Boolean = False
        Friend denominaciones_caja_anterior As Cls_SaldoCaja


        Private Sub BTN_Login_Click(sender As Object, e As EventArgs) Handles BTN_Login.Click
            T.Tables.Clear()
            SQL = "SELECT clave, tipo FROM usuario WHERE ID = @idUsu"
            Dim param As New List(Of SQLiteParameter) From {
                New SQLiteParameter("@idUsu", CBX_UserSelect.SelectedValue)
            }
            CargarTablaParam(T, SQL, param)

            'El id de usuario es incorrecto
            If T.Tables(0).Rows.Count <= 0 Then
                MsgError("No se encuentra el usuario para comprar la clave")
                TXT_Clave.Select()
                TXT_Clave.SelectAll()
            End If

            'El la clave no coincide con la almacenada en la DB
            If T.Tables(0).Rows(0).Item(0) <> TXT_Clave.Text Then
                MsgBox("Usuario o contraseña incorrecta", vbCritical + vbOKOnly, "Error")
                TXT_Clave.Select()
                TXT_Clave.SelectAll()
                Return
            End If

            idUsuActual = CBX_UserSelect.SelectedValue
            nomUsuActual = CBX_UserSelect.Text


            If T.Tables(0).Rows(0).Item(1) = 0 Then
                CuentaAdmin = False
            Else
                CuentaAdmin = True
            End If

            NextForm = If(CuentaAdmin, New M_Inicio, New P_Caja)

            If FromArqueo Then
                NextForm = New P_Caja
            End If

            NextForm.Show()
            NextForm.Select()

            If TypeOf (NextForm) Is P_Caja Then
                Dim cajaForm = CType(NextForm, P_Caja)
                cajaForm.BTN_RegresarCaja.Enabled = CuentaAdmin
                ShowStartShiftDialog(cajaForm, denominaciones_caja_anterior)
            End If

            isNavigating = True
            Me.Close()
        End Sub

        Private Sub BTN_RegresarLogin_Click(sender As Object, e As EventArgs)
            P_SelectUsu.Show()
            P_SelectUsu.Select()
            isNavigating = True
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
            isNavigating = False
            Me.Close()
        End Sub

        Private Sub P_Login_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
            ManejarCierreONavegacion(e)
        End Sub

        Private Sub P_Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
            T.Tables.Clear()
            SQL = "SELECT ID, usuario FROM usuario"
            Cargar_Tabla(T, SQL)
            If T.Tables(0).Rows.Count > 0 Then
                CBX_UserSelect.DataSource = T.Tables(0)
                CBX_UserSelect.DisplayMember = "usuario"
                CBX_UserSelect.ValueMember = "ID"
            End If

            TXT_Clave.Select()
        End Sub
    End Class

End Namespace