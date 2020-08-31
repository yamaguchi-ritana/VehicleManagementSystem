Public Class AccountFormSql

    Function AccountIdSearch(id As String) As String

        Dim sql As New System.Text.StringBuilder()

        sql.Append("BEGIN TRAN ")
        sql.Append("SELECT ")
        sql.Append("* ")
        sql.Append("FROM ")
        sql.Append("t_account ta WITH(TABLOCKX) ")
        sql.Append("WHERE ")
        sql.Append("ta.id = '" + id + "' ")
        sql.Append(";")

        Return sql.ToString

    End Function

    Function AccountIdSearchChk(id As String, updDtTime As String) As String

        Dim sql As New System.Text.StringBuilder()

        sql.Append("BEGIN TRAN ")
        sql.Append("SELECT ")
        sql.Append("* ")
        sql.Append("FROM ")
        sql.Append("t_account ta WITH(TABLOCKX) ")
        sql.Append("WHERE ")
        sql.Append("ta.id = '" + id + "' ")
        sql.Append("AND ")
        sql.Append("ta.update_date_time = '" + updDtTime + "' ")
        sql.Append(";")

        Return sql.ToString

    End Function

    Function AccountAcq() As String

        Dim sql As New System.Text.StringBuilder()

        sql.Append("SELECT ")
        sql.Append("ta.id, ")
        sql.Append("ta.password, ")
        sql.Append("CONVERT(VARCHAR, ta.UPDATE_DATE_TIME, 21) AS update_date_time ")
        sql.Append("FROM ")
        sql.Append("t_account ta ")
        sql.Append("ORDER BY ")
        sql.Append("ta.id ")
        sql.Append(";")

        Return sql.ToString

    End Function

    Function AccountIdOrPwSearch(id As String, password As String) As String

        Dim sql As New System.Text.StringBuilder()

        sql.Append("SELECT ")
        sql.Append("* ")
        sql.Append("FROM ")
        sql.Append("t_account ta ")

        If Not String.IsNullOrEmpty(id) OrElse Not String.IsNullOrEmpty(password) Then
            sql.Append("WHERE ")
        End If

        If Not String.IsNullOrEmpty(id) Then

            sql.Append("ta.id LIKE '%" + id + "%' ")

        End If

        If Not String.IsNullOrEmpty(password) Then

            If Not String.IsNullOrEmpty(id) Then
                sql.Append("AND ")
            End If

            sql.Append("ta.password LIKE '%" + password + "%' ")

        End If

        sql.Append(";")

        Return sql.ToString

    End Function

    Function CommitTran() As String

        Dim sql As New System.Text.StringBuilder()

        sql.Append("COMMIT TRAN ")

        Return sql.ToString

    End Function

    Function AccountInsert(id As String, password As String, userId As String) As String

        Dim sql As New System.Text.StringBuilder()

        sql.Append("INSERT INTO T_ACCOUNT ")
        sql.Append("VALUES(")
        sql.Append("'" + id + "', ")
        sql.Append("'" + password + "', ")
        sql.Append("'" + userId + "', ")
        sql.Append("GETDATE(), ")
        sql.Append("'" + userId + "', ")
        sql.Append("GETDATE()")
        sql.Append(");")
        sql.Append("COMMIT TRAN")

        Return sql.ToString

    End Function

    Function AccountUpd(id As String, password As String, chgId As String, updId As String) As String

        Dim sql As New System.Text.StringBuilder()

        sql.Append("UPDATE ")
        sql.Append("t_account ")
        sql.Append("SET ")
        sql.Append("id =" + "'" + id + "', ")
        sql.Append("password =" + "'" + password + "', ")
        sql.Append("update_id =" + "'" + chgId + "', ")
        sql.Append("update_date_time = " + "GETDATE() ")
        sql.Append("WHERE ")
        sql.Append("id = " + "'" + updId + "' ")
        sql.Append(";")
        sql.Append("COMMIT TRAN ")

        Return sql.ToString

    End Function

End Class
