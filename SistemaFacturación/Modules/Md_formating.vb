Imports Guna.UI2.WinForms
Namespace SistemaFacturacion.Modules

    Module Md_formating
        Friend Sub formatHeaderText(formatedNames As Dictionary(Of String, String), DGV As Guna2DataGridView)
            For Each formatedName In formatedNames
                If DGV.Columns.Contains(formatedName.Key) Then
                    DGV.Columns(formatedName.Key).HeaderText = formatedName.Value
                End If
            Next
        End Sub

        Friend Sub formatDGV(DGV As Guna2DataGridView, hiddenColumns As List(Of String), formatedNames As Dictionary(Of String, String), ColumnsSize As Dictionary(Of String, Integer))
            For Each col As String In hiddenColumns
                If DGV.Columns.Contains(col) Then
                    DGV.Columns(col).Visible = False
                End If
            Next

            formatHeaderText(formatedNames, DGV)

            DGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

            For Each colSize As KeyValuePair(Of String, Integer) In ColumnsSize
                If DGV.Columns.Contains(colSize.Key) Then
                    DGV.Columns(colSize.Key).FillWeight = colSize.Value
                End If
            Next
        End Sub
    End Module
End Namespace
