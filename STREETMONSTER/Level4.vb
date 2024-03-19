Public Class Level4
    Dim FirstTime As Boolean = True

    Dim Done1 As Boolean = False
    Dim Done2 As Boolean = False
    Dim Done3 As Boolean = False
    Dim Done4 As Boolean = False

    Dim CarStart As Integer = 0
    Dim CarMove1 As Integer = 0
    Dim CarMove2 As Integer = 0

    Dim MusicEnabled As Boolean = True
    Dim GameOver As Boolean = False

    Dim Wait As Integer = 2
    Dim IWait As Integer
    Dim NWait As Integer = 0
    Dim CircleOrRectangle11 As Random
    Dim CircleOrRectangle12 As Random
    Dim CircleOrRectangle21 As Random
    Dim CircleOrRectangle22 As Random
    Dim ICircleOrRectangle11 As Integer
    Dim ICircleOrRectangle12 As Integer
    Dim ICircleOrRectangle21 As Integer
    Dim ICircleOrRectangle22 As Integer

    Dim Car1Left As Boolean = True
    Dim Car2Left As Boolean = False
    Dim LeftCircle1 As Boolean
    Dim LeftCircle2 As Boolean
    Dim RightCircle1 As Boolean
    Dim RightCircle2 As Boolean

    Dim ObstacleSpeed As Integer = 3
    Dim ObstacleTime As Integer = 0
    Dim DificultyLevel As Integer = 4

    Private Sub Level4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.DoubleBuffered = True
        Me.KeyPreview = True

        pcbObstacle11.Parent = pcbBackground
        pcbObstacle12.Parent = pcbBackground
        pcbObstacle21.Parent = pcbBackground
        pcbObstacle22.Parent = pcbBackground
        pcbCar1.Parent = pcbBackground
        pcbCar2.Parent = pcbBackground
        pcbCarGas1.Parent = pcbBackground
        pcbCarGas2.Parent = pcbBackground
        lblGameOver.Parent = pcbBackground
        lblYourScore.Parent = pcbBackground
        lblScore.Parent = pcbBackground
        lblTime.Parent = pcbBackground
        btnReplay.Parent = pcbBackground
        lblNewHighScore.Parent = pcbBackground

        pcbObstacle11.Location = New Point(pcbObstacle11.Location.X, pcbObstacle11.Location.Y - 64)
        pcbObstacle12.Location = New Point(pcbObstacle12.Location.X, pcbObstacle12.Location.Y - 64)
        pcbObstacle21.Location = New Point(pcbObstacle21.Location.X, pcbObstacle21.Location.Y - 160)
        pcbObstacle22.Location = New Point(pcbObstacle22.Location.X, pcbObstacle22.Location.Y - 160)

        lblScore.Left = (Me.Width) / 2 - (lblScore.Width) / 2
    End Sub

    Private Sub lblScore_Click(sender As Object, e As EventArgs) Handles lblScore.Click
        lblScore.Left = (Me.Width) / 2 - (lblScore.Width) / 2
    End Sub

    Public Sub LetTheGameBegin()

        pcbObstacle11.Location = New Point(23, -69)
        pcbObstacle12.Location = New Point(118, -69)
        pcbObstacle21.Location = New Point(219, -369)
        pcbObstacle22.Location = New Point(316, -369)

        pcbCar1.Location = New Point(23, 432)
        pcbCar2.Location = New Point(312, 432)
        Car1Left = True
        Car2Left = False
        CarMove1 = 0
        CarMove2 = 0

        btnReplay.Visible = False
        pcbCarGas1.Visible = False
        pcbCarGas2.Visible = False
        lblGameOver.Visible = False
        lblYourScore.Visible = False
        lblTime.Visible = False
        lblNewHighScore.Visible = False
        Menukey.Visible = False
        lblScore.Text = "0"

        lblScore.Visible = True

        RandomizeAll()

        If FirstTime = True Then
            pcbCar1.Location = New Point(23, 466)
            pcbCar2.Location = New Point(312, 466)
            tmrCarStart.Start()
        End If

        ObstacleSpeed = DificultyLevel

        tmrTime.Start()
        tmrObstacles1.Start()
        tmrWaiting.Start()
    End Sub

    Private Sub Level4_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.A Then
            If CarMove1 = 0 Then
                tmrCar1move.Start()
            Else
                tmrCar1move.Stop()
                tmrCar1Change.Start()
            End If
        End If

        If e.KeyCode = Keys.J Then
            If CarMove2 = 0 Then
                tmrCar2Move.Start()
            Else
                tmrCar2Move.Stop()
                tmrCar2Change.Start()
            End If
        End If
    End Sub

    Private Sub GameIsOver()
        GameOver = True

        pcbCar1.Location = New Point(23, 432)
        pcbCar2.Location = New Point(312, 432)
        Car1Left = True
        Car2Left = False

        If MusicEnabled = True Then
            My.Computer.Audio.Play(My.Resources.Sound_crash, AudioPlayMode.Background)
        End If

        Dim t As String
        Dim mins As Integer
        If lblTime.Text > 60 Then
            Do Until lblTime.Text < 60
                lblTime.Text -= 60
                mins += 1
            Loop
        End If
        If lblTime.Text < 10 Then
            lblTime.Text = "0" & lblTime.Text
        End If

        t = mins.ToString & ":" & lblTime.Text

        lblGameOver.Visible = True
        lblYourScore.Visible = True
        lblScore.Visible = False
        lblYourScore.Text = "score: " & lblScore.Text & vbNewLine & "time: " & t
        lblYourScore.Left = (Me.Width) / 2 - (lblYourScore.Width) / 2
        lblYourScore.BringToFront()
        lblGameOver.BringToFront()

        tmrTime.Stop()
        tmrObstacles1.Stop()
        tmrObstacles2.Stop()
        tmrCar1move.Stop()
        tmrCar2Move.Stop()
        tmrCar1Change.Stop()
        tmrCar2Change.Stop()

        pcbObstacle11.Visible = False
        pcbObstacle12.Visible = False
        pcbObstacle21.Visible = False
        pcbObstacle22.Visible = False

        Menukey.Visible = True
        btnReplay.Visible = True
        btnReplay.BringToFront()

        chbName.Checked = False
    End Sub

    Private Sub RandomizeAll()
        Randomize11()
        Randomize12()
        Randomize21()
        Randomize22()
    End Sub

    Private Sub Randomize11()
        Done1 = False
        pcbObstacle11.Visible = True

        CircleOrRectangle11 = New Random
        ICircleOrRectangle11 = CircleOrRectangle11.Next(1, 50)

        If CLng(ICircleOrRectangle11) Mod 2 = 0 Then
            pcbObstacle11.Image = My.Resources.Circle1
            LeftCircle1 = True
        Else
            pcbObstacle11.Image = My.Resources.Rectangle1
            LeftCircle1 = False
        End If
    End Sub

    Private Sub Randomize12()
        Done2 = False
        pcbObstacle12.Visible = True

        CircleOrRectangle12 = New Random
        ICircleOrRectangle12 = CircleOrRectangle12.Next(1, 100)

        If CLng(ICircleOrRectangle12) Mod 2 = 0 Then
            pcbObstacle12.Image = My.Resources.Circle1
            LeftCircle2 = True
        Else
            pcbObstacle12.Image = My.Resources.Rectangle1
            LeftCircle2 = False
        End If
    End Sub

    Private Sub Randomize21()
        Done3 = False
        pcbObstacle21.Visible = True

        CircleOrRectangle21 = New Random
        ICircleOrRectangle21 = CircleOrRectangle21.Next(1, 150)

        If CLng(ICircleOrRectangle21) Mod 2 = 0 Then
            pcbObstacle21.Image = My.Resources.Circle2
            RightCircle1 = True
        Else
            pcbObstacle21.Image = My.Resources.Rectangle2
            RightCircle1 = False
        End If
    End Sub

    Private Sub Randomize22()
        Done4 = False
        pcbObstacle22.Visible = True

        CircleOrRectangle22 = New Random
        ICircleOrRectangle22 = CircleOrRectangle22.Next(1, 200)

        If CLng(ICircleOrRectangle22) Mod 2 = 0 Then
            pcbObstacle22.Image = My.Resources.Circle2
            RightCircle2 = True
        Else
            pcbObstacle22.Image = My.Resources.Rectangle2
            RightCircle2 = False
        End If
    End Sub

    Private Sub tmrCarStart_Tick(sender As Object, e As EventArgs) Handles tmrCarStart.Tick
        If FirstTime = True Then

            If CarStart = 20 Then
                CarStart = 0
                pcbCarGas1.Visible = False
                pcbCarGas2.Visible = False
                tmrCarStart.Stop()
                FirstTime = False
            Else
                pcbCar1.Location = New Point(pcbCar1.Location.X, pcbCar1.Location.Y - 1)
                pcbCar2.Location = New Point(pcbCar2.Location.X, pcbCar2.Location.Y - 1)
                pcbCarGas1.Location = New Point(pcbCarGas1.Location.X, pcbCarGas1.Location.Y - 1)
                pcbCarGas2.Location = New Point(pcbCarGas2.Location.X, pcbCarGas2.Location.Y - 1)
                pcbCarGas1.Visible = True
                pcbCarGas2.Visible = True
                CarStart += 1
            End If
        End If
    End Sub

    Private Sub tmrTime_Tick(sender As Object, e As EventArgs) Handles tmrTime.Tick
        lblTime.Text += 1
        ObstacleTime += 1
        If ObstacleTime = 15 Then
            ObstacleTime = 0
            ObstacleSpeed += 1
        End If
    End Sub

    Private Sub tmrCar1Move_Tick(sender As Object, e As EventArgs) Handles tmrCar1Move.Tick
        If CarMove1 = 21 Then
            CarMove1 = 0
            tmrCar1Move.Stop()
            If Car1Left = True Then
                Car1Left = False
            Else
                Car1Left = True
            End If
        Else
            If Car1Left = True Then
                pcbCar1.Location = New Point(pcbCar1.Location.X + 5, pcbCar1.Location.Y)
            Else
                pcbCar1.Location = New Point(pcbCar1.Location.X - 5, pcbCar1.Location.Y)
            End If

            CarMove1 += 1
        End If
    End Sub

    Private Sub tmrCar2Move_Tick(sender As Object, e As EventArgs) Handles tmrCar2Move.Tick
        If CarMove2 = 21 Then
            CarMove2 = 0
            tmrCar2Move.Stop()
            If Car2Left = True Then
                Car2Left = False
            Else
                Car2Left = True
            End If
        Else
            If Car2Left = True Then
                pcbCar2.Location = New Point(pcbCar2.Location.X + 5, pcbCar2.Location.Y)
            Else
                pcbCar2.Location = New Point(pcbCar2.Location.X - 5, pcbCar2.Location.Y)
            End If

            CarMove2 += 1
        End If
    End Sub

    Private Sub tmrCar1Change_Tick(sender As Object, e As EventArgs) Handles tmrCar1Change.Tick
        If CarMove1 = 0 Then
            tmrCar1Change.Stop()
        Else
            If Car1Left = True Then
                pcbCar1.Location = New Point(pcbCar1.Location.X - 5, pcbCar1.Location.Y)
            Else
                pcbCar1.Location = New Point(pcbCar1.Location.X + 5, pcbCar1.Location.Y)
            End If

            CarMove1 -= 1
        End If
    End Sub

    Private Sub tmrCar2Change_Tick(sender As Object, e As EventArgs) Handles tmrCar2Change.Tick
        If CarMove2 = 0 Then
            tmrCar2Change.Stop()
        Else
            If Car2Left = True Then
                pcbCar2.Location = New Point(pcbCar2.Location.X - 5, pcbCar2.Location.Y)
            Else
                pcbCar2.Location = New Point(pcbCar2.Location.X + 5, pcbCar2.Location.Y)
            End If

            CarMove2 -= 1
        End If
    End Sub

    Private Sub tmrObstacles1_Tick(sender As Object, e As EventArgs) Handles tmrObstacles1.Tick
        If (pcbObstacle11.Location = New Point(23, 580)) Or
          (pcbObstacle11.Location = New Point(23, 581)) Or
          (pcbObstacle11.Location = New Point(23, 582)) Or
          (pcbObstacle11.Location = New Point(23, 583)) Or
          (pcbObstacle11.Location = New Point(23, 584)) Or
          (pcbObstacle11.Location = New Point(23, 585)) Or
          (pcbObstacle11.Location = New Point(23, 586)) Or
          (pcbObstacle11.Location = New Point(23, 587)) Or
          (pcbObstacle11.Location = New Point(23, 588)) Or
          (pcbObstacle11.Location = New Point(23, 589)) Or
          (pcbObstacle11.Location = New Point(23, 590)) Or
          (pcbObstacle11.Location = New Point(23, 591)) Or
          (pcbObstacle11.Location = New Point(23, 592)) Or
          (pcbObstacle11.Location = New Point(23, 593)) Or
          (pcbObstacle11.Location = New Point(23, 594)) Or
          (pcbObstacle11.Location = New Point(23, 595)) Or
          (pcbObstacle11.Location = New Point(23, 596)) Or
          (pcbObstacle11.Location = New Point(23, 597)) Or
          (pcbObstacle11.Location = New Point(23, 598)) Or
          (pcbObstacle11.Location = New Point(23, 599)) Then

            If LeftCircle1 = True Then
                If pcbObstacle11.Visible = True Then
                    GameIsOver()
                Else
                    pcbObstacle11.Location = New Point(23, -69)
                    Randomize11()
                End If
            Else
                pcbObstacle11.Location = New Point(23, -69)
                Randomize11()
            End If
        Else
            pcbObstacle11.Location = New Point(pcbObstacle11.Location.X, pcbObstacle11.Location.Y + ObstacleSpeed)

            If pcbObstacle11.Bounds.IntersectsWith(pcbCar1.Bounds) Then
                If LeftCircle1 = True Then
                    If Done1 = False Then
                        If MusicEnabled = True Then
                            My.Computer.Audio.Play(My.Resources.Sound_collect, AudioPlayMode.Background)
                        End If
                        lblScore.Text += 1
                        pcbObstacle11.Visible = False
                        Done1 = True
                    End If
                Else
                    GameIsOver()
                End If
            End If
        End If

        If (pcbObstacle21.Location = New Point(219, 580)) Or
            (pcbObstacle21.Location = New Point(219, 581)) Or
            (pcbObstacle21.Location = New Point(219, 582)) Or
            (pcbObstacle21.Location = New Point(219, 583)) Or
            (pcbObstacle21.Location = New Point(219, 584)) Or
            (pcbObstacle21.Location = New Point(219, 585)) Or
            (pcbObstacle21.Location = New Point(219, 586)) Or
            (pcbObstacle21.Location = New Point(219, 587)) Or
            (pcbObstacle21.Location = New Point(219, 588)) Or
            (pcbObstacle21.Location = New Point(219, 589)) Or
            (pcbObstacle21.Location = New Point(219, 590)) Or
            (pcbObstacle21.Location = New Point(219, 591)) Or
            (pcbObstacle21.Location = New Point(219, 592)) Or
            (pcbObstacle21.Location = New Point(219, 593)) Or
            (pcbObstacle21.Location = New Point(219, 594)) Or
            (pcbObstacle21.Location = New Point(219, 595)) Or
            (pcbObstacle21.Location = New Point(219, 596)) Or
            (pcbObstacle21.Location = New Point(219, 597)) Or
            (pcbObstacle21.Location = New Point(219, 598)) Or
            (pcbObstacle21.Location = New Point(219, 599)) Then
            If RightCircle1 = True Then
                If pcbObstacle21.Visible = True Then
                    GameIsOver()
                Else
                    pcbObstacle21.Location = New Point(219, -69)
                    Randomize21()
                End If
            Else
                pcbObstacle21.Location = New Point(219, -69)
                Randomize21()
            End If
        Else
            pcbObstacle21.Location = New Point(pcbObstacle21.Location.X, pcbObstacle21.Location.Y + ObstacleSpeed)

            If pcbObstacle21.Bounds.IntersectsWith(pcbCar2.Bounds) Then
                If RightCircle1 = True Then
                    If Done3 = False Then
                        If MusicEnabled = True Then
                            My.Computer.Audio.Play(My.Resources.Sound_collect, AudioPlayMode.Background)
                        End If
                        lblScore.Text += 1
                        pcbObstacle21.Visible = False
                        Done3 = True
                    End If
                Else
                    GameIsOver()
                End If
            End If
        End If
    End Sub

    Private Sub tmrObstacles2_Tick(sender As Object, e As EventArgs) Handles tmrObstacles2.Tick
        If (pcbObstacle12.Location = New Point(118, 580)) Or
          (pcbObstacle12.Location = New Point(118, 581)) Or
          (pcbObstacle12.Location = New Point(118, 582)) Or
          (pcbObstacle12.Location = New Point(118, 583)) Or
          (pcbObstacle12.Location = New Point(118, 584)) Or
          (pcbObstacle12.Location = New Point(118, 585)) Or
          (pcbObstacle12.Location = New Point(118, 586)) Or
          (pcbObstacle12.Location = New Point(118, 587)) Or
          (pcbObstacle12.Location = New Point(118, 588)) Or
          (pcbObstacle12.Location = New Point(118, 589)) Or
          (pcbObstacle12.Location = New Point(118, 590)) Or
          (pcbObstacle12.Location = New Point(118, 591)) Or
          (pcbObstacle12.Location = New Point(118, 592)) Or
          (pcbObstacle12.Location = New Point(118, 593)) Or
          (pcbObstacle12.Location = New Point(118, 594)) Or
          (pcbObstacle12.Location = New Point(118, 595)) Or
          (pcbObstacle12.Location = New Point(118, 596)) Or
          (pcbObstacle12.Location = New Point(118, 597)) Or
          (pcbObstacle12.Location = New Point(118, 598)) Or
          (pcbObstacle12.Location = New Point(118, 599)) Then

            If LeftCircle2 = True Then
                If pcbObstacle12.Visible = True Then
                    GameIsOver()
                Else
                    pcbObstacle12.Location = New Point(118, -69)
                    Randomize12()
                End If
            Else
                pcbObstacle12.Location = New Point(118, -69)
                Randomize12()
            End If
        Else
            pcbObstacle12.Location = New Point(pcbObstacle12.Location.X, pcbObstacle12.Location.Y + ObstacleSpeed)

            If pcbObstacle12.Bounds.IntersectsWith(pcbCar1.Bounds) Then
                If LeftCircle2 = True Then
                    If Done2 = False Then
                        If MusicEnabled = True Then
                            My.Computer.Audio.Play(My.Resources.Sound_collect, AudioPlayMode.Background)
                        End If
                        lblScore.Text += 1
                        pcbObstacle12.Visible = False
                        Done2 = True
                    End If
                Else
                    GameIsOver()
                End If
            End If
        End If

        If (pcbObstacle22.Location = New Point(316, 580)) Or
            (pcbObstacle22.Location = New Point(316, 581)) Or
            (pcbObstacle22.Location = New Point(316, 582)) Or
            (pcbObstacle22.Location = New Point(316, 583)) Or
            (pcbObstacle22.Location = New Point(316, 584)) Or
            (pcbObstacle22.Location = New Point(316, 585)) Or
            (pcbObstacle22.Location = New Point(316, 586)) Or
            (pcbObstacle22.Location = New Point(316, 587)) Or
            (pcbObstacle22.Location = New Point(316, 588)) Or
            (pcbObstacle22.Location = New Point(316, 589)) Or
            (pcbObstacle22.Location = New Point(316, 590)) Or
            (pcbObstacle22.Location = New Point(316, 591)) Or
            (pcbObstacle22.Location = New Point(316, 592)) Or
            (pcbObstacle22.Location = New Point(316, 593)) Or
            (pcbObstacle22.Location = New Point(316, 594)) Or
            (pcbObstacle22.Location = New Point(316, 595)) Or
            (pcbObstacle22.Location = New Point(316, 596)) Or
            (pcbObstacle22.Location = New Point(316, 597)) Or
            (pcbObstacle22.Location = New Point(316, 598)) Or
            (pcbObstacle22.Location = New Point(316, 599)) Then

            If RightCircle2 = True Then
                If pcbObstacle22.Visible = True Then
                    GameIsOver()
                Else
                    pcbObstacle22.Location = New Point(316, -69)
                    Randomize22()
                End If
            Else
                pcbObstacle22.Location = New Point(316, -69)
                Randomize22()
            End If
        Else
            pcbObstacle22.Location = New Point(pcbObstacle22.Location.X, pcbObstacle22.Location.Y + ObstacleSpeed)

            If pcbObstacle22.Bounds.IntersectsWith(pcbCar2.Bounds) Then
                If RightCircle2 = True Then
                    If Done4 = False Then
                        If MusicEnabled = True Then
                            My.Computer.Audio.Play(My.Resources.Sound_collect, AudioPlayMode.Background)
                        End If
                        lblScore.Text += 1
                        pcbObstacle22.Visible = False
                        Done4 = True
                    End If
                Else
                    GameIsOver()
                End If
            End If
        End If
    End Sub

    Private Sub tmrWaiting_Tick(sender As Object, e As EventArgs) Handles tmrWaiting.Tick
        If NWait = IWait Then
            NWait = 0
            tmrObstacles2.Start()
            tmrWaiting.Stop()
        Else
            NWait += 1
        End If
    End Sub

    Private Sub chbName_CheckedChanged(sender As Object, e As EventArgs) Handles chbName.CheckedChanged
        If chbName.Checked = True Then
            LetTheGameBegin()
        End If
    End Sub

    Private Sub btnReplay_Click(sender As Object, e As EventArgs) Handles btnReplay.Click
        LetTheGameBegin()
    End Sub

    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click
        LetTheGameBegin()
        GroupBox1.Visible = False
    End Sub

    Private Sub btnRate_Click(sender As Object, e As EventArgs) Handles btnRate.Click
        Me.Hide()
        GameRating.Show()
    End Sub

    Private Sub Menukey_Click(sender As Object, e As EventArgs) Handles Menukey.Click
        Me.Hide()
        GameLevels.Show()
    End Sub
End Class