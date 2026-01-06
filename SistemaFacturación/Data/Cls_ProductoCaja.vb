Imports System.Globalization

Namespace SistemaFacturacion.Data
    Public Class Cls_ProductoCaja
        'Propiedades de la clase de productos que se van a agregar a la factura
        Public Property ID As Integer
        Public Property Codigo As String
        Public Property Producto As String
        Public Property Precio As Decimal
        Public Property Variable As Boolean
        Public ReadOnly Property Formated_precio As String
            Get
                Return Precio.ToString("C", CulturaCR)
            End Get
        End Property
        Public Property Cantidad As Integer
        Public ReadOnly Property Total As Decimal
            Get
                Return Precio * Cantidad
            End Get
        End Property
        Public ReadOnly Property Formated_total As String
            Get
                Return Total.ToString("C", CulturaCR)
            End Get
        End Property
        Private ReadOnly CulturaCR As New CultureInfo("es-CR")
    End Class

End Namespace