Imports System.IO
Imports MySql.Data.MySqlClient

Public Class signatures
    Inherits FormBase

    Public Sub New()
        InitializeComponent()
    End Sub

    Private Async Sub signatures_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.sidebar.AccountName = SessionManager.UserName
        'Me.sidebar.ActualForm = Me

        Dim params As New List(Of MySqlParameter) From {
            New MySqlParameter("@subscriberId", SessionManager.UserId)
        }

        Dim sql = "SELECT s.id AS subscriptionId, s.createdAt, u.id AS creatorId, u.name AS creatorName, u.profilePicture as creatorProfilePic " &
                  "FROM Subscription s INNER JOIN Users u ON s.creatorId = u.id " &
                  "WHERE s.subscriberId = @subscriberId"

        Dim subscriptions = Await QueryAsync(sql, params)

        SignaturesLayout.SuspendLayout()
        For Each subRow As DataRow In subscriptions.Rows
            Dim creatorId = subRow("creatorId").ToString()
            Dim creatorName = subRow("creatorName").ToString()

            Dim creatorCard = New SmallAccountCard(creatorId, creatorName, SessionManager.UserId.ToString(), Me)
            creatorCard.AccountName.Text = creatorName

            Dim accountImageUrl As String = subRow("creatorProfilePic").ToString()
            If Not String.IsNullOrEmpty(accountImageUrl) Then
                ImageHelper.SetImage(creatorCard.AccountPicProfile, Path.Combine(Application.StartupPath, accountImageUrl))
            End If

            SignaturesLayout.Controls.Add(creatorCard)
        Next
        SignaturesLayout.ResumeLayout()
    End Sub
End Class
