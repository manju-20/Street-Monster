Imports MySql.Data.MySqlClient
Imports MySqlConnector

Public Class GameRating
    Dim MysqlConn As MySqlConnection
    Dim COMMAND As MySqlCommand
    Dim dbDataSet As New DataTable
    Dim Rated As Boolean = False
    Dim StarCount As Integer

    Private Sub pcbStar1_Click(sender As Object, e As EventArgs) Handles pcbStar1.Click
        pcbStar1.Image = My.Resources.StarRate
        pcbStar2.Image = My.Resources.NoStarRate
        pcbStar3.Image = My.Resources.NoStarRate
        pcbStar4.Image = My.Resources.NoStarRate
        pcbStar5.Image = My.Resources.NoStarRate
        Label1.Text = "I rate this game: 1 star!"
        Rated = True
        StarCount = 1
    End Sub

    Private Sub pcbStar2_Click(sender As Object, e As EventArgs) Handles pcbStar2.Click
        pcbStar1.Image = My.Resources.StarRate
        pcbStar2.Image = My.Resources.StarRate
        pcbStar3.Image = My.Resources.NoStarRate
        pcbStar4.Image = My.Resources.NoStarRate
        pcbStar5.Image = My.Resources.NoStarRate
        Label1.Text = "I rate this game: 2 stars!"
        Rated = True
        StarCount = 2
    End Sub

    Private Sub pcbStar3_Click(sender As Object, e As EventArgs) Handles pcbStar3.Click
        pcbStar1.Image = My.Resources.StarRate
        pcbStar2.Image = My.Resources.StarRate
        pcbStar3.Image = My.Resources.StarRate
        pcbStar4.Image = My.Resources.NoStarRate
        pcbStar5.Image = My.Resources.NoStarRate
        Label1.Text = "I rate this game: 3 stars!"
        Rated = True
        StarCount = 3
    End Sub

    Private Sub pcbStar4_Click(sender As Object, e As EventArgs) Handles pcbStar4.Click
        pcbStar1.Image = My.Resources.StarRate
        pcbStar2.Image = My.Resources.StarRate
        pcbStar3.Image = My.Resources.StarRate
        pcbStar4.Image = My.Resources.StarRate
        pcbStar5.Image = My.Resources.NoStarRate
        Label1.Text = "I rate this game: 4 stars!"
        Rated = True
        StarCount = 4
    End Sub

    Private Sub pcbStar5_Click(sender As Object, e As EventArgs) Handles pcbStar5.Click
        pcbStar1.Image = My.Resources.StarRate
        pcbStar2.Image = My.Resources.StarRate
        pcbStar3.Image = My.Resources.StarRate
        pcbStar4.Image = My.Resources.StarRate
        pcbStar5.Image = My.Resources.StarRate
        Label1.Text = "I rate this game: 5 stars!"
        Rated = True
        StarCount = 5
    End Sub

    Private Sub btnOk_Click(sender As Object, e As EventArgs) Handles btnOk.Click
        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString = "server = localhost; userid = root; password = Naveenn7632@; database = roadrally"

        Dim READER As MySqlDataReader
        Try
            MysqlConn.Open()
            Dim Query As String
            Query = "insert into roadrally.commenting (username,comments) values('" & TextBox_Name.Text & "','" & txtComment.Text & "')"
            COMMAND = New MySqlCommand(Query, MysqlConn)

            READER = COMMAND.ExecuteReader
            MessageBox.Show("Thank You For Your Comments")
            Me.Hide()
            GameLevels.Show()
            MysqlConn.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()

        End Try
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Me.Hide()
        GameLevels.Show()
    End Sub
End Class