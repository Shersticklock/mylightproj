Public Class frmTaskCard

    Dim mdrTask As DataRow

    Private Sub frmTaskCard_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'Загружаем список исполнителей
        Dim odaDesignerFind As New SqlClient.SqlDataAdapter("SELECT emplID, emplLastName  FROM Employees where dismissed <> 1 order by emplLastName", mcnnInt)
        Dim dtDesigner As New DataTable : odaDesignerFind.Fill(dtDesigner)

        Me.cmbExecutor.DataSource = dtDesigner
        Me.cmbExecutor.DisplayMember = "emplLastName"
        Me.cmbExecutor.ValueMember = "emplID"

        Dim odaStatus As New SqlClient.SqlDataAdapter("SELECT ID, Name  FROM TaskStatuses ", mcnnInt)
        Dim dtStatus As New DataTable : odaStatus.Fill(dtStatus)

        Me.cmbStatus.DataSource = dtStatus
        Me.cmbStatus.DisplayMember = "Name"
        Me.cmbStatus.ValueMember = "ID"

        Dim odaTT As New SqlClient.SqlDataAdapter("SELECT ID, Name FROM TaskTypes", mcnnInt)
        Dim dtTT As New DataTable : odaTT.Fill(dtTT)

        Me.cmbTypeTask.DataSource = dtTT
        Me.cmbTypeTask.DisplayMember = "Name"
        Me.cmbTypeTask.ValueMember = "ID"

        Dim odaKA As New SqlClient.SqlDataAdapter("SELECT ID, Name FROM KAgents", mcnnInt)
        Dim dtKA As New DataTable : odaKA.Fill(dtKA)

        Me.cmbKA.DataSource = dtKA
        Me.cmbKA.DisplayMember = "Name"
        Me.cmbKA.ValueMember = "ID"
        Me.cmbKA.SelectedIndex = -1

        If custID <> Nothing Then
            Me.cmbKA.SelectedValue = custID
        End If

        If createTask = False Then 'открываем для редактирования
            LoadTask()

            Me.dgPersons.Visible = False
            Me.lblPersons.Visible = False
            Me.txtTaskComment.Visible = True
            Me.lblTaskComment.Visible = True
            Me.lblDateFinish.Visible = True
            Me.dtpDateFinish.Visible = True
        Else 'новая задача
            Me.lblStatus.Visible = False
            Me.cmbStatus.Visible = False
            Me.cmbPriority.SelectedIndex = -1
            Me.cmbExecutor.SelectedIndex = -1
            Me.txtDate_Start.Text = Format(Now(), "s")

            Me.txtTaskComment.Visible = False
            Me.lblTaskComment.Visible = False
            Me.lblDateFinish.Visible = False
            Me.dtpDateFinish.Visible = False

            If Me.cmbKA.SelectedIndex = -1 Then
                Me.dgPersons.DataSource = Nothing
            Else

            End If

            Me.dtpdata_Performance.Value = Now.Date
        End If

        Dim odaDepartment As New SqlClient.SqlDataAdapter("SELECT ID, Name FROM Departments order by name", mcnnInt)
        Dim dtDepartments As New DataTable : odaDepartment.Fill(dtDepartments)

        Me.cmbDepartment.DataSource = dtDepartments 'Связать данные со списком
        Me.cmbDepartment.DisplayMember = "Name"
        Me.cmbDepartment.ValueMember = "ID"

        If createTask = False Then
            Me.cmbDepartment.SelectedValue = Module1.NonQuery1Scalar("SELECT coalesce(departmentID, 1) FROM Employees WHERE emplID = " & emplID & "  ")
        End If

        ' Me.txtCustForSearh.Enabled = createTask

    End Sub

    Private Sub LoadTask()
        Try
            Dim cmd As New SqlClient.SqlCommand

            cmd.Connection = mcnnInt
            cmd.CommandText = "[sp_Task_parameters]"
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.Add(New SqlClient.SqlParameter("@taskID", SqlDbType.Int))
            cmd.Parameters("@taskID").Value = taskID

            Dim objDA As New SqlClient.SqlDataAdapter(cmd)
            Dim dtTask As New DataTable : objDA.Fill(dtTask)

            If dtTask.Rows.Count > 0 Then

                mdrTask = dtTask.Rows(0)   'Получить отдельную строку данных

                Me.cmbExecutor.SelectedValue = mdrTask("empID_executor")
                Me.cmbStatus.SelectedValue = mdrTask("statusID")
                Me.txtTaskContent.Text = mdrTask("taskContent")
                Me.Text += " от " & mdrTask("data_Statement")
                Me.txtDate_Start.Text = mdrTask("data_Statement")

                '   MsgBox("sdjvb")

                Me.dtpdata_Performance.Value = mdrTask("data_Plan")
                Me.cmbTypeTask.SelectedValue = mdrTask("taskTypesID")
                Me.cmbKA.SelectedValue = mdrTask("KA_ID")
                Me.cmbPriority.SelectedIndex = mdrTask("priority")
                Me.txtTaskComment.Text = mdrTask("taskComment")

                If mdrTask("statusID") = 4 Then 'задача выполнена
                    Me.lblDateFinish.Visible = True
                    Me.dtpDateFinish.Visible = True
                    Me.dtpDateFinish.Value = mdrTask("dateFinish")
                Else
                    Me.lblDateFinish.Visible = False
                    Me.dtpDateFinish.Visible = False
                End If
            Else
                Me.Close()
            End If
        Catch excData As System.Exception
            MessageBox.Show(excData.Message, appName)
            Exit Sub
        End Try
    End Sub

#Region " Загружаем данные о заказчиках - наименования и персон  "
    Private Sub LoadCustomers(ByVal strFind As String)
        If strFind = "'" Then
            Exit Sub
        End If

        Dim odaPartList As SqlClient.SqlDataAdapter
        Dim dtPartList As New DataTable

        If strFind <> Nothing Then
            odaPartList = New SqlClient.SqlDataAdapter("SELECT ID, Name FROM KAgents WHERE Name LIKE '%" & strFind & "%'  order by name", mcnnInt)
            odaPartList.Fill(dtPartList)
        Else
            odaPartList = New SqlClient.SqlDataAdapter("SELECT ID, Name FROM KAgents order by name", mcnnInt)
            odaPartList.Fill(dtPartList)
        End If

        Me.cmbKA.DataSource = dtPartList
        Me.cmbKA.DisplayMember = "Name"
        Me.cmbKA.ValueMember = "ID"
    End Sub

#Region " Сохранить задачу "
    Private Sub tsbtnOK_Click(sender As System.Object, e As System.EventArgs) Handles tsbtnOK.Click
        If Me.dtpdata_Performance.Value = Me.dtpdata_Performance.MinDate Then
            MsgBox("Укажи реальный срок выполнения задачи.", MsgBoxStyle.Critical, appName) : Exit Sub
        End If

        'If Me.dtpdata_Performance.Value.Date <= Format(Now().Date, "dd MMMM yyyy hh:mm") Then
        'MsgBox("Укажи реальный срок выполнения задачи. Больше текущей даты.", MsgBoxStyle.Critical, appName) : Exit Sub
        'End If

        If Me.cmbTypeTask.SelectedIndex = -1 Then
            MsgBox("НЕ указан тип задачи", MsgBoxStyle.Critical, appName)
            Exit Sub
        End If

        If Me.cmbPriority.SelectedIndex = -1 Then
            MsgBox("НЕ указан приоритет задачи", MsgBoxStyle.Critical, appName)
            Exit Sub
        End If

        If Me.cmbExecutor.SelectedIndex = -1 Then
            MsgBox("НЕ указан исполнитель задачи", MsgBoxStyle.Critical, appName)
            Exit Sub
        End If

        If Me.txtTaskContent.Text = Nothing Then
            MsgBox("НЕ указано содержимое задачи", MsgBoxStyle.Critical, appName)
            Exit Sub
        End If

        Dim strSQL$

        If createTask = False Then 'не выполнена редактирование
            If Me.cmbStatus.SelectedItem(0) = 4 Then 'ставим отметку об исполнении
                If Module1.NonQuery1Scalar("SELECT statusID FROM Tasks WHERE ID = " & taskID & " ") = 4 Then
                    MsgBox("Задача уже выполнена", MsgBoxStyle.Critical, appName) : Exit Sub
                Else 'не выполнена уст отметку о выполнении
                    strSQL = "UPDATE Tasks SET taskTypesID = " & Me.cmbTypeTask.SelectedItem(0) & ", statusID = " & Me.cmbStatus.SelectedItem(0) & ", dateFinish = getdate(), priority = " & Me.cmbPriority.SelectedIndex & ", taskComment = '" & Me.txtTaskComment.Text & "' WHERE ID = " & taskID & " "
                End If
            Else
                strSQL = "UPDATE Tasks SET taskTypesID = " & Me.cmbTypeTask.SelectedItem(0) & ", statusID = " & Me.cmbStatus.SelectedItem(0) & ", priority =  " & Me.cmbPriority.SelectedIndex & ", taskComment = '" & Me.txtTaskComment.Text & "', empID_executor = " & Me.cmbExecutor.SelectedItem(0) & ", KA_ID = " & Me.cmbKA.SelectedItem(0) & " WHERE ID = " & taskID & " "
            End If

            Module1.NonQuery1(strSQL)
        Else
            'сделать на сервере дату создания - текущую дату-сделал
            Try 'запись в таблицу
                Dim modaIndiv As New SqlClient.SqlDataAdapter("SELECT * FROM Tasks WHERE ID = " & taskID & "  ", mcnnInt)
                Dim dtTask As New DataTable : modaIndiv.Fill(dtTask)
                Dim mdrIndiv As DataRow : mdrIndiv = dtTask.NewRow

                mdrIndiv.BeginEdit()

                mdrIndiv("empID_autor") = emplID
                mdrIndiv("taskContent") = Me.txtTaskContent.Text
                mdrIndiv("data_Plan") = Me.dtpdata_Performance.Value
                mdrIndiv("priority") = Me.cmbPriority.SelectedIndex
                mdrIndiv("empID_executor") = Me.cmbExecutor.SelectedItem(0)
                mdrIndiv("taskTypesID") = Me.cmbTypeTask.SelectedItem(0)
                mdrIndiv("taskComment") = Me.txtTaskComment.Text

                If costID <> Nothing Then
                    mdrIndiv("orderID") = costID
                End If

                ' mdrIndiv("data_Statement") = Format(Me.dtpdata_Performance.Value, "s")
                '   mdrIndiv("dateStart") = Now() 'Format(Me.dtpdate_Start.Value.Date, "s")

                If Me.cmbKA.SelectedIndex <> -1 Then
                    mdrIndiv("KA_ID") = Me.cmbKA.SelectedItem(0)
                End If

                If Me.cmbStatus.SelectedItem(0) <> 1 Then ' задача уже выполнена
                    mdrIndiv("dateFinish") = Me.dtpdata_Performance.Value
                    mdrIndiv("statusID") = 4
                Else
                    mdrIndiv("statusID") = 1
                End If

                mdrIndiv.EndEdit()         'Завершить редактировать строку данных
                dtTask.Rows.Add(mdrIndiv)

                Dim ocbIndiv As SqlClient.SqlCommandBuilder

                ocbIndiv = New SqlClient.SqlCommandBuilder(modaIndiv)
                modaIndiv.InsertCommand = ocbIndiv.GetInsertCommand
                modaIndiv.Update(dtTask)
                dtTask.AcceptChanges()
                modaIndiv.InsertCommand.Connection.Close()
            Catch oexp As System.Exception
                MsgBox("error" & oexp.Message, MsgBoxStyle.Critical, appName)
            End Try
        End If

        Me.Close()
    End Sub

    ' Private Sub SaveTask()
    '    If Me.cmbKA.SelectedIndex = -1 Then
    '        'MsgBox("Начни вводить наименование заказчика", MsgBoxStyle.Critical, appName)
    '        'Me.ErrorProvider1.SetError(Me.txtFindCust, "Начни вводить наименование заказчика")
    '        'Me.txtFindCust.Focus()
    '        'Exit Sub
    '    End If

    '    If Me.cmbPriority.SelectedIndex = -1 Then
    '        'MsgBox("Начни вводить наименование продукции", MsgBoxStyle.Critical, appName)
    '        'Me.ErrorProvider1.SetError(Me.txtFindProd, "Начни вводить наименования продукции")
    '        'Me.txtFindProd.Focus()
    '        'Exit Sub
    '    End If

    '    '  Dim nomerVn$ = Nothing
    '    Select Case MsgBox(Prompt:="Сохранить задачу?", Buttons:=vbYesNo, Title:=appName)
    '        Case Is = vbYes
    '            Try
    '                Dim strSQL$

    '                strSQL = "INSERT INTO Tasks (empID_autor, taskContent, data_Statement, empID_executor, data_Plan, time_Plan,  orderID, priority ) "
    '                strSQL &= " VALUES (" & emplID & ", '" & Me.txtTaskContent.Text & "', '" & Format(Me.dtpdate_Start.Value.Date, "s") & "', "
    '                strSQL &= "  " & Me.cmbExecutor.SelectedItem(0) & ", '" & Format(Me.dtpdata_Performance.Value.Date, "s") & "', " & Me.nudtime_Performance.Value & ", "
    '                strSQL &= " " & Me.cmbPriority.SelectedIndex + 1 & " ) "
    '                '***
    '                Dim objCommand As New SqlClient.SqlCommand(strSQL)

    '                mcnnInt.Open()
    '                objCommand.Connection = mcnnInt

    '                If objCommand.ExecuteNonQuery > 0 = True Then
    '                    Dim objIdentifier As New SqlClient.SqlCommand("Select @@Identity", mcnnInt)
    '                    Try
    '                        costID = objIdentifier.ExecuteScalar
    '                    Catch
    '                        costID = 0
    '                    End Try
    '                End If

    '                mcnnInt.Close()

    '                If Module1.NonQuery1Scalar("SELECT count(*) FROM EmplCust WHERE custID = " & custID & " ") = 1 Then
    '                    strSQL = "UPDATE Costs SET emplCust = (SELECT TOP 1 emplCustID FROM EmplCust WHERE custID = " & custID & ")  WHERE costID = " & costID & " "
    '                    Module1.NonQuery1(strSQL)
    '                End If

    '                'Select Case MsgBox(Prompt:="Приступить к расчету заказа?", Buttons:=vbYesNo, Title:=appName)
    '                '    Case Is = vbYes
    '                '        ModCallForm.CallForm("", 11, 3)
    '                '    Case Is = vbNo
    '                'End Select
    '            Catch ex As System.Exception
    '                MsgBox(ex.Message, MsgBoxStyle.Critical, appName)
    '            End Try
    '        Case Is = vbNo : Exit Sub
    '    End Select
    'End Sub
#End Region

    Private Sub txtCustForSearh_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles txtCustForSearh.KeyDown
        LoadCustomers(Me.txtCustForSearh.Text)
    End Sub

    '**************************************************************
#End Region

    Private Sub ДобавитьКонтрагентаToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ДобавитьКонтрагентаToolStripMenuItem.Click
        addcust = True
        ModCallForm.CallForm("Контрагенты", 9, 3)
    End Sub

    Private Sub cmbKA_SelectedValueChanged(sender As Object, e As System.EventArgs) Handles cmbKA.SelectedValueChanged
        If Me.cmbKA.SelectedIndex <> -1 Then
            Try
                Dim odaEmplRout As New SqlClient.SqlDataAdapter("SELECT lastName AS ФИО, telEmpl as Телефон, emailEmpl AS email FROM EmplCust WHERE custID = " & Me.cmbKA.SelectedItem(0) & " ", mcnnInt)
                Dim dtEmplRout As New DataTable : odaEmplRout.Fill(dtEmplRout)

                Me.dgPersons.DataSource = dtEmplRout
                ' For n As Integer = 0 To dtEmplRout.Rows.Count - 1
                ' Me.lstPersons.Items.Add(dtEmplRout.i)
                ' Next
                '   If Me.txtTaskContent.Text <> Module1.NonQuery1ScalarString("SELECT COALESCE(Tel, 'нет') FROM KAgents WHERE ID = " & Me.cmbKA.SelectedItem(0) & "") Then
                'Me.txtTaskContent.Text += Module1.NonQuery1ScalarString("SELECT COALESCE(Tel, 'нет') FROM KAgents WHERE ID = " & Me.cmbKA.SelectedItem(0) & "")
                'End If

            Catch ex As System.Exception
                MsgBox("Загрузка персон-" + ex.Message, MsgBoxStyle.Critical, appName)
                Exit Sub
            End Try
        End If
     
    End Sub

    Private Sub dgPersons_CellDoubleClick(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgPersons.CellDoubleClick
        Me.txtTaskContent.Text += Me.dgPersons("ФИО", Me.dgPersons.SelectedRows.Item(0).Index).Value()
        Me.txtTaskContent.Text += "Телефон - "
        Me.txtTaskContent.Text += Me.dgPersons("Телефон", Me.dgPersons.SelectedRows.Item(0).Index).Value()
        Me.txtTaskContent.Text += " эл.почта - "
        Me.txtTaskContent.Text += Me.dgPersons("email", Me.dgPersons.SelectedRows.Item(0).Index).Value()
    End Sub

    Private Sub tsbtnExit_Click(sender As System.Object, e As System.EventArgs) Handles tsbtnExit.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click

        '  If createTask = True Then
        Try
            Dim odaEmplRout As New SqlClient.SqlDataAdapter("SELECT emplID, emplLastName FROM Employees WHERE departmentID = " & Me.cmbDepartment.SelectedItem(0) & " and dismissed <> 1 order by emplLastName", mcnnInt)
            Dim dtEmplRout As New DataTable : odaEmplRout.Fill(dtEmplRout)

            Me.cmbExecutor.DataSource = dtEmplRout
            Me.cmbExecutor.DisplayMember = "emplLastName"
            Me.cmbExecutor.ValueMember = "emplID"
            Me.cmbExecutor.Focus()
        Catch ex As System.Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, appName)
            Exit Sub
        End Try
        '  End If
    End Sub

    Private Sub cmbKA_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cmbKA.SelectedIndexChanged

    End Sub
End Class