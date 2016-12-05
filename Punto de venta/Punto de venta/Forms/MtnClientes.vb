Public Class MtnClientes
    Dim obCliente As Object
    Private Sub MtnClientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim clientes As New ClaseCliente()
        Dim paises As New ClasePais
        clientes.poblarComboN(ComboNombre)
        clientes.poblarComboID(ComboID)
        paises.poblarCombo(ComboPais)
    End Sub

    Private Sub ComboNombre_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboNombre.SelectedIndexChanged
        Dim clientes As New ClaseCliente(ComboNombre.Text)
        ComboID.Text = clientes.getId()
        BtnActualizar.Enabled = True
        BtnEliminar.Enabled = True
        BtnAgregar.Enabled = False
        BtnAdd.Enabled = True
    End Sub

    Private Sub MtnClientes_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        MenuGeneral.Show()
    End Sub

    Private Sub BtnActualizar_Click(sender As Object, e As EventArgs) Handles BtnActualizar.Click
        Dim colonias As New ClaseColonia(ComboColonia.Text)
        Dim sexo As String = Nothing
        If Masculino.Checked Then
            sexo = Masculino.Text.ToString
        ElseIf Femenino.Checked Then
            sexo = Femenino.Text.ToString
        End If
        If TxtNombre.Text = "" Or TxtPat.Text = "" Or TxtMat.Text = "" Or NumEdad.Text = "" Or TxtRfc.Text = "" _
            Or TxtCurp.Text = "" Or sexo = Nothing Or TxtEmail.Text = "" Or TxtTel.Text = "" Or TxtExt.Text = "" _
            Or TxtCalle.Text = "" Or colonias.getId(colonia) = Nothing Then
            MsgBox("No puedes actualizar con campos vacíos")
        Else
            Dim clientes As New ClaseCliente(CInt(ComboID.Text))
            clientes.actualiza(CInt(ComboID.Text), TxtNombre.Text, TxtPat.Text, TxtMat.Text, NumEdad.Text, TxtRfc.Text, TxtCurp.Text,
                         sexo, TxtEmail.Text, TxtTel.Text, TxtExt.Text, TxtCalle.Text, colonias.getId(colonia))
            clientes.poblarComboID(ComboID)
            clientes.poblarComboN(ComboNombre)
        End If
    End Sub

    Private Sub BtnAgregar_Click(sender As Object, e As EventArgs) Handles BtnAgregar.Click
        Dim colonias As New ClaseColonia(ComboColonia.Text)
        Dim sexo As String = Nothing
        If Masculino.Checked Then
            sexo = Masculino.Text.ToString
        ElseIf Femenino.Checked Then
            sexo = Femenino.Text.ToString
        End If
        If TxtNombre.Text = "" Or TxtPat.Text = "" Or TxtMat.Text = "" Or NumEdad.Text = "" Or TxtRfc.Text = "" _
            Or TxtCurp.Text = "" Or sexo = Nothing Or TxtEmail.Text = "" Or TxtTel.Text = "" Or TxtExt.Text = "" _
            Or TxtCalle.Text = "" Or colonias.getId(colonia) = Nothing Then
            MsgBox("No puedes registrar un cliente con campos vacíos")
        Else
            Dim Ciudades As New ClaseCliente(ComboCiudad.Text)
            Dim Paises As New ClaseCliente(ComboPais.Text)
            Dim Estados As New ClaseCliente(ComboEstado.Text)
            Dim clientes As New ClaseCliente()
            clientes.inserta(TxtNombre.Text, TxtPat.Text, TxtMat.Text, NumEdad.Text, TxtRfc.Text, TxtCurp.Text,
                         sexo, TxtEmail.Text, TxtTel.Text, TxtExt.Text, TxtCalle.Text, Paises.getId(pais), Estados.getId(estado), Ciudades.getId(ciudad), colonias.getId(colonia))
            clientes.poblarComboID(ComboID)
            clientes.poblarComboN(ComboNombre)
        End If
    End Sub

    Private Sub BtnEliminar_Click(sender As Object, e As EventArgs) Handles BtnEliminar.Click
        Dim clienteNombre = ComboNombre.Text
        If MessageBox.Show("¿Deseas eliminar al cliente " & clienteNombre & "?", "CONFIRMAR", MessageBoxButtons.YesNo) = DialogResult.Yes Then
            Dim clientes As New ClaseCliente()
            clientes.eliminar(CInt(ComboID.Text))
            clientes.poblarComboID(ComboID)
            clientes.poblarComboN(ComboNombre)
        End If
    End Sub

    Private Sub ComboPais_GotFocus(sender As Object, e As EventArgs) Handles ComboPais.GotFocus
        Dim paises As New ClasePais(ComboPais.Text)
        Dim estados As New ClaseEstado
        paises.poblarCombo(ComboPais)
    End Sub

    Private Sub ComboID_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboID.SelectedIndexChanged
        Dim clientes As New ClaseCliente(CInt(ComboID.Text))
        ComboNombre.Text = clientes.getNombre()
        obCliente = clientes.consultaCliente(obCliente)
        Me.poblarCampos(obCliente)
        BtnActualizar.Enabled = True
        BtnEliminar.Enabled = True
        BtnAgregar.Enabled = False
        BtnAdd.Enabled = True
    End Sub

    Public Sub poblarCampos(ByVal obCliente As Object)
        TxtNombre.Text = obCliente.item(1)
        TxtPat.Text = obCliente.item(2)
        TxtMat.Text = obCliente.item(3)
        NumEdad.Text = obCliente.item(4)
        TxtRfc.Text = obCliente.item(5)
        TxtCurp.Text = obCliente.item(6)
        If obCliente.item(7) = "Masculino" Then
            Masculino.Checked = True
        Else
            Femenino.Checked = True
        End If
        TxtEmail.Text = obCliente.item(8)
        TxtTel.Text = obCliente.item(9)
        TxtExt.Text = obCliente.item(10)
        TxtCalle.Text = obCliente.item(11)
        Dim colonia As New ClaseColonia(CInt(obCliente.item(12)))
        ComboColonia.Text = colonia.getNombre()
        Dim ciudad As New ClaseCiudad(CInt(colonia.getIdCiudad()))
        ComboCiudad.Text = ciudad.getNombre()
        Dim estado As New ClaseEstado(CInt(colonia.getIdEstado()))
        ComboEstado.Text = estado.getNombre()
        Dim pais As New ClasePais(CInt(colonia.getIdPais()))
        ComboPais.Text = pais.getNombre()

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

    Private Sub BtnAdd_Click(sender As Object, e As EventArgs) Handles BtnAdd.Click
        BtnActualizar.Enabled = False
        BtnEliminar.Enabled = False
        BtnAgregar.Enabled = True
        TxtNombre.Text = ""
        TxtPat.Text = ""
        TxtMat.Text = ""
        NumEdad.Text = ""
        TxtRfc.Text = ""
        TxtCurp.Text = ""
        Masculino.Checked = False
        Femenino.Checked = False
        TxtEmail.Text = ""
        TxtTel.Text = ""
        TxtExt.Text = ""
        TxtCalle.Text = ""
        Dim paises As New ClasePais
        paises.poblarCombo(ComboPais)
        BtnAdd.Enabled = False
    End Sub
End Class