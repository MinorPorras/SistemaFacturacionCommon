Imports System.Configuration
Imports System.Data.SQLite

Module Md_Reportes
    Friend Async Function GenerarReporte(desde As Date, hasta As Date, t As DataSet) As Task(Of Cls_ReporteVentas)
        Try
            Dim stringConexion As String = ConfigurationManager.ConnectionStrings("conexionString").ConnectionString

            Dim listaVentas As List(Of Cls_Venta) = Await ObtenerListaVentas(stringConexion, desde, hasta, t)

            Dim totalVentas As Decimal = 0D
            Dim ventasEfectivo As Decimal = 0D
            Dim ventasTarjeta As Decimal = 0D

            For Each venta As Cls_Venta In listaVentas
                totalVentas += venta.Total
                If venta.Tipo_venta = "Efectivo" Then
                    ventasEfectivo += venta.Total
                ElseIf venta.Tipo_venta = "Mixto" Then
                    ventasEfectivo += venta.Efectivo
                    ventasTarjeta += venta.Tarjeta
                Else
                    ventasTarjeta += venta.Total
                End If
            Next

            Dim numVentas As Integer = listaVentas.Count

            ' Se obtiene el producto más vendido dentro del rango especificado
            Dim producto = Await getProductosMasVendido(stringConexion, 1, desde, hasta, 1)

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


    Private Async Function ObtenerListaVentas(stringConexion As String, desde As Date, hasta As Date, t As DataSet) As Task(Of List(Of Cls_Venta))
        ' ... El código interno de este método no necesita cambios ya que no realiza operaciones I/O asíncronas
        ' El uso de un DataAdapter es síncrono por naturaleza, pero puedes envolverlo en un Task.Run
        ' para que se ejecute en un hilo secundario y no bloquee el hilo principal de la UI.
        Return Await Task.Run(Function()
                                  Using db As New SQLiteConnection(stringConexion)
                                      ' ... Resto del código original
                                      Try
                                          db.Open()
                                          Dim consulta As String = "SELECT f.num_factura As '# Fact', " &
                                                                  "f.fecha_emision As 'Fecha de emisión', " &
                                                                  "c.nombre As 'Nombre', f.efectivo_cliente as 'Efectivo', " &
                                                                  "f.tarjeta_cliente as 'Tarjeta', f.total As 'Total', " &
                                                                  "f.tipo_venta As 'tipo' " &
                                                                  "FROM factura f " &
                                                                  "INNER JOIN clientes c ON c.ID = f.ID_Cliente " &
                                                                  "WHERE fecha_emision >= @fechaInicio AND fecha_emision < @fechaFin AND cobrada != 0;"
                                          Using cmd As New SQLiteCommand(consulta, db)
                                              cmd.Parameters.Add(New SQLiteParameter("@fechaInicio", desde.ToString("yyyy-MM-dd")))
                                              cmd.Parameters.Add(New SQLiteParameter("@fechaFin", hasta.AddDays(1).ToString("yyyy-MM-dd")))

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

                                  Dim listaVentas As New List(Of Cls_Venta)
                                  If t.Tables.Count > 0 Then
                                      For Each row As DataRow In t.Tables(0).Rows
                                          Dim numFactura As String = row.Item("# Fact").ToString()
                                          Dim fecha As Date = Convert.ToDateTime(row.Item("Fecha de emisión"))
                                          Dim cliente As String = row.Item("Nombre").ToString()
                                          Dim efectivo As Decimal = Convert.ToDecimal(row.Item("Efectivo"))
                                          Dim tarjeta As Decimal = Convert.ToDecimal(row.Item("Tarjeta"))
                                          Dim total As Decimal = Convert.ToDecimal(row.Item("Total"))

                                          Dim tipoVentaNum As Integer = Convert.ToInt32(row.Item("tipo")) ' <--- OJO: OBTIENES EL NÚMERO
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

                                          Dim venta As New Cls_Venta(numFactura, fecha, cliente, total, tipoVenta, efectivo, tarjeta)
                                          listaVentas.Add(venta)
                                      Next
                                  End If
                                  Return listaVentas
                              End Function)
    End Function

    Friend Async Function getProductosMasVendido(stringConexion As String, LIMIT As Integer, desde As Date, hasta As Date, orderBy As Integer) As Task(Of List(Of Cls_ProductosMasVendidos))
        Return Await Task.Run(Function()
                                  Dim listProductosMasVendidos As New List(Of Cls_ProductosMasVendidos)
                                  Try
                                      Using db As New SQLiteConnection(stringConexion)
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
                                              ' Se establecen los parámetros de fecha correctamente para cubrir el día completo.
                                              ' Esto asegura que si 'desde' y 'hasta' son el mismo día, se cubra desde las 00:00:00 del 'desde' hasta las 23:59:59 del 'hasta'.
                                              Dim fechaFin As Date
                                              If desde.Date = hasta.Date Then
                                                  ' Si es el mismo día, se busca desde el inicio del día hasta el final
                                                  fechaFin = hasta.Date.AddDays(1)
                                              Else
                                                  fechaFin = hasta.AddDays(1).Date
                                              End If

                                              cmd.Parameters.Add(New SQLiteParameter("@fecha_inicio", desde.Date.ToString("yyyy-MM-dd HH:mm:ss")))
                                              cmd.Parameters.Add(New SQLiteParameter("@fecha_fin", fechaFin.ToString("yyyy-MM-dd HH:mm:ss")))
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
End Module
