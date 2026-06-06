Imports MySql.Data.MySqlClient

Public Class ContentCard
    Private ContentId As String
    Private ContentTitleValue As String
    Private ContentDescriptionValue As String
    Private ContentActive As Boolean

    Public Sub New(contentId As String, contentTitle As String, contentDescription As String, contentActive As Boolean)
        InitializeComponent()
        Me.ContentId = contentId
        Me.ContentTitleValue = contentTitle
        Me.ContentDescriptionValue = contentDescription
        Me.ContentActive = contentActive
    End Sub

    Private Sub EditBtn_Click(sender As Object, e As EventArgs) Handles EditBtn.Click
        ' TODO: Implementar edição
    End Sub

    Private Async Sub DeleteBtn_Click(sender As Object, e As EventArgs) Handles DeleteBtn.Click
        Dim acao = If(ContentActive, "desativar", "ativar")
        If MessageBox.Show($"Tem certeza que deseja {acao} este conteúdo?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) <> DialogResult.Yes Then
            Return
        End If

        Try
            Dim updates As New Dictionary(Of String, Object) From {
                {"active", Not ContentActive}
            }
            
            Dim params As New List(Of MySqlParameter) From {
                New MySqlParameter("@id", ContentId)
            }
            
            Await UpdateAsync("Content", updates, "id = @id", params)
            
            ContentActive = Not ContentActive
            LoadContents()
        Catch ex As Exception
            MessageBox.Show($"Erro ao atualizar status: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub LoadContents()
        ContentTitle.Text = ContentTitleValue
        ContentDescription.Text = ContentDescriptionValue
        DeleteBtn.Text = If(ContentActive, "Deactivate", "Activate")
    End Sub

    Private Sub ContentCard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadContents()
    End Sub
End Class
