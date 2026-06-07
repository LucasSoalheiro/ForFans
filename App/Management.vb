Imports System.IO
Imports System.Collections.Generic
Imports MySql.Data.MySqlClient

Public Class Management
    Inherits FormBase

    Public Sub New()
        InitializeComponent()
    End Sub

    Private Async Sub Management_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.sidebar.AccountName = SessionManager.UserName
        'Me.sidebar.ActualForm = Me

        Await LoadMyContent()
    End Sub

    Private Async Function LoadMyContent() As Task
        FLContents.Controls.Clear()
        FLContents.SuspendLayout()

        Dim params As New List(Of MySqlParameter) From {
            New MySqlParameter("@creatorId", SessionManager.UserId)
        }

        Dim userContent = Await ReadAllAsync("Content", "creatorId = @creatorId", params)

        If userContent.Rows.Count = 0 Then
            Dim lblNoContent As New Krypton.Toolkit.KryptonLabel()
            lblNoContent.Text = "Você ainda não publicou nenhum conteúdo."
            lblNoContent.StateCommon.ShortText.Font = New Font("Segoe UI", 12F, FontStyle.Italic)
            lblNoContent.StateCommon.ShortText.Color1 = Color.Gray
            lblNoContent.Margin = New Padding(0, 50, 0, 0)
            FLContents.Controls.Add(lblNoContent)
        End If

        For Each row As DataRow In userContent.Rows
            Dim contentCard As New ContentCard(row("id").ToString(), row("title").ToString(), row("description").ToString(), row("active"))
            contentCard.Width = FLContents.Width - FLContents.Padding.Horizontal - 50
            
            Dim thumbnailUrl As String = row("thumbnailUrl").ToString()
            If Not String.IsNullOrEmpty(thumbnailUrl) Then
                ImageHelper.SetImage(contentCard.ThumbnailPic, Path.Combine(Application.StartupPath, thumbnailUrl))
            End If

            FLContents.Controls.Add(contentCard)
        Next
        FLContents.ResumeLayout()
    End Function
End Class
