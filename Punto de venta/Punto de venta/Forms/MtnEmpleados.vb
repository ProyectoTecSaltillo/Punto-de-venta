Imports System.Security.Cryptography

Public Class MtnEmpleados
    Dim Passcorrecto As Boolean
    Dim rol As Integer = 1
    Dim UserBD As Object
    Private Sub TxtPass2_TextChanged(sender As Object, e As EventArgs) Handles TxtPass2.TextChanged
        If Trim(TxtPass1.Text) = Trim(TxtPass2.Text) Then
            Passcorrecto = True
        Else
            Passcorrecto = False
        End If
    End Sub

    Private Sub BtnAgregar_Click(sender As Object, e As EventArgs) Handles BtnAgregar.Click
        Dim empleados As New ClaseEmpleado
        Dim colonias As New ClaseColonia(ComboColonia.Text)
        If Passcorrecto And validacion() Then
            Dim HashedPass As String = ""
            Using MD5hash As MD5 = MD5.Create()
                HashedPass = Convert.ToBase64String(MD5hash.ComputeHash(System.Text.Encoding.ASCII.GetBytes(TxtPass2.Text)))
                empleados.inserta(TxtNombre.Text, TxtPat.Text, TxtMat.Text, TxtEmail.Text, HashedPass, rol, colonias.getId(colonia))
            End Using
        Else
            MsgBox("Password no coincide. Intentelo de nuevo")
        End If
        empleados.poblarComboID(ComboID)
        empleados.poblarComboNombre(ComboNombre)
    End Sub
    Private Sub ComboPais_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboPais.SelectedIndexChanged
        Dim paises As New ClasePais(ComboPais.Text)
        Dim estados As New ClaseEstado(ComboEstado.Text)
        ComboEstado.Text = "Seleccione..."
        ComboCiudad.Text = "Seleccione..."
        ComboColonia.Text = "Seleccione..."
        estados.poblarCombo(ComboEstado, paises.getId())
    End Sub
    Private Sub ComboEstado_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboEstado.SelectedIndexChanged
        Dim paises As New ClasePais(ComboPais.Text)
        Dim estados As New ClaseEstado(ComboEstado.Text)
        Dim ciudades As New ClaseCiudad(ComboCiudad.Text)
        ComboCiudad.Text = "Seleccione..."
        ComboColonia.Text = "Seleccione..."
        ciudades.poblarCombo(ComboCiudad, paises.getId(), estados.getId())
    End Sub
    Private Sub ComboCiudad_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboCiudad.SelectedIndexChanged
        Dim paises As New ClasePais(ComboPais.Text)
        Dim estados As New ClaseEstado(ComboEstado.Text)
        Dim ciudades As New ClaseCiudad(ComboCiudad.Text)
        Dim colonias As New ClaseColonia(ComboColonia.Text)
        ComboColonia.Text = "Seleccione..."
        colonias.poblarCombo(ComboColonia, paises.getId(), estados.getId(), ciudades.getId())
    End Sub

    Private Sub MtnEmpleados_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim paises As New ClasePais
        Dim empleado As New ClaseEmpleado
        empleado.poblarComboID(ComboID)
        empleado.poblarComboNombre(ComboNombre)
        paises.poblarCombo(ComboPais)
        'ComboColonia.Text = "Seleccione..."
    End Sub

    Private Sub MtnEmpleados_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        MenuGeneral.Show()
    End Sub

    Private Function validacion() As Boolean
        If ComboColonia.Text <> "Selecccione..." And TxtPass1.Text <> "" And TxtEmail.Text <> "" And TxtNombre.Text <> "" And TxtMat.Text <> "" And TxtPat.Text <> "" Then
            Return True
        End If
        Return False
    End Function

    Private Sub CheckAdm_CheckedChanged(sender As Object, e As EventArgs) Handles CheckAdm.CheckedChanged
        CheckEmp.CheckState = False
        rol = 1
    End Sub

    Private Sub CheckEmp_CheckedChanged(sender As Object, e As EventArgs) Handles CheckEmp.CheckedChanged
        CheckAdm.CheckState = False
        rol = 2
    End Sub

    Private Sub ComboID_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboID.SelectedIndexChanged
        Dim empleados As New ClaseEmpleado(CInt(ComboID.Text))
        ComboNombre.Text = empleados.getNombre()
        UserBD = empleados.DatosUsuario(UserBD)
        Me.poblarCampos(UserBD)
        TxtPass1.Text = ""
        TxtPass2.Text = ""
        If session.item(4) = UserBD.item(4) Then
            BtnEliminar.Enabled = False
        Else
            BtnEliminar.Enabled = True
        End If
    End Sub
    Private Sub ComboNombre_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboNombre.SelectedIndexChanged
        Dim empleados As New ClaseEmpleado(ComboNombre.Text)
        ComboID.Text = empleados.getId()
    End Sub

    Public Sub poblarCampos(ByVal Datos As Object)
        TxtNombre.Text = Datos.item(1)
        TxtPat.Text = Datos.item(2)
        TxtMat.Text = Datos.item(3)
        TxtEmail.Text = Datos.item(4)
        'TxtPass1.Text = Datos.item(5)
        'TxtPass2.Text = Datos.item(5)
        If Datos.item(6) = 1 Then
            CheckAdm.Checked = True
        Else
            CheckEmp.Checked = True
        End If
        Dim colonia As New ClaseColonia(CInt(Datos.item(7)))
        ComboColonia.Text = colonia.getNombre()
        Dim ciudad As New ClaseCiudad(CInt(colonia.getIdCiudad()))
        ComboCiudad.Text = ciudad.getNombre()
        Dim estado As New ClaseEstado(CInt(colonia.getIdEstado()))
        ComboEstado.Text = estado.getNombre()
        Dim pais As New ClasePais(CInt(colonia.getIdPais()))
        ComboPais.Text = pais.getNombre()

    End Sub

    Private Sub TxtPass1_GotFocus(sender As Object, e As EventArgs) Handles TxtPass1.GotFocus
        TxtPass1.Text = ""
    End Sub
    Private Sub TxtPass2_GotFocus(sender As Object, e As EventArgs) Handles TxtPass2.GotFocus
        TxtPass2.Text = ""
    End Sub

    Private Sub BtnModificar_Click(sender As Object, e As EventArgs) Handles BtnModificar.Click
        Dim empleados As New ClaseEmpleado(CInt(ComboID.Text))
        Dim colonias As New ClaseColonia(ComboColonia.Text)
        If Passcorrecto And validacion() Then
            Using MD5hash As MD5 = MD5.Create()
                Dim HashedPass As String = ""
                HashedPass = Convert.ToBase64String(MD5hash.ComputeHash(System.Text.Encoding.ASCII.GetBytes(TxtPass2.Text)))
                empleados.actualiza(ComboID.Text, TxtNombre.Text, TxtPat.Text, TxtMat.Text, TxtEmail.Text, HashedPass, rol, colonias.getId)
            End Using
        Else
            MsgBox("Password no coincide. Intentelo de nuevo")
        End If
        empleados.poblarComboID(ComboID)
        empleados.poblarComboNombre(ComboNombre)
    End Sub

    Private Sub BtnEliminar_Click(sender As Object, e As EventArgs) Handles BtnEliminar.Click
        Dim parteT() = TxtNombre.Text.Split(" ")
        Dim parteC() = ComboNombre.Text.Split(" ")
        Try
            If parteC(0) = parteT(0) And parteC(1) = parteT(1) Then
                Dim empleados As New ClaseEmpleado(parteC(0) & " " & parteC(1))
                empleados.elimina()
                empleados.poblarComboID(ComboID)
                empleados.poblarComboNombre(ComboNombre)
            End If
        Catch
            Dim empleados As New ClaseEmpleado(parteC(0))
            empleados.elimina()
            empleados.poblarComboID(ComboID)
            empleados.poblarComboNombre(ComboNombre)
        End Try
    End Sub
End Class