Imports MySql.Data.MySqlClient
Public Class FrmPaises
    Private Sub FrmPaises_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim paises As New ClasePaises
        paises.poblarDataGridPaises(DGVpaises)
        cnx.close()
    End Sub

    Private Sub BtnLimpia_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BtnLimpia.Click
        Txt_idpais.Text = vbNullString
        TxtDescripcion.Text = ""
        Txt_idpais.Focus()
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
        cnx.close()
    End Sub

    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click
        If Txt_idpais.Text = "" Then
            MessageBox.Show("Capturar clave")
        ElseIf TxtDescripcion.Text = "" Then
            MessageBox.Show("Capturar nombre de la carrera")
        Else
            Dim paises As New ClasePaises(Txt_idpais.Text, TxtDescripcion.Text)
            paises.getSetidPais = Txt_idpais.Text
            If paises.consultaUnPais() = False Then
                paises.consultaMaxPais()
                Txt_idpais.Text = idPais
                paises.insertaPais()
                MessageBox.Show("Registro insertado!")
            Else
                paises.getSetidPais = Txt_idpais.Text
                paises.getSetNombre = TxtDescripcion.Text

                paises.actualizaPais()
                MsgBox("Registro modificado")
            End If
            paises.poblarDataGridPaises(DGVPaises)
            cnx.close()
        End If
    End Sub

    Private Sub BtnEliminar_Click(sender As Object, e As EventArgs) Handles BtnEliminar.Click
        If MessageBox.Show("Está seguro ??", "CONFIRMAR", MessageBox.YesNo) = WindowsFormsSection.Forms.DialogResult.Yes Then
            Dim paises As New ClasePaises(Txt_idpais.Text, TxtDescripcion.Text)
            paises.eliminaPais()
            MessageBox.Show("Registro Eliminado")
            paises.poblarDataGridPaises(DGVPaises)
            cnx.close()
        End If
    End Sub

    Private Sub Txt_idpais_LostFocus(sender As Object, e As EventArgs) Handles Txt_idpais.LostFocus
        If Not IsNumeric(Txt_idpais.Text) Then
            '------
        Else
            Dim paises As New ClasePaises(Txt_idpais.Text, TxtDescripcion.Text)
            If paises.consultaUnPais() = True Then
                TxtDescripcion.Text = El_nombre
            Else
                TxtDescripcion.Text = ""
            End If


            If paises.consultaUnEstado() = False Then
                BtnEliminar.Enabled = True
            Else
                BtnEliminar.Enabled = False
            End If
            cnx.close()
        End If
    End Sub

    Private Sub TxtDescripcion_LostFocus(sender As Object, e As EventArgs) Handles TxtDescripcion.LostFocus
        If TxtDescripcion.Text = "" Then
            '------
        Else
            Dim paises As New ClasePaises(Txt_idpais.Text, TxtDescripcion.Text)
            If paises.consultaNombrePais() = True Then
                MsgBox("Nombre de pais ya está siendo usado.")
                BtnGuardar.Enabled = False
            Else
                BtnGuardar.Enabled = True
            End If
            cnx.close()
        End If
    End Sub
End Class
