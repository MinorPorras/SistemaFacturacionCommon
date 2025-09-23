Namespace SistemaFacturacion.Forms.Mantenimiento

    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Class M_MantenimientoMenu
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(M_MantenimientoMenu))
            Me.Guna2BorderlessForm1 = New Guna.UI2.WinForms.Guna2BorderlessForm(Me.components)
            Me.Guna2PictureBox1 = New Guna.UI2.WinForms.Guna2PictureBox()
            Me.BTN_Sucursal = New Guna.UI2.WinForms.Guna2Button()
            Me.BTN_Usuario = New Guna.UI2.WinForms.Guna2Button()
            Me.BTN_Proveedor = New Guna.UI2.WinForms.Guna2Button()
            Me.BTN_Cliente = New Guna.UI2.WinForms.Guna2Button()
            Me.BTN_Categoria = New Guna.UI2.WinForms.Guna2Button()
            Me.BTN_Impuesto = New Guna.UI2.WinForms.Guna2Button()
            Me.BTN_Conceptos = New Guna.UI2.WinForms.Guna2Button()
            Me.BTN_RegresarMant = New Guna.UI2.WinForms.Guna2Button()
            Me.Panel1 = New System.Windows.Forms.Panel()
            Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
            Me.BTN_LogOut = New Guna.UI2.WinForms.Guna2ImageButton()
            Me.BTN_Config = New Guna.UI2.WinForms.Guna2ImageButton()
            Me.BTN_CerrarApp = New Guna.UI2.WinForms.Guna2ImageButton()
            Me.BTN_Marca = New Guna.UI2.WinForms.Guna2Button()
            Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
            Me.BTN_Producto = New Guna.UI2.WinForms.Guna2Button()
            CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.Panel1.SuspendLayout()
            Me.TableLayoutPanel1.SuspendLayout()
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
            Me.Guna2PictureBox1.Location = New System.Drawing.Point(336, -96)
            Me.Guna2PictureBox1.Name = "Guna2PictureBox1"
            Me.Guna2PictureBox1.Size = New System.Drawing.Size(429, 382)
            Me.Guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
            Me.Guna2PictureBox1.TabIndex = 1
            Me.Guna2PictureBox1.TabStop = False
            '
            'BTN_Sucursal
            '
            Me.BTN_Sucursal.BorderRadius = 10
            Me.BTN_Sucursal.DisabledState.BorderColor = System.Drawing.Color.DarkGray
            Me.BTN_Sucursal.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
            Me.BTN_Sucursal.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
            Me.BTN_Sucursal.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
            Me.BTN_Sucursal.Dock = System.Windows.Forms.DockStyle.Top
            Me.BTN_Sucursal.FillColor = System.Drawing.Color.DarkSeaGreen
            Me.BTN_Sucursal.Font = New System.Drawing.Font("Ebrima", 20.25!, System.Drawing.FontStyle.Bold)
            Me.BTN_Sucursal.ForeColor = System.Drawing.Color.White
            Me.BTN_Sucursal.HoverState.FillColor = System.Drawing.Color.ForestGreen
            Me.BTN_Sucursal.Image = Global.SistemaFacturaciónCommon.My.Resources.Resources.ICO_Sucursal
            Me.BTN_Sucursal.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
            Me.BTN_Sucursal.ImageSize = New System.Drawing.Size(50, 50)
            Me.BTN_Sucursal.Location = New System.Drawing.Point(8, 8)
            Me.BTN_Sucursal.Name = "BTN_Sucursal"
            Me.BTN_Sucursal.Size = New System.Drawing.Size(530, 60)
            Me.BTN_Sucursal.TabIndex = 11
            Me.BTN_Sucursal.Text = "1. Sucursales"
            '
            'BTN_Usuario
            '
            Me.BTN_Usuario.BorderRadius = 10
            Me.BTN_Usuario.DisabledState.BorderColor = System.Drawing.Color.DarkGray
            Me.BTN_Usuario.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
            Me.BTN_Usuario.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
            Me.BTN_Usuario.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
            Me.BTN_Usuario.Dock = System.Windows.Forms.DockStyle.Top
            Me.BTN_Usuario.FillColor = System.Drawing.Color.SkyBlue
            Me.BTN_Usuario.Font = New System.Drawing.Font("Ebrima", 20.25!, System.Drawing.FontStyle.Bold)
            Me.BTN_Usuario.ForeColor = System.Drawing.Color.White
            Me.BTN_Usuario.HoverState.FillColor = System.Drawing.Color.DeepSkyBlue
            Me.BTN_Usuario.Image = Global.SistemaFacturaciónCommon.My.Resources.Resources.ICO_Usuario
            Me.BTN_Usuario.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
            Me.BTN_Usuario.ImageSize = New System.Drawing.Size(50, 50)
            Me.BTN_Usuario.Location = New System.Drawing.Point(544, 8)
            Me.BTN_Usuario.Name = "BTN_Usuario"
            Me.BTN_Usuario.Size = New System.Drawing.Size(531, 60)
            Me.BTN_Usuario.TabIndex = 12
            Me.BTN_Usuario.Text = "2. Usuarios"
            '
            'BTN_Proveedor
            '
            Me.BTN_Proveedor.BorderRadius = 10
            Me.BTN_Proveedor.DisabledState.BorderColor = System.Drawing.Color.DarkGray
            Me.BTN_Proveedor.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
            Me.BTN_Proveedor.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
            Me.BTN_Proveedor.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
            Me.BTN_Proveedor.Dock = System.Windows.Forms.DockStyle.Top
            Me.BTN_Proveedor.FillColor = System.Drawing.Color.CadetBlue
            Me.BTN_Proveedor.Font = New System.Drawing.Font("Ebrima", 20.25!, System.Drawing.FontStyle.Bold)
            Me.BTN_Proveedor.ForeColor = System.Drawing.Color.White
            Me.BTN_Proveedor.HoverState.FillColor = System.Drawing.Color.Teal
            Me.BTN_Proveedor.Image = Global.SistemaFacturaciónCommon.My.Resources.Resources.ICO_Proveedor
            Me.BTN_Proveedor.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
            Me.BTN_Proveedor.ImageSize = New System.Drawing.Size(50, 50)
            Me.BTN_Proveedor.Location = New System.Drawing.Point(544, 96)
            Me.BTN_Proveedor.Name = "BTN_Proveedor"
            Me.BTN_Proveedor.Size = New System.Drawing.Size(531, 60)
            Me.BTN_Proveedor.TabIndex = 14
            Me.BTN_Proveedor.Text = "4. Proveedores"
            '
            'BTN_Cliente
            '
            Me.BTN_Cliente.BorderRadius = 10
            Me.BTN_Cliente.DisabledState.BorderColor = System.Drawing.Color.DarkGray
            Me.BTN_Cliente.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
            Me.BTN_Cliente.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
            Me.BTN_Cliente.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
            Me.BTN_Cliente.Dock = System.Windows.Forms.DockStyle.Top
            Me.BTN_Cliente.FillColor = System.Drawing.Color.CornflowerBlue
            Me.BTN_Cliente.Font = New System.Drawing.Font("Ebrima", 20.25!, System.Drawing.FontStyle.Bold)
            Me.BTN_Cliente.ForeColor = System.Drawing.Color.White
            Me.BTN_Cliente.HoverState.FillColor = System.Drawing.Color.RoyalBlue
            Me.BTN_Cliente.Image = CType(resources.GetObject("BTN_Cliente.Image"), System.Drawing.Image)
            Me.BTN_Cliente.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
            Me.BTN_Cliente.ImageSize = New System.Drawing.Size(50, 50)
            Me.BTN_Cliente.Location = New System.Drawing.Point(8, 96)
            Me.BTN_Cliente.Name = "BTN_Cliente"
            Me.BTN_Cliente.Size = New System.Drawing.Size(530, 60)
            Me.BTN_Cliente.TabIndex = 13
            Me.BTN_Cliente.Text = "3. Clientes"
            '
            'BTN_Categoria
            '
            Me.BTN_Categoria.BorderRadius = 10
            Me.BTN_Categoria.DisabledState.BorderColor = System.Drawing.Color.DarkGray
            Me.BTN_Categoria.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
            Me.BTN_Categoria.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
            Me.BTN_Categoria.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
            Me.BTN_Categoria.Dock = System.Windows.Forms.DockStyle.Top
            Me.BTN_Categoria.FillColor = System.Drawing.Color.Goldenrod
            Me.BTN_Categoria.Font = New System.Drawing.Font("Ebrima", 20.25!, System.Drawing.FontStyle.Bold)
            Me.BTN_Categoria.ForeColor = System.Drawing.Color.White
            Me.BTN_Categoria.HoverState.FillColor = System.Drawing.Color.DarkGoldenrod
            Me.BTN_Categoria.Image = Global.SistemaFacturaciónCommon.My.Resources.Resources.ICO_Categoria
            Me.BTN_Categoria.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
            Me.BTN_Categoria.ImageSize = New System.Drawing.Size(50, 50)
            Me.BTN_Categoria.Location = New System.Drawing.Point(8, 272)
            Me.BTN_Categoria.Name = "BTN_Categoria"
            Me.BTN_Categoria.Size = New System.Drawing.Size(530, 60)
            Me.BTN_Categoria.TabIndex = 16
            Me.BTN_Categoria.Text = "7. Categoría"
            '
            'BTN_Impuesto
            '
            Me.BTN_Impuesto.BorderRadius = 10
            Me.BTN_Impuesto.DisabledState.BorderColor = System.Drawing.Color.DarkGray
            Me.BTN_Impuesto.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
            Me.BTN_Impuesto.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
            Me.BTN_Impuesto.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
            Me.BTN_Impuesto.Dock = System.Windows.Forms.DockStyle.Top
            Me.BTN_Impuesto.FillColor = System.Drawing.Color.MediumSlateBlue
            Me.BTN_Impuesto.Font = New System.Drawing.Font("Ebrima", 20.25!, System.Drawing.FontStyle.Bold)
            Me.BTN_Impuesto.ForeColor = System.Drawing.Color.White
            Me.BTN_Impuesto.HoverState.FillColor = System.Drawing.Color.DarkSlateBlue
            Me.BTN_Impuesto.Image = Global.SistemaFacturaciónCommon.My.Resources.Resources.ICO_Dolar
            Me.BTN_Impuesto.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
            Me.BTN_Impuesto.ImageSize = New System.Drawing.Size(50, 50)
            Me.BTN_Impuesto.Location = New System.Drawing.Point(8, 184)
            Me.BTN_Impuesto.Name = "BTN_Impuesto"
            Me.BTN_Impuesto.Size = New System.Drawing.Size(530, 60)
            Me.BTN_Impuesto.TabIndex = 15
            Me.BTN_Impuesto.Text = "5. Impuestos"
            '
            'BTN_Conceptos
            '
            Me.BTN_Conceptos.BorderRadius = 10
            Me.BTN_Conceptos.DisabledState.BorderColor = System.Drawing.Color.DarkGray
            Me.BTN_Conceptos.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
            Me.BTN_Conceptos.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
            Me.BTN_Conceptos.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
            Me.BTN_Conceptos.Dock = System.Windows.Forms.DockStyle.Top
            Me.BTN_Conceptos.FillColor = System.Drawing.Color.FromArgb(CType(CType(199, Byte), Integer), CType(CType(103, Byte), Integer), CType(CType(245, Byte), Integer))
            Me.BTN_Conceptos.Font = New System.Drawing.Font("Ebrima", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.BTN_Conceptos.ForeColor = System.Drawing.Color.White
            Me.BTN_Conceptos.HoverState.FillColor = System.Drawing.Color.Indigo
            Me.BTN_Conceptos.Image = Global.SistemaFacturaciónCommon.My.Resources.Resources.ICO_Marca
            Me.BTN_Conceptos.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
            Me.BTN_Conceptos.ImageSize = New System.Drawing.Size(50, 50)
            Me.BTN_Conceptos.Location = New System.Drawing.Point(544, 184)
            Me.BTN_Conceptos.Name = "BTN_Conceptos"
            Me.BTN_Conceptos.Size = New System.Drawing.Size(531, 60)
            Me.BTN_Conceptos.TabIndex = 17
            Me.BTN_Conceptos.Text = "6. Conceptos de movimientos caja"
            '
            'BTN_RegresarMant
            '
            Me.BTN_RegresarMant.DialogResult = System.Windows.Forms.DialogResult.Cancel
            Me.BTN_RegresarMant.DisabledState.BorderColor = System.Drawing.Color.DarkGray
            Me.BTN_RegresarMant.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
            Me.BTN_RegresarMant.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
            Me.BTN_RegresarMant.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
            Me.BTN_RegresarMant.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.BTN_RegresarMant.FillColor = System.Drawing.Color.LightCoral
            Me.BTN_RegresarMant.Font = New System.Drawing.Font("Ebrima", 20.25!, System.Drawing.FontStyle.Bold)
            Me.BTN_RegresarMant.ForeColor = System.Drawing.Color.White
            Me.BTN_RegresarMant.HoverState.FillColor = System.Drawing.Color.Firebrick
            Me.BTN_RegresarMant.Image = Global.SistemaFacturaciónCommon.My.Resources.Resources.ICO_Back
            Me.BTN_RegresarMant.ImageSize = New System.Drawing.Size(50, 50)
            Me.BTN_RegresarMant.Location = New System.Drawing.Point(0, 18)
            Me.BTN_RegresarMant.Name = "BTN_RegresarMant"
            Me.BTN_RegresarMant.Size = New System.Drawing.Size(1083, 72)
            Me.BTN_RegresarMant.TabIndex = 20
            Me.BTN_RegresarMant.Text = "0. Regresar"
            '
            'Panel1
            '
            Me.Panel1.Controls.Add(Me.BTN_RegresarMant)
            Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.Panel1.Location = New System.Drawing.Point(0, 639)
            Me.Panel1.Margin = New System.Windows.Forms.Padding(15)
            Me.Panel1.Name = "Panel1"
            Me.Panel1.Padding = New System.Windows.Forms.Padding(0, 15, 0, 0)
            Me.Panel1.Size = New System.Drawing.Size(1083, 90)
            Me.Panel1.TabIndex = 121
            '
            'Guna2Panel1
            '
            Me.Guna2Panel1.Location = New System.Drawing.Point(2, 419)
            Me.Guna2Panel1.Margin = New System.Windows.Forms.Padding(3, 3, 3, 15)
            Me.Guna2Panel1.Name = "Guna2Panel1"
            Me.Guna2Panel1.Padding = New System.Windows.Forms.Padding(0, 0, 0, 15)
            Me.Guna2Panel1.Size = New System.Drawing.Size(823, 80)
            Me.Guna2Panel1.TabIndex = 122
            '
            'BTN_LogOut
            '
            Me.BTN_LogOut.BackColor = System.Drawing.Color.Transparent
            Me.BTN_LogOut.CheckedState.ImageSize = New System.Drawing.Size(40, 40)
            Me.BTN_LogOut.HoverState.Image = Global.SistemaFacturaciónCommon.My.Resources.Resources.ICO_LogoutCol
            Me.BTN_LogOut.HoverState.ImageSize = New System.Drawing.Size(43, 43)
            Me.BTN_LogOut.Image = Global.SistemaFacturaciónCommon.My.Resources.Resources.ICO_Logout
            Me.BTN_LogOut.ImageOffset = New System.Drawing.Point(0, 0)
            Me.BTN_LogOut.ImageRotate = 0!
            Me.BTN_LogOut.ImageSize = New System.Drawing.Size(40, 40)
            Me.BTN_LogOut.Location = New System.Drawing.Point(975, 12)
            Me.BTN_LogOut.Name = "BTN_LogOut"
            Me.BTN_LogOut.PressedState.ImageSize = New System.Drawing.Size(64, 64)
            Me.BTN_LogOut.Size = New System.Drawing.Size(45, 45)
            Me.BTN_LogOut.TabIndex = 124
            '
            'BTN_Config
            '
            Me.BTN_Config.BackColor = System.Drawing.Color.Transparent
            Me.BTN_Config.CheckedState.ImageSize = New System.Drawing.Size(40, 40)
            Me.BTN_Config.HoverState.Image = Global.SistemaFacturaciónCommon.My.Resources.Resources.ICO_ConfigCol
            Me.BTN_Config.HoverState.ImageSize = New System.Drawing.Size(43, 43)
            Me.BTN_Config.Image = Global.SistemaFacturaciónCommon.My.Resources.Resources.ICO_Config
            Me.BTN_Config.ImageOffset = New System.Drawing.Point(0, 0)
            Me.BTN_Config.ImageRotate = 0!
            Me.BTN_Config.ImageSize = New System.Drawing.Size(40, 40)
            Me.BTN_Config.Location = New System.Drawing.Point(924, 12)
            Me.BTN_Config.Name = "BTN_Config"
            Me.BTN_Config.PressedState.ImageSize = New System.Drawing.Size(64, 64)
            Me.BTN_Config.Size = New System.Drawing.Size(45, 45)
            Me.BTN_Config.TabIndex = 123
            '
            'BTN_CerrarApp
            '
            Me.BTN_CerrarApp.BackColor = System.Drawing.Color.Transparent
            Me.BTN_CerrarApp.CheckedState.ImageSize = New System.Drawing.Size(40, 40)
            Me.BTN_CerrarApp.HoverState.Image = Global.SistemaFacturaciónCommon.My.Resources.Resources.ICO_CerrarCol
            Me.BTN_CerrarApp.HoverState.ImageSize = New System.Drawing.Size(43, 43)
            Me.BTN_CerrarApp.Image = Global.SistemaFacturaciónCommon.My.Resources.Resources.ICO_Cerrar
            Me.BTN_CerrarApp.ImageOffset = New System.Drawing.Point(0, 0)
            Me.BTN_CerrarApp.ImageRotate = 0!
            Me.BTN_CerrarApp.ImageSize = New System.Drawing.Size(40, 40)
            Me.BTN_CerrarApp.Location = New System.Drawing.Point(1026, 12)
            Me.BTN_CerrarApp.Name = "BTN_CerrarApp"
            Me.BTN_CerrarApp.PressedState.ImageSize = New System.Drawing.Size(64, 64)
            Me.BTN_CerrarApp.Size = New System.Drawing.Size(45, 45)
            Me.BTN_CerrarApp.TabIndex = 122
            '
            'BTN_Marca
            '
            Me.BTN_Marca.BorderRadius = 10
            Me.BTN_Marca.DisabledState.BorderColor = System.Drawing.Color.DarkGray
            Me.BTN_Marca.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
            Me.BTN_Marca.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
            Me.BTN_Marca.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
            Me.BTN_Marca.Dock = System.Windows.Forms.DockStyle.Top
            Me.BTN_Marca.FillColor = System.Drawing.Color.DarkOrchid
            Me.BTN_Marca.Font = New System.Drawing.Font("Ebrima", 20.25!, System.Drawing.FontStyle.Bold)
            Me.BTN_Marca.ForeColor = System.Drawing.Color.White
            Me.BTN_Marca.HoverState.FillColor = System.Drawing.Color.Indigo
            Me.BTN_Marca.Image = Global.SistemaFacturaciónCommon.My.Resources.Resources.ICO_Marca
            Me.BTN_Marca.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
            Me.BTN_Marca.ImageSize = New System.Drawing.Size(50, 50)
            Me.BTN_Marca.Location = New System.Drawing.Point(544, 272)
            Me.BTN_Marca.Name = "BTN_Marca"
            Me.BTN_Marca.Size = New System.Drawing.Size(531, 60)
            Me.BTN_Marca.TabIndex = 17
            Me.BTN_Marca.Text = "8. Marcas"
            '
            'TableLayoutPanel1
            '
            Me.TableLayoutPanel1.ColumnCount = 2
            Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
            Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
            Me.TableLayoutPanel1.Controls.Add(Me.BTN_Producto, 0, 4)
            Me.TableLayoutPanel1.Controls.Add(Me.BTN_Conceptos, 1, 2)
            Me.TableLayoutPanel1.Controls.Add(Me.BTN_Marca, 1, 3)
            Me.TableLayoutPanel1.Controls.Add(Me.BTN_Proveedor, 1, 1)
            Me.TableLayoutPanel1.Controls.Add(Me.BTN_Impuesto, 0, 2)
            Me.TableLayoutPanel1.Controls.Add(Me.BTN_Usuario, 1, 0)
            Me.TableLayoutPanel1.Controls.Add(Me.BTN_Cliente, 0, 1)
            Me.TableLayoutPanel1.Controls.Add(Me.BTN_Sucursal, 0, 0)
            Me.TableLayoutPanel1.Controls.Add(Me.BTN_Categoria, 0, 3)
            Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 188)
            Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
            Me.TableLayoutPanel1.Padding = New System.Windows.Forms.Padding(5)
            Me.TableLayoutPanel1.RowCount = 5
            Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
            Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
            Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
            Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
            Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
            Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
            Me.TableLayoutPanel1.Size = New System.Drawing.Size(1083, 451)
            Me.TableLayoutPanel1.TabIndex = 127
            '
            'BTN_Producto
            '
            Me.BTN_Producto.BorderRadius = 10
            Me.TableLayoutPanel1.SetColumnSpan(Me.BTN_Producto, 2)
            Me.BTN_Producto.DisabledState.BorderColor = System.Drawing.Color.DarkGray
            Me.BTN_Producto.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
            Me.BTN_Producto.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
            Me.BTN_Producto.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
            Me.BTN_Producto.Dock = System.Windows.Forms.DockStyle.Top
            Me.BTN_Producto.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.BTN_Producto.Font = New System.Drawing.Font("Ebrima", 20.25!, System.Drawing.FontStyle.Bold)
            Me.BTN_Producto.ForeColor = System.Drawing.Color.White
            Me.BTN_Producto.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(196, Byte), Integer), CType(CType(98, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.BTN_Producto.Image = Global.SistemaFacturaciónCommon.My.Resources.Resources.ICO_Productos
            Me.BTN_Producto.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
            Me.BTN_Producto.ImageSize = New System.Drawing.Size(50, 50)
            Me.BTN_Producto.Location = New System.Drawing.Point(8, 360)
            Me.BTN_Producto.Name = "BTN_Producto"
            Me.BTN_Producto.Size = New System.Drawing.Size(1067, 60)
            Me.BTN_Producto.TabIndex = 18
            Me.BTN_Producto.Text = "9. Productos"
            '
            'M_MantenimientoMenu
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer))
            Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
            Me.CancelButton = Me.BTN_RegresarMant
            Me.ClientSize = New System.Drawing.Size(1083, 729)
            Me.Controls.Add(Me.TableLayoutPanel1)
            Me.Controls.Add(Me.BTN_LogOut)
            Me.Controls.Add(Me.BTN_Config)
            Me.Controls.Add(Me.BTN_CerrarApp)
            Me.Controls.Add(Me.Guna2Panel1)
            Me.Controls.Add(Me.Panel1)
            Me.Controls.Add(Me.Guna2PictureBox1)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.KeyPreview = True
            Me.Name = "M_MantenimientoMenu"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "Mantenimiento"
            CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.Panel1.ResumeLayout(False)
            Me.TableLayoutPanel1.ResumeLayout(False)
            Me.ResumeLayout(False)

        End Sub

        Friend WithEvents Guna2BorderlessForm1 As Guna.UI2.WinForms.Guna2BorderlessForm
        Friend WithEvents Guna2PictureBox1 As Guna.UI2.WinForms.Guna2PictureBox
        Friend WithEvents BTN_Usuario As Guna.UI2.WinForms.Guna2Button
        Friend WithEvents BTN_Sucursal As Guna.UI2.WinForms.Guna2Button
        Friend WithEvents BTN_RegresarMant As Guna.UI2.WinForms.Guna2Button
        Friend WithEvents BTN_Conceptos As Guna.UI2.WinForms.Guna2Button
        Friend WithEvents BTN_Categoria As Guna.UI2.WinForms.Guna2Button
        Friend WithEvents BTN_Impuesto As Guna.UI2.WinForms.Guna2Button
        Friend WithEvents BTN_Proveedor As Guna.UI2.WinForms.Guna2Button
        Friend WithEvents BTN_Cliente As Guna.UI2.WinForms.Guna2Button
        Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
        Friend WithEvents Panel1 As Panel
        Friend WithEvents BTN_LogOut As Guna.UI2.WinForms.Guna2ImageButton
        Friend WithEvents BTN_Config As Guna.UI2.WinForms.Guna2ImageButton
        Friend WithEvents BTN_CerrarApp As Guna.UI2.WinForms.Guna2ImageButton
        Friend WithEvents BTN_Marca As Guna.UI2.WinForms.Guna2Button
        Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
        Friend WithEvents BTN_Producto As Guna.UI2.WinForms.Guna2Button
    End Class

End Namespace