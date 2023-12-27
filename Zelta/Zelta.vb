Public Class Zelta
    Private Sub Zelta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = String.Empty
        Me.ControlBox = False
        Me.DoubleBuffered = True
    End Sub

    Private Sub login_exit_button_Click(sender As Object, e As EventArgs) Handles login_exit_button.Click
        Me.Close()
        login.Close()
    End Sub

    Private Sub login_maximize_button_Click(sender As Object, e As EventArgs) Handles login_maximize_button.Click
        Me.WindowState = FormWindowState.Maximized
        login_maximize_button.Visible = False
        login_restore_button.Visible = True
    End Sub

    Private Sub login_restore_button_Click(sender As Object, e As EventArgs) Handles login_restore_button.Click
        Me.WindowState = FormWindowState.Normal
        login_restore_button.Visible = False
        login_maximize_button.Visible = True
    End Sub

    Private Sub login_minimize_button_Click(sender As Object, e As EventArgs) Handles login_minimize_button.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub menu_button_Click(sender As Object, e As EventArgs) Handles menu_button.Click
        Dim sidemenuwid As Integer = side_menu.Width
        If sidemenuwid.Equals(55) Then
            side_menu.Visible = True
            zelta_logo.Visible = True
            logo_sidemenu.Visible = False
            side_menu.Width = 230
        Else
            side_menu.Visible = True
            zelta_logo.Visible = False
            logo_sidemenu.Visible = True
            side_menu.Width = 55
        End If
    End Sub

    Private Sub exit_menu_button_Click(sender As Object, e As EventArgs) Handles exit_menu_button.Click
        Me.Close()
        login.Close()
    End Sub

    Private Sub OpenChildFormInpanel(Of activeform As {Form, New})()
        Dim childform As Form
        childform = panelChildform.Controls.OfType(Of activeform)().FirstOrDefault()
        If childform Is Nothing Then
            childform = New activeform()
            childform.TopLevel = False
            childform.FormBorderStyle = FormBorderStyle.None
            childform.Dock = DockStyle.Fill
            panelChildform.Controls.Add(childform)
            panelChildform.Tag = childform
            childform.Show()
        Else
            childform.BringToFront()
        End If
    End Sub

    Private Sub CloseChildFormpanel(Of activeform As {Form, New})()
        Dim childform As Form
        childform = panelChildform.Controls.OfType(Of activeform)().FirstOrDefault()
        If childform Is Nothing Then
            childform = New activeform()
            childform.TopLevel = False
            childform.FormBorderStyle = FormBorderStyle.None
            childform.Dock = DockStyle.Fill
            panelChildform.Controls.Add(childform)
            panelChildform.Tag = childform
            childform.Hide()
        Else
            childform.SendToBack()
        End If
    End Sub


    Private Sub BunifuFlatButton1_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton1.Click
        homescreen.BringToFront()
        display_saved_password.Visible = False
        Process.Start("C:\Users\Soul\Documents\repos\Zelta sample 3\bat\ULTIMATEDOT.bat")
    End Sub

    Private Sub open_menu_button_Click(sender As Object, e As EventArgs) Handles open_menu_button.Click
        display_saved_password.BringToFront()
        display_saved_password.Visible = True
        Dim passwordtext As String
        open_save_paswords.Filter = "Text File|*.txt|Word Doc|*.doc"
        open_save_paswords.InitialDirectory = "Downloads"
        open_save_paswords.Title = "Open Saved Passwords"
        open_save_paswords.ShowDialog()
        passwordtext = open_save_paswords.FileName
        display_saved_password.Text = My.Computer.FileSystem.ReadAllText(passwordtext)
    End Sub

    Private Sub about_menu_button_Click(sender As Object, e As EventArgs) Handles about_menu_button.Click
        display_saved_password.Visible = False
        OpenChildFormInpanel(Of About)()
    End Sub

    Private Sub help_menu_button_Click(sender As Object, e As EventArgs) Handles help_menu_button.Click
        OpenChildFormInpanel(Of help)()
    End Sub

    Private Sub hello_Click(sender As Object, e As EventArgs) Handles hello.Click
        OpenChildFormInpanel(Of help)()

    End Sub
End Class