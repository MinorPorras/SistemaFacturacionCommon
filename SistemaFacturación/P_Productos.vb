Imports System.Threading.Tasks
Public Class P_Productos
    Private stringConsultaBase As String = "SELECT p.ID AS 'ID', p.codigo AS 'Código', p.nombre AS 'Producto', d.descripcion AS 'Descripción', " &
                          "p.precio_base AS 'Costo', p.porc_impuesto AS 'Imp', p.ganancia AS '%', " &
                          "pv.precio_venta AS 'Venta', " &
                          "CASE WHEN p.variable=1 THEN 'Si' ELSE 'No' END AS 'Var', " &
                          "c.ID_Categoria AS 'ID_cat', cat.nombre AS 'Categoría', " &
                          "pm.ID_Marca AS 'ID_Marca', m.Nombre AS 'Marca', pp.ID_Proveedor AS 'ID_Prov', " &
                          "pr.nombre AS 'Proveedor', p.inventario AS 'Ex', p.favorito AS 'Fav', p.fechaAdd as 'Agregado' " &
                          "FROM producto p " &
                          "LEFT JOIN producto_categoria c ON p.ID = c.ID_Producto " &
                          "LEFT JOIN categoria cat ON c.ID_Categoria = cat.ID " &
                          "LEFT JOIN producto_marca pm ON p.ID = pm.ID_Producto " &
                          "LEFT JOIN marca m ON m.ID = pm.ID_Marca " &
                          "LEFT JOIN producto_proveedor pp ON p.ID = pp.ID_Producto " &
                          "LEFT JOIN proveedor pr ON pp.ID_Proveedor = pr.ID " &
                          "LEFT JOIN producto_desc d ON p.ID = d.ID_Producto " &
                          "LEFT JOIN producto_precioVenta pv ON pv.ID_Producto = p.ID"

    Private searchTimer As Timer

    ' Método para inicializar el temporizador y otros componentes necesarios
    Private Sub InicializarComponentes()
        ' Inicializar el temporizador
        searchTimer = New Timer()
        searchTimer.Interval = 250
        ' Medio segundo
        AddHandler searchTimer.Tick, AddressOf OnSearchTimerTick
    End Sub

    Private Sub OnSearchTimerTick(sender As Object, e As EventArgs)
        ' Detener el temporizador y ejecutar la búsqueda
        searchTimer.Stop()
        REFRESCAR()
    End Sub

    Private Sub P_Productos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        InicializarComponentes()
        cargarPestaña()
    End Sub

    Friend Sub cargarPestaña()
        SWT_Cat.Checked = False
        SWT_Marca.Checked = False
        SWT_Prov.Checked = False
        TXT_BuscarMarca.Enabled = False
        TXT_BuscarCat.Enabled = False
        TXT_BuscarProv.Enabled = False
        REFRESCAR()
        TXT_BuscarProd.Select()
    End Sub

    Public Sub REFRESCAR()
        Task.Run(Sub()
                     Try
                         ' Se limpia todo en la tabla
                         T.Tables.Clear()

                         Dim condicionBusqueda = String.Empty

                         If Not String.IsNullOrEmpty(TXT_BuscarProd.Text) Then
                             condicionBusqueda = " WHERE (p.nombre LIKE '%" & TXT_BuscarProd.Text & "%' OR p.codigo LIKE '%" & TXT_BuscarProd.Text & "%') "
                         Else
                             condicionBusqueda = " WHERE 1=1 "
                         End If
                         ' Se verifica que el checkbox de buscar por categoría esté seleccionado
                         If SWT_Cat.Checked AndAlso Not String.IsNullOrEmpty(TXT_BuscarCat.Text) Then
                             condicionBusqueda += "AND cat.nombre LIKE '%" & TXT_BuscarCat.Text & "%' "
                         End If

                         ' Se verifica que el checkbox de buscar por marca esté seleccionado
                         If SWT_Marca.Checked AndAlso Not String.IsNullOrEmpty(TXT_BuscarMarca.Text) Then
                             condicionBusqueda += "AND m.nombre LIKE '%" & TXT_BuscarMarca.Text & "%' "
                         End If

                         ' Se verifica que el checkbox de buscar por proveedor esté seleccionado
                         If SWT_Prov.Checked AndAlso Not String.IsNullOrEmpty(TXT_BuscarProv.Text) Then
                             condicionBusqueda += "AND pr.nombre LIKE '%" & TXT_BuscarProv.Text & "%' "
                         End If

                         If SWT_Recientes.Checked Then
                             condicionBusqueda += "Order By p.fechaAdd DESC;"
                         Else
                             condicionBusqueda += "ORDER BY p.codigo ASC;"
                         End If

                         ' Construcción del query basado en si se busca por código o por nombre
                         SQL = stringConsultaBase & condicionBusqueda

                         ' Luego de cargar los datos, actualizar la interfaz de usuario de manera segura 
                         Invoke(Sub()
                                    MNU_ELIMINAR.Visible = False
                                    MNU_MODIFICAR.Visible = False
                                    ' Cargar los datos en la tabla
                                    Cargar_Tabla(T, SQL)
                                    If T.Tables.Count > 0 AndAlso T.Tables(0).Rows.Count > 0 Then
                                        Dim bin As New BindingSource
                                        bin.DataSource = T.Tables(0)
                                        DGV_Prods.DataSource = bin
                                        MNU_ELIMINAR.Visible = True
                                        MNU_MODIFICAR.Visible = True
                                    Else ' Limpiar la fuente de datos si no se cargaron datos
                                        DGV_Prods.DataSource = Nothing
                                    End If
                                    AddHandler DGV_Prods.Resize, AddressOf DGV_Prods_Resize
                                End Sub)
                     Catch ex As Exception
                         If DGV_Prods.IsHandleCreated Then
                             Invoke(Sub()
                                        If ex.Message <> "InvalidArgument=El valor de '0' no es válido para 'index'." & vbCrLf & "Nombre del parámetro: index" Then
                                            msgError("Error al cargar la lista de productos: " & ex.Message)
                                        End If
                                    End Sub)
                         End If
                     End Try
                 End Sub)
    End Sub


    Private Sub DGV_Prods_Resize(sender As Object, e As EventArgs) Handles DGV_Prods.Resize
        Dim totalColumnWidth As Integer = 0
        For Each column As DataGridViewColumn In DGV_Prods.Columns
            totalColumnWidth += column.Width
        Next

        If totalColumnWidth < DGV_Prods.Width Then
            DGV_Prods.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        Else
            DGV_Prods.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        End If
    End Sub

    ' Método para manejar el evento DataBindingComplete
    Private Sub DGV_Prods_DataBindingComplete(sender As Object, e As DataGridViewBindingCompleteEventArgs) Handles DGV_Prods.DataBindingComplete
        Try
            Dim selectedRowIndex As Integer = -1
            If DGV_Prods.SelectedRows.Count > 0 Then
                selectedRowIndex = DGV_Prods.SelectedRows(0).Index
            End If
            If selectedRowIndex >= 0 AndAlso selectedRowIndex < DGV_Prods.Rows.Count Then
                DGV_Prods.Rows(selectedRowIndex).Selected = True
                DGV_Prods.FirstDisplayedScrollingRowIndex = selectedRowIndex
            End If
            For i As Integer = 0 To DGV_Prods.Columns.Count - 1
                DGV_Prods.Columns(i).ReadOnly = True
                Select Case i
                    Case 1
                        DGV_Prods.Columns(i).Width = 100
                    Case 2
                        DGV_Prods.Columns(i).Width = 200
                    Case 3
                        DGV_Prods.Columns(i).Width = 350
                    Case 4
                        DGV_Prods.Columns(i).Width = 60
                    Case 6
                        DGV_Prods.Columns(i).Width = 30
                    Case 8
                        DGV_Prods.Columns(i).Width = 45
                    Case 10
                        DGV_Prods.Columns(i).Width = 70
                    Case 12
                        DGV_Prods.Columns(i).Width = 70
                    Case 14
                        DGV_Prods.Columns(i).Width = 70
                    Case 15
                        DGV_Prods.Columns(i).Width = 70
                    Case 16
                        DGV_Prods.Columns(i).Width = 30

                End Select
            Next
            DGV_Prods.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
            DGV_Prods.AutoResizeColumn(DataGridViewAutoSizeColumnMode.DisplayedCells)
            DGV_Prods.Columns(4).DefaultCellStyle.Format = "#,##"
            DGV_Prods.Columns(7).DefaultCellStyle.Format = "#,##"
            DGV_Prods.GridColor = Color.DarkGray
            DGV_Prods.Columns(0).Visible = False
            DGV_Prods.Columns(5).Visible = False
            DGV_Prods.Columns(6).Visible = False
            DGV_Prods.Columns(9).Visible = False
            DGV_Prods.Columns(11).Visible = False
            DGV_Prods.Columns(13).Visible = False
        Catch ex As Exception
            ' Manejar el error si alguna columna no existe
            Console.WriteLine("Error al ocultar las columnas: " & ex.Message)
        End Try
    End Sub

    Private Sub BTN_NProd_Click(sender As Object, e As EventArgs) Handles BTN_NProd.Click
        E_NuevoProducto.ModProd = False
        E_NuevoProducto.Show()
        E_NuevoProducto.Select()
    End Sub

    Private Sub BTN_RegresarProd_Click(sender As Object, e As EventArgs) Handles BTN_RegresarProd.Click
        M_Mantenimiento.Show()
        M_Mantenimiento.Select()
        Me.Close()
    End Sub

    Private Sub TXT_BuscarMarca_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles TXT_BuscarMarca.MouseDoubleClick
        B_Marca.Show()
        B_Marca.Select()
        B_Marca.caso = "Prod"
    End Sub

    Private Sub TXT_BuscarProv_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles TXT_BuscarProv.MouseDoubleClick
        B_Proveedor.Show()
        B_Proveedor.Select()
        B_Proveedor.caso = "Prod"
    End Sub

    Private Sub TXT_BuscarCat_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles TXT_BuscarCat.MouseDoubleClick
        B_Categoria.Show()
        B_Categoria.Select()
        B_Categoria.caso = "Prod"
    End Sub

    Private Sub MNU_MODIFICAR_Click(sender As Object, e As EventArgs) Handles MNU_MODIFICAR.Click
        Try
            E_NuevoProducto.ModProd = True
            E_NuevoProducto.idProd = DGV_Prods.SelectedRows(0).Cells(0).Value.ToString()
            E_NuevoProducto.TXT_Cod.Text = DGV_Prods.SelectedRows(0).Cells(1).Value.ToString()
            E_NuevoProducto.TXT_Nombre.Text = DGV_Prods.SelectedRows(0).Cells(2).Value.ToString()
            E_NuevoProducto.TXT_Desc.Text = DGV_Prods.SelectedRows(0).Cells(3).Value.ToString()
            E_NuevoProducto.TXT_PrecioBase.Text = DGV_Prods.SelectedRows(0).Cells(4).Value.ToString()
            E_NuevoProducto.TXT_Impuesto.Text = DGV_Prods.SelectedRows(0).Cells(5).Value.ToString()
            E_NuevoProducto.TXT_Ganancia.Text = DGV_Prods.SelectedRows(0).Cells(6).Value.ToString()
            If DGV_Prods.SelectedRows(0).Cells(8).Value.ToString() = "Si" Then
                E_NuevoProducto.SWT_Var.Checked = True
            Else
                E_NuevoProducto.SWT_Var.Checked = False
            End If
            E_NuevoProducto.TXT_PrecioVenta.Text = DGV_Prods.SelectedRows(0).Cells(7).Value.ToString()
            E_NuevoProducto.LBL_IDCat.Text = DGV_Prods.SelectedRows(0).Cells(9).Value.ToString()
            E_NuevoProducto.TXT_Categoria.Text = DGV_Prods.SelectedRows(0).Cells(10).Value.ToString()
            E_NuevoProducto.LBL_IDMarca.Text = DGV_Prods.SelectedRows(0).Cells(11).Value.ToString()
            E_NuevoProducto.TXT_Marca.Text = DGV_Prods.SelectedRows(0).Cells(12).Value.ToString()
            E_NuevoProducto.LBL_Prov.Text = DGV_Prods.SelectedRows(0).Cells(13).Value.ToString()
            E_NuevoProducto.TXT_Proveedor.Text = DGV_Prods.SelectedRows(0).Cells(14).Value.ToString()
            If DGV_Prods.SelectedRows(0).Cells(16).Value.ToString() = "Si" Then
                E_NuevoProducto.SWT_Fav.Checked = True
            Else
                E_NuevoProducto.SWT_Fav.Checked = False
            End If
            If Not String.IsNullOrEmpty(DGV_Prods.SelectedRows(0).Cells(15).Value.ToString()) Then
                E_NuevoProducto.NUD_Inv.Value = DGV_Prods.SelectedRows(0).Cells(15).Value.ToString()
            Else
                E_NuevoProducto.NUD_Inv.Value = 0
            End If
            E_NuevoProducto.ModProd = True
            E_NuevoProducto.CodigoPreMod = DGV_Prods.SelectedRows(0).Cells(1).Value.ToString()
            E_NuevoProducto.Show()

        Catch ex As Exception
            MsgBox("Error: " & ex.Message, vbCritical + vbOKOnly, "Error")
        End Try
    End Sub

    Private Sub MNU_ELIMINAR_Click(sender As Object, e As EventArgs) Handles MNU_ELIMINAR.Click
        T.Tables.Clear()
        T1.Tables.Clear()
        Try
            If DGV_Prods.SelectedRows.Count > 0 Then
                ' Se pregunta una confirmación para eliminar el tema
                If msgEliminar(" el producto: " & DGV_Prods.SelectedRows(0).Cells(2).Value.ToString() & "?") Then
                    Dim idEliminar As Integer = Convert.ToInt32(DGV_Prods.SelectedRows(0).Cells(0).Value.ToString())
                    ' Verificar si hay categorías asociadas
                    SQL = "SELECT COUNT(ID) FROM producto WHERE ID = " & idEliminar
                    Cargar_Tabla(T, SQL)

                    If T.Tables(0).Rows(0).Item(0) <> 0 Then
                        'Se elimina
                        ELIMINAR("producto_marca", "ID_Producto", idEliminar)
                        ELIMINAR("producto_categoria", "ID_Producto", idEliminar)
                        ELIMINAR("producto_proveedor", "ID_Producto", idEliminar)
                        ELIMINAR("producto_desc", "ID_Producto", idEliminar)
                        ELIMINAR("producto_precioVenta", "ID_Producto", idEliminar)
                        ELIMINAR("producto", "ID", idEliminar)
                        REFRESCAR()
                        msgDatoDel()
                    Else
                        msgError("El producto no existe")
                    End If
                End If
            Else
                msgError("Seleccione un producto para eliminar.")
            End If
        Catch ex As Exception
            msgError("Error al eliminar el producto: " & ex.Message)
        End Try
        TXT_BuscarProd.SelectAll()
    End Sub

    Private Sub TXT_BuscarProd_TextChanged(sender As Object, e As EventArgs) Handles TXT_BuscarProd.TextChanged
        If searchTimer IsNot Nothing Then
            ' Reiniciar el temporizador cada vez que se cambia el texto
            searchTimer.Stop()
            searchTimer.Start()
        End If
    End Sub

    Private Sub TXT_BuscarProv_TextChanged(sender As Object, e As EventArgs) Handles TXT_BuscarProv.TextChanged
        If searchTimer IsNot Nothing Then
            ' Reiniciar el temporizador cada vez que se cambia el texto
            searchTimer.Stop()
            searchTimer.Start()
        End If
    End Sub

    Private Sub TXT_BuscarMarca_TextChanged(sender As Object, e As EventArgs) Handles TXT_BuscarMarca.TextChanged
        If searchTimer IsNot Nothing Then
            ' Reiniciar el temporizador cada vez que se cambia el texto
            searchTimer.Stop()
            searchTimer.Start()
        End If
    End Sub

    Private Sub TXT_BuscarCat_TextChanged(sender As Object, e As EventArgs) Handles TXT_BuscarCat.TextChanged
        If searchTimer IsNot Nothing Then
            ' Reiniciar el temporizador cada vez que se cambia el texto
            searchTimer.Stop()
            searchTimer.Start()
        End If
    End Sub

    Private Sub BTN_Hablador_Click(sender As Object, e As EventArgs) Handles BTN_Hablador.Click
        P_Hablador.Show()
        P_Hablador.Select()
        Me.Close()
    End Sub

    Private Sub TXT_BuscarMarca_DoubleClick(sender As Object, e As EventArgs) Handles TXT_BuscarMarca.DoubleClick
        B_Marca.caso = "Prod"
        B_Marca.TXT_BuscarMarca.Text = TXT_BuscarMarca.Text
        B_Marca.Show()
    End Sub

    Private Sub TXT_BuscarProv_DoubleClick(sender As Object, e As EventArgs) Handles TXT_BuscarProv.DoubleClick
        B_Proveedor.caso = "Prod"
        B_Proveedor.TXT_BuscarProv.Text = TXT_BuscarProv.Text
        B_Proveedor.Show()
    End Sub

    Private Sub TXT_BuscarCat_DoubleClick(sender As Object, e As EventArgs) Handles TXT_BuscarCat.DoubleClick
        B_Categoria.caso = "Prod"
        B_Categoria.TXT_BuscarCat.Text = TXT_BuscarCat.Text
        B_Categoria.Show()
    End Sub

    Private Sub SWT_Cat_CheckedChanged(sender As Object, e As EventArgs) Handles SWT_Cat.CheckedChanged
        If SWT_Cat.Checked = False Then
            TXT_BuscarCat.Text = ""
            TXT_BuscarCat.Enabled = False
        Else
            TXT_BuscarCat.Enabled = True
            TXT_BuscarCat.Select()
        End If
    End Sub

    Private Sub SWT_Prov_CheckedChanged(sender As Object, e As EventArgs) Handles SWT_Prov.CheckedChanged
        If SWT_Prov.Checked = False Then
            TXT_BuscarProv.Text = ""
            TXT_BuscarProv.Enabled = False
        Else
            TXT_BuscarProv.Enabled = True
            TXT_BuscarProv.Select()
        End If
    End Sub

    Private Sub SWT_Marca_CheckedChanged(sender As Object, e As EventArgs) Handles SWT_Marca.CheckedChanged
        If SWT_Marca.Checked = False Then
            TXT_BuscarMarca.Text = ""
            TXT_BuscarMarca.Enabled = False
        Else
            TXT_BuscarMarca.Select()
            TXT_BuscarMarca.Enabled = True
        End If
    End Sub

    Private Sub SWT_Recientes_CheckedChanged(sender As Object, e As EventArgs) Handles SWT_Recientes.CheckedChanged
        If searchTimer IsNot Nothing Then
            ' Reiniciar el temporizador cada vez que se cambia el texto
            searchTimer.Stop()
            searchTimer.Start()
        End If
    End Sub

    Private Sub BTN_Config_Click(sender As Object, e As EventArgs) Handles BTN_Config.Click
        entrarConfig(1)
    End Sub
End Class