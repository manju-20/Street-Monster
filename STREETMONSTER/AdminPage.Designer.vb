<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AdminPage
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
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Search_Text = New System.Windows.Forms.TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Button_Load_Table = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TextBox_ID = New System.Windows.Forms.TextBox()
        Me.TextBox_UN = New System.Windows.Forms.TextBox()
        Me.TextBox_Age = New System.Windows.Forms.TextBox()
        Me.TextBox_Gen = New System.Windows.Forms.TextBox()
        Me.Button_Update = New System.Windows.Forms.Button()
        Me.Button_Delete = New System.Windows.Forms.Button()
        Me.Backbtn = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.LoadTable = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.STREETMONSTER.My.Resources.Resources.car9
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(392, 569)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label1.Font = New System.Drawing.Font("Algerian", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Aqua
        Me.Label1.Location = New System.Drawing.Point(63, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(254, 39)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "ADMIN PAGE.."
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label2.Font = New System.Drawing.Font("Bookman Old Style", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Yellow
        Me.Label2.Location = New System.Drawing.Point(12, 56)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(202, 22)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Search The Player :"
        '
        'Search_Text
        '
        Me.Search_Text.Font = New System.Drawing.Font("Bookman Old Style", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Search_Text.Location = New System.Drawing.Point(211, 56)
        Me.Search_Text.Name = "Search_Text"
        Me.Search_Text.Size = New System.Drawing.Size(161, 25)
        Me.Search_Text.TabIndex = 3
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToOrderColumns = True
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(0, 87)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(392, 175)
        Me.DataGridView1.TabIndex = 4
        '
        'Button_Load_Table
        '
        Me.Button_Load_Table.BackColor = System.Drawing.Color.Gray
        Me.Button_Load_Table.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button_Load_Table.Font = New System.Drawing.Font("Cooper Black", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_Load_Table.ForeColor = System.Drawing.Color.White
        Me.Button_Load_Table.Location = New System.Drawing.Point(113, 268)
        Me.Button_Load_Table.Name = "Button_Load_Table"
        Me.Button_Load_Table.Size = New System.Drawing.Size(153, 37)
        Me.Button_Load_Table.TabIndex = 5
        Me.Button_Load_Table.Text = "LOAD TABLE"
        Me.Button_Load_Table.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label3.Font = New System.Drawing.Font("Palatino Linotype", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(35, 319)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(148, 28)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Player ID        :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label4.Font = New System.Drawing.Font("Palatino Linotype", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(33, 360)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(147, 28)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Player Name :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label5.Font = New System.Drawing.Font("Palatino Linotype", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(34, 407)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(146, 28)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Age                  :"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label6.Font = New System.Drawing.Font("Palatino Linotype", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(34, 451)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(147, 28)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "Gender           :"
        '
        'TextBox_ID
        '
        Me.TextBox_ID.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox_ID.Location = New System.Drawing.Point(186, 318)
        Me.TextBox_ID.Name = "TextBox_ID"
        Me.TextBox_ID.Size = New System.Drawing.Size(164, 29)
        Me.TextBox_ID.TabIndex = 10
        '
        'TextBox_UN
        '
        Me.TextBox_UN.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox_UN.Location = New System.Drawing.Point(186, 362)
        Me.TextBox_UN.Name = "TextBox_UN"
        Me.TextBox_UN.Size = New System.Drawing.Size(164, 29)
        Me.TextBox_UN.TabIndex = 11
        '
        'TextBox_Age
        '
        Me.TextBox_Age.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox_Age.Location = New System.Drawing.Point(186, 406)
        Me.TextBox_Age.Name = "TextBox_Age"
        Me.TextBox_Age.Size = New System.Drawing.Size(164, 29)
        Me.TextBox_Age.TabIndex = 12
        '
        'TextBox_Gen
        '
        Me.TextBox_Gen.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox_Gen.Location = New System.Drawing.Point(186, 453)
        Me.TextBox_Gen.Name = "TextBox_Gen"
        Me.TextBox_Gen.Size = New System.Drawing.Size(164, 29)
        Me.TextBox_Gen.TabIndex = 13
        '
        'Button_Update
        '
        Me.Button_Update.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Button_Update.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button_Update.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button_Update.Font = New System.Drawing.Font("Cooper Black", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_Update.Location = New System.Drawing.Point(73, 501)
        Me.Button_Update.Name = "Button_Update"
        Me.Button_Update.Size = New System.Drawing.Size(107, 29)
        Me.Button_Update.TabIndex = 14
        Me.Button_Update.Text = "UPDATE"
        Me.Button_Update.UseVisualStyleBackColor = False
        '
        'Button_Delete
        '
        Me.Button_Delete.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Button_Delete.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button_Delete.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button_Delete.Font = New System.Drawing.Font("Cooper Black", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_Delete.Location = New System.Drawing.Point(212, 501)
        Me.Button_Delete.Name = "Button_Delete"
        Me.Button_Delete.Size = New System.Drawing.Size(106, 29)
        Me.Button_Delete.TabIndex = 15
        Me.Button_Delete.Text = "DELETE"
        Me.Button_Delete.UseVisualStyleBackColor = False
        '
        'Backbtn
        '
        Me.Backbtn.AutoSize = True
        Me.Backbtn.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Backbtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Backbtn.Font = New System.Drawing.Font("Algerian", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Backbtn.ForeColor = System.Drawing.Color.Red
        Me.Backbtn.Location = New System.Drawing.Point(-3, 539)
        Me.Backbtn.Name = "Backbtn"
        Me.Backbtn.Size = New System.Drawing.Size(64, 21)
        Me.Backbtn.TabIndex = 16
        Me.Backbtn.Text = "BACK"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label7.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label7.Font = New System.Drawing.Font("Algerian", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Red
        Me.Label7.Location = New System.Drawing.Point(321, 539)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(61, 21)
        Me.Label7.TabIndex = 17
        Me.Label7.Text = "NEXT"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.LoadTable)
        Me.GroupBox1.Controls.Add(Me.DataGridView2)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.PictureBox2)
        Me.GroupBox1.Location = New System.Drawing.Point(0, -17)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(392, 577)
        Me.GroupBox1.TabIndex = 18
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "GroupBox1"
        Me.GroupBox1.Visible = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.STREETMONSTER.My.Resources.Resources.bg2
        Me.PictureBox2.Location = New System.Drawing.Point(-11, 17)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(397, 560)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 0
        Me.PictureBox2.TabStop = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label8.Font = New System.Drawing.Font("Algerian", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Aqua
        Me.Label8.Location = New System.Drawing.Point(10, 56)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(362, 32)
        Me.Label8.TabIndex = 1
        Me.Label8.Text = "Player Comments List"
        '
        'DataGridView2
        '
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Location = New System.Drawing.Point(0, 129)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.Size = New System.Drawing.Size(386, 193)
        Me.DataGridView2.TabIndex = 2
        '
        'LoadTable
        '
        Me.LoadTable.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.LoadTable.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LoadTable.Font = New System.Drawing.Font("Cooper Black", 15.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LoadTable.Location = New System.Drawing.Point(113, 336)
        Me.LoadTable.Name = "LoadTable"
        Me.LoadTable.Size = New System.Drawing.Size(166, 38)
        Me.LoadTable.TabIndex = 3
        Me.LoadTable.Text = "LOAD TABLE"
        Me.LoadTable.UseVisualStyleBackColor = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label9.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label9.Font = New System.Drawing.Font("Algerian", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Red
        Me.Label9.Location = New System.Drawing.Point(6, 548)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(64, 21)
        Me.Label9.TabIndex = 4
        Me.Label9.Text = "BACK"
        '
        'AdminPage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(384, 561)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Backbtn)
        Me.Controls.Add(Me.Button_Delete)
        Me.Controls.Add(Me.Button_Update)
        Me.Controls.Add(Me.TextBox_Gen)
        Me.Controls.Add(Me.TextBox_Age)
        Me.Controls.Add(Me.TextBox_UN)
        Me.Controls.Add(Me.TextBox_ID)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Button_Load_Table)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Search_Text)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "AdminPage"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AdminPage"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Search_Text As TextBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Button_Load_Table As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents TextBox_ID As TextBox
    Friend WithEvents TextBox_UN As TextBox
    Friend WithEvents TextBox_Age As TextBox
    Friend WithEvents TextBox_Gen As TextBox
    Friend WithEvents Button_Update As Button
    Friend WithEvents Button_Delete As Button
    Friend WithEvents Backbtn As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label9 As Label
    Friend WithEvents LoadTable As Button
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents Label8 As Label
    Friend WithEvents PictureBox2 As PictureBox
End Class
