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
        Public Property Fecha_creacion As DateTime
        Public Property Saldo_total As Decimal = 0
        Public ReadOnly Property Formated_saldo_total As String
            Get
                Return Saldo_total.ToString("C", CulturaCR) ' "C" es formato de moneda
            End Get
        End Property
        Public Property Comentario As String
        Public Property ListaProductos As List(Of Cls_DetalleProductoCxC)
        Public Property ListaPagos As List(Of Cls_CxCPagos)
        Public ReadOnly Property Saldo_restante As Decimal
            Get
                Dim saldo = Saldo_total
                For Each pago In ListaPagos
                    saldo -= pago.total
                Next
                Return saldo
            End Get
        End Property
        Public ReadOnly Property Formated_Saldo_restante As String
            Get
                Return Saldo_restante.ToString("C", CulturaCR) ' "C" es formato de moneda
            End Get
        End Property

        Private ReadOnly CulturaCR As New CultureInfo("es-CR")


        Friend Async Function AgregarActualizarCuenta(actualizar_factura_cobrar As Boolean) As Task(Of String)
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
                                                  {"SaldoTotal", Saldo_total},
                                                  {"comentario", Comentario}
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
                                                  {"comentario", Comentario},
                                                  {"IDCliente", ID_Cliente},
                                                  {"SaldoTotal", Saldo_total},
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
                                          For Each prod In ListaProductos
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

        Friend Sub GetDetailsWithID(ID_CxC As Integer)
            Try
                ID = ID_CxC
                If Not getEncabezado(ID) Then Throw New Exception("No se encontró la información inicial de la cuenta por cobrar")
                ListaProductos = getListaProductos(ID)
                ListaPagos = getListaPagos(ID)
            Catch ex As Exception
                Console.WriteLine($"Error al obtener los datos de la cuenta por cobrar: {ex.Message}")
            End Try
        End Sub

        Friend Function GetEncabezado(ID_CxC As Integer) As Boolean
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
            Fecha_creacion = T.Tables(0).Rows(0)("fecha_creacion")
            Saldo_total = T.Tables(0).Rows(0)("saldo_total")
            Comentario = T.Tables(0).Rows(0)("comentario")
            Return True
        End Function

        Friend Function GetListaProductos(ID_CxC As Integer) As List(Of Cls_DetalleProductoCxC)
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
                    .Cantidad = fila.Item("Cantidad")
                }
                listaProd.Add(producto)
            Next
            Return listaProd
        End Function

        Friend Function GetListaPagos(ID_CxC As Integer) As List(Of Cls_CxCPagos)
            SQL = "SELECT cp.ID , cp.fecha As Fecha , CP.tipo_venta, cp.monto_efectivo As Efectivo , 
                    cp.monto_tarjeta As Tarjeta , cp.comentario As Comentario
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
                    .Fecha = fila.Item("Fecha"),
                    .Tipo_venta = fila.Item("Tipo Venta"),
                    .Monto_efectivo = fila.Item("Efectivo"),
                    .Monto_tarjeta = fila.Item("Tarjeta"),
                    .Total = fila.Item("Efectivo") + fila.Item("Tarjeta"),
                    .Comentario = fila.Item("Comentario")
                }
                listaPago.Add(pago)
            Next
            Return listaPago
        End Function

        Friend Function ObtenerSaldoPendiente() As Decimal
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
