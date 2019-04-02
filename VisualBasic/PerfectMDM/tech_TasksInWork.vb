Imports System.IO

Public Class tech_TasksInWork

    Dim currentTaskID As Integer

    Private Sub frmTasksInWork_Activated(sender As Object, e As System.EventArgs) Handles Me.Activated
        '   LoadMeTasks()

        'If Module1.NonQuery1ScalarString("SELECT COUNT(*) FROM Tasks WHERE empID_executor = " & emplID & " AND statusID = 2 ") = 0 Then
        '    Me.btnCurrTask.Text = "Нет заказа в работе"
        'Else
        '    Me.btnCurrTask.Text = "Текущий заказ - " & Module1.NonQuery1ScalarString("SELECT nomerVN FROM Costs WHERE costID = (SELECT orderID FROM Tasks WHERE empID_executor = " & emplID & " AND statusID = 2) ")
        'End If

        If Me.dgTableData.SelectedRows.Count > 0 Then
            ' Dim strSQL$ = "SELECT taskContent FROM Tasks WHERE ID = " & Me.dgTableData("ID", Me.dgTableData.SelectedRows.Item(0).Index).Value() & " "
            '  Dim strSQL$ = "UPDATE Files SET description = '" & newDescript & "' WHERE ID = " & Me.dgFiles("ID", Me.dgFiles.CurrentRow.Index).Value() & " "
            '  Me.txtContent.Text = Module1.NonQuery1ScalarString("SELECT coalesce(taskContent, '') FROM Tasks WHERE empID_executor = " & emplID & " AND statusID = 2")
        End If
    End Sub

    Private Sub frmTasksInWork_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Try
            Dim odaEmplRout As New SqlClient.SqlDataAdapter("SELECT emplID, emplLastName FROM Employees WHERE departmentID=(SELECT departmentID FROM Employees WHERE emplID=" & emplID & ") order by emplLastName", mcnnInt)
            Dim dtEmplRout As New DataTable : odaEmplRout.Fill(dtEmplRout)

            Me.tscmbEmpl.ComboBox.DataSource = dtEmplRout
            Me.tscmbEmpl.ComboBox.DisplayMember = "emplLastName"
            Me.tscmbEmpl.ComboBox.ValueMember = "emplID"

            Dim odaDepartment As New SqlClient.SqlDataAdapter("SELECT ID, Name FROM Departments order by name", mcnnInt)
            Dim dtDepartments As New DataTable : odaDepartment.Fill(dtDepartments)
            Me.cmbDepartment.DataSource = dtDepartments 'Связать данные со списком
            Me.cmbDepartment.DisplayMember = "Name"
            Me.cmbDepartment.ValueMember = "ID"
        Catch ex As System.Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, appName)
        End Try

        LoadMeTasks(1)
    End Sub

    Private Sub LoadMeTasks(selectMode As Integer)
        Try
            Me.dgTableData.Columns.Remove("btn")
        Catch ex As System.Exception
        End Try

        Dim cmd As New SqlClient.SqlCommand

        cmd.Connection = mcnnInt

        Select Case selectMode
            Case Is = 1
                cmd.CommandText = "[sp_Tasks_My_Tech]"
            Case Is = 2
                cmd.CommandText = "[sp_Tasks_My_TechSortOrder]"
            Case Is = 3
                cmd.CommandText = "[sp_Tasks_My_TechSortMat]"
        End Select

        cmd.CommandType = CommandType.StoredProcedure

        cmd.Parameters.Add(New SqlClient.SqlParameter("@emplID", SqlDbType.Int))
        cmd.Parameters("@emplID").Value = emplID

        Dim objDA As New SqlClient.SqlDataAdapter(cmd)
        Dim dtTasks As New DataTable : objDA.Fill(dtTasks)

        Me.dgTableData.DataSource = dtTasks

        Try
            ColHideDG(dgTableData)

            For n As Integer = 0 To Me.dgTableData.RowCount - 1
                If Me.dgTableData("statusID", n).Value = 2 Then ' в работе
                    Me.dgTableData.Rows(n).DefaultCellStyle.BackColor = Color.LightCyan
                End If

                If Me.dgTableData("statusID", n).Value = 3 Then ' приостановлены
                    Me.dgTableData.Rows(n).DefaultCellStyle.BackColor = Color.Magenta
                End If

                If Me.dgTableData("statusID", n).Value = 0 Then ' не брать в раб так как предыдущие не выполнены
                    Me.dgTableData.Rows(n).DefaultCellStyle.BackColor = Color.Gray
                End If

                If Me.dgTableData("statusID", n).Value = 1 Then ' мажно брать в работу
                    Me.dgTableData.Rows(n).DefaultCellStyle.BackColor = Color.LightGreen
                End If
            Next

            Dim btn As New DataGridViewButtonColumn()

            dgTableData.Columns.Add(btn)
            btn.HeaderText = ""
            btn.FlatStyle = FlatStyle.Flat
            btn.FillWeight = 130

            btn.Text = "Взять в работу"
            btn.Name = "btn"
            btn.UseColumnTextForButtonValue = True
            btn.DefaultCellStyle.ForeColor = Color.Blue

            Me.dgTableData.ClearSelection()

        Catch ex As System.Exception
            MessageBox.Show(ex.Message, appName)
            Exit Sub
        End Try

        'If Module1.NonQuery1ScalarString("SELECT COUNT(*) FROM Tasks WHERE empID_executor = " & emplID & " AND statusID = 2 ") = 0 Then
        '    Me.btnTaskStart.Text = "Нет задачи в работе"
        'Else
        '    Me.btnTaskStart.Text = "Текущий заказ - " & Module1.NonQuery1ScalarString("SELECT TOP 1 nomerVN FROM Costs WHERE costID = (SELECT orderID FROM Tasks WHERE empID_executor = " & emplID & " AND statusID = 2) ")
        'End If
    End Sub


    Private Sub ColHideDG(NameGrid As Object)
        For Each col As Object In NameGrid.Columns
            If col.name = "dataFile" Or col.name = "link" Or col.name = "inDB" Or col.name = "ID" Or col.name = "statusID" Or col.name = "costID" Or col.name = "operOrder_ID" Or col.name = "matForOper" Or col.name = "ranger" Or col.name = "orderID" Or col.name = "Цвет" Then
                col.visible = False
            End If
        Next

        NameGrid.ClearSelection()
    End Sub

#Region " Переход к заказу "

#End Region

    Private Sub Timer1_Tick(sender As System.Object, e As System.EventArgs) Handles Timer1.Tick
        '  LoadMeTasks()
    End Sub


    Private Sub dgTableData_CellClick(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgTableData.CellClick
        ''   MsgBox(CStr(e.ColumnIndex))
        '' MsgBox(CStr(dgTableData.Columns.Count - 1))
        If e.ColumnIndex = dgTableData.Columns.Count - 1 Then
            Dim strSQL1$ = Nothing

            ' If Me.dgTableData.RowCount > 0 Then
            '  If Module1.NonQuery1ScalarString("SELECT COUNT(*) FROM Tasks WHERE empID_executor=" & emplID & " AND statusID=2") = 0 Then 'если нет задач в работе
            Select Case Module1.NonQuery1ScalarString("SELECT statusID FROM Tasks WHERE ID=" & Me.dgTableData("ID", Me.dgTableData.CurrentRow.Index).Value & "")
                Case Is = 1 'Задача в плане
                    strSQL1 = "UPDATE Tasks SET empID_executor=" & emplID & ",dateStart='" & Format(Now().Date, "s") & "',statusID = 2 WHERE ID=" & Me.dgTableData("ID", Me.dgTableData.CurrentRow.Index).Value & " "
                    '  Me.Countdown1.Start()
                Case Is = 3 'из приостановленной
                    strSQL1 = "UPDATE Tasks SET empID_executor=" & emplID & ",statusID=2 WHERE ID=" & Me.dgTableData("ID", Me.dgTableData.CurrentRow.Index).Value & ""
                    'определяем сколько времени эта хадача уже выполнялась
                    ' Me.Countdown1.Value = Module1.NonQuery1Scalar("SELECT coalesce(duration, 0) FROM Tasks WHERE ID=" & Me.dgTableData("ID", Me.dgTableData.CurrentRow.Index).Value & " ")
                    '  Me.Countdown1.Start()
                Case Else
                    MsgBox("Задача в работе.", MsgBoxStyle.Information, appName)
                    Exit Sub
            End Select

            Module1.NonQuery1(strSQL1)

            LoadMeTasks(1)

            Me.dgTableData.ClearSelection()

            'If Module1.NonQuery1ScalarString("SELECT statusID FROM Tasks WHERE ID = " & Me.dgTableData("ID", Me.dgTableData.SelectedRows.Item(0).Index).Value() & " ") = 1 Then 'Задача в плане
            '    strSQL = "UPDATE Tasks SET empID_executor = " & emplID & ", dateStart= '" & Format(Now().Date, "s") & "', statusID = 2 WHERE ID = " & Me.dgTableData("ID", Me.dgTableData.SelectedRows.Item(0).Index).Value() & " "
            '    Me.Countdown1.Start()
            'Else 'из приостановленной
            '    strSQL = "UPDATE Tasks SET empID_executor = " & emplID & ", statusID = 2 WHERE ID = " & Me.dgTableData("ID", Me.dgTableData.SelectedRows.Item(0).Index).Value() & " "
            '    'определяем сколько времени эта хадача уже выполнялась
            '    Me.Countdown1.Value = Module1.NonQuery1Scalar("SELECT coalesce(duration, 0) FROM Tasks WHERE ID = " & Me.dgTableData("ID", Me.dgTableData.SelectedRows.Item(0).Index).Value() & " ")
            '    Me.Countdown1.Start()
            'End If
            ' LoadMeTasks()
            'Else
            '    ' MsgBox("Необходимо завершить или приостановить текущую задачу.", MsgBoxStyle.Critical, appName)
            '    Exit Sub
            'End If
            'End If
            '   Me.dgTableData.Enabled = False
            '  Me.Timer1.Enabled = True
        End If

        '   Me.dgTableData.Rows(e.RowIndex).DefaultCellStyle.BackColor = Color.LightGreen
    End Sub

    Private Sub TaskInWork()
        Dim strSQL$

        If Me.dgTableData("statusID", Me.dgTableData.CurrentRow.Index).Value = 1 Then 'Задача в плане
            strSQL = "UPDATE Tasks SET empID_executor=" & emplID & ",dateStart='" & Now() & "',statusID=2 WHERE ID=" & Me.dgTableData("ID", Me.dgTableData.CurrentRow.Index).Value & ""
        Else 'из приостановленной
            strSQL = "UPDATE Tasks SET empID_executor=" & emplID & ",statusID=2 WHERE ID=" & Me.dgTableData("ID", Me.dgTableData.CurrentRow.Index).Value & " "
            'определяем сколько времени эта хадача уже выполнялась
            '  Me.Countdown2.Value = Module1.NonQuery1Scalar("SELECT coalesce(duration, 0) FROM Tasks WHERE ID=" & Me.dgTableData("ID", Me.dgTableData.CurrentRow.Index).Value & " ")
        End If

        currentTaskID = Me.dgTableData("ID", Me.dgTableData.CurrentRow.Index).Value

        Module1.NonQuery1(strSQL)

        LoadMeTasks(1)

        'Me.Countdown2.Start()
    End Sub

    Private Sub dgTableData_SelectionChanged(sender As Object, e As EventArgs) Handles dgTableData.SelectionChanged
        If Me.dgTableData.SelectedRows.Count = 1 Then
            '   Dim strSQL$ = "UPDATE Files SET description = '" & newDescript & "' WHERE ID = " & Me.dgFiles("ID", Me.dgFiles.CurrentRow.Index).Value() & " "
            If Me.dgTableData.CurrentRow Is Nothing Then
            Else
                ' Me.txtContent.Text = Me.dgTableData("Описание", Me.dgTableData.CurrentRow.Index).Value()
                '  Me.Countdown2.Value = Module1.NonQuery1Scalar("SELECT COALESCE(duration, 0) FROM Tasks WHERE ID=" & Me.dgTableData("ID", Me.dgTableData.CurrentRow.Index).Value() & "")
                '  Me.txtContent.Text = Module1.NonQuery1ScalarString("SELECT taskContent FROM Tasks WHERE ID = " & Me.dgTableData("ID", Me.dgTableData.SelectedRows.Item(0).Index).Value() & " ")

                Me.txtContent.Text = Module1.NonQuery1ScalarString("select Purpose from PurposeCost where costID=" & Me.dgTableData("costID", Me.dgTableData.CurrentRow.Index).Value() & "")
            End If

            Dim cmd As New SqlClient.SqlCommand

            cmd.Connection = mcnnInt
            cmd.CommandText = "[sp_Sklad_DeliveryForOper]"
            cmd.CommandType = CommandType.StoredProcedure

            cmd.Parameters.Add(New SqlClient.SqlParameter("@operID", SqlDbType.Int))
            cmd.Parameters("@operID").Value = Me.dgTableData("operOrder_ID", Me.dgTableData.CurrentRow.Index).Value()

            Dim objDA As New SqlClient.SqlDataAdapter(cmd)
            Dim dtMatList As New DataTable : objDA.Fill(dtMatList)

            Me.dgMatExpens.DataSource = dtMatList  'Связать данные со списком

            ColHideDG(dgMatExpens)


            Dim cmd1 As New SqlClient.SqlCommand

            cmd1.Connection = mcnnInt
            cmd1.CommandText = "sp_Order_FillSpec"
            cmd1.CommandType = CommandType.StoredProcedure
            cmd1.Parameters.Add(New SqlClient.SqlParameter("@costID", SqlDbType.Int))
            cmd1.Parameters("@costID").Value = costID

            Dim objDA1 As New SqlClient.SqlDataAdapter(cmd1)
            Dim dtSpec As New DataTable : objDA1.Fill(dtSpec)

            Me.dgSpec.DataSource = dtSpec  'Связать данные со списком

            ColHideDG(dgSpec)

            Try
                Dim cmd2 As New SqlClient.SqlCommand

                cmd2.Connection = mcnnInt
                cmd2.CommandText = "sp_Order_FillFiles"
                cmd2.CommandType = CommandType.StoredProcedure
                cmd2.Parameters.Add(New SqlClient.SqlParameter("@costID", SqlDbType.Int))
                cmd2.Parameters("@costID").Value = costID
                Dim objDA2 As New SqlClient.SqlDataAdapter(cmd2)
                Dim dtFiles As New DataTable : objDA2.Fill(dtFiles)

                Me.dgFiles.DataSource = dtFiles

                ColHideDG(dgSpec)

                'сделать в загрузке общих параметров
                Me.txtPath1.Text = Module1.NonQuery1ScalarString("Select coalesce(path1,'') FROM costs WHERE costID=" & costID & "")
                Me.txtPath2.Text = Module1.NonQuery1ScalarString("Select coalesce(path2,'') FROM costs WHERE costID=" & costID & "")
                Me.txtPath3.Text = Module1.NonQuery1ScalarString("Select coalesce(path3,'') FROM costs WHERE costID=" & costID & "")


                Dim cmd3 As New SqlClient.SqlCommand

                cmd3.Connection = mcnnInt
                cmd3.CommandText = "sp_Order_Rout"
                cmd3.CommandType = CommandType.StoredProcedure
                cmd3.Parameters.Add(New SqlClient.SqlParameter("@costID", SqlDbType.Int))
                cmd3.Parameters("@costID").Value = costID

                Dim objDA3 As New SqlClient.SqlDataAdapter(cmd3)
                Dim dtRout As New DataTable : objDA3.Fill(dtRout)

                Me.dgOrderRout.DataSource = dtRout

            Catch excp As System.Exception
                MessageBox.Show("Загрузка файлов " & excp.Message, appName)
                Exit Sub
            End Try

        End If
    End Sub




    Private Sub ToolStripButton7_Click(sender As Object, e As EventArgs)
        modeMatForOper = 2

        costID = Me.dgTableData("costID", Me.dgTableData.CurrentRow.Index).Value
        operFromOrderID = Me.dgTableData("operOrder_ID", Me.dgTableData.CurrentRow.Index).Value()

        ModCallForm.CallForm("Списание материала на операцию", 41, 3)
    End Sub

    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs)
        Dim frmSelect As frmOrder

        Try
            frmSelect = New frmOrder
            costID = Me.dgTableData("costID", Me.dgTableData.CurrentRow.Index).Value()
            frmSelect.ShowDialog()
        Catch excp As System.Exception
            If costID = 0 Then
                MessageBox.Show("Заказ не выбран.", appName)
            Else
                MessageBox.Show("Переход к заказу невозможен.  " & CStr(costID), appName)
            End If

            Exit Sub
        End Try
    End Sub

    Private Sub ToolStripButton3_Click(sender As Object, e As EventArgs)
        Me.tscmbEmpl.Visible = True
        Me.tsbtnUpdate.Visible = True
    End Sub

    Private Sub ToolStripButton10_Click(sender As Object, e As EventArgs)
        If Me.dgTableData.RowCount = 0 Then
            MsgBox("Не выбрана задача", MsgBoxStyle.Critical, appName)
        Else
            Dim strMsg$ = "Переназначить задачу - " + Me.dgTableData("Описание", Me.dgTableData.SelectedRows.Item(0).Index).Value() + "?"

            If MessageBox.Show(strMsg, appName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then

                Module1.NonQuery1("UPDATE Tasks SET empID_executor=" & Me.tscmbEmpl.SelectedItem(0) & " WHERE ID='" & Me.dgTableData("ID", Me.dgTableData.CurrentRow.Index).Value() & "'")

                LoadMeTasks(1)

                Me.tscmbEmpl.Visible = False
                Me.tsbtnUpdate.Visible = False
            End If
        End If
    End Sub

    Private Sub ToolStripButton4_Click(sender As Object, e As EventArgs) Handles ToolStripButton4.Click
        LoadMeTasks(3)
    End Sub

    Private Sub ToolStripButton5_Click(sender As Object, e As EventArgs) Handles ToolStripButton5.Click
        LoadMeTasks(2)
    End Sub

    Private Sub ToolStripButton11_Click(sender As Object, e As EventArgs) Handles ToolStripButton11.Click
        LoadMeTasks(1)
    End Sub

    Private Sub tsbtnStopTask_Click(sender As Object, e As EventArgs)
        If Me.dgTableData("statusID", Me.dgTableData.CurrentRow.Index).Value() = 2 Then
            Dim strReason$ = InputBox("Причина:", "Приостановка задачи", "")

            If Len(strReason) = 0 Then
                Exit Sub
            Else
                Dim desc$ = Module1.NonQuery1ScalarString("SELECT coalesce(description, '') FROM Tasks WHERE empID_executor=" & emplID & " AND statusID=3  ") + ", Приостановлен, сотр.- " & CStr(emplID) + ", " & strReason & ")"
                Dim strSQL$ = "UPDATE Tasks SET dateFinish='" & Format(Now().Date, "s") & "', empID_executor=" & emplID & ",statusID=3, description='" & desc & "', duration=" & 0 & " WHERE ID=" & Me.dgTableData("ID", Me.dgTableData.CurrentRow.Index).Value & ""

                Module1.NonQuery1(strSQL)

                LoadMeTasks(1)

                Me.Timer1.Enabled = False
                Me.dgTableData.Enabled = True
            End If
        Else
            MsgBox("Для остановки выполнения задачу необходимо взять в работу.", MsgBoxStyle.Critical, appName)
        End If
    End Sub

    Private Sub tsbtnEndTask_Click(sender As Object, e As EventArgs)
        Dim strMsg$ = "Завершить задачу - " + Me.dgTableData("Описание", Me.dgTableData.CurrentRow.Index).Value() + "?"

        '  MsgBox(CStr(Me.dgTableData("statusID", Me.dgTableData.CurrentRow.Index).Value()))

        If Me.dgTableData("statusID", Me.dgTableData.CurrentRow.Index).Value() = 2 Then
            If MessageBox.Show(strMsg, appName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
              
                Dim strSQL$ = "UPDATE Tasks SET dateFinish='" & Now() & "',empID_executor=" & emplID & ",statusID=4, duration=0 WHERE ID=" & Me.dgTableData("ID", Me.dgTableData.CurrentRow.Index).Value & ""

                Module1.NonQuery1(strSQL)

                If Me.dgTableData("matForOper", Me.dgTableData.CurrentRow.Index).Value = True Then 'Module1.NonQuery1ScalarBool("SELECT matForOper FROM tech_Operations WHERE ID = " & Me.dgTableData("operOrder_ID", Me.dgTableData.CurrentRow.Index).Value & " ") = 1 Then

                    If Me.dgSpec.RowCount = 0 Then
                        MsgBox("Для завершения задачи необходимо списать материал.", MsgBoxStyle.Critical, appName)
                        modeMatForOper = 2
                        costID = Me.dgTableData("costID", Me.dgTableData.CurrentRow.Index).Value
                        operFromOrderID = Me.dgTableData("operOrder_ID", Me.dgTableData.CurrentRow.Index).Value()

                        ModCallForm.CallForm("Списание материала на операцию", 41, 3)

                    End If
                End If

                Me.dgTableData.Enabled = True
                LoadMeTasks(1)
            End If
        Else
            MsgBox("Для завершения выполнения задача должна находиться в работе.", MsgBoxStyle.Critical, appName)
        End If
    End Sub

    Private Sub tsbtnExit_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Private Sub cmbDepartment_SelectedValueChanged(sender As Object, e As EventArgs) Handles cmbDepartment.SelectedValueChanged
        Dim cmd1 As New SqlClient.SqlCommand

        cmd1.Connection = mcnnInt
        cmd1.CommandText = "[sp_FilterExecutorDep]"
        cmd1.CommandType = CommandType.StoredProcedure
        cmd1.Parameters.Add(New SqlClient.SqlParameter("@depID", SqlDbType.Int))
        cmd1.Parameters("@depID").Value = Me.cmbDepartment.SelectedItem(0)

        Dim odaDesignerFind As New SqlClient.SqlDataAdapter(cmd1)
        Dim dtDesigner As New DataTable : odaDesignerFind.Fill(dtDesigner)

        Me.cmbEmplRout.DataSource = dtDesigner
        Me.cmbEmplRout.DisplayMember = "emplLastName"
        Me.cmbEmplRout.ValueMember = "emplID"
    End Sub

    Private Sub tsbtnRoutApply_Click(sender As Object, e As EventArgs) Handles tsbtnRoutApply.Click
        If Me.txtPurposeRout.Text = Nothing Then
            MsgBox("Поле описание должно быть заполнено", MsgBoxStyle.Critical, appName)
        Else
            Module1.NonQuery1("UPDATE Costs SET emplDesignerID=" & Me.cmbEmplRout.SelectedItem(0) & " WHERE costID=" & costID & "")
            Module1.NonQuery1("INSERT INTO OrderRout (empl_ID,next_empl_ID,description,costID) VALUES (" & emplID & "," & Me.cmbEmplRout.SelectedItem(0) & ",'" & Me.txtPurposeRout.Text & "'," & costID & ")")


            '  LoadOrderRout() 'загрузка маршрута заказа

            Me.tsbtnRoutApply.Checked = True
        End If
    End Sub

    Dim destinationPath As String ' Путь источника и назначения
    Dim sourcePath As String
    Dim flagOpenFile As Boolean 'определяет режим работы ворк

    Private Sub tsbtnOpenFile_Click(sender As Object, e As EventArgs) Handles tsbtnOpenFile.Click
        Dim file As String

        file = Me.dgFiles("link", Me.dgFiles.CurrentRow.Index).Value 'dgFiles.Rows(Me.dgFiles.SelectedRows.Item(0).Index)("link").ToString

        If file.StartsWith("http") Then
            Process.Start(file)
            Exit Sub
        End If

        Dim ext$ = Trim(Me.dgFiles("Расширение", Me.dgFiles.SelectedRows.Item(0).Index).Value().ToString)

        Try
            Me.Enabled = False

            For n As Integer = 0 To Me.dgFiles.SelectedRows.Count - 1
                sourcePath = Me.dgFiles("link", Me.dgFiles.CurrentRow.Index).Value ' dsFiles.Tables("Files").Rows(Me.dgFiles.SelectedRows.Item(n).Index)("link").ToString
                destinationPath = paramLocalTempPath + Path.GetFileName(sourcePath)
                ' MsgBox("Открываем " + paramLocalTempPath + Path.GetFileName(sourcePath))
                flagOpenFile = True
                'операция выполняется в ФОНЕ!!!
                Me.BackgroundWorker1.RunWorkerAsync(New Object() {sourcePath, destinationPath})
            Next
            Me.Enabled = True
        Catch ex As System.Exception
            MsgBox("Ошибка при открытии файла. " & ex.Message, MsgBoxStyle.Critical, appName)
            Exit Sub
        End Try
    End Sub

End Class