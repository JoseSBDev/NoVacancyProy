Imports MySqlConnector
Imports System.Diagnostics

Public Class MainPage
    Public role
    Dim weatherOpen As Boolean = False
    Dim weatherHide As Boolean = False
#Region "onLoad region"
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SelectUser()
        ConfigPage.SetTheme()
        Dim x As Integer = (Me.ClientSize.Width - PictureBox1.Width) \ 2
        Dim y As Integer = (Me.ClientSize.Height - PictureBox1.Height) \ 2
        PictureBox1.Location = New Point(x, y)
    End Sub
#End Region

#Region "Button events region"
    ' Eventos de clic en botones
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

    Private Sub Btn_Incident_Click(sender As Object, e As EventArgs) Handles Btn_Incident.Click
        IncidentPage.Show()
    End Sub

    Private Sub Btn_Maintenance_Click(sender As Object, e As EventArgs) Handles Btn_Maintenance.Click
        MaintenancePage.Show()
    End Sub

    Private Sub Btn_Cleaning_Click(sender As Object, e As EventArgs) Handles Btn_Cleaning.Click
        CleaningServicesPage.Show()
    End Sub

    Private Sub Btn_Inventory_Click(sender As Object, e As EventArgs) Handles Btn_Inventory.Click
        InventoryPage.Show()
    End Sub
#End Region

#Region "Other controls events region"
    ' Otros eventos de controles
    Private Sub PB_Weather_MouseEnter(sender As Object, e As EventArgs) Handles PB_Weather.MouseEnter
        Cursor = Cursors.Hand
    End Sub

    Private Sub PB_Weather_MouseLeave(sender As Object, e As EventArgs) Handles PB_Weather.MouseLeave
        Cursor = Cursors.Default
    End Sub

    Private Sub PB_Weather_Click(sender As Object, e As EventArgs) Handles PB_Weather.Click
        If weatherOpen = False Then
            If weatherHide = False Then
                WebBrowser1.Visible = True
                WebBrowser1.ScriptErrorsSuppressed = True ' Esto suprime los errores de script
                WebBrowser1.Navigate("https://www.eltiempo.es/valencia.html")
                weatherOpen = True
            Else
                WebBrowser1.Show()
                weatherHide = False
                weatherOpen = True
            End If
        Else
            WebBrowser1.Hide()
            weatherOpen = False
            weatherHide = True
        End If
    End Sub
    Private Sub PB_ChangeUser_MouseEnter(sender As Object, e As EventArgs) Handles PB_ChangeUser.MouseEnter
        Cursor = Cursors.Hand
    End Sub

    Private Sub PB_ChangeUser_MouseLeave(sender As Object, e As EventArgs) Handles PB_ChangeUser.MouseLeave
        Cursor = Cursors.Default
    End Sub

    Private Sub PB_ChangeUser_Click(sender As Object, e As EventArgs) Handles PB_ChangeUser.Click
        SelectUser()
    End Sub
#End Region

#Region "Main subs and functions region"
    ' Funciones y subprocedimientos principales

    'Dependiendo del rol seleccionado le asigna los permisos, a continuación, cambia el color en función si está habilitado o no. 
    Private Sub SelectUser()
        LoginPage.ShowDialog()
        If LoginPage.loggedIn = False Then
            MsgBox("Sin usuario logeado. La aplicación se va a cerrar.")
            Me.Close()
        End If
        'Desde aquí se controlan todos los accesos de los roles
        role = LoginPage.role
        LblRoleName.Text = role
        Select Case role
            Case "Administrador"
                Btn_Cleaning.Enabled = True
                Btn_Config.Enabled = True
                Btn_Incident.Enabled = True
                Btn_Reservations.Enabled = True
                Btn_Maintenance.Enabled = True
                Btn_Inventory.Enabled = True
                RoomsPage.Btn_UpdateRooms.Enabled = True
                RoomsPage.DataGridViewRooms.ReadOnly = False
            Case "Gerencia"
                Btn_Cleaning.Enabled = True
                Btn_Config.Enabled = True
                Btn_Incident.Enabled = True
                Btn_Reservations.Enabled = True
                Btn_Maintenance.Enabled = True
                Btn_Inventory.Enabled = True
                RoomsPage.Btn_UpdateRooms.Enabled = True
                RoomsPage.DataGridViewRooms.ReadOnly = False
            Case "Recepcion"
                Btn_Cleaning.Enabled = False
                Btn_Config.Enabled = False
                Btn_Incident.Enabled = True
                Btn_Reservations.Enabled = True
                Btn_Maintenance.Enabled = False
                Btn_Inventory.Enabled = True
                RoomsPage.Btn_UpdateRooms.Enabled = False
                RoomsPage.DataGridViewRooms.ReadOnly = True
            Case "Limpieza"
                Btn_Cleaning.Enabled = True
                Btn_Config.Enabled = False
                Btn_Incident.Enabled = False
                Btn_Reservations.Enabled = False
                Btn_Maintenance.Enabled = False
                Btn_Inventory.Enabled = False
                RoomsPage.Btn_UpdateRooms.Enabled = False
                RoomsPage.DataGridViewRooms.ReadOnly = True
            Case "Mantenimiento"
                Btn_Cleaning.Enabled = False
                Btn_Config.Enabled = False
                Btn_Incident.Enabled = False
                Btn_Reservations.Enabled = False
                Btn_Maintenance.Enabled = True
                Btn_Inventory.Enabled = False
                RoomsPage.Btn_UpdateRooms.Enabled = False
                RoomsPage.DataGridViewRooms.ReadOnly = True
        End Select

        For Each ctrl As Control In Me.Controls
            If TypeOf ctrl Is Button Then
                Dim btn As Button = DirectCast(ctrl, Button)
                If Not btn.Enabled Then
                    btn.BackColor = Color.Red
                Else
                    btn.BackColor = SystemColors.GradientInactiveCaption
                End If
            End If
        Next

        For Each ctrl As Control In RoomsPage.Controls
            If TypeOf ctrl Is Button Then
                Dim btn As Button = DirectCast(ctrl, Button)
                If Not btn.Enabled Then
                    btn.BackColor = Color.Red
                Else
                    btn.BackColor = SystemColors.GradientInactiveCaption
                End If
            End If
        Next
    End Sub
#End Region
End Class
