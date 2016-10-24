Public Class MtnClientes

    Private Sub MtnClientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim clientes As New ClaseCliente(ComboNombre.Text)
        clientes.poblarCombo(ComboNombre)
    End Sub

    'Private Sub ComboNombre_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboNombre.SelectedIndexChanged

    'End Sub

    'Private Sub ComboNombre_GotFocus(sender As Object, e As EventArgs) Handles ComboNombre.GotFocus
    '    Dim clientes As New ClaseCliente(ComboNombre.Text)
    '    clientes.poblarCombo(ComboNombre)
    'End Sub

    Private Sub ComboNombre_SelectedValueChanged(sender As Object, e As EventArgs) Handles ComboNombre.SelectedValueChanged
        If ComboNombre.Text <> "" Then
            Dim clientes As New ClaseCliente()
            clientes.consultaCliente(ComboNombre.Text)
            TxtNombre.Text = clientee.Item(0)
            TxtPat.Text = clientee.Item(1)
            TxtMat.Text = clientee.Item(2)
            NumEdad.Text = clientee.Item(3)
            TxtRfc.Text = clientee.Item(4)
            TxtCurp.Text = clientee.Item(5)

            TxtEmail.Text = clientee.Item(7)
            TxtTel.Text = clientee.Item(8)
            TxtExt.Text = clientee.Item(9)
            TxtCalle.Text = clientee.Item(10)
            ComboCiudad.Text = clientee.Item(11)
        End If

    End Sub

    Private Sub MtnClientes_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        MenuGeneral.Show()
    End Sub

    Private Sub BtnModificar_Click(sender As Object, e As EventArgs) Handles BtnModificar.Click
        'TxtNombre.Text = Me.ComboNombre.SelectedItem.ToString
    End Sub

    Private Sub BtnAgregar_Click(sender As Object, e As EventArgs) Handles BtnAgregar.Click
        Dim clientes As New ClaseCliente()
        Dim colonias As New ClaseColonia(ComboColonia.Text)
        Dim sexo As String = Nothing
        If Masculino.Checked Then
            sexo = Masculino.Text.ToString
        ElseIf Femenino.Checked Then
            sexo = Femenino.Text.ToString
        End If
        clientes.inserta(TxtNombre.Text, TxtPat.Text, TxtMat.Text, NumEdad.Text, TxtRfc.Text, TxtCurp.Text, sexo, TxtEmail.Text, TxtTel.Text, TxtExt.Text, TxtCalle.Text, colonias.getId(colonia))
    End Sub

    Private Sub BtnEliminar_Click(sender As Object, e As EventArgs) Handles BtnEliminar.Click
        Dim clienteNombre = ComboNombre.Text
        Dim id = ComboID.Text
        If MessageBox.Show("¿Deseas eliminar al cliente " & clienteNombre & "?", "CONFIRMAR", MessageBoxButtons.YesNo) = System.Windows.Forms.DialogResult.Yes Then
            Dim cliente As New ClaseCliente(id)
            If cliente.elimina(clientes) Then
                cliente.poblarCombo(ComboNombre)
            End If
        End If
        clientes.elimina(ComboID.Text)
    End Sub

    Private Sub ComboPais_GotFocus(sender As Object, e As EventArgs) Handles ComboPais.GotFocus
        Dim paises As New ClasePais(ComboPais.Text)
        Dim estados As New ClaseEstado
        paises.poblarCombo(ComboPais)
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
End Class