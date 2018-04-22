Imports MySql.Data.MySqlClient
Imports System.IO
Public Class VoteComplete
    Dim con As New MySql.Data.MySqlClient.MySqlConnection
    Dim myConnectionString As String
    Dim cmd, cmd1 As New MySqlCommand
    Dim result As Integer
    Dim da As New MySqlDataAdapter
    Dim dr As MySqlDataReader
    Dim ds As New DataTable
    Dim bs As New BindingSource
    Private Sub VoteComplete_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
        pres.Text = dataform.pres.Text
        dpres.Text = dataform.dpres.Text
        sec.Text = dataform.sec.Text
        ter.Text = dataform.tre.Text
        irep.Text = dataform.irepn.Text
        If dataform.SOSE.Text = "" Then
            Label6.Text = "SOMB Representative"
            reps.Text = dataform.sombn.Text
        Else
            reps.Text = dataform.sosen.Text
        End If
        If dataform.irep.Text = "" Then
            Label7.Hide()
            irep.Hide()
        End If
    End Sub

    Private Sub cancel_Click(sender As Object, e As EventArgs) Handles cancel.Click
        Me.Close()
        dataform.Close()
        User.Close()
        Login.Show()
    End Sub

    Private Sub nextfrm_Click(sender As Object, e As EventArgs) Handles nextfrm.Click
        Try
            con.Open()
            With cmd
                .Connection = con
                .CommandText = "INSERT INTO `student_candidate_rel`(`STUDENT_ID`, `CANDIDATE_PRESIDENT_ID`, `CANDIDATE_DEPUTY_PRESIDENT_ID`, `CANDIDATE_SECRETARY_ID`, `CANDIDATE_TREASURER_ID`, `CANDIDATE_SOMB_REP_ID`, `CANDIDATE_INTERNATIONAL_STUDENT_REP_ID`, `CANDIDATE_SOSE_REP`) " &
                                "VALUES ('" & User.userid.Text & "', '" & dataform.president.Text & "', '" & dataform.dpresident.Text & "', '" & dataform.seceretary.Text & "', '" & dataform.treasurer.Text & "', '" & dataform.SOMB.Text & "', '" & dataform.irep.Text & "', '" & dataform.SOSE.Text & "');"
                result = cmd.ExecuteNonQuery
                If result = 0 Then
                    MsgBox("Something Went Wrong!")
                Else
                    MsgBox("You have Voted successfully!!")
                End If
                Completed.Show()
                con.Close()
                Me.Close()
            End With
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        con.Close()
    End Sub
End Class