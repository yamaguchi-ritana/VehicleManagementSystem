Public Class SystemManagementForm
    Private Sub BtnAccountClick(sender As Object, e As EventArgs) Handles btnAccount.Click

        Dim accountForm As New AccountForm()

        accountForm.ShowDialog(Me)

        accountForm.Dispose()

    End Sub
End Class