Imports System.IO
Imports MySql.Data.MySqlClient

Public Class Management
    Inherits FormBase

    Public Sub New()
        InitializeComponent()
    End Sub

    Private Async Sub Management_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.sidebar.AccountName = SessionManager.UserName
        'Me.sidebar.ActualForm = Me

        Dim params As New List(Of MySqlParameter) From {
            New MySqlParameter("@creatorId", SessionManager.UserId)
        }

        Dim userContent = Await ReadAllAsync("Content", "creatorId = @creatorId", params)

        FLContents.SuspendLayout()
        For Each row As DataRow In userContent.Rows
            Dim contentCard As New ContentCard(row("id").ToString(), row("title").ToString(), row("description").ToString(), row("active"))

            Dim thumbnailUrl As String = row("thumbnailUrl").ToString()
            If Not String.IsNullOrEmpty(thumbnailUrl) Then
                ImageHelper.SetImage(contentCard.ThumbnailPic, Path.Combine(Application.StartupPath, thumbnailUrl))
            End If

            FLContents.Controls.Add(contentCard)
        Next
        FLContents.ResumeLayout()
    End Sub
End Class
