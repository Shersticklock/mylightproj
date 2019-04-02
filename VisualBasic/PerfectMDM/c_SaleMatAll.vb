Public Class c_SaleMatAll

    Dim costUnit@
    Dim prim$ = ""

    Private Sub c_MatSale_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        ' Me.Text = Module1.NonQuery1ScalarString("SELECT Name  FROM Services where ID = " & serviceID & " ")

        LoadProd()

        If postPrioritet <= 2 Then
            Me.tsbtnSet.Visible = True
            ' Me.cmsSale.Visible = True
        Else
            Me.tsbtnSet.Visible = False
        End If
    End Sub

    Private Sub LoadProd()
        Dim odaProd As New SqlClient.SqlDataAdapter("SELECT ID, Name FROM awc_Polygraph WHERE serviceID=" & serviceID & " order by name", mcnnInt)
        Dim dtProd As New DataTable : odaProd.Fill(dtProd)

        Me.cmbProd.DataSource = dtProd 'Связать данные со списком
        Me.cmbProd.DisplayMember = "Name"
        Me.cmbProd.ValueMember = "ID"
    End Sub

    Sub PopulateCategories()
        Dim list1 As String = Module1.NonQuery1ScalarString("SELECT listMatTypeID FROM CalcSettings WHERE serviceID=" & serviceID & " AND nameControl='" & Me.cmbProd.Text & "' ")
        Dim pNode As TreeNode ' parent
        Dim cNode As TreeNode ' child
        Dim ResultSet As DataSet = RunQuery("SELECT ID, Name FROM MatCategories WHERE ID IN (SELECT number FROM [dbo].[iter_intlist]('" & list1 & "')) AND description='1' order by Name")

        Try
            Me.tvMat.Nodes.Clear()

            If ResultSet.Tables.Count > 0 Then

                Dim row As DataRow

                For Each row In ResultSet.Tables(0).Rows
                    pNode = tvMat.Nodes.Add(row("Name").ToString()) ' add parent
                    pNode.Tag = row("ID").ToString()

                    Dim ResultSet1 As DataSet = RunQuery("Select ID, Name From MatTypes WHERE matCatID=" & row("ID") & " order by Name")
                    Dim row1 As DataRow

                    For Each row1 In ResultSet1.Tables(0).Rows
                        cNode = New TreeNode ' another way to add controls - create before adding
                        cNode.Text = row1("Name").ToString()
                        cNode.Tag = row1("ID").ToString()
                        pNode.Nodes.Add(cNode) ' add child
                    Next
                Next
            End If

            Dim odaMatList As New SqlClient.SqlDataAdapter("Select ID, Name From MatCategories Where description='1' order by Name", mcnnInt)
            Dim dtMatList As New DataTable : odaMatList.Fill(dtMatList)

            Me.clbMatGroup.DataSource = dtMatList 'Связать данные со списком
            Me.clbMatGroup.DisplayMember = "Name"
            Me.clbMatGroup.ValueMember = "ID"
        Catch oexpData As System.Exception
            MsgBox(oexpData.Message, MsgBoxStyle.Critical, appName)
        End Try
    End Sub

#Region " Загрузка лист материлов "
    Private Sub LoadList(modeFilter As Integer)
        Dim strSQL$ = Nothing

        Try
            Select Case Me.tvMat.SelectedNode.Level
                Case Is = 0
                    strSQL = "SELECT matID, matName FROM Materials WHERE Materials.matCatID=" & Me.tvMat.SelectedNode.Tag & " order by matName"
                Case Is = 1
                    strSQL = "SELECT matID, matName FROM Materials WHERE Materials.typeID=" & Me.tvMat.SelectedNode.Tag & " order by matName"
            End Select

            Dim odaMatList As New SqlClient.SqlDataAdapter(strSQL, mcnnInt)
            Dim dtMatList As New DataTable : odaMatList.Fill(dtMatList)

            Me.cmbMat.DataSource = dtMatList  'Связать данные со списком
            Me.cmbMat.DisplayMember = "matName"
            Me.cmbMat.ValueMember = "matID"
        Catch oexpData As System.Exception
            MsgBox(oexpData.Message, MsgBoxStyle.Critical, appName)
        End Try
    End Sub
#End Region

    Function RunQuery(ByVal QueryString As String) As DataSet
        Dim DBAdapter As New SqlClient.SqlDataAdapter(QueryString, mcnnInt) ' SqlClient.SqlDataAdapter
        Dim ResultsDataSet As New DataSet : DBAdapter.Fill(ResultsDataSet)

        Return ResultsDataSet
    End Function

    Private Sub tsbtnExit_Click(sender As System.Object, e As System.EventArgs) Handles tsbtnExit.Click
        Me.Close()
    End Sub

    Private Sub tvMat_AfterSelect(sender As System.Object, e As System.Windows.Forms.TreeViewEventArgs) Handles tvMat.AfterSelect
        LoadList(0)
    End Sub

    Private Sub Cost()
        If Me.cmbMat.SelectedIndex <> -1 Then
            Dim odaUnit As New SqlClient.SqlDataAdapter("SELECT Units.ID, Units.Name FROM Units INNER JOIN SkladAccountingUnits ON Units.ID=SkladAccountingUnits.unitID WHERE SkladAccountingUnits.matID=" & Me.cmbMat.SelectedItem(0) & "", mcnnInt)
            Dim dtUnit As New DataTable : odaUnit.Fill(dtUnit)

            Me.cmbUnit.DataSource = dtUnit 'Связать данные со списком
            Me.cmbUnit.DisplayMember = "Name"
            Me.cmbUnit.ValueMember = "ID"

            Dim k_skidka@ = (100 - Val(Me.tscmbSkidka.Text)) / 100 'скидка
            ' Dim k_skidka@ = 1
            Dim newCost@ = RoundUp((Module1.NonQuery1Scalar("SELECT TOP 1 priceOut FROM SkladAccountingUnits WHERE matID=" & Me.cmbMat.SelectedItem(0) & "") * Me.nudKolvo.Value * k_skidka) / Me.nudKolvo.Value * 100) / 100 * Me.nudKolvo.Value

            Me.tstxtItog.Text = newCost * (100 - Val(Me.tscmbSkidka.Text)) / 100

            prim = Module1.NonQuery1ScalarString("SELECT description FROM Services where ID=" & serviceID & "")
        End If
    End Sub

    Private Sub tsbtnCost_Click(sender As System.Object, e As System.EventArgs) Handles tsbtnCost.Click
        Cost()
    End Sub

    Private Sub tsbtnOK_Click(sender As System.Object, e As System.EventArgs) Handles tsbtnOK.Click
        If costID = Nothing Then
            Exit Sub
        Else
            If MessageBox.Show("Добавить расчет к заказу", appName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                If Not IsNumeric(Me.tstxtItog.Text) Then MsgBox("Не корректное значение стоимости", MsgBoxStyle.Critical, appName) : Exit Sub

                Dim number% = Module1.NonQuery1Scalar("SELECT coalesce(max(FLOOR(CONVERT(decimal(10,5), number))),0) +1 FROM orders WHERE costID=" & costID & "").ToString

                Dim orderIDforTech% = InsertToOrders(Me.cmbProd.Text, Me.cmbMat.SelectedItem(0), Me.nudKolvo.Value, CDec(Me.tstxtItog.Text), prim, "", number, costUnit) 'Пишем спецификацию

                Dim techCost@ = InsertTechOper(CInt(Me.Tag), Me.cmbProd.Tag, Me.cmbProd.SelectedItem(0), Me.nudKolvo.Value, orderIDforTech)

                Me.Close()
            Else
                Exit Sub
            End If
        End If
    End Sub

    Function InsertToOrders(ByVal strName As String, matID As Integer, matCount As Decimal, cost As Decimal, tech As String, sizeXY As String, num As String, costUnit As Decimal) As Integer
        Dim cmd As New SqlClient.SqlCommand

        Try
            cmd.Connection = mcnnInt
            cmd.CommandText = "sp_CalcToOrders"
            cmd.CommandType = CommandType.StoredProcedure
            'Описываем параметры
            cmd.Parameters.Add(New SqlClient.SqlParameter("@serviceID", SqlDbType.Int))
            cmd.Parameters("@serviceID").Value = serviceID

            cmd.Parameters.Add(New SqlClient.SqlParameter("@cost", SqlDbType.Decimal))
            cmd.Parameters("@cost").Value = cost

            cmd.Parameters.Add(New SqlClient.SqlParameter("@costID", SqlDbType.Int))
            cmd.Parameters("@costID").Value = costID

            cmd.Parameters.Add(New SqlClient.SqlParameter("@prim", SqlDbType.NVarChar))
            cmd.Parameters("@prim").Value = ""

            If matID = 0 Then
                cmd.Parameters.Add(New SqlClient.SqlParameter("@matID", SqlDbType.Int))
                cmd.Parameters("@matID").Value = Module1.NonQuery1Scalar("SELECT matID From materials where matzak=1")
            Else
                cmd.Parameters.Add(New SqlClient.SqlParameter("@matID", SqlDbType.Int))
                cmd.Parameters("@matID").Value = matID
            End If

            cmd.Parameters.Add(New SqlClient.SqlParameter("@data", SqlDbType.DateTime))
            cmd.Parameters("@data").Value = Now()

            cmd.Parameters.Add(New SqlClient.SqlParameter("@sostav", SqlDbType.NVarChar))
            cmd.Parameters("@sostav").Value = Me.cmbProd.SelectedItem(0)

            cmd.Parameters.Add(New SqlClient.SqlParameter("@edIzm", SqlDbType.Int))
            cmd.Parameters("@edIzm").Value = Me.cmbUnit.SelectedItem(0)

            cmd.Parameters.Add(New SqlClient.SqlParameter("@technology", SqlDbType.NVarChar))
            cmd.Parameters("@technology").Value = tech

            cmd.Parameters.Add(New SqlClient.SqlParameter("@costUnit", SqlDbType.Decimal))
            cmd.Parameters("@costUnit").Value = cost / Me.nudKolvo.Value

            cmd.Parameters.Add(New SqlClient.SqlParameter("@sizeCut", SqlDbType.NVarChar))
            cmd.Parameters("@sizeCut").Value = sizeXY

            cmd.Parameters.Add(New SqlClient.SqlParameter("@kolvo", SqlDbType.Int))
            cmd.Parameters("@kolvo").Value = Me.nudKolvo.Value

            cmd.Parameters.Add(New SqlClient.SqlParameter("@matCount", SqlDbType.Int))
            cmd.Parameters("@matCount").Value = matCount

            cmd.Parameters.Add(New SqlClient.SqlParameter("@nameForDoc", SqlDbType.NVarChar))
            cmd.Parameters("@nameForDoc").Value = strName

            cmd.Parameters.Add(New SqlClient.SqlParameter("@nomer", SqlDbType.NVarChar))
            cmd.Parameters("@nomer").Value = num

            mcnnInt.Open()

            Return cmd.ExecuteScalar
        Catch excp As System.Exception
            MessageBox.Show(excp.Message, appName)
            Exit Function
        Finally
            mcnnInt.Close()
        End Try
    End Function

    Function InsertTechOper(calcID As Integer, controlTag As String, controlItem0 As Integer, quantity As Integer, orderIDforTech As Integer) As Integer
        Dim cmd As New SqlClient.SqlCommand

        '  MsgBox(orderIDforTech.ToString)

        Try
            cmd.Connection = mcnnInt
            cmd.CommandText = "sp_TechOperOrderIns"
            cmd.CommandType = CommandType.StoredProcedure
            'Описываем параметры
            cmd.Parameters.Add(New SqlClient.SqlParameter("@calcID", SqlDbType.Int))
            cmd.Parameters("@calcID").Value = calcID

            cmd.Parameters.Add(New SqlClient.SqlParameter("@controlTag", SqlDbType.NVarChar))
            cmd.Parameters("@controlTag").Value = controlTag

            cmd.Parameters.Add(New SqlClient.SqlParameter("@controlItem0", SqlDbType.Int))
            cmd.Parameters("@controlItem0").Value = controlItem0

            cmd.Parameters.Add(New SqlClient.SqlParameter("@quantity", SqlDbType.Int))
            cmd.Parameters("@quantity").Value = quantity

            cmd.Parameters.Add(New SqlClient.SqlParameter("@orderID", SqlDbType.Int))
            cmd.Parameters("@orderID").Value = orderIDforTech

            mcnnInt.Open()

            Return cmd.ExecuteScalar
        Catch excp As System.Exception
            MessageBox.Show(excp.Message, appName)
            Exit Function
        Finally
            mcnnInt.Close()
        End Try
    End Function

    Private Sub НастроитьToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs)
        Me.clbMatGroup.Visible = True
    End Sub

    Private Sub cmbMat_SelectedValueChanged(sender As Object, e As System.EventArgs) Handles cmbMat.SelectedValueChanged
        Cost()
    End Sub

    Private Sub ToolStripButton1_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripButton1.Click
        LoadList(2)
    End Sub

    Private Sub ToolStripButton2_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripButton2.Click
        LoadList(1)
    End Sub

    Private Sub tsbtnSelectAll_Click(sender As System.Object, e As System.EventArgs) Handles tsbtnSelectAll.Click
        Dim i%

        For i = 0 To Me.clbMatGroup.Items.Count - 1
            Me.clbMatGroup.SetItemChecked(i, True)
        Next
    End Sub

    Private Sub tsbtnResetAll_Click(sender As System.Object, e As System.EventArgs) Handles tsbtnResetAll.Click
        Dim i%

        For i = 0 To Me.clbMatGroup.Items.Count - 1
            Me.clbMatGroup.SetItemChecked(i, False)
        Next
    End Sub

    Private Sub tsbtnApply_Click(sender As System.Object, e As System.EventArgs) Handles tsbtnApply.Click
        Dim s As String = Nothing

        For Each itemChecked As Object In Me.clbMatGroup.CheckedItems
            If s <> Nothing Then s += ", "
            s += CStr(itemChecked.item(0))
        Next

        If s Is Nothing Then
            MsgBox("Не выбраны группы материалов", MsgBoxStyle.Critical, appName) : Exit Sub
        End If
        'удаляем предыдущие записи
        Module1.NonQuery1("DELETE FROM CalcSettings WHERE serviceID=" & serviceID & " AND nameControl='" & Me.cmbProd.Text & "'")

        Dim strSQL1$ = "INSERT INTO CalcSettings (serviceID, nameControl, listMatTypeID, nameService, controlTag)"
        strSQL1 &= " VALUES (" & serviceID & ",'" & Me.cmbProd.Text & "','" & s & "',(SELECT name FROM services WHERE ID=" & serviceID & "),'')"

        Module1.NonQuery1(strSQL1)

        MsgBox("Готово", MsgBoxStyle.Information, appName)
        Me.Close()
    End Sub

    Private Sub tsbtnHide_Click(sender As System.Object, e As System.EventArgs) Handles tsbtnHide.Click
        Me.clbMatGroup.Visible = False
        Me.tsMainMenu.Visible = True
        Me.tvMat.Visible = True
    End Sub

    Private Sub clbMatGroup_VisibleChanged(sender As Object, e As System.EventArgs) Handles clbMatGroup.VisibleChanged
        Me.tsSettings.Visible = sender.visible
    End Sub

    Private Sub cmbProd_SelectedValueChanged(sender As Object, e As EventArgs) Handles cmbProd.SelectedValueChanged
        PopulateCategories()
    End Sub

    Private Sub ДобавитьПродуктToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ДобавитьПродуктToolStripMenuItem.Click
        Dim strName As String = InputBox("Новый продукт", appName)

        If Len(strName) = 0 Then
            MsgBox("Запись не произведена  ", MessageBoxIcon.Error, appName) : Exit Sub
        Else
            Module1.NonQuery1("INSERT INTO awc_Polygraph (Name, serviceID) VALUES ('" & strName & "', " & serviceID & ")")
            LoadProd()
        End If
    End Sub

    Private Sub УдадитьПродуктToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles УдадитьПродуктToolStripMenuItem.Click
        Select Case MsgBox(Prompt:="Удалить  " & Trim(Me.cmbProd.SelectedItem(1)) & "?", Buttons:=vbYesNo, Title:=appName)
            Case Is = vbYes
                Module1.NonQuery1("DELETE FROM awc_Polygraph WHERE ID = " & Me.cmbProd.SelectedItem(0) & "")
                LoadProd()
            Case Is = vbNo
                Exit Sub
        End Select
    End Sub

    Private Sub nudKolvo_GotFocus(sender As Object, e As EventArgs) Handles nudKolvo.GotFocus
        sender.Select(0, (Len(sender.Value.ToString)))
    End Sub

    Private Sub nudKolvo_MouseClick(sender As Object, e As MouseEventArgs) Handles nudKolvo.MouseClick
        sender.Select(0, (Len(sender.Value.ToString)))
    End Sub

    Private Sub ToolStripButton3_Click(sender As Object, e As EventArgs) Handles tsbtnSet.Click
        If emplID = Module1.NonQueryScalarInt("SELECT curator_ID FROM Services WHERE ID=" & serviceID & "") Or postPrioritet = 1 Then
            Me.clbMatGroup.Visible = True
            Me.tsMainMenu.Visible = False
            Me.tvMat.Visible = False
        Else
            MsgBox("Нет прав на конфигурирование", MsgBoxStyle.Critical, appName)
        End If
    End Sub

    Private Sub ЗадатьТехнологическуюОперациюToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ЗадатьТехнологическуюОперациюToolStripMenuItem.Click
        Module1.ConfigTechOper(cmsProd.SourceControl, CInt(Me.Tag))
    End Sub

    Private Sub nudKolvo_ValueChanged(sender As Object, e As EventArgs) Handles nudKolvo.ValueChanged
        Me.tscmbSkidka.ComboBox.DataSource = Nothing

        Try
            Dim odaDiscont As New SqlClient.SqlDataAdapter("SELECT awc_Discont.ID, awc_Discont.Name FROM awc_Discont INNER JOIN awc_DiscontServices ON awc_Discont.ID=awc_DiscontServices.discontID WHERE awc_DiscontServices.serviceID=" & serviceID & " AND quantity<=" & Me.nudKolvo.Value & " AND " & Me.nudKolvo.Value & "<=quantity2 order by awc_Discont.description", mcnnInt)
            Dim dtDiscont As New DataTable

            odaDiscont.Fill(dtDiscont)

            Me.tscmbSkidka.ComboBox.DataSource = dtDiscont 'Связать данные со списком
            Me.tscmbSkidka.ComboBox.DisplayMember = "Name"
            Me.tscmbSkidka.ComboBox.ValueMember = "ID"
        Catch ex As System.Exception
            '  MsgBox("Универсальный прайс, загрузка." & ex.Message, MsgBoxStyle.Critical, appName)
        End Try
    End Sub
End Class