Imports MySql.Data.MySqlClient

Public Class Content
    Inherits FormBase
    Private ContentId As String

    Public Sub New(contentId As String)
        InitializeComponent()
        Me.ContentId = contentId
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Close()
    End Sub

    Private Async Sub btnLike_Click(sender As Object, e As EventArgs) Handles btnLike.Click
        Try
            Dim params As New List(Of MySqlParameter) From {
                New MySqlParameter("@userId", SessionManager.UserId),
                New MySqlParameter("@contentId", ContentId)
            }

            ' Check if already liked
            Dim dt = Await QueryAsync("SELECT * FROM LikeContent WHERE userId = @userId AND contentId = @contentId", params)
            
            If dt.Rows.Count > 0 Then
                ' Unlike
                Await DeleteRecordAsync("LikeContent", "userId = @userId AND contentId = @contentId", params)
                btnLike.StateCommon.Content.ShortText.Color1 = Color.FromArgb(4, 41, 84)
                btnLike.Values.Text = "❤ Like"
            Else
                ' Like
                Dim data As New Dictionary(Of String, Object) From {
                    {"userId", SessionManager.UserId},
                    {"contentId", ContentId}
                }
                Await CreateAsync("LikeContent", data)
                btnLike.StateCommon.Content.ShortText.Color1 = Color.Red
                btnLike.Values.Text = "❤ Liked"
            End If
        Catch ex As Exception
            MsgBox("Erro ao processar like: " & ex.Message)
        End Try
    End Sub

    Private Async Function CheckLikeStatus() As Task
        Dim params As New List(Of MySqlParameter) From {
            New MySqlParameter("@userId", SessionManager.UserId),
            New MySqlParameter("@contentId", ContentId)
        }
        Dim dt = Await QueryAsync("SELECT * FROM LikeContent WHERE userId = @userId AND contentId = @contentId", params)
        If dt.Rows.Count > 0 Then
            btnLike.StateCommon.Content.ShortText.Color1 = Color.Red
            btnLike.Values.Text = "❤ Liked"
        End If
    End Function

    Private Async Sub Content_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.sidebar.AccountName = SessionManager.UserName
        
        Await CheckLikeStatus()

        Dim params As New List(Of MySqlParameter) From {
            New MySqlParameter("@id", ContentId)
        }

        Dim contents = Await ReadAsync("Content", "id = @id", params)
        If contents IsNot Nothing Then
            lblTitle.Values.Text = contents("title").ToString()
            lblDescription.Values.Text = contents("description").ToString()
            
            ContentPlayer.uiMode = "mini"
            ContentPlayer.URL = contents("fileUrl").ToString()
            ContentPlayer.Ctlcontrols.play()
        End If
    End Sub
End Class
