Public Class AccountInsertSql

    Function AccountInsert(id As String, password As String) As String

        Dim sql As New System.Text.StringBuilder()

        sql.Append("INSERT INTO T_ACCOUNT ")
        sql.Append("VALUES(")
        sql.Append("'" + id + "', ")
        sql.Append("'" + password + "', ")
        sql.Append("'user1', ")
        sql.Append("GETDATE(), ")
        sql.Append("'user1', ")
        sql.Append("GETDATE()")
        sql.Append(");")

        Return sql.ToString

    End Function

End Class
