<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Perfil
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtName = New System.Windows.Forms.TextBox()
        Me.TxtEmail = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtPsw = New System.Windows.Forms.TextBox()
        Me.BtnEdName = New System.Windows.Forms.Button()
        Me.BtnEdEmail = New System.Windows.Forms.Button()
        Me.BtnEdPsw = New System.Windows.Forms.Button()
        Me.BtnEdPat = New System.Windows.Forms.Button()
        Me.TxtPat = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.BtnEdMat = New System.Windows.Forms.Button()
        Me.TxtMat = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.BtnBack = New System.Windows.Forms.Button()
        Me.BtnGuardar = New System.Windows.Forms.Button()
        Me.BtnSalir = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(22, 57)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nombre:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(22, 135)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Email:"
        '
        'TxtName
        '
        Me.TxtName.Enabled = False
        Me.TxtName.Location = New System.Drawing.Point(75, 54)
        Me.TxtName.Name = "TxtName"
        Me.TxtName.Size = New System.Drawing.Size(172, 20)
        Me.TxtName.TabIndex = 2
        '
        'TxtEmail
        '
        Me.TxtEmail.Enabled = False
        Me.TxtEmail.Location = New System.Drawing.Point(75, 132)
        Me.TxtEmail.Name = "TxtEmail"
        Me.TxtEmail.Size = New System.Drawing.Size(172, 20)
        Me.TxtEmail.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(22, 161)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(64, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Contraseña:"
        '
        'TxtPsw
        '
        Me.TxtPsw.Enabled = False
        Me.TxtPsw.Location = New System.Drawing.Point(92, 158)
        Me.TxtPsw.Name = "TxtPsw"
        Me.TxtPsw.Size = New System.Drawing.Size(155, 20)
        Me.TxtPsw.TabIndex = 5
        '
        'BtnEdName
        '
        'Me.BtnEdName.BackgroundImage = Global.Punto_de_venta.My.Resources.Resources.edit
        Me.BtnEdName.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnEdName.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.BtnEdName.FlatAppearance.BorderSize = 0
        Me.BtnEdName.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnEdName.Location = New System.Drawing.Point(253, 52)
        Me.BtnEdName.Name = "BtnEdName"
        Me.BtnEdName.Size = New System.Drawing.Size(23, 22)
        Me.BtnEdName.TabIndex = 6
        Me.BtnEdName.UseVisualStyleBackColor = True
        '
        'BtnEdEmail
        '
        'Me.BtnEdEmail.BackgroundImage = Global.Punto_de_venta.My.Resources.Resources.edit
        Me.BtnEdEmail.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnEdEmail.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.BtnEdEmail.FlatAppearance.BorderSize = 0
        Me.BtnEdEmail.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnEdEmail.Location = New System.Drawing.Point(253, 130)
        Me.BtnEdEmail.Name = "BtnEdEmail"
        Me.BtnEdEmail.Size = New System.Drawing.Size(23, 22)
        Me.BtnEdEmail.TabIndex = 9
        Me.BtnEdEmail.UseVisualStyleBackColor = True
        '
        'BtnEdPsw
        '
        'Me.BtnEdPsw.BackgroundImage = Global.Punto_de_venta.My.Resources.Resources.edit
        Me.BtnEdPsw.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnEdPsw.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.BtnEdPsw.FlatAppearance.BorderSize = 0
        Me.BtnEdPsw.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnEdPsw.Location = New System.Drawing.Point(253, 156)
        Me.BtnEdPsw.Name = "BtnEdPsw"
        Me.BtnEdPsw.Size = New System.Drawing.Size(23, 22)
        Me.BtnEdPsw.TabIndex = 10
        Me.BtnEdPsw.UseVisualStyleBackColor = True
        '
        'BtnEdPat
        '
        'Me.BtnEdPat.BackgroundImage = Global.Punto_de_venta.My.Resources.Resources.edit
        Me.BtnEdPat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnEdPat.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.BtnEdPat.FlatAppearance.BorderSize = 0
        Me.BtnEdPat.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnEdPat.Location = New System.Drawing.Point(253, 78)
        Me.BtnEdPat.Name = "BtnEdPat"
        Me.BtnEdPat.Size = New System.Drawing.Size(23, 22)
        Me.BtnEdPat.TabIndex = 13
        Me.BtnEdPat.UseVisualStyleBackColor = True
        '
        'TxtPat
        '
        Me.TxtPat.Enabled = False
        Me.TxtPat.Location = New System.Drawing.Point(75, 80)
        Me.TxtPat.Name = "TxtPat"
        Me.TxtPat.Size = New System.Drawing.Size(172, 20)
        Me.TxtPat.TabIndex = 12
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(22, 83)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(47, 13)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Paterno:"
        '
        'BtnEdMat
        '
        'Me.BtnEdMat.BackgroundImage = Global.Punto_de_venta.My.Resources.Resources.edit
        Me.BtnEdMat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnEdMat.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.BtnEdMat.FlatAppearance.BorderSize = 0
        Me.BtnEdMat.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnEdMat.Location = New System.Drawing.Point(253, 104)
        Me.BtnEdMat.Name = "BtnEdMat"
        Me.BtnEdMat.Size = New System.Drawing.Size(23, 22)
        Me.BtnEdMat.TabIndex = 16
        Me.BtnEdMat.UseVisualStyleBackColor = True
        '
        'TxtMat
        '
        Me.TxtMat.Enabled = False
        Me.TxtMat.Location = New System.Drawing.Point(75, 106)
        Me.TxtMat.Name = "TxtMat"
        Me.TxtMat.Size = New System.Drawing.Size(172, 20)
        Me.TxtMat.TabIndex = 15
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(22, 109)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(49, 13)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "Materno:"
        '
        'BtnBack
        '
        Me.BtnBack.Location = New System.Drawing.Point(102, 12)
        Me.BtnBack.Name = "BtnBack"
        Me.BtnBack.Size = New System.Drawing.Size(99, 23)
        Me.BtnBack.TabIndex = 17
        Me.BtnBack.Text = "Menú General"
        Me.BtnBack.UseVisualStyleBackColor = True
        '
        'BtnGuardar
        '
        Me.BtnGuardar.Location = New System.Drawing.Point(148, 184)
        Me.BtnGuardar.Name = "BtnGuardar"
        Me.BtnGuardar.Size = New System.Drawing.Size(99, 23)
        Me.BtnGuardar.TabIndex = 18
        Me.BtnGuardar.Text = "Guardar"
        Me.BtnGuardar.UseVisualStyleBackColor = True
        '
        'BtnSalir
        '
        Me.BtnSalir.Location = New System.Drawing.Point(148, 213)
        Me.BtnSalir.Name = "BtnSalir"
        Me.BtnSalir.Size = New System.Drawing.Size(99, 23)
        Me.BtnSalir.TabIndex = 19
        Me.BtnSalir.Text = "Salir"
        Me.BtnSalir.UseVisualStyleBackColor = True
        '
        'Perfil
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.BtnSalir)
        Me.Controls.Add(Me.BtnGuardar)
        Me.Controls.Add(Me.BtnBack)
        Me.Controls.Add(Me.BtnEdMat)
        Me.Controls.Add(Me.TxtMat)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.BtnEdPat)
        Me.Controls.Add(Me.TxtPat)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.BtnEdPsw)
        Me.Controls.Add(Me.BtnEdEmail)
        Me.Controls.Add(Me.BtnEdName)
        Me.Controls.Add(Me.TxtPsw)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TxtEmail)
        Me.Controls.Add(Me.TxtName)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Perfil"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Perfil"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TxtName As TextBox
    Friend WithEvents TxtEmail As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TxtPsw As TextBox
    Friend WithEvents BtnEdName As Button
    Friend WithEvents BtnEdPsw As Button
    Friend WithEvents BtnEdEmail As Button
    Friend WithEvents BtnEdPat As Button
    Friend WithEvents TxtPat As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents BtnEdMat As Button
    Friend WithEvents TxtMat As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents BtnBack As Button
    Friend WithEvents BtnGuardar As Button
    Friend WithEvents BtnSalir As Button
End Class
