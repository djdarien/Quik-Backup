Public Class disclaimer

    'Close
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Close()
    End Sub

    'Shows main form, hides disclamer
    Private Sub btnAccept_Click(sender As Object, e As EventArgs) Handles btnAccept.Click
        Form1.Show()
        Hide()
    End Sub
End Class
