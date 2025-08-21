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
