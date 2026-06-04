Imports System.IO

Public Class config
    Inherits FormBase

    Private _id As String
    Private _fileUrl As String = String.Empty

    Private ReadOnly _avatarsFolder As String =
        Path.Combine(Application.StartupPath, "profilePicture")

    Public Sub New(id As String)
        InitializeComponent()
        _id = id
    End Sub


    Private Async Sub config_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.sidebar.UserId = _id
        Me.sidebar.ActualForm = Me


        Dim contorno As New System.Drawing.Drawing2D.GraphicsPath()
        contorno.AddEllipse(0, 0, PictureProfile.Width, PictureProfile.Height)
        PictureProfile.Region = New Region(contorno)


        Dim user = Await ReadAsync("Users", $"id = {_id}")
        If user Is Nothing Then Return
        Me.sidebar.AccountName = user("name").ToString()

        NameUser.Text = user("name").ToString()
        Useremail.Text = user("email").ToString()

        If user.Table.Columns.Contains("bio") AndAlso Not IsDBNull(user("bio")) Then
            NewBios.Text = user("bio").ToString()
        End If

        If user.Table.Columns.Contains("profilePicture") AndAlso Not IsDBNull(user("profilePicture")) AndAlso
           Not String.IsNullOrEmpty(user("profilePicture").ToString()) Then
            _fileUrl = user("profilePicture").ToString()
            LoadProfileImage(_fileUrl)
        End If
    End Sub


    Private Sub LoadProfileImage(filePath As String)
        Try
            If Not File.Exists(filePath) Then Return

            Dim bytes = File.ReadAllBytes(filePath)
            Using ms As New MemoryStream(bytes)
                PictureProfile.Image = Image.FromStream(ms)
            End Using
            PictureProfile.SizeMode = PictureBoxSizeMode.Zoom
        Catch ex As Exception

        End Try
    End Sub

    Private Sub ChangeImage_Click(sender As Object, e As EventArgs) Handles ChangeImage.Click
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
            If Not Directory.Exists(_avatarsFolder) Then
                Directory.CreateDirectory(_avatarsFolder)
            End If

            Dim ext = Path.GetExtension(sourcePath).ToLower()
            Dim destFileName = $"{_id}_avatar{ext}"
            Dim destPath = Path.Combine(_avatarsFolder, destFileName)

            For Each old In Directory.GetFiles(_avatarsFolder, $"{_id}_profilePicture.*")
                File.Delete(old)
            Next

            File.Copy(sourcePath, destPath, overwrite:=True)
            Return destPath
        Catch ex As Exception
            MessageBox.Show($"Erro ao salvar imagem: {ex.Message}",
                            "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return String.Empty
        End Try
    End Function


    Private Async Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
        If String.IsNullOrWhiteSpace(newName.Text) Then
            MessageBox.Show("O nome não pode ficar vazio.", "Atenção",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        If String.IsNullOrWhiteSpace(NewUseremail.Text) Then
            MessageBox.Show("O e-mail não pode ficar vazio.", "Atenção",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        BtnSave.Enabled = False
        BtnSave.Values.Text = "Salvando..."

        Try
            Dim updates As New Dictionary(Of String, Object) From {
                {"name", newName.Text.Trim()},
                {"email", NewUseremail.Text.Trim()},
                {"bio", NewBios.Text.Trim()}
            }

            If Not String.IsNullOrEmpty(_fileUrl) Then
                updates("profilePicture") = _fileUrl
            End If

            Await UpdateAsync("Users", updates, $"id = {_id}")

            NameUser.Text = newName.Text.Trim()
            Useremail.Text = NewUseremail.Text.Trim()

            MessageBox.Show("Perfil atualizado com sucesso!",
                            "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show($"Erro ao salvar: {ex.Message}",
                            "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            BtnSave.Enabled = True
            BtnSave.Values.Text = "Salvar alterações"
        End Try
    End Sub

    'borda do circulo azul
    Private Sub PictureProfile_Paint(sender As Object, e As PaintEventArgs) Handles PictureProfile.Paint

        e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias
        e.Graphics.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic


        Using caneta As New Pen(Color.FromArgb(0, 102, 204), 2)
            e.Graphics.DrawEllipse(caneta, 1, 1, PictureProfile.Width - 3, PictureProfile.Height - 3)
        End Using
    End Sub

    Private Sub NameUser_Click(sender As Object, e As EventArgs) Handles NameUser.Click

    End Sub
End Class