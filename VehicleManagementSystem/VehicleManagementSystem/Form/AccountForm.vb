Public Class AccountForm

    ' 前画面からの値引き渡し
    Dim frm As New SystemManagementForm

    ' DB接続情報を取得
    Private ReadOnly dbConnInfo As New DBConnInfoCommon

    ' ログインID
    Dim loginId As String

    ' アカウント情報
    Dim acctDtoList As New List(Of AccountDto)

    ' アカウント画面ロード処理
    Private Sub AccountFormLoad(sender As Object, e As EventArgs) Handles MyBase.Load

        ' 全画面からログインIDの引継ぎ
        Me.frm = CType(Me.Owner, SystemManagementForm)
        Me.loginId = Me.frm.Gsid

        ' アカウント画面の表示処理
        Me.AcctFrmLoad()

    End Sub

    Private Sub LblIdClick(sender As Object, e As EventArgs) Handles LblId.Click
        Me.TxtId.Focus()
    End Sub

    Private Sub LblPasswordClick(sender As Object, e As EventArgs) Handles LblPassword.Click
        Me.TxtPassword.Focus()
    End Sub

    ' 検索ボタン押下処理
    Private Sub BtnSearchClick(sender As Object, e As EventArgs) Handles btnSearch.Click

        ' sqlの生成
        Dim acctSearchSql As New AccountFormSql
        Dim sql As String = acctSearchSql.AccountIdOrPwSearch(Me.TxtId.Text, Me.TxtPassword.Text)

        ' DBへの接続
        Dim con = New SqlClient.SqlConnection With {
            .ConnectionString = Me.dbConnInfo.GetDBConnInfo
        }

        Try

            ' コネクションの接続
            con.Open()

            ' sql実行準備の設定
            Dim command As New SqlClient.SqlCommand With {
                .Connection = con,
                .CommandType = CommandType.Text,
                .CommandText = sql
            }

            ' sqlの結果を取得する
            Dim sdr As SqlClient.SqlDataReader
            sdr = command.ExecuteReader()

            ' sqlの設定解放
            command.Dispose()

            ' データグリッドの行数を初期化
            Me.gridSearchResults.RowCount = 1

            ' データグリッドの行数
            Dim rowIndex As Integer

            ' データのの読み込み
            While sdr.Read

                ' 1行追加
                Me.gridSearchResults.Rows.Add()

                ' アカウントの情報の保存
                Dim accountDto As New AccountDto With {
                    .GsRowIndex = rowIndex,
                    .GsId = sdr("id"),
                    .GsPw = sdr("password")
                }
                Me.acctDtoList.Add(accountDto)

                ' sqlの結果をデータグリッドに設定
                Me.gridSearchResults.Rows(rowIndex).Cells(0).Value = sdr("id")
                Me.gridSearchResults.Rows(rowIndex).Cells(1).Value = sdr("password")

                ' データグリッドの行数のカウントアップ
                rowIndex += 1

            End While

        Finally

            ' コネクションの接続確認
            If con.State <> ConnectionState.Closed Then

                ' コネクションの破棄
                con.Close()
                con.Dispose()

            End If

        End Try

    End Sub

    ' 追加ボタン処理
    Private Sub BtnAddClick(sender As Object, e As EventArgs) Handles btnAdd.Click

        ' DBへの接続
        Dim con As New SqlClient.SqlConnection With {
            .ConnectionString = Me.dbConnInfo.GetDBConnInfo
        }

        ' メッセージ情報
        Dim msgConst As New MessageConst

        ' アカウントチェックの結果情報
        Dim acctChkResult As New AccountChkResultDto

        ' アカウントチェック処理
        Me.AddExtChk(con, msgConst, acctChkResult)

        ' アカウントの存在チェック
        If acctChkResult.GsProcessEndFlg Then
            Return
        End If

        ' アカウント追加処理
        Me.AddAcct(con, msgConst, acctChkResult.GsCommand)

    End Sub

    ' 更新ボタン押下処理
    Private Sub BtnUpdateClick(sender As Object, e As EventArgs) Handles btnUpdate.Click

        ' DBへの接続
        Dim con As New SqlClient.SqlConnection With {
            .ConnectionString = Me.dbConnInfo.GetDBConnInfo
        }

        ' アカウントチェックの結果情報
        Dim accChkResult As New AccountChkResultDto

        ' メッセージ情報
        Dim msgConst As New MessageConst

        ' アカウントチェック処理
        Me.UpdExtChk(con, msgConst, accChkResult)

        ' アカウントの存在チェック
        If accChkResult.GsProcessEndFlg Then
            Return
        End If

        ' アカウント更新処理
        Me.UpdAcct(con, msgConst, accChkResult)

    End Sub

    ' 削除ボタン押下処理
    Private Sub BtnDelClick(sender As Object, e As EventArgs) Handles BtnDel.Click

        ' DBへの接続
        Dim con As New SqlClient.SqlConnection With {
            .ConnectionString = Me.dbConnInfo.GetDBConnInfo
        }

        ' メッセージ情報
        Dim msgConst As New MessageConst

        ' アカウントチェックの結果情報
        Dim accChkResult As New AccountChkResultDto

        ' アカウントチェック処理
        Me.UpdExtChk(con, msgConst, accChkResult)






        ' アカウント画面の表示処理
        Me.AcctFrmLoad()

    End Sub

    ' アカウント画面ロード処理
    Private Sub AcctFrmLoad()

        ' sqlの生成
        Dim acctSearchSql As New AccountFormSql
        Dim sql As String = acctSearchSql.AccountAcq()

        ' DBへの接続
        Dim con As New SqlClient.SqlConnection With {
            .ConnectionString = Me.dbConnInfo.GetDBConnInfo
        }

        Try

            ' sql実行準備の設定
            Dim command As New SqlClient.SqlCommand With {
                .Connection = con,
                .CommandType = CommandType.Text,
                .CommandText = sql
            }

            ' コネクションの接続
            con.Open()

            ' sqlの結果を取得する
            Dim sdr As SqlClient.SqlDataReader
            sdr = command.ExecuteReader()

            ' 列数を初期化
            Me.gridSearchResults.RowCount = 1

            ' データグリッドの行数
            Dim rowIndex As Integer

            ' データのの読み込み
            While sdr.Read

                ' 1行追加
                Me.gridSearchResults.Rows.Add()

                ' アカウントの情報の保存
                Dim accountDto As New AccountDto With {
                    .GsRowIndex = rowIndex,
                    .GsId = sdr("id"),
                    .GsPw = sdr("password"),
                    .GsUpdDtTime = sdr("update_date_time")
                }
                Me.acctDtoList.Add(accountDto)

                ' sqlの結果をデータグリッドに設定
                Me.gridSearchResults.Rows(rowIndex).Cells(0).Value = sdr("id")
                Me.gridSearchResults.Rows(rowIndex).Cells(1).Value = sdr("password")

                ' データグリッドの行数のカウントアップ
                rowIndex += 1

            End While

        Finally

            ' コネクションの接続確認
            If con.State <> ConnectionState.Closed Then

                ' コネクションの破棄
                con.Close()
                con.Dispose()

            End If

        End Try

    End Sub

    ' アカウントチェック処理
    Private Sub AddExtChk(con As SqlClient.SqlConnection, msgConst As MessageConst, accountChkResult As AccountChkResultDto)

        ' 入力チェック
        Dim chkTheInputCom As New CheckTheInputCommon

        ' txtIdが未入力の場合はエラー
        If Not chkTheInputCom.CheckTheInput(Me.TxtId.Text, msgConst.GetEnterId, msgConst.GetIdInputChkErr) Then
            accountChkResult.GsProcessEndFlg = True
            Return
        End If

        ' txtPasswordが未入力の場合はエラー
        If Not accountChkResult.GsProcessEndFlg AndAlso Not chkTheInputCom.CheckTheInput(Me.TxtPassword.Text, msgConst.GetEnterPw, msgConst.GetPwInputChkErr) Then
            accountChkResult.GsProcessEndFlg = True
            Return
        End If

        ' 追加処理の確認
        Dim result As DialogResult = MessageBox.Show(msgConst.GetAcctAddChk, msgConst.GetAcctAddCfm, MessageBoxButtons.OKCancel, MessageBoxIcon.Question)

        If result = DialogResult.Cancel Then
            accountChkResult.GsProcessEndFlg = True
            Return
        End If

        If accountChkResult.GsProcessEndFlg Then
            ' コネクションの接続確認
            If con.State <> ConnectionState.Closed Then

                ' コネクションの破棄
                con.Close()
                con.Dispose()

            End If
        End If

        ' sqlの生成
        Dim acctSearchSql As New AccountFormSql
        Dim sql As String = acctSearchSql.AccountIdSearch(Me.TxtId.Text)

        Try

            ' コネクションの接続
            con.Open()

            ' sql実行準備の設定
            Dim command As New SqlClient.SqlCommand With {
                .Connection = con,
                .CommandType = CommandType.Text,
                .CommandText = sql
            }

            ' sqlの結果を取得する
            Dim sdr As SqlClient.SqlDataReader
            sdr = command.ExecuteReader()

            ' IDが存在する場合エラー
            If sdr.HasRows Then
                MessageBox.Show(msgConst.GetIdIsIncorrect, msgConst.GetIdChkErr, MessageBoxButtons.OK, MessageBoxIcon.Error)
                accountChkResult.GsProcessEndFlg = True

            End If

            ' sql実行処理の破棄
            sdr.Close()

            ' sql処理の設定の引継ぎ
            accountChkResult.GsCommand = command

        Catch ex As Exception ' Exception処理

            MsgBox(ex.ToString)

        End Try

    End Sub

    ' アカウント追加処理
    Private Sub AddAcct(con As SqlClient.SqlConnection, msgConst As MessageConst, command As SqlClient.SqlCommand)

        ' sqlの生成
        Dim AcctSearchSql As New AccountFormSql
        Dim sql As String = AcctSearchSql.AccountInsert(Me.TxtId.Text, Me.TxtPassword.Text, Me.loginId)

        Try

            ' sql実行準備の設定
            command.CommandText = sql

            ' sqlの実行結果数
            Dim insResult As Integer

            ' sql実行結果数の取得
            insResult = command.ExecuteNonQuery()

            ' sqlの設定解放
            command.Dispose()

            ' 追加処理が成功時に結果を表示
            If 0 < insResult Then
                MessageBox.Show(msgConst.GetAddedAccount, msgConst.GetAddAccount, MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            End If

            ' アカウント画面の初期化
            Me.TxtId.Text = Nothing
            Me.TxtPassword.Text = Nothing

        Finally

            ' コネクションの接続確認
            If con.State <> ConnectionState.Closed Then

                ' コネクションの破棄
                con.Close()
                con.Dispose()

            End If

        End Try

        ' アカウント画面の表示処理
        Me.AcctFrmLoad()

    End Sub

    ' アカウント更新チェック処理
    Private Sub UpdExtChk(con As SqlClient.SqlConnection, msgConst As MessageConst, accountChkResult As AccountChkResultDto)

        ' 入力チェック処理
        Dim chkTheInputCom As New CheckTheInputCommon

        ' txtIdまたはtxtPassword未入力の場合はエラー
        If Not chkTheInputCom.OneChkTheInput(Me.TxtId.Text, Me.TxtPassword.Text, msgConst.GetIdOrPwChk, msgConst.GetIdOrPwChkErr) Then
            accountChkResult.GsProcessEndFlg = True
            Return
        End If

        ' 選択したデータグリッド行
        Dim selectRow As Integer = Me.gridSearchResults.SelectedCells(0).RowIndex

        ' ユーザーを選択していない場合エラー
        If Not chkTheInputCom.IntEquivChk(Me.acctDtoList.Count, selectRow, msgConst.GetUserSlctChk, msgConst.GetUserSlctChkErr) Then
            accountChkResult.GsProcessEndFlg = True
            Return
        End If

        ' 更新処理の確認
        Dim result As DialogResult = MessageBox.Show(msgConst.GetAcctUpdChk, msgConst.GetAcctUpdCfm, MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
        If result = DialogResult.Cancel Then
            accountChkResult.GsProcessEndFlg = True
            Return
        End If

        If accountChkResult.GsProcessEndFlg Then
            ' コネクションの接続確認
            If con.State <> ConnectionState.Closed Then

                ' コネクションの破棄
                con.Close()
                con.Dispose()

            End If
        End If

        ' ロードしたアカウント分処理
        For Each accountDto As AccountDto In Me.acctDtoList

            ' ロードしたアカウントと選択したアカウント
            If accountDto.GsRowIndex = selectRow Then

                ' アカウントチェックの結果情報
                accountChkResult.GsId = accountDto.GsId
                accountChkResult.GsUpdDtTime = accountDto.GsUpdDtTime

            End If

        Next

        ' sqlの生成
        Dim accountSearchSql As New AccountFormSql
        Dim sql As String = accountSearchSql.AccountIdSearchChk(accountChkResult.GsId, accountChkResult.GsUpdDtTime)

        Try

            ' コネクションの接続
            con.Open()

            ' sql実行準備の設定
            Dim command As New SqlClient.SqlCommand With {
                .Connection = con,
                .CommandType = CommandType.Text,
                .CommandText = sql
            }

            ' sqlの結果を取得する
            Dim sdr As SqlClient.SqlDataReader
            sdr = command.ExecuteReader()

            ' 他のユーザーに更新された場合エラー
            If Not sdr.HasRows Then

                ' ロックの解除
                command.CommandText = accountSearchSql.CommitTran

                ' sqlの設定解放
                command.Dispose()

                ' コネクションの接続確認
                If con.State <> ConnectionState.Closed Then

                    ' コネクションの破棄
                    con.Close()
                    con.Dispose()
                End If

                ' 他のユーザーが更新した場合エラー
                MessageBox.Show(msgConst.GetUpdedOtherUserChk, msgConst.GetIdChkErr, MessageBoxButtons.OK, MessageBoxIcon.Error)
                accountChkResult.GsProcessEndFlg = True

            Else

                ' データのの読み込み
                While sdr.Read

                    ' アカウントチェックの結果情報
                    accountChkResult.GsId = sdr("id")
                    accountChkResult.GsPw = sdr("password")

                End While

            End If

            ' sql実行処理の破棄
            sdr.Close()

            ' sql処理の設定の引継ぎ
            accountChkResult.GsCommand = command

        Catch ex As Exception ' Exception処理

            MsgBox(ex.ToString)

        End Try

    End Sub

    ' アカウント追加処理実行
    Private Sub UpdAcct(con As SqlClient.SqlConnection, msgConst As MessageConst, accountChkResult As AccountChkResultDto)

        ' ログインユーザー更新フラグ
        Dim chgLoginFlg As Boolean

        ' 更新ID
        Dim id As String

        ' 更新PW
        Dim pw As String

        ' ログインユーザーの更新
        If Me.loginId = accountChkResult.GsId Then

            chgLoginFlg = True

        End If

        ' ログインユーザーIDの更新ではない
        If String.IsNullOrEmpty(Me.TxtId.Text) Then

            id = accountChkResult.GsId

        Else　' ログインユーザーIDの更新

            id = Me.TxtId.Text

        End If

        ' ログインユーザーPWの更新ではない
        If String.IsNullOrEmpty(Me.TxtPassword.Text) Then

            pw = accountChkResult.GsPw

        Else ' ログインユーザーPWの更新

            pw = Me.TxtPassword.Text

        End If

        ' sqlの結果を取得する
        Dim accountSql As New AccountFormSql
        Dim sql As String = accountSql.AccountUpd(id, pw, Me.loginId, accountChkResult.GsId)

        Try

            ' sql実行準備の設定
            accountChkResult.GsCommand.CommandText = sql

            ' sqlの実行結果数
            Dim insResult As Integer

            ' sql実行結果数の取得
            insResult = accountChkResult.GsCommand.ExecuteNonQuery()

            ' sqlの設定解放
            accountChkResult.GsCommand.Dispose()

            ' 追加処理が成功時に結果を表示
            If 0 < insResult Then
                MessageBox.Show(msgConst.GetUpdedAcct, msgConst.GetUpdAcct, MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            End If

            ' loginIdの更新
            If chgLoginFlg AndAlso Not String.IsNullOrEmpty(Me.TxtId.Text) Then

                Me.loginId = Me.TxtId.Text

            End If

            ' txtId.TextとtxtPassword.Textの初期化
            Me.TxtId.Text = Nothing
            Me.TxtPassword.Text = Nothing

        Finally

            ' コネクションの接続確認
            If con.State <> ConnectionState.Closed Then

                ' コネクションの破棄
                con.Close()
                con.Dispose()

            End If

        End Try

        ' アカウント情報の初期化
        Me.acctDtoList = New List(Of AccountDto)

        ' アカウント画面の表示処理
        Me.AcctFrmLoad()

    End Sub

End Class