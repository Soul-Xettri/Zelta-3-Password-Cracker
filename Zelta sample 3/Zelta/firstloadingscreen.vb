Public Class firstloadingscreen
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim mainpage As Zelta = New Zelta()
        mainpage.MdiParent = Me.MdiParent
        Me.Close()
        mainpage.Show()
    End Sub

End Class