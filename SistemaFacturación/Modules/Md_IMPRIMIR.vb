' -----------------------------------------------------------------------------
' Módulo para la generación y armado de la factura impresa o reimpresa
' Obtiene los datos de la factura, cliente, sucursal y productos para mostrar
' en la vista previa de impresión o reimpresión.
' -----------------------------------------------------------------------------
Imports System.Data.SQLite
Imports System.Drawing.Printing
Imports Serilog
Imports Serilog.Context
Imports SistemaFacturaciónCommon.SistemaFacturacion.Data
Imports SistemaFacturaciónCommon.SistemaFacturacion.Forms.Dialogos
Namespace SistemaFacturacion.Modules

    Module Md_IMPRIMIR
        ' Variables para el contenido de la factura (impresión)
        Friend encabezadoFactura As String
        Friend encabezadoProds As String = "Cant        Descripción             Precio        Total" & vbCrLf &
                                                        "--------------------------------------------------" & vbCrLf
        Friend facturaContenido As New List(Of String)()
        Friend finFactura As String

        Private Sub LIMPIAR()
            Log.Information("Limpiando variables de impresión de factura")
            encabezadoFactura = ""
            facturaContenido.Clear()
            finFactura = ""
        End Sub

        ' Genera el contenido de la factura para impresión o reimpresión
        ' id_factura: ID de la factura a imprimir
        ' reimprimir: True si es reimpresión, False si es impresión normal
        Public Sub GENERAR_FACTURA(ID As Integer, tipo As String)
            LIMPIAR()

            Select Case tipo
                Case "Abono"
                    Log.Information("Generando factura de abono para impresión. ID Pago: {ID}", ID)
                    ImprimirFacturaAbono(ID)
                Case Else
                    Log.Information("Generando factura de venta para impresión. ID Factura: {ID}", ID)
                    ImprimirFacturaVenta(ID)
            End Select

            Log.Information("Iniciando proceso de impresión de factura.")
            ImprimirFactura(encabezadoFactura, facturaContenido, finFactura)
        End Sub

        Private Sub ImprimirFacturaVenta(id_Factura As Integer)
            Dim Factura As Cls_DatosFactura = ObtenerDatosGeneralesFactura(id_Factura)
            Log.Information("Datos generales de la factura obtenidos. ID: {ID}, NumFactura: {NumFactura}", Factura.IdFactura, Factura.NumFactura)

            Dim comentario As String = ObtenerComentario(id_Factura)
            Log.Information("Comentario de la factura obtenido: {Comentario}", If(String.IsNullOrEmpty(comentario), "Ninguno", comentario))

            ' Definir el contenido de la factura para impresión normal
            encabezadoFactura = CrearEncabezadoFactura(Factura, ObtenerDatosSucursal())
            Log.Information("Encabezado de la factura creado.")

            CargarProds(id_Factura)
            Log.Information("Productos de la factura cargados. Total productos: {Count}", facturaContenido.Count)

            finFactura = CrearFinFactura(Factura, comentario)
            Log.Information("Pie de la factura creado.")
        End Sub

        Private Sub ImprimirFacturaAbono(ID_pago As Integer)

            Dim pago As New Cls_CxCPagos
            pago.GetDetailsWithID(ID_pago)
            Log.Information("Datos del pago obtenidos. ID: {ID}, Monto: {Monto}, Tipo Venta: {TipoVenta}", pago.ID, pago.Total, pago.Tipo_venta)

            Dim cuenta As New Cls_CuentasXCobrar
            cuenta.GetDetailsWithID(pago.ID_CxC)
            Log.Information("Datos de la cuenta por cobrar obtenidos. ID: {ID}, Cliente: {Cliente}, Saldo Restante: {Saldo}", cuenta.ID, cuenta.Cliente, cuenta.Saldo_restante)

            ' Definir el contenido de la factura para impresión normal
            encabezadoFactura = CrearEncabezadoAbono(pago, ObtenerDatosSucursal(), cuenta)
            Log.Information("Encabezado de la factura de abono creado.")

            CargarProdsAbono(cuenta.ID)
            Log.Information("Productos de la cuenta por cobrar cargados. Total productos: {Count}", facturaContenido.Count)

            finFactura = CrearFinAbono(pago, cuenta)
            Log.Information("Pie de la factura de abono creado.")
        End Sub

        Private Function ObtenerDatosGeneralesFactura(id_factura As Integer) As Cls_DatosFactura
            ' Obtener datos principales de la factura, cliente y usuario
            T.Tables.Clear()
            SQL = "SELECT f.ID, strftime('%d-%m-%Y %H:%M:%S', f.fecha_emision) AS 'Fecha de emisión', c.nombre, f.num_factura, f.total, f.efectivo_cliente, " &
              "f.tarjeta_cliente, f.vuelto, f.tipo_venta, u.usuario" &
              " FROM (factura f LEFT JOIN clientes c ON c.ID =f.ID_Cliente) LEFT JOIN usuario u ON u.ID = f.ID_Usuario WHERE f.ID = " & id_factura
            Cargar_Tabla(T, SQL)
            Log.Information("Consulta SQL ejecutada para obtener datos de la factura. Filas obtenidas: {RowCount}", T.Tables(0).Rows.Count)

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

            Log.Information("Datos de la factura mapeados a Cls_DatosFactura. ID: {ID}, NumFactura: {NumFactura}, Total: {Total}", factura.IdFactura, factura.NumFactura, factura.TotalCaja)
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

            Log.Information("Comentario obtenido de la factura: {Comentario}", If(String.IsNullOrEmpty(comentario), "Ninguno", comentario))
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
            Log.Information("Datos de la sucursal obtenidos. Nombre: {Nombre}, Dirección: {Direccion}", sucursal.Nombre, sucursal.Direccion)
            Return sucursal
        End Function

        Private Function CrearEncabezadoFactura(factura As Cls_DatosFactura, sucursal As Cls_Sucursal) As String
            Return "------------------------------------------" & vbCrLf &
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

        Private Function CrearEncabezadoAbono(pago As Cls_CxCPagos, sucursal As Cls_Sucursal, cuentas As Cls_CuentasXCobrar) As String
            Return "------------------------------------------" & vbCrLf &
                                    "        FACTURA DE VENTA" & vbCrLf & vbCrLf &
                                    "-------- " & sucursal.Nombre & " ---------" & vbCrLf & vbCrLf &
                                    "Cajero: " & pago.Cajero & vbCrLf &
                                    "Ced. Jurídica: " & sucursal.Cedula & vbCrLf &
                                    "Dirección: " & sucursal.Direccion & vbCrLf &
                                    "Teléfono: " & sucursal.Telefono & vbCrLf &
                                    "Email: " & sucursal.Email & vbCrLf &
                                    "Fecha: " & pago.Fecha & vbCrLf &
                                    vbCrLf &
                                    "Cliente:" & cuentas.Cliente & vbCrLf &
                                    vbCrLf &
                                    "------------------------------------------" & vbCrLf &
                                    "Descripción de Productos" & vbCrLf &
                                    "------------------------------------------" & vbCrLf
        End Function

        Private Function CrearFinAbono(pago As Cls_CxCPagos, cuenta As Cls_CuentasXCobrar) As String
            Dim finFact As String = "-----------------------------------------" & vbCrLf &
                          "Total de la cuenta: " & pago.Formated_total & vbCrLf & vbCrLf
            If pago.Tipo_venta = 0 Then
                finFact += "Pago del cliente: " & pago.Formated_monto_efectivo & vbCrLf

            ElseIf pago.Tipo_venta = 4 Then
                finFact += "Pago en efectivo: " & pago.Formated_monto_efectivo & vbCrLf &
                    vbCrLf &
                     "Pago en tarjeta: " & pago.Formated_monto_tarjeta & vbCrLf
                finFact += "Total Abonado: " & pago.Total & vbCrLf
            Else
                finFact += "Pago en tarjeta: " & pago.Formated_monto_tarjeta & vbCrLf
            End If

            finFact += "Saldo Restante: " & cuenta.Formated_Saldo_restante & vbCrLf

            finFact += $"Comentario: {pago.Comentario}"

            Log.Information("Fin de la factura de abono creado. Total Cuenta: {TotalCuenta}, Saldo Restante: {SaldoRestante}", pago.Total, cuenta.Saldo_restante)
            Return finFact
        End Function

        Private Function CrearFinFactura(factura As Cls_DatosFactura, comentario As String) As String
            Dim finFact As String = "-----------------------------------------" & vbCrLf &
                          "Total de la venta: ₡ " & factura.TotalCaja & vbCrLf &
                          vbCrLf
            If factura.TipoPago = 0 Then
                finFact += "Pago del cliente: ₡ " & factura.Efectivo & vbCrLf

            ElseIf factura.TipoPago = 4 Then
                finFact += "Pago en efectivo: ₡ " & factura.Efectivo & vbCrLf &
                    vbCrLf &
                     "Pago en tarjeta: ₡ " & factura.Tarjeta
            Else
                finFact += "Pago en tarjeta: ₡ " & factura.Tarjeta & vbCrLf
            End If

            finFact += $"Comentario: {comentario}"

            Log.Information("Fin de la factura creado. Total Venta: {TotalVenta}, Tipo Pago: {TipoPago}", factura.TotalCaja, factura.TipoPago)
            Return finFact
        End Function

        Public Sub ImprimirFactura(encabezado As String, productos As List(Of String), fin As String)
            Using LogContext.PushProperty("Feature", "ImpresionFactura")
                Try
                    Log.Information("Iniciando configuración del PrintDocument para impresión de factura.")

                    Dim printDoc As New PrintDocument()

                    ' Usamos AddHandler para pasar los parámetros de la factura al controlador de eventos
                    AddHandler printDoc.PrintPage, Sub(sender, e)
                                                       PrintDocument_PrintPage(e, encabezado, productos, fin)
                                                   End Sub
                    ' 1. ANCHO: 80 mm (3.15 in) = 227 puntos.
                    ' 2. ALTO: Se mantiene un valor simbólicamente grande para rollo continuo.
                    Dim anchoEnPuntos As Integer = CInt(72 * 3.15)
                    Dim altoSimbolico As Integer = CInt(72 * 50)
                    Log.Debug("Configuración de papel: {Ancho}x{Alto} puntos para impresora térmica.", anchoEnPuntos, altoSimbolico)

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
                            Log.Information("Impresión iniciada. Impresora seleccionada: {PrinterName}", printDialog.Document.PrinterSettings.PrinterName)
                            ' Llama al método Print(), que inicia el evento PrintPage
                            printDoc.Print()
                        Else
                            Log.Information("Diálogo de impresión cancelado por el usuario. Impresión abortada.")
                        End If
                    End Using

                    Log.Debug("Mostrando previsualización de impresión.")
                    'Se muestra al usuario una vista previa del proceso de impresión
                    Dim printPreview As New PrintPreviewDialog With {.Document = printDoc}
                    printPreview.ShowDialog()
                Catch ex As Exception
                    ' Notificar al usuario (puede que sea necesario)
                    MsgError($"Error fatal al imprimir. Verifique la conexión de la impresora. Error: {ex.Message}")
                End Try

            End Using
        End Sub

        ' Manejador del evento PrintPage que ahora recibe los parámetros de la factura
        Private Sub PrintDocument_PrintPage(e As Printing.PrintPageEventArgs, encabezado As String, productos As List(Of String), fin As String)
            Using LogContext.PushProperty("Feature", "DrawFactura")
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

                Log.Debug("Iniciando dibujo de PrintPage. Ancho de página: {TotalWidth} puntos.", totalWidth)


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
                        Log.Debug("Dibujando producto: Cant={Cant}, Desc={Desc}", columns(0), columns(1))

                        Dim maxHeight As Single = 0

                        ' 1. Dibujar Descripción (columna con ajuste de línea) - Usa stringFormatWrap
                        Dim descRect As New RectangleF(leftMargin + colWidthCant, yPos, colWidthDesc, e.MarginBounds.Height)
                        e.Graphics.DrawString(desc, fontProds, brush, descRect, stringFormatWrap)

                        ' Medir la altura REAL de la descripción
                        maxHeight = e.Graphics.MeasureString(desc, fontProds, CInt(colWidthDesc), stringFormatWrap).Height

                        ' 2. Dibujar Cantidad (Izquierda) - Usa stringFormatWrap o Near
                        Dim rectCant As New RectangleF(leftMargin, yPos, colWidthCant, maxHeight)
                        e.Graphics.DrawString(cant, fontProds, brush, rectCant, stringFormatWrap)

                        ' 3. Dibujar Precio (Derecha) - ¡Usa stringFormatRight!
                        Dim rectPrecio As New RectangleF(leftMargin + colWidthCant + colWidthDesc, yPos, colWidthPrecio, maxHeight)
                        e.Graphics.DrawString(precio, fontProds, brush, rectPrecio, stringFormatRight)

                        ' 4. Dibujar Total (Derecha) - ¡Usa stringFormatRight!
                        Dim rectTotal As New RectangleF(leftMargin + colWidthCant + colWidthDesc + colWidthPrecio, yPos, colWidthTotal, maxHeight)
                        e.Graphics.DrawString(total, fontProds, brush, rectTotal, stringFormatRight)

                        yPos += maxHeight + 2
                    Else
                        Log.Warning("Línea de producto mal formada (esperado 4 columnas, encontrado {Count}). Línea: {ProductLine}", columns.Length, line)
                    End If
                Next

                ' --- Fin de Factura ---
                yPos += 10
                Log.Debug("Fin de dibujo de productos. Altura final Y: {YPos}", yPos)
                Dim finRect As New RectangleF(leftMargin, yPos, totalWidth - (leftMargin * 2), e.MarginBounds.Height)
                e.Graphics.DrawString(fin, font, brush, finRect, stringFormatWrap)
            End Using

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

            Log.Information("Productos cargados para impresión. Total productos: {Count}", facturaContenido.Count)
        End Sub

        Private Sub CargarProdsAbono(idfact As Integer)
            T.Tables.Clear()
            SQL = "SELECT p.nombre, cdp.precio , cdp.cantidad , cdp.total_linea 
                    FROM CC_DetalleProducto cdp 
                    left join producto p ON cdp.ID_Producto = p.ID
                    WHERE cdp.ID_Encabezado = @ID"
            Dim paramList As New List(Of SQLiteParameter) From {
                    {New SQLiteParameter("@ID", idfact)}
            }
            CargarTablaParam(T, SQL, paramList)

            If T Is Nothing OrElse T.Tables.Count <= 0 OrElse T.Tables(0).Rows.Count <= 0 Then
                Log.Warning("No se encontraron productos para la cuenta por cobrar ID: {ID}", idfact)
                Exit Sub
            End If

            For Each row As DataRow In T.Tables(0).Rows
                Dim producto As New Cls_DetalleProductoCxC With {
                    .Cantidad = row("cantidad"),
                    .Nombre = row("nombre"),
                    .Precio = row("precio")
                }

                ' Formatear la línea de producto. Usaremos tabulaciones o espacios fijos 
                ' para la vista previa, pero en el PrintPage lo dibujaremos en columnas.
                Dim lineaFormateada As String = $"{producto.Cantidad} | {producto.Nombre} | {producto.Precio:N2} | {producto.Total:N2}"

                ' Lo importante es guardar los datos de la línea en un formato que 
                ' nos permita procesar las columnas correctamente después. 
                ' Para simplificar, usaremos un carácter que NO aparezca en los nombres.
                Dim datosProducto As String = $"{producto.Cantidad}*{producto.Nombre}*{producto.Precio:N2}*{producto.Total:N2}" ' Separador de asterisco

                facturaContenido.Add(datosProducto)
            Next

            Log.Information("Productos de la cuenta por cobrar cargados para impresión. Total productos: {Count}", facturaContenido.Count)
        End Sub
    End Module

End Namespace