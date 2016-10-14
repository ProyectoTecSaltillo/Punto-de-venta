Imports MySql.Data.MySqlClient
Imports System.Security.Cryptography

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

        'Try
        strSQL = "SELECT * FROM usuarios WHERE email = '" & TxtEmail.Text & "' && password = '" & HashedPass & "';"
        xDT = xCnx.objetoDataAdapter(strSQL)
        If xDT.Rows.Count = 1 Then
            MessageBox.Show("Bienvenido")
            session = xDT.Rows(0)
            MenuGeneral.Show()
            Me.Hide()
        Else
            MessageBox.Show("Usuario o contraseña incorrecto!")
        End If
        cnx.Close()
        'Catch ex As MySqlException
        '    MessageBox.Show("No se ha podido conectar al servidor")
        'End Try
        'MenuGeneral.Show()
        'Me.Hide()
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
End Class