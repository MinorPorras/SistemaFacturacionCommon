Imports System.Reflection
Imports Microsoft.VisualBasic.Devices

Public Class E_NuevoImpuesto
    Friend idImpuesto As String
    Friend ModImp As Boolean = False
    Friend CodigoPreMod As String
    Friend Correcto As Boolean
    Private Sub BTN_RegresarUsu_Click(sender As Object, e As EventArgs) Handles BTN_RegresarImp.Click
        P_Impuestos.Show()
        P_Impuestos.Select()
        Me.Close()
    End Sub

    Private Sub BTN_NUsuario_Click(sender As Object, e As EventArgs) Handles BTN_NImpuesto.Click
        If VALIDAR() Then
            Try
                Dim codigo As String = TXT_CodImpuesto.Text
                If ModImp = False Then
                    If Not EXISTECOD("impuestos", "codigo", codigo) Then ' Si no se ha guardado la categoría
                        Correcto = True
                    Else
                        Correcto = False
                    End If
                Else
                    If codigo = CodigoPreMod Or Not EXISTECOD("impuestos", "codigo", codigo) Then
                        Correcto = True
                    Else
                        Correcto = False
                    End If
                End If
                If Correcto Then
                    ' Comprobación de que se quiere modificar la información en la base de datos por parte del usuario
                    If msgGuardar() Then
                        Try
                            If ModImp = False Then
                                ' Si la PK que esté guardada en IdCat no existe en la base de datos en esa tabla...
                                If EXISTEPK("impuestos", "ID", idImpuesto) = False Then ' Si no se ha guardado la categoría
                                    ' Guarda la PK almacenada en IdCat dentro de la Base de datos en la tabla y PK indicado
                                    GUARDAR_PK("impuestos", "ID", idImpuesto)
                                End If
                            End If
                            ' Actualizar los campos en la base de datos
                            GUARDAR_TEXT("impuestos", "codigo", TXT_CodImpuesto.Text, "ID", idImpuesto)
                            GUARDAR_TEXT("impuestos", "descripcion", TXT_DescImpuesto.Text, "ID", idImpuesto)
                            GUARDAR_INT("impuestos", "porcentaje", NUD_Porc.Value, "ID", idImpuesto)
                            LIMPIAR()
                            msgDatoAlm()
                            ' Muestra y refresca la pantalla del list view de Sucursales y cierra esta
                            P_Impuestos.Show()
                            P_Impuestos.Select()
                            P_Impuestos.REFRESCAR()
                            Me.Close()
                        Catch ex As Exception
                            msgError("Error al actualizar los datos: " & ex.Message)
                        End Try
                    End If
                Else
                    msgError("El código " + TXT_CodImpuesto.Text + " ya existe, coloque un código distinto")
                    TXT_CodImpuesto.SelectAll()
                End If
            Catch ex As Exception
                msgError("Error: " & ex.Message)
            End Try
        End If
    End Sub

    Friend Sub LIMPIAR()
        TXT_DescImpuesto.Clear()
        TXT_CodImpuesto.Clear()
        NUD_Porc.Value = 0.00
    End Sub

    Private Function VALIDAR()
        ' Si el texto no está vacío en el textbox habilita el botón de guardar/agregar
        If TXT_CodImpuesto.Text <> "" And TXT_DescImpuesto.Text <> "" Then
            BTN_NImpuesto.Enabled = True
            Return True
        Else
            BTN_NImpuesto.Enabled = False
            Return False
        End If
    End Function

    Private Sub TXT_CodImpuesto_TextChanged(sender As Object, e As EventArgs) Handles TXT_CodImpuesto.TextChanged
        VALIDAR()
    End Sub

    Private Sub TXT_DescImpuesto_TextChanged(sender As Object, e As EventArgs) Handles TXT_DescImpuesto.TextChanged
        VALIDAR()
    End Sub

    Private Sub E_NuevoImpuesto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If ModImp = False Then
            idImpuesto = OBTENERPK("impuestos", "ID")
        End If
        VALIDAR()
    End Sub

    Private Sub BTN_AutoCod_Click(sender As Object, e As EventArgs) Handles BTN_AutoCod.Click
        ' Obtener todos los códigos existentes
        Dim codigosExistentes As List(Of Integer) = ObtenerCodigosExistentes("impuestos", "codigo")
        ' Ordenarlos
        codigosExistentes.Sort()

        ' Número de dígitos según configuración
        Dim numConfig As Integer = Integer.Parse(Md_Inicializacion.GetAppSetting("AutoCodImp"))

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
        TXT_CodImpuesto.Text = CodActual
    End Sub
End Class