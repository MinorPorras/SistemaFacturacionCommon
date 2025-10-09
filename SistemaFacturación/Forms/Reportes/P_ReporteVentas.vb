Imports System.Data.SQLite
Imports System.Globalization
Imports Guna.UI2.WinForms
Imports SistemaFacturaciónCommon.SistemaFacturacion.Data
Imports SistemaFacturaciónCommon.SistemaFacturacion.Forms.Caja
Imports SistemaFacturaciónCommon.SistemaFacturacion.Forms.Dialogos
Imports SistemaFacturaciónCommon.SistemaFacturacion.Forms.Inicio
Imports SistemaFacturaciónCommon.SistemaFacturacion.Modules


Namespace SistemaFacturacion.Forms.Reportes

    Public Class P_ReporteVentas

        ' Declaración de un diccionario para rastrear el estado de carga de cada pestaña.
        Private _tabLoaded As New Dictionary(Of String, Boolean) From {
            {"PAG_ReporteVentas", False},
            {"PAG_ReporteProd", False},
            {"PAG_ArqueosCaja", False}
        }

#Region "Metodos compartidos"
        Private Sub P_ReporteVentas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
            'Se carga la primera pestaña por defecto
            If TAB_Reportes.SelectedTab IsNot Nothing Then
                LoadData(TAB_Reportes.SelectedTab.Name)
            End If
        End Sub

        Private Sub TAB_Reportes_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TAB_Reportes.SelectedIndexChanged
            If TAB_Reportes.SelectedTab IsNot Nothing Then
                Dim tabName As String = TAB_Reportes.SelectedTab.Name

                ' Verifica si la pestaña ya ha sido cargada usando su nombre.
                If _tabLoaded.ContainsKey(tabName) AndAlso Not _tabLoaded(tabName) Then
                    LoadData(tabName)
                End If
            End If
        End Sub

        ' Método único para cargar los datos basado en el nombre de la pestaña.
        Private Sub LoadData(tabName As String)
            Select Case tabName
                Case "PAG_ReporteVentas"
                    ' Lógica para cargar los datos de la pestaña de Ventas.
                    'Se carga la fecha actual
                    CargarFechaActual()
                    'Se aplican los estilos a los Data grid view
                    AplicarEstiloDataGridView(DGV_FactReporte)

                    ' Actualiza el estado de carga para evitar recargas.
                    _tabLoaded("PAG_ReporteVentas") = True

                Case "PAG_ReporteProd"
                    ' Lógica para cargar los datos de la pestaña de Reportes.
                    AplicarEstiloDataGridView(DGV_ListProductosMasVendidos)
                    RDB_OrderByCant.Checked = True

                    ' Actualiza el estado de carga para evitar recargas.
                    _tabLoaded("PAG_ReporteProd") = True
                Case "PAG_ArqueosCaja"
                    InicializarComponentes()
                    ReiniciarTemporizador()
            End Select
        End Sub
        Private Sub Regresar()
            M_Inicio.Show()
            M_Inicio.BringToFront()
            Me.Close()
        End Sub

        Private Sub CargarFechaActual()
            ' Establece la fecha de inicio al inicio del día (00:00:00)
            DTP_Desde.Value = Date.Now.Date

            ' Establece la fecha de fin al final del día (23:59:59)
            DTP_Hasta.Value = Date.Now.Date.AddDays(1).AddTicks(-1)

            ' Se aplica la misma lógica
            DTP_DesdeReporteProducto.Value = Date.Now.Date
            DTP_HastaReporteProducto.Value = Date.Now.Date.AddDays(1).AddTicks(-1)
        End Sub

        ' Este método puede estar en un módulo o en tu clase del formulario
        Private Sub AplicarEstiloDataGridView(ByVal dgv As Guna.UI2.WinForms.Guna2DataGridView)
            ' Deshabilita los estilos visuales del encabezado para que el estilo manual se aplique
            dgv.EnableHeadersVisualStyles = False

            ' Estilo para todas las filas
            Dim rowStyle As New DataGridViewCellStyle With {
                .Font = New Font("Segoe UI", 12),
                .BackColor = Color.White,
                .SelectionBackColor = Color.FromArgb(240, 240, 240), ' Un gris muy claro
                .SelectionForeColor = Color.Black,
                .ForeColor = Color.Black,
                .Alignment = DataGridViewContentAlignment.MiddleLeft
            }
            dgv.DefaultCellStyle = rowStyle

            ' Estilo para las filas alternas (asegurando que sea igual al estilo de fila predeterminado)
            Dim alternatingRowStyle As New DataGridViewCellStyle With {
                .Font = New Font("Segoe UI", 12),
                .BackColor = Color.White,
                .SelectionBackColor = Color.FromArgb(240, 240, 240),
                .SelectionForeColor = Color.Black,
                .ForeColor = Color.Black,
                .Alignment = DataGridViewContentAlignment.MiddleLeft
            }
            dgv.AlternatingRowsDefaultCellStyle = alternatingRowStyle

            ' Estilo para el encabezado de las columnas
            Dim headerStyle As New DataGridViewCellStyle With {
                .Font = New Font("Segoe UI", 12, FontStyle.Bold),
                .BackColor = Color.FromArgb(255, 128, 0), ' Naranja
                .SelectionBackColor = Color.FromArgb(255, 128, 0), ' Naranja (El color de la selección del encabezado)
                .ForeColor = Color.Black,
                .Alignment = DataGridViewContentAlignment.MiddleLeft
            }
            dgv.ColumnHeadersDefaultCellStyle = headerStyle

            ' Configuración de la apariencia general y altura de filas
            dgv.BackgroundColor = Color.White
            dgv.BorderStyle = BorderStyle.None
            dgv.CellBorderStyle = DataGridViewCellBorderStyle.None
            dgv.RowHeadersVisible = False

            ' Define la altura de las filas (ajustado para acomodar la fuente de tamaño 14)
            dgv.RowTemplate.Height = 30 ' Puedes ajustar este valor si lo necesitas

            ' Habilita el redimensionamiento de las columnas y filas
            dgv.AllowUserToResizeColumns = True
            dgv.AllowUserToResizeRows = False

            ' Ajuste del ancho de las columnas
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

            ' Habilitar el modo de ordenamiento para todas las columnas
            For Each col As DataGridViewColumn In dgv.Columns
                col.SortMode = DataGridViewColumnSortMode.Automatic
            Next
        End Sub
#End Region

#Region "Reporte de ventas"

        Friend encabezadoFactura As String
        Friend encabezadoProds As String
        Friend facturaContenido As New List(Of String)()
        Friend finFactura As String

        Private Sub BTN_GenReporte_Click(sender As Object, e As EventArgs) Handles BTN_GenReporte.Click
            MostrarReporteVentas()
        End Sub

        Private Async Sub MostrarReporteVentas()
            Try
                'Se desabilta el botón durante la creación del reporte
                BTN_GenReporte.Enabled = False
                BTN_GenReporte.Text = "Generando reporte..."
                BTN_GenReporte.BackColor = Color.FromKnownColor(KnownColor.Gray)
                'Se genera el reporte desde el módulo de reportes
                Dim reporte = Await GenerarReporte(DTP_Desde.Value, DTP_Hasta.Value, T)

                'Si no hay ventas registradas en el rango se envía un mensaje de alerta y no se carga nada
                If reporte.ListaVentas.Count < 0 Then
                    mensaje("No hay datos que mostrar en ese rango", vbOKOnly, "Sin datos")
                    Return
                End If

                'Se añaden los datos de la lista de facturas al data grid
                Dim bin As New BindingSource With {
                    .DataSource = reporte.ListaVentas
                }
                DGV_FactReporte.AutoGenerateColumns = True
                DGV_FactReporte.DataSource = bin
                DGV_FactReporte.Columns(0).Visible = False

                'Se agrega el total de ventas global
                TXT_TotalVentas.Text = reporte.total_ventas.ToString("C", New CultureInfo("es-CR"))

                'Se agrega el total de ventas en efectivo y en tarjeta
                TXT_VentasEfectivo.Text = reporte.ventas_efectivo.ToString("C", New CultureInfo("es-CR"))
                TXT_VentasTarjeta.Text = reporte.ventas_tarjeta.ToString("C", New CultureInfo("es-CR"))

                'Se agrega el número de ventas en el rango
                TXT_CantFacturas.Text = reporte.num_ventas.ToString("N0")

                'Se agregan los datos de producto más vendido
                If reporte.ProductoMasVendido IsNot Nothing Then
                    TXT_NombreProdMasVendido.Text = reporte.ProductoMasVendido.Nombre
                    TXT_CantProdMasVendido.Text = reporte.ProductoMasVendido.Cantidad.ToString("N0")
                    TXT_TotalProdMasVendido.Text = reporte.ProductoMasVendido.Total.ToString("C", New CultureInfo("es-CR"))
                Else
                    TXT_NombreProdMasVendido.Text = "Sin datos"
                    TXT_CantProdMasVendido.Text = "Sin datos"
                    TXT_TotalProdMasVendido.Text = "Sin datos"
                End If

                'Se vuelve a activar el botón al terminar de generar el reporte
                BTN_GenReporte.Enabled = True
                BTN_GenReporte.Text = "Generar reporte"
                BTN_GenReporte.BackColor = Color.FromKnownColor(KnownColor.MediumSeaGreen)
            Catch ex As Exception
                msgError("Error al crear el reporte: " + ex.Message)
            End Try
        End Sub

        Private Sub BTN_RegresarReporte_Click(sender As Object, e As EventArgs) Handles BTN_RegresarReporte.Click
            Regresar()
        End Sub

        Private Sub MNU_REIMPRIMIR_Click(sender As Object, e As EventArgs) Handles MNU_REIMPRIMIR.Click
            ' Asume que tienes un DataGridView llamado DGV_Facturas
            If DGV_FactReporte.CurrentRow IsNot Nothing Then
                Dim idFactura As Integer = Convert.ToInt32(DGV_FactReporte.CurrentRow.Cells("IdFactura").Value)
                ' Llamada directa a la función del módulo
                Md_IMPRIMIR.GENERAR_FACTURA(idFactura, "Comun")
            End If
        End Sub

        Private Sub MNU_Datos_Click(sender As Object, e As EventArgs) Handles MNU_DATOS.Click
            Dim ventaData As New Cls_Ventas
            Dim id = DGV_FactReporte.SelectedRows(0).Cells("ID").Value
            ventaData.CargarDataFactura(id)
            Using frmDatosFactura As New P_DatosFactura
                frmDatosFactura.Owner = Me
                ' Llama a la nueva subrutina para cargar los datos en el formulario
                frmDatosFactura.CargarDatos(ventaData)

                ' Muestra el formulario
                frmDatosFactura.ShowDialog()
                Me.Select()
            End Using
        End Sub

        Private Sub BTN_GenerarReporteVentaPDF_Click(sender As Object, e As EventArgs) Handles BTN_GenerarReporteVentaPDF.Click
            Dim resultado As DialogResult = MsgBox($"Desea generar el reporte de ventas en este rango: {DTP_Desde.Value:dd MMM yyyy} - {DTP_Hasta.Value:dd MMM yyyy}",
                                                   vbOKCancel, "Confirmación")
            If resultado = DialogResult.OK Then
                Md_Reportes.Crear_PDF_ReporteVentas(DTP_Desde.Value, DTP_Hasta.Value)
            End If
        End Sub

#End Region

#Region "Reporte productos"

        Private Sub BTN_RegresarReporteProducto_Click(sender As Object, e As EventArgs) Handles BTN_RegresarReporteProducto.Click
            Regresar()
        End Sub

        Private Async Sub BTN_GenReporteProductos_Click(sender As Object, e As EventArgs) Handles BTN_GenReporteProductos.Click
            'Se desabilta el botón durante la creación del reporte
            BTN_GenReporteProductos.Enabled = False
            BTN_GenReporteProductos.Text = "Generando reporte..."
            BTN_GenReporteProductos.FillColor = Color.FromKnownColor(KnownColor.Gray)

            'Se obtiene el valor del límite
            Dim limit As Integer = Convert.ToInt32(NUD_LimitReporteProducto.Value)

            Dim orderBy As Integer
            If RDB_OrderByCant.Checked = True Then
                orderBy = 1
            Else
                orderBy = 2
            End If
            Dim listaProd = Await getProductosMasVendido(limit, DTP_DesdeReporteProducto.Value, DTP_HastaReporteProducto.Value, orderBy)

            If listaProd.Count <= 0 Then
                msgError("No hay productos que mostrar en este rango")
                'Se vuelve a activar el botón al terminar de generar el reporte
                BTN_GenReporteProductos.Enabled = True
                BTN_GenReporteProductos.Text = "Generar reporte"
                BTN_GenReporteProductos.FillColor = Color.FromKnownColor(KnownColor.MediumSeaGreen)
                Return
            End If

            TXT_MejorProductoNombre.Text = listaProd(0).Nombre
            TXT_MejorProductoCant.Text = listaProd(0).Cantidad.ToString("N0")
            TXT_MejorProductoTotal.Text = listaProd(0).Total.ToString("C", New CultureInfo("es-CR"))

            'Se añaden los datos de la lista de productos más vendidos al data grid
            Dim bin As New BindingSource With {
                    .DataSource = listaProd
                }
            DGV_ListProductosMasVendidos.AutoGenerateColumns = True
            DGV_ListProductosMasVendidos.DataSource = bin

            'Se vuelve a activar el botón al terminar de generar el reporte
            BTN_GenReporteProductos.Enabled = True
            BTN_GenReporteProductos.Text = "Generar reporte"
            BTN_GenReporteProductos.FillColor = Color.FromKnownColor(KnownColor.MediumSeaGreen)
        End Sub

        Private Sub DGV_ListProductosMasVendidos_ColumnHeaderMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DGV_ListProductosMasVendidos.ColumnHeaderMouseClick
            ' Obtener la columna en la que se hizo clic
            Dim col As DataGridViewColumn = DGV_FactReporte.Columns(e.ColumnIndex)
            Dim colName As String = col.DataPropertyName

            ' Obtener la dirección de ordenamiento actual
            Dim sortDirection As System.ComponentModel.ListSortDirection
            If DGV_FactReporte.SortOrder = SortOrder.Ascending Then
                sortDirection = System.ComponentModel.ListSortDirection.Ascending
            Else
                sortDirection = System.ComponentModel.ListSortDirection.Descending
            End If

            ' Invertir la dirección si se hace clic en la misma columna
            If col.HeaderCell.SortGlyphDirection = SortOrder.Ascending Then
                sortDirection = System.ComponentModel.ListSortDirection.Descending
            Else
                sortDirection = System.ComponentModel.ListSortDirection.Ascending
            End If

            ' Ordenar el BindingSource
            Dim bs As BindingSource = TryCast(DGV_FactReporte.DataSource, BindingSource)
            If bs IsNot Nothing Then
                bs.Sort = colName & " " & IIf(sortDirection = System.ComponentModel.ListSortDirection.Ascending, "ASC", "DESC")
            End If

            ' Actualizar el glifo de ordenamiento
            col.HeaderCell.SortGlyphDirection = If(sortDirection = System.ComponentModel.ListSortDirection.Ascending, SortOrder.Ascending, SortOrder.Descending)

        End Sub

        Private Sub DGV_ListProductosMasVendidos_DataBindingComplete(sender As Object, e As DataGridViewBindingCompleteEventArgs) Handles DGV_ListProductosMasVendidos.DataBindingComplete
            ' Establecer el orden de las columnas para DGV_ListProductosMasVendidos
            DGV_ListProductosMasVendidos.Columns("nombre").DisplayIndex = 0
            DGV_ListProductosMasVendidos.Columns("cantidad").DisplayIndex = 1
            DGV_ListProductosMasVendidos.Columns("total").DisplayIndex = 2
        End Sub
#End Region


#Region "Arqueos de caja"
        Private searchTimer As Timer

        Private Sub ReiniciarTemporizador()
            If searchTimer IsNot Nothing Then
                ' Reiniciar el temporizador cada vez que se cambia el texto
                searchTimer.Stop()
                searchTimer.Start()
            End If
        End Sub

        ' Método para inicializar el temporizador y otros componentes necesarios
        Private Sub InicializarComponentes()
            'Se establece el filtro de la busqueda en desabilitado inicialmente para que muestre todos los cierres
            SWT_ActivateDateSearch.Checked = False
            DTP_Desde.Enabled = False
            ' Inicializar el temporizador
            searchTimer = New Timer With {
                .Interval = 250
            }
            ' Medio segundo
            AddHandler searchTimer.Tick, AddressOf OnSearchTimerTick
        End Sub

        Private Sub OnSearchTimerTick(sender As Object, e As EventArgs)
            ' Detener el temporizador y ejecutar la búsqueda
            searchTimer.Stop()
            REFRESCAR()
        End Sub

        Private Sub REFRESCAR()
            Task.Run(Sub()
                         T.Tables.Clear()
                         'Se inicializa el comando SQL para obtener la información
                         SQL = "SELECT " &
                                "    ac.ID, " &
                                "    ac.ID_Usuario, " &
                                "    u.usuario AS 'Cajero', " &
                                "    ac.fondo_inicial AS 'Fondo Inicial', " &
                                "    ac.hora_apertura AS 'Hora Apertura', " &
                                "    ac.hora_cierre AS 'Hora Cierre', " &
                                "    COUNT(mc.ID_arqueo) AS '# Movimientos', " &
                                "    ac.efectivo_contado AS 'Efectivo contado', " &
                                "    ac.diferencia AS 'Diferencia' " &
                                "FROM " &
                                "    Arqueo_Caja ac " &
                                "LEFT JOIN " &
                                "    usuario u ON u.ID = ac.ID_Usuario " &
                                "LEFT JOIN " &
                                "    Movimientos_Caja mc ON mc.ID_arqueo = ac.ID " &
                                "WHERE " &
                                "    (@usuario IS NULL OR u.usuario LIKE '%' || @usuario || '%') AND " &
                                "    (@fecha IS NULL OR DATE(ac.hora_cierre) = DATE(@fecha) OR DATE(ac.hora_apertura) = DATE(@fecha)) " &
                                "GROUP BY " &
                                "    ac.ID " &
                                "ORDER BY " &
                                "    ac.hora_cierre"

                         'Se crea el parámetro para el comentario y para la fecha
                         Dim usuario As New SQLiteParameter("@usuario")
                         Dim fecha As New SQLiteParameter("@fecha")

                         ' Si el campo de texto está vacío, el parámetro es NULL.
                         ' Esto le indica a la consulta SQL que ignore el filtro.
                         If String.IsNullOrWhiteSpace(TXT_BuscarUsuario.Text) Then
                             usuario.Value = DBNull.Value
                         Else
                             ' Se agrega la búsqueda por patrón LIKE para ser más flexible
                             usuario.Value = TXT_BuscarUsuario.Text
                         End If

                         ' Si el switch no está marcado, se ignora la fecha en el filtro
                         If SWT_ActivateDateSearch.Checked Then
                             fecha.Value = DTP_Desde.Value
                         Else
                             fecha.Value = DBNull.Value
                         End If

                         ' Se crea una lista para almacenar los parámetros
                         'Se añaden los parémtros a la lista
                         Dim paramList As New List(Of SQLiteParameter) From {
                             usuario,
                             fecha
                         }

                         ' Verificamos si la invocación es necesaria
                         Invoke(Sub()
                                    'Se carga la tabla con esa lista de parámetros indicado
                                    CargarTablaParam(T, SQL, paramList)

                                    Dim bin As New BindingSource With {
                                       .DataSource = T.Tables(0)
                                    }
                                    DGV_ListaCierres.DataSource = bin

                                    ' Mueve las siguientes dos líneas al final
                                    DGV_ListaCierres.Columns(0).Visible = False
                                    DGV_ListaCierres.Columns(1).Visible = False

                                    ' Agrega Refresh() para forzar la actualización después de todo
                                    DGV_ListaCierres.Refresh()
                                End Sub)
                     End Sub)
        End Sub

        Private Sub DGV_ListaCierres_DataBindingComplete(sender As Object, e As DataGridViewBindingCompleteEventArgs) Handles DGV_ListaCierres.DataBindingComplete
            ' Verificamos que existan al menos 11 columnas para evitar errores de índice
            If DGV_ListaCierres.Columns.Count >= 11 Then
                ' Oculta las columnas de ID, si es necesario
                DGV_ListaCierres.Columns(0).Visible = False
                DGV_ListaCierres.Columns(3).Visible = False

                ' Bucle para formatear las columnas de la 5 a la 10
                For i As Integer = 5 To 10
                    ' Aplica el formato de moneda de Costa Rica
                    DGV_ListaCierres.Columns(i).DefaultCellStyle.Format = "C"
                    DGV_ListaCierres.Columns(i).DefaultCellStyle.FormatProvider = New CultureInfo("es-CR")
                Next
            End If
        End Sub

        Private Sub BTN_RegresarArqueos_Click(sender As Object, e As EventArgs) Handles BTN_RegresarArqueos.Click
            Regresar()
        End Sub

        Private Sub TXT_BuscarUsuario_TextChanged(sender As Object, e As EventArgs) Handles TXT_BuscarUsuario.TextChanged
            ReiniciarTemporizador()
        End Sub

        Private Sub Guna2DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DTP_FechaFiltroArqueo.ValueChanged
            ReiniciarTemporizador()
        End Sub

        Private Sub SWT_ActivateDateSearch_CheckedChanged(sender As Object, e As EventArgs) Handles SWT_ActivateDateSearch.CheckedChanged
            If SWT_ActivateDateSearch.Checked Then
                DTP_FechaFiltroArqueo.Enabled = True
            Else
                DTP_FechaFiltroArqueo.Enabled = False
            End If
        End Sub

        Private Sub MNU_ARQUEO_DATOS_Click(sender As Object, e As EventArgs) Handles MNU_ARQUEO_DATOS.Click
            Dim cierre = DGV_ListaCierres.SelectedRows(0)
            SQL = "SELECT ac.ID, ac.ID_Usuario, u.usuario As 'Cajero', ac.fondo_inicial As 'Fondo Inicial', ac.hora_apertura As 'Hora Apertura', " &
                    "ac.hora_cierre As 'Hora Cierre', SUM(mc.ID) As '# Movimientos', ac.efectivo_contado As 'Efectivo contado', ac.diferencia As 'Diferencia' " &
                    "FROM Arqueo_Caja ac  LEFT JOIN usuario u ON U.ID = AC.ID_Usuario  LEFT JOIN Movimientos_Caja mc  ON mc.ID_arqueo  = AC.ID " &
                    "WHERE (@usuario IS NULL OR u.usuario LIKE '%' || @usuario || '%') " &
                    "(@fecha IS NULL OR DATE(ac.hora_cierre) = DATE(@fecha) OR DATE(ac.hora_apertura) = DATE(@fecha)) " &
                    "GROUP BY ac.ID ORDER BY ac.hora_cierre"
            Dim datosCierre As New Cls_CierreCaja With {
                .ID = cierre.Cells("ID").Value,
                .ID_Usuario = cierre.Cells("ID_Usuario").Value,
                .Cajero = cierre.Cells("Cajero").Value,
                .fondo_inicial = cierre.Cells("Fondo Inicial").Value,
                .hora_apertura = cierre.Cells("Hora Apertura").Value,
                .hora_cierre = cierre.Cells("Hora Cierre").Value,
                .efectivo_contado = cierre.Cells("Efectivo contado").Value,
                .diferencia = cierre.Cells("Diferencia").Value
            }

            Using frmVerDatos As New D_VerDatosCierre
                frmVerDatos.Owner = Me
                frmVerDatos.datosCierre = datosCierre
                frmVerDatos.ShowDialog()
            End Using
        End Sub


#End Region
    End Class

End Namespace