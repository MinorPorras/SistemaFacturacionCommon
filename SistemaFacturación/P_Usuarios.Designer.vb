<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class P_Usuarios
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(P_Usuarios))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Guna2BorderlessForm1 = New Guna.UI2.WinForms.Guna2BorderlessForm(Me.components)
        Me.BTN_RegresarUsu = New Guna.UI2.WinForms.Guna2Button()
        Me.BTN_NUsuario = New Guna.UI2.WinForms.Guna2Button()
        Me.TXT_BuscarUsuario = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2PictureBox1 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.MNU_CONTX = New Guna.UI2.WinForms.Guna2ContextMenuStrip()
        Me.MNU_MODIFICAR = New System.Windows.Forms.ToolStripMenuItem()
        Me.MNU_ELIMINAR = New System.Windows.Forms.ToolStripMenuItem()
        Me.DGV_Cajero = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2Panel2 = New Guna.UI2.WinForms.Guna2Panel()
        Me.BTN_Config = New Guna.UI2.WinForms.Guna2ImageButton()
        Me.BTN_CerrarApp = New Guna.UI2.WinForms.Guna2ImageButton()
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MNU_CONTX.SuspendLayout()
        CType(Me.DGV_Cajero, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Guna2Panel1.SuspendLayout()
        Me.Guna2Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Guna2BorderlessForm1
        '
        Me.Guna2BorderlessForm1.BorderRadius = 25
        Me.Guna2BorderlessForm1.ContainerControl = Me
        Me.Guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6R
        Me.Guna2BorderlessForm1.TransparentWhileDrag = True
        '
        'BTN_RegresarUsu
        '
        Me.BTN_RegresarUsu.BorderColor = System.Drawing.Color.Red
        Me.BTN_RegresarUsu.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.BTN_RegresarUsu.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BTN_RegresarUsu.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BTN_RegresarUsu.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BTN_RegresarUsu.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BTN_RegresarUsu.Dock = System.Windows.Forms.DockStyle.Left
        Me.BTN_RegresarUsu.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BTN_RegresarUsu.Font = New System.Drawing.Font("Ebrima", 20.25!, System.Drawing.FontStyle.Bold)
        Me.BTN_RegresarUsu.ForeColor = System.Drawing.Color.White
        Me.BTN_RegresarUsu.Image = CType(resources.GetObject("BTN_RegresarUsu.Image"), System.Drawing.Image)
        Me.BTN_RegresarUsu.ImageSize = New System.Drawing.Size(40, 40)
        Me.BTN_RegresarUsu.Location = New System.Drawing.Point(0, 0)
        Me.BTN_RegresarUsu.Name = "BTN_RegresarUsu"
        Me.BTN_RegresarUsu.Size = New System.Drawing.Size(427, 72)
        Me.BTN_RegresarUsu.TabIndex = 28
        Me.BTN_RegresarUsu.Text = "Regresar"
        '
        'BTN_NUsuario
        '
        Me.BTN_NUsuario.BorderColor = System.Drawing.Color.Red
        Me.BTN_NUsuario.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BTN_NUsuario.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BTN_NUsuario.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BTN_NUsuario.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BTN_NUsuario.Dock = System.Windows.Forms.DockStyle.Right
        Me.BTN_NUsuario.FillColor = System.Drawing.Color.MediumSeaGreen
        Me.BTN_NUsuario.Font = New System.Drawing.Font("Ebrima", 20.25!, System.Drawing.FontStyle.Bold)
        Me.BTN_NUsuario.ForeColor = System.Drawing.Color.White
        Me.BTN_NUsuario.Image = CType(resources.GetObject("BTN_NUsuario.Image"), System.Drawing.Image)
        Me.BTN_NUsuario.ImageSize = New System.Drawing.Size(40, 40)
        Me.BTN_NUsuario.Location = New System.Drawing.Point(422, 0)
        Me.BTN_NUsuario.Name = "BTN_NUsuario"
        Me.BTN_NUsuario.Size = New System.Drawing.Size(443, 72)
        Me.BTN_NUsuario.TabIndex = 27
        Me.BTN_NUsuario.Text = "Agregar"
        '
        'TXT_BuscarUsuario
        '
        Me.TXT_BuscarUsuario.BorderRadius = 20
        Me.TXT_BuscarUsuario.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TXT_BuscarUsuario.DefaultText = ""
        Me.TXT_BuscarUsuario.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TXT_BuscarUsuario.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TXT_BuscarUsuario.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXT_BuscarUsuario.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXT_BuscarUsuario.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXT_BuscarUsuario.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.TXT_BuscarUsuario.ForeColor = System.Drawing.Color.Black
        Me.TXT_BuscarUsuario.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXT_BuscarUsuario.IconRight = CType(resources.GetObject("TXT_BuscarUsuario.IconRight"), System.Drawing.Image)
        Me.TXT_BuscarUsuario.IconRightSize = New System.Drawing.Size(40, 40)
        Me.TXT_BuscarUsuario.Location = New System.Drawing.Point(46, 191)
        Me.TXT_BuscarUsuario.Name = "TXT_BuscarUsuario"
        Me.TXT_BuscarUsuario.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TXT_BuscarUsuario.PlaceholderText = "Buscar cajeros"
        Me.TXT_BuscarUsuario.SelectedText = ""
        Me.TXT_BuscarUsuario.Size = New System.Drawing.Size(772, 42)
        Me.TXT_BuscarUsuario.TabIndex = 25
        '
        'Guna2PictureBox1
        '
        Me.Guna2PictureBox1.Image = CType(resources.GetObject("Guna2PictureBox1.Image"), System.Drawing.Image)
        Me.Guna2PictureBox1.ImageRotate = 0!
        Me.Guna2PictureBox1.Location = New System.Drawing.Point(173, -128)
        Me.Guna2PictureBox1.Name = "Guna2PictureBox1"
        Me.Guna2PictureBox1.Size = New System.Drawing.Size(539, 442)
        Me.Guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Guna2PictureBox1.TabIndex = 24
        Me.Guna2PictureBox1.TabStop = False
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
        'DGV_Cajero
        '
        Me.DGV_Cajero.AllowUserToAddRows = False
        Me.DGV_Cajero.AllowUserToDeleteRows = False
        Me.DGV_Cajero.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.DGV_Cajero.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGV_Cajero.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DGV_Cajero.ColumnHeadersHeight = 20
        Me.DGV_Cajero.ContextMenuStrip = Me.MNU_CONTX
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DGV_Cajero.DefaultCellStyle = DataGridViewCellStyle3
        Me.DGV_Cajero.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DGV_Cajero.Location = New System.Drawing.Point(46, 251)
        Me.DGV_Cajero.MultiSelect = False
        Me.DGV_Cajero.Name = "DGV_Cajero"
        Me.DGV_Cajero.ReadOnly = True
        Me.DGV_Cajero.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGV_Cajero.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.DGV_Cajero.RowHeadersVisible = False
        Me.DGV_Cajero.Size = New System.Drawing.Size(772, 324)
        Me.DGV_Cajero.TabIndex = 70
        Me.DGV_Cajero.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.DGV_Cajero.ThemeStyle.AlternatingRowsStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DGV_Cajero.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.SystemColors.ControlText
        Me.DGV_Cajero.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DGV_Cajero.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.DGV_Cajero.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.DGV_Cajero.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DGV_Cajero.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.DGV_Cajero.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.DGV_Cajero.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DGV_Cajero.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.DGV_Cajero.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.DGV_Cajero.ThemeStyle.HeaderStyle.Height = 20
        Me.DGV_Cajero.ThemeStyle.ReadOnly = True
        Me.DGV_Cajero.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.DGV_Cajero.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.DGV_Cajero.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DGV_Cajero.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.DGV_Cajero.ThemeStyle.RowsStyle.Height = 22
        Me.DGV_Cajero.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DGV_Cajero.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.Controls.Add(Me.BTN_RegresarUsu)
        Me.Guna2Panel1.Controls.Add(Me.BTN_NUsuario)
        Me.Guna2Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Guna2Panel1.Location = New System.Drawing.Point(0, 589)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.Size = New System.Drawing.Size(865, 72)
        Me.Guna2Panel1.TabIndex = 124
        '
        'Guna2Panel2
        '
        Me.Guna2Panel2.Controls.Add(Me.BTN_Config)
        Me.Guna2Panel2.Controls.Add(Me.BTN_CerrarApp)
        Me.Guna2Panel2.Location = New System.Drawing.Point(802, -1)
        Me.Guna2Panel2.Name = "Guna2Panel2"
        Me.Guna2Panel2.Size = New System.Drawing.Size(63, 110)
        Me.Guna2Panel2.TabIndex = 131
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
        'P_Usuarios
        '
        Me.AcceptButton = Me.BTN_NUsuario
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.CancelButton = Me.BTN_RegresarUsu
        Me.ClientSize = New System.Drawing.Size(865, 661)
        Me.Controls.Add(Me.Guna2Panel2)
        Me.Controls.Add(Me.Guna2Panel1)
        Me.Controls.Add(Me.DGV_Cajero)
        Me.Controls.Add(Me.TXT_BuscarUsuario)
        Me.Controls.Add(Me.Guna2PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Name = "P_Usuarios"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Usuarios"
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MNU_CONTX.ResumeLayout(False)
        CType(Me.DGV_Cajero, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Guna2Panel1.ResumeLayout(False)
        Me.Guna2Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Guna2BorderlessForm1 As Guna.UI2.WinForms.Guna2BorderlessForm
    Friend WithEvents BTN_RegresarUsu As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BTN_NUsuario As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents TXT_BuscarUsuario As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2PictureBox1 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents MNU_CONTX As Guna.UI2.WinForms.Guna2ContextMenuStrip
    Friend WithEvents MNU_MODIFICAR As ToolStripMenuItem
    Friend WithEvents MNU_ELIMINAR As ToolStripMenuItem
    Friend WithEvents DGV_Cajero As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2Panel2 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents BTN_Config As Guna.UI2.WinForms.Guna2ImageButton
    Friend WithEvents BTN_CerrarApp As Guna.UI2.WinForms.Guna2ImageButton
End Class
