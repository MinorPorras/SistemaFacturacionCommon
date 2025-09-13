Imports System.Configuration
Imports System.Data.SQLite
Imports Syncfusion.Pdf
Imports Syncfusion.Pdf.Graphics

Module Md_Reportes
    Friend Async Function GenerarReporte(desde As Date, hasta As Date, t As DataSet) As Task(Of Cls_ReporteVentas)
        Try
            Dim listaVentas As List(Of Cls_DatosFactura) = Await ObtenerListaVentas(desde, hasta, t)

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

            Dim numVentas As Integer = listaVentas.Count

            ' Se obtiene el producto más vendido dentro del rango especificado
            Dim producto = Await getProductosMasVendido(1, desde, hasta, 1)

            Dim productoMasVendido As Cls_ProductosMasVendidos = Nothing
            If producto IsNot Nothing AndAlso producto.Count > 0 Then
                productoMasVendido = producto(0)
            End If

            Dim reporte As New Cls_ReporteVentas(listaVentas, totalVentas, numVentas, ventasEfectivo, ventasTarjeta, productoMasVendido)

            Return reporte
        Catch ex As Exception
            ' Devuelve un objeto vacío en caso de error
            Return New Cls_ReporteVentas()
        End Try
    End Function


    Private Async Function ObtenerListaVentas(desde As Date, hasta As Date, t As DataSet) As Task(Of List(Of Cls_DatosFactura))
        Return Await Task.Run(Function()
                                  Using db As New SQLiteConnection(GetConnectionString())
                                      Try
                                          db.Open()
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
                                                                        AND f.fecha_emision <  @fechaFin
                                                                        AND f.cobrada != 0;"
                                          Using cmd As New SQLiteCommand(consulta, db)
                                              cmd.Parameters.AddWithValue("@fechaInicio", desde)
                                              cmd.Parameters.AddWithValue("@fechaFin", hasta)

                                              Using da As New SQLiteDataAdapter(cmd)
                                                  If t.Tables.Count > 0 Then
                                                      t.Tables(0).Clear()
                                                  End If
                                                  da.Fill(t)
                                              End Using
                                          End Using
                                      Catch ex As Exception
                                          Throw ex
                                      End Try
                                  End Using

                                  Dim listaVentas As New List(Of Cls_DatosFactura)
                                  If t.Tables.Count > 0 Then
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
                                  End If
                                  Return listaVentas
                              End Function)
    End Function

    Friend Async Function getProductosMasVendido(LIMIT As Integer, desde As Date, hasta As Date, orderBy As Integer) As Task(Of List(Of Cls_ProductosMasVendidos))
        Return Await Task.Run(Function()
                                  Dim listProductosMasVendidos As New List(Of Cls_ProductosMasVendidos)
                                  Try
                                      Using db As New SQLiteConnection(GetConnectionString())
                                          db.Open()
                                          Dim orderByProperty As String
                                          If orderBy = 1 Then
                                              orderByProperty = "unidadesVendidas"
                                          ElseIf orderBy = 2 Then
                                              orderByProperty = "total"
                                          End If
                                          Dim consulta As String = "SELECT COUNT(fp.ID_Producto) AS unidadesVendidas, p.nombre, SUM(fp.precio_venta * fp.cant) As total " &
                                                               "FROM factura f " &
                                                               "INNER JOIN factura_producto fp ON f.ID = fp.ID_Factura " &
                                                               "INNER JOIN producto p ON fp.ID_Producto = p.ID " &
                                                               "WHERE f.fecha_emision >= @fecha_inicio AND f.fecha_emision < @fecha_fin " &
                                                               "GROUP BY p.nombre " &
                                                               $"ORDER BY {orderByProperty} DESC " &
                                                               "LIMIT @limite;"

                                          Using cmd As New SQLiteCommand(consulta, db)

                                              cmd.Parameters.Add(New SQLiteParameter("@fecha_inicio", desde.ToString("yyyy-MM-dd HH:mm:ss")))
                                              cmd.Parameters.Add(New SQLiteParameter("@fecha_fin", hasta.ToString("yyyy-MM-dd HH:mm:ss")))
                                              cmd.Parameters.Add(New SQLiteParameter("@limite", LIMIT))

                                              Using da As New SQLiteDataAdapter(cmd)
                                                  Dim T As New DataSet()
                                                  da.Fill(T)

                                                  If T.Tables.Count > 0 AndAlso T.Tables(0).Rows.Count > 0 Then
                                                      For Each row As DataRow In T.Tables(0).Rows
                                                          Dim prod As New Cls_ProductosMasVendidos(row.Item("unidadesVendidas"), row.Item("nombre"), row.Item("total"))
                                                          listProductosMasVendidos.Add(prod)
                                                      Next
                                                  End If
                                              End Using
                                          End Using
                                      End Using
                                  Catch ex As Exception
                                      Throw ex
                                  End Try
                                  Return listProductosMasVendidos
                              End Function)
    End Function

    Private Async Sub Crear_PDF_ReporteVentas(desde As Date, hasta As Date)
        'Se obtiene la información relevante de la base de datos
        Dim reporte As Cls_ReporteVentas = Await GenerarReporte(desde, hasta, T1)

        ' 1. Define diferentes estilos de fuente
        Dim fontTitulo As New PdfStandardFont(PdfFontFamily.Courier, 18, PdfFontStyle.Bold)
        Dim fontNormal As New PdfStandardFont(PdfFontFamily.Courier, 10)
        Dim fontNormalNegrita As New PdfStandardFont(PdfFontFamily.Courier, 10, PdfFontStyle.Bold)

        '2. Se define el punto de incio de nuestros elementos en el documento
        Dim yPoint As Single = 20

        ' Se crea un elemento PdfTextElement para los elementos que necesitamos mostrar como texto
        'Titulo
        Dim tituloElement As New PdfTextElement("REPORTE DE VENTAS", fontTitulo, PdfBrushes.Black)
        'Fecha de emisión
        Dim FechaEmisionElement As New PdfTextElement($"Fecha de emisión {desde.Date.ToLongDateString()} - {hasta.Date.ToLongDateString()}")

        Using reportePDF As New PdfDocument()
            ' Se pinta el título del reporte al documento

        End Using
    End Sub

#Region "Cierre de caja"

    Public Async Function obtenerCierreCajaInicial() As Task(Of Cls_CierreCaja)
        'Se obtiene la información del cierre anterior
        Dim infoCierreAnterior As DataTable = Await obtenerInfoCierreAnterior()

        'Se establecen los datos que se usan en caso de que no haya ningún cierre
        Dim fechaHoy As Date = Date.Today
        Dim fechaInicio As Date = New Date(fechaHoy.Year, fechaHoy.Month, fechaHoy.Day, 5, 0, 0)
        Dim fechaFin As Date = DateTime.Now
        Dim saldoTurnoAnterior As Integer = 0



        If infoCierreAnterior.Rows.Count > 0 Then
            'En caso de que ya exista un cierre anterior se obtiene la fecha de finalización de este
            fechaInicio = infoCierreAnterior.Rows(0).Item("HoraFin")

            'Se obtiene el saldo en caja del cierre anterior
            saldoTurnoAnterior = infoCierreAnterior.Rows(0).Item("DineroSiguente")

        End If

        'Se obtiene la información relacionada con las ventas en la 
        Dim listaVentas As List(Of Cls_DatosFactura) = Await ObtenerListaVentas(fechaInicio, fechaFin, T)
        Dim ventasEfectivo As Decimal = 0
        Dim ventasTarjeta As Decimal = 0
        For Each venta As Cls_DatosFactura In listaVentas
            If venta.TipoPago = "Efectivo" Then
                ventasEfectivo += venta.TotalCaja
            ElseIf venta.TipoPago = "Mixto" Then
                ventasEfectivo += venta.Efectivo
                ventasTarjeta += venta.Tarjeta
            Else
                ventasTarjeta += venta.TotalCaja
            End If
        Next
        Dim infoInicialCierre As New Cls_CierreCaja(fechaInicio, fechaFin, saldoTurnoAnterior, ventasEfectivo, ventasTarjeta)

        Return infoInicialCierre
    End Function

    Private Async Function obtenerInfoCierreAnterior() As Task(Of DataTable)
        Return Await Task.Run(Function()
                                  Dim T As New DataSet()
                                  Using db As New SQLiteConnection(GetConnectionString())
                                      db.Open()
                                      Dim consulta = "SELECT cc.Fecha_Hora_Fin As horaFin, cc.Saldo_Siguiente_Turno As dineroSiguente
                            FROM CierreCaja cc
                            ORDER BY cc.ID_Cierre DESC
                            LIMIT 1;"
                                      Using cmd As New SQLiteCommand(consulta, db)
                                          Using da As New SQLiteDataAdapter(cmd)
                                              da.Fill(T)
                                          End Using
                                      End Using
                                  End Using

                                  ' Verifica si la tabla 0 existe en el DataSet
                                  If T.Tables.Count > 0 Then
                                      ' Si existe, devuelve la tabla con los datos
                                      Return T.Tables(0)
                                  Else
                                      ' Si no existe, devuelve una nueva DataTable vacía
                                      Return New DataTable()
                                  End If
                              End Function)
    End Function

    Friend Async Function guardarNuevoCierre(conn As String, cierreInfo As Cls_CierreCaja) As Task(Of Boolean)
        Return Await Task.Run(Function()
                                  Try
                                      Using db As New SQLiteConnection(conn)
                                          db.Open()
                                          Dim consulta = "INSERT INTO CierreCaja (Fecha_Hora_Inicio, Fecha_Hora_Fin, ID_Usuario, Saldo_Inicial, 
                                 Ingreso_Efectivo, Ingreso_Tarjeta, Salidas_Efectivo, Efectivo_Contado, Saldo_Siguiente_Turno, Comentarios)
                                 VALUES (@fecha_inicio, @fecha_fin, @idUsuario, @saldoInicial, @IngresoEfectivo, @ingresoTarjeta, 
                                 @salidasEfectivo, @efectivoContado, @saldoSiguiente, @comentarios)"

                                          Using cmd As New SQLiteCommand(consulta, db)
                                              ' Se utiliza AddWithValue para que la librería maneje el tipo de dato
                                              ' y se respeta el orden de los parámetros para evitar errores de mapeo
                                              cmd.Parameters.AddWithValue("@fecha_inicio", cierreInfo.fecha_inicio)
                                              cmd.Parameters.AddWithValue("@fecha_fin", cierreInfo.fecha_fin)
                                              cmd.Parameters.AddWithValue("@idUsuario", idUsuActual)
                                              cmd.Parameters.AddWithValue("@saldoInicial", cierreInfo.saldo_inicial)
                                              cmd.Parameters.AddWithValue("@IngresoEfectivo", cierreInfo.ingresoEfectivo)
                                              cmd.Parameters.AddWithValue("@ingresoTarjeta", cierreInfo.ingresoTarjeta)
                                              cmd.Parameters.AddWithValue("@salidasEfectivo", cierreInfo.salidasEfectivo)
                                              cmd.Parameters.AddWithValue("@efectivoContado", cierreInfo.efectivoContado)
                                              cmd.Parameters.AddWithValue("@saldoSiguiente", cierreInfo.saldoSiguiente)
                                              cmd.Parameters.AddWithValue("@comentarios", cierreInfo.comentarios)

                                              If cmd.ExecuteNonQuery > 0 Then
                                                  Return True
                                              Else
                                                  Return False
                                              End If
                                          End Using
                                      End Using
                                  Catch ex As Exception
                                      Console.WriteLine("Error al guardar el cierre de caja: " & ex.Message)
                                      Return False
                                  End Try
                              End Function)
    End Function
#End Region
End Module
