Imports NuGet.Versioning
Imports System.IO
Imports Serilog


Namespace SistemaFacturacion.Modules
    ''' <summary>
    ''' Módulo para manejar eventos de Velopack como instalación, actualización y desinstalación.
    ''' </summary>
    Module Md_VelopackHandlers
        ' --- FAST CALLBACK HOOKS (Se ejecutan y terminan el proceso) ---
        Friend Sub HandleInstall(ByVal Version As SemanticVersion)
            ' Acciones a realizar durante la instalación de Velopack
            Log.Information($"Instalación completada. Versión: {Version}", TraceEventType.Information)

            ' Lógica de Acceso Directo Personalizada (Opcional, si vpk no lo hace)
            ' mgr.CreateShortcut("Sistema Facturacion")
        End Sub

        ' Se ejecuta en el primer inicio después de una instalación limpia (Instalación Inicial)
        Friend Sub HandleFirstRun(ByVal Version As SemanticVersion)
            Log.Information("Hook FirstRun ejecutado. Instalación inicial de la versión {Version}.", Version)

            ' Crear accesos directos o archivos de configuración iniciales.
            ' Nota: Velopack a menudo maneja los accesos directos automáticamente si se usa vpk.
            ' Si necesitas algo personalizado, aquí va.
            ' Velopack.UpdateManager.CreateShortcut("Sistema Facturacion")
        End Sub

        ' Se ejecuta justo antes de que se aplique una actualización
        Friend Sub HandleBeforeUpdate(ByVal Version As SemanticVersion)
            Log.Warning("Hook BeforeUpdate ejecutado. Preparando para actualizar a la versión {Version}. CERRANDO CONEXIONES.", Version)

            LimpiarConexionesDeBaseDeDatos()
            ' Aquí es donde debes ejecutar la lógica de migración de datos (ej. SQLite) 
            ' antes de que los archivos antiguos sean reemplazados.

            ' Asegúrate de que todas las conexiones a la DB (SQLite) o archivos locales CRÍTICOS
            ' estén cerrados o liberados, para que el instalador pueda reemplazarlos.
            MigrateDataFilesBeforeUpdate()
        End Sub

        ' Se ejecuta si la aplicación se reinició automáticamente después de una actualización
        Friend Sub HandleRestarted(ByVal Version As SemanticVersion)
            Log.Information(
                "Hook Restarted ejecutado. Aplicación reiniciada automáticamente después de actualizar a la versión {Version}.", Version
                )
        End Sub

        ' Se ejecuta cuando el usuario desinstala la aplicación
        Friend Sub HandleBeforeUninstall()
            Log.Information("Hook BeforeUninstall ejecutado. Limpiando datos de la aplicación.")

            ' Limpieza de la base de datos
            Dim dbpath As String = Path.Combine(GetAppDirectory(), "DB")

            If Directory.Exists(dbpath) Then
                Try
                    Log.Information("Eliminando directorio de la base de datos de la aplicación: {dbPath}", dbpath)
                    Directory.Delete(dbpath, True)
                Catch ex As Exception
                    Log.Error(ex, "Error al eliminar el directorio de la base de datos de la aplicación durante la desinstalación.")
                End Try
            Else
                Log.Warning("El directorio de datos ({dbPath}) ya estaba ausente. No se necesita limpieza.", dbpath)
            End If

            ' Limpieza de los archov de logs
            Dim configPath As String = Path.Combine(GetAppDirectory(), "app.config")

            If File.Exists(configPath) Then
                Try
                    Log.Information("Eliminando el archivo de configuración de la aplicación: {logPath}", configPath)
                    File.Delete(configPath)
                Catch ex As IOException
                    Log.Error(ex, "Error al eliminar el archivo de configuración de la aplicación durante la desinstalación. El archivo no puede ser eliminado")
                Catch ex As UnauthorizedAccessException
                    Log.Error(ex, "Error al eliminar el archivo de configuración de la aplicación durante la desinstalación. Permisos insuficientes.")
                Catch ex As Exception
                    Log.Error(ex, "Error al eliminar el archivo de configuración de la aplicación durante la desinstalación.")
                End Try
            Else
                Log.Warning("El archivo de configuración ({logPath}) ya estaba ausente. No se necesita limpieza.", configPath)
            End If
        End Sub
    End Module
End Namespace
