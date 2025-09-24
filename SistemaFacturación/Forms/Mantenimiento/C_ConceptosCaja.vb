Imports System.Data.SQLite
Imports Guna.UI2.WinForms
Imports SistemaFacturaciónCommon.SistemaFacturacion.Data
Imports SistemaFacturaciónCommon.SistemaFacturacion.Forms.Mantenimiento
Imports SistemaFacturaciónCommon.SistemaFacturacion.Modules

Public Class C_ConceptosCaja
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


    Private Sub OnSearchTimerTick(sender As Object, e As EventArgs)
        ' Detener el temporizador y ejecutar la búsqueda
        searchTimer.Stop()
        REFRESCAR_ENTRADAS()
        REFRESCAR_SALIDA()
    End Sub

    Private Sub RestartTimer()
        If searchTimer IsNot Nothing Then
            searchTimer.Stop()
            searchTimer.Start()
        End If
    End Sub

    Private Async Sub REFRESCAR_ENTRADAS()
        Await Task.Run(Sub()
                           Try

                               Me.Invoke(Sub()

                                             ' Se establece la consulta SQL
                                             Dim SQL = "SELECT ID, concepto As 'Concepto', ID_Tipo_Movimiento FROM Conceptos_Caja WHERE concepto LIKE @searchTerm AND ID_Tipo_Movimiento = 1"
                                             Dim searchText = If(String.IsNullOrEmpty(TXT_BuscarEntradas.Text), "", TXT_BuscarEntradas.Text)
                                             Dim param As New List(Of SQLiteParameter) From {New SQLiteParameter("@searchTerm", "%" & searchText & "%")}
                                             CargarTablaParam(T, SQL, param)
                                             If T.Tables(0) Is Nothing OrElse T.Tables(0).Rows.Count <= 0 Then
                                                 ' La tabla no existe o no tiene filas
                                                 MNU_CONTX.Visible = False
                                                 DGV_Entradas.DataSource = Nothing
                                                 Return
                                             End If
                                             Dim conceptos = T.Tables(0)

                                             'Se asigna el data source como lo que se obtuvo de la consulta
                                             DGV_Entradas.DataSource = New BindingSource With {.DataSource = conceptos}
                                             MNU_CONTX.Visible = True
                                         End Sub)
                           Catch ex As Exception
                               MessageBox.Show("Error al refrescar los datos: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                           End Try
                       End Sub)
    End Sub

    Private Async Sub REFRESCAR_SALIDA()
        Await Task.Run(Sub()
                           Try

                               Me.Invoke(Sub()

                                             ' Se establece la consulta SQL
                                             Dim SQL = "SELECT ID, concepto As 'Concepto', ID_Tipo_Movimiento FROM Conceptos_Caja WHERE concepto LIKE @searchTerm AND ID_Tipo_Movimiento = 2"
                                             Dim searchText = If(String.IsNullOrEmpty(TXT_BuscarSalidas.Text), "", TXT_BuscarSalidas.Text)
                                             Dim param As New List(Of SQLiteParameter) From {New SQLiteParameter("@searchTerm", "%" & searchText & "%")}
                                             CargarTablaParam(T, SQL, param)
                                             If T.Tables(0) Is Nothing OrElse T.Tables(0).Rows.Count <= 0 Then
                                                 MNU_CONTX.Visible = False
                                                 ' La tabla no existe o no tiene filas
                                                 DGV_Salidas.DataSource = Nothing
                                                 Return
                                             End If
                                             Dim conceptos = T.Tables(0)

                                             'Se asigna el data source como lo que se obtuvo de la consulta
                                             DGV_Salidas.DataSource = New BindingSource With {.DataSource = conceptos}
                                             MNU_CONTX.Visible = True
                                         End Sub)
                           Catch ex As Exception
                               MessageBox.Show("Error al refrescar los datos: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                           End Try
                       End Sub)
    End Sub

    Private Sub TXT_BuscarSalidas_TextChanged(sender As Object, e As EventArgs) Handles TXT_BuscarSalidas.TextChanged
        RestartTimer()
    End Sub

    Private Sub CargarDGVConceptosCaja(dGV_Entradas As Guna2DataGridView, isEntrada As Boolean, text As Object)
        Throw New NotImplementedException()
    End Sub

    Private Sub BTN_Config_Click(sender As Object, e As EventArgs) Handles BTN_Config.Click
        entrarConfig(2, Me)
    End Sub

    Private Sub BTN_RegresarCat_Click(sender As Object, e As EventArgs) Handles BTN_Regresar.Click
        M_MantenimientoMenu.Show()
        M_MantenimientoMenu.Select()
        Me.Close()
    End Sub

    Private Sub C_ConceptosCaja_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        InicializarComponentes()
    End Sub

    Private Sub C_ConceptosCaja_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        REFRESCAR_ENTRADAS()
        REFRESCAR_SALIDA()
    End Sub

    Private Sub TXT_BuscarEntradas_TextChanged(sender As Object, e As EventArgs) Handles TXT_BuscarEntradas.TextChanged
        RestartTimer()
    End Sub

    Private Sub OpenAddEditConcepto(isEntrada As Boolean)
        Dim concepto As New Cls_ConceptoCaja With {
            .ID = -1,
            .isEntrada = isEntrada
        }
        ' Abre el formulario de edición con el concepto seleccionado
        Dim form As New E_NuevoConcepto With {
            .concepto = concepto
        }

        Dim result = form.ShowDialog()
        If result = DialogResult.OK Then
            REFRESCAR_ENTRADAS()
            REFRESCAR_SALIDA()
        End If
    End Sub

    Private Sub BTN_AddEntrada_Click(sender As Object, e As EventArgs) Handles BTN_AddEntrada.Click
        OpenAddEditConcepto(True)
    End Sub

    Private Sub BTN_AddSalida_Click(sender As Object, e As EventArgs) Handles BTN_AddSalida.Click
        OpenAddEditConcepto(False)
    End Sub

    Private Sub MNU_MODIFICAR_Click(sender As Object, e As EventArgs) Handles MNU_MODIFICAR.Click
        Dim clickedDGV As Control = MNU_CONTX.SourceControl
        If TypeOf clickedDGV Is Guna2DataGridView Then
            Dim dgv As Guna2DataGridView = CType(clickedDGV, Guna2DataGridView)
            ' Verifica si la fila selecionada es o no una entrada
            Dim isEntrada = dgv.SelectedRows(0).Cells(2).Value = 1
            ' Crea el objeto concepto con los datos de la fila seleccionada
            Dim concepto As New Cls_ConceptoCaja With {
                .ID = dgv.SelectedRows(0).Cells(0).Value,
                .descripcion = dgv.SelectedRows(0).Cells(1).Value,
                .isEntrada = isEntrada,
                .valorTipo = If(isEntrada, 1, -1)
            }
            ' Abre el formulario de edición con el concepto seleccionado
            Dim form As New E_NuevoConcepto With {
                .concepto = concepto
            }

            Dim result = form.ShowDialog()
            ' Si se guardaron cambios, refresca ambos DataGridView
            If result = DialogResult.OK Then
                REFRESCAR_ENTRADAS()
                REFRESCAR_SALIDA()
            End If
        End If
    End Sub

    Private Sub MNU_ELIMINAR_Click(sender As Object, e As EventArgs) Handles MNU_ELIMINAR.Click
        Dim clickedDGV As Control = MNU_CONTX.SourceControl
        If TypeOf clickedDGV Is Guna2DataGridView Then
            Dim dgv As Guna2DataGridView = CType(clickedDGV, Guna2DataGridView)
            Dim conceptoID = dgv.SelectedRows(0).Cells(0).Value

            ' Pregunta de confirmación
            Dim confirmDelete = msgEliminar("el concepto seleccionado")
            If Not confirmDelete Then
                Return
            End If

            ' Ejecuta la eliminación
            Dim deleteQuery = "DELETE FROM Conceptos_Caja WHERE ID = @ID"
            Dim param As New Dictionary(Of String, Object) From {{"ID", conceptoID}}
            Dim success = EJECUTAR_PARAMETROS(deleteQuery, param)

            If Not success Then
                msgError("Error al eliminar el concepto.")
                Return
            End If

            If clickedDGV Is DGV_Entradas Then
                REFRESCAR_ENTRADAS()
            Else
                REFRESCAR_SALIDA()
            End If
            msgDatoDel()
        End If
    End Sub

    Private Sub DGV_Salidas_DataBindingComplete(sender As Object, e As DataGridViewBindingCompleteEventArgs) Handles DGV_Salidas.DataBindingComplete
        If DGV_Salidas.Columns.Count > 0 Then
            ' Check if the column exists before trying to access it
            If DGV_Salidas.Columns.Contains("ID_Tipo_Movimiento") Then
                DGV_Salidas.Columns("ID_Tipo_Movimiento").Visible = False
            End If
            If DGV_Salidas.Columns.Contains("ID") Then
                DGV_Salidas.Columns("ID").Visible = False
            End If
        End If
    End Sub

    Private Sub DGV_Entradas_DataBindingComplete(sender As Object, e As DataGridViewBindingCompleteEventArgs) Handles DGV_Entradas.DataBindingComplete
        If DGV_Entradas.Columns.Count > 0 Then
            ' Check if the column exists before trying to access it
            If DGV_Entradas.Columns.Contains("ID_Tipo_Movimiento") Then
                DGV_Entradas.Columns("ID_Tipo_Movimiento").Visible = False
            End If
            If DGV_Entradas.Columns.Contains("ID") Then
                DGV_Entradas.Columns("ID").Visible = False
            End If
        End If
    End Sub
End Class