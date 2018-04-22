Imports MySql.Data.MySqlClient
Public Class Table_Settings
    Dim con As New MySql.Data.MySqlClient.MySqlConnection
    Dim myConnectionString As String
    Dim cmd As New MySqlCommand
    Dim cmd1 As New MySqlCommand
    Private Sub CreateDB_Click(sender As Object, e As EventArgs) Handles CreateDB.Click
        myConnectionString = "server=" & Trim(db_settings.ip.Text) & ";" _
    & "uid=" & Trim(db_settings.dbuser.Text) & ";" _
    & "Password=" & Trim(db_settings.dbpass.Text) & ";" _
    & "database=" & Trim(db_settings.dbname.Text) & ";"
        con.ConnectionString = myConnectionString
        Try
            con.Open()
            With cmd
                .Connection = con
                .CommandText = "CREATE TABLE IF NOT EXISTS `candidate` (
                              `ID` int(11) NOT NULL,
                              `IMAGE` longblob,
                              `NAME` varchar(200) DEFAULT NULL,
                              `PORTFOLIO` longtext,
                              `POSITION` varchar(200) DEFAULT NULL,
                              `EMAIL` varchar(100) DEFAULT NULL,
                              `SCHOOL_TYPE` varchar(30) DEFAULT NULL
                            ) ENGINE=InnoDB DEFAULT CHARSET=latin1;
                            CREATE TABLE IF NOT EXISTS `studentlist` (
                              `ID` int(11) NOT NULL,
                              `PASSWORD` varchar(200) NOT NULL,
                              `SCHOOL_TYPE` varchar(200) NOT NULL,
                              `STUDENT_TYPE` varchar(45) NOT NULL,
                              `EMAIL` varchar(200) NOT NULL,
                              `NAME` varchar(200) NOT NULL
                            ) ENGINE=InnoDB DEFAULT CHARSET=latin1;
                            CREATE TABLE IF NOT EXISTS `student_candidate_rel` (
                              `ID` int(11) NOT NULL,
                              `STUDENT_ID` int(11) DEFAULT NULL,
                              `DATE` int(11) DEFAULT NULL,
                              `CANDIDATE_TREASURER_ID` int(11) DEFAULT NULL,
                              `CANDIDATE_SOSE_REP` int(11) DEFAULT NULL,
                              `CANDIDATE_SOMB_REP_ID` int(11) DEFAULT NULL,
                              `CANDIDATE_SECRETARY_ID` int(11) DEFAULT NULL,
                              `CANDIDATE_PRESIDENT_ID` int(11) DEFAULT NULL,
                              `CANDIDATE_INTERNATIONAL_STUDENT_REP_ID` int(11) DEFAULT NULL,
                              `CANDIDATE_DEPUTY_PRESIDENT_ID` int(11) DEFAULT NULL
                            ) ENGINE=InnoDB DEFAULT CHARSET=latin1;
                            ALTER TABLE `candidate`
                             ADD PRIMARY KEY (`ID`);
                            ALTER TABLE `studentlist`
                             ADD PRIMARY KEY (`ID`);
                            ALTER TABLE `student_candidate_rel`
                             ADD PRIMARY KEY (`ID`);"

                cmd.ExecuteNonQuery()

            End With
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        con.Close()
    End Sub
End Class