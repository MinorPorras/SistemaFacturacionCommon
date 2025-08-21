<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class P_Hablador
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(P_Hablador))
        Me.Guna2BorderlessForm1 = New Guna.UI2.WinForms.Guna2BorderlessForm(Me.components)
        Me.MNU_CONTX = New Guna.UI2.WinForms.Guna2ContextMenuStrip()
        Me.MNU_SELECCIONAR = New System.Windows.Forms.ToolStripMenuItem()
        Me.DGV_Hablador = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.codigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.precio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cant = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MNU_CONTX_IMP = New Guna.UI2.WinForms.Guna2ContextMenuStrip()
        Me.MNU_ELIMINAR = New System.Windows.Forms.ToolStripMenuItem()
        Me.Guna2PictureBox2 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DGV_BProd = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.TXT_BuscarProd = New Guna.UI2.WinForms.Guna2TextBox()
        Me.BTN_RegresarPrd = New Guna.UI2.WinForms.Guna2Button()
        Me.BTN_Imprimir = New Guna.UI2.WinForms.Guna2Button()
        Me.PrintDocument = New System.Drawing.Printing.PrintDocument()
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.BTN_Config = New Guna.UI2.WinForms.Guna2ImageButton()
        Me.MNU_CONTX.SuspendLayout()
        CType(Me.DGV_Hablador, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MNU_CONTX_IMP.SuspendLayout()
        CType(Me.Guna2PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGV_BProd, System.ComponentModel.ISupportInitialize).BeginInit()
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
        'MNU_CONTX
        '
        Me.MNU_CONTX.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MNU_CONTX.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MNU_SELECCIONAR})
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
        Me.MNU_CONTX.Size = New System.Drawing.Size(149, 30)
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
        'DGV_Hablador
        '
        Me.DGV_Hablador.AllowUserToAddRows = False
        Me.DGV_Hablador.AllowUserToDeleteRows = False
        Me.DGV_Hablador.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.DGV_Hablador.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGV_Hablador.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DGV_Hablador.ColumnHeadersHeight = 20
        Me.DGV_Hablador.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ID, Me.codigo, Me.nombre, Me.precio, Me.cant})
        Me.DGV_Hablador.ContextMenuStrip = Me.MNU_CONTX_IMP
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DGV_Hablador.DefaultCellStyle = DataGridViewCellStyle3
        Me.DGV_Hablador.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DGV_Hablador.Location = New System.Drawing.Point(474, 213)
        Me.DGV_Hablador.MultiSelect = False
        Me.DGV_Hablador.Name = "DGV_Hablador"
        Me.DGV_Hablador.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGV_Hablador.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.DGV_Hablador.RowHeadersVisible = False
        Me.DGV_Hablador.Size = New System.Drawing.Size(391, 287)
        Me.DGV_Hablador.TabIndex = 69
        Me.DGV_Hablador.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.DGV_Hablador.ThemeStyle.AlternatingRowsStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DGV_Hablador.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.SystemColors.ControlText
        Me.DGV_Hablador.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DGV_Hablador.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.DGV_Hablador.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.DGV_Hablador.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DGV_Hablador.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.DGV_Hablador.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.DGV_Hablador.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DGV_Hablador.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.DGV_Hablador.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.DGV_Hablador.ThemeStyle.HeaderStyle.Height = 20
        Me.DGV_Hablador.ThemeStyle.ReadOnly = False
        Me.DGV_Hablador.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.DGV_Hablador.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.DGV_Hablador.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DGV_Hablador.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.DGV_Hablador.ThemeStyle.RowsStyle.Height = 22
        Me.DGV_Hablador.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DGV_Hablador.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        '
        'ID
        '
        Me.ID.HeaderText = "ID"
        Me.ID.Name = "ID"
        Me.ID.Visible = False
        '
        'codigo
        '
        Me.codigo.FillWeight = 81.21828!
        Me.codigo.HeaderText = "Código"
        Me.codigo.Name = "codigo"
        '
        'nombre
        '
        Me.nombre.FillWeight = 233.6328!
        Me.nombre.HeaderText = "Producto"
        Me.nombre.Name = "nombre"
        '
        'precio
        '
        Me.precio.FillWeight = 52.7853!
        Me.precio.HeaderText = "Precio"
        Me.precio.Name = "precio"
        '
        'cant
        '
        Me.cant.FillWeight = 32.36362!
        Me.cant.HeaderText = "Cant."
        Me.cant.Name = "cant"
        '
        'MNU_CONTX_IMP
        '
        Me.MNU_CONTX_IMP.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MNU_CONTX_IMP.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MNU_ELIMINAR})
        Me.MNU_CONTX_IMP.Name = "MNU_CONTX"
        Me.MNU_CONTX_IMP.RenderStyle.ArrowColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.MNU_CONTX_IMP.RenderStyle.BorderColor = System.Drawing.Color.Gainsboro
        Me.MNU_CONTX_IMP.RenderStyle.ColorTable = Nothing
        Me.MNU_CONTX_IMP.RenderStyle.RoundedEdges = True
        Me.MNU_CONTX_IMP.RenderStyle.SelectionArrowColor = System.Drawing.Color.White
        Me.MNU_CONTX_IMP.RenderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.MNU_CONTX_IMP.RenderStyle.SelectionForeColor = System.Drawing.Color.White
        Me.MNU_CONTX_IMP.RenderStyle.SeparatorColor = System.Drawing.Color.Gainsboro
        Me.MNU_CONTX_IMP.RenderStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault
        Me.MNU_CONTX_IMP.Size = New System.Drawing.Size(128, 30)
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
        'Guna2PictureBox2
        '
        Me.Guna2PictureBox2.Image = CType(resources.GetObject("Guna2PictureBox2.Image"), System.Drawing.Image)
        Me.Guna2PictureBox2.ImageRotate = 0!
        Me.Guna2PictureBox2.Location = New System.Drawing.Point(282, -79)
        Me.Guna2PictureBox2.Name = "Guna2PictureBox2"
        Me.Guna2PictureBox2.Size = New System.Drawing.Size(340, 313)
        Me.Guna2PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Guna2PictureBox2.TabIndex = 70
        Me.Guna2PictureBox2.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Britannic Bold", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(560, 184)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(224, 23)
        Me.Label1.TabIndex = 71
        Me.Label1.Text = "Habladores a imprimir:"
        '
        'DGV_BProd
        '
        Me.DGV_BProd.AllowUserToAddRows = False
        Me.DGV_BProd.AllowUserToDeleteRows = False
        Me.DGV_BProd.AllowUserToResizeRows = False
        DataGridViewCellStyle9.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.DGV_BProd.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle9
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle10.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGV_BProd.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle10
        Me.DGV_BProd.ColumnHeadersHeight = 20
        Me.DGV_BProd.ContextMenuStrip = Me.MNU_CONTX
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle11.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle11.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DGV_BProd.DefaultCellStyle = DataGridViewCellStyle11
        Me.DGV_BProd.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DGV_BProd.Location = New System.Drawing.Point(12, 213)
        Me.DGV_BProd.MultiSelect = False
        Me.DGV_BProd.Name = "DGV_BProd"
        Me.DGV_BProd.ReadOnly = True
        Me.DGV_BProd.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle12.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGV_BProd.RowHeadersDefaultCellStyle = DataGridViewCellStyle12
        Me.DGV_BProd.RowHeadersVisible = False
        Me.DGV_BProd.Size = New System.Drawing.Size(456, 287)
        Me.DGV_BProd.TabIndex = 108
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
        'TXT_BuscarProd
        '
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
        Me.TXT_BuscarProd.Location = New System.Drawing.Point(12, 165)
        Me.TXT_BuscarProd.Name = "TXT_BuscarProd"
        Me.TXT_BuscarProd.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TXT_BuscarProd.PlaceholderText = "Buscar producto"
        Me.TXT_BuscarProd.SelectedText = ""
        Me.TXT_BuscarProd.Size = New System.Drawing.Size(456, 42)
        Me.TXT_BuscarProd.TabIndex = 107
        '
        'BTN_RegresarPrd
        '
        Me.BTN_RegresarPrd.BorderColor = System.Drawing.Color.Red
        Me.BTN_RegresarPrd.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.BTN_RegresarPrd.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BTN_RegresarPrd.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BTN_RegresarPrd.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BTN_RegresarPrd.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BTN_RegresarPrd.Dock = System.Windows.Forms.DockStyle.Left
        Me.BTN_RegresarPrd.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BTN_RegresarPrd.Font = New System.Drawing.Font("Ebrima", 20.25!, System.Drawing.FontStyle.Bold)
        Me.BTN_RegresarPrd.ForeColor = System.Drawing.Color.White
        Me.BTN_RegresarPrd.Image = CType(resources.GetObject("BTN_RegresarPrd.Image"), System.Drawing.Image)
        Me.BTN_RegresarPrd.ImageSize = New System.Drawing.Size(40, 40)
        Me.BTN_RegresarPrd.Location = New System.Drawing.Point(0, 0)
        Me.BTN_RegresarPrd.Name = "BTN_RegresarPrd"
        Me.BTN_RegresarPrd.Size = New System.Drawing.Size(444, 58)
        Me.BTN_RegresarPrd.TabIndex = 110
        Me.BTN_RegresarPrd.Text = "Regresar"
        '
        'BTN_Imprimir
        '
        Me.BTN_Imprimir.BorderColor = System.Drawing.Color.Red
        Me.BTN_Imprimir.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.BTN_Imprimir.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BTN_Imprimir.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BTN_Imprimir.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BTN_Imprimir.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BTN_Imprimir.Dock = System.Windows.Forms.DockStyle.Right
        Me.BTN_Imprimir.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BTN_Imprimir.Font = New System.Drawing.Font("Ebrima", 20.25!, System.Drawing.FontStyle.Bold)
        Me.BTN_Imprimir.ForeColor = System.Drawing.Color.White
        Me.BTN_Imprimir.Image = CType(resources.GetObject("BTN_Imprimir.Image"), System.Drawing.Image)
        Me.BTN_Imprimir.ImageSize = New System.Drawing.Size(40, 40)
        Me.BTN_Imprimir.Location = New System.Drawing.Point(441, 0)
        Me.BTN_Imprimir.Name = "BTN_Imprimir"
        Me.BTN_Imprimir.Size = New System.Drawing.Size(446, 58)
        Me.BTN_Imprimir.TabIndex = 111
        Me.BTN_Imprimir.Text = "Imprimir"
        '
        'PrintDocument
        '
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.Controls.Add(Me.BTN_Imprimir)
        Me.Guna2Panel1.Controls.Add(Me.BTN_RegresarPrd)
        Me.Guna2Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Guna2Panel1.Location = New System.Drawing.Point(0, 521)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.Size = New System.Drawing.Size(887, 58)
        Me.Guna2Panel1.TabIndex = 122
        '
        'BTN_Config
        '
        Me.BTN_Config.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.BTN_Config.CheckedState.ImageSize = New System.Drawing.Size(64, 64)
        Me.BTN_Config.HoverState.ImageSize = New System.Drawing.Size(64, 64)
        Me.BTN_Config.Image = CType(resources.GetObject("BTN_Config.Image"), System.Drawing.Image)
        Me.BTN_Config.ImageOffset = New System.Drawing.Point(0, 0)
        Me.BTN_Config.ImageRotate = 0!
        Me.BTN_Config.ImageSize = New System.Drawing.Size(60, 60)
        Me.BTN_Config.Location = New System.Drawing.Point(829, 1)
        Me.BTN_Config.Name = "BTN_Config"
        Me.BTN_Config.PressedState.ImageSize = New System.Drawing.Size(64, 64)
        Me.BTN_Config.Size = New System.Drawing.Size(58, 54)
        Me.BTN_Config.TabIndex = 124
        '
        'P_Hablador
        '
        Me.AcceptButton = Me.BTN_Imprimir
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.CancelButton = Me.BTN_RegresarPrd
        Me.ClientSize = New System.Drawing.Size(887, 579)
        Me.Controls.Add(Me.BTN_Config)
        Me.Controls.Add(Me.Guna2Panel1)
        Me.Controls.Add(Me.DGV_BProd)
        Me.Controls.Add(Me.TXT_BuscarProd)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DGV_Hablador)
        Me.Controls.Add(Me.Guna2PictureBox2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Name = "P_Hablador"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Imprimir hablador"
        Me.MNU_CONTX.ResumeLayout(False)
        CType(Me.DGV_Hablador, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MNU_CONTX_IMP.ResumeLayout(False)
        CType(Me.Guna2PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGV_BProd, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Guna2Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Guna2BorderlessForm1 As Guna.UI2.WinForms.Guna2BorderlessForm
    Friend WithEvents MNU_CONTX As Guna.UI2.WinForms.Guna2ContextMenuStrip
    Friend WithEvents MNU_SELECCIONAR As ToolStripMenuItem
    Friend WithEvents DGV_Hablador As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents Guna2PictureBox2 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents DGV_BProd As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents TXT_BuscarProd As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents BTN_RegresarPrd As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents MNU_CONTX_IMP As Guna.UI2.WinForms.Guna2ContextMenuStrip
    Friend WithEvents MNU_ELIMINAR As ToolStripMenuItem
    Friend WithEvents ID As DataGridViewTextBoxColumn
    Friend WithEvents codigo As DataGridViewTextBoxColumn
    Friend WithEvents nombre As DataGridViewTextBoxColumn
    Friend WithEvents precio As DataGridViewTextBoxColumn
    Friend WithEvents cant As DataGridViewTextBoxColumn
    Friend WithEvents BTN_Imprimir As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents PrintDocument As Printing.PrintDocument
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents BTN_Config As Guna.UI2.WinForms.Guna2ImageButton
End Class
