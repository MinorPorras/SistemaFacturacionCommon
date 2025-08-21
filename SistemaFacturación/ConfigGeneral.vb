Imports System.Configuration
Public Class ConfigGeneral

    Private Sub ConfigGeneral_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarAutoCods()
        cargarFontSizes()
    End Sub
    Private Sub Guna2ImageButton1_Click(sender As Object, e As EventArgs) Handles BTN_CerrarApp.Click
        msgCerrarApp()
    End Sub

#Region "TabDB"
    Private Sub BTN_RegresarConfig_Click(sender As Object, e As EventArgs) Handles BTN_RegresarConfig.Click
        Me.Close()
    End Sub

    Private Sub BTN_RspaldoDB_Click(sender As Object, e As EventArgs) Handles BTN_RspaldoDB.Click
        If MsgBox("¿Desea hacer el respaldo de la base de datos?", vbOKCancel + vbQuestion, "Confirmación") = MsgBoxResult.Ok Then
            Md_BackupDB.ExportarDB()
        End If
    End Sub

    Private Sub BTN_Importar_Click(sender As Object, e As EventArgs) Handles BTN_Importar.Click
        If MsgBox("¿Esta seguro de querer importar la base de datos? Se cambiará la información de la bd y no se podrá recuperar si hay un error", vbOKCancel + vbQuestion, "Confirmación") = MsgBoxResult.Ok Then
            If MsgBox("Esta verdaderamente seguro de querer hacer cambio? Esta accion no es reversible", vbOKCancel + vbQuestion, "Confirmación") = MsgBoxResult.Ok Then
                If MsgBox("Ultima comprobación, si presionas OK la base de datos será actualizada a lo que esté en el respaldo", vbOKCancel + vbQuestion, "Confirmación") = MsgBoxResult.Ok Then
                    If OFD_ImportarDB.ShowDialog() = DialogResult.OK Then
                        If Not OFD_ImportarDB.FileName = "" Then
                            Dim NuevaDB As String = OFD_ImportarDB.FileName
                            Md_BackupDB.ImportarDB(NuevaDB)
                            msgRestart()
                        End If
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub BTN_ModBackupDir_Click(sender As Object, e As EventArgs) Handles BTN_ModBackupDir.Click
        OFD_ModBackUpDir.SelectedPath = ConfigurationManager.AppSettings("DirectorioRespaldo")
        If OFD_ModBackUpDir.ShowDialog() = DialogResult.OK Then
            Dim folderPath As String
            If OFD_ModBackUpDir.SelectedPath = "C:\" Then
                folderPath = OFD_ModBackUpDir.SelectedPath
            Else
                folderPath = OFD_ModBackUpDir.SelectedPath + "\"
            End If

            Md_Inicializacion.SetAppSetting("DirectorioRespaldo", folderPath)
            MessageBox.Show("Carpeta seleccionada: " & folderPath)
            msgRestart()
        End If
    End Sub

    Private Sub BTN_ModConnDB_Click(sender As Object, e As EventArgs) Handles BTN_ModConnDB.Click
        If MsgBox("¿Esta seguro de querer importar la base de datos? Se cambiará la información de la bd y no se podrá recuperar si hay un error", vbOKCancel + vbQuestion, "Confirmación") = MsgBoxResult.Ok Then
            If MsgBox("Asegurate de hacer un respaldo antes de realizar esta acción", vbOKCancel + vbQuestion, "Confirmación") = MsgBoxResult.Ok Then
                If MsgBox("Ultima comprobación, si presionas OK la base de datos será actualizada a la que se seleccione", vbOKCancel + vbQuestion, "Confirmación") = MsgBoxResult.Ok Then
                    OFD_ModDirDB.Title = "Seleccione un archivo de de base de datos"
                    Dim strConn As String() = ObtenerConnectionString("DbConnectionString").Split("="c)
                    OFD_ModDirDB.FileName = strConn(1)
                    OFD_ModDirDB.InitialDirectory = strConn(1)
                    If OFD_ModDirDB.ShowDialog() = DialogResult.OK Then
                        Dim folderPath As String = IO.Path.GetFullPath(OFD_ModDirDB.FileName)
                        Md_Inicializacion.SetConnectionString("DbConnectionString", "Data Source=" & folderPath)
                        MessageBox.Show("Conexión actualizada: " & folderPath)
                        msgRestart()
                    End If
                End If
            End If
        End If
    End Sub
#End Region

#Region "tabCod"
    Private Sub SWT_ModCod_CheckedChanged(sender As Object, e As EventArgs) Handles SWT_ModCod.Click
        If SWT_ModCod.Checked = True Then
            NUD_Cajero.Enabled = True
            NUD_Cat.Enabled = True
            NUD_Cliente.Enabled = True
            NUD_Imp.Enabled = True
            NUD_Marca.Enabled = True
            NUD_Prod.Enabled = True
            NUD_Prov.Enabled = True
            BTN_ActualizarCods.Enabled = True

        Else
            NUD_Cajero.Enabled = False
            NUD_Cat.Enabled = False
            NUD_Cliente.Enabled = False
            NUD_Imp.Enabled = False
            NUD_Marca.Enabled = False
            NUD_Prod.Enabled = False
            NUD_Prov.Enabled = False
            CargarAutoCods()
            BTN_ActualizarCods.Enabled = False
        End If
    End Sub

    Private Sub CargarAutoCods()
        NUD_Cajero.Value = Md_Inicializacion.GetAppSetting("AutoCodCajero")
        NUD_Cat.Value = Md_Inicializacion.GetAppSetting("AutoCodCat")
        NUD_Cliente.Value = Md_Inicializacion.GetAppSetting("AutoCodCliente")
        NUD_Imp.Value = Md_Inicializacion.GetAppSetting("AutoCodImp")
        NUD_Marca.Value = Md_Inicializacion.GetAppSetting("AutoCodMarca")
        NUD_Prod.Value = Md_Inicializacion.GetAppSetting("AutoCodProd")
        NUD_Prov.Value = Md_Inicializacion.GetAppSetting("AutoCodProv")
    End Sub

    Private Sub BTN_ActualizarCods_Click(sender As Object, e As EventArgs) Handles BTN_ActualizarCods.Click
        Md_Inicializacion.SetAppSetting("AutoCodCajero", NUD_Cajero.Value)
        Md_Inicializacion.SetAppSetting("AutoCodCat", NUD_Cat.Value)
        Md_Inicializacion.SetAppSetting("AutoCodCliente", NUD_Cliente.Value)
        Md_Inicializacion.SetAppSetting("AutoCodImp", NUD_Imp.Value)
        Md_Inicializacion.SetAppSetting("AutoCodMarca", NUD_Marca.Value)
        Md_Inicializacion.SetAppSetting("AutoCodProd", NUD_Prod.Value)
        Md_Inicializacion.SetAppSetting("AutoCodProv", NUD_Prov.Value)
        msgDatoAlm()
    End Sub

    Private Sub BTN_Regresar_Click(sender As Object, e As EventArgs) Handles BTN_Regresar.Click
        Me.Close()
    End Sub
#End Region

#Region "Hablador"
    Private Sub cargarFontSizes()
        NUD_SizePrecio.Value = Md_Inicializacion.GetAppSetting("FontSizeProd")
        NUD_SizeProd.Value = Md_Inicializacion.GetAppSetting("FontSizePrecio")
    End Sub
    Private Sub BTN_ConfigRegHablador_Click(sender As Object, e As EventArgs) Handles BTN_ConfigRegHablador.Click
        Me.Close()
    End Sub

    Private Sub BTN_ActualizarHablador_Click(sender As Object, e As EventArgs) Handles BTN_ActualizarHablador.Click
        Md_Inicializacion.SetAppSetting("FontSizeProd", NUD_SizeProd.Value)
        Md_Inicializacion.SetAppSetting("FontSizePrecio", NUD_SizePrecio.Value)
        msgDatoAlm()
    End Sub

    Private Sub SWT_ModHablador_CheckedChanged(sender As Object, e As EventArgs) Handles SWT_ModHablador.CheckedChanged
        If SWT_ModHablador.Checked Then
            NUD_SizePrecio.Enabled = True
            NUD_SizeProd.Enabled = True
            BTN_ActualizarHablador.Enabled = True
        Else
            NUD_SizePrecio.Enabled = False
            NUD_SizeProd.Enabled = False
            BTN_ActualizarHablador.Enabled = False
            cargarFontSizes()
        End If
    End Sub
#End Region

End Class