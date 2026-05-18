
Public Class SideBar
    Public Event ToggleSideBar()

    Private Sub SidebarBtn_Click(sender As Object, e As EventArgs) Handles SidebarBtn.Click
        RaiseEvent ToggleSideBar()
    End Sub
End Class

