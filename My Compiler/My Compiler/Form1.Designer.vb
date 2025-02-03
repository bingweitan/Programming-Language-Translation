<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMyCompiler
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Label1 = New Label()
        Label2 = New Label()
        btnAnalyze = New Button()
        Label3 = New Label()
        Label4 = New Label()
        lstLexical = New TextBox()
        lstSyntax = New TextBox()
        lstCombined = New RichTextBox()
        txtCommand = New TextBox()
        btnClear = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(157, 24)
        Label1.Name = "Label1"
        Label1.Size = New Size(78, 20)
        Label1.TabIndex = 0
        Label1.Text = "Command"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(124, 106)
        Label2.Name = "Label2"
        Label2.Size = New Size(111, 20)
        Label2.TabIndex = 1
        Label2.Text = "Lexical Analysis"
        ' 
        ' btnAnalyze
        ' 
        btnAnalyze.Location = New Point(211, 382)
        btnAnalyze.Name = "btnAnalyze"
        btnAnalyze.Size = New Size(94, 29)
        btnAnalyze.TabIndex = 5
        btnAnalyze.Text = "Analyze"
        btnAnalyze.UseVisualStyleBackColor = True
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(126, 195)
        Label3.Name = "Label3"
        Label3.Size = New Size(109, 20)
        Label3.TabIndex = 7
        Label3.Text = "Syntax Analysis"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(157, 285)
        Label4.Name = "Label4"
        Label4.Size = New Size(78, 20)
        Label4.TabIndex = 9
        Label4.Text = "Combined"
        ' 
        ' lstLexical
        ' 
        lstLexical.Location = New Point(262, 106)
        lstLexical.Multiline = True
        lstLexical.Name = "lstLexical"
        lstLexical.ReadOnly = True
        lstLexical.Size = New Size(264, 62)
        lstLexical.TabIndex = 10
        ' 
        ' lstSyntax
        ' 
        lstSyntax.Location = New Point(262, 195)
        lstSyntax.Multiline = True
        lstSyntax.Name = "lstSyntax"
        lstSyntax.ReadOnly = True
        lstSyntax.Size = New Size(264, 62)
        lstSyntax.TabIndex = 11
        ' 
        ' lstCombined
        ' 
        lstCombined.Location = New Point(262, 285)
        lstCombined.Name = "lstCombined"
        lstCombined.ReadOnly = True
        lstCombined.Size = New Size(264, 62)
        lstCombined.TabIndex = 12
        lstCombined.Text = ""
        ' 
        ' txtCommand
        ' 
        txtCommand.Location = New Point(262, 21)
        txtCommand.Multiline = True
        txtCommand.Name = "txtCommand"
        txtCommand.Size = New Size(264, 62)
        txtCommand.TabIndex = 13
        ' 
        ' btnClear
        ' 
        btnClear.Location = New Point(415, 382)
        btnClear.Name = "btnClear"
        btnClear.Size = New Size(94, 29)
        btnClear.TabIndex = 14
        btnClear.Text = "Clear"
        btnClear.UseVisualStyleBackColor = True
        ' 
        ' frmMyCompiler
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(btnClear)
        Controls.Add(txtCommand)
        Controls.Add(lstCombined)
        Controls.Add(lstSyntax)
        Controls.Add(lstLexical)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(btnAnalyze)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "frmMyCompiler"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnAnalyze As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents lstLexical As TextBox
    Friend WithEvents lstSyntax As TextBox
    Friend WithEvents lstCombined As RichTextBox
    Friend WithEvents txtCommand As TextBox
    Friend WithEvents btnClear As Button

End Class
