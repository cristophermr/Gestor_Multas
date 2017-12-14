<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Multas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Multas))
        Me.pnlContenido = New System.Windows.Forms.Panel()
        Me.pnlAcciones = New System.Windows.Forms.Panel()
        Me.BunifuImageButton3 = New Bunifu.Framework.UI.BunifuImageButton()
        Me.BunifuImageButton2 = New Bunifu.Framework.UI.BunifuImageButton()
        Me.BunifuImageButton1 = New Bunifu.Framework.UI.BunifuImageButton()
        Me.txtBuscar = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.btnimgBuscar = New Bunifu.Framework.UI.BunifuImageButton()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.MultasENBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CodigoMultaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaMultaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreTraficoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MontoMultaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IndPagadaDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.CedulaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.pnlContenido.SuspendLayout()
        Me.pnlAcciones.SuspendLayout()
        CType(Me.BunifuImageButton3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BunifuImageButton2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BunifuImageButton1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnimgBuscar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MultasENBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnlContenido
        '
        Me.pnlContenido.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.pnlContenido.Controls.Add(Me.DataGridView1)
        Me.pnlContenido.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlContenido.Location = New System.Drawing.Point(0, 38)
        Me.pnlContenido.Name = "pnlContenido"
        Me.pnlContenido.Size = New System.Drawing.Size(810, 480)
        Me.pnlContenido.TabIndex = 3
        '
        'pnlAcciones
        '
        Me.pnlAcciones.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.pnlAcciones.Controls.Add(Me.BunifuImageButton3)
        Me.pnlAcciones.Controls.Add(Me.BunifuImageButton2)
        Me.pnlAcciones.Controls.Add(Me.BunifuImageButton1)
        Me.pnlAcciones.Controls.Add(Me.txtBuscar)
        Me.pnlAcciones.Controls.Add(Me.btnimgBuscar)
        Me.pnlAcciones.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlAcciones.Location = New System.Drawing.Point(0, 0)
        Me.pnlAcciones.Name = "pnlAcciones"
        Me.pnlAcciones.Size = New System.Drawing.Size(810, 38)
        Me.pnlAcciones.TabIndex = 2
        '
        'BunifuImageButton3
        '
        Me.BunifuImageButton3.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.BunifuImageButton3.Image = CType(resources.GetObject("BunifuImageButton3.Image"), System.Drawing.Image)
        Me.BunifuImageButton3.ImageActive = Nothing
        Me.BunifuImageButton3.InitialImage = CType(resources.GetObject("BunifuImageButton3.InitialImage"), System.Drawing.Image)
        Me.BunifuImageButton3.Location = New System.Drawing.Point(701, 6)
        Me.BunifuImageButton3.Name = "BunifuImageButton3"
        Me.BunifuImageButton3.Size = New System.Drawing.Size(50, 29)
        Me.BunifuImageButton3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.BunifuImageButton3.TabIndex = 4
        Me.BunifuImageButton3.TabStop = False
        Me.BunifuImageButton3.Zoom = 10
        '
        'BunifuImageButton2
        '
        Me.BunifuImageButton2.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.BunifuImageButton2.Image = CType(resources.GetObject("BunifuImageButton2.Image"), System.Drawing.Image)
        Me.BunifuImageButton2.ImageActive = Nothing
        Me.BunifuImageButton2.InitialImage = CType(resources.GetObject("BunifuImageButton2.InitialImage"), System.Drawing.Image)
        Me.BunifuImageButton2.Location = New System.Drawing.Point(757, 6)
        Me.BunifuImageButton2.Name = "BunifuImageButton2"
        Me.BunifuImageButton2.Size = New System.Drawing.Size(50, 29)
        Me.BunifuImageButton2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.BunifuImageButton2.TabIndex = 3
        Me.BunifuImageButton2.TabStop = False
        Me.BunifuImageButton2.Zoom = 10
        '
        'BunifuImageButton1
        '
        Me.BunifuImageButton1.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.BunifuImageButton1.Image = CType(resources.GetObject("BunifuImageButton1.Image"), System.Drawing.Image)
        Me.BunifuImageButton1.ImageActive = Nothing
        Me.BunifuImageButton1.InitialImage = CType(resources.GetObject("BunifuImageButton1.InitialImage"), System.Drawing.Image)
        Me.BunifuImageButton1.Location = New System.Drawing.Point(645, 6)
        Me.BunifuImageButton1.Name = "BunifuImageButton1"
        Me.BunifuImageButton1.Size = New System.Drawing.Size(50, 29)
        Me.BunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.BunifuImageButton1.TabIndex = 2
        Me.BunifuImageButton1.TabStop = False
        Me.BunifuImageButton1.Zoom = 10
        '
        'txtBuscar
        '
        Me.txtBuscar.BorderColorFocused = System.Drawing.Color.Blue
        Me.txtBuscar.BorderColorIdle = System.Drawing.Color.WhiteSmoke
        Me.txtBuscar.BorderColorMouseHover = System.Drawing.Color.Blue
        Me.txtBuscar.BorderThickness = 3
        Me.txtBuscar.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtBuscar.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.txtBuscar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(178, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtBuscar.isPassword = False
        Me.txtBuscar.Location = New System.Drawing.Point(4, 0)
        Me.txtBuscar.Margin = New System.Windows.Forms.Padding(4)
        Me.txtBuscar.Name = "txtBuscar"
        Me.txtBuscar.Size = New System.Drawing.Size(179, 38)
        Me.txtBuscar.TabIndex = 1
        Me.txtBuscar.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'btnimgBuscar
        '
        Me.btnimgBuscar.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.btnimgBuscar.Image = CType(resources.GetObject("btnimgBuscar.Image"), System.Drawing.Image)
        Me.btnimgBuscar.ImageActive = Nothing
        Me.btnimgBuscar.Location = New System.Drawing.Point(179, 5)
        Me.btnimgBuscar.Name = "btnimgBuscar"
        Me.btnimgBuscar.Size = New System.Drawing.Size(50, 29)
        Me.btnimgBuscar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnimgBuscar.TabIndex = 0
        Me.btnimgBuscar.TabStop = False
        Me.btnimgBuscar.Zoom = 10
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CodigoMultaDataGridViewTextBoxColumn, Me.FechaMultaDataGridViewTextBoxColumn, Me.NombreTraficoDataGridViewTextBoxColumn, Me.MontoMultaDataGridViewTextBoxColumn, Me.IndPagadaDataGridViewCheckBoxColumn, Me.CedulaDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.MultasENBindingSource
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.Location = New System.Drawing.Point(0, 0)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(810, 480)
        Me.DataGridView1.TabIndex = 0
        '
        'MultasENBindingSource
        '
        Me.MultasENBindingSource.DataSource = GetType(_03Entidades.MultasEN)
        '
        'CodigoMultaDataGridViewTextBoxColumn
        '
        Me.CodigoMultaDataGridViewTextBoxColumn.DataPropertyName = "Codigo_Multa"
        Me.CodigoMultaDataGridViewTextBoxColumn.HeaderText = "Codigo_Multa"
        Me.CodigoMultaDataGridViewTextBoxColumn.Name = "CodigoMultaDataGridViewTextBoxColumn"
        '
        'FechaMultaDataGridViewTextBoxColumn
        '
        Me.FechaMultaDataGridViewTextBoxColumn.DataPropertyName = "Fecha_Multa"
        Me.FechaMultaDataGridViewTextBoxColumn.HeaderText = "Fecha_Multa"
        Me.FechaMultaDataGridViewTextBoxColumn.Name = "FechaMultaDataGridViewTextBoxColumn"
        '
        'NombreTraficoDataGridViewTextBoxColumn
        '
        Me.NombreTraficoDataGridViewTextBoxColumn.DataPropertyName = "Nombre_Trafico"
        Me.NombreTraficoDataGridViewTextBoxColumn.HeaderText = "Nombre_Trafico"
        Me.NombreTraficoDataGridViewTextBoxColumn.Name = "NombreTraficoDataGridViewTextBoxColumn"
        '
        'MontoMultaDataGridViewTextBoxColumn
        '
        Me.MontoMultaDataGridViewTextBoxColumn.DataPropertyName = "Monto_Multa"
        Me.MontoMultaDataGridViewTextBoxColumn.HeaderText = "Monto_Multa"
        Me.MontoMultaDataGridViewTextBoxColumn.Name = "MontoMultaDataGridViewTextBoxColumn"
        '
        'IndPagadaDataGridViewCheckBoxColumn
        '
        Me.IndPagadaDataGridViewCheckBoxColumn.DataPropertyName = "Ind_Pagada"
        Me.IndPagadaDataGridViewCheckBoxColumn.HeaderText = "Ind_Pagada"
        Me.IndPagadaDataGridViewCheckBoxColumn.Name = "IndPagadaDataGridViewCheckBoxColumn"
        '
        'CedulaDataGridViewTextBoxColumn
        '
        Me.CedulaDataGridViewTextBoxColumn.DataPropertyName = "Cedula"
        Me.CedulaDataGridViewTextBoxColumn.HeaderText = "Cedula"
        Me.CedulaDataGridViewTextBoxColumn.Name = "CedulaDataGridViewTextBoxColumn"
        '
        'Multas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.pnlContenido)
        Me.Controls.Add(Me.pnlAcciones)
        Me.Name = "Multas"
        Me.Size = New System.Drawing.Size(810, 518)
        Me.pnlContenido.ResumeLayout(False)
        Me.pnlAcciones.ResumeLayout(False)
        CType(Me.BunifuImageButton3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BunifuImageButton2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BunifuImageButton1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnimgBuscar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MultasENBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlContenido As Panel
    Friend WithEvents pnlAcciones As Panel
    Friend WithEvents BunifuImageButton3 As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents BunifuImageButton2 As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents BunifuImageButton1 As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents txtBuscar As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents btnimgBuscar As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents CodigoMultaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FechaMultaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NombreTraficoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MontoMultaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IndPagadaDataGridViewCheckBoxColumn As DataGridViewCheckBoxColumn
    Friend WithEvents CedulaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MultasENBindingSource As BindingSource
End Class
