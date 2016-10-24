Imports System.Security.Cryptography

Public Class MtnEmpleados
    Dim Passcorrecto As Boolean
    Private Sub TxtPass2_TextChanged(sender As Object, e As EventArgs) Handles TxtPass2.TextChanged
        If Trim(TxtPass1.Text) = Trim(TxtPass2.Text) Then
            Passcorrecto = True
        Else
            Passcorrecto = False
        End If
    End Sub

    Private Sub BtnAgregar_Click(sender As Object, e As EventArgs) Handles BtnAgregar.Click
        If Passcorrecto And Validacion() Then
            Dim HashedPass As String = ""
            Using MD5hash As MD5 = MD5.Create()
                HashedPass = Convert.ToBase64String(MD5hash.ComputeHash(System.Text.Encoding.ASCII.GetBytes(TxtPass2.Text)))
            End Using
        Else
            MsgBox("Password no coincide. Intentelo de nuevo")
        End If

    End Sub
    Private Sub ComboPais_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboPais.SelectedIndexChanged
        Dim paises As New ClasePais(ComboPais.Text)
        Dim estados As New ClaseEstado(ComboEstado.Text)
        ComboEstado.Text = "Seleccione..."
        ComboCiudad.Text = "Seleccione..."
        ComboColonia.Text = "Seleccione..."
        estados.poblarCombo(ComboEstado, paises.getId(pais))
    End Sub
    Private Sub ComboEstado_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboEstado.SelectedIndexChanged
        Dim paises As New ClasePais(ComboPais.Text)
        Dim estados As New ClaseEstado(ComboEstado.Text)
        Dim ciudades As New ClaseCiudad(ComboCiudad.Text)
        ComboCiudad.Text = "Seleccione..."
        ComboColonia.Text = "Seleccione..."
        ciudades.poblarCombo(ComboCiudad, paises.getId(pais), estados.getId(estado))
    End Sub
    Private Sub ComboCiudad_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboCiudad.SelectedIndexChanged
        Dim paises As New ClasePais(ComboPais.Text)
        Dim estados As New ClaseEstado(ComboEstado.Text)
        Dim ciudades As New ClaseCiudad(ComboCiudad.Text)
        Dim colonias As New ClaseColonia(ComboColonia.Text)
        ComboColonia.Text = "Seleccione..."
        colonias.poblarCombo(ComboColonia, paises.getId(pais), estados.getId(estado), ciudades.getId(ciudad))
    End Sub

    Private Sub MtnEmpleados_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim paises As New ClasePais

        empleados.poblarCombo(ComboNombre)
        paises.poblarCombo(ComboPais)
        ComboColonia.Text = "Seleccione..."
    End Sub

    Private Sub MtnEmpleados_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        MenuGeneral.Show()
    End Sub

    Private Function validacion() As Boolean
        'ComboColonia.Text <> Nothing And ComboColonia.Text <> "Seleccione..."
        Return False
    End Function


End Class