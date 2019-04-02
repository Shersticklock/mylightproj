Imports System.Data.SqlClient
Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports System.Windows.Forms
Imports System.Drawing.Printing


Public Class frmPrintLabel
    Private PrtSetupDB As New PrintDialog()
    Private WithEvents PrtDocument As New System.Drawing.Printing.PrintDocument()
    Private PageSetupDB As New PageSetupDialog()
    Private PrintPreviewDB As New PrintPreviewDialog()
    Private PrinterSettings As New System.Drawing.Printing.PrinterSettings()
    
    Dim iii As Integer
    

    Private Sub frmPrintLabel_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmbPrim.DisplayMember = "text"
        cmbPrim.ValueMember = "id"
        Dim sql As String = "SELECT id, text FROM LabelPrintingNotes"
        Dim sqlAdapter As New SqlDataAdapter(sql, mcnnInt)
        Dim dataTable As New DataTable()
        sqlAdapter.Fill(dataTable)
        cmbPrim.DataSource = dataTable
        cmbPrim.SelectedIndex = -1
    End Sub

    Private Sub tsbtnPrintLabel_Click(sender As System.Object, e As System.EventArgs) Handles tsbtnPrintLabel.Click
        Me.TableLayoutPanel1.Enabled = False

        If Me.nudQuantity.Value = 0 Then
            MsgBox("Требуется ввести количество мест", MsgBoxStyle.Critical, appName)
            Me.nudQuantity.Focus()
        Else
            iii = 1

            PrtSetupDB.Document = PrtDocument
            PrtSetupDB.PrinterSettings = PrinterSettings

            If PrtSetupDB.ShowDialog() = DialogResult.OK Then
                For i As Integer = 1 To Me.nudQuantity.Value
                    '   MsgBox(CStr(i))

                    PrtDocument.Print()

                    iii += 1
                Next
            End If

            Me.TableLayoutPanel1.Enabled = True
        End If
    End Sub

    Private Sub PrtDocument_PrintPage(ByVal sender As Object, ByVal ev As PrintPageEventArgs) Handles PrtDocument.PrintPage

        Dim strMDSQL$ = "SELECT type_ID FROM KAgents WHERE ID=(SELECT custID FROM costs WHERE costID=" & costID & ")"
        Dim n As Integer = Me.nudSpace.Value
        Dim k As Integer = Me.nudInterval.Value
        Dim strMen$ = Module1.NonQuery1ScalarString("SELECT emplLastName + ' ' +COALESCE(emplTel, '') FROM Employees WHERE emplID=(SELECT emplID FROM Costs WHERE costID=" & costID & ")")


        ev.Graphics.DrawString("Заказ " & Module1.NonQuery1ScalarString("SELECT nomerVN FROM Costs WHERE costID=" & costID & ""), Me.Font, Brushes.Black, 20, n)
            '  n += k
            '   ev.Graphics.DrawString("Количество - " & CStr(Module1.NonQuery1Scalar("SELECT kolvo FROM Costs WHERE costID = " & costID & " ")), Me.Font, Brushes.Black, 20, n)
            n += k
            ev.Graphics.DrawString("Место- " & CStr(iii) & " из " & Me.nudQuantity.Value.ToString, Me.Font, Brushes.Black, 20, n) '100 было 220 это отступ

        If Me.cmbPrim.Text <> Nothing Then
            n += k
            ev.Graphics.DrawString("Примечание-" & Microsoft.VisualBasic.Left(Me.cmbPrim.Text, 12), Me.Font, Brushes.Black, 20, n)
            If Len(Me.cmbPrim.Text) > 12 And Len(Me.cmbPrim.Text) < 22 Then
                n += k
                ev.Graphics.DrawString(Mid(Me.cmbPrim.Text, 13, Len(Me.cmbPrim.Text)), Me.Font, Brushes.Black, 20, n)
            ElseIf Len(Me.cmbPrim.Text) > 22 Then
                n += k
                ev.Graphics.DrawString(Mid(Me.cmbPrim.Text, 23), Me.Font, Brushes.Black, 20, n)
            End If
        End If
    End Sub

    Private Sub tsbtnSettings_Click(sender As System.Object, e As System.EventArgs) Handles tsbtnSettings.Click
        PageSetupDB.Document = PrtDocument
        PageSetupDB.ShowDialog()
    End Sub

    Private Sub tsbtnViewLabel_Click(sender As System.Object, e As System.EventArgs) Handles tsbtnViewLabel.Click
        If Me.nudQuantity.Value = 0 Then
            MsgBox("Требуется ввести количество мест", MsgBoxStyle.Critical, appName)
            Me.nudQuantity.Focus()
        Else
            iii = 1

            PrintPreviewDB.Document = PrtDocument
            PrintPreviewDB.ShowDialog()
        End If
    End Sub

    Private Sub tsbtnExit_Click(sender As System.Object, e As System.EventArgs) Handles tsbtnExit.Click
        Me.Close()
    End Sub

    Private Sub nudQuantity_GotFocus(sender As Object, e As EventArgs) Handles nudQuantity.GotFocus
        sender.Select(0, (Len(sender.Value.ToString)))
    End Sub

    Private Sub nudQuantity_MouseClick(sender As Object, e As MouseEventArgs) Handles nudQuantity.MouseClick
        sender.Select(0, (Len(sender.Value.ToString)))
    End Sub

    Private Sub nudSpace_GotFocus(sender As Object, e As EventArgs) Handles nudSpace.GotFocus
        sender.Select(0, (Len(sender.Value.ToString)))
    End Sub

    Private Sub nudSpace_MouseClick(sender As Object, e As MouseEventArgs) Handles nudSpace.MouseClick
        sender.Select(0, (Len(sender.Value.ToString)))
    End Sub

    Private Sub nudInterval_GotFocus(sender As Object, e As EventArgs) Handles nudInterval.GotFocus
        sender.Select(0, (Len(sender.Value.ToString)))
    End Sub

    Private Sub nudInterval_MouseClick(sender As Object, e As MouseEventArgs) Handles nudInterval.MouseClick
        sender.Select(0, (Len(sender.Value.ToString)))
    End Sub
End Class
