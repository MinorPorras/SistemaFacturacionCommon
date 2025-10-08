Imports Guna.UI2.WinForms
Imports SistemaFacturaciónCommon.SistemaFacturacion.Modules
Imports SistemaFacturaciónCommon.SistemaFacturacion.Forms.Caja
Imports System.Data.SQLite
Imports Syncfusion.Windows.Forms.Tools
Imports SistemaFacturaciónCommon.SistemaFacturacion.Data

Namespace SistemaFacturacion.Forms.CuentasXCobrar

    Public Class P_CuentasCobrar
        Private Sub Btn_Regresar_Click(sender As Object, e As EventArgs) Handles btn_Regresar.Click
            Owner.Show()
            Me.Close()
        End Sub

        Private Sub P_CuentasCobrar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
            CrearBotones()
        End Sub

        Private Sub CrearBotones()
            SQL = "SELECT e.ID , c.nombre , e.comentario 
                    FROM CC_Encabezado e
                    LEFT JOIN clientes c ON c.codigo = e.ID_Cliente"
            T1.Tables.Clear()
            Cargar_Tabla(T1, SQL)
            If T Is Nothing OrElse T.Tables.Count <= 0 OrElse T.Tables(0).Rows.Count <= 0 Then
                MsgBox("No hay facturas por cobrar", MsgBoxStyle.Information, "Aviso")
                Exit Sub
            End If

            For i = 0 To T1.Tables(0).Rows.Count - 1
                Dim cxc As New Cls_CuentasXCobrar With {
                    .ID = T1.Tables(0).Rows(i)("ID").ToString(),
                    .Cliente = T1.Tables(0).Rows(i)("nombre").ToString(),
                    .comentario = T1.Tables(0).Rows(i)("comentario").ToString()
                }
                ' 1. Crea el panel que contendrá todo (panel normal)
                Dim panelContenedor As New Guna2GroupBox With {
                    .Size = New Size(400, 180),
                    .BorderStyle = BorderStyle.FixedSingle,
                    .CustomBorderColor = Color.FromArgb(255, 128, 0),
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

                ' 3. Crea el botón (con Dock.Bottom)
                Dim btnEliminar As New Guna2Button With {
                    .Name = "BTN_Del" & cxc.ID,
                    .Text = "Eliminar",
                    .Size = New Size(198, 30),
                    .Location = New Point(5, 70),
                    .Dock = DockStyle.Left,
                    .FillColor = Color.FromArgb(255, 64, 64),
                    .ForeColor = Color.White,
                    .Font = New Font("Segoe UI", 16, FontStyle.Bold),
                    .ImageAlign = HorizontalAlignment.Center,
                    .Image = My.Resources.ICO_Eliminar,
                    .Cursor = Cursors.Hand
                }
                AddHandler btnEliminar.Click, AddressOf BtnEliminar_Click
                AddHandler btnEliminar.MouseEnter, AddressOf BtnEliminar_MouseEnter
                AddHandler btnEliminar.MouseLeave, AddressOf BtnEliminar_MouseLeave

                ' 3. Crea el botón (con Dock.Bottom)
                Dim btnVerDetalles As New Guna2Button With {
                    .Name = "BTN_Detalles" & cxc.ID,
                    .Text = "Detalles",
                    .Size = New Size(198, 30),
                    .Location = New Point(5, 70),
                    .Dock = DockStyle.Right,
                    .ForeColor = Color.White,
                    .FillColor = Color.FromArgb(128, 128, 255),
                    .Font = New Font("Segoe UI", 16, FontStyle.Bold),
                    .ImageAlign = HorizontalAlignment.Center,
                    .Image = My.Resources.ICO_Search,
                    .Cursor = Cursors.Hand
                }
                AddHandler btnVerDetalles.Click, AddressOf btnVerDetalles_Click
                AddHandler btnVerDetalles.MouseEnter, AddressOf btnVerDetalles_MouseEnter
                AddHandler btnVerDetalles.MouseLeave, AddressOf btnVerDetalles_MouseLeave

                Dim lblComentario As New Label With {
                    .Text = cxc.comentario,
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
                    .Text = $"Pendiente: {cxc.obtenerSaldoPendiente()}",
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
                panelButtons.Controls.Add(btnEliminar)
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

        ' Esta subrutina se ejecuta cuando el mouse entra al botón
        Private Sub BtnEliminar_MouseEnter(sender As Object, e As EventArgs)
            Dim btn As Guna2Button = CType(sender, Guna2Button)
            ' Restaura el color base
            btn.FillColor = Color.FromArgb(215, 16, 0)
        End Sub

        ' Esta subrutina se ejecuta cuando el mouse sale del botón
        Private Sub BtnEliminar_MouseLeave(sender As Object, e As EventArgs)
            Dim btn As Guna2Button = CType(sender, Guna2Button)
            ' Restaura el color base
            btn.FillColor = Color.FromArgb(255, 64, 64)
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

        Private Async Sub BtnEliminar_Click(sender As Object, e As EventArgs)
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
            If Not MSG.msgEliminar($"la cuenta con el comentario: {comentarioTexto}") Then
                Return
            End If

            Dim CuentaEliminada As Boolean = Await ELIMINAR_CxC(idEncabezado)

            'Se elimina la cuenta de la base de datos
            If Not CuentaEliminada Then
                MSG.msgError("No se pudo eliminar correctamente la cuenta")
            End If


            ' 1. Limpia todos los botones existentes
            LimpiarBotones()

            ' 2. Vuelve a cargar los botones desde la base de datos
            CrearBotones()
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
                Me.Select()
                LimpiarBotones()
                CrearBotones()
            End Using
        End Sub
    End Class

End Namespace