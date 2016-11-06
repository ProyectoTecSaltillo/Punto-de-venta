Public Class MtnProveedores
    Private Sub MtnProveedores_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim paises As New ClasePais

        'empleados.poblarCombo(ComboNombre)
        paises.poblarCombo(ComboPais)
        ComboColonia.Text = "Seleccione..."
        ComboCiudad.Text = "Seleccione..."
        ComboEstado.Text = "Seleccione..."
    End Sub

    Private Sub BtnInicio_Click(sender As Object, e As EventArgs) Handles BtnInicio.Click
        Me.Close()
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

    Private Sub BtnLimpiaP_Click(sender As Object, e As EventArgs) Handles BtnLimpiaP.Click
        TxtProveedor.Text = ""
        TxtRazonSocial.Text = ""
        TxtTelefono.Text = ""
        TxtCorreo.Text = ""
        TxtNombreR.Text = ""
        TxtTelefonoR.Text = ""
    End Sub
    Private Sub BtnEliminar_Click(sender As Object, e As EventArgs) Handles BtnEliminaP.Click
        If MessageBox.Show("¿Esta seguro?", "CONFIRMAR", MessageBoxButtons.YesNo) = DialogResult.Yes Then
            Dim proveedor As New ClaseProveedores

            Try
                proveedor.getSetId_proveedor = TxtProveedor.Text
                proveedor.getSetRazonSocial = TxtRazonSocial.Text
                proveedor.getSetCorreo = TxtCorreo.Text
                proveedor.getSetTelefono = TxtTelefono.Text
                proveedor.getSetNombre = TxtNombreR.Text
                proveedor.getSetTelefonoRepresentante = TxtTelefonoR.Text
                proveedor.getSetPais = ComboPais.SelectedItem.ToString
                proveedor.getSetEstado = ComboEstado.SelectedItem.ToString
                proveedor.getSetCiudad = ComboCiudad.SelectedItem.ToString
                proveedor.getSetColonia = ComboColonia.SelectedItem.ToString

                proveedor.eliminaProveedor()
            Catch ex As Exception
                MessageBox.Show("No se puede eliminar")
            End Try
            proveedor.PoblarDataGridProveedores(DGVproveedores)
        End If
    End Sub

    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardaP.Click
        If TxtProveedor.Text = "" Then
            MessageBox.Show("Digite el id del proveedor !!")
        ElseIf ComboPais.SelectedItem = "" Then
            MessageBox.Show("Elige el pais !!")
        ElseIf ComboEstado.SelectedItem = "" Then
            MessageBox.Show("Elige el estado !!")
        ElseIf ComboCiudad.Text = "" Then
            MessageBox.Show("Elige la ciudad!!")
        ElseIf ComboColonia.Text = "" Then
            MessageBox.Show("Elige la colonia!!")
        ElseIf TxtRazonSocial.Text = "" Then
            MessageBox.Show("Digite la razon social")
        ElseIf TxtNombreR.Text = "" Then
            MessageBox.Show("Digite el nombre !!")
        ElseIf TxtCorreo.Text = "" Then
            MessageBox.Show("Digite el correo !!")
        ElseIf TxtTelefono.Text = "" Then
            MessageBox.Show("Digite el telefono !!")
        ElseIf TxtTelefonoR.Text = "" Then
            MessageBox.Show("Digite el telefono del representante")
        Else
            Try
                Dim pr As New ClaseProveedores(TxtProveedor.Text, ComboPais.SelectedItem.ToString(), ComboEstado.SelectedItem.ToString(), ComboCiudad.SelectedItem.ToString(),
                        ComboColonia.SelectedItem.ToString(), TxtRazonSocial.Text, TxtNombreR.Text, TxtCorreo.Text, TxtTelefono.Text, TxtTelefonoR.Text)

                If pr.consultaUnProveedor() = False Then
                    pr.insertaProveedor()
                    MessageBox.Show("Registro Insertado ...")
                Else
                    getSetCampos()
                    If MessageBox.Show("¿Actualizaras un registro?", "CONFIRMAR", MessageBoxButtons.YesNo) = DialogResult.Yes Then
                        pr.actualizaProveedor()
                        MsgBox("Registro modificado ...")
                    End If
                End If
                pr.PoblarDataGridProveedores(DGVproveedores)
            Catch ex As Exception
                MessageBox.Show("Inserte datos correctos")
            End Try
        End If
    End Sub
    Public Sub getSetCampos()

        Dim proveedor As New ClaseProveedores(TxtProveedor.Text, ComboPais.SelectedItem.ToString(), ComboEstado.SelectedItem.ToString(), ComboCiudad.SelectedItem.ToString(),
        ComboColonia.SelectedItem.ToString(), TxtRazonSocial.Text, TxtNombreR.Text, TxtCorreo.Text, TxtTelefono.Text, TxtTelefonoR.Text)

        proveedor.getSetId_proveedor = TxtProveedor.Text
        proveedor.getSetRazonSocial = TxtRazonSocial.Text
        proveedor.getSetCorreo = TxtCorreo.Text
        proveedor.getSetTelefono = TxtTelefono.Text
        proveedor.getSetNombre = TxtNombreR.Text
        proveedor.getSetTelefonoRepresentante = TxtTelefonoR.Text
        proveedor.getSetPais = ComboPais.SelectedItem.ToString
        proveedor.getSetEstado = ComboEstado.SelectedItem.ToString
        proveedor.getSetCiudad = ComboCiudad.SelectedItem.ToString
        proveedor.getSetColonia = ComboColonia.SelectedItem.ToString
    End Sub

    Private Sub DGVProveedores_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGVproveedores.CellContentClick
        Dim renglon As Integer
        renglon = DGVproveedores.CurrentCellAddress.Y
        TxtProveedor.Text = DGVproveedores.Rows(renglon).Cells(0).Value
        TxtRazonSocial.Text = DGVproveedores.Rows(renglon).Cells(1).Value
        TxtTelefono.Text = DGVproveedores.Rows(renglon).Cells(2).Value
        TxtCorreo.Text = DGVproveedores.Rows(renglon).Cells(3).Value
        TxtNombreR.Text = DGVproveedores.Rows(renglon).Cells(4).Value
        TxtTelefonoR.Text = DGVproveedores.Rows(renglon).Cells(5).Value
        ComboPais.Text = DGVproveedores.Rows(renglon).Cells(6).Value
        ComboEstado.Text = DGVproveedores.Rows(renglon).Cells(7).Value
        ComboCiudad.Text = DGVproveedores.Rows(renglon).Cells(8).Value
        ComboColonia.Text = DGVproveedores.Rows(renglon).Cells(9).Value
    End Sub

    Private Sub BtnExit_Click(sender As Object, e As EventArgs) Handles BtnExit.Click
        Me.Close()
    End Sub

    Private Sub BtnExit_MouseHover(sender As Object, e As EventArgs) Handles BtnExit.MouseHover
        BtnExit.Image = (My.Resources.x2_tamaño)
    End Sub

    Private Sub BtnExit_MouseLeave(sender As Object, e As EventArgs) Handles BtnExit.MouseLeave
        BtnExit.Image = (My.Resources.X_Tamaño)
    End Sub

    Private Sub BtnInicio_MouseHover(sender As Object, e As EventArgs) Handles BtnInicio.MouseHover
        BtnInicio.Image = (My.Resources.BotonMenu2_tamaño)
    End Sub

    Private Sub BtnInicio_MouseLeave(sender As Object, e As EventArgs) Handles BtnInicio.MouseLeave
        BtnInicio.Image = (My.Resources.BotonMenu_tamaño)
    End Sub

    Private Sub BtnGuardaP_MouseHover(sender As Object, e As EventArgs) Handles BtnGuardaP.MouseHover
        BtnGuardaP.Image = (My.Resources.Guardar2_tamaño)
    End Sub

    Private Sub BtnGuardaP_MouseLeave(sender As Object, e As EventArgs) Handles BtnGuardaP.MouseLeave
        BtnGuardaP.Image = (My.Resources.Guardar_Tamaño)
    End Sub

    Private Sub BtnLimpiaP_MouseHover(sender As Object, e As EventArgs) Handles BtnLimpiaP.MouseHover
        BtnLimpiaP.Image = (My.Resources.Limpiar2_tamaño)
    End Sub

    Private Sub BtnLimpiaP_MouseLeave(sender As Object, e As EventArgs) Handles BtnLimpiaP.MouseLeave
        BtnLimpiaP.Image = (My.Resources.Limpiar_tamaño)
    End Sub

    Private Sub BtnEliminaP_MouseHover(sender As Object, e As EventArgs) Handles BtnEliminaP.MouseHover
        BtnEliminaP.Image = (My.Resources.Eliminar2_tamaño)
    End Sub

    Private Sub BtnEliminaP_MouseLeave(sender As Object, e As EventArgs) Handles BtnEliminaP.MouseLeave
        BtnEliminaP.Image = (My.Resources.Eliminar_tamaño)
    End Sub
End Class