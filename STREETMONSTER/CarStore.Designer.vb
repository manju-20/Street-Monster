<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CarStore
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Car4 = New System.Windows.Forms.PictureBox()
        Me.Car3 = New System.Windows.Forms.PictureBox()
        Me.Car2 = New System.Windows.Forms.PictureBox()
        Me.Car = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Button_car1 = New System.Windows.Forms.Button()
        Me.Button_car2 = New System.Windows.Forms.Button()
        Me.Button_car3 = New System.Windows.Forms.Button()
        Me.Button_car4 = New System.Windows.Forms.Button()
        CType(Me.Car4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Car3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Car2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Car, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Black
        Me.Label1.Font = New System.Drawing.Font("Bookman Old Style", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(12, 49)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(360, 56)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "SELECT YOUR FAVOURITE " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "CAR HERE" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Car4
        '
        Me.Car4.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Car4.Image = Global.STREETMONSTER.My.Resources.Resources.car111
        Me.Car4.Location = New System.Drawing.Point(267, 341)
        Me.Car4.Name = "Car4"
        Me.Car4.Size = New System.Drawing.Size(58, 104)
        Me.Car4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Car4.TabIndex = 5
        Me.Car4.TabStop = False
        '
        'Car3
        '
        Me.Car3.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Car3.Image = Global.STREETMONSTER.My.Resources.Resources.car5
        Me.Car3.Location = New System.Drawing.Point(62, 341)
        Me.Car3.Name = "Car3"
        Me.Car3.Size = New System.Drawing.Size(58, 104)
        Me.Car3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Car3.TabIndex = 4
        Me.Car3.TabStop = False
        '
        'Car2
        '
        Me.Car2.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Car2.Image = Global.STREETMONSTER.My.Resources.Resources.car1
        Me.Car2.Location = New System.Drawing.Point(267, 155)
        Me.Car2.Name = "Car2"
        Me.Car2.Size = New System.Drawing.Size(58, 93)
        Me.Car2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Car2.TabIndex = 3
        Me.Car2.TabStop = False
        '
        'Car
        '
        Me.Car.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Car.Image = Global.STREETMONSTER.My.Resources.Resources.car3
        Me.Car.Location = New System.Drawing.Point(62, 155)
        Me.Car.Name = "Car"
        Me.Car.Size = New System.Drawing.Size(58, 93)
        Me.Car.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Car.TabIndex = 2
        Me.Car.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.STREETMONSTER.My.Resources.Resources.bg3
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(389, 565)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Button_car1
        '
        Me.Button_car1.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Button_car1.Font = New System.Drawing.Font("Cooper Black", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_car1.ForeColor = System.Drawing.Color.White
        Me.Button_car1.Location = New System.Drawing.Point(38, 254)
        Me.Button_car1.Name = "Button_car1"
        Me.Button_car1.Size = New System.Drawing.Size(108, 36)
        Me.Button_car1.TabIndex = 6
        Me.Button_car1.Text = "Car No: 1"
        Me.Button_car1.UseVisualStyleBackColor = False
        '
        'Button_car2
        '
        Me.Button_car2.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Button_car2.Font = New System.Drawing.Font("Cooper Black", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_car2.ForeColor = System.Drawing.Color.White
        Me.Button_car2.Location = New System.Drawing.Point(233, 254)
        Me.Button_car2.Name = "Button_car2"
        Me.Button_car2.Size = New System.Drawing.Size(122, 36)
        Me.Button_car2.TabIndex = 7
        Me.Button_car2.Text = "Car No: 2"
        Me.Button_car2.UseVisualStyleBackColor = False
        '
        'Button_car3
        '
        Me.Button_car3.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Button_car3.Font = New System.Drawing.Font("Cooper Black", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_car3.ForeColor = System.Drawing.Color.White
        Me.Button_car3.Location = New System.Drawing.Point(38, 451)
        Me.Button_car3.Name = "Button_car3"
        Me.Button_car3.Size = New System.Drawing.Size(118, 38)
        Me.Button_car3.TabIndex = 8
        Me.Button_car3.Text = "Car No: 3"
        Me.Button_car3.UseVisualStyleBackColor = False
        '
        'Button_car4
        '
        Me.Button_car4.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Button_car4.Font = New System.Drawing.Font("Cooper Black", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_car4.ForeColor = System.Drawing.Color.White
        Me.Button_car4.Location = New System.Drawing.Point(233, 451)
        Me.Button_car4.Name = "Button_car4"
        Me.Button_car4.Size = New System.Drawing.Size(122, 38)
        Me.Button_car4.TabIndex = 9
        Me.Button_car4.Text = "Car No: 4"
        Me.Button_car4.UseVisualStyleBackColor = False
        '
        'CarStore
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(384, 561)
        Me.Controls.Add(Me.Button_car4)
        Me.Controls.Add(Me.Button_car3)
        Me.Controls.Add(Me.Button_car2)
        Me.Controls.Add(Me.Button_car1)
        Me.Controls.Add(Me.Car4)
        Me.Controls.Add(Me.Car3)
        Me.Controls.Add(Me.Car2)
        Me.Controls.Add(Me.Car)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "CarStore"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CarStore"
        CType(Me.Car4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Car3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Car2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Car, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Car As PictureBox
    Friend WithEvents Car2 As PictureBox
    Friend WithEvents Car3 As PictureBox
    Friend WithEvents Car4 As PictureBox
    Friend WithEvents Button_car1 As Button
    Friend WithEvents Button_car2 As Button
    Friend WithEvents Button_car3 As Button
    Friend WithEvents Button_car4 As Button
End Class
