<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BackupForm
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
        Me.lblBackupDestination = New System.Windows.Forms.Label()
        Me.txtPath = New System.Windows.Forms.TextBox()
        Me.btnFaldaSelection = New System.Windows.Forms.Button()
        Me.btnReturn = New System.Windows.Forms.Button()
        Me.btnExecution = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblBackupDestination
        '
        Me.lblBackupDestination.AutoSize = True
        Me.lblBackupDestination.Location = New System.Drawing.Point(48, 136)
        Me.lblBackupDestination.Name = "lblBackupDestination"
        Me.lblBackupDestination.Size = New System.Drawing.Size(85, 15)
        Me.lblBackupDestination.TabIndex = 0
        Me.lblBackupDestination.Text = "バックアップ先"
        '
        'txtPath
        '
        Me.txtPath.Location = New System.Drawing.Point(51, 154)
        Me.txtPath.Name = "txtPath"
        Me.txtPath.Size = New System.Drawing.Size(574, 22)
        Me.txtPath.TabIndex = 1
        Me.txtPath.Text = "C:\VehicleManagementSystem\DB\backup"
        '
        'btnFaldaSelection
        '
        Me.btnFaldaSelection.Location = New System.Drawing.Point(631, 147)
        Me.btnFaldaSelection.Name = "btnFaldaSelection"
        Me.btnFaldaSelection.Size = New System.Drawing.Size(119, 34)
        Me.btnFaldaSelection.TabIndex = 2
        Me.btnFaldaSelection.Text = "フォルダ選択(&S)"
        Me.btnFaldaSelection.UseVisualStyleBackColor = True
        '
        'btnReturn
        '
        Me.btnReturn.Location = New System.Drawing.Point(51, 217)
        Me.btnReturn.Name = "btnReturn"
        Me.btnReturn.Size = New System.Drawing.Size(119, 34)
        Me.btnReturn.TabIndex = 3
        Me.btnReturn.Text = "戻る(&R)"
        Me.btnReturn.UseVisualStyleBackColor = True
        '
        'btnExecution
        '
        Me.btnExecution.Location = New System.Drawing.Point(190, 217)
        Me.btnExecution.Name = "btnExecution"
        Me.btnExecution.Size = New System.Drawing.Size(119, 34)
        Me.btnExecution.TabIndex = 4
        Me.btnExecution.Text = "実行(&E)"
        Me.btnExecution.UseVisualStyleBackColor = True
        '
        'BackupForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnExecution)
        Me.Controls.Add(Me.btnReturn)
        Me.Controls.Add(Me.btnFaldaSelection)
        Me.Controls.Add(Me.txtPath)
        Me.Controls.Add(Me.lblBackupDestination)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "BackupForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "BackupForm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblBackupDestination As Label
    Friend WithEvents txtPath As TextBox
    Friend WithEvents btnFaldaSelection As Button
    Friend WithEvents btnReturn As Button
    Friend WithEvents btnExecution As Button
End Class
