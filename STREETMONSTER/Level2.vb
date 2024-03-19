Public Class Level2
    Inherits System.Windows.Forms.Form
    Public myCaller As Form1
    Dim speed As Integer
    Dim road(17) As PictureBox
    Dim score As Integer

    Private Sub Level2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        speed = 4
        road(0) = PictureBox1
        road(1) = PictureBox2
        road(2) = PictureBox3
        road(3) = PictureBox4
        road(4) = PictureBox5
        road(5) = PictureBox6
        road(6) = PictureBox7
        road(7) = PictureBox8
        road(8) = PictureBox9
        road(9) = PictureBox10
        road(10) = PictureBox11
        road(11) = PictureBox12
        road(12) = PictureBox13
        road(13) = PictureBox14
        road(14) = PictureBox15
        road(15) = PictureBox16
        road(16) = PictureBox17
        road(17) = PictureBox18
    End Sub

    Private Sub RoadMover_Tick(sender As Object, e As EventArgs) Handles RoadMover.Tick
        For x As Integer = 0 To 17
            road(x).Top += speed
            If road(x).Top >= Me.Height Then
                road(x).Top = -road(x).Height
            End If
        Next
        If (Bike.Bounds.IntersectsWith(Racer1.Bounds)) Then
            endgame()
            My.Computer.Audio.Play(My.Resources.Sound_crash, AudioPlayMode.Background)
        End If
        If (Bike.Bounds.IntersectsWith(Racer2.Bounds)) Then
            endgame()
            My.Computer.Audio.Play(My.Resources.Sound_crash, AudioPlayMode.Background)
        End If
        If (Bike.Bounds.IntersectsWith(Racer3.Bounds)) Then
            endgame()
            My.Computer.Audio.Play(My.Resources.Sound_crash, AudioPlayMode.Background)
        End If

        If score > 8 And score < 12 Then
            speed = 6
        End If
        If score > 12 And score < 20 Then
            speed = 7
        End If

        If score = 20 Then
            GroupBox1.Visible = True
            RoadMover.Stop()
            Racer1Move.Stop()
            Racer2Move.Stop()
            Racer3Move.Stop()
            RightSide.Stop()
            LeftSide.Stop()
        End If
    End Sub

    Private Sub endgame()
        Gameover_text.Visible = True
        Quitkey.Visible = True
        Playagainkey.Visible = True
        GameoverScreen.Visible = True
        RoadMover.Stop()
        Racer1Move.Stop()
        Racer2Move.Stop()
        Racer3Move.Stop()
        RightSide.Stop()
        LeftSide.Stop()
        My.Computer.Audio.Stop()
    End Sub

    Private Sub Level2_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Right Then
            RightSide.Start()
        End If
        If e.KeyCode = Keys.Left Then
            LeftSide.Start()
        End If
        If e.KeyCode = Keys.A Then
            My.Computer.Audio.Play(My.Resources.carhorn, AudioPlayMode.Background)
        End If
    End Sub

    Private Sub Level2_KeyUp(sender As Object, e As KeyEventArgs) Handles MyBase.KeyUp
        RightSide.Stop()
        LeftSide.Stop()
    End Sub

    Private Sub RightSide_Tick(sender As Object, e As EventArgs) Handles RightSide.Tick
        If (Bike.Location.X < 257) Then
            Bike.Left += 5
        End If
    End Sub

    Private Sub LeftSide_Tick(sender As Object, e As EventArgs) Handles LeftSide.Tick
        If (Bike.Location.X > 84) Then
            Bike.Left -= 5
        End If
    End Sub

    Private Sub Racer1Move_Tick(sender As Object, e As EventArgs) Handles Racer1Move.Tick
        Racer1.Top += speed / 2
        If Racer1.Top >= Me.Height Then
            score += 1
            ScoreText.Text = "Score" & score
            Racer1.Top = -(CInt(Math.Ceiling(Rnd() * 200)) + Racer1.Height)
            Racer1.Left = CInt(Math.Ceiling(Rnd() * 95)) + 67
        End If
    End Sub

    Private Sub Racer2Move_Tick(sender As Object, e As EventArgs) Handles Racer2Move.Tick
        Racer2.Top += speed / 3
        If Racer2.Top >= Me.Height Then
            score += 1
            ScoreText.Text = "Score" & score
            Racer2.Top = -(CInt(Math.Ceiling(Rnd() * 200)) + Racer2.Height)
            Racer2.Left = CInt(Math.Ceiling(Rnd() * 100)) + 144
        End If
    End Sub

    Private Sub Racer3Move_Tick(sender As Object, e As EventArgs) Handles Racer3Move.Tick
        Racer3.Top += speed * 1 / 2
        If Racer3.Top >= Me.Height Then
            score += 1
            ScoreText.Text = "Score" & score
            Racer3.Top = -(CInt(Math.Ceiling(Rnd() * 180)) + Racer3.Height)
            Racer3.Left = CInt(Math.Ceiling(Rnd() * 160)) + 100
        End If
    End Sub

    Private Sub Pausekey_Click(sender As Object, e As EventArgs) Handles Pausekey.Click
        Playkey.Visible = True
        RestartKey.Visible = True
        Menukey.Visible = True
        PauseScreen.Visible = True
        RoadMover.Stop()
        Racer1Move.Stop()
        Racer2Move.Stop()
        Racer3Move.Stop()
    End Sub

    Private Sub Playkey_Click(sender As Object, e As EventArgs) Handles Playkey.Click
        PauseScreen.Visible = False
        Playkey.Visible = False
        RestartKey.Visible = False
        Menukey.Visible = False
        RoadMover.Start()
        Racer1Move.Start()
        Racer2Move.Start()
        Racer3Move.Start()
    End Sub

    Private Sub RestartKey_Click(sender As Object, e As EventArgs) Handles RestartKey.Click
        score = 0
        Me.Controls.Clear()
        InitializeComponent()
        Level2_Load(e, e)
    End Sub

    Private Sub Menukey_Click(sender As Object, e As EventArgs) Handles Menukey.Click
        Me.Hide()
        GameLevels.Show()
    End Sub

    Private Sub Playagainkey_Click(sender As Object, e As EventArgs) Handles Playagainkey.Click
        score = 0
        Me.Controls.Clear()
        InitializeComponent()
        Level2_Load(e, e)
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Quitkey.Click
        Me.Hide()
        GameLevels.Show()
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        Me.Hide()
        Level3.Show()
    End Sub
End Class