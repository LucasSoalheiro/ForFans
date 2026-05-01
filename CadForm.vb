Imports System.Text.RegularExpressions

Public Class CadForm
    Dim nome, email, senha, confirmacaoSenha, cpf, telefone, dataNasc As String
    Dim conteudoSenha, cpfFormatado, mensagemErro As String

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Nome_txt_TextChanged(sender As Object, e As EventArgs) Handles Nome_txt.TextChanged
        nome = Nome_txt.Text
    End Sub

    Private Sub Email_txt_TextChanged(sender As Object, e As EventArgs) Handles Email_txt.TextChanged
        email = Email_txt.Text
    End Sub


    Private Function IsEmailValid(ByVal email As String) As Boolean
        ' Basic email validation using regex
        Dim pattern As String = "^[^@\s]+@[^@\s]+\.[^@\s]+$"
        Return Regex.IsMatch(email, pattern)
    End Function

    Private Sub Senha_txt_TextChanged(sender As Object, e As EventArgs) Handles Senha_txt.TextChanged
        conteudoSenha = ""
        If Not Regex.IsMatch(Senha_txt.Text, "^(?=.*[a-z])") Then
            conteudoSenha = "Senha deve conter pelo menos uma letra minúscula." & Environment.NewLine
        End If
        If Not Regex.IsMatch(Senha_txt.Text, "^(?=.*[A-Z])") Then
            conteudoSenha &= "Senha deve conter pelo menos uma letra maiúscula." & Environment.NewLine
        End If
        If Not Regex.IsMatch(Senha_txt.Text, "^(?=.*\d)") Then
            conteudoSenha &= "Senha deve conter pelo menos um número." & Environment.NewLine
        End If
        If Not Regex.IsMatch(Senha_txt.Text, "^(?=.*[^\da-zA-Z])") Then
            conteudoSenha &= "Senha deve conter pelo menos um caractere especial." & Environment.NewLine
        End If
        If Not Regex.IsMatch(Senha_txt.Text, "^.{8,}$") Then
            conteudoSenha &= "Senha deve conter no mínimo 8 caracteres." & Environment.NewLine
        End If
        ConteudoSenha_lbl.Text = conteudoSenha
        senha = Senha_txt.Text
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
        End If
    End Sub

    Private Sub Cpf_txt_TextChanged(sender As Object, e As EventArgs) Handles Cpf_txt.TextChanged
        cpf = Cpf_txt.Text
    End Sub

    Private Function IsCpfValid(ByVal cpf As String) As Boolean
        ' Add validation for CPF Conflict with another CPF in the system
        ' While there isn't a database to check against, we can at least validate the format of the CPF
        cpfFormatado = cpf.Replace(","c, "."c)
        Return Regex.IsMatch(cpfFormatado, "^\d{3}\.\d{3}\.\d{3}-\d{2}$")
    End Function

    Private Sub Telefone_txt_TextChanged(sender As Object, e As EventArgs) Handles Telefone_txt.TextChanged
        telefone = Telefone_txt.Text
    End Sub

    Private Sub DataNasc_txt_TextChanged(sender As Object, e As EventArgs) Handles DataNasc_txt.TextChanged
        dataNasc = DataNasc_txt.Text
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Cad_btn.Click
        If String.IsNullOrEmpty(nome) Then
            mensagemErro = "O campo nome é obrigatório." & Environment.NewLine
        End If
        If Not IsEmailValid(email) Then
            mensagemErro &= "Email Inválido" & Environment.NewLine
            Email_txt.Text = ""
        End If
        If Not IsPasswordValid(senha) Then
            mensagemErro &= "Senha inválida. A senha deve conter no mínimo 8 caracteres, incluindo pelo menos uma letra maiúscula, uma letra minúscula, um número e um caractere especial." & Environment.NewLine
        End If
        If confirmacaoSenha <> senha Then
            mensagemErro &= "As senhas não coincidem. Por favor, digite novamente." & Environment.NewLine
            ConfirmacaoSenha_txt.Text = ""
        End If
        If Not IsCpfValid(cpf) Then
            mensagemErro &= "CPF inválido. O formato deve ser XXX.XXX.XXX-XX" & Environment.NewLine
            Cpf_txt.Text = ""
            Return
        End If
        If String.IsNullOrEmpty(telefone) Or telefone.Length <> 10 Then
            mensagemErro &= "Telefone " & Environment.NewLine
        End If
        If String.IsNullOrEmpty(dataNasc) Or dataNasc.Length <> 10 Then
                mensagemErro &= "Data de Nascimento Inválida" & Environment.NewLine
            End If
        MsgBox("Dados do usuario: " + nome + " " + email + " " + senha + " " + cpfFormatado + " " + telefone + " " + dataNasc)
    End Sub

End Class
