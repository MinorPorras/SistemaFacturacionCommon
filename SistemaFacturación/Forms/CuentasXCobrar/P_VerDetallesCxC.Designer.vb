Namespace SistemaFacturacion.Forms.CuentasXCobrar

    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Class P_VerDetallesCxC
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(P_VerDetallesCxC))
            Me.TXT_Total = New Guna.UI2.WinForms.Guna2TextBox()
            Me.Guna2HtmlLabel1 = New Guna.UI2.WinForms.Guna2HtmlLabel()
            Me.lblCliente = New Guna.UI2.WinForms.Guna2HtmlLabel()
            Me.Guna2HtmlLabel2 = New Guna.UI2.WinForms.Guna2HtmlLabel()
            Me.lblFechaCreacion = New Guna.UI2.WinForms.Guna2HtmlLabel()
            Me.Guna2HtmlLabel3 = New Guna.UI2.WinForms.Guna2HtmlLabel()
            Me.Guna2HtmlLabel4 = New Guna.UI2.WinForms.Guna2HtmlLabel()
            Me.DGV_ListProds = New Guna.UI2.WinForms.Guna2DataGridView()
            Me.Guna2HtmlLabel5 = New Guna.UI2.WinForms.Guna2HtmlLabel()
            Me.Guna2HtmlLabel6 = New Guna.UI2.WinForms.Guna2HtmlLabel()
            Me.lblCantProds = New Guna.UI2.WinForms.Guna2HtmlLabel()
            Me.lblSaldoRestante = New Guna.UI2.WinForms.Guna2HtmlLabel()
            Me.Guna2HtmlLabel8 = New Guna.UI2.WinForms.Guna2HtmlLabel()
            Me.Guna2HtmlLabel9 = New Guna.UI2.WinForms.Guna2HtmlLabel()
            Me.DGV_ListaAbonos = New Guna.UI2.WinForms.Guna2DataGridView()
            Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
            Me.BTN_ActualizarCuenta = New Guna.UI2.WinForms.Guna2Button()
            Me.BTN_Regresar = New Guna.UI2.WinForms.Guna2Button()
            Me.MainLayoutDetalleCxC = New System.Windows.Forms.TableLayoutPanel()
            Me.PAN_Comentario = New Guna.UI2.WinForms.Guna2Panel()
            Me.TXT_Comentario = New Guna.UI2.WinForms.Guna2TextBox()
            Me.Guna2Panel12 = New Guna.UI2.WinForms.Guna2Panel()
            Me.PAN_SaldoRestante = New Guna.UI2.WinForms.Guna2Panel()
            Me.PAN_LBLSaldoRestante = New Guna.UI2.WinForms.Guna2Panel()
            Me.PAN_LblTitleListAbono = New Guna.UI2.WinForms.Guna2Panel()
            Me.Guna2Panel7 = New Guna.UI2.WinForms.Guna2Panel()
            Me.PAN_LBLCantProd = New Guna.UI2.WinForms.Guna2Panel()
            Me.PAN_CantProd = New Guna.UI2.WinForms.Guna2Panel()
            Me.PAN_LblTitleListProd = New Guna.UI2.WinForms.Guna2Panel()
            Me.PAN_Total = New Guna.UI2.WinForms.Guna2Panel()
            Me.PAN_Fecha = New Guna.UI2.WinForms.Guna2Panel()
            Me.PAN_Cliente = New Guna.UI2.WinForms.Guna2Panel()
            CType(Me.DGV_ListProds, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.DGV_ListaAbonos, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.TableLayoutPanel1.SuspendLayout()
            Me.MainLayoutDetalleCxC.SuspendLayout()
            Me.PAN_Comentario.SuspendLayout()
            Me.Guna2Panel12.SuspendLayout()
            Me.PAN_SaldoRestante.SuspendLayout()
            Me.PAN_LBLSaldoRestante.SuspendLayout()
            Me.PAN_LblTitleListAbono.SuspendLayout()
            Me.Guna2Panel7.SuspendLayout()
            Me.PAN_LBLCantProd.SuspendLayout()
            Me.PAN_CantProd.SuspendLayout()
            Me.PAN_LblTitleListProd.SuspendLayout()
            Me.PAN_Total.SuspendLayout()
            Me.PAN_Fecha.SuspendLayout()
            Me.PAN_Cliente.SuspendLayout()
            Me.SuspendLayout()
            '
            'TXT_Total
            '
            Me.TXT_Total.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.TXT_Total.BackColor = System.Drawing.Color.Transparent
            Me.TXT_Total.BorderRadius = 20
            Me.TXT_Total.Cursor = System.Windows.Forms.Cursors.IBeam
            Me.TXT_Total.DefaultText = ""
            Me.TXT_Total.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
            Me.TXT_Total.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
            Me.TXT_Total.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
            Me.TXT_Total.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
            Me.TXT_Total.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.TXT_Total.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.TXT_Total.ForeColor = System.Drawing.Color.Black
            Me.TXT_Total.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.TXT_Total.Location = New System.Drawing.Point(87, 5)
            Me.TXT_Total.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
            Me.TXT_Total.Name = "TXT_Total"
            Me.TXT_Total.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
            Me.TXT_Total.PlaceholderText = ""
            Me.TXT_Total.SelectedText = ""
            Me.TXT_Total.Size = New System.Drawing.Size(295, 42)
            Me.TXT_Total.TabIndex = 107
            '
            'Guna2HtmlLabel1
            '
            Me.Guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent
            Me.Guna2HtmlLabel1.Font = New System.Drawing.Font("Segoe UI Black", 15.75!, System.Drawing.FontStyle.Bold)
            Me.Guna2HtmlLabel1.ForeColor = System.Drawing.SystemColors.Control
            Me.Guna2HtmlLabel1.Location = New System.Drawing.Point(17, 5)
            Me.Guna2HtmlLabel1.Name = "Guna2HtmlLabel1"
            Me.Guna2HtmlLabel1.Size = New System.Drawing.Size(81, 32)
            Me.Guna2HtmlLabel1.TabIndex = 106
            Me.Guna2HtmlLabel1.Text = "Cliente: "
            Me.Guna2HtmlLabel1.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit
            '
            'lblCliente
            '
            Me.lblCliente.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.lblCliente.AutoSize = False
            Me.lblCliente.BackColor = System.Drawing.Color.Transparent
            Me.lblCliente.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblCliente.ForeColor = System.Drawing.SystemColors.Control
            Me.lblCliente.Location = New System.Drawing.Point(104, 8)
            Me.lblCliente.Name = "lblCliente"
            Me.lblCliente.Size = New System.Drawing.Size(120, 32)
            Me.lblCliente.TabIndex = 108
            Me.lblCliente.Text = "Nombre"
            Me.lblCliente.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
            Me.lblCliente.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit
            '
            'Guna2HtmlLabel2
            '
            Me.Guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent
            Me.Guna2HtmlLabel2.Font = New System.Drawing.Font("Segoe UI Black", 15.75!, System.Drawing.FontStyle.Bold)
            Me.Guna2HtmlLabel2.ForeColor = System.Drawing.SystemColors.Control
            Me.Guna2HtmlLabel2.Location = New System.Drawing.Point(8, 6)
            Me.Guna2HtmlLabel2.Name = "Guna2HtmlLabel2"
            Me.Guna2HtmlLabel2.Size = New System.Drawing.Size(81, 32)
            Me.Guna2HtmlLabel2.TabIndex = 109
            Me.Guna2HtmlLabel2.Text = "Creada:"
            Me.Guna2HtmlLabel2.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit
            '
            'lblFechaCreacion
            '
            Me.lblFechaCreacion.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.lblFechaCreacion.AutoSize = False
            Me.lblFechaCreacion.BackColor = System.Drawing.Color.Transparent
            Me.lblFechaCreacion.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblFechaCreacion.ForeColor = System.Drawing.SystemColors.Control
            Me.lblFechaCreacion.Location = New System.Drawing.Point(95, 8)
            Me.lblFechaCreacion.Name = "lblFechaCreacion"
            Me.lblFechaCreacion.Size = New System.Drawing.Size(242, 32)
            Me.lblFechaCreacion.TabIndex = 110
            Me.lblFechaCreacion.Text = "00/00/00"
            Me.lblFechaCreacion.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
            Me.lblFechaCreacion.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit
            '
            'Guna2HtmlLabel3
            '
            Me.Guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent
            Me.Guna2HtmlLabel3.Font = New System.Drawing.Font("Segoe UI Black", 15.75!, System.Drawing.FontStyle.Bold)
            Me.Guna2HtmlLabel3.ForeColor = System.Drawing.SystemColors.Control
            Me.Guna2HtmlLabel3.Location = New System.Drawing.Point(16, 8)
            Me.Guna2HtmlLabel3.Name = "Guna2HtmlLabel3"
            Me.Guna2HtmlLabel3.Size = New System.Drawing.Size(63, 32)
            Me.Guna2HtmlLabel3.TabIndex = 111
            Me.Guna2HtmlLabel3.Text = "Total:"
            Me.Guna2HtmlLabel3.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit
            '
            'Guna2HtmlLabel4
            '
            Me.Guna2HtmlLabel4.BackColor = System.Drawing.Color.Transparent
            Me.Guna2HtmlLabel4.Font = New System.Drawing.Font("Segoe UI Black", 15.75!, System.Drawing.FontStyle.Bold)
            Me.Guna2HtmlLabel4.ForeColor = System.Drawing.SystemColors.Control
            Me.Guna2HtmlLabel4.Location = New System.Drawing.Point(29, 21)
            Me.Guna2HtmlLabel4.Name = "Guna2HtmlLabel4"
            Me.Guna2HtmlLabel4.Size = New System.Drawing.Size(130, 32)
            Me.Guna2HtmlLabel4.TabIndex = 112
            Me.Guna2HtmlLabel4.Text = "Comentario:"
            Me.Guna2HtmlLabel4.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit
            '
            'DGV_ListProds
            '
            Me.DGV_ListProds.AllowUserToAddRows = False
            Me.DGV_ListProds.AllowUserToDeleteRows = False
            DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
            Me.DGV_ListProds.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
            Me.DGV_ListProds.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.DGV_ListProds.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
            DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
            DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
            DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
            DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
            Me.DGV_ListProds.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
            Me.DGV_ListProds.ColumnHeadersHeight = 15
            Me.DGV_ListProds.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
            DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
            DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
            DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
            DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
            DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
            Me.DGV_ListProds.DefaultCellStyle = DataGridViewCellStyle3
            Me.DGV_ListProds.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter
            Me.DGV_ListProds.GridColor = System.Drawing.Color.White
            Me.DGV_ListProds.Location = New System.Drawing.Point(29, 0)
            Me.DGV_ListProds.Margin = New System.Windows.Forms.Padding(8)
            Me.DGV_ListProds.MultiSelect = False
            Me.DGV_ListProds.Name = "DGV_ListProds"
            Me.DGV_ListProds.ReadOnly = True
            Me.DGV_ListProds.RowHeadersVisible = False
            Me.DGV_ListProds.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
            Me.DGV_ListProds.Size = New System.Drawing.Size(1135, 133)
            Me.DGV_ListProds.TabIndex = 128
            Me.DGV_ListProds.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
            Me.DGV_ListProds.ThemeStyle.AlternatingRowsStyle.Font = Nothing
            Me.DGV_ListProds.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
            Me.DGV_ListProds.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
            Me.DGV_ListProds.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
            Me.DGV_ListProds.ThemeStyle.BackColor = System.Drawing.Color.White
            Me.DGV_ListProds.ThemeStyle.GridColor = System.Drawing.Color.White
            Me.DGV_ListProds.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.DGV_ListProds.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
            Me.DGV_ListProds.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.DGV_ListProds.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
            Me.DGV_ListProds.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
            Me.DGV_ListProds.ThemeStyle.HeaderStyle.Height = 15
            Me.DGV_ListProds.ThemeStyle.ReadOnly = True
            Me.DGV_ListProds.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
            Me.DGV_ListProds.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
            Me.DGV_ListProds.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.DGV_ListProds.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
            Me.DGV_ListProds.ThemeStyle.RowsStyle.Height = 22
            Me.DGV_ListProds.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.DGV_ListProds.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
            '
            'Guna2HtmlLabel5
            '
            Me.Guna2HtmlLabel5.BackColor = System.Drawing.Color.Transparent
            Me.Guna2HtmlLabel5.Font = New System.Drawing.Font("Segoe UI Black", 15.75!, System.Drawing.FontStyle.Bold)
            Me.Guna2HtmlLabel5.ForeColor = System.Drawing.SystemColors.Control
            Me.Guna2HtmlLabel5.Location = New System.Drawing.Point(17, 5)
            Me.Guna2HtmlLabel5.Name = "Guna2HtmlLabel5"
            Me.Guna2HtmlLabel5.Size = New System.Drawing.Size(198, 32)
            Me.Guna2HtmlLabel5.TabIndex = 129
            Me.Guna2HtmlLabel5.Text = "Lista de productos:"
            Me.Guna2HtmlLabel5.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit
            '
            'Guna2HtmlLabel6
            '
            Me.Guna2HtmlLabel6.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.Guna2HtmlLabel6.BackColor = System.Drawing.Color.Transparent
            Me.Guna2HtmlLabel6.Font = New System.Drawing.Font("Segoe UI Black", 15.75!, System.Drawing.FontStyle.Bold)
            Me.Guna2HtmlLabel6.ForeColor = System.Drawing.SystemColors.Control
            Me.Guna2HtmlLabel6.Location = New System.Drawing.Point(89, 5)
            Me.Guna2HtmlLabel6.Name = "Guna2HtmlLabel6"
            Me.Guna2HtmlLabel6.Size = New System.Drawing.Size(241, 32)
            Me.Guna2HtmlLabel6.TabIndex = 130
            Me.Guna2HtmlLabel6.Text = "Cantidad de productos:"
            Me.Guna2HtmlLabel6.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit
            '
            'lblCantProds
            '
            Me.lblCantProds.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.lblCantProds.AutoSize = False
            Me.lblCantProds.BackColor = System.Drawing.Color.Transparent
            Me.lblCantProds.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblCantProds.ForeColor = System.Drawing.SystemColors.Control
            Me.lblCantProds.Location = New System.Drawing.Point(16, 5)
            Me.lblCantProds.Name = "lblCantProds"
            Me.lblCantProds.Size = New System.Drawing.Size(366, 32)
            Me.lblCantProds.TabIndex = 131
            Me.lblCantProds.Text = "0"
            Me.lblCantProds.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
            Me.lblCantProds.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit
            '
            'lblSaldoRestante
            '
            Me.lblSaldoRestante.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.lblSaldoRestante.AutoSize = False
            Me.lblSaldoRestante.BackColor = System.Drawing.Color.Transparent
            Me.lblSaldoRestante.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblSaldoRestante.ForeColor = System.Drawing.SystemColors.Control
            Me.lblSaldoRestante.Location = New System.Drawing.Point(16, 4)
            Me.lblSaldoRestante.Name = "lblSaldoRestante"
            Me.lblSaldoRestante.Size = New System.Drawing.Size(366, 32)
            Me.lblSaldoRestante.TabIndex = 135
            Me.lblSaldoRestante.Text = "0.00"
            Me.lblSaldoRestante.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
            Me.lblSaldoRestante.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit
            '
            'Guna2HtmlLabel8
            '
            Me.Guna2HtmlLabel8.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.Guna2HtmlLabel8.BackColor = System.Drawing.Color.Transparent
            Me.Guna2HtmlLabel8.Font = New System.Drawing.Font("Segoe UI Black", 15.75!, System.Drawing.FontStyle.Bold)
            Me.Guna2HtmlLabel8.ForeColor = System.Drawing.SystemColors.Control
            Me.Guna2HtmlLabel8.Location = New System.Drawing.Point(167, 4)
            Me.Guna2HtmlLabel8.Name = "Guna2HtmlLabel8"
            Me.Guna2HtmlLabel8.Size = New System.Drawing.Size(163, 32)
            Me.Guna2HtmlLabel8.TabIndex = 134
            Me.Guna2HtmlLabel8.Text = "Saldo Restante:"
            Me.Guna2HtmlLabel8.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit
            '
            'Guna2HtmlLabel9
            '
            Me.Guna2HtmlLabel9.BackColor = System.Drawing.Color.Transparent
            Me.Guna2HtmlLabel9.Font = New System.Drawing.Font("Segoe UI Black", 15.75!, System.Drawing.FontStyle.Bold)
            Me.Guna2HtmlLabel9.ForeColor = System.Drawing.SystemColors.Control
            Me.Guna2HtmlLabel9.Location = New System.Drawing.Point(17, 4)
            Me.Guna2HtmlLabel9.Name = "Guna2HtmlLabel9"
            Me.Guna2HtmlLabel9.Size = New System.Drawing.Size(169, 32)
            Me.Guna2HtmlLabel9.TabIndex = 133
            Me.Guna2HtmlLabel9.Text = "Lista de abonos:"
            Me.Guna2HtmlLabel9.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit
            '
            'DGV_ListaAbonos
            '
            Me.DGV_ListaAbonos.AllowUserToDeleteRows = False
            Me.DGV_ListaAbonos.AllowUserToOrderColumns = True
            DataGridViewCellStyle4.BackColor = System.Drawing.Color.White
            Me.DGV_ListaAbonos.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle4
            Me.DGV_ListaAbonos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
            DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle5.ForeColor = System.Drawing.Color.White
            DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
            DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
            Me.DGV_ListaAbonos.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
            Me.DGV_ListaAbonos.ColumnHeadersHeight = 15
            Me.DGV_ListaAbonos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
            DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
            DataGridViewCellStyle6.BackColor = System.Drawing.Color.White
            DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
            DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
            DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
            DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
            Me.DGV_ListaAbonos.DefaultCellStyle = DataGridViewCellStyle6
            Me.DGV_ListaAbonos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter
            Me.DGV_ListaAbonos.GridColor = System.Drawing.Color.White
            Me.DGV_ListaAbonos.Location = New System.Drawing.Point(29, 0)
            Me.DGV_ListaAbonos.Margin = New System.Windows.Forms.Padding(8)
            Me.DGV_ListaAbonos.Name = "DGV_ListaAbonos"
            Me.DGV_ListaAbonos.RowHeadersVisible = False
            Me.DGV_ListaAbonos.Size = New System.Drawing.Size(1135, 129)
            Me.DGV_ListaAbonos.TabIndex = 132
            Me.DGV_ListaAbonos.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
            Me.DGV_ListaAbonos.ThemeStyle.AlternatingRowsStyle.Font = Nothing
            Me.DGV_ListaAbonos.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
            Me.DGV_ListaAbonos.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
            Me.DGV_ListaAbonos.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
            Me.DGV_ListaAbonos.ThemeStyle.BackColor = System.Drawing.Color.White
            Me.DGV_ListaAbonos.ThemeStyle.GridColor = System.Drawing.Color.White
            Me.DGV_ListaAbonos.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.DGV_ListaAbonos.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
            Me.DGV_ListaAbonos.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.DGV_ListaAbonos.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
            Me.DGV_ListaAbonos.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
            Me.DGV_ListaAbonos.ThemeStyle.HeaderStyle.Height = 15
            Me.DGV_ListaAbonos.ThemeStyle.ReadOnly = False
            Me.DGV_ListaAbonos.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
            Me.DGV_ListaAbonos.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
            Me.DGV_ListaAbonos.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.DGV_ListaAbonos.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
            Me.DGV_ListaAbonos.ThemeStyle.RowsStyle.Height = 22
            Me.DGV_ListaAbonos.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.DGV_ListaAbonos.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
            '
            'TableLayoutPanel1
            '
            Me.TableLayoutPanel1.ColumnCount = 2
            Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
            Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
            Me.TableLayoutPanel1.Controls.Add(Me.BTN_ActualizarCuenta, 1, 0)
            Me.TableLayoutPanel1.Controls.Add(Me.BTN_Regresar, 0, 0)
            Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 518)
            Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
            Me.TableLayoutPanel1.RowCount = 1
            Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
            Me.TableLayoutPanel1.Size = New System.Drawing.Size(1199, 60)
            Me.TableLayoutPanel1.TabIndex = 136
            '
            'BTN_ActualizarCuenta
            '
            Me.BTN_ActualizarCuenta.BorderRadius = 10
            Me.BTN_ActualizarCuenta.DisabledState.BorderColor = System.Drawing.Color.DarkGray
            Me.BTN_ActualizarCuenta.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
            Me.BTN_ActualizarCuenta.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
            Me.BTN_ActualizarCuenta.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
            Me.BTN_ActualizarCuenta.Dock = System.Windows.Forms.DockStyle.Fill
            Me.BTN_ActualizarCuenta.FillColor = System.Drawing.Color.LightSeaGreen
            Me.BTN_ActualizarCuenta.Font = New System.Drawing.Font("Ebrima", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.BTN_ActualizarCuenta.ForeColor = System.Drawing.Color.White
            Me.BTN_ActualizarCuenta.Image = Global.SistemaFacturaciónCommon.My.Resources.Resources.ICO_Export
            Me.BTN_ActualizarCuenta.ImageSize = New System.Drawing.Size(40, 40)
            Me.BTN_ActualizarCuenta.Location = New System.Drawing.Point(602, 3)
            Me.BTN_ActualizarCuenta.Name = "BTN_ActualizarCuenta"
            Me.BTN_ActualizarCuenta.Size = New System.Drawing.Size(594, 54)
            Me.BTN_ActualizarCuenta.TabIndex = 138
            Me.BTN_ActualizarCuenta.Text = "Actualizar cuenta"
            '
            'BTN_Regresar
            '
            Me.BTN_Regresar.BorderRadius = 10
            Me.BTN_Regresar.DisabledState.BorderColor = System.Drawing.Color.DarkGray
            Me.BTN_Regresar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
            Me.BTN_Regresar.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
            Me.BTN_Regresar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
            Me.BTN_Regresar.Dock = System.Windows.Forms.DockStyle.Fill
            Me.BTN_Regresar.FillColor = System.Drawing.Color.IndianRed
            Me.BTN_Regresar.Font = New System.Drawing.Font("Ebrima", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.BTN_Regresar.ForeColor = System.Drawing.Color.White
            Me.BTN_Regresar.Image = Global.SistemaFacturaciónCommon.My.Resources.Resources.ICO_Back
            Me.BTN_Regresar.ImageSize = New System.Drawing.Size(40, 40)
            Me.BTN_Regresar.Location = New System.Drawing.Point(3, 3)
            Me.BTN_Regresar.Name = "BTN_Regresar"
            Me.BTN_Regresar.Size = New System.Drawing.Size(593, 54)
            Me.BTN_Regresar.TabIndex = 137
            Me.BTN_Regresar.Text = "Regresar"
            '
            'MainLayoutDetalleCxC
            '
            Me.MainLayoutDetalleCxC.ColumnCount = 3
            Me.MainLayoutDetalleCxC.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 37.87376!))
            Me.MainLayoutDetalleCxC.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28.90365!))
            Me.MainLayoutDetalleCxC.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.22258!))
            Me.MainLayoutDetalleCxC.Controls.Add(Me.PAN_Comentario, 0, 1)
            Me.MainLayoutDetalleCxC.Controls.Add(Me.Guna2Panel12, 0, 5)
            Me.MainLayoutDetalleCxC.Controls.Add(Me.PAN_SaldoRestante, 2, 4)
            Me.MainLayoutDetalleCxC.Controls.Add(Me.PAN_LBLSaldoRestante, 1, 4)
            Me.MainLayoutDetalleCxC.Controls.Add(Me.PAN_LblTitleListAbono, 0, 4)
            Me.MainLayoutDetalleCxC.Controls.Add(Me.Guna2Panel7, 0, 3)
            Me.MainLayoutDetalleCxC.Controls.Add(Me.PAN_LBLCantProd, 1, 2)
            Me.MainLayoutDetalleCxC.Controls.Add(Me.PAN_CantProd, 2, 2)
            Me.MainLayoutDetalleCxC.Controls.Add(Me.PAN_LblTitleListProd, 0, 2)
            Me.MainLayoutDetalleCxC.Controls.Add(Me.PAN_Total, 2, 0)
            Me.MainLayoutDetalleCxC.Controls.Add(Me.PAN_Fecha, 1, 0)
            Me.MainLayoutDetalleCxC.Controls.Add(Me.PAN_Cliente, 0, 0)
            Me.MainLayoutDetalleCxC.Dock = System.Windows.Forms.DockStyle.Fill
            Me.MainLayoutDetalleCxC.Location = New System.Drawing.Point(0, 0)
            Me.MainLayoutDetalleCxC.Name = "MainLayoutDetalleCxC"
            Me.MainLayoutDetalleCxC.RowCount = 6
            Me.MainLayoutDetalleCxC.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60.0!))
            Me.MainLayoutDetalleCxC.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 22.75133!))
            Me.MainLayoutDetalleCxC.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50.0!))
            Me.MainLayoutDetalleCxC.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 38.62434!))
            Me.MainLayoutDetalleCxC.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50.0!))
            Me.MainLayoutDetalleCxC.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 38.62434!))
            Me.MainLayoutDetalleCxC.Size = New System.Drawing.Size(1199, 518)
            Me.MainLayoutDetalleCxC.TabIndex = 137
            '
            'PAN_Comentario
            '
            Me.MainLayoutDetalleCxC.SetColumnSpan(Me.PAN_Comentario, 3)
            Me.PAN_Comentario.Controls.Add(Me.Guna2HtmlLabel4)
            Me.PAN_Comentario.Controls.Add(Me.TXT_Comentario)
            Me.PAN_Comentario.Dock = System.Windows.Forms.DockStyle.Fill
            Me.PAN_Comentario.Location = New System.Drawing.Point(3, 63)
            Me.PAN_Comentario.Name = "PAN_Comentario"
            Me.PAN_Comentario.Size = New System.Drawing.Size(1193, 75)
            Me.PAN_Comentario.TabIndex = 14
            '
            'TXT_Comentario
            '
            Me.TXT_Comentario.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.TXT_Comentario.BackColor = System.Drawing.Color.Transparent
            Me.TXT_Comentario.BorderRadius = 20
            Me.TXT_Comentario.Cursor = System.Windows.Forms.Cursors.IBeam
            Me.TXT_Comentario.DefaultText = ""
            Me.TXT_Comentario.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
            Me.TXT_Comentario.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
            Me.TXT_Comentario.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
            Me.TXT_Comentario.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
            Me.TXT_Comentario.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.TXT_Comentario.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.TXT_Comentario.ForeColor = System.Drawing.Color.Black
            Me.TXT_Comentario.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.TXT_Comentario.Location = New System.Drawing.Point(191, 5)
            Me.TXT_Comentario.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
            Me.TXT_Comentario.Multiline = True
            Me.TXT_Comentario.Name = "TXT_Comentario"
            Me.TXT_Comentario.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
            Me.TXT_Comentario.PlaceholderText = ""
            Me.TXT_Comentario.ReadOnly = True
            Me.TXT_Comentario.SelectedText = ""
            Me.TXT_Comentario.Size = New System.Drawing.Size(991, 65)
            Me.TXT_Comentario.TabIndex = 114
            '
            'Guna2Panel12
            '
            Me.MainLayoutDetalleCxC.SetColumnSpan(Me.Guna2Panel12, 3)
            Me.Guna2Panel12.Controls.Add(Me.DGV_ListaAbonos)
            Me.Guna2Panel12.Dock = System.Windows.Forms.DockStyle.Fill
            Me.Guna2Panel12.Location = New System.Drawing.Point(3, 382)
            Me.Guna2Panel12.Name = "Guna2Panel12"
            Me.Guna2Panel12.Size = New System.Drawing.Size(1193, 133)
            Me.Guna2Panel12.TabIndex = 13
            '
            'PAN_SaldoRestante
            '
            Me.PAN_SaldoRestante.Controls.Add(Me.lblSaldoRestante)
            Me.PAN_SaldoRestante.Dock = System.Windows.Forms.DockStyle.Fill
            Me.PAN_SaldoRestante.Location = New System.Drawing.Point(803, 332)
            Me.PAN_SaldoRestante.Name = "PAN_SaldoRestante"
            Me.PAN_SaldoRestante.Size = New System.Drawing.Size(393, 44)
            Me.PAN_SaldoRestante.TabIndex = 12
            '
            'PAN_LBLSaldoRestante
            '
            Me.PAN_LBLSaldoRestante.Controls.Add(Me.Guna2HtmlLabel8)
            Me.PAN_LBLSaldoRestante.Dock = System.Windows.Forms.DockStyle.Fill
            Me.PAN_LBLSaldoRestante.Location = New System.Drawing.Point(457, 332)
            Me.PAN_LBLSaldoRestante.Name = "PAN_LBLSaldoRestante"
            Me.PAN_LBLSaldoRestante.Size = New System.Drawing.Size(340, 44)
            Me.PAN_LBLSaldoRestante.TabIndex = 11
            '
            'PAN_LblTitleListAbono
            '
            Me.PAN_LblTitleListAbono.Controls.Add(Me.Guna2HtmlLabel9)
            Me.PAN_LblTitleListAbono.Dock = System.Windows.Forms.DockStyle.Fill
            Me.PAN_LblTitleListAbono.Location = New System.Drawing.Point(3, 332)
            Me.PAN_LblTitleListAbono.Name = "PAN_LblTitleListAbono"
            Me.PAN_LblTitleListAbono.Size = New System.Drawing.Size(448, 44)
            Me.PAN_LblTitleListAbono.TabIndex = 10
            '
            'Guna2Panel7
            '
            Me.MainLayoutDetalleCxC.SetColumnSpan(Me.Guna2Panel7, 3)
            Me.Guna2Panel7.Controls.Add(Me.DGV_ListProds)
            Me.Guna2Panel7.Dock = System.Windows.Forms.DockStyle.Fill
            Me.Guna2Panel7.Location = New System.Drawing.Point(3, 194)
            Me.Guna2Panel7.Name = "Guna2Panel7"
            Me.Guna2Panel7.Size = New System.Drawing.Size(1193, 132)
            Me.Guna2Panel7.TabIndex = 9
            '
            'PAN_LBLCantProd
            '
            Me.PAN_LBLCantProd.Controls.Add(Me.Guna2HtmlLabel6)
            Me.PAN_LBLCantProd.Dock = System.Windows.Forms.DockStyle.Fill
            Me.PAN_LBLCantProd.Location = New System.Drawing.Point(457, 144)
            Me.PAN_LBLCantProd.Name = "PAN_LBLCantProd"
            Me.PAN_LBLCantProd.Size = New System.Drawing.Size(340, 44)
            Me.PAN_LBLCantProd.TabIndex = 8
            '
            'PAN_CantProd
            '
            Me.PAN_CantProd.Controls.Add(Me.lblCantProds)
            Me.PAN_CantProd.Dock = System.Windows.Forms.DockStyle.Fill
            Me.PAN_CantProd.Location = New System.Drawing.Point(803, 144)
            Me.PAN_CantProd.Name = "PAN_CantProd"
            Me.PAN_CantProd.Size = New System.Drawing.Size(393, 44)
            Me.PAN_CantProd.TabIndex = 7
            '
            'PAN_LblTitleListProd
            '
            Me.PAN_LblTitleListProd.Controls.Add(Me.Guna2HtmlLabel5)
            Me.PAN_LblTitleListProd.Dock = System.Windows.Forms.DockStyle.Fill
            Me.PAN_LblTitleListProd.Location = New System.Drawing.Point(3, 144)
            Me.PAN_LblTitleListProd.Name = "PAN_LblTitleListProd"
            Me.PAN_LblTitleListProd.Size = New System.Drawing.Size(448, 44)
            Me.PAN_LblTitleListProd.TabIndex = 5
            '
            'PAN_Total
            '
            Me.PAN_Total.Controls.Add(Me.Guna2HtmlLabel3)
            Me.PAN_Total.Controls.Add(Me.TXT_Total)
            Me.PAN_Total.Dock = System.Windows.Forms.DockStyle.Fill
            Me.PAN_Total.Location = New System.Drawing.Point(803, 3)
            Me.PAN_Total.Name = "PAN_Total"
            Me.PAN_Total.Size = New System.Drawing.Size(393, 54)
            Me.PAN_Total.TabIndex = 2
            '
            'PAN_Fecha
            '
            Me.PAN_Fecha.Controls.Add(Me.lblFechaCreacion)
            Me.PAN_Fecha.Controls.Add(Me.Guna2HtmlLabel2)
            Me.PAN_Fecha.Dock = System.Windows.Forms.DockStyle.Fill
            Me.PAN_Fecha.Location = New System.Drawing.Point(457, 3)
            Me.PAN_Fecha.Name = "PAN_Fecha"
            Me.PAN_Fecha.Size = New System.Drawing.Size(340, 54)
            Me.PAN_Fecha.TabIndex = 1
            '
            'PAN_Cliente
            '
            Me.PAN_Cliente.Controls.Add(Me.lblCliente)
            Me.PAN_Cliente.Controls.Add(Me.Guna2HtmlLabel1)
            Me.PAN_Cliente.Dock = System.Windows.Forms.DockStyle.Fill
            Me.PAN_Cliente.Location = New System.Drawing.Point(3, 3)
            Me.PAN_Cliente.Name = "PAN_Cliente"
            Me.PAN_Cliente.Size = New System.Drawing.Size(448, 54)
            Me.PAN_Cliente.TabIndex = 0
            '
            'P_VerDetallesCxC
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer))
            Me.ClientSize = New System.Drawing.Size(1199, 578)
            Me.Controls.Add(Me.MainLayoutDetalleCxC)
            Me.Controls.Add(Me.TableLayoutPanel1)
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.KeyPreview = True
            Me.Name = "P_VerDetallesCxC"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "Detalles de factura por cobrar"
            Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
            CType(Me.DGV_ListProds, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.DGV_ListaAbonos, System.ComponentModel.ISupportInitialize).EndInit()
            Me.TableLayoutPanel1.ResumeLayout(False)
            Me.MainLayoutDetalleCxC.ResumeLayout(False)
            Me.PAN_Comentario.ResumeLayout(False)
            Me.PAN_Comentario.PerformLayout()
            Me.Guna2Panel12.ResumeLayout(False)
            Me.PAN_SaldoRestante.ResumeLayout(False)
            Me.PAN_LBLSaldoRestante.ResumeLayout(False)
            Me.PAN_LBLSaldoRestante.PerformLayout()
            Me.PAN_LblTitleListAbono.ResumeLayout(False)
            Me.PAN_LblTitleListAbono.PerformLayout()
            Me.Guna2Panel7.ResumeLayout(False)
            Me.PAN_LBLCantProd.ResumeLayout(False)
            Me.PAN_LBLCantProd.PerformLayout()
            Me.PAN_CantProd.ResumeLayout(False)
            Me.PAN_LblTitleListProd.ResumeLayout(False)
            Me.PAN_LblTitleListProd.PerformLayout()
            Me.PAN_Total.ResumeLayout(False)
            Me.PAN_Total.PerformLayout()
            Me.PAN_Fecha.ResumeLayout(False)
            Me.PAN_Fecha.PerformLayout()
            Me.PAN_Cliente.ResumeLayout(False)
            Me.PAN_Cliente.PerformLayout()
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents TXT_Total As Guna.UI2.WinForms.Guna2TextBox
        Friend WithEvents Guna2HtmlLabel1 As Guna.UI2.WinForms.Guna2HtmlLabel
        Friend WithEvents lblCliente As Guna.UI2.WinForms.Guna2HtmlLabel
        Friend WithEvents Guna2HtmlLabel2 As Guna.UI2.WinForms.Guna2HtmlLabel
        Friend WithEvents lblFechaCreacion As Guna.UI2.WinForms.Guna2HtmlLabel
        Friend WithEvents Guna2HtmlLabel3 As Guna.UI2.WinForms.Guna2HtmlLabel
        Friend WithEvents Guna2HtmlLabel4 As Guna.UI2.WinForms.Guna2HtmlLabel
        Friend WithEvents DGV_ListProds As Guna.UI2.WinForms.Guna2DataGridView
        Friend WithEvents Guna2HtmlLabel5 As Guna.UI2.WinForms.Guna2HtmlLabel
        Friend WithEvents Guna2HtmlLabel6 As Guna.UI2.WinForms.Guna2HtmlLabel
        Friend WithEvents lblCantProds As Guna.UI2.WinForms.Guna2HtmlLabel
        Friend WithEvents lblSaldoRestante As Guna.UI2.WinForms.Guna2HtmlLabel
        Friend WithEvents Guna2HtmlLabel8 As Guna.UI2.WinForms.Guna2HtmlLabel
        Friend WithEvents Guna2HtmlLabel9 As Guna.UI2.WinForms.Guna2HtmlLabel
        Friend WithEvents DGV_ListaAbonos As Guna.UI2.WinForms.Guna2DataGridView
        Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
        Friend WithEvents BTN_Regresar As Guna.UI2.WinForms.Guna2Button
        Friend WithEvents BTN_ActualizarCuenta As Guna.UI2.WinForms.Guna2Button
        Friend WithEvents MainLayoutDetalleCxC As TableLayoutPanel
        Friend WithEvents PAN_Cliente As Guna.UI2.WinForms.Guna2Panel
        Friend WithEvents PAN_Fecha As Guna.UI2.WinForms.Guna2Panel
        Friend WithEvents PAN_Total As Guna.UI2.WinForms.Guna2Panel
        Friend WithEvents Guna2Panel7 As Guna.UI2.WinForms.Guna2Panel
        Friend WithEvents PAN_LBLCantProd As Guna.UI2.WinForms.Guna2Panel
        Friend WithEvents PAN_CantProd As Guna.UI2.WinForms.Guna2Panel
        Friend WithEvents PAN_LblTitleListProd As Guna.UI2.WinForms.Guna2Panel
        Friend WithEvents Guna2Panel12 As Guna.UI2.WinForms.Guna2Panel
        Friend WithEvents PAN_SaldoRestante As Guna.UI2.WinForms.Guna2Panel
        Friend WithEvents PAN_LBLSaldoRestante As Guna.UI2.WinForms.Guna2Panel
        Friend WithEvents PAN_LblTitleListAbono As Guna.UI2.WinForms.Guna2Panel
        Friend WithEvents PAN_Comentario As Guna.UI2.WinForms.Guna2Panel
        Friend WithEvents TXT_Comentario As Guna.UI2.WinForms.Guna2TextBox
    End Class
End Namespace
