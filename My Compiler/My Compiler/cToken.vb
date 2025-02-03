Public Class cToken
    Public kind As Integer
    Public spelling As String

    ' Token Types
    Public Shared VALID As Integer = 0
    Public Shared INVALID As Integer = 1
    Public Shared EOF As Integer = 2
    Public Shared IDENTIFIER As Integer = 3
    Public Shared STR As Integer = 4
    Public Shared NUMBER As Integer = 5
    Public Shared KEYWORD As Integer = 6
    Public Shared SYMBOL As Integer = 7
    Public Shared UNKNOWN As Integer = 8

    Public Sub New(ByVal kind As Integer, ByVal spelling As String)
        Me.kind = kind
        Me.spelling = spelling
    End Sub

    Public Overrides Function ToString() As String
        Return $"""{spelling}"""
    End Function
End Class
