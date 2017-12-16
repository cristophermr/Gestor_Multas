<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Conductores
    Inherits System.Windows.Forms.UserControl

    'UserControl reemplaza a Dispose para limpiar la lista de componentes.
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Conductores))
        Me.pnlAcciones = New System.Windows.Forms.Panel()
        Me.BunifuImageButton1 = New Bunifu.Framework.UI.BunifuImageButton()
        Me.btnedit = New Bunifu.Framework.UI.BunifuImageButton()
        Me.btndelete = New Bunifu.Framework.UI.BunifuImageButton()
        Me.btnAdd = New Bunifu.Framework.UI.BunifuImageButton()
        Me.txtBuscar = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.btnBuscar = New Bunifu.Framework.UI.BunifuImageButton()
        Me.pnlContenido = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.dtpNacimiento = New System.Windows.Forms.DateTimePicker()
        Me.txtObservaciones = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.txtDireccion = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuCustomLabel10 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuCustomLabel9 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.labeltel = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.txtTel_Cel = New WindowsFormsControlLibrary1.BunifuCustomTextbox()
        Me.BunifuCustomLabel6 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.txtTel_Casa = New WindowsFormsControlLibrary1.BunifuCustomTextbox()
        Me.BunifuCustomLabel7 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.txtNombre = New WindowsFormsControlLibrary1.BunifuCustomTextbox()
        Me.BunifuCustomLabel8 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.txtCedul = New WindowsFormsControlLibrary1.BunifuCustomTextbox()
        Me.BunifuCustomLabel4 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuCustomTextbox3 = New WindowsFormsControlLibrary1.BunifuCustomTextbox()
        Me.BunifuCustomLabel3 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuCustomTextbox2 = New WindowsFormsControlLibrary1.BunifuCustomTextbox()
        Me.BunifuCustomLabel2 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuCustomTextbox1 = New WindowsFormsControlLibrary1.BunifuCustomTextbox()
        Me.BunifuCustomLabel1 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.txtCedula = New WindowsFormsControlLibrary1.BunifuCustomTextbox()
        Me.ConductoresENBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.txtEmail = New WindowsFormsControlLibrary1.BunifuCustomTextbox()
        Me.BunifuCustomTextbox4 = New WindowsFormsControlLibrary1.BunifuCustomTextbox()
        Me.BunifuCustomTextbox5 = New WindowsFormsControlLibrary1.BunifuCustomTextbox()
        Me.grbxActivo = New System.Windows.Forms.GroupBox()
        Me.rdbtnSi = New System.Windows.Forms.RadioButton()
        Me.rdbtnNo = New System.Windows.Forms.RadioButton()
        Me.pnlAcciones.SuspendLayout()
        CType(Me.BunifuImageButton1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnedit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btndelete, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnAdd, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnBuscar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlContenido.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.ConductoresENBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grbxActivo.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlAcciones
        '
        Me.pnlAcciones.Controls.Add(Me.BunifuImageButton1)
        Me.pnlAcciones.Controls.Add(Me.btnedit)
        Me.pnlAcciones.Controls.Add(Me.btndelete)
        Me.pnlAcciones.Controls.Add(Me.btnAdd)
        Me.pnlAcciones.Controls.Add(Me.txtBuscar)
        Me.pnlAcciones.Controls.Add(Me.btnBuscar)
        Me.pnlAcciones.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlAcciones.Location = New System.Drawing.Point(0, 0)
        Me.pnlAcciones.Name = "pnlAcciones"
        Me.pnlAcciones.Size = New System.Drawing.Size(810, 38)
        Me.pnlAcciones.TabIndex = 0
        '
        'BunifuImageButton1
        '
        Me.BunifuImageButton1.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.BunifuImageButton1.Image = CType(resources.GetObject("BunifuImageButton1.Image"), System.Drawing.Image)
        Me.BunifuImageButton1.ImageActive = Nothing
        Me.BunifuImageButton1.InitialImage = CType(resources.GetObject("BunifuImageButton1.InitialImage"), System.Drawing.Image)
        Me.BunifuImageButton1.Location = New System.Drawing.Point(589, 5)
        Me.BunifuImageButton1.Name = "BunifuImageButton1"
        Me.BunifuImageButton1.Size = New System.Drawing.Size(50, 29)
        Me.BunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.BunifuImageButton1.TabIndex = 5
        Me.BunifuImageButton1.TabStop = False
        Me.BunifuImageButton1.Zoom = 10
        '
        'btnedit
        '
        Me.btnedit.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.btnedit.Image = CType(resources.GetObject("btnedit.Image"), System.Drawing.Image)
        Me.btnedit.ImageActive = Nothing
        Me.btnedit.InitialImage = CType(resources.GetObject("btnedit.InitialImage"), System.Drawing.Image)
        Me.btnedit.Location = New System.Drawing.Point(701, 6)
        Me.btnedit.Name = "btnedit"
        Me.btnedit.Size = New System.Drawing.Size(50, 29)
        Me.btnedit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnedit.TabIndex = 4
        Me.btnedit.TabStop = False
        Me.btnedit.Zoom = 10
        '
        'btndelete
        '
        Me.btndelete.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.btndelete.Image = CType(resources.GetObject("btndelete.Image"), System.Drawing.Image)
        Me.btndelete.ImageActive = Nothing
        Me.btndelete.InitialImage = CType(resources.GetObject("btndelete.InitialImage"), System.Drawing.Image)
        Me.btndelete.Location = New System.Drawing.Point(757, 6)
        Me.btndelete.Name = "btndelete"
        Me.btndelete.Size = New System.Drawing.Size(50, 29)
        Me.btndelete.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btndelete.TabIndex = 3
        Me.btndelete.TabStop = False
        Me.btndelete.Zoom = 10
        '
        'btnAdd
        '
        Me.btnAdd.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.btnAdd.Image = CType(resources.GetObject("btnAdd.Image"), System.Drawing.Image)
        Me.btnAdd.ImageActive = Nothing
        Me.btnAdd.InitialImage = CType(resources.GetObject("btnAdd.InitialImage"), System.Drawing.Image)
        Me.btnAdd.Location = New System.Drawing.Point(645, 6)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(50, 29)
        Me.btnAdd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnAdd.TabIndex = 2
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
        Me.txtBuscar.TabIndex = 1
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
        Me.btnBuscar.TabIndex = 0
        Me.btnBuscar.TabStop = False
        Me.btnBuscar.Zoom = 10
        '
        'pnlContenido
        '
        Me.pnlContenido.Controls.Add(Me.Panel1)
        Me.pnlContenido.Controls.Add(Me.BunifuCustomLabel4)
        Me.pnlContenido.Controls.Add(Me.BunifuCustomTextbox3)
        Me.pnlContenido.Controls.Add(Me.BunifuCustomLabel3)
        Me.pnlContenido.Controls.Add(Me.BunifuCustomTextbox2)
        Me.pnlContenido.Controls.Add(Me.BunifuCustomLabel2)
        Me.pnlContenido.Controls.Add(Me.BunifuCustomTextbox1)
        Me.pnlContenido.Controls.Add(Me.BunifuCustomLabel1)
        Me.pnlContenido.Controls.Add(Me.txtCedula)
        Me.pnlContenido.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlContenido.Location = New System.Drawing.Point(0, 38)
        Me.pnlContenido.Name = "pnlContenido"
        Me.pnlContenido.Size = New System.Drawing.Size(810, 480)
        Me.pnlContenido.TabIndex = 1
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.grbxActivo)
        Me.Panel1.Controls.Add(Me.BunifuCustomTextbox5)
        Me.Panel1.Controls.Add(Me.BunifuCustomTextbox4)
        Me.Panel1.Controls.Add(Me.txtEmail)
        Me.Panel1.Controls.Add(Me.dtpNacimiento)
        Me.Panel1.Controls.Add(Me.txtObservaciones)
        Me.Panel1.Controls.Add(Me.txtDireccion)
        Me.Panel1.Controls.Add(Me.BunifuCustomLabel10)
        Me.Panel1.Controls.Add(Me.BunifuCustomLabel9)
        Me.Panel1.Controls.Add(Me.labeltel)
        Me.Panel1.Controls.Add(Me.txtTel_Cel)
        Me.Panel1.Controls.Add(Me.BunifuCustomLabel6)
        Me.Panel1.Controls.Add(Me.txtTel_Casa)
        Me.Panel1.Controls.Add(Me.BunifuCustomLabel7)
        Me.Panel1.Controls.Add(Me.txtNombre)
        Me.Panel1.Controls.Add(Me.BunifuCustomLabel8)
        Me.Panel1.Controls.Add(Me.txtCedul)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(810, 480)
        Me.Panel1.TabIndex = 8
        '
        'dtpNacimiento
        '
        Me.dtpNacimiento.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpNacimiento.Location = New System.Drawing.Point(64, 136)
        Me.dtpNacimiento.Name = "dtpNacimiento"
        Me.dtpNacimiento.Size = New System.Drawing.Size(119, 20)
        Me.dtpNacimiento.TabIndex = 12
        '
        'txtObservaciones
        '
        Me.txtObservaciones.AutoSize = True
        Me.txtObservaciones.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.txtObservaciones.Location = New System.Drawing.Point(61, 282)
        Me.txtObservaciones.Name = "txtObservaciones"
        Me.txtObservaciones.Size = New System.Drawing.Size(78, 13)
        Me.txtObservaciones.TabIndex = 11
        Me.txtObservaciones.Text = "Observaciones"
        '
        'txtDireccion
        '
        Me.txtDireccion.AutoSize = True
        Me.txtDireccion.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.txtDireccion.Location = New System.Drawing.Point(61, 179)
        Me.txtDireccion.Name = "txtDireccion"
        Me.txtDireccion.Size = New System.Drawing.Size(99, 13)
        Me.txtDireccion.TabIndex = 10
        Me.txtDireccion.Text = "Direccion Completa"
        '
        'BunifuCustomLabel10
        '
        Me.BunifuCustomLabel10.AutoSize = True
        Me.BunifuCustomLabel10.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.BunifuCustomLabel10.Location = New System.Drawing.Point(217, 116)
        Me.BunifuCustomLabel10.Name = "BunifuCustomLabel10"
        Me.BunifuCustomLabel10.Size = New System.Drawing.Size(36, 13)
        Me.BunifuCustomLabel10.TabIndex = 9
        Me.BunifuCustomLabel10.Text = "E-Mail"
        '
        'BunifuCustomLabel9
        '
        Me.BunifuCustomLabel9.AutoSize = True
        Me.BunifuCustomLabel9.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.BunifuCustomLabel9.Location = New System.Drawing.Point(61, 119)
        Me.BunifuCustomLabel9.Name = "BunifuCustomLabel9"
        Me.BunifuCustomLabel9.Size = New System.Drawing.Size(108, 13)
        Me.BunifuCustomLabel9.TabIndex = 8
        Me.BunifuCustomLabel9.Text = "Fecha de Nacimiento"
        '
        'labeltel
        '
        Me.labeltel.AutoSize = True
        Me.labeltel.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.labeltel.Location = New System.Drawing.Point(431, 27)
        Me.labeltel.Name = "labeltel"
        Me.labeltel.Size = New System.Drawing.Size(84, 13)
        Me.labeltel.TabIndex = 7
        Me.labeltel.Text = "Telefono Celular"
        '
        'txtTel_Cel
        '
        Me.txtTel_Cel.BorderColor = System.Drawing.Color.SeaGreen
        Me.txtTel_Cel.Location = New System.Drawing.Point(434, 52)
        Me.txtTel_Cel.Name = "txtTel_Cel"
        Me.txtTel_Cel.Size = New System.Drawing.Size(100, 20)
        Me.txtTel_Cel.TabIndex = 6
        '
        'BunifuCustomLabel6
        '
        Me.BunifuCustomLabel6.AutoSize = True
        Me.BunifuCustomLabel6.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.BunifuCustomLabel6.Location = New System.Drawing.Point(560, 27)
        Me.BunifuCustomLabel6.Name = "BunifuCustomLabel6"
        Me.BunifuCustomLabel6.Size = New System.Drawing.Size(76, 13)
        Me.BunifuCustomLabel6.TabIndex = 5
        Me.BunifuCustomLabel6.Text = "Telefono Casa"
        '
        'txtTel_Casa
        '
        Me.txtTel_Casa.BorderColor = System.Drawing.Color.SeaGreen
        Me.txtTel_Casa.Location = New System.Drawing.Point(563, 52)
        Me.txtTel_Casa.Name = "txtTel_Casa"
        Me.txtTel_Casa.Size = New System.Drawing.Size(100, 20)
        Me.txtTel_Casa.TabIndex = 4
        '
        'BunifuCustomLabel7
        '
        Me.BunifuCustomLabel7.AutoSize = True
        Me.BunifuCustomLabel7.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.BunifuCustomLabel7.Location = New System.Drawing.Point(189, 27)
        Me.BunifuCustomLabel7.Name = "BunifuCustomLabel7"
        Me.BunifuCustomLabel7.Size = New System.Drawing.Size(113, 13)
        Me.BunifuCustomLabel7.TabIndex = 3
        Me.BunifuCustomLabel7.Text = "Nombre del Conductor"
        '
        'txtNombre
        '
        Me.txtNombre.BorderColor = System.Drawing.Color.SeaGreen
        Me.txtNombre.Location = New System.Drawing.Point(192, 52)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(208, 20)
        Me.txtNombre.TabIndex = 2
        '
        'BunifuCustomLabel8
        '
        Me.BunifuCustomLabel8.AutoSize = True
        Me.BunifuCustomLabel8.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.BunifuCustomLabel8.Location = New System.Drawing.Point(61, 27)
        Me.BunifuCustomLabel8.Name = "BunifuCustomLabel8"
        Me.BunifuCustomLabel8.Size = New System.Drawing.Size(40, 13)
        Me.BunifuCustomLabel8.TabIndex = 1
        Me.BunifuCustomLabel8.Text = "Cedula"
        '
        'txtCedul
        '
        Me.txtCedul.BorderColor = System.Drawing.Color.SeaGreen
        Me.txtCedul.Location = New System.Drawing.Point(64, 52)
        Me.txtCedul.Name = "txtCedul"
        Me.txtCedul.Size = New System.Drawing.Size(100, 20)
        Me.txtCedul.TabIndex = 0
        '
        'BunifuCustomLabel4
        '
        Me.BunifuCustomLabel4.AutoSize = True
        Me.BunifuCustomLabel4.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.BunifuCustomLabel4.Location = New System.Drawing.Point(431, 27)
        Me.BunifuCustomLabel4.Name = "BunifuCustomLabel4"
        Me.BunifuCustomLabel4.Size = New System.Drawing.Size(40, 13)
        Me.BunifuCustomLabel4.TabIndex = 7
        Me.BunifuCustomLabel4.Text = "Cedula"
        '
        'BunifuCustomTextbox3
        '
        Me.BunifuCustomTextbox3.BorderColor = System.Drawing.Color.SeaGreen
        Me.BunifuCustomTextbox3.Location = New System.Drawing.Point(434, 52)
        Me.BunifuCustomTextbox3.Name = "BunifuCustomTextbox3"
        Me.BunifuCustomTextbox3.Size = New System.Drawing.Size(100, 20)
        Me.BunifuCustomTextbox3.TabIndex = 6
        '
        'BunifuCustomLabel3
        '
        Me.BunifuCustomLabel3.AutoSize = True
        Me.BunifuCustomLabel3.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.BunifuCustomLabel3.Location = New System.Drawing.Point(560, 27)
        Me.BunifuCustomLabel3.Name = "BunifuCustomLabel3"
        Me.BunifuCustomLabel3.Size = New System.Drawing.Size(40, 13)
        Me.BunifuCustomLabel3.TabIndex = 5
        Me.BunifuCustomLabel3.Text = "Cedula"
        '
        'BunifuCustomTextbox2
        '
        Me.BunifuCustomTextbox2.BorderColor = System.Drawing.Color.SeaGreen
        Me.BunifuCustomTextbox2.Location = New System.Drawing.Point(563, 52)
        Me.BunifuCustomTextbox2.Name = "BunifuCustomTextbox2"
        Me.BunifuCustomTextbox2.Size = New System.Drawing.Size(100, 20)
        Me.BunifuCustomTextbox2.TabIndex = 4
        '
        'BunifuCustomLabel2
        '
        Me.BunifuCustomLabel2.AutoSize = True
        Me.BunifuCustomLabel2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.BunifuCustomLabel2.Location = New System.Drawing.Point(189, 27)
        Me.BunifuCustomLabel2.Name = "BunifuCustomLabel2"
        Me.BunifuCustomLabel2.Size = New System.Drawing.Size(113, 13)
        Me.BunifuCustomLabel2.TabIndex = 3
        Me.BunifuCustomLabel2.Text = "Nombre del Conductor"
        '
        'BunifuCustomTextbox1
        '
        Me.BunifuCustomTextbox1.BorderColor = System.Drawing.Color.SeaGreen
        Me.BunifuCustomTextbox1.Location = New System.Drawing.Point(192, 52)
        Me.BunifuCustomTextbox1.Name = "BunifuCustomTextbox1"
        Me.BunifuCustomTextbox1.Size = New System.Drawing.Size(208, 20)
        Me.BunifuCustomTextbox1.TabIndex = 2
        '
        'BunifuCustomLabel1
        '
        Me.BunifuCustomLabel1.AutoSize = True
        Me.BunifuCustomLabel1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.BunifuCustomLabel1.Location = New System.Drawing.Point(61, 27)
        Me.BunifuCustomLabel1.Name = "BunifuCustomLabel1"
        Me.BunifuCustomLabel1.Size = New System.Drawing.Size(40, 13)
        Me.BunifuCustomLabel1.TabIndex = 1
        Me.BunifuCustomLabel1.Text = "Cedula"
        '
        'txtCedula
        '
        Me.txtCedula.BorderColor = System.Drawing.Color.SeaGreen
        Me.txtCedula.Location = New System.Drawing.Point(64, 52)
        Me.txtCedula.Name = "txtCedula"
        Me.txtCedula.Size = New System.Drawing.Size(100, 20)
        Me.txtCedula.TabIndex = 0
        '
        'ConductoresENBindingSource
        '
        Me.ConductoresENBindingSource.DataSource = GetType(_03Entidades.ConductoresEN)
        '
        'txtEmail
        '
        Me.txtEmail.BorderColor = System.Drawing.Color.SeaGreen
        Me.txtEmail.Location = New System.Drawing.Point(220, 136)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(180, 20)
        Me.txtEmail.TabIndex = 13
        '
        'BunifuCustomTextbox4
        '
        Me.BunifuCustomTextbox4.BorderColor = System.Drawing.Color.SeaGreen
        Me.BunifuCustomTextbox4.Location = New System.Drawing.Point(64, 195)
        Me.BunifuCustomTextbox4.Multiline = True
        Me.BunifuCustomTextbox4.Name = "BunifuCustomTextbox4"
        Me.BunifuCustomTextbox4.Size = New System.Drawing.Size(599, 74)
        Me.BunifuCustomTextbox4.TabIndex = 14
        '
        'BunifuCustomTextbox5
        '
        Me.BunifuCustomTextbox5.BorderColor = System.Drawing.Color.SeaGreen
        Me.BunifuCustomTextbox5.Location = New System.Drawing.Point(64, 298)
        Me.BunifuCustomTextbox5.Multiline = True
        Me.BunifuCustomTextbox5.Name = "BunifuCustomTextbox5"
        Me.BunifuCustomTextbox5.Size = New System.Drawing.Size(599, 74)
        Me.BunifuCustomTextbox5.TabIndex = 15
        '
        'grbxActivo
        '
        Me.grbxActivo.Controls.Add(Me.rdbtnNo)
        Me.grbxActivo.Controls.Add(Me.rdbtnSi)
        Me.grbxActivo.ForeColor = System.Drawing.Color.Snow
        Me.grbxActivo.Location = New System.Drawing.Point(465, 103)
        Me.grbxActivo.Name = "grbxActivo"
        Me.grbxActivo.Size = New System.Drawing.Size(161, 67)
        Me.grbxActivo.TabIndex = 16
        Me.grbxActivo.TabStop = False
        Me.grbxActivo.Text = "Se encuentra activo?"
        '
        'rdbtnSi
        '
        Me.rdbtnSi.AutoSize = True
        Me.rdbtnSi.Location = New System.Drawing.Point(46, 21)
        Me.rdbtnSi.Name = "rdbtnSi"
        Me.rdbtnSi.Size = New System.Drawing.Size(34, 17)
        Me.rdbtnSi.TabIndex = 0
        Me.rdbtnSi.Text = "Si"
        Me.rdbtnSi.UseVisualStyleBackColor = True
        '
        'rdbtnNo
        '
        Me.rdbtnNo.AutoSize = True
        Me.rdbtnNo.Checked = True
        Me.rdbtnNo.Location = New System.Drawing.Point(46, 44)
        Me.rdbtnNo.Name = "rdbtnNo"
        Me.rdbtnNo.Size = New System.Drawing.Size(39, 17)
        Me.rdbtnNo.TabIndex = 1
        Me.rdbtnNo.TabStop = True
        Me.rdbtnNo.Text = "No"
        Me.rdbtnNo.UseVisualStyleBackColor = True
        '
        'Conductores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.Controls.Add(Me.pnlContenido)
        Me.Controls.Add(Me.pnlAcciones)
        Me.Name = "Conductores"
        Me.Size = New System.Drawing.Size(810, 518)
        Me.pnlAcciones.ResumeLayout(False)
        CType(Me.BunifuImageButton1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnedit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btndelete, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnAdd, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnBuscar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlContenido.ResumeLayout(False)
        Me.pnlContenido.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.ConductoresENBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grbxActivo.ResumeLayout(False)
        Me.grbxActivo.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnlAcciones As Panel
    Friend WithEvents txtBuscar As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents btnBuscar As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents pnlContenido As Panel
    Friend WithEvents btnedit As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents btndelete As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents btnAdd As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents ConductoresENBindingSource As BindingSource
    Friend WithEvents BunifuCheckbox1 As Bunifu.Framework.UI.BunifuCheckbox
    Friend WithEvents txtCedula As WindowsFormsControlLibrary1.BunifuCustomTextbox
    Friend WithEvents BunifuCustomLabel1 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuImageButton1 As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents BunifuCustomLabel2 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuCustomTextbox1 As WindowsFormsControlLibrary1.BunifuCustomTextbox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents dtpNacimiento As DateTimePicker
    Friend WithEvents txtObservaciones As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents txtDireccion As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuCustomLabel10 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuCustomLabel9 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents labeltel As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents txtTel_Cel As WindowsFormsControlLibrary1.BunifuCustomTextbox
    Friend WithEvents BunifuCustomLabel6 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents txtTel_Casa As WindowsFormsControlLibrary1.BunifuCustomTextbox
    Friend WithEvents BunifuCustomLabel7 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents txtNombre As WindowsFormsControlLibrary1.BunifuCustomTextbox
    Friend WithEvents BunifuCustomLabel8 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents txtCedul As WindowsFormsControlLibrary1.BunifuCustomTextbox
    Friend WithEvents BunifuCustomLabel4 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuCustomTextbox3 As WindowsFormsControlLibrary1.BunifuCustomTextbox
    Friend WithEvents BunifuCustomLabel3 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuCustomTextbox2 As WindowsFormsControlLibrary1.BunifuCustomTextbox
    Friend WithEvents txtEmail As WindowsFormsControlLibrary1.BunifuCustomTextbox
    Friend WithEvents BunifuCustomTextbox4 As WindowsFormsControlLibrary1.BunifuCustomTextbox
    Friend WithEvents BunifuCustomTextbox5 As WindowsFormsControlLibrary1.BunifuCustomTextbox
    Friend WithEvents grbxActivo As GroupBox
    Friend WithEvents rdbtnNo As RadioButton
    Friend WithEvents rdbtnSi As RadioButton
End Class
