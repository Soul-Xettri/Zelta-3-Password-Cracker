<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class login
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(login))
        Me.login_drag = New Bunifu.Framework.UI.BunifuDragControl(Me.components)
        Me.right_login_panel = New System.Windows.Forms.Panel()
        Me.bottom_login_panel = New System.Windows.Forms.Panel()
        Me.left_login_panel = New System.Windows.Forms.Panel()
        Me.login_exit_button = New FontAwesome.Sharp.IconButton()
        Me.login_maximize_button = New FontAwesome.Sharp.IconButton()
        Me.login_minimize_button = New FontAwesome.Sharp.IconButton()
        Me.login_restore_button = New FontAwesome.Sharp.IconButton()
        Me.Username_icon = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.Password_icon = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.login_button = New System.Windows.Forms.Button()
        Me.Logo_loginpage = New System.Windows.Forms.PictureBox()
        Me.Escape = New FontAwesome.Sharp.IconButton()
        Me.login_error = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.Password = New System.Windows.Forms.MaskedTextBox()
        Me.Username = New System.Windows.Forms.TextBox()
        Me.top_login_panel = New System.Windows.Forms.Panel()
        Me.RememberME = New System.Windows.Forms.CheckBox()
        CType(Me.Logo_loginpage, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.login_error, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'login_drag
        '
        Me.login_drag.Fixed = True
        Me.login_drag.Horizontal = True
        Me.login_drag.TargetControl = Me
        Me.login_drag.Vertical = True
        '
        'right_login_panel
        '
        Me.right_login_panel.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.right_login_panel.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.right_login_panel.ForeColor = System.Drawing.Color.Transparent
        Me.right_login_panel.Location = New System.Drawing.Point(895, 5)
        Me.right_login_panel.Name = "right_login_panel"
        Me.right_login_panel.Size = New System.Drawing.Size(5, 506)
        Me.right_login_panel.TabIndex = 1
        '
        'bottom_login_panel
        '
        Me.bottom_login_panel.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bottom_login_panel.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.bottom_login_panel.Location = New System.Drawing.Point(0, 501)
        Me.bottom_login_panel.Name = "bottom_login_panel"
        Me.bottom_login_panel.Size = New System.Drawing.Size(900, 5)
        Me.bottom_login_panel.TabIndex = 2
        '
        'left_login_panel
        '
        Me.left_login_panel.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.left_login_panel.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.left_login_panel.Location = New System.Drawing.Point(0, 0)
        Me.left_login_panel.Name = "left_login_panel"
        Me.left_login_panel.Size = New System.Drawing.Size(5, 506)
        Me.left_login_panel.TabIndex = 3
        '
        'login_exit_button
        '
        Me.login_exit_button.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.login_exit_button.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.login_exit_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.login_exit_button.ForeColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.login_exit_button.IconChar = FontAwesome.Sharp.IconChar.Times
        Me.login_exit_button.IconColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.login_exit_button.IconFont = FontAwesome.Sharp.IconFont.Solid
        Me.login_exit_button.IconSize = 15
        Me.login_exit_button.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.login_exit_button.Location = New System.Drawing.Point(875, 5)
        Me.login_exit_button.Name = "login_exit_button"
        Me.login_exit_button.Size = New System.Drawing.Size(20, 20)
        Me.login_exit_button.TabIndex = 4
        Me.login_exit_button.UseVisualStyleBackColor = False
        '
        'login_maximize_button
        '
        Me.login_maximize_button.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.login_maximize_button.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.login_maximize_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.login_maximize_button.ForeColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.login_maximize_button.IconChar = FontAwesome.Sharp.IconChar.Square
        Me.login_maximize_button.IconColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.login_maximize_button.IconFont = FontAwesome.Sharp.IconFont.Solid
        Me.login_maximize_button.IconSize = 15
        Me.login_maximize_button.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.login_maximize_button.Location = New System.Drawing.Point(854, 5)
        Me.login_maximize_button.Name = "login_maximize_button"
        Me.login_maximize_button.Size = New System.Drawing.Size(20, 20)
        Me.login_maximize_button.TabIndex = 5
        Me.login_maximize_button.UseVisualStyleBackColor = False
        '
        'login_minimize_button
        '
        Me.login_minimize_button.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.login_minimize_button.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.login_minimize_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.login_minimize_button.ForeColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.login_minimize_button.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize
        Me.login_minimize_button.IconColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.login_minimize_button.IconFont = FontAwesome.Sharp.IconFont.Solid
        Me.login_minimize_button.IconSize = 15
        Me.login_minimize_button.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.login_minimize_button.Location = New System.Drawing.Point(831, 5)
        Me.login_minimize_button.Name = "login_minimize_button"
        Me.login_minimize_button.Size = New System.Drawing.Size(20, 20)
        Me.login_minimize_button.TabIndex = 6
        Me.login_minimize_button.UseVisualStyleBackColor = False
        '
        'login_restore_button
        '
        Me.login_restore_button.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.login_restore_button.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.login_restore_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.login_restore_button.ForeColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.login_restore_button.IconChar = FontAwesome.Sharp.IconChar.WindowRestore
        Me.login_restore_button.IconColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.login_restore_button.IconFont = FontAwesome.Sharp.IconFont.Solid
        Me.login_restore_button.IconSize = 15
        Me.login_restore_button.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.login_restore_button.Location = New System.Drawing.Point(854, 5)
        Me.login_restore_button.Name = "login_restore_button"
        Me.login_restore_button.Size = New System.Drawing.Size(20, 20)
        Me.login_restore_button.TabIndex = 7
        Me.login_restore_button.UseVisualStyleBackColor = False
        Me.login_restore_button.Visible = False
        '
        'Username_icon
        '
        Me.Username_icon.Activecolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.Username_icon.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Username_icon.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.Username_icon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Username_icon.BorderRadius = 0
        Me.Username_icon.ButtonText = "    UserName"
        Me.Username_icon.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Username_icon.DisabledColor = System.Drawing.Color.Gray
        Me.Username_icon.Iconcolor = System.Drawing.Color.Transparent
        Me.Username_icon.Iconimage = Nothing
        Me.Username_icon.Iconimage_right = Nothing
        Me.Username_icon.Iconimage_right_Selected = Nothing
        Me.Username_icon.Iconimage_Selected = Nothing
        Me.Username_icon.IconMarginLeft = 0
        Me.Username_icon.IconMarginRight = 0
        Me.Username_icon.IconRightVisible = True
        Me.Username_icon.IconRightZoom = 0R
        Me.Username_icon.IconVisible = True
        Me.Username_icon.IconZoom = 90.0R
        Me.Username_icon.IsTab = False
        Me.Username_icon.Location = New System.Drawing.Point(481, 215)
        Me.Username_icon.Name = "Username_icon"
        Me.Username_icon.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.Username_icon.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.Username_icon.OnHoverTextColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.Username_icon.selected = False
        Me.Username_icon.Size = New System.Drawing.Size(94, 20)
        Me.Username_icon.TabIndex = 10
        Me.Username_icon.Text = "    UserName"
        Me.Username_icon.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Username_icon.Textcolor = System.Drawing.Color.Silver
        Me.Username_icon.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'Password_icon
        '
        Me.Password_icon.Activecolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.Password_icon.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Password_icon.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.Password_icon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Password_icon.BorderRadius = 0
        Me.Password_icon.ButtonText = "    Password"
        Me.Password_icon.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Password_icon.DisabledColor = System.Drawing.Color.Gray
        Me.Password_icon.Iconcolor = System.Drawing.Color.Transparent
        Me.Password_icon.Iconimage = Nothing
        Me.Password_icon.Iconimage_right = Nothing
        Me.Password_icon.Iconimage_right_Selected = Nothing
        Me.Password_icon.Iconimage_Selected = Nothing
        Me.Password_icon.IconMarginLeft = 0
        Me.Password_icon.IconMarginRight = 0
        Me.Password_icon.IconRightVisible = True
        Me.Password_icon.IconRightZoom = 0R
        Me.Password_icon.IconVisible = True
        Me.Password_icon.IconZoom = 90.0R
        Me.Password_icon.IsTab = False
        Me.Password_icon.Location = New System.Drawing.Point(481, 259)
        Me.Password_icon.Name = "Password_icon"
        Me.Password_icon.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.Password_icon.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.Password_icon.OnHoverTextColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.Password_icon.selected = False
        Me.Password_icon.Size = New System.Drawing.Size(94, 20)
        Me.Password_icon.TabIndex = 11
        Me.Password_icon.Text = "    Password"
        Me.Password_icon.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Password_icon.Textcolor = System.Drawing.Color.Silver
        Me.Password_icon.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'login_button
        '
        Me.login_button.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.login_button.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.login_button.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.login_button.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.login_button.Location = New System.Drawing.Point(643, 333)
        Me.login_button.Name = "login_button"
        Me.login_button.Size = New System.Drawing.Size(80, 50)
        Me.login_button.TabIndex = 12
        Me.login_button.Text = "LOGIN"
        Me.login_button.UseVisualStyleBackColor = False
        '
        'Logo_loginpage
        '
        Me.Logo_loginpage.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Logo_loginpage.Image = CType(resources.GetObject("Logo_loginpage.Image"), System.Drawing.Image)
        Me.Logo_loginpage.Location = New System.Drawing.Point(162, 126)
        Me.Logo_loginpage.Name = "Logo_loginpage"
        Me.Logo_loginpage.Size = New System.Drawing.Size(264, 231)
        Me.Logo_loginpage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Logo_loginpage.TabIndex = 13
        Me.Logo_loginpage.TabStop = False
        '
        'Escape
        '
        Me.Escape.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Escape.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Escape.ForeColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.Escape.IconChar = FontAwesome.Sharp.IconChar.None
        Me.Escape.IconColor = System.Drawing.Color.Black
        Me.Escape.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.Escape.Location = New System.Drawing.Point(9, 5)
        Me.Escape.Name = "Escape"
        Me.Escape.Size = New System.Drawing.Size(40, 20)
        Me.Escape.TabIndex = 15
        Me.Escape.Text = "ESC"
        Me.Escape.TextAlign = System.Drawing.ContentAlignment.TopLeft
        Me.Escape.UseVisualStyleBackColor = True
        '
        'login_error
        '
        Me.login_error.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink
        Me.login_error.ContainerControl = Me
        '
        'Password
        '
        Me.Password.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Password.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.Password.ForeColor = System.Drawing.SystemColors.Window
        Me.Password.Location = New System.Drawing.Point(581, 259)
        Me.Password.Name = "Password"
        Me.Password.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.Password.Size = New System.Drawing.Size(200, 20)
        Me.Password.TabIndex = 17
        '
        'Username
        '
        Me.Username.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Username.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.Username.ForeColor = System.Drawing.SystemColors.Window
        Me.Username.Location = New System.Drawing.Point(581, 215)
        Me.Username.Name = "Username"
        Me.Username.Size = New System.Drawing.Size(200, 20)
        Me.Username.TabIndex = 18
        '
        'top_login_panel
        '
        Me.top_login_panel.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.top_login_panel.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.top_login_panel.Location = New System.Drawing.Point(0, 0)
        Me.top_login_panel.Name = "top_login_panel"
        Me.top_login_panel.Size = New System.Drawing.Size(900, 5)
        Me.top_login_panel.TabIndex = 0
        '
        'RememberME
        '
        Me.RememberME.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.RememberME.AutoSize = True
        Me.RememberME.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RememberME.ForeColor = System.Drawing.Color.Silver
        Me.RememberME.Location = New System.Drawing.Point(581, 296)
        Me.RememberME.Name = "RememberME"
        Me.RememberME.Size = New System.Drawing.Size(110, 19)
        Me.RememberME.TabIndex = 21
        Me.RememberME.Text = "Remember Me"
        Me.RememberME.UseVisualStyleBackColor = True
        '
        'login
        '
        Me.AcceptButton = Me.login_button
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.CancelButton = Me.Escape
        Me.ClientSize = New System.Drawing.Size(900, 506)
        Me.Controls.Add(Me.login_maximize_button)
        Me.Controls.Add(Me.RememberME)
        Me.Controls.Add(Me.Username)
        Me.Controls.Add(Me.Password)
        Me.Controls.Add(Me.login_exit_button)
        Me.Controls.Add(Me.Logo_loginpage)
        Me.Controls.Add(Me.login_button)
        Me.Controls.Add(Me.Password_icon)
        Me.Controls.Add(Me.Username_icon)
        Me.Controls.Add(Me.login_restore_button)
        Me.Controls.Add(Me.login_minimize_button)
        Me.Controls.Add(Me.left_login_panel)
        Me.Controls.Add(Me.bottom_login_panel)
        Me.Controls.Add(Me.right_login_panel)
        Me.Controls.Add(Me.top_login_panel)
        Me.Controls.Add(Me.Escape)
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Name = "login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login"
        CType(Me.Logo_loginpage, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.login_error, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents login_drag As Bunifu.Framework.UI.BunifuDragControl
    Friend WithEvents right_login_panel As Panel
    Friend WithEvents left_login_panel As Panel
    Friend WithEvents bottom_login_panel As Panel
    Friend WithEvents login_minimize_button As FontAwesome.Sharp.IconButton
    Friend WithEvents login_maximize_button As FontAwesome.Sharp.IconButton
    Friend WithEvents login_exit_button As FontAwesome.Sharp.IconButton
    Friend WithEvents login_error As ErrorProvider
    Friend WithEvents Password As MaskedTextBox
    Friend WithEvents Username As TextBox
    Friend WithEvents top_login_panel As Panel
    Friend WithEvents RememberME As CheckBox
End Class
