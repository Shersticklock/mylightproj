Module Module1
    Public serverName$
    Public terminal As Boolean = False
    Public strPath As String  '
    Public Key As Microsoft.Win32.RegistryKey = Microsoft.Win32.Registry.LocalMachine.OpenSubKey("Software\MS\Perfect", True)

    Public columnNameMF As New ArrayList
    Public KeySettings As Microsoft.Win32.RegistryKey = Microsoft.Win32.Registry.CurrentUser.OpenSubKey("Software\MS\Perfect", True)
    Public emplID, postPrioritet, prava, ofID, g_postID, depID As Integer '������������ ��� ����� �� �������������� ����������
    Public kassaAllow As Boolean '�� ������ ������
    Public idSup As Integer '������������� ����������, ������������ � ������� �����
    Public costID, custID, taskID As Integer
    Public serviceID As Integer
    Public orderSpecID As Integer ' id ������ ��� orders
    Public addcust As Boolean = False '������� ���������� ���������
    Public addsup As Boolean = False '������� ���������� ����������
    Public addPerson As Boolean = False '� �������� �������������� ������ ��� �������� ������ ����������� ����
    Public addOrganization As Boolean = False '� �������� �������������� ������ ��� �������� ������ ��. ���� ���������
    Public selectReport As Integer
    Public nomVn As String
    Public url As String
    Public spravSQL As String = Nothing
    Public sprCaption As String
    Public currentInvoice As Integer
    Public procNotepad As Process

    Public modeMatForOper As Integer ' 1- �����������, 2- ��������
    Public operFromOrderID As Integer ' �������� �� ������� ����������� ��� �������������� ��������
    Public modeEmplPayPen As Boolean ' 0-����� ������� � ������, 1- ����� ���???
    Public createTask As Boolean '������� ���� ����� ������
    Public createEmplKA As Boolean = False  '������� �������� ������ ���������� �������
    Public strConnection As String
    Public mcnnInt As New SqlClient.SqlConnection

    '���������� ���������� � �����
    Public visibleResurs As Boolean
    Public visibleSklad As Boolean
    Public visibleFinans As Boolean

    Public visibleContact As Boolean '��������� �������� � ���� ������
    Public visibleCostOrder As Boolean  '����� ��������� ������
    Public allowDelFiles As Boolean '����������� �������� ������
    Public viewOnlyWhereImExecut As Boolean '����� ������ ������ � ����������
    Public visibleSpravochnik As Boolean '����� ����������
    Public rulesPayments As Boolean '����������� ��������� �� �������� ������
    Public WorkplaceHead As Boolean
    Public editClosedOrders As Boolean '����������� �������� ������
    Public OrdTakOfMan As Boolean '������������ ������ ������� ����

    Public CanUseMdmOnlinePayments As Boolean '����� ������������ ������ ������� ��� ����� ������ �����
    Public CanUseEnjoyOnlinePayments As Boolean '����� ������������ ������ ������� ������ ����� ������ �����
    Public CanUseAdditionalMdmOnlinePayments As Boolean '����� ������������ �������������� ������ ������� ��� ����� ���������
    Public CanMakeOnlinePaymentsInProgram As Boolean '����� ��������� ������ ������� �� ���������

    Public CanChangeRoutsInReadyOrder As Boolean
    Public CanChangeRoutsInIssuedOrder As Boolean
    Public CanDeleteRouts As Boolean

    Public CanEditCancelledOrders As Boolean

    Public CanAddDocumentOfSameType As Boolean
    '************************************************************
    Public neRedDoc As Boolean
    Public nePrinBeznal As Boolean
    Public EditSpec As Boolean = False
    Public otmGotovnost As Boolean '�������� ���������� ������

    Public appName As String = "HelloPrint"

    '����������, �������� ������� � �������� ��������� �������� � �����
    Public dolgi@ = 0, cost@ = 0, files$ ', adrNDS%

    Public strSum$ = Nothing
    Public currentDocNum$ = Nothing ' ��������� ����� ���������
    Public strCountNaim$ '��������� �������� ���������� ������������
    Public countNaim As Integer
    Public vse As String ' ��� ������� � ���� ������
    Public strSumProp$ '��������� �������� ����� ��������

    Public autoAccount As Boolean '������� �������������� �����
    Public openFromKA As Boolean
    Public MinCost As Integer ' ����� ������������ ������� ������������ � ���� �������� � ���� �����������

    Public skidkaCust% = 0
    Public costIDstr$ '������ ��������� ������� ��� �������� ������

    '���������
    Public paramLogistic As Boolean
    Public paramSklad As Boolean
    Public paramNumbering As Integer
    Public paramFinAnalytics As Boolean
    Public paramFileStoragePath As String '���� � ��������� ��������� 
    Public paramLocalTempPath As String '���� � ��������� ��������� �����
    Public paramUrlGanter As String  '���� � ������������
    Public paramFZP As Boolean '���� ����� ������ �����������
    Public paramManInvoicesPayment As Boolean '������ ���������� �������
    Public ProductionDate As Boolean = False
    Public f_paramProductionDate As Boolean
    Public FZPno As Boolean '�� ����� ���� ����� ������ �����������
    Public paramOrdTakOfMan As Boolean ' ����� ��������� ���� �������� � �������� ���������� ���������
    Public paramRoutAWC As Boolean '�������� �� ����� ������ ������ ������������ �������� ��� ���������� ����������� (���������)

    '�������� ���������� ���������� ����� ������� ����� � ������ � ������ ��������� ������� ������� �� ������ � ��
    Public mode_deduction As Boolean '����� ��������� ��������� � �������� ����������� � ������� �������
    Public paramIssuesOrders As Boolean = True '����� ���������� ����� � ��������� �����
    Public CanceledOrder As Boolean = False

    Public paramUrlMaper As String  '���� �
    Public formTagNewProd As String

    Public addProdawcPoly As Boolean = False

    Public paramUrlCalcPolygraph As String
    Public paramUrlCalcFastorder As String '

    ' ���������� �����
    Function RoundUp(ByVal ro As Decimal) As Long
        If (ro - Fix(ro)) > 0 Then RoundUp = Fix(ro) + 1 Else RoundUp = ro
    End Function

    Sub NonQuery1(ByVal strSQL As String)
        Try
            Dim ocmd As New SqlClient.SqlCommand

            ocmd.CommandText = strSQL
            ocmd.Connection = mcnnInt
            mcnnInt.Open()
            ocmd.ExecuteNonQuery()
        Catch excp As System.Exception
            MessageBox.Show(excp.Message, appName)
            MsgBox(strSQL, MsgBoxStyle.Critical, appName)
        Finally
            mcnnInt.Close()
        End Try
    End Sub

    Function NonQuery1Scalar(ByVal strSQL As String) As Decimal
        Try
            Dim ocmd As New SqlClient.SqlCommand

            ocmd.CommandText = strSQL
            ocmd.Connection = mcnnInt
            mcnnInt.Open()
            Return ocmd.ExecuteScalar
        Catch excp As System.Exception
            MessageBox.Show(excp.Message, appName)
            Exit Function
        Finally
            mcnnInt.Close()
        End Try
    End Function

    Function NonQueryScalarInt(ByVal strSQL As String) As Integer
        Try
            Dim ocmd As New SqlClient.SqlCommand

            ocmd.CommandText = strSQL
            ocmd.Connection = mcnnInt
            mcnnInt.Open()
            Return ocmd.ExecuteScalar
        Catch excp As System.Exception
            MessageBox.Show(excp.Message, appName)
            Exit Function
        Finally
            mcnnInt.Close()
        End Try
    End Function

    Function NonQuery1ScalarDate(ByVal strSQL As String) As Date
        Try
            Dim ocmd As New SqlClient.SqlCommand

            ocmd.CommandText = strSQL
            ocmd.Connection = mcnnInt
            mcnnInt.Open()
            Return ocmd.ExecuteScalar
        Catch excp As System.Exception
            MessageBox.Show(excp.Message, appName)
            Exit Function
        Finally
            mcnnInt.Close()
        End Try
    End Function

    Function NonQuery1ScalarString(ByVal strSQL As String) As String
        Try
            Dim ocmd As New SqlClient.SqlCommand

            ocmd.CommandText = strSQL
            ocmd.Connection = mcnnInt
            mcnnInt.Open()
            Return ocmd.ExecuteScalar
        Catch excp As System.Exception
            MessageBox.Show(excp.Message, appName)
            Return Nothing
            Exit Function
        Finally
            mcnnInt.Close()
        End Try
    End Function

    Function NonQuery1ScalarBool(ByVal strSQL As String) As Boolean
        Try

            Dim ocmd As New SqlClient.SqlCommand
            ocmd.CommandText = strSQL
            ocmd.Connection = mcnnInt
            mcnnInt.Open()
            Return ocmd.ExecuteScalar
        Catch excp As System.Exception
            MessageBox.Show(excp.Message, appName)
            Return False
            Exit Function
        Finally
            mcnnInt.Close()
        End Try
    End Function

    Sub vixod()
        Application.Exit()
    End Sub

    Public Sub Main() '�������� ������� ������ ������ ���������� ����������
        Dim Proc() As Process
        Dim ModuleName, ProcName As String

        ModuleName = Process.GetCurrentProcess.MainModule.ModuleName
        ProcName = System.IO.Path.GetFileNameWithoutExtension(ModuleName)

        Proc = Process.GetProcessesByName(ProcName)

        If Proc.Length > 1 Then
            MsgBox(appName + " ��� �������", MsgBoxStyle.Critical, appName) : Application.Exit()
        End If
    End Sub

    Public Function Test1(ByVal log As String, ByVal pass As String) As Boolean
        Dim success As Boolean
        Dim Hashhelper As New HashHelper.HashHelper()

        If log = "supervisor" Then
            Return True
        Else
            Dim modaLookupData As New SqlClient.SqlDataAdapter("SELECT * FROM Employees INNER JOIN Posts ON Employees.postID = Posts.postID WHERE Employees.emplID=" & emplID & " AND dismissed=0", mcnnInt)
            Dim dtLog As New DataTable : modaLookupData.Fill(dtLog)
            Dim dr As DataRow

            If dtLog.Rows.Count = 0 Then
                MsgBox("��� ����������.", MsgBoxStyle.Critical, appName)
            Else
                dr = dtLog.Rows(0)
                postPrioritet = dr("postPrioritet")
                emplID = dr("emplID")
                prava = dr("prava")
                kassaAllow = dr("kassa")
                ofID = dr("ofID")
                g_postID = dr("postID")
                depID = dr("departmentID")

                If TypeOf (dr("password")) Is DBNull Then
                    Return False
                Else
                    success = Hashhelper.ComparePassword(dr("password"), pass)
                    Return success
                End If
            End If
        End If
    End Function

    Public Function List(ByVal ID As Integer, ByVal ControlName As String) As DataTable
        Dim list1 As String = Module1.NonQuery1ScalarString("SELECT listMatTypeID FROM CalcSettings WHERE serviceID=" & ID & " AND nameControl='" & ControlName & "'")
        Dim strSQL$ = "SELECT matID, matName FROM Materials WHERE typeID IN (SELECT number FROM [dbo].[iter_intlist]('" & list1 & "')) AND accessible=1 order by matName"
        Dim odaMat As New SqlClient.SqlDataAdapter(strSQL, mcnnInt)
        Dim dtR As New DataTable : odaMat.Fill(dtR)
        Return dtR
    End Function

    Public Function GenerateString(ByVal minLength As Integer, ByVal maxLength As Integer) As String
        Dim charset As String = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ"
        Dim r As New Random()
        Dim lenPass As Integer = r.Next(minLength, maxLength)
        Dim str As String = String.Empty

        For i As Integer = 0 To lenPass - 1
            str += charset(r.Next(0, charset.Length))
        Next
        Return str
    End Function

    Public Sub ConfigTechOper(ByRef ob As Object, calcId As Integer)
        Dim frmSelect As New frmConfigTechOper

        frmSelect.ttt = ob.tag

        Try
            If TypeOf ob Is CheckBox Then
                If ob.checked = True Then
                    frmSelect.itemTech = 1
                Else
                    frmSelect.itemTech = 0
                End If

                frmSelect.calcID = calcId
                frmSelect.ShowDialog()
            Else

                If TypeOf ob Is CheckedListBox Then
                    frmSelect.ShowDialog()
                Else ' combobox
                    frmSelect.itemTech = ob.selecteditem(0)
                    frmSelect.calcID = calcId
                    frmSelect.ShowDialog()
                End If
            End If
        Catch ex As System.Exception
            MsgBox("�������� ������ � ������������������ �������� ������� ��� ��������������� � ����� ���������� ������� ������������. ���������� � ������������.", MsgBoxStyle.Information, appName)
            Exit Sub
        End Try
    End Sub
End Module
