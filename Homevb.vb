Public Class Homevb
    Dim cadForm As New CadForm()
    Private Async Sub Homevb_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Await GetConnectionAsync()
    End Sub

    Private Sub Cad_btn_Click(sender As Object, e As EventArgs) Handles Cad_btn.Click
        cadForm.Show()
        Me.Hide()
    End Sub

    Private Sub Login_btn_Click(sender As Object, e As EventArgs) Handles Login_btn.Click
        LoginForm.Show()
        Me.Hide()
    End Sub
End Class