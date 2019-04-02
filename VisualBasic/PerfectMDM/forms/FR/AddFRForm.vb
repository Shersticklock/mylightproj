Public Class AddFRForm
    Friend Dim NoteId As Integer

    Private Sub AddFRForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadOffices()
        LoadOrganizations()

        If (NoteId > 0) Then
            RestoreDataFromDbById(NoteId)
        End If
    End Sub

    Friend Sub RestoreDataFromDbById(id As Integer)
        Try
            Dim cmd As New SqlClient.SqlCommand
            cmd.Connection = mcnnInt
            cmd.CommandText = "sp_GetFiscalRegistrarById"
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.Add(New SqlClient.SqlParameter("@id", SqlDbType.Int))
            cmd.Parameters("@id").Value = id
            Dim frSqlDataAdapter As SqlClient.SqlDataAdapter = New SqlClient.SqlDataAdapter(cmd)
            Dim frDataTable As DataTable = New DataTable()
            frSqlDataAdapter.Fill(frDataTable)

            Dim dataRow As DataRow = frDataTable.Rows(0)
            NameTextBox.Text = dataRow.Item("Название")
            ShortNameTextBox.Text = dataRow.Item("Сокр. Название")
            If (Not IsDBNull(dataRow.Item("РН ККТ"))) Then
                RnKktTextBox.Text = dataRow.Item("РН ККТ")
            End If
            If (Not IsDBNull(dataRow.Item("ID юр. Лица"))) Then
                PersonComboBox.SelectedValue = dataRow.Item("ID юр. Лица")
            End If
            IpAddressTextBox.Text = dataRow.Item("IP")
            ComPortTextBox.Text = dataRow.Item("COM")
            PasswordTextBox.Text = dataRow.Item("Пароль")
            OfficeComboBox.SelectedValue = dataRow.Item("ID Офиса")
            VirtualCheckBox.Checked = dataRow.Item("Виртуальная касса")
            ActiveCheckBox.Checked = dataRow.Item("Активность")
        Catch excData As Exception
            MessageBox.Show(excData.Message, appName)
        End Try
    End Sub

    Private Sub LoadOrganizations()
        PersonComboBox.ValueMember = "custID"
        PersonComboBox.DisplayMember = "Name"

        Try
            Dim sqlDataAdapter As New SqlClient.SqlDataAdapter("SELECT custID, Name FROM Organizations where KAgent_ID=(SELECT ID FROM KAgents WHERE type_ID = 1) AND closed <> 1", mcnnInt)
            Dim dataTable As New DataTable()
            sqlDataAdapter.Fill(dataTable)
            PersonComboBox.DataSource = dataTable
        Catch ex As Exception
            MessageBox.Show("Ошибка при загрузке списка юридических лиц: " & ex.Message, appName)
        End Try
    End Sub

    Private Sub LoadOffices()
        OfficeComboBox.ValueMember = "ID"
        OfficeComboBox.DisplayMember = "name"

        Try
            Dim sqlDataAdapter As New SqlClient.SqlDataAdapter("SELECT ID, name FROM Offices", mcnnInt)
            Dim dataTable As New DataTable()
            sqlDataAdapter.Fill(dataTable)
            OfficeComboBox.DataSource = dataTable
        Catch oexpData As Exception
            MessageBox.Show("Ошибка при загрузке списка офисов: " & oexpData.Message, appName)
        End Try
    End Sub

    Private Sub SaveButton_Click(sender As Object, e As EventArgs) Handles SaveButton.Click
        If (PersonComboBox.SelectedValue Is Nothing) Then
            MessageBox.Show(Me, "Необходимо указать юридическое лицо!", appName)
            Exit Sub
        End If

        If NoteId > 0 Then
            UpdateFr()
        Else
            SaveFr()
        End If
        Me.Close()
    End Sub

    Private Sub UpdateFr()
        Dim sql As String
        sql = "UPDATE FiscalRegistrar SET " &
              "name = '" & NameTextBox.Text & "', " &
              "shortName = '" & ShortNameTextBox.Text & "', " &
              "rn_kkt = '" & RnKktTextBox.Text & "', " &
              "organizationID = '" & PersonComboBox.SelectedValue & "', " &
              "computerIP = '" & IpAddressTextBox.Text & "', " &
              "comPort = " & ComPortTextBox.Text & ", " &
              "password = '" & PasswordTextBox.Text & "', " &
              "officeID = " & OfficeComboBox.SelectedValue & ", " &
              "isVirtual = " & IsChecked(VirtualCheckBox) & ", " &
              "isActive = " & IsChecked(ActiveCheckBox) & " " &
              "WHERE id = " & NoteId
        Module1.NonQuery1(sql)
    End Sub

    Private Function IsChecked(checkBox As CheckBox) As Integer
        If checkBox.Checked Then
            Return 1
        Else
            Return 0
        End If
    End Function

    Private Sub SaveFr()
        Dim sql As String
        sql = "INSERT INTO FiscalRegistrar " &
              "(name, shortName, rn_kkt, organizationID, computerIP, comPort, password, officeID, isVirtual, isActive) " &
              "VALUES ('" & NameTextBox.Text & "', " &
              "'" & ShortNameTextBox.Text & "', " &
              "'" & RnKktTextBox.Text & "', " &
              PersonComboBox.SelectedValue & ", " &
              "'" & IpAddressTextBox.Text & "', " &
              ComPortTextBox.Text & ", " &
              "'" & PasswordTextBox.Text & "', " &
              OfficeComboBox.SelectedValue & ", " &
              IsChecked(VirtualCheckBox) & ", " &
              IsChecked(ActiveCheckBox) & ")"
        Module1.NonQuery1(sql)
    End Sub
End Class