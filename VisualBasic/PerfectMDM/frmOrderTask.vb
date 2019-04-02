Public Class frmOrderTask
    Private Sub OrderTask_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Text = "Новая задача к заказу - " + Module1.NonQuery1ScalarString("SELECT nomerVN from costs where costID = " & costID & "")

        Try
            Dim odaDepartment As New SqlClient.SqlDataAdapter("SELECT ID, Name FROM Departments order by name", mcnnInt)
            Dim dtDepartments As New DataTable : odaDepartment.Fill(dtDepartments)

            Me.cmbDepartment.DataSource = dtDepartments 'Связать данные со списком
            Me.cmbDepartment.DisplayMember = "Name"
            Me.cmbDepartment.ValueMember = "ID"
            Me.cmbDepartment.SelectedIndex = -1

            Dim odaServListH As New SqlClient.SqlDataAdapter("SELECT ID, name  FROM tech_Operations order by name", mcnnInt)
            Dim dtServListH As New DataTable : odaServListH.Fill(dtServListH)

            Me.lstTechOperations.DataSource = dtServListH  ' Связать данные со списком
            Me.lstTechOperations.DisplayMember = "name"
            Me.lstTechOperations.ValueMember = "ID"
        Catch oexpData As System.Exception
            MsgBox(oexpData.Message, MsgBoxStyle.Critical, appName)
        End Try
    End Sub

    Private Sub lstTechOperations_MouseDoubleClick(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles lstTechOperations.MouseDoubleClick
        If Me.txtBody.Text = Nothing Then
            Me.txtBody.Text = Me.lstTechOperations.Text
        Else
            Me.txtBody.Text += Chr(13) + Me.lstTechOperations.Text
        End If
    End Sub

    Private Sub cmbDepartment_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cmbDepartment.SelectedIndexChanged
        'Dim objDA As SqlClient.SqlDataAdapter
        'Dim cmd As New SqlClient.SqlCommand

        'cmd.Connection = mcnnInt
        'cmd.CommandText = "[sp_Task_Executors]"
        'cmd.CommandType = CommandType.StoredProcedure

        'cmd.Parameters.Add(New SqlClient.SqlParameter("@depID", SqlDbType.Int))
        'cmd.Parameters("@depID").Value = Me.cmbDepartment.SelectedItem(0)

        'cmd.Parameters.Add(New SqlClient.SqlParameter("@emplID", SqlDbType.Int))
        'cmd.Parameters("@emplID").Value = emplID

        'objDA = New SqlClient.SqlDataAdapter(cmd)

        'Dim dtExecutors As New DataTable
        'objDA.Fill(dtExecutors)

        'Me.cmbExecutor.DataSource = dtExecutors
        'Me.cmbExecutor.DisplayMember = "emplLastName"
        'Me.cmbExecutor.ValueMember = "emplID"

        If Me.cmbDepartment.SelectedIndex = -1 Then
            Me.cmbExecutor.SelectedIndex = -1
            Me.cmbExecutor.Enabled = False
            Exit Sub
        Else
            Try
                Dim odaEmplRout As New SqlClient.SqlDataAdapter("SELECT emplID, emplLastName FROM Employees WHERE dismissed <> 1 AND departmentID = " & Me.cmbDepartment.SelectedItem(0) & " order by emplLastName", mcnnInt)
                Dim dtEmplRout As New DataTable : odaEmplRout.Fill(dtEmplRout)

                Me.cmbExecutor.DataSource = dtEmplRout
                Me.cmbExecutor.DisplayMember = "emplLastName"
                Me.cmbExecutor.ValueMember = "emplID"
                Me.cmbExecutor.Enabled = True
            Catch ex As System.Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical, appName)
            End Try
        End If
    End Sub

    Private Sub tsbtnOK_Click(sender As System.Object, e As System.EventArgs) Handles tsbtnOK.Click
        If Me.cmbDepartment.SelectedIndex = -1 Or Me.cmbExecutor.SelectedIndex = -1 Then
            MsgBox("Не выбран исполнитель.") : Me.cmbDepartment.Focus() : Exit Sub
        End If

        Dim modaIndiv As New SqlClient.SqlDataAdapter("SELECT TOP 1 * FROM Tasks ", mcnnInt)
        Dim mdsIndiv As New DataSet : modaIndiv.Fill(mdsIndiv, "Tasks")
        Dim mdrIndiv As DataRow : mdrIndiv = mdsIndiv.Tables("Tasks").NewRow
        mdrIndiv.BeginEdit()

        Try 'запись в таблицу
            mdrIndiv("empID_autor") = emplID
            mdrIndiv("taskContent") = Me.txtBody.Text
            mdrIndiv("data_Statement") = Now()
            mdrIndiv("data_Plan") = Me.dtpDate.Value
            mdrIndiv("empID_executor") = Me.cmbExecutor.SelectedItem(0)
            mdrIndiv("orderID") = costID
            mdrIndiv("statusID") = 1
            mdrIndiv("KA_ID") = custID
            mdrIndiv("priority") = 1

            mdrIndiv.EndEdit() 'Завершить редактировать строку данных
            mdsIndiv.Tables("Tasks").Rows.Add(mdrIndiv)

            Dim ocbIndiv As SqlClient.SqlCommandBuilder

            ocbIndiv = New SqlClient.SqlCommandBuilder(modaIndiv)
            modaIndiv.InsertCommand = ocbIndiv.GetInsertCommand
            modaIndiv.Update(mdsIndiv, "Tasks")
            mdsIndiv.Tables("Tasks").AcceptChanges()
            modaIndiv.InsertCommand.Connection.Close()
        Catch oexp As System.Exception
            MsgBox("error" & oexp.Message, MsgBoxStyle.Critical, appName)
        End Try

        Me.Close()
    End Sub

    Private Sub tsbtnExit_Click(sender As System.Object, e As System.EventArgs) Handles tsbtnExit.Click
        Me.Close()
    End Sub
End Class