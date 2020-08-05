Public Class TOPForm

    Private Sub TOPFormLoad(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim characterConst As New CharacterConst

        Dim dNow As DateTime = System.DateTime.Now

        Dim sb As New System.Text.StringBuilder()

        sb.Append(dNow.ToString(characterConst.GetyyyyMMddToJp))

        sb.Append(characterConst.GetHalfSpace)
        sb.Append(characterConst.GetHalfParenthesesStr)
        sb.Append(dNow.ToString(characterConst.GetdddToJp))
        sb.Append(characterConst.GetHalfParenthesesEnd)

        Me.lblToday.Text = sb.ToString

        ' ' ' 

        aaa(dNow)



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

    Private Function aaa(dNow As DateTime) As String

        Dim dtBirth As DateTime = DateTime.Parse(dNow.ToString("yyyy/MM") + "/01")
        Dim a As String = dtBirth.ToString("ddd")
        Dim index As Integer
        index = bbb(a)

        Dim lblCld() As String = {"lblCldZero", "lblCldOne", "lblCldTwo", "lblCldThree", "lblCldFour", "lblCldFive", "lblCldSix", "lblCldSeven", "lblCldEight", "lblCldNine", "lblCldTen", "lblCldEleven", "lblCldTwelve", "lblCldThirteen", "lblCldFourteen", "lblCldFifteen", "lblCldSixteen", "lblCldSeventeen", "lblCldEighteen", "lblCldNineteen", "lblCldTwenty", "lblCldTwentyOne", "lblCldTwentyTwo", "lblCldTwentyThree", "lblCldTwentyFour", "lblCldTwentyFive", "lblCldTwentySix", "lblCldTwentySeven", "lblCldTwentyEight", "lblCldTwentyNine", "lblCldThirty", "lblCldThirtyOne", "lblCldThirtyTwo", "lblCldThirtyThree", "lblCldThirtyFour", "lblCldThirtyFive", "lblCldThirtySix", "lblCldThirtySeven", "lblCldThirtyEight", "lblCldThirtyNine", "lblCldForty", "lblCldFortyOne"}

        Dim day As Integer

        Dim diy As DateTime = dtBirth.AddMonths(0).AddDays(-1).ToString()
        Dim diyy As DateTime = dtBirth.AddMonths(1).AddDays(0).ToString()


        Console.WriteLine(diy.ToString("dd"))

        Console.WriteLine(diyy.ToString("dd"))

        For i = 0 To lblCld.Count - 1

            If index <= i Then
                If Me.lblCldZero.Name = lblCld(i).ToString Then
                    day += 1
                    Me.lblCldZero.Text = day
                ElseIf Me.lblCldOne.Name = lblCld(i).ToString Then
                    day += 1
                    Me.lblCldOne.Text = day
                ElseIf Me.lblCldTwo.Name = lblCld(i).ToString Then
                    day += 1
                    Me.lblCldTwo.Text = day
                ElseIf Me.lblCldThree.Name = lblCld(i).ToString Then
                    day += 1
                    Me.lblCldThree.Text = day
                ElseIf Me.lblCldFour.Name = lblCld(i).ToString Then
                    day += 1
                    Me.lblCldFour.Text = day
                ElseIf Me.lblCldFive.Name = lblCld(i).ToString Then
                    day += 1
                    Me.lblCldFive.Text = day
                ElseIf Me.lblCldSix.Name = lblCld(i).ToString Then
                    day += 1
                    Me.lblCldSix.Text = day
                ElseIf Me.lblCldSeven.Name = lblCld(i).ToString Then
                    day += 1
                    Me.lblCldSeven.Text = day
                ElseIf Me.lblCldEight.Name = lblCld(i).ToString Then
                    day += 1
                    Me.lblCldEight.Text = day
                ElseIf Me.lblCldNine.Name = lblCld(i).ToString Then
                    day += 1
                    Me.lblCldNine.Text = day
                ElseIf Me.lblCldTen.Name = lblCld(i).ToString Then
                    day += 1
                    Me.lblCldTen.Text = day
                ElseIf Me.lblCldEleven.Name = lblCld(i).ToString Then
                    day += 1
                    Me.lblCldEleven.Text = day
                ElseIf Me.lblCldTwelve.Name = lblCld(i).ToString Then
                    day += 1
                    Me.lblCldTwelve.Text = day
                ElseIf Me.lblCldThirteen.Name = lblCld(i).ToString Then
                    day += 1
                    Me.lblCldThirteen.Text = day
                ElseIf Me.lblCldFourteen.Name = lblCld(i).ToString Then
                    day += 1
                    Me.lblCldFourteen.Text = day
                ElseIf Me.lblCldFifteen.Name = lblCld(i).ToString Then
                    day += 1
                    Me.lblCldFifteen.Text = day
                ElseIf Me.lblCldSixteen.Name = lblCld(i).ToString Then
                    day += 1
                    Me.lblCldSixteen.Text = day
                ElseIf Me.lblCldSeventeen.Name = lblCld(i).ToString Then
                    day += 1
                    Me.lblCldSeventeen.Text = day
                ElseIf Me.lblCldEighteen.Name = lblCld(i).ToString Then
                    day += 1
                    Me.lblCldEighteen.Text = day
                ElseIf Me.lblCldNineteen.Name = lblCld(i).ToString Then
                    day += 1
                    Me.lblCldNineteen.Text = day
                ElseIf Me.lblCldTwenty.Name = lblCld(i).ToString Then
                    day += 1
                    Me.lblCldTwenty.Text = day
                ElseIf Me.lblCldTwentyOne.Name = lblCld(i).ToString Then
                    day += 1
                    Me.lblCldTwentyOne.Text = day
                ElseIf Me.lblCldTwentyTwo.Name = lblCld(i).ToString Then
                    day += 1
                    Me.lblCldTwentyTwo.Text = day
                ElseIf Me.lblCldTwentyThree.Name = lblCld(i).ToString Then
                    day += 1
                    Me.lblCldTwentyThree.Text = day
                ElseIf Me.lblCldTwentyFour.Name = lblCld(i).ToString Then
                    day += 1
                    Me.lblCldTwentyFour.Text = day
                ElseIf Me.lblCldTwentyFive.Name = lblCld(i).ToString Then
                    day += 1
                    Me.lblCldTwentyFive.Text = day
                ElseIf Me.lblCldTwentySix.Name = lblCld(i).ToString Then
                    day += 1
                    Me.lblCldTwentySix.Text = day
                ElseIf Me.lblCldTwentySeven.Name = lblCld(i).ToString Then
                    day += 1
                    Me.lblCldTwentySeven.Text = day
                ElseIf Me.lblCldTwentyEight.Name = lblCld(i).ToString Then
                    day += 1
                    Me.lblCldTwentyEight.Text = day
                ElseIf Me.lblCldTwentyNine.Name = lblCld(i).ToString Then
                    day += 1
                    Me.lblCldTwentyNine.Text = day
                ElseIf Me.lblCldThirty.Name = lblCld(i).ToString Then
                    day += 1
                    Me.lblCldThirty.Text = day
                ElseIf Me.lblCldThirtyOne.Name = lblCld(i).ToString Then
                    day += 1
                    Me.lblCldThirtyOne.Text = day
                ElseIf Me.lblCldThirtyTwo.Name = lblCld(i).ToString Then
                    day += 1
                    Me.lblCldThirtyTwo.Text = day
                ElseIf Me.lblCldThirtyThree.Name = lblCld(i).ToString Then
                    day += 1
                    Me.lblCldThirtyThree.Text = day
                ElseIf Me.lblCldThirtyFour.Name = lblCld(i).ToString Then
                    day += 1
                    Me.lblCldThirtyFour.Text = day
                ElseIf Me.lblCldThirtyFive.Name = lblCld(i).ToString Then
                    day += 1
                    Me.lblCldThirtyFive.Text = day
                ElseIf Me.lblCldThirtySix.Name = lblCld(i).ToString Then
                    day += 1
                    Me.lblCldThirtySix.Text = day
                ElseIf Me.lblCldThirtySeven.Name = lblCld(i).ToString Then
                    day += 1
                    Me.lblCldThirtySeven.Text = day
                ElseIf Me.lblCldThirtyEight.Name = lblCld(i).ToString Then
                    day += 1
                    Me.lblCldThirtyEight.Text = day
                ElseIf Me.lblCldThirtyNine.Name = lblCld(i).ToString Then
                    day += 1
                    Me.lblCldThirtyNine.Text = day
                ElseIf Me.lblCldForty.Name = lblCld(i).ToString Then
                    day += 1
                    Me.lblCldForty.Text = day
                ElseIf Me.lblCldFortyOne.Name = lblCld(i).ToString Then
                    day += 1
                    Me.lblCldFortyOne.Text = day
                End If

                If index <= i Then

                End If
            End If
        Next


    End Function

    Private Function bbb(a As String) As Integer



        If (a = "日") Then
            Return 0
        ElseIf (a = "月") Then
            Return 1
        ElseIf (a = "火") Then
            Return 2
        ElseIf (a = "水") Then
            Return 3
        ElseIf (a = "木") Then
            Return 4
        ElseIf (a = "金") Then
            Return 5
        Else
            Return 6
        End If

    End Function

End Class