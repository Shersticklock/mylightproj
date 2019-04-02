Public Class frmTimerExit

    Dim i As Integer = 1
    Dim n As Integer = 30

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Select Case n - i
            Case Is > 20
                Me.BackColor = Color.Lime
            Case Is > 10
                Me.BackColor = Color.Yellow
            Case Else
                Me.BackColor = Color.Red
        End Select

        If i = n Then
            Application.Exit()
        Else
            ttt()
        End If
    End Sub

    Private Sub ttt()
        Me.Label1.Text = CStr(n - i)
        i += 1
        Me.Timer1.Start()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        yyy()

        Me.Dispose()
        '  Me.Close()
    End Sub

    Private Sub frmTimerExit_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        yyy()
    End Sub

    Private Sub yyy()
        frmMainForm.Timer3.Stop()
        frmMainForm.Timer3.Interval = 180000
        frmMainForm.Timer3.Start()
    End Sub

    Private Sub frmTimerExit_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Button1.Focus()
    End Sub
End Class