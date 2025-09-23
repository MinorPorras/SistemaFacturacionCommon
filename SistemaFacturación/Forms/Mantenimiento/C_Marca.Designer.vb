Namespace SistemaFacturacion.Forms.Mantenimiento

    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Class C_Marca
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(C_Marca))
            Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Me.MNU_CONTX = New Guna.UI2.WinForms.Guna2ContextMenuStrip()
            Me.MNU_MODIFICAR = New System.Windows.Forms.ToolStripMenuItem()
            Me.MNU_ELIMINAR = New System.Windows.Forms.ToolStripMenuItem()
            Me.BTN_RegresarMarca = New Guna.UI2.WinForms.Guna2Button()
            Me.BTN_NMarca = New Guna.UI2.WinForms.Guna2Button()
            Me.TXT_BuscarMarca = New Guna.UI2.WinForms.Guna2TextBox()
            Me.Guna2PictureBox1 = New Guna.UI2.WinForms.Guna2PictureBox()
            Me.Guna2BorderlessForm1 = New Guna.UI2.WinForms.Guna2BorderlessForm(Me.components)
            Me.DGV_Marca = New Guna.UI2.WinForms.Guna2DataGridView()
            Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
            Me.BTN_Config = New Guna.UI2.WinForms.Guna2ImageButton()
            Me.BTN_CerrarApp = New Guna.UI2.WinForms.Guna2ImageButton()
            Me.MNU_CONTX.SuspendLayout()
            CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.DGV_Marca, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.Guna2Panel1.SuspendLayout()
            Me.SuspendLayout()
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
            Me.MNU_CONTX.Size = New System.Drawing.Size(185, 78)
            '
            'MNU_MODIFICAR
            '
            Me.MNU_MODIFICAR.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer))
            Me.MNU_MODIFICAR.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.MNU_MODIFICAR.ForeColor = System.Drawing.Color.White
            Me.MNU_MODIFICAR.Image = Global.SistemaFacturaciónCommon.My.Resources.Resources.ICO_Edit
            Me.MNU_MODIFICAR.Name = "MNU_MODIFICAR"
            Me.MNU_MODIFICAR.Size = New System.Drawing.Size(184, 26)
            Me.MNU_MODIFICAR.Text = "Modificar"
            Me.MNU_MODIFICAR.Visible = False
            '
            'MNU_ELIMINAR
            '
            Me.MNU_ELIMINAR.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer))
            Me.MNU_ELIMINAR.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.MNU_ELIMINAR.ForeColor = System.Drawing.Color.White
            Me.MNU_ELIMINAR.Image = Global.SistemaFacturaciónCommon.My.Resources.Resources.ICO_Eliminar
            Me.MNU_ELIMINAR.Name = "MNU_ELIMINAR"
            Me.MNU_ELIMINAR.Size = New System.Drawing.Size(184, 26)
            Me.MNU_ELIMINAR.Text = "Eliminar"
            Me.MNU_ELIMINAR.Visible = False
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
            Me.BTN_RegresarMarca.Font = New System.Drawing.Font("Ebrima", 18.0!, System.Drawing.FontStyle.Bold)
            Me.BTN_RegresarMarca.ForeColor = System.Drawing.Color.White
            Me.BTN_RegresarMarca.Image = Global.SistemaFacturaciónCommon.My.Resources.Resources.ICO_Back
            Me.BTN_RegresarMarca.ImageSize = New System.Drawing.Size(40, 40)
            Me.BTN_RegresarMarca.Location = New System.Drawing.Point(0, 0)
            Me.BTN_RegresarMarca.Name = "BTN_RegresarMarca"
            Me.BTN_RegresarMarca.Size = New System.Drawing.Size(230, 58)
            Me.BTN_RegresarMarca.TabIndex = 51
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
            Me.BTN_NMarca.Font = New System.Drawing.Font("Ebrima", 18.0!, System.Drawing.FontStyle.Bold)
            Me.BTN_NMarca.ForeColor = System.Drawing.Color.White
            Me.BTN_NMarca.Image = Global.SistemaFacturaciónCommon.My.Resources.Resources.ICO_Mas
            Me.BTN_NMarca.ImageSize = New System.Drawing.Size(40, 40)
            Me.BTN_NMarca.Location = New System.Drawing.Point(226, 0)
            Me.BTN_NMarca.Name = "BTN_NMarca"
            Me.BTN_NMarca.Size = New System.Drawing.Size(248, 58)
            Me.BTN_NMarca.TabIndex = 50
            Me.BTN_NMarca.Text = "Agregar"
            '
            'TXT_BuscarMarca
            '
            Me.TXT_BuscarMarca.BorderRadius = 20
            Me.TXT_BuscarMarca.Cursor = System.Windows.Forms.Cursors.IBeam
            Me.TXT_BuscarMarca.DefaultText = ""
            Me.TXT_BuscarMarca.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
            Me.TXT_BuscarMarca.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
            Me.TXT_BuscarMarca.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
            Me.TXT_BuscarMarca.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
            Me.TXT_BuscarMarca.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.TXT_BuscarMarca.Font = New System.Drawing.Font("Segoe UI", 9.0!)
            Me.TXT_BuscarMarca.ForeColor = System.Drawing.Color.Black
            Me.TXT_BuscarMarca.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.TXT_BuscarMarca.IconRight = Global.SistemaFacturaciónCommon.My.Resources.Resources.ICO_SearchCol
            Me.TXT_BuscarMarca.IconRightOffset = New System.Drawing.Point(10, 0)
            Me.TXT_BuscarMarca.IconRightSize = New System.Drawing.Size(40, 40)
            Me.TXT_BuscarMarca.Location = New System.Drawing.Point(24, 139)
            Me.TXT_BuscarMarca.Name = "TXT_BuscarMarca"
            Me.TXT_BuscarMarca.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
            Me.TXT_BuscarMarca.PlaceholderText = "Buscar marca"
            Me.TXT_BuscarMarca.SelectedText = ""
            Me.TXT_BuscarMarca.Size = New System.Drawing.Size(425, 42)
            Me.TXT_BuscarMarca.TabIndex = 49
            '
            'Guna2PictureBox1
            '
            Me.Guna2PictureBox1.Image = CType(resources.GetObject("Guna2PictureBox1.Image"), System.Drawing.Image)
            Me.Guna2PictureBox1.ImageRotate = 0!
            Me.Guna2PictureBox1.Location = New System.Drawing.Point(79, -76)
            Me.Guna2PictureBox1.Name = "Guna2PictureBox1"
            Me.Guna2PictureBox1.Size = New System.Drawing.Size(329, 287)
            Me.Guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
            Me.Guna2PictureBox1.TabIndex = 48
            Me.Guna2PictureBox1.TabStop = False
            '
            'Guna2BorderlessForm1
            '
            Me.Guna2BorderlessForm1.BorderRadius = 25
            Me.Guna2BorderlessForm1.ContainerControl = Me
            Me.Guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6R
            Me.Guna2BorderlessForm1.TransparentWhileDrag = True
            '
            'DGV_Marca
            '
            Me.DGV_Marca.AllowUserToAddRows = False
            Me.DGV_Marca.AllowUserToDeleteRows = False
            Me.DGV_Marca.AllowUserToResizeRows = False
            DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
            DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
            DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
            DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
            Me.DGV_Marca.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
            Me.DGV_Marca.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.None
            DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
            DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
            DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
            DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
            Me.DGV_Marca.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
            Me.DGV_Marca.ColumnHeadersHeight = 20
            Me.DGV_Marca.ContextMenuStrip = Me.MNU_CONTX
            DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
            DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
            DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
            DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
            DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
            Me.DGV_Marca.DefaultCellStyle = DataGridViewCellStyle3
            Me.DGV_Marca.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.DGV_Marca.Location = New System.Drawing.Point(24, 199)
            Me.DGV_Marca.MultiSelect = False
            Me.DGV_Marca.Name = "DGV_Marca"
            Me.DGV_Marca.ReadOnly = True
            Me.DGV_Marca.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
            DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle4.BackColor = System.Drawing.Color.White
            DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
            DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.White
            DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
            Me.DGV_Marca.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
            Me.DGV_Marca.RowHeadersVisible = False
            Me.DGV_Marca.Size = New System.Drawing.Size(425, 206)
            Me.DGV_Marca.TabIndex = 76
            Me.DGV_Marca.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
            Me.DGV_Marca.ThemeStyle.AlternatingRowsStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.DGV_Marca.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.SystemColors.ControlText
            Me.DGV_Marca.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.DGV_Marca.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
            Me.DGV_Marca.ThemeStyle.BackColor = System.Drawing.Color.White
            Me.DGV_Marca.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.DGV_Marca.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.DGV_Marca.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
            Me.DGV_Marca.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.DGV_Marca.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
            Me.DGV_Marca.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
            Me.DGV_Marca.ThemeStyle.HeaderStyle.Height = 20
            Me.DGV_Marca.ThemeStyle.ReadOnly = True
            Me.DGV_Marca.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
            Me.DGV_Marca.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
            Me.DGV_Marca.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.DGV_Marca.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
            Me.DGV_Marca.ThemeStyle.RowsStyle.Height = 22
            Me.DGV_Marca.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.DGV_Marca.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
            '
            'Guna2Panel1
            '
            Me.Guna2Panel1.Controls.Add(Me.BTN_RegresarMarca)
            Me.Guna2Panel1.Controls.Add(Me.BTN_NMarca)
            Me.Guna2Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.Guna2Panel1.Location = New System.Drawing.Point(0, 437)
            Me.Guna2Panel1.Name = "Guna2Panel1"
            Me.Guna2Panel1.Size = New System.Drawing.Size(474, 58)
            Me.Guna2Panel1.TabIndex = 124
            '
            'BTN_Config
            '
            Me.BTN_Config.BackColor = System.Drawing.Color.Transparent
            Me.BTN_Config.CheckedState.Image = Global.SistemaFacturaciónCommon.My.Resources.Resources.ICO_Config
            Me.BTN_Config.CheckedState.ImageSize = New System.Drawing.Size(40, 40)
            Me.BTN_Config.HoverState.Image = Global.SistemaFacturaciónCommon.My.Resources.Resources.ICO_ConfigCol
            Me.BTN_Config.HoverState.ImageSize = New System.Drawing.Size(43, 43)
            Me.BTN_Config.Image = Global.SistemaFacturaciónCommon.My.Resources.Resources.ICO_Config
            Me.BTN_Config.ImageOffset = New System.Drawing.Point(0, 0)
            Me.BTN_Config.ImageRotate = 0!
            Me.BTN_Config.ImageSize = New System.Drawing.Size(40, 40)
            Me.BTN_Config.Location = New System.Drawing.Point(417, 66)
            Me.BTN_Config.Name = "BTN_Config"
            Me.BTN_Config.PressedState.ImageSize = New System.Drawing.Size(64, 64)
            Me.BTN_Config.Size = New System.Drawing.Size(45, 45)
            Me.BTN_Config.TabIndex = 123
            '
            'BTN_CerrarApp
            '
            Me.BTN_CerrarApp.BackColor = System.Drawing.Color.Transparent
            Me.BTN_CerrarApp.CheckedState.Image = Global.SistemaFacturaciónCommon.My.Resources.Resources.ICO_Cerrar
            Me.BTN_CerrarApp.CheckedState.ImageSize = New System.Drawing.Size(40, 40)
            Me.BTN_CerrarApp.HoverState.Image = Global.SistemaFacturaciónCommon.My.Resources.Resources.ICO_CerrarCol
            Me.BTN_CerrarApp.HoverState.ImageSize = New System.Drawing.Size(43, 43)
            Me.BTN_CerrarApp.Image = Global.SistemaFacturaciónCommon.My.Resources.Resources.ICO_Cerrar
            Me.BTN_CerrarApp.ImageOffset = New System.Drawing.Point(0, 0)
            Me.BTN_CerrarApp.ImageRotate = 0!
            Me.BTN_CerrarApp.ImageSize = New System.Drawing.Size(40, 40)
            Me.BTN_CerrarApp.Location = New System.Drawing.Point(417, 12)
            Me.BTN_CerrarApp.Name = "BTN_CerrarApp"
            Me.BTN_CerrarApp.PressedState.ImageSize = New System.Drawing.Size(64, 64)
            Me.BTN_CerrarApp.Size = New System.Drawing.Size(45, 45)
            Me.BTN_CerrarApp.TabIndex = 122
            '
            'P_Marca
            '
            Me.AcceptButton = Me.BTN_NMarca
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer))
            Me.CancelButton = Me.BTN_RegresarMarca
            Me.ClientSize = New System.Drawing.Size(474, 495)
            Me.Controls.Add(Me.BTN_Config)
            Me.Controls.Add(Me.BTN_CerrarApp)
            Me.Controls.Add(Me.Guna2Panel1)
            Me.Controls.Add(Me.DGV_Marca)
            Me.Controls.Add(Me.TXT_BuscarMarca)
            Me.Controls.Add(Me.Guna2PictureBox1)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.KeyPreview = True
            Me.Name = "P_Marca"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "Marcas"
            Me.MNU_CONTX.ResumeLayout(False)
            CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.DGV_Marca, System.ComponentModel.ISupportInitialize).EndInit()
            Me.Guna2Panel1.ResumeLayout(False)
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents BTN_RegresarMarca As Guna.UI2.WinForms.Guna2Button
        Friend WithEvents BTN_NMarca As Guna.UI2.WinForms.Guna2Button
        Friend WithEvents TXT_BuscarMarca As Guna.UI2.WinForms.Guna2TextBox
        Friend WithEvents Guna2PictureBox1 As Guna.UI2.WinForms.Guna2PictureBox
        Friend WithEvents Guna2BorderlessForm1 As Guna.UI2.WinForms.Guna2BorderlessForm
        Friend WithEvents MNU_CONTX As Guna.UI2.WinForms.Guna2ContextMenuStrip
        Friend WithEvents MNU_MODIFICAR As ToolStripMenuItem
        Friend WithEvents MNU_ELIMINAR As ToolStripMenuItem
        Friend WithEvents DGV_Marca As Guna.UI2.WinForms.Guna2DataGridView
        Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
        Friend WithEvents BTN_Config As Guna.UI2.WinForms.Guna2ImageButton
        Friend WithEvents BTN_CerrarApp As Guna.UI2.WinForms.Guna2ImageButton
    End Class
End Namespace