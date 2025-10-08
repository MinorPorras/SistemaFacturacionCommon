Imports System.Data.SQLite
Imports System.Globalization
Imports SistemaFacturaciónCommon.SistemaFacturacion.Data
Imports SistemaFacturaciónCommon.SistemaFacturacion.Modules
Imports Syncfusion.CompoundFile.XlsIO.Native

Public Class Cls_Ventas
    Public Property ID As Integer
    Public Property Num_factura As Integer
    Public ReadOnly Property Formated_num_factura As String
        Get
            Return Num_factura.ToString("D15")
        End Get
    End Property
    Public Property ID_Cliente As Integer
    Public Property Cliente As String
    Public Property ID_Cajero As Integer
    Public Property Cajero As String
    Public Property Fecha_creacion As DateTime
    Public Property Efectivo As Decimal = 0
    Public ReadOnly Property Formated_Efectivo As String
        Get
            Return Efectivo.ToString("C", culturaCR) ' "C" es formato de moneda
        End Get
    End Property
    Public Property Tarjeta As Decimal = 0
    Public ReadOnly Property Formated_Tarjeta As String
        Get
            Return Tarjeta.ToString("C", culturaCR) ' "C" es formato de moneda
        End Get
    End Property
    Public Property Saldo_total As Decimal = 0
    Public ReadOnly Property Formated_saldo_total As String
        Get
            Return Saldo_total.ToString("C", culturaCR) ' "C" es formato de moneda
        End Get
    End Property
    Public Property Tipo_pago As Integer
    Public ReadOnly Property Formated_tipo_pago As String
        Get
            Select Case Tipo_pago
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
    Public Property Vuelto As Decimal = 0
    Public ReadOnly Property Formated_vuelto As String
        Get
            Return Vuelto.ToString("C", culturaCR) ' "C" es formato de moneda
        End Get
    End Property
    Public Property Comentario As String
    Public Property ListaProductos As New List(Of Cls_ProductoCaja)
    Public Property ID_CxC As Integer
    Public Property Saldo_restante As Decimal
    Public ReadOnly Property Formated_saldo_restante As String
        Get
            Return Saldo_restante.ToString("C", culturaCR) ' "C" es formato de moneda
        End Get
    End Property

    Private ReadOnly culturaCR As New CultureInfo("es-CR")

    ' Subrutina principal para guardar la factura
    Friend Async Function GuardarFactura(imprimir As Boolean, esCuentaPorCobrar As Boolean) As Task(Of Boolean)
        If MsgBox("¿Desea terminar la venta?", vbOKCancel + vbDefaultButton1, "Confirmar") = MsgBoxResult.Cancel Then
            Return False
        End If

        If ListaProductos.Count < 1 Then
            msgError("No se puede Guardar una factura vacía.")
            Return False
        End If

        Try
            Comentario = Comentario

            Dim resultado As String = Await GuardarFacturaDB(esCuentaPorCobrar)
            'Si dió algún tipo de error al guardar la factura, se muestra el mensaje y se sale del sub
            If resultado <> "OK" Then
                msgError("Error al guardar la factura: " & resultado)
                Return False
            End If

            ' Si se seleccionó la opción de imprimir, genera e imprime la factura
            If imprimir Then
                GENERAR_FACTURA(ID)
            End If
            Return True
        Catch ex As Exception
            msgError("Error: " & ex.Message)
            Return False
        End Try
    End Function
    Friend Async Function GuardarFacturaDB(esCuentaPorCobrar As Boolean) As Task(Of String)
        Return Await Task.Run(Function()

                                  Using db As New SQLiteConnection(GetConnectionString())
                                      db.Open()
                                      Dim transaction As SQLiteTransaction = db.BeginTransaction()

                                      Try
                                          ' 1. Guardar o actualizar la factura principal.
                                          GuardarFactura(db, transaction)

                                          ' 2. Guardar los productos y actualizar el inventario.
                                          GuardarProductos(db, transaction)

                                          ' 3. Guardar el comentario.
                                          GuardarComentario(db, transaction)

                                          If esCuentaPorCobrar Then
                                              EliminarCuentaPorCobrar(db, transaction)
                                          End If

                                          transaction.Commit()
                                          Return "OK"

                                      Catch ex As Exception
                                          transaction.Rollback()
                                          Return "Error en la transacción: " & ex.Message
                                      End Try
                                  End Using
                              End Function)
    End Function

    ' Guarda o actualiza los datos principales de la factura.
    Private Sub GuardarFactura(db As SQLiteConnection, transaction As SQLiteTransaction)
        Dim insertFacturaSQL As String = "INSERT INTO factura 
            (ID, num_factura, fecha_emision, ID_Cliente, ID_usuario, total, efectivo_cliente, tarjeta_cliente, vuelto, tipo_venta) 
            VALUES (@id, @num_factura, @fecha, @idCliente, @idUsu, @total, @efectivo, @tarjeta, @vuelto, @tipo_venta)"
        Using cmd As New SQLiteCommand(insertFacturaSQL, db, transaction)
            cmd.Parameters.AddWithValue("@id", ID)
            cmd.Parameters.AddWithValue("@num_factura", Num_factura)
            cmd.Parameters.AddWithValue("@idCliente", ID_Cliente)
            cmd.Parameters.AddWithValue("@idUsu", ID_Cajero)
            cmd.Parameters.AddWithValue("@fecha", Fecha_creacion)
            cmd.Parameters.AddWithValue("@total", Saldo_total)
            cmd.Parameters.AddWithValue("@efectivo", Efectivo)
            cmd.Parameters.AddWithValue("@tarjeta", Tarjeta)
            cmd.Parameters.AddWithValue("@vuelto", Vuelto)
            cmd.Parameters.AddWithValue("@tipo_venta", Tipo_pago)
            cmd.ExecuteNonQuery()
        End Using
    End Sub

    ' Elimina los productos anteriores y guarda los nuevos, actualizando el inventario.
    Private Sub GuardarProductos(db As SQLiteConnection, transaction As SQLiteTransaction)
        Dim deleteProductosSQL As String = "DELETE FROM factura_producto WHERE ID_Factura = @idFactura"
        Using cmd As New SQLiteCommand(deleteProductosSQL, db, transaction)
            cmd.Parameters.AddWithValue("@idFactura", ID)
            cmd.ExecuteNonQuery()
        End Using

        For Each producto As Cls_ProductoCaja In ListaProductos
            Dim insertProductoSQL As String = "INSERT INTO factura_producto (ID_Factura, ID_Producto, cant, precio_venta) VALUES (@idFactura, @idProducto, @cantidad, @precioVenta)"
            Using cmd As New SQLiteCommand(insertProductoSQL, db, transaction)
                cmd.Parameters.AddWithValue("@idFactura", ID)
                cmd.Parameters.AddWithValue("@idProducto", producto.ID)
                cmd.Parameters.AddWithValue("@cantidad", producto.Cantidad)
                cmd.Parameters.AddWithValue("@precioVenta", producto.Precio)
                cmd.ExecuteNonQuery()
            End Using

            Dim updateInventarioSQL As String = "UPDATE producto SET inventario = inventario - @cantidad WHERE ID = @idProducto"
            Using cmd As New SQLiteCommand(updateInventarioSQL, db, transaction)
                cmd.Parameters.AddWithValue("@cantidad", producto.Cantidad)
                cmd.Parameters.AddWithValue("@idProducto", producto.ID)
                cmd.ExecuteNonQuery()
            End Using
        Next
    End Sub

    ' Guarda o actualiza el comentario de la factura.
    Private Sub GuardarComentario(db As SQLiteConnection, transaction As SQLiteTransaction)
        Dim countComentario As Integer = 0
        Using cmd As New SQLiteCommand("SELECT COUNT(*) FROM factura_comentario WHERE ID_Factura = @idFactura", db, transaction)
            cmd.Parameters.AddWithValue("@idFactura", ID)
            countComentario = Convert.ToInt32(cmd.ExecuteScalar())
        End Using

        If countComentario > 0 Then
            Using cmd As New SQLiteCommand("UPDATE factura_comentario SET comentario = @comentario WHERE ID_Factura = @idFactura", db, transaction)
                cmd.Parameters.AddWithValue("@comentario", Comentario)
                cmd.Parameters.AddWithValue("@idFactura", ID)
                cmd.ExecuteNonQuery()
            End Using
        ElseIf countComentario = 0 And Not String.IsNullOrEmpty(Comentario) Then
            Using cmd As New SQLiteCommand("INSERT INTO factura_comentario (ID_Factura, comentario) VALUES (@idFactura, @comentario)", db, transaction)
                cmd.Parameters.AddWithValue("@comentario", Comentario)
                cmd.Parameters.AddWithValue("@idFactura", ID)
                cmd.ExecuteNonQuery()
            End Using
        End If
    End Sub

    Private Sub EliminarCuentaPorCobrar(db As SQLiteConnection, transaction As SQLiteTransaction)
        Using cmd As New SQLiteCommand("DELETE FROM CC_Encabezado WHERE ID = @ID;", db, transaction)
            cmd.Parameters.AddWithValue("@ID", ID_CxC)
            cmd.ExecuteNonQuery()
        End Using
    End Sub

    Friend Sub CargarDataFactura(id As Integer)
        Dim consulta = "SELECT f.ID, f.num_factura, f.fecha_emision, c.ID As 'ID_Cliente' c.nombre AS 'Cliente', " &
            "u.ID AS 'ID_Usuario', u.usuario AS 'Cajero', f.tipo_venta, " &
            "f.efectivo_cliente, f.tarjeta_cliente , f.vuelto , fc.comentario, f.total " &
            "FROM factura f " &
            "LEFT JOIN clientes c ON c.ID = f.ID_CLIENTE " &
            "LEFT JOIN usuario u ON u.ID = f.ID_USUARIO " &
            "LEFT JOIN factura_comentario fc ON fc.ID_Factura = f.ID WHERE f.num_factura " &
            "WHERE f.ID = @ID"
        Dim paramList As New List(Of SQLiteParameter) From {
            {New SQLiteParameter("@ID", id)}
        }
        CargarTablaParam(T, consulta, paramList)

        If T Is Nothing OrElse T.Tables.Count <= 0 OrElse T.Tables(0).Rows.Count <= 0 Then
            Exit Sub
        End If

        Dim fact = T.Tables(0).Rows(0)
        Me.ID = id
        Num_factura = fact("num_factura")
        Fecha_creacion = fact("fecha_emision")
        ID_Cliente = fact("ID_Cliente")
        Cliente = fact("Cliente")
        ID_Cajero = fact("ID_Usuario")
        Tipo_pago = fact("tipo_venta")
        Efectivo = fact("efectivo_cliente")
        Tarjeta = fact("tarjeta_cliente")
        Vuelto = fact("vuelto")
        Saldo_total = fact("total")

        getListaProductos()
    End Sub

    Friend Sub GetListaProductos()
        SQL = "SELECT p.ID, p.codigo, p.nombre, fp.precio_venta , fp.cant
                FROM factura_producto fp 
                LEFT JOIN producto p ON p.ID = fp.ID_Producto 
                WHERE fp.ID_Factura = @ID"

        Dim paramList As New List(Of SQLiteParameter) From {
            {New SQLiteParameter("@ID", ID)}
        }

        CargarTablaParam(T, SQL, paramList)

        If T Is Nothing OrElse T.Tables.Count <= 0 OrElse T.Tables(0).Rows.Count <= 0 Then
            ListaProductos = New List(Of Cls_ProductoCaja)
        End If

        For Each row As DataRow In T.Tables(0).Rows
            Dim prod As New Cls_ProductoCaja With {
                .ID = row("ID"),
                .Codigo = row("Codigo"),
                .Producto = row("nombre"),
                .Precio = row("precio_venta"),
                .Cantidad = row("cant")
            }

            ListaProductos.Add(prod)
        Next
    End Sub

End Class
