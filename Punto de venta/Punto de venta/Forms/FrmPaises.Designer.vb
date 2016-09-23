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
        Me.BtnLimpia.Location = New System.Drawing.Point(93, 184)
        Me.BtnLimpia.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnLimpia.Name = "BtnLimpia"
        Me.BtnLimpia.Size = New System.Drawing.Size(100, 28)
        Me.BtnLimpia.TabIndex = 5
        Me.BtnLimpia.Text = "Limpiar"
        Me.BtnLimpia.UseVisualStyleBackColor = True
        '
        'DGVPaises
        '
        Me.DGVPaises.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken
        Me.DGVPaises.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVPaises.Location = New System.Drawing.Point(18, 20)
        Me.DGVPaises.Margin = New System.Windows.Forms.Padding(4)
        Me.DGVPaises.Name = "DGVPaises"
        Me.DGVPaises.ReadOnly = True
        Me.DGVPaises.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.DGVPaises.Size = New System.Drawing.Size(305, 201)
        Me.DGVPaises.TabIndex = 100
        Me.DGVPaises.TabStop = False
        '
        'Txt_idpais
        '
        Me.Txt_idpais.Location = New System.Drawing.Point(93, 32)
        Me.Txt_idpais.Margin = New System.Windows.Forms.Padding(4)
        Me.Txt_idpais.Name = "Txt_idpais"
        Me.Txt_idpais.Size = New System.Drawing.Size(100, 22)
        Me.Txt_idpais.TabIndex = 1
        '
        'TxtDescripcion
        '
        Me.TxtDescripcion.Location = New System.Drawing.Point(93, 64)
        Me.TxtDescripcion.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtDescripcion.Name = "TxtDescripcion"
        Me.TxtDescripcion.Size = New System.Drawing.Size(100, 22)
        Me.TxtDescripcion.TabIndex = 2
        '
        'BtnEliminar
        '
        Me.BtnEliminar.Enabled = False
        Me.BtnEliminar.Location = New System.Drawing.Point(93, 145)
        Me.BtnEliminar.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnEliminar.Name = "BtnEliminar"
        Me.BtnEliminar.Size = New System.Drawing.Size(100, 28)
        Me.BtnEliminar.TabIndex = 4
        Me.BtnEliminar.Text = "Eliminar"
        Me.BtnEliminar.UseVisualStyleBackColor = True
        '
        'BtnGuardar
        '
        Me.BtnGuardar.Enabled = False
        Me.BtnGuardar.Location = New System.Drawing.Point(93, 109)
        Me.BtnGuardar.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnGuardar.Name = "BtnGuardar"
        Me.BtnGuardar.Size = New System.Drawing.Size(100, 28)
        Me.BtnGuardar.TabIndex = 3
        Me.BtnGuardar.Text = "Guardar"
        Me.BtnGuardar.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(24, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(59, 17)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "N° Pais:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(24, 67)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(62, 17)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Nombre:"
        '
        'SplitContainer1
        '
        Me.SplitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.SplitContainer1.Location = New System.Drawing.Point(12, 12)
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
        Me.SplitContainer1.Size = New System.Drawing.Size(565, 248)
        Me.SplitContainer1.SplitterDistance = 217
        Me.SplitContainer1.TabIndex = 8
        '
        'FrmPaises
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(595, 274)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "FrmPaises"
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
