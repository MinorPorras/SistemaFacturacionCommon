' -----------------------------------------------------------------------------
' Módulo de procesos y utilidades para operaciones CRUD en la base de datos
' Incluye funciones para guardar, actualizar, eliminar, obtener y validar datos
' -----------------------------------------------------------------------------

Imports System.Configuration
Imports System.Data.SQLite
Imports Syncfusion.Linq
Imports Syncfusion.Windows.Forms.Diagram
Namespace SistemaFacturacion.Modules

    Module Md_PROCESOS_BD

#Region "Operaciones de Guardado y Actualización"
        ' Guarda una nueva PK en la tabla especificada
        Friend Sub GUARDAR_PK(ByVal tabla As String, ByVal atributoPK As String, ByVal datoPK As Integer)
            SQL = "INSERT INTO " & tabla & "(" & atributoPK & ") VALUES (" & datoPK & ")"
            EJECUTAR(SQL)
        End Sub

        ' Actualiza un campo entero en la tabla
        Friend Sub GUARDAR_INT(ByVal tabla As String, ByVal atributos As String, ByVal contenido As Integer, ByVal PK As String, ByVal valorPK As Integer)
            SQL = "UPDATE " & tabla & " SET " & atributos & " = ( " & contenido & ") WHERE " & PK & " = " & valorPK & ";"
            EJECUTAR(SQL)
        End Sub

        ' Actualiza un campo de texto en la tabla
        Friend Sub GUARDAR_TEXT(ByVal tabla As String, ByVal atributos As String, ByVal contenido As String, ByVal PK As String, ByVal valorPK As Integer)
            SQL = "UPDATE " & tabla & " SET " & atributos & " = ('" & contenido & "') WHERE " & PK & " = " & valorPK & ";"
            EJECUTAR(SQL)
        End Sub

        ' Guarda una fila con 4 valores enteros
        Friend Sub GUARDAR_VarCompInt4(ByVal tabla As String, ByVal PK As Integer, ByVal value1 As Integer, ByVal value2 As Integer, ByVal value3 As Integer)
            SQL = "INSERT INTO " & tabla & " VALUES (" & PK & ", " & value1 & ", " & value2 & ", " & value3 & ")"
            EJECUTAR(SQL)
        End Sub

        ' Guarda una fila with PK y valor de texto
        Friend Sub GUARDAR_VarCompuestas(ByVal tabla As String, ByVal PK As Integer, ByVal value As String)
            SQL = "INSERT INTO " & tabla & " VALUES (" & PK & ", '" & value & "')"
            EJECUTAR(SQL)
        End Sub

        ' Guarda una fila con PK y valor entero
        Friend Sub GUARDAR_VarCompuestasInt(ByVal tabla As String, ByVal PK As Integer, ByVal value As Integer)
            SQL = "INSERT INTO " & tabla & " VALUES (" & PK & ", " & value & ")"
            EJECUTAR(SQL)
        End Sub

        ' Guarda una fila con PK y valor numérico (double)
        Friend Sub GUARDAR_VarCompNumeric(ByVal tabla As String, ByVal PK As Integer, ByVal value1 As Double)
            SQL = "INSERT INTO " & tabla & " VALUES (" & PK & ", " & value1 & ")"
            EJECUTAR(SQL)
        End Sub

        ' Actualiza un campo tipo BLOB (texto largo o binario)
        Friend Sub GUARDAR_BLOB(ByVal tabla As String, ByVal atributos As String, ByVal contenido As String, ByVal PK As String, ByVal valorPK As Integer)
            SQL = "UPDATE " & tabla & " SET " & atributos & " = ('" & contenido & "') WHERE " & PK & " = " & valorPK & ";"
            EJECUTAR(SQL)
        End Sub

        ' Actualiza un campo numérico (double)
        Friend Sub GUARDAR_NUMERIC(ByVal tabla As String, ByVal atributos As String, ByVal contenido As Double, ByVal PK As String, ByVal valorPK As Integer)
            SQL = "UPDATE " & tabla & " SET " & atributos & " = ( " & contenido & ") WHERE " & PK & " = " & valorPK & ";"
            EJECUTAR(SQL)
        End Sub

        ' Actualiza un campo de fecha (Date) en formato yyyy-MM-dd
        Friend Sub GUARDAR_DATE(ByVal TABLA As String, ByVal ATRIBUTOS As String, ByVal CONTENIDO As Date, ByVal PK As String, ByVal VALORPK As Integer)
            ' Convertir la fecha a un formato estándar de SQLite (yyyy-MM-dd)
            Dim contenidoStr As String = Format(CONTENIDO, "yyyy-MM-dd")
            SQL = "UPDATE " & TABLA & " SET " & ATRIBUTOS & " = '" & contenidoStr & "' WHERE " & PK & " = " & VALORPK
            EJECUTAR(SQL)
        End Sub

        ' Actualiza un campo de hora (TimeSpan) en formato HH:mm:ss
        Friend Sub GUARDAR_TIME(ByVal TABLA As String, ByVal ATRIBUTOS As String, ByVal CONTENIDO As TimeSpan, ByVal PK As String, ByVal VALORPK As Integer)
            ' Convertir TimeSpan a String con formato HH:mm:ss para TIME
            Dim contenidoStr As String = CONTENIDO.ToString("hh\:mm\:ss")
            SQL = "UPDATE " & TABLA & " SET " & ATRIBUTOS & " = '" & contenidoStr & "' WHERE " & PK & " = " & VALORPK
            EJECUTAR(SQL)
        End Sub

        ' Actualiza un campo de hora con la hora actual del sistema
        Friend Sub GUARDAR_TIMEACTUAL(ByVal TABLA As String, ByVal ATRIBUTOS As String, ByVal PK As String, ByVal VALORPK As Integer)
            SQL = "UPDATE " & TABLA & " SET " & ATRIBUTOS & " = datetime('now', 'localtime') WHERE " & PK & " = " & VALORPK
            EJECUTAR(SQL)
        End Sub
#End Region

#Region "Eliminación de Registros"
        ' Elimina un registro de la tabla por PK
        Friend Sub ELIMINAR(ByVal TABLA As String, ByVal PK As String, ByVal VALORPK As Integer)
            SQL = "DELETE FROM " & TABLA & " WHERE " & PK & " = " & VALORPK
            EJECUTAR(SQL)
        End Sub
#End Region

#Region "Gestión de Facturas y cuentas por cobrar"
        ' Guarda una factura con los datos proporcionados
        Friend Sub GUARDAR_FACT(ByVal TABLA As String, ByVal DATOS As String)
            SQL = "INSERT INTO " & TABLA & " VALUES (" & DATOS & ")"
            EJECUTAR(SQL)
        End Sub

        ' Función asíncrona para eliminar una factura y sus datos asociados.
        Friend Async Function ELIMINAR_FACT(ByVal ID As Integer) As Task(Of Boolean)
            Return Await Task.Run(Function()
                                      Dim resultado As Boolean = False

                                      Using db As New SQLiteConnection(GetConnectionString())
                                          ' Se inicia un proceso de transacción
                                          db.Open()
                                          Dim transaction As SQLiteTransaction = db.BeginTransaction()

                                          Try
                                              ' 1. Eliminar el comentario
                                              Dim deleteComentarioSql As String = "DELETE FROM factura_comentario WHERE ID_factura = @id"
                                              Using cmd As New SQLiteCommand(deleteComentarioSql, db, transaction)
                                                  cmd.Parameters.AddWithValue("@id", ID)
                                                  cmd.ExecuteNonQuery()
                                              End Using

                                              ' 2. Eliminar los productos de la factura
                                              Dim deleteProductosSql As String = "DELETE FROM factura_producto WHERE ID_factura = @id"
                                              Using cmd As New SQLiteCommand(deleteProductosSql, db, transaction)
                                                  cmd.Parameters.AddWithValue("@id", ID)
                                                  cmd.ExecuteNonQuery()
                                              End Using

                                              ' 3. Eliminar la factura principal
                                              Dim deleteFacturaSql As String = "DELETE FROM factura WHERE ID = @id"
                                              Using cmd As New SQLiteCommand(deleteFacturaSql, db, transaction)
                                                  cmd.Parameters.AddWithValue("@id", ID)
                                                  cmd.ExecuteNonQuery()
                                              End Using

                                              ' Si todo salió bien, confirma la transacción
                                              transaction.Commit()
                                              resultado = True

                                          Catch ex As Exception
                                              ' Si algo falla, revierte la transacción
                                              transaction.Rollback()
                                              Console.WriteLine("Error al eliminar la factura: " & ex.Message)
                                              msgError("Error al eliminar la factura: " & ex.Message)
                                              resultado = False
                                          End Try
                                      End Using
                                      Return resultado
                                  End Function)
        End Function

        ' Función asíncrona para eliminar una cuenta por cobrar
        Friend Async Function ELIMINAR_CxC(ByVal ID As Integer) As Task(Of Boolean)
            Return Await Task.Run(Function()
                                      Dim resultado As Boolean = False

                                      Using db As New SQLiteConnection(GetConnectionString())
                                          ' Se inicia un proceso de transacción
                                          db.Open()
                                          Dim transaction As SQLiteTransaction = db.BeginTransaction()

                                          Try
                                              ' 1. Eliminar la cuenta por cobrar
                                              Dim deleteComentarioSql As String = "DELETE FROM CC_Encabezado WHERE ID = @id"
                                              Using cmd As New SQLiteCommand(deleteComentarioSql, db, transaction)
                                                  cmd.Parameters.AddWithValue("@id", ID)
                                                  cmd.ExecuteNonQuery()
                                              End Using

                                              ' Si todo salió bien, confirma la transacción
                                              transaction.Commit()
                                              resultado = True

                                          Catch ex As Exception
                                              ' Si algo falla, revierte la transacción
                                              transaction.Rollback()
                                              Console.WriteLine("Error al eliminar la cuenta por cobrar: " & ex.Message)
                                              msgError("Error al eliminar la cuenta por cobrar: " & ex.Message)
                                              resultado = False
                                          End Try
                                      End Using
                                      Return resultado
                                  End Function)
        End Function

        Friend Function SwitchEstadoCuenta(ID As Integer, estado As Integer) As Boolean
            SQL = "UPDATE CC_ENCABEZADO SET Estado = @estado WHERE ID = @ID"
            Dim paramList = New Dictionary(Of String, Object) From {
                {"ID", ID},
                {"estado", estado}
            }
            If EJECUTAR_PARAMETROS(SQL, paramList) Then
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
                    Return 1
                End If

                SQL = "SELECT MAX(" & PK & ") FROM " & TABLA

                Using data As New DataSet
                    Cargar_Tabla(data, SQL)

                    If Not data.Tables(0).Rows.Count > 0 OrElse IsDBNull(data.Tables(0).Rows(0).Item(0)) Then
                        Return 1
                    End If

                    Return data.Tables(0).Rows(0).Item(0) + 1
                End Using

            Catch ex As Exception
                MsgBox("Error al cargar los datos desde la base de datos" & vbCrLf & ex.ToString(), vbOKOnly, "Error")
                Return 1
            End Try
        End Function

        Friend Function GetLastInsertedID(ByVal dbConnection As SQLiteConnection) As Integer
            Dim idResultado As Integer = 0

            Try
                Using cmd As New SQLiteCommand("SELECT last_insert_rowid()", dbConnection)
                    Dim result As Object = cmd.ExecuteScalar()

                    If Not IsDBNull(result) AndAlso result IsNot Nothing Then
                        idResultado = Convert.ToInt32(result)
                    End If
                End Using

                Return idResultado

            Catch ex As Exception
                ' Manejo de errores simplificado
                MsgBox("Error al obtener el último ID insertado: " & vbCrLf & ex.Message, vbOKOnly, "Error")
                Return 0
            End Try
        End Function

        Friend Function GetLastInsertedID_Transaction(ByVal dbConnection As SQLiteConnection, ByVal transaction As SQLiteTransaction) As Integer
            Dim idResultado As Integer = 0

            Try
                Using cmd As New SQLiteCommand("SELECT last_insert_rowid()", dbConnection, transaction)
                    Dim result As Object = cmd.ExecuteScalar()

                    If Not IsDBNull(result) AndAlso result IsNot Nothing Then
                        idResultado = Convert.ToInt32(result)
                    End If
                End Using

                Return idResultado

            Catch ex As Exception
                ' Manejo de errores simplificado
                MsgBox("Error al obtener el último ID insertado: " & vbCrLf & ex.Message, vbOKOnly, "Error")
                Return 0
            End Try
        End Function

        ' Verifica si existen registros en la tabla para la PK
        Friend Function EXISTE(ByVal TABLA As String, ByVal PK As String) As Boolean
            T.Tables.Clear()
            SQL = "SELECT " & PK & " From " & TABLA
            Cargar_Tabla(T, SQL)
            If T.Tables(0).Rows.Count > 0 Then
                EXISTE = True
            Else
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
                    EXISTEPK = True
                Else
                    EXISTEPK = False
                End If
            Catch ex As Exception
                EXISTEPK = False
                MsgBox("Error al cargar los datos desde la base de datos" & vbCrLf & ex.ToString(), vbOKOnly, "Error")
            End Try
        End Function

        ' Verifica si existe un código específico en la tabla
        Friend Function EXISTECOD(ByVal TABLA As String, ByVal cod As String, ByVal DATO As String) As Boolean
            Try
                T.Tables.Clear()
                SQL = "SELECT " & cod & " From " & TABLA & " WHERE " & cod & " = '" & DATO & "'"
                Cargar_Tabla(T, SQL)
                If T.Tables(0).Rows.Count > 0 Then
                    EXISTECOD = True
                Else
                    EXISTECOD = False
                End If
            Catch ex As Exception
                EXISTECOD = False
                MsgBox("Error al cargar los datos desde la base de datos" & vbCrLf & ex.ToString(), vbOKOnly, "Error")
            End Try
        End Function

        ' Valida si la tabla tiene contenido
        Friend Function Validar_Contenido_Tabla(ByVal TABLA As String) As Boolean
            Try
                T.Tables.Clear()
                SQL = "SELECT * FROM " & TABLA
                Cargar_Tabla(T, SQL)
                If T.Tables(0).Rows.Count > 0 Then
                    Validar_Contenido_Tabla = True
                Else
                    Validar_Contenido_Tabla = False
                End If
            Catch ex As Exception
                Validar_Contenido_Tabla = False
                MsgBox("Error al cargar los datos desde la base de datos" & vbCrLf & ex.ToString(), vbOKOnly, "Error")
            End Try
        End Function

        ' Obtiene una lista de códigos existentes en una tabla para un atributo
        Public Function ObtenerCodigosExistentes(tabla As String, atributo As String) As List(Of Integer)
            T.Tables.Clear()
            Dim codigos As New List(Of Integer)
            SQL = "SELECT " & atributo & " FROM " & tabla
            Cargar_Tabla(T, SQL)
            If T.Tables(0).Rows.Count > 0 Then
                For i As Integer = 0 To T.Tables(0).Rows.Count - 1
                    Dim codigo As Integer
                    If Integer.TryParse(T.Tables(0).Rows(i).Item(0).ToString(), codigo) Then
                        codigos.Add(codigo)
                    End If
                Next
                Return codigos
            Else
                codigos.Add(1)
                Return codigos
            End If
        End Function
#End Region

    End Module

End Namespace