Public Class DBConnInfoCommon

    ' App.configからDB接続情報を取得
    ReadOnly dbConnInfo As String = System.Configuration.ConfigurationManager.ConnectionStrings("DBConnInfo").ToString

    Public ReadOnly Property GetDBConnInfo() As String
        Get
            Return dbConnInfo
        End Get
    End Property

End Class
