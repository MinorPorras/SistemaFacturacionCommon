Namespace SistemaFacturacion.Forms.CuentasXCobrar

    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Class P_CuentasCobrar
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(P_CuentasCobrar))
            Me.pan_CuentasCobrar = New Guna.UI2.WinForms.Guna2Panel()
            Me.Label1 = New System.Windows.Forms.Label()
            Me.FlowLayout1 = New Syncfusion.Windows.Forms.Tools.FlowLayout(Me.components)
            Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
            Me.BTN_Regresar = New Guna.UI2.WinForms.Guna2Button()
            Me.Guna2HtmlLabel8 = New Guna.UI2.WinForms.Guna2HtmlLabel()
            Me.CBX_EstadoCuenta = New Guna.UI2.WinForms.Guna2ComboBox()
            Me.Guna2Shapes1 = New Guna.UI2.WinForms.Guna2Shapes()
            Me.Guna2Shapes2 = New Guna.UI2.WinForms.Guna2Shapes()
            Me.Guna2Shapes3 = New Guna.UI2.WinForms.Guna2Shapes()
            Me.Guna2HtmlLabel1 = New Guna.UI2.WinForms.Guna2HtmlLabel()
            Me.Guna2HtmlLabel2 = New Guna.UI2.WinForms.Guna2HtmlLabel()
            Me.Guna2HtmlLabel3 = New Guna.UI2.WinForms.Guna2HtmlLabel()
            CType(Me.FlowLayout1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.TableLayoutPanel1.SuspendLayout()
            Me.SuspendLayout()
            '
            'pan_CuentasCobrar
            '
            Me.pan_CuentasCobrar.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.pan_CuentasCobrar.AutoScroll = True
            Me.pan_CuentasCobrar.Location = New System.Drawing.Point(1, 119)
            Me.pan_CuentasCobrar.Name = "pan_CuentasCobrar"
            Me.pan_CuentasCobrar.Size = New System.Drawing.Size(936, 364)
            Me.pan_CuentasCobrar.TabIndex = 0
            '
            'Label1
            '
            Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
            Me.Label1.Font = New System.Drawing.Font("Britannic Bold", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label1.ForeColor = System.Drawing.Color.White
            Me.Label1.Location = New System.Drawing.Point(0, 0)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(939, 41)
            Me.Label1.TabIndex = 73
            Me.Label1.Text = "Cuentas por cobrar"
            Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            '
            'FlowLayout1
            '
            Me.FlowLayout1.ContainerControl = Me.pan_CuentasCobrar
            '
            'TableLayoutPanel1
            '
            Me.TableLayoutPanel1.ColumnCount = 1
            Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
            Me.TableLayoutPanel1.Controls.Add(Me.BTN_Regresar, 0, 0)
            Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 527)
            Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
            Me.TableLayoutPanel1.RowCount = 1
            Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
            Me.TableLayoutPanel1.Size = New System.Drawing.Size(939, 56)
            Me.TableLayoutPanel1.TabIndex = 130
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
            Me.BTN_Regresar.Size = New System.Drawing.Size(933, 50)
            Me.BTN_Regresar.TabIndex = 130
            Me.BTN_Regresar.Text = "Regresar"
            '
            'Guna2HtmlLabel8
            '
            Me.Guna2HtmlLabel8.BackColor = System.Drawing.Color.Transparent
            Me.Guna2HtmlLabel8.Font = New System.Drawing.Font("Segoe UI Black", 15.75!, System.Drawing.FontStyle.Bold)
            Me.Guna2HtmlLabel8.ForeColor = System.Drawing.SystemColors.Control
            Me.Guna2HtmlLabel8.Location = New System.Drawing.Point(12, 63)
            Me.Guna2HtmlLabel8.Name = "Guna2HtmlLabel8"
            Me.Guna2HtmlLabel8.Size = New System.Drawing.Size(209, 32)
            Me.Guna2HtmlLabel8.TabIndex = 131
            Me.Guna2HtmlLabel8.Text = "Estado de la cuenta:"
            Me.Guna2HtmlLabel8.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit
            '
            'CBX_EstadoCuenta
            '
            Me.CBX_EstadoCuenta.BackColor = System.Drawing.Color.Transparent
            Me.CBX_EstadoCuenta.BorderRadius = 10
            Me.CBX_EstadoCuenta.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
            Me.CBX_EstadoCuenta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.CBX_EstadoCuenta.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.CBX_EstadoCuenta.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.CBX_EstadoCuenta.Font = New System.Drawing.Font("Segoe UI", 10.0!)
            Me.CBX_EstadoCuenta.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
            Me.CBX_EstadoCuenta.ItemHeight = 30
            Me.CBX_EstadoCuenta.Items.AddRange(New Object() {"Inactivas", "Activas", "Cobradas", "Todas"})
            Me.CBX_EstadoCuenta.Location = New System.Drawing.Point(227, 63)
            Me.CBX_EstadoCuenta.Name = "CBX_EstadoCuenta"
            Me.CBX_EstadoCuenta.Size = New System.Drawing.Size(215, 36)
            Me.CBX_EstadoCuenta.StartIndex = 1
            Me.CBX_EstadoCuenta.TabIndex = 132
            '
            'Guna2Shapes1
            '
            Me.Guna2Shapes1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Me.Guna2Shapes1.BorderColor = System.Drawing.Color.MediumSeaGreen
            Me.Guna2Shapes1.FillColor = System.Drawing.Color.MediumSeaGreen
            Me.Guna2Shapes1.Location = New System.Drawing.Point(7, 503)
            Me.Guna2Shapes1.Name = "Guna2Shapes1"
            Me.Guna2Shapes1.PolygonSkip = 1
            Me.Guna2Shapes1.Rotate = 0!
            Me.Guna2Shapes1.Shape = Guna.UI2.WinForms.Enums.ShapeType.Ellipse
            Me.Guna2Shapes1.Size = New System.Drawing.Size(20, 20)
            Me.Guna2Shapes1.TabIndex = 133
            Me.Guna2Shapes1.Text = "Guna2Shapes1"
            Me.Guna2Shapes1.Zoom = 80
            '
            'Guna2Shapes2
            '
            Me.Guna2Shapes2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Me.Guna2Shapes2.BorderColor = System.Drawing.Color.IndianRed
            Me.Guna2Shapes2.FillColor = System.Drawing.Color.IndianRed
            Me.Guna2Shapes2.Location = New System.Drawing.Point(112, 503)
            Me.Guna2Shapes2.Name = "Guna2Shapes2"
            Me.Guna2Shapes2.PolygonSkip = 1
            Me.Guna2Shapes2.Rotate = 0!
            Me.Guna2Shapes2.Shape = Guna.UI2.WinForms.Enums.ShapeType.Ellipse
            Me.Guna2Shapes2.Size = New System.Drawing.Size(20, 20)
            Me.Guna2Shapes2.TabIndex = 134
            Me.Guna2Shapes2.Text = "Guna2Shapes2"
            Me.Guna2Shapes2.Zoom = 80
            '
            'Guna2Shapes3
            '
            Me.Guna2Shapes3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Me.Guna2Shapes3.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.Guna2Shapes3.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.Guna2Shapes3.Location = New System.Drawing.Point(228, 503)
            Me.Guna2Shapes3.Name = "Guna2Shapes3"
            Me.Guna2Shapes3.PolygonSkip = 1
            Me.Guna2Shapes3.Rotate = 0!
            Me.Guna2Shapes3.Shape = Guna.UI2.WinForms.Enums.ShapeType.Ellipse
            Me.Guna2Shapes3.Size = New System.Drawing.Size(20, 20)
            Me.Guna2Shapes3.TabIndex = 135
            Me.Guna2Shapes3.Text = "Guna2Shapes3"
            Me.Guna2Shapes3.Zoom = 80
            '
            'Guna2HtmlLabel1
            '
            Me.Guna2HtmlLabel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Me.Guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent
            Me.Guna2HtmlLabel1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Guna2HtmlLabel1.ForeColor = System.Drawing.SystemColors.Control
            Me.Guna2HtmlLabel1.Location = New System.Drawing.Point(33, 500)
            Me.Guna2HtmlLabel1.Name = "Guna2HtmlLabel1"
            Me.Guna2HtmlLabel1.Size = New System.Drawing.Size(51, 23)
            Me.Guna2HtmlLabel1.TabIndex = 136
            Me.Guna2HtmlLabel1.Text = "Activa"
            Me.Guna2HtmlLabel1.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit
            '
            'Guna2HtmlLabel2
            '
            Me.Guna2HtmlLabel2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Me.Guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent
            Me.Guna2HtmlLabel2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Guna2HtmlLabel2.ForeColor = System.Drawing.SystemColors.Control
            Me.Guna2HtmlLabel2.Location = New System.Drawing.Point(138, 501)
            Me.Guna2HtmlLabel2.Name = "Guna2HtmlLabel2"
            Me.Guna2HtmlLabel2.Size = New System.Drawing.Size(64, 23)
            Me.Guna2HtmlLabel2.TabIndex = 137
            Me.Guna2HtmlLabel2.Text = "Inactiva"
            Me.Guna2HtmlLabel2.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit
            '
            'Guna2HtmlLabel3
            '
            Me.Guna2HtmlLabel3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Me.Guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent
            Me.Guna2HtmlLabel3.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Guna2HtmlLabel3.ForeColor = System.Drawing.SystemColors.Control
            Me.Guna2HtmlLabel3.Location = New System.Drawing.Point(254, 501)
            Me.Guna2HtmlLabel3.Name = "Guna2HtmlLabel3"
            Me.Guna2HtmlLabel3.Size = New System.Drawing.Size(67, 23)
            Me.Guna2HtmlLabel3.TabIndex = 138
            Me.Guna2HtmlLabel3.Text = "Cobrada"
            Me.Guna2HtmlLabel3.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit
            '
            'P_CuentasCobrar
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer))
            Me.ClientSize = New System.Drawing.Size(939, 583)
            Me.Controls.Add(Me.Guna2HtmlLabel3)
            Me.Controls.Add(Me.Guna2HtmlLabel2)
            Me.Controls.Add(Me.Guna2HtmlLabel1)
            Me.Controls.Add(Me.Guna2Shapes3)
            Me.Controls.Add(Me.Guna2Shapes2)
            Me.Controls.Add(Me.Guna2Shapes1)
            Me.Controls.Add(Me.CBX_EstadoCuenta)
            Me.Controls.Add(Me.Guna2HtmlLabel8)
            Me.Controls.Add(Me.TableLayoutPanel1)
            Me.Controls.Add(Me.Label1)
            Me.Controls.Add(Me.pan_CuentasCobrar)
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.Name = "P_CuentasCobrar"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "P_CuentasCobrar"
            Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
            CType(Me.FlowLayout1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.TableLayoutPanel1.ResumeLayout(False)
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
        Friend WithEvents pan_CuentasCobrar As Guna.UI2.WinForms.Guna2Panel
        Friend WithEvents Label1 As Label
        Friend WithEvents FlowLayout1 As Syncfusion.Windows.Forms.Tools.FlowLayout
        Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
        Friend WithEvents BTN_Regresar As Guna.UI2.WinForms.Guna2Button
        Friend WithEvents Guna2HtmlLabel8 As Guna.UI2.WinForms.Guna2HtmlLabel
        Friend WithEvents CBX_EstadoCuenta As Guna.UI2.WinForms.Guna2ComboBox
        Friend WithEvents Guna2Shapes1 As Guna.UI2.WinForms.Guna2Shapes
        Friend WithEvents Guna2Shapes2 As Guna.UI2.WinForms.Guna2Shapes
        Friend WithEvents Guna2Shapes3 As Guna.UI2.WinForms.Guna2Shapes
        Friend WithEvents Guna2HtmlLabel1 As Guna.UI2.WinForms.Guna2HtmlLabel
        Friend WithEvents Guna2HtmlLabel2 As Guna.UI2.WinForms.Guna2HtmlLabel
        Friend WithEvents Guna2HtmlLabel3 As Guna.UI2.WinForms.Guna2HtmlLabel
    End Class

End Namespace