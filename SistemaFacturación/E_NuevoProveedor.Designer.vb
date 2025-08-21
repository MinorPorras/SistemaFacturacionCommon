<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class E_NuevoProveedor
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(E_NuevoProveedor))
        Me.Guna2BorderlessForm1 = New Guna.UI2.WinForms.Guna2BorderlessForm(Me.components)
        Me.Guna2PictureBox1 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.TXT_NombreProv = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TXT_CodigoProv = New Guna.UI2.WinForms.Guna2TextBox()
        Me.TXT_CorreoProv = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TXT_TelProv = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.BTN_RegresarProv = New Guna.UI2.WinForms.Guna2Button()
        Me.BTN_NProv = New Guna.UI2.WinForms.Guna2Button()
        Me.BTN_Pedidos = New Guna.UI2.WinForms.Guna2Button()
        Me.BTN_AutoCod = New Guna.UI2.WinForms.Guna2CircleButton()
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Guna2Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Guna2BorderlessForm1
        '
        Me.Guna2BorderlessForm1.BorderRadius = 25
        Me.Guna2BorderlessForm1.ContainerControl = Me
        Me.Guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6R
        Me.Guna2BorderlessForm1.TransparentWhileDrag = True
        '
        'Guna2PictureBox1
        '
        Me.Guna2PictureBox1.Image = CType(resources.GetObject("Guna2PictureBox1.Image"), System.Drawing.Image)
        Me.Guna2PictureBox1.ImageRotate = 0!
        Me.Guna2PictureBox1.Location = New System.Drawing.Point(160, -103)
        Me.Guna2PictureBox1.Name = "Guna2PictureBox1"
        Me.Guna2PictureBox1.Size = New System.Drawing.Size(409, 361)
        Me.Guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Guna2PictureBox1.TabIndex = 43
        Me.Guna2PictureBox1.TabStop = False
        '
        'TXT_NombreProv
        '
        Me.TXT_NombreProv.AutoRoundedCorners = True
        Me.TXT_NombreProv.BorderRadius = 14
        Me.TXT_NombreProv.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TXT_NombreProv.DefaultText = ""
        Me.TXT_NombreProv.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TXT_NombreProv.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TXT_NombreProv.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXT_NombreProv.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXT_NombreProv.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXT_NombreProv.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.TXT_NombreProv.ForeColor = System.Drawing.Color.Black
        Me.TXT_NombreProv.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXT_NombreProv.Location = New System.Drawing.Point(405, 181)
        Me.TXT_NombreProv.Name = "TXT_NombreProv"
        Me.TXT_NombreProv.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TXT_NombreProv.PlaceholderText = ""
        Me.TXT_NombreProv.SelectedText = ""
        Me.TXT_NombreProv.Size = New System.Drawing.Size(278, 31)
        Me.TXT_NombreProv.TabIndex = 48
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Britannic Bold", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(312, 185)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(87, 23)
        Me.Label2.TabIndex = 47
        Me.Label2.Text = "Nombre:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Britannic Bold", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(12, 185)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(79, 23)
        Me.Label1.TabIndex = 49
        Me.Label1.Text = "Codigo:"
        '
        'TXT_CodigoProv
        '
        Me.TXT_CodigoProv.AutoRoundedCorners = True
        Me.TXT_CodigoProv.BorderRadius = 14
        Me.TXT_CodigoProv.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TXT_CodigoProv.DefaultText = ""
        Me.TXT_CodigoProv.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TXT_CodigoProv.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TXT_CodigoProv.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXT_CodigoProv.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXT_CodigoProv.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXT_CodigoProv.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.TXT_CodigoProv.ForeColor = System.Drawing.Color.Black
        Me.TXT_CodigoProv.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXT_CodigoProv.Location = New System.Drawing.Point(97, 181)
        Me.TXT_CodigoProv.Name = "TXT_CodigoProv"
        Me.TXT_CodigoProv.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TXT_CodigoProv.PlaceholderText = ""
        Me.TXT_CodigoProv.SelectedText = ""
        Me.TXT_CodigoProv.Size = New System.Drawing.Size(134, 31)
        Me.TXT_CodigoProv.TabIndex = 50
        '
        'TXT_CorreoProv
        '
        Me.TXT_CorreoProv.AutoRoundedCorners = True
        Me.TXT_CorreoProv.BorderRadius = 14
        Me.TXT_CorreoProv.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TXT_CorreoProv.DefaultText = ""
        Me.TXT_CorreoProv.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TXT_CorreoProv.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TXT_CorreoProv.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXT_CorreoProv.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXT_CorreoProv.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXT_CorreoProv.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.TXT_CorreoProv.ForeColor = System.Drawing.Color.Black
        Me.TXT_CorreoProv.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXT_CorreoProv.Location = New System.Drawing.Point(97, 237)
        Me.TXT_CorreoProv.Name = "TXT_CorreoProv"
        Me.TXT_CorreoProv.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TXT_CorreoProv.PlaceholderText = ""
        Me.TXT_CorreoProv.SelectedText = ""
        Me.TXT_CorreoProv.Size = New System.Drawing.Size(586, 31)
        Me.TXT_CorreoProv.TabIndex = 52
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Britannic Bold", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(12, 241)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(79, 23)
        Me.Label3.TabIndex = 51
        Me.Label3.Text = "Correo:"
        '
        'TXT_TelProv
        '
        Me.TXT_TelProv.AutoRoundedCorners = True
        Me.TXT_TelProv.BorderRadius = 14
        Me.TXT_TelProv.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TXT_TelProv.DefaultText = ""
        Me.TXT_TelProv.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TXT_TelProv.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TXT_TelProv.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXT_TelProv.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXT_TelProv.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXT_TelProv.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.TXT_TelProv.ForeColor = System.Drawing.Color.Black
        Me.TXT_TelProv.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXT_TelProv.Location = New System.Drawing.Point(105, 290)
        Me.TXT_TelProv.Name = "TXT_TelProv"
        Me.TXT_TelProv.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TXT_TelProv.PlaceholderText = ""
        Me.TXT_TelProv.SelectedText = ""
        Me.TXT_TelProv.Size = New System.Drawing.Size(218, 31)
        Me.TXT_TelProv.TabIndex = 54
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Britannic Bold", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(5, 294)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(94, 23)
        Me.Label4.TabIndex = 53
        Me.Label4.Text = "Telefono:"
        '
        'BTN_RegresarProv
        '
        Me.BTN_RegresarProv.BorderColor = System.Drawing.Color.Red
        Me.BTN_RegresarProv.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.BTN_RegresarProv.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BTN_RegresarProv.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BTN_RegresarProv.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BTN_RegresarProv.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BTN_RegresarProv.Dock = System.Windows.Forms.DockStyle.Left
        Me.BTN_RegresarProv.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BTN_RegresarProv.Font = New System.Drawing.Font("Ebrima", 20.25!, System.Drawing.FontStyle.Bold)
        Me.BTN_RegresarProv.ForeColor = System.Drawing.Color.White
        Me.BTN_RegresarProv.Image = CType(resources.GetObject("BTN_RegresarProv.Image"), System.Drawing.Image)
        Me.BTN_RegresarProv.ImageSize = New System.Drawing.Size(40, 40)
        Me.BTN_RegresarProv.Location = New System.Drawing.Point(0, 0)
        Me.BTN_RegresarProv.Name = "BTN_RegresarProv"
        Me.BTN_RegresarProv.Size = New System.Drawing.Size(231, 67)
        Me.BTN_RegresarProv.TabIndex = 60
        Me.BTN_RegresarProv.Text = "Regresar"
        '
        'BTN_NProv
        '
        Me.BTN_NProv.BorderColor = System.Drawing.Color.Red
        Me.BTN_NProv.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BTN_NProv.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BTN_NProv.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BTN_NProv.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BTN_NProv.Dock = System.Windows.Forms.DockStyle.Right
        Me.BTN_NProv.FillColor = System.Drawing.Color.MediumSeaGreen
        Me.BTN_NProv.Font = New System.Drawing.Font("Ebrima", 20.25!, System.Drawing.FontStyle.Bold)
        Me.BTN_NProv.ForeColor = System.Drawing.Color.White
        Me.BTN_NProv.Image = CType(resources.GetObject("BTN_NProv.Image"), System.Drawing.Image)
        Me.BTN_NProv.ImageSize = New System.Drawing.Size(60, 60)
        Me.BTN_NProv.Location = New System.Drawing.Point(484, 0)
        Me.BTN_NProv.Name = "BTN_NProv"
        Me.BTN_NProv.Size = New System.Drawing.Size(229, 67)
        Me.BTN_NProv.TabIndex = 59
        Me.BTN_NProv.Text = "Guardar"
        '
        'BTN_Pedidos
        '
        Me.BTN_Pedidos.BorderColor = System.Drawing.Color.Red
        Me.BTN_Pedidos.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BTN_Pedidos.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BTN_Pedidos.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BTN_Pedidos.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BTN_Pedidos.Dock = System.Windows.Forms.DockStyle.Right
        Me.BTN_Pedidos.FillColor = System.Drawing.Color.DarkOrange
        Me.BTN_Pedidos.Font = New System.Drawing.Font("Ebrima", 20.25!, System.Drawing.FontStyle.Bold)
        Me.BTN_Pedidos.ForeColor = System.Drawing.Color.White
        Me.BTN_Pedidos.Image = CType(resources.GetObject("BTN_Pedidos.Image"), System.Drawing.Image)
        Me.BTN_Pedidos.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.BTN_Pedidos.ImageSize = New System.Drawing.Size(60, 60)
        Me.BTN_Pedidos.Location = New System.Drawing.Point(229, 0)
        Me.BTN_Pedidos.Name = "BTN_Pedidos"
        Me.BTN_Pedidos.Size = New System.Drawing.Size(255, 67)
        Me.BTN_Pedidos.TabIndex = 61
        Me.BTN_Pedidos.Text = "Pedidos"
        Me.BTN_Pedidos.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'BTN_AutoCod
        '
        Me.BTN_AutoCod.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BTN_AutoCod.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BTN_AutoCod.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BTN_AutoCod.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BTN_AutoCod.FillColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BTN_AutoCod.Font = New System.Drawing.Font("Snap ITC", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_AutoCod.ForeColor = System.Drawing.Color.White
        Me.BTN_AutoCod.ImageSize = New System.Drawing.Size(90, 90)
        Me.BTN_AutoCod.Location = New System.Drawing.Point(237, 175)
        Me.BTN_AutoCod.Name = "BTN_AutoCod"
        Me.BTN_AutoCod.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.BTN_AutoCod.Size = New System.Drawing.Size(44, 44)
        Me.BTN_AutoCod.TabIndex = 113
        Me.BTN_AutoCod.Text = "+"
        Me.BTN_AutoCod.TextOffset = New System.Drawing.Point(2, -2)
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.Controls.Add(Me.BTN_RegresarProv)
        Me.Guna2Panel1.Controls.Add(Me.BTN_Pedidos)
        Me.Guna2Panel1.Controls.Add(Me.BTN_NProv)
        Me.Guna2Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Guna2Panel1.Location = New System.Drawing.Point(0, 346)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.Size = New System.Drawing.Size(713, 67)
        Me.Guna2Panel1.TabIndex = 114
        '
        'E_NuevoProveedor
        '
        Me.AcceptButton = Me.BTN_NProv
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.CancelButton = Me.BTN_RegresarProv
        Me.ClientSize = New System.Drawing.Size(713, 413)
        Me.Controls.Add(Me.Guna2Panel1)
        Me.Controls.Add(Me.BTN_AutoCod)
        Me.Controls.Add(Me.TXT_TelProv)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TXT_CorreoProv)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TXT_CodigoProv)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TXT_NombreProv)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Guna2PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Name = "E_NuevoProveedor"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Mantenimiento de proveedores"
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Guna2Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Guna2BorderlessForm1 As Guna.UI2.WinForms.Guna2BorderlessForm
    Friend WithEvents Guna2PictureBox1 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents TXT_NombreProv As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TXT_TelProv As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TXT_CorreoProv As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TXT_CodigoProv As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents BTN_RegresarProv As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BTN_NProv As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BTN_Pedidos As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BTN_AutoCod As Guna.UI2.WinForms.Guna2CircleButton
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
End Class
