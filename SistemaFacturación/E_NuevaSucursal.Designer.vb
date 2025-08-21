<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class E_NuevaSucursal
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(E_NuevaSucursal))
        Me.Guna2BorderlessForm1 = New Guna.UI2.WinForms.Guna2BorderlessForm(Me.components)
        Me.Guna2PictureBox1 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.TXT_CodSucursal = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TXT_NombreSucursal = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TXT_DireccionSucursal = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TXT_CedJuridicaSucursal = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TXT_EmailSucursal = New Guna.UI2.WinForms.Guna2TextBox()
        Me.BTN_LogoSucursal = New Guna.UI2.WinForms.Guna2ImageButton()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.BTN_RegresarNSuc = New Guna.UI2.WinForms.Guna2Button()
        Me.BTN_GuardarNSucursal = New Guna.UI2.WinForms.Guna2Button()
        Me.OFD_LogoSucursal = New System.Windows.Forms.OpenFileDialog()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TXT_TelefonoSucursal = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
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
        'Guna2PictureBox1
        '
        Me.Guna2PictureBox1.Image = CType(resources.GetObject("Guna2PictureBox1.Image"), System.Drawing.Image)
        Me.Guna2PictureBox1.ImageRotate = 0!
        Me.Guna2PictureBox1.Location = New System.Drawing.Point(187, -121)
        Me.Guna2PictureBox1.Name = "Guna2PictureBox1"
        Me.Guna2PictureBox1.Size = New System.Drawing.Size(539, 442)
        Me.Guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Guna2PictureBox1.TabIndex = 13
        Me.Guna2PictureBox1.TabStop = False
        '
        'TXT_CodSucursal
        '
        Me.TXT_CodSucursal.AutoRoundedCorners = True
        Me.TXT_CodSucursal.BorderRadius = 14
        Me.TXT_CodSucursal.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TXT_CodSucursal.DefaultText = ""
        Me.TXT_CodSucursal.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TXT_CodSucursal.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TXT_CodSucursal.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXT_CodSucursal.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXT_CodSucursal.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXT_CodSucursal.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.TXT_CodSucursal.ForeColor = System.Drawing.Color.Black
        Me.TXT_CodSucursal.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXT_CodSucursal.Location = New System.Drawing.Point(160, 210)
        Me.TXT_CodSucursal.Name = "TXT_CodSucursal"
        Me.TXT_CodSucursal.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TXT_CodSucursal.PlaceholderText = ""
        Me.TXT_CodSucursal.SelectedText = ""
        Me.TXT_CodSucursal.Size = New System.Drawing.Size(175, 31)
        Me.TXT_CodSucursal.TabIndex = 14
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Britannic Bold", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(63, 213)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(79, 23)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "Codigo:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Britannic Bold", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(341, 213)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(87, 23)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "Nombre:"
        '
        'TXT_NombreSucursal
        '
        Me.TXT_NombreSucursal.AutoRoundedCorners = True
        Me.TXT_NombreSucursal.BorderRadius = 14
        Me.TXT_NombreSucursal.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TXT_NombreSucursal.DefaultText = ""
        Me.TXT_NombreSucursal.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TXT_NombreSucursal.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TXT_NombreSucursal.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXT_NombreSucursal.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXT_NombreSucursal.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXT_NombreSucursal.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.TXT_NombreSucursal.ForeColor = System.Drawing.Color.Black
        Me.TXT_NombreSucursal.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXT_NombreSucursal.Location = New System.Drawing.Point(434, 208)
        Me.TXT_NombreSucursal.Name = "TXT_NombreSucursal"
        Me.TXT_NombreSucursal.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TXT_NombreSucursal.PlaceholderText = ""
        Me.TXT_NombreSucursal.SelectedText = ""
        Me.TXT_NombreSucursal.Size = New System.Drawing.Size(431, 31)
        Me.TXT_NombreSucursal.TabIndex = 17
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Britannic Bold", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(38, 355)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(104, 23)
        Me.Label3.TabIndex = 18
        Me.Label3.Text = "Dirección:"
        '
        'TXT_DireccionSucursal
        '
        Me.TXT_DireccionSucursal.BorderRadius = 20
        Me.TXT_DireccionSucursal.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TXT_DireccionSucursal.DefaultText = ""
        Me.TXT_DireccionSucursal.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TXT_DireccionSucursal.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TXT_DireccionSucursal.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXT_DireccionSucursal.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXT_DireccionSucursal.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXT_DireccionSucursal.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.TXT_DireccionSucursal.ForeColor = System.Drawing.Color.Black
        Me.TXT_DireccionSucursal.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXT_DireccionSucursal.Location = New System.Drawing.Point(160, 346)
        Me.TXT_DireccionSucursal.Multiline = True
        Me.TXT_DireccionSucursal.Name = "TXT_DireccionSucursal"
        Me.TXT_DireccionSucursal.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TXT_DireccionSucursal.PlaceholderText = ""
        Me.TXT_DireccionSucursal.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TXT_DireccionSucursal.SelectedText = ""
        Me.TXT_DireccionSucursal.Size = New System.Drawing.Size(504, 99)
        Me.TXT_DireccionSucursal.TabIndex = 19
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Britannic Bold", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(12, 261)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(142, 23)
        Me.Label4.TabIndex = 20
        Me.Label4.Text = "Ced. Jurídica: "
        '
        'TXT_CedJuridicaSucursal
        '
        Me.TXT_CedJuridicaSucursal.AutoRoundedCorners = True
        Me.TXT_CedJuridicaSucursal.BorderRadius = 14
        Me.TXT_CedJuridicaSucursal.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TXT_CedJuridicaSucursal.DefaultText = ""
        Me.TXT_CedJuridicaSucursal.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TXT_CedJuridicaSucursal.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TXT_CedJuridicaSucursal.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXT_CedJuridicaSucursal.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXT_CedJuridicaSucursal.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXT_CedJuridicaSucursal.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.TXT_CedJuridicaSucursal.ForeColor = System.Drawing.Color.Black
        Me.TXT_CedJuridicaSucursal.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXT_CedJuridicaSucursal.Location = New System.Drawing.Point(160, 257)
        Me.TXT_CedJuridicaSucursal.Name = "TXT_CedJuridicaSucursal"
        Me.TXT_CedJuridicaSucursal.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TXT_CedJuridicaSucursal.PlaceholderText = ""
        Me.TXT_CedJuridicaSucursal.SelectedText = ""
        Me.TXT_CedJuridicaSucursal.Size = New System.Drawing.Size(175, 31)
        Me.TXT_CedJuridicaSucursal.TabIndex = 21
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Britannic Bold", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(75, 308)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(67, 23)
        Me.Label5.TabIndex = 22
        Me.Label5.Text = "Email:"
        '
        'TXT_EmailSucursal
        '
        Me.TXT_EmailSucursal.AutoRoundedCorners = True
        Me.TXT_EmailSucursal.BorderRadius = 14
        Me.TXT_EmailSucursal.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TXT_EmailSucursal.DefaultText = ""
        Me.TXT_EmailSucursal.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TXT_EmailSucursal.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TXT_EmailSucursal.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXT_EmailSucursal.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXT_EmailSucursal.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXT_EmailSucursal.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.TXT_EmailSucursal.ForeColor = System.Drawing.Color.Black
        Me.TXT_EmailSucursal.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXT_EmailSucursal.Location = New System.Drawing.Point(160, 300)
        Me.TXT_EmailSucursal.Name = "TXT_EmailSucursal"
        Me.TXT_EmailSucursal.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TXT_EmailSucursal.PlaceholderText = ""
        Me.TXT_EmailSucursal.SelectedText = ""
        Me.TXT_EmailSucursal.Size = New System.Drawing.Size(504, 31)
        Me.TXT_EmailSucursal.TabIndex = 23
        '
        'BTN_LogoSucursal
        '
        Me.BTN_LogoSucursal.BackColor = System.Drawing.Color.White
        Me.BTN_LogoSucursal.CheckedState.ImageSize = New System.Drawing.Size(64, 64)
        Me.BTN_LogoSucursal.HoverState.ImageSize = New System.Drawing.Size(74, 74)
        Me.BTN_LogoSucursal.Image = CType(resources.GetObject("BTN_LogoSucursal.Image"), System.Drawing.Image)
        Me.BTN_LogoSucursal.ImageOffset = New System.Drawing.Point(0, 0)
        Me.BTN_LogoSucursal.ImageRotate = 0!
        Me.BTN_LogoSucursal.ImageSize = New System.Drawing.Size(190, 190)
        Me.BTN_LogoSucursal.Location = New System.Drawing.Point(681, 300)
        Me.BTN_LogoSucursal.Name = "BTN_LogoSucursal"
        Me.BTN_LogoSucursal.PressedState.ImageSize = New System.Drawing.Size(64, 64)
        Me.BTN_LogoSucursal.Size = New System.Drawing.Size(184, 145)
        Me.BTN_LogoSucursal.TabIndex = 24
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Britannic Bold", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(742, 261)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(60, 23)
        Me.Label6.TabIndex = 25
        Me.Label6.Text = "Logo:"
        '
        'BTN_RegresarNSuc
        '
        Me.BTN_RegresarNSuc.BorderColor = System.Drawing.Color.Red
        Me.BTN_RegresarNSuc.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.BTN_RegresarNSuc.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BTN_RegresarNSuc.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BTN_RegresarNSuc.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BTN_RegresarNSuc.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BTN_RegresarNSuc.Dock = System.Windows.Forms.DockStyle.Left
        Me.BTN_RegresarNSuc.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BTN_RegresarNSuc.Font = New System.Drawing.Font("Ebrima", 20.25!, System.Drawing.FontStyle.Bold)
        Me.BTN_RegresarNSuc.ForeColor = System.Drawing.Color.White
        Me.BTN_RegresarNSuc.Image = CType(resources.GetObject("BTN_RegresarNSuc.Image"), System.Drawing.Image)
        Me.BTN_RegresarNSuc.ImageSize = New System.Drawing.Size(40, 40)
        Me.BTN_RegresarNSuc.Location = New System.Drawing.Point(0, 0)
        Me.BTN_RegresarNSuc.Name = "BTN_RegresarNSuc"
        Me.BTN_RegresarNSuc.Size = New System.Drawing.Size(428, 66)
        Me.BTN_RegresarNSuc.TabIndex = 27
        Me.BTN_RegresarNSuc.Text = "Regresar"
        '
        'BTN_GuardarNSucursal
        '
        Me.BTN_GuardarNSucursal.BorderColor = System.Drawing.Color.Red
        Me.BTN_GuardarNSucursal.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BTN_GuardarNSucursal.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BTN_GuardarNSucursal.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BTN_GuardarNSucursal.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BTN_GuardarNSucursal.Dock = System.Windows.Forms.DockStyle.Right
        Me.BTN_GuardarNSucursal.FillColor = System.Drawing.Color.MediumSeaGreen
        Me.BTN_GuardarNSucursal.Font = New System.Drawing.Font("Ebrima", 20.25!, System.Drawing.FontStyle.Bold)
        Me.BTN_GuardarNSucursal.ForeColor = System.Drawing.Color.White
        Me.BTN_GuardarNSucursal.Image = CType(resources.GetObject("BTN_GuardarNSucursal.Image"), System.Drawing.Image)
        Me.BTN_GuardarNSucursal.ImageSize = New System.Drawing.Size(60, 60)
        Me.BTN_GuardarNSucursal.Location = New System.Drawing.Point(421, 0)
        Me.BTN_GuardarNSucursal.Name = "BTN_GuardarNSucursal"
        Me.BTN_GuardarNSucursal.Size = New System.Drawing.Size(456, 66)
        Me.BTN_GuardarNSucursal.TabIndex = 26
        Me.BTN_GuardarNSucursal.Text = "Agregar"
        '
        'OFD_LogoSucursal
        '
        Me.OFD_LogoSucursal.Filter = "Archivos de imagen|*.jpg;*.jpeg;*.png;*.gif"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Britannic Bold", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(341, 261)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(94, 23)
        Me.Label7.TabIndex = 28
        Me.Label7.Text = "Teléfono:"
        '
        'TXT_TelefonoSucursal
        '
        Me.TXT_TelefonoSucursal.AutoRoundedCorners = True
        Me.TXT_TelefonoSucursal.BorderRadius = 14
        Me.TXT_TelefonoSucursal.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TXT_TelefonoSucursal.DefaultText = ""
        Me.TXT_TelefonoSucursal.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TXT_TelefonoSucursal.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TXT_TelefonoSucursal.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXT_TelefonoSucursal.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXT_TelefonoSucursal.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXT_TelefonoSucursal.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.TXT_TelefonoSucursal.ForeColor = System.Drawing.Color.Black
        Me.TXT_TelefonoSucursal.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXT_TelefonoSucursal.Location = New System.Drawing.Point(434, 255)
        Me.TXT_TelefonoSucursal.Name = "TXT_TelefonoSucursal"
        Me.TXT_TelefonoSucursal.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TXT_TelefonoSucursal.PlaceholderText = ""
        Me.TXT_TelefonoSucursal.SelectedText = ""
        Me.TXT_TelefonoSucursal.Size = New System.Drawing.Size(230, 31)
        Me.TXT_TelefonoSucursal.TabIndex = 29
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.Controls.Add(Me.BTN_RegresarNSuc)
        Me.Guna2Panel1.Controls.Add(Me.BTN_GuardarNSucursal)
        Me.Guna2Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Guna2Panel1.Location = New System.Drawing.Point(0, 470)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.Size = New System.Drawing.Size(877, 66)
        Me.Guna2Panel1.TabIndex = 30
        '
        'E_NuevaSucursal
        '
        Me.AcceptButton = Me.BTN_GuardarNSucursal
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.CancelButton = Me.BTN_RegresarNSuc
        Me.ClientSize = New System.Drawing.Size(877, 536)
        Me.Controls.Add(Me.Guna2Panel1)
        Me.Controls.Add(Me.TXT_TelefonoSucursal)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.BTN_LogoSucursal)
        Me.Controls.Add(Me.TXT_EmailSucursal)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TXT_CedJuridicaSucursal)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TXT_DireccionSucursal)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TXT_NombreSucursal)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TXT_CodSucursal)
        Me.Controls.Add(Me.Guna2PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Name = "E_NuevaSucursal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Mantenimiento de sucursal"
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Guna2Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Guna2BorderlessForm1 As Guna.UI2.WinForms.Guna2BorderlessForm
    Friend WithEvents Guna2PictureBox1 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents TXT_CodSucursal As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TXT_EmailSucursal As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TXT_CedJuridicaSucursal As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TXT_DireccionSucursal As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TXT_NombreSucursal As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents BTN_LogoSucursal As Guna.UI2.WinForms.Guna2ImageButton
    Friend WithEvents BTN_RegresarNSuc As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BTN_GuardarNSucursal As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents OFD_LogoSucursal As OpenFileDialog
    Friend WithEvents TXT_TelefonoSucursal As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
End Class
