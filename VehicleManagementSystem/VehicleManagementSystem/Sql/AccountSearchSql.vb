Public Class AccountSearchSql

    Function LoginAccountPwSearch(id As String, password As String) As String

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

    Function AccountIdSearch(id As String) As String

        Dim sql As New System.Text.StringBuilder()

        sql.Append("SELECT ")
        sql.Append("* ")
        sql.Append("FROM ")
        sql.Append("t_account ta ")
        sql.Append("WHERE ")
        sql.Append("ta.id = '" + id + "' ")
        sql.Append(";")

        Return sql.ToString

    End Function


    Function AccountAcq() As String

        Dim sql As New System.Text.StringBuilder()

        sql.Append("SELECT ")
        sql.Append("* ")
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

End Class
