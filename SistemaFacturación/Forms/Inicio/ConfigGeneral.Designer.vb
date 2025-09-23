Namespace SistemaFacturacion.Forms.Inicio
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
        Dim Animation1 As Guna.UI2.AnimatorNS.Animation = New Guna.UI2.AnimatorNS.Animation()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ConfigGeneral))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Guna2BorderlessForm1 = New Guna.UI2.WinForms.Guna2BorderlessForm(Me.components)
        Me.OFD_ImportarDB = New System.Windows.Forms.OpenFileDialog()
        Me.OFD_ModDirDB = New System.Windows.Forms.OpenFileDialog()
        Me.OFD_ModBackUpDir = New System.Windows.Forms.FolderBrowserDialog()
        Me.TCO_Config = New Guna.UI2.WinForms.Guna2TabControl()
        Me.PAG_Info = New System.Windows.Forms.TabPage()
        Me.btn_RegInfoConfig = New Guna.UI2.WinForms.Guna2Button()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.BTN_CheckForUpdates = New Guna.UI2.WinForms.Guna2Button()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.SWT_AutoUpdate = New Guna.UI2.WinForms.Guna2ToggleSwitch()
        Me.lbl_versionGeneralConfig = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Guna2PictureBox1 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.PAG_DBReportes = New System.Windows.Forms.TabPage()
        Me.Guna2GroupBox2 = New Guna.UI2.WinForms.Guna2GroupBox()
        Me.LBL_DownloadRepDIr = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.BTN_ModCarpetaDescargaReportes = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2GroupBox1 = New Guna.UI2.WinForms.Guna2GroupBox()
        Me.LBL_BackUpDIr = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.BTN_ModBackupDir = New Guna.UI2.WinForms.Guna2Button()
        Me.BTN_Importar = New Guna.UI2.WinForms.Guna2Button()
        Me.BTN_RspaldoDB = New Guna.UI2.WinForms.Guna2Button()
        Me.BTN_RegresarConfig = New Guna.UI2.WinForms.Guna2Button()
        Me.PAG_AutoCods = New System.Windows.Forms.TabPage()
        Me.Guna2GroupBox3 = New Guna.UI2.WinForms.Guna2GroupBox()
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
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.BTN_ActualizarCods = New Guna.UI2.WinForms.Guna2Button()
        Me.BTN_Regresar = New Guna.UI2.WinForms.Guna2Button()
        Me.PAG_Hablador = New System.Windows.Forms.TabPage()
        Me.Guna2GroupBox4 = New Guna.UI2.WinForms.Guna2GroupBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.SWT_ModHablador = New Guna.UI2.WinForms.Guna2ToggleSwitch()
        Me.NUD_SizePrecio = New Guna.UI2.WinForms.Guna2NumericUpDown()
        Me.NUD_SizeProd = New Guna.UI2.WinForms.Guna2NumericUpDown()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Guna2Panel2 = New Guna.UI2.WinForms.Guna2Panel()
        Me.BTN_ConfigRegHablador = New Guna.UI2.WinForms.Guna2Button()
        Me.BTN_ActualizarHablador = New Guna.UI2.WinForms.Guna2Button()
        Me.BTN_CerrarApp = New Guna.UI2.WinForms.Guna2ImageButton()
        Me.Guna2Transition1 = New Guna.UI2.WinForms.Guna2Transition()
        Me.Guna2PictureBox2 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.PAG_FavProd = New System.Windows.Forms.TabPage()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.PAN_InfoPageConfigFavProd = New Guna.UI2.WinForms.Guna2Panel()
        Me.TBL_DivSeccionsPageInfo = New System.Windows.Forms.TableLayoutPanel()
        Me.PAN_TBLLayoutCell2 = New Guna.UI2.WinForms.Guna2Panel()
        Me.PAN_ProdFavContainer = New Guna.UI2.WinForms.Guna2Panel()
        Me.PAN_DGVFavContainer = New Guna.UI2.WinForms.Guna2Panel()
        Me.BTN_MoveDown = New Guna.UI2.WinForms.Guna2TileButton()
        Me.BTN_MoveUp = New Guna.UI2.WinForms.Guna2TileButton()
        Me.DGV_FavProd = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.codigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colorProd = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PAN_HeaderFavContainer = New Guna.UI2.WinForms.Guna2Panel()
        Me.LBL_FavTitle = New System.Windows.Forms.Label()
        Me.PAN_TBLLayoutCell1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.TBL_TBLLayoutCell1 = New System.Windows.Forms.TableLayoutPanel()
        Me.TXT_BuscarProd = New Guna.UI2.WinForms.Guna2TextBox()
        Me.PAN_DGVSearchContainer = New Guna.UI2.WinForms.Guna2Panel()
        Me.DGV_BProd = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.PAN_BtnContainer = New Guna.UI2.WinForms.Guna2Panel()
        Me.BTN_Actualizar = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2Button1 = New Guna.UI2.WinForms.Guna2Button()
        Me.MNU_CONTX_BUSCAR = New Guna.UI2.WinForms.Guna2ContextMenuStrip()
        Me.MNU_SELECCIONAR = New System.Windows.Forms.ToolStripMenuItem()
        Me.MNU_CONTX_FAV = New Guna.UI2.WinForms.Guna2ContextMenuStrip()
        Me.MNU_ELIMINAR = New System.Windows.Forms.ToolStripMenuItem()
        Me.TCO_Config.SuspendLayout()
        Me.PAG_Info.SuspendLayout()
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PAG_DBReportes.SuspendLayout()
        Me.Guna2GroupBox2.SuspendLayout()
        Me.Guna2GroupBox1.SuspendLayout()
        Me.PAG_AutoCods.SuspendLayout()
        Me.Guna2GroupBox3.SuspendLayout()
        CType(Me.NUD_Prod, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NUD_Imp, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NUD_Cliente, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NUD_Prov, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NUD_Marca, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NUD_Cat, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NUD_Cajero, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Guna2Panel1.SuspendLayout()
        Me.PAG_Hablador.SuspendLayout()
        Me.Guna2GroupBox4.SuspendLayout()
        CType(Me.NUD_SizePrecio, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NUD_SizeProd, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Guna2Panel2.SuspendLayout()
        CType(Me.Guna2PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PAG_FavProd.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.PAN_InfoPageConfigFavProd.SuspendLayout()
        Me.TBL_DivSeccionsPageInfo.SuspendLayout()
        Me.PAN_TBLLayoutCell2.SuspendLayout()
        Me.PAN_ProdFavContainer.SuspendLayout()
        Me.PAN_DGVFavContainer.SuspendLayout()
        CType(Me.DGV_FavProd, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PAN_HeaderFavContainer.SuspendLayout()
        Me.PAN_TBLLayoutCell1.SuspendLayout()
        Me.TBL_TBLLayoutCell1.SuspendLayout()
        Me.PAN_DGVSearchContainer.SuspendLayout()
        CType(Me.DGV_BProd, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PAN_BtnContainer.SuspendLayout()
        Me.MNU_CONTX_BUSCAR.SuspendLayout()
        Me.MNU_CONTX_FAV.SuspendLayout()
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
        Me.TCO_Config.Controls.Add(Me.PAG_Info)
        Me.TCO_Config.Controls.Add(Me.PAG_DBReportes)
        Me.TCO_Config.Controls.Add(Me.PAG_AutoCods)
        Me.TCO_Config.Controls.Add(Me.PAG_Hablador)
        Me.TCO_Config.Controls.Add(Me.PAG_FavProd)
        Me.TCO_Config.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Guna2Transition1.SetDecoration(Me.TCO_Config, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.TCO_Config.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.TCO_Config.ItemSize = New System.Drawing.Size(240, 40)
        Me.TCO_Config.Location = New System.Drawing.Point(0, 149)
        Me.TCO_Config.Margin = New System.Windows.Forms.Padding(0)
        Me.TCO_Config.Name = "TCO_Config"
        Me.TCO_Config.SelectedIndex = 0
        Me.TCO_Config.Size = New System.Drawing.Size(1215, 530)
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
        Me.TCO_Config.TabButtonSize = New System.Drawing.Size(240, 40)
        Me.TCO_Config.TabIndex = 0
        Me.TCO_Config.TabMenuBackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.TCO_Config.TabMenuOrientation = Guna.UI2.WinForms.TabMenuOrientation.HorizontalTop
        '
        'PAG_Info
        '
        Me.PAG_Info.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.PAG_Info.Controls.Add(Me.btn_RegInfoConfig)
        Me.PAG_Info.Controls.Add(Me.Label17)
        Me.PAG_Info.Controls.Add(Me.Label16)
        Me.PAG_Info.Controls.Add(Me.BTN_CheckForUpdates)
        Me.PAG_Info.Controls.Add(Me.Label15)
        Me.PAG_Info.Controls.Add(Me.SWT_AutoUpdate)
        Me.PAG_Info.Controls.Add(Me.lbl_versionGeneralConfig)
        Me.PAG_Info.Controls.Add(Me.Label14)
        Me.PAG_Info.Controls.Add(Me.Label13)
        Me.PAG_Info.Controls.Add(Me.Label12)
        Me.PAG_Info.Controls.Add(Me.Label11)
        Me.PAG_Info.Controls.Add(Me.Guna2PictureBox1)
        Me.Guna2Transition1.SetDecoration(Me.PAG_Info, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.PAG_Info.Location = New System.Drawing.Point(4, 44)
        Me.PAG_Info.Name = "PAG_Info"
        Me.PAG_Info.Padding = New System.Windows.Forms.Padding(3)
        Me.PAG_Info.Size = New System.Drawing.Size(1207, 482)
        Me.PAG_Info.TabIndex = 3
        Me.PAG_Info.Text = "Información"
        Me.PAG_Info.ToolTipText = "Información general de la aplicación"
        '
        'btn_RegInfoConfig
        '
        Me.btn_RegInfoConfig.BorderColor = System.Drawing.Color.Red
        Me.btn_RegInfoConfig.BorderRadius = 10
        Me.Guna2Transition1.SetDecoration(Me.btn_RegInfoConfig, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.btn_RegInfoConfig.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btn_RegInfoConfig.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btn_RegInfoConfig.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btn_RegInfoConfig.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btn_RegInfoConfig.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btn_RegInfoConfig.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.btn_RegInfoConfig.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btn_RegInfoConfig.Font = New System.Drawing.Font("Ebrima", 20.25!, System.Drawing.FontStyle.Bold)
        Me.btn_RegInfoConfig.ForeColor = System.Drawing.Color.White
        Me.btn_RegInfoConfig.Image = CType(resources.GetObject("btn_RegInfoConfig.Image"), System.Drawing.Image)
        Me.btn_RegInfoConfig.ImageSize = New System.Drawing.Size(40, 40)
        Me.btn_RegInfoConfig.Location = New System.Drawing.Point(3, 414)
        Me.btn_RegInfoConfig.Name = "btn_RegInfoConfig"
        Me.btn_RegInfoConfig.Size = New System.Drawing.Size(1201, 65)
        Me.btn_RegInfoConfig.TabIndex = 118
        Me.btn_RegInfoConfig.Text = "Regresar"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Guna2Transition1.SetDecoration(Me.Label17, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Label17.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.White
        Me.Label17.Location = New System.Drawing.Point(103, 268)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(177, 19)
        Me.Label17.TabIndex = 117
        Me.Label17.Text = "Minor Josué Porras Varela"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Guna2Transition1.SetDecoration(Me.Label16, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Label16.Font = New System.Drawing.Font("Britannic Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.White
        Me.Label16.Location = New System.Drawing.Point(30, 270)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(52, 17)
        Me.Label16.TabIndex = 116
        Me.Label16.Text = "Autor:"
        '
        'BTN_CheckForUpdates
        '
        Me.BTN_CheckForUpdates.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BTN_CheckForUpdates.BorderRadius = 10
        Me.BTN_CheckForUpdates.BorderThickness = 2
        Me.Guna2Transition1.SetDecoration(Me.BTN_CheckForUpdates, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.BTN_CheckForUpdates.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.BTN_CheckForUpdates.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BTN_CheckForUpdates.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BTN_CheckForUpdates.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BTN_CheckForUpdates.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BTN_CheckForUpdates.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BTN_CheckForUpdates.Font = New System.Drawing.Font("Ebrima", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_CheckForUpdates.ForeColor = System.Drawing.Color.White
        Me.BTN_CheckForUpdates.Image = Global.SistemaFacturaciónCommon.My.Resources.Resources.ICO_Download
        Me.BTN_CheckForUpdates.ImageSize = New System.Drawing.Size(40, 40)
        Me.BTN_CheckForUpdates.Location = New System.Drawing.Point(433, 166)
        Me.BTN_CheckForUpdates.Name = "BTN_CheckForUpdates"
        Me.BTN_CheckForUpdates.Size = New System.Drawing.Size(378, 59)
        Me.BTN_CheckForUpdates.TabIndex = 115
        Me.BTN_CheckForUpdates.Text = "Buscar nuevas versiones"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Guna2Transition1.SetDecoration(Me.Label15, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Label15.Font = New System.Drawing.Font("Britannic Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.White
        Me.Label15.Location = New System.Drawing.Point(430, 275)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(300, 17)
        Me.Label15.TabIndex = 113
        Me.Label15.Text = "Buscar actualizaciones automáticamente:"
        '
        'SWT_AutoUpdate
        '
        Me.SWT_AutoUpdate.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.SWT_AutoUpdate.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.SWT_AutoUpdate.CheckedState.InnerBorderColor = System.Drawing.Color.White
        Me.SWT_AutoUpdate.CheckedState.InnerColor = System.Drawing.Color.White
        Me.Guna2Transition1.SetDecoration(Me.SWT_AutoUpdate, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.SWT_AutoUpdate.Location = New System.Drawing.Point(739, 270)
        Me.SWT_AutoUpdate.Name = "SWT_AutoUpdate"
        Me.SWT_AutoUpdate.Size = New System.Drawing.Size(72, 27)
        Me.SWT_AutoUpdate.TabIndex = 112
        Me.SWT_AutoUpdate.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.SWT_AutoUpdate.UncheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.SWT_AutoUpdate.UncheckedState.InnerBorderColor = System.Drawing.Color.White
        Me.SWT_AutoUpdate.UncheckedState.InnerColor = System.Drawing.Color.White
        '
        'lbl_versionGeneralConfig
        '
        Me.lbl_versionGeneralConfig.AutoSize = True
        Me.Guna2Transition1.SetDecoration(Me.lbl_versionGeneralConfig, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.lbl_versionGeneralConfig.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_versionGeneralConfig.ForeColor = System.Drawing.Color.White
        Me.lbl_versionGeneralConfig.Location = New System.Drawing.Point(103, 219)
        Me.lbl_versionGeneralConfig.Name = "lbl_versionGeneralConfig"
        Me.lbl_versionGeneralConfig.Size = New System.Drawing.Size(41, 19)
        Me.lbl_versionGeneralConfig.TabIndex = 111
        Me.lbl_versionGeneralConfig.Text = "0.0.0"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Guna2Transition1.SetDecoration(Me.Label14, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Label14.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.White
        Me.Label14.Location = New System.Drawing.Point(105, 166)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(220, 19)
        Me.Label14.TabIndex = 110
        Me.Label14.Text = "Sistema de Facturación Common"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Guna2Transition1.SetDecoration(Me.Label13, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Label13.Font = New System.Drawing.Font("Britannic Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.White
        Me.Label13.Location = New System.Drawing.Point(30, 219)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(67, 17)
        Me.Label13.TabIndex = 109
        Me.Label13.Text = "Versión:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Guna2Transition1.SetDecoration(Me.Label12, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Label12.Font = New System.Drawing.Font("Britannic Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.White
        Me.Label12.Location = New System.Drawing.Point(30, 168)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(69, 17)
        Me.Label12.TabIndex = 108
        Me.Label12.Text = "Nombre:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Guna2Transition1.SetDecoration(Me.Label11, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Label11.Font = New System.Drawing.Font("Britannic Bold", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(29, 110)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(244, 23)
        Me.Label11.TabIndex = 107
        Me.Label11.Text = "Información del producto"
        '
        'Guna2PictureBox1
        '
        Me.Guna2Transition1.SetDecoration(Me.Guna2PictureBox1, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Guna2PictureBox1.Image = Global.SistemaFacturaciónCommon.My.Resources.Resources.logoCompletoSFCommonTransparent
        Me.Guna2PictureBox1.ImageRotate = 0!
        Me.Guna2PictureBox1.Location = New System.Drawing.Point(860, 47)
        Me.Guna2PictureBox1.Name = "Guna2PictureBox1"
        Me.Guna2PictureBox1.Size = New System.Drawing.Size(324, 324)
        Me.Guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Guna2PictureBox1.TabIndex = 119
        Me.Guna2PictureBox1.TabStop = False
        '
        'PAG_DBReportes
        '
        Me.PAG_DBReportes.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.PAG_DBReportes.Controls.Add(Me.Guna2GroupBox2)
        Me.PAG_DBReportes.Controls.Add(Me.Guna2GroupBox1)
        Me.PAG_DBReportes.Controls.Add(Me.BTN_RegresarConfig)
        Me.Guna2Transition1.SetDecoration(Me.PAG_DBReportes, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.PAG_DBReportes.Location = New System.Drawing.Point(4, 44)
        Me.PAG_DBReportes.Margin = New System.Windows.Forms.Padding(0)
        Me.PAG_DBReportes.Name = "PAG_DBReportes"
        Me.PAG_DBReportes.Size = New System.Drawing.Size(1207, 482)
        Me.PAG_DBReportes.TabIndex = 0
        Me.PAG_DBReportes.Text = "Datos y reportes"
        Me.PAG_DBReportes.ToolTipText = "Gestión de los datos de las bases de datos y rutas de descargas de los respaldos " &
    "y reportes del sistema"
        '
        'Guna2GroupBox2
        '
        Me.Guna2GroupBox2.BorderRadius = 20
        Me.Guna2GroupBox2.Controls.Add(Me.LBL_DownloadRepDIr)
        Me.Guna2GroupBox2.Controls.Add(Me.Label20)
        Me.Guna2GroupBox2.Controls.Add(Me.BTN_ModCarpetaDescargaReportes)
        Me.Guna2GroupBox2.CustomBorderColor = System.Drawing.Color.Gray
        Me.Guna2Transition1.SetDecoration(Me.Guna2GroupBox2, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Guna2GroupBox2.FillColor = System.Drawing.Color.Transparent
        Me.Guna2GroupBox2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2GroupBox2.ForeColor = System.Drawing.Color.White
        Me.Guna2GroupBox2.Location = New System.Drawing.Point(632, 21)
        Me.Guna2GroupBox2.Name = "Guna2GroupBox2"
        Me.Guna2GroupBox2.Size = New System.Drawing.Size(550, 364)
        Me.Guna2GroupBox2.TabIndex = 123
        Me.Guna2GroupBox2.Text = "Gestión de reportes"
        Me.Guna2GroupBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'LBL_DownloadRepDIr
        '
        Me.LBL_DownloadRepDIr.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LBL_DownloadRepDIr.AutoEllipsis = True
        Me.Guna2Transition1.SetDecoration(Me.LBL_DownloadRepDIr, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.LBL_DownloadRepDIr.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_DownloadRepDIr.ForeColor = System.Drawing.Color.White
        Me.LBL_DownloadRepDIr.Location = New System.Drawing.Point(187, 141)
        Me.LBL_DownloadRepDIr.Name = "LBL_DownloadRepDIr"
        Me.LBL_DownloadRepDIr.Size = New System.Drawing.Size(352, 104)
        Me.LBL_DownloadRepDIr.TabIndex = 127
        Me.LBL_DownloadRepDIr.Text = "---"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Guna2Transition1.SetDecoration(Me.Label20, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Label20.Font = New System.Drawing.Font("Britannic Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ForeColor = System.Drawing.Color.White
        Me.Label20.Location = New System.Drawing.Point(7, 142)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(177, 17)
        Me.Label20.TabIndex = 126
        Me.Label20.Text = "Directorio de descarga:"
        '
        'BTN_ModCarpetaDescargaReportes
        '
        Me.BTN_ModCarpetaDescargaReportes.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BTN_ModCarpetaDescargaReportes.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BTN_ModCarpetaDescargaReportes.BorderRadius = 10
        Me.Guna2Transition1.SetDecoration(Me.BTN_ModCarpetaDescargaReportes, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.BTN_ModCarpetaDescargaReportes.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.BTN_ModCarpetaDescargaReportes.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BTN_ModCarpetaDescargaReportes.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BTN_ModCarpetaDescargaReportes.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BTN_ModCarpetaDescargaReportes.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BTN_ModCarpetaDescargaReportes.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BTN_ModCarpetaDescargaReportes.Font = New System.Drawing.Font("Ebrima", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_ModCarpetaDescargaReportes.ForeColor = System.Drawing.Color.White
        Me.BTN_ModCarpetaDescargaReportes.Image = Global.SistemaFacturaciónCommon.My.Resources.Resources.ICO_SaveFolder
        Me.BTN_ModCarpetaDescargaReportes.ImageSize = New System.Drawing.Size(40, 40)
        Me.BTN_ModCarpetaDescargaReportes.Location = New System.Drawing.Point(10, 59)
        Me.BTN_ModCarpetaDescargaReportes.Name = "BTN_ModCarpetaDescargaReportes"
        Me.BTN_ModCarpetaDescargaReportes.Size = New System.Drawing.Size(529, 50)
        Me.BTN_ModCarpetaDescargaReportes.TabIndex = 121
        Me.BTN_ModCarpetaDescargaReportes.Text = "Modificar carpeta de descarga de reportes"
        '
        'Guna2GroupBox1
        '
        Me.Guna2GroupBox1.BorderColor = System.Drawing.Color.Gray
        Me.Guna2GroupBox1.BorderRadius = 20
        Me.Guna2GroupBox1.Controls.Add(Me.LBL_BackUpDIr)
        Me.Guna2GroupBox1.Controls.Add(Me.Label19)
        Me.Guna2GroupBox1.Controls.Add(Me.BTN_ModBackupDir)
        Me.Guna2GroupBox1.Controls.Add(Me.BTN_Importar)
        Me.Guna2GroupBox1.Controls.Add(Me.BTN_RspaldoDB)
        Me.Guna2GroupBox1.CustomBorderColor = System.Drawing.Color.Gray
        Me.Guna2Transition1.SetDecoration(Me.Guna2GroupBox1, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Guna2GroupBox1.FillColor = System.Drawing.Color.Transparent
        Me.Guna2GroupBox1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2GroupBox1.ForeColor = System.Drawing.Color.White
        Me.Guna2GroupBox1.Location = New System.Drawing.Point(8, 21)
        Me.Guna2GroupBox1.Name = "Guna2GroupBox1"
        Me.Guna2GroupBox1.Size = New System.Drawing.Size(603, 364)
        Me.Guna2GroupBox1.TabIndex = 122
        Me.Guna2GroupBox1.Text = "Gestión de base de datos"
        Me.Guna2GroupBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'LBL_BackUpDIr
        '
        Me.LBL_BackUpDIr.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LBL_BackUpDIr.AutoEllipsis = True
        Me.Guna2Transition1.SetDecoration(Me.LBL_BackUpDIr, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.LBL_BackUpDIr.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_BackUpDIr.ForeColor = System.Drawing.Color.White
        Me.LBL_BackUpDIr.Location = New System.Drawing.Point(189, 269)
        Me.LBL_BackUpDIr.Name = "LBL_BackUpDIr"
        Me.LBL_BackUpDIr.Size = New System.Drawing.Size(403, 84)
        Me.LBL_BackUpDIr.TabIndex = 125
        Me.LBL_BackUpDIr.Text = "---"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Guna2Transition1.SetDecoration(Me.Label19, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Label19.Font = New System.Drawing.Font("Britannic Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.Color.White
        Me.Label19.Location = New System.Drawing.Point(9, 270)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(174, 17)
        Me.Label19.TabIndex = 124
        Me.Label19.Text = "Directorio de respaldo:"
        '
        'BTN_ModBackupDir
        '
        Me.BTN_ModBackupDir.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BTN_ModBackupDir.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BTN_ModBackupDir.BorderRadius = 10
        Me.Guna2Transition1.SetDecoration(Me.BTN_ModBackupDir, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.BTN_ModBackupDir.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.BTN_ModBackupDir.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BTN_ModBackupDir.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BTN_ModBackupDir.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BTN_ModBackupDir.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BTN_ModBackupDir.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BTN_ModBackupDir.Font = New System.Drawing.Font("Ebrima", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_ModBackupDir.ForeColor = System.Drawing.Color.White
        Me.BTN_ModBackupDir.Image = Global.SistemaFacturaciónCommon.My.Resources.Resources.ICO_SaveFolder
        Me.BTN_ModBackupDir.ImageSize = New System.Drawing.Size(40, 40)
        Me.BTN_ModBackupDir.Location = New System.Drawing.Point(8, 195)
        Me.BTN_ModBackupDir.Name = "BTN_ModBackupDir"
        Me.BTN_ModBackupDir.Size = New System.Drawing.Size(584, 50)
        Me.BTN_ModBackupDir.TabIndex = 123
        Me.BTN_ModBackupDir.Text = "Modificar carpeta de respaldo"
        '
        'BTN_Importar
        '
        Me.BTN_Importar.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BTN_Importar.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BTN_Importar.BorderRadius = 10
        Me.Guna2Transition1.SetDecoration(Me.BTN_Importar, Guna.UI2.AnimatorNS.DecorationType.None)
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
        Me.BTN_Importar.Location = New System.Drawing.Point(9, 127)
        Me.BTN_Importar.Margin = New System.Windows.Forms.Padding(10)
        Me.BTN_Importar.Name = "BTN_Importar"
        Me.BTN_Importar.Padding = New System.Windows.Forms.Padding(10)
        Me.BTN_Importar.Size = New System.Drawing.Size(584, 50)
        Me.BTN_Importar.TabIndex = 122
        Me.BTN_Importar.Text = "Importar base de datos"
        '
        'BTN_RspaldoDB
        '
        Me.BTN_RspaldoDB.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BTN_RspaldoDB.BorderColor = System.Drawing.Color.Lime
        Me.BTN_RspaldoDB.BorderRadius = 10
        Me.Guna2Transition1.SetDecoration(Me.BTN_RspaldoDB, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.BTN_RspaldoDB.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BTN_RspaldoDB.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BTN_RspaldoDB.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BTN_RspaldoDB.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BTN_RspaldoDB.FillColor = System.Drawing.Color.MediumSeaGreen
        Me.BTN_RspaldoDB.Font = New System.Drawing.Font("Ebrima", 14.25!, System.Drawing.FontStyle.Bold)
        Me.BTN_RspaldoDB.ForeColor = System.Drawing.Color.White
        Me.BTN_RspaldoDB.Image = Global.SistemaFacturaciónCommon.My.Resources.Resources.ICO_Export
        Me.BTN_RspaldoDB.ImageSize = New System.Drawing.Size(40, 40)
        Me.BTN_RspaldoDB.Location = New System.Drawing.Point(8, 59)
        Me.BTN_RspaldoDB.Name = "BTN_RspaldoDB"
        Me.BTN_RspaldoDB.Size = New System.Drawing.Size(584, 50)
        Me.BTN_RspaldoDB.TabIndex = 121
        Me.BTN_RspaldoDB.Text = "Respaldar base de datos"
        '
        'BTN_RegresarConfig
        '
        Me.BTN_RegresarConfig.BorderColor = System.Drawing.Color.Red
        Me.BTN_RegresarConfig.BorderRadius = 10
        Me.Guna2Transition1.SetDecoration(Me.BTN_RegresarConfig, Guna.UI2.AnimatorNS.DecorationType.None)
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
        Me.BTN_RegresarConfig.Location = New System.Drawing.Point(0, 417)
        Me.BTN_RegresarConfig.Name = "BTN_RegresarConfig"
        Me.BTN_RegresarConfig.Size = New System.Drawing.Size(1207, 65)
        Me.BTN_RegresarConfig.TabIndex = 55
        Me.BTN_RegresarConfig.Text = "Regresar"
        '
        'PAG_AutoCods
        '
        Me.PAG_AutoCods.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.PAG_AutoCods.Controls.Add(Me.Guna2GroupBox3)
        Me.PAG_AutoCods.Controls.Add(Me.Guna2Panel1)
        Me.Guna2Transition1.SetDecoration(Me.PAG_AutoCods, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.PAG_AutoCods.Location = New System.Drawing.Point(4, 44)
        Me.PAG_AutoCods.Margin = New System.Windows.Forms.Padding(0)
        Me.PAG_AutoCods.Name = "PAG_AutoCods"
        Me.PAG_AutoCods.Size = New System.Drawing.Size(1207, 482)
        Me.PAG_AutoCods.TabIndex = 1
        Me.PAG_AutoCods.Text = "Códigos automáticos"
        Me.PAG_AutoCods.ToolTipText = "Configuración los los digitos generados para los códigos de cada uno de los eleme" &
    "ntos del mantenimiento de la aplicación"
        '
        'Guna2GroupBox3
        '
        Me.Guna2GroupBox3.BorderRadius = 20
        Me.Guna2GroupBox3.Controls.Add(Me.Label7)
        Me.Guna2GroupBox3.Controls.Add(Me.SWT_ModCod)
        Me.Guna2GroupBox3.Controls.Add(Me.NUD_Prod)
        Me.Guna2GroupBox3.Controls.Add(Me.NUD_Imp)
        Me.Guna2GroupBox3.Controls.Add(Me.NUD_Cliente)
        Me.Guna2GroupBox3.Controls.Add(Me.NUD_Prov)
        Me.Guna2GroupBox3.Controls.Add(Me.NUD_Marca)
        Me.Guna2GroupBox3.Controls.Add(Me.NUD_Cat)
        Me.Guna2GroupBox3.Controls.Add(Me.NUD_Cajero)
        Me.Guna2GroupBox3.Controls.Add(Me.Label6)
        Me.Guna2GroupBox3.Controls.Add(Me.Label5)
        Me.Guna2GroupBox3.Controls.Add(Me.LBL_Proveedor)
        Me.Guna2GroupBox3.Controls.Add(Me.Label1)
        Me.Guna2GroupBox3.Controls.Add(Me.Label4)
        Me.Guna2GroupBox3.Controls.Add(Me.Label2)
        Me.Guna2GroupBox3.Controls.Add(Me.Label3)
        Me.Guna2GroupBox3.CustomBorderColor = System.Drawing.Color.Gray
        Me.Guna2Transition1.SetDecoration(Me.Guna2GroupBox3, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Guna2GroupBox3.FillColor = System.Drawing.Color.Transparent
        Me.Guna2GroupBox3.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2GroupBox3.ForeColor = System.Drawing.Color.White
        Me.Guna2GroupBox3.Location = New System.Drawing.Point(253, 49)
        Me.Guna2GroupBox3.Name = "Guna2GroupBox3"
        Me.Guna2GroupBox3.Size = New System.Drawing.Size(693, 295)
        Me.Guna2GroupBox3.TabIndex = 124
        Me.Guna2GroupBox3.Text = "Numero de digitos predeterminado en el código"
        Me.Guna2GroupBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Guna2Transition1.SetDecoration(Me.Label7, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Label7.Font = New System.Drawing.Font("Britannic Bold", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(252, 244)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(102, 23)
        Me.Label7.TabIndex = 125
        Me.Label7.Text = "Modificar:"
        '
        'SWT_ModCod
        '
        Me.SWT_ModCod.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.SWT_ModCod.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.SWT_ModCod.CheckedState.InnerBorderColor = System.Drawing.Color.White
        Me.SWT_ModCod.CheckedState.InnerColor = System.Drawing.Color.White
        Me.Guna2Transition1.SetDecoration(Me.SWT_ModCod, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.SWT_ModCod.Location = New System.Drawing.Point(360, 241)
        Me.SWT_ModCod.Name = "SWT_ModCod"
        Me.SWT_ModCod.Size = New System.Drawing.Size(72, 31)
        Me.SWT_ModCod.TabIndex = 124
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
        Me.Guna2Transition1.SetDecoration(Me.NUD_Prod, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.NUD_Prod.Enabled = False
        Me.NUD_Prod.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.NUD_Prod.Location = New System.Drawing.Point(505, 77)
        Me.NUD_Prod.Maximum = New Decimal(New Integer() {100000, 0, 0, 0})
        Me.NUD_Prod.Minimum = New Decimal(New Integer() {1000, 0, 0, -2147483648})
        Me.NUD_Prod.Name = "NUD_Prod"
        Me.NUD_Prod.Size = New System.Drawing.Size(108, 31)
        Me.NUD_Prod.TabIndex = 123
        Me.NUD_Prod.UpDownButtonFillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        '
        'NUD_Imp
        '
        Me.NUD_Imp.AutoRoundedCorners = True
        Me.NUD_Imp.BackColor = System.Drawing.Color.Transparent
        Me.NUD_Imp.BorderRadius = 14
        Me.NUD_Imp.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Guna2Transition1.SetDecoration(Me.NUD_Imp, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.NUD_Imp.Enabled = False
        Me.NUD_Imp.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.NUD_Imp.Location = New System.Drawing.Point(149, 171)
        Me.NUD_Imp.Maximum = New Decimal(New Integer() {100000, 0, 0, 0})
        Me.NUD_Imp.Minimum = New Decimal(New Integer() {1000, 0, 0, -2147483648})
        Me.NUD_Imp.Name = "NUD_Imp"
        Me.NUD_Imp.Size = New System.Drawing.Size(108, 31)
        Me.NUD_Imp.TabIndex = 122
        Me.NUD_Imp.UpDownButtonFillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        '
        'NUD_Cliente
        '
        Me.NUD_Cliente.AutoRoundedCorners = True
        Me.NUD_Cliente.BackColor = System.Drawing.Color.Transparent
        Me.NUD_Cliente.BorderRadius = 14
        Me.NUD_Cliente.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Guna2Transition1.SetDecoration(Me.NUD_Cliente, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.NUD_Cliente.Enabled = False
        Me.NUD_Cliente.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.NUD_Cliente.Location = New System.Drawing.Point(222, 77)
        Me.NUD_Cliente.Maximum = New Decimal(New Integer() {100000, 0, 0, 0})
        Me.NUD_Cliente.Minimum = New Decimal(New Integer() {1000, 0, 0, -2147483648})
        Me.NUD_Cliente.Name = "NUD_Cliente"
        Me.NUD_Cliente.Size = New System.Drawing.Size(108, 31)
        Me.NUD_Cliente.TabIndex = 121
        Me.NUD_Cliente.UpDownButtonFillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        '
        'NUD_Prov
        '
        Me.NUD_Prov.AutoRoundedCorners = True
        Me.NUD_Prov.BackColor = System.Drawing.Color.Transparent
        Me.NUD_Prov.BorderRadius = 14
        Me.NUD_Prov.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Guna2Transition1.SetDecoration(Me.NUD_Prov, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.NUD_Prov.Enabled = False
        Me.NUD_Prov.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.NUD_Prov.Location = New System.Drawing.Point(360, 77)
        Me.NUD_Prov.Maximum = New Decimal(New Integer() {100000, 0, 0, 0})
        Me.NUD_Prov.Minimum = New Decimal(New Integer() {1000, 0, 0, -2147483648})
        Me.NUD_Prov.Name = "NUD_Prov"
        Me.NUD_Prov.Size = New System.Drawing.Size(108, 31)
        Me.NUD_Prov.TabIndex = 120
        Me.NUD_Prov.UpDownButtonFillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        '
        'NUD_Marca
        '
        Me.NUD_Marca.AutoRoundedCorners = True
        Me.NUD_Marca.BackColor = System.Drawing.Color.Transparent
        Me.NUD_Marca.BorderRadius = 14
        Me.NUD_Marca.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Guna2Transition1.SetDecoration(Me.NUD_Marca, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.NUD_Marca.Enabled = False
        Me.NUD_Marca.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.NUD_Marca.Location = New System.Drawing.Point(425, 171)
        Me.NUD_Marca.Maximum = New Decimal(New Integer() {100000, 0, 0, 0})
        Me.NUD_Marca.Minimum = New Decimal(New Integer() {1000, 0, 0, -2147483648})
        Me.NUD_Marca.Name = "NUD_Marca"
        Me.NUD_Marca.Size = New System.Drawing.Size(108, 31)
        Me.NUD_Marca.TabIndex = 119
        Me.NUD_Marca.UpDownButtonFillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        '
        'NUD_Cat
        '
        Me.NUD_Cat.AutoRoundedCorners = True
        Me.NUD_Cat.BackColor = System.Drawing.Color.Transparent
        Me.NUD_Cat.BorderRadius = 14
        Me.NUD_Cat.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Guna2Transition1.SetDecoration(Me.NUD_Cat, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.NUD_Cat.Enabled = False
        Me.NUD_Cat.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.NUD_Cat.Location = New System.Drawing.Point(287, 171)
        Me.NUD_Cat.Maximum = New Decimal(New Integer() {100000, 0, 0, 0})
        Me.NUD_Cat.Minimum = New Decimal(New Integer() {1000, 0, 0, -2147483648})
        Me.NUD_Cat.Name = "NUD_Cat"
        Me.NUD_Cat.Size = New System.Drawing.Size(108, 31)
        Me.NUD_Cat.TabIndex = 118
        Me.NUD_Cat.UpDownButtonFillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        '
        'NUD_Cajero
        '
        Me.NUD_Cajero.AutoRoundedCorners = True
        Me.NUD_Cajero.BackColor = System.Drawing.Color.Transparent
        Me.NUD_Cajero.BorderRadius = 14
        Me.NUD_Cajero.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Guna2Transition1.SetDecoration(Me.NUD_Cajero, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.NUD_Cajero.Enabled = False
        Me.NUD_Cajero.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.NUD_Cajero.Location = New System.Drawing.Point(84, 77)
        Me.NUD_Cajero.Maximum = New Decimal(New Integer() {100000, 0, 0, 0})
        Me.NUD_Cajero.Minimum = New Decimal(New Integer() {1000, 0, 0, -2147483648})
        Me.NUD_Cajero.Name = "NUD_Cajero"
        Me.NUD_Cajero.Size = New System.Drawing.Size(108, 31)
        Me.NUD_Cajero.TabIndex = 117
        Me.NUD_Cajero.UpDownButtonFillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Guna2Transition1.SetDecoration(Me.Label6, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Label6.Font = New System.Drawing.Font("Britannic Bold", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(352, 51)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(123, 23)
        Me.Label6.TabIndex = 116
        Me.Label6.Text = "Proveedores"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Guna2Transition1.SetDecoration(Me.Label5, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Label5.Font = New System.Drawing.Font("Britannic Bold", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(509, 51)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(104, 23)
        Me.Label5.TabIndex = 115
        Me.Label5.Text = "Productos"
        '
        'LBL_Proveedor
        '
        Me.LBL_Proveedor.AutoSize = True
        Me.Guna2Transition1.SetDecoration(Me.LBL_Proveedor, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.LBL_Proveedor.Font = New System.Drawing.Font("Britannic Bold", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_Proveedor.ForeColor = System.Drawing.Color.White
        Me.LBL_Proveedor.Location = New System.Drawing.Point(97, 51)
        Me.LBL_Proveedor.Name = "LBL_Proveedor"
        Me.LBL_Proveedor.Size = New System.Drawing.Size(80, 23)
        Me.LBL_Proveedor.TabIndex = 110
        Me.LBL_Proveedor.Text = "Cajeros"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Guna2Transition1.SetDecoration(Me.Label1, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Label1.Font = New System.Drawing.Font("Britannic Bold", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(235, 51)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(84, 23)
        Me.Label1.TabIndex = 111
        Me.Label1.Text = "Clientes"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Guna2Transition1.SetDecoration(Me.Label4, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Label4.Font = New System.Drawing.Font("Britannic Bold", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(438, 142)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(76, 23)
        Me.Label4.TabIndex = 114
        Me.Label4.Text = "Marcas"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Guna2Transition1.SetDecoration(Me.Label2, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Label2.Font = New System.Drawing.Font("Britannic Bold", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(152, 142)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(105, 23)
        Me.Label2.TabIndex = 112
        Me.Label2.Text = "Impuestos"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Guna2Transition1.SetDecoration(Me.Label3, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Label3.Font = New System.Drawing.Font("Britannic Bold", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(286, 142)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(109, 23)
        Me.Label3.TabIndex = 113
        Me.Label3.Text = "Categorías"
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.Controls.Add(Me.BTN_ActualizarCods)
        Me.Guna2Panel1.Controls.Add(Me.BTN_Regresar)
        Me.Guna2Transition1.SetDecoration(Me.Guna2Panel1, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Guna2Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Guna2Panel1.Location = New System.Drawing.Point(0, 404)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.Size = New System.Drawing.Size(1207, 78)
        Me.Guna2Panel1.TabIndex = 101
        '
        'BTN_ActualizarCods
        '
        Me.BTN_ActualizarCods.BorderRadius = 10
        Me.Guna2Transition1.SetDecoration(Me.BTN_ActualizarCods, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.BTN_ActualizarCods.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BTN_ActualizarCods.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BTN_ActualizarCods.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BTN_ActualizarCods.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BTN_ActualizarCods.Dock = System.Windows.Forms.DockStyle.Right
        Me.BTN_ActualizarCods.FillColor = System.Drawing.Color.MediumSeaGreen
        Me.BTN_ActualizarCods.Font = New System.Drawing.Font("Ebrima", 20.25!, System.Drawing.FontStyle.Bold)
        Me.BTN_ActualizarCods.ForeColor = System.Drawing.Color.White
        Me.BTN_ActualizarCods.Image = Global.SistemaFacturaciónCommon.My.Resources.Resources.ICO_Check
        Me.BTN_ActualizarCods.ImageSize = New System.Drawing.Size(40, 40)
        Me.BTN_ActualizarCods.Location = New System.Drawing.Point(627, 0)
        Me.BTN_ActualizarCods.Name = "BTN_ActualizarCods"
        Me.BTN_ActualizarCods.Size = New System.Drawing.Size(580, 78)
        Me.BTN_ActualizarCods.TabIndex = 99
        Me.BTN_ActualizarCods.Text = "Actualizar"
        '
        'BTN_Regresar
        '
        Me.BTN_Regresar.BorderColor = System.Drawing.Color.Red
        Me.BTN_Regresar.BorderRadius = 10
        Me.Guna2Transition1.SetDecoration(Me.BTN_Regresar, Guna.UI2.AnimatorNS.DecorationType.None)
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
        Me.BTN_Regresar.Size = New System.Drawing.Size(601, 78)
        Me.BTN_Regresar.TabIndex = 98
        Me.BTN_Regresar.Text = "Regresar"
        '
        'PAG_Hablador
        '
        Me.PAG_Hablador.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.PAG_Hablador.Controls.Add(Me.Guna2GroupBox4)
        Me.PAG_Hablador.Controls.Add(Me.Guna2Panel2)
        Me.Guna2Transition1.SetDecoration(Me.PAG_Hablador, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.PAG_Hablador.Location = New System.Drawing.Point(4, 44)
        Me.PAG_Hablador.Margin = New System.Windows.Forms.Padding(0)
        Me.PAG_Hablador.Name = "PAG_Hablador"
        Me.PAG_Hablador.Size = New System.Drawing.Size(1207, 482)
        Me.PAG_Hablador.TabIndex = 2
        Me.PAG_Hablador.Text = "Habladores"
        Me.PAG_Hablador.ToolTipText = "Configuración del tamaño del texto de los habladores"
        '
        'Guna2GroupBox4
        '
        Me.Guna2GroupBox4.BorderRadius = 20
        Me.Guna2GroupBox4.Controls.Add(Me.Label10)
        Me.Guna2GroupBox4.Controls.Add(Me.SWT_ModHablador)
        Me.Guna2GroupBox4.Controls.Add(Me.NUD_SizePrecio)
        Me.Guna2GroupBox4.Controls.Add(Me.NUD_SizeProd)
        Me.Guna2GroupBox4.Controls.Add(Me.Label8)
        Me.Guna2GroupBox4.Controls.Add(Me.Label9)
        Me.Guna2GroupBox4.CustomBorderColor = System.Drawing.Color.Gray
        Me.Guna2Transition1.SetDecoration(Me.Guna2GroupBox4, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Guna2GroupBox4.FillColor = System.Drawing.Color.Transparent
        Me.Guna2GroupBox4.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2GroupBox4.ForeColor = System.Drawing.Color.White
        Me.Guna2GroupBox4.Location = New System.Drawing.Point(258, 38)
        Me.Guna2GroupBox4.Name = "Guna2GroupBox4"
        Me.Guna2GroupBox4.Size = New System.Drawing.Size(675, 297)
        Me.Guna2GroupBox4.TabIndex = 124
        Me.Guna2GroupBox4.Text = "Gestión de habladores"
        Me.Guna2GroupBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Guna2Transition1.SetDecoration(Me.Label10, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Label10.Font = New System.Drawing.Font("Britannic Bold", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(272, 256)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(102, 23)
        Me.Label10.TabIndex = 117
        Me.Label10.Text = "Modificar:"
        '
        'SWT_ModHablador
        '
        Me.SWT_ModHablador.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.SWT_ModHablador.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.SWT_ModHablador.CheckedState.InnerBorderColor = System.Drawing.Color.White
        Me.SWT_ModHablador.CheckedState.InnerColor = System.Drawing.Color.White
        Me.Guna2Transition1.SetDecoration(Me.SWT_ModHablador, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.SWT_ModHablador.Location = New System.Drawing.Point(383, 256)
        Me.SWT_ModHablador.Name = "SWT_ModHablador"
        Me.SWT_ModHablador.Size = New System.Drawing.Size(72, 31)
        Me.SWT_ModHablador.TabIndex = 116
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
        Me.Guna2Transition1.SetDecoration(Me.NUD_SizePrecio, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.NUD_SizePrecio.Enabled = False
        Me.NUD_SizePrecio.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.NUD_SizePrecio.Location = New System.Drawing.Point(414, 169)
        Me.NUD_SizePrecio.Maximum = New Decimal(New Integer() {100000, 0, 0, 0})
        Me.NUD_SizePrecio.Minimum = New Decimal(New Integer() {1000, 0, 0, -2147483648})
        Me.NUD_SizePrecio.Name = "NUD_SizePrecio"
        Me.NUD_SizePrecio.Size = New System.Drawing.Size(139, 31)
        Me.NUD_SizePrecio.TabIndex = 115
        Me.NUD_SizePrecio.UpDownButtonFillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        '
        'NUD_SizeProd
        '
        Me.NUD_SizeProd.AutoRoundedCorners = True
        Me.NUD_SizeProd.BackColor = System.Drawing.Color.Transparent
        Me.NUD_SizeProd.BorderRadius = 14
        Me.NUD_SizeProd.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Guna2Transition1.SetDecoration(Me.NUD_SizeProd, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.NUD_SizeProd.Enabled = False
        Me.NUD_SizeProd.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.NUD_SizeProd.Location = New System.Drawing.Point(414, 72)
        Me.NUD_SizeProd.Maximum = New Decimal(New Integer() {100000, 0, 0, 0})
        Me.NUD_SizeProd.Minimum = New Decimal(New Integer() {1000, 0, 0, -2147483648})
        Me.NUD_SizeProd.Name = "NUD_SizeProd"
        Me.NUD_SizeProd.Size = New System.Drawing.Size(139, 31)
        Me.NUD_SizeProd.TabIndex = 114
        Me.NUD_SizeProd.UpDownButtonFillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Guna2Transition1.SetDecoration(Me.Label8, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Label8.Font = New System.Drawing.Font("Britannic Bold", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(120, 71)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(253, 23)
        Me.Label8.TabIndex = 112
        Me.Label8.Text = "Tamaño nombre producto:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Guna2Transition1.SetDecoration(Me.Label9, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Label9.Font = New System.Drawing.Font("Britannic Bold", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(120, 171)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(185, 23)
        Me.Label9.TabIndex = 113
        Me.Label9.Text = "Tamaño del precio:"
        '
        'Guna2Panel2
        '
        Me.Guna2Panel2.Controls.Add(Me.BTN_ConfigRegHablador)
        Me.Guna2Panel2.Controls.Add(Me.BTN_ActualizarHablador)
        Me.Guna2Transition1.SetDecoration(Me.Guna2Panel2, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Guna2Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Guna2Panel2.Location = New System.Drawing.Point(0, 413)
        Me.Guna2Panel2.Name = "Guna2Panel2"
        Me.Guna2Panel2.Size = New System.Drawing.Size(1207, 69)
        Me.Guna2Panel2.TabIndex = 112
        '
        'BTN_ConfigRegHablador
        '
        Me.BTN_ConfigRegHablador.BorderColor = System.Drawing.Color.Red
        Me.BTN_ConfigRegHablador.BorderRadius = 10
        Me.Guna2Transition1.SetDecoration(Me.BTN_ConfigRegHablador, Guna.UI2.AnimatorNS.DecorationType.None)
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
        Me.BTN_ConfigRegHablador.Size = New System.Drawing.Size(590, 69)
        Me.BTN_ConfigRegHablador.TabIndex = 100
        Me.BTN_ConfigRegHablador.Text = "Regresar"
        '
        'BTN_ActualizarHablador
        '
        Me.BTN_ActualizarHablador.BorderRadius = 10
        Me.Guna2Transition1.SetDecoration(Me.BTN_ActualizarHablador, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.BTN_ActualizarHablador.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BTN_ActualizarHablador.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BTN_ActualizarHablador.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BTN_ActualizarHablador.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BTN_ActualizarHablador.Dock = System.Windows.Forms.DockStyle.Right
        Me.BTN_ActualizarHablador.FillColor = System.Drawing.Color.MediumSeaGreen
        Me.BTN_ActualizarHablador.Font = New System.Drawing.Font("Ebrima", 20.25!, System.Drawing.FontStyle.Bold)
        Me.BTN_ActualizarHablador.ForeColor = System.Drawing.Color.White
        Me.BTN_ActualizarHablador.Image = Global.SistemaFacturaciónCommon.My.Resources.Resources.ICO_Check
        Me.BTN_ActualizarHablador.ImageSize = New System.Drawing.Size(40, 40)
        Me.BTN_ActualizarHablador.Location = New System.Drawing.Point(625, 0)
        Me.BTN_ActualizarHablador.Name = "BTN_ActualizarHablador"
        Me.BTN_ActualizarHablador.Size = New System.Drawing.Size(582, 69)
        Me.BTN_ActualizarHablador.TabIndex = 101
        Me.BTN_ActualizarHablador.Text = "Actualizar"
        '
        'BTN_CerrarApp
        '
        Me.BTN_CerrarApp.BackColor = System.Drawing.Color.Transparent
        Me.BTN_CerrarApp.CheckedState.ImageSize = New System.Drawing.Size(40, 40)
        Me.Guna2Transition1.SetDecoration(Me.BTN_CerrarApp, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.BTN_CerrarApp.HoverState.Image = Global.SistemaFacturaciónCommon.My.Resources.Resources.ICO_CerrarCol
        Me.BTN_CerrarApp.HoverState.ImageSize = New System.Drawing.Size(43, 43)
        Me.BTN_CerrarApp.Image = Global.SistemaFacturaciónCommon.My.Resources.Resources.ICO_Cerrar
        Me.BTN_CerrarApp.ImageOffset = New System.Drawing.Point(0, 0)
        Me.BTN_CerrarApp.ImageRotate = 0!
        Me.BTN_CerrarApp.ImageSize = New System.Drawing.Size(40, 40)
        Me.BTN_CerrarApp.Location = New System.Drawing.Point(1163, 12)
        Me.BTN_CerrarApp.Name = "BTN_CerrarApp"
        Me.BTN_CerrarApp.PressedState.ImageSize = New System.Drawing.Size(64, 64)
        Me.BTN_CerrarApp.Size = New System.Drawing.Size(40, 40)
        Me.BTN_CerrarApp.TabIndex = 123
        '
        'Guna2Transition1
        '
        Me.Guna2Transition1.AnimationType = Guna.UI2.AnimatorNS.AnimationType.Scale
        Me.Guna2Transition1.Cursor = Nothing
        Animation1.AnimateOnlyDifferences = True
        Animation1.BlindCoeff = CType(resources.GetObject("Animation1.BlindCoeff"), System.Drawing.PointF)
        Animation1.LeafCoeff = 0!
        Animation1.MaxTime = 1.0!
        Animation1.MinTime = 0!
        Animation1.MosaicCoeff = CType(resources.GetObject("Animation1.MosaicCoeff"), System.Drawing.PointF)
        Animation1.MosaicShift = CType(resources.GetObject("Animation1.MosaicShift"), System.Drawing.PointF)
        Animation1.MosaicSize = 0
        Animation1.Padding = New System.Windows.Forms.Padding(0)
        Animation1.RotateCoeff = 0!
        Animation1.RotateLimit = 0!
        Animation1.ScaleCoeff = CType(resources.GetObject("Animation1.ScaleCoeff"), System.Drawing.PointF)
        Animation1.SlideCoeff = CType(resources.GetObject("Animation1.SlideCoeff"), System.Drawing.PointF)
        Animation1.TimeCoeff = 0!
        Animation1.TransparencyCoeff = 0!
        Me.Guna2Transition1.DefaultAnimation = Animation1
        '
        'Guna2PictureBox2
        '
        Me.Guna2Transition1.SetDecoration(Me.Guna2PictureBox2, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Guna2PictureBox2.Image = CType(resources.GetObject("Guna2PictureBox2.Image"), System.Drawing.Image)
        Me.Guna2PictureBox2.ImageRotate = 0!
        Me.Guna2PictureBox2.Location = New System.Drawing.Point(394, -85)
        Me.Guna2PictureBox2.Name = "Guna2PictureBox2"
        Me.Guna2PictureBox2.Size = New System.Drawing.Size(363, 310)
        Me.Guna2PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Guna2PictureBox2.TabIndex = 55
        Me.Guna2PictureBox2.TabStop = False
        '
        'PAG_FavProd
        '
        Me.PAG_FavProd.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.PAG_FavProd.Controls.Add(Me.TableLayoutPanel1)
        Me.Guna2Transition1.SetDecoration(Me.PAG_FavProd, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.PAG_FavProd.Location = New System.Drawing.Point(4, 44)
        Me.PAG_FavProd.Name = "PAG_FavProd"
        Me.PAG_FavProd.Padding = New System.Windows.Forms.Padding(3)
        Me.PAG_FavProd.Size = New System.Drawing.Size(1207, 482)
        Me.PAG_FavProd.TabIndex = 4
        Me.PAG_FavProd.Text = "Productos favoritos"
        Me.PAG_FavProd.ToolTipText = "Configuración de los botones de productos favoritos que se muestran en la caja"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.PAN_InfoPageConfigFavProd, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.PAN_BtnContainer, 0, 1)
        Me.Guna2Transition1.SetDecoration(Me.TableLayoutPanel1, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 58.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(1201, 476)
        Me.TableLayoutPanel1.TabIndex = 120
        '
        'PAN_InfoPageConfigFavProd
        '
        Me.PAN_InfoPageConfigFavProd.Controls.Add(Me.TBL_DivSeccionsPageInfo)
        Me.Guna2Transition1.SetDecoration(Me.PAN_InfoPageConfigFavProd, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.PAN_InfoPageConfigFavProd.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PAN_InfoPageConfigFavProd.Location = New System.Drawing.Point(3, 3)
        Me.PAN_InfoPageConfigFavProd.Name = "PAN_InfoPageConfigFavProd"
        Me.PAN_InfoPageConfigFavProd.Size = New System.Drawing.Size(1195, 412)
        Me.PAN_InfoPageConfigFavProd.TabIndex = 0
        '
        'TBL_DivSeccionsPageInfo
        '
        Me.TBL_DivSeccionsPageInfo.ColumnCount = 2
        Me.TBL_DivSeccionsPageInfo.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TBL_DivSeccionsPageInfo.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TBL_DivSeccionsPageInfo.Controls.Add(Me.PAN_TBLLayoutCell2, 1, 0)
        Me.TBL_DivSeccionsPageInfo.Controls.Add(Me.PAN_TBLLayoutCell1, 0, 0)
        Me.Guna2Transition1.SetDecoration(Me.TBL_DivSeccionsPageInfo, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.TBL_DivSeccionsPageInfo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TBL_DivSeccionsPageInfo.Location = New System.Drawing.Point(0, 0)
        Me.TBL_DivSeccionsPageInfo.Name = "TBL_DivSeccionsPageInfo"
        Me.TBL_DivSeccionsPageInfo.RowCount = 1
        Me.TBL_DivSeccionsPageInfo.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TBL_DivSeccionsPageInfo.Size = New System.Drawing.Size(1195, 412)
        Me.TBL_DivSeccionsPageInfo.TabIndex = 0
        '
        'PAN_TBLLayoutCell2
        '
        Me.PAN_TBLLayoutCell2.Controls.Add(Me.PAN_ProdFavContainer)
        Me.Guna2Transition1.SetDecoration(Me.PAN_TBLLayoutCell2, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.PAN_TBLLayoutCell2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PAN_TBLLayoutCell2.Location = New System.Drawing.Point(600, 3)
        Me.PAN_TBLLayoutCell2.Name = "PAN_TBLLayoutCell2"
        Me.PAN_TBLLayoutCell2.Size = New System.Drawing.Size(592, 406)
        Me.PAN_TBLLayoutCell2.TabIndex = 112
        '
        'PAN_ProdFavContainer
        '
        Me.PAN_ProdFavContainer.Controls.Add(Me.PAN_DGVFavContainer)
        Me.PAN_ProdFavContainer.Controls.Add(Me.PAN_HeaderFavContainer)
        Me.Guna2Transition1.SetDecoration(Me.PAN_ProdFavContainer, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.PAN_ProdFavContainer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PAN_ProdFavContainer.Location = New System.Drawing.Point(0, 0)
        Me.PAN_ProdFavContainer.Name = "PAN_ProdFavContainer"
        Me.PAN_ProdFavContainer.Size = New System.Drawing.Size(592, 406)
        Me.PAN_ProdFavContainer.TabIndex = 122
        '
        'PAN_DGVFavContainer
        '
        Me.PAN_DGVFavContainer.Controls.Add(Me.BTN_MoveDown)
        Me.PAN_DGVFavContainer.Controls.Add(Me.BTN_MoveUp)
        Me.PAN_DGVFavContainer.Controls.Add(Me.DGV_FavProd)
        Me.Guna2Transition1.SetDecoration(Me.PAN_DGVFavContainer, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.PAN_DGVFavContainer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PAN_DGVFavContainer.Location = New System.Drawing.Point(0, 57)
        Me.PAN_DGVFavContainer.Name = "PAN_DGVFavContainer"
        Me.PAN_DGVFavContainer.Size = New System.Drawing.Size(592, 349)
        Me.PAN_DGVFavContainer.TabIndex = 113
        '
        'BTN_MoveDown
        '
        Me.BTN_MoveDown.Animated = True
        Me.BTN_MoveDown.BorderRadius = 10
        Me.BTN_MoveDown.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Guna2Transition1.SetDecoration(Me.BTN_MoveDown, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.BTN_MoveDown.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BTN_MoveDown.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BTN_MoveDown.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BTN_MoveDown.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BTN_MoveDown.FillColor = System.Drawing.Color.Transparent
        Me.BTN_MoveDown.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_MoveDown.ForeColor = System.Drawing.Color.White
        Me.BTN_MoveDown.HoverState.Image = Global.SistemaFacturaciónCommon.My.Resources.Resources.ICO_DownCol
        Me.BTN_MoveDown.Image = Global.SistemaFacturaciónCommon.My.Resources.Resources.ICO_DownArrow
        Me.BTN_MoveDown.ImageSize = New System.Drawing.Size(60, 60)
        Me.BTN_MoveDown.Location = New System.Drawing.Point(519, 217)
        Me.BTN_MoveDown.Name = "BTN_MoveDown"
        Me.BTN_MoveDown.Size = New System.Drawing.Size(65, 58)
        Me.BTN_MoveDown.TabIndex = 114
        '
        'BTN_MoveUp
        '
        Me.BTN_MoveUp.Animated = True
        Me.BTN_MoveUp.BorderRadius = 10
        Me.BTN_MoveUp.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Guna2Transition1.SetDecoration(Me.BTN_MoveUp, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.BTN_MoveUp.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BTN_MoveUp.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BTN_MoveUp.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BTN_MoveUp.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BTN_MoveUp.FillColor = System.Drawing.Color.Transparent
        Me.BTN_MoveUp.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_MoveUp.ForeColor = System.Drawing.Color.White
        Me.BTN_MoveUp.HoverState.Image = Global.SistemaFacturaciónCommon.My.Resources.Resources.ICO_UpCol
        Me.BTN_MoveUp.Image = Global.SistemaFacturaciónCommon.My.Resources.Resources.ICO_UpArrow
        Me.BTN_MoveUp.ImageSize = New System.Drawing.Size(60, 60)
        Me.BTN_MoveUp.Location = New System.Drawing.Point(519, 83)
        Me.BTN_MoveUp.Name = "BTN_MoveUp"
        Me.BTN_MoveUp.Size = New System.Drawing.Size(65, 58)
        Me.BTN_MoveUp.TabIndex = 113
        '
        'DGV_FavProd
        '
        Me.DGV_FavProd.AllowDrop = True
        Me.DGV_FavProd.AllowUserToAddRows = False
        Me.DGV_FavProd.AllowUserToDeleteRows = False
        Me.DGV_FavProd.AllowUserToResizeColumns = False
        Me.DGV_FavProd.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.DGV_FavProd.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DGV_FavProd.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGV_FavProd.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DGV_FavProd.ColumnHeadersHeight = 20
        Me.DGV_FavProd.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ID, Me.codigo, Me.nombre, Me.colorProd})
        Me.DGV_FavProd.ContextMenuStrip = Me.MNU_CONTX_FAV
        Me.Guna2Transition1.SetDecoration(Me.DGV_FavProd, Guna.UI2.AnimatorNS.DecorationType.None)
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DGV_FavProd.DefaultCellStyle = DataGridViewCellStyle3
        Me.DGV_FavProd.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DGV_FavProd.Location = New System.Drawing.Point(14, 25)
        Me.DGV_FavProd.MultiSelect = False
        Me.DGV_FavProd.Name = "DGV_FavProd"
        Me.DGV_FavProd.ReadOnly = True
        Me.DGV_FavProd.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGV_FavProd.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.DGV_FavProd.RowHeadersVisible = False
        Me.DGV_FavProd.Size = New System.Drawing.Size(499, 305)
        Me.DGV_FavProd.TabIndex = 110
        Me.DGV_FavProd.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.DGV_FavProd.ThemeStyle.AlternatingRowsStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DGV_FavProd.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.SystemColors.ControlText
        Me.DGV_FavProd.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DGV_FavProd.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.DGV_FavProd.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.DGV_FavProd.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DGV_FavProd.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.DGV_FavProd.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.DGV_FavProd.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DGV_FavProd.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.DGV_FavProd.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.DGV_FavProd.ThemeStyle.HeaderStyle.Height = 20
        Me.DGV_FavProd.ThemeStyle.ReadOnly = True
        Me.DGV_FavProd.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.DGV_FavProd.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.DGV_FavProd.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DGV_FavProd.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.DGV_FavProd.ThemeStyle.RowsStyle.Height = 22
        Me.DGV_FavProd.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DGV_FavProd.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        '
        'ID
        '
        Me.ID.HeaderText = "ID"
        Me.ID.Name = "ID"
        Me.ID.ReadOnly = True
        Me.ID.Visible = False
        '
        'codigo
        '
        Me.codigo.HeaderText = "Código"
        Me.codigo.Name = "codigo"
        Me.codigo.ReadOnly = True
        '
        'nombre
        '
        Me.nombre.FillWeight = 233.6328!
        Me.nombre.HeaderText = "Producto"
        Me.nombre.Name = "nombre"
        Me.nombre.ReadOnly = True
        '
        'colorProd
        '
        Me.colorProd.FillWeight = 52.7853!
        Me.colorProd.HeaderText = "Color"
        Me.colorProd.Name = "colorProd"
        Me.colorProd.ReadOnly = True
        Me.colorProd.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        '
        'PAN_HeaderFavContainer
        '
        Me.PAN_HeaderFavContainer.Controls.Add(Me.LBL_FavTitle)
        Me.Guna2Transition1.SetDecoration(Me.PAN_HeaderFavContainer, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.PAN_HeaderFavContainer.Dock = System.Windows.Forms.DockStyle.Top
        Me.PAN_HeaderFavContainer.Location = New System.Drawing.Point(0, 0)
        Me.PAN_HeaderFavContainer.Name = "PAN_HeaderFavContainer"
        Me.PAN_HeaderFavContainer.Size = New System.Drawing.Size(592, 57)
        Me.PAN_HeaderFavContainer.TabIndex = 112
        '
        'LBL_FavTitle
        '
        Me.Guna2Transition1.SetDecoration(Me.LBL_FavTitle, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.LBL_FavTitle.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LBL_FavTitle.Font = New System.Drawing.Font("Britannic Bold", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_FavTitle.ForeColor = System.Drawing.Color.White
        Me.LBL_FavTitle.Location = New System.Drawing.Point(0, 0)
        Me.LBL_FavTitle.Name = "LBL_FavTitle"
        Me.LBL_FavTitle.Size = New System.Drawing.Size(592, 57)
        Me.LBL_FavTitle.TabIndex = 111
        Me.LBL_FavTitle.Text = "Favoritos (Seleccionar para cambiar el color)"
        Me.LBL_FavTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PAN_TBLLayoutCell1
        '
        Me.PAN_TBLLayoutCell1.Controls.Add(Me.TBL_TBLLayoutCell1)
        Me.Guna2Transition1.SetDecoration(Me.PAN_TBLLayoutCell1, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.PAN_TBLLayoutCell1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PAN_TBLLayoutCell1.Location = New System.Drawing.Point(3, 3)
        Me.PAN_TBLLayoutCell1.Name = "PAN_TBLLayoutCell1"
        Me.PAN_TBLLayoutCell1.Size = New System.Drawing.Size(591, 406)
        Me.PAN_TBLLayoutCell1.TabIndex = 0
        '
        'TBL_TBLLayoutCell1
        '
        Me.TBL_TBLLayoutCell1.ColumnCount = 1
        Me.TBL_TBLLayoutCell1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TBL_TBLLayoutCell1.Controls.Add(Me.TXT_BuscarProd, 0, 0)
        Me.TBL_TBLLayoutCell1.Controls.Add(Me.PAN_DGVSearchContainer, 0, 1)
        Me.Guna2Transition1.SetDecoration(Me.TBL_TBLLayoutCell1, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.TBL_TBLLayoutCell1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TBL_TBLLayoutCell1.Location = New System.Drawing.Point(0, 0)
        Me.TBL_TBLLayoutCell1.Name = "TBL_TBLLayoutCell1"
        Me.TBL_TBLLayoutCell1.RowCount = 2
        Me.TBL_TBLLayoutCell1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.31527!))
        Me.TBL_TBLLayoutCell1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 87.68473!))
        Me.TBL_TBLLayoutCell1.Size = New System.Drawing.Size(591, 406)
        Me.TBL_TBLLayoutCell1.TabIndex = 113
        '
        'TXT_BuscarProd
        '
        Me.TXT_BuscarProd.BorderRadius = 10
        Me.TXT_BuscarProd.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Guna2Transition1.SetDecoration(Me.TXT_BuscarProd, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.TXT_BuscarProd.DefaultText = ""
        Me.TXT_BuscarProd.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TXT_BuscarProd.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TXT_BuscarProd.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXT_BuscarProd.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXT_BuscarProd.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TXT_BuscarProd.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXT_BuscarProd.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.TXT_BuscarProd.ForeColor = System.Drawing.Color.Black
        Me.TXT_BuscarProd.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXT_BuscarProd.IconRight = Global.SistemaFacturaciónCommon.My.Resources.Resources.ICO_SearchCol
        Me.TXT_BuscarProd.IconRightOffset = New System.Drawing.Point(10, 0)
        Me.TXT_BuscarProd.IconRightSize = New System.Drawing.Size(40, 40)
        Me.TXT_BuscarProd.Location = New System.Drawing.Point(3, 3)
        Me.TXT_BuscarProd.Name = "TXT_BuscarProd"
        Me.TXT_BuscarProd.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TXT_BuscarProd.PlaceholderText = "Buscar producto"
        Me.TXT_BuscarProd.SelectedText = ""
        Me.TXT_BuscarProd.Size = New System.Drawing.Size(585, 44)
        Me.TXT_BuscarProd.TabIndex = 112
        '
        'PAN_DGVSearchContainer
        '
        Me.PAN_DGVSearchContainer.Controls.Add(Me.DGV_BProd)
        Me.Guna2Transition1.SetDecoration(Me.PAN_DGVSearchContainer, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.PAN_DGVSearchContainer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PAN_DGVSearchContainer.Location = New System.Drawing.Point(3, 53)
        Me.PAN_DGVSearchContainer.Name = "PAN_DGVSearchContainer"
        Me.PAN_DGVSearchContainer.Size = New System.Drawing.Size(585, 350)
        Me.PAN_DGVSearchContainer.TabIndex = 113
        '
        'DGV_BProd
        '
        Me.DGV_BProd.AllowUserToAddRows = False
        Me.DGV_BProd.AllowUserToDeleteRows = False
        Me.DGV_BProd.AllowUserToResizeRows = False
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.DGV_BProd.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle5
        Me.DGV_BProd.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGV_BProd.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.DGV_BProd.ColumnHeadersHeight = 20
        Me.DGV_BProd.ContextMenuStrip = Me.MNU_CONTX_BUSCAR
        Me.Guna2Transition1.SetDecoration(Me.DGV_BProd, Guna.UI2.AnimatorNS.DecorationType.None)
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DGV_BProd.DefaultCellStyle = DataGridViewCellStyle7
        Me.DGV_BProd.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DGV_BProd.Location = New System.Drawing.Point(24, 29)
        Me.DGV_BProd.MultiSelect = False
        Me.DGV_BProd.Name = "DGV_BProd"
        Me.DGV_BProd.ReadOnly = True
        Me.DGV_BProd.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGV_BProd.RowHeadersDefaultCellStyle = DataGridViewCellStyle8
        Me.DGV_BProd.RowHeadersVisible = False
        Me.DGV_BProd.Size = New System.Drawing.Size(541, 305)
        Me.DGV_BProd.TabIndex = 114
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
        'PAN_BtnContainer
        '
        Me.PAN_BtnContainer.Controls.Add(Me.BTN_Actualizar)
        Me.PAN_BtnContainer.Controls.Add(Me.Guna2Button1)
        Me.Guna2Transition1.SetDecoration(Me.PAN_BtnContainer, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.PAN_BtnContainer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PAN_BtnContainer.Location = New System.Drawing.Point(3, 421)
        Me.PAN_BtnContainer.Name = "PAN_BtnContainer"
        Me.PAN_BtnContainer.Size = New System.Drawing.Size(1195, 52)
        Me.PAN_BtnContainer.TabIndex = 2
        '
        'BTN_Actualizar
        '
        Me.BTN_Actualizar.BorderColor = System.Drawing.Color.MediumSeaGreen
        Me.BTN_Actualizar.BorderRadius = 10
        Me.Guna2Transition1.SetDecoration(Me.BTN_Actualizar, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.BTN_Actualizar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.BTN_Actualizar.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BTN_Actualizar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BTN_Actualizar.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BTN_Actualizar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BTN_Actualizar.FillColor = System.Drawing.Color.MediumSeaGreen
        Me.BTN_Actualizar.Font = New System.Drawing.Font("Ebrima", 20.25!, System.Drawing.FontStyle.Bold)
        Me.BTN_Actualizar.ForeColor = System.Drawing.Color.White
        Me.BTN_Actualizar.Image = Global.SistemaFacturaciónCommon.My.Resources.Resources.ICO_Check
        Me.BTN_Actualizar.ImageSize = New System.Drawing.Size(40, 40)
        Me.BTN_Actualizar.Location = New System.Drawing.Point(614, 0)
        Me.BTN_Actualizar.Name = "BTN_Actualizar"
        Me.BTN_Actualizar.Size = New System.Drawing.Size(570, 52)
        Me.BTN_Actualizar.TabIndex = 57
        Me.BTN_Actualizar.Text = "Actualizar"
        '
        'Guna2Button1
        '
        Me.Guna2Button1.BorderColor = System.Drawing.Color.Red
        Me.Guna2Button1.BorderRadius = 10
        Me.Guna2Transition1.SetDecoration(Me.Guna2Button1, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Guna2Button1.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Guna2Button1.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Guna2Button1.Font = New System.Drawing.Font("Ebrima", 20.25!, System.Drawing.FontStyle.Bold)
        Me.Guna2Button1.ForeColor = System.Drawing.Color.White
        Me.Guna2Button1.Image = Global.SistemaFacturaciónCommon.My.Resources.Resources.ICO_Back
        Me.Guna2Button1.ImageSize = New System.Drawing.Size(40, 40)
        Me.Guna2Button1.Location = New System.Drawing.Point(6, 0)
        Me.Guna2Button1.Name = "Guna2Button1"
        Me.Guna2Button1.Size = New System.Drawing.Size(565, 52)
        Me.Guna2Button1.TabIndex = 56
        Me.Guna2Button1.Text = "Regresar"
        '
        'MNU_CONTX_BUSCAR
        '
        Me.Guna2Transition1.SetDecoration(Me.MNU_CONTX_BUSCAR, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.MNU_CONTX_BUSCAR.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MNU_CONTX_BUSCAR.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MNU_SELECCIONAR})
        Me.MNU_CONTX_BUSCAR.Name = "MNU_CONTX"
        Me.MNU_CONTX_BUSCAR.RenderStyle.ArrowColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.MNU_CONTX_BUSCAR.RenderStyle.BorderColor = System.Drawing.Color.Gainsboro
        Me.MNU_CONTX_BUSCAR.RenderStyle.ColorTable = Nothing
        Me.MNU_CONTX_BUSCAR.RenderStyle.RoundedEdges = True
        Me.MNU_CONTX_BUSCAR.RenderStyle.SelectionArrowColor = System.Drawing.Color.White
        Me.MNU_CONTX_BUSCAR.RenderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.MNU_CONTX_BUSCAR.RenderStyle.SelectionForeColor = System.Drawing.Color.White
        Me.MNU_CONTX_BUSCAR.RenderStyle.SeparatorColor = System.Drawing.Color.Gainsboro
        Me.MNU_CONTX_BUSCAR.RenderStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault
        Me.MNU_CONTX_BUSCAR.Size = New System.Drawing.Size(149, 30)
        '
        'MNU_SELECCIONAR
        '
        Me.MNU_SELECCIONAR.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.MNU_SELECCIONAR.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MNU_SELECCIONAR.ForeColor = System.Drawing.Color.White
        Me.MNU_SELECCIONAR.Image = Global.SistemaFacturaciónCommon.My.Resources.Resources.ICO_MasCol
        Me.MNU_SELECCIONAR.Name = "MNU_SELECCIONAR"
        Me.MNU_SELECCIONAR.Size = New System.Drawing.Size(148, 26)
        Me.MNU_SELECCIONAR.Text = "Seleccionar"
        '
        'MNU_CONTX_FAV
        '
        Me.Guna2Transition1.SetDecoration(Me.MNU_CONTX_FAV, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.MNU_CONTX_FAV.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MNU_CONTX_FAV.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MNU_ELIMINAR})
        Me.MNU_CONTX_FAV.Name = "MNU_CONTX"
        Me.MNU_CONTX_FAV.RenderStyle.ArrowColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.MNU_CONTX_FAV.RenderStyle.BorderColor = System.Drawing.Color.Gainsboro
        Me.MNU_CONTX_FAV.RenderStyle.ColorTable = Nothing
        Me.MNU_CONTX_FAV.RenderStyle.RoundedEdges = True
        Me.MNU_CONTX_FAV.RenderStyle.SelectionArrowColor = System.Drawing.Color.White
        Me.MNU_CONTX_FAV.RenderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.MNU_CONTX_FAV.RenderStyle.SelectionForeColor = System.Drawing.Color.White
        Me.MNU_CONTX_FAV.RenderStyle.SeparatorColor = System.Drawing.Color.Gainsboro
        Me.MNU_CONTX_FAV.RenderStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault
        Me.MNU_CONTX_FAV.Size = New System.Drawing.Size(128, 30)
        '
        'MNU_ELIMINAR
        '
        Me.MNU_ELIMINAR.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.MNU_ELIMINAR.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MNU_ELIMINAR.ForeColor = System.Drawing.Color.White
        Me.MNU_ELIMINAR.Image = Global.SistemaFacturaciónCommon.My.Resources.Resources.ICO_Eliminar
        Me.MNU_ELIMINAR.Name = "MNU_ELIMINAR"
        Me.MNU_ELIMINAR.Size = New System.Drawing.Size(127, 26)
        Me.MNU_ELIMINAR.Text = "Eliminar"
        '
        'ConfigGeneral
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1215, 679)
        Me.Controls.Add(Me.BTN_CerrarApp)
        Me.Controls.Add(Me.TCO_Config)
        Me.Controls.Add(Me.Guna2PictureBox2)
        Me.Guna2Transition1.SetDecoration(Me, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Name = "ConfigGeneral"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Configuración general"
        Me.TCO_Config.ResumeLayout(False)
        Me.PAG_Info.ResumeLayout(False)
        Me.PAG_Info.PerformLayout()
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PAG_DBReportes.ResumeLayout(False)
        Me.Guna2GroupBox2.ResumeLayout(False)
        Me.Guna2GroupBox2.PerformLayout()
        Me.Guna2GroupBox1.ResumeLayout(False)
        Me.Guna2GroupBox1.PerformLayout()
        Me.PAG_AutoCods.ResumeLayout(False)
        Me.Guna2GroupBox3.ResumeLayout(False)
        Me.Guna2GroupBox3.PerformLayout()
        CType(Me.NUD_Prod, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NUD_Imp, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NUD_Cliente, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NUD_Prov, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NUD_Marca, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NUD_Cat, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NUD_Cajero, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Guna2Panel1.ResumeLayout(False)
        Me.PAG_Hablador.ResumeLayout(False)
        Me.Guna2GroupBox4.ResumeLayout(False)
        Me.Guna2GroupBox4.PerformLayout()
        CType(Me.NUD_SizePrecio, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NUD_SizeProd, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Guna2Panel2.ResumeLayout(False)
        CType(Me.Guna2PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PAG_FavProd.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.PAN_InfoPageConfigFavProd.ResumeLayout(False)
        Me.TBL_DivSeccionsPageInfo.ResumeLayout(False)
        Me.PAN_TBLLayoutCell2.ResumeLayout(False)
        Me.PAN_ProdFavContainer.ResumeLayout(False)
        Me.PAN_DGVFavContainer.ResumeLayout(False)
        CType(Me.DGV_FavProd, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PAN_HeaderFavContainer.ResumeLayout(False)
        Me.PAN_TBLLayoutCell1.ResumeLayout(False)
        Me.TBL_TBLLayoutCell1.ResumeLayout(False)
        Me.PAN_DGVSearchContainer.ResumeLayout(False)
        CType(Me.DGV_BProd, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PAN_BtnContainer.ResumeLayout(False)
        Me.MNU_CONTX_BUSCAR.ResumeLayout(False)
        Me.MNU_CONTX_FAV.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Guna2BorderlessForm1 As Guna.UI2.WinForms.Guna2BorderlessForm
    Friend WithEvents OFD_ImportarDB As OpenFileDialog
    Friend WithEvents OFD_ModDirDB As OpenFileDialog
    Friend WithEvents OFD_ModBackUpDir As FolderBrowserDialog
    Friend WithEvents TCO_Config As Guna.UI2.WinForms.Guna2TabControl
    Friend WithEvents PAG_DBReportes As TabPage
    Friend WithEvents PAG_AutoCods As TabPage
    Friend WithEvents Guna2PictureBox2 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents BTN_RegresarConfig As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents PAG_Hablador As TabPage
    Friend WithEvents BTN_ActualizarCods As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BTN_Regresar As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BTN_ActualizarHablador As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BTN_ConfigRegHablador As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2Panel2 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents BTN_CerrarApp As Guna.UI2.WinForms.Guna2ImageButton
    Friend WithEvents PAG_Info As TabPage
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents lbl_versionGeneralConfig As Label
    Friend WithEvents Guna2Transition1 As Guna.UI2.WinForms.Guna2Transition
    Friend WithEvents Label15 As Label
    Friend WithEvents SWT_AutoUpdate As Guna.UI2.WinForms.Guna2ToggleSwitch
    Friend WithEvents BTN_CheckForUpdates As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Label16 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents btn_RegInfoConfig As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2PictureBox1 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents BTN_ModCarpetaDescargaReportes As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2GroupBox1 As Guna.UI2.WinForms.Guna2GroupBox
    Friend WithEvents LBL_BackUpDIr As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents BTN_ModBackupDir As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BTN_Importar As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BTN_RspaldoDB As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2GroupBox2 As Guna.UI2.WinForms.Guna2GroupBox
    Friend WithEvents LBL_DownloadRepDIr As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents Guna2GroupBox3 As Guna.UI2.WinForms.Guna2GroupBox
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
    Friend WithEvents Guna2GroupBox4 As Guna.UI2.WinForms.Guna2GroupBox
    Friend WithEvents Label10 As Label
    Friend WithEvents SWT_ModHablador As Guna.UI2.WinForms.Guna2ToggleSwitch
    Friend WithEvents NUD_SizePrecio As Guna.UI2.WinForms.Guna2NumericUpDown
    Friend WithEvents NUD_SizeProd As Guna.UI2.WinForms.Guna2NumericUpDown
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents PAG_FavProd As TabPage
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents PAN_InfoPageConfigFavProd As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents TBL_DivSeccionsPageInfo As TableLayoutPanel
    Friend WithEvents PAN_TBLLayoutCell2 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents PAN_ProdFavContainer As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents PAN_DGVFavContainer As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents BTN_MoveDown As Guna.UI2.WinForms.Guna2TileButton
    Friend WithEvents BTN_MoveUp As Guna.UI2.WinForms.Guna2TileButton
    Friend WithEvents DGV_FavProd As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents ID As DataGridViewTextBoxColumn
    Friend WithEvents codigo As DataGridViewTextBoxColumn
    Friend WithEvents nombre As DataGridViewTextBoxColumn
    Friend WithEvents colorProd As DataGridViewTextBoxColumn
    Friend WithEvents PAN_HeaderFavContainer As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents LBL_FavTitle As Label
    Friend WithEvents PAN_TBLLayoutCell1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents TBL_TBLLayoutCell1 As TableLayoutPanel
    Friend WithEvents TXT_BuscarProd As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents PAN_DGVSearchContainer As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents DGV_BProd As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents PAN_BtnContainer As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents BTN_Actualizar As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2Button1 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents MNU_CONTX_BUSCAR As Guna.UI2.WinForms.Guna2ContextMenuStrip
    Friend WithEvents MNU_SELECCIONAR As ToolStripMenuItem
    Friend WithEvents MNU_CONTX_FAV As Guna.UI2.WinForms.Guna2ContextMenuStrip
    Friend WithEvents MNU_ELIMINAR As ToolStripMenuItem
End Class

End Namespace