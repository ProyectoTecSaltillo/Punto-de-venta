<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmPaises
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
        Me.BtnLimpia = New System.Windows.Forms.Button()
        Me.DGVPaises = New System.Windows.Forms.DataGridView()
        Me.Txt_idpais = New System.Windows.Forms.TextBox()
        Me.TxtDescripcion = New System.Windows.Forms.TextBox()
        Me.BtnEliminar = New System.Windows.Forms.Button()
        Me.BtnGuardar = New System.Windows.Forms.Button()
        CType(Me.DGVPaises, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtnLimpia
        '
        Me.BtnLimpia.Location = New System.Drawing.Point(23, 30)
        Me.BtnLimpia.Name = "BtnLimpia"
        Me.BtnLimpia.Size = New System.Drawing.Size(75, 23)
        Me.BtnLimpia.TabIndex = 0
        Me.BtnLimpia.Text = "Limpia"
        Me.BtnLimpia.UseVisualStyleBackColor = True
        '
        'DGVPaises
        '
        Me.DGVPaises.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVPaises.Location = New System.Drawing.Point(255, 181)
        Me.DGVPaises.Name = "DGVPaises"
        Me.DGVPaises.Size = New System.Drawing.Size(123, 68)
        Me.DGVPaises.TabIndex = 1
        '
        'Txt_idpais
        '
        Me.Txt_idpais.Location = New System.Drawing.Point(52, 100)
        Me.Txt_idpais.Name = "Txt_idpais"
        Me.Txt_idpais.Size = New System.Drawing.Size(100, 20)
        Me.Txt_idpais.TabIndex = 2
        '
        'TxtDescripcion
        '
        Me.TxtDescripcion.Location = New System.Drawing.Point(52, 126)
        Me.TxtDescripcion.Name = "TxtDescripcion"
        Me.TxtDescripcion.Size = New System.Drawing.Size(100, 20)
        Me.TxtDescripcion.TabIndex = 3
        '
        'BtnEliminar
        '
        Me.BtnEliminar.Location = New System.Drawing.Point(121, 30)
        Me.BtnEliminar.Name = "BtnEliminar"
        Me.BtnEliminar.Size = New System.Drawing.Size(75, 23)
        Me.BtnEliminar.TabIndex = 4
        Me.BtnEliminar.Text = "Elimina"
        Me.BtnEliminar.UseVisualStyleBackColor = True
        '
        'BtnGuardar
        '
        Me.BtnGuardar.Location = New System.Drawing.Point(225, 30)
        Me.BtnGuardar.Name = "BtnGuardar"
        Me.BtnGuardar.Size = New System.Drawing.Size(75, 23)
        Me.BtnGuardar.TabIndex = 5
        Me.BtnGuardar.Text = "Guardar"
        Me.BtnGuardar.UseVisualStyleBackColor = True
        '
        'FrmPaises
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(390, 261)
        Me.Controls.Add(Me.BtnGuardar)
        Me.Controls.Add(Me.BtnEliminar)
        Me.Controls.Add(Me.TxtDescripcion)
        Me.Controls.Add(Me.Txt_idpais)
        Me.Controls.Add(Me.DGVPaises)
        Me.Controls.Add(Me.BtnLimpia)
        Me.Name = "FrmPaises"
        Me.Text = "Form1"
        CType(Me.DGVPaises, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnLimpia As Button
    Friend WithEvents DGVPaises As DataGridView
    Friend WithEvents Txt_idpais As TextBox
    Friend WithEvents TxtDescripcion As TextBox
    Friend WithEvents BtnEliminar As Button
    Friend WithEvents BtnGuardar As Button
End Class
