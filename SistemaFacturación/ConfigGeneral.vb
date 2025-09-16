Imports System.Configuration
Imports System.Windows.Input
Imports Guna.UI2.WinForms
Public Class ConfigGeneral
    Private nudCodMappings As Dictionary(Of Guna2NumericUpDown, String)
    Private nudHabladorMappings As New Dictionary(Of Guna.UI2.WinForms.Guna2NumericUpDown, String)

    Private Sub ConfigGeneral_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        InicializarDiccionarios()
        cargarDBConfigInfo()
        CargarCodigosDesdeConfiguracion()
        cargarFontSizes()
        cargarGeneralConfig()
    End Sub
    Private Sub Guna2ImageButton1_Click(sender As Object, e As EventArgs) Handles BTN_CerrarApp.Click
        msgCerrarApp()
    End Sub

    Private Sub InicializarDiccionarios()
        ' Inicializa el diccionario
        nudCodMappings = New Dictionary(Of Guna2NumericUpDown, String) From {
            {NUD_Cajero, "AutoCodCajero"},
            {NUD_Cat, "AutoCodCat"},
            {NUD_Cliente, "AutoCodCliente"},
            {NUD_Imp, "AutoCodImp"},
            {NUD_Marca, "AutoCodMarca"},
            {NUD_Prod, "AutoCodProd"},
            {NUD_Prov, "AutoCodProv"}
        }

        nudHabladorMappings = New Dictionary(Of Guna.UI2.WinForms.Guna2NumericUpDown, String) From {
            {NUD_SizePrecio, "FontSizePrecio"},
            {NUD_SizeProd, "FontSizeProd"}
        }
    End Sub

#Region "TabDB"

    Private Sub cargarDBConfigInfo()
        ' Cargar información del directorio de respaldo
        Dim backupDir As String = Md_Inicializacion.GetAppSetting("DirectorioRespaldo")
        If Not String.IsNullOrEmpty(backupDir) Then
            LBL_BackUpDIr.Text = backupDir
        End If

        ' Cargar información del directorio de descargas
        Dim DescargasDir As String = Md_Inicializacion.GetAppSetting("DirectorioDescargaReportes")
        If Not String.IsNullOrEmpty(DescargasDir) Then
            LBL_DownloadRepDIr.Text = DescargasDir
        End If
    End Sub

    Private Sub BTN_RegresarConfig_Click(sender As Object, e As EventArgs) Handles BTN_RegresarConfig.Click
        Me.Close()
    End Sub

    Private Sub BTN_RspaldoDB_Click(sender As Object, e As EventArgs) Handles BTN_RspaldoDB.Click
        If MsgBox("¿Desea hacer el respaldo de la base de datos?", vbOKCancel + vbQuestion, "Confirmación") = MsgBoxResult.Ok Then
            Md_BackupDB.ExportarDB()
        End If
    End Sub

    Private Sub BTN_Importar_Click(sender As Object, e As EventArgs) Handles BTN_Importar.Click
        'Comprobaciones de seguridad de realizar la acción
        If MsgBox("¿Esta seguro de querer importar la base de datos? Se cambiará la información de la bd y no se podrá recuperar si hay un error", vbOKCancel + vbQuestion, "Confirmación") <> MsgBoxResult.Ok Then
            Exit Sub
        End If
        If MsgBox("Esta verdaderamente seguro de querer hacer cambio? Esta accion no es reversible", vbOKCancel + vbQuestion, "Confirmación") <> MsgBoxResult.Ok Then
            Exit Sub
        End If
        If MsgBox("Ultima comprobación, si presionas OK la base de datos será actualizada a lo que esté en el respaldo", vbOKCancel + vbQuestion, "Confirmación") <> MsgBoxResult.Ok Then
            Exit Sub
        End If
        'Ultima comprobación de que se seleccione un archivo
        If OFD_ImportarDB.ShowDialog() <> DialogResult.OK Then
            Exit Sub
        End If

        If Not OFD_ImportarDB.FileName = "" Then
            Dim NuevaDB As String = OFD_ImportarDB.FileName
            Md_BackupDB.ImportarDB(NuevaDB)
            msgRestart()
        End If
    End Sub

    Private Sub BTN_ModBackupDir_Click(sender As Object, e As EventArgs) Handles BTN_ModBackupDir.Click
        modificarDirSettings("DirectorioRespaldo")
    End Sub

    Private Sub BTN_ModCarpetaDescargaReportes_Click(sender As Object, e As EventArgs) Handles BTN_ModCarpetaDescargaReportes.Click
        modificarDirSettings("DirectorioDescargaReportes")
    End Sub

    Private Sub modificarDirSettings(key As String)
        ' 1. Cargar el valor actual de la configuración usando tu método centralizado.
        Dim currentPath As String = Md_Inicializacion.GetAppSetting(key)

        ' Establece la ruta seleccionada del diálogo con la ruta actual de la configuración.
        ' Se verifica si la ruta no está vacía antes de asignarla.
        If Not String.IsNullOrEmpty(currentPath) Then
            OFD_ModBackUpDir.SelectedPath = currentPath
        End If

        If OFD_ModBackUpDir.ShowDialog() = DialogResult.OK Then
            ' 2. Usar Path.Combine para manejar las rutas de forma segura.
            ' Esto evita errores si la ruta ya termina en '\'.
            Dim folderPath As String = OFD_ModBackUpDir.SelectedPath

            ' 3. Guardar la nueva configuración usando tu método centralizado.
            Md_Inicializacion.SetAppSetting(key, folderPath)

            MessageBox.Show("Carpeta seleccionada: " & folderPath)
            msgRestart()
        End If
    End Sub
#End Region

#Region "tabCod"

    Private Sub SWT_ModCod_CheckedChanged(sender As Object, e As EventArgs) Handles SWT_ModCod.CheckedChanged
        ' Itera sobre las claves del diccionario (los controles)
        For Each nud As Guna2NumericUpDown In nudCodMappings.Keys
            nud.Enabled = SWT_ModCod.Checked
        Next

        BTN_ActualizarCods.Enabled = SWT_ModCod.Checked

        If Not SWT_ModCod.Checked Then
            CargarCodigosDesdeConfiguracion()
        End If
    End Sub

    Private Sub CargarCodigosDesdeConfiguracion()
        For Each entry In nudCodMappings
            Dim nud As Guna2NumericUpDown = entry.Key
            Dim appSettingName As String = entry.Value

            ' Obtiene el valor de la configuración
            Dim settingValue As String = Md_Inicializacion.GetAppSetting(appSettingName)

            ' Verifica si el valor no es nulo o vacío antes de intentar la conversión
            If Not String.IsNullOrEmpty(settingValue) Then
                ' Convierte la cadena a Decimal y asigna el valor
                nud.Value = Convert.ToDecimal(settingValue)
            Else
                ' Opcional: Establece un valor predeterminado si el valor es nulo o vacío
                nud.Value = 0
            End If
        Next
    End Sub

    Private Sub BTN_ActualizarCods_Click(sender As Object, e As EventArgs) Handles BTN_ActualizarCods.Click
        For Each entry In nudCodMappings
            Dim nud As Guna2NumericUpDown = entry.Key
            Dim appSettingName As String = entry.Value
            Md_Inicializacion.SetAppSetting(appSettingName, nud.Value)
        Next
        msgDatoAlm()
    End Sub

    Private Sub BTN_Regresar_Click(sender As Object, e As EventArgs) Handles BTN_Regresar.Click
        Me.Close()
    End Sub
#End Region

#Region "Hablador"

    Private Sub cargarFontSizes()
        For Each entry In nudHabladorMappings
            Dim nud As Guna.UI2.WinForms.Guna2NumericUpDown = entry.Key
            Dim appSettingName As String = entry.Value
            ' Asegúrate de que el valor de la configuración sea un tipo numérico antes de asignarlo
            If Md_Inicializacion.GetAppSetting(appSettingName) IsNot Nothing AndAlso IsNumeric(Md_Inicializacion.GetAppSetting(appSettingName)) Then
                nud.Value = Convert.ToDecimal(Md_Inicializacion.GetAppSetting(appSettingName))
            End If
        Next
    End Sub

    Private Sub BTN_ActualizarHablador_Click(sender As Object, e As EventArgs) Handles BTN_ActualizarHablador.Click
        For Each entry In nudHabladorMappings
            Dim nud As Guna.UI2.WinForms.Guna2NumericUpDown = entry.Key
            Dim appSettingName As String = entry.Value
            Md_Inicializacion.SetAppSetting(appSettingName, nud.Value)
        Next
        msgDatoAlm()
    End Sub
    Private Sub SWT_ModHablador_CheckedChanged(sender As Object, e As EventArgs) Handles SWT_ModHablador.CheckedChanged
        ' Habilita o deshabilita los controles y el botón en un solo bucle
        For Each entry In nudHabladorMappings
            Dim nud As Guna.UI2.WinForms.Guna2NumericUpDown = entry.Key
            nud.Enabled = SWT_ModHablador.Checked
        Next
        BTN_ActualizarHablador.Enabled = SWT_ModHablador.Checked

        ' Carga los valores solo si el switch está deshabilitado
        If Not SWT_ModHablador.Checked Then
            cargarFontSizes()
        End If
    End Sub

#End Region

#Region "General"
    Private Sub cargarGeneralConfig()
        lbl_versionGeneralConfig.Text = Application.ProductVersion

        ' Deshabilitar el evento para evitar que se dispare
        RemoveHandler SWT_AutoUpdate.CheckedChanged, AddressOf SWT_AutoUpdate_CheckedChanged

        ' Cambiar el estado del control sin ejecutar el evento
        SWT_AutoUpdate.Checked = Md_Inicializacion.GetAppSetting("AutoUpdate") = "True"

        ' Habilitar el evento nuevamente
        AddHandler SWT_AutoUpdate.CheckedChanged, AddressOf SWT_AutoUpdate_CheckedChanged
    End Sub

    Private Sub SWT_AutoUpdate_CheckedChanged(sender As Object, e As EventArgs) Handles SWT_AutoUpdate.CheckedChanged
        ' Define el mensaje y el valor a guardar en una sola línea
        ' usando el operador condicional If
        Dim isEnabled As Boolean = SWT_AutoUpdate.Checked
        Dim settingValue As String = If(isEnabled, "True", "False")
        Dim message As String = If(isEnabled,
        "La actualización automática está habilitada. La aplicación buscará actualizaciones al iniciar.",
        "La actualización automática está deshabilitada. La aplicación no buscará actualizaciones al iniciar.")

        ' Establece la configuración y muestra el mensaje
        Md_Inicializacion.SetAppSetting("AutoUpdate", settingValue)
        MessageBox.Show(message, "Configuración Actualizada", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub BTN_CheckForUpdates_Click(sender As Object, e As EventArgs) Handles BTN_CheckForUpdates.Click
        Md_Inicializacion.CheckForUpdates()
    End Sub

    Private Sub btn_RegInfoConfig_Click(sender As Object, e As EventArgs) Handles btn_RegInfoConfig.Click
        Me.Close()
    End Sub

    Private Sub BTN_ConfigRegHablador_Click(sender As Object, e As EventArgs) Handles BTN_ConfigRegHablador.Click
        Me.Close()
    End Sub

#End Region

End Class