
Public Class SideBar
    Public Event ToggleSideBar()

    Public Property AccountName As String
        Get
            Return AccountLbl.Text
        End Get
        Set(value As String)
            AccountLbl.Text = value
        End Set
    End Property

    Private Sub SidebarBtn_Click(sender As Object, e As EventArgs) Handles SidebarBtn.Click
        RaiseEvent ToggleSideBar()
    End Sub

    Private Sub SideBar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    End Sub
End Class

