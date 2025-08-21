Public Class P_Impuestos

    Private Sub P_Impuestos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        REFRESCAR()
    End Sub

    Public Sub REFRESCAR()
        Try
            MNU_ELIMINAR.Visible = False
            MNU_MODIFICAR.Visible = False
            T.Tables.Clear()
            SQL = "SELECT ID, codigo AS 'Código', descripcion AS 'Descripción', porcentaje AS 'Porcentaje' " &
                    "FROM impuestos " &
                    "ORDER BY codigo ASC;"
            Cargar_Tabla(T, SQL)
            If T.Tables.Count > 0 AndAlso T.Tables(0).Rows.Count > 0 Then
                Dim bin As New BindingSource
                bin.DataSource = T.Tables(0)
                DGV_Imp.DataSource = bin
                ' Restaurar la selección
                MNU_ELIMINAR.Visible = True
                MNU_MODIFICAR.Visible = True
            End If
        Catch ex As Exception
            If ex.Message <> "InvalidArgument=El valor de '0' no es válido para 'index'." & vbCrLf & "Nombre del parámetro: index" Then
                ' Mostrar un mensaje de error genérico
                msgError("Error al cargar la lista de categorías: " & ex.Message)
            End If
        End Try

    End Sub

    ' Método para manejar el evento DataBindingComplete

    Private Sub DGV_Imp_DataBindingComplete(sender As Object, e As DataGridViewBindingCompleteEventArgs) Handles DGV_Imp.DataBindingComplete
        Try
            Dim selectedRowIndex As Integer = -1
            If DGV_Imp.SelectedRows.Count > 0 Then
                selectedRowIndex = DGV_Imp.SelectedRows(0).Index
            End If
            For i As Integer = 0 To DGV_Imp.Columns.Count - 1
                DGV_Imp.Columns(i).ReadOnly = True
                Select Case i
                    Case 1
                        DGV_Imp.Columns(i).Width = 50
                    Case 2
                        DGV_Imp.Columns(i).Width = 250
                    Case 3
                        DGV_Imp.Columns(i).Width = 70
                End Select
            Next
            DGV_Imp.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
            DGV_Imp.GridColor = Color.DarkGray
            DGV_Imp.Columns(0).Visible = False
            If selectedRowIndex >= 0 AndAlso selectedRowIndex < DGV_Imp.Rows.Count Then
                DGV_Imp.Rows(selectedRowIndex).Selected = True
            End If
        Catch ex As Exception
            ' Manejar el error si alguna columna no existe
            Console.WriteLine("Error al ocultar las columnas: " & ex.Message)
        End Try
    End Sub
    Private Sub BTN_RegresarImpuesto_Click(sender As Object, e As EventArgs) Handles BTN_RegresarImpuesto.Click
        M_Mantenimiento.Show()
        M_Mantenimiento.Select()
        Me.Close()
    End Sub

    Private Sub BTN_NImpuesto_Click(sender As Object, e As EventArgs) Handles BTN_NImpuesto.Click
        E_NuevoImpuesto.ModImp = False
        E_NuevoImpuesto.Show()
        E_NuevoImpuesto.Select()
    End Sub

    Private Sub MNU_MODIFICAR_Click(sender As Object, e As EventArgs) Handles MNU_MODIFICAR.Click
        Try
            E_NuevoImpuesto.idImpuesto = DGV_Imp.SelectedRows(0).Cells(0).Value.ToString()
            E_NuevoImpuesto.TXT_CodImpuesto.Text = DGV_Imp.SelectedRows(0).Cells(1).Value.ToString()
            E_NuevoImpuesto.TXT_DescImpuesto.Text = DGV_Imp.SelectedRows(0).Cells(2).Value.ToString()
            E_NuevoImpuesto.NUD_Porc.Value = Convert.ToInt32(DGV_Imp.SelectedRows(0).Cells(3).Value.ToString())
            E_NuevoImpuesto.ModImp = True
            E_NuevoImpuesto.CodigoPreMod = DGV_Imp.SelectedRows(0).Cells(1).Value.ToString()
            E_NuevoImpuesto.Show()
        Catch ex As Exception
            msgError("Error: " & ex.Message)
        End Try
    End Sub

    Private Sub MNU_ELIMINAR_Click(sender As Object, e As EventArgs) Handles MNU_ELIMINAR.Click
        T.Tables.Clear()
        T1.Tables.Clear()
        Try
            If DGV_Imp.SelectedRows.Count > 0 Then
                ' Se pregunta una confirmación para eliminar el tema
                If MsgBox("¿Desea eliminar el impuesto: " & DGV_Imp.SelectedRows(0).Cells(2).Value.ToString() & "?", vbQuestion + vbYesNo, "Confirmar") = vbYes Then
                    Dim idEliminar As Integer = Convert.ToInt32(DGV_Imp.SelectedRows(0).Cells(0).Value.ToString())
                    ' Verificar si hay categorías asociadas
                    SQL = "SELECT COUNT(ID) FROM impuestos WHERE ID = " & idEliminar
                    Cargar_Tabla(T, SQL)
                    If T.Tables(0).Rows(0).Item(0) <> 0 Then
                        'Se elimina
                        ELIMINAR("impuestos", "ID", idEliminar)
                        REFRESCAR()
                        msgDatoDel()
                    Else
                        msgError("El impuesto no existe")
                    End If
                End If
            Else
                msgError("Seleccione un impuesto para eliminar.")
            End If
        Catch ex As Exception
            msgError("Error al eliminar el impuesto: " & ex.Message)
        End Try
    End Sub

    Private Sub BTN_CerrarApp_Click(sender As Object, e As EventArgs) Handles BTN_CerrarApp.Click
        msgCerrarApp()
    End Sub

    Private Sub BTN_Config_Click(sender As Object, e As EventArgs) Handles BTN_Config.Click
        entrarConfig(1)
    End Sub
End Class