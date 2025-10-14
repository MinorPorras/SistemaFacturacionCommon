Imports SistemaFacturaciónCommon.SistemaFacturacion.Modules

Namespace SistemaFacturacion.Forms.Mantenimiento

    Public Class P_Hablador
        Private searchTimer As Timer
        Private productos As New List(Of String)()
        Private precioVenta As New List(Of String)()
        Private cantidad As New List(Of Integer)()

        Private currentProductIndex As Integer = 0
        Private currentQuantityIndex As Integer = 0
        Private printProducts As List(Of String)
        Private printPrices As List(Of String)
        Private printQuantities As List(Of Integer)

        ' Método para inicializar el temporizador y otros componentes necesarios
        Private Sub InicializarComponentes()
            ' Inicializar el temporizador
            searchTimer = New Timer With {
                .Interval = 100
            }
            ' Medio segundo
            AddHandler searchTimer.Tick, AddressOf OnSearchTimerTick
        End Sub

        Private Sub OnSearchTimerTick(sender As Object, e As EventArgs)
            ' Detener el temporizador y ejecutar la búsqueda
            searchTimer.Stop()
            REFRESCAR()
        End Sub
        Public Sub REFRESCAR()
            Task.Run(Sub()
                         Try
                             T.Tables.Clear()
                             SQL = "SELECT p.ID, p.codigo as 'Código', p.nombre as 'Nombre', v.precio_venta as 'Precio'" &
                                     " FROM producto p LEFT JOIN producto_precioVenta v ON p.ID = v.ID_Producto" +
                                     " where p.codigo LIKE '%" & TXT_BuscarProd.Text & "%' OR p.nombre LIKE '%" & TXT_BuscarProd.Text & "%' ORDER BY p.codigo ASC;"
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
                         Catch ex As Exception
                             Invoke(Sub()
                                        If DGV_BProd.IsHandleCreated Then
                                            If ex.Message <> "InvalidArgument=El valor de '0' no es válido para 'index'." & vbCrLf & "Nombre del parámetro: index" Then
                                                ' Mostrar un mensaje de error genérico
                                                msgError("Error al cargar la lista de clientes: " & ex.Message)
                                            End If
                                        End If
                                    End Sub)
                         End Try
                     End Sub)
        End Sub

        Private Sub DGV_BProd_DataBindingComplete(sender As Object, e As DataGridViewBindingCompleteEventArgs) Handles DGV_BProd.DataBindingComplete
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

        Private Sub P_Hablador_Load(sender As Object, e As EventArgs) Handles MyBase.Load
            InicializarComponentes()
            REFRESCAR()
        End Sub

        Private Sub TXT_BuscarProd_TextChanged(sender As Object, e As EventArgs) Handles TXT_BuscarProd.TextChanged
            If searchTimer IsNot Nothing Then
                searchTimer.Stop()
                searchTimer.Start()
            End If
        End Sub

        Private Sub BTN_RegresarPrd_Click(sender As Object, e As EventArgs) Handles BTN_RegresarPrd.Click
            C_Productos.Show()
            C_Productos.Select()
            Me.Close()
        End Sub

        Private Sub MNU_SELECCIONAR_Click(sender As Object, e As EventArgs) Handles MNU_SELECCIONAR.Click
            Dim id As Integer = Convert.ToInt32(DGV_BProd.SelectedRows(0).Cells(0).Value)
            Dim codigo As String = DGV_BProd.SelectedRows(0).Cells(1).Value.ToString()
            Dim nombre As String = DGV_BProd.SelectedRows(0).Cells(2).Value.ToString()
            Dim precio As Double = Convert.ToDouble(DGV_BProd.SelectedRows(0).Cells(3).Value)
            DGV_Hablador.Rows.Add(id, codigo, nombre, precio, 1)
        End Sub

        Private Sub MNU_ELIMINAR_Click(sender As Object, e As EventArgs) Handles MNU_ELIMINAR.Click
            DGV_Hablador.Rows.RemoveAt(DGV_Hablador.SelectedRows(0).Index)
        End Sub

        Private Sub BTN_Imprimir_Click(sender As Object, e As EventArgs) Handles BTN_Imprimir.Click

            ' Se rellenan las listas (tal como está en su código, es correcto)
            Dim productos As New List(Of String)
            Dim precioVenta As New List(Of String)
            Dim cantidad As New List(Of Integer)

            productos.Clear()
            precioVenta.Clear()
            cantidad.Clear()

            If DGV_Hablador.Rows.Count > 0 Then
                For i As Integer = 0 To DGV_Hablador.Rows.Count - 1
                    productos.Add(DGV_Hablador.Rows(i).Cells(2).Value.ToString())
                    precioVenta.Add(DGV_Hablador.Rows(i).Cells(3).Value.ToString())
                    cantidad.Add(Convert.ToInt32(DGV_Hablador.Rows(i).Cells(4).Value))
                Next
                Dim clsImpresionHabladores As New Cls_ImpresionHabladores()
                clsImpresionHabladores.CREAR_HABLADORES(DGV_Hablador, productos, precioVenta, cantidad)
            End If
        End Sub

        Private Sub BTN_Config_Click(sender As Object, e As EventArgs) Handles BTN_Config.Click
            entrarConfig(3, Me)
        End Sub
    End Class

End Namespace