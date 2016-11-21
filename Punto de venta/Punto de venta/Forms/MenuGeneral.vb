Public Class MenuGeneral
    Private Sub MenuGeneral_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ToolStripLabel1.Text = session.Item(1)
        If session.Item(6) <> 1 Then
            BtnProductos.Visible = False
            B.Visible = False
        End If
    End Sub

    Private Sub BtnMant_Click(sender As Object, e As EventArgs) Handles BtnMant.Click
        FrmPais.Show()
        Me.Hide()
    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub PerfilToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PerfilToolStripMenuItem.Click
        Perfil.Show()
        Me.Hide()
    End Sub

    Private Sub MenuGeneral_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        session = Nothing
        MsgBox("Vuelve pronto!")
        Login.Show()
    End Sub

    Private Sub BtnManEmp_Click(sender As Object, e As EventArgs) Handles BtnManEmp.Click
        Me.Hide()
        MtnEmpleados.Show()
    End Sub
    Private Sub BtnManCli_Click(sender As Object, e As EventArgs) Handles BtnManCli.Click
        MtnClientes.Show()
        Me.Hide()
    End Sub

    Private Sub BtnProductos_Click(sender As Object, e As EventArgs) Handles BtnProductos.Click
        FrmProductos.Show()
        Me.Hide()
    End Sub

    Private Sub B_Click(sender As Object, e As EventArgs) Handles B.Click
        MtnProveedores.Show()
        Me.Hide()
    End Sub

    Private Sub btnDev_Click(sender As Object, e As EventArgs) Handles btnDev.Click
        Me.Hide()
        Devoluciones.Show()
    End Sub

    Private Sub BtnReportes_Click(sender As Object, e As EventArgs) Handles BtnReportes.Click
        Me.Hide()
        Reportes.Show()
    End Sub

    Private Sub BtnVentas_Click(sender As Object, e As EventArgs) Handles BtnVentas.Click
        Me.Hide()
        Venta.Show()
    End Sub
End Class