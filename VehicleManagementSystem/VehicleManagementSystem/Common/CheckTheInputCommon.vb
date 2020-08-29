Public Class CheckTheInputCommon

    Function CheckTheInput(target As String, message As String, title As String) As Boolean

        If String.IsNullOrEmpty(target) Then
            MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        Else
            Return True
        End If

    End Function

    Function OneChkTheInput(firstTarget As String, secondTarget As String, message As String, title As String) As Boolean

        If String.IsNullOrEmpty(firstTarget) AndAlso String.IsNullOrEmpty(secondTarget) Then
            MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        Else
            Return True
        End If

    End Function

    Function IntEquivChk(firstTarget As Integer, secondTarget As Integer, message As String, title As String) As Boolean

        If firstTarget = secondTarget Then
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
