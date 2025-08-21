Imports System.Threading.Tasks

Public Class B_Impuesto
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
                         Dim busqueda As String = TXT_BuscarImp.Text.Trim()
                         Dim condicionBusqueda As String
                         If busqueda = "" Then
                             condicionBusqueda = "1=1" ' Esto siempre será verdadero, mostrando todos los registros
                         Else
                             condicionBusqueda = $"codigo LIKE '%{busqueda}%' OR descripcion LIKE '%{busqueda}%')"
                         End If
                         SQL = "SELECT ID, codigo AS 'Código', descripcion AS 'Descripción', porcentaje AS 'Porcentaje' " &
                                  "FROM impuestos " &
                                  "WHERE " & condicionBusqueda &
                                  " ORDER BY codigo ASC;"

                         Invoke(Sub()
                                    Cargar_Tabla(T, SQL)
                                    If T.Tables.Count > 0 AndAlso T.Tables(0).Rows.Count > 0 Then
                                        Dim bin As New BindingSource
                                        bin.DataSource = T.Tables(0)
                                        DGV_BImp.DataSource = bin
                                    Else ' Limpiar la fuente de datos si no se cargaron datos
                                        DGV_BImp.DataSource = Nothing
                                    End If
                                    TXT_BuscarImp.Select()
                                End Sub)
                     Catch ex As Exception
                         Invoke(Sub()
                                    If DGV_BImp.IsHandleCreated Then
                                        If ex.Message <> "InvalidArgument=El valor de '0' no es válido para 'index'." & vbCrLf & "Nombre del parámetro: index" Then
                                            ' Mostrar un mensaje de error genérico
                                            msgError("Error al cargar la lista de categorías: " & ex.Message)
                                        End If
                                    End If
                                End Sub)
                     End Try
                 End Sub)
    End Sub
    Private Sub DGV_BImp_DataBindingComplete_1(sender As Object, e As DataGridViewBindingCompleteEventArgs) Handles DGV_BImp.DataBindingComplete
        Try
            For i As Integer = 0 To DGV_BImp.Columns.Count - 1
                DGV_BImp.Columns(i).ReadOnly = True
                Select Case i
                    Case 1
                        DGV_BImp.Columns(i).Width = 50
                    Case 2
                        DGV_BImp.Columns(i).Width = 200
                    Case 3
                        DGV_BImp.Columns(i).Width = 70
                End Select
            Next
            DGV_BImp.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
            DGV_BImp.GridColor = Color.DarkGray
            DGV_BImp.Columns(0).Visible = False
        Catch ex As Exception
            ' Manejar el error si alguna columna no existe
            Console.WriteLine("Error al ocultar las columnas: " & ex.Message)
        End Try
    End Sub


    Private Sub BTN_RegresarMarca_Click(sender As Object, e As EventArgs) Handles BTN_RegresarImpuesto.Click
        E_NuevoProducto.Show()
        E_NuevoProducto.Select()
        Me.Close()
    End Sub

    Private Sub BTN_NMarca_Click(sender As Object, e As EventArgs) Handles BTN_SelectImpuesto.Click
        Try
            E_NuevoProducto.TXT_Impuesto.Text = TXT_porcentaje.Text
            E_NuevoProducto.LBL_IDImp.Text = DGV_BImp.SelectedRows(0).Cells(0).Value.ToString()
            E_NuevoProducto.Show()
            E_NuevoProducto.Select()
            Me.Close()
        Catch ex As Exception
            Me.Close()
        End Try
    End Sub

    Private Sub TXT_BuscarMarca_TextChanged(sender As Object, e As EventArgs) Handles TXT_BuscarImp.TextChanged
        If searchTimer IsNot Nothing Then
            searchTimer.Stop()
            searchTimer.Start()
        End If
    End Sub

    Private Sub B_Marca_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        InicializarComponentes()
        REFRESCAR()
    End Sub
    Private Sub DGV_BImp_SelectionChanged(sender As Object, e As EventArgs) Handles DGV_BImp.SelectionChanged
        Try
            TXT_codigo.Text = DGV_BImp.SelectedRows(0).Cells(1).Value.ToString()
            TXT_Desc.Text = DGV_BImp.SelectedRows(0).Cells(2).Value.ToString()
            TXT_porcentaje.Text = DGV_BImp.SelectedRows(0).Cells(3).Value.ToString()
        Catch ex As Exception
            TXT_codigo.Text = ""
            TXT_Desc.Text = ""
            TXT_porcentaje.Text = ""
        End Try
    End Sub
End Class