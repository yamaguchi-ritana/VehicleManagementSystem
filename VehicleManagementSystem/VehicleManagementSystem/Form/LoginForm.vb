'Imports System.Data.SqlClient

Public Class LoginForm

    Dim id As String

    Public ReadOnly Property Getid() As String
        Get
            Return id
        End Get
    End Property

    Private Sub LblIdClick(sender As Object, e As EventArgs) Handles lblId.Click
        Me.txtId.Focus()
    End Sub

    Private Sub LblPasswordClick(sender As Object, e As EventArgs) Handles lblPassword.Click
        Me.txtPassword.Focus()
    End Sub

    Private Sub BtnLoginClick(sender As Object, e As EventArgs) Handles btnLogin.Click

        Dim chkTheInputCom As New CheckTheInputCommon

        Dim errMsgConst As New MessageConst

        Dim charConst As New CharacterConst

        ' txtIdが未入力の場合はエラー
        If Not chkTheInputCom.CheckTheInput(Me.txtId.Text, errMsgConst.GetEnterId, errMsgConst.GetIdInputChkErr) Then
            Return
        End If

        ' txtPasswordが未入力の場合はエラー
        If Not chkTheInputCom.CheckTheInput(Me.txtPassword.Text, errMsgConst.GetEnterPw, errMsgConst.GetPwInputChkErr) Then
            Return
        End If

        ' txtIdに";"がある場合はエラー
        If Not chkTheInputCom.CharacterCheck(Me.txtId.Text, charConst.GetSemicolon, errMsgConst.GetCannotEnterSemicolonId, errMsgConst.GetIdCharChkErr) Then
            Return
        End If

        ' txtPasswordに";"がある場合はエラー
        If Not chkTheInputCom.CharacterCheck(Me.txtPassword.Text, charConst.GetSemicolon, errMsgConst.GetCannotEnterSemicolonPw, errMsgConst.GetPwCharChkErr) Then
            Return
        End If


        Dim loginFrmSql As New LoginFormSql

        Dim sql As String = loginFrmSql.AcctSearch(Me.txtId.Text, Me.txtPassword.Text)

        ' DB接続情報を取得
        Dim dbConnInfo As New DBConnInfoCommon

        ' DBへの接続
        Dim con As New SqlClient.SqlConnection With {
            .ConnectionString = dbConnInfo.GetDBConnInfo
        }

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

            ' アカウントが存在しない場合エラー
            If Not sr.HasRows Then
                MessageBox.Show(errMsgConst.GetIdOrPwIsIncorrect, errMsgConst.GetAccountChkErr, MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If

            While sr.Read
                Me.id = sr("id")
            End While

        Finally
            ' コネクションの破棄
            If con.State <> ConnectionState.Closed Then

                con.Close()

                con.Dispose()
            End If

        End Try

        ' TOPFormのインスタンスを作成する
        Dim topForm As New TOPForm()

        ' ログイン画面のの非表示
        Me.Hide()

        ' TOP画面を表示する
        ' ここではモーダルダイアログボックスとして表示する
        ' オーナーウィンドウにMeを指定する
        topForm.ShowDialog(Me)

        ' フォームが必要なくなったところで、Disposeを呼び出す
        ' リソースの解放
        topForm.Dispose()

    End Sub

    Private Sub btnEnd_Click(sender As Object, e As EventArgs) Handles btnEnd.Click
        ' アプリケーションの終了
        Application.Exit()
    End Sub

End Class
