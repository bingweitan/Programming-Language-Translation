Imports System.Text.RegularExpressions

Public Class cScanner
    Private input As String
    Private currentIndex As Integer
    Private currentChar As Char

    Public Sub New(ByVal inputText As String)
        input = inputText.Trim()
        currentIndex = 0
        If input.Length > 0 Then
            currentChar = input(0)
        Else
            currentChar = vbNullChar ' End of input
        End If
    End Sub

    Private Sub TakeIt(ByRef currentSpelling As String)
        currentSpelling &= currentChar
        currentIndex += 1
        If currentIndex < input.Length Then
            currentChar = input(currentIndex)
        Else
            currentChar = vbNullChar
        End If
    End Sub

    Public Function Scan() As cToken
        While currentChar <> vbNullChar AndAlso Char.IsWhiteSpace(currentChar)
            TakeIt("")
        End While

        If currentChar = vbNullChar Then
            Return New cToken(cToken.EOF, "EOF")
        End If

        Dim currentSpelling As String = ""

        ' Detect Identifiers (Commands, Keywords)
        If Char.IsLetter(currentChar) Then
            TakeIt(currentSpelling)
            While currentChar <> vbNullChar AndAlso (Char.IsLetterOrDigit(currentChar) Or currentChar = "_")
                TakeIt(currentSpelling)
            End While
            Return New cToken(cToken.IDENTIFIER, currentSpelling)

            ' Detect Strings (Words inside double quotes)
        ElseIf currentChar = """"c Then
            TakeIt(currentSpelling) ' Take opening quote
            While currentChar <> vbNullChar AndAlso currentChar <> """"c
                TakeIt(currentSpelling)
            End While
            If currentChar = """"c Then TakeIt(currentSpelling) ' Take closing quote
            Return New cToken(cToken.STR, currentSpelling)

            ' Detect Numbers
        ElseIf Char.IsDigit(currentChar) Then
            TakeIt(currentSpelling)
            While currentChar <> vbNullChar AndAlso Char.IsDigit(currentChar)
                TakeIt(currentSpelling)
            End While
            Return New cToken(cToken.NUMBER, currentSpelling)

            ' Detect Symbols (e.g., priority, due, am, pm)
        ElseIf ".,:/+-".Contains(currentChar) Then
            TakeIt(currentSpelling)
            Return New cToken(cToken.SYMBOL, currentSpelling)

        Else
            TakeIt(currentSpelling)
            Return New cToken(cToken.UNKNOWN, currentSpelling)
        End If
    End Function
End Class
