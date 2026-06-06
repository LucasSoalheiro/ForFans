Public Class SessionManager
    Public Shared Property UserId As Integer
    Public Shared Property UserName As String
    Public Shared Property UserRole As String

    Public Shared ReadOnly Property IsLoggedIn As Boolean
        Get
            Return UserId > 0
        End Get
    End Property

    Public Shared Sub Logout()
        UserId = 0
        UserName = String.Empty
        UserRole = String.Empty
    End Sub
End Class
