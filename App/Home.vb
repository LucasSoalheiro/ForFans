Imports System.IO
Imports MySql.Data.MySqlClient

Public Class Home
    Inherits FormBase
    Dim Username As String
    Dim Useremail As String

    Public Sub New()
        InitializeComponent()
    End Sub

    Private Async Sub Home_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.sidebar.AccountName = SessionManager.UserName
        Await LoadContent()
    End Sub

    Private Async Function LoadContent() As Task
        FContainer.SuspendLayout()

        Dim params As New List(Of MySqlParameter) From {
            New MySqlParameter("@userId", SessionManager.UserId)
        }

        ' Busca conteúdo de outros criadores
        Dim sql = "SELECT c.id AS contentId, u.id AS creatorId, u.name AS creatorName, u.profilePicture AS accountImage, " &
                  "c.title, c.thumbnailUrl, c.description " &
                  "FROM Content c JOIN Users u ON c.creatorId = u.id " &
                  "WHERE u.id <> @userId AND c.active = True"

        Dim contents = Await QueryAsync(sql, params)

        For Each row As DataRow In contents.Rows
            Dim contentId = row("contentId").ToString()
            Dim creatorId = row("creatorId").ToString()

            Dim contentCard As New Card(contentId, Me, SessionManager.UserId.ToString(), creatorId)
            contentCard.TitleContent.Text = row("title").ToString()
            contentCard.CreatorNamelbl.Text = row("creatorName").ToString()

            ' Carrega foto do criador
            Dim accountImageUrl As String = row("accountImage").ToString()
            If Not String.IsNullOrEmpty(accountImageUrl) Then
                ImageHelper.SetImage(contentCard.AccountPicture, Path.Combine(Application.StartupPath, accountImageUrl))
            End If

            ' Carrega thumbnail do conteúdo
            Dim thumbnailUrl As String = row("thumbnailUrl").ToString()
            If Not String.IsNullOrEmpty(thumbnailUrl) Then
                ImageHelper.SetImage(contentCard.ThumbnailImage, Path.Combine(Application.StartupPath, thumbnailUrl))
            End If

            FContainer.Controls.Add(contentCard)
        Next
        FContainer.ResumeLayout()
    End Function

End Class
