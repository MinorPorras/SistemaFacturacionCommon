Imports System.Configuration
Imports System.Data.SQLite
Imports System.IO
Imports System.Net
Imports System.Threading
Imports SistemaFacturaciónCommon.SistemaFacturacion.Forms.Inicio
Imports logger = SistemaFacturaciónCommon.SistemaFacturación.Modules.Md_LogSetup
Imports Velopack
Imports Velopack.Sources
Imports Velopack.Locators
Imports Velopack.Logging
Imports NuGet.Versioning
Imports Serilog
Imports Serilog.Context

' -----------------------------------------------------------------------------
' Módulo de inicialización y utilidades de configuración de la aplicación
' Incluye funciones para actualización, configuración y acceso a settings
' -----------------------------------------------------------------------------
Namespace SistemaFacturacion.Modules
    Module Md_Inicializacion
        Friend UpdateManagerInstance As UpdateManager
        Private Const REPO_OWNER As String = "MinorPorras"
        Private Const REPO_NAME As String = "SistemaFacturacionCommon"

        ' URL de las últimas releases en GitHub
        Friend ReadOnly GITHUB_REPO_URL As String = $"https://github.com/{REPO_OWNER}/{REPO_NAME}"
        Friend ReadOnly GITHUB_RELEASES_URL As String = $"{GITHUB_REPO_URL}/releases/latest"

        'Subrutina de inicio del proyecto debe de llamarse así y ser Public
        Public Sub Main()
            'Inicialización de configuración de serilog
            logger.ConfigLogger()

            'Definición del Mutex de para la instanciación única
            Const MutexName As String = "MiAplicacionFacturacionUnica"

            Dim createdNew As Boolean = False

            Dim m As New Mutex(True, MutexName, createdNew)

            If Not createdNew Then
                ' Si el Mutex ya existía, otra instancia se está ejecutando
                MsgError($"Otra instancia de la aplicación ya está en ejecución. Mutex: {MutexName}")
                Return ' Sale del Sub Main inmediatamente
            End If

            'Lógica de Velopack
            Using LogContext.PushProperty("Feature", "Velopack")
                VelopackApp.Build() _
                .OnFirstRun(AddressOf Md_VelopackHandlers.HandleFirstRun) _
                .OnBeforeUpdateFastCallback(AddressOf Md_VelopackHandlers.HandleBeforeUpdate) _
                .OnBeforeUninstallFastCallback(AddressOf Md_VelopackHandlers.HandleBeforeUninstall) _
                .OnRestarted(AddressOf Md_VelopackHandlers.HandleRestarted) _
                .OnAfterInstallFastCallback(AddressOf Md_VelopackHandlers.HandleInstall) _
                .Run()
            End Using

            UpdateManagerInstance = New UpdateManager(New GithubSource(GITHUB_REPO_URL, Nothing, False))

            ' Inicio de la aplicación
            Application.EnableVisualStyles()
            Application.SetCompatibleTextRenderingDefault(False)

            ' **Manejador Global de Excepciones**
            AddHandler Application.ThreadException, AddressOf Application_ThreadException
            AddHandler AppDomain.CurrentDomain.UnhandledException, AddressOf CurrentDomain_UnhandledException

            'Inicializaciones de la aplicación
            ' 1. Crear y mostrar la SplashScreen.
            Dim frmSplash As New P_SplashScreen
            frmSplash.Show()
            Log.Information("SplashScreen mostrada.")
            ' 2. Ejecutar la tarea de inicialización en segundo plano.
            ThreadPool.QueueUserWorkItem(AddressOf RealizarInicializaciones, frmSplash)

            ' Inicia la aplicación con el formulario que le indiquemos
            Application.Run()

            ' Ejemplo: Liberar recursos globales
            LimpiarConexionesDeBaseDeDatos()

            ' Ejemplo: Escribir un log de cierre
            Log.Information("La aplicación ha finalizado su ciclo de ejecución y se libera el mutex.")

            'Liberamos el Mutex
            If createdNew Then m.ReleaseMutex()
        End Sub

        Private Sub RealizarInicializaciones(stateInfo As Object)
            ' Obtener la referencia a la SplashScreen que pasamos.
            Dim frmSplash As P_SplashScreen = CType(stateInfo, P_SplashScreen)
            Try
                frmSplash.SwitchStateProgressIndicator(True)

                Dim locator As IVelopackLocator = VelopackLocator.Current
                Dim version As SemanticVersion = locator.CurrentlyInstalledVersion

                If version IsNot Nothing Then
                    frmSplash.setVersionLabel(version.ToString())
                End If

                frmSplash.UpdateStatus("Revisando por actualizaciones del sistema")
                Dim AutoUpdate As String = GetAppSetting("AutoUpdate")
                If AutoUpdate = "True" Then
                    CheckForUpdates().Wait()
                End If
                frmSplash.UpdateStatus("Inicializando la base de datos")
                InicializarDB()
                frmSplash.UpdateStatus("Inicializando configuraciones")
                InitConfigVaribles()
                frmSplash.UpdateStatus("Revisando la estructura de la base de datos" & vbCrLf & " y ejecutando migraciones")
                CheckAndMigrateDatabase()
                frmSplash.UpdateStatus("Inicialización finalizada")

                frmSplash.SwitchStateProgressIndicator(False)

                ' Usamos Invoke porque estamos en un hilo secundario y necesitamos
                ' interactuar con la interfaz de usuario.
                frmSplash.Invoke(Sub()
                                     Dim frmInicial As New P_SelectUsu
                                     frmInicial.Show()
                                     frmSplash.Close()
                                 End Sub)

            Catch ex As Exception
                MsgError("Error durante la inicialización: " & ex.Message)
            End Try
        End Sub

        Friend Sub LimpiarConexionesDeBaseDeDatos()
            ' Lista de las variables de conexión a limpiar (asumiendo que son SQLiteConnection)
            Dim conexiones = {Md_CONEXION.T, Md_CONEXION.T1, Md_CONEXION.T2,
                      Md_CONEXION.T3, Md_CONEXION.T4, Md_CONEXION.T5}

            ' Recorre todas las conexiones
            For Each conn In conexiones
                If conn IsNot Nothing Then
                    Try
                        conn.Dispose() ' Esto llama a Close() y libera recursos.
                    Catch ex As Exception
                        ' Opcional: Registrar el error si el dispose falla.
                        Log.Error("Error al liberar la conexión: {Message}", ex.Message)
                    End Try
                End If
            Next

            ' Limpieza de estado de la aplicación
            Md_CONEXION.idUsuActual = 0
            Md_CONEXION.nomUsuActual = "" ' Asignar cadena vacía es suficiente, no necesitas el If Not String.IsNullOrEmpty
            Md_CONEXION.CuentaAdmin = False
            Md_CONEXION.SQL = ""
            Log.Information("Datos de la aplicación limpiados")
        End Sub

        Private Sub Application_ThreadException(ByVal sender As Object, ByVal e As Threading.ThreadExceptionEventArgs)
            'Maneja errores en el hilo principal de la UI
            MsgError($"Error en la Interfaz de Usuario: {e.Exception.Message}")
        End Sub

        Private Sub CurrentDomain_UnhandledException(ByVal sender As Object, ByVal e As UnhandledExceptionEventArgs)
            ' Captura errores no manejados en hilos secundarios
            Dim ex As Exception = CType(e.ExceptionObject, Exception)
            MsgError($"Error Fatal de Aplicación: {ex.Message}. La aplicación debe cerrarse.")
            ' Forzar la salida si es un error fatal de hilo
            Application.Exit()
        End Sub


#Region "Actualizaciones"

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
        Friend Async Function CheckForUpdates() As Task(Of Boolean)
            Log.Information("Revisando actualizaciones")
            ' Verifica si la aplicación se está ejecutando en modo de depuración.
            ' Si es así, se omite la búsqueda de actualizaciones para evitar sobrescribir los archivos
            ' de desarrollo con los de una versión publicada.
#If DEBUG Then
            Mensaje("Está en modo Debug no se revisan nuevas versiones para evitar actualizaciónes que puedan perjudicar el código de nuevas versiones",
                    "Modo DEBUG", MessageBoxButtons.OK)
            Return False
#End If

            ' Verifica la conexión a Internet primero
            If Not HayConexionInternet() Then
                Log.Warning("No hay conexión a internet. No se puede buscar actualizaciones.")
                Mensaje("No hay conexión a internet. No se puede buscar actualizaciones.", "Sin conexión", MessageBoxButtons.OK)
                Return False
            End If

            Dim mgr = UpdateManagerInstance

            ' Si la aplicación no está instalada o si esta no está disponible
            ' para revisar o instalar actualizaciones
            If Not mgr.IsInstalled Then
                Log.Warning("Aplicación no instalada o no disponible para actualizar: IsInstalled:{installed}", mgr.IsInstalled)
                Return False
            End If
            Dim update As UpdateInfo = Await mgr.CheckForUpdatesAsync()
            ' SI no hya una nueva versión retorna false
            If update Is Nothing Then
                Log.Information("No hay versiones nuevas que instalar")
                Mensaje("La aplicación ya está actualizada.", "Sin actualizaciones", MessageBoxButtons.OK)
                Return False
            End If

            ' Notificar al usuario sobre la actualización disponible
            Dim frmUpdateAvailable As New P_UpdateAvailable()

            Dim htmlNotes As String = update.TargetFullRelease.NotesHTML
            frmUpdateAvailable.LoadReleaseNotes(update.TargetFullRelease.Version.ToString(), htmlNotes)

            Dim result = frmUpdateAvailable.ShowDialog()
            If result = DialogResult.Cancel Then
                ' El usuario decidió no actualizar
                Return False
            End If

            Dim progressReporter As New Action(Of Integer)(Sub(percent)
                                                               frmUpdateAvailable.updateDownloadProgress(percent) ' Asume que tienes este método
                                                           End Sub)

            Log.Information("escargando datos de la versión {version}", update.TargetFullRelease.Version)
            Await mgr.DownloadUpdatesAsync(update, progressReporter)

            Log.Information("Aplicando cambios de la versión {version} y reiniciando el sistema", update.TargetFullRelease.Version)
            'Aplicar la actualización y reiniciar el sistema
            mgr.ApplyUpdatesAndExit(update.TargetFullRelease)
            Return True

        End Function
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

            ' Actualiza o agrega la clave y valor
            Log.Information("Estableciendo configuración: {Key} = {Value}", key, value)
            If config.AppSettings.Settings(key) IsNot Nothing Then
                config.AppSettings.Settings(key).Value = value
            Else
                config.AppSettings.Settings.Add(key, value)
            End If

            ' Guarda los cambios
            Log.Information("Guardando cambios en el archivo de configuración: {ConfigPath}", configFilePath)
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
                Log.Information("Obteniendo configuración: {Key} = {Value}", key, config.AppSettings.Settings(key).Value)
                Return config.AppSettings.Settings(key).Value
            Else
                Log.Warning("La clave de configuración '{Key}' no existe. Retornando cadena vacía.", key)
                Return ""
            End If
        End Function

        ' Abre la ventana de configuración general y selecciona la pestaña indicada
        Public Sub EntrarConfig(index As Integer, owner As Form)
            Dim frmConf As New ConfigGeneral With {
                .InitialTabIndex = index
            }
            frmConf.Show(owner)
            frmConf.Select()
        End Sub

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
            Log.Information("Datos de la configuración inicializados")
        End Sub
#End Region

#End Region

#Region "Migraciones e inicialización de base de datos"

#Region "Metodos de migración generales"
        ' Se asumiría que esta lógica iría en un módulo de utilidades o archivo aparte
        Friend Sub MigrateDataFilesBeforeUpdate()
            ' Lógica omitida, ya que usas %AppData%. 
            ' Si no usaras %AppData%, aquí moverías archivos de la versión anterior a un lugar seguro.
            Log.Information("Omisión de migración de archivos: Los datos persistentes residen en %AppData% y no serán afectados por la actualización.")
        End Sub

        Friend Sub InicializarDB()
            Dim dbPersistentPath As String = GetDbPath()

            If Not File.Exists(dbPersistentPath) Then
                Try
                    ' 1. Obtiene la ruta del directorio donde se guardará la base de datos.
                    Dim dbDirectory As String = Path.GetDirectoryName(dbPersistentPath)

                    ' 2. Crea el directorio si no existe. Esto incluye la carpeta \DB.
                    If Not Directory.Exists(dbDirectory) Then
                        Directory.CreateDirectory(dbDirectory)
                    End If

                    ' 3. Ahora sí, copia la base de datos inicial a la ruta persistente.
                    Dim dbInicialPath As String = Path.Combine(Application.StartupPath, "bd\dbSistemaFacturacion.db")
                    File.Copy(dbInicialPath, dbPersistentPath)
                    Log.Information("Se inicializó la base de datos del usuario en: {userDB} desde la base de datos base en: {persistenDB}", dbInicialPath, dbPersistentPath)
                Catch ex As Exception
                    MsgError("Error al inicializar la base de datos: " & ex.Message)
                End Try
            End If
        End Sub

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
                MsgError("Error al verificar la existencia de la tabla: " & ex.Message)
            End Try

            Return exists
        End Function

        ' Función para verificar si una columna existe en una tabla específica en la base de datos
        Private Function ColumnExists(tableName As String, columnName As String) As Boolean
            Dim exists As Boolean = False

            Try
                Using conn As New SQLiteConnection(GetConnectionString())
                    conn.Open()

                    ' PRAGMA table_info(nombre_de_la_tabla) devuelve metadatos sobre todas las columnas de esa tabla.
                    ' El segundo campo ('name') del resultado contiene el nombre de la columna.
                    Dim sql As String = $"PRAGMA table_info('{tableName}');"

                    Using cmd As New SQLiteCommand(sql, conn)
                        Using reader As SQLiteDataReader = cmd.ExecuteReader()
                            ' Itera sobre todas las filas (columnas) devueltas
                            While reader.Read()
                                ' La columna que contiene el nombre de la columna en PRAGMA table_info es la segunda (índice 1).
                                ' Verifica si el nombre de la columna leída (reader.GetString(1)) coincide con el nombre buscado.
                                If String.Equals(reader.GetString(1), columnName, StringComparison.OrdinalIgnoreCase) Then
                                    exists = True
                                    Exit While ' Columna encontrada, podemos salir del bucle
                                End If
                            End While
                        End Using
                    End Using
                End Using
            Catch ex As Exception
                ' Mostrar el error si la conexión falla o la tabla no existe (opcional, para depuración)
                MsgError($"Error al verificar la existencia de la columna '{columnName}' en la tabla '{tableName}'")
                Log.Error("Error: {error}", ex.Message)
            End Try

            Return exists
        End Function

        Friend Sub CheckAndMigrateDatabase()
            Using LogContext.PushProperty("Features", "Migraciones")
                Try
                    Log.Information("Iniciando verificación y migración de la base de datos")
                    ' 1. Creación/Verificación de la tabla 'producto_favorito'
                    Log.Information("Verificando/Creando la tabla 'producto_favorito'")
                    If Not InicializarProductoFavorito() Then
                        ' Si falla la inicialización (devuelve False)
                        Throw New Exception("Fallo en la inicialización de la tabla 'producto_favorito'.")
                    End If

                    ' 2. Creación/Actualización/Migración del esquema de Caja
                    Log.Information("Verificando/Actualizando/Migrando el esquema de cierre de caja")
                    Update_cierre_caja()

                    ' 3. Creación de las tablas para el manejo de las cuentas por cobrar
                    Log.Information("Verificando/Creando las tablas para el manejo de las cuentas por cobrar")
                    If Not InicializarCuentasXCobrar() Then
                        ' Si falla la inicialización (devuelve False)
                        Throw New Exception("Fallo en la inicialización de las cuentas por cobrar.")
                    End If

                    Log.Information("Verificación y migración de la base de datos completada exitosamente")
                Catch ex As Exception
                    ' Maneja cualquier error que ocurra durante la verificación o migración
                    MsgError("Error general al verificar o migrar la base de datos: " & ex.Message)
                End Try
            End Using
        End Sub
#End Region

#Region "Inicialización de productos favoritos"
        Private Function InicializarProductoFavorito() As Boolean
            ' Si la tabla ya existe, salimos inmediatamente del delegado ya que ya se creó.
            If TableExists("producto_favorito") Then
                Log.Information("La tabla 'producto_favorito' ya existe. No se requiere creación.")
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
                    Log.Error("Fallo al crear la tabla 'producto_favorito'.")
                    Throw New Exception("Fallo al crear la tabla producto_favorito.")
                End If
            End Sub

            ' Ejecutamos la transacción maestra.
            Log.Information("Creando la tabla 'producto_favorito'.")
            Return EJECUTAR_TRANSACCION(operaciones)
        End Function

#End Region

#Region "Inialización cierre de caja"
        Private Sub Update_cierre_caja()
            ' Si la nueva estructura ya existe, salimos inmediatamente.
            If TableExists("Movimientos_Caja") Then
                Log.Information("La estructura de cierre de caja ya está actualizada. No se requiere migración.")
                Exit Sub
            End If

            Dim exito As Boolean = False

            ' 1. Determinar el modo (Migración o Creación Inicial)
            If TableExists("CierreCaja") Then
                ' Modo 1: Migración (la tabla antigua existe)
                Log.Information("La tabla 'CierreCaja' existe. Iniciando migración al nuevo esquema de cierre de caja.")
                exito = InicializaciónActualizaciónCierreCaja(True)
            Else
                ' Modo 2: Creación Inicial (la tabla antigua NO existe)
                Log.Information("La tabla 'CierreCaja' no existe. Iniciando creación del nuevo esquema de cierre de caja.")
                exito = InicializaciónActualizaciónCierreCaja(False)
            End If

            ' 2. Verificar el resultado y lanzar excepción si falló el COMMIT/ROLLBACK
            If Not exito Then
                ' Esto será capturado por el CATCH de CheckAndMigrateDatabase.
                Log.Error("La actualización de la base de datos falló y se deshicieron los cambios. Error al actualizar el esquema de cierre de caja")
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
                Log.Error("Fallo al crear la tabla 'Tipos_Movimiento'.")
                Return False
            End If

            SQL = "INSERT OR IGNORE INTO Tipos_Movimiento VALUES (1, 'Entrada', 1), (2, 'Salida', -1)"
            Log.Information("Insertando valores iniciales en 'Tipos_Movimiento'.")
            Return EJECUTAR_PARAMETROS_TRANSACCION(SQL, param, db, transaccion)
        End Function

        Private Function InicializarConceptosCaja(db As SQLiteConnection, transaccion As SQLiteTransaction) As Boolean
            ' Se crea la tabla de Conceptos_Caja
            ' Debe de tener ID, concepto
            SQL = "CREATE TABLE IF NOT EXISTS Conceptos_Caja (
                            ID INTEGER PRIMARY KEY,
                            concepto TEXT,
                            ID_Tipo_Movimiento INTEGER,
                            FOREIGN KEY(ID_Tipo_Movimiento) REFERENCES Tipos_Movimiento(ID))"
            Dim param As New Dictionary(Of String, Object)
            If Not EJECUTAR_PARAMETROS_TRANSACCION(SQL, param, db, transaccion) Then
                'Significa que hubo un error en la transacción
                Log.Error("Fallo al crear la tabla 'Conceptos_Caja'.")
                Return False
            End If

            SQL = "INSERT OR IGNORE INTO Conceptos_Caja VALUES (1, 'Ajuste', 1), (2, 'Pago a proveedores', 2)"
            Log.Information("Insertando valores iniciales en 'Conceptos_Caja'.")
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
                Log.Error("Fallo al crear la tabla 'Arqueo_Caja'.")
                Return False
            End If
            Log.Information("Tabla 'Arqueo_Caja' creada exitosamente.")


            If Not isMigrating And success Then
                ' Si no estamos migrando, solo creamos la tabla y salimos
                Log.Information("No se requiere migración. La tabla 'Arqueo_Caja' fue creada exitosamente.")
                Return True
            End If

            ' 2. MIGRAR LOS DATOS HISTÓRICOS
            SQL = "INSERT INTO Arqueo_Caja (ID, ID_Usuario, fondo_inicial, hora_apertura, hora_cierre, efectivo_contado, diferencia) " &
                  "SELECT ID_Cierre, ID_Usuario, Saldo_Inicial, Fecha_Hora_Inicio, Fecha_Hora_Fin, Efectivo_Contado, " &
                  "(Efectivo_Contado - (Saldo_Inicial + Ingreso_Efectivo - Salidas_Efectivo)) " &
                  "FROM CierreCaja"
            If Not EJECUTAR_PARAMETROS_TRANSACCION(SQL, param, db, transaccion) Then
                'Significa que hubo un error en la transacción
                Log.Error("Fallo al migrar los datos de 'CierreCaja' a 'Arqueo_Caja'.")
                Return False
            End If

            ' 3. ELIMINAR LA TABLA ANTIGUA
            SQL = "DROP TABLE CierreCaja"
            Log.Information("Eliminando la tabla antigua 'CierreCaja' después de la migración.")
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
                            fecha_hora TEXT,
                            FOREIGN KEY(ID_tipo_movimiento) REFERENCES Tipos_Movimiento(ID),
                            FOREIGN KEY(ID_concepto) REFERENCES Conceptos_Caja(ID),
                            FOREIGN KEY(ID_arqueo) REFERENCES Arqueo_Caja(ID))"
            Dim param As New Dictionary(Of String, Object)
            Log.Information("Creando la tabla 'Movimientos_Caja'.")
            Return EJECUTAR_PARAMETROS_TRANSACCION(SQL, param, db, transaccion)
        End Function

        Private Function InicializaciónActualizaciónCierreCaja(isMigrating As Boolean) As Boolean ' Se recomienda que devuelva Boolean
            Using LogContext.PushProperty("Inicialización", "CierreCaja")
                Log.Information("Iniciando la inicialización/actualización del esquema de cierre de caja. Modo Migración: {isMigrating}", isMigrating)

                ' Se define un delegado que contiene todas las operaciones de creación
                Dim operacionesDeGuardado As Action(Of SQLiteConnection, SQLiteTransaction) =
                Sub(conn, transaction)
                    ' Aseguramos que todas las llamadas dentro de la transacción sean exitosas
                    ' Usamos la lógica de Throw si alguna falla para forzar el Rollback en EJECUTAR_TRANSACCION
                    If Not InicializarTiposMovimientos(conn, transaction) Then
                        Log.Error("Fallo al crear Tipos_Movimiento.")
                        Throw New Exception("Fallo al crear Tipos_Movimiento.")
                    End If
                    If Not InicializarConceptosCaja(conn, transaction) Then
                        Log.Error("Fallo al crear Conceptos_Caja.")
                        Throw New Exception("Fallo al crear Conceptos_Caja.")
                    End If
                    If Not InicializarArqueoCaja(conn, transaction, isMigrating) Then
                        Log.Error("Fallo al crear Arqueo_Caja.")
                        Throw New Exception("Fallo al crear Arqueo_Caja.")
                    End If
                    If Not InicializarMovimientosCaja(conn, transaction) Then
                        Log.Error("Fallo al crear Movimientos_Caja.")
                        Throw New Exception("Fallo al crear Movimientos_Caja.")
                    End If
                End Sub

                ' Ejecutamos todas las operaciones a través de la función maestra
                ' que maneja la apertura, el commit y el rollback automáticamente.
                Log.Information("Ejecutando la transacción para inicializar/actualizar el esquema de cierre de caja.")
                Return EJECUTAR_TRANSACCION(operacionesDeGuardado)
            End Using
        End Function
#End Region

#Region "Inicialización de cuentas por cobrar"

        Private Function InicializarCuentasXCobrar() As Boolean
            If TableExists("CC_Encabezado") Then
                Log.Information("La tabla 'CC_Encabezado' ya existe. No se requiere creación.")
                Return True
            End If
            Dim op As Action(Of SQLiteConnection, SQLiteTransaction) =
                Sub(conn, transaccion)
                    If Not InicializarTablaCuentasXCobrar(conn, transaccion) Then
                        Log.Error("Fallo al crear CC_Encabezado.")
                        Throw New Exception("Fallo al crear CC_Encabezado.")
                    End If
                    If Not InicializarDetalleCuentasXCobrar(conn, transaccion) Then
                        Log.Error("Fallo al crear CC_DetalleProducto.")
                        Throw New Exception("Fallo al crear CC_DetalleProducto.")
                    End If
                    If Not InicializarPagosCuentasXCobrar(conn, transaccion) Then
                        Log.Error("Fallo al crear CC_Pagos.")
                        Throw New Exception("Fallo al crear CC_Pagos.")
                    End If
                    If Not DeleteCobradaColumn(conn, transaccion) Then
                        Log.Error("Fallo al eliminar la columna 'cobrada' de la tabla 'factura'.")
                        Throw New Exception("Fallo al eliminar la columna 'cobrada'")
                    End If
                End Sub
            Return EJECUTAR_TRANSACCION(op)
        End Function

        Private Function InicializarTablaCuentasXCobrar(db As SQLiteConnection, transaction As SQLiteTransaction) As Boolean
            SQL = "CREATE TABLE CC_Encabezado (
                    ID INTEGER PRIMARY KEY AUTOINCREMENT,
                    ID_Cliente INTEGER NOT NULL,
                    fecha_creacion DATETIME NOT NULL,
                    saldo_total DECIMAL(10, 2) NOT NULL,
                    comentario TEXT,
                    estado INTEGER NOT NULL,
                    FOREIGN KEY (ID_Cliente) REFERENCES Clientes(ID))"
            Dim param As New Dictionary(Of String, Object)
            Log.Information("Creando la tabla 'CC_Encabezado'.")
            Return EJECUTAR_PARAMETROS_TRANSACCION(SQL, param, db, transaction)
        End Function

        Private Function InicializarDetalleCuentasXCobrar(db As SQLiteConnection, transaction As SQLiteTransaction) As Boolean
            SQL = "CREATE TABLE CC_DetalleProducto (
                    ID INTEGER PRIMARY KEY AUTOINCREMENT,
                    ID_Encabezado INTEGER NOT NULL,
                    ID_Producto INTEGER,
                    cantidad DECIMAL(10, 2) NOT NULL,
                    precio DECIMAL(10, 2) NOT NULL,
                    total_linea DECIMAL(10, 2) NOT NULL,
                    FOREIGN KEY (ID_Encabezado) REFERENCES CC_Encabezado(ID) ON DELETE CASCADE
                    FOREIGN KEY(ID_Producto) REFERENCES producto(ID))"
            Dim param As New Dictionary(Of String, Object)
            Log.Information("Creando la tabla 'CC_DetalleProducto'.")
            Return EJECUTAR_PARAMETROS_TRANSACCION(SQL, param, db, transaction)
        End Function

        Private Function InicializarPagosCuentasXCobrar(db As SQLiteConnection, transaction As SQLiteTransaction) As Boolean
            SQL = "CREATE TABLE CC_Pagos (
                    ID INTEGER PRIMARY KEY AUTOINCREMENT,
                    ID_Usuario INTEGER NOT NULL,
                    ID_Encabezado INTEGER NOT NULL,
                    fecha DATETIME NOT NULL,
                    tipo_venta NVARCHAR(50),
                    monto_efectivo DECIMAL(10, 2),
                    monto_tarjeta DECIMAL(10, 2),
                    vuelto DECIMAL(10, 2),
                    comentario NVARCHAR(255),
                    FOREIGN KEY (ID_Encabezado) REFERENCES CC_Encabezado(ID) ON DELETE CASCADE,
                    FOREIGN KEY (ID_Usuario) REFERENCES usuario(ID))"
            Dim param As New Dictionary(Of String, Object)
            Log.Information("Creando la tabla 'CC_Pagos'.")
            Return EJECUTAR_PARAMETROS_TRANSACCION(SQL, param, db, transaction)
        End Function

        Private Function DeleteCobradaColumn(db As SQLiteConnection, transaction As SQLiteTransaction) As Boolean
            If ColumnExists("factura", "cobrada") Then
                SQL = "ALTER TABLE factura DROP COLUMN cobrada"
                Dim param As New Dictionary(Of String, Object)
                Log.Information("Eliminando la columna 'cobrada' de la tabla 'factura'.")
                Return EJECUTAR_PARAMETROS_TRANSACCION(SQL, param, db, transaction)
            End If
            Log.Information("La columna 'cobrada' no existe en la tabla 'factura'. No se requiere eliminación.")
            Return True
        End Function
#End Region
#End Region
    End Module

End Namespace
