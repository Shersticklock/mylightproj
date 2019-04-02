Public Class frmConfigTechOper

    Public ttt As String
    Public itemTech As Integer = vbNull
    Public calcID As Integer = vbNull
    '  Public serviceID As Integer = vbNull

    Private Sub tech_DepOper_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Me.ToolStripLabel1.Text = "Item(0)=" + CStr(itemTech) + ", Tag-" + ttt + ", calcID-" + CStr(calcID) + ", serviceID-" + CStr(serviceID)

            Dim cmd As New SqlClient.SqlCommand

            cmd.Connection = mcnnInt
            cmd.CommandText = "[sp_FilterParamTechOp]"
            cmd.CommandType = CommandType.StoredProcedure

            Dim odaData As New SqlClient.SqlDataAdapter(cmd)
            Dim dtData As New DataTable : odaData.Fill(dtData)

            Me.lstDep.DataSource = dtData
            Me.lstDep.DisplayMember = "Name"
            Me.lstDep.ValueMember = "ID"

            LoadServicesHave()

        Catch oexpData As System.Exception
            MessageBox.Show("Ошибка при загрузке списка: " & oexpData.Message, appName)
        End Try
    End Sub

#Region " DeleteService >>, <<"
    Private Sub tsbtnUnSelect_Click(sender As System.Object, e As System.EventArgs) Handles tsbtnUnSelect.Click
        Select Case MsgBox(Prompt:="Удалить операцию  " & CStr(Me.lstSelect.SelectedItem(1)) & "?", Buttons:=vbYesNo, Title:=appName)
            Case Is = vbYes
                '   Module1.NonQuery1("DELETE FROM tech_DepOper WHERE dep_ID = " & Me.lstDep.SelectedItem(0) & " AND operID = " & Me.lstSelect.SelectedItem(0) & " ")
                Module1.NonQuery1("DELETE FROM tech_OperControlTag WHERE ID = " & Me.lstSelect.SelectedItem(0) & " ")

                LoadServicesHave()
            Case Is = vbNo
                Exit Sub
        End Select
    End Sub

    Private Sub tsbtnSelect_Click(sender As System.Object, e As System.EventArgs) Handles tsbtnSelect.Click
        If Me.lstOper.Items.Count > 0 Then
            '   Dim strSQL$ = " INSERT INTO tech_DepOper (operID, dep_ID) VALUES (" & Me.lstOper.SelectedItem(0) & ", " & Me.lstDep.SelectedItem(0) & ")"
            Dim strSQL$ = " INSERT INTO tech_OperControlTag (calcID, controlTag, controlItem0, techOperID, serviceID) VALUES (" & calcID & ", '" & ttt & "', " & itemTech & ", " & Me.lstOper.SelectedItem(0) & ", " & serviceID & ")"

            Module1.NonQuery1(strSQL)

            LoadServicesHave()
        End If
    End Sub
#End Region

#Region " Загрузка лист каторые выбранный агент, если он пр-во выполняет "
    Private Sub LoadServicesHave()
        Try
            Dim odaServList As New SqlClient.SqlDataAdapter("SELECT tech_Operations.ID, tech_Operations.name FROM tech_Operations WHERE ID NOT IN (SELECT techOperID FROM tech_OperControlTag WHERE tech_OperControlTag.calcID = " & calcID & " AND controlTag='" & ttt & "' AND controlItem0 =" & itemTech & " AND serviceID =" & serviceID & ") AND ParamTechOperID = " & Me.lstDep.SelectedItem(0) & " order by tech_Operations.name", mcnnInt) 'SELECT ID, name FROM tech_Operations WHERE ID NOT IN (SELECT operID FROM tech_DepOper
            Dim dtServList As New DataTable : odaServList.Fill(dtServList)

            Me.lstOper.DataSource = dtServList
            Me.lstOper.DisplayMember = "name"
            Me.lstOper.ValueMember = "ID"

            Dim odaServListH As New SqlClient.SqlDataAdapter("SELECT tech_OperControlTag.ID, tech_Operations.name FROM tech_Operations INNER JOIN tech_OperControlTag ON tech_Operations.ID = tech_OperControlTag.techOperID WHERE tech_OperControlTag.calcID = " & calcID & " AND controlTag='" & ttt & "' AND controlItem0 =" & itemTech & " AND serviceID =" & serviceID & " ", mcnnInt)
            Dim dtServListH As New DataTable : odaServListH.Fill(dtServListH)

            Me.lstSelect.DataSource = dtServListH  ' Связать данные со списком
            Me.lstSelect.DisplayMember = "name"
            Me.lstSelect.ValueMember = "ID"
        Catch oexpData As System.Exception
            MsgBox(oexpData.Message, MsgBoxStyle.Critical, appName)
        End Try
    End Sub
#End Region

    Private Sub lstService_SelectedValueChanged(sender As Object, e As System.EventArgs) Handles lstDep.SelectedValueChanged
        LoadServicesHave()
    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        Me.Close()
    End Sub
End Class