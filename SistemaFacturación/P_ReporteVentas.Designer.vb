<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class P_ReporteVentas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(P_ReporteVentas))
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.TAB_Reportes = New Guna.UI2.WinForms.Guna2TabControl()
        Me.PAG_ReporteVentas = New System.Windows.Forms.TabPage()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Guna2GroupBox1 = New Guna.UI2.WinForms.Guna2GroupBox()
        Me.TXT_CantProdMasVendido = New Guna.UI2.WinForms.Guna2TextBox()
        Me.TXT_TotalProdMasVendido = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2HtmlLabel9 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel8 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel6 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.TXT_NombreProdMasVendido = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2GroupBox2 = New Guna.UI2.WinForms.Guna2GroupBox()
        Me.TXT_CantFacturas = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2HtmlLabel5 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel4 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.TXT_VentasEfectivo = New Guna.UI2.WinForms.Guna2TextBox()
        Me.TXT_VentasTarjeta = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2HtmlLabel3 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel2 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel1 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.LBL_Usu = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.TXT_TotalVentas = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.BTN_GenerarReporteVentaPDF = New Guna.UI2.WinForms.Guna2Button()
        Me.BTN_RegresarReporte = New Guna.UI2.WinForms.Guna2Button()
        Me.BTN_GenReporte = New Guna.UI2.WinForms.Guna2Button()
        Me.DTP_Hasta = New Guna.UI2.WinForms.Guna2DateTimePicker()
        Me.DTP_Desde = New Guna.UI2.WinForms.Guna2DateTimePicker()
        Me.DGV_FactReporte = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.MNU_CONTX = New Guna.UI2.WinForms.Guna2ContextMenuStrip()
        Me.MNU_REIMPRIMIR = New System.Windows.Forms.ToolStripMenuItem()
        Me.MNU_Datos = New System.Windows.Forms.ToolStripMenuItem()
        Me.PAG_ReporteProd = New System.Windows.Forms.TabPage()
        Me.TBL_ReporteProductosGeneral = New System.Windows.Forms.TableLayoutPanel()
        Me.TBL_ResultContainer = New System.Windows.Forms.TableLayoutPanel()
        Me.BTN_RegresarReporteProducto = New Guna.UI2.WinForms.Guna2Button()
        Me.GBX_ListaProductoCompleta = New Guna.UI2.WinForms.Guna2GroupBox()
        Me.DGV_ListProductosMasVendidos = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.DGV_MejorProducto = New Guna.UI2.WinForms.Guna2GroupBox()
        Me.TXT_MejorProductoCant = New Guna.UI2.WinForms.Guna2TextBox()
        Me.TXT_MejorProductoTotal = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2HtmlLabel7 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel10 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel11 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.TXT_MejorProductoNombre = New Guna.UI2.WinForms.Guna2TextBox()
        Me.PAN_ReporteProductoInputContainer = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2GroupBox3 = New Guna.UI2.WinForms.Guna2GroupBox()
        Me.RDB_OrderByCant = New Syncfusion.Windows.Forms.Tools.RadioButtonAdv()
        Me.RDB_OrderByTotal = New Syncfusion.Windows.Forms.Tools.RadioButtonAdv()
        Me.Guna2HtmlLabel15 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.BTN_GenReporteProductos = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2HtmlLabel13 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel14 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.DTP_HastaReporteProducto = New Guna.UI2.WinForms.Guna2DateTimePicker()
        Me.DTP_DesdeReporteProducto = New Guna.UI2.WinForms.Guna2DateTimePicker()
        Me.NUD_LimitReporteProducto = New Guna.UI2.WinForms.Guna2NumericUpDown()
        Me.Guna2HtmlLabel12 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.PAG_CierreCaja = New System.Windows.Forms.TabPage()
        Me.TBL_DivCierreCaja = New System.Windows.Forms.TableLayoutPanel()
        Me.PAN_EfectivoReal = New Guna.UI2.WinForms.Guna2Panel()
        Me.TBL_IngresoEfectivoReal = New System.Windows.Forms.TableLayoutPanel()
        Me.PAN_Moneda5 = New Guna.UI2.WinForms.Guna2Panel()
        Me.NUD_Moneda5 = New Guna.UI2.WinForms.Guna2NumericUpDown()
        Me.Guna2HtmlLabel28 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.PAN_Billete1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.NUD_Billete1 = New Guna.UI2.WinForms.Guna2NumericUpDown()
        Me.Guna2HtmlLabel22 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.PAN_Moneda10 = New Guna.UI2.WinForms.Guna2Panel()
        Me.NUD_Moneda10 = New Guna.UI2.WinForms.Guna2NumericUpDown()
        Me.Guna2HtmlLabel27 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.PAN_Billete2 = New Guna.UI2.WinForms.Guna2Panel()
        Me.NUD_Billete2 = New Guna.UI2.WinForms.Guna2NumericUpDown()
        Me.Guna2HtmlLabel21 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.PAN_Moneda25 = New Guna.UI2.WinForms.Guna2Panel()
        Me.NUD_Moneda25 = New Guna.UI2.WinForms.Guna2NumericUpDown()
        Me.Guna2HtmlLabel26 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.PAN_Billete5 = New Guna.UI2.WinForms.Guna2Panel()
        Me.NUD_Billete5 = New Guna.UI2.WinForms.Guna2NumericUpDown()
        Me.Guna2HtmlLabel20 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2Panel6 = New Guna.UI2.WinForms.Guna2Panel()
        Me.PAN_Moneda50 = New Guna.UI2.WinForms.Guna2Panel()
        Me.NUD_Moneda50 = New Guna.UI2.WinForms.Guna2NumericUpDown()
        Me.Guna2HtmlLabel25 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.PAN_Billete10 = New Guna.UI2.WinForms.Guna2Panel()
        Me.NUD_Billete10 = New Guna.UI2.WinForms.Guna2NumericUpDown()
        Me.Guna2HtmlLabel19 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.PAN_Moneda100 = New Guna.UI2.WinForms.Guna2Panel()
        Me.NUD_Moneda100 = New Guna.UI2.WinForms.Guna2NumericUpDown()
        Me.Guna2HtmlLabel24 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.PAN_Billete20 = New Guna.UI2.WinForms.Guna2Panel()
        Me.NUD_Billete20 = New Guna.UI2.WinForms.Guna2NumericUpDown()
        Me.Guna2HtmlLabel18 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.PAN_Moneda500 = New Guna.UI2.WinForms.Guna2Panel()
        Me.NUD_Moneda500 = New Guna.UI2.WinForms.Guna2NumericUpDown()
        Me.Guna2HtmlLabel23 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.PAN_Billete50 = New Guna.UI2.WinForms.Guna2Panel()
        Me.NUD_Billete50 = New Guna.UI2.WinForms.Guna2NumericUpDown()
        Me.Guna2HtmlLabel17 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.PAN_FooterEfectivoReal = New Guna.UI2.WinForms.Guna2Panel()
        Me.TXT_EfectivoReal = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2HtmlLabel29 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.PAN_HeaderEfectivoReal = New Guna.UI2.WinForms.Guna2Panel()
        Me.TableLayoutPanel5 = New System.Windows.Forms.TableLayoutPanel()
        Me.BTN_VerCierres = New Guna.UI2.WinForms.Guna2Button()
        Me.BTN_CCLimpiarCierre = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2HtmlLabel16 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.PAN_Cell2InfoCierre = New Guna.UI2.WinForms.Guna2Panel()
        Me.BTN_CalcularSaldoSiguiente = New Guna.UI2.WinForms.Guna2Button()
        Me.TableLayoutPanel4 = New System.Windows.Forms.TableLayoutPanel()
        Me.Guna2HtmlLabel39 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel33 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.NUD_SalidasEfectivo = New Guna.UI2.WinForms.Guna2NumericUpDown()
        Me.TXT_CCTotalEsperado = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2GroupBox5 = New Guna.UI2.WinForms.Guna2GroupBox()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.Guna2Panel3 = New Guna.UI2.WinForms.Guna2Panel()
        Me.TXT_CCDiferenciaAbsoluta = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2HtmlLabel35 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2Panel4 = New Guna.UI2.WinForms.Guna2Panel()
        Me.TXT_CCDiferenciaPorcentual = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2HtmlLabel38 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.TXT_CCComentario = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2HtmlLabel37 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.NUD_CCSaldoSiguienteTurno = New Guna.UI2.WinForms.Guna2NumericUpDown()
        Me.Guna2HtmlLabel36 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2Panel2 = New Guna.UI2.WinForms.Guna2Panel()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.Guna2Button3 = New Guna.UI2.WinForms.Guna2Button()
        Me.BTN_GenerarCierre = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2GroupBox4 = New Guna.UI2.WinForms.Guna2GroupBox()
        Me.TXT_CCVentaTarjeta = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2HtmlLabel32 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.TXT_CCVentaEfectivo = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2HtmlLabel31 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.TXT_CCSaldoInicial = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2HtmlLabel30 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.PrintDocument = New System.Drawing.Printing.PrintDocument()
        Me.PrintDialog = New System.Windows.Forms.PrintDialog()
        Me.TAB_Reportes.SuspendLayout()
        Me.PAG_ReporteVentas.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.Guna2GroupBox1.SuspendLayout()
        Me.Guna2GroupBox2.SuspendLayout()
        Me.Guna2Panel1.SuspendLayout()
        CType(Me.DGV_FactReporte, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MNU_CONTX.SuspendLayout()
        Me.PAG_ReporteProd.SuspendLayout()
        Me.TBL_ReporteProductosGeneral.SuspendLayout()
        Me.TBL_ResultContainer.SuspendLayout()
        Me.GBX_ListaProductoCompleta.SuspendLayout()
        CType(Me.DGV_ListProductosMasVendidos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.DGV_MejorProducto.SuspendLayout()
        Me.PAN_ReporteProductoInputContainer.SuspendLayout()
        Me.Guna2GroupBox3.SuspendLayout()
        CType(Me.RDB_OrderByCant, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RDB_OrderByTotal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NUD_LimitReporteProducto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PAG_CierreCaja.SuspendLayout()
        Me.TBL_DivCierreCaja.SuspendLayout()
        Me.PAN_EfectivoReal.SuspendLayout()
        Me.TBL_IngresoEfectivoReal.SuspendLayout()
        Me.PAN_Moneda5.SuspendLayout()
        CType(Me.NUD_Moneda5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PAN_Billete1.SuspendLayout()
        CType(Me.NUD_Billete1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PAN_Moneda10.SuspendLayout()
        CType(Me.NUD_Moneda10, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PAN_Billete2.SuspendLayout()
        CType(Me.NUD_Billete2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PAN_Moneda25.SuspendLayout()
        CType(Me.NUD_Moneda25, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PAN_Billete5.SuspendLayout()
        CType(Me.NUD_Billete5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Guna2Panel6.SuspendLayout()
        Me.PAN_Moneda50.SuspendLayout()
        CType(Me.NUD_Moneda50, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PAN_Billete10.SuspendLayout()
        CType(Me.NUD_Billete10, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PAN_Moneda100.SuspendLayout()
        CType(Me.NUD_Moneda100, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PAN_Billete20.SuspendLayout()
        CType(Me.NUD_Billete20, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PAN_Moneda500.SuspendLayout()
        CType(Me.NUD_Moneda500, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PAN_Billete50.SuspendLayout()
        CType(Me.NUD_Billete50, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PAN_FooterEfectivoReal.SuspendLayout()
        Me.PAN_HeaderEfectivoReal.SuspendLayout()
        Me.TableLayoutPanel5.SuspendLayout()
        Me.PAN_Cell2InfoCierre.SuspendLayout()
        Me.TableLayoutPanel4.SuspendLayout()
        CType(Me.NUD_SalidasEfectivo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Guna2GroupBox5.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
        Me.Guna2Panel3.SuspendLayout()
        Me.Guna2Panel4.SuspendLayout()
        CType(Me.NUD_CCSaldoSiguienteTurno, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Guna2Panel2.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.Guna2GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'TAB_Reportes
        '
        Me.TAB_Reportes.Controls.Add(Me.PAG_ReporteVentas)
        Me.TAB_Reportes.Controls.Add(Me.PAG_ReporteProd)
        Me.TAB_Reportes.Controls.Add(Me.PAG_CierreCaja)
        Me.TAB_Reportes.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TAB_Reportes.ItemSize = New System.Drawing.Size(180, 40)
        Me.TAB_Reportes.Location = New System.Drawing.Point(0, 0)
        Me.TAB_Reportes.Name = "TAB_Reportes"
        Me.TAB_Reportes.SelectedIndex = 0
        Me.TAB_Reportes.Size = New System.Drawing.Size(1254, 754)
        Me.TAB_Reportes.TabButtonHoverState.BorderColor = System.Drawing.Color.Empty
        Me.TAB_Reportes.TabButtonHoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.TAB_Reportes.TabButtonHoverState.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!)
        Me.TAB_Reportes.TabButtonHoverState.ForeColor = System.Drawing.Color.White
        Me.TAB_Reportes.TabButtonHoverState.InnerColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.TAB_Reportes.TabButtonIdleState.BorderColor = System.Drawing.Color.Empty
        Me.TAB_Reportes.TabButtonIdleState.FillColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.TAB_Reportes.TabButtonIdleState.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!)
        Me.TAB_Reportes.TabButtonIdleState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(156, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(167, Byte), Integer))
        Me.TAB_Reportes.TabButtonIdleState.InnerColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.TAB_Reportes.TabButtonSelectedState.BorderColor = System.Drawing.Color.Empty
        Me.TAB_Reportes.TabButtonSelectedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.TAB_Reportes.TabButtonSelectedState.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!)
        Me.TAB_Reportes.TabButtonSelectedState.ForeColor = System.Drawing.Color.White
        Me.TAB_Reportes.TabButtonSelectedState.InnerColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.TAB_Reportes.TabButtonSize = New System.Drawing.Size(180, 40)
        Me.TAB_Reportes.TabIndex = 0
        Me.TAB_Reportes.TabMenuBackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.TAB_Reportes.TabMenuOrientation = Guna.UI2.WinForms.TabMenuOrientation.HorizontalTop
        '
        'PAG_ReporteVentas
        '
        Me.PAG_ReporteVentas.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.PAG_ReporteVentas.Controls.Add(Me.TableLayoutPanel1)
        Me.PAG_ReporteVentas.Controls.Add(Me.Guna2HtmlLabel2)
        Me.PAG_ReporteVentas.Controls.Add(Me.Guna2HtmlLabel1)
        Me.PAG_ReporteVentas.Controls.Add(Me.LBL_Usu)
        Me.PAG_ReporteVentas.Controls.Add(Me.TXT_TotalVentas)
        Me.PAG_ReporteVentas.Controls.Add(Me.Guna2Panel1)
        Me.PAG_ReporteVentas.Controls.Add(Me.DTP_Hasta)
        Me.PAG_ReporteVentas.Controls.Add(Me.DTP_Desde)
        Me.PAG_ReporteVentas.Controls.Add(Me.DGV_FactReporte)
        Me.PAG_ReporteVentas.Location = New System.Drawing.Point(4, 44)
        Me.PAG_ReporteVentas.Name = "PAG_ReporteVentas"
        Me.PAG_ReporteVentas.Padding = New System.Windows.Forms.Padding(3)
        Me.PAG_ReporteVentas.Size = New System.Drawing.Size(1246, 706)
        Me.PAG_ReporteVentas.TabIndex = 0
        Me.PAG_ReporteVentas.Text = "Reporte de ventas"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.Guna2GroupBox1, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Guna2GroupBox2, 1, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(1240, 179)
        Me.TableLayoutPanel1.TabIndex = 139
        '
        'Guna2GroupBox1
        '
        Me.Guna2GroupBox1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Guna2GroupBox1.BorderRadius = 20
        Me.Guna2GroupBox1.Controls.Add(Me.TXT_CantProdMasVendido)
        Me.Guna2GroupBox1.Controls.Add(Me.TXT_TotalProdMasVendido)
        Me.Guna2GroupBox1.Controls.Add(Me.Guna2HtmlLabel9)
        Me.Guna2GroupBox1.Controls.Add(Me.Guna2HtmlLabel8)
        Me.Guna2GroupBox1.Controls.Add(Me.Guna2HtmlLabel6)
        Me.Guna2GroupBox1.Controls.Add(Me.TXT_NombreProdMasVendido)
        Me.Guna2GroupBox1.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Guna2GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Guna2GroupBox1.FillColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.Guna2GroupBox1.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2GroupBox1.ForeColor = System.Drawing.Color.White
        Me.Guna2GroupBox1.Location = New System.Drawing.Point(3, 3)
        Me.Guna2GroupBox1.Name = "Guna2GroupBox1"
        Me.Guna2GroupBox1.Size = New System.Drawing.Size(614, 173)
        Me.Guna2GroupBox1.TabIndex = 137
        Me.Guna2GroupBox1.Text = "Producto más vendido:"
        Me.Guna2GroupBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TXT_CantProdMasVendido
        '
        Me.TXT_CantProdMasVendido.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TXT_CantProdMasVendido.BorderRadius = 10
        Me.TXT_CantProdMasVendido.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TXT_CantProdMasVendido.DefaultText = ""
        Me.TXT_CantProdMasVendido.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TXT_CantProdMasVendido.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TXT_CantProdMasVendido.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXT_CantProdMasVendido.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXT_CantProdMasVendido.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXT_CantProdMasVendido.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.TXT_CantProdMasVendido.ForeColor = System.Drawing.Color.Black
        Me.TXT_CantProdMasVendido.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXT_CantProdMasVendido.IconRightSize = New System.Drawing.Size(40, 40)
        Me.TXT_CantProdMasVendido.Location = New System.Drawing.Point(438, 110)
        Me.TXT_CantProdMasVendido.Name = "TXT_CantProdMasVendido"
        Me.TXT_CantProdMasVendido.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TXT_CantProdMasVendido.PlaceholderText = ""
        Me.TXT_CantProdMasVendido.ReadOnly = True
        Me.TXT_CantProdMasVendido.SelectedText = ""
        Me.TXT_CantProdMasVendido.Size = New System.Drawing.Size(125, 42)
        Me.TXT_CantProdMasVendido.TabIndex = 142
        '
        'TXT_TotalProdMasVendido
        '
        Me.TXT_TotalProdMasVendido.BorderRadius = 10
        Me.TXT_TotalProdMasVendido.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TXT_TotalProdMasVendido.DefaultText = ""
        Me.TXT_TotalProdMasVendido.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TXT_TotalProdMasVendido.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TXT_TotalProdMasVendido.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXT_TotalProdMasVendido.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXT_TotalProdMasVendido.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXT_TotalProdMasVendido.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.TXT_TotalProdMasVendido.ForeColor = System.Drawing.Color.Black
        Me.TXT_TotalProdMasVendido.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXT_TotalProdMasVendido.IconRightSize = New System.Drawing.Size(40, 40)
        Me.TXT_TotalProdMasVendido.Location = New System.Drawing.Point(95, 110)
        Me.TXT_TotalProdMasVendido.Name = "TXT_TotalProdMasVendido"
        Me.TXT_TotalProdMasVendido.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TXT_TotalProdMasVendido.PlaceholderText = ""
        Me.TXT_TotalProdMasVendido.ReadOnly = True
        Me.TXT_TotalProdMasVendido.SelectedText = ""
        Me.TXT_TotalProdMasVendido.Size = New System.Drawing.Size(210, 42)
        Me.TXT_TotalProdMasVendido.TabIndex = 141
        '
        'Guna2HtmlLabel9
        '
        Me.Guna2HtmlLabel9.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel9.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel9.ForeColor = System.Drawing.SystemColors.Control
        Me.Guna2HtmlLabel9.Location = New System.Drawing.Point(327, 114)
        Me.Guna2HtmlLabel9.Name = "Guna2HtmlLabel9"
        Me.Guna2HtmlLabel9.Size = New System.Drawing.Size(105, 34)
        Me.Guna2HtmlLabel9.TabIndex = 140
        Me.Guna2HtmlLabel9.Text = "Cantidad"
        Me.Guna2HtmlLabel9.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit
        '
        'Guna2HtmlLabel8
        '
        Me.Guna2HtmlLabel8.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel8.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel8.ForeColor = System.Drawing.SystemColors.Control
        Me.Guna2HtmlLabel8.Location = New System.Drawing.Point(21, 114)
        Me.Guna2HtmlLabel8.Name = "Guna2HtmlLabel8"
        Me.Guna2HtmlLabel8.Size = New System.Drawing.Size(68, 34)
        Me.Guna2HtmlLabel8.TabIndex = 139
        Me.Guna2HtmlLabel8.Text = "Total:"
        Me.Guna2HtmlLabel8.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit
        '
        'Guna2HtmlLabel6
        '
        Me.Guna2HtmlLabel6.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel6.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel6.ForeColor = System.Drawing.SystemColors.Control
        Me.Guna2HtmlLabel6.Location = New System.Drawing.Point(21, 52)
        Me.Guna2HtmlLabel6.Name = "Guna2HtmlLabel6"
        Me.Guna2HtmlLabel6.Size = New System.Drawing.Size(104, 34)
        Me.Guna2HtmlLabel6.TabIndex = 138
        Me.Guna2HtmlLabel6.Text = "Nombre:"
        Me.Guna2HtmlLabel6.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit
        '
        'TXT_NombreProdMasVendido
        '
        Me.TXT_NombreProdMasVendido.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TXT_NombreProdMasVendido.BorderRadius = 10
        Me.TXT_NombreProdMasVendido.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TXT_NombreProdMasVendido.DefaultText = ""
        Me.TXT_NombreProdMasVendido.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TXT_NombreProdMasVendido.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TXT_NombreProdMasVendido.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXT_NombreProdMasVendido.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXT_NombreProdMasVendido.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXT_NombreProdMasVendido.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.TXT_NombreProdMasVendido.ForeColor = System.Drawing.Color.Black
        Me.TXT_NombreProdMasVendido.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXT_NombreProdMasVendido.IconRightSize = New System.Drawing.Size(40, 40)
        Me.TXT_NombreProdMasVendido.Location = New System.Drawing.Point(141, 48)
        Me.TXT_NombreProdMasVendido.Name = "TXT_NombreProdMasVendido"
        Me.TXT_NombreProdMasVendido.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TXT_NombreProdMasVendido.PlaceholderText = ""
        Me.TXT_NombreProdMasVendido.ReadOnly = True
        Me.TXT_NombreProdMasVendido.SelectedText = ""
        Me.TXT_NombreProdMasVendido.Size = New System.Drawing.Size(422, 42)
        Me.TXT_NombreProdMasVendido.TabIndex = 135
        '
        'Guna2GroupBox2
        '
        Me.Guna2GroupBox2.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Guna2GroupBox2.BorderRadius = 20
        Me.Guna2GroupBox2.Controls.Add(Me.TXT_CantFacturas)
        Me.Guna2GroupBox2.Controls.Add(Me.Guna2HtmlLabel5)
        Me.Guna2GroupBox2.Controls.Add(Me.Guna2HtmlLabel4)
        Me.Guna2GroupBox2.Controls.Add(Me.TXT_VentasEfectivo)
        Me.Guna2GroupBox2.Controls.Add(Me.TXT_VentasTarjeta)
        Me.Guna2GroupBox2.Controls.Add(Me.Guna2HtmlLabel3)
        Me.Guna2GroupBox2.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Guna2GroupBox2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Guna2GroupBox2.FillColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.Guna2GroupBox2.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2GroupBox2.ForeColor = System.Drawing.Color.White
        Me.Guna2GroupBox2.Location = New System.Drawing.Point(623, 3)
        Me.Guna2GroupBox2.Name = "Guna2GroupBox2"
        Me.Guna2GroupBox2.Size = New System.Drawing.Size(614, 173)
        Me.Guna2GroupBox2.TabIndex = 138
        Me.Guna2GroupBox2.Text = "Información de ventas"
        Me.Guna2GroupBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TXT_CantFacturas
        '
        Me.TXT_CantFacturas.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TXT_CantFacturas.BorderRadius = 10
        Me.TXT_CantFacturas.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TXT_CantFacturas.DefaultText = ""
        Me.TXT_CantFacturas.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TXT_CantFacturas.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TXT_CantFacturas.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXT_CantFacturas.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXT_CantFacturas.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXT_CantFacturas.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.TXT_CantFacturas.ForeColor = System.Drawing.Color.Black
        Me.TXT_CantFacturas.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXT_CantFacturas.IconRightSize = New System.Drawing.Size(40, 40)
        Me.TXT_CantFacturas.Location = New System.Drawing.Point(233, 48)
        Me.TXT_CantFacturas.Name = "TXT_CantFacturas"
        Me.TXT_CantFacturas.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TXT_CantFacturas.PlaceholderText = ""
        Me.TXT_CantFacturas.ReadOnly = True
        Me.TXT_CantFacturas.SelectedText = ""
        Me.TXT_CantFacturas.Size = New System.Drawing.Size(364, 42)
        Me.TXT_CantFacturas.TabIndex = 133
        '
        'Guna2HtmlLabel5
        '
        Me.Guna2HtmlLabel5.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel5.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel5.ForeColor = System.Drawing.SystemColors.Control
        Me.Guna2HtmlLabel5.Location = New System.Drawing.Point(18, 51)
        Me.Guna2HtmlLabel5.Name = "Guna2HtmlLabel5"
        Me.Guna2HtmlLabel5.Size = New System.Drawing.Size(209, 34)
        Me.Guna2HtmlLabel5.TabIndex = 134
        Me.Guna2HtmlLabel5.Text = "Facturas emitidas:"
        Me.Guna2HtmlLabel5.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit
        '
        'Guna2HtmlLabel4
        '
        Me.Guna2HtmlLabel4.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel4.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel4.ForeColor = System.Drawing.SystemColors.Control
        Me.Guna2HtmlLabel4.Location = New System.Drawing.Point(331, 114)
        Me.Guna2HtmlLabel4.Name = "Guna2HtmlLabel4"
        Me.Guna2HtmlLabel4.Size = New System.Drawing.Size(89, 34)
        Me.Guna2HtmlLabel4.TabIndex = 132
        Me.Guna2HtmlLabel4.Text = "Tarjeta:"
        Me.Guna2HtmlLabel4.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit
        '
        'TXT_VentasEfectivo
        '
        Me.TXT_VentasEfectivo.BorderRadius = 10
        Me.TXT_VentasEfectivo.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TXT_VentasEfectivo.DefaultText = ""
        Me.TXT_VentasEfectivo.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TXT_VentasEfectivo.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TXT_VentasEfectivo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXT_VentasEfectivo.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXT_VentasEfectivo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXT_VentasEfectivo.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.TXT_VentasEfectivo.ForeColor = System.Drawing.Color.Black
        Me.TXT_VentasEfectivo.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXT_VentasEfectivo.IconRightSize = New System.Drawing.Size(40, 40)
        Me.TXT_VentasEfectivo.Location = New System.Drawing.Point(119, 110)
        Me.TXT_VentasEfectivo.Name = "TXT_VentasEfectivo"
        Me.TXT_VentasEfectivo.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TXT_VentasEfectivo.PlaceholderText = ""
        Me.TXT_VentasEfectivo.ReadOnly = True
        Me.TXT_VentasEfectivo.SelectedText = ""
        Me.TXT_VentasEfectivo.Size = New System.Drawing.Size(184, 42)
        Me.TXT_VentasEfectivo.TabIndex = 129
        '
        'TXT_VentasTarjeta
        '
        Me.TXT_VentasTarjeta.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TXT_VentasTarjeta.BorderRadius = 10
        Me.TXT_VentasTarjeta.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TXT_VentasTarjeta.DefaultText = ""
        Me.TXT_VentasTarjeta.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TXT_VentasTarjeta.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TXT_VentasTarjeta.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXT_VentasTarjeta.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXT_VentasTarjeta.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXT_VentasTarjeta.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.TXT_VentasTarjeta.ForeColor = System.Drawing.Color.Black
        Me.TXT_VentasTarjeta.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXT_VentasTarjeta.IconRightSize = New System.Drawing.Size(40, 40)
        Me.TXT_VentasTarjeta.Location = New System.Drawing.Point(424, 110)
        Me.TXT_VentasTarjeta.Name = "TXT_VentasTarjeta"
        Me.TXT_VentasTarjeta.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TXT_VentasTarjeta.PlaceholderText = ""
        Me.TXT_VentasTarjeta.ReadOnly = True
        Me.TXT_VentasTarjeta.SelectedText = ""
        Me.TXT_VentasTarjeta.Size = New System.Drawing.Size(173, 42)
        Me.TXT_VentasTarjeta.TabIndex = 131
        '
        'Guna2HtmlLabel3
        '
        Me.Guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel3.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel3.ForeColor = System.Drawing.SystemColors.Control
        Me.Guna2HtmlLabel3.Location = New System.Drawing.Point(12, 114)
        Me.Guna2HtmlLabel3.Name = "Guna2HtmlLabel3"
        Me.Guna2HtmlLabel3.Size = New System.Drawing.Size(101, 34)
        Me.Guna2HtmlLabel3.TabIndex = 130
        Me.Guna2HtmlLabel3.Text = "Efectivo:"
        Me.Guna2HtmlLabel3.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit
        '
        'Guna2HtmlLabel2
        '
        Me.Guna2HtmlLabel2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel2.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel2.ForeColor = System.Drawing.SystemColors.Control
        Me.Guna2HtmlLabel2.Location = New System.Drawing.Point(938, 214)
        Me.Guna2HtmlLabel2.Name = "Guna2HtmlLabel2"
        Me.Guna2HtmlLabel2.Size = New System.Drawing.Size(68, 34)
        Me.Guna2HtmlLabel2.TabIndex = 128
        Me.Guna2HtmlLabel2.Text = "Total:"
        Me.Guna2HtmlLabel2.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit
        '
        'Guna2HtmlLabel1
        '
        Me.Guna2HtmlLabel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel1.ForeColor = System.Drawing.SystemColors.Control
        Me.Guna2HtmlLabel1.Location = New System.Drawing.Point(937, 364)
        Me.Guna2HtmlLabel1.Name = "Guna2HtmlLabel1"
        Me.Guna2HtmlLabel1.Size = New System.Drawing.Size(50, 23)
        Me.Guna2HtmlLabel1.TabIndex = 127
        Me.Guna2HtmlLabel1.Text = "Hasta:"
        Me.Guna2HtmlLabel1.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit
        '
        'LBL_Usu
        '
        Me.LBL_Usu.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LBL_Usu.BackColor = System.Drawing.Color.Transparent
        Me.LBL_Usu.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_Usu.ForeColor = System.Drawing.SystemColors.Control
        Me.LBL_Usu.Location = New System.Drawing.Point(937, 245)
        Me.LBL_Usu.Name = "LBL_Usu"
        Me.LBL_Usu.Size = New System.Drawing.Size(54, 23)
        Me.LBL_Usu.TabIndex = 126
        Me.LBL_Usu.Text = "Desde:"
        Me.LBL_Usu.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit
        '
        'TXT_TotalVentas
        '
        Me.TXT_TotalVentas.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TXT_TotalVentas.BorderRadius = 10
        Me.TXT_TotalVentas.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TXT_TotalVentas.DefaultText = ""
        Me.TXT_TotalVentas.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TXT_TotalVentas.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TXT_TotalVentas.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXT_TotalVentas.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXT_TotalVentas.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXT_TotalVentas.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.TXT_TotalVentas.ForeColor = System.Drawing.Color.Black
        Me.TXT_TotalVentas.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXT_TotalVentas.IconRightSize = New System.Drawing.Size(40, 40)
        Me.TXT_TotalVentas.Location = New System.Drawing.Point(1012, 210)
        Me.TXT_TotalVentas.Name = "TXT_TotalVentas"
        Me.TXT_TotalVentas.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TXT_TotalVentas.PlaceholderText = ""
        Me.TXT_TotalVentas.ReadOnly = True
        Me.TXT_TotalVentas.SelectedText = ""
        Me.TXT_TotalVentas.Size = New System.Drawing.Size(226, 42)
        Me.TXT_TotalVentas.TabIndex = 125
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.Controls.Add(Me.BTN_GenerarReporteVentaPDF)
        Me.Guna2Panel1.Controls.Add(Me.BTN_RegresarReporte)
        Me.Guna2Panel1.Controls.Add(Me.BTN_GenReporte)
        Me.Guna2Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Guna2Panel1.Location = New System.Drawing.Point(3, 633)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.Size = New System.Drawing.Size(1240, 70)
        Me.Guna2Panel1.TabIndex = 124
        '
        'BTN_GenerarReporteVentaPDF
        '
        Me.BTN_GenerarReporteVentaPDF.BorderColor = System.Drawing.Color.Red
        Me.BTN_GenerarReporteVentaPDF.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BTN_GenerarReporteVentaPDF.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BTN_GenerarReporteVentaPDF.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BTN_GenerarReporteVentaPDF.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BTN_GenerarReporteVentaPDF.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BTN_GenerarReporteVentaPDF.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BTN_GenerarReporteVentaPDF.Font = New System.Drawing.Font("Ebrima", 20.25!, System.Drawing.FontStyle.Bold)
        Me.BTN_GenerarReporteVentaPDF.ForeColor = System.Drawing.Color.White
        Me.BTN_GenerarReporteVentaPDF.Image = CType(resources.GetObject("BTN_GenerarReporteVentaPDF.Image"), System.Drawing.Image)
        Me.BTN_GenerarReporteVentaPDF.ImageSize = New System.Drawing.Size(50, 50)
        Me.BTN_GenerarReporteVentaPDF.Location = New System.Drawing.Point(403, 0)
        Me.BTN_GenerarReporteVentaPDF.Name = "BTN_GenerarReporteVentaPDF"
        Me.BTN_GenerarReporteVentaPDF.Size = New System.Drawing.Size(426, 70)
        Me.BTN_GenerarReporteVentaPDF.TabIndex = 84
        Me.BTN_GenerarReporteVentaPDF.Text = "Generar en PDF"
        '
        'BTN_RegresarReporte
        '
        Me.BTN_RegresarReporte.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.BTN_RegresarReporte.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BTN_RegresarReporte.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BTN_RegresarReporte.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BTN_RegresarReporte.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BTN_RegresarReporte.Dock = System.Windows.Forms.DockStyle.Left
        Me.BTN_RegresarReporte.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BTN_RegresarReporte.Font = New System.Drawing.Font("Ebrima", 20.25!, System.Drawing.FontStyle.Bold)
        Me.BTN_RegresarReporte.ForeColor = System.Drawing.Color.White
        Me.BTN_RegresarReporte.Image = CType(resources.GetObject("BTN_RegresarReporte.Image"), System.Drawing.Image)
        Me.BTN_RegresarReporte.ImageSize = New System.Drawing.Size(60, 60)
        Me.BTN_RegresarReporte.Location = New System.Drawing.Point(0, 0)
        Me.BTN_RegresarReporte.Name = "BTN_RegresarReporte"
        Me.BTN_RegresarReporte.Size = New System.Drawing.Size(403, 70)
        Me.BTN_RegresarReporte.TabIndex = 82
        Me.BTN_RegresarReporte.Text = "Regresar"
        '
        'BTN_GenReporte
        '
        Me.BTN_GenReporte.BorderColor = System.Drawing.Color.Red
        Me.BTN_GenReporte.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BTN_GenReporte.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BTN_GenReporte.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BTN_GenReporte.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BTN_GenReporte.Dock = System.Windows.Forms.DockStyle.Right
        Me.BTN_GenReporte.FillColor = System.Drawing.Color.MediumSeaGreen
        Me.BTN_GenReporte.Font = New System.Drawing.Font("Ebrima", 20.25!, System.Drawing.FontStyle.Bold)
        Me.BTN_GenReporte.ForeColor = System.Drawing.Color.White
        Me.BTN_GenReporte.Image = CType(resources.GetObject("BTN_GenReporte.Image"), System.Drawing.Image)
        Me.BTN_GenReporte.ImageSize = New System.Drawing.Size(50, 50)
        Me.BTN_GenReporte.Location = New System.Drawing.Point(829, 0)
        Me.BTN_GenReporte.Name = "BTN_GenReporte"
        Me.BTN_GenReporte.Size = New System.Drawing.Size(411, 70)
        Me.BTN_GenReporte.TabIndex = 83
        Me.BTN_GenReporte.Text = "Generar reporte"
        '
        'DTP_Hasta
        '
        Me.DTP_Hasta.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DTP_Hasta.BorderRadius = 10
        Me.DTP_Hasta.Checked = True
        Me.DTP_Hasta.FillColor = System.Drawing.Color.White
        Me.DTP_Hasta.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.DTP_Hasta.Format = System.Windows.Forms.DateTimePickerFormat.[Long]
        Me.DTP_Hasta.Location = New System.Drawing.Point(937, 393)
        Me.DTP_Hasta.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.DTP_Hasta.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.DTP_Hasta.Name = "DTP_Hasta"
        Me.DTP_Hasta.Size = New System.Drawing.Size(286, 36)
        Me.DTP_Hasta.TabIndex = 123
        Me.DTP_Hasta.Value = New Date(2025, 3, 17, 19, 28, 7, 244)
        '
        'DTP_Desde
        '
        Me.DTP_Desde.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DTP_Desde.BorderRadius = 10
        Me.DTP_Desde.Checked = True
        Me.DTP_Desde.FillColor = System.Drawing.Color.White
        Me.DTP_Desde.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.DTP_Desde.Format = System.Windows.Forms.DateTimePickerFormat.[Long]
        Me.DTP_Desde.Location = New System.Drawing.Point(937, 274)
        Me.DTP_Desde.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.DTP_Desde.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.DTP_Desde.Name = "DTP_Desde"
        Me.DTP_Desde.Size = New System.Drawing.Size(286, 36)
        Me.DTP_Desde.TabIndex = 122
        Me.DTP_Desde.Value = New Date(2025, 3, 17, 19, 28, 7, 244)
        '
        'DGV_FactReporte
        '
        Me.DGV_FactReporte.AllowUserToAddRows = False
        Me.DGV_FactReporte.AllowUserToDeleteRows = False
        Me.DGV_FactReporte.AllowUserToResizeRows = False
        DataGridViewCellStyle9.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.DGV_FactReporte.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle9
        Me.DGV_FactReporte.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle10.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGV_FactReporte.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle10
        Me.DGV_FactReporte.ColumnHeadersHeight = 20
        Me.DGV_FactReporte.ContextMenuStrip = Me.MNU_CONTX
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle11.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DGV_FactReporte.DefaultCellStyle = DataGridViewCellStyle11
        Me.DGV_FactReporte.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DGV_FactReporte.Location = New System.Drawing.Point(22, 188)
        Me.DGV_FactReporte.MultiSelect = False
        Me.DGV_FactReporte.Name = "DGV_FactReporte"
        Me.DGV_FactReporte.ReadOnly = True
        Me.DGV_FactReporte.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle12.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGV_FactReporte.RowHeadersDefaultCellStyle = DataGridViewCellStyle12
        Me.DGV_FactReporte.RowHeadersVisible = False
        Me.DGV_FactReporte.Size = New System.Drawing.Size(898, 269)
        Me.DGV_FactReporte.TabIndex = 121
        Me.DGV_FactReporte.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.DGV_FactReporte.ThemeStyle.AlternatingRowsStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DGV_FactReporte.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.SystemColors.ControlText
        Me.DGV_FactReporte.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DGV_FactReporte.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.DGV_FactReporte.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.DGV_FactReporte.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DGV_FactReporte.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.DGV_FactReporte.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.DGV_FactReporte.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DGV_FactReporte.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.DGV_FactReporte.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.DGV_FactReporte.ThemeStyle.HeaderStyle.Height = 20
        Me.DGV_FactReporte.ThemeStyle.ReadOnly = True
        Me.DGV_FactReporte.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.DGV_FactReporte.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.DGV_FactReporte.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DGV_FactReporte.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.DGV_FactReporte.ThemeStyle.RowsStyle.Height = 22
        Me.DGV_FactReporte.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DGV_FactReporte.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
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
        Me.MNU_CONTX.Size = New System.Drawing.Size(146, 56)
        '
        'MNU_REIMPRIMIR
        '
        Me.MNU_REIMPRIMIR.BackColor = System.Drawing.SystemColors.HotTrack
        Me.MNU_REIMPRIMIR.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MNU_REIMPRIMIR.ForeColor = System.Drawing.SystemColors.Control
        Me.MNU_REIMPRIMIR.Image = CType(resources.GetObject("MNU_REIMPRIMIR.Image"), System.Drawing.Image)
        Me.MNU_REIMPRIMIR.Name = "MNU_REIMPRIMIR"
        Me.MNU_REIMPRIMIR.Size = New System.Drawing.Size(145, 26)
        Me.MNU_REIMPRIMIR.Text = "Reimprimir"
        '
        'MNU_Datos
        '
        Me.MNU_Datos.BackColor = System.Drawing.Color.DarkGoldenrod
        Me.MNU_Datos.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MNU_Datos.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.MNU_Datos.Image = CType(resources.GetObject("MNU_Datos.Image"), System.Drawing.Image)
        Me.MNU_Datos.Name = "MNU_Datos"
        Me.MNU_Datos.Size = New System.Drawing.Size(145, 26)
        Me.MNU_Datos.Text = "Ver datos"
        '
        'PAG_ReporteProd
        '
        Me.PAG_ReporteProd.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.PAG_ReporteProd.Controls.Add(Me.TBL_ReporteProductosGeneral)
        Me.PAG_ReporteProd.Location = New System.Drawing.Point(4, 44)
        Me.PAG_ReporteProd.Name = "PAG_ReporteProd"
        Me.PAG_ReporteProd.Padding = New System.Windows.Forms.Padding(3)
        Me.PAG_ReporteProd.Size = New System.Drawing.Size(1246, 706)
        Me.PAG_ReporteProd.TabIndex = 1
        Me.PAG_ReporteProd.Text = "Reporte de productos"
        '
        'TBL_ReporteProductosGeneral
        '
        Me.TBL_ReporteProductosGeneral.ColumnCount = 2
        Me.TBL_ReporteProductosGeneral.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 68.46774!))
        Me.TBL_ReporteProductosGeneral.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 31.53226!))
        Me.TBL_ReporteProductosGeneral.Controls.Add(Me.TBL_ResultContainer, 0, 0)
        Me.TBL_ReporteProductosGeneral.Controls.Add(Me.PAN_ReporteProductoInputContainer, 1, 0)
        Me.TBL_ReporteProductosGeneral.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TBL_ReporteProductosGeneral.Location = New System.Drawing.Point(3, 3)
        Me.TBL_ReporteProductosGeneral.Name = "TBL_ReporteProductosGeneral"
        Me.TBL_ReporteProductosGeneral.RowCount = 1
        Me.TBL_ReporteProductosGeneral.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TBL_ReporteProductosGeneral.Size = New System.Drawing.Size(1240, 700)
        Me.TBL_ReporteProductosGeneral.TabIndex = 144
        '
        'TBL_ResultContainer
        '
        Me.TBL_ResultContainer.ColumnCount = 1
        Me.TBL_ResultContainer.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TBL_ResultContainer.Controls.Add(Me.BTN_RegresarReporteProducto, 0, 2)
        Me.TBL_ResultContainer.Controls.Add(Me.GBX_ListaProductoCompleta, 0, 0)
        Me.TBL_ResultContainer.Controls.Add(Me.DGV_MejorProducto, 0, 1)
        Me.TBL_ResultContainer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TBL_ResultContainer.Location = New System.Drawing.Point(3, 3)
        Me.TBL_ResultContainer.Name = "TBL_ResultContainer"
        Me.TBL_ResultContainer.RowCount = 3
        Me.TBL_ResultContainer.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TBL_ResultContainer.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 180.0!))
        Me.TBL_ResultContainer.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 51.0!))
        Me.TBL_ResultContainer.Size = New System.Drawing.Size(843, 694)
        Me.TBL_ResultContainer.TabIndex = 0
        '
        'BTN_RegresarReporteProducto
        '
        Me.BTN_RegresarReporteProducto.BorderRadius = 10
        Me.BTN_RegresarReporteProducto.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.BTN_RegresarReporteProducto.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BTN_RegresarReporteProducto.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BTN_RegresarReporteProducto.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BTN_RegresarReporteProducto.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BTN_RegresarReporteProducto.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BTN_RegresarReporteProducto.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BTN_RegresarReporteProducto.Font = New System.Drawing.Font("Ebrima", 20.25!, System.Drawing.FontStyle.Bold)
        Me.BTN_RegresarReporteProducto.ForeColor = System.Drawing.Color.White
        Me.BTN_RegresarReporteProducto.Image = CType(resources.GetObject("BTN_RegresarReporteProducto.Image"), System.Drawing.Image)
        Me.BTN_RegresarReporteProducto.ImageSize = New System.Drawing.Size(60, 60)
        Me.BTN_RegresarReporteProducto.Location = New System.Drawing.Point(3, 646)
        Me.BTN_RegresarReporteProducto.Name = "BTN_RegresarReporteProducto"
        Me.BTN_RegresarReporteProducto.Size = New System.Drawing.Size(837, 45)
        Me.BTN_RegresarReporteProducto.TabIndex = 144
        Me.BTN_RegresarReporteProducto.Text = "Regresar"
        '
        'GBX_ListaProductoCompleta
        '
        Me.GBX_ListaProductoCompleta.BackColor = System.Drawing.Color.Transparent
        Me.GBX_ListaProductoCompleta.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.GBX_ListaProductoCompleta.BorderRadius = 20
        Me.GBX_ListaProductoCompleta.Controls.Add(Me.DGV_ListProductosMasVendidos)
        Me.GBX_ListaProductoCompleta.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.GBX_ListaProductoCompleta.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GBX_ListaProductoCompleta.FillColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.GBX_ListaProductoCompleta.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GBX_ListaProductoCompleta.ForeColor = System.Drawing.Color.White
        Me.GBX_ListaProductoCompleta.Location = New System.Drawing.Point(3, 3)
        Me.GBX_ListaProductoCompleta.Name = "GBX_ListaProductoCompleta"
        Me.GBX_ListaProductoCompleta.ShadowDecoration.Color = System.Drawing.Color.IndianRed
        Me.GBX_ListaProductoCompleta.Size = New System.Drawing.Size(837, 457)
        Me.GBX_ListaProductoCompleta.TabIndex = 143
        Me.GBX_ListaProductoCompleta.Text = "Lista completa"
        Me.GBX_ListaProductoCompleta.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'DGV_ListProductosMasVendidos
        '
        Me.DGV_ListProductosMasVendidos.AllowUserToAddRows = False
        Me.DGV_ListProductosMasVendidos.AllowUserToDeleteRows = False
        Me.DGV_ListProductosMasVendidos.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.DGV_ListProductosMasVendidos.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGV_ListProductosMasVendidos.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DGV_ListProductosMasVendidos.ColumnHeadersHeight = 20
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DGV_ListProductosMasVendidos.DefaultCellStyle = DataGridViewCellStyle3
        Me.DGV_ListProductosMasVendidos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DGV_ListProductosMasVendidos.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DGV_ListProductosMasVendidos.Location = New System.Drawing.Point(0, 40)
        Me.DGV_ListProductosMasVendidos.MultiSelect = False
        Me.DGV_ListProductosMasVendidos.Name = "DGV_ListProductosMasVendidos"
        Me.DGV_ListProductosMasVendidos.ReadOnly = True
        Me.DGV_ListProductosMasVendidos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGV_ListProductosMasVendidos.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.DGV_ListProductosMasVendidos.RowHeadersVisible = False
        Me.DGV_ListProductosMasVendidos.Size = New System.Drawing.Size(837, 417)
        Me.DGV_ListProductosMasVendidos.TabIndex = 122
        Me.DGV_ListProductosMasVendidos.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.DGV_ListProductosMasVendidos.ThemeStyle.AlternatingRowsStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DGV_ListProductosMasVendidos.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.SystemColors.ControlText
        Me.DGV_ListProductosMasVendidos.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DGV_ListProductosMasVendidos.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.DGV_ListProductosMasVendidos.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.DGV_ListProductosMasVendidos.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DGV_ListProductosMasVendidos.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.DGV_ListProductosMasVendidos.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.DGV_ListProductosMasVendidos.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DGV_ListProductosMasVendidos.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.DGV_ListProductosMasVendidos.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.DGV_ListProductosMasVendidos.ThemeStyle.HeaderStyle.Height = 20
        Me.DGV_ListProductosMasVendidos.ThemeStyle.ReadOnly = True
        Me.DGV_ListProductosMasVendidos.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.DGV_ListProductosMasVendidos.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.DGV_ListProductosMasVendidos.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DGV_ListProductosMasVendidos.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.DGV_ListProductosMasVendidos.ThemeStyle.RowsStyle.Height = 22
        Me.DGV_ListProductosMasVendidos.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DGV_ListProductosMasVendidos.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        '
        'DGV_MejorProducto
        '
        Me.DGV_MejorProducto.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.DGV_MejorProducto.BorderRadius = 20
        Me.DGV_MejorProducto.Controls.Add(Me.TXT_MejorProductoCant)
        Me.DGV_MejorProducto.Controls.Add(Me.TXT_MejorProductoTotal)
        Me.DGV_MejorProducto.Controls.Add(Me.Guna2HtmlLabel7)
        Me.DGV_MejorProducto.Controls.Add(Me.Guna2HtmlLabel10)
        Me.DGV_MejorProducto.Controls.Add(Me.Guna2HtmlLabel11)
        Me.DGV_MejorProducto.Controls.Add(Me.TXT_MejorProductoNombre)
        Me.DGV_MejorProducto.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.DGV_MejorProducto.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DGV_MejorProducto.FillColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.DGV_MejorProducto.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DGV_MejorProducto.ForeColor = System.Drawing.Color.White
        Me.DGV_MejorProducto.Location = New System.Drawing.Point(3, 466)
        Me.DGV_MejorProducto.Name = "DGV_MejorProducto"
        Me.DGV_MejorProducto.Size = New System.Drawing.Size(837, 174)
        Me.DGV_MejorProducto.TabIndex = 138
        Me.DGV_MejorProducto.Text = "Producto más vendido:"
        Me.DGV_MejorProducto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TXT_MejorProductoCant
        '
        Me.TXT_MejorProductoCant.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TXT_MejorProductoCant.BorderRadius = 10
        Me.TXT_MejorProductoCant.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TXT_MejorProductoCant.DefaultText = ""
        Me.TXT_MejorProductoCant.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TXT_MejorProductoCant.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TXT_MejorProductoCant.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXT_MejorProductoCant.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXT_MejorProductoCant.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXT_MejorProductoCant.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.TXT_MejorProductoCant.ForeColor = System.Drawing.Color.Black
        Me.TXT_MejorProductoCant.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXT_MejorProductoCant.IconRightSize = New System.Drawing.Size(40, 40)
        Me.TXT_MejorProductoCant.Location = New System.Drawing.Point(438, 110)
        Me.TXT_MejorProductoCant.Name = "TXT_MejorProductoCant"
        Me.TXT_MejorProductoCant.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TXT_MejorProductoCant.PlaceholderText = ""
        Me.TXT_MejorProductoCant.ReadOnly = True
        Me.TXT_MejorProductoCant.SelectedText = ""
        Me.TXT_MejorProductoCant.Size = New System.Drawing.Size(367, 42)
        Me.TXT_MejorProductoCant.TabIndex = 142
        '
        'TXT_MejorProductoTotal
        '
        Me.TXT_MejorProductoTotal.BorderRadius = 10
        Me.TXT_MejorProductoTotal.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TXT_MejorProductoTotal.DefaultText = ""
        Me.TXT_MejorProductoTotal.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TXT_MejorProductoTotal.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TXT_MejorProductoTotal.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXT_MejorProductoTotal.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXT_MejorProductoTotal.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXT_MejorProductoTotal.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.TXT_MejorProductoTotal.ForeColor = System.Drawing.Color.Black
        Me.TXT_MejorProductoTotal.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXT_MejorProductoTotal.IconRightSize = New System.Drawing.Size(40, 40)
        Me.TXT_MejorProductoTotal.Location = New System.Drawing.Point(95, 110)
        Me.TXT_MejorProductoTotal.Name = "TXT_MejorProductoTotal"
        Me.TXT_MejorProductoTotal.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TXT_MejorProductoTotal.PlaceholderText = ""
        Me.TXT_MejorProductoTotal.ReadOnly = True
        Me.TXT_MejorProductoTotal.SelectedText = ""
        Me.TXT_MejorProductoTotal.Size = New System.Drawing.Size(210, 42)
        Me.TXT_MejorProductoTotal.TabIndex = 141
        '
        'Guna2HtmlLabel7
        '
        Me.Guna2HtmlLabel7.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel7.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel7.ForeColor = System.Drawing.SystemColors.Control
        Me.Guna2HtmlLabel7.Location = New System.Drawing.Point(327, 114)
        Me.Guna2HtmlLabel7.Name = "Guna2HtmlLabel7"
        Me.Guna2HtmlLabel7.Size = New System.Drawing.Size(105, 34)
        Me.Guna2HtmlLabel7.TabIndex = 140
        Me.Guna2HtmlLabel7.Text = "Cantidad"
        Me.Guna2HtmlLabel7.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit
        '
        'Guna2HtmlLabel10
        '
        Me.Guna2HtmlLabel10.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel10.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel10.ForeColor = System.Drawing.SystemColors.Control
        Me.Guna2HtmlLabel10.Location = New System.Drawing.Point(21, 114)
        Me.Guna2HtmlLabel10.Name = "Guna2HtmlLabel10"
        Me.Guna2HtmlLabel10.Size = New System.Drawing.Size(68, 34)
        Me.Guna2HtmlLabel10.TabIndex = 139
        Me.Guna2HtmlLabel10.Text = "Total:"
        Me.Guna2HtmlLabel10.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit
        '
        'Guna2HtmlLabel11
        '
        Me.Guna2HtmlLabel11.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel11.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel11.ForeColor = System.Drawing.SystemColors.Control
        Me.Guna2HtmlLabel11.Location = New System.Drawing.Point(21, 52)
        Me.Guna2HtmlLabel11.Name = "Guna2HtmlLabel11"
        Me.Guna2HtmlLabel11.Size = New System.Drawing.Size(104, 34)
        Me.Guna2HtmlLabel11.TabIndex = 138
        Me.Guna2HtmlLabel11.Text = "Nombre:"
        Me.Guna2HtmlLabel11.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit
        '
        'TXT_MejorProductoNombre
        '
        Me.TXT_MejorProductoNombre.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TXT_MejorProductoNombre.BorderRadius = 10
        Me.TXT_MejorProductoNombre.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TXT_MejorProductoNombre.DefaultText = ""
        Me.TXT_MejorProductoNombre.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TXT_MejorProductoNombre.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TXT_MejorProductoNombre.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXT_MejorProductoNombre.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXT_MejorProductoNombre.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXT_MejorProductoNombre.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.TXT_MejorProductoNombre.ForeColor = System.Drawing.Color.Black
        Me.TXT_MejorProductoNombre.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXT_MejorProductoNombre.IconRightSize = New System.Drawing.Size(40, 40)
        Me.TXT_MejorProductoNombre.Location = New System.Drawing.Point(141, 48)
        Me.TXT_MejorProductoNombre.Name = "TXT_MejorProductoNombre"
        Me.TXT_MejorProductoNombre.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TXT_MejorProductoNombre.PlaceholderText = ""
        Me.TXT_MejorProductoNombre.ReadOnly = True
        Me.TXT_MejorProductoNombre.SelectedText = ""
        Me.TXT_MejorProductoNombre.Size = New System.Drawing.Size(664, 42)
        Me.TXT_MejorProductoNombre.TabIndex = 135
        '
        'PAN_ReporteProductoInputContainer
        '
        Me.PAN_ReporteProductoInputContainer.Controls.Add(Me.Guna2GroupBox3)
        Me.PAN_ReporteProductoInputContainer.Controls.Add(Me.Guna2HtmlLabel15)
        Me.PAN_ReporteProductoInputContainer.Controls.Add(Me.BTN_GenReporteProductos)
        Me.PAN_ReporteProductoInputContainer.Controls.Add(Me.Guna2HtmlLabel13)
        Me.PAN_ReporteProductoInputContainer.Controls.Add(Me.Guna2HtmlLabel14)
        Me.PAN_ReporteProductoInputContainer.Controls.Add(Me.DTP_HastaReporteProducto)
        Me.PAN_ReporteProductoInputContainer.Controls.Add(Me.DTP_DesdeReporteProducto)
        Me.PAN_ReporteProductoInputContainer.Controls.Add(Me.NUD_LimitReporteProducto)
        Me.PAN_ReporteProductoInputContainer.Controls.Add(Me.Guna2HtmlLabel12)
        Me.PAN_ReporteProductoInputContainer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PAN_ReporteProductoInputContainer.Location = New System.Drawing.Point(852, 3)
        Me.PAN_ReporteProductoInputContainer.Name = "PAN_ReporteProductoInputContainer"
        Me.PAN_ReporteProductoInputContainer.Size = New System.Drawing.Size(385, 694)
        Me.PAN_ReporteProductoInputContainer.TabIndex = 1
        '
        'Guna2GroupBox3
        '
        Me.Guna2GroupBox3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Guna2GroupBox3.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Guna2GroupBox3.BorderRadius = 20
        Me.Guna2GroupBox3.Controls.Add(Me.RDB_OrderByCant)
        Me.Guna2GroupBox3.Controls.Add(Me.RDB_OrderByTotal)
        Me.Guna2GroupBox3.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Guna2GroupBox3.FillColor = System.Drawing.Color.Transparent
        Me.Guna2GroupBox3.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2GroupBox3.ForeColor = System.Drawing.Color.White
        Me.Guna2GroupBox3.Location = New System.Drawing.Point(55, 469)
        Me.Guna2GroupBox3.Name = "Guna2GroupBox3"
        Me.Guna2GroupBox3.Padding = New System.Windows.Forms.Padding(10, 10, 10, 5)
        Me.Guna2GroupBox3.Size = New System.Drawing.Size(282, 114)
        Me.Guna2GroupBox3.TabIndex = 152
        Me.Guna2GroupBox3.Text = "Ordenar por:"
        Me.Guna2GroupBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'RDB_OrderByCant
        '
        Me.RDB_OrderByCant.AccessibilityEnabled = True
        Me.RDB_OrderByCant.BeforeTouchSize = New System.Drawing.Size(262, 34)
        Me.RDB_OrderByCant.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.RDB_OrderByCant.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RDB_OrderByCant.ForeColor = System.Drawing.Color.White
        Me.RDB_OrderByCant.Location = New System.Drawing.Point(10, 41)
        Me.RDB_OrderByCant.MetroColor = System.Drawing.Color.FromArgb(CType(CType(88, Byte), Integer), CType(CType(89, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.RDB_OrderByCant.Name = "RDB_OrderByCant"
        Me.RDB_OrderByCant.Size = New System.Drawing.Size(262, 34)
        Me.RDB_OrderByCant.TabIndex = 1
        Me.RDB_OrderByCant.Text = "Cantidad"
        '
        'RDB_OrderByTotal
        '
        Me.RDB_OrderByTotal.AccessibilityEnabled = True
        Me.RDB_OrderByTotal.BeforeTouchSize = New System.Drawing.Size(262, 34)
        Me.RDB_OrderByTotal.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.RDB_OrderByTotal.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RDB_OrderByTotal.ForeColor = System.Drawing.Color.White
        Me.RDB_OrderByTotal.Location = New System.Drawing.Point(10, 75)
        Me.RDB_OrderByTotal.MetroColor = System.Drawing.Color.FromArgb(CType(CType(88, Byte), Integer), CType(CType(89, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.RDB_OrderByTotal.Name = "RDB_OrderByTotal"
        Me.RDB_OrderByTotal.Size = New System.Drawing.Size(262, 34)
        Me.RDB_OrderByTotal.TabIndex = 0
        Me.RDB_OrderByTotal.Text = "Total de ventas"
        '
        'Guna2HtmlLabel15
        '
        Me.Guna2HtmlLabel15.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Guna2HtmlLabel15.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel15.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel15.ForeColor = System.Drawing.SystemColors.Control
        Me.Guna2HtmlLabel15.Location = New System.Drawing.Point(65, 43)
        Me.Guna2HtmlLabel15.Name = "Guna2HtmlLabel15"
        Me.Guna2HtmlLabel15.Size = New System.Drawing.Size(272, 34)
        Me.Guna2HtmlLabel15.TabIndex = 151
        Me.Guna2HtmlLabel15.Text = "Ingreso de información"
        Me.Guna2HtmlLabel15.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit
        '
        'BTN_GenReporteProductos
        '
        Me.BTN_GenReporteProductos.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BTN_GenReporteProductos.BackColor = System.Drawing.Color.Transparent
        Me.BTN_GenReporteProductos.BorderColor = System.Drawing.Color.Red
        Me.BTN_GenReporteProductos.BorderRadius = 10
        Me.BTN_GenReporteProductos.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BTN_GenReporteProductos.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BTN_GenReporteProductos.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BTN_GenReporteProductos.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BTN_GenReporteProductos.FillColor = System.Drawing.Color.MediumSeaGreen
        Me.BTN_GenReporteProductos.Font = New System.Drawing.Font("Ebrima", 20.25!, System.Drawing.FontStyle.Bold)
        Me.BTN_GenReporteProductos.ForeColor = System.Drawing.Color.White
        Me.BTN_GenReporteProductos.Image = CType(resources.GetObject("BTN_GenReporteProductos.Image"), System.Drawing.Image)
        Me.BTN_GenReporteProductos.ImageSize = New System.Drawing.Size(50, 50)
        Me.BTN_GenReporteProductos.Location = New System.Drawing.Point(0, 640)
        Me.BTN_GenReporteProductos.Name = "BTN_GenReporteProductos"
        Me.BTN_GenReporteProductos.Size = New System.Drawing.Size(385, 54)
        Me.BTN_GenReporteProductos.TabIndex = 150
        Me.BTN_GenReporteProductos.Text = "Generar reporte"
        '
        'Guna2HtmlLabel13
        '
        Me.Guna2HtmlLabel13.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Guna2HtmlLabel13.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel13.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel13.ForeColor = System.Drawing.SystemColors.Control
        Me.Guna2HtmlLabel13.Location = New System.Drawing.Point(55, 348)
        Me.Guna2HtmlLabel13.Name = "Guna2HtmlLabel13"
        Me.Guna2HtmlLabel13.Size = New System.Drawing.Size(50, 23)
        Me.Guna2HtmlLabel13.TabIndex = 149
        Me.Guna2HtmlLabel13.Text = "Hasta:"
        Me.Guna2HtmlLabel13.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit
        '
        'Guna2HtmlLabel14
        '
        Me.Guna2HtmlLabel14.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Guna2HtmlLabel14.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel14.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel14.ForeColor = System.Drawing.SystemColors.Control
        Me.Guna2HtmlLabel14.Location = New System.Drawing.Point(55, 238)
        Me.Guna2HtmlLabel14.Name = "Guna2HtmlLabel14"
        Me.Guna2HtmlLabel14.Size = New System.Drawing.Size(54, 23)
        Me.Guna2HtmlLabel14.TabIndex = 148
        Me.Guna2HtmlLabel14.Text = "Desde:"
        Me.Guna2HtmlLabel14.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit
        '
        'DTP_HastaReporteProducto
        '
        Me.DTP_HastaReporteProducto.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DTP_HastaReporteProducto.BorderRadius = 10
        Me.DTP_HastaReporteProducto.Checked = True
        Me.DTP_HastaReporteProducto.FillColor = System.Drawing.Color.White
        Me.DTP_HastaReporteProducto.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.DTP_HastaReporteProducto.Format = System.Windows.Forms.DateTimePickerFormat.[Long]
        Me.DTP_HastaReporteProducto.Location = New System.Drawing.Point(55, 377)
        Me.DTP_HastaReporteProducto.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.DTP_HastaReporteProducto.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.DTP_HastaReporteProducto.Name = "DTP_HastaReporteProducto"
        Me.DTP_HastaReporteProducto.Size = New System.Drawing.Size(282, 36)
        Me.DTP_HastaReporteProducto.TabIndex = 147
        Me.DTP_HastaReporteProducto.Value = New Date(2025, 3, 17, 19, 28, 7, 244)
        '
        'DTP_DesdeReporteProducto
        '
        Me.DTP_DesdeReporteProducto.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DTP_DesdeReporteProducto.BorderRadius = 10
        Me.DTP_DesdeReporteProducto.Checked = True
        Me.DTP_DesdeReporteProducto.FillColor = System.Drawing.Color.White
        Me.DTP_DesdeReporteProducto.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.DTP_DesdeReporteProducto.Format = System.Windows.Forms.DateTimePickerFormat.[Long]
        Me.DTP_DesdeReporteProducto.Location = New System.Drawing.Point(55, 267)
        Me.DTP_DesdeReporteProducto.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.DTP_DesdeReporteProducto.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.DTP_DesdeReporteProducto.Name = "DTP_DesdeReporteProducto"
        Me.DTP_DesdeReporteProducto.Size = New System.Drawing.Size(282, 36)
        Me.DTP_DesdeReporteProducto.TabIndex = 146
        Me.DTP_DesdeReporteProducto.Value = New Date(2025, 3, 17, 19, 28, 7, 244)
        '
        'NUD_LimitReporteProducto
        '
        Me.NUD_LimitReporteProducto.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.NUD_LimitReporteProducto.BackColor = System.Drawing.Color.Transparent
        Me.NUD_LimitReporteProducto.BorderRadius = 10
        Me.NUD_LimitReporteProducto.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.NUD_LimitReporteProducto.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.NUD_LimitReporteProducto.Location = New System.Drawing.Point(55, 157)
        Me.NUD_LimitReporteProducto.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        Me.NUD_LimitReporteProducto.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.NUD_LimitReporteProducto.Name = "NUD_LimitReporteProducto"
        Me.NUD_LimitReporteProducto.Size = New System.Drawing.Size(282, 36)
        Me.NUD_LimitReporteProducto.TabIndex = 145
        Me.NUD_LimitReporteProducto.UpDownButtonFillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.NUD_LimitReporteProducto.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Guna2HtmlLabel12
        '
        Me.Guna2HtmlLabel12.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Guna2HtmlLabel12.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel12.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Guna2HtmlLabel12.ForeColor = System.Drawing.SystemColors.Control
        Me.Guna2HtmlLabel12.Location = New System.Drawing.Point(55, 128)
        Me.Guna2HtmlLabel12.Name = "Guna2HtmlLabel12"
        Me.Guna2HtmlLabel12.Size = New System.Drawing.Size(152, 23)
        Me.Guna2HtmlLabel12.TabIndex = 143
        Me.Guna2HtmlLabel12.Text = "Cantidad a mostrar:"
        Me.Guna2HtmlLabel12.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit
        '
        'PAG_CierreCaja
        '
        Me.PAG_CierreCaja.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.PAG_CierreCaja.Controls.Add(Me.TBL_DivCierreCaja)
        Me.PAG_CierreCaja.Location = New System.Drawing.Point(4, 44)
        Me.PAG_CierreCaja.Name = "PAG_CierreCaja"
        Me.PAG_CierreCaja.Padding = New System.Windows.Forms.Padding(3)
        Me.PAG_CierreCaja.Size = New System.Drawing.Size(1246, 706)
        Me.PAG_CierreCaja.TabIndex = 2
        Me.PAG_CierreCaja.Text = "Cierre de caja"
        '
        'TBL_DivCierreCaja
        '
        Me.TBL_DivCierreCaja.ColumnCount = 2
        Me.TBL_DivCierreCaja.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TBL_DivCierreCaja.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TBL_DivCierreCaja.Controls.Add(Me.PAN_EfectivoReal, 0, 0)
        Me.TBL_DivCierreCaja.Controls.Add(Me.PAN_Cell2InfoCierre, 1, 0)
        Me.TBL_DivCierreCaja.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TBL_DivCierreCaja.Location = New System.Drawing.Point(3, 3)
        Me.TBL_DivCierreCaja.Name = "TBL_DivCierreCaja"
        Me.TBL_DivCierreCaja.RowCount = 1
        Me.TBL_DivCierreCaja.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TBL_DivCierreCaja.Size = New System.Drawing.Size(1240, 700)
        Me.TBL_DivCierreCaja.TabIndex = 0
        '
        'PAN_EfectivoReal
        '
        Me.PAN_EfectivoReal.Controls.Add(Me.TBL_IngresoEfectivoReal)
        Me.PAN_EfectivoReal.Controls.Add(Me.PAN_FooterEfectivoReal)
        Me.PAN_EfectivoReal.Controls.Add(Me.PAN_HeaderEfectivoReal)
        Me.PAN_EfectivoReal.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PAN_EfectivoReal.Location = New System.Drawing.Point(3, 3)
        Me.PAN_EfectivoReal.Name = "PAN_EfectivoReal"
        Me.PAN_EfectivoReal.Size = New System.Drawing.Size(614, 694)
        Me.PAN_EfectivoReal.TabIndex = 0
        '
        'TBL_IngresoEfectivoReal
        '
        Me.TBL_IngresoEfectivoReal.ColumnCount = 2
        Me.TBL_IngresoEfectivoReal.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TBL_IngresoEfectivoReal.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TBL_IngresoEfectivoReal.Controls.Add(Me.PAN_Moneda5, 1, 5)
        Me.TBL_IngresoEfectivoReal.Controls.Add(Me.PAN_Billete1, 0, 5)
        Me.TBL_IngresoEfectivoReal.Controls.Add(Me.PAN_Moneda10, 1, 4)
        Me.TBL_IngresoEfectivoReal.Controls.Add(Me.PAN_Billete2, 0, 4)
        Me.TBL_IngresoEfectivoReal.Controls.Add(Me.PAN_Moneda25, 1, 3)
        Me.TBL_IngresoEfectivoReal.Controls.Add(Me.PAN_Billete5, 0, 3)
        Me.TBL_IngresoEfectivoReal.Controls.Add(Me.Guna2Panel6, 1, 2)
        Me.TBL_IngresoEfectivoReal.Controls.Add(Me.PAN_Billete10, 0, 2)
        Me.TBL_IngresoEfectivoReal.Controls.Add(Me.PAN_Moneda100, 1, 1)
        Me.TBL_IngresoEfectivoReal.Controls.Add(Me.PAN_Billete20, 0, 1)
        Me.TBL_IngresoEfectivoReal.Controls.Add(Me.PAN_Moneda500, 1, 0)
        Me.TBL_IngresoEfectivoReal.Controls.Add(Me.PAN_Billete50, 0, 0)
        Me.TBL_IngresoEfectivoReal.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TBL_IngresoEfectivoReal.Location = New System.Drawing.Point(0, 66)
        Me.TBL_IngresoEfectivoReal.Name = "TBL_IngresoEfectivoReal"
        Me.TBL_IngresoEfectivoReal.RowCount = 6
        Me.TBL_IngresoEfectivoReal.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.TBL_IngresoEfectivoReal.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.TBL_IngresoEfectivoReal.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.TBL_IngresoEfectivoReal.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.TBL_IngresoEfectivoReal.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.TBL_IngresoEfectivoReal.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.TBL_IngresoEfectivoReal.Size = New System.Drawing.Size(614, 562)
        Me.TBL_IngresoEfectivoReal.TabIndex = 10
        '
        'PAN_Moneda5
        '
        Me.PAN_Moneda5.Controls.Add(Me.NUD_Moneda5)
        Me.PAN_Moneda5.Controls.Add(Me.Guna2HtmlLabel28)
        Me.PAN_Moneda5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PAN_Moneda5.Location = New System.Drawing.Point(310, 468)
        Me.PAN_Moneda5.Name = "PAN_Moneda5"
        Me.PAN_Moneda5.Size = New System.Drawing.Size(301, 91)
        Me.PAN_Moneda5.TabIndex = 11
        '
        'NUD_Moneda5
        '
        Me.NUD_Moneda5.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.NUD_Moneda5.BackColor = System.Drawing.Color.Transparent
        Me.NUD_Moneda5.BorderRadius = 10
        Me.NUD_Moneda5.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.NUD_Moneda5.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.NUD_Moneda5.Location = New System.Drawing.Point(19, 36)
        Me.NUD_Moneda5.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        Me.NUD_Moneda5.Name = "NUD_Moneda5"
        Me.NUD_Moneda5.Size = New System.Drawing.Size(263, 36)
        Me.NUD_Moneda5.TabIndex = 153
        Me.NUD_Moneda5.UpDownButtonFillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        '
        'Guna2HtmlLabel28
        '
        Me.Guna2HtmlLabel28.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Guna2HtmlLabel28.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel28.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Guna2HtmlLabel28.ForeColor = System.Drawing.SystemColors.Control
        Me.Guna2HtmlLabel28.Location = New System.Drawing.Point(19, 7)
        Me.Guna2HtmlLabel28.Name = "Guna2HtmlLabel28"
        Me.Guna2HtmlLabel28.Size = New System.Drawing.Size(122, 23)
        Me.Guna2HtmlLabel28.TabIndex = 152
        Me.Guna2HtmlLabel28.Text = "Monedas de ₡5:"
        Me.Guna2HtmlLabel28.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit
        '
        'PAN_Billete1
        '
        Me.PAN_Billete1.Controls.Add(Me.NUD_Billete1)
        Me.PAN_Billete1.Controls.Add(Me.Guna2HtmlLabel22)
        Me.PAN_Billete1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PAN_Billete1.Location = New System.Drawing.Point(3, 468)
        Me.PAN_Billete1.Name = "PAN_Billete1"
        Me.PAN_Billete1.Size = New System.Drawing.Size(301, 91)
        Me.PAN_Billete1.TabIndex = 10
        '
        'NUD_Billete1
        '
        Me.NUD_Billete1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.NUD_Billete1.BackColor = System.Drawing.Color.Transparent
        Me.NUD_Billete1.BorderRadius = 10
        Me.NUD_Billete1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.NUD_Billete1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.NUD_Billete1.Location = New System.Drawing.Point(19, 34)
        Me.NUD_Billete1.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        Me.NUD_Billete1.Name = "NUD_Billete1"
        Me.NUD_Billete1.Size = New System.Drawing.Size(263, 36)
        Me.NUD_Billete1.TabIndex = 149
        Me.NUD_Billete1.UpDownButtonFillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        '
        'Guna2HtmlLabel22
        '
        Me.Guna2HtmlLabel22.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Guna2HtmlLabel22.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel22.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Guna2HtmlLabel22.ForeColor = System.Drawing.SystemColors.Control
        Me.Guna2HtmlLabel22.Location = New System.Drawing.Point(19, 5)
        Me.Guna2HtmlLabel22.Name = "Guna2HtmlLabel22"
        Me.Guna2HtmlLabel22.Size = New System.Drawing.Size(139, 23)
        Me.Guna2HtmlLabel22.TabIndex = 148
        Me.Guna2HtmlLabel22.Text = "Billetes de ₡1 000:"
        Me.Guna2HtmlLabel22.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit
        '
        'PAN_Moneda10
        '
        Me.PAN_Moneda10.Controls.Add(Me.NUD_Moneda10)
        Me.PAN_Moneda10.Controls.Add(Me.Guna2HtmlLabel27)
        Me.PAN_Moneda10.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PAN_Moneda10.Location = New System.Drawing.Point(310, 375)
        Me.PAN_Moneda10.Name = "PAN_Moneda10"
        Me.PAN_Moneda10.Size = New System.Drawing.Size(301, 87)
        Me.PAN_Moneda10.TabIndex = 9
        '
        'NUD_Moneda10
        '
        Me.NUD_Moneda10.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.NUD_Moneda10.BackColor = System.Drawing.Color.Transparent
        Me.NUD_Moneda10.BorderRadius = 10
        Me.NUD_Moneda10.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.NUD_Moneda10.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.NUD_Moneda10.Location = New System.Drawing.Point(19, 32)
        Me.NUD_Moneda10.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        Me.NUD_Moneda10.Name = "NUD_Moneda10"
        Me.NUD_Moneda10.Size = New System.Drawing.Size(263, 36)
        Me.NUD_Moneda10.TabIndex = 153
        Me.NUD_Moneda10.UpDownButtonFillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        '
        'Guna2HtmlLabel27
        '
        Me.Guna2HtmlLabel27.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Guna2HtmlLabel27.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel27.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Guna2HtmlLabel27.ForeColor = System.Drawing.SystemColors.Control
        Me.Guna2HtmlLabel27.Location = New System.Drawing.Point(19, 3)
        Me.Guna2HtmlLabel27.Name = "Guna2HtmlLabel27"
        Me.Guna2HtmlLabel27.Size = New System.Drawing.Size(131, 23)
        Me.Guna2HtmlLabel27.TabIndex = 152
        Me.Guna2HtmlLabel27.Text = "Monedas de ₡10:"
        Me.Guna2HtmlLabel27.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit
        '
        'PAN_Billete2
        '
        Me.PAN_Billete2.Controls.Add(Me.NUD_Billete2)
        Me.PAN_Billete2.Controls.Add(Me.Guna2HtmlLabel21)
        Me.PAN_Billete2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PAN_Billete2.Location = New System.Drawing.Point(3, 375)
        Me.PAN_Billete2.Name = "PAN_Billete2"
        Me.PAN_Billete2.Size = New System.Drawing.Size(301, 87)
        Me.PAN_Billete2.TabIndex = 8
        '
        'NUD_Billete2
        '
        Me.NUD_Billete2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.NUD_Billete2.BackColor = System.Drawing.Color.Transparent
        Me.NUD_Billete2.BorderRadius = 10
        Me.NUD_Billete2.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.NUD_Billete2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.NUD_Billete2.Location = New System.Drawing.Point(19, 32)
        Me.NUD_Billete2.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        Me.NUD_Billete2.Name = "NUD_Billete2"
        Me.NUD_Billete2.Size = New System.Drawing.Size(263, 36)
        Me.NUD_Billete2.TabIndex = 149
        Me.NUD_Billete2.UpDownButtonFillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        '
        'Guna2HtmlLabel21
        '
        Me.Guna2HtmlLabel21.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Guna2HtmlLabel21.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel21.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Guna2HtmlLabel21.ForeColor = System.Drawing.SystemColors.Control
        Me.Guna2HtmlLabel21.Location = New System.Drawing.Point(19, 3)
        Me.Guna2HtmlLabel21.Name = "Guna2HtmlLabel21"
        Me.Guna2HtmlLabel21.Size = New System.Drawing.Size(139, 23)
        Me.Guna2HtmlLabel21.TabIndex = 148
        Me.Guna2HtmlLabel21.Text = "Billetes de ₡2 000:"
        Me.Guna2HtmlLabel21.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit
        '
        'PAN_Moneda25
        '
        Me.PAN_Moneda25.Controls.Add(Me.NUD_Moneda25)
        Me.PAN_Moneda25.Controls.Add(Me.Guna2HtmlLabel26)
        Me.PAN_Moneda25.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PAN_Moneda25.Location = New System.Drawing.Point(310, 282)
        Me.PAN_Moneda25.Name = "PAN_Moneda25"
        Me.PAN_Moneda25.Size = New System.Drawing.Size(301, 87)
        Me.PAN_Moneda25.TabIndex = 7
        '
        'NUD_Moneda25
        '
        Me.NUD_Moneda25.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.NUD_Moneda25.BackColor = System.Drawing.Color.Transparent
        Me.NUD_Moneda25.BorderRadius = 10
        Me.NUD_Moneda25.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.NUD_Moneda25.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.NUD_Moneda25.Location = New System.Drawing.Point(19, 32)
        Me.NUD_Moneda25.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        Me.NUD_Moneda25.Name = "NUD_Moneda25"
        Me.NUD_Moneda25.Size = New System.Drawing.Size(263, 36)
        Me.NUD_Moneda25.TabIndex = 153
        Me.NUD_Moneda25.UpDownButtonFillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        '
        'Guna2HtmlLabel26
        '
        Me.Guna2HtmlLabel26.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Guna2HtmlLabel26.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel26.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Guna2HtmlLabel26.ForeColor = System.Drawing.SystemColors.Control
        Me.Guna2HtmlLabel26.Location = New System.Drawing.Point(19, 3)
        Me.Guna2HtmlLabel26.Name = "Guna2HtmlLabel26"
        Me.Guna2HtmlLabel26.Size = New System.Drawing.Size(131, 23)
        Me.Guna2HtmlLabel26.TabIndex = 152
        Me.Guna2HtmlLabel26.Text = "Monedas de ₡25:"
        Me.Guna2HtmlLabel26.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit
        '
        'PAN_Billete5
        '
        Me.PAN_Billete5.Controls.Add(Me.NUD_Billete5)
        Me.PAN_Billete5.Controls.Add(Me.Guna2HtmlLabel20)
        Me.PAN_Billete5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PAN_Billete5.Location = New System.Drawing.Point(3, 282)
        Me.PAN_Billete5.Name = "PAN_Billete5"
        Me.PAN_Billete5.Size = New System.Drawing.Size(301, 87)
        Me.PAN_Billete5.TabIndex = 6
        '
        'NUD_Billete5
        '
        Me.NUD_Billete5.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.NUD_Billete5.BackColor = System.Drawing.Color.Transparent
        Me.NUD_Billete5.BorderRadius = 10
        Me.NUD_Billete5.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.NUD_Billete5.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.NUD_Billete5.Location = New System.Drawing.Point(19, 32)
        Me.NUD_Billete5.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        Me.NUD_Billete5.Name = "NUD_Billete5"
        Me.NUD_Billete5.Size = New System.Drawing.Size(263, 36)
        Me.NUD_Billete5.TabIndex = 149
        Me.NUD_Billete5.UpDownButtonFillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        '
        'Guna2HtmlLabel20
        '
        Me.Guna2HtmlLabel20.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Guna2HtmlLabel20.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel20.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Guna2HtmlLabel20.ForeColor = System.Drawing.SystemColors.Control
        Me.Guna2HtmlLabel20.Location = New System.Drawing.Point(19, 3)
        Me.Guna2HtmlLabel20.Name = "Guna2HtmlLabel20"
        Me.Guna2HtmlLabel20.Size = New System.Drawing.Size(139, 23)
        Me.Guna2HtmlLabel20.TabIndex = 148
        Me.Guna2HtmlLabel20.Text = "Billetes de ₡5 000:"
        Me.Guna2HtmlLabel20.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit
        '
        'Guna2Panel6
        '
        Me.Guna2Panel6.Controls.Add(Me.PAN_Moneda50)
        Me.Guna2Panel6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Guna2Panel6.Location = New System.Drawing.Point(310, 189)
        Me.Guna2Panel6.Name = "Guna2Panel6"
        Me.Guna2Panel6.Size = New System.Drawing.Size(301, 87)
        Me.Guna2Panel6.TabIndex = 5
        '
        'PAN_Moneda50
        '
        Me.PAN_Moneda50.Controls.Add(Me.NUD_Moneda50)
        Me.PAN_Moneda50.Controls.Add(Me.Guna2HtmlLabel25)
        Me.PAN_Moneda50.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PAN_Moneda50.Location = New System.Drawing.Point(0, 0)
        Me.PAN_Moneda50.Name = "PAN_Moneda50"
        Me.PAN_Moneda50.Size = New System.Drawing.Size(301, 87)
        Me.PAN_Moneda50.TabIndex = 1
        '
        'NUD_Moneda50
        '
        Me.NUD_Moneda50.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.NUD_Moneda50.BackColor = System.Drawing.Color.Transparent
        Me.NUD_Moneda50.BorderRadius = 10
        Me.NUD_Moneda50.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.NUD_Moneda50.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.NUD_Moneda50.Location = New System.Drawing.Point(19, 32)
        Me.NUD_Moneda50.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        Me.NUD_Moneda50.Name = "NUD_Moneda50"
        Me.NUD_Moneda50.Size = New System.Drawing.Size(263, 36)
        Me.NUD_Moneda50.TabIndex = 153
        Me.NUD_Moneda50.UpDownButtonFillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        '
        'Guna2HtmlLabel25
        '
        Me.Guna2HtmlLabel25.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Guna2HtmlLabel25.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel25.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Guna2HtmlLabel25.ForeColor = System.Drawing.SystemColors.Control
        Me.Guna2HtmlLabel25.Location = New System.Drawing.Point(19, 3)
        Me.Guna2HtmlLabel25.Name = "Guna2HtmlLabel25"
        Me.Guna2HtmlLabel25.Size = New System.Drawing.Size(131, 23)
        Me.Guna2HtmlLabel25.TabIndex = 152
        Me.Guna2HtmlLabel25.Text = "Monedas de ₡50:"
        Me.Guna2HtmlLabel25.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit
        '
        'PAN_Billete10
        '
        Me.PAN_Billete10.Controls.Add(Me.NUD_Billete10)
        Me.PAN_Billete10.Controls.Add(Me.Guna2HtmlLabel19)
        Me.PAN_Billete10.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PAN_Billete10.Location = New System.Drawing.Point(3, 189)
        Me.PAN_Billete10.Name = "PAN_Billete10"
        Me.PAN_Billete10.Size = New System.Drawing.Size(301, 87)
        Me.PAN_Billete10.TabIndex = 4
        '
        'NUD_Billete10
        '
        Me.NUD_Billete10.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.NUD_Billete10.BackColor = System.Drawing.Color.Transparent
        Me.NUD_Billete10.BorderRadius = 10
        Me.NUD_Billete10.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.NUD_Billete10.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.NUD_Billete10.Location = New System.Drawing.Point(19, 32)
        Me.NUD_Billete10.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        Me.NUD_Billete10.Name = "NUD_Billete10"
        Me.NUD_Billete10.Size = New System.Drawing.Size(263, 36)
        Me.NUD_Billete10.TabIndex = 149
        Me.NUD_Billete10.UpDownButtonFillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        '
        'Guna2HtmlLabel19
        '
        Me.Guna2HtmlLabel19.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Guna2HtmlLabel19.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel19.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Guna2HtmlLabel19.ForeColor = System.Drawing.SystemColors.Control
        Me.Guna2HtmlLabel19.Location = New System.Drawing.Point(19, 3)
        Me.Guna2HtmlLabel19.Name = "Guna2HtmlLabel19"
        Me.Guna2HtmlLabel19.Size = New System.Drawing.Size(148, 23)
        Me.Guna2HtmlLabel19.TabIndex = 148
        Me.Guna2HtmlLabel19.Text = "Billetes de ₡10 000:"
        Me.Guna2HtmlLabel19.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit
        '
        'PAN_Moneda100
        '
        Me.PAN_Moneda100.Controls.Add(Me.NUD_Moneda100)
        Me.PAN_Moneda100.Controls.Add(Me.Guna2HtmlLabel24)
        Me.PAN_Moneda100.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PAN_Moneda100.Location = New System.Drawing.Point(310, 96)
        Me.PAN_Moneda100.Name = "PAN_Moneda100"
        Me.PAN_Moneda100.Size = New System.Drawing.Size(301, 87)
        Me.PAN_Moneda100.TabIndex = 3
        '
        'NUD_Moneda100
        '
        Me.NUD_Moneda100.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.NUD_Moneda100.BackColor = System.Drawing.Color.Transparent
        Me.NUD_Moneda100.BorderRadius = 10
        Me.NUD_Moneda100.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.NUD_Moneda100.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.NUD_Moneda100.Location = New System.Drawing.Point(19, 32)
        Me.NUD_Moneda100.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        Me.NUD_Moneda100.Name = "NUD_Moneda100"
        Me.NUD_Moneda100.Size = New System.Drawing.Size(263, 36)
        Me.NUD_Moneda100.TabIndex = 153
        Me.NUD_Moneda100.UpDownButtonFillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        '
        'Guna2HtmlLabel24
        '
        Me.Guna2HtmlLabel24.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Guna2HtmlLabel24.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel24.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Guna2HtmlLabel24.ForeColor = System.Drawing.SystemColors.Control
        Me.Guna2HtmlLabel24.Location = New System.Drawing.Point(19, 3)
        Me.Guna2HtmlLabel24.Name = "Guna2HtmlLabel24"
        Me.Guna2HtmlLabel24.Size = New System.Drawing.Size(140, 23)
        Me.Guna2HtmlLabel24.TabIndex = 152
        Me.Guna2HtmlLabel24.Text = "Monedas de ₡100:"
        Me.Guna2HtmlLabel24.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit
        '
        'PAN_Billete20
        '
        Me.PAN_Billete20.Controls.Add(Me.NUD_Billete20)
        Me.PAN_Billete20.Controls.Add(Me.Guna2HtmlLabel18)
        Me.PAN_Billete20.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PAN_Billete20.Location = New System.Drawing.Point(3, 96)
        Me.PAN_Billete20.Name = "PAN_Billete20"
        Me.PAN_Billete20.Size = New System.Drawing.Size(301, 87)
        Me.PAN_Billete20.TabIndex = 2
        '
        'NUD_Billete20
        '
        Me.NUD_Billete20.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.NUD_Billete20.BackColor = System.Drawing.Color.Transparent
        Me.NUD_Billete20.BorderRadius = 10
        Me.NUD_Billete20.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.NUD_Billete20.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.NUD_Billete20.Location = New System.Drawing.Point(19, 32)
        Me.NUD_Billete20.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        Me.NUD_Billete20.Name = "NUD_Billete20"
        Me.NUD_Billete20.Size = New System.Drawing.Size(263, 36)
        Me.NUD_Billete20.TabIndex = 149
        Me.NUD_Billete20.UpDownButtonFillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        '
        'Guna2HtmlLabel18
        '
        Me.Guna2HtmlLabel18.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Guna2HtmlLabel18.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel18.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Guna2HtmlLabel18.ForeColor = System.Drawing.SystemColors.Control
        Me.Guna2HtmlLabel18.Location = New System.Drawing.Point(19, 3)
        Me.Guna2HtmlLabel18.Name = "Guna2HtmlLabel18"
        Me.Guna2HtmlLabel18.Size = New System.Drawing.Size(148, 23)
        Me.Guna2HtmlLabel18.TabIndex = 148
        Me.Guna2HtmlLabel18.Text = "Billetes de ₡20 000:"
        Me.Guna2HtmlLabel18.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit
        '
        'PAN_Moneda500
        '
        Me.PAN_Moneda500.Controls.Add(Me.NUD_Moneda500)
        Me.PAN_Moneda500.Controls.Add(Me.Guna2HtmlLabel23)
        Me.PAN_Moneda500.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PAN_Moneda500.Location = New System.Drawing.Point(310, 3)
        Me.PAN_Moneda500.Name = "PAN_Moneda500"
        Me.PAN_Moneda500.Size = New System.Drawing.Size(301, 87)
        Me.PAN_Moneda500.TabIndex = 1
        '
        'NUD_Moneda500
        '
        Me.NUD_Moneda500.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.NUD_Moneda500.BackColor = System.Drawing.Color.Transparent
        Me.NUD_Moneda500.BorderRadius = 10
        Me.NUD_Moneda500.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.NUD_Moneda500.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.NUD_Moneda500.Location = New System.Drawing.Point(19, 32)
        Me.NUD_Moneda500.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        Me.NUD_Moneda500.Name = "NUD_Moneda500"
        Me.NUD_Moneda500.Size = New System.Drawing.Size(263, 36)
        Me.NUD_Moneda500.TabIndex = 151
        Me.NUD_Moneda500.UpDownButtonFillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        '
        'Guna2HtmlLabel23
        '
        Me.Guna2HtmlLabel23.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Guna2HtmlLabel23.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel23.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Guna2HtmlLabel23.ForeColor = System.Drawing.SystemColors.Control
        Me.Guna2HtmlLabel23.Location = New System.Drawing.Point(19, 3)
        Me.Guna2HtmlLabel23.Name = "Guna2HtmlLabel23"
        Me.Guna2HtmlLabel23.Size = New System.Drawing.Size(140, 23)
        Me.Guna2HtmlLabel23.TabIndex = 150
        Me.Guna2HtmlLabel23.Text = "Monedas de ₡500:"
        Me.Guna2HtmlLabel23.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit
        '
        'PAN_Billete50
        '
        Me.PAN_Billete50.Controls.Add(Me.NUD_Billete50)
        Me.PAN_Billete50.Controls.Add(Me.Guna2HtmlLabel17)
        Me.PAN_Billete50.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PAN_Billete50.Location = New System.Drawing.Point(3, 3)
        Me.PAN_Billete50.Name = "PAN_Billete50"
        Me.PAN_Billete50.Size = New System.Drawing.Size(301, 87)
        Me.PAN_Billete50.TabIndex = 0
        '
        'NUD_Billete50
        '
        Me.NUD_Billete50.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.NUD_Billete50.BackColor = System.Drawing.Color.Transparent
        Me.NUD_Billete50.BorderRadius = 10
        Me.NUD_Billete50.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.NUD_Billete50.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.NUD_Billete50.Location = New System.Drawing.Point(17, 32)
        Me.NUD_Billete50.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        Me.NUD_Billete50.Name = "NUD_Billete50"
        Me.NUD_Billete50.Size = New System.Drawing.Size(263, 36)
        Me.NUD_Billete50.TabIndex = 147
        Me.NUD_Billete50.UpDownButtonFillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        '
        'Guna2HtmlLabel17
        '
        Me.Guna2HtmlLabel17.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Guna2HtmlLabel17.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel17.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Guna2HtmlLabel17.ForeColor = System.Drawing.SystemColors.Control
        Me.Guna2HtmlLabel17.Location = New System.Drawing.Point(17, 3)
        Me.Guna2HtmlLabel17.Name = "Guna2HtmlLabel17"
        Me.Guna2HtmlLabel17.Size = New System.Drawing.Size(148, 23)
        Me.Guna2HtmlLabel17.TabIndex = 146
        Me.Guna2HtmlLabel17.Text = "Billetes de ₡50 000:"
        Me.Guna2HtmlLabel17.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit
        '
        'PAN_FooterEfectivoReal
        '
        Me.PAN_FooterEfectivoReal.Controls.Add(Me.TXT_EfectivoReal)
        Me.PAN_FooterEfectivoReal.Controls.Add(Me.Guna2HtmlLabel29)
        Me.PAN_FooterEfectivoReal.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PAN_FooterEfectivoReal.Location = New System.Drawing.Point(0, 628)
        Me.PAN_FooterEfectivoReal.Name = "PAN_FooterEfectivoReal"
        Me.PAN_FooterEfectivoReal.Size = New System.Drawing.Size(614, 66)
        Me.PAN_FooterEfectivoReal.TabIndex = 9
        '
        'TXT_EfectivoReal
        '
        Me.TXT_EfectivoReal.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TXT_EfectivoReal.BorderRadius = 10
        Me.TXT_EfectivoReal.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TXT_EfectivoReal.DefaultText = ""
        Me.TXT_EfectivoReal.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TXT_EfectivoReal.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TXT_EfectivoReal.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXT_EfectivoReal.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXT_EfectivoReal.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXT_EfectivoReal.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.TXT_EfectivoReal.ForeColor = System.Drawing.Color.Black
        Me.TXT_EfectivoReal.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXT_EfectivoReal.IconRightSize = New System.Drawing.Size(40, 40)
        Me.TXT_EfectivoReal.Location = New System.Drawing.Point(278, 13)
        Me.TXT_EfectivoReal.Name = "TXT_EfectivoReal"
        Me.TXT_EfectivoReal.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TXT_EfectivoReal.PlaceholderText = ""
        Me.TXT_EfectivoReal.ReadOnly = True
        Me.TXT_EfectivoReal.SelectedText = ""
        Me.TXT_EfectivoReal.Size = New System.Drawing.Size(314, 42)
        Me.TXT_EfectivoReal.TabIndex = 143
        '
        'Guna2HtmlLabel29
        '
        Me.Guna2HtmlLabel29.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel29.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel29.ForeColor = System.Drawing.SystemColors.Control
        Me.Guna2HtmlLabel29.Location = New System.Drawing.Point(34, 16)
        Me.Guna2HtmlLabel29.Name = "Guna2HtmlLabel29"
        Me.Guna2HtmlLabel29.Size = New System.Drawing.Size(238, 34)
        Me.Guna2HtmlLabel29.TabIndex = 142
        Me.Guna2HtmlLabel29.Text = "Efectivo real en caja:"
        Me.Guna2HtmlLabel29.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit
        '
        'PAN_HeaderEfectivoReal
        '
        Me.PAN_HeaderEfectivoReal.Controls.Add(Me.TableLayoutPanel5)
        Me.PAN_HeaderEfectivoReal.Dock = System.Windows.Forms.DockStyle.Top
        Me.PAN_HeaderEfectivoReal.Location = New System.Drawing.Point(0, 0)
        Me.PAN_HeaderEfectivoReal.Name = "PAN_HeaderEfectivoReal"
        Me.PAN_HeaderEfectivoReal.Size = New System.Drawing.Size(614, 66)
        Me.PAN_HeaderEfectivoReal.TabIndex = 0
        '
        'TableLayoutPanel5
        '
        Me.TableLayoutPanel5.ColumnCount = 3
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.94157!))
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 34.52921!))
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 34.52921!))
        Me.TableLayoutPanel5.Controls.Add(Me.BTN_VerCierres, 1, 0)
        Me.TableLayoutPanel5.Controls.Add(Me.BTN_CCLimpiarCierre, 2, 0)
        Me.TableLayoutPanel5.Controls.Add(Me.Guna2HtmlLabel16, 0, 0)
        Me.TableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel5.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel5.Name = "TableLayoutPanel5"
        Me.TableLayoutPanel5.RowCount = 1
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel5.Size = New System.Drawing.Size(614, 66)
        Me.TableLayoutPanel5.TabIndex = 0
        '
        'BTN_VerCierres
        '
        Me.BTN_VerCierres.BorderColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BTN_VerCierres.BorderRadius = 10
        Me.BTN_VerCierres.BorderThickness = 2
        Me.BTN_VerCierres.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.BTN_VerCierres.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BTN_VerCierres.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BTN_VerCierres.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BTN_VerCierres.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BTN_VerCierres.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BTN_VerCierres.FillColor = System.Drawing.Color.Transparent
        Me.BTN_VerCierres.FocusedColor = System.Drawing.Color.Silver
        Me.BTN_VerCierres.Font = New System.Drawing.Font("Ebrima", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_VerCierres.ForeColor = System.Drawing.Color.White
        Me.BTN_VerCierres.Image = CType(resources.GetObject("BTN_VerCierres.Image"), System.Drawing.Image)
        Me.BTN_VerCierres.ImageSize = New System.Drawing.Size(50, 50)
        Me.BTN_VerCierres.Location = New System.Drawing.Point(192, 3)
        Me.BTN_VerCierres.Name = "BTN_VerCierres"
        Me.BTN_VerCierres.Size = New System.Drawing.Size(206, 60)
        Me.BTN_VerCierres.TabIndex = 154
        Me.BTN_VerCierres.Text = "Ver cierres"
        '
        'BTN_CCLimpiarCierre
        '
        Me.BTN_CCLimpiarCierre.BorderColor = System.Drawing.Color.IndianRed
        Me.BTN_CCLimpiarCierre.BorderRadius = 10
        Me.BTN_CCLimpiarCierre.BorderThickness = 2
        Me.BTN_CCLimpiarCierre.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.BTN_CCLimpiarCierre.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BTN_CCLimpiarCierre.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BTN_CCLimpiarCierre.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BTN_CCLimpiarCierre.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BTN_CCLimpiarCierre.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BTN_CCLimpiarCierre.FillColor = System.Drawing.Color.Transparent
        Me.BTN_CCLimpiarCierre.FocusedColor = System.Drawing.Color.Silver
        Me.BTN_CCLimpiarCierre.Font = New System.Drawing.Font("Ebrima", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_CCLimpiarCierre.ForeColor = System.Drawing.Color.White
        Me.BTN_CCLimpiarCierre.Image = CType(resources.GetObject("BTN_CCLimpiarCierre.Image"), System.Drawing.Image)
        Me.BTN_CCLimpiarCierre.ImageSize = New System.Drawing.Size(50, 50)
        Me.BTN_CCLimpiarCierre.Location = New System.Drawing.Point(404, 3)
        Me.BTN_CCLimpiarCierre.Name = "BTN_CCLimpiarCierre"
        Me.BTN_CCLimpiarCierre.Size = New System.Drawing.Size(207, 60)
        Me.BTN_CCLimpiarCierre.TabIndex = 153
        Me.BTN_CCLimpiarCierre.Text = "Limpiar"
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
        Me.Guna2HtmlLabel16.Size = New System.Drawing.Size(183, 60)
        Me.Guna2HtmlLabel16.TabIndex = 152
        Me.Guna2HtmlLabel16.Text = "Efectivo real en caja"
        Me.Guna2HtmlLabel16.TextAlignment = System.Drawing.ContentAlignment.TopCenter
        Me.Guna2HtmlLabel16.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit
        '
        'PAN_Cell2InfoCierre
        '
        Me.PAN_Cell2InfoCierre.Controls.Add(Me.BTN_CalcularSaldoSiguiente)
        Me.PAN_Cell2InfoCierre.Controls.Add(Me.TableLayoutPanel4)
        Me.PAN_Cell2InfoCierre.Controls.Add(Me.Guna2GroupBox5)
        Me.PAN_Cell2InfoCierre.Controls.Add(Me.TXT_CCComentario)
        Me.PAN_Cell2InfoCierre.Controls.Add(Me.Guna2HtmlLabel37)
        Me.PAN_Cell2InfoCierre.Controls.Add(Me.NUD_CCSaldoSiguienteTurno)
        Me.PAN_Cell2InfoCierre.Controls.Add(Me.Guna2HtmlLabel36)
        Me.PAN_Cell2InfoCierre.Controls.Add(Me.Guna2Panel2)
        Me.PAN_Cell2InfoCierre.Controls.Add(Me.Guna2GroupBox4)
        Me.PAN_Cell2InfoCierre.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PAN_Cell2InfoCierre.Location = New System.Drawing.Point(623, 3)
        Me.PAN_Cell2InfoCierre.Name = "PAN_Cell2InfoCierre"
        Me.PAN_Cell2InfoCierre.Size = New System.Drawing.Size(614, 694)
        Me.PAN_Cell2InfoCierre.TabIndex = 1
        '
        'BTN_CalcularSaldoSiguiente
        '
        Me.BTN_CalcularSaldoSiguiente.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BTN_CalcularSaldoSiguiente.BackColor = System.Drawing.Color.Transparent
        Me.BTN_CalcularSaldoSiguiente.BorderColor = System.Drawing.Color.Red
        Me.BTN_CalcularSaldoSiguiente.BorderRadius = 10
        Me.BTN_CalcularSaldoSiguiente.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BTN_CalcularSaldoSiguiente.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BTN_CalcularSaldoSiguiente.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BTN_CalcularSaldoSiguiente.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BTN_CalcularSaldoSiguiente.FillColor = System.Drawing.Color.MediumSeaGreen
        Me.BTN_CalcularSaldoSiguiente.Font = New System.Drawing.Font("Ebrima", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_CalcularSaldoSiguiente.ForeColor = System.Drawing.Color.White
        Me.BTN_CalcularSaldoSiguiente.Image = CType(resources.GetObject("BTN_CalcularSaldoSiguiente.Image"), System.Drawing.Image)
        Me.BTN_CalcularSaldoSiguiente.ImageSize = New System.Drawing.Size(40, 40)
        Me.BTN_CalcularSaldoSiguiente.Location = New System.Drawing.Point(435, 384)
        Me.BTN_CalcularSaldoSiguiente.Name = "BTN_CalcularSaldoSiguiente"
        Me.BTN_CalcularSaldoSiguiente.Size = New System.Drawing.Size(164, 36)
        Me.BTN_CalcularSaldoSiguiente.TabIndex = 167
        Me.BTN_CalcularSaldoSiguiente.Text = "Calcular"
        '
        'TableLayoutPanel4
        '
        Me.TableLayoutPanel4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel4.ColumnCount = 2
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel4.Controls.Add(Me.Guna2HtmlLabel39, 1, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.Guna2HtmlLabel33, 0, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.NUD_SalidasEfectivo, 0, 1)
        Me.TableLayoutPanel4.Controls.Add(Me.TXT_CCTotalEsperado, 1, 1)
        Me.TableLayoutPanel4.Location = New System.Drawing.Point(12, 190)
        Me.TableLayoutPanel4.Name = "TableLayoutPanel4"
        Me.TableLayoutPanel4.RowCount = 2
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 43.90244!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 56.09756!))
        Me.TableLayoutPanel4.Size = New System.Drawing.Size(587, 82)
        Me.TableLayoutPanel4.TabIndex = 166
        '
        'Guna2HtmlLabel39
        '
        Me.Guna2HtmlLabel39.AutoSize = False
        Me.Guna2HtmlLabel39.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel39.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Guna2HtmlLabel39.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel39.ForeColor = System.Drawing.SystemColors.Control
        Me.Guna2HtmlLabel39.Location = New System.Drawing.Point(296, 3)
        Me.Guna2HtmlLabel39.Name = "Guna2HtmlLabel39"
        Me.Guna2HtmlLabel39.Size = New System.Drawing.Size(288, 30)
        Me.Guna2HtmlLabel39.TabIndex = 158
        Me.Guna2HtmlLabel39.Text = "Total esperado:"
        Me.Guna2HtmlLabel39.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.Guna2HtmlLabel39.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit
        '
        'Guna2HtmlLabel33
        '
        Me.Guna2HtmlLabel33.AutoSize = False
        Me.Guna2HtmlLabel33.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel33.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Guna2HtmlLabel33.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel33.ForeColor = System.Drawing.SystemColors.Control
        Me.Guna2HtmlLabel33.Location = New System.Drawing.Point(3, 3)
        Me.Guna2HtmlLabel33.Name = "Guna2HtmlLabel33"
        Me.Guna2HtmlLabel33.Size = New System.Drawing.Size(287, 30)
        Me.Guna2HtmlLabel33.TabIndex = 154
        Me.Guna2HtmlLabel33.Text = "Salidas en efectivo:"
        Me.Guna2HtmlLabel33.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.Guna2HtmlLabel33.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit
        '
        'NUD_SalidasEfectivo
        '
        Me.NUD_SalidasEfectivo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.NUD_SalidasEfectivo.BackColor = System.Drawing.Color.Transparent
        Me.NUD_SalidasEfectivo.BorderRadius = 10
        Me.NUD_SalidasEfectivo.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.NUD_SalidasEfectivo.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.NUD_SalidasEfectivo.Location = New System.Drawing.Point(3, 39)
        Me.NUD_SalidasEfectivo.Maximum = New Decimal(New Integer() {100000000, 0, 0, 0})
        Me.NUD_SalidasEfectivo.Name = "NUD_SalidasEfectivo"
        Me.NUD_SalidasEfectivo.Size = New System.Drawing.Size(287, 36)
        Me.NUD_SalidasEfectivo.TabIndex = 161
        Me.NUD_SalidasEfectivo.UpDownButtonFillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        '
        'TXT_CCTotalEsperado
        '
        Me.TXT_CCTotalEsperado.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TXT_CCTotalEsperado.BorderRadius = 10
        Me.TXT_CCTotalEsperado.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TXT_CCTotalEsperado.DefaultText = ""
        Me.TXT_CCTotalEsperado.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TXT_CCTotalEsperado.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TXT_CCTotalEsperado.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXT_CCTotalEsperado.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXT_CCTotalEsperado.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXT_CCTotalEsperado.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.TXT_CCTotalEsperado.ForeColor = System.Drawing.Color.Black
        Me.TXT_CCTotalEsperado.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXT_CCTotalEsperado.IconRightSize = New System.Drawing.Size(40, 40)
        Me.TXT_CCTotalEsperado.Location = New System.Drawing.Point(296, 39)
        Me.TXT_CCTotalEsperado.Name = "TXT_CCTotalEsperado"
        Me.TXT_CCTotalEsperado.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TXT_CCTotalEsperado.PlaceholderText = ""
        Me.TXT_CCTotalEsperado.ReadOnly = True
        Me.TXT_CCTotalEsperado.SelectedText = ""
        Me.TXT_CCTotalEsperado.Size = New System.Drawing.Size(288, 36)
        Me.TXT_CCTotalEsperado.TabIndex = 158
        '
        'Guna2GroupBox5
        '
        Me.Guna2GroupBox5.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Guna2GroupBox5.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Guna2GroupBox5.BorderRadius = 20
        Me.Guna2GroupBox5.Controls.Add(Me.TableLayoutPanel3)
        Me.Guna2GroupBox5.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Guna2GroupBox5.FillColor = System.Drawing.Color.Transparent
        Me.Guna2GroupBox5.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2GroupBox5.ForeColor = System.Drawing.Color.White
        Me.Guna2GroupBox5.Location = New System.Drawing.Point(12, 278)
        Me.Guna2GroupBox5.Name = "Guna2GroupBox5"
        Me.Guna2GroupBox5.Size = New System.Drawing.Size(587, 98)
        Me.Guna2GroupBox5.TabIndex = 154
        Me.Guna2GroupBox5.Text = "Diferencia"
        Me.Guna2GroupBox5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.ColumnCount = 2
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel3.Controls.Add(Me.Guna2Panel3, 0, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.Guna2Panel4, 1, 0)
        Me.TableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(0, 40)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 1
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(587, 58)
        Me.TableLayoutPanel3.TabIndex = 0
        '
        'Guna2Panel3
        '
        Me.Guna2Panel3.Controls.Add(Me.TXT_CCDiferenciaAbsoluta)
        Me.Guna2Panel3.Controls.Add(Me.Guna2HtmlLabel35)
        Me.Guna2Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Guna2Panel3.Location = New System.Drawing.Point(3, 3)
        Me.Guna2Panel3.Name = "Guna2Panel3"
        Me.Guna2Panel3.Size = New System.Drawing.Size(287, 52)
        Me.Guna2Panel3.TabIndex = 0
        '
        'TXT_CCDiferenciaAbsoluta
        '
        Me.TXT_CCDiferenciaAbsoluta.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TXT_CCDiferenciaAbsoluta.BorderRadius = 10
        Me.TXT_CCDiferenciaAbsoluta.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TXT_CCDiferenciaAbsoluta.DefaultText = ""
        Me.TXT_CCDiferenciaAbsoluta.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TXT_CCDiferenciaAbsoluta.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TXT_CCDiferenciaAbsoluta.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXT_CCDiferenciaAbsoluta.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXT_CCDiferenciaAbsoluta.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXT_CCDiferenciaAbsoluta.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.TXT_CCDiferenciaAbsoluta.ForeColor = System.Drawing.Color.Black
        Me.TXT_CCDiferenciaAbsoluta.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXT_CCDiferenciaAbsoluta.IconRightSize = New System.Drawing.Size(40, 40)
        Me.TXT_CCDiferenciaAbsoluta.Location = New System.Drawing.Point(108, 5)
        Me.TXT_CCDiferenciaAbsoluta.Name = "TXT_CCDiferenciaAbsoluta"
        Me.TXT_CCDiferenciaAbsoluta.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TXT_CCDiferenciaAbsoluta.PlaceholderText = ""
        Me.TXT_CCDiferenciaAbsoluta.ReadOnly = True
        Me.TXT_CCDiferenciaAbsoluta.SelectedText = ""
        Me.TXT_CCDiferenciaAbsoluta.Size = New System.Drawing.Size(167, 42)
        Me.TXT_CCDiferenciaAbsoluta.TabIndex = 169
        '
        'Guna2HtmlLabel35
        '
        Me.Guna2HtmlLabel35.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel35.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel35.ForeColor = System.Drawing.SystemColors.Control
        Me.Guna2HtmlLabel35.Location = New System.Drawing.Point(15, 12)
        Me.Guna2HtmlLabel35.Name = "Guna2HtmlLabel35"
        Me.Guna2HtmlLabel35.Size = New System.Drawing.Size(87, 27)
        Me.Guna2HtmlLabel35.TabIndex = 168
        Me.Guna2HtmlLabel35.Text = "Absoluta:"
        Me.Guna2HtmlLabel35.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit
        '
        'Guna2Panel4
        '
        Me.Guna2Panel4.Controls.Add(Me.TXT_CCDiferenciaPorcentual)
        Me.Guna2Panel4.Controls.Add(Me.Guna2HtmlLabel38)
        Me.Guna2Panel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Guna2Panel4.Location = New System.Drawing.Point(296, 3)
        Me.Guna2Panel4.Name = "Guna2Panel4"
        Me.Guna2Panel4.Size = New System.Drawing.Size(288, 52)
        Me.Guna2Panel4.TabIndex = 1
        '
        'TXT_CCDiferenciaPorcentual
        '
        Me.TXT_CCDiferenciaPorcentual.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TXT_CCDiferenciaPorcentual.BorderRadius = 10
        Me.TXT_CCDiferenciaPorcentual.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TXT_CCDiferenciaPorcentual.DefaultText = ""
        Me.TXT_CCDiferenciaPorcentual.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TXT_CCDiferenciaPorcentual.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TXT_CCDiferenciaPorcentual.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXT_CCDiferenciaPorcentual.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXT_CCDiferenciaPorcentual.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXT_CCDiferenciaPorcentual.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.TXT_CCDiferenciaPorcentual.ForeColor = System.Drawing.Color.Black
        Me.TXT_CCDiferenciaPorcentual.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXT_CCDiferenciaPorcentual.IconRightSize = New System.Drawing.Size(40, 40)
        Me.TXT_CCDiferenciaPorcentual.Location = New System.Drawing.Point(115, 5)
        Me.TXT_CCDiferenciaPorcentual.Name = "TXT_CCDiferenciaPorcentual"
        Me.TXT_CCDiferenciaPorcentual.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TXT_CCDiferenciaPorcentual.PlaceholderText = ""
        Me.TXT_CCDiferenciaPorcentual.ReadOnly = True
        Me.TXT_CCDiferenciaPorcentual.SelectedText = ""
        Me.TXT_CCDiferenciaPorcentual.Size = New System.Drawing.Size(170, 42)
        Me.TXT_CCDiferenciaPorcentual.TabIndex = 171
        '
        'Guna2HtmlLabel38
        '
        Me.Guna2HtmlLabel38.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel38.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel38.ForeColor = System.Drawing.SystemColors.Control
        Me.Guna2HtmlLabel38.Location = New System.Drawing.Point(6, 12)
        Me.Guna2HtmlLabel38.Name = "Guna2HtmlLabel38"
        Me.Guna2HtmlLabel38.Size = New System.Drawing.Size(103, 27)
        Me.Guna2HtmlLabel38.TabIndex = 170
        Me.Guna2HtmlLabel38.Text = "Porcentaje:"
        Me.Guna2HtmlLabel38.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit
        '
        'TXT_CCComentario
        '
        Me.TXT_CCComentario.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TXT_CCComentario.BorderRadius = 10
        Me.TXT_CCComentario.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TXT_CCComentario.DefaultText = ""
        Me.TXT_CCComentario.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TXT_CCComentario.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TXT_CCComentario.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXT_CCComentario.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXT_CCComentario.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXT_CCComentario.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.TXT_CCComentario.ForeColor = System.Drawing.Color.Black
        Me.TXT_CCComentario.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXT_CCComentario.IconRightSize = New System.Drawing.Size(40, 40)
        Me.TXT_CCComentario.Location = New System.Drawing.Point(170, 437)
        Me.TXT_CCComentario.Multiline = True
        Me.TXT_CCComentario.Name = "TXT_CCComentario"
        Me.TXT_CCComentario.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TXT_CCComentario.PlaceholderText = ""
        Me.TXT_CCComentario.SelectedText = ""
        Me.TXT_CCComentario.Size = New System.Drawing.Size(429, 84)
        Me.TXT_CCComentario.TabIndex = 165
        '
        'Guna2HtmlLabel37
        '
        Me.Guna2HtmlLabel37.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel37.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel37.ForeColor = System.Drawing.SystemColors.Control
        Me.Guna2HtmlLabel37.Location = New System.Drawing.Point(20, 459)
        Me.Guna2HtmlLabel37.Name = "Guna2HtmlLabel37"
        Me.Guna2HtmlLabel37.Size = New System.Drawing.Size(113, 27)
        Me.Guna2HtmlLabel37.TabIndex = 164
        Me.Guna2HtmlLabel37.Text = "Comentario:"
        Me.Guna2HtmlLabel37.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit
        '
        'NUD_CCSaldoSiguienteTurno
        '
        Me.NUD_CCSaldoSiguienteTurno.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.NUD_CCSaldoSiguienteTurno.BackColor = System.Drawing.Color.Transparent
        Me.NUD_CCSaldoSiguienteTurno.BorderRadius = 10
        Me.NUD_CCSaldoSiguienteTurno.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.NUD_CCSaldoSiguienteTurno.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.NUD_CCSaldoSiguienteTurno.Location = New System.Drawing.Point(235, 384)
        Me.NUD_CCSaldoSiguienteTurno.Maximum = New Decimal(New Integer() {100000000, 0, 0, 0})
        Me.NUD_CCSaldoSiguienteTurno.Name = "NUD_CCSaldoSiguienteTurno"
        Me.NUD_CCSaldoSiguienteTurno.Size = New System.Drawing.Size(194, 36)
        Me.NUD_CCSaldoSiguienteTurno.TabIndex = 163
        Me.NUD_CCSaldoSiguienteTurno.UpDownButtonFillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        '
        'Guna2HtmlLabel36
        '
        Me.Guna2HtmlLabel36.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel36.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel36.ForeColor = System.Drawing.SystemColors.Control
        Me.Guna2HtmlLabel36.Location = New System.Drawing.Point(20, 389)
        Me.Guna2HtmlLabel36.Name = "Guna2HtmlLabel36"
        Me.Guna2HtmlLabel36.Size = New System.Drawing.Size(200, 27)
        Me.Guna2HtmlLabel36.TabIndex = 162
        Me.Guna2HtmlLabel36.Text = "Saldo siguiente turno:"
        Me.Guna2HtmlLabel36.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit
        '
        'Guna2Panel2
        '
        Me.Guna2Panel2.Controls.Add(Me.TableLayoutPanel2)
        Me.Guna2Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Guna2Panel2.Location = New System.Drawing.Point(0, 628)
        Me.Guna2Panel2.Name = "Guna2Panel2"
        Me.Guna2Panel2.Size = New System.Drawing.Size(614, 66)
        Me.Guna2Panel2.TabIndex = 156
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 2
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel2.Controls.Add(Me.Guna2Button3, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.BTN_GenerarCierre, 1, 0)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 1
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 66.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(614, 66)
        Me.TableLayoutPanel2.TabIndex = 0
        '
        'Guna2Button3
        '
        Me.Guna2Button3.BorderRadius = 10
        Me.Guna2Button3.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Guna2Button3.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button3.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button3.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Guna2Button3.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Guna2Button3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Guna2Button3.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Guna2Button3.Font = New System.Drawing.Font("Ebrima", 20.25!, System.Drawing.FontStyle.Bold)
        Me.Guna2Button3.ForeColor = System.Drawing.Color.White
        Me.Guna2Button3.Image = CType(resources.GetObject("Guna2Button3.Image"), System.Drawing.Image)
        Me.Guna2Button3.ImageSize = New System.Drawing.Size(60, 60)
        Me.Guna2Button3.Location = New System.Drawing.Point(3, 3)
        Me.Guna2Button3.Name = "Guna2Button3"
        Me.Guna2Button3.Size = New System.Drawing.Size(301, 60)
        Me.Guna2Button3.TabIndex = 152
        Me.Guna2Button3.Text = "Regresar"
        '
        'BTN_GenerarCierre
        '
        Me.BTN_GenerarCierre.BackColor = System.Drawing.Color.Transparent
        Me.BTN_GenerarCierre.BorderColor = System.Drawing.Color.Red
        Me.BTN_GenerarCierre.BorderRadius = 10
        Me.BTN_GenerarCierre.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BTN_GenerarCierre.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BTN_GenerarCierre.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BTN_GenerarCierre.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BTN_GenerarCierre.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BTN_GenerarCierre.FillColor = System.Drawing.Color.MediumSeaGreen
        Me.BTN_GenerarCierre.Font = New System.Drawing.Font("Ebrima", 20.25!, System.Drawing.FontStyle.Bold)
        Me.BTN_GenerarCierre.ForeColor = System.Drawing.Color.White
        Me.BTN_GenerarCierre.Image = CType(resources.GetObject("BTN_GenerarCierre.Image"), System.Drawing.Image)
        Me.BTN_GenerarCierre.ImageSize = New System.Drawing.Size(50, 50)
        Me.BTN_GenerarCierre.Location = New System.Drawing.Point(310, 3)
        Me.BTN_GenerarCierre.Name = "BTN_GenerarCierre"
        Me.BTN_GenerarCierre.Size = New System.Drawing.Size(301, 60)
        Me.BTN_GenerarCierre.TabIndex = 151
        Me.BTN_GenerarCierre.Text = "Generar Cierre"
        '
        'Guna2GroupBox4
        '
        Me.Guna2GroupBox4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Guna2GroupBox4.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Guna2GroupBox4.BorderRadius = 20
        Me.Guna2GroupBox4.Controls.Add(Me.TXT_CCVentaTarjeta)
        Me.Guna2GroupBox4.Controls.Add(Me.Guna2HtmlLabel32)
        Me.Guna2GroupBox4.Controls.Add(Me.TXT_CCVentaEfectivo)
        Me.Guna2GroupBox4.Controls.Add(Me.Guna2HtmlLabel31)
        Me.Guna2GroupBox4.Controls.Add(Me.TXT_CCSaldoInicial)
        Me.Guna2GroupBox4.Controls.Add(Me.Guna2HtmlLabel30)
        Me.Guna2GroupBox4.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Guna2GroupBox4.FillColor = System.Drawing.Color.Transparent
        Me.Guna2GroupBox4.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2GroupBox4.ForeColor = System.Drawing.Color.White
        Me.Guna2GroupBox4.Location = New System.Drawing.Point(12, 16)
        Me.Guna2GroupBox4.Name = "Guna2GroupBox4"
        Me.Guna2GroupBox4.Size = New System.Drawing.Size(587, 163)
        Me.Guna2GroupBox4.TabIndex = 153
        Me.Guna2GroupBox4.Text = "Datos del cierre anterior"
        Me.Guna2GroupBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TXT_CCVentaTarjeta
        '
        Me.TXT_CCVentaTarjeta.BorderRadius = 10
        Me.TXT_CCVentaTarjeta.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TXT_CCVentaTarjeta.DefaultText = ""
        Me.TXT_CCVentaTarjeta.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TXT_CCVentaTarjeta.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TXT_CCVentaTarjeta.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXT_CCVentaTarjeta.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXT_CCVentaTarjeta.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXT_CCVentaTarjeta.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.TXT_CCVentaTarjeta.ForeColor = System.Drawing.Color.Black
        Me.TXT_CCVentaTarjeta.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXT_CCVentaTarjeta.IconRightSize = New System.Drawing.Size(40, 40)
        Me.TXT_CCVentaTarjeta.Location = New System.Drawing.Point(140, 106)
        Me.TXT_CCVentaTarjeta.Name = "TXT_CCVentaTarjeta"
        Me.TXT_CCVentaTarjeta.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TXT_CCVentaTarjeta.PlaceholderText = ""
        Me.TXT_CCVentaTarjeta.ReadOnly = True
        Me.TXT_CCVentaTarjeta.SelectedText = ""
        Me.TXT_CCVentaTarjeta.Size = New System.Drawing.Size(152, 42)
        Me.TXT_CCVentaTarjeta.TabIndex = 147
        '
        'Guna2HtmlLabel32
        '
        Me.Guna2HtmlLabel32.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Guna2HtmlLabel32.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel32.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel32.ForeColor = System.Drawing.SystemColors.Control
        Me.Guna2HtmlLabel32.Location = New System.Drawing.Point(15, 106)
        Me.Guna2HtmlLabel32.Name = "Guna2HtmlLabel32"
        Me.Guna2HtmlLabel32.Size = New System.Drawing.Size(119, 34)
        Me.Guna2HtmlLabel32.TabIndex = 146
        Me.Guna2HtmlLabel32.Text = "En tarjeta:"
        Me.Guna2HtmlLabel32.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit
        '
        'TXT_CCVentaEfectivo
        '
        Me.TXT_CCVentaEfectivo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TXT_CCVentaEfectivo.BorderRadius = 10
        Me.TXT_CCVentaEfectivo.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TXT_CCVentaEfectivo.DefaultText = ""
        Me.TXT_CCVentaEfectivo.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TXT_CCVentaEfectivo.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TXT_CCVentaEfectivo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXT_CCVentaEfectivo.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXT_CCVentaEfectivo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXT_CCVentaEfectivo.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.TXT_CCVentaEfectivo.ForeColor = System.Drawing.Color.Black
        Me.TXT_CCVentaEfectivo.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXT_CCVentaEfectivo.IconRightSize = New System.Drawing.Size(40, 40)
        Me.TXT_CCVentaEfectivo.Location = New System.Drawing.Point(440, 106)
        Me.TXT_CCVentaEfectivo.Name = "TXT_CCVentaEfectivo"
        Me.TXT_CCVentaEfectivo.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TXT_CCVentaEfectivo.PlaceholderText = ""
        Me.TXT_CCVentaEfectivo.ReadOnly = True
        Me.TXT_CCVentaEfectivo.SelectedText = ""
        Me.TXT_CCVentaEfectivo.Size = New System.Drawing.Size(139, 42)
        Me.TXT_CCVentaEfectivo.TabIndex = 145
        '
        'Guna2HtmlLabel31
        '
        Me.Guna2HtmlLabel31.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Guna2HtmlLabel31.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel31.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel31.ForeColor = System.Drawing.SystemColors.Control
        Me.Guna2HtmlLabel31.Location = New System.Drawing.Point(298, 111)
        Me.Guna2HtmlLabel31.Name = "Guna2HtmlLabel31"
        Me.Guna2HtmlLabel31.Size = New System.Drawing.Size(136, 34)
        Me.Guna2HtmlLabel31.TabIndex = 144
        Me.Guna2HtmlLabel31.Text = "En efectivo:"
        Me.Guna2HtmlLabel31.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit
        '
        'TXT_CCSaldoInicial
        '
        Me.TXT_CCSaldoInicial.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TXT_CCSaldoInicial.BorderRadius = 10
        Me.TXT_CCSaldoInicial.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TXT_CCSaldoInicial.DefaultText = ""
        Me.TXT_CCSaldoInicial.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TXT_CCSaldoInicial.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TXT_CCSaldoInicial.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXT_CCSaldoInicial.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXT_CCSaldoInicial.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXT_CCSaldoInicial.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.TXT_CCSaldoInicial.ForeColor = System.Drawing.Color.Black
        Me.TXT_CCSaldoInicial.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXT_CCSaldoInicial.IconRightSize = New System.Drawing.Size(40, 40)
        Me.TXT_CCSaldoInicial.Location = New System.Drawing.Point(168, 53)
        Me.TXT_CCSaldoInicial.Name = "TXT_CCSaldoInicial"
        Me.TXT_CCSaldoInicial.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TXT_CCSaldoInicial.PlaceholderText = ""
        Me.TXT_CCSaldoInicial.ReadOnly = True
        Me.TXT_CCSaldoInicial.SelectedText = ""
        Me.TXT_CCSaldoInicial.Size = New System.Drawing.Size(411, 42)
        Me.TXT_CCSaldoInicial.TabIndex = 143
        '
        'Guna2HtmlLabel30
        '
        Me.Guna2HtmlLabel30.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Guna2HtmlLabel30.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel30.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel30.ForeColor = System.Drawing.SystemColors.Control
        Me.Guna2HtmlLabel30.Location = New System.Drawing.Point(15, 53)
        Me.Guna2HtmlLabel30.Name = "Guna2HtmlLabel30"
        Me.Guna2HtmlLabel30.Size = New System.Drawing.Size(148, 34)
        Me.Guna2HtmlLabel30.TabIndex = 142
        Me.Guna2HtmlLabel30.Text = "Saldo inicial:"
        Me.Guna2HtmlLabel30.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit
        '
        'PrintDocument
        '
        '
        'PrintDialog
        '
        Me.PrintDialog.UseEXDialog = True
        '
        'P_ReporteVentas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1254, 754)
        Me.Controls.Add(Me.TAB_Reportes)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "P_ReporteVentas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Reportes"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.TAB_Reportes.ResumeLayout(False)
        Me.PAG_ReporteVentas.ResumeLayout(False)
        Me.PAG_ReporteVentas.PerformLayout()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.Guna2GroupBox1.ResumeLayout(False)
        Me.Guna2GroupBox1.PerformLayout()
        Me.Guna2GroupBox2.ResumeLayout(False)
        Me.Guna2GroupBox2.PerformLayout()
        Me.Guna2Panel1.ResumeLayout(False)
        CType(Me.DGV_FactReporte, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MNU_CONTX.ResumeLayout(False)
        Me.PAG_ReporteProd.ResumeLayout(False)
        Me.TBL_ReporteProductosGeneral.ResumeLayout(False)
        Me.TBL_ResultContainer.ResumeLayout(False)
        Me.GBX_ListaProductoCompleta.ResumeLayout(False)
        CType(Me.DGV_ListProductosMasVendidos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.DGV_MejorProducto.ResumeLayout(False)
        Me.DGV_MejorProducto.PerformLayout()
        Me.PAN_ReporteProductoInputContainer.ResumeLayout(False)
        Me.PAN_ReporteProductoInputContainer.PerformLayout()
        Me.Guna2GroupBox3.ResumeLayout(False)
        CType(Me.RDB_OrderByCant, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RDB_OrderByTotal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NUD_LimitReporteProducto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PAG_CierreCaja.ResumeLayout(False)
        Me.TBL_DivCierreCaja.ResumeLayout(False)
        Me.PAN_EfectivoReal.ResumeLayout(False)
        Me.TBL_IngresoEfectivoReal.ResumeLayout(False)
        Me.PAN_Moneda5.ResumeLayout(False)
        Me.PAN_Moneda5.PerformLayout()
        CType(Me.NUD_Moneda5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PAN_Billete1.ResumeLayout(False)
        Me.PAN_Billete1.PerformLayout()
        CType(Me.NUD_Billete1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PAN_Moneda10.ResumeLayout(False)
        Me.PAN_Moneda10.PerformLayout()
        CType(Me.NUD_Moneda10, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PAN_Billete2.ResumeLayout(False)
        Me.PAN_Billete2.PerformLayout()
        CType(Me.NUD_Billete2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PAN_Moneda25.ResumeLayout(False)
        Me.PAN_Moneda25.PerformLayout()
        CType(Me.NUD_Moneda25, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PAN_Billete5.ResumeLayout(False)
        Me.PAN_Billete5.PerformLayout()
        CType(Me.NUD_Billete5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Guna2Panel6.ResumeLayout(False)
        Me.PAN_Moneda50.ResumeLayout(False)
        Me.PAN_Moneda50.PerformLayout()
        CType(Me.NUD_Moneda50, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PAN_Billete10.ResumeLayout(False)
        Me.PAN_Billete10.PerformLayout()
        CType(Me.NUD_Billete10, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PAN_Moneda100.ResumeLayout(False)
        Me.PAN_Moneda100.PerformLayout()
        CType(Me.NUD_Moneda100, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PAN_Billete20.ResumeLayout(False)
        Me.PAN_Billete20.PerformLayout()
        CType(Me.NUD_Billete20, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PAN_Moneda500.ResumeLayout(False)
        Me.PAN_Moneda500.PerformLayout()
        CType(Me.NUD_Moneda500, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PAN_Billete50.ResumeLayout(False)
        Me.PAN_Billete50.PerformLayout()
        CType(Me.NUD_Billete50, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PAN_FooterEfectivoReal.ResumeLayout(False)
        Me.PAN_FooterEfectivoReal.PerformLayout()
        Me.PAN_HeaderEfectivoReal.ResumeLayout(False)
        Me.TableLayoutPanel5.ResumeLayout(False)
        Me.PAN_Cell2InfoCierre.ResumeLayout(False)
        Me.PAN_Cell2InfoCierre.PerformLayout()
        Me.TableLayoutPanel4.ResumeLayout(False)
        CType(Me.NUD_SalidasEfectivo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Guna2GroupBox5.ResumeLayout(False)
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.Guna2Panel3.ResumeLayout(False)
        Me.Guna2Panel3.PerformLayout()
        Me.Guna2Panel4.ResumeLayout(False)
        Me.Guna2Panel4.PerformLayout()
        CType(Me.NUD_CCSaldoSiguienteTurno, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Guna2Panel2.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.Guna2GroupBox4.ResumeLayout(False)
        Me.Guna2GroupBox4.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TAB_Reportes As Guna.UI2.WinForms.Guna2TabControl
    Friend WithEvents PAG_ReporteVentas As TabPage
    Friend WithEvents PAG_ReporteProd As TabPage
    Friend WithEvents Guna2HtmlLabel2 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel1 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents LBL_Usu As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents TXT_TotalVentas As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents BTN_RegresarReporte As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BTN_GenReporte As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents DTP_Hasta As Guna.UI2.WinForms.Guna2DateTimePicker
    Friend WithEvents DTP_Desde As Guna.UI2.WinForms.Guna2DateTimePicker
    Friend WithEvents DGV_FactReporte As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents BTN_GenerarReporteVentaPDF As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2HtmlLabel3 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents TXT_VentasEfectivo As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2HtmlLabel4 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents TXT_VentasTarjeta As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2HtmlLabel5 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents TXT_CantFacturas As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents TXT_NombreProdMasVendido As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2GroupBox1 As Guna.UI2.WinForms.Guna2GroupBox
    Friend WithEvents Guna2HtmlLabel6 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents PAG_CierreCaja As TabPage
    Friend WithEvents Guna2HtmlLabel8 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel9 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents TXT_TotalProdMasVendido As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents TXT_CantProdMasVendido As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2GroupBox2 As Guna.UI2.WinForms.Guna2GroupBox
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents DGV_MejorProducto As Guna.UI2.WinForms.Guna2GroupBox
    Friend WithEvents TXT_MejorProductoCant As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents TXT_MejorProductoTotal As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2HtmlLabel7 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel10 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel11 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents TXT_MejorProductoNombre As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents GBX_ListaProductoCompleta As Guna.UI2.WinForms.Guna2GroupBox
    Friend WithEvents DGV_ListProductosMasVendidos As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents TBL_ReporteProductosGeneral As TableLayoutPanel
    Friend WithEvents TBL_ResultContainer As TableLayoutPanel
    Friend WithEvents PAN_ReporteProductoInputContainer As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2HtmlLabel12 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents NUD_LimitReporteProducto As Guna.UI2.WinForms.Guna2NumericUpDown
    Friend WithEvents BTN_RegresarReporteProducto As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2HtmlLabel13 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel14 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents DTP_HastaReporteProducto As Guna.UI2.WinForms.Guna2DateTimePicker
    Friend WithEvents DTP_DesdeReporteProducto As Guna.UI2.WinForms.Guna2DateTimePicker
    Friend WithEvents BTN_GenReporteProductos As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2HtmlLabel15 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2GroupBox3 As Guna.UI2.WinForms.Guna2GroupBox
    Friend WithEvents RDB_OrderByTotal As Syncfusion.Windows.Forms.Tools.RadioButtonAdv
    Friend WithEvents RDB_OrderByCant As Syncfusion.Windows.Forms.Tools.RadioButtonAdv
    Friend WithEvents TBL_DivCierreCaja As TableLayoutPanel
    Friend WithEvents PAN_EfectivoReal As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents PAN_HeaderEfectivoReal As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2HtmlLabel16 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents PAN_FooterEfectivoReal As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents TBL_IngresoEfectivoReal As TableLayoutPanel
    Friend WithEvents PAN_Moneda5 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents PAN_Billete1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents PAN_Moneda10 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents PAN_Billete2 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents PAN_Moneda25 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents PAN_Billete5 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2Panel6 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents PAN_Moneda50 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents PAN_Billete10 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents PAN_Moneda100 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents PAN_Billete20 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents PAN_Moneda500 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents PAN_Billete50 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents NUD_Billete50 As Guna.UI2.WinForms.Guna2NumericUpDown
    Friend WithEvents Guna2HtmlLabel17 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents NUD_Billete1 As Guna.UI2.WinForms.Guna2NumericUpDown
    Friend WithEvents Guna2HtmlLabel22 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents NUD_Billete2 As Guna.UI2.WinForms.Guna2NumericUpDown
    Friend WithEvents Guna2HtmlLabel21 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents NUD_Billete5 As Guna.UI2.WinForms.Guna2NumericUpDown
    Friend WithEvents Guna2HtmlLabel20 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents NUD_Billete10 As Guna.UI2.WinForms.Guna2NumericUpDown
    Friend WithEvents Guna2HtmlLabel19 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents NUD_Billete20 As Guna.UI2.WinForms.Guna2NumericUpDown
    Friend WithEvents Guna2HtmlLabel18 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents NUD_Moneda500 As Guna.UI2.WinForms.Guna2NumericUpDown
    Friend WithEvents Guna2HtmlLabel23 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents NUD_Moneda5 As Guna.UI2.WinForms.Guna2NumericUpDown
    Friend WithEvents Guna2HtmlLabel28 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents NUD_Moneda10 As Guna.UI2.WinForms.Guna2NumericUpDown
    Friend WithEvents Guna2HtmlLabel27 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents NUD_Moneda25 As Guna.UI2.WinForms.Guna2NumericUpDown
    Friend WithEvents Guna2HtmlLabel26 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents NUD_Moneda50 As Guna.UI2.WinForms.Guna2NumericUpDown
    Friend WithEvents Guna2HtmlLabel25 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents NUD_Moneda100 As Guna.UI2.WinForms.Guna2NumericUpDown
    Friend WithEvents Guna2HtmlLabel24 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents TXT_EfectivoReal As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2HtmlLabel29 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents PAN_Cell2InfoCierre As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2GroupBox4 As Guna.UI2.WinForms.Guna2GroupBox
    Friend WithEvents TXT_CCSaldoInicial As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2HtmlLabel30 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents TXT_CCVentaEfectivo As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2HtmlLabel31 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents TXT_CCVentaTarjeta As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2HtmlLabel32 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2Panel2 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents BTN_GenerarCierre As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2HtmlLabel33 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2Button3 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents TXT_CCTotalEsperado As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents NUD_SalidasEfectivo As Guna.UI2.WinForms.Guna2NumericUpDown
    Friend WithEvents NUD_CCSaldoSiguienteTurno As Guna.UI2.WinForms.Guna2NumericUpDown
    Friend WithEvents Guna2HtmlLabel36 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents TXT_CCComentario As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2HtmlLabel37 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2GroupBox5 As Guna.UI2.WinForms.Guna2GroupBox
    Friend WithEvents BTN_CCLimpiarCierre As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents Guna2Panel3 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents TXT_CCDiferenciaPorcentual As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2HtmlLabel38 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel35 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents TXT_CCDiferenciaAbsoluta As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2Panel4 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents TableLayoutPanel4 As TableLayoutPanel
    Friend WithEvents Guna2HtmlLabel39 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents MNU_CONTX As Guna.UI2.WinForms.Guna2ContextMenuStrip
    Friend WithEvents MNU_REIMPRIMIR As ToolStripMenuItem
    Friend WithEvents MNU_Datos As ToolStripMenuItem
    Friend WithEvents PrintDocument As Printing.PrintDocument
    Friend WithEvents PrintDialog As PrintDialog
    Friend WithEvents BTN_CalcularSaldoSiguiente As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents TableLayoutPanel5 As TableLayoutPanel
    Friend WithEvents BTN_VerCierres As Guna.UI2.WinForms.Guna2Button
End Class
