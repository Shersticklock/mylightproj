Imports System.Data.SqlClient

Public Class frmOrderSpecEdit

    Dim modaLookupData As SqlClient.SqlDataAdapter
    Dim modaLookupData1 As SqlClient.SqlDataAdapter
    Public strID As String
    Dim valStart As Integer
    Dim dtData As DataTable ' спецификация
    Dim dtData1 As DataTable ' спецификация
    '*****************http://vb.net-informations.com/datagridview/vb.net_datagridview_database.htm
    Dim sCommand As SqlCommand
    Dim sAdapter As SqlDataAdapter
    Dim sBuilder As SqlCommandBuilder

    Dim typeEditCost As Integer '1=редактируем стоимость за единицу, 2 редактируем сумму


    Private Sub frm_EditSpec_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LoadData()

        Try
            Me.tstxtItogo.Text = Format(cost, "C")

            Dim odaMat As New SqlClient.SqlDataAdapter("SELECT matID, matName FROM Materials WHERE matID IN (SELECT matID FROM Orders WHERE costID=" & costID & ")", mcnnInt)
            Dim dtMat As New DataTable : odaMat.Fill(dtMat)

            Me.cmbMat.DataSource = dtMat 'Связать данные со списком
            Me.cmbMat.DisplayMember = "matName"
            Me.cmbMat.ValueMember = "matID"

            Me.tstxtKolvo.Visible = False
            Me.tslblKolvo.Visible = False
            Me.dgTableData.SelectionMode = DataGridViewSelectionMode.FullRowSelect
            Me.dgTableData.ReadOnly = True
        Catch oexpData As System.Exception
            MessageBox.Show("Ошибка при редактировании спецификации: " & oexpData.Message, appName)
            Exit Sub
        End Try
    End Sub

    Private Sub LoadData()
        Try
            Dim cmd As New SqlClient.SqlCommand

            cmd.Connection = mcnnInt
            cmd.CommandText = "sp_Order_EditSpec"
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.Add(New SqlClient.SqlParameter("@costID", SqlDbType.Int))
            cmd.Parameters("@costID").Value = costID

            modaLookupData = New SqlClient.SqlDataAdapter(cmd)
            dtData = New DataTable
            modaLookupData.Fill(dtData)

            Me.dgTableData.DataSource = dtData

            ColHideDG(Me.dgTableData)

        Catch excData As System.Exception
            MessageBox.Show(excData.Message, appName)
        End Try
    End Sub

#Region " Сохранить "
    Private Sub tsbtnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbtnSave.Click
        If Me.tstxtKolvo.Visible = True And IsNumeric(Me.tstxtKolvo.Text) = False Then
            MsgBox("Значение количества должно быть числом.", MsgBoxStyle.Critical, appName) : Exit Sub
        Else
            Dim strSQL$ = Nothing
            Dim dgrow As DataGridViewRow

            Try
                For Each dgrow In Me.dgTableData.Rows
                    strSQL = "UPDATE Orders SET kolvo=" & Replace(dgrow.Cells("Количество").Value, ",", ".") & ",prim='" & dgrow.Cells("Примечание").Value & "'"
                    strSQL &= ",nameForDoc='" & dgrow.Cells("Наименование").Value & "', cost=" & Replace(dgrow.Cells("Стоимость").Value, ",", ".") & ""
                    strSQL &= ", costUnit=" & Replace(dgrow.Cells("Стоимость за ед.").Value, ",", ".") & " WHERE ordID=" & dgrow.Cells("ordID").Value & ""

                    Module1.NonQuery1(strSQL)
                Next

        
                Me.dgTableData.Enabled = True
                Me.dgTableData.SelectionMode = DataGridViewSelectionMode.FullRowSelect
                Me.dgTableData.Enabled = True
                Me.dgTableData.MultiSelect = False
                Me.tstxtKolvo.Visible = False
                Me.tslblKolvo.Visible = False
                Me.dgTableData.ReadOnly = True

                LoadData()

                MsgBox("Вот как-то так.", MsgBoxStyle.Information, appName)
            Catch ex As System.Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical, appName)
            End Try   
        End If
    End Sub
#End Region

    Private Sub dgTableData_CellBeginEdit(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellCancelEventArgs) Handles dgTableData.CellBeginEdit
        Me.tsbtnSave.Enabled = False
        Me.cmsEdit.Enabled = False
    End Sub

    Private Sub dgTableData_CellEndEdit(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgTableData.CellEndEdit
        Me.tsbtnSave.Enabled = True
        Me.cmsEdit.Enabled = True

        If Me.dgTableData.CurrentCellAddress.X = 5 Then 'стоимость за ед должна быть 5

            Dim currInd% = Me.dgTableData.CurrentRow.Index

            Me.dgTableData("Стоимость за ед.", currInd).Value = Math.Round(Me.dgTableData("Стоимость за ед.", currInd).Value, 2)
            Me.dgTableData("Стоимость", currInd).Value = Me.dgTableData("Стоимость за ед.", currInd).Value * Me.dgTableData("Количество", currInd).Value
        End If

        Me.tstxtAsWillBe.Text = Format(dtData.Compute("SUM(Стоимость)", ""), "C")
    End Sub

    Private Sub ToolStripButton1_Click(sender As System.Object, e As System.EventArgs) Handles tsbtnExit.Click
        Me.Close()
    End Sub

    Private Sub РедактироватьМатериалToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles РедактироватьМатериалToolStripMenuItem.Click
        PopulateCategories()

        Me.tvMat.Visible = True
        Me.cmbMat.Visible = True
        Me.cmbAccUnits.Visible = True
        Me.btnMatApply.Visible = True
        Me.btnMatCancel.Visible = True

        Me.tsbtnSave.Enabled = False
    End Sub

    Sub PopulateCategories()

        Dim strSQL$ = "SELECT ID, Name FROM MatCategories WHERE description='1' order by Name" '" WHERE ID IN (SELECT number  FROM [dbo].[iter_intlist](' " & list1 & " ' ))  AND description = '1' "
        Dim pNode As TreeNode ' parent
        Dim cNode As TreeNode ' child
        Dim ResultSet As DataSet = RunQuery(strSQL) '"Select ID, Name From MatCategories Where description='1'  ")

        Me.tvMat.Nodes.Clear()

        If ResultSet.Tables.Count > 0 Then

            Dim row As DataRow

            For Each row In ResultSet.Tables(0).Rows
                pNode = tvMat.Nodes.Add(row("Name").ToString()) ' add parent
                pNode.Tag = row("ID").ToString()

                Dim ResultSet1 As DataSet = RunQuery("Select ID, Name From MatTypes WHERE matCatID=" & row("ID") & "")
                Dim row1 As DataRow

                For Each row1 In ResultSet1.Tables(0).Rows
                    cNode = New TreeNode ' another way to add controls - create before adding
                    cNode.Text = row1("Name").ToString()
                    cNode.Tag = row1("ID").ToString()
                    pNode.Nodes.Add(cNode) ' add child
                Next
            Next
        End If
    End Sub

    Function RunQuery(ByVal QueryString As String) As DataSet
        Dim DBAdapter As New SqlClient.SqlDataAdapter(QueryString, mcnnInt)
        Dim ResultsDataSet As New DataSet

        Try
            ' DBAdapter = New SqlClient.SqlDataAdapter(QueryString, mcnnInt)
            DBAdapter.Fill(ResultsDataSet)
            '   mcnnInt.Close()
        Catch ex As System.Exception
            'If mcnnInt.State = ConnectionState.Open Then

            'End If
            MessageBox.Show(ex.Message, appName)
        Finally
            mcnnInt.Close()
        End Try
        Return ResultsDataSet
    End Function

    Private Sub tvMat_AfterSelect(sender As System.Object, e As System.Windows.Forms.TreeViewEventArgs) Handles tvMat.AfterSelect
        LoadList(0)
    End Sub

#Region " Загрузка лист материлов "
    Private Sub LoadList(modeFilter As Integer)
        Dim strSQL$ = Nothing

        Select Case Me.tvMat.SelectedNode.Level
            Case Is = 0
                strSQL = "SELECT matID, matName FROM Materials WHERE Materials.matCatID = " & Me.tvMat.SelectedNode.Tag & " order by matName"
            Case Is = 1
                strSQL = "SELECT matID, matName FROM Materials WHERE Materials.typeID = " & Me.tvMat.SelectedNode.Tag & " order by matName"
        End Select

        Try
            Dim odaMatList As New SqlClient.SqlDataAdapter(strSQL, mcnnInt)
            Dim dtMatList As New DataTable

            odaMatList.Fill(dtMatList)

            If dtMatList.Rows.Count = 0 Then
                Me.cmbAccUnits.DataSource = Nothing
            End If

            Me.cmbMat.DataSource = dtMatList  'Связать данные со списком
            Me.cmbMat.DisplayMember = "matName"
            Me.cmbMat.ValueMember = "matID"
        Catch oexpData As System.Exception
            MsgBox(oexpData.Message, MsgBoxStyle.Critical, appName)
        End Try
    End Sub
#End Region

    Private Sub tsbtnMat_Click(sender As System.Object, e As System.EventArgs) Handles tsbtnMat.Click
        ModCallForm.CallForm("Материал", 7, 3)
    End Sub

    Private Sub НовоеКоличествоToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles НовоеКоличествоToolStripMenuItem.Click
        Me.dgTableData.SelectionMode = DataGridViewSelectionMode.CellSelect
        Me.dgTableData.MultiSelect = True
        Me.dgTableData.Enabled = False

        Dim n As Integer
        Dim currInd% = Me.dgTableData.CurrentRow.Index

        For Each dr As DataRow In dtData.Rows
            If Math.Floor(CDec(Replace(dr("ПП"), ".", ","))) = Math.Floor(CDec(Replace(Me.dgTableData("ПП", currInd).Value, ".", ","))) Then
                Me.dgTableData("Количество", n).Selected = True
            End If
            n += 1
        Next

        Me.tstxtKolvo.Visible = True
        Me.tslblKolvo.Visible = True
        Me.tstxtKolvo.Focus()
    End Sub

    Private Sub УдалитьСтрокуToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles УдалитьСтрокуToolStripMenuItem.Click
        Dim curInd% = Me.dgTableData.CurrentRow.Index

        Select Case MsgBox(Prompt:="Удалить " & Me.dgTableData("Нименование", curInd).Value() & " из спецификации?", Buttons:=vbYesNo, Title:=appName)
            Case Is = vbYes
                Module1.NonQuery1("DELETE FROM Orders WHERE ordID=" & Me.dgTableData("ID", curInd).Value() & "")

                LoadData()
            Case Is = vbNo
                Exit Sub
        End Select
    End Sub


    Private Sub LoadTech(dgTDordID As Integer)
        Try
      
            '  Me.TextBox1.Text = Me.dgTableData("ordID", Me.dgTableData.CurrentRow.Index).Value()

            Dim cmd As New SqlClient.SqlCommand

            cmd.Connection = mcnnInt
            cmd.CommandText = "sp_Order_EditSpecTech"
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.Add(New SqlClient.SqlParameter("@ordID", SqlDbType.Int))
            cmd.Parameters("@ordID").Value = dgTDordID

            modaLookupData1 = New SqlClient.SqlDataAdapter(cmd)
            dtData1 = New DataTable : modaLookupData1.Fill(dtData1)
            Me.dgTechOper.DataSource = dtData1

            '******************************
            'Dim cmb As New DataGridViewComboBoxColumn()
            'cmb.Width = 500
            'cmb.HeaderText = "Операция"
            'cmb.Name = "cmbTechOper"

            'Dim odaTechOper As New SqlClient.SqlDataAdapter("SELECT ID, name FROM tech_Operations", mcnnInt)
            'Dim dtTechOper As New DataTable : odaTechOper.Fill(dtTechOper)
            'cmb.DataSource = dtTechOper  'Связать данные со списком
            'cmb.DisplayMember = "name"
            'cmb.ValueMember = "ID"

            'If dtData1.Rows.Count > 0 Then
            '    Me.dgTechOper.Columns.Clear()
            '    Me.dgTechOper.DataSource = dtData1

            '    'добавляем столбец

            '    Me.dgTechOper.Columns.Add(cmb)

            '    For n As Integer = 0 To dtData1.Rows.Count - 1
            '        Me.dgTechOper("cmbTechOper", n).Value = dtData1.Rows(n)("operID")
            '    Next
            'End If

            ColHideDG(Me.dgTechOper)
        Catch excData As System.Exception
            MessageBox.Show(excData.Message, appName)
        End Try
    End Sub

    Private Sub ColHideDG(NameGrid As Object)
        For Each col As Object In NameGrid.Columns
            If col.name = "ordID" Or col.name = "matCatID" Or col.name = "ID" Or col.name = "matID" Or col.name = "costID" Or col.name = "foplID" Or col.name = "Комментарии" Or col.name = "Описание" Or col.name = "orderID" Or col.name = "operID" Then
                col.visible = False
            End If
        Next

        NameGrid.ClearSelection()
    End Sub

    Dim dtMatFormats As DataTable

    Private Sub cmbMat_SelectedValueChanged(sender As Object, e As EventArgs) Handles cmbMat.SelectedValueChanged
        If Me.cmbMat.SelectedIndex <> -1 Then
            Dim cmd As New SqlClient.SqlCommand

            cmd.Connection = mcnnInt
            cmd.CommandText = "[sp_MatAccUnits]"
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.Add(New SqlClient.SqlParameter("@matID", SqlDbType.Int))
            cmd.Parameters("@matID").Value = Me.cmbMat.SelectedItem(0)

            Dim odaMan As New SqlClient.SqlDataAdapter(cmd)

            dtMatFormats = New DataTable
            odaMan.Fill(dtMatFormats)

            Me.cmbAccUnits.DataSource = dtMatFormats 'Связать данные со списком
            Me.cmbAccUnits.DisplayMember = "unitName"
            Me.cmbAccUnits.ValueMember = "unitID"
        Else

        End If
    End Sub

    Private Sub dgTableData_SelectionChanged(sender As Object, e As EventArgs) Handles dgTableData.SelectionChanged
        If Me.dgTableData.SelectedRows.Count = 1 Then
            Dim curInd% = Me.dgTableData.CurrentRow.Index

            Me.cmbMat.SelectedValue = Me.dgTableData("matID", curInd).Value()

            LoadTech(Me.dgTableData("ordID", curInd).Value())
        Else
            Me.cmbMat.SelectedIndex = -1
        End If
    End Sub

    Private Sub btnMatApply_Click(sender As Object, e As EventArgs) Handles btnMatApply.Click
        Dim currInd% = Me.dgTableData.CurrentRow.Index

        If Me.cmbMat.SelectedIndex = -1 Then
            MsgBox("Не выбран материал", MsgBoxStyle.Critical, appName) : Me.cmbMat.Focus() : Exit Sub
        Else

            Dim strSQL$ = "UPDATE Orders SET"
            strSQL &= " matID = " & Me.cmbMat.SelectedItem(0) & " "
            strSQL &= " , AccUnitID = " & Me.cmbAccUnits.SelectedItem(0) & " "
            '  strSQL &= ", cost = " & Replace(Me.dgTableData("Стоимость", n).Value, ",", ".") & ", costUnit = " & Replace(Me.dgTableData("Стоимость", n).Value / Me.dgTableData(1, n).Value, ",", ".") & " "
            strSQL &= "  WHERE ordID =  " & Me.dgTableData(0, currInd).Value & " "

            Module1.NonQuery1(strSQL)

            LoadData()
        End If

        Me.tvMat.Visible = False
        Me.cmbMat.Visible = False
        Me.cmbAccUnits.Visible = False
        Me.btnMatApply.Visible = False
        Me.btnMatCancel.Visible = False

        Me.tsbtnSave.Enabled = True
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnMatCancel.Click
        Me.tvMat.Visible = False
        Me.cmbMat.Visible = False
        Me.cmbAccUnits.Visible = False
        Me.btnMatApply.Visible = False
        Me.btnMatCancel.Visible = False

        Me.tsbtnSave.Enabled = True
    End Sub

    Private Sub tstxtKolvo_KeyDown(sender As Object, e As KeyEventArgs) Handles tstxtKolvo.KeyDown
        If e.KeyCode = Keys.Enter Then
            If IsNumeric(Me.tstxtKolvo.Text) = False Then
                MsgBox("Значение количества должно быть числом.", MsgBoxStyle.Critical, appName) : Exit Sub
            Else
                Dim currInd% = Me.dgTableData.CurrentRow.Index

                Dim n% = 0
                Dim m% = 0

                For Each dr As DataRow In dtData.Rows
                    If Math.Floor(CDec(Replace(dr("ПП"), ".", ","))) = Math.Floor(CDec(Replace(Me.dgTableData("ПП", currInd).Value, ".", ","))) Then
                        '  MsgBox(dr(1))
                        m = 0
                        For Each dr1 As DataRow In dtData1.Rows
                            If dr1("orderID") = dr("ordID") Then
                                Select Case dr1("typeO")
                                    Case Is = 1 'файл
                                        ' Me.dgTechOper("Количество", n).Value = 1
                                    Case Is = 2 'мат ---нужен расчет по функции
                                        '  Me.dgTechOper("Количество", m).Value *= Val(Me.tstxtKolvo.Text) / Me.dgTableData("Количество", n).Value
                                    Case Is = 3 'изделие
                                        '  Me.dgTechOper("Количество", m).Value = Val(Me.tstxtKolvo.Text)
                                End Select
                            End If

                            m += 1
                        Next

                        Me.dgTableData("Количество материала", n).Value = Me.dgTableData("Количество материала", n).Value / Me.dgTableData("Количество", n).Value * Val(Me.tstxtKolvo.Text)
                        Me.dgTableData("Стоимость", n).Value = Me.dgTableData("Стоимость за ед.", n).Value * Val(Me.tstxtKolvo.Text)
                        Me.dgTableData("Количество", n).Value = Me.tstxtKolvo.Text

                        ' Me.dgTableData("Стоимость за ед.", n).Value = Math.Round(Me.dgTableData("Стоимость", n).Value / Val(Me.tstxtKolvo.Text), 2)
                    End If
                    n += 1
                Next

                Me.dgTableData.SelectionMode = DataGridViewSelectionMode.CellSelect
                Me.dgTableData.ReadOnly = True
                Me.dgTableData.Enabled = True
            End If
        End If
    End Sub

    Private Sub tsbtnCancel_Click(sender As Object, e As EventArgs) Handles tsbtnCancel.Click
        LoadData()

        If Me.dgTableData.SelectedCells.Count = 1 Then
            Dim curInd% = Me.dgTableData.CurrentRow.Index

            Me.cmbMat.SelectedValue = Me.dgTableData("matID", curInd).Value()

            LoadTech(Me.dgTableData("ordID", curInd).Value())
        Else
            Me.cmbMat.SelectedIndex = -1
        End If

        Me.dgTableData.MultiSelect = False
        Me.tslblKolvo.Visible = False
        Me.tstxtKolvo.Visible = False
    End Sub

    Private Sub НоваяЦенаЗаЕдиницуToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles НоваяЦенаЗаЕдиницуToolStripMenuItem.Click
        typeEditCost = 1

        Me.dgTableData.SelectionMode = DataGridViewSelectionMode.CellSelect
        Me.dgTableData.ReadOnly = False
    End Sub

    Private Sub НоваяСуммаToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles НоваяСуммаToolStripMenuItem.Click
        typeEditCost = 2

        Me.dgTableData.SelectionMode = DataGridViewSelectionMode.CellSelect
        Me.dgTableData.ReadOnly = False
    End Sub

    Private Sub dgTableData_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgTableData.CellContentClick

    End Sub
End Class