Imports System.Data.SQLite
Imports SistemaFacturaciónCommon.SistemaFacturacion.Modules
Namespace SistemaFacturacion.Forms.Dialogos
    Public Class D_MovimientoCaja
        Friend isEntrada As Boolean
        Private Sub D_MovimientoCaja_Load(sender As Object, e As EventArgs) Handles MyBase.Load
            CargarConceptos()
            LBL_tituloMovimiento.Text = If(isEntrada, "Registrar Entrada de Caja", "Registrar Salida de Caja")
        End Sub

        Private Sub CargarConceptos()
            SQL = "SELECT ID, concepto FROM Conceptos_Caja WHERE ID_Tipo_Movimiento = @tipo"
            Dim parametros As New List(Of SQLiteParameter) From {New SQLiteParameter("@tipo", If(isEntrada, 1, 2))}
            CargarTablaParam(T, SQL, parametros)

            ' Asegúrate de que la tabla exista antes de enlazarla
            If T.Tables.Count > 0 Then
                CBX_tipoConcepto.DataSource = T.Tables(0) ' Enlaza a la DataTable
                CBX_tipoConcepto.DisplayMember = "concepto"
                CBX_tipoConcepto.ValueMember = "ID"
            End If

        End Sub

        Private Sub BTN_Regresar_Click(sender As Object, e As EventArgs) Handles BTN_Regresar.Click
            Me.DialogResult = DialogResult.Cancel
        End Sub

        Private Sub BTN_ConfirmGuardarMov_Click(sender As Object, e As EventArgs) Handles BTN_ConfirmGuardarMov.Click
            If NUD_Monto.Value = 0 Then
                msgError("El monto no puede ser 0")
                Exit Sub
            End If

            If CBX_tipoConcepto.SelectedIndex = -1 Then
                msgError("Debe seleccionar un concepto")
                Exit Sub
            End If

            Me.DialogResult = If(msgGuardar(), DialogResult.OK, DialogResult.Cancel)
        End Sub
    End Class

End Namespace