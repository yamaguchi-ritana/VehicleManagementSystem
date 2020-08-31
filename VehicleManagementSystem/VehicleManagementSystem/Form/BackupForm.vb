Public Class BackupForm
    Private Sub LblBackupDestinationClick(sender As Object, e As EventArgs) Handles lblBackupDestination.Click
        Me.txtPath.Focus()
    End Sub

    Private Sub BtnFaldaSelectionClick(sender As Object, e As EventArgs) Handles btnFaldaSelection.Click

        Dim errMsgConst As New MessageConst

        Dim characterConst As New CharacterConst

        Dim fbd As New FolderBrowserDialog With {
            .Description = errMsgConst.GetCbackupDestination,
            .RootFolder = Environment.SpecialFolder.Desktop,
            .SelectedPath = characterConst.GetCDrive,
            .ShowNewFolderButton = True
        }

        ' ファルダ参照ダイアログを表示
        If fbd.ShowDialog(Me) = DialogResult.OK Then
            Me.txtPath.Text = fbd.SelectedPath
        End If

    End Sub

    Private Sub BtnReturnClick(sender As Object, e As EventArgs) Handles btnReturn.Click
        ' フォームを閉じる
        Me.Close()
    End Sub

    Private Sub BtnExecutionClick(sender As Object, e As EventArgs) Handles btnExecution.Click

        Dim errMsgConst As New MessageConst

        ' 指定したフォルダが存在するか判定
        ' フォルダが存在していない場合はエラー
        If Not System.IO.Directory.Exists(Me.txtPath.Text) Then
            MessageBox.Show(errMsgConst.GetFolderDoesNotExist, errMsgConst.GetFolderExistChk, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Dim backupSql As New BackupFormSql

        Dim characterConst As New CharacterConst

        Dim sql As String = backupSql.Backup(Me.txtPath.Text, Now.ToString(characterConst.GetyyyyMMddHHmmss))

        ' DB接続情報を取得
        Dim dbConnInfo As New DBConnInfoCommon

        ' DBへの接続
        Dim con As New SqlClient.SqlConnection With {
            .ConnectionString = dbConnInfo.GetDBConnInfo
        }

        Dim sqlCommand As New System.Data.SqlClient.SqlCommand(Sql, con)
        Dim adapter As New System.Data.SqlClient.SqlDataAdapter(sqlCommand)
        Try
            ' バックアップ開始
            Dim dt As New DataTable
            adapter.Fill(dt)
        Finally
            ' バックアップSQLの解放
            adapter.Dispose()
            sqlCommand.Dispose()

            con.Close()
            con.Dispose()
        End Try

        Dim messageConst As New MessageConst

        MessageBox.Show(messageConst.GetBackupCreatedSuccess, messageConst.GetCreateBackup)

        ' フォームを閉じる
        Me.Close()

    End Sub
End Class