Imports MySqlConnector

Public Class EditReservationForm
    Dim server = "localhost"
    Dim user = "root"
    Dim pwd = "root"
    Dim database = "hotel"
    Dim connectionString = "server=" & server & ";user=" & user & ";password=" & pwd & ";database=" & database
    Public reservationId As Integer
    Dim startDate As Date
    Dim endDate As Date
    Public roomId As Integer
    Dim globalProduct As String

    Private Sub EditReservationForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ShowReservation()
        FillComboBoxProducts()
    End Sub
    Private Sub ShowReservation()
        Dim query As String = " SELECT h.numero_habitacion, 
                                h.tipo,
                                r.fecha_inicio,
                                r.fecha_fin,
                                h.precio
                                FROM Habitacion h
                                LEFT JOIN Reserva r ON h.id_habitacion = r.id_habitacion
                                WHERE r.id_reserva = @reservation_id"

        Using connection As New MySqlConnection(connectionString)
            Dim adapter As New MySqlDataAdapter(query, connection)
            adapter.SelectCommand.Parameters.AddWithValue("@reservation_id", reservationId)
            Dim dataTable As New DataTable()
            adapter.Fill(dataTable)

            If dataTable.Rows.Count > 0 Then
                DataGridView1.DataSource = dataTable
                FillTextBox()
            Else
                MessageBox.Show("No se encontraron reservas para el ID especificado.")
            End If
        End Using
    End Sub

    Private Sub Btn_EditReservation_Click(sender As Object, e As EventArgs) Handles Btn_EditReservation.Click
        startDate = TxtBox_Startdate.Text
        endDate = TxtBox_Enddate.Text
        EditReservation()
    End Sub

    Private Sub Btn_DeleteReservation_Click(sender As Object, e As EventArgs) Handles Btn_DeleteReservation.Click
        startDate = TxtBox_Startdate.Text
        endDate = TxtBox_Enddate.Text
        DeleteReservation()
    End Sub

    Private Sub FillTextBox()
        If DataGridView1.Rows.Count > 0 Then
            Dim firstRow As DataGridViewRow = DataGridView1.Rows(0)
            TxtBox_Room.Text = Convert.ToInt32(firstRow.Cells("numero_habitacion").Value)
            TxtBox_Type.Text = firstRow.Cells("tipo").Value.ToString()
            startDate = firstRow.Cells("fecha_inicio").Value
            TxtBox_Startdate.Text = startDate.ToString("yyyy-MM-dd")
            endDate = firstRow.Cells("fecha_fin").Value
            TxtBox_Enddate.Text = endDate.ToString("yyyy-MM-dd")
        End If
    End Sub
    Private Sub EditReservation()
        Dim result As DialogResult = MessageBox.Show("¿Está seguro de que desea editar esta reserva?", "Confirmar edición", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
        If result = DialogResult.OK Then
            Dim query As String = " UPDATE Reserva
                                    SET fecha_inicio = @startdate, fecha_fin = @enddate
                                    WHERE id_reserva = @id_reserva
                                    AND id_habitacion = @id_habitacion
                                    "
            Using connection As New MySqlConnection(connectionString)
                Using command As New MySqlCommand(query, connection)
                    command.Parameters.AddWithValue("@startdate", startDate.ToString("yyyy-MM-dd"))
                    command.Parameters.AddWithValue("@enddate", endDate.ToString("yyyy-MM-dd"))
                    command.Parameters.AddWithValue("@id_reserva", reservationId)
                    command.Parameters.AddWithValue("@id_habitacion", roomId)
                    Try
                        connection.Open()
                        If CheckDisponibility() = True Then
                            Dim rowsAffected As Integer = command.ExecuteNonQuery()
                        Else
                            MessageBox.Show("No se encontraron reservas para el ID especificado.")
                        End If
                    Catch ex As Exception
                        MessageBox.Show("Error al editar la reserva: " & ex.Message)
                    End Try
                End Using
            End Using
            Me.Close()
        End If
    End Sub

    Public Function CheckDisponibility()
        Dim avaiable As Boolean = False
        Dim query As String = " SELECT *
                                FROM Reserva
                                WHERE id_habitacion = @id_habitacion
                                AND id_reserva <> @id_reserva -- Excluimos la reserva actual
                                AND @startdate BETWEEN fecha_inicio AND fecha_fin
                                or @enddate between fecha_inicio and fecha_fin"
        Using connection As New MySqlConnection(connectionString)
            Dim command As New MySqlCommand(query, connection)
            command.Parameters.AddWithValue("@startdate", startDate.ToString("yyyy-MM-dd"))
            command.Parameters.AddWithValue("@enddate", endDate.ToString("yyyy-MM-dd"))
            command.Parameters.AddWithValue("@id_reserva", reservationId)
            command.Parameters.AddWithValue("@id_habitacion", roomId)
            Try
                connection.Open()
                Dim reader As MySqlDataReader = Command.ExecuteReader()
                'Cuando encuentre la fila coincidente con el email (unique) devuelve el ID 
                If reader.HasRows Then
                    reader.Read()
                    avaiable = False
                Else
                    avaiable = True
                End If
            Catch ex As Exception
                MessageBox.Show("Error al editar la reserva: " & ex.Message)
            End Try
        End Using
        Return avaiable
    End Function

    Public Sub DeleteReservation()
        Dim result As DialogResult = MessageBox.Show("¿Está seguro de que desea eliminar esta reserva?", "Confirmar eliminación", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
        If result = DialogResult.OK Then
            Dim query As String = "DELETE FROM Reserva WHERE id_reserva = @reservationId"
            Using connection As New MySqlConnection(connectionString)
                Using command As New MySqlCommand(query, connection)
                    command.Parameters.AddWithValue("@reservationId", reservationId)
                    Try
                        connection.Open()
                        Dim rowsAffected As Integer = command.ExecuteNonQuery()
                        If rowsAffected > 0 Then
                            MessageBox.Show("La reserva se ha eliminado correctamente.")
                        Else
                            MessageBox.Show("No se encontró la reserva con el ID especificado.")
                        End If
                    Catch ex As Exception
                        MessageBox.Show("Error al eliminar la reserva: " & ex.Message)
                    End Try
                End Using
            End Using
            Me.Close()
        End If
    End Sub

    Private Sub FillComboBoxProducts()
        Dim query As String = "SELECT DISTINCT nombre FROM Producto"
        Using connection As New MySqlConnection(connectionString)
            Using command As New MySqlCommand(query, connection)
                Try
                    connection.Open()
                    ' Crea un lector de datos para obtener los resultados de la consulta
                    Dim reader As MySqlDataReader = command.ExecuteReader()
                    CB_Products.Items.Clear()
                    ' Recorre los resultados y añade los tipos de habitación al ComboBox
                    While reader.Read()
                        CB_Products.Items.Add(reader("nombre").ToString())
                    End While

                    ' Cierra el lector de datos
                    reader.Close()
                    connection.Close()
                Catch ex As Exception
                    MessageBox.Show("Error al editar la reserva: " & ex.Message)
                End Try
            End Using
        End Using
    End Sub

    Private Sub CB_Products_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CB_Products.SelectedIndexChanged
        GetProductQuantityInReservation(CB_Products.Text)
    End Sub

    Private Sub GetProductQuantityInReservation(productName As String)
        ' Construye la consulta SQL para obtener la cantidad del producto en la reserva
        Dim query As String = "SELECT p.nombre, pr.cantidad 
                                    FROM ProductosDeLaReserva pr 
                                    INNER JOIN Producto p ON pr.id_producto = p.id_producto 
                                    WHERE p.nombre = @selectedProduct
                                    AND pr.id_reserva = 1"
        Using connection As New MySqlConnection(connectionString)
            Dim adapter As New MySqlDataAdapter(query, connection)
            adapter.SelectCommand.Parameters.AddWithValue("@selectedProduct", productName)
            Dim dataTable As New DataTable()
            adapter.Fill(dataTable)

            If dataTable.Rows.Count > 0 Then
                Dim cantidad As Integer = Convert.ToInt32(dataTable.Rows(0)("cantidad"))
                TxtBox_Quantity.Text = cantidad
            Else
                TxtBox_Quantity.Text = 0
            End If
            globalProduct = productName
        End Using
        Btn_Minus.Enabled = True
        Btn_Plus.Enabled = True
    End Sub

    Private Sub Btn_Minus_Click(sender As Object, e As EventArgs) Handles Btn_Minus.Click
        If TxtBox_Quantity.Text IsNot Nothing AndAlso TxtBox_Quantity.Text > 0 Then
            Dim quantity As Integer = TxtBox_Quantity.Text
            TxtBox_Quantity.Text = quantity - 1
            ListBox_ReservationProds.Items.Add(globalProduct & " " & quantity - 1)
        End If
    End Sub

    Private Sub Btn_Plus_Click(sender As Object, e As EventArgs) Handles Btn_Plus.Click
        If TxtBox_Quantity.Text IsNot Nothing Then
            Dim quantity As Integer = TxtBox_Quantity.Text
            TxtBox_Quantity.Text = quantity + 1
            ListBox_ReservationProds.Items.Add(globalProduct & " " & quantity + 1)
        End If
    End Sub
End Class