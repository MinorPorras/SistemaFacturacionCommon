Imports System.Configuration
Imports System.Data.SQLite
Imports System.IO
Imports System.Net
Imports Squirrel

' -----------------------------------------------------------------------------
' Módulo de inicialización y utilidades de configuración de la aplicación
' Incluye funciones para actualización, configuración y acceso a settings
' -----------------------------------------------------------------------------
Module Md_Inicializacion

#Region "Actualizaciones"
    'Comprueba si hay conexión a internet intentando acceder a un sitio conocido
    Function HayConexionInternet() As Boolean
        Try
            Using client As New WebClient()
                Using stream = client.OpenRead("https://www.google.com")
                    Return True
                End Using
            End Using
        Catch
            Return False
        End Try
    End Function

    ' Verifica si existe una nueva versión del instalador y pregunta al usuario si desea actualizar
    Async Sub AutoUpdate()
        Dim AutoUpdate As String = GetAppSetting("AutoUpdate")
        If AutoUpdate = "False" Then
            Return
        End If
        ' Verifica si la aplicación se está ejecutando en modo de depuración.
        ' Si es así, se omite la búsqueda de actualizaciones para evitar sobrescribir los archivos
        ' de desarrollo con los de una versión publicada.
#If DEBUG Then
        Return
#End If


        ' Verifica la conexión a Internet primero
        If Not HayConexionInternet() Then
            MessageBox.Show("No hay conexión a internet. No se puede buscar actualizaciones.", "Sin conexión", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If

        ' Usa un bloque Try...Catch para manejar cualquier error durante el proceso de actualización
        Try
            Using mgr = Await UpdateManager.GitHubUpdateManager("https://github.com/MinorPorras/SistemaFacturacionCommon", prerelease:=True)

                ' 1. Verificamos si hay una actualización disponible
                Dim updateInfo = Await mgr.CheckForUpdate()

                ' 2. Si no hay actualizaciones, salimos de la función sin hacer nada
                If updateInfo.ReleasesToApply.Count = 0 Then
                    MessageBox.Show("Tu aplicación está actualizada.", "Actualización", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Return
                End If

                ' 3. Si hay actualizaciones, la descargamos y la aplicamos
                Dim newVersion = updateInfo.ReleasesToApply.Max().Version
                MessageBox.Show($"¡Nueva versión {newVersion} disponible! Descargando actualización...", "Actualización", MessageBoxButtons.OK, MessageBoxIcon.Information)

                Await mgr.UpdateApp()

                MessageBox.Show("Actualización completada. Por favor, reinicia la aplicación para aplicar los cambios.", "Actualización", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End Using

        Catch ex As Exception
            ' En caso de un error (como no encontrar el repositorio o un problema de conexión),
            ' no mostramos el error al usuario y simplemente salimos.
            ' Si lo deseas, puedes registrar el error en un archivo de log.
            MessageBox.Show("Ocurrió un error al buscar actualizaciones: " & ex.Message, "Error de actualización", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ' Puedes agregar aquí una línea para registrar el error si lo necesitas.
        End Try
    End Sub

    ' Verifica si existe una nueva versión del instalador y pregunta al usuario si desea actualizar
    Async Sub CheckForUpdates()
        ' Verifica si la aplicación se está ejecutando en modo de depuración.
        ' Si es así, se omite la búsqueda de actualizaciones para evitar sobrescribir los archivos
        ' de desarrollo con los de una versión publicada.
#If DEBUG Then
        MessageBox.Show("Está en modo Debug no se revisan nuevas versiones para evitar actualizaciónes que puedan perjudicar el código de nuevas versiones",
                        "Modo DEBUG", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Return
#End If

        ' Verifica la conexión a Internet primero
        If Not HayConexionInternet() Then
            MessageBox.Show("No hay conexión a internet. No se puede buscar actualizaciones.", "Sin conexión", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If

        ' Usa un bloque Try...Catch para manejar cualquier error durante el proceso de actualización
        Try
            Using mgr = Await UpdateManager.GitHubUpdateManager("https://github.com/MinorPorras/SistemaFacturacionCommon", prerelease:=True)

                ' 1. Verificamos si hay una actualización disponible
                Dim updateInfo = Await mgr.CheckForUpdate()

                ' 2. Si no hay actualizaciones, salimos de la función sin hacer nada
                If updateInfo.ReleasesToApply.Count = 0 Then
                    MessageBox.Show("Tu aplicación está actualizada.", "Actualización", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Return
                End If

                ' 3. Si hay actualizaciones, la descargamos y la aplicamos
                Dim newVersion = updateInfo.ReleasesToApply.Max().Version
                MessageBox.Show($"¡Nueva versión {newVersion} disponible! Descargando actualización...", "Actualización", MessageBoxButtons.OK, MessageBoxIcon.Information)

                Await mgr.UpdateApp()

                MessageBox.Show("Actualización completada. Por favor, reinicia la aplicación para aplicar los cambios.", "Actualización", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End Using

        Catch ex As Exception
            ' En caso de un error (como no encontrar el repositorio o un problema de conexión),
            ' no mostramos el error al usuario y simplemente salimos.
            ' Si lo deseas, puedes registrar el error en un archivo de log.
            MessageBox.Show("Ocurrió un error al buscar actualizaciones: " & ex.Message, "Error de actualización", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ' Puedes agregar aquí una línea para registrar el error si lo necesitas.
        End Try
    End Sub
#End Region

#Region "Configuraciones"
    ' Establece o actualiza un valor en appSettings
    Sub SetAppSetting(key As String, value As String)
        Dim config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None)
        If config.AppSettings.Settings(key) IsNot Nothing Then
            config.AppSettings.Settings(key).Value = value
        Else
            config.AppSettings.Settings.Add(key, value)
        End If
        config.Save(ConfigurationSaveMode.Modified)
        ConfigurationManager.RefreshSection("appSettings")
    End Sub

    ' Obtiene el valor de una clave de appSettings
    Function GetAppSetting(key As String) As String
        Dim value As String = ConfigurationManager.AppSettings.Get(key)
        Return value
    End Function

    ' Establece o actualiza una cadena de conexión en connectionStrings
    Sub SetConnectionString(name As String, connectionString As String)
        Dim config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None)
        If config.ConnectionStrings.ConnectionStrings("conexionString") IsNot Nothing Then
            config.ConnectionStrings.ConnectionStrings("conexionString").ConnectionString = connectionString
        Else
            config.ConnectionStrings.ConnectionStrings.Add(New ConnectionStringSettings("conexionString", connectionString))
        End If
        config.Save(ConfigurationSaveMode.Modified)
        ConfigurationManager.RefreshSection("connectionStrings")
    End Sub

    ' Obtiene la cadena de conexión especificada
    Function ObtenerConnectionString(name As String) As String
        Dim settings As ConnectionStringSettings = ConfigurationManager.ConnectionStrings("conexionString")
        If settings IsNot Nothing Then
            Return settings.ConnectionString
        Else
            Return String.Empty ' O devolver un mensaje de error o valor por defecto
        End If
    End Function

    ' Abre la ventana de configuración general y selecciona la pestaña indicada
    Public Sub entrarConfig(index As Integer)
        ConfigGeneral.Show()
        ConfigGeneral.Select()
        ConfigGeneral.TCO_Config.SelectedIndex = index
    End Sub
#End Region

#Region "Migraciones"
    Friend Sub CheckAndMigrateDatabase()
        'Creación y actualización de tabla producto_favorito
        Create_Producto_Favorito_IfNotExists()
        'Creación y actualización de tabla CierreCaja
        Update_cierre_caja()
    End Sub

    Private Sub Create_Producto_Favorito_IfNotExists()
        Try
            If TableExists("producto_favorito") Then
                ' La tabla ya existe, no es necesario hacer nada
                Return
            End If
            Dim stringConexion As String = ConfigurationManager.ConnectionStrings("conexionString").ConnectionString
            Using db As New SQLiteConnection(stringConexion)
                db.Open()
                SQL = "CREATE TABLE IF NOT EXISTS producto_favorito(
                            ID_Producto INTEGER PRIMARY KEY,
                            Posicion INTEGER NOT NULL,
                            BTN_Color INTEGER NOT NULL,
                            FOREIGN KEY(ID_Producto) REFERENCES producto(ID))
                        "
                Dim cmd As New SQLiteCommand(SQL, db)
                cmd.ExecuteNonQuery()
            End Using
        Catch ex As Exception
            ' Maneja cualquier error que ocurra durante la verificación o migración
            MessageBox.Show("Error al verificar o migrar la base de datos: " & ex.Message, "Error de Base de Datos", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Update_cierre_caja()
        Try
            If TableExists("CierreCaja") Then
                ' La tabla ya existe, no es necesario hacer nada
                Return
            End If
            Dim stringConexion As String = ConfigurationManager.ConnectionStrings("conexionString").ConnectionString
            Using db As New SQLiteConnection(stringConexion)
                db.Open()
                'Se elimina la tabla cierre_caja si existe (Esta es la vieja y no va a seguir siendo utilizada)
                SQL = "DROP TABLE IF EXISTS cierre_caja"
                Dim cmd As New SQLiteCommand(SQL, db)
                cmd.ExecuteNonQuery()

                'Se crea la nueva tabla cierre_caja si no existe
                SQL = "CREATE TABLE IF NOT EXISTS CierreCaja (
                        ID_Cierre INTEGER PRIMARY KEY,
                        Fecha_Hora_Inicio TEXT NOT NULL,
                        Fecha_Hora_Fin TEXT NOT NULL,
                        ID_Usuario INTEGER NOT NULL,
                        Saldo_Inicial REAL NOT NULL,
                        Ingreso_Efectivo REAL NOT NULL,
                        Ingreso_Tarjeta REAL NOT NULL,
                        Salidas_Efectivo REAL NOT NULL,
                        Efectivo_Contado REAL NOT NULL,
                        Comentarios TEXT,
                        FOREIGN KEY(ID_Usuario) REFERENCES Usuarios(ID_Usuario)
                    );"
                cmd = New SQLiteCommand(SQL, db)
                cmd.ExecuteNonQuery()
            End Using
        Catch ex As Exception
            ' Maneja cualquier error que ocurra durante la verificación o migración
            MessageBox.Show("Error al actualizar la tabla de cierre de caja" & ex.Message, "Error de Base de Datos", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' Función para verificar si una tabla existe en la base de datos
    Private Function TableExists(tableName As String) As Boolean
        Dim exists As Boolean = False
        Dim dbPath As String = "Data Source=mi_base_de_datos.db;Version=3;"

        Try
            Using conn As New SQLiteConnection(dbPath)
                conn.Open()
                Dim sql As String = $"SELECT name FROM sqlite_master WHERE type='table' AND name='{tableName}';"
                Using cmd As New SQLiteCommand(sql, conn)
                    Using reader As SQLiteDataReader = cmd.ExecuteReader()
                        If reader.HasRows Then
                            exists = True
                        End If
                    End Using
                End Using
            End Using
        Catch ex As Exception
            ' Puedes manejar el error o simplemente devolver False
            MessageBox.Show("Error al verificar la existencia de la tabla: " & ex.Message)
        End Try

        Return exists
    End Function
#End Region
End Module
