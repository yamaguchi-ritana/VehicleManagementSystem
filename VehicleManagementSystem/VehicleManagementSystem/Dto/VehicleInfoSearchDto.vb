Public Class VehicleInfoSearchDto

    Private surname As String

    Private name As String

    Private phoneNumber As String

    Private discriminationChar As String

    Private designatedNumber As String

    Public Property GsSurname() As String
        Get
            Return surname
        End Get
        Set(ByVal value As String)
            surname = value
        End Set
    End Property

    Public Property GsName() As String
        Get
            Return name
        End Get
        Set(ByVal value As String)
            name = value
        End Set
    End Property

    Public Property GsPhoneNumber() As String
        Get
            Return phoneNumber
        End Get
        Set(ByVal value As String)
            phoneNumber = value
        End Set
    End Property

    Public Property GsDiscriminationChar() As String
        Get
            Return discriminationChar
        End Get
        Set(ByVal value As String)
            discriminationChar = value
        End Set
    End Property

    Public Property GsDesignatedNumber() As String
        Get
            Return designatedNumber
        End Get
        Set(ByVal value As String)
            designatedNumber = value
        End Set
    End Property


End Class
