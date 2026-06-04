Imports System.IO

Public Class Register
    Inherits SmallForm

    Private _fileUrl As String = ""

    Private Async Sub RegiterBtn_Click(sender As Object, e As EventArgs) Handles RegiterBtn.Click
        Dim existingUser = Await ReadAsync("Users", $"email = '{UserEmail.Text}'")
        If existingUser IsNot Nothing Then
            MsgBox("An account with this email already exists.")
            Return
        End If

        Dim data As New Dictionary(Of String, Object) From {
            {"name", UserName.Text},
            {"email", UserEmail.Text},
            {"passwordHash", PasswordHasher.HashPassword(UserPassword.Text)},
            {"profilePicture", If(String.IsNullOrEmpty(_fileUrl), "", _fileUrl)}
        }
        Await CreateAsync("Users", data)
        Dim User = Await ReadAsync("Users", $"email = '{UserEmail.Text}'")
        MsgBox("Welcome to ForFans!")
        Dim mainForm As New Home(User("id").ToString())
        mainForm.Show()
        Me.Hide()
    End Sub

    Private Sub LoginLink_LinkClicked(sender As Object, e As EventArgs) Handles LoginLink.LinkClicked
        Dim loginForm As New Login()
        loginForm.Show()
        Me.Hide()
    End Sub

    Private Sub KryptonLabel7_Click(sender As Object, e As EventArgs) Handles KryptonLabel7.Click

    End Sub

    Private Sub PictureBtn_Click(sender As Object, e As EventArgs) Handles PictureBtn.Click
        Using ofd As New OpenFileDialog()
            ofd.Filter =
                "Imagens (*.jpg;*.jpeg;*.png;*.gif)|*.jpg;*.jpeg;*.png;*.gif|" &
                "Todos os arquivos|*.*"
            ofd.Title = "Selecione uma imagem de perfil"

            If ofd.ShowDialog() <> DialogResult.OK Then Return

            Dim savedPath = SaveAvatarLocally(ofd.FileName)
            If String.IsNullOrEmpty(savedPath) Then
                MessageBox.Show("Não foi possível salvar a imagem.",
                                "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            _fileUrl = savedPath
            LoadProfileImage(_fileUrl)
        End Using
    End Sub

    Private Function SaveAvatarLocally(sourcePath As String) As String
        Try
            ' Pasta profilePicture ao lado do executável (raiz do projeto em dev)
            Dim baseDir As String = AppDomain.CurrentDomain.BaseDirectory
            Dim destDir As String = Path.Combine(baseDir, "profilePicture")

            If Not Directory.Exists(destDir) Then
                Directory.CreateDirectory(destDir)
            End If

            ' Nome único para evitar colisões
            Dim ext As String = Path.GetExtension(sourcePath)
            Dim fileName As String = $"{Guid.NewGuid()}{ext}"
            Dim destPath As String = Path.Combine(destDir, fileName)

            File.Copy(sourcePath, destPath, overwrite:=True)

            ' Retorna caminho relativo para salvar no banco
            Return Path.Combine("profilePicture", fileName)
        Catch ex As Exception
            MessageBox.Show($"Erro ao salvar imagem: {ex.Message}",
                            "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return String.Empty
        End Try
    End Function
    Private Sub LoadProfileImage(filePath As String)
        Try
            If Not File.Exists(filePath) Then Return

            Dim bytes = File.ReadAllBytes(filePath)
            Using ms As New MemoryStream(bytes)
                ProfilePicture.Image = Image.FromStream(ms)
            End Using
            ProfilePicture.SizeMode = PictureBoxSizeMode.Zoom
        Catch ex As Exception

        End Try
    End Sub
End Class