Public Class SmallCard

    Private Title As String
    Private ActualForm As Form
    Private ContentId As String

    Public Sub New(title As String, actualForm As Form, contentId As String, userId_ignored As String)
        InitializeComponent()
        Me.Title = title
        Me.ActualForm = actualForm
        Me.ContentId = contentId
    End Sub

    Private Sub NavigateTo(newForm As Form)
        newForm.Show()
        If ActualForm IsNot Nothing Then ActualForm.Close()
    End Sub

    Private Sub Thumbnail_Click(sender As Object, e As EventArgs) Handles Thumbnail.Click
        NavigateTo(New Content(ContentId))
    End Sub

    Private Sub ContentTitle_Click(sender As Object, e As EventArgs) Handles ContentTitle.Click
        NavigateTo(New Content(ContentId))
    End Sub
End Class
