Public Class frmDocEdit
    Dim modaLookupData As SqlClient.SqlDataAdapter
    Public invoiceID As Integer
    Public IsSaved As Boolean = False
    Dim dtData As New DataTable
    Dim valStartKolvo As Decimal
    Dim valStartCost As Decimal

    Private Sub frmDocEdit_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        LoadData()
    End Sub

    Private Sub LoadData()
        Dim strSQL$ = "SELECT offeringID, prodName AS Наименование, kolvo AS Количество, summa AS Цена, total AS Всего, nds FROM Offering WHERE invoiceID=" & invoiceID & ""

        Try
            modaLookupData = New SqlClient.SqlDataAdapter(strSQL, mcnnInt)
            modaLookupData.Fill(dtData)

            Me.dgDocEdit.DataSource = dtData
            Me.dgDocEdit.Columns("offeringID").Visible = False
            Me.dgDocEdit.Columns("nds").Visible = False
            ' Me.dgTableData.EditMode = DataGridViewEditMode.EditOnEnter
        Catch excData As System.Exception
            MessageBox.Show(excData.Message, appName)
        End Try
    End Sub

    Private Sub dgDocEdit_CellBeginEdit(sender As Object, e As System.Windows.Forms.DataGridViewCellCancelEventArgs) Handles dgDocEdit.CellBeginEdit
        Me.tsbtnSave.Enabled = False

        'If Me.dgDocEdit.CurrentCellAddress.X = 2 Then
        '    valStartKolvo = Me.dgDocEdit.CurrentCell.Value
        'End If

        'If Me.dgDocEdit.CurrentCellAddress.X = 3 Then
        '    valStartCost = Me.dgDocEdit.CurrentCell.Value
        'End If

        'If valStartKolvo = 0 Then valStartKolvo = 1
        'If valStartCost = 0 Then valStartCost = 1
    End Sub

    Private Sub dgDocEdit_CellEndEdit(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgDocEdit.CellEndEdit
        If Me.dgDocEdit.CurrentCellAddress.X = 4 Then
            Me.dgDocEdit(3, Me.dgDocEdit.CurrentRow.Index).Value = Me.dgDocEdit(4, Me.dgDocEdit.CurrentRow.Index).Value / Me.dgDocEdit(2, Me.dgDocEdit.CurrentRow.Index).Value
        End If

        'If Me.dgDocEdit.CurrentCellAddress.X = 3 Then
        '    Me.dgDocEdit(4, Me.dgDocEdit.CurrentRow.Index).Value = Me.dgDocEdit(4, Me.dgDocEdit.CurrentRow.Index).Value / valStartCost * Me.dgDocEdit(3, Me.dgDocEdit.CurrentRow.Index).Value
        'End If
        If Me.dgDocEdit.CurrentCellAddress.X = 2 Then
            Me.dgDocEdit(4, Me.dgDocEdit.CurrentRow.Index).Value = Me.dgDocEdit(3, Me.dgDocEdit.CurrentRow.Index).Value * Me.dgDocEdit(2, Me.dgDocEdit.CurrentRow.Index).Value
        End If

        If Me.dgDocEdit.CurrentCellAddress.X = 3 Then
            Me.dgDocEdit(4, Me.dgDocEdit.CurrentRow.Index).Value = Me.dgDocEdit(3, Me.dgDocEdit.CurrentRow.Index).Value * Me.dgDocEdit(2, Me.dgDocEdit.CurrentRow.Index).Value
        End If


        Me.tsbtnSave.Enabled = True
    End Sub

    Private Sub tsbtnSave_Click(sender As System.Object, e As System.EventArgs) Handles tsbtnSave.Click
        Me.dgDocEdit.Update()

        Dim strSQL$, kolvo@, total@, summaNDS@, summa@

        For n As Integer = 0 To Me.dgDocEdit.RowCount - 1
            summa = Me.dgDocEdit("Цена", n).Value
            kolvo = Me.dgDocEdit("Количество", n).Value
            total = Me.dgDocEdit("Всего", n).Value
            summaNDS = (total * Me.dgDocEdit("nds", n).Value) / (100 + (Me.dgDocEdit("nds", n).Value))

            strSQL = "UPDATE Offering SET summa=" & Replace(summa, ",", ".") & ", prodName='" & Me.dgDocEdit("Наименование", n).Value & "', kolvo=" & Replace(kolvo, ",", ".") & ", total=" & Replace(total, ",", ".") & ", summaNDS=" & Replace(summaNDS, ",", ".") & " WHERE offeringID=" & Me.dgDocEdit(0, n).Value & ""
            ' MsgBox(strSQL)
            Module1.NonQuery1(strSQL)
        Next
        IsSaved = True
        frmDocOut.FillDSOffering(invoiceID)

        Me.Close()
    End Sub

    Private Sub tsbtnCancel_Click(sender As System.Object, e As System.EventArgs) Handles tsbtnCancel.Click
        LoadData()
    End Sub

    Private Sub ToolStripButton1_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripButton1.Click
        Me.Close()
    End Sub

End Class