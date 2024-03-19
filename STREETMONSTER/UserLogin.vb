Imports MySql.Data.MySqlClient
Imports MySqlConnector

Public Class UserLogin
    Dim MySqlConn As MySqlConnection
    Dim COMMAND As MySqlCommand
    Dim Counter As Integer = 0
    Dim Mytone As New System.Media.SoundPlayer

    Private Sub BackBtn_Click(sender As Object, e As EventArgs) Handles BackBtn.Click
        My.Computer.Audio.Play(My.Resources.ping, AudioPlayMode.Background)
        Me.Hide()
        Form1.Show()
    End Sub

    Private Sub UserBtn_Click(sender As Object, e As EventArgs) Handles UserBtn.Click
        My.Computer.Audio.Play(My.Resources.ping, AudioPlayMode.Background)
        MySqlConn = New MySqlConnection
        MySqlConn.ConnectionString = "server = localhost; userid = root; password = Naveenn7632@; database = roadrally"

        Dim READER As MySqlDataReader
        Try
            MySqlConn.Open()
            Dim Query As String
            Query = "select * from roadrally.user_info where username = '" & TextBox_UN.Text & "' and password = '" & TextBox_Pass.Text & "'"
            COMMAND = New MySqlCommand(Query, MySqlConn)

            READER = COMMAND.ExecuteReader
            Dim count As Integer
            count = 0
            While READER.Read
                count = count + 1
            End While
            If count = 1 Then
                MessageBox.Show(String.Format("Welcome: Newbiee"))
                TextBox_UN.Clear()
                TextBox_Pass.Clear()
                Me.Hide()
                GameLevels.Show()
            ElseIf count > 1 Then
                MessageBox.Show("Username And Password Are Duplicate")
                TextBox_UN.Clear()
                TextBox_Pass.Clear()
            Else
                MessageBox.Show("Username And Password Are Not Correct")
                TextBox_UN.Clear()
                TextBox_Pass.Clear()
            End If

            If Counter = 3 Then
                UserBtn.Enabled = False
                MessageBox.Show("You Have Reached The Max Login Limits")
            End If
            MySqlConn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            MySqlConn.Dispose()

        End Try
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            TextBox_Pass.UseSystemPasswordChar = False
        Else
            TextBox_Pass.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click
        Me.Hide()
        CreateAcc.Show()
    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click
        Me.Hide()
        AdminLogin.Show()
    End Sub
End Class