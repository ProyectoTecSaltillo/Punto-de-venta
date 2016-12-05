Public Class Devoluciones
    Dim fechaIn As MySql.Data.Types.MySqlDateTime = Nothing
    Dim devolucion As Object
    Private Sub Devoluciones_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim productos As New ClaseProductos
        productos.poblarCombo(Comboart)
        Empleado.Text = session.item(1) & " " & session.item(2) & " " & session.item(3)
        Dim dev As New ClaseDevolucion
        dev.poblarCombo(ComboSel)
    End Sub


    Private Sub Devoluciones_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        MenuGeneral.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles BtnAgregar.Click
        Dim dev As New ClaseDevolucion
        Dim producto As New ClaseProductos(TxtProducto.Text)

        dev.inserta(producto.getId(), session.item(0), TxtMotivo.Text, TxtCant.Text)
        dev.poblarCombo(ComboSel)
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboSel.SelectedIndexChanged
        Dim dev As New ClaseDevolucion()
        devolucion = dev.DatosDevolucion(devolucion, ComboSel.Text)
        If devolucion IsNot Nothing Then
            llenarCampos()
            BtnEliminar.Enabled = True
            BtnModificar.Enabled = True
            BtnAgregar.Enabled = False
        Else
            BtnEliminar.Enabled = False
            BtnModificar.Enabled = False
            BtnAgregar.Enabled = True
        End If

    End Sub

    Sub llenarCampos()
        TxtProducto.Text = devolucion.item(7)
        TxtCant.Text = devolucion.item(4)
        TxtMotivo.Text = devolucion.item(3)
    End Sub

    Private Sub Comboart_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Comboart.SelectedIndexChanged
        limpiar()
        TxtProducto.Text = Comboart.Text
        BtnEliminar.Enabled = False
        BtnModificar.Enabled = False
        BtnAgregar.Enabled = True
    End Sub
    Sub limpiar()
        TxtProducto.Text = ""
        TxtCant.Text = ""
        TxtMotivo.Text = ""
    End Sub

    Private Sub BtnLimpiar_Click(sender As Object, e As EventArgs) Handles BtnLimpiar.Click
        limpiar()
        BtnEliminar.Enabled = False
        BtnModificar.Enabled = False
        BtnAgregar.Enabled = True
    End Sub

    Private Sub BtnEliminar_Click(sender As Object, e As EventArgs) Handles BtnEliminar.Click
        Dim dev As New ClaseDevolucion()
        dev.eliminar(ComboSel.Text)
        dev.poblarCombo(ComboSel)
    End Sub

    Private Sub BtnModificar_Click(sender As Object, e As EventArgs) Handles BtnModificar.Click
        Dim dev As New ClaseDevolucion()
        Dim producto As New ClaseProductos(TxtProducto.Text)
        dev.modificar(ComboSel.Text, TxtMotivo.Text, producto.getId, TxtCant.Text)
        dev.poblarCombo(ComboSel)
    End Sub
End Class