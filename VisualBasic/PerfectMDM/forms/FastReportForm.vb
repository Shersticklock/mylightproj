Public Class FastReportForm

    Private Sub FastReportForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RefreshData()
    End Sub

    Private Sub RefreshButton_Click(sender As Object, e As EventArgs) Handles RefreshButton.Click
        RefreshData()
    End Sub

    Private Sub RefreshData()
        Dim datetimeFrom As DateTime
        dateTimeFrom = DateFrom.Value.Date
        datetimeFrom = dateTimeFrom.Add(TimeFrom.Value.TimeOfDay)

        Dim datetimeTo As DateTime
        datetimeTo = DateTo.Value.Date
        datetimeTo = dateTimeTo.Add(TimeTo.Value.TimeOfDay)

        LoadCassaData(datetimeFrom, datetimeTo)
        LoadOfficeData(datetimeFrom, datetimeTo)

        CassaDataGrid.ClearSelection()
        OfficeDataGrid.ClearSelection()
    End Sub

    Private Sub LoadCassaData(datetimeFrom As DateTime, datetimeTo As DateTime)
        Dim cassaCommand As New SqlClient.SqlCommand
        cassaCommand.Connection = mcnnInt
        cassaCommand.CommandText = "sp_R20001"
        cassaCommand.CommandType = CommandType.StoredProcedure
        cassaCommand.Parameters.Add(New SqlClient.SqlParameter("@Data1", SqlDbType.DateTime))
        cassaCommand.Parameters("@Data1").Value = dateTimeFrom
        cassaCommand.Parameters.Add(New SqlClient.SqlParameter("@Data2", SqlDbType.DateTime))
        cassaCommand.Parameters("@Data2").Value = dateTimeTo
        Dim cassaSqlDataAdapter As New SqlClient.SqlDataAdapter(cassaCommand)
        Dim cassaDataTable As New DataTable
        cassaSqlDataAdapter.Fill(cassaDataTable)
        CassaDataGrid.DataSource = cassaDataTable
    End Sub

    Private Sub LoadOfficeData(datetimeFrom As DateTime, datetimeTo As DateTime)
        Dim officeCommand As New SqlClient.SqlCommand
        officeCommand.Connection = mcnnInt
        officeCommand.CommandText = "sp_R20006"
        officeCommand.CommandType = CommandType.StoredProcedure
        officeCommand.Parameters.Add(New SqlClient.SqlParameter("@Data1", SqlDbType.DateTime))
        officeCommand.Parameters("@Data1").Value = dateTimeFrom
        officeCommand.Parameters.Add(New SqlClient.SqlParameter("@Data2", SqlDbType.DateTime))
        officeCommand.Parameters("@Data2").Value = dateTimeTo
        Dim officeSqlDataAdapter As New SqlClient.SqlDataAdapter(officeCommand)
        Dim officeDataTable As New DataTable
        officeSqlDataAdapter.Fill(officeDataTable)
        OfficeDataGrid.DataSource = officeDataTable
    End Sub

End Class