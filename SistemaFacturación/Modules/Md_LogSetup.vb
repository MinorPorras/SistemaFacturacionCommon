Imports System.Diagnostics
Imports System.IO
Imports System.Reflection
Imports Serilog
Imports Serilog.Formatting.Compact
Imports SistemaFacturaciónCommon.SistemaFacturacion.Modules.Md_Inicializacion
Imports Velopack.Locators
Namespace SistemaFacturación.Modules
    ''' <summary>
    ''' Módulo para configurar el sistema de logging utilizando Serilog.
    ''' </summary>
    Module Md_LogSetup
        ''' <summary>
        ''' Configuración inicial del logger.
        ''' </summary>
        Friend Sub ConfigLogger()
            Dim appVersion As String = "Unknown"

            Try
                appVersion = Assembly.GetExecutingAssembly().GetName().Version.ToString()
            Catch ex As Exception
                appVersion = "FallbackError"
            End Try

            'Detecta si el directorio de logs existe, si no, lo crea
            EnsureAppDirectoryExists()

            Dim logDir As String = Path.Combine(appRootDirectory, "Logs")

            ' Configuración de Serilog
            Log.Logger = New LoggerConfiguration() _
                .MinimumLevel.Information() _
                .Enrich.WithMachineName() _
                .Enrich.WithProcessId() _
                .Enrich.WithThreadId() _
                .Enrich.WithProperty("AppVersion", appVersion) _
                .WriteTo.Console() _
                .WriteTo.File(
                    formatter:=New RenderedCompactJsonFormatter(),
                    path:=Path.Combine(logDir, "log-.json"),
                    rollingInterval:=RollingInterval.Day,
                    retainedFileCountLimit:=14,
                    shared:=True) _
                .CreateLogger()

            Log.Information("Logger inicializado. AppVersion: {Version}", appVersion)
        End Sub
    End Module
End Namespace

