Imports MySql.Data.MySqlClient
Public Class Advanced_Search
    Dim con As New MySql.Data.MySqlClient.MySqlConnection
    Dim myConnectionString As String
    Dim cmd As New MySqlCommand
    Dim cmd1 As New MySqlCommand
    Dim result As Integer
    Dim da As New MySqlDataAdapter
    Dim ds As New DataTable
    Dim bs As New BindingSource
    Private Sub Search_Click(sender As Object, e As EventArgs) Handles Search.Click

        Dim name As String
        If TextBox1.Text <> "" And TextBox2.Text = "" And TextBox3.Text = "" Then
            myConnectionString = "server=" & Trim(db_settings.ip.Text) & ";" _
         & "uid=" & Trim(db_settings.dbuser.Text) & ";" _
         & "Password=" & Trim(db_settings.dbpass.Text) & ";" _
         & "database=" & Trim(db_settings.dbname.Text) & ";"
            con.ConnectionString = myConnectionString
            ds.Clear()
            Try
                main_activity.DataGridView1.RowTemplate.Height = 25
                con.Open()
                With cmd
                    name = "%" & TextBox1.Text & "%"
                    MessageBox.Show(name)
                    .Connection = con
                    .CommandText = "SELECT * FROM `studentlist` where NAME LIKE " & name & " ORDER BY `ID` ASC"
                End With
                da.SelectCommand = cmd
                da.Fill(ds)
                bs.DataSource = ds
                main_activity.DataGridView1.DataSource = bs
                da.Update(ds)
                main_activity.DataGridView1.Refresh()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
            con.Close()
        End If
        If TextBox1.Text = "" And TextBox2.Text <> "" And TextBox3.Text = "" Then
            myConnectionString = "server=" & Trim(db_settings.ip.Text) & ";" _
         & "uid=" & Trim(db_settings.dbuser.Text) & ";" _
         & "Password=" & Trim(db_settings.dbpass.Text) & ";" _
         & "database=" & Trim(db_settings.dbname.Text) & ";"
            con.ConnectionString = myConnectionString
            ds.Clear()
            Try
                main_activity.DataGridView1.RowTemplate.Height = 25
                con.Open()
                With cmd
                    .Connection = con
                    .CommandText = "SELECT * FROM `studentlist` where ID='" & TextBox2.Text & "'"
                End With
                da.SelectCommand = cmd
                da.Fill(ds)
                bs.DataSource = ds
                main_activity.DataGridView1.DataSource = bs
                da.Update(ds)
                main_activity.DataGridView1.Refresh()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
            con.Close()
        End If
        If TextBox1.Text = "" And TextBox2.Text = "" And TextBox3.Text <> "" Then
            myConnectionString = "server=" & Trim(db_settings.ip.Text) & ";" _
         & "uid=" & Trim(db_settings.dbuser.Text) & ";" _
         & "Password=" & Trim(db_settings.dbpass.Text) & ";" _
         & "database=" & Trim(db_settings.dbname.Text) & ";"
            con.ConnectionString = myConnectionString
            ds.Clear()
            Try
                main_activity.DataGridView1.RowTemplate.Height = 25
                con.Open()
                With cmd
                    .Connection = con
                    .CommandText = "SELECT * FROM `studentlist` where EMAIL='" & TextBox3.Text & "'"
                End With
                da.SelectCommand = cmd
                da.Fill(ds)
                bs.DataSource = ds
                main_activity.DataGridView1.DataSource = bs
                da.Update(ds)
                main_activity.DataGridView1.Refresh()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
            con.Close()
        End If
        If TextBox1.Text = "" And TextBox2.Text = "" And TextBox3.Text = "" Then
            MsgBox("Enter something to search")
        End If
        If TextBox1.Text <> "" And TextBox2.Text <> "" And TextBox3.Text <> "" Then
            MsgBox("Enter data at one textfield only")
        End If
    End Sub
End Class