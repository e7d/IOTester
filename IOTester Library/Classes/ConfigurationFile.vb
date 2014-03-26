Imports System.IO
Imports System.Text.RegularExpressions

Public Class ConfigurationFile
    Public Shared Sub SerializeConfigurationFile(ByVal Path As String, ByVal Benchmark As IOBenchmark)

    End Sub

    Public Shared Function ParseConfigurationFile(ByVal Path As String) As IOBenchmark
        Dim Benchmark As New IOBenchmark()

        Using ConfigurationReader = New StreamReader(File.OpenRead(Path))
            Dim Test As IOTest = Nothing
            Dim ConfigurationLine As String = ""
            Dim ConfigurationLineArgs() As String
            Dim ConfigurationName As String = ""

            While Not ConfigurationReader.EndOfStream
                ConfigurationLine = ConfigurationReader.ReadLine

                If New Regex("\[.*\]").IsMatch(ConfigurationLine) Then
                    If Not Test Is Nothing Then
                        If TestIsValid(Test) Then
                            Benchmark.AddJob(New IOJob(Test))
                            Console.WriteLine("""" & ConfigurationName & """ test added")
                        Else
                            Console.WriteLine("""" & ConfigurationName & """ test is not valid")
                        End If
                    End If
                    Test = New IOTest() With {.ID = Guid.NewGuid().ToString, .Name = "New Job", .Direction = IODirection.Read, .Drive = IO.Path.GetPathRoot(My.Application.Info.DirectoryPath), .Size = New Bytes("1GB"), .BufferSize = New Bytes("32MB"), .QueueDepth = 1, .Sequential = True}

                    ConfigurationName = New Regex("\[(.*)\]").Match(ConfigurationLine).Groups(1).Value
                    Test.Name = ConfigurationName
                ElseIf ConfigurationLine.Length > 0 Then
                    ConfigurationLineArgs = ConfigurationLine.Split("=")

                    Select Case ConfigurationLineArgs(0)
                        Case "Direction"
                            If ConfigurationLineArgs(1) = "Read" Then
                                Test.Direction = IODirection.Read
                            ElseIf ConfigurationLineArgs(1) = "1" Then
                                Test.Direction = IODirection.Read
                            ElseIf ConfigurationLineArgs(1) = "Write" Then
                                Test.Direction = IODirection.Write
                            ElseIf ConfigurationLineArgs(1) = "2" Then
                                Test.Direction = IODirection.Write
                            End If

                            'Test.Direction = ConfigurationLineArgs(1)
                        Case "Drive"
                            Test.Drive = ConfigurationLineArgs(1)
                        Case "Size"
                            Test.Size = New Bytes(ConfigurationLineArgs(1))
                        Case "BufferSize"
                            Test.BufferSize = New Bytes(ConfigurationLineArgs(1))
                        Case "QueueDepth"
                            Integer.TryParse(ConfigurationLineArgs(1), Test.QueueDepth)
                            If (Test.QueueDepth <> 1 AndAlso Test.QueueDepth <> 32) Then
                                Test.QueueDepth = 1
                            End If
                        Case "Sequential"
                            Test.Sequential = (ConfigurationLineArgs(1) = "1" OrElse ConfigurationLineArgs(1) = "True")
                    End Select
                End If
            End While
            If TestIsValid(Test) Then
                Benchmark.AddJob(New IOJob(Test))
                Console.WriteLine("""" & ConfigurationName & """ test added.")
            Else
                Console.WriteLine("""" & ConfigurationName & """ test is not valid.")
            End If
        End Using

        Return Benchmark
    End Function

    Public Shared Function TestIsValid(ByVal Test As IOTest) As Boolean
        Return _
            Not Test.Drive = Nothing AndAlso _
            Not Test.Direction = Nothing AndAlso _
            Not Test.Size Is Nothing AndAlso _
            Not Test.BufferSize Is Nothing AndAlso _
            Test.QueueDepth > 0 AndAlso _
            Test.QueueDepth <= 32
    End Function
End Class
