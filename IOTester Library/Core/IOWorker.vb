Imports System.Threading

Public Class IOWorker
    Public Enum WorkerType
        Normal
        Temporary
    End Enum

    Public Jobs As List(Of IOJob)
    Private WithEvents Thread As Thread

    Private _name As String = ""
    Public ReadOnly Property Name As String
        Get
            Return _name
        End Get
    End Property
    Private _status As IOStatus = IOStatus.Waiting
    Public ReadOnly Property Status As IOStatus
        Get
            Return _status
        End Get
    End Property
    Private _type As IOWorker.WorkerType = IOWorker.WorkerType.Normal
    Public ReadOnly Property Type As IOWorker.WorkerType
        Get
            Return _type
        End Get
    End Property

    Public Event WorkerCompleted(ByVal Worker As IOWorker)
    Public Event WorkerFailed(ByVal Worker As IOWorker)
    Public Event WorkerAborted(ByVal Worker As IOWorker)

    Public Sub New(ByVal Name As String, ByVal Type As IOWorker.WorkerType)
        Me._name = Name
        Me._type = Type
        Jobs = New List(Of IOJob)
    End Sub

    Public Sub AddJob(ByVal Job As IOJob)
        Job.Worker = Me
        Jobs.Add(Job)
    End Sub

    Public Sub Process()
        Thread = New Thread(AddressOf Thread_Process)
        Thread.Start()
    End Sub
    Public Sub Thread_Process()
        Try
            If Me._status = IOStatus.Waiting Then
                Me._status = IOStatus.Processing

                For Each Job As IOJob In Jobs
                    If Me._status = IOStatus.Processing AndAlso Job.Status = IOStatus.Waiting Then
                        Job.Process()
                    End If
                Next

                Me._status = IOStatus.Done
                RaiseEvent WorkerCompleted(Me)
            End If
        Catch Ex As Exception
            Me._status = IOStatus.Error

            Errors.Error("Worker Process Error")
            RaiseEvent WorkerFailed(Me)
        End Try
    End Sub
    Public Sub Abort()
        Try
            Me._status = IOStatus.Aborted

            For Each Job As IOJob In Jobs
                If Job.Status = IOStatus.Processing OrElse Job.Status = IOStatus.Waiting Then
                    Job.Abort()
                End If
            Next

            RaiseEvent WorkerAborted(Me)
        Catch Ex As Exception
            Me._status = IOStatus.Error

            Errors.Error("Worker Abort Error")
            RaiseEvent WorkerFailed(Me)
        End Try
    End Sub
    Public Sub Skip()
        Try
            For Each Job As IOJob In Jobs
                If Job.Status = IOStatus.Processing Then
                    Job.Abort()
                End If
            Next
        Catch Ex As Exception
            Me._status = IOStatus.Error

            Errors.Error("Worker Skip Error")
            RaiseEvent WorkerFailed(Me)
        End Try
    End Sub
    Public Sub ResetQueue()
        Me._status = IOStatus.Waiting
        Jobs.Clear()
    End Sub
End Class
