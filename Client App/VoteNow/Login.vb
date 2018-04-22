Imports MySql.Data.MySqlClient
Public Class Login
    Dim con As New MySql.Data.MySqlClient.MySqlConnection
    Dim myConnectionString As String
    Dim cmd As New MySqlCommand
    Dim cmd1 As New MySqlCommand
    Dim result As Integer
    Dim da As New MySqlDataAdapter
    Dim dr As MySqlDataReader
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        End

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Settings.Show()
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        con.Open()
        With cmd
            .Connection = con
            .CommandText = "SELECT ID,PASSWORD FROM `studentlist` WHERE ID='" & TextBox1.Text & "' and Password = '" & TextBox2.Text & "'"
            result = cmd.ExecuteNonQuery
            dr = cmd.ExecuteReader
        End With
        If dr.HasRows Then
            dr.Close()
            cmd.Parameters.Clear()
            'get name from DB to user label
            With cmd
                .Connection = con
                .CommandText = "SELECT NAME,SCHOOL_TYPE,STUDENT_TYPE FROM studentlist WHERE ID='" & TextBox1.Text & "'"
                result = cmd.ExecuteNonQuery
                dr = cmd.ExecuteReader
            End With
            User.Show()
            dataform.Hide()
            With dr
                .Read()
                User.username.Text = .Item("NAME")
                User.school.Text = .Item("SCHOOL_TYPE")
                User.student.Text = .Item("STUDENT_TYPE")
                .Close()
            End With
            SessionStart.Show()

            cmd.Parameters.Clear()
            User.userid.Text = TextBox1.Text
            Me.Hide()
            TextBox1.Text = ""
            TextBox2.Text = ""
        Else
            MessageBox.Show("UserID or Password Might be Wrong or You are not connected to internet")
        End If
        con.Close()



    End Sub

    Public Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        myConnectionString = "server=" & Trim(Settings.ip.Text) & ";" _
        & "uid=" & Trim(Settings.dbuser.Text) & ";" _
        & "Password=" & Trim(Settings.dbpass.Text) & ";" _
        & "database=" & Trim(Settings.dbname.Text) & ";"
        Try
            con.ConnectionString = myConnectionString
            con.Open()
        Catch ex As Exception
            MessageBox.Show("You have not uploaded your Config file or you have no internet connection")

        End Try
        con.Close()
    End Sub
End Class
