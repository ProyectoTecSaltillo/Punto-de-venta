<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MtnClientes
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
        Me.BtnEliminar = New System.Windows.Forms.Button()
        Me.BtnModificar = New System.Windows.Forms.Button()
        Me.BtnAgregar = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.TxtCalle = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.ComboColonia = New System.Windows.Forms.ComboBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.ComboEstado = New System.Windows.Forms.ComboBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.ComboPais = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.ComboCiudad = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TxtTel = New System.Windows.Forms.TextBox()
        Me.TxtEmail = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TxtMat = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TxtPat = New System.Windows.Forms.TextBox()
        Me.TxtNombre = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TxtExt = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ComboID = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ComboNombre = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.TxtRfc = New System.Windows.Forms.TextBox()
        Me.TxtCurp = New System.Windows.Forms.TextBox()
        Me.NumEdad = New System.Windows.Forms.NumericUpDown()
        Me.Masculino = New System.Windows.Forms.RadioButton()
        Me.Femenino = New System.Windows.Forms.RadioButton()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.NumEdad, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtnEliminar
        '
        Me.BtnEliminar.Location = New System.Drawing.Point(406, 364)
        Me.BtnEliminar.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnEliminar.Name = "BtnEliminar"
        Me.BtnEliminar.Size = New System.Drawing.Size(112, 33)
        Me.BtnEliminar.TabIndex = 13
        Me.BtnEliminar.Text = "Eliminar"
        Me.BtnEliminar.UseVisualStyleBackColor = True
        '
        'BtnModificar
        '
        Me.BtnModificar.Location = New System.Drawing.Point(406, 315)
        Me.BtnModificar.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnModificar.Name = "BtnModificar"
        Me.BtnModificar.Size = New System.Drawing.Size(112, 33)
        Me.BtnModificar.TabIndex = 12
        Me.BtnModificar.Text = "Modificar"
        Me.BtnModificar.UseVisualStyleBackColor = True
        '
        'BtnAgregar
        '
        Me.BtnAgregar.Location = New System.Drawing.Point(279, 364)
        Me.BtnAgregar.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnAgregar.Name = "BtnAgregar"
        Me.BtnAgregar.Size = New System.Drawing.Size(112, 33)
        Me.BtnAgregar.TabIndex = 11
        Me.BtnAgregar.Text = "Agregar"
        Me.BtnAgregar.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.TxtCalle)
        Me.GroupBox2.Controls.Add(Me.Label17)
        Me.GroupBox2.Controls.Add(Me.Label19)
        Me.GroupBox2.Controls.Add(Me.ComboColonia)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.ComboEstado)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.ComboPais)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.ComboCiudad)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.TxtTel)
        Me.GroupBox2.Controls.Add(Me.TxtEmail)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.TxtMat)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.TxtPat)
        Me.GroupBox2.Controls.Add(Me.TxtNombre)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Location = New System.Drawing.Point(10, 116)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox2.Size = New System.Drawing.Size(243, 289)
        Me.GroupBox2.TabIndex = 10
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Datos"
        '
        'TxtCalle
        '
        Me.TxtCalle.Location = New System.Drawing.Point(59, 260)
        Me.TxtCalle.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtCalle.Name = "TxtCalle"
        Me.TxtCalle.Size = New System.Drawing.Size(172, 20)
        Me.TxtCalle.TabIndex = 26
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(11, 138)
        Me.Label17.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(49, 13)
        Me.Label17.TabIndex = 23
        Me.Label17.Text = "Teléfono"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(21, 264)
        Me.Label19.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(30, 13)
        Me.Label19.TabIndex = 25
        Me.Label19.Text = "Calle"
        '
        'ComboColonia
        '
        Me.ComboColonia.FormattingEnabled = True
        Me.ComboColonia.Location = New System.Drawing.Point(59, 235)
        Me.ComboColonia.Margin = New System.Windows.Forms.Padding(2)
        Me.ComboColonia.Name = "ComboColonia"
        Me.ComboColonia.Size = New System.Drawing.Size(171, 21)
        Me.ComboColonia.TabIndex = 18
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(11, 211)
        Me.Label12.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(40, 13)
        Me.Label12.TabIndex = 17
        Me.Label12.Text = "Ciudad"
        '
        'ComboEstado
        '
        Me.ComboEstado.FormattingEnabled = True
        Me.ComboEstado.Location = New System.Drawing.Point(59, 185)
        Me.ComboEstado.Margin = New System.Windows.Forms.Padding(2)
        Me.ComboEstado.Name = "ComboEstado"
        Me.ComboEstado.Size = New System.Drawing.Size(171, 21)
        Me.ComboEstado.TabIndex = 16
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(11, 187)
        Me.Label11.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(40, 13)
        Me.Label11.TabIndex = 15
        Me.Label11.Text = "Estado"
        '
        'ComboPais
        '
        Me.ComboPais.FormattingEnabled = True
        Me.ComboPais.Location = New System.Drawing.Point(59, 159)
        Me.ComboPais.Margin = New System.Windows.Forms.Padding(2)
        Me.ComboPais.Name = "ComboPais"
        Me.ComboPais.Size = New System.Drawing.Size(171, 21)
        Me.ComboPais.TabIndex = 14
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(11, 162)
        Me.Label10.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(27, 13)
        Me.Label10.TabIndex = 13
        Me.Label10.Text = "Pais"
        '
        'ComboCiudad
        '
        Me.ComboCiudad.FormattingEnabled = True
        Me.ComboCiudad.Location = New System.Drawing.Point(59, 211)
        Me.ComboCiudad.Margin = New System.Windows.Forms.Padding(2)
        Me.ComboCiudad.Name = "ComboCiudad"
        Me.ComboCiudad.Size = New System.Drawing.Size(171, 21)
        Me.ComboCiudad.TabIndex = 5
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(11, 237)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(42, 13)
        Me.Label8.TabIndex = 4
        Me.Label8.Text = "Colonia"
        '
        'TxtTel
        '
        Me.TxtTel.Location = New System.Drawing.Point(64, 135)
        Me.TxtTel.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtTel.Name = "TxtTel"
        Me.TxtTel.Size = New System.Drawing.Size(167, 20)
        Me.TxtTel.TabIndex = 10
        '
        'TxtEmail
        '
        Me.TxtEmail.Location = New System.Drawing.Point(47, 106)
        Me.TxtEmail.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtEmail.Name = "TxtEmail"
        Me.TxtEmail.Size = New System.Drawing.Size(183, 20)
        Me.TxtEmail.TabIndex = 8
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(11, 109)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(32, 13)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "Email"
        '
        'TxtMat
        '
        Me.TxtMat.Location = New System.Drawing.Point(100, 76)
        Me.TxtMat.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtMat.Name = "TxtMat"
        Me.TxtMat.Size = New System.Drawing.Size(130, 20)
        Me.TxtMat.TabIndex = 6
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(11, 78)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(86, 13)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Apellido Materno"
        '
        'TxtPat
        '
        Me.TxtPat.Location = New System.Drawing.Point(100, 47)
        Me.TxtPat.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtPat.Name = "TxtPat"
        Me.TxtPat.Size = New System.Drawing.Size(130, 20)
        Me.TxtPat.TabIndex = 4
        '
        'TxtNombre
        '
        Me.TxtNombre.Location = New System.Drawing.Point(75, 20)
        Me.TxtNombre.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtNombre.Name = "TxtNombre"
        Me.TxtNombre.Size = New System.Drawing.Size(155, 20)
        Me.TxtNombre.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(11, 50)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(84, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Apellido Paterno"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(11, 23)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(58, 13)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Nombre (s)"
        '
        'TxtExt
        '
        Me.TxtExt.Location = New System.Drawing.Point(362, 133)
        Me.TxtExt.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtExt.Name = "TxtExt"
        Me.TxtExt.Size = New System.Drawing.Size(134, 20)
        Me.TxtExt.TabIndex = 12
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.ComboID)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.ComboNombre)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(10, 10)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Size = New System.Drawing.Size(334, 93)
        Me.GroupBox1.TabIndex = 8
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Buscar"
        '
        'ComboID
        '
        Me.ComboID.FormattingEnabled = True
        Me.ComboID.Location = New System.Drawing.Point(59, 47)
        Me.ComboID.Margin = New System.Windows.Forms.Padding(2)
        Me.ComboID.Name = "ComboID"
        Me.ComboID.Size = New System.Drawing.Size(259, 21)
        Me.ComboID.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(32, 50)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(18, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "ID"
        '
        'ComboNombre
        '
        Me.ComboNombre.FormattingEnabled = True
        Me.ComboNombre.Location = New System.Drawing.Point(59, 23)
        Me.ComboNombre.Margin = New System.Windows.Forms.Padding(2)
        Me.ComboNombre.Name = "ComboNombre"
        Me.ComboNombre.Size = New System.Drawing.Size(259, 21)
        Me.ComboNombre.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(11, 23)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nombre"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(298, 162)
        Me.Label13.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(32, 13)
        Me.Label13.TabIndex = 19
        Me.Label13.Text = "Edad"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(302, 185)
        Me.Label14.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(28, 13)
        Me.Label14.TabIndex = 20
        Me.Label14.Text = "RFC"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(298, 220)
        Me.Label15.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(37, 13)
        Me.Label15.TabIndex = 21
        Me.Label15.Text = "CURP"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(304, 248)
        Me.Label16.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(31, 13)
        Me.Label16.TabIndex = 22
        Me.Label16.Text = "Sexo"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(276, 136)
        Me.Label18.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(82, 13)
        Me.Label18.TabIndex = 24
        Me.Label18.Text = "Número Exterior"
        '
        'TxtRfc
        '
        Me.TxtRfc.Location = New System.Drawing.Point(339, 182)
        Me.TxtRfc.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtRfc.Name = "TxtRfc"
        Me.TxtRfc.Size = New System.Drawing.Size(157, 20)
        Me.TxtRfc.TabIndex = 25
        '
        'TxtCurp
        '
        Me.TxtCurp.Location = New System.Drawing.Point(339, 217)
        Me.TxtCurp.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtCurp.Name = "TxtCurp"
        Me.TxtCurp.Size = New System.Drawing.Size(157, 20)
        Me.TxtCurp.TabIndex = 26
        '
        'NumEdad
        '
        Me.NumEdad.Location = New System.Drawing.Point(339, 157)
        Me.NumEdad.Minimum = New Decimal(New Integer() {18, 0, 0, 0})
        Me.NumEdad.Name = "NumEdad"
        Me.NumEdad.Size = New System.Drawing.Size(41, 20)
        Me.NumEdad.TabIndex = 27
        Me.NumEdad.Value = New Decimal(New Integer() {18, 0, 0, 0})
        '
        'Masculino
        '
        Me.Masculino.AutoSize = True
        Me.Masculino.Location = New System.Drawing.Point(346, 246)
        Me.Masculino.Name = "Masculino"
        Me.Masculino.Size = New System.Drawing.Size(73, 17)
        Me.Masculino.TabIndex = 28
        Me.Masculino.TabStop = True
        Me.Masculino.Text = "Masculino"
        Me.Masculino.UseVisualStyleBackColor = True
        '
        'Femenino
        '
        Me.Femenino.AutoSize = True
        Me.Femenino.Location = New System.Drawing.Point(425, 246)
        Me.Femenino.Name = "Femenino"
        Me.Femenino.Size = New System.Drawing.Size(71, 17)
        Me.Femenino.TabIndex = 29
        Me.Femenino.TabStop = True
        Me.Femenino.Text = "Femenino"
        Me.Femenino.UseVisualStyleBackColor = True
        '
        'MtnClientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(529, 412)
        Me.Controls.Add(Me.Femenino)
        Me.Controls.Add(Me.Masculino)
        Me.Controls.Add(Me.NumEdad)
        Me.Controls.Add(Me.TxtCurp)
        Me.Controls.Add(Me.TxtRfc)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.BtnEliminar)
        Me.Controls.Add(Me.BtnModificar)
        Me.Controls.Add(Me.BtnAgregar)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.TxtExt)
        Me.Name = "MtnClientes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MtnClientes"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.NumEdad, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnEliminar As Button
    Friend WithEvents BtnModificar As Button
    Friend WithEvents BtnAgregar As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents TxtCalle As TextBox
    Friend WithEvents Label17 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents ComboColonia As ComboBox
    Friend WithEvents Label12 As Label
    Friend WithEvents ComboEstado As ComboBox
    Friend WithEvents Label11 As Label
    Friend WithEvents ComboPais As ComboBox
    Friend WithEvents Label10 As Label
    Friend WithEvents ComboCiudad As ComboBox
    Friend WithEvents Label8 As Label
    Friend WithEvents TxtTel As TextBox
    Friend WithEvents TxtEmail As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents TxtMat As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TxtPat As TextBox
    Friend WithEvents TxtNombre As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents TxtExt As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents ComboID As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents ComboNombre As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents TxtRfc As TextBox
    Friend WithEvents TxtCurp As TextBox
    Friend WithEvents NumEdad As NumericUpDown
    Friend WithEvents Femenino As RadioButton
    Friend WithEvents Masculino As RadioButton
End Class
