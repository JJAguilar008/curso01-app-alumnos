<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Me.btnAcelerar = New System.Windows.Forms.Button
        Me.btnFrenar = New System.Windows.Forms.Button
        Me.btnMover = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'btnAcelerar
        '
        Me.btnAcelerar.Location = New System.Drawing.Point(69, 369)
        Me.btnAcelerar.Name = "btnAcelerar"
        Me.btnAcelerar.Size = New System.Drawing.Size(75, 23)
        Me.btnAcelerar.TabIndex = 0
        Me.btnAcelerar.Text = "Acelerar"
        Me.btnAcelerar.UseVisualStyleBackColor = True
        '
        'btnFrenar
        '
        Me.btnFrenar.Location = New System.Drawing.Point(320, 368)
        Me.btnFrenar.Name = "btnFrenar"
        Me.btnFrenar.Size = New System.Drawing.Size(75, 23)
        Me.btnFrenar.TabIndex = 1
        Me.btnFrenar.Text = "Frenar"
        Me.btnFrenar.UseVisualStyleBackColor = True
        '
        'btnMover
        '
        Me.btnMover.Location = New System.Drawing.Point(590, 367)
        Me.btnMover.Name = "btnMover"
        Me.btnMover.Size = New System.Drawing.Size(75, 23)
        Me.btnMover.TabIndex = 2
        Me.btnMover.Text = "Mover"
        Me.btnMover.UseVisualStyleBackColor = True
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(743, 459)
        Me.Controls.Add(Me.btnMover)
        Me.Controls.Add(Me.btnFrenar)
        Me.Controls.Add(Me.btnAcelerar)
        Me.Name = "Form2"
        Me.Text = "Form2"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnAcelerar As System.Windows.Forms.Button
    Friend WithEvents btnFrenar As System.Windows.Forms.Button
    Friend WithEvents btnMover As System.Windows.Forms.Button
End Class
