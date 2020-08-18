Public Class VehicleInformationForm
    Private Sub VehicleInformationFormLoad(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim frm As SearchForm = CType(Me.Owner, SearchForm)

        Dim vehicleInfoSql As New VehicleInfoSql

        Dim sql As String = vehicleInfoSql.VehicleInfo(frm.GetVehiclePk())

        'ラベル用フラグ
        'Dim F As Integer

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
            'sr = command.ExecuteReader(CommandBehavior.SingleRow)

            command.Dispose()

            While sr.Read
                Me.txtHome.Text = sr("home")
                Me.txtClassNumber.Text = sr("class_number")
                Me.txtDiscriminationCharacter.Text = sr("discrimination_character")
                Me.txtDesignatedNumber.Text = sr("designated_number")
                Me.txtManufacturer.Text = sr("manufacturer")
                Me.txtCarName.Text = sr("car_name")
                Me.txtChassisNumber.Text = sr("chassis_number")
                Me.txtModel.Text = sr("model")
                Me.txtPrimeMoverModel.Text = sr("prime_mover_model")
                Me.txtModelDesignationNumber.Text = sr("model_designation_number")
                Me.txtCategoryNumber.Text = sr("category_number")
                Me.txtMileage.Text = sr("mileage")
                Me.txtFirstDate.Text = sr("first_date")
                Me.txtLastInspectionDate.Text = sr("last_inspection_date")
                Me.txtNextInspectionDate.Text = sr("next_inspection_date")
                Me.txtOther.Text = sr("other")
                Me.txtSurname.Text = sr("surname")
                Me.txtName.Text = sr("name")
                Me.txtPhoneticSurname.Text = sr("phonetic_surname")
                Me.txtPhoneticName.Text = sr("phonetic_name")
                Me.txtPhoneNumber.Text = sr("phone_number")
                Me.txtMailAddress.Text = sr("mail_address")
                Me.txtPostalCode.Text = sr("postal_code")
                Me.txtStreetAddress.Text = sr("street_address")
                ' Me.RichTxtRemark.Text = sr("remark")
            End While

        Finally
            ' コネクションの破棄
            If con.State <> ConnectionState.Closed Then

                con.Close()

                con.Dispose()
            End If

        End Try

    End Sub

    Private Sub BtnSearchClick(sender As Object, e As EventArgs) Handles btnReturn.Click
        ' フォームを閉じる
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'tm3(2020/07/26)
        'ボタン表示を変更

        Button2.Text = "キャンセル"

        Select Case Button1.Text

            Case "編集(&E)"

                Button1.Text = "保存"

                '編集モードへ切り替え
                '--車両情報--------
                'txtHome.ReadOnly = Not txtHome.ReadOnly
                'txtClassNumber.ReadOnly = Not txtClassNumber.ReadOnly
                'txtDiscriminationCharacter.ReadOnly = Not txtDiscriminationCharacter.ReadOnly
                'txtDesignatedNumber.ReadOnly = Not txtDesignatedNumber.ReadOnly
                txtManufacturer.ReadOnly = Not txtManufacturer.ReadOnly
                txtCarName.ReadOnly = Not txtCarName.ReadOnly
                txtChassisNumber.ReadOnly = Not txtChassisNumber.ReadOnly
                txtModel.ReadOnly = Not txtModel.ReadOnly
                txtPrimeMoverModel.ReadOnly = Not txtPrimeMoverModel.ReadOnly
                txtModelDesignationNumber.ReadOnly = Not txtModelDesignationNumber.ReadOnly
                txtCategoryNumber.ReadOnly = Not txtCategoryNumber.ReadOnly
                txtMileage.ReadOnly = Not txtMileage.ReadOnly
                txtFirstDate.ReadOnly = Not txtFirstDate.ReadOnly
                txtLastInspectionDate.ReadOnly = Not txtLastInspectionDate.ReadOnly
                txtNextInspectionDate.ReadOnly = Not txtNextInspectionDate.ReadOnly
                txtOther.ReadOnly = Not txtOther.ReadOnly
                TextBox1.ReadOnly = Not TextBox1.ReadOnly
                TextBox2.ReadOnly = Not TextBox2.ReadOnly
                '--顧客情報--------
                txtSurname.ReadOnly = False
                txtName.ReadOnly = False
                txtPhoneticSurname.ReadOnly = False
                txtPhoneticName.ReadOnly = False
                txtPhoneNumber.ReadOnly = False
                txtMailAddress.ReadOnly = False
                txtPostalCode.ReadOnly = False
                txtStreetAddress.ReadOnly = False
                RichTxtRemark.ReadOnly = Not RichTxtRemark.ReadOnly
                RichTxtRemark.BackColor = Color.White

            Case "保存"
                '--車両情報--------
                txtManufacturer.ReadOnly = True
                txtCarName.ReadOnly = True
                txtChassisNumber.ReadOnly = True
                txtModel.ReadOnly = True
                txtPrimeMoverModel.ReadOnly = True
                txtModelDesignationNumber.ReadOnly = True
                txtCategoryNumber.ReadOnly = True
                txtMileage.ReadOnly = True
                txtFirstDate.ReadOnly = True
                txtLastInspectionDate.ReadOnly = True
                txtNextInspectionDate.ReadOnly = True
                txtOther.ReadOnly = True
                TextBox1.ReadOnly = True
                TextBox2.ReadOnly = True
                '--顧客情報--------
                txtSurname.ReadOnly = True
                txtName.ReadOnly = True
                txtPhoneticSurname.ReadOnly = True
                txtPhoneticName.ReadOnly = True
                txtPhoneNumber.ReadOnly = True
                txtMailAddress.ReadOnly = True
                txtPostalCode.ReadOnly = True
                txtStreetAddress.ReadOnly = True
                RichTxtRemark.ReadOnly = True
                RichTxtRemark.BackColor = SystemColors.Control

                '保存処理


                'ボタン名変更
                Button1.Text = "編集(&E)"
                Button2.Text = "追加(&A)"
                'Case Else

        End Select

        'Dim intRet As Integer
        '
        'intRet = MsgBox("終了しますか？", MsgBoxStyle.YesNo, "確認")
        'If intRet = MsgBoxResult.No Then
        '
        'e.Cancel = True
        '
        'End If

        'ラベル用フラグ(0=保存,1=キャンセル)
        Dim F As Integer

        F = 0

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        'tm3(2020/07/26)

        'ラベル用フラグ(0=追加,1=キャンセル)
        Dim F As Integer

        If Button2.Text = "キャンセル" Then
            F = 1
        Else
            F = 0
        End If

        Select Case F
            Case 0 '車両＆顧客情報追加処理
                'Button2.Text = "保存1"
                Dim intRet As Integer

                intRet = MsgBox("実装中です", MsgBoxStyle.OkOnly, "実装中")
                If intRet = MsgBoxResult.No Then

                    'e.Cancel = True

                End If

            Case 1 '編集キャンセル処理
                Button2.Text = "キャンセル"
                '--車両情報--------
                txtManufacturer.ReadOnly = True
                txtCarName.ReadOnly = True
                txtChassisNumber.ReadOnly = True
                txtModel.ReadOnly = True
                txtPrimeMoverModel.ReadOnly = True
                txtModelDesignationNumber.ReadOnly = True
                txtCategoryNumber.ReadOnly = True
                txtMileage.ReadOnly = True
                txtFirstDate.ReadOnly = True
                txtLastInspectionDate.ReadOnly = True
                txtNextInspectionDate.ReadOnly = True
                txtOther.ReadOnly = True
                TextBox1.ReadOnly = True
                TextBox2.ReadOnly = True
                '--顧客情報--------
                txtSurname.ReadOnly = True
                txtName.ReadOnly = True
                txtPhoneticSurname.ReadOnly = True
                txtPhoneticName.ReadOnly = True
                txtPhoneNumber.ReadOnly = True
                txtMailAddress.ReadOnly = True
                txtPostalCode.ReadOnly = True
                txtStreetAddress.ReadOnly = True
                RichTxtRemark.ReadOnly = True
                RichTxtRemark.BackColor = SystemColors.Control

                Button1.Text = "編集(&E)"
                Button2.Text = "追加(&A)"
                'Me.Button1.Enabled = False

                'Case Else

        End Select

    End Sub
End Class