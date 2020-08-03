<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class VehicleInformationForm
    Inherits System.Windows.Forms.Form

    'フォームがコンポーネントの一覧をクリーンアップするために dispose をオーバーライドします。
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Windows フォーム デザイナーで必要です。
    Private components As System.ComponentModel.IContainer

    'メモ: 以下のプロシージャは Windows フォーム デザイナーで必要です。
    'Windows フォーム デザイナーを使用して変更できます。  
    'コード エディターを使って変更しないでください。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel9 = New System.Windows.Forms.TableLayoutPanel()
        Me.txtPhoneticName = New System.Windows.Forms.TextBox()
        Me.txtPhoneticSurname = New System.Windows.Forms.TextBox()
        Me.TableLayoutPanel8 = New System.Windows.Forms.TableLayoutPanel()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.txtSurname = New System.Windows.Forms.TextBox()
        Me.txtMailAddress = New System.Windows.Forms.TextBox()
        Me.txtPhoneNumber = New System.Windows.Forms.TextBox()
        Me.lblMailAddress = New System.Windows.Forms.Label()
        Me.tblFullName = New System.Windows.Forms.Label()
        Me.lblPhoneticFullName = New System.Windows.Forms.Label()
        Me.lblPhoneNumber = New System.Windows.Forms.Label()
        Me.TableLayoutPanel4 = New System.Windows.Forms.TableLayoutPanel()
        Me.lblRemark = New System.Windows.Forms.Label()
        Me.RichTxtRemark = New System.Windows.Forms.RichTextBox()
        Me.TableLayoutPanel5 = New System.Windows.Forms.TableLayoutPanel()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnReturn = New System.Windows.Forms.Button()
        Me.lblVer = New System.Windows.Forms.Label()
        Me.lblCopywriter = New System.Windows.Forms.Label()
        Me.lblModel = New System.Windows.Forms.Label()
        Me.lblChassisNumber = New System.Windows.Forms.Label()
        Me.lblCarName = New System.Windows.Forms.Label()
        Me.lblManufacturer = New System.Windows.Forms.Label()
        Me.lblPrimeMoverModel = New System.Windows.Forms.Label()
        Me.lblModelDesignationNumber = New System.Windows.Forms.Label()
        Me.lblCategoryNumber = New System.Windows.Forms.Label()
        Me.lblMileage = New System.Windows.Forms.Label()
        Me.lblFirstDate = New System.Windows.Forms.Label()
        Me.lblLastInspectionDate = New System.Windows.Forms.Label()
        Me.lblNextInspectionDate = New System.Windows.Forms.Label()
        Me.lblOther = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtManufacturer = New System.Windows.Forms.TextBox()
        Me.txtCarName = New System.Windows.Forms.TextBox()
        Me.txtChassisNumber = New System.Windows.Forms.TextBox()
        Me.txtModel = New System.Windows.Forms.TextBox()
        Me.txtPrimeMoverModel = New System.Windows.Forms.TextBox()
        Me.txtModelDesignationNumber = New System.Windows.Forms.TextBox()
        Me.txtCategoryNumber = New System.Windows.Forms.TextBox()
        Me.txtMileage = New System.Windows.Forms.TextBox()
        Me.txtFirstDate = New System.Windows.Forms.TextBox()
        Me.txtLastInspectionDate = New System.Windows.Forms.TextBox()
        Me.txtNextInspectionDate = New System.Windows.Forms.TextBox()
        Me.txtOther = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel7 = New System.Windows.Forms.TableLayoutPanel()
        Me.txtDesignatedNumber = New System.Windows.Forms.TextBox()
        Me.txtDiscriminationCharacter = New System.Windows.Forms.TextBox()
        Me.txtClassNumber = New System.Windows.Forms.TextBox()
        Me.txtHome = New System.Windows.Forms.TextBox()
        Me.lblCarRegistrationNumber = New System.Windows.Forms.Label()
        Me.lblAddress = New System.Windows.Forms.Label()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel6 = New System.Windows.Forms.TableLayoutPanel()
        Me.txtStreetAddress = New System.Windows.Forms.TextBox()
        Me.txtPostalCode = New System.Windows.Forms.TextBox()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.TableLayoutPanel9.SuspendLayout()
        Me.TableLayoutPanel8.SuspendLayout()
        Me.TableLayoutPanel4.SuspendLayout()
        Me.TableLayoutPanel5.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.TableLayoutPanel7.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
        Me.TableLayoutPanel6.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Outset
        Me.TableLayoutPanel2.ColumnCount = 4
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.TableLayoutPanel9, 3, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.TableLayoutPanel8, 1, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.txtMailAddress, 3, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.txtPhoneNumber, 1, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.lblMailAddress, 2, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.tblFullName, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.lblPhoneticFullName, 2, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.lblPhoneNumber, 0, 1)
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(36, 202)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 2
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(728, 57)
        Me.TableLayoutPanel2.TabIndex = 1
        '
        'TableLayoutPanel9
        '
        Me.TableLayoutPanel9.ColumnCount = 2
        Me.TableLayoutPanel9.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel9.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel9.Controls.Add(Me.txtPhoneticName, 1, 0)
        Me.TableLayoutPanel9.Controls.Add(Me.txtPhoneticSurname, 0, 0)
        Me.TableLayoutPanel9.Location = New System.Drawing.Point(547, 4)
        Me.TableLayoutPanel9.Margin = New System.Windows.Forms.Padding(2)
        Me.TableLayoutPanel9.Name = "TableLayoutPanel9"
        Me.TableLayoutPanel9.RowCount = 1
        Me.TableLayoutPanel9.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel9.Size = New System.Drawing.Size(176, 21)
        Me.TableLayoutPanel9.TabIndex = 15
        '
        'txtPhoneticName
        '
        Me.txtPhoneticName.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtPhoneticName.Location = New System.Drawing.Point(90, 2)
        Me.txtPhoneticName.Margin = New System.Windows.Forms.Padding(2)
        Me.txtPhoneticName.Name = "txtPhoneticName"
        Me.txtPhoneticName.ReadOnly = True
        Me.txtPhoneticName.Size = New System.Drawing.Size(84, 19)
        Me.txtPhoneticName.TabIndex = 17
        '
        'txtPhoneticSurname
        '
        Me.txtPhoneticSurname.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtPhoneticSurname.Location = New System.Drawing.Point(2, 2)
        Me.txtPhoneticSurname.Margin = New System.Windows.Forms.Padding(2)
        Me.txtPhoneticSurname.Name = "txtPhoneticSurname"
        Me.txtPhoneticSurname.ReadOnly = True
        Me.txtPhoneticSurname.Size = New System.Drawing.Size(84, 19)
        Me.txtPhoneticSurname.TabIndex = 16
        '
        'TableLayoutPanel8
        '
        Me.TableLayoutPanel8.ColumnCount = 2
        Me.TableLayoutPanel8.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel8.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel8.Controls.Add(Me.txtName, 0, 0)
        Me.TableLayoutPanel8.Controls.Add(Me.txtSurname, 0, 0)
        Me.TableLayoutPanel8.Location = New System.Drawing.Point(185, 4)
        Me.TableLayoutPanel8.Margin = New System.Windows.Forms.Padding(2)
        Me.TableLayoutPanel8.Name = "TableLayoutPanel8"
        Me.TableLayoutPanel8.RowCount = 1
        Me.TableLayoutPanel8.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel8.Size = New System.Drawing.Size(175, 21)
        Me.TableLayoutPanel8.TabIndex = 12
        '
        'txtName
        '
        Me.txtName.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtName.Location = New System.Drawing.Point(89, 2)
        Me.txtName.Margin = New System.Windows.Forms.Padding(2)
        Me.txtName.Name = "txtName"
        Me.txtName.ReadOnly = True
        Me.txtName.Size = New System.Drawing.Size(84, 19)
        Me.txtName.TabIndex = 15
        '
        'txtSurname
        '
        Me.txtSurname.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtSurname.Location = New System.Drawing.Point(2, 2)
        Me.txtSurname.Margin = New System.Windows.Forms.Padding(2)
        Me.txtSurname.Name = "txtSurname"
        Me.txtSurname.ReadOnly = True
        Me.txtSurname.Size = New System.Drawing.Size(83, 19)
        Me.txtSurname.TabIndex = 14
        '
        'txtMailAddress
        '
        Me.txtMailAddress.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtMailAddress.Location = New System.Drawing.Point(548, 32)
        Me.txtMailAddress.Margin = New System.Windows.Forms.Padding(2)
        Me.txtMailAddress.Name = "txtMailAddress"
        Me.txtMailAddress.ReadOnly = True
        Me.txtMailAddress.Size = New System.Drawing.Size(174, 19)
        Me.txtMailAddress.TabIndex = 14
        '
        'txtPhoneNumber
        '
        Me.txtPhoneNumber.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtPhoneNumber.Location = New System.Drawing.Point(185, 32)
        Me.txtPhoneNumber.Margin = New System.Windows.Forms.Padding(2)
        Me.txtPhoneNumber.Name = "txtPhoneNumber"
        Me.txtPhoneNumber.ReadOnly = True
        Me.txtPhoneNumber.Size = New System.Drawing.Size(174, 19)
        Me.txtPhoneNumber.TabIndex = 13
        '
        'lblMailAddress
        '
        Me.lblMailAddress.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblMailAddress.AutoSize = True
        Me.lblMailAddress.Location = New System.Drawing.Point(419, 36)
        Me.lblMailAddress.Name = "lblMailAddress"
        Me.lblMailAddress.Size = New System.Drawing.Size(69, 12)
        Me.lblMailAddress.TabIndex = 3
        Me.lblMailAddress.Text = "メールアドレス"
        '
        'tblFullName
        '
        Me.tblFullName.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tblFullName.AutoSize = True
        Me.tblFullName.Location = New System.Drawing.Point(77, 8)
        Me.tblFullName.Name = "tblFullName"
        Me.tblFullName.Size = New System.Drawing.Size(29, 12)
        Me.tblFullName.TabIndex = 3
        Me.tblFullName.Text = "氏名"
        '
        'lblPhoneticFullName
        '
        Me.lblPhoneticFullName.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblPhoneticFullName.AutoSize = True
        Me.lblPhoneticFullName.Location = New System.Drawing.Point(432, 8)
        Me.lblPhoneticFullName.Name = "lblPhoneticFullName"
        Me.lblPhoneticFullName.Size = New System.Drawing.Size(43, 12)
        Me.lblPhoneticFullName.TabIndex = 3
        Me.lblPhoneticFullName.Text = "ふりがな"
        '
        'lblPhoneNumber
        '
        Me.lblPhoneNumber.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblPhoneNumber.AutoSize = True
        Me.lblPhoneNumber.Location = New System.Drawing.Point(65, 36)
        Me.lblPhoneNumber.Name = "lblPhoneNumber"
        Me.lblPhoneNumber.Size = New System.Drawing.Size(53, 12)
        Me.lblPhoneNumber.TabIndex = 3
        Me.lblPhoneNumber.Text = "電話番号"
        '
        'TableLayoutPanel4
        '
        Me.TableLayoutPanel4.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Outset
        Me.TableLayoutPanel4.ColumnCount = 2
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.91209!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 87.08791!))
        Me.TableLayoutPanel4.Controls.Add(Me.lblRemark, 0, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.RichTxtRemark, 1, 0)
        Me.TableLayoutPanel4.Location = New System.Drawing.Point(36, 284)
        Me.TableLayoutPanel4.Name = "TableLayoutPanel4"
        Me.TableLayoutPanel4.RowCount = 1
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel4.Size = New System.Drawing.Size(728, 100)
        Me.TableLayoutPanel4.TabIndex = 3
        '
        'lblRemark
        '
        Me.lblRemark.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblRemark.AutoSize = True
        Me.lblRemark.Location = New System.Drawing.Point(34, 44)
        Me.lblRemark.Name = "lblRemark"
        Me.lblRemark.Size = New System.Drawing.Size(29, 12)
        Me.lblRemark.TabIndex = 4
        Me.lblRemark.Text = "備考"
        '
        'RichTxtRemark
        '
        Me.RichTxtRemark.BackColor = System.Drawing.SystemColors.Control
        Me.RichTxtRemark.Location = New System.Drawing.Point(100, 5)
        Me.RichTxtRemark.Name = "RichTxtRemark"
        Me.RichTxtRemark.ReadOnly = True
        Me.RichTxtRemark.Size = New System.Drawing.Size(623, 90)
        Me.RichTxtRemark.TabIndex = 5
        Me.RichTxtRemark.Text = ""
        '
        'TableLayoutPanel5
        '
        Me.TableLayoutPanel5.ColumnCount = 3
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel5.Controls.Add(Me.Button2, 2, 0)
        Me.TableLayoutPanel5.Controls.Add(Me.Button1, 1, 0)
        Me.TableLayoutPanel5.Controls.Add(Me.btnReturn, 0, 0)
        Me.TableLayoutPanel5.Location = New System.Drawing.Point(265, 389)
        Me.TableLayoutPanel5.Name = "TableLayoutPanel5"
        Me.TableLayoutPanel5.RowCount = 1
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel5.Size = New System.Drawing.Size(268, 28)
        Me.TableLayoutPanel5.TabIndex = 4
        '
        'Button2
        '
        Me.Button2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Button2.Location = New System.Drawing.Point(185, 3)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 22)
        Me.Button2.TabIndex = 13
        Me.Button2.Text = "追加(&A)"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Button1.Location = New System.Drawing.Point(96, 3)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 22)
        Me.Button1.TabIndex = 12
        Me.Button1.Text = "編集(&E)"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btnReturn
        '
        Me.btnReturn.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnReturn.Location = New System.Drawing.Point(7, 3)
        Me.btnReturn.Name = "btnReturn"
        Me.btnReturn.Size = New System.Drawing.Size(75, 22)
        Me.btnReturn.TabIndex = 11
        Me.btnReturn.Text = "戻る(&R)"
        Me.btnReturn.UseVisualStyleBackColor = True
        '
        'lblVer
        '
        Me.lblVer.AutoSize = True
        Me.lblVer.Location = New System.Drawing.Point(399, 431)
        Me.lblVer.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblVer.Name = "lblVer"
        Me.lblVer.Size = New System.Drawing.Size(45, 12)
        Me.lblVer.TabIndex = 10
        Me.lblVer.Text = "ver予定"
        '
        'lblCopywriter
        '
        Me.lblCopywriter.AutoSize = True
        Me.lblCopywriter.Location = New System.Drawing.Point(356, 432)
        Me.lblCopywriter.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblCopywriter.Name = "lblCopywriter"
        Me.lblCopywriter.Size = New System.Drawing.Size(40, 12)
        Me.lblCopywriter.TabIndex = 9
        Me.lblCopywriter.Text = "© 1GW"
        '
        'lblModel
        '
        Me.lblModel.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblModel.AutoSize = True
        Me.lblModel.Location = New System.Drawing.Point(639, 10)
        Me.lblModel.Name = "lblModel"
        Me.lblModel.Size = New System.Drawing.Size(29, 12)
        Me.lblModel.TabIndex = 4
        Me.lblModel.Text = "型式"
        '
        'lblChassisNumber
        '
        Me.lblChassisNumber.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblChassisNumber.AutoSize = True
        Me.lblChassisNumber.Location = New System.Drawing.Point(482, 10)
        Me.lblChassisNumber.Name = "lblChassisNumber"
        Me.lblChassisNumber.Size = New System.Drawing.Size(53, 12)
        Me.lblChassisNumber.TabIndex = 3
        Me.lblChassisNumber.Text = "車台番号"
        '
        'lblCarName
        '
        Me.lblCarName.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblCarName.AutoSize = True
        Me.lblCarName.Location = New System.Drawing.Point(349, 10)
        Me.lblCarName.Name = "lblCarName"
        Me.lblCarName.Size = New System.Drawing.Size(29, 12)
        Me.lblCarName.TabIndex = 2
        Me.lblCarName.Text = "車名"
        '
        'lblManufacturer
        '
        Me.lblManufacturer.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblManufacturer.AutoSize = True
        Me.lblManufacturer.Location = New System.Drawing.Point(197, 10)
        Me.lblManufacturer.Name = "lblManufacturer"
        Me.lblManufacturer.Size = New System.Drawing.Size(42, 12)
        Me.lblManufacturer.TabIndex = 1
        Me.lblManufacturer.Text = "メーカー"
        '
        'lblPrimeMoverModel
        '
        Me.lblPrimeMoverModel.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblPrimeMoverModel.AutoSize = True
        Me.lblPrimeMoverModel.Location = New System.Drawing.Point(41, 70)
        Me.lblPrimeMoverModel.Name = "lblPrimeMoverModel"
        Me.lblPrimeMoverModel.Size = New System.Drawing.Size(65, 12)
        Me.lblPrimeMoverModel.TabIndex = 1
        Me.lblPrimeMoverModel.Text = "原動機型式"
        '
        'lblModelDesignationNumber
        '
        Me.lblModelDesignationNumber.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblModelDesignationNumber.AutoSize = True
        Me.lblModelDesignationNumber.Location = New System.Drawing.Point(180, 70)
        Me.lblModelDesignationNumber.Name = "lblModelDesignationNumber"
        Me.lblModelDesignationNumber.Size = New System.Drawing.Size(77, 12)
        Me.lblModelDesignationNumber.TabIndex = 2
        Me.lblModelDesignationNumber.Text = "型式指定番号"
        '
        'lblCategoryNumber
        '
        Me.lblCategoryNumber.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblCategoryNumber.AutoSize = True
        Me.lblCategoryNumber.Location = New System.Drawing.Point(337, 70)
        Me.lblCategoryNumber.Name = "lblCategoryNumber"
        Me.lblCategoryNumber.Size = New System.Drawing.Size(53, 12)
        Me.lblCategoryNumber.TabIndex = 2
        Me.lblCategoryNumber.Text = "類別番号"
        '
        'lblMileage
        '
        Me.lblMileage.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblMileage.AutoSize = True
        Me.lblMileage.Location = New System.Drawing.Point(482, 70)
        Me.lblMileage.Name = "lblMileage"
        Me.lblMileage.Size = New System.Drawing.Size(53, 12)
        Me.lblMileage.TabIndex = 2
        Me.lblMileage.Text = "走行距離"
        '
        'lblFirstDate
        '
        Me.lblFirstDate.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblFirstDate.AutoSize = True
        Me.lblFirstDate.Location = New System.Drawing.Point(633, 70)
        Me.lblFirstDate.Name = "lblFirstDate"
        Me.lblFirstDate.Size = New System.Drawing.Size(41, 12)
        Me.lblFirstDate.TabIndex = 2
        Me.lblFirstDate.Text = "初年度"
        '
        'lblLastInspectionDate
        '
        Me.lblLastInspectionDate.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblLastInspectionDate.AutoSize = True
        Me.lblLastInspectionDate.Location = New System.Drawing.Point(41, 130)
        Me.lblLastInspectionDate.Name = "lblLastInspectionDate"
        Me.lblLastInspectionDate.Size = New System.Drawing.Size(65, 12)
        Me.lblLastInspectionDate.TabIndex = 2
        Me.lblLastInspectionDate.Text = "前回点検日"
        '
        'lblNextInspectionDate
        '
        Me.lblNextInspectionDate.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblNextInspectionDate.AutoSize = True
        Me.lblNextInspectionDate.Location = New System.Drawing.Point(186, 130)
        Me.lblNextInspectionDate.Name = "lblNextInspectionDate"
        Me.lblNextInspectionDate.Size = New System.Drawing.Size(65, 12)
        Me.lblNextInspectionDate.TabIndex = 2
        Me.lblNextInspectionDate.Text = "次回点検日"
        '
        'lblOther
        '
        Me.lblOther.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblOther.AutoSize = True
        Me.lblOther.Location = New System.Drawing.Point(345, 130)
        Me.lblOther.Name = "lblOther"
        Me.lblOther.Size = New System.Drawing.Size(36, 12)
        Me.lblOther.TabIndex = 2
        Me.lblOther.Text = "その他"
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(503, 130)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(11, 12)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "-"
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(648, 130)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(11, 12)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "-"
        '
        'txtManufacturer
        '
        Me.txtManufacturer.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtManufacturer.Location = New System.Drawing.Point(149, 36)
        Me.txtManufacturer.Margin = New System.Windows.Forms.Padding(2)
        Me.txtManufacturer.Name = "txtManufacturer"
        Me.txtManufacturer.ReadOnly = True
        Me.txtManufacturer.Size = New System.Drawing.Size(139, 19)
        Me.txtManufacturer.TabIndex = 12
        '
        'txtCarName
        '
        Me.txtCarName.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtCarName.Location = New System.Drawing.Point(294, 36)
        Me.txtCarName.Margin = New System.Windows.Forms.Padding(2)
        Me.txtCarName.Name = "txtCarName"
        Me.txtCarName.ReadOnly = True
        Me.txtCarName.Size = New System.Drawing.Size(139, 19)
        Me.txtCarName.TabIndex = 18
        '
        'txtChassisNumber
        '
        Me.txtChassisNumber.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtChassisNumber.Location = New System.Drawing.Point(439, 36)
        Me.txtChassisNumber.Margin = New System.Windows.Forms.Padding(2)
        Me.txtChassisNumber.Name = "txtChassisNumber"
        Me.txtChassisNumber.ReadOnly = True
        Me.txtChassisNumber.Size = New System.Drawing.Size(139, 19)
        Me.txtChassisNumber.TabIndex = 19
        '
        'txtModel
        '
        Me.txtModel.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtModel.Location = New System.Drawing.Point(584, 36)
        Me.txtModel.Margin = New System.Windows.Forms.Padding(2)
        Me.txtModel.Name = "txtModel"
        Me.txtModel.ReadOnly = True
        Me.txtModel.Size = New System.Drawing.Size(140, 19)
        Me.txtModel.TabIndex = 20
        '
        'txtPrimeMoverModel
        '
        Me.txtPrimeMoverModel.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtPrimeMoverModel.Location = New System.Drawing.Point(4, 96)
        Me.txtPrimeMoverModel.Margin = New System.Windows.Forms.Padding(2)
        Me.txtPrimeMoverModel.Name = "txtPrimeMoverModel"
        Me.txtPrimeMoverModel.ReadOnly = True
        Me.txtPrimeMoverModel.Size = New System.Drawing.Size(139, 19)
        Me.txtPrimeMoverModel.TabIndex = 21
        '
        'txtModelDesignationNumber
        '
        Me.txtModelDesignationNumber.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtModelDesignationNumber.Location = New System.Drawing.Point(149, 96)
        Me.txtModelDesignationNumber.Margin = New System.Windows.Forms.Padding(2)
        Me.txtModelDesignationNumber.Name = "txtModelDesignationNumber"
        Me.txtModelDesignationNumber.ReadOnly = True
        Me.txtModelDesignationNumber.Size = New System.Drawing.Size(139, 19)
        Me.txtModelDesignationNumber.TabIndex = 22
        '
        'txtCategoryNumber
        '
        Me.txtCategoryNumber.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtCategoryNumber.Location = New System.Drawing.Point(294, 96)
        Me.txtCategoryNumber.Margin = New System.Windows.Forms.Padding(2)
        Me.txtCategoryNumber.Name = "txtCategoryNumber"
        Me.txtCategoryNumber.ReadOnly = True
        Me.txtCategoryNumber.Size = New System.Drawing.Size(139, 19)
        Me.txtCategoryNumber.TabIndex = 23
        '
        'txtMileage
        '
        Me.txtMileage.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtMileage.Location = New System.Drawing.Point(439, 96)
        Me.txtMileage.Margin = New System.Windows.Forms.Padding(2)
        Me.txtMileage.Name = "txtMileage"
        Me.txtMileage.ReadOnly = True
        Me.txtMileage.Size = New System.Drawing.Size(139, 19)
        Me.txtMileage.TabIndex = 24
        '
        'txtFirstDate
        '
        Me.txtFirstDate.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtFirstDate.Location = New System.Drawing.Point(584, 96)
        Me.txtFirstDate.Margin = New System.Windows.Forms.Padding(2)
        Me.txtFirstDate.Name = "txtFirstDate"
        Me.txtFirstDate.ReadOnly = True
        Me.txtFirstDate.Size = New System.Drawing.Size(140, 19)
        Me.txtFirstDate.TabIndex = 25
        '
        'txtLastInspectionDate
        '
        Me.txtLastInspectionDate.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtLastInspectionDate.Location = New System.Drawing.Point(4, 158)
        Me.txtLastInspectionDate.Margin = New System.Windows.Forms.Padding(2)
        Me.txtLastInspectionDate.Name = "txtLastInspectionDate"
        Me.txtLastInspectionDate.ReadOnly = True
        Me.txtLastInspectionDate.Size = New System.Drawing.Size(139, 19)
        Me.txtLastInspectionDate.TabIndex = 26
        '
        'txtNextInspectionDate
        '
        Me.txtNextInspectionDate.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtNextInspectionDate.Location = New System.Drawing.Point(149, 158)
        Me.txtNextInspectionDate.Margin = New System.Windows.Forms.Padding(2)
        Me.txtNextInspectionDate.Name = "txtNextInspectionDate"
        Me.txtNextInspectionDate.ReadOnly = True
        Me.txtNextInspectionDate.Size = New System.Drawing.Size(139, 19)
        Me.txtNextInspectionDate.TabIndex = 27
        '
        'txtOther
        '
        Me.txtOther.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtOther.Location = New System.Drawing.Point(294, 158)
        Me.txtOther.Margin = New System.Windows.Forms.Padding(2)
        Me.txtOther.Name = "txtOther"
        Me.txtOther.ReadOnly = True
        Me.txtOther.Size = New System.Drawing.Size(139, 19)
        Me.txtOther.TabIndex = 28
        '
        'TextBox1
        '
        Me.TextBox1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TextBox1.Location = New System.Drawing.Point(439, 158)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(139, 19)
        Me.TextBox1.TabIndex = 29
        '
        'TextBox2
        '
        Me.TextBox2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TextBox2.Location = New System.Drawing.Point(584, 158)
        Me.TextBox2.Margin = New System.Windows.Forms.Padding(2)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.ReadOnly = True
        Me.TextBox2.Size = New System.Drawing.Size(140, 19)
        Me.TextBox2.TabIndex = 29
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Outset
        Me.TableLayoutPanel1.ColumnCount = 5
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel7, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.TextBox2, 4, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.TextBox1, 3, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.txtOther, 2, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.txtNextInspectionDate, 1, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.txtLastInspectionDate, 0, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.txtFirstDate, 4, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.txtMileage, 3, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.txtCategoryNumber, 2, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.txtModelDesignationNumber, 1, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.txtPrimeMoverModel, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.txtModel, 4, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.txtChassisNumber, 3, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.txtCarName, 2, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.txtManufacturer, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Label2, 4, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.Label1, 3, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.lblOther, 2, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.lblNextInspectionDate, 1, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.lblLastInspectionDate, 0, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.lblFirstDate, 4, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.lblMileage, 3, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.lblCategoryNumber, 2, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.lblModelDesignationNumber, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.lblPrimeMoverModel, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.lblCarRegistrationNumber, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.lblManufacturer, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.lblCarName, 2, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.lblChassisNumber, 3, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.lblModel, 4, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(36, 10)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 6
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(728, 185)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'TableLayoutPanel7
        '
        Me.TableLayoutPanel7.ColumnCount = 4
        Me.TableLayoutPanel7.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35.0!))
        Me.TableLayoutPanel7.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel7.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.0!))
        Me.TableLayoutPanel7.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.0!))
        Me.TableLayoutPanel7.Controls.Add(Me.txtDesignatedNumber, 3, 0)
        Me.TableLayoutPanel7.Controls.Add(Me.txtDiscriminationCharacter, 2, 0)
        Me.TableLayoutPanel7.Controls.Add(Me.txtClassNumber, 1, 0)
        Me.TableLayoutPanel7.Controls.Add(Me.txtHome, 0, 0)
        Me.TableLayoutPanel7.Location = New System.Drawing.Point(4, 34)
        Me.TableLayoutPanel7.Margin = New System.Windows.Forms.Padding(2)
        Me.TableLayoutPanel7.Name = "TableLayoutPanel7"
        Me.TableLayoutPanel7.RowCount = 1
        Me.TableLayoutPanel7.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel7.Size = New System.Drawing.Size(139, 24)
        Me.TableLayoutPanel7.TabIndex = 12
        '
        'txtDesignatedNumber
        '
        Me.txtDesignatedNumber.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtDesignatedNumber.Location = New System.Drawing.Point(97, 2)
        Me.txtDesignatedNumber.Margin = New System.Windows.Forms.Padding(2)
        Me.txtDesignatedNumber.Name = "txtDesignatedNumber"
        Me.txtDesignatedNumber.ReadOnly = True
        Me.txtDesignatedNumber.Size = New System.Drawing.Size(39, 19)
        Me.txtDesignatedNumber.TabIndex = 16
        '
        'txtDiscriminationCharacter
        '
        Me.txtDiscriminationCharacter.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtDiscriminationCharacter.Location = New System.Drawing.Point(77, 2)
        Me.txtDiscriminationCharacter.Margin = New System.Windows.Forms.Padding(2)
        Me.txtDiscriminationCharacter.Name = "txtDiscriminationCharacter"
        Me.txtDiscriminationCharacter.ReadOnly = True
        Me.txtDiscriminationCharacter.Size = New System.Drawing.Size(16, 19)
        Me.txtDiscriminationCharacter.TabIndex = 15
        '
        'txtClassNumber
        '
        Me.txtClassNumber.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtClassNumber.Location = New System.Drawing.Point(50, 2)
        Me.txtClassNumber.Margin = New System.Windows.Forms.Padding(2)
        Me.txtClassNumber.Name = "txtClassNumber"
        Me.txtClassNumber.ReadOnly = True
        Me.txtClassNumber.Size = New System.Drawing.Size(23, 19)
        Me.txtClassNumber.TabIndex = 14
        '
        'txtHome
        '
        Me.txtHome.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtHome.Location = New System.Drawing.Point(2, 2)
        Me.txtHome.Margin = New System.Windows.Forms.Padding(2)
        Me.txtHome.Name = "txtHome"
        Me.txtHome.ReadOnly = True
        Me.txtHome.Size = New System.Drawing.Size(44, 19)
        Me.txtHome.TabIndex = 13
        '
        'lblCarRegistrationNumber
        '
        Me.lblCarRegistrationNumber.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblCarRegistrationNumber.AutoSize = True
        Me.lblCarRegistrationNumber.Location = New System.Drawing.Point(29, 10)
        Me.lblCarRegistrationNumber.Name = "lblCarRegistrationNumber"
        Me.lblCarRegistrationNumber.Size = New System.Drawing.Size(89, 12)
        Me.lblCarRegistrationNumber.TabIndex = 0
        Me.lblCarRegistrationNumber.Text = "自動車登録番号"
        '
        'lblAddress
        '
        Me.lblAddress.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblAddress.AutoSize = True
        Me.lblAddress.Location = New System.Drawing.Point(34, 8)
        Me.lblAddress.Name = "lblAddress"
        Me.lblAddress.Size = New System.Drawing.Size(29, 12)
        Me.lblAddress.TabIndex = 4
        Me.lblAddress.Text = "住所"
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Outset
        Me.TableLayoutPanel3.ColumnCount = 2
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.91209!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 87.08791!))
        Me.TableLayoutPanel3.Controls.Add(Me.TableLayoutPanel6, 1, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.lblAddress, 0, 0)
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(36, 257)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 1
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(728, 29)
        Me.TableLayoutPanel3.TabIndex = 2
        '
        'TableLayoutPanel6
        '
        Me.TableLayoutPanel6.ColumnCount = 2
        Me.TableLayoutPanel6.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.40456!))
        Me.TableLayoutPanel6.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 88.59544!))
        Me.TableLayoutPanel6.Controls.Add(Me.txtStreetAddress, 1, 0)
        Me.TableLayoutPanel6.Controls.Add(Me.txtPostalCode, 0, 0)
        Me.TableLayoutPanel6.Location = New System.Drawing.Point(99, 4)
        Me.TableLayoutPanel6.Margin = New System.Windows.Forms.Padding(2)
        Me.TableLayoutPanel6.Name = "TableLayoutPanel6"
        Me.TableLayoutPanel6.RowCount = 1
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel6.Size = New System.Drawing.Size(625, 21)
        Me.TableLayoutPanel6.TabIndex = 11
        '
        'txtStreetAddress
        '
        Me.txtStreetAddress.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtStreetAddress.Location = New System.Drawing.Point(73, 2)
        Me.txtStreetAddress.Margin = New System.Windows.Forms.Padding(2)
        Me.txtStreetAddress.Name = "txtStreetAddress"
        Me.txtStreetAddress.ReadOnly = True
        Me.txtStreetAddress.Size = New System.Drawing.Size(550, 19)
        Me.txtStreetAddress.TabIndex = 16
        '
        'txtPostalCode
        '
        Me.txtPostalCode.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtPostalCode.Location = New System.Drawing.Point(2, 2)
        Me.txtPostalCode.Margin = New System.Windows.Forms.Padding(2)
        Me.txtPostalCode.Name = "txtPostalCode"
        Me.txtPostalCode.ReadOnly = True
        Me.txtPostalCode.Size = New System.Drawing.Size(67, 19)
        Me.txtPostalCode.TabIndex = 16
        '
        'VehicleInformationForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lblVer)
        Me.Controls.Add(Me.lblCopywriter)
        Me.Controls.Add(Me.TableLayoutPanel5)
        Me.Controls.Add(Me.TableLayoutPanel4)
        Me.Controls.Add(Me.TableLayoutPanel3)
        Me.Controls.Add(Me.TableLayoutPanel2)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "VehicleInformationForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "車両情報"
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        Me.TableLayoutPanel9.ResumeLayout(False)
        Me.TableLayoutPanel9.PerformLayout()
        Me.TableLayoutPanel8.ResumeLayout(False)
        Me.TableLayoutPanel8.PerformLayout()
        Me.TableLayoutPanel4.ResumeLayout(False)
        Me.TableLayoutPanel4.PerformLayout()
        Me.TableLayoutPanel5.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.TableLayoutPanel7.ResumeLayout(False)
        Me.TableLayoutPanel7.PerformLayout()
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.TableLayoutPanel3.PerformLayout()
        Me.TableLayoutPanel6.ResumeLayout(False)
        Me.TableLayoutPanel6.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents lblMailAddress As Label
    Friend WithEvents tblFullName As Label
    Friend WithEvents lblPhoneticFullName As Label
    Friend WithEvents lblPhoneNumber As Label
    Friend WithEvents TableLayoutPanel4 As TableLayoutPanel
    Friend WithEvents lblRemark As Label
    Friend WithEvents RichTxtRemark As RichTextBox
    Friend WithEvents TableLayoutPanel5 As TableLayoutPanel
    Friend WithEvents lblVer As Label
    Friend WithEvents lblCopywriter As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents btnReturn As Button
    Friend WithEvents txtPhoneNumber As TextBox
    Friend WithEvents txtMailAddress As TextBox
    Friend WithEvents lblModel As Label
    Friend WithEvents lblChassisNumber As Label
    Friend WithEvents lblCarName As Label
    Friend WithEvents lblManufacturer As Label
    Friend WithEvents lblPrimeMoverModel As Label
    Friend WithEvents lblModelDesignationNumber As Label
    Friend WithEvents lblCategoryNumber As Label
    Friend WithEvents lblMileage As Label
    Friend WithEvents lblFirstDate As Label
    Friend WithEvents lblLastInspectionDate As Label
    Friend WithEvents lblNextInspectionDate As Label
    Friend WithEvents lblOther As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtManufacturer As TextBox
    Friend WithEvents txtCarName As TextBox
    Friend WithEvents txtChassisNumber As TextBox
    Friend WithEvents txtModel As TextBox
    Friend WithEvents txtPrimeMoverModel As TextBox
    Friend WithEvents txtModelDesignationNumber As TextBox
    Friend WithEvents txtCategoryNumber As TextBox
    Friend WithEvents txtMileage As TextBox
    Friend WithEvents txtFirstDate As TextBox
    Friend WithEvents txtLastInspectionDate As TextBox
    Friend WithEvents txtNextInspectionDate As TextBox
    Friend WithEvents txtOther As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents lblCarRegistrationNumber As Label
    Friend WithEvents lblAddress As Label
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel9 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel8 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel7 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel6 As TableLayoutPanel
    Friend WithEvents txtPhoneticName As TextBox
    Friend WithEvents txtPhoneticSurname As TextBox
    Friend WithEvents txtName As TextBox
    Friend WithEvents txtSurname As TextBox
    Friend WithEvents txtDesignatedNumber As TextBox
    Friend WithEvents txtDiscriminationCharacter As TextBox
    Friend WithEvents txtClassNumber As TextBox
    Friend WithEvents txtHome As TextBox
    Friend WithEvents txtStreetAddress As TextBox
    Friend WithEvents txtPostalCode As TextBox
End Class
