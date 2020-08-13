Public Class MessageConst

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

    Private Const backupCreatedSuccess As String = "バックアップの作成に成功しました。"

    Private Const createBackup As String = "バックアップの作成"

    Private Const folderDoesNotExist As String = "指定のフォルダは、存在しません。"

    Private Const folderExistChk As String = "フォルダの存在チェックエラー"

    Private Const backupDestination As String = "バックアップ先を指定してください。"

    Private Const idIsIncorrect As String = "既にIDが存在します。"

    Private Const idChkErr As String = "IDチェックエラー"

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

    Public ReadOnly Property GetBackupCreatedSuccess() As String
        Get
            Return backupCreatedSuccess
        End Get
    End Property

    Public ReadOnly Property GetCreateBackup() As String
        Get
            Return createBackup
        End Get
    End Property

    Public ReadOnly Property GetFolderDoesNotExist() As String
        Get
            Return folderDoesNotExist
        End Get
    End Property

    Public ReadOnly Property GetFolderExistChk() As String
        Get
            Return folderExistChk
        End Get
    End Property

    Public ReadOnly Property GetCbackupDestination() As String
        Get
            Return backupDestination
        End Get
    End Property

    Public ReadOnly Property GetIdIsIncorrect() As String
        Get
            Return idIsIncorrect
        End Get
    End Property

    Public ReadOnly Property GetIdChkErr() As String
        Get
            Return idChkErr
        End Get
    End Property

End Class
