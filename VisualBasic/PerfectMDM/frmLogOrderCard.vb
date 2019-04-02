Imports VeerouteClient

Public Class frmLogOrderCard
    Dim oplata As String = Nothing
    Dim errVeerout As Boolean

    Private Sub frmOrderLogCard_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            If costID <> Nothing Then
                Dim odaPartList As New SqlClient.SqlDataAdapter("SELECT ID, Name FROM KAgents order by Name", mcnnInt)
                Dim dtPartList As New DataTable : odaPartList.Fill(dtPartList)

                Me.cmbCustomer.DataSource = dtPartList
                Me.cmbCustomer.DisplayMember = "Name"
                Me.cmbCustomer.ValueMember = "ID"
                Me.cmbCustomer.SelectedValue = custID
            End If
        Catch ex As System.Exception
            MessageBox.Show(ex.Message)
        End Try

        Me.txtFindKA.Visible = True
        Me.cmbCustomer.Visible = True
        Me.dtpDateG.Value = Now().Date 'AddDays(1)
    End Sub

    Private Sub cmbCustomer_SelectedValueChanged(sender As Object, e As System.EventArgs) Handles cmbCustomer.SelectedValueChanged
        LoadPointAndPersons(Me.cmbCustomer.SelectedItem(0))
    End Sub

    Private Sub LoadPointAndPersons(custID As Integer)
        If Me.cmbCustomer.SelectedIndex <> -1 Then
            Try
                Dim odaOper As New SqlClient.SqlDataAdapter("SELECT emplCustID, lastName FROM EmplCust WHERE custID=" & custID & " order by lastName", mcnnInt)
                Dim dtOper As New DataTable : odaOper.Fill(dtOper)

                Me.cmbPersona.DataSource = dtOper 'Связать данные со списком
                Me.cmbPersona.DisplayMember = "lastName"
                Me.cmbPersona.ValueMember = "emplCustID"

                Dim odaPoint As New SqlClient.SqlDataAdapter("SELECT ID, (name + ',' + adres) as Name FROM KA_GeoPoints WHERE KA_ID=" & custID & " order by Name", mcnnInt)
                Dim dtPoint As New DataTable : odaPoint.Fill(dtPoint)

                Me.cmbGeoPointName.DataSource = dtPoint 'Связать данные со списком
                Me.cmbGeoPointName.DisplayMember = "Name"
                Me.cmbGeoPointName.ValueMember = "ID"
            Catch ex As System.Exception
                MsgBox("error-выбор контрагента" & ex.Message, appName)
            End Try
        End If
    End Sub

    Private Sub txtFindKA_KeyDown(sender As Object, e As KeyEventArgs) Handles txtFindKA.KeyDown
        If e.KeyCode = Keys.Enter Then
            Try
                LoadCustomers(Me.txtFindKA.Text)
            Catch oexpData As System.Exception
                MsgBox(oexpData.Message, MsgBoxStyle.Critical, appName)
            End Try
        End If

        e.Handled = True
    End Sub

#Region " Загружаем заказчиков "
    Private Sub LoadCustomers(ByVal strFind As String)
        Try
            Dim odaPartList As New SqlClient.SqlDataAdapter("SELECT ID, Name FROM KAgents WHERE Name LIKE '%" & strFind & "%' order by Name", mcnnInt)
            Dim dtPartList As New DataTable : odaPartList.Fill(dtPartList)

            Me.cmbCustomer.DataSource = dtPartList
            Me.cmbCustomer.DisplayMember = "Name"
            Me.cmbCustomer.ValueMember = "ID"

        Catch oexpData As System.Exception
            MsgBox(oexpData.Message, MsgBoxStyle.Critical, appName)
        End Try
    End Sub
#End Region

    Private Sub tsbtnOK_Click(sender As Object, e As EventArgs) Handles tsbtnOK.Click
        Dim nomerDost$
        Dim lng@, lat@
        Dim manager$
        Dim adresDost As String
        Dim geopoint As String = Module1.NonQuery1ScalarString("SELECT geopoint FROM KA_GeoPoints WHERE ID = " & Me.cmbGeoPointName.SelectedItem(0) & "")

        Try
            If Me.cmbCustomer.SelectedIndex = -1 Then
                MsgBox("Не выбран контрагент", MsgBoxStyle.Critical, appName) : Me.cmbCustomer.Focus() : Exit Sub
            End If

            If Me.cmbGeoPointName.SelectedIndex = -1 Then
                MsgBox("Не указана точка доставки", MsgBoxStyle.Critical, appName) : Me.cmbGeoPointName.Focus() : Exit Sub
            End If

            If Me.cmbPersona.Text = Nothing Then
                MsgBox("Не выбрана персона-получатель", MsgBoxStyle.Critical, appName) : Me.cmbPersona.Focus() : Exit Sub
            End If

            If Me.dtpDateG.Value.Date < Now().Date Then
                MsgBox("Дата не может быть меньше текущей", MsgBoxStyle.Critical, appName) : Me.dtpDateG.Focus() : Exit Sub
            End If

            adresDost = Module1.NonQuery1ScalarString("SELECT adres FROM KA_GeoPoints WHERE ID=" & Me.cmbGeoPointName.SelectedItem(0) & "")
            lng = Module1.NonQuery1Scalar("SELECT REPLACE(SUBSTRING(geopoint,1,(CHARINDEX(',', geopoint)-1) ),'.',',') FROM KA_GeoPoints WHERE ID=" & Me.cmbGeoPointName.SelectedItem(0) & "")
            lat = Module1.NonQuery1Scalar("SELECT REPLACE(SUBSTRING(geopoint,(CHARINDEX(',', geopoint)+1), LEN(geopoint) ),'.',',') FROM KA_GeoPoints WHERE ID=" & Me.cmbGeoPointName.SelectedItem(0) & "")

            If costID = Nothing Then
                nomerDost = "БЗ-" + CStr(Now())
                manager = Module1.NonQuery1ScalarString("SELECT emplLastName FROM Employees WHERE emplID=" & emplID & "") 'куратор
                oplata = ""
            Else
                nomerDost = Module1.NonQuery1ScalarString("SELECT [dbo].[logOrderNum] (" & costID & ")")
                manager = Module1.NonQuery1ScalarString("SELECT emplLastName FROM Employees WHERE emplID=(SELECT emplID FROM Costs WHERE costID=" & costID & ")") 'куратор
                oplata = Module1.NonQuery1ScalarString("SELECT nomVN2 FROM Costs WHERE costID=" & costID & "")
            End If

            Select Case MsgBox(Prompt:="Сохранить заявку на доставку?", Buttons:=vbYesNo, Title:=appName)
                Case Is = vbYes
                    Try
                        ToVeeRout(nomerDost, adresDost, lng, lat, Me.cmbCustomer.Text, Me.cmbPersona.Text, "", manager)

                    Catch ex As System.Exception
                        MessageBox.Show("Ошибка процедуры сохранения заявки на доставку: " & ex.Message, appName)
                    End Try

                    If errVeerout = True Then
                        Exit Sub
                    End If

                    Dim cmd As New SqlClient.SqlCommand

                    Try
                        cmd.Connection = mcnnInt
                        cmd.CommandText = "sp_LogOrder_Create"
                        cmd.CommandType = CommandType.StoredProcedure

                        cmd.Parameters.Add(New SqlClient.SqlParameter("@costID", SqlDbType.Int))
                        cmd.Parameters("@costID").Value = costID

                        cmd.Parameters.Add(New SqlClient.SqlParameter("@geoPointID", SqlDbType.Int))
                        cmd.Parameters("@geoPointID").Value = Me.cmbGeoPointName.SelectedItem(0) '

                        cmd.Parameters.Add(New SqlClient.SqlParameter("@dateDelivery", SqlDbType.Date))
                        cmd.Parameters("@dateDelivery").Value = Me.dtpDateG.Value.Date

                        cmd.Parameters.Add(New SqlClient.SqlParameter("@KA_ID", SqlDbType.Int))
                        cmd.Parameters("@KA_ID").Value = Me.cmbCustomer.SelectedItem(0)

                        cmd.Parameters.Add(New SqlClient.SqlParameter("@person", SqlDbType.NVarChar))
                        cmd.Parameters("@person").Value = Me.cmbPersona.Text  '

                        cmd.Parameters.Add(New SqlClient.SqlParameter("@emplID", SqlDbType.Int))
                        cmd.Parameters("@emplID").Value = emplID

                        cmd.Parameters.Add(New SqlClient.SqlParameter("@prim", SqlDbType.NVarChar))
                        cmd.Parameters("@prim").Value = Me.cmbNazn.Text + ", " + Me.txtPrim.Text  '

                        cmd.Parameters.Add(New SqlClient.SqlParameter("@adresDost", SqlDbType.NVarChar))
                        cmd.Parameters("@adresDost").Value = adresDost

                        cmd.Parameters.Add(New SqlClient.SqlParameter("@tel", SqlDbType.NVarChar))
                        cmd.Parameters("@tel").Value = Me.txtTel.Text

                        cmd.Parameters.Add(New SqlClient.SqlParameter("@nomerDost", SqlDbType.NVarChar))
                        cmd.Parameters("@nomerDost").Value = nomerDost

                        cmd.Parameters.Add(New SqlClient.SqlParameter("@datePlan", SqlDbType.Date))
                        cmd.Parameters("@datePlan").Value = Me.dtpDateG.Value.Date

                        cmd.Parameters.Add(New SqlClient.SqlParameter("@performing_emplID", SqlDbType.Int))
                        cmd.Parameters("@performing_emplID").Value = Module1.NonQueryScalarInt("SELECT dirDepEmplID FROM Departments WHERE ID=11")

                        cmd.Parameters.Add(New SqlClient.SqlParameter("@LNG", SqlDbType.Decimal))
                        cmd.Parameters("@LNG").Value = lng

                        cmd.Parameters.Add(New SqlClient.SqlParameter("@LAT", SqlDbType.Decimal))
                        cmd.Parameters("@LAT").Value = lat

                        mcnnInt.Open()
                        cmd.ExecuteNonQuery()
                    Catch excp As System.Exception
                        MessageBox.Show("Ошибка процедуры сохранения заявки на доставку: " & excp.Message, appName)
                        Exit Sub
                    Finally
                        mcnnInt.Close()
                        Me.Close()
                    End Try

                Case Is = vbNo : Exit Sub
            End Select
        Catch ex As System.Exception
            MessageBox.Show("Ошибка процедуры сохранения заказа: " & ex.Message, appName)
        End Try
    End Sub

    Private Sub ToVeeRout(nomerDost As String, adres As String, LNG As Decimal, LAT As Decimal, KA As String, person As String, googlmail As String, manager As String)
        Dim client = New VeerouteClient.Client

        client.CreateSession("mdmprint", "api", "Api1234")

        Dim order As apiRequestOrdersOrder

        order = New apiRequestOrdersOrder()
        order.location = New apiRequestOrdersOrderLocation
        order.priority = 1
        order.orderReference = nomerDost
        order.location.name = adres
        order.location.address = adres
        order.location.latitude = LNG
        order.location.longitude = LAT
        order.date = Me.dtpDateG.Value.Date
        order.client = New apiRequestOrdersOrderClient()
        order.client.contactNumber = "8" + Me.txtTel.Text
        order.client.name = KA
        order.areaOfControl = "Производство" 'это распред центр производство
        order.client.contactPerson = person
        order.additionalInstructions = nomerDost + ", " + manager + ", " + adres + ", " + Me.cmbNazn.Text + ", " + Me.cmbIntDost.Text + ", сумма заказа-" + CStr(cost) + ", " + oplata + ", долг-" + CStr(dolgi) + ", " + Me.txtPrim.Text

        Dim window As New apiRequestOrdersOrderDropWindow

        window.start = Me.dtpDateG.Value.Date.AddHours(11).ToString("dd.MM.yyyy HH:mm")
        window.end = Me.dtpDateG.Value.Date.AddHours(19).ToString("dd.MM.yyyy HH:mm")

        order.dropWindows = {window}

        Try
            client.SaveOrder(order)
            errVeerout = False
        Catch ex As System.Exception
            MessageBox.Show("Добавьте поездку через минуту. " & ex.Message, appName)
            errVeerout = True
        End Try
    End Sub

    Private Sub ToolStripButton2_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripButton2.Click
        Me.Close()
    End Sub

    Private Sub nudTimeG1_ValueChanged(sender As System.Object, e As System.EventArgs) Handles nudTimeG1.ValueChanged
        Me.nudTimeG2.Minimum = sender.value + 1
    End Sub

    Private Sub cmbPersona_SelectedValueChanged(sender As Object, e As System.EventArgs) Handles cmbPersona.SelectedValueChanged
        If Me.cmbPersona.SelectedIndex <> -1 Then
            Me.txtTel.Text = Module1.NonQuery1ScalarString("SELECT coalesce(telMob, '') FROM EmplCust WHERE emplCustID=" & Me.cmbPersona.SelectedItem(0) & "")
        End If
    End Sub

    Private Sub ДобавитьТочкуДоставкиToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ДобавитьТочкуДоставкиToolStripMenuItem.Click
        Dim frmSelect As New frmKAgents

        frmSelect.ShowDialog()
        frmSelect.DesCust.SelectedTab = frmSelect.DesCust.TabPages.Item("points")
    End Sub
End Class