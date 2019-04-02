Public Class frmTasks
    Dim forexcelcaption As String

    Private Sub tsbtnAddTask_Click(sender As System.Object, e As System.EventArgs) Handles tsbtnAddTask.Click
        createTask = True

        Dim frmSelect As New frmTaskCard

        frmSelect.ShowDialog()
    End Sub

#Region " Загрузка формы "
    Private Sub frmTasks_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'Загружаем список сотрудников
        Dim odaDesignerFind As SqlClient.SqlDataAdapter
        Dim dtDesigner As DataTable = New DataTable

        odaDesignerFind = New SqlClient.SqlDataAdapter("SELECT emplID, emplLastName  FROM Employees WHERE dismissed <> 1 ", mcnnInt)
        odaDesignerFind.Fill(dtDesigner)

        Dim viewEmpl As New DataView(dtDesigner) : viewEmpl.Sort = "emplLastName"

        Me.cmbExecutor.DataSource = viewEmpl
        Me.cmbExecutor.DisplayMember = "emplLastName"
        Me.cmbExecutor.ValueMember = "emplID"
        Me.cmbExecutor.SelectedValue = emplID

        Dim odaAuthor As SqlClient.SqlDataAdapter
        Dim dtAuthor As DataTable = New DataTable

        odaAuthor = New SqlClient.SqlDataAdapter("SELECT emplID, emplLastName  FROM Employees WHERE dismissed <> 1 ", mcnnInt)
        odaAuthor.Fill(dtAuthor)

        Dim viewAuthor As New DataView(dtAuthor) : viewAuthor.Sort = "emplLastName"

        Me.cmbAuthor.DataSource = viewAuthor
        Me.cmbAuthor.DisplayMember = "emplLastName"
        Me.cmbAuthor.ValueMember = "emplID"
        Me.DateTimePicker1.Value = Now().Date
        Me.DateTimePicker2.Value = Now().Date


        Dim odaStatus As SqlClient.SqlDataAdapter
        Dim dtStatus As DataTable = New DataTable

        odaStatus = New SqlClient.SqlDataAdapter("SELECT ID, Name  FROM TaskStatuses", mcnnInt)
        odaStatus.Fill(dtStatus)

        Me.cmbStatus.DataSource = dtStatus
        Me.cmbStatus.DisplayMember = "Name"
        Me.cmbStatus.ValueMember = "ID"

    End Sub
#End Region

    Private Sub btnNow_Click(sender As System.Object, e As System.EventArgs) Handles btnNow.Click
        Me.DateTimePicker1.Value = Now().Date
        Me.DateTimePicker2.Value = Now().Date

        If Me.chkDataPeriod.Checked = True Then
            Me.chkDataPeriod.Checked = False
            Me.chkDataPeriod.Checked = True
        End If

        LoadTasks()
    End Sub

    Private Sub btnWeek_Click(sender As System.Object, e As System.EventArgs) Handles btnWeek.Click
        Me.DateTimePicker1.Value = Now().Date
        Me.DateTimePicker2.Value = Now().Date.AddDays(7)

        If Me.chkDataPeriod.Checked = True Then
            Me.chkDataPeriod.Checked = False
            Me.chkDataPeriod.Checked = True
        End If

        LoadTasks()
    End Sub

    Private Sub btnAll_Click(sender As System.Object, e As System.EventArgs) Handles btnAll.Click
        Me.chkDataPeriod.Checked = False
        Me.chkStatus.Checked = False
    End Sub

    Private Sub LoadTasks()
        Dim objDA As SqlClient.SqlDataAdapter
        Dim cmd As New SqlClient.SqlCommand
        Dim dtTasks As New DataTable

        cmd.Connection = mcnnInt
        cmd.CommandText = "[sp_Tasks]"
        cmd.CommandType = CommandType.StoredProcedure

        'Описываем параметры
        If Me.chkDataPeriod.Checked = True Then
            cmd.Parameters.Add(New SqlClient.SqlParameter("@Date1", SqlDbType.Date))
            cmd.Parameters("@Date1").Value = Me.DateTimePicker1.Value.Date 'Format(Me.DateTimePicker1.Value.Date, "s")

            cmd.Parameters.Add(New SqlClient.SqlParameter("@Date2", SqlDbType.Date))
            cmd.Parameters("@Date2").Value = Me.DateTimePicker2.Value.Date 'Format(Me.DateTimePicker2.Value.Date, "s")
        Else
            ' forexcelcaption = "Заказы за весь период"
        End If

        If Me.chkDateCreate.Checked = True Then
            cmd.Parameters.Add(New SqlClient.SqlParameter("@DateCreate1", SqlDbType.Date))
            cmd.Parameters("@DateCreate1").Value = Me.dtpDateCreate1.Value.Date 'Format(Me.dtpDateCreate1.Value.Date, "s")

            cmd.Parameters.Add(New SqlClient.SqlParameter("@DateCreate2", SqlDbType.Date))
            cmd.Parameters("@DateCreate2").Value = Me.dtpDateCreate2.Value.Date 'Format(Me.dtpDateCreate2.Value.Date, "s")
        Else
            ' forexcelcaption = "Заказы за весь период"
        End If

        If Me.chkStatus.Checked = True Then
            cmd.Parameters.Add(New SqlClient.SqlParameter("@status", SqlDbType.NText))
            cmd.Parameters("@status").Value = Me.cmbStatus.SelectedItem(0).ToString
        End If

        If Me.chkExecutor.Checked = True Then
            cmd.Parameters.Add(New SqlClient.SqlParameter("@executor", SqlDbType.NText))
            cmd.Parameters("@executor").Value = Me.cmbExecutor.SelectedItem(0).ToString
        End If

        If Me.chkCustForSearh.Checked = True Then
            cmd.Parameters.Add(New SqlClient.SqlParameter("@customer", SqlDbType.NText))
            cmd.Parameters("@customer").Value = Me.cmbCustForSearh.SelectedItem(0).ToString
        End If

        If Me.chkAuthor.Checked = True Then
            cmd.Parameters.Add(New SqlClient.SqlParameter("@author", SqlDbType.NText))
            cmd.Parameters("@author").Value = Me.cmbAuthor.SelectedItem(0).ToString
        End If

        objDA = New SqlClient.SqlDataAdapter(cmd)
        objDA.Fill(dtTasks)

        Me.dgTableData.DataSource = dtTasks
        Me.dgTableData.ClearSelection()

        For n As Integer = 0 To Me.dgTableData.ColumnCount - 1
            If Me.dgTableData.Columns(n).Name = "ID" Then
                Me.dgTableData.Columns("ID").Visible = False
            End If

            If Me.dgTableData.Columns(n).Name = "costID" Then
                Me.dgTableData.Columns("costID").Visible = False
            End If
        Next
    End Sub

#Region " Переход к задаче "
    Private Sub dgTableData_CellDoubleClick(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgTableData.CellDoubleClick
        TaskGo1()
    End Sub

    Private Sub TaskGo1()
        createTask = False

        Try
            taskID = Me.dgTableData(0, Me.dgTableData.CurrentRow.Index).Value()

            Dim frmSelect As New frmTaskCard

            frmSelect.ShowDialog()
        Catch ex As System.Exception
            MessageBox.Show(ex.Message, appName) : Exit Sub
        End Try
    End Sub
#End Region

    Private Sub chkExecutor_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chkExecutor.CheckedChanged
        Me.cmbExecutor.Enabled = sender.checked
    End Sub

    Private Sub chkCustForSearh_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkCustForSearh.CheckedChanged
        Me.txtCustForSearh.Visible = sender.checked
        Me.cmbCustForSearh.Visible = sender.checked
    End Sub

    Private Sub txtCustForSearh_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCustForSearh.TextChanged
        LoadCustomers(2, Me.txtCustForSearh.Text)
    End Sub

    Private Sub LoadCustomers(ByVal selectSerh As Integer, ByVal strFind As String)
        If strFind = """" Or strFind = "'" Then
            Exit Sub
        End If

        Dim odaPartList As SqlClient.SqlDataAdapter
        Dim dtPartList As New DataTable

        Try
            odaPartList = New SqlClient.SqlDataAdapter("SELECT ID, Name FROM KAgents WHERE Name LIKE '%" & strFind & "%'", mcnnInt)
            dtPartList.Clear()
            odaPartList.Fill(dtPartList)

            Dim viewCust As New DataView(dtPartList) : viewCust.Sort = "Name"

            Select Case selectSerh  'Связать данные со списком

                Case Is = 2 'загружаем заказчиков в поле поиска
                    Me.cmbCustForSearh.DataSource = viewCust
                    Me.cmbCustForSearh.DisplayMember = "Name"
                    Me.cmbCustForSearh.ValueMember = "ID"
            End Select
        Catch oexpData As System.Exception
            MsgBox(oexpData.Message, MsgBoxStyle.Critical, appName)
        End Try
    End Sub

    Private Sub chkStatus_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkStatus.CheckedChanged
        Me.cmbStatus.Enabled = sender.checked
    End Sub

    Private Sub chkAuthor_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkAuthor.CheckedChanged
        Me.cmbAuthor.Enabled = sender.checked
    End Sub

    Private Sub tsbtnAllTasks_Click(sender As System.Object, e As System.EventArgs) Handles tsbtnAllTasks.Click
        LoadTasks()
    End Sub

    Private Sub ВыполненаToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ВыполненаToolStripMenuItem.Click

        Dim strSQL$ = "UPDATE Tasks SET statusID = 4, dateFinish=getdate() WHERE ID=" & Me.dgTableData(0, Me.dgTableData.CurrentRow.Index).Value() & ""

        Module1.NonQuery1(strSQL)

        LoadTasks()
    End Sub

    Private Sub ПовторЗадачиToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ПовторЗадачиToolStripMenuItem.Click
        MsgBox("В разработке")
    End Sub

    Private Sub dgTableData_CurrentCellChanged(sender As Object, e As System.EventArgs) Handles dgTableData.CurrentCellChanged
        If Me.dgTableData.SelectedRows.Count > 0 Then
            Me.txtTaskContent.Text = Me.dgTableData("Описание", Me.dgTableData.SelectedRows.Item(0).Index()).Value()
        End If
    End Sub

    Private Sub tsbtnProsrok_Click(sender As System.Object, e As System.EventArgs) Handles tsbtnProsrok.Click

        Dim objDA As SqlClient.SqlDataAdapter
        Dim cmd As New SqlClient.SqlCommand
        Dim dtTasks As New DataTable

        cmd.Connection = mcnnInt
        cmd.CommandText = "[sp_TasksProsrok]"
        cmd.CommandType = CommandType.StoredProcedure

        'Описываем параметры
        If Me.chkExecutor.Checked = True Then
            cmd.Parameters.Add(New SqlClient.SqlParameter("@executor", SqlDbType.NText))
            cmd.Parameters("@executor").Value = Me.cmbExecutor.SelectedItem(0).ToString
        End If

        objDA = New SqlClient.SqlDataAdapter(cmd)
        objDA.Fill(dtTasks)

        Me.dgTableData.DataSource = dtTasks
        Me.dgTableData.ClearSelection()

        For n As Integer = 0 To Me.dgTableData.ColumnCount - 1
            If Me.dgTableData.Columns(n).Name = "ID" Then
                Me.dgTableData.Columns("ID").Visible = False
            End If
        Next
    End Sub

    Private Sub tsbtnMyTasks_Click(sender As System.Object, e As System.EventArgs) Handles tsbtnMyTasks.Click
        Me.cmbExecutor.SelectedItem(0) = emplID
        Me.chkExecutor.Checked = True

        LoadTasks()
    End Sub

    Private Sub ПерейтиКЗаказуToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ПерейтиКЗаказуToolStripMenuItem.Click
        Try
            costID = Me.dgTableData("costID", Me.dgTableData.CurrentRow.Index).Value()

            If costID = 0 Then
                costID = Nothing
                MsgBox("Эта задача не имеет связи с заказом.", MsgBoxStyle.Critical, appName)
                Exit Sub
            End If

        Catch ex As System.Exception
            MsgBox("Эта задача не имеет связи с заказом.", MsgBoxStyle.Critical, appName)
            Exit Sub
        End Try

        ModCallForm.CallForm("", 11, 3)
    End Sub
End Class