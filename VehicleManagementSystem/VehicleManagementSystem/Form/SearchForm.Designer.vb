<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SearchForm
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
        Me.lblSurname = New System.Windows.Forms.Label()
        Me.lblName = New System.Windows.Forms.Label()
        Me.lblPhoneNumber = New System.Windows.Forms.Label()
        Me.lblDiscriminationCharacter = New System.Windows.Forms.Label()
        Me.lblDesignatedNumber = New System.Windows.Forms.Label()
        Me.txtSurname = New System.Windows.Forms.TextBox()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.txtPhoneNumber = New System.Windows.Forms.TextBox()
        Me.txtDiscriminationCharacter = New System.Windows.Forms.TextBox()
        Me.txtDesignatedNumber = New System.Windows.Forms.TextBox()
        Me.gridSearchResults = New System.Windows.Forms.DataGridView()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.lblVer = New System.Windows.Forms.Label()
        Me.lblCopywriter = New System.Windows.Forms.Label()
        Me.colName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colManufacturer = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colCarName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colHome = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colClassNumber = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colCharacter = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colDesignatedNumber = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colLastInspectionDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.gridSearchResults, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblSurname
        '
        Me.lblSurname.AutoSize = True
        Me.lblSurname.Location = New System.Drawing.Point(13, 34)
        Me.lblSurname.Name = "lblSurname"
        Me.lblSurname.Size = New System.Drawing.Size(17, 12)
        Me.lblSurname.TabIndex = 0
        Me.lblSurname.Text = "姓"
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Location = New System.Drawing.Point(131, 34)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(17, 12)
        Me.lblName.TabIndex = 1
        Me.lblName.Text = "名"
        '
        'lblPhoneNumber
        '
        Me.lblPhoneNumber.AutoSize = True
        Me.lblPhoneNumber.Location = New System.Drawing.Point(253, 34)
        Me.lblPhoneNumber.Name = "lblPhoneNumber"
        Me.lblPhoneNumber.Size = New System.Drawing.Size(53, 12)
        Me.lblPhoneNumber.TabIndex = 2
        Me.lblPhoneNumber.Text = "電話番号"
        '
        'lblDiscriminationCharacter
        '
        Me.lblDiscriminationCharacter.AutoSize = True
        Me.lblDiscriminationCharacter.Location = New System.Drawing.Point(374, 34)
        Me.lblDiscriminationCharacter.Name = "lblDiscriminationCharacter"
        Me.lblDiscriminationCharacter.Size = New System.Drawing.Size(53, 12)
        Me.lblDiscriminationCharacter.TabIndex = 3
        Me.lblDiscriminationCharacter.Text = "判別文字"
        '
        'lblDesignatedNumber
        '
        Me.lblDesignatedNumber.AutoSize = True
        Me.lblDesignatedNumber.Location = New System.Drawing.Point(493, 34)
        Me.lblDesignatedNumber.Name = "lblDesignatedNumber"
        Me.lblDesignatedNumber.Size = New System.Drawing.Size(53, 12)
        Me.lblDesignatedNumber.TabIndex = 4
        Me.lblDesignatedNumber.Text = "指定番号"
        '
        'txtSurname
        '
        Me.txtSurname.Location = New System.Drawing.Point(12, 49)
        Me.txtSurname.Name = "txtSurname"
        Me.txtSurname.Size = New System.Drawing.Size(100, 19)
        Me.txtSurname.TabIndex = 0
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(132, 49)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(100, 19)
        Me.txtName.TabIndex = 5
        '
        'txtPhoneNumber
        '
        Me.txtPhoneNumber.Location = New System.Drawing.Point(255, 49)
        Me.txtPhoneNumber.Name = "txtPhoneNumber"
        Me.txtPhoneNumber.Size = New System.Drawing.Size(100, 19)
        Me.txtPhoneNumber.TabIndex = 6
        '
        'txtDiscriminationCharacter
        '
        Me.txtDiscriminationCharacter.Location = New System.Drawing.Point(376, 49)
        Me.txtDiscriminationCharacter.Name = "txtDiscriminationCharacter"
        Me.txtDiscriminationCharacter.Size = New System.Drawing.Size(100, 19)
        Me.txtDiscriminationCharacter.TabIndex = 7
        '
        'txtDesignatedNumber
        '
        Me.txtDesignatedNumber.Location = New System.Drawing.Point(495, 49)
        Me.txtDesignatedNumber.Name = "txtDesignatedNumber"
        Me.txtDesignatedNumber.Size = New System.Drawing.Size(100, 19)
        Me.txtDesignatedNumber.TabIndex = 8
        '
        'gridSearchResults
        '
        Me.gridSearchResults.AllowUserToOrderColumns = True
        Me.gridSearchResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gridSearchResults.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colName, Me.colManufacturer, Me.colCarName, Me.colHome, Me.colClassNumber, Me.colCharacter, Me.colDesignatedNumber, Me.colLastInspectionDate})
        Me.gridSearchResults.Location = New System.Drawing.Point(12, 87)
        Me.gridSearchResults.Name = "gridSearchResults"
        Me.gridSearchResults.RowTemplate.Height = 21
        Me.gridSearchResults.Size = New System.Drawing.Size(775, 328)
        Me.gridSearchResults.TabIndex = 9
        '
        'btnSearch
        '
        Me.btnSearch.Location = New System.Drawing.Point(621, 45)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(75, 26)
        Me.btnSearch.TabIndex = 10
        Me.btnSearch.Text = "検索(&S)"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'lblVer
        '
        Me.lblVer.AutoSize = True
        Me.lblVer.Location = New System.Drawing.Point(399, 431)
        Me.lblVer.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblVer.Name = "lblVer"
        Me.lblVer.Size = New System.Drawing.Size(45, 12)
        Me.lblVer.TabIndex = 12
        Me.lblVer.Text = "ver予定"
        '
        'lblCopywriter
        '
        Me.lblCopywriter.AutoSize = True
        Me.lblCopywriter.Location = New System.Drawing.Point(356, 432)
        Me.lblCopywriter.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblCopywriter.Name = "lblCopywriter"
        Me.lblCopywriter.Size = New System.Drawing.Size(40, 12)
        Me.lblCopywriter.TabIndex = 11
        Me.lblCopywriter.Text = "© 1GW"
        '
        'colName
        '
        Me.colName.HeaderText = "氏名"
        Me.colName.Name = "colName"
        Me.colName.ReadOnly = True
        Me.colName.Width = 102
        '
        'colManufacturer
        '
        Me.colManufacturer.HeaderText = "メーカー"
        Me.colManufacturer.Name = "colManufacturer"
        '
        'colCarName
        '
        Me.colCarName.HeaderText = "車名"
        Me.colCarName.Name = "colCarName"
        '
        'colHome
        '
        Me.colHome.HeaderText = "本拠地"
        Me.colHome.Name = "colHome"
        Me.colHome.ReadOnly = True
        Me.colHome.Width = 80
        '
        'colClassNumber
        '
        Me.colClassNumber.HeaderText = "分類番号"
        Me.colClassNumber.Name = "colClassNumber"
        Me.colClassNumber.ReadOnly = True
        Me.colClassNumber.Width = 90
        '
        'colCharacter
        '
        Me.colCharacter.HeaderText = "判別文字"
        Me.colCharacter.Name = "colCharacter"
        Me.colCharacter.ReadOnly = True
        Me.colCharacter.Width = 80
        '
        'colDesignatedNumber
        '
        Me.colDesignatedNumber.HeaderText = "指定番号"
        Me.colDesignatedNumber.Name = "colDesignatedNumber"
        Me.colDesignatedNumber.ReadOnly = True
        Me.colDesignatedNumber.Width = 80
        '
        'colLastInspectionDate
        '
        Me.colLastInspectionDate.HeaderText = "前回点検日"
        Me.colLastInspectionDate.Name = "colLastInspectionDate"
        Me.colLastInspectionDate.ReadOnly = True
        '
        'SearchForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lblVer)
        Me.Controls.Add(Me.lblCopywriter)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.gridSearchResults)
        Me.Controls.Add(Me.txtDesignatedNumber)
        Me.Controls.Add(Me.txtDiscriminationCharacter)
        Me.Controls.Add(Me.txtPhoneNumber)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.txtSurname)
        Me.Controls.Add(Me.lblDesignatedNumber)
        Me.Controls.Add(Me.lblDiscriminationCharacter)
        Me.Controls.Add(Me.lblPhoneNumber)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.lblSurname)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "SearchForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "検索"
        CType(Me.gridSearchResults, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblSurname As Label
    Friend WithEvents lblName As Label
    Friend WithEvents lblPhoneNumber As Label
    Friend WithEvents lblDiscriminationCharacter As Label
    Friend WithEvents lblDesignatedNumber As Label
    Friend WithEvents txtSurname As TextBox
    Friend WithEvents txtName As TextBox
    Friend WithEvents txtPhoneNumber As TextBox
    Friend WithEvents txtDiscriminationCharacter As TextBox
    Friend WithEvents txtDesignatedNumber As TextBox
    Friend WithEvents gridSearchResults As DataGridView
    Friend WithEvents btnSearch As Button
    Friend WithEvents lblVer As Label
    Friend WithEvents lblCopywriter As Label
    Friend WithEvents colName As DataGridViewTextBoxColumn
    Friend WithEvents colManufacturer As DataGridViewTextBoxColumn
    Friend WithEvents colCarName As DataGridViewTextBoxColumn
    Friend WithEvents colHome As DataGridViewTextBoxColumn
    Friend WithEvents colClassNumber As DataGridViewTextBoxColumn
    Friend WithEvents colCharacter As DataGridViewTextBoxColumn
    Friend WithEvents colDesignatedNumber As DataGridViewTextBoxColumn
    Friend WithEvents colLastInspectionDate As DataGridViewTextBoxColumn
End Class
