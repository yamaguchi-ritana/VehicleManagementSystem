Public Class AccountChkResultDto

    Dim processEndFlg As Boolean

    Dim command As New SqlClient.SqlCommand

    Dim id As String

    Dim pw As String

    Dim updDtTime As String

    Public Property GsProcessEndFlg() As Boolean
        Get
            Return processEndFlg
        End Get
        Set(ByVal value As Boolean)
            processEndFlg = value
        End Set
    End Property

    Public Property GsCommand() As SqlClient.SqlCommand
        Get
            Return command
        End Get
        Set(ByVal value As SqlClient.SqlCommand)
            command = value
        End Set
    End Property

    Public Property GsId() As String
        Get
            Return id
        End Get
        Set(ByVal value As String)
            id = value
        End Set
    End Property

    Public Property GsPw() As String
        Get
            Return pw
        End Get
        Set(ByVal value As String)
            pw = value
        End Set
    End Property

    Public Property GsUpdDtTime() As String
        Get
            Return updDtTime
        End Get
        Set(ByVal value As String)
            updDtTime = value
        End Set
    End Property

End Class
