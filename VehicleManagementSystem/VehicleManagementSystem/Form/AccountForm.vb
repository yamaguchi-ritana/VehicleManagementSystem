Public Class AccountForm

    Private Sub BtnInsertClick(sender As Object, e As EventArgs) Handles btnInsert.Click

        ' DB接続情報を取得
        Dim dbConnInfo As New DBConnInfoCommon

        ' DBへの接続
        Dim con As New SqlClient.SqlConnection With {
            .ConnectionString = dbConnInfo.GetDBConnInfo
        }

        Dim msgConst As New MessageConst

        ' アカウントの存在チェック
        If Me.AcctExtChk(con, msgConst) Then
            Return
        End If

        Me.AddAcct(dbConnInfo, con, msgConst)

    End Sub

    Private Function AcctExtChk(con As SqlClient.SqlConnection, msgConst As MessageConst) As Boolean

        Dim accountSearchSql As New AccountSearchSql

        Dim sql As String = accountSearchSql.AccountIdSearch(Me.txtId.Text)

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
                MessageBox.Show(msgConst.GetIdIsIncorrect, msgConst.GetIdChkErr, MessageBoxButtons.OK, MessageBoxIcon.Error)
                processEndFlg = True
            End If

        Finally
            ' コネクションの破棄
            If con.State <> ConnectionState.Closed Then

                con.Close()

                con.Dispose()

            End If

        End Try

        Return processEndFlg

    End Function

    Private Sub AddAcct(dbConnInfo As DBConnInfoCommon, con As SqlClient.SqlConnection, msgConst As MessageConst)

        Dim frm As SystemManagementForm = CType(Me.Owner, SystemManagementForm)

        Dim accountInsertSql As New AccountInsertSql

        Dim Sql As String = accountInsertSql.AccountInsert(Me.txtId.Text, Me.txtPassword.Text, frm.Getid)

        con.ConnectionString = dbConnInfo.GetDBConnInfo

        Try
            con.Open()

            Dim command As New SqlClient.SqlCommand With {
                .Connection = con,
                .CommandType = CommandType.Text,
                .CommandText = Sql
            }

            Dim insResult As Integer

            insResult = command.ExecuteNonQuery()

            command.Dispose()

            ' 追加処理が成功時に結果を表示
            If 0 < insResult Then
                MessageBox.Show(msgConst.GetAddedAccount, msgConst.GetAddAccount, MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            End If

            Me.txtId.Text = Nothing
            Me.txtPassword.Text = Nothing

        Finally
            ' コネクションの破棄
            If con.State <> ConnectionState.Closed Then

                con.Close()

                con.Dispose()
            End If

        End Try

    End Sub

End Class