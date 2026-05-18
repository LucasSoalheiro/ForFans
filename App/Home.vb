Public Class Home
    Inherits FormBase

    Private Async Sub Home_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Await GetConnectionAsync()

    End Sub
End Class
