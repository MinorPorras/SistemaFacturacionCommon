Imports System.Data.SQLite
Imports SistemaFacturaciónCommon.SistemaFacturacion.Data
Imports SistemaFacturaciónCommon.SistemaFacturacion.Forms.Caja
Imports SistemaFacturaciónCommon.SistemaFacturacion.Forms.Dialogos

Namespace SistemaFacturacion.Modules
    Module Md_Arqueos
#Region "Dialog"
        Public Sub ShowAperturaDialog(owner As Form, denominaciones As Cls_SaldoCaja)
            Using frmAperturaCaja As New D_AperturaCaja()
                frmAperturaCaja.Owner = owner
                frmAperturaCaja.saldoSiguiente = denominaciones
                Dim result As DialogResult = frmAperturaCaja.ShowDialog()
                If result = DialogResult.OK Then
                    Dim apertura As New Cls_CierreCaja With {
                        .ID_Usuario = idUsuActual,
                        .Fondo_inicial = CInt(frmAperturaCaja.saldoSiguiente.Total)
                    }
                    If apertura.IngresarApertura() Then
                        mensaje("Apertura de caja registrada con éxito", vbOKOnly, "Apertura de caja")
                    End If
                Else
                    Console.WriteLine("Se presionó el botón Cancel")
                    Return
                End If
            End Using
        End Sub

        Public Async Sub ShowCierreDialog(Owner As Form)
            If Not CheckIfCajaAbierta() Then
                msgError("No se puede realizar el cierre de caja porque no hay una caja abierta. Por favor, realice una apertura de caja primero.")
                Return
            End If
            Using frmCierre As New P_GenerarCierreCaja
                frmCierre.Owner = Owner
                Dim result = frmCierre.ShowDialog()

                If result <> DialogResult.OK Then
                    Console.WriteLine("Se presionó el botón Cancel")
                    Exit Sub
                End If

                If Await frmCierre.infoCierre.guardarCierre() Then
                    mensaje("Cierre de caja registrado con éxito", vbOKOnly, "Cierre de caja")
                    'Se abre el formulario de apertura de caja para iniciar una nueva sesión
                    ShowAperturaDialog(Owner, frmCierre.infoCierre.saldoSiguienteTurno)
                End If
            End Using
        End Sub
#End Region

#Region "Data & CRUD"
        Friend Sub RegistroMovimientos(esEntrada As Boolean, owner As Form)
            Using formMovimiento As New D_MovimientoCaja
                formMovimiento.isEntrada = esEntrada
                formMovimiento.Owner = owner
                Dim resultado As DialogResult = formMovimiento.ShowDialog()

                If resultado = DialogResult.OK Then
                    Dim movimiento As New Cls_MovimientosCaja With {
                        .id = 0,
                        .monto = CInt(formMovimiento.NUD_Monto.Value),
                        .tipoMovimiento = If(esEntrada, 1, 2),
                        .ID_Concepto = CInt(formMovimiento.CBX_tipoConcepto.SelectedValue),
                        .ID_Arqueo = 0,
                        .referencia = formMovimiento.TXT_Referencia.Text,
                        .fecha = DateTime.Now
                    }
                    If IngresarMovimientoCaja(movimiento) Then
                        mensaje("Ingreso registrado con éxito", vbOKOnly, "Ingreso a caja")
                    End If
                Else
                    Console.WriteLine("Se presionó el botón Cancel")
                    Return
                End If
            End Using
        End Sub

        Private Function IngresarMovimientoCaja(movimiento As Cls_MovimientosCaja) As Boolean
            ' Se define un delegado que contiene todas las operaciones
            Dim operacionesDeGuardado As Action(Of SQLiteConnection, SQLiteTransaction) =
            Sub(conn, transaction)
                CrearMovimiento(conn, transaction, movimiento)
            End Sub

            ' Se llama al método para ejecutar la transacción de forma segura
            If Not EJECUTAR_TRANSACCION(operacionesDeGuardado) Then
                Return False
            End If

            Return True
        End Function

        Private Function CrearMovimiento(conn As SQLiteConnection, transaction As SQLiteTransaction, movimiento As Cls_MovimientosCaja)
            'Hacer el ingreso a la base de datos de la información
            'Se ingresa el nuevo ID, monto, ID_Tipo_Movimiento, ID_Concepto, ID_arqueo, referencia
            Dim insertSQL As String = "INSERT INTO Movimientos_Caja (ID, monto, ID_Tipo_Movimiento, ID_Concepto, ID_arqueo, referencia, fecha_hora) " &
                                        "VALUES (@id, @monto, @tipo, @concepto, @arqueo, @referencia, @fecha)"
            Dim param As New Dictionary(Of String, Object) From {
                {"id", OBTENERPK("Movimientos_Caja", "ID")},
                {"monto", movimiento.monto},
                {"tipo", movimiento.tipoMovimiento}, ' 1 para entrada, 2 para salida
                {"concepto", movimiento.ID_Concepto},
                {"arqueo", OBTENERULTIMOARQUEO(conn)},
                {"referencia", movimiento.referencia},
                {"fecha", movimiento.fecha}
            }
            Return EJECUTAR_PARAMETROS_TRANSACCION(insertSQL, param, conn, transaction)
        End Function
#End Region

#Region "Validations"
        Friend Function CheckIfCajaAbierta() As Boolean
            Dim SQL As String = "SELECT COUNT(*) FROM Arqueo_Caja WHERE hora_cierre IS NULL"
            Cargar_Tabla(T, SQL)

            'Si no hay filas, no hay caja abierta
            If T.Tables(0).Rows.Count <= 0 Then
                Return False
            End If
            'Si el conteo es mayor que 0, hay caja abierta
            Return True
        End Function
#End Region

#Region "GetData"
        Friend Function OBTENERULTIMOARQUEO(conn As SQLiteConnection) As Object
            SQL = "SELECT ID FROM Arqueo_Caja ORDER BY ID DESC LIMIT 1"
            Dim cmd As New SQLiteCommand(SQL, conn)
            Dim result = cmd.ExecuteScalar()
            If result IsNot Nothing Then
                Return Convert.ToInt32(result)
            Else
                msgError("No se encontró un arqueo de caja abierto. Por favor, realice una apertura de caja primero.")
                Throw New Exception("No se encontró un arqueo de caja abierto.")
            End If
        End Function
#End Region
    End Module
End Namespace
