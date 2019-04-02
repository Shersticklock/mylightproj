Public Class fin_EmplPaym
    Dim curMonth As Integer 'текущий месяц

    Private Sub frmEmplPayments_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Dim odaYears As SqlClient.SqlDataAdapter
        Dim dtYears As DataTable = New DataTable

        odaYears = New SqlClient.SqlDataAdapter("SELECT DISTINCT year FROM fin_Working_Hours ", mcnnInt)
        odaYears.Fill(dtYears)

        Me.cmbYear.DataSource = dtYears
        Me.cmbYear.DisplayMember = "year"
        Me.cmbYear.ValueMember = "year"
        Me.cmbYear.SelectedIndex = dtYears.Rows.Count - 1

        If mode_deduction = False Then

            Me.chklbEmpl.Visible = False
            Me.cmbEmpl.Visible = True
            Me.lblEmpl.Visible = True
            Me.txtDescription.Visible = False
            Me.lblDescription.Visible = False
            Me.txtLimit.Visible = True
            Me.lblLimit.Visible = True

            '    'Загрузка сотрудников
            Dim odaEmpl As New SqlClient.SqlDataAdapter
            Dim dtEmpl As New DataTable

            Try
                odaEmpl = New SqlClient.SqlDataAdapter("SELECT emplID, emplLastName  FROM Employees WHERE dismissed <> 1 AND salary > 0 order by emplLastName", mcnnInt)
                odaEmpl.Fill(dtEmpl)

                Me.cmbEmpl.DataSource = dtEmpl
                Me.cmbEmpl.DisplayMember = "emplLastName"
                Me.cmbEmpl.ValueMember = "emplID"
            Catch ex As System.Exception
                MessageBox.Show(ex.Message, appName)
                Exit Sub
            End Try

            curMonth = Module1.NonQuery1Scalar("Select Month(getdate())")
            Me.cmbMonth.SelectedIndex = -1 'curMonth - 1 AWC 01/09/2014


        Else 'режим массовых удержаний
            Me.chklbEmpl.Visible = True
            Me.cmbEmpl.Visible = False
            Me.lblEmpl.Visible = False
            Me.txtLimit.Visible = False
            Me.lblLimit.Visible = False
            Me.txtDescription.Visible = True
            Me.lblDescription.Visible = True


            Dim dtEmpl1 As DataTable = New DataTable
            Dim odaEmpl1 As SqlClient.SqlDataAdapter

            Try
                odaEmpl1 = New SqlClient.SqlDataAdapter("SELECT emplID, emplLastName  FROM Employees WHERE dismissed <> 1 AND salary > 0 order by emplLastName", mcnnInt)
                odaEmpl1.Fill(dtEmpl1)

                Me.chklbEmpl.DataSource = dtEmpl1 'Связать данные со списком
                Me.chklbEmpl.DisplayMember = "emplLastName"
                Me.chklbEmpl.ValueMember = "emplID"
            Catch oexpData As System.Exception
                MsgBox(oexpData.Message, MsgBoxStyle.Critical, appName)
            End Try
        End If
    End Sub

    Private Sub cmbMonth_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cmbMonth.SelectedIndexChanged
        'If Me.cmbMonth.SelectedIndex < curMonth - 1 Then
        '     MsgBox("Можно установить только текущий месяц или будущий", MsgBoxStyle.Critical, appName)
        '    Me.cmbMonth.SelectedIndex = curMonth - 1
        'Else
        If mode_deduction = False Then Limit()
        'End If
    End Sub

    Private Sub btnSave_Click(sender As System.Object, e As System.EventArgs) Handles btnSave.Click
        Try
            If Me.cmbOrgOffice.SelectedIndex = -1 Then
                MsgBox("Не выбран источник.", MsgBoxStyle.Critical, appName)
                Me.cmbOrgOffice.Focus()
                Exit Sub
            End If

            If Me.cmbFopl.SelectedIndex = -1 Then
                MsgBox("Не выбрана форма оплаты.", MsgBoxStyle.Critical, appName)
                Me.cmbFopl.Focus()
                Exit Sub
            End If

            If Me.cmbMonth.SelectedIndex = -1 Then
                MsgBox("Не выбран период.", MsgBoxStyle.Critical, appName)
                Me.cmbMonth.Focus()
                Exit Sub
            End If

            If mode_deduction = False Then 'режим выплаты зп сотруднику
                If Me.cmbEmpl.SelectedIndex = -1 Then
                    MsgBox("Не выбран сотрудник.", MsgBoxStyle.Critical, appName)
                    Me.cmbEmpl.Focus()
                    Exit Sub
                End If

                'If Val(Me.txtLimit.Text) < Me.nudAmount.Value Then
                '    MsgBox("Сумма к выдаче превышает лимит.", MsgBoxStyle.Critical, appName)
                '    Exit Sub
                'End If

                Dim strMsg$ = "Провести выплату сотруднику " & Me.cmbEmpl.Text & "  в сумме " & Me.nudAmount.Value.ToString & " руб.?"
                Dim strSQL As String

                If MessageBox.Show(strMsg, appName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                    If Me.cmbFopl.SelectedIndex = 0 Then 'наличка
                        strSQL = "INSERT INTO PaymentsEmpl (emplID, month, year, amount, signFopl, office_ID, description) "
                        strSQL &= "VALUES ( " & Me.cmbEmpl.SelectedItem(0) & ", " & Me.cmbMonth.SelectedIndex + 1 & ", " & Me.cmbYear.SelectedItem(0) & ", "
                        strSQL &= " " & Replace(Me.nudAmount.Value, ",", ".") & ",  1, " & Me.cmbOrgOffice.SelectedValue & " , '" & Me.txtDescription.Text & "' )"
                    Else 'безнал
                        strSQL = "INSERT INTO PaymentsEmpl (emplID, month, year, amount, signFopl, org_ID, description) "
                        strSQL &= "VALUES ( " & Me.cmbEmpl.SelectedItem(0) & ", " & Me.cmbMonth.SelectedIndex + 1 & ", " & Me.cmbYear.SelectedItem(0) & ", "
                        strSQL &= " " & Replace(Me.nudAmount.Value, ",", ".") & ",  2, " & Me.cmbOrgOffice.SelectedValue & " , '" & Me.txtDescription.Text & "' )"
                    End If

                    Module1.NonQuery1(strSQL)

                    Limit()

                    Me.cmbEmpl.SelectedIndex = -1
                Else
                    MsgBox("Выплата не проведена.", MsgBoxStyle.Critical, appName)
                    Exit Sub
                End If

            Else 'Режим массовых удержаний
                If Me.chklbEmpl.CheckedItems.Count = 0 Then
                    MsgBox("Не выбраны сотрудники", MsgBoxStyle.Critical, appName) : Exit Sub
                End If

                Dim deductionAmount As Integer = CInt(Me.nudAmount.Value / Me.chklbEmpl.CheckedItems.Count)
                Dim strMsg$ = "У каждого из " & CStr(Me.chklbEmpl.CheckedItems.Count) & " отмеченных сотрудников будет удержана из ЗП " & CStr(Me.nudAmount.Value) & " руб.?"

                If MessageBox.Show(strMsg, appName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then

                    For Each itemChecked As Object In Me.chklbEmpl.CheckedItems

                        Dim strSQL As String

                        If Me.cmbFopl.SelectedIndex = 0 Then 'наличка
                            strSQL = "INSERT INTO PaymentsEmpl (emplID, month, year, amount, signFopl, office_ID, description) "
                            strSQL &= "VALUES ( " & itemChecked.item(0) & ", " & Me.cmbMonth.SelectedIndex + 1 & ", " & Me.cmbYear.SelectedItem(0) & ", "
                            strSQL &= " " & Replace(Me.nudAmount.Value, ",", ".") & ",  1, " & Me.cmbOrgOffice.SelectedValue & " , '" & Me.txtDescription.Text & "' )"
                        Else 'безнал
                            strSQL = "INSERT INTO PaymentsEmpl (emplID, month, year, amount, signFopl, org_ID, description) "
                            strSQL &= "VALUES ( " & itemChecked.item(0) & ", " & Me.cmbMonth.SelectedIndex + 1 & ", " & Me.cmbYear.SelectedItem(0) & ", "
                            strSQL &= " " & Replace(Me.nudAmount.Value, ",", ".") & ",  2, " & Me.cmbOrgOffice.SelectedValue & " , '" & Me.txtDescription.Text & "')"
                        End If

                        Module1.NonQuery1(strSQL)
                    Next
                    MsgBox("Готово", MsgBoxStyle.Information, appName)
                Else
                    MsgBox("Запись не произведена.", MsgBoxStyle.Critical, appName)
                End If
            End If
        Catch ex As System.Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, appName)
        End Try
    End Sub


    Private Sub cmbEmpl_SelectedValueChanged(sender As Object, e As System.EventArgs) Handles cmbEmpl.SelectedValueChanged
        If Me.cmbEmpl.SelectedIndex <> -1 Then
            'если безналом переплатил отразить это в лимите а если не выбрын безнал то лимит это наличная часть


            Limit()



            'Try
            '    MsgBox(CStr(Me.cmbEmpl.Items(0)))

            '    Me.txtLimit.Text = fin_EmplPlan.dgTableData("to_delivery", fin_EmplPlan.dgTableData.CurrentRow.Index).Value
            'Catch ex As System.Exception
            '    Limit()
            'End Try

            '  
        End If
    End Sub

    Private Sub Limit()
        Dim emplFZP% = Me.cmbEmpl.SelectedItem(0)
        Dim currentMonth% = Me.cmbMonth.SelectedIndex + 1
        Dim factOplataBeznal@ = Module1.NonQuery1Scalar("SELECT coalesce(SUM(amount), 0) FROM PaymentsEmpl WHERE year = year(getdate())  AND month =  " & currentMonth & " AND emplID = " & emplFZP & " AND signFopl = 2")
        Dim onCard@ = Module1.NonQuery1Scalar("SELECT OnCard FROM Employees WHERE  Employees.emplID = " & emplFZP & " ")
        Dim pereplata@, strPereplat$

        If factOplataBeznal > onCard Then
            pereplata = factOplataBeznal - onCard
            strPereplat = ", На карту переплачено - " + CStr(pereplata) + " руб."
        Else
            pereplata = 0
            strPereplat = Nothing
        End If

        'Dim strSQL$ = "SELECT (coalesce(salary, 0) - coalesce(OnCard, 0) - (SELECT coalesce(SUM(amount), 0) FROM PaymentsEmpl WHERE year = year(getdate())"
        'strSQL &= "  AND month =  " & currentMonth & " AND emplID = " & emplFZP & ") - " & pereplata & " + "
        'strSQL &= " (SELECT coalesce(SUM(awardsAmount), 0) - coalesce(SUM(penaltyAmount), 0) FROM EmplAwards WHERE year = year(getdate()) AND month =  " & currentMonth & " "
        'strSQL &= "  AND emplID = " & emplFZP & ")) FROM Employees WHERE Employees.emplID = " & emplFZP & " "

        Dim strSQL$ = "SELECT coalesce(salary, 0) - coalesce(OnCard, 0) - (SELECT coalesce(SUM(amount), 0) FROM PaymentsEmpl WHERE year = year(getdate()) "
        strSQL &= " AND month =  " & currentMonth & " AND emplID = " & emplFZP & " AND signFopl = 1) "
        strSQL &= " FROM Employees WHERE Employees.emplID = " & emplFZP & " "

        Me.txtLimit.Text = CStr(Module1.NonQuery1Scalar(strSQL)) + strPereplat
    End Sub

    Private Sub ВыделитьВсеToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ВыделитьВсеToolStripMenuItem.Click
        Dim i%

        For i = 0 To Me.chklbEmpl.Items.Count - 1
            Me.chklbEmpl.SetItemChecked(i, True)
        Next
    End Sub

    Private Sub СброситьВсеToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles СброситьВсеToolStripMenuItem.Click
        Dim i%

        For i = 0 To Me.chklbEmpl.Items.Count - 1
            Me.chklbEmpl.SetItemChecked(i, False)
        Next
    End Sub

    Private Sub chklbEmpl_SelectedValueChanged(sender As Object, e As System.EventArgs) Handles chklbEmpl.SelectedValueChanged
        Me.lblEmpl.Text = "Выбрано- " & CStr(Me.chklbEmpl.CheckedItems.Count)
        Me.lblEmpl.Visible = True
    End Sub


    Private Sub cmbFopl_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cmbFopl.SelectedIndexChanged

        Dim strSQL$ = Nothing

        If Me.cmbFopl.SelectedIndex = 1 Then
            strSQL = "SELECT custID as ID, Name FROM Organizations WHERE KAgent_ID  = (SELECT ID FROM KAgents WHERE type_ID = 1) "
        Else
            strSQL = "SELECT ID, name FROM Offices"
        End If

        Dim odaOrg As SqlClient.SqlDataAdapter
        Dim dtOrg As DataTable = New DataTable

        odaOrg = New SqlClient.SqlDataAdapter(strSQL, mcnnInt)
        odaOrg.Fill(dtOrg)

        Me.cmbOrgOffice.DataSource = dtOrg    'Связать данные со списком
        Me.cmbOrgOffice.DisplayMember = "Name"
        Me.cmbOrgOffice.ValueMember = "ID"

        Me.cmbOrgOffice.Visible = True
        Me.cmbOrgOffice.Focus()
    End Sub

    Private Sub cmbEmpl_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cmbEmpl.SelectedIndexChanged

    End Sub

    Private Sub nudAmount_MouseClick(sender As Object, e As MouseEventArgs) Handles nudAmount.MouseClick
        sender.Select(0, (Len(sender.Value.ToString)))
    End Sub

    Private Sub nudAmount_ValueChanged(sender As Object, e As EventArgs) Handles nudAmount.ValueChanged

    End Sub
End Class