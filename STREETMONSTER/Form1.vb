Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MessageBox.Show("Login To View This Option")
    End Sub

    Private Sub Backbtn_Click(sender As Object, e As EventArgs) Handles Backbtn.Click
        GroupBox1.Visible = False
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        MessageBox.Show("Login To View This Option")
    End Sub

    Private Sub Exitbtn_Click(sender As Object, e As EventArgs) Handles Exitbtn.Click
        Me.Hide()
    End Sub

    Private Sub MoreOptions_Click(sender As Object, e As EventArgs) Handles MoreOptions.Click
        GroupBox1.Visible = True
    End Sub

    Private Sub Startbtn_Click(sender As Object, e As EventArgs) Handles Startbtn.Click
        Me.Hide()
        UserLogin.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        MoreGames.Show()
    End Sub

    Private Sub Button4_Click_1(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Hide()
        AboutGame.Show()
    End Sub
End Class
