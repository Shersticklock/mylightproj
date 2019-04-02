Public Class frmSkladInventar

    Dim allowExec As Boolean = False

    Private Sub dgMat_KeyDown(sender As Object, e As KeyEventArgs) Handles dgMat.KeyDown
        If e.KeyCode = Keys.ControlKey + Keys.F Then Find()
        Me.tstxtstrFind.Focus()
        e.Handled = True
    End Sub

    Private Sub frmSkladInventar_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Try
            Dim odaGroup As New SqlClient.SqlDataAdapter("SELECT ID, name From MatGroups order by name", mcnnInt)
            Dim dtGroup As New DataTable : odaGroup.Fill(dtGroup)

            Me.cmbMatGroups.DataSource = dtGroup
            Me.cmbMatGroups.DisplayMember = "name"
            Me.cmbMatGroups.ValueMember = "ID"
            '    Me.cmbMatGroups.SelectedIndex = 1
            allowExec = True

            Dim cmd As New SqlClient.SqlCommand
            cmd.Connection = mcnnInt
            cmd.CommandText = "[sp_FilterDepSklad]"
            cmd.CommandType = CommandType.StoredProcedure

            Dim odaMan As New SqlClient.SqlDataAdapter(cmd)
            Dim dtMan As New DataTable : odaMan.Fill(dtMan)
            Me.cmbDepartments.DataSource = dtMan
            Me.cmbDepartments.DisplayMember = "Name"
            Me.cmbDepartments.ValueMember = "ID"

            Me.cmbDepartments.SelectedValue = depID
        Catch ex As System.Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, appName)
        End Try

        PopulateCategories()
    End Sub

    Sub PopulateCategories()
        Dim pNode As TreeNode ' parent
        Dim cNode As TreeNode ' child
        ' Query for the product categories. These are the values
        ' for the second-level nodes.
        Dim ResultSet As DataSet = RunQuery("Select ID, Name From MatCategories order by name")

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
    End Sub

    Function RunQuery(ByVal QueryString As String) As DataSet
        Dim DBAdapter As SqlClient.SqlDataAdapter
        Dim ResultsDataSet As DataSet = New DataSet

        Try
            ' Run the query and create a DataSet.
            DBAdapter = New SqlClient.SqlDataAdapter(QueryString, mcnnInt)
            DBAdapter.Fill(ResultsDataSet)
            ' Close the database connection.
            mcnnInt.Close()
        Catch ex As System.Exception
            ' Close the database connection if it is still open.
            If mcnnInt.State = ConnectionState.Open Then
                mcnnInt.Close()
            End If

            MessageBox.Show(ex.Message, appName)
        End Try
        Return ResultsDataSet
    End Function

    Sub ExecuteInventar()
        If allowExec = False Then
            Exit Sub
        Else
            If Me.cmbDepartments.SelectedIndex <> -1 Then
                Try 'создаем таблицу полной склад на входе всего
                    Dim objDA As SqlClient.SqlDataAdapter
                    Dim cmd As New SqlClient.SqlCommand

                    cmd.Connection = mcnnInt

                    Select Case Me.cmbModeInventar.SelectedIndex
                        Case Is = 0 'derevo
                            cmd.CommandText = "[sp_Sklad_Inventory]"
                            cmd.CommandType = CommandType.StoredProcedure

                            cmd.Parameters.Add(New SqlClient.SqlParameter("@typeMatID", SqlDbType.Int))
                            cmd.Parameters("@typeMatID").Value = Me.tvMat.SelectedNode.Tag

                        Case Is = 1 ' grupp 
                            cmd.CommandText = "[sp_Sklad_InventoryGroup]"
                            cmd.CommandType = CommandType.StoredProcedure

                            cmd.Parameters.Add(New SqlClient.SqlParameter("@MatGroupID", SqlDbType.Int))
                            cmd.Parameters("@MatGroupID").Value = Me.cmbMatGroups.SelectedItem(0)

                        Case Is = 2 ' total
                            cmd.CommandText = "[sp_Sklad_InventoryTotal]"
                            cmd.CommandType = CommandType.StoredProcedure
                    End Select

                    cmd.Parameters.Add(New SqlClient.SqlParameter("@depID", SqlDbType.Int))
                    cmd.Parameters("@depID").Value = Me.cmbDepartments.SelectedItem(0)

                    objDA = New SqlClient.SqlDataAdapter(cmd)

                    Dim dtSklad As New DataTable : objDA.Fill(dtSklad)

                    dtSklad.Rows.Add()

                    For Each col As DataColumn In dtSklad.Columns
                        Try
                            dtSklad.Rows(dtSklad.Rows.Count - 1)(col.ColumnName) = dtSklad.Compute("SUM(" & col.ColumnName & ")", "")
                        Catch ex As System.Exception
                            '  MsgBox(ex.Message, MsgBoxStyle.Critical, appName)
                        End Try
                    Next

                    Me.dgMat.DataSource = dtSklad

                    ColHideDG(Me.dgMat)
                Catch excp As System.Exception
                    MessageBox.Show(excp.Message, appName)
                End Try
            Else
                MsgBox("Не выбран склад (департамент)", MsgBoxStyle.Critical, appName)
                Me.cmbDepartments.Focus()
            End If
        End If
    End Sub

    Private Sub ColHideDG(NameGrid As Object)
        For Each col As Object In NameGrid.Columns
            If col.name = "typeID" Or col.name = "matID" Or col.name = "ID" Or col.name = "unitID" Then '
                col.visible = False
            End If
        Next

        NameGrid.ClearSelection()
    End Sub

    Private Sub cmbModeInventar_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cmbModeInventar.SelectedIndexChanged
        Select Case Me.cmbModeInventar.SelectedIndex
            Case Is = 0
                Me.cmbMatGroups.Visible = False
                Me.tvMat.Visible = True
            Case Is = 1
                Me.cmbMatGroups.Visible = True
                Me.tvMat.Visible = False
            Case Is = 2
                Me.cmbMatGroups.Visible = False
                Me.tvMat.Visible = False

                ExecuteInventar()
        End Select
    End Sub

    Private Sub cmbMatGroups_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cmbMatGroups.SelectedIndexChanged
        If Me.cmbMatGroups.Visible = True Then
            ExecuteInventar()
        End If
    End Sub

    Private Sub tvMat_AfterSelect(sender As System.Object, e As System.Windows.Forms.TreeViewEventArgs) Handles tvMat.AfterSelect
        If Me.tvMat.Visible = True Then
            Select Case Me.tvMat.SelectedNode.Level
                Case Is = 0
                    Exit Sub
                Case Is = 1
                    ExecuteInventar()
            End Select
        End If
    End Sub

#Region " Экспорт в Excel "

    Private Sub ЭкспортВExcelToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ЭкспортВExcelToolStripMenuItem.Click



        Dim oExcel As Object
        Dim oBook As Object
        Dim iRow As Integer
        Dim iCol As Integer
        Dim ch As Char
        Dim tmpDataSet As DataTable = CType(Me.dgMat.DataSource, DataTable)

        oExcel = CreateObject("Excel.Application")
        oExcel.Visible = True
        oBook = oExcel.Workbooks.Add
        With oBook.ActiveSheet
            .Range("A2:H2").Font.Size = 12
            .Range("A2:H2").Font.Bold = True
            .Range("B2").Value = "Инвентаризация на  " & Now.Date.ToString

            For iCol = 0 To Me.dgMat.Columns.Count - 1
                ch = Chr(65 + iCol)
                .Range(ch & 3).Value = Me.dgMat.Columns(iCol).HeaderText.ToString

                For iRow = 0 To tmpDataSet.Rows.Count - 1
                    ch = Chr(65 + iCol)
                    .Range(ch & iRow + 4).Value = IIf(IsDBNull(Me.dgMat(iCol, iRow).Value), "", Me.dgMat(iCol, iRow).Value)
                Next iRow
                .columns(iCol + 1).EntireColumn.AutoFit()
            Next iCol
        End With
        'oBook.SaveAs(oExcel.StartupPath & "\" & "uuu" & ".xls")
    End Sub
#End Region

    Private Sub cmbDepartments_SelectedValueChanged(sender As Object, e As EventArgs) Handles cmbDepartments.SelectedValueChanged
        Select Case Me.cmbModeInventar.SelectedIndex
            Case Is = 2
                ExecuteInventar()
        End Select
    End Sub

    Private Sub КорректировкаToolStripMenuItem_CheckedChanged(sender As Object, e As EventArgs) Handles КорректировкаToolStripMenuItem.CheckedChanged
        Me.dgMat.Enabled = Not sender.checked
        Me.nudCorr.Visible = sender.checked
        Me.txtCorr.Visible = sender.checked
        Me.btnSaveCorr.Visible = sender.checked
        Me.btnCancelCorr.Visible = sender.checked
    End Sub

    Private Sub КорректировкаToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles КорректировкаToolStripMenuItem.Click
        If postPrioritet <= 2 Then
            Me.nudCorr.Visible = True
            Me.txtCorr.Visible = True
            Me.btnSaveCorr.Visible = True
            Me.btnCancelCorr.Visible = True
            Me.nudCorr.Focus()
        Else
            Me.nudCorr.Visible = False
            Me.txtCorr.Visible = False
            Me.btnSaveCorr.Visible = False
            Me.btnCancelCorr.Visible = False
            MsgBox("Нет доступа.", MsgBoxStyle.Information, appName)
        End If
    End Sub

    Private Sub btnSaveCorr_Click(sender As Object, e As EventArgs) Handles btnSaveCorr.Click
        If Me.КорректировкаToolStripMenuItem.Checked = True Then
            If Me.txtCorr.Text = Nothing Then
                MsgBox("Необходимо указать причину.", MessageBoxIcon.Error, appName)
                Me.txtCorr.Focus()
            Else
                Try
                    Dim strSQL$ = "UPDATE SkladInventar SET quantity=" & Replace(Me.nudCorr.Value, ",", ".") & " WHERE SkladInventar.matID=" & Me.dgMat("matID", Me.dgMat.CurrentRow.Index).Value & " AND SkladInventar.unitID=" & Me.dgMat("unitID", Me.dgMat.CurrentRow.Index).Value & " "

                    Module1.NonQuery1(strSQL)

                    Dim strSQL1$ = "INSERT SkladInvCorr (depID, emplID, matID, oldQuantity, newQuantity, reason, unitID) VALUES (" & Me.cmbDepartments.SelectedItem(0) & "," & emplID & "," & Me.dgMat("matID", Me.dgMat.CurrentRow.Index).Value & "," & Replace(Me.dgMat("Количество", Me.dgMat.CurrentRow.Index).Value, ",", ".") & "," & Replace(Me.nudCorr.Value, ",", ".") & ",'" & Me.txtCorr.Text & "'," & Me.dgMat("unitID", Me.dgMat.CurrentRow.Index).Value & ") "

                    Module1.NonQuery1(strSQL1)

                    MsgBox("Коррекция выполнена", MsgBoxStyle.Information, appName)

                    ExecuteInventar()
                Catch ex As System.Exception
                    MessageBox.Show(ex.Message, appName)
                Finally
                    Me.КорректировкаToolStripMenuItem.Checked = False
                    Me.nudCorr.Visible = False
                    Me.txtCorr.Visible = False
                    Me.btnSaveCorr.Visible = False
                End Try
            End If
        End If
    End Sub

    Private Sub LoadUnits()
        Dim odaUnits As New SqlClient.SqlDataAdapter("SELECT ID, name, paramS, 0 as Сколько From Units WHERE internal=1 AND ID IN (SELECT unitID FROM SkladAccountingUnits WHERE matID=" & Me.dgMat("matID", Me.dgMat.CurrentRow.Index).Value & ") order by name", mcnnInt)
        Dim dtUnits As New DataTable : odaUnits.Fill(dtUnits)

        Me.dgUnits.DataSource = dtUnits
        Me.dgUnits.Columns("ID").Visible = False
    End Sub

    Function CheckedPass(ByVal pass As String) As Boolean
        If pass = "197630" Then
            Return True
        Else
            Return False
        End If
    End Function

    Private Sub txtPwd_TextChanged(sender As Object, e As EventArgs) Handles txtPwd.TextChanged
        If sender.text <> "Введи_пароль" Then
            Me.txtPwd.PasswordChar = "*"
            Me.txtPwd.ForeColor = Color.Black
        End If
    End Sub

    Private Sub ВыходToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ВыходToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ExecuteInventar()
    End Sub

    Private Sub btnCancelCorr_Click(sender As Object, e As EventArgs) Handles btnCancelCorr.Click
        Me.КорректировкаToolStripMenuItem.Checked = False
    End Sub

    Private Sub tsbtnFindForward_Click(sender As Object, e As EventArgs) Handles tsbtnFindForward.Click
        Find()
    End Sub

    Private Sub Find()
        Me.dgMat.ClearSelection()

        Dim Row As DataGridViewRow

        For Each Row In Me.dgMat.Rows
            For Each cell As DataGridViewCell In Row.Cells
                Me.dgMat.Rows(Row.Index).DefaultCellStyle.BackColor = Color.White
            Next
        Next

        Dim str_find As String = Me.tstxtstrFind.Text
        Dim a As Boolean = False

        For Each Row In Me.dgMat.Rows
            For Each cell As DataGridViewCell In Row.Cells
                If (cell.FormattedValue).ToUpper.Contains(str_find.ToUpper) Then
                    Me.dgMat.Rows(Row.Index).DefaultCellStyle.BackColor = Color.LightBlue

                    a = True
                End If
            Next
        Next

        If a = False Then MsgBox(str_find & " не найден", 32, "Поиск")
    End Sub

    Private Sub tstxtstrFind_KeyDown(sender As Object, e As KeyEventArgs) Handles tstxtstrFind.KeyDown
        If e.KeyCode = Keys.Enter Then Find()
        e.Handled = True
    End Sub
End Class