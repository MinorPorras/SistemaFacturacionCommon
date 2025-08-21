<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class E_NuevoCliente
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(E_NuevoCliente))
        Me.Guna2BorderlessForm1 = New Guna.UI2.WinForms.Guna2BorderlessForm(Me.components)
        Me.BTN_RegresarCliente = New Guna.UI2.WinForms.Guna2Button()
        Me.BTN_NCliente = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2PictureBox1 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TXT_CodCliente = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TXT_CedCliente = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtNombreCliente = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TXT_TelCliente = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TXT_CorreoCliente = New Guna.UI2.WinForms.Guna2TextBox()
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
        'BTN_RegresarCliente
        '
        Me.BTN_RegresarCliente.BorderColor = System.Drawing.Color.Red
        Me.BTN_RegresarCliente.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.BTN_RegresarCliente.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BTN_RegresarCliente.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BTN_RegresarCliente.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BTN_RegresarCliente.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BTN_RegresarCliente.Dock = System.Windows.Forms.DockStyle.Left
        Me.BTN_RegresarCliente.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BTN_RegresarCliente.Font = New System.Drawing.Font("Ebrima", 20.25!, System.Drawing.FontStyle.Bold)
        Me.BTN_RegresarCliente.ForeColor = System.Drawing.Color.White
        Me.BTN_RegresarCliente.Image = CType(resources.GetObject("BTN_RegresarCliente.Image"), System.Drawing.Image)
        Me.BTN_RegresarCliente.ImageSize = New System.Drawing.Size(40, 40)
        Me.BTN_RegresarCliente.Location = New System.Drawing.Point(0, 0)
        Me.BTN_RegresarCliente.Name = "BTN_RegresarCliente"
        Me.BTN_RegresarCliente.Size = New System.Drawing.Size(263, 63)
        Me.BTN_RegresarCliente.TabIndex = 36
        Me.BTN_RegresarCliente.Text = "Regresar"
        '
        'BTN_NCliente
        '
        Me.BTN_NCliente.BorderColor = System.Drawing.Color.Red
        Me.BTN_NCliente.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BTN_NCliente.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BTN_NCliente.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BTN_NCliente.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BTN_NCliente.Dock = System.Windows.Forms.DockStyle.Right
        Me.BTN_NCliente.FillColor = System.Drawing.Color.MediumSeaGreen
        Me.BTN_NCliente.Font = New System.Drawing.Font("Ebrima", 20.25!, System.Drawing.FontStyle.Bold)
        Me.BTN_NCliente.ForeColor = System.Drawing.Color.White
        Me.BTN_NCliente.Image = CType(resources.GetObject("BTN_NCliente.Image"), System.Drawing.Image)
        Me.BTN_NCliente.ImageSize = New System.Drawing.Size(40, 40)
        Me.BTN_NCliente.Location = New System.Drawing.Point(259, 0)
        Me.BTN_NCliente.Name = "BTN_NCliente"
        Me.BTN_NCliente.Size = New System.Drawing.Size(265, 63)
        Me.BTN_NCliente.TabIndex = 35
        Me.BTN_NCliente.Text = "Agregar"
        '
        'Guna2PictureBox1
        '
        Me.Guna2PictureBox1.Image = CType(resources.GetObject("Guna2PictureBox1.Image"), System.Drawing.Image)
        Me.Guna2PictureBox1.ImageRotate = 0!
        Me.Guna2PictureBox1.Location = New System.Drawing.Point(56, -100)
        Me.Guna2PictureBox1.Name = "Guna2PictureBox1"
        Me.Guna2PictureBox1.Size = New System.Drawing.Size(420, 354)
        Me.Guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Guna2PictureBox1.TabIndex = 37
        Me.Guna2PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Britannic Bold", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(23, 183)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(79, 23)
        Me.Label1.TabIndex = 39
        Me.Label1.Text = "Codigo:"
        '
        'TXT_CodCliente
        '
        Me.TXT_CodCliente.AutoRoundedCorners = True
        Me.TXT_CodCliente.BorderRadius = 14
        Me.TXT_CodCliente.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TXT_CodCliente.DefaultText = ""
        Me.TXT_CodCliente.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TXT_CodCliente.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TXT_CodCliente.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXT_CodCliente.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXT_CodCliente.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXT_CodCliente.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.TXT_CodCliente.ForeColor = System.Drawing.Color.Black
        Me.TXT_CodCliente.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXT_CodCliente.Location = New System.Drawing.Point(108, 179)
        Me.TXT_CodCliente.Name = "TXT_CodCliente"
        Me.TXT_CodCliente.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TXT_CodCliente.PlaceholderText = ""
        Me.TXT_CodCliente.SelectedText = ""
        Me.TXT_CodCliente.Size = New System.Drawing.Size(276, 31)
        Me.TXT_CodCliente.TabIndex = 38
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Britannic Bold", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(23, 220)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(73, 23)
        Me.Label2.TabIndex = 41
        Me.Label2.Text = "Cedula"
        '
        'TXT_CedCliente
        '
        Me.TXT_CedCliente.AutoRoundedCorners = True
        Me.TXT_CedCliente.BorderRadius = 14
        Me.TXT_CedCliente.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TXT_CedCliente.DefaultText = ""
        Me.TXT_CedCliente.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TXT_CedCliente.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TXT_CedCliente.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXT_CedCliente.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXT_CedCliente.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXT_CedCliente.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.TXT_CedCliente.ForeColor = System.Drawing.Color.Black
        Me.TXT_CedCliente.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXT_CedCliente.Location = New System.Drawing.Point(108, 216)
        Me.TXT_CedCliente.Name = "TXT_CedCliente"
        Me.TXT_CedCliente.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TXT_CedCliente.PlaceholderText = ""
        Me.TXT_CedCliente.SelectedText = ""
        Me.TXT_CedCliente.Size = New System.Drawing.Size(398, 31)
        Me.TXT_CedCliente.TabIndex = 40
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Britannic Bold", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(18, 257)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(87, 23)
        Me.Label3.TabIndex = 43
        Me.Label3.Text = "Nombre:"
        '
        'txtNombreCliente
        '
        Me.txtNombreCliente.AutoRoundedCorners = True
        Me.txtNombreCliente.BorderRadius = 14
        Me.txtNombreCliente.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtNombreCliente.DefaultText = ""
        Me.txtNombreCliente.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtNombreCliente.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtNombreCliente.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtNombreCliente.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtNombreCliente.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtNombreCliente.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtNombreCliente.ForeColor = System.Drawing.Color.Black
        Me.txtNombreCliente.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtNombreCliente.Location = New System.Drawing.Point(108, 253)
        Me.txtNombreCliente.Name = "txtNombreCliente"
        Me.txtNombreCliente.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtNombreCliente.PlaceholderText = ""
        Me.txtNombreCliente.SelectedText = ""
        Me.txtNombreCliente.Size = New System.Drawing.Size(398, 31)
        Me.txtNombreCliente.TabIndex = 42
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Britannic Bold", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(12, 294)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(94, 23)
        Me.Label4.TabIndex = 45
        Me.Label4.Text = "Telefono:"
        '
        'TXT_TelCliente
        '
        Me.TXT_TelCliente.AutoRoundedCorners = True
        Me.TXT_TelCliente.BorderRadius = 14
        Me.TXT_TelCliente.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TXT_TelCliente.DefaultText = ""
        Me.TXT_TelCliente.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TXT_TelCliente.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TXT_TelCliente.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXT_TelCliente.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXT_TelCliente.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXT_TelCliente.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.TXT_TelCliente.ForeColor = System.Drawing.Color.Black
        Me.TXT_TelCliente.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXT_TelCliente.Location = New System.Drawing.Point(108, 290)
        Me.TXT_TelCliente.Name = "TXT_TelCliente"
        Me.TXT_TelCliente.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TXT_TelCliente.PlaceholderText = ""
        Me.TXT_TelCliente.SelectedText = ""
        Me.TXT_TelCliente.Size = New System.Drawing.Size(398, 31)
        Me.TXT_TelCliente.TabIndex = 44
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Britannic Bold", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(12, 331)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(79, 23)
        Me.Label5.TabIndex = 47
        Me.Label5.Text = "Correo:"
        '
        'TXT_CorreoCliente
        '
        Me.TXT_CorreoCliente.AutoRoundedCorners = True
        Me.TXT_CorreoCliente.BorderRadius = 14
        Me.TXT_CorreoCliente.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TXT_CorreoCliente.DefaultText = ""
        Me.TXT_CorreoCliente.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TXT_CorreoCliente.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TXT_CorreoCliente.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXT_CorreoCliente.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXT_CorreoCliente.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXT_CorreoCliente.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.TXT_CorreoCliente.ForeColor = System.Drawing.Color.Black
        Me.TXT_CorreoCliente.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXT_CorreoCliente.Location = New System.Drawing.Point(108, 327)
        Me.TXT_CorreoCliente.Name = "TXT_CorreoCliente"
        Me.TXT_CorreoCliente.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TXT_CorreoCliente.PlaceholderText = ""
        Me.TXT_CorreoCliente.SelectedText = ""
        Me.TXT_CorreoCliente.Size = New System.Drawing.Size(398, 31)
        Me.TXT_CorreoCliente.TabIndex = 46
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
        Me.BTN_AutoCod.Location = New System.Drawing.Point(390, 166)
        Me.BTN_AutoCod.Name = "BTN_AutoCod"
        Me.BTN_AutoCod.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.BTN_AutoCod.Size = New System.Drawing.Size(44, 44)
        Me.BTN_AutoCod.TabIndex = 113
        Me.BTN_AutoCod.Text = "+"
        Me.BTN_AutoCod.TextOffset = New System.Drawing.Point(2, -2)
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.Controls.Add(Me.BTN_RegresarCliente)
        Me.Guna2Panel1.Controls.Add(Me.BTN_NCliente)
        Me.Guna2Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Guna2Panel1.Location = New System.Drawing.Point(0, 388)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.Size = New System.Drawing.Size(524, 63)
        Me.Guna2Panel1.TabIndex = 114
        '
        'E_NuevoCliente
        '
        Me.AcceptButton = Me.BTN_NCliente
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.CancelButton = Me.BTN_RegresarCliente
        Me.ClientSize = New System.Drawing.Size(524, 451)
        Me.Controls.Add(Me.Guna2Panel1)
        Me.Controls.Add(Me.BTN_AutoCod)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TXT_CorreoCliente)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TXT_TelCliente)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtNombreCliente)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TXT_CedCliente)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TXT_CodCliente)
        Me.Controls.Add(Me.Guna2PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Name = "E_NuevoCliente"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Mantenimiento de clientes"
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Guna2Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Guna2BorderlessForm1 As Guna.UI2.WinForms.Guna2BorderlessForm
    Friend WithEvents BTN_RegresarCliente As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BTN_NCliente As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2PictureBox1 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TXT_CedCliente As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TXT_CodCliente As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TXT_CorreoCliente As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TXT_TelCliente As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtNombreCliente As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents BTN_AutoCod As Guna.UI2.WinForms.Guna2CircleButton
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
End Class
