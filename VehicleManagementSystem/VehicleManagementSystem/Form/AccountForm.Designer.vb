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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lblId = New System.Windows.Forms.Label()
        Me.lblPassword = New System.Windows.Forms.Label()
        Me.txtId = New System.Windows.Forms.TextBox()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.btnInsert = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnReturn = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2})
        Me.DataGridView1.Location = New System.Drawing.Point(29, 31)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(417, 503)
        Me.DataGridView1.TabIndex = 0
        '
        'Column1
        '
        Me.Column1.HeaderText = "ID"
        Me.Column1.MinimumWidth = 6
        Me.Column1.Name = "Column1"
        Me.Column1.Width = 130
        '
        'Column2
        '
        Me.Column2.HeaderText = "Password"
        Me.Column2.MinimumWidth = 6
        Me.Column2.Name = "Column2"
        Me.Column2.Width = 130
        '
        'lblId
        '
        Me.lblId.AutoSize = True
        Me.lblId.Location = New System.Drawing.Point(471, 31)
        Me.lblId.Name = "lblId"
        Me.lblId.Size = New System.Drawing.Size(21, 15)
        Me.lblId.TabIndex = 3
        Me.lblId.Text = "ID"
        '
        'lblPassword
        '
        Me.lblPassword.AutoSize = True
        Me.lblPassword.Location = New System.Drawing.Point(688, 31)
        Me.lblPassword.Name = "lblPassword"
        Me.lblPassword.Size = New System.Drawing.Size(67, 15)
        Me.lblPassword.TabIndex = 4
        Me.lblPassword.Text = "Password"
        '
        'txtId
        '
        Me.txtId.Location = New System.Drawing.Point(474, 57)
        Me.txtId.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtId.Name = "txtId"
        Me.txtId.Size = New System.Drawing.Size(190, 22)
        Me.txtId.TabIndex = 5
        '
        'txtPassword
        '
        Me.txtPassword.Location = New System.Drawing.Point(691, 57)
        Me.txtPassword.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9679)
        Me.txtPassword.Size = New System.Drawing.Size(190, 22)
        Me.txtPassword.TabIndex = 6
        '
        'btnSearch
        '
        Me.btnSearch.Location = New System.Drawing.Point(911, 55)
        Me.btnSearch.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(129, 32)
        Me.btnSearch.TabIndex = 7
        Me.btnSearch.Text = "検索(&S)"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'btnInsert
        '
        Me.btnInsert.Location = New System.Drawing.Point(911, 121)
        Me.btnInsert.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnInsert.Name = "btnInsert"
        Me.btnInsert.Size = New System.Drawing.Size(129, 32)
        Me.btnInsert.TabIndex = 8
        Me.btnInsert.Text = "追加(&I)"
        Me.btnInsert.UseVisualStyleBackColor = True
        '
        'btnUpdate
        '
        Me.btnUpdate.Location = New System.Drawing.Point(911, 186)
        Me.btnUpdate.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(129, 31)
        Me.btnUpdate.TabIndex = 9
        Me.btnUpdate.Text = "更新(&U)"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'btnReturn
        '
        Me.btnReturn.Location = New System.Drawing.Point(911, 252)
        Me.btnReturn.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnReturn.Name = "btnReturn"
        Me.btnReturn.Size = New System.Drawing.Size(129, 31)
        Me.btnReturn.TabIndex = 10
        Me.btnReturn.Text = "戻る(&R)"
        Me.btnReturn.UseVisualStyleBackColor = True
        '
        'AccountForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1067, 562)
        Me.Controls.Add(Me.btnReturn)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.btnInsert)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.txtId)
        Me.Controls.Add(Me.lblPassword)
        Me.Controls.Add(Me.lblId)
        Me.Controls.Add(Me.DataGridView1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "AccountForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "アカウント"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents lblId As Label
    Friend WithEvents lblPassword As Label
    Friend WithEvents txtId As TextBox
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents btnSearch As Button
    Friend WithEvents btnInsert As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnReturn As Button
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
End Class
