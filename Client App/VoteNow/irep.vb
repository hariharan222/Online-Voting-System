Imports MySql.Data.MySqlClient
Imports System.IO
Public Class irep
    Dim con As New MySql.Data.MySqlClient.MySqlConnection
    Dim myConnectionString As String
    Dim cmd, cmd1 As New MySqlCommand
    Dim result As Integer
    Dim da As New MySqlDataAdapter
    Dim dr As MySqlDataReader
    Dim ds As New DataTable
    Dim bs As New BindingSource
    Private Sub irep_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
                .CommandText = "Select `NAME`, `ID` FROM `candidate` WHERE POSITION= 'INTERNATIONAL STUDENT REP' "
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



    Private Sub cancel_Click(sender As Object, e As EventArgs) Handles cancel.Click
        If User.school.Text = "SOSE" Then
            SOSE.Show()
            Me.Close()
        End If
        If User.school.Text = "CFLS" Then
            SOSE.Show()
            Me.Close()
        End If
        If User.school.Text = "SOMB" Then
            SOMB.Show()
            Me.Close()
        End If


    End Sub

    Private Sub ListBox1_MouseClick(sender As Object, e As MouseEventArgs) Handles ListBox1.MouseClick
        Try
            CID.Text = ListBox1.SelectedValue.ToString
            CSNAME.Text = ListBox1.Text
        Catch ex As Exception
            MsgBox("No Data Available")
        End Try
        'loading picture
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

    Private Sub nextfrm_Click(sender As Object, e As EventArgs) Handles nextfrm.Click
        If CID.Text = "" Then
            MessageBox.Show("Select an Option")
        Else
            dataform.irep.Text = CID.Text
            dataform.irepn.Text = CSNAME.Text

            VoteComplete.Show()
            Me.Close()
        End If

    End Sub
End Class