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

#Region "onLoad region"
    Private Sub RoomsPage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            FillComboBoxRoomType()
            ComboBoxRoomStat.Items.AddRange({"Todas", "Disponible", "Ocupada"})

            ' Por defecto, muestra todas las habitaciones
            ComboBoxRoomStat.SelectedIndex = 0
            ComboBoxRoomType.SelectedIndex = 0

            UpdateRoomList()
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub
#End Region

#Region "Button events region"
    ' Eventos de clic en botones

    'Llama a UpdateDatabase
    Private Sub Btn_UpdateRooms_Click(sender As Object, e As EventArgs) Handles Btn_UpdateRooms.Click
        UpdateDatabase()
    End Sub
#End Region

#Region "Other controls events region"
    ' Otros eventos de controles

    ' Actualiza la lista de habitaciones al cambiar la opción en los ComboBox
    Private Sub ComboBoxRoomType_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxRoomType.SelectedIndexChanged, ComboBoxRoomStat.SelectedIndexChanged
        UpdateRoomList()
    End Sub

    ' Actualiza la lista de habitaciones al cambiar el texto en el TextBox
    Private Sub TextBoxRoomNumber_TextChanged(sender As Object, e As EventArgs) Handles TextBoxRoomNumber.TextChanged
        UpdateRoomList()
    End Sub
#End Region

#Region "Main subs and functions region"
    ' Funciones y subprocedimientos principales

    'Rellena el combobox de tipo de habitación
    Private Sub FillComboBoxRoomType()
        Try
            Dim sqlQuery As String = "SELECT DISTINCT tipo FROM habitacion"
            Dim cmd As New MySqlCommand(sqlQuery, cn)
            cn.Open()

            Dim reader As MySqlDataReader = cmd.ExecuteReader()
            ComboBoxRoomType.Items.Clear()
            ComboBoxRoomType.Items.Add("Todas")

            While reader.Read()
                ComboBoxRoomType.Items.Add(reader("tipo").ToString())
            End While

            reader.Close()
        Catch ex As Exception
            MessageBox.Show("Error al llenar el ComboBox de tipos de habitación: " & ex.Message)
        Finally
            cn.Close()
        End Try
    End Sub

    'Updatea la lista de las habitaciones según los valores selecionados en los combobox o el textbox
    Private Sub UpdateRoomList()
        Try
            Dim sqlQuery As String = "SELECT * FROM habitacion WHERE 1 = 1"

            If ComboBoxRoomType.SelectedIndex > 0 Then
                sqlQuery &= " AND tipo = '" & ComboBoxRoomType.SelectedItem.ToString() & "'"
            ElseIf ComboBoxRoomType.SelectedIndex = 0 Then
                sqlQuery &= " AND tipo = tipo "
            End If

            If ComboBoxRoomStat.SelectedIndex = 1 Then
                sqlQuery &= " AND estado = 'Disponible'"
            ElseIf ComboBoxRoomStat.SelectedIndex = 2 Then
                sqlQuery &= " AND estado = 'Ocupada'"
            End If

            If Not String.IsNullOrEmpty(TextBoxRoomNumber.Text) Then
                sqlQuery &= " AND numero_habitacion = " & TextBoxRoomNumber.Text
            End If

            dataAdapterRooms = New MySqlDataAdapter(sqlQuery, cn)
            dataSet = New DataSet

            cn.Open()
            dataAdapterRooms.Fill(dataSet, "habitacion")

            DataGridViewRooms.DataSource = dataSet.Tables("habitacion")
            DataGridViewRooms.Columns("estado").Visible = True
        Catch ex As Exception
            MessageBox.Show("Error al actualizar la lista de habitaciones: " & ex.Message)
        Finally
            cn.Close()
        End Try
    End Sub

    'Actualiza la bbdd con los datos editados
    Private Sub UpdateDatabase()
        Try
            cn.Open()

            For Each row As DataRow In dataSet.Tables("Habitacion").Rows
                If row.RowState = DataRowState.Modified Then
                    Dim updateCommand As New MySqlCommand("UPDATE Habitacion SET numero_habitacion = @numero_habitacion, tipo = @tipo, estado = @estado, precio = @precio WHERE id_habitacion = @id_habitacion", cn)
                    updateCommand.Parameters.AddWithValue("@numero_habitacion", row("numero_habitacion"))
                    updateCommand.Parameters.AddWithValue("@tipo", row("tipo"))
                    updateCommand.Parameters.AddWithValue("@estado", row("estado"))
                    updateCommand.Parameters.AddWithValue("@precio", row("precio"))
                    updateCommand.Parameters.AddWithValue("@id_habitacion", row("id_habitacion"))
                    updateCommand.ExecuteNonQuery()
                End If
            Next

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

#End Region
End Class
