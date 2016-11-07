<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmProductos
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ComboIDP = New System.Windows.Forms.ComboBox()
        Me.ComboProv = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ComboID = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ComboProducto = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.TxtNombre = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.PrecioCompra = New System.Windows.Forms.NumericUpDown()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtOb = New System.Windows.Forms.TextBox()
        Me.TxtDesc = New System.Windows.Forms.TextBox()
        Me.PrecioVenta = New System.Windows.Forms.NumericUpDown()
        Me.BtnAdd = New System.Windows.Forms.Button()
        Me.BtnEliminar = New System.Windows.Forms.Button()
        Me.BtnActualizar = New System.Windows.Forms.Button()
        Me.BtnAgregar = New System.Windows.Forms.Button()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.TxtIDP = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.PrecioCompra, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PrecioVenta, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.ComboIDP)
        Me.GroupBox1.Controls.Add(Me.ComboProv)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.ComboID)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.ComboProducto)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(11, 11)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Size = New System.Drawing.Size(370, 84)
        Me.GroupBox1.TabIndex = 9
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Buscar"
        '
        'ComboIDP
        '
        Me.ComboIDP.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboIDP.FormattingEnabled = True
        Me.ComboIDP.Location = New System.Drawing.Point(322, 52)
        Me.ComboIDP.Margin = New System.Windows.Forms.Padding(2)
        Me.ComboIDP.Name = "ComboIDP"
        Me.ComboIDP.Size = New System.Drawing.Size(42, 21)
        Me.ComboIDP.TabIndex = 8
        '
        'ComboProv
        '
        Me.ComboProv.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboProv.FormattingEnabled = True
        Me.ComboProv.Location = New System.Drawing.Point(59, 52)
        Me.ComboProv.Margin = New System.Windows.Forms.Padding(2)
        Me.ComboProv.Name = "ComboProv"
        Me.ComboProv.Size = New System.Drawing.Size(259, 21)
        Me.ComboProv.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(5, 55)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(56, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Proveedor"
        '
        'ComboID
        '
        Me.ComboID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboID.FormattingEnabled = True
        Me.ComboID.Location = New System.Drawing.Point(322, 27)
        Me.ComboID.Margin = New System.Windows.Forms.Padding(2)
        Me.ComboID.Name = "ComboID"
        Me.ComboID.Size = New System.Drawing.Size(42, 21)
        Me.ComboID.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(333, 11)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(18, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "ID"
        '
        'ComboProducto
        '
        Me.ComboProducto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboProducto.FormattingEnabled = True
        Me.ComboProducto.Location = New System.Drawing.Point(59, 27)
        Me.ComboProducto.Margin = New System.Windows.Forms.Padding(2)
        Me.ComboProducto.Name = "ComboProducto"
        Me.ComboProducto.Size = New System.Drawing.Size(259, 21)
        Me.ComboProducto.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(5, 30)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(50, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Producto"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.TxtIDP)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.TxtNombre)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.PrecioCompra)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.TxtOb)
        Me.GroupBox2.Controls.Add(Me.TxtDesc)
        Me.GroupBox2.Controls.Add(Me.PrecioVenta)
        Me.GroupBox2.Location = New System.Drawing.Point(11, 112)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox2.Size = New System.Drawing.Size(370, 275)
        Me.GroupBox2.TabIndex = 11
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Datos"
        '
        'TxtNombre
        '
        Me.TxtNombre.Location = New System.Drawing.Point(117, 54)
        Me.TxtNombre.Name = "TxtNombre"
        Me.TxtNombre.Size = New System.Drawing.Size(246, 20)
        Me.TxtNombre.TabIndex = 12
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(5, 57)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(106, 13)
        Me.Label11.TabIndex = 11
        Me.Label11.Text = "Nombre del producto"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(86, 95)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(35, 13)
        Me.Label10.TabIndex = 10
        Me.Label10.Text = "Venta"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Location = New System.Drawing.Point(269, 95)
        Me.Label9.Name = "Label9"
        Me.Label9.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label9.Size = New System.Drawing.Size(13, 13)
        Me.Label9.TabIndex = 9
        Me.Label9.Text = "$"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Location = New System.Drawing.Point(122, 95)
        Me.Label8.Name = "Label8"
        Me.Label8.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label8.Size = New System.Drawing.Size(13, 13)
        Me.Label8.TabIndex = 8
        Me.Label8.Text = "$"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(5, 198)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(78, 13)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "Observaciones"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(227, 95)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(43, 13)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Compra"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(5, 92)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(52, 13)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Precio de"
        '
        'PrecioCompra
        '
        Me.PrecioCompra.Increment = New Decimal(New Integer() {50, 0, 0, 0})
        Me.PrecioCompra.Location = New System.Drawing.Point(283, 92)
        Me.PrecioCompra.Maximum = New Decimal(New Integer() {999999, 0, 0, 0})
        Me.PrecioCompra.Name = "PrecioCompra"
        Me.PrecioCompra.Size = New System.Drawing.Size(80, 20)
        Me.PrecioCompra.TabIndex = 1
        Me.PrecioCompra.ThousandsSeparator = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(5, 129)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(63, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Descripción"
        '
        'TxtOb
        '
        Me.TxtOb.Location = New System.Drawing.Point(89, 198)
        Me.TxtOb.Multiline = True
        Me.TxtOb.Name = "TxtOb"
        Me.TxtOb.Size = New System.Drawing.Size(275, 66)
        Me.TxtOb.TabIndex = 3
        '
        'TxtDesc
        '
        Me.TxtDesc.Location = New System.Drawing.Point(89, 126)
        Me.TxtDesc.Multiline = True
        Me.TxtDesc.Name = "TxtDesc"
        Me.TxtDesc.Size = New System.Drawing.Size(275, 66)
        Me.TxtDesc.TabIndex = 2
        '
        'PrecioVenta
        '
        Me.PrecioVenta.Increment = New Decimal(New Integer() {50, 0, 0, 0})
        Me.PrecioVenta.Location = New System.Drawing.Point(137, 92)
        Me.PrecioVenta.Maximum = New Decimal(New Integer() {999999, 0, 0, 0})
        Me.PrecioVenta.Name = "PrecioVenta"
        Me.PrecioVenta.Size = New System.Drawing.Size(80, 20)
        Me.PrecioVenta.TabIndex = 0
        Me.PrecioVenta.ThousandsSeparator = True
        '
        'BtnAdd
        '
        Me.BtnAdd.Location = New System.Drawing.Point(421, 34)
        Me.BtnAdd.Name = "BtnAdd"
        Me.BtnAdd.Size = New System.Drawing.Size(74, 50)
        Me.BtnAdd.TabIndex = 26
        Me.BtnAdd.Text = "Agregar producto"
        Me.BtnAdd.UseVisualStyleBackColor = True
        '
        'BtnEliminar
        '
        Me.BtnEliminar.Location = New System.Drawing.Point(396, 368)
        Me.BtnEliminar.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnEliminar.Name = "BtnEliminar"
        Me.BtnEliminar.Size = New System.Drawing.Size(112, 33)
        Me.BtnEliminar.TabIndex = 29
        Me.BtnEliminar.Text = "Eliminar"
        Me.BtnEliminar.UseVisualStyleBackColor = True
        '
        'BtnActualizar
        '
        Me.BtnActualizar.Location = New System.Drawing.Point(396, 319)
        Me.BtnActualizar.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnActualizar.Name = "BtnActualizar"
        Me.BtnActualizar.Size = New System.Drawing.Size(112, 33)
        Me.BtnActualizar.TabIndex = 28
        Me.BtnActualizar.Text = "Actulizar"
        Me.BtnActualizar.UseVisualStyleBackColor = True
        '
        'BtnAgregar
        '
        Me.BtnAgregar.Enabled = False
        Me.BtnAgregar.Location = New System.Drawing.Point(396, 268)
        Me.BtnAgregar.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnAgregar.Name = "BtnAgregar"
        Me.BtnAgregar.Size = New System.Drawing.Size(112, 33)
        Me.BtnAgregar.TabIndex = 27
        Me.BtnAgregar.Text = "Agregar"
        Me.BtnAgregar.UseVisualStyleBackColor = True
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(25, 25)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(86, 13)
        Me.Label12.TabIndex = 13
        Me.Label12.Text = "ID del proveedor"
        '
        'TxtIDP
        '
        Me.TxtIDP.Enabled = False
        Me.TxtIDP.Location = New System.Drawing.Point(117, 22)
        Me.TxtIDP.Name = "TxtIDP"
        Me.TxtIDP.Size = New System.Drawing.Size(37, 20)
        Me.TxtIDP.TabIndex = 14
        '
        'FrmProductos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(529, 412)
        Me.Controls.Add(Me.BtnEliminar)
        Me.Controls.Add(Me.BtnActualizar)
        Me.Controls.Add(Me.BtnAgregar)
        Me.Controls.Add(Me.BtnAdd)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "FrmProductos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmProductos"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.PrecioCompra, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PrecioVenta, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents ComboIDP As ComboBox
    Friend WithEvents ComboProv As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents ComboID As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents ComboProducto As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TxtOb As TextBox
    Friend WithEvents TxtDesc As TextBox
    Friend WithEvents PrecioCompra As NumericUpDown
    Friend WithEvents PrecioVenta As NumericUpDown
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents BtnAdd As Button
    Friend WithEvents BtnEliminar As Button
    Friend WithEvents BtnActualizar As Button
    Friend WithEvents BtnAgregar As Button
    Friend WithEvents TxtNombre As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents TxtIDP As TextBox
    Friend WithEvents Label12 As Label
End Class
