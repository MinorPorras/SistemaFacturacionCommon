Public Class P_DatosFactura
    Friend idFact As String
    Private Sub BTN_RegresarPed_Click(sender As Object, e As EventArgs) Handles BTN_RegresarPed.Click
        Owner.Select()
        Me.Close()
    End Sub

    Public Sub CargarDatos(datosFactura As Cls_DatosFactura)
        Me.idFact = datosFactura.IdFactura
        Me.TXT_NumFact.Text = datosFactura.NumFactura
        Me.TXT_FechaEmision.Text = datosFactura.Fecha
        Me.TXT_Cliente.Text = datosFactura.Cliente
        Me.TXT_Cajero.Text = datosFactura.Cajero
        Me.TXT_Comentario.Text = datosFactura.Comentario
        Me.TXT_Total.Text = datosFactura.TotalCaja
        Me.TXT_Efectivo.Text = datosFactura.Efectivo
        Me.TXT_Tarjeta.Text = datosFactura.Tarjeta
        Me.TXT_Vuelto.Text = datosFactura.Vuelto
        Me.TXT_TipoPago.Text = datosFactura.TipoPago
        CargarProds()
    End Sub

    Friend Sub CargarProds()
        Try
            T.Tables.Clear()
            SQL = "SELECT p.codigo, p.nombre, f.cant, f.precio_venta 
                    FROM factura_producto f 
                    Left Join producto p ON p.ID = f.ID_Producto
                    WHERE f.ID_Factura = " & idFact
            Cargar_Tabla(T, SQL)
            If T.Tables(0).Rows.Count > 0 Then
                Dim bin As New BindingSource With {
                    .DataSource = T.Tables(0)
                }
                DGV_ProdFact.DataSource = bin
            End If
        Catch ex As Exception
            If DGV_ProdFact.IsHandleCreated Then
                If ex.Message <> "InvalidArgument=El valor de '0' no es válido para 'index'." & vbCrLf & "Nombre del parámetro: index" Then
                    ' Mostrar un mensaje de error genérico
                    msgError("Error al cargar la lista de facturas: " & ex.Message)
                End If
            End If
        End Try
    End Sub

    Private Sub DGV_ProdFact_DataBindingComplete(sender As Object, e As DataGridViewBindingCompleteEventArgs) Handles DGV_ProdFact.DataBindingComplete
        DGV_ProdFact.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        DGV_ProdFact.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.DisplayedCells)
        DGV_ProdFact.GridColor = Color.DarkGray
    End Sub

    Private Sub BTN_CerrarApp_Click(sender As Object, e As EventArgs) Handles BTN_CerrarApp.Click
        msgCerrarApp()
    End Sub

    Private Sub P_DatosFactura_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class