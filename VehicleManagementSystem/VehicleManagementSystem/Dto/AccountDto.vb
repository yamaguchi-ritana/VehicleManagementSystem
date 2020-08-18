Public Class AccountDto

    Private rowIndex As Integer

    Private id As String

    Private pw As String

    Public Property GsRowIndex() As Integer
        Get
            Return rowIndex
        End Get
        Set(ByVal value As Integer)
            rowIndex = value
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

End Class
