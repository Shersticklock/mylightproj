Public Class tech_EmplEquip

    Private Sub tech_EmplEquip_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Dim odaData As SqlClient.SqlDataAdapter
        Dim dtData As DataTable = New DataTable

        Try
            odaData = New SqlClient.SqlDataAdapter("SELECT ID, Name FROM tech_Equipment ORDER BY Name, dep_ID ", mcnnInt)
            odaData.Fill(dtData)

            Me.lstEquipment.DataSource = dtData
            Me.lstEquipment.DisplayMember = "Name"
            Me.lstEquipment.ValueMember = "ID"

        Catch oexpData As System.Exception
            MessageBox.Show("Ошибка при загрузке списка: " & oexpData.Message, appName)
        End Try
    End Sub

#Region " DeleteService >>, <<"
    Private Sub tsbtnUnSelect_Click(sender As System.Object, e As System.EventArgs) Handles tsbtnUnSelect.Click
        Select Case MsgBox(Prompt:="Удалить сотрудника  " & CStr(Me.lstSelect.SelectedValue) & "?", Buttons:=vbYesNo, Title:=appName)
            Case Is = vbYes
                Module1.NonQuery1("DELETE FROM tech_EquipEmpl WHERE empl_ID = " & Me.lstSelect.SelectedItem(0) & " AND equip_ID = " & Me.lstEquipment.SelectedItem(0) & " ")

                LoadServicesHave()
            Case Is = vbNo
                Exit Sub
        End Select
    End Sub

    Private Sub tsbtnSelect_Click(sender As System.Object, e As System.EventArgs) Handles tsbtnSelect.Click
        Dim strSQL$ = " INSERT INTO tech_EquipEmpl (equip_ID, empl_ID) VALUES (" & Me.lstEquipment.SelectedItem(0) & ", " & Me.lstEml.SelectedItem(0) & ")"
        Module1.NonQuery1(strSQL)

        LoadServicesHave()
    End Sub
#End Region

#Region " Загрузка лист каторые выбранный агент, если он пр-во выполняет "
    Private Sub LoadServicesHave()
        Dim odaServList As SqlClient.SqlDataAdapter
        Dim dtServList As DataTable = New DataTable

        Try
            odaServList = New SqlClient.SqlDataAdapter("SELECT emplID, emplLastName FROM Employees WHERE emplID NOT IN (SELECT DISTINCT empl_ID FROM tech_EquipEmpl WHERE equip_ID = " & Me.lstEquipment.SelectedItem(0) & ") AND dismissed = 0 ", mcnnInt)
            odaServList.Fill(dtServList)

            Me.lstEml.DataSource = dtServList
            Me.lstEml.DisplayMember = "emplLastName"
            Me.lstEml.ValueMember = "emplID"
        Catch oexpData As System.Exception
            MsgBox(oexpData.Message, MsgBoxStyle.Information, appName)
        End Try


        ''загружаем 
        Dim odaServListH As SqlClient.SqlDataAdapter
        Dim dtServListH As DataTable = New DataTable
        Dim strSQL$ = "SELECT Employees.emplID, Employees.emplLastName FROM Employees INNER JOIN tech_EquipEmpl ON Employees.emplID = tech_EquipEmpl.empl_ID WHERE tech_EquipEmpl.equip_ID = " & Me.lstEquipment.SelectedItem(0) & " "

        Try
            odaServListH = New SqlClient.SqlDataAdapter(strSQL, mcnnInt)
            odaServListH.Fill(dtServListH)

            Me.lstSelect.DataSource = dtServListH  ' Связать данные со списком
            Me.lstSelect.DisplayMember = "emplLastName"
            Me.lstSelect.ValueMember = "emplID"
        Catch oexpData As System.Exception
            MsgBox(oexpData.Message, MsgBoxStyle.Critical, appName)
        End Try
    End Sub
#End Region

    Private Sub lstEmployees_SelectedValueChanged(sender As Object, e As System.EventArgs) Handles lstEquipment.SelectedValueChanged
        LoadServicesHave()
    End Sub
End Class