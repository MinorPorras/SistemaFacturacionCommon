Imports System.Globalization
Imports Guna.UI2.WinForms
Imports SistemaFacturaciónCommon.SistemaFacturacion.Data

Namespace SistemaFacturacion.Forms.Dialogos
    Public Class D_AperturaCaja
        Public Property ResultadoDelDialogo As DialogResult
        Dim listTxtDenominaciones As New Dictionary(Of Integer, Guna2NumericUpDown)
        Friend saldoSiguiente As New Cls_SaldoCaja()

        Private Sub BTN_RegresarAperturaCaja_Click(sender As Object, e As EventArgs) Handles BTN_RegresarAperturaCaja.Click
            Me.ResultadoDelDialogo = DialogResult.Cancel
            Me.Close()
        End Sub

        Private Sub D_AperturaCaja_Load(sender As Object, e As EventArgs) Handles MyBase.Load
            InicializarCantDenominacion()
            inicializarListaTxtDenominaciones()
        End Sub

        Private Sub BTN_AbrirSesionCaja_Click(sender As Object, e As EventArgs) Handles BTN_AbrirSesionCaja.Click
            ' Si la validación es exitosa, establece el resultado y cierra el formulario.
            Me.ResultadoDelDialogo = DialogResult.OK
            Me.Close()
        End Sub


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

        Private Sub InicializarCantDenominacion()
            NUD_Moneda5.Value = saldoSiguiente.Moneda5
            NUD_Moneda10.Value = saldoSiguiente.Moneda10
            NUD_Moneda25.Value = saldoSiguiente.Moneda25
            NUD_Moneda50.Value = saldoSiguiente.Moneda50
            NUD_Moneda100.Value = saldoSiguiente.Moneda100
            NUD_Moneda500.Value = saldoSiguiente.Moneda500

            NUD_Billete1.Value = saldoSiguiente.Billete1
            NUD_Billete2.Value = saldoSiguiente.Billete2
            NUD_Billete5.Value = saldoSiguiente.Billete5
            NUD_Billete10.Value = saldoSiguiente.Billete10
            NUD_Billete20.Value = saldoSiguiente.Billete20
            NUD_Billete50.Value = saldoSiguiente.Billete50

            TXT_SaldoSiguiente.Text = saldoSiguiente.Total
        End Sub

        Private Sub CalcularMonto()
            saldoSiguiente.Total = 0
            For Each denominacion In listTxtDenominaciones
                ' Obtiene el valor del control NumericUpDown (Decimal)
                Dim valorContado As Decimal = denominacion.Value.Value

                ' La clave del diccionario es un entero, lo usamos directamente para el case
                Dim valorDenominacion As Integer = denominacion.Key

                ' Se asigna la cantidad de monedas o billetes a la propiedad específica
                AsignarCantidadDenomincacion(valorContado, valorDenominacion)

                ' Se suma el valor total de esa denominación
                saldoSiguiente.Total += valorDenominacion * valorContado
            Next

            TXT_SaldoSiguiente.Text = saldoSiguiente.Total.ToString("C", New CultureInfo("es-CR"))
        End Sub

        Private Sub AsignarCantidadDenomincacion(valorContado As Decimal, valorDenominacion As Integer)
            Select Case valorDenominacion
                Case 5
                    saldoSiguiente.Moneda5 = valorContado
                Case 10
                    saldoSiguiente.Moneda10 = valorContado
                Case 25
                    saldoSiguiente.Moneda25 = valorContado
                Case 50
                    saldoSiguiente.Moneda50 = valorContado
                Case 100
                    saldoSiguiente.Moneda100 = valorContado
                Case 500
                    saldoSiguiente.Moneda500 = valorContado
                Case 1000
                    saldoSiguiente.Billete1 = valorContado
                Case 2000
                    saldoSiguiente.Billete2 = valorContado
                Case 5000
                    saldoSiguiente.Billete5 = valorContado
                Case 10000
                    saldoSiguiente.Billete10 = valorContado
                Case 20000
                    saldoSiguiente.Billete20 = valorContado
                Case 50000
                    saldoSiguiente.Billete50 = valorContado
            End Select
        End Sub

        'Al cambiar el valor del NUD se actualiza el total
        Private Sub NUD_ValueChanged(sender As Object, e As EventArgs)
            CalcularMonto()
        End Sub
    End Class
End Namespace