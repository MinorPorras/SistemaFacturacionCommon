Imports System.Windows.Forms

Public Class P_ReporteVentas
    Private Sub P_ReporteVentas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DTP_Desde.Value = Date.Now
        DTP_Hasta.Value = Date.Now
    End Sub

    Private Sub BTN_GenReporte_Click(sender As Object, e As EventArgs) Handles BTN_GenReporte.Click
        Try

            BTN_GenReporte.Enabled = False
            BTN_GenReporte.Text = "Generando reporte..."
            BTN_GenReporte.BackColor = Color.FromKnownColor(KnownColor.Gray)
            GenerarReporte(DTP_Desde.Value, DTP_Hasta.Value, T)
            If T.Tables.Count > 0 AndAlso T.Tables(0).Rows.Count > 0 Then
                Dim bin As New BindingSource With {
                    .DataSource = T.Tables(0)
                }
                DGV_FactReporte.DataSource = bin
                Dim total As Decimal
                For i As Integer = 0 To T.Tables(0).Rows.Count - 1
                    total += Convert.ToDecimal(T.Tables(0).Rows(i).Item(3))
                Next
                TXT_TotalVentas.Text = String.Format("{0:₡#,##0.00}", total)
            End If
        Catch ex As Exception
            If DGV_FactReporte.IsHandleCreated Then
                If ex.Message <> "InvalidArgument=El valor de '0' no es válido para 'index'." & vbCrLf & "Nombre del parámetro: index" Then
                    ' Mostrar un mensaje de error genérico
                    msgError("Error al generar el reporte: " & ex.Message)
                End If
            End If
        Finally
            BTN_GenReporte.Enabled = True
            BTN_GenReporte.Text = "Generar reporte"
            BTN_GenReporte.BackColor = Color.FromKnownColor(KnownColor.MediumSeaGreen)
        End Try
    End Sub

    Private Sub BTN_RegresarReporte_Click(sender As Object, e As EventArgs) Handles BTN_RegresarReporte.Click
        M_Inicio.Show()
        M_Inicio.BringToFront()
        Me.Close()
    End Sub
End Class