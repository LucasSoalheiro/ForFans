Imports System.IO
Imports System.Collections.Generic
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

        SignaturesLayout.Controls.Clear()
        SignaturesLayout.SuspendLayout()
        
        If subscriptions.Rows.Count = 0 Then
            Dim lblNoSub As New Krypton.Toolkit.KryptonLabel()
            lblNoSub.Text = "Você ainda não possui assinaturas ativas."
            lblNoSub.StateCommon.ShortText.Font = New Font("Segoe UI", 12F, FontStyle.Italic)
            lblNoSub.StateCommon.ShortText.Color1 = Color.Gray
            lblNoSub.Margin = New Padding(0, 50, 0, 0)
            SignaturesLayout.Controls.Add(lblNoSub)
        End If

        For Each subRow As DataRow In subscriptions.Rows
            Dim creatorId = subRow("creatorId").ToString()
            Dim creatorName = subRow("creatorName").ToString()

            Dim creatorCard = New SmallAccountCard(creatorId, creatorName, SessionManager.UserId.ToString(), Me)
            creatorCard.Width = SignaturesLayout.Width - SignaturesLayout.Padding.Horizontal - 50
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
