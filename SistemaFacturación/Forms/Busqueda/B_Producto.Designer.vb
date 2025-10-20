Namespace SistemaFacturacion.Forms.Busqueda

    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Class B_Producto
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
            Dim DataGridViewCellStyle17 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle18 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle19 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle20 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(B_Producto))
            Me.Guna2BorderlessForm1 = New Guna.UI2.WinForms.Guna2BorderlessForm(Me.components)
            Me.LBL_IDProd = New System.Windows.Forms.Label()
            Me.Label1 = New System.Windows.Forms.Label()
            Me.TXT_codigo = New Guna.UI2.WinForms.Guna2TextBox()
            Me.BTN_RegresarPrd = New Guna.UI2.WinForms.Guna2Button()
            Me.BTN_SelectProd = New Guna.UI2.WinForms.Guna2Button()
            Me.TXT_BuscarProd = New Guna.UI2.WinForms.Guna2TextBox()
            Me.Guna2PictureBox2 = New Guna.UI2.WinForms.Guna2PictureBox()
            Me.TXT_Nombre = New Guna.UI2.WinForms.Guna2TextBox()
            Me.Label2 = New System.Windows.Forms.Label()
            Me.Label4 = New System.Windows.Forms.Label()
            Me.TXT_Precio = New Guna.UI2.WinForms.Guna2TextBox()
            Me.Guna2TextBox1 = New Guna.UI2.WinForms.Guna2TextBox()
            Me.DGV_BProd = New Guna.UI2.WinForms.Guna2DataGridView()
            Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
            Me.TXT_CantProd = New Guna.UI2.WinForms.Guna2TextBox()
            Me.Label3 = New System.Windows.Forms.Label()
            Me.BTN_MenosCant = New Guna.UI2.WinForms.Guna2CircleButton()
            Me.BTN_MasCant = New Guna.UI2.WinForms.Guna2CircleButton()
            Me.GBX_Filter = New Guna.UI2.WinForms.Guna2GroupBox()
            Me.RDB_All = New Guna.UI2.WinForms.Guna2RadioButton()
            Me.RDB_200 = New Guna.UI2.WinForms.Guna2RadioButton()
            Me.RDB_100 = New Guna.UI2.WinForms.Guna2RadioButton()
            Me.RDB_500 = New Guna.UI2.WinForms.Guna2RadioButton()
            CType(Me.Guna2PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.DGV_BProd, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.Guna2Panel1.SuspendLayout()
            Me.GBX_Filter.SuspendLayout()
            Me.SuspendLayout()
            '
            'Guna2BorderlessForm1
            '
            Me.Guna2BorderlessForm1.BorderRadius = 25
            Me.Guna2BorderlessForm1.ContainerControl = Me
            Me.Guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6R
            Me.Guna2BorderlessForm1.TransparentWhileDrag = True
            '
            'LBL_IDProd
            '
            Me.LBL_IDProd.AutoSize = True
            Me.LBL_IDProd.Font = New System.Drawing.Font("Britannic Bold", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.LBL_IDProd.ForeColor = System.Drawing.Color.White
            Me.LBL_IDProd.Location = New System.Drawing.Point(843, 398)
            Me.LBL_IDProd.Name = "LBL_IDProd"
            Me.LBL_IDProd.Size = New System.Drawing.Size(16, 23)
            Me.LBL_IDProd.TabIndex = 96
            Me.LBL_IDProd.Text = " "
            Me.LBL_IDProd.Visible = False
            '
            'Label1
            '
            Me.Label1.AutoSize = True
            Me.Label1.Font = New System.Drawing.Font("Britannic Bold", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label1.ForeColor = System.Drawing.Color.White
            Me.Label1.Location = New System.Drawing.Point(531, 251)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(79, 23)
            Me.Label1.TabIndex = 93
            Me.Label1.Text = "Codigo:"
            '
            'TXT_codigo
            '
            Me.TXT_codigo.BorderRadius = 20
            Me.TXT_codigo.Cursor = System.Windows.Forms.Cursors.IBeam
            Me.TXT_codigo.DefaultText = ""
            Me.TXT_codigo.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
            Me.TXT_codigo.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
            Me.TXT_codigo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
            Me.TXT_codigo.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
            Me.TXT_codigo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.TXT_codigo.Font = New System.Drawing.Font("Segoe UI", 9.0!)
            Me.TXT_codigo.ForeColor = System.Drawing.Color.Black
            Me.TXT_codigo.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.TXT_codigo.Location = New System.Drawing.Point(616, 241)
            Me.TXT_codigo.Name = "TXT_codigo"
            Me.TXT_codigo.PlaceholderText = ""
            Me.TXT_codigo.ReadOnly = True
            Me.TXT_codigo.SelectedText = ""
            Me.TXT_codigo.Size = New System.Drawing.Size(210, 42)
            Me.TXT_codigo.TabIndex = 92
            '
            'BTN_RegresarPrd
            '
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
            Me.BTN_RegresarPrd.Image = Global.SistemaFacturaciónCommon.My.Resources.Resources.ICO_Back
            Me.BTN_RegresarPrd.ImageSize = New System.Drawing.Size(40, 40)
            Me.BTN_RegresarPrd.Location = New System.Drawing.Point(0, 0)
            Me.BTN_RegresarPrd.Name = "BTN_RegresarPrd"
            Me.BTN_RegresarPrd.Size = New System.Drawing.Size(481, 68)
            Me.BTN_RegresarPrd.TabIndex = 89
            Me.BTN_RegresarPrd.Text = "Regresar"
            '
            'BTN_SelectProd
            '
            Me.BTN_SelectProd.BorderColor = System.Drawing.Color.Red
            Me.BTN_SelectProd.DisabledState.BorderColor = System.Drawing.Color.DarkGray
            Me.BTN_SelectProd.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
            Me.BTN_SelectProd.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
            Me.BTN_SelectProd.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
            Me.BTN_SelectProd.Dock = System.Windows.Forms.DockStyle.Right
            Me.BTN_SelectProd.FillColor = System.Drawing.Color.MediumSeaGreen
            Me.BTN_SelectProd.Font = New System.Drawing.Font("Ebrima", 20.25!, System.Drawing.FontStyle.Bold)
            Me.BTN_SelectProd.ForeColor = System.Drawing.Color.White
            Me.BTN_SelectProd.Image = Global.SistemaFacturaciónCommon.My.Resources.Resources.ICO_Check
            Me.BTN_SelectProd.ImageSize = New System.Drawing.Size(40, 40)
            Me.BTN_SelectProd.Location = New System.Drawing.Point(481, 0)
            Me.BTN_SelectProd.Name = "BTN_SelectProd"
            Me.BTN_SelectProd.Size = New System.Drawing.Size(481, 68)
            Me.BTN_SelectProd.TabIndex = 88
            Me.BTN_SelectProd.Text = "Seleccionar"
            '
            'TXT_BuscarProd
            '
            Me.TXT_BuscarProd.BorderRadius = 20
            Me.TXT_BuscarProd.Cursor = System.Windows.Forms.Cursors.IBeam
            Me.TXT_BuscarProd.DefaultText = ""
            Me.TXT_BuscarProd.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
            Me.TXT_BuscarProd.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
            Me.TXT_BuscarProd.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
            Me.TXT_BuscarProd.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
            Me.TXT_BuscarProd.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.TXT_BuscarProd.Font = New System.Drawing.Font("Segoe UI", 9.0!)
            Me.TXT_BuscarProd.ForeColor = System.Drawing.Color.Black
            Me.TXT_BuscarProd.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.TXT_BuscarProd.IconRight = Global.SistemaFacturaciónCommon.My.Resources.Resources.ICO_SearchCol
            Me.TXT_BuscarProd.IconRightOffset = New System.Drawing.Point(10, 0)
            Me.TXT_BuscarProd.IconRightSize = New System.Drawing.Size(40, 40)
            Me.TXT_BuscarProd.Location = New System.Drawing.Point(23, 152)
            Me.TXT_BuscarProd.Name = "TXT_BuscarProd"
            Me.TXT_BuscarProd.PlaceholderText = "Buscar producto"
            Me.TXT_BuscarProd.SelectedText = ""
            Me.TXT_BuscarProd.Size = New System.Drawing.Size(716, 42)
            Me.TXT_BuscarProd.TabIndex = 87
            '
            'Guna2PictureBox2
            '
            Me.Guna2PictureBox2.Image = CType(resources.GetObject("Guna2PictureBox2.Image"), System.Drawing.Image)
            Me.Guna2PictureBox2.ImageRotate = 0!
            Me.Guna2PictureBox2.Location = New System.Drawing.Point(311, -81)
            Me.Guna2PictureBox2.Name = "Guna2PictureBox2"
            Me.Guna2PictureBox2.Size = New System.Drawing.Size(366, 316)
            Me.Guna2PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
            Me.Guna2PictureBox2.TabIndex = 86
            Me.Guna2PictureBox2.TabStop = False
            '
            'TXT_Nombre
            '
            Me.TXT_Nombre.BorderRadius = 20
            Me.TXT_Nombre.Cursor = System.Windows.Forms.Cursors.IBeam
            Me.TXT_Nombre.DefaultText = ""
            Me.TXT_Nombre.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
            Me.TXT_Nombre.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
            Me.TXT_Nombre.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
            Me.TXT_Nombre.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
            Me.TXT_Nombre.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.TXT_Nombre.Font = New System.Drawing.Font("Segoe UI", 9.0!)
            Me.TXT_Nombre.ForeColor = System.Drawing.Color.Black
            Me.TXT_Nombre.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.TXT_Nombre.Location = New System.Drawing.Point(616, 309)
            Me.TXT_Nombre.Name = "TXT_Nombre"
            Me.TXT_Nombre.PlaceholderText = ""
            Me.TXT_Nombre.ReadOnly = True
            Me.TXT_Nombre.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal
            Me.TXT_Nombre.SelectedText = ""
            Me.TXT_Nombre.Size = New System.Drawing.Size(329, 42)
            Me.TXT_Nombre.TabIndex = 94
            '
            'Label2
            '
            Me.Label2.AutoSize = True
            Me.Label2.Font = New System.Drawing.Font("Britannic Bold", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label2.ForeColor = System.Drawing.Color.White
            Me.Label2.Location = New System.Drawing.Point(523, 319)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New System.Drawing.Size(87, 23)
            Me.Label2.TabIndex = 95
            Me.Label2.Text = "Nombre:"
            '
            'Label4
            '
            Me.Label4.AutoSize = True
            Me.Label4.Font = New System.Drawing.Font("Britannic Bold", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label4.ForeColor = System.Drawing.Color.White
            Me.Label4.Location = New System.Drawing.Point(536, 389)
            Me.Label4.Name = "Label4"
            Me.Label4.Size = New System.Drawing.Size(75, 23)
            Me.Label4.TabIndex = 100
            Me.Label4.Text = "Precio:"
            '
            'TXT_Precio
            '
            Me.TXT_Precio.BorderRadius = 20
            Me.TXT_Precio.Cursor = System.Windows.Forms.Cursors.IBeam
            Me.TXT_Precio.DefaultText = ""
            Me.TXT_Precio.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
            Me.TXT_Precio.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
            Me.TXT_Precio.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
            Me.TXT_Precio.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
            Me.TXT_Precio.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.TXT_Precio.Font = New System.Drawing.Font("Segoe UI", 9.0!)
            Me.TXT_Precio.ForeColor = System.Drawing.Color.Black
            Me.TXT_Precio.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.TXT_Precio.Location = New System.Drawing.Point(616, 379)
            Me.TXT_Precio.Name = "TXT_Precio"
            Me.TXT_Precio.PlaceholderText = ""
            Me.TXT_Precio.ReadOnly = True
            Me.TXT_Precio.SelectedText = ""
            Me.TXT_Precio.Size = New System.Drawing.Size(210, 42)
            Me.TXT_Precio.TabIndex = 99
            '
            'Guna2TextBox1
            '
            Me.Guna2TextBox1.BorderRadius = 20
            Me.Guna2TextBox1.Cursor = System.Windows.Forms.Cursors.IBeam
            Me.Guna2TextBox1.DefaultText = "0"
            Me.Guna2TextBox1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
            Me.Guna2TextBox1.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
            Me.Guna2TextBox1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
            Me.Guna2TextBox1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
            Me.Guna2TextBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.Guna2TextBox1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
            Me.Guna2TextBox1.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.Guna2TextBox1.Location = New System.Drawing.Point(1142, 902)
            Me.Guna2TextBox1.Margin = New System.Windows.Forms.Padding(6)
            Me.Guna2TextBox1.Name = "Guna2TextBox1"
            Me.Guna2TextBox1.PlaceholderText = ""
            Me.Guna2TextBox1.ReadOnly = True
            Me.Guna2TextBox1.SelectedText = ""
            Me.Guna2TextBox1.Size = New System.Drawing.Size(390, 84)
            Me.Guna2TextBox1.TabIndex = 102
            '
            'DGV_BProd
            '
            Me.DGV_BProd.AllowUserToAddRows = False
            Me.DGV_BProd.AllowUserToDeleteRows = False
            Me.DGV_BProd.AllowUserToResizeRows = False
            DataGridViewCellStyle17.BackColor = System.Drawing.Color.White
            DataGridViewCellStyle17.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle17.ForeColor = System.Drawing.SystemColors.ControlText
            DataGridViewCellStyle17.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
            DataGridViewCellStyle17.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
            Me.DGV_BProd.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle17
            DataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle18.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
            DataGridViewCellStyle18.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle18.ForeColor = System.Drawing.Color.White
            DataGridViewCellStyle18.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
            DataGridViewCellStyle18.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
            Me.DGV_BProd.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle18
            Me.DGV_BProd.ColumnHeadersHeight = 20
            DataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle19.BackColor = System.Drawing.Color.White
            DataGridViewCellStyle19.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle19.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
            DataGridViewCellStyle19.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
            DataGridViewCellStyle19.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
            DataGridViewCellStyle19.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
            Me.DGV_BProd.DefaultCellStyle = DataGridViewCellStyle19
            Me.DGV_BProd.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.DGV_BProd.Location = New System.Drawing.Point(23, 210)
            Me.DGV_BProd.MultiSelect = False
            Me.DGV_BProd.Name = "DGV_BProd"
            Me.DGV_BProd.ReadOnly = True
            Me.DGV_BProd.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
            DataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle20.BackColor = System.Drawing.Color.White
            DataGridViewCellStyle20.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle20.ForeColor = System.Drawing.SystemColors.WindowText
            DataGridViewCellStyle20.SelectionBackColor = System.Drawing.Color.White
            DataGridViewCellStyle20.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle20.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
            Me.DGV_BProd.RowHeadersDefaultCellStyle = DataGridViewCellStyle20
            Me.DGV_BProd.RowHeadersVisible = False
            Me.DGV_BProd.Size = New System.Drawing.Size(493, 314)
            Me.DGV_BProd.TabIndex = 106
            Me.DGV_BProd.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
            Me.DGV_BProd.ThemeStyle.AlternatingRowsStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.DGV_BProd.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.SystemColors.ControlText
            Me.DGV_BProd.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.DGV_BProd.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
            Me.DGV_BProd.ThemeStyle.BackColor = System.Drawing.Color.White
            Me.DGV_BProd.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.DGV_BProd.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.DGV_BProd.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
            Me.DGV_BProd.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.DGV_BProd.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
            Me.DGV_BProd.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
            Me.DGV_BProd.ThemeStyle.HeaderStyle.Height = 20
            Me.DGV_BProd.ThemeStyle.ReadOnly = True
            Me.DGV_BProd.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
            Me.DGV_BProd.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
            Me.DGV_BProd.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.DGV_BProd.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
            Me.DGV_BProd.ThemeStyle.RowsStyle.Height = 22
            Me.DGV_BProd.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.DGV_BProd.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
            '
            'Guna2Panel1
            '
            Me.Guna2Panel1.Controls.Add(Me.BTN_RegresarPrd)
            Me.Guna2Panel1.Controls.Add(Me.BTN_SelectProd)
            Me.Guna2Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.Guna2Panel1.Location = New System.Drawing.Point(0, 546)
            Me.Guna2Panel1.Name = "Guna2Panel1"
            Me.Guna2Panel1.Size = New System.Drawing.Size(962, 68)
            Me.Guna2Panel1.TabIndex = 107
            '
            'TXT_CantProd
            '
            Me.TXT_CantProd.BorderRadius = 20
            Me.TXT_CantProd.Cursor = System.Windows.Forms.Cursors.IBeam
            Me.TXT_CantProd.DefaultText = "1"
            Me.TXT_CantProd.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
            Me.TXT_CantProd.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
            Me.TXT_CantProd.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
            Me.TXT_CantProd.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
            Me.TXT_CantProd.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.TXT_CantProd.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.TXT_CantProd.ForeColor = System.Drawing.Color.Black
            Me.TXT_CantProd.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.TXT_CantProd.Location = New System.Drawing.Point(634, 466)
            Me.TXT_CantProd.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
            Me.TXT_CantProd.Name = "TXT_CantProd"
            Me.TXT_CantProd.PlaceholderText = ""
            Me.TXT_CantProd.SelectedText = ""
            Me.TXT_CantProd.Size = New System.Drawing.Size(208, 42)
            Me.TXT_CantProd.TabIndex = 107
            Me.TXT_CantProd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
            '
            'Label3
            '
            Me.Label3.AutoSize = True
            Me.Label3.Font = New System.Drawing.Font("Britannic Bold", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label3.ForeColor = System.Drawing.Color.White
            Me.Label3.Location = New System.Drawing.Point(689, 437)
            Me.Label3.Name = "Label3"
            Me.Label3.Size = New System.Drawing.Size(92, 23)
            Me.Label3.TabIndex = 106
            Me.Label3.Text = "Cantidad"
            '
            'BTN_MenosCant
            '
            Me.BTN_MenosCant.DialogResult = System.Windows.Forms.DialogResult.Cancel
            Me.BTN_MenosCant.DisabledState.BorderColor = System.Drawing.Color.DarkGray
            Me.BTN_MenosCant.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
            Me.BTN_MenosCant.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
            Me.BTN_MenosCant.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
            Me.BTN_MenosCant.FillColor = System.Drawing.Color.Transparent
            Me.BTN_MenosCant.Font = New System.Drawing.Font("Segoe UI", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.BTN_MenosCant.ForeColor = System.Drawing.Color.Transparent
            Me.BTN_MenosCant.Image = Global.SistemaFacturaciónCommon.My.Resources.Resources.ICO_MinusCol
            Me.BTN_MenosCant.ImageSize = New System.Drawing.Size(50, 50)
            Me.BTN_MenosCant.Location = New System.Drawing.Point(575, 463)
            Me.BTN_MenosCant.Name = "BTN_MenosCant"
            Me.BTN_MenosCant.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
            Me.BTN_MenosCant.Size = New System.Drawing.Size(50, 50)
            Me.BTN_MenosCant.TabIndex = 108
            Me.BTN_MenosCant.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
            Me.BTN_MenosCant.TextOffset = New System.Drawing.Point(0, -5)
            '
            'BTN_MasCant
            '
            Me.BTN_MasCant.BackgroundImage = CType(resources.GetObject("BTN_MasCant.BackgroundImage"), System.Drawing.Image)
            Me.BTN_MasCant.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
            Me.BTN_MasCant.DialogResult = System.Windows.Forms.DialogResult.Cancel
            Me.BTN_MasCant.DisabledState.BorderColor = System.Drawing.Color.DarkGray
            Me.BTN_MasCant.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
            Me.BTN_MasCant.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
            Me.BTN_MasCant.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
            Me.BTN_MasCant.FillColor = System.Drawing.Color.Transparent
            Me.BTN_MasCant.Font = New System.Drawing.Font("Segoe UI", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.BTN_MasCant.ForeColor = System.Drawing.Color.White
            Me.BTN_MasCant.Image = Global.SistemaFacturaciónCommon.My.Resources.Resources.ICO_MasCol
            Me.BTN_MasCant.ImageSize = New System.Drawing.Size(50, 50)
            Me.BTN_MasCant.Location = New System.Drawing.Point(851, 463)
            Me.BTN_MasCant.Name = "BTN_MasCant"
            Me.BTN_MasCant.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
            Me.BTN_MasCant.Size = New System.Drawing.Size(50, 50)
            Me.BTN_MasCant.TabIndex = 109
            Me.BTN_MasCant.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
            Me.BTN_MasCant.TextOffset = New System.Drawing.Point(-6, -5)
            '
            'GBX_Filter
            '
            Me.GBX_Filter.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.GBX_Filter.BorderRadius = 10
            Me.GBX_Filter.Controls.Add(Me.RDB_All)
            Me.GBX_Filter.Controls.Add(Me.RDB_200)
            Me.GBX_Filter.Controls.Add(Me.RDB_100)
            Me.GBX_Filter.Controls.Add(Me.RDB_500)
            Me.GBX_Filter.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.GBX_Filter.CustomBorderThickness = New System.Windows.Forms.Padding(0, 20, 0, 0)
            Me.GBX_Filter.FillColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer))
            Me.GBX_Filter.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.GBX_Filter.ForeColor = System.Drawing.Color.White
            Me.GBX_Filter.Location = New System.Drawing.Point(745, 152)
            Me.GBX_Filter.Name = "GBX_Filter"
            Me.GBX_Filter.Size = New System.Drawing.Size(199, 74)
            Me.GBX_Filter.TabIndex = 128
            Me.GBX_Filter.Text = "Filtro"
            Me.GBX_Filter.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
            Me.GBX_Filter.TextOffset = New System.Drawing.Point(0, -10)
            '
            'RDB_All
            '
            Me.RDB_All.AutoSize = True
            Me.RDB_All.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.RDB_All.CheckedState.BorderThickness = 0
            Me.RDB_All.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.RDB_All.CheckedState.InnerColor = System.Drawing.Color.White
            Me.RDB_All.CheckedState.InnerOffset = -4
            Me.RDB_All.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
            Me.RDB_All.ForeColor = System.Drawing.SystemColors.Control
            Me.RDB_All.Location = New System.Drawing.Point(101, 45)
            Me.RDB_All.Name = "RDB_All"
            Me.RDB_All.Size = New System.Drawing.Size(55, 17)
            Me.RDB_All.TabIndex = 90
            Me.RDB_All.Text = "Todos"
            Me.RDB_All.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
            Me.RDB_All.UncheckedState.BorderThickness = 2
            Me.RDB_All.UncheckedState.FillColor = System.Drawing.Color.Transparent
            Me.RDB_All.UncheckedState.InnerColor = System.Drawing.Color.Transparent
            '
            'RDB_200
            '
            Me.RDB_200.AutoSize = True
            Me.RDB_200.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.RDB_200.CheckedState.BorderThickness = 0
            Me.RDB_200.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.RDB_200.CheckedState.InnerColor = System.Drawing.Color.White
            Me.RDB_200.CheckedState.InnerOffset = -4
            Me.RDB_200.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
            Me.RDB_200.ForeColor = System.Drawing.SystemColors.Control
            Me.RDB_200.Location = New System.Drawing.Point(101, 25)
            Me.RDB_200.Name = "RDB_200"
            Me.RDB_200.Size = New System.Drawing.Size(94, 17)
            Me.RDB_200.TabIndex = 89
            Me.RDB_200.Text = "200 Productos"
            Me.RDB_200.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
            Me.RDB_200.UncheckedState.BorderThickness = 2
            Me.RDB_200.UncheckedState.FillColor = System.Drawing.Color.Transparent
            Me.RDB_200.UncheckedState.InnerColor = System.Drawing.Color.Transparent
            '
            'RDB_100
            '
            Me.RDB_100.AutoSize = True
            Me.RDB_100.Checked = True
            Me.RDB_100.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.RDB_100.CheckedState.BorderThickness = 0
            Me.RDB_100.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.RDB_100.CheckedState.InnerColor = System.Drawing.Color.White
            Me.RDB_100.CheckedState.InnerOffset = -4
            Me.RDB_100.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
            Me.RDB_100.ForeColor = System.Drawing.SystemColors.Control
            Me.RDB_100.Location = New System.Drawing.Point(7, 25)
            Me.RDB_100.Name = "RDB_100"
            Me.RDB_100.Size = New System.Drawing.Size(94, 17)
            Me.RDB_100.TabIndex = 88
            Me.RDB_100.TabStop = True
            Me.RDB_100.Text = "100 Productos"
            Me.RDB_100.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
            Me.RDB_100.UncheckedState.BorderThickness = 2
            Me.RDB_100.UncheckedState.FillColor = System.Drawing.Color.Transparent
            Me.RDB_100.UncheckedState.InnerColor = System.Drawing.Color.Transparent
            '
            'RDB_500
            '
            Me.RDB_500.AutoSize = True
            Me.RDB_500.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.RDB_500.CheckedState.BorderThickness = 0
            Me.RDB_500.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.RDB_500.CheckedState.InnerColor = System.Drawing.Color.White
            Me.RDB_500.CheckedState.InnerOffset = -4
            Me.RDB_500.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
            Me.RDB_500.ForeColor = System.Drawing.SystemColors.Control
            Me.RDB_500.Location = New System.Drawing.Point(7, 45)
            Me.RDB_500.Name = "RDB_500"
            Me.RDB_500.Size = New System.Drawing.Size(94, 17)
            Me.RDB_500.TabIndex = 87
            Me.RDB_500.Text = "500 Productos"
            Me.RDB_500.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
            Me.RDB_500.UncheckedState.BorderThickness = 2
            Me.RDB_500.UncheckedState.FillColor = System.Drawing.Color.Transparent
            Me.RDB_500.UncheckedState.InnerColor = System.Drawing.Color.Transparent
            '
            'B_Producto
            '
            Me.AcceptButton = Me.BTN_SelectProd
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer))
            Me.CancelButton = Me.BTN_RegresarPrd
            Me.ClientSize = New System.Drawing.Size(962, 614)
            Me.Controls.Add(Me.GBX_Filter)
            Me.Controls.Add(Me.TXT_CantProd)
            Me.Controls.Add(Me.Guna2Panel1)
            Me.Controls.Add(Me.Label3)
            Me.Controls.Add(Me.BTN_MenosCant)
            Me.Controls.Add(Me.DGV_BProd)
            Me.Controls.Add(Me.BTN_MasCant)
            Me.Controls.Add(Me.Guna2TextBox1)
            Me.Controls.Add(Me.Label4)
            Me.Controls.Add(Me.TXT_Precio)
            Me.Controls.Add(Me.LBL_IDProd)
            Me.Controls.Add(Me.Label2)
            Me.Controls.Add(Me.TXT_Nombre)
            Me.Controls.Add(Me.Label1)
            Me.Controls.Add(Me.TXT_codigo)
            Me.Controls.Add(Me.TXT_BuscarProd)
            Me.Controls.Add(Me.Guna2PictureBox2)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.KeyPreview = True
            Me.Name = "B_Producto"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "Buscar Productos"
            CType(Me.Guna2PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.DGV_BProd, System.ComponentModel.ISupportInitialize).EndInit()
            Me.Guna2Panel1.ResumeLayout(False)
            Me.GBX_Filter.ResumeLayout(False)
            Me.GBX_Filter.PerformLayout()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub

        Friend WithEvents Guna2BorderlessForm1 As Guna.UI2.WinForms.Guna2BorderlessForm
        Friend WithEvents LBL_IDProd As Label
        Friend WithEvents Label1 As Label
        Friend WithEvents TXT_codigo As Guna.UI2.WinForms.Guna2TextBox
        Friend WithEvents BTN_RegresarPrd As Guna.UI2.WinForms.Guna2Button
        Friend WithEvents BTN_SelectProd As Guna.UI2.WinForms.Guna2Button
        Friend WithEvents TXT_BuscarProd As Guna.UI2.WinForms.Guna2TextBox
        Friend WithEvents Guna2PictureBox2 As Guna.UI2.WinForms.Guna2PictureBox
        Friend WithEvents Label4 As Label
        Friend WithEvents TXT_Precio As Guna.UI2.WinForms.Guna2TextBox
        Friend WithEvents Label2 As Label
        Friend WithEvents TXT_Nombre As Guna.UI2.WinForms.Guna2TextBox
        Friend WithEvents Guna2TextBox1 As Guna.UI2.WinForms.Guna2TextBox
        Friend WithEvents DGV_BProd As Guna.UI2.WinForms.Guna2DataGridView
        Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
        Friend WithEvents TXT_CantProd As Guna.UI2.WinForms.Guna2TextBox
        Friend WithEvents Label3 As Label
        Friend WithEvents BTN_MenosCant As Guna.UI2.WinForms.Guna2CircleButton
        Friend WithEvents BTN_MasCant As Guna.UI2.WinForms.Guna2CircleButton
        Friend WithEvents GBX_Filter As Guna.UI2.WinForms.Guna2GroupBox
        Friend WithEvents RDB_All As Guna.UI2.WinForms.Guna2RadioButton
        Friend WithEvents RDB_200 As Guna.UI2.WinForms.Guna2RadioButton
        Friend WithEvents RDB_100 As Guna.UI2.WinForms.Guna2RadioButton
        Friend WithEvents RDB_500 As Guna.UI2.WinForms.Guna2RadioButton
    End Class
End Namespace
