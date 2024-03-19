<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Level2
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Level2))
        Me.ScoreText = New System.Windows.Forms.Label()
        Me.SpeedText = New System.Windows.Forms.Label()
        Me.Pausekey = New System.Windows.Forms.Label()
        Me.RoadMover = New System.Windows.Forms.Timer(Me.components)
        Me.RightSide = New System.Windows.Forms.Timer(Me.components)
        Me.LeftSide = New System.Windows.Forms.Timer(Me.components)
        Me.Racer1Move = New System.Windows.Forms.Timer(Me.components)
        Me.Racer2Move = New System.Windows.Forms.Timer(Me.components)
        Me.Racer3Move = New System.Windows.Forms.Timer(Me.components)
        Me.Playkey = New System.Windows.Forms.Button()
        Me.RestartKey = New System.Windows.Forms.Button()
        Me.Menukey = New System.Windows.Forms.Button()
        Me.Gameover_text = New System.Windows.Forms.Label()
        Me.Playagainkey = New System.Windows.Forms.Label()
        Me.Quitkey = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PictureBox19 = New System.Windows.Forms.PictureBox()
        Me.GameoverScreen = New System.Windows.Forms.PictureBox()
        Me.PauseScreen = New System.Windows.Forms.PictureBox()
        Me.Racer3 = New System.Windows.Forms.PictureBox()
        Me.Racer2 = New System.Windows.Forms.PictureBox()
        Me.Racer1 = New System.Windows.Forms.PictureBox()
        Me.Bike = New System.Windows.Forms.PictureBox()
        Me.PictureBox17 = New System.Windows.Forms.PictureBox()
        Me.PictureBox18 = New System.Windows.Forms.PictureBox()
        Me.PictureBox15 = New System.Windows.Forms.PictureBox()
        Me.PictureBox16 = New System.Windows.Forms.PictureBox()
        Me.PictureBox13 = New System.Windows.Forms.PictureBox()
        Me.PictureBox14 = New System.Windows.Forms.PictureBox()
        Me.PictureBox11 = New System.Windows.Forms.PictureBox()
        Me.PictureBox12 = New System.Windows.Forms.PictureBox()
        Me.PictureBox9 = New System.Windows.Forms.PictureBox()
        Me.PictureBox10 = New System.Windows.Forms.PictureBox()
        Me.PictureBox7 = New System.Windows.Forms.PictureBox()
        Me.PictureBox8 = New System.Windows.Forms.PictureBox()
        Me.PictureBox6 = New System.Windows.Forms.PictureBox()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox19, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GameoverScreen, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PauseScreen, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Racer3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Racer2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Racer1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Bike, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox17, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox18, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox15, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox16, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox13, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox14, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ScoreText
        '
        Me.ScoreText.AutoSize = True
        Me.ScoreText.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ScoreText.ForeColor = System.Drawing.Color.Blue
        Me.ScoreText.Location = New System.Drawing.Point(101, 9)
        Me.ScoreText.Name = "ScoreText"
        Me.ScoreText.Size = New System.Drawing.Size(52, 17)
        Me.ScoreText.TabIndex = 22
        Me.ScoreText.Text = "Score 0"
        '
        'SpeedText
        '
        Me.SpeedText.AutoSize = True
        Me.SpeedText.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SpeedText.ForeColor = System.Drawing.Color.Blue
        Me.SpeedText.Location = New System.Drawing.Point(228, 9)
        Me.SpeedText.Name = "SpeedText"
        Me.SpeedText.Size = New System.Drawing.Size(56, 17)
        Me.SpeedText.TabIndex = 23
        Me.SpeedText.Text = "Speed 0"
        '
        'Pausekey
        '
        Me.Pausekey.AutoSize = True
        Me.Pausekey.BackColor = System.Drawing.Color.Black
        Me.Pausekey.Font = New System.Drawing.Font("Cooper Black", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Pausekey.ForeColor = System.Drawing.Color.Red
        Me.Pausekey.Location = New System.Drawing.Point(97, 44)
        Me.Pausekey.Name = "Pausekey"
        Me.Pausekey.Size = New System.Drawing.Size(56, 19)
        Me.Pausekey.TabIndex = 24
        Me.Pausekey.Text = "Pause"
        '
        'RoadMover
        '
        Me.RoadMover.Enabled = True
        Me.RoadMover.Interval = 10
        '
        'RightSide
        '
        Me.RightSide.Interval = 10
        '
        'LeftSide
        '
        Me.LeftSide.Interval = 10
        '
        'Racer1Move
        '
        Me.Racer1Move.Enabled = True
        Me.Racer1Move.Interval = 10
        '
        'Racer2Move
        '
        Me.Racer2Move.Enabled = True
        Me.Racer2Move.Interval = 10
        '
        'Racer3Move
        '
        Me.Racer3Move.Enabled = True
        Me.Racer3Move.Interval = 10
        '
        'Playkey
        '
        Me.Playkey.BackColor = System.Drawing.Color.Black
        Me.Playkey.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Playkey.Font = New System.Drawing.Font("Bookman Old Style", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Playkey.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Playkey.Location = New System.Drawing.Point(247, 29)
        Me.Playkey.Name = "Playkey"
        Me.Playkey.Size = New System.Drawing.Size(100, 48)
        Me.Playkey.TabIndex = 26
        Me.Playkey.Text = "PLAY"
        Me.Playkey.UseVisualStyleBackColor = False
        Me.Playkey.Visible = False
        '
        'RestartKey
        '
        Me.RestartKey.BackColor = System.Drawing.Color.Black
        Me.RestartKey.Cursor = System.Windows.Forms.Cursors.Hand
        Me.RestartKey.Font = New System.Drawing.Font("Bookman Old Style", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RestartKey.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.RestartKey.Location = New System.Drawing.Point(228, 83)
        Me.RestartKey.Name = "RestartKey"
        Me.RestartKey.Size = New System.Drawing.Size(144, 46)
        Me.RestartKey.TabIndex = 27
        Me.RestartKey.Text = "RESTART"
        Me.RestartKey.UseVisualStyleBackColor = False
        Me.RestartKey.Visible = False
        '
        'Menukey
        '
        Me.Menukey.BackColor = System.Drawing.Color.Black
        Me.Menukey.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Menukey.Font = New System.Drawing.Font("Bookman Old Style", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Menukey.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Menukey.Location = New System.Drawing.Point(215, 135)
        Me.Menukey.Name = "Menukey"
        Me.Menukey.Size = New System.Drawing.Size(171, 44)
        Me.Menukey.TabIndex = 28
        Me.Menukey.Text = "MAIN MENU"
        Me.Menukey.UseVisualStyleBackColor = False
        Me.Menukey.Visible = False
        '
        'Gameover_text
        '
        Me.Gameover_text.AutoSize = True
        Me.Gameover_text.BackColor = System.Drawing.Color.Black
        Me.Gameover_text.Font = New System.Drawing.Font("Stencil", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Gameover_text.ForeColor = System.Drawing.Color.White
        Me.Gameover_text.Location = New System.Drawing.Point(12, 103)
        Me.Gameover_text.Name = "Gameover_text"
        Me.Gameover_text.Size = New System.Drawing.Size(372, 76)
        Me.Gameover_text.TabIndex = 30
        Me.Gameover_text.Text = "GAMEOVER"
        Me.Gameover_text.Visible = False
        '
        'Playagainkey
        '
        Me.Playagainkey.AutoSize = True
        Me.Playagainkey.BackColor = System.Drawing.Color.Black
        Me.Playagainkey.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Playagainkey.Font = New System.Drawing.Font("Bookman Old Style", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Playagainkey.ForeColor = System.Drawing.Color.Yellow
        Me.Playagainkey.Location = New System.Drawing.Point(85, 226)
        Me.Playagainkey.Name = "Playagainkey"
        Me.Playagainkey.Size = New System.Drawing.Size(209, 41)
        Me.Playagainkey.TabIndex = 31
        Me.Playagainkey.Text = "Play Again"
        Me.Playagainkey.Visible = False
        '
        'Quitkey
        '
        Me.Quitkey.AutoSize = True
        Me.Quitkey.BackColor = System.Drawing.Color.Black
        Me.Quitkey.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Quitkey.Font = New System.Drawing.Font("Bookman Old Style", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Quitkey.ForeColor = System.Drawing.Color.Yellow
        Me.Quitkey.Location = New System.Drawing.Point(142, 285)
        Me.Quitkey.Name = "Quitkey"
        Me.Quitkey.Size = New System.Drawing.Size(98, 41)
        Me.Quitkey.TabIndex = 32
        Me.Quitkey.Text = "Quit"
        Me.Quitkey.Visible = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.PictureBox19)
        Me.GroupBox1.Location = New System.Drawing.Point(-5, -23)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(391, 588)
        Me.GroupBox1.TabIndex = 33
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "GroupBox1"
        Me.GroupBox1.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Black
        Me.Label1.Font = New System.Drawing.Font("Algerian", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Aqua
        Me.Label1.Location = New System.Drawing.Point(35, 210)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(354, 41)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "LEVEL COMPLETED"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Black
        Me.Label2.Font = New System.Drawing.Font("Algerian", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Red
        Me.Label2.Location = New System.Drawing.Point(86, 267)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(238, 41)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "NEXT LEVEL"
        '
        'PictureBox19
        '
        Me.PictureBox19.Image = CType(resources.GetObject("PictureBox19.Image"), System.Drawing.Image)
        Me.PictureBox19.Location = New System.Drawing.Point(-38, 19)
        Me.PictureBox19.Name = "PictureBox19"
        Me.PictureBox19.Size = New System.Drawing.Size(482, 569)
        Me.PictureBox19.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox19.TabIndex = 0
        Me.PictureBox19.TabStop = False
        '
        'GameoverScreen
        '
        Me.GameoverScreen.Image = Global.STREETMONSTER.My.Resources.Resources.speed2
        Me.GameoverScreen.Location = New System.Drawing.Point(-5, -9)
        Me.GameoverScreen.Name = "GameoverScreen"
        Me.GameoverScreen.Size = New System.Drawing.Size(402, 574)
        Me.GameoverScreen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.GameoverScreen.TabIndex = 29
        Me.GameoverScreen.TabStop = False
        Me.GameoverScreen.Visible = False
        '
        'PauseScreen
        '
        Me.PauseScreen.Image = Global.STREETMONSTER.My.Resources.Resources.Resume_Page_3
        Me.PauseScreen.Location = New System.Drawing.Point(-3, -9)
        Me.PauseScreen.Name = "PauseScreen"
        Me.PauseScreen.Size = New System.Drawing.Size(389, 574)
        Me.PauseScreen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PauseScreen.TabIndex = 25
        Me.PauseScreen.TabStop = False
        Me.PauseScreen.Visible = False
        '
        'Racer3
        '
        Me.Racer3.Image = Global.STREETMONSTER.My.Resources.Resources.bike3
        Me.Racer3.Location = New System.Drawing.Point(247, 152)
        Me.Racer3.Name = "Racer3"
        Me.Racer3.Size = New System.Drawing.Size(38, 76)
        Me.Racer3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Racer3.TabIndex = 21
        Me.Racer3.TabStop = False
        '
        'Racer2
        '
        Me.Racer2.Image = Global.STREETMONSTER.My.Resources.Resources.bike1
        Me.Racer2.Location = New System.Drawing.Point(167, -23)
        Me.Racer2.Name = "Racer2"
        Me.Racer2.Size = New System.Drawing.Size(38, 76)
        Me.Racer2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Racer2.TabIndex = 20
        Me.Racer2.TabStop = False
        '
        'Racer1
        '
        Me.Racer1.Image = Global.STREETMONSTER.My.Resources.Resources.bike4
        Me.Racer1.Location = New System.Drawing.Point(98, 285)
        Me.Racer1.Name = "Racer1"
        Me.Racer1.Size = New System.Drawing.Size(38, 76)
        Me.Racer1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Racer1.TabIndex = 19
        Me.Racer1.TabStop = False
        '
        'Bike
        '
        Me.Bike.Image = Global.STREETMONSTER.My.Resources.Resources.bike5
        Me.Bike.Location = New System.Drawing.Point(167, 457)
        Me.Bike.Name = "Bike"
        Me.Bike.Size = New System.Drawing.Size(38, 76)
        Me.Bike.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Bike.TabIndex = 18
        Me.Bike.TabStop = False
        '
        'PictureBox17
        '
        Me.PictureBox17.BackColor = System.Drawing.Color.Black
        Me.PictureBox17.Location = New System.Drawing.Point(291, 285)
        Me.PictureBox17.Name = "PictureBox17"
        Me.PictureBox17.Size = New System.Drawing.Size(4, 650)
        Me.PictureBox17.TabIndex = 17
        Me.PictureBox17.TabStop = False
        '
        'PictureBox18
        '
        Me.PictureBox18.BackColor = System.Drawing.Color.Black
        Me.PictureBox18.Location = New System.Drawing.Point(291, -352)
        Me.PictureBox18.Name = "PictureBox18"
        Me.PictureBox18.Size = New System.Drawing.Size(4, 650)
        Me.PictureBox18.TabIndex = 16
        Me.PictureBox18.TabStop = False
        '
        'PictureBox15
        '
        Me.PictureBox15.BackColor = System.Drawing.Color.Black
        Me.PictureBox15.Location = New System.Drawing.Point(88, 285)
        Me.PictureBox15.Name = "PictureBox15"
        Me.PictureBox15.Size = New System.Drawing.Size(4, 650)
        Me.PictureBox15.TabIndex = 15
        Me.PictureBox15.TabStop = False
        '
        'PictureBox16
        '
        Me.PictureBox16.BackColor = System.Drawing.Color.Black
        Me.PictureBox16.Location = New System.Drawing.Point(88, -352)
        Me.PictureBox16.Name = "PictureBox16"
        Me.PictureBox16.Size = New System.Drawing.Size(4, 650)
        Me.PictureBox16.TabIndex = 14
        Me.PictureBox16.TabStop = False
        '
        'PictureBox13
        '
        Me.PictureBox13.BackColor = System.Drawing.Color.White
        Me.PictureBox13.Location = New System.Drawing.Point(215, 515)
        Me.PictureBox13.Name = "PictureBox13"
        Me.PictureBox13.Size = New System.Drawing.Size(7, 114)
        Me.PictureBox13.TabIndex = 13
        Me.PictureBox13.TabStop = False
        '
        'PictureBox14
        '
        Me.PictureBox14.BackColor = System.Drawing.Color.White
        Me.PictureBox14.Location = New System.Drawing.Point(154, 515)
        Me.PictureBox14.Name = "PictureBox14"
        Me.PictureBox14.Size = New System.Drawing.Size(7, 114)
        Me.PictureBox14.TabIndex = 12
        Me.PictureBox14.TabStop = False
        '
        'PictureBox11
        '
        Me.PictureBox11.BackColor = System.Drawing.Color.White
        Me.PictureBox11.Location = New System.Drawing.Point(215, 369)
        Me.PictureBox11.Name = "PictureBox11"
        Me.PictureBox11.Size = New System.Drawing.Size(7, 114)
        Me.PictureBox11.TabIndex = 11
        Me.PictureBox11.TabStop = False
        '
        'PictureBox12
        '
        Me.PictureBox12.BackColor = System.Drawing.Color.White
        Me.PictureBox12.Location = New System.Drawing.Point(154, 369)
        Me.PictureBox12.Name = "PictureBox12"
        Me.PictureBox12.Size = New System.Drawing.Size(7, 114)
        Me.PictureBox12.TabIndex = 10
        Me.PictureBox12.TabStop = False
        '
        'PictureBox9
        '
        Me.PictureBox9.BackColor = System.Drawing.Color.White
        Me.PictureBox9.Location = New System.Drawing.Point(215, 226)
        Me.PictureBox9.Name = "PictureBox9"
        Me.PictureBox9.Size = New System.Drawing.Size(7, 114)
        Me.PictureBox9.TabIndex = 9
        Me.PictureBox9.TabStop = False
        '
        'PictureBox10
        '
        Me.PictureBox10.BackColor = System.Drawing.Color.White
        Me.PictureBox10.Location = New System.Drawing.Point(154, 226)
        Me.PictureBox10.Name = "PictureBox10"
        Me.PictureBox10.Size = New System.Drawing.Size(7, 114)
        Me.PictureBox10.TabIndex = 8
        Me.PictureBox10.TabStop = False
        '
        'PictureBox7
        '
        Me.PictureBox7.BackColor = System.Drawing.Color.White
        Me.PictureBox7.Location = New System.Drawing.Point(215, 83)
        Me.PictureBox7.Name = "PictureBox7"
        Me.PictureBox7.Size = New System.Drawing.Size(7, 114)
        Me.PictureBox7.TabIndex = 7
        Me.PictureBox7.TabStop = False
        '
        'PictureBox8
        '
        Me.PictureBox8.BackColor = System.Drawing.Color.White
        Me.PictureBox8.Location = New System.Drawing.Point(154, 83)
        Me.PictureBox8.Name = "PictureBox8"
        Me.PictureBox8.Size = New System.Drawing.Size(7, 114)
        Me.PictureBox8.TabIndex = 6
        Me.PictureBox8.TabStop = False
        '
        'PictureBox6
        '
        Me.PictureBox6.BackColor = System.Drawing.Color.White
        Me.PictureBox6.Location = New System.Drawing.Point(215, -60)
        Me.PictureBox6.Name = "PictureBox6"
        Me.PictureBox6.Size = New System.Drawing.Size(7, 114)
        Me.PictureBox6.TabIndex = 5
        Me.PictureBox6.TabStop = False
        '
        'PictureBox5
        '
        Me.PictureBox5.BackColor = System.Drawing.Color.White
        Me.PictureBox5.Location = New System.Drawing.Point(154, -60)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(7, 114)
        Me.PictureBox5.TabIndex = 4
        Me.PictureBox5.TabStop = False
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = Global.STREETMONSTER.My.Resources.Resources.snowright
        Me.PictureBox4.Location = New System.Drawing.Point(301, 285)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(85, 650)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox4.TabIndex = 3
        Me.PictureBox4.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = Global.STREETMONSTER.My.Resources.Resources.snowright
        Me.PictureBox3.Location = New System.Drawing.Point(301, -352)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(85, 650)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 2
        Me.PictureBox3.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.STREETMONSTER.My.Resources.Resources.snowleft
        Me.PictureBox2.Location = New System.Drawing.Point(-3, 285)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(85, 650)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 1
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.STREETMONSTER.My.Resources.Resources.snowleft
        Me.PictureBox1.Location = New System.Drawing.Point(-3, -352)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(85, 650)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Level2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(196, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(384, 561)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Quitkey)
        Me.Controls.Add(Me.Playagainkey)
        Me.Controls.Add(Me.Gameover_text)
        Me.Controls.Add(Me.GameoverScreen)
        Me.Controls.Add(Me.Menukey)
        Me.Controls.Add(Me.RestartKey)
        Me.Controls.Add(Me.Playkey)
        Me.Controls.Add(Me.PauseScreen)
        Me.Controls.Add(Me.Pausekey)
        Me.Controls.Add(Me.SpeedText)
        Me.Controls.Add(Me.ScoreText)
        Me.Controls.Add(Me.Racer3)
        Me.Controls.Add(Me.Racer2)
        Me.Controls.Add(Me.Racer1)
        Me.Controls.Add(Me.Bike)
        Me.Controls.Add(Me.PictureBox17)
        Me.Controls.Add(Me.PictureBox18)
        Me.Controls.Add(Me.PictureBox15)
        Me.Controls.Add(Me.PictureBox16)
        Me.Controls.Add(Me.PictureBox13)
        Me.Controls.Add(Me.PictureBox14)
        Me.Controls.Add(Me.PictureBox11)
        Me.Controls.Add(Me.PictureBox12)
        Me.Controls.Add(Me.PictureBox9)
        Me.Controls.Add(Me.PictureBox10)
        Me.Controls.Add(Me.PictureBox7)
        Me.Controls.Add(Me.PictureBox8)
        Me.Controls.Add(Me.PictureBox6)
        Me.Controls.Add(Me.PictureBox5)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "Level2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Level2"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox19, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GameoverScreen, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PauseScreen, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Racer3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Racer2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Racer1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Bike, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox17, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox18, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox15, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox16, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox13, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox14, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents PictureBox6 As PictureBox
    Friend WithEvents PictureBox7 As PictureBox
    Friend WithEvents PictureBox8 As PictureBox
    Friend WithEvents PictureBox9 As PictureBox
    Friend WithEvents PictureBox10 As PictureBox
    Friend WithEvents PictureBox11 As PictureBox
    Friend WithEvents PictureBox12 As PictureBox
    Friend WithEvents PictureBox13 As PictureBox
    Friend WithEvents PictureBox14 As PictureBox
    Friend WithEvents PictureBox15 As PictureBox
    Friend WithEvents PictureBox16 As PictureBox
    Friend WithEvents PictureBox17 As PictureBox
    Friend WithEvents PictureBox18 As PictureBox
    Friend WithEvents Bike As PictureBox
    Friend WithEvents Racer1 As PictureBox
    Friend WithEvents Racer2 As PictureBox
    Friend WithEvents Racer3 As PictureBox
    Friend WithEvents ScoreText As Label
    Friend WithEvents SpeedText As Label
    Friend WithEvents Pausekey As Label
    Friend WithEvents RoadMover As Timer
    Friend WithEvents RightSide As Timer
    Friend WithEvents LeftSide As Timer
    Friend WithEvents Racer1Move As Timer
    Friend WithEvents Racer2Move As Timer
    Friend WithEvents Racer3Move As Timer
    Friend WithEvents PauseScreen As PictureBox
    Friend WithEvents Playkey As Button
    Friend WithEvents RestartKey As Button
    Friend WithEvents Menukey As Button
    Friend WithEvents GameoverScreen As PictureBox
    Friend WithEvents Gameover_text As Label
    Friend WithEvents Playagainkey As Label
    Friend WithEvents Quitkey As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox19 As PictureBox
End Class
