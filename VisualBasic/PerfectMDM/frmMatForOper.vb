Public Class frmMatForOper

#Region " Загрузка формы "
    Private Sub frmMatForOper_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim cmd As New SqlClient.SqlCommand
        cmd.Connection = mcnnInt
        cmd.CommandText = "[sp_FilterDepSklad]"
        cmd.CommandType = CommandType.StoredProcedure

        '   cmd.Parameters.Add(New SqlClient.SqlParameter("@emplID", SqlDbType.Int))
        '  cmd.Parameters("@emplID").Value = emplID

        Dim odaMan As New SqlClient.SqlDataAdapter(cmd)
        Dim dtMan As New DataTable : odaMan.Fill(dtMan)

        Me.cmbDepartment.DataSource = dtMan
        Me.cmbDepartment.DisplayMember = "Name"
        Me.cmbDepartment.ValueMember = "ID"

        '  Me.cmbDepartment.SelectedValue = depID 'устанавливаем департамент текущего пользователя

        Dim pNode As TreeNode ' parent
        Dim cNode As TreeNode ' child
        Dim ResultSet As DataSet = RunQuery("Select ID, Name From MatCategories order by name ") 'Where description='1'

        Me.tvMat.Nodes.Clear()

        If ResultSet.Tables.Count > 0 Then
            Dim row As DataRow

            For Each row In ResultSet.Tables(0).Rows
                pNode = tvMat.Nodes.Add(row("Name").ToString()) ' add parent
                pNode.Tag = row("ID").ToString()

                Dim ResultSet1 As DataSet = RunQuery("Select ID, Name From MatTypes WHERE matCatID=" & row("ID") & " order by name ")
                Dim row1 As DataRow

                For Each row1 In ResultSet1.Tables(0).Rows
                    cNode = New TreeNode ' another way to add controls - create before adding
                    cNode.Text = row1("Name").ToString()
                    cNode.Tag = row1("ID").ToString()
                    pNode.Nodes.Add(cNode) ' add child
                Next
            Next
        End If

        Select Case modeMatForOper
            Case Is = 1 ' калькуляция
                Me.tsMaterialDelivery.Visible = True
                '  Me.Text = "Калькуляция материала на операцию"
                Me.Label1.Text = "Калькуляция"
                '   Me.Label1.Visible = False
           
                Me.dgAvailableMaterial.Visible = True
                '  Me.dgMatOut.Visible = False
                '***
                Me.btnExecMatForOper.Text = "Сохранить калькуляцию"

            Case Is = 2 'Списываем

                Me.tvMat.Enabled = False

                Me.Label1.Text = "Списано материала на операцию"
                Me.btnExecMatForOper.Text = "Списать"
        End Select
    End Sub
#End Region

#Region " Дерево "
    Private Sub LoadList()
        Select Case Me.tvMat.SelectedNode.Level
            Case Is = 0
                Me.dgAvailableMaterial.DataSource = Nothing
                Me.dgMat.DataSource = Nothing
                Me.Text = ""
            Case Is = 1
                Me.Text = "Материал категории " + Me.tvMat.SelectedNode.Parent.Tag + ", тип " + Me.tvMat.SelectedNode.Tag
            
                Dim cmd As New SqlClient.SqlCommand

                cmd.Connection = mcnnInt

                Select Case modeMatForOper
                    Case Is = 1 ' калькуляция
                        cmd.CommandText = "[sp_Sklad_AllMat]"
                        cmd.CommandType = CommandType.StoredProcedure

                        cmd.Parameters.Add(New SqlClient.SqlParameter("@typeMatID", SqlDbType.Int))
                        cmd.Parameters("@typeMatID").Value = Me.tvMat.SelectedNode.Tag

                    Case Is = 2 ' списываем
                        cmd.CommandText = "[sp_Sklad_AvailableMatInDep]"
                        cmd.CommandType = CommandType.StoredProcedure

                        cmd.Parameters.Add(New SqlClient.SqlParameter("@typeMatID", SqlDbType.Int))
                        cmd.Parameters("@typeMatID").Value = Me.tvMat.SelectedNode.Tag

                        cmd.Parameters.Add(New SqlClient.SqlParameter("@depID", SqlDbType.Int))
                        cmd.Parameters("@depID").Value = depID
                End Select


                Dim objDA As SqlClient.SqlDataAdapter
                objDA = New SqlClient.SqlDataAdapter(cmd)

                Dim dtMatList As New DataTable : objDA.Fill(dtMatList)
                Me.dgMat.DataSource = dtMatList  'Связать данные со списком

                ColHideDG(dgMat)
        End Select
    End Sub

    Function RunQuery(ByVal QueryString As String) As DataSet
        Dim DBAdapter As New SqlClient.SqlDataAdapter(QueryString, mcnnInt)
        Dim ResultsDataSet As New DataSet

        ' Try
        '   DBAdapter = New SqlClient.SqlDataAdapter(QueryString, mcnnInt)
        DBAdapter.Fill(ResultsDataSet)
        '    mcnnInt.Close()
        'Catch ex As System.Exception
        '    If mcnnInt.State = ConnectionState.Open Then
        '        mcnnInt.Close()
        '    End If
        '    MessageBox.Show(ex.Message)
        'End Try
        Return ResultsDataSet
    End Function

    Private Sub tvMat_AfterSelect(sender As System.Object, e As System.Windows.Forms.TreeViewEventArgs) Handles tvMat.AfterSelect
        LoadList()
    End Sub
#End Region

#Region " Выдать списать материал "
    Private Sub btnExecMatForOper_Click(sender As Object, e As EventArgs) Handles btnExecMatForOper.Click
        Dim strSQL$ = Nothing
        Dim strMsg$ = Nothing
        Dim quantity As Decimal

        If Val(Replace(Me.tstxtQuantity.Text, ",", ".")) = 0 Then
            MsgBox("Количество равное нулю не калькулируется.", MsgBoxStyle.Critical, appName)
            Exit Sub
        End If
        'Try
        '    costMat = Module1.NonQuery1Scalar("SELECT costBay FROM SkladAccountingUnits WHERE unitID = " & Me.dgAvailableMaterial("unitID", Me.dgAvailableMaterial.CurrentRow.Index).Value() & " AND matID = " & Me.dgAvailableMaterial("matID", Me.dgAvailableMaterial.CurrentRow.Index).Value() & "")
        'Catch ex As System.Exception
        '    MsgBox(ex.Message, MsgBoxStyle.Critical, appName)
        'End Try
        '  If Me.tscmbModeSpisania.SelectedIndex = 1 Then
        quantity = Val(Replace(Me.tstxtQuantity.Text, ",", ".")) 'калькулируем мат в ед учета
        'Else
        '    Try
        '        quantity = Val(Replace(Me.tstxtQuantity.Text, ",", ".")) / Module1.NonQuery1Scalar("SELECT kolvo FROM MatFormatINOUT WHERE formatPrintID = " & Me.cmbPrintFormat.SelectedItem(0) & " AND unitID = " & Me.dgAvailableMaterial("unitID", Me.dgAvailableMaterial.CurrentRow.Index).Value() & "")
        '    Catch ex As System.Exception
        '        MsgBox("Нет соотношения форматов. " + ex.Message, MsgBoxStyle.Critical, appName) : Exit Sub
        '    End Try
        'End If

        Select Case modeMatForOper
            Case Is = 1 'калькуляция
                If Me.dgAvailableMaterial.SelectedRows.Count = 0 Then
                    MsgBox("Не выбран доступный материал", MsgBoxStyle.Critical, appName)
                Else
                    strMsg = "Калькулировать на операцию - " + Me.dgAvailableMaterial("Наименование", Me.dgAvailableMaterial.CurrentRow.Index).Value() + " в количестве- " + Me.tstxtQuantity.Text + "?"

                    If MessageBox.Show(strMsg, appName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                        strSQL = "INSERT INTO MatCalcForOper (matID, kolvo, unitID, description, depID, tofoID, emplID, prim)"
                        strSQL &= " VALUES (" & Me.dgAvailableMaterial("matID", Me.dgAvailableMaterial.CurrentRow.Index).Value() & "," & Replace(quantity, ",", ".") & ","
                        strSQL &= "" & Me.dgAvailableMaterial("unitID", Me.dgAvailableMaterial.CurrentRow.Index).Value() & ",'делал- " & CStr(emplID) & "',"
                        strSQL &= "" & depID & "," & operFromOrderID & "," & emplID & ",'" & Me.tstxtPrim.Text & "')"

                        Module1.NonQuery1(strSQL)

                        Me.tstxtPrim.Text = Nothing
                    Else
                        MsgBox("Запись не произведена.", MsgBoxStyle.Information, appName)
                    End If
                End If

                CalcForOper(operFromOrderID)

            Case Is = 2 'Списать материал на операцию
                If modeMatForOper = Nothing Then
                    MsgBox("Не выбрана операция на которую будет выдаваться материал", MsgBoxStyle.Critical, appName) : Exit Sub
                Else
                    If Val(Me.tstxtQuantity.Text) = 0 Then
                        MsgBox("Нельзя списать ноль единиц учета.", MsgBoxStyle.Critical, appName) : Exit Sub
                    End If

                    If Me.dgAvailableMaterial.Rows.Count = 0 Or Me.dgAvailableMaterial.SelectedRows.Count = 0 Then
                        MsgBox("Отсутствует или не выбрана единица учета. (Вторая сверху таблица)", MsgBoxStyle.Critical, appName) : Me.dgMat.ClearSelection() : Me.dgAvailableMaterial.Focus() : Exit Sub
                    End If

                    strMsg = "Списать на операцию " + " " + Me.dgAvailableMaterial("Наименование", Me.dgAvailableMaterial.CurrentRow.Index).Value() + " в количестве " + Me.tstxtQuantity.Text + "?"

                    If MessageBox.Show(strMsg, appName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then

                        quantity = RoundUp(quantity)

                        strSQL = "INSERT INTO SkladOut (matID, kolvo, data, orderID, unitID, description, depID, tofoID)"
                        strSQL &= " VALUES (" & Me.dgAvailableMaterial("matID", Me.dgAvailableMaterial.CurrentRow.Index).Value() & ", " & Replace(quantity, ",", ".") & ","
                        strSQL &= "'" & Now().Date & "'," & costID & ", " & Me.dgAvailableMaterial("unitID", Me.dgAvailableMaterial.CurrentRow.Index).Value() & ",'списал- " & CStr(emplID) & "',"
                        strSQL &= "" & depID & "," & operFromOrderID & ")"

                        Module1.NonQuery1(strSQL)

                        DeliveryForOper(operFromOrderID)
                    Else
                        MsgBox("Запись не произведена.", MsgBoxStyle.Information, appName)
                    End If
                End If
        End Select
    End Sub
#End Region

    Private Sub tsbtnMatFromNom_Click(sender As System.Object, e As System.EventArgs) Handles tsbtnMatFromNom.Click
        Me.tvMat.Enabled = True
        Me.dgMat.ClearSelection()
    End Sub

    Private Sub tsbtnMatFromSpec_Click(sender As System.Object, e As System.EventArgs) Handles tsbtnMatFromSpec.Click
        MatFromSpec()
    End Sub

    Public Sub MatFromSpec()
        Me.tvMat.Enabled = False

        If orderSpecID = Nothing Then
            MsgBox("НЕ выбран заказ", MsgBoxStyle.Critical, appName) : Exit Sub
        Else
            Dim cmd As New SqlClient.SqlCommand

            cmd.Connection = mcnnInt
            cmd.CommandText = "[sp_Sklad_MaterialsFromOrder]"
            cmd.CommandType = CommandType.StoredProcedure

            cmd.Parameters.Add(New SqlClient.SqlParameter("@orderID", SqlDbType.Int))
            cmd.Parameters("@orderID").Value = orderSpecID

            Dim objDA As New SqlClient.SqlDataAdapter(cmd)
            Dim dtSklad As New DataTable : objDA.Fill(dtSklad)

            Me.dgMat.DataSource = dtSklad

            ColHideDG(dgMat)
        End If
    End Sub

    Public Sub DeliveryForOper(operID As Integer)
        Dim cmd As New SqlClient.SqlCommand
        cmd.Connection = mcnnInt
        cmd.CommandText = "[sp_Sklad_DeliveryForOper]"
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.Add(New SqlClient.SqlParameter("@operID", SqlDbType.Int))
        cmd.Parameters("@operID").Value = operID

        Dim objDA As New SqlClient.SqlDataAdapter(cmd)
        Dim dtSklad As New DataTable : objDA.Fill(dtSklad)

        Me.dgMatOut.DataSource = dtSklad

        ColHideDG(dgMatOut)
    End Sub

    Public Sub CalcForOper(operID As Integer)
        Dim cmd As New SqlClient.SqlCommand
        cmd.Connection = mcnnInt
        cmd.CommandText = "[sp_Sklad_CalcForOper1]"
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.Add(New SqlClient.SqlParameter("@operID", SqlDbType.Int))
        cmd.Parameters("@operID").Value = operID

        Dim objDA As New SqlClient.SqlDataAdapter(cmd)
        Dim dtSklad As New DataTable : objDA.Fill(dtSklad)

        Me.dgMatOut.DataSource = dtSklad

        ColHideDG(dgMatOut)
    End Sub

    Private Sub ДобавитьПоставщикаToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs)
        addsup = True : ModCallForm.CallForm("Контрагенты", 9, 3)
    End Sub

    Private Sub dgMat_SelectionChanged(sender As Object, e As EventArgs) Handles dgMat.SelectionChanged
        If Me.dgMat.SelectedRows.Count = 1 Then
            'надо давать единицы учета при выборе самого материала
            Try
                Dim cmd As New SqlClient.SqlCommand

                cmd.Connection = mcnnInt

                If modeMatForOper = 1 Then
                    cmd.CommandText = "[sp_Sklad_CalcMat]"
                Else 'списание и надо отобразить только матераиал в наличии
                    cmd.CommandText = "[sp_Sklad_AvailableMat]"
                End If

                cmd.CommandType = CommandType.StoredProcedure

                cmd.Parameters.Add(New SqlClient.SqlParameter("@matID", SqlDbType.Int))
                cmd.Parameters("@matID").Value = Me.dgMat("matID", Me.dgMat.CurrentRow.Index).Value()

                '    cmd.Parameters.Add(New SqlClient.SqlParameter("@DepID", SqlDbType.Int))
                '    cmd.Parameters("@DepID").Value = depID

                Dim objDA As New SqlClient.SqlDataAdapter(cmd)
                Dim dtSklad As New DataTable : objDA.Fill(dtSklad)

                Me.dgAvailableMaterial.DataSource = dtSklad

                ColHideDG(dgAvailableMaterial)

                'If dtSklad.Rows.Count > 0 Then
                '    Me.tscmbModeSpisania.Enabled = True
                'Else
                '    Me.tscmbModeSpisania.Enabled = False
                'End If

                DeliveryForOper(operFromOrderID)
            Catch oexpData As System.SystemException
                MsgBox(oexpData.Message, MsgBoxStyle.Critical, appName)
            End Try
        End If
    End Sub

    Private Sub ColHideDG(NameGrid As Object)
        For Each col As Object In NameGrid.Columns
            If col.name = "matID" Or col.name = "matCatID" Or col.name = "ID" Or col.name = "typeID" Or col.name = "unitID" Then
                col.visible = False
            End If
        Next

        NameGrid.ClearSelection()
    End Sub

    Private Sub tstxtQuantity_Click(sender As Object, e As EventArgs)
        Me.tstxtQuantity.Select(0, (Len(Me.tstxtQuantity.Text)))
    End Sub

    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs) Handles ToolStripButton2.Click
        Me.Close()
    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        Dim curInd% = Me.dgMatOut.CurrentRow.Index

        Select Case MsgBox(Prompt:="Отменить списание  " & CStr(Me.dgMatOut(2, curInd).Value()) & "?", Buttons:=vbYesNo, Title:=appName)
            Case Is = vbYes
                Module1.NonQuery1("DELETE FROM SkladOut WHERE ID=" & Me.dgMatOut("ID", curInd).Value() & "")

                DeliveryForOper(operFromOrderID)
            Case Is = vbNo
                Exit Sub
        End Select
    End Sub
End Class