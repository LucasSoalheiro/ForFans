Public Class Content
    Inherits FormBase
    Private ContentId As String
    Private UserId As String

    Public Sub New(contentId As String, userId As String)
        InitializeComponent()
        Me.ContentId = contentId
        Me.UserId = userId
    End Sub
    Private Sub Content_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class