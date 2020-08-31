Public Class LoginFormSql

    Function AcctSearch(id As String, password As String) As String

        Dim sql As New System.Text.StringBuilder()

        sql.Append("SELECT ")
        sql.Append("* ")
        sql.Append("FROM ")
        sql.Append("t_account ta ")
        sql.Append("WHERE ")
        sql.Append("ta.id = '" + id + "' ")
        sql.Append("and ta.password = '" + password + "' ")
        sql.Append(";")

        Return sql.ToString

    End Function

End Class
