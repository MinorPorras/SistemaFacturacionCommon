Imports System.Net.Mime.MediaTypeNames
Imports System.Threading.Tasks


Public Class B_Categoria
    Friend caso As String
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
    Public Sub REFRESCAR()
        Task.Run(Sub()
                     Try
                         T.Tables.Clear()
                         Dim busqueda As String = TXT_BuscarCat.Text.Trim()
                         Dim condicionBusqueda As String
                         If busqueda = "" Then
                             condicionBusqueda = "1=1" ' Esto siempre será verdadero, mostrando todos los registros
                         Else
                             condicionBusqueda = $"codigo LIKE '%{busqueda}%' OR nombre LIKE '%{busqueda}%'"
                         End If
                         SQL = "SELECT ID, codigo AS 'Código', nombre AS 'Nombre' " &
                                  "FROM categoria " &
                                  "WHERE " & condicionBusqueda &
                                  " ORDER BY codigo ASC;"
                         Invoke(Sub()
                                    Cargar_Tabla(T, SQL)
                                    If T.Tables.Count > 0 AndAlso T.Tables(0).Rows.Count > 0 Then
                                        DGV_BCat.Columns.Clear()
                                        Dim bin As New BindingSource
                                        bin.DataSource = T.Tables(0)
                                        DGV_BCat.DataSource = bin
                                    Else ' Limpiar la fuente de datos si no se cargaron datos
                                        DGV_BCat.DataSource = Nothing
                                    End If
                                    TXT_BuscarCat.Select()
                                End Sub)
                     Catch ex As Exception
                         If DGV_BCat.IsHandleCreated Then
                             Invoke(Sub()
                                        If ex.Message <> "InvalidArgument=El valor de '0' no es válido para 'index'." & vbCrLf & "Nombre del parámetro: index" Then
                                            ' Mostrar un mensaje de error genérico
                                            msgError("Error al cargar la lista de categorías: " & ex.Message)
                                        End If
                                    End Sub)
                         End If
                     End Try
                 End Sub)
    End Sub


    ' Método para manejar el evento DataBindingComplete
    Private Sub DGV_BCat_DataBindingComplete(sender As Object, e As DataGridViewBindingCompleteEventArgs) Handles DGV_BCat.DataBindingComplete
        Try
            ' Mover la celda activa a otra columna visible antes de ocultar columnas 
            If DGV_BCat.CurrentCell IsNot Nothing AndAlso DGV_BCat.CurrentCell.ColumnIndex = 0 Then
                DGV_BCat.CurrentCell = DGV_BCat.Rows(0).Cells(1)
                ' Mueve la celda activa a la columna 1 o cualquier otra columna visible
            End If
            For i As Integer = 0 To DGV_BCat.Columns.Count - 1
                DGV_BCat.Columns(i).ReadOnly = True
                Select Case i
                    Case 1
                        DGV_BCat.Columns(i).Width = 50
                    Case 2
                        DGV_BCat.Columns(i).Width = 200
                End Select
            Next
            DGV_BCat.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
            DGV_BCat.GridColor = Color.DarkGray
            DGV_BCat.Columns(0).Visible = False
        Catch ex As Exception
            ' Manejar el error si alguna columna no existe
            Console.WriteLine("Error al ocultar las columnas: " & ex.Message)
        End Try
    End Sub

    Private Sub BTN_RegresarMarca_Click(sender As Object, e As EventArgs) Handles BTN_RegresarCat.Click
        Select Case caso
            Case "Prod"
                P_Productos.Show()
                P_Productos.Select()
            Case "NProd"
                E_NuevoProducto.Show()
                E_NuevoProducto.Select()
        End Select
        Me.Close()
    End Sub

    Private Sub BTN_NMarca_Click(sender As Object, e As EventArgs) Handles BTN_SelectCat.Click
        Try
            Select Case caso
                Case "Prod"
                    P_Productos.TXT_BuscarCat.Text = TXT_Nombre.Text
                    P_Productos.REFRESCAR()
                    P_Productos.Show()
                    P_Productos.Select()
                Case "NProd"
                    E_NuevoProducto.TXT_Categoria.Text = TXT_Nombre.Text
                    E_NuevoProducto.LBL_IDCat.Text = DGV_BCat.SelectedRows(0).Cells(0).Value.ToString()
                    E_NuevoProducto.Show()
                    E_NuevoProducto.Select()
            End Select
            Me.Close()
        Catch ex As Exception
            P_Productos.TXT_BuscarCat.Text = ""
            P_Productos.REFRESCAR()
            Me.Close()
        End Try

    End Sub

    Private Sub TXT_BuscarMarca_TextChanged(sender As Object, e As EventArgs) Handles TXT_BuscarCat.TextChanged
        If searchTimer IsNot Nothing Then
            searchTimer.Stop()
            searchTimer.Start()
        End If
    End Sub

    Private Sub B_Marca_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        InicializarComponentes()
        REFRESCAR()
    End Sub

    Private Sub DGV_BCat_SelectionChanged(sender As Object, e As EventArgs) Handles DGV_BCat.SelectionChanged
        Try
            TXT_codigo.Text = DGV_BCat.SelectedRows(0).Cells(1).Value.ToString()
            TXT_Nombre.Text = DGV_BCat.SelectedRows(0).Cells(2).Value.ToString()
        Catch ex As Exception
            TXT_codigo.Text = ""
            TXT_Nombre.Text = ""
        End Try
    End Sub

End Class