Public Class AccountForm

    Dim loginId As String

    Dim frm As New SystemManagementForm

    Dim accountDtoList As New List(Of AccountDto)

    Private Sub AccountFormLoad(sender As Object, e As EventArgs) Handles MyBase.Load

        frm = CType(Me.Owner, SystemManagementForm)

        Me.loginId = Me.frm.Gsid

        Me.AccountFormLoad()

    End Sub

    Private Sub BtnSearchClick(sender As Object, e As EventArgs) Handles btnSearch.Click

        Dim accountSearchSql As New AccountSearchSql

        Dim sql As String = accountSearchSql.AccountIdOrPwSearch(Me.txtId.Text, Me.txtPassword.Text)

        ' DB接続情報を取得
        Dim dbConnInfo As New DBConnInfoCommon

        ' DBへの接続
        Dim con As New SqlClient.SqlConnection With {
            .ConnectionString = dbConnInfo.GetDBConnInfo
        }

        Try
            con.Open()

            Dim command As New SqlClient.SqlCommand With {
                .Connection = con,
                .CommandType = CommandType.Text,
                .CommandText = sql
            }

            ' SQLの結果を取得する
            Dim sr As SqlClient.SqlDataReader

            sr = command.ExecuteReader()

            command.Dispose()

            ' 列数を初期化
            Me.gridSearchResults.RowCount = 1

            Dim rowIndex As Integer

            While sr.Read

                '1行追加
                Me.gridSearchResults.Rows.Add()

                Dim accountDto As New AccountDto With {
                    .GsRowIndex = rowIndex,
                    .GsId = sr("id"),
                    .GsPw = sr("password")
                }

                accountDtoList.Add(accountDto)

                Me.gridSearchResults.Rows(rowIndex).Cells(0).Value = sr("id")
                Me.gridSearchResults.Rows(rowIndex).Cells(1).Value = sr("password")

                rowIndex += 1

            End While

        Finally
            ' コネクションの破棄
            If con.State <> ConnectionState.Closed Then

                con.Close()

                con.Dispose()
            End If

        End Try
    End Sub

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

    Private Sub BtnUpdateClick(sender As Object, e As EventArgs) Handles btnUpdate.Click

        Dim chkTheInputCom As New CheckTheInputCommon

        Dim msgConst As New MessageConst

        If String.IsNullOrEmpty(Me.txtId.Text) AndAlso String.IsNullOrEmpty(Me.txtPassword.Text) Then
            ' IDまたはPasswordが未入力の場合エラー
            MessageBox.Show("IDまたはPassword入力して下さい。", "IDまたはPassword入力チェック", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Dim selectRow As Integer = Me.gridSearchResults.SelectedCells(0).RowIndex

        If accountDtoList.Count = selectRow Then
            ' ユーザーを選択していない場合エラー
            MessageBox.Show("ユーザーを選択して下さい。", "ユーザーを選択チェック", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Dim updId As String = ""

        Dim chgLoginFlg As Boolean

        Dim id As String = ""

        Dim pw As String = ""

        For Each accountDto As AccountDto In accountDtoList

            If accountDto.GsRowIndex = selectRow Then

                updId = accountDto.GsId

                If Me.loginId = accountDto.GsId Then

                    chgLoginFlg = True

                End If

                If String.IsNullOrEmpty(Me.txtId.Text) Then
                    id = accountDto.GsId
                Else
                    id = Me.txtId.Text
                End If

                If String.IsNullOrEmpty(Me.txtPassword.Text) Then
                    pw = accountDto.GsPw
                Else
                    pw = Me.txtPassword.Text
                End If

            End If

            If accountDto.GsId = Me.txtId.Text Then

                ' IDが存在する場合エラー
                MessageBox.Show(msgConst.GetIdIsIncorrect, msgConst.GetIdChkErr, MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return

            End If

        Next

        Dim accountSql As New AccountSql

        Dim sql As String = accountSql.AccountUpd(id, pw, Me.loginId, updId)
        ' DB接続情報を取得
        Dim dbConnInfo As New DBConnInfoCommon

        ' DBへの接続
        Dim con As New SqlClient.SqlConnection With {
            .ConnectionString = dbConnInfo.GetDBConnInfo
        }

        con.ConnectionString = dbConnInfo.GetDBConnInfo

        Try
            con.Open()

            Dim command As New SqlClient.SqlCommand With {
                .Connection = con,
                .CommandType = CommandType.Text,
                .CommandText = sql
            }

            Dim insResult As Integer

            insResult = command.ExecuteNonQuery()

            command.Dispose()

            ' 追加処理が成功時に結果を表示
            If 0 < insResult Then
                ' MessageBox.Show(msgConst.GetAddedAccount, msgConst.GetAddAccount, MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            End If

            If chgLoginFlg AndAlso Not String.IsNullOrEmpty(Me.txtId.Text) Then

                Me.loginId = Me.txtId.Text

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
        Me.accountDtoList = New List(Of AccountDto)
        Me.AccountFormLoad()

    End Sub

    Private Function AcctExtChk(con As SqlClient.SqlConnection, msgConst As MessageConst) As Boolean

        Dim chkTheInputCom As New CheckTheInputCommon

        Dim processEndFlg As Boolean

        ' txtIdが未入力の場合はエラー
        If Not chkTheInputCom.CheckTheInput(Me.txtId.Text, msgConst.GetEnterId, msgConst.GetIdInputChkErr) Then
            processEndFlg = True
        End If

        ' txtPasswordが未入力の場合はエラー
        If Not processEndFlg AndAlso Not chkTheInputCom.CheckTheInput(Me.txtPassword.Text, msgConst.GetEnterPw, msgConst.GetPwInputChkErr) Then
            processEndFlg = True
        End If

        Dim accountSearchSql As New AccountSearchSql

        Dim sql As String = accountSearchSql.AccountIdSearch(Me.txtId.Text)

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

        Dim accountInsertSql As New AccountInsertSql

        Dim Sql As String = accountInsertSql.AccountInsert(Me.txtId.Text, Me.txtPassword.Text, Me.loginId)

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

        Me.AccountFormLoad()

    End Sub

    Private Sub AccountFormLoad()

        Dim accountSearchSql As New AccountSearchSql

        Dim sql As String = accountSearchSql.AccountAcq()

        ' DB接続情報を取得
        Dim dbConnInfo As New DBConnInfoCommon

        ' DBへの接続
        Dim con As New SqlClient.SqlConnection With {
            .ConnectionString = dbConnInfo.GetDBConnInfo
        }

        Try
            con.Open()

            Dim command As New SqlClient.SqlCommand With {
                .Connection = con,
                .CommandType = CommandType.Text,
                .CommandText = sql
            }

            ' SQLの結果を取得する
            Dim sr As SqlClient.SqlDataReader

            sr = command.ExecuteReader()

            command.Dispose()

            ' 列数を初期化
            Me.gridSearchResults.RowCount = 1

            Dim rowIndex As Integer

            While sr.Read

                '1行追加
                Me.gridSearchResults.Rows.Add()

                Dim accountDto As New AccountDto With {
                    .GsRowIndex = rowIndex,
                    .GsId = sr("id"),
                    .GsPw = sr("password")
                }

                accountDtoList.Add(accountDto)

                Me.gridSearchResults.Rows(rowIndex).Cells(0).Value = sr("id")
                Me.gridSearchResults.Rows(rowIndex).Cells(1).Value = sr("password")

                rowIndex += 1

            End While

        Finally
            ' コネクションの破棄
            If con.State <> ConnectionState.Closed Then

                con.Close()

                con.Dispose()
            End If

        End Try

    End Sub

End Class