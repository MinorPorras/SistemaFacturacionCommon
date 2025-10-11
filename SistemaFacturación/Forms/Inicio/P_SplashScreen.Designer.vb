<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class P_SplashScreen
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(P_SplashScreen))
        Me.Guna2PictureBox1 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.PrgIndicator = New Guna.UI2.WinForms.Guna2ProgressIndicator()
        Me.LBL_Info = New System.Windows.Forms.Label()
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Guna2PictureBox1
        '
        Me.Guna2PictureBox1.Image = Global.SistemaFacturaciónCommon.My.Resources.Resources.logoCompletoSFCommonTransparent
        Me.Guna2PictureBox1.ImageRotate = 0!
        Me.Guna2PictureBox1.Location = New System.Drawing.Point(112, -120)
        Me.Guna2PictureBox1.Name = "Guna2PictureBox1"
        Me.Guna2PictureBox1.Size = New System.Drawing.Size(556, 500)
        Me.Guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Guna2PictureBox1.TabIndex = 0
        Me.Guna2PictureBox1.TabStop = False
        '
        'PrgIndicator
        '
        Me.PrgIndicator.Location = New System.Drawing.Point(340, 348)
        Me.PrgIndicator.Name = "PrgIndicator"
        Me.PrgIndicator.ProgressColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.PrgIndicator.Size = New System.Drawing.Size(90, 90)
        Me.PrgIndicator.TabIndex = 1
        '
        'LBL_Info
        '
        Me.LBL_Info.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_Info.ForeColor = System.Drawing.SystemColors.Control
        Me.LBL_Info.Location = New System.Drawing.Point(107, 240)
        Me.LBL_Info.MaximumSize = New System.Drawing.Size(561, 105)
        Me.LBL_Info.Name = "LBL_Info"
        Me.LBL_Info.Size = New System.Drawing.Size(561, 105)
        Me.LBL_Info.TabIndex = 2
        Me.LBL_Info.Text = "Inicializando el sistema"
        Me.LBL_Info.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'P_SplashScreen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.LBL_Info)
        Me.Controls.Add(Me.PrgIndicator)
        Me.Controls.Add(Me.Guna2PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "P_SplashScreen"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Common Sistema de facturación"
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Guna2PictureBox1 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents PrgIndicator As Guna.UI2.WinForms.Guna2ProgressIndicator
    Friend WithEvents LBL_Info As Label
End Class
