Public Class About
    Private Sub About_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        college_info_link.Text = "https://lagrandee.edu.np/"
        college_info_link.Links.Add(0, 25, "https://lagrandee.edu.np/")
        college_bca_link.Text = "https://lagrandee.edu.np/programs/bca/"
        college_bca_link.Links.Add(0, 38, "https://lagrandee.edu.np/programs/bca/")
        college_contact_link.Text = "https://lagrandee.edu.np/contact/"
        college_contact_link.Links.Add(0, 33, "https://lagrandee.edu.np/contact/")
    End Sub

    Private Sub college_info_link_LinkClicked_1(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles college_info_link.LinkClicked
        Process.Start("https://lagrandee.edu.np/")
    End Sub

    Private Sub college_bca_link_LinkClicked_1(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles college_bca_link.LinkClicked
        Process.Start("https://lagrandee.edu.np/programs/bca/")
    End Sub

    Private Sub college_contact_link_LinkClicked_1(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles college_contact_link.LinkClicked
        Process.Start("https://lagrandee.edu.np/contact/")
    End Sub
End Class