Imports System.Globalization
Imports SistemaFacturaciónCommon.SistemaFacturacion.Data

Namespace SistemaFacturacion.Forms.Caja

    Public Class E_ProductoVariable
        Public cant As Integer
        Dim culturaCR As New CultureInfo("es-CR")
        Public producto As Cls_ProductoCaja
        Private Sub E_ProductoVariable_Load(sender As Object, e As EventArgs) Handles MyBase.Load
            VALIDAR()
            TXT_PrecioVenta.Select()
        End Sub

        Private Sub BTN_RegresarPrd_Click(sender As Object, e As EventArgs) Handles BTN_RegresarPrd.Click
            Me.DialogResult = DialogResult.Cancel
        End Sub

        Private Sub BTN_SelectProd_Click(sender As Object, e As EventArgs) Handles BTN_SelectProd.Click
            Dim prod As New Cls_ProductoCaja With {
                .ID = LBL_ID.Text,
                .Codigo = LBL_Cod.Text,
                .Producto = LBL_Producto.Text,
                .Precio = Convert.ToDecimal(TXT_PrecioVenta.Text),
                .Cantidad = cant,
                .Variable = True
            }

            producto = prod

            TXT_PrecioVenta.Clear()
            Me.DialogResult = DialogResult.OK
        End Sub

        Private Sub TXT_PrecioVenta_TextChanged(sender As Object, e As EventArgs) Handles TXT_PrecioVenta.TextChanged
            VALIDAR()
        End Sub

        Private Sub VALIDAR()
            Try
                Dim pVenta As Double
                If Not String.IsNullOrEmpty(TXT_PrecioVenta.Text) And Double.TryParse(TXT_PrecioVenta.Text, pVenta) Then
                    BTN_SelectProd.Enabled = True
                Else
                    BTN_SelectProd.Enabled = False
                End If
            Catch ex As Exception
                MsgBox("El precio no es un formato numerico correcto", vbCritical + vbOKOnly, "Formato número incorrecto")
            End Try
        End Sub
    End Class

End Namespace