Public Class ErrorMessageConst

    Private Const enterId As String = "IDを入力して下さい。"

    Private Const idInputChkErr As String = "ID入力チェックエラー"

    Private Const enterPw As String = "Passwordを入力して下さい。"

    Private Const pwInputChkErr As String = "Password入力チェックエラー"

    Private Const cannotEnterSemicolonId As String = "IDに"";""は入力できません。"

    Private Const idCharChkErr As String = "ID文字チェックエラー"

    Private Const cannotEnterSemicolonPw As String = "Passwordに"";""は入力できません。"

    Private Const pwCharChkErr As String = "Password文字チェックエラー"

    Private Const idOrPwIsIncorrect As String = "IDまたはPasswordが誤っています。"

    Private Const accountChkErr As String = "アカウントチェックエラー"

    Private Const vehicleInfoDoesNotExist As String = "車両情報が存在しません。"

    Private Const vehicleInfoChk As String = "車両情報存在チェック"

    Public ReadOnly Property GetEnterId() As String
        Get
            Return enterId
        End Get
    End Property

    Public ReadOnly Property GetIdInputChkErr() As String
        Get
            Return idInputChkErr
        End Get
    End Property

    Public ReadOnly Property GetEnterPw() As String
        Get
            Return enterPw
        End Get
    End Property

    Public ReadOnly Property GetPwInputChkErr() As String
        Get
            Return pwInputChkErr
        End Get
    End Property

    Public ReadOnly Property GetCannotEnterSemicolonId() As String
        Get
            Return cannotEnterSemicolonId
        End Get
    End Property

    Public ReadOnly Property GetIdCharChkErr() As String
        Get
            Return idCharChkErr
        End Get
    End Property

    Public ReadOnly Property GetCannotEnterSemicolonPw() As String
        Get
            Return cannotEnterSemicolonPw
        End Get
    End Property

    Public ReadOnly Property GetPwCharChkErr() As String
        Get
            Return pwCharChkErr
        End Get
    End Property

    Public ReadOnly Property GetIdOrPwIsIncorrect() As String
        Get
            Return idOrPwIsIncorrect
        End Get
    End Property

    Public ReadOnly Property GetAccountChkErr() As String
        Get
            Return accountChkErr
        End Get
    End Property

    Public ReadOnly Property GetVehicleInfoDoesNotExist() As String
        Get
            Return vehicleInfoDoesNotExist
        End Get
    End Property

    Public ReadOnly Property GetVehicleInfoChk() As String
        Get
            Return vehicleInfoChk
        End Get
    End Property

End Class
