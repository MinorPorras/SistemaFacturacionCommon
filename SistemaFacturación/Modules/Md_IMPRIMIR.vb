' -----------------------------------------------------------------------------
' Módulo para la generación y armado de la factura impresa o reimpresa
' Obtiene los datos de la factura, cliente, sucursal y productos para mostrar
' en la vista previa de impresión o reimpresión.
' -----------------------------------------------------------------------------
Imports System.Drawing.Printing
Imports SistemaFacturaciónCommon.SistemaFacturacion.Data
Namespace SistemaFacturacion.Modules

    Module Md_IMPRIMIR
        ' Variables para el contenido de la factura (impresión)
        Friend encabezadoFactura As String
        Friend encabezadoProds As String = "Cant        Descripción             Precio        Total" & vbCrLf &
                                                        "--------------------------------------------------" & vbCrLf
        Friend facturaContenido As New List(Of String)()
        Friend finFactura As String

        Private Sub LIMPIAR()
            encabezadoFactura = ""
            facturaContenido.Clear()
            finFactura = ""
        End Sub

        ' Genera el contenido de la factura para impresión o reimpresión
        ' id_factura: ID de la factura a imprimir
        ' reimprimir: True si es reimpresión, False si es impresión normal
        Public Sub GENERAR_FACTURA(id_factura As Integer)
            LIMPIAR()
            Dim factura As New Cls_DatosFactura()
            factura = ObtenerDatosGeneralesFactura(id_factura)

            Dim strVenta As String
            ' Determinar el tipo de venta en texto
            Select Case factura.TipoPago
                Case 0
                    strVenta = "Efectivo"
                Case 1
                    strVenta = "Tarjeta"
                Case 2
                    strVenta = "Sinpe"
                Case 3
                    strVenta = "Depósito"
                Case 4
                    strVenta = "Mixto"
                Case Else
                    strVenta = "Efectivo"
            End Select

            Dim comentario As String = ObtenerComentario(id_factura)

            ' Definir el contenido de la factura para impresión normal
            encabezadoFactura = crearEncabezadoFactura(factura, ObtenerDatosSucursal())

            CargarProds(id_factura)

            finFactura = crearFinFactura(factura, comentario)

            ImprimirFactura(encabezadoFactura, facturaContenido, finFactura)
        End Sub

        Private Function ObtenerDatosGeneralesFactura(id_factura As Integer) As Cls_DatosFactura
            ' Obtener datos principales de la factura, cliente y usuario
            T.Tables.Clear()
            SQL = "SELECT f.ID, strftime('%d-%m-%Y %H:%M:%S', f.fecha_emision) AS 'Fecha de emisión', c.nombre, f.num_factura, f.total, f.efectivo_cliente, " &
              "f.tarjeta_cliente, f.vuelto, f.tipo_venta, u.usuario" &
              " FROM (factura f LEFT JOIN clientes c ON c.ID =f.ID_Cliente) LEFT JOIN usuario u ON u.ID = f.ID_Usuario WHERE f.ID = " & id_factura
            Cargar_Tabla(T, SQL)

            Dim row As DataRow = T.Tables(0).Rows(0)

            Dim numFacturaValue As Integer = If(IsDBNull(row.Item(3)), 0, CInt(row.Item(3)))

            Dim factura As New Cls_DatosFactura With {
                .IdFactura = If(IsDBNull(row.Item(0)), 0, CInt(row.Item(0))),
                .NumFactura = numFacturaValue.ToString("D15"),
                .Fecha = If(IsDBNull(row.Item(1)), "", row.Item(1).ToString()),
                .Cliente = If(IsDBNull(row.Item(2)), "", row.Item(2).ToString()),
                .Cajero = If(IsDBNull(row.Item(9)), "", row.Item(9).ToString()),
                .Efectivo = If(IsDBNull(row.Item(5)), "0", row.Item(5).ToString()),
                .Tarjeta = If(IsDBNull(row.Item(6)), "0", row.Item(6).ToString()),
                .Vuelto = If(IsDBNull(row.Item(7)), "0", row.Item(7).ToString()),
                .TipoPago = If(IsDBNull(row.Item(8)), "0", row.Item(8).ToString()),
                .Comentario = "",
                .TotalCaja = If(IsDBNull(row.Item(4)), 0D, Convert.ToDecimal(row.Item(4)))
            }

            Return factura
        End Function

        Private Function ObtenerComentario(id_factura As Integer) As String
            ' Obtener comentario asociado a la factura
            T.Tables.Clear()
            SQL = "SELECT comentario FROM factura_comentario WHERE ID_Factura = " & id_factura
            Cargar_Tabla(T, SQL)

            Dim comentario As String = "" ' Inicializamos la variable del comentario

            ' Verificamos que se haya cargado al menos una tabla
            If T.Tables.Count > 0 Then
                ' Luego verificamos que esa tabla tenga al menos una fila
                If T.Tables(0).Rows.Count > 0 Then
                    ' Si hay una fila, obtenemos el comentario
                    comentario = If(IsDBNull(T.Tables(0).Rows(0).Item(0)), "", T.Tables(0).Rows(0).Item(0))
                End If
            End If

            Return comentario
        End Function

        Private Function ObtenerDatosSucursal() As Cls_Sucursal
            ' Obtener datos de la sucursal desde la base de datos
            T.Tables.Clear()
            SQL = "SELECT nombre, direccion, telefono, email, ced_juridica  FROM sucursal WHERE ID = 1"
            Cargar_Tabla(T, SQL)
            Dim sucursal As New Cls_Sucursal With {
                .Nombre = If(IsDBNull(T.Tables(0).Rows(0).Item(0)), " ", T.Tables(0).Rows(0).Item(0)),
                .Direccion = If(IsDBNull(T.Tables(0).Rows(0).Item(1)), " ", T.Tables(0).Rows(0).Item(1)),
                .Telefono = If(IsDBNull(T.Tables(0).Rows(0).Item(2)), " ", T.Tables(0).Rows(0).Item(2)),
                .Email = If(IsDBNull(T.Tables(0).Rows(0).Item(3)), " ", T.Tables(0).Rows(0).Item(3)),
                .Cedula = If(IsDBNull(T.Tables(0).Rows(0).Item(4)), " ", T.Tables(0).Rows(0).Item(4))
            }
            Return sucursal
        End Function

        Private Function crearEncabezadoFactura(factura As Cls_DatosFactura, sucursal As Cls_Sucursal) As String
            Return "-------------------------------------------" & vbCrLf &
                                    "        FACTURA DE VENTA" & vbCrLf & vbCrLf &
                                    "-------- " & sucursal.Nombre & " ---------" & vbCrLf & vbCrLf &
                                    "Nº de Factura: " & factura.NumFactura & vbCrLf &
                                    "Cajero: " & factura.Cajero & vbCrLf &
                                    "Ced. Jurídica: " & sucursal.Cedula & vbCrLf &
                                    "Dirección: " & sucursal.Direccion & vbCrLf &
                                    "Teléfono: " & sucursal.Telefono & vbCrLf &
                                    "Email: " & sucursal.Email & vbCrLf &
                                    "Fecha: " & factura.Fecha & vbCrLf &
                                    vbCrLf &
                                    "Cliente:" & factura.Cliente & vbCrLf &
                                    vbCrLf &
                                    "------------------------------------------" & vbCrLf &
                                    "Descripción de Productos" & vbCrLf &
                                    "------------------------------------------" & vbCrLf
        End Function

        Private Function crearFinFactura(factura As Cls_DatosFactura, comentario As String) As String
            Dim finFact As String = "-----------------------------------------" & vbCrLf &
                          "Total de la venta: ₡ " & factura.TotalCaja & vbCrLf &
                          vbCrLf
            If factura.TipoPago = 1 Then
                finFact += "Pago del cliente: ₡ " & factura.Efectivo & vbCrLf

            ElseIf factura.TipoPago = 4 Then
                finFact += "Pago en efectivo: ₡ " & factura.Efectivo & vbCrLf &
                    vbCrLf &
                     "Pago en tarjeta: ₡ " & factura.Tarjeta
            Else
                finFact += "Pago en tarjeta: ₡ " & factura.Tarjeta & vbCrLf
            End If

            finFact += $"Comentario: {comentario}"

            Return finFact
        End Function

        Public Sub ImprimirFactura(encabezado As String, productos As List(Of String), fin As String)
            Dim printDoc As New PrintDocument()

            ' Usamos AddHandler para pasar los parámetros de la factura al controlador de eventos
            AddHandler printDoc.PrintPage, Sub(sender, e)
                                               printDocument_PrintPage(sender, e, encabezado, productos, fin)
                                           End Sub
            ' 1. ANCHO: 80 mm (3.15 in) = 227 puntos.
            ' 2. ALTO: Se mantiene un valor simbólicamente grande para rollo continuo.
            Dim anchoEnPuntos As Integer = CInt(72 * 3.15)
            Dim altoSimbolico As Integer = CInt(72 * 50)

            Dim customPaperSize As New PaperSize("80mm Roll", anchoEnPuntos, altoSimbolico)
            printDoc.DefaultPageSettings.PaperSize = customPaperSize
            printDoc.DefaultPageSettings.Margins = New Margins(0, 0, 0, 0)

            Using printDialog As New PrintDialog()
                ' Asignar el documento al diálogo
                printDialog.Document = printDoc

                ' Permitir solo la selección de impresora, no ajustes avanzados
                printDialog.AllowSomePages = False

                ' Mostrar el diálogo y verificar si el usuario presionó OK
                If printDialog.ShowDialog() = DialogResult.OK Then
                    ' Si el usuario seleccionó una impresora y presionó Aceptar,
                    ' la propiedad Document del diálogo ya tiene la impresora seleccionada.

                    ' Llama al método Print(), que inicia el evento PrintPage
                    printDoc.Print()
                End If
            End Using

            'Se muestra al usuario una vista previa del proceso de impresión
            Dim printPreview As New PrintPreviewDialog With {.Document = printDoc}
            printPreview.ShowDialog()
        End Sub

        ' Manejador del evento PrintPage que ahora recibe los parámetros de la factura
        Private Sub printDocument_PrintPage(sender As Object, e As Printing.PrintPageEventArgs, encabezado As String, productos As List(Of String), fin As String)
            Dim font As New Font("Arial", 12)
            Dim fontProds As New Font("Segoe UI", 9)
            Dim brush As New SolidBrush(Color.Black)
            ' Agregamos la opción para que el texto se envuelva automáticamente
            Dim stringFormatWrap As New StringFormat() With {
                .Alignment = StringAlignment.Near,
                .LineAlignment = StringAlignment.Near,
                .Trimming = StringTrimming.Word,
                .FormatFlags = StringFormatFlags.LineLimit '
            }

            Dim stringFormatRight As New StringFormat() With {
                .Alignment = StringAlignment.Far, ' Alineación a la derecha
                .LineAlignment = StringAlignment.Near,
                .Trimming = StringTrimming.None,
                .FormatFlags = StringFormatFlags.NoWrap
            }

            ' El ancho total de la impresión es fijo, no uses e.MarginBounds.Left/Top si son 0
            ' totalWidth = 72 * 3.78 (272 puntos)
            Dim totalWidth As Single = 270.0F
            Dim leftMargin As Single = 10 ' Pequeño margen
            Dim xPos As Single = leftMargin
            Dim yPos As Single = 10

            ' --- Encabezado ---
            ' Usamos un ancho de RectangleF para que el texto del encabezado se ajuste
            Dim headerRect As New RectangleF(leftMargin, yPos, totalWidth - (leftMargin * 2), 0)
            e.Graphics.DrawString(encabezado, font, brush, headerRect, stringFormatWrap)
            yPos += e.Graphics.MeasureString(encabezado, font, CInt(headerRect.Width), stringFormatWrap).Height + 5

            ' --- Encabezado de Productos (Cant, Descrip, Precio, Total) ---
            e.Graphics.DrawString(encabezadoProds, fontProds, brush, leftMargin, yPos)
            yPos += e.Graphics.MeasureString(encabezadoProds, fontProds, CInt(totalWidth), stringFormatWrap).Height + 5

            ' --- Productos línea por línea ---
            ' Definimos los anchos de cada columna (ajustados a un ancho total de ~272 puntos)
            Dim colWidthCant As Single = 35.0F
            Dim colWidthDesc As Single = 110.0F
            Dim colWidthPrecio As Single = 50.0F
            Dim colWidthTotal As Single = 50.0F

            For Each line As String In productos
                ' Usamos el separador de asterisco de CargarProds
                Dim columns() As String = line.Split("*"c)

                If columns.Length = 4 Then
                    Dim cant As String = columns(0)
                    Dim desc As String = columns(1)
                    Dim precio As String = columns(2)
                    Dim total As String = columns(3)

                    Dim maxHeight As Single = 0

                    ' 1. Dibujar Descripción (columna con ajuste de línea) - Usa stringFormatWrap
                    Dim descRect As New RectangleF(leftMargin + colWidthCant, yPos, colWidthDesc, e.MarginBounds.Height)
                    e.Graphics.DrawString(desc, fontProds, brush, descRect, stringFormatWrap)

                    ' Medir la altura REAL de la descripción
                    maxHeight = e.Graphics.MeasureString(desc, fontProds, CInt(colWidthDesc), stringFormatWrap).Height

                    ' 2. Dibujar Cantidad (Izquierda) - Usa stringFormatWrap o Near
                    Dim rectCant As New RectangleF(leftMargin, yPos, colWidthCant, maxHeight)
                    e.Graphics.DrawString(cant, fontProds, brush, rectCant, stringFormatWrap) ' <--- OK con stringFormatWrap

                    ' 3. Dibujar Precio (Derecha) - ¡Usa stringFormatRight!
                    Dim rectPrecio As New RectangleF(leftMargin + colWidthCant + colWidthDesc, yPos, colWidthPrecio, maxHeight)
                    e.Graphics.DrawString(precio, fontProds, brush, rectPrecio, stringFormatRight) ' <--- CAMBIO

                    ' 4. Dibujar Total (Derecha) - ¡Usa stringFormatRight!
                    Dim rectTotal As New RectangleF(leftMargin + colWidthCant + colWidthDesc + colWidthPrecio, yPos, colWidthTotal, maxHeight)
                    e.Graphics.DrawString(total, fontProds, brush, rectTotal, stringFormatRight) ' <--- CAMBIO

                    yPos += maxHeight + 2
                End If
            Next

            ' --- Fin de Factura ---
            yPos += 10
            Dim finRect As New RectangleF(leftMargin, yPos, totalWidth - (leftMargin * 2), e.MarginBounds.Height)
            e.Graphics.DrawString(fin, font, brush, finRect, stringFormatWrap)
        End Sub

        ' Carga los productos de la factura y los agrega al contenido de impresión
        ' idfact: ID de la factura
        ' reimprimir: True si es reimpresión, False si es impresión normal
        Private Sub CargarProds(idfact As Integer)
            T.Tables.Clear()
            SQL = "SELECT f.cant, p.nombre, f.precio_venta FROM ((factura_producto f LEFT JOIN producto p ON p.ID = f.ID_Producto)" &
              " LEFT JOIN Producto_precioVenta v ON p.ID = v.ID_Producto) WHERE ID_Factura = " & idfact
            Cargar_Tabla(T, SQL)

            If T.Tables(0).Rows.Count > 0 Then
                For i As Integer = 0 To T.Tables(0).Rows.Count - 1
                    Dim cantidad As Double = Convert.ToDouble(T.Tables(0).Rows(i).Item(0))
                    Dim nombreProd As String = T.Tables(0).Rows(i).Item(1).ToString()
                    Dim precioVenta As Double = Convert.ToDouble(T.Tables(0).Rows(i).Item(2))
                    Dim totalLinea As Double = cantidad * precioVenta

                    ' Formatear la línea de producto. Usaremos tabulaciones o espacios fijos 
                    ' para la vista previa, pero en el PrintPage lo dibujaremos en columnas.
                    Dim lineaFormateada As String = $"{cantidad:N2} | {nombreProd} | {precioVenta:N2} | {totalLinea:N2}"

                    ' Lo importante es guardar los datos de la línea en un formato que 
                    ' nos permita procesar las columnas correctamente después. 
                    ' Para simplificar, usaremos un carácter que NO aparezca en los nombres.
                    Dim datosProducto As String = $"{cantidad}*{nombreProd}*{precioVenta}*{totalLinea}" ' Separador de asterisco

                    facturaContenido.Add(datosProducto)
                Next
            End If
        End Sub

        Public Class ImpresionHabladores

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
                            Return
                        End If
                    Next

                    currentQuantityIndex = 0
                Next

                ' Si se completó la impresión, limpiar variables
                If Not e.HasMorePages Then
                    printProducts = Nothing
                    printPrices = Nothing
                    printQuantities = Nothing
                    DGV_Referencia?.Rows.Clear()
                End If
            End Sub

        End Class
    End Module

End Namespace