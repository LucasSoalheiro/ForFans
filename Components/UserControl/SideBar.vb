
Public Class SideBar
    Public Event ToggleSideBar()

    Public UserId As String
    Public ActualForm As Form

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
        Me.BackColor = Color.FromArgb(29, 161, 242)
    End Sub

    Private Sub LabelCreatorArea_Click(sender As Object, e As EventArgs) Handles LabelCreatorArea.Click
        Dim creatorArea As New CreatorArea(UserId)
        creatorArea.Show()
        ActualForm.Hide()
    End Sub

    Private Sub ButtonCreatorArea_Click(sender As Object, e As EventArgs) Handles ButtonCreatorArea.Click
        Dim creatorArea As New CreatorArea(UserId)
        creatorArea.Show()
        ActualForm.Hide()
    End Sub

    Private Sub KryptonLabel1_Click(sender As Object, e As EventArgs) Handles KryptonLabel1.Click
        Dim home As New Home(UserId)
        home.Show()
        ActualForm.Hide()
    End Sub

    Private Sub KryptonButton3_Click(sender As Object, e As EventArgs) Handles KryptonButton3.Click
        Dim screenconfig As New config(UserId)
        screenconfig.Show()
        ActualForm.Hide()
    End Sub

    Private Sub KryptonButton2_Click(sender As Object, e As EventArgs) Handles KryptonButton2.Click
        Dim Assignaturearea As New signatures(UserId)
        Assignaturearea.Show()
        ActualForm.Hide()
    End Sub

    Private Sub KryptonLabel4_Click(sender As Object, e As EventArgs) Handles KryptonLabel4.Click
        Dim Assignaturearea As New signatures(UserId)
        Assignaturearea.Show()
        ActualForm.Hide()
    End Sub

    Private Sub AccountLbl_Click(sender As Object, e As EventArgs) Handles AccountLbl.Click
        Dim config As New config(UserId)
        config.Show()
        ActualForm.Hide()
    End Sub

    Private Sub KryptonButton1_Click(sender As Object, e As EventArgs) Handles KryptonButton1.Click
        Dim login As New Login()
        login.Show()
        ActualForm.Hide()
    End Sub

    Private Sub KryptonLabel2_Click(sender As Object, e As EventArgs) Handles KryptonLabel2.Click
        Dim login As New Login()
        login.Show()
        ActualForm.Hide()
    End Sub

    Private Sub KryptonButton4_Click(sender As Object, e As EventArgs) Handles KryptonButton4.Click

    End Sub

    Private Sub ManageContents_Click(sender As Object, e As EventArgs) Handles ManageContents.Click

    End Sub
End Class

