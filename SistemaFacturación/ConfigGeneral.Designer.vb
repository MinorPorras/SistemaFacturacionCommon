<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ConfigGeneral
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ConfigGeneral))
        Me.Guna2BorderlessForm1 = New Guna.UI2.WinForms.Guna2BorderlessForm(Me.components)
        Me.OFD_ImportarDB = New System.Windows.Forms.OpenFileDialog()
        Me.OFD_ModDirDB = New System.Windows.Forms.OpenFileDialog()
        Me.OFD_ModBackUpDir = New System.Windows.Forms.FolderBrowserDialog()
        Me.TCO_Config = New Guna.UI2.WinForms.Guna2TabControl()
        Me.tabDB = New System.Windows.Forms.TabPage()
        Me.BTN_RegresarConfig = New Guna.UI2.WinForms.Guna2Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.BTN_ModConnDB = New Guna.UI2.WinForms.Guna2Button()
        Me.BTN_ModBackupDir = New Guna.UI2.WinForms.Guna2Button()
        Me.BTN_Importar = New Guna.UI2.WinForms.Guna2Button()
        Me.BTN_RspaldoDB = New Guna.UI2.WinForms.Guna2Button()
        Me.tabCod = New System.Windows.Forms.TabPage()
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.BTN_ActualizarCods = New Guna.UI2.WinForms.Guna2Button()
        Me.BTN_Regresar = New Guna.UI2.WinForms.Guna2Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.SWT_ModCod = New Guna.UI2.WinForms.Guna2ToggleSwitch()
        Me.NUD_Prod = New Guna.UI2.WinForms.Guna2NumericUpDown()
        Me.NUD_Imp = New Guna.UI2.WinForms.Guna2NumericUpDown()
        Me.NUD_Cliente = New Guna.UI2.WinForms.Guna2NumericUpDown()
        Me.NUD_Prov = New Guna.UI2.WinForms.Guna2NumericUpDown()
        Me.NUD_Marca = New Guna.UI2.WinForms.Guna2NumericUpDown()
        Me.NUD_Cat = New Guna.UI2.WinForms.Guna2NumericUpDown()
        Me.NUD_Cajero = New Guna.UI2.WinForms.Guna2NumericUpDown()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.LBL_Proveedor = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TabHablador = New System.Windows.Forms.TabPage()
        Me.Guna2Panel2 = New Guna.UI2.WinForms.Guna2Panel()
        Me.BTN_ConfigRegHablador = New Guna.UI2.WinForms.Guna2Button()
        Me.BTN_ActualizarHablador = New Guna.UI2.WinForms.Guna2Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.SWT_ModHablador = New Guna.UI2.WinForms.Guna2ToggleSwitch()
        Me.NUD_SizePrecio = New Guna.UI2.WinForms.Guna2NumericUpDown()
        Me.NUD_SizeProd = New Guna.UI2.WinForms.Guna2NumericUpDown()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Guna2PictureBox2 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.BTN_CerrarApp = New Guna.UI2.WinForms.Guna2ImageButton()
        Me.Guna2Panel3 = New Guna.UI2.WinForms.Guna2Panel()
        Me.TCO_Config.SuspendLayout()
        Me.tabDB.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.tabCod.SuspendLayout()
        Me.Guna2Panel1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.NUD_Prod, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NUD_Imp, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NUD_Cliente, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NUD_Prov, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NUD_Marca, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NUD_Cat, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NUD_Cajero, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabHablador.SuspendLayout()
        Me.Guna2Panel2.SuspendLayout()
        CType(Me.NUD_SizePrecio, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NUD_SizeProd, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Guna2PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Guna2Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Guna2BorderlessForm1
        '
        Me.Guna2BorderlessForm1.BorderRadius = 25
        Me.Guna2BorderlessForm1.ContainerControl = Me
        Me.Guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6R
        Me.Guna2BorderlessForm1.TransparentWhileDrag = True
        '
        'OFD_ImportarDB
        '
        Me.OFD_ImportarDB.FileName = "OpenFileDialog1"
        '
        'OFD_ModDirDB
        '
        Me.OFD_ModDirDB.CheckFileExists = False
        Me.OFD_ModDirDB.Filter = "Archivos de bd(*.db)|*.db"
        Me.OFD_ModDirDB.Title = "Seleccione un archivo de access"
        Me.OFD_ModDirDB.ValidateNames = False
        '
        'TCO_Config
        '
        Me.TCO_Config.Controls.Add(Me.tabDB)
        Me.TCO_Config.Controls.Add(Me.tabCod)
        Me.TCO_Config.Controls.Add(Me.TabHablador)
        Me.TCO_Config.ItemSize = New System.Drawing.Size(160, 40)
        Me.TCO_Config.Location = New System.Drawing.Point(-5, 147)
        Me.TCO_Config.Margin = New System.Windows.Forms.Padding(0)
        Me.TCO_Config.Name = "TCO_Config"
        Me.TCO_Config.SelectedIndex = 0
        Me.TCO_Config.Size = New System.Drawing.Size(661, 454)
        Me.TCO_Config.TabButtonHoverState.BorderColor = System.Drawing.Color.Empty
        Me.TCO_Config.TabButtonHoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.TCO_Config.TabButtonHoverState.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!)
        Me.TCO_Config.TabButtonHoverState.ForeColor = System.Drawing.Color.White
        Me.TCO_Config.TabButtonHoverState.InnerColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.TCO_Config.TabButtonIdleState.BorderColor = System.Drawing.Color.Empty
        Me.TCO_Config.TabButtonIdleState.FillColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.TCO_Config.TabButtonIdleState.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!)
        Me.TCO_Config.TabButtonIdleState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(156, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(167, Byte), Integer))
        Me.TCO_Config.TabButtonIdleState.InnerColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.TCO_Config.TabButtonSelectedState.BorderColor = System.Drawing.Color.Empty
        Me.TCO_Config.TabButtonSelectedState.FillColor = System.Drawing.Color.Gray
        Me.TCO_Config.TabButtonSelectedState.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!)
        Me.TCO_Config.TabButtonSelectedState.ForeColor = System.Drawing.Color.White
        Me.TCO_Config.TabButtonSelectedState.InnerColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.TCO_Config.TabButtonSize = New System.Drawing.Size(160, 40)
        Me.TCO_Config.TabIndex = 0
        Me.TCO_Config.TabMenuBackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.TCO_Config.TabMenuOrientation = Guna.UI2.WinForms.TabMenuOrientation.HorizontalTop
        '
        'tabDB
        '
        Me.tabDB.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.tabDB.Controls.Add(Me.BTN_RegresarConfig)
        Me.tabDB.Controls.Add(Me.GroupBox1)
        Me.tabDB.Location = New System.Drawing.Point(4, 44)
        Me.tabDB.Margin = New System.Windows.Forms.Padding(0)
        Me.tabDB.Name = "tabDB"
        Me.tabDB.Size = New System.Drawing.Size(653, 406)
        Me.tabDB.TabIndex = 0
        Me.tabDB.Text = "Gestión base de datos"
        '
        'BTN_RegresarConfig
        '
        Me.BTN_RegresarConfig.BorderColor = System.Drawing.Color.Red
        Me.BTN_RegresarConfig.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.BTN_RegresarConfig.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BTN_RegresarConfig.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BTN_RegresarConfig.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BTN_RegresarConfig.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BTN_RegresarConfig.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.BTN_RegresarConfig.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BTN_RegresarConfig.Font = New System.Drawing.Font("Ebrima", 20.25!, System.Drawing.FontStyle.Bold)
        Me.BTN_RegresarConfig.ForeColor = System.Drawing.Color.White
        Me.BTN_RegresarConfig.Image = CType(resources.GetObject("BTN_RegresarConfig.Image"), System.Drawing.Image)
        Me.BTN_RegresarConfig.ImageSize = New System.Drawing.Size(40, 40)
        Me.BTN_RegresarConfig.Location = New System.Drawing.Point(0, 341)
        Me.BTN_RegresarConfig.Name = "BTN_RegresarConfig"
        Me.BTN_RegresarConfig.Size = New System.Drawing.Size(653, 65)
        Me.BTN_RegresarConfig.TabIndex = 55
        Me.BTN_RegresarConfig.Text = "Regresar"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.BTN_ModConnDB)
        Me.GroupBox1.Controls.Add(Me.BTN_ModBackupDir)
        Me.GroupBox1.Controls.Add(Me.BTN_Importar)
        Me.GroupBox1.Controls.Add(Me.BTN_RspaldoDB)
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.GroupBox1.Location = New System.Drawing.Point(31, 15)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(590, 293)
        Me.GroupBox1.TabIndex = 54
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Gestión de base de datos"
        '
        'BTN_ModConnDB
        '
        Me.BTN_ModConnDB.BorderRadius = 25
        Me.BTN_ModConnDB.BorderThickness = 2
        Me.BTN_ModConnDB.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.BTN_ModConnDB.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BTN_ModConnDB.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BTN_ModConnDB.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BTN_ModConnDB.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BTN_ModConnDB.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BTN_ModConnDB.Font = New System.Drawing.Font("Ebrima", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_ModConnDB.ForeColor = System.Drawing.Color.White
        Me.BTN_ModConnDB.Image = CType(resources.GetObject("BTN_ModConnDB.Image"), System.Drawing.Image)
        Me.BTN_ModConnDB.ImageSize = New System.Drawing.Size(40, 40)
        Me.BTN_ModConnDB.Location = New System.Drawing.Point(6, 150)
        Me.BTN_ModConnDB.Name = "BTN_ModConnDB"
        Me.BTN_ModConnDB.Size = New System.Drawing.Size(565, 58)
        Me.BTN_ModConnDB.TabIndex = 14
        Me.BTN_ModConnDB.Text = "Modificar conexión base de datos"
        '
        'BTN_ModBackupDir
        '
        Me.BTN_ModBackupDir.BorderRadius = 25
        Me.BTN_ModBackupDir.BorderThickness = 2
        Me.BTN_ModBackupDir.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.BTN_ModBackupDir.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BTN_ModBackupDir.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BTN_ModBackupDir.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BTN_ModBackupDir.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BTN_ModBackupDir.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BTN_ModBackupDir.Font = New System.Drawing.Font("Ebrima", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_ModBackupDir.ForeColor = System.Drawing.Color.White
        Me.BTN_ModBackupDir.Image = CType(resources.GetObject("BTN_ModBackupDir.Image"), System.Drawing.Image)
        Me.BTN_ModBackupDir.ImageSize = New System.Drawing.Size(60, 60)
        Me.BTN_ModBackupDir.Location = New System.Drawing.Point(6, 214)
        Me.BTN_ModBackupDir.Name = "BTN_ModBackupDir"
        Me.BTN_ModBackupDir.Size = New System.Drawing.Size(565, 58)
        Me.BTN_ModBackupDir.TabIndex = 13
        Me.BTN_ModBackupDir.Text = "Modificar carpeta de respaldo"
        '
        'BTN_Importar
        '
        Me.BTN_Importar.AutoRoundedCorners = True
        Me.BTN_Importar.BorderRadius = 28
        Me.BTN_Importar.BorderThickness = 2
        Me.BTN_Importar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.BTN_Importar.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BTN_Importar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BTN_Importar.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BTN_Importar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BTN_Importar.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BTN_Importar.Font = New System.Drawing.Font("Ebrima", 14.25!, System.Drawing.FontStyle.Bold)
        Me.BTN_Importar.ForeColor = System.Drawing.Color.White
        Me.BTN_Importar.Image = CType(resources.GetObject("BTN_Importar.Image"), System.Drawing.Image)
        Me.BTN_Importar.ImageSize = New System.Drawing.Size(40, 40)
        Me.BTN_Importar.Location = New System.Drawing.Point(6, 22)
        Me.BTN_Importar.Name = "BTN_Importar"
        Me.BTN_Importar.Size = New System.Drawing.Size(565, 58)
        Me.BTN_Importar.TabIndex = 12
        Me.BTN_Importar.Text = "Importar base de datos"
        '
        'BTN_RspaldoDB
        '
        Me.BTN_RspaldoDB.BorderRadius = 25
        Me.BTN_RspaldoDB.BorderThickness = 2
        Me.BTN_RspaldoDB.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BTN_RspaldoDB.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BTN_RspaldoDB.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BTN_RspaldoDB.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BTN_RspaldoDB.FillColor = System.Drawing.Color.MediumSeaGreen
        Me.BTN_RspaldoDB.Font = New System.Drawing.Font("Ebrima", 14.25!, System.Drawing.FontStyle.Bold)
        Me.BTN_RspaldoDB.ForeColor = System.Drawing.Color.White
        Me.BTN_RspaldoDB.Image = CType(resources.GetObject("BTN_RspaldoDB.Image"), System.Drawing.Image)
        Me.BTN_RspaldoDB.ImageSize = New System.Drawing.Size(40, 40)
        Me.BTN_RspaldoDB.Location = New System.Drawing.Point(6, 86)
        Me.BTN_RspaldoDB.Name = "BTN_RspaldoDB"
        Me.BTN_RspaldoDB.Size = New System.Drawing.Size(565, 58)
        Me.BTN_RspaldoDB.TabIndex = 11
        Me.BTN_RspaldoDB.Text = "Respaldar base de datos"
        '
        'tabCod
        '
        Me.tabCod.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.tabCod.Controls.Add(Me.Guna2Panel1)
        Me.tabCod.Controls.Add(Me.GroupBox2)
        Me.tabCod.Location = New System.Drawing.Point(4, 44)
        Me.tabCod.Margin = New System.Windows.Forms.Padding(0)
        Me.tabCod.Name = "tabCod"
        Me.tabCod.Size = New System.Drawing.Size(653, 406)
        Me.tabCod.TabIndex = 1
        Me.tabCod.Text = "Códigos automáticos"
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.Controls.Add(Me.BTN_ActualizarCods)
        Me.Guna2Panel1.Controls.Add(Me.BTN_Regresar)
        Me.Guna2Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Guna2Panel1.Location = New System.Drawing.Point(0, 328)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.Size = New System.Drawing.Size(653, 78)
        Me.Guna2Panel1.TabIndex = 101
        '
        'BTN_ActualizarCods
        '
        Me.BTN_ActualizarCods.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BTN_ActualizarCods.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BTN_ActualizarCods.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BTN_ActualizarCods.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BTN_ActualizarCods.Dock = System.Windows.Forms.DockStyle.Right
        Me.BTN_ActualizarCods.FillColor = System.Drawing.Color.MediumSeaGreen
        Me.BTN_ActualizarCods.Font = New System.Drawing.Font("Ebrima", 20.25!, System.Drawing.FontStyle.Bold)
        Me.BTN_ActualizarCods.ForeColor = System.Drawing.Color.White
        Me.BTN_ActualizarCods.Image = CType(resources.GetObject("BTN_ActualizarCods.Image"), System.Drawing.Image)
        Me.BTN_ActualizarCods.ImageSize = New System.Drawing.Size(40, 40)
        Me.BTN_ActualizarCods.Location = New System.Drawing.Point(319, 0)
        Me.BTN_ActualizarCods.Name = "BTN_ActualizarCods"
        Me.BTN_ActualizarCods.Size = New System.Drawing.Size(334, 78)
        Me.BTN_ActualizarCods.TabIndex = 99
        Me.BTN_ActualizarCods.Text = "Actualizar"
        '
        'BTN_Regresar
        '
        Me.BTN_Regresar.BorderColor = System.Drawing.Color.Red
        Me.BTN_Regresar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.BTN_Regresar.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BTN_Regresar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BTN_Regresar.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BTN_Regresar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BTN_Regresar.Dock = System.Windows.Forms.DockStyle.Left
        Me.BTN_Regresar.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BTN_Regresar.Font = New System.Drawing.Font("Ebrima", 20.25!, System.Drawing.FontStyle.Bold)
        Me.BTN_Regresar.ForeColor = System.Drawing.Color.White
        Me.BTN_Regresar.Image = CType(resources.GetObject("BTN_Regresar.Image"), System.Drawing.Image)
        Me.BTN_Regresar.ImageSize = New System.Drawing.Size(40, 40)
        Me.BTN_Regresar.Location = New System.Drawing.Point(0, 0)
        Me.BTN_Regresar.Name = "BTN_Regresar"
        Me.BTN_Regresar.Size = New System.Drawing.Size(322, 78)
        Me.BTN_Regresar.TabIndex = 98
        Me.BTN_Regresar.Text = "Regresar"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.SWT_ModCod)
        Me.GroupBox2.Controls.Add(Me.NUD_Prod)
        Me.GroupBox2.Controls.Add(Me.NUD_Imp)
        Me.GroupBox2.Controls.Add(Me.NUD_Cliente)
        Me.GroupBox2.Controls.Add(Me.NUD_Prov)
        Me.GroupBox2.Controls.Add(Me.NUD_Marca)
        Me.GroupBox2.Controls.Add(Me.NUD_Cat)
        Me.GroupBox2.Controls.Add(Me.NUD_Cajero)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.LBL_Proveedor)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.GroupBox2.Location = New System.Drawing.Point(38, 22)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(576, 269)
        Me.GroupBox2.TabIndex = 100
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Número de digitos predeterminado en el código"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Britannic Bold", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(185, 218)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(102, 23)
        Me.Label7.TabIndex = 109
        Me.Label7.Text = "Modificar:"
        '
        'SWT_ModCod
        '
        Me.SWT_ModCod.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.SWT_ModCod.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.SWT_ModCod.CheckedState.InnerBorderColor = System.Drawing.Color.White
        Me.SWT_ModCod.CheckedState.InnerColor = System.Drawing.Color.White
        Me.SWT_ModCod.Location = New System.Drawing.Point(293, 215)
        Me.SWT_ModCod.Name = "SWT_ModCod"
        Me.SWT_ModCod.Size = New System.Drawing.Size(72, 31)
        Me.SWT_ModCod.TabIndex = 108
        Me.SWT_ModCod.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.SWT_ModCod.UncheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.SWT_ModCod.UncheckedState.InnerBorderColor = System.Drawing.Color.White
        Me.SWT_ModCod.UncheckedState.InnerColor = System.Drawing.Color.White
        '
        'NUD_Prod
        '
        Me.NUD_Prod.AutoRoundedCorners = True
        Me.NUD_Prod.BackColor = System.Drawing.Color.Transparent
        Me.NUD_Prod.BorderRadius = 14
        Me.NUD_Prod.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.NUD_Prod.Enabled = False
        Me.NUD_Prod.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.NUD_Prod.Location = New System.Drawing.Point(438, 51)
        Me.NUD_Prod.Maximum = New Decimal(New Integer() {100000, 0, 0, 0})
        Me.NUD_Prod.Minimum = New Decimal(New Integer() {1000, 0, 0, -2147483648})
        Me.NUD_Prod.Name = "NUD_Prod"
        Me.NUD_Prod.Size = New System.Drawing.Size(108, 31)
        Me.NUD_Prod.TabIndex = 107
        Me.NUD_Prod.UpDownButtonFillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        '
        'NUD_Imp
        '
        Me.NUD_Imp.AutoRoundedCorners = True
        Me.NUD_Imp.BackColor = System.Drawing.Color.Transparent
        Me.NUD_Imp.BorderRadius = 14
        Me.NUD_Imp.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.NUD_Imp.Enabled = False
        Me.NUD_Imp.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.NUD_Imp.Location = New System.Drawing.Point(82, 145)
        Me.NUD_Imp.Maximum = New Decimal(New Integer() {100000, 0, 0, 0})
        Me.NUD_Imp.Minimum = New Decimal(New Integer() {1000, 0, 0, -2147483648})
        Me.NUD_Imp.Name = "NUD_Imp"
        Me.NUD_Imp.Size = New System.Drawing.Size(108, 31)
        Me.NUD_Imp.TabIndex = 106
        Me.NUD_Imp.UpDownButtonFillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        '
        'NUD_Cliente
        '
        Me.NUD_Cliente.AutoRoundedCorners = True
        Me.NUD_Cliente.BackColor = System.Drawing.Color.Transparent
        Me.NUD_Cliente.BorderRadius = 14
        Me.NUD_Cliente.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.NUD_Cliente.Enabled = False
        Me.NUD_Cliente.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.NUD_Cliente.Location = New System.Drawing.Point(155, 51)
        Me.NUD_Cliente.Maximum = New Decimal(New Integer() {100000, 0, 0, 0})
        Me.NUD_Cliente.Minimum = New Decimal(New Integer() {1000, 0, 0, -2147483648})
        Me.NUD_Cliente.Name = "NUD_Cliente"
        Me.NUD_Cliente.Size = New System.Drawing.Size(108, 31)
        Me.NUD_Cliente.TabIndex = 105
        Me.NUD_Cliente.UpDownButtonFillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        '
        'NUD_Prov
        '
        Me.NUD_Prov.AutoRoundedCorners = True
        Me.NUD_Prov.BackColor = System.Drawing.Color.Transparent
        Me.NUD_Prov.BorderRadius = 14
        Me.NUD_Prov.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.NUD_Prov.Enabled = False
        Me.NUD_Prov.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.NUD_Prov.Location = New System.Drawing.Point(293, 51)
        Me.NUD_Prov.Maximum = New Decimal(New Integer() {100000, 0, 0, 0})
        Me.NUD_Prov.Minimum = New Decimal(New Integer() {1000, 0, 0, -2147483648})
        Me.NUD_Prov.Name = "NUD_Prov"
        Me.NUD_Prov.Size = New System.Drawing.Size(108, 31)
        Me.NUD_Prov.TabIndex = 104
        Me.NUD_Prov.UpDownButtonFillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        '
        'NUD_Marca
        '
        Me.NUD_Marca.AutoRoundedCorners = True
        Me.NUD_Marca.BackColor = System.Drawing.Color.Transparent
        Me.NUD_Marca.BorderRadius = 14
        Me.NUD_Marca.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.NUD_Marca.Enabled = False
        Me.NUD_Marca.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.NUD_Marca.Location = New System.Drawing.Point(358, 145)
        Me.NUD_Marca.Maximum = New Decimal(New Integer() {100000, 0, 0, 0})
        Me.NUD_Marca.Minimum = New Decimal(New Integer() {1000, 0, 0, -2147483648})
        Me.NUD_Marca.Name = "NUD_Marca"
        Me.NUD_Marca.Size = New System.Drawing.Size(108, 31)
        Me.NUD_Marca.TabIndex = 103
        Me.NUD_Marca.UpDownButtonFillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        '
        'NUD_Cat
        '
        Me.NUD_Cat.AutoRoundedCorners = True
        Me.NUD_Cat.BackColor = System.Drawing.Color.Transparent
        Me.NUD_Cat.BorderRadius = 14
        Me.NUD_Cat.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.NUD_Cat.Enabled = False
        Me.NUD_Cat.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.NUD_Cat.Location = New System.Drawing.Point(220, 145)
        Me.NUD_Cat.Maximum = New Decimal(New Integer() {100000, 0, 0, 0})
        Me.NUD_Cat.Minimum = New Decimal(New Integer() {1000, 0, 0, -2147483648})
        Me.NUD_Cat.Name = "NUD_Cat"
        Me.NUD_Cat.Size = New System.Drawing.Size(108, 31)
        Me.NUD_Cat.TabIndex = 102
        Me.NUD_Cat.UpDownButtonFillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        '
        'NUD_Cajero
        '
        Me.NUD_Cajero.AutoRoundedCorners = True
        Me.NUD_Cajero.BackColor = System.Drawing.Color.Transparent
        Me.NUD_Cajero.BorderRadius = 14
        Me.NUD_Cajero.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.NUD_Cajero.Enabled = False
        Me.NUD_Cajero.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.NUD_Cajero.Location = New System.Drawing.Point(17, 51)
        Me.NUD_Cajero.Maximum = New Decimal(New Integer() {100000, 0, 0, 0})
        Me.NUD_Cajero.Minimum = New Decimal(New Integer() {1000, 0, 0, -2147483648})
        Me.NUD_Cajero.Name = "NUD_Cajero"
        Me.NUD_Cajero.Size = New System.Drawing.Size(108, 31)
        Me.NUD_Cajero.TabIndex = 101
        Me.NUD_Cajero.UpDownButtonFillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Britannic Bold", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(285, 25)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(123, 23)
        Me.Label6.TabIndex = 93
        Me.Label6.Text = "Proveedores"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Britannic Bold", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(442, 25)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(104, 23)
        Me.Label5.TabIndex = 91
        Me.Label5.Text = "Productos"
        '
        'LBL_Proveedor
        '
        Me.LBL_Proveedor.AutoSize = True
        Me.LBL_Proveedor.Font = New System.Drawing.Font("Britannic Bold", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_Proveedor.ForeColor = System.Drawing.Color.White
        Me.LBL_Proveedor.Location = New System.Drawing.Point(30, 25)
        Me.LBL_Proveedor.Name = "LBL_Proveedor"
        Me.LBL_Proveedor.Size = New System.Drawing.Size(80, 23)
        Me.LBL_Proveedor.TabIndex = 81
        Me.LBL_Proveedor.Text = "Cajeros"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Britannic Bold", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(168, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(84, 23)
        Me.Label1.TabIndex = 83
        Me.Label1.Text = "Clientes"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Britannic Bold", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(371, 116)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(76, 23)
        Me.Label4.TabIndex = 89
        Me.Label4.Text = "Marcas"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Britannic Bold", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(85, 116)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(105, 23)
        Me.Label2.TabIndex = 85
        Me.Label2.Text = "Impuestos"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Britannic Bold", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(219, 116)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(109, 23)
        Me.Label3.TabIndex = 87
        Me.Label3.Text = "Categorías"
        '
        'TabHablador
        '
        Me.TabHablador.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.TabHablador.Controls.Add(Me.Guna2Panel2)
        Me.TabHablador.Controls.Add(Me.Label10)
        Me.TabHablador.Controls.Add(Me.SWT_ModHablador)
        Me.TabHablador.Controls.Add(Me.NUD_SizePrecio)
        Me.TabHablador.Controls.Add(Me.NUD_SizeProd)
        Me.TabHablador.Controls.Add(Me.Label8)
        Me.TabHablador.Controls.Add(Me.Label9)
        Me.TabHablador.Location = New System.Drawing.Point(4, 44)
        Me.TabHablador.Margin = New System.Windows.Forms.Padding(0)
        Me.TabHablador.Name = "TabHablador"
        Me.TabHablador.Size = New System.Drawing.Size(653, 406)
        Me.TabHablador.TabIndex = 2
        Me.TabHablador.Text = "Habladores"
        '
        'Guna2Panel2
        '
        Me.Guna2Panel2.Controls.Add(Me.BTN_ConfigRegHablador)
        Me.Guna2Panel2.Controls.Add(Me.BTN_ActualizarHablador)
        Me.Guna2Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Guna2Panel2.Location = New System.Drawing.Point(0, 337)
        Me.Guna2Panel2.Name = "Guna2Panel2"
        Me.Guna2Panel2.Size = New System.Drawing.Size(653, 69)
        Me.Guna2Panel2.TabIndex = 112
        '
        'BTN_ConfigRegHablador
        '
        Me.BTN_ConfigRegHablador.BorderColor = System.Drawing.Color.Red
        Me.BTN_ConfigRegHablador.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.BTN_ConfigRegHablador.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BTN_ConfigRegHablador.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BTN_ConfigRegHablador.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BTN_ConfigRegHablador.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BTN_ConfigRegHablador.Dock = System.Windows.Forms.DockStyle.Left
        Me.BTN_ConfigRegHablador.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BTN_ConfigRegHablador.Font = New System.Drawing.Font("Ebrima", 20.25!, System.Drawing.FontStyle.Bold)
        Me.BTN_ConfigRegHablador.ForeColor = System.Drawing.Color.White
        Me.BTN_ConfigRegHablador.Image = CType(resources.GetObject("BTN_ConfigRegHablador.Image"), System.Drawing.Image)
        Me.BTN_ConfigRegHablador.ImageSize = New System.Drawing.Size(40, 40)
        Me.BTN_ConfigRegHablador.Location = New System.Drawing.Point(0, 0)
        Me.BTN_ConfigRegHablador.Name = "BTN_ConfigRegHablador"
        Me.BTN_ConfigRegHablador.Size = New System.Drawing.Size(325, 69)
        Me.BTN_ConfigRegHablador.TabIndex = 100
        Me.BTN_ConfigRegHablador.Text = "Regresar"
        '
        'BTN_ActualizarHablador
        '
        Me.BTN_ActualizarHablador.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BTN_ActualizarHablador.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BTN_ActualizarHablador.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BTN_ActualizarHablador.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BTN_ActualizarHablador.Dock = System.Windows.Forms.DockStyle.Right
        Me.BTN_ActualizarHablador.FillColor = System.Drawing.Color.MediumSeaGreen
        Me.BTN_ActualizarHablador.Font = New System.Drawing.Font("Ebrima", 20.25!, System.Drawing.FontStyle.Bold)
        Me.BTN_ActualizarHablador.ForeColor = System.Drawing.Color.White
        Me.BTN_ActualizarHablador.Image = CType(resources.GetObject("BTN_ActualizarHablador.Image"), System.Drawing.Image)
        Me.BTN_ActualizarHablador.ImageSize = New System.Drawing.Size(40, 40)
        Me.BTN_ActualizarHablador.Location = New System.Drawing.Point(323, 0)
        Me.BTN_ActualizarHablador.Name = "BTN_ActualizarHablador"
        Me.BTN_ActualizarHablador.Size = New System.Drawing.Size(330, 69)
        Me.BTN_ActualizarHablador.TabIndex = 101
        Me.BTN_ActualizarHablador.Text = "Actualizar"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Britannic Bold", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(248, 242)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(102, 23)
        Me.Label10.TabIndex = 111
        Me.Label10.Text = "Modificar:"
        '
        'SWT_ModHablador
        '
        Me.SWT_ModHablador.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.SWT_ModHablador.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.SWT_ModHablador.CheckedState.InnerBorderColor = System.Drawing.Color.White
        Me.SWT_ModHablador.CheckedState.InnerColor = System.Drawing.Color.White
        Me.SWT_ModHablador.Location = New System.Drawing.Point(359, 242)
        Me.SWT_ModHablador.Name = "SWT_ModHablador"
        Me.SWT_ModHablador.Size = New System.Drawing.Size(72, 31)
        Me.SWT_ModHablador.TabIndex = 110
        Me.SWT_ModHablador.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.SWT_ModHablador.UncheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.SWT_ModHablador.UncheckedState.InnerBorderColor = System.Drawing.Color.White
        Me.SWT_ModHablador.UncheckedState.InnerColor = System.Drawing.Color.White
        '
        'NUD_SizePrecio
        '
        Me.NUD_SizePrecio.AutoRoundedCorners = True
        Me.NUD_SizePrecio.BackColor = System.Drawing.Color.Transparent
        Me.NUD_SizePrecio.BorderRadius = 14
        Me.NUD_SizePrecio.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.NUD_SizePrecio.Enabled = False
        Me.NUD_SizePrecio.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.NUD_SizePrecio.Location = New System.Drawing.Point(390, 155)
        Me.NUD_SizePrecio.Maximum = New Decimal(New Integer() {100000, 0, 0, 0})
        Me.NUD_SizePrecio.Minimum = New Decimal(New Integer() {1000, 0, 0, -2147483648})
        Me.NUD_SizePrecio.Name = "NUD_SizePrecio"
        Me.NUD_SizePrecio.Size = New System.Drawing.Size(139, 31)
        Me.NUD_SizePrecio.TabIndex = 109
        Me.NUD_SizePrecio.UpDownButtonFillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        '
        'NUD_SizeProd
        '
        Me.NUD_SizeProd.AutoRoundedCorners = True
        Me.NUD_SizeProd.BackColor = System.Drawing.Color.Transparent
        Me.NUD_SizeProd.BorderRadius = 14
        Me.NUD_SizeProd.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.NUD_SizeProd.Enabled = False
        Me.NUD_SizeProd.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.NUD_SizeProd.Location = New System.Drawing.Point(390, 58)
        Me.NUD_SizeProd.Maximum = New Decimal(New Integer() {100000, 0, 0, 0})
        Me.NUD_SizeProd.Minimum = New Decimal(New Integer() {1000, 0, 0, -2147483648})
        Me.NUD_SizeProd.Name = "NUD_SizeProd"
        Me.NUD_SizeProd.Size = New System.Drawing.Size(139, 31)
        Me.NUD_SizeProd.TabIndex = 108
        Me.NUD_SizeProd.UpDownButtonFillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Britannic Bold", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(96, 57)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(253, 23)
        Me.Label8.TabIndex = 106
        Me.Label8.Text = "Tamaño nombre producto:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Britannic Bold", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(96, 157)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(185, 23)
        Me.Label9.TabIndex = 107
        Me.Label9.Text = "Tamaño del precio:"
        '
        'Guna2PictureBox2
        '
        Me.Guna2PictureBox2.Image = CType(resources.GetObject("Guna2PictureBox2.Image"), System.Drawing.Image)
        Me.Guna2PictureBox2.ImageRotate = 0!
        Me.Guna2PictureBox2.Location = New System.Drawing.Point(149, -85)
        Me.Guna2PictureBox2.Name = "Guna2PictureBox2"
        Me.Guna2PictureBox2.Size = New System.Drawing.Size(363, 310)
        Me.Guna2PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Guna2PictureBox2.TabIndex = 55
        Me.Guna2PictureBox2.TabStop = False
        '
        'BTN_CerrarApp
        '
        Me.BTN_CerrarApp.BackColor = System.Drawing.Color.Firebrick
        Me.BTN_CerrarApp.CheckedState.ImageSize = New System.Drawing.Size(64, 64)
        Me.BTN_CerrarApp.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BTN_CerrarApp.HoverState.ImageSize = New System.Drawing.Size(64, 64)
        Me.BTN_CerrarApp.Image = CType(resources.GetObject("BTN_CerrarApp.Image"), System.Drawing.Image)
        Me.BTN_CerrarApp.ImageOffset = New System.Drawing.Point(0, 0)
        Me.BTN_CerrarApp.ImageRotate = 0!
        Me.BTN_CerrarApp.ImageSize = New System.Drawing.Size(70, 70)
        Me.BTN_CerrarApp.Location = New System.Drawing.Point(0, 0)
        Me.BTN_CerrarApp.Name = "BTN_CerrarApp"
        Me.BTN_CerrarApp.PressedState.ImageSize = New System.Drawing.Size(64, 64)
        Me.BTN_CerrarApp.Size = New System.Drawing.Size(51, 53)
        Me.BTN_CerrarApp.TabIndex = 123
        '
        'Guna2Panel3
        '
        Me.Guna2Panel3.Controls.Add(Me.BTN_CerrarApp)
        Me.Guna2Panel3.Location = New System.Drawing.Point(595, 1)
        Me.Guna2Panel3.Name = "Guna2Panel3"
        Me.Guna2Panel3.Size = New System.Drawing.Size(51, 53)
        Me.Guna2Panel3.TabIndex = 124
        '
        'ConfigGeneral
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(646, 592)
        Me.Controls.Add(Me.Guna2Panel3)
        Me.Controls.Add(Me.TCO_Config)
        Me.Controls.Add(Me.Guna2PictureBox2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Name = "ConfigGeneral"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Configuración general"
        Me.TCO_Config.ResumeLayout(False)
        Me.tabDB.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.tabCod.ResumeLayout(False)
        Me.Guna2Panel1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.NUD_Prod, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NUD_Imp, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NUD_Cliente, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NUD_Prov, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NUD_Marca, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NUD_Cat, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NUD_Cajero, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabHablador.ResumeLayout(False)
        Me.TabHablador.PerformLayout()
        Me.Guna2Panel2.ResumeLayout(False)
        CType(Me.NUD_SizePrecio, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NUD_SizeProd, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Guna2PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Guna2Panel3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Guna2BorderlessForm1 As Guna.UI2.WinForms.Guna2BorderlessForm
    Friend WithEvents OFD_ImportarDB As OpenFileDialog
    Friend WithEvents OFD_ModDirDB As OpenFileDialog
    Friend WithEvents OFD_ModBackUpDir As FolderBrowserDialog
    Friend WithEvents TCO_Config As Guna.UI2.WinForms.Guna2TabControl
    Friend WithEvents tabDB As TabPage
    Friend WithEvents tabCod As TabPage
    Friend WithEvents Guna2PictureBox2 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents BTN_RegresarConfig As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents BTN_ModConnDB As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BTN_ModBackupDir As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BTN_Importar As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BTN_RspaldoDB As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents TabHablador As TabPage
    Friend WithEvents BTN_ActualizarCods As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BTN_Regresar As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label7 As Label
    Friend WithEvents SWT_ModCod As Guna.UI2.WinForms.Guna2ToggleSwitch
    Friend WithEvents NUD_Prod As Guna.UI2.WinForms.Guna2NumericUpDown
    Friend WithEvents NUD_Imp As Guna.UI2.WinForms.Guna2NumericUpDown
    Friend WithEvents NUD_Cliente As Guna.UI2.WinForms.Guna2NumericUpDown
    Friend WithEvents NUD_Prov As Guna.UI2.WinForms.Guna2NumericUpDown
    Friend WithEvents NUD_Marca As Guna.UI2.WinForms.Guna2NumericUpDown
    Friend WithEvents NUD_Cat As Guna.UI2.WinForms.Guna2NumericUpDown
    Friend WithEvents NUD_Cajero As Guna.UI2.WinForms.Guna2NumericUpDown
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents LBL_Proveedor As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents BTN_ActualizarHablador As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BTN_ConfigRegHablador As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents NUD_SizePrecio As Guna.UI2.WinForms.Guna2NumericUpDown
    Friend WithEvents NUD_SizeProd As Guna.UI2.WinForms.Guna2NumericUpDown
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents SWT_ModHablador As Guna.UI2.WinForms.Guna2ToggleSwitch
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2Panel2 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents BTN_CerrarApp As Guna.UI2.WinForms.Guna2ImageButton
    Friend WithEvents Guna2Panel3 As Guna.UI2.WinForms.Guna2Panel
End Class
