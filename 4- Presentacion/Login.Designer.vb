<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Login
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Login))
        Me.BunifuElipse1 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.BunifuDragControl1 = New Bunifu.Framework.UI.BunifuDragControl(Me.components)
        Me.header = New System.Windows.Forms.Panel()
        Me.BunifuImageButton1 = New Bunifu.Framework.UI.BunifuImageButton()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.BunifuCustomLabel1 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.btnLogin = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.txtUsuario = New Bunifu.Framework.UI.BunifuTextbox()
        Me.txtPassword = New Bunifu.Framework.UI.BunifuTextbox()
        Me.header.SuspendLayout()
        CType(Me.BunifuImageButton1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BunifuElipse1
        '
        Me.BunifuElipse1.ElipseRadius = 5
        Me.BunifuElipse1.TargetControl = Me
        '
        'BunifuDragControl1
        '
        Me.BunifuDragControl1.Fixed = True
        Me.BunifuDragControl1.Horizontal = True
        Me.BunifuDragControl1.TargetControl = Me.header
        Me.BunifuDragControl1.Vertical = True
        '
        'header
        '
        Me.header.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.header.Controls.Add(Me.BunifuImageButton1)
        Me.header.Controls.Add(Me.PictureBox2)
        Me.header.Controls.Add(Me.BunifuCustomLabel1)
        Me.header.Dock = System.Windows.Forms.DockStyle.Top
        Me.header.Location = New System.Drawing.Point(0, 0)
        Me.header.Name = "header"
        Me.header.Size = New System.Drawing.Size(664, 43)
        Me.header.TabIndex = 0
        '
        'BunifuImageButton1
        '
        Me.BunifuImageButton1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.BunifuImageButton1.Image = CType(resources.GetObject("BunifuImageButton1.Image"), System.Drawing.Image)
        Me.BunifuImageButton1.ImageActive = Nothing
        Me.BunifuImageButton1.Location = New System.Drawing.Point(623, 9)
        Me.BunifuImageButton1.Name = "BunifuImageButton1"
        Me.BunifuImageButton1.Size = New System.Drawing.Size(29, 23)
        Me.BunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.BunifuImageButton1.TabIndex = 4
        Me.BunifuImageButton1.TabStop = False
        Me.BunifuImageButton1.Zoom = 10
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(3, 1)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(31, 39)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 3
        Me.PictureBox2.TabStop = False
        '
        'BunifuCustomLabel1
        '
        Me.BunifuCustomLabel1.AutoSize = True
        Me.BunifuCustomLabel1.Font = New System.Drawing.Font("Century", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(178, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BunifuCustomLabel1.Location = New System.Drawing.Point(39, 9)
        Me.BunifuCustomLabel1.Name = "BunifuCustomLabel1"
        Me.BunifuCustomLabel1.Size = New System.Drawing.Size(133, 23)
        Me.BunifuCustomLabel1.TabIndex = 2
        Me.BunifuCustomLabel1.Text = "Iniciar Sesión"
        '
        'btnLogin
        '
        Me.btnLogin.Activecolor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.btnLogin.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.btnLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnLogin.BorderRadius = 0
        Me.btnLogin.ButtonText = "Ingresar"
        Me.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnLogin.DisabledColor = System.Drawing.Color.Gray
        Me.btnLogin.Iconcolor = System.Drawing.Color.Transparent
        Me.btnLogin.Iconimage = CType(resources.GetObject("btnLogin.Iconimage"), System.Drawing.Image)
        Me.btnLogin.Iconimage_right = Nothing
        Me.btnLogin.Iconimage_right_Selected = Nothing
        Me.btnLogin.Iconimage_Selected = Nothing
        Me.btnLogin.IconMarginLeft = 0
        Me.btnLogin.IconMarginRight = 0
        Me.btnLogin.IconRightVisible = True
        Me.btnLogin.IconRightZoom = 0R
        Me.btnLogin.IconVisible = True
        Me.btnLogin.IconZoom = 90.0R
        Me.btnLogin.IsTab = False
        Me.btnLogin.Location = New System.Drawing.Point(259, 234)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.btnLogin.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.btnLogin.OnHoverTextColor = System.Drawing.Color.White
        Me.btnLogin.selected = False
        Me.btnLogin.Size = New System.Drawing.Size(117, 48)
        Me.btnLogin.TabIndex = 5
        Me.btnLogin.Text = "Ingresar"
        Me.btnLogin.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnLogin.Textcolor = System.Drawing.Color.White
        Me.btnLogin.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'txtUsuario
        '
        Me.txtUsuario.BackColor = System.Drawing.Color.Silver
        Me.txtUsuario.BackgroundImage = CType(resources.GetObject("txtUsuario.BackgroundImage"), System.Drawing.Image)
        Me.txtUsuario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.txtUsuario.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.txtUsuario.Icon = CType(resources.GetObject("txtUsuario.Icon"), System.Drawing.Image)
        Me.txtUsuario.Location = New System.Drawing.Point(180, 129)
        Me.txtUsuario.Name = "txtUsuario"
        Me.txtUsuario.Size = New System.Drawing.Size(307, 36)
        Me.txtUsuario.TabIndex = 8
        Me.txtUsuario.text = ""
        '
        'txtPassword
        '
        Me.txtPassword.BackColor = System.Drawing.Color.Silver
        Me.txtPassword.BackgroundImage = CType(resources.GetObject("txtPassword.BackgroundImage"), System.Drawing.Image)
        Me.txtPassword.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.txtPassword.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.txtPassword.Icon = CType(resources.GetObject("txtPassword.Icon"), System.Drawing.Image)
        Me.txtPassword.Location = New System.Drawing.Point(180, 171)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Size = New System.Drawing.Size(307, 36)
        Me.txtPassword.TabIndex = 9
        Me.txtPassword.Tag = ""
        Me.txtPassword.text = ""
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(664, 321)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.txtUsuario)
        Me.Controls.Add(Me.btnLogin)
        Me.Controls.Add(Me.header)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.Name = "Login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.header.ResumeLayout(False)
        Me.header.PerformLayout()
        CType(Me.BunifuImageButton1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BunifuElipse1 As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents BunifuDragControl1 As Bunifu.Framework.UI.BunifuDragControl
    Friend WithEvents header As Panel
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents BunifuCustomLabel1 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents btnLogin As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents BunifuImageButton1 As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents txtPassword As Bunifu.Framework.UI.BunifuTextbox
    Friend WithEvents txtUsuario As Bunifu.Framework.UI.BunifuTextbox
End Class
