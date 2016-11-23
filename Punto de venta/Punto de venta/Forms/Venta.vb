Public Class Venta
    Dim obProducto As Object
    Dim cont = 0

    'Llena todos los dropdown al iniciar el formulario
    Private Sub Venta_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim clientes As New ClaseCliente()
        clientes.poblarComboN(ComboCli)
        clientes.poblarComboID(ComboIDC)
        Dim proveedores As New ClaseProv()
        proveedores.poblarComboProveedores(ComboProv)
        proveedores.poblarComboIDP(ComboIDP)
        Dim productos As New ClaseProductos()
        productos.poblarComboProducto(ComboProducto, CInt(ComboIDP.Text))
        productos.poblarComboID(ComboID, CInt(ComboIDP.Text))
        cont = 1
    End Sub

    'Muestra el menú general al cerrar la ventana actual
    Private Sub Venta_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        MenuGeneral.Show()
    End Sub

    'Muestra el id del producto al momento de seleccionar el nombre del mismo en el dropdown
    Private Sub ComboProducto_SelectedIndexChanged() Handles ComboProducto.SelectedIndexChanged
        Dim productos As New ClaseProductos(ComboProducto.Text)
        ComboID.Text = productos.getId()
    End Sub

    'Muestra el nombre del producto al momento de seleccionar el id del mismo en el dropdown
    Private Sub ComboID_SelectedIndexChanged() Handles ComboID.SelectedIndexChanged
        Dim productos As New ClaseProductos(CInt(ComboID.Text))
        ComboProducto.Text = productos.getNombre()
        obProducto = productos.consultaProducto(obProducto)
    End Sub

    'Muestra el id del proveedor al momento de seleccionar el nombre del mismo en el dropdown
    Private Sub ComboProv_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboProv.SelectedIndexChanged
        Dim proveedores As New ClaseProv(ComboProv.Text)
        ComboIDP.Text = proveedores.getId()
        If cont = 1 Then
            Dim productos As New ClaseProductos()
            productos.poblarComboID(ComboID, CInt(ComboIDP.Text))
            productos.poblarComboProducto(ComboProducto, CInt(ComboIDP.Text))
        End If
    End Sub

    'Muestra el nombre del proveedor al momento de seleccionar el id del mismo en el dropdown
    Private Sub ComboIDP_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboIDP.SelectedIndexChanged
        Dim proveedores As New ClaseProv(CInt(ComboIDP.Text))
        ComboProv.Text = proveedores.getNombre()
        If cont = 1 Then
            Dim productos As New ClaseProductos()
            productos.poblarComboID(ComboID, CInt(ComboIDP.Text))
            productos.poblarComboProducto(ComboProducto, CInt(ComboIDP.Text))
        End If
    End Sub

    'Muestra el id del cliente al momento de seleccionar el nombre del mismo en el dropdown
    Private Sub ComboCli_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboCli.SelectedIndexChanged
        Dim clientes As New ClaseCliente(ComboCli.Text)
        ComboIDC.Text = clientes.getId()
    End Sub

    'Muestra el nombre del cliente al momento de seleccionar el id del mismo en el dropdown
    Private Sub ComboIDC_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboIDC.SelectedIndexChanged
        Dim clientes As New ClaseCliente(CInt(ComboIDC.Text))
        ComboCli.Text = clientes.getNombre()
    End Sub

    'Agrega el producto seleccionado al carrito y hace el cálculo del total
    Private Sub BtnAdd_Click(sender As Object, e As EventArgs) Handles BtnAdd.Click
        Dim prompt As String = "Teclea la cantidad de productos deseados: "
        Dim title As String = "Cantidad de productos"
        Dim a As Object
        Dim cantidad As Integer
        a = InputBox(prompt, title)

        If Not IsNumeric(a) Then
            MsgBox("Cantidad inválida de productos!")
        Else
            cantidad = CInt(a)
            If cantidad <= 0 Then
                MsgBox("Cantidad inválida de productos!")
            Else
                Dim lista As ListViewItem = New ListViewItem(ComboID.Text)
                lista.SubItems.Add(StrConv(ComboProducto.Text, VbStrConv.ProperCase))
                lista.SubItems.Add("$" & obProducto.Item(5))
                lista.SubItems.Add(cantidad)
                lista.SubItems.Add("$" & cantidad * obProducto.Item(5))
                ListView1.Items.Add(lista)

                Me.calculaTotal()
            End If
        End If
    End Sub

    'Quita el producto seleccionado del carrito
    Private Sub BtnElim_Click(sender As Object, e As EventArgs) Handles BtnElim.Click
        Dim lista As ListViewItem = New ListViewItem()
        For Each lista In ListView1.SelectedItems
            lista.Remove()
        Next
        Me.calculaTotal()
    End Sub

    'Quita todos los productos del carrito
    Private Sub BtnLimp_Click(sender As Object, e As EventArgs) Handles BtnLimp.Click
        ListView1.Items.Clear()
        Me.calculaTotal()
    End Sub

    Private Sub calculaTotal()
        Dim total As Double
        For i = 0 To ListView1.Items.Count - 1
            total += CDbl(ListView1.Items(i).SubItems(4).Text)
        Next i
        labelTotal.Text = "$" & total
    End Sub

    Private Sub BtnComp_Click(sender As Object, e As EventArgs) Handles BtnComp.Click
        Dim pago As String = ""
        Dim ventas As New ClaseVenta()
        If Efectivo.Checked Then
            pago = Efectivo.Text.ToString
        ElseIf Credito.Checked Then
            pago = Credito.Text.ToString
        End If
        If pago = "" Then
            MsgBox("No has seleccionado la forma de pago")
        ElseIf ListView1.Items.Count = 0 Then
            MsgBox("No has seleccionado ningún producto")
        Else
            For i = 0 To ListView1.Items.Count - 1
                ventas.inserta(session.Item(0), CInt(ComboIDC.Text), CDbl(ListView1.Items(i).SubItems(4).Text), pago, CInt(ListView1.Items(i).SubItems(0).Text), CInt(ListView1.Items(i).SubItems(3).Text))
            Next i
            MessageBox.Show("Compra registrada!")
            BtnLimp.PerformClick()
        End If
    End Sub
End Class