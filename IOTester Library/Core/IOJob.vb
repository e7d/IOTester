Imports System.ComponentModel
Imports System.IO
Imports System.Threading

Public Class IOJob
    Implements IDisposable

    Private Const FILE_FLAG_NO_BUFFERING As FileOptions = DirectCast(&H20000000, FileOptions)
    Private RdmInit As Integer = Date.Now.Millisecond
    Private Rdm As Random

    Public Worker As IOWorker
    Private _test As IOTest
    Public ReadOnly Property Test As IOTest
        Get
            Return _test
        End Get
    End Property
    Private _results As IOResults
    Public ReadOnly Property Results As IOResults
        Get
            Return _results
        End Get
    End Property

    Public Status As IOStatus = IOStatus.Waiting
    Private Threads() As BackgroundWorker
    Private Buffer() As Byte
    Private Positions() As Long
    Private Pass As Integer = 0
    Private ReportProgress As Boolean
    Private ReportPeriod As Integer
    Private _workerProgress As Integer = -1
    Public ReadOnly Property WorkerProgress As Integer
        Get
            Return _workerProgress
        End Get
    End Property
    Private WithEvents ProgressPoller As Timer

    Private WorkerLock As New Object
    Private ThreadLock As ManualResetEvent
    Private RunningThreads As Integer

    Public Event JobStarted(ByVal _job As IOJob)
    Public Event JobProgressChanged(ByVal _job As IOJob)
    Public Event JobCompleted(ByVal _job As IOJob)
    Public Event JobAborted(ByVal _job As IOJob)

    Public Sub New(ByVal Test As IOTest, Optional ByVal ReportProgress As Boolean = False, Optional ByVal ReportPeriod As Integer = 0)
        Me._test = Test

        Me.ReportProgress = ReportProgress
        Me.ReportPeriod = ReportPeriod

        If ReportProgress Then
            ProgressPoller = New Timer(AddressOf ProgressPollerCallback)
        End If
    End Sub
#Region "IDisposable Support"
    Private disposedValue As Boolean

    Protected Overridable Sub Dispose(ByVal disposing As Boolean)
        If Not Me.disposedValue Then
            If disposing Then
                Try
                    SyncLock WorkerLock
                        File.Delete(_test.Drive & "/IOTester.tmp")
                    End SyncLock
                Catch ex As Exception
                    Throw New Exception("IOJob dispose failed.")
                End Try
                If ReportProgress Then ProgressPoller.Dispose()
            End If
        End If
        Me.disposedValue = True
    End Sub

    Public Sub Dispose() Implements IDisposable.Dispose
        Dispose(True)
        GC.SuppressFinalize(Me)
    End Sub
#End Region

#Region "Job Definitions"
    Public Sub Reset()
        SyncLock WorkerLock
            _results = Nothing
            Status = IOStatus.Waiting
            _workerProgress = -1
            Pass = 0
        End SyncLock
    End Sub

    Public Sub Prepare()
        Try
            If Status = IOStatus.Aborted Then Exit Sub

            SyncLock WorkerLock
                RaiseEvent JobProgressChanged(Me)

                Dim Buffer(1024 * 1024 - 1) As Byte
                Call FillBuffer(Buffer)

                If Not Directory.Exists(_test.Drive & "/IOTest") Then
                    Directory.CreateDirectory(_test.Drive & "/IOTest").Attributes = FileAttributes.Hidden
                End If
                Using FileStreamW As New FileStream(_test.Drive & "/IOTest/" & _test.ID & ".tmp", FileMode.Create, FileAccess.Write, FileShare.Write, CInt(Buffer.Length), FileOptions.WriteThrough Or FILE_FLAG_NO_BUFFERING)
                    For i As Integer = 0 To (_test.Size.Size / (1024 * 1024))
                        FileStreamW.Write(Buffer, 0, Buffer.Length)
                    Next
                End Using
            End SyncLock
        Catch ex As Exception
            Throw New Exception("IOJob creation failed.")
        End Try
    End Sub

    Public Sub Process()
        Try
            If Status = IOStatus.Aborted Then Exit Sub

            SyncLock WorkerLock
                'Lock
                ThreadLock = New ManualResetEvent(False)

                'Raise Start Event
                Status = IOStatus.Processing
                RaiseEvent JobStarted(Me)

                'Initialisation
                Call Prepare()

                _results = New IOResults()
                _results.Timer.Reset()

                ReDim Buffer(_test.BufferSize.Size - 1)
                ReDim Threads(_test.QueueDepth)
                For i = 0 To _test.QueueDepth - 1
                    Threads(i) = New BackgroundWorker
                    AddHandler Threads(i).DoWork, AddressOf Process_DoWork
                Next
                If Not Test.Sequential Then Positions = PreparePositions(_test)
                Call FillBuffer(Buffer)

                'Start Timer
                If ReportProgress Then ProgressPoller.Change(0, ReportPeriod)
                _results.Timer.Start()

                'Run Threads
                RunningThreads = _test.QueueDepth
                For i = 0 To _test.QueueDepth - 1
                    Threads(i).RunWorkerAsync()
                Next
                ThreadLock.WaitOne()

                'Stop Timer
                _results.Timer.Stop()
                If ReportProgress Then ProgressPoller.Change(Timeout.Infinite, 0)
                Call Clean()

                'Raise Stop Event
                If Status = IOStatus.Aborted Then
                    RaiseEvent JobAborted(Me)
                Else
                    Status = IOStatus.Done
                    RaiseEvent JobCompleted(Me)
                End If
            End SyncLock
        Catch ex As Exception
            Status = IOStatus.Error
            Throw New Exception("IOJob work failed.")
        Finally
            If Status = IOStatus.Done OrElse Status = IOStatus.Aborted OrElse IOStatus.Error Then Clean()
        End Try
    End Sub
    Public Sub Process_DoWork()
        Try
            If Status = IOStatus.Aborted Then Exit Sub

            Select Case _test.Direction
                Case IODirection.Read
                    Using FileStreamR As New FileStream(_test.Drive & "/IOTest/" & _test.ID & ".tmp", FileMode.Open, FileAccess.Read, FileShare.Read, CInt(Buffer.Length), FileOptions.WriteThrough Or FILE_FLAG_NO_BUFFERING)
                        While Interlocked.Increment(Pass) < _test.Count And Not Status = IOStatus.Aborted
                            Try
                                'If Not Test.Sequential Then FileStreamR.Position = Positions(Pass)
                                If Not Test.Sequential Then FileStreamR.Seek(Positions(Pass), SeekOrigin.Begin)
                                FileStreamR.Read(Buffer, 0, Buffer.Length)
                                'System.Text.Encoding.Default.GetString(Buffer)
                                'FileStreamR.Flush(True)

                                _workerProgress = Pass * 100 / _test.Count
                                _results.Count = Pass
                                _results.Size = Pass * _test.BufferSize.Size
                            Catch ex As Exception
                                Throw New Exception("IOJob read pass failed.")
                            End Try
                        End While
                    End Using
                Case IODirection.Write
                    Using FileStreamW As New FileStream(_test.Drive & "/IOTest/" & _test.ID & ".tmp", FileMode.Open, FileAccess.Write, FileShare.Write, CInt(Buffer.Length), FileOptions.WriteThrough Or FILE_FLAG_NO_BUFFERING)
                        'OPTIONS: 
                        ' - FileOptions.WriteThrough Or FILE_FLAG_NO_BUFFERING
                        ' - FileOptions.Asynchronous

                        While Interlocked.Increment(Pass) < _test.Count And Not Status = IOStatus.Aborted
                            Try
                                'If Not Test.Sequential Then FileStreamW.Position = Positions(Pass)
                                If Not Test.Sequential Then FileStreamW.Seek(Positions(Pass), SeekOrigin.Begin)
                                FileStreamW.Write(Buffer, 0, Buffer.Length)
                                'FileStreamW.Flush(True)

                                _workerProgress = Pass * 100 / _test.Count
                                _results.Count = Pass
                                _results.Size = Pass * _test.BufferSize.Size
                            Catch ex As Exception
                                Throw New Exception("IOJob read pass failed.")
                            End Try
                        End While
                    End Using
            End Select

            If (Interlocked.Decrement(RunningThreads) = 0) Then ThreadLock.Set()
        Catch ex As Exception
            Status = IOStatus.Error
            Throw New Exception("IOJob work failed.")
        End Try
    End Sub

    Private Sub Clean()
        If File.Exists(_test.Drive & "IOTest\" & _test.ID & ".tmp") Then File.Delete(_test.Drive & "IOTest\" & _test.ID & ".tmp")
    End Sub

    Public Sub Abort()
        Status = IOStatus.Aborted
    End Sub
#End Region

#Region "Job Poller"
    Sub ProgressPollerCallback(ByVal ProgressPollerState As Object)
        RaiseEvent JobProgressChanged(Me)
    End Sub
#End Region

#Region "Low level File Methods"
    Private Sub FillBuffer(ByRef Buffer() As Byte)
        Rdm = New Random(RdmInit)
        RdmInit += 1
        Rdm.NextBytes(Buffer)
    End Sub

    Private Function PreparePositions(ByVal Test As IOTest) As Long()
        Dim Positions(Math.Max(Test.Count - 1, 0)) As Long

        Try
            For i As Integer = 0 To Positions.Length - 1
                Positions(i) = i * Test.BufferSize.Size
            Next

            If Not Test.Sequential Then
                Dim Rdm As New Random()

                Dim i, j As Integer
                Dim tmp As Long
                For i = 0 To Positions.Length - 1
                    j = Rdm.Next(Positions.Length)

                    tmp = Positions(i)
                    Positions(i) = Positions(j)
                    Positions(j) = tmp
                Next
            End If
        Catch ex As Exception
        End Try

        Return Positions
    End Function
#End Region

End Class