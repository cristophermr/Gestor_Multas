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
        Me.grbxActivo = New System.Windows.Forms.GroupBox()
        Me.swtActivo = New Bunifu.Framework.UI.BunifuSwitch()
        Me.BunifuCustomLabel7 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.txtNombre = New WindowsFormsControlLibrary1.BunifuCustomTextbox()
        Me.BunifuCustomLabel8 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.txtCedul = New WindowsFormsControlLibrary1.BunifuCustomTextbox()
        Me.BunifuCustomLabel1 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuCustomTextbox1 = New WindowsFormsControlLibrary1.BunifuCustomTextbox()
        Me.pnlContenido.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.btnedit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btndelete, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnAdd, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnBuscar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grbxActivo.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlContenido
        '
        Me.pnlContenido.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.pnlContenido.Controls.Add(Me.BunifuCustomLabel1)
        Me.pnlContenido.Controls.Add(Me.BunifuCustomTextbox1)
        Me.pnlContenido.Controls.Add(Me.grbxActivo)
        Me.pnlContenido.Controls.Add(Me.BunifuCustomLabel7)
        Me.pnlContenido.Controls.Add(Me.txtNombre)
        Me.pnlContenido.Controls.Add(Me.BunifuCustomLabel8)
        Me.pnlContenido.Controls.Add(Me.txtCedul)
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
        'grbxActivo
        '
        Me.grbxActivo.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grbxActivo.Controls.Add(Me.swtActivo)
        Me.grbxActivo.ForeColor = System.Drawing.Color.Snow
        Me.grbxActivo.Location = New System.Drawing.Point(547, 237)
        Me.grbxActivo.Name = "grbxActivo"
        Me.grbxActivo.Size = New System.Drawing.Size(161, 67)
        Me.grbxActivo.TabIndex = 33
        Me.grbxActivo.TabStop = False
        Me.grbxActivo.Text = "Roles"
        '
        'swtActivo
        '
        Me.swtActivo.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.swtActivo.BorderRadius = 0
        Me.swtActivo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.swtActivo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.swtActivo.Location = New System.Drawing.Point(55, 33)
        Me.swtActivo.Name = "swtActivo"
        Me.swtActivo.Oncolor = System.Drawing.Color.SeaGreen
        Me.swtActivo.Onoffcolor = System.Drawing.Color.DarkGray
        Me.swtActivo.Size = New System.Drawing.Size(51, 19)
        Me.swtActivo.TabIndex = 19
        Me.swtActivo.Textcolor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.swtActivo.Value = False
        '
        'BunifuCustomLabel7
        '
        Me.BunifuCustomLabel7.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BunifuCustomLabel7.AutoSize = True
        Me.BunifuCustomLabel7.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.BunifuCustomLabel7.Location = New System.Drawing.Point(90, 175)
        Me.BunifuCustomLabel7.Name = "BunifuCustomLabel7"
        Me.BunifuCustomLabel7.Size = New System.Drawing.Size(113, 13)
        Me.BunifuCustomLabel7.TabIndex = 22
        Me.BunifuCustomLabel7.Text = "Nombre del Conductor"
        '
        'txtNombre
        '
        Me.txtNombre.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtNombre.BorderColor = System.Drawing.Color.SeaGreen
        Me.txtNombre.Location = New System.Drawing.Point(93, 200)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(208, 20)
        Me.txtNombre.TabIndex = 21
        '
        'BunifuCustomLabel8
        '
        Me.BunifuCustomLabel8.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BunifuCustomLabel8.AutoSize = True
        Me.BunifuCustomLabel8.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.BunifuCustomLabel8.Location = New System.Drawing.Point(90, 248)
        Me.BunifuCustomLabel8.Name = "BunifuCustomLabel8"
        Me.BunifuCustomLabel8.Size = New System.Drawing.Size(43, 13)
        Me.BunifuCustomLabel8.TabIndex = 20
        Me.BunifuCustomLabel8.Text = "Usuario"
        '
        'txtCedul
        '
        Me.txtCedul.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtCedul.BorderColor = System.Drawing.Color.SeaGreen
        Me.txtCedul.Location = New System.Drawing.Point(93, 273)
        Me.txtCedul.Name = "txtCedul"
        Me.txtCedul.Size = New System.Drawing.Size(100, 20)
        Me.txtCedul.TabIndex = 19
        '
        'BunifuCustomLabel1
        '
        Me.BunifuCustomLabel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BunifuCustomLabel1.AutoSize = True
        Me.BunifuCustomLabel1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.BunifuCustomLabel1.Location = New System.Drawing.Point(320, 248)
        Me.BunifuCustomLabel1.Name = "BunifuCustomLabel1"
        Me.BunifuCustomLabel1.Size = New System.Drawing.Size(61, 13)
        Me.BunifuCustomLabel1.TabIndex = 35
        Me.BunifuCustomLabel1.Text = "Contraseña"
        '
        'BunifuCustomTextbox1
        '
        Me.BunifuCustomTextbox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BunifuCustomTextbox1.BorderColor = System.Drawing.Color.SeaGreen
        Me.BunifuCustomTextbox1.Location = New System.Drawing.Point(323, 273)
        Me.BunifuCustomTextbox1.Name = "BunifuCustomTextbox1"
        Me.BunifuCustomTextbox1.Size = New System.Drawing.Size(100, 20)
        Me.BunifuCustomTextbox1.TabIndex = 34
        '
        'Usuarios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.pnlContenido)
        Me.Name = "Usuarios"
        Me.Size = New System.Drawing.Size(810, 518)
        Me.pnlContenido.ResumeLayout(False)
        Me.pnlContenido.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        CType(Me.btnedit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btndelete, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnAdd, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnBuscar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grbxActivo.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlContenido As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnedit As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents btndelete As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents btnAdd As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents txtBuscar As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents btnBuscar As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents BunifuCustomLabel1 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuCustomTextbox1 As WindowsFormsControlLibrary1.BunifuCustomTextbox
    Friend WithEvents grbxActivo As GroupBox
    Friend WithEvents swtActivo As Bunifu.Framework.UI.BunifuSwitch
    Friend WithEvents BunifuCustomLabel7 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents txtNombre As WindowsFormsControlLibrary1.BunifuCustomTextbox
    Friend WithEvents BunifuCustomLabel8 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents txtCedul As WindowsFormsControlLibrary1.BunifuCustomTextbox
End Class
