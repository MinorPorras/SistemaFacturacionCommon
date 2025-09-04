Imports System.Configuration
Imports System.Threading.Tasks
Imports System.Drawing

Public Class M_Inicio
    Dim LArray As String()
    Dim MArray As String()
    Dim XArray As String()
    Dim JArray As String()
    Dim VArray As String()
    Dim SArray As String()
    Dim DArray As String()

    Dim Lcont As Integer
    Dim Mcont As Integer
    Dim Xcont As Integer
    Dim Jcont As Integer
    Dim Vcont As Integer
    Dim Scont As Integer
    Dim Dcont As Integer

    Private Sub Inicio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        REFRESCAR()
    End Sub

    Friend Sub REFRESCAR()
        If Not CuentaAdmin Then
            BTN_Config.Enabled = False
            BTN_Mantenimiento.Enabled = False
            BTN_Reporte.Enabled = False
        Else
            BTN_Config.Enabled = True
            BTN_Mantenimiento.Enabled = True
            'Se coloca en False ya que la función aún no esta implementada
            BTN_Reporte.Enabled = True
        End If
        LBL_Sucursal.Text = "Sucursal: " + ConfigurationManager.AppSettings("Empresa").ToString()
        LBL_Telefono.Text = "Telefono: " + ConfigurationManager.AppSettings("Telefono").ToString()
        LBL_Email.Text = "Email: " + ConfigurationManager.AppSettings("Correo").ToString()
        Try
            PIC_Logo.Image = Image.FromFile(ConfigurationManager.AppSettings("Logo").ToString())
        Catch ex As Exception
            Console.WriteLine("No se encontró la imagen")
        End Try
        Task.Run(Sub()
                     cargarCalProveedores("dia_pedido", "proveedor_diaPedido")
                 End Sub)
        Task.Run(Sub()
                     cargarCalProveedores("dia_recibido", "proveedor_recibirPedido")
                 End Sub)
        CargarEstilosDGV()
        LBL_Usu.Text = nomUsuActual
    End Sub

    Friend Sub cargarCalProveedores(tipoPed As String, tabla As String)
        Task.Run(Sub()
                     Try
                         Invoke(Sub()
                                    ' Crear una nueva DataTable independiente para cada hilo

                                    Dim T_Hilo As New DataSet

                                    ' Construir la consulta SQL
                                    SQL = "SELECT p.ID, p.nombre, d." & tipoPed & " FROM proveedor p INNER JOIN " & tabla & " d ON p.ID = d.ID_Proveedor;"
                                    Cargar_Tabla(T_Hilo, SQL)
                                    ' Se eliminan todos los datos de los arrays
                                    ReDim LArray(0)
                                    ReDim MArray(0)
                                    ReDim XArray(0)
                                    ReDim JArray(0)
                                    ReDim VArray(0)
                                    ReDim SArray(0)
                                    ReDim DArray(0)

                                    ' Se ponen todos los contadores a 0
                                    Lcont = 0
                                    Mcont = 0
                                    Xcont = 0
                                    Jcont = 0
                                    Vcont = 0
                                    Scont = 0
                                    Dcont = 0

                                    ' Llenar los arrays con nuevos datos
                                    For i As Integer = 0 To T_Hilo.Tables(0).Rows().Count - 1
                                        Dim dia As String = T_Hilo.Tables(0).Rows(i).Item(2).ToString()
                                        Select Case dia
                                            Case "Lunes"
                                                ReDim Preserve LArray(Lcont)
                                                LArray(Lcont) = T_Hilo.Tables(0).Rows(i).Item(1).ToString()
                                                Lcont += 1
                                            Case "Martes"
                                                ReDim Preserve MArray(Mcont)
                                                MArray(Mcont) = T_Hilo.Tables(0).Rows(i).Item(1).ToString()
                                                Mcont += 1
                                            Case "Miércoles"
                                                ReDim Preserve XArray(Xcont)
                                                XArray(Xcont) = T_Hilo.Tables(0).Rows(i).Item(1).ToString()
                                                Xcont += 1
                                            Case "Jueves"
                                                ReDim Preserve JArray(Jcont)
                                                JArray(Jcont) = T_Hilo.Tables(0).Rows(i).Item(1).ToString()
                                                Jcont += 1
                                            Case "Viernes"
                                                ReDim Preserve VArray(Vcont)
                                                VArray(Vcont) = T_Hilo.Tables(0).Rows(i).Item(1).ToString()
                                                Vcont += 1
                                            Case "Sábado"
                                                ReDim Preserve SArray(Scont)
                                                SArray(Scont) = T_Hilo.Tables(0).Rows(i).Item(1).ToString()
                                                Scont += 1
                                            Case "Domingo"
                                                ReDim Preserve DArray(Dcont)
                                                DArray(Dcont) = T_Hilo.Tables(0).Rows(i).Item(1).ToString()
                                                Dcont += 1
                                        End Select
                                    Next

                                    ' Se encuentra el array más largo de los 7
                                    Dim arraymas As String()
                                    Dim Arraymascont As Integer = 0

                                    For Each arr As String() In {LArray, MArray, XArray, JArray, VArray, SArray, DArray}
                                        If arr.Length > Arraymascont Then
                                            arraymas = arr
                                            Arraymascont = arr.Length
                                        End If
                                    Next

                                    ' Se redimensionan todos los arrays al del más grande para que tengan el mismo tamaño
                                    ReDim Preserve LArray(Arraymascont - 1)
                                    ReDim Preserve MArray(Arraymascont - 1)
                                    ReDim Preserve XArray(Arraymascont - 1)
                                    ReDim Preserve JArray(Arraymascont - 1)
                                    ReDim Preserve VArray(Arraymascont - 1)
                                    ReDim Preserve SArray(Arraymascont - 1)
                                    ReDim Preserve DArray(Arraymascont - 1)

                                    ' Limpiar los ítems del DataGridView correspondiente
                                    If tabla = "proveedor_diaPedido" Then
                                        DGV_LHacerPed.Rows.Clear()
                                    ElseIf tabla = "proveedor_recibirPedido" Then
                                        DGV_LRebPed.Rows.Clear()
                                    End If

                                    ' Añadir los ítems al DataGridView correspondiente
                                    For i As Integer = 0 To Arraymascont - 1
                                        ' Verificar que el índice está dentro del rango antes de acceder a los arrays
                                        If i < LArray.Length OrElse i < MArray.Length OrElse i < XArray.Length OrElse i < JArray.Length OrElse i < VArray.Length OrElse i < SArray.Length OrElse i < DArray.Length Then
                                            If tabla = "proveedor_diaPedido" Then
                                                DGV_LHacerPed.Rows.Add(If(i < LArray.Length, LArray(i), ""),
                                                                   If(i < MArray.Length, MArray(i), ""),
                                                                   If(i < XArray.Length, XArray(i), ""),
                                                                   If(i < JArray.Length, JArray(i), ""),
                                                                   If(i < VArray.Length, VArray(i), ""),
                                                                   If(i < SArray.Length, SArray(i), ""),
                                                                   If(i < DArray.Length, DArray(i), ""))
                                            ElseIf tabla = "proveedor_recibirPedido" Then
                                                DGV_LRebPed.Rows.Add(If(i < LArray.Length, LArray(i), ""),
                                                                 If(i < MArray.Length, MArray(i), ""),
                                                                 If(i < XArray.Length, XArray(i), ""),
                                                                 If(i < JArray.Length, JArray(i), ""),
                                                                 If(i < VArray.Length, VArray(i), ""),
                                                                 If(i < SArray.Length, SArray(i), ""),
                                                                 If(i < DArray.Length, DArray(i), ""))
                                            End If
                                        End If
                                    Next
                                End Sub)

                     Catch ex As Exception
                         Invoke(Sub()
                                    msgError("Error: " & ex.Message)
                                End Sub)
                     End Try
                 End Sub)
    End Sub

    Private Sub CargarEstilosDGV()
        DGV_LHacerPed.ColumnHeadersDefaultCellStyle.Font = New Font("Microsoft Sans Serif", 9.75, FontStyle.Bold)
        DGV_LHacerPed.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        DGV_LHacerPed.GridColor = Color.FromArgb(231, 229, 255)
        DGV_LHacerPed.ThemeStyle.AlternatingRowsStyle.Font = New Font("Microsoft Sans Serif", 8.25)
        DGV_LHacerPed.ThemeStyle.RowsStyle.Font = New Font("Microsoft Sans Serif", 8.25)
        DGV_LHacerPed.DefaultCellStyle.Font = New Font("Microsoft Sans Serif", 8.25)
        DGV_LHacerPed.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

        DGV_LRebPed.ColumnHeadersDefaultCellStyle.Font = New Font("Microsoft Sans Serif", 9.75, FontStyle.Bold)
        DGV_LRebPed.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        DGV_LRebPed.GridColor = Color.FromArgb(231, 229, 255)
        DGV_LRebPed.ThemeStyle.AlternatingRowsStyle.Font = New Font("Microsoft Sans Serif", 8.25)
        DGV_LRebPed.ThemeStyle.RowsStyle.Font = New Font("Microsoft Sans Serif", 8.25)
        DGV_LRebPed.DefaultCellStyle.Font = New Font("Microsoft Sans Serif", 8.25)
        DGV_LRebPed.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
    End Sub

    Private Sub BTN_CerrarApp_Click(sender As Object, e As EventArgs) Handles BTN_CerrarApp.Click
        msgCerrarApp()

    End Sub

    Private Sub BTN_Mantenimiento_Click(sender As Object, e As EventArgs) Handles BTN_Mantenimiento.Click
        M_Mantenimiento.Show()
        M_Mantenimiento.Select()
        Me.Close()
    End Sub

    Private Sub BTN_Reporte_Click(sender As Object, e As EventArgs) Handles BTN_Reporte.Click
        P_ReporteVentas.Show()
        P_ReporteVentas.Select()
        Me.Close()
    End Sub

    Private Sub Inicio_KeyPress(sender As Object, e As KeyPressEventArgs) Handles MyBase.KeyPress
        If e.KeyChar = "1"c Then
            BTN_Mantenimiento.PerformClick()
        ElseIf e.KeyChar = "2"c Then
            BTN_Reporte.PerformClick()
        ElseIf e.KeyChar = "3"c Then
            BTN_CajaVenta.PerformClick()
        End If
    End Sub
    Private Sub BTN_CajaVenta_Click_1(sender As Object, e As EventArgs) Handles BTN_CajaVenta.Click
        P_Caja.Show()
        P_Caja.Select()
        P_Caja.LBL_Usu.Text = nomUsuActual
        P_Caja.idUsu = idUsuActual
        Me.Close()
    End Sub

    Private Sub BTN_Config_Click(sender As Object, e As EventArgs) Handles BTN_Config.Click
        entrarConfig(0)
    End Sub

    Private Sub BTN_LogOut_Click(sender As Object, e As EventArgs) Handles BTN_LogOut.Click
        LBL_Usu.Text = ""
        P_SelectUsu.Show()
        P_SelectUsu.Select()
        Me.Close()
    End Sub
End Class
