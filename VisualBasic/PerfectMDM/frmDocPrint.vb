Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Imports System.IO

'Поработать на программной заменой источника данных
Public Class frmDocPrint
    Dim crParameterFieldDefinitions As ParameterFieldDefinitions
    Dim crParameterFieldDefinition As ParameterFieldDefinition
    Dim crParameterValues As ParameterValues
    Dim crParameterDiscreteValue As ParameterDiscreteValue
    Dim reportParams As New Specialized.NameValueCollection

    Public Sub InitReport(ByVal var As Integer) ', ByVal reportParams As Specialized.NameValueCollection)
        Dim rprt As New ReportDocument
        'получаем файл шаблона отчета из БД
        '& " AND active ='1'
        Dim da As New SqlClient.SqlDataAdapter("SELECT * FROM TypesDocument WHERE ID=" & var & "", mcnnInt)
        Dim dsF As New DataSet()

        Dim strFileName As String = Path.GetTempPath & "report.rpt"
        Dim rrr As New FileInfo(strFileName)

        rrr.Delete()  ' удаляем если существует файл отчета

        Try
            da.Fill(dsF, "MyImages")

            Dim MyData() As Byte = dsF.Tables("MyImages").Rows(0)("docField")
            Dim K As Long = UBound(MyData)
            ' сохраняем во временную папку файл отчета
            Dim fs As New FileStream(strFileName, FileMode.OpenOrCreate, FileAccess.Write)

            fs.Write(MyData, 0, K)
            fs.Close()
            fs = Nothing
            dsF = Nothing
            da = Nothing
        Catch ex As System.Exception
        End Try

        'rprt.Load("C:\rrr.rpt")

        rprt.Load(strFileName) 'получаем из временной папки файл шаблона отчета

        'Читаем параметры шаблона отчета
        For i As Integer = 0 To rprt.ParameterFields.Count - 1
            Dim A As String = rprt.ParameterFields(i).Name ' наименование параметра
            'MsgBox(A)
            NoProblem(A) 'передаем по ссылке значение А получаем его измененным в зависимости от его имени
            ' MsgBox(A)
            reportParams.Add(rprt.ParameterFields(i).Name, A)
        Next

        Try
            For Each paramName As String In reportParams.Keys
                crParameterFieldDefinitions = rprt.DataDefinition.ParameterFields
                crParameterFieldDefinition = crParameterFieldDefinitions(paramName)
                crParameterValues = crParameterFieldDefinition.CurrentValues
                crParameterDiscreteValue = New ParameterDiscreteValue()
                crParameterDiscreteValue.Value = reportParams(paramName)
                crParameterValues.Add(crParameterDiscreteValue)
                crParameterFieldDefinition.ApplyCurrentValues(crParameterValues)
            Next
        Catch ex As System.Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, appName)
        End Try

        Me.CrystalReportViewer1.ReportSource = rprt
        Me.Show()

        'Dim strFileName1 As String = "C:\DSPerfectCRM.xml"
        'Dim rrr1 As New FileInfo(strFileName1)
        'rrr1.Delete()   ' удаляем если существует файл

        'Dim strFileName2 As String = "C:\DSTZ.xml"
        'Dim rrr2 As New FileInfo(strFileName2)

        ''**************
        'rrr2.Delete()   ' удаляем если существует файл
    End Sub

    Sub NoProblem(ByRef uuu As String)
        If String.Compare(uuu.Substring(0, 3), "prm", True) = 0 Then
            uuu = Module1.NonQuery1ScalarString("SELECT coalesce(description, '') FROM ParamForDoc WHERE name=  '" & uuu & "' ")
            Exit Sub
        End If

        Select Case uuu
            Case Is = "dolg" : uuu = dolgi
            Case Is = "cost" : uuu = cost
            Case Is = "files" : uuu = files
            Case Is = "itogDoc" : uuu = strSum
            Case Is = "countNaim" : uuu = CStr(countNaim)
                ' Case Is = "strNDS" : uuu = adrNDS 'ставка НДС получателя платежа
            Case Is = "vse" : uuu = vse
            Case Is = "strKolvo" : uuu = strCountNaim
            Case Is = "kolvo" : uuu = CStr(countNaim)
            Case Is = "currentOferta" : uuu = currentDocNum
                ' Case Is = "NDS" : uuu = frmDocOut.dsSchet.Tables("Adresee").Rows(0).Item(23).ToString()
                'CStr(Me.dgAllInvoices(dgAllInvoices.CurrentCell.RowNumber, 1))
                ' Case Is = "ndsVsego" : uuu = CStr(itogDoc - itogDoc / (dsSchet.Tables("Adresee").Rows(0).Item(23) / 100 + 1))
                'Case Is = "Itogo" : uuu = CStr(itogDoc)
                'Case Is = "ndsVsego" : uuu = CStr(itogDoc - itogDoc / (frmDocOut.dsSchet.Tables("Adresee").Rows(0).Item(23) / 100 + 1))
            Case Else
                MsgBox("Значение параметра " & uuu & " не найдено.", MsgBoxStyle.Critical, appName)
        End Select
    End Sub

    Private Sub ОтправитьПоEmailToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ОтправитьПоEmailToolStripMenuItem.Click
        Me.CrystalReportViewer1.PrintReport()
        'rprt.SaveAs("C:\TMP\DSPerfectCRM.pdf")
    End Sub

   
    Private Sub frmDocPrint_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class