Public Class CharacterConst

    Private Const halfSpace As String = " "

    Private Const halfParenthesesStr As String = "("

    Private Const halfParenthesesEnd As String = ")"

    Private Const semicolon As String = ";"

    Private Const cDrive As String = "C:\"

    Private Const yyyyMMddHHmmss As String = "yyyyMMddHHmmss"

    Private Const yrSlashMo As String = "yyyy/MM"

    Private Const yyyyMMddToJp As String = "yyyy年MM月dd日"

    Private Const dddToJp As String = "ddd"

    Private Const dd As String = "dd"

    Private Const slashZeroOne As String = "/01"

    Private Const sunday As String = "日"

    Private Const monday As String = "月"

    Private Const tuesday As String = "火"

    Private Const wednesday As String = "水"

    Private Const thursday As String = "木"

    Private Const friday As String = "金"

    Private Const saturday As String = "土"

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

    Public ReadOnly Property GetYrSlashMo() As String
        Get
            Return yrSlashMo
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

    Public ReadOnly Property Getdd() As String
        Get
            Return dd
        End Get
    End Property

    Public ReadOnly Property GetSlashZeroOne() As String
        Get
            Return slashZeroOne
        End Get
    End Property

    Public ReadOnly Property GetSunday() As String
        Get
            Return sunday
        End Get
    End Property

    Public ReadOnly Property GetMonday() As String
        Get
            Return monday
        End Get
    End Property

    Public ReadOnly Property GetTuesday() As String
        Get
            Return tuesday
        End Get
    End Property

    Public ReadOnly Property GetWednesday() As String
        Get
            Return wednesday
        End Get
    End Property

    Public ReadOnly Property GetThursday() As String
        Get
            Return thursday
        End Get
    End Property

    Public ReadOnly Property GetFriday() As String
        Get
            Return friday
        End Get
    End Property

    Public ReadOnly Property GetSaturday() As String
        Get
            Return saturday
        End Get
    End Property

End Class
