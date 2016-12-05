<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Devoluciones
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TxtCant = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TxtMotivo = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Comboart = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Empleado = New System.Windows.Forms.Label()
        Me.BtnAgregar = New System.Windows.Forms.Button()
        Me.Buscar = New System.Windows.Forms.GroupBox()
        Me.ComboSel = New System.Windows.Forms.ComboBox()
        Me.TxtProducto = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.BtnLimpiar = New System.Windows.Forms.Button()
        Me.BtnEliminar = New System.Windows.Forms.Button()
        Me.BtnModificar = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.Buscar.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TxtProducto)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.TxtCant)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.TxtMotivo)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Comboart)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 106)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(827, 342)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos de la Devolucion"
        '
        'TxtCant
        '
        Me.TxtCant.Location = New System.Drawing.Point(94, 128)
        Me.TxtCant.Name = "TxtCant"
        Me.TxtCant.Size = New System.Drawing.Size(133, 22)
        Me.TxtCant.TabIndex = 12
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(17, 131)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(64, 17)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Cantidad"
        '
        'TxtMotivo
        '
        Me.TxtMotivo.Location = New System.Drawing.Point(94, 156)
        Me.TxtMotivo.Multiline = True
        Me.TxtMotivo.Name = "TxtMotivo"
        Me.TxtMotivo.Size = New System.Drawing.Size(561, 180)
        Me.TxtMotivo.TabIndex = 7
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(17, 159)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 17)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Motivo"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(26, 32)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 17)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Articulo"
        '
        'Comboart
        '
        Me.Comboart.FormattingEnabled = True
        Me.Comboart.Location = New System.Drawing.Point(94, 29)
        Me.Comboart.Name = "Comboart"
        Me.Comboart.Size = New System.Drawing.Size(264, 24)
        Me.Comboart.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(29, 464)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(71, 17)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Empleado"
        '
        'Empleado
        '
        Me.Empleado.AutoSize = True
        Me.Empleado.Location = New System.Drawing.Point(121, 464)
        Me.Empleado.Name = "Empleado"
        Me.Empleado.Size = New System.Drawing.Size(82, 17)
        Me.Empleado.TabIndex = 3
        Me.Empleado.Text = "El que logio"
        '
        'BtnAgregar
        '
        Me.BtnAgregar.Location = New System.Drawing.Point(377, 458)
        Me.BtnAgregar.Name = "BtnAgregar"
        Me.BtnAgregar.Size = New System.Drawing.Size(150, 26)
        Me.BtnAgregar.TabIndex = 4
        Me.BtnAgregar.Text = "Agregar"
        Me.BtnAgregar.UseVisualStyleBackColor = True
        '
        'Buscar
        '
        Me.Buscar.Controls.Add(Me.BtnLimpiar)
        Me.Buscar.Controls.Add(Me.ComboSel)
        Me.Buscar.Location = New System.Drawing.Point(12, 12)
        Me.Buscar.Name = "Buscar"
        Me.Buscar.Size = New System.Drawing.Size(827, 76)
        Me.Buscar.TabIndex = 5
        Me.Buscar.TabStop = False
        Me.Buscar.Text = "Buscar"
        '
        'ComboSel
        '
        Me.ComboSel.FormattingEnabled = True
        Me.ComboSel.Location = New System.Drawing.Point(20, 31)
        Me.ComboSel.Name = "ComboSel"
        Me.ComboSel.Size = New System.Drawing.Size(338, 24)
        Me.ComboSel.TabIndex = 0
        '
        'TxtProducto
        '
        Me.TxtProducto.Enabled = False
        Me.TxtProducto.Location = New System.Drawing.Point(94, 97)
        Me.TxtProducto.Name = "TxtProducto"
        Me.TxtProducto.Size = New System.Drawing.Size(133, 22)
        Me.TxtProducto.TabIndex = 14
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(17, 100)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(65, 17)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "Producto"
        '
        'BtnLimpiar
        '
        Me.BtnLimpiar.Location = New System.Drawing.Point(677, 27)
        Me.BtnLimpiar.Name = "BtnLimpiar"
        Me.BtnLimpiar.Size = New System.Drawing.Size(129, 31)
        Me.BtnLimpiar.TabIndex = 1
        Me.BtnLimpiar.Text = "Limpiar"
        Me.BtnLimpiar.UseVisualStyleBackColor = True
        '
        'BtnEliminar
        '
        Me.BtnEliminar.Enabled = False
        Me.BtnEliminar.Location = New System.Drawing.Point(689, 458)
        Me.BtnEliminar.Name = "BtnEliminar"
        Me.BtnEliminar.Size = New System.Drawing.Size(129, 27)
        Me.BtnEliminar.TabIndex = 6
        Me.BtnEliminar.Text = "Eliminar"
        Me.BtnEliminar.UseVisualStyleBackColor = True
        '
        'BtnModificar
        '
        Me.BtnModificar.Enabled = False
        Me.BtnModificar.Location = New System.Drawing.Point(533, 458)
        Me.BtnModificar.Name = "BtnModificar"
        Me.BtnModificar.Size = New System.Drawing.Size(150, 26)
        Me.BtnModificar.TabIndex = 7
        Me.BtnModificar.Text = "Modificar"
        Me.BtnModificar.UseVisualStyleBackColor = True
        '
        'Devoluciones
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(851, 493)
        Me.Controls.Add(Me.BtnModificar)
        Me.Controls.Add(Me.BtnEliminar)
        Me.Controls.Add(Me.Buscar)
        Me.Controls.Add(Me.BtnAgregar)
        Me.Controls.Add(Me.Empleado)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Devoluciones"
        Me.Text = "Devoluciones"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Buscar.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents TxtCant As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TxtMotivo As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Comboart As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Empleado As Label
    Friend WithEvents BtnAgregar As Button
    Friend WithEvents Buscar As GroupBox
    Friend WithEvents ComboSel As ComboBox
    Friend WithEvents TxtProducto As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents BtnLimpiar As Button
    Friend WithEvents BtnEliminar As Button
    Friend WithEvents BtnModificar As Button
End Class
