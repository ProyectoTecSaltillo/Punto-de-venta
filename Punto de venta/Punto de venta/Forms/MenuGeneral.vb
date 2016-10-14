Public Class MenuGeneral
    Private Sub MenuGeneral_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If session.Item(6) <> 1 Then
            Bu.Visible = False
            B.Visible = False
        End If
    End Sub

    Private Sub BtnMant_Click(sender As Object, e As EventArgs) Handles BtnMant.Click
        FrmPais.Show()
        Me.Close()
    End Sub
End Class