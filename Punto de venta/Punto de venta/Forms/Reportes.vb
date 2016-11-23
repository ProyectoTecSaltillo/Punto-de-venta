Public Class Reportes
    Private Sub FechaFin_LostFocus(sender As Object, e As EventArgs) Handles FechaFin.LostFocus
        FechaInicio.MaxDate = FechaFin.Value.Date
    End Sub

    Private Sub FechaInicio_LostFocus(sender As Object, e As EventArgs) Handles FechaInicio.LostFocus
        FechaFin.MinDate = FechaInicio.Value.Date
    End Sub


    Private Sub Reportes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FechaFin.MaxDate = DateTime.Today
        FechaInicio.MaxDate = DateTime.Today
    End Sub
    Private Sub BtnBuscar_Click(sender As Object, e As EventArgs) Handles BtnBuscar.Click
        If ComboSel.Text = "Ventas" Then

        ElseIf ComboSel.Text = "Devoluciones" Then
            Dim devol As New ClaseDevolucion
            Dim fechain As Date = FechaInicio.Text
            Dim fechafi As Date = FechaFin.Text
            devol.PoblarDataGridConFecha(DGV, Format(fechain, "yyyy-MM-dd"), Format(fechafi, "yyyy-MM-dd"))
        ElseIf ComboSel.Text = "Productos" Then
            Dim Prod As New ClaseProductos
            Dim fechain As Date = FechaInicio.Text
            Dim fechafi As Date = FechaFin.Text
            Prod.PoblarDataGridConFecha(DGV, Format(fechain, "yyyy-MM-dd"), Format(fechafi, "yyyy-MM-dd"))
        End If
    End Sub
End Class