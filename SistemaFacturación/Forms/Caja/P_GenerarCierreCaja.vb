Imports System.Data.SQLite
Imports System.Globalization
Imports Guna.UI2.WinForms
Imports SistemaFacturaciónCommon.SistemaFacturacion.Data
Imports SistemaFacturaciónCommon.SistemaFacturacion.Modules

Namespace SistemaFacturacion.Forms.Caja
    Public Class P_GenerarCierreCaja
#Region "Variables y funciones generales"
        Dim listTxtDenominaciones As New Dictionary(Of Integer, Guna2NumericUpDown)
        Friend infoCierre As Cls_CierreCaja
        Friend idCierre As Integer = 0

        Private Sub InicializarListaTxtDenominaciones()
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

        Private Async Sub P_GenerarCierreCaja_Load(sender As Object, e As EventArgs) Handles MyBase.Load
            inicializarListaTxtDenominaciones()
            infoCierre = New Cls_CierreCaja()
            Await infoCierre.ObtenerInfoInicial(idCierre)
            infoCierre.ID = idCierre

            TXT_SaldoInicial.Text = infoCierre.fondo_inicial.ToString("0.00")
            TXT_VentaEfectivo.Text = infoCierre.ingresoEfectivo.ToString("0.00")
            TXT_VentaTarjeta.Text = infoCierre.ingresoTarjeta.ToString("0.00")
            TXT_SalidasRegistradas.Text = infoCierre.SalidasEfectivo.ToString("0.00")
            TXT_EntradasRegistradas.Text = infoCierre.EntradasEfectivo.ToString("0.00")
        End Sub

        Private Sub LIMPIAR_CIERRE_CAJA()
            'Se limpian todas las caja de texto de los billetes
            For Each txt In listTxtDenominaciones
                txt.Value.Text = 0
            Next

            'Se limpian las cajas de texto de totales y diferencias
            TXT_DineroReal.Text = "0.00"
            TXT_SaldoEsperado.Text = "0.00"
            TXT_DiferenciaAbsoluta.Text = "0.00"

            infoCierre.LimpiarDatos()
        End Sub
        Private Sub AsignarCantidadDenomincacion(valorContado As Decimal, valorDenominacion As Integer)
            Select Case valorDenominacion
                Case 5
                    infoCierre.saldoSiguienteTurno.Moneda5 = valorContado
                Case 10
                    infoCierre.saldoSiguienteTurno.Moneda10 = valorContado
                Case 25
                    infoCierre.saldoSiguienteTurno.Moneda25 = valorContado
                Case 50
                    infoCierre.saldoSiguienteTurno.Moneda50 = valorContado
                Case 100
                    infoCierre.saldoSiguienteTurno.Moneda100 = valorContado
                Case 500
                    infoCierre.saldoSiguienteTurno.Moneda500 = valorContado
                Case 1000
                    infoCierre.saldoSiguienteTurno.Billete1 = valorContado
                Case 2000
                    infoCierre.saldoSiguienteTurno.Billete2 = valorContado
                Case 5000
                    infoCierre.saldoSiguienteTurno.Billete5 = valorContado
                Case 10000
                    infoCierre.saldoSiguienteTurno.Billete10 = valorContado
                Case 20000
                    infoCierre.saldoSiguienteTurno.Billete20 = valorContado
                Case 50000
                    infoCierre.saldoSiguienteTurno.Billete50 = valorContado
            End Select
        End Sub

        'Al cambiar el valor del NUD se actualiza el total
        Private Sub NUD_ValueChanged(sender As Object, e As EventArgs)
            Dim denominacionModificada As Integer
            Select Case sender.name
                Case "NUD_Moneda5"
                    denominacionModificada = 5
                Case "NUD_Moneda10"
                    denominacionModificada = 10
                Case "NUD_Moneda25"
                    denominacionModificada = 25
                Case "NUD_Moneda50"
                    denominacionModificada = 50
                Case "NUD_Moneda100"
                    denominacionModificada = 100
                Case "NUD_Moneda500"
                    denominacionModificada = 500
                Case "NUD_Billete1"
                    denominacionModificada = 1000
                Case "NUD_Billete2"
                    denominacionModificada = 2000
                Case "NUD_Billete5"
                    denominacionModificada = 5000
                Case "NUD_Billete10"
                    denominacionModificada = 10000
                Case "NUD_Billete20"
                    denominacionModificada = 20000
                Case "NUD_Billete50"
                    denominacionModificada = 50000
            End Select

            AsignarCantidadDenomincacion(sender.value, denominacionModificada)
            'Se calcula el total de dinero real en caja según las denominaciones
            TXT_DineroReal.Text = infoCierre.saldoSiguienteTurno.formated_total

            'Se obtienen los datos de saldo esperado y diferencias desde la misma función
            TXT_SaldoEsperado.Text = infoCierre.CargarTotalEsperadoYDiferencia()
            TXT_DiferenciaAbsoluta.Text = infoCierre.Diferencia.ToString("0.00")
            TXT_DiferenciaPorcentual.Text = infoCierre.DiferenciaPorcentaje.ToString("0.00")
        End Sub
#End Region

        Private Async Sub BTN_CerrarSesionCaja_Click(sender As Object, e As EventArgs) Handles BTN_CerrarSesionCaja.Click
            ' Nos aseguramos de tener los datos del calculo actualizados
            infoCierre.CargarTotalEsperadoYDiferencia()
            ' Guardar el cierre de caja
            If Not Await infoCierre.guardarCierre() Then
                msgError("Error interno al realizar el cierre")
                Me.DialogResult = DialogResult.Cancel
            End If

            Dim listaDenominaciones As New Cls_SaldoCaja With {
                .Moneda5 = NUD_Moneda5.Value,
                .Moneda10 = NUD_Moneda10.Value,
                .Moneda25 = NUD_Moneda25.Value,
                .Moneda50 = NUD_Moneda50.Value,
                .Moneda100 = NUD_Moneda100.Value,
                .Moneda500 = NUD_Moneda500.Value,
                .Billete1 = NUD_Billete1.Value,
                .Billete2 = NUD_Billete2.Value,
                .Billete5 = NUD_Billete5.Value,
                .Billete10 = NUD_Billete10.Value,
                .Billete20 = NUD_Billete20.Value,
                .Billete50 = NUD_Billete50.Value
            }

            infoCierre.saldoSiguienteTurno = listaDenominaciones

            Me.DialogResult = DialogResult.OK
        End Sub

        Private Sub BTN_RegresarCierreCaja_Click(sender As Object, e As EventArgs) Handles BTN_RegresarCierreCaja.Click
            Me.DialogResult = DialogResult.Cancel
        End Sub

        Private Sub BTN_LimpiarCierre_Click(sender As Object, e As EventArgs) Handles BTN_LimpiarCierre.Click
            LIMPIAR_CIERRE_CAJA()
        End Sub
    End Class
End Namespace