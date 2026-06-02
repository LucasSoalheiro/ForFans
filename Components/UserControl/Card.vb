Public Class Card

    Public ContentId As String
    Public UserId As String
    Public ActualForm As Form
    Public Sub New(contentId As String, actualForm As Form, userId As String)
        InitializeComponent()
        Me.ContentId = contentId
        Me.ActualForm = actualForm
        Me.UserId = userId
    End Sub
    Public Sub LoadData(contentId As String, CreatorName As String, title As String)

        CreatorNamelbl.Text = CreatorName
        TitleContent.Text = title
    End Sub

    Private Sub ThumbnailImage_Click(sender As Object, e As EventArgs) Handles ThumbnailImage.Click
        Dim content As New Content(ContentId, UserId)
        ActualForm.Hide()
        content.Show()
    End Sub
End Class
