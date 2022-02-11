<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLeerXML
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLeerXML))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblcantarchivos = New System.Windows.Forms.Label()
        Me.cmdExportar = New System.Windows.Forms.Button()
        Me.DGWDatos = New System.Windows.Forms.DataGridView()
        Me.cmdSalir = New System.Windows.Forms.Button()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblcantarchpdf = New System.Windows.Forms.Label()
        Me.RFC = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NOMBRE = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FECHA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FOLIO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TIPOCOMPROBANTE = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SERIE = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TOTAL = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UUID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UUIDRel = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DGWDatos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(16, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(209, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Archivos Encontreados:"
        '
        'lblcantarchivos
        '
        Me.lblcantarchivos.AutoSize = True
        Me.lblcantarchivos.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcantarchivos.Location = New System.Drawing.Point(80, 56)
        Me.lblcantarchivos.Name = "lblcantarchivos"
        Me.lblcantarchivos.Size = New System.Drawing.Size(19, 20)
        Me.lblcantarchivos.TabIndex = 1
        Me.lblcantarchivos.Text = "0"
        '
        'cmdExportar
        '
        Me.cmdExportar.Location = New System.Drawing.Point(40, 184)
        Me.cmdExportar.Name = "cmdExportar"
        Me.cmdExportar.Size = New System.Drawing.Size(136, 32)
        Me.cmdExportar.TabIndex = 2
        Me.cmdExportar.Text = "Exportar Excel"
        Me.cmdExportar.UseVisualStyleBackColor = True
        '
        'DGWDatos
        '
        Me.DGWDatos.AllowUserToAddRows = False
        Me.DGWDatos.AllowUserToDeleteRows = False
        Me.DGWDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGWDatos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.RFC, Me.NOMBRE, Me.FECHA, Me.FOLIO, Me.TIPOCOMPROBANTE, Me.SERIE, Me.TOTAL, Me.UUID, Me.UUIDRel})
        Me.DGWDatos.Location = New System.Drawing.Point(232, 360)
        Me.DGWDatos.Name = "DGWDatos"
        Me.DGWDatos.ReadOnly = True
        Me.DGWDatos.RowTemplate.Height = 24
        Me.DGWDatos.Size = New System.Drawing.Size(912, 224)
        Me.DGWDatos.TabIndex = 7
        '
        'cmdSalir
        '
        Me.cmdSalir.Location = New System.Drawing.Point(40, 224)
        Me.cmdSalir.Name = "cmdSalir"
        Me.cmdSalir.Size = New System.Drawing.Size(136, 32)
        Me.cmdSalir.TabIndex = 8
        Me.cmdSalir.Text = "Cancelar"
        Me.cmdSalir.UseVisualStyleBackColor = True
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"ORGANIZACION TREVIÑO", "BIENES EXPRESS", "PRODUCTORA EXPRESS", "MARISCOS LA JAIBITA"})
        Me.ComboBox1.Location = New System.Drawing.Point(248, 24)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(568, 24)
        Me.ComboBox1.TabIndex = 9
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(40, 56)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(40, 17)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "XML:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(40, 80)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(39, 17)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "PDF:"
        '
        'lblcantarchpdf
        '
        Me.lblcantarchpdf.AutoSize = True
        Me.lblcantarchpdf.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcantarchpdf.Location = New System.Drawing.Point(80, 80)
        Me.lblcantarchpdf.Name = "lblcantarchpdf"
        Me.lblcantarchpdf.Size = New System.Drawing.Size(19, 20)
        Me.lblcantarchpdf.TabIndex = 11
        Me.lblcantarchpdf.Text = "0"
        '
        'RFC
        '
        Me.RFC.HeaderText = "RFC"
        Me.RFC.Name = "RFC"
        Me.RFC.ReadOnly = True
        '
        'NOMBRE
        '
        Me.NOMBRE.HeaderText = "NOMBRE"
        Me.NOMBRE.Name = "NOMBRE"
        Me.NOMBRE.ReadOnly = True
        '
        'FECHA
        '
        Me.FECHA.HeaderText = "FECHA"
        Me.FECHA.Name = "FECHA"
        Me.FECHA.ReadOnly = True
        '
        'FOLIO
        '
        Me.FOLIO.HeaderText = "FOLIO"
        Me.FOLIO.Name = "FOLIO"
        Me.FOLIO.ReadOnly = True
        '
        'TIPOCOMPROBANTE
        '
        Me.TIPOCOMPROBANTE.HeaderText = "TIPO COMPROBANTE"
        Me.TIPOCOMPROBANTE.Name = "TIPOCOMPROBANTE"
        Me.TIPOCOMPROBANTE.ReadOnly = True
        '
        'SERIE
        '
        Me.SERIE.HeaderText = "SERIE"
        Me.SERIE.Name = "SERIE"
        Me.SERIE.ReadOnly = True
        '
        'TOTAL
        '
        DataGridViewCellStyle1.Format = "C2"
        DataGridViewCellStyle1.NullValue = Nothing
        Me.TOTAL.DefaultCellStyle = DataGridViewCellStyle1
        Me.TOTAL.HeaderText = "TOTAL"
        Me.TOTAL.Name = "TOTAL"
        Me.TOTAL.ReadOnly = True
        '
        'UUID
        '
        Me.UUID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.UUID.HeaderText = "UUID"
        Me.UUID.Name = "UUID"
        Me.UUID.ReadOnly = True
        Me.UUID.Width = 66
        '
        'UUIDRel
        '
        Me.UUIDRel.HeaderText = "UUIDRel"
        Me.UUIDRel.Name = "UUIDRel"
        Me.UUIDRel.ReadOnly = True
        '
        'frmLeerXML
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1290, 611)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lblcantarchpdf)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.cmdSalir)
        Me.Controls.Add(Me.DGWDatos)
        Me.Controls.Add(Me.cmdExportar)
        Me.Controls.Add(Me.lblcantarchivos)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmLeerXML"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Leer XML"
        CType(Me.DGWDatos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblcantarchivos As System.Windows.Forms.Label
    Friend WithEvents cmdExportar As System.Windows.Forms.Button
    Friend WithEvents DGWDatos As System.Windows.Forms.DataGridView
    Friend WithEvents cmdSalir As System.Windows.Forms.Button
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lblcantarchpdf As System.Windows.Forms.Label
    Friend WithEvents RFC As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NOMBRE As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FECHA As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FOLIO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TIPOCOMPROBANTE As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SERIE As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TOTAL As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents UUID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents UUIDRel As System.Windows.Forms.DataGridViewTextBoxColumn

End Class
