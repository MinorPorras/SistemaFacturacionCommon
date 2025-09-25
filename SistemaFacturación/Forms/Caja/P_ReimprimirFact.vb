Imports System.Data.SQLite
Imports SistemaFacturaciónCommon.SistemaFacturacion.Data
Imports SistemaFacturaciónCommon.SistemaFacturacion.Modules


Namespace SistemaFacturacion.Forms.Caja

    Public Class P_ReimprimirFact
        Private searchTimer As Timer

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

        Private Sub P_ReimprimirFact_Load(sender As Object, e As EventArgs) Handles MyBase.Load
            InicializarComponentes()
        End Sub

        Private Async Sub P_ReimprimirFact_Async_Load(sender As Object, e As EventArgs) Handles MyBase.Load
            ' Esperar un pequeño retraso para asegurarse de que el formulario está completamente cargado
            Await Task.Delay(100)
            Me.Select()
            REFRESCAR()
        End Sub

        Friend Sub REFRESCAR()
            ' Ejecutar la tarea en un hilo de fondo
            Task.Run(Sub()
                         Try
                             ' Crear la consulta SQL de forma segura
                             Dim consulta As String = "SELECT f.ID, printf('%015d', CAST(f.num_factura AS INTEGER)) AS 'Num factura', " &
                                         "strftime('%d-%m-%Y %H:%M:%S', f.fecha_emision) AS 'Fecha de emisión', c.nombre AS 'Cliente', u.usuario AS 'Cajero', " &
                                         "f.efectivo_cliente AS 'Pago efectivo', f.tarjeta_cliente AS 'Pago tarjeta', f.vuelto AS 'Vuelto', " &
                                         "fc.comentario AS 'Comentario', f.total AS 'Total', CASE WHEN f.tipo_venta = 0 THEN 'Efectivo' " &
                                         "WHEN f.tipo_venta = 1 THEN 'Tarjeta' " &
                                         "WHEN f.tipo_venta = 2 THEN 'Sinpe' " &
                                         "WHEN f.tipo_venta = 3 THEN 'Depósito' " &
                                         "WHEN f.tipo_venta = 4 THEN 'Mixto' " &
                                         "ELSE 'Efectivo' END AS 'Tipo venta', " &
                                         "f.cobrada AS 'Cobrada' " &
                                         "FROM factura f " &
                                         "LEFT JOIN clientes c ON c.ID = f.ID_CLIENTE " &
                                         "LEFT JOIN usuario u ON u.ID = f.ID_USUARIO " &
                                         "LEFT JOIN factura_comentario fc ON fc.ID_Factura = f.ID "

                             Dim parametros As New List(Of SQLiteParameter)()
                             Dim busqueda As String = ""

                             ' Usamos Invoke para acceder al control TXT_BuscarFact en el hilo de la UI
                             Invoke(Sub()
                                        busqueda = TXT_BuscarFact.Text.Trim()
                                    End Sub)

                             ' Construir la cláusula WHERE y añadir el parámetro de búsqueda
                             Dim condicionBusqueda As String
                             If Not String.IsNullOrWhiteSpace(busqueda) Then
                                 condicionBusqueda = "WHERE f.cobrada = 1 AND printf('%015d', CAST(f.num_factura AS INTEGER)) LIKE @busqueda "
                                 parametros.Add(New SQLiteParameter("@busqueda", "%" & busqueda & "%"))
                             Else
                                 condicionBusqueda = "WHERE f.cobrada = 1 "
                             End If

                             ' Añadir el ORDER BY y el LIMIT
                             Dim cant As String = ""
                             Invoke(Sub()
                                        If RDB_200.Checked Then
                                            cant = "LIMIT 200"
                                        ElseIf RDB_100.Checked Then
                                            cant = "LIMIT 100"
                                        ElseIf RDB_All.Checked Then
                                            cant = "" ' Sin límite
                                        Else
                                            cant = "LIMIT 50"
                                        End If
                                    End Sub)

                             ' Unir todas las partes de la consulta
                             consulta &= condicionBusqueda & "ORDER BY CAST(f.num_factura AS INTEGER) DESC " & cant & ";"

                             ' Limpiar la tabla antes de cargar nuevos datos
                             T.Tables.Clear()

                             ' Cargar los datos de forma segura usando el método CargarTablaParam
                             CargarTablaParam(T, consulta, parametros)

                             ' Invocar al hilo de la UI para actualizar el DataGridView
                             Invoke(Sub()
                                        MNU_REIMPRIMIR.Visible = False
                                        MNU_Datos.Visible = False
                                        If T.Tables.Count > 0 AndAlso T.Tables(0).Rows.Count > 0 Then
                                            Dim bin As New BindingSource With {.DataSource = T.Tables(0)}
                                            DGV_ReimprimirFact.DataSource = bin
                                            MNU_REIMPRIMIR.Visible = True
                                            MNU_Datos.Visible = True
                                        Else
                                            DGV_ReimprimirFact.DataSource = Nothing
                                        End If
                                        TXT_BuscarFact.Select()
                                    End Sub)

                         Catch ex As Exception
                             ' Manejar la excepción en el hilo de la UI
                             Invoke(Sub()
                                        If DGV_ReimprimirFact.IsHandleCreated Then
                                            ' Ignorar el error específico de índice
                                            If ex.Message <> "InvalidArgument=El valor de '0' no es válido para 'index'." & vbCrLf & "Nombre del parámetro: index" Then
                                                msgError("Error al cargar la lista de facturas: " & ex.Message)
                                            End If
                                        End If
                                    End Sub)
                         End Try
                     End Sub)
        End Sub

        Private Sub DGV_ReimprimirFact_DataBindingComplete(sender As Object, e As DataGridViewBindingCompleteEventArgs) Handles DGV_ReimprimirFact.DataBindingComplete
            Me.BeginInvoke(New MethodInvoker(Sub()
                                                 Try
                                                     Dim selectedRowIndex As Integer = -1
                                                     If DGV_ReimprimirFact.SelectedRows.Count > 0 Then
                                                         selectedRowIndex = DGV_ReimprimirFact.SelectedRows(0).Index
                                                     End If
                                                     For i As Integer = 0 To DGV_ReimprimirFact.Columns.Count - 1
                                                         DGV_ReimprimirFact.Columns(i).ReadOnly = True
                                                         Select Case i
                                                             Case 1
                                                                 DGV_ReimprimirFact.Columns(i).Width = 60
                                                             Case 2
                                                                 DGV_ReimprimirFact.Columns(i).Width = 60
                                                             Case 3
                                                                 DGV_ReimprimirFact.Columns(i).Width = 70
                                                             Case 4
                                                                 DGV_ReimprimirFact.Columns(i).Width = 70
                                                             Case 5
                                                                 DGV_ReimprimirFact.Columns(i).Width = 100
                                                             Case 6
                                                                 DGV_ReimprimirFact.Columns(i).Width = 40
                                                             Case 7
                                                                 DGV_ReimprimirFact.Columns(i).Width = 40
                                                             Case 8
                                                                 DGV_ReimprimirFact.Columns(i).Width = 30
                                                             Case 9
                                                                 DGV_ReimprimirFact.Columns(i).Width = 30
                                                             Case 10
                                                                 DGV_ReimprimirFact.Columns(i).Width = 40
                                                             Case 11
                                                                 DGV_ReimprimirFact.Columns(i).Width = 50
                                                         End Select
                                                     Next
                                                     DGV_ReimprimirFact.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
                                                     DGV_ReimprimirFact.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.DisplayedCells)
                                                     DGV_ReimprimirFact.GridColor = Color.DarkGray
                                                     DGV_ReimprimirFact.Columns(0).Visible = False
                                                     If selectedRowIndex >= 0 AndAlso selectedRowIndex < DGV_ReimprimirFact.Rows.Count Then
                                                         DGV_ReimprimirFact.Rows(selectedRowIndex).Selected = True
                                                         DGV_ReimprimirFact.FirstDisplayedScrollingRowIndex = selectedRowIndex
                                                     End If
                                                 Catch ex As Exception
                                                     ' Manejar el error si alguna columna no existe
                                                     Console.WriteLine("Error al ocultar las columnas: " & ex.Message)
                                                 End Try
                                             End Sub))
        End Sub

        Private Function ObtenerIdFacturaReciente() As Integer
            Dim idFactura As Integer = -1
            Try
                Using conn As New SQLiteConnection(GetConnectionString())
                    conn.Open()
                    Using cmd As New SQLiteCommand("SELECT MAX(ID) FROM factura WHERE cobrada = 1;", conn)
                        Dim result = cmd.ExecuteScalar()
                        If result IsNot DBNull.Value Then
                            idFactura = Convert.ToInt32(result)
                        End If
                    End Using
                End Using
            Catch ex As Exception
                msgError("Error al obtener la factura más reciente: " & ex.Message)
            End Try
            Return idFactura
        End Function

        Private Sub BTN_ImpReciente_Click(sender As Object, e As EventArgs) Handles BTN_ImpReciente.Click
            Dim idFact As Integer = ObtenerIdFacturaReciente()
            If idFact = -1 Then
                msgError("No se encontró ninguna factura reciente.")
            End If

            Md_IMPRIMIR.GENERAR_FACTURA(idFact)
        End Sub

        Private Sub MNU_REIMPRIMIR_Click(sender As Object, e As EventArgs) Handles MNU_REIMPRIMIR.Click
            ' Asume que tienes un DataGridView llamado DGV_Facturas
            If DGV_ReimprimirFact.CurrentRow IsNot Nothing Then
                Dim idFactura As Integer = Convert.ToInt32(DGV_ReimprimirFact.CurrentRow.Cells("ID").Value)
                ' Llamada directa a la función del módulo
                Md_IMPRIMIR.GENERAR_FACTURA(idFactura)
            End If
        End Sub

        Private Sub MNU_Datos_Click(sender As Object, e As EventArgs) Handles MNU_Datos.Click
            Dim datosFactura As New Cls_DatosFactura With {
                .IdFactura = DGV_ReimprimirFact.SelectedRows(0).Cells(0).Value.ToString(),
                .NumFactura = DGV_ReimprimirFact.SelectedRows(0).Cells(1).Value.ToString(),
                .Fecha = DGV_ReimprimirFact.SelectedRows(0).Cells(2).Value.ToString(),
                .Cliente = DGV_ReimprimirFact.SelectedRows(0).Cells(3).Value.ToString(),
                .Cajero = DGV_ReimprimirFact.SelectedRows(0).Cells(4).Value.ToString(),
                .Comentario = DGV_ReimprimirFact.SelectedRows(0).Cells(5).Value.ToString(),
                .TotalCaja = DGV_ReimprimirFact.SelectedRows(0).Cells(6).Value.ToString(),
                .Efectivo = DGV_ReimprimirFact.SelectedRows(0).Cells(7).Value.ToString(),
                .Tarjeta = DGV_ReimprimirFact.SelectedRows(0).Cells(8).Value.ToString(),
                .Vuelto = DGV_ReimprimirFact.SelectedRows(0).Cells(9).Value.ToString(),
                .TipoPago = DGV_ReimprimirFact.SelectedRows(0).Cells(10).Value.ToString()
            }
            ' Crea la instancia del formulario
            Dim frmDatosFactura As New P_DatosFactura With {
                .Owner = Me
            }

            ' Llama a la nueva subrutina para cargar los datos en el formulario
            frmDatosFactura.CargarDatos(datosFactura)

            ' Muestra el formulario
            frmDatosFactura.Show()
        End Sub


        Private Sub CerrarApp_Click(sender As Object, e As EventArgs)
            msgCerrarApp()
        End Sub

        Private Sub BTN_RegresarFact_Click(sender As Object, e As EventArgs) Handles BTN_RegresarFact.Click
            Owner.Show()
            Owner.Select()
            If TypeOf Owner Is P_Caja Then
                Dim caja = CType(Owner, P_Caja)
                caja.isDialogOpen = False
                caja.TXT_BuscarProducto.SelectAll()
            End If
            Me.Close()
        End Sub

        Private Sub reiniciarTimer()
            If searchTimer IsNot Nothing Then
                searchTimer.Stop()
                searchTimer.Start()
            End If
        End Sub

        Private Sub TXT_BuscarFact_TextChanged(sender As Object, e As EventArgs) Handles TXT_BuscarFact.TextChanged
            reiniciarTimer()
        End Sub

        Private Sub RDB_50_CheckedChanged(sender As Object, e As EventArgs) Handles RDB_50.CheckedChanged
            reiniciarTimer()
        End Sub

        Private Sub RDB_100_CheckedChanged(sender As Object, e As EventArgs) Handles RDB_100.CheckedChanged
            reiniciarTimer()
        End Sub

        Private Sub RDB_200_CheckedChanged(sender As Object, e As EventArgs) Handles RDB_200.CheckedChanged
            reiniciarTimer()
        End Sub

        Private Sub RDB_All_CheckedChanged(sender As Object, e As EventArgs) Handles RDB_All.CheckedChanged
            reiniciarTimer()
        End Sub

        Private Sub DTP_Fecha_ValueChanged(sender As Object, e As EventArgs)
            reiniciarTimer()
        End Sub

        Private Sub BTN_CerrarApp_Click(sender As Object, e As EventArgs) Handles BTN_CerrarApp.Click
            msgCerrarApp()
        End Sub
    End Class

End Namespace