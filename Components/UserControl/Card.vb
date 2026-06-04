Public Class Card

    Public ContentId As String
    Public UserId As String
    Public ActualForm As Form
    Public creatorId As String

    Public Sub New(contentId As String, actualForm As Form, userId As String, creatorId As String)
        InitializeComponent()
        Me.ContentId = contentId
        Me.ActualForm = actualForm
        Me.UserId = userId
        Me.creatorId = creatorId
    End Sub
    Public Sub LoadData(contentId As String, CreatorName As String, title As String, accountImage As Image)
        CreatorNamelbl.Text = CreatorName
        TitleContent.Text = title
    End Sub

    Private Sub ThumbnailImage_Click(sender As Object, e As EventArgs) Handles ThumbnailImage.Click
        Dim content As New Content(ContentId, UserId)
        ActualForm.Hide()
        content.Show()
    End Sub

    Private Sub TitleContent_Click(sender As Object, e As EventArgs) Handles TitleContent.Click
        Dim creatorPage As New CreatorPage(creatorId, UserId)
        creatorPage.Show()
        ActualForm.Hide()
    End Sub

    Private Sub CreatorNamelbl_Click(sender As Object, e As EventArgs) Handles CreatorNamelbl.Click
        Dim creatorPage As New CreatorPage(creatorId, UserId)
        creatorPage.Show()
        ActualForm.Hide()
    End Sub

    Private Sub AccountPicture_Click(sender As Object, e As EventArgs) Handles AccountPicture.Click
        Dim creatorPage As New CreatorPage(creatorId, UserId)
        creatorPage.Show()
        ActualForm.Hide()
    End Sub
End Class
