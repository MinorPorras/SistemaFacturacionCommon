Public Class E_NuevaMarca
    Friend ColorMarca As String
    Friend idMarca As String
    Friend ModMarca As Boolean = False
    Friend CodigoPreMod As String
    Private Correcto As Boolean

    Private Sub E_NuevaCat_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If ModMarca = False Then
            idMarca = OBTENERPK("marca", "ID")
        End If
        VALIDAR()
    End Sub

    Private Function VALIDAR()
        ' Si el texto no está vacío en el textbox habilita el botón de guardar/agregar
        If TXT_CodMarca.Text <> "" And TXT_NombreMarca.Text <> "" Then
            BTN_NMarca.Enabled = True
            Return True
        Else
            BTN_NMarca.Enabled = False
            Return False
        End If

    End Function

    Private Sub BTN_RegresarNCat_Click(sender As Object, e As EventArgs) Handles BTN_RegresarMarca.Click
        P_Marca.Show()
        P_Marca.Select()
        P_Marca.TXT_BuscarMarca.SelectAll()
        Me.Close()
    End Sub

    Private Sub BTN_NCat_Click(sender As Object, e As EventArgs) Handles BTN_NMarca.Click
        If VALIDAR() Then
            Try
                Dim codigo As String = TXT_CodMarca.Text
                If ModMarca = False Then
                    If Not EXISTECOD("marca", "codigo", codigo) Then ' Si no se ha guardado la categoría
                        Correcto = True
                    Else
                        Correcto = False
                    End If
                Else
                    If codigo = CodigoPreMod Or Not EXISTECOD("marca", "codigo", codigo) Then
                        Correcto = True
                    Else
                        Correcto = False
                    End If
                End If
                If Correcto Then
                    ' Comprobación de que se quiere modificar la información en la base de datos por parte del usuario
                    If msgGuardar() Then
                        Try
                            If ModMarca = False Then
                                ' Si la PK que esté guardada en IdCat no existe en la base de datos en esa tabla...
                                If EXISTEPK("marca", "ID", idMarca) = False Then ' Si no se ha guardado la categoría
                                    ' Guarda la PK almacenada en IdCat dentro de la Base de datos en la tabla y PK indicado
                                    GUARDAR_PK("marca", "ID", idMarca)
                                End If
                            End If
                            ' Actualizar los campos en la base de datos
                            GUARDAR_TEXT("marca", "codigo", TXT_CodMarca.Text, "ID", idMarca)
                            GUARDAR_TEXT("marca", "nombre", TXT_NombreMarca.Text, "ID", idMarca)
                            LIMPIAR()
                            msgDatoAlm()
                            ' Muestra y refresca la pantalla del list view de Sucursales y cierra esta
                            P_Marca.Show()
                            P_Marca.Select()
                            P_Marca.REFRESCAR()
                            P_Marca.TXT_BuscarMarca.SelectAll()
                            Me.Close()
                        Catch ex As Exception
                            msgError("Error al actualizar los datos: " & ex.Message)
                        End Try
                    End If
                Else
                    msgError("El código " + TXT_CodMarca.Text + " ya existe, coloque un código distinto")
                    TXT_CodMarca.SelectAll()
                End If
            Catch ex As Exception
                msgError("Error: " & ex.Message)
            End Try
        End If
    End Sub

    Friend Sub LIMPIAR()
        TXT_CodMarca.Clear()
        TXT_NombreMarca.Clear()
    End Sub

    Private Sub TXT_NombreMarca_TextChanged(sender As Object, e As EventArgs) Handles TXT_NombreMarca.TextChanged
        VALIDAR()
    End Sub

    Private Sub TXT_CodMarca_TextChanged(sender As Object, e As EventArgs) Handles TXT_CodMarca.TextChanged
        VALIDAR()
    End Sub

    Private Sub BTN_AutoCod_Click(sender As Object, e As EventArgs) Handles BTN_AutoCod.Click
        ' Obtener todos los códigos existentes
        Dim codigosExistentes As List(Of Integer) = ObtenerCodigosExistentes("marca", "codigo")
        ' Ordenarlos
        codigosExistentes.Sort()

        ' Número de dígitos según configuración
        Dim numConfig As Integer = Integer.Parse(Md_Inicializacion.GetAppSetting("AutoCodMarca"))

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
        TXT_CodMarca.Text = CodActual
    End Sub
End Class