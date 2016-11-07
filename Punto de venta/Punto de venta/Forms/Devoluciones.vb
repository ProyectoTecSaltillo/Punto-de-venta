Public Class Devoluciones
    Dim fechaIn As MySql.Data.Types.MySqlDateTime = Nothing
    Private Sub Devoluciones_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim productos As New ClaseProductos
        productos.poblarCombo(Comboart)
        Empleado.Text = session.item(1) & " " & session.item(2) & " " & session.item(3)

    End Sub


    Private Sub Devoluciones_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        MenuGeneral.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim dev As New ClaseDevolucion
        Dim producto As New ClaseProductos(Comboart.Text)
        producto.getId()
        dev.inserta(producto.getProveedor, session.item(0), TextMotivo.Text, TxtCant.Text)
    End Sub
End Class