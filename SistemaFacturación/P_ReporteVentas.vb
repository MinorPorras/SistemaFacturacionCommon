Imports System.Configuration
Imports System.Globalization
Imports System.Windows.Forms

Public Class P_ReporteVentas

#Region "Metodos compartidos"
    Private Sub P_ReporteVentas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Se carag la fecha actual
        CargarFechaActual()
        'Se aplican los estilos a los Data grid view
        AplicarEstiloDataGridView(DGV_FactReporte)
        AplicarEstiloDataGridView(DGV_ListProductosMasVendidos)
        RDB_OrderByCant.Checked = True
    End Sub
    Private Sub Regresar()
        M_Inicio.Show()
        M_Inicio.BringToFront()
        Me.Close()
    End Sub

    Private Sub CargarFechaActual()
        DTP_Desde.Value = Date.Now
        DTP_Hasta.Value = Date.Now
        DTP_DesdeReporteProducto.Value = Date.Now
        DTP_HastaReporteProducto.Value = Date.Now
    End Sub

    ' Este método puede estar en un módulo o en tu clase del formulario
    Private Sub AplicarEstiloDataGridView(ByVal dgv As Guna.UI2.WinForms.Guna2DataGridView)
        ' Deshabilita los estilos visuales del encabezado para que el estilo manual se aplique
        dgv.EnableHeadersVisualStyles = False

        ' Estilo para todas las filas
        Dim rowStyle As New DataGridViewCellStyle()
        rowStyle.Font = New Font("Segoe UI", 12)
        rowStyle.BackColor = Color.White
        rowStyle.SelectionBackColor = Color.FromArgb(240, 240, 240) ' Un gris muy claro
        rowStyle.SelectionForeColor = Color.Black
        rowStyle.ForeColor = Color.Black
        rowStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        dgv.DefaultCellStyle = rowStyle

        ' Estilo para las filas alternas (asegurando que sea igual al estilo de fila predeterminado)
        Dim alternatingRowStyle As New DataGridViewCellStyle()
        alternatingRowStyle.Font = New Font("Segoe UI", 12)
        alternatingRowStyle.BackColor = Color.White
        alternatingRowStyle.SelectionBackColor = Color.FromArgb(240, 240, 240)
        alternatingRowStyle.SelectionForeColor = Color.Black
        alternatingRowStyle.ForeColor = Color.Black
        alternatingRowStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        dgv.AlternatingRowsDefaultCellStyle = alternatingRowStyle

        ' Estilo para el encabezado de las columnas
        Dim headerStyle As New DataGridViewCellStyle()
        headerStyle.Font = New Font("Segoe UI", 12, FontStyle.Bold)
        headerStyle.BackColor = Color.FromArgb(255, 128, 0) ' Naranja
        headerStyle.SelectionBackColor = Color.FromArgb(255, 128, 0) ' Naranja (El color de la selección del encabezado)
        headerStyle.ForeColor = Color.Black
        headerStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
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

            'Se agrega el total de ventas global
            TXT_TotalVentas.Text = reporte.total_ventas.ToString("C", New CultureInfo("es-CR"))

            'Se agrega el total de ventas en efectivo y en tarjeta
            TXT_VentasEfectivo.Text = reporte.ventas_efectivo.ToString("C", New CultureInfo("es-CR"))
            TXT_VentasTarjeta.Text = reporte.ventas_tarjeta.ToString("C", New CultureInfo("es-CR"))

            'Se agrega el número de ventas en el rango
            TXT_CantFacturas.Text = reporte.num_ventas.ToString("N0")

            'Se agregan los datos de producto más vendido
            If reporte.ProductoMasVendido IsNot Nothing Then
                TXT_NombreProdMasVendido.Text = reporte.ProductoMasVendido.nombre
                TXT_CantProdMasVendido.Text = reporte.ProductoMasVendido.cantidad.ToString("N0")
                TXT_TotalProdMasVendido.Text = reporte.ProductoMasVendido.total.ToString("C", New CultureInfo("es-CR"))
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
#End Region

#Region "Reporte productos"

    Private Sub BTN_RegresarReporteProducto_Click(sender As Object, e As EventArgs) Handles BTN_RegresarReporteProducto.Click
        Regresar()
    End Sub

    Private Async Sub BTN_GenReporteProductos_Click(sender As Object, e As EventArgs) Handles BTN_GenReporteProductos.Click
        'Se desabilta el botón durante la creación del reporte
        BTN_GenReporteProductos.Enabled = False
        BTN_GenReporteProductos.Text = "Generando reporte..."
        BTN_GenReporteProductos.BackColor = Color.FromKnownColor(KnownColor.Gray)

        'Se obtiene el valor del límite
        Dim limit As Integer = Convert.ToInt32(NUD_LimitReporteProducto.Value)

        Dim stringConexion As String = ConfigurationManager.ConnectionStrings("conexionString").ConnectionString
        Dim orderBy As Integer
        If RDB_OrderByCant.Checked = True Then
            orderBy = 1
        Else
            orderBy = 2
        End If
        Dim listaProd = Await getProductosMasVendido(stringConexion, limit, DTP_DesdeReporteProducto.Value, DTP_HastaReporteProducto.Value, orderBy)

        If listaProd.Count <= 0 Then
            msgError("No hay productos que mostrar en este rango")
            Return
        End If

        TXT_MejorProductoNombre.Text = listaProd(0).nombre
        TXT_MejorProductoCant.Text = listaProd(0).cantidad.ToString("N0")
        TXT_MejorProductoTotal.Text = listaProd(0).total.ToString("C", New CultureInfo("es-CR"))

        'Se añaden los datos de la lista de productos más vendidos al data grid
        Dim bin As New BindingSource With {
                .DataSource = listaProd
            }
        DGV_ListProductosMasVendidos.AutoGenerateColumns = True
        DGV_ListProductosMasVendidos.DataSource = bin

        'Se vuelve a activar el botón al terminar de generar el reporte
        BTN_GenReporteProductos.Enabled = True
        BTN_GenReporteProductos.Text = "Generar reporte"
        BTN_GenReporteProductos.BackColor = Color.FromKnownColor(KnownColor.MediumSeaGreen)
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
End Class