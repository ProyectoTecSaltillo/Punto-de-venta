Imports MySql.Data.MySqlClient
Public Class FrmPaises

    Dim flag As Boolean = True
    Private cnx As New MySqlConnection

    Private Sub FrmPaises_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TxtDescripcion.Enabled = False
        Dim paises As New ClasePaises
        paises.poblarDataGridPaises(DGVPaises)
        cnx.Close()
    End Sub

    Private Sub BtnLimpia_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BtnLimpia.Click
        Restablecer()
    End Sub

    Private Sub DGVPaises_CellContentClick(ByVal sender As Object, ByVal e As DataGridViewCellEventArgs) Handles DGVPaises.CellContentClick
        Dim renglon As Integer
        renglon = DGVPaises.CurrentCellAddress.Y
        Txt_idpais.Text = DGVPaises.Rows(renglon).Cells(0).Value
        TxtDescripcion.Text = DGVPaises.Rows(renglon).Cells(1).Value

        Dim paises As New ClasePaises(Txt_idpais.Text, TxtDescripcion.Text)
        If paises.consultaUnEstado() = False Then
            BtnEliminar.Enabled = True
        Else
            BtnEliminar.Enabled = False
        End If
        cnx.Close()
    End Sub

    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click
        If Txt_idpais.Text = "" Then
            MessageBox.Show("Capturar clave")
        ElseIf TxtDescripcion.Text = "" Then
            MessageBox.Show("Capturar nombre de la carrera")
        Else
            Dim paises As New ClasePaises(Txt_idpais.Text, TxtDescripcion.Text)
            'cnx.Close()
            paises.getSetidPais = Txt_idpais.Text
            If paises.consultaUnPais() = False Then
                paises.consultaMaxPais()
                Txt_idpais.Text = idpais
                paises.insertaPais()
                MessageBox.Show("Registro insertado!")
            Else
                paises.getSetidPais = Txt_idpais.Text
                paises.getSetNombre = TxtDescripcion.Text

                paises.actualizaPais()
                MsgBox("Registro modificado")
            End If
            paises.poblarDataGridPaises(DGVPaises)
            'cnx.Close()
            Txt_idpais.Text = ""
            TxtDescripcion.Text = ""
            Txt_idpais.Focus()
            Restablecer()
            cnx.Close()
        End If
    End Sub

    Private Sub BtnEliminar_Click(sender As Object, e As EventArgs) Handles BtnEliminar.Click
        If MessageBox.Show("¿Deseas eliminar el pais?", "CONFIRMAR", MessageBoxButtons.YesNo) = System.Windows.Forms.DialogResult.Yes Then
            Dim paises As New ClasePaises(Txt_idpais.Text, TxtDescripcion.Text)
            paises.eliminaPais()
            MessageBox.Show("Registro Eliminado")
            paises.poblarDataGridPaises(DGVPaises)
            cnx.Close()
            Txt_idpais.Text = ""
            TxtDescripcion.Text = ""
            Txt_idpais.Focus()
            Restablecer()
        End If
    End Sub

    Private Sub Txt_idpais_LostFocus(sender As Object, e As EventArgs) Handles Txt_idpais.LostFocus
        If Not IsNumeric(Txt_idpais.Text) Then
            '------
        Else
            Dim paises As New ClasePaises(Txt_idpais.Text, TxtDescripcion.Text)
            If paises.consultaUnPais() = True Then
                TxtDescripcion.Text = EL_nombre
                BtnGuardar.Enabled = False
                flag = False
                BtnEliminar.Enabled = True
            Else
                TxtDescripcion.Text = ""
                BtnGuardar.Enabled = True
                flag = True
                BtnEliminar.Enabled = False
            End If


            If paises.consultaUnPais() = True And paises.consultaUnEstado() = False Then
                BtnEliminar.Enabled = True
            Else
                BtnEliminar.Enabled = False
            End If
            cnx.Close()
        End If
    End Sub

    Private Sub TxtDescripcion_LostFocus(sender As Object, e As EventArgs) Handles TxtDescripcion.LostFocus
        If flag = True And TxtDescripcion.Text <> "" Then
            Dim paises As New ClasePaises(Txt_idpais.Text, TxtDescripcion.Text)
            If paises.consultaNombrePais() = True Then
                MsgBox("Ese pais ya está registrado")
                BtnGuardar.Enabled = False
                TxtDescripcion.Focus()
            Else
                BtnGuardar.Enabled = True
            End If
        Else
            cnx.Close()
        End If
    End Sub

    Private Sub Txt_idpais_TextChanged(sender As Object, e As EventArgs) Handles Txt_idpais.TextChanged
        If Txt_idpais.Text <> "" Then
            TxtDescripcion.Enabled = True
        Else
            TxtDescripcion.Enabled = False
            BtnGuardar.Enabled = False
            BtnEliminar.Enabled = False
        End If
        If Not IsNumeric(Txt_idpais.Text) Then
            Txt_idpais.Text = ""
        End If
    End Sub

    Private Sub Restablecer()
        Txt_idpais.Text = vbNullString
        TxtDescripcion.Text = ""
        Txt_idpais.Focus()
        BtnEliminar.Enabled = False
        BtnGuardar.Enabled = False
    End Sub
End Class
