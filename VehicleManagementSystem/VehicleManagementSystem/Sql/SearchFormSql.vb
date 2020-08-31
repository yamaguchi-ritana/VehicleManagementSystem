Public Class SearchFormSql

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

        If Not String.IsNullOrEmpty(dto.GsSurname) Then
            condFlg = True
        ElseIf Not String.IsNullOrEmpty(dto.GsName) Then
            condFlg = True
        ElseIf Not String.IsNullOrEmpty(dto.GsPhoneNumber) Then
            condFlg = True
        ElseIf Not String.IsNullOrEmpty(dto.GsDiscriminationChar) Then
            condFlg = True
        ElseIf Not String.IsNullOrEmpty(dto.GsDesignatedNumber) Then
            condFlg = True
        End If

        If condFlg Then
            sql.Append("WHERE ")
        End If

        If Not String.IsNullOrEmpty(dto.GsSurname) Then

            sql.Append("(tu.surname LIKE '%" + dto.GsSurname + "%' ")
            sql.Append("OR ")
            sql.Append("tu.phonetic_surname LIKE '%" + dto.GsSurname + "%') ")

        End If

        If Not String.IsNullOrEmpty(dto.GsName) Then

            If Not String.IsNullOrEmpty(dto.GsSurname) Then
                sql.Append("AND ")
            End If

            sql.Append("(tu.name LIKE '%" + dto.GsName + "%' ")
            sql.Append("OR ")
            sql.Append("tu.phonetic_name LIKE '%" + dto.GsName + "%') ")

        End If

        If Not String.IsNullOrEmpty(dto.GsPhoneNumber) Then

            If Not String.IsNullOrEmpty(dto.GsSurname) OrElse Not String.IsNullOrEmpty(dto.GsName) Then
                sql.Append("AND ")
            End If

            sql.Append("tu.phone_number LIKE '%" + dto.GsPhoneNumber + "%' ")

        End If

        If Not String.IsNullOrEmpty(dto.GsDiscriminationChar) Then

            If Not String.IsNullOrEmpty(dto.GsSurname) OrElse Not String.IsNullOrEmpty(dto.GsName) OrElse Not String.IsNullOrEmpty(dto.GsPhoneNumber) Then
                sql.Append("AND ")
            End If

            sql.Append("tv.discrimination_character LIKE '%" + dto.GsDiscriminationChar + "%' ")

        End If

        If Not String.IsNullOrEmpty(dto.GsDesignatedNumber) Then

            If Not String.IsNullOrEmpty(dto.GsSurname) OrElse Not String.IsNullOrEmpty(dto.GsName) OrElse Not String.IsNullOrEmpty(dto.GsPhoneNumber) OrElse Not String.IsNullOrEmpty(dto.GsDiscriminationChar) Then
                sql.Append("AND ")
            End If

            sql.Append("tv.designated_number LIKE '%" + dto.GsDesignatedNumber + "%' ")
        End If

        sql.Append(";")

        Return sql.ToString

    End Function

End Class
