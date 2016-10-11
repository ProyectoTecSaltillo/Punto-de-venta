Imports MySql.Data.MySqlClient
Public Class FrmPais
    Private cnx As New MySqlConnection
    Private Sub FrmPais_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Restablecer()
        'Dim paises As New ClasePais(ComboPais.Text)
        'Dim estados As New ClasePais
        'paises.poblarComboPaises(ComboPais)
    End Sub

    Private Sub BtnLimpia_Click(ByVal sender As Object, ByVal e As EventArgs)
        Restablecer()
    End Sub

    'Inserta nuevos paises
    Private Sub BtnActualizarP_Click(sender As Object, e As EventArgs) Handles BtnActualizarP.Click
        Dim paises As New ClasePais(ComboPais.Text)
        If paises.actualiza(pais, TxtPais.Text) Then
            paises.poblarComboPaises(ComboPais)
            TxtPais.Text = ""
        End If
        Restablecer()
        cnx.Close()
    End Sub
    Private Sub BtnActualizarE_Click(sender As Object, e As EventArgs) Handles BtnActualizarE.Click
        Dim paises As New ClasePais(ComboPais.Text)
        Dim estados As New ClasePais(ComboEstado.Text)
        If estados.actualiza(estado, TxtEstado.Text) Then
            estados.poblarComboEstados(ComboEstado, paises.getIdPais())
            TxtEstado.Text = ""
        End If
        Restablecer()
        cnx.Close()
    End Sub
    Private Sub BtnActualizarC_Click(sender As Object, e As EventArgs) Handles BtnActualizarC.Click
        Dim paises As New ClasePais(ComboPais.Text)
        Dim estados As New ClasePais(ComboEstado.Text)
        Dim ciudades As New ClasePais(ComboCiudad.Text)
        If ciudades.actualiza(ciudad, TxtCiudad.Text) Then
            ciudades.poblarComboCiudades(ComboCiudad, paises.getIdPais(), estados.getIdEstado)
            TxtCiudad.Text = ""
        End If
        Restablecer()
        cnx.Close()
    End Sub

    Private Sub Restablecer()
        TxtPais.Text = ""
        TxtPais.Focus()
        BtnEliminarP.Enabled = False
        BtnActualizarP.Enabled = False
        BtnEliminarE.Enabled = False
        BtnActualizarE.Enabled = False
        BtnLimpia.Enabled = False
    End Sub

    'Habilita el botón guardar si hay text dentro del campo, de lo contrario, lo mantiene deshabilitado
    Private Sub Txtpais_TextChanged(sender As Object, e As EventArgs) Handles TxtPais.TextChanged
        If (ComboPais.Text <> "" And Trim(TxtPais.Text) <> "") Then
            BtnActualizarP.Enabled = True
        Else
            BtnActualizarP.Enabled = False
        End If
    End Sub
    Private Sub Txtestado_TextChanged(sender As Object, e As EventArgs) Handles TxtEstado.TextChanged
        If (ComboEstado.Text <> "" And Trim(TxtEstado.Text) <> "") Then
            BtnActualizarE.Enabled = True
        Else
            BtnActualizarE.Enabled = False
        End If
    End Sub
    Private Sub Txtciudad_TextChanged(sender As Object, e As EventArgs) Handles TxtCiudad.TextChanged
        If (ComboCiudad.Text <> "" And Trim(TxtCiudad.Text) <> "") Then
            BtnActualizarC.Enabled = True
        Else
            BtnActualizarC.Enabled = False
        End If
    End Sub
    Private Sub TxtColonia_TextChanged(sender As Object, e As EventArgs) Handles TxtColonia.TextChanged
        If (ComboColonia.Text <> "" And Trim(TxtColonia.Text) <> "") Then
            BtnActualizarCo.Enabled = True
        Else
            BtnActualizarCo.Enabled = False
        End If
    End Sub

    Private Sub BtnInsertarP_Click(sender As Object, e As EventArgs) Handles BtnInsertarP.Click
        If TxtPais.Text = "" Then
            MessageBox.Show("Capturar nombre del Pais")
        Else
            Dim paises As New ClasePais(TxtPais.Text)
            If paises.consultaUno(pais) = False Then
                TxtPais.Text = EL_nombre
                paises.insertaP()
            End If
            paises.poblarComboPaises(ComboPais)
            TxtPais.Text = ""
            Restablecer()
        End If
    End Sub
    Private Sub BtnInsertarE_Click(sender As Object, e As EventArgs) Handles BtnInsertarE.Click
        Dim paises As New ClasePais(ComboPais.Text)
        Dim estados As New ClasePais(TxtEstado.Text)
        If TxtEstado.Text = "" Then
            MessageBox.Show("Capturar nombre del Estado")
        Else
            If estados.consultaUno(estado) = False Then
                TxtEstado.Text = EL_nombre
                estados.insertaE(paises.getIdPais())
            End If
            estados.poblarComboEstados(ComboEstado, paises.getIdPais())
            TxtEstado.Text = ""
            Restablecer()
        End If
    End Sub

    Private Sub BtnInsertarC_Click(sender As Object, e As EventArgs) Handles BtnInsertarC.Click
        Dim paises As New ClasePais(ComboPais.Text)
        Dim estados As New ClasePais(ComboEstado.Text)
        Dim ciudades As New ClasePais(TxtCiudad.Text)
        If TxtCiudad.Text = "" Then
            MessageBox.Show("Capturar nombre de la Ciudad")
        Else
            If ciudades.consultaUno(ciudad) = False Then
                TxtCiudad.Text = EL_nombre
                ciudades.insertaC(paises.getIdPais(), estados.getIdEstado())
            End If
            ciudades.poblarComboCiudades(ComboCiudad, paises.getIdPais(), estados.getIdEstado())
            TxtCiudad.Text = ""
            Restablecer()
        End If
    End Sub
    Private Sub BtnInsertarCo_Click(sender As Object, e As EventArgs) Handles BtnInsertarCo.Click
        Dim paises As New ClasePais(ComboPais.Text)
        Dim estados As New ClasePais(ComboEstado.Text)
        Dim ciudades As New ClasePais(ComboCiudad.Text)
        Dim colonias As New ClasePais(TxtColonia.Text)
        If TxtColonia.Text = "" Then
            MessageBox.Show("Capturar nombre de la Ciudad")
        Else
            If colonias.consultaUno(colonia) = False Then
                TxtColonia.Text = EL_nombre
                colonias.insertaCo(paises.getIdPais(), estados.getIdEstado(), ciudades.getIdCiudad)
            End If
            colonias.poblarComboColonias(ComboColonia, paises.getIdPais(), estados.getIdEstado(), ciudades.getIdCiudad)
            TxtColonia.Text = ""
            Restablecer()
        End If
    End Sub

    Private Sub BtnEliminarP_Click(sender As Object, e As EventArgs) Handles BtnEliminarP.Click
        Dim cbselect = ComboPais.Text
        If MessageBox.Show("¿Deseas eliminar el pais " & cbselect & "?", "CONFIRMAR", MessageBoxButtons.YesNo) = System.Windows.Forms.DialogResult.Yes Then
            Dim paises As New ClasePais(cbselect)
            If paises.elimina(pais) Then
                BtnEliminarP.Enabled = False
                paises.poblarComboPaises(ComboPais)
            End If
            TxtPais.Text = ""
            Restablecer()
        End If
    End Sub
    Private Sub BtnEliminarE_Click(sender As Object, e As EventArgs) Handles BtnEliminarE.Click
        Dim cbselect = ComboEstado.Text
        Dim paises As New ClasePais(ComboPais.Text)
        If MessageBox.Show("¿Deseas eliminar el Estado " & cbselect & "?", "CONFIRMAR", MessageBoxButtons.YesNo) = System.Windows.Forms.DialogResult.Yes Then
            Dim estados As New ClasePais(cbselect)
            If estados.elimina(estado) Then
                BtnEliminarE.Enabled = False
                estados.poblarComboEstados(ComboEstado, paises.getIdPais())
            End If
            TxtEstado.Text = ""
            Restablecer()
        End If
    End Sub
    Private Sub BtnEliminarC_Click(sender As Object, e As EventArgs) Handles BtnEliminarC.Click
        Dim cbselect = ComboCiudad.Text
        Dim paises As New ClasePais(ComboPais.Text)
        Dim estados As New ClasePais(ComboEstado.Text)
        If MessageBox.Show("¿Deseas eliminar la Ciudad " & cbselect & "?", "CONFIRMAR", MessageBoxButtons.YesNo) = System.Windows.Forms.DialogResult.Yes Then
            Dim ciudades As New ClasePais(cbselect)
            If ciudades.elimina(ciudad) Then
                BtnEliminarC.Enabled = False
                ciudades.poblarComboCiudades(ComboCiudad, paises.getIdPais(), estados.getIdEstado)
            End If
            TxtCiudad.Text = ""
            Restablecer()
        End If
    End Sub
    Private Sub BtnEliminarCo_Click(sender As Object, e As EventArgs) Handles BtnEliminarCo.Click
        Dim cbselect = ComboColonia.Text
        Dim paises As New ClasePais(ComboPais.Text)
        Dim estados As New ClasePais(ComboEstado.Text)
        Dim ciudades As New ClasePais(ComboCiudad.Text)
        If MessageBox.Show("¿Deseas eliminar la Colonia " & cbselect & "?", "CONFIRMAR", MessageBoxButtons.YesNo) = System.Windows.Forms.DialogResult.Yes Then
            Dim colonias As New ClasePais(cbselect)
            If colonias.elimina(colonia) Then
                BtnEliminarCo.Enabled = False
                colonias.poblarComboColonias(ComboColonia, paises.getIdPais(), estados.getIdEstado, ciudades.getIdCiudad)
            End If
            TxtColonia.Text = ""
            Restablecer()
        End If
    End Sub

    Private Sub ComboPais_GotFocus(sender As Object, e As EventArgs) Handles ComboPais.GotFocus
        Dim paises As New ClasePais(ComboPais.Text)
        Dim estados As New ClasePais
        paises.poblarComboPaises(ComboPais)
    End Sub
    Private Sub ComboEstado_GotFocus(sender As Object, e As EventArgs) Handles ComboEstado.GotFocus
        Dim paises As New ClasePais(ComboPais.Text)
        Dim estados As New ClasePais(ComboEstado.Text)
        estados.poblarComboEstados(ComboEstado, paises.getIdPais())
    End Sub
    Private Sub ComboCiudad_GotFocus(sender As Object, e As EventArgs) Handles ComboCiudad.GotFocus
        Dim paises As New ClasePais(ComboPais.Text)
        Dim estados As New ClasePais(ComboEstado.Text)
        Dim ciudades As New ClasePais(ComboCiudad.Text)
        ciudades.poblarComboCiudades(ComboCiudad, paises.getIdPais(), estados.getIdEstado)
    End Sub
    Private Sub Combocolonias_GotFocus(sender As Object, e As EventArgs) Handles ComboCiudad.GotFocus
        Dim paises As New ClasePais(ComboPais.Text)
        Dim estados As New ClasePais(ComboEstado.Text)
        Dim ciudades As New ClasePais(ComboCiudad.Text)
        Dim colonias As New ClasePais(ComboColonia.Text)
        colonias.poblarComboColonias(ComboColonia, paises.getIdPais(), estados.getIdEstado, ciudades.getIdCiudad)
    End Sub

    Private Sub ComboPais_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboPais.SelectedIndexChanged
        Dim paises As New ClasePais(ComboPais.Text)
        Dim estados As New ClasePais(ComboEstado.Text)
        estados.poblarComboEstados(ComboEstado, paises.getIdPais())
        GBEstado.Enabled = True
        If paises.consultaAlgoP(estado, paises.getIdPais) = True Then
            BtnEliminarP.Enabled = False
        Else
            BtnEliminarP.Enabled = True
        End If
    End Sub
    Private Sub ComboEstado_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboEstado.SelectedIndexChanged
        Dim paises As New ClasePais(ComboPais.Text)
        Dim estados As New ClasePais(ComboEstado.Text)
        Dim ciudades As New ClasePais(ComboCiudad.Text)
        ciudades.poblarComboCiudades(ComboCiudad, paises.getIdPais(), estados.getIdEstado())
        GBCiudad.Enabled = True
        If estados.consultaAlgoE(ciudad, estados.getIdEstado()) = True Then
            BtnEliminarE.Enabled = False
        Else
            BtnEliminarE.Enabled = True
        End If
    End Sub
    Private Sub ComboCiudad_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboCiudad.SelectedIndexChanged
        Dim paises As New ClasePais(ComboPais.Text)
        Dim estados As New ClasePais(ComboEstado.Text)
        Dim ciudades As New ClasePais(ComboCiudad.Text)
        Dim colonias As New ClasePais(ComboColonia.Text)
        colonias.poblarComboColonias(ComboColonia, paises.getIdPais(), estados.getIdEstado(), ciudades.getIdCiudad)
        GBColonia.Enabled = True
        If ciudades.consultaAlgoC(ciudad, ciudades.getIdCiudad()) = True Then
            BtnEliminarE.Enabled = False
        Else
            BtnEliminarE.Enabled = True
        End If
    End Sub

End Class