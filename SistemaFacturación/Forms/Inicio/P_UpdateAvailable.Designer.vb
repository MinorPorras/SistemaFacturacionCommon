<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class P_UpdateAvailable
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(P_UpdateAvailable))
        Me.Guna2BorderlessForm1 = New Guna.UI2.WinForms.Guna2BorderlessForm(Me.components)
        Me.WB_ReleaseNotes = New System.Windows.Forms.WebBrowser()
        Me.LBL_Version = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.BTN_Login = New Guna.UI2.WinForms.Guna2Button()
        Me.BTN_RegresarLogin = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2HtmlLabel2 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.PB_DownloadProgress = New Guna.UI2.WinForms.Guna2ProgressBar()
        Me.Guna2HtmlLabel1 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.LBL_Percent = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.SuspendLayout()
        '
        'Guna2BorderlessForm1
        '
        Me.Guna2BorderlessForm1.BorderRadius = 20
        Me.Guna2BorderlessForm1.ContainerControl = Me
        Me.Guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6R
        Me.Guna2BorderlessForm1.TransparentWhileDrag = True
        '
        'WB_ReleaseNotes
        '
        Me.WB_ReleaseNotes.Location = New System.Drawing.Point(12, 112)
        Me.WB_ReleaseNotes.MinimumSize = New System.Drawing.Size(20, 20)
        Me.WB_ReleaseNotes.Name = "WB_ReleaseNotes"
        Me.WB_ReleaseNotes.Size = New System.Drawing.Size(605, 276)
        Me.WB_ReleaseNotes.TabIndex = 0
        '
        'LBL_Version
        '
        Me.LBL_Version.AutoSize = False
        Me.LBL_Version.BackColor = System.Drawing.Color.Transparent
        Me.LBL_Version.Font = New System.Drawing.Font("Segoe UI Black", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_Version.ForeColor = System.Drawing.SystemColors.Control
        Me.LBL_Version.Location = New System.Drawing.Point(12, 12)
        Me.LBL_Version.Name = "LBL_Version"
        Me.LBL_Version.Size = New System.Drawing.Size(605, 34)
        Me.LBL_Version.TabIndex = 2
        Me.LBL_Version.Text = "Nueva versión disponible"
        Me.LBL_Version.TextAlignment = System.Drawing.ContentAlignment.TopCenter
        '
        'BTN_Login
        '
        Me.BTN_Login.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BTN_Login.BackColor = System.Drawing.Color.Transparent
        Me.BTN_Login.BorderColor = System.Drawing.Color.Red
        Me.BTN_Login.BorderRadius = 20
        Me.BTN_Login.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.BTN_Login.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BTN_Login.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BTN_Login.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BTN_Login.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BTN_Login.FillColor = System.Drawing.Color.MediumSeaGreen
        Me.BTN_Login.Font = New System.Drawing.Font("Ebrima", 20.25!, System.Drawing.FontStyle.Bold)
        Me.BTN_Login.ForeColor = System.Drawing.SystemColors.Control
        Me.BTN_Login.Image = Global.SistemaFacturaciónCommon.My.Resources.Resources.ICO_Download
        Me.BTN_Login.ImageSize = New System.Drawing.Size(40, 40)
        Me.BTN_Login.Location = New System.Drawing.Point(312, 489)
        Me.BTN_Login.Name = "BTN_Login"
        Me.BTN_Login.Size = New System.Drawing.Size(305, 62)
        Me.BTN_Login.TabIndex = 114
        Me.BTN_Login.Text = "Actualizar/reiniciar"
        '
        'BTN_RegresarLogin
        '
        Me.BTN_RegresarLogin.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BTN_RegresarLogin.BackColor = System.Drawing.Color.Transparent
        Me.BTN_RegresarLogin.BorderColor = System.Drawing.Color.Gainsboro
        Me.BTN_RegresarLogin.BorderRadius = 20
        Me.BTN_RegresarLogin.CustomBorderColor = System.Drawing.Color.Transparent
        Me.BTN_RegresarLogin.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.BTN_RegresarLogin.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BTN_RegresarLogin.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BTN_RegresarLogin.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BTN_RegresarLogin.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BTN_RegresarLogin.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BTN_RegresarLogin.Font = New System.Drawing.Font("Ebrima", 20.25!, System.Drawing.FontStyle.Bold)
        Me.BTN_RegresarLogin.ForeColor = System.Drawing.SystemColors.Control
        Me.BTN_RegresarLogin.Image = Global.SistemaFacturaciónCommon.My.Resources.Resources.ICO_Cerrar
        Me.BTN_RegresarLogin.ImageSize = New System.Drawing.Size(40, 40)
        Me.BTN_RegresarLogin.Location = New System.Drawing.Point(12, 489)
        Me.BTN_RegresarLogin.Name = "BTN_RegresarLogin"
        Me.BTN_RegresarLogin.Size = New System.Drawing.Size(294, 62)
        Me.BTN_RegresarLogin.TabIndex = 113
        Me.BTN_RegresarLogin.Text = "Ahora no"
        '
        'Guna2HtmlLabel2
        '
        Me.Guna2HtmlLabel2.AutoSize = False
        Me.Guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel2.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel2.ForeColor = System.Drawing.SystemColors.Control
        Me.Guna2HtmlLabel2.Location = New System.Drawing.Point(12, 52)
        Me.Guna2HtmlLabel2.Name = "Guna2HtmlLabel2"
        Me.Guna2HtmlLabel2.Size = New System.Drawing.Size(605, 54)
        Me.Guna2HtmlLabel2.TabIndex = 115
        Me.Guna2HtmlLabel2.Text = "Si procede con la actualización al terminar el proceso la aplicación se reiniciar" &
    "á"
        '
        'PB_DownloadProgress
        '
        Me.PB_DownloadProgress.Location = New System.Drawing.Point(12, 443)
        Me.PB_DownloadProgress.Name = "PB_DownloadProgress"
        Me.PB_DownloadProgress.ProgressColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.PB_DownloadProgress.ProgressColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.PB_DownloadProgress.Size = New System.Drawing.Size(605, 30)
        Me.PB_DownloadProgress.TabIndex = 116
        Me.PB_DownloadProgress.Text = "Guna2ProgressBar1"
        Me.PB_DownloadProgress.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault
        '
        'Guna2HtmlLabel1
        '
        Me.Guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel1.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel1.ForeColor = System.Drawing.SystemColors.Control
        Me.Guna2HtmlLabel1.Location = New System.Drawing.Point(12, 407)
        Me.Guna2HtmlLabel1.Name = "Guna2HtmlLabel1"
        Me.Guna2HtmlLabel1.Size = New System.Drawing.Size(205, 26)
        Me.Guna2HtmlLabel1.TabIndex = 117
        Me.Guna2HtmlLabel1.Text = "Progreso de instalación:"
        '
        'LBL_Percent
        '
        Me.LBL_Percent.BackColor = System.Drawing.Color.Transparent
        Me.LBL_Percent.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_Percent.ForeColor = System.Drawing.SystemColors.Control
        Me.LBL_Percent.Location = New System.Drawing.Point(223, 406)
        Me.LBL_Percent.Name = "LBL_Percent"
        Me.LBL_Percent.Size = New System.Drawing.Size(19, 27)
        Me.LBL_Percent.TabIndex = 118
        Me.LBL_Percent.Text = "%"
        '
        'P_UpdateAvailable
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(629, 563)
        Me.Controls.Add(Me.LBL_Percent)
        Me.Controls.Add(Me.Guna2HtmlLabel1)
        Me.Controls.Add(Me.PB_DownloadProgress)
        Me.Controls.Add(Me.Guna2HtmlLabel2)
        Me.Controls.Add(Me.BTN_Login)
        Me.Controls.Add(Me.BTN_RegresarLogin)
        Me.Controls.Add(Me.LBL_Version)
        Me.Controls.Add(Me.WB_ReleaseNotes)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Name = "P_UpdateAvailable"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "¡Actualización disponible!"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Guna2BorderlessForm1 As Guna.UI2.WinForms.Guna2BorderlessForm
    Friend WithEvents WB_ReleaseNotes As WebBrowser
    Friend WithEvents LBL_Version As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents BTN_Login As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BTN_RegresarLogin As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2HtmlLabel2 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel1 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents PB_DownloadProgress As Guna.UI2.WinForms.Guna2ProgressBar
    Friend WithEvents LBL_Percent As Guna.UI2.WinForms.Guna2HtmlLabel
End Class
