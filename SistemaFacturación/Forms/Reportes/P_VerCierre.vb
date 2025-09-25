Imports System.Data.SQLite
Imports System.Globalization
Imports SistemaFacturaciónCommon.SistemaFacturacion.Data
Imports SistemaFacturaciónCommon.SistemaFacturacion.Forms.Dialogos
Imports SistemaFacturaciónCommon.SistemaFacturacion.Modules

Namespace SistemaFacturacion.Forms.Reportes

    Public Class P_VerCierre
        Private searchTimer As Timer
        Private Sub P_VerCierre_Load(sender As Object, e As EventArgs) Handles MyBase.Load
            InicializarComponentes()
            ReiniciarTemporizador()
        End Sub

        ' Método para inicializar el temporizador y otros componentes necesarios
        Private Sub InicializarComponentes()
            'Se establece el filtro de la busqueda en desabilitado inicialmente para que muestre todos los cierres
            SWT_ActivateDateSearch.Checked = False
            DTP_Desde.Enabled = False
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
            REFRESCAR()
        End Sub

        Private Sub REFRESCAR()
            Task.Run(Sub()
                         T.Tables.Clear()
                         'Se inicializa el comando SQL para obtener la información
                         SQL = "SELECT 
	                            cc.ID_Cierre , 
	                            cc.Fecha_Hora_Inicio As 'Hora Inicio', 
	                            cc.Fecha_Hora_Fin As 'Hora fin', 
	                            u.ID , 
	                            U.usuario As 'Cajero', 
	                            cc.Saldo_Inicial As 'Saldo Inicial', 
	                            cc.Ingreso_Efectivo As 'Ing. Efectivo', 
	                            cc.Ingreso_Tarjeta As 'Ing. Tarjeta', 
	                            cc.Salidas_Efectivo As 'Salidas', 
	                            cc.Efectivo_Contado As 'Efectivo contado', 
	                            cc.Saldo_Siguiente_Turno As 'Saldo siguiente', 
	                            cc.Comentarios As 'Comentario'
                            FROM 
	                            CierreCaja cc 
                            INNER JOIN 
	                            usuario u ON U.ID = CC.ID_Usuario 
                            WHERE
                                (@comentario IS NULL OR CC.Comentarios LIKE '%' || @comentario || '%') AND
                                (@fecha IS NULL OR DATE(CC.Fecha_Hora_Fin) = DATE(@fecha) OR DATE(CC.Fecha_Hora_Inicio) = DATE(@fecha))"

                         'Se crea el parámetro para el comentario y para la fecha
                         Dim comentario As New SQLiteParameter("@comentario")
                         Dim fecha As New SQLiteParameter("@fecha")

                         ' Si el campo de texto está vacío, el parámetro es NULL.
                         ' Esto le indica a la consulta SQL que ignore el filtro.
                         If String.IsNullOrWhiteSpace(TXT_BuscarComentario.Text) Then
                             comentario.Value = DBNull.Value
                         Else
                             ' Se agrega la búsqueda por patrón LIKE para ser más flexible
                             comentario.Value = TXT_BuscarComentario.Text
                         End If

                         ' Si el switch no está marcado, se ignora la fecha en el filtro
                         If SWT_ActivateDateSearch.Checked Then
                             fecha.Value = DTP_Desde.Value
                         Else
                             fecha.Value = DBNull.Value
                         End If

                         ' Se crea una lista para almacenar los parámetros
                         'Se añaden los parémtros a la lista
                         Dim paramList As New List(Of SQLiteParameter) From {
                             comentario,
                             fecha
                         }

                         ' Verificamos si la invocación es necesaria
                         Invoke(Sub()
                                    'Se carga la tabla con esa lista de parámetros indicado
                                    CargarTablaParam(T, SQL, paramList)

                                    Dim bin As New BindingSource With {
                                       .DataSource = T.Tables(0)
                                    }
                                    DGV_ListaCierres.DataSource = bin

                                    ' Mueve las siguientes dos líneas al final
                                    DGV_ListaCierres.Columns(0).Visible = False
                                    DGV_ListaCierres.Columns(3).Visible = False

                                    ' Agrega Refresh() para forzar la actualización después de todo
                                    DGV_ListaCierres.Refresh()
                                End Sub)
                     End Sub)
        End Sub

        Private Sub DGV_ListaCierres_DataBindingComplete(sender As Object, e As DataGridViewBindingCompleteEventArgs) Handles DGV_ListaCierres.DataBindingComplete
            ' Verificamos que existan al menos 11 columnas para evitar errores de índice
            If DGV_ListaCierres.Columns.Count >= 11 Then
                ' Oculta las columnas de ID, si es necesario
                DGV_ListaCierres.Columns(0).Visible = False
                DGV_ListaCierres.Columns(3).Visible = False

                ' Bucle para formatear las columnas de la 5 a la 10
                For i As Integer = 5 To 10
                    ' Aplica el formato de moneda de Costa Rica
                    DGV_ListaCierres.Columns(i).DefaultCellStyle.Format = "C"
                    DGV_ListaCierres.Columns(i).DefaultCellStyle.FormatProvider = New CultureInfo("es-CR")
                Next
            End If
        End Sub

        Private Sub BTN_RegresarReporte_Click(sender As Object, e As EventArgs) Handles BTN_RegresarReporte.Click
            Owner.Select()
            Me.Close()
        End Sub

        Private Sub SWT_ActivateDateSearch_CheckedChanged(sender As Object, e As EventArgs) Handles SWT_ActivateDateSearch.CheckedChanged
            If SWT_ActivateDateSearch.Checked Then
                DTP_Desde.Enabled = True
            Else
                DTP_Desde.Enabled = False
            End If
        End Sub

        Private Sub DTP_Desde_ValueChanged(sender As Object, e As EventArgs) Handles DTP_Desde.ValueChanged
            ReiniciarTemporizador()
        End Sub

        Private Sub TXT_BuscarComentario_TextChanged(sender As Object, e As EventArgs) Handles TXT_BuscarComentario.TextChanged
            ReiniciarTemporizador()
        End Sub

        Private Sub ReiniciarTemporizador()
            If searchTimer IsNot Nothing Then
                ' Reiniciar el temporizador cada vez que se cambia el texto
                searchTimer.Stop()
                searchTimer.Start()
            End If
        End Sub

        Private Sub MNU_Datos_Click(sender As Object, e As EventArgs) Handles MNU_Datos.Click
            'Dim datosCierre As New Cls_CierreCaja With {
            '    .fecha_inicio = DGV_ListaCierres.SelectedRows(0).Cells(1).Value,
            '    .fecha_fin = DGV_ListaCierres.SelectedRows(0).Cells(2).Value,
            '    .Cajero = DGV_ListaCierres.SelectedRows(0).Cells(4).Value,
            '    .saldo_inicial = DGV_ListaCierres.SelectedRows(0).Cells(5).Value,
            '    .ingresoEfectivo = DGV_ListaCierres.SelectedRows(0).Cells(6).Value,
            '    .ingresoTarjeta = DGV_ListaCierres.SelectedRows(0).Cells(7).Value,
            '    .salidasEfectivo = DGV_ListaCierres.SelectedRows(0).Cells(8).Value,
            '    .efectivoContado = DGV_ListaCierres.SelectedRows(0).Cells(9).Value,
            '    .saldoSiguiente = DGV_ListaCierres.SelectedRows(0).Cells(10).Value,
            '    .comentarios = DGV_ListaCierres.SelectedRows(0).Cells(11).Value
            '}

            'Using frmVerDatos As New D_VerDatosCierre
            '    frmVerDatos.Owner = Me
            '    frmVerDatos.datosCierre = datosCierre
            '    frmVerDatos.ShowDialog()
            'End Using
        End Sub
    End Class

End Namespace