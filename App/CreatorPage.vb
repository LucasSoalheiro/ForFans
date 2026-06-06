Imports System.IO
Imports MySql.Data.MySqlClient

Public Class CreatorPage
    Inherits FormBase
    Private CreatorId As String
    Private Subscribed As Boolean

    Public Sub New(creatorId As String)
        InitializeComponent()
        Me.CreatorId = creatorId
    End Sub

    Private Async Sub CreatorPage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.sidebar.AccountName = SessionManager.UserName
        'Me.sidebar.ActualForm = Me

        Await LoadCreatorInfo()
        Await LoadContent()
    End Sub

    Private Async Function LoadCreatorInfo() As Task
        Dim params As New List(Of MySqlParameter) From {
            New MySqlParameter("@userId", SessionManager.UserId),
            New MySqlParameter("@creatorId", CreatorId)
        }

        ' Verifica se já é inscrito
        Dim alreadySubscribed = Await QueryAsync("SELECT * FROM Subscription WHERE subscriberId = @userId AND creatorId = @creatorId", params)

        Subscribed = alreadySubscribed.Rows.Count > 0
        SubscribeBtn.Text = If(Subscribed, "Unsubscribe", "Subscribe")

        ' Busca informações do criador
        Dim creatorSql = "SELECT u.id, u.name, u.profilePicture, u.bio, COUNT(s.id) AS subscribers " &
                         "FROM Users u LEFT JOIN Subscription s ON u.id = s.creatorId " &
                         "WHERE u.id = @creatorId " &
                         "GROUP BY u.id, u.name, u.profilePicture, u.bio"

        Dim creatorData = Await QueryAsync(creatorSql, New List(Of MySqlParameter) From {New MySqlParameter("@creatorId", CreatorId)})

        If creatorData.Rows.Count > 0 Then
            Dim row = creatorData.Rows(0)
            Me.CreatorName.Text = row("name").ToString()
            Me.SubscribersNumber.Text = $"{row("subscribers")} subscribers"
            Me.CreatorBio.Text = row("bio").ToString()

            Dim accountImageUrl As String = row("profilePicture").ToString()
            If Not String.IsNullOrEmpty(accountImageUrl) Then
                ImageHelper.SetImage(Me.CreatorPicture, Path.Combine(Application.StartupPath, accountImageUrl))
            End If
        End If
    End Function

    Private Async Sub SubscribeBtn_Click(sender As Object, e As EventArgs) Handles SubscribeBtn.Click
        Dim params As New List(Of MySqlParameter) From {
            New MySqlParameter("@userId", SessionManager.UserId),
            New MySqlParameter("@creatorId", CreatorId)
        }

        If Subscribed Then
            Await DeleteRecordAsync("Subscription", "subscriberId = @userId AND creatorId = @creatorId", params)
        Else
            Await CreateAsync("Subscription", New Dictionary(Of String, Object) From {
                {"subscriberId", SessionManager.UserId},
                {"creatorId", CreatorId}
            })
        End If

        Await LoadCreatorInfo()
    End Sub

    Private Async Function LoadContent() As Task
        FPCreatorsContent.SuspendLayout()

        Dim params As New List(Of MySqlParameter) From {
            New MySqlParameter("@creatorId", CreatorId)
        }

        Dim contents = Await ReadAllAsync("Content", "creatorId = @creatorId", params)

        For Each row As DataRow In contents.Rows
            Dim contentCard As New SmallCard(row("title").ToString(), Me, row("id").ToString(), SessionManager.UserId.ToString())
            contentCard.ContentTitle.Text = row("title").ToString()

            Dim thumbnailUrl As String = row("thumbnailUrl").ToString()
            If Not String.IsNullOrEmpty(thumbnailUrl) Then
                ImageHelper.SetImage(contentCard.Thumbnail, Path.Combine(Application.StartupPath, thumbnailUrl))
            End If

            FPCreatorsContent.Controls.Add(contentCard)
        Next
        FPCreatorsContent.ResumeLayout()
    End Function
End Class
