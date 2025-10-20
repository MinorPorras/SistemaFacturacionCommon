Namespace SistemaFacturacion.Forms.Mantenimiento

    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Class C_Productos
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
            Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(C_Productos))
            Me.BTN_NProd = New Guna.UI2.WinForms.Guna2Button()
            Me.MNU_CONTX = New Guna.UI2.WinForms.Guna2ContextMenuStrip()
            Me.MNU_MODIFICAR = New System.Windows.Forms.ToolStripMenuItem()
            Me.MNU_ELIMINAR = New System.Windows.Forms.ToolStripMenuItem()
            Me.BTN_RegresarProd = New Guna.UI2.WinForms.Guna2Button()
            Me.TXT_BuscarProd = New Guna.UI2.WinForms.Guna2TextBox()
            Me.Label1 = New System.Windows.Forms.Label()
            Me.Label2 = New System.Windows.Forms.Label()
            Me.Label3 = New System.Windows.Forms.Label()
            Me.TXT_BuscarMarca = New Guna.UI2.WinForms.Guna2TextBox()
            Me.TXT_BuscarProv = New Guna.UI2.WinForms.Guna2TextBox()
            Me.TXT_BuscarCat = New Guna.UI2.WinForms.Guna2TextBox()
            Me.DGV_Prods = New Guna.UI2.WinForms.Guna2DataGridView()
            Me.BTN_Hablador = New Guna.UI2.WinForms.Guna2Button()
            Me.Label5 = New System.Windows.Forms.Label()
            Me.SWT_Marca = New Guna.UI2.WinForms.Guna2ToggleSwitch()
            Me.Label4 = New System.Windows.Forms.Label()
            Me.SWT_Prov = New Guna.UI2.WinForms.Guna2ToggleSwitch()
            Me.Label6 = New System.Windows.Forms.Label()
            Me.SWT_Cat = New Guna.UI2.WinForms.Guna2ToggleSwitch()
            Me.Label7 = New System.Windows.Forms.Label()
            Me.SWT_Recientes = New Guna.UI2.WinForms.Guna2ToggleSwitch()
            Me.BTN_Config = New Guna.UI2.WinForms.Guna2ImageButton()
            Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
            Me.GBX_Filter = New Guna.UI2.WinForms.Guna2GroupBox()
            Me.RDB_All = New Guna.UI2.WinForms.Guna2RadioButton()
            Me.RDB_200 = New Guna.UI2.WinForms.Guna2RadioButton()
            Me.RDB_100 = New Guna.UI2.WinForms.Guna2RadioButton()
            Me.RDB_500 = New Guna.UI2.WinForms.Guna2RadioButton()
            Me.MNU_CONTX.SuspendLayout()
            CType(Me.DGV_Prods, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.TableLayoutPanel1.SuspendLayout()
            Me.GBX_Filter.SuspendLayout()
            Me.SuspendLayout()
            '
            'BTN_NProd
            '
            Me.BTN_NProd.BorderColor = System.Drawing.Color.Red
            Me.BTN_NProd.BorderRadius = 10
            Me.BTN_NProd.DialogResult = System.Windows.Forms.DialogResult.Cancel
            Me.BTN_NProd.DisabledState.BorderColor = System.Drawing.Color.DarkGray
            Me.BTN_NProd.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
            Me.BTN_NProd.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
            Me.BTN_NProd.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
            Me.BTN_NProd.Dock = System.Windows.Forms.DockStyle.Fill
            Me.BTN_NProd.FillColor = System.Drawing.Color.MediumSeaGreen
            Me.BTN_NProd.Font = New System.Drawing.Font("Ebrima", 20.25!, System.Drawing.FontStyle.Bold)
            Me.BTN_NProd.ForeColor = System.Drawing.Color.White
            Me.BTN_NProd.Image = Global.SistemaFacturaciónCommon.My.Resources.Resources.ICO_Mas
            Me.BTN_NProd.ImageSize = New System.Drawing.Size(40, 40)
            Me.BTN_NProd.Location = New System.Drawing.Point(837, 3)
            Me.BTN_NProd.Name = "BTN_NProd"
            Me.BTN_NProd.Size = New System.Drawing.Size(413, 52)
            Me.BTN_NProd.TabIndex = 51
            Me.BTN_NProd.Text = "Agregar"
            '
            'MNU_CONTX
            '
            Me.MNU_CONTX.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer))
            Me.MNU_CONTX.ImageScalingSize = New System.Drawing.Size(20, 20)
            Me.MNU_CONTX.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MNU_MODIFICAR, Me.MNU_ELIMINAR})
            Me.MNU_CONTX.Name = "MNU_CONTX"
            Me.MNU_CONTX.RenderStyle.ArrowColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.MNU_CONTX.RenderStyle.BorderColor = System.Drawing.Color.Gainsboro
            Me.MNU_CONTX.RenderStyle.ColorTable = Nothing
            Me.MNU_CONTX.RenderStyle.RoundedEdges = True
            Me.MNU_CONTX.RenderStyle.SelectionArrowColor = System.Drawing.Color.White
            Me.MNU_CONTX.RenderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.MNU_CONTX.RenderStyle.SelectionForeColor = System.Drawing.Color.White
            Me.MNU_CONTX.RenderStyle.SeparatorColor = System.Drawing.Color.Gainsboro
            Me.MNU_CONTX.RenderStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault
            Me.MNU_CONTX.Size = New System.Drawing.Size(136, 56)
            '
            'MNU_MODIFICAR
            '
            Me.MNU_MODIFICAR.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer))
            Me.MNU_MODIFICAR.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.MNU_MODIFICAR.ForeColor = System.Drawing.Color.White
            Me.MNU_MODIFICAR.Image = Global.SistemaFacturaciónCommon.My.Resources.Resources.ICO_Edit
            Me.MNU_MODIFICAR.Name = "MNU_MODIFICAR"
            Me.MNU_MODIFICAR.Size = New System.Drawing.Size(135, 26)
            Me.MNU_MODIFICAR.Text = "Modificar"
            Me.MNU_MODIFICAR.Visible = False
            '
            'MNU_ELIMINAR
            '
            Me.MNU_ELIMINAR.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer))
            Me.MNU_ELIMINAR.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.MNU_ELIMINAR.ForeColor = System.Drawing.Color.White
            Me.MNU_ELIMINAR.Image = Global.SistemaFacturaciónCommon.My.Resources.Resources.ICO_Eliminar
            Me.MNU_ELIMINAR.Name = "MNU_ELIMINAR"
            Me.MNU_ELIMINAR.Size = New System.Drawing.Size(135, 26)
            Me.MNU_ELIMINAR.Text = "Eliminar"
            Me.MNU_ELIMINAR.Visible = False
            '
            'BTN_RegresarProd
            '
            Me.BTN_RegresarProd.BorderColor = System.Drawing.Color.Red
            Me.BTN_RegresarProd.BorderRadius = 10
            Me.BTN_RegresarProd.DialogResult = System.Windows.Forms.DialogResult.Cancel
            Me.BTN_RegresarProd.DisabledState.BorderColor = System.Drawing.Color.DarkGray
            Me.BTN_RegresarProd.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
            Me.BTN_RegresarProd.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
            Me.BTN_RegresarProd.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
            Me.BTN_RegresarProd.Dock = System.Windows.Forms.DockStyle.Fill
            Me.BTN_RegresarProd.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
            Me.BTN_RegresarProd.Font = New System.Drawing.Font("Ebrima", 20.25!, System.Drawing.FontStyle.Bold)
            Me.BTN_RegresarProd.ForeColor = System.Drawing.Color.White
            Me.BTN_RegresarProd.Image = Global.SistemaFacturaciónCommon.My.Resources.Resources.ICO_Back
            Me.BTN_RegresarProd.ImageSize = New System.Drawing.Size(40, 40)
            Me.BTN_RegresarProd.Location = New System.Drawing.Point(3, 3)
            Me.BTN_RegresarProd.Name = "BTN_RegresarProd"
            Me.BTN_RegresarProd.Size = New System.Drawing.Size(411, 52)
            Me.BTN_RegresarProd.TabIndex = 48
            Me.BTN_RegresarProd.Text = "Regresar"
            '
            'TXT_BuscarProd
            '
            Me.TXT_BuscarProd.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
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
            Me.TXT_BuscarProd.Location = New System.Drawing.Point(12, 21)
            Me.TXT_BuscarProd.Name = "TXT_BuscarProd"
            Me.TXT_BuscarProd.PlaceholderText = "Buscar producto"
            Me.TXT_BuscarProd.SelectedText = ""
            Me.TXT_BuscarProd.Size = New System.Drawing.Size(1157, 42)
            Me.TXT_BuscarProd.TabIndex = 47
            '
            'Label1
            '
            Me.Label1.AutoSize = True
            Me.Label1.Font = New System.Drawing.Font("Britannic Bold", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label1.ForeColor = System.Drawing.Color.White
            Me.Label1.Location = New System.Drawing.Point(8, 88)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(72, 23)
            Me.Label1.TabIndex = 57
            Me.Label1.Text = "Marca:"
            '
            'Label2
            '
            Me.Label2.AutoSize = True
            Me.Label2.Font = New System.Drawing.Font("Britannic Bold", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label2.ForeColor = System.Drawing.Color.White
            Me.Label2.Location = New System.Drawing.Point(295, 88)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New System.Drawing.Size(109, 23)
            Me.Label2.TabIndex = 59
            Me.Label2.Text = "Proveedor:"
            '
            'Label3
            '
            Me.Label3.AutoSize = True
            Me.Label3.Font = New System.Drawing.Font("Britannic Bold", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label3.ForeColor = System.Drawing.Color.White
            Me.Label3.Location = New System.Drawing.Point(620, 88)
            Me.Label3.Name = "Label3"
            Me.Label3.Size = New System.Drawing.Size(105, 23)
            Me.Label3.TabIndex = 61
            Me.Label3.Text = "Categoría:"
            '
            'TXT_BuscarMarca
            '
            Me.TXT_BuscarMarca.BorderRadius = 20
            Me.TXT_BuscarMarca.Cursor = System.Windows.Forms.Cursors.IBeam
            Me.TXT_BuscarMarca.DefaultText = ""
            Me.TXT_BuscarMarca.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
            Me.TXT_BuscarMarca.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
            Me.TXT_BuscarMarca.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
            Me.TXT_BuscarMarca.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
            Me.TXT_BuscarMarca.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.TXT_BuscarMarca.Font = New System.Drawing.Font("Segoe UI", 9.0!)
            Me.TXT_BuscarMarca.ForeColor = System.Drawing.Color.Black
            Me.TXT_BuscarMarca.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.TXT_BuscarMarca.Location = New System.Drawing.Point(86, 80)
            Me.TXT_BuscarMarca.Name = "TXT_BuscarMarca"
            Me.TXT_BuscarMarca.PlaceholderText = "Doble click para buscar"
            Me.TXT_BuscarMarca.SelectedText = ""
            Me.TXT_BuscarMarca.Size = New System.Drawing.Size(162, 42)
            Me.TXT_BuscarMarca.TabIndex = 65
            '
            'TXT_BuscarProv
            '
            Me.TXT_BuscarProv.BorderRadius = 20
            Me.TXT_BuscarProv.Cursor = System.Windows.Forms.Cursors.IBeam
            Me.TXT_BuscarProv.DefaultText = ""
            Me.TXT_BuscarProv.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
            Me.TXT_BuscarProv.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
            Me.TXT_BuscarProv.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
            Me.TXT_BuscarProv.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
            Me.TXT_BuscarProv.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.TXT_BuscarProv.Font = New System.Drawing.Font("Segoe UI", 9.0!)
            Me.TXT_BuscarProv.ForeColor = System.Drawing.Color.Black
            Me.TXT_BuscarProv.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.TXT_BuscarProv.Location = New System.Drawing.Point(410, 80)
            Me.TXT_BuscarProv.Name = "TXT_BuscarProv"
            Me.TXT_BuscarProv.PlaceholderText = "Doble click para buscar"
            Me.TXT_BuscarProv.SelectedText = ""
            Me.TXT_BuscarProv.Size = New System.Drawing.Size(155, 42)
            Me.TXT_BuscarProv.TabIndex = 66
            '
            'TXT_BuscarCat
            '
            Me.TXT_BuscarCat.BorderRadius = 20
            Me.TXT_BuscarCat.Cursor = System.Windows.Forms.Cursors.IBeam
            Me.TXT_BuscarCat.DefaultText = ""
            Me.TXT_BuscarCat.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
            Me.TXT_BuscarCat.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
            Me.TXT_BuscarCat.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
            Me.TXT_BuscarCat.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
            Me.TXT_BuscarCat.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.TXT_BuscarCat.Font = New System.Drawing.Font("Segoe UI", 9.0!)
            Me.TXT_BuscarCat.ForeColor = System.Drawing.Color.Black
            Me.TXT_BuscarCat.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.TXT_BuscarCat.Location = New System.Drawing.Point(727, 80)
            Me.TXT_BuscarCat.Name = "TXT_BuscarCat"
            Me.TXT_BuscarCat.PlaceholderText = "Doble click para buscar"
            Me.TXT_BuscarCat.SelectedText = ""
            Me.TXT_BuscarCat.Size = New System.Drawing.Size(166, 42)
            Me.TXT_BuscarCat.TabIndex = 67
            '
            'DGV_Prods
            '
            Me.DGV_Prods.AllowUserToAddRows = False
            Me.DGV_Prods.AllowUserToDeleteRows = False
            Me.DGV_Prods.AllowUserToResizeRows = False
            DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
            DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
            DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
            DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
            Me.DGV_Prods.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
            Me.DGV_Prods.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.DGV_Prods.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
            DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
            DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
            DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
            DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
            Me.DGV_Prods.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
            Me.DGV_Prods.ColumnHeadersHeight = 20
            Me.DGV_Prods.ContextMenuStrip = Me.MNU_CONTX
            DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
            DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
            DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
            DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
            DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
            Me.DGV_Prods.DefaultCellStyle = DataGridViewCellStyle3
            Me.DGV_Prods.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.DGV_Prods.Location = New System.Drawing.Point(14, 165)
            Me.DGV_Prods.MultiSelect = False
            Me.DGV_Prods.Name = "DGV_Prods"
            Me.DGV_Prods.ReadOnly = True
            Me.DGV_Prods.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
            DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle4.BackColor = System.Drawing.Color.White
            DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
            DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.White
            DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
            Me.DGV_Prods.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
            Me.DGV_Prods.RowHeadersVisible = False
            Me.DGV_Prods.Size = New System.Drawing.Size(1253, 387)
            Me.DGV_Prods.TabIndex = 68
            Me.DGV_Prods.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
            Me.DGV_Prods.ThemeStyle.AlternatingRowsStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.DGV_Prods.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.SystemColors.ControlText
            Me.DGV_Prods.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.DGV_Prods.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
            Me.DGV_Prods.ThemeStyle.BackColor = System.Drawing.Color.White
            Me.DGV_Prods.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.DGV_Prods.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.DGV_Prods.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
            Me.DGV_Prods.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.DGV_Prods.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
            Me.DGV_Prods.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
            Me.DGV_Prods.ThemeStyle.HeaderStyle.Height = 20
            Me.DGV_Prods.ThemeStyle.ReadOnly = True
            Me.DGV_Prods.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
            Me.DGV_Prods.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
            Me.DGV_Prods.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.DGV_Prods.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
            Me.DGV_Prods.ThemeStyle.RowsStyle.Height = 22
            Me.DGV_Prods.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.DGV_Prods.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
            '
            'BTN_Hablador
            '
            Me.BTN_Hablador.BorderColor = System.Drawing.Color.Red
            Me.BTN_Hablador.BorderRadius = 10
            Me.BTN_Hablador.DialogResult = System.Windows.Forms.DialogResult.Cancel
            Me.BTN_Hablador.DisabledState.BorderColor = System.Drawing.Color.DarkGray
            Me.BTN_Hablador.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
            Me.BTN_Hablador.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
            Me.BTN_Hablador.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
            Me.BTN_Hablador.Dock = System.Windows.Forms.DockStyle.Fill
            Me.BTN_Hablador.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.BTN_Hablador.Font = New System.Drawing.Font("Ebrima", 20.25!, System.Drawing.FontStyle.Bold)
            Me.BTN_Hablador.ForeColor = System.Drawing.Color.White
            Me.BTN_Hablador.Image = CType(resources.GetObject("BTN_Hablador.Image"), System.Drawing.Image)
            Me.BTN_Hablador.ImageSize = New System.Drawing.Size(50, 50)
            Me.BTN_Hablador.Location = New System.Drawing.Point(420, 3)
            Me.BTN_Hablador.Name = "BTN_Hablador"
            Me.BTN_Hablador.Size = New System.Drawing.Size(411, 52)
            Me.BTN_Hablador.TabIndex = 69
            Me.BTN_Hablador.Text = "Crear hablador"
            '
            'Label5
            '
            Me.Label5.AutoSize = True
            Me.Label5.Font = New System.Drawing.Font("Britannic Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label5.ForeColor = System.Drawing.Color.White
            Me.Label5.Location = New System.Drawing.Point(14, 131)
            Me.Label5.Name = "Label5"
            Me.Label5.Size = New System.Drawing.Size(191, 16)
            Me.Label5.TabIndex = 71
            Me.Label5.Text = "Activar busqueda por marca"
            Me.Label5.TextAlign = System.Drawing.ContentAlignment.TopCenter
            '
            'SWT_Marca
            '
            Me.SWT_Marca.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.SWT_Marca.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.SWT_Marca.CheckedState.InnerBorderColor = System.Drawing.Color.White
            Me.SWT_Marca.CheckedState.InnerColor = System.Drawing.Color.White
            Me.SWT_Marca.Location = New System.Drawing.Point(211, 127)
            Me.SWT_Marca.Name = "SWT_Marca"
            Me.SWT_Marca.Size = New System.Drawing.Size(37, 20)
            Me.SWT_Marca.TabIndex = 70
            Me.SWT_Marca.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
            Me.SWT_Marca.UncheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
            Me.SWT_Marca.UncheckedState.InnerBorderColor = System.Drawing.Color.White
            Me.SWT_Marca.UncheckedState.InnerColor = System.Drawing.Color.White
            '
            'Label4
            '
            Me.Label4.AutoSize = True
            Me.Label4.Font = New System.Drawing.Font("Britannic Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label4.ForeColor = System.Drawing.Color.White
            Me.Label4.Location = New System.Drawing.Point(309, 132)
            Me.Label4.Name = "Label4"
            Me.Label4.Size = New System.Drawing.Size(215, 16)
            Me.Label4.TabIndex = 73
            Me.Label4.Text = "Activar busqueda por proveedor"
            Me.Label4.TextAlign = System.Drawing.ContentAlignment.TopCenter
            '
            'SWT_Prov
            '
            Me.SWT_Prov.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.SWT_Prov.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.SWT_Prov.CheckedState.InnerBorderColor = System.Drawing.Color.White
            Me.SWT_Prov.CheckedState.InnerColor = System.Drawing.Color.White
            Me.SWT_Prov.Location = New System.Drawing.Point(530, 128)
            Me.SWT_Prov.Name = "SWT_Prov"
            Me.SWT_Prov.Size = New System.Drawing.Size(35, 20)
            Me.SWT_Prov.TabIndex = 72
            Me.SWT_Prov.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
            Me.SWT_Prov.UncheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
            Me.SWT_Prov.UncheckedState.InnerBorderColor = System.Drawing.Color.White
            Me.SWT_Prov.UncheckedState.InnerColor = System.Drawing.Color.White
            '
            'Label6
            '
            Me.Label6.AutoSize = True
            Me.Label6.Font = New System.Drawing.Font("Britannic Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label6.ForeColor = System.Drawing.Color.White
            Me.Label6.Location = New System.Drawing.Point(640, 132)
            Me.Label6.Name = "Label6"
            Me.Label6.Size = New System.Drawing.Size(212, 16)
            Me.Label6.TabIndex = 75
            Me.Label6.Text = "Activar busqueda por categoría"
            Me.Label6.TextAlign = System.Drawing.ContentAlignment.TopCenter
            '
            'SWT_Cat
            '
            Me.SWT_Cat.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.SWT_Cat.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.SWT_Cat.CheckedState.InnerBorderColor = System.Drawing.Color.White
            Me.SWT_Cat.CheckedState.InnerColor = System.Drawing.Color.White
            Me.SWT_Cat.Location = New System.Drawing.Point(858, 128)
            Me.SWT_Cat.Name = "SWT_Cat"
            Me.SWT_Cat.Size = New System.Drawing.Size(35, 20)
            Me.SWT_Cat.TabIndex = 74
            Me.SWT_Cat.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
            Me.SWT_Cat.UncheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
            Me.SWT_Cat.UncheckedState.InnerBorderColor = System.Drawing.Color.White
            Me.SWT_Cat.UncheckedState.InnerColor = System.Drawing.Color.White
            '
            'Label7
            '
            Me.Label7.AutoSize = True
            Me.Label7.Font = New System.Drawing.Font("Britannic Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label7.ForeColor = System.Drawing.Color.White
            Me.Label7.Location = New System.Drawing.Point(936, 92)
            Me.Label7.Name = "Label7"
            Me.Label7.Size = New System.Drawing.Size(90, 16)
            Me.Label7.TabIndex = 122
            Me.Label7.Text = "Ver recientes"
            Me.Label7.TextAlign = System.Drawing.ContentAlignment.TopCenter
            '
            'SWT_Recientes
            '
            Me.SWT_Recientes.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.SWT_Recientes.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.SWT_Recientes.CheckedState.InnerBorderColor = System.Drawing.Color.White
            Me.SWT_Recientes.CheckedState.InnerColor = System.Drawing.Color.White
            Me.SWT_Recientes.Location = New System.Drawing.Point(939, 111)
            Me.SWT_Recientes.Name = "SWT_Recientes"
            Me.SWT_Recientes.Size = New System.Drawing.Size(87, 31)
            Me.SWT_Recientes.TabIndex = 121
            Me.SWT_Recientes.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
            Me.SWT_Recientes.UncheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
            Me.SWT_Recientes.UncheckedState.InnerBorderColor = System.Drawing.Color.White
            Me.SWT_Recientes.UncheckedState.InnerColor = System.Drawing.Color.White
            '
            'BTN_Config
            '
            Me.BTN_Config.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.BTN_Config.BackColor = System.Drawing.Color.Transparent
            Me.BTN_Config.CheckedState.Image = Global.SistemaFacturaciónCommon.My.Resources.Resources.ICO_Config
            Me.BTN_Config.CheckedState.ImageSize = New System.Drawing.Size(40, 40)
            Me.BTN_Config.HoverState.Image = Global.SistemaFacturaciónCommon.My.Resources.Resources.ICO_ConfigCol
            Me.BTN_Config.HoverState.ImageSize = New System.Drawing.Size(43, 43)
            Me.BTN_Config.Image = Global.SistemaFacturaciónCommon.My.Resources.Resources.ICO_Config
            Me.BTN_Config.ImageOffset = New System.Drawing.Point(0, 0)
            Me.BTN_Config.ImageRotate = 0!
            Me.BTN_Config.ImageSize = New System.Drawing.Size(40, 40)
            Me.BTN_Config.Location = New System.Drawing.Point(1198, 18)
            Me.BTN_Config.Name = "BTN_Config"
            Me.BTN_Config.PressedState.ImageSize = New System.Drawing.Size(64, 64)
            Me.BTN_Config.Size = New System.Drawing.Size(45, 45)
            Me.BTN_Config.TabIndex = 125
            '
            'TableLayoutPanel1
            '
            Me.TableLayoutPanel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.TableLayoutPanel1.ColumnCount = 3
            Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
            Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
            Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
            Me.TableLayoutPanel1.Controls.Add(Me.BTN_RegresarProd, 0, 0)
            Me.TableLayoutPanel1.Controls.Add(Me.BTN_Hablador, 1, 0)
            Me.TableLayoutPanel1.Controls.Add(Me.BTN_NProd, 2, 0)
            Me.TableLayoutPanel1.Location = New System.Drawing.Point(14, 576)
            Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
            Me.TableLayoutPanel1.RowCount = 1
            Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
            Me.TableLayoutPanel1.Size = New System.Drawing.Size(1253, 58)
            Me.TableLayoutPanel1.TabIndex = 126
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
            Me.GBX_Filter.Location = New System.Drawing.Point(1068, 80)
            Me.GBX_Filter.Name = "GBX_Filter"
            Me.GBX_Filter.Size = New System.Drawing.Size(199, 74)
            Me.GBX_Filter.TabIndex = 127
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
            'C_Productos
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer))
            Me.CancelButton = Me.BTN_RegresarProd
            Me.ClientSize = New System.Drawing.Size(1280, 637)
            Me.Controls.Add(Me.GBX_Filter)
            Me.Controls.Add(Me.TableLayoutPanel1)
            Me.Controls.Add(Me.BTN_Config)
            Me.Controls.Add(Me.Label7)
            Me.Controls.Add(Me.SWT_Recientes)
            Me.Controls.Add(Me.Label6)
            Me.Controls.Add(Me.SWT_Cat)
            Me.Controls.Add(Me.Label4)
            Me.Controls.Add(Me.SWT_Prov)
            Me.Controls.Add(Me.Label5)
            Me.Controls.Add(Me.SWT_Marca)
            Me.Controls.Add(Me.DGV_Prods)
            Me.Controls.Add(Me.TXT_BuscarCat)
            Me.Controls.Add(Me.TXT_BuscarProv)
            Me.Controls.Add(Me.TXT_BuscarMarca)
            Me.Controls.Add(Me.Label3)
            Me.Controls.Add(Me.Label2)
            Me.Controls.Add(Me.Label1)
            Me.Controls.Add(Me.TXT_BuscarProd)
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.KeyPreview = True
            Me.Name = "C_Productos"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "Productos"
            Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
            Me.MNU_CONTX.ResumeLayout(False)
            CType(Me.DGV_Prods, System.ComponentModel.ISupportInitialize).EndInit()
            Me.TableLayoutPanel1.ResumeLayout(False)
            Me.GBX_Filter.ResumeLayout(False)
            Me.GBX_Filter.PerformLayout()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub

        Friend WithEvents BTN_NProd As Guna.UI2.WinForms.Guna2Button
        Friend WithEvents BTN_RegresarProd As Guna.UI2.WinForms.Guna2Button
        Friend WithEvents TXT_BuscarProd As Guna.UI2.WinForms.Guna2TextBox
        Friend WithEvents MNU_CONTX As Guna.UI2.WinForms.Guna2ContextMenuStrip
        Friend WithEvents MNU_MODIFICAR As ToolStripMenuItem
        Friend WithEvents MNU_ELIMINAR As ToolStripMenuItem
        Friend WithEvents Label3 As Label
        Friend WithEvents Label2 As Label
        Friend WithEvents Label1 As Label
        Friend WithEvents TXT_BuscarMarca As Guna.UI2.WinForms.Guna2TextBox
        Friend WithEvents TXT_BuscarCat As Guna.UI2.WinForms.Guna2TextBox
        Friend WithEvents TXT_BuscarProv As Guna.UI2.WinForms.Guna2TextBox
        Friend WithEvents DGV_Prods As Guna.UI2.WinForms.Guna2DataGridView
        Friend WithEvents BTN_Hablador As Guna.UI2.WinForms.Guna2Button
        Friend WithEvents Label6 As Label
        Friend WithEvents SWT_Cat As Guna.UI2.WinForms.Guna2ToggleSwitch
        Friend WithEvents Label4 As Label
        Friend WithEvents SWT_Prov As Guna.UI2.WinForms.Guna2ToggleSwitch
        Friend WithEvents Label5 As Label
        Friend WithEvents SWT_Marca As Guna.UI2.WinForms.Guna2ToggleSwitch
        Friend WithEvents Label7 As Label
        Friend WithEvents SWT_Recientes As Guna.UI2.WinForms.Guna2ToggleSwitch
        Friend WithEvents BTN_Config As Guna.UI2.WinForms.Guna2ImageButton
        Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
        Friend WithEvents GBX_Filter As Guna.UI2.WinForms.Guna2GroupBox
        Friend WithEvents RDB_All As Guna.UI2.WinForms.Guna2RadioButton
        Friend WithEvents RDB_200 As Guna.UI2.WinForms.Guna2RadioButton
        Friend WithEvents RDB_100 As Guna.UI2.WinForms.Guna2RadioButton
        Friend WithEvents RDB_500 As Guna.UI2.WinForms.Guna2RadioButton
    End Class
End Namespace