Imports NuGet.Versioning
Imports Velopack
Imports Velopack.Locators
Imports Serilog
Namespace SistemaFacturacion.Modules
    ''' <summary>
    ''' Módulo para manejar eventos de Velopack como instalación, actualización y desinstalación.
    ''' </summary>
    Module Md_VelopackHandlers
        ' --- FAST CALLBACK HOOKS (Se ejecutan y terminan el proceso) ---
        Private Sub HandleInstall(ByVal Version As SemanticVersion)
            ' Acciones a realizar durante la instalación de Velopack
            Log.Information($"Instalación completada. Versión: {Version}", TraceEventType.Information)

            ' Lógica de Acceso Directo Personalizada (Opcional, si vpk no lo hace)
            ' mgr.CreateShortcut("Sistema Facturacion")
        End Sub
    End Module
End Namespace
