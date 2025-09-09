Imports System.Configuration
Imports System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder
Imports System.Data.SQLite
Imports SistemaFacturaciónCommon.MSG
Imports Syncfusion.Windows.Forms
Imports Syncfusion.Windows.Forms.Tools

Public Class P_ConfigFavProd
    Private searchTimer As Timer
    Private isDragging As Boolean = False
    Private draggedRowImage As Bitmap

    Private Sub P_ConfigFavProd_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        InicializarComponentes()
        CargarProdFav()
        REFRESCAR()
    End Sub


    ' Método para inicializar el temporizador y otros componentes necesarios
    Private Sub InicializarComponentes()
        ' Inicializar el temporizador
        searchTimer = New Timer With {
            .Interval = 100
        }
        ' Medio segundo
        AddHandler searchTimer.Tick, AddressOf OnSearchTimerTick
    End Sub

    Private Sub OnSearchTimerTick(sender As Object, e As EventArgs)
        ' Detener el temporizador y ejecutar la búsqueda
        searchTimer.Stop()
        REFRESCAR()
    End Sub

    Private Sub CargarProdFav()
        DGV_FavProd.Rows.Clear()
        T.Tables.Clear()
        SQL = "SELECT pf.ID_Producto as 'ID', p.codigo as 'Código', p.nombre as 'Nombre', pf.BTN_Color as 'color'" &
     " FROM producto_favorito pf" &
     " JOIN producto p ON pf.ID_Producto = p.ID" &
     " ORDER BY pf.Posicion ASC;"
        Cargar_Tabla(T, SQL)
        ' Verifica si la tabla tiene datos
        If T.Tables.Count > 0 AndAlso T.Tables(0).Rows.Count > 0 Then
            ' Recorre cada fila del DataTable 'T' y la agrega al DataGridView
            For Each row As DataRow In T.Tables(0).Rows
                ' Agrega una nueva fila al DataGridView
                Dim newRowIndex As Integer = DGV_FavProd.Rows.Add(row("ID"), row("Código"), row("Nombre"), row("color"))

                ' Obtiene la referencia a la nueva fila
                Dim newRow As DataGridViewRow = DGV_FavProd.Rows(newRowIndex)

                ' Aplica el color a la celda
                If newRow.Cells("colorProd").Value IsNot Nothing Then ' Cambio de "colorProd" a "color"
                    Dim colorValue As Integer = Convert.ToInt32(newRow.Cells("colorProd").Value) ' Cambio de "colorProd" a "color"
                    Dim cellColor As Color = Color.FromArgb(colorValue)

                    newRow.Cells("colorProd").Style.BackColor = cellColor ' Cambio de "colorProd" a "color"
                    newRow.Cells("colorProd").Style.ForeColor = cellColor ' Corrección aquí, el color de la fuente debe ser legible, no el mismo que el fondo
                    newRow.Cells("colorProd").Style.SelectionBackColor = cellColor ' Cambio de "colorProd" a "color"
                    newRow.Cells("colorProd").Style.SelectionForeColor = cellColor ' Corrección aquí
                End If
            Next
        End If
    End Sub

    Private Sub BTN_CerrarApp_Click(sender As Object, e As EventArgs)
        msgCerrarApp()
    End Sub

    Private Sub BTN_RegresarConfig_Click(sender As Object, e As EventArgs) Handles BTN_RegresarConfig.Click
        P_Caja.LoadBtnFav()
        Me.Close()
    End Sub

    Public Sub REFRESCAR()
        Task.Run(Sub()
                     Try
                         T.Tables.Clear()
                         SQL = "SELECT p.ID, p.codigo as 'Código', p.nombre as 'Nombre', v.precio_venta as 'Precio'" &
                                 " FROM producto p LEFT JOIN producto_precioVenta v ON p.ID = v.ID_Producto" +
                                 " where p.codigo LIKE '%" & TXT_BuscarProd.Text & "%' OR p.nombre LIKE '%" & TXT_BuscarProd.Text & "%' ORDER BY p.codigo ASC;"
                         Invoke(Sub()
                                    Cargar_Tabla(T, SQL)
                                    If T.Tables.Count > 0 AndAlso T.Tables(0).Rows.Count > 0 Then
                                        Dim bin As New BindingSource With {
                                            .DataSource = T.Tables(0)
                                        }
                                        DGV_BProd.DataSource = bin
                                        DGV_BProd.Columns(0).Visible = False
                                    Else ' Limpiar la fuente de datos si no se cargaron datos
                                        DGV_BProd.DataSource = Nothing
                                    End If
                                    TXT_BuscarProd.Select()
                                End Sub)
                     Catch ex As Exception
                         Invoke(Sub()
                                    If DGV_BProd.IsHandleCreated Then
                                        If ex.Message <> "InvalidArgument=El valor de '0' no es válido para 'index'." & vbCrLf & "Nombre del parámetro: index" Then
                                            ' Mostrar un mensaje de error genérico
                                            msgError("Error al cargar la lista de clientes: " & ex.Message)
                                        End If
                                    End If
                                End Sub)
                     End Try
                 End Sub)
    End Sub

    Private Sub TXT_BuscarProd_TextChanged(sender As Object, e As EventArgs) Handles TXT_BuscarProd.TextChanged
        If searchTimer IsNot Nothing Then
            searchTimer.Stop()
            searchTimer.Start()
        End If
    End Sub

    Private Sub MNU_SELECCIONAR_Click(sender As Object, e As EventArgs) Handles MNU_SELECCIONAR.Click
        'REvisa si hay un producto con el ID ya agregado en la lista de favoritos
        For Each row As DataGridViewRow In DGV_FavProd.Rows
            If row.Cells(0).Value IsNot Nothing AndAlso DGV_BProd.SelectedRows(0).Cells(0).Value IsNot Nothing Then
                If row.Cells(0).Value.ToString() = DGV_BProd.SelectedRows(0).Cells(0).Value.ToString() Then
                    msgError("El producto ya está en la lista de favoritos.")
                    Return
                End If
            End If
        Next

        Dim id As Integer = Convert.ToInt32(DGV_BProd.SelectedRows(0).Cells(0).Value)
        Dim codigo As String = DGV_BProd.SelectedRows(0).Cells(1).Value.ToString()
        Dim nombre As String = DGV_BProd.SelectedRows(0).Cells(2).Value.ToString()

        ' Agrega la nueva fila y guarda la referencia
        Dim nuevaFilaIndex As Integer = DGV_FavProd.Rows.Add(id, codigo, nombre)
        Dim nuevaFila As DataGridViewRow = DGV_FavProd.Rows(nuevaFilaIndex)
        Dim celdaColor = nuevaFila.Cells(3)
        'Color naranja
        Dim r = 255
        Dim g = 128
        Dim b = 0
        'Se establece este color a la celda
        celdaColor.Style.BackColor = Color.FromArgb(r, g, b)
        celdaColor.Style.ForeColor = Color.FromArgb(r, g, b)
        celdaColor.Style.SelectionBackColor = Color.FromArgb(r, g, b)
        celdaColor.Style.SelectionForeColor = Color.FromArgb(r, g, b)

    End Sub
    Private Sub DGV_Hablador_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGV_FavProd.CellClick
        ' Verifica que el clic sea en la columna de color y no en el encabezado
        If e.ColumnIndex = 3 AndAlso e.RowIndex >= 0 Then
            ' Obtiene la celda actual
            Dim cell As DataGridViewCell = DGV_FavProd.Rows(e.RowIndex).Cells(e.ColumnIndex)

            ' Crea y muestra el diálogo de color
            Using colorDialog As New ColorDialog()
                ' Si la celda ya tiene un color, lo establece como el predeterminado del diálogo
                If cell.Style.BackColor <> Color.Empty Then
                    colorDialog.Color = cell.Style.BackColor
                Else
                    colorDialog.Color = Color.White ' Color por defecto si no hay uno
                End If

                ' Muestra el diálogo y si el usuario selecciona un color
                If colorDialog.ShowDialog() = DialogResult.OK Then
                    ' Crea una copia del estilo para no modificar el estilo por defecto de la columna
                    ' Asigna el color seleccionado
                    Dim newCellStyle As New DataGridViewCellStyle(cell.Style) With {
                        .BackColor = colorDialog.Color,
                        .ForeColor = colorDialog.Color,
                        .SelectionBackColor = colorDialog.Color,
                        .SelectionForeColor = colorDialog.Color
                    }

                    ' Aplica el nuevo estilo a la celda
                    cell.Style = newCellStyle
                End If
            End Using
        End If
    End Sub

    Private Sub MNU_ELIMINAR_Click(sender As Object, e As EventArgs) Handles MNU_ELIMINAR.Click
        DGV_FavProd.Rows.RemoveAt(DGV_FavProd.SelectedRows(0).Index)
    End Sub

    Private Sub BTN_MoveUp_Click(sender As Object, e As EventArgs) Handles BTN_MoveUp.Click
        ' Asegurarse de que hay una fila seleccionada y no es la primera fila
        If DGV_FavProd.SelectedRows.Count > 0 AndAlso DGV_FavProd.SelectedRows(0).Index > 0 Then
            Dim selectedRow As DataGridViewRow = DGV_FavProd.SelectedRows(0)
            Dim oldIndex As Integer = selectedRow.Index
            Dim newIndex As Integer = oldIndex - 1

            ' Remover e insertar la fila en la nueva posición
            DGV_FavProd.Rows.RemoveAt(oldIndex)
            DGV_FavProd.Rows.Insert(newIndex, selectedRow)

            ' Mantener la fila seleccionada después del movimiento
            selectedRow.Selected = True
        End If
    End Sub

    Private Sub BTN_MoveDown_Click(sender As Object, e As EventArgs) Handles BTN_MoveDown.Click
        ' Asegurarse de que hay una fila seleccionada y no es la última fila
        If DGV_FavProd.SelectedRows.Count > 0 AndAlso DGV_FavProd.SelectedRows(0).Index < DGV_FavProd.Rows.Count - 1 Then
            Dim selectedRow As DataGridViewRow = DGV_FavProd.SelectedRows(0)
            Dim oldIndex As Integer = selectedRow.Index
            Dim newIndex As Integer = oldIndex + 1

            ' Remover e insertar la fila en la nueva posición
            DGV_FavProd.Rows.RemoveAt(oldIndex)
            DGV_FavProd.Rows.Insert(newIndex, selectedRow)

            ' Mantener la fila seleccionada después del movimiento
            selectedRow.Selected = True
        End If
    End Sub

    Private Sub BTN_Actualizar_Click(sender As Object, e As EventArgs) Handles BTN_Actualizar.Click
        Dim cmd As New SQLiteCommand()
        ' Usa tu clase de conexión a la base de datos
        Dim conn As New SQLiteConnection(ConfigurationManager.ConnectionStrings("conexionString").ConnectionString)
        Dim transaction As SQLiteTransaction

        Try
            conn.Open()
            transaction = conn.BeginTransaction()
            cmd.Transaction = transaction

            ' 1. Elimina todos los registros de la tabla de favoritos
            cmd.CommandText = "DELETE FROM producto_favorito;"
            cmd.ExecuteNonQuery()

            ' 2. Recorre el DataGridView e inserta cada fila
            For i As Integer = 0 To DGV_FavProd.Rows.Count - 1
                Dim idProducto As Integer = Convert.ToInt32(DGV_FavProd.Rows(i).Cells("ID").Value)
                Dim colorValue As Integer = DGV_FavProd.Rows(i).Cells("colorProd").Style.BackColor.ToArgb()

                cmd.CommandText = "INSERT INTO producto_favorito (ID_Producto, Posicion, BTN_Color) VALUES (@id, @posicion, @color);"
                cmd.Parameters.Clear()
                cmd.Parameters.AddWithValue("@id", idProducto)
                cmd.Parameters.AddWithValue("@posicion", i + 1)
                cmd.Parameters.AddWithValue("@color", colorValue)

                cmd.ExecuteNonQuery()
            Next

            transaction.Commit()
            MSG.mensaje("Se ha guardado el nuevo orden de productos favoritos.", vbOKOnly, "Favoritos guardados")

        Catch ex As Exception
            ' 4. Revierte la transacción si hubo un error
            transaction?.Rollback() ' Llama a Rollback sobre la variable de la transacción
            msgError("Error al guardar el nuevo orden: " & ex.Message)
        Finally
            If conn.State = ConnectionState.Open Then
                conn.Close()
            End If
            P_Caja.LoadBtnFav()
        End Try
    End Sub
End Class