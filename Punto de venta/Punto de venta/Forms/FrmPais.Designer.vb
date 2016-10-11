<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmPais
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmPais))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtPais = New System.Windows.Forms.TextBox()
        Me.BtnActualizarP = New System.Windows.Forms.Button()
        Me.BtnEliminarP = New System.Windows.Forms.Button()
        Me.BtnInsertarP = New System.Windows.Forms.Button()
        Me.ComboPais = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ComboEstado = New System.Windows.Forms.ComboBox()
        Me.BtnInsertarE = New System.Windows.Forms.Button()
        Me.BtnEliminarE = New System.Windows.Forms.Button()
        Me.BtnActualizarE = New System.Windows.Forms.Button()
        Me.TxtEstado = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.ComboCiudad = New System.Windows.Forms.ComboBox()
        Me.BtnInsertarC = New System.Windows.Forms.Button()
        Me.BtnEliminarC = New System.Windows.Forms.Button()
        Me.BtnActualizarC = New System.Windows.Forms.Button()
        Me.TxtCiudad = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.ComboColonia = New System.Windows.Forms.ComboBox()
        Me.BtnInsertarCo = New System.Windows.Forms.Button()
        Me.BtnLimpia = New System.Windows.Forms.Button()
        Me.BtnEliminarCo = New System.Windows.Forms.Button()
        Me.BtnActualizarCo = New System.Windows.Forms.Button()
        Me.TxtColonia = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.GBPais = New System.Windows.Forms.GroupBox()
        Me.GBEstado = New System.Windows.Forms.GroupBox()
        Me.GBCiudad = New System.Windows.Forms.GroupBox()
        Me.GBColonia = New System.Windows.Forms.GroupBox()
        Me.GBPais.SuspendLayout()
        Me.GBEstado.SuspendLayout()
        Me.GBCiudad.SuspendLayout()
        Me.GBColonia.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(145, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Introduce el nombre del país:"
        '
        'TxtPais
        '
        Me.TxtPais.Location = New System.Drawing.Point(179, 13)
        Me.TxtPais.Name = "TxtPais"
        Me.TxtPais.Size = New System.Drawing.Size(170, 20)
        Me.TxtPais.TabIndex = 1
        '
        'BtnActualizarP
        '
        Me.BtnActualizarP.Location = New System.Drawing.Point(355, 40)
        Me.BtnActualizarP.Name = "BtnActualizarP"
        Me.BtnActualizarP.Size = New System.Drawing.Size(75, 23)
        Me.BtnActualizarP.TabIndex = 2
        Me.BtnActualizarP.Text = "Actualizar"
        Me.BtnActualizarP.UseVisualStyleBackColor = True
        '
        'BtnEliminarP
        '
        Me.BtnEliminarP.Location = New System.Drawing.Point(436, 40)
        Me.BtnEliminarP.Name = "BtnEliminarP"
        Me.BtnEliminarP.Size = New System.Drawing.Size(75, 23)
        Me.BtnEliminarP.TabIndex = 3
        Me.BtnEliminarP.Text = "Eliminar"
        Me.BtnEliminarP.UseVisualStyleBackColor = True
        '
        'BtnInsertarP
        '
        Me.BtnInsertarP.Location = New System.Drawing.Point(355, 12)
        Me.BtnInsertarP.Name = "BtnInsertarP"
        Me.BtnInsertarP.Size = New System.Drawing.Size(75, 23)
        Me.BtnInsertarP.TabIndex = 6
        Me.BtnInsertarP.Text = "Insertar"
        Me.BtnInsertarP.UseVisualStyleBackColor = True
        '
        'ComboPais
        '
        Me.ComboPais.FormattingEnabled = True
        Me.ComboPais.Items.AddRange(New Object() {""})
        Me.ComboPais.Location = New System.Drawing.Point(179, 42)
        Me.ComboPais.Name = "ComboPais"
        Me.ComboPais.Size = New System.Drawing.Size(170, 21)
        Me.ComboPais.TabIndex = 7
        Me.ComboPais.Text = "Seleccione..."
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(6, 38)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(145, 29)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Seleccione el país que desee actualizar o eliminar:"
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(6, 38)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(145, 29)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "Seleccione el estado que desee actualizar o eliminar:"
        '
        'ComboEstado
        '
        Me.ComboEstado.FormattingEnabled = True
        Me.ComboEstado.Location = New System.Drawing.Point(179, 42)
        Me.ComboEstado.Name = "ComboEstado"
        Me.ComboEstado.Size = New System.Drawing.Size(170, 21)
        Me.ComboEstado.TabIndex = 15
        Me.ComboEstado.Text = "Seleccione..."
        '
        'BtnInsertarE
        '
        Me.BtnInsertarE.Location = New System.Drawing.Point(355, 12)
        Me.BtnInsertarE.Name = "BtnInsertarE"
        Me.BtnInsertarE.Size = New System.Drawing.Size(75, 23)
        Me.BtnInsertarE.TabIndex = 14
        Me.BtnInsertarE.Text = "Insertar"
        Me.BtnInsertarE.UseVisualStyleBackColor = True
        '
        'BtnEliminarE
        '
        Me.BtnEliminarE.Location = New System.Drawing.Point(436, 40)
        Me.BtnEliminarE.Name = "BtnEliminarE"
        Me.BtnEliminarE.Size = New System.Drawing.Size(75, 23)
        Me.BtnEliminarE.TabIndex = 12
        Me.BtnEliminarE.Text = "Eliminar"
        Me.BtnEliminarE.UseVisualStyleBackColor = True
        '
        'BtnActualizarE
        '
        Me.BtnActualizarE.Location = New System.Drawing.Point(355, 40)
        Me.BtnActualizarE.Name = "BtnActualizarE"
        Me.BtnActualizarE.Size = New System.Drawing.Size(75, 23)
        Me.BtnActualizarE.TabIndex = 11
        Me.BtnActualizarE.Text = "Actualizar"
        Me.BtnActualizarE.UseVisualStyleBackColor = True
        '
        'TxtEstado
        '
        Me.TxtEstado.Location = New System.Drawing.Point(179, 13)
        Me.TxtEstado.Name = "TxtEstado"
        Me.TxtEstado.Size = New System.Drawing.Size(170, 20)
        Me.TxtEstado.TabIndex = 10
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 16)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(156, 13)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Introduce el nombre del estado:"
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(6, 37)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(145, 30)
        Me.Label5.TabIndex = 24
        Me.Label5.Text = "Seleccione la ciudad que desee actualizar o eliminar:"
        '
        'ComboCiudad
        '
        Me.ComboCiudad.FormattingEnabled = True
        Me.ComboCiudad.Location = New System.Drawing.Point(179, 41)
        Me.ComboCiudad.Name = "ComboCiudad"
        Me.ComboCiudad.Size = New System.Drawing.Size(170, 21)
        Me.ComboCiudad.TabIndex = 23
        Me.ComboCiudad.Text = "Seleccione..."
        '
        'BtnInsertarC
        '
        Me.BtnInsertarC.Location = New System.Drawing.Point(355, 12)
        Me.BtnInsertarC.Name = "BtnInsertarC"
        Me.BtnInsertarC.Size = New System.Drawing.Size(75, 23)
        Me.BtnInsertarC.TabIndex = 22
        Me.BtnInsertarC.Text = "Insertar"
        Me.BtnInsertarC.UseVisualStyleBackColor = True
        '
        'BtnEliminarC
        '
        Me.BtnEliminarC.Location = New System.Drawing.Point(436, 39)
        Me.BtnEliminarC.Name = "BtnEliminarC"
        Me.BtnEliminarC.Size = New System.Drawing.Size(75, 23)
        Me.BtnEliminarC.TabIndex = 20
        Me.BtnEliminarC.Text = "Eliminar"
        Me.BtnEliminarC.UseVisualStyleBackColor = True
        '
        'BtnActualizarC
        '
        Me.BtnActualizarC.Location = New System.Drawing.Point(355, 39)
        Me.BtnActualizarC.Name = "BtnActualizarC"
        Me.BtnActualizarC.Size = New System.Drawing.Size(75, 23)
        Me.BtnActualizarC.TabIndex = 19
        Me.BtnActualizarC.Text = "Actualizar"
        Me.BtnActualizarC.UseVisualStyleBackColor = True
        '
        'TxtCiudad
        '
        Me.TxtCiudad.Location = New System.Drawing.Point(179, 13)
        Me.TxtCiudad.Name = "TxtCiudad"
        Me.TxtCiudad.Size = New System.Drawing.Size(170, 20)
        Me.TxtCiudad.TabIndex = 18
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 16)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(165, 13)
        Me.Label6.TabIndex = 17
        Me.Label6.Text = "Introduce el nombre de la ciudad:"
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(6, 38)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(145, 29)
        Me.Label7.TabIndex = 32
        Me.Label7.Text = "Seleccione la colonia que desee actualizar o eliminar:"
        '
        'ComboColonia
        '
        Me.ComboColonia.FormattingEnabled = True
        Me.ComboColonia.Location = New System.Drawing.Point(179, 42)
        Me.ComboColonia.Name = "ComboColonia"
        Me.ComboColonia.Size = New System.Drawing.Size(170, 21)
        Me.ComboColonia.TabIndex = 31
        Me.ComboColonia.Text = "Seleccione..."
        '
        'BtnInsertarCo
        '
        Me.BtnInsertarCo.Location = New System.Drawing.Point(355, 12)
        Me.BtnInsertarCo.Name = "BtnInsertarCo"
        Me.BtnInsertarCo.Size = New System.Drawing.Size(75, 23)
        Me.BtnInsertarCo.TabIndex = 30
        Me.BtnInsertarCo.Text = "Insertar"
        Me.BtnInsertarCo.UseVisualStyleBackColor = True
        '
        'BtnLimpia
        '
        Me.BtnLimpia.Location = New System.Drawing.Point(367, 342)
        Me.BtnLimpia.Name = "BtnLimpia"
        Me.BtnLimpia.Size = New System.Drawing.Size(156, 23)
        Me.BtnLimpia.TabIndex = 29
        Me.BtnLimpia.Text = "Limpiar"
        Me.BtnLimpia.UseVisualStyleBackColor = True
        '
        'BtnEliminarCo
        '
        Me.BtnEliminarCo.Location = New System.Drawing.Point(436, 40)
        Me.BtnEliminarCo.Name = "BtnEliminarCo"
        Me.BtnEliminarCo.Size = New System.Drawing.Size(75, 23)
        Me.BtnEliminarCo.TabIndex = 28
        Me.BtnEliminarCo.Text = "Eliminar"
        Me.BtnEliminarCo.UseVisualStyleBackColor = True
        '
        'BtnActualizarCo
        '
        Me.BtnActualizarCo.Location = New System.Drawing.Point(355, 40)
        Me.BtnActualizarCo.Name = "BtnActualizarCo"
        Me.BtnActualizarCo.Size = New System.Drawing.Size(75, 23)
        Me.BtnActualizarCo.TabIndex = 27
        Me.BtnActualizarCo.Text = "Actualizar"
        Me.BtnActualizarCo.UseVisualStyleBackColor = True
        '
        'TxtColonia
        '
        Me.TxtColonia.Location = New System.Drawing.Point(179, 13)
        Me.TxtColonia.Name = "TxtColonia"
        Me.TxtColonia.Size = New System.Drawing.Size(170, 20)
        Me.TxtColonia.TabIndex = 26
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(6, 16)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(169, 13)
        Me.Label8.TabIndex = 25
        Me.Label8.Text = "Introduce el nombre del la colonia:"
        '
        'GBPais
        '
        Me.GBPais.Controls.Add(Me.Label1)
        Me.GBPais.Controls.Add(Me.TxtPais)
        Me.GBPais.Controls.Add(Me.BtnActualizarP)
        Me.GBPais.Controls.Add(Me.BtnEliminarP)
        Me.GBPais.Controls.Add(Me.BtnInsertarP)
        Me.GBPais.Controls.Add(Me.ComboPais)
        Me.GBPais.Controls.Add(Me.Label2)
        Me.GBPais.Location = New System.Drawing.Point(12, 12)
        Me.GBPais.Name = "GBPais"
        Me.GBPais.Size = New System.Drawing.Size(519, 74)
        Me.GBPais.TabIndex = 33
        Me.GBPais.TabStop = False
        Me.GBPais.Text = "PAÍSES"
        '
        'GBEstado
        '
        Me.GBEstado.Controls.Add(Me.Label4)
        Me.GBEstado.Controls.Add(Me.TxtEstado)
        Me.GBEstado.Controls.Add(Me.BtnActualizarE)
        Me.GBEstado.Controls.Add(Me.BtnEliminarE)
        Me.GBEstado.Controls.Add(Me.BtnInsertarE)
        Me.GBEstado.Controls.Add(Me.ComboEstado)
        Me.GBEstado.Controls.Add(Me.Label3)
        Me.GBEstado.Enabled = False
        Me.GBEstado.Location = New System.Drawing.Point(12, 94)
        Me.GBEstado.Name = "GBEstado"
        Me.GBEstado.Size = New System.Drawing.Size(519, 74)
        Me.GBEstado.TabIndex = 34
        Me.GBEstado.TabStop = False
        Me.GBEstado.Text = "ESTADOS"
        '
        'GBCiudad
        '
        Me.GBCiudad.Controls.Add(Me.Label6)
        Me.GBCiudad.Controls.Add(Me.TxtCiudad)
        Me.GBCiudad.Controls.Add(Me.BtnActualizarC)
        Me.GBCiudad.Controls.Add(Me.BtnEliminarC)
        Me.GBCiudad.Controls.Add(Me.BtnInsertarC)
        Me.GBCiudad.Controls.Add(Me.ComboCiudad)
        Me.GBCiudad.Controls.Add(Me.Label5)
        Me.GBCiudad.Enabled = False
        Me.GBCiudad.Location = New System.Drawing.Point(12, 179)
        Me.GBCiudad.Name = "GBCiudad"
        Me.GBCiudad.Size = New System.Drawing.Size(519, 74)
        Me.GBCiudad.TabIndex = 35
        Me.GBCiudad.TabStop = False
        Me.GBCiudad.Text = "CIUDADES"
        '
        'GBColonia
        '
        Me.GBColonia.Controls.Add(Me.Label8)
        Me.GBColonia.Controls.Add(Me.TxtColonia)
        Me.GBColonia.Controls.Add(Me.BtnActualizarCo)
        Me.GBColonia.Controls.Add(Me.Label7)
        Me.GBColonia.Controls.Add(Me.BtnEliminarCo)
        Me.GBColonia.Controls.Add(Me.ComboColonia)
        Me.GBColonia.Controls.Add(Me.BtnInsertarCo)
        Me.GBColonia.Enabled = False
        Me.GBColonia.Location = New System.Drawing.Point(12, 262)
        Me.GBColonia.Name = "GBColonia"
        Me.GBColonia.Size = New System.Drawing.Size(519, 74)
        Me.GBColonia.TabIndex = 36
        Me.GBColonia.TabStop = False
        Me.GBColonia.Text = "COLONIAS"
        '
        'FrmPais
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(546, 374)
        Me.Controls.Add(Me.GBColonia)
        Me.Controls.Add(Me.GBCiudad)
        Me.Controls.Add(Me.GBEstado)
        Me.Controls.Add(Me.GBPais)
        Me.Controls.Add(Me.BtnLimpia)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "FrmPais"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmPais"
        Me.GBPais.ResumeLayout(False)
        Me.GBPais.PerformLayout()
        Me.GBEstado.ResumeLayout(False)
        Me.GBEstado.PerformLayout()
        Me.GBCiudad.ResumeLayout(False)
        Me.GBCiudad.PerformLayout()
        Me.GBColonia.ResumeLayout(False)
        Me.GBColonia.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents TxtPais As TextBox
    Friend WithEvents BtnActualizarP As Button
    Friend WithEvents BtnEliminarP As Button
    Friend WithEvents BtnInsertarP As Button
    Friend WithEvents ComboPais As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents ComboEstado As ComboBox
    Friend WithEvents BtnInsertarE As Button
    Friend WithEvents BtnEliminarE As Button
    Friend WithEvents BtnActualizarE As Button
    Friend WithEvents TxtEstado As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents ComboCiudad As ComboBox
    Friend WithEvents BtnInsertarC As Button
    Friend WithEvents BtnEliminarC As Button
    Friend WithEvents BtnActualizarC As Button
    Friend WithEvents TxtCiudad As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents ComboColonia As ComboBox
    Friend WithEvents BtnInsertarCo As Button
    Friend WithEvents BtnLimpia As Button
    Friend WithEvents BtnEliminarCo As Button
    Friend WithEvents BtnActualizarCo As Button
    Friend WithEvents TxtColonia As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents GBPais As GroupBox
    Friend WithEvents GBEstado As GroupBox
    Friend WithEvents GBCiudad As GroupBox
    Friend WithEvents GBColonia As GroupBox
End Class
