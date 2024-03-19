Imports MySql.Data.MySqlClient
Imports MySqlConnector

Public Class AdminPage
    Dim gender As String
    Dim MysqlConn As MySqlConnection
    Dim COMMAND As MySqlCommand
    Dim dbDataSet As New DataTable
    Dim Mytone As New System.Media.SoundPlayer

    Private Sub Load_Table()
        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString = "server = localhost; userid = root; password = Naveenn7632@; database = roadrally"
        Dim SDA As New MySqlDataAdapter
        Dim bSource As New BindingSource
        Try
            MysqlConn.Open()
            Dim Query As String
            Query = "select id,username,age,gender from roadrally.user_info"
            COMMAND = New MySqlCommand(Query, MysqlConn)
            SDA.SelectCommand = COMMAND
            SDA.Fill(dbDataSet)
            bSource.DataSource = dbDataSet
            DataGridView1.DataSource = bSource
            SDA.Update(dbDataSet)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()

        End Try
    End Sub

    Private Sub Button_Load_Table_Click(sender As Object, e As EventArgs) Handles Button_Load_Table.Click
        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString = "server = localhost; userid = root; password = Naveenn7632@; database = roadrally"
        Dim SDA As New MySqlDataAdapter
        Dim dbDataSet As New DataTable
        Dim bSource As New BindingSource
        Try
            MysqlConn.Open()
            Dim Query As String
            Query = "select id,username ,age ,gender from roadrally.user_info"
            COMMAND = New MySqlCommand(Query, MysqlConn)
            SDA.SelectCommand = COMMAND
            SDA.Fill(dbDataSet)
            bSource.DataSource = dbDataSet
            DataGridView1.DataSource = bSource
            SDA.Update(dbDataSet)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()

        End Try
    End Sub

    Private Sub AdminPage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Load_Table()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow
            row = Me.DataGridView1.Rows(e.RowIndex)

            TextBox_ID.Text = row.Cells("id").Value.ToString
            TextBox_UN.Text = row.Cells("username").Value.ToString
            TextBox_Age.Text = row.Cells("age").Value.ToString
            TextBox_Gen.Text = row.Cells("gender").Value.ToString

        End If
    End Sub

    Private Sub Search_Text_TextChanged(sender As Object, e As EventArgs) Handles Search_Text.TextChanged
        Dim DV As New DataView(dbDataSet)
        DV.RowFilter = String.Format("username like '%{0}%'", Search_Text.Text)
        DataGridView1.DataSource = DV
    End Sub

    Private Sub Button_Update_Click(sender As Object, e As EventArgs) Handles Button_Update.Click
        My.Computer.Audio.Play(My.Resources.ping, AudioPlayMode.Background)
        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString = "server = localhost; userid = root; password = Naveenn7632@; database = roadrally"

        Dim READER As MySqlDataReader
        Try
            MysqlConn.Open()
            Dim Query As String
            Query = "update roadrally.user_info set id = '" & TextBox_ID.Text & "', username = '" & TextBox_UN.Text & "', age = '" & TextBox_Age.Text & "', gender = '" & TextBox_Gen.Text & "' where id = '" & TextBox_ID.Text & "'"
            COMMAND = New MySqlCommand(Query, MysqlConn)

            READER = COMMAND.ExecuteReader
            MessageBox.Show("Data Updated")
            MysqlConn.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()

        End Try
    End Sub

    Private Sub Button_Delete_Click(sender As Object, e As EventArgs) Handles Button_Delete.Click
        My.Computer.Audio.Play(My.Resources.ping, AudioPlayMode.Background)
        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString = "server = localhost; userid = root; password = Naveenn7632@; database = roadrally"

        Dim READER As MySqlDataReader
        Try
            MysqlConn.Open()
            Dim Query As String
            Query = "Delete from roadrally.user_info where id = '" & TextBox_ID.Text & "'"
            COMMAND = New MySqlCommand(Query, MysqlConn)
            READER = COMMAND.ExecuteReader
            MessageBox.Show("Player Removed")
            MysqlConn.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()

        End Try
    End Sub

    Private Sub Backbtn_Click(sender As Object, e As EventArgs) Handles Backbtn.Click
        Me.Hide()
        Form1.Show()
    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click
        GroupBox1.Visible = True
    End Sub

    Private Sub Label9_Click(sender As Object, e As EventArgs) Handles Label9.Click
        GroupBox1.Visible = False
    End Sub

    Private Sub LoadTable_Click(sender As Object, e As EventArgs) Handles LoadTable.Click
        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString = "server = localhost; userid = root; password = Naveenn7632@; database = roadrally"
        Dim SDA As New MySqlDataAdapter
        Dim dbDataSet As New DataTable
        Dim bSource As New BindingSource
        Try
            MysqlConn.Open()
            Dim Query As String
            Query = "select username ,comments from roadrally.commenting"
            COMMAND = New MySqlCommand(Query, MysqlConn)
            SDA.SelectCommand = COMMAND
            SDA.Fill(dbDataSet)
            bSource.DataSource = dbDataSet
            DataGridView2.DataSource = bSource
            SDA.Update(dbDataSet)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()

        End Try
    End Sub
End Class