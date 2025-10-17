Imports System.Globalization
Imports Guna.UI2.WinForms
Imports SistemaFacturaciónCommon.SistemaFacturacion.Data
Imports SistemaFacturaciónCommon.SistemaFacturacion.Modules.Md_formating
Imports SistemaFacturaciónCommon.SistemaFacturacion.Modules.Md_Inicializacion
Imports Syncfusion.Windows.Forms.Tools

Namespace SistemaFacturacion.Forms.CuentasXCobrar

    Public Class P_VerDetallesCxC
        Friend ID As Integer
        Private culturaCR As New CultureInfo("es-CR")


        Private Sub D_VerDetallesCxC_Load(sender As Object, e As EventArgs) Handles MyBase.Load
            GetData()
        End Sub

        Friend Sub GetData()
            Try

            Catch ex As Exception

            End Try
            Dim cxc As New Cls_CuentasXCobrar
            cxc.GetDetailsWithID(ID)
            lblCliente.Text = cxc.Cliente
            lblFechaCreacion.Text = cxc.Fecha_creacion.ToString("dd/MM/yyyy hh:mm:ss tt")

            TXT_Total.Text = cxc.Formated_saldo_total
            TXT_Comentario.Text = cxc.Comentario

            lblCantProds.Text = cxc.ListaProductos.Count
            Dim binProd As New BindingSource With {.DataSource = cxc.ListaProductos}
            DGV_ListProds.DataSource = binProd

            lblSaldoRestante.Text = cxc.ObtenerSaldoPendiente().ToString("C", culturaCR)
            Dim binAbono As New BindingSource With {.DataSource = cxc.ListaPagos}
            DGV_ListaAbonos.DataSource = binAbono

        End Sub
        Private Sub BTN_Regresar_Click(sender As Object, e As EventArgs) Handles BTN_Regresar.Click
            Owner.Show()
            isNavigating = True
            Me.Close()
        End Sub

        Private Sub DGV_ListProds_DataBindingComplete(sender As Object, e As DataGridViewBindingCompleteEventArgs) Handles DGV_ListProds.DataBindingComplete
            Dim hiddenColumns As New List(Of String) From {
                {"ID"},
                {"Precio"},
                {"total"}
            }
            Dim formatedNames As New Dictionary(Of String, String) From {
                {"cantidad", "Cantidad"},
                {"formated_Precio", "Precio Unitario"},
                {"formated_total", "Total"}
            }
            Dim columnSizes As New Dictionary(Of String, Integer) From {
                {"Nombre", 400},
                {"Codigo", 40},
                {"formated_Precio", 60},
                {"cantidad", 60},
                {"formated_total", 60}
            }
            formatDGV(DGV_ListProds, hiddenColumns, formatedNames, columnSizes)
        End Sub

        Private Sub DGV_ListaAbonos_DataBindingComplete(sender As Object, e As DataGridViewBindingCompleteEventArgs) Handles DGV_ListaAbonos.DataBindingComplete

            Dim hiddenColumns As New List(Of String) From {
                {"ID"},
                {"ID_CxC"},
                {"ID_Usuario"},
                {"tipo_venta"},
                {"Vuelto"},
                {"monto_efectivo"},
                {"monto_tarjeta"},
                {"total"}
            }
            Dim formatedNames As New Dictionary(Of String, String) From {
                {"Fecha", "Fecha"},
                {"tipo_venta_value", "Tipo Venta"},
                {"formated_monto_efectivo", "Efectivo"},
                {"formated_monto_tarjeta", "Tarjeta"},
                {"formated_total", "Total"},
                {"formated_vuelto", "Vuelto"},
                {"Comentario", "Comentario"}
            }
            Dim columnSizes As New Dictionary(Of String, Integer) From {
                {"Comentario", 500},
                {"Fecha", 90},
                {"tipo_venta_value", 100},
                {"formated_monto_efectivo", 90},
                {"formated_monto_tarjeta", 90},
                {"formated_total", 90}
            }

            formatDGV(DGV_ListaAbonos, hiddenColumns, formatedNames, columnSizes)
            DGV_ListaAbonos.RowHeadersDefaultCellStyle.Alignment = TextAlignment.Center
        End Sub

        Private Sub BTN_ActualizarCuenta_Click(sender As Object, e As EventArgs) Handles BTN_ActualizarCuenta.Click
            Dim cajaForm As New P_CajaCxC With {
                .idCuenta = ID,
                .Owner = Me
            }
            cajaForm.Show()
            Me.Hide()
        End Sub
    End Class


End Namespace