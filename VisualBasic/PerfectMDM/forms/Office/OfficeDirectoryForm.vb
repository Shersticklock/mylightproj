Imports System.Data.SqlClient

Public Class OfficeDirectoryForm
    Private Sub OfficeDirectoryForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadOffices()
    End Sub

    Private Sub LoadOffices()
        Dim cmd As New SqlCommand
        cmd.Connection = mcnnInt
        cmd.CommandText = "sp_GetOffices"
        cmd.CommandType = CommandType.StoredProcedure
        Dim sqlDataAdapter As New SqlDataAdapter(cmd)
        Dim dataTable As New DataTable()
        sqlDataAdapter.Fill(dataTable)
        OfficeDataGridView.DataSource = dataTable

        For Each dataColumn As DataGridViewColumn In OfficeDataGridView.Columns
            If (dataColumn.Name = "ID") Then
                dataColumn.Visible = False
            End If
        Next
    End Sub

    Private Sub AddOfficeButton_Click(sender As Object, e As EventArgs) Handles AddOfficeButton.Click
        Dim addOfficeForm As AddOfficeForm = New AddOfficeForm()
        addOfficeForm.NoteID = 0
        addOfficeForm.ShowDialog(Me)
        LoadOffices()
    End Sub

    Private Sub EditOfficeButton_Click(sender As Object, e As EventArgs) Handles EditOfficeButton.Click
        If (OfficeDataGridView.SelectedRows.Count <= 0) Then
            MessageBox.Show("Не выбрана запись для изменения!", "Ошибка")
            Exit Sub
        End If

        Dim addOfficeForm As AddOfficeForm = New AddOfficeForm()
        Dim id As Integer = OfficeDataGridView.SelectedRows(0).Cells("ID").Value
        addOfficeForm.NoteId = id
        addOfficeForm.ShowDialog(Me)
        LoadOffices()
    End Sub

    Private Sub DeleteOfficeButton_Click(sender As Object, e As EventArgs) Handles DeleteOfficeButton.Click

        If (OfficeDataGridView.SelectedRows.Count <= 0) Then
            MessageBox.Show(Me, "Не выбрана запись для удаления!", "Ошибка")
            Exit Sub
        End If

        Dim result As Integer = MessageBox.Show("Удалить выбранную позицию?", "Удаление позиции",
                                                MessageBoxButtons.YesNo)
        If result = DialogResult.Yes Then
            Dim selectedRow As DataGridViewRow
            selectedRow = OfficeDataGridView.SelectedRows(0)
            Dim selectedId = selectedRow.Cells("ID").Value
            Dim sql As String = "DELETE FROM Offices WHERE ID = " & selectedId

            Try
                Dim ocmd As New SqlCommand
                ocmd.CommandText = sql
                ocmd.Connection = mcnnInt
                mcnnInt.Open()
                ocmd.ExecuteNonQuery()
            Catch excp As Exception
                MessageBox.Show(Me, "Невозможно удалить офис!", "Ошибка")
            Finally
                mcnnInt.Close()
            End Try

            LoadOffices()
        End If
    End Sub
End Class