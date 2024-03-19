Public Class GemCollector
    Dim moveRight As Boolean = False
    Dim moveUp As Boolean = False
    Dim moveLeft As Boolean = False
    Dim moveDown As Boolean = False
    Dim score As Integer = 0
    Dim highScore As Integer = 0
    Dim lives As Integer = 3
    Dim ready As Integer = 1000
    Dim maxBugNumber As Integer = 7
    'this variable records the number of bugs currently on the screen (note: since the array starts at 0, there will be 
    'currentbugnumber+1 bugs on the screen
    Dim currentBugNumber As Integer = 2
    Dim bugArray(maxBugNumber) As PictureBox
    Dim bugSpeed As Single = 1

    Private Sub GemCollector_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim obj As Object, i As Integer = 0
        ' start timer for character movements
        Timer1.Start()
        endMessage.Visible = False
        ' add objects to bug array

        'function which adds objects with bug tag to bugArray array.
        initialiseBugs()
    End Sub

    Private Sub GemCollector_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        Select Case e.KeyValue
            Case Keys.Right
                moveRight = True
            Case Keys.Up
                moveUp = True
            Case Keys.Left
                moveLeft = True
            Case Keys.Down
                moveDown = True

        End Select
    End Sub

    Private Sub GemCollector_KeyUp(sender As Object, e As KeyEventArgs) Handles MyBase.KeyUp
        Select Case e.KeyValue
            Case Keys.Right
                moveRight = False
            Case Keys.Up
                moveUp = False
            Case Keys.Left
                moveLeft = False
            Case Keys.Down
                moveDown = False
            Case Keys.N
                ' reset position of bug
                bug.Top = 300
                bug.Left = 300
                ' reset position of boy
                boy.Left = 0
                boy.Top = 0
                lives = 3
                livesLabel.Text = "Lives: " & lives
                score = 0
                scoreLabel.Text = "Score: " & score
                moveRight = False
                moveUp = False
                moveDown = False
                moveLeft = False
                Timer1.Start()
                endMessage.Visible = False
                currentBugNumber = 2
                'reset bug positions &  number of bugs
                initialiseBugs()

            Case Keys.B
                GameLevels.Show()
                Me.Hide()
            Case Keys.I
                increaseBug()
        End Select
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim i As Integer = 0
        Dim k As Integer = 0
        Dim j As Integer = 0

        ready = ready - 10
        Dim Collided As Boolean = False

        ' only move towards that direction if the boy is not touching the screen boundaries
        ' if the boy's x coordinate plus the boy's width is smaller than the window width
        If moveRight = True And (boy.Left + boy.Width < Me.Width) Then
            boy.Left = boy.Left + 5
        End If
        If moveLeft = True And boy.Left > 0 Then
            boy.Left = boy.Left - 5
        End If
        If moveUp = True And boy.Top > 0 Then
            boy.Top = boy.Top - 5
        End If
        If moveDown = True And boy.Top + 1.5 * boy.Height < Me.Height Then
            boy.Top = boy.Top + 5
        End If
        If Collision(boy, gem) = True Then
            gem.Top = Int(Rnd() * (440 - 2 * gem.Height) + gem.Height)
            gem.Left = Int(Rnd() * (600 - 2 * gem.Width) + gem.Width)
            gem.BringToFront()
            Debug.WriteLine("gem top: " & gem.Top)
            Debug.WriteLine("gem left: " & gem.Left)
            score = score + 1
            scoreLabel.Text = "Score: " & score
            ''every time I collect 5 gems, increase the number of bugs, add 0.1 to the speed of the bugs, and make myself invincible for 1 second.
            If (score > 0) And (score Mod 5 = 0) Then
                increaseBug()
                ready = 1000
                bugSpeed += 0.1

            End If
        End If

        If ready > 0 Then
            boy.BackColor = Color.Aqua
        Else
            boy.BackColor = Color.White
        End If
        ' after the initial second has passed, if there is a collision between boy and any of the bugs, turn collided variable to true.
        If ready < 0 Then
            For i = 0 To currentBugNumber
                If Collision(boy, bugArray(i)) Then
                    Collided = True
                    ' reset position of bug
                End If
            Next
        End If

        'If the boy collides with the enemy then do the following
        If Collided = True Then
            For i = 0 To currentBugNumber
                ' assign random position to bugs
                AssignRandomPosition(bugArray(i))
            Next
            lives = lives - 1
            livesLabel.Text = "Lives: " & lives
            'reset position of boy
            boy.Top = 89
            boy.Left = 4
            ready = 1000
            If lives = 0 Then
                Timer1.Stop()
                MsgBox("game over")
                ' display message saying start new game or go back to main menu
                endMessage.Visible = True
                If score > highScore Then
                    highScore = score
                    highScoreLabel.Text = "High Score: " & highScore
                End If

            End If
            Collided = False
        End If

        ' make the bug chases the main character around
        For i = 0 To currentBugNumber
            Chase(bugArray(i), boy)
        Next

        ' if two bugs come too close to each other, make them bounce off each other.
        i = 0
        j = 0
        ' k = the number of bugs
        k = currentBugNumber
        For j = 0 To k - 1
            For i = 1 To k
                If i + j <= k Then
                    bounceOff(bugArray(j), bugArray(j + i))
                End If
            Next
        Next
    End Sub

    Private Function Collision(ByVal Object1 As Object, ByVal Object2 As Object) As Boolean
        Dim Collided As Boolean = False
        If Object1.Top + Object1.Height >= Object2.Top And
            Object2.Top + Object2.Height >= Object1.Top And
            Object1.Left + Object1.Width >= Object2.Left And
            Object2.Left + Object2.Width >= Object1.Left And Object1.visible = True And Object2.visible = True Then
            Collided = True
        End If
        Return Collided
    End Function

    Private Function Chase(ByRef Object1 As Object, ByRef Object2 As Object)
        ' if the enemy object is to the right of the player character, the enemy object will move to the left
        If Object1.Left + Object1.Width > Object2.Left Then
            Object1.Left -= bugSpeed
        End If

        ' if the enemy object is to the left of the player character, the enemy object will move to the right
        If Object1.Left + Object1.Width < Object2.Left Then
            Object1.Left += bugSpeed
        End If

        ' if the enemy object is lower than the player character, the enemy object will move up
        If Object1.Top + Object1.Height > Object2.Top Then
            Object1.Top -= bugSpeed
        End If

        ' if the enemy object is higher than the player character, the enemy object will move down
        If Object1.Top + Object1.Height < Object2.Top Then
            Object1.Top += bugSpeed
        End If
    End Function

    Private Function AssignRandomPosition(ByRef Obj5 As Object)
        Obj5.Top = Int(Rnd() * (440 - 2 * Obj5.Height) + Obj5.Height)
        Obj5.Left = Int(Rnd() * (600 - 2 * Obj5.Width) + Obj5.Width)
    End Function

    Private Function bounceOff(ByRef Obj1 As Object, ByRef Obj2 As Object)
        If Collision(Obj1, Obj2) Then
            ' check if object 1 is on the right of object 2. If yes, then move object 1 to the right and object 2 to the left.
            If (Obj1.Left > Obj2.Left) Then
                Obj1.Left += 1
                Obj2.Left -= 1
            Else
                ' if object 2 is on the right object 1, then move object 2 to the right and object 1 to the left.
                Obj1.Left -= 1
                Obj2.Left += 1
            End If

            If (Obj1.Top > Obj2.Top) Then
                Obj1.Top += 1
                Obj2.Top -= 1
            Else
                ' if object 2 is on the right object 1, then move object 2 to the right and object 1 to the left.
                Obj1.Top -= 1
                Obj2.Top += 1
            End If

        End If

    End Function


    'this function increases the number of bugs by 1
    Private Function increaseBug()
        If currentBugNumber < maxBugNumber Then
            currentBugNumber += 1
            bugArray(currentBugNumber).Visible = True
        End If

    End Function

    Private Function initialiseBugs()
        Dim i As Integer = 0
        For Each obj In Me.Controls
            If TypeOf obj Is PictureBox AndAlso obj.tag = "bug" Then
                bugArray(i) = obj
                i += 1
            End If
        Next
        For i = 0 To maxBugNumber
            bugArray(i).Visible = False
        Next
        For i = 0 To currentBugNumber
            bugArray(i).Visible = True
        Next
    End Function
End Class