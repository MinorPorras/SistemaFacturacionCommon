<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class M_Mantenimiento
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(M_Mantenimiento))
        Me.Guna2BorderlessForm1 = New Guna.UI2.WinForms.Guna2BorderlessForm(Me.components)
        Me.Guna2PictureBox1 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.BTN_Sucursal = New Guna.UI2.WinForms.Guna2Button()
        Me.BTN_Usuario = New Guna.UI2.WinForms.Guna2Button()
        Me.BTN_Proveedor = New Guna.UI2.WinForms.Guna2Button()
        Me.BTN_Cliente = New Guna.UI2.WinForms.Guna2Button()
        Me.BTN_Categoria = New Guna.UI2.WinForms.Guna2Button()
        Me.BTN_Impuesto = New Guna.UI2.WinForms.Guna2Button()
        Me.BTN_Producto = New Guna.UI2.WinForms.Guna2Button()
        Me.BTN_Marca = New Guna.UI2.WinForms.Guna2Button()
        Me.BTN_RegresarMant = New Guna.UI2.WinForms.Guna2Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2Panel2 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Guna2Panel3 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2Panel4 = New Guna.UI2.WinForms.Guna2Panel()
        Me.BTN_LogOut = New Guna.UI2.WinForms.Guna2ImageButton()
        Me.BTN_Config = New Guna.UI2.WinForms.Guna2ImageButton()
        Me.BTN_CerrarApp = New Guna.UI2.WinForms.Guna2ImageButton()
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Guna2Panel1.SuspendLayout()
        Me.Guna2Panel2.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Guna2Panel3.SuspendLayout()
        Me.Guna2Panel4.SuspendLayout()
        Me.SuspendLayout()
        '
        'Guna2BorderlessForm1
        '
        Me.Guna2BorderlessForm1.BorderRadius = 25
        Me.Guna2BorderlessForm1.ContainerControl = Me
        Me.Guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6R
        Me.Guna2BorderlessForm1.TransparentWhileDrag = True
        '
        'Guna2PictureBox1
        '
        Me.Guna2PictureBox1.Image = CType(resources.GetObject("Guna2PictureBox1.Image"), System.Drawing.Image)
        Me.Guna2PictureBox1.ImageRotate = 0!
        Me.Guna2PictureBox1.Location = New System.Drawing.Point(136, -122)
        Me.Guna2PictureBox1.Name = "Guna2PictureBox1"
        Me.Guna2PictureBox1.Size = New System.Drawing.Size(539, 442)
        Me.Guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Guna2PictureBox1.TabIndex = 1
        Me.Guna2PictureBox1.TabStop = False
        '
        'BTN_Sucursal
        '
        Me.BTN_Sucursal.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BTN_Sucursal.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BTN_Sucursal.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BTN_Sucursal.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BTN_Sucursal.Dock = System.Windows.Forms.DockStyle.Left
        Me.BTN_Sucursal.FillColor = System.Drawing.Color.YellowGreen
        Me.BTN_Sucursal.Font = New System.Drawing.Font("Ebrima", 20.25!, System.Drawing.FontStyle.Bold)
        Me.BTN_Sucursal.ForeColor = System.Drawing.Color.White
        Me.BTN_Sucursal.Image = CType(resources.GetObject("BTN_Sucursal.Image"), System.Drawing.Image)
        Me.BTN_Sucursal.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.BTN_Sucursal.ImageSize = New System.Drawing.Size(60, 60)
        Me.BTN_Sucursal.Location = New System.Drawing.Point(0, 0)
        Me.BTN_Sucursal.Name = "BTN_Sucursal"
        Me.BTN_Sucursal.Size = New System.Drawing.Size(411, 60)
        Me.BTN_Sucursal.TabIndex = 11
        Me.BTN_Sucursal.Text = "1. Sucursales"
        '
        'BTN_Usuario
        '
        Me.BTN_Usuario.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BTN_Usuario.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BTN_Usuario.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BTN_Usuario.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BTN_Usuario.Dock = System.Windows.Forms.DockStyle.Right
        Me.BTN_Usuario.FillColor = System.Drawing.Color.RoyalBlue
        Me.BTN_Usuario.Font = New System.Drawing.Font("Ebrima", 20.25!, System.Drawing.FontStyle.Bold)
        Me.BTN_Usuario.ForeColor = System.Drawing.Color.White
        Me.BTN_Usuario.Image = CType(resources.GetObject("BTN_Usuario.Image"), System.Drawing.Image)
        Me.BTN_Usuario.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.BTN_Usuario.ImageSize = New System.Drawing.Size(60, 60)
        Me.BTN_Usuario.Location = New System.Drawing.Point(411, 0)
        Me.BTN_Usuario.Name = "BTN_Usuario"
        Me.BTN_Usuario.Size = New System.Drawing.Size(412, 60)
        Me.BTN_Usuario.TabIndex = 12
        Me.BTN_Usuario.Text = "2. Cajeros"
        '
        'BTN_Proveedor
        '
        Me.BTN_Proveedor.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BTN_Proveedor.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BTN_Proveedor.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BTN_Proveedor.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BTN_Proveedor.Dock = System.Windows.Forms.DockStyle.Right
        Me.BTN_Proveedor.FillColor = System.Drawing.Color.Teal
        Me.BTN_Proveedor.Font = New System.Drawing.Font("Ebrima", 20.25!, System.Drawing.FontStyle.Bold)
        Me.BTN_Proveedor.ForeColor = System.Drawing.Color.White
        Me.BTN_Proveedor.Image = CType(resources.GetObject("BTN_Proveedor.Image"), System.Drawing.Image)
        Me.BTN_Proveedor.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.BTN_Proveedor.ImageSize = New System.Drawing.Size(70, 70)
        Me.BTN_Proveedor.Location = New System.Drawing.Point(411, 0)
        Me.BTN_Proveedor.Name = "BTN_Proveedor"
        Me.BTN_Proveedor.Size = New System.Drawing.Size(412, 60)
        Me.BTN_Proveedor.TabIndex = 14
        Me.BTN_Proveedor.Text = "4. Proveedores"
        '
        'BTN_Cliente
        '
        Me.BTN_Cliente.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BTN_Cliente.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BTN_Cliente.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BTN_Cliente.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BTN_Cliente.Dock = System.Windows.Forms.DockStyle.Left
        Me.BTN_Cliente.FillColor = System.Drawing.Color.CornflowerBlue
        Me.BTN_Cliente.Font = New System.Drawing.Font("Ebrima", 20.25!, System.Drawing.FontStyle.Bold)
        Me.BTN_Cliente.ForeColor = System.Drawing.Color.White
        Me.BTN_Cliente.Image = CType(resources.GetObject("BTN_Cliente.Image"), System.Drawing.Image)
        Me.BTN_Cliente.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.BTN_Cliente.ImageSize = New System.Drawing.Size(60, 60)
        Me.BTN_Cliente.Location = New System.Drawing.Point(0, 0)
        Me.BTN_Cliente.Name = "BTN_Cliente"
        Me.BTN_Cliente.Size = New System.Drawing.Size(411, 60)
        Me.BTN_Cliente.TabIndex = 13
        Me.BTN_Cliente.Text = "3. Clientes"
        '
        'BTN_Categoria
        '
        Me.BTN_Categoria.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BTN_Categoria.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BTN_Categoria.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BTN_Categoria.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BTN_Categoria.Dock = System.Windows.Forms.DockStyle.Right
        Me.BTN_Categoria.FillColor = System.Drawing.Color.Goldenrod
        Me.BTN_Categoria.Font = New System.Drawing.Font("Ebrima", 20.25!, System.Drawing.FontStyle.Bold)
        Me.BTN_Categoria.ForeColor = System.Drawing.Color.White
        Me.BTN_Categoria.Image = CType(resources.GetObject("BTN_Categoria.Image"), System.Drawing.Image)
        Me.BTN_Categoria.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.BTN_Categoria.ImageSize = New System.Drawing.Size(60, 60)
        Me.BTN_Categoria.Location = New System.Drawing.Point(411, 0)
        Me.BTN_Categoria.Name = "BTN_Categoria"
        Me.BTN_Categoria.Size = New System.Drawing.Size(412, 60)
        Me.BTN_Categoria.TabIndex = 16
        Me.BTN_Categoria.Text = "6. Categoría"
        '
        'BTN_Impuesto
        '
        Me.BTN_Impuesto.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BTN_Impuesto.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BTN_Impuesto.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BTN_Impuesto.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BTN_Impuesto.Dock = System.Windows.Forms.DockStyle.Left
        Me.BTN_Impuesto.FillColor = System.Drawing.Color.MediumSlateBlue
        Me.BTN_Impuesto.Font = New System.Drawing.Font("Ebrima", 20.25!, System.Drawing.FontStyle.Bold)
        Me.BTN_Impuesto.ForeColor = System.Drawing.Color.White
        Me.BTN_Impuesto.Image = CType(resources.GetObject("BTN_Impuesto.Image"), System.Drawing.Image)
        Me.BTN_Impuesto.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.BTN_Impuesto.ImageSize = New System.Drawing.Size(70, 70)
        Me.BTN_Impuesto.Location = New System.Drawing.Point(0, 0)
        Me.BTN_Impuesto.Name = "BTN_Impuesto"
        Me.BTN_Impuesto.Size = New System.Drawing.Size(411, 60)
        Me.BTN_Impuesto.TabIndex = 15
        Me.BTN_Impuesto.Text = "5. Impuestos"
        '
        'BTN_Producto
        '
        Me.BTN_Producto.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BTN_Producto.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BTN_Producto.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BTN_Producto.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BTN_Producto.Dock = System.Windows.Forms.DockStyle.Right
        Me.BTN_Producto.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BTN_Producto.Font = New System.Drawing.Font("Ebrima", 20.25!, System.Drawing.FontStyle.Bold)
        Me.BTN_Producto.ForeColor = System.Drawing.Color.White
        Me.BTN_Producto.Image = CType(resources.GetObject("BTN_Producto.Image"), System.Drawing.Image)
        Me.BTN_Producto.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.BTN_Producto.ImageSize = New System.Drawing.Size(60, 60)
        Me.BTN_Producto.Location = New System.Drawing.Point(411, 0)
        Me.BTN_Producto.Name = "BTN_Producto"
        Me.BTN_Producto.Size = New System.Drawing.Size(412, 65)
        Me.BTN_Producto.TabIndex = 18
        Me.BTN_Producto.Text = "8. Productos"
        '
        'BTN_Marca
        '
        Me.BTN_Marca.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BTN_Marca.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BTN_Marca.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BTN_Marca.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BTN_Marca.Dock = System.Windows.Forms.DockStyle.Left
        Me.BTN_Marca.FillColor = System.Drawing.Color.DarkOrchid
        Me.BTN_Marca.Font = New System.Drawing.Font("Ebrima", 20.25!, System.Drawing.FontStyle.Bold)
        Me.BTN_Marca.ForeColor = System.Drawing.Color.White
        Me.BTN_Marca.Image = CType(resources.GetObject("BTN_Marca.Image"), System.Drawing.Image)
        Me.BTN_Marca.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.BTN_Marca.ImageSize = New System.Drawing.Size(60, 60)
        Me.BTN_Marca.Location = New System.Drawing.Point(0, 0)
        Me.BTN_Marca.Name = "BTN_Marca"
        Me.BTN_Marca.Size = New System.Drawing.Size(411, 65)
        Me.BTN_Marca.TabIndex = 17
        Me.BTN_Marca.Text = "7. Marcas"
        '
        'BTN_RegresarMant
        '
        Me.BTN_RegresarMant.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.BTN_RegresarMant.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BTN_RegresarMant.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BTN_RegresarMant.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BTN_RegresarMant.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BTN_RegresarMant.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.BTN_RegresarMant.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BTN_RegresarMant.Font = New System.Drawing.Font("Ebrima", 20.25!, System.Drawing.FontStyle.Bold)
        Me.BTN_RegresarMant.ForeColor = System.Drawing.Color.White
        Me.BTN_RegresarMant.Image = CType(resources.GetObject("BTN_RegresarMant.Image"), System.Drawing.Image)
        Me.BTN_RegresarMant.ImageSize = New System.Drawing.Size(60, 60)
        Me.BTN_RegresarMant.Location = New System.Drawing.Point(0, 18)
        Me.BTN_RegresarMant.Name = "BTN_RegresarMant"
        Me.BTN_RegresarMant.Size = New System.Drawing.Size(823, 72)
        Me.BTN_RegresarMant.TabIndex = 20
        Me.BTN_RegresarMant.Text = "0. Regresar"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.BTN_RegresarMant)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 580)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(15)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Padding = New System.Windows.Forms.Padding(0, 15, 0, 0)
        Me.Panel1.Size = New System.Drawing.Size(823, 90)
        Me.Panel1.TabIndex = 121
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.Controls.Add(Me.BTN_Marca)
        Me.Guna2Panel1.Controls.Add(Me.BTN_Producto)
        Me.Guna2Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Guna2Panel1.Location = New System.Drawing.Point(0, 500)
        Me.Guna2Panel1.Margin = New System.Windows.Forms.Padding(3, 3, 3, 15)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.Padding = New System.Windows.Forms.Padding(0, 0, 0, 15)
        Me.Guna2Panel1.Size = New System.Drawing.Size(823, 80)
        Me.Guna2Panel1.TabIndex = 122
        '
        'Guna2Panel2
        '
        Me.Guna2Panel2.Controls.Add(Me.BTN_Categoria)
        Me.Guna2Panel2.Controls.Add(Me.BTN_Impuesto)
        Me.Guna2Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Guna2Panel2.Location = New System.Drawing.Point(0, 410)
        Me.Guna2Panel2.Margin = New System.Windows.Forms.Padding(3, 3, 3, 15)
        Me.Guna2Panel2.Name = "Guna2Panel2"
        Me.Guna2Panel2.Padding = New System.Windows.Forms.Padding(0, 0, 0, 30)
        Me.Guna2Panel2.Size = New System.Drawing.Size(823, 90)
        Me.Guna2Panel2.TabIndex = 123
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.BTN_Proveedor)
        Me.Panel2.Controls.Add(Me.BTN_Cliente)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 320)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(3, 3, 3, 15)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Padding = New System.Windows.Forms.Padding(0, 0, 0, 30)
        Me.Panel2.Size = New System.Drawing.Size(823, 90)
        Me.Panel2.TabIndex = 124
        '
        'Guna2Panel3
        '
        Me.Guna2Panel3.Controls.Add(Me.BTN_Usuario)
        Me.Guna2Panel3.Controls.Add(Me.BTN_Sucursal)
        Me.Guna2Panel3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Guna2Panel3.Location = New System.Drawing.Point(0, 230)
        Me.Guna2Panel3.Margin = New System.Windows.Forms.Padding(3, 3, 3, 15)
        Me.Guna2Panel3.Name = "Guna2Panel3"
        Me.Guna2Panel3.Padding = New System.Windows.Forms.Padding(0, 0, 0, 30)
        Me.Guna2Panel3.Size = New System.Drawing.Size(823, 90)
        Me.Guna2Panel3.TabIndex = 125
        '
        'Guna2Panel4
        '
        Me.Guna2Panel4.Controls.Add(Me.BTN_LogOut)
        Me.Guna2Panel4.Controls.Add(Me.BTN_Config)
        Me.Guna2Panel4.Controls.Add(Me.BTN_CerrarApp)
        Me.Guna2Panel4.Location = New System.Drawing.Point(765, -3)
        Me.Guna2Panel4.Name = "Guna2Panel4"
        Me.Guna2Panel4.Size = New System.Drawing.Size(58, 166)
        Me.Guna2Panel4.TabIndex = 126
        '
        'BTN_LogOut
        '
        Me.BTN_LogOut.BackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(143, Byte), Integer))
        Me.BTN_LogOut.CheckedState.ImageSize = New System.Drawing.Size(64, 64)
        Me.BTN_LogOut.Dock = System.Windows.Forms.DockStyle.Top
        Me.BTN_LogOut.HoverState.ImageSize = New System.Drawing.Size(64, 64)
        Me.BTN_LogOut.Image = CType(resources.GetObject("BTN_LogOut.Image"), System.Drawing.Image)
        Me.BTN_LogOut.ImageOffset = New System.Drawing.Point(0, 0)
        Me.BTN_LogOut.ImageRotate = 0!
        Me.BTN_LogOut.ImageSize = New System.Drawing.Size(60, 60)
        Me.BTN_LogOut.Location = New System.Drawing.Point(0, 108)
        Me.BTN_LogOut.Name = "BTN_LogOut"
        Me.BTN_LogOut.PressedState.ImageSize = New System.Drawing.Size(64, 64)
        Me.BTN_LogOut.Size = New System.Drawing.Size(58, 54)
        Me.BTN_LogOut.TabIndex = 124
        '
        'BTN_Config
        '
        Me.BTN_Config.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.BTN_Config.CheckedState.ImageSize = New System.Drawing.Size(64, 64)
        Me.BTN_Config.Dock = System.Windows.Forms.DockStyle.Top
        Me.BTN_Config.HoverState.ImageSize = New System.Drawing.Size(64, 64)
        Me.BTN_Config.Image = CType(resources.GetObject("BTN_Config.Image"), System.Drawing.Image)
        Me.BTN_Config.ImageOffset = New System.Drawing.Point(0, 0)
        Me.BTN_Config.ImageRotate = 0!
        Me.BTN_Config.ImageSize = New System.Drawing.Size(60, 60)
        Me.BTN_Config.Location = New System.Drawing.Point(0, 54)
        Me.BTN_Config.Name = "BTN_Config"
        Me.BTN_Config.PressedState.ImageSize = New System.Drawing.Size(64, 64)
        Me.BTN_Config.Size = New System.Drawing.Size(58, 54)
        Me.BTN_Config.TabIndex = 123
        '
        'BTN_CerrarApp
        '
        Me.BTN_CerrarApp.BackColor = System.Drawing.Color.Red
        Me.BTN_CerrarApp.CheckedState.ImageSize = New System.Drawing.Size(64, 64)
        Me.BTN_CerrarApp.Dock = System.Windows.Forms.DockStyle.Top
        Me.BTN_CerrarApp.HoverState.ImageSize = New System.Drawing.Size(64, 64)
        Me.BTN_CerrarApp.Image = CType(resources.GetObject("BTN_CerrarApp.Image"), System.Drawing.Image)
        Me.BTN_CerrarApp.ImageOffset = New System.Drawing.Point(0, 0)
        Me.BTN_CerrarApp.ImageRotate = 0!
        Me.BTN_CerrarApp.ImageSize = New System.Drawing.Size(60, 60)
        Me.BTN_CerrarApp.Location = New System.Drawing.Point(0, 0)
        Me.BTN_CerrarApp.Name = "BTN_CerrarApp"
        Me.BTN_CerrarApp.PressedState.ImageSize = New System.Drawing.Size(64, 64)
        Me.BTN_CerrarApp.Size = New System.Drawing.Size(58, 54)
        Me.BTN_CerrarApp.TabIndex = 122
        '
        'M_Mantenimiento
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.CancelButton = Me.BTN_RegresarMant
        Me.ClientSize = New System.Drawing.Size(823, 670)
        Me.Controls.Add(Me.Guna2Panel4)
        Me.Controls.Add(Me.Guna2Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Guna2Panel2)
        Me.Controls.Add(Me.Guna2Panel1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Guna2PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Name = "M_Mantenimiento"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Mantenimiento"
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Guna2Panel1.ResumeLayout(False)
        Me.Guna2Panel2.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Guna2Panel3.ResumeLayout(False)
        Me.Guna2Panel4.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Guna2BorderlessForm1 As Guna.UI2.WinForms.Guna2BorderlessForm
    Friend WithEvents Guna2PictureBox1 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents BTN_Usuario As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BTN_Sucursal As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BTN_RegresarMant As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BTN_Producto As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BTN_Marca As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BTN_Categoria As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BTN_Impuesto As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BTN_Proveedor As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BTN_Cliente As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Guna2Panel3 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Guna2Panel2 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2Panel4 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents BTN_LogOut As Guna.UI2.WinForms.Guna2ImageButton
    Friend WithEvents BTN_Config As Guna.UI2.WinForms.Guna2ImageButton
    Friend WithEvents BTN_CerrarApp As Guna.UI2.WinForms.Guna2ImageButton
End Class
