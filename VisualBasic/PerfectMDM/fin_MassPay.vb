Public Class fin_MassPay
   

#Region " Загружаем заказчиков "
    Private Sub LoadCustomers(ByVal strFind As String)
        Try
            Dim odaPartList As New SqlClient.SqlDataAdapter("SELECT ID, Name FROM KAgents WHERE Name LIKE '%" & strFind & "%' order by Name", mcnnInt)
            Dim dtPartList As New DataTable : odaPartList.Fill(dtPartList)

            Me.cmbCustomer.DataSource = dtPartList
            Me.cmbCustomer.DisplayMember = "Name"
            Me.cmbCustomer.ValueMember = "ID"
        Catch oexpData As System.Exception
            MsgBox(oexpData.Message, appName)
        End Try
    End Sub
#End Region

    Private Sub tsbtnUpdate_Click(sender As System.Object, e As System.EventArgs) Handles tsbtnUpdate.Click
        UpdateOrders()
    End Sub

    Private Sub UpdateOrders()
        If Me.cmbCustomer.SelectedIndex = -1 Then
            MsgBox("Не выбран контрагент", MsgBoxStyle.Critical, appName) : Me.cmbCustomer.Focus()
        Else
            Try
                Dim cmd As New SqlClient.SqlCommand

                cmd.Connection = mcnnInt

                If Me.cmbCustOrg.SelectedIndex = -1 Then
                    cmd.CommandText = "sp_Order_MassPay"
                Else
                    cmd.CommandText = "sp_Order_MassPayOrg"
                End If

                cmd.CommandType = CommandType.StoredProcedure
                'Описываем параметры
                cmd.Parameters.Add(New SqlClient.SqlParameter("@Data1", SqlDbType.Date))
                cmd.Parameters("@Data1").Value = Me.DateTimePicker1.Value.Date
                cmd.Parameters.Add(New SqlClient.SqlParameter("@Data2", SqlDbType.Date))
                cmd.Parameters("@Data2").Value = Me.DateTimePicker2.Value.Date
                cmd.Parameters.Add(New SqlClient.SqlParameter("@customer", SqlDbType.Int))
                cmd.Parameters("@customer").Value = Me.cmbCustomer.SelectedItem(0)

                If Me.cmbCustOrg.SelectedIndex <> -1 Then
                    cmd.Parameters.Add(New SqlClient.SqlParameter("@custOrgID", SqlDbType.Int))
                    cmd.Parameters("@custOrgID").Value = Me.cmbCustOrg.SelectedItem(0)
                End If

                Dim objDA As New SqlClient.SqlDataAdapter(cmd)
                Dim dtData As New DataTable : objDA.Fill(dtData)

                If dtData.Rows.Count > 0 Then
                    Me.dgTableData.DataSource = dtData
                    Me.dgTableData.Columns(0).Visible = False 'скрываем первую колонку с ид
                    Me.ToolStripStatusLabel1.Visible = True
                Else
                    Me.dgTableData.DataSource = Nothing
                End If

            Catch excp As System.Exception
                MessageBox.Show(excp.Message, appName)
                Exit Sub
            End Try
        End If
    End Sub


    Dim s As Boolean = False
    Dim d As Integer = 0

    Private Sub dgTableData_SelectionChanged(sender As Object, e As System.EventArgs) Handles dgTableData.SelectionChanged
        Dim s% = 0
        Dim n As Integer = 0

        d = 0

        costIDstr = Nothing

        For Each row As Object In Me.dgTableData.Rows
            If row.selected Then
                s = s + 1
                d += Me.dgTableData("Стоимость", n).Value
                If s > 1 Then costIDstr += ","
                costIDstr += Me.dgTableData("costID", n).Value.ToString
            End If
            n += 1
        Next

        Me.ToolStripStatusLabel1.Text = "Выбрано заказов: " & CStr(s)
        Me.ToolStripStatusLabel2.Text = "на сумму " + CStr(Format(d, "C"))
    End Sub

    Private Sub tsbtnPaySel_Click(sender As System.Object, e As System.EventArgs) Handles tsbtnPaySel.Click
        If costIDstr <> String.Empty Then

            Dim frmSelect As frmOrderPayment

            frmSelect = New frmOrderPayment
            frmSelect.MassPay = True

            frmSelect.nudPay.Text = d
            frmSelect.ShowDialog()
        Else
            MsgBox("Не выбраны заказы", MsgBoxStyle.Critical, appName)
            Exit Sub
        End If
    End Sub

    Private Sub frmOrderPayMass_Activated(sender As Object, e As System.EventArgs) Handles Me.Activated
        If Me.cmbCustomer.SelectedIndex <> -1 Then
            UpdateOrders()
        End If
    End Sub

    Private Sub tsbtnExportToExcel_Click(sender As System.Object, e As System.EventArgs) Handles tsbtnExportToExcel.Click
        If Me.dgTableData.RowCount = 0 Then
            Exit Sub
        End If

        Dim oExcel As Object
        Dim oBook As Object
        Dim iRow As Integer
        Dim iCol As Integer
        Dim ch As Char
        Dim tmpDataSet As DataTable

        'Dim tmpDoc As frmDoc = Me.ActiveMdiChild
        tmpDataSet = CType(Me.dgTableData.DataSource, DataTable)

        oExcel = CreateObject("Excel.Application")
        oExcel.Visible = True
        oBook = oExcel.Workbooks.Add

        With oBook.ActiveSheet
            .Range("A2:H2").Font.Size = 12
            .Range("A2:H2").Font.Bold = True
            .Range("B2").Value = "Массовая оплата"

            For iCol = 0 To tmpDataSet.Columns.Count - 1
                ch = Chr(65 + iCol)
                .Range(ch & 3).Value = Me.dgTableData.Columns(iCol).HeaderText.ToString

                For iRow = 0 To tmpDataSet.Rows.Count - 1
                    ch = Chr(65 + iCol)
                    .Range(ch & iRow + 4).Value = IIf(IsDBNull(dgTableData(iCol, iRow).Value), "", dgTableData(iCol, iRow).Value)
                Next iRow
                .columns(iCol + 1).EntireColumn.AutoFit()
            Next iCol
        End With
        'oBook.SaveAs(oExcel.StartupPath & "\" & "uuu" & ".xls")
    End Sub

    Private Sub ToolStripButton1_Click_1(sender As System.Object, e As System.EventArgs) Handles ToolStripButton1.Click
        Me.Close()
    End Sub

    Private Sub tsbtnSelAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbtnSelAll.Click
        If s = False Then
            Me.dgTableData.SelectAll()
            s = True
        Else
            Me.dgTableData.ClearSelection()
            s = False
        End If
    End Sub

    Private Sub cmbCustomer_SelectedValueChanged(sender As Object, e As EventArgs) Handles cmbCustomer.SelectedValueChanged
        If Me.cmbCustomer.SelectedIndex <> -1 Then
            Dim odaPartList As New SqlClient.SqlDataAdapter("SELECT custID, Name FROM Organizations WHERE KAgent_ID=" & Me.cmbCustomer.SelectedItem(0) & " order by Name", mcnnInt)
            Dim dtPartList As New DataTable : odaPartList.Fill(dtPartList)

            Me.cmbCustOrg.DataSource = dtPartList
            Me.cmbCustOrg.DisplayMember = "Name"
            Me.cmbCustOrg.ValueMember = "custID"
        End If

    End Sub

    Private Sub txtFindKA_KeyDown(sender As Object, e As KeyEventArgs) Handles txtFindKA.KeyDown
        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Tab Then
            LoadCustomers(Me.txtFindKA.Text)
            Me.cmbCustomer.Focus()
        End If
        e.Handled = True

    End Sub

    Private Sub ПерейтиКЗаказуToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ПерейтиКЗаказуToolStripMenuItem.Click
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

    Private Sub fin_MassPay_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class