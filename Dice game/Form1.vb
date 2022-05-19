Public Class Form1
    Public score As Integer = 0
    Public High_roll As Integer = 0
    Function save(score As Integer)
        Dim filePath As String = "C:\Users\Aurora\OneDrive - Calderdale College\github sort folder\Computing\Dice game\High score.txt"
        Dim highscore As Integer
        Dim fileHolder As System.IO.StreamReader = My.Computer.FileSystem.OpenTextFileReader(filePath)

        Dim line As String = fileHolder.ReadLine()



        ' If line < score Then

        '     My.Computer.FileSystem.WriteAllText(filePath, score, False)
        'highscore = score
        'Else
        'highscore = line
        'End If

        Return (highscore)
    End Function
    Sub endscript()
        Dim terminate As Boolean = False
        While terminate = False
            Button1.Name = "Game Over"
        End While
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim randomNumber As Integer
        Randomize()
        randomNumber = Int(Rnd() * 6 + 1)

        Dim scoretemp As Integer = 0


        If randomNumber = 1 Then
            PictureBox1.Image = My.Resources.Dice1
        ElseIf randomNumber = 2 Then
            PictureBox1.Image = My.Resources.Dice2
        ElseIf randomNumber = 3 Then
            PictureBox1.Image = My.Resources.Dice3
        ElseIf randomNumber = 4 Then
            PictureBox1.Image = My.Resources.Dice4
        ElseIf randomNumber = 5 Then
            PictureBox1.Image = My.Resources.Dice5
        Else
            PictureBox1.Image = My.Resources.Dice6
        End If

        Dim randomNumber2 As Integer
        Randomize()
        randomNumber2 = Int(Rnd() * 6 + 1)

        If randomNumber2 = 1 Then
            PictureBox2.Image = My.Resources.Dice1
        ElseIf randomNumber2 = 2 Then
            PictureBox2.Image = My.Resources.Dice2
        ElseIf randomNumber2 = 3 Then
            PictureBox2.Image = My.Resources.Dice3
        ElseIf randomNumber2 = 4 Then
            PictureBox2.Image = My.Resources.Dice4
        ElseIf randomNumber2 = 5 Then
            PictureBox2.Image = My.Resources.Dice5
        Else
            PictureBox2.Image = My.Resources.Dice6
        End If

        Dim randomNumber3 As Integer
        Randomize()
        randomNumber3 = Int(Rnd() * 6 + 1)

        If randomNumber3 = 1 Then
            PictureBox3.Image = My.Resources.Dice1
        ElseIf randomNumber3 = 2 Then
            PictureBox3.Image = My.Resources.Dice2
        ElseIf randomNumber3 = 3 Then
            PictureBox3.Image = My.Resources.Dice3
        ElseIf randomNumber3 = 4 Then
            PictureBox3.Image = My.Resources.Dice4
        ElseIf randomNumber3 = 5 Then
            PictureBox3.Image = My.Resources.Dice5
        Else
            PictureBox3.Image = My.Resources.Dice6
        End If



        scoretemp += randomNumber + randomNumber2 + randomNumber3

        If randomNumber = randomNumber2 Or randomNumber = randomNumber3 Or randomNumber2 = randomNumber3 Then
            scoretemp = scoretemp * 2
        End If


        score += scoretemp

        Label1.Text = "Score: " & score

        If randomNumber = 1 And randomNumber2 = 1 Then
            save(score)
            endscript()
        ElseIf randomNumber = 1 And randomNumber3 = 1
            save(score)
            endscript()
        ElseIf randomNumber2 = 1 And randomNumber3 = 1
            save(score)
            endscript()
        End If

        If scoretemp > High_roll Then
            High_roll = scoretemp
        End If

        Label2.Text = "Highest Roll: " & High_roll
        Label3.Text = "High Score: " & save(score)
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click
        'Show "Form2.vb" '

    End Sub
End Class