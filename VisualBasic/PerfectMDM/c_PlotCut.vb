Public Class c_PlotCut
    Dim matQuantity@
    Dim sTotal@
    Dim kolvoSloev%

    Dim prim As String
    Dim costMont@
    Dim costVyborka@
    Dim costCut@

    Dim discont As Integer
    Dim strNacSrok$


    Private Sub awc_PlotCut_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Dim odaProd As New SqlClient.SqlDataAdapter("SELECT ID, Name FROM awc_Polygraph WHERE serviceID=" & serviceID & " order by name", mcnnInt)
        Dim dtProd As New DataTable : odaProd.Fill(dtProd)

        Me.tmbMatTypes.DataSource = dtProd 'Связать данные со списком
        Me.tmbMatTypes.DisplayMember = "Name"
        Me.tmbMatTypes.ValueMember = "ID"

        Try 'загружаем монтажку
            Dim strSQL2$ = "SELECT listMatTypeID FROM CalcSettings WHERE serviceID=" & serviceID & " AND nameControl='" & Trim(Me.chkMatMont.Text) & "'"
            Dim odaKrepType As New SqlClient.SqlDataAdapter("SELECT matID, matName FROM Materials WHERE typeID IN (" & Module1.NonQuery1ScalarString(strSQL2) & ") ", mcnnInt)
            Dim dtKrepType As New DataTable : odaKrepType.Fill(dtKrepType)

            Me.cmbMatMont.DataSource = dtKrepType 'Связать данные со списком
            Me.cmbMatMont.DisplayMember = "matName"
            Me.cmbMatMont.ValueMember = "matID"

            Dim odaTech As New SqlClient.SqlDataAdapter("SELECT ID, nameTech FROM awc_CalcTech WHERE calcID=" & CInt(Me.Tag) & " AND controlTag='" & Me.cmbVyborka.Tag & "' AND serviceID=" & serviceID & "", mcnnInt)
            Dim dtTech As New DataTable : odaTech.Fill(dtTech)

            Me.cmbVyborka.DataSource = dtTech 'Связать данные со списком
            Me.cmbVyborka.DisplayMember = "nameTech"
            Me.cmbVyborka.ValueMember = "ID"
            Me.cmbVyborka.SelectedIndex = -1
        Catch ex As System.Exception
        End Try

        'Читаем наименования срочности
        Dim odaSrok As New SqlClient.SqlDataAdapter("SELECT nac,Name FROM unicalcSrokNac", mcnnInt)
        Dim dtSrok As New DataTable : odaSrok.Fill(dtSrok)

        Me.cmbSrok.DataSource = dtSrok
        Me.cmbSrok.DisplayMember = "Name"
        Me.cmbSrok.ValueMember = "nac"
        Me.cmbSrok.SelectedIndex = 0
        Me.chkVyborka.Enabled = True
    End Sub

    Private Sub tsbtnCost_Click(sender As System.Object, e As System.EventArgs) Handles tsbtnCost.Click
        Dim nacenkaSrok As Integer

        If Me.cmbSelect.SelectedIndex = -1 Then MsgBox("Не выбран вид материала", MsgBoxStyle.Critical, appName) : Me.cmbSelect.Focus() : Exit Sub
        If Me.cmbSrok.SelectedIndex = -1 Then MsgBox("Не указан срок.", MsgBoxStyle.Critical, appName) : Me.cmbSrok.Focus() : Exit Sub

        Select Case Me.cmbSrok.SelectedIndex
            Case Is = -1 : MsgBox("Не выбран срок", MsgBoxStyle.Critical, appName) : Me.cmbSrok.Focus() : Exit Sub
            Case Is = 0 : nacenkaSrok = 0
            Case Is = 1 : nacenkaSrok = 25
            Case Is = 2 : nacenkaSrok = 100
            Case Is = 3 : nacenkaSrok = 150
            Case Is = 4 : nacenkaSrok = 200
        End Select

        strNacSrok = CStr(nacenkaSrok)

        Dim cenaMat@, Itogo@

        prim = Nothing

        matQuantity = Me.nudKolvo.Value * Me.nudX.Value * Me.nudY.Value / 1000000

        If matQuantity < 1 Then
            matQuantity = 1
        End If

        If Me.chkMatMont.Checked = True Then
            costMont = Module1.NonQuery1Scalar("SELECT TOP 1 priceOut FROM SkladAccountingUnits WHERE matID=" & Me.cmbMatMont.SelectedItem(0) & "") * matQuantity
        Else
            costMont = 0
        End If

        If Me.cmbSelect.SelectedIndex = 0 Then 'мат заказчика
            cenaMat = 0
            kolvoSloev = Me.nudKolSloev.Value
            sTotal = kolvoSloev * Me.nudKolvo.Value * Me.nudX.Value * Me.nudY.Value / 1000000

            costCut = Module1.NonQuery1Scalar("SELECT[dbo].[costTechOperCMB] (" & Replace(sTotal, ",", ".") & ",'" & Me.Tag & "','" & Me.tmbMatTypes.Tag & "'," & Me.tmbMatTypes.SelectedItem(0) & "," & serviceID & ",1," & Me.nudKolvo.Value & "," & discont & ")")

            If Me.cmbVyborka.Visible = True Then
                If Me.cmbVyborka.SelectedIndex = -1 Then MsgBox("Не выбрана сложность выборки.", MsgBoxStyle.Critical, appName) : Me.cmbVyborka.Focus() : Exit Sub
                costVyborka = Module1.NonQuery1Scalar("SELECT[dbo].[costTechOperCMB] (" & Replace(sTotal / kolvoSloev, ",", ".") & ", '" & Me.Tag & "','" & Me.cmbVyborka.Tag & "'," & Me.cmbVyborka.SelectedItem(0) & "," & serviceID & ", 1," & Me.nudKolvo.Value & "," & discont & ")")
                prim += ", требуется выборка"
            Else
                costVyborka = 0
            End If

            matQuantity = 0
        Else
            kolvoSloev = Me.dgMat.Rows.Count

            If Me.dgMat.RowCount > 0 Then
                sTotal = Me.dgMat.RowCount * Me.nudKolvo.Value * Me.nudX.Value * Me.nudY.Value / 1000000 '    If matQuantity < 1 Then matQuantity = 1 'если меньше метра считаем как 1 метр кв
                'цикл по мату
                For n As Integer = 0 To kolvoSloev - 1
                    Try
                        cenaMat += matQuantity * Module1.NonQuery1Scalar("SELECT TOP 1 priceOut FROM SkladAccountingUnits WHERE matID=" & Me.dgMat("matID", n).Value & "")
                    Catch ex As System.Exception
                        MsgBox(ex.Message, MsgBoxStyle.Critical, appName) : Exit For : Exit Sub
                    End Try
                Next

                costCut = Module1.NonQuery1Scalar("SELECT[dbo].[costTechOperCMB] (" & Replace(sTotal, ",", ".") & ",'" & Me.Tag & "','" & Me.tmbMatTypes.Tag & "'," & Me.tmbMatTypes.SelectedItem(0) & "," & serviceID & ",1," & Me.nudKolvo.Value & "," & discont & ")")

                If Me.cmbVyborka.Visible = True Then
                    If Me.cmbVyborka.SelectedIndex = -1 Then MsgBox("Не выбрана сложность выборки.", MsgBoxStyle.Critical, appName) : Me.cmbVyborka.Focus() : Exit Sub
                    costVyborka = Module1.NonQuery1Scalar("SELECT[dbo].[costTechOperCMB] (" & Replace(sTotal / kolvoSloev, ",", ".") & ",'" & Me.Tag & "','" & Me.cmbVyborka.Tag & "'," & Me.cmbVyborka.SelectedItem(0) & "," & serviceID & ",1," & Me.nudKolvo.Value & "," & discont & ")")

                    prim += ", требуется выборка"
                Else
                    costVyborka = 0
                End If
            Else
                MsgBox("Не выбран материал", MsgBoxStyle.Critical, appName) : Exit Sub
            End If
        End If

        Itogo = (costCut + costVyborka + cenaMat + costMont) * (100 - Val(Me.tscmbSkidka.Text)) / 100

        Dim newCost As Decimal = RoundUp(Itogo / Me.nudKolvo.Value * 100) / 100 * Me.nudKolvo.Value

        Me.tstxtItog.Text = newCost
        Me.tstxtCostUnit.Text = Itogo / Me.nudKolvo.Value

        prim += " * наценка за срочность: " + Me.cmbSrok.Text + "-" + strNacSrok + "%"
    End Sub

#Region " Сохраняем "
    Private Sub tsbtnOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbtnOK.Click
        If Me.cmbSrok.SelectedIndex = -1 Then MsgBox("Не указан срок.", MsgBoxStyle.Critical, appName) : Me.cmbSrok.Focus() : Exit Sub
        If Not IsNumeric(tstxtItog.Text) Then MsgBox("Не корректное значение стоимости", MsgBoxStyle.Critical, appName) : Exit Sub

        If costID = Nothing Then
            Exit Sub
        Else
            If MessageBox.Show("Добавить расчет к заказу", appName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                Dim IDmatZak As Integer = Module1.NonQuery1Scalar("SELECT matID FROM Materials WHERE matZak=1") 'ID материала заказчика
                Dim IDmatVirt As Integer = Module1.NonQuery1Scalar("SELECT matID FROM Materials WHERE virtMat=1")
                Dim number$ = Module1.NonQuery1Scalar("SELECT coalesce(max(FLOOR(CONVERT(decimal(10,5), number))),0) +1 FROM orders WHERE costID=" & costID & "").ToString
                Dim orderIDforTech%
                Dim techCost@

                number = Module1.NonQuery1Scalar("SELECT coalesce(max(FLOOR(CONVERT(decimal(10,5), number))),0) +1 FROM orders WHERE costID=" & costID & "").ToString

                If Me.cmbSelect.SelectedIndex = 0 Then 'материал заказчика
                    matQuantity = 0

                    Dim fff As String = Nothing

                    If Me.chkVyborka.Checked = True Then
                        prim = ""
                    End If

                    orderIDforTech = InsertToOrders(Me.tmbMatTypes.Text, IDmatZak, 0, CDec(Val(Me.tstxtItog.Text) - costMont - costVyborka), "Плоттерная резка", Me.nudX.Value.ToString & "x" & Me.nudY.Value.ToString + " мм", number, CDec(Me.tstxtCostUnit.Text), Me.cmbSrok.Text) 'Пишем спецификацию

                    '*********Технологические операции
                    techCost = InsertTechOper(CInt(Me.Tag), Me.tmbMatTypes.Tag, Me.tmbMatTypes.SelectedValue, Me.nudKolvo.Value, orderIDforTech)


                    If Me.chkMatMont.Checked = True Then
                        orderIDforTech = InsertToOrders("Пленка монтажная", Me.cmbMatMont.SelectedValue, matQuantity, costMont, "Плоттерная резка", Me.nudX.Value.ToString & "x" & Me.nudY.Value.ToString + " мм", (number + ".1"), 0, "") 'Пишем спецификацию


                        techCost = InsertTechOper(CInt(Me.Tag), Me.tmbMatTypes.Tag, Me.tmbMatTypes.SelectedValue, Me.nudKolvo.Value, orderIDforTech)


                        If Me.chkVyborka.Checked = True Then
                            orderIDforTech = InsertToOrders("Выборка", IDmatVirt, matQuantity, costVyborka, "Плоттерная резка", Me.nudX.Value.ToString & "x" & Me.nudY.Value.ToString + " мм", (number + ".2"), costVyborka / Me.nudKolvo.Value, Me.cmbVyborka.Text) 'Пишем спецификацию

                            techCost = InsertTechOper(CInt(Me.Tag), Me.cmbVyborka.Tag, Me.cmbVyborka.SelectedValue, Me.nudKolvo.Value, orderIDforTech)

                        End If
                    Else
                        If Me.chkVyborka.Checked = True Then
                            orderIDforTech = InsertToOrders("Выборка", IDmatVirt, matQuantity, costVyborka, "Плоттерная резка", Me.nudX.Value.ToString & "x" & Me.nudY.Value.ToString + " мм", (number + ".1"), costVyborka / Me.nudKolvo.Value, Me.cmbVyborka.Text) 'Пишем спецификацию

                            techCost = InsertTechOper(CInt(Me.Tag), Me.cmbVyborka.Tag, Me.cmbVyborka.SelectedValue, Me.nudKolvo.Value, orderIDforTech)
                        End If
                    End If
                Else 'реальный мат


                    Dim costMat@
                    Dim n As Integer

                    For n = 0 To Me.dgMat.Rows.Count - 1
                        Try
                            costMat = matQuantity * Module1.NonQuery1Scalar("SELECT TOP 1 priceOut FROM SkladAccountingUnits WHERE matID=" & Me.dgMat("matID", n).Value & "")

                            Dim numberN$ = number + "." + (n + 1).ToString

                            If n = 0 Then
                                orderIDforTech = InsertToOrders(Me.tmbMatTypes.Text, Me.dgMat("matID", n).Value, matQuantity, (costCut + costMat), "Плоттерная резка", Me.nudX.Value.ToString & "x" & Me.nudY.Value.ToString + " мм", numberN, CDec(Me.tstxtCostUnit.Text), Me.cmbSrok.Text) 'Пишем спецификацию
                            Else
                                orderIDforTech = InsertToOrders("", Me.dgMat("matID", n).Value, matQuantity, (costCut + costMat), "Плоттерная резка", Me.nudX.Value.ToString & "x" & Me.nudY.Value.ToString + " мм", numberN, CDec(Me.tstxtCostUnit.Text), "") 'Пишем спецификацию
                            End If

                            '*********Технологические операции
                            techCost = InsertTechOper(CInt(Me.Tag), Me.tmbMatTypes.Tag, Me.tmbMatTypes.SelectedValue, Me.nudKolvo.Value, orderIDforTech)

                        Catch ex As System.Exception
                            MsgBox(ex.Message, MsgBoxStyle.Critical, appName) : Exit For : Exit Sub
                        End Try
                    Next

                    If Me.chkMatMont.Checked = True Then
                        orderIDforTech = InsertToOrders("Пленка монтажная", Me.cmbMatMont.SelectedValue, matQuantity, costMont, "Плоттерная резка", Me.nudX.Value.ToString & "x" & Me.nudY.Value.ToString + " мм", (number + "." + (n + 1).ToString), costMont / Me.nudKolvo.Value, "") 'Пишем спецификацию

                        '         techCost = InsertTechOper(CInt(Me.Tag), Me.tmbMatTypes.Tag, Me.tmbMatTypes.SelectedValue, Me.nudKolvo.Value, orderIDforTech)

                        If Me.chkVyborka.Checked = True Then
                            orderIDforTech = InsertToOrders("Выборка", Module1.NonQuery1Scalar("SELECT matID FROM Materials WHERE virtMat=1"), matQuantity, costVyborka, "Плоттерная резка", Me.nudX.Value.ToString & "x" & Me.nudY.Value.ToString + " мм", (number + "." + (n + 2).ToString), costMont / Me.nudKolvo.Value, "Выборка " + Me.cmbVyborka.Text) 'Пишем спецификацию

                            techCost = InsertTechOper(CInt(Me.Tag), Me.cmbVyborka.Tag, Me.cmbVyborka.SelectedValue, Me.nudKolvo.Value, orderIDforTech)
                        End If
                    Else
                        If Me.chkVyborka.Checked = True Then
                            orderIDforTech = InsertToOrders("Выборка", Module1.NonQuery1Scalar("SELECT matID FROM Materials WHERE virtMat=1"), matQuantity, costVyborka, "Плоттерная резка", Me.nudX.Value.ToString & "x" & Me.nudY.Value.ToString + " мм", (number + "." + (n + 1).ToString), costVyborka / Me.nudKolvo.Value, "Выборка " + Me.cmbVyborka.Text) 'Пишем спецификацию

                            techCost = InsertTechOper(CInt(Me.Tag), Me.cmbVyborka.Tag, Me.cmbVyborka.SelectedValue, Me.nudKolvo.Value, orderIDforTech)
                        End If
                    End If
                End If

                Me.Close()
            Else
                Exit Sub
            End If
        End If
    End Sub

    Function InsertToOrders(ByVal strName As String, matID As Integer, matCount As Decimal, cost As Decimal, tech As String, sizeXY As String, num As String, costUnit As Decimal, strPrim As String) As Integer
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
            cmd.Parameters("@prim").Value = strPrim

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
            cmd.Parameters("@sostav").Value = ""  'цветность

            cmd.Parameters.Add(New SqlClient.SqlParameter("@edIzm", SqlDbType.Int))
            cmd.Parameters("@edIzm").Value = 1

            cmd.Parameters.Add(New SqlClient.SqlParameter("@technology", SqlDbType.NVarChar))
            cmd.Parameters("@technology").Value = tech

            cmd.Parameters.Add(New SqlClient.SqlParameter("@costUnit", SqlDbType.Decimal))
            cmd.Parameters("@costUnit").Value = costUnit  ' cost / Me.nudKolvo.Value

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
#End Region

    Private Sub КофигураторToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles КофигураторToolStripMenuItem.Click
        ConfigCalc(cmsConfigMat.SourceControl)

        LoadTypesMat()
    End Sub

    Private Sub LoadTypesMat()
        Dim list2 As String = Module1.NonQuery1ScalarString("SELECT listMatTypeID FROM CalcSettings WHERE serviceID = " & serviceID & " AND nameControl = '" & Me.tmbMatTypes.Text & "' ")

        If list2 = Nothing Then

        Else
            Dim odaMatType As New SqlClient.SqlDataAdapter("SELECT ID, Name FROM MatTypes where ID IN (" & list2 & ") order by Name", mcnnInt)
            Dim dtMatType As New DataTable : odaMatType.Fill(dtMatType)

            Me.cmbMatTypes.DataSource = dtMatType 'Связать данные со списком
            Me.cmbMatTypes.DisplayMember = "Name"
            Me.cmbMatTypes.ValueMember = "ID"

            Me.tstxtCostUnit.Text = ""
            Me.tstxtItog.Text = ""
        End If
    End Sub

    Private Sub ConfigCalc(ByRef ob As Object)
        Dim frmSelect As New frmConfigCalcMat
        Dim c As Control

        If emplID = Module1.NonQueryScalarInt("SELECT curator_ID FROM Services WHERE ID = " & serviceID & "") Or postPrioritet = 1 Then
            For Each c In ob.Parent.Controls
                If TypeOf c Is CheckBox Or TypeOf c Is Label Then 'ВНИМАНИЕ смотри тип элемента
                    If Mid(c.Name, 4) = Mid(ob.Name, 4) Then 'кто вызвал этот элемент управления
                        frmSelect.fff = c.Text
                        frmSelect.ShowDialog()
                        Exit For
                    End If
                End If

                If TypeOf c Is ComboBox Then 'ВНИМАНИЕ смотри тип элемента
                    If Mid(c.Name, 4) = Mid(ob.Name, 4) And c.Text <> ob.text Then 'кто вызвал этот элемент управления
                        frmSelect.fff = c.Text
                        frmSelect.ShowDialog()
                        Exit For
                    End If
                End If
            Next
        Else
            MsgBox("Нет прав на конфигурирование", MsgBoxStyle.Critical, appName)
        End If
    End Sub

    Private Sub tsbtnExit_Click(sender As System.Object, e As System.EventArgs) Handles tsbtnExit.Click
        Me.Close()
    End Sub

    Private Sub chkMatMont_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chkMatMont.CheckedChanged
        Me.cmbMatMont.Visible = sender.checked
    End Sub

    Private Sub chkVyborka_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chkVyborka.CheckedChanged
        Me.cmbVyborka.Visible = sender.checked
        'Me.cmbVyborka.SelectedIndex = 0
    End Sub

    Private Sub ДобавитьПродуктToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ДобавитьПродуктToolStripMenuItem.Click
        formTagNewProd = Me.Tag
        ModCallForm.CallForm("Продукт", 42, 3)
    End Sub

    Private Sub УдадитьПродуктToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles УдадитьПродуктToolStripMenuItem.Click
        Select Case MsgBox(Prompt:="Удалить  " & Trim(Me.tmbMatTypes.SelectedItem(1)) & "?", Buttons:=vbYesNo, Title:=appName)
            Case Is = vbYes
                Module1.NonQuery1("DELETE FROM awc_Polygraph WHERE ID = " & Me.tmbMatTypes.SelectedItem(0) & "")
            Case Is = vbNo
                Exit Sub
        End Select
    End Sub

    Private Sub ЗадатьТехнологическуюОперациюToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ЗадатьТехнологическуюОперациюToolStripMenuItem.Click
        Module1.ConfigTechOper(cmsProdTech.SourceControl, CInt(Me.Tag))
    End Sub

    Private Sub nudX_GotFocus(sender As Object, e As EventArgs) Handles nudX.GotFocus
        sender.Select(0, (Len(sender.Value.ToString)))
    End Sub

    Private Sub nudY_GotFocus(sender As Object, e As EventArgs) Handles nudY.GotFocus
        sender.Select(0, (Len(sender.Value.ToString)))
    End Sub

    Private Sub nudX_MouseClick(sender As Object, e As MouseEventArgs) Handles nudX.MouseClick
        sender.Select(0, (Len(sender.Value.ToString)))
    End Sub

    Private Sub nudY_MouseClick(sender As Object, e As MouseEventArgs) Handles nudY.MouseClick
        sender.Select(0, (Len(sender.Value.ToString)))
    End Sub

    Private Sub nudKolvo_GotFocus(sender As Object, e As EventArgs) Handles nudKolvo.GotFocus
        sender.Select(0, (Len(sender.Value.ToString)))
    End Sub

    Private Sub nudKolvo_MouseClick(sender As Object, e As MouseEventArgs) Handles nudKolvo.MouseClick
        sender.Select(0, (Len(sender.Value.ToString)))
    End Sub

    Private Sub tmbMat_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbSelect.SelectedIndexChanged
        If Me.cmbSelect.SelectedIndex = 0 Then
            Me.Label1.Text = "Количество слоев"
            Me.cmbMat.Visible = False
            Me.cmbMatTypes.Visible = False
            Me.btnAdd.Visible = False
            Me.nudKolSloev.Visible = True
            Me.dgMat.Visible = False
        Else
            Me.cmbMatTypes.Visible = True
            Me.cmbMat.Visible = True
            Me.dgMat.Visible = True
            Me.btnAdd.Visible = True
            Me.Label1.Text = "Элементы"
            Me.dgMat.Visible = True
            Me.nudKolSloev.Visible = False
        End If
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        If Me.cmbMatTypes.SelectedIndex = -1 Then MsgBox("Не выбран тип краски", MsgBoxStyle.Critical, appName) : Exit Sub
        If Me.cmbMat.SelectedIndex = -1 Then MsgBox("Не выбрана краска", MsgBoxStyle.Critical, appName) : Exit Sub

        Me.dgMat.Rows.Add()
        Me.dgMat.ClearSelection()

        Dim countRows As Integer = Me.dgMat.Rows.Count

        Me.dgMat.Item("range", countRows - 1).Value = CInt(countRows)
        Me.dgMat.Item("matID", countRows - 1).Value = Me.cmbMat.SelectedItem(0)
        Me.dgMat.Item("cost", countRows - 1).Value = Module1.NonQuery1Scalar("SELECT nacenka FROM Materials WHERE matID=" & Me.cmbMat.SelectedItem(0) & "")
        Me.dgMat.Item("NameMat", countRows - 1).Value = Me.cmbMat.Text
    End Sub

    Private Sub cmbMatTypes_SelectedValueChanged(sender As Object, e As EventArgs) Handles cmbMatTypes.SelectedValueChanged
        Try
            If sender.SelectedIndex <> -1 Then
                Dim odaMat1 As New SqlClient.SqlDataAdapter("SELECT matID, matName FROM Materials WHERE typeID=" & sender.SelectedItem(0) & " AND accessible=1 order by matName", mcnnInt)
                Dim dtMat1 As New DataTable : odaMat1.Fill(dtMat1)

                Me.cmbMat.DataSource = dtMat1 'Связать данные со списком
                Me.cmbMat.DisplayMember = "matName"
                Me.cmbMat.ValueMember = "matID"
            Else
                Me.cmbMat.DataSource = Nothing
            End If
        Catch ex As System.Exception
            MsgBox("error" & ex.Message, MsgBoxStyle.Critical, appName)
        End Try
    End Sub

    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem1.Click
        Module1.ConfigTechOper(Me.cmsConfigTech.SourceControl, CInt(Me.Tag))
    End Sub

    Private Sub tmbMatTypes_SelectedValueChanged(sender As Object, e As EventArgs) Handles tmbMatTypes.SelectedValueChanged
        LoadTypesMat()
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
            MsgBox("Универсальный прайс, загрузка." & ex.Message, MsgBoxStyle.Critical, appName)
        End Try
    End Sub
End Class