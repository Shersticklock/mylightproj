Public Class frmMatFormats

    Dim mdrMatIndiv As DataRow
    Dim mblnAdd As Boolean
    Dim currentID%

    Private Sub frmMatFormats_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadList()
    End Sub

#Region " Загрузка лист материлов "
    Private Sub LoadList()
        LoadFormats()
    End Sub
#End Region

    Private Sub LoadFormats()
        Try
            Dim odaMatList As New SqlClient.SqlDataAdapter("SELECT ID, formatName FROM MatFormats order by formatName", mcnnInt)
            Dim dtMatFormat As New DataTable : odaMatList.Fill(dtMatFormat)

            Me.lstMaterials.DataSource = dtMatFormat  'Связать данные со списком
            Me.lstMaterials.DisplayMember = "formatName"
            Me.lstMaterials.ValueMember = "ID"
        Catch oexpData As System.Exception
            MsgBox(oexpData.Message, MsgBoxStyle.Critical, appName)
        End Try
    End Sub

#Region " Загрузка параметров материала "
    Private Sub LoadIndividual()
        Dim strName As String
        Dim oCtl As Object
        Dim dtMat As New DataTable
        Dim modaMatIndiv As SqlClient.SqlDataAdapter


        If Me.lstMaterials.SelectedIndex <> -1 Then
            Try
                modaMatIndiv = New SqlClient.SqlDataAdapter("SELECT * FROM MatFormats WHERE ID = " & Me.lstMaterials.SelectedItem(0) & " ", mcnnInt)
                modaMatIndiv.Fill(dtMat)
                mdrMatIndiv = dtMat.Rows(0)

                For Each oCtl In Me.tlpAttrMat.Controls
                    If TypeOf oCtl Is TextBox Then
                        strName = Mid(oCtl.name, 4)
                        Try
                            oCtl.text = mdrMatIndiv(strName).ToString
                        Catch oexp As System.Exception
                        End Try
                    End If
                Next

                If mdrMatIndiv("accessible") = True Then
                    Me.cmbAccessible.SelectedIndex = 1
                Else
                    Me.cmbAccessible.SelectedIndex = 0
                End If

                Me.chkDefault.Checked = mdrMatIndiv("formatDefault")
            Catch oexpData As System.Exception
                MessageBox.Show("Error загрузки данных материала: " & oexpData.Message, appName)
                Exit Sub
            End Try
        End If
    End Sub
#End Region

    Private Sub tsbtnSaveMat_Click(sender As Object, e As EventArgs) Handles tsbtnSaveMat.Click
        Dim current As Integer = Me.lstMaterials.SelectedIndex

        SaveRecord()

        If mblnAdd = True Then
      
        Else
            Me.lstMaterials.Focus()
        End If

        LoadIndividual()
    End Sub

#Region " Сохранить изменения "
    Private Sub SaveRecord()
        If Me.txtformatName.Text = "" Then ' наименование
            Me.ErrorProvider1.SetError(Me.txtformatName, "Поле наименование должно быть заполнено")
            Exit Sub
        Else : Me.ErrorProvider1.Clear() : End If

        If Me.txtsizeX.Text = "" Then
            Me.ErrorProvider1.SetError(Me.txtsizeX, "Поле размер должно быть заполнено")
            Exit Sub
        Else : Me.ErrorProvider1.Clear() : End If

        If Me.txtsizeY.Text = "" Then
            Me.ErrorProvider1.SetError(Me.txtsizeY, "Поле размер должно быть заполнено")
            Exit Sub
        Else : Me.ErrorProvider1.Clear() : End If

        If Me.txttotalDimX.Text = "" Then
            Me.ErrorProvider1.SetError(Me.txttotalDimX, "Поле размер должно быть заполнено")
            Exit Sub
        Else : Me.ErrorProvider1.Clear() : End If

        If Me.txttotalDimY.Text = "" Then
            Me.ErrorProvider1.SetError(Me.txttotalDimY, "Поле размер должно быть заполнено")
            Exit Sub
        Else : Me.ErrorProvider1.Clear() : End If

        If Me.cmbAccessible.SelectedIndex = -1 Then  '
            Me.ErrorProvider1.SetError(Me.cmbAccessible, "Должна быть указана доступность формата")
            Exit Sub
        Else : Me.ErrorProvider1.Clear() : End If

        If Me.txtnacFormat.Text = "" Then
            Me.ErrorProvider1.SetError(Me.txtnacFormat, "Поле Наценка должно быть заполнено")
            Exit Sub
        Else : Me.ErrorProvider1.Clear() : End If

        Dim current As Integer
        Dim strSQL$

        Try
            If mblnAdd = True Then
                strSQL = "INSERT INTO MatFormats (formatName, sizeX, sizeY, totalDimX, totalDimY, accessible, nacFormat, formatDefault) VALUES ('" & Me.txtformatName.Text & "', "
                strSQL &= " " & Replace(Me.txtsizeX.Text, ",", ".") & ", " & Replace(Me.txtsizeY.Text, ",", ".") & ", " & Replace(Me.txttotalDimX.Text, ",", ".") & ", " & Replace(Me.txttotalDimY.Text, ",", ".") & ", " & Me.cmbAccessible.SelectedIndex & ", " & CInt(Me.txtnacFormat.Text) & ", " & CInt(Me.chkDefault.Checked) & ")"
            Else
                current = Me.lstMaterials.SelectedIndex ' текущее местонахождение в списке
                strSQL = "UPDATE MatFormats SET formatName= '" & Trim(Me.txtformatName.Text) & "', nacFormat = " & CInt(Me.txtnacFormat.Text) & ""
                strSQL &= ", sizeX =" & Replace(Me.txtsizeX.Text, ",", ".") & ", sizeY = " & Replace(Me.txtsizeY.Text, ",", ".") & " "
                strSQL &= ", totalDimX =" & Replace(Me.txttotalDimX.Text, ",", ".") & ", totalDimY = " & Replace(Me.txttotalDimY.Text, ",", ".") & " "
                strSQL &= ", accessible = " & Me.cmbAccessible.SelectedIndex & ", formatDefault = " & CInt(Me.chkDefault.Checked) & " WHERE ID = " & Me.lstMaterials.SelectedItem(0) & ""
            End If

            Module1.NonQuery1(strSQL)

            LoadList()

            If mblnAdd = True Then
                Me.lstMaterials.SelectedIndex = Me.lstMaterials.Items.Count - 1 ' Если добавили то перемещаемся в конец
            Else
                Me.lstMaterials.SelectedIndex = currentID
            End If

            ActivateEditing(False)
        Catch excData As System.Exception
            MessageBox.Show("Error Occured:" & excData.Message, appName)
            Exit Sub
        End Try
    End Sub
#End Region

#Region " Активация редактирования материала "
    Private Sub ActivateEditing(ByVal bEnable As Boolean)
        ' Если редактирование разрешено то перемещение по запрещено

        Me.lstMaterials.Enabled = Not bEnable

        Dim oCurr As Object

        For Each oCurr In Me.tlpAttrMat.Controls() 'обработать в цикле каждый элемент в форме
            If TypeOf oCurr Is ComboBox Then
                oCurr.Enabled = bEnable
                If oCurr.Enabled = False Then
                    oCurr.BackColor() = System.Drawing.Color.White
                End If
            End If

            If TypeOf oCurr Is TextBox Then
                oCurr.Enabled = bEnable
                If oCurr.Enabled = False Then
                    oCurr.BackColor() = System.Drawing.Color.White
                End If
                If mblnAdd = True Then
                    oCurr.text = Nothing
                End If
            End If
        Next

        Me.tsbtnNewMat.Enabled = Not bEnable
        Me.tsbtnEditMat.Enabled = Not bEnable

        If bEnable = True Then
            Dim odaType1 As New SqlClient.SqlDataAdapter("SELECT ID, name From MatCategories order by Name", mcnnInt)
            Dim dtType1 As New DataTable : odaType1.Fill(dtType1)
        End If

        Me.txtformatName.Focus()
    End Sub
#End Region

    Private Sub lstMaterials_SelectedValueChanged(sender As Object, e As EventArgs) Handles lstMaterials.SelectedValueChanged
        LoadIndividual()
    End Sub

    Private Sub tsbtnExit_Click(sender As Object, e As EventArgs) Handles tsbtnExit.Click
        Me.Close()
    End Sub

    Private Sub tsbtnEditMat_Click(sender As Object, e As EventArgs) Handles tsbtnEditMat.Click
        If Me.lstMaterials.SelectedIndex = -1 Then
            MsgBox("Не выбран материал.", MsgBoxStyle.Critical, appName)
        Else
            currentID = Me.lstMaterials.SelectedIndex
            mblnAdd = False

            ActivateEditing(True)
        End If
    End Sub

    Private Sub tsbtnCancel_Click(sender As Object, e As EventArgs) Handles tsbtnCancel.Click
        Me.lstMaterials.Enabled = False

        Dim current As Integer = Me.lstMaterials.SelectedIndex

        If mblnAdd = True Then mblnAdd = False
        ActivateEditing(False)
        Me.lstMaterials.SelectedIndex = current

        If Me.lstMaterials.SelectedIndex <> -1 Then
            LoadIndividual()
        End If
    End Sub

    Private Sub tsbtnDeleteMat_Click(sender As Object, e As EventArgs) Handles tsbtnDeleteMat.Click
        If MessageBox.Show("Удалить печатный формат-" & Me.lstMaterials.SelectedItem(1) & "?", appName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Module1.NonQuery1("DELETE FROM MatFormats WHERE ID=" & Me.lstMaterials.SelectedItem(0) & "")

            LoadFormats()
        Else
            Exit Sub
        End If
    End Sub

    Private Sub tsbtnNewMat_Click(sender As Object, e As EventArgs) Handles tsbtnNewMat.Click
        Try
            mblnAdd = True
            ActivateEditing(True)
        Catch ex As System.Exception
            MessageBox.Show("Error Occured:" & ex.Message, appName)
            Exit Sub
        End Try
    End Sub

End Class