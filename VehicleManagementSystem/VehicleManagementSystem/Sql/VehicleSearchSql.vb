Public Class VehicleSearchSql

    Function VehicleInfoSearch(dto As VehicleInfoSearchDto) As String

        Dim sql As New System.Text.StringBuilder()

        sql.Append("SELECT ")
        sql.Append("tu.surname + ' ' + tu.name as full_name, ")
        sql.Append("tv.vehicle_pk, ")
        sql.Append("tv.manufacturer, ")
        sql.Append("tv.car_name, ")
        sql.Append("tv.home, ")
        sql.Append("tv.class_number, ")
        sql.Append("tv.discrimination_character, ")
        sql.Append("tv.designated_number, ")
        sql.Append("tv.last_inspection_date ")
        sql.Append("FROM ")
        sql.Append("t_user tu ")
        sql.Append("INNER JOIN ")
        sql.Append("t_vehicle tv ")
        sql.Append("ON tu.user_pk = tv.user_pk ")

        Dim condFlg As Boolean

        If Not String.IsNullOrEmpty(dto.GSSurname) Then
            condFlg = True
        ElseIf Not String.IsNullOrEmpty(dto.GSName) Then
            condFlg = True
        ElseIf Not String.IsNullOrEmpty(dto.GSPhoneNumber) Then
            condFlg = True
        ElseIf Not String.IsNullOrEmpty(dto.GSDiscriminationChar) Then
            condFlg = True
        ElseIf Not String.IsNullOrEmpty(dto.GSDesignatedNumber) Then
            condFlg = True
        End If

        If condFlg Then
            sql.Append("WHERE ")
        End If

        If Not String.IsNullOrEmpty(dto.GSSurname) Then

            sql.Append("(tu.surname LIKE '%" + dto.GSSurname + "%' ")
            sql.Append("OR ")
            sql.Append("tu.phonetic_surname LIKE '%" + dto.GSSurname + "%') ")

        End If

        If Not String.IsNullOrEmpty(dto.GSName) Then

            If Not String.IsNullOrEmpty(dto.GSSurname) Then
                sql.Append("AND ")
            End If

            sql.Append("(tu.name LIKE '%" + dto.GSName + "%' ")
            sql.Append("OR ")
            sql.Append("tu.phonetic_name LIKE '%" + dto.GSName + "%') ")

        End If

        If Not String.IsNullOrEmpty(dto.GSPhoneNumber) Then

            If Not String.IsNullOrEmpty(dto.GSSurname) OrElse Not String.IsNullOrEmpty(dto.GSName) Then
                sql.Append("AND ")
            End If

            sql.Append("tu.phone_number LIKE '%" + dto.GSPhoneNumber + "%' ")

        End If

        If Not String.IsNullOrEmpty(dto.GSDiscriminationChar) Then

            If Not String.IsNullOrEmpty(dto.GSSurname) OrElse Not String.IsNullOrEmpty(dto.GSName) OrElse Not String.IsNullOrEmpty(dto.GSPhoneNumber) Then
                sql.Append("AND ")
            End If

            sql.Append("tv.discrimination_character LIKE '%" + dto.GSDiscriminationChar + "%' ")

        End If

        If Not String.IsNullOrEmpty(dto.GSDesignatedNumber) Then

            If Not String.IsNullOrEmpty(dto.GSSurname) OrElse Not String.IsNullOrEmpty(dto.GSName) OrElse Not String.IsNullOrEmpty(dto.GSPhoneNumber) OrElse Not String.IsNullOrEmpty(dto.GSDiscriminationChar) Then
                sql.Append("AND ")
            End If

            sql.Append("tv.designated_number LIKE '%" + dto.GSDesignatedNumber + "%' ")
        End If

        sql.Append(";")

        Return sql.ToString

    End Function

End Class
