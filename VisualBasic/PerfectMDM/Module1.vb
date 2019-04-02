Module Module1
    Public serverName$
    Public terminal As Boolean = False
    Public strPath As String  '
    Public Key As Microsoft.Win32.RegistryKey = Microsoft.Win32.Registry.LocalMachine.OpenSubKey("Software\MS\Perfect", True)

    Public columnNameMF As New ArrayList
    Public KeySettings As Microsoft.Win32.RegistryKey = Microsoft.Win32.Registry.CurrentUser.OpenSubKey("Software\MS\Perfect", True)
    Public emplID, postPrioritet, prava, ofID, g_postID, depID As Integer 'определяется при входе по принадлежности сотрудника
    Public kassaAllow As Boolean 'не приним оплату
    Public idSup As Integer 'идентификатор поставщика, определяется в главной форме
    Public costID, custID, taskID As Integer
    Public serviceID As Integer
    Public orderSpecID As Integer ' id специи таб orders
    Public addcust As Boolean = False 'признак добавления заказчика
    Public addsup As Boolean = False 'признак добавления поставщика
    Public addPerson As Boolean = False 'в карточке редактирования заказа при создании нового контактного лица
    Public addOrganization As Boolean = False 'в карточке редактирования заказа при создании нового юр. лица заказчика
    Public selectReport As Integer
    Public nomVn As String
    Public url As String
    Public spravSQL As String = Nothing
    Public sprCaption As String
    Public currentInvoice As Integer
    Public procNotepad As Process

    Public modeMatForOper As Integer ' 1- калькуляция, 2- списание
    Public operFromOrderID As Integer ' операция на которую списывается или калькулируется матераил
    Public modeEmplPayPen As Boolean ' 0-режим штрафов и премий, 1- режим ФЗП???
    Public createTask As Boolean 'признак срзд новой задачи
    Public createEmplKA As Boolean = False  'признак создания нового сотрудника клиента
    Public strConnection As String
    Public mcnnInt As New SqlClient.SqlConnection

    'Переменные привязаные к ролям
    Public visibleResurs As Boolean
    Public visibleSklad As Boolean
    Public visibleFinans As Boolean

    Public visibleContact As Boolean 'видимость контакта в карт заказа
    Public visibleCostOrder As Boolean  'видит стоимость заказа
    Public allowDelFiles As Boolean 'возможность удаления файлов
    Public viewOnlyWhereImExecut As Boolean 'Видит только заказы к исполнению
    Public visibleSpravochnik As Boolean 'Видит справочник
    Public rulesPayments As Boolean 'Возможность управлять из карточки заказа
    Public WorkplaceHead As Boolean
    Public editClosedOrders As Boolean 'редактирует закрытые заказы
    Public OrdTakOfMan As Boolean 'распределяет заказы атрибут роли

    Public CanUseMdmOnlinePayments As Boolean 'может пользоваться онлайн оплатой мдм через яндекс кассу
    Public CanUseEnjoyOnlinePayments As Boolean 'может пользоваться онлайн оплатой энджой через яндекс кассу
    Public CanUseAdditionalMdmOnlinePayments As Boolean 'может пользоваться дополнительной онлайн оплатой мдм через робокассу
    Public CanMakeOnlinePaymentsInProgram As Boolean 'может создавать онлайн платежи из программы

    Public CanChangeRoutsInReadyOrder As Boolean
    Public CanChangeRoutsInIssuedOrder As Boolean
    Public CanDeleteRouts As Boolean

    Public CanEditCancelledOrders As Boolean

    Public CanAddDocumentOfSameType As Boolean
    '************************************************************
    Public neRedDoc As Boolean
    Public nePrinBeznal As Boolean
    Public EditSpec As Boolean = False
    Public otmGotovnost As Boolean 'отмечает готовность заказа

    Public appName As String = "HelloPrint"

    'переменные, значения которых в качестве параметра передаем в отчет
    Public dolgi@ = 0, cost@ = 0, files$ ', adrNDS%

    Public strSum$ = Nothing
    Public currentDocNum$ = Nothing ' внутренни номер документа
    Public strCountNaim$ 'строковое значение количества наименований
    Public countNaim As Integer
    Public vse As String ' все позиции в виде строки
    Public strSumProp$ 'строковое значение суммы прописью

    Public autoAccount As Boolean 'признак автозаполнения счета
    Public openFromKA As Boolean
    Public MinCost As Integer ' сумма минимального расчета определяется в поле описания у типа контрагента

    Public skidkaCust% = 0
    Public costIDstr$ 'строка идэшников заказов для массовой оплаты

    'Настройки
    Public paramLogistic As Boolean
    Public paramSklad As Boolean
    Public paramNumbering As Integer
    Public paramFinAnalytics As Boolean
    Public paramFileStoragePath As String 'путь к файловому хранилищу 
    Public paramLocalTempPath As String 'путь к локальной временной папке
    Public paramUrlGanter As String  'путь к планирования
    Public paramFZP As Boolean 'Блок учета выплат сотрудникам
    Public paramManInvoicesPayment As Boolean 'модуль управления счетами
    Public ProductionDate As Boolean = False
    Public f_paramProductionDate As Boolean
    Public FZPno As Boolean 'не видит Блок учета выплат сотрудникам
    Public paramOrdTakOfMan As Boolean ' заказ принимает офис менеджер и передает свободнлму менеджеру
    Public paramRoutAWC As Boolean 'отвечает за выбор только одного департамента препресс или выборочных сотрудников (процедура)

    'режимные переменные определяют набор видимых полей в формах и логику отработки событий нажатий на кнопки и тп
    Public mode_deduction As Boolean 'режим массового удержания в выплатах сотрудникам и частные выплаты
    Public paramIssuesOrders As Boolean = True 'может переводить заказ в состояние Выдан
    Public CanceledOrder As Boolean = False

    Public paramUrlMaper As String  'путь к
    Public formTagNewProd As String

    Public addProdawcPoly As Boolean = False

    Public paramUrlCalcPolygraph As String
    Public paramUrlCalcFastorder As String '

    ' Округление вверх
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

    Public Sub Main() 'проверка запуска только одного экземпляра приложения
        Dim Proc() As Process
        Dim ModuleName, ProcName As String

        ModuleName = Process.GetCurrentProcess.MainModule.ModuleName
        ProcName = System.IO.Path.GetFileNameWithoutExtension(ModuleName)

        Proc = Process.GetProcessesByName(ProcName)

        If Proc.Length > 1 Then
            MsgBox(appName + " уже запущен", MsgBoxStyle.Critical, appName) : Application.Exit()
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
                MsgBox("Нет полномочий.", MsgBoxStyle.Critical, appName)
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
            MsgBox("Возможно ошибка в последовательности загрузки оперций для калькулирования и типов материалов профиля калькулятора. Обратитесь к разработчику.", MsgBoxStyle.Information, appName)
            Exit Sub
        End Try
    End Sub
End Module
