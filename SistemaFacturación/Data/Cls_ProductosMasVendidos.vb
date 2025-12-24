Namespace SistemaFacturacion.Data
    Public Class Cls_ProductosMasVendidos
        Public Property Ranking As Integer
        Public Property Cantidad As Integer
        Public Property Nombre As String
        Public Property Total As Decimal

        Public Sub New(ranking As Integer, cantidad As Integer, nombre As String, total As Decimal)
            Me.Ranking = ranking
            Me.Cantidad = cantidad
            Me.Nombre = nombre
            Me.Total = total
        End Sub
    End Class

End Namespace
