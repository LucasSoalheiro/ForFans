Imports System.Text.RegularExpressions

Public Class Form1
    Dim nome, email, senha, confirmacaoSenha, cpf, telefone, dataNasc As String
    Dim conteudoSenha As String

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Nome_txt_TextChanged(sender As Object, e As EventArgs) Handles Nome_txt.TextChanged
        nome = Nome_txt.Text
    End Sub

    Private Sub Nome_txt_LostFocus(sender As Object, e As EventArgs) Handles Nome_txt.LostFocus
        If String.IsNullOrEmpty(Nome_txt.Text) Then
            MsgBox("O campo nome é obrigatório.")
            Nome_txt.Focus()
        End If
    End Sub

    Private Sub Email_txt_TextChanged(sender As Object, e As EventArgs) Handles Email_txt.TextChanged
        email = Email_txt.Text
    End Sub

    Private Sub Email_txt_LostFocus(sender As Object, e As EventArgs) Handles Email_txt.LostFocus
        If Not Email_txt.Text.Contains("@") Then
            MsgBox("Email Inválido")
            Email_txt.Text = ""
            Email_txt.Focus()
        End If
    End Sub

    Private Sub Senha_txt_TextChanged(sender As Object, e As EventArgs) Handles Senha_txt.TextChanged
        senha = Senha_txt.Text
    End Sub

    Private Sub Senha_txt_LostFocus(sender As Object, e As EventArgs) Handles Senha_txt.LostFocus
        If Not IsPasswordValid(Senha_txt.Text) Then
            MsgBox("Senha inválida. A senha deve conter no mínimo 8 caracteres, incluindo pelo menos uma letra maiúscula, uma letra minúscula, um número e um caractere especial.")
            Senha_txt.Focus()
        End If
    End Sub

    Private Function IsPasswordValid(ByVal password As String) As Boolean
        ' Criteria: Min 8 characters, at least 1 Uppercase, 1 Lowercase, 1 Number, and 1 Special Character
        Dim pattern As String = "^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[^\da-zA-Z]).{8,}$"
        Return Regex.IsMatch(password, pattern)
    End Function


    Private Sub ConfirmacaoSenha_txt_TextChanged(sender As Object, e As EventArgs) Handles ConfirmacaoSenha_txt.TextChanged
        confirmacaoSenha = ConfirmacaoSenha_txt.Text
    End Sub

    Private Sub ConfirmacaoSenha_txt_LostFocus(sender As Object, e As EventArgs) Handles ConfirmacaoSenha_txt.LostFocus
        If confirmacaoSenha <> senha Then
            MsgBox("As senhas não coincidem. Por favor, digite novamente.")
            ConfirmacaoSenha_txt.Text = ""
            ConfirmacaoSenha_txt.Focus()
        End If
    End Sub

    Private Sub Cpf_txt_TextChanged(sender As Object, e As EventArgs) Handles Cpf_txt.TextChanged
        If Cpf_txt.Text.Length = 3 Then
            Cpf_txt.Text += "."
            Cpf_txt.SelectionStart = Cpf_txt.Text.Length

        End If
        If Cpf_txt.Text.Length = 7 Then
            Cpf_txt.Text += "."
            Cpf_txt.SelectionStart = Cpf_txt.Text.Length

        End If
        If Cpf_txt.Text.Length = 11 Then
            Cpf_txt.Text += "-"
            Cpf_txt.SelectionStart = Cpf_txt.Text.Length

        End If
        If Cpf_txt.Text.Length < 15 Then
            cpf = Cpf_txt.Text
        End If
    End Sub

    Private Sub Cpf_txt_LostFocus(sender As Object, e As EventArgs) Handles Cpf_txt.LostFocus
        Cpf_txt.Text = cpf
    End Sub

    Private Sub Telefone_txt_TextChanged(sender As Object, e As EventArgs) Handles Telefone_txt.TextChanged
        '(00) 00000-0000

        If Telefone_txt.Text.Length = 3 Then
            Telefone_txt.Text += ") "
            Telefone_txt.SelectionStart = Telefone_txt.Text.Length
        End If
        If Telefone_txt.Text.Length = 10 Then
            Telefone_txt.Text += "-"
            Telefone_txt.SelectionStart = Telefone_txt.Text.Length
        End If
        If Telefone_txt.Text.Length < 15 Then
            telefone = Telefone_txt.Text
        End If
    End Sub

    Private Sub Telefone_txt_LostFocus(sender As Object, e As EventArgs) Handles Telefone_txt.LostFocus
        Telefone_txt.Text = telefone
    End Sub

    Private Sub Telefone_txt_Focus(sender As Object, e As EventArgs) Handles Telefone_txt.GotFocus
        If String.IsNullOrEmpty(Telefone_txt.Text) Then
            Telefone_txt.Text = "("
            Telefone_txt.SelectionStart = Telefone_txt.Text.Length
        End If
    End Sub

    Private Sub DataNasc_txt_TextChanged(sender As Object, e As EventArgs) Handles DataNasc_txt.TextChanged
        '00/00/0000

        If DataNasc_txt.Text.Length = 2 Then
            DataNasc_txt.Text += "/"
            DataNasc_txt.SelectionStart = DataNasc_txt.Text.Length
        End If
        If DataNasc_txt.Text.Length = 5 Then
            DataNasc_txt.Text += "/"
            DataNasc_txt.SelectionStart = DataNasc_txt.Text.Length
        End If
        dataNasc = DataNasc_txt.Text
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MsgBox("Dados do usuario: " + nome + " " + email + " " + senha + " " + confirmacaoSenha + " " + cpf + " " + telefone + " " + dataNasc)
    End Sub

End Class
