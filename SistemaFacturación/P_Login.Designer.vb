<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class P_Login
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(P_Login))
        Me.BTN_RegresarLogin = New Guna.UI2.WinForms.Guna2Button()
        Me.BTN_Login = New Guna.UI2.WinForms.Guna2Button()
        Me.TXT_Clave = New Guna.UI2.WinForms.Guna2TextBox()
        Me.LBL_Usu = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2PictureBox2 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.Guna2PictureBox1 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.GBX_Login = New Guna.UI2.WinForms.Guna2GroupBox()
        Me.BTN_CerrarApp = New Guna.UI2.WinForms.Guna2ImageButton()
        Me.Guna2BorderlessForm1 = New Guna.UI2.WinForms.Guna2BorderlessForm(Me.components)
        CType(Me.Guna2PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GBX_Login.SuspendLayout()
        Me.SuspendLayout()
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
        Me.BTN_RegresarLogin.Image = CType(resources.GetObject("BTN_RegresarLogin.Image"), System.Drawing.Image)
        Me.BTN_RegresarLogin.ImageSize = New System.Drawing.Size(40, 40)
        Me.BTN_RegresarLogin.Location = New System.Drawing.Point(4, 276)
        Me.BTN_RegresarLogin.Name = "BTN_RegresarLogin"
        Me.BTN_RegresarLogin.Size = New System.Drawing.Size(247, 62)
        Me.BTN_RegresarLogin.TabIndex = 111
        Me.BTN_RegresarLogin.Text = "Regresar"
        '
        'BTN_Login
        '
        Me.BTN_Login.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BTN_Login.BackColor = System.Drawing.Color.Transparent
        Me.BTN_Login.BorderColor = System.Drawing.Color.Red
        Me.BTN_Login.BorderRadius = 20
        Me.BTN_Login.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.BTN_Login.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BTN_Login.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BTN_Login.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BTN_Login.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BTN_Login.FillColor = System.Drawing.Color.MediumSeaGreen
        Me.BTN_Login.Font = New System.Drawing.Font("Ebrima", 20.25!, System.Drawing.FontStyle.Bold)
        Me.BTN_Login.ForeColor = System.Drawing.SystemColors.Control
        Me.BTN_Login.Image = CType(resources.GetObject("BTN_Login.Image"), System.Drawing.Image)
        Me.BTN_Login.ImageSize = New System.Drawing.Size(40, 40)
        Me.BTN_Login.Location = New System.Drawing.Point(257, 275)
        Me.BTN_Login.Name = "BTN_Login"
        Me.BTN_Login.Size = New System.Drawing.Size(276, 62)
        Me.BTN_Login.TabIndex = 112
        Me.BTN_Login.Text = "Iniciar sesión"
        '
        'TXT_Clave
        '
        Me.TXT_Clave.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TXT_Clave.BackColor = System.Drawing.Color.Transparent
        Me.TXT_Clave.BorderRadius = 20
        Me.TXT_Clave.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TXT_Clave.DefaultText = ""
        Me.TXT_Clave.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TXT_Clave.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TXT_Clave.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXT_Clave.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXT_Clave.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXT_Clave.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.TXT_Clave.ForeColor = System.Drawing.Color.Black
        Me.TXT_Clave.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXT_Clave.Location = New System.Drawing.Point(133, 165)
        Me.TXT_Clave.Name = "TXT_Clave"
        Me.TXT_Clave.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TXT_Clave.PlaceholderText = ""
        Me.TXT_Clave.SelectedText = ""
        Me.TXT_Clave.Size = New System.Drawing.Size(351, 46)
        Me.TXT_Clave.TabIndex = 114
        '
        'LBL_Usu
        '
        Me.LBL_Usu.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.LBL_Usu.BackColor = System.Drawing.Color.Transparent
        Me.LBL_Usu.Font = New System.Drawing.Font("Segoe UI Black", 15.75!, System.Drawing.FontStyle.Bold)
        Me.LBL_Usu.ForeColor = System.Drawing.SystemColors.Control
        Me.LBL_Usu.Location = New System.Drawing.Point(133, 100)
        Me.LBL_Usu.Name = "LBL_Usu"
        Me.LBL_Usu.Size = New System.Drawing.Size(82, 32)
        Me.LBL_Usu.TabIndex = 115
        Me.LBL_Usu.Text = "Usuario"
        Me.LBL_Usu.TextAlignment = System.Drawing.ContentAlignment.TopCenter
        Me.LBL_Usu.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit
        '
        'Guna2PictureBox2
        '
        Me.Guna2PictureBox2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Guna2PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.Guna2PictureBox2.Image = CType(resources.GetObject("Guna2PictureBox2.Image"), System.Drawing.Image)
        Me.Guna2PictureBox2.ImageRotate = 0!
        Me.Guna2PictureBox2.Location = New System.Drawing.Point(73, 89)
        Me.Guna2PictureBox2.Name = "Guna2PictureBox2"
        Me.Guna2PictureBox2.Size = New System.Drawing.Size(54, 54)
        Me.Guna2PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Guna2PictureBox2.TabIndex = 118
        Me.Guna2PictureBox2.TabStop = False
        '
        'Guna2PictureBox1
        '
        Me.Guna2PictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Guna2PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2PictureBox1.Image = CType(resources.GetObject("Guna2PictureBox1.Image"), System.Drawing.Image)
        Me.Guna2PictureBox1.ImageRotate = 0!
        Me.Guna2PictureBox1.Location = New System.Drawing.Point(73, 161)
        Me.Guna2PictureBox1.Name = "Guna2PictureBox1"
        Me.Guna2PictureBox1.Size = New System.Drawing.Size(54, 54)
        Me.Guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Guna2PictureBox1.TabIndex = 119
        Me.Guna2PictureBox1.TabStop = False
        '
        'GBX_Login
        '
        Me.GBX_Login.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.GBX_Login.BackColor = System.Drawing.Color.Transparent
        Me.GBX_Login.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.GBX_Login.BorderRadius = 20
        Me.GBX_Login.Controls.Add(Me.BTN_Login)
        Me.GBX_Login.Controls.Add(Me.BTN_RegresarLogin)
        Me.GBX_Login.Controls.Add(Me.LBL_Usu)
        Me.GBX_Login.Controls.Add(Me.Guna2PictureBox1)
        Me.GBX_Login.Controls.Add(Me.Guna2PictureBox2)
        Me.GBX_Login.Controls.Add(Me.TXT_Clave)
        Me.GBX_Login.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.GBX_Login.FillColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.GBX_Login.Font = New System.Drawing.Font("Segoe UI Black", 21.75!, System.Drawing.FontStyle.Bold)
        Me.GBX_Login.ForeColor = System.Drawing.Color.White
        Me.GBX_Login.Location = New System.Drawing.Point(89, 68)
        Me.GBX_Login.Name = "GBX_Login"
        Me.GBX_Login.ShadowDecoration.BorderRadius = 20
        Me.GBX_Login.ShadowDecoration.Color = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.GBX_Login.ShadowDecoration.Enabled = True
        Me.GBX_Login.Size = New System.Drawing.Size(539, 343)
        Me.GBX_Login.TabIndex = 122
        Me.GBX_Login.Text = "Iniciar sesión"
        Me.GBX_Login.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'BTN_CerrarApp
        '
        Me.BTN_CerrarApp.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BTN_CerrarApp.BackColor = System.Drawing.Color.Red
        Me.BTN_CerrarApp.CheckedState.ImageSize = New System.Drawing.Size(64, 64)
        Me.BTN_CerrarApp.HoverState.ImageSize = New System.Drawing.Size(64, 64)
        Me.BTN_CerrarApp.Image = CType(resources.GetObject("BTN_CerrarApp.Image"), System.Drawing.Image)
        Me.BTN_CerrarApp.ImageOffset = New System.Drawing.Point(0, 0)
        Me.BTN_CerrarApp.ImageRotate = 0!
        Me.BTN_CerrarApp.ImageSize = New System.Drawing.Size(60, 60)
        Me.BTN_CerrarApp.Location = New System.Drawing.Point(656, -1)
        Me.BTN_CerrarApp.Name = "BTN_CerrarApp"
        Me.BTN_CerrarApp.PressedState.ImageSize = New System.Drawing.Size(64, 64)
        Me.BTN_CerrarApp.Size = New System.Drawing.Size(58, 54)
        Me.BTN_CerrarApp.TabIndex = 123
        '
        'Guna2BorderlessForm1
        '
        Me.Guna2BorderlessForm1.BorderRadius = 25
        Me.Guna2BorderlessForm1.ContainerControl = Me
        Me.Guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6R
        Me.Guna2BorderlessForm1.TransparentWhileDrag = True
        '
        'P_Login
        '
        Me.AcceptButton = Me.BTN_Login
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.CancelButton = Me.BTN_RegresarLogin
        Me.ClientSize = New System.Drawing.Size(714, 489)
        Me.Controls.Add(Me.BTN_CerrarApp)
        Me.Controls.Add(Me.GBX_Login)
        Me.ForeColor = System.Drawing.SystemColors.Control
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "P_Login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Inicio de sesión"
        CType(Me.Guna2PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GBX_Login.ResumeLayout(False)
        Me.GBX_Login.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BTN_Login As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BTN_RegresarLogin As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents LBL_Usu As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents TXT_Clave As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2PictureBox1 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents Guna2PictureBox2 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents GBX_Login As Guna.UI2.WinForms.Guna2GroupBox
    Friend WithEvents BTN_CerrarApp As Guna.UI2.WinForms.Guna2ImageButton
    Friend WithEvents Guna2BorderlessForm1 As Guna.UI2.WinForms.Guna2BorderlessForm
End Class
