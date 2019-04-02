Public Class fin_ArtExpens

    Dim modaLookupData As SqlClient.SqlDataAdapter
    Dim dtData As DataTable

    Private Sub fin_ArtExpens_Activated(sender As Object, e As System.EventArgs) Handles Me.Activated
        LoadData()
    End Sub

    Private Sub fin_ArtExpens_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'LoadData()
    End Sub

    Private Sub LoadData()
        Me.dgTableData.Columns.Clear()

        Try
            Dim cmb As New DataGridViewComboBoxColumn()
            cmb.Width = 500
            cmb.HeaderText = "Вид затраты"
            cmb.Name = "cmbClassExpenses"

            Dim odaClassExp As SqlClient.SqlDataAdapter = New SqlClient.SqlDataAdapter("SELECT ID, name FROM fin_ClassifierExpenses", mcnnInt)
            Dim dtClassExp As New DataTable

            odaClassExp.Fill(dtClassExp)

            cmb.DataSource = dtClassExp  'Связать данные со списком
            cmb.DisplayMember = "name"
            cmb.ValueMember = "ID"


            modaLookupData = New SqlClient.SqlDataAdapter("Select ID, name, ID_classExp, description From fin_ArticlesExpenses", mcnnInt)

            dtData = New DataTable
            modaLookupData.Fill(dtData)


            If dtData.Rows.Count > 0 Then
                Me.dgTableData.DataSource = dtData

                For n As Integer = 0 To Me.dgTableData.ColumnCount - 1
                    If Me.dgTableData.Columns(n).Name = "ID_classExp" Then
                        Me.dgTableData.Columns("ID_classExp").Visible = False
                    End If

                    If Me.dgTableData.Columns(n).Name = "ID" Then
                        Me.dgTableData.Columns("ID").Visible = False
                    End If
                Next

                'добавляем столбец с типами затрат
                Me.dgTableData.Columns.Add(cmb)

                For n As Integer = 0 To dtData.Rows.Count - 1
                    Me.dgTableData("cmbClassExpenses", n).Value = dtData.Rows(n)("ID_classExp")
                Next
            End If
        Catch excData As System.Exception
            MessageBox.Show(excData.Message, appName)
        End Try
    End Sub

    Private Sub tsbtnOK_Click(sender As System.Object, e As System.EventArgs) Handles tsbtnOK.Click
        For n As Integer = 0 To Me.dgTableData.Rows.Count - 1
            '  MsgBox(CStr(Me.dgTableData("cmbClassExpenses", n).Value()))
            dtData.Rows(n)("ID_classExp") = Me.dgTableData("cmbClassExpenses", n).Value()
            dtData.Rows(n)("description") = Me.dgTableData("description", n).Value()
        Next

        dtData.EndInit()

        Dim custCB As New SqlClient.SqlCommandBuilder(modaLookupData)

        Try
            modaLookupData.Update(dtData)
            dtData.AcceptChanges()
            MessageBox.Show("Сохранил", appName)

            '  Me.dgTableData.Columns.Remove("cmbClassExpenses")

            LoadData()
        Catch ex As System.Exception
            MessageBox.Show(ex.Message, appName)
        End Try
    End Sub

    Private Sub tsbtnExit_Click(sender As System.Object, e As System.EventArgs) Handles tsbtnExit.Click
        Me.Close()
    End Sub

    Private Sub СтатьиЗатратToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles СтатьиЗатратToolStripMenuItem.Click
        spravSQL = "SELECT * FROM fin_ArticlesExpenses"

        ModCallForm.CallForm("Статьи затрат", 1, 3)
    End Sub
End Class