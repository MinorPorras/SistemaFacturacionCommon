Imports SistemaFacturaciónCommon.SistemaFacturacion.Data
Imports SistemaFacturaciónCommon.SistemaFacturacion.Modules


Namespace SistemaFacturacion.Forms.Caja
    Public Class P_DatosFactura
        Private Sub BTN_RegresarPed_Click(sender As Object, e As EventArgs) Handles BTN_RegresarPed.Click
            Me.DialogResult = DialogResult.Cancel
        End Sub

        Public Sub CargarDatos(datosFactura As Cls_Ventas)
            TXT_NumFact.Text = datosFactura.Formated_num_factura
            TXT_FechaEmision.Text = datosFactura.Fecha_creacion
            TXT_Cliente.Text = datosFactura.Cliente
            TXT_Cajero.Text = datosFactura.Cajero
            TXT_Comentario.Text = datosFactura.Comentario
            TXT_Total.Text = datosFactura.Formated_saldo_total
            TXT_Efectivo.Text = datosFactura.Formated_Efectivo
            TXT_Tarjeta.Text = datosFactura.Formated_Tarjeta
            TXT_Vuelto.Text = datosFactura.Formated_vuelto
            TXT_TipoPago.Text = datosFactura.formated_tipo_pago

            datosFactura.getListaProductos()

            Dim bin As New BindingSource With {.DataSource = datosFactura.ListaProductos}
            DGV_ProdFact.DataSource = bin
        End Sub

        Private Sub DGV_ProdFact_DataBindingComplete(sender As Object, e As DataGridViewBindingCompleteEventArgs) Handles DGV_ProdFact.DataBindingComplete
            Dim hiddenColumns As New List(Of String) From {
                "ID",
                "Precio",
                "Total"
            }
            Dim formatedNames As New Dictionary(Of String, String) From {
                {"Formated_Precio", "Precio"},
                {"Formated_Total", "Total"}
            }

            Dim columnSize As New Dictionary(Of String, Integer) From {}

            formatDGV(DGV_ProdFact, hiddenColumns, formatedNames, columnSize)

            DGV_ProdFact.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
            DGV_ProdFact.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.DisplayedCells)
            DGV_ProdFact.GridColor = Color.DarkGray
        End Sub

        Private Sub BTN_CerrarApp_Click(sender As Object, e As EventArgs) Handles BTN_CerrarApp.Click
            isNavigating = False
            Me.Close()
        End Sub

        Private Sub P_DatosFactura_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
            ManejarCierreONavegacion(e)
        End Sub
    End Class


End Namespace