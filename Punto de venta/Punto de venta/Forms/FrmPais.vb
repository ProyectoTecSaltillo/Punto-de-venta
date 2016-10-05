Imports MySql.Data.MySqlClient
Public Class FrmPais
    Private cnx As New MySqlConnection
    Private Sub FrmPais_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Restablecer()
        Dim paises As New ClasePais
        paises.poblarComboPaises(ComboPais)
    End Sub

    Private Sub BtnLimpia_Click(ByVal sender As Object, ByVal e As EventArgs)
        Restablecer()
    End Sub

    'Inserta nuevos paises
    Private Sub BtnActualizar_Click(sender As Object, e As EventArgs) Handles BtnActualizarP.Click
        Dim paises As New ClasePais(ComboPais.Text)
        If paises.actualiza(pais, TxtPais.Text) Then
            paises.poblarComboPaises(ComboPais)
            TxtPais.Text = ""
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
    Private Sub TxtDescripcion_TextChanged(sender As Object, e As EventArgs) Handles TxtPais.TextChanged
        If (ComboPais.Text <> "" And TxtPais.Text <> "") Then
            BtnActualizarP.Enabled = True
        Else
            BtnActualizarP.Enabled = False
        End If
    End Sub

    Private Sub BtnInsertarP_Click(sender As Object, e As EventArgs) Handles BtnInsertarP.Click
        If TxtPais.Text = "" Then
            MessageBox.Show("Capturar nombre del Pais")
        Else
            Dim paises As New ClasePais(TxtPais.Text)
            If paises.consultaUno(pais) = False Then
                TxtPais.Text = EL_nombre
                paises.inserta(pais)
            End If
            paises.poblarComboPaises(ComboPais)
            TxtPais.Text = ""
            Restablecer()
        End If
    End Sub
    Private Sub ComboPais_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboPais.SelectedIndexChanged

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

    Private Sub ComboPais_GotFocus(sender As Object, e As EventArgs) Handles ComboPais.GotFocus
        BtnEliminarP.Enabled = True
        If ComboPais.Text <> "" Then
            GBEstado.Enabled = True
        Else
            GBEstado.Enabled = False
        End If
    End Sub

    Private Sub BtnInsertarE_Click(sender As Object, e As EventArgs) Handles BtnInsertarE.Click
        Dim paises As New ClasePais(ComboPais.Text)
        If paises.consultaUno(pais) = True Then
            Dim estados As New ClasePais(TxtEstado.Text)
            If estados.consultaUno(estado) = False Then
                TxtEstado.Text = EL_nombre
                estados.inserta(estado)
            End If
        End If
    End Sub
End Class