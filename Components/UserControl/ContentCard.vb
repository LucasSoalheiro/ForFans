Public Class ContentCard
    Private ContentId As String
    Private ContentTitleValue As String
    Private ContentDescriptionValue As String


    Public Sub New(contentId As String, contentTitle As String, contentDescription As String)

        ' Esta chamada é requerida pelo designer.
        InitializeComponent()
        Me.ContentId = contentId
        Me.ContentTitleValue = contentTitle
        Me.ContentDescriptionValue = contentDescription
        ' Adicione qualquer inicialização após a chamada InitializeComponent().

    End Sub
    Private Sub EditBtn_Click(sender As Object, e As EventArgs) Handles EditBtn.Click

    End Sub

    Private Async Sub DeleteBtn_Click(sender As Object, e As EventArgs) Handles DeleteBtn.Click
        Await UpdateAsync("Content", New Dictionary(Of String, Object) From {{"active", False}}, $"id = '{ContentId}'")
    End Sub

    Private Sub ContentCard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ContentTitle.Text = ContentTitleValue
        ContentDescription.Text = ContentDescriptionValue

    End Sub
End Class
