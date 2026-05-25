Public Class Login
    Inherits SmallForm
    Private Async Sub LoginBtn_Click(sender As Object, e As EventArgs) Handles LoginBtn.Click
        Dim User = Await ReadAsync("Users", $"email = '{LoginEmail.Text}'")

        If User IsNot Nothing AndAlso PasswordHasher.VerifyPassword(LoginPassword.Text, User("passwordHash").ToString()) Then
            MsgBox("Login successful!")
            Dim mainForm As New Home(User("id").ToString())
            mainForm.Show()
            Me.Hide()
        Else
            MsgBox("Invalid email or password.")
        End If

    End Sub

    Private Sub CreateAccountLink_LinkClicked(sender As Object, e As EventArgs) Handles CreateAccountLink.LinkClicked
        Dim registerForm As New Register()
        registerForm.Show()
        Me.Hide()
    End Sub
End Class