Imports MySql.Data.MySqlClient
Imports Krypton.Toolkit

Public Class UserEditDialog
    Private _userId As Integer

    Public Sub New(userId As Integer)
        ' Esta chamada é exigida pelo designer.
        InitializeComponent()

        ' Adicione qualquer inicialização após a chamada InitializeComponent().
        _userId = userId
    End Sub

    Private Async Sub UserEditDialog_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim params As New List(Of MySqlParameter) From {
                New MySqlParameter("@id", _userId)
            }
            Dim user = Await ReadAsync("Users", "id = @id", params)
            If user IsNot Nothing Then
                txtName.Text = user("name").ToString()
                txtEmail.Text = user("email").ToString()
                
                ' Seleciona a role no ComboBox
                Dim role = user("role").ToString()
                If cmbRole.Items.Contains(role) Then
                    cmbRole.SelectedItem = role
                Else
                    cmbRole.SelectedIndex = 0
                End If
            Else
                MsgBox("Usuário não encontrado.", MsgBoxStyle.Exclamation)
                Me.Close()
            End If
        Catch ex As Exception
            MsgBox($"Erro ao carregar dados: {ex.Message}", MsgBoxStyle.Critical)
            Me.Close()
        End Try
    End Sub

    Private Async Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim name = txtName.Text.Trim()
        Dim email = txtEmail.Text.Trim()
        Dim role = cmbRole.Text

        If String.IsNullOrEmpty(name) OrElse String.IsNullOrEmpty(email) Then
            MsgBox("Preencha todos os campos obrigatórios.", MsgBoxStyle.Exclamation)
            Return
        End If

        ' Validação básica de email
        If Not email.Contains("@") OrElse Not email.Contains(".") Then
            MsgBox("Insira um email válido.", MsgBoxStyle.Exclamation)
            Return
        End If

        Try
            Dim data As New Dictionary(Of String, Object) From {
                {"name", name},
                {"email", email},
                {"role", role}
            }
            Dim params As New List(Of MySqlParameter) From {
                New MySqlParameter("@id", _userId)
            }
            
            Await UpdateAsync("Users", data, "id = @id", params)
            
            MsgBox("Usuário atualizado com sucesso!", MsgBoxStyle.Information)
            Me.DialogResult = DialogResult.OK
            Me.Close()
        Catch ex As Exception
            MsgBox($"Erro ao salvar alterações: {ex.Message}", MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.DialogResult = DialogResult.Cancel
        Me.Close()
    End Sub
End Class
