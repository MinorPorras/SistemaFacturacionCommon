Imports System.Data.SQLite
Imports SistemaFacturaciónCommon.SistemaFacturacion.Data
Imports SistemaFacturaciónCommon.SistemaFacturacion.Modules


Namespace SistemaFacturacion.Forms.Caja

    Public Class P_ReimprimirFact
        Private searchTimer As Timer
        Private binFacts As New BindingSource With {.DataSource = Nothing}
        Dim listaVentas As New List(Of Cls_Ventas)

        ' Método para inicializar el temporizador y otros componentes necesarios
        Private Sub InicializarComponentes()
            ' Inicializar el temporizador
            searchTimer = New Timer With {
                .Interval = 100
            }
            ' Medio segundo
            AddHandler searchTimer.Tick, AddressOf OnSearchTimerTick

            DGV_ReimprimirFact.DataSource = binFacts
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
                             Dim busqueda As String = ""
                             Dim cant As String = ""


                             ' Usamos Invoke para acceder al control TXT_BuscarFact en el hilo de la UI
                             Invoke(Sub()
                                        busqueda = TXT_BuscarFact.Text.Trim()
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

                             Dim consulta = "SELECT f.ID, f.num_factura, f.fecha_emision, c.nombre AS 'Cliente', u.usuario AS 'Cajero', f.tipo_venta, " &
                                         "f.efectivo_cliente, f.tarjeta_cliente , f.vuelto , " &
                                         "fc.comentario, f.total " &
                                         "FROM factura f " &
                                         "LEFT JOIN clientes c ON c.ID = f.ID_CLIENTE " &
                                         "LEFT JOIN usuario u ON u.ID = f.ID_USUARIO " &
                                         "LEFT JOIN factura_comentario fc ON fc.ID_Factura = f.ID WHERE f.num_factura LIKE @busqueda " &
                                         "ORDER BY CAST(f.num_factura AS INTEGER) DESC " & cant

                             Dim parametros As New List(Of SQLiteParameter) From {{New SQLiteParameter("@busqueda", "%" & busqueda & "%")}}

                             ' Cargar los datos de forma segura usando el método CargarTablaParam
                             CargarTablaParam(T, consulta, parametros)

                             ' Invocar al hilo de la UI para actualizar el DataGridView
                             Invoke(Sub()
                                        ' Lógica CORREGIDA: verifica que T, la tabla y las filas existan
                                        If T Is Nothing OrElse T.Tables.Count = 0 OrElse T.Tables(0).Rows.Count = 0 Then
                                            binFacts.DataSource = listaVentas ' Mostrar lista vacía
                                            Exit Sub
                                        End If

                                        For Each venta As DataRow In T.Tables(0).Rows
                                            Dim factura As New Cls_Ventas With {
                                                .ID = venta("ID"),
                                                .Num_factura = venta("num_factura"),
                                                .Fecha_creacion = venta("fecha_emision"),
                                                .Cliente = venta("Cliente"),
                                                .Cajero = venta("Cajero"),
                                                .Saldo_total = venta("total"),
                                                .Efectivo = venta("efectivo_cliente"),
                                                .Tarjeta = venta("tarjeta_cliente"),
                                                .Vuelto = venta("vuelto"),
                                                .Tipo_pago = venta("tipo_venta"),
                                                .Comentario = If(IsDBNull(venta("Comentario")), "", venta("Comentario"))
                                            }

                                            listaVentas.Add(factura)
                                        Next

                                        binFacts.DataSource = listaVentas
                                        binFacts.ResetBindings(False)

                                        MNU_REIMPRIMIR.Visible = True
                                        MNU_Datos.Visible = True
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
                                                     Dim hiddenColumns As New List(Of String) From {
                                                        "ID",
                                                        "Num_factura",
                                                        "ID_Cliente",
                                                        "ID_Cajero",
                                                        "saldo_total",
                                                        "Efectivo",
                                                        "Tarjeta",
                                                        "Tipo_pago",
                                                        "ID_CxC",
                                                        "vuelto",
                                                        "saldo_restante",
                                                        "Formated_saldo_restante"
                                                     }

                                                     Dim formatedNames As New Dictionary(Of String, String) From {
                                                        {"Formated_num_factura", "# Factura"},
                                                        {"Fecha_creacion", "Fecha"},
                                                        {"Cajero", "Cajero"},
                                                        {"Cliente", "Cliente"},
                                                        {"Formated_Efectivo", "Efectivo"},
                                                        {"Formated_Tarjeta", "Tarjeta"},
                                                        {"Formated_vuelto", "Vuelto"},
                                                        {"Formated_saldo_total", "Total"},
                                                        {"Formated_tipo_pago", "Método"},
                                                        {"Comentario", "Comentario"}
                                                     }

                                                     Dim columnSize As New Dictionary(Of String, Integer) From {
                                                        {"Comentario", 40},
                                                        {"Fecha_Creacion", 20}
                                                     }
                                                     formatDGV(DGV_ReimprimirFact, hiddenColumns, formatedNames, columnSize)


                                                     Dim selectedRowIndex As Integer = -1
                                                     If DGV_ReimprimirFact.SelectedRows.Count > 0 Then
                                                         selectedRowIndex = DGV_ReimprimirFact.SelectedRows(0).Index
                                                     End If
                                                     DGV_ReimprimirFact.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
                                                     DGV_ReimprimirFact.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.DisplayedCells)
                                                     DGV_ReimprimirFact.GridColor = Color.DarkGray
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
                    Using cmd As New SQLiteCommand("SELECT MAX(ID) FROM factura", conn)
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

            Md_IMPRIMIR.GENERAR_FACTURA(idFact, "Comun")
        End Sub

        Private Sub MNU_REIMPRIMIR_Click(sender As Object, e As EventArgs) Handles MNU_REIMPRIMIR.Click
            Dim idFactura As Integer = Convert.ToInt32(DGV_ReimprimirFact.SelectedRows(0).Cells("ID").Value)
            ' Llamada directa a la función del módulo
            Md_IMPRIMIR.GENERAR_FACTURA(idFactura, "Comun")
        End Sub

        Private Sub MNU_Datos_Click(sender As Object, e As EventArgs) Handles MNU_Datos.Click

            Dim ventaData As New Cls_Ventas
            Dim id = DGV_ReimprimirFact.SelectedRows(0).Cells("ID").Value
            ventaData.CargarDataFactura(id)

            Using frmDatosFactura As New P_DatosFactura
                frmDatosFactura.Owner = Me
                ' Llama a la nueva subrutina para cargar los datos en el formulario
                frmDatosFactura.CargarDatos(ventaData)

                ' Muestra el formulario
                frmDatosFactura.ShowDialog()
                Me.Select()
            End Using
        End Sub


        Private Sub CerrarApp_Click(sender As Object, e As EventArgs)
            isNavigating = False
            Me.Close()
        End Sub

        Private Sub BTN_RegresarFact_Click(sender As Object, e As EventArgs) Handles BTN_RegresarFact.Click
            Owner.Show()
            Owner.Select()
            If TypeOf Owner Is P_Caja Then
                Dim caja = CType(Owner, P_Caja)
                caja.TXT_BuscarProducto.SelectAll()
            End If
            isNavigating = True
            Me.Close()
        End Sub

        Private Sub ReiniciarTimer()
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

        Private Sub P_ReimprimirFact_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
            ManejarCierreONavegacion(e)
        End Sub

        Private Sub BTN_CerrarApp_Click(sender As Object, e As EventArgs) Handles BTN_CerrarApp.Click
            isNavigating = False
            Me.Close()
        End Sub
    End Class

End Namespace