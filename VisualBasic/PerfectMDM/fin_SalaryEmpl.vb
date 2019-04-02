Public Class fin_SalaryEmpl

    Dim selYear As Boolean = False

    Private Sub fin_SalaryEmpl_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Dim odaYears As New SqlClient.SqlDataAdapter("SELECT DISTINCT [year]  FROM fin_Working_Hours ", mcnnInt)
        Dim dtYears As New DataTable : odaYears.Fill(dtYears)

        Me.tscmbYear.ComboBox.DataSource = dtYears
        Me.tscmbYear.ComboBox.DisplayMember = "year"
        Me.tscmbYear.ComboBox.ValueMember = "year"
        Me.tscmbYear.ComboBox.SelectedIndex = -1
        selYear = True

        Dim odaEmp As New SqlClient.SqlDataAdapter("SELECT emplID, emplLastName  FROM Employees WHERE dismissed <> 1 order by emplLastName", mcnnInt)
        Dim dtEmp As New DataTable : odaEmp.Fill(dtEmp)

        Me.tscmbEmpl.ComboBox.DataSource = dtEmp
        Me.tscmbEmpl.ComboBox.DisplayMember = "emplLastName"
        Me.tscmbEmpl.ComboBox.ValueMember = "emplID"
        Me.tscmbEmpl.ComboBox.SelectedIndex = -1  
    End Sub

    Private Sub ВсеСотрудникиToolStripMenuItem1_Click(sender As System.Object, e As System.EventArgs) Handles ВсеСотрудникиToolStripMenuItem1.Click
        Me.tscmbEmpl.ComboBox.SelectedIndex = -1

        If Me.tscmbYear.SelectedIndex = -1 Or Me.tscmbYear.SelectedIndex = -1 Then
            MsgBox("Не задан отчетный период месяц или год.", MsgBoxStyle.Critical, appName) : Exit Sub
        End If

        If Me.tscmbMonth.SelectedIndex = -1 Or Me.tscmbMonth.SelectedIndex = -1 Then
            MsgBox("Не задан месяц.", MsgBoxStyle.Critical, appName) : Exit Sub
        End If


        Dim cmd As New SqlClient.SqlCommand

        cmd.Connection = mcnnInt
        cmd.CommandText = "[sp_Fin_SalaryEmplAll]"
        cmd.CommandType = CommandType.StoredProcedure

        cmd.Parameters.Add(New SqlClient.SqlParameter("@numMonth", SqlDbType.Int))
        cmd.Parameters("@numMonth").Value = Me.tscmbMonth.SelectedIndex + 1

        cmd.Parameters.Add(New SqlClient.SqlParameter("@year", SqlDbType.Int))
        cmd.Parameters("@year").Value = Me.tscmbYear.SelectedItem(0)

        Dim objDA As New SqlClient.SqlDataAdapter(cmd)
        Dim dtEmplPlan As New DataTable : objDA.Fill(dtEmplPlan)

        Me.dgTableData.Columns.Clear()

        dtEmplPlan.Rows.Add()

        For Each col As DataColumn In dtEmplPlan.Columns
            Try
                '     MsgBox(col.ColumnName, MsgBoxStyle.Information, appName)
                dtEmplPlan.Rows(dtEmplPlan.Rows.Count - 1)(col.ColumnName) = dtEmplPlan.Compute("SUM(" & col.ColumnName & ")", "")
                '  dtEmplPlan.Rows(dtEmplPlan.Rows.Count - 1)(col.ColumnName) = "Итого за "
            Catch ex As System.Exception
                ' MsgBox(ex.Message, MsgBoxStyle.Critical, appName)
            End Try
        Next

        Me.dgTableData.DataSource = dtEmplPlan
        Me.dgTableData.ClearSelection()

        Try
            For n As Integer = 0 To Me.dgTableData.ColumnCount - 1
                If Me.dgTableData.Columns(n).Name = "emplID" Then
                    Me.dgTableData.Columns("emplID").Visible = False
                End If
            Next
        Catch ex As System.Exception
            MessageBox.Show(ex.Message, appName)
            Exit Sub
        End Try
    End Sub

    Private Sub ОбновитьToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ОбновитьToolStripMenuItem.Click
        If Me.tscmbEmpl.ComboBox.SelectedIndex = -1 Then
            MsgBox("Не задан сотрудник.", MsgBoxStyle.Critical, appName) : Me.tscmbEmpl.ComboBox.Focus() : Exit Sub
        End If

        If Me.tscmbYear.ComboBox.SelectedIndex = -1 Then
            MsgBox("Не задан отчетный период месяц или год.", MsgBoxStyle.Critical, appName) : Me.tscmbYear.ComboBox.Focus() : Exit Sub
        End If

        If Me.tscmbMonth.ComboBox.SelectedIndex = -1 Then
            MsgBox("Не задан месяц.", MsgBoxStyle.Critical, appName) : Me.tscmbMonth.ComboBox.Focus() : Exit Sub
        End If

        Dim cmd As New SqlClient.SqlCommand

        cmd.Connection = mcnnInt
        cmd.CommandText = "[sp_Fin_SalaryEmpl]"
        cmd.CommandType = CommandType.StoredProcedure

        cmd.Parameters.Add(New SqlClient.SqlParameter("@numMonth", SqlDbType.Int))
        cmd.Parameters("@numMonth").Value = Me.tscmbMonth.SelectedIndex + 1

        cmd.Parameters.Add(New SqlClient.SqlParameter("@year", SqlDbType.Int))
        cmd.Parameters("@year").Value = Me.tscmbYear.SelectedItem(0)

        cmd.Parameters.Add(New SqlClient.SqlParameter("@emplID", SqlDbType.Int))
        cmd.Parameters("@emplID").Value = Me.tscmbEmpl.SelectedItem(0)

        Dim objDA As New SqlClient.SqlDataAdapter(cmd)
        Dim dtEmplPlan As New DataTable : objDA.Fill(dtEmplPlan)

        Me.dgTableData.Columns.Clear()

        dtEmplPlan.Rows.Add()


        For Each col As DataColumn In dtEmplPlan.Columns
            Try
                dtEmplPlan.Rows(dtEmplPlan.Rows.Count - 1)(col.ColumnName) = dtEmplPlan.Compute("SUM(" & col.ColumnName & ")", "")
            Catch ex As System.Exception
            End Try
        Next

        Me.dgTableData.DataSource = dtEmplPlan
        Me.dgTableData.ClearSelection()
        Me.dgTableData.Columns("emplID").Visible = False

    End Sub

    Private Sub tscmbEmpl_Click(sender As Object, e As EventArgs) Handles tscmbEmpl.Click

    End Sub
End Class