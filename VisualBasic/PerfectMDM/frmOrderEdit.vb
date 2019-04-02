
Imports System.Data.SqlClient

Public Class frmOrderEdit
    Dim odaCostIndiv As SqlDataAdapter
    Dim dtCostIndiv As New DataTable
    Dim mdrCostIndiv As DataRow
    Dim allowSelectEmpl As Boolean = False

    Public orderEdit_statusCurr%

#Region " Загрузка формы редактирования заказа "
    Private Sub frmOrderEdit_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        If addPerson = True Then
            LoadPersons(Me.cmbCustomer.SelectedItem(0))
        End If
        If (addOrganization) Then
            LoadOrganizations(Me.cmbCustomer.SelectedItem(0))
        End If

        Me.dtpDateOfProductionReady.Visible = True
        Me.lblDateOfProductionReady.Visible = True
        Me.dtpDateOfIssue.Visible = Not ProductionDate ' выдачу не видит
        Me.lblDateOfIssue.Visible = Not ProductionDate
    End Sub

    Private Sub LoadKA(sss As String)
        Try
            Dim strSQL$

            If sss <> Nothing Then
                strSQL = "SELECT ID, Name FROM KAgents Where Name Like '" & sss & "%' order by Name"
            Else
                strSQL = "SELECT ID, Name FROM KAgents order by Name"
            End If

            Dim odaPartList As New SqlDataAdapter(strSQL, mcnnInt)
            Dim dtPartList As New DataTable : odaPartList.Fill(dtPartList)

            Me.cmbCustomer.DataSource = dtPartList
            Me.cmbCustomer.DisplayMember = "Name"
            Me.cmbCustomer.ValueMember = "ID"

            If sss = Nothing Then
                Me.cmbCustomer.SelectedValue = custID
            End If
        Catch oexpData As Exception
            MsgBox(oexpData.Message, MsgBoxStyle.Critical, appName)
        End Try
    End Sub
#End Region

#Region " Сохранить изменения "
    Private Sub SaveRecord()
        If Me.dtpDateOfProductionReady.Value >= Me.dtpDateOfIssue.Value Then
            MsgBox("Выдача ранее производства невозможна.", MsgBoxStyle.Critical, appName) : Me.dtpDateOfProductionReady.Focus() : Exit Sub
        End If

        If Me.dtpDateOfLayoutReady.Value > Me.dtpDateOfProductionReady.Value Or Me.dtpDateOfLayoutReady.Value >= Me.dtpDateOfIssue.Value Then
            MsgBox("Выдача ранее согласования макета невозможна", MsgBoxStyle.Critical, appName) : Me.dtpDateOfProductionReady.Focus() : Exit Sub
        End If

        If Me.cmbOurOrganization.SelectedIndex = -1 Then
            MsgBox("Не задана организация", MsgBoxStyle.Critical, appName) : Me.cmbOurOrganization.Focus() : Exit Sub
        End If

        If (Me.cmbContactPerson.SelectedIndex = -1) Then
            MsgBox("Не задано контактное лицо", MsgBoxStyle.Critical, appName) : Me.cmbContactPerson.Focus() : Exit Sub
        End If

        If (Me.cmbCommentForIssue.Text Is Nothing Or Me.cmbCommentForIssue.Text = "") Then
            MsgBox("Не задан комментарий к оплате", MsgBoxStyle.Critical, appName) : Me.cmbCommentForIssue.Focus() : Exit Sub
        End If

        If (Me.cmbIssuePlace.SelectedIndex = -1) Then
            MsgBox("Не задано поле 'Выдача'", MsgBoxStyle.Critical, appName) : Me.cmbIssuePlace.Focus() : Exit Sub
        End If

        mdrCostIndiv.BeginEdit()

        Try
            mdrCostIndiv("dataOut") = Me.dtpDateOfIssue.Value
            mdrCostIndiv("dataMaketOut") = Me.dtpDateOfLayoutReady.Value
            mdrCostIndiv("productionDate") = Me.dtpDateOfProductionReady.Value
            mdrCostIndiv("emplID") = Me.cmbManager.SelectedItem(0) ' менеджер
            mdrCostIndiv("nomVN2") = Me.cmbCommentForIssue.Text
            mdrCostIndiv("custID") = Me.cmbCustomer.SelectedValue
            mdrCostIndiv("typeCostIndex") = Me.cmbCostType.SelectedIndex '0 Реальный заказ '1 Виртуальный заказ '2 Авансовая оплата
            mdrCostIndiv("marketingID") = Me.cmbOrderSource.SelectedItem(0) 'источник
            mdrCostIndiv("isExpress") = CInt(Me.chkExpressOrder.Checked)
            mdrCostIndiv("issuePlaceID") = cmbIssuePlace.SelectedValue
            mdrCostIndiv("statusID") = orderEdit_statusCurr
            mdrCostIndiv("nomVN3") = txtAdditionalNumber.Text

            If Me.cmbContactPerson.SelectedIndex <> -1 Then
                mdrCostIndiv("emplCust") = Me.cmbContactPerson.SelectedItem(0)  ' менеджер
            End If

            mdrCostIndiv("orgID") = Me.cmbOurOrganization.SelectedItem(0) ' 

            If Me.cmbCustomerPerson.SelectedIndex <> -1 Then
                mdrCostIndiv("custOrgID") = Me.cmbCustomerPerson.SelectedItem(0) ' 
            End If

            mdrCostIndiv.EndEdit()  'Завершить редактировать строку данных

            'создать экземпляр пострителя команды
            Dim ocbCostIndiv As SqlCommandBuilder

            ocbCostIndiv = New SqlCommandBuilder(odaCostIndiv)
            odaCostIndiv.UpdateCommand = ocbCostIndiv.GetUpdateCommand
            odaCostIndiv.Update(dtCostIndiv)
            dtCostIndiv.AcceptChanges()
            odaCostIndiv.UpdateCommand.Connection.Close()

            Me.Close()
        Catch excData As Exception
            MsgBox("error - возможно менеджер или исполнитель заказа уволен - " & excData.Message, MsgBoxStyle.Critical, appName)
            Exit Sub
        End Try
    End Sub
#End Region

    Private Sub СоздатьПредставителяToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles СоздатьПредставителяToolStripMenuItem.Click
        addPerson = True

        custID = Me.cmbCustomer.SelectedItem(0)

        Dim frmSelect As New frmEmplKA
        frmSelect.ShowDialog(Me)
    End Sub

    Private Sub СоздатьЮрЛицоToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles СоздатьЮрЛицоToolStripMenuItem.Click
        addOrganization = True

        custID = Me.cmbCustomer.SelectedItem(0)
        openFromKA = True

        Dim frmSelect As New frmOrganizations
        
        frmSelect.ShowDialog(Me)
    End Sub
    
    Private Sub LoadPersons(ByVal idCust As Integer)
        Try
            Dim odaEmplCust As  New SqlDataAdapter("SELECT emplCustID, lastname FROM EmplCust WHERE custID = " & idCust & " order by lastname ", mcnnInt)
            Dim dtEmplCust As New DataTable : odaEmplCust.Fill(dtEmplCust)
            'Связать данные со списком
            Me.cmbContactPerson.DataSource = dtEmplCust
            Me.cmbContactPerson.DisplayMember = "lastname"
            Me.cmbContactPerson.ValueMember = "emplCustID"
            If addPerson = True Then
                addPerson = False
                Me.cmbContactPerson.SelectedValue = dtEmplCust.Rows(CInt(dtEmplCust.Rows.Count) - 1)("emplCustID")
            End If
        Catch oexpData As Exception
            MsgBox(oexpData.Message, MsgBoxStyle.Critical, appName)
        End Try
    End Sub
    
    Private Sub LoadOrganizations(idCust As Integer)
        Try
            Dim odaCustOrg As New SqlDataAdapter("SELECT custID, Name FROM Organizations WHERE KAgent_ID=" & idCust & " AND closed<>1 order by Name", mcnnInt)
            Dim dtCustOrg As New DataTable : odaCustOrg.Fill(dtCustOrg)

            Me.cmbCustomerPerson.DataSource = dtCustOrg
            Me.cmbCustomerPerson.DisplayMember = "Name"
            Me.cmbCustomerPerson.ValueMember = "custID"
            If (addOrganization = True) Then
                addOrganization = False
            End If
        Catch oexpData As Exception
            MsgBox(oexpData.Message, MsgBoxStyle.Critical, appName)
        End Try
    End Sub

    Private Sub ToolStripButton3_Click(sender As Object, e As EventArgs) Handles ToolStripButton3.Click
        Me.Close()
    End Sub

    Private Sub tsbtnOk_Click(sender As Object, e As EventArgs) Handles tsbtnOk.Click
        SaveRecord()
    End Sub

    Private Sub txtFind_KeyDown(sender As Object, e As KeyEventArgs) Handles txtFindCustomer.KeyDown
        Dim cmd As New SqlCommand : cmd.Connection = mcnnInt
        cmd.CommandText = "[sp_FilterKA]"
        cmd.CommandType = CommandType.StoredProcedure

        Try
            If e.KeyCode = Keys.Enter Then
                If sender.Text = """" Or sender.text = "'" Then
                    Exit Sub
                Else
                    cmd.Parameters.Add(New SqlParameter("@fragment", SqlDbType.NVarChar))
                    cmd.Parameters("@fragment").Value = sender.Text

                    Dim odaKA As New SqlDataAdapter(cmd)
                    Dim dtPartList As New DataTable : odaKA.Fill(dtPartList)

                    Me.cmbCustomer.DataSource = dtPartList
                    Me.cmbCustomer.DisplayMember = "Name"
                    Me.cmbCustomer.ValueMember = "ID"
                End If
                e.Handled = True
            End If
        Catch oexpData As SystemException
            MsgBox(oexpData.Message + "---" + cmd.CommandText, MsgBoxStyle.Critical, appName)
        End Try
    End Sub

    Private Sub cmbCust_SelectedValueChanged(sender As Object, e As EventArgs) Handles cmbCustomer.SelectedValueChanged
        Dim idCust As Integer = Me.cmbCustomer.SelectedItem(0)
        LoadPersons(idCust)
        LoadOrganizations(idCust)
    End Sub

    Private Sub cmbNomVN2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbCommentForIssue.SelectedIndexChanged
        If Me.cmbCommentForIssue.SelectedIndex <> -1 Then
            Me.tsbtnOk.Enabled = True
        End If
    End Sub

    Private Sub frmOrderEdit_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim cmd As New SqlCommand : cmd.Connection = mcnnInt
            cmd.CommandText = "[sp_FilterManager]" 'Загружаем список менеджеров
            cmd.CommandType = CommandType.StoredProcedure
            Dim odaMan As New SqlDataAdapter(cmd)
            Dim dtMan As New DataTable : odaMan.Fill(dtMan)
            Me.cmbManager.DataSource = dtMan
            Me.cmbManager.DisplayMember = "emplLastName"
            Me.cmbManager.ValueMember = "emplID"

            Dim odaMarket As New SqlDataAdapter("SELECT ID, name FROM Reclama order by description", mcnnInt)
            Dim dtMarket As New DataTable : odaMarket.Fill(dtMarket)

            Me.cmbOrderSource.DataSource = dtMarket
            Me.cmbOrderSource.DisplayMember = "Name"
            Me.cmbOrderSource.ValueMember = "ID"

            Dim odaIssuePlaces As New SqlDataAdapter("SELECT ID, name FROM IssuePlace", mcnnInt)
            Dim dtIssuePlaces As New DataTable()
            odaIssuePlaces.Fill(dtIssuePlaces)
            Me.cmbIssuePlace.DisplayMember = "name"
            Me.cmbIssuePlace.ValueMember = "ID"
            Me.cmbIssuePlace.DataSource = dtIssuePlaces

            'Загружаем список организаций
            Dim odaOrg As New SqlDataAdapter("SELECT custID, Name FROM Organizations WHERE KAgent_ID=(SELECT ID FROM KAgents WHERE type_ID=1) AND closed<>1 order by Name", mcnnInt)
            Dim dtOrg As New DataTable : odaOrg.Fill(dtOrg)

            Me.cmbOurOrganization.DataSource = dtOrg
            Me.cmbOurOrganization.DisplayMember = "Name"
            Me.cmbOurOrganization.ValueMember = "custID"

            LoadKA(Nothing)
            LoadPersons(custID)
            LoadOrganizations(custID)

            allowSelectEmpl = True

            odaCostIndiv = New SqlDataAdapter("SELECT * FROM Costs WHERE Costs.costID=" & costID & "", mcnnInt)
            odaCostIndiv.Fill(dtCostIndiv)
            mdrCostIndiv = dtCostIndiv.Rows(0)

            Me.Text = "Редактирование заказа " & CStr(mdrCostIndiv("nomerVN")) & " от " & CStr(mdrCostIndiv("data"))
            Me.dtpDateOfLayoutReady.Value = CDate(mdrCostIndiv("dataMaketOut"))
            Me.dtpDateOfIssue.Value = CDate(mdrCostIndiv("dataOut"))

            Me.dtpDateOfProductionReady.Value = CDate(mdrCostIndiv("productionDate"))

            Me.cmbManager.SelectedValue = mdrCostIndiv("emplID")

            if (mdrCostIndiv("orderClosed") AND postPrioritet <> 1) Then ' Заказ закрыт и пользователь не админ
                cmbManager.Enabled = False
            End If

            Me.cmbOurOrganization.SelectedValue = mdrCostIndiv("orgID")
            Me.cmbOrderSource.SelectedValue = mdrCostIndiv("marketingID")

            If mdrCostIndiv("nomVN2") Is DBNull.Value Then
                Me.cmbCommentForIssue.Text = Nothing
            Else
                Me.cmbCommentForIssue.Text = mdrCostIndiv("nomVN2")
            End If

            If mdrCostIndiv("emplCust") Is DBNull.Value Then
                Me.cmbContactPerson.SelectedIndex = -1
            Else
                Me.cmbContactPerson.SelectedValue = mdrCostIndiv("emplCust")
            End If

            If mdrCostIndiv("custOrgID") Is DBNull.Value Then
                Me.cmbCustomerPerson.SelectedIndex = -1
            Else
                Me.cmbCustomerPerson.SelectedValue = mdrCostIndiv("custOrgID")
            End If

            If Not IsDBNull(mdrCostIndiv("isExpress")) Then
                chkExpressOrder.Checked = mdrCostIndiv("isExpress")
            End If

            If Not IsDBNull(mdrCostIndiv("issuePlaceID")) Then
                cmbIssuePlace.SelectedValue = mdrCostIndiv("issuePlaceID")
            Else
                cmbIssuePlace.SelectedIndex = -1
            End If

            If Not IsDBNull(mdrCostIndiv("nomVN3")) Then
                txtAdditionalNumber.Text = mdrCostIndiv("nomVN3")
            End If

            Select Case mdrCostIndiv("typeCostIndex")
                Case Is = 0
                    Me.cmbCostType.SelectedIndex = 0
                Case Is = 1
                    Me.cmbCostType.SelectedIndex = 1
                Case Is = 2
                    Me.cmbCostType.SelectedIndex = 2
            End Select

            Me.cmbCommentForIssue.Items.Add("безнал")
            Me.cmbCommentForIssue.Items.Add("оплатить полностью")
            Me.cmbCommentForIssue.Items.Add("предоплата")
            Me.cmbCommentForIssue.Items.Add("оплатить остаток")
            Me.cmbCommentForIssue.Items.Add("оплатить доставку")
            Me.cmbCommentForIssue.Items.Add("оплачен")
            Me.cmbCommentForIssue.Items.Add("не требует оплаты")

            If Me.cmbCommentForIssue.Text = Nothing Then
                Me.tsbtnOk.Enabled = False
            End If

            Me.cmbCostType.SelectedIndex = mdrCostIndiv("typeCostIndex")
            If mdrCostIndiv("statusID") = 1 Then
                Me.lblCostType.Visible = True
                Me.cmbCostType.Visible = True
            Else
                Me.lblCostType.Visible = False
                Me.cmbCostType.Visible = False
            End If

            Me.Label6.Text = "Кредитный лимит: " + CStr(Format(NonQuery1Scalar("Select dbo.[kreditVirtMDM](" & custID & ", " & costID & ")"), "C"))
        Catch oexpData As Exception
            MsgBox(oexpData.Message, MsgBoxStyle.Critical, appName)
        End Try
    End Sub
End Class