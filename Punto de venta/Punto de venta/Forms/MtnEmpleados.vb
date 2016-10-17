Imports System.Security.Cryptography

Public Class MtnEmpleados
    Dim Passcorrecto As Boolean
    Private Sub TxtPass2_TextChanged(sender As Object, e As EventArgs) Handles TxtPass2.TextChanged
        If (TxtPass1.Text = TxtPass2.Text) Then
            Passcorrecto = True
        Else
            Passcorrecto = False
        End If
    End Sub

    Private Sub BtnAgregar_Click(sender As Object, e As EventArgs) Handles BtnAgregar.Click
        If Passcorrecto Then
            Dim HashedPass As String = ""
            Using MD5hash As MD5 = MD5.Create()
                HashedPass = Convert.ToBase64String(MD5hash.ComputeHash(System.Text.Encoding.ASCII.GetBytes(TxtPass2.Text)))
            End Using
        Else
            MsgBox("Password no coincide. Intentelo de nuevo")
        End If

    End Sub
End Class