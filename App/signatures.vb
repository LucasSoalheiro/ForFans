Public Class signatures
    Inherits FormBase

    Private id As String

    Public Sub New(id As String)
        InitializeComponent()
        Me.id = id
    End Sub
    Private Sub config_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.sidebar.UserId = id
        Me.sidebar.ActualForm = Me
    End Sub

End Class