Imports System.Configuration
Imports System.Windows.Forms.DataVisualization.Charting
Imports MySqlConnector

Public Class ConfigPage
    Dim server = "localhost"
    Dim user = "root"
    Dim pwd = "root"
    Dim database = "hotel"
    Dim connectionString = "server=" & server & ";user=" & user & ";password=" & pwd & ";database=" & database
    Dim userId As Integer
    Dim userName As String
    Dim userPass As String
    Dim userMail As String
    Dim userRole As Integer

#Region "onLoad region"
    Private Sub ConfigPage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FillComboBox()
        LoadMonthlyRevenueChart()
    End Sub
#End Region

#Region "Button events region"
    ' Eventos de clic en botones

    'Llama a la función EditUser
    Private Sub Btn_EditUser_Click(sender As Object, e As EventArgs) Handles Btn_EditUser.Click
        EditUser()
    End Sub

    'Llama a la función NewUser
    Private Sub Btn_NewUser_Click(sender As Object, e As EventArgs) Handles Btn_NewUser.Click
        NewUser()
    End Sub
#End Region

#Region "Other controls events region"
    ' Otros eventos de controles

    'Maneja la selección única del checkedlistbox
    Private Sub CheckedListBox_Roles_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CheckedListBox_Roles.SelectedIndexChanged
        Dim checkedListBox As CheckedListBox = DirectCast(sender, CheckedListBox)

        ' Desmarca todos los elementos
        For i As Integer = 0 To checkedListBox.Items.Count - 1
            checkedListBox.SetItemChecked(i, False)
        Next

        ' Marca solo el elemento del sender
        Dim selectedIndex As Integer = checkedListBox.SelectedIndex
        If selectedIndex <> -1 Then
            checkedListBox.SetItemChecked(selectedIndex, True)
        End If
    End Sub

    'Maneja el cambio de modo a noche 
    Private Sub PB_NightMode_Click(sender As Object, e As EventArgs) Handles PB_NightMode.Click
        Dim config As Configuration = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None)
        config.AppSettings.Settings("Theme").Value = "Night"
        config.Save(ConfigurationSaveMode.Modified)
        ConfigurationManager.RefreshSection("appSettings")
        SetTheme()
    End Sub

    'Maneja el cambio de modo a dia 
    Private Sub PB_DayMode_Click(sender As Object, e As EventArgs) Handles PB_DayMode.Click
        Dim config As Configuration = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None)
        config.AppSettings.Settings("Theme").Value = "Day"
        config.Save(ConfigurationSaveMode.Modified)
        ConfigurationManager.RefreshSection("appSettings")
        SetTheme()
    End Sub

    'Llama a la función HandleUser
    Private Sub ListBox_Users_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox_Users.SelectedIndexChanged
        HandleUser()
    End Sub

    'Deselecciona el usuario seleccionado
    Private Sub ConfigPage_MouseClick(sender As Object, e As MouseEventArgs) Handles MyBase.MouseClick
        ListBox_Users.ClearSelected()
        TxtBox_Name.Text = ""
        TxtBox_Password.Text = ""
        TxtBox_Email.Text = ""
        For i As Integer = 0 To CheckedListBox_Roles.Items.Count - 1
            CheckedListBox_Roles.SetItemChecked(i, False)
        Next
        Btn_EditUser.Enabled = False
        Btn_NewUser.Enabled = True
    End Sub
#End Region

#Region "Main subs and functions region"
    ' Funciones principales

    'Funcion para alternar entre modo noche y modo dia
    Public Sub SetTheme()
        Dim theme As String = ConfigurationManager.AppSettings("Theme")

        If theme = "Night" Then
            PB_NightMode.Visible = False
            PB_DayMode.Visible = True
            RoomsPage.BackColor = SystemColors.WindowFrame
            CleaningServicesPage.BackColor = SystemColors.WindowFrame
            Me.BackColor = SystemColors.WindowFrame
            SeeReservationPage.BackColor = SystemColors.WindowFrame
            IncidentPage.BackColor = SystemColors.WindowFrame
            LoginPage.BackColor = SystemColors.WindowFrame
            MainPage.BackColor = SystemColors.WindowFrame
            MaintenancePage.BackColor = SystemColors.WindowFrame
            NewReservationPage.BackColor = SystemColors.WindowFrame
            ReservationPage.BackColor = SystemColors.WindowFrame
        Else
            PB_DayMode.Visible = False
            PB_NightMode.Visible = True
            RoomsPage.BackColor = SystemColors.Window
            CleaningServicesPage.BackColor = SystemColors.Window
            Me.BackColor = SystemColors.Window
            SeeReservationPage.BackColor = SystemColors.Window
            IncidentPage.BackColor = SystemColors.Window
            LoginPage.BackColor = SystemColors.Window
            MainPage.BackColor = SystemColors.Window
            MaintenancePage.BackColor = SystemColors.Window
            NewReservationPage.BackColor = SystemColors.Window
            ReservationPage.BackColor = SystemColors.Window
        End If
    End Sub

    'Rellena el combobox
    Private Sub FillComboBox()
        Try
            Using connection As New MySqlConnection(connectionString)
                connection.Open()
                Dim query As String = "SELECT nombre FROM Usuario"
                Dim command As New MySqlCommand(query, connection)
                Dim reader As MySqlDataReader = command.ExecuteReader()

                While reader.Read()
                    ListBox_Users.Items.Add(reader("nombre").ToString())
                End While

                reader.Close()
            End Using
        Catch ex As Exception
            MessageBox.Show("Error al conectar a la base de datos: " & ex.Message)
        End Try
    End Sub

    'Cargar datos en el gráfico
    Private Sub LoadMonthlyRevenueChart()
        ' 1. Obtener los datos de la base de datos
        Dim query As String = "SELECT MONTH(fecha_emision) AS Mes, SUM(total) AS FacturacionMensual FROM Factura WHERE YEAR(fecha_emision) = 2024 GROUP BY MONTH(fecha_emision)"
        Dim dataTable As New DataTable()

        Using connection As New MySqlConnection(connectionString)
            Dim adapter As New MySqlDataAdapter(query, connection)
            adapter.Fill(dataTable)
        End Using

        ' 2. Procesar los datos
        Dim series As New Series("Facturación Mensual")
        series.ChartType = SeriesChartType.Column

        For Each row As DataRow In dataTable.Rows
            Dim month As Integer = Convert.ToInt32(row("Mes"))
            Dim revenue As Double = Convert.ToDouble(row("FacturacionMensual"))
            series.Points.AddXY(month, revenue)
        Next

        ' 3. Asignar datos al Chart
        Chart1.Series.Clear()
        Chart1.Series.Add(series)
        Chart1.ChartAreas(0).AxisX.Title = "Mes"
        Chart1.ChartAreas(0).AxisY.Title = "Facturación"
    End Sub

    'Maneja la funcionalidad cuando se selecciona un usuario rellenando las txtbox necesarias
    Private Sub HandleUser()
        If ListBox_Users.SelectedIndex <> -1 Then
            Btn_EditUser.Enabled = True
            Btn_NewUser.Enabled = False
            For i As Integer = 0 To CheckedListBox_Roles.Items.Count - 1
                CheckedListBox_Roles.SetItemChecked(i, False)
            Next
            Dim selectedUserName As String = ListBox_Users.SelectedItem.ToString()
            Try
                Using connection As New MySqlConnection(connectionString)
                    connection.Open()
                    Dim query As String = "SELECT * FROM Usuario WHERE nombre = @nombre"
                    Dim command As New MySqlCommand(query, connection)
                    command.Parameters.AddWithValue("@nombre", selectedUserName)
                    Dim reader As MySqlDataReader = command.ExecuteReader()

                    If reader.Read() Then
                        userId = reader.GetInt32("id_usuario")
                        userName = reader.GetString("nombre")
                        userPass = reader.GetString("contrasena")
                        userMail = reader.GetString("email")
                        userRole = reader.GetInt32("id_rol")
                    End If

                    TxtBox_Name.Text = userName
                    TxtBox_Password.Text = userPass
                    TxtBox_Email.Text = userMail
                    CheckedListBox_Roles.SetItemChecked(userRole - 1, True)

                    reader.Close()
                End Using
            Catch ex As Exception
                MessageBox.Show("Error al obtener los datos del usuario: " & ex.Message)
            End Try
        End If
    End Sub

    'Inserta los datos introducidos en los txtbox para añadir un nuevo usuario
    Private Sub NewUser()
        TxtBox_Name.Text = userName
        TxtBox_Password.Text = userPass
        TxtBox_Email.Text = userMail

        Dim query As String = "INSERT INTO Usuario (nombre, email, contrasena, id_rol) VALUES (@nombre, @email, @contrasena, @id_rol)"
        Using connection As New MySqlConnection(connectionString)
            Using command As New MySqlCommand(query, connection)
                command.Parameters.AddWithValue("@nombre", TxtBox_Name.Text)
                command.Parameters.AddWithValue("@email", TxtBox_Email.Text)
                command.Parameters.AddWithValue("@contrasena", TxtBox_Password.Text)
                command.Parameters.AddWithValue("@id_rol", CheckedListBox_Roles.SelectedIndex + 1)
                Try
                    connection.Open()
                    Dim rowsAffected As Integer = command.ExecuteNonQuery()

                    If rowsAffected > 0 Then
                        MessageBox.Show("Usuario insertado correctamente.")
                    Else
                        MessageBox.Show("No se pudo insertar el usuario.")
                    End If
                Catch ex As Exception
                    MessageBox.Show("Error al insertar el usuario: " & ex.Message)
                End Try
            End Using
        End Using
        FillComboBox()
    End Sub

    'Botón que actualiza los datos introducidos para el usuario seleccioando
    Private Sub EditUser()
        Dim query As String = "UPDATE Usuario SET nombre = @nombre, email = @email, contrasena = @contrasena, id_rol = @id_rol WHERE id_usuario = @id"
        Using connection As New MySqlConnection(connectionString)
            Using command As New MySqlCommand(query, connection)
                command.Parameters.AddWithValue("@nombre", TxtBox_Name.Text)
                command.Parameters.AddWithValue("@email", TxtBox_Email.Text)
                command.Parameters.AddWithValue("@contrasena", TxtBox_Password.Text)
                command.Parameters.AddWithValue("@id_rol", CheckedListBox_Roles.SelectedIndex + 1)
                command.Parameters.AddWithValue("@id", userId)

                Try
                    connection.Open()
                    Dim rowsAffected As Integer = command.ExecuteNonQuery()

                    If rowsAffected > 0 Then
                        MessageBox.Show("Usuario actualizado correctamente.")
                    Else
                        MessageBox.Show("No se pudo encontrar el usuario especificado.")
                    End If
                Catch ex As Exception
                    MessageBox.Show("Error al actualizar el usuario: " & ex.Message)
                End Try
            End Using
        End Using
        TxtBox_Name.Text = ""
        TxtBox_Password.Text = ""
        TxtBox_Email.Text = ""
        For i As Integer = 0 To CheckedListBox_Roles.Items.Count - 1
            CheckedListBox_Roles.SetItemChecked(i, False)
        Next

        Btn_EditUser.Enabled = False
        Btn_NewUser.Enabled = True
    End Sub
#End Region
End Class