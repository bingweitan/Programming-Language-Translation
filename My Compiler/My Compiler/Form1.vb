Public Class frmMyCompiler
    Private Sub btnAnalyze_Click(sender As Object, e As EventArgs) Handles btnAnalyze.Click
        Dim input As String = txtCommand.Text.Trim().ToLower()

        ' Check if the input is empty
        If String.IsNullOrWhiteSpace(input) Then
            MessageBox.Show("Please enter a command.")
            Return
        End If

        ' Perform lexical analysis using cScanner
        Dim scanner As New cScanner(input)
        Dim tokens As New List(Of cToken)
        Dim currentToken As cToken = scanner.Scan()

        While currentToken.kind <> cToken.EOF
            tokens.Add(currentToken)
            currentToken = scanner.Scan()
        End While

        ' Display lexical tokens in lstLexical
        lstLexical.Text = String.Join(", ", tokens.Select(Function(t) t.spelling))

        ' Perform syntax analysis
        Dim syntaxResult As String = SyntaxAnalysis(tokens)

        ' Display syntax result in lstSyntax
        lstSyntax.Text = syntaxResult

        ' Determine final output and set lstCombined's text and color
        Dim combinedResult As String = If(syntaxResult.StartsWith("Error"), "Command is invalid.", "Command is valid.")
        lstCombined.Text = combinedResult
        lstCombined.ForeColor = If(syntaxResult.StartsWith("Error"), Color.Red, Color.Green)
    End Sub

    Function SyntaxAnalysis(ByVal tokens As List(Of cToken)) As String
        If tokens.Count = 0 Then
            Return "Error: Command is empty."
        End If

        Dim command As String = tokens(0).spelling.ToLower()

        Select Case command
            Case "create", "update"
                ' Check for valid "task" keyword
                If tokens.Count < 3 OrElse tokens(1).spelling.ToLower() <> "task" Then
                    Return "Error: Missing 'task' keyword."
                End If

                ' Check if the task description is enclosed in quotes
                If tokens(2).kind <> cToken.STR Then
                    Return "Error: Task description must be enclosed in quotes."
                End If

                ' Check for valid priority (only allowed: low, medium, high)
                Dim priorityIndex As Integer = tokens.FindIndex(Function(t) t.spelling.ToLower() = "priority")
                If priorityIndex > -1 Then
                    If priorityIndex + 2 >= tokens.Count OrElse Not {"low", "medium", "high"}.Contains(tokens(priorityIndex + 2).spelling.ToLower()) Then
                        Return "Error: Invalid priority. Allowed values are 'low', 'medium', or 'high'."
                    End If
                End If

                ' Check if the due date is in the correct format (DD/MM/YYYY)
                Dim dueIndex As Integer = tokens.FindIndex(Function(t) t.spelling.ToLower() = "due")
                If dueIndex > -1 AndAlso (dueIndex + 1 < tokens.Count) Then
                    If Not IsValidDateFormat(tokens(dueIndex + 1).spelling) Then
                        Return "Error: Invalid date format. Use 'DD/MM/YYYY'."
                    End If
                End If

                Return "Valid Command"

            Case "list"
                If tokens.Count < 2 OrElse tokens(1).spelling.ToLower() <> "tasks" Then
                    Return "Error: Missing 'tasks' keyword after 'list'."
                End If
                Return "Valid Command"

            Case Else
                Return "Error: Unknown command."
        End Select
    End Function

    ' Function to check if the date is in DD/MM/YYYY format
    Function IsValidDateFormat(ByVal duedate As String) As Boolean
        ' Regular expression to match DD/MM/YYYY format
        Dim pattern As String = "^\d{2}/\d{2}/\d{4}$"
        Dim regex As New System.Text.RegularExpressions.Regex(pattern)
        Return regex.IsMatch(duedate)
    End Function
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtCommand.Clear()
        lstLexical.Clear()
        lstSyntax.Clear()
        lstCombined.Clear()
    End Sub

End Class
