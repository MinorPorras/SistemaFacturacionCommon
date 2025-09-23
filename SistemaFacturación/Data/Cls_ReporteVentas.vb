
Namespace SistemaFacturacion.Data
    Public Class Cls_ReporteVentas
        Public ListaVentas As New List(Of Cls_DatosFactura)
        Public total_ventas As Decimal
        Public num_ventas As Integer
        Public ventas_efectivo As Decimal
        Public ventas_tarjeta As Decimal
        Public ProductoMasVendido As Cls_ProductosMasVendidos

        Public Sub New(listaVentas As List(Of Cls_DatosFactura), total_ventas As Decimal, num_ventas As Integer, ventas_efectivo As Decimal, ventas_tarjeta As Decimal, productoMasVendido As Cls_ProductosMasVendidos)
            Me.ListaVentas = listaVentas
            Me.total_ventas = total_ventas
            Me.num_ventas = num_ventas
            Me.ventas_efectivo = ventas_efectivo
            Me.ventas_tarjeta = ventas_tarjeta
            Me.ProductoMasVendido = productoMasVendido
        End Sub

        Public Sub New()

        End Sub
    End Class

End Namespace
