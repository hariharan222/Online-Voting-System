Imports MySql.Data.MySqlClient
Public Class Settings
    Dim conn As New MySql.Data.MySqlClient.MySqlConnection
    Dim myConnectionString As String
    Dim cmd As New MySqlCommand
    Dim result As Integer
    Dim da As New MySqlDataAdapter
    Private Sub Settings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        connectstat1.Hide()
        connectalert1.Hide()
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        myConnectionString = "server=" & Trim(ip.Text) & ";" _
    & "uid=" & Trim(dbuser.Text) & ";" _
    & "Password=" & Trim(dbpass.Text) & ";" _
    & "database=" & Trim(dbname.Text) & ";"
        Try
            conn.ConnectionString = myConnectionString
            conn.Open()
            connectstat1.Show()
            connectalert1.Hide()

        Catch ex As Exception
            connectalert1.Show()
        End Try
        Login.Login_Load(e, e)


    End Sub

    Private Sub reset_Click_1(sender As Object, e As EventArgs) Handles reset.Click
        dbname.Text = ""
        dbpass.Text = ""
        dbname.Text = ""
        ip.Text = ""
    End Sub
    Private Sub close_Click_1(sender As Object, e As EventArgs) Handles close.Click
        Me.Hide()
    End Sub

    Private Sub ip_TextChanged(sender As Object, e As EventArgs) Handles ip.TextChanged

    End Sub
End Class