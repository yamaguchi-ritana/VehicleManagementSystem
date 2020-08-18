Public Class AccountSql

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

        Return sql.ToString

    End Function

End Class
