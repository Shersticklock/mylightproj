Public Class frmServices

    Dim modaLookupData As SqlClient.SqlDataAdapter
    Dim dtData As DataTable
    Dim mdrPersonIndiv As DataRow

    Dim mblnAdd As Boolean


    Private Sub frmServices_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Dim cmd As New SqlClient.SqlCommand

        cmd.Connection = mcnnInt
        cmd.CommandText = "[sp_FilterAuthorKA]"
        cmd.CommandType = CommandType.StoredProcedure

        Dim odaMan As New SqlClient.SqlDataAdapter(cmd)
        Dim dtMan As New DataTable : odaMan.Fill(dtMan)

        Me.cmbEmploees.DataSource = dtMan
        Me.cmbEmploees.DisplayMember = "emplLastName"
        Me.cmbEmploees.ValueMember = "emplID"

        ActivateEditing(False)

        LoadList()   ' загружаем список 
    End Sub

#Region " Загрузка лист скидок "
    Private Sub LoadDiscontHave()
        If Me.lstData.SelectedIndex <> -1 Then
            Try
                Dim odaServList As New SqlClient.SqlDataAdapter("SELECT ID, name FROM awc_Discont WHERE ID NOT IN (SELECT DISTINCT discontID FROM awc_DiscontServices WHERE serviceID = " & Me.lstData.SelectedItem(0) & ") order by name ", mcnnInt)
                Dim dtServList As New DataTable : odaServList.Fill(dtServList)

                Me.tscmbDiscont.ComboBox.DataSource = dtServList
                Me.tscmbDiscont.ComboBox.DisplayMember = "name"
                Me.tscmbDiscont.ComboBox.ValueMember = "ID"

                Dim strSQL$ = "SELECT ID, name FROM awc_Discont WHERE ID IN (SELECT DISTINCT discontID FROM awc_DiscontServices WHERE serviceID = " & Me.lstData.SelectedItem(0) & ")  "
                Dim odaServListH As New SqlClient.SqlDataAdapter(strSQL, mcnnInt)
                Dim dtServListH As New DataTable : odaServListH.Fill(dtServListH)

                Me.lstSelect.DataSource = dtServListH
                Me.lstSelect.DisplayMember = "name"
                Me.lstSelect.ValueMember = "ID"

            Catch oexpData As System.Exception
                MsgBox(oexpData.Message, MsgBoxStyle.Critical, appName)
            End Try
        Else
            Me.tscmbDiscont.ComboBox.DataSource = Nothing
            ' MsgBox("Не выбран материал-1.", MessageBoxIcon.Error, appName)
        End If
    End Sub
#End Region

#Region " Загрузка лист "
    Private Sub LoadList()
        Try
            Dim cmd As New SqlClient.SqlCommand

            cmd.Connection = mcnnInt
            cmd.CommandText = "sp_FilterServices"
            cmd.CommandType = CommandType.StoredProcedure

            modaLookupData = New SqlClient.SqlDataAdapter(cmd)
            dtData = New DataTable
            modaLookupData.Fill(dtData)

            Me.lstData.DataSource = dtData
            Me.lstData.DisplayMember = "Name"
            Me.lstData.ValueMember = "ID"
        Catch ex As System.Exception
            MessageBox.Show(ex.Message, appName)
        End Try
    End Sub
#End Region

#Region " Перемещение "
    Private Sub lstData_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles lstData.SelectedIndexChanged

    End Sub

    Private Sub LoadIndividual()

        Dim strName As String
        Dim oCtl2 As Object

        If Me.lstData.SelectedIndex <> -1 Then
            mdrPersonIndiv = dtData.Rows(Me.lstData.SelectedIndex())

            For Each oCtl2 In Me.tlpContact.Controls
                If TypeOf oCtl2 Is TextBox Then
                    strName = Mid(oCtl2.name, 4)

                    Try
                        oCtl2.text = mdrPersonIndiv(strName).ToString
                    Catch oexp As System.Exception
                    End Try
                End If
            Next

            Me.chkWebCalc.Checked = mdrPersonIndiv("web_calc")
            Me.chkActive.Checked = mdrPersonIndiv("active")
            Me.cmbEmploees.SelectedValue = mdrPersonIndiv("curator_ID")

            LoadDiscontHave()
        End If
    End Sub
#End Region

#Region " Сохранить изменения "
    Private Sub SaveRecord()
        Dim current As Integer = Me.lstData.SelectedValue

        If Me.txtName.Text = "" Then ' наименование
            Me.ErrorProvider1.SetError(Me.txtName, "Поле")
            Exit Sub
        Else : Me.ErrorProvider1.Clear() : End If

        If Me.txtformCostNumber.Text = "" Then ' наименование
            Me.ErrorProvider1.SetError(Me.txtformCostNumber, "Поле")
            Exit Sub
        Else : Me.ErrorProvider1.Clear() : End If

        If Me.txtformPriceNumber.Text = "" Then ' наименование
            Me.ErrorProvider1.SetError(Me.txtformPriceNumber, "Поле")
            Exit Sub
        Else : Me.ErrorProvider1.Clear() : End If

        If Me.cmbEmploees.SelectedIndex = -1 Then ' наименование
            MsgBox("Не указан куратор", MsgBoxStyle.Critical, appName)
            Exit Sub
        End If

        Dim strName As String
        Dim oCtl As Object

        If mblnAdd = True Then
            mdrPersonIndiv = dtData.NewRow
        End If

        mdrPersonIndiv.BeginEdit() 'приступить к редактированию строки

        For Each oCtl In Me.tlpContact.Controls
            If TypeOf oCtl Is TextBox Then
                strName = Mid(oCtl.name, 4)
                Try
                    mdrPersonIndiv(strName) = oCtl.text
                Catch oexp As System.Exception
                End Try
            End If
        Next

        mdrPersonIndiv("active") = Me.chkActive.Checked
        mdrPersonIndiv("web_calc") = Me.chkWebCalc.Checked
        mdrPersonIndiv("curator_ID") = Me.cmbEmploees.SelectedItem(0)

        mdrPersonIndiv.EndEdit() 'Завершить редактирование строки данных

        If mblnAdd = True Then
            dtData.Rows.Add(mdrPersonIndiv)
        End If

        Try
            Dim custCB As New SqlClient.SqlCommandBuilder(modaLookupData)

            mcnnInt.Open()
            modaLookupData.InsertCommand = custCB.GetInsertCommand
            modaLookupData.Update(dtData)
            dtData.AcceptChanges()
            modaLookupData.InsertCommand.Connection.Close()
            mcnnInt.Close()

            ActivateEditing(False)

            LoadList()

            If mblnAdd = True Then
                mblnAdd = False
            Else
                Me.lstData.SelectedValue = current
            End If
        Catch excData As System.Exception
            MsgBox(excData.Message, MsgBoxStyle.Critical, appName)
        End Try
    End Sub
#End Region

#Region " Меню "
    Private Sub tsbtnNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbtnNew.Click
        mblnAdd = True

        Dim oCtl As Object

        For Each oCtl In Me.tlpContact.Controls
            If TypeOf oCtl Is TextBox Then
                oCtl.text = ""
            End If
        Next

        Me.chkActive.Checked = True
        Me.chkWebCalc.Checked = False

        ActivateEditing(True)
    End Sub

    Private Sub tsbtnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbtnSave.Click
        SaveRecord()
    End Sub

    Private Sub tsbtnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbtnEdit.Click
        ActivateEditing(True)
    End Sub

#Region " Активация редактирования  "
    Private Sub ActivateEditing(ByVal bEnable As Boolean)

        Dim oCtl As Object

        For Each oCtl In Me.tlpContact.Controls
            If TypeOf oCtl Is TextBox Then
                If bEnable Then
                    ' oCtl.BorderStyle() = System.Windows.Forms.BorderStyle.Fixed3D
                    oCtl.BackColor() = System.Drawing.Color.White
                Else
                    'oCtl.BorderStyle() = System.Windows.Forms.BorderStyle.FixedSingle
                    oCtl.BackColor() = System.Drawing.Color.White
                    'oCtl2.BackColor() = Me.BackColor
                End If
                oCtl.enabled = bEnable
                'oCtl.readOnly = Not bEnable
            End If

            Me.tsbtnNew.Enabled = Not bEnable
            Me.cmbEmploees.Enabled = bEnable
            Me.chkActive.Enabled = bEnable
            Me.chkWebCalc.Enabled = bEnable

            Me.txtName.Focus()
        Next
    End Sub
#End Region

    Private Sub tsbtnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbtnCancel.Click
        Me.ErrorProvider1.Clear()
        Dim current As Integer = Me.lstData.SelectedIndex

        If mblnAdd Then
            mblnAdd = False
        End If

        ActivateEditing(False)
        LoadList()

        Me.lstData.SelectedIndex = current
    End Sub

    Private Sub tsbtnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbtnDelete.Click
        If MessageBox.Show("Удалить " & Me.lstData.Text & "?", appName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Try
                Module1.NonQuery1("DELETE FROM Services WHERE ID = " & Me.lstData.SelectedItem(0) & " ")
                ActivateEditing(False)
                LoadList()
            Catch excData As System.Exception
                MessageBox.Show("Возможно существуют спецификации ([Orders],[tech_OperControlTag],[CalcSettings],[awc_Polygraph] с данным направлением: " & Me.lstData.SelectedItem(0) & Chr(13) & excData.Message, appName)
            End Try
        Else
            Exit Sub
        End If
    End Sub

    Private Sub tsbtnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbtnExit.Click
        Me.Close()
    End Sub
#End Region

    Private Sub txtformCostNumber_MouseClick(sender As Object, e As MouseEventArgs) Handles txtformCostNumber.MouseClick
        sender.Select(0, Len(sender.Text))
    End Sub

    Private Sub txtformPriceNumber_MouseClick(sender As Object, e As MouseEventArgs) Handles txtformPriceNumber.MouseClick
        sender.Select(0, Len(sender.Text))
    End Sub

    Private Sub txtdescription_MouseClick(sender As Object, e As MouseEventArgs) Handles txtdescription.MouseClick
        '  sender.Select(0, Len(sender.Text))
    End Sub

    Private Sub txtweb_caption_MouseClick(sender As Object, e As MouseEventArgs) Handles txtweb_caption.MouseClick
        sender.Select(0, Len(sender.Text))
    End Sub

    Private Sub chkWebCalc_CheckStateChanged(sender As Object, e As EventArgs) Handles chkWebCalc.CheckStateChanged
        Me.txtweb_caption.Visible = sender.checked
        Me.Label3.Visible = sender.checked
    End Sub

    Private Sub tsbtnSelect_Click(sender As Object, e As EventArgs) Handles tsbtnSelect.Click
        Dim strSQL$ = "INSERT INTO awc_DiscontServices (serviceID, discontID, quantity, quantity2) VALUES (" & Me.lstData.SelectedItem(0) & ","
        strSQL &= "" & Me.tscmbDiscont.ComboBox.SelectedItem(0) & ",  " & Replace(Me.tstxtQuantity.Text, ",", ".") & ",  " & Replace(Me.tstxtQuantity2.Text, ",", ".") & ")"

        Module1.NonQuery1(strSQL)

        LoadDiscontHave()
    End Sub

    Private Sub tsbtnUnSelect_Click(sender As Object, e As EventArgs) Handles tsbtnUnSelect.Click
        If Me.lstSelect.SelectedItems.Count = 1 Then
            Dim selectID As Integer = Me.lstSelect.SelectedItem(0)

            Select Case MsgBox(Prompt:="Удалить   " & CStr(Me.lstSelect.SelectedItem(1)) & "?", Buttons:=vbYesNo, Title:=appName)
                Case Is = vbYes
                    Module1.NonQuery1("DELETE FROM awc_DiscontServices WHERE discontID=" & selectID & " AND serviceID=" & Me.lstData.SelectedItem(0) & "")

                    LoadDiscontHave()

                    Me.tsbtnUnSelect.Select()

                Case Is = vbNo
                    Exit Sub
            End Select
        Else
            MsgBox("Скидок больше нет.", MsgBoxStyle.Information, appName)
        End If
    End Sub

    Private Sub lstData_SelectedValueChanged(sender As Object, e As EventArgs) Handles lstData.SelectedValueChanged
        LoadIndividual()
    End Sub


    Private Sub lstSelect_SelectedValueChanged(sender As Object, e As EventArgs) Handles lstSelect.SelectedValueChanged
        If Me.lstSelect.SelectedIndex <> -1 Then
            Try
                Me.tstxtQuantity.Text = Module1.NonQuery1Scalar("SELECT coalesce(quantity,0) FROM awc_DiscontServices WHERE discontID=" & Me.lstSelect.SelectedItem(0) & " AND serviceID=" & Me.lstData.SelectedItem(0) & "")
                Me.tstxtQuantity2.Text = Module1.NonQuery1Scalar("SELECT coalesce(quantity2,0) FROM awc_DiscontServices WHERE discontID=" & Me.lstSelect.SelectedItem(0) & " AND serviceID=" & Me.lstData.SelectedItem(0) & "")

            Catch ex As System.Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical, appName)
                MsgBox("Проверь а.", MsgBoxStyle.Information, appName)
            End Try
        End If
    End Sub

End Class