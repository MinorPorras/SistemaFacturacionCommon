Imports System.Data.SQLite
Imports System.Globalization
Imports SistemaFacturaciónCommon.SistemaFacturacion.Data
Imports SistemaFacturaciónCommon.SistemaFacturacion.Forms.Busqueda
Imports SistemaFacturaciónCommon.SistemaFacturacion.Modules
Namespace SistemaFacturacion.Data
    Public Class Cls_CuentasXCobrar
        Public Property ID As Integer
        Public Property ID_Cliente As Integer
        Public Property Cliente As String
        Public Property ID_Cajero As Integer
        Public Property fecha_creacion As DateTime
        Public Property saldo_total As Decimal
        Public Property formated_saldo_total As String
        Public Property comentario As String
        Public Property listaProductos As List(Of Cls_DetalleProductoCxC)
        Public Property listaPagos As List(Of Cls_CxCPagos)

        Private culturaCR As New CultureInfo("es-CR")


        Friend Async Function agregarActualizarCuenta(actualizar_factura_cobrar As Boolean) As Task(Of String)
            Return Await Task.Run(Function()
                                      ' Iniciar una transacción de base de datos
                                      Dim dbConnection As New SQLiteConnection(GetConnectionString())
                                      dbConnection.Open()
                                      Dim transaction As SQLiteTransaction = dbConnection.BeginTransaction()

                                      Try
                                          If Not actualizar_factura_cobrar Then
                                              ' Caso: Guardar por primera vez
                                              Dim insertFacturaSQL As String = "INSERT INTO CC_Encabezado 
                                                                                (ID_Cliente, fecha_creacion, saldo_total, comentario) 
                                                                                VALUES (@IDCliente, @FechaCreacion, @SaldoTotal, @comentario);"
                                              Dim parametrosFactura As New Dictionary(Of String, Object) From {
                                                  {"FechaCreacion", DateTime.Now},
                                                  {"IDCliente", ID_Cliente},
                                                  {"SaldoTotal", saldo_total},
                                                  {"comentario", comentario}
                                              }
                                              EJECUTAR_PARAMETROS_TRANSACCION(insertFacturaSQL, parametrosFactura, dbConnection, transaction)

                                              ID = GetLastInsertedID_Transaction(dbConnection, transaction)
                                          Else
                                              ' Caso: Actualizar factura existente
                                              Dim updateFacturaSQL As String = "UPDATE CC_Encabezado SET
                                                                                ID_Cliente = @IDCliente,
                                                                                saldo_total = @SaldoTotal,
                                                                                comentario = @comentario
                                                                                WHERE ID = @IDEncabezado;"
                                              'Obtener el PK del numFactura actual
                                              Dim parametrosUpdate As New Dictionary(Of String, Object) From {
                                                  {"comentario", comentario},
                                                  {"IDCliente", ID_Cliente},
                                                  {"SaldoTotal", saldo_total},
                                                  {"IDEncabezado", ID}
                                              }
                                              EJECUTAR_PARAMETROS_TRANSACCION(updateFacturaSQL, parametrosUpdate, dbConnection, transaction)

                                              ' Eliminar productos anteriores
                                              Dim deleteProductosSQL As String = "DELETE FROM CC_DetalleProducto WHERE ID_Encabezado = @IDEncabezado"
                                              Dim paramDeleteProds As New Dictionary(Of String, Object) From {
                                                {"IDEncabezado", ID}
                                              }
                                              EJECUTAR_PARAMETROS_TRANSACCION(deleteProductosSQL, paramDeleteProds, dbConnection, transaction)
                                          End If

                                          Dim insertProductoSQL As String = "INSERT INTO CC_DetalleProducto 
                                                                                (ID_Encabezado, ID_Producto, cantidad, precio, total_linea) 
                                                                                VALUES (@IDEncabezado, @IDProducto, @Cantidad, @Precio, @TotalLinea);"
                                          For Each prod In listaProductos
                                              Dim paramProds As New Dictionary(Of String, Object) From {
                                                {"IDEncabezado", ID},
                                                {"IDProducto", prod.ID},
                                                {"Cantidad", prod.cantidad},
                                                {"Precio", prod.Precio},
                                                {"TotalLinea", prod.total}
                                              }
                                              EJECUTAR_PARAMETROS_TRANSACCION(insertProductoSQL, paramProds, dbConnection, transaction)
                                          Next


                                          transaction.Commit()
                                          Return "OK"

                                      Catch ex As Exception
                                          transaction.Rollback()
                                          Return "Error en la transacción: " & ex.Message
                                      Finally
                                          If dbConnection.State = ConnectionState.Open Then
                                              dbConnection.Close()
                                          End If
                                      End Try
                                  End Function)
        End Function

        Friend Sub getDetailsWithID(ID_CxC As Integer)
            Try
                ID = ID_CxC
                If Not getEncabezado(ID) Then Throw New Exception("No se encontró la información inicial de la cuenta por cobrar")
                listaProductos = getListaProductos(ID)
                listaPagos = getListaPagos(ID)
            Catch ex As Exception
                Console.WriteLine($"Error al obtener los datos de la cuenta por cobrar: {ex.Message}")
            End Try
        End Sub

        Friend Function getEncabezado(ID_CxC As Integer) As Boolean
            SQL = "SELECT CE.ID_Cliente , C.nombre , CE.fecha_creacion , CE.saldo_total , CE.comentario 
            FROM CC_Encabezado ce 
            LEFT JOIN clientes c ON CE.ID_Cliente = C.ID
            where ce.ID = @id"
            Dim paramList As New List(Of SQLiteParameter) From {
                {New SQLiteParameter("@id", ID_CxC)}
            }

            CargarTablaParam(T, SQL, paramList)
            If T Is Nothing OrElse T.Tables.Count <= 0 OrElse T.Tables(0).Rows.Count <= 0 Then
                Return False
            End If
            ID_Cliente = T.Tables(0).Rows(0)("ID_Cliente")
            Cliente = T.Tables(0).Rows(0)("Nombre")
            fecha_creacion = T.Tables(0).Rows(0)("fecha_creacion")
            saldo_total = T.Tables(0).Rows(0)("saldo_total")
            comentario = T.Tables(0).Rows(0)("comentario")
            formated_saldo_total = saldo_total.ToString("C", culturaCR)
            Return True
        End Function

        Friend Function getListaProductos(ID_CxC As Integer) As List(Of Cls_DetalleProductoCxC)
            SQL = "SELECT cdp.ID_Producto , p.codigo As Código , p.nombre As Nombre , cdp.precio As Precio , cdp.cantidad As Cantidad , cdp.total_linea As Total
                    FROM CC_DetalleProducto cdp 
                    LEFT JOIN producto p ON P.ID = cdp.ID_Producto 
                    WHERE cdp.ID_Encabezado = @id"
            Dim paramList As New List(Of SQLiteParameter) From {
                {New SQLiteParameter("@id", ID_CxC)}
            }
            CargarTablaParam(T, SQL, paramList)
            If T Is Nothing OrElse T.Tables.Count <= 0 OrElse T.Tables(0).Rows.Count <= 0 Then
                Return New List(Of Cls_DetalleProductoCxC)
            End If
            Dim listaProd As New List(Of Cls_DetalleProductoCxC)
            For Each fila As DataRow In T.Tables(0).Rows
                Dim producto As New Cls_DetalleProductoCxC With {
                    .ID = fila.Item("ID_Producto"),
                    .Codigo = fila.Item("Código"),
                    .Nombre = fila.Item("Nombre"),
                    .Precio = fila.Item("Precio"),
                    .cantidad = fila.Item("Cantidad"),
                    .total = fila.Item("Total")
                }
                producto.formated_Precio = producto.Precio.ToString("C", culturaCR)
                producto.formated_total = producto.total.ToString("C", culturaCR)
                listaProd.Add(producto)
            Next
            Return listaProd
        End Function

        Friend Function getListaPagos(ID_CxC As Integer) As List(Of Cls_CxCPagos)
            SQL = "SELECT cp.ID , cp.fecha As Fecha , CP.tipo_venta, 
                    CASE
	                    WHEN cp.tipo_venta = 0 THEN 'Efectivo'
	                    WHEN cp.tipo_venta = 1 THEN 'Tarjeta'
	                    WHEN cp.tipo_venta = 2 THEN 'Depósito'
	                    WHEN cp.tipo_venta = 3 THEN 'Sinpe'
	                    WHEN cp.tipo_venta = 4 THEN 'Mixto'
	                    ELSE 'No válido'
                    END As 'TipoVenta', cp.monto_efectivo As Efectivo , cp.monto_tarjeta As Tarjeta , cp.comentario As Comentario
                    FROM CC_Pagos cp WHERE CP.ID_Encabezado = @id "
            Dim paramList As New List(Of SQLiteParameter) From {
                {New SQLiteParameter("@id", ID_CxC)}
            }
            CargarTablaParam(T, SQL, paramList)
            If T Is Nothing OrElse T.Tables.Count <= 0 OrElse T.Tables(0).Rows.Count <= 0 Then
                Return New List(Of Cls_CxCPagos)
            End If
            Dim listaPago As New List(Of Cls_CxCPagos)
            For Each fila As DataRow In T.Tables(0).Rows
                Dim pago As New Cls_CxCPagos With {
                    .ID = fila.Item("ID"),
                    .fecha = fila.Item("Fecha"),
                    .tipo_venta = fila.Item("Tipo Venta"),
                    .tipo_venta_value = fila.Item("TipoVenta"),
                    .monto_efectivo = fila.Item("Efectivo"),
                    .monto_tarjeta = fila.Item("Tarjeta"),
                    .total = fila.Item("Efectivo") + fila.Item("Tarjeta"),
                    .Comentario = fila.Item("Comentario")
                }
                pago.formated_monto_efectivo = pago.monto_efectivo.ToString("C", culturaCR)
                pago.formated_monto_tarjeta = pago.monto_tarjeta.ToString("C", culturaCR)
                pago.formated_total = pago.total.ToString("C", culturaCR)
                listaPago.Add(pago)
            Next
            Return listaPago
        End Function

        Friend Function obtenerSaldoPendiente() As Decimal
            SQL = "SELECT 
                        ce.saldo_total - IFNULL(SUM(cp.monto_efectivo + cp.monto_tarjeta), 0) AS Saldo_Pendiente
                    FROM
                        CC_Encabezado ce
                    LEFT JOIN
                        CC_Pagos cp ON cp.ID_Encabezado = ce.ID
                    WHERE
                        ce.ID = @ID
                    GROUP BY
                        ce.ID, ce.saldo_total;"
            Dim paramList As New List(Of SQLiteParameter) From {
                {New SQLiteParameter("@ID", ID)}
            }
            CargarTablaParam(T, SQL, paramList)
            'Se revisa que exista la tabla
            If T Is Nothing OrElse T.Tables.Count <= 0 Then
                Return 0
            End If
            'Se revisa que haya al menos una fila
            If T.Tables(0).Rows.Count <= 0 Then
                Return 0
            End If
            'Se obtiene el saldo y se revisa si este no es null
            Dim saldo As Object = T.Tables(0).Rows(0).Item("Saldo_Pendiente")

            If IsDBNull(saldo) Then
                Return 0
            End If
            'Se retorna el saldo como decimal
            Return Convert.ToDecimal(saldo)
        End Function
    End Class
End Namespace
