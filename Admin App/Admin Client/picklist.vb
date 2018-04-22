Imports MySql.Data.MySqlClient
Public Class picklist
    Dim con As New MySql.Data.MySqlClient.MySqlConnection
    Dim myConnectionString As String
    Dim cmd As New MySqlCommand
    Dim cmd1 As New MySqlCommand
    Dim result As Integer
    Dim da As New MySqlDataAdapter
    Dim ds As New DataTable
    Dim bs As New BindingSource
    Private Sub picklist_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        myConnectionString = "server=" & Trim(db_settings.ip.Text) & ";" _
    & "uid=" & Trim(db_settings.dbuser.Text) & ";" _
    & "Password=" & Trim(db_settings.dbpass.Text) & ";" _
    & "database=" & Trim(db_settings.dbname.Text) & ";"
        con.ConnectionString = myConnectionString
        ds.Clear()
        Try
            DataGridView1.RowTemplate.Height = 25
            con.Open()
            With cmd
                .Connection = con
                .CommandText = "SELECT * FROM `studentlist`"
            End With
            da.SelectCommand = cmd
            da.Fill(ds)
            bs.DataSource = ds
            DataGridView1.DataSource = bs
            da.Update(ds)
            DataGridView1.Refresh()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        con.Close()
    End Sub

    Private Sub submit_Click(sender As Object, e As EventArgs) Handles submit.Click
        StudentSearch.Show()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Try
            Dim row As DataGridViewRow
            row = Me.DataGridView1.Rows(e.RowIndex)
            main_activity.CID.Text = row.Cells("ID").Value.ToString
            main_activity.CNAME.Text = row.Cells("NAME").Value.ToString
            main_activity.CMAIL.Text = row.Cells("EMAIL").Value.ToString
            main_activity.CSTYPE.Text = row.Cells("SCHOOL_TYPE").Value.ToString
            main_activity.Show()


        Catch ex As Exception

        End Try

    End Sub
End Class