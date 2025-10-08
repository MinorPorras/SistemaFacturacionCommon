Imports System.Globalization

Namespace SistemaFacturacion.Data

    Public Class Cls_CxCPagos
        Public Property ID As Integer
        Public Property ID_Usuario As Integer
        Public Property ID_Cliente As Integer
        Public Property Fecha As DateTime
        Public Property Tipo_venta As Integer
        Public ReadOnly Property Tipo_venta_value As String
            Get
                Select Case Tipo_venta
                    Case 0
                        Return "Efectivo"
                    Case 1
                        Return "Tarjeta"
                    Case 2
                        Return "Sinpe"
                    Case 3
                        Return "Depósito"
                    Case Else
                        Return "Mixto"
                End Select
            End Get
        End Property
        Public Property Monto_efectivo As Decimal
        Public Property Monto_tarjeta As Decimal
        Public Property Total As Decimal
        Public ReadOnly Property Formated_monto_efectivo As String
            Get
                Return Monto_efectivo.ToString("C", culturaCR)
            End Get
        End Property
        Public ReadOnly Property Formated_monto_tarjeta As String
            Get
                Return Monto_tarjeta.ToString("C", culturaCR)
            End Get
        End Property
        Public ReadOnly Property Formated_total As String
            Get
                Return Total.ToString("C", culturaCR)
            End Get
        End Property
        Public Property Comentario As String

        Private ReadOnly culturaCR As New CultureInfo("es-CR")



    End Class
End Namespace
