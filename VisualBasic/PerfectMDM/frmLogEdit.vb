Imports System.Data.SqlClient

Public Class frmLogEdit

    Dim modaLookupData As SqlClient.SqlDataAdapter
    ' Public frmEdit_strSQL As String
    Public logID As Integer

    Dim valStart As Integer
    Dim dtData As New DataTable

    '*****************http://vb.net-informations.com/datagridview/vb.net_datagridview_database.htm
    Dim sCommand As SqlCommand
    Dim sAdapter As SqlDataAdapter
    Dim sBuilder As SqlCommandBuilder
    Dim sDs As DataSet
    Dim sTable As DataTable

    Private Sub frmLogEdit_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Me.Text = Me.Text + "- " + Module1.NonQuery1ScalarString("SELECT numberLog FROM Logistics WHERE ID = " & logID & "")

        Dim strSQL$ = "SELECT * FROM Logistics WHERE ID = " & logID & " "

        Try
            modaLookupData = New SqlClient.SqlDataAdapter(strSQL, mcnnInt)
            modaLookupData.Fill(dtData)

            Me.dgTableData.DataSource = dtData
            Me.dgTableData.Columns("ID").Visible = False
            ' Me.dgTableData.EditMode = DataGridViewEditMode.EditOnEnter
        Catch excData As System.Exception
            MessageBox.Show(excData.Message)
        End Try
    End Sub

    Private Sub tsbtnSave_Click(sender As System.Object, e As System.EventArgs) Handles tsbtnSave.Click

        Dim strSQL$

        For n As Integer = 0 To Me.dgTableData.RowCount - 1
            If Me.dgTableData(5, n).Value > Me.dgTableData(6, n).Value Then
                MsgBox("Время начала интервала доставки больше времени окончания интервала.") : Exit Sub
            End If
            If Me.dgTableData(6, n).Value > 20 Or Me.dgTableData(6, n).Value < 7 Or Me.dgTableData(5, n).Value > 20 Or Me.dgTableData(5, n).Value < 7 Then
                MsgBox("Время начала или окончания интервала доставки не корректно.") : Exit Sub
            End If
            strSQL = "UPDATE Logistics SET emplCust= '" & Me.dgTableData("Получатель", n).Value & "', adressLog = '" & Me.dgTableData("Адрес", n).Value & "', "
            strSQL &= "tel= '" & Me.dgTableData("Телефон", n).Value & "', dateG = '" & Me.dgTableData("Дата", n).Value & "', timeG1 = '" & Me.dgTableData("Время с", n).Value & "', "
            strSQL &= "  timeG2 = '" & Me.dgTableData("Время до", n).Value & "', prim = '" & Me.dgTableData("Примечания", n).Value & "' WHERE ID = " & Me.dgTableData("ID", n).Value & " "
            '        MsgBox(strSQL)
            Module1.NonQuery1(strSQL)
            Me.tsbtnSave.Enabled = False
        Next
    End Sub

    Private Sub ToolStripButton1_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripButton1.Click
        Me.Close()
    End Sub

    Private Sub dgTableData_CellBeginEdit(sender As Object, e As System.Windows.Forms.DataGridViewCellCancelEventArgs) Handles dgTableData.CellBeginEdit
        Me.tsbtnSave.Enabled = False
    End Sub

    Private Sub dgTableData_CellEndEdit(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgTableData.CellEndEdit
        Me.tsbtnSave.Enabled = True
    End Sub
End Class