Public Class E_NuevaCategoria
    Friend ColorCat As String
    Friend idCat As String
    Friend ModCat As Boolean = False
    Friend CodigoPreMod As String
    Private Correcto As Boolean

    Private Sub E_NuevaCat_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If ModCat = False Then
            idCat = OBTENERPK("categoria", "ID")
        End If
        VALIDAR()
    End Sub


    Private Sub BTN_Color_Click(sender As Object, e As EventArgs) Handles BTN_Color.Click
        Try
            If ColorDialog1.ShowDialog() = DialogResult.OK Then
                BTN_Color.FillColor = ColorDialog1.Color
                ColorCat = Convert.ToString(ColorDialog1.Color.R) + "," + Convert.ToString(ColorDialog1.Color.G) + "," + Convert.ToString(ColorDialog1.Color.B)
            End If
            VALIDAR()
        Catch ex As Exception
            msgError("Error: " & ex.Message)
        End Try

    End Sub

    Private Function VALIDAR()
        ' Si el texto no está vacío en el textbox habilita el botón de guardar/agregar
        If TXT_CodCat.Text <> "" And TXT_NombreCat.Text <> "" Then
            BTN_NCat.Enabled = True
            Return True
        Else
            BTN_NCat.Enabled = False
            Return False
        End If

    End Function

    Private Sub BTN_RegresarNCat_Click(sender As Object, e As EventArgs) Handles BTN_RegresarCat.Click
        P_Categoria.Show()
        P_Categoria.Select()
        P_Categoria.TXT_BuscarCat.SelectAll()
        Me.Close()
    End Sub

    Private Sub BTN_NCat_Click(sender As Object, e As EventArgs) Handles BTN_NCat.Click
        If VALIDAR() Then
            Try
                Dim codigo As String = TXT_CodCat.Text
                If ModCat = False Then
                    If Not EXISTECOD("categoria", "codigo", codigo) Then ' Si no se ha guardado la categoría
                        Correcto = True
                    Else
                        Correcto = False
                    End If
                Else
                    If codigo = CodigoPreMod Or Not EXISTECOD("categoria", "codigo", codigo) Then
                        Correcto = True
                    Else
                        Correcto = False
                    End If
                End If
                If Correcto Then
                    ' Comprobación de que se quiere modificar la información en la base de datos por parte del usuario
                    If msgGuardar() Then
                        Try
                            If ModCat = False Then
                                ' Si la PK que esté guardada en IdCat no existe en la base de datos en esa tabla...
                                If EXISTEPK("categoria", "ID", idCat) = False Then ' Si no se ha guardado la categoría
                                    ' Guarda la PK almacenada en IdCat dentro de la Base de datos en la tabla y PK indicado
                                    GUARDAR_PK("categoria", "ID", idCat)
                                End If
                            End If
                            ' Actualizar los campos en la base de datos
                            GUARDAR_TEXT("categoria", "codigo", TXT_CodCat.Text, "ID", idCat)
                            GUARDAR_TEXT("categoria", "nombre", TXT_NombreCat.Text, "ID", idCat)
                            If String.IsNullOrEmpty(ColorCat) Then
                                GUARDAR_TEXT("categoria", "color", "0,0,0", "ID", idCat)
                            Else
                                GUARDAR_TEXT("categoria", "color", ColorCat, "ID", idCat)
                            End If
                            LIMPIAR()
                            msgDatoAlm()
                            ' Muestra y refresca la pantalla del list view de Sucursales y cierra esta
                            P_Categoria.Show()
                            P_Categoria.Select()
                            P_Categoria.REFRESCAR()
                            P_Categoria.TXT_BuscarCat.Select()
                            P_Categoria.TXT_BuscarCat.SelectAll()
                            Me.Close()
                        Catch ex As Exception
                            msgError("Error al actualizar los datos: " & ex.Message)
                        End Try
                    End If
                Else
                    msgError("El código " + TXT_CodCat.Text + " ya existe, coloque un código distinto")
                    TXT_CodCat.Select()
                    TXT_CodCat.SelectAll()
                End If
            Catch ex As Exception
                msgError("Error: " & ex.Message)
            End Try
        End If
    End Sub

    Friend Sub LIMPIAR()
        TXT_CodCat.Clear()
        TXT_NombreCat.Clear()
        BTN_Color.BackColor = Color.White
        ColorDialog1.Color = Color.White
    End Sub

    Private Sub BTN_AutoCod_Click(sender As Object, e As EventArgs) Handles BTN_AutoCod.Click
        ' Obtener todos los códigos existentes
        Dim codigosExistentes As List(Of Integer) = ObtenerCodigosExistentes("categoria", "codigo")
        ' Ordenarlos
        codigosExistentes.Sort()

        ' Número de dígitos según configuración
        Dim numConfig As Integer = Integer.Parse(Md_Inicializacion.GetAppSetting("AutoCodCat"))

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
        TXT_CodCat.Text = CodActual
        Md_Inicializacion.SetAppSetting("UlCodCat", CodActual)
    End Sub

End Class