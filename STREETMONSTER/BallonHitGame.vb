Public Class BallonHitGame
    Dim score As Integer = 0
    Dim Ren As New Random

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        PictureBox1.Top -= 5
        PictureBox2.Top -= 5
        PictureBox3.Top -= 5
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        If PictureBox1.Location.Y < -60 Or PictureBox2.Location.Y < -60 Or PictureBox3.Location.Y < -60 Then
            Timer1.Enabled = False
            Timer2.Enabled = False

            MessageBox.Show("GameOver")
        End If
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click, PictureBox2.Click, PictureBox3.Click
        score += 1
        Label2.Text = score

        Dim x As Integer = Ren.Next(0, 400)
        sender.location = New Point(x, 300)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If ComboBox1.Text = "SLOW" Then
            Timer1.Interval = 200
        ElseIf ComboBox1.Text = "NORMAL" Then
            Timer1.Enabled = 100
        ElseIf ComboBox1.Text = "FAST" Then
            Timer1.Enabled = 50
        End If

        PictureBox1.Location = New Point(90, 70)
        PictureBox1.Location = New Point(190, 200)
        PictureBox1.Location = New Point(320, 330)


        Timer1.Enabled = True
        Timer2.Enabled = True
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Timer1.Enabled = False
        Timer2.Enabled = False
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Timer1.Enabled = True
        Timer2.Enabled = True
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Hide()
        GameLevels.Show()
    End Sub
End Class