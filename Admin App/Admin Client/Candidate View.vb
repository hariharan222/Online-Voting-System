Imports System.IO
Imports MySql.Data.MySqlClient
Public Class Candidate_View
    Dim con As New MySql.Data.MySqlClient.MySqlConnection
    Dim myConnectionString As String
    Dim cmd As New MySqlCommand
    Dim cmd1 As New MySqlCommand
    Dim result As Integer
    Dim da As New MySqlDataAdapter
    Dim ds, ds2 As New DataTable
    Dim bs As New BindingSource
    Dim reader As MySqlDataReader
    Private Sub Candidate_View_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
                .CommandText = "SELECT ID,NAME,POSITION,EMAIL,SCHOOL_TYPE FROM `candidate`"
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

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        DataGridView1.Refresh()
        ds.Clear()
        con.ConnectionString = myConnectionString
        ds.Clear()
        Try
            DataGridView1.RowTemplate.Height = 25
            con.Open()
            With cmd
                .Connection = con
                .CommandText = "SELECT ID,NAME,POSITION,EMAIL,SCHOOL_TYPE FROM `candidate`"
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

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Dim row As DataGridViewRow
        Try
            row = Me.DataGridView1.Rows(e.RowIndex)
            deleteid.Text = row.Cells("ID").Value.ToString
            CNAME.Text = row.Cells("NAME").Value.ToString
            CID.Text = row.Cells("ID").Value.ToString
            CMAIL.Text = row.Cells("EMAIL").Value.ToString
        Catch ex As Exception

        End Try

        con.Open()
        Try
            With cmd
                .Connection = con
                .CommandText = "SELECT IMAGE FROM candidate WHERE ID = " & deleteid.Text & ""
                cmd.ExecuteNonQuery()
            End With
            Dim imageData As Byte() = DirectCast(cmd.ExecuteScalar(), Byte())
            If Not imageData Is Nothing Then
                Using ms As New MemoryStream(imageData, 0, imageData.Length)
                    ms.Write(imageData, 0, imageData.Length)
                    PictureBox1.Image = Image.FromStream(ms, True)
                End Using
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        cmd.Dispose()
        con.Close()


    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        ds.Clear()
        con.Open()
        Try

            With cmd
                .Connection = con
                .CommandText = "DELETE FROM candidate WHERE ID = " & deleteid.Text & ""
                result = cmd.ExecuteNonQuery
                If result = 0 Then
                    MsgBox("No Data Exist!")
                Else
                    MsgBox("Successfully Deleted!")

                End If
            End With
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        con.Close()
        Try
            DataGridView1.RowTemplate.Height = 25
            con.Open()
            With cmd
                .Connection = con
                .CommandText = "SELECT ID,NAME,POSITION,EMAIL,SCHOOL_TYPE FROM `candidate`"
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

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        cmd.Parameters.Clear()
        Dim text As String
        Portfolio.Show()
        Try
            con.Open()
            With cmd
                .Connection = con
                .CommandText = "SELECT PORTFOLIO FROM `candidate` where ID = '" & CID.Text & "'"
            End With
            reader = cmd.ExecuteReader
            While reader.Read
                Portfolio.RichTextBox1.Text = reader.GetString("PORTFOLIO")
            End While

            cmd.Parameters.Clear()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        con.Close()

    End Sub
End Class