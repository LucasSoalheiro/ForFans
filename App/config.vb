Imports System.IO
Imports MySql.Data.MySqlClient

Public Class config
    Inherits FormBase

    Private _fileUrl As String = String.Empty

    Public Sub New()
        InitializeComponent()
    End Sub

    Private Async Sub config_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.sidebar.AccountName = SessionManager.UserName
        'Me.sidebar.ActualForm = Me

        ' Estilo circular para a foto
        Dim contorno As New System.Drawing.Drawing2D.GraphicsPath()
        contorno.AddEllipse(0, 0, PictureProfile.Width, PictureProfile.Height)
        PictureProfile.Region = New Region(contorno)

        Dim params As New List(Of MySqlParameter) From {
            New MySqlParameter("@id", SessionManager.UserId)
        }
        
        Dim user = Await ReadAsync("Users", "id = @id", params)
        If user Is Nothing Then Return

        NameUser.Text = user("name").ToString()
        Useremail.Text = user("email").ToString()
        newName.Text = user("name").ToString()
        NewUseremail.Text = user("email").ToString()

        If user.Table.Columns.Contains("bio") AndAlso Not IsDBNull(user("bio")) Then
            NewBios.Text = user("bio").ToString()
        End If

        If user.Table.Columns.Contains("profilePicture") AndAlso Not IsDBNull(user("profilePicture")) AndAlso
           Not String.IsNullOrEmpty(user("profilePicture").ToString()) Then
            _fileUrl = user("profilePicture").ToString()
            ImageHelper.SetImage(PictureProfile, Path.Combine(Application.StartupPath, _fileUrl))
        End If
    End Sub

    Private Sub ChangeImage_Click(sender As Object, e As EventArgs) Handles ChangeImage.Click
        Using ofd As New OpenFileDialog()
            ofd.Filter = "Imagens (*.jpg;*.jpeg;*.png;*.gif)|*.jpg;*.jpeg;*.png;*.gif"
            ofd.Title = "Selecione uma imagem de perfil"

            If ofd.ShowDialog() <> DialogResult.OK Then Return

            ' Limite de 2MB para foto de perfil
            If Not Validator.IsFileSizeValid(ofd.FileName, 2 * 1024 * 1024) Then
                MessageBox.Show("A imagem de perfil deve ter no máximo 2MB.", "Arquivo muito grande", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            Dim savedPath = SaveAvatarLocally(ofd.FileName)
            if String.IsNullOrEmpty(savedPath) Then
                MessageBox.Show("Não foi possível salvar a imagem.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            _fileUrl = savedPath
            ImageHelper.SetImage(PictureProfile, Path.Combine(Application.StartupPath, _fileUrl))
        End Using
    End Sub

    Private Function SaveAvatarLocally(sourcePath As String) As String
        Try
            Dim avatarsFolder = Path.Combine(Application.StartupPath, "profilePicture")
            If Not Directory.Exists(avatarsFolder) Then Directory.CreateDirectory(avatarsFolder)

            Dim ext = Path.GetExtension(sourcePath).ToLower()
            Dim destFileName = $"{SessionManager.UserId}_{Guid.NewGuid()}{ext}" ' Guid para evitar conflito
            Dim destPath = Path.Combine(avatarsFolder, destFileName)

            File.Copy(sourcePath, destPath, overwrite:=True)
            Return Path.Combine("profilePicture", destFileName)
        Catch ex As Exception
            MessageBox.Show($"Erro ao salvar imagem: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return String.Empty
        End Try
    End Function

    Private Async Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
        Dim name As String = newName.Text.Trim()
        Dim email As String = NewUseremail.Text.Trim()
        Dim bio As String = NewBios.Text.Trim()

        If String.IsNullOrWhiteSpace(name) Then
            MessageBox.Show("O nome não pode ficar vazio.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        If String.IsNullOrWhiteSpace(email) Then
            MessageBox.Show("O e-mail não pode ficar vazio.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        If Not Validator.IsValidEmail(email) Then
            MessageBox.Show("Por favor, insira um e-mail válido.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        BtnSave.Enabled = False
        BtnSave.Values.Text = "Salvando..."

        Try
            ' Verifica se o e-mail já existe para outro usuário
            Dim emailParams As New List(Of MySqlParameter) From {
                New MySqlParameter("@email", email),
                New MySqlParameter("@id", SessionManager.UserId)
            }
            Dim existingUser = Await ReadAsync("Users", "email = @email AND id <> @id", emailParams)
            
            If existingUser IsNot Nothing Then
                MessageBox.Show("Este e-mail já está sendo usado por outra conta.", "Conflito de E-mail", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            Dim updates As New Dictionary(Of String, Object) From {
                {"name", name},
                {"email", email},
                {"bio", bio}
            }

            If Not String.IsNullOrEmpty(_fileUrl) Then
                updates("profilePicture") = _fileUrl
            End If

            Dim whereParams As New List(Of MySqlParameter) From {
                New MySqlParameter("@id", SessionManager.UserId)
            }

            Await UpdateAsync("Users", updates, "id = @id", whereParams)

            ' Atualiza a sessão se o nome mudou
            SessionManager.UserName = name
            Me.sidebar.AccountName = SessionManager.UserName
            NameUser.Text = name
            Useremail.Text = email

            MessageBox.Show("Perfil atualizado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show("Ocorreu um erro ao salvar as alterações. Tente novamente.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            BtnSave.Enabled = True
            BtnSave.Values.Text = "Salvar alterações"
        End Try
    End Sub

    Private Sub PictureProfile_Paint(sender As Object, e As PaintEventArgs) Handles PictureProfile.Paint
        e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias
        Using caneta As New Pen(Color.FromArgb(0, 102, 204), 2)
            e.Graphics.DrawEllipse(caneta, 1, 1, PictureProfile.Width - 3, PictureProfile.Height - 3)
        End Using
    End Sub
End Class
