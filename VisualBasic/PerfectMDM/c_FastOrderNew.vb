Imports System.Data.SqlClient
Imports System.Security.Permissions
Imports System.Threading
Imports Cassa

<PermissionSet(SecurityAction.Demand, Name:="FullTrust")>
<System.Runtime.InteropServices.ComVisibleAttribute(True)>
Public Class c_FastOrderNew
    Dim Itogo@, cost@, prim$
    Dim printCheckDone As Boolean
    Dim countOfThings As Integer = 0
    Dim discountDataTable As DataTable
    Dim needRecalculate As Boolean
    Dim scriptInvoking As Boolean = False

    Dim cassaId As Integer
    Dim cassaIsConnect As Boolean

    Dim total As Decimal
    Dim n As Integer


    Private Sub tsbtnExit_Click_1(sender As Object, e As EventArgs) Handles tsbtnExit.Click
        Me.Close()
    End Sub

    Private Sub mdm_FastOrderNew_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If terminal = True Then
            Application.Exit()
        End If
    End Sub

    Private Sub mdm_FastOrderNew_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DiscountComboBox.ComboBox.DisplayMember = "name"
        DiscountComboBox.ComboBox.ValueMember = "name"

        LoadDiscounts()

        Me.WebBrowser1.ObjectForScripting = Me
        Me.WebBrowser1.Navigate(
            paramUrlCalcFastorder + "/Calculator/?fast=1&empl=" + CStr(emplID) + "&ofID=" + CStr(ofID))
        AddHandler Me.WebBrowser1.Document.Stop, AddressOf Document_Stop
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

    Public Sub PrintCheck()
        printCheckDone = False

        Dim cassa As New Cassa.CassaHelper()
        total = 0

        Dim sql As String = "SELECT ID, comPort, password, computerIP, isVirtual FROM FiscalRegistrar WHERE ID = " & cassaId & ""
        Dim frSqlDataAdapter As New SqlClient.SqlDataAdapter(sql, mcnnInt)
        Dim frDataTable As DataTable = New DataTable()
        frSqlDataAdapter.Fill(frDataTable)

        Dim port As Integer = frDataTable.Rows(0).Item("comPort")
        Dim password As String = frDataTable.Rows(0).Item("password")
        Dim ip As String = frDataTable.Rows(0).Item("computerIP")
        
        Dim tcpCassa As Boolean = KeySettings.GetValue("tcpKassa")

        if (tcpCassa) Then
            cassa.Connect(port, CInt(password), ip)
        Else
            cassa.Connect(port, password)
        End If
        
        cassa.OpenSessionIfRequired()

        Try
            If cassa.State = Global.Cassa.EState.ПринтерВРабочемРежиме Then
                MsgBox(cassa.State, MsgBoxStyle.Critical, appName)
            Else
                cassa.LockPort()
                cassa.Beep()

                Dim table As HtmlElement = Me.WebBrowser1.Document.GetElementsByTagName("table").Item(0)
                Dim rows = table.GetElementsByTagName("tr")
                n = 1


                PrintRows(rows, cassa)


                'For n = 1 To rows.count() - 2
                'Dim cells As HtmlElementCollection = rows(n).GetElementsByTagName("td")

                'If (cells.Count = 0) Then
                'Continue For
                'End If

                'Dim kolvo = cells.Item(0).InnerHtml
                'Dim name = cells.Item(1).InnerHtml
                'Dim cena = cells.Item(2).InnerHtml
                'Dim cenaEd = Math.Round(cena / kolvo, 2)

                'If Len(name) > 35 Then
                'cassa.Sale(kolvo, cenaEd, Microsoft.VisualBasic.Left(name, 35))
                'Else
                'cassa.Sale(kolvo, cenaEd, name)
                'End If

                'total += cena
                'Next

                cassa.CloseCheck(total, 0)

                Thread.Sleep(TimeSpan.FromSeconds(n))
                cassa.UnLockPort()
                printCheckDone = True
                ' cassa.Disconnect()
                '  End If
            End If
        Catch ex As Global.Cassa.CassaException
            If ex.ResultCode = 18 Then
                '  cassa.UnLockPort()
                MsgBox("Касса занята. Попробуйте через минуту1.", MsgBoxStyle.Critical, appName)
            Else
                MsgBox("Ошибка печати!" & Environment.NewLine & "(" & cassa.ResultCode & ") " & cassa.ResultCodeDescription)
            End If
            
            '  Catch oexpData As System.Exception
            '  MsgBox("Касса занята. Попробуйте через минуту2. " + oexpData, MsgBoxStyle.Critical, appName)
        Finally
            cassa.Disconnect()
        End Try
    End Sub

    Private Sub PrintRows(rows As HtmlElementCollection, cassa As CassaHelper)
        Try
            While n <= rows.Count() - 2
                PrintRow(rows, cassa)
                n = n + 1
            End While
        Catch ex As CassaException
            If (cassa.EcrAdvancedMode = 1 Or cassa.EcrAdvancedMode = 2) Then
                Dim checkErrorForm As New PrintCheckErrorForm()
                checkErrorForm.ShowDialog(Me)
                If (checkErrorForm.ResumeCheck) Then
                    PrintRows(rows, cassa)
                Else
                    cassa.CancelCheck()
                    cassa.UnLockPort()
                    Throw ex
                End If
            Else 
                Throw ex
            End If
        End Try
    End Sub

    Private Sub PrintRow(rows As HtmlElementCollection, cassa As CassaHelper)
        Dim cells As HtmlElementCollection = rows(n).GetElementsByTagName("td")

        If (cells.Count = 0) Then
            Exit Sub
        End If

        Dim kolvo = cells.Item(0).InnerHtml
        Dim name = cells.Item(1).InnerHtml
        Dim cena = cells.Item(2).InnerHtml
        Dim cenaEd = Math.Round(cena / kolvo, 2)

        If Len(name) > 35 Then
            cassa.Sale(kolvo, cenaEd, Microsoft.VisualBasic.Left(name, 35))
        Else
            cassa.Sale(kolvo, cenaEd, name)
        End If

        total += cena
    End Sub

    Private Sub DiscountComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles DiscountComboBox.SelectedIndexChanged
        If needRecalculate Then
            scriptInvoking = True
            Me.WebBrowser1.Document.InvokeScript("setDiscount", New Object() {DiscountComboBox.ComboBox.SelectedValue})
        End If
    End Sub

    Private Sub Document_Stop(sender As Object, e As EventArgs)
        If (scriptInvoking) Then
            scriptInvoking = False
            Thread.Sleep(100)
            Me.WebBrowser1.Refresh()
        End If
    End Sub

    Private Sub WebBrowser1_DocumentCompleted(sender As Object, e As WebBrowserDocumentCompletedEventArgs) Handles WebBrowser1.DocumentCompleted
        Dim allHtmlTables As HtmlElementCollection = Me.WebBrowser1.Document.GetElementsByTagName("table")
        WebBrowser1.Document.InvokeScript("setFiscalRegistrarId", New Object() { KeySettings.GetValue("IDkassa") })
        If (allHtmlTables.Count > 0) Then
            Dim table As HtmlElement = allHtmlTables.Item(0)
            Dim rows As HtmlElementCollection = table.GetElementsByTagName("tr")
            If rows.Count() > 2 Then
                Dim newCountOfThings = 0
                Dim n As Integer
                For n = 1 To rows.Count() - 2
                    Dim cells As HtmlElementCollection = rows(n).GetElementsByTagName("td")

                    If (cells.Count = 0) Then
                        Continue For
                    End If

                    Dim kolvo As Integer
                    Dim isInteger = Integer.TryParse(cells.Item(0).InnerHtml, kolvo)
                    If isInteger Then
                        newCountOfThings += kolvo
                    End If
                Next
                countOfThings = newCountOfThings
            Else
                countOfThings = 0
            End If
            RefreshDiscounts()
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

    Private Sub tsbtnOK_Click(sender As Object, e As EventArgs) Handles tsbtnOK.Click
        Try
            cassaId = KeySettings.GetValue("IDkassa")
            cassaIsConnect = KeySettings.GetValue("connectToFR")
        Catch ex As Exception
            MessageBox.Show(Me, "Не установлены настройки ФР.", appName)
            Exit Sub
        End Try

        If (Not cassaIsConnect Or cassaId <= 0) Then
            MessageBox.Show(Me, "Не установлены настройки ФР.", appName)
            Exit Sub
        End If

        Dim isVirtual = Module1.NonQuery1ScalarBool("SELECT isVirtual FROM FiscalRegistrar WHERE ID=" & cassaId)
        If (isVirtual) Then
            MessageBox.Show(Me, "Нельзя создать быстрый заказ через виртуальную кассу!", appName)
            Exit Sub
        End If

        Dim table As HtmlElement = Me.WebBrowser1.Document.GetElementsByTagName("table").Item(0)
        Dim rows = table.GetElementsByTagName("tr")

        If rows.count() = 2 Then 'Me.dtData.Rows.Count = 0 в таблице со страницы нет записей
            MsgBox("Пустой заказ не может быть создан.", MsgBoxStyle.Critical, appName)
        Else
            '  Try
            If kassaAllow = False Then 'не приним оплату
                'Создать не оплаченный заказ!!! создает Андрей
                Me.WebBrowser1.Document.InvokeScript("saveOrderWOpay")
            Else
                If postPrioritet <> 1 Then
                    PrintCheck()
                    If printCheckDone = True Then
                        Me.WebBrowser1.Document.InvokeScript("saveOrder")
                        Me.Close()
                    Else
                        MsgBox("Чек Не будет напечатан и заказ не будет создан.", MsgBoxStyle.Information, appName)
                        Exit Sub
                    End If
                Else
                    ' Me.WebBrowser1.Document.InvokeScript("saveOrder")
                    'Me.Close()

                    MsgBox("Чек Не будет напечатан и заказ не будет создан.", MsgBoxStyle.Information, appName)
                End If
            End If
        End If
    End Sub

    Private Sub tsbtnSetPrice_Click(sender As Object, e As EventArgs) Handles tsbtnSetPrice.Click
        If _
            emplID = Module1.NonQuery1Scalar("SELECT curator_ID FROM Services WHERE ID=" & serviceID & "") Or
            postPrioritet = 1 Then
            ModCallForm.CallForm("Быстрый заказ", 2, 2)
        Else
            MsgBox("Доступ запрещен", MsgBoxStyle.Critical, appName)
        End If
    End Sub
End Class