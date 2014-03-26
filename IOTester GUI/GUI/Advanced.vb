Imports IOTester

Public Class Advanced
    Private WithEvents Benchmark As IOBenchmark

    Public Delegate Sub UpdateStartDlg(ByVal Job As IOJob)
    Public UpdateStart As UpdateStartDlg = AddressOf UpdateStartCallback
    Private UpdateStartLock As New Object
    Public Delegate Sub UpdateProgressDlg(ByVal Job As IOJob, ByVal Progress As Integer)
    Public UpdateProgress As UpdateProgressDlg = AddressOf UpdateProgressCallback
    Private UpdateProgressLock As New Object
    Public Delegate Sub UpdateResultsDlg(ByVal Job As IOJob)
    Public UpdateResults As UpdateResultsDlg = AddressOf UpdateResultsCallback
    Private UpdateResultsLock As New Object
    Public Delegate Sub UpdateEndDlg(ByVal Job As IOJob)
    Public UpdateEnd As UpdateEndDlg = AddressOf UpdateEndCallback
    Private UpdateEndLock As New Object
    Public Delegate Sub ResetResultsDlg()
    Public ResetResults As UpdateResultsDlg = AddressOf ResetResultsCallback
    Private ResetResultsLock As New Object

    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Benchmark = New IOBenchmark()
#If DEBUG Then
        'Benchmark.AddJob(New IOJob(New IOTest() With {.Name = "1GB Sequential Read", .Drive = "C:\", .Direction = IODirection.Read, .BufferSize = New Bytes("32MB"), .Size = New Bytes("1GB"), .Sequential = True}, True, 1000))
        'Benchmark.AddJob(New IOJob(New IOTest() With {.Name = "1GB Sequential Write", .Drive = "C:\", .Direction = IODirection.Write, .BufferSize = New Bytes("32MB"), .Size = New Bytes("1GB"), .Sequential = True}, True, 1000))
        'Benchmark.AddJob(New IOJob(New IOTest() With {.Name = "1GB 512K Read", .Drive = "C:\", .Direction = IODirection.Read, .BufferSize = New Bytes("512KB"), .Size = New Bytes("1GB"), .Sequential = False}, True, 1000))
        'Benchmark.AddJob(New IOJob(New IOTest() With {.Name = "1GB 512K Write", .Drive = "C:\", .Direction = IODirection.Write, .BufferSize = New Bytes("512KB"), .Size = New Bytes("1GB"), .Sequential = False}, True, 1000))
        'Benchmark.AddJob(New IOJob(New IOTest() With {.Name = "1GB 4K Read", .Drive = "C:\", .Direction = IODirection.Read, .BufferSize = New Bytes("4KB"), .Size = New Bytes("1GB"), .Sequential = False}, True, 1000))
        'Benchmark.AddJob(New IOJob(New IOTest() With {.Name = "1GB 4K Write", .Drive = "C:\", .Direction = IODirection.Write, .BufferSize = New Bytes("4KB"), .Size = New Bytes("1GB"), .Sequential = False}, True, 1000))
#End If
    End Sub

#Region "Main ToolStrip Menu"
    Private Sub NewToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewToolStripMenuItem.Click
        Benchmark = New IOBenchmark()
        ListViewJobs.Items.Clear()
    End Sub

    Private Sub OpenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenToolStripMenuItem.Click
        OpenFileDialogLoad.ShowDialog()
    End Sub
    Private Sub OpenFileDialogLoad_FileOk() Handles OpenFileDialogLoad.FileOk
        Benchmark = ConfigurationFile.ParseConfigurationFile(OpenFileDialogLoad.FileName)

        For Each Worker As IOWorker In Benchmark.Workers.Values
            For Each Job As IOJob In Worker.Jobs
                Try
                    If Not Job Is Nothing Then
                        Dim ID As Guid = Guid.NewGuid()

                        Dim NewItem As New ListViewItem({ _
                            New ListViewItem.ListViewSubItem() With {.Name = "Name", .Text = Job.Test.Name}, _
                            New ListViewItem.ListViewSubItem() With {.Name = "Direction", .Text = Job.Test.Direction.ToString}, _
                            New ListViewItem.ListViewSubItem() With {.Name = "Drive", .Text = Job.Test.Drive}, _
                            New ListViewItem.ListViewSubItem() With {.Name = "Size", .Text = Job.Test.Size.ToString}, _
                            New ListViewItem.ListViewSubItem() With {.Name = "BufferSize", .Text = Job.Test.BufferSize.ToString}, _
                            New ListViewItem.ListViewSubItem() With {.Name = "QueueDepth", .Text = Job.Test.QueueDepth.ToString}, _
                            New ListViewItem.ListViewSubItem() With {.Name = "Sequential", .Text = IIf(Job.Test.Sequential, "Yes", "No")}, _
                            New ListViewItem.ListViewSubItem() With {.Name = "Status", .Text = "Waiting"}, _
                            New ListViewItem.ListViewSubItem() With {.Name = "Owner", .Text = ""}, _
                            New ListViewItem.ListViewSubItem() With {.Name = "Start", .Text = ""}, _
                            New ListViewItem.ListViewSubItem() With {.Name = "End", .Text = ""}, _
                            New ListViewItem.ListViewSubItem() With {.Name = "Bandwidth", .Text = ""}, _
                            New ListViewItem.ListViewSubItem() With {.Name = "Velocity", .Text = ""}, _
                            New ListViewItem.ListViewSubItem() With {.Name = "ID", .Text = ID.ToString}, _
                            New ListViewItem.ListViewSubItem() With {.Name = "StatusWindow", .Tag = New Status()} _
                        }, 0) With {.Tag = New IOJob(New IOTest() With { _
                            .ID = ID.ToString, _
                            .Name = Job.Test.Name, _
                            .Drive = Job.Test.Drive, _
                            .Direction = Job.Test.Direction, _
                            .BufferSize = Job.Test.BufferSize, _
                            .QueueDepth = Job.Test.QueueDepth, _
                            .Size = Job.Test.Size, _
                            .Sequential = Job.Test.Sequential _
                        }, True, 1000)}

                        ListViewJobs.Items.Add(NewItem)
                    End If
                Catch Ex As Exception

                End Try
            Next
        Next
    End Sub

    Private Sub SaveToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveToolStripMenuItem.Click
        'To-Do
    End Sub

    Private Sub SaveAsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveAsToolStripMenuItem.Click
        'To-Do
    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        Application.Exit()
    End Sub

    Private Sub SimpleModeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AdvancedModeToolStripMenuItem.Click
        Simple.Show()
        Me.Close()
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        About.ShowDialog()
    End Sub
#End Region

#Region "Items List"
    Private Sub ListViewJobs_DoubleClick(sender As Object, e As EventArgs) Handles ListViewJobs.DoubleClick
        For Each Item As ListViewItem In ListViewJobs.SelectedItems
            CType(Item.SubItems("StatusWindow").Tag, Status).Show()
            CType(Item.SubItems("StatusWindow").Tag, Status).Focus()
        Next
    End Sub
#End Region

#Region "Items ToolStrip Menu"
    Private Sub ContextMenuStripJobs_Opening(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles ContextMenuStripJobs.Opening
        ToolStripMenuItemDeleteJob.Enabled = (ListViewJobs.SelectedItems.Count > 0)
        ToolStripMenuItemChangeStatus.Enabled = (ListViewJobs.SelectedItems.Count > 0)

        If ListViewJobs.SelectedItems.Count = 1 Then
            ToolStripMenuItemProcessJob.Enabled = CType(ListViewJobs.SelectedItems(0).Tag, IOJob).Status = IOStatus.Waiting
            ToolStripMenuItemAbortJob.Enabled = CType(ListViewJobs.SelectedItems(0).Tag, IOJob).Status = IOStatus.Processing
        Else
            ToolStripMenuItemProcessJob.Enabled = False
            ToolStripMenuItemAbortJob.Enabled = False
        End If
    End Sub

    Private Sub ToolStripMenuItemAddJob_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItemAddJob.Click
        AddJob.ShowDialog(Me)
    End Sub

    Private Sub ToolStripMenuItemDeleteJob_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItemDeleteJob.Click
        For Each Item As ListViewItem In ListViewJobs.SelectedItems
            ListViewJobs.Items.Remove(Item)
        Next
    End Sub

    Private Sub StartToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItemProcessJob.Click
        'To-Do
    End Sub
    Private Sub AbortToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItemAbortJob.Click
        For Each Item As ListViewItem In ListViewJobs.SelectedItems
            CType(Item.Tag, IOJob).Abort()
        Next
    End Sub

    Private Sub PostPonedToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItemPostPoned.Click
        For Each Item As ListViewItem In ListViewJobs.SelectedItems
            Item.SubItems("Status").Text = "Postponed"
        Next
    End Sub

    Private Sub WaitingToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItemWaiting.Click
        For Each Item As ListViewItem In ListViewJobs.SelectedItems
            Item.SubItems("Status").Text = "Waiting"
            CType(Item.Tag, IOJob).Reset()
            CType(Item.SubItems("StatusWindow").Tag, Status).TextBoxBandwidth.Clear()
            CType(Item.SubItems("StatusWindow").Tag, Status).TextBoxVelocity.Clear()
            CType(Item.SubItems("StatusWindow").Tag, Status).TextBoxTimeElapsed.Clear()
            CType(Item.SubItems("StatusWindow").Tag, Status).TextBoxTimeRemaining.Clear()
            Item.SubItems("Start").Text = ""
            Item.SubItems("End").Text = ""
            Item.SubItems("Bandwidth").Text = ""
            Item.SubItems("Velocity").Text = ""
        Next
    End Sub
#End Region

#Region "Items Buttons"
    Private Sub ButtonBenchmark_Click(sender As Object, e As EventArgs) Handles ButtonBenchmarkStart.Click
        Benchmark.Reset()
        For Each Item As ListViewItem In ListViewJobs.Items
            If Item.SubItems("Status").Text = "Waiting" Then
                Benchmark.AddJob(CType(Item.Tag, IOJob))
            End If
        Next
        Benchmark.Start()
    End Sub

    Private Sub ButtonBenchmarkStop_Click(sender As Object, e As EventArgs) Handles ButtonBenchmarkStop.Click
        Benchmark.Stop()
    End Sub
#End Region

#Region "Job Handlers"
    Private Sub Benchmark_JobStarted(ByVal Job As IOJob) Handles Benchmark.JobStarted
        Me.BeginInvoke(UpdateStart, Job)
    End Sub
    Private Sub Benchmark_ProgressChanged(ByVal Job As IOJob) Handles Benchmark.JobProgressChanged
        If Job.WorkerProgress > 0 Then Me.BeginInvoke(UpdateResults, Job)
        Me.BeginInvoke(UpdateProgress, Job, Job.WorkerProgress)
    End Sub
    Private Sub Benchmark_JobCompleted(ByVal Job As IOJob) Handles Benchmark.JobCompleted, Benchmark.JobAborted
        Me.BeginInvoke(UpdateEnd, Job)
        Me.BeginInvoke(UpdateResults, Job)
        Me.BeginInvoke(UpdateProgress, Job, 100)
    End Sub
    Private Sub Benchmark_BenchmarkCompleted() Handles Benchmark.BenchmarkCompleted
        'To-Do
    End Sub
#End Region

#Region "GUI Delegates"
    Private Sub UpdateStartCallback(ByVal Job As IOJob)
        SyncLock UpdateStartLock
            For Each Item As ListViewItem In ListViewJobs.Items
                If Job.Test.ID = Item.SubItems("ID").Text Then
                    Item.SubItems("Start").Text = Now.ToLocalTime()
                    CType(Item.SubItems("StatusWindow").Tag, Status).Show()
                End If
            Next
        End SyncLock
    End Sub
    Private Sub UpdateProgressCallback(ByVal Job As IOJob, ByVal Progress As Integer)
        SyncLock UpdateProgressLock
            For Each Item As ListViewItem In ListViewJobs.Items
                If Job.Test.ID = Item.SubItems("ID").Text Then
                    If Job.Status = IOStatus.Waiting Then
                        Item.SubItems("Status").Text = "Waiting"

                        CType(Item.SubItems("StatusWindow").Tag, Status).Text = "Status: Waiting"
                        CType(Item.SubItems("StatusWindow").Tag, Status).ProgressBarJob.Value = 0
                    ElseIf Job.Status = IOStatus.Processing Then
                        If Progress < 0 Then
                            Item.SubItems("Status").Text = "Preparing"

                            CType(Item.SubItems("StatusWindow").Tag, Status).Text = "Status: Preparing..."
                            CType(Item.SubItems("StatusWindow").Tag, Status).ProgressBarJob.Value = 0
                        ElseIf Progress >= 0 AndAlso Progress < 100 Then
                            Item.SubItems("Status").Text = "Processing"

                            CType(Item.SubItems("StatusWindow").Tag, Status).Text = "Status: " & Progress & "%"
                            CType(Item.SubItems("StatusWindow").Tag, Status).ProgressBarJob.Value = Progress

                            Dim Elapsed As Integer = (Now - Date.Parse(Item.SubItems("Start").Text)).TotalSeconds
                            Dim Remaining As Integer = IIf(Progress > 0, (Elapsed * 100 / Progress) - Elapsed, 0)
                            CType(Item.SubItems("StatusWindow").Tag, Status).TextBoxTimeElapsed.Text = New TimeSpan(0, 0, Elapsed).ToString()
                            CType(Item.SubItems("StatusWindow").Tag, Status).TextBoxTimeRemaining.Text = New TimeSpan(0, 0, Remaining).ToString()
                        End If
                    ElseIf Job.Status = IOStatus.Done Then
                        Item.SubItems("Status").Text = "Done"

                        CType(Item.SubItems("StatusWindow").Tag, Status).Text = "Status: Done"
                        CType(Item.SubItems("StatusWindow").Tag, Status).ProgressBarJob.Value = 100
                    ElseIf Job.Status = IOStatus.Aborted Then
                        Item.SubItems("Status").Text = "Aborted"

                        CType(Item.SubItems("StatusWindow").Tag, Status).Text = "Status: Aborted"
                        CType(Item.SubItems("StatusWindow").Tag, Status).ProgressBarJob.Value = 100
                    ElseIf Job.Status = IOStatus.Error Then
                        Item.SubItems("Status").Text = "Error"

                        CType(Item.SubItems("StatusWindow").Tag, Status).Text = "Status: Error"
                        CType(Item.SubItems("StatusWindow").Tag, Status).ProgressBarJob.Value = 0
                    End If
                End If
            Next
        End SyncLock
    End Sub
    Private Sub UpdateResultsCallback(ByVal Job As IOJob)
        SyncLock UpdateResultsLock
            For Each Item As ListViewItem In ListViewJobs.Items
                If Job.Test.ID = Item.SubItems("ID").Text Then
                    Item.SubItems("Bandwidth").Text = Job.Results.Bitrate.Value.ToString("0.00") & " " & Job.Results.Bitrate.Unit.ToString & "/s"
                    Item.SubItems("Velocity").Text = Job.Results.Velocity.ToString("0.00") & " IO/s"

                    CType(Item.SubItems("StatusWindow").Tag, Status).TextBoxBandwidth.Text = Job.Results.Bitrate.Value.ToString("0.00") & " " & Job.Results.Bitrate.Unit.ToString & "/s"
                    CType(Item.SubItems("StatusWindow").Tag, Status).TextBoxVelocity.Text = Job.Results.Velocity.ToString("0.00") & " IO/s"
                End If
            Next
        End SyncLock
    End Sub
    Private Sub UpdateEndCallback(ByVal Job As IOJob)
        For Each Item As ListViewItem In ListViewJobs.Items
            If Job.Test.ID = Item.SubItems("ID").Text Then
                Item.SubItems("End").Text = Now.ToLocalTime()
                CType(Item.SubItems("StatusWindow").Tag, Status).Hide()
            End If
        Next
    End Sub
    Private Sub ResetResultsCallback()
        SyncLock ResetResultsLock
            'To-Do
        End SyncLock
    End Sub
#End Region
End Class