Imports System.Text.RegularExpressions
Imports MySqlConnector

Public Class NewReservationPage
    Public startDate As Date
    Public endDate As Date
    Public roomNumber As Integer
    Public roomPrice As Double
    Public roomType As String
    Public reservationPrice As Integer
    Dim server = "localhost"
    Dim user = "root"
    Dim pwd = "root"
    Dim database = "hotel"
    Dim connectionString = "server=" & server & ";user=" & user & ";password=" & pwd & ";database=" & database
    Dim ableToReserve As Boolean
    Public roomId As Integer
    Dim clientEmail As String
    Dim clientName As String
    Dim clientPhone As String

#Region "onLoad region"
    Private Sub NewReservationPage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim clientEmail = Nothing
        Dim clientName = Nothing
        Dim clientPhone = Nothing

        TxtBox_ClientName.Text = Nothing
        TxtBox_ClientPhone.Text = Nothing
        TxtBox_SearchClient.Text = Nothing

        ableToReserve = False

        TxtBox_Name.Text = "Nombre"
        TxtBox_Name.ForeColor = SystemColors.GrayText
        TxtBox_Name.BackColor = SystemColors.Window
        TxtBox_Phone.Text = "Teléfono"
        TxtBox_Phone.ForeColor = SystemColors.GrayText
        TxtBox_Phone.BackColor = SystemColors.Window
        TxtBox_Mail.Text = "Email"
        TxtBox_Mail.ForeColor = SystemColors.GrayText
        TxtBox_Mail.BackColor = SystemColors.Window

        TxtBox_Room.Text = roomNumber.ToString()
        TxtBox_Type.Text = roomType
        TxtBox_Startdate.Text = startDate.ToString("yyyy-MM-dd")
        TxtBox_Enddate.Text = endDate.ToString("yyyy-MM-dd")

        Dim daysDiff As Integer = (endDate - startDate).Days
        reservationPrice = roomPrice * daysDiff
        Lbl_Price.Text = reservationPrice
        CheckIfAble()
    End Sub
#End Region

#Region "Button events region"
    'Evento que llama a CreateClient
    Private Sub Btn_CreateClient_Click(sender As Object, e As EventArgs) Handles Btn_CreateClient.Click
        CreateClient()
    End Sub
    'Evento que llama a CreateReservation
    Private Sub Btn_AcceptReservation_Click(sender As Object, e As EventArgs) Handles Btn_AcceptReservation.Click
        CreateReservation()
    End Sub
#End Region

#Region "Other controls events region"

    'Desactiva o activa los controles en cada caso dependiendo de la selección
    Private Sub ChkBox_NewClient_CheckedChanged(sender As Object, e As EventArgs) Handles ChkBox_NewClient.CheckedChanged
        If ChkBox_NewClient.Checked Then
            For Each control As Control In Panel1.Controls
                If TypeOf control Is TextBox Then
                    Dim textBox As TextBox = DirectCast(control, TextBox)
                    textBox.Enabled = True
                End If
                ableToReserve = False
            Next
            TxtBox_SearchClient.Enabled = False
            Btn_CheckClient.Enabled = False
            Btn_CreateClient.Enabled = True
        Else
            For Each control As Control In Panel1.Controls
                If TypeOf control Is TextBox Then
                    Dim textBox As TextBox = DirectCast(control, TextBox)
                    textBox.Enabled = False
                End If
                ableToReserve = False
            Next
            TxtBox_SearchClient.Enabled = True
            Btn_CheckClient.Enabled = True
            Btn_CreateClient.Enabled = False
        End If
        CheckIfAble()
    End Sub

    Private Sub TextBox_GotFocus(sender As Object, e As EventArgs) Handles TxtBox_Mail.GotFocus, TxtBox_Name.GotFocus, TxtBox_Phone.GotFocus
        Dim textBox As TextBox = DirectCast(sender, TextBox)
        textBox.Text = ""
        textBox.ForeColor = SystemColors.WindowText
    End Sub

    Private Sub TxtBox_Mail_LostFocus(sender As Object, e As EventArgs) Handles TxtBox_Mail.LostFocus
        Dim textBox As TextBox = DirectCast(sender, TextBox)
        If String.IsNullOrEmpty(textBox.Text) Then
            textBox.Text = "Email"
            textBox.ForeColor = SystemColors.GrayText
        End If
    End Sub

    Private Sub TxtBox_Name_LostFocus(sender As Object, e As EventArgs) Handles TxtBox_Name.LostFocus
        Dim textBox As TextBox = DirectCast(sender, TextBox)
        If String.IsNullOrEmpty(textBox.Text) Then
            textBox.Text = "Nombre"
            textBox.ForeColor = SystemColors.GrayText
        End If
    End Sub

    Private Sub TxtBox_Phone_LostFocus(sender As Object, e As EventArgs) Handles TxtBox_Phone.LostFocus
        Dim textBox As TextBox = DirectCast(sender, TextBox)
        If String.IsNullOrEmpty(textBox.Text) Then
            textBox.Text = "Teléfono"
            textBox.ForeColor = SystemColors.GrayText
        End If
    End Sub

    'Funcionalidad para que pulsando al intro desde el txtbox llame a una función
    Private Sub TxtBox_SearchClient_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtBox_SearchClient.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            SearchByEmail()
        End If
    End Sub

    'Funcionalidad para que pulsando al intro desde el txtbox llame a una función
    Private Sub TxtBox_Mail_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtBox_Mail.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            CreateClient()
        End If
    End Sub
#End Region

#Region "Main subs and functions region"

    'Busca al cliente por el email
    Private Sub SearchByEmail()
        clientEmail = TxtBox_SearchClient.Text.Trim() 'Se eliminan espacios con trim

        If clientEmail IsNot Nothing Then
            Dim query As String = "SELECT * FROM Cliente WHERE email = @searchEmail"
            Using connection As New MySqlConnection(connectionString)
                Dim command As New MySqlCommand(query, connection)
                command.Parameters.AddWithValue("@searchEmail", clientEmail)
                Try
                    connection.Open()
                    Dim reader As MySqlDataReader = command.ExecuteReader()
                    'Si se han encontrado coincidencias, imprime los datos en los txtbox correspondientes, de lo contrario avisa al usuario
                    If reader.HasRows Then
                        While reader.Read()
                            clientName = reader("nombre").ToString()
                            clientPhone = reader("telefono").ToString()
                        End While
                        TxtBox_ClientName.Text = clientName
                        TxtBox_ClientPhone.Text = clientPhone
                        ableToReserve = True
                        CheckIfAble()
                    Else
                        MsgBox("No se encontraron coincidencias.")
                    End If
                Catch ex As Exception
                    MessageBox.Show("Error al buscar cliente: " & ex.Message)
                End Try
            End Using
        End If
    End Sub

    'Checkea si está disponible para reservar
    Public Sub CheckIfAble()
        If ableToReserve = True Then
            Btn_AcceptReservation.Enabled = True
            Btn_AcceptReservation.BackColor = SystemColors.GradientInactiveCaption
        Else
            Btn_AcceptReservation.Enabled = False
            Btn_AcceptReservation.BackColor = Color.LightCoral
        End If
    End Sub

    'Checkea el mail del cliente
    Private Function CheckClientMail(email As String)
        Dim clientId As Integer
        Dim query As String = "SELECT id_cliente FROM Cliente WHERE email = @searchEmail"
        Using connection As New MySqlConnection(connectionString)
            Dim command As New MySqlCommand(query, connection)
            command.Parameters.AddWithValue("@searchEmail", email)
            Try
                connection.Open()
                Dim reader As MySqlDataReader = command.ExecuteReader()
                'Cuando encuentre la fila coincidente con el email (unique) devuelve el ID 
                If reader.HasRows Then
                    reader.Read()
                    clientId = Convert.ToInt32(reader("id_cliente"))
                Else
                    MsgBox("No se encontraron coincidencias.")
                End If
            Catch ex As Exception
                MessageBox.Show("Error al buscar cliente: " & ex.Message)
            End Try
        End Using
        Return clientId
    End Function

    'Crea el cliente revisando antes el formato de los datos 
    Public Sub CreateClient()
        'Uso expresiones regulares para controlar el formato de los datos introducidos
        Dim emailPattern As String = "\b[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Z|a-z]{2,}\b" 'Patron de mail
        Dim regexMail As New Regex(emailPattern)
        Dim phonePattern As String = "\b[0-9]{7,14}\b" 'Patron de telefono sin codigo de pais
        Dim regexPhone As New Regex(phonePattern)
        Dim namePattern As String = "\b[A-Za-z]+$\b" 'Patron de nombre
        Dim regexName As New Regex(namePattern)

        If Not regexMail.IsMatch(TxtBox_Mail.Text) Then
            MessageBox.Show("El correo electrónico no tiene un formato válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            TxtBox_Mail.BackColor = Color.LightCoral
        ElseIf Not regexPhone.IsMatch(TxtBox_Phone.Text) Then
            MessageBox.Show("El número de teléfono no tiene un formato válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            TxtBox_Phone.BackColor = Color.LightCoral
        ElseIf Not regexName.IsMatch(TxtBox_Name.Text) Then
            MessageBox.Show("El nombre no tiene un formato válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            TxtBox_Name.BackColor = Color.LightCoral
        Else
            clientEmail = TxtBox_Mail.Text
            clientPhone = TxtBox_Phone.Text
            clientName = TxtBox_Name.Text

            Dim insert As String = "INSERT INTO Cliente (nombre, telefono, email) VALUES (@nombre, @telefono, @email)"
            Using connection As New MySqlConnection(connectionString)
                Dim command As New MySqlCommand(insert, connection)
                command.Parameters.AddWithValue("@nombre", clientName)
                command.Parameters.AddWithValue("@telefono", clientPhone)
                command.Parameters.AddWithValue("@email", clientEmail)
                Try
                    connection.Open()
                    command.ExecuteNonQuery()
                    MsgBox("Cliente creado con éxito.")
                    For Each control As Control In Panel1.Controls
                        If TypeOf control Is TextBox Then
                            Dim textBox As TextBox = DirectCast(control, TextBox)
                            textBox.Enabled = False
                        End If
                    Next
                    Btn_CreateClient.Enabled = False
                    ableToReserve = True
                    CheckIfAble()
                Catch ex As Exception
                    MessageBox.Show("Error al buscar cliente: " & ex.Message)
                End Try
            End Using
        End If
    End Sub

    'Crea la reserva
    Public Sub CreateReservation()
        Dim clientId As Integer

        If ableToReserve = True Then
            clientId = CheckClientMail(clientEmail)
            Dim insert As String = "INSERT INTO Reserva (id_cliente, id_habitacion, fecha_inicio, fecha_fin, precio_reserva) VALUES (@id_cliente, @id_habitacion, @startdate, @enddate, @reservationPrice)"
            Using connection As New MySqlConnection(connectionString)
                Dim command As New MySqlCommand(insert, connection)
                command.Parameters.AddWithValue("@id_cliente", clientId)
                command.Parameters.AddWithValue("@id_habitacion", roomId)
                command.Parameters.AddWithValue("@startdate", startDate)
                command.Parameters.AddWithValue("@enddate", endDate)
                command.Parameters.AddWithValue("@reservationPrice", reservationPrice)
                Try
                    connection.Open()
                    command.ExecuteNonQuery()
                    MsgBox("Reserva creada con éxito. Habitacion " & roomNumber & ". Desde el " & startDate & " hasta el " & endDate & " para el cliente " & clientName)
                    Me.Close()
                Catch ex As Exception
                    MessageBox.Show("Error al buscar cliente: " & ex.Message)
                End Try
            End Using
        Else
            MsgBox("Rellene los datos necesarios para la reserva y vuelva a intentarlo.")
        End If
    End Sub
#End Region

End Class