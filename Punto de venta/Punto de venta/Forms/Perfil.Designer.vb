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
        Me.Label1.Location = New System.Drawing.Point(29, 70)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(62, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nombre:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(29, 166)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(46, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Email:"
        '
        'TxtName
        '
        Me.TxtName.Enabled = False
        Me.TxtName.Location = New System.Drawing.Point(100, 66)
        Me.TxtName.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TxtName.Name = "TxtName"
        Me.TxtName.Size = New System.Drawing.Size(228, 22)
        Me.TxtName.TabIndex = 2
        '
        'TxtEmail
        '
        Me.TxtEmail.Enabled = False
        Me.TxtEmail.Location = New System.Drawing.Point(100, 162)
        Me.TxtEmail.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TxtEmail.Name = "TxtEmail"
        Me.TxtEmail.Size = New System.Drawing.Size(228, 22)
        Me.TxtEmail.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(29, 198)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(85, 17)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Contraseña:"
        '
        'TxtPsw
        '
        Me.TxtPsw.Enabled = False
        Me.TxtPsw.Location = New System.Drawing.Point(123, 194)
        Me.TxtPsw.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TxtPsw.Name = "TxtPsw"
        Me.TxtPsw.Size = New System.Drawing.Size(205, 22)
        Me.TxtPsw.TabIndex = 5
        '
        'BtnEdName
        '
        Me.BtnEdName.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnEdName.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.BtnEdName.FlatAppearance.BorderSize = 0
        Me.BtnEdName.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnEdName.Location = New System.Drawing.Point(337, 64)
        Me.BtnEdName.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BtnEdName.Name = "BtnEdName"
        Me.BtnEdName.Size = New System.Drawing.Size(31, 27)
        Me.BtnEdName.TabIndex = 6
        Me.BtnEdName.UseVisualStyleBackColor = True
        '
        'BtnEdEmail
        '
        Me.BtnEdEmail.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnEdEmail.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.BtnEdEmail.FlatAppearance.BorderSize = 0
        Me.BtnEdEmail.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnEdEmail.Location = New System.Drawing.Point(337, 160)
        Me.BtnEdEmail.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BtnEdEmail.Name = "BtnEdEmail"
        Me.BtnEdEmail.Size = New System.Drawing.Size(31, 27)
        Me.BtnEdEmail.TabIndex = 9
        Me.BtnEdEmail.UseVisualStyleBackColor = True
        '
        'BtnEdPsw
        '
        Me.BtnEdPsw.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnEdPsw.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.BtnEdPsw.FlatAppearance.BorderSize = 0
        Me.BtnEdPsw.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnEdPsw.Location = New System.Drawing.Point(337, 192)
        Me.BtnEdPsw.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BtnEdPsw.Name = "BtnEdPsw"
        Me.BtnEdPsw.Size = New System.Drawing.Size(31, 27)
        Me.BtnEdPsw.TabIndex = 10
        Me.BtnEdPsw.UseVisualStyleBackColor = True
        '
        'BtnEdPat
        '
        Me.BtnEdPat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnEdPat.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.BtnEdPat.FlatAppearance.BorderSize = 0
        Me.BtnEdPat.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnEdPat.Location = New System.Drawing.Point(337, 96)
        Me.BtnEdPat.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BtnEdPat.Name = "BtnEdPat"
        Me.BtnEdPat.Size = New System.Drawing.Size(31, 27)
        Me.BtnEdPat.TabIndex = 13
        Me.BtnEdPat.UseVisualStyleBackColor = True
        '
        'TxtPat
        '
        Me.TxtPat.Enabled = False
        Me.TxtPat.Location = New System.Drawing.Point(100, 98)
        Me.TxtPat.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TxtPat.Name = "TxtPat"
        Me.TxtPat.Size = New System.Drawing.Size(228, 22)
        Me.TxtPat.TabIndex = 12
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(29, 102)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(62, 17)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Paterno:"
        '
        'BtnEdMat
        '
        Me.BtnEdMat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnEdMat.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.BtnEdMat.FlatAppearance.BorderSize = 0
        Me.BtnEdMat.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnEdMat.Location = New System.Drawing.Point(337, 128)
        Me.BtnEdMat.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BtnEdMat.Name = "BtnEdMat"
        Me.BtnEdMat.Size = New System.Drawing.Size(31, 27)
        Me.BtnEdMat.TabIndex = 16
        Me.BtnEdMat.UseVisualStyleBackColor = True
        '
        'TxtMat
        '
        Me.TxtMat.Enabled = False
        Me.TxtMat.Location = New System.Drawing.Point(100, 130)
        Me.TxtMat.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TxtMat.Name = "TxtMat"
        Me.TxtMat.Size = New System.Drawing.Size(228, 22)
        Me.TxtMat.TabIndex = 15
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(29, 134)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(64, 17)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "Materno:"
        '
        'BtnBack
        '
        Me.BtnBack.Location = New System.Drawing.Point(136, 15)
        Me.BtnBack.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BtnBack.Name = "BtnBack"
        Me.BtnBack.Size = New System.Drawing.Size(132, 28)
        Me.BtnBack.TabIndex = 17
        Me.BtnBack.Text = "Menú General"
        Me.BtnBack.UseVisualStyleBackColor = True
        '
        'BtnGuardar
        '
        Me.BtnGuardar.Location = New System.Drawing.Point(197, 226)
        Me.BtnGuardar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BtnGuardar.Name = "BtnGuardar"
        Me.BtnGuardar.Size = New System.Drawing.Size(132, 28)
        Me.BtnGuardar.TabIndex = 18
        Me.BtnGuardar.Text = "Guardar"
        Me.BtnGuardar.UseVisualStyleBackColor = True
        '
        'BtnSalir
        '
        Me.BtnSalir.Location = New System.Drawing.Point(197, 262)
        Me.BtnSalir.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BtnSalir.Name = "BtnSalir"
        Me.BtnSalir.Size = New System.Drawing.Size(132, 28)
        Me.BtnSalir.TabIndex = 19
        Me.BtnSalir.Text = "Salir"
        Me.BtnSalir.UseVisualStyleBackColor = True
        '
        'Perfil
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(379, 321)
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
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
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
