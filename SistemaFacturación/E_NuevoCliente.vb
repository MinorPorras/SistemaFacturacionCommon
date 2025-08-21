Public Class E_NuevoCliente
    Friend idCliente As String
    Friend ModCLi As Boolean = False
    Friend CodigoPreMod As String
    Private Correcto As Boolean

    Private Sub E_NuevoCliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If ModCLi = False Then
            idCliente = OBTENERPK("clientes", "ID")
        End If
        VALIDAR()
    End Sub

    Private Function VALIDAR()
        ' Si el texto no está vacío en el textbox habilita el botón de guardar/agregar
        If TXT_CodCliente.Text <> "" And txtNombreCliente.Text <> "" Then
            BTN_NCliente.Enabled = True
            Return True
        Else
            BTN_NCliente.Enabled = False
            Return False
        End If
    End Function

    Private Sub BTN_NCliente_Click(sender As Object, e As EventArgs) Handles BTN_NCliente.Click
        If VALIDAR() Then
            Try
                Dim codigo As String = TXT_CodCliente.Text
                If ModCLi = False Then
                    If Not EXISTECOD("clientes", "codigo", codigo) Then ' Si no se ha guardado la categoría
                        Correcto = True
                    Else
                        Correcto = False
                    End If
                Else
                    If codigo = CodigoPreMod Or Not EXISTECOD("clientes", "codigo", codigo) Then
                        Correcto = True
                    Else
                        Correcto = False
                    End If
                End If
                If Correcto Then
                    ' Comprobación de que se quiere modificar la información en la base de datos por parte del usuario
                    If msgGuardar() Then
                        Try
                            If ModCLi = False Then
                                ' Si la PK que esté guardada en IdCat no existe en la base de datos en esa tabla...
                                If EXISTEPK("clientes", "ID", idCliente) = False Then ' Si no se ha guardado la categoría
                                    ' Guarda la PK almacenada en IdCat dentro de la Base de datos en la tabla y PK indicado
                                    GUARDAR_PK("clientes", "ID", idCliente)
                                End If
                            End If
                            ' Actualizar los campos en la base de datos
                            GUARDAR_TEXT("clientes", "codigo", TXT_CodCliente.Text, "ID", idCliente)
                            GUARDAR_TEXT("clientes", "nombre", txtNombreCliente.Text, "ID", idCliente)

                            If Not String.IsNullOrEmpty(TXT_CedCliente.Text) Then
                                T.Tables.Clear()
                                SQL = "SELECT ID_Cliente FROM cliente_cedula WHERE ID_Cliente = " + idCliente
                                Cargar_Tabla(T, SQL)
                                If T.Tables(0).Rows.Count <= 0 Then
                                    GUARDAR_VarCompuestas("cliente_cedula", idCliente, TXT_CedCliente.Text)
                                Else
                                    GUARDAR_TEXT("cliente_cedula", "cedula", TXT_CedCliente.Text, "ID_Cliente", idCliente)
                                End If
                            Else
                                ELIMINAR("cliente_cedula", "ID_Cliente", idCliente)
                            End If

                            If Not String.IsNullOrEmpty(TXT_CorreoCliente.Text) Then
                                T.Tables.Clear()
                                SQL = "SELECT ID_Cliente FROM cliente_correo WHERE ID_Cliente = " + idCliente
                                Cargar_Tabla(T, SQL)
                                If T.Tables(0).Rows.Count <= 0 Then
                                    GUARDAR_VarCompuestas("cliente_correo", idCliente, TXT_CorreoCliente.Text)
                                Else
                                    GUARDAR_TEXT("cliente_correo", "correo", TXT_CorreoCliente.Text, "ID_Cliente", idCliente)
                                End If
                            Else
                                ELIMINAR("cliente_correo", "ID_Cliente", idCliente)
                            End If

                            If Not String.IsNullOrEmpty(TXT_TelCliente.Text) Then
                                T.Tables.Clear()
                                SQL = "SELECT ID_Cliente FROM cliente_telefono WHERE ID_Cliente = " + idCliente
                                Cargar_Tabla(T, SQL)
                                If T.Tables(0).Rows.Count <= 0 Then
                                    GUARDAR_VarCompuestas("cliente_telefono", idCliente, TXT_TelCliente.Text)
                                Else
                                    GUARDAR_TEXT("cliente_telefono", "telefono", TXT_TelCliente.Text, "ID_Cliente", idCliente)
                                End If
                            Else
                                ELIMINAR("cliente_telefono", "ID_Cliente", idCliente)
                            End If
                            LIMPIAR()
                            msgDatoAlm()
                            ' Muestra y refresca la pantalla del list view de Sucursales y cierra esta
                            P_Clientes.Show()
                            P_Clientes.Select()
                            P_Clientes.REFRESCAR()
                            P_Clientes.TXT_BuscarCliente.SelectAll()
                            Me.Close()
                        Catch ex As Exception
                            msgError("Error al actualizar los datos: " & ex.Message)
                        End Try
                    End If
                Else
                    msgError("El código " + TXT_CodCliente.Text + " ya existe, coloque un código distinto")
                    TXT_CodCliente.SelectAll()
                End If
            Catch ex As Exception
                msgError("Error: " & ex.Message)
            End Try
        End If
    End Sub

    Friend Sub LIMPIAR()
        TXT_CodCliente.Clear()
        TXT_CedCliente.Clear()
        txtNombreCliente.Clear()
        TXT_TelCliente.Clear()
        TXT_CorreoCliente.Clear()
    End Sub

    Private Sub BTN_RegresarCliente_Click(sender As Object, e As EventArgs) Handles BTN_RegresarCliente.Click
        P_Clientes.REFRESCAR()
        P_Clientes.TXT_BuscarCliente.SelectAll()
        P_Clientes.Show()
        P_Clientes.Select()
        Me.Close()
    End Sub

    Private Sub TXT_CodCliente_TextChanged(sender As Object, e As EventArgs) Handles TXT_CodCliente.TextChanged
        VALIDAR()
    End Sub

    Private Sub txtNombreCliente_TextChanged(sender As Object, e As EventArgs) Handles txtNombreCliente.TextChanged
        VALIDAR()
    End Sub

    Private Sub TXT_TelCliente_TextChanged(sender As Object, e As EventArgs) Handles TXT_TelCliente.TextChanged
        VALIDAR()
    End Sub

    Private Sub TXT_CorreoCliente_TextChanged(sender As Object, e As EventArgs) Handles TXT_CorreoCliente.TextChanged
        VALIDAR()
    End Sub

    Private Sub BTN_AutoCod_Click(sender As Object, e As EventArgs) Handles BTN_AutoCod.Click
        ' Obtener todos los códigos existentes
        Dim codigosExistentes As List(Of Integer) = ObtenerCodigosExistentes("clientes", "codigo")
        ' Ordenarlos
        codigosExistentes.Sort()

        ' Número de dígitos según configuración
        Dim numConfig As Integer = Integer.Parse(Md_Inicializacion.GetAppSetting("AutoCodCliente"))

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
        TXT_CodCliente.Text = CodActual
    End Sub
End Class