Public Class StopwatchEvents
    Inherits Stopwatch

    Public Event Resetted()
    Public Event Restarted()
    Public Event Started()
    Public Event Stopped()

    Public Overloads Sub Reset()
        MyBase.Reset()
        RaiseEvent Resetted()
    End Sub

    Public Overloads Sub Restart()
        MyBase.Reset()
        MyBase.Start()
        RaiseEvent Restarted()
    End Sub

    Public Overloads Sub Start()
        MyBase.Start()
        RaiseEvent Started()
    End Sub

    Public Overloads Sub [Stop]()
        MyBase.Stop()
        RaiseEvent Stopped()
    End Sub
End Class
