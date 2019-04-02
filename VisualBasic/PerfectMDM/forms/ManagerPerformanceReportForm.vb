Public Class ManagerPerformanceReportForm
    Private Sub RefreshButton_Click(sender As Object, e As EventArgs) Handles RefreshButton.Click
        Dim dateFromValue As DateTime = DateFrom.Value
        Dim dateToValue As DateTime = DateTo.Value

        Dim index As Integer = TabControl1.SelectedIndex
        If (index = 0) Then
            RefreshFastOrdersReport(dateFromValue, dateToValue)
        ElseIf (index = 1)
            RefreshCreatedOrdersReport(dateFromValue, dateToValue)
        Else
            RefreshManagerOrdersReport(dateFromValue, dateToValue)
        End If
    End Sub

    Private Sub RefreshFastOrdersReport(dateFromValue As Date, dateToValue As Date)
        Dim cmd As New SqlClient.SqlCommand
        cmd.Connection = mcnnInt
        cmd.CommandText = "sp_R20009"
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.Add(New SqlClient.SqlParameter("@Data1", SqlDbType.DateTime))
        cmd.Parameters("@Data1").Value = dateFromValue
        cmd.Parameters.Add(New SqlClient.SqlParameter("@Data2", SqlDbType.DateTime))
        cmd.Parameters("@Data2").Value = dateToValue

        Dim sqlDataAdapter As New SqlClient.SqlDataAdapter(cmd)
        Dim dataTable As New DataTable
        sqlDataAdapter.Fill(dataTable)
        
        Me.Result1DataGridView.Columns.Clear()
        Me.Result1DataGridView.DataSource = dataTable
        Me.Result1DataGridView.ClearSelection()
    End Sub

    Private Sub RefreshCreatedOrdersReport(dateFromValue As Date, dateToValue As Date)
        Dim cmd As New SqlClient.SqlCommand
        cmd.Connection = mcnnInt
        cmd.CommandText = "sp_R20012"
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.Add(New SqlClient.SqlParameter("@Data1", SqlDbType.DateTime))
        cmd.Parameters("@Data1").Value = dateFromValue
        cmd.Parameters.Add(New SqlClient.SqlParameter("@Data2", SqlDbType.DateTime))
        cmd.Parameters("@Data2").Value = dateToValue

        Dim sqlDataAdapter As New SqlClient.SqlDataAdapter(cmd)
        Dim dataTable As New DataTable
        sqlDataAdapter.Fill(dataTable)
        
        Me.Result2DataGridView.Columns.Clear()
        Me.Result2DataGridView.DataSource = dataTable
        Me.Result2DataGridView.ClearSelection()
    End Sub

    Private Sub RefreshManagerOrdersReport(dateFromValue As Date, dateToValue As Date)
        Dim cmd As New SqlClient.SqlCommand
        cmd.Connection = mcnnInt
        cmd.CommandText = "sp_R20013"
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.Add(New SqlClient.SqlParameter("@Data1", SqlDbType.DateTime))
        cmd.Parameters("@Data1").Value = dateFromValue
        cmd.Parameters.Add(New SqlClient.SqlParameter("@Data2", SqlDbType.DateTime))
        cmd.Parameters("@Data2").Value = dateToValue

        Dim sqlDataAdapter As New SqlClient.SqlDataAdapter(cmd)
        Dim dataTable As New DataTable
        sqlDataAdapter.Fill(dataTable)
        
        Me.Result3DataGridView.Columns.Clear()
        Me.Result3DataGridView.DataSource = dataTable
        Me.Result3DataGridView.ClearSelection()
    End Sub

    Private Sub OperatorsPerformanceReportForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim newDate As DateTime = Now()
        newDate = newDate.AddDays(-(Now().Day) + 1)
        Me.DateFrom.Value = newDate
    End Sub
End Class