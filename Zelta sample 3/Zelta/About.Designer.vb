<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class About
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(About))
        Me.left_login_panel = New System.Windows.Forms.Panel()
        Me.about_top_panel = New System.Windows.Forms.Panel()
        Me.copyright_Info_about_form = New System.Windows.Forms.Label()
        Me.version_about_form = New System.Windows.Forms.Label()
        Me.title_about_FORM = New System.Windows.Forms.Label()
        Me.about_form_logo = New System.Windows.Forms.PictureBox()
        Me.about_page_second_top_panel = New System.Windows.Forms.Panel()
        Me.college_contact_link = New System.Windows.Forms.LinkLabel()
        Me.college_bca_link = New System.Windows.Forms.LinkLabel()
        Me.links = New System.Windows.Forms.Label()
        Me.college_info_link = New System.Windows.Forms.LinkLabel()
        Me.about_page_3rd_panel = New System.Windows.Forms.Panel()
        Me.name_and_symbol_no = New System.Windows.Forms.TextBox()
        Me.prakash_info = New System.Windows.Forms.TextBox()
        Me.rakesh_info = New System.Windows.Forms.TextBox()
        Me.niraj_info = New System.Windows.Forms.TextBox()
        Me.development_title_about_page = New System.Windows.Forms.Label()
        Me.about_page_note = New System.Windows.Forms.RichTextBox()
        Me.about_top_panel.SuspendLayout()
        CType(Me.about_form_logo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.about_page_second_top_panel.SuspendLayout()
        Me.about_page_3rd_panel.SuspendLayout()
        Me.SuspendLayout()
        '
        'left_login_panel
        '
        Me.left_login_panel.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.left_login_panel.Dock = System.Windows.Forms.DockStyle.Left
        Me.left_login_panel.Location = New System.Drawing.Point(0, 0)
        Me.left_login_panel.Name = "left_login_panel"
        Me.left_login_panel.Size = New System.Drawing.Size(5, 506)
        Me.left_login_panel.TabIndex = 27
        '
        'about_top_panel
        '
        Me.about_top_panel.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.about_top_panel.Controls.Add(Me.copyright_Info_about_form)
        Me.about_top_panel.Controls.Add(Me.version_about_form)
        Me.about_top_panel.Controls.Add(Me.title_about_FORM)
        Me.about_top_panel.Controls.Add(Me.about_form_logo)
        Me.about_top_panel.Dock = System.Windows.Forms.DockStyle.Top
        Me.about_top_panel.Location = New System.Drawing.Point(5, 0)
        Me.about_top_panel.Name = "about_top_panel"
        Me.about_top_panel.Size = New System.Drawing.Size(895, 85)
        Me.about_top_panel.TabIndex = 28
        '
        'copyright_Info_about_form
        '
        Me.copyright_Info_about_form.AutoSize = True
        Me.copyright_Info_about_form.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.copyright_Info_about_form.ForeColor = System.Drawing.SystemColors.WindowText
        Me.copyright_Info_about_form.Location = New System.Drawing.Point(180, 34)
        Me.copyright_Info_about_form.Name = "copyright_Info_about_form"
        Me.copyright_Info_about_form.Size = New System.Drawing.Size(537, 20)
        Me.copyright_Info_about_form.TabIndex = 7
        Me.copyright_Info_about_form.Text = "Copyright(c) 2020-2022 by La Grandee International College-Program-BCA"
        '
        'version_about_form
        '
        Me.version_about_form.AutoSize = True
        Me.version_about_form.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.version_about_form.ForeColor = System.Drawing.SystemColors.WindowText
        Me.version_about_form.Location = New System.Drawing.Point(183, 60)
        Me.version_about_form.Name = "version_about_form"
        Me.version_about_form.Size = New System.Drawing.Size(218, 20)
        Me.version_about_form.TabIndex = 6
        Me.version_about_form.Text = "Version 2.0- BCA IV Project II"
        '
        'title_about_FORM
        '
        Me.title_about_FORM.AutoSize = True
        Me.title_about_FORM.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.title_about_FORM.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.title_about_FORM.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.title_about_FORM.Location = New System.Drawing.Point(177, 3)
        Me.title_about_FORM.Name = "title_about_FORM"
        Me.title_about_FORM.Size = New System.Drawing.Size(428, 31)
        Me.title_about_FORM.TabIndex = 5
        Me.title_about_FORM.Text = "Free RAR/ZIP Password Unlocker"
        '
        'about_form_logo
        '
        Me.about_form_logo.Image = CType(resources.GetObject("about_form_logo.Image"), System.Drawing.Image)
        Me.about_form_logo.Location = New System.Drawing.Point(0, 0)
        Me.about_form_logo.Name = "about_form_logo"
        Me.about_form_logo.Size = New System.Drawing.Size(174, 85)
        Me.about_form_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.about_form_logo.TabIndex = 0
        Me.about_form_logo.TabStop = False
        '
        'about_page_second_top_panel
        '
        Me.about_page_second_top_panel.Controls.Add(Me.college_contact_link)
        Me.about_page_second_top_panel.Controls.Add(Me.college_bca_link)
        Me.about_page_second_top_panel.Controls.Add(Me.links)
        Me.about_page_second_top_panel.Controls.Add(Me.college_info_link)
        Me.about_page_second_top_panel.Dock = System.Windows.Forms.DockStyle.Top
        Me.about_page_second_top_panel.Location = New System.Drawing.Point(5, 85)
        Me.about_page_second_top_panel.Name = "about_page_second_top_panel"
        Me.about_page_second_top_panel.Size = New System.Drawing.Size(895, 151)
        Me.about_page_second_top_panel.TabIndex = 29
        '
        'college_contact_link
        '
        Me.college_contact_link.AutoSize = True
        Me.college_contact_link.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.college_contact_link.Location = New System.Drawing.Point(8, 104)
        Me.college_contact_link.Name = "college_contact_link"
        Me.college_contact_link.Size = New System.Drawing.Size(204, 16)
        Me.college_contact_link.TabIndex = 9
        Me.college_contact_link.TabStop = True
        Me.college_contact_link.Text = "https://lagrandee.edu.np/contact/"
        '
        'college_bca_link
        '
        Me.college_bca_link.AutoSize = True
        Me.college_bca_link.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.college_bca_link.Location = New System.Drawing.Point(8, 77)
        Me.college_bca_link.Name = "college_bca_link"
        Me.college_bca_link.Size = New System.Drawing.Size(246, 16)
        Me.college_bca_link.TabIndex = 8
        Me.college_bca_link.TabStop = True
        Me.college_bca_link.Text = "https://lagrandee.edu.np/programs/bca/"
        '
        'links
        '
        Me.links.AutoSize = True
        Me.links.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.links.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.links.ForeColor = System.Drawing.Color.Blue
        Me.links.Location = New System.Drawing.Point(7, 12)
        Me.links.Name = "links"
        Me.links.Size = New System.Drawing.Size(58, 20)
        Me.links.TabIndex = 0
        Me.links.Text = "Links ::"
        '
        'college_info_link
        '
        Me.college_info_link.AutoSize = True
        Me.college_info_link.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.college_info_link.Location = New System.Drawing.Point(6, 49)
        Me.college_info_link.Name = "college_info_link"
        Me.college_info_link.Size = New System.Drawing.Size(157, 16)
        Me.college_info_link.TabIndex = 1
        Me.college_info_link.TabStop = True
        Me.college_info_link.Text = "https://lagrandee.edu.np/"
        '
        'about_page_3rd_panel
        '
        Me.about_page_3rd_panel.Controls.Add(Me.name_and_symbol_no)
        Me.about_page_3rd_panel.Controls.Add(Me.prakash_info)
        Me.about_page_3rd_panel.Controls.Add(Me.rakesh_info)
        Me.about_page_3rd_panel.Controls.Add(Me.niraj_info)
        Me.about_page_3rd_panel.Controls.Add(Me.development_title_about_page)
        Me.about_page_3rd_panel.Dock = System.Windows.Forms.DockStyle.Top
        Me.about_page_3rd_panel.Location = New System.Drawing.Point(5, 236)
        Me.about_page_3rd_panel.Name = "about_page_3rd_panel"
        Me.about_page_3rd_panel.Size = New System.Drawing.Size(895, 186)
        Me.about_page_3rd_panel.TabIndex = 30
        '
        'name_and_symbol_no
        '
        Me.name_and_symbol_no.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.name_and_symbol_no.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.name_and_symbol_no.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.name_and_symbol_no.Location = New System.Drawing.Point(3, 36)
        Me.name_and_symbol_no.Name = "name_and_symbol_no"
        Me.name_and_symbol_no.ReadOnly = True
        Me.name_and_symbol_no.Size = New System.Drawing.Size(476, 15)
        Me.name_and_symbol_no.TabIndex = 4
        Me.name_and_symbol_no.Text = "Program                 Name                                 Symbol_No.          " &
    "PU_Registration_NO."
        '
        'prakash_info
        '
        Me.prakash_info.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.prakash_info.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.prakash_info.Location = New System.Drawing.Point(3, 147)
        Me.prakash_info.Name = "prakash_info"
        Me.prakash_info.ReadOnly = True
        Me.prakash_info.Size = New System.Drawing.Size(476, 13)
        Me.prakash_info.TabIndex = 3
        Me.prakash_info.Text = "BCA-IV-Batch2018 :: @Prakash Basnet                  19530121                   2" &
    "018-1-53-0121"
        '
        'rakesh_info
        '
        Me.rakesh_info.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.rakesh_info.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.rakesh_info.Location = New System.Drawing.Point(3, 111)
        Me.rakesh_info.Name = "rakesh_info"
        Me.rakesh_info.ReadOnly = True
        Me.rakesh_info.Size = New System.Drawing.Size(476, 13)
        Me.rakesh_info.TabIndex = 2
        Me.rakesh_info.Text = "BCA-IV-Batch2018 :: @Rakesh Chhetri                  19530123                   2" &
    "018-1-53-0123"
        '
        'niraj_info
        '
        Me.niraj_info.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.niraj_info.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.niraj_info.Location = New System.Drawing.Point(3, 73)
        Me.niraj_info.Name = "niraj_info"
        Me.niraj_info.ReadOnly = True
        Me.niraj_info.Size = New System.Drawing.Size(476, 13)
        Me.niraj_info.TabIndex = 1
        Me.niraj_info.Text = "BCA-IV-Batch2018 :: @Niraj Bohara                       19530119                 " &
    "  2018-1-23-0119"
        '
        'development_title_about_page
        '
        Me.development_title_about_page.AutoSize = True
        Me.development_title_about_page.Dock = System.Windows.Forms.DockStyle.Top
        Me.development_title_about_page.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.development_title_about_page.ForeColor = System.Drawing.SystemColors.WindowText
        Me.development_title_about_page.Location = New System.Drawing.Point(0, 0)
        Me.development_title_about_page.Name = "development_title_about_page"
        Me.development_title_about_page.Size = New System.Drawing.Size(587, 18)
        Me.development_title_about_page.TabIndex = 0
        Me.development_title_about_page.Text = "Developed by Students of La Grandee International College-Program-BCA IV-Batch 20" &
    "18"
        '
        'about_page_note
        '
        Me.about_page_note.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.about_page_note.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.about_page_note.Dock = System.Windows.Forms.DockStyle.Fill
        Me.about_page_note.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.about_page_note.Location = New System.Drawing.Point(5, 422)
        Me.about_page_note.Name = "about_page_note"
        Me.about_page_note.ReadOnly = True
        Me.about_page_note.Size = New System.Drawing.Size(895, 84)
        Me.about_page_note.TabIndex = 31
        Me.about_page_note.Text = resources.GetString("about_page_note.Text")
        '
        'About
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(900, 506)
        Me.Controls.Add(Me.about_page_note)
        Me.Controls.Add(Me.about_page_3rd_panel)
        Me.Controls.Add(Me.about_page_second_top_panel)
        Me.Controls.Add(Me.about_top_panel)
        Me.Controls.Add(Me.left_login_panel)
        Me.DoubleBuffered = True
        Me.Name = "About"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "About"
        Me.about_top_panel.ResumeLayout(False)
        Me.about_top_panel.PerformLayout()
        CType(Me.about_form_logo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.about_page_second_top_panel.ResumeLayout(False)
        Me.about_page_second_top_panel.PerformLayout()
        Me.about_page_3rd_panel.ResumeLayout(False)
        Me.about_page_3rd_panel.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents left_login_panel As Panel
    Friend WithEvents about_top_panel As Panel
    Friend WithEvents copyright_Info_about_form As Label
    Friend WithEvents version_about_form As Label
    Friend WithEvents title_about_FORM As Label
    Friend WithEvents about_form_logo As PictureBox
    Friend WithEvents about_page_second_top_panel As Panel
    Friend WithEvents college_contact_link As LinkLabel
    Friend WithEvents college_bca_link As LinkLabel
    Friend WithEvents links As Label
    Friend WithEvents college_info_link As LinkLabel
    Friend WithEvents about_page_3rd_panel As Panel
    Friend WithEvents name_and_symbol_no As TextBox
    Friend WithEvents prakash_info As TextBox
    Friend WithEvents rakesh_info As TextBox
    Friend WithEvents niraj_info As TextBox
    Friend WithEvents development_title_about_page As Label
    Friend WithEvents about_page_note As RichTextBox
End Class
