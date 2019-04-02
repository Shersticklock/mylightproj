Public Class frmEmplRole
    Dim mdsEmplIndiv As New DataSet
    Dim modaEmplIndiv As SqlClient.SqlDataAdapter
    Dim mdrEmplIndiv As DataRow
    Dim mblnAdd As Boolean

    Private Sub frmEmplRole_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ActivateEditing(False)
        LoadPosts()
    End Sub

    Private Sub LoadPosts()
        Try
            Dim odaPost As New SqlClient.SqlDataAdapter("SELECT postID, postName FROM Posts order by postName", mcnnInt)
            Dim dtPost As New DataTable : odaPost.Fill(dtPost)

            Me.lstPosts.DataSource = dtPost     '—в€зать данные со списком
            Me.lstPosts.DisplayMember = "postName"
            Me.lstPosts.ValueMember = "postID"
        Catch ex As System.Exception
        End Try

        Me.nudPrioritet.Maximum = CInt(Module1.NonQuery1Scalar("SELECT count(*) FROM Posts"))
    End Sub

    Private Sub LoadParamPost()
        mdsEmplIndiv.Clear()
        If Me.lstPosts.SelectedIndex > -1 Then
            Try
                modaEmplIndiv = New SqlClient.SqlDataAdapter("SELECT * FROM Posts WHERE postID = " & Me.lstPosts.SelectedItem(0) & "", mcnnInt)
                modaEmplIndiv.Fill(mdsEmplIndiv, "Posts")
                mdrEmplIndiv = mdsEmplIndiv.Tables("Posts").Rows(0)

                Me.txtName.Text = mdrEmplIndiv("postName")
                Me.nudPrioritet.Value = mdrEmplIndiv("postPrioritet")

                Dim n As Integer

                For n = 0 To Me.chlbAllowMenu.Items.Count - 1
                    Me.chlbAllowMenu.SetItemChecked(n, mdrEmplIndiv("b" & CStr(n)))
                Next
              
            Catch oexpData As System.Exception
                MessageBox.Show("ќшибка при загрузке полномочий ролей. " & oexpData.Message, appName)
                Exit Sub
            End Try
        End If
    End Sub

    Private Sub lstPosts_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstPosts.SelectedIndexChanged
        LoadParamPost()
    End Sub

    Private Sub ActivateEditing(ByVal bEnable As Boolean)
        Me.lstPosts.Enabled = Not bEnable

        For Each oCurr As Object In Me.TableLayoutPanel2.Controls   'обработать в цикле каждый элемент в форме
            If TypeOf oCurr Is Label Then
            Else
                oCurr.enabled = bEnable
                oCurr.BackColor() = System.Drawing.Color.White
            End If
        Next

        Me.tsbtnEdit.Enabled = Not bEnable
        Me.tsbtnNew.Enabled = Not bEnable
        Me.tsbtnSave.Enabled = bEnable
    End Sub

    Private Sub tsbtnNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbtnNew.Click
        mblnAdd = True

        For Each oCtl As Object In Me.TableLayoutPanel2.Controls
            If TypeOf oCtl Is TextBox Then
                Dim strName$ = Mid(oCtl.Name, 4)
                oCtl.text = ""
            End If
        Next

        ActivateEditing(True)
        Me.txtName.Focus()
    End Sub

    Private Sub tsbtnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbtnEdit.Click
        mblnAdd = False
        ActivateEditing(True)
    End Sub

    Private Sub tsbtnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbtnSave.Click
        SaveRecord()
    End Sub

#Region " —охранить изменени€  - значени€ записываютс€ в таб Posts в пол€ b1, b2 .... "
    Private Sub SaveRecord()
        Dim current% = Me.lstPosts.SelectedIndex ' текущее местонахождение в списке
        Dim oCtl As Object
        Dim n As Integer

        If Me.txtName.Text = "" Then MsgBox("ѕоле Ќаименование должно быть заполнено", MsgBoxStyle.Critical, appName) : Exit Sub
        If mblnAdd = True Then mdrEmplIndiv = mdsEmplIndiv.Tables("Posts").NewRow

        mdrEmplIndiv.BeginEdit() 'приступить к редактированию строки

        Try
            For Each oCtl In Me.TableLayoutPanel2.Controls 'ѕроверить текстовые пол€
                If TypeOf oCtl Is TextBox Then
                    Dim strName$ = Mid(oCtl.Name, 4)

                    Try 'ошибки игнорируютс€
                        mdrEmplIndiv(strName) = oCtl.text
                    Catch oexp As System.Exception
                    End Try
                End If
            Next

            mdrEmplIndiv("postName") = Me.txtName.Text
            mdrEmplIndiv("postPrioritet") = Me.nudPrioritet.Value

            For n = 0 To Me.chlbAllowMenu.Items.Count - 1
                If Me.chlbAllowMenu.GetItemChecked(n) = True Then mdrEmplIndiv("b" & CStr(n)) = True Else mdrEmplIndiv("b" & CStr(n)) = False
            Next
        Catch oexp As System.Exception
            MessageBox.Show("Error Occured:" & oexp.Message, appName)
        End Try

        mdrEmplIndiv.EndEdit() '«авершить редактирование строки данных

        Try
            If mblnAdd = True Then
                mdsEmplIndiv.Tables("Posts").Rows.Add(mdrEmplIndiv)
            End If

            Dim ocbMatIndiv As SqlClient.SqlCommandBuilder = New SqlClient.SqlCommandBuilder(modaEmplIndiv)

            If mblnAdd = True Then
                modaEmplIndiv.InsertCommand = ocbMatIndiv.GetInsertCommand  ' ќбеспечить создание оператора Insert SQL
            Else
                modaEmplIndiv.UpdateCommand = ocbMatIndiv.GetUpdateCommand
            End If

            modaEmplIndiv.Update(mdsEmplIndiv, "Posts") 'выполнить команду SQL и закрыть соед.
            mdsEmplIndiv.Tables("Posts").AcceptChanges()

            ActivateEditing(False)

            If mblnAdd = True Then
                modaEmplIndiv.InsertCommand.Connection.Close()  'закрыть соединение

                LoadPosts()

                Me.lstPosts.SelectedIndex = Me.lstPosts.Items.Count - 1 ' ≈сли добавили компанию то перемещаемс€ в конец
            Else
                Me.lstPosts.SelectedIndex = current ' ≈сли редактировали то возвращаемс€ к ней
            End If
        Catch excData As System.Exception
            MessageBox.Show("Error Occured:" & excData.Message, appName)
        End Try

        ActivateEditing(False)
    End Sub
#End Region

    Private Sub tsbtnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbtnCancel.Click
        mblnAdd = False
        LoadParamPost()
        ActivateEditing(False)
    End Sub

    Private Sub tsbtnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbtnExit.Click
        Me.Close()
    End Sub
End Class