Public Class BackupSql
    Function Backup(path As String, nowDate As String) As String

        Dim sql As New System.Text.StringBuilder()

        sql.Append("BACKUP DATABASE VehicleManagementSystem TO DISK = '" + path + "\" + nowDate + ".bak" + "' ")
        sql.Append("With FORMAT, NAME = 'Full Backup of VehicleManagementSystem'; ")

        Return sql.ToString

    End Function
End Class
