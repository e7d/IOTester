Imports System.Threading

Public Class IOBenchmark
    Public Workers As New Dictionary(Of String, IOWorker)

    Public ReadOnly Property Status As IOStatus
        Get
            Dim _status As IOStatus = IOStatus.Done
            For Each _worker As IOWorker In Workers.Values
                If _worker.Status < _status Then
                    _status = _worker.Status
                    If _status = IOStatus.Error Then Exit For
                End If
            Next
            Return _status
        End Get
    End Property

    Public Event JobStarted(ByVal Job As IOJob)
    Public Event JobProgressChanged(ByVal Job As IOJob)
    Public Event JobCompleted(ByVal Job As IOJob)
    Public Event JobAborted(ByVal Job As IOJob)
    Public Event WorkerCompleted(ByVal Worker As IOWorker)
    Public Event BenchmarkAborted(ByVal Benchmark As IOBenchmark)
    Public Event BenchmarkCompleted(ByVal Benchmark As IOBenchmark)

    Public Sub New()
        AddWorker("Worker0", IOWorker.WorkerType.Normal)
    End Sub

    Public Function AddWorker() As Boolean
        Return AddWorker("Worker" + Workers.Count.ToString, IOWorker.WorkerType.Normal)
    End Function
    Public Function AddTemporaryWorker() As Boolean
        Return True
        Return AddWorker("TemporaryWorker" + Workers.Count.ToString, IOWorker.WorkerType.Temporary)
    End Function
    Public Function AddWorker(ByVal Name As String, ByVal Type As IOWorker.WorkerType) As Boolean
        If Not Workers.ContainsKey(Name) Then
            Dim Worker As New IOWorker(Name, Type)
            AddHandler Worker.WorkerCompleted, AddressOf Worker_WorkerCompleted

            Workers.Add(Name, Worker)

            Return True
        End If
        Return False
    End Function
    Public Function RemoveWorker(ByVal Name As String) As Boolean
        If Workers.ContainsKey(Name) AndAlso Workers.Count > 1 Then
            Workers.Remove(Name)
            Return True
        End If

        Return False
    End Function

    Public Sub AddJob(ByVal Job As IOJob)
        AddJob("Worker0", Job)
    End Sub
    Public Sub AddJob(ByVal WorkerName As String, ByVal Job As IOJob)
        If Workers.ContainsKey(WorkerName) Then
            AddHandler Job.JobStarted, AddressOf Job_JobStarted
            AddHandler Job.JobProgressChanged, AddressOf Job_JobProgressChanged
            AddHandler Job.JobCompleted, AddressOf Job_JobCompleted
            AddHandler Job.JobAborted, AddressOf Job_JobAborted

            Workers(WorkerName).AddJob(Job)
        End If
    End Sub

    Public Sub Start()
        For Each Worker As IOWorker In Workers.Values
            Start(Worker.Name)
        Next
    End Sub
    Public Sub Start(ByVal WorkerName As String)
        If Workers.ContainsKey(WorkerName) Then
            Workers(WorkerName).Process()
        End If
    End Sub

    Public Sub [Stop]()
        For Each Worker As IOWorker In Workers.Values
            If Worker.Status = IOStatus.Processing OrElse Worker.Status = IOStatus.Waiting Then
                Call [Stop](Worker.Name)
            End If
        Next

        RaiseEvent BenchmarkAborted(Me)
    End Sub
    Public Sub [Stop](ByVal WorkerName As String)
        If Workers.ContainsKey(WorkerName) AndAlso Workers(WorkerName).Status = IOStatus.Processing Then
            Workers(WorkerName).Abort()
        End If
    End Sub
    Public Sub Reset()
        For Each Worker As IOWorker In Workers.Values
            Reset(Worker.Name)
        Next
    End Sub
    Public Sub Reset(ByVal WorkerName As String)
        If Workers.ContainsKey(WorkerName) Then
            Workers(WorkerName).ResetQueue()
        End If
    End Sub

    Private Sub Job_JobStarted(ByVal Job As IOJob)
        RaiseEvent JobStarted(Job)
    End Sub
    Private Sub Job_JobProgressChanged(ByVal Job As IOJob)
        RaiseEvent JobProgressChanged(Job)
    End Sub
    Private Sub Job_JobCompleted(ByVal Job As IOJob)
        RaiseEvent JobCompleted(Job)
    End Sub
    Private Sub Job_JobAborted(ByVal Job As IOJob)
        RaiseEvent JobAborted(Job)
    End Sub
    Private Sub Worker_WorkerCompleted(ByVal Worker As IOWorker)
        If Worker.Type = IOWorker.WorkerType.Temporary Then
            If Not RemoveWorker(Worker.Name) Then
                Throw New Exception("Could not delete temporary worker.")
            End If
        End If
        RaiseEvent WorkerCompleted(Worker)

        If Me.Status = IOStatus.Done Then RaiseEvent BenchmarkCompleted(Me)
    End Sub
End Class
