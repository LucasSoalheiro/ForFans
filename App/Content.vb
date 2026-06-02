Public Class Content
    Inherits FormBase
    Private ContentId As String
    Private UserId As String

    Public Sub New(contentId As String, userId As String)
        InitializeComponent()
        Me.ContentId = contentId
        Me.UserId = userId

    End Sub
    Private Async Sub Content_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.sidebar.ActualForm = Me
        Dim contents = Await ReadAsync("Content", $"id = {ContentId}")

        ContentPlayer.URL = contents("fileUrl").ToString()
    End Sub
End Class