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
    Friend Function GetConnectionString() As String
        Dim appDataPath As String = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)
        Dim appDirectory As String = Path.Combine(appDataPath, "SistemaDeFacturacion")
        Dim dbPath As String = Path.Combine(appDirectory, "dbSistemaFacturacion.db")

        If Not Directory.Exists(appDirectory) Then
            Directory.CreateDirectory(appDirectory)
        End If

        Return $"Data Source={dbPath}"
    End Function

    ' Este método es el que genera la ruta persistente para tu base de datos.
    Friend Function GetDbPath() As String
        ' 1. Obtiene la ruta del directorio de datos de la aplicación del usuario.
        Dim appDataPath As String = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)

        ' 2. Combina la ruta para crear una carpeta específica para tu aplicación.
        Dim appDirectory As String = Path.Combine(appDataPath, "SistemaDeFacturacion")

        ' 3. Combina la ruta de la carpeta con el nombre de tu base de datos.
        Dim dbPath As String = Path.Combine(appDirectory, "dbSistemaFacturacion.db")

        ' 4. Asegura que el directorio exista. Si no, lo crea.
        If Not Directory.Exists(appDirectory) Then
            Directory.CreateDirectory(appDirectory)
        End If

        Return dbPath
    End Function

#Region "Interaccion"
    ' Carga datos en un DataSet usando parámetros en la consulta SQL
    Public Sub CargarTablaParam(ByVal t As DataSet, ByVal consulta As String, ByVal parametros As List(Of SQLiteParameter))
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
                    Console.WriteLine("Ejeacutando consulta: " & consulta)
                    Using da As New SQLiteDataAdapter(cmd)
                        da.Fill(t)
                    End Using
                End Using
                Console.WriteLine("Datos cargados: " & t.Tables(0).Rows.Count & " filas.")
            Catch ex As Exception
                Console.WriteLine(ex.Message)
            End Try
        End Using
    End Sub

    ' Carga datos en un DataSet usando una consulta SQL simple
    Public Sub Cargar_Tabla(ByVal t As DataSet, ByVal consulta As String)
        Using db As New SQLiteConnection(GetConnectionString())
            Try
                db.Open()
                Using cmd As New SQLiteCommand(consulta, db)
                    Console.WriteLine("Ejecutando consulta: " & consulta)
                    Using da As New SQLiteDataAdapter(cmd)
                        da.Fill(t)
                    End Using
                End Using
                Console.WriteLine("Datos cargados: " & t.Tables(0).Rows.Count & " filas.")
                ' Nota: la línea "t.Tables(0).Rows(0).Item(0)" puede causar un error si no hay datos. Se corrigió a .Rows.Count.
            Catch ex As Exception
                Console.WriteLine(ex.Message)
            End Try
        End Using
    End Sub

    ' Ejecuta una consulta SQL que no retorna resultados (INSERT, UPDATE, DELETE)
    Public Function EJECUTAR(ByVal SQL As String) As Boolean
        Using db As New SQLiteConnection(GetConnectionString())
            Try
                db.Open()
                Using cmd As New SQLiteCommand(SQL, db)
                    cmd.ExecuteNonQuery()
                End Using
                Return True
            Catch ex As Exception
                Console.WriteLine(ex.Message)
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
                    cmd.ExecuteNonQuery()
                End Using
                Return True
            Catch ex As Exception
                Console.WriteLine(ex.Message)
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
                    Console.WriteLine(ex.Message)
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
            Console.WriteLine("Error en la ejecución de parámetros con transacción: " & ex.Message)
            Return False ' Esto causará que el Rollback se ejecute en el método principal.
        End Try
    End Function
#End Region

#Region "Configuracion"
    ' Los métodos que manejan App.config no necesitan refactorización, ya que no abren conexiones de base de datos.
    ' Se mantienen como están.
    Friend Sub modConexionString(rutaNueva As String)
        Dim config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None)
        config.ConnectionStrings.ConnectionStrings("DbConnectionString").ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & rutaNueva
        config.Save(ConfigurationSaveMode.Modified)
        ConfigurationManager.RefreshSection("connectionStrings")
    End Sub

    Public Sub ActConfig(key As String, value As String)
        Dim config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None)
        If config.AppSettings.Settings(key) IsNot Nothing Then
            config.AppSettings.Settings(key).Value = value
        Else
            config.AppSettings.Settings.Add(key, value)
        End If
        config.Save(ConfigurationSaveMode.Modified)
        ConfigurationManager.RefreshSection("appSettings")
    End Sub
#End Region
End Module
