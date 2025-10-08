Imports System.Globalization

Public Class Cls_DetalleProductoCxC
    Public Property ID As Integer
    Public Property Codigo As String
    Public Property Nombre As String
    Public Property Cantidad As String
    Public Property Precio As Decimal
    Public ReadOnly Property Total As Decimal
        Get
            Return Precio * Cantidad
        End Get
    End Property
    Public ReadOnly Property Formated_Precio As String
        Get
            Return Precio.ToString("C", culturaCR)
        End Get
    End Property
    Public ReadOnly Property Formated_total As String
        Get
            Return Total.ToString("C", culturaCR)
        End Get
    End Property

    Private ReadOnly culturaCR As New CultureInfo("es-CR")
End Class
