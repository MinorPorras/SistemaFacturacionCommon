' -------------------------------------------------------------
' Formulario para la gestión de creación y edición de sucursales
' Permite ingresar, validar y guardar información de una sucursal
' -------------------------------------------------------------
Imports System.Configuration

Public Class E_NuevaSucursal
    ' Identificador único de la sucursal
    Friend idSucursal As String
    ' Ruta del logo seleccionado para la sucursal
    Friend RutaLogo As String
    ' Indica si se está modificando (True) o creando (False) una sucursal
    Friend ModSuc As Boolean = False

    ' Evento: Regresa al formulario de listado de sucursales
    Private Sub BTN_RegresarSuc_Click(sender As Object, e As EventArgs) Handles BTN_RegresarNSuc.Click
        P_Sucursal.Show()
        P_Sucursal.Select()
        Me.Close()
    End Sub

    ' Función: Valida que todos los campos requeridos estén completos
    ' Habilita o deshabilita el botón de guardar según la validación
    Private Function VALIDAR()
        ' Si el texto no está vacío en el textbox habilita el botón de guardar/agregar
        If TXT_CodSucursal.Text <> "" And TXT_CedJuridicaSucursal.Text <> "" And TXT_NombreSucursal.Text <> "" And TXT_EmailSucursal.Text <> "" And TXT_TelefonoSucursal.Text <> "" And TXT_DireccionSucursal.Text <> "" And RutaLogo <> "" Then
            BTN_GuardarNSucursal.Enabled = True
            Return True
        Else
            BTN_GuardarNSucursal.Enabled = False
            Return True
        End If
    End Function

    ' Evento: Selección de logo para la sucursal mediante OpenFileDialog
    Private Sub BTN_LogoSucursal_Click(sender As Object, e As EventArgs) Handles BTN_LogoSucursal.Click
        Try
            If OFD_LogoSucursal.ShowDialog() = DialogResult.OK Then
                RutaLogo = OFD_LogoSucursal.FileName
                BTN_LogoSucursal.Image = Image.FromFile(RutaLogo)
                VALIDAR()
            End If
        Catch ex As Exception
            msgError("Error: " & ex.Message)
        End Try
    End Sub

    ' Evento: Al cargar el formulario, obtiene una nueva PK si es alta
    Private Sub E_NuevaSucursal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Al cargar la página obtiene una PK nueva
        If ModSuc = False Then
            idSucursal = OBTENERPK("sucursal", "ID")
        End If
        VALIDAR()
    End Sub

    ' Eventos: Validan los campos al cambiar el texto en los TextBox
    Private Sub TXT_CodSucursal_TextChanged(sender As Object, e As EventArgs) Handles TXT_CodSucursal.TextChanged
        VALIDAR()
    End Sub

    Private Sub TXT_NombreSucursal_TextChanged(sender As Object, e As EventArgs) Handles TXT_NombreSucursal.TextChanged
        VALIDAR()
    End Sub

    Private Sub TXT_CedJuridicaSucursal_TextChanged(sender As Object, e As EventArgs) Handles TXT_CedJuridicaSucursal.TextChanged
        VALIDAR()
    End Sub

    Private Sub TXT_EmailSucursal_TextChanged(sender As Object, e As EventArgs) Handles TXT_EmailSucursal.TextChanged
        VALIDAR()
    End Sub

    Private Sub TXT_DireccionSucursal_TextChanged(sender As Object, e As EventArgs) Handles TXT_DireccionSucursal.TextChanged
        VALIDAR()
    End Sub

    Private Sub TXT_TelefonoSucursal_TextChanged(sender As Object, e As EventArgs) Handles TXT_TelefonoSucursal.TextChanged
        VALIDAR()
    End Sub

    ' Evento: Guarda la información de la sucursal en la base de datos
    Private Sub BTN_GuardarNSucursal_Click(sender As Object, e As EventArgs) Handles BTN_GuardarNSucursal.Click
        If VALIDAR() Then
            Try
                ' Comprobación de que se quiere modificar la información en la base de datos por parte del usuario
                If msgGuardar() Then
                    Try
                        If ModSuc = False Then
                            ' Si la PK que esté guardada en IdCat no existe en la base de datos en esa tabla...
                            If EXISTEPK("sucursal", "ID", idSucursal) = False Then ' Si no se ha guardado la categoría
                                ' Guarda la PK almacenada en IdCat dentro de la Base de datos en la tabla y PK indicado
                                GUARDAR_PK("sucursal", "ID", idSucursal)
                            End If
                        End If
                        ' Actualizar los campos en la base de datos
                        GUARDAR_TEXT("sucursal", "codigo", Convert.ToInt32(TXT_CodSucursal.Text), "ID", idSucursal)
                        GUARDAR_TEXT("sucursal", "nombre", TXT_NombreSucursal.Text, "ID", idSucursal)
                        ActConfig("Empresa", TXT_NombreSucursal.Text)
                        GUARDAR_TEXT("sucursal", "direccion", TXT_DireccionSucursal.Text, "ID", idSucursal)
                        GUARDAR_TEXT("sucursal", "ced_juridica", TXT_CedJuridicaSucursal.Text, "ID", idSucursal)
                        GUARDAR_TEXT("sucursal", "telefono", TXT_TelefonoSucursal.Text, "ID", idSucursal)
                        ActConfig("Telefono", TXT_TelefonoSucursal.Text)
                        GUARDAR_TEXT("sucursal", "email", TXT_EmailSucursal.Text, "ID", idSucursal)
                        ActConfig("Correo", TXT_EmailSucursal.Text)
                        GUARDAR_TEXT("sucursal", "logo", RutaLogo, "ID", idSucursal)
                        ActConfig("Logo", RutaLogo)
                        LIMPIAR()
                        msgDatoAlm()
                        ' Muestra y refresca la pantalla del list view de Sucursales y cierra esta
                        P_Sucursal.Show()
                        P_Sucursal.Select()
                        P_Sucursal.REFRESCAR()
                        Me.Close()
                    Catch ex As Exception
                        msgError("Error al actualizar los datos: " & ex.Message)
                    End Try
                End If
            Catch ex As Exception
                msgError("Error: " & ex.Message)
            End Try
        End If
    End Sub

    ' Evento: Permite guardar la sucursal presionando Enter
    Private Sub E_NuevaSucursal_KeyPress(sender As Object, e As KeyPressEventArgs) Handles MyBase.KeyPress
        If e.KeyChar = Chr(13) Then
            BTN_GuardarNSucursal.PerformClick()
        End If
    End Sub

    ' Limpia todos los campos del formulario
    Friend Sub LIMPIAR()
        TXT_CedJuridicaSucursal.Clear()
        TXT_CodSucursal.Clear()
        TXT_DireccionSucursal.Clear()
        TXT_TelefonoSucursal.Clear()
        TXT_EmailSucursal.Clear()
        TXT_NombreSucursal.Clear()
    End Sub
End Class