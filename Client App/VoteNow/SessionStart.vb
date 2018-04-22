Imports MySql.Data.MySqlClient
Public Class SessionStart
    Dim con As New MySql.Data.MySqlClient.MySqlConnection
    Dim myConnectionString As String
    Dim cmd, cmd1 As New MySqlCommand
    Dim result As Integer
    Dim da As New MySqlDataAdapter
    Dim dr As MySqlDataReader
    Dim ds As New DataTable
    Dim bs As New BindingSource
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        End
    End Sub

    Private Sub SessionStart_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        myConnectionString = "server=" & Trim(Settings.ip.Text) & ";" _
       & "uid=" & Trim(Settings.dbuser.Text) & ";" _
       & "Password=" & Trim(Settings.dbpass.Text) & ";" _
       & "database=" & Trim(Settings.dbname.Text) & ";"
        Try
            con.ConnectionString = myConnectionString
            con.Open()
        Catch ex As Exception
            MessageBox.Show("No Connection to the internet found")

        End Try
        con.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        con.Open()
        With cmd
            .Connection = con
            .CommandText = "SELECT STUDENT_ID FROM `student_candidate_rel` WHERE STUDENT_ID='" & User.userid.Text & "'"
            result = cmd.ExecuteNonQuery
            dr = cmd.ExecuteReader
        End With
   
        If dr.HasRows Then
            Completed.Show()
            Me.Close()
        Else
            President_vote.Show()
            Me.Close()
        End If

    End Sub
End Class