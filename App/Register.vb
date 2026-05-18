
Public Class Register
    Inherits SmallForm

    Private Async Sub RegiterBtn_Click(sender As Object, e As EventArgs) Handles RegiterBtn.Click
        Dim data As New Dictionary(Of String, Object) From {
            {"name", UserName.Text},
            {"email", UserEmail.Text},
            {"passwordHash", PasswordHasher.HashPassword(UserPassword.Text)}
        }

        Await CreateAsync("Users", data)
    End Sub


End Class