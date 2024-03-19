<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GameRating
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(GameRating))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtComment = New System.Windows.Forms.TextBox()
        Me.btnOk = New System.Windows.Forms.Button()
        Me.pcbStar5 = New System.Windows.Forms.PictureBox()
        Me.pcbStar4 = New System.Windows.Forms.PictureBox()
        Me.pcbStar3 = New System.Windows.Forms.PictureBox()
        Me.pcbStar2 = New System.Windows.Forms.PictureBox()
        Me.pcbStar1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBox_Name = New System.Windows.Forms.TextBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        CType(Me.pcbStar5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pcbStar4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pcbStar3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pcbStar2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pcbStar1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Palatino Linotype", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(14, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(217, 32)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "I Rate This Game :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Kristen ITC", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(12, 252)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(163, 33)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Comments :"
        '
        'txtComment
        '
        Me.txtComment.Font = New System.Drawing.Font("Bookman Old Style", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtComment.Location = New System.Drawing.Point(12, 288)
        Me.txtComment.Multiline = True
        Me.txtComment.Name = "txtComment"
        Me.txtComment.Size = New System.Drawing.Size(360, 157)
        Me.txtComment.TabIndex = 8
        '
        'btnOk
        '
        Me.btnOk.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnOk.Font = New System.Drawing.Font("Cooper Black", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOk.ForeColor = System.Drawing.Color.White
        Me.btnOk.Location = New System.Drawing.Point(122, 475)
        Me.btnOk.Name = "btnOk"
        Me.btnOk.Size = New System.Drawing.Size(130, 35)
        Me.btnOk.TabIndex = 9
        Me.btnOk.Text = "SUBMIT"
        Me.btnOk.UseVisualStyleBackColor = False
        '
        'pcbStar5
        '
        Me.pcbStar5.BackColor = System.Drawing.Color.Transparent
        Me.pcbStar5.Image = Global.STREETMONSTER.My.Resources.Resources.NoStarRate
        Me.pcbStar5.Location = New System.Drawing.Point(318, 79)
        Me.pcbStar5.Name = "pcbStar5"
        Me.pcbStar5.Size = New System.Drawing.Size(55, 50)
        Me.pcbStar5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pcbStar5.TabIndex = 6
        Me.pcbStar5.TabStop = False
        '
        'pcbStar4
        '
        Me.pcbStar4.BackColor = System.Drawing.Color.Transparent
        Me.pcbStar4.Image = Global.STREETMONSTER.My.Resources.Resources.NoStarRate
        Me.pcbStar4.Location = New System.Drawing.Point(243, 79)
        Me.pcbStar4.Name = "pcbStar4"
        Me.pcbStar4.Size = New System.Drawing.Size(55, 50)
        Me.pcbStar4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pcbStar4.TabIndex = 5
        Me.pcbStar4.TabStop = False
        '
        'pcbStar3
        '
        Me.pcbStar3.BackColor = System.Drawing.Color.Transparent
        Me.pcbStar3.Image = Global.STREETMONSTER.My.Resources.Resources.NoStarRate
        Me.pcbStar3.Location = New System.Drawing.Point(165, 79)
        Me.pcbStar3.Name = "pcbStar3"
        Me.pcbStar3.Size = New System.Drawing.Size(55, 50)
        Me.pcbStar3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pcbStar3.TabIndex = 4
        Me.pcbStar3.TabStop = False
        '
        'pcbStar2
        '
        Me.pcbStar2.BackColor = System.Drawing.Color.Transparent
        Me.pcbStar2.Image = Global.STREETMONSTER.My.Resources.Resources.NoStarRate
        Me.pcbStar2.Location = New System.Drawing.Point(94, 79)
        Me.pcbStar2.Name = "pcbStar2"
        Me.pcbStar2.Size = New System.Drawing.Size(55, 50)
        Me.pcbStar2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pcbStar2.TabIndex = 3
        Me.pcbStar2.TabStop = False
        '
        'pcbStar1
        '
        Me.pcbStar1.BackColor = System.Drawing.Color.Transparent
        Me.pcbStar1.Image = Global.STREETMONSTER.My.Resources.Resources.NoStarRate
        Me.pcbStar1.Location = New System.Drawing.Point(20, 79)
        Me.pcbStar1.Name = "pcbStar1"
        Me.pcbStar1.Size = New System.Drawing.Size(55, 50)
        Me.pcbStar1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pcbStar1.TabIndex = 2
        Me.pcbStar1.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(-5, -5)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(394, 575)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Black
        Me.Label3.Font = New System.Drawing.Font("Algerian", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(12, 185)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(174, 24)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Player Name :"
        '
        'TextBox_Name
        '
        Me.TextBox_Name.Font = New System.Drawing.Font("Bookman Old Style", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox_Name.Location = New System.Drawing.Point(183, 183)
        Me.TextBox_Name.Name = "TextBox_Name"
        Me.TextBox_Name.Size = New System.Drawing.Size(177, 26)
        Me.TextBox_Name.TabIndex = 11
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.Image = Global.STREETMONSTER.My.Resources.Resources.backbtn
        Me.PictureBox2.Location = New System.Drawing.Point(12, 525)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(91, 33)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 12
        Me.PictureBox2.TabStop = False
        '
        'GameRating
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(384, 561)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.TextBox_Name)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnOk)
        Me.Controls.Add(Me.txtComment)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.pcbStar5)
        Me.Controls.Add(Me.pcbStar4)
        Me.Controls.Add(Me.pcbStar3)
        Me.Controls.Add(Me.pcbStar2)
        Me.Controls.Add(Me.pcbStar1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "GameRating"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "GameRating"
        CType(Me.pcbStar5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pcbStar4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pcbStar3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pcbStar2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pcbStar1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents pcbStar1 As PictureBox
    Friend WithEvents pcbStar2 As PictureBox
    Friend WithEvents pcbStar3 As PictureBox
    Friend WithEvents pcbStar4 As PictureBox
    Friend WithEvents pcbStar5 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtComment As TextBox
    Friend WithEvents btnOk As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBox_Name As TextBox
    Friend WithEvents PictureBox2 As PictureBox
End Class
