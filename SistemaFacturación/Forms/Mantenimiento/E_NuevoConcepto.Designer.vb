Namespace SistemaFacturacion.Forms.Mantenimiento
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Class E_NuevoConcepto
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(E_NuevoConcepto))
        Me.Guna2BorderlessForm1 = New Guna.UI2.WinForms.Guna2BorderlessForm(Me.components)
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TXT_Concepto = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.CBX_tipoConcepto = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.BTN_NConcepto = New Guna.UI2.WinForms.Guna2Button()
        Me.BTN_Regresar = New Guna.UI2.WinForms.Guna2Button()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Guna2BorderlessForm1
        '
        Me.Guna2BorderlessForm1.BorderRadius = 30
        Me.Guna2BorderlessForm1.ContainerControl = Me
        Me.Guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6R
        Me.Guna2BorderlessForm1.TransparentWhileDrag = True
        '
        'Label3
        '
        Me.Label3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Britannic Bold", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(23, 19)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(499, 41)
        Me.Label3.TabIndex = 135
        Me.Label3.Text = "Tipos de movimientos de caja"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Britannic Bold", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(64, 94)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(101, 23)
        Me.Label1.TabIndex = 137
        Me.Label1.Text = "Concepto:"
        '
        'TXT_Concepto
        '
        Me.TXT_Concepto.AutoRoundedCorners = True
        Me.TXT_Concepto.BorderRadius = 17
        Me.TXT_Concepto.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TXT_Concepto.DefaultText = ""
        Me.TXT_Concepto.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TXT_Concepto.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TXT_Concepto.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXT_Concepto.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXT_Concepto.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXT_Concepto.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.TXT_Concepto.ForeColor = System.Drawing.Color.Black
        Me.TXT_Concepto.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXT_Concepto.Location = New System.Drawing.Point(181, 88)
        Me.TXT_Concepto.Name = "TXT_Concepto"
        Me.TXT_Concepto.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TXT_Concepto.PlaceholderText = ""
        Me.TXT_Concepto.SelectedText = ""
        Me.TXT_Concepto.Size = New System.Drawing.Size(276, 37)
        Me.TXT_Concepto.TabIndex = 136
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Britannic Bold", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(25, 175)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(150, 23)
        Me.Label4.TabIndex = 139
        Me.Label4.Text = "Tipo de cuenta:"
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
        Me.CBX_tipoConcepto.Location = New System.Drawing.Point(181, 168)
        Me.CBX_tipoConcepto.Name = "CBX_tipoConcepto"
        Me.CBX_tipoConcepto.Size = New System.Drawing.Size(276, 36)
        Me.CBX_tipoConcepto.TabIndex = 138
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.BTN_NConcepto, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.BTN_Regresar, 0, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 242)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(547, 57)
        Me.TableLayoutPanel1.TabIndex = 141
        '
        'BTN_NConcepto
        '
        Me.BTN_NConcepto.BorderColor = System.Drawing.Color.Red
        Me.BTN_NConcepto.BorderRadius = 10
        Me.BTN_NConcepto.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.BTN_NConcepto.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BTN_NConcepto.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BTN_NConcepto.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BTN_NConcepto.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BTN_NConcepto.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BTN_NConcepto.FillColor = System.Drawing.Color.MediumSeaGreen
        Me.BTN_NConcepto.Font = New System.Drawing.Font("Ebrima", 20.25!, System.Drawing.FontStyle.Bold)
        Me.BTN_NConcepto.ForeColor = System.Drawing.Color.White
        Me.BTN_NConcepto.Image = Global.SistemaFacturaciónCommon.My.Resources.Resources.ICO_Check
        Me.BTN_NConcepto.ImageSize = New System.Drawing.Size(50, 50)
        Me.BTN_NConcepto.Location = New System.Drawing.Point(276, 3)
        Me.BTN_NConcepto.Name = "BTN_NConcepto"
        Me.BTN_NConcepto.Size = New System.Drawing.Size(268, 51)
        Me.BTN_NConcepto.TabIndex = 131
        Me.BTN_NConcepto.Text = "Guardar"
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
        Me.BTN_Regresar.Location = New System.Drawing.Point(3, 3)
        Me.BTN_Regresar.Name = "BTN_Regresar"
        Me.BTN_Regresar.Size = New System.Drawing.Size(267, 51)
        Me.BTN_Regresar.TabIndex = 130
        Me.BTN_Regresar.Text = "Regresar"
        '
        'E_NuevoConcepto
        '
        Me.AcceptButton = Me.BTN_NConcepto
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.CancelButton = Me.BTN_Regresar
        Me.ClientSize = New System.Drawing.Size(547, 299)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.CBX_tipoConcepto)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TXT_Concepto)
        Me.Controls.Add(Me.Label3)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Name = "E_NuevoConcepto"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "E_NuevoConcepto"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Guna2BorderlessForm1 As Guna.UI2.WinForms.Guna2BorderlessForm
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TXT_Concepto As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents CBX_tipoConcepto As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents BTN_Regresar As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BTN_NConcepto As Guna.UI2.WinForms.Guna2Button
End Class

End Namespace