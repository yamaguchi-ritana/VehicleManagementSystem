Public Class CharacterConst

    Private Const halfSpace As String = " "

    Private Const halfParenthesesStr As String = "("

    Private Const halfParenthesesEnd As String = ")"

    Private Const semicolon As String = ";"

    Private Const cDrive As String = "C:\"

    Private Const yyyyMMddHHmmss As String = "yyyyMMddHHmmss"

    Private Const yyyyMMddToJp As String = "yyyy年MM月dd日"

    Private Const dddToJp As String = "ddd"

    Public ReadOnly Property GetHalfSpace() As String
        Get
            Return halfSpace
        End Get
    End Property

    Public ReadOnly Property GetHalfParenthesesStr() As String
        Get
            Return halfParenthesesStr
        End Get
    End Property

    Public ReadOnly Property GetHalfParenthesesEnd() As String
        Get
            Return halfParenthesesEnd
        End Get
    End Property

    Public ReadOnly Property GetSemicolon() As String
        Get
            Return semicolon
        End Get
    End Property

    Public ReadOnly Property GetCDrive() As String
        Get
            Return cDrive
        End Get
    End Property

    Public ReadOnly Property GetyyyyMMddHHmmss() As String
        Get
            Return yyyyMMddHHmmss
        End Get
    End Property

    Public ReadOnly Property GetyyyyMMddToJp() As String
        Get
            Return yyyyMMddToJp
        End Get
    End Property

    Public ReadOnly Property GetdddToJp() As String
        Get
            Return dddToJp
        End Get
    End Property

End Class
