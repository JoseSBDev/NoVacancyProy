Imports MySqlConnector

Public Class LoginPage
    Public loggedIn = False
    Public role As String = ""
    Private Sub LoginPage_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub SendLogin()
        Dim connectionString As String = "server=localhost;user id=root;password=root;database=hotel"
        Dim username As String = txtUsername.Text
        Dim password As String = txtPassword.Text

        Using connection As New MySqlConnection(connectionString)
            Dim query As String = "SELECT COUNT(*) FROM usuario WHERE nombre = @Username AND contrasena = @Password"
            Dim command As New MySqlCommand(query, connection)
            command.Parameters.AddWithValue("@Username", username)
            command.Parameters.AddWithValue("@Password", password)

            Try
                connection.Open()
                Dim count As Integer = Convert.ToInt32(command.ExecuteScalar())

                If count > 0 Then
                    ' Si el inicio de sesión es exitoso, obtenemos el rol del usuario
                    Dim roleQuery As String = "SELECT id_rol FROM usuario WHERE nombre = @Username"
                    Dim roleCommand As New MySqlCommand(roleQuery, connection)
                    roleCommand.Parameters.AddWithValue("@Username", username)
                    role = roleCommand.ExecuteScalar().ToString()

                    MessageBox.Show("Inicio de sesión exitoso" & role)
                    loggedIn = True

                    Select Case role
                        Case "1"
                            role = "Administrador"
                        Case "2"
                            role = "Gerencia"
                        Case "3"
                            role = "Recepcion"
                        Case "4"
                            role = "Limpieza"
                        Case "5"
                            role = "Mantenimiento"
                    End Select

                    Me.Close()
                Else
                    MessageBox.Show("Nombre de usuario o contraseña incorrectos")
                End If
            Catch ex As Exception
                MessageBox.Show("Error al intentar conectar a la base de datos: " & ex.Message)
            End Try
        End Using
    End Sub
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles Btn_Login.Click
        SendLogin()
    End Sub

    Private Sub Btn_Salir_Click(sender As Object, e As EventArgs) Handles Btn_Salir.Click
        MainPage.Close()
    End Sub

    Private Sub txtPassword_KeyDown(sender As Object, e As KeyEventArgs) Handles txtPassword.KeyDown
        If e.KeyCode = Keys.Enter Then
            SendLogin()
        End If
    End Sub
End Class