Imports System.IO
Imports MySql.Data.MySqlClient

Public Class Register
    Inherits SmallForm

    Private _fileUrl As String = ""

    Private Async Sub RegiterBtn_Click(sender As Object, e As EventArgs) Handles RegiterBtn.Click
        Dim name As String = UserName.Text.Trim()
        Dim email As String = UserEmail.Text.Trim()
        Dim password As String = UserPassword.Text

        If String.IsNullOrWhiteSpace(name) OrElse String.IsNullOrWhiteSpace(email) OrElse String.IsNullOrWhiteSpace(password) Then
            MsgBox("Please fill in all required fields.")
            Return
        End If

        If Not Validator.IsValidEmail(email) Then
            MsgBox("Please enter a valid email address.")
            Return
        End If

        If Not Validator.IsStrongPassword(password) Then
            MsgBox("A senha deve conter no mínimo 6 caracteres.")
            Return
        End If

        RegiterBtn.Enabled = False
        Try
            Dim params As New List(Of MySqlParameter) From {
                New MySqlParameter("@email", email)
            }
            Dim existingUser = Await ReadAsync("Users", "email = @email", params)
            If existingUser IsNot Nothing Then
                MsgBox("An account with this email already exists.")
                Return
            End If

            Dim data As New Dictionary(Of String, Object) From {
                {"name", name},
                {"email", email},
                {"passwordHash", PasswordHasher.HashPassword(password)},
                {"profilePicture", If(String.IsNullOrEmpty(_fileUrl), "", _fileUrl.Replace("\", "/"))}
            }

            Dim newId = Await CreateAsync("Users", data)

            ' Inicializa a sessão
            SessionManager.UserId = Convert.ToInt32(newId)
            SessionManager.UserName = name
            SessionManager.UserRole = "subscriber"

            MsgBox("Welcome to ForFans!")
            Dim mainForm As New Home()
            mainForm.Show()
            Me.Close()
        Catch ex As Exception
            MsgBox("An error occurred during registration. Please try again.")
        Finally
            If Me.Visible Then RegiterBtn.Enabled = True
        End Try
    End Sub

    Private Sub LoginLink_LinkClicked(sender As Object, e As EventArgs) Handles LoginLink.LinkClicked
        Dim loginForm As New Login()
        loginForm.Show()
        Me.Close()
    End Sub

    Private Sub PictureBtn_Click(sender As Object, e As EventArgs) Handles PictureBtn.Click
        Using ofd As New OpenFileDialog()
            ofd.Filter = "Imagens (*.jpg;*.jpeg;*.png;*.gif)|*.jpg;*.jpeg;*.png;*.gif|Todos os arquivos|*.*"
            ofd.Title = "Selecione uma imagem de perfil"

            If ofd.ShowDialog() <> DialogResult.OK Then Return

            ' Limite de 2MB para foto de perfil
            If Not Validator.IsFileSizeValid(ofd.FileName, 2 * 1024 * 1024) Then
                MessageBox.Show("A imagem de perfil deve ter no máximo 2MB.", "Arquivo muito grande", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            Dim savedPath = SaveAvatarLocally(ofd.FileName)
            If String.IsNullOrEmpty(savedPath) Then
                MessageBox.Show("Não foi possível salvar a imagem.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            _fileUrl = savedPath
            ImageHelper.SetImage(ProfilePicture, Path.Combine(AppDomain.CurrentDomain.BaseDirectory, _fileUrl))
        End Using
    End Sub

    Private Function SaveAvatarLocally(sourcePath As String) As String
        Try
            Dim baseDir As String = AppDomain.CurrentDomain.BaseDirectory
            Dim destDir As String = Path.Combine(baseDir, "profilePicture")

            If Not Directory.Exists(destDir) Then
                Directory.CreateDirectory(destDir)
            End If

            Dim ext As String = Path.GetExtension(sourcePath)
            Dim fileName As String = $"{Guid.NewGuid()}{ext}"
            Dim destPath As String = Path.Combine(destDir, fileName)

            File.Copy(sourcePath, destPath, overwrite:=True)

            ' Retorna caminho relativo
            Return Path.Combine("profilePicture", fileName)
        Catch ex As Exception
            MessageBox.Show($"Erro ao salvar imagem: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return String.Empty
        End Try
    End Function

    Private Sub KryptonLabel1_Click(sender As Object, e As EventArgs) Handles KryptonLabel1.Click

    End Sub
End Class