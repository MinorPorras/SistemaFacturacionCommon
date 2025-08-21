Imports System.Configuration
Imports System.IO
Imports System.Net
Imports Squirrel

' -----------------------------------------------------------------------------
' Módulo de inicialización y utilidades de configuración de la aplicación
' Incluye funciones para actualización, configuración y acceso a settings
' -----------------------------------------------------------------------------
Module Md_Inicializacion

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
    Async Sub CheckForUpdates()
        If Not HayConexionInternet() Then
            MessageBox.Show("No hay conexión a internet. No se puede buscar actualizaciones.", "Sin conexión", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If

        Using mgr = Await UpdateManager.GitHubUpdateManager("https://github.com/MinorPorras/SistemaFacturacionCommon")
            Await mgr.UpdateApp()
        End Using
    End Sub

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

End Module
