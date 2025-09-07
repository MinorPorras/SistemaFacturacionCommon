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

#Region "Cierre de caja"

    Public Async Function obtenerCierreCajaInicial(conn As String) As Task(Of Cls_CierreCaja)
        'Se obtiene la información del cierre anterior
        Dim infoCierreAnterior As DataTable = Await obtenerInfoCierreAnterior(conn)

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
        Dim listaVentas As List(Of Cls_Venta) = Await ObtenerListaVentas(conn, fechaInicio, fechaFin, T)
        Dim ventasEfectivo As Decimal = 0
        Dim ventasTarjeta As Decimal = 0
        For Each venta As Cls_Venta In listaVentas
            If venta.Tipo_venta = "Efectivo" Then
                ventasEfectivo += venta.Total
            ElseIf venta.Tipo_venta = "Mixto" Then
                ventasEfectivo += venta.Efectivo
                ventasTarjeta += venta.Tarjeta
            Else
                ventasTarjeta += venta.Total
            End If
        Next
        Dim infoInicialCierre As New Cls_CierreCaja(fechaInicio, fechaFin, saldoTurnoAnterior, ventasEfectivo, ventasTarjeta)

        Return infoInicialCierre
    End Function

    Private Async Function obtenerInfoCierreAnterior(conn As String) As Task(Of DataTable)
        Return Await Task.Run(Function()
                                  Dim T As New DataSet()
                                  Using db As New SQLiteConnection(conn)
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
