Imports System.Data.SqlClient
Imports System.Threading
Imports Cassa

Public Class frmOrderPayment

    Public MassPay As Boolean
    Private maxSum As Decimal
    Private cashInputWasEdited As Boolean = False

    Private Sub InputPayment_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        Try
            Dim odaFopl As New SqlDataAdapter("SELECT ID, Name FROM Fopl", mcnnInt)
            Dim dtFopl As New DataTable : odaFopl.Fill(dtFopl)

            If (Not CanMakeOnlinePaymentsInProgram) Then
                dtFopl.Rows.RemoveAt(2)
            End If

            Me.cmbFoplName.DataSource = dtFopl
            Me.cmbFoplName.DisplayMember = "Name"
            Me.cmbFoplName.ValueMember = "ID"
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, appName)
        End Try

        LoadFiscalRegistrars()
        LoadPersons()
        LoadOnlinePaymentsTypes()
        LoadMaxSum()

        Me.cmbFoplName.Enabled = Not nePrinBeznal
    End Sub

    Private Sub LoadOnlinePaymentsTypes()
        Me.OnlinePaymentTypeComboBox.ValueMember = "ID"
        Me.OnlinePaymentTypeComboBox.DisplayMember = "name"

        Try
            Dim sql As String = "SELECT ID, name FROM OnlinePaymentsType WHERE isActive = 1"
            Dim optSqlDataAdapter As New SqlDataAdapter(sql, mcnnInt)
            Dim optDataTable As New DataTable()
            optSqlDataAdapter.Fill(optDataTable)
            OnlinePaymentTypeComboBox.DataSource = optDataTable
        Catch ex As Exception
            MessageBox.Show(ex.Message, appName)
        End Try
    End Sub

    Private Sub LoadFiscalRegistrars()
        Me.CassaComboBox.ValueMember = "ID"
        Me.CassaComboBox.DisplayMember = "shortName"
        Try
            Dim sql As String = "SELECT ID, shortName From FiscalRegistrar WHERE isActive=1"
            Dim cassaSqlDataAdapter As New SqlDataAdapter(sql, mcnnInt)
            Dim cassaDataTable As New DataTable()
            cassaSqlDataAdapter.Fill(cassaDataTable)
            Me.CassaComboBox.DataSource = cassaDataTable

            If (postPrioritet <> 1) Then
                CassaComboBox.Enabled = False
            End If
        Catch excData As Exception
            MessageBox.Show(excData.Message, appName)
        End Try

        Try
            CassaComboBox.SelectedValue = KeySettings.GetValue("IDkassa")
        Catch ex As Exception
            CassaComboBox.SelectedIndex = -1
        End Try
    End Sub

    Private Sub LoadPersons()
        Me.PersonComboBox.ValueMember = "custID"
        Me.PersonComboBox.DisplayMember = "Name"
        Try
            Dim sql As String = "SELECT custID, Name FROM Organizations where KAgent_ID=(SELECT ID FROM KAgents WHERE type_ID = 1) AND closed <> 1"
            Dim organisationsSqlDataAdapter As New SqlDataAdapter(sql, mcnnInt)
            Dim organisationsDataTable As New DataTable()
            organisationsSqlDataAdapter.Fill(organisationsDataTable)
            Me.PersonComboBox.DataSource = organisationsDataTable
        Catch ex As Exception
            MessageBox.Show(ex.Message, appName)
        End Try
    End Sub

    Private Sub LoadMaxSum()
        maxSum = Module1.NonQuery1Scalar("SELECT coalesce(SUM(Orders.cost), 0)-(Select  COALESCE(SUM(summa), 0) FROM Payments WHERE stateID=2 AND costID=" & costID & ") FROM Orders WHERE Orders.costID=" & costID & "")
    End Sub

    Private Sub InputPay(PayCostID As Integer, summa As Decimal, custIDpay As Integer, frID As Integer, organizationID As Integer, onlinePayTypeId As Integer)
        Try
            Dim strSQL$ = "INSERT INTO Payments (summa,data,costID,foplID,custID, emplID, date_PayDoc,numberPayDoc,stateID"
            If (frID <> -1) Then
                strSQL$ &= ",fiscalRegistrarID"
            End If
            If (organizationID <> -1) Then
                strSQL$ &= ",organizationID"
            End If
            If (onlinePayTypeId <> -1) Then
                strSQL$ &= ",onlinePaymentTypeID"
            End If
            strSQL$ &= ") "

            Dim datePayDoc As Date
            if (dtpDataPay.Visible) Then
                datePayDoc = dtpDataPay.Value.Date
            Else 
                datePayDoc = DateTime.Now
            End If

            strSQL$ &= "VALUES (" & Replace(summa, ",", ".") & ",'" & Format(Now(), "s") & "'," & PayCostID & "," & Me.cmbFoplName.SelectedItem(0) & ","
            strSQL$ &= "" & custIDpay & "," & emplID & ",'" & Format(datePayDoc, "s") & "','" & Trim(Me.txtNomerDoc.Text) & "', 2"
            If (frID <> -1) Then
                strSQL$ &= "," & frID
            End If
            If (organizationID <> -1) Then
                strSQL$ &= "," & organizationID
            End If
            If (onlinePayTypeId <> -1) Then
                strSQL$ &= "," & onlinePayTypeId
            End If
            strSQL$ &= ")"

            Dim ocmd As New SqlCommand

            ocmd.CommandText = strSQL
            ocmd.Connection = mcnnInt
            mcnnInt.Open()
            ocmd.ExecuteNonQuery()
        Catch excp As Exception
            MsgBox("Оплата НЕ произведена", MessageBoxIcon.Error, appName)
            MessageBox.Show(excp.Message, appName)
            Exit Sub
        Finally
            mcnnInt.Close()
        End Try
    End Sub

    Private Sub cmbFoplName_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cmbFoplName.SelectedIndexChanged
        If Me.cmbFoplName.SelectedItem(0) = 1 Then
            Me.ShortChangePanel.Visible = True
            Me.OnlinePaymentTypeLabel.Visible = False
            Me.OnlinePaymentTypeComboBox.Visible = False
            Me.CassaLabel.Visible = True
            Me.CassaComboBox.Visible = True
            Me.PersonLabel.Visible = False
            Me.PersonComboBox.Visible = False
            Me.Label3.Visible = False
            Me.Label4.Visible = False
            Me.dtpDataPay.Visible = False
            Me.txtNomerDoc.Visible = False
        ElseIf (Me.cmbFoplName.SelectedItem(0) = 2) Then
            Me.ShortChangePanel.Visible = False
            Me.OnlinePaymentTypeLabel.Visible = False
            Me.OnlinePaymentTypeComboBox.Visible = False
            Me.CassaLabel.Visible = False
            Me.CassaComboBox.Visible = False
            Me.PersonLabel.Visible = True
            Me.PersonComboBox.Visible = True
            Me.Label3.Visible = True
            Me.Label4.Text = "Номер"
            Me.Label4.Visible = True
            Me.dtpDataPay.Visible = True
            Me.txtNomerDoc.Visible = True
        Else
            Me.ShortChangePanel.Visible = False
            Me.OnlinePaymentTypeLabel.Visible = True
            Me.OnlinePaymentTypeComboBox.Visible = True
            Me.CassaLabel.Visible = False
            Me.CassaComboBox.Visible = False
            Me.PersonLabel.Visible = False
            Me.PersonComboBox.Visible = False
            Me.Label3.Visible = True
            Me.Label4.Text = "Номер транзакции"
            Me.Label4.Visible = True
            Me.dtpDataPay.Visible = True
            Me.txtNomerDoc.Visible = True
        End If
    End Sub

    Private Sub OkButton_Click(sender As Object, e As EventArgs) Handles OkButton.Click
        Dim summa As Decimal = ConvertTextToDecimal(nudPay.Text)
        If summa = 0 Then
            MsgBox("Некорректная сумма платежа.", MsgBoxStyle.Information, appName)
            nudPay.Focus()
            Exit Sub
        End If

        If MassPay = False Then
            If Module1.NonQuery1Scalar("SELECT COALESCE(SUM(cost), 0)-(SELECT COALESCE(SUM(summa), 0) FROM Payments WHERE stateID=2 AND costID=" & costID & ") FROM Orders WHERE costID=" & costID & "") < summa Then
                MsgBox("Некорректная сумма платежа.", MsgBoxStyle.Information, appName)
                Me.nudPay.Focus()
                Exit Sub
            End If

            If Me.cmbFoplName.SelectedValue = 1 Then 'nal
                If (CassaComboBox.SelectedValue Is Nothing) Then
                    MessageBox.Show(Me, "Не установлены настройки ФР.", appName)
                    Exit Sub
                End If

                Dim isVirtual = Module1.NonQuery1ScalarBool("SELECT isVirtual FROM FiscalRegistrar WHERE ID=" & CassaComboBox.SelectedValue)
                Dim orgId = Module1.NonQueryScalarInt("SELECT organizationID FROM FiscalRegistrar WHERE ID=" & CassaComboBox.SelectedValue)

                If (isVirtual) Then
                    InputPay(costID, summa, custID, CassaComboBox.SelectedValue, orgId, -1)
                Else 'реальная касса
                    Try
                        Dim isConnect As Boolean = KeySettings.GetValue("connectToFR")
                        If (Not isConnect) Then
                            MessageBox.Show(Me, "Касса не подключена.", appName)
                            Exit Sub
                        End If
                    Catch ex As Exception
                        MessageBox.Show(Me, "Касса не подключена.", appName)
                        Exit Sub
                    End Try

                    If postPrioritet <> 1 Then
                        Try
                            Dim cassaPassword As Integer = CInt(Module1.NonQuery1ScalarString("SELECT password FROM FiscalRegistrar WHERE ID=" & CassaComboBox.SelectedValue))
                            Dim cassaComPort As Integer = Module1.NonQueryScalarInt("SELECT comPort FROM FiscalRegistrar WHERE ID=" & CassaComboBox.SelectedValue)
                            Dim cassaIp As String = Module1.NonQuery1ScalarString("SELECT computerIP FROM FiscalRegistrar WHERE ID=" & CassaComboBox.SelectedValue)
                            Dim cassa As New Cassa.CassaHelper()
                            
                            Dim tcpCassa As Boolean = KeySettings.GetValue("tcpKassa")
                            If (tcpCassa) Then
                                cassa.Connect(cassaComPort, cassaPassword, cassaIp)
                            Else 
                                cassa.Connect(cassaComPort, cassaPassword)
                            End If
                            
                            cassa.OpenSessionIfRequired()

                            If cassa.State = Global.Cassa.EState.ПринтерВРабочемРежиме Then
                                MsgBox("Касса не в рабочем режиме.", MsgBoxStyle.Information, appName)
                                Me.Close()
                                Exit Sub
                            Else
                                PrintCheck(cassa)
                                cassa.Disconnect()
                                InputPay(costID, summa, custID, CassaComboBox.SelectedValue, orgId, -1)
                            End If
                        Catch oexpData As Exception
                            MsgBox("Касса " + oexpData.Message, MsgBoxStyle.Critical, appName)
                            Exit Sub
                        End Try
                    Else
                        MsgBox("Чек Не будет напечатан.", MsgBoxStyle.Information, appName)
                        InputPay(costID, summa, custID, CassaComboBox.SelectedValue, orgId, -1)
                    End If
                End If
            ElseIf (Me.cmbFoplName.SelectedValue = 2) Then 'безнал
                InputPay(costID, summa, custID, -1, PersonComboBox.SelectedValue, -1)
            Else 'Онлайн платеж
                Dim orgId As Integer = Module1.NonQueryScalarInt("SELECT orgID FROM OnlinePaymentsType WHERE ID=" & OnlinePaymentTypeComboBox.SelectedValue)
                InputPay(costID, summa, custID, -1, orgId, OnlinePaymentTypeComboBox.SelectedValue)
            End If

        Else 'Выполняем массовую оплату заказов 
            Dim separators() As Char = {","c}
            Dim words() As String
            Dim costOrder As Decimal
            Dim sumPay As Decimal = ConvertTextToDecimal(nudPay.Text)

            'разбираем costIDstr в цикле вызываем процедуру оплаты, передавая ей ид заказов и суммы
            words = costIDstr.Split(separators)
            Dim word As String
            For Each word In words
                costOrder = Module1.NonQuery1Scalar("SELECT coalesce(SUM(Orders.cost), 0) FROM Orders WHERE Orders.costID=" & CInt(word) & "")
                If sumPay > costOrder Then
                    InputPay(word, costOrder, Module1.NonQuery1Scalar("SELECT custID FROM Costs WHERE costID=" & CInt(word) & ""), -1, -1, -1)
                    sumPay -= costOrder
                Else
                    InputPay(word, sumPay, Module1.NonQuery1Scalar("SELECT custID FROM Costs WHERE costID=" & CInt(word) & ""), -1, -1, -1)
                    Exit For
                End If
            Next
            MassPay = False
        End If

        Me.Close()
    End Sub

    Private Sub PrintCheck(cassa As CassaHelper)
        Dim summa As Decimal = ConvertTextToDecimal(nudPay.Text)
        Try
            cassa.Beep()
            cassa.Sale(1, summa, ("Оплата заказа " + nomVn))
            Thread.Sleep(TimeSpan.FromSeconds(1))
            cassa.CloseCheck(summa, 0)
            Thread.Sleep(TimeSpan.FromSeconds(1))
        Catch ex As CassaException
            If (cassa.EcrAdvancedMode = 1 Or cassa.EcrAdvancedMode = 2) Then
                Dim checkErrorForm As New PrintCheckErrorForm()
                checkErrorForm.ShowDialog(Me)
                If (checkErrorForm.ResumeCheck) Then
                    PrintCheck(cassa)
                Else
                    cassa.CancelCheck()
                    cassa.Disconnect()
                    Throw ex
                End If
            Else
                Throw ex
            End If
        End Try
    End Sub

    Private Sub nudPay_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles nudPay.MouseDoubleClick
        Me.nudPay.Text = maxSum
    End Sub

    Private Sub nudPay_TextChanged(sender As Object, e As EventArgs) Handles nudPay.TextChanged
        Dim summa = ConvertTextToDecimal(nudPay.Text)
        If (summa > maxSum)
            nudPay.Text = maxSum
        End If
        If (summa < 0)
            nudPay.Text = "0,00"
        End If
        If (Not cashInputWasEdited) Then
            CashInputTextBox.Text = summa
        Else 
            CalculateShortChange()
        End If
    End Sub

    Private Function ConvertTextToDecimal(summaText As String) As Decimal
        summaText = summaText.Replace("."c, ","c)
        Dim summa As Decimal
        summa = Convert.ToDecimal(summaText)
        Return summa
    End Function

    Private Function CharIsCorrect(ch As Char) As Boolean
        If (ch = "1"c) Then Return True
        If (ch = "2"c) Then Return True
        If (ch = "3"c) Then Return True
        If (ch = "4"c) Then Return True
        If (ch = "5"c) Then Return True
        If (ch = "6"c) Then Return True
        If (ch = "7"c) Then Return True
        If (ch = "8"c) Then Return True
        If (ch = "9"c) Then Return True
        If (ch = "0"c) Then Return True
        If (ch = ","c) Then Return True
        If (ch = "."c) Then Return True
        If (ch = Convert.ToChar(Keys.Back)) Then Return True
        Return False
    End Function

    Private Sub CancelButton_Click(sender As Object, e As EventArgs) Handles CancelButton.Click
        Me.Close()
    End Sub

    Private Sub CashInputTextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles CashInputTextBox.KeyPress
        If (CharIsCorrect(e.KeyChar))
            cashInputWasEdited = True
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub CashInputTextBox_TextChanged(sender As Object, e As EventArgs) Handles CashInputTextBox.TextChanged
        CalculateShortChange()
    End Sub

    Private Sub CalculateShortChange()
        Dim amount As Decimal
        Dim introduced As Decimal
        Dim shortChange As Decimal

        amount = ConvertTextToDecimal(nudPay.Text)
        introduced = ConvertTextToDecimal(CashInputTextBox.Text)

        'If (Not Decimal.TryParse(nudPay.Text, amount)) Then
        '    MessageBox.Show(Me, "Значение поля 'Сумма' не является числом!", appName)
        'End If

        'If (Not Decimal.TryParse(CashInputTextBox.Text, introduced)) Then
        '    MessageBox.Show(Me, "Значение поля 'Внесено' не является числом!", appName)
        'End If

        shortChange = introduced - amount
        If (shortChange < 0.0) Then
            ShortChangeValueLabel.Text = "Ошибка!"
            Exit Sub
        End If

        ShortChangeValueLabel.Text = shortChange
    End Sub

    Private Sub nudPay_KeyPress(sender As Object, e As KeyPressEventArgs) Handles nudPay.KeyPress
        If (Not CharIsCorrect(e.KeyChar))
            e.Handled = True
        End If
    End Sub
End Class