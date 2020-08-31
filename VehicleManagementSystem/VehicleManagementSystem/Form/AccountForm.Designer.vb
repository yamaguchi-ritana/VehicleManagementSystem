<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AccountForm
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
        Me.gridSearchResults = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LblId = New System.Windows.Forms.Label()
        Me.LblPassword = New System.Windows.Forms.Label()
        Me.TxtId = New System.Windows.Forms.TextBox()
        Me.TxtPassword = New System.Windows.Forms.TextBox()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnReturn = New System.Windows.Forms.Button()
        Me.BtnDel = New System.Windows.Forms.Button()
        CType(Me.gridSearchResults, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gridSearchResults
        '
        Me.gridSearchResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gridSearchResults.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2})
        Me.gridSearchResults.Location = New System.Drawing.Point(22, 25)
        Me.gridSearchResults.Margin = New System.Windows.Forms.Padding(2)
        Me.gridSearchResults.MultiSelect = False
        Me.gridSearchResults.Name = "gridSearchResults"
        Me.gridSearchResults.ReadOnly = True
        Me.gridSearchResults.RowHeadersWidth = 51
        Me.gridSearchResults.RowTemplate.Height = 24
        Me.gridSearchResults.Size = New System.Drawing.Size(313, 402)
        Me.gridSearchResults.TabIndex = 0
        '
        'Column1
        '
        Me.Column1.HeaderText = "ID"
        Me.Column1.MinimumWidth = 6
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Width = 130
        '
        'Column2
        '
        Me.Column2.HeaderText = "Password"
        Me.Column2.MinimumWidth = 6
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        Me.Column2.Width = 130
        '
        'LblId
        '
        Me.LblId.AutoSize = True
        Me.LblId.Location = New System.Drawing.Point(353, 25)
        Me.LblId.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LblId.Name = "LblId"
        Me.LblId.Size = New System.Drawing.Size(16, 12)
        Me.LblId.TabIndex = 3
        Me.LblId.Text = "ID"
        '
        'LblPassword
        '
        Me.LblPassword.AutoSize = True
        Me.LblPassword.Location = New System.Drawing.Point(516, 25)
        Me.LblPassword.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LblPassword.Name = "LblPassword"
        Me.LblPassword.Size = New System.Drawing.Size(54, 12)
        Me.LblPassword.TabIndex = 4
        Me.LblPassword.Text = "Password"
        '
        'TxtId
        '
        Me.TxtId.Location = New System.Drawing.Point(356, 46)
        Me.TxtId.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtId.Name = "TxtId"
        Me.TxtId.Size = New System.Drawing.Size(144, 19)
        Me.TxtId.TabIndex = 5
        '
        'TxtPassword
        '
        Me.TxtPassword.Location = New System.Drawing.Point(518, 46)
        Me.TxtPassword.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtPassword.Name = "TxtPassword"
        Me.TxtPassword.Size = New System.Drawing.Size(144, 19)
        Me.TxtPassword.TabIndex = 6
        '
        'btnSearch
        '
        Me.btnSearch.Location = New System.Drawing.Point(683, 44)
        Me.btnSearch.Margin = New System.Windows.Forms.Padding(2)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(97, 26)
        Me.btnSearch.TabIndex = 7
        Me.btnSearch.Text = "検索(&S)"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(683, 95)
        Me.btnAdd.Margin = New System.Windows.Forms.Padding(2)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(97, 26)
        Me.btnAdd.TabIndex = 8
        Me.btnAdd.Text = "追加(&A)"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnUpdate
        '
        Me.btnUpdate.Location = New System.Drawing.Point(683, 147)
        Me.btnUpdate.Margin = New System.Windows.Forms.Padding(2)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(97, 25)
        Me.btnUpdate.TabIndex = 9
        Me.btnUpdate.Text = "更新(&U)"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'btnReturn
        '
        Me.btnReturn.Location = New System.Drawing.Point(683, 250)
        Me.btnReturn.Margin = New System.Windows.Forms.Padding(2)
        Me.btnReturn.Name = "btnReturn"
        Me.btnReturn.Size = New System.Drawing.Size(97, 25)
        Me.btnReturn.TabIndex = 10
        Me.btnReturn.Text = "戻る(&R)"
        Me.btnReturn.UseVisualStyleBackColor = True
        '
        'BtnDel
        '
        Me.BtnDel.Location = New System.Drawing.Point(683, 198)
        Me.BtnDel.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnDel.Name = "BtnDel"
        Me.BtnDel.Size = New System.Drawing.Size(97, 25)
        Me.BtnDel.TabIndex = 11
        Me.BtnDel.Text = "削除(&D)"
        Me.BtnDel.UseVisualStyleBackColor = True
        '
        'AccountForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.BtnDel)
        Me.Controls.Add(Me.btnReturn)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.TxtPassword)
        Me.Controls.Add(Me.TxtId)
        Me.Controls.Add(Me.LblPassword)
        Me.Controls.Add(Me.LblId)
        Me.Controls.Add(Me.gridSearchResults)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.MaximizeBox = False
        Me.Name = "AccountForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "アカウント"
        CType(Me.gridSearchResults, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents gridSearchResults As DataGridView
    Friend WithEvents LblId As Label
    Friend WithEvents LblPassword As Label
    Friend WithEvents TxtId As TextBox
    Friend WithEvents TxtPassword As TextBox
    Friend WithEvents btnSearch As Button
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnReturn As Button
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents BtnDel As Button
End Class
