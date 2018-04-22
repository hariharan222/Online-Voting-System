Imports System.IO
Imports MySql.Data.MySqlClient
Public Class Results
    Dim path2 As String = "C:\Program Files\Microsoft Office\Office15\EXCEL.exe"
    Dim con As New MySql.Data.MySqlClient.MySqlConnection
    Dim myConnectionString As String
    Dim cmd As New MySqlCommand
    Dim cmd1 As New MySqlCommand
    Dim result As Integer
    Dim da As New MySqlDataAdapter
    Dim ds As New DataTable
    Dim bs As New BindingSource
    Private Sub Results_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
                .CommandText = "SELECT c.NAME as 'NAME',c.POSITION as 'POSITION',count(sc.ID) as TOTAL
FROM student_candidate_rel sc 
left JOIN candidate c on c.ID=sc.CANDIDATE_PRESIDENT_ID
where c.POSITION='PRESIDENT'
GROUP BY c.NAME

UNION

SELECT c.NAME as 'NAME',c.POSITION as 'POSITION',count(sc.ID) as TOTAL
FROM student_candidate_rel sc 
left JOIN candidate c on c.ID=sc.CANDIDATE_DEPUTY_PRESIDENT_ID
where c.POSITION='DEPTY PRESIDENT'
GROUP BY c.NAME

UNION

SELECT c.NAME as 'NAME',c.POSITION as 'POSITION',count(sc.ID) as TOTAL
FROM student_candidate_rel sc 
left JOIN candidate c on c.ID=sc.CANDIDATE_SECRETARY_ID
where c.POSITION='SECERETARY'
GROUP BY c.NAME

UNION


SELECT c.NAME as 'NAME',c.POSITION as 'POSITION',count(sc.ID) as TOTAL
FROM student_candidate_rel sc 
left JOIN candidate c on c.ID=sc.CANDIDATE_TREASURER_ID
where c.POSITION='TREASURER'
GROUP BY c.NAME

UNION

SELECT c.NAME as 'NAME',c.POSITION as 'POSITION',count(sc.ID) as TOTAL
FROM student_candidate_rel sc 
left JOIN candidate c on c.ID=sc.CANDIDATE_SOMB_REP_ID
where c.POSITION='SOMB REPRESENTATIVE'
GROUP BY c.NAME

UNION


SELECT c.NAME as 'NAME',c.POSITION as 'POSITION',count(sc.ID) as TOTAL
FROM student_candidate_rel sc 
left JOIN candidate c on c.ID=sc.CANDIDATE_SOSE_REP
where c.POSITION='SOSE REPRESENTATIVE'
GROUP BY c.NAME

UNION

SELECT c.NAME as 'NAME',c.POSITION as 'POSITION',count(sc.ID) as TOTAL
FROM student_candidate_rel sc 
left JOIN candidate c on c.ID=sc.CANDIDATE_INTERNATIONAL_STUDENT_REP_ID
where c.POSITION='INTERNATIONAL STUDENT REP'
GROUP BY c.NAME"
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
        DATAGRIDVIEW_TO_EXCEL((DataGridView1)) ' THIS PARAMETER IS YOUR DATAGRIDVIEW
    End Sub

    Private Sub DATAGRIDVIEW_TO_EXCEL(dataGridView1 As DataGridView)
        Try
            Dim DTB = New DataTable, RWS As Integer, CLS As Integer

            For CLS = 0 To dataGridView1.ColumnCount - 1 ' COLUMNS OF DTB
                DTB.Columns.Add(dataGridView1.Columns(CLS).Name.ToString)
            Next

            Dim DRW As DataRow

            For RWS = 0 To dataGridView1.Rows.Count - 1 ' FILL DTB WITH DATAGRIDVIEW
                DRW = DTB.NewRow

                For CLS = 0 To dataGridView1.ColumnCount - 1
                    Try
                        DRW(DTB.Columns(CLS).ColumnName.ToString) = dataGridView1.Rows(RWS).Cells(CLS).Value.ToString
                    Catch ex As Exception

                    End Try
                Next

                DTB.Rows.Add(DRW)
            Next

            DTB.AcceptChanges()
            Dim path As String = My.Computer.FileSystem.SpecialDirectories.MyDocuments & "\Votenow_result.xml"
            Dim DST As New DataSet

            DST.Tables.Add(DTB)
            Dim FLE As String = path ' PATH AND FILE NAME WHERE THE XML WIL BE CREATED (EXEMPLE: C:\REPS\XML.xml)
            DTB.WriteXml(FLE)

            If Exists(path2) = True Then
                Dim EXL As String = "C:\Program Files\Microsoft Office\Office15\EXCEL.exe" ' PATH OF/ EXCEL.EXE IN YOUR MICROSOFT OFFICE
                Shell(Chr(34) & EXL & Chr(34) & " " & Chr(34) & FLE & Chr(34), vbNormalFocus) ' OPEN XML WITH EXCEL
            Else
                Dim EXL As String = "C:\Program Files\Microsoft Office\Office14\EXCEL.exe" ' PATH OF/ EXCEL.EXE IN YOUR MICROSOFT OFFICE
                Shell(Chr(34) & EXL & Chr(34) & " " & Chr(34) & FLE & Chr(34), vbNormalFocus) ' OPEN XML WITH EXCEL

            End If


        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Sub

    Public Shared Function Exists(path3 As String) As Boolean
        Return True
    End Function

    Private Sub closebox_Click(sender As Object, e As EventArgs) Handles closebox.Click
        Me.Close()

    End Sub
End Class