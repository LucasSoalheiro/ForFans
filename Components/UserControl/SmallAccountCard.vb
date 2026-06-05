Public Class SmallAccountCard

    Public CreatorId As String
    Public CreatorName As String
    Public UserId As String
    Public ActualForm As Form


    Public Sub New(creatorId As String, creatorName As String, userId As String, actualForm As Form)

        ' Esta chamada é requerida pelo designer.
        InitializeComponent()
        Me.CreatorId = creatorId
        Me.CreatorName = creatorName
        Me.UserId = userId
        Me.ActualForm = actualForm
        ' Adicione qualquer inicialização após a chamada InitializeComponent().

    End Sub

    Private Sub SmallAccountCard_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Async Sub DeactiveSubBtn_Click(sender As Object, e As EventArgs) Handles DeactiveSubBtn.Click
        Await DeleteRecordAsync("Subscription", $"subscriberId = {UserId} AND creatorId = {CreatorId}")
        DeactiveSubBtn.Text = "Inscrever-se"
    End Sub

    Private Sub AccountName_Click(sender As Object, e As EventArgs) Handles AccountName.Click
        Dim creatorPage As New CreatorPage(CreatorId, UserId)
        ActualForm.Hide()
        creatorPage.Show()
    End Sub

    Private Sub AccountPicProfile_Click(sender As Object, e As EventArgs) Handles AccountPicProfile.Click
        Dim creatorPage As New CreatorPage(CreatorId, UserId)
        ActualForm.Hide()
        creatorPage.Show()
    End Sub
End Class
