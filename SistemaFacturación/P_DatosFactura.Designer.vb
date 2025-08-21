<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class P_DatosFactura
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(P_DatosFactura))
        Me.Guna2BorderlessForm1 = New Guna.UI2.WinForms.Guna2BorderlessForm(Me.components)
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TXT_NumFact = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TXT_FechaEmision = New Guna.UI2.WinForms.Guna2TextBox()
        Me.TXT_Cliente = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TXT_Cajero = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TXT_Total = New Guna.UI2.WinForms.Guna2TextBox()
        Me.TXT_Efectivo = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TXT_Vuelto = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TXT_TipoPago = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TXT_Tarjeta = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TXT_Comentario = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.BTN_RegresarPed = New Guna.UI2.WinForms.Guna2Button()
        Me.DGV_ProdFact = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.BTN_CerrarApp = New Guna.UI2.WinForms.Guna2ImageButton()
        Me.Panel1.SuspendLayout()
        CType(Me.DGV_ProdFact, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Guna2BorderlessForm1
        '
        Me.Guna2BorderlessForm1.AnimationType = Guna.UI2.WinForms.Guna2BorderlessForm.AnimateWindowType.AW_CENTER
        Me.Guna2BorderlessForm1.BorderRadius = 25
        Me.Guna2BorderlessForm1.ContainerControl = Me
        Me.Guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6R
        Me.Guna2BorderlessForm1.TransparentWhileDrag = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Britannic Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(26, 35)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(146, 17)
        Me.Label5.TabIndex = 61
        Me.Label5.Text = "Numero de factura:"
        '
        'TXT_NumFact
        '
        Me.TXT_NumFact.AutoRoundedCorners = True
        Me.TXT_NumFact.BorderRadius = 20
        Me.TXT_NumFact.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TXT_NumFact.DefaultText = ""
        Me.TXT_NumFact.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TXT_NumFact.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TXT_NumFact.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXT_NumFact.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXT_NumFact.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXT_NumFact.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.TXT_NumFact.ForeColor = System.Drawing.Color.Black
        Me.TXT_NumFact.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXT_NumFact.IconRightSize = New System.Drawing.Size(40, 40)
        Me.TXT_NumFact.Location = New System.Drawing.Point(178, 22)
        Me.TXT_NumFact.Name = "TXT_NumFact"
        Me.TXT_NumFact.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TXT_NumFact.PlaceholderText = "Num"
        Me.TXT_NumFact.ReadOnly = True
        Me.TXT_NumFact.SelectedText = ""
        Me.TXT_NumFact.Size = New System.Drawing.Size(201, 42)
        Me.TXT_NumFact.TabIndex = 62
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Britannic Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(391, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(137, 17)
        Me.Label1.TabIndex = 63
        Me.Label1.Text = "Fecha de Emisión:"
        '
        'TXT_FechaEmision
        '
        Me.TXT_FechaEmision.AutoRoundedCorners = True
        Me.TXT_FechaEmision.BorderRadius = 20
        Me.TXT_FechaEmision.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TXT_FechaEmision.DefaultText = ""
        Me.TXT_FechaEmision.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TXT_FechaEmision.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TXT_FechaEmision.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXT_FechaEmision.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXT_FechaEmision.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXT_FechaEmision.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.TXT_FechaEmision.ForeColor = System.Drawing.Color.Black
        Me.TXT_FechaEmision.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXT_FechaEmision.IconRightSize = New System.Drawing.Size(40, 40)
        Me.TXT_FechaEmision.Location = New System.Drawing.Point(534, 22)
        Me.TXT_FechaEmision.Name = "TXT_FechaEmision"
        Me.TXT_FechaEmision.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TXT_FechaEmision.PlaceholderText = "fecha"
        Me.TXT_FechaEmision.ReadOnly = True
        Me.TXT_FechaEmision.SelectedText = ""
        Me.TXT_FechaEmision.Size = New System.Drawing.Size(170, 42)
        Me.TXT_FechaEmision.TabIndex = 64
        '
        'TXT_Cliente
        '
        Me.TXT_Cliente.AutoRoundedCorners = True
        Me.TXT_Cliente.BorderRadius = 20
        Me.TXT_Cliente.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TXT_Cliente.DefaultText = ""
        Me.TXT_Cliente.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TXT_Cliente.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TXT_Cliente.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXT_Cliente.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXT_Cliente.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXT_Cliente.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.TXT_Cliente.ForeColor = System.Drawing.Color.Black
        Me.TXT_Cliente.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXT_Cliente.IconRightSize = New System.Drawing.Size(40, 40)
        Me.TXT_Cliente.Location = New System.Drawing.Point(98, 81)
        Me.TXT_Cliente.Name = "TXT_Cliente"
        Me.TXT_Cliente.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TXT_Cliente.PlaceholderText = "Num"
        Me.TXT_Cliente.ReadOnly = True
        Me.TXT_Cliente.SelectedText = ""
        Me.TXT_Cliente.Size = New System.Drawing.Size(201, 42)
        Me.TXT_Cliente.TabIndex = 66
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Britannic Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(31, 95)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 17)
        Me.Label2.TabIndex = 65
        Me.Label2.Text = "Cliente:"
        '
        'TXT_Cajero
        '
        Me.TXT_Cajero.AutoRoundedCorners = True
        Me.TXT_Cajero.BorderRadius = 20
        Me.TXT_Cajero.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TXT_Cajero.DefaultText = ""
        Me.TXT_Cajero.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TXT_Cajero.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TXT_Cajero.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXT_Cajero.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXT_Cajero.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXT_Cajero.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.TXT_Cajero.ForeColor = System.Drawing.Color.Black
        Me.TXT_Cajero.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXT_Cajero.IconRightSize = New System.Drawing.Size(40, 40)
        Me.TXT_Cajero.Location = New System.Drawing.Point(385, 81)
        Me.TXT_Cajero.Name = "TXT_Cajero"
        Me.TXT_Cajero.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TXT_Cajero.PlaceholderText = "Num"
        Me.TXT_Cajero.ReadOnly = True
        Me.TXT_Cajero.SelectedText = ""
        Me.TXT_Cajero.Size = New System.Drawing.Size(201, 42)
        Me.TXT_Cajero.TabIndex = 68
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Britannic Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(319, 95)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(60, 17)
        Me.Label3.TabIndex = 67
        Me.Label3.Text = "Cajero:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Britannic Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(45, 152)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(47, 17)
        Me.Label4.TabIndex = 69
        Me.Label4.Text = "Total:"
        '
        'TXT_Total
        '
        Me.TXT_Total.AutoRoundedCorners = True
        Me.TXT_Total.BorderRadius = 20
        Me.TXT_Total.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TXT_Total.DefaultText = ""
        Me.TXT_Total.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TXT_Total.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TXT_Total.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXT_Total.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXT_Total.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXT_Total.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.TXT_Total.ForeColor = System.Drawing.Color.Black
        Me.TXT_Total.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXT_Total.IconRightSize = New System.Drawing.Size(40, 40)
        Me.TXT_Total.Location = New System.Drawing.Point(98, 140)
        Me.TXT_Total.Name = "TXT_Total"
        Me.TXT_Total.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TXT_Total.PlaceholderText = "Num"
        Me.TXT_Total.ReadOnly = True
        Me.TXT_Total.SelectedText = ""
        Me.TXT_Total.Size = New System.Drawing.Size(167, 42)
        Me.TXT_Total.TabIndex = 70
        '
        'TXT_Efectivo
        '
        Me.TXT_Efectivo.AutoRoundedCorners = True
        Me.TXT_Efectivo.BorderRadius = 20
        Me.TXT_Efectivo.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TXT_Efectivo.DefaultText = ""
        Me.TXT_Efectivo.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TXT_Efectivo.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TXT_Efectivo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXT_Efectivo.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXT_Efectivo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXT_Efectivo.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.TXT_Efectivo.ForeColor = System.Drawing.Color.Black
        Me.TXT_Efectivo.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXT_Efectivo.IconRightSize = New System.Drawing.Size(40, 40)
        Me.TXT_Efectivo.Location = New System.Drawing.Point(178, 205)
        Me.TXT_Efectivo.Name = "TXT_Efectivo"
        Me.TXT_Efectivo.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TXT_Efectivo.PlaceholderText = "Num"
        Me.TXT_Efectivo.ReadOnly = True
        Me.TXT_Efectivo.SelectedText = ""
        Me.TXT_Efectivo.Size = New System.Drawing.Size(167, 42)
        Me.TXT_Efectivo.TabIndex = 72
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Britannic Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(64, 215)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(108, 17)
        Me.Label6.TabIndex = 71
        Me.Label6.Text = "Pago efectivo:"
        '
        'TXT_Vuelto
        '
        Me.TXT_Vuelto.AutoRoundedCorners = True
        Me.TXT_Vuelto.BorderRadius = 20
        Me.TXT_Vuelto.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TXT_Vuelto.DefaultText = ""
        Me.TXT_Vuelto.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TXT_Vuelto.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TXT_Vuelto.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXT_Vuelto.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXT_Vuelto.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXT_Vuelto.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.TXT_Vuelto.ForeColor = System.Drawing.Color.Black
        Me.TXT_Vuelto.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXT_Vuelto.IconRightSize = New System.Drawing.Size(40, 40)
        Me.TXT_Vuelto.Location = New System.Drawing.Point(631, 140)
        Me.TXT_Vuelto.Name = "TXT_Vuelto"
        Me.TXT_Vuelto.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TXT_Vuelto.PlaceholderText = "Num"
        Me.TXT_Vuelto.ReadOnly = True
        Me.TXT_Vuelto.SelectedText = ""
        Me.TXT_Vuelto.Size = New System.Drawing.Size(167, 42)
        Me.TXT_Vuelto.TabIndex = 74
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Britannic Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(568, 152)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(57, 17)
        Me.Label7.TabIndex = 73
        Me.Label7.Text = "Vuelto:"
        '
        'TXT_TipoPago
        '
        Me.TXT_TipoPago.AutoRoundedCorners = True
        Me.TXT_TipoPago.BorderRadius = 20
        Me.TXT_TipoPago.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TXT_TipoPago.DefaultText = ""
        Me.TXT_TipoPago.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TXT_TipoPago.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TXT_TipoPago.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXT_TipoPago.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXT_TipoPago.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXT_TipoPago.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.TXT_TipoPago.ForeColor = System.Drawing.Color.Black
        Me.TXT_TipoPago.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXT_TipoPago.IconRightSize = New System.Drawing.Size(40, 40)
        Me.TXT_TipoPago.Location = New System.Drawing.Point(385, 140)
        Me.TXT_TipoPago.Name = "TXT_TipoPago"
        Me.TXT_TipoPago.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TXT_TipoPago.PlaceholderText = "Num"
        Me.TXT_TipoPago.ReadOnly = True
        Me.TXT_TipoPago.SelectedText = ""
        Me.TXT_TipoPago.Size = New System.Drawing.Size(158, 42)
        Me.TXT_TipoPago.TabIndex = 76
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Britannic Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(274, 152)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(105, 17)
        Me.Label8.TabIndex = 75
        Me.Label8.Text = "Tipo de pago:"
        '
        'TXT_Tarjeta
        '
        Me.TXT_Tarjeta.AutoRoundedCorners = True
        Me.TXT_Tarjeta.BorderRadius = 20
        Me.TXT_Tarjeta.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TXT_Tarjeta.DefaultText = ""
        Me.TXT_Tarjeta.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TXT_Tarjeta.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TXT_Tarjeta.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXT_Tarjeta.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXT_Tarjeta.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXT_Tarjeta.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.TXT_Tarjeta.ForeColor = System.Drawing.Color.Black
        Me.TXT_Tarjeta.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXT_Tarjeta.IconRightSize = New System.Drawing.Size(40, 40)
        Me.TXT_Tarjeta.Location = New System.Drawing.Point(496, 205)
        Me.TXT_Tarjeta.Name = "TXT_Tarjeta"
        Me.TXT_Tarjeta.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TXT_Tarjeta.PlaceholderText = "Num"
        Me.TXT_Tarjeta.ReadOnly = True
        Me.TXT_Tarjeta.SelectedText = ""
        Me.TXT_Tarjeta.Size = New System.Drawing.Size(167, 42)
        Me.TXT_Tarjeta.TabIndex = 78
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Britannic Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(380, 215)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(100, 17)
        Me.Label9.TabIndex = 77
        Me.Label9.Text = "Pago tarjeta:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Britannic Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(26, 273)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(95, 17)
        Me.Label10.TabIndex = 79
        Me.Label10.Text = "Comentario:"
        '
        'TXT_Comentario
        '
        Me.TXT_Comentario.BorderRadius = 15
        Me.TXT_Comentario.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TXT_Comentario.DefaultText = ""
        Me.TXT_Comentario.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TXT_Comentario.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TXT_Comentario.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXT_Comentario.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXT_Comentario.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXT_Comentario.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.TXT_Comentario.ForeColor = System.Drawing.Color.Black
        Me.TXT_Comentario.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXT_Comentario.IconRightSize = New System.Drawing.Size(40, 40)
        Me.TXT_Comentario.Location = New System.Drawing.Point(127, 262)
        Me.TXT_Comentario.Multiline = True
        Me.TXT_Comentario.Name = "TXT_Comentario"
        Me.TXT_Comentario.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TXT_Comentario.PlaceholderText = "Num"
        Me.TXT_Comentario.ReadOnly = True
        Me.TXT_Comentario.SelectedText = ""
        Me.TXT_Comentario.Size = New System.Drawing.Size(671, 60)
        Me.TXT_Comentario.TabIndex = 80
        Me.TXT_Comentario.TextOffset = New System.Drawing.Point(10, 0)
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Britannic Bold", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(335, 336)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(136, 30)
        Me.Label11.TabIndex = 81
        Me.Label11.Text = "Productos"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.BTN_RegresarPed)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 648)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(813, 61)
        Me.Panel1.TabIndex = 82
        '
        'BTN_RegresarPed
        '
        Me.BTN_RegresarPed.BorderColor = System.Drawing.Color.Red
        Me.BTN_RegresarPed.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.BTN_RegresarPed.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BTN_RegresarPed.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BTN_RegresarPed.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BTN_RegresarPed.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BTN_RegresarPed.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.BTN_RegresarPed.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BTN_RegresarPed.Font = New System.Drawing.Font("Ebrima", 20.25!, System.Drawing.FontStyle.Bold)
        Me.BTN_RegresarPed.ForeColor = System.Drawing.Color.White
        Me.BTN_RegresarPed.Image = CType(resources.GetObject("BTN_RegresarPed.Image"), System.Drawing.Image)
        Me.BTN_RegresarPed.ImageSize = New System.Drawing.Size(40, 40)
        Me.BTN_RegresarPed.Location = New System.Drawing.Point(0, 0)
        Me.BTN_RegresarPed.Name = "BTN_RegresarPed"
        Me.BTN_RegresarPed.Size = New System.Drawing.Size(813, 61)
        Me.BTN_RegresarPed.TabIndex = 83
        Me.BTN_RegresarPed.Text = "Regresar"
        '
        'DGV_ProdFact
        '
        Me.DGV_ProdFact.AllowUserToAddRows = False
        Me.DGV_ProdFact.AllowUserToDeleteRows = False
        Me.DGV_ProdFact.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.DGV_ProdFact.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGV_ProdFact.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DGV_ProdFact.ColumnHeadersHeight = 20
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DGV_ProdFact.DefaultCellStyle = DataGridViewCellStyle3
        Me.DGV_ProdFact.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DGV_ProdFact.Location = New System.Drawing.Point(31, 369)
        Me.DGV_ProdFact.MultiSelect = False
        Me.DGV_ProdFact.Name = "DGV_ProdFact"
        Me.DGV_ProdFact.ReadOnly = True
        Me.DGV_ProdFact.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGV_ProdFact.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.DGV_ProdFact.RowHeadersVisible = False
        Me.DGV_ProdFact.Size = New System.Drawing.Size(749, 258)
        Me.DGV_ProdFact.TabIndex = 83
        Me.DGV_ProdFact.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.DGV_ProdFact.ThemeStyle.AlternatingRowsStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DGV_ProdFact.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.SystemColors.ControlText
        Me.DGV_ProdFact.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DGV_ProdFact.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.DGV_ProdFact.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.DGV_ProdFact.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DGV_ProdFact.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.DGV_ProdFact.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.DGV_ProdFact.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DGV_ProdFact.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.DGV_ProdFact.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.DGV_ProdFact.ThemeStyle.HeaderStyle.Height = 20
        Me.DGV_ProdFact.ThemeStyle.ReadOnly = True
        Me.DGV_ProdFact.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.DGV_ProdFact.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.DGV_ProdFact.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DGV_ProdFact.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.DGV_ProdFact.ThemeStyle.RowsStyle.Height = 22
        Me.DGV_ProdFact.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DGV_ProdFact.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        '
        'BTN_CerrarApp
        '
        Me.BTN_CerrarApp.BackColor = System.Drawing.Color.Red
        Me.BTN_CerrarApp.CheckedState.ImageSize = New System.Drawing.Size(64, 64)
        Me.BTN_CerrarApp.HoverState.ImageSize = New System.Drawing.Size(64, 64)
        Me.BTN_CerrarApp.Image = CType(resources.GetObject("BTN_CerrarApp.Image"), System.Drawing.Image)
        Me.BTN_CerrarApp.ImageOffset = New System.Drawing.Point(0, 0)
        Me.BTN_CerrarApp.ImageRotate = 0!
        Me.BTN_CerrarApp.ImageSize = New System.Drawing.Size(60, 60)
        Me.BTN_CerrarApp.Location = New System.Drawing.Point(758, -1)
        Me.BTN_CerrarApp.Name = "BTN_CerrarApp"
        Me.BTN_CerrarApp.PressedState.ImageSize = New System.Drawing.Size(64, 64)
        Me.BTN_CerrarApp.Size = New System.Drawing.Size(55, 53)
        Me.BTN_CerrarApp.TabIndex = 124
        '
        'P_DatosFactura
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(813, 709)
        Me.Controls.Add(Me.BTN_CerrarApp)
        Me.Controls.Add(Me.DGV_ProdFact)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.TXT_Comentario)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.TXT_Tarjeta)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.TXT_TipoPago)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.TXT_Vuelto)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.TXT_Efectivo)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.TXT_Total)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TXT_Cajero)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TXT_Cliente)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TXT_FechaEmision)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TXT_NumFact)
        Me.Controls.Add(Me.Label5)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Name = "P_DatosFactura"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Datos de la factura"
        Me.Panel1.ResumeLayout(False)
        CType(Me.DGV_ProdFact, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Guna2BorderlessForm1 As Guna.UI2.WinForms.Guna2BorderlessForm
    Friend WithEvents Label5 As Label
    Friend WithEvents TXT_NumFact As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TXT_FechaEmision As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents TXT_Cliente As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TXT_Cajero As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TXT_Vuelto As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents TXT_Efectivo As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents TXT_Total As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TXT_TipoPago As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents TXT_Tarjeta As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents TXT_Comentario As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents BTN_RegresarPed As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents DGV_ProdFact As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents BTN_CerrarApp As Guna.UI2.WinForms.Guna2ImageButton
End Class
