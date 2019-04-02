Imports System.Data.SqlClient
Imports System.IO
Imports System.ServiceProcess

Public Class frmDocOut
    Dim allowLoadOffering As Boolean = False
    Dim itogDoc As Double
    Dim strKop$ = Nothing '������� � ���� ������
    Dim Summa$ = ""
    Public CostOrganization As Integer = -1

#Region " �������� ����� "
    Private Sub frmDocOut_Activated(sender As Object, e As System.EventArgs) Handles Me.Activated
        Try
            FillDSOffering(Me.dgAllInvoices("invoiceID", Me.dgAllInvoices.CurrentRow.Index).Value())
        Catch ex As System.Exception
        End Try

        Me.HelpProvider1.SetHelpString(Me, "������� �� ������ ���������")
    End Sub

    Private Sub DocOut_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.cmsAddDelPos.Enabled = Not neRedDoc
        Me.cmsAllInvoices.Enabled = Not neRedDoc
        Me.tsbtnNewCost.Enabled = Not neRedDoc
        Me.tsbtnCreateNaOsn.Enabled = Not neRedDoc

        LoadOrganisation()

        If (costOrganization <> -1) Then
            cmbGruzPol.SelectedValue = costOrganization
            cmbOrganization.SelectedValue = costOrganization
        End If

        '��������� ������ ��������� ����������� �������
        Try
            Dim odaAddr As New SqlClient.SqlDataAdapter("SELECT custID, Name FROM Organizations WHERE closed=0 AND KAgent_ID=(SELECT ID FROM KAgents WHERE type_ID=1) ORDER BY Name", mcnnInt)
            Dim dtAddr As New DataTable : odaAddr.Fill(dtAddr)

            Me.cmbAddressee.DataSource = dtAddr    '������� ������ �� �������
            Me.cmbAddressee.DisplayMember = "Name"
            Me.cmbAddressee.ValueMember = "custID"

            Me.cmbAddressee.SelectedValue = Module1.NonQuery1Scalar("SELECT orgID FROM Costs WHERE costID=" & costID & "")

            Dim odaDoc As New SqlClient.SqlDataAdapter("SELECT ID, name FROM TypesDocument WHERE active=1 AND TZ <> 1 order by name", mcnnInt)
            Dim dtDoc As New DataTable : odaDoc.Fill(dtDoc)

            Me.clbDocTypes.DataSource = dtDoc
            Me.clbDocTypes.DisplayMember = "name"
            Me.clbDocTypes.ValueMember = "ID"
        Catch ex As System.Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, appName)
        End Try

        AllInvoices()

        LoadHistory()

        '����
        allowLoadOffering = True
    End Sub

    Private Sub LoadHistory()
        Dim cmd As New SqlClient.SqlCommand

        cmd.Connection = mcnnInt
        cmd.CommandText = "sp_LoadHistory"
        cmd.CommandType = CommandType.StoredProcedure

        '��������� ���������
        cmd.Parameters.Add(New SqlClient.SqlParameter("@costId", SqlDbType.Int))
        cmd.Parameters("@costId").Value = costID

        Dim dataAdapter As New SqlClient.SqlDataAdapter(cmd)
        Dim dataTable As New DataTable
        dataAdapter.Fill(dataTable)

        Me.dgHistory.DataSource = dataTable
    End Sub

    Private Sub LoadOrganisation()
        Try
            Dim odaPartList As New SqlClient.SqlDataAdapter("SELECT custID, Name FROM Organizations WHERE closed=0 AND KAgent_ID=" & custID & " ORDER BY Name", mcnnInt)
            Dim dtPartList As New DataTable : odaPartList.Fill(dtPartList)

            Me.cmbOrganization.DataSource = dtPartList
            Me.cmbOrganization.DisplayMember = "Name"
            Me.cmbOrganization.ValueMember = "custID"

            Dim odaGruzPol As New SqlClient.SqlDataAdapter("SELECT custID, Name FROM Organizations WHERE closed=0 AND KAgent_ID=" & custID & " ORDER BY Name", mcnnInt)
            Dim dtGruzPol As New DataTable : odaGruzPol.Fill(dtGruzPol)

            Me.cmbGruzPol.DataSource = dtGruzPol    '������� ������ �� �������
            Me.cmbGruzPol.DisplayMember = "Name"
            Me.cmbGruzPol.ValueMember = "custID"
        Catch oexpData As System.Exception
            MsgBox(oexpData.Message, MsgBoxStyle.Critical, appName)
        End Try
    End Sub
#End Region

#Region " ��� ���������� �� ��� "
    Private Sub AllInvoices()
        Dim cmd As New SqlClient.SqlCommand

        cmd.Connection = mcnnInt
        cmd.CommandText = "sp_DocAllInvoices"
        cmd.CommandType = CommandType.StoredProcedure

        '��������� ���������
        cmd.Parameters.Add(New SqlClient.SqlParameter("@costID", SqlDbType.Int))
        cmd.Parameters("@costID").Value = costID

        Dim objDA As New SqlClient.SqlDataAdapter(cmd)
        Dim dtInvoices As New DataTable : objDA.Fill(dtInvoices)

        Me.dgAllInvoices.DataSource = dtInvoices

        ColHideDG(dgAllInvoices)
    End Sub

    Private Sub AllInvoicesWOorder(strDocTypes As String)
        Dim cmd As New SqlClient.SqlCommand

        cmd.Connection = mcnnInt
        cmd.CommandText = "sp_DocAllInvoicesWOorder"
        cmd.CommandType = CommandType.StoredProcedure

        '��������� ���������
        cmd.Parameters.Add(New SqlClient.SqlParameter("@date1", SqlDbType.Date))
        cmd.Parameters("@date1").Value = Me.dtpDocOut.Value.Date

        cmd.Parameters.Add(New SqlClient.SqlParameter("@date2", SqlDbType.Date))
        cmd.Parameters("@date2").Value = Me.dtpDate2.Value.Date

        cmd.Parameters.Add(New SqlClient.SqlParameter("@adrID", SqlDbType.Int))
        cmd.Parameters("@adrID").Value = Me.cmbAddressee.SelectedItem(0)

        cmd.Parameters.Add(New SqlClient.SqlParameter("@strDocTypes", SqlDbType.NText))
        cmd.Parameters("@strDocTypes").Value = strDocTypes

        Dim objDA As New SqlClient.SqlDataAdapter(cmd)
        Dim dtInvoices As New DataTable : objDA.Fill(dtInvoices)

        Me.dgAllInvoices.DataSource = dtInvoices

        ColHideDG(dgAllInvoices)
    End Sub
#End Region

#Region " ��������� ������ ��������� "
    Public Sub FillDSOffering(ByVal invoiceID As Integer)

        Dim cmd As New SqlClient.SqlCommand

        cmd.Connection = mcnnInt
        cmd.CommandText = "sp_Doc_FillOffering"
        cmd.CommandType = CommandType.StoredProcedure

        '��������� ���������
        cmd.Parameters.Add(New SqlClient.SqlParameter("@invoiceID", SqlDbType.Int))
        cmd.Parameters("@invoiceID").Value = invoiceID

        Dim objDA As New SqlClient.SqlDataAdapter(cmd)
        Dim dtOfert As New DataTable : objDA.Fill(dtOfert)

        If Me.dgAllInvoices.Rows.Count > 0 Then
            Try
                itogDoc = 0

                If dtOfert.Rows.Count > 0 Then
                    itogDoc = dtOfert.Compute("SUM(�����)", "")

                    Me.ToolStripStatusLabel1.Text = "����� � ��������� " & dtOfert.Rows.Count.ToString & " �������, �� �����: " & Format(itogDoc, "C")
                    Me.ToolStripStatusLabel1.Visible = True
                Else
                    Me.ToolStripStatusLabel1.Visible = False
                End If

                Me.dgDoc.DataSource = dtOfert
                Me.dgDoc.Columns("offeringID").Visible = False
            Catch oexpData As System.SystemException
                MessageBox.Show("Error loading individual data:  offering -" & oexpData.Message, appName)
                Exit Sub
            End Try
        End If
    End Sub
#End Region

#Region " ������� ����� �������� "
    Private Sub NewDoc(sel As Integer, docTypeID As Integer)
        Dim strSQL As String
        Dim nomDoc, descriptionDoc As String

        Try
            Dim count As Integer = Module1.NonQueryScalarInt("SELECT COUNT(*) FROM Invoices WHERE costID=" & costID & " AND typeDoc=" & docTypeID & "")
            if (count > 0) Then
                Dim docTypeName As String = Module1.NonQuery1ScalarString("SELECT name FROM TypesDocument WHERE ID=" & docTypeID & "")
                If (Not CanAddDocumentOfSameType) Then
                    MessageBox.Show(Me, "��� ������ ��� ������ �������� " & docTypeName)
                    Exit Sub
                End If
                Dim result As DialogResult = MessageBox.Show(Me, "��� ������ ��� ������ �������� " & docTypeName & ". ������� ��� ����?", appName, MessageBoxButtons.YesNo)
                If (result = DialogResult.No) Then
                    Exit Sub
                End If
            End If

            Select Case sel
                Case Is = 1 '������� �������� "� ����", � �� �� ��������� ������� ���������
                    Me.txtKA_find.Visible = False : Me.cmb_KA.Visible = False

                    '***** ���� �������� ����� �� ������

                    If Module1.NonQuery1Scalar("SELECT count(*) FROM Invoices WHERE costID=" & costID & " AND typeDoc=" & docTypeID & "") >= 1 Then
                        nomDoc = nomVn + "/" + Module1.NonQuery1ScalarString("SELECT count(*) FROM Invoices WHERE costID=" & costID & " AND typeDoc=" & docTypeID & "")
                    Else
                        nomDoc = nomVn
                    End If

                    If autoAccount = True Then    '���� �������������� ����� ��������
                        Dim cmd As New SqlClient.SqlCommand

                        Try
                            cmd.Connection = mcnnInt
                            cmd.CommandText = "sp_AutoCompletOffert"
                            cmd.CommandType = CommandType.StoredProcedure
                            '��������� ���������
                            cmd.Parameters.Add(New SqlClient.SqlParameter("@costID", SqlDbType.Int))
                            cmd.Parameters("@costID").Value = costID
                            cmd.Parameters.Add(New SqlClient.SqlParameter("@typeDocID", SqlDbType.Int))
                            cmd.Parameters("@typeDocID").Value = docTypeID
                            cmd.Parameters.Add(New SqlClient.SqlParameter("@numDoc", SqlDbType.NVarChar))
                            cmd.Parameters("@numDoc").Value = nomDoc

                            '��� ���
                            If Me.cmbOrganization.SelectedIndex <> -1 Then
                                cmd.Parameters.Add(New SqlClient.SqlParameter("@orgID", SqlDbType.Int))
                                cmd.Parameters("@orgID").Value = Me.cmbOrganization.SelectedItem(0)

                                cmd.Parameters.Add(New SqlClient.SqlParameter("@gruzPolID", SqlDbType.Int))
                                cmd.Parameters("@gruzPolID").Value = Me.cmbGruzPol.SelectedItem(0)
                            Else
                                cmd.Parameters.Add(New SqlClient.SqlParameter("@orgID", SqlDbType.Int))
                                cmd.Parameters("@orgID").Value = 15892

                                cmd.Parameters.Add(New SqlClient.SqlParameter("@gruzPolID", SqlDbType.Int))
                                cmd.Parameters("@gruzPolID").Value = 15892
                            End If

                            cmd.Parameters.Add(New SqlClient.SqlParameter("@adresseeID", SqlDbType.Int))
                            cmd.Parameters("@adresseeID").Value = Me.cmbAddressee.SelectedItem(0)
                            cmd.Parameters.Add(New SqlClient.SqlParameter("@emplID", SqlDbType.Int))
                            cmd.Parameters("@emplID").Value = emplID
                            cmd.Parameters.Add(New SqlClient.SqlParameter("@dateDoc", SqlDbType.Date))
                            cmd.Parameters("@dateDoc").Value = Format(Me.dtpDocOut.Value.Date, "s") 'Format(Now().Date, "s")

                            mcnnInt.Open()
                            cmd.ExecuteNonQuery()

                            Dim cmd2 As New SqlClient.SqlCommand
                            cmd2.Connection = mcnnInt
                            cmd2.CommandText = "sp_addCreateDocumentHistory"
                            cmd2.CommandType = CommandType.StoredProcedure
                            cmd2.ExecuteNonQuery()
                        Catch excp As System.Exception
                            MessageBox.Show(excp.Message)
                            Exit Sub
                        Finally
                            mcnnInt.Close()
                        End Try
                    Else
                        If Me.cmbOrganization.SelectedIndex <> -1 Then
                            strSQL = "INSERT INTO Invoices (data,typeDoc,numberDoc,custID, costID,adrID,emplID,gruzPolID,grounds)"
                            strSQL &= " VALUES (CAST('" & Format(Me.dtpDocOut.Value.Date, "s") & "' AS date), " & docTypeID & ",'" & nomDoc & "',"
                            strSQL &= "" & Me.cmbOrganization.SelectedItem(0) & "," & costID & "," & Me.cmbAddressee.SelectedItem(0) & "," & emplID & "," & Me.cmbGruzPol.SelectedItem(0) & ",'" & Me.txtGrounds.Text & "')"
                        Else ' �������� �� �� �� ���� ��� ���� ���???
                            strSQL = "INSERT INTO Invoices (data,typeDoc,numberDoc,custID,costID,adrID,emplID)"
                            strSQL &= " VALUES (CAST('" & Format(Me.dtpDocOut.Value.Date, "s") & "' AS date)," & docTypeID & ",'" & nomDoc & "',"
                            strSQL &= "15892," & costID & "," & Me.cmbAddressee.SelectedItem(0) & "," & emplID & " )"
                        End If

                        Module1.NonQuery1(strSQL)

                        Try
                            Dim cmd As New SqlClient.SqlCommand
                            cmd.Connection = mcnnInt
                            cmd.CommandText = "sp_addCreateDocumentHistory"
                            cmd.CommandType = CommandType.StoredProcedure
                            mcnnInt.Open()
                            cmd.ExecuteNonQuery()
                        Finally
                            mcnnInt.Close()
                        End Try
                    End If

                    FillDSOffering(currentInvoice)

                    AllInvoices()

                    Me.dgDoc.ClearSelection()

                Case Is = 2 '������� �������� �� ��������� ������� ���������
                    Me.txtKA_find.Visible = False : Me.cmb_KA.Visible = False

                    '***** ���� �������� ����� �� ������
                    If Module1.NonQuery1Scalar("SELECT count(*) FROM Invoices WHERE costID=" & costID & " AND typeDoc=" & docTypeID & "") >= 1 Then
                        nomDoc = nomVn + "/" + Module1.NonQuery1ScalarString("SELECT count(*) FROM Invoices WHERE costID=" & costID & " AND typeDoc=" & docTypeID & "")
                    Else
                        nomDoc = nomVn
                    End If

                    Dim cmd As New SqlClient.SqlCommand

                    Try
                        cmd.Connection = mcnnInt
                        cmd.CommandText = "sp_DocCrNaOsn"
                        cmd.CommandType = CommandType.StoredProcedure
                        '��������� ���������
                        cmd.Parameters.Add(New SqlClient.SqlParameter("@dateDoc", SqlDbType.Date))
                        cmd.Parameters("@dateDoc").Value = Format(Me.dtpDocOut.Value.Date, "s") 'Format(Now().Date, "s")
                        cmd.Parameters.Add(New SqlClient.SqlParameter("@costID", SqlDbType.Int))
                        cmd.Parameters("@costID").Value = costID
                        cmd.Parameters.Add(New SqlClient.SqlParameter("@typeDocID", SqlDbType.Int))
                        cmd.Parameters("@typeDocID").Value = docTypeID
                        cmd.Parameters.Add(New SqlClient.SqlParameter("@numDoc", SqlDbType.NVarChar))
                        cmd.Parameters("@numDoc").Value = nomDoc
                        cmd.Parameters.Add(New SqlClient.SqlParameter("@orgID", SqlDbType.Int))
                        cmd.Parameters("@orgID").Value = Me.cmbOrganization.SelectedItem(0)
                        cmd.Parameters.Add(New SqlClient.SqlParameter("@adresseeID", SqlDbType.Int))
                        cmd.Parameters("@adresseeID").Value = Me.cmbAddressee.SelectedItem(0)
                        cmd.Parameters.Add(New SqlClient.SqlParameter("@emplID", SqlDbType.Int))
                        cmd.Parameters("@emplID").Value = emplID
                        cmd.Parameters.Add(New SqlClient.SqlParameter("@invoiceID", SqlDbType.Int))
                        cmd.Parameters("@invoiceID").Value = Me.dgAllInvoices("invoiceID", Me.dgAllInvoices.CurrentRow.Index).Value()

                        cmd.Parameters.Add(New SqlClient.SqlParameter("@gruzPolID", SqlDbType.Int))
                        cmd.Parameters("@gruzPolID").Value = Me.cmbGruzPol.SelectedItem(0)
                        cmd.Parameters.Add(New SqlClient.SqlParameter("@grounds", SqlDbType.NVarChar))
                        cmd.Parameters("@grounds").Value = Me.txtGrounds.Text

                        mcnnInt.Open()

                        cmd.ExecuteNonQuery()
                        Dim cmd2 As New SqlClient.SqlCommand
                        cmd2.Connection = mcnnInt
                        cmd2.CommandText = "sp_addCreateDocumentHistory"
                        cmd2.CommandType = CommandType.StoredProcedure
                        cmd2.ExecuteNonQuery()

                        mcnnInt.Close()

                        AllInvoices()
                        FillDSOffering(currentInvoice)

                    Catch excp As System.Exception
                        MessageBox.Show(excp.Message, appName)
                        MessageBox.Show("�� ������ ��������-���������.", appName)
                        Exit Sub
                    End Try

                Case Is = 3 '������� �������� ��� ������ 
                    If Me.cmb_KA.SelectedIndex = -1 Then
                        MsgBox("������ �����������", MsgBoxStyle.Information, appName)
                        Me.txtKA_find.Focus() : Exit Sub
                    End If

                    Dim myValue As Object
                    myValue = InputBox("����� ����� ���������", appName, "")
                    If myValue Is "" Then
                        Exit Sub
                    Else
                        nomDoc = myValue
                    End If

                    Dim myValue1 As Object

                    myValue1 = InputBox("����� �������� ����������", appName, "")

                    If myValue1 Is "" Then
                        Exit Sub
                    Else
                        descriptionDoc = myValue1
                    End If

                    strSQL = "INSERT INTO Invoices (data,typeDoc,numberDoc,adrID,KA_ID,emplID,description,gruzPolID,grounds)"
                    strSQL &= " VALUES (CAST('" & Format(Me.dtpDocOut.Value.Date, "s") & "' AS date)," & docTypeID & ",'" & nomDoc & "',"
                    strSQL &= "" & Me.cmbAddressee.SelectedItem(0) & "," & Me.cmb_KA.SelectedItem(0) & "," & emplID & ",'" & descriptionDoc & "'," & Me.cmbGruzPol.SelectedItem(0) & ",'" & Me.txtGrounds.Text & "')"

                    Module1.NonQuery1(strSQL)

                    DocWOorder()
            End Select

        Catch ex As System.Exception
            MessageBox.Show(ex.Message, appName)
            MessageBox.Show("�������� �������� ��� ����������.", appName)
        End Try
    End Sub

    Private Sub tsbtnNewCost_Click_1(sender As Object, e As EventArgs) Handles tsbtnNewCost.Click
        If Me.cmbAddressee.SelectedIndex = -1 Then
            MsgBox("������ ����������� - ����������", MsgBoxStyle.Information, appName)
            Me.cmbAddressee.Focus()
        Else
            Dim itemChecked As Object

            For Each itemChecked In Me.clbDocTypes.CheckedItems
                NewDoc(1, itemChecked.item(0))
            Next
        End If
    End Sub
#End Region

    Private Sub DocWOorder()
        Dim cmd As New SqlClient.SqlCommand

        cmd.Connection = mcnnInt
        cmd.CommandText = "sp_DocWOorder"
        cmd.CommandType = CommandType.StoredProcedure

        '��������� ���������
        cmd.Parameters.Add(New SqlClient.SqlParameter("@date1", SqlDbType.Date))
        cmd.Parameters("@date1").Value = Me.dtpDocOut.Value.Date

        cmd.Parameters.Add(New SqlClient.SqlParameter("@date2", SqlDbType.Date))
        cmd.Parameters("@date2").Value = Me.dtpDate2.Value.Date

        cmd.Parameters.Add(New SqlClient.SqlParameter("@KAID", SqlDbType.Int))
        cmd.Parameters("@KAID").Value = costID

        Dim objDA As New SqlClient.SqlDataAdapter(cmd)
        Dim dtInvoices As New DataTable : objDA.Fill(dtInvoices)

        Me.dgAllInvoices.DataSource = dtInvoices

        ColHideDG(dgAllInvoices)
    End Sub


#Region " ������� ������� �� ����� "
    Private Sub DelFromInvoce()
        If Me.dgDoc.SelectedRows.Count = 0 Then
            MsgBox("�� ������� �������", MsgBoxStyle.Information, appName) : Exit Sub
        End If

        Dim strSQL$ = Nothing

        Try
            strSQL = "DELETE FROM Offering WHERE offeringID = " & Me.dgDoc("offeringID", Me.dgDoc.SelectedRows.Item(0).Index).Value & ""

            Select Case MsgBox(Prompt:="������� ������ " & Me.dgDoc("������������", Me.dgDoc.SelectedRows.Item(0).Index).Value.ToString & "?", Buttons:=vbYesNo, Title:=appName)
                Case Is = vbYes
                    Module1.NonQuery1(strSQL)

                    AddChangeHistoryNote()

                    currentInvoice = Me.dgAllInvoices("invoiceID", Me.dgAllInvoices.CurrentRow.Index).Value()

                    FillDSOffering(currentInvoice)
                Case Is = vbNo
                    Exit Sub
            End Select
        Catch ex As System.Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub �������ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles �������ToolStripMenuItem.Click
        DelFromInvoce()
    End Sub
#End Region

#Region " ����������� �� ���������� "
    Private Sub dgAllInvoices_CurrentCellChanged(sender As Object, e As System.EventArgs) Handles dgAllInvoices.CurrentCellChanged
        If allowLoadOffering = True Then
            Try
                currentInvoice = Me.dgAllInvoices("invoiceID", Me.dgAllInvoices.CurrentRow.Index).Value()

                If Me.dgAllInvoices("��", Me.dgAllInvoices.CurrentRow.Index).Value() = 1 Then
                    If emplID = 3 Or emplID = 1096 Then '1096
                        Me.cmsAddDelPos.Enabled = True
                        Me.�������������������ToolStripMenuItem.Enabled = True
                        Me.tsDelDoc.Enabled = True
                        Me.���������������������������ToolStripMenuItem.Enabled = True
                    Else
                        Me.cmsAddDelPos.Enabled = Me.dgAllInvoices("��", Me.dgAllInvoices.CurrentRow.Index).Value()
                        Me.�������������������ToolStripMenuItem.Enabled = Me.dgAllInvoices("��", Me.dgAllInvoices.CurrentRow.Index).Value()
                        Me.tsDelDoc.Enabled = Me.dgAllInvoices("��", Me.dgAllInvoices.CurrentRow.Index).Value()
                        Me.���������������������������ToolStripMenuItem.Enabled = Me.dgAllInvoices("��", Me.dgAllInvoices.CurrentRow.Index).Value()
                    End If
                Else
                    Me.cmsAddDelPos.Enabled = True
                    Me.�������������������ToolStripMenuItem.Enabled = True
                    Me.tsDelDoc.Enabled = True
                    Me.���������������������������ToolStripMenuItem.Enabled = True
                End If

                FillDSOffering(currentInvoice)
            Catch ex As System.Exception

            End Try
        End If
    End Sub
#End Region

#Region " ������ ��������� "
    Private Sub PrintDoc()
        Try
            If Me.dgAllInvoices.SelectedRows.Count = 0 Then
                MsgBox("�� ������ ��������.", MsgBoxStyle.Information, appName) : Exit Sub
            End If

            '��������� ��� ����� ������ � ���� � ������ ��������
       
            Dim dsSchet As New DataSet 'Schet
            Dim modaSchet As New SqlClient.SqlDataAdapter("SELECT * FROM Organizations WHERE custID=(SELECT adrID FROM Invoices WHERE invoiceID=" & currentInvoice & ")", mcnnInt)
            Dim dtAddressee As New DataTable : modaSchet.Fill(dsSchet, "Adresee")

            If Me.cmbOrganization.SelectedIndex = -1 Then
                modaSchet = New SqlClient.SqlDataAdapter("SELECT * FROM Organizations WHERE custID=15892", mcnnInt)
                modaSchet.Fill(dsSchet, "Customers")

                '  modaSchet = New SqlClient.SqlDataAdapter("SELECT * FROM Organizations WHERE custID=194", mcnnInt)
                modaSchet.Fill(dsSchet, "GruzPol")
            Else
                modaSchet = New SqlClient.SqlDataAdapter("SELECT * FROM Organizations WHERE custID=(select custID from Invoices where invoiceID=" & currentInvoice & ")", mcnnInt)
                modaSchet.Fill(dsSchet, "Customers")

                modaSchet = New SqlClient.SqlDataAdapter("SELECT * FROM Organizations WHERE custID=(select gruzPolID from Invoices where invoiceID=" & currentInvoice & ")", mcnnInt)
                modaSchet.Fill(dsSchet, "GruzPol")
            End If

            modaSchet = New SqlClient.SqlDataAdapter("SELECT * FROM Units", mcnnInt)
            modaSchet.Fill(dsSchet, "Units")

            modaSchet = New SqlClient.SqlDataAdapter("SELECT invoiceID, COALESCE(costID, '���') as costID,data,custID,date_PayDoc,numberPayDoc,numberDoc,(SELECT emplLastName FROM Employees WHERE emplID=(SELECT emplID FROM Costs WHERE costID=" & costID & ")) as manager,(SELECT emplTel FROM Employees WHERE emplID=(SELECT emplID FROM Costs WHERE costID=" & costID & ")) as telman,coalesce((SELECT skidka FROM Costs WHERE costID= " & costID & "), 0) as skidka, grounds FROM Invoices WHERE invoiceID=" & currentInvoice & "", mcnnInt)
            modaSchet.Fill(dsSchet, "Invoices")

            modaSchet = New SqlClient.SqlDataAdapter("SELECT * FROM Offering WHERE invoiceID=" & currentInvoice & " ", mcnnInt)
            modaSchet.Fill(dsSchet, "Offering")

            if (Not cmbAddressee.SelectedIndex = -1) Then
                modaSchet = New SqlDataAdapter("SELECT * FROM Organizations WHERE custID=" & cmbAddressee.SelectedValue & "", mcnnInt)
                modaSchet.Fill(dsSchet, "Company")
            End If

            Dim strFileName1 As String = paramLocalTempPath & "DSPerfectCRM.xml"
            Dim rrr1 As New FileInfo(strFileName1)

            rrr1.Delete()   ' ������� ���� ���������� ����
            dsSchet.WriteXml(strFileName1, XmlWriteMode.WriteSchema)

            '��������� ���������� � �����
            currentDocNum = CStr(dgAllInvoices("�����", dgAllInvoices.CurrentRow.Index).Value()) '���������� ����� ���������
            '������� � ���� ������
            strKop = CStr(Format(itogDoc, "0.00")).Substring(CStr(Format(itogDoc, "0.00")).Length - 2)

            countNaim = dgDoc.Rows.Count '���������� ������������
            '����� ��������� �������� + ������ ����� ������ ���������
            SumProp.SummaString(Summa$, Fix(itogDoc), 1, " �����", " �����", " ������")

            strSum = UCase(GetChar(Summa, 1)) & Mid(Summa, 2) & " " & strKop & " ���."

            '���������� ������������ �������� + ������ ����� ������ ���������
            SumProp.SummaString(Summa$, Me.dgDoc.RowCount, 1, "", "", "")
            strCountNaim$ = UCase(GetChar(Summa, 1)) & Mid(Summa, 2) & " " & strKop & ""

            vse = "" ' ��� ������� � ���� ������

            Dim n%
            Dim mdrOfferta As Object

            For Each mdrOfferta In dgDoc.Rows
                If n = 0 Then
                    vse = dgDoc("������������", n).Value.ToString   'mdrOfferta("������������").ToString
                Else
                    vse += ", " & dgDoc("������������", n).Value.ToString 'mdrOfferta("������������").ToString
                End If
                n += 1
            Next

            '***���������� ��� ���������
            frmDocPrint.InitReport(Me.dgAllInvoices("typeDoc", Me.dgAllInvoices.CurrentRow.Index).Value())

        Catch ex As System.Exception
            MessageBox.Show("������ � �������� ������������ ���������. " & ex.Message, appName)
        End Try
    End Sub
#End Region

    Private Sub ���������������ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ���������������ToolStripMenuItem.Click
        If currentInvoice = Nothing Then
            MsgBox("�� ������ ����.", MsgBoxStyle.Information, appName)

            Me.dgAllInvoices.Focus()
        Else
            Dim frmSelect As New frmDocProdukt
            frmSelect.ShowDialog()

            If (frmSelect.IsAddedPosition) Then
                AddChangeHistoryNote()
            End If
            FillDSOffering(currentInvoice)
        End If
    End Sub

    Private Sub AddChangeHistoryNote()
        Try
            Dim cmd As New SqlClient.SqlCommand
            cmd.Connection = mcnnInt
            cmd.CommandText = "sp_addChangeDocumentHistory"
            cmd.Parameters.Add(New SqlClient.SqlParameter("@invoiceId", SqlDbType.Int))
            cmd.Parameters("@invoiceId").Value = currentInvoice
            cmd.CommandType = CommandType.StoredProcedure
            mcnnInt.Open()
            cmd.ExecuteNonQuery()
        Finally
            mcnnInt.Close()
        End Try
    End Sub

    Private Sub dgAllInvoices_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dgAllInvoices.KeyDown
        If e.KeyCode = Keys.P Then
            Me.cmsAllInvoices.Show()
            Me.cmsAllInvoices.Focus()
        End If
    End Sub

    Private Sub ������������������ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ������������������ToolStripMenuItem.Click
        PrintDoc()
    End Sub

    Private Sub ������������������ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ������������������ToolStripMenuItem.Click
        Dim itemChecked As Object

        For Each itemChecked In Me.clbDocTypes.CheckedItems
            NewDoc(2, itemChecked.item(0))
        Next
    End Sub

    Private Sub �������������������ToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles �������������������ToolStripMenuItem.Click
        Dim frmSelect As New frmDocEdit

        frmSelect.invoiceID = Me.dgAllInvoices("invoiceID", Me.dgAllInvoices.CurrentRow.Index).Value()
        frmSelect.Text = frmSelect.Text + " " + CStr(Me.dgAllInvoices("�����", Me.dgAllInvoices.CurrentRow.Index).Value())
        frmSelect.ShowDialog()
        If (frmSelect.IsSaved) Then
            currentInvoice = Me.dgAllInvoices("invoiceID", Me.dgAllInvoices.CurrentRow.Index).Value()
            AddChangeHistoryNote()
        End If
    End Sub


    Private Sub �������������ToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles �������������ToolStripMenuItem.Click
        openFromKA = True

        Dim frmSelect As New frmOrganizations
        frmSelect.ShowDialog()
    End Sub

    Private Sub ��������������ToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ��������������ToolStripMenuItem.Click
        LoadOrganisation()
    End Sub

    Private Sub txtKA_find_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtKA_find.TextChanged
        LoadCustomers(sender.Text)
    End Sub

#Region " ��������� ������ � ���������� - ������������ � ������  "
    Private Sub LoadCustomers(ByVal strFind As String)
        Try
            Dim odaPartList As New SqlClient.SqlDataAdapter("SELECT ID, Name FROM KAgents WHERE Name LIKE '%" & strFind & "%' order by Name", mcnnInt)
            Dim dtPartList As New DataTable : odaPartList.Fill(dtPartList)

            Me.cmb_KA.DataSource = dtPartList
            Me.cmb_KA.DisplayMember = "Name"
            Me.cmb_KA.ValueMember = "ID"
        Catch oexpData As System.Exception
            MsgBox(oexpData.Message)
        End Try
    End Sub
#End Region

    Private Sub tsDelDoc_Click(sender As System.Object, e As System.EventArgs) Handles tsDelDoc.Click
        Try  '������� ���� � �������� ��� ������� � ���
            Select Case MsgBox(Prompt:="������� " & CStr(Me.dgAllInvoices("��������", Me.dgAllInvoices.CurrentRow.Index).Value()) & " " & CStr(Me.dgAllInvoices("�����", Me.dgAllInvoices.CurrentRow.Index).Value()) & "?", Buttons:=vbYesNo, Title:=appName)
                Case Is = vbYes
                    Me.dgDoc.DataSource = Nothing
                    Module1.NonQuery1("DELETE FROM Invoices WHERE invoiceID=" & Me.dgAllInvoices("invoiceID", Me.dgAllInvoices.CurrentRow.Index).Value() & "")

                    AllInvoices()
                Case Is = vbNo
                    Exit Sub
            End Select
        Catch ex As System.Exception
            MessageBox.Show(ex.Message, appName)
        End Try
    End Sub

    Private Sub ��������������ToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ��������������ToolStripMenuItem.Click
        Try
            costID = Me.dgAllInvoices("costID", Me.dgAllInvoices.CurrentRow.Index).Value()
        Catch ex As System.Exception
            MessageBox.Show(ex.Message, appName)
            Exit Sub
        End Try
        ModCallForm.CallForm("", 11, 3)
    End Sub

    Friend eBtn As System.Windows.Forms.Button ' ������������� ������, ������ ��� ����� �������� ���� ������, ��� ��� ���� ���������
    Friend eTxt As System.Windows.Forms.TextBox
    Friend mForm As System.Windows.Forms.Form

    Private Sub �������������ToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles �������������ToolStripMenuItem.Click
        mForm = New System.Windows.Forms.Form
        eTxt = New System.Windows.Forms.TextBox
            ' Friend mForm As New System.Windows.Forms.Form
        mForm.Text = "����� �� ������ ���������"

        Dim elLabel As New Label
        Dim eBtn As New Button
            'Dim eTxt = New TextBox
            ' � �.�. ������� �������� � ��������� �� �� �����
        eBtn.Text = "�����"
        eBtn.Visible = True
        eBtn.Dock = DockStyle.Top
        AddHandler eBtn.Click, AddressOf eBtn_Click ' ��������� ������� Click
        mForm.Controls.Add(eBtn)

        eTxt.AutoSize = True
            'eTxt.Text = ""
        eTxt.Dock = DockStyle.Top
        eTxt.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
            ' AddHandler eTxt.TextChanged, AddressOf eTxt_Text ' ��������� ������� Click
        mForm.Controls.Add(eTxt)

        elLabel.AutoSize = True
        elLabel.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        elLabel.Text = "����� ��������"
        mForm.Controls.Add(elLabel)
        elLabel.Dock = DockStyle.Top

        mForm.MaximizeBox = False
        mForm.AutoSize = True
        mForm.Show()
        eTxt.Focus()
    End Sub

    Private Sub eBtn_Click()
        Dim strSQL$

        strSQL = "SELECT Invoices.costID, Invoices.invoiceID, TypesDocument.name AS ��������, Invoices.numberDoc AS �����, CONVERT(varchar(10), Invoices.data, 104) AS ����,"
        strSQL &= " Employees.emplLastName AS �����, "
        strSQL &= " Invoices.description AS ���������, Invoices.typeDoc FROM Invoices "
        strSQL &= " INNER JOIN TypesDocument ON Invoices.typeDoc = TypesDocument.ID "
        strSQL &= " INNER JOIN Employees ON Invoices.emplID = Employees.emplID WHERE  "
        strSQL &= " Invoices.numberDoc LIKE '%'+'" & Trim(eTxt.Text) & "'+'%' "

        mForm.Close()
    End Sub


    Private Sub ���������������������������ToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ���������������������������ToolStripMenuItem.Click
        Select Case MsgBox(Prompt:="������� ��� ������� � ���������-" & CStr(Me.dgAllInvoices("��������", Me.dgAllInvoices.CurrentRow.Index).Value()) & " " & CStr(Me.dgAllInvoices("�����", Me.dgAllInvoices.CurrentRow.Index).Value()) & "?", Buttons:=vbYesNo, Title:=appName)
            Case Is = vbYes
                Module1.NonQuery1("DELETE FROM Offering WHERE invoiceID = " & Me.dgAllInvoices("invoiceID", Me.dgAllInvoices.CurrentRow.Index).Value() & " ")
                Me.dgDoc.DataSource = Nothing
            Case Is = vbNo
                Exit Sub
        End Select
    End Sub

#Region " ������� � Excel "
    Private Sub ����������ExcelToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ����������ExcelToolStripMenuItem.Click
        Dim oExcel As Object
        Dim oBook As Object
        Dim iRow As Integer
        Dim iCol As Integer
        Dim ch As Char
        Dim tmpDataSet As DataTable = CType(Me.dgAllInvoices.DataSource, DataTable)

        oExcel = CreateObject("Excel.Application")
        oExcel.Visible = True
        oBook = oExcel.Workbooks.Add
        With oBook.ActiveSheet
            .Range("A2:H2").Font.Size = 12
            .Range("A2:H2").Font.Bold = True
            '    .Range("B2").Value = "����� " & Me.lstReports.SelectedItem(1)

            For iCol = 0 To Me.dgAllInvoices.Columns.Count - 1
                ch = Chr(65 + iCol)
                .Range(ch & 3).Value = Me.dgAllInvoices.Columns(iCol).HeaderText.ToString


                For iRow = 0 To tmpDataSet.Rows.Count - 1
                    ch = Chr(65 + iCol)

                    If Me.dgAllInvoices.Columns(iCol).Name <> "�����" Then
                        .Range(ch & iRow + 4).NumberFormat = "@"
                    End If

                    .Range(ch & iRow + 4).Value = IIf(IsDBNull(Me.dgAllInvoices(iCol, iRow).Value), "", Replace(Me.dgAllInvoices(iCol, iRow).Value.ToString, "=", "�����-"))
                Next iRow
                .columns(iCol + 1).EntireColumn.AutoFit()
            Next iCol

        End With
    End Sub
#End Region

    Private Sub ��������������ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ��������������ToolStripMenuItem.Click
        openFromKA = True
        If custID <> Nothing Then
            Dim frmSelect As New frmOrganizations
            frmSelect.ShowDialog()
        Else
            MsgBox("�� ������ ����������.", MsgBoxStyle.Critical, appName)
        End If
    End Sub

    Private Sub ColHideDG(NameGrid As DataGridView)
        For Each col As DataGridViewColumn In NameGrid.Columns
            If col.Name = "invoiceID" Or col.Name = "statusID" Or col.Name = "typeDoc" Or col.Name = "ID" Or col.Name = "custID" Or col.Name = "��" Then
                col.visible = False
            End If
        Next

        NameGrid.ClearSelection()
    End Sub

    Private Sub tsbtnExit_Click(sender As Object, e As EventArgs) Handles tsbtnExit.Click
        If MessageBox.Show("��������� ������ � �����������?", appName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then Me.Close()
    End Sub

    Private Sub tsbtnClosedPeriod_Click(sender As Object, e As EventArgs) Handles tsbtnClosedPeriod.Click
        If emplID = 3 Or emplID = 1096 Then '1096
            MsgBox("��������� ������", MsgBoxStyle.Information, appName)

            Dim cmd As New SqlClient.SqlCommand

            cmd.Connection = mcnnInt
            cmd.CommandText = "sp_FinClosedPeriod"
            cmd.CommandType = CommandType.StoredProcedure

            cmd.Parameters.Add(New SqlClient.SqlParameter("@date1", SqlDbType.Date))
            cmd.Parameters("@date1").Value = Me.dtpDocOut.Value.Date

            cmd.Parameters.Add(New SqlClient.SqlParameter("@date2", SqlDbType.Date))
            cmd.Parameters("@date2").Value = Me.dtpDate2.Value.Date

            mcnnInt.Open()
            cmd.ExecuteNonQuery()
            mcnnInt.Close()
        End If
    End Sub
   
    Private Sub tsbtnVIntervale_Click(sender As Object, e As EventArgs) Handles tsbtnVIntervale.Click
        Try
            Dim strDocTypes$ = Nothing

            For Each itemChecked As Object In Me.clbDocTypes.CheckedItems
                strDocTypes += "," + itemChecked.item(0).ToString
            Next

            AllInvoicesWOorder(strDocTypes)
        Catch ex As System.Exception
            MessageBox.Show("�������� �� ������� ��������: ��� ���������, ���������� ��� �������� ���. " & ex.Message, appName)
            Exit Sub
        End Try
    End Sub

    Private Sub tsbtnCreateNaOsn_Click(sender As Object, e As EventArgs) Handles tsbtnCreateNaOsn.Click
        Dim itemChecked As Object

        For Each itemChecked In Me.clbDocTypes.CheckedItems
            NewDoc(2, itemChecked.item(0))
        Next
    End Sub

    Private Sub dtpDate2_VisibleChanged(sender As Object, e As EventArgs) Handles dtpDate2.VisibleChanged
        If Me.dtpDate2.Visible = True Then
            If emplID = 3 Or emplID = 1096 Then '1096
                Me.tsbtnClosedPeriod.Visible = True
            End If
        End If
    End Sub

    Private Sub tsbtnSSS_Click(sender As Object, e As EventArgs) Handles tsbtnSSS.Click
        If emplID = 3 Or emplID = 1096 Then
            Dim TestService As New ServiceController("1CIntegration", "AppServer01")

            If Me.tsbtnSSS.Checked = False Then
                TestService.Stop()
            Else
                TestService.Start()
            End If
        Else
            MsgBox("��� �������", MsgBoxStyle.Information, appName)
        End If
    End Sub

    Private Sub btnRefreshHistory_Click(sender As Object, e As EventArgs) Handles btnRefreshHistory.Click
        LoadHistory()
    End Sub
End Class