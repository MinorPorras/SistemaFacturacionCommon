Imports System.Globalization
Imports Guna.UI2.WinForms
Imports Serilog
Namespace SistemaFacturacion.Modules

    Module Md_formating

        Public CrCultureInfo As New CultureInfo("es-CR")

        Friend Sub FormatHeaderText(formatedNames As Dictionary(Of String, String), DGV As Guna2DataGridView)
            For Each formatedName In formatedNames
                If DGV.Columns.Contains(formatedName.Key) Then
                    Log.Information("Formateando encabezado de la columna: {Column} a {HeaderText}", formatedName.Key, formatedName.Value)
                    DGV.Columns(formatedName.Key).HeaderText = formatedName.Value
                End If
            Next
        End Sub

        Friend Sub FormatDGV(DGV As Guna2DataGridView, hiddenColumns As List(Of String), formatedNames As Dictionary(Of String, String), ColumnsSize As Dictionary(Of String, Integer))
            For Each col As String In hiddenColumns
                If DGV.Columns.Contains(col) Then
                    Log.Information("Ocultando columna: {Column}", col)
                    DGV.Columns(col).Visible = False
                End If
            Next

            FormatHeaderText(formatedNames, DGV)

            DGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

            For Each colSize As KeyValuePair(Of String, Integer) In ColumnsSize
                If DGV.Columns.Contains(colSize.Key) Then
                    Log.Information("Ajustando tamaño de columna: {Column} a {Size}", colSize.Key, colSize.Value)
                    DGV.Columns(colSize.Key).FillWeight = colSize.Value
                End If
            Next
        End Sub
    End Module
End Namespace
