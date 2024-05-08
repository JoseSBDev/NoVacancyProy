Imports MySqlConnector

Public Class ReservationPage
    Dim server = "localhost"
    Dim user = "root"
    Dim pwd = "root"
    Dim database = "hotel"
    Dim connectionString = "server=" & server & ";user=" & user & ";password=" & pwd & ";database=" & database
    Dim startDate As Date
    Dim endDate As Date
    Dim roomNumber As Integer
    Dim roomPrice As Double
    Dim roomType As String
    Dim roomState As String
    Dim roomid As Integer
    Dim reservationID As Integer

#Region "onLoad region"
    Private Sub ReservationPage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        startDate = DateTimePicker1.Value.Date
        endDate = DateTimePicker2.Value.Date

        'Controlar que se seleccione toda la fila para que el boton de nueva reserva funcione como se espera
        DataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        ShowAvailableRooms(startDate, endDate)
    End Sub
#End Region

#Region "Button events region"
    ' Eventos de clic en botones

    'Muestra la página de la reserva en caso de estar seleccionada una fila de una reserva ocupada
    Private Sub Btn_SeeReservation_Click(sender As Object, e As EventArgs) Handles Btn_SeeReservation.Click
        If DataGridView1.SelectedRows.Count = 1 AndAlso roomState = "Ocupada" Then
            SeeReservationForm.ShowDialog()
            ShowAvailableRooms(startDate, endDate)
        Else
            MsgBox("Debes seleccionar una fila con habitación ocupada para poder editar una reserva.")
        End If
    End Sub

    'Muestra la página de nueva reserva si hay una fila seleccioanda y pasa los valores a las variables necesarias
    Private Sub Btn_NewReservation_Click(sender As Object, e As EventArgs) Handles Btn_NewReservation.Click
        If DataGridView1.SelectedRows.Count = 1 AndAlso roomState = "Disponible" Then
            If DateTimePicker1.Value.Date = DateTimePicker2.Value.Date Or DateTimePicker1.Value.Date > DateTimePicker2.Value.Date Then
                MsgBox("Debes seleccionar al menos una noche en la reserva. Modifica las fechas, selecciona una habitacion diponible y prueba de nuevo.")
            Else
                NewReservationPage.startDate = DateTimePicker1.Value.Date
                NewReservationPage.endDate = DateTimePicker2.Value.Date
                NewReservationPage.roomPrice = roomPrice
                NewReservationPage.roomType = roomType
                NewReservationPage.roomNumber = roomNumber
                NewReservationPage.roomId = roomid
                NewReservationPage.ShowDialog()
                ShowAvailableRooms(startDate, endDate)
            End If
        Else
            MsgBox("Debes seleccionar una fila con habitación disponible para poder reservar una habitación.")
        End If

    End Sub
#End Region

#Region "Other controls events region"
    ' Otros eventos de controles

    'Controla que la fila ocupada contenga datos y establece el valor de las variables necesarias cuando se pulse cualquier boton
    Private Sub DataGridView1_SelectionChanged(sender As Object, e As EventArgs) Handles DataGridView1.SelectionChanged
        Try
            If DataGridView1.SelectedRows.Count > 0 Then
                Dim selectedRow As DataGridViewRow = DataGridView1.SelectedRows(0)
                roomPrice = Convert.ToDouble(selectedRow.Cells("precio").Value)
                roomNumber = Convert.ToInt32(selectedRow.Cells("numero_habitacion").Value)
                roomType = selectedRow.Cells("tipo").Value.ToString()
                roomState = selectedRow.Cells("estado").Value.ToString()
                roomid = Convert.ToInt32(selectedRow.Cells("id_habitacion").Value)
                If selectedRow IsNot Nothing AndAlso roomState = "Ocupada" Then
                    reservationID = Convert.ToInt32(selectedRow.Cells("id_reserva").Value)
                    SeeReservationForm.reservationId = reservationID
                    SeeReservationForm.roomId = roomid
                End If
            End If
        Catch ex As Exception
            MessageBox.Show("Seleccione una fila con datos.")
        End Try

    End Sub

    'Funcion que pinta las celdas dependiendo de su estado
    Private Sub DataGridView1_RowPrePaint(sender As Object, e As DataGridViewRowPrePaintEventArgs) Handles DataGridView1.RowPrePaint
        If e.RowIndex >= 0 AndAlso e.RowIndex < DataGridView1.Rows.Count Then
            Dim cell As DataGridViewCell = DataGridView1.Rows(e.RowIndex).Cells("estado")
            If cell IsNot Nothing AndAlso cell.Value IsNot Nothing Then
                Dim estado As String = cell.Value.ToString()
                If estado = "Ocupada" Then
                    DataGridView1.Rows(e.RowIndex).DefaultCellStyle.BackColor = Color.OrangeRed
                ElseIf estado = "Disponible" Then
                    DataGridView1.Rows(e.RowIndex).DefaultCellStyle.BackColor = Color.LightGreen
                End If
            End If
        End If
    End Sub

    'Maneja la actualización del grid cuando se cambia la fecha de fin
    Private Sub DateTimePicker2_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker2.ValueChanged
        startDate = DateTimePicker1.Value.Date
        endDate = DateTimePicker2.Value.Date
        ShowAvailableRooms(startDate, endDate)
    End Sub
#End Region

#Region "Main subs and functions region"
    ' Funciones y subprocedimientos principales

    'Muestra las habitaciones y cambia el estado a ocupada en caso de tener una reserva en las fechas seleccionadas
    Public Sub ShowAvailableRooms(startDate As Date, endDate As Date)
        Dim query As String = "
                                SELECT h.numero_habitacion, 
                               h.tipo,
                               r.fecha_inicio,
                               r.fecha_fin,
                               h.precio,
                               h.id_habitacion,
                               r.id_reserva, 
                               CASE
                                   WHEN r.id_reserva IS NULL THEN 'Disponible'
                                   ELSE 'Ocupada'
                               END AS estado
                            FROM Habitacion h
                            LEFT JOIN Reserva r ON h.id_habitacion = r.id_habitacion 
                                        AND ((@startDate BETWEEN r.fecha_inicio AND r.fecha_fin)
                                        OR (@endDate BETWEEN r.fecha_inicio AND r.fecha_fin)
                                        OR (r.fecha_inicio BETWEEN @startDate AND @endDate)
                                        OR (r.fecha_fin BETWEEN @startDate AND @endDate))


    "

        Using connection As New MySqlConnection(connectionString)
            Dim adapter As New MySqlDataAdapter(query, connection)
            adapter.SelectCommand.Parameters.AddWithValue("@startDate", startDate)
            adapter.SelectCommand.Parameters.AddWithValue("@endDate", endDate)
            Dim dataTable As New DataTable()
            adapter.Fill(dataTable)
            DataGridView1.DataSource = dataTable
        End Using

        DataGridView1.Refresh()
    End Sub
#End Region
End Class