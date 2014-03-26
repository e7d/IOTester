Public Class IOTest
    Public ID As String = Guid.NewGuid.ToString
    Public Name As String = ""
    Public Direction As IODirection = IODirection.Read
    Public Drive As String
    Public Size As Bytes
    Public ReadOnly Property Count As Long
        Get
            Return Math.Ceiling(Size.Size / BufferSize.Size)
        End Get
    End Property
    Public BufferSize As Bytes
    Public QueueDepth As Integer
    Public Sequential As Boolean
End Class

Public Class IOResults
    Public WithEvents Timer As StopwatchEvents
    Public Count As Integer
    Public Size As Long
    Private _velocity As Integer
    Public ReadOnly Property Velocity As Double
        Get
            Return Math.Round(Count / (Timer.Elapsed.TotalMilliseconds / 1000), 2)
        End Get
    End Property
    Private _bitrate As Bytes
    Public ReadOnly Property Bitrate As Bytes
        Get
            Return New Bytes(Math.Round(Size / (Timer.Elapsed.TotalMilliseconds / 1000), 2))
        End Get
    End Property
    Public Sub New()
        Timer = New StopwatchEvents()
    End Sub
End Class

Public Enum IODirection As Integer
    Read = 1
    Write = 2
End Enum
Public Enum IODataType
    Random
    Zero
    One
End Enum
Public Enum IOStatus As Integer
    [Error] = -1
    Waiting = 0
    Processing = 1
    Done = 2
    Aborted = 3
    Postponed = 3
End Enum