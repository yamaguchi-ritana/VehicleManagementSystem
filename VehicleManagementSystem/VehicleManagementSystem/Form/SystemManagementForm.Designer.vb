<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SystemManagementForm
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
        Me.btnAccount = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnAccount
        '
        Me.btnAccount.Location = New System.Drawing.Point(26, 30)
        Me.btnAccount.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnAccount.Name = "btnAccount"
        Me.btnAccount.Size = New System.Drawing.Size(129, 32)
        Me.btnAccount.TabIndex = 1
        Me.btnAccount.Text = "アカウント(&A)"
        Me.btnAccount.UseVisualStyleBackColor = True
        '
        'SystemManagementForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1067, 562)
        Me.Controls.Add(Me.btnAccount)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "SystemManagementForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "システム管理"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnAccount As Button
End Class
