Imports System.Drawing.Printing

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
        P_Productos.Show()
        P_Productos.Select()
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
        productos.Clear()
        precioVenta.Clear()
        cantidad.Clear()
        If DGV_Hablador.Rows.Count > 0 Then
            For i As Integer = 0 To DGV_Hablador.Rows.Count - 1
                productos.Add(DGV_Hablador.Rows(i).Cells(2).Value.ToString())
                precioVenta.Add(DGV_Hablador.Rows(i).Cells(3).Value.ToString())
                cantidad.Add(Convert.ToInt32(DGV_Hablador.Rows(i).Cells(4).Value))
            Next
            CREAR_HABLADORES(productos, precioVenta, cantidad)
        End If
    End Sub

    Friend Sub CREAR_HABLADORES(productos As List(Of String), precios As List(Of String), cant As List(Of Integer))
        ' Inicializar las variables de estado
        currentProductIndex = 0
        currentQuantityIndex = 0
        printProducts = productos
        printPrices = precios
        printQuantities = cant

        Dim printDoc As New PrintDocument()
        AddHandler printDoc.PrintPage, AddressOf PrintDocument_PrintPage

        ' Configurar el tamaño de papel personalizado en pulgadas
        Dim customPaperSize As New PaperSize("Custom", CInt(72 * 3.937), CInt(297 * 3.937))
        printDoc.DefaultPageSettings.PaperSize = customPaperSize

        ' Configurar márgenes a cero
        printDoc.DefaultPageSettings.Margins = New Margins(0, 0, 0, 0)

        ' Imprimir el documento
        Dim printDialog As New PrintDialog With {
            .Document = printDoc
        }

        If printDialog.ShowDialog() = DialogResult.OK Then
            printDoc.Print()
            DGV_Hablador.Rows.Clear()
        End If
    End Sub

    Private Sub PrintDocument_PrintPage(sender As Object, e As PrintPageEventArgs)
        Dim tamañoProds As Integer = Md_Inicializacion.GetAppSetting("FontSizeProd")
        Dim tamañoPrecio As Integer = Md_Inicializacion.GetAppSetting("FontSizePrecio")

        Dim font As New Font("Arial", tamañoProds)
        Dim fontProds As New Font("Arial", tamañoProds, FontStyle.Bold)
        Dim fontPrices As New Font("Arial", tamañoPrecio, FontStyle.Bold)
        Dim brush As New SolidBrush(Color.Black)
        Dim stringFormatLeft As New StringFormat() With {
            .Alignment = StringAlignment.Near,
            .LineAlignment = StringAlignment.Near
        }

        ' Establecer el tamaño del papel
        Dim totalWidth As Single = 72 * 3.78
        Dim leftMargin As Single = e.MarginBounds.Left
        Dim topMargin As Single = e.MarginBounds.Top
        Dim yPos As Single = topMargin
        ' 1. Obtener el ancho del área de dibujo disponible:
        Dim largoDisponible As Single = totalWidth - leftMargin ' Restamos el margen izquierdo

        ' 2. Crear una cadena con un solo guión para medir su ancho:
        Dim Guion As String = "-"

        Dim largoGuion As Single = e.Graphics.MeasureString(Guion, font).Width
        ' 3. Calcular cuántos guiones caben en el ancho disponible:
        Dim NumGuion As Integer = CInt(Math.Floor(largoDisponible / largoGuion))


        yPos = topMargin ' Reiniciar posición vertical en cada nueva página
        e.HasMorePages = False ' Asumir que no hay más páginas al inicio

        ' Recorrer los productos desde el último punto guardado
        For i As Integer = currentProductIndex To printProducts.Count - 1
            ' Comenzar desde la última cantidad procesada si es el mismo producto
            Dim startJ As Integer = If(i = currentProductIndex, currentQuantityIndex, 0)

            For j As Integer = startJ To printQuantities(i) - 1
                'Añadir una línea adicional antes de escribir la información del producto (opcional)
                yPos += e.Graphics.MeasureString(" ", font).Height

                ' Dibujar el nombre del producto alineado a la izquierda
                Dim productName As String = productos(i)
                Dim productRect As New RectangleF(leftMargin, yPos, totalWidth, 0)
                Dim productSize As SizeF = e.Graphics.MeasureString(productName, fontProds, totalWidth, stringFormatLeft)

                ' Calcular el tamaño del rectángulo para ajustar el texto en varias líneas si es necesario
                productRect.Height = productSize.Height
                e.Graphics.DrawString(productName, fontProds, brush, productRect, stringFormatLeft)
                yPos += productRect.Height + 5

                ' Dibujar el precio alineado a la izquierda
                Dim productPrice As String = "₡" & precioVenta(i)
                Dim priceRect As New RectangleF(leftMargin, yPos, totalWidth, 0)
                e.Graphics.DrawString(productPrice, fontProds, brush, priceRect, stringFormatLeft)
                yPos += e.Graphics.MeasureString(productPrice, fontPrices).Height + 20 ' Espacio adicional después de cada hablador

                ' Crea un linea de guiones que divide ambos habladores
                If Not (i = printProducts.Count - 1 AndAlso j = printQuantities(i) - 1) Then
                    Dim lines As New String("-"c, NumGuion)
                    e.Graphics.DrawString(lines, font, brush, leftMargin, yPos, stringFormatLeft)
                    yPos += e.Graphics.MeasureString(lines, font).Height + 5
                End If

                ' Verificar espacio restante
                If yPos + e.Graphics.MeasureString(productPrice, fontProds).Height > e.MarginBounds.Bottom Then
                    ' Guardar el progreso actual
                    currentProductIndex = i
                    currentQuantityIndex = j + 1 ' Guardar la siguiente cantidad a procesar
                    e.HasMorePages = True
                    Return ' Salir para generar nueva página
                End If
            Next

            ' Resetear el índice de cantidad al pasar al siguiente producto
            currentQuantityIndex = 0
        Next

        ' Limpiar variables si se completó la impresión
        If Not e.HasMorePages Then
            printProducts = Nothing
            printPrices = Nothing
            printQuantities = Nothing
            DGV_Hablador.Rows.Clear()
        End If
    End Sub

    Private Sub BTN_Config_Click(sender As Object, e As EventArgs) Handles BTN_Config.Click
        entrarConfig(3)
    End Sub
End Class