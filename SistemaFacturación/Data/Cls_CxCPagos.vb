Namespace SistemaFacturacion.Data

    Public Class Cls_CxCPagos
        Public Property ID As Integer
        Public Property fecha As DateTime
        Public Property tipo_venta As Integer
        Public Property tipo_venta_value As String
        Public Property monto_efectivo As Decimal
        Public Property monto_tarjeta As Decimal
        Public Property total As Decimal
        Public Property formated_monto_efectivo As Decimal
        Public Property formated_monto_tarjeta As Decimal
        Public Property formated_total As Decimal
        Public Property Comentario As String
    End Class
End Namespace
