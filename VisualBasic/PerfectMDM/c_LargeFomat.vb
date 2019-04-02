Public Class c_LargeFomat

    Dim prim As String = ""
    Dim disc As Integer = 0
    Dim matQuantityLF As Decimal

    Private Sub mdm_LargeFomat_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        '  skidkaCust = Module1.NonQuery1Scalar("Select coalesce(Discount, 0) From KA_ServDisccount Where ID_KA=" & custID & " AND ID_Service=" & serviceID & "")
     
        Dim odaTech As New SqlClient.SqlDataAdapter("SELECT ID, nameTech FROM awc_CalcTech WHERE calcID=" & CInt(Me.Tag) & " AND controlTag='" & Me.cmbModeCost.Tag & "' AND serviceID=" & serviceID & "", mcnnInt)
        Dim dtTech As New DataTable : odaTech.Fill(dtTech)

        Me.cmbModeCost.DataSource = dtTech 'Связать данные со списком
        Me.cmbModeCost.DisplayMember = "nameTech"
        Me.cmbModeCost.ValueMember = "ID"
        Me.cmbModeCost.SelectedIndex = -1


        'Me.cmbModeCost.Items.Add("360 dpi")
        'Me.cmbModeCost.Items.Add("720 dpi")
        'Me.cmbModeCost.Items.Add("1440 dpi")
        'Me.cmbModeCost.Items.Add("360 dpi для РА")
        'Me.cmbModeCost.Items.Add("720 dpi для РА")
        'Me.cmbModeCost.Items.Add("1440 dpi для РА")


        Me.Label15.Visible = False
        Me.clbOper.Visible = False

        'Читаем наименования срочности
        Dim odaSrok As New SqlClient.SqlDataAdapter("SELECT nac, Name FROM unicalcSrokNac", mcnnInt)
        Dim dtSrok As New DataTable : odaSrok.Fill(dtSrok)

        Me.cmbSrok.DataSource = dtSrok
        Me.cmbSrok.DisplayMember = "Name"
        Me.cmbSrok.ValueMember = "nac"
        Me.cmbSrok.SelectedIndex = 0

        Try
            Dim odaProd As New SqlClient.SqlDataAdapter("SELECT ID, Name FROM awc_Polygraph WHERE serviceID=" & serviceID & " order by name", mcnnInt)
            Dim dtProd As New DataTable : odaProd.Fill(dtProd)
            Me.cmbProd.DataSource = dtProd 'Связать данные со списком
            Me.cmbProd.DisplayMember = "Name"
            Me.cmbProd.ValueMember = "ID"

            Dim odaLuv As New SqlClient.SqlDataAdapter("SELECT ID, nameTech FROM awc_CalcTech WHERE serviceID=" & serviceID & " AND controlTag='LFluvers'", mcnnInt)
            Dim dtLuv As New DataTable : odaLuv.Fill(dtLuv)

            Me.cmbLuvers.DataSource = dtLuv 'Связать данные со списком
            Me.cmbLuvers.DisplayMember = "nameTech"
            Me.cmbLuvers.ValueMember = "ID"

            Dim odaKarman As New SqlClient.SqlDataAdapter("SELECT ID, nameTech FROM awc_CalcTech WHERE serviceID=" & serviceID & " AND controlTag='LFKarman'", mcnnInt)
            Dim dtKarman As New DataTable : odaKarman.Fill(dtKarman)

            Me.cmbKarman.DataSource = dtKarman 'Связать данные со списком
            Me.cmbKarman.DisplayMember = "nameTech"
            Me.cmbKarman.ValueMember = "ID"

            Dim odaKraya As New SqlClient.SqlDataAdapter("SELECT ID, nameTech FROM awc_CalcTech WHERE serviceID=" & serviceID & " AND controlTag='LFKraya'", mcnnInt)
            Dim dtKraya As New DataTable : odaKraya.Fill(dtKraya)

            Me.cmbKraya.DataSource = dtKraya 'Связать данные со списком
            Me.cmbKraya.DisplayMember = "nameTech"
            Me.cmbKraya.ValueMember = "ID"

            Dim list1 As String = Module1.NonQuery1ScalarString("SELECT listMatTypeID FROM CalcSettings WHERE serviceID=" & serviceID & " AND nameControl='" & Trim(Me.lblMatTypes1.Text) & "'")
            Dim odaMatType As New SqlClient.SqlDataAdapter("SELECT ID, Name FROM MatTypes where ID IN (" & list1 & ") order by Name", mcnnInt)
            Dim dtMatType As New DataTable : odaMatType.Fill(dtMatType)

            Me.tmbProd.DataSource = dtMatType 'Связать данные со списком
            Me.tmbProd.DisplayMember = "Name"
            Me.tmbProd.ValueMember = "ID"
        Catch ex As System.Exception
            '   MsgBox("error Скорее всего не запрфилированы карманы, люверсы или края. Проверь наличие операций и их конфу в калике." & ex.Message, MsgBoxStyle.Critical, appName)
            '  Exit Sub
        End Try
    End Sub

    Private Sub КофигураторToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles КофигураторToolStripMenuItem.Click
        ConfigCalc(cmsConfigMat.SourceControl)
    End Sub

    Private Sub ConfigCalc(ByRef ob As Object)
        Dim frmSelect As New frmConfigCalcMat
        Dim c As Control

        If postPrioritet = 1 Then
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

    Private Sub cmbMatTypes1_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles tmbProd.SelectedIndexChanged
        Try
            If sender.SelectedIndex <> -1 Then
                Dim odaMat As New SqlClient.SqlDataAdapter("SELECT matID, matName FROM Materials WHERE typeID = " & sender.SelectedItem(0) & " AND accessible = 1 order by matName", mcnnInt)
                Dim dtMat As New DataTable : odaMat.Fill(dtMat)

                Me.cmbMat.DataSource = dtMat 'Связать данные со списком
                Me.cmbMat.DisplayMember = "matName"
                Me.cmbMat.ValueMember = "matID"
            End If
        Catch ex As System.Exception
            MsgBox("error" & ex.Message, MsgBoxStyle.Critical, appName)
        End Try
    End Sub

    Private Sub cmbLuvers_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbLuvers.SelectedIndexChanged
        Me.pnLuvers.Visible = CBool(sender.SelectedIndex)
    End Sub

    Private Sub cmbKarman_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbKarman.SelectedIndexChanged
        Me.pnKarman.Visible = CBool(sender.SelectedIndex)
    End Sub

    Private Sub cmbKraya_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbKraya.SelectedIndexChanged
        Me.pnKraya.Visible = CBool(sender.SelectedIndex)
    End Sub

    Private Sub tsbtnCost_Click(sender As System.Object, e As System.EventArgs) Handles tsbtnCost.Click
        Dim strLuvers$, strKarman$, strKraya$, costTechBase@
       
        If Me.cmbModeCost.SelectedIndex = -1 Then
            MsgBox("Выбери режим расчета", MsgBoxStyle.Critical, appName) : Me.cmbModeCost.Focus() : Exit Sub
        End If

        If Me.nudX.Value = 0 Or Me.nudY.Value = Nothing Then
            MsgBox("Не указан размер", MsgBoxStyle.Critical, appName) : Exit Sub
        End If

        prim = Nothing

        If Me.tmbProd.SelectedIndex = -1 Then
            MsgBox("НЕ выбрана подложка", MsgBoxStyle.Critical, appName) : Exit Sub
        End If

        Dim s As Decimal = Me.nudX.Value * Me.nudY.Value
        Dim l As Decimal = 2 * (Me.nudX.Value + Me.nudY.Value)
        Dim nacenka As Integer

        Dim costMat@, nacMat@, costProchee@, itogo@

        matQuantityLF = Me.nudKolvo.Value * s
        costTechBase = Module1.NonQuery1Scalar("SELECT[dbo].[costTechOperCMB] (" & Replace(matQuantityLF, ",", ".") & ",'" & Me.Tag & "','" & Me.cmbModeCost.Tag & "'," & Me.cmbModeCost.SelectedItem(0) & "," & serviceID & ",1," & Me.nudKolvo.Value & "," & disc & ")")
        costMat = Module1.NonQuery1Scalar("SELECT TOP 1 priceOut FROM SkladAccountingUnits WHERE matID=" & Me.cmbMat.SelectedItem(0) & "")
        nacMat = Module1.NonQuery1Scalar("SELECT nacenka FROM Materials WHERE matID=" & Me.cmbMat.SelectedItem(0) & "")

        Select Case Me.cmbModeCost.SelectedIndex
            Case Is = 0 '360:    dpi()
                Select Case matQuantityLF
                    Case Is > 50 : nacenka = nacMat * 0.95
                    Case Is >= 1 : nacenka = nacMat * 1.1
                    Case Is < 1 : nacenka = nacMat * 3
                End Select
            Case Is = 1 '720:    dpi()
                Select Case matQuantityLF
                    Case Is > 50 : nacenka = nacMat * 1.1
                    Case Is >= 1 : nacenka = nacMat * 1.3
                    Case Is < 1 : nacenka = nacMat * 3
                End Select
            Case Is = 2 '1440:   dpi()
                Select Case matQuantityLF
                    Case Is > 50 : nacenka = nacMat * 2.3
                    Case Is >= 1 : nacenka = nacMat * 2.5
                    Case Is < 1 : nacenka = nacMat * 3
                End Select
            Case Is = 3 '360 dpi для РА 
                nacenka = nacMat * 0.9
            Case Is = 4 '720 dpi для РА 
                nacenka = nacMat
            Case Is = 5 '1440 dpi для РА 
                nacenka = nacMat * 1.2
        End Select

        Dim costOper@ = 0
        Dim signFerst As Boolean = True
        Dim strOper$ = Nothing

        For Each itemChecked As Object In Me.clbOper.CheckedItems
            If signFerst = False Then
                strOper += "," + itemChecked.item(0).ToString
                prim += "," + itemChecked.item(1).ToString
            Else
                strOper = itemChecked.item(0).ToString
                prim += itemChecked.item(1).ToString
                signFerst = False
            End If
        Next

        If signFerst = False Then
            costOper = Module1.NonQuery1Scalar("SELECT[dbo].[costTechOperCLB] (" & Replace(matQuantityLF, ",", ".") & ",'" & strOper & "',1," & Me.nudKolvo.Value & "," & disc & ")")
        Else
            costOper = 0
        End If

        Dim costDopOper@ = 0

        If Me.cmbLuvers.SelectedIndex = 1 Then 'считаем люверс
            If Me.chkLuvUp.Checked = False And Me.chkLuvDn.Checked = False And Me.chkLuvLeft.Checked = False And Me.chkLuvRight.Checked = False Then
                MsgBox("Не выбраны места установки люверсов", MsgBoxStyle.Critical, appName) : Exit Sub
            End If

            If Me.rbn10mm.Checked = True Then
                strLuvers = "Люверс - 10 мм, дистанция- " & Me.nudLuvDistancia.Value.ToString & " m"
            Else
                strLuvers = "Люверс - 12 мм, дистанция- " & Me.nudLuvDistancia.Value.ToString & " m"
            End If

            Dim kolVoLuvers% = 0

            If Me.chkLuvUp.Checked = True Then
                kolVoLuvers = Me.nudX.Value * 100 \ Me.nudLuvDistancia.Value * 100
                strLuvers += ", сверху"
            End If

            If Me.chkLuvDn.Checked = True Then
                kolVoLuvers += Me.nudX.Value * 100 \ Me.nudLuvDistancia.Value * 100
                strLuvers += ", снизу"
            End If

            If Me.chkLuvLeft.Checked = True Then
                kolVoLuvers += Me.nudY.Value * 100 \ Me.nudLuvDistancia.Value * 100
                strLuvers += ", слева"
            End If

            If Me.chkLuvRight.Checked = True Then
                kolVoLuvers += Me.nudY.Value * 100 \ Me.nudLuvDistancia.Value * 100
                strLuvers += ", справа"
            End If

            costDopOper = Module1.NonQuery1Scalar("SELECT[dbo].[costTechOperCMB] (" & kolVoLuvers & "," & Me.Tag & ",'" & Me.cmbLuvers.Tag & "'," & Me.cmbLuvers.SelectedItem(0) & "," & serviceID & ",1," & Me.nudKolvo.Value & "," & disc & ")")
            prim += ", " + strLuvers
        End If

        If Me.cmbKarman.SelectedIndex = 1 Then 'считаем карман
            Dim kolvoKarman@
            strKarman = "карман"

            If Me.chkKarRight.Checked = True Then
                kolvoKarman = Me.nudY.Value
                strKarman += ", справа"
            End If

            If Me.chkKarUp.Checked = True Then
                kolvoKarman += Me.nudX.Value
                strKarman += ", сверху"
            End If

            If Me.chkKarLeft.Checked = True Then
                kolvoKarman += Me.nudY.Value
                strKarman += ", слева"
            End If

            If Me.chkKarDn.Checked = True Then
                kolvoKarman += Me.nudX.Value
                strKarman += ", снизу"
            End If

            costDopOper += Module1.NonQuery1Scalar("SELECT[dbo].[costTechOperCMB] (" & Replace(kolvoKarman, ",", ".") & "," & Me.Tag & ",'" & Me.cmbKarman.Tag & "'," & Me.cmbKarman.SelectedItem(0) & "," & serviceID & ",1," & Me.nudKolvo.Value & "," & disc & ")")
            prim += ", " + strKarman
        End If

        If Me.cmbKraya.SelectedIndex = 1 Then 'считаем усиление краев
            Dim kolvoKraya@ = 0
            strKraya = "усиление краев"

            If Me.chkKraRight.Checked = True Then
                kolvoKraya = Me.nudY.Value
                strKraya += ", справа"
            End If

            If Me.chkKraUp.Checked = True Then
                kolvoKraya += Me.nudX.Value
                strKraya += ", сверху"
            End If

            If Me.chkKraLeft.Checked = True Then
                kolvoKraya += Me.nudY.Value
                strKraya += ", слева"
            End If

            If Me.chkKraDn.Checked = True Then
                kolvoKraya += Me.nudX.Value
                strKraya += ", снизу"
            End If

            costDopOper += Module1.NonQuery1Scalar("SELECT[dbo].[costTechOperCMB] (" & Replace(kolvoKraya, ",", ".") & "," & Me.Tag & ",'" & Me.cmbKraya.Tag & "'," & Me.cmbKraya.SelectedItem(0) & "," & serviceID & ",1," & Me.nudKolvo.Value & "," & disc & ")")
            prim += ", " + strKraya
        End If

        costProchee = Me.nudShnur.Value * 30
        If Me.nudShnur.Value > 0 Then
            prim += ", шнур"
        End If

        costProchee += Me.nudSkleyka.Value * 30
        If Me.nudSkleyka.Value > 0 Then
            prim += ", склейка"
        End If

        costProchee += Me.nudObrez.Value * 30
        If Me.nudObrez.Value > 0 Then
            prim += ", обрезка"
        End If

        ' Dim k_skidka@ = (100 - Val(Me.tscmbSkidka.Text)) / 100 'скидка

        '  MsgBox((100 - Val(Me.tscmbSkidka.Text)) / 100.ToString)

        itogo = ((matQuantityLF * costMat) * (100 + nacenka) / 100 + Me.nudKolvo.Value * (costProchee + costDopOper + costOper)) * (100 - Val(Me.tscmbSkidka.Text)) / 100

        If itogo < 500 Then itogo = 500

        itogo *= (100 + Me.cmbSrok.SelectedValue) / 100

        Me.tstxtItog.Text = Format(itogo, "C")
        Me.tstxtCostUnit.Text = Format(itogo / Me.nudKolvo.Value, "C")
    End Sub

    Private Sub chkLuvPoKrugu_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chkLuvPoKrugu.CheckedChanged
        Me.chkLuvRight.Checked = sender.checked
        Me.chkLuvUp.Checked = sender.checked
        Me.chkLuvLeft.Checked = sender.checked
        Me.chkLuvDn.Checked = sender.checked
    End Sub

    Private Sub tsbtnExit_Click(sender As System.Object, e As System.EventArgs) Handles tsbtnExit.Click
        Me.Close()
    End Sub

    Private Sub tsbtnOK_Click(sender As System.Object, e As System.EventArgs) Handles tsbtnOK.Click
        SaveCost()

        Me.Close()
    End Sub

    Private Sub SaveCost()
        If costID = Nothing Then
            Exit Sub
        Else
            If MessageBox.Show("Добавить расчет к заказу", appName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                If Not IsNumeric(tstxtItog.Text) Then MsgBox("Не корректное значение стоимости", MsgBoxStyle.Critical, appName) : Exit Sub


                Dim number$ = Module1.NonQuery1Scalar("SELECT coalesce(max(FLOOR(CONVERT(decimal(10,5), number))),0) +1 FROM orders WHERE costID=" & costID & "").ToString
                Dim orderIDforTech% = InsertToOrders(Me.cmbProd.Text, Me.cmbMat.SelectedValue, matQuantityLF, CDec(Me.tstxtItog.Text), Me.cmbModeCost.Text, Me.nudX.Value.ToString & "x" & Me.nudY.Value.ToString + " м", number, CDec(Me.tstxtCostUnit.Text)) 'Пишем спецификацию
                Dim techCost@
                '*********Технологические операции
                techCost = InsertTechOper(CInt(Me.Tag), Me.cmbProd.Tag, Me.cmbProd.SelectedValue, Me.nudKolvo.Value, orderIDforTech)
                ' techCost += InsertTechOper(CInt(Me.Tag), Me.cmbMatColor.Tag, Me.cmbMatColor.SelectedValue, Me.nudKolvo.Value, orderIDforTech)
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
            cmd.Parameters("@prim").Value = prim

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
            cmd.Parameters("@sostav").Value = Me.cmbModeCost.Text  'цветность

            cmd.Parameters.Add(New SqlClient.SqlParameter("@edIzm", SqlDbType.Int))
            cmd.Parameters("@edIzm").Value = Me.cmbPrintFormat.SelectedItem(0)

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

    Private Sub tsbtnAddCost_Click(sender As System.Object, e As System.EventArgs) Handles tsbtnAddCost.Click
        SaveCost()
    End Sub


    Private Sub cmbProd_SelectedValueChanged(sender As Object, e As EventArgs) Handles cmbProd.SelectedValueChanged
        Try
            Dim list2 As String = Module1.NonQuery1ScalarString("SELECT listMatTypeID FROM CalcSettings WHERE serviceID=" & serviceID & " AND nameControl='" & Me.cmbProd.Text & "'")
            Dim odaMatType As New SqlClient.SqlDataAdapter("SELECT ID, Name FROM MatTypes where ID IN (" & list2 & ") order by Name", mcnnInt)
            Dim dtMatType As New DataTable : odaMatType.Fill(dtMatType)

            Me.tmbProd.DataSource = dtMatType 'Связать данные со списком
            Me.tmbProd.DisplayMember = "Name"
            Me.tmbProd.ValueMember = "ID"
        Catch ex As System.Exception
        End Try

        LoadOper()
    End Sub

    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem1.Click
        Module1.ConfigTechOper(cmsConfigTech.SourceControl, CInt(Me.Tag))
    End Sub

    Private Sub chkAdd_CheckedChanged(sender As Object, e As EventArgs) Handles chkAdd.CheckedChanged
        Me.nudObrez.Visible = sender.checked
        Me.nudSkleyka.Visible = sender.checked
        Me.nudShnur.Visible = sender.checked
        Me.Label8.Visible = sender.checked
        Me.Label9.Visible = sender.checked
        Me.Label10.Visible = sender.checked

        If sender.checked = False Then
            Me.nudObrez.Value = 0
            Me.nudSkleyka.Value = 0
            Me.nudShnur.Value = 0
        End If
    End Sub

#Region " Загрузка операций "
    Private Sub LoadOper()
        Try
            Dim odaNacenki As New SqlClient.SqlDataAdapter("SELECT ID, name FROM tech_Operations WHERE ID IN (SELECT techOperID FROM tech_OperControlTag WHERE controlItem0 = " & Me.cmbProd.SelectedItem(0) & " AND controlTag = 'LFProd' AND serviceID = " & serviceID & ") order by name ", mcnnInt)
            Dim dtNacenki As New DataTable : odaNacenki.Fill(dtNacenki)

            Me.clbOper.DataSource = dtNacenki
            Me.clbOper.DisplayMember = "name"
            Me.clbOper.ValueMember = "ID"
        Catch ex As System.Exception
        End Try
    End Sub
#End Region

    Private Sub ЗадатьТехнологическуюОперациюToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ЗадатьТехнологическуюОперациюToolStripMenuItem.Click
        Module1.ConfigTechOper(Me.cmbProd, CInt(Me.Tag))

        LoadOper()
    End Sub

    Private Sub ДобавитьПродуктToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ДобавитьПродуктToolStripMenuItem1.Click
        formTagNewProd = Me.Tag

        ModCallForm.CallForm("Продукт", 42, 3)
    End Sub

    Private Sub УдалитьПродуктToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles УдалитьПродуктToolStripMenuItem.Click
        Select Case MsgBox(Prompt:="Удалить  " & Trim(Me.cmbProd.SelectedItem(1)) & "?", Buttons:=vbYesNo, Title:=appName)
            Case Is = vbYes
                Module1.NonQuery1("DELETE FROM awc_Polygraph WHERE ID=" & Me.cmbProd.SelectedItem(0) & "")
            Case Is = vbNo
                Exit Sub
        End Select
    End Sub

    Dim dtMatFormats As DataTable

    Private Sub cmbMat_SelectedValueChanged(sender As Object, e As EventArgs) Handles cmbMat.SelectedValueChanged
        Dim cmd As New SqlClient.SqlCommand

        cmd.Connection = mcnnInt
        cmd.CommandText = "[sp_MatPrintFormat]"
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.Add(New SqlClient.SqlParameter("@matID", SqlDbType.Int))
        cmd.Parameters("@matID").Value = Me.cmbMat.SelectedItem(0)

        Dim odaMan As New SqlClient.SqlDataAdapter(cmd)

        dtMatFormats = New DataTable
        odaMan.Fill(dtMatFormats)

        Me.cmbPrintFormat.DataSource = dtMatFormats 'Связать данные со списком
        Me.cmbPrintFormat.DisplayMember = "formatName"
        Me.cmbPrintFormat.ValueMember = "unitID"
    End Sub

    Private Sub nudKolvo_MouseClick(sender As Object, e As MouseEventArgs) Handles nudKolvo.MouseClick
        sender.Select(0, (Len(sender.Value.ToString)))
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
            '   MsgBox("Универсальный прайс, загрузка." & ex.Message, MsgBoxStyle.Critical, appName)
        End Try
    End Sub

    Private Sub tscmbSkidka_Click(sender As Object, e As EventArgs) Handles tscmbSkidka.Click

    End Sub

    Private Sub tstxtItog_Click(sender As Object, e As EventArgs) Handles tstxtItog.Click

    End Sub

    Private Sub nudX_MouseClick(sender As Object, e As MouseEventArgs) Handles nudX.MouseClick
        sender.Select(0, (Len(sender.Value.ToString)))
    End Sub

    Private Sub nudX_ValueChanged(sender As Object, e As EventArgs) Handles nudX.ValueChanged

    End Sub

    Private Sub nudY_MouseClick(sender As Object, e As MouseEventArgs) Handles nudY.MouseClick
        sender.Select(0, (Len(sender.Value.ToString)))
    End Sub

    Private Sub nudY_ValueChanged(sender As Object, e As EventArgs) Handles nudY.ValueChanged

    End Sub
End Class