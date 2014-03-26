Imports System.IO
Imports IOTester

Imports System.Security.Principal
Imports System.Text

Public Class Simple
    Private WithEvents Benchmark As IOBenchmark

    Private BenchmarkDrive As String
    Private BenchmarkBufferSize As Bytes
    Private BenchmarkQueueDepth As Integer
    Private BenchmarkSize As Bytes
    Private BenchmarkSequential As Boolean

    Public Delegate Sub UpdateSetupDlg(ByVal Enabled As Boolean)
    Public UpdateSetup As UpdateSetupDlg = AddressOf UpdateSetupCallback
    Private UpdateSetupLock As New Object
    Public Delegate Sub UpdateProgressDlg(ByVal Progress As Integer)
    Public UpdateProgress As UpdateProgressDlg = AddressOf UpdateProgressCallback
    Private UpdateProgressLock As New Object
    Public Delegate Sub UpdateResultsDlg(ByVal Job As IOJob)
    Public UpdateResults As UpdateResultsDlg = AddressOf UpdateResultsCallback
    Private UpdateResultsLock As New Object

    Public Sub New()
        ' Security, requires admin rights
        If Security.IsVistaOrHigher AndAlso Not Security.IsAdmin Then
            Security.RestartElevated()
        End If

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        For Each LogicalDrive As String In Directory.GetLogicalDrives()
            ComboBoxDriveValue.Items.Add(LogicalDrive)
        Next
        ComboBoxDriveValue.SelectedItem = "C:\"
        ComboBoxSizeValue.SelectedItem = "1GB"
    End Sub

    Private Sub CopyToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CopyToolStripMenuItem.Click
        Dim Clipboard As New StringBuilder()
        Clipboard.AppendLine(My.Application.Info.ProductName & " " & My.Application.Info.Version.ToString & " - " & My.Application.Info.Copyright.Replace("©", "(c)"))
        Clipboard.AppendLine("* 1 KB/s = 1,024 bytes/s")
        Clipboard.AppendLine()
        Clipboard.AppendLine("Size: " & ComboBoxSizeValue.Text)
        Clipboard.AppendLine("Drive: " & ComboBoxDriveValue.Text)
        Clipboard.AppendLine("Date: " & Now.ToString("yyyy-MM-dd HH:mm:ss"))
        Clipboard.AppendLine("System: " & System.Environment.OSVersion.ToString)
        Clipboard.AppendLine()
        Clipboard.Append(CStr("Test").PadRight("44"))
        Clipboard.Append(CStr("Bandwidth").PadLeft("15"))
        Clipboard.Append(CStr("Velocity").PadLeft("20"))
        Clipboard.AppendLine()
        Clipboard.Append(CStr("Sequential Read").PadRight("44"))
        Clipboard.Append(CStr(LabelReadSequentialBandwidthValue.Text & " " & LabelReadSequentialBandwidthUnit.Text).PadLeft("15"))
        Clipboard.Append(CStr("-").PadLeft("20"))
        Clipboard.AppendLine()
        Clipboard.Append(CStr("Sequential Write").PadRight("44"))
        Clipboard.Append(CStr(LabelWriteSequentialBandwidthValue.Text & " " & LabelWriteSequentialBandwidthUnit.Text).PadLeft("15"))
        Clipboard.Append(CStr("-").PadLeft("20"))
        Clipboard.AppendLine()
        Clipboard.Append(CStr("Random 512K Read").PadRight("44"))
        Clipboard.Append(CStr(LabelRead512KBBandwidthValue.Text & " " & LabelRead512KBBandwidthUnit.Text).PadLeft("15"))
        Clipboard.Append(CStr("-").PadLeft("20"))
        Clipboard.AppendLine()
        Clipboard.Append(CStr("Random 512K Write").PadRight("44"))
        Clipboard.Append(CStr(LabelWrite512KBBandwidthValue.Text & " " & LabelWrite512KBBandwidthUnit.Text).PadLeft("15"))
        Clipboard.Append(CStr("-").PadLeft("20"))
        Clipboard.AppendLine()
        Clipboard.Append(CStr("Random 4K Read").PadRight("44"))
        Clipboard.Append(CStr(LabelRead4KBBandwidthValue.Text & " " & LabelRead4KBBandwidthUnit.Text).PadLeft("15"))
        Clipboard.Append(CStr(LabelRead4KBVelocityValue.Text & " IO/s").PadLeft("20"))
        Clipboard.AppendLine()
        Clipboard.Append(CStr("Random 4K Write").PadRight("44"))
        Clipboard.Append(CStr(LabelWrite4KBBandwidthValue.Text & " " & LabelWrite4KBBandwidthUnit.Text).PadLeft("15"))
        Clipboard.Append(CStr(LabelWrite4KBVelocityValue.Text & " IO/s").PadLeft("20"))
        Clipboard.AppendLine()
        Clipboard.Append(CStr("Random 4K Read (QD=32)").PadRight("44"))
        Clipboard.Append(CStr(LabelRead4KBQD32BandwidthValue.Text & " " & LabelRead4KBQD32BandwidthUnit.Text).PadLeft("15"))
        Clipboard.Append(CStr(LabelRead4KBQD32VelocityValue.Text & " IO/s").PadLeft("20"))
        Clipboard.AppendLine()
        Clipboard.Append(CStr("Random 4K Write (QD=32)").PadRight("44"))
        Clipboard.Append(CStr(LabelWrite4KBQD32BandwidthValue.Text & " " & LabelWrite4KBQD32BandwidthUnit.Text).PadLeft("15"))
        Clipboard.Append(CStr(LabelWrite4KBQD32VelocityValue.Text & " IO/s").PadLeft("20"))
        Clipboard.AppendLine()

        'Export to Txt
        My.Computer.Clipboard.SetText(Clipboard.ToString, TextDataFormat.Text)
        'Export to BMP
        'Dim Bmp As New Bitmap(Me.Width, Me.Height)
        'Me.DrawToBitmap(Bmp, New Rectangle(0, 0, Me.Width, Me.Height))
        'My.Computer.Clipboard.SetImage(Bmp)
    End Sub

    Private Sub AdvancedModeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AdvancedModeToolStripMenuItem.Click
        Advanced.Show()
        Me.Hide()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        Application.Exit()
    End Sub

    Private Sub AboutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AboutToolStripMenuItem.Click
        About.ShowDialog()
    End Sub

    Private Sub ComboBoxDriveValue_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles ComboBoxDriveValue.MouseEnter
        ToolTip_Main.ToolTipTitle = "Drive"
    End Sub

    Private Sub ComboBoxSizeValue_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles ComboBoxSizeValue.MouseEnter
        ToolTip_Main.ToolTipTitle = "Size"
    End Sub

    Private Sub Benchmark_ProgressChanged(ByVal Job As IOJob) Handles Benchmark.JobProgressChanged
        If Job.WorkerProgress > 0 Then Me.BeginInvoke(UpdateResults, Job)
        Me.BeginInvoke(UpdateProgress, Job.WorkerProgress)
    End Sub
    Private Sub Benchmark_JobCompleted(ByVal Job As IOJob) Handles Benchmark.JobCompleted
        Me.BeginInvoke(UpdateResults, Job)
        Me.BeginInvoke(UpdateProgress, 100)
    End Sub
    Private Sub Benchmark_BenchmarkCompleted() Handles Benchmark.BenchmarkCompleted, Benchmark.BenchmarkAborted
        Me.BeginInvoke(UpdateSetup, True)
        Me.BeginInvoke(UpdateProgress, 0)
    End Sub

    Private Sub UpdateSetupCallback(ByVal Enabled As Boolean)
        SyncLock UpdateSetupLock
            MenuStrip_Main.Enabled = Enabled
            ComboBoxSizeValue.Enabled = Enabled
            ComboBoxDriveValue.Enabled = Enabled

            ButtonAll.Enabled = (ButtonAll.Text = "Stop" Or Enabled)
            ButtonSequential.Enabled = (ButtonSequential.Text = "Stop" Or Enabled)
            Button512KB.Enabled = (Button512KB.Text = "Stop" Or Enabled)
            Button4KB.Enabled = (Button4KB.Text = "Stop" Or Enabled)
            Button4KBQD32.Enabled = (Button4KBQD32.Text = "Stop" Or Enabled)

            If Enabled Then
                ButtonAll.Text = "All"
                ButtonSequential.Text = "Sequential"
                Button512KB.Text = "512 KB"
                Button4KB.Text = "4 KB"
                Button4KBQD32.Text = "4 KB (QD=32)"
            End If
        End SyncLock
    End Sub
    Private Sub UpdateProgressCallback(ByVal Progress As Integer)
        SyncLock UpdateProgressLock
            If Progress > -1 Then
                ProgressBarBenchmark.Style = ProgressBarStyle.Blocks
                ProgressBarBenchmark.Value = Progress
            Else
                ProgressBarBenchmark.Style = ProgressBarStyle.Marquee
                ProgressBarBenchmark.Value = 100
            End If
        End SyncLock
    End Sub
    Private Sub UpdateResultsCallback(ByVal Job As IOJob)
        SyncLock UpdateResultsLock
            Try
                Select Case Job.Test.BufferSize.ToString
                    Case "32 MB"
                        Select Case Job.Test.Direction
                            Case IODirection.Read
                                LabelReadSequentialBandwidthValue.Text = Job.Results.Bitrate.Value.ToString("0.00")
                                LabelReadSequentialBandwidthUnit.Text = Job.Results.Bitrate.Unit.ToString & "/s"
                                LabelReadSequentialVelocityValue.Text = Job.Results.Velocity.ToString("0.00")
                            Case IODirection.Write
                                LabelWriteSequentialBandwidthValue.Text = Job.Results.Bitrate.Value.ToString("0.00")
                                LabelWriteSequentialBandwidthUnit.Text = Job.Results.Bitrate.Unit.ToString & "/s"
                                LabelWriteSequentialVelocityValue.Text = Job.Results.Velocity.ToString("0.00")
                        End Select
                    Case "512 KB"
                        Select Case Job.Test.Direction
                            Case IODirection.Read
                                LabelRead512KBBandwidthValue.Text = Job.Results.Bitrate.Value.ToString("0.00")
                                LabelRead512KBBandwidthUnit.Text = Job.Results.Bitrate.Unit.ToString & "/s"
                                LabelRead512KBVelocityValue.Text = Job.Results.Velocity.ToString("0.00")
                            Case IODirection.Write
                                LabelWrite512KBBandwidthValue.Text = Job.Results.Bitrate.Value.ToString("0.00")
                                LabelWrite512KBBandwidthUnit.Text = Job.Results.Bitrate.Unit.ToString & "/s"
                                LabelWrite512KBVelocityValue.Text = Job.Results.Velocity.ToString("0.00")
                        End Select
                    Case "4 KB"
                        Select Case Job.Test.QueueDepth
                            Case 1
                                Select Case Job.Test.Direction
                                    Case IODirection.Read
                                        LabelRead4KBBandwidthValue.Text = Job.Results.Bitrate.Value.ToString("0.00")
                                        LabelRead4KBBandwidthUnit.Text = Job.Results.Bitrate.Unit.ToString & "/s"
                                        LabelRead4KBVelocityValue.Text = Job.Results.Velocity.ToString("0.00")
                                    Case IODirection.Write
                                        LabelWrite4KBBandwidthValue.Text = Job.Results.Bitrate.Value.ToString("0.00")
                                        LabelWrite4KBBandwidthUnit.Text = Job.Results.Bitrate.Unit.ToString & "/s"
                                        LabelWrite4KBVelocityValue.Text = Job.Results.Velocity.ToString("0.00")
                                End Select
                            Case 32
                                Select Case Job.Test.Direction
                                    Case IODirection.Read
                                        LabelRead4KBQD32BandwidthValue.Text = Job.Results.Bitrate.Value.ToString("0.00")
                                        LabelRead4KBQD32BandwidthUnit.Text = Job.Results.Bitrate.Unit.ToString & "/s"
                                        LabelRead4KBQD32VelocityValue.Text = Job.Results.Velocity.ToString("0.00")
                                    Case IODirection.Write
                                        LabelWrite4KBQD32BandwidthValue.Text = Job.Results.Bitrate.Value.ToString("0.00")
                                        LabelWrite4KBQD32BandwidthUnit.Text = Job.Results.Bitrate.Unit.ToString & "/s"
                                        LabelWrite4KBQD32VelocityValue.Text = Job.Results.Velocity.ToString("0.00")
                                End Select
                        End Select
                End Select
            Catch ex As Exception
                LabelWriteSequentialBandwidthValue.Text = "FAIL"
                LabelWriteSequentialBandwidthUnit.Text = ""
                LabelWriteSequentialVelocityValue.Text = ""
                LabelReadSequentialBandwidthValue.Text = "FAIL"
                LabelReadSequentialBandwidthUnit.Text = ""
                LabelReadSequentialVelocityValue.Text = ""
            End Try
        End SyncLock
    End Sub

    Private Sub ButtonBenchmark_Click(sender As Object, e As EventArgs) Handles ButtonAll.Click, ButtonSequential.Click, Button512KB.Click, Button4KB.Click, Button4KBQD32.Click
        Dim ClickedButton As Button = CType(sender, Button)

        If ClickedButton.Text = "Stop" Then
            Benchmark.Stop()
            ClickedButton.Enabled = False
        Else
            ClickedButton.Text = "Stop"
            Me.BeginInvoke(UpdateSetup, False)

            If ClickedButton Is ButtonAll Then ButtonAll_Click(sender, e)
            If ClickedButton Is ButtonSequential Then ButtonSequential_Click(sender, e)
            If ClickedButton Is Button512KB Then Button512KB_Click(sender, e)
            If ClickedButton Is Button4KB Then Button4KB_Click(sender, e)
            If ClickedButton Is Button4KBQD32 Then Button4KBQD32_Click(sender, e)
        End If
    End Sub

    Private Sub ButtonAll_Click(sender As Object, e As EventArgs)
        Benchmark = New IOBenchmark()

        'Sequential
        Benchmark.AddJob(New IOJob(New IOTest() With { _
            .Direction = IODirection.Read, _
            .Drive = ComboBoxDriveValue.Text, _
            .Size = New Bytes(ComboBoxSizeValue.Text), _
            .BufferSize = New Bytes("32MB"), _
            .QueueDepth = 1, _
            .Sequential = True
        }, True, 1000))
        Benchmark.AddJob(New IOJob(New IOTest() With { _
            .Direction = IODirection.Write, _
            .Drive = ComboBoxDriveValue.Text, _
            .Size = New Bytes(ComboBoxSizeValue.Text), _
            .BufferSize = New Bytes("32MB"), _
            .QueueDepth = 1, _
            .Sequential = True
        }, True, 1000))

        '512K
        Benchmark.AddJob(New IOJob(New IOTest() With { _
            .Direction = IODirection.Read, _
            .Drive = ComboBoxDriveValue.Text, _
            .Size = New Bytes(ComboBoxSizeValue.Text), _
            .BufferSize = New Bytes("512KB"), _
            .QueueDepth = 1, _
            .Sequential = False
        }, True, 1000))
        Benchmark.AddJob(New IOJob(New IOTest() With { _
            .Direction = IODirection.Write, _
            .Drive = ComboBoxDriveValue.Text, _
            .Size = New Bytes(ComboBoxSizeValue.Text), _
            .BufferSize = New Bytes("512KB"), _
            .QueueDepth = 1, _
            .Sequential = False
        }, True, 1000))

        '4K
        Benchmark.AddJob(New IOJob(New IOTest() With { _
            .Direction = IODirection.Read, _
            .Drive = ComboBoxDriveValue.Text, _
            .Size = New Bytes(ComboBoxSizeValue.Text), _
            .BufferSize = New Bytes("4KB"), _
            .QueueDepth = 1, _
            .Sequential = False
        }, True, 1000))
        Benchmark.AddJob(New IOJob(New IOTest() With { _
            .Direction = IODirection.Write, _
            .Drive = ComboBoxDriveValue.Text, _
            .Size = New Bytes(ComboBoxSizeValue.Text), _
            .BufferSize = New Bytes("4KB"), _
            .QueueDepth = 1, _
            .Sequential = False
        }, True, 1000))

        '4K QD=32
        Benchmark.AddJob(New IOJob(New IOTest() With { _
            .Direction = IODirection.Read, _
            .Drive = ComboBoxDriveValue.Text, _
            .Size = New Bytes(ComboBoxSizeValue.Text), _
            .BufferSize = New Bytes("4KB"), _
            .QueueDepth = 32, _
            .Sequential = False
        }, True, 1000))
        Benchmark.AddJob(New IOJob(New IOTest() With { _
            .Direction = IODirection.Write, _
            .Drive = ComboBoxDriveValue.Text, _
            .Size = New Bytes(ComboBoxSizeValue.Text), _
            .BufferSize = New Bytes("4KB"), _
            .QueueDepth = 32, _
            .Sequential = False
        }, True, 1000))

        Benchmark.Start()
    End Sub

    Private Sub ButtonSequential_Click(sender As Object, e As EventArgs)
        Benchmark = New IOBenchmark()

        Benchmark.AddJob(New IOJob(New IOTest() With { _
            .Direction = IODirection.Read, _
            .Drive = ComboBoxDriveValue.Text, _
            .Size = New Bytes(ComboBoxSizeValue.Text), _
            .BufferSize = New Bytes("32MB"), _
            .QueueDepth = 1, _
            .Sequential = True
        }, True, 1000))
        Benchmark.AddJob(New IOJob(New IOTest() With { _
            .Direction = IODirection.Write, _
            .Drive = ComboBoxDriveValue.Text, _
            .Size = New Bytes(ComboBoxSizeValue.Text), _
            .BufferSize = New Bytes("32MB"), _
            .QueueDepth = 1, _
            .Sequential = True
        }, True, 1000))

        Benchmark.Start()
    End Sub

    Private Sub Button512KB_Click(sender As Object, e As EventArgs)
        Benchmark = New IOBenchmark()

        Benchmark.AddJob(New IOJob(New IOTest() With { _
            .Direction = IODirection.Read, _
            .Drive = ComboBoxDriveValue.Text, _
            .Size = New Bytes(ComboBoxSizeValue.Text), _
            .BufferSize = New Bytes("512KB"), _
            .QueueDepth = 1, _
            .Sequential = False
        }, True, 1000))
        Benchmark.AddJob(New IOJob(New IOTest() With { _
            .Direction = IODirection.Write, _
            .Drive = ComboBoxDriveValue.Text, _
            .Size = New Bytes(ComboBoxSizeValue.Text), _
            .BufferSize = New Bytes("512KB"), _
            .QueueDepth = 1, _
            .Sequential = False
        }, True, 1000))

        Benchmark.Start()
    End Sub

    Private Sub Button4KB_Click(sender As Object, e As EventArgs)
        Benchmark = New IOBenchmark()

        Benchmark.AddJob(New IOJob(New IOTest() With { _
            .Direction = IODirection.Read, _
            .Drive = ComboBoxDriveValue.Text, _
            .Size = New Bytes(ComboBoxSizeValue.Text), _
            .BufferSize = New Bytes("4KB"), _
            .QueueDepth = 1, _
            .Sequential = False
        }, True, 1000))
        Benchmark.AddJob(New IOJob(New IOTest() With { _
            .Direction = IODirection.Write, _
            .Drive = ComboBoxDriveValue.Text, _
            .Size = New Bytes(ComboBoxSizeValue.Text), _
            .BufferSize = New Bytes("4KB"), _
            .QueueDepth = 1, _
            .Sequential = False
        }, True, 1000))

        Benchmark.Start()
    End Sub

    Private Sub Button4KBQD32_Click(sender As Object, e As EventArgs)
        Benchmark = New IOBenchmark()

        Benchmark.AddJob(New IOJob(New IOTest() With { _
            .Direction = IODirection.Read, _
            .Drive = ComboBoxDriveValue.Text, _
            .Size = New Bytes(ComboBoxSizeValue.Text), _
            .BufferSize = New Bytes("4KB"), _
            .QueueDepth = 32, _
            .Sequential = False
        }, True, 1000))
        Benchmark.AddJob(New IOJob(New IOTest() With { _
            .Direction = IODirection.Write, _
            .Drive = ComboBoxDriveValue.Text, _
            .Size = New Bytes(ComboBoxSizeValue.Text), _
            .BufferSize = New Bytes("4KB"), _
            .QueueDepth = 32, _
            .Sequential = False
        }, True, 1000))

        Benchmark.Start()
    End Sub

    Private Sub Simple_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If Not Benchmark Is Nothing AndAlso (Benchmark.Status = IOStatus.Waiting Or Benchmark.Status = IOStatus.Processing) Then
            If MessageBox.Show("A benchmark is in progress. Do you really want to quit?", "Benchmark in progress", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = Windows.Forms.DialogResult.Yes Then
                Benchmark.Stop()
            Else
                e.Cancel = True
            End If
        End If

        For Each LogicalDrive As String In Directory.GetLogicalDrives()
            If Directory.Exists(LogicalDrive & "IOTest") Then
                For Each TestFile As String In Directory.GetFiles(LogicalDrive & "IOTest")
                    Try
                        File.Delete(TestFile)
                    Catch ex As Exception

                    End Try
                Next

                Try
                    Directory.Delete(LogicalDrive & "IOTest")
                Catch ex As Exception

                End Try
            End If
        Next
        Application.Exit()
    End Sub
End Class