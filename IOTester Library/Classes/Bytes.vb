Imports System.Text.RegularExpressions

Public Enum BytesUnit As Integer
    B
    KB
    MB
    GB
    TB
    PB
End Enum
Public Class Bytes
    Private _size As Long = 0
    Private _value As Double = 0
    Private _unit As BytesUnit = BytesUnit.B
    Private _p1 As Double

    Public Property Size As Long
        Get
            Return _size
        End Get
        Set(ByVal _size As Long)
            Me._size = _size
        End Set
    End Property
    Public ReadOnly Property Value As Double
        Get
            Return Me._value
        End Get
    End Property
    Public ReadOnly Property Unit As BytesUnit
        Get
            Return Me._unit
        End Get
    End Property

    Sub New(ByVal _long As Long)
        Me._size = _long
        Call ToBytes()
    End Sub
    Sub New(ByVal _double As Double)
        Me._size = _double
        Call ToBytes()
    End Sub
    Sub New(ByVal _string As String)
        Try
            Dim BytesPattern As New Regex("([0-9]+(?:\.[0-9]?)?)([A-Z]?)(?:B)?")

            _string = _string.ToUpper
            If BytesPattern.IsMatch(_string) Then
                Dim convertedValue As Double = CDbl(BytesPattern.Match(_string).Groups(1).Value)

                Dim PowersOfTwo As Integer = 0
                If BytesPattern.Match(_string).Groups(2).Value.Contains("K") Then PowersOfTwo = 1
                If BytesPattern.Match(_string).Groups(2).Value.Contains("M") Then PowersOfTwo = 2
                If BytesPattern.Match(_string).Groups(2).Value.Contains("G") Then PowersOfTwo = 3
                If BytesPattern.Match(_string).Groups(2).Value.Contains("T") Then PowersOfTwo = 4
                If BytesPattern.Match(_string).Groups(2).Value.Contains("P") Then PowersOfTwo = 5

                For i = 0 To PowersOfTwo - 1
                    convertedValue *= 1024
                Next

                Me._size = Math.Round(convertedValue)
            Else
                Me._size = 0
            End If
        Catch ex As Exception
            Me._size = 0
        End Try

        Call ToBytes()
    End Sub

    Private Sub ToBytes()
        Dim convertedBytesValue As String = ""
        Dim convertedBytesUnit As String = ""

        Dim _value As Double = Me._size
        Dim PowersOfTwo As Integer = 0
        While _value >= 1024
            PowersOfTwo += 1
            _value /= 1024
        End While
        Me._value = Math.Round(_value, 2)

        Select Case PowersOfTwo
            Case 0
                Me._unit = BytesUnit.B
            Case 1
                Me._unit = BytesUnit.KB
            Case 2
                Me._unit = BytesUnit.MB
            Case 3
                Me._unit = BytesUnit.GB
            Case 4
                Me._unit = BytesUnit.TB
            Case 5
                Me._unit = BytesUnit.PB
            Case Else
                Me._value = Me._size
                Me._unit = BytesUnit.B
        End Select
    End Sub

    Public Overrides Function ToString() As String
        Return Me._value & " " & Me._unit.ToString
    End Function
End Class