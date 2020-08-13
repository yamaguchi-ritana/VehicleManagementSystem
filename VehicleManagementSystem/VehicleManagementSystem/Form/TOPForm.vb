Public Class TOPForm

    Dim id As String

    Public ReadOnly Property Getid() As String
        Get
            Return id
        End Get
    End Property

    Private referDate As DateTime

    Private Sub TOPFormLoad(sender As Object, e As EventArgs) Handles MyBase.Load, lblToday.DoubleClick

        Dim frm As LoginForm = CType(Me.Owner, LoginForm)

        Me.id = frm.Getid

        Dim characterConst As New CharacterConst

        Dim dtNow As DateTime = System.DateTime.Now

        Me.referDate = dtNow

        Dim sb As New System.Text.StringBuilder()

        sb.Append(dtNow.ToString(characterConst.GetyyyyMMddToJp))
        sb.Append(characterConst.GetHalfSpace)
        sb.Append(characterConst.GetHalfParenthesesStr)
        sb.Append(dtNow.ToString(characterConst.GetdddToJp))
        sb.Append(characterConst.GetHalfParenthesesEnd)

        Me.lblToday.Text = sb.ToString

        Me.CldCreateProc(dtNow)

    End Sub

    Private Sub BtnLastMoClick(sender As Object, e As EventArgs) Handles btnLastMo.Click

        Me.CldClearProc()

        Dim lastMo As DateTime = referDate

        Dim changeMo As DateTime = lastMo.AddMonths(-1).AddDays(0).ToString()

        Me.referDate = changeMo

        Me.CldCreateProc(changeMo)

    End Sub

    Private Sub BtnNextMoClick(sender As Object, e As EventArgs) Handles btnNextMo.Click

        Me.CldClearProc()

        Dim nextMo As DateTime = referDate

        Dim changeMo As DateTime = nextMo.AddMonths(+1).AddDays(0).ToString()

        Me.referDate = changeMo

        Me.CldCreateProc(changeMo)

    End Sub

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

    Private Sub btnSysMgtClick(sender As Object, e As EventArgs) Handles btnSysMgt.Click

        Dim systemManagementForm As New SystemManagementForm()

        systemManagementForm.ShowDialog(Me)

        systemManagementForm.Dispose()

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

    Private Sub CldClearProc()

        Me.lblCldZero.Text = Nothing
        Me.lblCldOne.Text = Nothing
        Me.lblCldTwo.Text = Nothing
        Me.lblCldThree.Text = Nothing
        Me.lblCldFour.Text = Nothing
        Me.lblCldFive.Text = Nothing

        Me.lblCldTwentyEight.Text = Nothing
        Me.lblCldTwentyNine.Text = Nothing
        Me.lblCldThirty.Text = Nothing
        Me.lblCldThirtyOne.Text = Nothing
        Me.lblCldThirtyTwo.Text = Nothing
        Me.lblCldThirtyThree.Text = Nothing
        Me.lblCldThirtyFour.Text = Nothing
        Me.lblCldThirtyFive.Text = Nothing
        Me.lblCldThirtySix.Text = Nothing
        Me.lblCldThirtySeven.Text = Nothing
        Me.lblCldThirtyEight.Text = Nothing
        Me.lblCldThirtyNine.Text = Nothing
        Me.lblCldForty.Text = Nothing
        Me.lblCldFortyOne.Text = Nothing

    End Sub

    ' フォームのClosingイベントハンドラ
    Private Sub FrmProgressClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        ' アプリケーションの終了
        Application.Exit()
    End Sub

    Private Sub CldCreateProc(dtNow As DateTime)

        Dim charConst As New CharacterConst

        Dim strDt As DateTime = DateTime.Parse(dtNow.ToString(charConst.GetYrSlashMo) + charConst.GetSlashZeroOne)

        Dim strWeek As String = strDt.ToString(charConst.GetdddToJp)

        Dim strPosition As Integer

        Me.SetCld(strPosition, strWeek, charConst, strDt)

    End Sub

    Private Sub SetCld(strPosition As Integer, strWeek As String, charConst As CharacterConst, strDt As DateTime)

        strPosition = Me.GetbeginDay(strWeek, charConst)

        Dim lblCld() As String = {"lblCldZero", "lblCldOne", "lblCldTwo", "lblCldThree", "lblCldFour", "lblCldFive", "lblCldSix", "lblCldSeven", "lblCldEight", "lblCldNine", "lblCldTen", "lblCldEleven", "lblCldTwelve", "lblCldThirteen", "lblCldFourteen", "lblCldFifteen", "lblCldSixteen", "lblCldSeventeen", "lblCldEighteen", "lblCldNineteen", "lblCldTwenty", "lblCldTwentyOne", "lblCldTwentyTwo", "lblCldTwentyThree", "lblCldTwentyFour", "lblCldTwentyFive", "lblCldTwentySix", "lblCldTwentySeven", "lblCldTwentyEight", "lblCldTwentyNine", "lblCldThirty", "lblCldThirtyOne", "lblCldThirtyTwo", "lblCldThirtyThree", "lblCldThirtyFour", "lblCldThirtyFive", "lblCldThirtySix", "lblCldThirtySeven", "lblCldThirtyEight", "lblCldThirtyNine", "lblCldForty", "lblCldFortyOne"}

        Dim day As Integer

        Dim endDt As DateTime = strDt.AddMonths(1).AddDays(-1).ToString()

        Me.SetThisMo(lblCld, day, endDt, charConst, strPosition)

        Dim lastMo As Integer = CInt(endDt.ToString(charConst.Getdd))

        Me.SetLastMo(lastMo)

        Dim nextMo As Integer

        Me.SetNextMo(nextMo)

    End Sub

    Private Function GetbeginDay(strWeek As String, charConst As CharacterConst) As Integer

        If (strWeek = charConst.GetSunday) Then
            Return 0
        ElseIf (strWeek = charConst.GetMonday) Then
            Return 1
        ElseIf (strWeek = charConst.GetTuesday) Then
            Return 2
        ElseIf (strWeek = charConst.GetWednesday) Then
            Return 3
        ElseIf (strWeek = charConst.GetThursday) Then
            Return 4
        ElseIf (strWeek = charConst.GetFriday) Then
            Return 5
        Else
            Return 6
        End If

    End Function

    Private Sub SetThisMo(lblCld() As String, day As Integer, endDt As DateTime, charConst As CharacterConst, strPosition As Integer)

        For index = 0 To lblCld.Count - 1
            If day = CInt(endDt.ToString(charConst.Getdd)) Then
                Exit For
            End If
            If strPosition <= index Then

                day += 1

                If Me.lblCldZero.Name = lblCld(index).ToString Then
                    Me.lblCldZero.Text = day
                ElseIf Me.lblCldOne.Name = lblCld(index).ToString Then
                    Me.lblCldOne.Text = day
                ElseIf Me.lblCldTwo.Name = lblCld(index).ToString Then
                    Me.lblCldTwo.Text = day
                ElseIf Me.lblCldThree.Name = lblCld(index).ToString Then
                    Me.lblCldThree.Text = day
                ElseIf Me.lblCldFour.Name = lblCld(index).ToString Then
                    Me.lblCldFour.Text = day
                ElseIf Me.lblCldFive.Name = lblCld(index).ToString Then
                    Me.lblCldFive.Text = day
                ElseIf Me.lblCldSix.Name = lblCld(index).ToString Then
                    Me.lblCldSix.Text = day
                ElseIf Me.lblCldSeven.Name = lblCld(index).ToString Then
                    Me.lblCldSeven.Text = day
                ElseIf Me.lblCldEight.Name = lblCld(index).ToString Then
                    Me.lblCldEight.Text = day
                ElseIf Me.lblCldNine.Name = lblCld(index).ToString Then
                    Me.lblCldNine.Text = day
                ElseIf Me.lblCldTen.Name = lblCld(index).ToString Then
                    Me.lblCldTen.Text = day
                ElseIf Me.lblCldEleven.Name = lblCld(index).ToString Then
                    Me.lblCldEleven.Text = day
                ElseIf Me.lblCldTwelve.Name = lblCld(index).ToString Then
                    Me.lblCldTwelve.Text = day
                ElseIf Me.lblCldThirteen.Name = lblCld(index).ToString Then
                    Me.lblCldThirteen.Text = day
                ElseIf Me.lblCldFourteen.Name = lblCld(index).ToString Then
                    Me.lblCldFourteen.Text = day
                ElseIf Me.lblCldFifteen.Name = lblCld(index).ToString Then
                    Me.lblCldFifteen.Text = day
                ElseIf Me.lblCldSixteen.Name = lblCld(index).ToString Then
                    Me.lblCldSixteen.Text = day
                ElseIf Me.lblCldSeventeen.Name = lblCld(index).ToString Then
                    Me.lblCldSeventeen.Text = day
                ElseIf Me.lblCldEighteen.Name = lblCld(index).ToString Then
                    Me.lblCldEighteen.Text = day
                ElseIf Me.lblCldNineteen.Name = lblCld(index).ToString Then
                    Me.lblCldNineteen.Text = day
                ElseIf Me.lblCldTwenty.Name = lblCld(index).ToString Then
                    Me.lblCldTwenty.Text = day
                ElseIf Me.lblCldTwentyOne.Name = lblCld(index).ToString Then
                    Me.lblCldTwentyOne.Text = day
                ElseIf Me.lblCldTwentyTwo.Name = lblCld(index).ToString Then
                    Me.lblCldTwentyTwo.Text = day
                ElseIf Me.lblCldTwentyThree.Name = lblCld(index).ToString Then
                    Me.lblCldTwentyThree.Text = day
                ElseIf Me.lblCldTwentyFour.Name = lblCld(index).ToString Then
                    Me.lblCldTwentyFour.Text = day
                ElseIf Me.lblCldTwentyFive.Name = lblCld(index).ToString Then
                    Me.lblCldTwentyFive.Text = day
                ElseIf Me.lblCldTwentySix.Name = lblCld(index).ToString Then
                    Me.lblCldTwentySix.Text = day
                ElseIf Me.lblCldTwentySeven.Name = lblCld(index).ToString Then
                    Me.lblCldTwentySeven.Text = day
                ElseIf Me.lblCldTwentyEight.Name = lblCld(index).ToString Then
                    Me.lblCldTwentyEight.Text = day
                ElseIf Me.lblCldTwentyNine.Name = lblCld(index).ToString Then
                    Me.lblCldTwentyNine.Text = day
                ElseIf Me.lblCldThirty.Name = lblCld(index).ToString Then
                    Me.lblCldThirty.Text = day
                ElseIf Me.lblCldThirtyOne.Name = lblCld(index).ToString Then
                    Me.lblCldThirtyOne.Text = day
                ElseIf Me.lblCldThirtyTwo.Name = lblCld(index).ToString Then
                    Me.lblCldThirtyTwo.Text = day
                ElseIf Me.lblCldThirtyThree.Name = lblCld(index).ToString Then
                    Me.lblCldThirtyThree.Text = day
                ElseIf Me.lblCldThirtyFour.Name = lblCld(index).ToString Then
                    Me.lblCldThirtyFour.Text = day
                ElseIf Me.lblCldThirtyFive.Name = lblCld(index).ToString Then
                    Me.lblCldThirtyFive.Text = day
                ElseIf Me.lblCldThirtySix.Name = lblCld(index).ToString Then
                    Me.lblCldThirtySix.Text = day
                End If

            End If
        Next

    End Sub

    Private Sub SetLastMo(lastMo As Integer)

        For lastMoCnt = 0 To 5

            If String.IsNullOrWhiteSpace(Me.lblCldFive.Text) Then
                Me.lblCldFive.Text = CStr(lastMo)
            ElseIf String.IsNullOrWhiteSpace(Me.lblCldFour.Text) Then
                Me.lblCldFour.Text = CStr(lastMo)
            ElseIf String.IsNullOrWhiteSpace(Me.lblCldThree.Text) Then
                Me.lblCldThree.Text = CStr(lastMo)
            ElseIf String.IsNullOrWhiteSpace(Me.lblCldTwo.Text) Then
                Me.lblCldTwo.Text = CStr(lastMo)
            ElseIf String.IsNullOrWhiteSpace(Me.lblCldOne.Text) Then
                Me.lblCldOne.Text = CStr(lastMo)
            ElseIf String.IsNullOrWhiteSpace(Me.lblCldZero.Text) Then
                Me.lblCldZero.Text = CStr(lastMo)
            End If

            lastMo -= 1

        Next

    End Sub

    Private Sub SetNextMo(nextMo As Integer)

        For nextMoCnt = 0 To 10

            nextMo += 1

            If String.IsNullOrWhiteSpace(Me.lblCldTwentyEight.Text) Then
                Me.lblCldTwentyEight.Text = Single.Parse(nextMo)
            ElseIf String.IsNullOrWhiteSpace(Me.lblCldTwentyNine.Text) Then
                Me.lblCldTwentyNine.Text = Single.Parse(nextMo)
            ElseIf String.IsNullOrWhiteSpace(Me.lblCldThirty.Text) Then
                Me.lblCldThirty.Text = Single.Parse(nextMo)
            ElseIf String.IsNullOrWhiteSpace(Me.lblCldThirtyOne.Text) Then
                Me.lblCldThirtyOne.Text = Single.Parse(nextMo)
            ElseIf String.IsNullOrWhiteSpace(Me.lblCldThirtyTwo.Text) Then
                Me.lblCldThirtyTwo.Text = Single.Parse(nextMo)
            ElseIf String.IsNullOrWhiteSpace(Me.lblCldThirtyThree.Text) Then
                Me.lblCldThirtyThree.Text = Single.Parse(nextMo)
            ElseIf String.IsNullOrWhiteSpace(Me.lblCldThirtyFour.Text) Then
                Me.lblCldThirtyFour.Text = Single.Parse(nextMo)
            ElseIf String.IsNullOrWhiteSpace(Me.lblCldThirtyFive.Text) Then
                Me.lblCldThirtyFive.Text = Single.Parse(nextMo)
            ElseIf String.IsNullOrWhiteSpace(Me.lblCldThirtySix.Text) Then
                Me.lblCldThirtySix.Text = Single.Parse(nextMo)
            ElseIf String.IsNullOrWhiteSpace(Me.lblCldThirtySeven.Text) Then
                Me.lblCldThirtySeven.Text = Single.Parse(nextMo)
            ElseIf String.IsNullOrWhiteSpace(Me.lblCldThirtyEight.Text) Then
                Me.lblCldThirtyEight.Text = Single.Parse(nextMo)
            ElseIf String.IsNullOrWhiteSpace(Me.lblCldThirtyNine.Text) Then
                Me.lblCldThirtyNine.Text = Single.Parse(nextMo)
            ElseIf String.IsNullOrWhiteSpace(Me.lblCldForty.Text) Then
                Me.lblCldForty.Text = Single.Parse(nextMo)
            ElseIf String.IsNullOrWhiteSpace(Me.lblCldFortyOne.Text) Then
                Me.lblCldFortyOne.Text = Single.Parse(nextMo)
            End If

        Next

    End Sub

End Class