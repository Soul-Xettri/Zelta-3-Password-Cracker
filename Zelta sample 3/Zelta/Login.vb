Public Class login

    Private Sub IconButton1_Click(sender As Object, e As EventArgs) Handles login_exit_button.Click
        Me.Close()
    End Sub

    Private Sub IconButton2_Click(sender As Object, e As EventArgs) Handles login_maximize_button.Click
        Me.WindowState = FormWindowState.Maximized
        login_maximize_button.Visible = False
        login_restore_button.Visible = True
    End Sub

    Private Sub IconButton3_Click(sender As Object, e As EventArgs) Handles login_minimize_button.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Friend WithEvents login_restore_button As FontAwesome.Sharp.IconButton

    Private Sub login_restore_button_Click(sender As Object, e As EventArgs) Handles login_restore_button.Click
        Me.WindowState = FormWindowState.Normal
        login_restore_button.Visible = False
        login_maximize_button.Visible = True
    End Sub

    Friend WithEvents Logo_loginpage As PictureBox
    Friend WithEvents login_button As Button
    Friend WithEvents Password_icon As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents Username_icon As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents Escape As FontAwesome.Sharp.IconButton

    Private Sub IconButton1_Click_1(sender As Object, e As EventArgs) Handles Escape.Click
        Me.WindowState = FormWindowState.Normal
    End Sub

    Private Sub login_button_Click(sender As Object, e As EventArgs) Handles login_button.Click
        Dim userid As String = Username.Text
        Dim userpassword As String = Password.Text
        If userid.Equals("Admin") And userpassword.Equals("Zelta") Then
            Dim mainpage As firstloadingscreen = New firstloadingscreen()
            mainpage.MdiParent = Me.MdiParent
            Me.Hide()
            mainpage.Show()
        Else
            Username.Clear()
            Password.Clear()
            login_error.SetError(Username, "Invalid Username and Password")
            login_error.SetError(Password, "Invalid Username and Password")
        End If
    End Sub

    Private Sub login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If My.Settings.RememberME = True Then
            Username.Text = My.Settings.UserName
            Password.Text = My.Settings.Password
            RememberME.Checked = True
        Else
            'do nothing
        End If
        Me.Text = String.Empty
        Me.ControlBox = False
        Me.DoubleBuffered = True
    End Sub

    Private Sub RememberME_CheckedChanged(sender As Object, e As EventArgs) Handles RememberME.CheckedChanged
        If RememberME.Checked = True Then
            My.Settings.RememberME = True
            My.Settings.UserName = Username.Text
            My.Settings.Password = Password.Text
            My.Settings.Save()
            Username.Focus()
        Else
            My.Settings.RememberME = False
            My.Settings.UserName = Username.Text
            My.Settings.Password = Password.Text
            My.Settings.Save()
            Username.Text = ""
            Password.Text = ""
            Username.Focus()
        End If
    End Sub
End Class