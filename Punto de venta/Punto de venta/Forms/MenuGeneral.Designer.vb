﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
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
        Me.BtnManCli = New System.Windows.Forms.Button()
        Me.B = New System.Windows.Forms.Button()
        Me.BtnProductos = New System.Windows.Forms.Button()
        Me.BienvenidoToolStrip = New System.Windows.Forms.ToolStrip()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripDropDownButton()
        Me.PerfilToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnDev = New System.Windows.Forms.Button()
        Me.BtnReportes = New System.Windows.Forms.Button()
        Me.BtnVentas = New System.Windows.Forms.Button()
        Me.BienvenidoToolStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'BtnMant
        '
        Me.BtnMant.Location = New System.Drawing.Point(12, 26)
        Me.BtnMant.Name = "BtnMant"
        Me.BtnMant.Size = New System.Drawing.Size(242, 47)
        Me.BtnMant.TabIndex = 1
        Me.BtnMant.Text = "Mantenimiento países"
        Me.BtnMant.UseVisualStyleBackColor = True
        '
        'BtnManEmp
        '
        Me.BtnManEmp.Location = New System.Drawing.Point(12, 79)
        Me.BtnManEmp.Name = "BtnManEmp"
        Me.BtnManEmp.Size = New System.Drawing.Size(242, 44)
        Me.BtnManEmp.TabIndex = 2
        Me.BtnManEmp.Text = "Mantenimiento Empleados"
        Me.BtnManEmp.UseVisualStyleBackColor = True
        '
        'BtnManCli
        '
        Me.BtnManCli.Location = New System.Drawing.Point(12, 128)
        Me.BtnManCli.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.BtnManCli.Name = "BtnManCli"
        Me.BtnManCli.Size = New System.Drawing.Size(242, 44)
        Me.BtnManCli.TabIndex = 7
        Me.BtnManCli.Text = "Mantenimiento Clientes"
        '
        'B
        '
        Me.B.Location = New System.Drawing.Point(12, 179)
        Me.B.Name = "B"
        Me.B.Size = New System.Drawing.Size(242, 44)
        Me.B.TabIndex = 4
        Me.B.Text = "Mantenimiento proveedores"
        Me.B.UseVisualStyleBackColor = True
        '
        'BtnProductos
        '
        Me.BtnProductos.Location = New System.Drawing.Point(12, 229)
        Me.BtnProductos.Name = "BtnProductos"
        Me.BtnProductos.Size = New System.Drawing.Size(242, 44)
        Me.BtnProductos.TabIndex = 5
        Me.BtnProductos.Text = "Productos"
        Me.BtnProductos.UseVisualStyleBackColor = True
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
        Me.BienvenidoToolStrip.Size = New System.Drawing.Size(266, 25)
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
        Me.PerfilToolStripMenuItem.Size = New System.Drawing.Size(101, 22)
        Me.PerfilToolStripMenuItem.Text = "Perfil"
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(101, 22)
        Me.SalirToolStripMenuItem.Text = "Salir"
        Me.SalirToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        '
        'btnDev
        '
        Me.btnDev.Location = New System.Drawing.Point(12, 280)
        Me.btnDev.Name = "btnDev"
        Me.btnDev.Size = New System.Drawing.Size(242, 44)
        Me.btnDev.TabIndex = 8
        Me.btnDev.Text = "Devoluciones"
        Me.btnDev.UseVisualStyleBackColor = True
        '
        'BtnReportes
        '
        Me.BtnReportes.Location = New System.Drawing.Point(12, 330)
        Me.BtnReportes.Name = "BtnReportes"
        Me.BtnReportes.Size = New System.Drawing.Size(242, 44)
        Me.BtnReportes.TabIndex = 9
        Me.BtnReportes.Text = "Reportes"
        Me.BtnReportes.UseVisualStyleBackColor = True
        '
        'BtnVentas
        '
        Me.BtnVentas.Location = New System.Drawing.Point(12, 380)
        Me.BtnVentas.Name = "BtnVentas"
        Me.BtnVentas.Size = New System.Drawing.Size(242, 44)
        Me.BtnVentas.TabIndex = 10
        Me.BtnVentas.Text = "Ventas"
        Me.BtnVentas.UseVisualStyleBackColor = True
        '
        'MenuGeneral
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(266, 432)
        Me.Controls.Add(Me.BtnVentas)
        Me.Controls.Add(Me.BtnReportes)
        Me.Controls.Add(Me.btnDev)
        Me.Controls.Add(Me.BienvenidoToolStrip)
        Me.Controls.Add(Me.BtnProductos)
        Me.Controls.Add(Me.B)
        Me.Controls.Add(Me.BtnManCli)
        Me.Controls.Add(Me.BtnManEmp)
        Me.Controls.Add(Me.BtnMant)
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
    Friend WithEvents BtnManCli As Button
    Friend WithEvents B As Button
    Friend WithEvents BtnProductos As Button
    Friend WithEvents BienvenidoToolStrip As ToolStrip
    Friend WithEvents ToolStripLabel1 As ToolStripDropDownButton
    Friend WithEvents SalirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PerfilToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents btnDev As Button
    Friend WithEvents BtnReportes As Button
    Friend WithEvents BtnVentas As Button
End Class
