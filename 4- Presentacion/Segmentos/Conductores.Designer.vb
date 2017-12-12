<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Conductores
    Inherits System.Windows.Forms.UserControl

    'UserControl reemplaza a Dispose para limpiar la lista de componentes.
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
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.ConductoresENBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ConductoresBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BunifuCustomDataGrid1 = New Bunifu.Framework.UI.BunifuCustomDataGrid()
        Me.ConductoresENBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.ConductoresLNBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ConductoresENBindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.CedulaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreCompletoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TelCelularDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TelCasaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaNacimientoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EMailDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DirCompletaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ObservacionesDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IndActivoDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        CType(Me.ConductoresENBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ConductoresBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BunifuCustomDataGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ConductoresENBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ConductoresLNBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ConductoresENBindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ConductoresENBindingSource
        '
        Me.ConductoresENBindingSource.DataSource = GetType(_03Entidades.ConductoresEN)
        '
        'ConductoresBindingSource
        '
        Me.ConductoresBindingSource.DataSource = GetType(_04Presentacion.Conductores)
        '
        'BunifuCustomDataGrid1
        '
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.BunifuCustomDataGrid1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle3
        Me.BunifuCustomDataGrid1.AutoGenerateColumns = False
        Me.BunifuCustomDataGrid1.BackgroundColor = System.Drawing.Color.Gainsboro
        Me.BunifuCustomDataGrid1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.BunifuCustomDataGrid1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(59, Byte), Integer))
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.DarkGray
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.BunifuCustomDataGrid1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.BunifuCustomDataGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.BunifuCustomDataGrid1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CedulaDataGridViewTextBoxColumn, Me.NombreCompletoDataGridViewTextBoxColumn, Me.TelCelularDataGridViewTextBoxColumn, Me.TelCasaDataGridViewTextBoxColumn, Me.FechaNacimientoDataGridViewTextBoxColumn, Me.EMailDataGridViewTextBoxColumn, Me.DirCompletaDataGridViewTextBoxColumn, Me.ObservacionesDataGridViewTextBoxColumn, Me.IndActivoDataGridViewCheckBoxColumn})
        Me.BunifuCustomDataGrid1.DataSource = Me.ConductoresENBindingSource2
        Me.BunifuCustomDataGrid1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BunifuCustomDataGrid1.DoubleBuffered = True
        Me.BunifuCustomDataGrid1.EnableHeadersVisualStyles = False
        Me.BunifuCustomDataGrid1.GridColor = System.Drawing.SystemColors.ControlLight
        Me.BunifuCustomDataGrid1.HeaderBgColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.BunifuCustomDataGrid1.HeaderForeColor = System.Drawing.Color.DarkGray
        Me.BunifuCustomDataGrid1.Location = New System.Drawing.Point(0, 0)
        Me.BunifuCustomDataGrid1.Name = "BunifuCustomDataGrid1"
        Me.BunifuCustomDataGrid1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.BunifuCustomDataGrid1.Size = New System.Drawing.Size(810, 518)
        Me.BunifuCustomDataGrid1.TabIndex = 0
        '
        'ConductoresENBindingSource1
        '
        Me.ConductoresENBindingSource1.DataSource = GetType(_03Entidades.ConductoresEN)
        '
        'ConductoresLNBindingSource
        '
        Me.ConductoresLNBindingSource.DataSource = GetType(_02LogicaNegocios.ConductoresLN)
        '
        'ConductoresENBindingSource2
        '
        Me.ConductoresENBindingSource2.DataSource = GetType(_03Entidades.ConductoresEN)
        '
        'CedulaDataGridViewTextBoxColumn
        '
        Me.CedulaDataGridViewTextBoxColumn.DataPropertyName = "Cedula"
        Me.CedulaDataGridViewTextBoxColumn.HeaderText = "Cedula"
        Me.CedulaDataGridViewTextBoxColumn.Name = "CedulaDataGridViewTextBoxColumn"
        '
        'NombreCompletoDataGridViewTextBoxColumn
        '
        Me.NombreCompletoDataGridViewTextBoxColumn.DataPropertyName = "NombreCompleto"
        Me.NombreCompletoDataGridViewTextBoxColumn.HeaderText = "NombreCompleto"
        Me.NombreCompletoDataGridViewTextBoxColumn.Name = "NombreCompletoDataGridViewTextBoxColumn"
        '
        'TelCelularDataGridViewTextBoxColumn
        '
        Me.TelCelularDataGridViewTextBoxColumn.DataPropertyName = "Tel_Celular"
        Me.TelCelularDataGridViewTextBoxColumn.HeaderText = "Tel_Celular"
        Me.TelCelularDataGridViewTextBoxColumn.Name = "TelCelularDataGridViewTextBoxColumn"
        '
        'TelCasaDataGridViewTextBoxColumn
        '
        Me.TelCasaDataGridViewTextBoxColumn.DataPropertyName = "Tel_Casa"
        Me.TelCasaDataGridViewTextBoxColumn.HeaderText = "Tel_Casa"
        Me.TelCasaDataGridViewTextBoxColumn.Name = "TelCasaDataGridViewTextBoxColumn"
        '
        'FechaNacimientoDataGridViewTextBoxColumn
        '
        Me.FechaNacimientoDataGridViewTextBoxColumn.DataPropertyName = "Fecha_Nacimiento"
        Me.FechaNacimientoDataGridViewTextBoxColumn.HeaderText = "Fecha_Nacimiento"
        Me.FechaNacimientoDataGridViewTextBoxColumn.Name = "FechaNacimientoDataGridViewTextBoxColumn"
        '
        'EMailDataGridViewTextBoxColumn
        '
        Me.EMailDataGridViewTextBoxColumn.DataPropertyName = "E_Mail"
        Me.EMailDataGridViewTextBoxColumn.HeaderText = "E_Mail"
        Me.EMailDataGridViewTextBoxColumn.Name = "EMailDataGridViewTextBoxColumn"
        '
        'DirCompletaDataGridViewTextBoxColumn
        '
        Me.DirCompletaDataGridViewTextBoxColumn.DataPropertyName = "Dir_Completa"
        Me.DirCompletaDataGridViewTextBoxColumn.HeaderText = "Dir_Completa"
        Me.DirCompletaDataGridViewTextBoxColumn.Name = "DirCompletaDataGridViewTextBoxColumn"
        '
        'ObservacionesDataGridViewTextBoxColumn
        '
        Me.ObservacionesDataGridViewTextBoxColumn.DataPropertyName = "Observaciones"
        Me.ObservacionesDataGridViewTextBoxColumn.HeaderText = "Observaciones"
        Me.ObservacionesDataGridViewTextBoxColumn.Name = "ObservacionesDataGridViewTextBoxColumn"
        '
        'IndActivoDataGridViewCheckBoxColumn
        '
        Me.IndActivoDataGridViewCheckBoxColumn.DataPropertyName = "Ind_Activo"
        Me.IndActivoDataGridViewCheckBoxColumn.HeaderText = "Ind_Activo"
        Me.IndActivoDataGridViewCheckBoxColumn.Name = "IndActivoDataGridViewCheckBoxColumn"
        '
        'Conductores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.Controls.Add(Me.BunifuCustomDataGrid1)
        Me.Name = "Conductores"
        Me.Size = New System.Drawing.Size(810, 518)
        CType(Me.ConductoresENBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ConductoresBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BunifuCustomDataGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ConductoresENBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ConductoresLNBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ConductoresENBindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ConductoresENBindingSource As BindingSource
    Friend WithEvents ConductoresBindingSource As BindingSource
    Friend WithEvents BunifuCustomDataGrid1 As Bunifu.Framework.UI.BunifuCustomDataGrid
    Friend WithEvents ConductoresENBindingSource1 As BindingSource
    Friend WithEvents CedulaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NombreCompletoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TelCelularDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TelCasaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FechaNacimientoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EMailDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DirCompletaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ObservacionesDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IndActivoDataGridViewCheckBoxColumn As DataGridViewCheckBoxColumn
    Friend WithEvents ConductoresENBindingSource2 As BindingSource
    Friend WithEvents ConductoresLNBindingSource As BindingSource
End Class
