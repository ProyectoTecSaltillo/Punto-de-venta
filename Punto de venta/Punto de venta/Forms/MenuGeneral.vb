Public Class MenuGeneral
    Private Sub BtnMant_Click(sender As Object, e As EventArgs) Handles BtnMant.Click
        FrmPais.Show()
        Me.Close()
    End Sub

    Private Sub CerrarSesion_Click(sender As Object, e As EventArgs) Handles CerrarSes.Click
        Me.Close()
        Login.Show()
    End Sub

    Private Sub Venta_Click(sender As Object, e As EventArgs) Handles Venta.Click
        Me.Close()
        Venta.Show()
    End Sub
End Class