Public Class fin_Kassa

    Private Sub Kassa_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try   'Загружаем безнальные счета
            Dim odaAddr As New SqlClient.SqlDataAdapter("SELECT custID, shortName FROM Organizations where KAgent_ID=(SELECT ID FROM KAgents WHERE type_ID =1) AND closed<>1 order by shortName", mcnnInt)
            Dim dtAddr As New DataTable : odaAddr.Fill(dtAddr)
            Me.cmbOrganization.DataSource = dtAddr    'Связать данные со списком
            Me.cmbOrganization.DisplayMember = "shortName"
            Me.cmbOrganization.ValueMember = "custID"

            'Заполнение списка офисов
            Dim odaOffices As New SqlClient.SqlDataAdapter("SELECT ID, name FROM Offices", mcnnInt)
            Dim dtOffices As New DataTable : odaOffices.Fill(dtOffices)
            Me.cmbOffice.DataSource = dtOffices
            Me.cmbOffice.DisplayMember = "name"
            Me.cmbOffice.ValueMember = "ID"
            Me.cmbOffice.SelectedValue = ofID


            Dim odaFounders As New SqlClient.SqlDataAdapter("SELECT ID, Name FROM Founders order by Name", mcnnInt)
            Dim dtFounders As New DataTable : odaFounders.Fill(dtFounders)
            Me.cmbFounder.DataSource = dtFounders 'Связать данные со списком
            Me.cmbFounder.DisplayMember = "Name"
            Me.cmbFounder.ValueMember = "ID"


            Dim odaFounders1 As New SqlClient.SqlDataAdapter("SELECT ID, Name FROM Founders order by Name", mcnnInt)
            Dim dtFounders1 As New DataTable : odaFounders1.Fill(dtFounders1)
            Me.cmbFounder1.DataSource = dtFounders1 'Связать данные со списком
            Me.cmbFounder1.DisplayMember = "Name"
            Me.cmbFounder1.ValueMember = "ID"
        Catch oexpData As System.Exception
            MessageBox.Show("Ошибка2: " & oexpData.Message, appName)
        End Try
    End Sub

    Function CheckedPass(ByVal pass As String) As Boolean
        If pass = "197630" Then
            Return True
        Else
            MsgBox("Неправильный пароль.", MessageBoxIcon.Error)
            Return False
        End If
    End Function

#Region " Применить "
    Private Sub btnApplyCashless_Click(sender As System.Object, e As System.EventArgs) Handles btnApplyCashless.Click

        If CheckedPass(Me.txtPwd.Text) = True Then
            Apply()
        Else
            MsgBox("Доступ запрещен.", MsgBoxStyle.Critical, appName)
        End If

        Me.txtPwd.Text = ""
    End Sub

    Private Sub Apply()
        If Me.cmbModeCashless.SelectedIndex = -1 Then
            MsgBox("Не выбран режим.", MsgBoxStyle.Critical, appName)
            Me.cmbModeCashless.Focus()
            Exit Sub
        End If

        If MessageBox.Show("Отмена операции невозможна. Вы действительно хотите " + Me.cmbModeCashless.Text + "?", appName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Dim strSQL$ = Nothing
            'проблема экспресс рекламы
            Try
                Select Case Me.cmbModeCashless.SelectedIndex
                    Case Is = 0 ' снять
                        strSQL$ = "INSERT INTO fin_ManyOut (amount,description, fopl_ID,found_ID,payer,org_ID) "
                        strSQL &= "VALUES (" & Replace(Me.nudCashless.Value, ",", ".") & ", '" & Trim(Me.txtDescriptionCashless.Text) & "', 2," & Me.cmbFounder.SelectedItem(0) & "," & Me.cmbOrganization.SelectedItem(0) & "," & Me.cmbOrganization.SelectedItem(0) & ")"
                    Case Is = 1 'внести
                        strSQL$ = "INSERT INTO fin_ManyIn (amount,description, fopl_ID,org_ID,found_ID) "
                        strSQL &= "VALUES (" & Replace(Me.nudCashless.Value, ",", ".") & ",'" & Trim(Me.txtDescriptionCashless.Text) & "',2," & Me.cmbOrganization.SelectedItem(0) & "," & Me.cmbFounder.SelectedItem(0) & ")"
                End Select

                Module1.NonQuery1(strSQL)

                MsgBox("Готово.", MsgBoxStyle.Information, appName)

                UpdateCashless()
            Catch excData As System.Exception
                MsgBox("Ошибка при " + Me.cmbModeCashless.Text, MessageBoxIcon.Stop, appName) : Exit Sub
                'Finally
                '    mcnnInt.Close()
            End Try
        End If
    End Sub

    Private Sub btnApplyCash_Click(sender As System.Object, e As System.EventArgs) Handles btnApplyCash.Click
        'If idConfig = 25712 Then
        '    If Me.txtPwdCash.Text = "нал" Then ' нал сделан для бизнес проспекта
        '        ApplyCash()
        '    Else
        '        MsgBox("Доступ запрещен.", MsgBoxStyle.Critical, appName)
        '    End If
        '    Me.txtPwdCash.Text = ""
        'Else
        If CheckedPass(Me.txtPwdCash.Text) = True Then '
            ApplyCash()
        Else
            MsgBox("Доступ запрещен.", MsgBoxStyle.Critical, appName)
        End If

        Me.txtPwdCash.Text = ""
        ' End If
    End Sub

    Private Sub ApplyCash()
        If Me.cmbModeCash.SelectedIndex = -1 Then
            MsgBox("Не выбран режим.", MsgBoxStyle.Critical, appName)
            Me.cmbModeCash.Focus()
            Exit Sub
        End If

        If MessageBox.Show("Отмена операции невозможна. Вы действительно хотите " + Me.cmbModeCash.Text + "?", appName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Dim strSQL$ = Nothing

            Try
                Select Case Me.cmbModeCash.SelectedIndex
                    Case Is = 0 ' снять
                        strSQL$ = "INSERT INTO fin_ManyOut (amount, description, fopl_ID, office_ID, found_ID) "
                        strSQL &= "VALUES (" & Replace(Me.nudCash.Value, ",", ".") & ",'" & Trim(Me.txtDescriptionCash.Text) & "',1," & Me.cmbOffice.SelectedItem(0) & "," & Me.cmbFounder1.SelectedItem(0) & ")"
                    Case Is = 1 'внести
                        strSQL$ = "INSERT INTO fin_ManyIn (amount, description, fopl_ID, office_ID, found_ID) "
                        strSQL &= "VALUES (" & Replace(Me.nudCash.Value, ",", ".") & ",'" & Trim(Me.txtDescriptionCash.Text) & "',1," & Me.cmbOffice.SelectedItem(0) & "," & Me.cmbFounder1.SelectedItem(0) & ")"
                End Select

                Module1.NonQuery1(strSQL)

                UpdateCash()

                MsgBox("Готово.", MsgBoxStyle.Information, appName)
            Catch excData As System.Exception
                MsgBox("Ошибка при " + Me.cmbModeCash.Text, MessageBoxIcon.Stop, appName) : Exit Sub
            Finally
                mcnnInt.Close()
            End Try
        End If


    End Sub
#End Region

    Private Sub ToolStripTextBox1_TextChanged(sender As Object, e As System.EventArgs) Handles ToolStripTextBox1.TextChanged

        Dim a As Boolean

        If sender.Text = "нал" Then
            a = True
        Else
            a = False
        End If
    End Sub

    Private Sub btnUpdateCashless_Click(sender As System.Object, e As System.EventArgs) Handles btnUpdateCashless.Click
        UpdateCashless()
    End Sub

    Private Sub UpdateCashless()
        Dim objDA As SqlClient.SqlDataAdapter
        Dim cmd As New SqlClient.SqlCommand

        cmd.Connection = mcnnInt
        cmd.CommandText = "[sp_FinCashless]"
        cmd.CommandType = CommandType.StoredProcedure

        objDA = New SqlClient.SqlDataAdapter(cmd)

        Dim dtSklad As New DataTable : objDA.Fill(dtSklad)

        Me.dgCashless.DataSource = dtSklad

        ColHideDG(dgCashless)
    End Sub

    Private Sub btnUpdateCash_Click(sender As System.Object, e As System.EventArgs) Handles btnUpdateCash.Click
        UpdateCash()
    End Sub

    Private Sub UpdateCash()

        Dim cmd As New SqlClient.SqlCommand

        cmd.Connection = mcnnInt
        cmd.CommandText = "[sp_FinCash]"
        cmd.CommandType = CommandType.StoredProcedure

        Dim objDA As New SqlClient.SqlDataAdapter(cmd)
        Dim dtFin As New DataTable : objDA.Fill(dtFin)

        Me.dgCash.DataSource = dtFin

        ColHideDG(dgCash)
    End Sub

    Private Sub ColHideDG(NameGrid As Object)
        For Each col As Object In NameGrid.Columns
            If col.name = "ID" Or col.name = "custID" Or col.name = "ofID" Then
                col.visible = False
            End If
        Next

        NameGrid.DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomRight
        NameGrid.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomLeft
        NameGrid.ClearSelection()
    End Sub

    Private Sub dgCashless_SelectionChanged(sender As Object, e As EventArgs) Handles dgCashless.SelectionChanged
        If Me.dgCashless.SelectedRows.Count > 0 Then
            Me.cmbOrganization.SelectedValue = Me.dgCashless("custID", Me.dgCashless.CurrentRow.Index).Value()
        End If
    End Sub

    Private Sub dgCash_SelectionChanged(sender As Object, e As EventArgs) Handles dgCash.SelectionChanged
        If Me.dgCash.SelectedRows.Count > 0 Then
            Me.cmbOffice.SelectedValue = Me.dgCash("ofID", Me.dgCash.CurrentRow.Index).Value()
        End If
    End Sub
End Class