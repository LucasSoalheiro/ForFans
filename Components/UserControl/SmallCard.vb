Public Class SmallCard

    Private Title As String
    Private ActualForm As Form
    Public Sub New(title As String, actualForm As Form)
        InitializeComponent()
        Me.Title = title
        Me.ActualForm = actualForm
    End Sub
End Class
