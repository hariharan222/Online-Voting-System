Public Class Completed
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()

        dataform.Close()
        User.Close()
        Login.Show()

    End Sub
End Class