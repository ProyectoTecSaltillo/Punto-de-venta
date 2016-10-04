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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        CType(Me.DGVPaises, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.SuspendLayout()
        '
        'BtnLimpia
        '
        Me.BtnLimpia.Location = New System.Drawing.Point(70, 150)
        Me.BtnLimpia.Name = "BtnLimpia"
        Me.BtnLimpia.Size = New System.Drawing.Size(75, 23)
        Me.BtnLimpia.TabIndex = 5
        Me.BtnLimpia.Text = "Limpiar"
        Me.BtnLimpia.UseVisualStyleBackColor = True
        '
        'DGVPaises
        '
        Me.DGVPaises.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken
        Me.DGVPaises.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVPaises.Location = New System.Drawing.Point(14, 16)
        Me.DGVPaises.Name = "DGVPaises"
        Me.DGVPaises.ReadOnly = True
        Me.DGVPaises.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.DGVPaises.Size = New System.Drawing.Size(229, 163)
        Me.DGVPaises.TabIndex = 100
        Me.DGVPaises.TabStop = False
        '
        'Txt_idpais
        '
        Me.Txt_idpais.Location = New System.Drawing.Point(70, 26)
        Me.Txt_idpais.Name = "Txt_idpais"
        Me.Txt_idpais.Size = New System.Drawing.Size(76, 20)
        Me.Txt_idpais.TabIndex = 1
        '
        'TxtDescripcion
        '
        Me.TxtDescripcion.Location = New System.Drawing.Point(70, 52)
        Me.TxtDescripcion.Name = "TxtDescripcion"
        Me.TxtDescripcion.Size = New System.Drawing.Size(76, 20)
        Me.TxtDescripcion.TabIndex = 2
        '
        'BtnEliminar
        '
        Me.BtnEliminar.Enabled = False
        Me.BtnEliminar.Location = New System.Drawing.Point(70, 118)
        Me.BtnEliminar.Name = "BtnEliminar"
        Me.BtnEliminar.Size = New System.Drawing.Size(75, 23)
        Me.BtnEliminar.TabIndex = 4
        Me.BtnEliminar.Text = "Eliminar"
        Me.BtnEliminar.UseVisualStyleBackColor = True
        '
        'BtnGuardar
        '
        Me.BtnGuardar.Enabled = False
        Me.BtnGuardar.Location = New System.Drawing.Point(70, 89)
        Me.BtnGuardar.Name = "BtnGuardar"
        Me.BtnGuardar.Size = New System.Drawing.Size(75, 23)
        Me.BtnGuardar.TabIndex = 3
        Me.BtnGuardar.Text = "Guardar"
        Me.BtnGuardar.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(45, 89)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Id País:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(46, 154)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(66, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Descripción:"
        '
        'SplitContainer1
        '
        Me.SplitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.SplitContainer1.Location = New System.Drawing.Point(9, 10)
        Me.SplitContainer1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.BtnGuardar)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label2)
        Me.SplitContainer1.Panel1.Controls.Add(Me.BtnLimpia)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label1)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Txt_idpais)
        Me.SplitContainer1.Panel1.Controls.Add(Me.TxtDescripcion)
        Me.SplitContainer1.Panel1.Controls.Add(Me.BtnEliminar)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.DGVPaises)
        Me.SplitContainer1.Size = New System.Drawing.Size(424, 202)
        Me.SplitContainer1.SplitterDistance = 162
        Me.SplitContainer1.SplitterWidth = 3
        Me.SplitContainer1.TabIndex = 8
        '
        'FrmPaises
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(446, 223)
        Me.Controls.Add(Me.SplitContainer1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmPaises"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Paises"
        CType(Me.DGVPaises, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BtnLimpia As Button
    Friend WithEvents DGVPaises As DataGridView
    Friend WithEvents Txt_idpais As TextBox
    Friend WithEvents TxtDescripcion As TextBox
    Friend WithEvents BtnEliminar As Button
    Friend WithEvents BtnGuardar As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents SplitContainer1 As SplitContainer
End Class
