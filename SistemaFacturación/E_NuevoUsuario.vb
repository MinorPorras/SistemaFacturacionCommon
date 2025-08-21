Imports System.Drawing.Imaging

Public Class E_NuevoUsuario
    Friend ColorUsuario As String
    Friend idUsuario As String
    Friend ModUsu As Boolean = False
    Friend CodigoPreMod As String
    Dim Correcto As Boolean
    Private Sub E_NuevoUsuario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If ModUsu = False Then
            idUsuario = OBTENERPK("usuario", "ID")
        End If
        VALIDAR()
    End Sub

    Private Function VALIDAR() As Boolean
        ' Si el texto no está vacío en el textbox habilita el botón de guardar/agregar
        If TXT_CodUsuario.Text <> "" And TXT_NombreUsuario.Text <> "" And ColorUsuario <> "" And CBX_tipoCuenta.SelectedIndex <> -1 Then
            If TXT_ClaveUsuario.Text <> "" Or SWT_SinClave.Checked = True Then
                BTN_NUsuario.Enabled = True
                Return True
            Else
                BTN_NUsuario.Enabled = False
                Return False
            End If
        Else
            BTN_NUsuario.Enabled = False
            Return False
        End If
        Return False
    End Function

    Private Sub BTN_RegresarUsu_Click(sender As Object, e As EventArgs) Handles BTN_RegresarUsu.Click
        P_Usuarios.Show()
        P_Usuarios.Select()
        P_Usuarios.REFRESCAR()
        P_Usuarios.TXT_BuscarUsuario.SelectAll()
        Me.Close()
    End Sub

    Private Sub BTN_Color_Click(sender As Object, e As EventArgs) Handles BTN_Color.Click
        Try
            If ColorDialog1.ShowDialog() = DialogResult.OK Then
                BTN_Color.FillColor = ColorDialog1.Color
                ColorUsuario = Convert.ToString(ColorDialog1.Color.R) + "," + Convert.ToString(ColorDialog1.Color.G) + "," + Convert.ToString(ColorDialog1.Color.B)
                VALIDAR()
            End If
        Catch ex As Exception
            msgError("Error al seleccionar el color: " & ex.Message)
            ColorUsuario = String.Empty
            VALIDAR()
        End Try
    End Sub

    Private Sub BTN_NUsuario_Click(sender As Object, e As EventArgs) Handles BTN_NUsuario.Click
        If VALIDAR() Then
            Try
                Dim codigo As String = TXT_CodUsuario.Text
                If ModUsu = False Then
                    If Not EXISTECOD("usuario", "codigo", codigo) Then ' Si no se ha guardado la categoría
                        Correcto = True
                    Else
                        Correcto = False
                    End If
                Else
                    If codigo = CodigoPreMod Or Not EXISTECOD("usuario", "codigo", codigo) Then
                        Correcto = True
                    Else
                        Correcto = False
                    End If
                End If
                If Correcto Then
                    ' Comprobación de que se quiere modificar la información en la base de datos por parte del usuario
                    If msgGuardar() Then
                        Try
                            If ModUsu = False Then
                                If EXISTEPK("usuario", "ID", idUsuario) = False Then
                                    GUARDAR_PK("usuario", "ID", idUsuario)
                                End If
                            End If
                            ' Actualizar los campos en la base de datos
                            GUARDAR_TEXT("usuario", "codigo", TXT_CodUsuario.Text, "ID", idUsuario)
                            GUARDAR_TEXT("usuario", "usuario", TXT_NombreUsuario.Text, "ID", idUsuario)
                            If SWT_SinClave.Checked = True Then
                                GUARDAR_TEXT("usuario", "clave", String.Empty, "ID", idUsuario)
                            Else
                                GUARDAR_TEXT("usuario", "clave", TXT_ClaveUsuario.Text, "ID", idUsuario)
                            End If
                            If String.IsNullOrEmpty(ColorUsuario) Then
                                GUARDAR_TEXT("usuario", "color", "0,0,0", "ID", idUsuario)
                            Else
                                GUARDAR_TEXT("usuario", "color", ColorUsuario, "ID", idUsuario)
                            End If
                            If CBX_tipoCuenta.SelectedIndex = 0 Then
                                'Si es cajero
                                GUARDAR_TEXT("usuario", "tipo", 0, "ID", idUsuario)
                            Else
                                'Si es admin
                                GUARDAR_TEXT("usuario", "tipo", 1, "ID", idUsuario)
                            End If
                            LIMPIAR()
                            msgDatoAlm()
                            ' Muestra y refresca la pantalla del list view de Sucursales y cierra esta
                            P_Usuarios.Show()
                            P_Usuarios.Select()
                            P_Usuarios.REFRESCAR()
                            P_Usuarios.TXT_BuscarUsuario.SelectAll()

                            Me.Close()
                        Catch ex As Exception
                            MsgBox("Error al actualizar los datos: " & ex.Message, vbCritical + vbOKOnly, "Error")
                        End Try
                    End If
                Else
                    MsgBox("El código " + TXT_CodUsuario.Text + " ya existe, coloque un código distinto", vbCritical + vbOKOnly, "Error")
                    TXT_CodUsuario.SelectAll()
                End If
            Catch ex As Exception
                MsgBox("Error: " & ex.Message, vbCritical + vbOKOnly, "Error")
            End Try
        End If
    End Sub

    Friend Sub LIMPIAR()
        TXT_CodUsuario.Clear()
        TXT_NombreUsuario.Clear()
        TXT_ClaveUsuario.Clear()
        BTN_Color.BackColor = Color.White
        ColorDialog1.Color = Color.White
        ColorUsuario = String.Empty
        CBX_tipoCuenta.SelectedIndex = 0
        SWT_SinClave.Checked = False
    End Sub

    Private Sub CBK_NoClaveUsu_CheckedChanged(sender As Object, e As EventArgs)
        VALIDAR()
    End Sub
    Private Sub TXT_CodUsuario_TextChanged(sender As Object, e As EventArgs) Handles TXT_CodUsuario.TextChanged
        VALIDAR()
    End Sub

    Private Sub TXT_NombreUsuario_TextChanged(sender As Object, e As EventArgs) Handles TXT_NombreUsuario.TextChanged
        VALIDAR()
    End Sub

    Private Sub TXT_ClaveUsuario_TextChanged(sender As Object, e As EventArgs) Handles TXT_ClaveUsuario.TextChanged
        VALIDAR()
    End Sub

    Private Sub CBX_Sucursal_SelectedIndexChanged(sender As Object, e As EventArgs)
        VALIDAR()
    End Sub

    Private Sub BTN_AutoCod_Click(sender As Object, e As EventArgs) Handles BTN_AutoCod.Click
        ' Obtener todos los códigos existentes
        Dim codigosExistentes As List(Of Integer) = ObtenerCodigosExistentes("usuario", "codigo")
        ' Ordenarlos
        codigosExistentes.Sort()

        ' Número de dígitos según configuración
        Dim numConfig As Integer = Integer.Parse(Md_Inicializacion.GetAppSetting("AutoCodCajero"))

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
        TXT_CodUsuario.Text = CodActual
    End Sub
End Class