<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtMatricula = New System.Windows.Forms.TextBox
        Me.label = New System.Windows.Forms.Label
        Me.lblNombre = New System.Windows.Forms.Label
        Me.btnConsultar = New System.Windows.Forms.Button
        Me.Label2 = New System.Windows.Forms.Label
        Me.cbMateria = New System.Windows.Forms.ComboBox
        Me.btnAgregar = New System.Windows.Forms.Button
        Me.dgvMaterias = New System.Windows.Forms.DataGridView
        Me.btnGuardar = New System.Windows.Forms.Button
        CType(Me.dgvMaterias, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Matricula:"
        '
        'txtMatricula
        '
        Me.txtMatricula.Location = New System.Drawing.Point(73, 25)
        Me.txtMatricula.Name = "txtMatricula"
        Me.txtMatricula.Size = New System.Drawing.Size(148, 20)
        Me.txtMatricula.TabIndex = 1
        '
        'label
        '
        Me.label.AutoSize = True
        Me.label.Location = New System.Drawing.Point(8, 76)
        Me.label.Name = "label"
        Me.label.Size = New System.Drawing.Size(47, 13)
        Me.label.TabIndex = 2
        Me.label.Text = "Nombre:"
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Location = New System.Drawing.Point(70, 76)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(39, 13)
        Me.lblNombre.TabIndex = 3
        Me.lblNombre.Text = "Label2"
        '
        'btnConsultar
        '
        Me.btnConsultar.Location = New System.Drawing.Point(227, 23)
        Me.btnConsultar.Name = "btnConsultar"
        Me.btnConsultar.Size = New System.Drawing.Size(75, 23)
        Me.btnConsultar.TabIndex = 4
        Me.btnConsultar.Text = "Consultar"
        Me.btnConsultar.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(9, 161)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(45, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Materia:"
        '
        'cbMateria
        '
        Me.cbMateria.Cursor = System.Windows.Forms.Cursors.Default
        Me.cbMateria.FormattingEnabled = True
        Me.cbMateria.Location = New System.Drawing.Point(73, 158)
        Me.cbMateria.Name = "cbMateria"
        Me.cbMateria.Size = New System.Drawing.Size(148, 21)
        Me.cbMateria.TabIndex = 6
        '
        'btnAgregar
        '
        Me.btnAgregar.Location = New System.Drawing.Point(227, 156)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(75, 23)
        Me.btnAgregar.TabIndex = 7
        Me.btnAgregar.Text = "Agregar"
        Me.btnAgregar.UseVisualStyleBackColor = True
        '
        'dgvMaterias
        '
        Me.dgvMaterias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvMaterias.Location = New System.Drawing.Point(12, 233)
        Me.dgvMaterias.Name = "dgvMaterias"
        Me.dgvMaterias.Size = New System.Drawing.Size(429, 150)
        Me.dgvMaterias.TabIndex = 8
        '
        'btnGuardar
        '
        Me.btnGuardar.Location = New System.Drawing.Point(365, 390)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(75, 23)
        Me.btnGuardar.TabIndex = 9
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(453, 423)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.dgvMaterias)
        Me.Controls.Add(Me.btnAgregar)
        Me.Controls.Add(Me.cbMateria)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnConsultar)
        Me.Controls.Add(Me.lblNombre)
        Me.Controls.Add(Me.label)
        Me.Controls.Add(Me.txtMatricula)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form3"
        Me.Text = "Form3"
        CType(Me.dgvMaterias, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtMatricula As System.Windows.Forms.TextBox
    Friend WithEvents label As System.Windows.Forms.Label
    Friend WithEvents lblNombre As System.Windows.Forms.Label
    Friend WithEvents btnConsultar As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cbMateria As System.Windows.Forms.ComboBox
    Friend WithEvents btnAgregar As System.Windows.Forms.Button
    Friend WithEvents dgvMaterias As System.Windows.Forms.DataGridView
    Friend WithEvents btnGuardar As System.Windows.Forms.Button
End Class
