Imports System.IO
Public Class CreatorPage
    Inherits FormBase
    Private CreatorId As String
    Public UserId As String


    Public Sub New(creatorId As String, userId As String)
        InitializeComponent()
        Me.CreatorId = creatorId
        Me.UserId = userId

    End Sub

    Private Async Sub CreatorPage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim alreadySubscribed As DataTable = Await QueryAsync($"SELECT * FROM Subscription WHERE subscriberId = '{UserId}' AND creatorId = '{CreatorId}' AND status = 'active'")
        If alreadySubscribed.Rows.Count > 0 Then
            SubscribeBtn.Text = "Subscribed"
            SubscribeBtn.Enabled = False
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
    AND s.status = 'active'
WHERE u.id = {CreatorId}
GROUP BY
    u.id,
    u.name,
    u.profilePicture,
    u.bio;")
        Dim Contents = Await ReadAsync("Content", $"creatorId = {CreatorId}")
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
    End Sub

    Private Async Sub SubscribeBtn_Click(sender As Object, e As EventArgs) Handles SubscribeBtn.Click
        'Await CreateAsync("")
    End Sub
End Class