Imports System.Data.SQLite
Imports Guna.UI2.WinForms
Imports SistemaFacturaciónCommon.SistemaFacturacion.Forms.Caja
Imports SistemaFacturaciónCommon.SistemaFacturacion.Modules

Namespace SistemaFacturacion.Forms.Inicio

    Public Class ConfigGeneral
        Private nudCodMappings As Dictionary(Of Guna2NumericUpDown, String)
        Private nudHabladorMappings As New Dictionary(Of Guna.UI2.WinForms.Guna2NumericUpDown, String)

        Public Property InitialTabIndex As Integer = 0

        ' Declaración de un diccionario para rastrear el estado de carga de cada pestaña.
        Private _tabLoaded As New Dictionary(Of String, Boolean) From {
            {"PAG_Info", False},
            {"PAG_DBReportes", False},
            {"PAG_AutoCods", False},
            {"PAG_Hablador", False},
            {"PAG_FavProd", False}
        }

        Private Sub ConfigGeneral_Load(sender As Object, e As EventArgs) Handles MyBase.Load
            ' Usamos el valor almacenado en la propiedad
            Me.TCO_Config.SelectedIndex = Me.InitialTabIndex

            ' Asegurar que la pestaña seleccionada sea visible
            Me.TCO_Config.SelectedTab.Select()

            'Se carga la primera pestaña por defecto
            If TCO_Config.SelectedTab IsNot Nothing Then
                LoadData(TCO_Config.SelectedTab.Name)
            End If
        End Sub

        ' Método único para cargar los datos basado en el nombre de la pestaña.
        Private Sub LoadData(tabName As String)
            Select Case tabName
                Case "PAG_Info"
                    If Not _tabLoaded("PAG_Info") Then
                        ' Cargar datos específicos para la pestaña PAG_Info
                        cargarGeneralConfig()
                        _tabLoaded("PAG_Info") = True
                    End If
                Case "PAG_DBReportes"
                    If Not _tabLoaded("PAG_DBReportes") Then
                        ' Cargar datos específicos para la pestaña PAG_DBReportes
                        cargarDBConfigInfo()
                        _tabLoaded("PAG_DBReportes") = True
                    End If
                Case "PAG_AutoCods"
                    If Not _tabLoaded("PAG_AutoCods") Then
                        ' Cargar datos específicos para la pestaña PAG_AutoCods
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
                        CargarCodigosDesdeConfiguracion()
                        _tabLoaded("PAG_AutoCods") = True
                    End If
                Case "PAG_Hablador"
                    If Not _tabLoaded("PAG_Hablador") Then
                        ' Cargar datos específicos para la pestaña PAG_Hablador
                        nudHabladorMappings = New Dictionary(Of Guna.UI2.WinForms.Guna2NumericUpDown, String) From {
                            {NUD_SizePrecio, "FontSizePrecio"},
                            {NUD_SizeProd, "FontSizeProd"}
                        }
                        cargarFontSizes()
                        _tabLoaded("PAG_Hablador") = True
                    End If
                Case "PAG_FavProd"
                    If Not _tabLoaded("PAG_FavProd") Then
                        ' Cargar datos específicos para la pestaña PAG_FavProd
                        ' Aquí iría el código para cargar los datos de esta pestaña
                        InicializarComponentesProdFav()
                        _tabLoaded("PAG_FavProd") = True
                    End If
            End Select
        End Sub

        Private Sub TCO_Config_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TCO_Config.SelectedIndexChanged
            If TCO_Config.SelectedTab IsNot Nothing Then
                Dim tabName As String = TCO_Config.SelectedTab.Name

                ' Verifica si la pestaña ya ha sido cargada usando su nombre.
                If _tabLoaded.ContainsKey(tabName) AndAlso Not _tabLoaded(tabName) Then
                    LoadData(tabName)
                End If
            End If
        End Sub

        Private Sub Guna2ImageButton1_Click(sender As Object, e As EventArgs) Handles BTN_CerrarApp.Click
            msgCerrarApp()
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

#Region "FavProd"
        Private searchTimer As Timer
        Friend ownerForm As Form

        ' Método para inicializar el temporizador y otros componentes necesarios
        Private Sub InicializarComponentesProdFav()
            ' Inicializar el temporizador
            searchTimer = New Timer With {
                .Interval = 100
            }
            ' Medio segundo
            AddHandler searchTimer.Tick, AddressOf OnSearchTimerTick
            CargarProdFav()
            REFRESCAR_BuscarProd()
        End Sub

        Private Sub OnSearchTimerTick(sender As Object, e As EventArgs)
            ' Detener el temporizador y ejecutar la búsqueda
            searchTimer.Stop()
            REFRESCAR_BuscarProd()
        End Sub

        Private Sub CargarProdFav()
            DGV_FavProd.Rows.Clear()
            T.Tables.Clear()
            SQL = "SELECT pf.ID_Producto as 'ID', p.codigo as 'Código', p.nombre as 'Nombre', pf.BTN_Color as 'color'" &
                     " FROM producto_favorito pf" &
                     " JOIN producto p ON pf.ID_Producto = p.ID" &
                     " ORDER BY pf.Posicion ASC;"
            Cargar_Tabla(T, SQL)
            ' Verifica si la tabla tiene datos
            If T.Tables.Count > 0 AndAlso T.Tables(0).Rows.Count > 0 Then
                ' Recorre cada fila del DataTable 'T' y la agrega al DataGridView
                For Each row As DataRow In T.Tables(0).Rows
                    ' Agrega una nueva fila al DataGridView
                    Dim newRowIndex As Integer = DGV_FavProd.Rows.Add(row("ID"), row("Código"), row("Nombre"), row("color"))

                    ' Obtiene la referencia a la nueva fila
                    Dim newRow As DataGridViewRow = DGV_FavProd.Rows(newRowIndex)

                    ' Aplica el color a la celda
                    If newRow.Cells("colorProd").Value IsNot Nothing Then ' Cambio de "colorProd" a "color"
                        Dim colorValue As Integer = Convert.ToInt32(newRow.Cells("colorProd").Value) ' Cambio de "colorProd" a "color"
                        Dim cellColor As Color = Color.FromArgb(colorValue)

                        newRow.Cells("colorProd").Style.BackColor = cellColor ' Cambio de "colorProd" a "color"
                        newRow.Cells("colorProd").Style.ForeColor = cellColor ' Corrección aquí, el color de la fuente debe ser legible, no el mismo que el fondo
                        newRow.Cells("colorProd").Style.SelectionBackColor = cellColor ' Cambio de "colorProd" a "color"
                        newRow.Cells("colorProd").Style.SelectionForeColor = cellColor ' Corrección aquí
                    End If
                Next
            End If
        End Sub

        Public Sub REFRESCAR_BuscarProd()
            Task.Run(Sub()
                         Try
                             T.Tables.Clear()
                             SQL = "SELECT p.ID, p.codigo as 'Código', p.nombre as 'Nombre', v.precio_venta as 'Precio'" &
                                     " FROM producto p LEFT JOIN producto_precioVenta v ON p.ID = v.ID_Producto" +
                                     " where p.codigo LIKE '%" & TXT_BuscarProd.Text & "%' OR p.nombre LIKE '%" & TXT_BuscarProd.Text & "%' ORDER BY p.codigo ASC;"
                             Invoke(Sub()
                                        Cargar_Tabla(T, SQL)
                                        If T.Tables.Count > 0 AndAlso T.Tables(0).Rows.Count > 0 Then
                                            Dim bin As New BindingSource With {
                                                .DataSource = T.Tables(0)
                                            }
                                            DGV_BProd.DataSource = bin
                                            DGV_BProd.Columns(0).Visible = False
                                        Else ' Limpiar la fuente de datos si no se cargaron datos
                                            DGV_BProd.DataSource = Nothing
                                        End If
                                        TXT_BuscarProd.Select()
                                    End Sub)
                         Catch ex As Exception
                             Invoke(Sub()
                                        If DGV_BProd.IsHandleCreated Then
                                            If ex.Message <> "InvalidArgument=El valor de '0' no es válido para 'index'." & vbCrLf & "Nombre del parámetro: index" Then
                                                ' Mostrar un mensaje de error genérico
                                                msgError("Error al cargar la lista de clientes: " & ex.Message)
                                            End If
                                        End If
                                    End Sub)
                         End Try
                     End Sub)
        End Sub

        Private Sub TXT_BuscarProd_TextChanged(sender As Object, e As EventArgs) Handles TXT_BuscarProd.TextChanged
            If searchTimer IsNot Nothing Then
                searchTimer.Stop()
                searchTimer.Start()
            End If
        End Sub

        Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
            If TypeOf Me.Owner Is P_Caja Then
                P_Caja.LoadBtnFav()
            End If
            Me.Close()
        End Sub

        Private Sub MNU_SELECCIONAR_Click(sender As Object, e As EventArgs) Handles MNU_SELECCIONAR.Click
            'REvisa si hay un producto con el ID ya agregado en la lista de favoritos
            For Each row As DataGridViewRow In DGV_FavProd.Rows
                If row.Cells(0).Value IsNot Nothing AndAlso DGV_BProd.SelectedRows(0).Cells(0).Value IsNot Nothing Then
                    If row.Cells(0).Value.ToString() = DGV_BProd.SelectedRows(0).Cells(0).Value.ToString() Then
                        msgError("El producto ya está en la lista de favoritos.")
                        Return
                    End If
                End If
            Next

            Dim id As Integer = Convert.ToInt32(DGV_BProd.SelectedRows(0).Cells(0).Value)
            Dim codigo As String = DGV_BProd.SelectedRows(0).Cells(1).Value.ToString()
            Dim nombre As String = DGV_BProd.SelectedRows(0).Cells(2).Value.ToString()

            ' Agrega la nueva fila y guarda la referencia
            Dim nuevaFilaIndex As Integer = DGV_FavProd.Rows.Add(id, codigo, nombre)
            Dim nuevaFila As DataGridViewRow = DGV_FavProd.Rows(nuevaFilaIndex)
            Dim celdaColor = nuevaFila.Cells(3)
            'Color naranja
            Dim r = 255
            Dim g = 128
            Dim b = 0
            'Se establece este color a la celda
            celdaColor.Style.BackColor = Color.FromArgb(r, g, b)
            celdaColor.Style.ForeColor = Color.FromArgb(r, g, b)
            celdaColor.Style.SelectionBackColor = Color.FromArgb(r, g, b)
            celdaColor.Style.SelectionForeColor = Color.FromArgb(r, g, b)

        End Sub

        Private Sub MNU_ELIMINAR_Click(sender As Object, e As EventArgs) Handles MNU_ELIMINAR.Click
            DGV_FavProd.Rows.RemoveAt(DGV_FavProd.SelectedRows(0).Index)
        End Sub

        Private Sub MoveFavProd(moveUp As Boolean)
            Dim selectedRow As DataGridViewRow
            Dim oldIndex As Integer
            Dim newIndex As Integer
            Dim MaxIndex As Integer = DGV_FavProd.Rows.Count - 1

            ' 1. Verificar si hay filas seleccionadas
            If DGV_FavProd.SelectedRows.Count = 0 Then
                Exit Sub
            End If

            selectedRow = DGV_FavProd.SelectedRows(0)
            oldIndex = selectedRow.Index

            ' 2. Calcular el nuevo índice
            If moveUp Then
                ' Salir si ya está en la primera posición
                If oldIndex = 0 Then Exit Sub
                newIndex = oldIndex - 1
            Else
                ' Salir si ya está en la última posición
                If oldIndex = MaxIndex Then Exit Sub
                newIndex = oldIndex + 1
            End If

            ' 3. Remover e insertar la fila en la nueva posición
            DGV_FavProd.Rows.RemoveAt(oldIndex)
            DGV_FavProd.Rows.Insert(newIndex, selectedRow)

            ' 4. Mantener la fila seleccionada después del movimiento
            selectedRow.Selected = True
        End Sub

        Private Sub BTN_MoveUp_Click(sender As Object, e As EventArgs) Handles BTN_MoveUp.Click
            MoveFavProd(True)
        End Sub

        Private Sub BTN_MoveDown_Click(sender As Object, e As EventArgs) Handles BTN_MoveDown.Click
            MoveFavProd(False)
        End Sub

        Private Sub DGV_FavProd_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGV_FavProd.CellClick
            ' Verifica que el clic sea en la columna de color y no en el encabezado
            If e.ColumnIndex = 3 AndAlso e.RowIndex >= 0 Then
                ' Obtiene la celda actual
                Dim cell As DataGridViewCell = DGV_FavProd.Rows(e.RowIndex).Cells(e.ColumnIndex)

                ' Crea y muestra el diálogo de color
                Using colorDialog As New ColorDialog()
                    ' Si la celda ya tiene un color, lo establece como el predeterminado del diálogo
                    If cell.Style.BackColor <> Color.Empty Then
                        colorDialog.Color = cell.Style.BackColor
                    Else
                        colorDialog.Color = Color.White ' Color por defecto si no hay uno
                    End If

                    ' Muestra el diálogo y si el usuario selecciona un color
                    If colorDialog.ShowDialog() = DialogResult.OK Then
                        ' Crea una copia del estilo para no modificar el estilo por defecto de la columna
                        ' Asigna el color seleccionado
                        Dim newCellStyle As New DataGridViewCellStyle(cell.Style) With {
                            .BackColor = colorDialog.Color,
                            .ForeColor = colorDialog.Color,
                            .SelectionBackColor = colorDialog.Color,
                            .SelectionForeColor = colorDialog.Color
                        }

                        ' Aplica el nuevo estilo a la celda
                        cell.Style = newCellStyle
                    End If
                End Using
            End If
        End Sub

        Private Sub BTN_Actualizar_Click(sender As Object, e As EventArgs) Handles BTN_Actualizar.Click

            Dim cmd As New SQLiteCommand()
            Dim transaction As SQLiteTransaction = Nothing ' Inicialización segura

            ' Usamos Using para garantizar que la conexión (conn) se cierre y se libere (Dispose).
            Using conn As New SQLiteConnection(GetConnectionString())
                Try
                    conn.Open()

                    ' Asignar conexión y empezar transacción aquí.
                    cmd.Connection = conn
                    transaction = conn.BeginTransaction()
                    cmd.Transaction = transaction

                    ' 1. Elimina todos los registros de la tabla de favoritos
                    cmd.CommandText = "DELETE FROM producto_favorito;"
                    cmd.ExecuteNonQuery()

                    ' 2. Prepara los parámetros UNA SOLA VEZ antes del bucle para optimización.
                    cmd.CommandText = "INSERT INTO producto_favorito (ID_Producto, Posicion, BTN_Color) VALUES (@id, @posicion, @color);"
                    cmd.Parameters.Clear()
                    cmd.Parameters.Add("@id", DbType.Int32)
                    cmd.Parameters.Add("@posicion", DbType.Int32)
                    cmd.Parameters.Add("@color", DbType.Int32)

                    ' 3. Recorre el DataGridView e inserta cada fila
                    For i As Integer = 0 To DGV_FavProd.Rows.Count - 1
                        Dim row As DataGridViewRow = DGV_FavProd.Rows(i)

                        ' Asigna solo el valor dentro del bucle
                        cmd.Parameters("@id").Value = Convert.ToInt32(row.Cells("ID").Value)
                        cmd.Parameters("@posicion").Value = i + 1
                        cmd.Parameters("@color").Value = row.Cells("colorProd").Style.BackColor.ToArgb()

                        cmd.ExecuteNonQuery()
                    Next

                    ' 4. Confirma la transacción.
                    transaction.Commit()
                    MSG.mensaje("Se ha guardado el nuevo orden de productos favoritos.", vbOKOnly, "Favoritos guardados")

                Catch ex As Exception
                    ' 5. Revierte la transacción SÓLO si fue inicializada correctamente.
                    transaction?.Rollback()
                    msgError("Error al guardar el nuevo orden: " & ex.Message)

                Finally
                    If TypeOf Me.Owner Is P_Caja Then
                        P_Caja.LoadBtnFav()
                    End If
                End Try
            End Using
        End Sub
#End Region

    End Class

End Namespace