Public Class fzp_EmplPlan

    Dim curMonth As Integer 'текущий месяц
    Dim selYear As Boolean = False
    Dim modeSelect As Integer = 0
    Dim allowOpacity As Boolean = True

    Private Sub fin_EmplPlan_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'Заполнение списка
        Try
            Dim odaWageSystem As New SqlClient.SqlDataAdapter("SELECT * FROM fin_WageSystem", mcnnInt)
            Dim dtWageSystem As New DataTable : odaWageSystem.Fill(dtWageSystem)

            Me.tscmbWageSystem.ComboBox.DataSource = dtWageSystem
            Me.tscmbWageSystem.ComboBox.DisplayMember = "Name"
            Me.tscmbWageSystem.ComboBox.ValueMember = "ID"

            Me.Opacity = 100

            Dim odaYears As New SqlClient.SqlDataAdapter("SELECT DISTINCT [year] FROM fin_Working_Hours", mcnnInt)
            Dim dtYears As New DataTable : odaYears.Fill(dtYears)

            Me.tscmbYear.ComboBox.DataSource = dtYears
            Me.tscmbYear.ComboBox.DisplayMember = "year"
            Me.tscmbYear.ComboBox.ValueMember = "year"
            Me.tscmbYear.ComboBox.SelectedIndex = dtYears.Rows.Count - 1

            selYear = True
        Catch ex As System.Exception
            MessageBox.Show("Ошибка при загрузке систем оплаты труда: fin_WageSystem " & ex.Message, appName)
        End Try
    End Sub

    Private Sub LoadData()
        modeSelect = 0

        If Me.tscmbYear.SelectedIndex = -1 Or Me.tscmbMonth.SelectedIndex = -1 Then
            MsgBox("Не задан отчетный период месяц или год", MsgBoxStyle.Critical, appName)
            Exit Sub
        End If

        Dim cmd As New SqlClient.SqlCommand
        cmd.Connection = mcnnInt
        cmd.CommandText = "[sp_Fin_EmplPlan]"
        cmd.CommandType = CommandType.StoredProcedure

        cmd.Parameters.Add(New SqlClient.SqlParameter("@numMonth", SqlDbType.Int))
        cmd.Parameters("@numMonth").Value = Me.tscmbMonth.SelectedIndex + 1

        cmd.Parameters.Add(New SqlClient.SqlParameter("@year", SqlDbType.Int))
        cmd.Parameters("@year").Value = Me.tscmbYear.SelectedItem(0)

        Dim objDA As New SqlClient.SqlDataAdapter(cmd)
        Dim dtEmplPlan As New DataTable : objDA.Fill(dtEmplPlan)
        '    Me.dgTableData.Columns.Clear()

        Me.dgTableData.DataSource = dtEmplPlan

        ColHideDG(Me.dgTableData)

        'Me.dgTableData.ClearSelection()

        'Try
        '    For n As Integer = 0 To Me.dgTableData.ColumnCount - 1
        '        If Me.dgTableData.Columns(n).Name = "emplID" Then
        '            Me.dgTableData.Columns("emplID").Visible = False
        '        End If

        '        If Me.dgTableData.Columns(n).Name = "Фактическая отрабтка" Then
        '            Me.dgTableData.Columns("Фактическая отрабтка").Visible = False
        '        End If

        '        If Me.dgTableData.Columns(n).Name = "Рабочих единиц" Then
        '            Me.dgTableData.Columns("Рабочих единиц").Visible = False
        '        End If

        '        If Me.dgTableData.Columns(n).Name = "Рабочих дней" Then
        '            Me.dgTableData.Columns("Рабочих дней").Visible = False
        '        End If
        '    Next
        'Catch ex As System.Exception
        '    MessageBox.Show(ex.Message, appName)
        '    Exit Sub
        'End Try
    End Sub

    Private Sub ColHideDG(NameGrid As Object)
        For Each col As Object In NameGrid.Columns
            If col.name = "invoiceKA_ID" Or col.name = "emplID" Or col.name = "Фактическая отрабтка" Or col.name = "Рабочих единиц" Or col.name = "Рабочих дней" Then
                col.visible = False
            End If
        Next

        NameGrid.ClearSelection()
    End Sub

    Private Sub ОтобразитьПоказателиToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ОтобразитьПоказателиToolStripMenuItem.Click
        LoadData()
    End Sub

    Private Sub ВыходToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ВыходToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub CalcToDelivery()
        Try
            Me.dgTableData.Columns.Remove("to_delivery")
            Me.dgTableData.Columns.Remove("btn")
        Catch ex As System.Exception
        End Try

        Me.dgTableData.Columns.Add("to_delivery", "К выдаче")

        Dim nal% = 0
        Dim naKartu% = 0
        Dim itogo As Decimal = 0

        Try
            For n As Integer = 0 To Me.dgTableData.RowCount - 1
                Me.dgTableData("to_delivery", n).Value = Math.Round(Me.dgTableData("Оклад", n).Value / Me.dgTableData("Рабочих единиц", n).Value * _
                (Me.dgTableData("Рабочих единиц", n).Value + Me.dgTableData("Фактическая отработка", n).Value) _
                + (Me.dgTableData("Маржа", n).Value / 100 * Me.dgTableData("Процент менеджера", n).Value) _
                + Me.dgTableData("Премия", n).Value - Me.dgTableData("Штраф", n).Value - Me.dgTableData("Белая", n).Value - Me.dgTableData("Выдано", n).Value, 2)
                '+ (Me.dgTableData("Фактическая выручка", n).Value / 100 * Me.dgTableData("Процент менеджера", n).Value) _
                nal += Me.dgTableData("to_delivery", n).Value
                naKartu += Me.dgTableData("На_карту", n).Value
                itogo += Me.dgTableData("to_delivery", n).Value
            Next

            Me.tsslItogo.Text = "Нал.:" + CStr(nal)
            Me.ToolStripStatusLabel2.Text = "На карту: " + CStr(Format(naKartu, "C"))

            '   Me.dgTableData.DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomRight

            Dim btn As New DataGridViewButtonColumn()

            dgTableData.Columns.Add(btn)
            btn.HeaderText = "Выдача"
            btn.Text = "Выдать"
            btn.Name = "btn"
            btn.UseColumnTextForButtonValue = True

            Me.tsslItogo.Text = "К выдаче " + CStr(Format(itogo, "C"))
        Catch ex As System.Exception
            MessageBox.Show(ex.Message, appName)
            Exit Sub
        End Try
    End Sub

    Private Sub DataGridView1_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgTableData.CellClick
        Dim strMsg$ = Nothing
        Dim strSQL$ = Nothing

        Select Case modeSelect
            Case Is = 0
                If e.ColumnIndex = dgTableData.Columns.Count - 1 Then
                    If Me.dgTableData.Rows(e.RowIndex).DefaultCellStyle.BackColor = Color.LightGreen Or Me.dgTableData("to_delivery", Me.dgTableData.CurrentRow.Index).Value() = 0 Then
                        MsgBox("Выплата невозможна", MsgBoxStyle.Information, appName)
                        Exit Sub
                    End If
                    strMsg = "Выплатить - " + Me.dgTableData("to_delivery", Me.dgTableData.CurrentRow.Index).Value().ToString + " рублей" + "?"

                    If MessageBox.Show(strMsg, appName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                        strSQL = "INSERT INTO PaymentsEmpl (emplID, month, year, amount, signFopl, office_ID, description) "
                        strSQL &= "VALUES (" & Me.dgTableData(0, e.RowIndex).Value & "," & Me.tscmbMonth.SelectedIndex + 1 & "," & Me.tscmbYear.SelectedItem(0) & ", "
                        strSQL &= "" & Replace(Me.dgTableData("to_delivery", e.RowIndex).Value(), ",", ".") & ",1,1,'fzp')"

                        Module1.NonQuery1(strSQL)

                        Me.dgTableData.Rows(e.RowIndex).DefaultCellStyle.BackColor = Color.LightGreen
                    End If
                End If
            Case Is = 2
            Case Else
        End Select
    End Sub

#Region " Экспорт в Excel "
    Private Sub ExportExcel()
        If Me.dgTableData.RowCount = 0 Then
            Exit Sub
        End If
        Dim oExcel As Object
        Dim oBook As Object
        Dim iRow As Integer
        Dim iCol As Integer
        Dim ch As Char
        'Dim tmpDataSet As DataTable

        'Dim tmpDoc As frmDoc = Me.ActiveMdiChild
        '   tmpDataSet = CType(Me.dgTableData.DataSource, DataTable)
        '    tmpDataSet = CType(Me.dgTableData., DataTable)

        oExcel = CreateObject("Excel.Application")
        oExcel.Visible = True
        oBook = oExcel.Workbooks.Add
        With oBook.ActiveSheet
            .Range("A2:H2").Font.Size = 12
            .Range("A2:H2").Font.Bold = True
            '   .Range("B2").Value = forExcelcaption

            For iCol = 0 To Me.dgTableData.Columns.Count - 1
                ch = Chr(65 + iCol)
                .Range(ch & 3).Value = Me.dgTableData.Columns(iCol).HeaderText.ToString

                For iRow = 0 To Me.dgTableData.Rows.Count - 1
                    ch = Chr(65 + iCol)
                    .Range(ch & iRow + 4).Value = IIf(IsDBNull(dgTableData(iCol, iRow).Value), "", dgTableData(iCol, iRow).Value)
                Next iRow
                .columns(iCol + 1).EntireColumn.AutoFit()
            Next iCol
        End With
        'oBook.SaveAs(oExcel.StartupPath & "\" & "uuu" & ".xls")
    End Sub
#End Region

    Private Sub ЭкспортВEXCELToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ЭкспортВEXCELToolStripMenuItem.Click
        ExportExcel()
    End Sub

    Private Sub СохранитьToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles СохранитьToolStripMenuItem.Click
        Dim strMsg$ = "Сохранить изменения? " '& Me.cmbEmpl.Text & " выплату на сумму " & Me.nudActualRevenue.Value.ToString & " руб.?"
        Dim curMonthWorkingHours% = Module1.NonQuery1Scalar("SELECT workingHours FROM fin_Working_hours WHERE year=" & Me.tscmbYear.SelectedItem(0) & " AND month=" & Me.tscmbMonth.SelectedIndex + 1 & " ")

        If MessageBox.Show(strMsg, appName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Dim strSQL$ = Nothing

            For n As Integer = 0 To Me.dgTableData.RowCount - 1

                Select Case modeSelect
                    Case Is = 0
                        Exit Sub
                    Case Is = 1 'сохраняем плановую рализацию
                        If Module1.NonQuery1Scalar("SELECT COUNT(*) FROM fin_EmplPlanFact WHERE [emplID]=" & Me.dgTableData(0, n).Value & " AND month=" & Me.tscmbMonth.SelectedIndex + 1 & " AND year =" & Me.tscmbYear.SelectedItem(0) & "") = 0 Then
                            strSQL = "INSERT INTO fin_EmplPlanFact (emplID, month, year, PlanRevenue) "
                            strSQL &= "VALUES (" & Me.dgTableData(0, n).Value & ", " & Me.tscmbMonth.SelectedIndex + 1 & ",  " & Me.tscmbYear.SelectedItem(0) & ", "
                            strSQL &= "" & Replace(Me.dgTableData(2, n).Value, ",", ".") & " ) "
                        Else
                            strSQL = "UPDATE fin_EmplPlanFact SET "
                            strSQL &= "[PlanRevenue] = " & Replace(Me.dgTableData(2, n).Value, ",", ".") & " "
                            strSQL &= "WHERE  emplID = " & Me.dgTableData(0, n).Value & " AND month=" & Me.tscmbMonth.SelectedIndex + 1 & " AND year=" & Me.tscmbYear.SelectedItem(0) & " "
                        End If

                        Module1.NonQuery1(strSQL)

                    Case Is = 2 'сохраняем фактическую отработку
                        If Module1.NonQuery1Scalar("SELECT COUNT(*) FROM fin_EmplPlanFact WHERE [emplID]=" & Me.dgTableData(0, n).Value & " AND month=" & Me.tscmbMonth.SelectedIndex + 1 & " AND year =" & Me.tscmbYear.SelectedItem(0) & "") = 0 Then
                            strSQL = "INSERT INTO fin_EmplPlanFact (emplID, month, year, FulfilledHours) "
                            strSQL &= "VALUES ( " & Me.dgTableData(0, n).Value & ", " & Me.tscmbMonth.SelectedIndex + 1 & ",  " & Me.tscmbYear.SelectedItem(0) & ", "
                            strSQL &= " " & Replace(Me.dgTableData(2, n).Value, ",", ".") & " )"
                        Else
                            strSQL = "UPDATE fin_EmplPlanFact SET"
                            strSQL &= " [FulfilledHours] =" & Replace(Me.dgTableData(2, n).Value, ",", ".") & " "
                            strSQL &= " WHERE emplID = " & Me.dgTableData(0, n).Value & " AND month = " & Me.tscmbMonth.SelectedIndex + 1 & " AND year =" & Me.tscmbYear.SelectedItem(0) & " "
                        End If
                End Select

                Module1.NonQuery1(strSQL)
            Next

        Else
            MsgBox("Запись не произведена.", MsgBoxStyle.Critical, appName)
        End If
    End Sub

    Private Sub ФактическаяОтработкаToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ФактическаяОтработкаToolStripMenuItem.Click
        If Me.tscmbYear.SelectedIndex = -1 Then
            MsgBox("Не задан год", MsgBoxStyle.Critical, appName) : Exit Sub
        End If

        If Me.tscmbMonth.SelectedIndex = -1 Then
            MsgBox("Не задан месяц", MsgBoxStyle.Critical, appName) : Exit Sub
        End If

        modeSelect = 2

        Dim cmd As New SqlClient.SqlCommand
        cmd.Connection = mcnnInt
        cmd.CommandText = "[sp_Fin_EmplPlanSet]"
        cmd.CommandType = CommandType.StoredProcedure

        cmd.Parameters.Add(New SqlClient.SqlParameter("@numMonth", SqlDbType.Int))
        cmd.Parameters("@numMonth").Value = Me.tscmbMonth.SelectedIndex + 1

        cmd.Parameters.Add(New SqlClient.SqlParameter("@year", SqlDbType.Int))
        cmd.Parameters("@year").Value = Me.tscmbYear.SelectedItem(0)

        Dim objDA As New SqlClient.SqlDataAdapter(cmd)
        Dim dtEmplPlan As New DataTable : objDA.Fill(dtEmplPlan)

        Me.dgTableData.Columns.Clear()
        Me.dgTableData.DataSource = dtEmplPlan
        Me.dgTableData.Columns("emplID").Visible = False
        Me.dgTableData.ClearSelection()
        Me.Text = sender.text
    End Sub

    Private Sub ПлановыеПоказателиToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ПлановыеПоказателиToolStripMenuItem.Click
        If Me.tscmbYear.SelectedIndex = -1 Then
            MsgBox("Не задан год", MsgBoxStyle.Critical, appName) : Exit Sub
        End If

        If Me.tscmbMonth.SelectedIndex = -1 Then
            MsgBox("Не задан месяц", MsgBoxStyle.Critical, appName) : Exit Sub
        End If

        modeSelect = 1

        Dim cmd As New SqlClient.SqlCommand
        cmd.Connection = mcnnInt
        cmd.CommandText = "[sp_Fin_EmplPlanSet]"
        cmd.CommandType = CommandType.StoredProcedure

        cmd.Parameters.Add(New SqlClient.SqlParameter("@numMonth", SqlDbType.Int))
        cmd.Parameters("@numMonth").Value = Me.tscmbMonth.SelectedIndex + 1
        cmd.Parameters.Add(New SqlClient.SqlParameter("@year", SqlDbType.Int))
        cmd.Parameters("@year").Value = Me.tscmbYear.SelectedItem(0)

        Dim objDA As New SqlClient.SqlDataAdapter(cmd)
        Dim dtEmplPlan As New DataTable : objDA.Fill(dtEmplPlan)

        Me.dgTableData.Columns.Clear()
        Me.dgTableData.DataSource = dtEmplPlan

        ' Me.dgTableData.Columns.Add("PlanRevenue", "Плановая выручка")

        Me.dgTableData.ClearSelection()
        Me.Text = sender.text
    End Sub

    Private Sub РасчетToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles РасчетToolStripMenuItem.Click
        Select Case Me.tscmbWageSystem.SelectedItem(0)
            Case Is = 1
                CalcToDelivery()
            Case Else
                MsgBox("Надо уточнить логику", MsgBoxStyle.Information, appName)
        End Select
    End Sub

    Private Sub dgTableData_ColumnHeaderMouseClick(sender As Object, e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles dgTableData.ColumnHeaderMouseClick
        CalcToDelivery()
    End Sub

End Class