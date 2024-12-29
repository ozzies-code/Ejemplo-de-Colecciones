<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEjemploColecciones
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btnMostrarNombres = New System.Windows.Forms.Button()
        Me.txtNombres = New System.Windows.Forms.TextBox()
        Me.lblNombres = New System.Windows.Forms.Label()
        Me.lblApellidos = New System.Windows.Forms.Label()
        Me.txtApellidos = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'btnMostrarNombres
        '
        Me.btnMostrarNombres.Location = New System.Drawing.Point(124, 129)
        Me.btnMostrarNombres.Name = "btnMostrarNombres"
        Me.btnMostrarNombres.Size = New System.Drawing.Size(102, 64)
        Me.btnMostrarNombres.TabIndex = 0
        Me.btnMostrarNombres.Text = "&Mostrar Nombres"
        Me.btnMostrarNombres.UseVisualStyleBackColor = True
        '
        'txtNombres
        '
        Me.txtNombres.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txtNombres.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNombres.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.txtNombres.Location = New System.Drawing.Point(72, 26)
        Me.txtNombres.Name = "txtNombres"
        Me.txtNombres.Size = New System.Drawing.Size(259, 26)
        Me.txtNombres.TabIndex = 1
        '
        'lblNombres
        '
        Me.lblNombres.AutoSize = True
        Me.lblNombres.Location = New System.Drawing.Point(21, 26)
        Me.lblNombres.Name = "lblNombres"
        Me.lblNombres.Size = New System.Drawing.Size(45, 19)
        Me.lblNombres.TabIndex = 2
        Me.lblNombres.Text = "NOMBRES"
        '
        'lblApellidos
        '
        Me.lblApellidos.AutoSize = True
        Me.lblApellidos.Location = New System.Drawing.Point(21, 70)
        Me.lblApellidos.Name = "lblApellidos"
        Me.lblApellidos.Size = New System.Drawing.Size(52, 19)
        Me.lblApellidos.TabIndex = 4
        Me.lblApellidos.Text = "APELLIDOS"
        '
        'txtApellidos
        '
        Me.txtApellidos.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txtApellidos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtApellidos.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.txtApellidos.Location = New System.Drawing.Point(72, 70)
        Me.txtApellidos.Name = "txtApellidos"
        Me.txtApellidos.Size = New System.Drawing.Size(259, 26)
        Me.txtApellidos.TabIndex = 3
        '
        'frmEjemploColecciones
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(5.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.IndianRed
        Me.ClientSize = New System.Drawing.Size(347, 207)
        Me.Controls.Add(Me.lblApellidos)
        Me.Controls.Add(Me.txtApellidos)
        Me.Controls.Add(Me.lblNombres)
        Me.Controls.Add(Me.txtNombres)
        Me.Controls.Add(Me.btnMostrarNombres)
        Me.Font = New System.Drawing.Font("Bodoni MT Poster Compressed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.Margin = New System.Windows.Forms.Padding(2, 4, 2, 4)
        Me.Name = "frmEjemploColecciones"
        Me.Text = "Ejemplo de Colecciones"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnMostrarNombres As Button
    Friend WithEvents txtNombres As TextBox
    Friend WithEvents lblNombres As Label
    Friend WithEvents lblApellidos As Label
    Friend WithEvents txtApellidos As TextBox
End Class
