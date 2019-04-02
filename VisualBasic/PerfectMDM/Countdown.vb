Public Class Countdown
    Private _value As TimeSpan

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        _value = _value + TimeSpan.FromSeconds(1)
        Label1.Text = _value.ToString()
    End Sub

    Public Sub Start()
        Timer1.Start()
    End Sub

    Public Sub [Stop]()
        Timer1.Stop()
    End Sub

    Public ReadOnly Property IsStarted() As Boolean
        Get
            Return Timer1.Enabled
        End Get
    End Property

    Public Property Value() As Double
        Get
            Return _value.TotalHours
        End Get
        Set(val As Double)
            Dim t As TimeSpan
            t = TimeSpan.FromHours(val)
            _value = t
            Label1.Text = _value.ToString()
        End Set
    End Property
End Class
