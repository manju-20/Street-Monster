Imports MySql.Data.MySqlClient
Imports MySqlConnector

Public Class CreateAcc
    Dim gender As String
    Dim MysqlConn As MySqlConnection
    Dim COMMAND As MySqlCommand
    Dim Mytone As New System.Media.SoundPlayer

    Private Sub Btn_Save_Click(sender As Object, e As EventArgs) Handles Btn_Save.Click
        My.Computer.Audio.Play(My.Resources.ping, AudioPlayMode.Background)
        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString = "server = localhost; userid = root; password = Naveenn7632@; database = roadrally"

        Dim READER As MySqlDataReader
        Try
            MysqlConn.Open()
            Dim Query As String
            Query = "insert into roadrally.user_info (id,username,age,gender,password) values('" & TextBox_ID.Text & "','" & TextBox_Name.Text & "','" & TextBox_Age.Text & "','" & gender & "','" & TextBox_Pass.Text & "')"
            COMMAND = New MySqlCommand(Query, MysqlConn)

            READER = COMMAND.ExecuteReader
            MessageBox.Show("Data Saved")
            TextBox_ID.Clear()
            TextBox_Name.Clear()
            TextBox_Age.Clear()
            TextBox_Pass.Clear()
            MysqlConn.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()

        End Try
        autogenerate_ID()
    End Sub

    Private Sub autogenerate_ID()
        Dim MysqlConn As New MySqlConnection
        Dim COMMAND As New MySqlCommand
        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString = "server = localhost; userid = root; password = Naveenn7632@; database = roadrally"

        COMMAND.Connection = MysqlConn
        MysqlConn.Open()

        Dim number As Integer
        COMMAND.CommandText = "SELECT Max(ID) From user_info"

        If IsDBNull(COMMAND.ExecuteScalar) Then
            number = 1
            TextBox_ID.Text = number
        Else
            number = COMMAND.ExecuteScalar + 1
            TextBox_ID.Text = number
        End If

        COMMAND.Dispose()
        MysqlConn.Close()
        MysqlConn.Dispose()

    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        gender = "Male"
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        gender = "Female"
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            TextBox_Pass.UseSystemPasswordChar = False
        Else
            TextBox_Pass.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub BckBtn_Click(sender As Object, e As EventArgs) Handles BckBtn.Click
        Me.Hide()
        UserLogin.Show()
    End Sub

    Private Sub CreateAcc_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        autogenerate_ID()
    End Sub
End Class