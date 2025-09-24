Imports System.Data.SqlClient
Imports System.Data.SQLite
Imports SistemaFacturaciónCommon.SistemaFacturacion.Data
Imports SistemaFacturaciónCommon.SistemaFacturacion.Modules

Public Class E_NuevoConcepto
    Friend concepto As Cls_ConceptoCaja

    Private Sub E_NuevoConcepto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If concepto.isEntrada Then
            CBX_tipoConcepto.SelectedIndex = 0
        Else
            CBX_tipoConcepto.SelectedIndex = 1
        End If

        ' Si el ID es -1, es un nuevo concepto
        If concepto.ID = -1 Then
            Return
        End If

        ' Cargar datos del concepto existente
        TXT_Concepto.Text = concepto.descripcion

        CBX_tipoConcepto.SelectedIndex = If(concepto.isEntrada, 0, 1)


    End Sub

    Private Sub AddUpdateConcepto()
        Dim descripcion As String = TXT_Concepto.Text.Trim()
        If String.IsNullOrEmpty(descripcion) Then
            MessageBox.Show("El campo de concepto no puede estar vacío.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If
        Dim esEntrada As Boolean = (CBX_tipoConcepto.SelectedIndex = 0)
        Dim query As String
        ' Crear un diccionario para los parámetros
        Dim paramDict As New Dictionary(Of String, Object) From {
            {"ID", If(concepto.ID = -1, OBTENERPK("Conceptos_Caja", "ID"), concepto.ID)},
            {"Descripcion", descripcion},
            {"tipo", If(esEntrada, 1, 2)}
        }

        If concepto.ID = -1 Then
            ' Insertar nuevo concepto
            query = "INSERT INTO Conceptos_Caja (ID, concepto, ID_Tipo_Movimiento) VALUES (@ID, @Descripcion, @tipo)"
        Else
            ' Actualizar concepto existente
            query = "UPDATE Conceptos_Caja SET concepto = @Descripcion, ID_Tipo_Movimiento = @tipo WHERE ID = @ID"
        End If

        ' Ejecutar la consulta con parámetros
        If Not EJECUTAR_PARAMETROS(query, paramDict) Then
            msgError("Error al guardar el concepto.")
            Return
        End If

        MessageBox.Show("Concepto guardado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Me.DialogResult = DialogResult.OK
        Me.Close()
    End Sub

    Private Sub BTN_NConcepto_Click(sender As Object, e As EventArgs) Handles BTN_NConcepto.Click
        AddUpdateConcepto()
    End Sub

    Private Sub BTN_Regresar_Click(sender As Object, e As EventArgs) Handles BTN_Regresar.Click
        Me.DialogResult = DialogResult.Cancel
    End Sub
End Class