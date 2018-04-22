Imports MySql.Data.MySqlClient
Imports System.IO
Public Class Deputy_President
    Dim con As New MySql.Data.MySqlClient.MySqlConnection
    Dim myConnectionString As String
    Dim cmd, cmd1 As New MySqlCommand
    Dim result As Integer
    Dim da As New MySqlDataAdapter
    Dim dr As MySqlDataReader
    Dim ds As New DataTable
    Dim bs As New BindingSource
    Private Sub Deputy_President_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
        'president
        Try
            With cmd
                .Connection = con
                .CommandText = "Select `NAME`, `ID` FROM `candidate` WHERE POSITION= 'DEPTY PRESIDENT' "
            End With
            With ListBox1
                da.SelectCommand = cmd
                da.Fill(ds)
                .DataSource = ds
                .DisplayMember = "NAME"
                .ValueMember = "ID"

            End With

            cmd.Parameters.Clear()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub nextfrm_Click(sender As Object, e As EventArgs) Handles nextfrm.Click
        If CID.Text = "" Then
            MessageBox.Show("Select an Option")
        Else
            dataform.dpresident.Text = CID.Text
            dataform.dpres.Text = CSNAME.Text
            Seceretary.Show()
            Me.Close()
        End If

    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged



    End Sub
    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub ListBox1_MouseClick(sender As Object, e As MouseEventArgs) Handles ListBox1.MouseClick, Label3.MouseClick
        Try
            CID.Text = ListBox1.SelectedValue.ToString
            CSNAME.Text = ListBox1.Text
        Catch ex As Exception
            MessageBox.Show("Nothing Selected")
        End Try
        con.Open()
        Try
            With cmd
                .Connection = con
                .CommandText = "SELECT IMAGE FROM candidate WHERE ID = " & CID.Text & ""
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
        con.Close()
    End Sub

    Private Sub cancel_Click(sender As Object, e As EventArgs) Handles cancel.Click
        President_vote.Show()
        Me.Close()

    End Sub

End Class