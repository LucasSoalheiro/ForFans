Imports System.IO
Public Class signatures
    Inherits FormBase

    Private id As String

    Public Sub New(id As String)
        InitializeComponent()
        Me.id = id
    End Sub
    Private Async Sub config_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.sidebar.UserId = id
        Me.sidebar.ActualForm = Me

        Dim Subscriptions = Await QueryAsync($"SELECT
    s.id AS subscriptionId,
    s.createdAt,
    u.id AS creatorId,
    u.name AS creatorName,
  u.profilePicture as creatorProfilePic
FROM Subscription s
INNER JOIN Users u
    ON s.creatorId = u.id
WHERE s.subscriberId = {id}")

        SignaturesLayout.SuspendLayout()
        For Each Subscription As DataRow In Subscriptions.Rows
            Dim creatorCard = New SmallAccountCard(Subscription("creatorId").ToString(), Subscription("creatorName").ToString(), id, Me)
            creatorCard.AccountName.Text = Subscription("creatorName").ToString()
            Dim accountImageUrl As String = Subscription("creatorProfilePic").ToString()

            Dim accountImagePath = Path.Combine(
                Application.StartupPath,
                accountImageUrl.Replace("/", "\")
            )

            Using img As Image = Image.FromFile(accountImagePath)
                creatorCard.AccountPicProfile.Image = New Bitmap(img)
            End Using

            SignaturesLayout.Controls.Add(creatorCard)
        Next
        SignaturesLayout.ResumeLayout()
    End Sub



End Class