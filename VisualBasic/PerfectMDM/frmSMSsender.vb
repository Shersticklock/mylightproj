Public Class frmSMSsender

    Private Sub ToolStripButton1_Click(sender As System.Object, e As System.EventArgs) Handles tsbtnSend.Click
        If Me.mtxtMobTel.Text = Nothing Then
            MsgBox("Нет телефона - представителя заказчика.", MsgBoxStyle.Critical, appName)
            Exit Sub
        Else
            SMSsend(Me.mtxtMobTel.Text, Me.txtMessage.Text)
        End If
    End Sub

    Private Sub SMSsend(phone As String, body As String)
        Dim cmd As New SqlClient.SqlCommand

        Try
            cmd.Connection = mcnnInt
            cmd.CommandText = "sp_SMSsender"
            cmd.CommandType = CommandType.StoredProcedure

            cmd.Parameters.Add(New SqlClient.SqlParameter("@phone", SqlDbType.NChar))
            cmd.Parameters("@phone").Value = phone

            cmd.Parameters.Add(New SqlClient.SqlParameter("@message", SqlDbType.NVarChar))
            cmd.Parameters("@message").Value = body

            mcnnInt.Open()
            cmd.ExecuteNonQuery()
            ' Me.tsbtnSend.Enabled = False
        Catch excp As System.Exception
            MessageBox.Show(excp.Message, appName)
            Exit Sub
        Finally
            mcnnInt.Close()
        End Try
    End Sub


    Private Sub frmSMSsender_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Me.mtxtMobTel.Text = Module1.NonQuery1ScalarString("SELECT '8'+replace(replace(replace(replace(telMob, ' ',''), '(',''), ')',''),'-','')  FROM EmplCust WHERE emplCustID = (SELECT emplCust FROM Costs WHERE costID = " & costID & ")")

        Dim odaMarket1 As New SqlClient.SqlDataAdapter("SELECT ID, name FROM SMS_Template", mcnnInt)
        Dim dtMarket1 As New DataTable : odaMarket1.Fill(dtMarket1)

        Me.cmbTemplateSMS.DataSource = dtMarket1
        Me.cmbTemplateSMS.DisplayMember = "Name"
        Me.cmbTemplateSMS.ValueMember = "ID"
    End Sub

    Private Sub cmbTemplateSMS_SelectedValueChanged(sender As Object, e As System.EventArgs) Handles cmbTemplateSMS.SelectedValueChanged
        Me.txtMessage.Text = Module1.NonQuery1ScalarString("SELECT description FROM SMS_Template WHERE ID =  " & Me.cmbTemplateSMS.SelectedItem(0) & "")
    End Sub

    Private Sub tsbtnSaveTemplate_Click(sender As System.Object, e As System.EventArgs) Handles tsbtnSaveTemplate.Click
        Module1.NonQuery1("INSERT INTO SMS_Template (name, description) VALUES ('" & Me.txtNewTemplareSMS.Text & "', '" & Replace(Me.txtMessage.Text, "'", " ` ") & "')")

        MsgBox("Шаблон сохранил.", MsgBoxStyle.Information, appName)
        Me.tsbtnSaveTemplate.Enabled = False
    End Sub

    Private Sub txtNewTemplareSMS_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtNewTemplareSMS.TextChanged
        Me.tsbtnSaveTemplate.Enabled = True
    End Sub

    Private Sub txtMessage_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtMessage.TextChanged
        Me.tsbtnSend.Enabled = True
    End Sub

    Private Sub mtxtMobTel_MaskInputRejected(sender As System.Object, e As System.Windows.Forms.MaskInputRejectedEventArgs) Handles mtxtMobTel.MaskInputRejected
        Me.tsbtnSend.Enabled = True
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Dim cmd As New SqlClient.SqlCommand

        cmd.Connection = mcnnInt
        cmd.CommandText = "[sp_SMS_NeZabrNeOpl]"
        cmd.CommandType = CommandType.StoredProcedure

        'cmd.Parameters.Add(New SqlClient.SqlParameter("@depID", SqlDbType.Int))
        'cmd.Parameters("@depID").Value = depID

        mcnnInt.Open()

        Dim objDA As New SqlClient.SqlDataAdapter(cmd)
        Dim dtMatList As New DataTable : objDA.Fill(dtMatList)
        Me.dgDataTable.DataSource = dtMatList  'Связать данные со списком
        mcnnInt.Close()
    End Sub

    Private Sub tsbtnSendAll_Click(sender As Object, e As EventArgs) Handles tsbtnSendAll.Click
        '  Dim num As String

        For Each dr As DataGridViewRow In Me.dgDataTable.Rows
            '    num = "8" + Replace(Replace(Replace(Replace(dr.Cells("Телефон").Value, " ", ""), "(", ""), ")", ""), "-", "")

            'MsgBox(num)

            SMSsend(("8" + Replace(Replace(Replace(Replace(dr.Cells("Телефон").Value, " ", ""), "(", ""), ")", ""), "-", "")), (Me.txtMessage.Text + "-" + dr.Cells("Номер").Value))

        Next
    End Sub

    Private Sub cmbTemplateSMS_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbTemplateSMS.SelectedIndexChanged

    End Sub
End Class