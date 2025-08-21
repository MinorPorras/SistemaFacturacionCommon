Imports System.Threading.Tasks

Public Class P_Marca
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

    Private Sub BTN_RegresarCat_Click(sender As Object, e As EventArgs) Handles BTN_RegresarMarca.Click
        M_Mantenimiento.Show()
        M_Mantenimiento.Select()
        Me.Close()
    End Sub

    Private Sub P_Marca_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        InicializarComponentes()
        REFRESCAR()
    End Sub

    Public Sub REFRESCAR()
        Task.Run(Sub()
                     Try
                         T.Tables.Clear()
                         Dim busqueda As String = TXT_BuscarMarca.Text.Trim()
                         Dim condicionBusqueda As String
                         If busqueda = "" Then
                             condicionBusqueda = "1=1" ' Esto siempre será verdadero, mostrando todos los registros
                         Else
                             condicionBusqueda = $"(codigo LIKE '%{busqueda}%' OR nombre LIKE '%{busqueda}%')"
                         End If
                         SQL = "SELECT ID, codigo AS 'Código', nombre AS 'Nombre' " &
                                  "FROM marca " &
                                  "WHERE " & condicionBusqueda &
                                  " ORDER BY codigo ASC;"

                         Invoke(Sub()
                                    MNU_ELIMINAR.Visible = False
                                    MNU_MODIFICAR.Visible = False
                                    Cargar_Tabla(T, SQL)
                                    If T.Tables.Count > 0 AndAlso T.Tables(0).Rows.Count > 0 Then
                                        Dim bin As New BindingSource
                                        bin.DataSource = T.Tables(0)
                                        DGV_Marca.DataSource = bin
                                        MNU_ELIMINAR.Visible = True
                                        MNU_MODIFICAR.Visible = True
                                    Else ' Limpiar la fuente de datos si no se cargaron datos
                                        DGV_Marca.DataSource = Nothing
                                    End If
                                    TXT_BuscarMarca.Select()
                                End Sub)
                     Catch ex As Exception
                         Invoke(Sub()
                                    If DGV_Marca.IsHandleCreated Then
                                        If ex.Message <> "InvalidArgument=El valor de '0' no es válido para 'index'." & vbCrLf & "Nombre del parámetro: index" Then
                                            ' Mostrar un mensaje de error genérico
                                            msgError("Error al cargar la lista de categorías: " & ex.Message)
                                        End If
                                    End If
                                End Sub)
                     End Try
                 End Sub)
    End Sub

    ' Método para manejar el evento DataBindingComplete
    Private Sub DGV_Marca_DataBindingComplete(sender As Object, e As DataGridViewBindingCompleteEventArgs) Handles DGV_Marca.DataBindingComplete
        Try
            Dim selectedRowIndex As Integer = -1
            If DGV_Marca.SelectedRows.Count > 0 Then
                selectedRowIndex = DGV_Marca.SelectedRows(0).Index
            End If
            For i As Integer = 0 To DGV_Marca.Columns.Count - 1
                DGV_Marca.Columns(i).ReadOnly = True
                Select Case i
                    Case 1
                        DGV_Marca.Columns(i).Width = 80
                    Case 2
                        DGV_Marca.Columns(i).Width = 345
                End Select
            Next
            DGV_Marca.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
            DGV_Marca.GridColor = Color.DarkGray
            DGV_Marca.Columns(0).Visible = False
            If selectedRowIndex >= 0 AndAlso selectedRowIndex < DGV_Marca.Rows.Count Then
                DGV_Marca.Rows(selectedRowIndex).Selected = True
                DGV_Marca.FirstDisplayedScrollingRowIndex = selectedRowIndex
            End If
        Catch ex As Exception
            ' Manejar el error si alguna columna no existe
            Console.WriteLine("Error al ocultar las columnas: " & ex.Message)
        End Try
    End Sub

    Private Sub TXT_BuscarCat_TextChanged(sender As Object, e As EventArgs) Handles TXT_BuscarMarca.TextChanged
        If searchTimer IsNot Nothing Then
            searchTimer.Stop()
            searchTimer.Start()
        End If
    End Sub

    Private Sub BTN_NCat_Click(sender As Object, e As EventArgs) Handles BTN_NMarca.Click
        E_NuevaMarca.ModMarca = False
        E_NuevaMarca.Show()
        E_NuevaMarca.Select()
    End Sub

    Private Sub MNU_MODIFICAR_Click(sender As Object, e As EventArgs) Handles MNU_MODIFICAR.Click
        Try
            E_NuevaMarca.idMarca = DGV_Marca.SelectedRows(0).Cells(0).Value.ToString()
            E_NuevaMarca.TXT_CodMarca.Text = DGV_Marca.SelectedRows(0).Cells(1).Value.ToString()
            E_NuevaMarca.TXT_NombreMarca.Text = DGV_Marca.SelectedRows(0).Cells(2).Value.ToString()
            E_NuevaMarca.ModMarca = True
            E_NuevaMarca.CodigoPreMod = DGV_Marca.SelectedRows(0).Cells(1).Value.ToString()
            E_NuevaMarca.Show()
        Catch ex As Exception
            MsgBox("Error: " & ex.Message, vbCritical + vbOKOnly, "Error")
        End Try
    End Sub

    Private Sub MNU_ELIMINAR_Click(sender As Object, e As EventArgs) Handles MNU_ELIMINAR.Click
        T.Tables.Clear()
        T1.Tables.Clear()
        Try
            If DGV_Marca.SelectedRows.Count > 0 Then
                ' Se pregunta una confirmación para eliminar el tema
                If msgEliminar(" la marca: " & DGV_Marca.SelectedRows(0).Cells(2).Value.ToString() & "?") Then
                    Dim idEliminar As Integer = Convert.ToInt32(DGV_Marca.SelectedRows(0).Cells(0).Value.ToString())
                    ' Verificar si hay categorías asociadas
                    SQL = "SELECT COUNT(ID) FROM marca WHERE ID = " & idEliminar
                    Cargar_Tabla(T, SQL)

                    If T.Tables(0).Rows(0).Item(0) <> 0 Then
                        'Se elimina
                        ELIMINAR("producto_marca", "ID_Marca", idEliminar)
                        ELIMINAR("marca", "ID", idEliminar)
                        REFRESCAR()
                        msgDatoDel()
                    Else
                        msgError("La marca no existe")
                    End If
                End If
            Else
                msgError("Seleccione una marca para eliminar.")
            End If
        Catch ex As Exception
            Console.WriteLine(ex.Message)
            msgError("Error al eliminar la marca: " & ex.Message)
        End Try
        TXT_BuscarMarca.SelectAll()
    End Sub

    Private Sub BTN_CerrarApp_Click(sender As Object, e As EventArgs) Handles BTN_CerrarApp.Click
        msgCerrarApp()
    End Sub

    Private Sub BTN_Config_Click(sender As Object, e As EventArgs) Handles BTN_Config.Click
        entrarConfig(1)
    End Sub
End Class