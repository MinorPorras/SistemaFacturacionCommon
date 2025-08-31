Imports Guna.UI2.WinForms

Public Class P_CuentasCobrar
    Private Sub btn_Regresar_Click(sender As Object, e As EventArgs) Handles btn_Regresar.Click
        Me.Close()
    End Sub

    Private Sub P_CuentasCobrar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CrearBotones()
    End Sub

    Private Sub CrearBotones()
        SQL = "SELECT f.ID , c.nombre , fc.comentario 
                FROM factura f
                LEFT JOIN clientes c ON c.codigo  = f.ID_Cliente 
                LEFT JOIN factura_comentario fc ON f.ID = fc.ID_Factura
                WHERE f.cobrada = 0"
        T1.Tables.Clear()
        Cargar_Tabla(T1, SQL)
        If T.Tables(0).Rows.Count <= 0 Then
            MsgBox("No hay facturas por cobrar", MsgBoxStyle.Information, "Aviso")
            Me.Close()
        End If

        For i = 0 To T1.Tables(0).Rows.Count - 1
            ' 1. Crea el panel que contendrá todo (panel normal)
            Dim panelContenedor As New Panel With {
            .Size = New Size(300, 100),
            .BorderStyle = BorderStyle.FixedSingle
            }

            ' 2. Crea un Panel normal para los Labels internos
            Dim panelLabels As New Panel With {
            .Name = "PAN_" & T1.Tables(0).Rows(i)("ID").ToString(),
            .Size = New Size(290, 60), ' Adjusted size to fit inside the container
            .Location = New Point(5, 5),
            .BorderStyle = BorderStyle.FixedSingle
            }
            AddHandler panelLabels.Click, AddressOf Panel_Click_Select_Cuenta

            ' 3. Crea el botón (con Dock.Bottom)
            Dim btnEliminar As New Guna2Button With {
            .Name = "BTN_" & T1.Tables(0).Rows(i)("ID").ToString(),
            .Text = "Eliminar",
            .Size = New Size(290, 30), ' Adjusted size
            .Location = New Point(5, 70),
            .Dock = DockStyle.Bottom,
            .FillColor = Color.FromArgb(255, 64, 64),
            .ForeColor = Color.White,
            .Font = New Font("Segoe UI", 16, FontStyle.Bold),
            .ImageAlign = HorizontalAlignment.Center,
            .Image = My.Resources.ICO_Eliminar
            }
            AddHandler btnEliminar.Click, AddressOf BtnEliminar_Click

            ' Se añade el botón primero para que el Dock.Fill del panelLabels funcione
            panelContenedor.Controls.Add(btnEliminar)
            panelContenedor.Controls.Add(panelLabels)

            ' 4. Posiciona los Labels dentro del panelLabels
            Dim lblNombre As New Label With {
            .Text = T1.Tables(0).Rows(i)("nombre").ToString(),
            .ForeColor = Color.White,
            .TextAlign = ContentAlignment.MiddleCenter,
            .AutoSize = False,
            .Size = New Size(panelLabels.Width, panelLabels.Height / 2),
            .Location = New Point(0, 0)
            }
            panelLabels.Controls.Add(lblNombre)

            Dim lblComentario As New Label
            If IsDBNull(T1.Tables(0).Rows(i)("comentario")) Then
                lblComentario.Text = "Sin comentario"
            Else
                lblComentario.Text = T1.Tables(0).Rows(i)("comentario").ToString()
            End If
            lblComentario.ForeColor = Color.White
            lblComentario.TextAlign = ContentAlignment.MiddleCenter
            lblComentario.AutoSize = False
            lblComentario.Size = New Size(panelLabels.Width, panelLabels.Height / 2)
            lblComentario.Location = New Point(0, panelLabels.Height / 2)
            panelLabels.Controls.Add(lblComentario)

            pan_CuentasCobrar.Controls.Add(panelContenedor)
        Next
    End Sub

    Private Sub BtnEliminar_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Panel_Click_Select_Cuenta(sender As Object, e As EventArgs)

    End Sub
End Class