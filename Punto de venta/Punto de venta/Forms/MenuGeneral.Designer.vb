<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MenuGeneral
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
        Me.BtnMant = New System.Windows.Forms.Button()
        Me.BtnManEmp = New System.Windows.Forms.Button()
        Me.Sol = New System.Windows.Forms.Button()
        Me.B = New System.Windows.Forms.Button()
        Me.Bu = New System.Windows.Forms.Button()
        Me.BienvenidoToolStrip = New System.Windows.Forms.ToolStrip()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripDropDownButton()
        Me.PerfilToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BienvenidoToolStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'BtnMant
        '
        Me.BtnMant.Location = New System.Drawing.Point(16, 32)
        Me.BtnMant.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BtnMant.Name = "BtnMant"
        Me.BtnMant.Size = New System.Drawing.Size(323, 58)
        Me.BtnMant.TabIndex = 1
        Me.BtnMant.Text = "Mantenimiento países"
        Me.BtnMant.UseVisualStyleBackColor = True
        '
        'BtnManEmp
        '
        Me.BtnManEmp.Location = New System.Drawing.Point(16, 97)
        Me.BtnManEmp.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BtnManEmp.Name = "BtnManEmp"
        Me.BtnManEmp.Size = New System.Drawing.Size(323, 54)
        Me.BtnManEmp.TabIndex = 2
        Me.BtnManEmp.Text = "Mantenimiento Empleados"
        Me.BtnManEmp.UseVisualStyleBackColor = True
        '
        'Sol
        '
        Me.Sol.Location = New System.Drawing.Point(16, 159)
        Me.Sol.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Sol.Name = "Sol"
        Me.Sol.Size = New System.Drawing.Size(323, 54)
        Me.Sol.TabIndex = 3
        Me.Sol.Text = "Solicitudes"
        Me.Sol.UseVisualStyleBackColor = True
        '
        'B
        '
        Me.B.Location = New System.Drawing.Point(16, 220)
        Me.B.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.B.Name = "B"
        Me.B.Size = New System.Drawing.Size(323, 54)
        Me.B.TabIndex = 4
        Me.B.Text = "..."
        Me.B.UseVisualStyleBackColor = True
        '
        'Bu
        '
        Me.Bu.Location = New System.Drawing.Point(16, 282)
        Me.Bu.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Bu.Name = "Bu"
        Me.Bu.Size = New System.Drawing.Size(323, 54)
        Me.Bu.TabIndex = 5
        Me.Bu.Text = "..."
        Me.Bu.UseVisualStyleBackColor = True
        '
        'BienvenidoToolStrip
        '
        Me.BienvenidoToolStrip.AutoSize = False
        Me.BienvenidoToolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.BienvenidoToolStrip.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.BienvenidoToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel1})
        Me.BienvenidoToolStrip.Location = New System.Drawing.Point(0, 0)
        Me.BienvenidoToolStrip.Name = "BienvenidoToolStrip"
        Me.BienvenidoToolStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.BienvenidoToolStrip.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.BienvenidoToolStrip.Size = New System.Drawing.Size(355, 31)
        Me.BienvenidoToolStrip.TabIndex = 6
        Me.BienvenidoToolStrip.Text = "ToolStrip1"
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.AutoSize = False
        Me.ToolStripLabel1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PerfilToolStripMenuItem, Me.SalirToolStripMenuItem})
        Me.ToolStripLabel1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.ToolStripLabel1.Size = New System.Drawing.Size(98, 22)
        '
        'PerfilToolStripMenuItem
        '
        Me.PerfilToolStripMenuItem.Name = "PerfilToolStripMenuItem"
        Me.PerfilToolStripMenuItem.Size = New System.Drawing.Size(118, 26)
        Me.PerfilToolStripMenuItem.Text = "Perfil"
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(118, 26)
        Me.SalirToolStripMenuItem.Text = "Salir"
        Me.SalirToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        '
        'MenuGeneral
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(355, 346)
        Me.Controls.Add(Me.BienvenidoToolStrip)
        Me.Controls.Add(Me.Bu)
        Me.Controls.Add(Me.B)
        Me.Controls.Add(Me.Sol)
        Me.Controls.Add(Me.BtnManEmp)
        Me.Controls.Add(Me.BtnMant)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.MaximizeBox = False
        Me.Name = "MenuGeneral"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MenuGeneral"
        Me.BienvenidoToolStrip.ResumeLayout(False)
        Me.BienvenidoToolStrip.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BtnMant As Button
    Friend WithEvents BtnManEmp As Button
    Friend WithEvents Sol As Button
    Friend WithEvents B As Button
    Friend WithEvents Bu As Button
    Friend WithEvents BienvenidoToolStrip As ToolStrip
    Friend WithEvents ToolStripLabel1 As ToolStripDropDownButton
    Friend WithEvents SalirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PerfilToolStripMenuItem As ToolStripMenuItem
End Class
