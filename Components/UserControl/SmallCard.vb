Public Class SmallCard

    Private Title As String
    Private ActualForm As Form
    Private ContentId As String
    Private UserId As String
    Public Sub New(title As String, actualForm As Form, contentId As String, userId As String)
        InitializeComponent()
        Me.Title = title
        Me.ActualForm = actualForm
        Me.ContentId = contentId
        Me.UserId = userId
    End Sub

    Private Sub SmallCard_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Thumbnail_Click(sender As Object, e As EventArgs) Handles Thumbnail.Click
        Dim Content = New Content(ContentId, UserId)
        ActualForm.Hide()
        Content.Show()
    End Sub

    Private Sub ContentTitle_Click(sender As Object, e As EventArgs) Handles ContentTitle.Click
        Dim Content = New Content(ContentId, UserId)
        ActualForm.Hide()
        Content.Show()
    End Sub
End Class
