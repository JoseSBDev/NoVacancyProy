Imports MySqlConnector

Public Class MaintenancePage
    Dim server = "localhost"
    Dim user = "root"
    Dim pwd = "root"
    Dim database = "hotel"
    Dim connectionString = "server=" & server & ";user=" & user & ";password=" & pwd & ";database=" & database

    Dim incidentDate As Date
    Dim maintenanceDate As Date
    Dim roomNumber As Integer
    Dim incidentState As String
    Dim description As String
    Dim incidentId As Integer

#Region "onLoad region"
    Private Sub MaintenancePage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CB_State.Items.Add("Completada")
        CB_State.Items.Add("En espera")
        CB_State.Items.Add("En progreso")
        ShowMaintenanceIncidents()
    End Sub
#End Region

#Region "Button events region"
    ' Eventos de clic en botones

    'Llama a la función UpdateMaintenanceRegistry
    Private Sub Btn_EditMaintenance_Click(sender As Object, e As EventArgs) Handles Btn_EditMaintenance.Click
        If TxtBox_Description.Text IsNot Nothing Then
            UpdateMaintenanceRegistry()
        End If
    End Sub
#End Region

#Region "Other controls events region"
    ' Otros eventos de controles

    'Maneja la variable incidentState cuando se cambia en el combobox
    Private Sub CB_State_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CB_State.SelectedIndexChanged
        incidentState = CB_State.SelectedItem
    End Sub

    'Rellena los txtbox de la incidencia seleccionada
    Private Sub DataGridView1_SelectionChanged(sender As Object, e As EventArgs) Handles DataGridView1.SelectionChanged
        Try
            If DataGridView1.SelectedRows.Count > 0 Then
                Dim selectedRow As DataGridViewRow = DataGridView1.SelectedRows(0)
                roomNumber = Convert.ToInt32(selectedRow.Cells("numero_habitacion").Value)
                incidentDate = selectedRow.Cells("fecha").Value.ToString()
                incidentState = selectedRow.Cells("estado").Value.ToString()
                description = selectedRow.Cells("descripcion").Value.ToString()
                incidentId = Convert.ToInt32(selectedRow.Cells("id_mantenimiento").Value)
                If selectedRow IsNot Nothing Then
                    TxtBox_Date.Text = incidentDate
                    TxtBox_Description.Text = description
                    TxtBox_Room.Text = roomNumber
                    SelectComboBox()
                End If
            End If
        Catch ex As Exception
            MessageBox.Show("Seleccione una fila con datos.")
        End Try

    End Sub
    'Function que cambia el color de la fila dependiendo de su estado
    Private Sub DataGridView1_RowPrePaint(sender As Object, e As DataGridViewRowPrePaintEventArgs) Handles DataGridView1.RowPrePaint
        If e.RowIndex >= 0 AndAlso e.RowIndex < DataGridView1.Rows.Count Then
            Dim cell As DataGridViewCell = DataGridView1.Rows(e.RowIndex).Cells("estado")
            If cell IsNot Nothing AndAlso cell.Value IsNot Nothing Then
                Dim estado As String = cell.Value.ToString()
                If estado = "Completada" Then
                    DataGridView1.Rows(e.RowIndex).DefaultCellStyle.BackColor = Color.LightGreen
                ElseIf estado = "En progreso" Then
                    DataGridView1.Rows(e.RowIndex).DefaultCellStyle.BackColor = Color.LightSalmon
                ElseIf estado = "En espera" Then
                    DataGridView1.Rows(e.RowIndex).DefaultCellStyle.BackColor = Color.LightYellow
                End If
            End If
        End If
    End Sub
#End Region

#Region "Main subs and functions region"
    ' Funciones y subprocedimientos principales

    'Funcion que rellena el grid con las incidencias de mantenimiento
    Private Sub ShowMaintenanceIncidents()
        Dim query As String = "SELECT 
                                h.numero_habitacion, 
                                m.fecha,
                                m.estado,
                                m.descripcion,
                                m.id_mantenimiento
                               FROM Mantenimiento m
                               LEFT JOIN Habitacion h ON h.id_habitacion = m.id_habitacion"

        Using connection As New MySqlConnection(connectionString)
            Dim adapter As New MySqlDataAdapter(query, connection)
            Dim dataTable As New DataTable()
            adapter.Fill(dataTable)

            If dataTable.Rows.Count > 0 Then
                DataGridView1.DataSource = dataTable
                DataGridView1.Columns("descripcion").Width = 340
                DataGridView1.Columns("id_mantenimiento").Visible = False
                'FillTextBox()
            Else
                MessageBox.Show("No se encontraron reservas para el ID especificado.")
            End If
        End Using
    End Sub

    'Cambia la selección del combobox dependiendo del estado de la incidencia
    Private Sub SelectComboBox()
        Select Case incidentState
            Case "Completada"
                CB_State.SelectedIndex = 0
            Case "En espera"
                CB_State.SelectedIndex = 1
            Case "En progreso"
                CB_State.SelectedIndex = 2
        End Select
    End Sub

    'Actauliza la bbdd ed mantenimiento
    Private Sub UpdateMaintenanceRegistry()
        Dim result As DialogResult = MessageBox.Show("¿Está seguro de que desea editar esta incidencia?", "Confirmar edición", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
        If result = DialogResult.OK Then
            maintenanceDate = DateTimePicker1.Value
            description = TxtBox_Description.Text
            Dim query As String = " UPDATE Mantenimiento
                                    SET fecha = @maintenanceDate, descripcion = @description, estado = @incidentState
                                    WHERE id_mantenimiento = @id_mantenimiento
                                    "
            Using connection As New MySqlConnection(connectionString)
                Using command As New MySqlCommand(query, connection)
                    command.Parameters.AddWithValue("@maintenanceDate", maintenanceDate.ToString("yyyy-MM-dd"))
                    command.Parameters.AddWithValue("@description", description)
                    command.Parameters.AddWithValue("@incidentState", incidentState)
                    command.Parameters.AddWithValue("@id_mantenimiento", incidentId)

                    Try
                        connection.Open()
                        command.ExecuteNonQuery()
                        MsgBox("Registro editado con éxito.")
                    Catch ex As Exception
                        MessageBox.Show("Error al editar el mantenimiento: " & ex.Message)
                    End Try
                End Using
            End Using
            Me.Close()
        End If
    End Sub

#End Region
End Class