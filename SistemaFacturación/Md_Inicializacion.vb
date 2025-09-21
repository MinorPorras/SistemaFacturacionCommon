Imports System.Configuration
Imports System.Data.SQLite
Imports System.IO
Imports System.Net
Imports System.Web.Util
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
        If AutoUpdate = False Then
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
    ' Declara una variable privada para el directorio de la aplicación
    Friend ReadOnly appRootDirectory As String = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "CommonSistemaDeFacturacion")

    ' Centraliza la creación del directorio de la aplicación
    Friend Sub EnsureAppDirectoryExists()
        If Not Directory.Exists(appRootDirectory) Then
            Directory.CreateDirectory(appRootDirectory)
        End If
    End Sub

    ' Método para obtener el directorio raíz de la aplicación
    Friend Function GetAppDirectory() As String
        EnsureAppDirectoryExists()
        Return appRootDirectory
    End Function


    ' Establece o actualiza un valor en appSettings
    Sub SetAppSetting(key As String, value As String)
        ' Obtiene la ruta del archivo de configuración del usuario
        EnsureAppDirectoryExists()
        Dim configFilePath As String = Path.Combine(appRootDirectory, "app.config")

        ' Carga el archivo de configuración desde la nueva ruta
        Dim config = ConfigurationManager.OpenMappedExeConfiguration(New ExeConfigurationFileMap() With {.ExeConfigFilename = configFilePath}, ConfigurationUserLevel.None)

        If config.AppSettings.Settings(key) IsNot Nothing Then
            config.AppSettings.Settings(key).Value = value
        Else
            config.AppSettings.Settings.Add(key, value)
        End If

        ' Guarda los cambios
        config.Save(ConfigurationSaveMode.Modified)
        ConfigurationManager.RefreshSection("appSettings")
    End Sub

    ' Obtiene el valor de una clave de appSettings
    ' Obtiene un valor de appSettings
    Function GetAppSetting(key As String) As String
        EnsureAppDirectoryExists()
        Dim configFilePath As String = Path.Combine(appRootDirectory, "app.config")

        Dim config = ConfigurationManager.OpenMappedExeConfiguration(New ExeConfigurationFileMap() With {.ExeConfigFilename = configFilePath}, ConfigurationUserLevel.None)

        If config.AppSettings.Settings(key) IsNot Nothing Then
            Return config.AppSettings.Settings(key).Value
        Else
            Return ""
        End If
    End Function

    ' Abre la ventana de configuración general y selecciona la pestaña indicada
    Public Sub entrarConfig(index As Integer)
        ConfigGeneral.Show()
        ConfigGeneral.Select()
        ConfigGeneral.TCO_Config.SelectedIndex = index
    End Sub
#End Region

#Region "Inicialización de configuraciones"
    Friend Sub InitConfigVaribles()
        ' Asegura que el directorio de la aplicación exista
        EnsureAppDirectoryExists()

        Dim licencia As String = ConfigurationManager.AppSettings("Syncfusion.Licensing")
        Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense(licencia)

        ' Define las configuraciones y sus valores predeterminados
        Dim defaultSettings As New Dictionary(Of String, String) From {
        {"DirectorioRespaldo", Path.Combine(appRootDirectory, "Respaldo")},
        {"DirectorioDescargaReportes", Path.Combine(appRootDirectory, "Reportes")},
        {"AutoCodCajero", "2"},
        {"AutoCodCliente", "2"},
        {"AutoCodProv", "2"},
        {"AutoCodImp", "2"},
        {"AutoCodCat", "2"},
        {"AutoCodMarca", "3"},
        {"AutoCodProd", "4"},
        {"AutoUpdate", "False"},
        {"FontSizeProd", "16"},
        {"FontSizePrecio", "16"},
        {"Logo", Path.Combine(Application.StartupPath, "recursos", "ICO_Image.png")},
        {"Empresa", "Nombre"},
        {"Telefono", "1111-1111"},
        {"Correo", "ejemplo@gmail.com"}
    }

        ' Recorre la lista, crea la configuración si no existe y asegura que las carpetas se creen
        For Each setting In defaultSettings
            If String.IsNullOrEmpty(GetAppSetting(setting.Key)) Then
                ' Establece la configuración
                SetAppSetting(setting.Key, setting.Value)

                ' Si la configuración es un directorio, lo crea si no existe
                If setting.Key = "DirectorioRespaldo" OrElse setting.Key = "DirectorioDescargaReportes" Then
                    If Not Directory.Exists(setting.Value) Then
                        Directory.CreateDirectory(setting.Value)
                    End If
                End If
            End If
        Next
    End Sub
#End Region

#Region "Migraciones e inicialización de base de datos"
    Friend Sub inicializarDB()
        Dim dbPersistentePath As String = GetDbPath()

        If Not File.Exists(dbPersistentePath) Then
            Try
                ' 1. Obtiene la ruta del directorio donde se guardará la base de datos.
                Dim dbDirectory As String = Path.GetDirectoryName(dbPersistentePath)

                ' 2. Crea el directorio si no existe. Esto incluye la carpeta \DB.
                If Not Directory.Exists(dbDirectory) Then
                    Directory.CreateDirectory(dbDirectory)
                End If

                ' 3. Ahora sí, copia la base de datos inicial a la ruta persistente.
                Dim dbInicialPath As String = Path.Combine(Application.StartupPath, "bd\dbSistemaFacturacion.db")
                File.Copy(dbInicialPath, dbPersistentePath)
            Catch ex As Exception
                MsgBox("Error al inicializar la base de datos: " & ex.Message, MsgBoxStyle.Exclamation, "Error")
            End Try
        End If
    End Sub


    Friend Sub CheckAndMigrateDatabase()
        Try
            ' 1. Creación/Verificación de la tabla 'producto_favorito'
            If Not InicializarProductoFavorito() Then
                ' Si falla la inicialización (devuelve False), lanzamos una excepción con un mensaje claro.
                Throw New Exception("Fallo en la inicialización de la tabla 'producto_favorito'.")
            End If

            ' 2. Creación/Actualización/Migración del esquema de Caja
            Update_cierre_caja()

        Catch ex As Exception
            ' Maneja cualquier error que ocurra durante la verificación o migración
            msgError("Error general al verificar o migrar la base de datos: " & vbCrLf & vbCrLf & ex.Message)
        End Try
    End Sub

    Private Function InicializarProductoFavorito() As Boolean
        ' Si la tabla ya existe, salimos inmediatamente del delegado ya que ya se creó.
        If TableExists("producto_favorito") Then
            Return True
        End If
        ' Se define el delegado que contiene la operación de creación.
        Dim operaciones As Action(Of SQLiteConnection, SQLiteTransaction) =
        Sub(conn, transaction)

            ' SQL para la creación de la tabla
            SQL = "CREATE TABLE IF NOT EXISTS producto_favorito(
                       ID_Producto INTEGER PRIMARY KEY,
                       Posicion INTEGER NOT NULL,
                       BTN_Color INTEGER NOT NULL,
                       FOREIGN KEY(ID_Producto) REFERENCES producto(ID)
                     )"

            Dim param As New Dictionary(Of String, Object)

            ' Si la ejecución falla, lanzamos una excepción para que EJECUTAR_TRANSACCION haga el Rollback.
            If Not EJECUTAR_PARAMETROS_TRANSACCION(SQL, param, conn, transaction) Then
                Throw New Exception("Fallo al crear la tabla producto_favorito.")
            End If
        End Sub

        ' Ejecutamos la transacción maestra.
        Return EJECUTAR_TRANSACCION(operaciones)
    End Function

    Private Sub Update_cierre_caja()
        ' Si la nueva estructura ya existe, salimos inmediatamente.
        If TableExists("Movimientos_Caja") Then
            Exit Sub
        End If

        Dim exito As Boolean = False

        ' 1. Determinar el modo (Migración o Creación Inicial)
        If TableExists("CierreCaja") Then
            ' Modo 1: Migración (la tabla antigua existe)
            exito = InicializaciónActualizaciónCierreCaja(True)
        Else
            ' Modo 2: Creación Inicial (la tabla antigua NO existe)
            exito = InicializaciónActualizaciónCierreCaja(False)
        End If

        ' 2. Verificar el resultado y lanzar excepción si falló el COMMIT/ROLLBACK
        If Not exito Then
            ' Esto será capturado por el CATCH de CheckAndMigrateDatabase.
            Throw New Exception("La actualización de la base de datos falló y se deshicieron los cambios.")
        End If
    End Sub

    Private Function InicializarTiposMovimientos(db As SQLiteConnection, transaccion As SQLiteTransaction) As Boolean
        ' Se crea la tabla de Tipos_Movimiento
        ' Debe de tener ID, nombre y valor (1 para entradas -1 para salidas, esto para facilitar los calculos)
        SQL = "CREATE TABLE IF NOT EXISTS Tipos_Movimiento (
                            ID INTEGER PRIMARY KEY,
                            nombre TEXT,
                            Valor INTEGER)"
        Dim param As New Dictionary(Of String, Object)

        If Not EJECUTAR_PARAMETROS_TRANSACCION(SQL, param, db, transaccion) Then
            'Significa que hubo un error en la transacción
            Return False
        End If

        SQL = "INSERT OR IGNORE INTO Tipos_Movimiento VALUES (1, 'Entrada', 1), (2, 'Salida', -1)"
        Return EJECUTAR_PARAMETROS_TRANSACCION(SQL, param, db, transaccion)
    End Function

    Private Function InicializarConceptosCaja(db As SQLiteConnection, transaccion As SQLiteTransaction) As Boolean
        ' Se crea la tabla de Conceptos_Caja
        ' Debe de tener ID, concepto
        SQL = "CREATE TABLE IF NOT EXISTS Conceptos_Caja (
                            ID INTEGER PRIMARY KEY,
                            concepto TEXT)"
        Dim param As New Dictionary(Of String, Object)
        If Not EJECUTAR_PARAMETROS_TRANSACCION(SQL, param, db, transaccion) Then
            'Significa que hubo un error en la transacción
            Return False
        End If

        SQL = "INSERT OR IGNORE INTO Conceptos_Caja VALUES (1, 'Ajuste'), (2, 'Pago a proveedores')"
        Return EJECUTAR_PARAMETROS_TRANSACCION(SQL, param, db, transaccion)
    End Function

    Private Function InicializarArqueoCaja(db As SQLiteConnection, transaccion As SQLiteTransaction, isMigrating As Boolean) As Boolean
        ' 1. Se crea la tabla de Arqueo_Caja para pasar los datos de la tabla de cierreCaja
        ' Debe de tener ID, fondo_inicial, hora_apertura, hora_cierre, efectivo_contado, diferencia
        SQL = "CREATE TABLE IF NOT EXISTS Arqueo_Caja (
                            ID INTEGER PRIMARY KEY,
                            ID_Usuario INTEGER,
                            fondo_inicial REAL,
                            hora_apertura TEXT,
                            hora_cierre TEXT,
                            efectivo_contado REAL,
                            diferencia REAL,
                            FOREIGN KEY(ID_Usuario) REFERENCES Usuarios(ID_Usuario))"
        Dim param As New Dictionary(Of String, Object)
        Dim success = EJECUTAR_PARAMETROS_TRANSACCION(SQL, param, db, transaccion)
        If Not success Then
            'Significa que hubo un error en la transacción
            Return False
        End If


        If Not isMigrating And success Then
            Return True
        End If

        ' 2. MIGRAR LOS DATOS HISTÓRICOS
        SQL = "INSERT INTO Arqueo_Caja (ID, ID_Usuario, fondo_inicial, hora_apertura, hora_cierre, efectivo_contado, diferencia) " &
              "SELECT ID_Cierre, ID_Usuario, Saldo_Inicial, Fecha_Hora_Inicio, Fecha_Hora_Fin, Efectivo_Contado, " &
              "(Efectivo_Contado - (Saldo_Inicial + Ingreso_Efectivo - Salidas_Efectivo)) " &
              "FROM CierreCaja"
        If Not EJECUTAR_PARAMETROS_TRANSACCION(SQL, param, db, transaccion) Then
            'Significa que hubo un error en la transacción
            Return False
        End If

        ' 3. ELIMINAR LA TABLA ANTIGUA
        SQL = "DROP TABLE CierreCaja"
        Return EJECUTAR_PARAMETROS_TRANSACCION(SQL, param, db, transaccion)
    End Function

    Private Function InicializarMovimientosCaja(db As SQLiteConnection, transaccion As SQLiteTransaction) As Boolean
        ' Se crea la tabla de Movimientos_Caja
        ' Debe de tener ID, monto, ID_tipo_movimiento, ID_concepto, ID_arqueo, referencia
        SQL = "CREATE TABLE IF NOT EXISTS Movimientos_Caja (
                            ID INTEGER PRIMARY KEY,
                            monto REAL,
                            ID_tipo_movimiento INTEGER,
                            ID_concepto INTEGER,
                            ID_arqueo INTEGER,
                            referencia TEXT,
                            FOREIGN KEY(ID_tipo_movimiento) REFERENCES Tipos_Movimiento(ID),
                            FOREIGN KEY(ID_concepto) REFERENCES Conceptos_Caja(ID),
                            FOREIGN KEY(ID_arqueo) REFERENCES Arqueo_Caja(ID))"
        Dim param As New Dictionary(Of String, Object)
        Return EJECUTAR_PARAMETROS_TRANSACCION(SQL, param, db, transaccion)
    End Function

    Private Function InicializaciónActualizaciónCierreCaja(isMigrating As Boolean) As Boolean ' Se recomienda que devuelva Boolean
        ' Se define un delegado que contiene todas las operaciones de creación
        Dim operacionesDeGuardado As Action(Of SQLiteConnection, SQLiteTransaction) =
        Sub(conn, transaction)
            ' Aseguramos que todas las llamadas dentro de la transacción sean exitosas
            ' Usamos la lógica de Throw si alguna falla para forzar el Rollback en EJECUTAR_TRANSACCION

            If Not InicializarTiposMovimientos(conn, transaction) Then Throw New Exception("Fallo al crear Tipos_Movimiento.")
            If Not InicializarConceptosCaja(conn, transaction) Then Throw New Exception("Fallo al crear Conceptos_Caja.")
            If Not InicializarArqueoCaja(conn, transaction, isMigrating) Then Throw New Exception("Fallo al crear Arqueo_Caja.")
            If Not InicializarMovimientosCaja(conn, transaction) Then Throw New Exception("Fallo al crear Movimientos_Caja.")
        End Sub

        ' Ejecutamos todas las operaciones a través de la función maestra
        ' que maneja la apertura, el commit y el rollback automáticamente.
        Return EJECUTAR_TRANSACCION(operacionesDeGuardado)
    End Function

    ' Función para verificar si una tabla existe en la base de datos
    Private Function TableExists(tableName As String) As Boolean
        Dim exists As Boolean = False

        Try
            Using conn As New SQLiteConnection(GetConnectionString())
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
