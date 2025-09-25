Imports System.Globalization
Imports SistemaFacturaciónCommon.SistemaFacturacion.Data
Namespace SistemaFacturacion.Forms.Dialogos

    Public Class D_VerDatosCierre
        Friend datosCierre As Cls_CierreCaja
        Private Sub BTN_RegresarVerCC_Click(sender As Object, e As EventArgs) Handles BTN_RegresarVerCC.Click
            Owner.Select()
            Me.Close()
        End Sub

        Private Sub D_VerDatosCierre_Load(sender As Object, e As EventArgs) Handles MyBase.Load
            'TXT_VerCCSaldoInicial.Text = datosCierre.fondo_inicial.ToString("C", New CultureInfo("es-CR"))
            'TXT_VerCCVentaTarjeta.Text = datosCierre.ingresoTarjeta.ToString("C", New CultureInfo("es-CR"))
            'TXT_VerCCVentaEfectivo.Text = datosCierre.ingresoEfectivo.ToString("C", New CultureInfo("es-CR"))
            'TXT_VerCCSalidasEfectivo.Text = datosCierre.salidasEfectivo.ToString("C", New CultureInfo("es-CR"))
            ''Se calcula el total esperado
            ''Saldo esperado = saldoInicial + Ventas - salidas
            'Dim totalEsperado = CInt(datosCierre.fondo_inicial) + CInt(datosCierre.ingresoEfectivo) - CInt(datosCierre.SalidasEfectivo)
            'TXT_VerCCTotalEsperado.Text = totalEsperado.ToString("C", New CultureInfo("es-CR"))

            'TXT_VerCCEfectivoContado.Text = datosCierre.efectivoContado.ToString("C", New CultureInfo("es-CR"))

            ''Se calcula la diferencia absoluta y porcentual
            ''Diferencia absoluta = saldoEsperado - saldoReal
            'Dim diffAbsoluta As Decimal = CInt(datosCierre.efectivoContado) - totalEsperado
            ''Diferencia porcentual = saldoReal * 100 / saldoEsperado
            'Dim diffPorc As Decimal
            'If totalEsperado <> 0 Then
            '    diffPorc = (diffAbsoluta / Math.Abs(totalEsperado)) * 100
            'End If
            ''Se asignan los valores de las diferencias
            'TXT_VerCCDiferenciaAbsoluta.Text = diffAbsoluta.ToString("C", New CultureInfo("es-CR"))
            'TXT_VerCCDiferenciaPorcentual.Text = diffPorc

            'TXT_VerCCSaldoSiguienteEfectivo.Text = datosCierre.saldoSiguiente.ToString("C", New CultureInfo("es-CR"))
            'TXT_VerCCComentario.Text = datosCierre.comentarios
        End Sub
    End Class
End Namespace
