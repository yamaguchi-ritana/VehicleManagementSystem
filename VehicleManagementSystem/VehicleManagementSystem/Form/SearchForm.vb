Public Class SearchForm

    Dim selectedVehicleDtoList As New List(Of SelectedVehicleDto)

    Dim vehiclePk As Integer

    ' VehicleInformationFormに車両PKを受け渡すための設定処理
    Public ReadOnly Property GsVehiclePk() As Integer
        Get
            Return vehiclePk
        End Get
    End Property

    Private Sub LblMrClick(sender As Object, e As EventArgs) Handles lblSurname.Click
        Me.txtSurname.Focus()
    End Sub

    Private Sub LblNameClick(sender As Object, e As EventArgs) Handles lblName.Click
        Me.txtName.Focus()
    End Sub

    Private Sub LblPhoneNumberClick(sender As Object, e As EventArgs) Handles lblPhoneNumber.Click
        Me.txtPhoneNumber.Focus()
    End Sub

    Private Sub LblDiscriminationCharacterClick(sender As Object, e As EventArgs) Handles lblDiscriminationCharacter.Click
        Me.txtDiscriminationCharacter.Focus()
    End Sub

    Private Sub LblDesignatedNumberClick(sender As Object, e As EventArgs) Handles lblDesignatedNumber.Click
        Me.txtDesignatedNumber.Focus()
    End Sub

    Private Sub BtnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click

        Dim vehicleInfoSearchDto As New VehicleInfoSearchDto With {
            .GsSurname = Me.txtSurname.Text,
            .GsName = Me.txtName.Text,
            .GsPhoneNumber = Me.txtPhoneNumber.Text,
            .GsDiscriminationChar = Me.txtDiscriminationCharacter.Text,
            .GsDesignatedNumber = Me.txtDesignatedNumber.Text
        }

        Dim searchFormSql As New VehicleSearchSql

        Dim sql As String = searchFormSql.VehicleInfoSearch(vehicleInfoSearchDto)

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

            ' 列数を初期化
            Me.gridSearchResults.RowCount = 1

            Dim errMsgConst As New MessageConst

            ' 車両情報が存在しない場合エラー
            If Not sr.HasRows Then
                MessageBox.Show(errMsgConst.GetVehicleInfoDoesNotExist, errMsgConst.GetVehicleInfoChk, MessageBoxButtons.OK, MessageBoxIcon.Question)
                Return
            End If

            Dim rowIndex As Integer

            While sr.Read

                '1行追加
                Me.gridSearchResults.Rows.Add()

                Dim selectedVehicleDto As New SelectedVehicleDto With {
                    .GsRowIndex = rowIndex,
                    .GsVehiclePk = sr("vehicle_pk")
                }

                selectedVehicleDtoList.Add(selectedVehicleDto)

                Me.gridSearchResults.Rows(rowIndex).Cells(0).Value = sr("full_name")
                Me.gridSearchResults.Rows(rowIndex).Cells(1).Value = sr("manufacturer")
                Me.gridSearchResults.Rows(rowIndex).Cells(2).Value = sr("car_name")
                Me.gridSearchResults.Rows(rowIndex).Cells(3).Value = sr("home")
                Me.gridSearchResults.Rows(rowIndex).Cells(4).Value = sr("class_number")
                Me.gridSearchResults.Rows(rowIndex).Cells(5).Value = sr("discrimination_character")
                Me.gridSearchResults.Rows(rowIndex).Cells(6).Value = sr("designated_number")
                Me.gridSearchResults.Rows(rowIndex).Cells(7).Value = Format(sr("last_inspection_date"), "yyyy/MM/dd")

                rowIndex += 1

            End While

        Finally
            ' コネクションの破棄
            If con.State <> ConnectionState.Closed Then

                con.Close()

                con.Dispose()
            End If

        End Try
    End Sub

    Private Sub gridSearchResultsCellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles gridSearchResults.CellContentDoubleClick

        For Each selectedVehicleDto As SelectedVehicleDto In selectedVehicleDtoList
            If selectedVehicleDto.GsRowIndex() = Me.gridSearchResults.SelectedCells(0).RowIndex Then
                VehiclePk = selectedVehicleDto.GsVehiclePk
            End If
        Next

        ' VehicleInformationFormのインスタンスを作成する
        Dim vehicleInformationForm As New VehicleInformationForm()

        ' ここではモーダルダイアログボックスとして表示する
        ' オーナーウィンドウにMeを指定する
        vehicleInformationForm.ShowDialog(Me)

        ' フォームが必要なくなったところで、Disposeを呼び出す
        ' リソースの解放
        vehicleInformationForm.Dispose()

    End Sub
End Class