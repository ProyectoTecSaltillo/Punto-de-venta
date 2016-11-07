Public Class MtnProveedores
    Private Sub MtnProveedores_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim paises As New ClasePais
        Dim proveedores As New ClaseProveedores
        proveedores.PoblarDataGridProveedores(DGVproveedores)
        'empleados.poblarCombo(ComboNombre)
        paises.poblarCombo(ComboPais)
        ComboPais.Text = "Seleccione..."
        ComboColonia.Text = "Seleccione..."
        ComboCiudad.Text = "Seleccione..."
        ComboEstado.Text = "Seleccione..."
    End Sub

    Private Sub BtnInicio_Click(sender As Object, e As EventArgs) Handles BtnInicio.Click
        Me.Close()
        MenuGeneral.Show()
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
        ComboPais.Text = "Seleccione..."
        ComboEstado.Text = "Seleccione..."
        ComboCiudad.Text = "Seleccione..."
        ComboColonia.Text = "Seleccione..."

    End Sub
    Private Sub BtnEliminar_Click(sender As Object, e As EventArgs) Handles BtnEliminaP.Click
        Dim proveedor As New ClaseProveedores

        If MessageBox.Show("¿Esta seguro?", "CONFIRMAR", MessageBoxButtons.YesNo) = DialogResult.Yes Then


            Try

                proveedor.eliminaProveedor(TxtProveedor.Text, ComboPais.Text, ComboEstado.Text, ComboCiudad.Text, ComboColonia.Text, TxtRazonSocial.Text,
                                           TxtNombreR.Text, TxtCorreo.Text, TxtTelefono.Text, TxtTelefonoR.Text)

                TxtProveedor.Text = ""
                TxtRazonSocial.Text = ""
                TxtTelefono.Text = ""
                TxtCorreo.Text = ""
                TxtNombreR.Text = ""
                TxtTelefonoR.Text = ""
                ComboPais.Text = "Seleccione..."
                ComboEstado.Text = "Seleccione..."
                ComboCiudad.Text = "Seleccione..."
                ComboColonia.Text = "Seleccione..."

            Catch ex As Exception
                MessageBox.Show("No se puede eliminar")
            End Try
            proveedor.PoblarDataGridProveedores(DGVproveedores)
        End If
    End Sub

    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardaP.Click
        If TxtProveedor.Text = "" Then
            MessageBox.Show("Digite el id del proveedor !!")
        ElseIf TxtRazonSocial.Text = "" Then
            MessageBox.Show("Digite la razon social")
        ElseIf TxtTelefono.Text = "" Then
            MessageBox.Show("Digite el nombre !!")
        ElseIf ComboEstado.SelectedIndex.Equals(-1) Then
            MessageBox.Show("Elige el estado !!")
        ElseIf TxtCorreo.Text = "" Then
            MessageBox.Show("Digite el correo !!")
        ElseIf ComboPais.SelectedIndex.Equals(-1) Then
            MessageBox.Show("Elige el pais !!")
        ElseIf ComboCiudad.SelectedIndex.Equals(-1) Then
            MessageBox.Show("Elige la ciudad!!")
        ElseIf ComboColonia.SelectedIndex.Equals(-1) Then
            MessageBox.Show("Elige la colonia!!")
        ElseIf TxtNombreR.Text = "" Then
            MessageBox.Show("Digite el telefono !!")
        ElseIf TxtTelefonoR.Text = "" Then
            MessageBox.Show("Digite el telefono del representante")
        Else
            Try
                Dim pr As New ClaseProveedores

                If pr.consultaUnProveedor(TxtProveedor.Text) = False Then
                    'ByVal id_proovedor As Integer, ByVal idPais As Integer, ByVal idEstado As Integer, idCiudad As Integer, ByVal idColonia As Integer, ByVal razonSocial As String, ByVal nombre As String, ByVal correo As String, ByVal telefono As String, ByVal tel_repr As Integer
                    pr.insertaProveedor(TxtProveedor.Text, ComboPais.Text, ComboEstado.Text, ComboCiudad.Text, ComboColonia.Text, TxtRazonSocial.Text, TxtNombreR.Text, TxtCorreo.Text, TxtTelefono.Text, TxtTelefonoR.Text)
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
                MessageBox.Show(ex.Message) '"Inserte datos correctos")
            End Try
        End If
        'cnx.Close()
    End Sub
    Public Sub getSetCampos()

        Dim proveedor As New ClaseProveedores

        proveedor.getSetId_proveedor = TxtProveedor.Text
        proveedor.getSetPais = ComboPais.SelectedItem.ToString
        proveedor.getSetEstado = ComboEstado.SelectedItem.ToString
        proveedor.getSetCiudad = ComboCiudad.SelectedItem.ToString
        proveedor.getSetColonia = ComboColonia.SelectedItem.ToString
        proveedor.getSetRazonSocial = TxtRazonSocial.Text
        proveedor.getSetNombre = TxtNombreR.Text
        proveedor.getSetCorreo = TxtCorreo.Text
        proveedor.getSetTelefono = TxtTelefono.Text
        proveedor.getSetTelefonoRepresentante = TxtTelefonoR.Text

    End Sub

    Private Sub DGVProveedores_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGVproveedores.CellClick
        Dim renglon As Integer
        Dim proveedor As New ClaseProveedores
        Dim pais As String
        renglon = DGVproveedores.CurrentCellAddress.Y

        TxtProveedor.Text = DGVproveedores.Rows(renglon).Cells(0).Value
        TxtRazonSocial.Text = DGVproveedores.Rows(renglon).Cells(5).Value
        TxtNombreR.Text = DGVproveedores.Rows(renglon).Cells(6).Value
        TxtCorreo.Text = DGVproveedores.Rows(renglon).Cells(7).Value
        TxtTelefono.Text = DGVproveedores.Rows(renglon).Cells(8).Value
        TxtTelefonoR.Text = DGVproveedores.Rows(renglon).Cells(9).Value

        ComboPais.Text = DGVproveedores.Rows(renglon).Cells(1).Value

        'ComboPais.Text = proveedor.getNombrePais(DGVproveedores.Rows(renglon).Cells(1).Value)
        'ComboPais.SelectedValue = DGVproveedores.Rows(renglon).Cells(1).Value
        'proveedor.PoblamCmBxPais(ComboPais)

        'ComboEstado.SelectedValue = DGVproveedores.Rows(renglon).Cells(2).Value
        'proveedor.PoblamCmBxEstado(ComboEstado, DGVproveedores.Rows(renglon).Cells(1).Value)

        'ComboCiudad.SelectedValue = DGVproveedores.Rows(renglon).Cells(3).Value
        'proveedor.PoblamCmBxCiudades(ComboEstado, DGVproveedores.Rows(renglon).Cells(1).Value, DGVproveedores.Rows(renglon).Cells(2).Value)

        'ComboColonia.SelectedValue = DGVproveedores.Rows(renglon).Cells(4).Value
        'proveedor.PoblaCmBxColonias(ComboEstado, DGVproveedores.Rows(renglon).Cells(1).Value, DGVproveedores.Rows(renglon).Cells(2).Value, DGVproveedores.Rows(renglon).Cells(3).Value)

    End Sub



    Private Sub BtnExit_Click(sender As Object, e As EventArgs) Handles BtnExit.Click
        Me.Close()
    End Sub


End Class