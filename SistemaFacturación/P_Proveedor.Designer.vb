<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class P_Proveedor
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(P_Proveedor))
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Guna2BorderlessForm1 = New Guna.UI2.WinForms.Guna2BorderlessForm(Me.components)
        Me.MNU_CONTX = New Guna.UI2.WinForms.Guna2ContextMenuStrip()
        Me.MNU_MODIFICAR = New System.Windows.Forms.ToolStripMenuItem()
        Me.MNU_ELIMINAR = New System.Windows.Forms.ToolStripMenuItem()
        Me.BTN_RegresarProv = New Guna.UI2.WinForms.Guna2Button()
        Me.BTN_NProv = New Guna.UI2.WinForms.Guna2Button()
        Me.TXT_BuscarProv = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2PictureBox1 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.DGV_Prov = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2Panel4 = New Guna.UI2.WinForms.Guna2Panel()
        Me.BTN_Config = New Guna.UI2.WinForms.Guna2ImageButton()
        Me.BTN_CerrarApp = New Guna.UI2.WinForms.Guna2ImageButton()
        Me.MNU_CONTX.SuspendLayout()
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGV_Prov, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Guna2Panel1.SuspendLayout()
        Me.Guna2Panel4.SuspendLayout()
        Me.SuspendLayout()
        '
        'Guna2BorderlessForm1
        '
        Me.Guna2BorderlessForm1.BorderRadius = 25
        Me.Guna2BorderlessForm1.ContainerControl = Me
        Me.Guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6R
        Me.Guna2BorderlessForm1.TransparentWhileDrag = True
        '
        'MNU_CONTX
        '
        Me.MNU_CONTX.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MNU_CONTX.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MNU_MODIFICAR, Me.MNU_ELIMINAR})
        Me.MNU_CONTX.Name = "MNU_CONTX"
        Me.MNU_CONTX.RenderStyle.ArrowColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.MNU_CONTX.RenderStyle.BorderColor = System.Drawing.Color.Gainsboro
        Me.MNU_CONTX.RenderStyle.ColorTable = Nothing
        Me.MNU_CONTX.RenderStyle.RoundedEdges = True
        Me.MNU_CONTX.RenderStyle.SelectionArrowColor = System.Drawing.Color.White
        Me.MNU_CONTX.RenderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.MNU_CONTX.RenderStyle.SelectionForeColor = System.Drawing.Color.White
        Me.MNU_CONTX.RenderStyle.SeparatorColor = System.Drawing.Color.Gainsboro
        Me.MNU_CONTX.RenderStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault
        Me.MNU_CONTX.Size = New System.Drawing.Size(136, 56)
        '
        'MNU_MODIFICAR
        '
        Me.MNU_MODIFICAR.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MNU_MODIFICAR.Image = CType(resources.GetObject("MNU_MODIFICAR.Image"), System.Drawing.Image)
        Me.MNU_MODIFICAR.Name = "MNU_MODIFICAR"
        Me.MNU_MODIFICAR.Size = New System.Drawing.Size(135, 26)
        Me.MNU_MODIFICAR.Text = "Modificar"
        Me.MNU_MODIFICAR.Visible = False
        '
        'MNU_ELIMINAR
        '
        Me.MNU_ELIMINAR.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MNU_ELIMINAR.Image = CType(resources.GetObject("MNU_ELIMINAR.Image"), System.Drawing.Image)
        Me.MNU_ELIMINAR.Name = "MNU_ELIMINAR"
        Me.MNU_ELIMINAR.Size = New System.Drawing.Size(135, 26)
        Me.MNU_ELIMINAR.Text = "Eliminar"
        Me.MNU_ELIMINAR.Visible = False
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
        Me.BTN_RegresarProv.Size = New System.Drawing.Size(437, 69)
        Me.BTN_RegresarProv.TabIndex = 44
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
        Me.BTN_NProv.ImageSize = New System.Drawing.Size(40, 40)
        Me.BTN_NProv.Location = New System.Drawing.Point(435, 0)
        Me.BTN_NProv.Name = "BTN_NProv"
        Me.BTN_NProv.Size = New System.Drawing.Size(435, 69)
        Me.BTN_NProv.TabIndex = 43
        Me.BTN_NProv.Text = "Agregar"
        '
        'TXT_BuscarProv
        '
        Me.TXT_BuscarProv.BorderRadius = 20
        Me.TXT_BuscarProv.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TXT_BuscarProv.DefaultText = ""
        Me.TXT_BuscarProv.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TXT_BuscarProv.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TXT_BuscarProv.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXT_BuscarProv.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXT_BuscarProv.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXT_BuscarProv.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.TXT_BuscarProv.ForeColor = System.Drawing.Color.Black
        Me.TXT_BuscarProv.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXT_BuscarProv.IconRight = CType(resources.GetObject("TXT_BuscarProv.IconRight"), System.Drawing.Image)
        Me.TXT_BuscarProv.IconRightSize = New System.Drawing.Size(40, 40)
        Me.TXT_BuscarProv.Location = New System.Drawing.Point(47, 190)
        Me.TXT_BuscarProv.Name = "TXT_BuscarProv"
        Me.TXT_BuscarProv.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TXT_BuscarProv.PlaceholderText = "Buscar proveedor"
        Me.TXT_BuscarProv.SelectedText = ""
        Me.TXT_BuscarProv.Size = New System.Drawing.Size(772, 42)
        Me.TXT_BuscarProv.TabIndex = 42
        '
        'Guna2PictureBox1
        '
        Me.Guna2PictureBox1.Image = CType(resources.GetObject("Guna2PictureBox1.Image"), System.Drawing.Image)
        Me.Guna2PictureBox1.ImageRotate = 0!
        Me.Guna2PictureBox1.Location = New System.Drawing.Point(174, -129)
        Me.Guna2PictureBox1.Name = "Guna2PictureBox1"
        Me.Guna2PictureBox1.Size = New System.Drawing.Size(539, 442)
        Me.Guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Guna2PictureBox1.TabIndex = 41
        Me.Guna2PictureBox1.TabStop = False
        '
        'DGV_Prov
        '
        Me.DGV_Prov.AllowUserToAddRows = False
        Me.DGV_Prov.AllowUserToDeleteRows = False
        Me.DGV_Prov.AllowUserToResizeRows = False
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.DGV_Prov.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle5
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGV_Prov.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.DGV_Prov.ColumnHeadersHeight = 20
        Me.DGV_Prov.ContextMenuStrip = Me.MNU_CONTX
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DGV_Prov.DefaultCellStyle = DataGridViewCellStyle7
        Me.DGV_Prov.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DGV_Prov.Location = New System.Drawing.Point(47, 250)
        Me.DGV_Prov.MultiSelect = False
        Me.DGV_Prov.Name = "DGV_Prov"
        Me.DGV_Prov.ReadOnly = True
        Me.DGV_Prov.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGV_Prov.RowHeadersDefaultCellStyle = DataGridViewCellStyle8
        Me.DGV_Prov.RowHeadersVisible = False
        Me.DGV_Prov.Size = New System.Drawing.Size(772, 324)
        Me.DGV_Prov.TabIndex = 77
        Me.DGV_Prov.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.DGV_Prov.ThemeStyle.AlternatingRowsStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DGV_Prov.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.SystemColors.ControlText
        Me.DGV_Prov.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DGV_Prov.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.DGV_Prov.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.DGV_Prov.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DGV_Prov.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.DGV_Prov.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.DGV_Prov.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DGV_Prov.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.DGV_Prov.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.DGV_Prov.ThemeStyle.HeaderStyle.Height = 20
        Me.DGV_Prov.ThemeStyle.ReadOnly = True
        Me.DGV_Prov.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.DGV_Prov.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.DGV_Prov.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DGV_Prov.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.DGV_Prov.ThemeStyle.RowsStyle.Height = 22
        Me.DGV_Prov.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DGV_Prov.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.Controls.Add(Me.BTN_NProv)
        Me.Guna2Panel1.Controls.Add(Me.BTN_RegresarProv)
        Me.Guna2Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Guna2Panel1.Location = New System.Drawing.Point(0, 592)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.Size = New System.Drawing.Size(870, 69)
        Me.Guna2Panel1.TabIndex = 123
        '
        'Guna2Panel4
        '
        Me.Guna2Panel4.Controls.Add(Me.BTN_Config)
        Me.Guna2Panel4.Controls.Add(Me.BTN_CerrarApp)
        Me.Guna2Panel4.Location = New System.Drawing.Point(807, 0)
        Me.Guna2Panel4.Name = "Guna2Panel4"
        Me.Guna2Panel4.Size = New System.Drawing.Size(63, 110)
        Me.Guna2Panel4.TabIndex = 130
        '
        'BTN_Config
        '
        Me.BTN_Config.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.BTN_Config.CheckedState.ImageSize = New System.Drawing.Size(64, 64)
        Me.BTN_Config.Dock = System.Windows.Forms.DockStyle.Top
        Me.BTN_Config.HoverState.ImageSize = New System.Drawing.Size(64, 64)
        Me.BTN_Config.Image = CType(resources.GetObject("BTN_Config.Image"), System.Drawing.Image)
        Me.BTN_Config.ImageOffset = New System.Drawing.Point(0, 0)
        Me.BTN_Config.ImageRotate = 0!
        Me.BTN_Config.ImageSize = New System.Drawing.Size(60, 60)
        Me.BTN_Config.Location = New System.Drawing.Point(0, 54)
        Me.BTN_Config.Name = "BTN_Config"
        Me.BTN_Config.PressedState.ImageSize = New System.Drawing.Size(64, 64)
        Me.BTN_Config.Size = New System.Drawing.Size(63, 54)
        Me.BTN_Config.TabIndex = 123
        '
        'BTN_CerrarApp
        '
        Me.BTN_CerrarApp.BackColor = System.Drawing.Color.Red
        Me.BTN_CerrarApp.CheckedState.ImageSize = New System.Drawing.Size(64, 64)
        Me.BTN_CerrarApp.Dock = System.Windows.Forms.DockStyle.Top
        Me.BTN_CerrarApp.HoverState.ImageSize = New System.Drawing.Size(64, 64)
        Me.BTN_CerrarApp.Image = CType(resources.GetObject("BTN_CerrarApp.Image"), System.Drawing.Image)
        Me.BTN_CerrarApp.ImageOffset = New System.Drawing.Point(0, 0)
        Me.BTN_CerrarApp.ImageRotate = 0!
        Me.BTN_CerrarApp.ImageSize = New System.Drawing.Size(60, 60)
        Me.BTN_CerrarApp.Location = New System.Drawing.Point(0, 0)
        Me.BTN_CerrarApp.Name = "BTN_CerrarApp"
        Me.BTN_CerrarApp.PressedState.ImageSize = New System.Drawing.Size(64, 64)
        Me.BTN_CerrarApp.Size = New System.Drawing.Size(63, 54)
        Me.BTN_CerrarApp.TabIndex = 122
        '
        'P_Proveedor
        '
        Me.AcceptButton = Me.BTN_NProv
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.CancelButton = Me.BTN_RegresarProv
        Me.ClientSize = New System.Drawing.Size(870, 661)
        Me.Controls.Add(Me.Guna2Panel4)
        Me.Controls.Add(Me.Guna2Panel1)
        Me.Controls.Add(Me.DGV_Prov)
        Me.Controls.Add(Me.TXT_BuscarProv)
        Me.Controls.Add(Me.Guna2PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Name = "P_Proveedor"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Proveedores"
        Me.MNU_CONTX.ResumeLayout(False)
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGV_Prov, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Guna2Panel1.ResumeLayout(False)
        Me.Guna2Panel4.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Guna2BorderlessForm1 As Guna.UI2.WinForms.Guna2BorderlessForm
    Friend WithEvents MNU_CONTX As Guna.UI2.WinForms.Guna2ContextMenuStrip
    Friend WithEvents MNU_MODIFICAR As ToolStripMenuItem
    Friend WithEvents MNU_ELIMINAR As ToolStripMenuItem
    Friend WithEvents BTN_NProv As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BTN_RegresarProv As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents TXT_BuscarProv As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2PictureBox1 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents DGV_Prov As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2Panel4 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents BTN_Config As Guna.UI2.WinForms.Guna2ImageButton
    Friend WithEvents BTN_CerrarApp As Guna.UI2.WinForms.Guna2ImageButton
End Class
