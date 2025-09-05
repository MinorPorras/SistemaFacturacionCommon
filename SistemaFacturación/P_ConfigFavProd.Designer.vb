<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class P_ConfigFavProd
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(P_ConfigFavProd))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.MNU_CONTX_BUSCAR = New Guna.UI2.WinForms.Guna2ContextMenuStrip()
        Me.MNU_SELECCIONAR = New System.Windows.Forms.ToolStripMenuItem()
        Me.MNU_CONTX_FAV = New Guna.UI2.WinForms.Guna2ContextMenuStrip()
        Me.MNU_ELIMINAR = New System.Windows.Forms.ToolStripMenuItem()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.PAN_InfoPageConfigFavProd = New Guna.UI2.WinForms.Guna2Panel()
        Me.TBL_DivSeccionsPageInfo = New System.Windows.Forms.TableLayoutPanel()
        Me.PAN_TBLLayoutCell2 = New Guna.UI2.WinForms.Guna2Panel()
        Me.PAN_ProdFavContainer = New Guna.UI2.WinForms.Guna2Panel()
        Me.PAN_DGVFavContainer = New Guna.UI2.WinForms.Guna2Panel()
        Me.BTN_MoveDown = New Guna.UI2.WinForms.Guna2TileButton()
        Me.BTN_MoveUp = New Guna.UI2.WinForms.Guna2TileButton()
        Me.DGV_FavProd = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.codigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colorProd = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PAN_HeaderFavContainer = New Guna.UI2.WinForms.Guna2Panel()
        Me.LBL_FavTitle = New System.Windows.Forms.Label()
        Me.PAN_TBLLayoutCell1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.TBL_TBLLayoutCell1 = New System.Windows.Forms.TableLayoutPanel()
        Me.TXT_BuscarProd = New Guna.UI2.WinForms.Guna2TextBox()
        Me.PAN_DGVSearchContainer = New Guna.UI2.WinForms.Guna2Panel()
        Me.DGV_BProd = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.PAN_HeaderPageInfoTitle = New Guna.UI2.WinForms.Guna2Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PAN_BtnContainer = New Guna.UI2.WinForms.Guna2Panel()
        Me.BTN_RegresarConfig = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2BorderlessForm1 = New Guna.UI2.WinForms.Guna2BorderlessForm(Me.components)
        Me.Guna2DragControl1 = New Guna.UI2.WinForms.Guna2DragControl(Me.components)
        Me.BTN_Actualizar = New Guna.UI2.WinForms.Guna2Button()
        Me.MNU_CONTX_BUSCAR.SuspendLayout()
        Me.MNU_CONTX_FAV.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.PAN_InfoPageConfigFavProd.SuspendLayout()
        Me.TBL_DivSeccionsPageInfo.SuspendLayout()
        Me.PAN_TBLLayoutCell2.SuspendLayout()
        Me.PAN_ProdFavContainer.SuspendLayout()
        Me.PAN_DGVFavContainer.SuspendLayout()
        CType(Me.DGV_FavProd, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PAN_HeaderFavContainer.SuspendLayout()
        Me.PAN_TBLLayoutCell1.SuspendLayout()
        Me.TBL_TBLLayoutCell1.SuspendLayout()
        Me.PAN_DGVSearchContainer.SuspendLayout()
        CType(Me.DGV_BProd, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PAN_HeaderPageInfoTitle.SuspendLayout()
        Me.PAN_BtnContainer.SuspendLayout()
        Me.SuspendLayout()
        '
        'MNU_CONTX_BUSCAR
        '
        Me.MNU_CONTX_BUSCAR.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MNU_CONTX_BUSCAR.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MNU_SELECCIONAR})
        Me.MNU_CONTX_BUSCAR.Name = "MNU_CONTX"
        Me.MNU_CONTX_BUSCAR.RenderStyle.ArrowColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.MNU_CONTX_BUSCAR.RenderStyle.BorderColor = System.Drawing.Color.Gainsboro
        Me.MNU_CONTX_BUSCAR.RenderStyle.ColorTable = Nothing
        Me.MNU_CONTX_BUSCAR.RenderStyle.RoundedEdges = True
        Me.MNU_CONTX_BUSCAR.RenderStyle.SelectionArrowColor = System.Drawing.Color.White
        Me.MNU_CONTX_BUSCAR.RenderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.MNU_CONTX_BUSCAR.RenderStyle.SelectionForeColor = System.Drawing.Color.White
        Me.MNU_CONTX_BUSCAR.RenderStyle.SeparatorColor = System.Drawing.Color.Gainsboro
        Me.MNU_CONTX_BUSCAR.RenderStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault
        Me.MNU_CONTX_BUSCAR.Size = New System.Drawing.Size(149, 30)
        '
        'MNU_SELECCIONAR
        '
        Me.MNU_SELECCIONAR.BackColor = System.Drawing.Color.White
        Me.MNU_SELECCIONAR.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MNU_SELECCIONAR.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.MNU_SELECCIONAR.Image = CType(resources.GetObject("MNU_SELECCIONAR.Image"), System.Drawing.Image)
        Me.MNU_SELECCIONAR.Name = "MNU_SELECCIONAR"
        Me.MNU_SELECCIONAR.Size = New System.Drawing.Size(148, 26)
        Me.MNU_SELECCIONAR.Text = "Seleccionar"
        '
        'MNU_CONTX_FAV
        '
        Me.MNU_CONTX_FAV.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MNU_CONTX_FAV.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MNU_ELIMINAR})
        Me.MNU_CONTX_FAV.Name = "MNU_CONTX"
        Me.MNU_CONTX_FAV.RenderStyle.ArrowColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.MNU_CONTX_FAV.RenderStyle.BorderColor = System.Drawing.Color.Gainsboro
        Me.MNU_CONTX_FAV.RenderStyle.ColorTable = Nothing
        Me.MNU_CONTX_FAV.RenderStyle.RoundedEdges = True
        Me.MNU_CONTX_FAV.RenderStyle.SelectionArrowColor = System.Drawing.Color.White
        Me.MNU_CONTX_FAV.RenderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.MNU_CONTX_FAV.RenderStyle.SelectionForeColor = System.Drawing.Color.White
        Me.MNU_CONTX_FAV.RenderStyle.SeparatorColor = System.Drawing.Color.Gainsboro
        Me.MNU_CONTX_FAV.RenderStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault
        Me.MNU_CONTX_FAV.Size = New System.Drawing.Size(128, 30)
        '
        'MNU_ELIMINAR
        '
        Me.MNU_ELIMINAR.BackColor = System.Drawing.Color.White
        Me.MNU_ELIMINAR.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MNU_ELIMINAR.Image = CType(resources.GetObject("MNU_ELIMINAR.Image"), System.Drawing.Image)
        Me.MNU_ELIMINAR.Name = "MNU_ELIMINAR"
        Me.MNU_ELIMINAR.Size = New System.Drawing.Size(127, 26)
        Me.MNU_ELIMINAR.Text = "Eliminar"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.PAN_InfoPageConfigFavProd, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.PAN_HeaderPageInfoTitle, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.PAN_BtnContainer, 0, 2)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 3
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 58.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(1198, 590)
        Me.TableLayoutPanel1.TabIndex = 119
        '
        'PAN_InfoPageConfigFavProd
        '
        Me.PAN_InfoPageConfigFavProd.Controls.Add(Me.TBL_DivSeccionsPageInfo)
        Me.PAN_InfoPageConfigFavProd.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PAN_InfoPageConfigFavProd.Location = New System.Drawing.Point(3, 56)
        Me.PAN_InfoPageConfigFavProd.Name = "PAN_InfoPageConfigFavProd"
        Me.PAN_InfoPageConfigFavProd.Size = New System.Drawing.Size(1192, 472)
        Me.PAN_InfoPageConfigFavProd.TabIndex = 0
        '
        'TBL_DivSeccionsPageInfo
        '
        Me.TBL_DivSeccionsPageInfo.ColumnCount = 2
        Me.TBL_DivSeccionsPageInfo.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TBL_DivSeccionsPageInfo.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TBL_DivSeccionsPageInfo.Controls.Add(Me.PAN_TBLLayoutCell2, 1, 0)
        Me.TBL_DivSeccionsPageInfo.Controls.Add(Me.PAN_TBLLayoutCell1, 0, 0)
        Me.TBL_DivSeccionsPageInfo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TBL_DivSeccionsPageInfo.Location = New System.Drawing.Point(0, 0)
        Me.TBL_DivSeccionsPageInfo.Name = "TBL_DivSeccionsPageInfo"
        Me.TBL_DivSeccionsPageInfo.RowCount = 1
        Me.TBL_DivSeccionsPageInfo.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TBL_DivSeccionsPageInfo.Size = New System.Drawing.Size(1192, 472)
        Me.TBL_DivSeccionsPageInfo.TabIndex = 0
        '
        'PAN_TBLLayoutCell2
        '
        Me.PAN_TBLLayoutCell2.Controls.Add(Me.PAN_ProdFavContainer)
        Me.PAN_TBLLayoutCell2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PAN_TBLLayoutCell2.Location = New System.Drawing.Point(599, 3)
        Me.PAN_TBLLayoutCell2.Name = "PAN_TBLLayoutCell2"
        Me.PAN_TBLLayoutCell2.Size = New System.Drawing.Size(590, 466)
        Me.PAN_TBLLayoutCell2.TabIndex = 112
        '
        'PAN_ProdFavContainer
        '
        Me.PAN_ProdFavContainer.Controls.Add(Me.PAN_DGVFavContainer)
        Me.PAN_ProdFavContainer.Controls.Add(Me.PAN_HeaderFavContainer)
        Me.PAN_ProdFavContainer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PAN_ProdFavContainer.Location = New System.Drawing.Point(0, 0)
        Me.PAN_ProdFavContainer.Name = "PAN_ProdFavContainer"
        Me.PAN_ProdFavContainer.Size = New System.Drawing.Size(590, 466)
        Me.PAN_ProdFavContainer.TabIndex = 122
        '
        'PAN_DGVFavContainer
        '
        Me.PAN_DGVFavContainer.Controls.Add(Me.BTN_MoveDown)
        Me.PAN_DGVFavContainer.Controls.Add(Me.BTN_MoveUp)
        Me.PAN_DGVFavContainer.Controls.Add(Me.DGV_FavProd)
        Me.PAN_DGVFavContainer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PAN_DGVFavContainer.Location = New System.Drawing.Point(0, 57)
        Me.PAN_DGVFavContainer.Name = "PAN_DGVFavContainer"
        Me.PAN_DGVFavContainer.Size = New System.Drawing.Size(590, 409)
        Me.PAN_DGVFavContainer.TabIndex = 113
        '
        'BTN_MoveDown
        '
        Me.BTN_MoveDown.Animated = True
        Me.BTN_MoveDown.BorderRadius = 10
        Me.BTN_MoveDown.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BTN_MoveDown.CustomBorderThickness = New System.Windows.Forms.Padding(0, 0, 0, 25)
        Me.BTN_MoveDown.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BTN_MoveDown.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BTN_MoveDown.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BTN_MoveDown.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BTN_MoveDown.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BTN_MoveDown.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_MoveDown.ForeColor = System.Drawing.Color.White
        Me.BTN_MoveDown.Image = CType(resources.GetObject("BTN_MoveDown.Image"), System.Drawing.Image)
        Me.BTN_MoveDown.ImageSize = New System.Drawing.Size(50, 50)
        Me.BTN_MoveDown.Location = New System.Drawing.Point(519, 254)
        Me.BTN_MoveDown.Name = "BTN_MoveDown"
        Me.BTN_MoveDown.Size = New System.Drawing.Size(65, 58)
        Me.BTN_MoveDown.TabIndex = 114
        '
        'BTN_MoveUp
        '
        Me.BTN_MoveUp.Animated = True
        Me.BTN_MoveUp.BorderRadius = 10
        Me.BTN_MoveUp.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BTN_MoveUp.CustomBorderThickness = New System.Windows.Forms.Padding(0, 0, 0, 25)
        Me.BTN_MoveUp.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BTN_MoveUp.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BTN_MoveUp.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BTN_MoveUp.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BTN_MoveUp.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BTN_MoveUp.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_MoveUp.ForeColor = System.Drawing.Color.White
        Me.BTN_MoveUp.Image = CType(resources.GetObject("BTN_MoveUp.Image"), System.Drawing.Image)
        Me.BTN_MoveUp.ImageSize = New System.Drawing.Size(50, 50)
        Me.BTN_MoveUp.Location = New System.Drawing.Point(519, 120)
        Me.BTN_MoveUp.Name = "BTN_MoveUp"
        Me.BTN_MoveUp.Size = New System.Drawing.Size(65, 58)
        Me.BTN_MoveUp.TabIndex = 113
        '
        'DGV_FavProd
        '
        Me.DGV_FavProd.AllowDrop = True
        Me.DGV_FavProd.AllowUserToDeleteRows = False
        Me.DGV_FavProd.AllowUserToOrderColumns = True
        Me.DGV_FavProd.AllowUserToResizeColumns = False
        Me.DGV_FavProd.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.DGV_FavProd.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DGV_FavProd.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGV_FavProd.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DGV_FavProd.ColumnHeadersHeight = 20
        Me.DGV_FavProd.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ID, Me.codigo, Me.nombre, Me.colorProd})
        Me.DGV_FavProd.ContextMenuStrip = Me.MNU_CONTX_FAV
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DGV_FavProd.DefaultCellStyle = DataGridViewCellStyle3
        Me.DGV_FavProd.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DGV_FavProd.Location = New System.Drawing.Point(14, 25)
        Me.DGV_FavProd.MultiSelect = False
        Me.DGV_FavProd.Name = "DGV_FavProd"
        Me.DGV_FavProd.ReadOnly = True
        Me.DGV_FavProd.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGV_FavProd.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.DGV_FavProd.RowHeadersVisible = False
        Me.DGV_FavProd.Size = New System.Drawing.Size(499, 365)
        Me.DGV_FavProd.TabIndex = 110
        Me.DGV_FavProd.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.DGV_FavProd.ThemeStyle.AlternatingRowsStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DGV_FavProd.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.SystemColors.ControlText
        Me.DGV_FavProd.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DGV_FavProd.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.DGV_FavProd.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.DGV_FavProd.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DGV_FavProd.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.DGV_FavProd.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.DGV_FavProd.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DGV_FavProd.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.DGV_FavProd.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.DGV_FavProd.ThemeStyle.HeaderStyle.Height = 20
        Me.DGV_FavProd.ThemeStyle.ReadOnly = True
        Me.DGV_FavProd.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.DGV_FavProd.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.DGV_FavProd.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DGV_FavProd.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.DGV_FavProd.ThemeStyle.RowsStyle.Height = 22
        Me.DGV_FavProd.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DGV_FavProd.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        '
        'ID
        '
        Me.ID.HeaderText = "ID"
        Me.ID.Name = "ID"
        Me.ID.ReadOnly = True
        Me.ID.Visible = False
        '
        'codigo
        '
        Me.codigo.HeaderText = "Código"
        Me.codigo.Name = "codigo"
        Me.codigo.ReadOnly = True
        '
        'nombre
        '
        Me.nombre.FillWeight = 233.6328!
        Me.nombre.HeaderText = "Producto"
        Me.nombre.Name = "nombre"
        Me.nombre.ReadOnly = True
        '
        'colorProd
        '
        Me.colorProd.FillWeight = 52.7853!
        Me.colorProd.HeaderText = "Color"
        Me.colorProd.Name = "colorProd"
        Me.colorProd.ReadOnly = True
        Me.colorProd.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        '
        'PAN_HeaderFavContainer
        '
        Me.PAN_HeaderFavContainer.Controls.Add(Me.LBL_FavTitle)
        Me.PAN_HeaderFavContainer.Dock = System.Windows.Forms.DockStyle.Top
        Me.PAN_HeaderFavContainer.Location = New System.Drawing.Point(0, 0)
        Me.PAN_HeaderFavContainer.Name = "PAN_HeaderFavContainer"
        Me.PAN_HeaderFavContainer.Size = New System.Drawing.Size(590, 57)
        Me.PAN_HeaderFavContainer.TabIndex = 112
        '
        'LBL_FavTitle
        '
        Me.LBL_FavTitle.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LBL_FavTitle.Font = New System.Drawing.Font("Britannic Bold", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_FavTitle.ForeColor = System.Drawing.Color.White
        Me.LBL_FavTitle.Location = New System.Drawing.Point(0, 0)
        Me.LBL_FavTitle.Name = "LBL_FavTitle"
        Me.LBL_FavTitle.Size = New System.Drawing.Size(590, 57)
        Me.LBL_FavTitle.TabIndex = 111
        Me.LBL_FavTitle.Text = "Favoritos (Seleccionar para cambiar el color)"
        Me.LBL_FavTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PAN_TBLLayoutCell1
        '
        Me.PAN_TBLLayoutCell1.Controls.Add(Me.TBL_TBLLayoutCell1)
        Me.PAN_TBLLayoutCell1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PAN_TBLLayoutCell1.Location = New System.Drawing.Point(3, 3)
        Me.PAN_TBLLayoutCell1.Name = "PAN_TBLLayoutCell1"
        Me.PAN_TBLLayoutCell1.Size = New System.Drawing.Size(590, 466)
        Me.PAN_TBLLayoutCell1.TabIndex = 0
        '
        'TBL_TBLLayoutCell1
        '
        Me.TBL_TBLLayoutCell1.ColumnCount = 1
        Me.TBL_TBLLayoutCell1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TBL_TBLLayoutCell1.Controls.Add(Me.TXT_BuscarProd, 0, 0)
        Me.TBL_TBLLayoutCell1.Controls.Add(Me.PAN_DGVSearchContainer, 0, 1)
        Me.TBL_TBLLayoutCell1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TBL_TBLLayoutCell1.Location = New System.Drawing.Point(0, 0)
        Me.TBL_TBLLayoutCell1.Name = "TBL_TBLLayoutCell1"
        Me.TBL_TBLLayoutCell1.RowCount = 2
        Me.TBL_TBLLayoutCell1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TBL_TBLLayoutCell1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90.0!))
        Me.TBL_TBLLayoutCell1.Size = New System.Drawing.Size(590, 466)
        Me.TBL_TBLLayoutCell1.TabIndex = 113
        '
        'TXT_BuscarProd
        '
        Me.TXT_BuscarProd.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TXT_BuscarProd.BorderRadius = 20
        Me.TXT_BuscarProd.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TXT_BuscarProd.DefaultText = ""
        Me.TXT_BuscarProd.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TXT_BuscarProd.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TXT_BuscarProd.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXT_BuscarProd.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXT_BuscarProd.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXT_BuscarProd.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.TXT_BuscarProd.ForeColor = System.Drawing.Color.Black
        Me.TXT_BuscarProd.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXT_BuscarProd.IconRight = CType(resources.GetObject("TXT_BuscarProd.IconRight"), System.Drawing.Image)
        Me.TXT_BuscarProd.IconRightSize = New System.Drawing.Size(40, 40)
        Me.TXT_BuscarProd.Location = New System.Drawing.Point(3, 3)
        Me.TXT_BuscarProd.Name = "TXT_BuscarProd"
        Me.TXT_BuscarProd.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TXT_BuscarProd.PlaceholderText = "Buscar producto"
        Me.TXT_BuscarProd.SelectedText = ""
        Me.TXT_BuscarProd.Size = New System.Drawing.Size(584, 40)
        Me.TXT_BuscarProd.TabIndex = 112
        '
        'PAN_DGVSearchContainer
        '
        Me.PAN_DGVSearchContainer.Controls.Add(Me.DGV_BProd)
        Me.PAN_DGVSearchContainer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PAN_DGVSearchContainer.Location = New System.Drawing.Point(3, 49)
        Me.PAN_DGVSearchContainer.Name = "PAN_DGVSearchContainer"
        Me.PAN_DGVSearchContainer.Size = New System.Drawing.Size(584, 414)
        Me.PAN_DGVSearchContainer.TabIndex = 113
        '
        'DGV_BProd
        '
        Me.DGV_BProd.AllowUserToAddRows = False
        Me.DGV_BProd.AllowUserToDeleteRows = False
        Me.DGV_BProd.AllowUserToResizeRows = False
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.DGV_BProd.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle5
        Me.DGV_BProd.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGV_BProd.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.DGV_BProd.ColumnHeadersHeight = 20
        Me.DGV_BProd.ContextMenuStrip = Me.MNU_CONTX_BUSCAR
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DGV_BProd.DefaultCellStyle = DataGridViewCellStyle7
        Me.DGV_BProd.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DGV_BProd.Location = New System.Drawing.Point(24, 28)
        Me.DGV_BProd.MultiSelect = False
        Me.DGV_BProd.Name = "DGV_BProd"
        Me.DGV_BProd.ReadOnly = True
        Me.DGV_BProd.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGV_BProd.RowHeadersDefaultCellStyle = DataGridViewCellStyle8
        Me.DGV_BProd.RowHeadersVisible = False
        Me.DGV_BProd.Size = New System.Drawing.Size(540, 370)
        Me.DGV_BProd.TabIndex = 114
        Me.DGV_BProd.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.DGV_BProd.ThemeStyle.AlternatingRowsStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DGV_BProd.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.SystemColors.ControlText
        Me.DGV_BProd.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DGV_BProd.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.DGV_BProd.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.DGV_BProd.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DGV_BProd.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.DGV_BProd.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.DGV_BProd.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DGV_BProd.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.DGV_BProd.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.DGV_BProd.ThemeStyle.HeaderStyle.Height = 20
        Me.DGV_BProd.ThemeStyle.ReadOnly = True
        Me.DGV_BProd.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.DGV_BProd.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.DGV_BProd.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DGV_BProd.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.DGV_BProd.ThemeStyle.RowsStyle.Height = 22
        Me.DGV_BProd.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DGV_BProd.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        '
        'PAN_HeaderPageInfoTitle
        '
        Me.PAN_HeaderPageInfoTitle.Controls.Add(Me.Label1)
        Me.PAN_HeaderPageInfoTitle.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PAN_HeaderPageInfoTitle.Location = New System.Drawing.Point(3, 3)
        Me.PAN_HeaderPageInfoTitle.Name = "PAN_HeaderPageInfoTitle"
        Me.PAN_HeaderPageInfoTitle.Size = New System.Drawing.Size(1192, 47)
        Me.PAN_HeaderPageInfoTitle.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.Font = New System.Drawing.Font("Britannic Bold", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(1192, 47)
        Me.Label1.TabIndex = 112
        Me.Label1.Text = "Configuración de productos favoritos"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PAN_BtnContainer
        '
        Me.PAN_BtnContainer.Controls.Add(Me.BTN_Actualizar)
        Me.PAN_BtnContainer.Controls.Add(Me.BTN_RegresarConfig)
        Me.PAN_BtnContainer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PAN_BtnContainer.Location = New System.Drawing.Point(3, 534)
        Me.PAN_BtnContainer.Name = "PAN_BtnContainer"
        Me.PAN_BtnContainer.Size = New System.Drawing.Size(1192, 53)
        Me.PAN_BtnContainer.TabIndex = 2
        '
        'BTN_RegresarConfig
        '
        Me.BTN_RegresarConfig.BorderColor = System.Drawing.Color.Red
        Me.BTN_RegresarConfig.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.BTN_RegresarConfig.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BTN_RegresarConfig.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BTN_RegresarConfig.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BTN_RegresarConfig.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BTN_RegresarConfig.Dock = System.Windows.Forms.DockStyle.Left
        Me.BTN_RegresarConfig.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BTN_RegresarConfig.Font = New System.Drawing.Font("Ebrima", 20.25!, System.Drawing.FontStyle.Bold)
        Me.BTN_RegresarConfig.ForeColor = System.Drawing.Color.White
        Me.BTN_RegresarConfig.Image = CType(resources.GetObject("BTN_RegresarConfig.Image"), System.Drawing.Image)
        Me.BTN_RegresarConfig.ImageSize = New System.Drawing.Size(40, 40)
        Me.BTN_RegresarConfig.Location = New System.Drawing.Point(0, 0)
        Me.BTN_RegresarConfig.Name = "BTN_RegresarConfig"
        Me.BTN_RegresarConfig.Size = New System.Drawing.Size(593, 53)
        Me.BTN_RegresarConfig.TabIndex = 56
        Me.BTN_RegresarConfig.Text = "Regresar"
        '
        'Guna2BorderlessForm1
        '
        Me.Guna2BorderlessForm1.BorderRadius = 25
        Me.Guna2BorderlessForm1.ContainerControl = Me
        Me.Guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6R
        Me.Guna2BorderlessForm1.TransparentWhileDrag = True
        '
        'Guna2DragControl1
        '
        Me.Guna2DragControl1.DockIndicatorTransparencyValue = 0.6R
        Me.Guna2DragControl1.UseTransparentDrag = True
        '
        'BTN_Actualizar
        '
        Me.BTN_Actualizar.BorderColor = System.Drawing.Color.MediumSeaGreen
        Me.BTN_Actualizar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.BTN_Actualizar.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BTN_Actualizar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BTN_Actualizar.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BTN_Actualizar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BTN_Actualizar.Dock = System.Windows.Forms.DockStyle.Left
        Me.BTN_Actualizar.FillColor = System.Drawing.Color.MediumSeaGreen
        Me.BTN_Actualizar.Font = New System.Drawing.Font("Ebrima", 20.25!, System.Drawing.FontStyle.Bold)
        Me.BTN_Actualizar.ForeColor = System.Drawing.Color.White
        Me.BTN_Actualizar.Image = CType(resources.GetObject("BTN_Actualizar.Image"), System.Drawing.Image)
        Me.BTN_Actualizar.ImageSize = New System.Drawing.Size(40, 40)
        Me.BTN_Actualizar.Location = New System.Drawing.Point(593, 0)
        Me.BTN_Actualizar.Name = "BTN_Actualizar"
        Me.BTN_Actualizar.Size = New System.Drawing.Size(593, 53)
        Me.BTN_Actualizar.TabIndex = 57
        Me.BTN_Actualizar.Text = "Actualizar"
        '
        'P_ConfigFavProd
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1198, 590)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "P_ConfigFavProd"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "P_ConfigFavProd"
        Me.MNU_CONTX_BUSCAR.ResumeLayout(False)
        Me.MNU_CONTX_FAV.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.PAN_InfoPageConfigFavProd.ResumeLayout(False)
        Me.TBL_DivSeccionsPageInfo.ResumeLayout(False)
        Me.PAN_TBLLayoutCell2.ResumeLayout(False)
        Me.PAN_ProdFavContainer.ResumeLayout(False)
        Me.PAN_DGVFavContainer.ResumeLayout(False)
        CType(Me.DGV_FavProd, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PAN_HeaderFavContainer.ResumeLayout(False)
        Me.PAN_TBLLayoutCell1.ResumeLayout(False)
        Me.TBL_TBLLayoutCell1.ResumeLayout(False)
        Me.PAN_DGVSearchContainer.ResumeLayout(False)
        CType(Me.DGV_BProd, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PAN_HeaderPageInfoTitle.ResumeLayout(False)
        Me.PAN_BtnContainer.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents MNU_CONTX_BUSCAR As Guna.UI2.WinForms.Guna2ContextMenuStrip
    Friend WithEvents MNU_SELECCIONAR As ToolStripMenuItem
    Friend WithEvents MNU_CONTX_FAV As Guna.UI2.WinForms.Guna2ContextMenuStrip
    Friend WithEvents MNU_ELIMINAR As ToolStripMenuItem
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents PAN_InfoPageConfigFavProd As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents TBL_DivSeccionsPageInfo As TableLayoutPanel
    Friend WithEvents PAN_TBLLayoutCell1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents PAN_ProdFavContainer As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents PAN_DGVFavContainer As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents PAN_HeaderFavContainer As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents LBL_FavTitle As Label
    Friend WithEvents TXT_BuscarProd As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents PAN_TBLLayoutCell2 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents TBL_TBLLayoutCell1 As TableLayoutPanel
    Friend WithEvents Label1 As Label
    Friend WithEvents DGV_FavProd As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents PAN_DGVSearchContainer As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents DGV_BProd As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents Guna2BorderlessForm1 As Guna.UI2.WinForms.Guna2BorderlessForm
    Friend WithEvents PAN_HeaderPageInfoTitle As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents BTN_RegresarConfig As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents ID As DataGridViewTextBoxColumn
    Friend WithEvents codigo As DataGridViewTextBoxColumn
    Friend WithEvents nombre As DataGridViewTextBoxColumn
    Friend WithEvents colorProd As DataGridViewTextBoxColumn
    Friend WithEvents BTN_MoveUp As Guna.UI2.WinForms.Guna2TileButton
    Friend WithEvents BTN_MoveDown As Guna.UI2.WinForms.Guna2TileButton
    Friend WithEvents PAN_BtnContainer As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2DragControl1 As Guna.UI2.WinForms.Guna2DragControl
    Friend WithEvents BTN_Actualizar As Guna.UI2.WinForms.Guna2Button
End Class
