Imports System.Data.SQLite
Imports SistemaFacturaciónCommon.SistemaFacturacion.Data
Imports SistemaFacturaciónCommon.SistemaFacturacion.Forms.Busqueda
Imports SistemaFacturaciónCommon.SistemaFacturacion.Modules
Namespace SistemaFacturacion.Data
    Public Class Cls_CuentasXCobrar
        Friend Property ID As Integer
        Friend Property ID_Cliente As Integer
        Friend Property Cliente As String
        Friend Property fecha_creacion As DateTime
        Friend Property saldo_total As Decimal
        Friend Property comentario As String
        Friend Property listaPagos As List(Of Cls_CxCPagos)

        Friend Async Function agregarActualizarCuenta(actualizar_factura_cobrar As Boolean, productList As List(Of Cls_ProductoCaja)) As Task(Of String)
            Return Await Task.Run(Function()
                                      ' Iniciar una transacción de base de datos
                                      Dim dbConnection As New SQLiteConnection(GetConnectionString())
                                      dbConnection.Open()
                                      Dim transaction As SQLiteTransaction = dbConnection.BeginTransaction()

                                      Try
                                          If Not actualizar_factura_cobrar Then
                                              ' Caso: Guardar por primera vez
                                              ID = OBTENERPK("CC_Encabezado", "ID")
                                              Dim insertFacturaSQL As String = "INSERT INTO CC_Encabezado 
                                                                                (ID_Cliente, fecha_creacion, saldo_total, comentario) 
                                                                                VALUES (@IDCliente, @FechaCreacion, @SaldoTotal, @comentario);"
                                              Dim parametrosFactura As New Dictionary(Of String, Object) From {
                                              {"FechaCreacion", DateTime.Now},
                                              {"IDCliente", ID_Cliente},
                                              {"SaldoTotal", saldo_total},
                                              {"comentario", comentario}
                                          }
                                              Using cmd As New SQLiteCommand(insertFacturaSQL, dbConnection, transaction)
                                                  'Se agrega cada uno de los parámetros al comando
                                                  For Each p In parametrosFactura
                                                      cmd.Parameters.AddWithValue("@" & p.Key, p.Value)
                                                  Next
                                                  cmd.ExecuteNonQuery()
                                              End Using

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
                                              Using cmd As New SQLiteCommand(updateFacturaSQL, dbConnection, transaction)
                                                  For Each p In parametrosUpdate
                                                      'Se agrega cada uno de los parámetros al comando
                                                      cmd.Parameters.AddWithValue("@" & p.Key, p.Value)
                                                  Next
                                                  cmd.ExecuteNonQuery()
                                              End Using

                                              ' Eliminar productos anteriores
                                              Dim deleteProductosSQL As String = "DELETE FROM CC_DetalleProducto WHERE ID_Encabezado = @IDEncabezado"
                                              Using cmd As New SQLiteCommand(deleteProductosSQL, dbConnection, transaction)
                                                  cmd.Parameters.AddWithValue("@IDEncabezado", ID)
                                                  cmd.ExecuteNonQuery()
                                              End Using
                                          End If

                                          Dim insertProductoSQL As String = "INSERT INTO CC_DetalleProducto 
                                                                                (ID_Encabezado, ID_Producto, cantidad, precio, total_linea) 
                                                                                VALUES (@IDEncabezado, @IDProducto, @Cantidad, @Precio, @TotalLinea);"
                                          For Each prod In productList
                                              Using cmd As New SQLiteCommand(insertProductoSQL, dbConnection, transaction)
                                                  cmd.Parameters.AddWithValue("@IDEncabezado", ID)
                                                  cmd.Parameters.AddWithValue("@IDProducto", prod.ID)
                                                  cmd.Parameters.AddWithValue("@Cantidad", prod.Cantidad)
                                                  cmd.Parameters.AddWithValue("@Precio", prod.Precio)
                                                  cmd.Parameters.AddWithValue("@TotalLinea", prod.Precio * prod.Cantidad)
                                                  cmd.ExecuteNonQuery()
                                              End Using
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
    End Class
End Namespace
