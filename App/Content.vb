Imports MySql.Data.MySqlClient

Public Class Content
    Inherits FormBase
    Private ContentId As String

    Public Sub New(contentId As String)
        InitializeComponent()
        Me.ContentId = contentId
    End Sub

    Private Async Sub Content_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.sidebar.AccountName = SessionManager.UserName
        'Me.sidebar.ActualForm = Me

        Dim params As New List(Of MySqlParameter) From {
            New MySqlParameter("@id", ContentId)
        }

        Dim contents = Await ReadAsync("Content", "id = @id", params)
        If contents IsNot Nothing Then
            ContentPlayer.URL = contents("fileUrl").ToString()
        End If
    End Sub
End Class
