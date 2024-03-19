<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Level3
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.lblGameOver = New System.Windows.Forms.Label()
        Me.lblYourScore = New System.Windows.Forms.Label()
        Me.lblNewHighScore = New System.Windows.Forms.Label()
        Me.lblTime = New System.Windows.Forms.Label()
        Me.lblScore = New System.Windows.Forms.Label()
        Me.chbName = New System.Windows.Forms.CheckBox()
        Me.btnReplay = New System.Windows.Forms.Button()
        Me.tmrCarStart = New System.Windows.Forms.Timer(Me.components)
        Me.tmrCar1Move = New System.Windows.Forms.Timer(Me.components)
        Me.tmrcar2Move = New System.Windows.Forms.Timer(Me.components)
        Me.tmrCar1Change = New System.Windows.Forms.Timer(Me.components)
        Me.tmrCar2Change = New System.Windows.Forms.Timer(Me.components)
        Me.tmrTime = New System.Windows.Forms.Timer(Me.components)
        Me.tmrObstacles1 = New System.Windows.Forms.Timer(Me.components)
        Me.tmrObstacles2 = New System.Windows.Forms.Timer(Me.components)
        Me.tmrWaiting = New System.Windows.Forms.Timer(Me.components)
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Menukey = New System.Windows.Forms.Button()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
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
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.lblGameOver.Location = New System.Drawing.Point(0, 9)
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
        Me.lblYourScore.Font = New System.Drawing.Font("Microsoft YaHei UI", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblYourScore.ForeColor = System.Drawing.SystemColors.Control
        Me.lblYourScore.Location = New System.Drawing.Point(156, 109)
        Me.lblYourScore.Name = "lblYourScore"
        Me.lblYourScore.Size = New System.Drawing.Size(76, 86)
        Me.lblYourScore.TabIndex = 6
        Me.lblYourScore.Text = "0"
        Me.lblYourScore.Visible = False
        '
        'lblNewHighScore
        '
        Me.lblNewHighScore.AutoSize = True
        Me.lblNewHighScore.BackColor = System.Drawing.Color.Transparent
        Me.lblNewHighScore.Font = New System.Drawing.Font("Bookman Old Style", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNewHighScore.ForeColor = System.Drawing.Color.Red
        Me.lblNewHighScore.Location = New System.Drawing.Point(9, 273)
        Me.lblNewHighScore.Name = "lblNewHighScore"
        Me.lblNewHighScore.Size = New System.Drawing.Size(112, 44)
        Me.lblNewHighScore.TabIndex = 7
        Me.lblNewHighScore.Text = "New" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "HighScore"
        Me.lblNewHighScore.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.lblNewHighScore.Visible = False
        '
        'lblTime
        '
        Me.lblTime.AutoSize = True
        Me.lblTime.BackColor = System.Drawing.Color.Transparent
        Me.lblTime.Font = New System.Drawing.Font("Microsoft YaHei UI", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTime.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.lblTime.Location = New System.Drawing.Point(315, 324)
        Me.lblTime.Name = "lblTime"
        Me.lblTime.Size = New System.Drawing.Size(35, 39)
        Me.lblTime.TabIndex = 8
        Me.lblTime.Text = "0"
        Me.lblTime.Visible = False
        '
        'lblScore
        '
        Me.lblScore.AutoSize = True
        Me.lblScore.BackColor = System.Drawing.Color.Transparent
        Me.lblScore.Font = New System.Drawing.Font("Microsoft YaHei UI", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblScore.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblScore.Location = New System.Drawing.Point(164, 513)
        Me.lblScore.Name = "lblScore"
        Me.lblScore.Size = New System.Drawing.Size(35, 39)
        Me.lblScore.TabIndex = 9
        Me.lblScore.Text = "0"
        Me.lblScore.Visible = False
        '
        'chbName
        '
        Me.chbName.AutoSize = True
        Me.chbName.Font = New System.Drawing.Font("Bookman Old Style", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chbName.ForeColor = System.Drawing.Color.Black
        Me.chbName.Location = New System.Drawing.Point(249, 291)
        Me.chbName.Name = "chbName"
        Me.chbName.Size = New System.Drawing.Size(123, 26)
        Me.chbName.TabIndex = 10
        Me.chbName.Text = "NO NAME"
        Me.chbName.TextAlign = System.Drawing.ContentAlignment.TopLeft
        Me.chbName.UseVisualStyleBackColor = True
        Me.chbName.Visible = False
        '
        'btnReplay
        '
        Me.btnReplay.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnReplay.Font = New System.Drawing.Font("Bookman Old Style", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReplay.ForeColor = System.Drawing.Color.Red
        Me.btnReplay.Location = New System.Drawing.Point(139, 349)
        Me.btnReplay.Name = "btnReplay"
        Me.btnReplay.Size = New System.Drawing.Size(103, 39)
        Me.btnReplay.TabIndex = 11
        Me.btnReplay.Text = "REPLAY"
        Me.btnReplay.UseVisualStyleBackColor = False
        Me.btnReplay.Visible = False
        '
        'tmrCarStart
        '
        Me.tmrCarStart.Interval = 1
        '
        'tmrCar1Move
        '
        Me.tmrCar1Move.Interval = 1
        '
        'tmrcar2Move
        '
        Me.tmrcar2Move.Interval = 1
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
        Me.GroupBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.PictureBox2)
        Me.GroupBox1.Controls.Add(Me.PictureBox1)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(-1, -12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(385, 574)
        Me.GroupBox1.TabIndex = 16
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "GroupBox1"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Black
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.Font = New System.Drawing.Font("Cooper Black", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(87, 460)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(188, 46)
        Me.Button1.TabIndex = 7
        Me.Button1.Text = "START GAME"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Black
        Me.Label5.Font = New System.Drawing.Font("Malgun Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Yellow
        Me.Label5.Location = New System.Drawing.Point(126, 390)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(234, 20)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Escape From All The Rectangles" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Black
        Me.Label4.Font = New System.Drawing.Font("Malgun Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Yellow
        Me.Label4.Location = New System.Drawing.Point(128, 351)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(183, 20)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Do Not Leave Any Circle"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft YaHei UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(51, 303)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(114, 26)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "EXAMPLE :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Bookman Old Style", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Red
        Me.Label2.Location = New System.Drawing.Point(13, 97)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(360, 176)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "1. Press The Button 'A' To Move Car" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Left And RightSide." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "2. Collect All The Bl" &
    "ue Circles And" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Escape From The Blue Box." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "3. Double-Click On Level 4 To Play " &
    "" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "That Game."
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Gray
        Me.Label1.Font = New System.Drawing.Font("Arial Black", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(37, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(314, 41)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "To Play This Game"
        '
        'Menukey
        '
        Me.Menukey.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Menukey.Font = New System.Drawing.Font("Bookman Old Style", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Menukey.ForeColor = System.Drawing.Color.Red
        Me.Menukey.Location = New System.Drawing.Point(118, 403)
        Me.Menukey.Name = "Menukey"
        Me.Menukey.Size = New System.Drawing.Size(147, 39)
        Me.Menukey.TabIndex = 17
        Me.Menukey.Text = "Main Menu"
        Me.Menukey.UseVisualStyleBackColor = False
        Me.Menukey.Visible = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.STREETMONSTER.My.Resources.Resources.Rectangle1
        Me.PictureBox2.Location = New System.Drawing.Point(87, 390)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(35, 32)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 4
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.STREETMONSTER.My.Resources.Resources.Circle1
        Me.PictureBox1.Location = New System.Drawing.Point(87, 343)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(35, 32)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'pcbCar2
        '
        Me.pcbCar2.BackColor = System.Drawing.Color.Transparent
        Me.pcbCar2.Location = New System.Drawing.Point(311, 401)
        Me.pcbCar2.Name = "pcbCar2"
        Me.pcbCar2.Size = New System.Drawing.Size(48, 79)
        Me.pcbCar2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pcbCar2.TabIndex = 13
        Me.pcbCar2.TabStop = False
        '
        'pcbCarGas2
        '
        Me.pcbCarGas2.BackColor = System.Drawing.Color.Transparent
        Me.pcbCarGas2.Location = New System.Drawing.Point(322, 476)
        Me.pcbCarGas2.Name = "pcbCarGas2"
        Me.pcbCarGas2.Size = New System.Drawing.Size(37, 39)
        Me.pcbCarGas2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pcbCarGas2.TabIndex = 15
        Me.pcbCarGas2.TabStop = False
        '
        'pcbCar1
        '
        Me.pcbCar1.BackColor = System.Drawing.Color.Transparent
        Me.pcbCar1.Image = Global.STREETMONSTER.My.Resources.Resources.car111
        Me.pcbCar1.Location = New System.Drawing.Point(23, 401)
        Me.pcbCar1.Name = "pcbCar1"
        Me.pcbCar1.Size = New System.Drawing.Size(48, 79)
        Me.pcbCar1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pcbCar1.TabIndex = 12
        Me.pcbCar1.TabStop = False
        '
        'pcbCarGas1
        '
        Me.pcbCarGas1.BackColor = System.Drawing.Color.Transparent
        Me.pcbCarGas1.Image = Global.STREETMONSTER.My.Resources.Resources.CarStartGif
        Me.pcbCarGas1.Location = New System.Drawing.Point(34, 476)
        Me.pcbCarGas1.Name = "pcbCarGas1"
        Me.pcbCarGas1.Size = New System.Drawing.Size(37, 39)
        Me.pcbCarGas1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pcbCarGas1.TabIndex = 14
        Me.pcbCarGas1.TabStop = False
        '
        'pcbObstacle22
        '
        Me.pcbObstacle22.BackColor = System.Drawing.Color.Transparent
        Me.pcbObstacle22.Image = Global.STREETMONSTER.My.Resources.Resources.Circle2
        Me.pcbObstacle22.Location = New System.Drawing.Point(313, 32)
        Me.pcbObstacle22.Name = "pcbObstacle22"
        Me.pcbObstacle22.Size = New System.Drawing.Size(46, 41)
        Me.pcbObstacle22.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pcbObstacle22.TabIndex = 5
        Me.pcbObstacle22.TabStop = False
        '
        'pcbObstacle21
        '
        Me.pcbObstacle21.BackColor = System.Drawing.Color.Transparent
        Me.pcbObstacle21.Image = Global.STREETMONSTER.My.Resources.Resources.Circle2
        Me.pcbObstacle21.Location = New System.Drawing.Point(219, 32)
        Me.pcbObstacle21.Name = "pcbObstacle21"
        Me.pcbObstacle21.Size = New System.Drawing.Size(46, 41)
        Me.pcbObstacle21.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pcbObstacle21.TabIndex = 4
        Me.pcbObstacle21.TabStop = False
        '
        'pcbObstacle12
        '
        Me.pcbObstacle12.BackColor = System.Drawing.Color.Transparent
        Me.pcbObstacle12.Image = Global.STREETMONSTER.My.Resources.Resources.Circle1
        Me.pcbObstacle12.Location = New System.Drawing.Point(118, 32)
        Me.pcbObstacle12.Name = "pcbObstacle12"
        Me.pcbObstacle12.Size = New System.Drawing.Size(46, 41)
        Me.pcbObstacle12.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pcbObstacle12.TabIndex = 3
        Me.pcbObstacle12.TabStop = False
        '
        'pcbObstacle11
        '
        Me.pcbObstacle11.BackColor = System.Drawing.Color.Transparent
        Me.pcbObstacle11.Image = Global.STREETMONSTER.My.Resources.Resources.Circle1
        Me.pcbObstacle11.Location = New System.Drawing.Point(23, 32)
        Me.pcbObstacle11.Name = "pcbObstacle11"
        Me.pcbObstacle11.Size = New System.Drawing.Size(46, 41)
        Me.pcbObstacle11.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pcbObstacle11.TabIndex = 2
        Me.pcbObstacle11.TabStop = False
        '
        'pcbBackground
        '
        Me.pcbBackground.Image = Global.STREETMONSTER.My.Resources.Resources.Background
        Me.pcbBackground.Location = New System.Drawing.Point(-7, 0)
        Me.pcbBackground.Name = "pcbBackground"
        Me.pcbBackground.Size = New System.Drawing.Size(393, 562)
        Me.pcbBackground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pcbBackground.TabIndex = 0
        Me.pcbBackground.TabStop = False
        '
        'Level3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(384, 561)
        Me.Controls.Add(Me.Menukey)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.pcbCar2)
        Me.Controls.Add(Me.pcbCarGas2)
        Me.Controls.Add(Me.pcbCar1)
        Me.Controls.Add(Me.pcbCarGas1)
        Me.Controls.Add(Me.btnReplay)
        Me.Controls.Add(Me.chbName)
        Me.Controls.Add(Me.lblScore)
        Me.Controls.Add(Me.lblTime)
        Me.Controls.Add(Me.lblNewHighScore)
        Me.Controls.Add(Me.lblYourScore)
        Me.Controls.Add(Me.pcbObstacle22)
        Me.Controls.Add(Me.pcbObstacle21)
        Me.Controls.Add(Me.pcbObstacle12)
        Me.Controls.Add(Me.pcbObstacle11)
        Me.Controls.Add(Me.lblGameOver)
        Me.Controls.Add(Me.pcbBackground)
        Me.Name = "Level3"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Level3"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents lblNewHighScore As Label
    Friend WithEvents lblTime As Label
    Friend WithEvents lblScore As Label
    Friend WithEvents chbName As CheckBox
    Friend WithEvents btnReplay As Button
    Friend WithEvents pcbCar1 As PictureBox
    Friend WithEvents pcbCar2 As PictureBox
    Friend WithEvents pcbCarGas1 As PictureBox
    Friend WithEvents pcbCarGas2 As PictureBox
    Friend WithEvents tmrCarStart As Timer
    Friend WithEvents tmrCar1Move As Timer
    Friend WithEvents tmrcar2Move As Timer
    Friend WithEvents tmrCar1Change As Timer
    Friend WithEvents tmrCar2Change As Timer
    Friend WithEvents tmrTime As Timer
    Friend WithEvents tmrObstacles1 As Timer
    Friend WithEvents tmrObstacles2 As Timer
    Friend WithEvents tmrWaiting As Timer
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Menukey As Button
End Class
