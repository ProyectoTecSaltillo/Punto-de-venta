<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MtnProveedores
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
        Me.TxtRazonSocial = New System.Windows.Forms.TextBox()
        Me.TxtTelefono = New System.Windows.Forms.TextBox()
        Me.TxtCorreo = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TxtProveedor = New System.Windows.Forms.TextBox()
        Me.ComboColonia = New System.Windows.Forms.ComboBox()
        Me.ComboCiudad = New System.Windows.Forms.ComboBox()
        Me.ComboEstado = New System.Windows.Forms.ComboBox()
        Me.ComboPais = New System.Windows.Forms.ComboBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.TxtTelefonoR = New System.Windows.Forms.TextBox()
        Me.TxtNombreR = New System.Windows.Forms.TextBox()
        Me.BtnGuardaP = New System.Windows.Forms.Button()
        Me.BtnLimpiaP = New System.Windows.Forms.Button()
        Me.BtnEliminaP = New System.Windows.Forms.Button()
        Me.DGVproveedores = New System.Windows.Forms.DataGridView()
        Me.BtnInicio = New System.Windows.Forms.Button()
        Me.BtnExit = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DGVproveedores, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TxtRazonSocial
        '
        Me.TxtRazonSocial.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.TxtRazonSocial.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtRazonSocial.Location = New System.Drawing.Point(367, 53)
        Me.TxtRazonSocial.Name = "TxtRazonSocial"
        Me.TxtRazonSocial.Size = New System.Drawing.Size(182, 18)
        Me.TxtRazonSocial.TabIndex = 2
        '
        'TxtTelefono
        '
        Me.TxtTelefono.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.TxtTelefono.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtTelefono.Location = New System.Drawing.Point(80, 53)
        Me.TxtTelefono.Name = "TxtTelefono"
        Me.TxtTelefono.Size = New System.Drawing.Size(176, 18)
        Me.TxtTelefono.TabIndex = 4
        '
        'TxtCorreo
        '
        Me.TxtCorreo.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.TxtCorreo.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtCorreo.Location = New System.Drawing.Point(77, 84)
        Me.TxtCorreo.Name = "TxtCorreo"
        Me.TxtCorreo.Size = New System.Drawing.Size(179, 18)
        Me.TxtCorreo.TabIndex = 6
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.TxtProveedor)
        Me.GroupBox1.Controls.Add(Me.ComboColonia)
        Me.GroupBox1.Controls.Add(Me.ComboCiudad)
        Me.GroupBox1.Controls.Add(Me.ComboEstado)
        Me.GroupBox1.Controls.Add(Me.ComboPais)
        Me.GroupBox1.Controls.Add(Me.TxtCorreo)
        Me.GroupBox1.Controls.Add(Me.TxtRazonSocial)
        Me.GroupBox1.Controls.Add(Me.TxtTelefono)
        Me.GroupBox1.Font = New System.Drawing.Font("Segoe WP", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(23, 23)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.GroupBox1.Size = New System.Drawing.Size(569, 172)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos"
        '
        'TxtProveedor
        '
        Me.TxtProveedor.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.TxtProveedor.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtProveedor.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtProveedor.Location = New System.Drawing.Point(97, 23)
        Me.TxtProveedor.Name = "TxtProveedor"
        Me.TxtProveedor.Size = New System.Drawing.Size(159, 16)
        Me.TxtProveedor.TabIndex = 21
        '
        'ComboColonia
        '
        Me.ComboColonia.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.ComboColonia.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ComboColonia.FormattingEnabled = True
        Me.ComboColonia.Location = New System.Drawing.Point(332, 136)
        Me.ComboColonia.Name = "ComboColonia"
        Me.ComboColonia.Size = New System.Drawing.Size(121, 25)
        Me.ComboColonia.TabIndex = 19
        '
        'ComboCiudad
        '
        Me.ComboCiudad.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.ComboCiudad.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ComboCiudad.FormattingEnabled = True
        Me.ComboCiudad.Location = New System.Drawing.Point(332, 109)
        Me.ComboCiudad.Name = "ComboCiudad"
        Me.ComboCiudad.Size = New System.Drawing.Size(121, 25)
        Me.ComboCiudad.TabIndex = 18
        '
        'ComboEstado
        '
        Me.ComboEstado.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.ComboEstado.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ComboEstado.FormattingEnabled = True
        Me.ComboEstado.Location = New System.Drawing.Point(119, 140)
        Me.ComboEstado.Name = "ComboEstado"
        Me.ComboEstado.Size = New System.Drawing.Size(107, 25)
        Me.ComboEstado.TabIndex = 17
        '
        'ComboPais
        '
        Me.ComboPais.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.ComboPais.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ComboPais.FormattingEnabled = True
        Me.ComboPais.Location = New System.Drawing.Point(105, 112)
        Me.ComboPais.Name = "ComboPais"
        Me.ComboPais.Size = New System.Drawing.Size(121, 25)
        Me.ComboPais.TabIndex = 12
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.TxtTelefonoR)
        Me.GroupBox2.Controls.Add(Me.TxtNombreR)
        Me.GroupBox2.Font = New System.Drawing.Font("Segoe WP", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.White
        Me.GroupBox2.Location = New System.Drawing.Point(23, 201)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.GroupBox2.Size = New System.Drawing.Size(569, 84)
        Me.GroupBox2.TabIndex = 8
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Datos del representante"
        '
        'TxtTelefonoR
        '
        Me.TxtTelefonoR.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.TxtTelefonoR.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtTelefonoR.Location = New System.Drawing.Point(368, 39)
        Me.TxtTelefonoR.Name = "TxtTelefonoR"
        Me.TxtTelefonoR.Size = New System.Drawing.Size(182, 18)
        Me.TxtTelefonoR.TabIndex = 12
        '
        'TxtNombreR
        '
        Me.TxtNombreR.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.TxtNombreR.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtNombreR.Location = New System.Drawing.Point(92, 38)
        Me.TxtNombreR.Name = "TxtNombreR"
        Me.TxtNombreR.Size = New System.Drawing.Size(180, 18)
        Me.TxtNombreR.TabIndex = 10
        '
        'BtnGuardaP
        '
        Me.BtnGuardaP.BackColor = System.Drawing.Color.Transparent
        Me.BtnGuardaP.BackgroundImage = Global.Punto_de_venta.My.Resources.Resources.Guardar
        Me.BtnGuardaP.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnGuardaP.FlatAppearance.BorderSize = 0
        Me.BtnGuardaP.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnGuardaP.Location = New System.Drawing.Point(433, 460)
        Me.BtnGuardaP.Name = "BtnGuardaP"
        Me.BtnGuardaP.Size = New System.Drawing.Size(40, 40)
        Me.BtnGuardaP.TabIndex = 9
        Me.BtnGuardaP.UseVisualStyleBackColor = False
        '
        'BtnLimpiaP
        '
        Me.BtnLimpiaP.BackColor = System.Drawing.Color.Transparent
        Me.BtnLimpiaP.BackgroundImage = Global.Punto_de_venta.My.Resources.Resources.Limpiar
        Me.BtnLimpiaP.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnLimpiaP.FlatAppearance.BorderSize = 0
        Me.BtnLimpiaP.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnLimpiaP.Location = New System.Drawing.Point(490, 460)
        Me.BtnLimpiaP.Name = "BtnLimpiaP"
        Me.BtnLimpiaP.Size = New System.Drawing.Size(40, 40)
        Me.BtnLimpiaP.TabIndex = 10
        Me.BtnLimpiaP.UseVisualStyleBackColor = False
        '
        'BtnEliminaP
        '
        Me.BtnEliminaP.BackColor = System.Drawing.Color.Transparent
        Me.BtnEliminaP.BackgroundImage = Global.Punto_de_venta.My.Resources.Resources.Eliminar
        Me.BtnEliminaP.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnEliminaP.FlatAppearance.BorderSize = 0
        Me.BtnEliminaP.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnEliminaP.Location = New System.Drawing.Point(547, 460)
        Me.BtnEliminaP.Name = "BtnEliminaP"
        Me.BtnEliminaP.Size = New System.Drawing.Size(40, 40)
        Me.BtnEliminaP.TabIndex = 11
        Me.BtnEliminaP.UseVisualStyleBackColor = False
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
        Me.BtnInicio.BackColor = System.Drawing.Color.Transparent
        Me.BtnInicio.BackgroundImage = Global.Punto_de_venta.My.Resources.Resources.BotonMenu2
        Me.BtnInicio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnInicio.FlatAppearance.BorderSize = 0
        Me.BtnInicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnInicio.ForeColor = System.Drawing.Color.Transparent
        Me.BtnInicio.Location = New System.Drawing.Point(20, 455)
        Me.BtnInicio.Name = "BtnInicio"
        Me.BtnInicio.Size = New System.Drawing.Size(55, 50)
        Me.BtnInicio.TabIndex = 13
        Me.BtnInicio.UseVisualStyleBackColor = False
        '
        'BtnExit
        '
        Me.BtnExit.BackColor = System.Drawing.Color.Transparent
        Me.BtnExit.BackgroundImage = Global.Punto_de_venta.My.Resources.Resources.X
        Me.BtnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnExit.FlatAppearance.BorderSize = 0
        Me.BtnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnExit.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.BtnExit.Location = New System.Drawing.Point(592, -3)
        Me.BtnExit.Name = "BtnExit"
        Me.BtnExit.Size = New System.Drawing.Size(31, 37)
        Me.BtnExit.TabIndex = 14
        Me.BtnExit.UseVisualStyleBackColor = False
        '
        'MtnProveedores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Punto_de_venta.My.Resources.Resources.PantallaProveedores
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(625, 518)
        Me.Controls.Add(Me.BtnExit)
        Me.Controls.Add(Me.BtnInicio)
        Me.Controls.Add(Me.DGVproveedores)
        Me.Controls.Add(Me.BtnEliminaP)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.BtnLimpiaP)
        Me.Controls.Add(Me.BtnGuardaP)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "MtnProveedores"
        Me.Text = " Mantenimiento Proveedores"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.DGVproveedores, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TxtRazonSocial As TextBox
    Friend WithEvents TxtTelefono As TextBox
    Friend WithEvents TxtCorreo As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents TxtTelefonoR As TextBox
    Friend WithEvents TxtNombreR As TextBox
    Friend WithEvents BtnGuardaP As Button
    Friend WithEvents BtnLimpiaP As Button
    Friend WithEvents BtnEliminaP As Button
    Friend WithEvents ComboPais As ComboBox
    Friend WithEvents ComboColonia As ComboBox
    Friend WithEvents ComboCiudad As ComboBox
    Friend WithEvents ComboEstado As ComboBox
    Friend WithEvents DGVproveedores As DataGridView
    Friend WithEvents BtnInicio As Button
    Friend WithEvents TxtProveedor As TextBox
    Friend WithEvents BtnExit As Button
End Class
