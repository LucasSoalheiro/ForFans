Imports MySql.Data.MySqlClient

Public Class SmallAccountCard

    Public CreatorId As String
    Public CreatorName As String
    Public ActualForm As Form

    Public Sub New(creatorId As String, creatorName As String, userId_ignored As String, actualForm As Form)
        InitializeComponent()
        Me.CreatorId = creatorId
        Me.CreatorName = creatorName
        Me.ActualForm = actualForm
    End Sub

    Private Sub NavigateTo(newForm As Form)
        newForm.Show()
        If ActualForm IsNot Nothing Then ActualForm.Close()
    End Sub

    Private Async Sub DeactiveSubBtn_Click(sender As Object, e As EventArgs) Handles DeactiveSubBtn.Click
        Dim params As New List(Of MySqlParameter) From {
            New MySqlParameter("@userId", SessionManager.UserId),
            New MySqlParameter("@creatorId", CreatorId)
        }
        Await DeleteRecordAsync("Subscription", "subscriberId = @userId AND creatorId = @creatorId", params)
        DeactiveSubBtn.Text = "Unsubscribed"
        DeactiveSubBtn.Enabled = False
    End Sub

    Private Sub AccountName_Click(sender As Object, e As EventArgs) Handles AccountName.Click
        NavigateTo(New CreatorPage(CreatorId))
    End Sub

    Private Sub AccountPicProfile_Click(sender As Object, e As EventArgs) Handles AccountPicProfile.Click
        NavigateTo(New CreatorPage(CreatorId))
    End Sub
End Class
