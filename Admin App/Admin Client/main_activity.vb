Imports MySql.Data.MySqlClient
Public Class main_activity
    Dim con As New MySql.Data.MySqlClient.MySqlConnection
    Dim myConnectionString As String
    Dim cmd As New MySqlCommand
    Dim cmd1 As New MySqlCommand
    Dim result As Integer
    Dim da As New MySqlDataAdapter
    Dim ds As New DataTable
    Dim bs As New BindingSource
    Public Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
                .CommandText = "SELECT * FROM studentlist"
            End With
            da.SelectCommand = cmd
            da.Fill(ds)
            bs.DataSource = ds
            DataGridView1.DataSource = bs
            da.Update(ds)
            DataGridView1.Refresh()
        Catch ex As Exception
            MessageBox.Show("Cannot find server, please check your Database Settings")

        End Try
        con.Close()
    End Sub
    Private Sub PictureBox7_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub
    Private Sub PictureBox10_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Private Sub PictureBox13_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub
    Private Sub EXITToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EXITToolStripMenuItem.Click
        Me.Close()
    End Sub
    Private Sub SETTINGSToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles SETTINGSToolStripMenuItem.Click
        db_settings.Show()
    End Sub

    Public Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub submit_Click(sender As Object, e As EventArgs) Handles submit.Click
        Try
            con.Open()

            With cmd
                .Connection = con
                .CommandText = "INSERT INTO studentlist (`ID`, `PASSWORD`, `SCHOOL_TYPE`, `STUDENT_TYPE`, `EMAIL`, `NAME`) " &
                                "VALUES ('" & sid.Text & "', '" & spass.Text & "', '" & sctype.Text & "', '" & sttype.Text & "', '" & email.Text & "', '" & sname.Text & "');"
                result = cmd.ExecuteNonQuery
                If result = 0 Then
                    MsgBox("Unable to Update. Check Server Status or Check Your Data")
                Else
                    MsgBox("Successfully saved!")
                End If
            End With
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        con.Close()
        ds.Clear()
    End Sub
    Private Sub Button8_Click(sender As Object, e As EventArgs)
        DataGridView1.DataSource = Nothing
    End Sub

    Private Sub search_KeyDown(sender As Object, e As KeyEventArgs) Handles searchbox.KeyDown
        ds.Clear()
        Try
            DataGridView1.RowTemplate.Height = 25
            con.Open()
            With cmd
                .Connection = con
                .CommandText = "SELECT * FROM studentlist where ID = '" & searchbox.Text & "'"
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

    Private Sub CREATETABLESToolStripMenuItem_Click(sender As Object, e As EventArgs)


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            OpenFileDialog1.Filter = "JPEG|*.jpg"
            If OpenFileDialog1.ShowDialog = DialogResult.OK Then
                candimage.Image = Image.FromFile(OpenFileDialog1.FileName)
                candimage.SizeMode = PictureBoxSizeMode.StretchImage
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Try



            Dim msstream As New System.IO.MemoryStream()
            candimage.Image.Save(msstream, System.Drawing.Imaging.ImageFormat.Jpeg)
            Dim arrImage() As Byte = msstream.GetBuffer()
            msstream.Close()
            con.Open()
            With cmd
                .Connection = con
                .CommandText = "INSERT INTO `candidate` (`ID`, `NAME`, `POSITION`, `EMAIL`, `SCHOOL_TYPE` , `IMAGE`) " &
                                "VALUES ('" & CID.Text & "', '" & CNAME.Text & "', '" & CPOS.Text & "','" & CMAIL.Text & "','" & CSTYPE.Text & "',@Image);"
                .Parameters.AddWithValue("@Image", arrImage)

                result = cmd.ExecuteNonQuery
                .Parameters.Clear()

                If result = 0 Then
                    MsgBox("Data has been Inserted!")
                Else
                    MsgBox("Successfully saved!")
                End If
            End With
        Catch ex As Exception
            cmd.Parameters.Clear()
            MsgBox(ex.Message)
        End Try
        con.Close()

        CID.Text = ""
        CNAME.Text = ""
        CPOS.Text = ""
        CMAIL.Text = ""
        CSTYPE.Text = ""
        candimage.Image = Nothing


    End Sub



    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Dim row As DataGridViewRow

        Try
            row = Me.DataGridView1.Rows(e.RowIndex)
            deleteid.Text = row.Cells("ID").Value.ToString
            sname.Text = row.Cells("NAME").Value.ToString
            sid.Text = row.Cells("ID").Value.ToString
            email.Text = row.Cells("EMAIL").Value.ToString
            spass.Text = row.Cells("PASSWORD").Value.ToString

        Catch ex As Exception

        End Try

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub TabPage3_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs)
        Candidate_View.Show()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Candidate_View.Show()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        picklist.Show()
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Search.Show()




    End Sub

    Private Sub Button7_Click_1(sender As Object, e As EventArgs)
        Results.Show()

    End Sub

    Private Sub Button8_Click_1(sender As Object, e As EventArgs) Handles Button8.Click
        ds.Clear()
        con.Open()
        Try

            With cmd
                .Connection = con
                .CommandText = "DELETE FROM studentlist WHERE ID = " & deleteid.Text & ""
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
                .CommandText = "SELECT * FROM studentlist"
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

    Private Sub Button4_Click_1(sender As Object, e As EventArgs) Handles Button4.Click
        ds.Clear()
        Try
            DataGridView1.RowTemplate.Height = 25
            con.Open()
            With cmd
                .Connection = con
                .CommandText = "SELECT * FROM studentlist"
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

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        End

    End Sub

    Private Sub STUDENTLISTToolStripMenuItem_Click(sender As Object, e As EventArgs)
        TabControl1.SelectedIndex = 1



    End Sub

    Private Sub CreateTableToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CreateTableToolStripMenuItem.Click
        Table_Settings.Show()
    End Sub

    Private Sub RESULTSToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RESULTSToolStripMenuItem.Click
        Results.Show()

    End Sub
End Class
