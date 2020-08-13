Public Class SystemManagementForm

    Dim id As String

    Public ReadOnly Property Getid() As String
        Get
            Return id
        End Get
    End Property

    Private Sub SystemManagementFormLoad(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim frm As TOPForm = CType(Me.Owner, TOPForm)

        Me.id = frm.Getid

    End Sub

    Private Sub BtnAccountClick(sender As Object, e As EventArgs) Handles btnAccount.Click

        Dim accountForm As New AccountForm()

        accountForm.ShowDialog(Me)

        accountForm.Dispose()

    End Sub

End Class