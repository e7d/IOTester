Public Class Errors
    Public Enum Severity
        Debug
        Info
        Warn
        [Error]
    End Enum

    Public Shared Event Message(ByVal Text As String, ByVal Severity As Severity)

    Public Shared Sub Log(ByVal Text As String)
        Info(Text)
    End Sub

    Public Shared Sub Debug(ByVal Text As String)
        RaiseEvent Message(Text, Severity.Debug)
    End Sub

    Public Shared Sub Info(ByVal Text As String)
        RaiseEvent Message(Text, Severity.Info)
    End Sub

    Public Shared Sub Warn(ByVal Text As String)
        RaiseEvent Message(Text, Severity.Warn)
    End Sub

    Public Shared Sub [Error](ByVal Text As String)
        RaiseEvent Message(Text, Severity.Error)
    End Sub
End Class
