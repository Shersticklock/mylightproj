Public Class frmSkladArrival

    Private Sub frmSkladArrival_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
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

        Dim cmd As New SqlClient.SqlCommand
        cmd.Connection = mcnnInt
        cmd.CommandText = "[sp_FilterDepSklad]"
        cmd.CommandType = CommandType.StoredProcedure
        Dim odaMan As New SqlClient.SqlDataAdapter(cmd)
        Dim dtMan As New DataTable : odaMan.Fill(dtMan)

        Me.tscmbDep.ComboBox.DataSource = dtMan
        Me.tscmbDep.ComboBox.DisplayMember = "Name"
        Me.tscmbDep.ComboBox.ValueMember = "ID"
        Me.tscmbDep.ComboBox.SelectedValue = depID

        FindSup("")
    End Sub

    Function RunQuery(ByVal QueryString As String) As DataSet
        Dim ResultsDataSet As New DataSet

        Try
            Dim DBAdapter As New SqlClient.SqlDataAdapter(QueryString, mcnnInt)

            DBAdapter.Fill(ResultsDataSet)
        Catch ex As System.Exception
            MessageBox.Show(ex.Message, appName)
        Finally
            mcnnInt.Close()
        End Try

        Return ResultsDataSet
    End Function

#Region " Загружаем Поставщиков "
    Private Sub txtKA_find_GotFocus(sender As Object, e As EventArgs) Handles txtKA_find.GotFocus
        sender.text = Nothing
    End Sub

    Private Sub txtKA_find_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles txtKA_find.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                FindSup(Me.txtKA_find.Text)
                e.Handled = True
            End If
        Catch oexpData As System.SystemException
            MsgBox(oexpData.Message + " прцедура [sp_FilterSuplayer]", MsgBoxStyle.Critical, appName)
        End Try
    End Sub

    Private Sub FindSup(fragment As String)
        If fragment = """" Or fragment = "'" Then
            Exit Sub
        Else
            Dim cmd As New SqlClient.SqlCommand
            cmd.Connection = mcnnInt
            cmd.CommandText = "[sp_FilterSuplayer]"
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.Add(New SqlClient.SqlParameter("@fragment", SqlDbType.NVarChar))
            cmd.Parameters("@fragment").Value = fragment

            Dim odaKA As New SqlClient.SqlDataAdapter(cmd)
            Dim dtPartList As New DataTable : odaKA.Fill(dtPartList)

            If dtPartList.Rows.Count = 0 Then
                MsgBox("Поставщик не найден", MsgBoxStyle.Information, appName)
            Else
                Me.cmbKA.DataSource = dtPartList
                Me.cmbKA.DisplayMember = "Name"
                Me.cmbKA.ValueMember = "ID"
            End If
        End If
    End Sub

    '**************************************************************

    Private Sub cmbKA_SelectedValueChanged(sender As Object, e As System.EventArgs) Handles cmbKA.SelectedValueChanged
        Try
            Dim odaPartList As New SqlClient.SqlDataAdapter("SELECT custID, name FROM Organizations  WHERE KAgent_ID=" & Me.cmbKA.SelectedItem(0) & " order by name ", mcnnInt)
            Dim dtPartList As New DataTable : odaPartList.Fill(dtPartList)
            Me.cmbOrganizations.DataSource = dtPartList 'Связать данные со списком
            Me.cmbOrganizations.DisplayMember = "Name"
            Me.cmbOrganizations.ValueMember = "custID"

            If Me.cmbKA.SelectedIndex <> -1 Then
                Me.txtFindNumInv.Enabled = True
            End If
        Catch oexpData As System.Exception
            MsgBox(oexpData.Message, MsgBoxStyle.Critical, appName)
        End Try
    End Sub
#End Region

    Private Sub btnArrivall_Click(sender As System.Object, e As System.EventArgs) Handles btnArrivall.Click
        If Me.cmbKA.SelectedIndex = -1 Then
            MsgBox("Не выбран поставщик материала", MsgBoxStyle.Critical, appName) : Me.cmbKA.Focus() : Exit Sub
        End If

        If Me.cmbUnit.SelectedIndex = -1 Then
            MsgBox("Не выбрана единица учета.", MsgBoxStyle.Critical, appName) : Me.cmbUnit.Focus() : Exit Sub
        End If

        If Me.nudQuantity.Value = 0 Then
            MsgBox("Количество не может быть равно нулю.", MsgBoxStyle.Critical, appName) : Me.nudQuantity.Focus() : Exit Sub
        End If

        If Me.dgMat.SelectedRows.Count = 0 Then
            MsgBox("Не выбран материал, который будет приходоваться.", MsgBoxStyle.Critical, appName) : Me.dgMat.Focus() : Exit Sub
        Else
            Dim strMsg$ = "Принять на склад - " + Me.dgMat("Наименование", Me.dgMat.CurrentRow.Index).Value() + " в объеме - " + Me.nudQuantity.Value.ToString + " " + Me.cmbUnit.Text + "?"

            If MessageBox.Show(strMsg, appName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                Dim depIDNew As Integer = depID


                Dim strSQL$ = "INSERT INTO SkladIn (matID,kolvo,price,description,suplayerID,unitID,depID) " 'invoiceKA_ID,
                strSQL &= "VALUES (" & Me.dgMat("matID", Me.dgMat.CurrentRow.Index).Value() & "," & Replace(Me.nudQuantity.Value, ",", ".") & ","
                strSQL &= "" & Replace(Me.nudPrice.Value, ",", ".") & ",'" & Me.txtNakl.Text & "'," & Me.cmbKA.SelectedItem(0) & "" ', " & Me.cmbNumber.SelectedItem(0) & "
                strSQL &= "," & Me.cmbUnit.SelectedItem(0) & "," & depIDNew & ")" ' ИД департамента проставляется значением  по умолчанию в таблице БД

                Module1.NonQuery1(strSQL)

                Me.nudQuantity.Value = 0
                Me.nudPrice.Value = 0
            Else
                MsgBox("Запись не произведена. Приход на склад.", MsgBoxStyle.Information, appName)
            End If
        End If
    End Sub

    Private Sub tsbtnArrival_CheckedChanged(sender As Object, e As EventArgs) Handles tsbtnArrival.CheckedChanged
        If Me.tsbtnArrival.Checked = True Then 'показываем приходы
            If Me.tscmbDep.ComboBox.SelectedIndex = -1 Then
                MsgBox("Не выбран департамент.", MsgBoxStyle.Critical, appName) : Me.tscmbDep.ComboBox.Focus() : Exit Sub
            Else
                Dim cmd As New SqlClient.SqlCommand
                cmd.Connection = mcnnInt
                cmd.CommandText = "[sp_Sklad_Arrival]"
                cmd.CommandType = CommandType.StoredProcedure

                cmd.Parameters.Add(New SqlClient.SqlParameter("@Data1", SqlDbType.Date))
                cmd.Parameters("@Data1").Value = Me.dtpDate1.Value.Date

                cmd.Parameters.Add(New SqlClient.SqlParameter("@Data2", SqlDbType.Date))
                cmd.Parameters("@Data2").Value = Me.dtpDate2.Value.Date

                cmd.Parameters.Add(New SqlClient.SqlParameter("@DepID", SqlDbType.Int))
                cmd.Parameters("@DepID").Value = Me.tscmbDep.ComboBox.SelectedItem(0)

                Dim objDA As New SqlClient.SqlDataAdapter(cmd)
                Dim dtSklad As New DataTable : objDA.Fill(dtSklad)

                Me.dgMat.DataSource = dtSklad

                ColHideDG(dgMat)
            End If
        Else 'показываем то что было до этого
            LoadList()
        End If

        Me.tvMat.Enabled = Not sender.checked
        Me.btnArrivall.Enabled = Not sender.checked
        Me.txtKA_find.Enabled = Not sender.checked
        Me.cmbKA.Enabled = Not sender.checked
        Me.cmbNumber.Enabled = Not sender.checked
        Me.cmbOrganizations.Enabled = Not sender.checked
        Me.nudQuantity.Enabled = Not sender.checked
        Me.nudPrice.Enabled = Not sender.checked
        Me.cmbUnit.Enabled = Not sender.checked
    End Sub

    Private Sub УдалитьToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles УдалитьToolStripMenuItem.Click
        If Me.dgMat.SelectedRows.Count = 0 Then
            MsgBox("Не выбрана позиция", MsgBoxStyle.Information, appName) : Exit Sub
        End If

        Try
            Select Case MsgBox(Prompt:="Удалить строку " & Me.dgMat("Наименование", Me.dgMat.SelectedRows.Item(0).Index).Value.ToString & "?", Buttons:=vbYesNo, Title:=appName)
                Case Is = vbYes
                    Module1.NonQuery1("DELETE FROM SkladIn WHERE ID=" & Me.dgMat("ID", Me.dgMat.SelectedRows.Item(0).Index).Value & "")
                Case Is = vbNo
                    Exit Sub
            End Select
        Catch ex As System.Exception
            MessageBox.Show(ex.Message, appName)
        End Try
    End Sub

    Private Sub tvMat_AfterSelect(sender As System.Object, e As System.Windows.Forms.TreeViewEventArgs) Handles tvMat.AfterSelect
        LoadList()
    End Sub

    Private Sub LoadList()
        Dim strSQL$ = Nothing
        Dim strSQL2$ = Nothing

        Select Case Me.tvMat.SelectedNode.Level
            Case Is = 0
                Me.dgMat.DataSource = Nothing
                Me.Text = ""
                Me.cmbUnit.DataSource = Nothing

            Case Is = 1
                Me.Text = "Приходование материала категории " + Me.tvMat.SelectedNode.Parent.Tag + ", для типа " + Me.tvMat.SelectedNode.Tag
                'надо давать единицы учета при выборе самого материала
                Try
                    Dim odaMatList As New SqlClient.SqlDataAdapter("SELECT matID,matName AS Наименование, matCatID, typeID FROM Materials WHERE Materials.typeID= " & Me.tvMat.SelectedNode.Tag & " order by matName", mcnnInt)
                    Dim dtMatList As New DataTable : odaMatList.Fill(dtMatList)

                    Me.dgMat.DataSource = dtMatList  'Связать данные со списком

                    ColHideDG(dgMat)
                Catch oexpData As System.SystemException
                    MsgBox(oexpData.Message, MsgBoxStyle.Critical, appName)
                End Try
        End Select
    End Sub

    Private Sub tsbtnExit_Click(sender As System.Object, e As System.EventArgs) Handles tsbtnExit.Click
        Me.Close()
    End Sub

    Private Sub tsbtnMat_Click(sender As System.Object, e As System.EventArgs) Handles tsbtnMat.Click
        ModCallForm.CallForm("Материал", 7, 3)
    End Sub

    Private Sub tsbtnInvoices_Click(sender As Object, e As EventArgs) Handles tsbtnInvoices.Click
        ModCallForm.CallForm("Управление счетами", 27, 3)
    End Sub

    Private Sub txtFindNumInv_GotFocus(sender As Object, e As EventArgs) Handles txtFindNumInv.GotFocus
        sender.text = Nothing
    End Sub

    Private Sub txtFindNumInv_KeyDown(sender As Object, e As KeyEventArgs) Handles txtFindNumInv.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                If Me.txtFindNumInv.Text = """" Or Me.txtFindNumInv.Text = "'" Then
                    Exit Sub
                Else
                    Dim cmd As New SqlClient.SqlCommand
                    cmd.Connection = mcnnInt
                    cmd.CommandText = "[sp_Sklad_Invoices]"
                    cmd.CommandType = CommandType.StoredProcedure

                    cmd.Parameters.Add(New SqlClient.SqlParameter("@KAID", SqlDbType.Int))
                    cmd.Parameters("@KAID").Value = Me.cmbKA.SelectedItem(0)

                    cmd.Parameters.Add(New SqlClient.SqlParameter("@numInv", SqlDbType.NVarChar))
                    cmd.Parameters("@numInv").Value = Me.txtFindNumInv.Text

                    Dim odaNumber As New SqlClient.SqlDataAdapter(cmd)
                    Dim dtNumber As New DataTable : odaNumber.Fill(dtNumber)

                    If dtNumber.Rows.Count = 0 Then
                        MsgBox("Счет не найден", MsgBoxStyle.Information, appName)
                    Else
                        Me.cmbNumber.DataSource = dtNumber  'Связать данные со списком
                        Me.cmbNumber.DisplayMember = "numberInvoice"
                        Me.cmbNumber.ValueMember = "ID"
                    End If
                End If
                ' e.Handled = True
            End If
        Catch oexpData As System.SystemException
            MsgBox(oexpData.Message + " прцедура [sp_Sklad_Invoices]", MsgBoxStyle.Critical, appName)
        End Try
    End Sub

    Private Sub dgMat_SelectionChanged(sender As Object, e As EventArgs) Handles dgMat.SelectionChanged
        If Me.dgMat.SelectedRows.Count > 0 Then
            'надо давать единицы учета при выборе самого материала
            Try
                Dim odaUnit As New SqlClient.SqlDataAdapter("SELECT Units.ID,Units.name FROM SkladAccountingUnits INNER JOIN Units ON SkladAccountingUnits.unitID=Units.ID WHERE SkladAccountingUnits.matID=" & Me.dgMat("matID", Me.dgMat.CurrentRow.Index).Value() & " AND Units.purchase=1 order by name", mcnnInt)
                Dim dtUnit As New DataTable : odaUnit.Fill(dtUnit)

                Me.cmbUnit.DataSource = dtUnit  'Связать данные со списком
                Me.cmbUnit.DisplayMember = "name"
                Me.cmbUnit.ValueMember = "ID"
            Catch oexpData As System.SystemException
                MsgBox(oexpData.Message, MsgBoxStyle.Critical, appName)
            End Try
        End If
    End Sub

    Private Sub ColHideDG(NameGrid As Object)
        For Each col As Object In NameGrid.Columns
            If col.name = "matID" Or col.name = "matCatID" Or col.name = "ID" Or col.name = "typeID" Then
                col.visible = False
            End If
        Next

        NameGrid.ClearSelection()
    End Sub

    Private Sub nudQuantity_MouseClick(sender As Object, e As MouseEventArgs) Handles nudQuantity.MouseClick
        sender.Select(0, (Len(sender.Value.ToString)))
    End Sub

    Private Sub nudPrice_MouseClick(sender As Object, e As MouseEventArgs) Handles nudPrice.MouseClick
        sender.Select(0, (Len(sender.Value.ToString)))
    End Sub

    Private Sub tsbtnExport_Click(sender As Object, e As EventArgs) Handles tsbtnExport.Click
        If Me.dgMat.RowCount = 0 Then
            Exit Sub
        Else
            Dim oExcel As Object
            Dim oBook As Object
            Dim iRow As Integer
            Dim iCol As Integer
            Dim ch As Char
            Dim tmpDataSet As DataTable

            tmpDataSet = CType(Me.dgMat.DataSource, DataTable)

            oExcel = CreateObject("Excel.Application")
            oExcel.Visible = True
            oBook = oExcel.Workbooks.Add

            With oBook.ActiveSheet
                .Range("A2:H2").Font.Size = 12
                .Range("A2:H2").Font.Bold = True
                .Range("B2").Value = "Склад"

                For iCol = 0 To tmpDataSet.Columns.Count - 1

                    ch = Chr(65 + iCol)
                    .Range(ch & 3).Value = Me.dgMat.Columns(iCol).HeaderText.ToString

                    For iRow = 0 To tmpDataSet.Rows.Count - 1
                        ch = Chr(65 + iCol)
                        .Range(ch & iRow + 4).Value = IIf(IsDBNull(dgMat(iCol, iRow).Value), "", dgMat(iCol, iRow).Value)
                    Next iRow
                    .columns(iCol + 1).EntireColumn.AutoFit()
                Next iCol
            End With
        End If
    End Sub

End Class