Public Class Cls_ProductosMasVendidos
    Public Property Cantidad As Integer
    Public Property Nombre As String
    Public Property Total As Decimal

    Public Sub New(cantidad As Integer, nombre As String, total As Decimal)
        Me.cantidad = cantidad
        Me.nombre = nombre
        Me.total = total
    End Sub
End Class
