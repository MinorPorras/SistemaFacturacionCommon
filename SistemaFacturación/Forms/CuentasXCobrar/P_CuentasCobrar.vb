Imports Guna.UI2.WinForms
Imports SistemaFacturaciónCommon.SistemaFacturacion.Modules
Imports SistemaFacturaciónCommon.SistemaFacturacion.Forms.Caja
Imports System.Data.SQLite
Imports Syncfusion.Windows.Forms.Tools
Imports SistemaFacturaciónCommon.SistemaFacturacion.Data

Namespace SistemaFacturacion.Forms.CuentasXCobrar

    Public Class P_CuentasCobrar
        Dim estadoIndex As Integer
        Private Sub P_CuentasCobrar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
            REFRESCAR()
        End Sub

        Private Sub CrearBotones()
            If T1 Is Nothing OrElse T1.Tables.Count <= 0 OrElse T1.Tables(0).Rows.Count <= 0 Then
                Dim lblNohayCxC As New Label With {
                    .Text = "No hay cuentas por cobrar",
                    .Name = $"lblNoHayCxC",
                    .ForeColor = Color.White,
                    .TextAlign = ContentAlignment.MiddleCenter,
                    .AutoSize = False,
                    .Font = New Font("Segoe UI", 22, FontStyle.Bold),
                    .Size = pan_CuentasCobrar.ClientSize
                }
                pan_CuentasCobrar.Controls.Add(lblNohayCxC)
                lblNohayCxC.BringToFront()
                Exit Sub
            End If

            For i = 0 To T1.Tables(0).Rows.Count - 1
                Dim cxc As New Cls_CuentasXCobrar With {
                    .ID = T1.Tables(0).Rows(i)("ID").ToString(),
                    .Cliente = T1.Tables(0).Rows(i)("nombre").ToString(),
                    .Comentario = T1.Tables(0).Rows(i)("comentario").ToString(),
                    .Estado = Convert.ToInt32(T1.Tables(0).Rows(i)("estado"))
                }

                Dim mainColor As Color
                Select Case cxc.Estado
                    Case 0 'Inactivo
                        mainColor = Color.IndianRed
                    Case 1 'Activo
                        mainColor = Color.MediumSeaGreen
                    Case 2 'Cobrada
                        mainColor = Color.FromArgb(255, 128, 0)
                    Case Else
                        mainColor = Color.Gray
                End Select
                ' 1. Crea el panel que contendrá todo (panel normal)
                Dim panelContenedor As New Guna2GroupBox With {
                    .Size = New Size(400, 180),
                    .BorderStyle = BorderStyle.FixedSingle,
                    .CustomBorderColor = mainColor,
                    .BorderColor = mainColor,
                    .Text = T1.Tables(0).Rows(i)("nombre").ToString(),
                    .ForeColor = Color.White,
                    .Font = New Font("Segoe UI", 16, FontStyle.Bold),
                    .TextAlign = TextAlignment.Center,
                    .AutoScroll = True,
                    .BorderRadius = 20
                }

                ' 2. Crea un Panel normal para los Labels internos
                Dim panelLabels As New Panel With {
                    .Name = "PAN_" & cxc.ID,
                    .Location = New Point(5, 5),
                    .BorderStyle = BorderStyle.FixedSingle,
                    .BackColor = Color.FromArgb(38, 38, 38), ' Establece el color de fondo original
                    .Cursor = Cursors.Hand, ' Cambia el cursor a mano para indicar que es clickeable
                    .Dock = Dock.Fill
                }
                AddHandler panelLabels.Click, AddressOf Label_Click_Select_Cuenta
                AddHandler panelLabels.MouseEnter, AddressOf PanelLabels_MouseEnter
                AddHandler panelLabels.MouseLeave, AddressOf PanelLabels_MouseLeave

                Dim panelButtons As New Panel With {
                    .Dock = DockStyle.Bottom,
                    .Size = New Size(panelContenedor.Width, 30)
                }

                Dim btnSwitchEstado As Guna2Button

                Select Case cxc.Estado
                    Case 0 'Inactivo
                        btnSwitchEstado = New Guna2Button With {
                            .Name = "BTN_Del" & cxc.ID,
                            .Text = "Activar",
                            .Size = New Size(198, 30),
                            .Location = New Point(5, 70),
                            .Dock = DockStyle.Left,
                            .FillColor = Color.MediumSeaGreen,
                            .ForeColor = Color.White,
                            .Font = New Font("Segoe UI", 16, FontStyle.Bold),
                            .ImageAlign = HorizontalAlignment.Center,
                            .Image = My.Resources.ICO_Eliminar,
                            .Cursor = Cursors.Hand
                        }
                    Case Else 'Activo
                        btnSwitchEstado = New Guna2Button With {
                            .Name = "BTN_Del" & cxc.ID,
                            .Text = "Desactivar",
                            .Size = New Size(198, 30),
                            .Location = New Point(5, 70),
                            .Dock = DockStyle.Left,
                            .FillColor = Color.IndianRed,
                            .ForeColor = Color.White,
                            .Font = New Font("Segoe UI", 16, FontStyle.Bold),
                            .ImageAlign = HorizontalAlignment.Center,
                            .Image = My.Resources.ICO_Eliminar,
                            .Cursor = Cursors.Hand
                        }
                End Select

                AddHandler btnSwitchEstado.Click, AddressOf BtnSwitchActive_Click
                AddHandler btnSwitchEstado.MouseEnter, AddressOf BtnSwitchEstado_MouseEnter
                AddHandler btnSwitchEstado.MouseLeave, AddressOf BtnSwitchEstado_MouseLeave
                ' 3. Crea el botón (con Dock.Bottom)
                Dim btnVerDetalles As New Guna2Button With {
                    .Name = "BTN_Detalles" & cxc.ID,
                    .Text = "Detalles",
                    .Size = New Size(198, 30),
                    .Location = New Point(5, 70),
                    .Dock = If(cxc.Estado <> 2, DockStyle.Right, DockStyle.Fill),
                    .ForeColor = Color.White,
                    .FillColor = Color.FromArgb(128, 128, 255),
                    .Font = New Font("Segoe UI", 16, FontStyle.Bold),
                    .ImageAlign = HorizontalAlignment.Center,
                    .Image = My.Resources.ICO_Search,
                    .Cursor = Cursors.Hand
                }
                AddHandler btnVerDetalles.Click, AddressOf BtnVerDetalles_Click
                AddHandler btnVerDetalles.MouseEnter, AddressOf BtnVerDetalles_MouseEnter
                AddHandler btnVerDetalles.MouseLeave, AddressOf BtnVerDetalles_MouseLeave

                Dim lblComentario As New Label With {
                    .Text = cxc.Comentario,
                    .Name = $"lblComentario_{cxc.ID}",
                    .ForeColor = Color.White,
                    .TextAlign = ContentAlignment.MiddleCenter,
                    .AutoSize = False,
                    .Font = New Font("Segoe UI", 14, FontStyle.Regular),
                    .Size = New Size(panelLabels.Width, panelLabels.Height / 2),
                    .Dock = DockStyle.Top
                }

                'Asigna los eventos de hover y click a lblComentario
                AddHandler lblComentario.Click, AddressOf Label_Click_Select_Cuenta
                AddHandler lblComentario.MouseEnter, AddressOf PanelLabels_MouseEnter
                AddHandler lblComentario.MouseLeave, AddressOf PanelLabels_MouseLeave

                Dim lblSaldoRestante As New Label With {
                    .Name = $"lblSaldoRestante_{cxc.ID}",
                    .Text = $"Pendiente: {cxc.ObtenerSaldoPendiente()}",
                    .ForeColor = Color.White,
                    .TextAlign = ContentAlignment.MiddleCenter,
                    .AutoSize = False,
                    .Font = New Font("Segoe UI", 14, FontStyle.Bold),
                    .Size = New Size(panelLabels.Width, panelLabels.Height / 2),
                    .Dock = DockStyle.Top
                }
                AddHandler lblSaldoRestante.Click, AddressOf Label_Click_Select_Cuenta
                AddHandler lblSaldoRestante.MouseEnter, AddressOf PanelLabels_MouseEnter
                AddHandler lblSaldoRestante.MouseLeave, AddressOf PanelLabels_MouseLeave

                ' Agregar los botones al panel de botones
                If cxc.Estado <> 2 Then
                    panelButtons.Controls.Add(btnSwitchEstado)
                End If

                panelButtons.Controls.Add(btnVerDetalles)

                ' 1. Añade el panel de botones (Dock.Bottom)
                panelContenedor.Controls.Add(panelButtons)

                ' 2. Añade el panel de etiquetas (Dock.Fill) DE ÚLTIMO
                panelContenedor.Controls.Add(panelLabels)

                ' Agregar los labels al panel de etiquetas
                panelLabels.Controls.Add(lblSaldoRestante)
                panelLabels.Controls.Add(lblComentario)

                ' Finalmente, añadir el panel contenedor completo al contenedor principal
                pan_CuentasCobrar.Controls.Add(panelContenedor)
            Next
        End Sub

        Private Function ObtenerSaldoPendiente(ID As Integer) As Decimal
            SQL = "SELECT 
                        ce.saldo_total - IFNULL((
                            SELECT SUM(cp.monto) 
                            FROM CC_Pagos cp 
                            WHERE cp.ID_Encabezado = ce.ID
                        ), 0) AS Saldo_Pendiente
                    FROM 
                        CC_Encabezado ce 
                    WHERE 
                        ce.ID = @ID;"
            Dim paramList As New List(Of SQLiteParameter) From {
                {New SQLiteParameter("@ID", ID)}
            }
            CargarTablaParam(T, SQL, paramList)
            'Se revisa que exista la tabla
            If T Is Nothing OrElse T.Tables.Count <= 0 Then
                Return 0
            End If
            'Se revisa que haya al menos una fila
            If T.Tables(0).Rows.Count <= 0 Then
                Return 0
            End If
            'Se obtiene el saldo y se revisa si este no es null
            Dim saldo As Object = T.Tables(0).Rows(0).Item("Saldo_Pendiente")

            If IsDBNull(saldo) Then
                Return 0
            End If
            'Se retorna el saldo como decimal
            Return Convert.ToDecimal(saldo)
        End Function

        ' Maneja el evento cuando el mouse entra en los labels de panel
        Private Sub PanelLabels_MouseEnter(sender As Object, e As EventArgs)
            Dim control As Control = CType(sender, Control)
            ' Se cambia el color del control padre (el panel)
            control.Parent.BackColor = Color.FromArgb(48, 48, 48)
        End Sub

        Private Sub PanelLabels_MouseLeave(sender As Object, e As EventArgs)
            Dim control As Control = CType(sender, Control)
            ' Se restaura el color del control padre (el panel)
            control.Parent.BackColor = Color.FromArgb(38, 38, 38)
        End Sub

        Private Sub BtnSwitchEstado_MouseEnter(sender As Object, e As EventArgs)
            Dim btn As Guna2Button = CType(sender, Guna2Button)
            If btn.Text = "Desactivar" Then ' Estado Activo/Otros -> Es el botón ROJO
                btn.FillColor = Color.FromArgb(215, 16, 0) ' Rojo más oscuro
            ElseIf btn.Text = "Activar" Then ' Estado Inactivo -> Es el botón VERDE
                btn.FillColor = Color.FromArgb(0, 192, 0) ' Verde más oscuro
            End If
        End Sub

        Private Sub BtnSwitchEstado_MouseLeave(sender As Object, e As EventArgs)
            Dim btn As Guna2Button = CType(sender, Guna2Button)
            If btn.Text = "Desactivar" Then ' Estado Activo/Otros -> Es el botón ROJO
                btn.FillColor = Color.FromArgb(255, 64, 64) ' Rojo original
            ElseIf btn.Text = "Activar" Then ' Estado Inactivo -> Es el botón VERDE
                btn.FillColor = Color.FromArgb(64, 255, 64) ' Verde original
            End If
        End Sub

        Private Sub BtnVerDetalles_MouseLeave(sender As Object, e As EventArgs)
            Dim btn As Guna2Button = CType(sender, Guna2Button)
            ' Restaura el color base
            btn.FillColor = Color.FromArgb(128, 128, 255)
        End Sub

        Private Sub BtnVerDetalles_MouseEnter(sender As Object, e As EventArgs)
            Dim btn As Guna2Button = CType(sender, Guna2Button)
            ' Cambia a un color rojo más oscuro
            btn.FillColor = Color.FromArgb(110, 110, 255)
        End Sub

        Private Sub BtnVerDetalles_Click(sender As Object, e As EventArgs)
            'Se obtiene el nombre del botón que se presionó
            Dim btnDetalleNombre As String = sender.name
            ' Se hace un substring para obtener el ID de la factura que está en el nombre del botón
            Dim idEncabezado As String = btnDetalleNombre.Substring(12)

            Dim detailsForm As New P_VerDetallesCxC With {
                .Owner = Me,
                .ID = idEncabezado
            }
            detailsForm.Show()
            Me.Hide()
        End Sub

        Private Sub LimpiarBotones()
            pan_CuentasCobrar.Controls.Clear()
        End Sub

        Private Sub BtnSwitchActive_Click(sender As Object, e As EventArgs)
            'Se obtiene el nombre del botón que se presionó
            Dim btnDelNombre As String = sender.name
            ' Se hace un substring para obtener el ID de la factura que está en el nombre del botón
            Dim idEncabezado As String = btnDelNombre.Substring(7)

            ' Se busca el control Label por su nombre (lblComentario_ID)
            Dim controlesEncontrados() As Control = Controls.Find($"lblComentario_{idEncabezado}", True)

            ' Se verifica si se encontró el control y si este es del tipo correcto
            If controlesEncontrados.Length <= 0 Or TypeOf controlesEncontrados(0) IsNot Label Then
                MSG.msgError("No se encontró la cuenta por cobrar")
                Return
            End If

            ' Se obtiene el objeto Label y se accede a su propiedad Text
            Dim lblComentario As Label = CType(controlesEncontrados(0), Label)
            Dim comentarioTexto As String = lblComentario.Text


            ' Se verifica que el usuario desea eliminar la cuenta, si no, se sale del sub
            If Not msgCambiarEstadoCuenta(sender.text, comentarioTexto) Then
                Exit Sub
            End If

            Dim nuevoEstadoID As Integer = 0
            Select Case sender.text
                Case "Desactivar"
                    nuevoEstadoID = 0
                Case "Activar"
                    nuevoEstadoID = 1
            End Select
            Dim CuentaEliminada As Boolean = SwitchEstadoCuenta(idEncabezado, nuevoEstadoID)

            'Se elimina la cuenta de la base de datos
            If Not CuentaEliminada Then
                MSG.msgError("No se pudo eliminar correctamente la cuenta")
            End If
            REFRESCAR()
        End Sub

        Private Sub Label_Click_Select_Cuenta(sender As Object, e As EventArgs)
            ' 1. Obtener el Label que fue clickeado
            Dim label As Label = CType(sender, Label)

            ' 2. Obtener el Panel padre del Label
            Dim panel As Panel = CType(label.Parent, Panel)

            ' 3. Extraer el ID de la factura del nombre del Panel
            Dim idCuenta As String = panel.Name.Replace("PAN_", "")

            Using cajaForm As New P_CajaCxC
                cajaForm.idCuenta = idCuenta
                cajaForm.ShowDialog()
                REFRESCAR()
            End Using
        End Sub

        Private Sub BTN_Regresar_Click(sender As Object, e As EventArgs) Handles BTN_Regresar.Click
            Owner.Show()
            Me.Close()
        End Sub



        Private Sub REFRESCAR()
            SQL = "SELECT e.ID , c.nombre , e.comentario, e.estado
                    FROM CC_Encabezado e
                    LEFT JOIN clientes c ON c.codigo = e.ID_Cliente"
            If estadoIndex <> 1 And estadoIndex <> 0 And estadoIndex <> 2 Then
                Cargar_Tabla(T1, SQL)
            Else
                SQL += " WHERE e.estado = @estado"

                Dim paramList As New List(Of SQLiteParameter) From {
                    {New SQLiteParameter("@estado", estadoIndex)}
                }
                CargarTablaParam(T1, SQL, paramList)
            End If

            LimpiarBotones()
            CrearBotones()
        End Sub

        Private Sub CBX_EstadoCuenta_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBX_EstadoCuenta.SelectedIndexChanged
            estadoIndex = CBX_EstadoCuenta.SelectedIndex
            REFRESCAR()
        End Sub
    End Class

End Namespace