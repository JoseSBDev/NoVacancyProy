Imports Microsoft.Reporting.WinForms
Imports MySqlConnector

Public Class InvoiceReportPage
    Dim server = "localhost"
    Dim user = "root"
    Dim pwd = "root"
    Dim database = "hotel"
    Dim connectionString = "server=" & server & ";user=" & user & ";password=" & pwd & ";database=" & database
    Dim reservationId = SeeReservationForm.reservationId

    Private Sub InvoiceReportPage_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        GenerateProductReport()
        'GenerateReservationReport()
        'Me.ReportViewer1.RefreshReport()
    End Sub

    Public Sub GenerateProductReport()
        'Dim query As String = " SELECT p.nombre as nombre, pr.cantidad as cantidad, p.precio as precio
        '                        FROM Producto p
        '                        LEFT JOIN ProductosDeLaReserva pr ON p.id_producto = pr.id_producto
        '                        WHERE pr.id_reserva = @reservation_id" 
        Dim query As String = "SELECT 
                                    c.nombre AS nombre, 
                                    c.telefono AS telefono, 
                                    c.email AS email, 
                                    p.nombre AS producto, 
                                    p.precio AS precio, 
                                    pr.cantidad AS cantidad, 
                                    pr.cantidad * p.precio as preciototalproducto,
                                    r.precio_reserva, 
                                    h.precio AS precio_noche,
                                    f.id_factura as numero_factura,
                                    f.fecha_emision as fecha_factura,
                                    r.fecha_fin - r.fecha_inicio as dias,
                                    h.precio * (r.fecha_fin - r.fecha_inicio) as precio_total_habitacion
                                FROM 
                                    reserva r
                                JOIN 
                                    cliente c ON r.id_cliente = c.id_cliente
                                join 
	                                productosdelareserva pr on pr.id_reserva = r.id_reserva
                                JOIN 
                                    producto p ON pr.id_producto = p.id_producto
                                JOIN 
                                    habitacion h ON r.id_habitacion = h.id_habitacion
                                JOIN 
	                                factura f on f.id_reserva = r.id_reserva
                                WHERE 
                                    r.id_reserva = 1"
        Dim startDate As New Date
        Dim endDate As New Date
        Dim precio As Integer
        Try
            Using connection As New MySqlConnection(connectionString)
                Dim adapter As New MySqlDataAdapter(query, connection)
                Dim dataTable As New DataTable()

                'adapter.SelectCommand.Parameters.AddWithValue("@reservation_id", reservationId)
                adapter.Fill(dataTable)

                ReportViewer1.LocalReport.DataSources.Clear()
                Dim reportDataTable As New ReportDataSource("asd", dataTable)
                ReportViewer1.LocalReport.DataSources.Add(reportDataTable)
                ReportViewer1.RefreshReport()
            End Using
        Catch ex As Exception

        End Try

    End Sub

    Public Sub GenerateReservationReport()
        Dim query As String = "SELECT r.fecha_inicio, r.fecha_fin, h.precio
                               FROM Reserva r
                               LEFT JOIN Habitacion h ON r.id_habitacion = h.id_habitacion
                               WHERE r.id_reserva = @reservation_id"

        Try
            Using connection As New MySqlConnection(connectionString)
                Dim adapter As New MySqlDataAdapter(query, connection)
                adapter.SelectCommand.Parameters.AddWithValue("@reservation_id", reservationId)

                Dim dataTable As New DataTable()
                adapter.Fill(dataTable)

                ReportViewer1.LocalReport.DataSources.Clear()
                Dim reportDataTable As New ReportDataSource("dsInvoice", dataTable)
                ReportViewer1.LocalReport.DataSources.Add(reportDataTable)
                ReportViewer1.RefreshReport()
            End Using
        Catch ex As Exception
            MessageBox.Show("Error al generar el informe: " & ex.Message)
        End Try
    End Sub

End Class