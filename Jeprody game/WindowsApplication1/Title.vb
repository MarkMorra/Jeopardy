Public Class Title

    Private Sub Title_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        My.Computer.Audio.Play(My.Resources.jeopardy1, AudioPlayMode.BackgroundLoop)
    End Sub

    Private Sub Play_Click(sender As Object, e As EventArgs) Handles Play.Click

        Jeopardy.Show()
        Me.Hide()

    End Sub

End Class
