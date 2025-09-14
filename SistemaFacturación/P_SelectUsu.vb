Imports System.Deployment.Application
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.Button
Imports Guna.UI2.WinForms
Imports SistemaFacturaciónCommon.Md_Inicializacion
Public Class P_SelectUsu

    Private Sub P_LoginCaja_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        inicializarDB()
        AutoUpdate()
        CheckAndMigrateDatabase()
        InitConfigVaribles()
        T.Tables.Clear()
        SQL = "SELECT ID, usuario, color FROM usuario"
        Cargar_Tabla(T, SQL)
        If T.Tables(0).Rows.Count > 0 Then
            For Each row As DataRow In T.Tables(0).Rows
                agregarBoton(FlowLayoutPanel1, row.Item("usuario"), row.Item("ID"), row.Item("color"))
            Next
        End If
    End Sub

    Private Sub agregarBoton(flowpanel As FlowLayoutPanel, nombre As String, tag As Integer, colorT As String)
        Dim splitRGB() As String = colorT.Split(","c)
        Dim r As Integer = Convert.ToInt32(splitRGB(0))
        Dim b As Integer = Convert.ToInt32(splitRGB(1))
        Dim g As Integer = Convert.ToInt32(splitRGB(2))
        Dim nuevoBTN As New Guna2Button With {
            .Size = New Drawing.Size(80, 60),
            .Font = New Font("Britannic Bold", 16),
            .Name = "BTN_Usu" & tag,
            .Text = nombre,
            .Tag = tag,
            .AutoSize = True,
            .FillColor = Color.FromArgb(r, b, g),
            .Margin = New Padding(15, 15, 0, 0),
            .Dock = DockStyle.Bottom,
            .BorderRadius = 10
        }

        AddHandler nuevoBTN.Click, AddressOf BotonUsu_Click

        FlowLayoutPanel1.Controls.Add(nuevoBTN)
    End Sub

    Private Sub BotonUsu_Click(sender As Object, e As EventArgs)
        Dim botonClicado As Guna2Button = CType(sender, Guna2Button)
        P_Login.LBL_Usu.Text = botonClicado.Text
        P_Login.idUsu = Convert.ToInt32(botonClicado.Tag)
        P_Login.TXT_Clave.Select()
        P_Login.Show()
        P_Login.Select()
        Me.Close()
    End Sub

    Private Sub BTN_CerrarApp_Click(sender As Object, e As EventArgs) Handles BTN_CerrarApp.Click
        msgCerrarApp()
    End Sub
End Class