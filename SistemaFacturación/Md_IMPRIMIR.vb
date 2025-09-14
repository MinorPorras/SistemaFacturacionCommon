' -----------------------------------------------------------------------------
' Módulo para la generación y armado de la factura impresa o reimpresa
' Obtiene los datos de la factura, cliente, sucursal y productos para mostrar
' en la vista previa de impresión o reimpresión.
' -----------------------------------------------------------------------------
Imports System.Drawing.Printing

Module Md_IMPRIMIR
    ' Variables para el contenido de la factura (impresión)
    Friend encabezadoFactura As String
    Friend encabezadoProds As String = "Cant     Descripción        Precio       Total" & vbCrLf &
                                                    "--------------------------------------------------" & vbCrLf
    Friend facturaContenido As New List(Of String)()
    Friend finFactura As String

    Private Sub LIMPIAR()
        encabezadoFactura = ""
        facturaContenido.Clear()
        finFactura = ""
    End Sub

    ' Genera el contenido de la factura para impresión o reimpresión
    ' id_factura: ID de la factura a imprimir
    ' reimprimir: True si es reimpresión, False si es impresión normal
    Public Sub GENERAR_FACTURA(id_factura As Integer)
        LIMPIAR()
        Dim factura As New Cls_DatosFactura()
        factura = ObtenerDatosGeneralesFactura(id_factura)

        Dim strVenta As String
        ' Determinar el tipo de venta en texto
        Select Case factura.TipoPago
            Case 0
                strVenta = "Efectivo"
            Case 1
                strVenta = "Tarjeta"
            Case 2
                strVenta = "Sinpe"
            Case 3
                strVenta = "Depósito"
            Case 4
                strVenta = "Mixto"
            Case Else
                strVenta = "Efectivo"
        End Select

        Dim comentario As String = ObtenerComentario(id_factura)

        ' Obtener datos de la sucursal
        Dim sucursal As New Cls_Sucursal()
        sucursal = ObtenerDatosSucursal()

        ' Formatear la dirección para impresión
        Dim direccionsplit() As String = sucursal.Direccion.Split(","c)
        sucursal.Direccion = ""
        For i As Integer = 0 To direccionsplit.Length - 1
            If i <> 1 Then
                sucursal.Direccion = sucursal.Direccion & direccionsplit(i) & ","
            Else
                sucursal.Direccion = sucursal.Direccion & vbCrLf & direccionsplit(i)
            End If
        Next

        ' Definir el contenido de la factura para impresión normal
        encabezadoFactura = crearEncabezadoFactura(factura, sucursal)

        CargarProds(id_factura)

        finFactura = crearFinFactura(factura)

        ImprimirFactura(encabezadoFactura, facturaContenido, finFactura)
    End Sub

    Private Function ObtenerDatosGeneralesFactura(id_factura As Integer) As Cls_DatosFactura
        ' Obtener datos principales de la factura, cliente y usuario
        T.Tables.Clear()
        SQL = "SELECT f.ID, f.fecha_emision, c.nombre, f.num_factura, f.total, f.efectivo_cliente, f.tarjeta_cliente, f.vuelto, f.tipo_venta, u.usuario" &
            " FROM (factura f LEFT JOIN clientes c ON c.ID =f.ID_Cliente) LEFT JOIN usuario u ON u.ID = f.ID_Usuario WHERE f.ID = " & id_factura
        Cargar_Tabla(T, SQL)
        Dim factura As New Cls_DatosFactura With {
            .Fecha = If(IsDBNull(T.Tables(0).Rows(0).Item(1)), " ", T.Tables(0).Rows(0).Item(1)),
            .Cliente = If(IsDBNull(T.Tables(0).Rows(0).Item(2)), " ", T.Tables(0).Rows(0).Item(2)),
            .NumFactura = If(IsDBNull(T.Tables(0).Rows(0).Item(3)), " ", CInt(T.Tables(0).Rows(0).Item(3)).ToString("D15")),
            .TotalCaja = If(IsDBNull(T.Tables(0).Rows(0).Item(4)), " ", T.Tables(0).Rows(0).Item(4)),
            .Efectivo = If(IsDBNull(T.Tables(0).Rows(0).Item(5)), " ", T.Tables(0).Rows(0).Item(5)),
            .Tarjeta = If(IsDBNull(T.Tables(0).Rows(0).Item(6)), " ", T.Tables(0).Rows(0).Item(6)),
            .Vuelto = If(IsDBNull(T.Tables(0).Rows(0).Item(7)), " ", T.Tables(0).Rows(0).Item(7)),
            .TipoPago = If(IsDBNull(T.Tables(0).Rows(0).Item(8)), " ", T.Tables(0).Rows(0).Item(8)),
            .Cajero = If(IsDBNull(T.Tables(0).Rows(0).Item(9)), " ", T.Tables(0).Rows(0).Item(9))
        }

        Return factura

    End Function

    Private Function ObtenerComentario(id_factura As Integer) As String
        ' Obtener comentario asociado a la factura
        T.Tables.Clear()
        SQL = "SELECT comentario FROM factura_comentario WHERE ID_Factura = " & id_factura
        Cargar_Tabla(T, SQL)

        Dim comentario As String = "" ' Inicializamos la variable del comentario

        ' Verificamos que se haya cargado al menos una tabla
        If T.Tables.Count > 0 Then
            ' Luego verificamos que esa tabla tenga al menos una fila
            If T.Tables(0).Rows.Count > 0 Then
                ' Si hay una fila, obtenemos el comentario
                comentario = If(IsDBNull(T.Tables(0).Rows(0).Item(0)), "", T.Tables(0).Rows(0).Item(0))
            End If
        End If

        Return comentario
    End Function

    Private Function ObtenerDatosSucursal() As Cls_Sucursal
        ' Obtener datos de la sucursal desde la base de datos
        T.Tables.Clear()
        SQL = "SELECT nombre, direccion, telefono, email, ced_juridica  FROM sucursal WHERE ID = 1"
        Cargar_Tabla(T, SQL)
        Dim sucursal As New Cls_Sucursal With {
            .Nombre = If(IsDBNull(T.Tables(0).Rows(0).Item(0)), " ", T.Tables(0).Rows(0).Item(0)),
            .Direccion = If(IsDBNull(T.Tables(0).Rows(0).Item(1)), " ", T.Tables(0).Rows(0).Item(1)),
            .Telefono = If(IsDBNull(T.Tables(0).Rows(0).Item(2)), " ", T.Tables(0).Rows(0).Item(2)),
            .Email = If(IsDBNull(T.Tables(0).Rows(0).Item(3)), " ", T.Tables(0).Rows(0).Item(3)),
            .Cedula = If(IsDBNull(T.Tables(0).Rows(0).Item(4)), " ", T.Tables(0).Rows(0).Item(4))
        }
        Return sucursal
    End Function

    Private Function crearEncabezadoFactura(factura As Cls_DatosFactura, sucursal As Cls_Sucursal) As String
        Return "-------------------------------------------" & vbCrLf &
                                "        FACTURA DE VENTA" & vbCrLf & vbCrLf &
                                "------------ " & sucursal.Direccion & " -------------" & vbCrLf & vbCrLf &
                                "Nº de Factura: " & factura.NumFactura & vbCrLf &
                                "Cajero: " & factura.Cajero & vbCrLf &
                                "Ced. Jurídica:" & sucursal.Cedula & vbCrLf &
                                "Dirección:" & sucursal.Direccion & vbCrLf &
                                "Teléfono: " & sucursal.Telefono & vbCrLf &
                                "Email: " & sucursal.Email & vbCrLf &
                                "Fecha: " & factura.Fecha & vbCrLf &
                                vbCrLf &
                                "Cliente:" & factura.Cliente & vbCrLf &
                                vbCrLf &
                                "-------------------------------------------" & vbCrLf &
                                "Descripción de Productos" & vbCrLf &
                                "-------------------------------------------" & vbCrLf
    End Function

    Private Function crearFinFactura(factura As Cls_DatosFactura) As String
        Dim finFcatura As String = "-------------------------------------------" & vbCrLf &
                      "Total de la venta: ₡ " & factura.TotalCaja & vbCrLf &
                      vbCrLf
        If factura.TipoPago = 1 Then
            finFcatura += "Pago del cliente: ₡ " & factura.Efectivo

        ElseIf factura.TipoPago = 4 Then
            finFcatura += "Pago en efectivo: ₡ " & factura.Efectivo & vbCrLf &
                vbCrLf &
                 "Pago en tarjeta: ₡ " & factura.Tarjeta
        Else
            finFcatura += "Pago en tarjeta: ₡ " & factura.Tarjeta
        End If

        Return finFcatura
    End Function

    Public Sub ImprimirFactura(encabezado As String, productos As List(Of String), fin As String)
        Dim printDoc As New PrintDocument()

        ' Usamos AddHandler para pasar los parámetros de la factura al controlador de eventos
        AddHandler printDoc.PrintPage, Sub(sender, e)
                                           printDocument_PrintPage(sender, e, encabezado, productos, fin)
                                       End Sub
        ' Configurar tamaño de papel personalizado (72 puntos por pulgada, 3.937 pulgadas de ancho, 297 mm de alto)
        Dim customPaperSize As New PaperSize("Custom", CInt(72 * 3.937), CInt(297 * 3.937))
        printDoc.DefaultPageSettings.PaperSize = customPaperSize
        printDoc.DefaultPageSettings.Margins = New Margins(0, 0, 0, 0)

        Dim printPreview As New PrintPreviewDialog With {
            .Document = printDoc
        }

        ' printPreview.ShowDialog() ' Para vista previa
        printDoc.Print()
    End Sub

    ' Manejador del evento PrintPage que ahora recibe los parámetros de la factura
    Private Sub printDocument_PrintPage(sender As Object, e As Printing.PrintPageEventArgs, encabezado As String, productos As List(Of String), fin As String)
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

        ' Dibuja el encabezado de la factura
        e.Graphics.DrawString(encabezado, font, brush, leftMargin, yPos, stringFormat)
        yPos += e.Graphics.MeasureString(encabezado, font).Height + 10

        ' Dibuja el encabezado de la tabla de productos
        e.Graphics.DrawString(encabezadoProds, fontProds, brush, leftMargin, yPos, stringFormat) ' Nota: usa la variable global
        yPos += e.Graphics.MeasureString(encabezadoProds, fontProds).Height + 10

        ' Dibuja los productos línea por línea
        For Each line As String In productos ' Recorre la lista de productos
            Dim columns() As String = line.Split(New Char() {"."c}, StringSplitOptions.RemoveEmptyEntries)

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
            yPos += maxHeight + 5
        Next

        yPos += 10
        e.Graphics.DrawString(fin, font, brush, leftMargin, yPos, stringFormat)
    End Sub

    ' Carga los productos de la factura y los agrega al contenido de impresión
    ' idfact: ID de la factura
    ' reimprimir: True si es reimpresión, False si es impresión normal
    Private Sub CargarProds(idfact As Integer)
        T.Tables.Clear()
        SQL = "SELECT f.cant, p.nombre, f.precio_venta FROM ((factura_producto f LEFT JOIN producto p ON p.ID = f.ID_Producto)" &
            " LEFT JOIN Producto_precioVenta v ON p.ID = v.ID_Producto) WHERE ID_Factura = " & idfact
        Cargar_Tabla(T, SQL)
        Dim prods As String
        If T.Tables(0).Rows.Count > 0 Then
            For i As Integer = 0 To T.Tables(0).Rows.Count - 1
                prods = T.Tables(0).Rows(i).Item(0) & "." &
                                  T.Tables(0).Rows(i).Item(1) & "." &
                                  T.Tables(0).Rows(i).Item(2) & "." &
                                  Convert.ToDouble(T.Tables(0).Rows(i).Item(0)) * Convert.ToDouble(T.Tables(0).Rows(i).Item(2)) & vbCrLf
                facturaContenido.Add(prods)
            Next
        End If
    End Sub
End Module
