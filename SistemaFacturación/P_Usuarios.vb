
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports System.Threading.Tasks

Public Class P_Usuarios
    Private searchTimer As Timer

    ' Método para inicializar el temporizador y otros componentes necesarios
    Private Sub InicializarComponentes()
        ' Inicializar el temporizador
        searchTimer = New Timer()
        searchTimer.Interval = 200
        ' Medio segundo
        AddHandler searchTimer.Tick, AddressOf OnSearchTimerTick
    End Sub

    Private Sub OnSearchTimerTick(sender As Object, e As EventArgs)
        ' Detener el temporizador y ejecutar la búsqueda
        searchTimer.Stop()
        REFRESCAR()
    End Sub
    Private Sub P_Usuarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        InicializarComponentes()
        REFRESCAR()
    End Sub

    Private Sub CerrarApp_Click(sender As Object, e As EventArgs)
        msgCerrarApp()
    End Sub
    Public Sub REFRESCAR()
        Task.Run(Sub()
                     Try
                         Dim busqueda As String = TXT_BuscarUsuario.Text.Trim()
                         Dim condicionBusqueda As String
                         If busqueda = "" Then
                             condicionBusqueda = "1=1" ' Esto siempre será verdadero, mostrando todos los registros
                         Else
                             condicionBusqueda = $"(u.codigo LIKE '%{busqueda}%' OR u.usuario LIKE '%{busqueda}%')"
                         End If

                         SQL = "SELECT u.ID, u.codigo AS 'Código', u.usuario AS 'Cajero', u.clave, " &
                                  "CASE WHEN u.tipo = 0 THEN 'Cajero' " &
                                  "WHEN u.tipo = 1 THEN 'Administrador' " &
                                  "ELSE 'Desconocido' END AS 'Tipo', u.color AS 'Color' " &
                                  "FROM usuario u " &
                                  "WHERE " & condicionBusqueda &
                                  " ORDER BY u.codigo ASC;"

                         Invoke(Sub()
                                    T.Tables.Clear()
                                    MNU_ELIMINAR.Visible = False
                                    MNU_MODIFICAR.Visible = False
                                    Cargar_Tabla(T, SQL)
                                    If T.Tables.Count > 0 AndAlso T.Tables(0).Rows.Count > 0 Then
                                        Dim bin As New BindingSource
                                        bin.DataSource = T.Tables(0)
                                        DGV_Cajero.DataSource = bin
                                        MNU_ELIMINAR.Visible = True
                                        MNU_MODIFICAR.Visible = True
                                    Else ' Limpiar la fuente de datos si no se cargaron datos
                                        DGV_Cajero.DataSource = Nothing
                                    End If
                                    TXT_BuscarUsuario.Select()
                                End Sub)
                     Catch ex As Exception
                         Invoke(Sub()
                                    If DGV_Cajero.IsHandleCreated Then
                                        If ex.Message <> "InvalidArgument=El valor de '0' no es válido para 'index'." & vbCrLf & "Nombre del parámetro: index" Then
                                            ' Mostrar un mensaje de error genérico
                                            msgError("Error al cargar la lista de categorías: " & ex.Message)
                                        End If
                                    End If

                                End Sub)
                     End Try
                 End Sub)
    End Sub


    Private Sub DGV_Cajero_DataBindingComplete(sender As Object, e As DataGridViewBindingCompleteEventArgs) Handles DGV_Cajero.DataBindingComplete
        Try
            Dim selectedRowIndex As Integer = -1
            If DGV_Cajero.SelectedRows.Count > 0 Then
                selectedRowIndex = DGV_Cajero.SelectedRows(0).Index
            End If
            For i As Integer = 0 To DGV_Cajero.Columns.Count - 1
                DGV_Cajero.Columns(i).ReadOnly = True
                Select Case i
                    Case 1
                        DGV_Cajero.Columns(i).Width = 20
                    Case 2
                        DGV_Cajero.Columns(i).Width = 100
                    Case 4
                        DGV_Cajero.Columns(i).Width = 100
                    Case 5
                        DGV_Cajero.Columns(i).Width = 200
                End Select
            Next

            For Each row As DataGridViewRow In DGV_Cajero.Rows
                If row.Cells(5).Value IsNot Nothing Then
                    Dim col As String() = row.Cells(5).Value.ToString().Split(","c)
                    If col.Length = 3 Then
                        ' Convertir los valores RGB a enteros
                        Dim r As Integer = Convert.ToInt32(col(0).Trim())
                        Dim g As Integer = Convert.ToInt32(col(1).Trim())
                        Dim b As Integer = Convert.ToInt32(col(2).Trim())

                        row.Cells(5).Style.BackColor = Color.FromArgb(r, g, b)
                        row.Cells(5).Style.ForeColor = Color.FromArgb(r, g, b)
                        row.Cells(5).Style.SelectionBackColor = Color.FromArgb(r, g, b)
                        row.Cells(5).Style.SelectionForeColor = Color.FromArgb(r, g, b)
                    End If
                End If
            Next

            DGV_Cajero.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
            DGV_Cajero.GridColor = Color.DarkGray
            DGV_Cajero.Columns(0).Visible = False
            DGV_Cajero.Columns(3).Visible = False
            If selectedRowIndex >= 0 AndAlso selectedRowIndex < DGV_Cajero.Rows.Count Then
                DGV_Cajero.Rows(selectedRowIndex).Selected = True
                DGV_Cajero.FirstDisplayedScrollingRowIndex = selectedRowIndex
            End If
        Catch ex As Exception
            ' Manejar el error si alguna columna no existe
            Console.WriteLine("Error al ocultar las columnas: " & ex.Message)
        End Try
    End Sub



    Private Sub BTN_RegresarUsu_Click(sender As Object, e As EventArgs) Handles BTN_RegresarUsu.Click
        M_Mantenimiento.Show()
        M_Mantenimiento.Select()
        Me.Close()
    End Sub

    Private Sub BTN_NUsuario_Click(sender As Object, e As EventArgs) Handles BTN_NUsuario.Click
        E_NuevoUsuario.ModUsu = False
        E_NuevoUsuario.Show()
        E_NuevoUsuario.Select()
    End Sub

    Private Sub TXT_BuscarUsuario_TextChanged(sender As Object, e As EventArgs) Handles TXT_BuscarUsuario.TextChanged
        If searchTimer IsNot Nothing Then
            searchTimer.Stop()
            searchTimer.Start()
        End If
    End Sub

    Private Sub MNU_ELIMINAR_Click(sender As Object, e As EventArgs) Handles MNU_ELIMINAR.Click
        T.Tables.Clear()
        T1.Tables.Clear()
        Try
            If DGV_Cajero.SelectedRows.Count > 0 Then
                ' Se pregunta una confirmación para eliminar el tema
                If msgEliminar("al cajero: " & DGV_Cajero.SelectedRows(0).Cells(2).Value.ToString()) Then
                    Dim idSucEliminar As Integer = Convert.ToInt32(DGV_Cajero.SelectedRows(0).Cells(0).Value.ToString())
                    ' Verificar si hay categorías asociadas
                    SQL = "SELECT COUNT(ID) FROM usuario WHERE ID = " & idSucEliminar
                    Cargar_Tabla(T, SQL)

                    If T.Tables(0).Rows(0).Item(0) <> 0 Then
                        'Se elimina
                        ELIMINAR("usuario", "ID", idSucEliminar)
                        REFRESCAR()
                        msgDatoDel()
                    Else
                        msgError("El usuario no existe")
                    End If
                End If
            Else
                msgError("Seleccione un usuario para eliminar.")
            End If
        Catch ex As Exception
            msgError("Error al eliminar El usuario: " & ex.Message)
        End Try
        TXT_BuscarUsuario.SelectAll()
    End Sub

    Private Sub MNU_MODIFICAR_Click(sender As Object, e As EventArgs) Handles MNU_MODIFICAR.Click
        Try
            E_NuevoUsuario.idUsuario = DGV_Cajero.SelectedRows(0).Cells(0).Value.ToString()
            E_NuevoUsuario.TXT_CodUsuario.Text = DGV_Cajero.SelectedRows(0).Cells(1).Value.ToString()
            E_NuevoUsuario.TXT_NombreUsuario.Text = DGV_Cajero.SelectedRows(0).Cells(2).Value.ToString()
            E_NuevoUsuario.TXT_ClaveUsuario.Text = DGV_Cajero.SelectedRows(0).Cells(3).Value.ToString()
            If DGV_Cajero.SelectedRows(0).Cells(4).Value = "Administrador" Then
                E_NuevoUsuario.CBX_tipoCuenta.SelectedIndex = 1
            Else
                E_NuevoUsuario.CBX_tipoCuenta.SelectedIndex = 0
            End If

            Dim rgbValues() = DGV_Cajero.SelectedRows(0).Cells(5).Value.ToString().Split(",")
            Dim red As Integer = Convert.ToInt32(rgbValues(0))
            Dim green As Integer = Convert.ToInt32(rgbValues(1))
            Dim blue As Integer = Convert.ToInt32(rgbValues(2))
            E_NuevoUsuario.BTN_Color.FillColor = Color.FromArgb(red, green, blue)
            E_NuevoUsuario.ColorDialog1.Color = Color.FromArgb(red, green, blue)
            E_NuevoUsuario.ColorUsuario = DGV_Cajero.SelectedRows(0).Cells(5).Value.ToString()
            If String.IsNullOrEmpty(DGV_Cajero.SelectedRows(0).Cells(3).Value.ToString()) Then
                E_NuevoUsuario.SWT_SinClave.Checked = True
            Else
                E_NuevoUsuario.SWT_SinClave.Checked = False
            End If
            E_NuevoUsuario.ModUsu = True
            E_NuevoUsuario.CodigoPreMod = DGV_Cajero.SelectedRows(0).Cells(1).Value.ToString()
            E_NuevoUsuario.Show()
            E_NuevoUsuario.Select()
        Catch ex As Exception
            msgError("Error al extraer los datos para modificarlos: " & ex.Message)
        End Try
    End Sub

    Private Sub Guna2ImageButton1_Click(sender As Object, e As EventArgs) Handles BTN_Config.Click
        entrarConfig(1)
    End Sub

    Private Sub BTN_CerrarApp_Click(sender As Object, e As EventArgs) Handles BTN_CerrarApp.Click
        msgCerrarApp()
    End Sub
End Class