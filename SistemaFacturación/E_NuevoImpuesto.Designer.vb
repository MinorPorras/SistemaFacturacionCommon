<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class E_NuevoImpuesto
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(E_NuevoImpuesto))
        Me.Guna2BorderlessForm1 = New Guna.UI2.WinForms.Guna2BorderlessForm(Me.components)
        Me.Guna2PictureBox1 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.TXT_CodImpuesto = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TXT_DescImpuesto = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.NUD_Porc = New Guna.UI2.WinForms.Guna2NumericUpDown()
        Me.BTN_RegresarImp = New Guna.UI2.WinForms.Guna2Button()
        Me.BTN_NImpuesto = New Guna.UI2.WinForms.Guna2Button()
        Me.BTN_AutoCod = New Guna.UI2.WinForms.Guna2CircleButton()
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NUD_Porc, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.Guna2PictureBox1.Location = New System.Drawing.Point(16, -93)
        Me.Guna2PictureBox1.Name = "Guna2PictureBox1"
        Me.Guna2PictureBox1.Size = New System.Drawing.Size(397, 328)
        Me.Guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Guna2PictureBox1.TabIndex = 26
        Me.Guna2PictureBox1.TabStop = False
        '
        'TXT_CodImpuesto
        '
        Me.TXT_CodImpuesto.AutoRoundedCorners = True
        Me.TXT_CodImpuesto.BorderRadius = 14
        Me.TXT_CodImpuesto.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TXT_CodImpuesto.DefaultText = ""
        Me.TXT_CodImpuesto.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TXT_CodImpuesto.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TXT_CodImpuesto.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXT_CodImpuesto.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXT_CodImpuesto.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXT_CodImpuesto.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.TXT_CodImpuesto.ForeColor = System.Drawing.Color.Black
        Me.TXT_CodImpuesto.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXT_CodImpuesto.Location = New System.Drawing.Point(143, 148)
        Me.TXT_CodImpuesto.Name = "TXT_CodImpuesto"
        Me.TXT_CodImpuesto.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TXT_CodImpuesto.PlaceholderText = ""
        Me.TXT_CodImpuesto.SelectedText = ""
        Me.TXT_CodImpuesto.Size = New System.Drawing.Size(182, 31)
        Me.TXT_CodImpuesto.TabIndex = 28
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Britannic Bold", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(31, 151)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(79, 23)
        Me.Label1.TabIndex = 27
        Me.Label1.Text = "Codigo:"
        '
        'TXT_DescImpuesto
        '
        Me.TXT_DescImpuesto.AutoRoundedCorners = True
        Me.TXT_DescImpuesto.BorderRadius = 14
        Me.TXT_DescImpuesto.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TXT_DescImpuesto.DefaultText = ""
        Me.TXT_DescImpuesto.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TXT_DescImpuesto.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TXT_DescImpuesto.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXT_DescImpuesto.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXT_DescImpuesto.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXT_DescImpuesto.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.TXT_DescImpuesto.ForeColor = System.Drawing.Color.Black
        Me.TXT_DescImpuesto.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXT_DescImpuesto.Location = New System.Drawing.Point(143, 204)
        Me.TXT_DescImpuesto.Name = "TXT_DescImpuesto"
        Me.TXT_DescImpuesto.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TXT_DescImpuesto.PlaceholderText = ""
        Me.TXT_DescImpuesto.SelectedText = ""
        Me.TXT_DescImpuesto.Size = New System.Drawing.Size(279, 31)
        Me.TXT_DescImpuesto.TabIndex = 30
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Britannic Bold", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(12, 208)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(125, 23)
        Me.Label2.TabIndex = 29
        Me.Label2.Text = "Descripción:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Britannic Bold", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(22, 260)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(115, 23)
        Me.Label3.TabIndex = 31
        Me.Label3.Text = "Porcentaje:"
        '
        'NUD_Porc
        '
        Me.NUD_Porc.AutoRoundedCorners = True
        Me.NUD_Porc.BackColor = System.Drawing.Color.Transparent
        Me.NUD_Porc.BorderRadius = 14
        Me.NUD_Porc.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.NUD_Porc.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.NUD_Porc.Location = New System.Drawing.Point(143, 258)
        Me.NUD_Porc.Name = "NUD_Porc"
        Me.NUD_Porc.Size = New System.Drawing.Size(279, 31)
        Me.NUD_Porc.TabIndex = 32
        Me.NUD_Porc.UpDownButtonFillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        '
        'BTN_RegresarImp
        '
        Me.BTN_RegresarImp.BorderColor = System.Drawing.Color.Red
        Me.BTN_RegresarImp.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.BTN_RegresarImp.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BTN_RegresarImp.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BTN_RegresarImp.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BTN_RegresarImp.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BTN_RegresarImp.Dock = System.Windows.Forms.DockStyle.Left
        Me.BTN_RegresarImp.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BTN_RegresarImp.Font = New System.Drawing.Font("Ebrima", 20.25!, System.Drawing.FontStyle.Bold)
        Me.BTN_RegresarImp.ForeColor = System.Drawing.Color.White
        Me.BTN_RegresarImp.Image = CType(resources.GetObject("BTN_RegresarImp.Image"), System.Drawing.Image)
        Me.BTN_RegresarImp.ImageSize = New System.Drawing.Size(40, 40)
        Me.BTN_RegresarImp.Location = New System.Drawing.Point(0, 0)
        Me.BTN_RegresarImp.Name = "BTN_RegresarImp"
        Me.BTN_RegresarImp.Size = New System.Drawing.Size(216, 73)
        Me.BTN_RegresarImp.TabIndex = 34
        Me.BTN_RegresarImp.Text = "Regresar"
        '
        'BTN_NImpuesto
        '
        Me.BTN_NImpuesto.BorderColor = System.Drawing.Color.Red
        Me.BTN_NImpuesto.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BTN_NImpuesto.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BTN_NImpuesto.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BTN_NImpuesto.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BTN_NImpuesto.Dock = System.Windows.Forms.DockStyle.Right
        Me.BTN_NImpuesto.FillColor = System.Drawing.Color.MediumSeaGreen
        Me.BTN_NImpuesto.Font = New System.Drawing.Font("Ebrima", 20.25!, System.Drawing.FontStyle.Bold)
        Me.BTN_NImpuesto.ForeColor = System.Drawing.Color.White
        Me.BTN_NImpuesto.Image = CType(resources.GetObject("BTN_NImpuesto.Image"), System.Drawing.Image)
        Me.BTN_NImpuesto.ImageSize = New System.Drawing.Size(40, 40)
        Me.BTN_NImpuesto.Location = New System.Drawing.Point(210, 0)
        Me.BTN_NImpuesto.Name = "BTN_NImpuesto"
        Me.BTN_NImpuesto.Size = New System.Drawing.Size(220, 73)
        Me.BTN_NImpuesto.TabIndex = 33
        Me.BTN_NImpuesto.Text = "Guardar"
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
        Me.BTN_AutoCod.Location = New System.Drawing.Point(331, 141)
        Me.BTN_AutoCod.Name = "BTN_AutoCod"
        Me.BTN_AutoCod.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.BTN_AutoCod.Size = New System.Drawing.Size(44, 44)
        Me.BTN_AutoCod.TabIndex = 113
        Me.BTN_AutoCod.Text = "+"
        Me.BTN_AutoCod.TextOffset = New System.Drawing.Point(2, -2)
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.Controls.Add(Me.BTN_RegresarImp)
        Me.Guna2Panel1.Controls.Add(Me.BTN_NImpuesto)
        Me.Guna2Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Guna2Panel1.Location = New System.Drawing.Point(0, 310)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.Size = New System.Drawing.Size(430, 73)
        Me.Guna2Panel1.TabIndex = 114
        '
        'E_NuevoImpuesto
        '
        Me.AcceptButton = Me.BTN_NImpuesto
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.CancelButton = Me.BTN_RegresarImp
        Me.ClientSize = New System.Drawing.Size(430, 383)
        Me.Controls.Add(Me.Guna2Panel1)
        Me.Controls.Add(Me.BTN_AutoCod)
        Me.Controls.Add(Me.NUD_Porc)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TXT_DescImpuesto)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TXT_CodImpuesto)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Guna2PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Name = "E_NuevoImpuesto"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Mantenimiento de impuestos"
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NUD_Porc, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Guna2Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Guna2BorderlessForm1 As Guna.UI2.WinForms.Guna2BorderlessForm
    Friend WithEvents Guna2PictureBox1 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents TXT_DescImpuesto As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TXT_CodImpuesto As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents NUD_Porc As Guna.UI2.WinForms.Guna2NumericUpDown
    Friend WithEvents Label3 As Label
    Friend WithEvents BTN_RegresarImp As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BTN_NImpuesto As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BTN_AutoCod As Guna.UI2.WinForms.Guna2CircleButton
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
End Class
