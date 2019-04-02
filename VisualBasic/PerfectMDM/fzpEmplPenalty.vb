Public Class fzpEmplPenalty
    Dim curMonth As Integer = Module1.NonQuery1Scalar("Select Month(getdate())") - 1 'текущий месяц

    Private Sub frmEmplPenalty_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        If modeEmplPayPen = False Then ' режим штрафов и премий
            Me.cmbMonth.SelectedIndex = -1 'curMonth для АВЦ
            Me.btnApply.Text = "Записать штраф и премию"
            Me.lbldescriptionA.Visible = True
            Me.txtdescriptionA.Visible = True
            Me.btnToCarryOnExpenses.Visible = False
        Else
            Me.lbldescriptionA.Visible = False
            Me.txtdescriptionA.Visible = False
            Me.btnApply.Text = ""
            Me.btnToCarryOnExpenses.Visible = True
            'Режим ФЗП К выдаче
            Dim oCurr As Object
            'обработать в цикле каждый элемент в таблице
            For Each oCurr In Me.TableLayoutPanel1.Controls
                If TypeOf oCurr Is ComboBox Or TypeOf oCurr Is DataGridView Or TypeOf oCurr Is Button Then
                Else
                    oCurr.visible = False
                End If
            Next
            Me.btnApply.Text = "Провести выплату"
        End If
    End Sub

    Private Sub btnApply_Click(sender As System.Object, e As System.EventArgs) Handles btnApply.Click
        If Me.cmbMonth.SelectedIndex = -1 Then
            MsgBox("Не период (месяц) начисления", MsgBoxStyle.Critical, appName)
            Me.cmbMonth.Focus()
            Exit Sub
        Else
            If modeEmplPayPen = False Then ' режим штрафов и премий
                Dim strMsg$ = "Оформить на сотрудника " & Me.dgAwards("Сотрудник", Me.dgAwards.CurrentRow.Index).Value() & " штрафов на сумму " & Me.nudPenalty.Value.ToString & " руб. и премии на сумму " & Me.nudAward.Value.ToString & " руб. ?"
                Dim strSQL As String

                If MessageBox.Show(strMsg, appName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                    If Module1.NonQuery1Scalar("SELECT COUNT(*) FROM EmplAwards WHERE emplID = " & Me.dgAwards("emplID", Me.dgAwards.CurrentRow.Index).Value() & " AND month = " & Me.cmbMonth.SelectedIndex + 1 & " AND year = year(getdate()) ") <> 0 Then
                        'обновить
                        strSQL = "UPDATE EmplAwards SET awardsAmount = awardsAmount + " & Me.nudAward.Value & ", "
                        strSQL &= " descriptionA = descriptionA + '" & ", " & CStr(Me.nudAward.Value) + "-" + Me.txtdescriptionA.Text & "', "
                        strSQL &= " penaltyAmount = penaltyAmount + " & Me.nudPenalty.Value & ", descriptionP = descriptionP + '" & ", " & CStr(Me.nudPenalty.Value) + "-" + Me.txtDescription.Text & "'"
                        strSQL &= " WHERE emplID = " & Me.dgAwards("emplID", Me.dgAwards.CurrentRow.Index).Value() & " AND month = " & Me.cmbMonth.SelectedIndex + 1 & " AND year = year(getdate()) "
                    Else
                        'вставить
                        strSQL = "INSERT INTO EmplAwards (emplID, month, year, awardsAmount, descriptionA, penaltyAmount, descriptionP) "
                        strSQL &= "VALUES ( " & Me.dgAwards("emplID", Me.dgAwards.CurrentRow.Index).Value() & ", " & Me.cmbMonth.SelectedIndex + 1 & ",  year(getdate()), "
                        strSQL &= " " & Me.nudAward.Value & ", '" & CStr(Me.nudAward.Value) + "-" + Me.txtdescriptionA.Text & "', " & Me.nudPenalty.Value & ", '" & CStr(Me.nudPenalty.Value) + "-" + Me.txtDescription.Text & "' )"
                        '  Me.txtDescription.Text = strSQL
                    End If
                    Module1.NonQuery1(strSQL)
                    'Module1.NonQuery1("DELETE FROM EmplAwards WHERE emplID = " & Me.dgAwards("emplID", Me.dgAwards.CurrentRow.Index).Value() & " AND month = month(getdate()) AND year = year(getdate()) ")
                    Me.cmbMonth.SelectedIndex = -1

                    LoadAwards()

                    Me.txtDescription.Text = Nothing
                    Me.txtdescriptionA.Text = Nothing
                    Me.nudAward.Value = 0
                    Me.nudPenalty.Value = 0
                Else
                    MsgBox("Запись не произведена.", MsgBoxStyle.Critical, appName)
                End If
            Else
                If Me.dgAwards.SelectedRows.Count = 0 Then
                    MsgBox("Не выбран сотрудник.", MsgBoxStyle.Critical, appName) : Exit Sub
                End If

                Dim strMsg$ = "Выплатить сотруднику " & Me.dgAwards("Сотрудник", Me.dgAwards.CurrentRow.Index).Value() & " вознаграждение в размере- " & Me.dgAwards("К_выдаче", Me.dgAwards.CurrentRow.Index).Value() & " руб.?"
                Dim strSQL As String

                If MessageBox.Show(strMsg, appName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then

                    'Module1.NonQuery1("DELETE FROM EmplAwards  WHERE emplID = " & Me.dgAwards("emplID", Me.dgAwards.CurrentRow.Index).Value() & " AND month = month(getdate()) AND year = year(getdate()) ")

                    strSQL = "INSERT INTO PaymentsEmpl (emplID, month, year, amount) "
                    strSQL &= "VALUES ( " & Me.dgAwards("emplID", Me.dgAwards.CurrentRow.Index).Value() & ", " & Me.cmbMonth.SelectedIndex + 1 & ",  year(getdate()), "
                    strSQL &= " " & Me.dgAwards("К_выдаче", Me.dgAwards.CurrentRow.Index).Value() & " )"
                    '  Me.txtDescription.Text = strSQL
                    Module1.NonQuery1(strSQL)
                Else
                    MsgBox("Запись не произведена.", MsgBoxStyle.Critical, appName)
                End If
            End If

            UpdateData()
        End If
    End Sub

    Private Sub LoadAwards()
        Try 'создаем таблицу
            Dim str1SQL As String = " SELECT Employees.emplID, Employees.emplLastName AS Сотрудник,  ttt.Awards  AS Премия, coalesce(ttt.descriptionA, 'net') as Примечание, coalesce(ttt.Penalty, 0)  AS Штраф, coalesce(ttt.descriptionP, 'net2') as Примечание "
            str1SQL &= " FROM Employees LEFT JOIN (SELECT emplID, coalesce(EmplAwards.awardsAmount, 0) as Awards, descriptionA, coalesce(EmplAwards.penaltyAmount, 0) as Penalty, descriptionP "
            str1SQL &= " FROM EmplAwards WHERE EmplAwards.year = year(getdate()) AND month =  " & Me.cmbMonth.SelectedIndex + 1 & ") ttt "
            str1SQL &= " ON Employees.emplID = ttt.emplID WHERE dismissed <> 1 AND salary > 0 "

            If postPrioritet = 1 Then
                str1SQL &= " order by Employees.emplLastName "
            Else
                str1SQL &= " AND Employees.curatorID = " & emplID & " "
            End If

            Dim odaAwards As New SqlClient.SqlDataAdapter(str1SQL, mcnnInt)
            Dim dtAwards As New DataTable : odaAwards.Fill(dtAwards)

            Me.dgAwards.DataSource = dtAwards
            Me.dgAwards.Columns("emplID").Visible = False
            Me.dgAwards.ClearSelection()
        Catch excp As System.Exception
            MessageBox.Show(excp.Message, appName)
        End Try
    End Sub

    Private Sub LoadFZP()

        Dim cmd As New SqlClient.SqlCommand

        cmd.Connection = mcnnInt
        cmd.CommandText = "[sp_Fin_VseExpPersonal]"
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.Add(New SqlClient.SqlParameter("@numMonth", SqlDbType.Int))
        cmd.Parameters("@numMonth").Value = Me.cmbMonth.SelectedIndex + 1

        Dim objDA As New SqlClient.SqlDataAdapter(cmd)
        Dim dtAwards As New DataTable : objDA.Fill(dtAwards)

        Me.dgAwards.DataSource = dtAwards
        Me.dgAwards.ClearSelection()


        Try 'создаем таблицу
            dtAwards.Rows.Add()
            dtAwards.Rows(dtAwards.Rows.Count - 1)("Оклад") = dtAwards.Compute("SUM(Оклад)", "")
            dtAwards.Rows(dtAwards.Rows.Count - 1)("На_карту") = dtAwards.Compute("SUM(На_карту)", "")
            dtAwards.Rows(dtAwards.Rows.Count - 1)("Выдано") = dtAwards.Compute("SUM(Выдано)", "")
            dtAwards.Rows(dtAwards.Rows.Count - 1)("Премия") = dtAwards.Compute("SUM(Премия)", "")
            dtAwards.Rows(dtAwards.Rows.Count - 1)("Штраф") = dtAwards.Compute("SUM(Штраф)", "")
            ' dtAwards.Rows(dtAwards.Rows.Count - 1)("К_выдаче") = dtAwards.Compute("SUM(К_выдаче)", ""), "C")
            'Сумма с налогами
            dtAwards.Rows.Add()
            dtAwards.Rows(dtAwards.Rows.Count - 1)("Сотрудник") = "Итого с налогами"
            dtAwards.Rows(dtAwards.Rows.Count - 1)("Оклад") = dtAwards.Rows(dtAwards.Rows.Count - 2)("На_карту") * 1.5 + (dtAwards.Rows(dtAwards.Rows.Count - 2)("Оклад") - dtAwards.Rows(dtAwards.Rows.Count - 2)("На_карту"))

            Me.dgAwards.DataSource = dtAwards
            Me.dgAwards.Columns("emplID").Visible = False
            Me.dgAwards.ClearSelection()
        Catch excp As System.Exception
            MessageBox.Show(excp.Message, appName)
        End Try
    End Sub

    Private Sub cmbMonth_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cmbMonth.SelectedIndexChanged
        If modeEmplPayPen = False Then ' режим штрафов и премий
            If Me.cmbMonth.SelectedIndex > curMonth Then
                MsgBox("Можно установить только текущий месяц или прошедший", MsgBoxStyle.Critical, appName)
                Me.cmbMonth.SelectedIndex = curMonth
            End If

            LoadAwards()
        Else
            LoadFZP()
        End If
    End Sub

    Private Sub UpdateData()
        If modeEmplPayPen = False Then ' режим штрафов и премий
            LoadAwards()
        Else
            If Me.cmbMonth.SelectedIndex = -1 Then
                MsgBox("Не выбран отчетный период", MsgBoxStyle.Critical, appName)
                Exit Sub
            Else
                If postPrioritet = 1 Then
                    LoadFZP()
                End If
            End If
        End If
    End Sub

    Private Sub btnUpdate_Click(sender As System.Object, e As System.EventArgs) Handles btnUpdate.Click
        UpdateData()
    End Sub

#Region " Экспорт в Excel "
    Private Sub btnToExcel_Click(sender As System.Object, e As System.EventArgs) Handles btnToExcel.Click
        Dim oExcel As Object
        Dim oBook As Object
        Dim iRow As Integer
        Dim iCol As Integer
        Dim ch As Char
        Dim tmpDataSet As DataTable = CType(Me.dgAwards.DataSource, DataTable)

        oExcel = CreateObject("Excel.Application")
        oExcel.Visible = True
        oBook = oExcel.Workbooks.Add
        With oBook.ActiveSheet
            .Range("A2:H2").Font.Size = 12
            .Range("A2:H2").Font.Bold = True
            ' .Range("B2").Value = "Отчет " & ToolStripComboBox1.Text

            For iCol = 0 To dgAwards.Columns.Count - 1
                ch = Chr(65 + iCol)
                .Range(ch & 3).Value = Me.dgAwards.Columns(iCol).HeaderText.ToString

                For iRow = 0 To tmpDataSet.Rows.Count - 1
                    ch = Chr(65 + iCol)
                    .Range(ch & iRow + 4).Value = IIf(IsDBNull(Me.dgAwards(iCol, iRow).Value), "", Me.dgAwards(iCol, iRow).Value)
                Next iRow
            Next iCol
        End With
        'oBook.SaveAs(oExcel.StartupPath & "\" & "uuu" & ".xls")
    End Sub
#End Region

    Private Sub LoadDetails(ID As Integer)
        Try 'создаем таблицу
            Dim str1SQL$ = "SELECT createTime AS Дата, amount AS Сумма, description AS Основание FROM PaymentsEmpl WHERE year = year(getdate()) AND month =  " & Me.cmbMonth.SelectedIndex + 1 & " AND emplID = " & ID & " "
            Dim odaAwards As New SqlClient.SqlDataAdapter(str1SQL, mcnnInt)
            Dim dtAwards As New DataTable : odaAwards.Fill(dtAwards)

            If dtAwards.Rows.Count > 0 Then
                dtAwards.Rows.Add()
                dtAwards.Rows(dtAwards.Rows.Count - 1)("Сумма") = dtAwards.Compute("SUM(Сумма)", "")
            End If

            Me.dgDetails.DataSource = dtAwards
            Me.dgDetails.ClearSelection()
        Catch excp As System.Exception
            MessageBox.Show(excp.Message, appName)
        End Try
    End Sub

    Private Sub btnHide_Click(sender As System.Object, e As System.EventArgs) Handles btnHide.Click
        Me.dgDetails.Visible = False
        Me.btnHide.Visible = False
    End Sub

    Private Sub ЭкспортВExcelToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ЭкспортВExcelToolStripMenuItem.Click
        If Me.dgAwards.SelectedRows.Count = 0 Then
            MsgBox("Не выбран сотрудник.") : Exit Sub
        Else
            ' MsgBox(Me.dgAwards("emplID", Me.dgAwards.CurrentRow.Index).Value())
        End If

        ' LoadFZP(" AND Employees.emplID = " & Me.dgAwards("emplID", Me.dgAwards.CurrentRow.Index).Value() & " ")
        ' MsgBox(CStr(Me.dgAwards("emplID", Me.dgAwards.CurrentRow.Index).Value()))
        LoadDetails(Me.dgAwards("emplID", Me.dgAwards.CurrentRow.Index).Value())

        Me.dgDetails.Visible = True
        Me.btnHide.Visible = True

    End Sub

    Private Sub dgAwards_CurrentCellChanged(sender As Object, e As System.EventArgs) Handles dgAwards.CurrentCellChanged
        If modeEmplPayPen = False Then ' режим штрафов и премий

        Else
            If Me.dgDetails.Visible = False Or Me.dgAwards.SelectedRows.Count = 0 Then
                Exit Sub
            Else
                If IsDBNull(Me.dgAwards("emplID", Me.dgAwards.CurrentRow.Index).Value()) = False Then
                    LoadDetails(Me.dgAwards("emplID", Me.dgAwards.CurrentRow.Index).Value())
                Else
                    Me.dgDetails.Visible = False
                    Me.btnHide.Visible = False
                End If
            End If
        End If
    End Sub

    Private Sub nudAward_MouseClick(sender As Object, e As MouseEventArgs) Handles nudAward.MouseClick
        sender.Select(0, (Len(sender.Value.ToString)))
    End Sub

    Private Sub nudAward_ValueChanged(sender As Object, e As EventArgs) Handles nudAward.ValueChanged

    End Sub

    Private Sub nudPenalty_MouseClick(sender As Object, e As MouseEventArgs) Handles nudPenalty.MouseClick
        sender.Select(0, (Len(sender.Value.ToString)))
    End Sub

    Private Sub nudPenalty_ValueChanged(sender As Object, e As EventArgs) Handles nudPenalty.ValueChanged

    End Sub
End Class