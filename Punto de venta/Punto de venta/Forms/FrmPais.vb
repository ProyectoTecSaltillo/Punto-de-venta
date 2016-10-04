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

    Private Sub DGVPaises_CellContentClick(ByVal sender As Object, ByVal e As DataGridViewCellEventArgs) 
        Dim renglon As Integer
        '   renglon = DGVPaises.CurrentCellAddress.Y
        '      idpais = DGVPaises.Rows(renglon).Cells(0).Value
        ' TxtPais.Text = DGVPaises.Rows(renglon).Cells(1).Value

        Dim paises As New ClasePais(TxtPais.Text)
        If paises.consultaUnEstado() = False Then
            BtnEliminarP.Enabled = True
        Else
            BtnEliminarP.Enabled = False
        End If
        cnx.Close()
    End Sub

    'Inserta nuevos paises
    Private Sub BtnActualizar_Click(sender As Object, e As EventArgs) Handles BtnActualizarP.Click
        Dim paises As New ClasePais(TxtPais.Text)

        paises.getSetNombre = TxtPais.Text
        paises.actualizaPais()
        MsgBox("Registro modificado")
        'paises.poblarDataGridPaises(DGVPaises)
        TxtPais.Text = ""
        Restablecer()
        cnx.Close()
    End Sub

    Private Sub Restablecer()
        TxtPais.Text = ""
        TxtPais.Focus()
        BtnEliminarP.Enabled = False
        BtnActualizarP.Enabled = False
        BtnLimpia.Enabled = False
    End Sub

    'Habilita el botón guardar si hay text dentro del campo, de lo contrario, lo mantiene deshabilitado
    Private Sub TxtDescripcion_TextChanged(sender As Object, e As EventArgs) Handles TxtPais.TextChanged
        'Actualizar se activa con paises validos
        'If TxtPais.Text Is Nothing Or TxtPais.Text.Trim().Length < 1 Then
        '    BtnActualizarP.Enabled = False
        'Else
        '    BtnActualizarP.Enabled = True
        'End If
    End Sub

    Private Sub BtnInsertarP_Click(sender As Object, e As EventArgs) Handles BtnInsertarP.Click
        If TxtPais.Text = "" Then
            MessageBox.Show("Capturar nombre del Pais")
        Else
            Dim paises As New ClasePais(TxtPais.Text)
            If paises.consultaUnPais() = False Then
                TxtPais.Text = EL_nombre
                paises.insertaPais()
                MessageBox.Show("Registro insertado!")
            Else
                paises.getSetNombre = TxtPais.Text
                paises.actualizaPais()
                MsgBox("Registro modificado")
            End If
            paises.poblarComboPaises(ComboPais)
            TxtPais.Text = ""
            Restablecer()
        End If
    End Sub

    Private Sub ComboPais_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboPais.SelectedIndexChanged

    End Sub
End Class