Imports System.Data.SQLite
Imports System.Globalization
Imports Guna.UI2.WinForms
Imports SistemaFacturaciónCommon.SistemaFacturacion.Data
Imports SistemaFacturaciónCommon.SistemaFacturacion.Modules

Namespace SistemaFacturacion.Data

    Public Class Cls_CierreCaja
        Friend Property ID As Integer
        Friend Property ID_Usuario As Integer
        Friend Property Cajero As String = ""
        Friend Property fondo_inicial As Integer
        Friend Property ingresoEfectivo As Decimal = 0
        Friend Property EntradasEfectivo As Decimal = 0
        Friend Property SalidasEfectivo As Decimal = 0
        Friend Property ingresoTarjeta As Decimal = 0
        Friend Property hora_apertura As Date
        Friend Property hora_cierre As Date
        Friend Property efectivo_contado As Integer = 0
        Friend Property diferencia As Decimal = 0
        Friend Property diferenciaPorcentaje As Decimal = 0


        Private Async Function ObtenerInfoCierreActual() As Task(Of DataTable)
            Return Await Task.Run(Function()
                                      Dim T As New DataSet()
                                      Using db As New SQLiteConnection(GetConnectionString())
                                          db.Open()
                                          Dim consulta = "SELECT ac.ID, ac.ID_Usuario, u.usuario, ac.hora_apertura, ac.fondo_inicial" &
                                                            " FROM Arqueo_Caja ac LEFT JOIN usuario u ON u.ID = ac.ID_Usuario" &
                                                            " Order By ac.ID DESC LIMIT 1"
                                          Using cmd As New SQLiteCommand(consulta, db)
                                              Using da As New SQLiteDataAdapter(cmd)
                                                  da.Fill(T)
                                              End Using
                                          End Using
                                      End Using

                                      ' Verifica si la tabla 0 existe en el DataSet
                                      If T.Tables.Count <= 0 Then
                                          ' Si no existe, devuelve una nueva DataTable vacía
                                          Return New DataTable()
                                      End If

                                      ' Verifica si la tabla 0 tiene filas
                                      If T.Tables(0).Rows.Count = 0 Then
                                          ' Si no hay filas, devuelve una nueva DataTable vacía
                                          Return New DataTable()
                                      End If

                                      ' Si hay filas, obtiene la fecha de la última fila
                                      If Not Date.TryParse(T.Tables(0).Rows(0).Item("hora_apertura").ToString(), Nothing) Then
                                          msgError("Error al convertir la fecha de la última apertura de caja.")
                                          Return New DataTable()
                                      End If

                                      ' Si existe, devuelve la tabla con los datos
                                      Return T.Tables(0)
                                  End Function)
        End Function

        Friend Async Sub ObtenerTotalMovimientosCaja()
            Await Task.Run(Sub()
                               Dim sql As String = "SELECT SUM(monto) AS total, ID_Tipo_Movimiento FROM Movimientos_Caja WHERE ID_Arqueo = @idArqueo GROUP BY ID_Tipo_Movimiento"
                               Dim paramList As New List(Of SQLiteParameter) From {
                                          New SQLiteParameter("@idArqueo", ID)
                                      }
                               CargarTablaParam(T1, sql, paramList)

                               ' Verifica si la tabla existe o si esta tiene filas
                               If T1.Tables.Count <= 0 OrElse T1.Tables(0).Rows.Count = 0 OrElse IsDBNull(T1.Tables(0).Rows(0).Item("Total")) Then
                                   ' Si no hay filas, devuelve una nueva DataTable vacía
                                   EntradasEfectivo = 0
                                   SalidasEfectivo = 0
                                   Exit Sub
                               End If

                               EntradasEfectivo = T1.Tables(0).Rows(0).Item("Total")
                               SalidasEfectivo = T1.Tables(0).Rows(1).Item("Total")

                           End Sub)
        End Sub

        Public Async Function obtenerInfoInicial() As Task
            'Se obtiene la información del cierre anterior
            Dim infoCierreActual As DataTable = Await ObtenerInfoCierreActual()

            ' Manejo de caso sin datos
            If infoCierreActual.Rows.Count = 0 Then
                Return
            End If

            ' Se corrige la conversión de la fecha
            Dim fechaInicio As Date = Convert.ToDateTime(infoCierreActual.Rows(0).Item("hora_apertura"))
            Dim fechaFin As Date = DateTime.Now


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


            'Se asignan los datos a la clase que se va a devolver
            ID = infoCierreActual.Rows(0).Item("ID")
            ID_Usuario = infoCierreActual.Rows(0).Item("ID_Usuario")
            Cajero = infoCierreActual.Rows(0).Item("usuario")
            fondo_inicial = infoCierreActual.Rows(0).Item("fondo_inicial")
            hora_apertura = fechaInicio
            hora_cierre = fechaFin
            ingresoEfectivo = ventasEfectivo
            ingresoTarjeta = ventasTarjeta
            efectivo_contado = 0
            diferencia = 0
            diferenciaPorcentaje = 0

            ObtenerTotalMovimientosCaja()

        End Function

        ' Guarda el cierre de caja en la base de datos
        Friend Async Function guardarCierre() As Task(Of Boolean)
            Return Await Task.Run(Function()
                                      Try
                                          Dim consulta = "UPDATE Arqueo_Caja SET hora_cierre = @fechaFin, efectivo_contado = @efectivoContado, " &
                                                                " diferencia = @diferencia WHERE ID = @ID"
                                          Dim exito = EJECUTAR_PARAMETROS(consulta, New Dictionary(Of String, Object) From {
                                              {"fechaFin", hora_cierre},
                                              {"efectivoContado", efectivo_contado},
                                              {"diferencia", diferencia},
                                              {"ID", ID}
                                          })

                                          If Not exito Then
                                              Throw New Exception("No se pudo actualizar el cierre de caja.")
                                          End If

                                          Return True
                                      Catch ex As Exception
                                          Console.WriteLine("Error al guardar el cierre de caja: " & ex.Message)
                                          Return False
                                      End Try
                                  End Function)
        End Function

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
            efectivo_contado = 0
            diferencia = 0
            diferenciaPorcentaje = 0
            EntradasEfectivo = 0
            SalidasEfectivo = 0

            'Se recarga la información inicial
            Await obtenerInfoInicial()
        End Sub

        Friend Function CalcularMontoEfectivoCajaReal(listTxtDenominaciones As Dictionary(Of Integer, Guna2NumericUpDown)) As String
            ' Reinicia el totalCajaReal a cero antes de cada cálculo
            efectivo_contado = 0
            For Each denominacion In listTxtDenominaciones
                Dim valorContado As Decimal = denominacion.Value.Value
                Dim valorDenominacion As Integer = denominacion.Key

                ' Multiplica el valor del billete o la moneda por la cantidad contada
                efectivo_contado += valorDenominacion * valorContado
            Next

            Return efectivo_contado.ToString("C", New CultureInfo("es-CR"))
        End Function

        Friend Function CargarTotalEsperadoYDiferencia() As String
            'Se obtienen los datos de saldo inicial, ventas en efectivo
            Dim saldoInicial As Decimal = fondo_inicial
            Dim ventaEfectivo As Decimal = ingresoEfectivo
            Dim Salidas As Decimal = SalidasEfectivo
            Dim Entradas As Decimal = EntradasEfectivo

            'Saldo esperado = saldoInicial + Ventas - salidas
            Dim saldoEsperado = saldoInicial + ventaEfectivo + Entradas - Salidas

            'Se obtiene el valor del saldo real contado de la caja
            Dim saldoReal As Decimal = efectivo_contado
            'Diferencia absoluta = saldoEsperado - saldoReal
            diferencia = saldoReal - saldoEsperado
            'Diferencia porcentual = saldoReal * 100 / saldoEsperado
            If saldoEsperado <> 0 Then
                diferenciaPorcentaje = (diferencia / Math.Abs(saldoEsperado)) * 100
            Else
                diferenciaPorcentaje = 0
            End If

            'Se devuelve el saldo esperado formateado
            Return saldoEsperado.ToString("C", New CultureInfo("es-CR"))
        End Function

        Friend Function verificarCajaAbierta() As Boolean
            Dim SQL As String = "SELECT COUNT(*) FROM Arqueo_Caja WHERE hora_cierre IS NULL"
            Cargar_Tabla(T, SQL)

            'Si no hay filas, no hay caja abierta
            If T.Tables(0).Rows.Count <= 0 Then
                Return False
            End If
            'Si el conteo es mayor que 0, hay caja abierta
            Return Convert.ToInt32(T.Tables(0).Rows(0).Item(0)) > 0
        End Function

        Friend Async Function obtenerListaMovimientos(filter As String) As Task(Of DataTable)
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
                                      CargarTablaParam(T, SQL, paramList)

                                      Return T.Tables(0)
                                  End Function)
        End Function
    End Class
End Namespace
