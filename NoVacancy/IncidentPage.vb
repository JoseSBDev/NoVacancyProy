Imports MySqlConnector

Public Class IncidentPage

    Dim server = "localhost"
    Dim user = "root"
    Dim pwd = "root"
    Dim database = "hotel"
    Dim connectionString = "server=" & server & ";user=" & user & ";password=" & pwd & ";database=" & database
    Dim roomsId As New Dictionary(Of String, Integer)()

#Region "onLoad region"
    Private Sub IncidentPage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CB_Type.Items.Add("Mantenimiento")
        CB_Type.Items.Add("Limpieza")

        FillRoomComboBox()
    End Sub
#End Region

#Region "Button events region"
    ' Eventos de clic en botones

    'Llama a create incident
    Private Sub Btn_CreateIncident_Click(sender As Object, e As EventArgs) Handles Btn_CreateIncident.Click
        CreateIncident()
    End Sub
#End Region

#Region "Other controls events region"
    ' Otros eventos de controles
#End Region

#Region "Main subs and functions region"
    ' Funciones y subprocedimientos principales
    Public Sub FillRoomComboBox()
        Dim query As String = "SELECT numero_habitacion FROM Habitacion"
        Dim id = 1
        Using connection As New MySqlConnection(connectionString)
            Dim command As New MySqlCommand(query, connection)
            connection.Open()
            Dim reader As MySqlDataReader = command.ExecuteReader()
            While reader.Read()
                CB_Room.Items.Add(reader("numero_habitacion").ToString())
                roomsId.Add(reader("numero_habitacion").ToString(), id)
                id += 1
            End While
            reader.Close()
        End Using
    End Sub

    Private Sub CreateIncident()
        Dim selectedRoomNumber As String = CB_Room.SelectedItem.ToString()
        Dim roomId As Integer = -1
        If roomsId.ContainsKey(selectedRoomNumber) Then
            roomId = roomsId(selectedRoomNumber)
        End If

        'Verificar si se seleccionó una habitación válida
        If roomId <> -1 Then
            Dim incidentType As String = CB_Type.Text
            Dim description As String = RTB_Description.Text
            Dim today As Date = Now

            Dim query As String = $"INSERT INTO {incidentType}(id_habitacion, descripcion, fecha) VALUES (@roomId, @description, @date)"

            Using connection As New MySqlConnection(connectionString)
                Dim command As New MySqlCommand(query, connection)
                command.Parameters.AddWithValue("@roomId", roomId)
                'command.Parameters.AddWithValue("@incidentType", incidentType)
                command.Parameters.AddWithValue("@description", description)
                command.Parameters.AddWithValue("@date", today.ToString("yyyy-MM-dd"))
                connection.Open()
                command.ExecuteNonQuery()
            End Using
            MsgBox("Incidencia enviada.")
            Me.Close()
        Else
            MessageBox.Show("Seleccione una habitación válida.")
        End If
    End Sub
#End Region
End Class