Namespace SistemaFacturacion.Forms.Caja
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Class P_GenerarCierreCaja
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(P_GenerarCierreCaja))
            Me.Guna2HtmlLabel16 = New Guna.UI2.WinForms.Guna2HtmlLabel()
            Me.TBL_LayoutGeneral = New System.Windows.Forms.TableLayoutPanel()
            Me.BTN_CerrarSesionCaja = New Guna.UI2.WinForms.Guna2Button()
            Me.PAN_DatosCierre = New Guna.UI2.WinForms.Guna2Panel()
            Me.BTN_LimpiarCierre = New Guna.UI2.WinForms.Guna2Button()
            Me.Guna2GroupBox5 = New Guna.UI2.WinForms.Guna2GroupBox()
            Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
            Me.Guna2Panel3 = New Guna.UI2.WinForms.Guna2Panel()
            Me.TXT_DiferenciaAbsoluta = New Guna.UI2.WinForms.Guna2TextBox()
            Me.Guna2HtmlLabel35 = New Guna.UI2.WinForms.Guna2HtmlLabel()
            Me.Guna2Panel4 = New Guna.UI2.WinForms.Guna2Panel()
            Me.TXT_DiferenciaPorcentual = New Guna.UI2.WinForms.Guna2TextBox()
            Me.Guna2HtmlLabel38 = New Guna.UI2.WinForms.Guna2HtmlLabel()
            Me.TXT_SaldoEsperado = New Guna.UI2.WinForms.Guna2TextBox()
            Me.Guna2HtmlLabel2 = New Guna.UI2.WinForms.Guna2HtmlLabel()
            Me.TableLayoutPanel4 = New System.Windows.Forms.TableLayoutPanel()
            Me.TXT_SalidasRegistradas = New Guna.UI2.WinForms.Guna2TextBox()
            Me.Guna2HtmlLabel39 = New Guna.UI2.WinForms.Guna2HtmlLabel()
            Me.Guna2HtmlLabel33 = New Guna.UI2.WinForms.Guna2HtmlLabel()
            Me.TXT_EntradasRegistradas = New Guna.UI2.WinForms.Guna2TextBox()
            Me.Guna2GroupBox4 = New Guna.UI2.WinForms.Guna2GroupBox()
            Me.TXT_VentaTarjeta = New Guna.UI2.WinForms.Guna2TextBox()
            Me.Guna2HtmlLabel32 = New Guna.UI2.WinForms.Guna2HtmlLabel()
            Me.TXT_VentaEfectivo = New Guna.UI2.WinForms.Guna2TextBox()
            Me.Guna2HtmlLabel31 = New Guna.UI2.WinForms.Guna2HtmlLabel()
            Me.TXT_SaldoInicial = New Guna.UI2.WinForms.Guna2TextBox()
            Me.Guna2HtmlLabel30 = New Guna.UI2.WinForms.Guna2HtmlLabel()
            Me.BTN_RegresarCierreCaja = New Guna.UI2.WinForms.Guna2Button()
            Me.PAN_EfectivoReal = New Guna.UI2.WinForms.Guna2Panel()
            Me.TXT_DineroReal = New Guna.UI2.WinForms.Guna2TextBox()
            Me.Guna2HtmlLabel1 = New Guna.UI2.WinForms.Guna2HtmlLabel()
            Me.PAN_DineroReal = New Guna.UI2.WinForms.Guna2Panel()
            Me.Guna2GroupBox1 = New Guna.UI2.WinForms.Guna2GroupBox()
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
            Me.TBL_LayoutGeneral.SuspendLayout()
            Me.PAN_DatosCierre.SuspendLayout()
            Me.Guna2GroupBox5.SuspendLayout()
            Me.TableLayoutPanel3.SuspendLayout()
            Me.Guna2Panel3.SuspendLayout()
            Me.Guna2Panel4.SuspendLayout()
            Me.TableLayoutPanel4.SuspendLayout()
            Me.Guna2GroupBox4.SuspendLayout()
            Me.PAN_EfectivoReal.SuspendLayout()
            Me.PAN_DineroReal.SuspendLayout()
            Me.Guna2GroupBox1.SuspendLayout()
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
            Me.SuspendLayout()
            '
            'Guna2HtmlLabel16
            '
            Me.Guna2HtmlLabel16.AutoSize = False
            Me.Guna2HtmlLabel16.BackColor = System.Drawing.Color.Transparent
            Me.Guna2HtmlLabel16.Dock = System.Windows.Forms.DockStyle.Top
            Me.Guna2HtmlLabel16.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Guna2HtmlLabel16.ForeColor = System.Drawing.SystemColors.Control
            Me.Guna2HtmlLabel16.Location = New System.Drawing.Point(0, 0)
            Me.Guna2HtmlLabel16.Name = "Guna2HtmlLabel16"
            Me.Guna2HtmlLabel16.Size = New System.Drawing.Size(1075, 34)
            Me.Guna2HtmlLabel16.TabIndex = 160
            Me.Guna2HtmlLabel16.Text = "Registrar cierre de caja"
            Me.Guna2HtmlLabel16.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
            Me.Guna2HtmlLabel16.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit
            '
            'TBL_LayoutGeneral
            '
            Me.TBL_LayoutGeneral.ColumnCount = 2
            Me.TBL_LayoutGeneral.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 47.14715!))
            Me.TBL_LayoutGeneral.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 52.85285!))
            Me.TBL_LayoutGeneral.Controls.Add(Me.BTN_CerrarSesionCaja, 1, 2)
            Me.TBL_LayoutGeneral.Controls.Add(Me.PAN_DatosCierre, 1, 0)
            Me.TBL_LayoutGeneral.Controls.Add(Me.BTN_RegresarCierreCaja, 1, 1)
            Me.TBL_LayoutGeneral.Controls.Add(Me.PAN_EfectivoReal, 0, 2)
            Me.TBL_LayoutGeneral.Controls.Add(Me.PAN_DineroReal, 0, 0)
            Me.TBL_LayoutGeneral.Dock = System.Windows.Forms.DockStyle.Fill
            Me.TBL_LayoutGeneral.Location = New System.Drawing.Point(0, 34)
            Me.TBL_LayoutGeneral.Name = "TBL_LayoutGeneral"
            Me.TBL_LayoutGeneral.RowCount = 3
            Me.TBL_LayoutGeneral.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90.9241!))
            Me.TBL_LayoutGeneral.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.075908!))
            Me.TBL_LayoutGeneral.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 51.0!))
            Me.TBL_LayoutGeneral.Size = New System.Drawing.Size(1075, 658)
            Me.TBL_LayoutGeneral.TabIndex = 161
            '
            'BTN_CerrarSesionCaja
            '
            Me.BTN_CerrarSesionCaja.BackColor = System.Drawing.Color.Transparent
            Me.BTN_CerrarSesionCaja.BorderColor = System.Drawing.Color.Red
            Me.BTN_CerrarSesionCaja.BorderRadius = 10
            Me.BTN_CerrarSesionCaja.DialogResult = System.Windows.Forms.DialogResult.OK
            Me.BTN_CerrarSesionCaja.DisabledState.BorderColor = System.Drawing.Color.DarkGray
            Me.BTN_CerrarSesionCaja.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
            Me.BTN_CerrarSesionCaja.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
            Me.BTN_CerrarSesionCaja.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
            Me.BTN_CerrarSesionCaja.Dock = System.Windows.Forms.DockStyle.Fill
            Me.BTN_CerrarSesionCaja.FillColor = System.Drawing.Color.MediumSeaGreen
            Me.BTN_CerrarSesionCaja.Font = New System.Drawing.Font("Ebrima", 20.25!, System.Drawing.FontStyle.Bold)
            Me.BTN_CerrarSesionCaja.ForeColor = System.Drawing.Color.White
            Me.BTN_CerrarSesionCaja.Image = Global.SistemaFacturaciónCommon.My.Resources.Resources.ICO_Check
            Me.BTN_CerrarSesionCaja.ImageSize = New System.Drawing.Size(40, 40)
            Me.BTN_CerrarSesionCaja.Location = New System.Drawing.Point(509, 609)
            Me.BTN_CerrarSesionCaja.Name = "BTN_CerrarSesionCaja"
            Me.BTN_CerrarSesionCaja.Size = New System.Drawing.Size(563, 46)
            Me.BTN_CerrarSesionCaja.TabIndex = 157
            Me.BTN_CerrarSesionCaja.Text = "Finalizar turno"
            '
            'PAN_DatosCierre
            '
            Me.PAN_DatosCierre.Controls.Add(Me.BTN_LimpiarCierre)
            Me.PAN_DatosCierre.Controls.Add(Me.Guna2GroupBox5)
            Me.PAN_DatosCierre.Controls.Add(Me.TXT_SaldoEsperado)
            Me.PAN_DatosCierre.Controls.Add(Me.Guna2HtmlLabel2)
            Me.PAN_DatosCierre.Controls.Add(Me.TableLayoutPanel4)
            Me.PAN_DatosCierre.Controls.Add(Me.Guna2GroupBox4)
            Me.PAN_DatosCierre.Dock = System.Windows.Forms.DockStyle.Fill
            Me.PAN_DatosCierre.Location = New System.Drawing.Point(509, 3)
            Me.PAN_DatosCierre.Name = "PAN_DatosCierre"
            Me.PAN_DatosCierre.Size = New System.Drawing.Size(563, 545)
            Me.PAN_DatosCierre.TabIndex = 158
            '
            'BTN_LimpiarCierre
            '
            Me.BTN_LimpiarCierre.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.BTN_LimpiarCierre.BorderColor = System.Drawing.Color.IndianRed
            Me.BTN_LimpiarCierre.BorderRadius = 10
            Me.BTN_LimpiarCierre.BorderThickness = 2
            Me.BTN_LimpiarCierre.DialogResult = System.Windows.Forms.DialogResult.Cancel
            Me.BTN_LimpiarCierre.DisabledState.BorderColor = System.Drawing.Color.DarkGray
            Me.BTN_LimpiarCierre.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
            Me.BTN_LimpiarCierre.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
            Me.BTN_LimpiarCierre.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
            Me.BTN_LimpiarCierre.FillColor = System.Drawing.Color.Transparent
            Me.BTN_LimpiarCierre.FocusedColor = System.Drawing.Color.Silver
            Me.BTN_LimpiarCierre.Font = New System.Drawing.Font("Ebrima", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.BTN_LimpiarCierre.ForeColor = System.Drawing.Color.White
            Me.BTN_LimpiarCierre.Image = CType(resources.GetObject("BTN_LimpiarCierre.Image"), System.Drawing.Image)
            Me.BTN_LimpiarCierre.ImageSize = New System.Drawing.Size(50, 50)
            Me.BTN_LimpiarCierre.Location = New System.Drawing.Point(15, 452)
            Me.BTN_LimpiarCierre.Name = "BTN_LimpiarCierre"
            Me.BTN_LimpiarCierre.Size = New System.Drawing.Size(207, 60)
            Me.BTN_LimpiarCierre.TabIndex = 171
            Me.BTN_LimpiarCierre.Text = "Limpiar"
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
            Me.Guna2GroupBox5.Location = New System.Drawing.Point(15, 331)
            Me.Guna2GroupBox5.Name = "Guna2GroupBox5"
            Me.Guna2GroupBox5.Size = New System.Drawing.Size(532, 98)
            Me.Guna2GroupBox5.TabIndex = 170
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
            Me.TableLayoutPanel3.Size = New System.Drawing.Size(532, 58)
            Me.TableLayoutPanel3.TabIndex = 0
            '
            'Guna2Panel3
            '
            Me.Guna2Panel3.Controls.Add(Me.TXT_DiferenciaAbsoluta)
            Me.Guna2Panel3.Controls.Add(Me.Guna2HtmlLabel35)
            Me.Guna2Panel3.Dock = System.Windows.Forms.DockStyle.Fill
            Me.Guna2Panel3.Location = New System.Drawing.Point(3, 3)
            Me.Guna2Panel3.Name = "Guna2Panel3"
            Me.Guna2Panel3.Size = New System.Drawing.Size(260, 52)
            Me.Guna2Panel3.TabIndex = 0
            '
            'TXT_DiferenciaAbsoluta
            '
            Me.TXT_DiferenciaAbsoluta.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.TXT_DiferenciaAbsoluta.BorderRadius = 10
            Me.TXT_DiferenciaAbsoluta.Cursor = System.Windows.Forms.Cursors.IBeam
            Me.TXT_DiferenciaAbsoluta.DefaultText = "0.00"
            Me.TXT_DiferenciaAbsoluta.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
            Me.TXT_DiferenciaAbsoluta.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
            Me.TXT_DiferenciaAbsoluta.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
            Me.TXT_DiferenciaAbsoluta.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
            Me.TXT_DiferenciaAbsoluta.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.TXT_DiferenciaAbsoluta.Font = New System.Drawing.Font("Segoe UI", 9.0!)
            Me.TXT_DiferenciaAbsoluta.ForeColor = System.Drawing.Color.Black
            Me.TXT_DiferenciaAbsoluta.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.TXT_DiferenciaAbsoluta.IconRightSize = New System.Drawing.Size(40, 40)
            Me.TXT_DiferenciaAbsoluta.Location = New System.Drawing.Point(108, 5)
            Me.TXT_DiferenciaAbsoluta.Name = "TXT_DiferenciaAbsoluta"
            Me.TXT_DiferenciaAbsoluta.PlaceholderText = ""
            Me.TXT_DiferenciaAbsoluta.ReadOnly = True
            Me.TXT_DiferenciaAbsoluta.SelectedText = ""
            Me.TXT_DiferenciaAbsoluta.Size = New System.Drawing.Size(140, 42)
            Me.TXT_DiferenciaAbsoluta.TabIndex = 169
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
            Me.Guna2Panel4.Controls.Add(Me.TXT_DiferenciaPorcentual)
            Me.Guna2Panel4.Controls.Add(Me.Guna2HtmlLabel38)
            Me.Guna2Panel4.Dock = System.Windows.Forms.DockStyle.Fill
            Me.Guna2Panel4.Location = New System.Drawing.Point(269, 3)
            Me.Guna2Panel4.Name = "Guna2Panel4"
            Me.Guna2Panel4.Size = New System.Drawing.Size(260, 52)
            Me.Guna2Panel4.TabIndex = 1
            '
            'TXT_DiferenciaPorcentual
            '
            Me.TXT_DiferenciaPorcentual.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.TXT_DiferenciaPorcentual.BorderRadius = 10
            Me.TXT_DiferenciaPorcentual.Cursor = System.Windows.Forms.Cursors.IBeam
            Me.TXT_DiferenciaPorcentual.DefaultText = "0.00"
            Me.TXT_DiferenciaPorcentual.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
            Me.TXT_DiferenciaPorcentual.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
            Me.TXT_DiferenciaPorcentual.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
            Me.TXT_DiferenciaPorcentual.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
            Me.TXT_DiferenciaPorcentual.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.TXT_DiferenciaPorcentual.Font = New System.Drawing.Font("Segoe UI", 9.0!)
            Me.TXT_DiferenciaPorcentual.ForeColor = System.Drawing.Color.Black
            Me.TXT_DiferenciaPorcentual.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.TXT_DiferenciaPorcentual.IconRightSize = New System.Drawing.Size(40, 40)
            Me.TXT_DiferenciaPorcentual.Location = New System.Drawing.Point(115, 5)
            Me.TXT_DiferenciaPorcentual.Name = "TXT_DiferenciaPorcentual"
            Me.TXT_DiferenciaPorcentual.PlaceholderText = ""
            Me.TXT_DiferenciaPorcentual.ReadOnly = True
            Me.TXT_DiferenciaPorcentual.SelectedText = ""
            Me.TXT_DiferenciaPorcentual.Size = New System.Drawing.Size(142, 42)
            Me.TXT_DiferenciaPorcentual.TabIndex = 171
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
            'TXT_SaldoEsperado
            '
            Me.TXT_SaldoEsperado.BorderRadius = 10
            Me.TXT_SaldoEsperado.Cursor = System.Windows.Forms.Cursors.IBeam
            Me.TXT_SaldoEsperado.DefaultText = "0.00"
            Me.TXT_SaldoEsperado.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
            Me.TXT_SaldoEsperado.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
            Me.TXT_SaldoEsperado.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
            Me.TXT_SaldoEsperado.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
            Me.TXT_SaldoEsperado.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.TXT_SaldoEsperado.Font = New System.Drawing.Font("Segoe UI", 9.0!)
            Me.TXT_SaldoEsperado.ForeColor = System.Drawing.Color.Black
            Me.TXT_SaldoEsperado.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.TXT_SaldoEsperado.IconRightSize = New System.Drawing.Size(40, 40)
            Me.TXT_SaldoEsperado.Location = New System.Drawing.Point(255, 276)
            Me.TXT_SaldoEsperado.Name = "TXT_SaldoEsperado"
            Me.TXT_SaldoEsperado.PlaceholderText = ""
            Me.TXT_SaldoEsperado.ReadOnly = True
            Me.TXT_SaldoEsperado.SelectedText = ""
            Me.TXT_SaldoEsperado.Size = New System.Drawing.Size(269, 36)
            Me.TXT_SaldoEsperado.TabIndex = 169
            '
            'Guna2HtmlLabel2
            '
            Me.Guna2HtmlLabel2.AutoSize = False
            Me.Guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent
            Me.Guna2HtmlLabel2.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Guna2HtmlLabel2.ForeColor = System.Drawing.SystemColors.Control
            Me.Guna2HtmlLabel2.Location = New System.Drawing.Point(15, 279)
            Me.Guna2HtmlLabel2.Name = "Guna2HtmlLabel2"
            Me.Guna2HtmlLabel2.Size = New System.Drawing.Size(241, 30)
            Me.Guna2HtmlLabel2.TabIndex = 168
            Me.Guna2HtmlLabel2.Text = "Dinero esperado en caja:"
            Me.Guna2HtmlLabel2.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
            Me.Guna2HtmlLabel2.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit
            '
            'TableLayoutPanel4
            '
            Me.TableLayoutPanel4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.TableLayoutPanel4.ColumnCount = 2
            Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
            Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
            Me.TableLayoutPanel4.Controls.Add(Me.TXT_SalidasRegistradas, 0, 1)
            Me.TableLayoutPanel4.Controls.Add(Me.Guna2HtmlLabel39, 1, 0)
            Me.TableLayoutPanel4.Controls.Add(Me.Guna2HtmlLabel33, 0, 0)
            Me.TableLayoutPanel4.Controls.Add(Me.TXT_EntradasRegistradas, 1, 1)
            Me.TableLayoutPanel4.Location = New System.Drawing.Point(15, 171)
            Me.TableLayoutPanel4.Name = "TableLayoutPanel4"
            Me.TableLayoutPanel4.RowCount = 2
            Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 43.90244!))
            Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 56.09756!))
            Me.TableLayoutPanel4.Size = New System.Drawing.Size(532, 82)
            Me.TableLayoutPanel4.TabIndex = 167
            '
            'TXT_SalidasRegistradas
            '
            Me.TXT_SalidasRegistradas.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.TXT_SalidasRegistradas.BorderRadius = 10
            Me.TXT_SalidasRegistradas.Cursor = System.Windows.Forms.Cursors.IBeam
            Me.TXT_SalidasRegistradas.DefaultText = "0.00"
            Me.TXT_SalidasRegistradas.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
            Me.TXT_SalidasRegistradas.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
            Me.TXT_SalidasRegistradas.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
            Me.TXT_SalidasRegistradas.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
            Me.TXT_SalidasRegistradas.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.TXT_SalidasRegistradas.Font = New System.Drawing.Font("Segoe UI", 9.0!)
            Me.TXT_SalidasRegistradas.ForeColor = System.Drawing.Color.Black
            Me.TXT_SalidasRegistradas.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.TXT_SalidasRegistradas.IconRightSize = New System.Drawing.Size(40, 40)
            Me.TXT_SalidasRegistradas.Location = New System.Drawing.Point(3, 39)
            Me.TXT_SalidasRegistradas.Name = "TXT_SalidasRegistradas"
            Me.TXT_SalidasRegistradas.PlaceholderText = ""
            Me.TXT_SalidasRegistradas.ReadOnly = True
            Me.TXT_SalidasRegistradas.SelectedText = ""
            Me.TXT_SalidasRegistradas.Size = New System.Drawing.Size(260, 36)
            Me.TXT_SalidasRegistradas.TabIndex = 159
            '
            'Guna2HtmlLabel39
            '
            Me.Guna2HtmlLabel39.AutoSize = False
            Me.Guna2HtmlLabel39.BackColor = System.Drawing.Color.Transparent
            Me.Guna2HtmlLabel39.Dock = System.Windows.Forms.DockStyle.Fill
            Me.Guna2HtmlLabel39.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Guna2HtmlLabel39.ForeColor = System.Drawing.SystemColors.Control
            Me.Guna2HtmlLabel39.Location = New System.Drawing.Point(269, 3)
            Me.Guna2HtmlLabel39.Name = "Guna2HtmlLabel39"
            Me.Guna2HtmlLabel39.Size = New System.Drawing.Size(260, 30)
            Me.Guna2HtmlLabel39.TabIndex = 158
            Me.Guna2HtmlLabel39.Text = "Entradas"
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
            Me.Guna2HtmlLabel33.Size = New System.Drawing.Size(260, 30)
            Me.Guna2HtmlLabel33.TabIndex = 154
            Me.Guna2HtmlLabel33.Text = "Salidas "
            Me.Guna2HtmlLabel33.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
            Me.Guna2HtmlLabel33.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit
            '
            'TXT_EntradasRegistradas
            '
            Me.TXT_EntradasRegistradas.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.TXT_EntradasRegistradas.BorderRadius = 10
            Me.TXT_EntradasRegistradas.Cursor = System.Windows.Forms.Cursors.IBeam
            Me.TXT_EntradasRegistradas.DefaultText = "0.00"
            Me.TXT_EntradasRegistradas.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
            Me.TXT_EntradasRegistradas.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
            Me.TXT_EntradasRegistradas.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
            Me.TXT_EntradasRegistradas.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
            Me.TXT_EntradasRegistradas.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.TXT_EntradasRegistradas.Font = New System.Drawing.Font("Segoe UI", 9.0!)
            Me.TXT_EntradasRegistradas.ForeColor = System.Drawing.Color.Black
            Me.TXT_EntradasRegistradas.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.TXT_EntradasRegistradas.IconRightSize = New System.Drawing.Size(40, 40)
            Me.TXT_EntradasRegistradas.Location = New System.Drawing.Point(269, 39)
            Me.TXT_EntradasRegistradas.Name = "TXT_EntradasRegistradas"
            Me.TXT_EntradasRegistradas.PlaceholderText = ""
            Me.TXT_EntradasRegistradas.ReadOnly = True
            Me.TXT_EntradasRegistradas.SelectedText = ""
            Me.TXT_EntradasRegistradas.Size = New System.Drawing.Size(260, 36)
            Me.TXT_EntradasRegistradas.TabIndex = 158
            '
            'Guna2GroupBox4
            '
            Me.Guna2GroupBox4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.Guna2GroupBox4.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.Guna2GroupBox4.BorderRadius = 20
            Me.Guna2GroupBox4.Controls.Add(Me.TXT_VentaTarjeta)
            Me.Guna2GroupBox4.Controls.Add(Me.Guna2HtmlLabel32)
            Me.Guna2GroupBox4.Controls.Add(Me.TXT_VentaEfectivo)
            Me.Guna2GroupBox4.Controls.Add(Me.Guna2HtmlLabel31)
            Me.Guna2GroupBox4.Controls.Add(Me.TXT_SaldoInicial)
            Me.Guna2GroupBox4.Controls.Add(Me.Guna2HtmlLabel30)
            Me.Guna2GroupBox4.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.Guna2GroupBox4.FillColor = System.Drawing.Color.Transparent
            Me.Guna2GroupBox4.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Guna2GroupBox4.ForeColor = System.Drawing.Color.White
            Me.Guna2GroupBox4.Location = New System.Drawing.Point(15, 6)
            Me.Guna2GroupBox4.Name = "Guna2GroupBox4"
            Me.Guna2GroupBox4.Size = New System.Drawing.Size(532, 151)
            Me.Guna2GroupBox4.TabIndex = 159
            Me.Guna2GroupBox4.Text = "Datos Iniciales del turno"
            Me.Guna2GroupBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
            '
            'TXT_VentaTarjeta
            '
            Me.TXT_VentaTarjeta.BorderRadius = 10
            Me.TXT_VentaTarjeta.Cursor = System.Windows.Forms.Cursors.IBeam
            Me.TXT_VentaTarjeta.DefaultText = "0.00"
            Me.TXT_VentaTarjeta.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
            Me.TXT_VentaTarjeta.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
            Me.TXT_VentaTarjeta.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
            Me.TXT_VentaTarjeta.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
            Me.TXT_VentaTarjeta.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.TXT_VentaTarjeta.Font = New System.Drawing.Font("Segoe UI", 9.0!)
            Me.TXT_VentaTarjeta.ForeColor = System.Drawing.Color.Black
            Me.TXT_VentaTarjeta.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.TXT_VentaTarjeta.IconRightSize = New System.Drawing.Size(40, 40)
            Me.TXT_VentaTarjeta.Location = New System.Drawing.Point(111, 106)
            Me.TXT_VentaTarjeta.Name = "TXT_VentaTarjeta"
            Me.TXT_VentaTarjeta.PlaceholderText = ""
            Me.TXT_VentaTarjeta.ReadOnly = True
            Me.TXT_VentaTarjeta.SelectedText = ""
            Me.TXT_VentaTarjeta.Size = New System.Drawing.Size(140, 36)
            Me.TXT_VentaTarjeta.TabIndex = 147
            '
            'Guna2HtmlLabel32
            '
            Me.Guna2HtmlLabel32.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.Guna2HtmlLabel32.BackColor = System.Drawing.Color.Transparent
            Me.Guna2HtmlLabel32.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Guna2HtmlLabel32.ForeColor = System.Drawing.SystemColors.Control
            Me.Guna2HtmlLabel32.Location = New System.Drawing.Point(13, 110)
            Me.Guna2HtmlLabel32.Name = "Guna2HtmlLabel32"
            Me.Guna2HtmlLabel32.Size = New System.Drawing.Size(92, 27)
            Me.Guna2HtmlLabel32.TabIndex = 146
            Me.Guna2HtmlLabel32.Text = "En tarjeta:"
            Me.Guna2HtmlLabel32.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit
            '
            'TXT_VentaEfectivo
            '
            Me.TXT_VentaEfectivo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.TXT_VentaEfectivo.BorderRadius = 10
            Me.TXT_VentaEfectivo.Cursor = System.Windows.Forms.Cursors.IBeam
            Me.TXT_VentaEfectivo.DefaultText = "0.00"
            Me.TXT_VentaEfectivo.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
            Me.TXT_VentaEfectivo.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
            Me.TXT_VentaEfectivo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
            Me.TXT_VentaEfectivo.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
            Me.TXT_VentaEfectivo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.TXT_VentaEfectivo.Font = New System.Drawing.Font("Segoe UI", 9.0!)
            Me.TXT_VentaEfectivo.ForeColor = System.Drawing.Color.Black
            Me.TXT_VentaEfectivo.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.TXT_VentaEfectivo.IconRightSize = New System.Drawing.Size(40, 40)
            Me.TXT_VentaEfectivo.Location = New System.Drawing.Point(384, 105)
            Me.TXT_VentaEfectivo.Name = "TXT_VentaEfectivo"
            Me.TXT_VentaEfectivo.PlaceholderText = ""
            Me.TXT_VentaEfectivo.ReadOnly = True
            Me.TXT_VentaEfectivo.SelectedText = ""
            Me.TXT_VentaEfectivo.Size = New System.Drawing.Size(132, 36)
            Me.TXT_VentaEfectivo.TabIndex = 145
            '
            'Guna2HtmlLabel31
            '
            Me.Guna2HtmlLabel31.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.Guna2HtmlLabel31.BackColor = System.Drawing.Color.Transparent
            Me.Guna2HtmlLabel31.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Guna2HtmlLabel31.ForeColor = System.Drawing.SystemColors.Control
            Me.Guna2HtmlLabel31.Location = New System.Drawing.Point(273, 110)
            Me.Guna2HtmlLabel31.Name = "Guna2HtmlLabel31"
            Me.Guna2HtmlLabel31.Size = New System.Drawing.Size(105, 27)
            Me.Guna2HtmlLabel31.TabIndex = 144
            Me.Guna2HtmlLabel31.Text = "En efectivo:"
            Me.Guna2HtmlLabel31.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit
            '
            'TXT_SaldoInicial
            '
            Me.TXT_SaldoInicial.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.TXT_SaldoInicial.BorderRadius = 10
            Me.TXT_SaldoInicial.Cursor = System.Windows.Forms.Cursors.IBeam
            Me.TXT_SaldoInicial.DefaultText = "0.00"
            Me.TXT_SaldoInicial.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
            Me.TXT_SaldoInicial.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
            Me.TXT_SaldoInicial.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
            Me.TXT_SaldoInicial.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
            Me.TXT_SaldoInicial.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.TXT_SaldoInicial.Font = New System.Drawing.Font("Segoe UI", 9.0!)
            Me.TXT_SaldoInicial.ForeColor = System.Drawing.Color.Black
            Me.TXT_SaldoInicial.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.TXT_SaldoInicial.IconRightSize = New System.Drawing.Size(40, 40)
            Me.TXT_SaldoInicial.Location = New System.Drawing.Point(135, 53)
            Me.TXT_SaldoInicial.Name = "TXT_SaldoInicial"
            Me.TXT_SaldoInicial.PlaceholderText = ""
            Me.TXT_SaldoInicial.ReadOnly = True
            Me.TXT_SaldoInicial.SelectedText = ""
            Me.TXT_SaldoInicial.Size = New System.Drawing.Size(381, 36)
            Me.TXT_SaldoInicial.TabIndex = 143
            '
            'Guna2HtmlLabel30
            '
            Me.Guna2HtmlLabel30.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.Guna2HtmlLabel30.BackColor = System.Drawing.Color.Transparent
            Me.Guna2HtmlLabel30.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Guna2HtmlLabel30.ForeColor = System.Drawing.SystemColors.Control
            Me.Guna2HtmlLabel30.Location = New System.Drawing.Point(15, 58)
            Me.Guna2HtmlLabel30.Name = "Guna2HtmlLabel30"
            Me.Guna2HtmlLabel30.Size = New System.Drawing.Size(114, 27)
            Me.Guna2HtmlLabel30.TabIndex = 142
            Me.Guna2HtmlLabel30.Text = "Saldo inicial:"
            Me.Guna2HtmlLabel30.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit
            '
            'BTN_RegresarCierreCaja
            '
            Me.BTN_RegresarCierreCaja.BorderRadius = 10
            Me.BTN_RegresarCierreCaja.DialogResult = System.Windows.Forms.DialogResult.Cancel
            Me.BTN_RegresarCierreCaja.DisabledState.BorderColor = System.Drawing.Color.DarkGray
            Me.BTN_RegresarCierreCaja.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
            Me.BTN_RegresarCierreCaja.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
            Me.BTN_RegresarCierreCaja.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
            Me.BTN_RegresarCierreCaja.Dock = System.Windows.Forms.DockStyle.Fill
            Me.BTN_RegresarCierreCaja.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
            Me.BTN_RegresarCierreCaja.Font = New System.Drawing.Font("Ebrima", 20.25!, System.Drawing.FontStyle.Bold)
            Me.BTN_RegresarCierreCaja.ForeColor = System.Drawing.Color.White
            Me.BTN_RegresarCierreCaja.Image = Global.SistemaFacturaciónCommon.My.Resources.Resources.ICO_Back
            Me.BTN_RegresarCierreCaja.ImageSize = New System.Drawing.Size(40, 40)
            Me.BTN_RegresarCierreCaja.Location = New System.Drawing.Point(509, 554)
            Me.BTN_RegresarCierreCaja.Name = "BTN_RegresarCierreCaja"
            Me.BTN_RegresarCierreCaja.Size = New System.Drawing.Size(563, 49)
            Me.BTN_RegresarCierreCaja.TabIndex = 153
            Me.BTN_RegresarCierreCaja.Text = "Regresar"
            '
            'PAN_EfectivoReal
            '
            Me.PAN_EfectivoReal.Controls.Add(Me.TXT_DineroReal)
            Me.PAN_EfectivoReal.Controls.Add(Me.Guna2HtmlLabel1)
            Me.PAN_EfectivoReal.Dock = System.Windows.Forms.DockStyle.Fill
            Me.PAN_EfectivoReal.Location = New System.Drawing.Point(3, 609)
            Me.PAN_EfectivoReal.Name = "PAN_EfectivoReal"
            Me.PAN_EfectivoReal.Size = New System.Drawing.Size(500, 46)
            Me.PAN_EfectivoReal.TabIndex = 13
            '
            'TXT_DineroReal
            '
            Me.TXT_DineroReal.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.TXT_DineroReal.BorderRadius = 10
            Me.TXT_DineroReal.Cursor = System.Windows.Forms.Cursors.IBeam
            Me.TXT_DineroReal.DefaultText = "0"
            Me.TXT_DineroReal.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
            Me.TXT_DineroReal.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
            Me.TXT_DineroReal.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
            Me.TXT_DineroReal.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
            Me.TXT_DineroReal.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.TXT_DineroReal.Font = New System.Drawing.Font("Segoe UI", 9.0!)
            Me.TXT_DineroReal.ForeColor = System.Drawing.Color.Black
            Me.TXT_DineroReal.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.TXT_DineroReal.IconRightSize = New System.Drawing.Size(40, 40)
            Me.TXT_DineroReal.Location = New System.Drawing.Point(176, 3)
            Me.TXT_DineroReal.Name = "TXT_DineroReal"
            Me.TXT_DineroReal.PlaceholderText = ""
            Me.TXT_DineroReal.ReadOnly = True
            Me.TXT_DineroReal.SelectedText = ""
            Me.TXT_DineroReal.Size = New System.Drawing.Size(302, 39)
            Me.TXT_DineroReal.TabIndex = 159
            '
            'Guna2HtmlLabel1
            '
            Me.Guna2HtmlLabel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.Guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent
            Me.Guna2HtmlLabel1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
            Me.Guna2HtmlLabel1.ForeColor = System.Drawing.SystemColors.Control
            Me.Guna2HtmlLabel1.Location = New System.Drawing.Point(20, 11)
            Me.Guna2HtmlLabel1.Name = "Guna2HtmlLabel1"
            Me.Guna2HtmlLabel1.Size = New System.Drawing.Size(150, 23)
            Me.Guna2HtmlLabel1.TabIndex = 158
            Me.Guna2HtmlLabel1.Text = "Dinero real en caja:"
            Me.Guna2HtmlLabel1.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit
            '
            'PAN_DineroReal
            '
            Me.PAN_DineroReal.Controls.Add(Me.Guna2GroupBox1)
            Me.PAN_DineroReal.Dock = System.Windows.Forms.DockStyle.Fill
            Me.PAN_DineroReal.Location = New System.Drawing.Point(3, 3)
            Me.PAN_DineroReal.Name = "PAN_DineroReal"
            Me.TBL_LayoutGeneral.SetRowSpan(Me.PAN_DineroReal, 2)
            Me.PAN_DineroReal.Size = New System.Drawing.Size(500, 600)
            Me.PAN_DineroReal.TabIndex = 160
            '
            'Guna2GroupBox1
            '
            Me.Guna2GroupBox1.BorderRadius = 20
            Me.Guna2GroupBox1.Controls.Add(Me.TBL_IngresoEfectivoReal)
            Me.Guna2GroupBox1.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.Guna2GroupBox1.FillColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer))
            Me.Guna2GroupBox1.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Guna2GroupBox1.ForeColor = System.Drawing.Color.White
            Me.Guna2GroupBox1.Location = New System.Drawing.Point(9, 6)
            Me.Guna2GroupBox1.Name = "Guna2GroupBox1"
            Me.Guna2GroupBox1.Size = New System.Drawing.Size(479, 579)
            Me.Guna2GroupBox1.TabIndex = 159
            Me.Guna2GroupBox1.Text = "Dinero real en caja"
            Me.Guna2GroupBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
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
            Me.TBL_IngresoEfectivoReal.Location = New System.Drawing.Point(0, 40)
            Me.TBL_IngresoEfectivoReal.Name = "TBL_IngresoEfectivoReal"
            Me.TBL_IngresoEfectivoReal.RowCount = 6
            Me.TBL_IngresoEfectivoReal.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
            Me.TBL_IngresoEfectivoReal.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
            Me.TBL_IngresoEfectivoReal.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
            Me.TBL_IngresoEfectivoReal.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
            Me.TBL_IngresoEfectivoReal.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
            Me.TBL_IngresoEfectivoReal.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
            Me.TBL_IngresoEfectivoReal.Size = New System.Drawing.Size(479, 539)
            Me.TBL_IngresoEfectivoReal.TabIndex = 13
            '
            'PAN_Moneda5
            '
            Me.PAN_Moneda5.Controls.Add(Me.NUD_Moneda5)
            Me.PAN_Moneda5.Controls.Add(Me.Guna2HtmlLabel28)
            Me.PAN_Moneda5.Dock = System.Windows.Forms.DockStyle.Fill
            Me.PAN_Moneda5.Location = New System.Drawing.Point(242, 448)
            Me.PAN_Moneda5.Name = "PAN_Moneda5"
            Me.PAN_Moneda5.Size = New System.Drawing.Size(234, 88)
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
            Me.NUD_Moneda5.Size = New System.Drawing.Size(196, 36)
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
            Me.PAN_Billete1.Location = New System.Drawing.Point(3, 448)
            Me.PAN_Billete1.Name = "PAN_Billete1"
            Me.PAN_Billete1.Size = New System.Drawing.Size(233, 88)
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
            Me.NUD_Billete1.Size = New System.Drawing.Size(195, 36)
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
            Me.PAN_Moneda10.Location = New System.Drawing.Point(242, 359)
            Me.PAN_Moneda10.Name = "PAN_Moneda10"
            Me.PAN_Moneda10.Size = New System.Drawing.Size(234, 83)
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
            Me.NUD_Moneda10.Size = New System.Drawing.Size(196, 36)
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
            Me.PAN_Billete2.Location = New System.Drawing.Point(3, 359)
            Me.PAN_Billete2.Name = "PAN_Billete2"
            Me.PAN_Billete2.Size = New System.Drawing.Size(233, 83)
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
            Me.NUD_Billete2.Size = New System.Drawing.Size(195, 36)
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
            Me.PAN_Moneda25.Location = New System.Drawing.Point(242, 270)
            Me.PAN_Moneda25.Name = "PAN_Moneda25"
            Me.PAN_Moneda25.Size = New System.Drawing.Size(234, 83)
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
            Me.NUD_Moneda25.Size = New System.Drawing.Size(196, 36)
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
            Me.PAN_Billete5.Location = New System.Drawing.Point(3, 270)
            Me.PAN_Billete5.Name = "PAN_Billete5"
            Me.PAN_Billete5.Size = New System.Drawing.Size(233, 83)
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
            Me.NUD_Billete5.Size = New System.Drawing.Size(195, 36)
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
            Me.Guna2Panel6.Location = New System.Drawing.Point(242, 181)
            Me.Guna2Panel6.Name = "Guna2Panel6"
            Me.Guna2Panel6.Size = New System.Drawing.Size(234, 83)
            Me.Guna2Panel6.TabIndex = 5
            '
            'PAN_Moneda50
            '
            Me.PAN_Moneda50.Controls.Add(Me.NUD_Moneda50)
            Me.PAN_Moneda50.Controls.Add(Me.Guna2HtmlLabel25)
            Me.PAN_Moneda50.Dock = System.Windows.Forms.DockStyle.Fill
            Me.PAN_Moneda50.Location = New System.Drawing.Point(0, 0)
            Me.PAN_Moneda50.Name = "PAN_Moneda50"
            Me.PAN_Moneda50.Size = New System.Drawing.Size(234, 83)
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
            Me.NUD_Moneda50.Size = New System.Drawing.Size(196, 36)
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
            Me.PAN_Billete10.Location = New System.Drawing.Point(3, 181)
            Me.PAN_Billete10.Name = "PAN_Billete10"
            Me.PAN_Billete10.Size = New System.Drawing.Size(233, 83)
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
            Me.NUD_Billete10.Size = New System.Drawing.Size(195, 36)
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
            Me.PAN_Moneda100.Location = New System.Drawing.Point(242, 92)
            Me.PAN_Moneda100.Name = "PAN_Moneda100"
            Me.PAN_Moneda100.Size = New System.Drawing.Size(234, 83)
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
            Me.NUD_Moneda100.Size = New System.Drawing.Size(196, 36)
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
            Me.PAN_Billete20.Location = New System.Drawing.Point(3, 92)
            Me.PAN_Billete20.Name = "PAN_Billete20"
            Me.PAN_Billete20.Size = New System.Drawing.Size(233, 83)
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
            Me.NUD_Billete20.Size = New System.Drawing.Size(195, 36)
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
            Me.PAN_Moneda500.Location = New System.Drawing.Point(242, 3)
            Me.PAN_Moneda500.Name = "PAN_Moneda500"
            Me.PAN_Moneda500.Size = New System.Drawing.Size(234, 83)
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
            Me.NUD_Moneda500.Size = New System.Drawing.Size(196, 36)
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
            Me.PAN_Billete50.Size = New System.Drawing.Size(233, 83)
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
            Me.NUD_Billete50.Size = New System.Drawing.Size(195, 36)
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
            'P_GenerarCierreCaja
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer))
            Me.ClientSize = New System.Drawing.Size(1075, 692)
            Me.Controls.Add(Me.TBL_LayoutGeneral)
            Me.Controls.Add(Me.Guna2HtmlLabel16)
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.KeyPreview = True
            Me.Name = "P_GenerarCierreCaja"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "Registrar cierre de caja"
            Me.TBL_LayoutGeneral.ResumeLayout(False)
            Me.PAN_DatosCierre.ResumeLayout(False)
            Me.Guna2GroupBox5.ResumeLayout(False)
            Me.TableLayoutPanel3.ResumeLayout(False)
            Me.Guna2Panel3.ResumeLayout(False)
            Me.Guna2Panel3.PerformLayout()
            Me.Guna2Panel4.ResumeLayout(False)
            Me.Guna2Panel4.PerformLayout()
            Me.TableLayoutPanel4.ResumeLayout(False)
            Me.Guna2GroupBox4.ResumeLayout(False)
            Me.Guna2GroupBox4.PerformLayout()
            Me.PAN_EfectivoReal.ResumeLayout(False)
            Me.PAN_EfectivoReal.PerformLayout()
            Me.PAN_DineroReal.ResumeLayout(False)
            Me.Guna2GroupBox1.ResumeLayout(False)
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
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents Guna2HtmlLabel16 As Guna.UI2.WinForms.Guna2HtmlLabel
        Friend WithEvents TBL_LayoutGeneral As TableLayoutPanel
        Friend WithEvents PAN_EfectivoReal As Guna.UI2.WinForms.Guna2Panel
        Friend WithEvents TXT_DineroReal As Guna.UI2.WinForms.Guna2TextBox
        Friend WithEvents Guna2HtmlLabel1 As Guna.UI2.WinForms.Guna2HtmlLabel
        Friend WithEvents BTN_RegresarCierreCaja As Guna.UI2.WinForms.Guna2Button
        Friend WithEvents BTN_CerrarSesionCaja As Guna.UI2.WinForms.Guna2Button
        Friend WithEvents PAN_DatosCierre As Guna.UI2.WinForms.Guna2Panel
        Friend WithEvents Guna2GroupBox4 As Guna.UI2.WinForms.Guna2GroupBox
        Friend WithEvents TXT_VentaTarjeta As Guna.UI2.WinForms.Guna2TextBox
        Friend WithEvents Guna2HtmlLabel32 As Guna.UI2.WinForms.Guna2HtmlLabel
        Friend WithEvents TXT_VentaEfectivo As Guna.UI2.WinForms.Guna2TextBox
        Friend WithEvents Guna2HtmlLabel31 As Guna.UI2.WinForms.Guna2HtmlLabel
        Friend WithEvents TXT_SaldoInicial As Guna.UI2.WinForms.Guna2TextBox
        Friend WithEvents Guna2HtmlLabel30 As Guna.UI2.WinForms.Guna2HtmlLabel
        Friend WithEvents TableLayoutPanel4 As TableLayoutPanel
        Friend WithEvents Guna2HtmlLabel39 As Guna.UI2.WinForms.Guna2HtmlLabel
        Friend WithEvents Guna2HtmlLabel33 As Guna.UI2.WinForms.Guna2HtmlLabel
        Friend WithEvents TXT_EntradasRegistradas As Guna.UI2.WinForms.Guna2TextBox
        Friend WithEvents TXT_SalidasRegistradas As Guna.UI2.WinForms.Guna2TextBox
        Friend WithEvents Guna2HtmlLabel2 As Guna.UI2.WinForms.Guna2HtmlLabel
        Friend WithEvents TXT_SaldoEsperado As Guna.UI2.WinForms.Guna2TextBox
        Friend WithEvents Guna2GroupBox5 As Guna.UI2.WinForms.Guna2GroupBox
        Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
        Friend WithEvents Guna2Panel3 As Guna.UI2.WinForms.Guna2Panel
        Friend WithEvents TXT_DiferenciaAbsoluta As Guna.UI2.WinForms.Guna2TextBox
        Friend WithEvents Guna2HtmlLabel35 As Guna.UI2.WinForms.Guna2HtmlLabel
        Friend WithEvents Guna2Panel4 As Guna.UI2.WinForms.Guna2Panel
        Friend WithEvents TXT_DiferenciaPorcentual As Guna.UI2.WinForms.Guna2TextBox
        Friend WithEvents Guna2HtmlLabel38 As Guna.UI2.WinForms.Guna2HtmlLabel
        Friend WithEvents Guna2GroupBox1 As Guna.UI2.WinForms.Guna2GroupBox
        Friend WithEvents PAN_DineroReal As Guna.UI2.WinForms.Guna2Panel
        Friend WithEvents TBL_IngresoEfectivoReal As TableLayoutPanel
        Friend WithEvents PAN_Moneda5 As Guna.UI2.WinForms.Guna2Panel
        Friend WithEvents NUD_Moneda5 As Guna.UI2.WinForms.Guna2NumericUpDown
        Friend WithEvents Guna2HtmlLabel28 As Guna.UI2.WinForms.Guna2HtmlLabel
        Friend WithEvents PAN_Billete1 As Guna.UI2.WinForms.Guna2Panel
        Friend WithEvents NUD_Billete1 As Guna.UI2.WinForms.Guna2NumericUpDown
        Friend WithEvents Guna2HtmlLabel22 As Guna.UI2.WinForms.Guna2HtmlLabel
        Friend WithEvents PAN_Moneda10 As Guna.UI2.WinForms.Guna2Panel
        Friend WithEvents NUD_Moneda10 As Guna.UI2.WinForms.Guna2NumericUpDown
        Friend WithEvents Guna2HtmlLabel27 As Guna.UI2.WinForms.Guna2HtmlLabel
        Friend WithEvents PAN_Billete2 As Guna.UI2.WinForms.Guna2Panel
        Friend WithEvents NUD_Billete2 As Guna.UI2.WinForms.Guna2NumericUpDown
        Friend WithEvents Guna2HtmlLabel21 As Guna.UI2.WinForms.Guna2HtmlLabel
        Friend WithEvents PAN_Moneda25 As Guna.UI2.WinForms.Guna2Panel
        Friend WithEvents NUD_Moneda25 As Guna.UI2.WinForms.Guna2NumericUpDown
        Friend WithEvents Guna2HtmlLabel26 As Guna.UI2.WinForms.Guna2HtmlLabel
        Friend WithEvents PAN_Billete5 As Guna.UI2.WinForms.Guna2Panel
        Friend WithEvents NUD_Billete5 As Guna.UI2.WinForms.Guna2NumericUpDown
        Friend WithEvents Guna2HtmlLabel20 As Guna.UI2.WinForms.Guna2HtmlLabel
        Friend WithEvents Guna2Panel6 As Guna.UI2.WinForms.Guna2Panel
        Friend WithEvents PAN_Moneda50 As Guna.UI2.WinForms.Guna2Panel
        Friend WithEvents NUD_Moneda50 As Guna.UI2.WinForms.Guna2NumericUpDown
        Friend WithEvents Guna2HtmlLabel25 As Guna.UI2.WinForms.Guna2HtmlLabel
        Friend WithEvents PAN_Billete10 As Guna.UI2.WinForms.Guna2Panel
        Friend WithEvents NUD_Billete10 As Guna.UI2.WinForms.Guna2NumericUpDown
        Friend WithEvents Guna2HtmlLabel19 As Guna.UI2.WinForms.Guna2HtmlLabel
        Friend WithEvents PAN_Moneda100 As Guna.UI2.WinForms.Guna2Panel
        Friend WithEvents NUD_Moneda100 As Guna.UI2.WinForms.Guna2NumericUpDown
        Friend WithEvents Guna2HtmlLabel24 As Guna.UI2.WinForms.Guna2HtmlLabel
        Friend WithEvents PAN_Billete20 As Guna.UI2.WinForms.Guna2Panel
        Friend WithEvents NUD_Billete20 As Guna.UI2.WinForms.Guna2NumericUpDown
        Friend WithEvents Guna2HtmlLabel18 As Guna.UI2.WinForms.Guna2HtmlLabel
        Friend WithEvents PAN_Moneda500 As Guna.UI2.WinForms.Guna2Panel
        Friend WithEvents NUD_Moneda500 As Guna.UI2.WinForms.Guna2NumericUpDown
        Friend WithEvents Guna2HtmlLabel23 As Guna.UI2.WinForms.Guna2HtmlLabel
        Friend WithEvents PAN_Billete50 As Guna.UI2.WinForms.Guna2Panel
        Friend WithEvents NUD_Billete50 As Guna.UI2.WinForms.Guna2NumericUpDown
        Friend WithEvents Guna2HtmlLabel17 As Guna.UI2.WinForms.Guna2HtmlLabel
        Friend WithEvents BTN_LimpiarCierre As Guna.UI2.WinForms.Guna2Button
    End Class
End Namespace
