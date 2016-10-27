<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MtnProveedores
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtRazonSocial = New System.Windows.Forms.TextBox()
        Me.TxtTelefono = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtCorreo = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TxtProveedor = New System.Windows.Forms.TextBox()
        Me.ComboColonia = New System.Windows.Forms.ComboBox()
        Me.ComboCiudad = New System.Windows.Forms.ComboBox()
        Me.ComboEstado = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ComboPais = New System.Windows.Forms.ComboBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.TxtTelefonoR = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TxtNombreR = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.BtnGuardaP = New System.Windows.Forms.Button()
        Me.BtnLimpiaP = New System.Windows.Forms.Button()
        Me.BtnEliminaP = New System.Windows.Forms.Button()
        Me.DGVproveedores = New System.Windows.Forms.DataGridView()
        Me.BtnInicio = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DGVproveedores, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(231, 23)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(71, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Razon social:"
        '
        'TxtRazonSocial
        '
        Me.TxtRazonSocial.Location = New System.Drawing.Point(308, 16)
        Me.TxtRazonSocial.Name = "TxtRazonSocial"
        Me.TxtRazonSocial.Size = New System.Drawing.Size(233, 20)
        Me.TxtRazonSocial.TabIndex = 2
        '
        'TxtTelefono
        '
        Me.TxtTelefono.Location = New System.Drawing.Point(90, 47)
        Me.TxtTelefono.Name = "TxtTelefono"
        Me.TxtTelefono.Size = New System.Drawing.Size(127, 20)
        Me.TxtTelefono.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(13, 54)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(52, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Telefono:"
        '
        'TxtCorreo
        '
        Me.TxtCorreo.Location = New System.Drawing.Point(90, 73)
        Me.TxtCorreo.Name = "TxtCorreo"
        Me.TxtCorreo.Size = New System.Drawing.Size(166, 20)
        Me.TxtCorreo.TabIndex = 6
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(13, 80)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(41, 13)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Correo:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.TxtProveedor)
        Me.GroupBox1.Controls.Add(Me.ComboColonia)
        Me.GroupBox1.Controls.Add(Me.ComboCiudad)
        Me.GroupBox1.Controls.Add(Me.ComboEstado)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.ComboPais)
        Me.GroupBox1.Controls.Add(Me.TxtCorreo)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.TxtRazonSocial)
        Me.GroupBox1.Controls.Add(Me.TxtTelefono)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Location = New System.Drawing.Point(23, 23)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(569, 172)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(14, 23)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(70, 13)
        Me.Label10.TabIndex = 20
        Me.Label10.Text = "Id proveedor:"
        '
        'TxtProveedor
        '
        Me.TxtProveedor.Location = New System.Drawing.Point(91, 16)
        Me.TxtProveedor.Name = "TxtProveedor"
        Me.TxtProveedor.Size = New System.Drawing.Size(120, 20)
        Me.TxtProveedor.TabIndex = 21
        '
        'ComboColonia
        '
        Me.ComboColonia.FormattingEnabled = True
        Me.ComboColonia.Location = New System.Drawing.Point(323, 135)
        Me.ComboColonia.Name = "ComboColonia"
        Me.ComboColonia.Size = New System.Drawing.Size(121, 21)
        Me.ComboColonia.TabIndex = 19
        '
        'ComboCiudad
        '
        Me.ComboCiudad.FormattingEnabled = True
        Me.ComboCiudad.Location = New System.Drawing.Point(323, 106)
        Me.ComboCiudad.Name = "ComboCiudad"
        Me.ComboCiudad.Size = New System.Drawing.Size(121, 21)
        Me.ComboCiudad.TabIndex = 18
        '
        'ComboEstado
        '
        Me.ComboEstado.FormattingEnabled = True
        Me.ComboEstado.Location = New System.Drawing.Point(90, 140)
        Me.ComboEstado.Name = "ComboEstado"
        Me.ComboEstado.Size = New System.Drawing.Size(121, 21)
        Me.ComboEstado.TabIndex = 17
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(13, 108)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(30, 13)
        Me.Label9.TabIndex = 16
        Me.Label9.Text = "Pais:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(13, 143)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(43, 13)
        Me.Label8.TabIndex = 15
        Me.Label8.Text = "Estado:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(246, 109)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(43, 13)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "Ciudad:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(246, 138)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(45, 13)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Colonia:"
        '
        'ComboPais
        '
        Me.ComboPais.FormattingEnabled = True
        Me.ComboPais.Location = New System.Drawing.Point(90, 105)
        Me.ComboPais.Name = "ComboPais"
        Me.ComboPais.Size = New System.Drawing.Size(121, 21)
        Me.ComboPais.TabIndex = 12
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.TxtTelefonoR)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.TxtNombreR)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Location = New System.Drawing.Point(23, 201)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(569, 84)
        Me.GroupBox2.TabIndex = 8
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Datos del representante"
        '
        'TxtTelefonoR
        '
        Me.TxtTelefonoR.Location = New System.Drawing.Point(78, 49)
        Me.TxtTelefonoR.Name = "TxtTelefonoR"
        Me.TxtTelefonoR.Size = New System.Drawing.Size(245, 20)
        Me.TxtTelefonoR.TabIndex = 12
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(12, 52)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(52, 13)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Telefono:"
        '
        'TxtNombreR
        '
        Me.TxtNombreR.Location = New System.Drawing.Point(79, 23)
        Me.TxtNombreR.Name = "TxtNombreR"
        Me.TxtNombreR.Size = New System.Drawing.Size(245, 20)
        Me.TxtNombreR.TabIndex = 10
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(13, 26)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(47, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Nombre:"
        '
        'BtnGuardaP
        '
        Me.BtnGuardaP.Location = New System.Drawing.Point(355, 472)
        Me.BtnGuardaP.Name = "BtnGuardaP"
        Me.BtnGuardaP.Size = New System.Drawing.Size(75, 23)
        Me.BtnGuardaP.TabIndex = 9
        Me.BtnGuardaP.Text = "&Guardar"
        Me.BtnGuardaP.UseVisualStyleBackColor = True
        '
        'BtnLimpiaP
        '
        Me.BtnLimpiaP.Location = New System.Drawing.Point(436, 472)
        Me.BtnLimpiaP.Name = "BtnLimpiaP"
        Me.BtnLimpiaP.Size = New System.Drawing.Size(75, 23)
        Me.BtnLimpiaP.TabIndex = 10
        Me.BtnLimpiaP.Text = "&Limpiar"
        Me.BtnLimpiaP.UseVisualStyleBackColor = True
        '
        'BtnEliminaP
        '
        Me.BtnEliminaP.Location = New System.Drawing.Point(517, 472)
        Me.BtnEliminaP.Name = "BtnEliminaP"
        Me.BtnEliminaP.Size = New System.Drawing.Size(75, 23)
        Me.BtnEliminaP.TabIndex = 11
        Me.BtnEliminaP.Text = "&Eliminar"
        Me.BtnEliminaP.UseVisualStyleBackColor = True
        '
        'DGVproveedores
        '
        Me.DGVproveedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVproveedores.Location = New System.Drawing.Point(23, 291)
        Me.DGVproveedores.Name = "DGVproveedores"
        Me.DGVproveedores.Size = New System.Drawing.Size(569, 150)
        Me.DGVproveedores.TabIndex = 12
        '
        'BtnInicio
        '
        Me.BtnInicio.Location = New System.Drawing.Point(39, 479)
        Me.BtnInicio.Name = "BtnInicio"
        Me.BtnInicio.Size = New System.Drawing.Size(75, 23)
        Me.BtnInicio.TabIndex = 13
        Me.BtnInicio.Text = "Inicio"
        Me.BtnInicio.UseVisualStyleBackColor = True
        '
        'MtnProveedores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(623, 518)
        Me.Controls.Add(Me.BtnInicio)
        Me.Controls.Add(Me.DGVproveedores)
        Me.Controls.Add(Me.BtnEliminaP)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.BtnLimpiaP)
        Me.Controls.Add(Me.BtnGuardaP)
        Me.Name = "MtnProveedores"
        Me.Text = " Mantenimiento Proveedores"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.DGVproveedores, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label2 As Label
    Friend WithEvents TxtRazonSocial As TextBox
    Friend WithEvents TxtTelefono As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TxtCorreo As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents TxtTelefonoR As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents TxtNombreR As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents BtnGuardaP As Button
    Friend WithEvents BtnLimpiaP As Button
    Friend WithEvents BtnEliminaP As Button
    Friend WithEvents ComboPais As ComboBox
    Friend WithEvents ComboColonia As ComboBox
    Friend WithEvents ComboCiudad As ComboBox
    Friend WithEvents ComboEstado As ComboBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents DGVproveedores As DataGridView
    Friend WithEvents BtnInicio As Button
    Friend WithEvents Label10 As Label
    Friend WithEvents TxtProveedor As TextBox
End Class
