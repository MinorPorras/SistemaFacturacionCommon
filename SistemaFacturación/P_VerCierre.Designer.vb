<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class P_VerCierre
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(P_VerCierre))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.TBL_LayoutVerCierre = New System.Windows.Forms.TableLayoutPanel()
        Me.Guna2HtmlLabel16 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.TBL_LayoutSearch = New System.Windows.Forms.TableLayoutPanel()
        Me.DTP_Desde = New Guna.UI2.WinForms.Guna2DateTimePicker()
        Me.Guna2HtmlLabel2 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel1 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.TXT_BuscarComentario = New Guna.UI2.WinForms.Guna2TextBox()
        Me.PAN_SWTBuscarFecha = New Guna.UI2.WinForms.Guna2Panel()
        Me.SWT_ActivateDateSearch = New Guna.UI2.WinForms.Guna2ToggleSwitch()
        Me.Guna2HtmlLabel3 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.PAN_BTNAccions = New Guna.UI2.WinForms.Guna2Panel()
        Me.BTN_RegresarReporte = New Guna.UI2.WinForms.Guna2Button()
        Me.PAN_dgvVerCierre = New Guna.UI2.WinForms.Guna2Panel()
        Me.DGV_ListaCierres = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.MNU_CONTX = New Guna.UI2.WinForms.Guna2ContextMenuStrip()
        Me.MNU_Datos = New System.Windows.Forms.ToolStripMenuItem()
        Me.TBL_LayoutVerCierre.SuspendLayout()
        Me.TBL_LayoutSearch.SuspendLayout()
        Me.PAN_SWTBuscarFecha.SuspendLayout()
        Me.PAN_BTNAccions.SuspendLayout()
        Me.PAN_dgvVerCierre.SuspendLayout()
        CType(Me.DGV_ListaCierres, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MNU_CONTX.SuspendLayout()
        Me.SuspendLayout()
        '
        'TBL_LayoutVerCierre
        '
        Me.TBL_LayoutVerCierre.ColumnCount = 1
        Me.TBL_LayoutVerCierre.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TBL_LayoutVerCierre.Controls.Add(Me.Guna2HtmlLabel16, 0, 0)
        Me.TBL_LayoutVerCierre.Controls.Add(Me.TBL_LayoutSearch, 0, 1)
        Me.TBL_LayoutVerCierre.Controls.Add(Me.PAN_BTNAccions, 0, 3)
        Me.TBL_LayoutVerCierre.Controls.Add(Me.PAN_dgvVerCierre, 0, 2)
        Me.TBL_LayoutVerCierre.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TBL_LayoutVerCierre.Location = New System.Drawing.Point(0, 0)
        Me.TBL_LayoutVerCierre.Name = "TBL_LayoutVerCierre"
        Me.TBL_LayoutVerCierre.RowCount = 4
        Me.TBL_LayoutVerCierre.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60.0!))
        Me.TBL_LayoutVerCierre.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60.0!))
        Me.TBL_LayoutVerCierre.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TBL_LayoutVerCierre.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60.0!))
        Me.TBL_LayoutVerCierre.Size = New System.Drawing.Size(994, 576)
        Me.TBL_LayoutVerCierre.TabIndex = 0
        '
        'Guna2HtmlLabel16
        '
        Me.Guna2HtmlLabel16.AutoSize = False
        Me.Guna2HtmlLabel16.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel16.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Guna2HtmlLabel16.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel16.ForeColor = System.Drawing.SystemColors.Control
        Me.Guna2HtmlLabel16.Location = New System.Drawing.Point(3, 3)
        Me.Guna2HtmlLabel16.Name = "Guna2HtmlLabel16"
        Me.Guna2HtmlLabel16.Size = New System.Drawing.Size(988, 54)
        Me.Guna2HtmlLabel16.TabIndex = 153
        Me.Guna2HtmlLabel16.Text = "Consulta de cierres de caja"
        Me.Guna2HtmlLabel16.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.Guna2HtmlLabel16.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit
        '
        'TBL_LayoutSearch
        '
        Me.TBL_LayoutSearch.ColumnCount = 5
        Me.TBL_LayoutSearch.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.49541!))
        Me.TBL_LayoutSearch.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80.50459!))
        Me.TBL_LayoutSearch.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 109.0!))
        Me.TBL_LayoutSearch.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 299.0!))
        Me.TBL_LayoutSearch.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 112.0!))
        Me.TBL_LayoutSearch.Controls.Add(Me.DTP_Desde, 3, 0)
        Me.TBL_LayoutSearch.Controls.Add(Me.Guna2HtmlLabel2, 2, 0)
        Me.TBL_LayoutSearch.Controls.Add(Me.Guna2HtmlLabel1, 0, 0)
        Me.TBL_LayoutSearch.Controls.Add(Me.TXT_BuscarComentario, 1, 0)
        Me.TBL_LayoutSearch.Controls.Add(Me.PAN_SWTBuscarFecha, 4, 0)
        Me.TBL_LayoutSearch.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TBL_LayoutSearch.Location = New System.Drawing.Point(3, 63)
        Me.TBL_LayoutSearch.Name = "TBL_LayoutSearch"
        Me.TBL_LayoutSearch.RowCount = 1
        Me.TBL_LayoutSearch.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TBL_LayoutSearch.Size = New System.Drawing.Size(988, 54)
        Me.TBL_LayoutSearch.TabIndex = 154
        '
        'DTP_Desde
        '
        Me.DTP_Desde.BorderRadius = 10
        Me.DTP_Desde.Checked = True
        Me.DTP_Desde.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DTP_Desde.FillColor = System.Drawing.Color.White
        Me.DTP_Desde.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.DTP_Desde.Format = System.Windows.Forms.DateTimePickerFormat.[Long]
        Me.DTP_Desde.Location = New System.Drawing.Point(579, 3)
        Me.DTP_Desde.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.DTP_Desde.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.DTP_Desde.Name = "DTP_Desde"
        Me.DTP_Desde.Size = New System.Drawing.Size(293, 48)
        Me.DTP_Desde.TabIndex = 157
        Me.DTP_Desde.Value = New Date(2025, 3, 17, 19, 28, 7, 244)
        '
        'Guna2HtmlLabel2
        '
        Me.Guna2HtmlLabel2.AutoSize = False
        Me.Guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Guna2HtmlLabel2.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel2.ForeColor = System.Drawing.SystemColors.Control
        Me.Guna2HtmlLabel2.Location = New System.Drawing.Point(470, 3)
        Me.Guna2HtmlLabel2.Name = "Guna2HtmlLabel2"
        Me.Guna2HtmlLabel2.Size = New System.Drawing.Size(103, 48)
        Me.Guna2HtmlLabel2.TabIndex = 156
        Me.Guna2HtmlLabel2.Text = "Fecha:"
        Me.Guna2HtmlLabel2.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.Guna2HtmlLabel2.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit
        '
        'Guna2HtmlLabel1
        '
        Me.Guna2HtmlLabel1.AutoSize = False
        Me.Guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Guna2HtmlLabel1.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel1.ForeColor = System.Drawing.SystemColors.Control
        Me.Guna2HtmlLabel1.Location = New System.Drawing.Point(3, 3)
        Me.Guna2HtmlLabel1.Name = "Guna2HtmlLabel1"
        Me.Guna2HtmlLabel1.Size = New System.Drawing.Size(85, 48)
        Me.Guna2HtmlLabel1.TabIndex = 154
        Me.Guna2HtmlLabel1.Text = "Buscar:"
        Me.Guna2HtmlLabel1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.Guna2HtmlLabel1.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit
        '
        'TXT_BuscarComentario
        '
        Me.TXT_BuscarComentario.BorderRadius = 10
        Me.TXT_BuscarComentario.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TXT_BuscarComentario.DefaultText = ""
        Me.TXT_BuscarComentario.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TXT_BuscarComentario.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TXT_BuscarComentario.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXT_BuscarComentario.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXT_BuscarComentario.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TXT_BuscarComentario.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXT_BuscarComentario.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.TXT_BuscarComentario.ForeColor = System.Drawing.Color.Black
        Me.TXT_BuscarComentario.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXT_BuscarComentario.IconRightSize = New System.Drawing.Size(40, 40)
        Me.TXT_BuscarComentario.Location = New System.Drawing.Point(94, 3)
        Me.TXT_BuscarComentario.Name = "TXT_BuscarComentario"
        Me.TXT_BuscarComentario.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TXT_BuscarComentario.PlaceholderText = ""
        Me.TXT_BuscarComentario.SelectedText = ""
        Me.TXT_BuscarComentario.Size = New System.Drawing.Size(370, 48)
        Me.TXT_BuscarComentario.TabIndex = 155
        '
        'PAN_SWTBuscarFecha
        '
        Me.PAN_SWTBuscarFecha.Controls.Add(Me.SWT_ActivateDateSearch)
        Me.PAN_SWTBuscarFecha.Controls.Add(Me.Guna2HtmlLabel3)
        Me.PAN_SWTBuscarFecha.Location = New System.Drawing.Point(878, 3)
        Me.PAN_SWTBuscarFecha.Name = "PAN_SWTBuscarFecha"
        Me.PAN_SWTBuscarFecha.Size = New System.Drawing.Size(106, 48)
        Me.PAN_SWTBuscarFecha.TabIndex = 158
        '
        'SWT_ActivateDateSearch
        '
        Me.SWT_ActivateDateSearch.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SWT_ActivateDateSearch.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.SWT_ActivateDateSearch.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.SWT_ActivateDateSearch.CheckedState.InnerBorderColor = System.Drawing.Color.White
        Me.SWT_ActivateDateSearch.CheckedState.InnerColor = System.Drawing.Color.White
        Me.SWT_ActivateDateSearch.Location = New System.Drawing.Point(25, 26)
        Me.SWT_ActivateDateSearch.Name = "SWT_ActivateDateSearch"
        Me.SWT_ActivateDateSearch.Size = New System.Drawing.Size(53, 20)
        Me.SWT_ActivateDateSearch.TabIndex = 158
        Me.SWT_ActivateDateSearch.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.SWT_ActivateDateSearch.UncheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.SWT_ActivateDateSearch.UncheckedState.InnerBorderColor = System.Drawing.Color.White
        Me.SWT_ActivateDateSearch.UncheckedState.InnerColor = System.Drawing.Color.White
        '
        'Guna2HtmlLabel3
        '
        Me.Guna2HtmlLabel3.AutoSize = False
        Me.Guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Guna2HtmlLabel3.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel3.ForeColor = System.Drawing.SystemColors.Control
        Me.Guna2HtmlLabel3.Location = New System.Drawing.Point(0, 0)
        Me.Guna2HtmlLabel3.Name = "Guna2HtmlLabel3"
        Me.Guna2HtmlLabel3.Size = New System.Drawing.Size(106, 25)
        Me.Guna2HtmlLabel3.TabIndex = 157
        Me.Guna2HtmlLabel3.Text = "Activar"
        Me.Guna2HtmlLabel3.TextAlignment = System.Drawing.ContentAlignment.TopCenter
        Me.Guna2HtmlLabel3.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit
        '
        'PAN_BTNAccions
        '
        Me.PAN_BTNAccions.Controls.Add(Me.BTN_RegresarReporte)
        Me.PAN_BTNAccions.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PAN_BTNAccions.Location = New System.Drawing.Point(3, 519)
        Me.PAN_BTNAccions.Name = "PAN_BTNAccions"
        Me.PAN_BTNAccions.Size = New System.Drawing.Size(988, 54)
        Me.PAN_BTNAccions.TabIndex = 156
        '
        'BTN_RegresarReporte
        '
        Me.BTN_RegresarReporte.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BTN_RegresarReporte.BorderRadius = 10
        Me.BTN_RegresarReporte.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.BTN_RegresarReporte.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BTN_RegresarReporte.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BTN_RegresarReporte.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BTN_RegresarReporte.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BTN_RegresarReporte.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BTN_RegresarReporte.Font = New System.Drawing.Font("Ebrima", 20.25!, System.Drawing.FontStyle.Bold)
        Me.BTN_RegresarReporte.ForeColor = System.Drawing.Color.White
        Me.BTN_RegresarReporte.Image = CType(resources.GetObject("BTN_RegresarReporte.Image"), System.Drawing.Image)
        Me.BTN_RegresarReporte.ImageSize = New System.Drawing.Size(60, 60)
        Me.BTN_RegresarReporte.Location = New System.Drawing.Point(16, 1)
        Me.BTN_RegresarReporte.Name = "BTN_RegresarReporte"
        Me.BTN_RegresarReporte.Size = New System.Drawing.Size(956, 51)
        Me.BTN_RegresarReporte.TabIndex = 84
        Me.BTN_RegresarReporte.Text = "Regresar"
        '
        'PAN_dgvVerCierre
        '
        Me.PAN_dgvVerCierre.Controls.Add(Me.DGV_ListaCierres)
        Me.PAN_dgvVerCierre.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PAN_dgvVerCierre.Location = New System.Drawing.Point(3, 123)
        Me.PAN_dgvVerCierre.Name = "PAN_dgvVerCierre"
        Me.PAN_dgvVerCierre.Size = New System.Drawing.Size(988, 390)
        Me.PAN_dgvVerCierre.TabIndex = 157
        '
        'DGV_ListaCierres
        '
        Me.DGV_ListaCierres.AllowUserToAddRows = False
        Me.DGV_ListaCierres.AllowUserToDeleteRows = False
        Me.DGV_ListaCierres.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.DGV_ListaCierres.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DGV_ListaCierres.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGV_ListaCierres.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DGV_ListaCierres.ColumnHeadersHeight = 20
        Me.DGV_ListaCierres.ContextMenuStrip = Me.MNU_CONTX
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DGV_ListaCierres.DefaultCellStyle = DataGridViewCellStyle3
        Me.DGV_ListaCierres.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DGV_ListaCierres.Location = New System.Drawing.Point(16, 13)
        Me.DGV_ListaCierres.MultiSelect = False
        Me.DGV_ListaCierres.Name = "DGV_ListaCierres"
        Me.DGV_ListaCierres.ReadOnly = True
        Me.DGV_ListaCierres.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGV_ListaCierres.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.DGV_ListaCierres.RowHeadersVisible = False
        Me.DGV_ListaCierres.Size = New System.Drawing.Size(956, 367)
        Me.DGV_ListaCierres.TabIndex = 156
        Me.DGV_ListaCierres.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.DGV_ListaCierres.ThemeStyle.AlternatingRowsStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DGV_ListaCierres.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.SystemColors.ControlText
        Me.DGV_ListaCierres.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DGV_ListaCierres.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.DGV_ListaCierres.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.DGV_ListaCierres.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DGV_ListaCierres.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.DGV_ListaCierres.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.DGV_ListaCierres.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DGV_ListaCierres.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.DGV_ListaCierres.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.DGV_ListaCierres.ThemeStyle.HeaderStyle.Height = 20
        Me.DGV_ListaCierres.ThemeStyle.ReadOnly = True
        Me.DGV_ListaCierres.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.DGV_ListaCierres.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.DGV_ListaCierres.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DGV_ListaCierres.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.DGV_ListaCierres.ThemeStyle.RowsStyle.Height = 22
        Me.DGV_ListaCierres.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DGV_ListaCierres.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        '
        'MNU_CONTX
        '
        Me.MNU_CONTX.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MNU_CONTX.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MNU_Datos})
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
        Me.MNU_CONTX.Size = New System.Drawing.Size(185, 52)
        '
        'MNU_Datos
        '
        Me.MNU_Datos.BackColor = System.Drawing.Color.DarkGoldenrod
        Me.MNU_Datos.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MNU_Datos.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.MNU_Datos.Image = CType(resources.GetObject("MNU_Datos.Image"), System.Drawing.Image)
        Me.MNU_Datos.Name = "MNU_Datos"
        Me.MNU_Datos.Size = New System.Drawing.Size(184, 26)
        Me.MNU_Datos.Text = "Ver datos"
        '
        'P_VerCierre
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(994, 576)
        Me.Controls.Add(Me.TBL_LayoutVerCierre)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Name = "P_VerCierre"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ver cierres anteriores"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.TBL_LayoutVerCierre.ResumeLayout(False)
        Me.TBL_LayoutSearch.ResumeLayout(False)
        Me.PAN_SWTBuscarFecha.ResumeLayout(False)
        Me.PAN_BTNAccions.ResumeLayout(False)
        Me.PAN_dgvVerCierre.ResumeLayout(False)
        CType(Me.DGV_ListaCierres, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MNU_CONTX.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TBL_LayoutVerCierre As TableLayoutPanel
    Friend WithEvents Guna2HtmlLabel16 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents TBL_LayoutSearch As TableLayoutPanel
    Friend WithEvents Guna2HtmlLabel1 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents TXT_BuscarComentario As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2HtmlLabel2 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents DTP_Desde As Guna.UI2.WinForms.Guna2DateTimePicker
    Friend WithEvents PAN_BTNAccions As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents BTN_RegresarReporte As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents MNU_CONTX As Guna.UI2.WinForms.Guna2ContextMenuStrip
    Friend WithEvents MNU_Datos As ToolStripMenuItem
    Friend WithEvents PAN_dgvVerCierre As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents DGV_ListaCierres As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents PAN_SWTBuscarFecha As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2HtmlLabel3 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents SWT_ActivateDateSearch As Guna.UI2.WinForms.Guna2ToggleSwitch
End Class
