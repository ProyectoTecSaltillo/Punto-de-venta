Public Class Perfil
    Private Sub Perfil_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TxtName.Text = session.Item(1)
        TxtPat.Text = session.Item(2)
        TxtMat.Text = session.Item(3)
        TxtEmail.Text = session.Item(4)
        TxtPsw.PasswordChar = "*"
        TxtPsw.Text = session.Item(5)
    End Sub

    Private Sub BtnEdName_Click(sender As Object, e As EventArgs) Handles BtnEdName.Click
        TxtName.Enabled = True
    End Sub

    Private Sub BtnEdPat_Click(sender As Object, e As EventArgs) Handles BtnEdPat.Click
        TxtPat.Enabled = True
    End Sub

    Private Sub BtnEdMat_Click(sender As Object, e As EventArgs) Handles BtnEdMat.Click
        TxtMat.Enabled = True
    End Sub

    Private Sub BtnEdEmail_Click(sender As Object, e As EventArgs) Handles BtnEdEmail.Click
        TxtEmail.Enabled = True
    End Sub

    Private Sub BtnEdPsw_Click(sender As Object, e As EventArgs) Handles BtnEdPsw.Click
        TxtPsw.Enabled = True
    End Sub

    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles BtnSalir.Click
        session = Nothing
        Login.Show()
        Me.Close()
    End Sub

    Private Sub BtnBack_Click(sender As Object, e As EventArgs) Handles BtnBack.Click
        MenuGeneral.Show()
        Me.Close()
    End Sub
End Class