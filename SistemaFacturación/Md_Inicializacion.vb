Imports System.Configuration
Imports System.IO

' -----------------------------------------------------------------------------
' Módulo de inicialización y utilidades de configuración de la aplicación
' Incluye funciones para actualización, configuración y acceso a settings
' -----------------------------------------------------------------------------
Module Md_Inicializacion

    ' Verifica si existe una nueva versión del instalador y pregunta al usuario si desea actualizar
    Public Sub CheckForUpdates()
        ' Ruta completa del archivo setup.exe
        Dim setupFile As String = "C:\SisFactUtilidades\SisFactIntaller\setup.exe"

        ' Verificar si existe el archivo setup.exe en la ruta de actualización
        If File.Exists(setupFile) Then
            ' Obtener la versión actual de la aplicación
            Dim currentVersion As Version = New Version(Application.ProductVersion)
            ' Obtener la versión del archivo setup.exe
            Dim setupFileInfo As FileVersionInfo = FileVersionInfo.GetVersionInfo(setupFile)
            Dim setupFileVersion As String = setupFileInfo.FileVersion

            ' Validar que la cadena de versión sea válida
            Dim updateVersion As Version = Nothing
            If Version.TryParse(setupFileVersion, updateVersion) Then
                ' Comparar versiones para determinar si hay una nueva versión disponible
                If updateVersion > currentVersion Then
                    ' Preguntar al usuario si desea actualizar
                    If MessageBox.Show("Hay una nueva versión disponible. ¿Deseas actualizar?", "Actualización Disponible", MessageBoxButtons.YesNo) = DialogResult.Yes Then
                        ApplyUpdate(setupFile)
                    End If
                End If
            End If
        End If
    End Sub

    ' Ejecuta el instalador de la nueva versión y cierra la aplicación actual
    Private Sub ApplyUpdate(setupFile As String)
        Process.Start(setupFile)
        Application.Exit()
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
