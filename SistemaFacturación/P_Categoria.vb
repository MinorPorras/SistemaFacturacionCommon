Imports System.Threading.Tasks

Public Class P_Categoria
    Private searchTimer As Timer

    ' Método para inicializar el temporizador y otros componentes necesarios
    Private Sub InicializarComponentes()
        ' Inicializar el temporizador
        searchTimer = New Timer()
        searchTimer.Interval = 100
        ' Medio segundo
        AddHandler searchTimer.Tick, AddressOf OnSearchTimerTick
    End Sub

    Private Sub OnSearchTimerTick(sender As Object, e As EventArgs)
        ' Detener el temporizador y ejecutar la búsqueda
        searchTimer.Stop()
        REFRESCAR()
    End Sub

    Private Sub BTN_RegresarCat_Click(sender As Object, e As EventArgs) Handles BTN_RegresarCat.Click
        M_Mantenimiento.Show()
        M_Mantenimiento.Select()
        Me.Close()
    End Sub

    Private Sub P_Categoria_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        InicializarComponentes()
        REFRESCAR()
    End Sub

    Public Sub REFRESCAR()
        Task.Run(Sub()
                     Try
                         T.Tables.Clear()
                         Dim busqueda As String = TXT_BuscarCat.Text.Trim()
                         Dim condicionBusqueda As String
                         If busqueda = "" Then
                             condicionBusqueda = "1=1" ' Esto siempre será verdadero, mostrando todos los registros
                         Else
                             condicionBusqueda = $"(codigo LIKE '%{busqueda}%' OR nombre LIKE '%{busqueda}%')"
                         End If
                         SQL = "SELECT ID, codigo AS 'Código', nombre AS 'Nombre', color AS 'Color' " &
                                  "FROM categoria " &
                                  "WHERE " & condicionBusqueda &
                                  " ORDER BY codigo ASC;"
                         Invoke(Sub()
                                    MNU_ELIMINAR.Visible = False
                                    MNU_MODIFICAR.Visible = False
                                    Cargar_Tabla(T, SQL)
                                    If T.Tables.Count > 0 AndAlso T.Tables(0).Rows.Count > 0 Then
                                        DGV_Categoria.Columns.Clear()
                                        Dim bin As New BindingSource
                                        bin.DataSource = T.Tables(0)
                                        DGV_Categoria.DataSource = bin
                                        MNU_ELIMINAR.Visible = True
                                        MNU_MODIFICAR.Visible = True
                                    Else ' Limpiar la fuente de datos si no se cargaron datos
                                        DGV_Categoria.DataSource = Nothing
                                    End If
                                    TXT_BuscarCat.Select()
                                End Sub)
                     Catch ex As Exception
                         Invoke(Sub()
                                    If DGV_Categoria.IsHandleCreated Then
                                        If ex.Message <> "InvalidArgument=El valor de '0' no es válido para 'index'." & vbCrLf & "Nombre del parámetro: index" Then
                                            ' Mostrar un mensaje de error genérico
                                            msgError("Error al cargar la lista de categorías: " & ex.Message)
                                        End If
                                    End If
                                End Sub)

                     End Try
                 End Sub)
    End Sub


    Private Sub DGV_Categoria_DataBindingComplete(sender As Object, e As DataGridViewBindingCompleteEventArgs) Handles DGV_Categoria.DataBindingComplete
        Try
            Dim selectedRowIndex As Integer = -1
            If DGV_Categoria.SelectedRows.Count > 0 Then
                selectedRowIndex = DGV_Categoria.SelectedRows(0).Index
            End If
            For i As Integer = 0 To DGV_Categoria.Columns.Count - 1
                DGV_Categoria.Columns(i).ReadOnly = True
                Select Case i
                    Case 1
                        DGV_Categoria.Columns(i).Width = 50
                    Case 2
                        DGV_Categoria.Columns(i).Width = 200
                    Case 3
                        DGV_Categoria.Columns(i).Width = 70
                End Select
            Next
            For i As Integer = 0 To DGV_Categoria.Rows.Count - 1
                If DGV_Categoria.Rows(i).Cells(3).Value IsNot Nothing Then
                    Dim col As String() = DGV_Categoria.Rows(i).Cells(3).Value.ToString().Split(","c)
                    ' Convertir los valores RGB a enteros
                    Dim r As Integer = Convert.ToInt32(col(0).Trim())
                    Dim g As Integer = Convert.ToInt32(col(1).Trim())
                    Dim b As Integer = Convert.ToInt32(col(2).Trim())

                    DGV_Categoria.Rows(i).Cells(3).Style.BackColor = Color.FromArgb(r, g, b)
                    DGV_Categoria.Rows(i).Cells(3).Style.ForeColor = Color.FromArgb(r, g, b)
                    DGV_Categoria.Rows(i).Cells(3).Style.SelectionBackColor = Color.FromArgb(r, g, b)
                    DGV_Categoria.Rows(i).Cells(3).Style.SelectionForeColor = Color.FromArgb(r, g, b)
                End If
            Next
            DGV_Categoria.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
            DGV_Categoria.GridColor = Color.DarkGray
            DGV_Categoria.Columns(0).Visible = False
            ' Restaurar la selección
            If selectedRowIndex >= 0 AndAlso selectedRowIndex < DGV_Categoria.Rows.Count Then
                DGV_Categoria.Rows(selectedRowIndex).Selected = True
                DGV_Categoria.FirstDisplayedScrollingRowIndex = selectedRowIndex
            End If
        Catch ex As Exception
            ' Manejar el error si alguna columna no existe
            Console.WriteLine("Error al ocultar las columnas: " & ex.Message)
        End Try
    End Sub

    Private Sub TXT_BuscarCat_TextChanged(sender As Object, e As EventArgs) Handles TXT_BuscarCat.TextChanged
        If searchTimer IsNot Nothing Then
            searchTimer.Stop()
            searchTimer.Start()
        End If
    End Sub

    Private Sub BTN_NCat_Click(sender As Object, e As EventArgs) Handles BTN_NCat.Click
        E_NuevaCategoria.ModCat = False
        E_NuevaCategoria.Show()
        E_NuevaCategoria.Select()
    End Sub

    Private Sub MNU_MODIFICAR_Click(sender As Object, e As EventArgs) Handles MNU_MODIFICAR.Click
        E_NuevaCategoria.ModCat = True
        Try
            E_NuevaCategoria.CodigoPreMod = DGV_Categoria.SelectedRows(0).Cells(1).Value.ToString()
            E_NuevaCategoria.idCat = DGV_Categoria.SelectedRows(0).Cells(0).Value.ToString()
            E_NuevaCategoria.TXT_CodCat.Text = DGV_Categoria.SelectedRows(0).Cells(1).Value.ToString()
            E_NuevaCategoria.TXT_NombreCat.Text = DGV_Categoria.SelectedRows(0).Cells(2).Value.ToString()
            Dim rgbValues() = DGV_Categoria.SelectedRows(0).Cells(3).Value.ToString().Split(",")
            Dim red As Integer = Convert.ToInt32(rgbValues(0))
            Dim green As Integer = Convert.ToInt32(rgbValues(1))
            Dim blue As Integer = Convert.ToInt32(rgbValues(2))
            E_NuevaCategoria.BTN_Color.FillColor = Color.FromArgb(red, green, blue)
            E_NuevaCategoria.ColorDialog1.Color = Color.FromArgb(red, green, blue)
            E_NuevaCategoria.ColorCat = DGV_Categoria.SelectedRows(0).Cells(3).Value.ToString()
            E_NuevaCategoria.ModCat = True
            E_NuevaCategoria.Show()
        Catch ex As Exception
            msgError("Error: " & ex.Message)
            E_NuevaCategoria.Show()
        End Try

    End Sub

    Private Sub MNU_ELIMINAR_Click(sender As Object, e As EventArgs) Handles MNU_ELIMINAR.Click

        T.Tables.Clear()
        T1.Tables.Clear()
        Try
            If DGV_Categoria.SelectedRows.Count > 0 Then
                ' Se pregunta una confirmación para eliminar el tema
                If msgEliminar(" la categoria: " & DGV_Categoria.SelectedRows(0).Cells(2).Value.ToString() & "?") Then
                    Dim idEliminar As Integer = Convert.ToInt32(DGV_Categoria.SelectedRows(0).Cells(0).Value.ToString())
                    ' Verificar si hay categorías asociadas
                    SQL = "SELECT COUNT(ID) FROM categoria WHERE ID = " & idEliminar
                    Cargar_Tabla(T, SQL)
                    If T.Tables(0).Rows(0).Item(0) <> 0 Then
                        'Se elimina
                        ELIMINAR("categoria", "ID", idEliminar)
                        msgDatoDel()
                        REFRESCAR()
                    Else
                        msgError("La categoria no existe")
                    End If
                End If
            Else
                msgError("Seleccione una categoria para eliminar.")
            End If
        Catch ex As Exception
            msgError("Error al eliminar la categoria: " & ex.Message)
        End Try
        TXT_BuscarCat.SelectAll()
    End Sub

    Private Sub BTN_CerrarApp_Click(sender As Object, e As EventArgs) Handles BTN_CerrarApp.Click
        msgCerrarApp()
    End Sub

    Private Sub BTN_Config_Click(sender As Object, e As EventArgs) Handles BTN_Config.Click
        entrarConfig(1)
    End Sub
End Class