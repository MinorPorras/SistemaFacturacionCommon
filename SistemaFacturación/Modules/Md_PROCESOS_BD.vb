' -----------------------------------------------------------------------------
' Módulo de procesos y utilidades para operaciones CRUD en la base de datos
' Incluye funciones para guardar, actualizar, eliminar, obtener y validar datos
' -----------------------------------------------------------------------------

Imports System.Data.SQLite
Imports Serilog
Namespace SistemaFacturacion.Modules

    Module Md_PROCESOS_BD

#Region "Operaciones de Guardado y Actualización"
        ' Guarda una nueva PK en la tabla especificada
        Friend Sub GUARDAR_PK(ByVal tabla As String, ByVal atributoPK As String, ByVal datoPK As Integer)
            SQL = "INSERT INTO " & tabla & "(" & atributoPK & ") VALUES (" & datoPK & ")"
            Log.Debug("Ejecutando SQL para guardar PK: " & SQL)
            EJECUTAR(SQL)
        End Sub

        ' Actualiza un campo entero en la tabla
        Friend Sub GUARDAR_INT(ByVal tabla As String, ByVal atributos As String, ByVal contenido As Integer, ByVal PK As String, ByVal valorPK As Integer)
            SQL = "UPDATE " & tabla & " SET " & atributos & " = ( " & contenido & ") WHERE " & PK & " = " & valorPK & ";"
            Log.Debug("Ejecutando SQL para guardar INT: " & SQL)
            EJECUTAR(SQL)
        End Sub

        ' Actualiza un campo de texto en la tabla
        Friend Sub GUARDAR_TEXT(ByVal tabla As String, ByVal atributos As String, ByVal contenido As String, ByVal PK As String, ByVal valorPK As Integer)
            SQL = "UPDATE " & tabla & " SET " & atributos & " = ('" & contenido & "') WHERE " & PK & " = " & valorPK & ";"
            Log.Debug("Ejecutando SQL para guardar TEXT: " & SQL)
            EJECUTAR(SQL)
        End Sub

        ' Guarda una fila con 4 valores enteros
        Friend Sub GUARDAR_VarCompInt4(ByVal tabla As String, ByVal PK As Integer, ByVal value1 As Integer, ByVal value2 As Integer, ByVal value3 As Integer)
            SQL = "INSERT INTO " & tabla & " VALUES (" & PK & ", " & value1 & ", " & value2 & ", " & value3 & ")"
            Log.Debug("Ejecutando SQL para guardar VarCompInt4: " & SQL)
            EJECUTAR(SQL)
        End Sub

        ' Guarda una fila with PK y valor de texto
        Friend Sub GUARDAR_VarCompuestas(ByVal tabla As String, ByVal PK As Integer, ByVal value As String)
            SQL = "INSERT INTO " & tabla & " VALUES (" & PK & ", '" & value & "')"
            Log.Debug("Ejecutando SQL para guardar VarCompuestas: " & SQL)
            EJECUTAR(SQL)
        End Sub

        ' Guarda una fila con PK y valor entero
        Friend Sub GUARDAR_VarCompuestasInt(ByVal tabla As String, ByVal PK As Integer, ByVal value As Integer)
            SQL = "INSERT INTO " & tabla & " VALUES (" & PK & ", " & value & ")"
            Log.Debug("Ejecutando SQL para guardar VarCompuestasInt: " & SQL)
            EJECUTAR(SQL)
        End Sub

        ' Guarda una fila con PK y valor numérico (double)
        Friend Sub GUARDAR_VarCompNumeric(ByVal tabla As String, ByVal PK As Integer, ByVal value1 As Double)
            SQL = "INSERT INTO " & tabla & " VALUES (" & PK & ", " & value1 & ")"
            Log.Debug("Ejecutando SQL para guardar VarCompNumeric: " & SQL)
            EJECUTAR(SQL)
        End Sub

        ' Actualiza un campo tipo BLOB (texto largo o binario)
        Friend Sub GUARDAR_BLOB(ByVal tabla As String, ByVal atributos As String, ByVal contenido As String, ByVal PK As String, ByVal valorPK As Integer)
            SQL = "UPDATE " & tabla & " SET " & atributos & " = ('" & contenido & "') WHERE " & PK & " = " & valorPK & ";"
            Log.Debug("Ejecutando SQL para guardar BLOB: " & SQL)
            EJECUTAR(SQL)
        End Sub

        ' Actualiza un campo numérico (double)
        Friend Sub GUARDAR_NUMERIC(ByVal tabla As String, ByVal atributos As String, ByVal contenido As Double, ByVal PK As String, ByVal valorPK As Integer)
            SQL = "UPDATE " & tabla & " SET " & atributos & " = ( " & contenido & ") WHERE " & PK & " = " & valorPK & ";"
            Log.Debug("Ejecutando SQL para guardar NUMERIC: " & SQL)
            EJECUTAR(SQL)
        End Sub

        ' Actualiza un campo de fecha (Date) en formato yyyy-MM-dd
        Friend Sub GUARDAR_DATE(ByVal TABLA As String, ByVal ATRIBUTOS As String, ByVal CONTENIDO As Date, ByVal PK As String, ByVal VALORPK As Integer)
            ' Convertir la fecha a un formato estándar de SQLite (yyyy-MM-dd)
            Dim contenidoStr As String = Format(CONTENIDO, "yyyy-MM-dd")
            SQL = "UPDATE " & TABLA & " SET " & ATRIBUTOS & " = '" & contenidoStr & "' WHERE " & PK & " = " & VALORPK
            Log.Debug("Ejecutando SQL para guardar DATE: " & SQL)
            EJECUTAR(SQL)
        End Sub

        ' Actualiza un campo de hora (TimeSpan) en formato HH:mm:ss
        Friend Sub GUARDAR_TIME(ByVal TABLA As String, ByVal ATRIBUTOS As String, ByVal CONTENIDO As TimeSpan, ByVal PK As String, ByVal VALORPK As Integer)
            ' Convertir TimeSpan a String con formato HH:mm:ss para TIME
            Dim contenidoStr As String = CONTENIDO.ToString("hh\:mm\:ss")
            SQL = "UPDATE " & TABLA & " SET " & ATRIBUTOS & " = '" & contenidoStr & "' WHERE " & PK & " = " & VALORPK
            Log.Debug("Ejecutando SQL para guardar TIME: " & SQL)
            EJECUTAR(SQL)
        End Sub

        ' Actualiza un campo de hora con la hora actual del sistema
        Friend Sub GUARDAR_TIMEACTUAL(ByVal TABLA As String, ByVal ATRIBUTOS As String, ByVal PK As String, ByVal VALORPK As Integer)
            SQL = "UPDATE " & TABLA & " SET " & ATRIBUTOS & " = datetime('now', 'localtime') WHERE " & PK & " = " & VALORPK
            Log.Debug("Ejecutando SQL para guardar tiempo actual: " & SQL)
            EJECUTAR(SQL)
        End Sub
#End Region

#Region "Eliminación de Registros"
        ' Elimina un registro de la tabla por PK
        Friend Sub ELIMINAR(ByVal TABLA As String, ByVal PK As String, ByVal VALORPK As Integer)
            SQL = "DELETE FROM " & TABLA & " WHERE " & PK & " = " & VALORPK
            Log.Debug("Ejecutando SQL para eliminar registro: " & SQL)
            EJECUTAR(SQL)
        End Sub
#End Region

#Region "Gestión de Facturas y cuentas por cobrar"
        Friend Function SwitchEstadoCuenta(ID As Integer, estado As Integer) As Boolean
            SQL = "UPDATE CC_ENCABEZADO SET Estado = @estado WHERE ID = @ID"
            Log.Debug("Ejecutando SQL para cambiar estado de cuenta: " & SQL)
            Dim paramList = New Dictionary(Of String, Object) From {
                {"ID", ID},
                {"estado", estado}
            }
            If EJECUTAR_PARAMETROS(SQL, paramList) Then
                Log.Information($"Estado de cuenta con ID {ID} cambiado a {estado}")
                Return True
            End If
            Return False
        End Function
#End Region

#Region "Obtención de PK y Validaciones"
        ' Obtiene el siguiente valor de PK para una tabla
        Friend Function OBTENERPK(ByVal TABLA As String, ByVal PK As String) As Integer
            Try
                If Not EXISTE(TABLA, PK) = True Then
                    Log.Debug("No existen registros en la tabla " & TABLA & ". Retornando PK = 1")
                    Return 1
                End If

                SQL = "SELECT MAX(" & PK & ") FROM " & TABLA

                Using data As New DataSet
                    data.Tables.Clear()
                    Cargar_Tabla(data, SQL)

                    If Not data.Tables(0).Rows.Count > 0 OrElse IsDBNull(data.Tables(0).Rows(0).Item(0)) Then
                        Log.Debug("No se encontraron registros en la tabla " & TABLA & ". Retornando PK = 1")
                        Return 1
                    End If

                    Log.Debug("Siguiente PK para la tabla " & TABLA & " es " & (data.Tables(0).Rows(0).Item(0) + 1))
                    Return data.Tables(0).Rows(0).Item(0) + 1
                End Using
            Catch ex As Exception
                MsgError("Error al obtener la PK de la tabla " & TABLA & ": " & ex.ToString())
                Return 1
            End Try
        End Function

        Friend Function GetLastInsertedID(ByVal dbConnection As SQLiteConnection) As Integer
            Dim idResultado As Integer = 0

            Try
                Using cmd As New SQLiteCommand("SELECT last_insert_rowid()", dbConnection)
                    Dim result As Object = cmd.ExecuteScalar()

                    Log.Debug("Resultado de last_insert_rowid(): " & If(result IsNot Nothing, result.ToString(), "NULL"))
                    If Not IsDBNull(result) AndAlso result IsNot Nothing Then
                        idResultado = Convert.ToInt32(result)
                    End If
                End Using

                Log.Information("Último ID insertado obtenido: " & idResultado)
                Return idResultado

            Catch ex As Exception
                ' Manejo de errores simplificado
                MsgError("Error al obtener el último ID insertado: " & vbCrLf & ex.Message)
                Return 0
            End Try
        End Function

        Friend Function GetLastInsertedID_Transaction(ByVal dbConnection As SQLiteConnection, ByVal transaction As SQLiteTransaction) As Integer
            Dim idResultado As Integer = 0

            Try
                Using cmd As New SQLiteCommand("SELECT last_insert_rowid()", dbConnection, transaction)
                    Dim result As Object = cmd.ExecuteScalar()

                    Log.Debug("Resultado de last_insert_rowid() en transacción: " & If(result IsNot Nothing, result.ToString(), "NULL"))
                    If Not IsDBNull(result) AndAlso result IsNot Nothing Then
                        idResultado = Convert.ToInt32(result)
                    End If
                End Using

                Log.Information("Último ID insertado obtenido: " & idResultado)
                Return idResultado

            Catch ex As Exception
                ' Manejo de errores simplificado
                MsgError("Error al obtener el último ID insertado: " & vbCrLf & ex.Message)
                Return 0
            End Try
        End Function

        ' Verifica si existen registros en la tabla para la PK
        Friend Function EXISTE(ByVal TABLA As String, ByVal PK As String) As Boolean
            T.Tables.Clear()
            SQL = "SELECT " & PK & " From " & TABLA
            Cargar_Tabla(T, SQL)
            If T.Tables(0).Rows.Count > 0 Then
                Log.Information("Registros encontrados en la tabla " & TABLA)
                EXISTE = True
            Else
                Log.Warning("No se encontraron registros en la tabla " & TABLA)
                EXISTE = False
            End If
        End Function

        ' Verifica si existe una PK específica en la tabla
        Friend Function EXISTEPK(ByVal TABLA As String, ByVal PK As String, ByVal DATO_PK As Integer) As Boolean
            Try
                T.Tables.Clear()
                SQL = "SELECT " & PK & " From " & TABLA & " Where " & PK & " = " & DATO_PK
                Cargar_Tabla(T, SQL)
                If T.Tables(0).Rows.Count > 0 Then
                    Log.Information("PK " & DATO_PK & " encontrada en la tabla " & TABLA)
                    EXISTEPK = True
                Else
                    Log.Warning("PK " & DATO_PK & " no encontrada en la tabla " & TABLA)
                    EXISTEPK = False
                End If
            Catch ex As Exception
                EXISTEPK = False
                MsgError("Error al verificar la existencia de PK en la tabla " & TABLA & ": " & ex.ToString())
            End Try
        End Function

        ' Verifica si existe un código específico en la tabla
        Friend Function EXISTECOD(ByVal TABLA As String, ByVal cod As String, ByVal DATO As String) As Boolean
            Try
                T.Tables.Clear()
                SQL = "SELECT " & cod & " From " & TABLA & " WHERE " & cod & " = '" & DATO & "'"
                Cargar_Tabla(T, SQL)
                If T.Tables(0).Rows.Count > 0 Then
                    Log.Information("Código " & DATO & " encontrado en la tabla " & TABLA)
                    EXISTECOD = True
                Else
                    Log.Warning("Código " & DATO & " no encontrado en la tabla " & TABLA)
                    EXISTECOD = False
                End If
            Catch ex As Exception
                EXISTECOD = False
                MsgError("Error al verificar la existencia de código en la tabla " & TABLA & ": " & ex.ToString())
            End Try
        End Function

        ' Valida si la tabla tiene contenido
        Friend Function Validar_Contenido_Tabla(ByVal TABLA As String) As Boolean
            Try
                T.Tables.Clear()
                SQL = "SELECT * FROM " & TABLA
                Cargar_Tabla(T, SQL)
                If T.Tables(0).Rows.Count > 0 Then
                    Log.Information("La tabla " & TABLA & " contiene datos.")
                    Validar_Contenido_Tabla = True
                Else
                    Log.Warning("La tabla " & TABLA & " está vacía.")
                    Validar_Contenido_Tabla = False
                End If
            Catch ex As Exception
                Validar_Contenido_Tabla = False
                MsgError("Error al validar el contenido de la tabla " & TABLA & ": " & ex.ToString())
            End Try
        End Function

        ' Obtiene una lista de códigos existentes en una tabla para un atributo
        Public Function ObtenerCodigosExistentes(tabla As String, atributo As String) As List(Of Integer)
            T.Tables.Clear()
            Dim codigos As New List(Of Integer)
            SQL = "SELECT " & atributo & " FROM " & tabla
            Cargar_Tabla(T, SQL)
            Log.Information("Obteniendo códigos existentes de la tabla " & tabla & " para el atributo " & atributo)
            If T.Tables(0).Rows.Count > 0 Then
                For i As Integer = 0 To T.Tables(0).Rows.Count - 1
                    Dim codigo As Integer
                    If Integer.TryParse(T.Tables(0).Rows(i).Item(0).ToString(), codigo) Then
                        codigos.Add(codigo)
                    End If
                Next
                Log.Information("# Códigos obtenidos: {num}", codigos.Count)
                Return codigos
            Else
                Log.Warning("No se encontraron códigos en la tabla " & tabla & ". Retornando lista con valor 1.")
                codigos.Add(1)
                Return codigos
            End If
        End Function
#End Region

    End Module

End Namespace