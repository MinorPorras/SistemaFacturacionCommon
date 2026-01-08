Imports System.Data.SQLite
Imports Serilog
Imports SistemaFacturaciónCommon.SistemaFacturacion.Data
Imports SistemaFacturaciónCommon.SistemaFacturacion.Forms.Caja
Imports SistemaFacturaciónCommon.SistemaFacturacion.Forms.Dialogos
Imports SistemaFacturaciónCommon.SistemaFacturacion.Types.tp_EstadoArqueo
Imports SistemaFacturaciónCommon.SistemaFacturacion.Helper.NavigationHelper
Imports SistemaFacturaciónCommon.SistemaFacturacion.Types

Namespace SistemaFacturacion.Modules
    Module Md_Arqueos

#Region "Dialog"
        Public Function ShowStartShiftDialog(owner As P_Caja, denominaciones As Cls_SaldoCaja) As Boolean
            If IsShiftStarted() Then
                MsgError("Ya hay un turno iniciado, antes de iniciar uno nuevo, debe de terminar el anterior")
                Return False
            End If
            Using frmAperturaCaja As New D_AperturaCaja()
                frmAperturaCaja.Owner = owner
                frmAperturaCaja.saldoSiguiente = denominaciones
                Dim result As DialogResult = frmAperturaCaja.ShowDialog()
                If result <> DialogResult.OK Then
                    Log.Information("Apertura de caja cancelada por el usuario.")
                    Return False
                End If

                Dim apertura As New Cls_CierreCaja With {
                    .ID_Usuario = idUsuActual,
                    .Fondo_inicial = CInt(frmAperturaCaja.saldoSiguiente.Total)
                }
                If apertura.IngresarApertura() Then
                    Log.Information("Apertura de caja registrada con éxito. UsuarioID={UserID}, FondoInicial={Fondo}", idUsuActual, apertura.Fondo_inicial)
                    Mensaje("Apertura de caja registrada con éxito", vbOKOnly, "Apertura de caja")
                    owner.LBL_EstadoTurno.Text = Iniciado
                    Return True
                Else
                    Log.Error("Fallo al registrar la Apertura de Caja en la DB. UsuarioID={UserID}, FondoInicial={Fondo}", idUsuActual, apertura.Fondo_inicial)
                    Return False
                End If
            End Using
        End Function

        Public Async Function ShowEndShiftDialog(Owner As P_Caja) As Task(Of Boolean)
            Log.Information("Iniciando flujo de Cierre de Caja.")
            Dim ShiftStateId = IsShiftStarted()
            If ShiftStateId = -1 Or ShiftStateId = 0 Then
                MsgError("No se puede realizar el cierre de caja porque no hay una caja abierta. Por favor, realice una apertura de caja primero.")
                Return False
            End If

            Using frmCierre As New P_GenerarCierreCaja
                frmCierre.Owner = Owner
                frmCierre.idCierre = ShiftStateId
                Dim result = frmCierre.ShowDialog()

                If result <> DialogResult.OK Then
                    Log.Information("Cierre de caja cancelado por el usuario o diálogo cerrado.")
                    Return False
                End If

                If Await frmCierre.infoCierre.GuardarCierre() Then
                    Log.Information("Cierre de caja registrado con éxito. UsuarioID={UserID}, TotalVentas={Ventas}, TotalEfectivo={Efectivo}, TotalTarjeta={Tarjeta}, apertura={horaApertura}, cierre={horaCierre}, SaldoSiguienteTurno={SaldoSiguiente}",
                                    idUsuActual,
                                    frmCierre.infoCierre.IngresoEfectivo,
                                    frmCierre.infoCierre.IngresoTarjeta,
                                    frmCierre.infoCierre.Hora_apertura,
                                    frmCierre.infoCierre.Hora_cierre,
                                    frmCierre.infoCierre.SaldoSiguienteTurno)
                    Mensaje("Cierre de caja registrado con éxito", vbOKOnly, "Cierre de caja")
                    'Primero se debe de abrir la pestaña de login
                    LogOut(True, Owner, fromArqueo:=True, denominaciones:=frmCierre.infoCierre.SaldoSiguienteTurno)
                    Return True
                Else
                    MsgError($"Fallo al registrar el Cierre de Caja en la DB. UsuarioID={idUsuActual}, MontoEfectivo={frmCierre.infoCierre.IngresoEfectivo}")
                    Return False
                End If
            End Using
        End Function
#End Region

#Region "Data & CRUD"
        Friend Sub RegistroMovimientos(esEntrada As Boolean, owner As Form)
            Using formMovimiento As New D_MovimientoCaja
                formMovimiento.isEntrada = esEntrada
                formMovimiento.Owner = owner
                Dim resultado As DialogResult = formMovimiento.ShowDialog()

                If resultado <> DialogResult.OK Then
                    Log.Information("Registro de movimiento de caja ({Tipo}) cancelado por el usuario.", If(esEntrada, "Entrada", "Salida"))
                    Exit Sub
                End If
                Dim movimiento As New Cls_MovimientosCaja With {
                    .Id = 0,
                    .Monto = CInt(formMovimiento.NUD_Monto.Value),
                    .TipoMovimiento = If(esEntrada, 1, 2),
                    .ID_Concepto = CInt(formMovimiento.CBX_tipoConcepto.SelectedValue),
                    .ID_Arqueo = 0,
                    .Referencia = formMovimiento.TXT_Referencia.Text,
                    .Fecha = DateTime.Now
                }
                Log.Information("Registrando movimiento de caja. Tipo={Tipo}, Monto={Monto}, ConceptoID={ConceptoID}, Referencia={Referencia}, Fecha={Fecha}",
                                If(esEntrada, "Entrada", "Salida"),
                                movimiento.Monto,
                                movimiento.ID_Concepto,
                                If(String.IsNullOrWhiteSpace(movimiento.Referencia), "N/A", movimiento.Referencia),
                                movimiento.Fecha)
                If IngresarMovimientoCaja(movimiento) Then
                    Log.Information("Ingreso registrado con éxito. Monto={Monto}, Tipo={Tipo}, ConceptoID={ConceptoID}", movimiento.Monto, If(esEntrada, "Entrada", "Salida"), movimiento.ID_Concepto)
                    Mensaje("Ingreso registrado con éxito", vbOKOnly, "Ingreso a caja")
                Else
                    MsgError("Fallo al registrar el ingreso en la DB. Monto=" & movimiento.Monto & ", Tipo=" & If(esEntrada, "Entrada", "Salida") & ", ConceptoID=" & movimiento.ID_Concepto)
                End If
            End Using
        End Sub

        Private Function IngresarMovimientoCaja(movimiento As Cls_MovimientosCaja) As Boolean
            ' Se define un delegado que contiene todas las operaciones
            Dim operacionesDeGuardado As Action(Of SQLiteConnection, SQLiteTransaction) =
            Sub(conn, transaction)
                Log.Information("Iniciando transacción para registrar movimiento de caja.")
                CrearMovimiento(conn, transaction, movimiento)
            End Sub

            ' Se llama al método para ejecutar la transacción de forma segura
            If Not EJECUTAR_TRANSACCION(operacionesDeGuardado) Then
                MsgError("Error interno al registrar el movimiento de caja. Por favor, intente nuevamente.")
                Return False
            End If

            Log.Information("Transacción completada con éxito para movimiento de caja.")
            Return True
        End Function

        Private Function CrearMovimiento(conn As SQLiteConnection, transaction As SQLiteTransaction, movimiento As Cls_MovimientosCaja)
            'Hacer el ingreso a la base de datos de la información
            'Se ingresa el nuevo ID, monto, ID_Tipo_Movimiento, ID_Concepto, ID_arqueo, referencia
            Dim insertSQL As String = "INSERT INTO Movimientos_Caja (ID, monto, ID_Tipo_Movimiento, ID_Concepto, ID_arqueo, referencia, fecha_hora) " &
                                        "VALUES (@id, @monto, @tipo, @concepto, @arqueo, @referencia, @fecha)"
            Dim param As New Dictionary(Of String, Object) From {
                {"id", OBTENERPK("Movimientos_Caja", "ID")},
                {"monto", movimiento.Monto},
                {"tipo", movimiento.TipoMovimiento}, ' 1 para entrada, 2 para salida
                {"concepto", movimiento.ID_Concepto},
                {"arqueo", OBTENERULTIMOARQUEO(conn)},
                {"referencia", movimiento.Referencia},
                {"fecha", movimiento.Fecha}
            }
            Log.Information("Preparando para ejecutar inserción de movimiento de caja. Monto={Monto}, Tipo={Tipo}, ConceptoID={ConceptoID}, Referencia={Referencia}, Fecha={Fecha}",
                            movimiento.Monto,
                            If(movimiento.TipoMovimiento = 1, "Entrada", "Salida"),
                            movimiento.ID_Concepto,
                            If(String.IsNullOrWhiteSpace(movimiento.Referencia), "N/A", movimiento.Referencia),
                            movimiento.Fecha)
            Return EJECUTAR_PARAMETROS_TRANSACCION(insertSQL, param, conn, transaction)
        End Function
#End Region

#Region "Validations"
        ''' <summary>
        ''' Verifica que el usuario actual tenga un turno iniciado, Devolviendo un código integer que indica el estado del turno del cajero
        ''' </summary>
        ''' <returns>
        ''' -1 = Error, no se pudo obtener el ID del usuario
        ''' 0 = No se ha iniciado ningún turno
        ''' Cualquier Otro integer = ID del último cierre que tiene abierto el usuario actual
        ''' </returns>
        Friend Function IsShiftStarted() As Integer
            ' Asumiendo que tu llave primaria se llama id_arqueo
            Dim SQL As String = "SELECT COUNT(*), ID FROM Arqueo_Caja 
                                    WHERE ID = (SELECT MAX(ID) FROM Arqueo_Caja WHERE ID_Usuario = @idUsuario) 
                                    AND hora_cierre IS NULL AND ID_Usuario = @idUsuario"
            Dim paramList = New List(Of SQLiteParameter) From {
                {New SQLiteParameter("@idUsuario", idUsuActual)}
            }
            CargarTablaParam(T, SQL, paramList)

            'Si no hay filas, no hay caja abierta
            If T.Tables(0).Rows.Count <= 0 Then
                Log.Warning("No se ha inciado ningún turno, primero inicie uno nuevo")
                Return 0
            End If

            'Si el count de la instrucción es 0 significa que todos los arqueos están completos
            'O sea no hay caja abiertas y se puede abrir una nueva
            If T.Tables(0).Rows(0).Item(0) = 0 Then
                Log.Information("No hay turnos iniciados, puede crear un nuevo")
                Return 0
            End If

            If T.Tables(0).Rows(0).Item("ID") = 0 Then
                MSG.MsgError("No se pudo obtener el ID de la cuenta")
                Return -1
            End If

            'Si el conteo es mayor que 0, hay caja abierta
            Log.Information("Conteo de arqueos de caja abiertos: {Count}", Convert.ToInt32(T.Tables(0).Rows(0)(0)))
            Return T.Tables(0).Rows(0).Item("ID")
        End Function
#End Region

#Region "GetData"
        Friend Function OBTENERULTIMOARQUEO(conn As SQLiteConnection) As Object
            SQL = "SELECT ID FROM Arqueo_Caja ORDER BY ID DESC LIMIT 1"
            Dim cmd As New SQLiteCommand(SQL, conn)
            Dim result = cmd.ExecuteScalar()
            If result IsNot Nothing Then
                Log.Information("Último arqueo de caja obtenido: ID={ArqueoID}", Convert.ToInt32(result))
                Return Convert.ToInt32(result)
            Else
                MsgError("No se encontró un arqueo de caja abierto. Por favor, realice una apertura de caja primero.")
                Throw New Exception("No se encontró un arqueo de caja abierto.")
            End If
        End Function
#End Region
    End Module
End Namespace
