Imports System.Drawing.Printing

Public Class P_TerminarVenta
    ' Declaración de variables a nivel de la clase
    ' Estas variables se mantienen durante todo el ciclo de vida del formulario
    Dim idFactura As Integer
    Friend total As Double ' El total de la factura
    Private vuelto As Double ' El vuelto a devolver al cliente
    Private TipoPago As Integer ' El tipo de pago seleccionado (Efectivo, Tarjeta, etc.)
    Friend NumFactura As String ' El número de la factura
    Friend idCLiente As Integer ' El ID del cliente asociado a la factura

    ' Variables para el contenido de la factura (impresión)
    Friend encabezadoFactura As String
    Friend encabezadoProds As String
    Friend facturaContenido As New List(Of String)()
    Friend finFactura As String

    ' Manejador del evento Load del formulario
    Private Sub P_TerminarVenta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Obtiene el próximo ID de factura disponible
        idFactura = OBTENERPK("factura", "ID")
        ' Valida el estado inicial del pago y habilita/deshabilita los botones de venta
        VALIDAR(TXT_ECliente, TXT_ECliente, total, False)

        ' Añade los manejadores de eventos (handlers) para los botones de "Colocar Total"
        ' Esto evita tener que crear una subrutina para cada botón y centraliza la lógica
        AddHandler BTN_EColocarTotal.Click, AddressOf ColocarTotal
        AddHandler BTN_TColocarTotal.Click, AddressOf ColocarTotal
        AddHandler BTN_SColocarTotal.Click, AddressOf ColocarTotal
        AddHandler BTN_DColocarTotal.Click, AddressOf ColocarTotal

        ' Se añade los manejadores de eventos para los botones de "Restante"
        AddHandler BTN_RestanteEfectivo.Click, AddressOf AgregarRestante
        AddHandler BTN_RestanteTarjeta.Click, AddressOf AgregarRestante

        ' Añade los manejadores de eventos para los cambios en los TextBox de pago
        ' Esto asegura que el cálculo del vuelto y la validación se actualicen automáticamente
        AddHandler TXT_ECliente.TextChanged, AddressOf RecalcularVueltoYValidar
        AddHandler TXT_TCliente.TextChanged, AddressOf RecalcularVueltoYValidar
        AddHandler TXT_SCliente.TextChanged, AddressOf RecalcularVueltoYValidar
        AddHandler TXT_DCliente.TextChanged, AddressOf RecalcularVueltoYValidar
        AddHandler TXT_PagoTarjeta.TextChanged, AddressOf RecalcularVueltoYValidar
        AddHandler TXT_PagoEfectivo.TextChanged, AddressOf RecalcularVueltoYValidar
    End Sub

    ' Manejador de evento unificado para los botones de "Colocar Total"
    ' "sender" es el botón que ha sido presionado
    Private Sub ColocarTotal(sender As Object, e As EventArgs)
        ' Convierte el objeto sender al tipo de control Guna2Button
        Dim btn As Guna.UI2.WinForms.Guna2Button = CType(sender, Guna.UI2.WinForms.Guna2Button)

        ' Usa un Select Case para identificar qué botón se hizo clic y actualizar el TextBox correcto
        Select Case btn.Name
            Case "BTN_EColocarTotal"
                TXT_ECliente.Text = total
            Case "BTN_TColocarTotal"
                TXT_TCliente.Text = total
            Case "BTN_SColocarTotal"
                TXT_SCliente.Text = total
            Case "BTN_DColocarTotal"
                TXT_DCliente.Text = total
        End Select
    End Sub

    ' Manejador de evento unificado para los cambios en los TextBox de pago
    Private Sub RecalcularVueltoYValidar(sender As Object, e As EventArgs)
        ' Convierte el objeto sender al tipo de control Guna2TextBox
        Dim txt As Guna.UI2.WinForms.Guna2TextBox = CType(sender, Guna.UI2.WinForms.Guna2TextBox)

        ' Usa un Select Case para determinar qué TextBox se modificó
        Select Case txt.Name
            Case "TXT_ECliente"
                CalcVuelto(TXT_ECliente, TXT_EVuelto)
                VALIDAR(TXT_ECliente, TXT_ECliente, total, False)
            Case "TXT_TCliente"
                CalcVuelto(TXT_TCliente, TXT_TVuelto)
                VALIDAR(TXT_TCliente, TXT_TCliente, total, False)
            Case "TXT_SCliente"
                CalcVuelto(TXT_SCliente, TXT_SVuelto)
                VALIDAR(TXT_SCliente, TXT_SCliente, total, False)
            Case "TXT_DCliente"
                CalcVuelto(TXT_DCliente, TXT_DVuelto)
                VALIDAR(TXT_DCliente, TXT_DCliente, total, False)
            Case "TXT_PagoTarjeta", "TXT_PagoEfectivo"
                ' El cálculo para el pago mixto se maneja con ambos TextBox
                CalcVuelto(TXT_DCliente, TXT_MVuelto) ' Se usa TXT_DCliente como placeholder para la primera caja, ya que su valor no es relevante aquí
                VALIDAR(TXT_PagoTarjeta, TXT_PagoEfectivo, total, True)
        End Select
    End Sub

    ' Calcula el vuelto basado en el monto entregado por el cliente
    Private Sub CalcVuelto(txtEntregaCliente As Guna.UI2.WinForms.Guna2TextBox, txtVuelto As Guna.UI2.WinForms.Guna2TextBox)
        Dim eCliente As Double
        Dim eCliente2 As Double

        ' Lógica para tipos de pago no mixtos (Efectivo, Tarjeta, Sinpe, Depósito)
        If Not TabControlTVenta.SelectedIndex = 4 Then
            If Double.TryParse(txtEntregaCliente.Text, eCliente) Then
                vuelto = eCliente - total
                If vuelto > 0 Then
                    txtVuelto.Text = vuelto.ToString()
                Else
                    txtVuelto.Text = "0"
                End If
            End If
        Else ' Lógica para el pago mixto
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

    ' Valida si el monto de pago es suficiente para habilitar los botones de venta
    Private Sub VALIDAR(txtEntregaCliente As Guna.UI2.WinForms.Guna2TextBox, txtEntregaCliente2 As Guna.UI2.WinForms.Guna2TextBox, Total As Double, mixto As Boolean)
        Try
            ' Si el TextBox principal está vacío, lo inicializa a 0 para evitar errores de conversión
            If String.IsNullOrEmpty(txtEntregaCliente.Text) Then
                txtEntregaCliente.Text = 0
            End If

            If mixto Then ' Lógica de validación para pago mixto
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
            Else ' Lógica de validación para pagos únicos
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

#Region "TerminarVenta_ImprimirFactura"
    ' Subrutina principal para guardar la factura en la base de datos
    Private Sub GuardarFactura(txtTotal As Guna.UI2.WinForms.Guna2TextBox, txtEntregaCliente As Guna.UI2.WinForms.Guna2TextBox, txtVuelto As Guna.UI2.WinForms.Guna2TextBox, imprimir As Boolean)
        If MsgBox("¿Desea terminar la venta?", vbOKCancel + vbDefaultButton1, "Confirmar") = MsgBoxResult.Cancel Then
            Return
        End If
        Try
            ' Verifica si la factura ya existe en la base de datos
            If EXISTEPK("factura", "ID", idFactura) = True Then
                msgError("La factura ya fue guardada anteriormente.")
            End If
            Dim tarjeta As Double
            Dim efectivo As Double
            ' Asigna los montos de pago según el tipo de pago
            If TipoPago = 4 Then
                efectivo = Convert.ToDouble(TXT_PagoEfectivo.Text)
                tarjeta = Convert.ToDouble(TXT_PagoTarjeta.Text)
            Else
                efectivo = Convert.ToDouble(txtEntregaCliente.Text)
                tarjeta = 0
            End If
            ' Inserta la nueva factura en la base de datos
            Dim insert As String = $"{idFactura}, {NumFactura}, '{Date.Now:yyyy-MM-dd HH:mm:ss}', 
            {idCLiente}, {P_Caja.idUsu}, {total}, {efectivo}, {tarjeta}, {vuelto}, {TipoPago}, {1}"

            GUARDAR_FACT("factura", insert)
            Dim NInv As Integer
            ' Itera sobre los productos en el DataGridView de la caja
            For i As Integer = 0 To P_Caja.DGV_Caja.Rows.Count - 2
                ' Guarda los detalles de cada producto vendido
                GUARDAR_VarCompInt4("factura_producto", idFactura, P_Caja.DGV_Caja.Rows(i).Cells(0).Value.ToString(), P_Caja.DGV_Caja.Rows(i).Cells(4).Value.ToString(), Convert.ToDouble(P_Caja.DGV_Caja.Rows(i).Cells(3).Value.ToString()))
                ' Actualiza el inventario del producto
                T1.Tables.Clear()
                SQL = "SELECT inventario FROM producto WHERE ID = " & P_Caja.DGV_Caja.Rows(i).Cells(0).Value.ToString()
                Cargar_Tabla(T1, SQL)
                If T1.Tables(0).Rows.Count > 0 Then
                    NInv = Convert.ToInt32(T1.Tables(0).Rows(0).Item(0)) - Convert.ToInt32(P_Caja.DGV_Caja.Rows(i).Cells(4).Value)
                    GUARDAR_INT("producto", "inventario", NInv, "ID", P_Caja.DGV_Caja.Rows(i).Cells(0).Value)
                End If
            Next
            ' Guarda cualquier comentario adicional de la factura
            If Not String.IsNullOrEmpty(TXT_Comentario.Text) Then
                GUARDAR_VarCompuestas("factura_comentario", idFactura, TXT_Comentario.Text)
            End If

            ' Si se seleccionó la opción de imprimir, genera e imprime la factura
            If imprimir Then
                CREAR_FACTURA(idFactura, False)
                ImprimirFactura()
            End If

            ' Limpia la interfaz de la caja y la prepara para una nueva venta
            P_Caja.LIMPIAR()
            P_Caja.CargarNumFactura()
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
    End Sub

    Private Sub TerminarVenta(imprimir As Boolean)
        Dim TipoPago As Integer = TabControlTVenta.SelectedIndex
        Select Case TipoPago
            Case 0 ' Efectivo
                GuardarFactura(TXT_ETotal, TXT_ECliente, TXT_EVuelto, imprimir)
            Case 1 ' Tarjeta
                GuardarFactura(TXT_TTotal, TXT_TCliente, TXT_TVuelto, imprimir)
            Case 2 ' Sinpe
                GuardarFactura(TXT_STotal, TXT_SCliente, TXT_SVuelto, imprimir)
            Case 3 ' Depósito
                GuardarFactura(TXT_DTotal, TXT_DCliente, TXT_DVuelto, imprimir)
            Case 4 ' Mixto
                GuardarFactura(TXT_MTotal, TXT_PagoEfectivo, TXT_MVuelto, imprimir)
        End Select
    End Sub

    Private Sub BTN_TVenta_Click(sender As Object, e As EventArgs) Handles BTN_TVenta.Click
        TerminarVenta(False)
    End Sub

    Private Sub BTN_TVentaImp_Click(sender As Object, e As EventArgs) Handles BTN_TVentaImp.Click
        TerminarVenta(True)
    End Sub

    ' Manejador del evento PrintPage para la impresión de la factura
    Private Sub PrintDocument_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument.PrintPage
        ' Configuración de fuentes y formatos para el texto
        Dim font As New Font("Arial", 12)
        Dim fontProds As New Font("Segoe UI", 9)
        Dim brush As New SolidBrush(Color.Black)
        Dim stringFormat As New StringFormat() With {
        .Alignment = StringAlignment.Near,
        .LineAlignment = StringAlignment.Near
    }

        ' Configuración del área de impresión
        Dim totalWidth As Single = 72 * 3.78
        Dim cellWidth As Single = totalWidth / 4
        Dim leftMargin As Single = e.MarginBounds.Left
        Dim topMargin As Single = e.MarginBounds.Top
        Dim yPos As Single = topMargin

        ' Dibuja el encabezado de la factura
        e.Graphics.DrawString(encabezadoFactura, font, brush, leftMargin, yPos, stringFormat)
        yPos += e.Graphics.MeasureString(encabezadoFactura, font).Height + 10 ' Espacio adicional

        ' Dibuja el encabezado de la tabla de productos
        e.Graphics.DrawString(encabezadoProds, fontProds, brush, leftMargin, yPos, stringFormat)
        yPos += e.Graphics.MeasureString(encabezadoProds, fontProds).Height + 10 ' Espacio adicional

        ' Dibuja los productos línea por línea
        For Each line As String In facturaContenido
            Dim columns() As String = line.Split(New Char() {"."c}, StringSplitOptions.RemoveEmptyEntries) ' Divide la línea en columnas

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

            yPos += maxHeight + 5 ' Incrementa la posición Y para la siguiente línea
        Next

        yPos += 10 ' Espacio adicional después de los productos
        e.Graphics.DrawString(finFactura, font, brush, leftMargin, yPos, stringFormat)
    End Sub


    ' Método para iniciar el proceso de impresión
    Private Sub ImprimirFactura()
        Dim printDoc As New PrintDocument()
        AddHandler printDoc.PrintPage, AddressOf PrintDocument_PrintPage

        ' Configura el tamaño del papel y los márgenes a 0
        Dim customPaperSize As New PaperSize("Custom", CInt(72 * 3.937), CInt(297 * 3.937))
        printDoc.DefaultPageSettings.PaperSize = customPaperSize
        printDoc.DefaultPageSettings.Margins = New Margins(0, 0, 0, 0)

        Dim printPreview As New PrintPreviewDialog With {
            .Document = printDoc
        }

        If PrintDialog.ShowDialog() = DialogResult.OK Then ' Muestra el diálogo de impresión
            printDoc.Print()
        End If
    End Sub
#End Region

    ' Manejador del clic para el botón "Regresar Venta"
    Private Sub BTN_RegresarVenta_Click(sender As Object, e As EventArgs) Handles BTN_RegresarVenta.Click
        P_Caja.Select()
        P_Caja.TXT_BuscarProducto.Select()
        P_Caja.TXT_BuscarProducto.SelectAll()
        Me.Close()
    End Sub

    ' Manejador del cambio de pestaña en el TabControl
    Private Sub TabControlTVenta_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TabControlTVenta.SelectedIndexChanged
        LIMPIAR()
    End Sub

    Friend Sub LIMPIAR()
        ' Obtener la letra identificadora de la pestaña actual (E, T, S, D, M)
        Dim tipoPago As Integer = TabControlTVenta.SelectedIndex
        Dim prefijoActivo As String
        Select Case tipoPago
            Case 0 ' Efectivo
                prefijoActivo = "E"
            Case 1 ' Tarjeta
                prefijoActivo = "T"
            Case 2 ' Sinpe
                prefijoActivo = "S"
            Case 3 ' Depósito
                prefijoActivo = "D"
            Case 4 ' Mixto
                ' Para el pago mixto, los prefijos son "PagoEfectivo", "PagoTarjeta" y "M" para el vuelto
                prefijoActivo = "Pago" ' Usaremos un prefijo que capture ambos
            Case Else
                prefijoActivo = ""
        End Select

        ' Recorrer todos los TextBox y limpiarlos, excepto los de la pestaña activa
        Dim txtsToClear As New List(Of Guna.UI2.WinForms.Guna2TextBox) From {
            TXT_ECliente, TXT_EVuelto,
            TXT_TCliente, TXT_TVuelto,
            TXT_SCliente, TXT_SVuelto,
            TXT_DCliente, TXT_DVuelto,
            TXT_PagoEfectivo, TXT_PagoTarjeta, TXT_MVuelto
        }

        For Each txt As Guna.UI2.WinForms.Guna2TextBox In txtsToClear
            ' Si la pestaña es Mixto, limpia los campos que no tienen los prefijos de Mixto
            If tipoPago = 4 Then
                If Not txt.Name.StartsWith("TXT_Pago") AndAlso Not txt.Name.StartsWith("TXT_M") Then
                    txt.Text = "0"
                End If
            Else
                ' Si el prefijo del nombre del TextBox no coincide con el prefijo de la pestaña activa
                If Not txt.Name.StartsWith("TXT_" & prefijoActivo) Then
                    txt.Text = "0"
                End If
            End If
        Next

        ' Finalmente, enfocarse en el TextBox correcto de la pestaña activa y seleccionar su texto
        Select Case tipoPago
            Case 0 ' Efectivo
                TXT_ECliente.Select()
                TXT_ECliente.SelectAll()
            Case 1 ' Tarjeta
                TXT_TCliente.Select()
                TXT_TCliente.SelectAll()
            Case 2 ' Sinpe
                TXT_SCliente.Select()
                TXT_SCliente.SelectAll()
            Case 3 ' Depósito
                TXT_DCliente.Select()
                TXT_DCliente.SelectAll()
            Case 4 ' Mixto
                TXT_PagoEfectivo.Select()
                TXT_PagoEfectivo.SelectAll()
        End Select
    End Sub

    ' Calcula el monto restante para pago mixto
    Private Function CargarRestante(efectivo As Boolean) As Double
        ' Si los campos están vacíos, los inicializa a 0
        If String.IsNullOrEmpty(TXT_PagoEfectivo.Text) Then
            TXT_PagoEfectivo.Text = 0
        End If
        If String.IsNullOrEmpty(TXT_PagoTarjeta.Text) Then
            TXT_PagoTarjeta.Text = 0
        End If

        Dim restante As Double
        Dim pEfectivo As Double = Convert.ToDouble(TXT_PagoEfectivo.Text)
        Dim pTarjeta As Double = Convert.ToDouble(TXT_PagoTarjeta.Text)

        If efectivo Then ' Si el botón de efectivo restante fue presionado
            restante = total - pTarjeta
            If restante < 0 Then
                restante = 0
            End If
            Return restante
        Else ' Si el botón de tarjeta restante fue presionado
            restante = total - pEfectivo
            If restante < 0 Then
                restante = 0
            End If
            Return restante
        End If

    End Function

    'Se agrega el restante al campo correspondiente
    Private Sub AgregarRestante(sender As Object, e As EventArgs)
        ' Convierte el objeto sender al tipo de control Guna2Button
        Dim btn As Guna.UI2.WinForms.Guna2Button = CType(sender, Guna.UI2.WinForms.Guna2Button)
        ' Usa un Select Case para identificar qué botón se hizo clic y actualizar el TextBox correcto
        Select Case btn.Name
            Case "BTN_RestanteTarjeta"
                TXT_PagoTarjeta.Text = CargarRestante(False)
            Case "BTN_RestanteEfectivo"
                TXT_PagoEfectivo.Text = CargarRestante(True)
        End Select
        ' Recalcula el vuelto y valida los montos después de agregar el restante
        CalcVuelto(TXT_DCliente, TXT_MVuelto)
        VALIDAR(TXT_PagoTarjeta, TXT_PagoEfectivo, total, True)
    End Sub

    ' Manejador de eventos de teclado para atajos de teclado
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