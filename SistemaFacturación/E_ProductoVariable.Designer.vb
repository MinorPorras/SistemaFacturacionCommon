<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class E_ProductoVariable
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(E_ProductoVariable))
        Me.Guna2BorderlessForm1 = New Guna.UI2.WinForms.Guna2BorderlessForm(Me.components)
        Me.Guna2HtmlLabel4 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.LBL_Producto = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.LBL_Cod = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel2 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.TXT_PrecioVenta = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2HtmlLabel1 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.BTN_RegresarPrd = New Guna.UI2.WinForms.Guna2Button()
        Me.BTN_SelectProd = New Guna.UI2.WinForms.Guna2Button()
        Me.LBL_ID = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
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
        'Guna2HtmlLabel4
        '
        Me.Guna2HtmlLabel4.BackColor = System.Drawing.SystemColors.Control
        Me.Guna2HtmlLabel4.Font = New System.Drawing.Font("Segoe UI Black", 15.75!, System.Drawing.FontStyle.Bold)
        Me.Guna2HtmlLabel4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Guna2HtmlLabel4.Location = New System.Drawing.Point(12, 83)
        Me.Guna2HtmlLabel4.Name = "Guna2HtmlLabel4"
        Me.Guna2HtmlLabel4.Size = New System.Drawing.Size(104, 32)
        Me.Guna2HtmlLabel4.TabIndex = 97
        Me.Guna2HtmlLabel4.Text = "Producto:"
        Me.Guna2HtmlLabel4.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit
        '
        'LBL_Producto
        '
        Me.LBL_Producto.BackColor = System.Drawing.SystemColors.Control
        Me.LBL_Producto.Font = New System.Drawing.Font("Segoe UI Black", 15.75!, System.Drawing.FontStyle.Bold)
        Me.LBL_Producto.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.LBL_Producto.Location = New System.Drawing.Point(122, 83)
        Me.LBL_Producto.Name = "LBL_Producto"
        Me.LBL_Producto.Size = New System.Drawing.Size(87, 32)
        Me.LBL_Producto.TabIndex = 98
        Me.LBL_Producto.Text = "Nombre"
        Me.LBL_Producto.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit
        '
        'LBL_Cod
        '
        Me.LBL_Cod.BackColor = System.Drawing.SystemColors.Control
        Me.LBL_Cod.Font = New System.Drawing.Font("Segoe UI Black", 15.75!, System.Drawing.FontStyle.Bold)
        Me.LBL_Cod.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.LBL_Cod.Location = New System.Drawing.Point(99, 29)
        Me.LBL_Cod.Name = "LBL_Cod"
        Me.LBL_Cod.Size = New System.Drawing.Size(39, 32)
        Me.LBL_Cod.TabIndex = 100
        Me.LBL_Cod.Text = "cod"
        Me.LBL_Cod.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit
        '
        'Guna2HtmlLabel2
        '
        Me.Guna2HtmlLabel2.BackColor = System.Drawing.SystemColors.Control
        Me.Guna2HtmlLabel2.Font = New System.Drawing.Font("Segoe UI Black", 15.75!, System.Drawing.FontStyle.Bold)
        Me.Guna2HtmlLabel2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Guna2HtmlLabel2.Location = New System.Drawing.Point(12, 29)
        Me.Guna2HtmlLabel2.Name = "Guna2HtmlLabel2"
        Me.Guna2HtmlLabel2.Size = New System.Drawing.Size(81, 32)
        Me.Guna2HtmlLabel2.TabIndex = 99
        Me.Guna2HtmlLabel2.Text = "Código:"
        Me.Guna2HtmlLabel2.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit
        '
        'TXT_PrecioVenta
        '
        Me.TXT_PrecioVenta.BackColor = System.Drawing.SystemColors.Control
        Me.TXT_PrecioVenta.BorderColor = System.Drawing.Color.DarkOrange
        Me.TXT_PrecioVenta.BorderRadius = 20
        Me.TXT_PrecioVenta.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TXT_PrecioVenta.DefaultText = ""
        Me.TXT_PrecioVenta.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TXT_PrecioVenta.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TXT_PrecioVenta.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXT_PrecioVenta.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXT_PrecioVenta.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXT_PrecioVenta.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.TXT_PrecioVenta.ForeColor = System.Drawing.Color.Black
        Me.TXT_PrecioVenta.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXT_PrecioVenta.Location = New System.Drawing.Point(187, 135)
        Me.TXT_PrecioVenta.Name = "TXT_PrecioVenta"
        Me.TXT_PrecioVenta.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TXT_PrecioVenta.PlaceholderText = ""
        Me.TXT_PrecioVenta.SelectedText = ""
        Me.TXT_PrecioVenta.Size = New System.Drawing.Size(182, 42)
        Me.TXT_PrecioVenta.TabIndex = 102
        '
        'Guna2HtmlLabel1
        '
        Me.Guna2HtmlLabel1.BackColor = System.Drawing.SystemColors.Control
        Me.Guna2HtmlLabel1.Font = New System.Drawing.Font("Segoe UI Black", 15.75!, System.Drawing.FontStyle.Bold)
        Me.Guna2HtmlLabel1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Guna2HtmlLabel1.Location = New System.Drawing.Point(12, 138)
        Me.Guna2HtmlLabel1.Name = "Guna2HtmlLabel1"
        Me.Guna2HtmlLabel1.Size = New System.Drawing.Size(169, 32)
        Me.Guna2HtmlLabel1.TabIndex = 101
        Me.Guna2HtmlLabel1.Text = "Precio de venta:"
        Me.Guna2HtmlLabel1.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit
        '
        'BTN_RegresarPrd
        '
        Me.BTN_RegresarPrd.BackColor = System.Drawing.SystemColors.Control
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
        Me.BTN_RegresarPrd.Size = New System.Drawing.Size(200, 60)
        Me.BTN_RegresarPrd.TabIndex = 111
        '
        'BTN_SelectProd
        '
        Me.BTN_SelectProd.BackColor = System.Drawing.SystemColors.Control
        Me.BTN_SelectProd.BorderColor = System.Drawing.Color.Red
        Me.BTN_SelectProd.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BTN_SelectProd.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BTN_SelectProd.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BTN_SelectProd.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BTN_SelectProd.Dock = System.Windows.Forms.DockStyle.Right
        Me.BTN_SelectProd.FillColor = System.Drawing.Color.MediumSeaGreen
        Me.BTN_SelectProd.Font = New System.Drawing.Font("Ebrima", 20.25!, System.Drawing.FontStyle.Bold)
        Me.BTN_SelectProd.ForeColor = System.Drawing.Color.White
        Me.BTN_SelectProd.Image = CType(resources.GetObject("BTN_SelectProd.Image"), System.Drawing.Image)
        Me.BTN_SelectProd.ImageSize = New System.Drawing.Size(40, 40)
        Me.BTN_SelectProd.Location = New System.Drawing.Point(200, 0)
        Me.BTN_SelectProd.Name = "BTN_SelectProd"
        Me.BTN_SelectProd.Size = New System.Drawing.Size(200, 60)
        Me.BTN_SelectProd.TabIndex = 110
        '
        'LBL_ID
        '
        Me.LBL_ID.BackColor = System.Drawing.SystemColors.Control
        Me.LBL_ID.Font = New System.Drawing.Font("Segoe UI Black", 15.75!, System.Drawing.FontStyle.Bold)
        Me.LBL_ID.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.LBL_ID.Location = New System.Drawing.Point(349, 12)
        Me.LBL_ID.Name = "LBL_ID"
        Me.LBL_ID.Size = New System.Drawing.Size(22, 32)
        Me.LBL_ID.TabIndex = 112
        Me.LBL_ID.Text = "id"
        Me.LBL_ID.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit
        Me.LBL_ID.Visible = False
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.Controls.Add(Me.BTN_SelectProd)
        Me.Guna2Panel1.Controls.Add(Me.BTN_RegresarPrd)
        Me.Guna2Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Guna2Panel1.Location = New System.Drawing.Point(0, 196)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.Size = New System.Drawing.Size(400, 60)
        Me.Guna2Panel1.TabIndex = 113
        '
        'E_ProductoVariable
        '
        Me.AcceptButton = Me.BTN_SelectProd
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.CancelButton = Me.BTN_RegresarPrd
        Me.ClientSize = New System.Drawing.Size(400, 256)
        Me.Controls.Add(Me.Guna2Panel1)
        Me.Controls.Add(Me.LBL_ID)
        Me.Controls.Add(Me.TXT_PrecioVenta)
        Me.Controls.Add(Me.Guna2HtmlLabel1)
        Me.Controls.Add(Me.LBL_Cod)
        Me.Controls.Add(Me.Guna2HtmlLabel2)
        Me.Controls.Add(Me.LBL_Producto)
        Me.Controls.Add(Me.Guna2HtmlLabel4)
        Me.ForeColor = System.Drawing.SystemColors.Control
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "E_ProductoVariable"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Agregar precio"
        Me.Guna2Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Guna2BorderlessForm1 As Guna.UI2.WinForms.Guna2BorderlessForm
    Friend WithEvents LBL_Cod As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel2 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents LBL_Producto As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel4 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents TXT_PrecioVenta As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2HtmlLabel1 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents BTN_RegresarPrd As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BTN_SelectProd As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents LBL_ID As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
End Class
