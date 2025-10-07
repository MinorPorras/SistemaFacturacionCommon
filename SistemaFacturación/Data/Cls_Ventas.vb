Imports System.Data.SQLite
Imports System.Globalization
Imports SistemaFacturaciónCommon.SistemaFacturacion.Data
Imports SistemaFacturaciónCommon.SistemaFacturacion.Modules

Public Class Cls_Ventas
    Public Property ID As Integer
    Public Property Num_factura As Integer
    Public Property Formated_num_factura As String
    Public Property ID_Cliente As Integer
    Public Property Cliente As String
    Public Property ID_Cajero As Integer
    Public Property Cajero As String
    Public Property Fecha_creacion As DateTime
    Public Property Efectivo As Decimal = 0
    Public Property Tarjeta As Decimal = 0
    Public Property Saldo_total As Decimal = 0
    Public ReadOnly Property Formated_saldo_total As String
        Get
            Return Saldo_total.ToString("C", culturaCR) ' "C" es formato de moneda
        End Get
    End Property
    Public Property Tipo_pago As Integer
    Public Property Formated_tipo_pago As String
    Public Property Vuelto As Decimal = 0
    Public Property Comentario As String
    Public Property ListaProductos As List(Of Cls_ProductoCaja)

    Private ReadOnly culturaCR As New CultureInfo("es-CR")


    Friend Async Function GuardarFacturaDB(esCuentaPorCobrar As Boolean) As Task(Of String)
        Return Await Task.Run(Function()

                                  Using db As New SQLiteConnection(GetConnectionString())
                                      db.Open()
                                      Dim transaction As SQLiteTransaction = db.BeginTransaction()

                                      Try
                                          ' 1. Guardar o actualizar la factura principal.
                                          GuardarOActualizarFactura(db, transaction, esCuentaPorCobrar)

                                          ' 2. Guardar los productos y actualizar el inventario.
                                          GuardarProductos(db, transaction)

                                          ' 3. Guardar el comentario.
                                          GuardarComentario(db, transaction)

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
    Private Sub GuardarOActualizarFactura(db As SQLiteConnection, transaction As SQLiteTransaction, esCuentaPorCobrar As Boolean)
        If esCuentaPorCobrar Then
            Dim updateFacturaSQL As String = "UPDATE factura SET 
                                                fecha_emision = @fecha, 
                                                total = @total, 
                                                efectivo_cliente = @efectivo, 
                                                tarjeta_cliente = @tarjeta, 
                                                vuelto = @vuelto, 
                                                tipo_venta = @tipo_venta, 
                                                cobrada = 1 
                                                WHERE ID = @id"
            Using cmd As New SQLiteCommand(updateFacturaSQL, db, transaction)
                cmd.Parameters.AddWithValue("@id", ID)
                cmd.Parameters.AddWithValue("@fecha", fecha_creacion)
                cmd.Parameters.AddWithValue("@total", saldo_total)
                cmd.Parameters.AddWithValue("@efectivo", efectivo)
                cmd.Parameters.AddWithValue("@tarjeta", tarjeta)
                cmd.Parameters.AddWithValue("@vuelto", vuelto)
                cmd.Parameters.AddWithValue("@tipo_venta", tipo_pago)
                cmd.ExecuteNonQuery()
            End Using
        Else
            Dim insertFacturaSQL As String = "INSERT INTO factura 
            (ID, num_factura, fecha_emision, ID_Cliente, ID_usuario, total, efectivo_cliente, tarjeta_cliente, vuelto, tipo_venta, cobrada) 
            VALUES (@id, @num_factura, @fecha, @idCliente, @idUsu, @total, @efectivo, @tarjeta, @vuelto, @tipo_venta, 1)"
            Using cmd As New SQLiteCommand(insertFacturaSQL, db, transaction)
                cmd.Parameters.AddWithValue("@id", ID)
                cmd.Parameters.AddWithValue("@num_factura", num_factura)
                cmd.Parameters.AddWithValue("@idCliente", ID_Cliente)
                cmd.Parameters.AddWithValue("@idUsu", ID_Cajero)
                cmd.Parameters.AddWithValue("@fecha", fecha_creacion)
                cmd.Parameters.AddWithValue("@total", saldo_total)
                cmd.Parameters.AddWithValue("@efectivo", efectivo)
                cmd.Parameters.AddWithValue("@tarjeta", tarjeta)
                cmd.Parameters.AddWithValue("@vuelto", vuelto)
                cmd.Parameters.AddWithValue("@tipo_venta", tipo_pago)
                cmd.ExecuteNonQuery()
            End Using
        End If
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
                cmd.Parameters.AddWithValue("@comentario", comentario)
                cmd.Parameters.AddWithValue("@idFactura", ID)
                cmd.ExecuteNonQuery()
            End Using
        ElseIf countComentario = 0 And Not String.IsNullOrEmpty(Comentario) Then
            Using cmd As New SQLiteCommand("INSERT INTO factura_comentario (ID_Factura, comentario) VALUES (@idFactura, @comentario)", db, transaction)
                cmd.Parameters.AddWithValue("@comentario", comentario)
                cmd.Parameters.AddWithValue("@idFactura", ID)
                cmd.ExecuteNonQuery()
            End Using
        End If
    End Sub


End Class
