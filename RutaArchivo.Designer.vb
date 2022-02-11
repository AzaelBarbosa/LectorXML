<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RutaArchivo
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
        Me.txtruta = New System.Windows.Forms.TextBox()
        Me.cmdSeleccionar = New System.Windows.Forms.Button()
        Me.cmdAceptar = New System.Windows.Forms.Button()
        Me.cmCancela = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtruta
        '
        Me.txtruta.Location = New System.Drawing.Point(136, 24)
        Me.txtruta.Name = "txtruta"
        Me.txtruta.ReadOnly = True
        Me.txtruta.Size = New System.Drawing.Size(400, 22)
        Me.txtruta.TabIndex = 0
        '
        'cmdSeleccionar
        '
        Me.cmdSeleccionar.Location = New System.Drawing.Point(8, 16)
        Me.cmdSeleccionar.Name = "cmdSeleccionar"
        Me.cmdSeleccionar.Size = New System.Drawing.Size(120, 32)
        Me.cmdSeleccionar.TabIndex = 1
        Me.cmdSeleccionar.Text = "Seleccionar"
        Me.cmdSeleccionar.UseVisualStyleBackColor = True
        '
        'cmdAceptar
        '
        Me.cmdAceptar.Location = New System.Drawing.Point(144, 72)
        Me.cmdAceptar.Name = "cmdAceptar"
        Me.cmdAceptar.Size = New System.Drawing.Size(120, 32)
        Me.cmdAceptar.TabIndex = 2
        Me.cmdAceptar.Text = "Aceptar"
        Me.cmdAceptar.UseVisualStyleBackColor = True
        '
        'cmCancela
        '
        Me.cmCancela.Location = New System.Drawing.Point(272, 72)
        Me.cmCancela.Name = "cmCancela"
        Me.cmCancela.Size = New System.Drawing.Size(120, 32)
        Me.cmCancela.TabIndex = 3
        Me.cmCancela.Text = "Cancelar"
        Me.cmCancela.UseVisualStyleBackColor = True
        '
        'RutaArchivo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(547, 149)
        Me.ControlBox = False
        Me.Controls.Add(Me.cmCancela)
        Me.Controls.Add(Me.cmdAceptar)
        Me.Controls.Add(Me.cmdSeleccionar)
        Me.Controls.Add(Me.txtruta)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "RutaArchivo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "RutaArchivo"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtruta As System.Windows.Forms.TextBox
    Friend WithEvents cmdSeleccionar As System.Windows.Forms.Button
    Friend WithEvents cmdAceptar As System.Windows.Forms.Button
    Friend WithEvents cmCancela As System.Windows.Forms.Button
End Class
