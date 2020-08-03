<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TOPForm
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
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblVer = New System.Windows.Forms.Label()
        Me.lblCopywriter = New System.Windows.Forms.Label()
        Me.btnBackup = New System.Windows.Forms.Button()
        Me.btnEnd = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnSearch
        '
        Me.btnSearch.Location = New System.Drawing.Point(477, 32)
        Me.btnSearch.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(129, 32)
        Me.btnSearch.TabIndex = 0
        Me.btnSearch.Text = "検索(&S)"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(627, 32)
        Me.Button2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(129, 32)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "登録(&R)"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(477, 92)
        Me.Button3.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(129, 31)
        Me.Button3.TabIndex = 2
        Me.Button3.Text = "修正(&U)"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(627, 92)
        Me.Button4.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(129, 31)
        Me.Button4.TabIndex = 3
        Me.Button4.Text = "通知一覧(&N)"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(477, 149)
        Me.Button5.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(129, 31)
        Me.Button5.TabIndex = 4
        Me.Button5.Text = "システム管理(&M)"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(205, 182)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(82, 15)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "イメージ予定"
        '
        'lblVer
        '
        Me.lblVer.AutoSize = True
        Me.lblVer.Location = New System.Drawing.Point(404, 426)
        Me.lblVer.Name = "lblVer"
        Me.lblVer.Size = New System.Drawing.Size(57, 15)
        Me.lblVer.TabIndex = 10
        Me.lblVer.Text = "ver予定"
        '
        'lblCopywriter
        '
        Me.lblCopywriter.AutoSize = True
        Me.lblCopywriter.Location = New System.Drawing.Point(347, 428)
        Me.lblCopywriter.Name = "lblCopywriter"
        Me.lblCopywriter.Size = New System.Drawing.Size(51, 15)
        Me.lblCopywriter.TabIndex = 9
        Me.lblCopywriter.Text = "© 1GW"
        '
        'btnBackup
        '
        Me.btnBackup.Location = New System.Drawing.Point(627, 149)
        Me.btnBackup.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnBackup.Name = "btnBackup"
        Me.btnBackup.Size = New System.Drawing.Size(129, 31)
        Me.btnBackup.TabIndex = 11
        Me.btnBackup.Text = "バックアップ(&B)"
        Me.btnBackup.UseVisualStyleBackColor = True
        '
        'btnEnd
        '
        Me.btnEnd.Location = New System.Drawing.Point(627, 365)
        Me.btnEnd.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnEnd.Name = "btnEnd"
        Me.btnEnd.Size = New System.Drawing.Size(129, 30)
        Me.btnEnd.TabIndex = 12
        Me.btnEnd.Text = "終了(&E)"
        Me.btnEnd.UseVisualStyleBackColor = True
        '
        'TOPForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnEnd)
        Me.Controls.Add(Me.btnBackup)
        Me.Controls.Add(Me.lblVer)
        Me.Controls.Add(Me.lblCopywriter)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.btnSearch)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.MaximizeBox = False
        Me.Name = "TOPForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "TOP"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnSearch As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents lblVer As Label
    Friend WithEvents lblCopywriter As Label
    Friend WithEvents btnBackup As Button
    Friend WithEvents btnEnd As Button
End Class
