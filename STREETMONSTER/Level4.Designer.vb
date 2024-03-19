<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Level4
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Level4))
        Me.lblGameOver = New System.Windows.Forms.Label()
        Me.lblYourScore = New System.Windows.Forms.Label()
        Me.lblScore = New System.Windows.Forms.Label()
        Me.lblTime = New System.Windows.Forms.Label()
        Me.lblNewHighScore = New System.Windows.Forms.Label()
        Me.chbName = New System.Windows.Forms.CheckBox()
        Me.btnReplay = New System.Windows.Forms.Button()
        Me.Menukey = New System.Windows.Forms.Button()
        Me.tmrCarStart = New System.Windows.Forms.Timer(Me.components)
        Me.tmrCar1Move = New System.Windows.Forms.Timer(Me.components)
        Me.tmrCar2Move = New System.Windows.Forms.Timer(Me.components)
        Me.tmrCar1Change = New System.Windows.Forms.Timer(Me.components)
        Me.tmrCar2Change = New System.Windows.Forms.Timer(Me.components)
        Me.tmrTime = New System.Windows.Forms.Timer(Me.components)
        Me.tmrObstacles1 = New System.Windows.Forms.Timer(Me.components)
        Me.tmrObstacles2 = New System.Windows.Forms.Timer(Me.components)
        Me.tmrWaiting = New System.Windows.Forms.Timer(Me.components)
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnStart = New System.Windows.Forms.Button()
        Me.btnRate = New System.Windows.Forms.Button()
        Me.pcbCar2 = New System.Windows.Forms.PictureBox()
        Me.pcbCarGas2 = New System.Windows.Forms.PictureBox()
        Me.pcbCar1 = New System.Windows.Forms.PictureBox()
        Me.pcbCarGas1 = New System.Windows.Forms.PictureBox()
        Me.pcbObstacle22 = New System.Windows.Forms.PictureBox()
        Me.pcbObstacle21 = New System.Windows.Forms.PictureBox()
        Me.pcbObstacle12 = New System.Windows.Forms.PictureBox()
        Me.pcbObstacle11 = New System.Windows.Forms.PictureBox()
        Me.pcbBackground = New System.Windows.Forms.PictureBox()
        Me.GroupBox1.SuspendLayout()
        CType(Me.pcbCar2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pcbCarGas2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pcbCar1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pcbCarGas1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pcbObstacle22, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pcbObstacle21, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pcbObstacle12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pcbObstacle11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pcbBackground, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblGameOver
        '
        Me.lblGameOver.AutoSize = True
        Me.lblGameOver.BackColor = System.Drawing.Color.Transparent
        Me.lblGameOver.Font = New System.Drawing.Font("Stencil", 50.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGameOver.ForeColor = System.Drawing.Color.Red
        Me.lblGameOver.Location = New System.Drawing.Point(0, -3)
        Me.lblGameOver.Name = "lblGameOver"
        Me.lblGameOver.Size = New System.Drawing.Size(384, 80)
        Me.lblGameOver.TabIndex = 1
        Me.lblGameOver.Text = "GAMEOVER"
        Me.lblGameOver.Visible = False
        '
        'lblYourScore
        '
        Me.lblYourScore.AutoSize = True
        Me.lblYourScore.BackColor = System.Drawing.Color.Transparent
        Me.lblYourScore.Font = New System.Drawing.Font("Palatino Linotype", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblYourScore.ForeColor = System.Drawing.Color.White
        Me.lblYourScore.Location = New System.Drawing.Point(152, 96)
        Me.lblYourScore.Name = "lblYourScore"
        Me.lblYourScore.Size = New System.Drawing.Size(69, 87)
        Me.lblYourScore.TabIndex = 6
        Me.lblYourScore.Text = "0"
        Me.lblYourScore.Visible = False
        '
        'lblScore
        '
        Me.lblScore.AutoSize = True
        Me.lblScore.Font = New System.Drawing.Font("Palatino Linotype", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblScore.ForeColor = System.Drawing.Color.White
        Me.lblScore.Location = New System.Drawing.Point(177, 513)
        Me.lblScore.Name = "lblScore"
        Me.lblScore.Size = New System.Drawing.Size(36, 44)
        Me.lblScore.TabIndex = 7
        Me.lblScore.Text = "0"
        Me.lblScore.Visible = False
        '
        'lblTime
        '
        Me.lblTime.AutoSize = True
        Me.lblTime.Font = New System.Drawing.Font("Palatino Linotype", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTime.ForeColor = System.Drawing.Color.White
        Me.lblTime.Location = New System.Drawing.Point(336, 314)
        Me.lblTime.Name = "lblTime"
        Me.lblTime.Size = New System.Drawing.Size(36, 44)
        Me.lblTime.TabIndex = 8
        Me.lblTime.Text = "0"
        Me.lblTime.Visible = False
        '
        'lblNewHighScore
        '
        Me.lblNewHighScore.AutoSize = True
        Me.lblNewHighScore.BackColor = System.Drawing.Color.Transparent
        Me.lblNewHighScore.Font = New System.Drawing.Font("Bookman Old Style", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNewHighScore.ForeColor = System.Drawing.Color.Red
        Me.lblNewHighScore.Location = New System.Drawing.Point(1, 314)
        Me.lblNewHighScore.Name = "lblNewHighScore"
        Me.lblNewHighScore.Size = New System.Drawing.Size(137, 44)
        Me.lblNewHighScore.TabIndex = 9
        Me.lblNewHighScore.Text = "NEW " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "HIGHSCORE" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.lblNewHighScore.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.lblNewHighScore.Visible = False
        '
        'chbName
        '
        Me.chbName.AutoSize = True
        Me.chbName.BackColor = System.Drawing.Color.Transparent
        Me.chbName.Font = New System.Drawing.Font("Bookman Old Style", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chbName.Location = New System.Drawing.Point(261, 285)
        Me.chbName.Name = "chbName"
        Me.chbName.Size = New System.Drawing.Size(123, 26)
        Me.chbName.TabIndex = 10
        Me.chbName.Text = "NO NAME"
        Me.chbName.UseVisualStyleBackColor = False
        Me.chbName.Visible = False
        '
        'btnReplay
        '
        Me.btnReplay.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnReplay.Font = New System.Drawing.Font("Bookman Old Style", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReplay.ForeColor = System.Drawing.Color.Aqua
        Me.btnReplay.Location = New System.Drawing.Point(144, 314)
        Me.btnReplay.Name = "btnReplay"
        Me.btnReplay.Size = New System.Drawing.Size(106, 34)
        Me.btnReplay.TabIndex = 11
        Me.btnReplay.Text = "REPLAY"
        Me.btnReplay.UseVisualStyleBackColor = False
        Me.btnReplay.Visible = False
        '
        'Menukey
        '
        Me.Menukey.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Menukey.Font = New System.Drawing.Font("Bookman Old Style", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Menukey.ForeColor = System.Drawing.Color.Aqua
        Me.Menukey.Location = New System.Drawing.Point(124, 361)
        Me.Menukey.Name = "Menukey"
        Me.Menukey.Size = New System.Drawing.Size(139, 36)
        Me.Menukey.TabIndex = 12
        Me.Menukey.Text = "Main Menu"
        Me.Menukey.UseVisualStyleBackColor = False
        Me.Menukey.Visible = False
        '
        'tmrCarStart
        '
        Me.tmrCarStart.Interval = 1
        '
        'tmrCar1Move
        '
        Me.tmrCar1Move.Interval = 1
        '
        'tmrCar2Move
        '
        Me.tmrCar2Move.Interval = 1
        '
        'tmrCar1Change
        '
        Me.tmrCar1Change.Interval = 1
        '
        'tmrCar2Change
        '
        Me.tmrCar2Change.Interval = 1
        '
        'tmrTime
        '
        Me.tmrTime.Interval = 1000
        '
        'tmrObstacles1
        '
        Me.tmrObstacles1.Interval = 1
        '
        'tmrObstacles2
        '
        Me.tmrObstacles2.Interval = 1
        '
        'tmrWaiting
        '
        Me.tmrWaiting.Interval = 1000
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.GroupBox1.Controls.Add(Me.btnRate)
        Me.GroupBox1.Controls.Add(Me.btnStart)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(-5, -14)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(394, 581)
        Me.GroupBox1.TabIndex = 17
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "GroupBox1"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("Bookman Old Style", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Red
        Me.Label1.Location = New System.Drawing.Point(41, 44)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(298, 35)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "To Play This Game"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(15, 110)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(367, 152)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = resources.GetString("Label2.Text")
        '
        'btnStart
        '
        Me.btnStart.BackColor = System.Drawing.Color.Black
        Me.btnStart.Font = New System.Drawing.Font("Cooper Black", 15.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStart.ForeColor = System.Drawing.Color.White
        Me.btnStart.Location = New System.Drawing.Point(97, 321)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(183, 37)
        Me.btnStart.TabIndex = 2
        Me.btnStart.Text = "START GAME"
        Me.btnStart.UseVisualStyleBackColor = False
        '
        'btnRate
        '
        Me.btnRate.BackColor = System.Drawing.Color.Black
        Me.btnRate.Font = New System.Drawing.Font("Cooper Black", 15.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRate.ForeColor = System.Drawing.Color.White
        Me.btnRate.Location = New System.Drawing.Point(80, 375)
        Me.btnRate.Name = "btnRate"
        Me.btnRate.Size = New System.Drawing.Size(224, 47)
        Me.btnRate.TabIndex = 3
        Me.btnRate.Text = "RATE THE GAME"
        Me.btnRate.UseVisualStyleBackColor = False
        '
        'pcbCar2
        '
        Me.pcbCar2.BackColor = System.Drawing.Color.Transparent
        Me.pcbCar2.Image = Global.STREETMONSTER.My.Resources.Resources.car22
        Me.pcbCar2.Location = New System.Drawing.Point(305, 405)
        Me.pcbCar2.Name = "pcbCar2"
        Me.pcbCar2.Size = New System.Drawing.Size(55, 75)
        Me.pcbCar2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pcbCar2.TabIndex = 14
        Me.pcbCar2.TabStop = False
        '
        'pcbCarGas2
        '
        Me.pcbCarGas2.Image = Global.STREETMONSTER.My.Resources.Resources.CarStartGif1
        Me.pcbCarGas2.Location = New System.Drawing.Point(316, 474)
        Me.pcbCarGas2.Name = "pcbCarGas2"
        Me.pcbCarGas2.Size = New System.Drawing.Size(44, 34)
        Me.pcbCarGas2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pcbCarGas2.TabIndex = 16
        Me.pcbCarGas2.TabStop = False
        '
        'pcbCar1
        '
        Me.pcbCar1.BackColor = System.Drawing.Color.Transparent
        Me.pcbCar1.Image = Global.STREETMONSTER.My.Resources.Resources.car111
        Me.pcbCar1.Location = New System.Drawing.Point(14, 405)
        Me.pcbCar1.Name = "pcbCar1"
        Me.pcbCar1.Size = New System.Drawing.Size(55, 75)
        Me.pcbCar1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pcbCar1.TabIndex = 13
        Me.pcbCar1.TabStop = False
        '
        'pcbCarGas1
        '
        Me.pcbCarGas1.Image = Global.STREETMONSTER.My.Resources.Resources.CarStartGif1
        Me.pcbCarGas1.Location = New System.Drawing.Point(25, 474)
        Me.pcbCarGas1.Name = "pcbCarGas1"
        Me.pcbCarGas1.Size = New System.Drawing.Size(44, 34)
        Me.pcbCarGas1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pcbCarGas1.TabIndex = 15
        Me.pcbCarGas1.TabStop = False
        '
        'pcbObstacle22
        '
        Me.pcbObstacle22.BackColor = System.Drawing.Color.Transparent
        Me.pcbObstacle22.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pcbObstacle22.Image = Global.STREETMONSTER.My.Resources.Resources.Circle2
        Me.pcbObstacle22.Location = New System.Drawing.Point(316, 32)
        Me.pcbObstacle22.Name = "pcbObstacle22"
        Me.pcbObstacle22.Size = New System.Drawing.Size(44, 38)
        Me.pcbObstacle22.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pcbObstacle22.TabIndex = 5
        Me.pcbObstacle22.TabStop = False
        Me.pcbObstacle22.Visible = False
        '
        'pcbObstacle21
        '
        Me.pcbObstacle21.BackColor = System.Drawing.Color.Transparent
        Me.pcbObstacle21.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pcbObstacle21.Image = Global.STREETMONSTER.My.Resources.Resources.Circle2
        Me.pcbObstacle21.Location = New System.Drawing.Point(219, 32)
        Me.pcbObstacle21.Name = "pcbObstacle21"
        Me.pcbObstacle21.Size = New System.Drawing.Size(44, 38)
        Me.pcbObstacle21.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pcbObstacle21.TabIndex = 4
        Me.pcbObstacle21.TabStop = False
        Me.pcbObstacle21.Visible = False
        '
        'pcbObstacle12
        '
        Me.pcbObstacle12.BackColor = System.Drawing.Color.Transparent
        Me.pcbObstacle12.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pcbObstacle12.Image = Global.STREETMONSTER.My.Resources.Resources.Circle1
        Me.pcbObstacle12.Location = New System.Drawing.Point(118, 32)
        Me.pcbObstacle12.Name = "pcbObstacle12"
        Me.pcbObstacle12.Size = New System.Drawing.Size(44, 38)
        Me.pcbObstacle12.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pcbObstacle12.TabIndex = 3
        Me.pcbObstacle12.TabStop = False
        Me.pcbObstacle12.Visible = False
        '
        'pcbObstacle11
        '
        Me.pcbObstacle11.BackColor = System.Drawing.Color.Transparent
        Me.pcbObstacle11.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pcbObstacle11.Image = Global.STREETMONSTER.My.Resources.Resources.Circle1
        Me.pcbObstacle11.Location = New System.Drawing.Point(23, 32)
        Me.pcbObstacle11.Name = "pcbObstacle11"
        Me.pcbObstacle11.Size = New System.Drawing.Size(44, 38)
        Me.pcbObstacle11.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pcbObstacle11.TabIndex = 2
        Me.pcbObstacle11.TabStop = False
        Me.pcbObstacle11.Visible = False
        '
        'pcbBackground
        '
        Me.pcbBackground.Image = Global.STREETMONSTER.My.Resources.Resources.Background
        Me.pcbBackground.Location = New System.Drawing.Point(-5, -3)
        Me.pcbBackground.Name = "pcbBackground"
        Me.pcbBackground.Size = New System.Drawing.Size(394, 570)
        Me.pcbBackground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pcbBackground.TabIndex = 0
        Me.pcbBackground.TabStop = False
        '
        'Level4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(384, 561)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.pcbCar2)
        Me.Controls.Add(Me.pcbCarGas2)
        Me.Controls.Add(Me.pcbCar1)
        Me.Controls.Add(Me.pcbCarGas1)
        Me.Controls.Add(Me.Menukey)
        Me.Controls.Add(Me.btnReplay)
        Me.Controls.Add(Me.chbName)
        Me.Controls.Add(Me.lblNewHighScore)
        Me.Controls.Add(Me.lblTime)
        Me.Controls.Add(Me.lblScore)
        Me.Controls.Add(Me.lblYourScore)
        Me.Controls.Add(Me.pcbObstacle22)
        Me.Controls.Add(Me.pcbObstacle21)
        Me.Controls.Add(Me.pcbObstacle12)
        Me.Controls.Add(Me.pcbObstacle11)
        Me.Controls.Add(Me.lblGameOver)
        Me.Controls.Add(Me.pcbBackground)
        Me.Name = "Level4"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Level4"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.pcbCar2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pcbCarGas2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pcbCar1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pcbCarGas1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pcbObstacle22, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pcbObstacle21, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pcbObstacle12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pcbObstacle11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pcbBackground, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents pcbBackground As PictureBox
    Friend WithEvents lblGameOver As Label
    Friend WithEvents pcbObstacle11 As PictureBox
    Friend WithEvents pcbObstacle12 As PictureBox
    Friend WithEvents pcbObstacle21 As PictureBox
    Friend WithEvents pcbObstacle22 As PictureBox
    Friend WithEvents lblYourScore As Label
    Friend WithEvents lblScore As Label
    Friend WithEvents lblTime As Label
    Friend WithEvents lblNewHighScore As Label
    Friend WithEvents chbName As CheckBox
    Friend WithEvents btnReplay As Button
    Friend WithEvents Menukey As Button
    Friend WithEvents pcbCar1 As PictureBox
    Friend WithEvents pcbCar2 As PictureBox
    Friend WithEvents pcbCarGas1 As PictureBox
    Friend WithEvents pcbCarGas2 As PictureBox
    Friend WithEvents tmrCarStart As Timer
    Friend WithEvents tmrCar1Move As Timer
    Friend WithEvents tmrCar2Move As Timer
    Friend WithEvents tmrCar1Change As Timer
    Friend WithEvents tmrCar2Change As Timer
    Friend WithEvents tmrTime As Timer
    Friend WithEvents tmrObstacles1 As Timer
    Friend WithEvents tmrObstacles2 As Timer
    Friend WithEvents tmrWaiting As Timer
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btnStart As Button
    Friend WithEvents btnRate As Button
End Class
