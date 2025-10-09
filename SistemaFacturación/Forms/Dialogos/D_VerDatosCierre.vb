Imports System.Globalization
Imports SistemaFacturaciónCommon.SistemaFacturacion.Data
Imports SistemaFacturaciónCommon.SistemaFacturacion.Modules
Namespace SistemaFacturacion.Forms.Dialogos

    Public Class D_VerDatosCierre
        Friend datosCierre As Cls_CierreCaja

        Private Async Sub D_VerDatosCierre_Load(sender As Object, e As EventArgs) Handles MyBase.Load
            'Se obtiene la lista de ventas
            Dim listaVentas = Await ObtenerListaVentas(datosCierre.hora_apertura, datosCierre.hora_cierre, T)

            For Each venta As Cls_DatosFactura In listaVentas
                If venta.TipoPago = "Efectivo" Then
                    datosCierre.ingresoEfectivo += venta.TotalCaja
                ElseIf venta.TipoPago = "Mixto" Then
                    datosCierre.ingresoEfectivo += venta.Efectivo
                    datosCierre.ingresoTarjeta += venta.Tarjeta
                Else
                    datosCierre.ingresoTarjeta += venta.TotalCaja
                End If
            Next

            'Se obtiene la información de las entradas y salidas de efectivo en caja
            'Primero se obtienen los totales
            Await datosCierre.ObtenerTotalMovimientosCaja()

            'Se calcula el total esperado y la diferencia
            Dim saldo_esperado = datosCierre.CargarTotalEsperadoYDiferenciaDetalles()

            ' Se asignan los valores a las cajas de texto
            TXT_SaldoInicial.Text = datosCierre.Formated_Fondo_inicial
            TXT_VentaTarjeta.Text = datosCierre.Formated_IngresoTarjeta
            TXT_VentaEfectivo.Text = datosCierre.Formated_IngresoEfectivo

            TXT_SalidasRegistradas.Text = datosCierre.Formated_SalidasEfectivo
            TXT_EntradasRegistradas.Text = datosCierre.Formated_EntradasEfectivo

            LBL_Usuario.Text = datosCierre.Cajero
            TXT_SaldoEsperado.Text = saldo_esperado
            TXT_SaldoReal.Text = datosCierre.Formated_Efectivo_Contado

            TXT_DiferenciaAbsoluta.Text = datosCierre.diferencia.ToString("#0.00")
            TXT_DiferenciaPorcentual.Text = datosCierre.diferenciaPorcentaje.ToString("#0.00") & "%"

        End Sub

        Private Sub BTN_RegresarCierreCaja_Click(sender As Object, e As EventArgs) Handles BTN_RegresarCierreCaja.Click
            Me.DialogResult = DialogResult.Cancel
        End Sub

        Private Async Sub REFRESCAR_MOVIMIENTOS()
            If datosCierre Is Nothing Then
                Exit Sub
            End If
            Dim listaMovimientos = Await datosCierre.obtenerListaMovimientos(CBX_tipoConcepto.Text)

            Dim bin As New BindingSource With {
                .DataSource = listaMovimientos
            }
            DGV_ListaMovimientos.DataSource = bin
        End Sub

        Private Sub CBX_tipoConcepto_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBX_tipoConcepto.SelectedIndexChanged
            REFRESCAR_MOVIMIENTOS()
        End Sub

        Private Sub D_VerDatosCierre_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
            REFRESCAR_MOVIMIENTOS()
        End Sub
    End Class
End Namespace
