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

    Private Const addedAccount As String = "アカウントを追加しました。"

    Private Const addAccount As String = "アカウントの追加"

    Private Const idOrPwChk As String = "IDまたはPassword入力して下さい。"

    Private Const idOrPwChkErr As String = "IDまたはPassword入力チェックエラー"

    Private Const userSlctChk As String = "ユーザーを選択して下さい。"

    Private Const userSlctChkErr As String = "ユーザーを選択チェックエラー"

    Private Const updedOtherUserChk As String = "他のユーザーに更新されています。"

    Private Const acctAddChk As String = "アカウントを追加します。"

    Private Const acctAddCfm As String = "アカウント追加確認"

    Private Const acctUpdChk As String = "アカウントを更新します。"

    Private Const acctUpdCfm As String = "アカウント更新確認"

    Private Const acctDelChk As String = "アカウントを削除します。"

    Private Const acctDelCfm As String = "アカウント削除確認"

    Private Const updedAcct As String = "アカウントを更新しました。"

    Private Const updAcct As String = "アカウントの更新"

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

    Public ReadOnly Property GetAddedAccount() As String
        Get
            Return addedAccount
        End Get
    End Property

    Public ReadOnly Property GetAddAccount() As String
        Get
            Return addAccount
        End Get
    End Property

    Public ReadOnly Property GetIdOrPwChk() As String
        Get
            Return IdOrPwChk
        End Get
    End Property

    Public ReadOnly Property GetIdOrPwChkErr() As String
        Get
            Return IdOrPwChkErr
        End Get
    End Property

    Public ReadOnly Property GetUserSlctChk() As String
        Get
            Return userSlctChk
        End Get
    End Property

    Public ReadOnly Property GetUserSlctChkErr() As String
        Get
            Return userSlctChkErr
        End Get
    End Property

    Public ReadOnly Property GetUpdedOtherUserChk() As String
        Get
            Return updedOtherUserChk
        End Get
    End Property

    Public ReadOnly Property GetAcctAddChk() As String
        Get
            Return acctAddChk
        End Get
    End Property

    Public ReadOnly Property GetAcctAddCfm() As String
        Get
            Return acctAddCfm
        End Get
    End Property

    Public ReadOnly Property GetAcctUpdChk() As String
        Get
            Return acctUpdChk
        End Get
    End Property

    Public ReadOnly Property GetAcctUpdCfm() As String
        Get
            Return acctUpdCfm
        End Get
    End Property

    Public ReadOnly Property GetAcctDelChk() As String
        Get
            Return acctDelChk
        End Get
    End Property

    Public ReadOnly Property GetAcctDelCfm() As String
        Get
            Return acctDelCfm
        End Get
    End Property

    Public ReadOnly Property GetUpdedAcct() As String
        Get
            Return updedAcct
        End Get
    End Property

    Public ReadOnly Property GetUpdAcct() As String
        Get
            Return updAcct
        End Get
    End Property

End Class
