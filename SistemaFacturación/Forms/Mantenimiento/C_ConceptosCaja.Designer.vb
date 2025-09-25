Namespace SistemaFacturacion.Forms.Mantenimiento
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Class C_ConceptosCaja
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(C_ConceptosCaja))
        Me.BTN_Config = New Guna.UI2.WinForms.Guna2ImageButton()
        Me.DGV_Entradas = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.MNU_CONTX = New Guna.UI2.WinForms.Guna2ContextMenuStrip()
        Me.MNU_MODIFICAR = New System.Windows.Forms.ToolStripMenuItem()
        Me.MNU_ELIMINAR = New System.Windows.Forms.ToolStripMenuItem()
        Me.TXT_BuscarSalidas = New Guna.UI2.WinForms.Guna2TextBox()
        Me.DGV_Salidas = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.TXT_BuscarEntradas = New Guna.UI2.WinForms.Guna2TextBox()
        Me.BTN_Regresar = New Guna.UI2.WinForms.Guna2Button()
        Me.BTN_AddSalida = New Guna.UI2.WinForms.Guna2CircleButton()
        Me.BTN_AddEntrada = New Guna.UI2.WinForms.Guna2CircleButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        CType(Me.DGV_Entradas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MNU_CONTX.SuspendLayout()
        CType(Me.DGV_Salidas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BTN_Config
        '
        Me.BTN_Config.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BTN_Config.BackColor = System.Drawing.Color.Transparent
        Me.BTN_Config.CheckedState.ImageSize = New System.Drawing.Size(40, 40)
        Me.BTN_Config.HoverState.Image = Global.SistemaFacturaciónCommon.My.Resources.Resources.ICO_ConfigCol
        Me.BTN_Config.HoverState.ImageSize = New System.Drawing.Size(43, 43)
        Me.BTN_Config.Image = Global.SistemaFacturaciónCommon.My.Resources.Resources.ICO_Config
        Me.BTN_Config.ImageOffset = New System.Drawing.Point(0, 0)
        Me.BTN_Config.ImageRotate = 0!
        Me.BTN_Config.ImageSize = New System.Drawing.Size(40, 40)
        Me.BTN_Config.Location = New System.Drawing.Point(718, 12)
        Me.BTN_Config.Name = "BTN_Config"
        Me.BTN_Config.PressedState.ImageSize = New System.Drawing.Size(64, 64)
        Me.BTN_Config.Size = New System.Drawing.Size(45, 45)
        Me.BTN_Config.TabIndex = 126
        '
        'DGV_Entradas
        '
        Me.DGV_Entradas.AllowUserToAddRows = False
        Me.DGV_Entradas.AllowUserToDeleteRows = False
        Me.DGV_Entradas.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.DGV_Entradas.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DGV_Entradas.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGV_Entradas.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DGV_Entradas.ColumnHeadersHeight = 20
        Me.DGV_Entradas.ContextMenuStrip = Me.MNU_CONTX
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DGV_Entradas.DefaultCellStyle = DataGridViewCellStyle3
        Me.DGV_Entradas.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DGV_Entradas.Location = New System.Drawing.Point(414, 179)
        Me.DGV_Entradas.MultiSelect = False
        Me.DGV_Entradas.Name = "DGV_Entradas"
        Me.DGV_Entradas.ReadOnly = True
        Me.DGV_Entradas.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGV_Entradas.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.DGV_Entradas.RowHeadersVisible = False
        Me.DGV_Entradas.Size = New System.Drawing.Size(333, 249)
        Me.DGV_Entradas.TabIndex = 125
        Me.DGV_Entradas.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.DGV_Entradas.ThemeStyle.AlternatingRowsStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DGV_Entradas.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.SystemColors.ControlText
        Me.DGV_Entradas.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DGV_Entradas.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.DGV_Entradas.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.DGV_Entradas.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DGV_Entradas.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.DGV_Entradas.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.DGV_Entradas.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DGV_Entradas.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.DGV_Entradas.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.DGV_Entradas.ThemeStyle.HeaderStyle.Height = 20
        Me.DGV_Entradas.ThemeStyle.ReadOnly = True
        Me.DGV_Entradas.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.DGV_Entradas.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.DGV_Entradas.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DGV_Entradas.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.DGV_Entradas.ThemeStyle.RowsStyle.Height = 22
        Me.DGV_Entradas.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DGV_Entradas.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
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
        '
        'TXT_BuscarSalidas
        '
        Me.TXT_BuscarSalidas.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TXT_BuscarSalidas.BorderRadius = 20
        Me.TXT_BuscarSalidas.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TXT_BuscarSalidas.DefaultText = ""
        Me.TXT_BuscarSalidas.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TXT_BuscarSalidas.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TXT_BuscarSalidas.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXT_BuscarSalidas.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXT_BuscarSalidas.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXT_BuscarSalidas.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.TXT_BuscarSalidas.ForeColor = System.Drawing.Color.Black
        Me.TXT_BuscarSalidas.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXT_BuscarSalidas.IconRight = Global.SistemaFacturaciónCommon.My.Resources.Resources.ICO_SearchCol
        Me.TXT_BuscarSalidas.IconRightOffset = New System.Drawing.Point(10, 0)
        Me.TXT_BuscarSalidas.IconRightSize = New System.Drawing.Size(40, 40)
        Me.TXT_BuscarSalidas.Location = New System.Drawing.Point(26, 119)
        Me.TXT_BuscarSalidas.Name = "TXT_BuscarSalidas"
        Me.TXT_BuscarSalidas.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TXT_BuscarSalidas.PlaceholderText = "Buscar concepto de salidas"
        Me.TXT_BuscarSalidas.SelectedText = ""
        Me.TXT_BuscarSalidas.Size = New System.Drawing.Size(283, 42)
        Me.TXT_BuscarSalidas.TabIndex = 124
        '
        'DGV_Salidas
        '
        Me.DGV_Salidas.AllowUserToAddRows = False
        Me.DGV_Salidas.AllowUserToDeleteRows = False
        Me.DGV_Salidas.AllowUserToResizeRows = False
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.DGV_Salidas.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle5
        Me.DGV_Salidas.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGV_Salidas.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.DGV_Salidas.ColumnHeadersHeight = 20
        Me.DGV_Salidas.ContextMenuStrip = Me.MNU_CONTX
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DGV_Salidas.DefaultCellStyle = DataGridViewCellStyle7
        Me.DGV_Salidas.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DGV_Salidas.Location = New System.Drawing.Point(26, 179)
        Me.DGV_Salidas.MultiSelect = False
        Me.DGV_Salidas.Name = "DGV_Salidas"
        Me.DGV_Salidas.ReadOnly = True
        Me.DGV_Salidas.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGV_Salidas.RowHeadersDefaultCellStyle = DataGridViewCellStyle8
        Me.DGV_Salidas.RowHeadersVisible = False
        Me.DGV_Salidas.Size = New System.Drawing.Size(333, 249)
        Me.DGV_Salidas.TabIndex = 127
        Me.DGV_Salidas.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.DGV_Salidas.ThemeStyle.AlternatingRowsStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DGV_Salidas.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.SystemColors.ControlText
        Me.DGV_Salidas.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DGV_Salidas.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.DGV_Salidas.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.DGV_Salidas.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DGV_Salidas.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.DGV_Salidas.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.DGV_Salidas.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DGV_Salidas.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.DGV_Salidas.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.DGV_Salidas.ThemeStyle.HeaderStyle.Height = 20
        Me.DGV_Salidas.ThemeStyle.ReadOnly = True
        Me.DGV_Salidas.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.DGV_Salidas.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.DGV_Salidas.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DGV_Salidas.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.DGV_Salidas.ThemeStyle.RowsStyle.Height = 22
        Me.DGV_Salidas.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DGV_Salidas.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        '
        'TXT_BuscarEntradas
        '
        Me.TXT_BuscarEntradas.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TXT_BuscarEntradas.BorderRadius = 20
        Me.TXT_BuscarEntradas.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TXT_BuscarEntradas.DefaultText = ""
        Me.TXT_BuscarEntradas.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TXT_BuscarEntradas.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TXT_BuscarEntradas.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXT_BuscarEntradas.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXT_BuscarEntradas.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXT_BuscarEntradas.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.TXT_BuscarEntradas.ForeColor = System.Drawing.Color.Black
        Me.TXT_BuscarEntradas.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXT_BuscarEntradas.IconRight = Global.SistemaFacturaciónCommon.My.Resources.Resources.ICO_SearchCol
        Me.TXT_BuscarEntradas.IconRightOffset = New System.Drawing.Point(10, 0)
        Me.TXT_BuscarEntradas.IconRightSize = New System.Drawing.Size(40, 40)
        Me.TXT_BuscarEntradas.Location = New System.Drawing.Point(414, 119)
        Me.TXT_BuscarEntradas.Name = "TXT_BuscarEntradas"
        Me.TXT_BuscarEntradas.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TXT_BuscarEntradas.PlaceholderText = "Buscar concepto de entradas"
        Me.TXT_BuscarEntradas.SelectedText = ""
        Me.TXT_BuscarEntradas.Size = New System.Drawing.Size(283, 42)
        Me.TXT_BuscarEntradas.TabIndex = 128
        '
        'BTN_Regresar
        '
        Me.BTN_Regresar.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BTN_Regresar.BorderColor = System.Drawing.Color.Red
        Me.BTN_Regresar.BorderRadius = 10
        Me.BTN_Regresar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.BTN_Regresar.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BTN_Regresar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BTN_Regresar.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BTN_Regresar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BTN_Regresar.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BTN_Regresar.Font = New System.Drawing.Font("Ebrima", 20.25!, System.Drawing.FontStyle.Bold)
        Me.BTN_Regresar.ForeColor = System.Drawing.Color.White
        Me.BTN_Regresar.Image = Global.SistemaFacturaciónCommon.My.Resources.Resources.ICO_Back
        Me.BTN_Regresar.ImageSize = New System.Drawing.Size(40, 40)
        Me.BTN_Regresar.Location = New System.Drawing.Point(26, 439)
        Me.BTN_Regresar.Name = "BTN_Regresar"
        Me.BTN_Regresar.Size = New System.Drawing.Size(721, 55)
        Me.BTN_Regresar.TabIndex = 129
        Me.BTN_Regresar.Text = "Regresar"
        '
        'BTN_AddSalida
        '
        Me.BTN_AddSalida.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BTN_AddSalida.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BTN_AddSalida.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BTN_AddSalida.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BTN_AddSalida.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BTN_AddSalida.FillColor = System.Drawing.Color.Transparent
        Me.BTN_AddSalida.Font = New System.Drawing.Font("Snap ITC", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_AddSalida.ForeColor = System.Drawing.Color.White
        Me.BTN_AddSalida.HoverState.Image = CType(resources.GetObject("resource.Image"), System.Drawing.Image)
        Me.BTN_AddSalida.Image = CType(resources.GetObject("BTN_AddSalida.Image"), System.Drawing.Image)
        Me.BTN_AddSalida.ImageSize = New System.Drawing.Size(45, 45)
        Me.BTN_AddSalida.Location = New System.Drawing.Point(315, 119)
        Me.BTN_AddSalida.Name = "BTN_AddSalida"
        Me.BTN_AddSalida.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.BTN_AddSalida.Size = New System.Drawing.Size(44, 44)
        Me.BTN_AddSalida.TabIndex = 130
        '
        'BTN_AddEntrada
        '
        Me.BTN_AddEntrada.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BTN_AddEntrada.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BTN_AddEntrada.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BTN_AddEntrada.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BTN_AddEntrada.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BTN_AddEntrada.FillColor = System.Drawing.Color.Transparent
        Me.BTN_AddEntrada.Font = New System.Drawing.Font("Snap ITC", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_AddEntrada.ForeColor = System.Drawing.Color.White
        Me.BTN_AddEntrada.HoverState.Image = CType(resources.GetObject("resource.Image1"), System.Drawing.Image)
        Me.BTN_AddEntrada.Image = CType(resources.GetObject("BTN_AddEntrada.Image"), System.Drawing.Image)
        Me.BTN_AddEntrada.ImageSize = New System.Drawing.Size(45, 45)
        Me.BTN_AddEntrada.Location = New System.Drawing.Point(703, 119)
        Me.BTN_AddEntrada.Name = "BTN_AddEntrada"
        Me.BTN_AddEntrada.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.BTN_AddEntrada.Size = New System.Drawing.Size(44, 44)
        Me.BTN_AddEntrada.TabIndex = 131
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Britannic Bold", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(85, 76)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(205, 23)
        Me.Label1.TabIndex = 132
        Me.Label1.Text = "Conceptos de Salidas"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Britannic Bold", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(487, 76)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(219, 23)
        Me.Label2.TabIndex = 133
        Me.Label2.Text = "Conceptos de entradas"
        '
        'Label3
        '
        Me.Label3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Britannic Bold", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(142, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(499, 41)
        Me.Label3.TabIndex = 134
        Me.Label3.Text = "Tipos de movimientos de caja"
        '
        'C_ConceptosCaja
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(775, 506)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BTN_AddEntrada)
        Me.Controls.Add(Me.BTN_AddSalida)
        Me.Controls.Add(Me.BTN_Regresar)
        Me.Controls.Add(Me.TXT_BuscarEntradas)
        Me.Controls.Add(Me.DGV_Salidas)
        Me.Controls.Add(Me.BTN_Config)
        Me.Controls.Add(Me.DGV_Entradas)
        Me.Controls.Add(Me.TXT_BuscarSalidas)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Name = "C_ConceptosCaja"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Conceptos de entradas y salidas de caja"
        CType(Me.DGV_Entradas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MNU_CONTX.ResumeLayout(False)
        CType(Me.DGV_Salidas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BTN_Config As Guna.UI2.WinForms.Guna2ImageButton
    Friend WithEvents DGV_Entradas As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents TXT_BuscarSalidas As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents DGV_Salidas As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents TXT_BuscarEntradas As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents BTN_Regresar As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BTN_AddSalida As Guna.UI2.WinForms.Guna2CircleButton
    Friend WithEvents BTN_AddEntrada As Guna.UI2.WinForms.Guna2CircleButton
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents MNU_CONTX As Guna.UI2.WinForms.Guna2ContextMenuStrip
    Friend WithEvents MNU_MODIFICAR As ToolStripMenuItem
    Friend WithEvents MNU_ELIMINAR As ToolStripMenuItem
End Class

End Namespace