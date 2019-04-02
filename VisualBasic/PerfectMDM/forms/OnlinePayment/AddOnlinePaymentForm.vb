Public Class AddOnlinePaymentForm
    Public Dim NoteId As Integer

    Private Sub AddOnlinePaymentForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadOrganizations()

        If (NoteId > 0) Then
            RestoreDataFromDbById(NoteId)
        End If
    End Sub

    Friend Sub RestoreDataFromDbById(id As Integer)
        Try
            Dim sql As String
            sql = "SELECT name, orgID, isActive FROM OnlinePaymentsType WHERE ID = " & NoteId & ""
            
            Dim sqlDataAdapter As SqlClient.SqlDataAdapter = New SqlClient.SqlDataAdapter(sql, mcnnInt)
            Dim dataTable As DataTable = New DataTable()
            sqlDataAdapter.Fill(dataTable)

            Dim dataRow As DataRow = dataTable.Rows(0)
            NameTextBox.Text = dataRow.Item("name")
            If (Not IsDBNull(dataRow.Item("orgID"))) Then
                PersonComboBox.SelectedValue = dataRow.Item("orgID")
            End If
            ActiveCheckBox.Checked = dataRow.Item("isActive")
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

    Private Sub SaveButton_Click(sender As Object, e As EventArgs) Handles SaveButton.Click
        If (NoteId > 0) Then
            UpdateOnlinePaymentType()
        Else
            InsertOnlinePaymentType()
        End If
        Me.Close()
    End Sub

    Private Sub UpdateOnlinePaymentType()
        Dim sql As String
        sql = "UPDATE OnlinePaymentsType SET " &
              "name = '" & NameTextBox.Text & "', " &
              "orgID = '" & PersonComboBox.SelectedValue & "', " &
              "isActive = " & IsChecked(ActiveCheckBox) & " " &
              "WHERE ID = " & NoteId
        Module1.NonQuery1(sql)
    End Sub

    Private Sub InsertOnlinePaymentType()
        Dim sql As String
        sql = "INSERT INTO OnlinePaymentsType " &
              "(name, orgID, isActive) " &
              "VALUES ('" & NameTextBox.Text & "', " &
              PersonComboBox.SelectedValue & ", " &
              IsChecked(ActiveCheckBox) & ")"
        Module1.NonQuery1(sql)
    End Sub

    Private Function IsChecked(checkBox As CheckBox) As Integer
        If checkBox.Checked Then
            Return 1
        Else
            Return 0
        End If
    End Function
End Class