Imports System.Text

Public Class frmSklad

    Dim dtMatList1 As DataTable

#Region " Загрузка формы "
    Private Sub frmSklad_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.cmbSelectMode.SelectedIndex = -1


        Dim cmd As New SqlClient.SqlCommand
        cmd.Connection = mcnnInt
        cmd.CommandText = "[sp_FilterDepSklad]"
        cmd.CommandType = CommandType.StoredProcedure
        Dim odaMan As New SqlClient.SqlDataAdapter(cmd)
        Dim dtMan As New DataTable : odaMan.Fill(dtMan)

        Me.cmbDepartment.DataSource = dtMan
        Me.cmbDepartment.DisplayMember = "Name"
        Me.cmbDepartment.ValueMember = "ID"

        Me.cmbDepartment.SelectedValue = depID 'устанавливаем департамент текущего пользователя

        Dim pNode As TreeNode ' parent
        Dim cNode As TreeNode ' child
        Dim ResultSet As DataSet = RunQuery("Select ID, Name From MatCategories order by name") 'Where description='1'

        Me.tvMat.Nodes.Clear()

        If ResultSet.Tables.Count > 0 Then

            Dim row As DataRow

            For Each row In ResultSet.Tables(0).Rows
                pNode = tvMat.Nodes.Add(row("Name").ToString()) ' add parent
                pNode.Tag = row("ID").ToString()

                Dim ResultSet1 As DataSet = RunQuery("Select ID, Name From MatTypes WHERE matCatID=" & row("ID") & " order by name")
                Dim row1 As DataRow

                For Each row1 In ResultSet1.Tables(0).Rows
                    cNode = New TreeNode ' another way to add controls - create before adding
                    cNode.Text = row1("Name").ToString()
                    cNode.Tag = row1("ID").ToString()
                    pNode.Nodes.Add(cNode) ' add child
                Next
            Next
        End If

        Try
            Dim odaDep As New SqlClient.SqlDataAdapter("SELECT ID, Name FROM Departments order by Name", mcnnInt)
            Dim dtDep As New DataTable : odaDep.Fill(dtDep)

            Me.cmbDepAssignment.ComboBox.DataSource = dtDep 'Связать данные со списком
            Me.cmbDepAssignment.ComboBox.DisplayMember = "Name"
            Me.cmbDepAssignment.ComboBox.ValueMember = "ID"


        Catch oexpData As System.Exception
            MessageBox.Show("Ошибка при загрузке списка департаментов: " & oexpData.Message, appName)
        End Try
    End Sub
#End Region

#Region " Дерево "
    Private Sub LoadList()
        Select Case Me.tvMat.SelectedNode.Level
            Case Is = 0
                Me.dgUnit.DataSource = Nothing
                Me.dgMat.DataSource = Nothing
                Me.Text = ""
            Case Is = 1
                Me.Text = "Выдача материала категории " + Me.tvMat.SelectedNode.Parent.Tag + ", типа " + Me.tvMat.SelectedNode.Tag

                Dim cmd As New SqlClient.SqlCommand

                cmd.Connection = mcnnInt
                cmd.CommandText = "[sp_Sklad_AvailableWOtreb]"
                cmd.CommandType = CommandType.StoredProcedure

                cmd.Parameters.Add(New SqlClient.SqlParameter("@typeMatID", SqlDbType.Int))
                cmd.Parameters("@typeMatID").Value = Me.tvMat.SelectedNode.Tag

                cmd.Parameters.Add(New SqlClient.SqlParameter("@depID", SqlDbType.Int))
                cmd.Parameters("@depID").Value = depID

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
    Private Sub btnExecute_Click(sender As Object, e As EventArgs) Handles btnExecute.Click
        Dim strMsg$
        Dim strSQL$ = Nothing
        Dim quantity As Decimal

        If Me.dgUnit.RowCount = 0 Or Me.dgUnit.SelectedRows.Count = 0 Then
            MsgBox("Нет доступного материала или он не выбран.", MsgBoxStyle.Critical, appName)
            Exit Sub
        Else

            If Me.cmbSelectMode.SelectedIndex = 0 Then 'Выдаем по требованию
                If MessageBox.Show("Выдать - " + Me.dgMat("Ед. учета", Me.dgMat.CurrentRow.Index).Value() + " в количестве- " + Me.dgMat("Количество", Me.dgMat.CurrentRow.Index).Value().ToString + "?", appName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                    '  If dtDetailTreb.Rows.Count > 0 Then
                    If Me.dgUnit("Количество", Me.dgUnit.CurrentRow.Index).Value() >= Me.dgMat("Количество", Me.dgMat.CurrentRow.Index).Value() Then
                        Try
                            strSQL = "INSERT INTO SkladOut (matID, kolvo, unitID, description, depID, tofoID, orderID, emplID) VALUES (" & Me.dgMat("matID", Me.dgMat.CurrentRow.Index).Value() & "," & Replace(Me.dgMat("Количество", Me.dgMat.CurrentRow.Index).Value(), ",", ".") & ","
                            strSQL &= "" & Me.dgMat("unitID", Me.dgMat.CurrentRow.Index).Value() & ",'списал-" & CStr(emplID) + " на заказ " + Me.dgMat("Заказ", Me.dgMat.CurrentRow.Index).Value().ToString & "'," & Me.cmbDepartment.SelectedItem(0) & "," & Me.dgMat("tofoID", Me.dgMat.CurrentRow.Index).Value() & ", " & Me.dgMat("orderID", Me.dgMat.CurrentRow.Index).Value() & "," & emplID & ")"

                            Module1.NonQuery1(strSQL)

                            LoadUnit()

                        Catch ex As System.Exception
                            Exit Sub
                        End Try
                    Else
                        MsgBox("Количество в наличии меньше требуемого.", MsgBoxStyle.Critical, appName)
                        Exit Sub
                    End If
                Else
                    MsgBox("Запись не произведена.", MsgBoxStyle.Information, appName)
                End If

            Else 'Списываем с ОСНОВНОГО склада НА СКЛАД НАЗНАЧЕНИЕ
                quantity = Val(Me.tstxtQuantity.Text)

                strMsg = "Выдать на департамент - " + Me.dgUnit("Наименование", Me.dgUnit.CurrentRow.Index).Value() + " в количестве- " + Me.tstxtQuantity.Text + "?"

                If MessageBox.Show(strMsg, appName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                    If Me.dgUnit("Количество", Me.dgUnit.CurrentRow.Index).Value() >= quantity Then
                        Try
                            If Me.tstxtReason.Text = "" Then
                                MsgBox("Укажите ФИО кому выдан материал или причину списания.", MsgBoxStyle.Critical, appName)
                                Me.tstxtReason.Focus()
                                Exit Sub
                            Else
                                'с какого склада выдал СДЕЛАТЬ ПРОЦЕДУРУ сейчас цена прписывается триггерами
                                strSQL = "INSERT INTO SkladOut (matID, kolvo, data, unitID, description, depID)"
                                strSQL &= " VALUES (" & Me.dgUnit("matID", Me.dgUnit.CurrentRow.Index).Value() & ", " & Replace(quantity, ",", ".") & ","
                                strSQL &= " '" & Now().Date & "', " & Me.dgUnit("unitID", Me.dgUnit.CurrentRow.Index).Value() & ", '" & Me.tstxtReason.Text & "',"
                                strSQL &= "" & Me.cmbDepartment.SelectedItem(0) & ")"

                                Module1.NonQuery1(strSQL)

                                If depID = Me.cmbDepartment.SelectedValue Then 'приходование на склад назначения
                                    strSQL = "INSERT INTO SkladIN (matID, kolvo, data, unitID, description, depID)"
                                    strSQL &= " VALUES (" & Me.dgUnit("matID", Me.dgUnit.CurrentRow.Index).Value() & "," & Replace(quantity, ",", ".") & ","
                                    strSQL &= "'" & Now().Date & "'," & Me.dgUnit("unitID", Me.dgUnit.CurrentRow.Index).Value() & ",'выдал- " & CStr(emplID) & "',"
                                    strSQL &= "" & Me.cmbDepAssignment.SelectedItem(0) & ")"
                                    ', " & Replace(Me.dgAvailableMaterial("costBay", Me.dgAvailableMaterial.CurrentRow.Index).Value(), ",", ".") & "

                                    Module1.NonQuery1(strSQL)

                                    LoadUnit()

                                    MsgBox("Списано с выдающего склада и зачислено на склад назначения!", MsgBoxStyle.Information, appName)

                                End If

                                DeliveryNow()

                                Me.lbMatOut.Text = "Списано сегодня"
                            End If
                        Catch ex As System.Exception
                            MsgBox(ex.Message) : Exit Sub
                        End Try
                    Else
                        MsgBox("Количество в наличии меньше требуемого.", MsgBoxStyle.Critical, appName)
                        Exit Sub
                    End If
                Else
                    MsgBox("Запись не произведена.", MsgBoxStyle.Information, appName)
                End If
            End If
        End If
    End Sub
#End Region

    Private Sub DeliveryNow()
        If Me.cmbDepartment.SelectedIndex = -1 Then
            MsgBox("Не выбран департамент, отменяет только кладовщик.", MsgBoxStyle.Critical, appName)
            Me.cmbDepartment.Focus()

        Else
            Dim cmd As New SqlClient.SqlCommand

            cmd.Connection = mcnnInt
            cmd.CommandText = "[sp_Sklad_DeliveryNow]"
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.Add(New SqlClient.SqlParameter("@Data1", SqlDbType.Date))
            cmd.Parameters("@Data1").Value = Me.dtpDateMatOut.Value.Date

            cmd.Parameters.Add(New SqlClient.SqlParameter("@DepID", SqlDbType.Int))
            cmd.Parameters("@DepID").Value = Me.cmbDepartment.SelectedItem(0)

            Dim objDA As New SqlClient.SqlDataAdapter(cmd)
            Dim dtSklad As New DataTable : objDA.Fill(dtSklad)

            Me.dgMatOut.DataSource = dtSklad

            ColHideDG(dgMatOut)

            Me.lbMatOut.Text = "Материал, выданный " + Format(Me.dtpDateMatOut.Value, "dd.MM.yyyy")
            Me.lbMatOut.Visible = True
            Me.ОтменитьСписаниеToolStripMenuItem.Visible = True
        End If
    End Sub

    Private Sub ДобавитьПоставщикаToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs)
        addsup = True : ModCallForm.CallForm("Контрагенты", 9, 3)
    End Sub

    Private Sub cmbDepAssignment_SelectedValueChanged(sender As Object, e As EventArgs)
        If depID = Me.cmbDepartment.SelectedValue Then
            Me.btnExecute.Text = "Списать материал"
            Me.tslbReason.Text = "причина списания"
        Else
            Me.btnExecute.Text = "Выдать материал"
            Me.tslbReason.Text = "ФИО кому выдал"
        End If
    End Sub

    Private Sub dgMat_CurrentCellChanged(sender As Object, e As EventArgs) Handles dgMat.CurrentCellChanged
        'надо давать единицы учета при выборе самого материала
        Try
            LoadUnit()
        Catch oexpData As System.SystemException
            MsgBox(oexpData.Message, MsgBoxStyle.Critical, appName)
        End Try
    End Sub

    Private Sub LoadUnit()
        If IsNothing(Me.dgMat.CurrentRow) = False Then
            Dim cmd As New SqlClient.SqlCommand

            cmd.Connection = mcnnInt

            If Me.cmbSelectMode.SelectedIndex = 0 Then
                cmd.CommandText = "[sp_Sklad_TrebOnMat]"
                cmd.CommandType = CommandType.StoredProcedure

                cmd.Parameters.Add(New SqlClient.SqlParameter("@matID", SqlDbType.Int))
                cmd.Parameters("@matID").Value = Me.dgMat("matID", Me.dgMat.CurrentRow.Index).Value()

                cmd.Parameters.Add(New SqlClient.SqlParameter("@DepID", SqlDbType.Int))
                cmd.Parameters("@DepID").Value = depID

                cmd.Parameters.Add(New SqlClient.SqlParameter("@unitID", SqlDbType.Int))
                cmd.Parameters("@unitID").Value = Me.dgMat("unitID", Me.dgMat.CurrentRow.Index).Value()

            Else
                cmd.CommandText = "[sp_Sklad_AvailableMat]"
                cmd.CommandType = CommandType.StoredProcedure

                cmd.Parameters.Add(New SqlClient.SqlParameter("@matID", SqlDbType.Int))
                cmd.Parameters("@matID").Value = Me.dgMat("matID", Me.dgMat.CurrentRow.Index).Value()
            End If

            Dim objDA As New SqlClient.SqlDataAdapter(cmd)
            Dim dtSklad As New DataTable : objDA.Fill(dtSklad)

            Me.dgUnit.DataSource = dtSklad

            ColHideDG(dgUnit)
        Else
            Me.dgUnit.DataSource = Nothing
        End If
    End Sub

    Private Sub ColHideDG(NameGrid As Object)
        For Each col As Object In NameGrid.Columns
            If col.name = "matID" Or col.name = "matCatID" Or col.name = "ID" Or col.name = "typeID" Or col.name = "unitID" Or col.name = "orderID" Or col.name = "tofoID" Then '
                col.visible = False
            End If
        Next

        NameGrid.ClearSelection()
    End Sub


    Private Sub tsbtnTrebNaOtpusk_Click(sender As Object, e As EventArgs)
        TrebMain()
    End Sub

    Private Sub tsbtnAllMatOut_Click(sender As Object, e As EventArgs) Handles tsbtnAllMatOut.Click
        Dim cmd As New SqlClient.SqlCommand

        cmd.Connection = mcnnInt
        cmd.CommandText = "[sp_Sklad_Delivery]"
        cmd.CommandType = CommandType.StoredProcedure

        cmd.Parameters.Add(New SqlClient.SqlParameter("@DepID", SqlDbType.Int))
        cmd.Parameters("@DepID").Value = Me.cmbDepAssignment.SelectedItem(0)

        Dim objDA As New SqlClient.SqlDataAdapter(cmd)
        Dim dtSklad As New DataTable : objDA.Fill(dtSklad)

        Me.dgMatOut.DataSource = dtSklad

        ColHideDG(dgMatOut)

        Me.ОтменитьСписаниеToolStripMenuItem.Visible = True
    End Sub

    Private Sub tsbtnMatOutOnDate_Click(sender As Object, e As EventArgs) Handles tsbtnMatOutOnDate.Click
        DeliveryNow()
    End Sub

    Private Sub tstxtQuantity_Click(sender As Object, e As EventArgs) Handles tstxtQuantity.Click
        Me.tstxtQuantity.Select(0, (Len(Me.tstxtQuantity.Text)))
    End Sub

    Public Sub SaveHTML(ByVal strHTML As String)
        Dim htmlFile As New IO.FileInfo("C:\report.html")
        Dim sw As New IO.StreamWriter("C:\report.html", False, System.Text.Encoding.GetEncoding(1251)) ' = htmlFile.CreateText()
        'Если поставить не False а True, то запись будет в конец файла. Т.е. если в файле уже есть текст, то этот текст стераться не будет, а новый будет добавляться в конец. Если файла не существует, то он создаваться не будет. А если же поставить False, то если в файле был текст, то он стерается, и запись идет в пустой файл. Если файла не существует, то он создается. Дальше идет тип кодировки, в нашем случае это стандартная 1251 
        sw.WriteLine(strHTML)
        sw.Close()
        Process.Start("C:\report.html")
    End Sub

    Public Sub PrintHTML()
        Try
            Dim MyProcess As New Process
            MyProcess.StartInfo.CreateNoWindow = False
            MyProcess.StartInfo.Verb = "print"
            MyProcess.StartInfo.FileName = "C:\report.html"
            MyProcess.Start()
            MyProcess.WaitForExit()
        Catch ex As System.Exception
            MessageBox.Show("Printing error", appName)
        End Try
    End Sub

    Private Sub tsbtnOrderMat_Click(sender As Object, e As EventArgs) Handles tsbtnOrderMat.Click
        Dim cmd As New SqlClient.SqlCommand

        cmd.Connection = mcnnInt
        cmd.CommandText = "[sp_Sklad_OrderBayMat]"
        cmd.CommandType = CommandType.StoredProcedure

        Dim objDA As New SqlClient.SqlDataAdapter(cmd)
        Dim dtSklad As New DataTable : objDA.Fill(dtSklad)

        Me.dgMatOut.DataSource = dtSklad

        ColHideDG(dgMatOut)

        Me.lbMatOut.Text = "Материал, Заказанный на " + Format(Now().Date, "dd.MM.yyyy")
        Me.lbMatOut.Visible = True

        Me.ОтменитьСписаниеToolStripMenuItem.Visible = False
    End Sub


    Private Sub ЗаказатьМатериалToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ЗаказатьМатериалToolStripMenuItem.Click
        ' сделать отметку чтоб выданное требование не отображалось -менять статус у калькуляции
        Dim strSQL$ = "UPDATE MatCalcForOper SET statusID=2 WHERE ID=" & Me.dgMatOut("ID", Me.dgMatOut.CurrentRow.Index).Value() & " "

        Module1.NonQuery1(strSQL)

        TrebMain()

        MsgBox("Заказан материал.", MsgBoxStyle.Information, appName)
    End Sub

    Private Sub МатериалЗакупленToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles МатериалЗакупленToolStripMenuItem.Click
        Dim strSQL$ = "UPDATE MatCalcForOper SET statusID=1 WHERE ID =" & Me.dgMat("ID", Me.dgMat.CurrentRow.Index).Value() & " "

        Module1.NonQuery1(strSQL)

        TrebMain()

        MsgBox("Материал оприходован.", MsgBoxStyle.Information, appName)
    End Sub

    Private Sub ОтменитьСписаниеToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ОтменитьСписаниеToolStripMenuItem.Click
        Dim curInd% = Me.dgMatOut.CurrentRow.Index

        Select Case MessageBox.Show("Отменить списание?", appName, MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            Case Is = DialogResult.Yes
                If Module1.NonQueryScalarInt("SELECT[dbo].[emplDirDepSklad]()") = emplID Then
                    Module1.NonQuery1("DELETE FROM SkladOut WHERE ID=" & Me.dgMatOut("ID", curInd).Value() & "")
                Else
                    MsgBox("Нет прав.", MsgBoxStyle.Critical, appName)
                End If

            Case Is = DialogResult.No
                Exit Sub
        End Select
    End Sub

    Private Sub ПерейтиКЗаказуToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ПерейтиКЗаказуToolStripMenuItem.Click
        Dim frmSelect As frmOrder

        Try
            frmSelect = New frmOrder
            costID = Me.dgMatOut("costID", Me.dgMatOut.CurrentRow.Index).Value()
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

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub


    Private Sub cmbSelectMode_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbSelectMode.SelectedIndexChanged
        Select Case Me.cmbSelectMode.SelectedIndex
            Case Is = -1
                Me.tlp2.Visible = False
                Me.tlp3.Visible = False
                Me.tvMat.Visible = False

            Case Is = 0 'Выдача по требованию
                Me.tlp2.Visible = True

                Me.tvMat.Visible = True
                Me.tvMat.Enabled = False

                Me.dgMat.Visible = True
                Me.dgUnit.Visible = True
                Me.tsUnit.Visible = True
                Me.lbUnit.Visible = True

                Me.cmbDepAssignment.Visible = False
                Me.tslbReason.Visible = False
                Me.tstxtReason.Visible = False

                Me.tsunitsQuant.Visible = False
                Me.tstxtQuantity.Visible = False

                Me.tlp3.Visible = False

            Case Is = 1 'Выдача на департамент
                Me.tvMat.Visible = True
                Me.tvMat.Enabled = True
                Me.dgMat.Visible = True
                Me.dgUnit.Visible = True
                Me.tsUnit.Visible = True
                Me.lbUnit.Visible = True

                Me.tsunitsQuant.Visible = True
                Me.tstxtQuantity.Visible = True
                Me.cmbDepAssignment.Visible = True
                Me.tslbReason.Visible = True
                Me.tstxtReason.Visible = True

                Me.tlp3.Visible = False
                Me.tlp2.Visible = True

            Case Is = 2 'Выданный и заказанный материал
                Me.tvMat.Visible = False
                Me.tlp3.Visible = True
                Me.tlp2.Visible = False
        End Select
    End Sub

    Private Sub ИнвентаризацияToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ИнвентаризацияToolStripMenuItem.Click
        ModCallForm.CallForm("Инвентаризация на дату " & CStr(Now().Date), 33, 3)
    End Sub

    Private Sub ЭкспортВExcelToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ЭкспортВExcelToolStripMenuItem.Click
        Dim oExcel As Object
        Dim oBook As Object
        Dim iRow As Integer
        Dim iCol As Integer
        Dim ch As Char

        oExcel = CreateObject("Excel.Application")
        oExcel.Visible = True
        oBook = oExcel.Workbooks.Add
        With oBook.ActiveSheet
            .Range("A2:H2").Font.Size = 12
            .Range("A2:H2").Font.Bold = True
            .Range("B2").Value = "Выдано на дату " + Me.dtpDateMatOut.Value.Date.ToString

            For iCol = 0 To Me.dgMatOut.Columns.Count - 1
                ch = Chr(65 + iCol)
                .Range(ch & 3).Value = Me.dgMatOut.Columns(iCol).HeaderText.ToString

                For iRow = 0 To Me.dgMatOut.Rows.Count - 1
                    ch = Chr(65 + iCol)
                    .Range(ch & iRow + 4).Value = IIf(IsDBNull(Me.dgMatOut(iCol, iRow).Value), "", Me.dgMatOut(iCol, iRow).Value)
                Next iRow
                .columns(iCol + 1).EntireColumn.AutoFit()
            Next iCol
        End With
    End Sub


    Private Sub TrebMain()
        Throw New NotImplementedException
    End Sub

    Private Sub dgMat_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgMat.CellContentClick

    End Sub
End Class