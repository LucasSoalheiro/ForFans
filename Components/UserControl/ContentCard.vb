Public Class ContentCard
    Private ContentId As String
    Private ContentTitleValue As String
    Private ContentDescriptionValue As String
    Private ContentActive As Boolean

    Public Sub New(contentId As String, contentTitle As String, contentDescription As String, contentActive As Boolean)

        ' Esta chamada é requerida pelo designer.
        InitializeComponent()
        Me.ContentId = contentId
        Me.ContentTitleValue = contentTitle
        Me.ContentDescriptionValue = contentDescription
        Me.ContentActive = contentActive
        ' Adicione qualquer inicialização após a chamada InitializeComponent().

    End Sub
    Private Sub EditBtn_Click(sender As Object, e As EventArgs) Handles EditBtn.Click

    End Sub

    Private Async Sub DeleteBtn_Click(sender As Object, e As EventArgs) Handles DeleteBtn.Click
        If ContentActive Then
            Await UpdateAsync("Content", New Dictionary(Of String, Object) From {{"active", False}}, $"id = '{ContentId}'")
        Else
            Await UpdateAsync("Content", New Dictionary(Of String, Object) From {{"active", True}}, $"id = '{ContentId}'")
        End If
        ContentActive = Not ContentActive
        LoadContents()
    End Sub
    Private Sub LoadContents()
        ContentTitle.Text = ContentTitleValue
        ContentDescription.Text = ContentDescriptionValue
        If ContentActive Then
            DeleteBtn.Text = "Deactivate"

        Else
            DeleteBtn.Text = "Activate"

        End If
    End Sub
    Private Sub ContentCard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadContents()
    End Sub
End Class
