Imports System.Data.SQLite
Imports System.Globalization
Imports Serilog
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
    Public Property Excluir_de_cierre As Integer
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
    Friend Async Function GuardarFactura(imprimir As Boolean) As Task(Of Boolean)
        If MsgBox("¿Desea terminar la venta?", vbOKCancel + vbDefaultButton1, "Confirmar") = MsgBoxResult.Cancel Then
            Log.Information("Guardado de factura cancelado por el usuario.")
            Return False
        End If

        If ListaProductos.Count < 1 Then
            MsgError("No se puede Guardar una factura vacía.")
            Return False
        End If

        Try
            Dim resultado As String = Await GuardarFacturaDB()
            'Si dió algún tipo de error al guardar la factura, se muestra el mensaje y se sale del sub
            If resultado <> "OK" Then
                MsgError("Error al guardar la factura: " & resultado)
                Return False
            End If

            ' Si se seleccionó la opción de imprimir, genera e imprime la factura
            If imprimir Then
                Log.Information("Factura guardada con éxito. ID={FacturaID}, NumFactura={NumFactura}, ClienteID={ClienteID}, Total={Total}, Efectivo={Efectivo}, Tarjeta={Tarjeta}, Vuelto={Vuelto}, TipoPago={TipoPago}",
                                ID, Num_factura, ID_Cliente, Saldo_total, Efectivo, Tarjeta, Vuelto, Formated_tipo_pago)
                GENERAR_FACTURA(ID, "Comun")
            End If

            Log.Information("Proceso de guardado de factura completado con éxito.")
            Return True
        Catch ex As Exception
            MsgError("Error al guardar o generar la factura: " & ex.Message)
            Return False
        End Try
    End Function
    Friend Async Function GuardarFacturaDB() As Task(Of String)
        Return Await Task.Run(Function()

                                  Using db As New SQLiteConnection(GetConnectionString())
                                      db.Open()
                                      Log.Debug("Conexión a la base de datos abierta para guardar factura. UsuarioID={UserID}, ClienteID={ClienteID}, Total={Total}, Efectivo={Efectivo}, Tarjeta={Tarjeta}, Vuelto={Vuelto}, TipoPago={TipoPago}",
                                                ID_Cajero, ID_Cliente, Saldo_total, Efectivo, Tarjeta, Vuelto, Formated_tipo_pago)
                                      Dim transaction As SQLiteTransaction = db.BeginTransaction()

                                      Try
                                          ' 1. Guardar o actualizar la factura principal.
                                          GuardarFactura(db, transaction)
                                          Log.Information("Factura principal guardada con éxito. ID={FacturaID}", ID)

                                          ' 2. Guardar los productos y actualizar el inventario.
                                          GuardarProductos(db, transaction)
                                          Log.Information("Productos de la factura guardados y inventario actualizado con éxito. FacturaID={FacturaID}, NumProductos={NumProductos}",
                                                            ID, ListaProductos.Count)

                                          ' 3. Guardar el comentario.
                                          GuardarComentario(db, transaction)
                                          Log.Information("Comentario de la factura guardado con éxito. FacturaID={FacturaID}, Comentario={Comentario}",
                                                                ID, If(String.IsNullOrEmpty(Comentario), "N/A", Comentario))

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
            (ID, num_factura, fecha_emision, ID_Cliente, ID_usuario, total, efectivo_cliente, tarjeta_cliente, vuelto, tipo_venta, excluir_de_cierre) 
            VALUES (@id, @num_factura, @fecha, @idCliente, @idUsu, @total, @efectivo, @tarjeta, @vuelto, @tipo_venta, @excluir)"
        Log.Debug("Preparando comando SQL para insertar/actualizar factura: {SQL}", insertFacturaSQL)
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
            cmd.Parameters.AddWithValue("@excluir", Excluir_de_cierre)
            cmd.ExecuteNonQuery()
        End Using
    End Sub

    ' Elimina los productos anteriores y guarda los nuevos, actualizando el inventario.
    Private Sub GuardarProductos(db As SQLiteConnection, transaction As SQLiteTransaction)
        Dim deleteProductosSQL As String = "DELETE FROM factura_producto WHERE ID_Factura = @idFactura"
        Log.Information("Eliminando productos anteriores de la factura ID={FacturaID} antes de insertar nuevos productos.", ID)
        Using cmd As New SQLiteCommand(deleteProductosSQL, db, transaction)
            cmd.Parameters.AddWithValue("@idFactura", ID)
            cmd.ExecuteNonQuery()
        End Using

        For Each producto As Cls_ProductoCaja In ListaProductos
            Dim insertProductoSQL As String = "INSERT INTO factura_producto (ID_Factura, ID_Producto, cant, precio_venta) VALUES (@idFactura, @idProducto, @cantidad, @precioVenta)"
            Log.Information("Insertando producto en factura. FacturaID={FacturaID}, ProductoID={ProductoID}, Cantidad={Cantidad}, PrecioVenta={PrecioVenta}",
                            ID, producto.ID, producto.Cantidad, producto.Precio)
            Using cmd As New SQLiteCommand(insertProductoSQL, db, transaction)
                cmd.Parameters.AddWithValue("@idFactura", ID)
                cmd.Parameters.AddWithValue("@idProducto", producto.ID)
                cmd.Parameters.AddWithValue("@cantidad", producto.Cantidad)
                cmd.Parameters.AddWithValue("@precioVenta", producto.Precio)
                cmd.ExecuteNonQuery()
            End Using

            Dim updateInventarioSQL As String = "UPDATE producto Set inventario = inventario - @cantidad WHERE ID = @idProducto"
            Log.Information("Actualizando inventario del producto. ProductoID={ProductoID}, CantidadRestada={CantidadRestada}",
                            producto.ID, producto.Cantidad)
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
        Using cmd As New SQLiteCommand("Select COUNT(*) FROM factura_comentario WHERE ID_Factura = @idFactura", db, transaction)
            cmd.Parameters.AddWithValue("@idFactura", ID)
            Log.Information("Verificando existencia de comentario para la factura ID={FacturaID}", ID)
            countComentario = Convert.ToInt32(cmd.ExecuteScalar())
        End Using

        If countComentario > 0 Then
            Using cmd As New SQLiteCommand("UPDATE factura_comentario Set comentario = @comentario WHERE ID_Factura = @idFactura", db, transaction)
                cmd.Parameters.AddWithValue("@comentario", Comentario)
                cmd.Parameters.AddWithValue("@idFactura", ID)
                Log.Information("Actualizando comentario existente para la factura ID={FacturaID}", ID)
                cmd.ExecuteNonQuery()
            End Using
        ElseIf countComentario = 0 And Not String.IsNullOrEmpty(Comentario) Then
            Using cmd As New SQLiteCommand("INSERT INTO factura_comentario (ID_Factura, comentario) VALUES (@idFactura, @comentario)", db, transaction)
                cmd.Parameters.AddWithValue("@comentario", Comentario)
                cmd.Parameters.AddWithValue("@idFactura", ID)
                Log.Information("Insertando nuevo comentario para la factura ID={FacturaID}", ID)
                cmd.ExecuteNonQuery()
            End Using
        End If
    End Sub

    Friend Sub CargarDataFactura(id As Integer)
        Dim consulta = "Select f.ID, f.num_factura, f.fecha_emision, c.ID As 'ID_Cliente' c.nombre AS 'Cliente', " &
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
        Log.Information("Cargando datos de la factura ID={FacturaID} desde la base de datos.", id)
        CargarTablaParam(T, consulta, paramList)

        If T Is Nothing OrElse T.Tables.Count <= 0 OrElse T.Tables(0).Rows.Count <= 0 Then
            MsgError("No se encontró la factura especificada.")
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
        Cajero = fact("Cajero")
        Comentario = If(IsDBNull(fact("comentario")), "", fact("comentario"))

        Log.Information("Datos de la factura cargados: NumFactura={NumFactura}, ClienteID={ClienteID}, CajeroID={CajeroID}, Total={Total}, Efectivo={Efectivo}, Tarjeta={Tarjeta}, Vuelto={Vuelto}, TipoPago={TipoPago}",
                        Num_factura, ID_Cliente, ID_Cajero, Saldo_total, Efectivo, Tarjeta, Vuelto, Formated_tipo_pago)

        Log.Information("Cargando lista de productos para la factura ID={FacturaID}", id)
        GetListaProductos()
    End Sub

    Friend Sub GetListaProductos()
        SQL = "SELECT p.ID, p.codigo, p.nombre, fp.precio_venta , fp.cant
                FROM factura_producto fp 
                LEFT JOIN producto p ON p.ID = fp.ID_Producto 
                WHERE fp.ID_Factura = @ID"

        Dim paramList As New List(Of SQLiteParameter) From {
            {New SQLiteParameter("@ID", ID)}
        }
        Log.Information("Ejecutando consulta para obtener productos de la factura ID={FacturaID}", ID)
        CargarTablaParam(T, SQL, paramList)

        If T Is Nothing OrElse T.Tables.Count <= 0 OrElse T.Tables(0).Rows.Count <= 0 Then
            Log.Warning("No se encontraron productos asociados a la factura ID={FacturaID}. Devolviendo la lista vacía", ID)
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

        Log.Information("Productos cargados para la factura ID={FacturaID}. NumProductos={NumProductos}", ID, ListaProductos.Count)
    End Sub

End Class
