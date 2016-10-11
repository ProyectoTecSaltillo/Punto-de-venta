<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MenuGeneral
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
        Me.BtnMant = New System.Windows.Forms.Button()
        Me.BtnManEmp = New System.Windows.Forms.Button()
        Me.Sol = New System.Windows.Forms.Button()
        Me.B = New System.Windows.Forms.Button()
        Me.Bu = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Verdana", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(247, 32)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Punto de Venta"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'BtnMant
        '
        Me.BtnMant.Location = New System.Drawing.Point(12, 59)
        Me.BtnMant.Name = "BtnMant"
        Me.BtnMant.Size = New System.Drawing.Size(242, 47)
        Me.BtnMant.TabIndex = 1
        Me.BtnMant.Text = "Mantenimiento países"
        Me.BtnMant.UseVisualStyleBackColor = True
        '
        'BtnManEmp
        '
        Me.BtnManEmp.Location = New System.Drawing.Point(12, 112)
        Me.BtnManEmp.Name = "BtnManEmp"
        Me.BtnManEmp.Size = New System.Drawing.Size(242, 44)
        Me.BtnManEmp.TabIndex = 2
        Me.BtnManEmp.Text = "Mantenimiento Empleados"
        Me.BtnManEmp.UseVisualStyleBackColor = True
        '
        'Sol
        '
        Me.Sol.Location = New System.Drawing.Point(12, 162)
        Me.Sol.Name = "Sol"
        Me.Sol.Size = New System.Drawing.Size(242, 44)
        Me.Sol.TabIndex = 3
        Me.Sol.Text = "Solicitudes"
        Me.Sol.UseVisualStyleBackColor = True
        '
        'B
        '
        Me.B.Location = New System.Drawing.Point(12, 212)
        Me.B.Name = "B"
        Me.B.Size = New System.Drawing.Size(242, 44)
        Me.B.TabIndex = 4
        Me.B.Text = "..."
        Me.B.UseVisualStyleBackColor = True
        '
        'Bu
        '
        Me.Bu.Location = New System.Drawing.Point(12, 262)
        Me.Bu.Name = "Bu"
        Me.Bu.Size = New System.Drawing.Size(242, 44)
        Me.Bu.TabIndex = 5
        Me.Bu.Text = "..."
        Me.Bu.UseVisualStyleBackColor = True
        '
        'MenuGeneral
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(266, 318)
        Me.Controls.Add(Me.Bu)
        Me.Controls.Add(Me.B)
        Me.Controls.Add(Me.Sol)
        Me.Controls.Add(Me.BtnManEmp)
        Me.Controls.Add(Me.BtnMant)
        Me.Controls.Add(Me.Label1)
        Me.MaximizeBox = False
        Me.Name = "MenuGeneral"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MenuGeneral"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents BtnMant As Button
    Friend WithEvents BtnManEmp As Button
    Friend WithEvents Sol As Button
    Friend WithEvents B As Button
    Friend WithEvents Bu As Button
End Class
