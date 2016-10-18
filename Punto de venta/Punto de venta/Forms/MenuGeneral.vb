Public Class MenuGeneral
    Private Sub BtnMant_Click(sender As Object, e As EventArgs) Handles BtnMant.Click
        FrmPais.Show()
        Me.Hide()
    End Sub

    Private Sub CerrarSesion_Click(sender As Object, e As EventArgs) Handles CerrarSes.Click
        Me.Close()
        Login.Show()
    End Sub

    Private Sub Venta_Click(sender As Object, e As EventArgs) Handles Venta.Click
        Me.Hide()
        Venta.Show()
    End Sub

    Private Sub BtnManEmp_Click(sender As Object, e As EventArgs) Handles BtnManEmp.Click
        Me.Hide()
        MtnEmpleados.Show()
    End Sub

    Private Sub MenuGeneral_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        Login.Show()
    End Sub

    Private Sub MenuGeneral_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class