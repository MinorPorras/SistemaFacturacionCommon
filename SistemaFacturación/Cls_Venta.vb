Public Class Cls_Venta
    Public Property ID As Integer
    Public Property Num_factura As String
    Public Property Fecha As Date
    Public Property Cliente As String
    Public Property Efectivo As Decimal
    Public Property Tarjeta As Decimal
    Public Property Total As Decimal
    Public Property Tipo_venta As String

    Sub New(id As Integer, num_factura As String, fecha As Date, cliente As String, total As Decimal, tipo_venta As String, efectivo As Decimal, tarjeta As Decimal)
        Me.ID = id
        Me.Num_factura = num_factura
        Me.Fecha = fecha
        Me.Cliente = cliente
        Me.Efectivo = efectivo
        Me.Tarjeta = tarjeta
        Me.Total = total
        Me.Tipo_venta = tipo_venta
    End Sub
End Class
