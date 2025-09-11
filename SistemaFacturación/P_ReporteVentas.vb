Imports System.Configuration
Imports System.Data.SQLite
Imports System.Drawing.Printing
Imports System.Globalization
Imports System.Windows.Forms
Imports Guna.UI2.WinForms
Imports Syncfusion.Pdf
Imports Syncfusion.Pdf.Graphics

Public Class P_ReporteVentas

    ' Declaración de un diccionario para rastrear el estado de carga de cada pestaña.
    Private _tabLoaded As New Dictionary(Of String, Boolean) From {
    {"PAG_ReporteVentas", False},
    {"PAG_ReporteProd", False},
    {"PAG_CierreCaja", False}
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

            Case "PAG_CierreCaja"
                ' Lógica para cargar los datos de la pestaña de Configuración.
                'Se carga la lista de denominaciones del cierre de caja
                inicializarListaTxtDenominaciones()

                'Se carga la información del cierre de caja
                ObtenerDatosCierreDeCaja()

                AddHandler TXT_EfectivoReal.TextChanged, AddressOf CargarTotalEsperadoYDiferencia
                AddHandler NUD_SalidasEfectivo.ValueChanged, AddressOf CargarTotalEsperadoYDiferencia

                ' Actualiza el estado de carga para evitar recargas.
                _tabLoaded("PAG_CierreCaja") = True
        End Select
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
        encabezadoFactura = ""
        'Se limpia la lista de productos
        For Each line As String In facturaContenido.ToList()
            facturaContenido.Remove(line)
        Next

        finFactura = ""
        GENERAR_FACTURA(DGV_FactReporte.SelectedRows(0).Cells(0).Value.ToString(), True)
        ImprimirFactura()
    End Sub

    Private Sub MNU_Datos_Click(sender As Object, e As EventArgs) Handles MNU_Datos.Click
        Dim datosFactura As New Cls_DatosFactura With {
            .IdFactura = DGV_FactReporte.SelectedRows(0).Cells(0).Value.ToString(),
            .NumFactura = DGV_FactReporte.SelectedRows(0).Cells(1).Value.ToString(),
            .Fecha = DGV_FactReporte.SelectedRows(0).Cells(2).Value.ToString(),
            .Cliente = DGV_FactReporte.SelectedRows(0).Cells(3).Value.ToString(),
            .Cajero = DGV_FactReporte.SelectedRows(0).Cells(4).Value.ToString(),
            .Comentario = DGV_FactReporte.SelectedRows(0).Cells(5).Value.ToString(),
            .Efectivo = DGV_FactReporte.SelectedRows(0).Cells(6).Value.ToString(),
            .Tarjeta = DGV_FactReporte.SelectedRows(0).Cells(7).Value.ToString(),
            .TotalCaja = DGV_FactReporte.SelectedRows(0).Cells(8).Value.ToString(),
            .TipoPago = DGV_FactReporte.SelectedRows(0).Cells(9).Value.ToString(),
            .Vuelto = DGV_FactReporte.SelectedRows(0).Cells(10).Value.ToString()
        }
        ' Crea la instancia del formulario
        Dim frmDatosFactura As New P_DatosFactura With {
            .Owner = Me
        }

        ' Llama a la nueva subrutina para cargar los datos en el formulario
        frmDatosFactura.CargarDatos(datosFactura)

        ' Muestra el formulario
        frmDatosFactura.Show()
    End Sub

    Private Sub BTN_GenerarReporteVentaPDF_Click(sender As Object, e As EventArgs) Handles BTN_GenerarReporteVentaPDF.Click
        'If MsgBox("Desea generar el reporte con la información indicada?") = DialogResult.OK Then
        '    Md_Reportes.Crear_PDF_ReporteVentas(DTP_Desde.Value, DTP_Hasta.Value)
        'End If
    End Sub

    Private Sub PrintDocument_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument.PrintPage
        Dim font As New Font("Arial", 12)
        Dim fontProds As New Font("Segoe UI", 9)
        Dim brush As New SolidBrush(Color.Black)
        Dim stringFormat As New StringFormat() With {
        .Alignment = StringAlignment.Near,
        .LineAlignment = StringAlignment.Near
        }

        Dim totalWidth As Single = 72 * 3.78
        Dim cellWidth As Single = totalWidth / 4
        Dim leftMargin As Single = e.MarginBounds.Left
        Dim topMargin As Single = e.MarginBounds.Top
        Dim yPos As Single = topMargin

        ' Dibujar el encabezado
        e.Graphics.DrawString(encabezadoFactura, font, brush, leftMargin, yPos, stringFormat)
        yPos += e.Graphics.MeasureString(encabezadoFactura, font).Height + 10 ' Espacio adicional después del encabezado

        ' Dibujar el encabezado de la tabla de productos
        e.Graphics.DrawString(encabezadoProds, fontProds, brush, leftMargin, yPos, stringFormat)
        yPos += e.Graphics.MeasureString(encabezadoProds, fontProds).Height + 10 ' Espacio adicional después del encabezado

        ' Dibujar los productos
        For Each line As String In facturaContenido
            Dim columns() As String = line.Split(New Char() {"."c}, StringSplitOptions.RemoveEmptyEntries) ' Cambiar el delimitador si es necesario

            Dim maxHeight As Single = 0

            For colIndex As Integer = 0 To columns.Length - 1
                Dim rect As New RectangleF(leftMargin + (colIndex * cellWidth), yPos, cellWidth, 0)
                Dim size As SizeF = e.Graphics.MeasureString(columns(colIndex), fontProds, rect.Size, stringFormat)

                If size.Height > maxHeight Then
                    maxHeight = size.Height
                End If

                rect.Height = maxHeight
                e.Graphics.DrawString(columns(colIndex), fontProds, brush, rect, stringFormat)
            Next

            yPos += maxHeight + 5 ' Asegurar que el yPos se incremente para cada línea de productos
        Next

        yPos += 10 ' Espacio adicional después de los productos
        e.Graphics.DrawString(finFactura, font, brush, leftMargin, yPos, stringFormat)
    End Sub


    ' Método para iniciar la impresión
    Private Sub ImprimirFactura()
        Dim printDoc As New PrintDocument()
        AddHandler printDoc.PrintPage, AddressOf PrintDocument_PrintPage
        ' Configurar el tamaño de papel personalizado en pulgadas
        Dim customPaperSize As New PaperSize("Custom", CInt(72 * 3.937), CInt(297 * 3.937))
        printDoc.DefaultPageSettings.PaperSize = customPaperSize

        ' Configurar márgenes a cero
        printDoc.DefaultPageSettings.Margins = New Margins(0, 0, 0, 0)

        Dim printPreview As New PrintPreviewDialog With {
            .Document = printDoc
        }
        printDoc.Print()

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

#Region "Cierre de caja"

    Dim totalCajaReal As Integer
    Dim listTxtDenominaciones As New Dictionary(Of Integer, Guna2NumericUpDown)
    Dim nuevoCierre As Cls_CierreCaja
    Dim saldoSiguiente As Cls_SaldoCaja

    Private Sub inicializarListaTxtDenominaciones()
        ' Añadir cada NumericUpDown de denominación a la lista
        listTxtDenominaciones.Add(5, NUD_Moneda5)
        listTxtDenominaciones.Add(10, NUD_Moneda10)
        listTxtDenominaciones.Add(25, NUD_Moneda25)
        listTxtDenominaciones.Add(50, NUD_Moneda50)
        listTxtDenominaciones.Add(100, NUD_Moneda100)
        listTxtDenominaciones.Add(500, NUD_Moneda500)
        listTxtDenominaciones.Add(1000, NUD_Billete1)
        listTxtDenominaciones.Add(2000, NUD_Billete2)
        listTxtDenominaciones.Add(5000, NUD_Billete5)
        listTxtDenominaciones.Add(10000, NUD_Billete10)
        listTxtDenominaciones.Add(20000, NUD_Billete20)
        listTxtDenominaciones.Add(50000, NUD_Billete50)

        ' Asignar el evento a cada control en la lista
        For Each nud In listTxtDenominaciones.Values
            AddHandler nud.ValueChanged, AddressOf NUD_ValueChanged
        Next
    End Sub

    Private Sub CalcularMontoEfectivoCajaReal()
        ' Reinicia el totalCajaReal a cero antes de cada cálculo
        totalCajaReal = 0
        For Each denominacion In listTxtDenominaciones
            Dim valorContado As Decimal = denominacion.Value.Value
            Dim valorDenominacion As Integer = denominacion.Key

            ' Multiplica el valor del billete o la moneda por la cantidad contada
            totalCajaReal += valorDenominacion * valorContado
        Next

        TXT_EfectivoReal.Text = totalCajaReal.ToString("C", New CultureInfo("es-CR"))
    End Sub

    'Al cambiar el valor del NUD se actualiza el total
    Private Sub NUD_ValueChanged(sender As Object, e As EventArgs)
        CalcularMontoEfectivoCajaReal()
    End Sub

    Private Sub Guna2Button3_Click(sender As Object, e As EventArgs) Handles Guna2Button3.Click
        Regresar()
    End Sub

    Private Async Sub ObtenerDatosCierreDeCaja()
        nuevoCierre = Await obtenerCierreCajaInicial()

        TXT_CCSaldoInicial.Text = nuevoCierre.saldo_inicial
        TXT_CCVentaEfectivo.Text = nuevoCierre.ingresoEfectivo
        TXT_CCVentaTarjeta.Text = nuevoCierre.ingresoTarjeta
    End Sub

    Private Sub CargarTotalEsperadoYDiferencia()
        'Se obtienen los datos de saldo inicial, ventas en efectivo
        Dim saldoInicial As Decimal
        Dim ventaEfectivo As Decimal
        If Not Decimal.TryParse(TXT_CCSaldoInicial.Text, saldoInicial) Then
            msgError("El formato de las ventas en efectivo no es correcta")
        End If
        If Not Decimal.TryParse(TXT_CCVentaEfectivo.Text, ventaEfectivo) Then
            msgError("El formato de las ventas en efectivo no es correcto")
        End If

        'Salidas
        Dim Salidas As Decimal = NUD_SalidasEfectivo.Value

        'Saldo esperado = saldoInicial + Ventas - salidas
        Dim saldoEsperado = saldoInicial + ventaEfectivo - Salidas

        'Se obtiene el valor del saldo real contado de la caja
        Dim saldoReal As Decimal
        If Not Decimal.TryParse(TXT_EfectivoReal.Text.Replace("₡", "").Replace(" ", ""), saldoReal) Then
            msgError("El formato del efectivo real en caja no es correcto")
        End If
        'Diferencia absoluta = saldoEsperado - saldoReal
        Dim diffAbsoluta As Decimal = saldoReal - saldoEsperado
        'Diferencia porcentual = saldoReal * 100 / saldoEsperado
        Dim diffPorc As Decimal = 0
        If saldoEsperado <> 0 Then
            diffPorc = (diffAbsoluta / Math.Abs(saldoEsperado)) * 100
        End If

        'Se asignan los datos a los campos de texto necesarios
        TXT_CCTotalEsperado.Text = saldoEsperado.ToString("0.00")
        TXT_CCDiferenciaAbsoluta.Text = diffAbsoluta.ToString("0.00")
        TXT_CCDiferenciaPorcentual.Text = diffPorc.ToString("0.00")
    End Sub

    Private Async Sub BTN_GenerarCierre_Click(sender As Object, e As EventArgs) Handles BTN_GenerarCierre.Click
        If Not msgGuardarCierre() Then
            'Si no desea guardarlo no hace nada
            Return
        End If
        'Se agrega a la información que ya se le agrega al objeto los datos restantes
        nuevoCierre.comentarios = TXT_CCComentario.Text
        nuevoCierre.saldoSiguiente = NUD_CCSaldoSiguienteTurno.Value
        nuevoCierre.efectivoContado = Convert.ToDecimal(TXT_EfectivoReal.Text.Replace("₡", "").Replace(" ", ""))
        nuevoCierre.salidasEfectivo = NUD_SalidasEfectivo.Value

        'Se guarda la info en la DB
        'Si no se logra guardar correctamente devuel el mensaje de error
        If Not Await guardarNuevoCierre(GetConnectionString(), nuevoCierre) Then
            msgError("Error al generar el cierre de la caja")
            Return
        End If

        'Se limpia la caja
        LIMPIAR_CIERRE_CAJA()
    End Sub

    Private Sub LIMPIAR_CIERRE_CAJA()
        'Se limpian todas las caja de texto de los billetes
        For Each txt In listTxtDenominaciones
            txt.Value.Text = 0
        Next

        TXT_CCComentario.Text = ""
        NUD_CCSaldoSiguienteTurno.Value = 0
        NUD_CCSaldoSiguienteTurno.Value = 0

        ObtenerDatosCierreDeCaja()
    End Sub

    Private Sub BTN_CCLimpiarCierre_Click(sender As Object, e As EventArgs) Handles BTN_CCLimpiarCierre.Click
        LIMPIAR_CIERRE_CAJA()
    End Sub

    Private Sub BTN_CalcularSaldoSiguiente_Click(sender As Object, e As EventArgs) Handles BTN_CalcularSaldoSiguiente.Click
        ' Lógica para asegurar que el objeto no esté vacío la primera vez que se usa
        If saldoSiguiente Is Nothing Then
            ' Si es la primera vez que se abre, crea un objeto vacío
            saldoSiguiente = New Cls_SaldoCaja()
        End If

        ' Clonar el objeto *antes* de abrir el formulario de diálogo
        Dim saldoParaDialogo As Cls_SaldoCaja = saldoSiguiente.Clonar(saldoSiguiente)

        Using frmCalcularSaldo As New D_CalcularSaldoSiguiente(saldoParaDialogo)
            frmCalcularSaldo.Owner = Me

            frmCalcularSaldo.ShowDialog()

            ' Verifica el resultado del dialogo
            If frmCalcularSaldo.ResultadoDelDialogo = DialogResult.OK Then
                ' El formulario de diálogo ahora devuelve el objeto modificado
                saldoSiguiente = frmCalcularSaldo.saldoSiguiente
                NUD_CCSaldoSiguienteTurno.Value = saldoSiguiente.Total
            Else
                Return
            End If
        End Using
    End Sub

#End Region
End Class