Imports System.Globalization
Imports System.Threading.Tasks
Imports SistemaFacturaciónCommon.SistemaFacturacion.Data
Imports SistemaFacturaciónCommon.SistemaFacturacion.Forms.Caja
Imports SistemaFacturaciónCommon.SistemaFacturacion.Forms.Mantenimiento
Imports SistemaFacturaciónCommon.SistemaFacturacion.Modules
Imports TheArtOfDevHtmlRenderer.Adapters.RGraphicsPath

Namespace SistemaFacturacion.Forms.Busqueda
    Public Class B_Producto
        Friend ModProd As Boolean
        Friend idModProd As Integer
        Private searchTimer As Timer
        Public producto As New Cls_ProductoCaja

        ' Método para inicializar el temporizador y otros componentes necesarios
        Private Sub InicializarComponentes()
            ' Inicializar el temporizador
            searchTimer = New Timer With {
                .Interval = 100
            }
            ' Medio segundo
            AddHandler searchTimer.Tick, AddressOf OnSearchTimerTick
            TXT_BuscarProd.Text = producto.Producto
            TXT_codigo.Text = producto.Codigo
            TXT_Nombre.Text = producto.Producto
            TXT_CantProd.Text = producto.Cantidad
            TXT_Precio.Text = producto.Precio
        End Sub

        Private Sub OnSearchTimerTick(sender As Object, e As EventArgs)
            ' Detener el temporizador y ejecutar la búsqueda
            searchTimer.Stop()
            REFRESCAR()
        End Sub

        Private Sub B_Producto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
            InicializarComponentes()
            REFRESCAR()
        End Sub

        Public Sub REFRESCAR()
            Task.Run(Sub()
                         Try
                             T.Tables.Clear()
                             Dim busqueda As String = TXT_BuscarProd.Text.Trim()
                             Dim condicionBusqueda As String
                             If busqueda = "" Then
                                 condicionBusqueda = "1=1" ' Esto siempre será verdadero, mostrando todos los registros
                             Else
                                 condicionBusqueda = $"p.codigo LIKE '%{busqueda}%' OR p.nombre LIKE '%{busqueda}%'"
                             End If
                             SQL = "SELECT p.ID, p.codigo AS 'Código', p.nombre AS 'Nombre', v.precio_venta AS 'Precio de venta', " &
                                      "CASE WHEN p.variable = 1 THEN 'Si' ELSE 'No' END AS 'Variable' " &
                                      "FROM producto p " &
                                      "LEFT JOIN producto_precioVenta v ON p.ID = v.ID_Producto " &
                                      "WHERE " & condicionBusqueda &
                                      " ORDER BY p.codigo ASC;"

                             ' Asegúrate de que el control tiene un identificador de ventana antes de invocar
                             If DGV_BProd.IsHandleCreated Then
                                 Invoke(Sub()
                                            Cargar_Tabla(T, SQL)
                                            If T.Tables.Count > 0 AndAlso T.Tables(0).Rows.Count > 0 Then
                                                Dim bin As New BindingSource With {
                                                    .DataSource = T.Tables(0)
                                                }
                                                DGV_BProd.DataSource = bin
                                            Else ' Limpiar la fuente de datos si no se cargaron datos
                                                DGV_BProd.DataSource = Nothing
                                            End If
                                            TXT_BuscarProd.Select()
                                        End Sub)
                             Else
                                 ' Espera hasta que el control esté listo
                                 Me.BeginInvoke(Sub() REFRESCAR())
                             End If
                         Catch ex As Exception
                             If DGV_BProd.IsHandleCreated Then
                                 Invoke(Sub()
                                            If ex.Message <> "InvalidArgument=El valor de '0' no es válido para 'index'." & vbCrLf & "Nombre del parámetro: index" Then
                                                ' Mostrar un mensaje de error genérico
                                                msgError("Error al cargar la lista de clientes: " & ex.Message)
                                            End If
                                        End Sub)
                             End If
                         End Try
                     End Sub)
        End Sub


        Private Sub DGV_BProd_DataBindingComplete_1(sender As Object, e As DataGridViewBindingCompleteEventArgs) Handles DGV_BProd.DataBindingComplete
            Try
                For i As Integer = 0 To DGV_BProd.Columns.Count - 1
                    DGV_BProd.Columns(i).ReadOnly = True
                    Select Case i
                        Case 1
                            DGV_BProd.Columns(i).Width = 50
                        Case 2
                            DGV_BProd.Columns(i).Width = 200
                        Case 3
                            DGV_BProd.Columns(i).Width = 70
                    End Select
                Next
                DGV_BProd.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
                DGV_BProd.GridColor = Color.DarkGray
                DGV_BProd.Columns(0).Visible = False
            Catch ex As Exception
                ' Manejar el error si alguna columna no existe
                Console.WriteLine("Error al ocultar las columnas: " & ex.Message)
            End Try
        End Sub

        Private Sub TXT_BuscarProd_TextChanged(sender As Object, e As EventArgs) Handles TXT_BuscarProd.TextChanged
            If searchTimer IsNot Nothing Then
                searchTimer.Stop()
                searchTimer.Start()
            End If
        End Sub

        Private Sub BTN_RegresarPrd_Click(sender As Object, e As EventArgs) Handles BTN_RegresarPrd.Click
            If TypeOf (Owner) Is P_Caja Then
                Dim typedOwner = CType(Owner, P_Caja)
                typedOwner.TXT_BuscarProducto.SelectAll()
            End If

            If TypeOf (Owner) Is P_CajaCxC Then
                Dim typedOwner = CType(Owner, P_CajaCxC)
                typedOwner.TXT_BuscarProducto.SelectAll()
            End If

            Me.DialogResult = DialogResult.Cancel
        End Sub

        Private Sub BTN_SelectProd_Click(sender As Object, e As EventArgs) Handles BTN_SelectProd.Click
            If TXT_Precio.Text = "Variable" Then
                Dim prodVariableForm As New E_ProductoVariable
                prodVariableForm.LBL_Cod.Text = TXT_codigo.Text
                prodVariableForm.LBL_Producto.Text = TXT_Nombre.Text
                prodVariableForm.LBL_ID.Text = DGV_BProd.SelectedRows(0).Cells("ID").Value
                prodVariableForm.Owner = Owner
                prodVariableForm.cant = TXT_CantProd.Text
                Dim result As DialogResult = prodVariableForm.ShowDialog()
                If result = DialogResult.OK Then
                    producto = prodVariableForm.producto
                    Me.DialogResult = DialogResult.OK
                Else
                    Me.DialogResult = DialogResult.Cancel
                End If
                LIMPIAR()
                Exit Sub
            End If

            Dim prod As New Cls_ProductoCaja With {
                    .ID = LBL_IDProd.Text,
                    .Codigo = TXT_codigo.Text,
                    .Producto = TXT_Nombre.Text,
                    .Precio = Convert.ToDecimal(TXT_Precio.Text),
                    .Cantidad = CInt(TXT_CantProd.Text)
            }
            producto = prod
            Me.DialogResult = DialogResult.OK
        End Sub

        Private Sub BTN_MasCant_Click(sender As Object, e As EventArgs) Handles BTN_MasCant.Click
            Try
                producto.Cantidad = Convert.ToInt32(TXT_CantProd.Text)
                producto.Cantidad += 1
                TXT_CantProd.Text = producto.Cantidad
            Catch ex As Exception

            End Try

        End Sub

        Private Sub BTN_MenosCant_Click(sender As Object, e As EventArgs) Handles BTN_MenosCant.Click
            Try
                producto.Cantidad = Convert.ToInt32(TXT_CantProd.Text)
                If producto.Cantidad >= 1 Then
                    producto.Cantidad -= 1
                    TXT_CantProd.Text = producto.Cantidad
                End If
            Catch ex As Exception

            End Try
        End Sub

        Friend Sub LIMPIAR()
            TXT_BuscarProd.Clear()
            TXT_CantProd.Text = "1"
            TXT_codigo.Clear()
            TXT_Nombre.Clear()
            TXT_Precio.Clear()
        End Sub

        Private Sub DGV_BMarca_SelectionChanged(sender As Object, e As EventArgs) Handles DGV_BProd.SelectionChanged
            Try
                TXT_codigo.Text = DGV_BProd.SelectedRows(0).Cells("Código").Value.ToString()
                TXT_Nombre.Text = DGV_BProd.SelectedRows(0).Cells("Nombre").Value.ToString()
                If DGV_BProd.SelectedRows(0).Cells("Variable").Value.ToString() = "Si" Then
                    TXT_Precio.Text = "Variable"
                Else
                    TXT_Precio.Text = DGV_BProd.SelectedRows(0).Cells("Precio de venta").Value.ToString()
                End If
                LBL_IDProd.Text = DGV_BProd.SelectedRows(0).Cells("ID").Value.ToString()
            Catch ex As Exception
                TXT_codigo.Text = ""
                TXT_Nombre.Text = ""
                TXT_Precio.Text = ""
            End Try
        End Sub
    End Class
End Namespace
