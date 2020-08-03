Public Class CheckTheInputCommon

    Function CheckTheInput(target As String, message As String, title As String) As Boolean

        If String.IsNullOrEmpty(target) Then
            MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        Else
            Return True
        End If

    End Function

    Function CharacterCheck(target As String, comparison As String, message As String, title As String) As Boolean

        If target = comparison Then
            MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        Else
            Return True
        End If

    End Function

End Class
