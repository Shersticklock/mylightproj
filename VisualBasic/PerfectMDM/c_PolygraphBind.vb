Imports System.Data.SqlClient
Imports System.Threading

Public Class c_PolygraphBind
    
    Dim countOfThings As Integer = 0
    Dim discountDataTable As DataTable
    Dim needRecalculate As Boolean
    
    Private Sub tsbtnExit_Click(sender As Object, e As EventArgs) Handles tsbtnExit.Click
        Me.Close()
    End Sub

    Private Sub mdm_PolygraphBind_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DiscountComboBox.ComboBox.DisplayMember = "name"
        DiscountComboBox.ComboBox.ValueMember = "name"

        LoadDiscounts()
        
        Me.WebBrowser1.ObjectForScripting = Me
        Me.WebBrowser1.Navigate(paramUrlCalcPolygraph + CStr(costID))
    End Sub

    Private Sub LoadDiscounts()
        Dim cmd As New SqlCommand
        cmd.Connection = mcnnInt
        cmd.CommandText = "sp_GetAllDiscounts"
        cmd.CommandType = CommandType.StoredProcedure

        cmd.Parameters.Add(New SqlParameter("@ServiceId", SqlDbType.Int))
        cmd.Parameters("@ServiceId").Value = serviceID

        Dim discountSqlDataAdapter As New SqlDataAdapter(cmd)
        discountDataTable = New DataTable()
        discountSqlDataAdapter.Fill(discountDataTable)

        Dim idCol As DataColumn = discountDataTable.Columns("id")
        discountDataTable.PrimaryKey = New DataColumn() {idCol}
    End Sub

    Private Sub tsbtnOK_Click(sender As Object, e As EventArgs) Handles tsbtnOK.Click
        Dim links = Me.WebBrowser1.Document.GetElementsByTagName("input")
        
        For Each link As HtmlElement In links
            If link.GetAttribute("value").ToLower().Contains("ok") Then
                link.InvokeMember("click")
            End If
        Next

        Me.tsbtnOK.Enabled = False
        Me.tsbtnAddCost.Enabled = True
    End Sub
    
    Private Sub WebBrowser1_DocumentCompleted(sender As Object, e As WebBrowserDocumentCompletedEventArgs) Handles WebBrowser1.DocumentCompleted
        Dim txtTirag As HtmlElement = WebBrowser1.Document.GetElementById("txtTirag")
        Dim strTirag = txtTirag.GetAttribute("value")
        Dim intTirag = 0
        Dim isInteger = Integer.TryParse(strTirag, intTirag)
        If isInteger Then
            countOfThings = intTirag
        Else
            countOfThings = 0
        End If

        RefreshDiscounts()
    End Sub

    Private Sub tsbtnCost_Click(sender As Object, e As EventArgs) Handles tsbtnCost.Click
        Dim HTML As HtmlDocument = Me.WebBrowser1.Document
        Dim discount As Double = DiscountComboBox.ComboBox.SelectedValue / 100.0
        Me.WebBrowser1.Document.InvokeScript("setDiscount", New Object() {discount})
        For Each link As HtmlElement In HTML.GetElementsByTagName("input")
            If link.OuterHtml.Contains("Считать") Then
                link.InvokeMember("click")
            End If
        Next
        Me.tsbtnOK.Enabled = True
    End Sub

    Private Sub DiscountComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles DiscountComboBox.SelectedIndexChanged
        If needRecalculate Then
            Me.tsbtnOK.Enabled = False
            Me.WebBrowser1.Document.InvokeScript("setDiscount", New Object() {DiscountComboBox.ComboBox.SelectedValue})
        End If
    End Sub

    Private Sub RefreshDiscounts()
        Dim newDiscounts As DataTable
        newDiscounts = discountDataTable.Clone()
        For Each discountRow As DataRow In discountDataTable.Rows
            Dim minDiscountValue As Integer
            Dim maxDiscountValue As Integer

            minDiscountValue = discountRow.Item("minCount")
            maxDiscountValue = discountRow.Item("maxCount")

            If (countOfThings >= minDiscountValue And countOfThings <= maxDiscountValue) Then
                newDiscounts.ImportRow(discountRow)
            End If
        Next

        If (DiscountComboBox.ComboBox.DataSource Is Nothing) Then
            DiscountComboBox.ComboBox.DataSource = newDiscounts
            Exit Sub
        End If

        Dim selectedDataRow As DataRow
        selectedDataRow = DiscountComboBox.ComboBox.DataSource.Rows(DiscountComboBox.ComboBox.SelectedIndex)
        If (isDataTableContainsDiscount(newDiscounts, selectedDataRow)) Then
            needRecalculate = False
            DiscountComboBox.ComboBox.DataSource = newDiscounts
            Dim indexOfSelectedDataRow As Integer
            indexOfSelectedDataRow = getIndexOfDiscount(newDiscounts, selectedDataRow)
            If (indexOfSelectedDataRow >= 0) Then
                DiscountComboBox.ComboBox.SelectedIndex = indexOfSelectedDataRow
            End If
            needRecalculate = True
        Else
            needRecalculate = True
            DiscountComboBox.ComboBox.DataSource = newDiscounts
        End If
    End Sub

    Private Function getIndexOfDiscount(discounts As DataTable, selectedDataRow As DataRow) As Integer
        Dim selectedDataRowName As String = selectedDataRow.Item("name")
        For i As Integer = 0 To discounts.Rows.Count
            Dim dataRow As DataRow = discounts.Rows(i)
            Dim dataRowName As String = dataRow.Item("name")
            If (dataRowName = selectedDataRowName) Then
                Return i
            End If
        Next
        Return -1
    End Function

    Private Function isDataTableContainsDiscount(newDiscounts As DataTable, selectedDataRow As DataRow) As Boolean
        Dim selectedDataRowName As String = selectedDataRow.Item("name")
        For Each dataRow As DataRow In newDiscounts.Rows
            Dim dataRowName As String = dataRow.Item("name")
            If (dataRowName = selectedDataRowName) Then
                Return True
            End If
        Next
        Return False
    End Function

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        ModCallForm.CallForm(sender.tag, 39, 3)
    End Sub

    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs) Handles ToolStripButton2.Click
        ModCallForm.CallForm(sender.tag, 39, 3)
    End Sub

End Class