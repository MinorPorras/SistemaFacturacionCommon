Imports System.Drawing.Printing
Imports System.Threading.Tasks


Public Class P_ReimprimirFact
    Friend encabezadoFactura As String
    Friend encabezadoProds As String
    Friend facturaContenido As New List(Of String)()
    Friend finFactura As String
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
        Task.Run(Sub()
                     Try
                         T.Tables.Clear()
                         Dim busqueda As String = TXT_BuscarFact.Text.Trim()
                         Dim condicionBusqueda As String
                         If busqueda = "" Then
                             condicionBusqueda = "1=1" ' Esto siempre será verdadero, mostrando todos los registros
                         Else
                             condicionBusqueda = $"(printf('%015d', CAST(f.num_factura AS INTEGER)) LIKE '%{busqueda}%')"
                         End If

                         Dim cant As String = ""
                         If RDB_200.Checked Then
                             cant = "LIMIT 200"
                         ElseIf RDB_100.Checked Then
                             cant = "LIMIT 100"
                         ElseIf RDB_All.Checked Then
                             cant = "" ' Sin límite
                         Else
                             cant = "LIMIT 50"
                         End If

                         SQL = "SELECT f.ID, printf('%015d', CAST(f.num_factura AS INTEGER)) AS 'Num factura', f.fecha_emision AS 'Fecha de emisión', " &
                                  "c.nombre AS 'Cliente', u.usuario AS 'Cajero', fc.comentario AS 'Comentario', f.total AS 'Total', " &
                                  "f.efectivo_cliente AS 'Pago efectivo', f.tarjeta_cliente AS 'Pago tarjeta', f.vuelto AS 'Vuelto', " &
                                  "CASE WHEN f.tipo_venta = 0 THEN 'Efectivo' " &
                                       "WHEN f.tipo_venta = 1 THEN 'Tarjeta' " &
                                       "WHEN f.tipo_venta = 2 THEN 'Sinpe' " &
                                       "WHEN f.tipo_venta = 3 THEN 'Depósito' " &
                                       "WHEN f.tipo_venta = 4 THEN 'Mixto' " &
                                       "ELSE 'Efectivo' END AS 'Tipo venta', " &
                                  "f.cobrada AS 'Cobrada' " &
                                  "FROM factura f " &
                                  "LEFT JOIN clientes c ON c.ID = f.ID_CLIENTE " &
                                  "LEFT JOIN usuario u ON u.ID = f.ID_USUARIO " &
                                  "LEFT JOIN factura_comentario fc ON fc.ID_Factura = f.ID " &
                                  "WHERE " & condicionBusqueda & " " &
                                  "ORDER BY CAST(f.num_factura AS INTEGER) DESC " & cant & ";"
                         Invoke(Sub()
                                    MNU_REIMPRIMIR.Visible = False
                                    MNU_Datos.Visible = False
                                    Cargar_Tabla(T, SQL)
                                    If T.Tables.Count > 0 AndAlso T.Tables(0).Rows.Count > 0 Then
                                        Dim bin As New BindingSource With {
                                            .DataSource = T.Tables(0)
                                        }
                                        DGV_ReimprimirFact.DataSource = bin
                                        MNU_REIMPRIMIR.Visible = True
                                        MNU_Datos.Visible = True
                                    Else ' Limpiar la fuente de datos si no se cargaron datos
                                        DGV_ReimprimirFact.DataSource = Nothing
                                    End If
                                    TXT_BuscarFact.Select()
                                End Sub)
                     Catch ex As Exception
                         Invoke(Sub()
                                    If DGV_ReimprimirFact.IsHandleCreated Then
                                        If ex.Message <> "InvalidArgument=El valor de '0' no es válido para 'index'." & vbCrLf & "Nombre del parámetro: index" Then
                                            ' Mostrar un mensaje de error genérico
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


    Private Sub BTN_ImpReciente_Click(sender As Object, e As EventArgs) Handles BTN_ImpReciente.Click
        encabezadoFactura = ""
        For i As Integer = facturaContenido.Count - 1 To 0 Step -1
            facturaContenido.RemoveAt(i)
        Next

        finFactura = ""
        T.Tables.Clear()
        SQL = "SELECT ID FROM factura ORDER BY cast(num_factura as integer) DESC LIMIT 1;"
        Cargar_Tabla(T, SQL)
        If T.Tables(0).Rows.Count > 0 Then
            Dim idFact As String = T.Tables(0).Rows(0).Item(0).ToString()
            CREAR_FACTURA(idFact, True)
            ImprimirFactura()
        End If
    End Sub

    Private Sub MNU_REIMPRIMIR_Click(sender As Object, e As EventArgs) Handles MNU_REIMPRIMIR.Click
        encabezadoFactura = ""
        'Se limpia la lista de productos
        For Each line As String In facturaContenido.ToList()
            facturaContenido.Remove(line)
        Next

        finFactura = ""
        CREAR_FACTURA(DGV_ReimprimirFact.SelectedRows(0).Cells(0).Value.ToString(), True)
        ImprimirFactura()
    End Sub

    Private Sub MNU_Datos_Click(sender As Object, e As EventArgs) Handles MNU_Datos.Click
        P_DatosFactura.idFact = DGV_ReimprimirFact.SelectedRows(0).Cells(0).Value.ToString()
        P_DatosFactura.TXT_NumFact.Text = DGV_ReimprimirFact.SelectedRows(0).Cells(1).Value.ToString()
        P_DatosFactura.TXT_FechaEmision.Text = DGV_ReimprimirFact.SelectedRows(0).Cells(2).Value.ToString()
        P_DatosFactura.TXT_Cliente.Text = DGV_ReimprimirFact.SelectedRows(0).Cells(3).Value.ToString()
        P_DatosFactura.TXT_Cajero.Text = DGV_ReimprimirFact.SelectedRows(0).Cells(4).Value.ToString()
        P_DatosFactura.TXT_Comentario.Text = DGV_ReimprimirFact.SelectedRows(0).Cells(5).Value.ToString()
        P_DatosFactura.TXT_Total.Text = DGV_ReimprimirFact.SelectedRows(0).Cells(6).Value.ToString()
        P_DatosFactura.TXT_Efectivo.Text = DGV_ReimprimirFact.SelectedRows(0).Cells(7).Value.ToString()
        P_DatosFactura.TXT_Tarjeta.Text = DGV_ReimprimirFact.SelectedRows(0).Cells(8).Value.ToString()
        P_DatosFactura.TXT_Vuelto.Text = DGV_ReimprimirFact.SelectedRows(0).Cells(9).Value.ToString()
        P_DatosFactura.TXT_TipoPago.Text = DGV_ReimprimirFact.SelectedRows(0).Cells(10).Value.ToString()
        P_DatosFactura.Show()
        P_DatosFactura.Select()
        P_DatosFactura.cargarProds()
        Me.Close()
    End Sub


    Private Sub CerrarApp_Click(sender As Object, e As EventArgs)
        msgCerrarApp()
    End Sub

    Private Sub PrintDocument_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument.PrintPage
        Dim font As New Font("Arial", 12)
        Dim fontProds As New Font("Segoe UI", 9)
        Dim brush As New SolidBrush(Color.Black)
        Dim stringFormat As New StringFormat() With {
        .Alignment = StringAlignment.Near,
        .LineAlignment = StringAlignment.Near
    }

        Dim totalWidth As Single = 72 * 3.78
        Dim cellWidth As Single = totalWidth / 4
        Dim leftMargin As Single = e.MarginBounds.Left
        Dim topMargin As Single = e.MarginBounds.Top
        Dim yPos As Single = topMargin

        ' Dibujar el encabezado
        e.Graphics.DrawString(encabezadoFactura, font, brush, leftMargin, yPos, stringFormat)
        yPos += e.Graphics.MeasureString(encabezadoFactura, font).Height + 10 ' Espacio adicional después del encabezado

        ' Dibujar el encabezado de la tabla de productos
        e.Graphics.DrawString(encabezadoProds, fontProds, brush, leftMargin, yPos, stringFormat)
        yPos += e.Graphics.MeasureString(encabezadoProds, fontProds).Height + 10 ' Espacio adicional después del encabezado

        ' Dibujar los productos
        For Each line As String In facturaContenido
            Dim columns() As String = line.Split(New Char() {"."c}, StringSplitOptions.RemoveEmptyEntries) ' Cambiar el delimitador si es necesario

            Dim maxHeight As Single = 0

            For colIndex As Integer = 0 To columns.Length - 1
                Dim rect As New RectangleF(leftMargin + (colIndex * cellWidth), yPos, cellWidth, 0)
                Dim size As SizeF = e.Graphics.MeasureString(columns(colIndex), fontProds, rect.Size, stringFormat)

                If size.Height > maxHeight Then
                    maxHeight = size.Height
                End If

                rect.Height = maxHeight
                e.Graphics.DrawString(columns(colIndex), fontProds, brush, rect, stringFormat)
            Next

            yPos += maxHeight + 5 ' Asegurar que el yPos se incremente para cada línea de productos
        Next

        yPos += 10 ' Espacio adicional después de los productos
        e.Graphics.DrawString(finFactura, font, brush, leftMargin, yPos, stringFormat)
    End Sub


    ' Método para iniciar la impresión
    Private Sub ImprimirFactura()
        Dim printDoc As New PrintDocument()
        AddHandler printDoc.PrintPage, AddressOf printDocument_PrintPage
        ' Configurar el tamaño de papel personalizado en pulgadas
        Dim customPaperSize As New PaperSize("Custom", CInt(72 * 3.937), CInt(297 * 3.937))
        printDoc.DefaultPageSettings.PaperSize = customPaperSize

        ' Configurar márgenes a cero
        printDoc.DefaultPageSettings.Margins = New Margins(0, 0, 0, 0)

        Dim printPreview As New PrintPreviewDialog With {
            .Document = printDoc
        }
        printDoc.Print()

    End Sub

    Private Sub BTN_RegresarFact_Click(sender As Object, e As EventArgs) Handles BTN_RegresarFact.Click
        P_Caja.Show()
        P_Caja.Select()
        P_Caja.TXT_BuscarProducto.SelectAll()
        Me.Close()
    End Sub

    Private Sub TXT_BuscarFact_TextChanged(sender As Object, e As EventArgs) Handles TXT_BuscarFact.TextChanged
        If searchTimer IsNot Nothing Then
            searchTimer.Stop()
            searchTimer.Start()
        End If
    End Sub

    Private Sub RDB_50_CheckedChanged(sender As Object, e As EventArgs) Handles RDB_50.CheckedChanged
        If searchTimer IsNot Nothing Then
            searchTimer.Stop()
            searchTimer.Start()
        End If
    End Sub

    Private Sub RDB_100_CheckedChanged(sender As Object, e As EventArgs) Handles RDB_100.CheckedChanged
        If searchTimer IsNot Nothing Then
            searchTimer.Stop()
            searchTimer.Start()
        End If
    End Sub

    Private Sub RDB_200_CheckedChanged(sender As Object, e As EventArgs) Handles RDB_200.CheckedChanged
        If searchTimer IsNot Nothing Then
            searchTimer.Stop()
            searchTimer.Start()
        End If
    End Sub

    Private Sub RDB_All_CheckedChanged(sender As Object, e As EventArgs) Handles RDB_All.CheckedChanged
        If searchTimer IsNot Nothing Then
            searchTimer.Stop()
            searchTimer.Start()
        End If
    End Sub

    Private Sub DTP_Fecha_ValueChanged(sender As Object, e As EventArgs)
        If searchTimer IsNot Nothing Then
            searchTimer.Stop()
            searchTimer.Start()
        End If
    End Sub

    Private Sub BTN_CerrarApp_Click(sender As Object, e As EventArgs) Handles BTN_CerrarApp.Click
        msgCerrarApp()
    End Sub
End Class