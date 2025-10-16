Namespace SistemaFacturacion.Forms.Inicio
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Class P_SelectUsu
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(P_SelectUsu))
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.Guna2GroupBox2 = New Guna.UI2.WinForms.Guna2GroupBox()
        Me.GRB_SelectUsuario = New Guna.UI2.WinForms.Guna2GroupBox()
        Me.BTN_CerrarApp = New Guna.UI2.WinForms.Guna2ImageButton()
        Me.Guna2BorderlessForm1 = New Guna.UI2.WinForms.Guna2BorderlessForm(Me.components)
            Me.GRB_SelectUsuario.SuspendLayout()
            Me.SuspendLayout()
            '
            'FlowLayoutPanel1
            '
            Me.FlowLayoutPanel1.AutoScroll = True
            Me.FlowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(62, Byte), Integer))
            Me.FlowLayoutPanel1.Location = New System.Drawing.Point(3, 43)
            Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
            Me.FlowLayoutPanel1.Size = New System.Drawing.Size(845, 420)
            Me.FlowLayoutPanel1.TabIndex = 0
            '
            'Guna2GroupBox2
            '
            Me.Guna2GroupBox2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.Guna2GroupBox2.BorderColor = System.Drawing.SystemColors.AppWorkspace
            Me.Guna2GroupBox2.BorderRadius = 20
            Me.Guna2GroupBox2.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.Guna2GroupBox2.CustomBorderThickness = New System.Windows.Forms.Padding(2, 40, 2, 2)
            Me.Guna2GroupBox2.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Guna2GroupBox2.ForeColor = System.Drawing.Color.White
            Me.Guna2GroupBox2.Location = New System.Drawing.Point(85, 68)
            Me.Guna2GroupBox2.Name = "Guna2GroupBox2"
            Me.Guna2GroupBox2.Size = New System.Drawing.Size(884, 414)
            Me.Guna2GroupBox2.TabIndex = 127
            Me.Guna2GroupBox2.Text = "Seleccione un usuario:"
            '
            'GRB_SelectUsuario
            '
            Me.GRB_SelectUsuario.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.GRB_SelectUsuario.BackColor = System.Drawing.Color.Transparent
            Me.GRB_SelectUsuario.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.GRB_SelectUsuario.BorderRadius = 20
            Me.GRB_SelectUsuario.Controls.Add(Me.FlowLayoutPanel1)
            Me.GRB_SelectUsuario.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.GRB_SelectUsuario.FillColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(62, Byte), Integer))
            Me.GRB_SelectUsuario.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.GRB_SelectUsuario.ForeColor = System.Drawing.Color.White
            Me.GRB_SelectUsuario.Location = New System.Drawing.Point(71, 85)
            Me.GRB_SelectUsuario.Name = "GRB_SelectUsuario"
            Me.GRB_SelectUsuario.ShadowDecoration.BorderRadius = 20
            Me.GRB_SelectUsuario.ShadowDecoration.Color = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
            Me.GRB_SelectUsuario.ShadowDecoration.Enabled = True
            Me.GRB_SelectUsuario.Size = New System.Drawing.Size(851, 479)
            Me.GRB_SelectUsuario.TabIndex = 1
            Me.GRB_SelectUsuario.Text = "Seleccione un usuario:"
            '
            'BTN_CerrarApp
            '
            Me.BTN_CerrarApp.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.BTN_CerrarApp.BackColor = System.Drawing.Color.Transparent
            Me.BTN_CerrarApp.CheckedState.Image = Global.SistemaFacturaciónCommon.My.Resources.Resources.ICO_Cerrar
            Me.BTN_CerrarApp.CheckedState.ImageSize = New System.Drawing.Size(40, 40)
            Me.BTN_CerrarApp.HoverState.Image = Global.SistemaFacturaciónCommon.My.Resources.Resources.ICO_CerrarCol
            Me.BTN_CerrarApp.HoverState.ImageSize = New System.Drawing.Size(43, 43)
            Me.BTN_CerrarApp.Image = Global.SistemaFacturaciónCommon.My.Resources.Resources.ICO_Cerrar
            Me.BTN_CerrarApp.ImageOffset = New System.Drawing.Point(0, 0)
            Me.BTN_CerrarApp.ImageRotate = 0!
            Me.BTN_CerrarApp.ImageSize = New System.Drawing.Size(40, 40)
            Me.BTN_CerrarApp.Location = New System.Drawing.Point(927, 12)
            Me.BTN_CerrarApp.Name = "BTN_CerrarApp"
            Me.BTN_CerrarApp.PressedState.ImageSize = New System.Drawing.Size(64, 64)
            Me.BTN_CerrarApp.Size = New System.Drawing.Size(45, 45)
            Me.BTN_CerrarApp.TabIndex = 124
            '
            'Guna2BorderlessForm1
            '
            Me.Guna2BorderlessForm1.BorderRadius = 25
            Me.Guna2BorderlessForm1.ContainerControl = Me
            Me.Guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6R
            Me.Guna2BorderlessForm1.TransparentWhileDrag = True
            '
            'P_SelectUsu
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer))
            Me.ClientSize = New System.Drawing.Size(984, 611)
            Me.Controls.Add(Me.GRB_SelectUsuario)
            Me.Controls.Add(Me.BTN_CerrarApp)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.Name = "P_SelectUsu"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "Selección de usuario"
            Me.GRB_SelectUsuario.ResumeLayout(False)
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents Guna2GroupBox2 As Guna.UI2.WinForms.Guna2GroupBox
    Friend WithEvents GRB_SelectUsuario As Guna.UI2.WinForms.Guna2GroupBox
    Friend WithEvents BTN_CerrarApp As Guna.UI2.WinForms.Guna2ImageButton
    Friend WithEvents Guna2BorderlessForm1 As Guna.UI2.WinForms.Guna2BorderlessForm
End Class

End Namespace