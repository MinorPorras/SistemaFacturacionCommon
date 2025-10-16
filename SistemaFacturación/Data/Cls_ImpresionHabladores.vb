Imports System.Drawing.Printing
Imports Serilog
Imports Serilog.Context
Imports SistemaFacturaciónCommon.SistemaFacturacion.Modules

Public Class Cls_ImpresionHabladores
    ' Variables de estado (Se definen a nivel de clase para que persistan entre páginas)
    Private Shared currentProductIndex As Integer = 0
    Private Shared currentQuantityIndex As Integer = 0
    Private Shared printProducts As List(Of String)
    Private Shared printPrices As List(Of String)
    Private Shared printQuantities As List(Of Integer)

    ' Variable para la conexión al DGV (Se inicializa al inicio de la impresión)
    Private Shared DGV_Referencia As DataGridView

    ' --------------------------------------------------------------------------
    ' FUNCIÓN PRINCIPAL: Inicia y configura el proceso de impresión
    ' --------------------------------------------------------------------------
    Friend Shared Sub CREAR_HABLADORES(dgv As DataGridView,
                                      productos As List(Of String),
                                      precios As List(Of String),
                                      cant As List(Of Integer))

        ' 1. Inicializar el estado de la clase
        currentProductIndex = 0
        currentQuantityIndex = 0
        printProducts = productos
        printPrices = precios
        printQuantities = cant
        DGV_Referencia = dgv ' Guardar la referencia al DGV

        ' 2. Configuración del PrintDocument
        Dim printDoc As New PrintDocument()
        AddHandler printDoc.PrintPage, AddressOf PrintDocument_PrintPage

        ' Configurar el tamaño de papel personalizado en pulgadas (3.937 puntos por pulgada)
        Dim customPaperSize As New PaperSize("Custom", CInt(72 * 3.937), CInt(297 * 3.937))
        printDoc.DefaultPageSettings.PaperSize = customPaperSize

        ' Configurar márgenes a cero
        printDoc.DefaultPageSettings.Margins = New Margins(0, 0, 0, 0)

        ' 3. Mostrar diálogo e Imprimir
        Dim printDialog As New PrintDialog With {
            .Document = printDoc
        }

        If printDialog.ShowDialog() = DialogResult.OK Then
            printDoc.Print()
        End If
    End Sub

    ' --------------------------------------------------------------------------
    ' MANEJADOR DEL EVENTO PrintPage: Dibuja el contenido en la página
    ' --------------------------------------------------------------------------
    Private Shared Sub PrintDocument_PrintPage(sender As Object, e As PrintPageEventArgs)
        Using LogContext.PushProperty("Feature", "Habladores")
            Log.Information("Iniciando PrintPage. Estado: ProdIndex={PIndex}, QtyIndex={QIndex}", currentProductIndex, currentQuantityIndex)
            ' Configuración de fuentes y pinceles
            Dim tamañoProds As Integer = GetAppSetting("FontSizeProd")
            Dim tamañoPrecio As Integer = GetAppSetting("FontSizePrecio")

            Dim font As New Font("Arial", tamañoProds)
            Dim fontProds As New Font("Arial", tamañoProds, FontStyle.Bold)
            Dim fontPrices As New Font("Arial", tamañoPrecio, FontStyle.Bold)
            Dim brush As New SolidBrush(Color.Black)
            Dim stringFormatLeft As New StringFormat() With {
                .Alignment = StringAlignment.Near,
                .LineAlignment = StringAlignment.Near
            }

            ' *** CÁLCULOS DE ANCHO ***
            Dim totalWidth As Single = 72 * 3.15 ' El ancho total de 3.15 pulgadas en puntos
            Dim leftMargin As Single = e.MarginBounds.Left
            Dim topMargin As Single = e.MarginBounds.Top
            Dim yPos As Single = topMargin
            Dim largoDisponible As Single = totalWidth - leftMargin ' Ancho de dibujo

            Dim Guion As String = "-"
            Dim largoGuion As Single = e.Graphics.MeasureString(Guion, font).Width
            Dim NumGuion As Integer = CInt(Math.Floor(largoDisponible / largoGuion))

            e.HasMorePages = False

            ' Recorrer los productos
            For i As Integer = currentProductIndex To printProducts.Count - 1
                Dim startJ As Integer = If(i = currentProductIndex, currentQuantityIndex, 0)

                For j As Integer = startJ To printQuantities(i) - 1

                    yPos += e.Graphics.MeasureString(" ", font).Height

                    ' ------------------ DIBUJAR PRODUCTO ------------------
                    Dim productName As String = printProducts(i)
                    Dim productRect As New RectangleF(leftMargin, yPos, totalWidth, 0)
                    Dim productSize As SizeF = e.Graphics.MeasureString(productName, fontProds, totalWidth, stringFormatLeft)

                    productRect.Height = productSize.Height
                    e.Graphics.DrawString(productName, fontProds, brush, productRect, stringFormatLeft)
                    yPos += productRect.Height + 5

                    ' ------------------ DIBUJAR PRECIO ------------------
                    Dim productPrice As String = "₡" & printPrices(i)
                    Dim priceRect As New RectangleF(leftMargin, yPos, totalWidth, 0)
                    e.Graphics.DrawString(productPrice, fontProds, brush, priceRect, stringFormatLeft)

                    Log.Debug("Iniciando Producto {I}: '{Name}'. Empezando en copia: {StartJ}", i, productName, startJ)

                    ' Altura necesaria para el chequeo de límite de página
                    Dim heightCheck As Single = e.Graphics.MeasureString(productPrice, fontPrices).Height
                    yPos += heightCheck + 20 ' Espacio adicional después de cada hablador

                    ' ------------------ DIBUJAR GUIONES ------------------
                    If Not (i = printProducts.Count - 1 AndAlso j = printQuantities(i) - 1) Then
                        Dim lines As New String("-"c, NumGuion)
                        e.Graphics.DrawString(lines, font, brush, leftMargin, yPos, stringFormatLeft)
                        yPos += e.Graphics.MeasureString(lines, font).Height + 5
                    End If

                    ' ------------------ VERIFICAR SALTO DE PÁGINA ------------------
                    ' Verificar si el próximo elemento (si existiera) no cabe.
                    If yPos + heightCheck > e.MarginBounds.Bottom Then
                        currentProductIndex = i
                        currentQuantityIndex = j + 1
                        e.HasMorePages = True
                        Log.Information("Salto de página necesario. Próximo inicio: Producto {PIndex} (copia {QIndex}).",
                                        currentProductIndex, currentQuantityIndex)
                        Return
                    End If
                Next

                currentQuantityIndex = 0
            Next

            ' Si se completó la impresión, limpiar variables
            If Not e.HasMorePages Then
                Log.Information("Impresión de habladores completada. Limpiando variables de estado.")

                ' Asegúrate de que estás limpiando correctamente el DGV
                If DGV_Referencia IsNot Nothing Then
                    DGV_Referencia.Rows.Clear()
                    Log.Debug("DGV_Referencia limpiado correctamente.")
                End If

                printProducts = Nothing
                printPrices = Nothing
                printQuantities = Nothing
                currentProductIndex = 0
                currentQuantityIndex = 0
                Log.Information("Variables de estado limpiadas.")
            End If
        End Using

    End Sub
End Class
