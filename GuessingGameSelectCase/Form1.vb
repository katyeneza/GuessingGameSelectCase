Public Class Form1
    Dim intSecret As Integer

    Private Sub btnGuess_Click(sender As Object, e As EventArgs) Handles btnGuess.Click
        Dim intGuess As Integer = Me.txtGuess.Text

        Select Case intGuess
            Case intSecret
                Me.lblAnswer.Text = "You got it."
                Me.btnRestart.Enabled = True
                Me.btnGuess.Enabled = False
            Case 1 To intSecret
                Me.lblAnswer.Text = "Too low."
            Case intSecret To 10
                Me.lblAnswer.Text = "Too high."
            Case Is < 1
                Me.lblAnswer.Text = "You chose a number lower than 1! Guess again."
            Case Is > 10
                Me.lblAnswer.Text = "You chose a number higher than 10! Guess again."
        End Select

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        'Set initial random number.
        Randomize()
        intSecret = Int((10 - 1 + 1) * Rnd() + 1)

        'Set up interface. 
        Me.btnRestart.Enabled = False
    End Sub

    Private Sub btnRestart_Click(sender As Object, e As EventArgs) Handles btnRestart.Click
        'rerandomize intsecret
        Randomize()
        intSecret = Int((10 - 1 + 1) * Rnd() + 1)

        'disable reset and restart 
        Me.btnRestart.Enabled = False
        Me.btnGuess.Enabled = True
        Me.lblAnswer.Text = ""
        Me.txtGuess.Text = ""
        'picture box is picWord

    End Sub
End Class
