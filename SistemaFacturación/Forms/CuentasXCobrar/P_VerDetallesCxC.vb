Imports System.Globalization
Imports Guna.UI2.WinForms
Imports SistemaFacturaciónCommon.SistemaFacturacion.Data
Imports SistemaFacturaciónCommon.SistemaFacturacion.Modules.Md_formating

Namespace SistemaFacturacion.Forms.CuentasXCobrar

    Public Class P_VerDetallesCxC
        Friend ID As Integer
        Private culturaCR As New CultureInfo("es-CR")


        Private Sub D_VerDetallesCxC_Load(sender As Object, e As EventArgs) Handles MyBase.Load
            getData()
        End Sub

        Private Sub getData()
            Dim cxc As New Cls_CuentasXCobrar
            cxc.getDetailsWithID(ID)
            lblCliente.Text = cxc.Cliente
            lblFechaCreacion.Text = cxc.fecha_creacion.ToString("dd/MM/yyyy hh:mm:ss tt")

            TXT_Total.Text = cxc.formated_saldo_total
            TXT_Comentario.Text = cxc.comentario

            lblCantProds.Text = cxc.listaProductos.Count
            Dim binProd As New BindingSource With {.DataSource = cxc.listaProductos}
            DGV_ListProds.DataSource = binProd

            lblSaldoRestante.Text = cxc.obtenerSaldoPendiente().ToString("C", culturaCR)
            Dim binAbono As New BindingSource With {.DataSource = cxc.listaPagos}
            DGV_ListaAbonos.DataSource = binAbono

        End Sub
        Private Sub BTN_Regresar_Click(sender As Object, e As EventArgs) Handles BTN_Regresar.Click
            Owner.Show()
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
                {"tipo_venta"},
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
                {"Comentario", "Comentario"}
            }
            Dim columnSizes As New Dictionary(Of String, Integer) From {
                {"Comentario", 600},
                {"Fecha", 60},
                {"tipo_venta_value", 70},
                {"formated_monto_efectivo", 60},
                {"formated_monto_tarjeta", 60},
                {"formated_total", 60}
            }

            formatDGV(DGV_ListaAbonos, hiddenColumns, formatedNames, columnSizes)
        End Sub

        Private Sub BTN_ActualizarCuenta_Click(sender As Object, e As EventArgs) Handles BTN_ActualizarCuenta.Click
            Using cajaForm As New P_CajaCxC
                cajaForm.idCuenta = ID
                cajaForm.ShowDialog()
                Me.Select()
            End Using
        End Sub
    End Class


End Namespace