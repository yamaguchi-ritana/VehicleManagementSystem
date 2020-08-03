Public Class CharacterConst
    Private Const semicolon As String = ";"

    Private Const cDrive As String = "C:\"

    Private Const yyyyMMddHHmmss As String = "yyyyMMddHHmmss"

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

End Class
