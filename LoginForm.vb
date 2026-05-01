Public Class LoginForm
    Dim email, senha As String
    Private Sub LoginForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Email_txt_TextChanged(sender As Object, e As EventArgs) Handles Email_txt.TextChanged
        email = Email_txt.Text
    End Sub

    Private Sub Senha_txt_TextChanged(sender As Object, e As EventArgs) Handles Senha_txt.TextChanged
        senha = Senha_txt.Text
    End Sub

    Private Sub Login_btn_Click(sender As Object, e As EventArgs) Handles Login_btn.Click
        ' Here we will do the connection with the database and check if the email and password are correct
        MsgBox("Login realizado com sucesso!")
    End Sub
End Class