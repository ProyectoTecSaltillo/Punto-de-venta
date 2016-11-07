Public Class FrmProductos
    Dim obProducto As Object
    Dim cont = 0

    'Llena todos los dropdown al iniciar el formulario
    Private Sub FrmProductos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim proveedores As New ClaseProv()
        proveedores.poblarComboProveedores(ComboProv)
        proveedores.poblarComboIDP(ComboIDP)
        Dim productos As New ClaseProductos()
        productos.poblarComboProducto(ComboProducto, CInt(ComboIDP.Text))
        productos.poblarComboID(ComboID, CInt(ComboIDP.Text))
        cont = 1
    End Sub

    'Muestra el menú general al cerrar la ventana actual
    Private Sub FrmProductos_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        MenuGeneral.Show()
    End Sub

    'Hace una actualización al producto seleccionado del dropdown
    Private Sub BtnActualizar_Click(sender As Object, e As EventArgs) Handles BtnActualizar.Click
        If TxtNombre.Text = "" Or PrecioVenta.Text = "" Or PrecioCompra.Text = "" Or TxtDesc.Text = "" Then
            MsgBox("No puedes actualizar con campos vacíos")
        Else
            Dim productos As New ClaseProductos(CInt(ComboID.Text))
            productos.actualiza(CInt(ComboID.Text), TxtNombre.Text, PrecioVenta.Text, PrecioCompra.Text, TxtDesc.Text, TxtOb.Text)
            productos.poblarComboID(ComboID, CInt(ComboIDP.Text))
            productos.poblarComboProducto(ComboProducto, CInt(ComboIDP.Text))
        End If
    End Sub

    'Ingresa un nuevo producto
    Private Sub BtnAgregar_Click(sender As Object, e As EventArgs) Handles BtnAgregar.Click
        If TxtNombre.Text = "" Or PrecioVenta.Text = "" Or PrecioCompra.Text = "" Or TxtDesc.Text = "" Then
            MsgBox("No puedes registrar un producto con campos vacíos")
        Else
            Dim productos As New ClaseProductos()
            productos.inserta(TxtNombre.Text, TxtDesc.Text, CInt(ComboIDP.Text), session.Item(0), PrecioVenta.Text, PrecioCompra.Text, TxtOb.Text)
            productos.poblarComboID(ComboID, CInt(ComboIDP.Text))
            productos.poblarComboProducto(ComboProducto, CInt(ComboIDP.Text))
        End If
    End Sub

    'Elimina el producto seleccionado del dropdown
    Private Sub BtnEliminar_Click(sender As Object, e As EventArgs) Handles BtnEliminar.Click
        If MessageBox.Show("¿Deseas eliminar el producto " & ComboProducto.Text & "?", "CONFIRMAR", MessageBoxButtons.YesNo) = DialogResult.Yes Then
            Dim productos As New ClaseProductos()
            productos.eliminar(CInt(ComboID.Text))
            productos.poblarComboID(ComboID, CInt(ComboIDP.Text))
            productos.poblarComboProducto(ComboProducto, CInt(ComboIDP.Text))
        End If
    End Sub

    'Muestra el id del producto al momento de seleccionar el nombre del mismo en el dropdown
    Private Sub ComboProducto_SelectedIndexChanged() Handles ComboProducto.SelectedIndexChanged
        Dim productos As New ClaseProductos(ComboProducto.Text)
        ComboID.Text = productos.getId()
        BtnActualizar.Enabled = True
        BtnEliminar.Enabled = True
        BtnAgregar.Enabled = False
        BtnAdd.Enabled = True
    End Sub

    'Muestra el nombre del producto al momento de seleccionar el id del mismo en el dropdown
    Private Sub ComboID_SelectedIndexChanged() Handles ComboID.SelectedIndexChanged
        Dim productos As New ClaseProductos(CInt(ComboID.Text))
        ComboProducto.Text = productos.getNombre()
        obProducto = productos.consultaProducto(obProducto)
        Me.poblarCampos(obProducto)
        BtnActualizar.Enabled = True
        BtnEliminar.Enabled = True
        BtnAgregar.Enabled = False
        BtnAdd.Enabled = True
    End Sub

    'Método para mostrar la información completa del producto al seleccionarlo del dropdown
    Public Sub poblarCampos(ByVal obProducto As Object)
        TxtIDP.Text = ComboIDP.Text
        TxtNombre.Text = obProducto.item(1)
        TxtDesc.Text = obProducto.item(2)
        PrecioVenta.Text = obProducto.item(5)
        PrecioCompra.Text = obProducto.item(6)
        If Not IsDBNull(obProducto.item(7)) Then
            TxtOb.Text = obProducto.item(7)
        Else
            TxtOb.Text = ""
        End If
    End Sub

    'Muestra el id del proveedor al momento de seleccionar el nombre del mismo en el dropdown
    Private Sub ComboProv_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboProv.SelectedIndexChanged
        Dim proveedores As New ClaseProv(ComboProv.Text)
        ComboIDP.Text = proveedores.getId()
        TxtIDP.Text = ComboIDP.Text
        If cont = 1 Then
            Dim productos As New ClaseProductos()
            productos.poblarComboID(ComboID, CInt(ComboIDP.Text))
            productos.poblarComboProducto(ComboProducto, CInt(ComboIDP.Text))
        End If
        BtnActualizar.Enabled = True
        BtnEliminar.Enabled = True
        BtnAgregar.Enabled = False
        BtnAdd.Enabled = True
    End Sub

    'Muestra el nombre del proveedor al momento de seleccionar el id del mismo en el dropdown
    Private Sub ComboIDP_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboIDP.SelectedIndexChanged
        Dim proveedores As New ClaseProv(CInt(ComboIDP.Text))
        ComboProv.Text = proveedores.getNombre()
        TxtIDP.Text = ComboIDP.Text
        If cont = 1 Then
            Dim productos As New ClaseProductos()
            productos.poblarComboID(ComboID, CInt(ComboIDP.Text))
            productos.poblarComboProducto(ComboProducto, CInt(ComboIDP.Text))
        End If
        BtnActualizar.Enabled = True
        BtnEliminar.Enabled = True
        BtnAgregar.Enabled = False
        BtnAdd.Enabled = True
    End Sub

    Private Sub BtnAdd_Click(sender As Object, e As EventArgs) Handles BtnAdd.Click
        BtnActualizar.Enabled = False
        BtnEliminar.Enabled = False
        BtnAgregar.Enabled = True
        TxtNombre.Text = ""
        TxtDesc.Text = ""
        PrecioVenta.Text = ""
        PrecioCompra.Text = ""
        TxtOb.Text = ""
        BtnAdd.Enabled = False
    End Sub
End Class