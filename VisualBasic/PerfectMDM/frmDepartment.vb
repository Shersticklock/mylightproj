Public Class frmDepartment
    Dim mdsPersonIndiv As New DataSet
    Dim modaPersonIndiv As SqlClient.SqlDataAdapter
    Dim mdrPersonIndiv As DataRow
    Dim mblnAdd As Boolean
    Dim currentPerson As Integer


    Private Sub frmEmplDepParam_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim odaMatType1 As New SqlClient.SqlDataAdapter("SELECT emplID, emplLastName FROM Employees", mcnnInt)
        Dim dtMatType1 As New DataTable : odaMatType1.Fill(dtMatType1)

        Me.cmbDirDep.DataSource = dtMatType1 'Связать данные со списком
        Me.cmbDirDep.DisplayMember = "emplLastName"
        Me.cmbDirDep.ValueMember = "emplID"

        'Dim cmd As New SqlClient.SqlCommand
        'Dim odaMan As New SqlClient.SqlDataAdapter(cmd)
        'Dim dtMan As New DataTable : odaMan.Fill(dtMan)

        'Me.cmbDirDep.DataSource = dtMan
        'Me.cmbDirDep.DisplayMember = "emplLastName"
        'Me.cmbDirDep.ValueMember = "emplID"

        ActivateEditing(False)

        LoadList()   ' загружаем список 

        Me.lstData.SelectedIndex = 0
    End Sub

#Region " Загрузка лист "
    Private Sub LoadList()
        Try
            modaPersonIndiv = New SqlClient.SqlDataAdapter("SELECT ID, name, description, dirDepEmplID, manStyle  FROM Departments order by name", mcnnInt)
            modaPersonIndiv.FillSchema(mdsPersonIndiv, 2, "Services")
            modaPersonIndiv.Fill(mdsPersonIndiv, "Services")

            Me.lstData.DataSource = mdsPersonIndiv.Tables("Services")
            Me.lstData.DisplayMember = "Name"
            Me.lstData.ValueMember = "ID"
            '   Me.lstData.SelectedIndex = 0

        Catch ex As System.Exception
            MessageBox.Show(ex.Message, appName)
        End Try
    End Sub
#End Region

#Region " Перемещение "
    Private Sub lstData_SelectedValueChanged(sender As Object, e As EventArgs) Handles lstData.SelectedValueChanged
        LoadIndividual()
    End Sub

    Private Sub LoadIndividual()
        Dim strName As String
        Dim oCtl2 As Object

        If Me.lstData.SelectedIndex <> -1 Then
            mdrPersonIndiv = mdsPersonIndiv.Tables("Services").Rows.Find(Me.lstData.SelectedItem(0))

            For Each oCtl2 In Me.tlpContact.Controls
                If TypeOf oCtl2 Is TextBox Then
                    strName = Mid(oCtl2.name, 4)

                    Try
                        oCtl2.text = mdrPersonIndiv(strName).ToString
                    Catch oexp As System.Exception
                    End Try
                End If
            Next

            If mdrPersonIndiv("dirDepEmplID") <> vbNull Then
                Me.cmbDirDep.SelectedValue = mdrPersonIndiv("dirDepEmplID")
            End If

            Me.cmbManStyle.SelectedIndex = mdrPersonIndiv("manStyle")


            Dim mdsPerson As New DataSet
            Dim modaPerson As New SqlClient.SqlDataAdapter("SELECT emplID, emplLastName  FROM Employees WHERE departmentID = " & Me.lstData.SelectedItem(0) & " order by emplLastName", mcnnInt)

            modaPerson.FillSchema(mdsPerson, 2, "Services")
            modaPerson.Fill(mdsPerson, "Services")

            Me.lstDepEmpl.DataSource = mdsPerson.Tables("Services")
            Me.lstDepEmpl.DisplayMember = "emplLastName"
            Me.lstDepEmpl.ValueMember = "emplID"
            Me.lstDepEmpl.ClearSelected()
        End If

    End Sub
#End Region

#Region " Сохранить изменения "
    Private Sub SaveRecord()
        currentPerson = Me.lstData.SelectedIndex

        If Me.txtName.Text = "" Then ' наименование
            Me.ErrorProvider1.SetError(Me.txtName, "Поле")
            Exit Sub
        Else : Me.ErrorProvider1.Clear() : End If

        If Me.cmbDirDep.SelectedIndex = -1 Then ' наименование
            MsgBox("Не указан директор департамента", MsgBoxStyle.Critical, appName)
            Exit Sub
        End If

        Dim strName As String
        Dim oCtl As Object

        If mblnAdd = True Then
            mdrPersonIndiv = mdsPersonIndiv.Tables("Services").NewRow  'mdsPersonIndiv.Tables("Services").NewRow
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

        If Me.cmbDirDep.SelectedIndex <> -1 Then
            mdrPersonIndiv("dirDepEmplID") = Me.cmbDirDep.SelectedItem(0)
        End If

        mdrPersonIndiv("manStyle") = Me.cmbManStyle.SelectedIndex

        mdrPersonIndiv.EndEdit() 'Завершить редактирование строки данных

        Try
            Dim ocbPersonIndiv As SqlClient.SqlCommandBuilder 'создать экземпляр пострителя команды
            ocbPersonIndiv = New SqlClient.SqlCommandBuilder(modaPersonIndiv)

            If mblnAdd = True Then
                mdsPersonIndiv.Tables("Services").Rows.Add(mdrPersonIndiv)
                modaPersonIndiv.InsertCommand = ocbPersonIndiv.GetInsertCommand  ' Обеспечить создание оператора Insert SQL
            Else
                modaPersonIndiv.UpdateCommand = ocbPersonIndiv.GetUpdateCommand
            End If

            modaPersonIndiv.Update(mdsPersonIndiv, "Services") 'выполнить команду SQL и закрыть соед.
            mdsPersonIndiv.Tables("Services").AcceptChanges()

            If mblnAdd = True Then
                modaPersonIndiv.InsertCommand.Connection.Close()
            Else
                modaPersonIndiv.UpdateCommand.Connection.Close()
            End If
        Catch excData As System.Exception
            MsgBox(excData.Message, MsgBoxStyle.Critical, appName)
        End Try

        ActivateEditing(False)
        mblnAdd = False
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

        ActivateEditing(True)
    End Sub

    Private Sub tsbtnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbtnSave.Click
        SaveRecord()
    End Sub

    Private Sub tsbtnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbtnEdit.Click
        Dim cmd As New SqlClient.SqlCommand

        cmd.Connection = mcnnInt
        cmd.CommandText = "[sp_FilterDirDep]"
        cmd.CommandType = CommandType.StoredProcedure

        cmd.Parameters.Add(New SqlClient.SqlParameter("@depID", SqlDbType.Int))
        cmd.Parameters("@depID").Value = Me.lstData.SelectedItem(0)

        Dim odaMan As New SqlClient.SqlDataAdapter(cmd)
        Dim dtMan As New DataTable : odaMan.Fill(dtMan)

        Me.cmbDirDep.DataSource = Nothing
        Me.cmbDirDep.DataSource = dtMan
        Me.cmbDirDep.DisplayMember = "emplLastName"
        Me.cmbDirDep.ValueMember = "emplID"

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
            Me.cmbDirDep.Enabled = bEnable
            Me.cmbManStyle.Enabled = bEnable
            Me.lstData.Enabled = Not bEnable

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

        Me.lstData.SelectedIndex = current
    End Sub

    Private Sub tsbtnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbtnDelete.Click
        If MessageBox.Show("Удалить " & Trim(CStr(mdrPersonIndiv("Name"))) & "?", appName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then

            Dim ocbPartIndiv As SqlClient.SqlCommandBuilder

            Try
                mdrPersonIndiv.Delete()
                ocbPartIndiv = New SqlClient.SqlCommandBuilder(modaPersonIndiv)
                modaPersonIndiv.DeleteCommand = ocbPartIndiv.GetDeleteCommand
                modaPersonIndiv.Update(mdsPersonIndiv.Tables("Services"))
                mdsPersonIndiv.Tables("Services").AcceptChanges()
                modaPersonIndiv.DeleteCommand.Connection.Close()

                ActivateEditing(False)
            Catch excData As System.Exception
                MessageBox.Show("Error Occured:" & excData.Message, appName)
            End Try
        Else
            Exit Sub
        End If
    End Sub

    Private Sub tsbtnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbtnExit.Click
        Me.Close()
    End Sub
#End Region

    Private Sub lstData_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstData.SelectedIndexChanged

    End Sub

    Private Sub txtName_TextChanged(sender As Object, e As EventArgs) Handles txtName.TextChanged

    End Sub
End Class