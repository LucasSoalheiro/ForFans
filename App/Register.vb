
Public Class Register
    Inherits SmallForm

    Private Async Sub RegiterBtn_Click(sender As Object, e As EventArgs) Handles RegiterBtn.Click
        Dim existingUser = Await ReadAsync("Users", $"email = '{UserEmail.Text}'")
        If existingUser IsNot Nothing Then
            MsgBox("An account with this email already exists.")
            Return
        End If

        Dim data As New Dictionary(Of String, Object) From {
            {"name", UserName.Text},
            {"email", UserEmail.Text},
            {"passwordHash", PasswordHasher.HashPassword(UserPassword.Text)}
        }
        Await CreateAsync("Users", data)
        Dim User = Await ReadAsync("Users", $"email = '{UserEmail.Text}'")
        MsgBox("Welcome to ForFans!")
        Dim mainForm As New Home(User("id").ToString())
        mainForm.Show()
        Me.Hide()
    End Sub

    Private Sub LoginLink_LinkClicked(sender As Object, e As EventArgs) Handles LoginLink.LinkClicked
        Dim loginForm As New Login()
        loginForm.Show()
        Me.Hide()
    End Sub

    Private Sub KryptonLabel7_Click(sender As Object, e As EventArgs) Handles KryptonLabel7.Click

    End Sub
End Class