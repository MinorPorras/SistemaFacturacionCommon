Public Class E_NuevoProveedor
    Friend ColorProv As String
    Friend idProv As String
    Friend ModProv As Boolean = False
    Friend CodigoPreMod As String
    Friend LHacerPed As New List(Of String)()
    Friend LRebPed As New List(Of String)()
    Dim Correcto As Boolean


    Private Sub E_NuevaCat_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TXT_CodigoProv.Select()
        If ModProv = False Then
            idProv = OBTENERPK("proveedor", "ID")
        End If
        VALIDAR()
    End Sub

    Private Function VALIDAR()
        ' Si el texto no está vacío en el textbox habilita el botón de guardar/agregar
        If TXT_CodigoProv.Text <> "" And TXT_NombreProv.Text <> "" Then
            BTN_NProv.Enabled = True
            BTN_Pedidos.Enabled = True
            Return True
        Else
            BTN_NProv.Enabled = False
            BTN_Pedidos.Enabled = False
            Return False
        End If
    End Function

    Private Sub BTN_RegresarNCat_Click(sender As Object, e As EventArgs) Handles BTN_RegresarProv.Click
        P_Proveedor.Show()
        P_Proveedor.Select()
        P_Proveedor.TXT_BuscarProv.SelectAll()
        Me.Close()
    End Sub

    Private Sub BTN_NCat_Click(sender As Object, e As EventArgs) Handles BTN_NProv.Click
        If VALIDAR() Then
            Try
                Dim codigo As String = TXT_CodigoProv.Text
                If ModProv = False Then
                    If Not EXISTECOD("proveedor", "codigo", codigo) Then ' Si no se ha guardado la categoría
                        Correcto = True
                    Else
                        Correcto = False
                    End If
                Else
                    If codigo = CodigoPreMod Or Not EXISTECOD("proveedor", "codigo", codigo) Then
                        Correcto = True
                    Else
                        Correcto = False
                    End If
                End If
                If Correcto Then
                    ' Comprobación de que se quiere modificar la información en la base de datos por parte del usuario
                    If msgGuardar() Then
                        Try
                            If ModProv = False Then
                                ' Si la PK que esté guardada en IdCat no existe en la base de datos en esa tabla...
                                If EXISTEPK("proveedor", "ID", idProv) = False Then ' Si no se ha guardado la categoría
                                    ' Guarda la PK almacenada en IdCat dentro de la Base de datos en la tabla y PK indicado
                                    GUARDAR_PK("proveedor", "ID", idProv)
                                End If
                            End If
                            ' Actualizar los campos en la base de datos
                            GUARDAR_TEXT("proveedor", "codigo", TXT_CodigoProv.Text, "ID", idProv)
                            GUARDAR_TEXT("proveedor", "nombre", TXT_NombreProv.Text, "ID", idProv)

                            If Not String.IsNullOrEmpty(TXT_CorreoProv.Text) Then
                                T.Tables.Clear()
                                SQL = "SELECT ID_Proveedor FROM proveedor_correo WHERE ID_Proveedor = " + idProv
                                Cargar_Tabla(T, SQL)
                                If T.Tables(0).Rows.Count <= 0 Then
                                    GUARDAR_VarCompuestas("proveedor_correo", idProv, TXT_CorreoProv.Text)
                                Else
                                    GUARDAR_TEXT("proveedor_correo", "correo", TXT_CorreoProv.Text, "ID_Proveedor", idProv)
                                End If
                            Else
                                ELIMINAR("proveedor_correo", "ID_Proveedor", idProv)
                            End If

                            If Not String.IsNullOrEmpty(TXT_TelProv.Text) Then
                                T.Tables.Clear()
                                SQL = "SELECT ID_Proveedor FROM proveedor_telefono WHERE ID_Proveedor = " + idProv
                                Cargar_Tabla(T, SQL)
                                If T.Tables(0).Rows.Count <= 0 Then
                                    GUARDAR_VarCompuestas("proveedor_telefono", idProv, TXT_TelProv.Text)
                                Else
                                    GUARDAR_TEXT("proveedor_telefono", "telefono", TXT_TelProv.Text, "ID_Proveedor", idProv)
                                End If
                            Else
                                ELIMINAR("proveedor_telefono", "ID_Proveedor", idProv)
                            End If

                            T.Tables.Clear()
                            SQL = "SELECT p.ID_Proveedor, p.dia_pedido FROM proveedor_diaPedido p WHERE p.ID_Proveedor = " & idProv
                            Cargar_Tabla(T, SQL)
                            If T.Tables(0).Rows.Count > 0 Then
                                ELIMINAR("proveedor_diaPedido", "ID_Proveedor", idProv)
                            End If
                            For i As Integer = 0 To LHacerPed.Count - 1
                                GUARDAR_VarCompuestas("proveedor_diaPedido", idProv, LHacerPed(i))
                            Next

                            T.Tables.Clear()
                            SQL = "SELECT r.ID_Proveedor, r.dia_recibido FROM proveedor_recibirPedido r WHERE r.ID_Proveedor = " & idProv
                            Cargar_Tabla(T, SQL)
                            If T.Tables(0).Rows.Count > 0 Then
                                ELIMINAR("proveedor_recibirPedido", "ID_Proveedor", idProv)
                            End If
                            For i As Integer = 0 To LRebPed.Count - 1
                                GUARDAR_VarCompuestas("proveedor_recibirPedido", idProv, LRebPed(i))
                            Next

                            LIMPIAR()
                            msgDatoAlm()
                            ' Muestra y refresca la pantalla del list view de Sucursales y cierra esta
                            P_Proveedor.Show()
                            P_Proveedor.Select()
                            P_Proveedor.REFRESCAR()
                            P_Proveedor.TXT_BuscarProv.SelectAll()
                            Me.Close()
                        Catch ex As Exception
                            msgError("Error al actualizar los datos: " & ex.Message)
                        End Try
                    End If
                Else
                    msgError("El código " + TXT_CodigoProv.Text + " ya existe, coloque un código distinto")
                    TXT_CodigoProv.SelectAll()
                End If
            Catch ex As Exception
                msgError("Error: " & ex.Message)
            End Try
        End If
    End Sub

    Friend Sub LIMPIAR()
        TXT_CodigoProv.Clear()
        TXT_NombreProv.Clear()
        TXT_CorreoProv.Clear()
        TXT_TelProv.Clear()
        LHacerPed.Clear()
        LRebPed.Clear()
    End Sub

    Private Sub TXT_NombreMarca_TextChanged(sender As Object, e As EventArgs) Handles TXT_NombreProv.TextChanged
        VALIDAR()
    End Sub

    Private Sub BTN_Pedidos_Click(sender As Object, e As EventArgs) Handles BTN_Pedidos.Click
        E_ProveedorPedido.LBL_Proveedor.Text = TXT_NombreProv.Text
        E_ProveedorPedido.Show()
        E_ProveedorPedido.Select()
    End Sub

    Private Sub BTN_AutoCod_Click(sender As Object, e As EventArgs) Handles BTN_AutoCod.Click
        ' Obtener todos los códigos existentes
        Dim codigosExistentes As List(Of Integer) = ObtenerCodigosExistentes("proveedor", "codigo")
        ' Ordenarlos
        codigosExistentes.Sort()

        ' Número de dígitos según configuración
        Dim numConfig As Integer = Integer.Parse(Md_Inicializacion.GetAppSetting("AutoCodProv"))

        ' Encontrar el primer número que no esté en uso
        Dim codigoDisponible As Integer = 1
        For Each codigo In codigosExistentes
            If codigo = codigoDisponible Then
                codigoDisponible += 1
            ElseIf codigo > codigoDisponible Then
                Exit For
            End If
        Next

        ' Formatear el código disponible con ceros a la izquierda según numConfig
        Dim CodActual As String = codigoDisponible.ToString("D" & numConfig)
        TXT_CodigoProv.Text = CodActual
    End Sub
End Class