Imports System.Data.SqlClient

Public Class AddOfficeForm

    Friend Dim NoteId As Integer
    
    Private Sub AddOfficeForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If (NoteId > 0 ) Then
            RestoreDataFromDbById(NoteId)
        End If
    End Sub

    Private Sub RestoreDataFromDbById(noteId As Integer)
        Try
            Dim sql As String = "SELECT ID, name FROM Offices WHERE ID=" & noteId & ""
            Dim sqlDataAdapter As New SqlDataAdapter(sql, mcnnInt)
            Dim dataTable As New DataTable()
            sqlDataAdapter.Fill(dataTable)
            
            Dim dataRow As DataRow = dataTable.Rows(0)
            NameTextBox.Text = dataRow.Item("name")
        Catch excData As Exception
            MessageBox.Show(excData.Message, appName)
        End Try
    End Sub

    Private Sub SaveButton_Click(sender As Object, e As EventArgs) Handles SaveButton.Click
        If NoteId > 0 Then
            UpdateFr()
        Else
            SaveFr()
        End If
        Me.Close()
    End Sub

    Private Sub UpdateFr()
        Dim sql As String
        sql = "UPDATE Offices SET " &
              "name = '" & NameTextBox.Text & "' " &
              "WHERE id = " & NoteId
        Module1.NonQuery1(sql)
    End Sub
    
    Private Sub SaveFr()
        Dim sql As String
        sql = "INSERT INTO Offices " &
              "(name, description) " &
              "VALUES ('" & NameTextBox.Text & "', ' ')"
        Module1.NonQuery1(sql)
    End Sub

End Class