Imports IOTester
Imports System.IO
Imports System.Text.RegularExpressions
Imports System.Text
Imports System.Threading

Module Main
    Private Drive As String
    Private WithEvents Benchmark As New IOBenchmark()
    Private VerboseOutput As Boolean = False
    Private OutputResultsToLog As Boolean = False
    Private OutputResults As New StringBuilder()
    Private Lock As New ManualResetEvent(False)

    Sub Main(ByVal args As String())
        'For Each Drive As DriveInfo In DriveInfo.GetDrives()
        '    Console.WriteLine("Drive: " & Drive.Name)
        '    Console.WriteLine("   Type: " & Drive.DriveType.ToString)
        '    Console.WriteLine("   IsReady: " & Drive.IsReady)
        '    If Drive.IsReady Then
        '        Console.WriteLine("   Label: " & Drive.VolumeLabel)
        '        Console.WriteLine("   Format: " & Drive.DriveFormat)
        '        Console.WriteLine("   Size: " & New Bytes(Drive.TotalSize).ToString())
        '        Console.WriteLine("   Available: " & New Bytes(Drive.AvailableFreeSpace).ToString())
        '    End If
        '    Console.WriteLine()
        'Next
        '
        'Console.ReadLine()
        'Return

        For i = 0 To args.Length - 1
            Select Case args(i)
                Case "/?", "/h", "/help", "-?", "-h", "-help"
                    Call DisplayHelp()
                    Return
                Case "-i", "/i"
                    Benchmark = ConfigurationFile.ParseConfigurationFile(args(i + 1))
                    i += 1
                Case "-v", "/v"
                    VerboseOutput = True
                Case "-o", "/o"
                    OutputResultsToLog = True
                Case Else
                    Drive = args(i)
            End Select
        Next

        If String.IsNullOrEmpty(Drive) Then
            Call DisplayHelp()
            Return
        End If

        If Not VerboseOutput Then
            Console.ForegroundColor = ConsoleColor.White
            Console.Write(CStr("Test").PadRight("44"))
            Console.Write(CStr("Bandwidth").PadLeft("15"))
            Console.Write(CStr("Velocity").PadLeft("20"))
            Console.ForegroundColor = ConsoleColor.Gray
            Console.WriteLine()
        End If
        If OutputResultsToLog Then
            OutputResults.Append(CStr("Test").PadRight("44"))
            OutputResults.Append(CStr("Bandwidth").PadLeft("15"))
            OutputResults.Append(CStr("Velocity").PadLeft("20"))
            OutputResults.AppendLine()
        End If

        If Benchmark.Workers("Worker0").Jobs.Count = 0 Then
            'Sequential
            Benchmark.AddJob(New IOJob(New IOTest() With {.Name = "1GB Sequential Read", .Direction = IODirection.Read, .Drive = Drive, .Size = New Bytes("1GB"), .BufferSize = New Bytes("32MB"), .QueueDepth = 1, .Sequential = True}))
            If VerboseOutput Then Console.WriteLine("""1GB Sequential Read"" test added.")
            Benchmark.AddJob(New IOJob(New IOTest() With {.Name = "1GB Sequential Write", .Direction = IODirection.Write, .Drive = Drive, .Size = New Bytes("1GB"), .BufferSize = New Bytes("32MB"), .QueueDepth = 1, .Sequential = True}))
            If VerboseOutput Then Console.WriteLine("""1GB Sequential Write"" test added.")

            '512K
            Benchmark.AddJob(New IOJob(New IOTest() With {.Name = "500MB 512K Random Read", .Direction = IODirection.Read, .Drive = Drive, .Size = New Bytes("500MB"), .BufferSize = New Bytes("512K"), .QueueDepth = 1, .Sequential = False}))
            If VerboseOutput Then Console.WriteLine("""500MB 512K Random Read"" test added.")
            Benchmark.AddJob(New IOJob(New IOTest() With {.Name = "500MB 512K Random Write", .Direction = IODirection.Write, .Drive = Drive, .Size = New Bytes("500MB"), .BufferSize = New Bytes("512K"), .QueueDepth = 1, .Sequential = False}))
            If VerboseOutput Then Console.WriteLine("""500MB 512K Random Write"" test added.")

            '4K
            Benchmark.AddJob(New IOJob(New IOTest() With {.Name = "100MB 4K Random Read", .Direction = IODirection.Read, .Drive = Drive, .Size = New Bytes("100MB"), .BufferSize = New Bytes("4K"), .QueueDepth = 1, .Sequential = False}))
            If VerboseOutput Then Console.WriteLine("""100MB 4K Random Read"" test added.")
            Benchmark.AddJob(New IOJob(New IOTest() With {.Name = "100MB 4K Random Write", .Direction = IODirection.Write, .Drive = Drive, .Size = New Bytes("100MB"), .BufferSize = New Bytes("4K"), .QueueDepth = 1, .Sequential = False}))
            If VerboseOutput Then Console.WriteLine("""100MB 4K Random Write"" test added.")

            '4K, QD=32
            Benchmark.AddJob(New IOJob(New IOTest() With {.Name = "500MB 4K (QD=32) Random Read", .Direction = IODirection.Read, .Drive = Drive, .Size = New Bytes("500MB"), .BufferSize = New Bytes("4K"), .QueueDepth = 32, .Sequential = False}))
            If VerboseOutput Then Console.WriteLine("""500MB 4K (QD=32) Random Read"" test added.")
            Benchmark.AddJob(New IOJob(New IOTest() With {.Name = "500MB 4K (QD=32) Random Write", .Direction = IODirection.Write, .Drive = Drive, .Size = New Bytes("500MB"), .BufferSize = New Bytes("4K"), .QueueDepth = 32, .Sequential = False}))
            If VerboseOutput Then Console.WriteLine("""500MB 4K (QD=32) Random Write"" test added.")

            If VerboseOutput Then Console.WriteLine("")
        End If

        AddHandler Benchmark.JobStarted, AddressOf Benchmark_JobStarted
        AddHandler Benchmark.JobProgressChanged, AddressOf Benchmark_ProgressChanged
        AddHandler Benchmark.JobCompleted, AddressOf Benchmark_JobCompleted
        AddHandler Benchmark.BenchmarkCompleted, AddressOf Benchmark_BenchmarkCompleted
        Benchmark.Start()

        Lock.WaitOne()
    End Sub

    Sub DisplayHelp()
        Console.WriteLine()
        Console.WriteLine(My.Application.Info.ProductName & " " & My.Application.Info.Version.ToString & " - " & My.Application.Info.Copyright.Replace("©", "(c)"))
        Console.WriteLine("* 1 KB/s = 1,024 bytes/s")
        Console.WriteLine()
        Console.WriteLine("Usage: " & My.Application.Info.ProductName & " [-i file] [-o] drive")
        Console.WriteLine()
        Console.WriteLine("Options:")
        Console.WriteLine("    -i file   Use the specified configuration file.")
        Console.WriteLine("    -v        Display verbose output to console, containing more details.")
        Console.WriteLine("    -o        Record and output the results to an output file.")
        Console.WriteLine("")
    End Sub

#Region "Benchmark Handlers"
    Private Sub Benchmark_JobStarted(ByVal Job As IOJob)
        If Not VerboseOutput Then
            Console.Write(CStr(Job.Test.Name).PadRight(44))
        Else
            Console.ForegroundColor = ConsoleColor.White
            Console.WriteLine("[" & Job.Test.Name & "]")
            Console.ForegroundColor = ConsoleColor.Gray
            Console.WriteLine("Job Settings")
            Console.WriteLine("   Date:        " & Now.ToString("yyyy-MM-dd HH:mm:ss"))
            Console.WriteLine("   Drive:       " & Job.Test.Drive)
            Console.WriteLine("   Direction:   " & Job.Test.Direction.ToString)
            Console.WriteLine("   Buffer Size: " & Job.Test.BufferSize.ToString)
            Console.WriteLine("   File Size:   " & Job.Test.Size.ToString)
            Console.WriteLine("   Sequential:  " & Job.Test.Sequential.ToString)
        End If
    End Sub
    Private Sub Benchmark_ProgressChanged(ByVal Job As IOJob)
    End Sub
    Private Sub Benchmark_JobCompleted(ByVal Job As IOJob)
        If Not VerboseOutput Then
            Console.Write(CStr(Job.Results.Bitrate.Value.ToString("0.00") & " " & Job.Results.Bitrate.Unit.ToString & "/s").PadLeft(15))
            If Job.Test.BufferSize.Size = 4096 AndAlso Job.Test.QueueDepth = 32 Then
                Console.Write(CStr(Job.Results.Velocity.ToString("0.00") & " IO/s").PadLeft(20))
            Else
                Console.Write(CStr("- ").PadLeft(20))
            End If
            Console.WriteLine()
        Else
            Console.ForegroundColor = ConsoleColor.White
            Console.WriteLine("Results")
            Console.ForegroundColor = ConsoleColor.Gray
            Console.WriteLine("   Bitrate:     " & Job.Results.Bitrate.Value.ToString("0.00") & " " & Job.Results.Bitrate.Unit.ToString & "/s")
            Console.WriteLine("   Velocity:    " & Job.Results.Velocity.ToString("0.00") & " IO/s")
            Console.WriteLine("")
        End If

        If OutputResultsToLog Then
            OutputResults.Append(Job.Test.Name.PadRight(44))
            OutputResults.Append(CStr(Job.Results.Bitrate.Value.ToString("0.00") & " " & Job.Results.Bitrate.Unit.ToString & "/s").PadLeft(15))
            If Job.Test.BufferSize.Size = 4096 Then
                OutputResults.Append(CStr(Job.Results.Velocity.ToString("0.00") & " IO/s").PadLeft(20))
            Else
                OutputResults.Append(CStr("- ").PadLeft(20))
            End If
            OutputResults.AppendLine()
        End If
    End Sub
    Private Sub Benchmark_BenchmarkCompleted()
        If OutputResultsToLog Then
            Using OutputResultsStreamWriter As New StreamWriter("IOTester_" & Now.ToString("yyyyMMdd-HHmmss") & ".log")
                OutputResultsStreamWriter.Write(OutputResults.ToString())
            End Using
        End If

        Lock.Set()
    End Sub
#End Region
End Module
