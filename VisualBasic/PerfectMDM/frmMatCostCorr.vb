Public Class frmMatCostCorr

    Private Sub frmMatCostCorr_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "Коррекция цен на материал"

        Dim odaTypeMat As New SqlClient.SqlDataAdapter("SELECT ID, Name From MatTypes order by name", mcnnInt)
        Dim dtTypeMat As New DataTable : odaTypeMat.Fill(dtTypeMat)
        Me.cmbMatType.DataSource = dtTypeMat
        Me.cmbMatType.DisplayMember = "Name"
        Me.cmbMatType.ValueMember = "ID"

        PopulateCategories()
    End Sub

    Sub PopulateCategories()
        Dim pNode As TreeNode ' parent
        Dim cNode As TreeNode ' child
        Dim ResultSet As DataSet = RunQuery("Select ID, Name From MatCategories order by name ")

        Me.tvMatCorr.Nodes.Clear()

        If ResultSet.Tables.Count > 0 Then

            Dim row As DataRow

            For Each row In ResultSet.Tables(0).Rows
                pNode = Me.tvMatCorr.Nodes.Add(row("Name").ToString()) ' add parent
                pNode.Tag = row("ID").ToString()

                Dim ResultSet1 As DataSet = RunQuery("Select ID, Name From MatTypes WHERE matCatID = " & row("ID") & " order by name ")
                Dim row1 As DataRow

                For Each row1 In ResultSet1.Tables(0).Rows
                    cNode = New TreeNode ' another way to add controls - create before adding
                    cNode.Text = row1("Name").ToString()
                    cNode.Tag = row1("ID").ToString()
                    pNode.Nodes.Add(cNode) ' add child
                Next
            Next
        End If
    End Sub

    Function RunQuery(ByVal QueryString As String) As DataSet
        Dim DBAdapter As New SqlClient.SqlDataAdapter(QueryString, mcnnInt)
        Dim ResultsDataSet As New DataSet : DBAdapter.Fill(ResultsDataSet)
        Return ResultsDataSet
    End Function

    Private Sub tsbtnSaveMat_Click(sender As Object, e As EventArgs) Handles tsbtnSaveMat.Click
        If Me.cmbMatType.SelectedIndex = -1 Then
            MsgBox("Не выбран тип материала.", MsgBoxStyle.Information, appName)
            Me.tvMatCorr.FindForm()
            Exit Sub
        Else
            Select Case Me.tvMatCorr.SelectedNode.Level
                Case Is = 0
                    MsgBox("Не выбран тип материала.", MsgBoxStyle.Information, appName)
                    Exit Sub
                Case Is = 1
                    Select Case MsgBox(Prompt:="Увеличить отпускную цену для выбранного типа материалов в " & Me.nudK.Value.ToString & " раза ?", Buttons:=vbYesNo, Title:=appName)
                        Case Is = vbYes
                            Try
                                ' Module1.NonQuery1("UPDATE Materials SET priceOut = priceOut * " & Me.nudK.Value & "  WHERE matID = " & Me.tvMatCorr.SelectedNode.Tag & " ")
                                Dim cmd As New SqlClient.SqlCommand

                                cmd.Connection = mcnnInt
                                cmd.CommandType = CommandType.StoredProcedure

                                cmd.CommandText = "[sp_Mat_CostCorr]"
                                cmd.Parameters.Add(New SqlClient.SqlParameter("@typeID", SqlDbType.Int))
                                cmd.Parameters("@typeID").Value = Me.tvMatCorr.SelectedNode.Tag

                                cmd.Parameters.Add(New SqlClient.SqlParameter("@koefCost", SqlDbType.Decimal))
                                cmd.Parameters("@koefCost").Value = Me.nudK.Value

                                cmd.Parameters.Add(New SqlClient.SqlParameter("@koefCostBay", SqlDbType.Decimal))
                                cmd.Parameters("@koefCostBay").Value = Me.nudKbay.Value

                                mcnnInt.Open()
                                cmd.ExecuteNonQuery()
                                MsgBox("Выполнено", MsgBoxStyle.Information, appName)
                            Catch excData As System.Exception
                                MsgBox("Возможно процедура не оплачена и не активирована. Обратитесь к разработчику.", MsgBoxStyle.Information, appName)
                                MsgBox(excData.Message, MsgBoxStyle.Critical, appName)
                                Exit Sub
                            Finally
                                mcnnInt.Close()
                                ' Me.Close()
                            End Try
                        Case Is = vbNo
                            Exit Sub
                    End Select
            End Select
        End If
    End Sub

    Private Sub tsbtnExit_Click(sender As Object, e As EventArgs) Handles tsbtnExit.Click
        Me.Close()
    End Sub

    Private Sub tvMatCorr_AfterSelect(sender As Object, e As TreeViewEventArgs) Handles tvMatCorr.AfterSelect
        Select Case Me.tvMatCorr.SelectedNode.Level
            Case Is = 0
                Exit Sub
            Case Is = 1
                Me.cmbMatType.SelectedValue = Me.tvMatCorr.SelectedNode.Tag
        End Select
    End Sub

End Class