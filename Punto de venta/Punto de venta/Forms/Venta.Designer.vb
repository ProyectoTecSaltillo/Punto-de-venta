<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Venta
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ComboIDP = New System.Windows.Forms.ComboBox()
        Me.ComboIDC = New System.Windows.Forms.ComboBox()
        Me.ComboProv = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.ComboCli = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.ComboID = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.ComboProducto = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.BtnAdd = New System.Windows.Forms.Button()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.BtnComp = New System.Windows.Forms.Button()
        Me.BtnElim = New System.Windows.Forms.Button()
        Me.labelTotal = New System.Windows.Forms.Label()
        Me.BtnLimp = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Efectivo = New System.Windows.Forms.RadioButton()
        Me.Credito = New System.Windows.Forms.RadioButton()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(383, 390)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(51, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "TOTAL:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.ComboIDP)
        Me.GroupBox1.Controls.Add(Me.ComboIDC)
        Me.GroupBox1.Controls.Add(Me.ComboProv)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.ComboCli)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.ComboID)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.ComboProducto)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Location = New System.Drawing.Point(11, 11)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Size = New System.Drawing.Size(385, 108)
        Me.GroupBox1.TabIndex = 10
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Buscar"
        '
        'ComboIDP
        '
        Me.ComboIDP.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboIDP.FormattingEnabled = True
        Me.ComboIDP.Location = New System.Drawing.Point(329, 53)
        Me.ComboIDP.Margin = New System.Windows.Forms.Padding(2)
        Me.ComboIDP.Name = "ComboIDP"
        Me.ComboIDP.Size = New System.Drawing.Size(42, 21)
        Me.ComboIDP.TabIndex = 12
        '
        'ComboIDC
        '
        Me.ComboIDC.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboIDC.FormattingEnabled = True
        Me.ComboIDC.Location = New System.Drawing.Point(329, 28)
        Me.ComboIDC.Margin = New System.Windows.Forms.Padding(2)
        Me.ComboIDC.Name = "ComboIDC"
        Me.ComboIDC.Size = New System.Drawing.Size(42, 21)
        Me.ComboIDC.TabIndex = 8
        '
        'ComboProv
        '
        Me.ComboProv.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboProv.FormattingEnabled = True
        Me.ComboProv.Location = New System.Drawing.Point(66, 53)
        Me.ComboProv.Margin = New System.Windows.Forms.Padding(2)
        Me.ComboProv.Name = "ComboProv"
        Me.ComboProv.Size = New System.Drawing.Size(259, 21)
        Me.ComboProv.TabIndex = 9
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(5, 56)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(56, 13)
        Me.Label10.TabIndex = 11
        Me.Label10.Text = "Proveedor"
        '
        'ComboCli
        '
        Me.ComboCli.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboCli.FormattingEnabled = True
        Me.ComboCli.Location = New System.Drawing.Point(66, 28)
        Me.ComboCli.Margin = New System.Windows.Forms.Padding(2)
        Me.ComboCli.Name = "ComboCli"
        Me.ComboCli.Size = New System.Drawing.Size(259, 21)
        Me.ComboCli.TabIndex = 7
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(5, 30)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(39, 13)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Cliente"
        '
        'ComboID
        '
        Me.ComboID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboID.FormattingEnabled = True
        Me.ComboID.Location = New System.Drawing.Point(329, 78)
        Me.ComboID.Margin = New System.Windows.Forms.Padding(2)
        Me.ComboID.Name = "ComboID"
        Me.ComboID.Size = New System.Drawing.Size(42, 21)
        Me.ComboID.TabIndex = 2
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(340, 12)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(18, 13)
        Me.Label8.TabIndex = 2
        Me.Label8.Text = "ID"
        '
        'ComboProducto
        '
        Me.ComboProducto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboProducto.FormattingEnabled = True
        Me.ComboProducto.Location = New System.Drawing.Point(66, 78)
        Me.ComboProducto.Margin = New System.Windows.Forms.Padding(2)
        Me.ComboProducto.Name = "ComboProducto"
        Me.ComboProducto.Size = New System.Drawing.Size(259, 21)
        Me.ComboProducto.TabIndex = 1
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(5, 80)
        Me.Label9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(50, 13)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = "Producto"
        '
        'BtnAdd
        '
        Me.BtnAdd.Location = New System.Drawing.Point(443, 136)
        Me.BtnAdd.Name = "BtnAdd"
        Me.BtnAdd.Size = New System.Drawing.Size(74, 50)
        Me.BtnAdd.TabIndex = 27
        Me.BtnAdd.Text = "Agregar producto"
        Me.BtnAdd.UseVisualStyleBackColor = True
        '
        'ListView1
        '
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5})
        Me.ListView1.GridLines = True
        Me.ListView1.Location = New System.Drawing.Point(11, 135)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(419, 252)
        Me.ListView1.TabIndex = 29
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "ID"
        Me.ColumnHeader1.Width = 25
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Nombre"
        Me.ColumnHeader2.Width = 213
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Precio($)"
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Cantidad"
        Me.ColumnHeader4.Width = 62
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Total"
        '
        'BtnComp
        '
        Me.BtnComp.Location = New System.Drawing.Point(442, 341)
        Me.BtnComp.Name = "BtnComp"
        Me.BtnComp.Size = New System.Drawing.Size(75, 46)
        Me.BtnComp.TabIndex = 31
        Me.BtnComp.Text = "Comprar"
        Me.BtnComp.UseVisualStyleBackColor = True
        '
        'BtnElim
        '
        Me.BtnElim.Location = New System.Drawing.Point(443, 192)
        Me.BtnElim.Name = "BtnElim"
        Me.BtnElim.Size = New System.Drawing.Size(74, 50)
        Me.BtnElim.TabIndex = 32
        Me.BtnElim.Text = "Eliminar producto"
        Me.BtnElim.UseVisualStyleBackColor = True
        '
        'labelTotal
        '
        Me.labelTotal.AutoSize = True
        Me.labelTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelTotal.Location = New System.Drawing.Point(440, 390)
        Me.labelTotal.Name = "labelTotal"
        Me.labelTotal.Size = New System.Drawing.Size(25, 13)
        Me.labelTotal.TabIndex = 33
        Me.labelTotal.Text = "$ 0"
        '
        'BtnLimp
        '
        Me.BtnLimp.Location = New System.Drawing.Point(443, 248)
        Me.BtnLimp.Name = "BtnLimp"
        Me.BtnLimp.Size = New System.Drawing.Size(74, 50)
        Me.BtnLimp.TabIndex = 34
        Me.BtnLimp.Text = "Limpiar productos"
        Me.BtnLimp.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(401, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(81, 13)
        Me.Label1.TabIndex = 35
        Me.Label1.Text = "Forma de pago:"
        '
        'Efectivo
        '
        Me.Efectivo.AutoSize = True
        Me.Efectivo.Location = New System.Drawing.Point(404, 52)
        Me.Efectivo.Name = "Efectivo"
        Me.Efectivo.Size = New System.Drawing.Size(64, 17)
        Me.Efectivo.TabIndex = 36
        Me.Efectivo.TabStop = True
        Me.Efectivo.Text = "Efectivo"
        Me.Efectivo.UseVisualStyleBackColor = True
        '
        'Credito
        '
        Me.Credito.AutoSize = True
        Me.Credito.Location = New System.Drawing.Point(404, 75)
        Me.Credito.Name = "Credito"
        Me.Credito.Size = New System.Drawing.Size(108, 17)
        Me.Credito.TabIndex = 37
        Me.Credito.TabStop = True
        Me.Credito.Text = "Tarjeta de crédito"
        Me.Credito.UseVisualStyleBackColor = True
        '
        'Venta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(529, 412)
        Me.Controls.Add(Me.Credito)
        Me.Controls.Add(Me.Efectivo)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BtnLimp)
        Me.Controls.Add(Me.labelTotal)
        Me.Controls.Add(Me.BtnElim)
        Me.Controls.Add(Me.BtnComp)
        Me.Controls.Add(Me.ListView1)
        Me.Controls.Add(Me.BtnAdd)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label6)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "Venta"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Venta"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label6 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents ComboIDC As ComboBox
    Friend WithEvents ComboCli As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents ComboID As ComboBox
    Friend WithEvents Label8 As Label
    Friend WithEvents ComboProducto As ComboBox
    Friend WithEvents Label9 As Label
    Friend WithEvents ComboProv As ComboBox
    Friend WithEvents Label10 As Label
    Friend WithEvents ComboIDP As ComboBox
    Friend WithEvents BtnAdd As Button
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents ColumnHeader5 As ColumnHeader
    Friend WithEvents ListView1 As ListView
    Friend WithEvents BtnComp As Button
    Friend WithEvents BtnElim As Button
    Friend WithEvents labelTotal As Label
    Friend WithEvents BtnLimp As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Efectivo As RadioButton
    Friend WithEvents Credito As RadioButton
End Class
