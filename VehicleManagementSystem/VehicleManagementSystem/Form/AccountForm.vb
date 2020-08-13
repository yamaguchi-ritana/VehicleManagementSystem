Public Class AccountForm

    Private Sub BtnInsertClick(sender As Object, e As EventArgs) Handles btnInsert.Click

        Dim accountSearchSql As New AccountSearchSql

        Dim sql As String = accountSearchSql.AccountIdSearch(Me.txtId.Text)

        ' DB接続情報を取得
        Dim dbConnInfo As New DBConnInfoCommon

        ' DBへの接続
        Dim con As New SqlClient.SqlConnection With {
            .ConnectionString = dbConnInfo.GetDBConnInfo
        }

        Dim errMsgConst As New MessageConst

        Dim processEndFlg As Boolean

        Try

            con.Open()

            ' コネクションの指定
            ' コマンドの種類をテキストにする（省略可）
            ' 実行するSQLを指定
            Dim command As New SqlClient.SqlCommand With {
                .Connection = con,
                .CommandType = CommandType.Text,
                .CommandText = sql
            }

            ' SQLの結果を取得する
            Dim sr As SqlClient.SqlDataReader

            sr = command.ExecuteReader()

            command.Dispose()

            ' IDが存在する場合エラー
            If sr.HasRows Then
                MessageBox.Show(errMsgConst.GetIdIsIncorrect, errMsgConst.GetIdChkErr, MessageBoxButtons.OK, MessageBoxIcon.Error)
                processEndFlg = True
            End If

        Finally
            ' コネクションの破棄
            If con.State <> ConnectionState.Closed Then

                con.Close()

                con.Dispose()

            End If

        End Try

        If processEndFlg Then
            Return
        End If

        Dim accountInsertSql As New AccountInsertSql

        sql = accountInsertSql.AccountInsert(Me.txtId.Text, Me.txtPassword.Text)

        con.ConnectionString = dbConnInfo.GetDBConnInfo

        Try

            con.Open()

            Dim command As New SqlClient.SqlCommand With {
                .Connection = con,
                .CommandType = CommandType.Text,
                .CommandText = sql
            }

            command.ExecuteNonQuery()

            command.Dispose()

        Finally
            ' コネクションの破棄
            If con.State <> ConnectionState.Closed Then

                con.Close()

                con.Dispose()
            End If

        End Try

    End Sub

End Class