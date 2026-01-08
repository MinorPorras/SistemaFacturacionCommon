' -----------------------------------------------------------------------------
' Módulo de conexión y operaciones con la base de datos SQLite para el sistema
' Incluye funciones de conexión, ejecución de consultas y utilidades de configuración
' -----------------------------------------------------------------------------
Imports System.Configuration
Imports System.Data.OleDb
Imports System.Data.SQLite
Imports System.IO
Imports System.Threading.Tasks
Imports System.Windows.Forms
Imports Serilog
Namespace SistemaFacturacion.Modules

    Module Md_CONEXION

        ' DataSets globales para almacenar resultados de consultas
        Public T As New DataSet
        Public T1 As New DataSet
        Public T2 As New DataSet
        Public T3 As New DataSet
        Public T4 As New DataSet
        Public T5 As New DataSet

        ' Variables globales de usuario actual
        Public idUsuActual As Integer
        Public nomUsuActual As String
        Public CuentaAdmin As Boolean

        ' Variables globales para consultas y cadena de conexión
        Public SQL As String

        ' Método privado para obtener la cadena de conexión segura y persistente
        ' Centraliza la obtención de la cadena de conexión
        Friend Function GetConnectionString() As String
            Log.Information("Obteniendo cadena de conexión a la base de datos.")
            Return $"Data Source={GetDbPath()};Version=3;"
        End Function

        ' Este método es el que genera la ruta persistente para tu base de datos.
        ' Centraliza la obtención de la ruta de la base de datos
        Friend Function GetDbPath() As String
            EnsureAppDirectoryExists()
            Dim appDir = GetAppDirectory()
            Log.Information("Ruta de la base de datos: {DbPath}", Path.Combine(appDir, "DB", "dbSistemaFacturacion.db"))
            Return Path.Combine(appDir, "DB", "dbSistemaFacturacion.db")
        End Function

#Region "Interaccion"
        ' Carga datos en un DataSet usando parámetros en la consulta SQL
        Public Sub CargarTablaParam(ByVal t As DataSet, ByVal consulta As String, ByVal parametros As List(Of SQLiteParameter))
            t.Tables.Clear()
            Using db As New SQLiteConnection(GetConnectionString())
                Try
                    db.Open()
                    Using cmd As New SQLiteCommand(consulta, db)
                        If parametros IsNot Nothing Then
                            For Each param As SQLiteParameter In parametros
                                cmd.Parameters.AddWithValue(param.ParameterName, param.Value)
                                Console.WriteLine("Parámetro añadido: " & param.ParameterName & " = " & param.Value)
                            Next
                        End If
                        Log.Information("Ejecutando consulta con parámetros: " & consulta)
                        Using da As New SQLiteDataAdapter(cmd)
                            da.Fill(t)
                        End Using
                    End Using
                    Log.Information("Datos cargados: {RowCount} filas.", t.Tables(0).Rows.Count)
                Catch ex As Exception
                    Log.Error(ex, "Error al cargar datos con parámetros")
                End Try
            End Using
        End Sub

        ' Carga datos en un DataSet usando una consulta SQL simple
        Public Async Sub Cargar_Tabla(ByVal t As DataSet, ByVal consulta As String)
            t.Tables.Clear()
            Using db As New SQLiteConnection(GetConnectionString())
                Try
                    db.Open()
                    Using cmd As New SQLiteCommand(consulta, db)
                        Using da As New SQLiteDataAdapter(cmd)
                            da.Fill(t)
                        End Using
                    End Using
                    Log.Information("Datos cargados: {RowCount} filas.", t.Tables(0).Rows.Count)
                Catch ex As Exception
                    Log.Error(ex, "Error al cargar datos")
                End Try
            End Using
        End Sub

        ' Carga datos en un DataSet usando parámetros en la consulta SQL (versión asíncrona)
        Public Async Function CargarTablaParamAsync(
            ByVal t As DataSet,
            ByVal consulta As String,
            ByVal parametros As List(Of SQLiteParameter)
        ) As Task

            t.Tables.Clear()

            Using db As New SQLiteConnection(GetConnectionString())
                Try
                    Await db.OpenAsync()

                    Using cmd As New SQLiteCommand(consulta, db)
                        If parametros IsNot Nothing Then
                            For Each param As SQLiteParameter In parametros
                                cmd.Parameters.AddWithValue(param.ParameterName, param.Value)
                                Console.WriteLine("Parámetro añadido: " & param.ParameterName & " = " & param.Value)
                            Next
                        End If

                        Log.Information("Ejecutando consulta con parámetros: " & consulta)

                        Using da As New SQLiteDataAdapter(cmd)
                            Await Task.Run(Function() da.Fill(t))
                        End Using
                    End Using

                    Log.Information("Datos cargados: {RowCount} filas.", t.Tables(0).Rows.Count)

                Catch ex As Exception
                    Log.Error(ex, "Error al cargar datos con parámetros")
                    Throw
                End Try
            End Using

        End Function

        ' Carga datos en un DataSet usando una consulta SQL simple (versión asíncrona)
        Public Async Function Cargar_TablaAsync(
            ByVal t As DataSet,
            ByVal consulta As String
        ) As Task

            t.Tables.Clear()

            Using db As New SQLiteConnection(GetConnectionString())
                Try
                    Await db.OpenAsync()

                    Using cmd As New SQLiteCommand(consulta, db)
                        Using da As New SQLiteDataAdapter(cmd)
                            Await Task.Run(Function() da.Fill(t))
                        End Using
                    End Using

                    Log.Information("Datos cargados: {RowCount} filas.", t.Tables(0).Rows.Count)

                Catch ex As Exception
                    Log.Error(ex, "Error al cargar datos")
                    Throw
                End Try
            End Using

        End Function


        ' Ejecuta una consulta SQL que no retorna resultados (INSERT, UPDATE, DELETE)
        Public Function EJECUTAR(ByVal SQL As String) As Boolean
            Using db As New SQLiteConnection(GetConnectionString())
                Try
                    db.Open()
                    Using cmd As New SQLiteCommand(SQL, db)
                        Log.Information("Ejecutando comando: " & SQL)
                        cmd.ExecuteNonQuery()
                    End Using
                    Return True
                Catch ex As Exception
                    Log.Error(ex, "Error al ejecutar comando")
                    Return False
                End Try
            End Using
        End Function

        ' Agregado el nuevo método que creamos juntos
        Public Function EJECUTAR_PARAMETROS(ByVal sql As String, ByVal parametros As Dictionary(Of String, Object)) As Boolean
            Using db As New SQLiteConnection(GetConnectionString())
                Try
                    db.Open()
                    Using cmd As New SQLiteCommand(sql, db)
                        For Each parametro As KeyValuePair(Of String, Object) In parametros
                            cmd.Parameters.AddWithValue($"@{parametro.Key}", parametro.Value)
                        Next
                        Log.Information("Ejecutando comando con parámetros: " & sql)
                        cmd.ExecuteNonQuery()
                    End Using
                    Return True
                Catch ex As Exception
                    Log.Error(ex, "Error al ejecutar comando con parámetros")
                    Return False
                End Try
            End Using
        End Function

        Public Function EJECUTAR_TRANSACCION(ByVal operaciones As Action(Of SQLiteConnection, SQLiteTransaction)) As Boolean
            Using db As New SQLiteConnection(GetConnectionString())
                db.Open()
                Using transaction As SQLiteTransaction = db.BeginTransaction()
                    Try
                        ' Se ejecutan todas las operaciones pasadas como parámetro
                        operaciones.Invoke(db, transaction)

                        ' Si no hay errores, se confirma la transacción
                        transaction.Commit()
                        Return True
                    Catch ex As Exception
                        ' Si hay un error, se revierte la transacción
                        transaction.Rollback()
                        Log.Error(ex, "Error en la transacción: {ErrorMessage}")
                        Return False
                    End Try
                End Using
            End Using
        End Function

        Public Function EJECUTAR_PARAMETROS_TRANSACCION(ByVal sql As String, ByVal parametros As Dictionary(Of String, Object), ByVal conn As SQLiteConnection, ByVal transaction As SQLiteTransaction) As Boolean
            Try
                Using cmd As New SQLiteCommand(sql, conn, transaction)
                    For Each parametro As KeyValuePair(Of String, Object) In parametros
                        cmd.Parameters.AddWithValue($"@{parametro.Key}", parametro.Value)
                    Next
                    cmd.ExecuteNonQuery()
                End Using
                Return True
            Catch ex As Exception
                Log.Error(ex, "Error en la ejecución de parámetros con transacción")
                Return False ' Esto causará que el Rollback se ejecute en el método principal.
            End Try
        End Function
#End Region
    End Module
End Namespace
