Imports MySqlConnector

Public Class RoomsPage
    Dim dataSet As DataSet
    Dim dataAdapterRooms As MySqlDataAdapter
    Dim cbRooms As MySqlCommandBuilder
    Dim server = "localhost"
    Dim user = "root"
    Dim pwd = "root"
    Dim database = "hotel"
    Dim connectionString = "server=" & server & ";user=" & user & ";password=" & pwd & ";database=" & database
    Dim cn As New MySqlConnection(connectionString)
    Dim role

    Private Sub RoomsPage_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'role = MainPage.role
        'If role! = "Administrador" Or role!= "Gerencia" Or role! = "Recepcion" Then
        '   Btn_UpdateRooms.Enabled = False
        '   DataGridViewRooms.ReadOnly = False
        'End If

        Try
            ' Llena el ComboBox de tipos de habitación
            FillComboBoxRoomType()

            ' Llena el ComboBox de disponibilidad
            ComboBoxRoomStat.Items.AddRange({"Todas", "Disponible", "Ocupada"})

            ' Por defecto, muestra todas las habitaciones
            ComboBoxRoomStat.SelectedIndex = 0
            ComboBoxRoomType.SelectedIndex = 0


            ' Actualiza la lista de habitaciones
            UpdateRoomList()

        Catch ex As Exception
            ' Maneja cualquier excepción
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub

    Private Sub FillComboBoxRoomType()
        Try
            ' Construye la consulta SQL para obtener los tipos de habitación distintos
            Dim sqlQuery As String = "SELECT DISTINCT tipo FROM habitacion"

            ' Crea un comando para ejecutar la consulta
            Dim cmd As New MySqlCommand(sqlQuery, cn)

            ' Abre la conexión
            cn.Open()

            ' Crea un lector de datos para obtener los resultados de la consulta
            Dim reader As MySqlDataReader = cmd.ExecuteReader()

            ' Limpia los elementos previos del ComboBox
            ComboBoxRoomType.Items.Clear()
            ComboBoxRoomType.Items.Add("Todas")

            ' Recorre los resultados y añade los tipos de habitación al ComboBox
            While reader.Read()
                ComboBoxRoomType.Items.Add(reader("tipo").ToString())
            End While

            ' Cierra el lector de datos
            reader.Close()

        Catch ex As Exception
            MessageBox.Show("Error al llenar el ComboBox de tipos de habitación: " & ex.Message)
        Finally
            ' Cierra la conexión
            cn.Close()
        End Try
    End Sub

    Private Sub UpdateRoomList()
        Try
            ' Construye la consulta SQL base
            Dim sqlQuery As String = "SELECT * FROM habitacion WHERE 1 = 1"

            ' Filtra por tipo de habitación si se selecciona uno en el ComboBox
            If ComboBoxRoomType.SelectedIndex > 0 Then
                sqlQuery &= " AND tipo = '" & ComboBoxRoomType.SelectedItem.ToString() & "'"
            ElseIf ComboBoxRoomType.SelectedIndex = 0 Then
                sqlQuery &= " AND tipo = tipo "
            End If

            ' Filtra por disponibilidad según lo seleccionado en el ComboBox de disponibilidad
            If ComboBoxRoomStat.SelectedIndex = 1 Then
                sqlQuery &= " AND estado = 'Disponible'" ' Habitaciones disponibles
            ElseIf ComboBoxRoomStat.SelectedIndex = 2 Then
                sqlQuery &= " AND estado = 'Ocupada'" ' Habitaciones no disponibles
            End If

            If Not String.IsNullOrEmpty(TextBoxRoomNumber.Text) Then
                sqlQuery &= " AND numero_habitacion = " & TextBoxRoomNumber.Text
            End If

            ' Crea el adaptador de datos con la consulta SQL actualizada
            dataAdapterRooms = New MySqlDataAdapter(sqlQuery, cn)

            ' Crea un nuevo DataSet
            dataSet = New DataSet

            ' Abre la conexión
            cn.Open()

            ' Rellena el DataSet con la información
            dataAdapterRooms.Fill(dataSet, "habitacion")

            ' Asigna el origen de datos al DataGridView
            DataGridViewRooms.DataSource = dataSet.Tables("habitacion")
            DataGridViewRooms.Columns("estado").Visible = False
        Catch ex As Exception
            ' Maneja cualquier excepción
            MessageBox.Show("Error al actualizar la lista de habitaciones: " & ex.Message)
        Finally
            ' Cierra la conexión
            cn.Close()
        End Try
    End Sub

    Private Sub UpdateDatabase()
        Try
            cn.Open()
            dataAdapterRooms.Update(dataSet, "habitacion")
            cn.Close()
            MessageBox.Show("Base de datos actualizada correctamente.")
            UpdateRoomList()
        Catch ex As Exception
            MessageBox.Show("Error al actualizar la base de datos: " & ex.Message)
        Finally
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
    End Sub


    Private Sub ComboBoxRoomType_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxRoomType.SelectedIndexChanged, ComboBoxRoomStat.SelectedIndexChanged
        ' Actualiza la lista de habitaciones al cambiar la opción en los ComboBox
        UpdateRoomList()
    End Sub

    Private Sub TextBoxRoomNumber_TextChanged(sender As Object, e As EventArgs) Handles TextBoxRoomNumber.TextChanged
        ' Actualiza la lista de habitaciones al cambiar el texto en el TextBox
        UpdateRoomList()
    End Sub

    Private Sub Btn_Reservations_Click(sender As Object, e As EventArgs) Handles Btn_UpdateRooms.Click
        UpdateDatabase()
    End Sub
End Class
