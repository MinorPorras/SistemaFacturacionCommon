Imports SistemaFacturaciónCommon.SistemaFacturacion.Forms.Mantenimiento
Imports SistemaFacturaciónCommon.SistemaFacturacion.Modules

Public Class C_ConceptosCaja
    Private searchTimer As Timer

    ' Método para inicializar el temporizador y otros componentes necesarios
    Private Sub InicializarComponentes()
        ' Inicializar el temporizador
        searchTimer = New Timer()
        searchTimer.Interval = 100
        ' Medio segundo
        AddHandler searchTimer.Tick, AddressOf OnSearchTimerTick
    End Sub

    Private Sub OnSearchTimerTick(sender As Object, e As EventArgs)
        ' Detener el temporizador y ejecutar la búsqueda
        searchTimer.Stop()
        REFRESCAR()
    End Sub

    Private Sub RestartTimer()
        If searchTimer IsNot Nothing Then
            searchTimer.Stop()
            searchTimer.Start()
        End If
    End Sub

    Private Sub REFRESCAR()

    End Sub
    Private Sub BTN_Config_Click(sender As Object, e As EventArgs) Handles BTN_Config.Click
        entrarConfig(2, Me)
    End Sub

    Private Sub BTN_RegresarCat_Click(sender As Object, e As EventArgs) Handles BTN_Regresar.Click
        M_MantenimientoMenu.Show()
        M_MantenimientoMenu.Select()
        Me.Close()
    End Sub

    Private Sub C_ConceptosCaja_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class