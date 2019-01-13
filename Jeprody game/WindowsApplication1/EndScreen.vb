Public Class EndScreen

    Private Sub EndScreen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Jeopardy.Score(0) = Jeopardy.Score(1) Then
            WinnerBox.Text = "The teams have tied! Congratulations to both teams!" + vbNewLine + "Score: $" + Jeopardy.Score(0).ToString()
        ElseIf Jeopardy.Score(0) > Jeopardy.Score(1) Then
            WinnerBox.Text = "Team 1 has won! Congratulations!" + vbNewLine + "Score: $" + Jeopardy.Score(0).ToString()
        ElseIf Jeopardy.Score(0) < Jeopardy.Score(1) Then
            WinnerBox.Text = "Team 2 has won! Congratulations!" + vbNewLine + "Score: $" + Jeopardy.Score(1).ToString()
        End If

    End Sub
End Class