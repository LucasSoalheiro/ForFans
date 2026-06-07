Imports MySql.Data.MySqlClient

Public Class Login
    Inherits SmallForm
    Private Async Sub LoginBtn_Click(sender As Object, e As EventArgs) Handles LoginBtn.Click
        Dim email As String = LoginEmail.Text.Trim()
        Dim password As String = LoginPassword.Text
        If email.ToLower() = "admin" AndAlso password = "coxinha123" Then
            SessionManager.UserId = 999999 ' ID fictício para Admin
            SessionManager.UserName = "System Admin"
            SessionManager.UserRole = "admin"

            MsgBox("Admin login successful!")
            Dim mainForm As New Home()
            mainForm.Show()
            Me.Hide()
            Return
        End If
        If String.IsNullOrWhiteSpace(email) OrElse String.IsNullOrWhiteSpace(password) Then
            MsgBox("Please fill in all fields.")
            Return
        End If

        If Not Validator.IsValidEmail(email) Then
            MsgBox("Please enter a valid email address.")
            Return
        End If

        LoginBtn.Enabled = False
        Try
            ' Login especial para Admin


            Dim params As New List(Of MySqlParameter) From {
                New MySqlParameter("@email", email)
            }

            Dim user = Await ReadAsync("Users", "email = @email", params)
            If user("active") = False Then
                MsgBox("Your account is deactivated.")
                Return
            End If
            If user IsNot Nothing AndAlso PasswordHasher.VerifyPassword(password, user("passwordHash").ToString()) Then
                ' Inicializa a sessão
                SessionManager.UserId = Convert.ToInt32(user("id"))
                SessionManager.UserName = user("name").ToString()
                SessionManager.UserRole = user("role").ToString()

                MsgBox($"Welcome back, {SessionManager.UserName}!")

                Dim mainForm As New Home()
                mainForm.Show()
                Me.Hide()
            Else
                MsgBox("Invalid email or password.")
            End If
        Catch ex As Exception
            MsgBox("An error occurred during login. Please try again later.")
        Finally
            If Me.Visible Then LoginBtn.Enabled = True
        End Try
    End Sub

    Private Sub CreateAccountLink_LinkClicked(sender As Object, e As EventArgs) Handles CreateAccountLink.LinkClicked
        Dim registerForm As New Register()
        registerForm.Show()
        Me.Hide()
    End Sub

End Class
