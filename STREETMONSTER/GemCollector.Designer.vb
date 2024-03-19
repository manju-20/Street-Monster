<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class GemCollector
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(GemCollector))
        Me.scoreLabel = New System.Windows.Forms.Label()
        Me.highScoreLabel = New System.Windows.Forms.Label()
        Me.livesLabel = New System.Windows.Forms.Label()
        Me.endMessage = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.PictureBox8 = New System.Windows.Forms.PictureBox()
        Me.PictureBox7 = New System.Windows.Forms.PictureBox()
        Me.PictureBox6 = New System.Windows.Forms.PictureBox()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.bug = New System.Windows.Forms.PictureBox()
        Me.boy = New System.Windows.Forms.PictureBox()
        Me.gem = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bug, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.boy, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gem, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'scoreLabel
        '
        Me.scoreLabel.AutoSize = True
        Me.scoreLabel.Font = New System.Drawing.Font("Palatino Linotype", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.scoreLabel.Location = New System.Drawing.Point(2, -1)
        Me.scoreLabel.Name = "scoreLabel"
        Me.scoreLabel.Size = New System.Drawing.Size(76, 28)
        Me.scoreLabel.TabIndex = 0
        Me.scoreLabel.Text = "Score :"
        '
        'highScoreLabel
        '
        Me.highScoreLabel.AutoSize = True
        Me.highScoreLabel.Font = New System.Drawing.Font("Palatino Linotype", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.highScoreLabel.Location = New System.Drawing.Point(2, 40)
        Me.highScoreLabel.Name = "highScoreLabel"
        Me.highScoreLabel.Size = New System.Drawing.Size(127, 28)
        Me.highScoreLabel.TabIndex = 1
        Me.highScoreLabel.Text = "HighScore :"
        '
        'livesLabel
        '
        Me.livesLabel.AutoSize = True
        Me.livesLabel.Font = New System.Drawing.Font("Palatino Linotype", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.livesLabel.Location = New System.Drawing.Point(527, 9)
        Me.livesLabel.Name = "livesLabel"
        Me.livesLabel.Size = New System.Drawing.Size(95, 28)
        Me.livesLabel.TabIndex = 2
        Me.livesLabel.Text = "Lives :  3"
        '
        'endMessage
        '
        Me.endMessage.AutoSize = True
        Me.endMessage.Font = New System.Drawing.Font("Bookman Old Style", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.endMessage.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.endMessage.Location = New System.Drawing.Point(115, 80)
        Me.endMessage.Name = "endMessage"
        Me.endMessage.Size = New System.Drawing.Size(397, 48)
        Me.endMessage.TabIndex = 3
        Me.endMessage.Text = "Press 'B' To Go Back To Main Menu." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Press 'N' To Start Game." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Timer1
        '
        Me.Timer1.Interval = 10
        '
        'PictureBox8
        '
        Me.PictureBox8.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox8.Image = CType(resources.GetObject("PictureBox8.Image"), System.Drawing.Image)
        Me.PictureBox8.Location = New System.Drawing.Point(397, 417)
        Me.PictureBox8.Name = "PictureBox8"
        Me.PictureBox8.Size = New System.Drawing.Size(35, 25)
        Me.PictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox8.TabIndex = 13
        Me.PictureBox8.TabStop = False
        Me.PictureBox8.Tag = "bug"
        Me.PictureBox8.Visible = False
        '
        'PictureBox7
        '
        Me.PictureBox7.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox7.Image = CType(resources.GetObject("PictureBox7.Image"), System.Drawing.Image)
        Me.PictureBox7.Location = New System.Drawing.Point(356, 417)
        Me.PictureBox7.Name = "PictureBox7"
        Me.PictureBox7.Size = New System.Drawing.Size(35, 25)
        Me.PictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox7.TabIndex = 12
        Me.PictureBox7.TabStop = False
        Me.PictureBox7.Tag = "bug"
        Me.PictureBox7.Visible = False
        '
        'PictureBox6
        '
        Me.PictureBox6.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox6.Image = CType(resources.GetObject("PictureBox6.Image"), System.Drawing.Image)
        Me.PictureBox6.Location = New System.Drawing.Point(315, 417)
        Me.PictureBox6.Name = "PictureBox6"
        Me.PictureBox6.Size = New System.Drawing.Size(35, 25)
        Me.PictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox6.TabIndex = 11
        Me.PictureBox6.TabStop = False
        Me.PictureBox6.Tag = "bug"
        Me.PictureBox6.Visible = False
        '
        'PictureBox5
        '
        Me.PictureBox5.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox5.Image = CType(resources.GetObject("PictureBox5.Image"), System.Drawing.Image)
        Me.PictureBox5.Location = New System.Drawing.Point(274, 417)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(35, 25)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox5.TabIndex = 10
        Me.PictureBox5.TabStop = False
        Me.PictureBox5.Tag = "bug"
        Me.PictureBox5.Visible = False
        '
        'PictureBox4
        '
        Me.PictureBox4.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), System.Drawing.Image)
        Me.PictureBox4.Location = New System.Drawing.Point(233, 417)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(35, 25)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox4.TabIndex = 9
        Me.PictureBox4.TabStop = False
        Me.PictureBox4.Tag = "bug"
        Me.PictureBox4.Visible = False
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(192, 417)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(35, 25)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 8
        Me.PictureBox3.TabStop = False
        Me.PictureBox3.Tag = "bug"
        Me.PictureBox3.Visible = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(151, 417)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(35, 25)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 7
        Me.PictureBox2.TabStop = False
        Me.PictureBox2.Tag = "bug"
        Me.PictureBox2.Visible = False
        '
        'bug
        '
        Me.bug.BackColor = System.Drawing.Color.Transparent
        Me.bug.Image = CType(resources.GetObject("bug.Image"), System.Drawing.Image)
        Me.bug.Location = New System.Drawing.Point(110, 417)
        Me.bug.Name = "bug"
        Me.bug.Size = New System.Drawing.Size(35, 25)
        Me.bug.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.bug.TabIndex = 6
        Me.bug.TabStop = False
        Me.bug.Tag = "bug"
        Me.bug.Visible = False
        '
        'boy
        '
        Me.boy.BackColor = System.Drawing.SystemColors.Control
        Me.boy.Image = CType(resources.GetObject("boy.Image"), System.Drawing.Image)
        Me.boy.Location = New System.Drawing.Point(566, 259)
        Me.boy.Name = "boy"
        Me.boy.Size = New System.Drawing.Size(46, 47)
        Me.boy.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.boy.TabIndex = 5
        Me.boy.TabStop = False
        '
        'gem
        '
        Me.gem.BackColor = System.Drawing.Color.Transparent
        Me.gem.Image = CType(resources.GetObject("gem.Image"), System.Drawing.Image)
        Me.gem.Location = New System.Drawing.Point(380, 213)
        Me.gem.Name = "gem"
        Me.gem.Size = New System.Drawing.Size(31, 25)
        Me.gem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.gem.TabIndex = 4
        Me.gem.TabStop = False
        '
        'GemCollector
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(624, 442)
        Me.Controls.Add(Me.PictureBox8)
        Me.Controls.Add(Me.PictureBox7)
        Me.Controls.Add(Me.PictureBox6)
        Me.Controls.Add(Me.PictureBox5)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.bug)
        Me.Controls.Add(Me.boy)
        Me.Controls.Add(Me.gem)
        Me.Controls.Add(Me.endMessage)
        Me.Controls.Add(Me.livesLabel)
        Me.Controls.Add(Me.highScoreLabel)
        Me.Controls.Add(Me.scoreLabel)
        Me.Name = "GemCollector"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "GemCollector"
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bug, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.boy, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gem, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents scoreLabel As Label
    Friend WithEvents highScoreLabel As Label
    Friend WithEvents livesLabel As Label
    Friend WithEvents endMessage As Label
    Friend WithEvents gem As PictureBox
    Friend WithEvents boy As PictureBox
    Friend WithEvents bug As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents PictureBox6 As PictureBox
    Friend WithEvents PictureBox7 As PictureBox
    Friend WithEvents PictureBox8 As PictureBox
    Friend WithEvents Timer1 As Timer
End Class
