Imports MySql.Data.MySqlClient
Public Class FrmPais
    Private cnx As New MySqlConnection
    Private Sub FrmPais_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Restablecer()
    End Sub


    Private Sub BtnLimpia_Click(ByVal sender As Object, ByVal e As EventArgs)
        Restablecer()
    End Sub

    'Inserta nuevos paises
    Private Sub BtnActualizarP_Click(sender As Object, e As EventArgs) Handles BtnActualizarP.Click
        Dim paises As New ClasePais(ComboPais.Text)
        If paises.actualiza(pais, TxtPais.Text) Then
            paises.poblarCombo(ComboPais)
            TxtPais.Text = ""
        End If
        Restablecer()
        cnx.Close()
    End Sub
    Private Sub BtnActualizarE_Click(sender As Object, e As EventArgs) Handles BtnActualizarE.Click
        Dim paises As New ClasePais(ComboPais.Text)
        Dim estados As New ClaseEstado(ComboEstado.Text)
        If estados.actualiza(estado, TxtEstado.Text) Then
            estados.poblarCombo(ComboEstado, paises.getId())
            TxtEstado.Text = ""
        End If
        Restablecer()
        cnx.Close()
    End Sub
    Private Sub BtnActualizarC_Click(sender As Object, e As EventArgs) Handles BtnActualizarC.Click
        Dim paises As New ClasePais(ComboPais.Text)
        Dim estados As New ClaseEstado(ComboEstado.Text)
        Dim ciudades As New ClaseCiudad(ComboCiudad.Text)
        If ciudades.actualiza(ciudad, TxtCiudad.Text) Then
            ciudades.poblarCombo(ComboCiudad, paises.getId(), estados.getId())
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

    'Habilita el botón insertar país si hay texto dentro del campo, de lo contrario, lo mantiene deshabilitado
    Private Sub TxtPais_TextChanged(sender As Object, e As EventArgs) Handles TxtPais.TextChanged
        If (ComboPais.Text <> "" And TxtPais.Text <> "") Then
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
                paises.inserta()
            Else
                MsgBox("Ese Pais ya existe, ingrese otro por favor")
            End If
            paises.poblarCombo(ComboPais)
            TxtPais.Text = ""
            Restablecer()
        End If
    End Sub
    Private Sub BtnInsertarE_Click(sender As Object, e As EventArgs) Handles BtnInsertarE.Click
        Dim paises As New ClasePais(ComboPais.Text)
        Dim estados As New ClaseEstado(TxtEstado.Text)
        If TxtEstado.Text = "" Then
            MessageBox.Show("Capturar nombre del Estado")
        Else
            If estados.consultaUno(estado) = False Then
                TxtEstado.Text = EL_nombre
                estados.inserta(paises.getId())
            Else
                MsgBox("Ese Estado ya existe, ingrese otro por favor")
            End If
            estados.poblarCombo(ComboEstado, paises.getId())
            TxtEstado.Text = ""
            Restablecer()
        End If
    End Sub

    Private Sub BtnInsertarC_Click(sender As Object, e As EventArgs) Handles BtnInsertarC.Click
        Dim paises As New ClasePais(ComboPais.Text)
        Dim estados As New ClaseEstado(ComboEstado.Text)
        Dim ciudades As New ClaseCiudad(TxtCiudad.Text)
        If TxtCiudad.Text = "" Then
            MessageBox.Show("Capturar nombre de la Ciudad")
        Else
            If ciudades.consultaUno(ciudad) = False Then
                TxtCiudad.Text = EL_nombre
                ciudades.inserta(paises.getId(), estados.getId())
            Else
                MsgBox("Esa Ciudad ya existe, ingrese otro por favor")
            End If
            ciudades.poblarCombo(ComboCiudad, paises.getId(), estados.getId())
            TxtCiudad.Text = ""
            Restablecer()
        End If
    End Sub
    Private Sub BtnInsertarCo_Click(sender As Object, e As EventArgs) Handles BtnInsertarCo.Click
        Dim paises As New ClasePais(ComboPais.Text)
        Dim estados As New ClaseEstado(ComboEstado.Text)
        Dim ciudades As New ClaseCiudad(ComboCiudad.Text)
        Dim colonias As New ClaseColonia(TxtColonia.Text)
        If TxtColonia.Text = "" Then
            MessageBox.Show("Capturar nombre de la Colonia")
        Else
            If colonias.consultaUno(colonia) = False Then
                TxtColonia.Text = EL_nombre
                colonias.inserta(paises.getId(), estados.getId(), ciudades.getId())
            Else
                MsgBox("Esa Colonia ya existe, ingrese otro por favor")
            End If
            colonias.poblarCombo(ComboColonia, paises.getId(), estados.getId(), ciudades.getId())
            TxtColonia.Text = ""
            Restablecer()
        End If
    End Sub

    Private Sub BtnEliminarP_Click(sender As Object, e As EventArgs) Handles BtnEliminarP.Click
        Dim cbselect = ComboPais.Text
        If MessageBox.Show("¿Deseas eliminar el pais " & cbselect & "?", "CONFIRMAR", MessageBoxButtons.YesNo) = System.Windows.Forms.DialogResult.Yes Then
            Dim paises As New ClasePais(cbselect)
            If paises.elimina() Then
                BtnEliminarP.Enabled = False
                paises.poblarCombo(ComboPais)
            End If
            TxtPais.Text = ""
            Restablecer()
        End If
    End Sub
    Private Sub BtnEliminarE_Click(sender As Object, e As EventArgs) Handles BtnEliminarE.Click
        Dim cbselect = ComboEstado.Text
        Dim paises As New ClasePais(ComboPais.Text)
        If MessageBox.Show("¿Deseas eliminar el Estado " & cbselect & "?", "CONFIRMAR", MessageBoxButtons.YesNo) = System.Windows.Forms.DialogResult.Yes Then
            Dim estados As New ClaseEstado(cbselect)
            If estados.elimina() Then
                BtnEliminarE.Enabled = False
                estados.poblarCombo(ComboEstado, paises.getId())
            End If
            TxtEstado.Text = ""
            Restablecer()
        End If
    End Sub
    Private Sub BtnEliminarC_Click(sender As Object, e As EventArgs) Handles BtnEliminarC.Click
        Dim cbselect = ComboCiudad.Text
        Dim paises As New ClasePais(ComboPais.Text)
        Dim estados As New ClaseEstado(ComboEstado.Text)
        If MessageBox.Show("¿Deseas eliminar la Ciudad " & cbselect & "?", "CONFIRMAR", MessageBoxButtons.YesNo) = System.Windows.Forms.DialogResult.Yes Then
            Dim ciudades As New ClaseCiudad(cbselect)
            If ciudades.elimina() Then
                BtnEliminarC.Enabled = False
                ciudades.poblarCombo(ComboCiudad, paises.getId(), estados.getId())
            End If
            TxtCiudad.Text = ""
            Restablecer()
        End If
    End Sub
    Private Sub BtnEliminarCo_Click(sender As Object, e As EventArgs) Handles BtnEliminarCo.Click
        Dim cbselect = ComboColonia.Text
        Dim paises As New ClasePais(ComboPais.Text)
        Dim estados As New ClaseEstado(ComboEstado.Text)
        Dim ciudades As New ClaseCiudad(ComboCiudad.Text)
        If MessageBox.Show("¿Deseas eliminar la Colonia " & cbselect & "?", "CONFIRMAR", MessageBoxButtons.YesNo) = System.Windows.Forms.DialogResult.Yes Then
            Dim colonias As New ClaseColonia(cbselect)
            If colonias.elimina() Then
                BtnEliminarCo.Enabled = False
                colonias.poblarCombo(ComboColonia, paises.getId(), estados.getId(), ciudades.getId())
            End If
            TxtColonia.Text = ""
            Restablecer()
        End If
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
        BtnEliminarE.Enabled = False
        BtnEliminarC.Enabled = False
        BtnEliminarCo.Enabled = False
        GBColonia.Enabled = False
        GBCiudad.Enabled = False
        estados.poblarCombo(ComboEstado, paises.getId())
        GBEstado.Enabled = True
        'error falla al desactivar el boton eliminar
        If paises.consultaAlgo(estado, paises.getId()) = True Then
            BtnEliminarP.Enabled = False
        Else
            BtnEliminarP.Enabled = True
        End If
    End Sub
    Private Sub ComboEstado_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboEstado.SelectedIndexChanged
        Dim paises As New ClasePais(ComboPais.Text)
        Dim estados As New ClaseEstado(ComboEstado.Text)
        Dim ciudades As New ClaseCiudad(ComboCiudad.Text)
        ComboCiudad.Text = "Seleccione..."
        ComboColonia.Text = "Seleccione..."
        BtnEliminarC.Enabled = False
        BtnEliminarCo.Enabled = False
        GBColonia.Enabled = False
        ciudades.poblarCombo(ComboCiudad, paises.getId(), estados.getId())
        GBCiudad.Enabled = True
        If estados.consultaAlgo(ciudad, estados.getId()) = True Then
            BtnEliminarE.Enabled = False
        Else
            BtnEliminarE.Enabled = True
        End If
    End Sub
    Private Sub ComboCiudad_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboCiudad.SelectedIndexChanged
        Dim paises As New ClasePais(ComboPais.Text)
        Dim estados As New ClaseEstado(ComboEstado.Text)
        Dim ciudades As New ClaseCiudad(ComboCiudad.Text)
        Dim colonias As New ClaseColonia(ComboColonia.Text)
        ComboColonia.Text = "Seleccione..."
        BtnEliminarCo.Enabled = False
        colonias.poblarCombo(ComboColonia, paises.getId(), estados.getId(), ciudades.getId())
        GBColonia.Enabled = True
        If ciudades.consultaAlgo(colonia, ciudades.getId()) = True Then
            BtnEliminarC.Enabled = False
        Else
            BtnEliminarC.Enabled = True
        End If
    End Sub

    Private Sub FrmPais_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        MenuGeneral.Show()
    End Sub
End Class