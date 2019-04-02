Public Class frmConfigCalcMat
    Dim dtMatList As DataTable = New DataTable
    Dim odaMatList As SqlClient.SqlDataAdapter
    Dim n As Integer = 0
    Public fff As String
    Dim strSQLmain As String = "SELECT ID, Name FROM MatTypes WHERE ID IN "

    Private Sub frmConfigCalc_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Me.txtNameControl.Text = fff

        Try
            Dim odaType As New SqlClient.SqlDataAdapter("SELECT ID, name From Services order by name", mcnnInt) 'WHERE active = '1'
            Dim dtType As New DataTable : odaType.Fill(dtType)

            Me.cmbService.DataSource = dtType
            Me.cmbService.DisplayMember = "name"
            Me.cmbService.ValueMember = "ID"
            Me.cmbService.SelectedValue = serviceID
        Catch ex As System.Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, appName)
        End Try

        PopulateCategories()
    End Sub

    Sub PopulateCategories()
        Dim pNode As TreeNode ' parent
        Dim cNode As TreeNode ' child
        Dim ResultSet As DataSet = RunQuery("Select ID, Name From MatCategories Where description='1' order by Name")

        Me.tvMat.Nodes.Clear()

        If ResultSet.Tables.Count > 0 Then

            Dim row As DataRow

            For Each row In ResultSet.Tables(0).Rows
                pNode = tvMat.Nodes.Add(row("Name").ToString()) ' add parent
                pNode.Tag = row("ID").ToString()

                Dim ResultSet1 As DataSet = RunQuery("Select ID, Name From MatTypes WHERE matCatID=" & row("ID") & "  order by Name")
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
        Dim DBAdapter As SqlClient.SqlDataAdapter
        Dim ResultsDataSet As New DataSet

        Try
            DBAdapter = New SqlClient.SqlDataAdapter(QueryString, mcnnInt)
            DBAdapter.Fill(ResultsDataSet)
            mcnnInt.Close()
        Catch ex As System.Exception
            If mcnnInt.State = ConnectionState.Open Then
                mcnnInt.Close()
            End If
            MessageBox.Show(ex.Message, appName)
        End Try
        Return ResultsDataSet
    End Function

    Private Sub LoadTypes(ByVal dt As DataTable)
        Me.clbMatTypeID.DataSource = dt 'Связать данные со списком
        Me.clbMatTypeID.DisplayMember = "matName"
        Me.clbMatTypeID.ValueMember = "matID"
    End Sub


    Private Sub tvMat_AfterSelect(sender As System.Object, e As System.Windows.Forms.TreeViewEventArgs) Handles tvMat.AfterSelect
        LoadList()
    End Sub

#Region " Загрузка выбранных типов материалов "
    Private Sub LoadList()
        Dim strSQL$ = Nothing

        If Me.tvMat.SelectedNode.Level = 1 Then
            n += 1

            If n = 1 Then
                strSQL = "(" & CStr(Me.tvMat.SelectedNode.Tag) & ""
            Else
                strSQLmain = Replace(strSQLmain, ")", ", ")
                strSQL = CStr(Me.tvMat.SelectedNode.Tag)
            End If

            strSQLmain += strSQL & ")"
            dtMatList.Clear()

            Try
                odaMatList = New SqlClient.SqlDataAdapter(strSQLmain, mcnnInt)
                odaMatList.Fill(dtMatList)

                Me.clbMatTypeID.DataSource = dtMatList 'Связать данные со списком
                Me.clbMatTypeID.DisplayMember = "Name"
                Me.clbMatTypeID.ValueMember = "ID"

                If Me.clbMatTypeID.Items.Count > 0 Then
                    Dim i%

                    For i = 0 To Me.clbMatTypeID.Items.Count - 1
                        '  If Me.clbMatTypeID.Items(i).checked = True Then
                        Me.clbMatTypeID.SetItemChecked(i, True)
                        '   End If
                        '   Me.clbMatTypeID.SetItemChecked(i - 1, True)
                    Next

                End If

            Catch oexpData As System.Exception
                MsgBox(strSQLmain + "  " + oexpData.Message, MsgBoxStyle.Critical, appName)
            End Try
        End If
    End Sub
#End Region


    Private Sub tsbtnCost_Click(sender As Object, e As EventArgs) Handles tsbtnCost.Click
        If Me.txtNameControl.Text = Nothing Then
            MsgBox("Не указано имя элемента выпадающего списка", MsgBoxStyle.Critical, appName) : Exit Sub
        End If

        Dim s As String = Nothing

        For Each itemChecked As Object In Me.clbMatTypeID.CheckedItems
            If s <> Nothing Then s += ", "
            s += CStr(itemChecked.item(0))
        Next

        If s Is Nothing Then
            MsgBox("Не выбраны типы материалов", MsgBoxStyle.Critical, appName)
        Else
            'удаляем предыдущие записи
            Module1.NonQuery1("DELETE FROM CalcSettings WHERE serviceID=" & Me.cmbService.SelectedItem(0) & " AND nameControl='" & Trim(Me.txtNameControl.Text) & "' AND controlTag='" & Me.txtControlTag.Text & "'")

            Dim strSQL1$ = "INSERT INTO CalcSettings (serviceID, nameControl, listMatTypeID, nameService, controlTag)"
            strSQL1 &= " VALUES (" & Me.cmbService.SelectedItem(0) & ",'" & Trim(Me.txtNameControl.Text) & "','" & s & "','" & Me.cmbService.Text & "','" & Me.txtControlTag.Text & "')"
            '  strSQL1 &= " (SELECT name FROM services WHERE ID=" & Me.cmbService.SelectedItem(0) & ") )"
            'strSQL1 &= " "

            Module1.NonQuery1(strSQL1)
            '  MsgBox("Готово", MsgBoxStyle.Information, appName)
            Me.Close()
        End If
    End Sub

    Private Sub tsbtnOK_Click(sender As Object, e As EventArgs) Handles tsbtnOK.Click
        Me.Close()
    End Sub
End Class