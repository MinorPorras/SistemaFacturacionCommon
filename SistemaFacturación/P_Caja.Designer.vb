<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class P_Caja
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
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(P_Caja))
        Me.Guna2BorderlessForm1 = New Guna.UI2.WinForms.Guna2BorderlessForm(Me.components)
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.Guna2AnimateWindow1 = New Guna.UI2.WinForms.Guna2AnimateWindow(Me.components)
        Me.LBL_Hora = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.LBL_Fecha = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.TXT_BuscarCliente = New Guna.UI2.WinForms.Guna2TextBox()
        Me.MNU_CONTX = New Guna.UI2.WinForms.Guna2ContextMenuStrip()
        Me.MNU_MODIFICAR = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.MNU_ELIMINAR = New System.Windows.Forms.ToolStripMenuItem()
        Me.Guna2HtmlLabel3 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel2 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel1 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.PIC_Logo = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.Guna2HtmlLabel4 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.BTN_NProd = New Guna.UI2.WinForms.Guna2CircleButton()
        Me.LBL_Usu = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel6 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.DGV_Caja = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.ID_Prod = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.codigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Nombre_prod = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.precioVenta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cantidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Total = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Guna2Panel4 = New Guna.UI2.WinForms.Guna2Panel()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.TXT_Total = New Guna.UI2.WinForms.Guna2TextBox()
        Me.BTN_RegresarCaja = New Guna.UI2.WinForms.Guna2Button()
        Me.BTN_Reprint = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2Panel2 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2HtmlLabel7 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.BTN_TVenta = New Guna.UI2.WinForms.Guna2Button()
        Me.BTN_GuardarCuenta = New Guna.UI2.WinForms.Guna2Button()
        Me.BTN_CuentaCobrar = New Guna.UI2.WinForms.Guna2Button()
        Me.BTN_RegistrarIngreso = New Guna.UI2.WinForms.Guna2Button()
        Me.BTN_AperturaCaja = New Guna.UI2.WinForms.Guna2Button()
        Me.BTN_RegistrarSalida = New Guna.UI2.WinForms.Guna2Button()
        Me.BTN_CierreCaja = New Guna.UI2.WinForms.Guna2Button()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.PAN_AddProd = New System.Windows.Forms.Panel()
        Me.BTN_DelFactura = New Guna.UI2.WinForms.Guna2TileButton()
        Me.TXT_BuscarProducto = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.TableLayoutPanel4 = New System.Windows.Forms.TableLayoutPanel()
        Me.PAN_FavProd = New Guna.UI2.WinForms.Guna2Panel()
        Me.PAN_FavProdBTNContainer = New Guna.UI2.WinForms.Guna2Panel()
        Me.PAN_HeaderFavProd = New Guna.UI2.WinForms.Guna2Panel()
        Me.BTN_EditFavProd = New Guna.UI2.WinForms.Guna2TileButton()
        Me.lbl_tituloProdFav = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.FLW_FavProdBtn = New Syncfusion.Windows.Forms.Tools.FlowLayout(Me.components)
        Me.MNU_CONTX.SuspendLayout()
        CType(Me.PIC_Logo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGV_Caja, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Guna2Panel4.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.Guna2Panel2.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Guna2Panel1.SuspendLayout()
        Me.PAN_AddProd.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.TableLayoutPanel4.SuspendLayout()
        Me.PAN_FavProd.SuspendLayout()
        Me.PAN_HeaderFavProd.SuspendLayout()
        CType(Me.FLW_FavProdBtn, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Guna2BorderlessForm1
        '
        Me.Guna2BorderlessForm1.ContainerControl = Me
        Me.Guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6R
        Me.Guna2BorderlessForm1.TransparentWhileDrag = True
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'BackgroundWorker1
        '
        '
        'LBL_Hora
        '
        Me.LBL_Hora.BackColor = System.Drawing.Color.Transparent
        Me.LBL_Hora.Font = New System.Drawing.Font("Segoe UI Black", 15.75!, System.Drawing.FontStyle.Bold)
        Me.LBL_Hora.ForeColor = System.Drawing.SystemColors.Control
        Me.LBL_Hora.Location = New System.Drawing.Point(176, 48)
        Me.LBL_Hora.Name = "LBL_Hora"
        Me.LBL_Hora.Size = New System.Drawing.Size(62, 32)
        Me.LBL_Hora.TabIndex = 102
        Me.LBL_Hora.Text = "00:00"
        Me.LBL_Hora.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit
        '
        'LBL_Fecha
        '
        Me.LBL_Fecha.BackColor = System.Drawing.Color.Transparent
        Me.LBL_Fecha.Font = New System.Drawing.Font("Segoe UI Black", 15.75!, System.Drawing.FontStyle.Bold)
        Me.LBL_Fecha.ForeColor = System.Drawing.SystemColors.Control
        Me.LBL_Fecha.Location = New System.Drawing.Point(185, 10)
        Me.LBL_Fecha.Name = "LBL_Fecha"
        Me.LBL_Fecha.Size = New System.Drawing.Size(53, 32)
        Me.LBL_Fecha.TabIndex = 101
        Me.LBL_Fecha.Text = "1/1/1"
        Me.LBL_Fecha.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit
        '
        'TXT_BuscarCliente
        '
        Me.TXT_BuscarCliente.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TXT_BuscarCliente.BorderRadius = 20
        Me.TXT_BuscarCliente.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TXT_BuscarCliente.DefaultText = ""
        Me.TXT_BuscarCliente.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TXT_BuscarCliente.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TXT_BuscarCliente.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXT_BuscarCliente.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXT_BuscarCliente.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXT_BuscarCliente.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.TXT_BuscarCliente.ForeColor = System.Drawing.Color.Black
        Me.TXT_BuscarCliente.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXT_BuscarCliente.Location = New System.Drawing.Point(100, 6)
        Me.TXT_BuscarCliente.Name = "TXT_BuscarCliente"
        Me.TXT_BuscarCliente.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TXT_BuscarCliente.PlaceholderText = "Doble click para buscar"
        Me.TXT_BuscarCliente.SelectedText = ""
        Me.TXT_BuscarCliente.Size = New System.Drawing.Size(337, 42)
        Me.TXT_BuscarCliente.TabIndex = 95
        '
        'MNU_CONTX
        '
        Me.MNU_CONTX.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.MNU_CONTX.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MNU_CONTX.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MNU_MODIFICAR, Me.ToolStripSeparator1, Me.MNU_ELIMINAR})
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
        Me.MNU_CONTX.Size = New System.Drawing.Size(136, 62)
        '
        'MNU_MODIFICAR
        '
        Me.MNU_MODIFICAR.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MNU_MODIFICAR.ForeColor = System.Drawing.Color.White
        Me.MNU_MODIFICAR.Image = Global.SistemaFacturaciónCommon.My.Resources.Resources.ICO_Edit
        Me.MNU_MODIFICAR.Name = "MNU_MODIFICAR"
        Me.MNU_MODIFICAR.Size = New System.Drawing.Size(135, 26)
        Me.MNU_MODIFICAR.Text = "Modificar"
        Me.MNU_MODIFICAR.Visible = False
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(132, 6)
        '
        'MNU_ELIMINAR
        '
        Me.MNU_ELIMINAR.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MNU_ELIMINAR.ForeColor = System.Drawing.Color.White
        Me.MNU_ELIMINAR.Image = CType(resources.GetObject("MNU_ELIMINAR.Image"), System.Drawing.Image)
        Me.MNU_ELIMINAR.Name = "MNU_ELIMINAR"
        Me.MNU_ELIMINAR.Size = New System.Drawing.Size(135, 26)
        Me.MNU_ELIMINAR.Text = "Eliminar"
        Me.MNU_ELIMINAR.Visible = False
        '
        'Guna2HtmlLabel3
        '
        Me.Guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel3.Font = New System.Drawing.Font("Segoe UI Black", 15.75!, System.Drawing.FontStyle.Bold)
        Me.Guna2HtmlLabel3.ForeColor = System.Drawing.SystemColors.Control
        Me.Guna2HtmlLabel3.Location = New System.Drawing.Point(12, 11)
        Me.Guna2HtmlLabel3.Name = "Guna2HtmlLabel3"
        Me.Guna2HtmlLabel3.Size = New System.Drawing.Size(81, 32)
        Me.Guna2HtmlLabel3.TabIndex = 94
        Me.Guna2HtmlLabel3.Text = "Cliente:"
        Me.Guna2HtmlLabel3.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit
        '
        'Guna2HtmlLabel2
        '
        Me.Guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel2.Font = New System.Drawing.Font("Segoe UI Black", 15.75!, System.Drawing.FontStyle.Bold)
        Me.Guna2HtmlLabel2.ForeColor = System.Drawing.SystemColors.Control
        Me.Guna2HtmlLabel2.Location = New System.Drawing.Point(109, 48)
        Me.Guna2HtmlLabel2.Name = "Guna2HtmlLabel2"
        Me.Guna2HtmlLabel2.Size = New System.Drawing.Size(61, 32)
        Me.Guna2HtmlLabel2.TabIndex = 2
        Me.Guna2HtmlLabel2.Text = "Hora:"
        Me.Guna2HtmlLabel2.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit
        '
        'Guna2HtmlLabel1
        '
        Me.Guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel1.Font = New System.Drawing.Font("Segoe UI Black", 15.75!, System.Drawing.FontStyle.Bold)
        Me.Guna2HtmlLabel1.ForeColor = System.Drawing.SystemColors.Control
        Me.Guna2HtmlLabel1.Location = New System.Drawing.Point(111, 10)
        Me.Guna2HtmlLabel1.Name = "Guna2HtmlLabel1"
        Me.Guna2HtmlLabel1.Size = New System.Drawing.Size(68, 32)
        Me.Guna2HtmlLabel1.TabIndex = 1
        Me.Guna2HtmlLabel1.Text = "Fecha:"
        Me.Guna2HtmlLabel1.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit
        '
        'PIC_Logo
        '
        Me.PIC_Logo.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PIC_Logo.BackColor = System.Drawing.Color.Transparent
        Me.PIC_Logo.BorderRadius = 15
        Me.PIC_Logo.ImageRotate = 0!
        Me.PIC_Logo.Location = New System.Drawing.Point(5, 6)
        Me.PIC_Logo.Name = "PIC_Logo"
        Me.PIC_Logo.Size = New System.Drawing.Size(100, 90)
        Me.PIC_Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PIC_Logo.TabIndex = 0
        Me.PIC_Logo.TabStop = False
        '
        'Guna2HtmlLabel4
        '
        Me.Guna2HtmlLabel4.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel4.Font = New System.Drawing.Font("Segoe UI Black", 15.75!, System.Drawing.FontStyle.Bold)
        Me.Guna2HtmlLabel4.ForeColor = System.Drawing.SystemColors.Control
        Me.Guna2HtmlLabel4.Location = New System.Drawing.Point(22, 20)
        Me.Guna2HtmlLabel4.Name = "Guna2HtmlLabel4"
        Me.Guna2HtmlLabel4.Size = New System.Drawing.Size(104, 32)
        Me.Guna2HtmlLabel4.TabIndex = 96
        Me.Guna2HtmlLabel4.Text = "Producto:"
        Me.Guna2HtmlLabel4.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit
        '
        'BTN_NProd
        '
        Me.BTN_NProd.BackColor = System.Drawing.Color.Transparent
        Me.BTN_NProd.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BTN_NProd.FillColor = System.Drawing.Color.Transparent
        Me.BTN_NProd.Font = New System.Drawing.Font("Snap ITC", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_NProd.ForeColor = System.Drawing.Color.White
        Me.BTN_NProd.Image = Global.SistemaFacturaciónCommon.My.Resources.Resources.ICO_MasCol
        Me.BTN_NProd.ImageSize = New System.Drawing.Size(45, 45)
        Me.BTN_NProd.Location = New System.Drawing.Point(446, 15)
        Me.BTN_NProd.Name = "BTN_NProd"
        Me.BTN_NProd.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.BTN_NProd.Size = New System.Drawing.Size(44, 45)
        Me.BTN_NProd.TabIndex = 110
        '
        'LBL_Usu
        '
        Me.LBL_Usu.BackColor = System.Drawing.Color.Transparent
        Me.LBL_Usu.Font = New System.Drawing.Font("Segoe UI Black", 15.75!, System.Drawing.FontStyle.Bold)
        Me.LBL_Usu.ForeColor = System.Drawing.SystemColors.Control
        Me.LBL_Usu.Location = New System.Drawing.Point(478, 10)
        Me.LBL_Usu.Name = "LBL_Usu"
        Me.LBL_Usu.Size = New System.Drawing.Size(82, 32)
        Me.LBL_Usu.TabIndex = 113
        Me.LBL_Usu.Text = "Usuario"
        Me.LBL_Usu.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit
        '
        'Guna2HtmlLabel6
        '
        Me.Guna2HtmlLabel6.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel6.Font = New System.Drawing.Font("Segoe UI Black", 15.75!, System.Drawing.FontStyle.Bold)
        Me.Guna2HtmlLabel6.ForeColor = System.Drawing.SystemColors.Control
        Me.Guna2HtmlLabel6.Location = New System.Drawing.Point(383, 10)
        Me.Guna2HtmlLabel6.Name = "Guna2HtmlLabel6"
        Me.Guna2HtmlLabel6.Size = New System.Drawing.Size(89, 32)
        Me.Guna2HtmlLabel6.TabIndex = 114
        Me.Guna2HtmlLabel6.Text = "Usuario:"
        Me.Guna2HtmlLabel6.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit
        '
        'DGV_Caja
        '
        Me.DGV_Caja.AllowUserToDeleteRows = False
        Me.DGV_Caja.AllowUserToOrderColumns = True
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.White
        Me.DGV_Caja.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle4
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGV_Caja.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.DGV_Caja.ColumnHeadersHeight = 15
        Me.DGV_Caja.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.DGV_Caja.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ID_Prod, Me.codigo, Me.Nombre_prod, Me.precioVenta, Me.cantidad, Me.Total})
        Me.DGV_Caja.ContextMenuStrip = Me.MNU_CONTX
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DGV_Caja.DefaultCellStyle = DataGridViewCellStyle6
        Me.DGV_Caja.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DGV_Caja.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter
        Me.DGV_Caja.GridColor = System.Drawing.Color.White
        Me.DGV_Caja.Location = New System.Drawing.Point(8, 8)
        Me.DGV_Caja.Margin = New System.Windows.Forms.Padding(8)
        Me.DGV_Caja.Name = "DGV_Caja"
        Me.DGV_Caja.RowHeadersVisible = False
        Me.DGV_Caja.Size = New System.Drawing.Size(642, 367)
        Me.DGV_Caja.TabIndex = 115
        Me.DGV_Caja.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.DGV_Caja.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.DGV_Caja.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.DGV_Caja.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.DGV_Caja.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.DGV_Caja.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.DGV_Caja.ThemeStyle.GridColor = System.Drawing.Color.White
        Me.DGV_Caja.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DGV_Caja.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.DGV_Caja.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DGV_Caja.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.DGV_Caja.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.DGV_Caja.ThemeStyle.HeaderStyle.Height = 15
        Me.DGV_Caja.ThemeStyle.ReadOnly = False
        Me.DGV_Caja.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.DGV_Caja.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.DGV_Caja.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DGV_Caja.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.DGV_Caja.ThemeStyle.RowsStyle.Height = 22
        Me.DGV_Caja.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DGV_Caja.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        '
        'ID_Prod
        '
        Me.ID_Prod.HeaderText = "ID"
        Me.ID_Prod.Name = "ID_Prod"
        Me.ID_Prod.ReadOnly = True
        Me.ID_Prod.Visible = False
        '
        'codigo
        '
        Me.codigo.HeaderText = "Cod"
        Me.codigo.Name = "codigo"
        Me.codigo.ReadOnly = True
        '
        'Nombre_prod
        '
        Me.Nombre_prod.HeaderText = "Producto"
        Me.Nombre_prod.Name = "Nombre_prod"
        Me.Nombre_prod.ReadOnly = True
        '
        'precioVenta
        '
        Me.precioVenta.HeaderText = "Precio"
        Me.precioVenta.Name = "precioVenta"
        Me.precioVenta.ReadOnly = True
        '
        'cantidad
        '
        Me.cantidad.HeaderText = "Cant."
        Me.cantidad.Name = "cantidad"
        '
        'Total
        '
        Me.Total.HeaderText = "Total"
        Me.Total.Name = "Total"
        Me.Total.ReadOnly = True
        '
        'Guna2Panel4
        '
        Me.Guna2Panel4.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom
        Me.Guna2Panel4.Controls.Add(Me.Guna2HtmlLabel3)
        Me.Guna2Panel4.Controls.Add(Me.TXT_BuscarCliente)
        Me.Guna2Panel4.Location = New System.Drawing.Point(3, 3)
        Me.Guna2Panel4.Name = "Guna2Panel4"
        Me.Guna2Panel4.Size = New System.Drawing.Size(440, 53)
        Me.Guna2Panel4.TabIndex = 119
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 3
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel1.Controls.Add(Me.TXT_Total, 2, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.BTN_RegresarCaja, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.BTN_Reprint, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Guna2Panel2, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Guna2Panel4, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.BTN_AperturaCaja, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.BTN_CierreCaja, 2, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.BTN_GuardarCuenta, 2, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.BTN_TVenta, 2, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.BTN_CuentaCobrar, 1, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.BTN_RegistrarSalida, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.BTN_RegistrarIngreso, 1, 1)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 507)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 4
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 24.48133!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.3112!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.10373!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.10373!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(1339, 242)
        Me.TableLayoutPanel1.TabIndex = 120
        '
        'TXT_Total
        '
        Me.TXT_Total.BorderRadius = 20
        Me.TXT_Total.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TXT_Total.DefaultText = "₡ 0"
        Me.TXT_Total.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TXT_Total.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TXT_Total.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXT_Total.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXT_Total.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TXT_Total.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXT_Total.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_Total.ForeColor = System.Drawing.Color.Black
        Me.TXT_Total.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXT_Total.Location = New System.Drawing.Point(898, 6)
        Me.TXT_Total.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.TXT_Total.Name = "TXT_Total"
        Me.TXT_Total.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TXT_Total.PlaceholderText = ""
        Me.TXT_Total.SelectedText = ""
        Me.TXT_Total.Size = New System.Drawing.Size(435, 47)
        Me.TXT_Total.TabIndex = 124
        '
        'BTN_RegresarCaja
        '
        Me.BTN_RegresarCaja.BorderRadius = 10
        Me.BTN_RegresarCaja.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BTN_RegresarCaja.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BTN_RegresarCaja.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BTN_RegresarCaja.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BTN_RegresarCaja.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BTN_RegresarCaja.FillColor = System.Drawing.Color.IndianRed
        Me.BTN_RegresarCaja.Font = New System.Drawing.Font("Ebrima", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_RegresarCaja.ForeColor = System.Drawing.Color.White
        Me.BTN_RegresarCaja.Image = Global.SistemaFacturaciónCommon.My.Resources.Resources.ICO_Back
        Me.BTN_RegresarCaja.ImageSize = New System.Drawing.Size(40, 40)
        Me.BTN_RegresarCaja.Location = New System.Drawing.Point(3, 183)
        Me.BTN_RegresarCaja.Name = "BTN_RegresarCaja"
        Me.BTN_RegresarCaja.Size = New System.Drawing.Size(440, 56)
        Me.BTN_RegresarCaja.TabIndex = 113
        Me.BTN_RegresarCaja.Text = "[F7] Regresar"
        '
        'BTN_Reprint
        '
        Me.BTN_Reprint.BorderRadius = 10
        Me.BTN_Reprint.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BTN_Reprint.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BTN_Reprint.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BTN_Reprint.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BTN_Reprint.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BTN_Reprint.FillColor = System.Drawing.Color.Gray
        Me.BTN_Reprint.Font = New System.Drawing.Font("Ebrima", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_Reprint.ForeColor = System.Drawing.Color.White
        Me.BTN_Reprint.Image = Global.SistemaFacturaciónCommon.My.Resources.Resources.ICO_Print
        Me.BTN_Reprint.ImageSize = New System.Drawing.Size(40, 40)
        Me.BTN_Reprint.Location = New System.Drawing.Point(3, 62)
        Me.BTN_Reprint.Name = "BTN_Reprint"
        Me.BTN_Reprint.Size = New System.Drawing.Size(440, 55)
        Me.BTN_Reprint.TabIndex = 111
        Me.BTN_Reprint.Text = "[F1] Reimprimir factura"
        '
        'Guna2Panel2
        '
        Me.Guna2Panel2.Controls.Add(Me.Guna2HtmlLabel7)
        Me.Guna2Panel2.Location = New System.Drawing.Point(449, 3)
        Me.Guna2Panel2.Name = "Guna2Panel2"
        Me.Guna2Panel2.Size = New System.Drawing.Size(440, 53)
        Me.Guna2Panel2.TabIndex = 116
        '
        'Guna2HtmlLabel7
        '
        Me.Guna2HtmlLabel7.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Guna2HtmlLabel7.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel7.Font = New System.Drawing.Font("Segoe UI Black", 15.75!, System.Drawing.FontStyle.Bold)
        Me.Guna2HtmlLabel7.ForeColor = System.Drawing.SystemColors.Control
        Me.Guna2HtmlLabel7.Location = New System.Drawing.Point(357, 11)
        Me.Guna2HtmlLabel7.Name = "Guna2HtmlLabel7"
        Me.Guna2HtmlLabel7.Size = New System.Drawing.Size(63, 32)
        Me.Guna2HtmlLabel7.TabIndex = 123
        Me.Guna2HtmlLabel7.Text = "Total:"
        Me.Guna2HtmlLabel7.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit
        '
        'BTN_TVenta
        '
        Me.BTN_TVenta.BorderRadius = 10
        Me.BTN_TVenta.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BTN_TVenta.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BTN_TVenta.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BTN_TVenta.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BTN_TVenta.FillColor = System.Drawing.Color.MediumSeaGreen
        Me.BTN_TVenta.Font = New System.Drawing.Font("Ebrima", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_TVenta.ForeColor = System.Drawing.Color.White
        Me.BTN_TVenta.Image = Global.SistemaFacturaciónCommon.My.Resources.Resources.ICO_EndSale
        Me.BTN_TVenta.ImageSize = New System.Drawing.Size(40, 40)
        Me.BTN_TVenta.Location = New System.Drawing.Point(895, 62)
        Me.BTN_TVenta.Name = "BTN_TVenta"
        Me.BTN_TVenta.Size = New System.Drawing.Size(441, 55)
        Me.BTN_TVenta.TabIndex = 112
        Me.BTN_TVenta.Text = "[F3] Terminar venta"
        '
        'BTN_GuardarCuenta
        '
        Me.BTN_GuardarCuenta.BorderRadius = 10
        Me.BTN_GuardarCuenta.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BTN_GuardarCuenta.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BTN_GuardarCuenta.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BTN_GuardarCuenta.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BTN_GuardarCuenta.FillColor = System.Drawing.Color.LightSeaGreen
        Me.BTN_GuardarCuenta.Font = New System.Drawing.Font("Ebrima", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_GuardarCuenta.ForeColor = System.Drawing.Color.White
        Me.BTN_GuardarCuenta.Image = Global.SistemaFacturaciónCommon.My.Resources.Resources.ICO_Export
        Me.BTN_GuardarCuenta.ImageSize = New System.Drawing.Size(40, 40)
        Me.BTN_GuardarCuenta.Location = New System.Drawing.Point(895, 183)
        Me.BTN_GuardarCuenta.Name = "BTN_GuardarCuenta"
        Me.BTN_GuardarCuenta.Size = New System.Drawing.Size(441, 55)
        Me.BTN_GuardarCuenta.TabIndex = 113
        Me.BTN_GuardarCuenta.Text = "[F9] Guardar cuenta"
        '
        'BTN_CuentaCobrar
        '
        Me.BTN_CuentaCobrar.BorderRadius = 10
        Me.BTN_CuentaCobrar.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BTN_CuentaCobrar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BTN_CuentaCobrar.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BTN_CuentaCobrar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BTN_CuentaCobrar.FillColor = System.Drawing.Color.MediumPurple
        Me.BTN_CuentaCobrar.Font = New System.Drawing.Font("Ebrima", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_CuentaCobrar.ForeColor = System.Drawing.Color.White
        Me.BTN_CuentaCobrar.Image = Global.SistemaFacturaciónCommon.My.Resources.Resources.ICO_BagSimple
        Me.BTN_CuentaCobrar.ImageSize = New System.Drawing.Size(40, 40)
        Me.BTN_CuentaCobrar.Location = New System.Drawing.Point(449, 183)
        Me.BTN_CuentaCobrar.Name = "BTN_CuentaCobrar"
        Me.BTN_CuentaCobrar.Size = New System.Drawing.Size(440, 55)
        Me.BTN_CuentaCobrar.TabIndex = 113
        Me.BTN_CuentaCobrar.Text = "[F8] Cuentas por cobrar"
        '
        'BTN_RegistrarIngreso
        '
        Me.BTN_RegistrarIngreso.BorderRadius = 10
        Me.BTN_RegistrarIngreso.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BTN_RegistrarIngreso.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BTN_RegistrarIngreso.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BTN_RegistrarIngreso.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BTN_RegistrarIngreso.FillColor = System.Drawing.Color.DarkCyan
        Me.BTN_RegistrarIngreso.Font = New System.Drawing.Font("Ebrima", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_RegistrarIngreso.ForeColor = System.Drawing.Color.White
        Me.BTN_RegistrarIngreso.Image = Global.SistemaFacturaciónCommon.My.Resources.Resources.ICO_Mas
        Me.BTN_RegistrarIngreso.ImageSize = New System.Drawing.Size(40, 40)
        Me.BTN_RegistrarIngreso.Location = New System.Drawing.Point(449, 62)
        Me.BTN_RegistrarIngreso.Name = "BTN_RegistrarIngreso"
        Me.BTN_RegistrarIngreso.Size = New System.Drawing.Size(440, 54)
        Me.BTN_RegistrarIngreso.TabIndex = 113
        Me.BTN_RegistrarIngreso.Text = "[F2] Ingreso de efectivo"
        '
        'BTN_AperturaCaja
        '
        Me.BTN_AperturaCaja.BorderRadius = 10
        Me.BTN_AperturaCaja.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BTN_AperturaCaja.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BTN_AperturaCaja.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BTN_AperturaCaja.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BTN_AperturaCaja.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BTN_AperturaCaja.FillColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BTN_AperturaCaja.Font = New System.Drawing.Font("Ebrima", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_AperturaCaja.ForeColor = System.Drawing.Color.White
        Me.BTN_AperturaCaja.Image = Global.SistemaFacturaciónCommon.My.Resources.Resources.ICO_Unlock
        Me.BTN_AperturaCaja.ImageSize = New System.Drawing.Size(40, 40)
        Me.BTN_AperturaCaja.Location = New System.Drawing.Point(3, 123)
        Me.BTN_AperturaCaja.Name = "BTN_AperturaCaja"
        Me.BTN_AperturaCaja.Size = New System.Drawing.Size(440, 54)
        Me.BTN_AperturaCaja.TabIndex = 125
        Me.BTN_AperturaCaja.Text = "[F4] Apertura de caja"
        '
        'BTN_RegistrarSalida
        '
        Me.BTN_RegistrarSalida.BorderRadius = 10
        Me.BTN_RegistrarSalida.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BTN_RegistrarSalida.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BTN_RegistrarSalida.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BTN_RegistrarSalida.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BTN_RegistrarSalida.FillColor = System.Drawing.Color.Peru
        Me.BTN_RegistrarSalida.Font = New System.Drawing.Font("Ebrima", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_RegistrarSalida.ForeColor = System.Drawing.Color.White
        Me.BTN_RegistrarSalida.Image = Global.SistemaFacturaciónCommon.My.Resources.Resources.ICO_Menos
        Me.BTN_RegistrarSalida.ImageSize = New System.Drawing.Size(40, 40)
        Me.BTN_RegistrarSalida.Location = New System.Drawing.Point(449, 123)
        Me.BTN_RegistrarSalida.Name = "BTN_RegistrarSalida"
        Me.BTN_RegistrarSalida.Size = New System.Drawing.Size(440, 54)
        Me.BTN_RegistrarSalida.TabIndex = 126
        Me.BTN_RegistrarSalida.Text = "[F5] Salida de efectivo"
        '
        'BTN_CierreCaja
        '
        Me.BTN_CierreCaja.BorderRadius = 10
        Me.BTN_CierreCaja.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BTN_CierreCaja.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BTN_CierreCaja.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BTN_CierreCaja.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BTN_CierreCaja.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BTN_CierreCaja.FillColor = System.Drawing.Color.MediumOrchid
        Me.BTN_CierreCaja.Font = New System.Drawing.Font("Ebrima", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_CierreCaja.ForeColor = System.Drawing.Color.White
        Me.BTN_CierreCaja.Image = Global.SistemaFacturaciónCommon.My.Resources.Resources.ICO_Lock
        Me.BTN_CierreCaja.ImageSize = New System.Drawing.Size(40, 40)
        Me.BTN_CierreCaja.Location = New System.Drawing.Point(895, 123)
        Me.BTN_CierreCaja.Name = "BTN_CierreCaja"
        Me.BTN_CierreCaja.Size = New System.Drawing.Size(441, 54)
        Me.BTN_CierreCaja.TabIndex = 127
        Me.BTN_CierreCaja.Text = "[F6] Cierre de caja"
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 2
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.06647!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.93353!))
        Me.TableLayoutPanel2.Controls.Add(Me.Panel1, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.Guna2Panel1, 1, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.Panel3, 1, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.PAN_FavProd, 0, 1)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 2
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 21.49712!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 78.50288!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(1339, 507)
        Me.TableLayoutPanel2.TabIndex = 121
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.PIC_Logo)
        Me.Panel1.Controls.Add(Me.LBL_Hora)
        Me.Panel1.Controls.Add(Me.LBL_Usu)
        Me.Panel1.Controls.Add(Me.LBL_Fecha)
        Me.Panel1.Controls.Add(Me.Guna2HtmlLabel6)
        Me.Panel1.Controls.Add(Me.Guna2HtmlLabel1)
        Me.Panel1.Controls.Add(Me.Guna2HtmlLabel2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(3, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(651, 102)
        Me.Panel1.TabIndex = 124
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.Controls.Add(Me.PAN_AddProd)
        Me.Guna2Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Guna2Panel1.Location = New System.Drawing.Point(660, 3)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.Size = New System.Drawing.Size(676, 102)
        Me.Guna2Panel1.TabIndex = 94
        '
        'PAN_AddProd
        '
        Me.PAN_AddProd.Controls.Add(Me.BTN_DelFactura)
        Me.PAN_AddProd.Controls.Add(Me.BTN_NProd)
        Me.PAN_AddProd.Controls.Add(Me.TXT_BuscarProducto)
        Me.PAN_AddProd.Controls.Add(Me.Guna2HtmlLabel4)
        Me.PAN_AddProd.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PAN_AddProd.Location = New System.Drawing.Point(0, 0)
        Me.PAN_AddProd.Name = "PAN_AddProd"
        Me.PAN_AddProd.Size = New System.Drawing.Size(676, 102)
        Me.PAN_AddProd.TabIndex = 101
        '
        'BTN_DelFactura
        '
        Me.BTN_DelFactura.Animated = True
        Me.BTN_DelFactura.BorderRadius = 10
        Me.BTN_DelFactura.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BTN_DelFactura.CustomBorderColor = System.Drawing.Color.Transparent
        Me.BTN_DelFactura.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BTN_DelFactura.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BTN_DelFactura.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BTN_DelFactura.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BTN_DelFactura.FillColor = System.Drawing.Color.Transparent
        Me.BTN_DelFactura.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_DelFactura.ForeColor = System.Drawing.Color.White
        Me.BTN_DelFactura.HoverState.FillColor = System.Drawing.Color.IndianRed
        Me.BTN_DelFactura.Image = Global.SistemaFacturaciónCommon.My.Resources.Resources.ICO_Clear
        Me.BTN_DelFactura.ImageSize = New System.Drawing.Size(60, 60)
        Me.BTN_DelFactura.Location = New System.Drawing.Point(596, 20)
        Me.BTN_DelFactura.Name = "BTN_DelFactura"
        Me.BTN_DelFactura.Size = New System.Drawing.Size(67, 67)
        Me.BTN_DelFactura.TabIndex = 113
        '
        'TXT_BuscarProducto
        '
        Me.TXT_BuscarProducto.BorderRadius = 20
        Me.TXT_BuscarProducto.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TXT_BuscarProducto.DefaultText = ""
        Me.TXT_BuscarProducto.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TXT_BuscarProducto.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TXT_BuscarProducto.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXT_BuscarProducto.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXT_BuscarProducto.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXT_BuscarProducto.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.TXT_BuscarProducto.ForeColor = System.Drawing.Color.Black
        Me.TXT_BuscarProducto.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXT_BuscarProducto.Location = New System.Drawing.Point(132, 13)
        Me.TXT_BuscarProducto.Name = "TXT_BuscarProducto"
        Me.TXT_BuscarProducto.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TXT_BuscarProducto.PlaceholderText = "Doble click para buscar"
        Me.TXT_BuscarProducto.SelectedText = ""
        Me.TXT_BuscarProducto.Size = New System.Drawing.Size(308, 47)
        Me.TXT_BuscarProducto.TabIndex = 97
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.TableLayoutPanel4)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(665, 116)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(8)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Padding = New System.Windows.Forms.Padding(0, 0, 8, 0)
        Me.Panel3.Size = New System.Drawing.Size(666, 383)
        Me.Panel3.TabIndex = 125
        '
        'TableLayoutPanel4
        '
        Me.TableLayoutPanel4.ColumnCount = 1
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel4.Controls.Add(Me.DGV_Caja, 0, 0)
        Me.TableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel4.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel4.Name = "TableLayoutPanel4"
        Me.TableLayoutPanel4.RowCount = 1
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80.45686!))
        Me.TableLayoutPanel4.Size = New System.Drawing.Size(658, 383)
        Me.TableLayoutPanel4.TabIndex = 116
        '
        'PAN_FavProd
        '
        Me.PAN_FavProd.Controls.Add(Me.PAN_FavProdBTNContainer)
        Me.PAN_FavProd.Controls.Add(Me.PAN_HeaderFavProd)
        Me.PAN_FavProd.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PAN_FavProd.Location = New System.Drawing.Point(3, 111)
        Me.PAN_FavProd.Name = "PAN_FavProd"
        Me.PAN_FavProd.Size = New System.Drawing.Size(651, 393)
        Me.PAN_FavProd.TabIndex = 126
        '
        'PAN_FavProdBTNContainer
        '
        Me.PAN_FavProdBTNContainer.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PAN_FavProdBTNContainer.AutoScroll = True
        Me.PAN_FavProdBTNContainer.BackColor = System.Drawing.Color.Transparent
        Me.PAN_FavProdBTNContainer.Location = New System.Drawing.Point(12, 82)
        Me.PAN_FavProdBTNContainer.Name = "PAN_FavProdBTNContainer"
        Me.PAN_FavProdBTNContainer.Padding = New System.Windows.Forms.Padding(10)
        Me.PAN_FavProdBTNContainer.Size = New System.Drawing.Size(623, 298)
        Me.PAN_FavProdBTNContainer.TabIndex = 1
        Me.PAN_FavProdBTNContainer.UseTransparentBackground = True
        '
        'PAN_HeaderFavProd
        '
        Me.PAN_HeaderFavProd.Controls.Add(Me.BTN_EditFavProd)
        Me.PAN_HeaderFavProd.Controls.Add(Me.lbl_tituloProdFav)
        Me.PAN_HeaderFavProd.Dock = System.Windows.Forms.DockStyle.Top
        Me.PAN_HeaderFavProd.Location = New System.Drawing.Point(0, 0)
        Me.PAN_HeaderFavProd.Name = "PAN_HeaderFavProd"
        Me.PAN_HeaderFavProd.Size = New System.Drawing.Size(651, 67)
        Me.PAN_HeaderFavProd.TabIndex = 0
        '
        'BTN_EditFavProd
        '
        Me.BTN_EditFavProd.Animated = True
        Me.BTN_EditFavProd.BorderRadius = 10
        Me.BTN_EditFavProd.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BTN_EditFavProd.CustomBorderColor = System.Drawing.Color.Transparent
        Me.BTN_EditFavProd.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BTN_EditFavProd.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BTN_EditFavProd.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BTN_EditFavProd.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BTN_EditFavProd.Dock = System.Windows.Forms.DockStyle.Right
        Me.BTN_EditFavProd.FillColor = System.Drawing.Color.Transparent
        Me.BTN_EditFavProd.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_EditFavProd.ForeColor = System.Drawing.Color.White
        Me.BTN_EditFavProd.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BTN_EditFavProd.Image = Global.SistemaFacturaciónCommon.My.Resources.Resources.ICO_Favoritos
        Me.BTN_EditFavProd.ImageSize = New System.Drawing.Size(60, 60)
        Me.BTN_EditFavProd.Location = New System.Drawing.Point(584, 0)
        Me.BTN_EditFavProd.Name = "BTN_EditFavProd"
        Me.BTN_EditFavProd.Size = New System.Drawing.Size(67, 67)
        Me.BTN_EditFavProd.TabIndex = 112
        '
        'lbl_tituloProdFav
        '
        Me.lbl_tituloProdFav.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_tituloProdFav.BackColor = System.Drawing.Color.Transparent
        Me.lbl_tituloProdFav.Font = New System.Drawing.Font("Segoe UI Black", 15.75!, System.Drawing.FontStyle.Bold)
        Me.lbl_tituloProdFav.ForeColor = System.Drawing.SystemColors.Control
        Me.lbl_tituloProdFav.Location = New System.Drawing.Point(231, 13)
        Me.lbl_tituloProdFav.Name = "lbl_tituloProdFav"
        Me.lbl_tituloProdFav.Size = New System.Drawing.Size(206, 32)
        Me.lbl_tituloProdFav.TabIndex = 111
        Me.lbl_tituloProdFav.Text = "Productos favoritos"
        Me.lbl_tituloProdFav.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit
        '
        'FLW_FavProdBtn
        '
        Me.FLW_FavProdBtn.ContainerControl = Me.PAN_FavProdBTNContainer
        '
        'P_Caja
        '
        Me.AcceptButton = Me.BTN_NProd
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1339, 749)
        Me.Controls.Add(Me.TableLayoutPanel2)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Name = "P_Caja"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Caja"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MNU_CONTX.ResumeLayout(False)
        CType(Me.PIC_Logo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGV_Caja, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Guna2Panel4.ResumeLayout(False)
        Me.Guna2Panel4.PerformLayout()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.Guna2Panel2.ResumeLayout(False)
        Me.Guna2Panel2.PerformLayout()
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Guna2Panel1.ResumeLayout(False)
        Me.PAN_AddProd.ResumeLayout(False)
        Me.PAN_AddProd.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.TableLayoutPanel4.ResumeLayout(False)
        Me.PAN_FavProd.ResumeLayout(False)
        Me.PAN_HeaderFavProd.ResumeLayout(False)
        Me.PAN_HeaderFavProd.PerformLayout()
        CType(Me.FLW_FavProdBtn, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Guna2BorderlessForm1 As Guna.UI2.WinForms.Guna2BorderlessForm
    Friend WithEvents Timer1 As Timer
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents Guna2AnimateWindow1 As Guna.UI2.WinForms.Guna2AnimateWindow
    Friend WithEvents LBL_Hora As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents LBL_Fecha As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel4 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents TXT_BuscarCliente As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2HtmlLabel3 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel2 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel1 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents PIC_Logo As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents BTN_NProd As Guna.UI2.WinForms.Guna2CircleButton
    Friend WithEvents MNU_CONTX As Guna.UI2.WinForms.Guna2ContextMenuStrip
    Friend WithEvents MNU_MODIFICAR As ToolStripMenuItem
    Friend WithEvents MNU_ELIMINAR As ToolStripMenuItem
    Friend WithEvents LBL_Usu As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel6 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents DGV_Caja As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents Guna2Panel4 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents TXT_BuscarProducto As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PAN_AddProd As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents TXT_Total As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2HtmlLabel7 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents ID_Prod As DataGridViewTextBoxColumn
    Friend WithEvents codigo As DataGridViewTextBoxColumn
    Friend WithEvents Nombre_prod As DataGridViewTextBoxColumn
    Friend WithEvents precioVenta As DataGridViewTextBoxColumn
    Friend WithEvents cantidad As DataGridViewTextBoxColumn
    Friend WithEvents Total As DataGridViewTextBoxColumn
    Friend WithEvents TableLayoutPanel4 As TableLayoutPanel
    Friend WithEvents Guna2Panel2 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents PAN_FavProd As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents PAN_HeaderFavProd As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents lbl_tituloProdFav As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents BTN_EditFavProd As Guna.UI2.WinForms.Guna2TileButton
    Friend WithEvents PAN_FavProdBTNContainer As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents FLW_FavProdBtn As Syncfusion.Windows.Forms.Tools.FlowLayout
    Friend WithEvents BTN_Reprint As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BTN_TVenta As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BTN_CuentaCobrar As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BTN_RegresarCaja As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BTN_RegistrarIngreso As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BTN_GuardarCuenta As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents BTN_DelFactura As Guna.UI2.WinForms.Guna2TileButton
    Friend WithEvents BTN_CierreCaja As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BTN_RegistrarSalida As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BTN_AperturaCaja As Guna.UI2.WinForms.Guna2Button
End Class
