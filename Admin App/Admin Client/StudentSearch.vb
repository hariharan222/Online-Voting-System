Imports MySql.Data.MySqlClient
Public Class StudentSearch
    Dim con As New MySql.Data.MySqlClient.MySqlConnection
    Dim myConnectionString As String
    Dim cmd As New MySqlCommand
    Dim cmd1 As New MySqlCommand
    Dim result As Integer
    Dim da As New MySqlDataAdapter
    Dim ds As New DataTable
    Dim bs As New BindingSource
    Private Sub Search_Click(sender As Object, e As EventArgs) Handles Search.Click
        If TextBox1.Text <> "" And TextBox2.Text = "" And TextBox3.Text = "" Then
            myConnectionString = "server=" & Trim(db_settings.ip.Text) & ";" _
         & "uid=" & Trim(db_settings.dbuser.Text) & ";" _
         & "Password=" & Trim(db_settings.dbpass.Text) & ";" _
         & "database=" & Trim(db_settings.dbname.Text) & ";"
            con.ConnectionString = myConnectionString
            ds.Clear()
            Try
                picklist.DataGridView1.RowTemplate.Height = 25
                con.Open()
                With cmd
                    .Connection = con
                    .CommandText = "SELECT * FROM `studentlist` where NAME='" & TextBox1.Text & "'"
                End With
                da.SelectCommand = cmd
                da.Fill(ds)
                bs.DataSource = ds
                picklist.DataGridView1.DataSource = bs
                da.Update(ds)
                picklist.DataGridView1.Refresh()
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
                picklist.DataGridView1.RowTemplate.Height = 25
                con.Open()
                With cmd
                    .Connection = con
                    .CommandText = "SELECT * FROM `studentlist` where ID='" & TextBox2.Text & "'"
                End With
                da.SelectCommand = cmd
                da.Fill(ds)
                bs.DataSource = ds
                picklist.DataGridView1.DataSource = bs
                da.Update(ds)
                picklist.DataGridView1.Refresh()
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
                picklist.DataGridView1.RowTemplate.Height = 25
                con.Open()
                With cmd
                    .Connection = con
                    .CommandText = "SELECT * FROM `studentlist` where EMAIL='" & TextBox3.Text & "'"
                End With
                da.SelectCommand = cmd
                da.Fill(ds)
                bs.DataSource = ds
                picklist.DataGridView1.DataSource = bs
                da.Update(ds)
                picklist.DataGridView1.Refresh()
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
        picklist.Show()
        Me.Close()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
    End Sub

    Private Sub StudentSearch_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class