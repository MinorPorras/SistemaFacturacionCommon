Namespace SistemaFacturacion.Forms.Caja

    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Class P_CuentasCobrar
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(P_CuentasCobrar))
            Me.Guna2BorderlessForm1 = New Guna.UI2.WinForms.Guna2BorderlessForm(Me.components)
            Me.pan_CuentasCobrar = New Guna.UI2.WinForms.Guna2Panel()
            Me.Label1 = New System.Windows.Forms.Label()
            Me.FlowLayout1 = New Syncfusion.Windows.Forms.Tools.FlowLayout(Me.components)
            Me.btn_Regresar = New Syncfusion.WinForms.Controls.SfButton()
            CType(Me.FlowLayout1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'Guna2BorderlessForm1
            '
            Me.Guna2BorderlessForm1.BorderRadius = 25
            Me.Guna2BorderlessForm1.ContainerControl = Me
            Me.Guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6R
            Me.Guna2BorderlessForm1.TransparentWhileDrag = True
            '
            'pan_CuentasCobrar
            '
            Me.pan_CuentasCobrar.AutoScroll = True
            Me.pan_CuentasCobrar.Location = New System.Drawing.Point(1, 76)
            Me.pan_CuentasCobrar.Name = "pan_CuentasCobrar"
            Me.pan_CuentasCobrar.Size = New System.Drawing.Size(936, 431)
            Me.pan_CuentasCobrar.TabIndex = 0
            '
            'Label1
            '
            Me.Label1.AutoSize = True
            Me.Label1.Font = New System.Drawing.Font("Britannic Bold", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label1.ForeColor = System.Drawing.Color.White
            Me.Label1.Location = New System.Drawing.Point(283, 32)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(338, 41)
            Me.Label1.TabIndex = 73
            Me.Label1.Text = "Cuentas por cobrar"
            '
            'FlowLayout1
            '
            Me.FlowLayout1.ContainerControl = Me.pan_CuentasCobrar
            '
            'btn_Regresar
            '
            Me.btn_Regresar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
            Me.btn_Regresar.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.btn_Regresar.Font = New System.Drawing.Font("Ebrima", 20.25!, System.Drawing.FontStyle.Bold)
            Me.btn_Regresar.ForeColor = System.Drawing.Color.White
            Me.btn_Regresar.ImageSize = New System.Drawing.Size(40, 40)
            Me.btn_Regresar.Location = New System.Drawing.Point(0, 528)
            Me.btn_Regresar.Name = "btn_Regresar"
            Me.btn_Regresar.RightToLeft = System.Windows.Forms.RightToLeft.No
            Me.btn_Regresar.Size = New System.Drawing.Size(939, 55)
            Me.btn_Regresar.Style.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
            Me.btn_Regresar.Style.FocusedBackColor = System.Drawing.Color.Maroon
            Me.btn_Regresar.Style.FocusedForeColor = System.Drawing.Color.White
            Me.btn_Regresar.Style.ForeColor = System.Drawing.Color.White
            Me.btn_Regresar.Style.HoverBackColor = System.Drawing.Color.Maroon
            Me.btn_Regresar.Style.HoverForeColor = System.Drawing.Color.White
            Me.btn_Regresar.Style.Image = Global.SistemaFacturaciónCommon.My.Resources.Resources.ICO_Back
            Me.btn_Regresar.TabIndex = 74
            Me.btn_Regresar.Text = "Regresar"
            Me.btn_Regresar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.btn_Regresar.UseVisualStyleBackColor = False
            '
            'P_CuentasCobrar
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer))
            Me.ClientSize = New System.Drawing.Size(939, 583)
            Me.Controls.Add(Me.btn_Regresar)
            Me.Controls.Add(Me.Label1)
            Me.Controls.Add(Me.pan_CuentasCobrar)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.Name = "P_CuentasCobrar"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "P_CuentasCobrar"
            CType(Me.FlowLayout1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub

        Friend WithEvents Guna2BorderlessForm1 As Guna.UI2.WinForms.Guna2BorderlessForm
        Friend WithEvents pan_CuentasCobrar As Guna.UI2.WinForms.Guna2Panel
        Friend WithEvents Label1 As Label
        Friend WithEvents FlowLayout1 As Syncfusion.Windows.Forms.Tools.FlowLayout
        Friend WithEvents btn_Regresar As Syncfusion.WinForms.Controls.SfButton
    End Class

End Namespace