Imports System.Globalization
Imports Syncfusion.Windows.Forms

Namespace SistemaFacturacion.Data
    Public Class Cls_SaldoCaja
        Friend Property Billete50 As Decimal = 0
        Friend Property Billete20 As Decimal = 0
        Friend Property Billete10 As Decimal = 0
        Friend Property Billete5 As Decimal = 0
        Friend Property Billete2 As Decimal = 0
        Friend Property Billete1 As Decimal = 0
        Friend Property Moneda500 As Decimal = 0
        Friend Property Moneda100 As Decimal = 0
        Friend Property Moneda50 As Decimal = 0
        Friend Property Moneda25 As Decimal = 0
        Friend Property Moneda10 As Decimal = 0
        Friend Property Moneda5 As Decimal = 0
        Friend ReadOnly Property Total As Decimal
            Get
                Dim totalCalculado As Decimal = 0

                ' Billets (Billetes)
                totalCalculado += 50000 * Billete50
                totalCalculado += 20000 * Billete20
                totalCalculado += 10000 * Billete10
                totalCalculado += 5000 * Billete5
                totalCalculado += 2000 * Billete2
                totalCalculado += 1000 * Billete1

                ' Monedas (Coins)
                totalCalculado += 500 * Moneda500
                totalCalculado += 100 * Moneda100
                totalCalculado += 50 * Moneda50
                totalCalculado += 25 * Moneda25
                totalCalculado += 10 * Moneda10
                totalCalculado += 5 * Moneda5

                Return totalCalculado
            End Get
        End Property
        Friend ReadOnly Property formated_total As String
            Get
                Return Total.ToString("C", New CultureInfo("es-CR"))
            End Get
        End Property

        Public Sub New()
            Billete50 = 0
            Billete20 = 0
            Billete10 = 0
            Billete5 = 0
            Billete2 = 0
            Billete1 = 0

            Moneda500 = 0
            Moneda100 = 0
            Moneda50 = 0
            Moneda25 = 0
            Moneda10 = 0
            Moneda5 = 0
        End Sub

        Friend Function Clonar(objViejo As Cls_SaldoCaja) As Cls_SaldoCaja
            Dim objNuevo As New Cls_SaldoCaja With {
                .Billete1 = objViejo.Billete1,
                .Billete2 = objViejo.Billete2,
                .Billete5 = objViejo.Billete5,
                .Billete10 = objViejo.Billete10,
                .Billete20 = objViejo.Billete20,
                .Billete50 = objViejo.Billete50,
                .Moneda5 = objViejo.Moneda5,
                .Moneda10 = objViejo.Moneda10,
                .Moneda25 = objViejo.Moneda25,
                .Moneda50 = objViejo.Moneda50,
                .Moneda100 = objViejo.Moneda100,
                .Moneda500 = objViejo.Moneda500
            }
            Return objNuevo
        End Function
    End Class


End Namespace
