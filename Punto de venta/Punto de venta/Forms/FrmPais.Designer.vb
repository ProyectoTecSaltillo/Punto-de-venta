﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmPais
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(8, 20)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(191, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Introduce el nombre del país:"
        '
        'TxtPais
        '
        Me.TxtPais.Location = New System.Drawing.Point(239, 16)
        Me.TxtPais.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TxtPais.Name = "TxtPais"
        Me.TxtPais.Size = New System.Drawing.Size(225, 22)
        Me.TxtPais.TabIndex = 1
        '
        'BtnActualizarP
        '
        Me.BtnActualizarP.Location = New System.Drawing.Point(473, 49)
        Me.BtnActualizarP.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BtnActualizarP.Name = "BtnActualizarP"
        Me.BtnActualizarP.Size = New System.Drawing.Size(100, 28)
        Me.BtnActualizarP.TabIndex = 2
        Me.BtnActualizarP.Text = "Actualizar"
        Me.BtnActualizarP.UseVisualStyleBackColor = True
        '
        'BtnEliminarP
        '
        Me.BtnEliminarP.Location = New System.Drawing.Point(581, 49)
        Me.BtnEliminarP.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BtnEliminarP.Name = "BtnEliminarP"
        Me.BtnEliminarP.Size = New System.Drawing.Size(100, 28)
        Me.BtnEliminarP.TabIndex = 3
        Me.BtnEliminarP.Text = "Eliminar"
        Me.BtnEliminarP.UseVisualStyleBackColor = True
        '
        'BtnInsertarP
        '
        Me.BtnInsertarP.Location = New System.Drawing.Point(473, 15)
        Me.BtnInsertarP.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BtnInsertarP.Name = "BtnInsertarP"
        Me.BtnInsertarP.Size = New System.Drawing.Size(100, 28)
        Me.BtnInsertarP.TabIndex = 6
        Me.BtnInsertarP.Text = "Insertar"
        Me.BtnInsertarP.UseVisualStyleBackColor = True
        '
        'ComboPais
        '
        Me.ComboPais.FormattingEnabled = True
        Me.ComboPais.Location = New System.Drawing.Point(239, 52)
        Me.ComboPais.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ComboPais.Name = "ComboPais"
        Me.ComboPais.Size = New System.Drawing.Size(225, 24)
        Me.ComboPais.TabIndex = 7
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(8, 47)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(193, 36)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Seleccione el país que desee actualizar o eliminar:"
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(8, 47)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(193, 36)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "Seleccione el estado que desee actualizar o eliminar:"
        '
        'ComboEstado
        '
        Me.ComboEstado.FormattingEnabled = True
        Me.ComboEstado.Location = New System.Drawing.Point(239, 52)
        Me.ComboEstado.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ComboEstado.Name = "ComboEstado"
        Me.ComboEstado.Size = New System.Drawing.Size(225, 24)
        Me.ComboEstado.TabIndex = 15
        '
        'BtnInsertarE
        '
        Me.BtnInsertarE.Location = New System.Drawing.Point(473, 15)
        Me.BtnInsertarE.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BtnInsertarE.Name = "BtnInsertarE"
        Me.BtnInsertarE.Size = New System.Drawing.Size(100, 28)
        Me.BtnInsertarE.TabIndex = 14
        Me.BtnInsertarE.Text = "Insertar"
        Me.BtnInsertarE.UseVisualStyleBackColor = True
        '
        'BtnEliminarE
        '
        Me.BtnEliminarE.Location = New System.Drawing.Point(581, 49)
        Me.BtnEliminarE.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BtnEliminarE.Name = "BtnEliminarE"
        Me.BtnEliminarE.Size = New System.Drawing.Size(100, 28)
        Me.BtnEliminarE.TabIndex = 12
        Me.BtnEliminarE.Text = "Eliminar"
        Me.BtnEliminarE.UseVisualStyleBackColor = True
        '
        'BtnActualizarE
        '
        Me.BtnActualizarE.Location = New System.Drawing.Point(473, 49)
        Me.BtnActualizarE.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BtnActualizarE.Name = "BtnActualizarE"
        Me.BtnActualizarE.Size = New System.Drawing.Size(100, 28)
        Me.BtnActualizarE.TabIndex = 11
        Me.BtnActualizarE.Text = "Actualizar"
        Me.BtnActualizarE.UseVisualStyleBackColor = True
        '
        'TxtEstado
        '
        Me.TxtEstado.Location = New System.Drawing.Point(239, 16)
        Me.TxtEstado.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TxtEstado.Name = "TxtEstado"
        Me.TxtEstado.Size = New System.Drawing.Size(225, 22)
        Me.TxtEstado.TabIndex = 10
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(8, 20)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(208, 17)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Introduce el nombre del estado:"
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(8, 46)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(193, 37)
        Me.Label5.TabIndex = 24
        Me.Label5.Text = "Seleccione la ciudad que desee actualizar o eliminar:"
        '
        'ComboCiudad
        '
        Me.ComboCiudad.FormattingEnabled = True
        Me.ComboCiudad.Location = New System.Drawing.Point(239, 50)
        Me.ComboCiudad.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ComboCiudad.Name = "ComboCiudad"
        Me.ComboCiudad.Size = New System.Drawing.Size(225, 24)
        Me.ComboCiudad.TabIndex = 23
        '
        'BtnInsertarC
        '
        Me.BtnInsertarC.Location = New System.Drawing.Point(473, 15)
        Me.BtnInsertarC.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BtnInsertarC.Name = "BtnInsertarC"
        Me.BtnInsertarC.Size = New System.Drawing.Size(100, 28)
        Me.BtnInsertarC.TabIndex = 22
        Me.BtnInsertarC.Text = "Insertar"
        Me.BtnInsertarC.UseVisualStyleBackColor = True
        '
        'BtnEliminarC
        '
        Me.BtnEliminarC.Location = New System.Drawing.Point(581, 48)
        Me.BtnEliminarC.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BtnEliminarC.Name = "BtnEliminarC"
        Me.BtnEliminarC.Size = New System.Drawing.Size(100, 28)
        Me.BtnEliminarC.TabIndex = 20
        Me.BtnEliminarC.Text = "Eliminar"
        Me.BtnEliminarC.UseVisualStyleBackColor = True
        '
        'BtnActualizarC
        '
        Me.BtnActualizarC.Location = New System.Drawing.Point(473, 48)
        Me.BtnActualizarC.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BtnActualizarC.Name = "BtnActualizarC"
        Me.BtnActualizarC.Size = New System.Drawing.Size(100, 28)
        Me.BtnActualizarC.TabIndex = 19
        Me.BtnActualizarC.Text = "Actualizar"
        Me.BtnActualizarC.UseVisualStyleBackColor = True
        '
        'TxtCiudad
        '
        Me.TxtCiudad.Location = New System.Drawing.Point(239, 16)
        Me.TxtCiudad.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TxtCiudad.Name = "TxtCiudad"
        Me.TxtCiudad.Size = New System.Drawing.Size(225, 22)
        Me.TxtCiudad.TabIndex = 18
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(8, 20)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(219, 17)
        Me.Label6.TabIndex = 17
        Me.Label6.Text = "Introduce el nombre de la ciudad:"
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(8, 47)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(193, 36)
        Me.Label7.TabIndex = 32
        Me.Label7.Text = "Seleccione la colonia que desee actualizar o eliminar:"
        '
        'ComboColonia
        '
        Me.ComboColonia.FormattingEnabled = True
        Me.ComboColonia.Location = New System.Drawing.Point(239, 52)
        Me.ComboColonia.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ComboColonia.Name = "ComboColonia"
        Me.ComboColonia.Size = New System.Drawing.Size(225, 24)
        Me.ComboColonia.TabIndex = 31
        '
        'BtnInsertarCo
        '
        Me.BtnInsertarCo.Location = New System.Drawing.Point(473, 15)
        Me.BtnInsertarCo.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BtnInsertarCo.Name = "BtnInsertarCo"
        Me.BtnInsertarCo.Size = New System.Drawing.Size(100, 28)
        Me.BtnInsertarCo.TabIndex = 30
        Me.BtnInsertarCo.Text = "Insertar"
        Me.BtnInsertarCo.UseVisualStyleBackColor = True
        '
        'BtnLimpia
        '
        Me.BtnLimpia.Location = New System.Drawing.Point(489, 421)
        Me.BtnLimpia.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BtnLimpia.Name = "BtnLimpia"
        Me.BtnLimpia.Size = New System.Drawing.Size(208, 28)
        Me.BtnLimpia.TabIndex = 29
        Me.BtnLimpia.Text = "Limpiar"
        Me.BtnLimpia.UseVisualStyleBackColor = True
        '
        'BtnEliminarCo
        '
        Me.BtnEliminarCo.Location = New System.Drawing.Point(581, 49)
        Me.BtnEliminarCo.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BtnEliminarCo.Name = "BtnEliminarCo"
        Me.BtnEliminarCo.Size = New System.Drawing.Size(100, 28)
        Me.BtnEliminarCo.TabIndex = 28
        Me.BtnEliminarCo.Text = "Eliminar"
        Me.BtnEliminarCo.UseVisualStyleBackColor = True
        '
        'BtnActualizarCo
        '
        Me.BtnActualizarCo.Location = New System.Drawing.Point(473, 49)
        Me.BtnActualizarCo.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BtnActualizarCo.Name = "BtnActualizarCo"
        Me.BtnActualizarCo.Size = New System.Drawing.Size(100, 28)
        Me.BtnActualizarCo.TabIndex = 27
        Me.BtnActualizarCo.Text = "Actualizar"
        Me.BtnActualizarCo.UseVisualStyleBackColor = True
        '
        'TxtColonia
        '
        Me.TxtColonia.Location = New System.Drawing.Point(239, 16)
        Me.TxtColonia.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TxtColonia.Name = "TxtColonia"
        Me.TxtColonia.Size = New System.Drawing.Size(225, 22)
        Me.TxtColonia.TabIndex = 26
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(8, 20)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(225, 17)
        Me.Label8.TabIndex = 25
        Me.Label8.Text = "Introduce el nombre del la colonia:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.TxtPais)
        Me.GroupBox1.Controls.Add(Me.BtnActualizarP)
        Me.GroupBox1.Controls.Add(Me.BtnEliminarP)
        Me.GroupBox1.Controls.Add(Me.BtnInsertarP)
        Me.GroupBox1.Controls.Add(Me.ComboPais)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(16, 15)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox1.Size = New System.Drawing.Size(692, 91)
        Me.GroupBox1.TabIndex = 33
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "PAÍSES"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.TxtEstado)
        Me.GroupBox2.Controls.Add(Me.BtnActualizarE)
        Me.GroupBox2.Controls.Add(Me.BtnEliminarE)
        Me.GroupBox2.Controls.Add(Me.BtnInsertarE)
        Me.GroupBox2.Controls.Add(Me.ComboEstado)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Enabled = False
        Me.GroupBox2.Location = New System.Drawing.Point(16, 116)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox2.Size = New System.Drawing.Size(692, 91)
        Me.GroupBox2.TabIndex = 34
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "ESTADOS"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Controls.Add(Me.TxtCiudad)
        Me.GroupBox3.Controls.Add(Me.BtnActualizarC)
        Me.GroupBox3.Controls.Add(Me.BtnEliminarC)
        Me.GroupBox3.Controls.Add(Me.BtnInsertarC)
        Me.GroupBox3.Controls.Add(Me.ComboCiudad)
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Enabled = False
        Me.GroupBox3.Location = New System.Drawing.Point(16, 220)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox3.Size = New System.Drawing.Size(692, 91)
        Me.GroupBox3.TabIndex = 35
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "CIUDADES"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.Label8)
        Me.GroupBox4.Controls.Add(Me.TxtColonia)
        Me.GroupBox4.Controls.Add(Me.BtnActualizarCo)
        Me.GroupBox4.Controls.Add(Me.Label7)
        Me.GroupBox4.Controls.Add(Me.BtnEliminarCo)
        Me.GroupBox4.Controls.Add(Me.ComboColonia)
        Me.GroupBox4.Controls.Add(Me.BtnInsertarCo)
        Me.GroupBox4.Enabled = False
        Me.GroupBox4.Location = New System.Drawing.Point(16, 322)
        Me.GroupBox4.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox4.Size = New System.Drawing.Size(692, 91)
        Me.GroupBox4.TabIndex = 36
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "COLONIAS"
        '
        'FrmPais
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(728, 460)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.BtnLimpia)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "FrmPais"
        Me.Text = "FrmPais"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
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
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents GroupBox4 As GroupBox
End Class
