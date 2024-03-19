Public Class CarStore
    Public Delegate Sub Del(ByVal image As Image)
    Private _del As Del

    Public Sub New(ByVal del As Del)
        InitializeComponent()
        Me._del = del
    End Sub

    Private Sub Button_car1_Click(sender As Object, e As EventArgs) Handles Button_car1.Click
        _del(Car.Image)
        Me.Hide()
        Level1.Show()
    End Sub

    Private Sub Button_car2_Click(sender As Object, e As EventArgs) Handles Button_car2.Click
        _del(Car2.Image)
        Me.Hide()
        Level1.Show()
    End Sub

    Private Sub Button_car3_Click(sender As Object, e As EventArgs) Handles Button_car3.Click
        _del(Car3.Image)
        Me.Hide()
        Level1.Show()
    End Sub

    Private Sub Button_car4_Click(sender As Object, e As EventArgs) Handles Button_car4.Click
        _del(Car4.Image)
        Me.Hide()
        Level1.Show()
    End Sub
End Class