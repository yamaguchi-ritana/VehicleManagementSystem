<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class LoginForm
    Inherits System.Windows.Forms.Form

    'フォームがコンポーネントの一覧をクリーンアップするために dispose をオーバーライドします。
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.txtId = New System.Windows.Forms.TextBox()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.btnLogin = New System.Windows.Forms.Button()
        Me.lblId = New System.Windows.Forms.Label()
        Me.lblPassword = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnEnd = New System.Windows.Forms.Button()
        Me.lblVer = New System.Windows.Forms.Label()
        Me.lblCopywriter = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtId
        '
        Me.txtId.Location = New System.Drawing.Point(125, 86)
        Me.txtId.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtId.Name = "txtId"
        Me.txtId.Size = New System.Drawing.Size(152, 19)
        Me.txtId.TabIndex = 2
        '
        'txtPassword
        '
        Me.txtPassword.Location = New System.Drawing.Point(125, 146)
        Me.txtPassword.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9679)
        Me.txtPassword.Size = New System.Drawing.Size(152, 19)
        Me.txtPassword.TabIndex = 4
        '
        'btnLogin
        '
        Me.btnLogin.Location = New System.Drawing.Point(125, 182)
        Me.btnLogin.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(69, 24)
        Me.btnLogin.TabIndex = 5
        Me.btnLogin.Text = "ログイン(&L)"
        Me.btnLogin.UseVisualStyleBackColor = True
        '
        'lblId
        '
        Me.lblId.AutoSize = True
        Me.lblId.Location = New System.Drawing.Point(125, 70)
        Me.lblId.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblId.Name = "lblId"
        Me.lblId.Size = New System.Drawing.Size(16, 12)
        Me.lblId.TabIndex = 1
        Me.lblId.Text = "ID"
        '
        'lblPassword
        '
        Me.lblPassword.AutoSize = True
        Me.lblPassword.Location = New System.Drawing.Point(125, 129)
        Me.lblPassword.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblPassword.Name = "lblPassword"
        Me.lblPassword.Size = New System.Drawing.Size(54, 12)
        Me.lblPassword.TabIndex = 3
        Me.lblPassword.Text = "Password"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(125, 30)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(66, 12)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "イメージ予定"
        '
        'btnEnd
        '
        Me.btnEnd.Location = New System.Drawing.Point(208, 182)
        Me.btnEnd.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnEnd.Name = "btnEnd"
        Me.btnEnd.Size = New System.Drawing.Size(69, 24)
        Me.btnEnd.TabIndex = 6
        Me.btnEnd.Text = "終了(&E)"
        Me.btnEnd.UseVisualStyleBackColor = True
        '
        'lblVer
        '
        Me.lblVer.AutoSize = True
        Me.lblVer.Location = New System.Drawing.Point(192, 253)
        Me.lblVer.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblVer.Name = "lblVer"
        Me.lblVer.Size = New System.Drawing.Size(45, 12)
        Me.lblVer.TabIndex = 10
        Me.lblVer.Text = "ver予定"
        '
        'lblCopywriter
        '
        Me.lblCopywriter.AutoSize = True
        Me.lblCopywriter.Location = New System.Drawing.Point(149, 254)
        Me.lblCopywriter.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblCopywriter.Name = "lblCopywriter"
        Me.lblCopywriter.Size = New System.Drawing.Size(40, 12)
        Me.lblCopywriter.TabIndex = 9
        Me.lblCopywriter.Text = "© 1GW"
        '
        'LoginForm
        '
        Me.AcceptButton = Me.btnLogin
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(386, 272)
        Me.Controls.Add(Me.lblVer)
        Me.Controls.Add(Me.lblCopywriter)
        Me.Controls.Add(Me.btnEnd)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lblPassword)
        Me.Controls.Add(Me.lblId)
        Me.Controls.Add(Me.btnLogin)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.txtId)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.MaximizeBox = False
        Me.Name = "LoginForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ログイン"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtId As TextBox
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents btnLogin As Button
    Friend WithEvents lblId As Label
    Friend WithEvents lblPassword As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents btnEnd As Button
    Friend WithEvents lblVer As Label
    Friend WithEvents lblCopywriter As Label
End Class
