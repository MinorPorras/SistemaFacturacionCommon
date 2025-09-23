Namespace SistemaFacturacion.Data

    Public Class Cls_CierreCaja
        Friend Property fecha_inicio As Date
        Friend Property fecha_fin As Date
        Friend Property saldo_inicial As Integer
        Friend Property ingresoEfectivo As Decimal
        Friend Property ingresoTarjeta As Decimal
        Friend Property salidasEfectivo As Decimal = 0
        Friend Property efectivoContado As Integer = 0
        Friend Property saldoSiguiente As Integer = 0
        Friend Property comentarios As String = ""
        Friend Property Cajero As String = ""

        Public Sub New(fecha_inicio As Date, fecha_fin As Date, saldo_inicial As Integer, ingresoEfectivo As Decimal, ingresoTarjeta As Decimal)
            Me.fecha_inicio = fecha_inicio
            Me.fecha_fin = fecha_fin
            Me.saldo_inicial = saldo_inicial
            Me.ingresoEfectivo = ingresoEfectivo
            Me.ingresoTarjeta = ingresoTarjeta
        End Sub

        Public Sub New()

        End Sub
    End Class
End Namespace
