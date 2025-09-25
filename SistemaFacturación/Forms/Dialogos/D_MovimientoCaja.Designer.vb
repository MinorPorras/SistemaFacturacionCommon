Namespace SistemaFacturacion.Forms.Dialogos
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Class D_MovimientoCaja
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(D_MovimientoCaja))
        Me.Guna2BorderlessForm1 = New Guna.UI2.WinForms.Guna2BorderlessForm(Me.components)
        Me.LBL_tituloMovimiento = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.BTN_Regresar = New Guna.UI2.WinForms.Guna2Button()
        Me.BTN_ConfirmGuardarMov = New Guna.UI2.WinForms.Guna2Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.NUD_Monto = New Guna.UI2.WinForms.Guna2NumericUpDown()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CBX_tipoConcepto = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.TXT_Referencia = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.NUD_Monto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Guna2BorderlessForm1
        '
        Me.Guna2BorderlessForm1.BorderRadius = 25
        Me.Guna2BorderlessForm1.ContainerControl = Me
        Me.Guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6R
        Me.Guna2BorderlessForm1.TransparentWhileDrag = True
        '
        'LBL_tituloMovimiento
        '
        Me.LBL_tituloMovimiento.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LBL_tituloMovimiento.BackColor = System.Drawing.Color.Transparent
        Me.LBL_tituloMovimiento.Font = New System.Drawing.Font("Segoe UI Black", 15.75!, System.Drawing.FontStyle.Bold)
        Me.LBL_tituloMovimiento.ForeColor = System.Drawing.SystemColors.Control
        Me.LBL_tituloMovimiento.Location = New System.Drawing.Point(136, 12)
        Me.LBL_tituloMovimiento.Name = "LBL_tituloMovimiento"
        Me.LBL_tituloMovimiento.Size = New System.Drawing.Size(203, 32)
        Me.LBL_tituloMovimiento.TabIndex = 112
        Me.LBL_tituloMovimiento.Text = "Entrada de efectivo"
        Me.LBL_tituloMovimiento.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit
        '
        'BTN_Regresar
        '
        Me.BTN_Regresar.BorderColor = System.Drawing.Color.Red
        Me.BTN_Regresar.BorderRadius = 10
        Me.BTN_Regresar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.BTN_Regresar.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BTN_Regresar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BTN_Regresar.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BTN_Regresar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BTN_Regresar.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BTN_Regresar.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BTN_Regresar.Font = New System.Drawing.Font("Ebrima", 20.25!, System.Drawing.FontStyle.Bold)
        Me.BTN_Regresar.ForeColor = System.Drawing.Color.White
        Me.BTN_Regresar.Image = Global.SistemaFacturaciónCommon.My.Resources.Resources.ICO_Back
        Me.BTN_Regresar.ImageSize = New System.Drawing.Size(40, 40)
        Me.BTN_Regresar.Location = New System.Drawing.Point(3, 3)
        Me.BTN_Regresar.Name = "BTN_Regresar"
        Me.BTN_Regresar.Size = New System.Drawing.Size(231, 57)
        Me.BTN_Regresar.TabIndex = 114
        Me.BTN_Regresar.Text = "Regresar"
        '
        'BTN_ConfirmGuardarMov
        '
        Me.BTN_ConfirmGuardarMov.BorderColor = System.Drawing.Color.Red
        Me.BTN_ConfirmGuardarMov.BorderRadius = 10
        Me.BTN_ConfirmGuardarMov.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.BTN_ConfirmGuardarMov.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BTN_ConfirmGuardarMov.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BTN_ConfirmGuardarMov.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BTN_ConfirmGuardarMov.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BTN_ConfirmGuardarMov.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BTN_ConfirmGuardarMov.FillColor = System.Drawing.Color.MediumSeaGreen
        Me.BTN_ConfirmGuardarMov.Font = New System.Drawing.Font("Ebrima", 20.25!, System.Drawing.FontStyle.Bold)
        Me.BTN_ConfirmGuardarMov.ForeColor = System.Drawing.Color.White
        Me.BTN_ConfirmGuardarMov.Image = Global.SistemaFacturaciónCommon.My.Resources.Resources.ICO_Mas
        Me.BTN_ConfirmGuardarMov.ImageSize = New System.Drawing.Size(40, 40)
        Me.BTN_ConfirmGuardarMov.Location = New System.Drawing.Point(240, 3)
        Me.BTN_ConfirmGuardarMov.Name = "BTN_ConfirmGuardarMov"
        Me.BTN_ConfirmGuardarMov.Size = New System.Drawing.Size(231, 57)
        Me.BTN_ConfirmGuardarMov.TabIndex = 113
        Me.BTN_ConfirmGuardarMov.Text = "Guardar"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Britannic Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(64, 145)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(66, 21)
        Me.Label2.TabIndex = 115
        Me.Label2.Text = "Monto:"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.BTN_Regresar, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.BTN_ConfirmGuardarMov, 1, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 269)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(474, 63)
        Me.TableLayoutPanel1.TabIndex = 117
        '
        'NUD_Monto
        '
        Me.NUD_Monto.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.NUD_Monto.AutoRoundedCorners = True
        Me.NUD_Monto.BackColor = System.Drawing.Color.Transparent
        Me.NUD_Monto.BorderRadius = 17
        Me.NUD_Monto.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.NUD_Monto.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.NUD_Monto.Location = New System.Drawing.Point(136, 138)
        Me.NUD_Monto.Maximum = New Decimal(New Integer() {1000000, 0, 0, 0})
        Me.NUD_Monto.Name = "NUD_Monto"
        Me.NUD_Monto.Size = New System.Drawing.Size(293, 36)
        Me.NUD_Monto.TabIndex = 152
        Me.NUD_Monto.UpDownButtonFillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Britannic Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(39, 77)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(91, 21)
        Me.Label1.TabIndex = 153
        Me.Label1.Text = "Concepto:"
        '
        'CBX_tipoConcepto
        '
        Me.CBX_tipoConcepto.AutoRoundedCorners = True
        Me.CBX_tipoConcepto.BackColor = System.Drawing.Color.Transparent
        Me.CBX_tipoConcepto.BorderRadius = 17
        Me.CBX_tipoConcepto.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.CBX_tipoConcepto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBX_tipoConcepto.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CBX_tipoConcepto.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CBX_tipoConcepto.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.CBX_tipoConcepto.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.CBX_tipoConcepto.ItemHeight = 30
        Me.CBX_tipoConcepto.Items.AddRange(New Object() {"Entrada", "Salida"})
        Me.CBX_tipoConcepto.Location = New System.Drawing.Point(136, 70)
        Me.CBX_tipoConcepto.Name = "CBX_tipoConcepto"
        Me.CBX_tipoConcepto.Size = New System.Drawing.Size(293, 36)
        Me.CBX_tipoConcepto.TabIndex = 154
        '
        'TXT_Referencia
        '
        Me.TXT_Referencia.AutoRoundedCorners = True
        Me.TXT_Referencia.BorderRadius = 17
        Me.TXT_Referencia.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TXT_Referencia.DefaultText = ""
        Me.TXT_Referencia.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TXT_Referencia.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TXT_Referencia.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXT_Referencia.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXT_Referencia.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXT_Referencia.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.TXT_Referencia.ForeColor = System.Drawing.Color.Black
        Me.TXT_Referencia.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXT_Referencia.Location = New System.Drawing.Point(136, 208)
        Me.TXT_Referencia.Name = "TXT_Referencia"
        Me.TXT_Referencia.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TXT_Referencia.PlaceholderText = "# de factura o identificador"
        Me.TXT_Referencia.SelectedText = ""
        Me.TXT_Referencia.Size = New System.Drawing.Size(293, 37)
        Me.TXT_Referencia.TabIndex = 155
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Britannic Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(27, 217)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(103, 21)
        Me.Label3.TabIndex = 156
        Me.Label3.Text = "Referencia:"
        '
        'D_MovimientoCaja
        '
        Me.AcceptButton = Me.BTN_ConfirmGuardarMov
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.CancelButton = Me.BTN_Regresar
        Me.ClientSize = New System.Drawing.Size(474, 332)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TXT_Referencia)
        Me.Controls.Add(Me.CBX_tipoConcepto)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.NUD_Monto)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.LBL_tituloMovimiento)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Name = "D_MovimientoCaja"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Movimientos de caja"
        Me.TableLayoutPanel1.ResumeLayout(False)
        CType(Me.NUD_Monto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Guna2BorderlessForm1 As Guna.UI2.WinForms.Guna2BorderlessForm
    Friend WithEvents LBL_tituloMovimiento As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents BTN_Regresar As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BTN_ConfirmGuardarMov As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Label2 As Label
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents NUD_Monto As Guna.UI2.WinForms.Guna2NumericUpDown
    Friend WithEvents Label1 As Label
    Friend WithEvents CBX_tipoConcepto As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents TXT_Referencia As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label3 As Label
End Class
End Namespace