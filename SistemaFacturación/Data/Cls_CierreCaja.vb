Imports System.Data.SQLite
Imports System.Globalization
Imports Serilog
Imports SistemaFacturaciónCommon.SistemaFacturacion.Modules

Namespace SistemaFacturacion.Data

    Public Class Cls_CierreCaja
        Friend Property ID As Integer
        Friend Property ID_Usuario As Integer
        Friend Property Cajero As String = ""
        Friend Property Fondo_inicial As Integer
        Public ReadOnly Property Formated_Fondo_inicial As String
            Get
                Return Fondo_inicial.ToString("C", CulturaCR) ' "C" es formato de moneda
            End Get
        End Property
        Friend Property IngresoEfectivo As Decimal = 0
        Public ReadOnly Property Formated_IngresoEfectivo As String
            Get
                Return IngresoEfectivo.ToString("C", CulturaCR) ' "C" es formato de moneda
            End Get
        End Property
        Friend Property EntradasEfectivo As Decimal = 0
        Public ReadOnly Property Formated_EntradasEfectivo As String
            Get
                Return EntradasEfectivo.ToString("C", CulturaCR) ' "C" es formato de moneda
            End Get
        End Property
        Friend Property SalidasEfectivo As Decimal = 0
        Public ReadOnly Property Formated_SalidasEfectivo As String
            Get
                Return SalidasEfectivo.ToString("C", CulturaCR) ' "C" es formato de moneda
            End Get
        End Property
        Friend Property IngresoTarjeta As Decimal = 0
        Public ReadOnly Property Formated_IngresoTarjeta As String
            Get
                Return IngresoTarjeta.ToString("C", CulturaCR) ' "C" es formato de moneda
            End Get
        End Property
        Friend Property Hora_apertura As Date
        Friend Property Hora_cierre As Date
        Public Property Diferencia As Decimal
        Public ReadOnly Property Formated_Diferencia As String
            Get
                Return Diferencia.ToString("C", CulturaCR) ' "C" es formato de moneda
            End Get
        End Property
        Friend Property DiferenciaPorcentaje As Decimal = 0
        Friend Property Efectivo_contado As Integer
        Public ReadOnly Property Formated_Efectivo_Contado As String
            Get
                Return Efectivo_contado.ToString("C", CulturaCR) ' "C" es formato de moneda
            End Get
        End Property
        Friend Property SaldoSiguienteTurno As Cls_SaldoCaja

        Private ReadOnly CulturaCR As New CultureInfo("es-CR")


#Region "getInfo"
        Private Async Function ObtenerInfoCierreActual() As Task(Of DataTable)
            Return Await Task.Run(Function()
                                      Dim T As New DataSet()
                                      Using db As New SQLiteConnection(GetConnectionString())
                                          db.Open()
                                          Dim consulta = "SELECT ac.ID, ac.ID_Usuario, u.usuario, ac.hora_apertura, ac.fondo_inicial" &
                                                            " FROM Arqueo_Caja ac LEFT JOIN usuario u ON u.ID = ac.ID_Usuario" &
                                                            " Order By ac.ID DESC LIMIT 1"
                                          Using cmd As New SQLiteCommand(consulta, db)
                                              Log.Information("Ejecutando consulta para obtener la información del cierre de caja actual: {Consulta}", consulta)
                                              Using da As New SQLiteDataAdapter(cmd)
                                                  da.Fill(T)
                                              End Using
                                          End Using
                                      End Using

                                      ' Verifica si la tabla 0 existe en el DataSet
                                      If T.Tables.Count <= 0 Then
                                          ' Si no existe, devuelve una nueva DataTable vacía
                                          Log.Warning("No se encontraron tablas en el DataSet al obtener la información del cierre de caja actual.")
                                          Return New DataTable()
                                      End If

                                      ' Verifica si la tabla 0 tiene filas
                                      If T.Tables(0).Rows.Count = 0 Then
                                          ' Si no hay filas, devuelve una nueva DataTable vacía
                                          Log.Warning("No se encontraron registros al obtener la información del cierre de caja actual.")
                                          Return New DataTable()
                                      End If

                                      ' Si hay filas, obtiene la fecha de la última fila
                                      If Not Date.TryParse(T.Tables(0).Rows(0).Item("hora_apertura").ToString(), Nothing) Then
                                          MsgError("Error al convertir la fecha de la última apertura de caja.")
                                          Return New DataTable()
                                      End If

                                      ' Si existe, devuelve la tabla con los datos
                                      Log.Information("Información del cierre de caja actual obtenida correctamente.")
                                      Return T.Tables(0)
                                  End Function)
        End Function

        Friend Async Function ObtenerTotalMovimientosCaja() As Task
            Await Task.Run(Sub()
                               Dim sql As String = "SELECT SUM(monto) AS total, ID_Tipo_Movimiento FROM Movimientos_Caja WHERE ID_Arqueo = @idArqueo GROUP BY ID_Tipo_Movimiento"
                               Dim paramList As New List(Of SQLiteParameter) From {
                                          New SQLiteParameter("@idArqueo", ID)
                                      }
                               CargarTablaParam(T1, sql, paramList)

                               EntradasEfectivo = 0
                               SalidasEfectivo = 0

                               ' Verifica si la tabla existe o si esta tiene filas
                               If T1.Tables.Count <= 0 OrElse T1.Tables(0).Rows.Count = 0 OrElse IsDBNull(T1.Tables(0).Rows(0).Item("Total")) Then
                                   Log.Warning("No se encontraron movimientos de caja para el arqueo con ID {ArqueoID}.", ID)
                                   ' Si no hay filas, devuelve una nueva DataTable vacía
                                   Exit Sub
                               End If

                               Log.Information("Totales de movimientos de caja obtenidos correctamente para el arqueo con ID {ArqueoID}.", ID)

                               For Each row As DataRow In T1.Tables(0).Rows
                                   If IsDBNull(row.Item("ID_Tipo_Movimiento")) Then
                                       Continue For
                                   End If
                                   Select Case row.Item("ID_Tipo_Movimiento")
                                       Case 1 'Entrada
                                           EntradasEfectivo = row.Item("total")
                                       Case 2 'Salida
                                           SalidasEfectivo = row.Item("total")
                                   End Select
                               Next
                               Log.Information("Totales - Entradas: {Entradas}, Salidas: {Salidas}", EntradasEfectivo, SalidasEfectivo)
                           End Sub)
        End Function

        Public Async Function ObtenerInfoInicial() As Task
            'Se obtiene la información del cierre anterior
            Dim infoCierreActual As DataTable = Await ObtenerInfoCierreActual()
            Log.Information("Obteniendo información inicial para el cierre de caja.")
            ' Manejo de caso sin datos
            If infoCierreActual.Rows.Count = 0 Then
                MsgError("No se encontró un arqueo de caja abierto. Por favor, realice una apertura de caja primero.")
                Return
            End If

            ' Se corrige la conversión de la fecha
            Dim fechaInicio As Date = Convert.ToDateTime(infoCierreActual.Rows(0).Item("hora_apertura"))
            Dim fechaFin As Date = DateTime.Now

            Log.Information("Fechas de apertura y cierre obtenidas: Apertura={Apertura}, Cierre={Cierre}", fechaInicio, fechaFin)

            'Se obtiene la información relacionada con las ventas en la 
            Dim listaVentas As List(Of Cls_DatosFactura) = Await ObtenerListaVentas(fechaInicio, fechaFin, T, True)
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
            Log.Information("Totales de ventas obtenidos: Efectivo={Efectivo}, Tarjeta={Tarjeta}", ventasEfectivo, ventasTarjeta)

            'Obtener lista de abonos a cuentas por cobrar realizados
            Dim pagosCxC As New Cls_CxCPagos
            Dim tbl As DataTable = pagosCxC.GetListaTotalesAbonosByDate(fechaInicio, fechaFin)
            Log.Information("Totales de abonos a cuentas por cobrar obtenidos.")
            If tbl IsNot Nothing AndAlso tbl.Rows.Count > 0 Then
                If Not IsDBNull(tbl.Rows(0).Item("total_efectivo")) Then
                    ventasEfectivo += tbl.Rows(0).Item("total_efectivo")
                End If
                If Not IsDBNull(tbl.Rows(0).Item("total_tarjeta")) Then
                    ventasTarjeta += tbl.Rows(0).Item("total_tarjeta")
                End If
            End If
            Log.Information("Totales de ventas actualizados con abonos a CxC: Efectivo={Efectivo}, Tarjeta={Tarjeta}", ventasEfectivo, ventasTarjeta)

            'Se asignan los datos a la clase que se va a devolver
            ID = infoCierreActual.Rows(0).Item("ID")
            ID_Usuario = infoCierreActual.Rows(0).Item("ID_Usuario")
            Cajero = infoCierreActual.Rows(0).Item("usuario")
            Fondo_inicial = infoCierreActual.Rows(0).Item("fondo_inicial")
            Hora_apertura = fechaInicio
            Hora_cierre = fechaFin
            IngresoEfectivo = ventasEfectivo
            IngresoTarjeta = ventasTarjeta
            SaldoSiguienteTurno = New Cls_SaldoCaja()
            Efectivo_contado = 0
            Diferencia = 0
            DiferenciaPorcentaje = 0
            Log.Information("Datos iniciales del cierre de caja asignados correctamente.")

            'Se obtienen los movimientos de caja asociados a este arqueo
            Await ObtenerTotalMovimientosCaja()
        End Function

        Friend Async Function ObtenerListaMovimientos(filter As String) As Task(Of DataTable)
            Return Await Task.Run(Function()
                                      SQL = "SELECT mc.monto As 'Monto', tm.ID, tm.nombre As 'Tipo movimiento', cc.concepto As 'Concepto', mc.referencia As 'Referencia', " &
                                            "mc.fecha_hora As 'Fecha' FROM Movimientos_Caja mc LEFT JOIN Tipos_Movimiento tm ON mc.ID_tipo_movimiento = tm.id " &
                                            "LEFT JOIN Conceptos_Caja cc ON cc.ID = mc.ID_concepto WHERE ID_ARQUEO = @ID"
                                      If filter = "Entrada" Then
                                          SQL += " AND tm.ID = 1"
                                      ElseIf filter = "Salida" Then
                                          SQL += " AND tm.ID = 2"
                                      End If

                                      Dim paramList As New List(Of SQLiteParameter) From {
                                          {New SQLiteParameter("@ID", ID)}
                                      }
                                      Log.Information("Ejecutando consulta para obtener la lista de movimientos de caja: {CONSULTA}", SQL)
                                      CargarTablaParam(T, SQL, paramList)

                                      For Each row As DataRow In T.Tables(0).Rows
                                          Dim idTipo As Integer = Convert.ToInt32(row.Item("ID"))
                                          If idTipo = 1 Then ' Asumiendo 1 = Entrada
                                              EntradasEfectivo = row.Item("monto")
                                          ElseIf idTipo = 2 Then ' Asumiendo 2 = Salida
                                              SalidasEfectivo = row.Item("monto")
                                          End If
                                      Next

                                      Log.Information("Lista de movimientos de caja obtenida correctamente. Total registros: {Count}", T.Tables(0).Rows.Count)

                                      Return T.Tables(0)
                                  End Function)
        End Function
#End Region

#Region "Manejo de datos y CRUD"
        ' Guarda el cierre de caja en la base de datos
        Friend Async Function GuardarCierre() As Task(Of Boolean)
            Return Await Task.Run(Function()
                                      Try
                                          Dim consulta = "UPDATE Arqueo_Caja SET hora_cierre = @fechaFin, efectivo_contado = @efectivoContado, " &
                                                                " diferencia = @diferencia WHERE ID = @ID"
                                          Log.Information("Ejecutando consulta para guardar el cierre de caja: {Consulta}", consulta)
                                          Dim exito = EJECUTAR_PARAMETROS(consulta, New Dictionary(Of String, Object) From {
                                              {"fechaFin", Hora_cierre},
                                              {"efectivoContado", SaldoSiguienteTurno.Total},
                                              {"diferencia", Diferencia},
                                              {"ID", ID}
                                          })

                                          If Not exito Then
                                              Throw New Exception($"Fallo al actualizar el cierre de caja en la base de datos para el arqueo con ID {ID}.")
                                          End If

                                          Log.Information("Cierre de caja guardado correctamente para el arqueo con ID {ArqueoID}.", ID)
                                          Return True
                                      Catch ex As Exception
                                          Log.Error("Error al guardar el cierre de caja: {ErrorMessage}", ex.Message)
                                          Return False
                                      End Try
                                  End Function)
        End Function

        Friend Function IngresarApertura() As Boolean
            'Hacer el ingreso a la base de datos de la información
            'Se ingresa el nuevo ID, ID_Usuario, fondo_inicial, hora_apertura
            Using db As New SQLiteConnection(GetConnectionString())
                db.Open()
                Dim transaction = db.BeginTransaction()
                Dim insertSQL As String = "INSERT INTO Arqueo_Caja (ID, ID_Usuario, fondo_inicial, hora_apertura) VALUES (@id, @idUsu, @fondo, @hora)"
                Dim param As New Dictionary(Of String, Object) From {
                    {"id", OBTENERPK("Arqueo_Caja", "ID")},
                    {"idUsu", ID_Usuario},
                    {"fondo", Fondo_inicial},
                    {"hora", DateTime.Now}
                }
                Try
                    Log.Information("Ejecutando inserción para apertura de caja: {Consulta}", insertSQL)
                    Using cmd As New SQLiteCommand(insertSQL, db, transaction)
                        For Each p In param
                            cmd.Parameters.AddWithValue("@" & p.Key, p.Value)
                        Next
                        cmd.ExecuteNonQuery()
                    End Using
                    Log.Information("Apertura de caja registrada correctamente con ID {ArqueoID}.", param("id"))
                    transaction.Commit()
                Catch ex As Exception
                    transaction.Rollback()
                    MsgError("Error interno al registrar la apertura de caja. Por favor, intente nuevamente. Ejecutando roolback. Error: " & ex.Message)
                    Return False
                Finally
                    If db.State = ConnectionState.Open Then
                        Log.Information("Cerrando conexión a la base de datos.")
                        db.Close()
                    End If
                End Try
            End Using
            Return True
        End Function
#End Region

#Region "General"
        Friend Async Sub LimpiarDatos()
            ' Se limpia la información del cierre y se recargan sis datos iniciales
            ID = 0
            ID_Usuario = 0
            Cajero = ""
            fondo_inicial = 0
            ingresoEfectivo = 0
            ingresoTarjeta = 0
            hora_apertura = Date.MinValue
            hora_cierre = Date.MinValue
            saldoSiguienteTurno = New Cls_SaldoCaja()
            Diferencia = 0
            diferenciaPorcentaje = 0
            EntradasEfectivo = 0
            SalidasEfectivo = 0
            Efectivo_contado = 0
            Log.Information("Datos del cierre de caja limpiados.")

            'Se recarga la información inicial
            Await obtenerInfoInicial()
        End Sub
#End Region

#Region "Calculos"

        Friend Function CargarTotalEsperadoYDiferencia() As String
            'Se obtienen los datos de saldo inicial, ventas en efectivo
            Dim saldoInicial As Decimal = fondo_inicial
            Dim ventaEfectivo As Decimal = ingresoEfectivo
            Dim Salidas As Decimal = SalidasEfectivo
            Dim Entradas As Decimal = EntradasEfectivo

            'Saldo esperado = saldoInicial + Ventas - salidas
            Dim saldoEsperado = saldoInicial + ventaEfectivo + Entradas - Salidas
            Log.Debug("Cálculo de saldo esperado: Inicial={Inicial}, VentasEfectivo={VentasEfectivo}, Entradas={Entradas}, Salidas={Salidas}, SaldoEsperado={SaldoEsperado}",
                            saldoInicial, ventaEfectivo, Entradas, Salidas, saldoEsperado)

            'Se obtiene el valor del saldo real contado de la caja
            Dim saldoReal As Decimal = saldoSiguienteTurno.Total
            'Diferencia absoluta = saldoEsperado - saldoReal
            Diferencia = saldoReal - saldoEsperado
            'Diferencia porcentual = saldoReal * 100 / saldoEsperado
            If saldoEsperado <> 0 Then
                diferenciaPorcentaje = (diferencia / Math.Abs(saldoEsperado)) * 100
            Else
                diferenciaPorcentaje = 0
            End If
            Log.Debug("Cálculo de diferencias: SaldoReal={SaldoReal}, Diferencia={Diferencia}, DiferenciaPorcentaje={DiferenciaPorcentaje}",
                            saldoReal, Diferencia, DiferenciaPorcentaje)

            'Se devuelve el saldo esperado formateado
            Return saldoEsperado.ToString("C", New CultureInfo("es-CR"))
        End Function

        Friend Function CargarTotalEsperadoYDiferenciaDetalles() As String
            'Se obtienen los datos de saldo inicial, ventas en efectivo
            Dim saldoInicial As Decimal = Fondo_inicial
            Dim ventaEfectivo As Decimal = IngresoEfectivo
            Dim Salidas As Decimal = SalidasEfectivo
            Dim Entradas As Decimal = EntradasEfectivo

            'Saldo esperado = saldoInicial + Ventas - salidas
            Dim saldoEsperado = saldoInicial + ventaEfectivo + Entradas - Salidas
            Log.Debug("Cálculo de saldo esperado para detalles: Inicial={Inicial}, VentasEfectivo={VentasEfectivo}, Entradas={Entradas}, Salidas={Salidas}, SaldoEsperado={SaldoEsperado}",
                            saldoInicial, ventaEfectivo, Entradas, Salidas, saldoEsperado)

            'Se obtiene el valor del saldo real contado de la caja
            Dim saldoReal As Decimal = Efectivo_contado
            'Diferencia absoluta = saldoEsperado - saldoReal
            Diferencia = saldoReal - saldoEsperado
            'Diferencia porcentual = saldoReal * 100 / saldoEsperado
            If saldoEsperado <> 0 Then
                DiferenciaPorcentaje = (Diferencia / Math.Abs(saldoEsperado)) * 100
            Else
                DiferenciaPorcentaje = 0
            End If
            Log.Debug("Cálculo de diferencias para detalles: SaldoReal={SaldoReal}, Diferencia={Diferencia}, DiferenciaPorcentaje={DiferenciaPorcentaje}",
                            saldoReal, Diferencia, DiferenciaPorcentaje)

            'Se devuelve el saldo esperado formateado
            Return saldoEsperado.ToString("C", New CultureInfo("es-CR"))
        End Function
#End Region
    End Class
End Namespace
