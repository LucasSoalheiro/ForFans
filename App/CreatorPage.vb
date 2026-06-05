Imports System.IO
Imports System.Runtime.InteropServices
Public Class CreatorPage
    Inherits FormBase
    Private CreatorId As String
    Public UserId As String
    Private Subscribed As Boolean

    Public Sub New(creatorId As String, userId As String)
        InitializeComponent()
        Me.CreatorId = creatorId
        Me.UserId = userId

    End Sub
    Private Async Function LoadCreatorInfo() As Task
        Me.sidebar.UserId = UserId
        Me.sidebar.ActualForm = Me
        Dim alreadySubscribed As DataTable = Await QueryAsync($"SELECT * FROM Subscription WHERE subscriberId = '{UserId}' AND creatorId = '{CreatorId}'")
        If alreadySubscribed.Rows.Count > 0 Then
            Subscribed = True
            SubscribeBtn.Text = "Unsubscribe"

        Else
            Subscribed = False
            SubscribeBtn.Text = "Subscribe"
        End If
        Dim Creator = Await QueryAsync($"SELECT
    u.id,
    u.name,
    u.profilePicture,
    u.bio,
    COUNT(s.id) AS subscribers
FROM Users u
LEFT JOIN Subscription s
    ON u.id = s.creatorId
WHERE u.id = {CreatorId}
GROUP BY
    u.id,
    u.name,
    u.profilePicture,
    u.bio;")

        Me.CreatorName.Text = Creator.Rows(0)("name").ToString()
        Me.SubscribersNumber.Text = $"{Creator.Rows(0)("subscribers")} subscribers"
        Me.CreatorBio.Text = Creator.Rows(0)("bio").ToString()
        Dim accountImageUrl As String = Creator.Rows(0)("profilePicture").ToString()
        Dim accountImagePath = Path.Combine(
                Application.StartupPath,
                accountImageUrl.Replace("/", "\")
            )

        Using img As Image = Image.FromFile(accountImagePath)
            Me.CreatorPicture.Image = New Bitmap(img)
        End Using
    End Function
    Private Async Sub CreatorPage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Await LoadCreatorInfo()
        Await LoadContent()
    End Sub


    Private Async Sub SubscribeBtn_Click(sender As Object, e As EventArgs) Handles SubscribeBtn.Click
        If Subscribed Then
            Await DeleteRecordAsync("Subscription", $"subscriberId = '{UserId}' AND creatorId = '{CreatorId}'")
            Subscribed = False
        Else

            Await CreateAsync("Subscription", New Dictionary(Of String, Object) From {
            {"subscriberId", UserId},
            {"creatorId", CreatorId}
        })
            Subscribed = True
        End If

        Await LoadCreatorInfo()
    End Sub

    Private Async Function LoadContent() As Task
        FPCreatorsContent.SuspendLayout()
        Dim Contents = Await ReadAllAsync("Content", $"creatorId = {CreatorId}")
        For Each row As DataRow In Contents.Rows
            Dim contentCard As New SmallCard(row("title").ToString(), Me, row("id").ToString(), UserId)
            contentCard.ContentTitle.Text = row("title").ToString()
            Dim thumbnailUrl As String = row("thumbnailUrl").ToString()
            Dim thumbnailPath = Path.Combine(
                Application.StartupPath,
                thumbnailUrl.Replace("/", "\")
            )

            Using img As Image = Image.FromFile(thumbnailPath)
                contentCard.Thumbnail.Image = New Bitmap(img)
            End Using
            FPCreatorsContent.Controls.Add(contentCard)
        Next
        FPCreatorsContent.ResumeLayout()
    End Function
End Class