Imports System.Data.SQLite
Imports System.Globalization
Imports Serilog
Imports SistemaFacturaciónCommon.SistemaFacturacion.Modules

Namespace SistemaFacturacion.Data

    Public Class Cls_CxCPagos
        Public Property ID As Integer
        Public Property ID_Usuario As Integer
        Public Property Cajero As String
        Public Property ID_CxC As Integer
        Public Property Fecha As DateTime
        Public Property Tipo_venta As Integer
        Public ReadOnly Property Tipo_venta_value As String
            Get
                Select Case Tipo_venta
                    Case 0
                        Return "Efectivo"
                    Case 1
                        Return "Tarjeta"
                    Case 2
                        Return "Sinpe"
                    Case 3
                        Return "Depósito"
                    Case Else
                        Return "Mixto"
                End Select
            End Get
        End Property
        Public Property Monto_efectivo As Decimal
        Public Property Monto_tarjeta As Decimal
        Public ReadOnly Property Total As Decimal
            Get
                Return Monto_efectivo + Monto_tarjeta
            End Get
        End Property
        Public Property Vuelto As Decimal
        Public ReadOnly Property Formated_vuelto As String
            Get
                Return Vuelto.ToString("C", culturaCR)
            End Get
        End Property

        Public ReadOnly Property Formated_monto_efectivo As String
            Get
                Return Monto_efectivo.ToString("C", culturaCR)
            End Get
        End Property
        Public ReadOnly Property Formated_monto_tarjeta As String
            Get
                Return Monto_tarjeta.ToString("C", culturaCR)
            End Get
        End Property
        Public ReadOnly Property Formated_total As String
            Get
                Return Total.ToString("C", culturaCR)
            End Get
        End Property
        Public Property Comentario As String = ""

        Private ReadOnly culturaCR As New CultureInfo("es-CR")


        Friend Async Function Guardar() As Task(Of Integer)
            Return Await Task.Run(Function() As Integer ' Usamos Await y especificamos el tipo de retorno

                                      ' 1. USANDO la conexión para asegurar que se cierre.
                                      Using db As New SQLiteConnection(GetConnectionString())
                                          db.Open() ' Abrir la conexión
                                          Log.Debug("Conexión a la base de datos abierta para guardar pago. UsuarioID={UserID}, CxCID={CxCID}, MontoEfectivo={Efectivo}, MontoTarjeta={Tarjeta}, Comentario={Comentario}",
                                                    ID_Usuario, ID_CxC, Monto_efectivo, Monto_tarjeta, If(String.IsNullOrEmpty(Comentario), "N/A", Comentario))

                                          ' 2. USANDO la transacción para asegurar que se libere, incluso si hay Rollback o error.
                                          ' Se requiere pasar la conexión abierta (db) al BeginTransaction
                                          Using transaction As SQLiteTransaction = db.BeginTransaction()

                                              Try
                                                  Dim consulta = "INSERT INTO CC_Pagos (ID_Usuario, ID_Encabezado, fecha, tipo_venta, monto_efectivo, monto_tarjeta, comentario)" &
                                                                    " VALUES (@ID_usuario, @ID_Encabezado, @fecha, @tipo_venta, @efectivo, @tarjeta, @comentario)"

                                                  ' Es mejor usar List(Of SQLiteParameter) si tu helper EJECUTAR_PARAMETROS_TRANSACCION lo soporta, 
                                                  ' o mantener el diccionario si ese helper lo requiere. Asumiremos que tu helper acepta el Dictionary.
                                                  Dim paramList As New Dictionary(Of String, Object) From {
                                                        {"ID_usuario", ID_Usuario},
                                                        {"ID_Encabezado", ID_CxC},
                                                        {"fecha", Fecha},
                                                        {"tipo_venta", Tipo_venta},
                                                        {"efectivo", Monto_efectivo},
                                                        {"tarjeta", Monto_tarjeta},
                                                        {"comentario", If(String.IsNullOrEmpty(Comentario), "", Comentario)}
                                                    }

                                                  ' Nota: Asegúrate de que las claves del diccionario de parámetros incluyan el "@" 
                                                  ' si tu helper EJECUTAR_PARAMETROS_TRANSACCION lo necesita.
                                                  Log.Information("Ejecutando inserción de pago en la base de datos.")
                                                  If EJECUTAR_PARAMETROS_TRANSACCION(consulta, paramList, db, transaction) Then
                                                      Dim idResultado = GetLastInsertedID_Transaction(db, transaction)
                                                      Log.Information("Pago guardado con éxito. PagoID={PaymentID}", idResultado)
                                                      transaction.Commit()
                                                      Return idResultado
                                                  Else
                                                      ' Si el helper devuelve False, se hace Rollback
                                                      Log.Error("Fallo al guardar el pago en la base de datos. Realizando rollback.")
                                                      transaction.Rollback()
                                                      Return 0
                                                  End If

                                              Catch ex As Exception
                                                  ' Si ocurre CUALQUIER error, hacemos Rollback
                                                  transaction.Rollback()
                                                  Log.Error(ex, "Excepción al guardar el pago. Realizando rollback.")
                                                  Return 0
                                              End Try

                                          End Using
                                      End Using

                                  End Function)
        End Function


        Friend Function GetDetailsWithID(ID_pago As Integer) As Boolean
            SQL = "SELECT cp.ID_Encabezado, cp.ID_Usuario, u.usuario , cp.fecha, 
                    cp.monto_efectivo, cp.monto_tarjeta, cp.vuelto, cp.comentario 
                    FROM CC_Pagos cp  
                    LEFT JOIN usuario u ON u.ID = cp.ID_Usuario 
                    WHERE cp.ID = @ID"
            Dim paramList As New List(Of SQLiteParameter) From {
                {New SQLiteParameter("@ID", ID_pago)}
            }

            CargarTablaParam(T, SQL, paramList)

            If T Is Nothing OrElse T.Tables.Count <= 0 OrElse T.Tables(0).Rows.Count <= 0 Then
                Return False
            End If

            ID = ID_pago
            ID_CxC = T.Tables(0).Rows(0).Item("ID_Encabezado")
            ID_Usuario = T.Tables(0).Rows(0).Item("ID_Usuario")
            Cajero = T.Tables(0).Rows(0).Item("usuario")
            Fecha = T.Tables(0).Rows(0).Item("fecha")
            Monto_efectivo = T.Tables(0).Rows(0).Item("monto_efectivo")
            Monto_tarjeta = T.Tables(0).Rows(0).Item("monto_tarjeta")
            Vuelto = If(IsDBNull(T.Tables(0).Rows(0).Item("vuelto")), 0, T.Tables(0).Rows(0).Item("vuelto"))
            Comentario = T.Tables(0).Rows(0).Item("comentario")
            Return True
        End Function

        Friend Function GetListaTotalesAbonosByDate(fechaInicio As Date, fechaFin As Date) As DataTable
            SQL = "SELECT SUM(p.monto_efectivo) AS total_efectivo, 
	                    SUM(p.monto_tarjeta) AS total_tarjeta, 
	                    COUNT(p.ID) AS total_pagos 
                    FROM CC_Pagos p
                    INNER JOIN CC_Encabezado ce on CE.ID = p.ID_Encabezado 
                    WHERE 
	                    ce.estado <> 2 AND
	                    date(p.fecha) BETWEEN date(@fechaInicio) AND date(@fechaFin);"
            Dim paramList As New List(Of SQLiteParameter) From {
                {New SQLiteParameter("@fechaInicio", fechaInicio.ToString("yyyy-MM-dd"))},
                {New SQLiteParameter("@fechaFin", fechaFin.ToString("yyyy-MM-dd"))}
            }
            Log.Information("Obteniendo totales de abonos entre {StartDate} y {EndDate}", fechaInicio.ToString("yyyy-MM-dd"), fechaFin.ToString("yyyy-MM-dd"))
            CargarTablaParam(T, SQL, paramList)
            If T Is Nothing OrElse T.Tables.Count <= 0 OrElse T.Tables(0).Rows.Count <= 0 Then
                Log.Warning("No se encontraron totales de abonos en el rango de fechas especificado.")
                Return Nothing
            End If

            Log.Information("Totales de abonos obtenidos con éxito.")
            Return T.Tables(0)
        End Function
    End Class
End Namespace
