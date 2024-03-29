Imports MySqlConnector

Public Class MainPage
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoginPage.ShowDialog()
        If LoginPage.loggedIn = False Then
            MsgBox("Sin usuario logeado. La aplicación se va a cerrar.")
            Me.Close()
        End If
        Dim x As Integer = (Me.ClientSize.Width - PictureBox1.Width) \ 2
        Dim y As Integer = (Me.ClientSize.Height - PictureBox1.Height) \ 2

        ' Establecer la nueva posición del PictureBox
        PictureBox1.Location = New Point(x, y)

    End Sub


    Private Sub Btn_Config_Click(sender As Object, e As EventArgs) Handles Btn_Config.Click
        ConfigPage.ShowDialog()
    End Sub

    Private Sub Btn_Reservations_Click(sender As Object, e As EventArgs) Handles Btn_Reservations.Click
        ReservationPage.Show()
    End Sub

    Private Sub Btn_Rooms_Click(sender As Object, e As EventArgs) Handles Btn_Rooms.Click
        RoomsPage.Show()
    End Sub

    Private Sub Btn_exit_Click(sender As Object, e As EventArgs) Handles Btn_exit.Click
        Me.Close()
    End Sub
End Class
