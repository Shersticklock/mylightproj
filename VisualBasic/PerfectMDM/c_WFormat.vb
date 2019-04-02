Public Class c_WFormat

    Dim Itogo%, CostFromPrice@
    Dim ocmd As New SqlClient.SqlCommand
    '***********
    Dim colorStr$
    Dim kolvoSlista As Decimal
    Dim tech$

#Region " Загрузка и очистка формы "
    Private Sub mdm_WFormat_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim odaProd As New SqlClient.SqlDataAdapter("SELECT ID, Name FROM awc_Polygraph WHERE serviceID=" & serviceID & " order by name", mcnnInt)
        Dim dtProd As New DataTable : odaProd.Fill(dtProd)

        Me.cmbProd.DataSource = dtProd 'Связать данные со списком
        Me.cmbProd.DisplayMember = "Name"
        Me.cmbProd.ValueMember = "ID"


        Try 'Читаем наименования групп прайсов
            Dim odaGroupPrice As New SqlClient.SqlDataAdapter("SELECT ID, groupName FROM PriceGroup WHERE serviceID=" & serviceID & " order by groupName", mcnnInt)
            Dim dtGroupPrice As New DataTable : odaGroupPrice.Fill(dtGroupPrice)

            Me.cmbPriceGroup.DataSource = dtGroupPrice
            Me.cmbPriceGroup.DisplayMember = "groupName"
            Me.cmbPriceGroup.ValueMember = "ID"
            Me.cmbPriceGroup.SelectedIndex = -1

            Me.Label4.Text = Trim(Module1.NonQuery1ScalarString("SELECT COALESCE(description, 'Не задано') FROM Services WHERE ID=" & serviceID & ""))
        Catch ex As System.Exception
        End Try
    End Sub

    Private Sub NewCost()
        Me.txtPrim.Text = Nothing
        Me.tstxtItog.Text = Nothing
        Me.tscmbSkidka.Enabled = True
    End Sub
#End Region

#Region " Расчет цены "
    Private Sub tsbtnCost_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbtnCost.Click
        If Me.cmbPriceGroup.SelectedIndex = -1 Then MsgBox("Не выбрана группа") : Me.cmbPriceGroup.Focus() : Exit Sub
        If Me.cmbPriceName.SelectedIndex = -1 Then MsgBox("Не выбрана продукция") : Me.cmbPriceName.Focus() : Exit Sub
        If Me.cmbParam2.SelectedIndex = -1 Then MsgBox("Не выбран параметр") : Me.cmbParam2.Focus() : Exit Sub
        If Me.cmbMat.SelectedIndex = -1 Then MsgBox("Не выбран материал") : Me.cmbMat.Focus() : Exit Sub

        Dim s%, costColor@

        For i As Integer = 0 To Me.clbNacenki.Items.Count - 1
            If Me.clbNacenki.GetItemChecked(i) = True Then
                Me.clbNacenki.SelectedIndex = i
                s += CInt(Me.clbNacenki.SelectedValue)
            End If
        Next

        Dim k_skidka@ = (100 - Val(Me.tscmbSkidka.Text)) / 100 'скидка

        Dim minTir% = Module1.NonQueryScalarInt("select min(name) from PriceCost inner join [PriceParam1] on PriceCost.param1ID= PriceParam1.ID where([PriceParam1].[groupID]=" & Me.cmbPriceGroup.SelectedItem(0) & " And PriceCost.priceNameID=" & Me.cmbPriceName.SelectedItem(0) & ") and PriceCost.param2ID=" & Me.cmbParam2.SelectedItem(0) & "")

        If Me.nudQuantity.Value < minTir Then
            '  MsgBox("Минимальный тираж с такими параметрами = " & CStr(minTir), MsgBoxStyle.Critical, appName)
            Me.nudQuantity.Minimum = minTir
        End If

        kolvoSlista = Module1.NonQuery1Scalar("SELECT kolvoSlista FROM PriceParam2 WHERE ID=" & Me.cmbParam2.SelectedItem(0) & "")

        Me.ToolStripLabel3.Text = "цена за п.м"

        CostFromPrice = Me.nudQuantity.Value * NonQuery1Scalar("Select dbo.[costUniCalcMatAdd](" & Me.cmbMat.SelectedItem(0) & "," & Me.cmbPriceName.SelectedItem(0) & "," & Me.cmbParam2.SelectedItem(0) & "," & Me.nudY.Value & ")")

        Itogo = CostFromPrice * (100 + s) / 100 * k_skidka '+ Me.nudQuantity.Value * costMat / kolvoSlista

        '  Itogo = RoundUp(Itogo / Me.nudQuantity.Value * 100) / 100 * Me.nudQuantity.Value

        tech = Me.cmbPriceName.Text + ", " + Me.txtPrim2.Text + Me.cmbParam2.Text

        Me.txtPrim.Text = Me.cmbPriceGroup.Text + ", " + tech

        ' Dim newCost As Decimal = RoundUp(Itogo / Me.nudQuantity.Value * 100) / 100 * Me.nudQuantity.Value

        Me.tstxtItog.Text = Itogo 'Format(Itogo, "0.####")

        Me.tstxtCostUnit.Text = Format(Itogo / Me.nudQuantity.Value, "0.##")
        '***************
        costColor = 0
    End Sub
#End Region

#Region " Добавить расчет к заказу "
    Dim esheRashet As Boolean

    Private Sub tsbtnOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbtnOK.Click
        esheRashet = False

        Save()
    End Sub

    Private Sub ToolStripButton1_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripButton1.Click
        esheRashet = True

        Save()
    End Sub

    Private Sub Save()
        If costID = Nothing Then
            Select Case MsgBox(Prompt:="Закрыть расчет? ", Buttons:=vbYesNo, Title:=appName)
                Case Is = vbYes : Me.Close()
                Case Is = vbNo : Exit Sub
            End Select
        Else
            If MessageBox.Show("Добавить расчет к заказу?", appName + " - Калькуляция", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                If Not IsNumeric(Me.tstxtItog.Text) Then MsgBox("Не корректное значение стоимости", MsgBoxStyle.Critical, appName) : Me.tstxtItog.Focus() : Exit Sub
                If Me.txtPrim2.Text = Nothing Then MsgBox("Не заполнен обрезной формат", MsgBoxStyle.Critical, appName) : Me.txtPrim2.Focus() : Exit Sub

                Try
                    Dim orderIDforTech% = InsertToOrders(colorStr) 'Пишем спецификацию
                    '*********Технологические операции

                    Dim techCost@ = InsertTechOper(CInt(Me.Tag), Me.cmbPriceName.Tag, Me.cmbPriceName.SelectedItem(0), Me.nudQuantity.Value * kolvoSlista, orderIDforTech)
                    techCost += InsertTechOper(CInt(Me.Tag), Me.cmbParam2.Tag, Me.cmbParam2.SelectedItem(0), Me.nudQuantity.Value * kolvoSlista, orderIDforTech)

                    Dim itemChecked As Object 'выборка по состоянию

                    For Each itemChecked In Me.clbNacenki.CheckedItems
                        techCost += InsertTechOper(CInt(Me.Tag), Me.clbNacenki.Tag, itemChecked.item(0), Me.nudQuantity.Value, orderIDforTech)
                    Next

                    If esheRashet = False Then
                        Me.Close()
                    End If
                Catch excData As System.Exception
                    MsgBox(excData.Message, MsgBoxStyle.Critical, appName)
                    Exit Sub
                End Try
            Else
                Exit Sub
            End If
        End If
    End Sub

    Function InsertToOrders(ByVal colorstr As String) As Integer

        Dim cmd As New SqlClient.SqlCommand

        Try
            cmd.Connection = mcnnInt
            cmd.CommandText = "sp_CalcToOrders"
            cmd.CommandType = CommandType.StoredProcedure
            'Описываем параметры
            cmd.Parameters.Add(New SqlClient.SqlParameter("@serviceID", SqlDbType.Int))
            cmd.Parameters("@serviceID").Value = serviceID

            cmd.Parameters.Add(New SqlClient.SqlParameter("@cost", SqlDbType.Decimal))
            cmd.Parameters("@cost").Value = Me.tstxtItog.Text

            cmd.Parameters.Add(New SqlClient.SqlParameter("@costID", SqlDbType.Int))
            cmd.Parameters("@costID").Value = costID

            cmd.Parameters.Add(New SqlClient.SqlParameter("@prim", SqlDbType.NVarChar))
            cmd.Parameters("@prim").Value = Me.txtPrim.Text

            If Me.cmbMat.SelectedIndex = -1 Then
                cmd.Parameters.Add(New SqlClient.SqlParameter("@matID", SqlDbType.Int))
                cmd.Parameters("@matID").Value = Module1.NonQuery1Scalar("SELECT matID From materials where matzak=1")
            Else
                cmd.Parameters.Add(New SqlClient.SqlParameter("@matID", SqlDbType.Int))
                cmd.Parameters("@matID").Value = Me.cmbMat.SelectedValue
            End If

            cmd.Parameters.Add(New SqlClient.SqlParameter("@data", SqlDbType.DateTime))
            cmd.Parameters("@data").Value = Now()

            cmd.Parameters.Add(New SqlClient.SqlParameter("@sostav", SqlDbType.NVarChar))
            cmd.Parameters("@sostav").Value = "1"

            cmd.Parameters.Add(New SqlClient.SqlParameter("@edIzm", SqlDbType.Int))
            cmd.Parameters("@edIzm").Value = Me.cmbPrintFormat.SelectedItem(0)

            cmd.Parameters.Add(New SqlClient.SqlParameter("@technology", SqlDbType.NVarChar))
            cmd.Parameters("@technology").Value = "нет"

            cmd.Parameters.Add(New SqlClient.SqlParameter("@costUnit", SqlDbType.Decimal))
            cmd.Parameters("@costUnit").Value = Me.tstxtItog.Text / Me.nudQuantity.Value

            cmd.Parameters.Add(New SqlClient.SqlParameter("@sizeCut", SqlDbType.NVarChar))
            cmd.Parameters("@sizeCut").Value = ""

            cmd.Parameters.Add(New SqlClient.SqlParameter("@kolvo", SqlDbType.Int))
            cmd.Parameters("@kolvo").Value = Me.nudQuantity.Value

            cmd.Parameters.Add(New SqlClient.SqlParameter("@matCount", SqlDbType.Int))
            cmd.Parameters("@matCount").Value = Me.nudQuantity.Value * kolvoSlista

            cmd.Parameters.Add(New SqlClient.SqlParameter("@nameForDoc", SqlDbType.NVarChar))
            cmd.Parameters("@nameForDoc").Value = Me.cmbProd.Text + ", " + Me.cmbPriceGroup.Text + ", " + Me.cmbParam2.Text + ", " + Me.txtPrim2.Text

            cmd.Parameters.Add(New SqlClient.SqlParameter("@nomer", SqlDbType.NVarChar))
            cmd.Parameters("@nomer").Value = Module1.NonQuery1Scalar("SELECT coalesce(max(FLOOR(CONVERT(decimal(10,5), number))),0) +1 FROM orders WHERE costID=" & costID & "").ToString

            '  cmd.Parameters.Add(New SqlClient.SqlParameter("@printFormatID", SqlDbType.Int))
            ' cmd.Parameters("@printFormatID").Value = Me.cmbPrintFormat.SelectedItem(0)

            '  cmd.Parameters.Add(New SqlClient.SqlParameter("@printFormatCount", SqlDbType.Int))
            ' cmd.Parameters("@printFormatCount").Value = 123

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

#Region " Выбор группы "
    Private Sub cmbPriceGroup_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbPriceGroup.SelectedIndexChanged
        If Me.cmbPriceGroup.SelectedIndex <> -1 Then
            Me.lblMatTypes.Text = sender.text + "**"
            LoadNac()
            LoadPrice()
            NewCost()

            Try
                Dim strSQL1$ = "SELECT listMatTypeID FROM CalcSettings WHERE serviceID=" & serviceID & " AND nameControl='" & Me.lblMatTypes.Text & "'"
                Dim odaMatType As New SqlClient.SqlDataAdapter("SELECT ID, Name FROM MatTypes where ID IN (" & Module1.NonQuery1ScalarString(strSQL1) & ") order by Name ", mcnnInt)
                Dim dtMatType As New DataTable : odaMatType.Fill(dtMatType)

                Me.cmbMatTypes.DataSource = dtMatType 'Связать данные со списком
                Me.cmbMatTypes.DisplayMember = "Name"
                Me.cmbMatTypes.ValueMember = "ID"

                Me.Label3.Text = Trim(Module1.NonQuery1ScalarString("SELECT COALESCE(param2name, 'Не задан') FROM PriceGroup WHERE ID=" & Me.cmbPriceGroup.SelectedItem(0) & ""))
            Catch ex As System.Exception
            End Try
        End If

        Me.cmbPriceName.SelectedIndex = -1
        Me.cmbParam2.SelectedIndex = -1
        Me.cmbMatTypes.SelectedIndex = -1
        Me.cmbMat.SelectedIndex = -1
    End Sub
#End Region

#Region " Загрузка прайсов "
    Private Sub LoadPrice()
        Try
            Dim odaPriceName As New SqlClient.SqlDataAdapter("select distinct rrr.ID, rrr.namePrice, rrr.groupID from [PriceCost] pc inner join (SELECT ID, namePrice, groupID FROM PriceName) rrr on pc.priceNameID=rrr.id inner join (SELECT [ID] FROM [PriceParam2]) p2 ON p2.ID=pc.param2ID where rrr.groupID=" & Me.cmbPriceGroup.SelectedItem(0) & " order by namePrice", mcnnInt)
            Dim dtPriceName As New DataTable : odaPriceName.Fill(dtPriceName)

            Me.cmbPriceName.DataSource = dtPriceName
            Me.cmbPriceName.DisplayMember = "namePrice"
            Me.cmbPriceName.ValueMember = "ID"
        Catch ex As System.Exception
        End Try
    End Sub
#End Region

#Region " Загрузка наценок "
    Private Sub LoadNac()
        Try
            Dim odaNacenki As New SqlClient.SqlDataAdapter("SELECT ID, nacName, nacValue FROM PriceNacenki WHERE groupID=" & Me.cmbPriceGroup.SelectedItem(0) & "", mcnnInt)
            Dim dtNacenki As New DataTable : odaNacenki.Fill(dtNacenki)

            Me.clbNacenki.DataSource = dtNacenki
            Me.clbNacenki.DisplayMember = "nacName"
            Me.clbNacenki.ValueMember = "nacValue"
        Catch ex As System.Exception
        End Try
    End Sub
#End Region

    Private Sub cmbTirag_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        Dim KeyAscii% = Asc(e.KeyChar)

        Select Case KeyAscii
            Case 48 To 57, 8, 44, 46
            Case Else
                KeyAscii = 0
        End Select
        If KeyAscii = 0 Then
            e.Handled = True
        Else
            e.Handled = False
        End If
    End Sub

    Private Sub cmbColor_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbParam2.SelectedIndexChanged
        NewCost()
    End Sub

    Private Sub cmbPriceName_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbPriceName.SelectedIndexChanged
        Try
            Dim strSQL$ = "SELECT DISTINCT PriceParam2.ID, PriceParam2.name FROM PriceCost "
            strSQL &= "INNER JOIN PriceParam2  ON PriceCost.param2ID=PriceParam2.ID WHERE PriceParam2.serviceID=" & serviceID & " "
            strSQL &= "and PriceCost.priceNameID = " & Me.cmbPriceName.SelectedItem(0) & " order by name"

            'Читаем наименования парметра-2
            Dim odaPriceParam2 As New SqlClient.SqlDataAdapter(strSQL, mcnnInt)
            Dim dtPriceParam2 As New DataTable : odaPriceParam2.Fill(dtPriceParam2)

            Me.cmbParam2.DataSource = dtPriceParam2
            Me.cmbParam2.DisplayMember = "name"
            Me.cmbParam2.ValueMember = "ID"

            NewCost()
        Catch ex As System.Exception
        End Try
    End Sub

    Private Sub tsbtnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbtnExit.Click
        Me.Close()
    End Sub

    Private Sub tsbtnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbtnClear.Click
        NewCost()
    End Sub

    Private Sub КофигураторToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles КофигураторToolStripMenuItem.Click
        ConfigCalc(cmsCalcConfig.SourceControl)
    End Sub

    Private Sub ConfigCalc(ByRef ob As Object)
        Dim frmSelect As New frmConfigCalcMat
        Dim c As Control
        'ob контрол к которому привязано меню

        If emplID = Module1.NonQueryScalarInt("SELECT curator_ID FROM Services WHERE ID=" & serviceID & "") Or postPrioritet = 1 Then
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

    '**************
    Private Sub cmbMatTypes_SelectedValueChanged(sender As Object, e As System.EventArgs) Handles cmbMatTypes.SelectedValueChanged
        Try
            If Me.cmbMatTypes.SelectedIndex <> -1 Then
                Dim odaMat1 As New SqlClient.SqlDataAdapter("SELECT matID, matName FROM Materials WHERE typeID=" & sender.SelectedItem(0) & " AND accessible=1 order by matName", mcnnInt)
                Dim dtMat1 As New DataTable : odaMat1.Fill(dtMat1)

                Me.cmbMat.DataSource = dtMat1 'Связать данные со списком
                Me.cmbMat.DisplayMember = "matName"
                Me.cmbMat.ValueMember = "matID"
            End If
        Catch ex As System.Exception
            MsgBox("error" & ex.Message, MsgBoxStyle.Critical, appName)
        End Try
    End Sub

    Private Sub ДобавитьПродуктToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ДобавитьПродуктToolStripMenuItem.Click
        formTagNewProd = Me.Tag

        ModCallForm.CallForm("Продукт", 42, 3)
    End Sub

    Private Sub УдадитьПродуктToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles УдадитьПродуктToolStripMenuItem.Click
        Select Case MsgBox(Prompt:="Удалить  " & Trim(Me.cmbProd.SelectedItem(1)) & "?", Buttons:=vbYesNo, Title:=appName)
            Case Is = vbYes
                Module1.NonQuery1("DELETE FROM awc_Polygraph WHERE ID=" & Me.cmbProd.SelectedItem(0) & "")
            Case Is = vbNo
                Exit Sub
        End Select
    End Sub

    Private Sub ЗадатьТехнологическуюОперациюToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ЗадатьТехнологическуюОперациюToolStripMenuItem.Click
        Module1.ConfigTechOper(cmsCalcConfigTech.SourceControl, CInt(Me.Tag))
    End Sub

    Private Sub ЗадатьТехнологическуюОперациюToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ЗадатьТехнологическуюОперациюToolStripMenuItem1.Click
        Module1.ConfigTechOper(cmsCalcConfigTech.SourceControl, CInt(Me.Tag))
    End Sub

    Private Sub nudY_GotFocus(sender As Object, e As EventArgs) Handles nudY.GotFocus
        sender.Select(0, (Len(sender.Value.ToString)))
    End Sub

    Private Sub nudY_MouseClick(sender As Object, e As MouseEventArgs) Handles nudY.MouseClick
        sender.Select(0, (Len(sender.Value.ToString)))
    End Sub

    Private Sub nudQuantity_GotFocus(sender As Object, e As EventArgs) Handles nudQuantity.GotFocus
        sender.Select(0, (Len(sender.Value.ToString)))
    End Sub

    Private Sub nudQuantity_MouseClick(sender As Object, e As MouseEventArgs) Handles nudQuantity.MouseClick
        sender.Select(0, (Len(sender.Value.ToString)))
    End Sub

    Dim dtMatFormats As DataTable

    Private Sub cmbMat_SelectedValueChanged(sender As Object, e As EventArgs) Handles cmbMat.SelectedValueChanged
        If Me.cmbMat.SelectedIndex <> -1 Then
            Dim cmd As New SqlClient.SqlCommand
            cmd.Connection = mcnnInt
            cmd.CommandText = "[sp_MatPrintFormat]"
            cmd.CommandType = CommandType.StoredProcedure

            cmd.Parameters.Add(New SqlClient.SqlParameter("@matID", SqlDbType.Int))
            cmd.Parameters("@matID").Value = Me.cmbMat.SelectedItem(0)

            Dim odaMan As New SqlClient.SqlDataAdapter(cmd)
            dtMatFormats = New DataTable : odaMan.Fill(dtMatFormats)

            Me.cmbPrintFormat.DataSource = dtMatFormats 'Связать данные со списком
            Me.cmbPrintFormat.DisplayMember = "formatName"
            Me.cmbPrintFormat.ValueMember = "unitID"
        Else
            Me.cmbPrintFormat.DataSource = Nothing
        End If
    End Sub

 
    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs) Handles ToolStripButton2.Click
        If emplID = Module1.NonQuery1Scalar("SELECT curator_ID FROM Services WHERE ID=" & serviceID & "") Or postPrioritet = 1 Then
            ModCallForm.CallForm("Установка цен", 2, 2)
        Else
            MsgBox("Доступ запрещен", MsgBoxStyle.Critical, appName)
        End If
    End Sub

    Private Sub nudQuantity_ValueChanged(sender As Object, e As EventArgs) Handles nudQuantity.ValueChanged
        Me.tscmbSkidka.ComboBox.DataSource = Nothing

        Try
            Dim odaDiscont As New SqlClient.SqlDataAdapter("SELECT awc_Discont.ID, awc_Discont.Name FROM awc_Discont INNER JOIN awc_DiscontServices ON awc_Discont.ID=awc_DiscontServices.discontID WHERE awc_DiscontServices.serviceID=" & serviceID & " AND quantity<=" & Me.nudQuantity.Value & " AND " & Me.nudQuantity.Value & "<=quantity2 order by awc_Discont.description", mcnnInt)
            Dim dtDiscont As New DataTable

            odaDiscont.Fill(dtDiscont)

            Me.tscmbSkidka.ComboBox.DataSource = dtDiscont 'Связать данные со списком
            Me.tscmbSkidka.ComboBox.DisplayMember = "Name"
            Me.tscmbSkidka.ComboBox.ValueMember = "ID"
        Catch ex As System.Exception
            '   MsgBox("Универсальный прайс, загрузка." & ex.Message, MsgBoxStyle.Critical, appName)
        End Try
    End Sub

End Class