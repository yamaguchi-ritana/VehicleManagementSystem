Public Class SelectedVehicleDto

    Private rowIndex As Integer

    Private vehiclePk As Integer

    Public Property GsRowIndex() As Integer
        Get
            Return rowIndex
        End Get
        Set(ByVal value As Integer)
            rowIndex = value
        End Set
    End Property

    Public Property GsVehiclePk() As Integer
        Get
            Return vehiclePk
        End Get
        Set(ByVal value As Integer)
            vehiclePk = value
        End Set
    End Property

End Class
