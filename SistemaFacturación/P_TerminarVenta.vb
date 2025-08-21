Imports System.Drawing.Printing

Public Class P_TerminarVenta
    Dim idFactura As Integer
    Friend total As Double
    Private vuelto As Double
    Private TipoPago As Integer
    Friend NumFactura As String
    Friend idCLiente As Integer

    Friend encabezadoFactura As String
    Friend encabezadoProds As String
    Friend facturaContenido As New List(Of String)()
    Friend finFactura As String
    Private Sub P_TerminarVenta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        idFactura = OBTENERPK("factura", "ID")
        VALIDAR(TXT_ECliente, TXT_ECliente, total, False)
    End Sub

    Private Sub TXT_ECliente_TextChanged(sender As Object, e As EventArgs) Handles TXT_ECliente.TextChanged
        calcVuelto(TXT_ECliente, TXT_EVuelto)
        VALIDAR(TXT_ECliente, TXT_ECliente, total, False)
    End Sub

    Private Sub TXT_TCliente_TextChanged(sender As Object, e As EventArgs) Handles TXT_TCliente.TextChanged
        calcVuelto(TXT_TCliente, TXT_TVuelto)
        VALIDAR(TXT_TCliente, TXT_TCliente, total, False)
    End Sub
    Private Sub TXT_SCliente_TextChanged(sender As Object, e As EventArgs) Handles TXT_SCliente.TextChanged
        calcVuelto(TXT_SCliente, TXT_SVuelto)
        VALIDAR(TXT_SCliente, TXT_SCliente, total, False)

    End Sub

    Private Sub TXT_DCliente_TextChanged(sender As Object, e As EventArgs) Handles TXT_DCliente.TextChanged
        calcVuelto(TXT_DCliente, TXT_DVuelto)
        VALIDAR(TXT_DCliente, TXT_DCliente, total, False)

    End Sub

    Private Sub TXT_PagoTarjeta_TextChanged(sender As Object, e As EventArgs) Handles TXT_PagoTarjeta.TextChanged
        'Se pone cualquier textbox debido a que el calculo en este caso se hace solo
        calcVuelto(TXT_DCliente, TXT_MVuelto)
        VALIDAR(TXT_PagoTarjeta, TXT_PagoEfectivo, total, True)

    End Sub

    Private Sub TXT_PagoEfectivo_TextChanged(sender As Object, e As EventArgs) Handles TXT_PagoEfectivo.TextChanged
        'Se pone cualquier textbox debido a que el calculo en este caso se hace solo
        calcVuelto(TXT_DCliente, TXT_MVuelto)
        VALIDAR(TXT_PagoTarjeta, TXT_PagoEfectivo, total, True)

    End Sub

    Private Sub CalcVuelto(txtEntregaCliente As Guna.UI2.WinForms.Guna2TextBox, txtVuelto As Guna.UI2.WinForms.Guna2TextBox)
        Dim eCliente As Double
        Dim eCliente2 As Double
        If Not TabControlTVenta.SelectedIndex = 4 Then
            If Double.TryParse(txtEntregaCliente.Text, eCliente) Then
                vuelto = eCliente - total
                If vuelto > 0 Then
                    txtVuelto.Text = vuelto.ToString()
                Else
                    txtVuelto.Text = "0"
                End If
            End If
        Else
            If Double.TryParse(TXT_PagoTarjeta.Text, eCliente) AndAlso Double.TryParse(TXT_PagoEfectivo.Text, eCliente2) Then
                Dim EntregaCliente As Double = eCliente + eCliente2
                vuelto = EntregaCliente - total
                If vuelto > 0 Then
                    txtVuelto.Text = vuelto.ToString()
                Else
                    txtVuelto.Text = "0"
                End If
            End If
        End If
    End Sub

    Private Sub VALIDAR(txtEntregaCliente As Guna.UI2.WinForms.Guna2TextBox, txtEntregaCliente2 As Guna.UI2.WinForms.Guna2TextBox, Total As Double, mixto As Boolean)
        Try
            If String.IsNullOrEmpty(txtEntregaCliente.Text) Then
                txtEntregaCliente.Text = 0
            End If
            If mixto Then 'Si es mixto el pago

                If String.IsNullOrEmpty(txtEntregaCliente2.Text) Then
                    txtEntregaCliente2.Text = 0
                End If

                If Convert.ToDouble(txtEntregaCliente.Text) + Convert.ToDouble(txtEntregaCliente2.Text) >= Total Then
                    BTN_TVenta.Enabled = True
                    BTN_TVentaImp.Enabled = True
                Else
                    BTN_TVenta.Enabled = False
                    BTN_TVentaImp.Enabled = False
                End If
            Else

                If Convert.ToDouble(txtEntregaCliente.Text) >= Total Then
                    BTN_TVenta.Enabled = True
                    BTN_TVentaImp.Enabled = True
                Else
                    BTN_TVenta.Enabled = False
                    BTN_TVentaImp.Enabled = False
                End If
            End If
        Catch ex As Exception
            MsgBox("Error: " & ex.Message, vbCritical + vbOKOnly, "Error")
        End Try
    End Sub

    Private Sub BTN_TVenta_Click(sender As Object, e As EventArgs) Handles BTN_TVenta.Click
        TipoPago = TabControlTVenta.SelectedIndex
        Select Case TipoPago
            Case 0 'Efectivo
                guardarFactura(TXT_ETotal, TXT_ECliente, TXT_EVuelto, False)
            Case 1 'Tarjeta
                guardarFactura(TXT_TTotal, TXT_TCliente, TXT_TVuelto, False)
            Case 2 'Sinpe
                guardarFactura(TXT_STotal, TXT_SCliente, TXT_SVuelto, False)
            Case 3 'Depósito
                guardarFactura(TXT_DTotal, TXT_DCliente, TXT_DVuelto, False)
            Case 4 'Mixto
                guardarFactura(TXT_MTotal, TXT_ECliente, TXT_MVuelto, False)
        End Select
    End Sub
    Private Sub BTN_TVentaImp_Click_1(sender As Object, e As EventArgs) Handles BTN_TVentaImp.Click
        TipoPago = TabControlTVenta.SelectedIndex
        Select Case TipoPago
            Case 0 'Efectivo
                guardarFactura(TXT_ETotal, TXT_ECliente, TXT_EVuelto, True)
            Case 1 'Tarjeta
                guardarFactura(TXT_TTotal, TXT_TCliente, TXT_TVuelto, True)
            Case 2 'Sinpe
                guardarFactura(TXT_STotal, TXT_SCliente, TXT_SVuelto, True)
            Case 3 'Depósito
                guardarFactura(TXT_DTotal, TXT_DCliente, TXT_DVuelto, True)
            Case 4 'Mixto
                GuardarFactura(TXT_MTotal, TXT_ECliente, TXT_MVuelto, True)
        End Select
    End Sub

    Private Sub GuardarFactura(txtTotal As Guna.UI2.WinForms.Guna2TextBox, txtEntregaCliente As Guna.UI2.WinForms.Guna2TextBox, txtVuelto As Guna.UI2.WinForms.Guna2TextBox, imprimir As Boolean)
        If MsgBox("¿Desea terminar la venta?", vbOKCancel + vbDefaultButton1, "Confirmar") = MsgBoxResult.Ok Then
            Try
                Dim tarjeta As Double
                Dim efectivo As Double
                ' Si la PK que esté guardada en IdCat no existe en la base de datos en esa tabla...
                If EXISTEPK("factura", "ID", idFactura) = False Then ' Si no se ha guardado la categoría
                    If TipoPago = 4 Then
                        efectivo = Convert.ToDouble(TXT_PagoEfectivo.Text)
                        tarjeta = Convert.ToDouble(TXT_PagoTarjeta.Text)
                    Else
                        efectivo = Convert.ToDouble(txtEntregaCliente.Text)
                        tarjeta = 0
                    End If
                    Dim insert As String = $"{idFactura}, {NumFactura}, '{Date.Now:yyyy-MM-dd HH:mm:ss}', {idCLiente}, {P_Caja.idUsu}, {total}, {efectivo}, {tarjeta}, {vuelto}, {TipoPago}, {1}"
                    GUARDAR_FACT("factura", insert)
                End If
                Dim NInv As Integer
                For i As Integer = 0 To P_Caja.DGV_Caja.Rows.Count - 2
                    GUARDAR_VarCompInt4("factura_producto", idFactura, P_Caja.DGV_Caja.Rows(i).Cells(0).Value.ToString(), P_Caja.DGV_Caja.Rows(i).Cells(4).Value.ToString(), Convert.ToDouble(P_Caja.DGV_Caja.Rows(i).Cells(3).Value.ToString()))
                    T1.Tables.Clear()
                    SQL = "SELECT inventario FROM producto WHERE ID = " & P_Caja.DGV_Caja.Rows(i).Cells(0).Value.ToString()
                    Cargar_Tabla(T1, SQL)
                    If T1.Tables(0).Rows.Count > 0 Then
                        NInv = Convert.ToInt32(T1.Tables(0).Rows(0).Item(0)) - Convert.ToInt32(P_Caja.DGV_Caja.Rows(i).Cells(4).Value)
                        GUARDAR_INT("producto", "inventario", NInv, "ID", P_Caja.DGV_Caja.Rows(i).Cells(0).Value)
                    End If
                Next
                If Not String.IsNullOrEmpty(TXT_Comentario.Text) Then
                    GUARDAR_VarCompuestas("factura_comentario", idFactura, TXT_Comentario.Text)
                End If

                If imprimir Then
                    CREAR_FACTURA(idFactura, False)
                    ImprimirFactura()
                End If

                P_Caja.LIMPIAR()
                P_Caja.cargarNumFactura()
                P_Caja.Show()
                P_Caja.Refresh()
                P_Caja.Select()
                mensaje("Vuelto: ₡ " & vuelto, vbOKOnly, "Venta completada")
                P_Caja.TXT_BuscarProducto.Select()
                P_Caja.TXT_BuscarProducto.SelectAll()
                Me.Close()
            Catch ex As Exception
                msgError("Error: " & ex.Message)
            End Try
        End If

    End Sub

    ' Manejar el evento PrintPage
    Private Sub PrintDocument_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument.PrintPage
        Dim font As New Font("Arial", 12)
        Dim fontProds As New Font("Segoe UI", 9)
        Dim brush As New SolidBrush(Color.Black)
        Dim stringFormat As New StringFormat() With {
        .Alignment = StringAlignment.Near,
        .LineAlignment = StringAlignment.Near
    }

        Dim totalWidth As Single = 72 * 3.78
        Dim cellWidth As Single = totalWidth / 4
        Dim leftMargin As Single = e.MarginBounds.Left
        Dim topMargin As Single = e.MarginBounds.Top
        Dim yPos As Single = topMargin

        ' Dibujar el encabezado
        e.Graphics.DrawString(encabezadoFactura, font, brush, leftMargin, yPos, stringFormat)
        yPos += e.Graphics.MeasureString(encabezadoFactura, font).Height + 10 ' Espacio adicional después del encabezado

        ' Dibujar el encabezado de la tabla de productos
        e.Graphics.DrawString(encabezadoProds, fontProds, brush, leftMargin, yPos, stringFormat)
        yPos += e.Graphics.MeasureString(encabezadoProds, fontProds).Height + 10 ' Espacio adicional después del encabezado

        ' Dibujar los productos
        For Each line As String In facturaContenido
            Dim columns() As String = line.Split(New Char() {"."c}, StringSplitOptions.RemoveEmptyEntries) ' Cambiar el delimitador si es necesario

            Dim maxHeight As Single = 0

            For colIndex As Integer = 0 To columns.Length - 1
                Dim rect As New RectangleF(leftMargin + (colIndex * cellWidth), yPos, cellWidth, 0)
                Dim size As SizeF = e.Graphics.MeasureString(columns(colIndex), fontProds, rect.Size, stringFormat)

                If size.Height > maxHeight Then
                    maxHeight = size.Height
                End If

                rect.Height = maxHeight
                e.Graphics.DrawString(columns(colIndex), fontProds, brush, rect, stringFormat)
            Next

            yPos += maxHeight + 5 ' Asegurar que el yPos se incremente para cada línea de productos
        Next

        yPos += 10 ' Espacio adicional después de los productos
        e.Graphics.DrawString(finFactura, font, brush, leftMargin, yPos, stringFormat)
    End Sub


    ' Método para iniciar la impresión
    Private Sub ImprimirFactura()
        Dim printDoc As New PrintDocument()
        AddHandler printDoc.PrintPage, AddressOf printDocument_PrintPage
        ' Configurar el tamaño de papel personalizado en pulgadas
        Dim customPaperSize As New PaperSize("Custom", CInt(72 * 3.937), CInt(297 * 3.937))
        printDoc.DefaultPageSettings.PaperSize = customPaperSize

        ' Configurar márgenes a cero
        printDoc.DefaultPageSettings.Margins = New Margins(0, 0, 0, 0)

        Dim printPreview As New PrintPreviewDialog With {
            .Document = printDoc
        }
        If PrintDialog.ShowDialog() = DialogResult.OK Then ' Si el usuario selecciona OK, procedemos a imprimir 
            printDoc.Print()
        End If
    End Sub


    Private Sub BTN_RegresarVenta_Click(sender As Object, e As EventArgs) Handles BTN_RegresarVenta.Click
        P_Caja.Select()
        P_Caja.TXT_BuscarProducto.Select()
        P_Caja.TXT_BuscarProducto.SelectAll()
        Me.Close()
    End Sub

    Private Sub TabControlTVenta_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TabControlTVenta.SelectedIndexChanged
        LIMPIAR()
    End Sub

    Friend Sub LIMPIAR()
        TipoPago = TabControlTVenta.SelectedIndex
        Select Case TipoPago
            Case 0 'Efectivo
                'Tarjeta
                TXT_TCliente.Text = "0"
                TXT_TVuelto.Text = "0"
                'Sinpe
                TXT_SCliente.Text = "0"
                TXT_SVuelto.Text = "0"
                'Depósito
                TXT_DCliente.Text = "0"
                TXT_DVuelto.Text = "0"
                'Mixto
                TXT_PagoEfectivo.Text = "0"
                TXT_PagoTarjeta.Text = "0"
                TXT_MVuelto.Text = "0"
                TXT_ECliente.Select()
                TXT_ECliente.SelectAll()
            Case 1 'Tarjeta
                'Efectivo
                TXT_EVuelto.Text = "0"
                TXT_ECliente.Text = "0"
                'Sinpe
                TXT_SCliente.Text = "0"
                TXT_SVuelto.Text = "0"
                'Depósito
                TXT_DCliente.Text = "0"
                TXT_DVuelto.Text = "0"
                'Mixto
                TXT_PagoEfectivo.Text = "0"
                TXT_PagoTarjeta.Text = "0"
                TXT_MVuelto.Text = "0"
                TXT_TCliente.Select()
                TXT_TCliente.SelectAll()
            Case 2 'Sinpe
                'Efectivo
                TXT_EVuelto.Text = "0"
                TXT_ECliente.Text = "0"
                'Tarjeta
                TXT_TCliente.Text = "0"
                TXT_TVuelto.Text = "0"
                'Depósito
                TXT_DCliente.Text = "0"
                TXT_DVuelto.Text = "0"
                'Mixto
                TXT_PagoEfectivo.Text = "0"
                TXT_PagoTarjeta.Text = "0"
                TXT_MVuelto.Text = "0"
                TXT_SCliente.Select()
                TXT_SCliente.SelectAll()
            Case 3 'Depósito
                'Efectivo
                TXT_EVuelto.Text = "0"
                TXT_ECliente.Text = "0"
                'Tarjeta
                TXT_TCliente.Text = "0"
                TXT_TVuelto.Text = "0"
                'Sinpe
                TXT_SCliente.Text = "0"
                TXT_SVuelto.Text = "0"
                'Mixto
                TXT_PagoEfectivo.Text = "0"
                TXT_PagoTarjeta.Text = "0"
                TXT_MVuelto.Text = "0"
                TXT_DCliente.Select()
                TXT_DCliente.SelectAll()
            Case 4 'Mixto
                'Efectivo
                TXT_EVuelto.Text = "0"
                TXT_ECliente.Text = "0"
                'Tarjeta
                TXT_TCliente.Text = "0"
                TXT_TVuelto.Text = "0"
                'Sinpe
                TXT_SCliente.Text = "0"
                TXT_SVuelto.Text = "0"
                'Depósito
                TXT_DCliente.Text = "0"
                TXT_DVuelto.Text = "0"
                TXT_PagoEfectivo.Select()
                TXT_PagoEfectivo.SelectAll()
        End Select
    End Sub

    Private Sub BTN_EColocarTotal_Click(sender As Object, e As EventArgs) Handles BTN_EColocarTotal.Click
        colocarTotal(TXT_ECliente)
    End Sub

    Private Sub BTN_TColocarTotal_Click(sender As Object, e As EventArgs) Handles BTN_TColocarTotal.Click
        colocarTotal(TXT_TCliente)
    End Sub

    Private Sub BTN_SColocarTotal_Click(sender As Object, e As EventArgs) Handles BTN_SColocarTotal.Click
        colocarTotal(TXT_SCliente)
    End Sub
    Private Sub BTN_DColocarTotal_Click(sender As Object, e As EventArgs) Handles BTN_DColocarTotal.Click
        colocarTotal(TXT_DCliente)
    End Sub

    Private Sub ColocarTotal(txtEntregaCliente As Guna.UI2.WinForms.Guna2TextBox)
        txtEntregaCliente.Text = total
    End Sub

    Private Function CargarRestante(efectivo As Boolean)
        If String.IsNullOrEmpty(TXT_PagoEfectivo.Text) Then
            TXT_PagoEfectivo.Text = 0
        End If
        If String.IsNullOrEmpty(TXT_PagoTarjeta.Text) Then
            TXT_PagoTarjeta.Text = 0
        End If
        Dim restante As Double
        Dim pEfectivo As Double = Convert.ToDouble(TXT_PagoEfectivo.Text)
        Dim pTarjeta As Double = Convert.ToDouble(TXT_PagoTarjeta.Text)
        If efectivo Then
            restante = total - pTarjeta
            If restante < 0 Then
                restante = 0
            End If
            Return restante
        Else
            restante = total - pEfectivo
            If restante < 0 Then
                restante = 0
            End If
            Return restante
        End If

    End Function

    Private Sub BTN_RestanteTarjeta_Click(sender As Object, e As EventArgs) Handles BTN_RestanteTarjeta.Click
        TXT_PagoEfectivo.Text = cargarRestante(True)
        calcVuelto(TXT_DCliente, TXT_MVuelto)
    End Sub

    Private Sub BTN_RestanteEfectivo_Click(sender As Object, e As EventArgs) Handles BTN_RestanteEfectivo.Click
        TXT_PagoTarjeta.Text = cargarRestante(False)
        calcVuelto(TXT_DCliente, TXT_MVuelto)
    End Sub

    Private Sub P_TerminarVenta_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        Select Case e.KeyCode
            Case Keys.F3
                BTN_RegresarVenta.PerformClick()
            Case Keys.F7
                BTN_TVenta.PerformClick()
            Case Keys.F4
                BTN_TVentaImp.PerformClick()
        End Select
    End Sub
End Class