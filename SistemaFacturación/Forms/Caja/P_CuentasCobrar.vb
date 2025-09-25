Imports Guna.UI2.WinForms
Imports SistemaFacturaciónCommon.SistemaFacturacion.Modules

Namespace SistemaFacturacion.Forms.Caja

    Public Class P_CuentasCobrar
        Private Sub btn_Regresar_Click(sender As Object, e As EventArgs) Handles btn_Regresar.Click
            If TypeOf Owner Is P_Caja Then
                Dim caja = CType(Owner, P_Caja)
                caja.isDialogOpen = False
            End If
            Me.Close()
        End Sub

        Private Sub P_CuentasCobrar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
            CrearBotones()
        End Sub

        Private Sub CrearBotones()
            SQL = "SELECT f.ID , c.nombre , fc.comentario 
                FROM factura f
                LEFT JOIN clientes c ON c.codigo  = f.ID_Cliente 
                LEFT JOIN factura_comentario fc ON f.ID = fc.ID_Factura
                WHERE f.cobrada = 0"
            T1.Tables.Clear()
            Cargar_Tabla(T1, SQL)
            If T.Tables(0).Rows.Count <= 0 Then
                MsgBox("No hay facturas por cobrar", MsgBoxStyle.Information, "Aviso")
                Return
            End If

            For i = 0 To T1.Tables(0).Rows.Count - 1
                Dim idFactura = T1.Tables(0).Rows(i)("ID").ToString()

                ' 1. Crea el panel que contendrá todo (panel normal)
                Dim panelContenedor As New Panel With {
                .Size = New Size(300, 100),
                .BorderStyle = BorderStyle.FixedSingle
                }

                ' 2. Crea un Panel normal para los Labels internos
                Dim panelLabels As New Panel With {
                .Name = "PAN_" & idFactura,
                .Size = New Size(290, 60), ' Adjusted size to fit inside the container
                .Location = New Point(5, 5),
                .BorderStyle = BorderStyle.FixedSingle,
                .BackColor = Color.FromArgb(38, 38, 38), ' Establece el color de fondo original
                .Cursor = Cursors.Hand ' Cambia el cursor a mano para indicar que es clickeable
                }

                ' 3. Crea el botón (con Dock.Bottom)
                Dim btnEliminar As New Guna2Button With {
                .Name = "BTN_" & idFactura,
                .Text = "Eliminar",
                .Size = New Size(290, 30), ' Adjusted size
                .Location = New Point(5, 70),
                .Dock = DockStyle.Bottom,
                .FillColor = Color.White,
                .ForeColor = Color.FromArgb(255, 64, 64),
                .Font = New Font("Segoe UI", 16, FontStyle.Bold),
                .ImageAlign = HorizontalAlignment.Center,
                .Image = My.Resources.ICO_Eliminar,
                .Cursor = Cursors.Hand
                }
                AddHandler btnEliminar.Click, AddressOf BtnEliminar_Click
                AddHandler btnEliminar.MouseEnter, AddressOf BtnEliminar_MouseEnter
                AddHandler btnEliminar.MouseLeave, AddressOf BtnEliminar_MouseLeave

                ' Se añade el botón primero para que el Dock.Fill del panelLabels funcione
                panelContenedor.Controls.Add(btnEliminar)
                panelContenedor.Controls.Add(panelLabels)

                ' 4. Posiciona los Labels dentro del panelLabels
                Dim lblNombre As New Label With {
                .Text = T1.Tables(0).Rows(i)("nombre").ToString(),
                .ForeColor = Color.White,
                .TextAlign = ContentAlignment.MiddleCenter,
                .AutoSize = False,
                .Size = New Size(panelLabels.Width, panelLabels.Height / 2),
                .Location = New Point(0, 0)
                }
                panelLabels.Controls.Add(lblNombre)
                'Asigna los eventos de hover y click a lblNombre
                AddHandler lblNombre.Click, AddressOf Label_Click_Select_Cuenta
                AddHandler lblNombre.MouseEnter, AddressOf PanelLabels_MouseEnter
                AddHandler lblNombre.MouseLeave, AddressOf PanelLabels_MouseLeave

                Dim lblComentario As New Label
                If IsDBNull(T1.Tables(0).Rows(i)("comentario")) Then
                    lblComentario.Text = "Sin comentario"
                Else
                    lblComentario.Text = T1.Tables(0).Rows(i)("comentario").ToString()
                End If
                lblComentario.Name = $"lblComentario_{idFactura}"
                lblComentario.ForeColor = Color.White
                lblComentario.TextAlign = ContentAlignment.MiddleCenter
                lblComentario.AutoSize = False
                lblComentario.Size = New Size(panelLabels.Width, panelLabels.Height / 2)
                lblComentario.Location = New Point(0, panelLabels.Height / 2)
                'Asigna los eventos de hover y click a lblComentario
                AddHandler lblComentario.Click, AddressOf Label_Click_Select_Cuenta
                AddHandler lblComentario.MouseEnter, AddressOf PanelLabels_MouseEnter
                AddHandler lblComentario.MouseLeave, AddressOf PanelLabels_MouseLeave
                panelLabels.Controls.Add(lblComentario)

                pan_CuentasCobrar.Controls.Add(panelContenedor)
            Next
        End Sub

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
            ' Cambia a un color rojo más oscuro
            btn.FillColor = Color.WhiteSmoke
        End Sub

        ' Esta subrutina se ejecuta cuando el mouse sale del botón
        Private Sub BtnEliminar_MouseLeave(sender As Object, e As EventArgs)
            Dim btn As Guna2Button = CType(sender, Guna2Button)
            ' Restaura el color base
            btn.FillColor = Color.White
        End Sub

        Private Sub LimpiarBotones()
            pan_CuentasCobrar.Controls.Clear()
        End Sub

        Private Async Sub BtnEliminar_Click(sender As Object, e As EventArgs)
            'Se obtiene el nombre del botón que se presionó
            Dim btnDelNombre As String = sender.name
            ' Se hace un substring para obtener el ID de la factura que está en el nombre del botón
            Dim idFactura As String = btnDelNombre.Substring(4)

            ' Se busca el control Label por su nombre (lblComentario_ID)
            Dim controlesEncontrados() As Control = Controls.Find($"lblComentario_{idFactura}", True)

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

            Dim FacturaEliminada As Boolean = Await ELIMINAR_FACT(idFactura)

            'Se elimina la cuenta de la base de datos
            If Not FacturaEliminada Then
                MSG.msgError("No se pudo eliminar correctamente la factura")
            End If


            ' 1. Limpia todos los botones existentes
            LimpiarBotones()

            ' 2. Vuelve a cargar los botones desde la base de datos
            CrearBotones()
        End Sub

        Private Async Sub Label_Click_Select_Cuenta(sender As Object, e As EventArgs)
            ' 1. Obtener el Label que fue clickeado
            Dim label As Label = CType(sender, Label)

            ' 2. Obtener el Panel padre del Label
            Dim panel As Panel = CType(label.Parent, Panel)

            ' 3. Extraer el ID de la factura del nombre del Panel
            Dim idFactura As String = panel.Name.Replace("PAN_", "")

            Dim controlEncontrado() As Control = panel.Controls.Find($"lblComentario_{idFactura}", True)
            Dim comentarioTexto As String = ""
            ' Se verifica si se encontró el control
            If controlEncontrado.Length > 0 AndAlso TypeOf controlEncontrado(0) Is Label Then
                ' Se obtiene el objeto Label y se accede a su propiedad Text
                Dim lblComentario As Label = CType(controlEncontrado(0), Label)
                comentarioTexto = lblComentario.Text
            End If
            Dim SQLFact = $"SELECT num_factura, total, ID_Cliente FROM factura WHERE ID = {idFactura}"
            Dim tareaFactura As Task(Of DataSet) = Task.Run(Function()
                                                                ' 4. Consultar los detalles de la factura y los productos (la lógica es la misma)
                                                                Dim tablaFact As New DataSet
                                                                Cargar_Tabla(tablaFact, SQLFact)
                                                                Return tablaFact
                                                            End Function)

            Dim SQLProd = $"SELECT ID_Producto, cant, precio_venta FROM factura_producto WHERE ID_Factura = {idFactura}"
            Dim tareaProductos As Task(Of DataSet) = Task.Run(Function()
                                                                  Dim tablaProd As New DataSet
                                                                  Cargar_Tabla(tablaProd, SQLProd)
                                                                  Return tablaProd
                                                              End Function)

            Await Task.WhenAll(tareaFactura, tareaProductos)

            Dim T_Factura = tareaFactura.Result
            Dim T_Productos = tareaProductos.Result

            ' 5. Pasar los datos a la caja
            If T_Productos.Tables(0).Rows.Count > 0 And T_Factura.Tables(0).Rows.Count > 0 Then
                Dim cajaForm As P_Caja = CType(Me.Owner, P_Caja)
                cajaForm.CargarFacturaDesdeCuentas(T_Productos.Tables(0), T_Factura.Tables(0).Rows(0)("num_factura"), T_Factura.Tables(0).Rows(0)("total"),
                                                   idFactura, T_Factura.Tables(0).Rows(0)("ID_Cliente"), comentarioTexto)
                If TypeOf Owner Is P_Caja Then
                    Dim caja = CType(Owner, P_Caja)
                    caja.isDialogOpen = False
                End If
                Me.Close()
            Else
                If TypeOf Owner Is P_Caja Then
                    Dim caja = CType(Owner, P_Caja)
                    caja.isDialogOpen = False
                End If
                MSG.msgError("No se encontraron datos para esta factura.")
            End If
        End Sub
    End Class

End Namespace