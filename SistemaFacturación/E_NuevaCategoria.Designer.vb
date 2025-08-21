<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class E_NuevaCategoria
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(E_NuevaCategoria))
        Me.BTN_RegresarCat = New Guna.UI2.WinForms.Guna2Button()
        Me.BTN_NCat = New Guna.UI2.WinForms.Guna2Button()
        Me.BTN_Color = New Guna.UI2.WinForms.Guna2TileButton()
        Me.TXT_NombreCat = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TXT_CodCat = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Guna2PictureBox1 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.Guna2BorderlessForm1 = New Guna.UI2.WinForms.Guna2BorderlessForm(Me.components)
        Me.ColorDialog1 = New System.Windows.Forms.ColorDialog()
        Me.BTN_AutoCod = New Guna.UI2.WinForms.Guna2CircleButton()
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Guna2Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'BTN_RegresarCat
        '
        Me.BTN_RegresarCat.BorderColor = System.Drawing.Color.Red
        Me.BTN_RegresarCat.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.BTN_RegresarCat.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BTN_RegresarCat.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BTN_RegresarCat.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BTN_RegresarCat.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BTN_RegresarCat.Dock = System.Windows.Forms.DockStyle.Left
        Me.BTN_RegresarCat.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BTN_RegresarCat.Font = New System.Drawing.Font("Ebrima", 20.25!, System.Drawing.FontStyle.Bold)
        Me.BTN_RegresarCat.ForeColor = System.Drawing.Color.White
        Me.BTN_RegresarCat.Image = CType(resources.GetObject("BTN_RegresarCat.Image"), System.Drawing.Image)
        Me.BTN_RegresarCat.ImageSize = New System.Drawing.Size(40, 40)
        Me.BTN_RegresarCat.Location = New System.Drawing.Point(0, 0)
        Me.BTN_RegresarCat.Name = "BTN_RegresarCat"
        Me.BTN_RegresarCat.Size = New System.Drawing.Size(251, 61)
        Me.BTN_RegresarCat.TabIndex = 41
        Me.BTN_RegresarCat.Text = "Regresar"
        '
        'BTN_NCat
        '
        Me.BTN_NCat.BorderColor = System.Drawing.Color.Red
        Me.BTN_NCat.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BTN_NCat.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BTN_NCat.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BTN_NCat.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BTN_NCat.Dock = System.Windows.Forms.DockStyle.Right
        Me.BTN_NCat.FillColor = System.Drawing.Color.MediumSeaGreen
        Me.BTN_NCat.Font = New System.Drawing.Font("Ebrima", 20.25!, System.Drawing.FontStyle.Bold)
        Me.BTN_NCat.ForeColor = System.Drawing.Color.White
        Me.BTN_NCat.Image = CType(resources.GetObject("BTN_NCat.Image"), System.Drawing.Image)
        Me.BTN_NCat.ImageSize = New System.Drawing.Size(40, 40)
        Me.BTN_NCat.Location = New System.Drawing.Point(223, 0)
        Me.BTN_NCat.Name = "BTN_NCat"
        Me.BTN_NCat.Size = New System.Drawing.Size(278, 61)
        Me.BTN_NCat.TabIndex = 40
        Me.BTN_NCat.Text = "Guardar"
        '
        'BTN_Color
        '
        Me.BTN_Color.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BTN_Color.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BTN_Color.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BTN_Color.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BTN_Color.FillColor = System.Drawing.Color.White
        Me.BTN_Color.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BTN_Color.ForeColor = System.Drawing.Color.Black
        Me.BTN_Color.Location = New System.Drawing.Point(373, 199)
        Me.BTN_Color.Name = "BTN_Color"
        Me.BTN_Color.Size = New System.Drawing.Size(105, 81)
        Me.BTN_Color.TabIndex = 39
        Me.BTN_Color.Text = "Seleccione un color"
        '
        'TXT_NombreCat
        '
        Me.TXT_NombreCat.AutoRoundedCorners = True
        Me.TXT_NombreCat.BorderRadius = 14
        Me.TXT_NombreCat.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TXT_NombreCat.DefaultText = ""
        Me.TXT_NombreCat.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TXT_NombreCat.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TXT_NombreCat.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXT_NombreCat.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXT_NombreCat.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXT_NombreCat.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.TXT_NombreCat.ForeColor = System.Drawing.Color.Black
        Me.TXT_NombreCat.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXT_NombreCat.Location = New System.Drawing.Point(102, 249)
        Me.TXT_NombreCat.Name = "TXT_NombreCat"
        Me.TXT_NombreCat.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TXT_NombreCat.PlaceholderText = ""
        Me.TXT_NombreCat.SelectedText = ""
        Me.TXT_NombreCat.Size = New System.Drawing.Size(253, 31)
        Me.TXT_NombreCat.TabIndex = 36
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Britannic Bold", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(8, 253)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(87, 23)
        Me.Label2.TabIndex = 35
        Me.Label2.Text = "Nombre:"
        '
        'TXT_CodCat
        '
        Me.TXT_CodCat.AutoRoundedCorners = True
        Me.TXT_CodCat.BorderRadius = 14
        Me.TXT_CodCat.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TXT_CodCat.DefaultText = ""
        Me.TXT_CodCat.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TXT_CodCat.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TXT_CodCat.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXT_CodCat.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXT_CodCat.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXT_CodCat.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.TXT_CodCat.ForeColor = System.Drawing.Color.Black
        Me.TXT_CodCat.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXT_CodCat.Location = New System.Drawing.Point(102, 203)
        Me.TXT_CodCat.Name = "TXT_CodCat"
        Me.TXT_CodCat.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TXT_CodCat.PlaceholderText = ""
        Me.TXT_CodCat.SelectedText = ""
        Me.TXT_CodCat.Size = New System.Drawing.Size(203, 31)
        Me.TXT_CodCat.TabIndex = 34
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Britannic Bold", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(17, 206)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(79, 23)
        Me.Label1.TabIndex = 33
        Me.Label1.Text = "Codigo:"
        '
        'Guna2PictureBox1
        '
        Me.Guna2PictureBox1.Image = CType(resources.GetObject("Guna2PictureBox1.Image"), System.Drawing.Image)
        Me.Guna2PictureBox1.ImageRotate = 0!
        Me.Guna2PictureBox1.Location = New System.Drawing.Point(41, -85)
        Me.Guna2PictureBox1.Name = "Guna2PictureBox1"
        Me.Guna2PictureBox1.Size = New System.Drawing.Size(409, 361)
        Me.Guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Guna2PictureBox1.TabIndex = 32
        Me.Guna2PictureBox1.TabStop = False
        '
        'Guna2BorderlessForm1
        '
        Me.Guna2BorderlessForm1.BorderRadius = 25
        Me.Guna2BorderlessForm1.ContainerControl = Me
        Me.Guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6R
        Me.Guna2BorderlessForm1.TransparentWhileDrag = True
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
        Me.BTN_AutoCod.Location = New System.Drawing.Point(311, 199)
        Me.BTN_AutoCod.Name = "BTN_AutoCod"
        Me.BTN_AutoCod.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.BTN_AutoCod.Size = New System.Drawing.Size(44, 44)
        Me.BTN_AutoCod.TabIndex = 111
        Me.BTN_AutoCod.Text = "+"
        Me.BTN_AutoCod.TextOffset = New System.Drawing.Point(2, -2)
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.Controls.Add(Me.BTN_RegresarCat)
        Me.Guna2Panel1.Controls.Add(Me.BTN_NCat)
        Me.Guna2Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Guna2Panel1.Location = New System.Drawing.Point(0, 301)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.Size = New System.Drawing.Size(501, 61)
        Me.Guna2Panel1.TabIndex = 112
        '
        'E_NuevaCategoria
        '
        Me.AcceptButton = Me.BTN_NCat
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.CancelButton = Me.BTN_RegresarCat
        Me.ClientSize = New System.Drawing.Size(501, 362)
        Me.Controls.Add(Me.Guna2Panel1)
        Me.Controls.Add(Me.BTN_AutoCod)
        Me.Controls.Add(Me.BTN_Color)
        Me.Controls.Add(Me.TXT_NombreCat)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TXT_CodCat)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Guna2PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Name = "E_NuevaCategoria"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Mantenimiento de categorías"
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Guna2Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BTN_RegresarCat As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BTN_NCat As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BTN_Color As Guna.UI2.WinForms.Guna2TileButton
    Friend WithEvents TXT_NombreCat As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TXT_CodCat As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Guna2PictureBox1 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents Guna2BorderlessForm1 As Guna.UI2.WinForms.Guna2BorderlessForm
    Friend WithEvents ColorDialog1 As ColorDialog
    Friend WithEvents BTN_AutoCod As Guna.UI2.WinForms.Guna2CircleButton
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
End Class
