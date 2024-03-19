Imports MySql.Data.MySqlClient
Imports MySqlConnector

Public Class AdminLogin
    Dim MysqlConn As MySqlConnection
    Dim COMMAND As MySqlCommand
    Dim counter As Integer = 0
    Dim Mytone As New System.Media.SoundPlayer

    Private Sub AdminBtn_Click(sender As Object, e As EventArgs) Handles AdminBtn.Click
        My.Computer.Audio.Play(My.Resources.ping, AudioPlayMode.Background)
        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString = "server = localhost;userid = root; password = Naveenn7632@; database = roadrally"

        Dim READER As MySqlDataReader
        Try
            MysqlConn.Open()
            Dim Query As String
            Query = "select * from roadrally.admin_info where username = '" & TextBox_Ad.Text & "' and password = '" & TextBox_Ap.Text & "'"
            COMMAND = New MySqlCommand(Query, MysqlConn)

            READER = COMMAND.ExecuteReader
            Dim count As Integer
            count = 0
            While READER.Read
                count = count + 1
            End While

            If count = 1 Then
                MessageBox.Show("Welcome Admin")
                AdminPage.Show()
                Me.Hide()
                TextBox_Ap.Clear()
                TextBox_Ad.Clear()
            ElseIf count > 1 Then
                MessageBox.Show("Adminname And Password Are Duplicate")
                TextBox_Ad.Clear()
                TextBox_Ap.Clear()
            Else
                MessageBox.Show("Username And Password Are Not Correct")
                TextBox_Ad.Clear()
                TextBox_Ap.Clear()
            End If
            MysqlConn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            TextBox_Ap.UseSystemPasswordChar = False
        Else
            TextBox_Ap.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub BackBtn_Click(sender As Object, e As EventArgs) Handles BackBtn.Click
        Me.Hide()
        UserLogin.Show()
    End Sub
End Class