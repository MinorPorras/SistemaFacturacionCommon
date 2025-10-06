Namespace SistemaFacturacion.Data
    Public Class Cls_ProductoCaja
        'Propiedades de la clase de productos que se van a agregar a la factura
        Public Property ID As Integer
        Public Property Codigo As String
        Public Property Producto As String
        Public Property Precio As Decimal
        Public Property formated_precio As String
        Public Property Cantidad As Integer
        Public Property total As Decimal
        Public Property formated_total As String
    End Class

End Namespace