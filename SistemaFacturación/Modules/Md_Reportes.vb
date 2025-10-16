Imports System.Configuration
Imports System.Data.SQLite
Imports System.Globalization
Imports System.IO
Imports Serilog
Imports Serilog.Context
Imports SistemaFacturaciónCommon.SistemaFacturacion.Data
Imports Syncfusion.Pdf
Imports Syncfusion.Pdf.Graphics
Imports Syncfusion.Pdf.Grid
Namespace SistemaFacturacion.Modules

    Module Md_Reportes
        ' Declaraciones a nivel de módulo
        Dim reportePDF As PdfDocument
        Dim pag As PdfPage
        Dim graficos As PdfGraphics
        Dim pos As New PointF(10, 10)

#Region "Obtención de datos"
        Friend Async Function GenerarReporte(desde As Date, hasta As Date, t As DataSet) As Task(Of Cls_ReporteVentas)
            Try
                Dim listaVentas As List(Of Cls_DatosFactura) = Await ObtenerListaVentas(desde, hasta, t)
                Log.Information($"Se obtuvieron {listaVentas.Count} ventas entre {desde} y {hasta}")

                Dim totalVentas As Decimal = 0D
                Dim ventasEfectivo As Decimal = 0D
                Dim ventasTarjeta As Decimal = 0D

                For Each venta As Cls_DatosFactura In listaVentas
                    totalVentas += venta.TotalCaja
                    If venta.TipoPago = "Efectivo" Then
                        ventasEfectivo += venta.TotalCaja
                    ElseIf venta.TipoPago = "Mixto" Then
                        ventasEfectivo += venta.Efectivo
                        ventasTarjeta += venta.Tarjeta
                    Else
                        ventasTarjeta += venta.TotalCaja
                    End If
                Next
                Log.Information("Cálculo de totales completado: " &
                                $"Total Ventas: {totalVentas}, " &
                                $"Ventas Efectivo: {ventasEfectivo}, " &
                                $"Ventas Tarjeta: {ventasTarjeta}")

                Dim numVentas As Integer = listaVentas.Count

                ' Se obtiene el producto más vendido dentro del rango especificado
                Dim producto = Await GetProductosMasVendido(1, desde, hasta, 1)

                Dim productoMasVendido As Cls_ProductosMasVendidos = Nothing
                If producto IsNot Nothing AndAlso producto.Count > 0 Then
                    productoMasVendido = producto(0)
                End If
                Log.Information("Producto más vendido obtenido: " &
                                If(productoMasVendido IsNot Nothing,
                                   $"Nombre: {productoMasVendido.Nombre}, Cantidad: {productoMasVendido.Cantidad}, Total: {productoMasVendido.Total}",
                                   "Ningún producto vendido"))

                Dim reporte As New Cls_ReporteVentas(listaVentas, totalVentas, numVentas, ventasEfectivo, ventasTarjeta, productoMasVendido)

                Log.Information("Reporte de ventas generado exitosamente.")
                Return reporte
            Catch ex As Exception
                ' Devuelve un objeto vacío en caso de error
                Log.Error(ex, "Error al generar el reporte de ventas.")
                Return New Cls_ReporteVentas()
            End Try
        End Function


        Friend Async Function ObtenerListaVentas(desde As Date, hasta As Date, t As DataSet) As Task(Of List(Of Cls_DatosFactura))
            Return Await Task.Run(Function()
                                      Dim consulta As String = "SELECT 
                                                                        f.ID,
                                                                        f.num_factura AS '# Fact',
                                                                        f.fecha_emision AS 'Fecha de emisión',
                                                                        c.nombre AS 'Cliente',
                                                                        u.usuario As 'Cajero',
                                                                        fc.comentario  As 'Comentario',
                                                                        f.efectivo_cliente AS 'Efectivo',
                                                                        f.tarjeta_cliente AS 'Tarjeta',
                                                                        f.total AS 'Total',
                                                                        f.tipo_venta AS 'tipo',
                                                                        f.vuelto  As Vuelto
                                                                    FROM 
                                                                        factura f
                                                                    INNER JOIN 
                                                                        clientes c ON c.ID = f.ID_Cliente
                                                                    INNER JOIN
	                                                                    usuario u  ON u.ID = f.ID_Usuario 
                                                                    LEFT JOIN 
	                                                                    factura_comentario fc  ON fc.ID_Factura  =f.ID 
                                                                    WHERE 
                                                                        f.fecha_emision >= @fechaInicio
                                                                        AND f.fecha_emision <  @fechaFin;"

                                      Dim paramList As New List(Of SQLiteParameter) From {
                                          New SQLiteParameter("@fechaInicio", desde),
                                          New SQLiteParameter("@fechaFin", hasta)
                                      }

                                      'Se limpia el dataset antes de llenarlo
                                      t.Tables.Clear()

                                      Log.Information($"Ejecutando consulta de ventas entre {desde} y {hasta}")
                                      CargarTablaParam(t, consulta, paramList)

                                      Dim listaVentas As New List(Of Cls_DatosFactura)

                                      ' Si la tabla no tiene filas, se devuelve la lista vacía
                                      If t.Tables.Count <= 0 Then
                                          Log.Warning("No se encontraron ventas en el rango especificado.")
                                          Return listaVentas
                                      End If

                                      For Each row As DataRow In t.Tables(0).Rows
                                          Dim factura As New Cls_DatosFactura With {
                                        .IdFactura = row.Item("ID").ToString(),
                                        .NumFactura = row.Item("# Fact").ToString(),
                                        .Fecha = Convert.ToDateTime(row.Item("Fecha de emisión")),
                                        .Cliente = row.Item("Cliente").ToString(),
                                        .Cajero = row.Item("Cajero").ToString(),
                                        .Comentario = row.Item("Comentario").ToString(),
                                        .Efectivo = Convert.ToDecimal(row.Item("Efectivo")),
                                        .Tarjeta = Convert.ToDecimal(row.Item("Tarjeta")),
                                        .TotalCaja = Convert.ToDecimal(row.Item("Total")),
                                        .Vuelto = Convert.ToDecimal(row.Item("Vuelto"))
                                        }

                                          'Se obtiene el número del tipo de venta
                                          Dim tipoVentaNum As Integer = Convert.ToInt32(row.Item("tipo"))
                                          Dim tipoVenta As String

                                          Select Case tipoVentaNum
                                              Case 0
                                                  tipoVenta = "Efectivo"
                                              Case 1
                                                  tipoVenta = "Tarjeta"
                                              Case 2
                                                  tipoVenta = "Sinpe"
                                              Case 3
                                                  tipoVenta = "Depósito"
                                              Case 4
                                                  tipoVenta = "Mixto"
                                              Case Else
                                                  tipoVenta = "Desconocido"
                                          End Select
                                          factura.TipoPago = tipoVenta
                                          'Se añade la factura a la lista
                                          listaVentas.Add(factura)
                                      Next

                                      Log.Information($"Total de ventas obtenidas: {listaVentas.Count}")
                                      Return listaVentas
                                  End Function)
        End Function

        Friend Async Function GetProductosMasVendido(LIMIT As Integer, desde As Date, hasta As Date, orderBy As Integer) As Task(Of List(Of Cls_ProductosMasVendidos))
            Return Await Task.Run(Function()
                                      Dim listProductosMasVendidos As New List(Of Cls_ProductosMasVendidos)
                                      Try
                                          Dim orderByProperty As String
                                          Select Case orderBy
                                              Case 1
                                                  orderByProperty = "unidadesVendidas"
                                              Case 2
                                                  orderByProperty = "total"
                                              Case Else
                                                  orderByProperty = "total"
                                          End Select

                                          Dim consulta As String = "SELECT COUNT(fp.ID_Producto) AS unidadesVendidas, p.nombre, SUM(fp.precio_venta * fp.cant) As total " &
                                                                   "FROM factura f " &
                                                                   "INNER JOIN factura_producto fp ON f.ID = fp.ID_Factura " &
                                                                   "INNER JOIN producto p ON fp.ID_Producto = p.ID " &
                                                                   "WHERE f.fecha_emision >= @fecha_inicio AND f.fecha_emision < @fecha_fin " &
                                                                   "GROUP BY p.nombre " &
                                                                   $"ORDER BY {orderByProperty} DESC " &
                                                                   "LIMIT @limite;"


                                          Dim paramList As New List(Of SQLiteParameter) From {
                                                  New SQLiteParameter("@fecha_inicio", desde.ToString("yyyy-MM-dd HH:mm:ss")),
                                                  New SQLiteParameter("@fecha_fin", hasta.ToString("yyyy-MM-dd HH:mm:ss")),
                                                  New SQLiteParameter("@limite", LIMIT)
                                          }

                                          Log.Information($"Ejecutando consulta de productos más vendidos entre {desde} y {hasta}, ordenando por {orderByProperty} y limitando a {LIMIT} resultados.")
                                          CargarTablaParam(T, consulta, paramList)

                                          If T.Tables.Count > 0 AndAlso T.Tables(0).Rows.Count > 0 Then
                                              Log.Information($"Se encontraron {T.Tables(0).Rows.Count} productos vendidos en el rango especificado.")
                                              For Each row As DataRow In T.Tables(0).Rows
                                                  Dim prod As New Cls_ProductosMasVendidos(row.Item("unidadesVendidas"), row.Item("nombre"), row.Item("total"))
                                                  listProductosMasVendidos.Add(prod)
                                              Next
                                          End If
                                      Catch ex As Exception
                                          Log.Error(ex, "Error al obtener los productos más vendidos.")
                                          Throw ex
                                      End Try
                                      Log.Information($"Total de productos más vendidos obtenidos: {listProductosMasVendidos.Count}")
                                      Return listProductosMasVendidos
                                  End Function)
        End Function

        Private Async Function GetInfoSucursal() As Task(Of Cls_Sucursal)
            Return Await Task.Run(Function()
                                      Dim consulta As String = "SELECT nombre, logo FROM sucursal;"
                                      Log.Information("Obteniendo información de la sucursal desde la base de datos.")
                                      Cargar_Tabla(T, consulta)
                                      Dim suc As New Cls_Sucursal With {
                                          .Nombre = T.Tables(0).Rows(0).Item(0),
                                          .logo = T.Tables(0).Rows(0).Item(1)
                                      }
                                      Log.Information($"Información de la sucursal obtenida: Nombre = {suc.Nombre}, Logo = {suc.logo}")
                                      Return suc
                                  End Function)
        End Function
#End Region

        Friend Async Sub Crear_PDF_ReporteVentas(desde As Date, hasta As Date)
            Using LogContext.PushProperty("Feature", "Reportes")
                Try
                    Log.Information("Iniciando la generación del reporte de ventas en PDF.")

                    pos = New PointF(10, 10)
                    'Se obtiene la información relevante de la base de datos
                    Dim reporte As Cls_ReporteVentas = Await GenerarReporte(desde, hasta, T1)
                    Log.Information("Reporte de ventas generado: {numVentas}, Total: {montoTotal}", reporte.num_ventas, reporte.total_ventas)
                    Dim cultura As New CultureInfo("es-CR")

                    Dim listaFiltrada = reporte.ListaVentas.Select(Function(venta) New With {
                            venta.NumFactura,
                            venta.Fecha,
                            venta.Cajero,
                            venta.Cliente,
                            venta.TipoPago,
                            .TotalCaja = venta.TotalCaja.ToString("C", New CultureInfo("es-CR"))})

                    'Se obtienen los datos de la sucursal
                    Dim sucursal As Cls_Sucursal = Await GetInfoSucursal()
                    Log.Information("Información de la sucursal para el reporte obtenida.")
                    ' 2. Se verifica si la ruta del logo de la sucursal existe en el disco
                    If String.IsNullOrEmpty(sucursal.logo) OrElse Not System.IO.File.Exists(sucursal.logo) Then
                        Log.Warning("La ruta del logo de la sucursal no es válida o está vacía. Se utilizará el logo de respaldo.")
                        ' Si la ruta no es válida, se construye una ruta dinámica para el logo de respaldo
                        Dim rutaBase As String = Application.StartupPath
                        Dim rutaRecursos As String = System.IO.Path.Combine(rutaBase, "recursos")
                        sucursal.logo = System.IO.Path.Combine(rutaRecursos, "logoCompletoSFCommon.jpg")
                    End If

                    Log.Information($"Ruta del logo de la sucursal: {sucursal.logo}")
                    Dim logo As New PdfBitmap(sucursal.logo)

                    'Se establecen las variables necesarias para guardar el archivo
                    Dim rutaDescargas As String = GetAppSetting("DirectorioDescargaReportes")
                    Dim rutaCompleta As String = Path.Combine(rutaDescargas, $"ReporteDeVentas{Date.Now:yyyyMMddHHmmss}.pdf")

                    ' 1. Define diferentes estilos de fuente
                    Dim fontTitulo As New PdfStandardFont(PdfFontFamily.Courier, 18, PdfFontStyle.Bold)
                    Dim fontSubTitulo As New PdfStandardFont(PdfFontFamily.Courier, 14, PdfFontStyle.Bold)
                    Dim fontNormal As New PdfStandardFont(PdfFontFamily.Courier, 10)
                    Dim fontNormalNegrita As New PdfStandardFont(PdfFontFamily.Courier, 10, PdfFontStyle.Bold)

                    'Crea y define el objeto para la alineación
                    Dim fCentrado As New PdfStringFormat With {
                        .Alignment = PdfTextAlignment.Center
                    }
                    Dim fIzquierda As New PdfStringFormat With {
                        .Alignment = PdfTextAlignment.Left
                    }
                    Dim fDerecha As New PdfStringFormat With {
                        .Alignment = PdfTextAlignment.Right
                    }
                    Dim fJustify As New PdfStringFormat With {
                        .Alignment = PdfTextAlignment.Justify
                    }

                    reportePDF = New PdfDocument()
                    pag = reportePDF.Pages.Add()
                    graficos = pag.Graphics

                    'Se definen las dimensiones de la imagen
                    Dim dimensionesLogo As Single = 60
                    Dim tamañoLogo As New SizeF(dimensionesLogo, dimensionesLogo)
                    Dim areaLogo As New RectangleF(pos, tamañoLogo)
                    'Se dibuja la imagen en el reporte
                    graficos.DrawImage(logo, areaLogo)

                    'Se aumenta la posición en el eje Y a 30
                    pos.Y += 20

                    'Se dibuja el título
                    Dim posTitulo As New PointF(pag.Size.Width / 2, pos.Y)
                    graficos.DrawString("REPORTE DE VENTAS", fontTitulo, PdfBrushes.Black, posTitulo, fCentrado)

                    'Se aumenta la posición en el eje Y a 80
                    pos.Y += 50

                    'Se muestra el total de ventas
                    graficos.DrawString($"Total de ventas: {reporte.total_ventas.ToString("C", New CultureInfo("es-CR"))}", fontNormalNegrita, PdfBrushes.Black, pos, fIzquierda)

                    Dim posNumVentas As New PointF(pag.Size.Width - 210, pos.Y)
                    'Se muestra el numero de ventas
                    graficos.DrawString($"Numero de ventas: {reporte.num_ventas:#,##}", fontNormalNegrita, PdfBrushes.Black, posNumVentas, fDerecha)

                    pos.Y += 20
                    graficos.DrawString($"Ventas en tarjeta: {reporte.ventas_tarjeta.ToString("C", New CultureInfo("es-CR"))}", fontNormalNegrita, PdfBrushes.Black, pos, fIzquierda)

                    Dim posVentasEfectivo As New PointF(pag.Size.Width - 150, pos.Y)
                    'Se muestra el numero de ventas
                    graficos.DrawString($"Ventas en efectivo: {reporte.ventas_efectivo.ToString("C", New CultureInfo("es-CR"))}", fontNormalNegrita, PdfBrushes.Black, posVentasEfectivo, fDerecha)

                    If reporte.ProductoMasVendido IsNot Nothing Then
                        pos.Y += 20
                        graficos.DrawString($"Producto más vendido: {reporte.ProductoMasVendido.Nombre}", fontNormalNegrita, PdfBrushes.Black, pos, fIzquierda)

                        pos.Y += 20
                        graficos.DrawString($"Cantidad vendida: {reporte.ProductoMasVendido.Cantidad:#,##}", fontNormalNegrita, PdfBrushes.Black, pos, fIzquierda)

                        Dim posTotalVentasProd As New PointF(pag.Size.Width - 335, pos.Y)
                        graficos.DrawString($"Total vendido: {reporte.ProductoMasVendido.Total.ToString("C", New CultureInfo("es-CR"))}", fontNormalNegrita, PdfBrushes.Black, posTotalVentasProd, fIzquierda)
                    End If

                    pos.Y += 30
                    graficos.DrawString($"Lista de ventas", fontSubTitulo, PdfBrushes.Black, pos, fIzquierda)

                    pos.Y += 20

                    If listaFiltrada IsNot Nothing And listaFiltrada.Count > 0 Then
                        Log.Debug("Lista de ventas filtrada para PDF. Registros a dibujar: {Count}", listaFiltrada.Count)
                        Dim gridVentas As New PdfGrid With {
                        .DataSource = listaFiltrada
                    }
                        For Each celda As PdfGridCell In gridVentas.Headers(0).Cells
                            celda.Style.Font = fontNormalNegrita
                            celda.Style.StringFormat = fCentrado
                        Next
                        gridVentas.RepeatHeader = True

                        ' Se define un formato de paginación
                        Dim formatoDisposicion As New PdfGridLayoutFormat With {
                            .Layout = PdfLayoutType.Paginate,
                            .Break = PdfLayoutBreakType.FitPage
                        }
                        ' Se dibuja el grid, pasándole la posición inicial y el formato de paginación
                        ' El método Draw se encarga de crear las nuevas páginas automáticamente
                        gridVentas.Draw(pag, pos.X, pos.Y, formatoDisposicion)
                    End If

                    Log.Information("Guardando reporte PDF en la ruta: {RutaCompleta}", rutaCompleta)
                    reportePDF.Save(rutaCompleta)

                    Log.Information("Reporte PDF guardado con éxito. Se procede a preguntar para abrir.")
                    Dim resultado As DialogResult = MsgBox($"Archivo creado exitosamente en la ruta: {rutaCompleta}" & vbCrLf & "¿Desea abrir el archivo?", vbOKCancel, "¿Desea abrir el archivo?")
                    If resultado = DialogResult.OK Then
                        ' Abre el archivo PDF con el programa predeterminado del sistema
                        Log.Information("Abriendo el archivo PDF: {RutaCompleta}", rutaCompleta)
                        Process.Start(rutaCompleta)
                    End If
                Catch ex As Exception
                    Log.Error(ex, "Error al generar el reporte de ventas en PDF.")
                    MsgError("Error al generar el reporte de ventas en PDF: " & ex.Message)
                End Try
            End Using
        End Sub
    End Module

End Namespace
