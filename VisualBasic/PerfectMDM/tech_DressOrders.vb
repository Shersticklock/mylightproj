Imports System.IO

Public Class tech_DressOrders
    Dim dsDressTasks As New DT_DressTasks
    Dim dsTechCard As New DS_DressOrder


    Private Sub tech_DressOrders_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        Me.dgTechOperFromOrder.ClearSelection()
    End Sub

    Private Sub tech_DressOrders_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        Dim cmd As New SqlClient.SqlCommand
        cmd.Connection = mcnnInt
        cmd.CommandText = "[sp_FilterExecutorPlan]"
        cmd.CommandType = CommandType.StoredProcedure
        Dim odaMan As New SqlClient.SqlDataAdapter(cmd)
        Dim dtMan As New DataTable : odaMan.Fill(dtMan)
        Me.cmbDirDep.DataSource = dtMan
        Me.cmbDirDep.DisplayMember = "emplLastName"
        Me.cmbDirDep.ValueMember = "emplID"

        Dim cmd1 As New SqlClient.SqlCommand
        cmd1.Connection = mcnnInt
        cmd1.CommandText = "[sp_FilterDepartmentPro]"
        cmd1.CommandType = CommandType.StoredProcedure
        Dim odaDep As New SqlClient.SqlDataAdapter(cmd1)
        Dim dtDep As New DataTable : odaDep.Fill(dtDep)
        Me.cmbParamTechOper.DataSource = dtDep
        Me.cmbParamTechOper.DisplayMember = "Name"
        Me.cmbParamTechOper.ValueMember = "ID"


        Dim cmd2 As New SqlClient.SqlCommand
        cmd2.Connection = mcnnInt
        cmd2.CommandText = "[sp_FilterDepartmentPro]"
        cmd2.CommandType = CommandType.StoredProcedure
        Dim odaDep1 As New SqlClient.SqlDataAdapter(cmd2)
        Dim dtDep2 As New DataTable : odaDep1.Fill(dtDep2)
        Me.cmbDep.DataSource = dtDep2
        Me.cmbDep.DisplayMember = "Name"
        Me.cmbDep.ValueMember = "ID"
    End Sub

#Region " Загружаем спецификацию "
    Private Sub lstCosts_SelectedValueChanged(sender As Object, e As System.EventArgs) Handles lstCosts.SelectedValueChanged
        If Me.lstCosts.SelectedIndex <> -1 Then
            Try
                Dim cmd As New SqlClient.SqlCommand

                cmd.Connection = mcnnInt
                cmd.CommandText = "sp_Order_FillSpec"
                cmd.CommandType = CommandType.StoredProcedure

                cmd.Parameters.Add(New SqlClient.SqlParameter("@costID", SqlDbType.Int))
                cmd.Parameters("@costID").Value = Me.lstCosts.SelectedItem(0)

                Dim objDA As New SqlClient.SqlDataAdapter(cmd)
                Dim dtSpec As New DataTable : objDA.Fill(dtSpec)

                Me.dgSpec.DataSource = dtSpec

                Me.TextBox1.Text = Nothing

                ColHideDG(Me.dgSpec)

                RasxodMat()
            Catch excp As System.Exception
                MessageBox.Show("Спецификация-" + excp.Message, appName)
                Exit Sub
            End Try
        End If
    End Sub
#End Region

#Region " Расход материала "
    Private Sub RasxodMat()
        Try
            Dim cmd As New SqlClient.SqlCommand

            cmd.Connection = mcnnInt
            cmd.CommandText = "[sp_Sklad_DeliveryForOrder]"
            cmd.CommandType = CommandType.StoredProcedure

            cmd.Parameters.Add(New SqlClient.SqlParameter("@orderID", SqlDbType.Int))
            cmd.Parameters("@orderID").Value = Me.lstCosts.SelectedItem(0)

            Dim objDA As New SqlClient.SqlDataAdapter(cmd)
            Dim dtSklad As New DataTable : objDA.Fill(dtSklad)

            Me.dgMatExpens.DataSource = dtSklad

            ColHideDG(Me.dgMatExpens)
        Catch oexpData As System.SystemException
            MessageBox.Show("Расход материала: " & oexpData.Message, appName)
        End Try
    End Sub
#End Region

    Private Sub LoadAllOper(ordIDforspec)
        Try
            Me.TextBox1.Text += CStr(ordIDforspec) + ","

            Dim cmd As New SqlClient.SqlCommand

            cmd.Connection = mcnnInt
            cmd.CommandText = "sp_tech_DressOrders1"
            cmd.CommandType = CommandType.StoredProcedure
            'Описываем параметры
            cmd.Parameters.Add(New SqlClient.SqlParameter("@ordID", SqlDbType.Int))
            cmd.Parameters("@ordID").Value = ordIDforspec

            Dim objDA As New SqlClient.SqlDataAdapter(cmd)

            dsTechCard.Operations.Clear()
            objDA.Fill(dsTechCard, "Operations")

            Me.dgTechOperFromOrder.DataSource = dsTechCard.Operations
            Me.dgTechOperFromOrder.ClearSelection()

        Catch ex As System.Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, appName)
        End Try
    End Sub

    Private Sub dgAllOper_CellClick(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgTechOperFromOrder.CellClick
        ' LoadEquip(Me.dgAllOper("operID", Me.dgAllOper.CurrentRow.Index).Value())
    End Sub

    Private Sub ПечатьНарядЗаказаToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ПечатьНарядЗаказаToolStripMenuItem.Click
        PrintDressTasks()
    End Sub



#Region " РАСПЕЧАТКА Наряд-заказа "
    Private Sub PrintDressTasks()
        ''заполнить набор данных
        'Dim objDA As SqlClient.SqlDataAdapter
        'Dim cmd As New SqlClient.SqlCommand

        'cmd.Connection = mcnnInt
        'cmd.CommandText = "sp_DO_Task"
        'cmd.CommandType = CommandType.StoredProcedure
        'cmd.Parameters.Add(New SqlClient.SqlParameter("@costID", SqlDbType.Int))
        'cmd.Parameters("@costID").Value = Me.dgSpec("ordID", Me.dgSpec.CurrentRow.Index).Value
        'objDA = New SqlClient.SqlDataAdapter(cmd)


        'dsDressTasks.Tasks.Clear()
        'objDA.Fill(dsDressTasks, "Task")


        If dsDressTasks.Tasks.Rows.Count = 0 Then 'Or currentStatus = 1
            MessageBox.Show("С пустым наряд-заказом формирование документа невозможно", appName, MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Exit Sub
        Else
            Try
                'удаляем старый файл если он есть
                Dim strFileName As String = paramLocalTempPath & "DSDT.xml" 'Path.GetTempPath & "\DSTZ.xml"
                Dim rrr As New FileInfo(strFileName)

                rrr.Delete()
                'пишем содержимое датасета в XML
                'dsTZ.Tables("order").WriteXml(strFileName, XmlWriteMode.WriteSchema) 'не пишем таб файлы чтоб в случае файла большого объема не обрывалась связь по таймоуту
                'dsTZ.Tables("cost").WriteXml(strFileName, XmlWriteMode.)
                dsDressTasks.WriteXml(strFileName, XmlWriteMode.WriteSchema)

                frmDocPrint.InitReport(NonQueryScalarInt("SELECT ID FROM TypesDocument WHERE TZ=2")) ' ид документа наряд заказ

            Catch ex As System.Exception
                MessageBox.Show(ex.Message, appName)
                Exit Sub
            End Try
        End If
    End Sub
#End Region

    Private Sub btnToPlan_Click(sender As System.Object, e As System.EventArgs) Handles btnToPlan.Click
        If Me.cmbEmplExec.SelectedIndex = -1 Or Me.cmbParamTechOper.SelectedIndex = -1 Then
            MsgBox("Не выбран исполнитель или станок.", MsgBoxStyle.Critical, appName)
        
        Else
            If MessageBox.Show("Добавить в технологическую карту", appName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                Dim cmd As New SqlClient.SqlCommand

                Try
                    cmd.Connection = mcnnInt
                    cmd.CommandText = "sp_TechOperOrderInsF"
                    cmd.CommandType = CommandType.StoredProcedure
                    'Описываем параметры
                    cmd.Parameters.Add(New SqlClient.SqlParameter("@operID", SqlDbType.Int))
                    cmd.Parameters("@operID").Value = Me.cmbOper.SelectedItem(0)

                    cmd.Parameters.Add(New SqlClient.SqlParameter("@quantity", SqlDbType.Int))
                    cmd.Parameters("@quantity").Value = Me.nudQuantity.Value

                    cmd.Parameters.Add(New SqlClient.SqlParameter("@orderID", SqlDbType.Int))
                    cmd.Parameters("@orderID").Value = Me.dgSpec("ordID", Me.dgSpec.CurrentRow.Index).Value()

                    mcnnInt.Open()
                    cmd.ExecuteNonQuery()
                    mcnnInt.Close()

                    LoadAllOper(Me.dgSpec("ordID", Me.dgSpec.CurrentRow.Index).Value())
                Catch excp As System.Exception
                    MessageBox.Show(excp.Message, appName)
                    Exit Sub
                End Try

            End If
        End If

        'If Module1.NonQuery1ScalarBool("SELECT dayoff FROM Calendar WHERE date = " & Me.dtpStartTask.Value.Date & "") = 1 Then
        '    'If Me.CheckBox1.Checked = 1 Then
        '    '    MsgBox("Включена переработка. Стоимость операций будет умножена на полтора", MsgBoxStyle.Critical, appName)
        '    'Else
        '    '    MsgBox("Это выходной день. Включи переработку.", MsgBoxStyle.Critical, appName)
        '    '    Exit Sub
        '    'End If
        'End If

        ' MsgBox("Тест постановка в план", MsgBoxStyle.Information, appName)





        'Dim cost@ = Me.nudQuantity.Value

        ''If Me.CheckBox1.Checked = True Then
        ''    cost *= 1.5
        ''End If

        'Dim strSQL$ = "INSERT INTO tech_OperFromOrder (operID, cost, quantity, duration, orderID) "
        'strSQL &= "VALUES (" & Me.cmbOper.SelectedItem(0) & ", 0, " & Me.nudQuantity.Value & "," & 1 & "," & Me.dgSpec("ordID", Me.dgSpec.CurrentRow.Index).Value() & ")"

        'Module1.NonQuery1(strSQL)



        'Dim mdrIndiv As DataRow
        'Dim mdsIndiv As New DataSet
        'Dim modaIndiv As SqlClient.SqlDataAdapter

        'Try 'запись в таблицу
        '    modaIndiv = New SqlClient.SqlDataAdapter("SELECT TOP 1 * FROM Tasks ", mcnnInt)
        '    modaIndiv.Fill(mdsIndiv, "Tasks")
        '    mdrIndiv = mdsIndiv.Tables("Tasks").NewRow
        '    mdrIndiv.BeginEdit()

        '    mdrIndiv("empID_autor") = emplID
        '    mdrIndiv("taskContent") = Me.dgAllOper("Операция", Me.dgAllOper.CurrentRow.Index).Value
        '    mdrIndiv("data_Statement") = Me.dtpStartTask.Value.ToLongDateString  ' плановая дата старта задачи
        '    '   mdrIndiv("data_Plan") = Me.dtpStartTask.Value.AddHours(Me.nudDuration.Value)
        '    mdrIndiv("empID_executor") = Me.cmbEmplExec.SelectedItem(0)
        '    mdrIndiv("orderID") = Me.dgSpec("costID", Me.dgSpec.CurrentRow.Index).Value
        '    mdrIndiv("statusID") = 1
        '    mdrIndiv("priority") = 3
        '    mdrIndiv("operOrder_ID") = Me.dgAllOper("ID", Me.dgAllOper.CurrentRow.Index).Value
        '    mdrIndiv("equip_ID") = Me.cmbParamTechOper.SelectedItem(0)

        '    mdrIndiv.EndEdit()         'Завершить редактировать строку данных
        '    mdsIndiv.Tables("Tasks").Rows.Add(mdrIndiv)

        '    Dim ocbIndiv As SqlClient.SqlCommandBuilder

        '    ocbIndiv = New SqlClient.SqlCommandBuilder(modaIndiv)
        '    modaIndiv.InsertCommand = ocbIndiv.GetInsertCommand
        '    modaIndiv.Update(mdsIndiv, "Tasks")
        '    mdsIndiv.Tables("Tasks").AcceptChanges()
        '    modaIndiv.InsertCommand.Connection.Close()
        'Catch oexp As System.Exception
        '    MsgBox("error" & oexp.Message, MsgBoxStyle.Critical, appName)
        'End Try
        ' Me.dgSpec.Rows(e.RowIndex).DefaultCellStyle.BackColor = Color.LightGreen

    End Sub

    Private Sub dtpStartTask_ValueChanged(sender As System.Object, e As System.EventArgs)
        ' MsgBox("Проверяем выходной это день или нет. Если выходной предлагаем включить переработку. Далее смотрим загруз машины и сотрудника")
    End Sub

    Private Sub КалькуляцияМатериалаToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles КалькуляцияМатериалаToolStripMenuItem.Click
        modeMatForOper = 1
        operFromOrderID = Me.dgTechOperFromOrder("ID", Me.dgTechOperFromOrder.CurrentRow.Index).Value()

        '   ModCallForm.CallForm("Списание материала на операцию", 41, 3)

        Dim form As New frmMatForOper

        ' form.MatFromSpec(Me.lstCosts.SelectedItem(0))
        costID = Me.lstCosts.SelectedItem(0)

        form.btnExecMatForOper.Text = "Калькуляция материала"

        'If idConfig = 76572312 Then
        '    Form.tscmbModeSpisania.Visible = True
        'End If

        form.Text = "Калькуляция материала на операцию"
        form.ShowDialog()
    End Sub

    Private Sub ColHideDG(NameGrid As Object)
        For Each col As Object In NameGrid.Columns
            If col.name = "matID" Or col.name = "matCatID" Or col.name = "ID" Or col.name = "typeID" Or col.name = "unitID" Then
                col.visible = False
            End If
        Next

        NameGrid.DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomRight
        NameGrid.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomLeft
        NameGrid.ClearSelection()
    End Sub


    Private Sub cmbParamTechOper_SelectedValueChanged(sender As Object, e As EventArgs) Handles cmbParamTechOper.SelectedValueChanged
        Try
            Dim cmd As New SqlClient.SqlCommand

            cmd.Connection = mcnnInt
            cmd.CommandText = "[sp_FilterExecutorDep]"
            cmd.CommandType = CommandType.StoredProcedure

            cmd.Parameters.Add(New SqlClient.SqlParameter("@depID", SqlDbType.Int))
            cmd.Parameters("@depID").Value = Me.cmbParamTechOper.SelectedItem(0)

            Dim odaMan As New SqlClient.SqlDataAdapter(cmd)
            Dim dtMan As New DataTable : odaMan.Fill(dtMan)

            Me.cmbEmplExec.DataSource = dtMan
            Me.cmbEmplExec.DisplayMember = "emplLastName"
            Me.cmbEmplExec.ValueMember = "emplID"

            Dim odaOper As New SqlClient.SqlDataAdapter("SELECT ID, Name FROM tech_Operations WHERE ParamTechOperID = " & Me.cmbParamTechOper.SelectedItem(0) & " order by name", mcnnInt)
            Dim dtOper As New DataTable : odaOper.Fill(dtOper)

            Me.cmbOper.DataSource = dtOper
            Me.cmbOper.DisplayMember = "Name"
            Me.cmbOper.ValueMember = "ID"

        Catch ex As System.Exception
            MessageBox.Show(ex.Message, appName)
            Exit Sub
        End Try
    End Sub

    Private Sub СписатьМатериалToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles СписатьМатериалToolStripMenuItem.Click
        modeMatForOper = 2
        operFromOrderID = Me.dgTechOperFromOrder("ID", Me.dgTechOperFromOrder.CurrentRow.Index).Value()
        'costID = Me.lstCosts.SelectedItem(0)

        'ModCallForm.CallForm("Списание материала на операцию", 41, 3)

        '     costID = Me.dgTableData("costID", Me.dgTableData.CurrentRow.Index).Value
        '        operFromOrderID = Me.dgTableData("operOrder_ID", Me.dgTableData.CurrentRow.Index).Value()

        '  ModCallForm.CallForm("Списание материала на операцию", 41, 3)

        Dim form As New frmMatForOper

        costID = Me.lstCosts.SelectedItem(0)

        form.MatFromSpec()

        form.btnExecMatForOper.Text = "Списать материал"

        '    Form.tscmbModeSpisania.Visible = True

        form.Text = "Списание материала на операцию в заказе № " + Module1.NonQuery1ScalarString("SELECT nomerVN FROM Costs WHERE costID=" & costID & "")

        form.ShowDialog()
    End Sub

    Private Sub dgSpec_SelectionChanged(sender As Object, e As EventArgs) Handles dgSpec.SelectionChanged
        LoadAllOper(Me.dgSpec("ordID", Me.dgSpec.CurrentRow.Index).Value())
    End Sub

    Private Sub dgAllOper_SelectionChanged(sender As Object, e As EventArgs) Handles dgTechOperFromOrder.SelectionChanged
        Dim cmd As New SqlClient.SqlCommand

        cmd.Connection = mcnnInt
        cmd.CommandText = "[sp_Sklad_DeliveryForOper]"
        cmd.CommandType = CommandType.StoredProcedure

        cmd.Parameters.Add(New SqlClient.SqlParameter("@operID", SqlDbType.Int))
        cmd.Parameters("@operID").Value = Me.dgTechOperFromOrder("ID", Me.dgTechOperFromOrder.CurrentRow.Index).Value()

        Dim objDA As New SqlClient.SqlDataAdapter(cmd)

        Dim dtMatList As New DataTable : objDA.Fill(dtMatList)
        Me.dgMatExpens.DataSource = dtMatList  'Связать данные со списком


        Dim cmd1 As New SqlClient.SqlCommand

        cmd1.Connection = mcnnInt
        cmd1.CommandText = "[sp_Sklad_CalcForOper]"
        cmd1.CommandType = CommandType.StoredProcedure

        cmd1.Parameters.Add(New SqlClient.SqlParameter("@operID", SqlDbType.Int))
        cmd1.Parameters("@operID").Value = Me.dgTechOperFromOrder("ID", Me.dgTechOperFromOrder.CurrentRow.Index).Value()

        Dim objDA1 As New SqlClient.SqlDataAdapter(cmd1)

        Dim dtMatList1 As New DataTable : objDA1.Fill(dtMatList1)
        Me.dgMatForOper.DataSource = dtMatList1  'Связать данные со списком

        '  ColHideDG(dgMatForOper)


        Dim cmd2 As New SqlClient.SqlCommand

        cmd2.Connection = mcnnInt
        cmd2.CommandText = "[sp_TechTasks]"
        cmd2.CommandType = CommandType.StoredProcedure

        cmd2.Parameters.Add(New SqlClient.SqlParameter("@operID", SqlDbType.Int))
        cmd2.Parameters("@operID").Value = Me.dgTechOperFromOrder("ID", Me.dgTechOperFromOrder.CurrentRow.Index).Value()

        Dim objDA2 As New SqlClient.SqlDataAdapter(cmd)

        dsDressTasks.Tasks.Clear()
        objDA2.Fill(dsDressTasks, "Tasks")

        Me.dgTechTask.DataSource = dsDressTasks.Tasks  'Связать данные со списком
    End Sub

    Private Sub ПерейтиКЗаказуToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ПерейтиКЗаказуToolStripMenuItem.Click
        costID = Me.lstCosts.SelectedItem(0)

        ModCallForm.CallForm("", 11, 3)
    End Sub

    Private Sub cmbMode_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbMode.SelectedIndexChanged
        ' если хотя бы на одну операцию нет калькуляции материала и или на одну из задач исполнителем сам технолог те она никому не поручена
        ' тогда в планровании, а если оба условия выполнены то производство
        If Me.cmbDirDep.SelectedIndex <> -1 Then
            Dim cmd As New SqlClient.SqlCommand

            cmd.Connection = mcnnInt

            Select Case Me.cmbMode.SelectedIndex
                Case Is = -1
                    Exit Sub
                Case Is = 0
                    'Загружаем список 
                    'сделать что если заказ вып в неск депратаментах нач всех где он вып должны его видеть
                    cmd.CommandText = "[sp_techOrderPlanDep]"
                Case Is = 1
                    cmd.CommandText = "[sp_techOrderWorkDep]"
                Case Is = 2
                    cmd.CommandText = "[sp_techOrderAllDep]"
                Case Is = 3
                    cmd.CommandText = "[sp_techOrderTempGot]"
                Case Is = 4
                    cmd.CommandText = "[sp_techOrderTempVydan]"
            End Select

            cmd.CommandType = CommandType.StoredProcedure

            cmd.Parameters.Add(New SqlClient.SqlParameter("@emplID", SqlDbType.Int))
            cmd.Parameters("@emplID").Value = Me.cmbDirDep.SelectedItem(0)

            Dim odaMan As New SqlClient.SqlDataAdapter(cmd)
            Dim dtCosts As New DataTable : odaMan.Fill(dtCosts)

            Me.lstCosts.DataSource = dtCosts
            Me.lstCosts.DisplayMember = "nomerVN"
            Me.lstCosts.ValueMember = "costID"
        End If
    End Sub

    Private Sub nudQuantity_GotFocus(sender As Object, e As EventArgs) Handles nudQuantity.GotFocus
        Me.nudQuantity.Select(0, 1)
    End Sub

    Private Sub nudQuantity_MouseClick(sender As Object, e As MouseEventArgs) Handles nudQuantity.MouseClick
        Me.nudQuantity.Select(0, 1)
    End Sub

    Private Sub УдалитьСтрокуToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles УдалитьСтрокуToolStripMenuItem.Click
        Dim curInd% = Me.dgMatForOper.CurrentRow.Index

        Select Case MsgBox(Prompt:="Удалить строку  " & CStr(Me.dgMatForOper(2, curInd).Value()) & "?", Buttons:=vbYesNo, Title:=appName)
            Case Is = vbYes
                Module1.NonQuery1("DELETE FROM MatCalcForOper WHERE ID=" & Me.dgMatForOper("ID", curInd).Value() & "")
            Case Is = vbNo
                Exit Sub
        End Select
    End Sub

    Private Sub УдалитьToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles УдалитьToolStripMenuItem.Click
        Dim curInd% = Me.dgTechOperFromOrder.CurrentRow.Index

        Select Case MsgBox(Prompt:="Удалить операцию " & CStr(Me.dgTechOperFromOrder(2, curInd).Value()) & "?", Buttons:=vbYesNo, Title:=appName)
            Case Is = vbYes
                Module1.NonQuery1("DELETE FROM tech_OperFromOrder WHERE ID=" & Me.dgTechOperFromOrder("ID", curInd).Value() & "")
            Case Is = vbNo
                Exit Sub
        End Select
    End Sub

    'Private Sub ОтменитьСписаниеToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ОтменитьСписаниеToolStripMenuItem.Click
    '    Dim curInd% = Me.dgMatExpens.CurrentRow.Index

    '    Select Case MsgBox(Prompt:="Отменить списание  " & CStr(Me.dgMatExpens(2, curInd).Value()) & "?", Buttons:=vbYesNo, Title:=appName)
    '        Case Is = vbYes
    '            'Dim cmd As New SqlClient.SqlCommand
    '            'cmd.Connection = mcnnInt
    '            'cmd.CommandText = "[sp_FilterDepSklad]"
    '            'cmd.CommandType = CommandType.StoredProcedure

    '            'Dim odaMan As New SqlClient.SqlDataAdapter(cmd)
    '            'Dim dtMan As New DataTable : odaMan.Fill(dtMan)

    '            If Module1.NonQueryScalarInt("SELECT[dbo].[emplDirDepSklad] ()") = emplID Then
    '                Module1.NonQuery1("DELETE FROM SkladOut WHERE ID = " & Me.dgMatExpens("ID", curInd).Value() & " ")

    '                RasxodMat()
    '            Else
    '                MsgBox("Нет прав.", MsgBoxStyle.Critical, appName)
    '            End If
    '        Case Is = vbNo
    '            Exit Sub
    '    End Select
    'End Sub


    Private Sub cmbDep_SelectedValueChanged(sender As Object, e As EventArgs) Handles cmbDep.SelectedValueChanged
        Try
            Dim odaEmpl As New SqlClient.SqlDataAdapter("SELECT emplID, emplLastName FROM Employees WHERE departmentID=" & Me.cmbDep.SelectedItem(0) & " order by emplLastName", mcnnInt)
            Dim dtEmpl As New DataTable : odaEmpl.Fill(dtEmpl)

            Me.cmbEmplExec.DataSource = dtEmpl
            Me.cmbEmplExec.DisplayMember = "emplLastName"
            Me.cmbEmplExec.ValueMember = "emplID"
        Catch ex As System.Exception
            MessageBox.Show(ex.Message, appName)
            Exit Sub
        End Try
    End Sub


    Private Sub ФормироватьТехнологическуюКартуToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ФормироватьТехнологическуюКартуToolStripMenuItem.Click
        If dsTechCard.Tasks.Rows.Count = 0 Then 'Or currentStatus = 1
            MessageBox.Show("С пустым списком операций формирование документа невозможно", appName, MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Exit Sub
        Else
            Try
                'удаляем старый файл если он есть
                Dim strFileName As String = paramLocalTempPath & "dsTechCard.xml" 'Path.GetTempPath & "\DSTZ.xml"
                Dim rrr As New FileInfo(strFileName)

                rrr.Delete()
                'пишем содержимое датасета в XML
                'dsTZ.Tables("order").WriteXml(strFileName, XmlWriteMode.WriteSchema) 'не пишем таб файлы чтоб в случае файла большого объема не обрывалась связь по таймоуту
                'dsTZ.Tables("cost").WriteXml(strFileName, XmlWriteMode.)
                dsTechCard.WriteXml(strFileName, XmlWriteMode.WriteSchema)

                frmDocPrint.InitReport(NonQueryScalarInt("SELECT ID FROM TypesDocument WHERE TZ=3")) ' ид документа наряд заказ

            Catch ex As System.Exception
                MessageBox.Show(ex.Message, appName)
                Exit Sub
            End Try
        End If
    End Sub

    Private Sub dgTechOperFromOrder_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgTechOperFromOrder.CellContentClick

    End Sub

    Private Sub dgSpec_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgSpec.CellContentClick

    End Sub
End Class