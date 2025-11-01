Imports System.Drawing.Printing
Imports System.Windows.Forms.AxHost
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
                                      cant As List(Of Integer), oneToOnePrint As Boolean)

        ' 1. Inicializar el estado de la clase
        currentProductIndex = 0
        currentQuantityIndex = 0
        printProducts = productos
        printPrices = precios
        printQuantities = cant
        DGV_Referencia = dgv ' Guardar la referencia al DGV

        If (oneToOnePrint) Then
            Log.Information("Modo de impresión One-to-One activado.")
            PrintOneToOne()
            Exit Sub
        End If

        Log.Information("Modo de impresión Normal activado.")
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
    ' FUNCIÓN AUXILIAR: Imprime cada hablador como un documento individual.
    ' --------------------------------------------------------------------------
    Private Shared Sub PrintOneToOne()
        Using LogContext.PushProperty("Feature", "Habladores")
            Log.Information("Iniciando impresión One-to-One.")

            Dim printDialog As New PrintDialog()

            ' Bucle principal: recorre cada producto en la lista
            For i As Integer = 0 To printProducts.Count - 1
                Dim productName As String = printProducts(i)
                Dim numCopies As Integer = printQuantities(i)

                ' Bucle interno: recorre cada COPIA de ese producto
                For j As Integer = 0 To numCopies - 1

                    ' **1. Crear un NUEVO PrintDocument para CADA impresión**
                    Dim printDoc As New PrintDocument()

                    ' **2. Configurar la página (Papel y márgenes)**
                    Dim customPaperSize As New PaperSize("Custom", CInt(72 * 3.937), CInt(297 * 3.937))
                    printDoc.DefaultPageSettings.PaperSize = customPaperSize
                    printDoc.DefaultPageSettings.Margins = New Margins(0, 0, 0, 0)

                    ' **3. Asignar el manejador de página ÚNICO**
                    AddHandler printDoc.PrintPage, AddressOf PrintDocument_PrintPage_Single

                    ' **4. Asignar el documento al diálogo de impresión (solo la primera vez si se quiere)**
                    If i = 0 AndAlso j = 0 Then
                        printDialog.Document = printDoc
                        If printDialog.ShowDialog() <> DialogResult.OK Then
                            Log.Warning("Impresión One-to-One cancelada por el usuario.")
                            Return ' Salir si el usuario cancela la primera impresión
                        End If
                    End If

                    ' **5. Imprimir el documento individual**
                    Log.Debug("Imprimiendo copia {J} de Producto {I}: '{Name}'", j + 1, i, productName)

                    ' **ACTUALIZAR ÍNDICES GLOBALES ANTES de imprimir**
                    ' Esto asegura que el manejador PrintDocument_PrintPage_Single sepa qué dibujar.
                    currentProductIndex = i
                    currentQuantityIndex = j

                    printDoc.Print()
                Next
            Next


            ' Limpiar variables globales después de la impresión One-to-One
            CLEANUP_VARIABLES()
        End Using
    End Sub

    ' --------------------------------------------------------------------------
    ' MANEJADOR DEL EVENTO PrintPage para un solo hablador
    ' --------------------------------------------------------------------------
    Private Shared Sub PrintDocument_PrintPage_Single(sender As Object, e As PrintPageEventArgs)
        Using LogContext.PushProperty("Feature", "Habladores_Single")

            ' Usamos currentProductIndex y currentQuantityIndex para saber qué dibujar
            Dim i As Integer = currentProductIndex
            Dim j As Integer = currentQuantityIndex ' No es estrictamente necesario, pero mantiene la coherencia

            ' --- COPIA TODO EL CÓDIGO DE DIBUJO DESDE PrintDocument_PrintPage AQUÍ ---

            ' Configuración de fuentes y pinceles
            ' Configuración de fuentes y pinceles
            Dim tamañoProds As Integer = GetAppSetting("FontSizeProd")
            Dim tamañoPrecio As Integer = GetAppSetting("FontSizePrecio")

            Using font As New Font("Arial", tamañoProds),
              fontProds As New Font("Arial", tamañoProds, FontStyle.Bold),
              fontPrices As New Font("Arial", tamañoPrecio, FontStyle.Bold),
              brush As New SolidBrush(Color.Black)

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

                ' NO HAY BUCLES NI LÓGICA DE SALTO DE PÁGINA
                e.HasMorePages = False ' Siempre falso para una impresión individual

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

            End Using
        End Using
    End Sub

    ' --------------------------------------------------------------------------
    ' FUNCIÓN AUXILIAR: Limpia las variables de estado
    ' --------------------------------------------------------------------------
    Private Shared Sub CLEANUP_VARIABLES()
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
    End Sub

    ' (Luego llamas a CLEANUP_VARIABLES() al final de PrintOneToOne o en el PrintPage original.)

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

                ' Limpiar variables globales después de la impresión One-to-One
                CLEANUP_VARIABLES()
            End If
        End Using

    End Sub
End Class
