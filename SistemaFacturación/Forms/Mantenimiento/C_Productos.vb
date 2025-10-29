Imports System.Data.SQLite
Imports System.Text
Imports SistemaFacturaciónCommon.SistemaFacturacion.Forms.Busqueda
Imports SistemaFacturaciónCommon.SistemaFacturacion.Modules
Namespace SistemaFacturacion.Forms.Mantenimiento

    Public Class C_Productos
        Private stringConsultaBase As String = "SELECT p.ID AS 'ID', p.codigo AS 'Código', p.nombre AS 'Producto', d.descripcion AS 'Descripción', " &
                              "p.precio_base AS 'Costo', p.porc_impuesto AS 'Imp', p.ganancia AS '%', " &
                              "pv.precio_venta AS 'Venta', " &
                              "CASE WHEN p.variable=1 THEN 'Si' ELSE 'No' END AS 'Var', " &
                              "c.ID_Categoria AS 'ID_cat', cat.nombre AS 'Categoría', " &
                              "pm.ID_Marca AS 'ID_Marca', m.Nombre AS 'Marca', pp.ID_Proveedor AS 'ID_Prov', " &
                              "pr.nombre AS 'Proveedor', p.inventario AS 'Ex', p.fechaAdd as 'Agregado' " &
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
            searchTimer = New Timer With {
                .Interval = 250
            }
            ' Medio segundo
            AddHandler searchTimer.Tick, AddressOf OnSearchTimerTick
        End Sub

        Private Sub Restartimer()
            If searchTimer IsNot Nothing Then
                ' Reiniciar el temporizador cada vez que se cambia el texto
                searchTimer.Stop()
                searchTimer.Start()
            End If
        End Sub

        Private Sub OnSearchTimerTick(sender As Object, e As EventArgs)
            ' Detener el temporizador y ejecutar la búsqueda
            searchTimer.Stop()
            REFRESCAR()
        End Sub

        Private Sub C_Productos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
            InicializarComponentes()
            cargarPestaña()
        End Sub

        Friend Sub CargarPestaña()
            SWT_Cat.Checked = False
            SWT_Marca.Checked = False
            SWT_Prov.Checked = False
            TXT_BuscarMarca.Enabled = False
            TXT_BuscarCat.Enabled = False
            TXT_BuscarProv.Enabled = False
            TXT_BuscarProd.Select()
        End Sub

        Public Async Sub REFRESCAR()
            Try
                Dim resultados As DataTable = Await Task.Run(Function()
                                                                 Dim T As New DataSet()
                                                                 ' La consulta base ahora es la que me proporcionaste
                                                                 Dim paramList As New List(Of SQLiteParameter)()
                                                                 Dim condiciones As New StringBuilder(" WHERE 1=1 ")

                                                                 ' Filtro principal por nombre o código
                                                                 If Not String.IsNullOrEmpty(TXT_BuscarProd.Text) Then
                                                                     condiciones.Append(" AND (p.nombre LIKE @producto OR p.codigo LIKE @producto) ")
                                                                     paramList.Add(New SQLiteParameter("@producto", "%" & TXT_BuscarProd.Text & "%"))
                                                                 End If

                                                                 ' Filtro por categoría
                                                                 If SWT_Cat.Checked AndAlso Not String.IsNullOrEmpty(TXT_BuscarCat.Text) Then
                                                                     condiciones.Append(" AND cat.nombre LIKE @categoria ")
                                                                     paramList.Add(New SQLiteParameter("@categoria", "%" & TXT_BuscarCat.Text & "%"))
                                                                 End If

                                                                 ' Filtro por marca
                                                                 If SWT_Marca.Checked AndAlso Not String.IsNullOrEmpty(TXT_BuscarMarca.Text) Then
                                                                     condiciones.Append(" AND m.nombre LIKE @marca ")
                                                                     paramList.Add(New SQLiteParameter("@marca", "%" & TXT_BuscarMarca.Text & "%"))
                                                                 End If

                                                                 ' Filtro por proveedor
                                                                 If SWT_Prov.Checked AndAlso Not String.IsNullOrEmpty(TXT_BuscarProv.Text) Then
                                                                     condiciones.Append(" AND pr.nombre LIKE @proveedor ")
                                                                     paramList.Add(New SQLiteParameter("@proveedor", "%" & TXT_BuscarProv.Text & "%"))
                                                                 End If

                                                                 Dim orden As String = If(SWT_Recientes.Checked, " ORDER BY p.fechaAdd DESC", " ORDER BY p.codigo ASC")

                                                                 Dim limit As String = ""
                                                                 If RDB_100.Checked Then
                                                                     limit = " LIMIT 100;"
                                                                 ElseIf RDB_200.Checked Then
                                                                     limit = " LIMIT 200;"
                                                                 ElseIf RDB_500.Checked Then
                                                                     limit = " LIMIT 500;"
                                                                 End If

                                                                 Dim consultaFinal As String = stringConsultaBase.ToString() & condiciones.ToString() & orden & limit

                                                                 ' Llamada al método para cargar la tabla de forma segura
                                                                 CargarTablaParam(T, consultaFinal, paramList)

                                                                 If T.Tables.Count > 0 Then
                                                                     Return T.Tables(0)
                                                                 Else
                                                                     Return Nothing
                                                                 End If
                                                             End Function)

                ' Actualización de la UI en el hilo principal
                DGV_Prods.DataSource = Nothing
                MNU_ELIMINAR.Visible = False
                MNU_MODIFICAR.Visible = False

                If resultados IsNot Nothing AndAlso resultados.Rows.Count > 0 Then
                    DGV_Prods.DataSource = New BindingSource With {.DataSource = resultados}
                    MNU_ELIMINAR.Visible = True
                    MNU_MODIFICAR.Visible = True
                End If

            Catch ex As Exception
                If Me.IsHandleCreated Then
                    msgError("Error al cargar la lista de productos: " & ex.Message)
                End If
            End Try
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

                    ' Configurar inicialmente todas las columnas en modo None
                    DGV_Prods.Columns(i).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells

                    ' Configurar visibilidad y saltar si está oculta
                    Select Case i
                        Case 0, 5, 6, 9, 11, 13
                            DGV_Prods.Columns(i).Visible = False
                            Continue For
                    End Select

                    Select Case i
                        Case 1
                            DGV_Prods.Columns(i).Width = 100
                        Case 2
                            DGV_Prods.Columns(i).Width = 200
                        Case 3 ' Columna de la Descripción (la que se adapta)
                            ' Usamos Fill para que rellene el espacio disponible
                            DGV_Prods.Columns(i).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
                            'Establecemos un ANCHO MÍNIMO para que se ajuste al contenido si hay poco espacio
                            DGV_Prods.Columns(i).MinimumWidth = DGV_Prods.Columns(i).GetPreferredWidth(DataGridViewAutoSizeColumnMode.DisplayedCells, True)
                        Case 4
                            DGV_Prods.Columns(i).Width = 60
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
                    End Select
                Next

                DGV_Prods.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
                DGV_Prods.Columns(4).DefaultCellStyle.Format = "#,##"
                DGV_Prods.Columns(7).DefaultCellStyle.Format = "#,##"
                DGV_Prods.GridColor = Color.DarkGray

            Catch ex As Exception
                Console.WriteLine("Error al configurar las columnas: " & ex.Message)
            End Try
        End Sub

        Private Sub DGV_Prods_SizeChanged(sender As Object, e As EventArgs) Handles DGV_Prods.SizeChanged
            Try
                ' 1. Verificar si la columna 3 existe y es visible.
                If DGV_Prods.Columns.Count > 3 AndAlso DGV_Prods.Columns(3).Visible Then

                    Dim ColumnaDescripcion As DataGridViewColumn = DGV_Prods.Columns(3)
                    Const MAX_ANCHO As Integer = 400

                    ' 2. Aplicar el límite de 400px
                    ' Si el ancho calculado automáticamente por el modo Fill supera el máximo, lo forzamos.
                    If ColumnaDescripcion.Width > MAX_ANCHO Then
                        ColumnaDescripcion.Width = MAX_ANCHO
                    End If

                    ' 3. Reajustar las celdas para que se adapte el contenido si el ancho fue limitado.
                    DGV_Prods.AutoResizeColumn(3, DataGridViewAutoSizeColumnMode.DisplayedCells)
                End If
            Catch ex As Exception
                Console.WriteLine("Error al limitar el ancho de la columna: " & ex.Message)
            End Try
        End Sub

        Private Sub BTN_NProd_Click(sender As Object, e As EventArgs) Handles BTN_NProd.Click
            Dim frmNewProd As New E_NuevoProducto With {
                .ModProd = False
            }
            frmNewProd.ShowDialog()

            TXT_BuscarProd.SelectAll()
            TXT_BuscarProd.Focus()
        End Sub

        Private Sub BTN_RegresarProd_Click(sender As Object, e As EventArgs) Handles BTN_RegresarProd.Click
            Dim mantMenu As New M_MantenimientoMenu
            mantMenu.Show()
            mantMenu.Select()
            isNavigating = True
            Me.Close()
        End Sub

        Private Sub MNU_MODIFICAR_Click(sender As Object, e As EventArgs) Handles MNU_MODIFICAR.Click
            Try
                Dim frmNewProd As New E_NuevoProducto With {
                    .ModProd = True,
                    .idProd = DGV_Prods.SelectedRows(0).Cells(0).Value.ToString(),
                    .CodigoPreMod = DGV_Prods.SelectedRows(0).Cells(1).Value.ToString(),
                    .Owner = Me
                }
                frmNewProd.TXT_Cod.Text = DGV_Prods.SelectedRows(0).Cells(1).Value.ToString()
                frmNewProd.TXT_Nombre.Text = DGV_Prods.SelectedRows(0).Cells(2).Value.ToString()
                frmNewProd.TXT_Desc.Text = DGV_Prods.SelectedRows(0).Cells(3).Value.ToString()
                frmNewProd.TXT_PrecioBase.Text = DGV_Prods.SelectedRows(0).Cells(4).Value.ToString()
                frmNewProd.TXT_Impuesto.Text = DGV_Prods.SelectedRows(0).Cells(5).Value.ToString()
                frmNewProd.TXT_Ganancia.Text = DGV_Prods.SelectedRows(0).Cells(6).Value.ToString()
                frmNewProd.SWT_Var.Checked = DGV_Prods.SelectedRows(0).Cells(8).Value.ToString() = "Si"
                frmNewProd.TXT_PrecioVenta.Text = DGV_Prods.SelectedRows(0).Cells(7).Value.ToString()
                frmNewProd.LBL_IDCat.Text = DGV_Prods.SelectedRows(0).Cells(9).Value.ToString()
                frmNewProd.TXT_Categoria.Text = DGV_Prods.SelectedRows(0).Cells(10).Value.ToString()
                frmNewProd.LBL_IDMarca.Text = DGV_Prods.SelectedRows(0).Cells(11).Value.ToString()
                frmNewProd.TXT_Marca.Text = DGV_Prods.SelectedRows(0).Cells(12).Value.ToString()
                frmNewProd.LBL_Prov.Text = DGV_Prods.SelectedRows(0).Cells(13).Value.ToString()
                frmNewProd.TXT_Proveedor.Text = DGV_Prods.SelectedRows(0).Cells(14).Value.ToString()
                ' Manejo del valor de inventario nulo o vacío
                Dim inventario As Integer = Convert.ToInt32(DGV_Prods.SelectedRows(0).Cells(15).Value)
                frmNewProd.NUD_Inv.Value = If(String.IsNullOrEmpty(inventario), 0, inventario)

                frmNewProd.ShowDialog()

                TXT_BuscarProd.SelectAll()
                TXT_BuscarProd.Focus()
            Catch ex As Exception
                MsgError("Error: " & ex.Message)
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
            Restartimer()
        End Sub

        Private Sub TXT_BuscarProv_TextChanged(sender As Object, e As EventArgs) Handles TXT_BuscarProv.TextChanged
            Restartimer()
        End Sub

        Private Sub TXT_BuscarMarca_TextChanged(sender As Object, e As EventArgs) Handles TXT_BuscarMarca.TextChanged
            Restartimer()
        End Sub

        Private Sub TXT_BuscarCat_TextChanged(sender As Object, e As EventArgs) Handles TXT_BuscarCat.TextChanged
            Restartimer()
        End Sub

        Private Sub BTN_Hablador_Click(sender As Object, e As EventArgs) Handles BTN_Hablador.Click
            Dim frmHablador As New P_Hablador
            frmHablador.Show()
            frmHablador.Select()
            isNavigating = True
            Me.Close()
        End Sub

        Private Sub TXT_BuscarMarca_DoubleClick(sender As Object, e As EventArgs) Handles TXT_BuscarMarca.DoubleClick
            Dim frmSearchMarca As New B_Marca With {.Owner = Me}
            frmSearchMarca.ShowDialog()
            REFRESCAR()
        End Sub

        Private Sub TXT_BuscarProv_DoubleClick(sender As Object, e As EventArgs) Handles TXT_BuscarProv.DoubleClick
            Dim frmSearchProv As New B_Proveedor With {.Owner = Me}
            frmSearchProv.ShowDialog()
            REFRESCAR()
        End Sub

        Private Sub TXT_BuscarCat_DoubleClick(sender As Object, e As EventArgs) Handles TXT_BuscarCat.DoubleClick
            Dim frmSearchCategoria As New B_Categoria With {.Owner = Me}
            frmSearchCategoria.ShowDialog()
            REFRESCAR()
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
            Restartimer()
        End Sub

        Private Sub BTN_Config_Click(sender As Object, e As EventArgs) Handles BTN_Config.Click
            entrarConfig(2, Me)
        End Sub

        Private Sub C_Productos_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
            REFRESCAR()
        End Sub

        Private Sub C_Productos_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
            ManejarCierreONavegacion(e)
        End Sub

        Private Sub RDB_100_CheckedChanged(sender As Object, e As EventArgs) Handles RDB_100.CheckedChanged
            REFRESCAR()
        End Sub

        Private Sub RDB_200_CheckedChanged(sender As Object, e As EventArgs) Handles RDB_200.CheckedChanged
            REFRESCAR()
        End Sub

        Private Sub RDB_500_CheckedChanged(sender As Object, e As EventArgs) Handles RDB_500.CheckedChanged
            REFRESCAR()
        End Sub

        Private Sub RDB_All_CheckedChanged(sender As Object, e As EventArgs) Handles RDB_All.CheckedChanged
            REFRESCAR()
        End Sub
    End Class
End Namespace