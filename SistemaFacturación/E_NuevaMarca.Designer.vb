<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class E_NuevaMarca
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(E_NuevaMarca))
        Me.BTN_RegresarMarca = New Guna.UI2.WinForms.Guna2Button()
        Me.BTN_NMarca = New Guna.UI2.WinForms.Guna2Button()
        Me.TXT_NombreMarca = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TXT_CodMarca = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Guna2PictureBox1 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.Guna2BorderlessForm1 = New Guna.UI2.WinForms.Guna2BorderlessForm(Me.components)
        Me.BTN_AutoCod = New Guna.UI2.WinForms.Guna2CircleButton()
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Guna2Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'BTN_RegresarMarca
        '
        Me.BTN_RegresarMarca.BorderColor = System.Drawing.Color.Red
        Me.BTN_RegresarMarca.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.BTN_RegresarMarca.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BTN_RegresarMarca.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BTN_RegresarMarca.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BTN_RegresarMarca.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BTN_RegresarMarca.Dock = System.Windows.Forms.DockStyle.Left
        Me.BTN_RegresarMarca.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BTN_RegresarMarca.Font = New System.Drawing.Font("Ebrima", 20.25!, System.Drawing.FontStyle.Bold)
        Me.BTN_RegresarMarca.ForeColor = System.Drawing.Color.White
        Me.BTN_RegresarMarca.Image = CType(resources.GetObject("BTN_RegresarMarca.Image"), System.Drawing.Image)
        Me.BTN_RegresarMarca.ImageSize = New System.Drawing.Size(40, 40)
        Me.BTN_RegresarMarca.Location = New System.Drawing.Point(0, 0)
        Me.BTN_RegresarMarca.Name = "BTN_RegresarMarca"
        Me.BTN_RegresarMarca.Size = New System.Drawing.Size(219, 65)
        Me.BTN_RegresarMarca.TabIndex = 49
        Me.BTN_RegresarMarca.Text = "Regresar"
        '
        'BTN_NMarca
        '
        Me.BTN_NMarca.BorderColor = System.Drawing.Color.Red
        Me.BTN_NMarca.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BTN_NMarca.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BTN_NMarca.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BTN_NMarca.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BTN_NMarca.Dock = System.Windows.Forms.DockStyle.Right
        Me.BTN_NMarca.FillColor = System.Drawing.Color.MediumSeaGreen
        Me.BTN_NMarca.Font = New System.Drawing.Font("Ebrima", 20.25!, System.Drawing.FontStyle.Bold)
        Me.BTN_NMarca.ForeColor = System.Drawing.Color.White
        Me.BTN_NMarca.Image = CType(resources.GetObject("BTN_NMarca.Image"), System.Drawing.Image)
        Me.BTN_NMarca.ImageSize = New System.Drawing.Size(40, 40)
        Me.BTN_NMarca.Location = New System.Drawing.Point(214, 0)
        Me.BTN_NMarca.Name = "BTN_NMarca"
        Me.BTN_NMarca.Size = New System.Drawing.Size(233, 65)
        Me.BTN_NMarca.TabIndex = 48
        Me.BTN_NMarca.Text = "Guardar"
        '
        'TXT_NombreMarca
        '
        Me.TXT_NombreMarca.AutoRoundedCorners = True
        Me.TXT_NombreMarca.BorderRadius = 14
        Me.TXT_NombreMarca.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TXT_NombreMarca.DefaultText = ""
        Me.TXT_NombreMarca.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TXT_NombreMarca.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TXT_NombreMarca.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXT_NombreMarca.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXT_NombreMarca.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXT_NombreMarca.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.TXT_NombreMarca.ForeColor = System.Drawing.Color.Black
        Me.TXT_NombreMarca.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXT_NombreMarca.Location = New System.Drawing.Point(112, 234)
        Me.TXT_NombreMarca.Name = "TXT_NombreMarca"
        Me.TXT_NombreMarca.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TXT_NombreMarca.PlaceholderText = ""
        Me.TXT_NombreMarca.SelectedText = ""
        Me.TXT_NombreMarca.Size = New System.Drawing.Size(309, 31)
        Me.TXT_NombreMarca.TabIndex = 46
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Britannic Bold", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(18, 238)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(87, 23)
        Me.Label2.TabIndex = 45
        Me.Label2.Text = "Nombre:"
        '
        'TXT_CodMarca
        '
        Me.TXT_CodMarca.AutoRoundedCorners = True
        Me.TXT_CodMarca.BorderRadius = 14
        Me.TXT_CodMarca.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TXT_CodMarca.DefaultText = ""
        Me.TXT_CodMarca.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TXT_CodMarca.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TXT_CodMarca.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXT_CodMarca.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXT_CodMarca.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXT_CodMarca.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.TXT_CodMarca.ForeColor = System.Drawing.Color.Black
        Me.TXT_CodMarca.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXT_CodMarca.Location = New System.Drawing.Point(112, 188)
        Me.TXT_CodMarca.Name = "TXT_CodMarca"
        Me.TXT_CodMarca.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TXT_CodMarca.PlaceholderText = ""
        Me.TXT_CodMarca.SelectedText = ""
        Me.TXT_CodMarca.Size = New System.Drawing.Size(175, 31)
        Me.TXT_CodMarca.TabIndex = 44
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Britannic Bold", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(27, 191)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(79, 23)
        Me.Label1.TabIndex = 43
        Me.Label1.Text = "Codigo:"
        '
        'Guna2PictureBox1
        '
        Me.Guna2PictureBox1.Image = CType(resources.GetObject("Guna2PictureBox1.Image"), System.Drawing.Image)
        Me.Guna2PictureBox1.ImageRotate = 0!
        Me.Guna2PictureBox1.Location = New System.Drawing.Point(12, -100)
        Me.Guna2PictureBox1.Name = "Guna2PictureBox1"
        Me.Guna2PictureBox1.Size = New System.Drawing.Size(409, 361)
        Me.Guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Guna2PictureBox1.TabIndex = 42
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
        Me.BTN_AutoCod.Location = New System.Drawing.Point(293, 184)
        Me.BTN_AutoCod.Name = "BTN_AutoCod"
        Me.BTN_AutoCod.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.BTN_AutoCod.Size = New System.Drawing.Size(44, 44)
        Me.BTN_AutoCod.TabIndex = 112
        Me.BTN_AutoCod.Text = "+"
        Me.BTN_AutoCod.TextOffset = New System.Drawing.Point(2, -2)
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.Controls.Add(Me.BTN_NMarca)
        Me.Guna2Panel1.Controls.Add(Me.BTN_RegresarMarca)
        Me.Guna2Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Guna2Panel1.Location = New System.Drawing.Point(0, 285)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.Size = New System.Drawing.Size(447, 65)
        Me.Guna2Panel1.TabIndex = 113
        '
        'E_NuevaMarca
        '
        Me.AcceptButton = Me.BTN_NMarca
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.CancelButton = Me.BTN_RegresarMarca
        Me.ClientSize = New System.Drawing.Size(447, 350)
        Me.Controls.Add(Me.Guna2Panel1)
        Me.Controls.Add(Me.BTN_AutoCod)
        Me.Controls.Add(Me.TXT_NombreMarca)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TXT_CodMarca)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Guna2PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Name = "E_NuevaMarca"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Mantenimiento de marcas"
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Guna2Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BTN_RegresarMarca As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BTN_NMarca As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents TXT_NombreMarca As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TXT_CodMarca As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Guna2PictureBox1 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents Guna2BorderlessForm1 As Guna.UI2.WinForms.Guna2BorderlessForm
    Friend WithEvents BTN_AutoCod As Guna.UI2.WinForms.Guna2CircleButton
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
End Class
