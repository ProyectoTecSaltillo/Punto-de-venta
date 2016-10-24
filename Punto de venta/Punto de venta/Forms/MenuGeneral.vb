Public Class MenuGeneral
    Private Sub MenuGeneral_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ToolStripLabel1.Text = "Bienvenido " & session.Item(1)
        If session.Item(6) <> 1 Then
            Bu.Visible = False
            B.Visible = False
        End If
    End Sub

    Private Sub BtnMant_Click(sender As Object, e As EventArgs) Handles BtnMant.Click
        FrmPais.Show()
        Me.Hide()
    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub PerfilToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PerfilToolStripMenuItem.Click
        Perfil.Show()
        Me.Hide()
    End Sub

    Private Sub MenuGeneral_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        session = Nothing
        MsgBox("Vuelve pronto!")
        Login.Show()
    End Sub

End Class