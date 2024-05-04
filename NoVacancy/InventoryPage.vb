Imports MySqlConnector

Public Class InventoryPage
    Dim server = "localhost"
    Dim user = "root"
    Dim pwd = "root"
    Dim database = "hotel"
    Dim connectionString = "server=" & server & ";user=" & user & ";password=" & pwd & ";database=" & database
    Dim productId As Integer
    Dim products As New List(Of String)()
    Dim count As Integer = 0
    Private Sub InventoryPage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FillInventoryDataGridView()
    End Sub
    Private Sub FillInventoryDataGridView()
        Dim query As String = " SELECT p.nombre AS NombreProducto, p.precio AS Precio, i.cantidad AS Cantidad, i.stock_minimo as Stock_minimo, p.id_producto as idProd
                                FROM Inventario i
                                LEFT JOIN Producto p ON i.id_producto = p.id_producto;"

        Using connection As New MySqlConnection(connectionString)
            Dim adapter As New MySqlDataAdapter(query, connection)
            Dim dataTable As New DataTable()
            ListBox_Alerts.Items.Clear()

            Try
                connection.Open()
                adapter.Fill(dataTable)
            Catch ex As Exception
                MessageBox.Show("Error al conectar a la base de datos: " & ex.Message)
                Return
            End Try
            DataGridView1.DataSource = dataTable
            DataGridView1.Columns("idProd").Visible = False
        End Using

        DataGridView1.Refresh()
    End Sub
    Private Sub DataGridView1_RowPrePaint(sender As Object, e As DataGridViewRowPrePaintEventArgs) Handles DataGridView1.RowPrePaint
        If e.RowIndex >= 0 AndAlso e.RowIndex < DataGridView1.Rows.Count Then
            Dim minStock As DataGridViewCell = DataGridView1.Rows(e.RowIndex).Cells("Stock_minimo")
            Dim stock As DataGridViewCell = DataGridView1.Rows(e.RowIndex).Cells("Cantidad")
            Dim productName As DataGridViewCell = DataGridView1.Rows(e.RowIndex).Cells("Nombreproducto")

            If minStock IsNot Nothing AndAlso minStock.Value IsNot Nothing Then
                Dim Stock_minimo As Integer = minStock.Value.ToString()
                Dim cantidad As Integer = stock.Value.ToString()

                If Stock_minimo >= cantidad Then
                    FillAlerts(productName.Value)
                    DataGridView1.Rows(e.RowIndex).DefaultCellStyle.BackColor = Color.LightCoral
                Else
                    DataGridView1.Rows(e.RowIndex).DefaultCellStyle.BackColor = Color.LightGreen
                End If
            End If
        End If
    End Sub

    Private Sub Btn_UpdateStock_Click(sender As Object, e As EventArgs) Handles Btn_UpdateStock.Click
        If TxtBox_Product.Text IsNot Nothing AndAlso TxtBox_Stock.Text IsNot Nothing Then
            Dim query As String = "UPDATE Inventario SET cantidad = @newQuantity WHERE id_producto = @productId"

            Using connection As New MySqlConnection(connectionString)
                Using command As New MySqlCommand(query, connection)
                    command.Parameters.AddWithValue("@newQuantity", TxtBox_Stock.Text)
                    command.Parameters.AddWithValue("@productId", productId)

                    Try
                        connection.Open()
                        Dim rowsAffected As Integer = command.ExecuteNonQuery()
                        If rowsAffected > 0 Then
                            MessageBox.Show("La cantidad del producto se ha actualizado correctamente.")
                        Else
                            MessageBox.Show("No se encontró el producto con el ID especificado.")
                        End If
                        FillInventoryDataGridView()
                        Btn_UpdateStock.Enabled = False
                        TxtBox_Product.Text = ""
                        TxtBox_Stock.Text = ""
                    Catch ex As Exception
                        MessageBox.Show("Error al actualizar la cantidad del producto: " & ex.Message)
                    End Try
                End Using
            End Using
        End If
    End Sub
    Private Sub DataGridView1_SelectionChanged(sender As Object, e As EventArgs) Handles DataGridView1.SelectionChanged
        Try
            If DataGridView1.SelectedRows.Count > 0 Then
                Dim selectedRow As DataGridViewRow = DataGridView1.SelectedRows(0)
                TxtBox_Stock.Text = Convert.ToInt32(selectedRow.Cells("Cantidad").Value)
                TxtBox_Product.Text = selectedRow.Cells("NombreProducto").Value.ToString()
                productId = selectedRow.Cells("idProd").Value.ToString()
                Btn_UpdateStock.Enabled = True
            End If
        Catch ex As Exception
            MessageBox.Show("Seleccione una fila con datos.")
        End Try
    End Sub

    Private Sub FillAlerts(product As String)
        If Not products.Contains(product) Then
            ListBox_Alerts.Items.Add("El producto " & product & " está por debajo del stock mínimo.")
            products.Add(product)
        End If
    End Sub
End Class