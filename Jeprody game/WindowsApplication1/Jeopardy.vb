Public Class Jeopardy

    Private Const NUMOFQS = 30
    Private Const QSETAMT = 6

    Dim catused(5) As Integer
    Dim currentValue As Integer
    Public Score(1) As Integer
    Dim buttons As Integer
    Dim questions(QSETAMT, 5) As String
    'question element 6, index 5 is the cat title


    Private Sub Jeopardy_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim valid As Boolean
        Randomize()

        Score = {0, 0}
        buttons = 0

        UpdateScore()

        For i As Integer = 0 To 5 Step 1
            Do
                catused(i) = CInt(Math.Floor(Rnd() * QSETAMT))

                valid = True

                For j As Integer = (i - 1) To (i < 0) Step -1
                    If catused(j) = catused(i) Then
                        valid = False
                    End If
                Next
            Loop While Not valid
        Next

        questions = {
                    {vbNewLine + "This is the game Lee Sedol was defeated in by Google’s DeepMind AI.", vbNewLine + "He is the man responsible who coined the term 'artificial intelligence'.", vbNewLine + "This can describe a non-living thing with the ability to develop a skill.", vbNewLine + "He is the chess grandmaster defeated by Deep Blue in 1997.", vbNewLine + "This is the name of the first chatbot ever created.", "AI"},
                    {vbNewLine + "This is what RFID stands for.", vbNewLine + "This is the typical cost of an NFC tag.", vbNewLine + "This is the subcategory of RFID that uses a passive transmitter.", vbNewLine + "The company that partnered with NXP Semiconductors to develop RFID technology.", vbNewLine + "The effective range of RFID.", "RFID"},
                    {vbNewLine + "This is the level of automation of Tesla Autopilot.", vbNewLine + "This long range technology uses lasers to measure distances.", vbNewLine + "The name of the car that won the 2007 DARPA Urban Challenge.", vbNewLine + "This is the year that Waymo completed the first fully autonomous trip on public roads.", vbNewLine + "He was the leader of first successful self driving car project.", "Self Driving Cars"},
                    {vbNewLine + "In this type of computer, bits can only be in one state at a time.", vbNewLine + "This phenomenon allows you to affect one qubit by observing another.", vbNewLine + "This effect allows a qubit to have multiple states at once.", vbNewLine + "This is the thought experiment helps to show how it is possible for something to be in two states at once.", vbNewLine + "A sphere with a vector arrow representing the probability of a qubit collapsing into a certain classical state.", "Quantum Computers"},
                    {vbNewLine + "This is the minimum value the weighted sum must be at to turn on the output of a neuron.", vbNewLine + "The most common type of neural network, where all information travels in one direction.", vbNewLine + "This type of neuron accepts a binary input.", vbNewLine + "This type of neuron smooths out the output.", vbNewLine + "The layers of a neural network that are not inputs of outputs.", "Neural Networks"},
                    {vbNewLine + "This is what AI stands for.", vbNewLine + "This is what RADAR means.", vbNewLine + "This is what NFC stands for.", vbNewLine + "This is what SAE.", vbNewLine + "This is what DARPA stands for.", "Acronyms"},
                    {vbNewLine + "this is emberising", vbNewLine + "you shoulnt see this", vbNewLine + "yikes", vbNewLine + "error", vbNewLine + "opps", "Somthing went wrong"}
                    }

        c0.Text = questions(catused(0), 5)
        c1.Text = questions(catused(1), 5)
        c2.Text = questions(catused(2), 5)
        c3.Text = questions(catused(3), 5)
        c4.Text = questions(catused(4), 5)
        c5.Text = questions(catused(5), 5)

    End Sub


    Sub QuestionGroupVis(visibility As Boolean)

        questionbox.Visible = visibility
        gr11correct.Visible = visibility
        gr11incorrect.Visible = visibility
        gr12correct.Visible = visibility
        gr12incorrect.Visible = visibility
        cancel.Visible = visibility

    End Sub

    Sub QuestionButtonAction(cat As Integer, row As Integer)

        currentValue = (row + 1) * 100

        questionbox.Text = questions(catused(cat), row)

        QuestionGroupVis(True)

        buttons += 1

    End Sub

    Sub AddRemovePoints(multiplier As Integer, grade As Integer)

        Score(grade) += (currentValue * multiplier)

        UpdateScore()

    End Sub

    Sub UpdateScore()

        score0.Text = "$" + Score(0).ToString()
        score1.Text = "$" + Score(1).ToString()

    End Sub

    Private Sub cancel_Click(sender As Object, e As EventArgs) Handles cancel.Click
        QuestionGroupVis(False)

        If buttons >= NUMOFQS Then
            EndScreen.Show()
            Me.Hide()

        End If

    End Sub

    Private Sub gr11correct_Click(sender As Object, e As EventArgs) Handles gr11correct.Click
        AddRemovePoints(1, 0)
    End Sub

    Private Sub gr11incorrect_Click(sender As Object, e As EventArgs) Handles gr11incorrect.Click
        AddRemovePoints(-1, 0)
    End Sub

    Private Sub gr12correct_Click(sender As Object, e As EventArgs) Handles gr12correct.Click
        AddRemovePoints(1, 1)
    End Sub

    Private Sub gr12incorrect_Click(sender As Object, e As EventArgs) Handles gr12incorrect.Click
        AddRemovePoints(-1, 1)
    End Sub

    'button code
    '----------------------------------------------------------------------------------------------------

    Private Sub c0b0_Click(sender As Object, e As EventArgs) Handles c0b0.Click

        c0b0.Visible = False
        QuestionButtonAction(0, 0)

    End Sub

    Private Sub c0b1_Click(sender As Object, e As EventArgs) Handles c0b1.Click

        c0b1.Visible = False
        QuestionButtonAction(0, 1)

    End Sub

    Private Sub c0b2_Click(sender As Object, e As EventArgs) Handles c0b2.Click

        c0b2.Visible = False
        QuestionButtonAction(0, 2)

    End Sub

    Private Sub c0b3_Click(sender As Object, e As EventArgs) Handles c0b3.Click

        c0b3.Visible = False
        QuestionButtonAction(0, 3)

    End Sub

    Private Sub c0b4_Click(sender As Object, e As EventArgs) Handles c0b4.Click

        c0b4.Visible = False
        QuestionButtonAction(0, 4)

    End Sub

    '----------------------------------------------------------------------------------------------------

    Private Sub c1b0_Click(sender As Object, e As EventArgs) Handles c1b0.Click

        c1b0.Visible = False
        QuestionButtonAction(1, 0)

    End Sub

    Private Sub c1b1_Click(sender As Object, e As EventArgs) Handles c1b1.Click

        c1b1.Visible = False
        QuestionButtonAction(1, 1)

    End Sub

    Private Sub c1b2_Click(sender As Object, e As EventArgs) Handles c1b2.Click

        c1b2.Visible = False
        QuestionButtonAction(1, 2)

    End Sub

    Private Sub c1b3_Click(sender As Object, e As EventArgs) Handles c1b3.Click

        c1b3.Visible = False
        QuestionButtonAction(1, 3)

    End Sub

    Private Sub c1b4_Click(sender As Object, e As EventArgs) Handles c1b4.Click

        c1b4.Visible = False
        QuestionButtonAction(1, 4)

    End Sub

    '----------------------------------------------------------------------------------------------------

    Private Sub c2b0_Click(sender As Object, e As EventArgs) Handles c2b0.Click

        c2b0.Visible = False
        QuestionButtonAction(2, 0)

    End Sub

    Private Sub c2b1_Click(sender As Object, e As EventArgs) Handles c2b1.Click

        c2b1.Visible = False
        QuestionButtonAction(2, 1)

    End Sub

    Private Sub c2b2_Click(sender As Object, e As EventArgs) Handles c2b2.Click

        c2b2.Visible = False
        QuestionButtonAction(2, 2)

    End Sub

    Private Sub c2b3_Click(sender As Object, e As EventArgs) Handles c2b3.Click

        c2b3.Visible = False
        QuestionButtonAction(2, 3)

    End Sub

    Private Sub c2b4_Click(sender As Object, e As EventArgs) Handles c2b4.Click

        c2b4.Visible = False
        QuestionButtonAction(2, 4)

    End Sub

    '----------------------------------------------------------------------------------------------------

    Private Sub c3b0_Click(sender As Object, e As EventArgs) Handles c3b0.Click

        c3b0.Visible = False
        QuestionButtonAction(3, 0)

    End Sub

    Private Sub c3b1_Click(sender As Object, e As EventArgs) Handles c3b1.Click

        c3b1.Visible = False
        QuestionButtonAction(3, 1)

    End Sub

    Private Sub c3b2_Click(sender As Object, e As EventArgs) Handles c3b2.Click

        c3b2.Visible = False
        QuestionButtonAction(3, 2)

    End Sub

    Private Sub c3b3_Click(sender As Object, e As EventArgs) Handles c3b3.Click

        c3b3.Visible = False
        QuestionButtonAction(3, 3)

    End Sub

    Private Sub c3b4_Click(sender As Object, e As EventArgs) Handles c3b4.Click

        c3b4.Visible = False
        QuestionButtonAction(3, 4)

    End Sub

    '----------------------------------------------------------------------------------------------------

    Private Sub c4b0_Click(sender As Object, e As EventArgs) Handles c4b0.Click

        c4b0.Visible = False
        QuestionButtonAction(4, 0)

    End Sub

    Private Sub c4b1_Click(sender As Object, e As EventArgs) Handles c4b1.Click

        c4b1.Visible = False
        QuestionButtonAction(4, 1)

    End Sub

    Private Sub c4b2_Click(sender As Object, e As EventArgs) Handles c4b2.Click

        c4b2.Visible = False
        QuestionButtonAction(4, 2)

    End Sub

    Private Sub c4b3_Click(sender As Object, e As EventArgs) Handles c4b3.Click

        c4b3.Visible = False
        QuestionButtonAction(4, 3)

    End Sub

    Private Sub c4b4_Click(sender As Object, e As EventArgs) Handles c4b4.Click

        c4b4.Visible = False
        QuestionButtonAction(4, 4)

    End Sub

    '----------------------------------------------------------------------------------------------------

    Private Sub c5b0_Click(sender As Object, e As EventArgs) Handles c5b0.Click

        c5b0.Visible = False
        QuestionButtonAction(5, 0)

    End Sub

    Private Sub c5b1_Click(sender As Object, e As EventArgs) Handles c5b1.Click

        c5b1.Visible = False
        QuestionButtonAction(5, 1)

    End Sub

    Private Sub c5b2_Click(sender As Object, e As EventArgs) Handles c5b2.Click

        c5b2.Visible = False
        QuestionButtonAction(5, 2)

    End Sub

    Private Sub c5b3_Click(sender As Object, e As EventArgs) Handles c5b3.Click

        c5b3.Visible = False
        QuestionButtonAction(5, 3)

    End Sub

    Private Sub c5b4_Click(sender As Object, e As EventArgs) Handles c5b4.Click

        c5b4.Visible = False
        QuestionButtonAction(5, 4)

    End Sub

End Class