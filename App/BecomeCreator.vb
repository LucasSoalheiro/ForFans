Imports System.Collections.Generic
Imports MySql.Data.MySqlClient

Public Class BecomeCreator
    Inherits FormBase

    Private Sub BtnAddPhoto_Click(sender As Object, e As EventArgs) Handles BtnAddPhoto.Click
        Using ofd As New OpenFileDialog()
            ofd.Filter = "Imagens (*.jpg;*.jpeg;*.png)|*.jpg;*.jpeg;*.png"
            ofd.Title = "Selecione sua foto de perfil"

            If ofd.ShowDialog() = DialogResult.OK Then
                KryptonPictureBox1.Image = Image.FromFile(ofd.FileName)
            End If
        End Using
    End Sub

    Private Sub BtnRemovePhoto_Click(sender As Object, e As EventArgs) Handles BtnRemovePhoto.Click
        If KryptonPictureBox1.Image IsNot Nothing Then
            KryptonPictureBox1.Image.Dispose()
            KryptonPictureBox1.Image = Nothing
        End If
    End Sub

    Private Async Sub KryptonButton1_Click(sender As Object, e As EventArgs) Handles KryptonButton1.Click
        ' Validação
        If String.IsNullOrWhiteSpace(KryptonTextBox1.Text) Then
            MsgBox("Por favor, insira seu nome artístico.", MsgBoxStyle.Exclamation)
            Return
        End If

        If String.IsNullOrWhiteSpace(KryptonTextBox2.Text) Then
            MsgBox("Por favor, insira uma categoria de conteúdo.", MsgBoxStyle.Exclamation)
            Return
        End If

        If KryptonPictureBox1.Image Is Nothing Then
            MsgBox("Por favor, selecione uma foto de perfil.", MsgBoxStyle.Exclamation)
            Return
        End If

        If Not KryptonCheckBox1.Checked Then
            MsgBox("Você precisa aceitar os termos de uso para continuar.", MsgBoxStyle.Exclamation)
            Return
        End If

        KryptonButton1.Enabled = False
        Try
            ' Dados para atualizar
            Dim data As New Dictionary(Of String, Object) From {
                {"name", KryptonTextBox1.Text.Trim()},
                {"bio", KryptonTextBox2.Text.Trim()}, ' Usando o campo bio para categoria/descrição curta por enquanto
                {"role", "creator"}
            }

            ' Filtro pelo ID do usuário logado
            Dim params As New List(Of MySql.Data.MySqlClient.MySqlParameter) From {
                New MySql.Data.MySqlClient.MySqlParameter("@id", SessionManager.UserId)
            }

            ' Atualiza no banco de dados
            Dim rowsAffected = Await Database.UpdateAsync("Users", data, "id = @id", params)

            If rowsAffected > 0 Then
                ' Atualiza a sessão local
                SessionManager.UserRole = "creator"

                MsgBox("Parabéns! Agora você é um criador oficial do ForFans.", MsgBoxStyle.Information)

                ' Navega para a Área do Criador
                Dim creatorAreaForm As New CreatorArea()
                creatorAreaForm.Show()
                Me.Close()
            Else
                MsgBox("Ocorreu um erro ao atualizar seu perfil. Tente novamente.", MsgBoxStyle.Critical)
            End If

        Catch ex As Exception
            MsgBox("Erro ao processar sua solicitação: " & ex.Message, MsgBoxStyle.Critical)
        Finally
            If Me.Visible Then KryptonButton1.Enabled = True
        End Try
    End Sub
End Class