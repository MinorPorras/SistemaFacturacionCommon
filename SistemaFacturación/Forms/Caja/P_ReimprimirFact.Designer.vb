Namespace SistemaFacturacion.Forms.Caja
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Class P_ReimprimirFact
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(P_ReimprimirFact))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Guna2BorderlessForm1 = New Guna.UI2.WinForms.Guna2BorderlessForm(Me.components)
        Me.MNU_CONTX = New Guna.UI2.WinForms.Guna2ContextMenuStrip()
        Me.MNU_REIMPRIMIR = New System.Windows.Forms.ToolStripMenuItem()
        Me.MNU_Datos = New System.Windows.Forms.ToolStripMenuItem()
        Me.BTN_RegresarFact = New Guna.UI2.WinForms.Guna2Button()
        Me.BTN_ImpReciente = New Guna.UI2.WinForms.Guna2Button()
        Me.TXT_BuscarFact = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2PictureBox1 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.DGV_ReimprimirFact = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.RDB_50 = New Guna.UI2.WinForms.Guna2RadioButton()
        Me.GRB_Filtro = New System.Windows.Forms.GroupBox()
        Me.RDB_All = New Guna.UI2.WinForms.Guna2RadioButton()
        Me.RDB_200 = New Guna.UI2.WinForms.Guna2RadioButton()
        Me.RDB_100 = New Guna.UI2.WinForms.Guna2RadioButton()
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.BTN_CerrarApp = New Guna.UI2.WinForms.Guna2ImageButton()
        Me.MNU_CONTX.SuspendLayout()
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGV_ReimprimirFact, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GRB_Filtro.SuspendLayout()
        Me.Guna2Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Guna2BorderlessForm1
        '
        Me.Guna2BorderlessForm1.AnimationType = Guna.UI2.WinForms.Guna2BorderlessForm.AnimateWindowType.AW_CENTER
        Me.Guna2BorderlessForm1.BorderRadius = 25
        Me.Guna2BorderlessForm1.ContainerControl = Me
        Me.Guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6R
        Me.Guna2BorderlessForm1.TransparentWhileDrag = True
        '
        'MNU_CONTX
        '
        Me.MNU_CONTX.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MNU_CONTX.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MNU_REIMPRIMIR, Me.MNU_Datos})
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
        'MNU_REIMPRIMIR
        '
        Me.MNU_REIMPRIMIR.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.MNU_REIMPRIMIR.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MNU_REIMPRIMIR.ForeColor = System.Drawing.Color.White
        Me.MNU_REIMPRIMIR.Image = Global.SistemaFacturaciónCommon.My.Resources.Resources.ICO_Print
        Me.MNU_REIMPRIMIR.Name = "MNU_REIMPRIMIR"
        Me.MNU_REIMPRIMIR.Size = New System.Drawing.Size(184, 26)
        Me.MNU_REIMPRIMIR.Text = "Reimprimir"
        Me.MNU_REIMPRIMIR.Visible = False
        '
        'MNU_Datos
        '
        Me.MNU_Datos.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.MNU_Datos.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MNU_Datos.ForeColor = System.Drawing.Color.White
        Me.MNU_Datos.Image = Global.SistemaFacturaciónCommon.My.Resources.Resources.ICO_SearchCol
        Me.MNU_Datos.Name = "MNU_Datos"
        Me.MNU_Datos.Size = New System.Drawing.Size(184, 26)
        Me.MNU_Datos.Text = "Ver datos"
        '
        'BTN_RegresarFact
        '
        Me.BTN_RegresarFact.BorderColor = System.Drawing.Color.Red
        Me.BTN_RegresarFact.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.BTN_RegresarFact.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BTN_RegresarFact.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BTN_RegresarFact.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BTN_RegresarFact.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BTN_RegresarFact.Dock = System.Windows.Forms.DockStyle.Left
        Me.BTN_RegresarFact.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BTN_RegresarFact.Font = New System.Drawing.Font("Ebrima", 20.25!, System.Drawing.FontStyle.Bold)
        Me.BTN_RegresarFact.ForeColor = System.Drawing.Color.White
        Me.BTN_RegresarFact.Image = Global.SistemaFacturaciónCommon.My.Resources.Resources.ICO_Back
        Me.BTN_RegresarFact.ImageSize = New System.Drawing.Size(40, 40)
        Me.BTN_RegresarFact.Location = New System.Drawing.Point(0, 0)
        Me.BTN_RegresarFact.Name = "BTN_RegresarFact"
        Me.BTN_RegresarFact.Size = New System.Drawing.Size(610, 57)
        Me.BTN_RegresarFact.TabIndex = 51
        Me.BTN_RegresarFact.Text = "Regresar"
        '
        'BTN_ImpReciente
        '
        Me.BTN_ImpReciente.BorderColor = System.Drawing.Color.Red
        Me.BTN_ImpReciente.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BTN_ImpReciente.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BTN_ImpReciente.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BTN_ImpReciente.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BTN_ImpReciente.Dock = System.Windows.Forms.DockStyle.Right
        Me.BTN_ImpReciente.FillColor = System.Drawing.Color.MediumSeaGreen
        Me.BTN_ImpReciente.Font = New System.Drawing.Font("Ebrima", 20.25!, System.Drawing.FontStyle.Bold)
        Me.BTN_ImpReciente.ForeColor = System.Drawing.Color.White
        Me.BTN_ImpReciente.Image = Global.SistemaFacturaciónCommon.My.Resources.Resources.ICO_Print
        Me.BTN_ImpReciente.ImageSize = New System.Drawing.Size(40, 40)
        Me.BTN_ImpReciente.Location = New System.Drawing.Point(607, 0)
        Me.BTN_ImpReciente.Name = "BTN_ImpReciente"
        Me.BTN_ImpReciente.Size = New System.Drawing.Size(612, 57)
        Me.BTN_ImpReciente.TabIndex = 50
        Me.BTN_ImpReciente.Text = "Imprimir más reciente"
        '
        'TXT_BuscarFact
        '
        Me.TXT_BuscarFact.BorderRadius = 20
        Me.TXT_BuscarFact.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TXT_BuscarFact.DefaultText = ""
        Me.TXT_BuscarFact.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TXT_BuscarFact.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TXT_BuscarFact.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXT_BuscarFact.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXT_BuscarFact.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXT_BuscarFact.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.TXT_BuscarFact.ForeColor = System.Drawing.Color.Black
        Me.TXT_BuscarFact.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXT_BuscarFact.IconRight = Global.SistemaFacturaciónCommon.My.Resources.Resources.ICO_SearchCol
        Me.TXT_BuscarFact.IconRightOffset = New System.Drawing.Point(10, 0)
        Me.TXT_BuscarFact.IconRightSize = New System.Drawing.Size(40, 40)
        Me.TXT_BuscarFact.Location = New System.Drawing.Point(26, 166)
        Me.TXT_BuscarFact.Name = "TXT_BuscarFact"
        Me.TXT_BuscarFact.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TXT_BuscarFact.PlaceholderText = "Buscar número de factura"
        Me.TXT_BuscarFact.SelectedText = ""
        Me.TXT_BuscarFact.Size = New System.Drawing.Size(957, 42)
        Me.TXT_BuscarFact.TabIndex = 49
        '
        'Guna2PictureBox1
        '
        Me.Guna2PictureBox1.Image = CType(resources.GetObject("Guna2PictureBox1.Image"), System.Drawing.Image)
        Me.Guna2PictureBox1.ImageRotate = 0!
        Me.Guna2PictureBox1.Location = New System.Drawing.Point(460, -91)
        Me.Guna2PictureBox1.Name = "Guna2PictureBox1"
        Me.Guna2PictureBox1.Size = New System.Drawing.Size(387, 316)
        Me.Guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Guna2PictureBox1.TabIndex = 48
        Me.Guna2PictureBox1.TabStop = False
        '
        'DGV_ReimprimirFact
        '
        Me.DGV_ReimprimirFact.AllowUserToAddRows = False
        Me.DGV_ReimprimirFact.AllowUserToDeleteRows = False
        Me.DGV_ReimprimirFact.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.DGV_ReimprimirFact.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGV_ReimprimirFact.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DGV_ReimprimirFact.ColumnHeadersHeight = 20
        Me.DGV_ReimprimirFact.ContextMenuStrip = Me.MNU_CONTX
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DGV_ReimprimirFact.DefaultCellStyle = DataGridViewCellStyle3
        Me.DGV_ReimprimirFact.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DGV_ReimprimirFact.Location = New System.Drawing.Point(26, 231)
        Me.DGV_ReimprimirFact.MultiSelect = False
        Me.DGV_ReimprimirFact.Name = "DGV_ReimprimirFact"
        Me.DGV_ReimprimirFact.ReadOnly = True
        Me.DGV_ReimprimirFact.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGV_ReimprimirFact.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.DGV_ReimprimirFact.RowHeadersVisible = False
        Me.DGV_ReimprimirFact.Size = New System.Drawing.Size(1166, 370)
        Me.DGV_ReimprimirFact.TabIndex = 78
        Me.DGV_ReimprimirFact.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.DGV_ReimprimirFact.ThemeStyle.AlternatingRowsStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DGV_ReimprimirFact.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.SystemColors.ControlText
        Me.DGV_ReimprimirFact.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DGV_ReimprimirFact.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.DGV_ReimprimirFact.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.DGV_ReimprimirFact.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DGV_ReimprimirFact.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.DGV_ReimprimirFact.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.DGV_ReimprimirFact.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DGV_ReimprimirFact.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.DGV_ReimprimirFact.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.DGV_ReimprimirFact.ThemeStyle.HeaderStyle.Height = 20
        Me.DGV_ReimprimirFact.ThemeStyle.ReadOnly = True
        Me.DGV_ReimprimirFact.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.DGV_ReimprimirFact.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.DGV_ReimprimirFact.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DGV_ReimprimirFact.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.DGV_ReimprimirFact.ThemeStyle.RowsStyle.Height = 22
        Me.DGV_ReimprimirFact.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DGV_ReimprimirFact.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        '
        'RDB_50
        '
        Me.RDB_50.AutoSize = True
        Me.RDB_50.Checked = True
        Me.RDB_50.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.RDB_50.CheckedState.BorderThickness = 0
        Me.RDB_50.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.RDB_50.CheckedState.InnerColor = System.Drawing.Color.White
        Me.RDB_50.CheckedState.InnerOffset = -4
        Me.RDB_50.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.RDB_50.ForeColor = System.Drawing.SystemColors.Control
        Me.RDB_50.Location = New System.Drawing.Point(23, 21)
        Me.RDB_50.Name = "RDB_50"
        Me.RDB_50.Size = New System.Drawing.Size(81, 17)
        Me.RDB_50.TabIndex = 83
        Me.RDB_50.TabStop = True
        Me.RDB_50.Text = "50 Facturas"
        Me.RDB_50.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.RDB_50.UncheckedState.BorderThickness = 2
        Me.RDB_50.UncheckedState.FillColor = System.Drawing.Color.Transparent
        Me.RDB_50.UncheckedState.InnerColor = System.Drawing.Color.Transparent
        '
        'GRB_Filtro
        '
        Me.GRB_Filtro.Controls.Add(Me.RDB_All)
        Me.GRB_Filtro.Controls.Add(Me.RDB_200)
        Me.GRB_Filtro.Controls.Add(Me.RDB_100)
        Me.GRB_Filtro.Controls.Add(Me.RDB_50)
        Me.GRB_Filtro.ForeColor = System.Drawing.SystemColors.Control
        Me.GRB_Filtro.Location = New System.Drawing.Point(989, 150)
        Me.GRB_Filtro.Name = "GRB_Filtro"
        Me.GRB_Filtro.Size = New System.Drawing.Size(203, 64)
        Me.GRB_Filtro.TabIndex = 84
        Me.GRB_Filtro.TabStop = False
        Me.GRB_Filtro.Text = "Filtros"
        '
        'RDB_All
        '
        Me.RDB_All.AutoSize = True
        Me.RDB_All.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.RDB_All.CheckedState.BorderThickness = 0
        Me.RDB_All.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.RDB_All.CheckedState.InnerColor = System.Drawing.Color.White
        Me.RDB_All.CheckedState.InnerOffset = -4
        Me.RDB_All.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.RDB_All.ForeColor = System.Drawing.SystemColors.Control
        Me.RDB_All.Location = New System.Drawing.Point(110, 41)
        Me.RDB_All.Name = "RDB_All"
        Me.RDB_All.Size = New System.Drawing.Size(55, 17)
        Me.RDB_All.TabIndex = 86
        Me.RDB_All.Text = "Todas"
        Me.RDB_All.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.RDB_All.UncheckedState.BorderThickness = 2
        Me.RDB_All.UncheckedState.FillColor = System.Drawing.Color.Transparent
        Me.RDB_All.UncheckedState.InnerColor = System.Drawing.Color.Transparent
        '
        'RDB_200
        '
        Me.RDB_200.AutoSize = True
        Me.RDB_200.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.RDB_200.CheckedState.BorderThickness = 0
        Me.RDB_200.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.RDB_200.CheckedState.InnerColor = System.Drawing.Color.White
        Me.RDB_200.CheckedState.InnerOffset = -4
        Me.RDB_200.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.RDB_200.ForeColor = System.Drawing.SystemColors.Control
        Me.RDB_200.Location = New System.Drawing.Point(110, 21)
        Me.RDB_200.Name = "RDB_200"
        Me.RDB_200.Size = New System.Drawing.Size(87, 17)
        Me.RDB_200.TabIndex = 85
        Me.RDB_200.Text = "200 Facturas"
        Me.RDB_200.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.RDB_200.UncheckedState.BorderThickness = 2
        Me.RDB_200.UncheckedState.FillColor = System.Drawing.Color.Transparent
        Me.RDB_200.UncheckedState.InnerColor = System.Drawing.Color.Transparent
        '
        'RDB_100
        '
        Me.RDB_100.AutoSize = True
        Me.RDB_100.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.RDB_100.CheckedState.BorderThickness = 0
        Me.RDB_100.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.RDB_100.CheckedState.InnerColor = System.Drawing.Color.White
        Me.RDB_100.CheckedState.InnerOffset = -4
        Me.RDB_100.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.RDB_100.ForeColor = System.Drawing.SystemColors.Control
        Me.RDB_100.Location = New System.Drawing.Point(23, 41)
        Me.RDB_100.Name = "RDB_100"
        Me.RDB_100.Size = New System.Drawing.Size(87, 17)
        Me.RDB_100.TabIndex = 84
        Me.RDB_100.Text = "100 Facturas"
        Me.RDB_100.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.RDB_100.UncheckedState.BorderThickness = 2
        Me.RDB_100.UncheckedState.FillColor = System.Drawing.Color.Transparent
        Me.RDB_100.UncheckedState.InnerColor = System.Drawing.Color.Transparent
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.Controls.Add(Me.BTN_RegresarFact)
        Me.Guna2Panel1.Controls.Add(Me.BTN_ImpReciente)
        Me.Guna2Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Guna2Panel1.Location = New System.Drawing.Point(0, 628)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.Size = New System.Drawing.Size(1219, 57)
        Me.Guna2Panel1.TabIndex = 87
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
        Me.BTN_CerrarApp.Location = New System.Drawing.Point(1162, 12)
        Me.BTN_CerrarApp.Name = "BTN_CerrarApp"
        Me.BTN_CerrarApp.PressedState.ImageSize = New System.Drawing.Size(64, 64)
        Me.BTN_CerrarApp.Size = New System.Drawing.Size(45, 45)
        Me.BTN_CerrarApp.TabIndex = 125
        '
        'P_ReimprimirFact
        '
        Me.AcceptButton = Me.BTN_ImpReciente
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.CancelButton = Me.BTN_RegresarFact
        Me.ClientSize = New System.Drawing.Size(1219, 685)
        Me.Controls.Add(Me.BTN_CerrarApp)
        Me.Controls.Add(Me.Guna2Panel1)
        Me.Controls.Add(Me.GRB_Filtro)
        Me.Controls.Add(Me.DGV_ReimprimirFact)
        Me.Controls.Add(Me.TXT_BuscarFact)
        Me.Controls.Add(Me.Guna2PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "P_ReimprimirFact"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Reimprimir factura"
        Me.MNU_CONTX.ResumeLayout(False)
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGV_ReimprimirFact, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GRB_Filtro.ResumeLayout(False)
        Me.GRB_Filtro.PerformLayout()
        Me.Guna2Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Guna2BorderlessForm1 As Guna.UI2.WinForms.Guna2BorderlessForm
    Friend WithEvents BTN_RegresarFact As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BTN_ImpReciente As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents TXT_BuscarFact As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2PictureBox1 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents MNU_CONTX As Guna.UI2.WinForms.Guna2ContextMenuStrip
    Friend WithEvents MNU_REIMPRIMIR As ToolStripMenuItem
    Friend WithEvents DGV_ReimprimirFact As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents GRB_Filtro As GroupBox
    Friend WithEvents RDB_100 As Guna.UI2.WinForms.Guna2RadioButton
    Friend WithEvents RDB_50 As Guna.UI2.WinForms.Guna2RadioButton
    Friend WithEvents RDB_All As Guna.UI2.WinForms.Guna2RadioButton
    Friend WithEvents RDB_200 As Guna.UI2.WinForms.Guna2RadioButton
    Friend WithEvents MNU_Datos As ToolStripMenuItem
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents BTN_CerrarApp As Guna.UI2.WinForms.Guna2ImageButton
End Class

End Namespace