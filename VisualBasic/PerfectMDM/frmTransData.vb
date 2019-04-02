Imports System.IO
Imports Microsoft.SqlServer.Server
Imports System.Windows.Forms

Public Class frmTransData

    Dim modaLookupData As SqlClient.SqlDataAdapter
    Dim strPath As String

    Dim mdsPrice As DataSet
    Dim modaPrice As SqlClient.SqlDataAdapter

    Dim Tables() As String = {"PriceGroup", "PriceNacenki", "PriceName", "PriceParam1", "PriceParam2", "PriceCost"}

    Private Sub Gen_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Dim intCurrSQL As Integer
        'Dim oNames As SQLDMO.NameList
        'Dim oSQLApp As New SQLDMO.Application

        'oNames = oSQLApp.ListAvailableSQLServers

        'If oNames.Count = 0 Then
        '    ' Me.lstSQLServers.Items.Add("(local)\SQLEXPRESS")
        'End If

        'For intCurrSQL = 1 To oNames.Count
        '    ' Me.lstSQLServers.Items.Add(oNames.Item(intCurrSQL))
        'Next

        strPath = Application.StartupPath

        'Dim db As Object
        'Dim osvr As SQLDMO.SQLServer

        'osvr = New SQLDMO.SQLServer
        'osvr.LoginSecure = True
        'Try
        '    osvr.Connect("(local)\SQLEXPRESS")
        '    'osvr.Connect(Me.lstSQLServers.SelectedItem & "\SQLEXPRESS")
        'Catch excp As Exception
        '    MessageBox.Show(excp.Message)
        '    Exit Sub
        'End Try

        'Me.cmbDataBases.Items.Clear() '�������� ������� ������

        'For Each db In osvr.Databases '�������� ���� ��� ������, ������������ � ���������� �������
        '    Me.cmbDataBases.Items.Add(db.Name)
        'Next

        Dim odaMarket1 As New SqlClient.SqlDataAdapter("SELECT ID, name FROM Services WHERE active = 1 order by name ", mcnnInt)
        Dim dtMarket1 As New DataTable : odaMarket1.Fill(dtMarket1)

        Me.cmbService.DataSource = dtMarket1
        Me.cmbService.DisplayMember = "Name"
        Me.cmbService.ValueMember = "ID"
    End Sub

    Private Sub btnStart_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStart.Click
        'Dim j As Integer
        '   Dim dsDataFromDB As DataSet
        '   Dim odaStart As SqlClient.SqlDataAdapter

        ' strConnection = "Data Source=(local)\SQLEXPRESS; Integrated Security=SSPI; Initial Catalog='" & Trim(Me.cmbDataBases.Text) & "';"
        ' mcnnInt.ConnectionString = strConnection

        ' If Me.cmbDataBases.Text = "" Then MsgBox("�� ������� ���� ������") : Exit Sub
        ' If Me.cmbDataBases.SelectedIndex = -1 Then MsgBox("�� ������� ���� ������") : Exit Sub
        Dim servID As Integer = Me.cmbService.SelectedItem(0)

        Select Case Me.cmbLocation.SelectedIndex
            Case Is = 0 '����������� ����
                Select Case MsgBox(Prompt:="�������� ������ �� ���� ��������?", Buttons:=vbYesNo, Title:="TransData")
                    Case Is = vbYes
                        mdsPrice = New DataSet

                        mcnnInt.Open()

                        modaPrice = New SqlClient.SqlDataAdapter("SELECT * FROM PriceGroup WHERE serviceID = " & servID & "", mcnnInt)
                        modaPrice.Fill(mdsPrice, "PriceGroup")
                        modaPrice = New SqlClient.SqlDataAdapter("SELECT * FROM PriceNacenki WHERE groupID IN (SELECT ID FROM PriceGroup WHERE serviceID = " & servID & ")", mcnnInt)
                        modaPrice.Fill(mdsPrice, "PriceNacenki")
                        modaPrice = New SqlClient.SqlDataAdapter("SELECT * FROM PriceName WHERE groupID IN (SELECT ID FROM PriceGroup WHERE serviceID = " & servID & ")", mcnnInt)
                        modaPrice.Fill(mdsPrice, "PriceName")
                        modaPrice = New SqlClient.SqlDataAdapter("SELECT * FROM PriceParam1 WHERE groupID IN (SELECT ID FROM PriceGroup WHERE serviceID = " & servID & ")", mcnnInt)
                        modaPrice.Fill(mdsPrice, "PriceParam1")
                        modaPrice = New SqlClient.SqlDataAdapter("SELECT * FROM PriceCost WHERE param1ID IN (SELECT ID FROM PriceParam1 WHERE groupID IN (SELECT ID FROM PriceGroup WHERE serviceID = " & servID & ")) AND priceNameID IN (SELECT ID FROM PriceName WHERE groupID IN (SELECT ID FROM PriceGroup WHERE serviceID = " & servID & ")) AND param2ID IN (SELECT ID FROM PriceParam2 WHERE serviceID = " & servID & ")", mcnnInt)
                        modaPrice.Fill(mdsPrice, "PriceCost")
                        modaPrice = New SqlClient.SqlDataAdapter("SELECT * FROM PriceParam2 WHERE serviceID = " & servID & "", mcnnInt)
                        modaPrice.Fill(mdsPrice, "PriceParam2")

                        '    mdsPrice.WriteXml(strPath + "\" & "PriceGroup") & ".xml", XmlWriteMode.WriteSchema)
                        'If File.Exists(strPath + "\Priceconfig.ini") Then
                        '    File.Delete(strPath + "\Priceconfig.ini")
                        'End If
                        'File.Copy(Me.OpenFileDialog1.FileName, strPath + "\Priceconfig.ini")

                        For Each dt As DataTable In mdsPrice.Tables  '�������� ���� ��� ������, ������������ � ���������� �������
                            dt.WriteXml(strPath + "\" & dt.TableName & ".xml", XmlWriteMode.WriteSchema)
                        Next



                        'For j = 0 To UBound(Tables) '��������� ������� � ������� XML
                        '    dsDataFromDB = New DataSet()
                        '    Try
                        '        odaStart = New SqlClient.SqlDataAdapter("SELECT * FROM " & Tables(j) & " WHERE ", mcnnInt)
                        '        odaStart.Fill(dsDataFromDB)
                        '        dsDataFromDB.WriteXml(strPath + "\" & CStr(Tables(j)) & ".xml", XmlWriteMode.WriteSchema)
                        '    Catch exData As System.Exception
                        '        MsgBox(exData.Message, MsgBoxStyle.Critical, appName) : Exit Sub
                        '    End Try
                        'Next

                        mcnnInt.Close()

                        MsgBox("�������� �������.", MsgBoxStyle.Information, appName)
                    Case Is = vbNo
                        Exit Sub
                End Select

            Case Is = 1 '������
                Select Case MsgBox(Prompt:="�� �������, ��� ���������� � ���������� � ������ �������� ������� ���� ������? ", Buttons:=vbYesNo, Title:=appName)
                    Case Is = vbYes
                        UpdateClassica() '��������� �������
                    Case Is = vbNo
                        Exit Sub
                End Select

                'Select Case MsgBox(Prompt:="��������� �������� �����-����? ", Buttons:=vbYesNo, Title:="TransData")
                '    Case Is = vbYes
                '        If File.Exists(Me.SaveFileDialog1.FileName) Then
                '            File.Delete(Me.SaveFileDialog1.FileName)
                '        End If
                '        File.Copy(strPath + "\Priceconfig.ini", Me.SaveFileDialog1.FileName)
                '        MsgBox("����-����� ��������.")
                '    Case Is = vbNo
                '        Me.Close()
                'End Select
        End Select
    End Sub

    Private Sub UpdateClassica()
        Dim i As Integer
        Dim ds As New DataSet
        Dim strSQL$

        Try
            For i = 0 To UBound(Tables)

                ds.ReadXml(strPath + "\" & Tables(i) & ".xml", XmlReadMode.ReadSchema)

                Dim row As DataRow
                Dim col As DataColumn
                Dim colStr As String = Nothing

                For Each col In ds.Tables(Tables(i)).Columns
                    If colStr <> Nothing Then
                        colStr += ", " + col.ColumnName
                    Else
                        'If col.ColumnName <> "ID" Then
                        colStr = col.ColumnName
                        'End If
                    End If
                Next

                Dim dataStr As String

                For Each row In ds.Tables(Tables(i)).Rows
                    strSQL = "INSERT INTO " + Tables(i) + " (" + colStr + ") VALUES ("
                    dataStr = Nothing

                    For Each col In ds.Tables(Tables(i)).Columns
                        If dataStr <> Nothing Then

                            'Select col.ColumnName
                            '    Case Is = "serviceID" : dataStr += ", " + Me.cmbService.SelectedItem(0).ToString
                            '        '        'Case Is = "groupID"
                            '        '        'Case Is = "priceNameID"
                            '        '        'Case Is = "param1ID"
                            '        '        'Case Is = "param2ID"
                            '    Case Else
                            dataStr += ", '" + Replace(row(col.ColumnName).ToString, ",", ".") + "'"
                            'End Select


                            'If col.ColumnName = "serviceID" Then
                            '    dataStr += ", " + Me.cmbService.SelectedItem(0).ToString
                            'Else
                            '    dataStr += ", '" + row(col.ColumnName).ToString + "'"
                            'End If
                        Else
                            'If col.ColumnName <> "ID" Then
                            dataStr = "'" + Replace(row(col.ColumnName).ToString, ",", ".") + "'"
                            'End If
                        End If
                    Next

                    strSQL += dataStr + ")"

                    Module1.NonQuery1(strSQL)
                    '��� ��� ��� ����� ���������� ������� ������, ���� ������ ������� � ���������� � ��� �����
                    '� ����������� ������ ������� �� ���� ���� ��� � XML???

                Next
            Next

            MsgBox("������� ��������.", MsgBoxStyle.Information, appName)
            Me.Close()
        Catch excp As System.Exception
            '   MsgBox(strSQL)
            MessageBox.Show(excp.Message, appName)
            Exit Sub
        End Try
    End Sub

    Private Sub cmbDataBases_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbService.SelectedIndexChanged
        'Select Case Me.cmbLocation.SelectedIndex
        '    Case Is = 0 '����������� ����           
        '        MsgBox("����� ��������� ���� �����-����.", MsgBoxStyle.Critical, appName)
        '        Me.grpFindFilePrice.Enabled = True
        '        Me.grpRefreshFilePrice.Enabled = False
        '        FindFilePrice()
        '    Case Is = 1 '������
        '        MsgBox("����� ���� �����-����� ���������� ������.", MsgBoxStyle.Critical, appName)
        '        Me.grpFindFilePrice.Enabled = False
        '        Me.grpRefreshFilePrice.Enabled = True
        '        SaveFilePrice()
        'End Select
    End Sub

    Private Sub btnFindFile_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFindFile.Click
        FindFilePrice()
    End Sub

    Private Sub FindFilePrice()
        With OpenFileDialog1
            .InitialDirectory = "c:\"
            .Filter = "��������� ���� (Priceconfig.ini)|*.ini"
            .ShowDialog()
            Me.txtFile.Text = .FileName
        End With
        Me.btnStart.BackColor = Color.Lime
    End Sub

    Private Sub btnFileSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFileSave.Click
        SaveFilePrice()
    End Sub

    Private Sub SaveFilePrice()
        With SaveFileDialog1
            .InitialDirectory = "c:\"
            .Filter = "�����-����|*.ini"
            .ShowDialog()
            Me.txtSaveFile.Text = .FileName
        End With

        Me.btnStart.BackColor = Color.Lime
    End Sub

    Private Sub cmbLocation_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbLocation.SelectedIndexChanged

    End Sub
End Class
