<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PADRE
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PADRE))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ArchivoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LeerXMLToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConfiguracionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RutaArchivosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ArchivoToolStripMenuItem, Me.ConfiguracionToolStripMenuItem, Me.SalirToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1234, 28)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ArchivoToolStripMenuItem
        '
        Me.ArchivoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LeerXMLToolStripMenuItem})
        Me.ArchivoToolStripMenuItem.Name = "ArchivoToolStripMenuItem"
        Me.ArchivoToolStripMenuItem.Size = New System.Drawing.Size(71, 24)
        Me.ArchivoToolStripMenuItem.Text = "Archivo"
        '
        'LeerXMLToolStripMenuItem
        '
        Me.LeerXMLToolStripMenuItem.Name = "LeerXMLToolStripMenuItem"
        Me.LeerXMLToolStripMenuItem.Size = New System.Drawing.Size(152, 24)
        Me.LeerXMLToolStripMenuItem.Text = "Leer XML"
        '
        'ConfiguracionToolStripMenuItem
        '
        Me.ConfiguracionToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RutaArchivosToolStripMenuItem})
        Me.ConfiguracionToolStripMenuItem.Name = "ConfiguracionToolStripMenuItem"
        Me.ConfiguracionToolStripMenuItem.Size = New System.Drawing.Size(114, 24)
        Me.ConfiguracionToolStripMenuItem.Text = "Configuracion"
        '
        'RutaArchivosToolStripMenuItem
        '
        Me.RutaArchivosToolStripMenuItem.Name = "RutaArchivosToolStripMenuItem"
        Me.RutaArchivosToolStripMenuItem.Size = New System.Drawing.Size(168, 24)
        Me.RutaArchivosToolStripMenuItem.Text = "Ruta Archivos"
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(50, 24)
        Me.SalirToolStripMenuItem.Text = "Salir"
        '
        'PADRE
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1234, 794)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "PADRE"
        Me.Text = "PADRE"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents ArchivoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ConfiguracionToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RutaArchivosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LeerXMLToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
