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
            Dim Venta As New ClaseVenta
            Dim fechain As Date = FechaInicio.Text
            Dim fechafi As Date = FechaFin.Text
            Venta.PoblarDataGridConFecha(DGV, Format(fechain, "yyyy-MM-dd") & " 00:00:00", Format(fechafi, "yyyy-MM-dd") & " 23:59:59")
        ElseIf ComboSel.Text = "Devoluciones" Then
            Dim devol As New ClaseDevolucion
            Dim fechain As Date = FechaInicio.Text
            Dim fechafi As Date = FechaFin.Text
            devol.PoblarDataGridConFecha(DGV, Format(fechain, "yyyy-MM-dd") & " 00:00:00", Format(fechafi, "yyyy-MM-dd") & " 23:59:59")
        ElseIf ComboSel.Text = "Productos" Then
            Dim Prod As New ClaseProductos
            Dim fechain As Date = FechaInicio.Text
            Dim fechafi As Date = FechaFin.Text
            Prod.PoblarDataGridConFecha(DGV, Format(fechain, "yyyy-MM-dd") & " 00:00:00", Format(fechafi, "yyyy-MM-dd") & " 23:59:59")
        End If
    End Sub

    Private Sub Reportes_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        MenuGeneral.Show()

    End Sub
End Class