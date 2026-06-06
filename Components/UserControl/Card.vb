Imports MySql.Data.MySqlClient
Public Class Card

    Public ContentId As String
    Public ActualForm As Form
    Public CreatorId As String

    Public Sub New(contentId As String, actualForm As Form, userId_ignored As String, creatorId As String)
        InitializeComponent()
        Me.ContentId = contentId
        Me.ActualForm = actualForm
        Me.CreatorId = creatorId
    End Sub

    Private Sub NavigateTo(newForm As Form)
        newForm.Show()
        If ActualForm IsNot Nothing Then ActualForm.Close()
    End Sub

    Private Async Function CanAccessContent() As Task(Of Boolean)
        ' Admin e o próprio criador sempre acessam
        If SessionManager.UserRole = "admin" OrElse SessionManager.UserId.ToString() = CreatorId Then
            Return True
        End If

        ' Verifica assinatura ativa
        Dim params As New List(Of MySqlParameter) From {
            New MySqlParameter("@userId", SessionManager.UserId),
            New MySqlParameter("@creatorId", CreatorId)
        }
        Dim subResult = Await QueryAsync("SELECT id FROM Subscription WHERE subscriberId = @userId AND creatorId = @creatorId", params)

        Return subResult.Rows.Count > 0
    End Function

    Private Async Sub ThumbnailImage_Click(sender As Object, e As EventArgs) Handles ThumbnailImage.Click
        If Await CanAccessContent() Then
            NavigateTo(New Content(ContentId))
        Else
            MessageBox.Show("Este conteúdo é exclusivo para inscritos. Inscreva-se no perfil do criador para acessar!", "Acesso Restrito", MessageBoxButtons.OK, MessageBoxIcon.Information)
            NavigateTo(New CreatorPage(CreatorId))
        End If
    End Sub

    Private Sub TitleContent_Click(sender As Object, e As EventArgs) Handles TitleContent.Click
        NavigateTo(New CreatorPage(CreatorId))
    End Sub

    Private Sub CreatorNamelbl_Click(sender As Object, e As EventArgs) Handles CreatorNamelbl.Click
        NavigateTo(New CreatorPage(CreatorId))
    End Sub

    Private Sub AccountPicture_Click(sender As Object, e As EventArgs) Handles AccountPicture.Click
        NavigateTo(New CreatorPage(CreatorId))
    End Sub
End Class
