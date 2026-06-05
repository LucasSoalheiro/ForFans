Imports System.IO


Public Class Home
    Inherits FormBase
    Dim Username As String
    Dim Useremail As String

    Private id As String

    Public Sub New(id As String)
        InitializeComponent()
        Me.id = id
    End Sub

    Private Async Sub Home_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Await LoadContent()
        Dim sidebar As New SideBar()
        Dim User = Await ReadAsync("Users", $"id = '{id}'")
        Username = User("name").ToString()
        Useremail = User("email").ToString()
        Me.sidebar.AccountName = Username
        Me.sidebar.UserId = id
        Me.sidebar.ActualForm = Me

    End Sub

    Private Async Function LoadContent() As Task
        FContainer.SuspendLayout()
        Dim Contents = Await QueryAsync("SELECT c.id AS contentId, u.id AS creatorId, u.name AS creatorName,u.profilePicture AS accountImage, c.title, c.thumbnailUrl, c.description FROM Content c JOIN Users u ON c.creatorId = u.id;")
        For Each row As DataRow In Contents.Rows
            Dim contentCard As New Card(row("contentId").ToString(), Me, id, row("creatorId").ToString())
            contentCard.TitleContent.Text = row("title").ToString()
            contentCard.CreatorNamelbl.Text = row("creatorName").ToString()
            Dim accountImageUrl As String = row("accountImage").ToString()

            Dim accountImagePath = Path.Combine(
                Application.StartupPath,
                accountImageUrl.Replace("/", "\")
            )

            Using img As Image = Image.FromFile(accountImagePath)
                contentCard.AccountPicture.Image = New Bitmap(img)
            End Using

            Dim thumbnailUrl As String = row("thumbnailUrl").ToString()

            Dim fullPath = Path.Combine(
            Application.StartupPath,
            thumbnailUrl.Replace("/", "\")
            )
            Using img As Image = Image.FromFile(fullPath)
                contentCard.ThumbnailImage.Image = New Bitmap(img)
            End Using
            FContainer.Controls.Add(contentCard)
        Next
        FContainer.ResumeLayout()
    End Function

End Class
