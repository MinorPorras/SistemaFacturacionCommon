<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class P_ReporteVentas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(P_ReporteVentas))
        Me.Guna2BorderlessForm1 = New Guna.UI2.WinForms.Guna2BorderlessForm(Me.components)
        Me.DGV_FactReporte = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.DTP_Desde = New Guna.UI2.WinForms.Guna2DateTimePicker()
        Me.DTP_Hasta = New Guna.UI2.WinForms.Guna2DateTimePicker()
        Me.BTN_RegresarReporte = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.BTN_GenReporte = New Guna.UI2.WinForms.Guna2Button()
        Me.TXT_TotalVentas = New Guna.UI2.WinForms.Guna2TextBox()
        Me.LBL_Usu = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel1 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel2 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2PictureBox1 = New Guna.UI2.WinForms.Guna2PictureBox()
        CType(Me.DGV_FactReporte, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Guna2Panel1.SuspendLayout()
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Guna2BorderlessForm1
        '
        Me.Guna2BorderlessForm1.BorderRadius = 25
        Me.Guna2BorderlessForm1.ContainerControl = Me
        Me.Guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6R
        Me.Guna2BorderlessForm1.TransparentWhileDrag = True
        '
        'DGV_FactReporte
        '
        Me.DGV_FactReporte.AllowUserToAddRows = False
        Me.DGV_FactReporte.AllowUserToDeleteRows = False
        Me.DGV_FactReporte.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.DGV_FactReporte.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGV_FactReporte.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DGV_FactReporte.ColumnHeadersHeight = 20
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DGV_FactReporte.DefaultCellStyle = DataGridViewCellStyle3
        Me.DGV_FactReporte.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DGV_FactReporte.Location = New System.Drawing.Point(12, 163)
        Me.DGV_FactReporte.MultiSelect = False
        Me.DGV_FactReporte.Name = "DGV_FactReporte"
        Me.DGV_FactReporte.ReadOnly = True
        Me.DGV_FactReporte.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGV_FactReporte.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.DGV_FactReporte.RowHeadersVisible = False
        Me.DGV_FactReporte.Size = New System.Drawing.Size(889, 279)
        Me.DGV_FactReporte.TabIndex = 79
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
        'DTP_Desde
        '
        Me.DTP_Desde.Checked = True
        Me.DTP_Desde.FillColor = System.Drawing.Color.White
        Me.DTP_Desde.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.DTP_Desde.Format = System.Windows.Forms.DateTimePickerFormat.[Long]
        Me.DTP_Desde.Location = New System.Drawing.Point(12, 492)
        Me.DTP_Desde.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.DTP_Desde.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.DTP_Desde.Name = "DTP_Desde"
        Me.DTP_Desde.Size = New System.Drawing.Size(200, 36)
        Me.DTP_Desde.TabIndex = 80
        Me.DTP_Desde.Value = New Date(2025, 3, 17, 19, 28, 7, 244)
        '
        'DTP_Hasta
        '
        Me.DTP_Hasta.Checked = True
        Me.DTP_Hasta.FillColor = System.Drawing.Color.White
        Me.DTP_Hasta.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.DTP_Hasta.Format = System.Windows.Forms.DateTimePickerFormat.[Long]
        Me.DTP_Hasta.Location = New System.Drawing.Point(247, 492)
        Me.DTP_Hasta.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.DTP_Hasta.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.DTP_Hasta.Name = "DTP_Hasta"
        Me.DTP_Hasta.Size = New System.Drawing.Size(200, 36)
        Me.DTP_Hasta.TabIndex = 81
        Me.DTP_Hasta.Value = New Date(2025, 3, 17, 19, 28, 7, 244)
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
        Me.BTN_RegresarReporte.Size = New System.Drawing.Size(447, 70)
        Me.BTN_RegresarReporte.TabIndex = 82
        Me.BTN_RegresarReporte.Text = "Regresar"
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.Controls.Add(Me.BTN_RegresarReporte)
        Me.Guna2Panel1.Controls.Add(Me.BTN_GenReporte)
        Me.Guna2Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Guna2Panel1.Location = New System.Drawing.Point(0, 572)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.Size = New System.Drawing.Size(913, 70)
        Me.Guna2Panel1.TabIndex = 84
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
        Me.BTN_GenReporte.Location = New System.Drawing.Point(442, 0)
        Me.BTN_GenReporte.Name = "BTN_GenReporte"
        Me.BTN_GenReporte.Size = New System.Drawing.Size(471, 70)
        Me.BTN_GenReporte.TabIndex = 83
        Me.BTN_GenReporte.Text = "Generar reporte"
        '
        'TXT_TotalVentas
        '
        Me.TXT_TotalVentas.BorderRadius = 20
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
        Me.TXT_TotalVentas.Location = New System.Drawing.Point(675, 486)
        Me.TXT_TotalVentas.Name = "TXT_TotalVentas"
        Me.TXT_TotalVentas.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TXT_TotalVentas.PlaceholderText = ""
        Me.TXT_TotalVentas.ReadOnly = True
        Me.TXT_TotalVentas.SelectedText = ""
        Me.TXT_TotalVentas.Size = New System.Drawing.Size(226, 42)
        Me.TXT_TotalVentas.TabIndex = 85
        '
        'LBL_Usu
        '
        Me.LBL_Usu.BackColor = System.Drawing.Color.Transparent
        Me.LBL_Usu.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_Usu.ForeColor = System.Drawing.SystemColors.Control
        Me.LBL_Usu.Location = New System.Drawing.Point(12, 463)
        Me.LBL_Usu.Name = "LBL_Usu"
        Me.LBL_Usu.Size = New System.Drawing.Size(54, 23)
        Me.LBL_Usu.TabIndex = 116
        Me.LBL_Usu.Text = "Desde:"
        Me.LBL_Usu.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit
        '
        'Guna2HtmlLabel1
        '
        Me.Guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel1.ForeColor = System.Drawing.SystemColors.Control
        Me.Guna2HtmlLabel1.Location = New System.Drawing.Point(247, 463)
        Me.Guna2HtmlLabel1.Name = "Guna2HtmlLabel1"
        Me.Guna2HtmlLabel1.Size = New System.Drawing.Size(50, 23)
        Me.Guna2HtmlLabel1.TabIndex = 117
        Me.Guna2HtmlLabel1.Text = "Hasta:"
        Me.Guna2HtmlLabel1.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit
        '
        'Guna2HtmlLabel2
        '
        Me.Guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel2.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel2.ForeColor = System.Drawing.SystemColors.Control
        Me.Guna2HtmlLabel2.Location = New System.Drawing.Point(485, 490)
        Me.Guna2HtmlLabel2.Name = "Guna2HtmlLabel2"
        Me.Guna2HtmlLabel2.Size = New System.Drawing.Size(184, 34)
        Me.Guna2HtmlLabel2.TabIndex = 119
        Me.Guna2HtmlLabel2.Text = "Total de ventas:"
        Me.Guna2HtmlLabel2.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit
        '
        'Guna2PictureBox1
        '
        Me.Guna2PictureBox1.Image = CType(resources.GetObject("Guna2PictureBox1.Image"), System.Drawing.Image)
        Me.Guna2PictureBox1.ImageRotate = 0!
        Me.Guna2PictureBox1.Location = New System.Drawing.Point(266, -80)
        Me.Guna2PictureBox1.Name = "Guna2PictureBox1"
        Me.Guna2PictureBox1.Size = New System.Drawing.Size(385, 317)
        Me.Guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Guna2PictureBox1.TabIndex = 120
        Me.Guna2PictureBox1.TabStop = False
        '
        'P_ReporteVentas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(913, 642)
        Me.Controls.Add(Me.Guna2HtmlLabel2)
        Me.Controls.Add(Me.Guna2HtmlLabel1)
        Me.Controls.Add(Me.LBL_Usu)
        Me.Controls.Add(Me.TXT_TotalVentas)
        Me.Controls.Add(Me.Guna2Panel1)
        Me.Controls.Add(Me.DTP_Hasta)
        Me.Controls.Add(Me.DTP_Desde)
        Me.Controls.Add(Me.DGV_FactReporte)
        Me.Controls.Add(Me.Guna2PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "P_ReporteVentas"
        Me.Text = "P_ReporteVentas"
        CType(Me.DGV_FactReporte, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Guna2Panel1.ResumeLayout(False)
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Guna2BorderlessForm1 As Guna.UI2.WinForms.Guna2BorderlessForm
    Friend WithEvents DTP_Hasta As Guna.UI2.WinForms.Guna2DateTimePicker
    Friend WithEvents DTP_Desde As Guna.UI2.WinForms.Guna2DateTimePicker
    Friend WithEvents DGV_FactReporte As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents BTN_RegresarReporte As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents TXT_TotalVentas As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2HtmlLabel1 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents LBL_Usu As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel2 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2PictureBox1 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents BTN_GenReporte As Guna.UI2.WinForms.Guna2Button
End Class
