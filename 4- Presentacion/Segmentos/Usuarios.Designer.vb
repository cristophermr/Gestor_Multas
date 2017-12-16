<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Usuarios
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Usuarios))
        Me.pnlContenido = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnedit = New Bunifu.Framework.UI.BunifuImageButton()
        Me.btndelete = New Bunifu.Framework.UI.BunifuImageButton()
        Me.btnAdd = New Bunifu.Framework.UI.BunifuImageButton()
        Me.txtBuscar = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.btnBuscar = New Bunifu.Framework.UI.BunifuImageButton()
        Me.pnlContenido.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.btnedit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btndelete, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnAdd, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnBuscar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnlContenido
        '
        Me.pnlContenido.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.pnlContenido.Controls.Add(Me.Panel1)
        Me.pnlContenido.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlContenido.Location = New System.Drawing.Point(0, 0)
        Me.pnlContenido.Name = "pnlContenido"
        Me.pnlContenido.Size = New System.Drawing.Size(810, 518)
        Me.pnlContenido.TabIndex = 6
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.Panel1.Controls.Add(Me.btnedit)
        Me.Panel1.Controls.Add(Me.btndelete)
        Me.Panel1.Controls.Add(Me.btnAdd)
        Me.Panel1.Controls.Add(Me.txtBuscar)
        Me.Panel1.Controls.Add(Me.btnBuscar)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(810, 42)
        Me.Panel1.TabIndex = 1
        '
        'btnedit
        '
        Me.btnedit.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.btnedit.Image = CType(resources.GetObject("btnedit.Image"), System.Drawing.Image)
        Me.btnedit.ImageActive = Nothing
        Me.btnedit.InitialImage = CType(resources.GetObject("btnedit.InitialImage"), System.Drawing.Image)
        Me.btnedit.Location = New System.Drawing.Point(701, 7)
        Me.btnedit.Name = "btnedit"
        Me.btnedit.Size = New System.Drawing.Size(50, 29)
        Me.btnedit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnedit.TabIndex = 7
        Me.btnedit.TabStop = False
        Me.btnedit.Zoom = 10
        '
        'btndelete
        '
        Me.btndelete.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.btndelete.Image = CType(resources.GetObject("btndelete.Image"), System.Drawing.Image)
        Me.btndelete.ImageActive = Nothing
        Me.btndelete.InitialImage = CType(resources.GetObject("btndelete.InitialImage"), System.Drawing.Image)
        Me.btndelete.Location = New System.Drawing.Point(757, 7)
        Me.btndelete.Name = "btndelete"
        Me.btndelete.Size = New System.Drawing.Size(50, 29)
        Me.btndelete.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btndelete.TabIndex = 6
        Me.btndelete.TabStop = False
        Me.btndelete.Zoom = 10
        '
        'btnAdd
        '
        Me.btnAdd.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.btnAdd.Image = CType(resources.GetObject("btnAdd.Image"), System.Drawing.Image)
        Me.btnAdd.ImageActive = Nothing
        Me.btnAdd.InitialImage = CType(resources.GetObject("btnAdd.InitialImage"), System.Drawing.Image)
        Me.btnAdd.Location = New System.Drawing.Point(645, 7)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(50, 29)
        Me.btnAdd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnAdd.TabIndex = 5
        Me.btnAdd.TabStop = False
        Me.btnAdd.Zoom = 10
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
        Me.txtBuscar.TabIndex = 3
        Me.txtBuscar.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'btnBuscar
        '
        Me.btnBuscar.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.btnBuscar.Image = CType(resources.GetObject("btnBuscar.Image"), System.Drawing.Image)
        Me.btnBuscar.ImageActive = Nothing
        Me.btnBuscar.Location = New System.Drawing.Point(179, 5)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(50, 29)
        Me.btnBuscar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnBuscar.TabIndex = 2
        Me.btnBuscar.TabStop = False
        Me.btnBuscar.Zoom = 10
        '
        'Usuarios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.pnlContenido)
        Me.Name = "Usuarios"
        Me.Size = New System.Drawing.Size(810, 518)
        Me.pnlContenido.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        CType(Me.btnedit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btndelete, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnAdd, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnBuscar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlContenido As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnedit As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents btndelete As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents btnAdd As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents txtBuscar As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents btnBuscar As Bunifu.Framework.UI.BunifuImageButton
End Class
