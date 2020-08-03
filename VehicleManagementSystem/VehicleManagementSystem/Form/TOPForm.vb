Public Class TOPForm

    Private Sub BtnSearchClick(sender As Object, e As EventArgs) Handles btnSearch.Click
        ' SearchFormのインスタンスを作成する
        Dim searchForm As New SearchForm()

        ' ここではモーダルダイアログボックスとして表示する
        ' オーナーウィンドウにMeを指定する
        searchForm.ShowDialog(Me)

        ' フォームが必要なくなったところで、Disposeを呼び出す
        ' リソースの解放
        searchForm.Dispose()
    End Sub

    Private Sub BtnBackupClick(sender As Object, e As EventArgs) Handles btnBackup.Click

        ' BackupFormのインスタンスを作成する
        Dim backupForm As New BackupForm()

        ' ここではモーダルダイアログボックスとして表示する
        ' オーナーウィンドウにMeを指定する
        backupForm.ShowDialog(Me)

        ' フォームが必要なくなったところで、Disposeを呼び出す
        ' リソースの解放
        backupForm.Dispose()

    End Sub

    Private Sub BtnEndClick(sender As Object, e As EventArgs) Handles btnEnd.Click
        ' アプリケーションの終了
        Application.Exit()
    End Sub

    ' フォームのClosingイベントハンドラ
    Private Sub FrmProgressClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        ' アプリケーションの終了
        Application.Exit()
    End Sub

End Class