<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Zelta
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Zelta))
        Me.taskbar_zeltapage = New System.Windows.Forms.Panel()
        Me.college_logo = New System.Windows.Forms.PictureBox()
        Me.college_name = New System.Windows.Forms.Label()
        Me.login_exit_button = New FontAwesome.Sharp.IconButton()
        Me.side_menu = New System.Windows.Forms.Panel()
        Me.BunifuFlatButton1 = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.menu_button = New FontAwesome.Sharp.IconButton()
        Me.logo_sidemenu = New System.Windows.Forms.PictureBox()
        Me.exit_menu_button = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.about_menu_button = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.help_menu_button = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.open_menu_button = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.zelta_logo = New System.Windows.Forms.PictureBox()
        Me.login_restore_button = New FontAwesome.Sharp.IconButton()
        Me.login_maximize_button = New FontAwesome.Sharp.IconButton()
        Me.login_minimize_button = New FontAwesome.Sharp.IconButton()
        Me.drag_center = New Bunifu.Framework.UI.BunifuDragControl(Me.components)
        Me.drag_sidepanel = New Bunifu.Framework.UI.BunifuDragControl(Me.components)
        Me.drag_taskbar = New Bunifu.Framework.UI.BunifuDragControl(Me.components)
        Me.bottom_login_panel = New System.Windows.Forms.Panel()
        Me.right_login_panel = New System.Windows.Forms.Panel()
        Me.panelChildform = New System.Windows.Forms.Panel()
        Me.hello = New System.Windows.Forms.Button()
        Me.homescreen = New System.Windows.Forms.PictureBox()
        Me.display_saved_password = New System.Windows.Forms.TextBox()
        Me.drag_childform = New Bunifu.Framework.UI.BunifuDragControl(Me.components)
        Me.open_save_paswords = New System.Windows.Forms.OpenFileDialog()
        Me.taskbar_zeltapage.SuspendLayout()
        CType(Me.college_logo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.side_menu.SuspendLayout()
        CType(Me.logo_sidemenu, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.zelta_logo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelChildform.SuspendLayout()
        CType(Me.homescreen, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'taskbar_zeltapage
        '
        Me.taskbar_zeltapage.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.taskbar_zeltapage.Controls.Add(Me.college_logo)
        Me.taskbar_zeltapage.Controls.Add(Me.college_name)
        Me.taskbar_zeltapage.Controls.Add(Me.login_exit_button)
        Me.taskbar_zeltapage.Dock = System.Windows.Forms.DockStyle.Top
        Me.taskbar_zeltapage.Location = New System.Drawing.Point(0, 0)
        Me.taskbar_zeltapage.Name = "taskbar_zeltapage"
        Me.taskbar_zeltapage.Size = New System.Drawing.Size(900, 30)
        Me.taskbar_zeltapage.TabIndex = 0
        '
        'college_logo
        '
        Me.college_logo.Image = CType(resources.GetObject("college_logo.Image"), System.Drawing.Image)
        Me.college_logo.Location = New System.Drawing.Point(12, 2)
        Me.college_logo.Name = "college_logo"
        Me.college_logo.Size = New System.Drawing.Size(35, 26)
        Me.college_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.college_logo.TabIndex = 11
        Me.college_logo.TabStop = False
        '
        'college_name
        '
        Me.college_name.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.college_name.AutoSize = True
        Me.college_name.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.college_name.Location = New System.Drawing.Point(52, 7)
        Me.college_name.Name = "college_name"
        Me.college_name.Size = New System.Drawing.Size(270, 16)
        Me.college_name.TabIndex = 12
        Me.college_name.Text = "LA Grandee International College :: Project-2"
        '
        'login_exit_button
        '
        Me.login_exit_button.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.login_exit_button.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.login_exit_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.login_exit_button.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.login_exit_button.IconChar = FontAwesome.Sharp.IconChar.Times
        Me.login_exit_button.IconColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.login_exit_button.IconFont = FontAwesome.Sharp.IconFont.Solid
        Me.login_exit_button.IconSize = 15
        Me.login_exit_button.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.login_exit_button.Location = New System.Drawing.Point(875, 5)
        Me.login_exit_button.Name = "login_exit_button"
        Me.login_exit_button.Size = New System.Drawing.Size(20, 20)
        Me.login_exit_button.TabIndex = 5
        Me.login_exit_button.UseVisualStyleBackColor = False
        '
        'side_menu
        '
        Me.side_menu.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.side_menu.Controls.Add(Me.BunifuFlatButton1)
        Me.side_menu.Controls.Add(Me.menu_button)
        Me.side_menu.Controls.Add(Me.logo_sidemenu)
        Me.side_menu.Controls.Add(Me.exit_menu_button)
        Me.side_menu.Controls.Add(Me.about_menu_button)
        Me.side_menu.Controls.Add(Me.help_menu_button)
        Me.side_menu.Controls.Add(Me.open_menu_button)
        Me.side_menu.Controls.Add(Me.zelta_logo)
        Me.side_menu.Dock = System.Windows.Forms.DockStyle.Left
        Me.side_menu.Location = New System.Drawing.Point(0, 30)
        Me.side_menu.Name = "side_menu"
        Me.side_menu.Size = New System.Drawing.Size(230, 476)
        Me.side_menu.TabIndex = 1
        '
        'BunifuFlatButton1
        '
        Me.BunifuFlatButton1.Activecolor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.BunifuFlatButton1.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.BunifuFlatButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuFlatButton1.BorderRadius = 0
        Me.BunifuFlatButton1.ButtonText = "           Start"
        Me.BunifuFlatButton1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuFlatButton1.DisabledColor = System.Drawing.Color.Gray
        Me.BunifuFlatButton1.Iconcolor = System.Drawing.Color.Transparent
        Me.BunifuFlatButton1.Iconimage = CType(resources.GetObject("BunifuFlatButton1.Iconimage"), System.Drawing.Image)
        Me.BunifuFlatButton1.Iconimage_right = Nothing
        Me.BunifuFlatButton1.Iconimage_right_Selected = Nothing
        Me.BunifuFlatButton1.Iconimage_Selected = Nothing
        Me.BunifuFlatButton1.IconMarginLeft = 0
        Me.BunifuFlatButton1.IconMarginRight = 0
        Me.BunifuFlatButton1.IconRightVisible = True
        Me.BunifuFlatButton1.IconRightZoom = 0R
        Me.BunifuFlatButton1.IconVisible = True
        Me.BunifuFlatButton1.IconZoom = 45.0R
        Me.BunifuFlatButton1.IsTab = True
        Me.BunifuFlatButton1.Location = New System.Drawing.Point(0, 140)
        Me.BunifuFlatButton1.Name = "BunifuFlatButton1"
        Me.BunifuFlatButton1.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.BunifuFlatButton1.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.BunifuFlatButton1.OnHoverTextColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.BunifuFlatButton1.selected = True
        Me.BunifuFlatButton1.Size = New System.Drawing.Size(230, 35)
        Me.BunifuFlatButton1.TabIndex = 12
        Me.BunifuFlatButton1.Text = "           Start"
        Me.BunifuFlatButton1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BunifuFlatButton1.Textcolor = System.Drawing.Color.Silver
        Me.BunifuFlatButton1.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'menu_button
        '
        Me.menu_button.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.menu_button.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.menu_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.menu_button.ForeColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.menu_button.IconChar = FontAwesome.Sharp.IconChar.Bars
        Me.menu_button.IconColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.menu_button.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.menu_button.IconSize = 18
        Me.menu_button.Location = New System.Drawing.Point(205, 6)
        Me.menu_button.Name = "menu_button"
        Me.menu_button.Size = New System.Drawing.Size(22, 22)
        Me.menu_button.TabIndex = 11
        Me.menu_button.UseVisualStyleBackColor = False
        '
        'logo_sidemenu
        '
        Me.logo_sidemenu.Image = CType(resources.GetObject("logo_sidemenu.Image"), System.Drawing.Image)
        Me.logo_sidemenu.Location = New System.Drawing.Point(-8, 10)
        Me.logo_sidemenu.Name = "logo_sidemenu"
        Me.logo_sidemenu.Size = New System.Drawing.Size(63, 63)
        Me.logo_sidemenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.logo_sidemenu.TabIndex = 14
        Me.logo_sidemenu.TabStop = False
        Me.logo_sidemenu.Visible = False
        '
        'exit_menu_button
        '
        Me.exit_menu_button.Activecolor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.exit_menu_button.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.exit_menu_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.exit_menu_button.BorderRadius = 0
        Me.exit_menu_button.ButtonText = "           Exit"
        Me.exit_menu_button.Cursor = System.Windows.Forms.Cursors.Hand
        Me.exit_menu_button.DisabledColor = System.Drawing.Color.Gray
        Me.exit_menu_button.Iconcolor = System.Drawing.Color.Transparent
        Me.exit_menu_button.Iconimage = CType(resources.GetObject("exit_menu_button.Iconimage"), System.Drawing.Image)
        Me.exit_menu_button.Iconimage_right = Nothing
        Me.exit_menu_button.Iconimage_right_Selected = Nothing
        Me.exit_menu_button.Iconimage_Selected = Nothing
        Me.exit_menu_button.IconMarginLeft = 0
        Me.exit_menu_button.IconMarginRight = 0
        Me.exit_menu_button.IconRightVisible = True
        Me.exit_menu_button.IconRightZoom = 0R
        Me.exit_menu_button.IconVisible = True
        Me.exit_menu_button.IconZoom = 45.0R
        Me.exit_menu_button.IsTab = True
        Me.exit_menu_button.Location = New System.Drawing.Point(0, 304)
        Me.exit_menu_button.Name = "exit_menu_button"
        Me.exit_menu_button.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.exit_menu_button.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.exit_menu_button.OnHoverTextColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.exit_menu_button.selected = False
        Me.exit_menu_button.Size = New System.Drawing.Size(230, 35)
        Me.exit_menu_button.TabIndex = 12
        Me.exit_menu_button.Text = "           Exit"
        Me.exit_menu_button.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.exit_menu_button.Textcolor = System.Drawing.Color.Silver
        Me.exit_menu_button.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'about_menu_button
        '
        Me.about_menu_button.Activecolor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.about_menu_button.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.about_menu_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.about_menu_button.BorderRadius = 0
        Me.about_menu_button.ButtonText = "           About"
        Me.about_menu_button.Cursor = System.Windows.Forms.Cursors.Hand
        Me.about_menu_button.DisabledColor = System.Drawing.Color.Gray
        Me.about_menu_button.Iconcolor = System.Drawing.Color.Transparent
        Me.about_menu_button.Iconimage = CType(resources.GetObject("about_menu_button.Iconimage"), System.Drawing.Image)
        Me.about_menu_button.Iconimage_right = Nothing
        Me.about_menu_button.Iconimage_right_Selected = Nothing
        Me.about_menu_button.Iconimage_Selected = Nothing
        Me.about_menu_button.IconMarginLeft = 0
        Me.about_menu_button.IconMarginRight = 0
        Me.about_menu_button.IconRightVisible = True
        Me.about_menu_button.IconRightZoom = 0R
        Me.about_menu_button.IconVisible = True
        Me.about_menu_button.IconZoom = 45.0R
        Me.about_menu_button.IsTab = True
        Me.about_menu_button.Location = New System.Drawing.Point(0, 263)
        Me.about_menu_button.Name = "about_menu_button"
        Me.about_menu_button.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.about_menu_button.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.about_menu_button.OnHoverTextColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.about_menu_button.selected = False
        Me.about_menu_button.Size = New System.Drawing.Size(230, 35)
        Me.about_menu_button.TabIndex = 11
        Me.about_menu_button.Text = "           About"
        Me.about_menu_button.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.about_menu_button.Textcolor = System.Drawing.Color.Silver
        Me.about_menu_button.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'help_menu_button
        '
        Me.help_menu_button.Activecolor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.help_menu_button.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.help_menu_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.help_menu_button.BorderRadius = 0
        Me.help_menu_button.ButtonText = "           Help"
        Me.help_menu_button.Cursor = System.Windows.Forms.Cursors.Hand
        Me.help_menu_button.DisabledColor = System.Drawing.Color.Gray
        Me.help_menu_button.Iconcolor = System.Drawing.Color.Transparent
        Me.help_menu_button.Iconimage = CType(resources.GetObject("help_menu_button.Iconimage"), System.Drawing.Image)
        Me.help_menu_button.Iconimage_right = Nothing
        Me.help_menu_button.Iconimage_right_Selected = Nothing
        Me.help_menu_button.Iconimage_Selected = Nothing
        Me.help_menu_button.IconMarginLeft = 0
        Me.help_menu_button.IconMarginRight = 0
        Me.help_menu_button.IconRightVisible = True
        Me.help_menu_button.IconRightZoom = 0R
        Me.help_menu_button.IconVisible = True
        Me.help_menu_button.IconZoom = 45.0R
        Me.help_menu_button.IsTab = True
        Me.help_menu_button.Location = New System.Drawing.Point(0, 222)
        Me.help_menu_button.Name = "help_menu_button"
        Me.help_menu_button.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.help_menu_button.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.help_menu_button.OnHoverTextColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.help_menu_button.selected = False
        Me.help_menu_button.Size = New System.Drawing.Size(230, 35)
        Me.help_menu_button.TabIndex = 11
        Me.help_menu_button.Text = "           Help"
        Me.help_menu_button.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.help_menu_button.Textcolor = System.Drawing.Color.Silver
        Me.help_menu_button.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'open_menu_button
        '
        Me.open_menu_button.Activecolor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.open_menu_button.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.open_menu_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.open_menu_button.BorderRadius = 0
        Me.open_menu_button.ButtonText = "           Open"
        Me.open_menu_button.Cursor = System.Windows.Forms.Cursors.Hand
        Me.open_menu_button.DisabledColor = System.Drawing.Color.Gray
        Me.open_menu_button.Iconcolor = System.Drawing.Color.Transparent
        Me.open_menu_button.Iconimage = CType(resources.GetObject("open_menu_button.Iconimage"), System.Drawing.Image)
        Me.open_menu_button.Iconimage_right = Nothing
        Me.open_menu_button.Iconimage_right_Selected = Nothing
        Me.open_menu_button.Iconimage_Selected = Nothing
        Me.open_menu_button.IconMarginLeft = 0
        Me.open_menu_button.IconMarginRight = 0
        Me.open_menu_button.IconRightVisible = True
        Me.open_menu_button.IconRightZoom = 0R
        Me.open_menu_button.IconVisible = True
        Me.open_menu_button.IconZoom = 45.0R
        Me.open_menu_button.IsTab = True
        Me.open_menu_button.Location = New System.Drawing.Point(-1, 181)
        Me.open_menu_button.Name = "open_menu_button"
        Me.open_menu_button.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.open_menu_button.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.open_menu_button.OnHoverTextColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.open_menu_button.selected = False
        Me.open_menu_button.Size = New System.Drawing.Size(230, 35)
        Me.open_menu_button.TabIndex = 11
        Me.open_menu_button.Text = "           Open"
        Me.open_menu_button.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.open_menu_button.Textcolor = System.Drawing.Color.Silver
        Me.open_menu_button.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'zelta_logo
        '
        Me.zelta_logo.Image = CType(resources.GetObject("zelta_logo.Image"), System.Drawing.Image)
        Me.zelta_logo.Location = New System.Drawing.Point(12, 6)
        Me.zelta_logo.Name = "zelta_logo"
        Me.zelta_logo.Size = New System.Drawing.Size(175, 87)
        Me.zelta_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.zelta_logo.TabIndex = 13
        Me.zelta_logo.TabStop = False
        '
        'login_restore_button
        '
        Me.login_restore_button.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.login_restore_button.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.login_restore_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.login_restore_button.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.login_restore_button.IconChar = FontAwesome.Sharp.IconChar.WindowRestore
        Me.login_restore_button.IconColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.login_restore_button.IconFont = FontAwesome.Sharp.IconFont.Solid
        Me.login_restore_button.IconSize = 15
        Me.login_restore_button.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.login_restore_button.Location = New System.Drawing.Point(854, 5)
        Me.login_restore_button.Name = "login_restore_button"
        Me.login_restore_button.Size = New System.Drawing.Size(20, 20)
        Me.login_restore_button.TabIndex = 8
        Me.login_restore_button.UseVisualStyleBackColor = False
        Me.login_restore_button.Visible = False
        '
        'login_maximize_button
        '
        Me.login_maximize_button.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.login_maximize_button.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.login_maximize_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.login_maximize_button.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.login_maximize_button.IconChar = FontAwesome.Sharp.IconChar.Square
        Me.login_maximize_button.IconColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.login_maximize_button.IconFont = FontAwesome.Sharp.IconFont.Solid
        Me.login_maximize_button.IconSize = 15
        Me.login_maximize_button.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.login_maximize_button.Location = New System.Drawing.Point(854, 5)
        Me.login_maximize_button.Name = "login_maximize_button"
        Me.login_maximize_button.Size = New System.Drawing.Size(20, 20)
        Me.login_maximize_button.TabIndex = 9
        Me.login_maximize_button.UseVisualStyleBackColor = False
        '
        'login_minimize_button
        '
        Me.login_minimize_button.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.login_minimize_button.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.login_minimize_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.login_minimize_button.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.login_minimize_button.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize
        Me.login_minimize_button.IconColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.login_minimize_button.IconFont = FontAwesome.Sharp.IconFont.Solid
        Me.login_minimize_button.IconSize = 15
        Me.login_minimize_button.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.login_minimize_button.Location = New System.Drawing.Point(831, 5)
        Me.login_minimize_button.Name = "login_minimize_button"
        Me.login_minimize_button.Size = New System.Drawing.Size(20, 20)
        Me.login_minimize_button.TabIndex = 10
        Me.login_minimize_button.UseVisualStyleBackColor = False
        '
        'drag_center
        '
        Me.drag_center.Fixed = True
        Me.drag_center.Horizontal = True
        Me.drag_center.TargetControl = Me
        Me.drag_center.Vertical = True
        '
        'drag_sidepanel
        '
        Me.drag_sidepanel.Fixed = True
        Me.drag_sidepanel.Horizontal = True
        Me.drag_sidepanel.TargetControl = Me.side_menu
        Me.drag_sidepanel.Vertical = True
        '
        'drag_taskbar
        '
        Me.drag_taskbar.Fixed = True
        Me.drag_taskbar.Horizontal = True
        Me.drag_taskbar.TargetControl = Me.taskbar_zeltapage
        Me.drag_taskbar.Vertical = True
        '
        'bottom_login_panel
        '
        Me.bottom_login_panel.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.bottom_login_panel.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.bottom_login_panel.Location = New System.Drawing.Point(230, 501)
        Me.bottom_login_panel.Name = "bottom_login_panel"
        Me.bottom_login_panel.Size = New System.Drawing.Size(670, 5)
        Me.bottom_login_panel.TabIndex = 11
        '
        'right_login_panel
        '
        Me.right_login_panel.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.right_login_panel.Dock = System.Windows.Forms.DockStyle.Right
        Me.right_login_panel.ForeColor = System.Drawing.Color.Transparent
        Me.right_login_panel.Location = New System.Drawing.Point(895, 30)
        Me.right_login_panel.Name = "right_login_panel"
        Me.right_login_panel.Size = New System.Drawing.Size(5, 471)
        Me.right_login_panel.TabIndex = 12
        '
        'panelChildform
        '
        Me.panelChildform.Controls.Add(Me.hello)
        Me.panelChildform.Controls.Add(Me.homescreen)
        Me.panelChildform.Controls.Add(Me.display_saved_password)
        Me.panelChildform.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panelChildform.Location = New System.Drawing.Point(230, 30)
        Me.panelChildform.Name = "panelChildform"
        Me.panelChildform.Size = New System.Drawing.Size(665, 471)
        Me.panelChildform.TabIndex = 13
        '
        'hello
        '
        Me.hello.Location = New System.Drawing.Point(87, 24)
        Me.hello.Name = "hello"
        Me.hello.Size = New System.Drawing.Size(75, 23)
        Me.hello.TabIndex = 9
        Me.hello.Text = "Button1"
        Me.hello.UseVisualStyleBackColor = True
        '
        'homescreen
        '
        Me.homescreen.Dock = System.Windows.Forms.DockStyle.Fill
        Me.homescreen.Image = CType(resources.GetObject("homescreen.Image"), System.Drawing.Image)
        Me.homescreen.Location = New System.Drawing.Point(0, 0)
        Me.homescreen.Name = "homescreen"
        Me.homescreen.Size = New System.Drawing.Size(665, 471)
        Me.homescreen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.homescreen.TabIndex = 8
        Me.homescreen.TabStop = False
        '
        'display_saved_password
        '
        Me.display_saved_password.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.display_saved_password.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.display_saved_password.Dock = System.Windows.Forms.DockStyle.Fill
        Me.display_saved_password.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.display_saved_password.ForeColor = System.Drawing.SystemColors.Window
        Me.display_saved_password.Location = New System.Drawing.Point(0, 0)
        Me.display_saved_password.Multiline = True
        Me.display_saved_password.Name = "display_saved_password"
        Me.display_saved_password.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.display_saved_password.Size = New System.Drawing.Size(665, 471)
        Me.display_saved_password.TabIndex = 7
        Me.display_saved_password.Visible = False
        '
        'drag_childform
        '
        Me.drag_childform.Fixed = True
        Me.drag_childform.Horizontal = True
        Me.drag_childform.TargetControl = Nothing
        Me.drag_childform.Vertical = True
        '
        'open_save_paswords
        '
        Me.open_save_paswords.FileName = "open_save_paswords"
        '
        'Zelta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(900, 506)
        Me.Controls.Add(Me.panelChildform)
        Me.Controls.Add(Me.right_login_panel)
        Me.Controls.Add(Me.bottom_login_panel)
        Me.Controls.Add(Me.login_minimize_button)
        Me.Controls.Add(Me.login_maximize_button)
        Me.Controls.Add(Me.login_restore_button)
        Me.Controls.Add(Me.side_menu)
        Me.Controls.Add(Me.taskbar_zeltapage)
        Me.Name = "Zelta"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Zelta"
        Me.taskbar_zeltapage.ResumeLayout(False)
        Me.taskbar_zeltapage.PerformLayout()
        CType(Me.college_logo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.side_menu.ResumeLayout(False)
        CType(Me.logo_sidemenu, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.zelta_logo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelChildform.ResumeLayout(False)
        Me.panelChildform.PerformLayout()
        CType(Me.homescreen, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents taskbar_zeltapage As Panel
    Friend WithEvents side_menu As Panel
    Friend WithEvents login_exit_button As FontAwesome.Sharp.IconButton
    Friend WithEvents login_restore_button As FontAwesome.Sharp.IconButton
    Friend WithEvents login_maximize_button As FontAwesome.Sharp.IconButton
    Friend WithEvents login_minimize_button As FontAwesome.Sharp.IconButton
    Friend WithEvents menu_button As FontAwesome.Sharp.IconButton
    Friend WithEvents college_logo As PictureBox
    Friend WithEvents college_name As Label
    Friend WithEvents zelta_logo As PictureBox
    Friend WithEvents drag_center As Bunifu.Framework.UI.BunifuDragControl
    Friend WithEvents drag_sidepanel As Bunifu.Framework.UI.BunifuDragControl
    Friend WithEvents drag_taskbar As Bunifu.Framework.UI.BunifuDragControl
    Friend WithEvents logo_sidemenu As PictureBox
    Friend WithEvents exit_menu_button As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents about_menu_button As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents help_menu_button As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents open_menu_button As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents bottom_login_panel As Panel
    Friend WithEvents right_login_panel As Panel
    Friend WithEvents panelChildform As Panel
    Friend WithEvents drag_childform As Bunifu.Framework.UI.BunifuDragControl
    Friend WithEvents open_save_paswords As OpenFileDialog
    Friend WithEvents BunifuFlatButton1 As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents display_saved_password As TextBox
    Friend WithEvents homescreen As PictureBox
    Friend WithEvents hello As Button
End Class
