Imports System.Threading.Tasks

Public Class B_Cliente

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
    Private Sub B_Cliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        InicializarComponentes()
        REFRESCAR()
    End Sub

    Public Sub REFRESCAR()
        Task.Run(Sub()
                     Try
                         T.Tables.Clear()
                         Dim busqueda As String = TXT_BuscarCliente.Text.Trim()
                         Dim condicionBusqueda As String
                         If busqueda = "" Then
                             condicionBusqueda = "1=1" ' Esto siempre será verdadero, mostrando todos los registros
                         Else
                             condicionBusqueda = $"codigo LIKE '%{busqueda}%' OR nombre LIKE '%{busqueda}%'"
                         End If
                         SQL = "SELECT ID, codigo AS 'Código', nombre AS 'Nombre' " &
                                  "FROM clientes " &
                                  "WHERE " & condicionBusqueda &
                                  " ORDER BY codigo ASC;"

                         Invoke(Sub()
                                    Cargar_Tabla(T, SQL)
                                    If T.Tables.Count > 0 AndAlso T.Tables(0).Rows.Count > 0 Then
                                        Dim bin As New BindingSource
                                        bin.DataSource = T.Tables(0)
                                        DGV_BCliente.DataSource = bin
                                    Else ' Limpiar la fuente de datos si no se cargaron datos
                                        DGV_BCliente.DataSource = Nothing
                                    End If
                                    TXT_BuscarCliente.Select()
                                End Sub)
                     Catch ex As Exception
                         If DGV_BCliente.IsHandleCreated Then
                             Invoke(Sub()
                                        If ex.Message <> "InvalidArgument=El valor de '0' no es válido para 'index'." & vbCrLf & "Nombre del parámetro: index" Then
                                            ' Mostrar un mensaje de error genérico
                                            msgError("Error al cargar la lista de clientes: " & ex.Message)
                                        End If
                                    End Sub)
                         End If
                     End Try
                 End Sub)

    End Sub

    Private Sub DGV_BCliente_DataBindingComplete(sender As Object, e As DataGridViewBindingCompleteEventArgs) Handles DGV_BCliente.DataBindingComplete
        Try
            For i As Integer = 0 To DGV_BCliente.Columns.Count - 1
                DGV_BCliente.Columns(i).ReadOnly = True
                Select Case i
                    Case 1
                        DGV_BCliente.Columns(i).Width = 50
                    Case 2
                        DGV_BCliente.Columns(i).Width = 200
                    Case 3
                        DGV_BCliente.Columns(i).Width = 70
                End Select
            Next
            DGV_BCliente.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
            DGV_BCliente.GridColor = Color.DarkGray
            DGV_BCliente.Columns(0).Visible = False
        Catch ex As Exception
            ' Manejar el error si alguna columna no existe
            Console.WriteLine("Error al ocultar las columnas: " & ex.Message)
        End Try
    End Sub

    Private Sub BTN_RegresarBCLiente_Click(sender As Object, e As EventArgs) Handles BTN_RegresarBCLiente.Click
        P_Caja.Show()
        P_Caja.Select()
        Me.Close()
    End Sub

    Private Sub BTN_SelectCliente_Click(sender As Object, e As EventArgs) Handles BTN_SelectCliente.Click
        P_Caja.Show()
        P_Caja.idCliente = DGV_BCliente.SelectedRows(0).Cells(0).Value.ToString()
        P_Caja.TXT_BuscarCliente.Text = TXT_codigo.Text
        P_Caja.Select()
        Me.Close()
    End Sub

    Private Sub TXT_BuscarCliente_TextChanged(sender As Object, e As EventArgs) Handles TXT_BuscarCliente.TextChanged
        If searchTimer IsNot Nothing Then
            searchTimer.Stop()
            searchTimer.Start()
        End If
    End Sub

    Private Sub DGV_BCliente_SelectionChanged(sender As Object, e As EventArgs) Handles DGV_BCliente.SelectionChanged
        Try
            TXT_codigo.Text = DGV_BCliente.SelectedRows(0).Cells(1).Value.ToString()
            TXT_Nombre.Text = DGV_BCliente.SelectedRows(0).Cells(2).Value.ToString()
            LBL_IDCliente.Text = DGV_BCliente.SelectedRows(0).Cells(0).Value.ToString()
        Catch ex As Exception
            TXT_codigo.Text = ""
            TXT_Nombre.Text = ""
        End Try
    End Sub

    Friend Sub LIMPIAR()
        TXT_BuscarCliente.Clear()
        TXT_codigo.Clear()
        TXT_Nombre.Clear()
    End Sub
End Class