Imports System.IO

Public Class fin_InvoiceCard

    Dim noLoad As Boolean
    Public InvoiceKA_ID As Integer

    Private Sub InputExpenses_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
           
            Me.cmbTypeInvoice.Items.Add("Счет №")
            Me.cmbTypeInvoice.Items.Add("Представительские расходы")
                    '  Me.lblPayer.Visible = True
                    '   Me.cmbPayers.Visible = True

            Me.cmbTypeInvoice.SelectedIndex = 0
            Me.Label5.Text = "Статья затрат"


            Dim odaFopl As New SqlClient.SqlDataAdapter("SELECT ID, Name FROM Fopl order by Name", mcnnInt)
            Dim dtFopl As New DataTable : odaFopl.Fill(dtFopl)

            Me.cmbFopl.DataSource = dtFopl
            Me.cmbFopl.DisplayMember = "Name"
            Me.cmbFopl.ValueMember = "ID"

            Dim odaTypeList As New SqlClient.SqlDataAdapter("SELECT ID, Name FROM TypesKAgent order by Name", mcnnInt)
            Dim dtTypeList As New DataTable : odaTypeList.Fill(dtTypeList)

            noLoad = True

            Me.cmbTypeCompany.DataSource = dtTypeList 'Связать данные со списком
            Me.cmbTypeCompany.DisplayMember = "Name"
            Me.cmbTypeCompany.ValueMember = "ID"
            Me.cmbTypeCompany.SelectedIndex = 2
            noLoad = False
        Catch ex As System.Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, appName)
        End Try
    End Sub

    Private Sub LoadSuplayers(strFind As String)
        Dim strSQLfind$ = Nothing

        Try
            If Me.txtFindKA.Text <> "Контрагент" Then
                strSQLfind$ = "SELECT ID, name FROM KAgents WHERE type_ID=" & Me.cmbTypeCompany.SelectedItem(0) & " AND name LIKE '%" & strFind & "%' order by Name"
            Else
                strSQLfind$ = "SELECT ID, name FROM KAgents WHERE type_ID=" & Me.cmbTypeCompany.SelectedItem(0) & " order by Name"
            End If

            Dim odaPartList As New SqlClient.SqlDataAdapter(strSQLfind, mcnnInt)
            Dim dtPartList As New DataTable : odaPartList.Fill(dtPartList)

            Me.cmbKAgent.DataSource = dtPartList 'Связать данные со списком
            Me.cmbKAgent.DisplayMember = "Name"
            Me.cmbKAgent.ValueMember = "ID"
        Catch oexpData As System.SystemException
            MsgBox(oexpData.Message, MsgBoxStyle.Critical, appName)
        End Try
    End Sub

    Private Sub loadOrganizations()
        Try
            Dim odaPartList As New SqlClient.SqlDataAdapter("SELECT custID, Name FROM Organizations WHERE closed=0 AND KAgent_ID=" & Me.cmbKAgent.SelectedItem(0) & " order by Name", mcnnInt)
            Dim dtPartList As New DataTable : odaPartList.Fill(dtPartList)

            Me.cmbOrganizations.DataSource = dtPartList 'Связать данные со списком
            Me.cmbOrganizations.DisplayMember = "Name"
            Me.cmbOrganizations.ValueMember = "custID"
        Catch oexpData As System.SystemException
            MsgBox(oexpData.Message, MsgBoxStyle.Critical, appName)
        End Try
    End Sub

    Private Sub tsbtnOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbtnOK.Click
        Try
            If Me.nudAccount.Value = 0 Then
                MsgBox("Некорректная сумма.", MessageBoxIcon.Error, appName)
                Exit Sub
            End If

            If Me.cmbFopl.SelectedIndex = -1 Then
                MsgBox("Выбери форму оплаты.", MessageBoxIcon.Error, appName)
                Me.cmbFopl.Focus()
                Exit Sub
            End If

            If Me.cmbKAgent.SelectedIndex = -1 Then
                MsgBox("Выбери поставщика.", MsgBoxStyle.Critical, appName)
                Exit Sub
            End If

            If Me.cmbFopl.SelectedItem(0) <> 1 Then 'Безнал
                If Me.cmbOrganizations.SelectedIndex = -1 Then
                    MsgBox("Выбери юридическое лицо- получатель платежа.", MsgBoxStyle.Information, appName)
                    Me.cmbOrganizations.Focus()
                    Exit Sub
                Else
                    If Me.cmbPayers.SelectedIndex = -1 Then
                        MsgBox("Выбери юридическое лицо- плательщик.", MsgBoxStyle.Information, appName)
                        Me.cmbPayers.Focus()
                        Exit Sub
                    Else
                        If Me.txtnumberInvoice.Text = Nothing Or Me.txtnumberInvoice.Text = "Введите_номер_счета" Then
                            MsgBox("Введите номер счета.", MessageBoxIcon.Error, appName)
                            Me.txtnumberInvoice.Focus()
                            Exit Sub
                        Else
                            InvoiceKA_ID = CreateInvoice_KA("")
                        End If
                    End If
                End If
            Else
                InvoiceKA_ID = CreateInvoice_KA_cash("")

                '****************провести оплату счета ТЗ3 МДМ
                Try
                    If Me.cmbOrganizations.SelectedIndex <> -1 Then
                        If Me.cmbDescription.SelectedIndex <> -1 Then 'статья затрат определена
                            Module1.NonQuery1("INSERT INTO fin_ManyOut (amount,office_ID,description,org_ID,fopl_ID,invoiceKA_ID,raznos,datetrans) VALUES (" & Replace(Me.nudAccount.Value, ",", ".") & "," & ofID & ",'" & Me.cmbDescription.Text & "'," & Me.cmbOrganizations.SelectedItem(0) & ",1," & InvoiceKA_ID & ",1,'" & Now.Date & "')")
                        Else
                            Module1.NonQuery1("INSERT INTO fin_ManyOut (amount,office_ID,description,org_ID,fopl_ID,invoiceKA_ID,raznos,datetrans) VALUES (" & Replace(Me.nudAccount.Value, ",", ".") & "," & ofID & ",'" & Me.cmbDescription.Text & "'," & Me.cmbOrganizations.SelectedItem(0) & ",1," & InvoiceKA_ID & ",0,'" & Now.Date & "')")
                        End If

                    Else
                        If Me.cmbDescription.SelectedIndex <> -1 Then 'статья затрат определена
                            Module1.NonQuery1("INSERT INTO fin_ManyOut (amount,office_ID,description,fopl_ID,invoiceKA_ID,raznos,datetrans) VALUES (" & Replace(Me.nudAccount.Value, ",", ".") & "," & ofID & ",'" & Me.cmbDescription.Text & "',1," & InvoiceKA_ID & ",1,'" & Now.Date & "') ")
                        Else
                            Module1.NonQuery1("INSERT INTO fin_ManyOut (amount,office_ID,description,fopl_ID,invoiceKA_ID,raznos,datetrans) VALUES (" & Replace(Me.nudAccount.Value, ",", ".") & "," & ofID & ",'" & Me.cmbDescription.Text & "',1," & InvoiceKA_ID & ",0,'" & Now.Date & "') ")
                        End If

                    End If

                    Dim cmd As New SqlClient.SqlCommand

                    cmd.Connection = mcnnInt
                    cmd.CommandText = "sp_InvoicePay"
                    cmd.CommandType = CommandType.StoredProcedure

                    cmd.Parameters.Add(New SqlClient.SqlParameter("@ID", SqlDbType.Int))
                    cmd.Parameters("@ID").Value = InvoiceKA_ID

                    cmd.Parameters.Add(New SqlClient.SqlParameter("@datePay", SqlDbType.Date))
                    cmd.Parameters("@datePay").Value = Format(Now.Date, "s") 'Format(Now().Date, "s")

                    cmd.Parameters.Add(New SqlClient.SqlParameter("@summa", SqlDbType.Decimal))
                    cmd.Parameters("@summa").Value = Me.nudAccount.Value

                    cmd.Parameters.Add(New SqlClient.SqlParameter("@description", SqlDbType.NVarChar))
                    cmd.Parameters("@description").Value = Trim(Me.cmbDescription.Text)

                    mcnnInt.Open()
                    cmd.ExecuteNonQuery()
                    mcnnInt.Close()

                    If Me.cmbDescription.SelectedIndex <> -1 Then 'статья затрат определена
                        Module1.NonQuery1("INSERT INTO fin_Expenses (amount,dateExpens,SettlementPeriod,ID_ArtExpenses,description,invKAID) VALUES (" & Replace(Me.nudAccount.Value, ",", ".") & ",'" & Now.Date & "',1," & Me.cmbDescription.SelectedItem(0) & ",''," & InvoiceKA_ID & ")")
                    End If

                Catch excp As System.Exception
                    MessageBox.Show(excp.Message, appName)
                End Try
            End If

            destinationPath = paramFileStoragePath + "a-" + CStr(InvoiceKA_ID) + "-" + System.IO.Path.GetFileName(Me.txtFIle.Text)

            Dim mForm As New Form

            mForm.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
            mForm.Text = "Сохраняю файл счета"

            Dim elLabel As New Label

            elLabel.Font = New System.Drawing.Font("Tahoma", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
            elLabel.AutoSize = True
            elLabel.Text = "Сохраняю файл счета." & Chr(13) & "Ничего не нажимайте пока не закроется это окно." & Chr(13) & "Окно закроется автоматически."
            mForm.Controls.Add(elLabel)

            Dim pb As New ProgressBar

            mForm.Controls.Add(pb)
            mForm.MaximizeBox = False

            mForm.Show()

            If Not String.IsNullOrEmpty(sFilePath1) Then
                System.IO.File.Copy(sFilePath1, destinationPath, True) 'копируем файл. Если есть, переписываем - True

                Module1.NonQuery1("UPDATE Invoices_KA SET linkToFile='" & destinationPath & "' WHERE ID=" & InvoiceKA_ID & "")
            End If

            mForm.Close()
        Catch ex As System.Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, appName)
            Exit Sub
        End Try

        Me.Close()
    End Sub

    Function CreateInvoice_KA(ByVal strSQL As String) As Integer 'счет безнальный
        Dim cmd As New SqlClient.SqlCommand

        Try
            cmd.Connection = mcnnInt
            cmd.CommandText = "sp_Invoice_KA_create"
            cmd.CommandType = CommandType.StoredProcedure
            'Описываем параметры
            cmd.Parameters.Add(New SqlClient.SqlParameter("@KA_ID", SqlDbType.Int))
            cmd.Parameters("@KA_ID").Value = Me.cmbKAgent.SelectedItem(0)

            cmd.Parameters.Add(New SqlClient.SqlParameter("@orgID", SqlDbType.Int))
            cmd.Parameters("@orgID").Value = Me.cmbOrganizations.SelectedItem(0)

            cmd.Parameters.Add(New SqlClient.SqlParameter("@numberInvoice", SqlDbType.NVarChar))
            cmd.Parameters("@numberInvoice").Value = Trim(Me.txtnumberInvoice.Text)

            cmd.Parameters.Add(New SqlClient.SqlParameter("@account", SqlDbType.Decimal))
            cmd.Parameters("@account").Value = Me.nudAccount.Value

            cmd.Parameters.Add(New SqlClient.SqlParameter("@dateInvoice", SqlDbType.Date))
            cmd.Parameters("@dateInvoice").Value = Format(Me.dtpdateInvoice.Value.Date, "s")

            cmd.Parameters.Add(New SqlClient.SqlParameter("@description", SqlDbType.NVarChar))
            cmd.Parameters("@description").Value = Me.cmbDescription.Text

            cmd.Parameters.Add(New SqlClient.SqlParameter("@signFopl", SqlDbType.Int))
            cmd.Parameters("@signFopl").Value = Me.cmbFopl.SelectedItem(0)


            cmd.Parameters.Add(New SqlClient.SqlParameter("@stavkaNDS", SqlDbType.Int))
            cmd.Parameters("@stavkaNDS").Value = Val(Me.cmbStavkaNDS.Text)

            cmd.Parameters.Add(New SqlClient.SqlParameter("@summaNDS", SqlDbType.Decimal))
            cmd.Parameters("@summaNDS").Value = Me.nudNDSsumma.Value


            If costID <> 0 Then
                cmd.Parameters.Add(New SqlClient.SqlParameter("@order_ID", SqlDbType.Int))
                cmd.Parameters("@order_ID").Value = costID
            End If

            cmd.Parameters.Add(New SqlClient.SqlParameter("@emplID", SqlDbType.Int))
            cmd.Parameters("@emplID").Value = emplID

            If Me.dtpDatePlanPay.Visible = True Then
                cmd.Parameters.Add(New SqlClient.SqlParameter("@datePlanPay", SqlDbType.Date))
                cmd.Parameters("@datePlanPay").Value = Me.dtpDatePlanPay.Value.Date
            End If

            '********доб офис
            cmd.Parameters.Add(New SqlClient.SqlParameter("@payer", SqlDbType.Int))
            cmd.Parameters("@payer").Value = Me.cmbPayers.SelectedItem(0)

            If Me.cmbPrognoz.Visible = True Then
                cmd.Parameters.Add(New SqlClient.SqlParameter("@invKA_ID", SqlDbType.Int))
                cmd.Parameters("@invKA_ID").Value = Me.cmbPrognoz.SelectedItem(0)
            End If

            mcnnInt.Open()

            Return cmd.ExecuteScalar
        Catch excp As System.Exception
            MessageBox.Show(excp.Message, appName)
            Exit Function
        Finally
            mcnnInt.Close()
        End Try
    End Function

    Function CreateInvoice_KA_cash(ByVal strSQL As String) As Integer
        Dim cmd As New SqlClient.SqlCommand

        Try
            cmd.Connection = mcnnInt
            cmd.CommandText = "sp_Invoice_KA_create_cash"
            cmd.CommandType = CommandType.StoredProcedure
            'Описываем параметры
            cmd.Parameters.Add(New SqlClient.SqlParameter("@KA_ID", SqlDbType.Int))
            cmd.Parameters("@KA_ID").Value = Me.cmbKAgent.SelectedItem(0)

            If Me.cmbOrganizations.SelectedIndex <> -1 Then
                cmd.Parameters.Add(New SqlClient.SqlParameter("@orgID", SqlDbType.Int))
                cmd.Parameters("@orgID").Value = Me.cmbOrganizations.SelectedItem(0)
            End If

            cmd.Parameters.Add(New SqlClient.SqlParameter("@numberInvoice", SqlDbType.NVarChar))
            cmd.Parameters("@numberInvoice").Value = Trim(Me.txtnumberInvoice.Text)

            cmd.Parameters.Add(New SqlClient.SqlParameter("@account", SqlDbType.Decimal))
            cmd.Parameters("@account").Value = Me.nudAccount.Value

            cmd.Parameters.Add(New SqlClient.SqlParameter("@dateInvoice", SqlDbType.Date))
            cmd.Parameters("@dateInvoice").Value = Format(Me.dtpdateInvoice.Value.Date, "s")

            cmd.Parameters.Add(New SqlClient.SqlParameter("@description", SqlDbType.NVarChar))
            cmd.Parameters("@description").Value = Me.cmbDescription.Text

            If costID <> 0 Then
                cmd.Parameters.Add(New SqlClient.SqlParameter("@order_ID", SqlDbType.Int))
                cmd.Parameters("@order_ID").Value = costID
            End If

            cmd.Parameters.Add(New SqlClient.SqlParameter("@emplID", SqlDbType.Int))
            cmd.Parameters("@emplID").Value = emplID

            cmd.Parameters.Add(New SqlClient.SqlParameter("@signFopl", SqlDbType.Int))
            cmd.Parameters("@signFopl").Value = Me.cmbFopl.SelectedItem(0)

            If Me.cmbPrognoz.Visible = True Then
                cmd.Parameters.Add(New SqlClient.SqlParameter("@invKA_ID", SqlDbType.Int))
                cmd.Parameters("@invKA_ID").Value = Me.cmbPrognoz.SelectedItem(0)
            End If

            '********доб офис
            cmd.Parameters.Add(New SqlClient.SqlParameter("@officeID", SqlDbType.Int))
            cmd.Parameters("@officeID").Value = ofID

            If Me.dtpDatePlanPay.Visible = True Then
                cmd.Parameters.Add(New SqlClient.SqlParameter("@datePlanPay", SqlDbType.Date))
                cmd.Parameters("@datePlanPay").Value = Me.dtpDatePlanPay.Value.Date
            End If

            mcnnInt.Open()
            Return cmd.ExecuteScalar
        Catch excp As System.Exception
            MessageBox.Show(excp.Message, appName)
            Exit Function
        Finally
            mcnnInt.Close()
        End Try
    End Function

    Private Sub tsbtnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbtnExit.Click
        Me.Close()
    End Sub

    Private Sub cmbTypeCompany_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbTypeCompany.SelectedValueChanged
        If sender.SelectedIndex <> -1 Then
            LoadSuplayers("")

            Me.txtFindKA.Focus()
            Me.cmbKAgent.Enabled = True

            ' Me.cmbKAgent.Focus()
        Else
            Me.cmbKAgent.Enabled = False
        End If

        If noLoad = False Then
            ' LoadSuplayers()
        End If
    End Sub

    Private Sub cmbSuplayer_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cmbKAgent.SelectedIndexChanged
        If sender.SelectedIndex <> -1 Then
            loadOrganizations()

            Me.cmbOrganizations.Enabled = True
            '   Me.cmbOrganizations.Focus()
        Else
            Me.cmbOrganizations.Enabled = False
        End If
    End Sub

    Private Sub cmbTypeInvoice_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cmbTypeInvoice.SelectedIndexChanged
        Select Case Me.cmbTypeInvoice.SelectedIndex
            Case Is = 0 'счет
                Me.txtnumberInvoice.Visible = True
                Me.txtnumberInvoice.Text = "Введите_номер_счета"

                If costID <> Nothing Then
                    Me.cmbDescription.DataSource = Nothing
                    Me.cmbDescription.Text = "К заказу " & Trim(Module1.NonQuery1ScalarString("SELECT nomerVN FROM Costs WHERE costID=" & costID & ""))
                Else
                    Dim odaExp As New SqlClient.SqlDataAdapter("SELECT ID, name FROM fin_ArticlesExpenses order by name", mcnnInt)
                    Dim dtExp As New DataTable : odaExp.Fill(dtExp)

                    Me.cmbDescription.DataSource = dtExp
                    Me.cmbDescription.DisplayMember = "name"
                    Me.cmbDescription.ValueMember = "ID"
                    Me.cmbDescription.SelectedIndex = -1
                End If

                Me.txtnumberInvoice.SelectAll()
                Me.txtnumberInvoice.Focus()
                Me.btnAddFile.Visible = True
                Me.txtFIle.Visible = True

            Case Is = 1
                Me.txtnumberInvoice.Visible = False
                Me.txtnumberInvoice.Text = sender.text
                Me.btnAddFile.Visible = False
                Me.txtFIle.Visible = False
                Me.Label3.Visible = False
                Me.cmbOrganizations.Visible = False
        End Select
    End Sub

    Dim destinationPath As String
    Dim sourcePath As String
    Dim sFilePath1 As String = ""
    Dim fileNameUser As String

    Private Sub dtpdateInvoice_ValueChanged(sender As System.Object, e As System.EventArgs) Handles dtpdateInvoice.ValueChanged
        Me.nudAccount.Focus()
    End Sub

    Private Sub cmbFopl_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cmbFopl.SelectedIndexChanged
        Dim strSQL$ = Nothing

        If Me.cmbFopl.SelectedIndex = 0 Then
            Me.cmbTypeInvoice.SelectedIndex = 0

            strSQL = "SELECT custID as ID, shortName as Name FROM Organizations WHERE KAgent_ID=(SELECT ID FROM KAgents WHERE type_ID=1 AND closed=0)"
            Me.lblPayer.Text = "Организация"
            Me.lblPayer.Visible = True
            Me.cmbPayers.Visible = True
        Else
            Me.cmbTypeInvoice.SelectedIndex = 1

            strSQL = "SELECT ID, Name FROM Offices"

            Me.LabelNDS1.Visible = False
            Me.LabelNDS2.Visible = False
            Me.cmbStavkaNDS.Visible = False
            Me.nudNDSsumma.Visible = False

            Me.lblPayer.Visible = False
            Me.cmbPayers.Visible = False
        End If

        Dim odaOrg As New SqlClient.SqlDataAdapter(strSQL, mcnnInt)
        Dim dtOrg As New DataTable : odaOrg.Fill(dtOrg)

        Me.cmbPayers.DataSource = dtOrg    'Связать данные со списком
        Me.cmbPayers.DisplayMember = "Name"
        Me.cmbPayers.ValueMember = "ID"
        Me.cmbPayers.SelectedIndex = -1
    End Sub

    Private Sub cmbPayers_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cmbPayers.SelectedIndexChanged
        Me.btnAddFile.Focus()
    End Sub

    Private Sub btnAddFile_Click(sender As System.Object, e As System.EventArgs) Handles btnAddFile.Click
        If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
            sFilePath1 = OpenFileDialog1.FileName
            fileNameUser = System.IO.Path.GetFileName(OpenFileDialog1.FileName)
            Me.txtFIle.Text = fileNameUser
        Else
            Exit Sub
        End If
    End Sub

    Private Sub ДобавитьПоставщикаToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ДобавитьПоставщикаToolStripMenuItem.Click
        addsup = True : ModCallForm.CallForm("Контрагенты", 9, 3)
    End Sub

    Private Sub ДобавитьЮрлицоToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ДобавитьЮрлицоToolStripMenuItem.Click
        openFromKA = True

        If Me.cmbKAgent.SelectedIndex <> -1 Then
            custID = Me.cmbKAgent.SelectedItem(0)

            Dim frmSelect As frmOrganizations

            frmSelect = New frmOrganizations
            frmSelect.ShowDialog()
        Else
            MsgBox("Не выбран контрагент.", MsgBoxStyle.Critical, appName)
        End If
    End Sub

    Private Sub nudAccount_GotFocus(sender As Object, e As EventArgs) Handles nudAccount.GotFocus
        sender.Select(0, (Len(sender.Value.ToString)))
    End Sub

    Private Sub nudAccount_MouseClick(sender As Object, e As MouseEventArgs) Handles nudAccount.MouseClick
        sender.Select(0, (Len(sender.Value.ToString)))
    End Sub

    Private Sub nudX_MouseClick(sender As Object, e As MouseEventArgs)
        sender.Select(0, (Len(sender.Value.ToString)))
    End Sub

    Private Sub nudY_MouseClick(sender As Object, e As MouseEventArgs)
        sender.Select(0, (Len(sender.Value.ToString)))
    End Sub

    Private Sub txtFindKA_TextChanged(sender As Object, e As EventArgs) Handles txtFindKA.TextChanged
        LoadSuplayers(Me.txtFindKA.Text)
    End Sub

End Class