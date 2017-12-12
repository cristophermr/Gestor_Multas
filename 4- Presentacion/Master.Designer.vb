<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Master
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
        Dim Animation16 As BunifuAnimatorNS.Animation = New BunifuAnimatorNS.Animation()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Master))
        Dim Animation17 As BunifuAnimatorNS.Animation = New BunifuAnimatorNS.Animation()
        Dim Animation18 As BunifuAnimatorNS.Animation = New BunifuAnimatorNS.Animation()
        Me.BunifuElipse1 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.header = New System.Windows.Forms.Panel()
        Me.BunifuImageButton5 = New Bunifu.Framework.UI.BunifuImageButton()
        Me.BunifuImageButton4 = New Bunifu.Framework.UI.BunifuImageButton()
        Me.BunifuImageButton2 = New Bunifu.Framework.UI.BunifuImageButton()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.BunifuCustomLabel1 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuDragControl1 = New Bunifu.Framework.UI.BunifuDragControl(Me.components)
        Me.bntMenu = New Bunifu.Framework.UI.BunifuImageButton()
        Me.BunifuImageButton3 = New Bunifu.Framework.UI.BunifuImageButton()
        Me.SlideMenu = New System.Windows.Forms.Panel()
        Me.lblEstado = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.bntProcesos = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.pnlCatalogos = New System.Windows.Forms.Panel()
        Me.bntUsuarios = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.btnConductores = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.bntConductores = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.bntTiposLic = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.Logo = New System.Windows.Forms.PictureBox()
        Me.btnSalir = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.btnReportes = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.bntCatalogos = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.LogoAnimation = New BunifuAnimatorNS.BunifuTransition(Me.components)
        Me.PanelAnimation = New BunifuAnimatorNS.BunifuTransition(Me.components)
        Me.SubMenus = New BunifuAnimatorNS.BunifuTransition(Me.components)
        Me.btnLic = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.BunifuFlatButton4 = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.btnMultas = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.pnlProcesos = New System.Windows.Forms.Panel()
        Me.Conductores1 = New _04Presentacion.Conductores()
        Me.header.SuspendLayout()
        CType(Me.BunifuImageButton5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BunifuImageButton4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BunifuImageButton2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bntMenu, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BunifuImageButton3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SlideMenu.SuspendLayout()
        Me.pnlCatalogos.SuspendLayout()
        CType(Me.Logo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.pnlProcesos.SuspendLayout()
        Me.SuspendLayout()
        '
        'BunifuElipse1
        '
        Me.BunifuElipse1.ElipseRadius = 5
        Me.BunifuElipse1.TargetControl = Me
        '
        'header
        '
        Me.header.AutoSize = True
        Me.header.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.header.Controls.Add(Me.BunifuImageButton5)
        Me.header.Controls.Add(Me.BunifuImageButton4)
        Me.header.Controls.Add(Me.BunifuImageButton2)
        Me.header.Controls.Add(Me.PictureBox2)
        Me.header.Controls.Add(Me.BunifuCustomLabel1)
        Me.LogoAnimation.SetDecoration(Me.header, BunifuAnimatorNS.DecorationType.None)
        Me.PanelAnimation.SetDecoration(Me.header, BunifuAnimatorNS.DecorationType.None)
        Me.SubMenus.SetDecoration(Me.header, BunifuAnimatorNS.DecorationType.None)
        Me.header.Dock = System.Windows.Forms.DockStyle.Top
        Me.header.Location = New System.Drawing.Point(0, 0)
        Me.header.Name = "header"
        Me.header.Size = New System.Drawing.Size(1191, 42)
        Me.header.TabIndex = 1
        '
        'BunifuImageButton5
        '
        Me.BunifuImageButton5.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BunifuImageButton5.BackColor = System.Drawing.Color.Transparent
        Me.LogoAnimation.SetDecoration(Me.BunifuImageButton5, BunifuAnimatorNS.DecorationType.None)
        Me.PanelAnimation.SetDecoration(Me.BunifuImageButton5, BunifuAnimatorNS.DecorationType.None)
        Me.SubMenus.SetDecoration(Me.BunifuImageButton5, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuImageButton5.Image = CType(resources.GetObject("BunifuImageButton5.Image"), System.Drawing.Image)
        Me.BunifuImageButton5.ImageActive = Nothing
        Me.BunifuImageButton5.Location = New System.Drawing.Point(1096, 12)
        Me.BunifuImageButton5.Name = "BunifuImageButton5"
        Me.BunifuImageButton5.Size = New System.Drawing.Size(27, 22)
        Me.BunifuImageButton5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.BunifuImageButton5.TabIndex = 5
        Me.BunifuImageButton5.TabStop = False
        Me.BunifuImageButton5.Zoom = 10
        '
        'BunifuImageButton4
        '
        Me.BunifuImageButton4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BunifuImageButton4.BackColor = System.Drawing.Color.Transparent
        Me.LogoAnimation.SetDecoration(Me.BunifuImageButton4, BunifuAnimatorNS.DecorationType.None)
        Me.PanelAnimation.SetDecoration(Me.BunifuImageButton4, BunifuAnimatorNS.DecorationType.None)
        Me.SubMenus.SetDecoration(Me.BunifuImageButton4, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuImageButton4.Image = CType(resources.GetObject("BunifuImageButton4.Image"), System.Drawing.Image)
        Me.BunifuImageButton4.ImageActive = Nothing
        Me.BunifuImageButton4.Location = New System.Drawing.Point(1125, 12)
        Me.BunifuImageButton4.Name = "BunifuImageButton4"
        Me.BunifuImageButton4.Size = New System.Drawing.Size(27, 22)
        Me.BunifuImageButton4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.BunifuImageButton4.TabIndex = 4
        Me.BunifuImageButton4.TabStop = False
        Me.BunifuImageButton4.Zoom = 10
        '
        'BunifuImageButton2
        '
        Me.BunifuImageButton2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BunifuImageButton2.BackColor = System.Drawing.Color.Transparent
        Me.LogoAnimation.SetDecoration(Me.BunifuImageButton2, BunifuAnimatorNS.DecorationType.None)
        Me.PanelAnimation.SetDecoration(Me.BunifuImageButton2, BunifuAnimatorNS.DecorationType.None)
        Me.SubMenus.SetDecoration(Me.BunifuImageButton2, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuImageButton2.Image = CType(resources.GetObject("BunifuImageButton2.Image"), System.Drawing.Image)
        Me.BunifuImageButton2.ImageActive = Nothing
        Me.BunifuImageButton2.Location = New System.Drawing.Point(1155, 12)
        Me.BunifuImageButton2.Name = "BunifuImageButton2"
        Me.BunifuImageButton2.Size = New System.Drawing.Size(24, 22)
        Me.BunifuImageButton2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.BunifuImageButton2.TabIndex = 3
        Me.BunifuImageButton2.TabStop = False
        Me.BunifuImageButton2.Zoom = 10
        '
        'PictureBox2
        '
        Me.SubMenus.SetDecoration(Me.PictureBox2, BunifuAnimatorNS.DecorationType.None)
        Me.PanelAnimation.SetDecoration(Me.PictureBox2, BunifuAnimatorNS.DecorationType.None)
        Me.LogoAnimation.SetDecoration(Me.PictureBox2, BunifuAnimatorNS.DecorationType.None)
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(18, 0)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(31, 39)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 1
        Me.PictureBox2.TabStop = False
        '
        'BunifuCustomLabel1
        '
        Me.BunifuCustomLabel1.AutoSize = True
        Me.SubMenus.SetDecoration(Me.BunifuCustomLabel1, BunifuAnimatorNS.DecorationType.None)
        Me.PanelAnimation.SetDecoration(Me.BunifuCustomLabel1, BunifuAnimatorNS.DecorationType.None)
        Me.LogoAnimation.SetDecoration(Me.BunifuCustomLabel1, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuCustomLabel1.Font = New System.Drawing.Font("Century", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(178, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BunifuCustomLabel1.Location = New System.Drawing.Point(55, 8)
        Me.BunifuCustomLabel1.Name = "BunifuCustomLabel1"
        Me.BunifuCustomLabel1.Size = New System.Drawing.Size(172, 23)
        Me.BunifuCustomLabel1.TabIndex = 0
        Me.BunifuCustomLabel1.Text = "Gestión de multas"
        '
        'BunifuDragControl1
        '
        Me.BunifuDragControl1.Fixed = True
        Me.BunifuDragControl1.Horizontal = True
        Me.BunifuDragControl1.TargetControl = Me.header
        Me.BunifuDragControl1.Vertical = True
        '
        'bntMenu
        '
        Me.bntMenu.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bntMenu.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.LogoAnimation.SetDecoration(Me.bntMenu, BunifuAnimatorNS.DecorationType.None)
        Me.PanelAnimation.SetDecoration(Me.bntMenu, BunifuAnimatorNS.DecorationType.None)
        Me.SubMenus.SetDecoration(Me.bntMenu, BunifuAnimatorNS.DecorationType.None)
        Me.bntMenu.Image = CType(resources.GetObject("bntMenu.Image"), System.Drawing.Image)
        Me.bntMenu.ImageActive = Nothing
        Me.bntMenu.Location = New System.Drawing.Point(227, 4)
        Me.bntMenu.Name = "bntMenu"
        Me.bntMenu.Size = New System.Drawing.Size(23, 37)
        Me.bntMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.bntMenu.TabIndex = 1
        Me.bntMenu.TabStop = False
        Me.bntMenu.Zoom = 10
        '
        'BunifuImageButton3
        '
        Me.BunifuImageButton3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.BunifuImageButton3.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.LogoAnimation.SetDecoration(Me.BunifuImageButton3, BunifuAnimatorNS.DecorationType.None)
        Me.PanelAnimation.SetDecoration(Me.BunifuImageButton3, BunifuAnimatorNS.DecorationType.None)
        Me.SubMenus.SetDecoration(Me.BunifuImageButton3, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuImageButton3.Image = CType(resources.GetObject("BunifuImageButton3.Image"), System.Drawing.Image)
        Me.BunifuImageButton3.ImageActive = Nothing
        Me.BunifuImageButton3.Location = New System.Drawing.Point(3, 594)
        Me.BunifuImageButton3.Name = "BunifuImageButton3"
        Me.BunifuImageButton3.Size = New System.Drawing.Size(40, 35)
        Me.BunifuImageButton3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.BunifuImageButton3.TabIndex = 8
        Me.BunifuImageButton3.TabStop = False
        Me.BunifuImageButton3.Zoom = 5
        '
        'SlideMenu
        '
        Me.SlideMenu.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.SlideMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.SlideMenu.Controls.Add(Me.lblEstado)
        Me.SlideMenu.Controls.Add(Me.pnlProcesos)
        Me.SlideMenu.Controls.Add(Me.bntProcesos)
        Me.SlideMenu.Controls.Add(Me.pnlCatalogos)
        Me.SlideMenu.Controls.Add(Me.Logo)
        Me.SlideMenu.Controls.Add(Me.btnSalir)
        Me.SlideMenu.Controls.Add(Me.btnReportes)
        Me.SlideMenu.Controls.Add(Me.bntCatalogos)
        Me.SlideMenu.Controls.Add(Me.BunifuImageButton3)
        Me.SlideMenu.Controls.Add(Me.bntMenu)
        Me.LogoAnimation.SetDecoration(Me.SlideMenu, BunifuAnimatorNS.DecorationType.None)
        Me.PanelAnimation.SetDecoration(Me.SlideMenu, BunifuAnimatorNS.DecorationType.None)
        Me.SubMenus.SetDecoration(Me.SlideMenu, BunifuAnimatorNS.DecorationType.None)
        Me.SlideMenu.Dock = System.Windows.Forms.DockStyle.Left
        Me.SlideMenu.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.SlideMenu.Location = New System.Drawing.Point(0, 0)
        Me.SlideMenu.Name = "SlideMenu"
        Me.SlideMenu.Size = New System.Drawing.Size(258, 629)
        Me.SlideMenu.TabIndex = 0
        '
        'lblEstado
        '
        Me.lblEstado.AutoSize = True
        Me.SubMenus.SetDecoration(Me.lblEstado, BunifuAnimatorNS.DecorationType.None)
        Me.PanelAnimation.SetDecoration(Me.lblEstado, BunifuAnimatorNS.DecorationType.None)
        Me.LogoAnimation.SetDecoration(Me.lblEstado, BunifuAnimatorNS.DecorationType.None)
        Me.lblEstado.Location = New System.Drawing.Point(49, 607)
        Me.lblEstado.Name = "lblEstado"
        Me.lblEstado.Size = New System.Drawing.Size(0, 13)
        Me.lblEstado.TabIndex = 1
        '
        'bntProcesos
        '
        Me.bntProcesos.Activecolor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.bntProcesos.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.bntProcesos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.bntProcesos.BorderRadius = 0
        Me.bntProcesos.ButtonText = "  &Procesos"
        Me.bntProcesos.Cursor = System.Windows.Forms.Cursors.Hand
        Me.SubMenus.SetDecoration(Me.bntProcesos, BunifuAnimatorNS.DecorationType.None)
        Me.PanelAnimation.SetDecoration(Me.bntProcesos, BunifuAnimatorNS.DecorationType.None)
        Me.LogoAnimation.SetDecoration(Me.bntProcesos, BunifuAnimatorNS.DecorationType.None)
        Me.bntProcesos.DisabledColor = System.Drawing.Color.Gray
        Me.bntProcesos.ForeColor = System.Drawing.Color.Gray
        Me.bntProcesos.Iconcolor = System.Drawing.Color.Transparent
        Me.bntProcesos.Iconimage = CType(resources.GetObject("bntProcesos.Iconimage"), System.Drawing.Image)
        Me.bntProcesos.Iconimage_right = CType(resources.GetObject("bntProcesos.Iconimage_right"), System.Drawing.Image)
        Me.bntProcesos.Iconimage_right_Selected = Nothing
        Me.bntProcesos.Iconimage_Selected = Nothing
        Me.bntProcesos.IconMarginLeft = 0
        Me.bntProcesos.IconMarginRight = 0
        Me.bntProcesos.IconRightVisible = True
        Me.bntProcesos.IconRightZoom = 0R
        Me.bntProcesos.IconVisible = True
        Me.bntProcesos.IconZoom = 40.0R
        Me.bntProcesos.IsTab = True
        Me.bntProcesos.Location = New System.Drawing.Point(3, 236)
        Me.bntProcesos.Name = "bntProcesos"
        Me.bntProcesos.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.bntProcesos.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.bntProcesos.OnHoverTextColor = System.Drawing.Color.White
        Me.bntProcesos.selected = False
        Me.bntProcesos.Size = New System.Drawing.Size(247, 42)
        Me.bntProcesos.TabIndex = 10
        Me.bntProcesos.Text = "  &Procesos"
        Me.bntProcesos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bntProcesos.Textcolor = System.Drawing.Color.White
        Me.bntProcesos.TextFont = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'pnlCatalogos
        '
        Me.pnlCatalogos.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.pnlCatalogos.Controls.Add(Me.bntUsuarios)
        Me.pnlCatalogos.Controls.Add(Me.btnConductores)
        Me.pnlCatalogos.Controls.Add(Me.bntConductores)
        Me.pnlCatalogos.Controls.Add(Me.bntTiposLic)
        Me.LogoAnimation.SetDecoration(Me.pnlCatalogos, BunifuAnimatorNS.DecorationType.None)
        Me.PanelAnimation.SetDecoration(Me.pnlCatalogos, BunifuAnimatorNS.DecorationType.None)
        Me.SubMenus.SetDecoration(Me.pnlCatalogos, BunifuAnimatorNS.DecorationType.None)
        Me.pnlCatalogos.Location = New System.Drawing.Point(7, 119)
        Me.pnlCatalogos.Name = "pnlCatalogos"
        Me.pnlCatalogos.Size = New System.Drawing.Size(243, 111)
        Me.pnlCatalogos.TabIndex = 17
        '
        'bntUsuarios
        '
        Me.bntUsuarios.Activecolor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.bntUsuarios.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.bntUsuarios.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.bntUsuarios.BorderRadius = 0
        Me.bntUsuarios.ButtonText = "  &Usuarios"
        Me.bntUsuarios.Cursor = System.Windows.Forms.Cursors.Hand
        Me.SubMenus.SetDecoration(Me.bntUsuarios, BunifuAnimatorNS.DecorationType.None)
        Me.PanelAnimation.SetDecoration(Me.bntUsuarios, BunifuAnimatorNS.DecorationType.None)
        Me.LogoAnimation.SetDecoration(Me.bntUsuarios, BunifuAnimatorNS.DecorationType.None)
        Me.bntUsuarios.DisabledColor = System.Drawing.Color.Gray
        Me.bntUsuarios.Iconcolor = System.Drawing.Color.Transparent
        Me.bntUsuarios.Iconimage = CType(resources.GetObject("bntUsuarios.Iconimage"), System.Drawing.Image)
        Me.bntUsuarios.Iconimage_right = Nothing
        Me.bntUsuarios.Iconimage_right_Selected = Nothing
        Me.bntUsuarios.Iconimage_Selected = Nothing
        Me.bntUsuarios.IconMarginLeft = 0
        Me.bntUsuarios.IconMarginRight = 0
        Me.bntUsuarios.IconRightVisible = True
        Me.bntUsuarios.IconRightZoom = 0R
        Me.bntUsuarios.IconVisible = True
        Me.bntUsuarios.IconZoom = 45.0R
        Me.bntUsuarios.IsTab = False
        Me.bntUsuarios.Location = New System.Drawing.Point(3, 80)
        Me.bntUsuarios.Name = "bntUsuarios"
        Me.bntUsuarios.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.bntUsuarios.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.bntUsuarios.OnHoverTextColor = System.Drawing.Color.White
        Me.bntUsuarios.selected = False
        Me.bntUsuarios.Size = New System.Drawing.Size(186, 40)
        Me.bntUsuarios.TabIndex = 17
        Me.bntUsuarios.Text = "  &Usuarios"
        Me.bntUsuarios.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bntUsuarios.Textcolor = System.Drawing.Color.White
        Me.bntUsuarios.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'btnConductores
        '
        Me.btnConductores.Activecolor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.btnConductores.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnConductores.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnConductores.BorderRadius = 0
        Me.btnConductores.ButtonText = "  &Conductores"
        Me.btnConductores.Cursor = System.Windows.Forms.Cursors.Hand
        Me.SubMenus.SetDecoration(Me.btnConductores, BunifuAnimatorNS.DecorationType.None)
        Me.PanelAnimation.SetDecoration(Me.btnConductores, BunifuAnimatorNS.DecorationType.None)
        Me.LogoAnimation.SetDecoration(Me.btnConductores, BunifuAnimatorNS.DecorationType.None)
        Me.btnConductores.DisabledColor = System.Drawing.Color.Gray
        Me.btnConductores.Iconcolor = System.Drawing.Color.Transparent
        Me.btnConductores.Iconimage = CType(resources.GetObject("btnConductores.Iconimage"), System.Drawing.Image)
        Me.btnConductores.Iconimage_right = Nothing
        Me.btnConductores.Iconimage_right_Selected = Nothing
        Me.btnConductores.Iconimage_Selected = Nothing
        Me.btnConductores.IconMarginLeft = 0
        Me.btnConductores.IconMarginRight = 0
        Me.btnConductores.IconRightVisible = True
        Me.btnConductores.IconRightZoom = 0R
        Me.btnConductores.IconVisible = True
        Me.btnConductores.IconZoom = 45.0R
        Me.btnConductores.IsTab = False
        Me.btnConductores.Location = New System.Drawing.Point(3, 41)
        Me.btnConductores.Name = "btnConductores"
        Me.btnConductores.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnConductores.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.btnConductores.OnHoverTextColor = System.Drawing.Color.White
        Me.btnConductores.selected = False
        Me.btnConductores.Size = New System.Drawing.Size(186, 40)
        Me.btnConductores.TabIndex = 15
        Me.btnConductores.Text = "  &Conductores"
        Me.btnConductores.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnConductores.Textcolor = System.Drawing.Color.White
        Me.btnConductores.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'bntConductores
        '
        Me.bntConductores.Activecolor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.bntConductores.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.bntConductores.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.bntConductores.BorderRadius = 0
        Me.bntConductores.ButtonText = "  C&onductores"
        Me.bntConductores.Cursor = System.Windows.Forms.Cursors.Hand
        Me.SubMenus.SetDecoration(Me.bntConductores, BunifuAnimatorNS.DecorationType.None)
        Me.PanelAnimation.SetDecoration(Me.bntConductores, BunifuAnimatorNS.DecorationType.None)
        Me.LogoAnimation.SetDecoration(Me.bntConductores, BunifuAnimatorNS.DecorationType.None)
        Me.bntConductores.DisabledColor = System.Drawing.Color.Gray
        Me.bntConductores.Iconcolor = System.Drawing.Color.Transparent
        Me.bntConductores.Iconimage = CType(resources.GetObject("bntConductores.Iconimage"), System.Drawing.Image)
        Me.bntConductores.Iconimage_right = Nothing
        Me.bntConductores.Iconimage_right_Selected = Nothing
        Me.bntConductores.Iconimage_Selected = Nothing
        Me.bntConductores.IconMarginLeft = 0
        Me.bntConductores.IconMarginRight = 0
        Me.bntConductores.IconRightVisible = True
        Me.bntConductores.IconRightZoom = 0R
        Me.bntConductores.IconVisible = True
        Me.bntConductores.IconZoom = 45.0R
        Me.bntConductores.IsTab = False
        Me.bntConductores.Location = New System.Drawing.Point(3, 46)
        Me.bntConductores.Name = "bntConductores"
        Me.bntConductores.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.bntConductores.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.bntConductores.OnHoverTextColor = System.Drawing.Color.White
        Me.bntConductores.selected = False
        Me.bntConductores.Size = New System.Drawing.Size(186, 40)
        Me.bntConductores.TabIndex = 16
        Me.bntConductores.Text = "  C&onductores"
        Me.bntConductores.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bntConductores.Textcolor = System.Drawing.Color.White
        Me.bntConductores.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'bntTiposLic
        '
        Me.bntTiposLic.Activecolor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.bntTiposLic.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.bntTiposLic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.bntTiposLic.BorderRadius = 0
        Me.bntTiposLic.ButtonText = "  &Tipos Licencias"
        Me.bntTiposLic.Cursor = System.Windows.Forms.Cursors.Hand
        Me.SubMenus.SetDecoration(Me.bntTiposLic, BunifuAnimatorNS.DecorationType.None)
        Me.PanelAnimation.SetDecoration(Me.bntTiposLic, BunifuAnimatorNS.DecorationType.None)
        Me.LogoAnimation.SetDecoration(Me.bntTiposLic, BunifuAnimatorNS.DecorationType.None)
        Me.bntTiposLic.DisabledColor = System.Drawing.Color.Gray
        Me.bntTiposLic.Iconcolor = System.Drawing.Color.Transparent
        Me.bntTiposLic.Iconimage = CType(resources.GetObject("bntTiposLic.Iconimage"), System.Drawing.Image)
        Me.bntTiposLic.Iconimage_right = Nothing
        Me.bntTiposLic.Iconimage_right_Selected = Nothing
        Me.bntTiposLic.Iconimage_Selected = Nothing
        Me.bntTiposLic.IconMarginLeft = 0
        Me.bntTiposLic.IconMarginRight = 0
        Me.bntTiposLic.IconRightVisible = True
        Me.bntTiposLic.IconRightZoom = 0R
        Me.bntTiposLic.IconVisible = True
        Me.bntTiposLic.IconZoom = 45.0R
        Me.bntTiposLic.IsTab = False
        Me.bntTiposLic.Location = New System.Drawing.Point(3, 3)
        Me.bntTiposLic.Name = "bntTiposLic"
        Me.bntTiposLic.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.bntTiposLic.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.bntTiposLic.OnHoverTextColor = System.Drawing.Color.White
        Me.bntTiposLic.selected = False
        Me.bntTiposLic.Size = New System.Drawing.Size(186, 40)
        Me.bntTiposLic.TabIndex = 15
        Me.bntTiposLic.Text = "  &Tipos Licencias"
        Me.bntTiposLic.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bntTiposLic.Textcolor = System.Drawing.Color.White
        Me.bntTiposLic.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'Logo
        '
        Me.SubMenus.SetDecoration(Me.Logo, BunifuAnimatorNS.DecorationType.None)
        Me.PanelAnimation.SetDecoration(Me.Logo, BunifuAnimatorNS.DecorationType.None)
        Me.LogoAnimation.SetDecoration(Me.Logo, BunifuAnimatorNS.DecorationType.None)
        Me.Logo.Image = CType(resources.GetObject("Logo.Image"), System.Drawing.Image)
        Me.Logo.Location = New System.Drawing.Point(3, 4)
        Me.Logo.Name = "Logo"
        Me.Logo.Size = New System.Drawing.Size(133, 73)
        Me.Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Logo.TabIndex = 14
        Me.Logo.TabStop = False
        '
        'btnSalir
        '
        Me.btnSalir.Activecolor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.btnSalir.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnSalir.BorderRadius = 0
        Me.btnSalir.ButtonText = "  &Salir"
        Me.btnSalir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.SubMenus.SetDecoration(Me.btnSalir, BunifuAnimatorNS.DecorationType.None)
        Me.PanelAnimation.SetDecoration(Me.btnSalir, BunifuAnimatorNS.DecorationType.None)
        Me.LogoAnimation.SetDecoration(Me.btnSalir, BunifuAnimatorNS.DecorationType.None)
        Me.btnSalir.DisabledColor = System.Drawing.Color.Gray
        Me.btnSalir.ForeColor = System.Drawing.Color.Gray
        Me.btnSalir.Iconcolor = System.Drawing.Color.Transparent
        Me.btnSalir.Iconimage = CType(resources.GetObject("btnSalir.Iconimage"), System.Drawing.Image)
        Me.btnSalir.Iconimage_right = Nothing
        Me.btnSalir.Iconimage_right_Selected = Nothing
        Me.btnSalir.Iconimage_Selected = Nothing
        Me.btnSalir.IconMarginLeft = 0
        Me.btnSalir.IconMarginRight = 0
        Me.btnSalir.IconRightVisible = True
        Me.btnSalir.IconRightZoom = 0R
        Me.btnSalir.IconVisible = True
        Me.btnSalir.IconZoom = 45.0R
        Me.btnSalir.IsTab = True
        Me.btnSalir.Location = New System.Drawing.Point(5, 424)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnSalir.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.btnSalir.OnHoverTextColor = System.Drawing.Color.White
        Me.btnSalir.selected = False
        Me.btnSalir.Size = New System.Drawing.Size(248, 42)
        Me.btnSalir.TabIndex = 13
        Me.btnSalir.Text = "  &Salir"
        Me.btnSalir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSalir.Textcolor = System.Drawing.Color.White
        Me.btnSalir.TextFont = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'btnReportes
        '
        Me.btnReportes.Activecolor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.btnReportes.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnReportes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnReportes.BorderRadius = 0
        Me.btnReportes.ButtonText = " &Reportes"
        Me.btnReportes.Cursor = System.Windows.Forms.Cursors.Hand
        Me.SubMenus.SetDecoration(Me.btnReportes, BunifuAnimatorNS.DecorationType.None)
        Me.PanelAnimation.SetDecoration(Me.btnReportes, BunifuAnimatorNS.DecorationType.None)
        Me.LogoAnimation.SetDecoration(Me.btnReportes, BunifuAnimatorNS.DecorationType.None)
        Me.btnReportes.DisabledColor = System.Drawing.Color.Gray
        Me.btnReportes.ForeColor = System.Drawing.Color.Gray
        Me.btnReportes.Iconcolor = System.Drawing.Color.Transparent
        Me.btnReportes.Iconimage = CType(resources.GetObject("btnReportes.Iconimage"), System.Drawing.Image)
        Me.btnReportes.Iconimage_right = CType(resources.GetObject("btnReportes.Iconimage_right"), System.Drawing.Image)
        Me.btnReportes.Iconimage_right_Selected = Nothing
        Me.btnReportes.Iconimage_Selected = Nothing
        Me.btnReportes.IconMarginLeft = 0
        Me.btnReportes.IconMarginRight = 0
        Me.btnReportes.IconRightVisible = True
        Me.btnReportes.IconRightZoom = 0R
        Me.btnReportes.IconVisible = True
        Me.btnReportes.IconZoom = 40.0R
        Me.btnReportes.IsTab = True
        Me.btnReportes.Location = New System.Drawing.Point(6, 365)
        Me.btnReportes.Name = "btnReportes"
        Me.btnReportes.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnReportes.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.btnReportes.OnHoverTextColor = System.Drawing.Color.White
        Me.btnReportes.selected = False
        Me.btnReportes.Size = New System.Drawing.Size(247, 42)
        Me.btnReportes.TabIndex = 12
        Me.btnReportes.Text = " &Reportes"
        Me.btnReportes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnReportes.Textcolor = System.Drawing.Color.White
        Me.btnReportes.TextFont = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'bntCatalogos
        '
        Me.bntCatalogos.Activecolor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.bntCatalogos.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.bntCatalogos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.bntCatalogos.BorderRadius = 0
        Me.bntCatalogos.ButtonText = "  &Catálogos Datos"
        Me.bntCatalogos.Cursor = System.Windows.Forms.Cursors.Hand
        Me.SubMenus.SetDecoration(Me.bntCatalogos, BunifuAnimatorNS.DecorationType.None)
        Me.PanelAnimation.SetDecoration(Me.bntCatalogos, BunifuAnimatorNS.DecorationType.None)
        Me.LogoAnimation.SetDecoration(Me.bntCatalogos, BunifuAnimatorNS.DecorationType.None)
        Me.bntCatalogos.DisabledColor = System.Drawing.Color.Gray
        Me.bntCatalogos.ForeColor = System.Drawing.Color.Gray
        Me.bntCatalogos.Iconcolor = System.Drawing.Color.Transparent
        Me.bntCatalogos.Iconimage = CType(resources.GetObject("bntCatalogos.Iconimage"), System.Drawing.Image)
        Me.bntCatalogos.Iconimage_right = CType(resources.GetObject("bntCatalogos.Iconimage_right"), System.Drawing.Image)
        Me.bntCatalogos.Iconimage_right_Selected = Nothing
        Me.bntCatalogos.Iconimage_Selected = Nothing
        Me.bntCatalogos.IconMarginLeft = 0
        Me.bntCatalogos.IconMarginRight = 0
        Me.bntCatalogos.IconRightVisible = True
        Me.bntCatalogos.IconRightZoom = 0R
        Me.bntCatalogos.IconVisible = True
        Me.bntCatalogos.IconZoom = 40.0R
        Me.bntCatalogos.IsTab = True
        Me.bntCatalogos.Location = New System.Drawing.Point(3, 83)
        Me.bntCatalogos.Name = "bntCatalogos"
        Me.bntCatalogos.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.bntCatalogos.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.bntCatalogos.OnHoverTextColor = System.Drawing.Color.White
        Me.bntCatalogos.selected = False
        Me.bntCatalogos.Size = New System.Drawing.Size(250, 42)
        Me.bntCatalogos.TabIndex = 9
        Me.bntCatalogos.Text = "  &Catálogos Datos"
        Me.bntCatalogos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bntCatalogos.Textcolor = System.Drawing.Color.White
        Me.bntCatalogos.TextFont = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Conductores1)
        Me.Panel2.Controls.Add(Me.SlideMenu)
        Me.LogoAnimation.SetDecoration(Me.Panel2, BunifuAnimatorNS.DecorationType.None)
        Me.PanelAnimation.SetDecoration(Me.Panel2, BunifuAnimatorNS.DecorationType.None)
        Me.SubMenus.SetDecoration(Me.Panel2, BunifuAnimatorNS.DecorationType.None)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 42)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1191, 629)
        Me.Panel2.TabIndex = 2
        '
        'LogoAnimation
        '
        Me.LogoAnimation.AnimationType = BunifuAnimatorNS.AnimationType.ScaleAndRotate
        Me.LogoAnimation.Cursor = Nothing
        Animation16.AnimateOnlyDifferences = True
        Animation16.BlindCoeff = CType(resources.GetObject("Animation16.BlindCoeff"), System.Drawing.PointF)
        Animation16.LeafCoeff = 0!
        Animation16.MaxTime = 1.0!
        Animation16.MinTime = 0!
        Animation16.MosaicCoeff = CType(resources.GetObject("Animation16.MosaicCoeff"), System.Drawing.PointF)
        Animation16.MosaicShift = CType(resources.GetObject("Animation16.MosaicShift"), System.Drawing.PointF)
        Animation16.MosaicSize = 0
        Animation16.Padding = New System.Windows.Forms.Padding(30)
        Animation16.RotateCoeff = 0.5!
        Animation16.RotateLimit = 0.2!
        Animation16.ScaleCoeff = CType(resources.GetObject("Animation16.ScaleCoeff"), System.Drawing.PointF)
        Animation16.SlideCoeff = CType(resources.GetObject("Animation16.SlideCoeff"), System.Drawing.PointF)
        Animation16.TimeCoeff = 0!
        Animation16.TransparencyCoeff = 0!
        Me.LogoAnimation.DefaultAnimation = Animation16
        '
        'PanelAnimation
        '
        Me.PanelAnimation.AnimationType = BunifuAnimatorNS.AnimationType.HorizSlide
        Me.PanelAnimation.Cursor = Nothing
        Animation17.AnimateOnlyDifferences = True
        Animation17.BlindCoeff = CType(resources.GetObject("Animation17.BlindCoeff"), System.Drawing.PointF)
        Animation17.LeafCoeff = 0!
        Animation17.MaxTime = 1.0!
        Animation17.MinTime = 0!
        Animation17.MosaicCoeff = CType(resources.GetObject("Animation17.MosaicCoeff"), System.Drawing.PointF)
        Animation17.MosaicShift = CType(resources.GetObject("Animation17.MosaicShift"), System.Drawing.PointF)
        Animation17.MosaicSize = 0
        Animation17.Padding = New System.Windows.Forms.Padding(0)
        Animation17.RotateCoeff = 0!
        Animation17.RotateLimit = 0!
        Animation17.ScaleCoeff = CType(resources.GetObject("Animation17.ScaleCoeff"), System.Drawing.PointF)
        Animation17.SlideCoeff = CType(resources.GetObject("Animation17.SlideCoeff"), System.Drawing.PointF)
        Animation17.TimeCoeff = 0!
        Animation17.TransparencyCoeff = 0!
        Me.PanelAnimation.DefaultAnimation = Animation17
        '
        'SubMenus
        '
        Me.SubMenus.AnimationType = BunifuAnimatorNS.AnimationType.HorizBlind
        Me.SubMenus.Cursor = Nothing
        Animation18.AnimateOnlyDifferences = True
        Animation18.BlindCoeff = CType(resources.GetObject("Animation18.BlindCoeff"), System.Drawing.PointF)
        Animation18.LeafCoeff = 0!
        Animation18.MaxTime = 1.0!
        Animation18.MinTime = 0!
        Animation18.MosaicCoeff = CType(resources.GetObject("Animation18.MosaicCoeff"), System.Drawing.PointF)
        Animation18.MosaicShift = CType(resources.GetObject("Animation18.MosaicShift"), System.Drawing.PointF)
        Animation18.MosaicSize = 0
        Animation18.Padding = New System.Windows.Forms.Padding(0)
        Animation18.RotateCoeff = 0!
        Animation18.RotateLimit = 0!
        Animation18.ScaleCoeff = CType(resources.GetObject("Animation18.ScaleCoeff"), System.Drawing.PointF)
        Animation18.SlideCoeff = CType(resources.GetObject("Animation18.SlideCoeff"), System.Drawing.PointF)
        Animation18.TimeCoeff = 0!
        Animation18.TransparencyCoeff = 0!
        Me.SubMenus.DefaultAnimation = Animation18
        '
        'btnLic
        '
        Me.btnLic.Activecolor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.btnLic.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnLic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnLic.BorderRadius = 0
        Me.btnLic.ButtonText = "  &Licencias"
        Me.btnLic.Cursor = System.Windows.Forms.Cursors.Hand
        Me.SubMenus.SetDecoration(Me.btnLic, BunifuAnimatorNS.DecorationType.None)
        Me.PanelAnimation.SetDecoration(Me.btnLic, BunifuAnimatorNS.DecorationType.None)
        Me.LogoAnimation.SetDecoration(Me.btnLic, BunifuAnimatorNS.DecorationType.None)
        Me.btnLic.DisabledColor = System.Drawing.Color.Gray
        Me.btnLic.Iconcolor = System.Drawing.Color.Transparent
        Me.btnLic.Iconimage = CType(resources.GetObject("btnLic.Iconimage"), System.Drawing.Image)
        Me.btnLic.Iconimage_right = Nothing
        Me.btnLic.Iconimage_right_Selected = Nothing
        Me.btnLic.Iconimage_Selected = Nothing
        Me.btnLic.IconMarginLeft = 0
        Me.btnLic.IconMarginRight = 0
        Me.btnLic.IconRightVisible = True
        Me.btnLic.IconRightZoom = 0R
        Me.btnLic.IconVisible = True
        Me.btnLic.IconZoom = 45.0R
        Me.btnLic.IsTab = False
        Me.btnLic.Location = New System.Drawing.Point(3, 3)
        Me.btnLic.Name = "btnLic"
        Me.btnLic.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnLic.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.btnLic.OnHoverTextColor = System.Drawing.Color.White
        Me.btnLic.selected = False
        Me.btnLic.Size = New System.Drawing.Size(186, 40)
        Me.btnLic.TabIndex = 15
        Me.btnLic.Text = "  &Licencias"
        Me.btnLic.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnLic.Textcolor = System.Drawing.Color.White
        Me.btnLic.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'BunifuFlatButton4
        '
        Me.BunifuFlatButton4.Activecolor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.BunifuFlatButton4.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.BunifuFlatButton4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuFlatButton4.BorderRadius = 0
        Me.BunifuFlatButton4.ButtonText = "  C&onductores"
        Me.BunifuFlatButton4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.SubMenus.SetDecoration(Me.BunifuFlatButton4, BunifuAnimatorNS.DecorationType.None)
        Me.PanelAnimation.SetDecoration(Me.BunifuFlatButton4, BunifuAnimatorNS.DecorationType.None)
        Me.LogoAnimation.SetDecoration(Me.BunifuFlatButton4, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuFlatButton4.DisabledColor = System.Drawing.Color.Gray
        Me.BunifuFlatButton4.Iconcolor = System.Drawing.Color.Transparent
        Me.BunifuFlatButton4.Iconimage = CType(resources.GetObject("BunifuFlatButton4.Iconimage"), System.Drawing.Image)
        Me.BunifuFlatButton4.Iconimage_right = Nothing
        Me.BunifuFlatButton4.Iconimage_right_Selected = Nothing
        Me.BunifuFlatButton4.Iconimage_Selected = Nothing
        Me.BunifuFlatButton4.IconMarginLeft = 0
        Me.BunifuFlatButton4.IconMarginRight = 0
        Me.BunifuFlatButton4.IconRightVisible = True
        Me.BunifuFlatButton4.IconRightZoom = 0R
        Me.BunifuFlatButton4.IconVisible = True
        Me.BunifuFlatButton4.IconZoom = 45.0R
        Me.BunifuFlatButton4.IsTab = False
        Me.BunifuFlatButton4.Location = New System.Drawing.Point(3, 46)
        Me.BunifuFlatButton4.Name = "BunifuFlatButton4"
        Me.BunifuFlatButton4.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.BunifuFlatButton4.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.BunifuFlatButton4.OnHoverTextColor = System.Drawing.Color.White
        Me.BunifuFlatButton4.selected = False
        Me.BunifuFlatButton4.Size = New System.Drawing.Size(186, 40)
        Me.BunifuFlatButton4.TabIndex = 16
        Me.BunifuFlatButton4.Text = "  C&onductores"
        Me.BunifuFlatButton4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BunifuFlatButton4.Textcolor = System.Drawing.Color.White
        Me.BunifuFlatButton4.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'btnMultas
        '
        Me.btnMultas.Activecolor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.btnMultas.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnMultas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnMultas.BorderRadius = 0
        Me.btnMultas.ButtonText = "  &Multas"
        Me.btnMultas.Cursor = System.Windows.Forms.Cursors.Hand
        Me.SubMenus.SetDecoration(Me.btnMultas, BunifuAnimatorNS.DecorationType.None)
        Me.PanelAnimation.SetDecoration(Me.btnMultas, BunifuAnimatorNS.DecorationType.None)
        Me.LogoAnimation.SetDecoration(Me.btnMultas, BunifuAnimatorNS.DecorationType.None)
        Me.btnMultas.DisabledColor = System.Drawing.Color.Gray
        Me.btnMultas.Iconcolor = System.Drawing.Color.Transparent
        Me.btnMultas.Iconimage = CType(resources.GetObject("btnMultas.Iconimage"), System.Drawing.Image)
        Me.btnMultas.Iconimage_right = Nothing
        Me.btnMultas.Iconimage_right_Selected = Nothing
        Me.btnMultas.Iconimage_Selected = Nothing
        Me.btnMultas.IconMarginLeft = 0
        Me.btnMultas.IconMarginRight = 0
        Me.btnMultas.IconRightVisible = True
        Me.btnMultas.IconRightZoom = 0R
        Me.btnMultas.IconVisible = True
        Me.btnMultas.IconZoom = 45.0R
        Me.btnMultas.IsTab = False
        Me.btnMultas.Location = New System.Drawing.Point(3, 41)
        Me.btnMultas.Name = "btnMultas"
        Me.btnMultas.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnMultas.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.btnMultas.OnHoverTextColor = System.Drawing.Color.White
        Me.btnMultas.selected = False
        Me.btnMultas.Size = New System.Drawing.Size(186, 40)
        Me.btnMultas.TabIndex = 15
        Me.btnMultas.Text = "  &Multas"
        Me.btnMultas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnMultas.Textcolor = System.Drawing.Color.White
        Me.btnMultas.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'pnlProcesos
        '
        Me.pnlProcesos.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.pnlProcesos.Controls.Add(Me.btnMultas)
        Me.pnlProcesos.Controls.Add(Me.BunifuFlatButton4)
        Me.pnlProcesos.Controls.Add(Me.btnLic)
        Me.LogoAnimation.SetDecoration(Me.pnlProcesos, BunifuAnimatorNS.DecorationType.None)
        Me.PanelAnimation.SetDecoration(Me.pnlProcesos, BunifuAnimatorNS.DecorationType.None)
        Me.SubMenus.SetDecoration(Me.pnlProcesos, BunifuAnimatorNS.DecorationType.None)
        Me.pnlProcesos.Location = New System.Drawing.Point(12, 282)
        Me.pnlProcesos.Name = "pnlProcesos"
        Me.pnlProcesos.Size = New System.Drawing.Size(243, 77)
        Me.pnlProcesos.TabIndex = 18
        '
        'Conductores1
        '
        Me.Conductores1.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.SubMenus.SetDecoration(Me.Conductores1, BunifuAnimatorNS.DecorationType.None)
        Me.PanelAnimation.SetDecoration(Me.Conductores1, BunifuAnimatorNS.DecorationType.None)
        Me.LogoAnimation.SetDecoration(Me.Conductores1, BunifuAnimatorNS.DecorationType.None)
        Me.Conductores1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Conductores1.Location = New System.Drawing.Point(258, 0)
        Me.Conductores1.Name = "Conductores1"
        Me.Conductores1.Size = New System.Drawing.Size(933, 629)
        Me.Conductores1.TabIndex = 1
        '
        'Master
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1191, 671)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.header)
        Me.PanelAnimation.SetDecoration(Me, BunifuAnimatorNS.DecorationType.None)
        Me.LogoAnimation.SetDecoration(Me, BunifuAnimatorNS.DecorationType.None)
        Me.SubMenus.SetDecoration(Me, BunifuAnimatorNS.DecorationType.None)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimizeBox = False
        Me.Name = "Master"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Master"
        Me.header.ResumeLayout(False)
        Me.header.PerformLayout()
        CType(Me.BunifuImageButton5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BunifuImageButton4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BunifuImageButton2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bntMenu, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BunifuImageButton3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SlideMenu.ResumeLayout(False)
        Me.SlideMenu.PerformLayout()
        Me.pnlCatalogos.ResumeLayout(False)
        CType(Me.Logo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.pnlProcesos.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BunifuElipse1 As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents header As Panel
    Friend WithEvents BunifuCustomLabel1 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents BunifuImageButton2 As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents BunifuDragControl1 As Bunifu.Framework.UI.BunifuDragControl
    Friend WithEvents BunifuImageButton5 As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents BunifuImageButton4 As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents SlideMenu As Panel
    Friend WithEvents bntCatalogos As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents BunifuImageButton3 As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents bntMenu As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents bntProcesos As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents btnSalir As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents btnReportes As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents Panel2 As Panel
    Friend WithEvents LogoAnimation As BunifuAnimatorNS.BunifuTransition
    Friend WithEvents PanelAnimation As BunifuAnimatorNS.BunifuTransition
    Friend WithEvents Logo As PictureBox
    Friend WithEvents pnlCatalogos As Panel
    Friend WithEvents bntUsuarios As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents bntConductores As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents bntTiposLic As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents btnConductores As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents lblEstado As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents SubMenus As BunifuAnimatorNS.BunifuTransition
    Friend WithEvents pnlProcesos As Panel
    Friend WithEvents btnMultas As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents BunifuFlatButton4 As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents btnLic As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents Conductores1 As Conductores
End Class
