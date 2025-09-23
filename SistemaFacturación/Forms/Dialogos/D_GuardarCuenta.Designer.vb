Namespace SistemaFacturacion.Forms.Dialogos

    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Class D_GuardarCuenta
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(D_GuardarCuenta))
            Me.Guna2BorderlessForm1 = New Guna.UI2.WinForms.Guna2BorderlessForm(Me.components)
            Me.Label1 = New System.Windows.Forms.Label()
            Me.Label2 = New System.Windows.Forms.Label()
            Me.TXT_Comentario = New Guna.UI2.WinForms.Guna2TextBox()
            Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
            Me.BTN_RegresarMarca = New Guna.UI2.WinForms.Guna2Button()
            Me.BTN_ConfirmGuardarCuenta = New Guna.UI2.WinForms.Guna2Button()
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
            'Label1
            '
            Me.Label1.AutoSize = True
            Me.Label1.Font = New System.Drawing.Font("Britannic Bold", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label1.ForeColor = System.Drawing.Color.White
            Me.Label1.Location = New System.Drawing.Point(64, 9)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(275, 41)
            Me.Label1.TabIndex = 74
            Me.Label1.Text = "Guardar cuenta"
            '
            'Label2
            '
            Me.Label2.AutoSize = True
            Me.Label2.Font = New System.Drawing.Font("Britannic Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label2.ForeColor = System.Drawing.Color.White
            Me.Label2.Location = New System.Drawing.Point(15, 76)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New System.Drawing.Size(111, 21)
            Me.Label2.TabIndex = 91
            Me.Label2.Text = "Comentario:"
            '
            'TXT_Comentario
            '
            Me.TXT_Comentario.BorderRadius = 20
            Me.TXT_Comentario.Cursor = System.Windows.Forms.Cursors.IBeam
            Me.TXT_Comentario.DefaultText = ""
            Me.TXT_Comentario.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
            Me.TXT_Comentario.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
            Me.TXT_Comentario.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
            Me.TXT_Comentario.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
            Me.TXT_Comentario.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.TXT_Comentario.Font = New System.Drawing.Font("Segoe UI", 9.0!)
            Me.TXT_Comentario.ForeColor = System.Drawing.Color.Black
            Me.TXT_Comentario.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.TXT_Comentario.Location = New System.Drawing.Point(19, 100)
            Me.TXT_Comentario.Name = "TXT_Comentario"
            Me.TXT_Comentario.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
            Me.TXT_Comentario.PlaceholderText = "Doble click para buscar"
            Me.TXT_Comentario.SelectedText = ""
            Me.TXT_Comentario.Size = New System.Drawing.Size(347, 42)
            Me.TXT_Comentario.TabIndex = 96
            '
            'Guna2Panel1
            '
            Me.Guna2Panel1.Controls.Add(Me.BTN_RegresarMarca)
            Me.Guna2Panel1.Controls.Add(Me.BTN_ConfirmGuardarCuenta)
            Me.Guna2Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.Guna2Panel1.Location = New System.Drawing.Point(0, 178)
            Me.Guna2Panel1.Name = "Guna2Panel1"
            Me.Guna2Panel1.Size = New System.Drawing.Size(391, 68)
            Me.Guna2Panel1.TabIndex = 97
            '
            'BTN_RegresarMarca
            '
            Me.BTN_RegresarMarca.BorderColor = System.Drawing.Color.Red
            Me.BTN_RegresarMarca.DialogResult = System.Windows.Forms.DialogResult.Cancel
            Me.BTN_RegresarMarca.DisabledState.BorderColor = System.Drawing.Color.DarkGray
            Me.BTN_RegresarMarca.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
            Me.BTN_RegresarMarca.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
            Me.BTN_RegresarMarca.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
            Me.BTN_RegresarMarca.Dock = System.Windows.Forms.DockStyle.Left
            Me.BTN_RegresarMarca.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
            Me.BTN_RegresarMarca.Font = New System.Drawing.Font("Ebrima", 20.25!, System.Drawing.FontStyle.Bold)
            Me.BTN_RegresarMarca.ForeColor = System.Drawing.Color.White
            Me.BTN_RegresarMarca.Image = Global.SistemaFacturaciónCommon.My.Resources.Resources.ICO_Back
            Me.BTN_RegresarMarca.ImageSize = New System.Drawing.Size(40, 40)
            Me.BTN_RegresarMarca.Location = New System.Drawing.Point(0, 0)
            Me.BTN_RegresarMarca.Name = "BTN_RegresarMarca"
            Me.BTN_RegresarMarca.Size = New System.Drawing.Size(201, 68)
            Me.BTN_RegresarMarca.TabIndex = 58
            Me.BTN_RegresarMarca.Text = "Regresar"
            '
            'BTN_ConfirmGuardarCuenta
            '
            Me.BTN_ConfirmGuardarCuenta.BorderColor = System.Drawing.Color.Red
            Me.BTN_ConfirmGuardarCuenta.DisabledState.BorderColor = System.Drawing.Color.DarkGray
            Me.BTN_ConfirmGuardarCuenta.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
            Me.BTN_ConfirmGuardarCuenta.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
            Me.BTN_ConfirmGuardarCuenta.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
            Me.BTN_ConfirmGuardarCuenta.Dock = System.Windows.Forms.DockStyle.Right
            Me.BTN_ConfirmGuardarCuenta.FillColor = System.Drawing.Color.MediumSeaGreen
            Me.BTN_ConfirmGuardarCuenta.Font = New System.Drawing.Font("Ebrima", 20.25!, System.Drawing.FontStyle.Bold)
            Me.BTN_ConfirmGuardarCuenta.ForeColor = System.Drawing.Color.White
            Me.BTN_ConfirmGuardarCuenta.Image = Global.SistemaFacturaciónCommon.My.Resources.Resources.ICO_Mas
            Me.BTN_ConfirmGuardarCuenta.ImageSize = New System.Drawing.Size(40, 40)
            Me.BTN_ConfirmGuardarCuenta.Location = New System.Drawing.Point(199, 0)
            Me.BTN_ConfirmGuardarCuenta.Name = "BTN_ConfirmGuardarCuenta"
            Me.BTN_ConfirmGuardarCuenta.Size = New System.Drawing.Size(192, 68)
            Me.BTN_ConfirmGuardarCuenta.TabIndex = 57
            Me.BTN_ConfirmGuardarCuenta.Text = "Guardar"
            '
            'D_GuardarCuenta
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer))
            Me.ClientSize = New System.Drawing.Size(391, 246)
            Me.Controls.Add(Me.Guna2Panel1)
            Me.Controls.Add(Me.TXT_Comentario)
            Me.Controls.Add(Me.Label2)
            Me.Controls.Add(Me.Label1)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.KeyPreview = True
            Me.Name = "D_GuardarCuenta"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "D_GuardarCuenta"
            Me.Guna2Panel1.ResumeLayout(False)
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
        Friend WithEvents Guna2BorderlessForm1 As Guna.UI2.WinForms.Guna2BorderlessForm
        Friend WithEvents Label1 As Label
        Friend WithEvents Label2 As Label
        Friend WithEvents TXT_Comentario As Guna.UI2.WinForms.Guna2TextBox
        Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
        Friend WithEvents BTN_RegresarMarca As Guna.UI2.WinForms.Guna2Button
        Friend WithEvents BTN_ConfirmGuardarCuenta As Guna.UI2.WinForms.Guna2Button
    End Class

End Namespace