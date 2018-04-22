Imports MySql.Data.MySqlClient
Public Class db_settings
    Dim conn As New MySql.Data.MySqlClient.MySqlConnection
    Dim myConnectionString As String
    Dim cmd As New MySqlCommand
    Dim result As Integer
    Dim da As New MySqlDataAdapter

    Private Sub db_settings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        connectstat1.Hide()
        connectalert1.Hide()
    End Sub
    Public Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
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
            connectstat1.Hide()
            connectalert1.Show()
        End Try
        conn.Close()
        main_activity.Form1_Load(e, e)
    End Sub

    Private Sub close_Click(sender As Object, e As EventArgs) Handles close.Click

        Me.Hide()
    End Sub
End Class