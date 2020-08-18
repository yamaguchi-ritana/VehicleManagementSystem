Public Class VehicleInfoSql
    Function VehicleInfo(vehiclePk As Integer) As String

        Dim sql As New System.Text.StringBuilder()

        sql.Append("SELECT ")
        sql.Append("tv.home, ")
        sql.Append("tv.class_number, ")
        sql.Append("tv.discrimination_character, ")
        sql.Append("tv.designated_number, ")
        sql.Append("tv.manufacturer, ")
        sql.Append("tv.car_name, ")
        sql.Append("tv.chassis_number, ")
        sql.Append("tv.model, ")
        sql.Append("tv.prime_mover_model, ")
        sql.Append("tv.model_designation_number, ")
        sql.Append("tv.category_number, ")
        sql.Append("tv.mileage, ")
        sql.Append("tv.first_date, ")
        sql.Append("tv.last_inspection_date, ")
        sql.Append("tv.next_inspection_date, ")
        sql.Append("tv.other, ")
        sql.Append("tu.surname, ")
        sql.Append("tu.name, ")
        sql.Append("tu.phonetic_surname, ")
        sql.Append("tu.phonetic_name, ")
        sql.Append("tu.phone_number, ")
        sql.Append("tu.mail_address, ")
        sql.Append("tu.postal_code, ")
        sql.Append("tu.street_address ")
        ' sql.Append(" tv.remark ")
        sql.Append("FROM ")
        sql.Append("t_user tu ")
        sql.Append("INNER JOIN ")
        sql.Append("t_vehicle tv ")
        sql.Append("ON tu.user_pk = tv.user_pk ")
        sql.Append("WHERE ")
        sql.Append("tv.vehicle_pk = '" + vehiclePk.ToString + "' ")
        sql.Append(";")

        Return sql.ToString

    End Function
End Class
