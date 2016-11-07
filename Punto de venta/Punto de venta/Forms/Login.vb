Imports MySql.Data.MySqlClient
Imports System.Security.Cryptography
Imports AxWMPLib

Public Class Login
    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TxtEmail.Focus()
    End Sub

    Private Sub BtnEntrar_Click(sender As Object, e As EventArgs) Handles BtnEntrar.Click
        Dim strSQL As String
        Dim xCnx As New conexion
        Dim xDT As DataTable
        Dim HashedPass As String = ""

        Using MD5hash As MD5 = MD5.Create()
            HashedPass = Convert.ToBase64String(MD5hash.ComputeHash(System.Text.Encoding.ASCII.GetBytes(TxtPsw.Text)))
        End Using

        strSQL = "SELECT * FROM usuarios WHERE email = '" & TxtEmail.Text & "' && password = '" & HashedPass & "';"
        xDT = xCnx.objetoDataAdapter(strSQL)
        If xDT.Rows.Count = 1 Then
            TxtEmail.Text = ""
            TxtPsw.Text = ""
            session = xDT.Rows(0)
            MessageBox.Show("Bienvenido " & session.Item(1))
            MenuGeneral.Show()
            Me.Hide()
        Else
            MessageBox.Show("Usuario o contraseña incorrecto!")
        End If
        cnx.Close()
    End Sub

    Private Sub TxtUser_TextChanged(sender As Object, e As EventArgs) Handles TxtEmail.TextChanged
        If (Trim(TxtEmail.Text) <> "") Then
            TxtPsw.Enabled = True
        Else
            TxtPsw.Enabled = False
        End If
    End Sub

    Private Sub TxtPsw_TextChanged(sender As Object, e As EventArgs) Handles TxtPsw.TextChanged
        TxtPsw.PasswordChar = "*"
    End Sub

    Private Sub BtnExit_Click(sender As Object, e As EventArgs) Handles BtnExit.Click
        Me.Close()
    End Sub

    Dim cont As Integer = 0
    Private Sub VideoLogin_PlayStateChange(sender As Object, e As _WMPOCXEvents_PlayStateChangeEvent) Handles VideoLogin.PlayStateChange
        If cont = 1 Then
            VideoLogin.URL = App.Path & "\Punto-de-venta\Punto de venta\Resources\login.mp4"
            VideoLogin.Visible = False
            TxtEmail.Visible = True
            BtnEntrar.Visible = True
            TxtPsw.Visible = True
        End If
        cont = cont + 1

    End Sub

    Private Sub BtnExit_MouseHover(sender As Object, e As EventArgs) Handles BtnExit.MouseHover
        BtnExit.Image = (My.Resources.x2_tamaño)
    End Sub

    Private Sub BtnExit_MouseLeave(sender As Object, e As EventArgs) Handles BtnExit.MouseLeave
        BtnExit.Image = (My.Resources.X_Tamaño)
    End Sub
End Class