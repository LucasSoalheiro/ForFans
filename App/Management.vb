Imports System.IO
Public Class Management
    Inherits FormBase
    Private UserId As String


    Public Sub New(UserId As String)

        ' Esta chamada é requerida pelo designer.
        InitializeComponent()
        Me.UserId = UserId
        ' Adicione qualquer inicialização após a chamada InitializeComponent().

    End Sub
    Private Async Sub Management_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.sidebar.UserId = UserId
        Me.sidebar.ActualForm = Me
        Dim UserContent = Await ReadAllAsync("Content", $"creatorId={UserId}")
        FLContents.SuspendLayout()
        For Each row As DataRow In UserContent.Rows
            Dim contentCard As New ContentCard(row("id").ToString(), row("title").ToString(), row("description").ToString())
            Dim accountImageUrl As String = row("thumbnailUrl").ToString()

            Dim accountImagePath = Path.Combine(
                Application.StartupPath,
                accountImageUrl.Replace("/", "\")
            )
            If row("active") = False Then
                contentCard.DeleteBtn.Text = "Deactivate"
                contentCard.DeleteBtn.Enabled = False
            Else
                contentCard.DeleteBtn.Text = "Activate"
                contentCard.DeleteBtn.Enabled = True
            End If
            Using img As Image = Image.FromFile(accountImagePath)
                contentCard.ThumbnailPic.Image = New Bitmap(img)
            End Using

            FLContents.Controls.Add(contentCard)
        Next
        FLContents.ResumeLayout()
    End Sub
End Class