Imports System.IO

Public Class config
    Inherits FormBase

    Private _id As String
    Private _fileUrl As String = String.Empty

    ' Pasta avatars sempre ao lado do executável
    Private ReadOnly _avatarsFolder As String =
        Path.Combine(Application.StartupPath, "profilePicture")

    Public Sub New(id As String)
        InitializeComponent()
        _id = id
    End Sub

    ' ── Carrega dados do usuário ao abrir o form ──────────────────────────
    Private Async Sub config_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.sidebar.UserId = _id
        Me.sidebar.ActualForm = Me

        'deixando o circulo do perfil redondo
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

    ' ── Carrega imagem no PictureBox a partir de caminho local ────────────
    Private Sub LoadProfileImage(filePath As String)
        Try
            If Not File.Exists(filePath) Then Return
            ' Lê em MemoryStream para não travar o arquivo no disco
            Dim bytes = File.ReadAllBytes(filePath)
            Using ms As New MemoryStream(bytes)
                PictureProfile.Image = Image.FromStream(ms)
            End Using
            PictureProfile.SizeMode = PictureBoxSizeMode.Zoom
        Catch ex As Exception
            ' Silencia erros de imagem
        End Try
    End Sub

    ' ── Botão: selecionar nova imagem ─────────────────────────────────────
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
            LoadProfileImage(_fileUrl)   ' Pré-visualiza imediatamente
        End Using
    End Sub

    ' ── Copia o arquivo para /avatars/{id}_avatar.ext ─────────────────────
    Private Function SaveAvatarLocally(sourcePath As String) As String
        Try
            ' Garante que a pasta existe
            If Not Directory.Exists(_avatarsFolder) Then
                Directory.CreateDirectory(_avatarsFolder)
            End If

            Dim ext = Path.GetExtension(sourcePath).ToLower()   ' Ex: .jpg
            Dim destFileName = $"{_id}_avatar{ext}"             ' Ex: 42_avatar.jpg
            Dim destPath = Path.Combine(_avatarsFolder, destFileName)

            ' Remove avatar anterior do mesmo usuário (qualquer extensão)
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

    ' ── Botão: salvar todas as alterações ─────────────────────────────────
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

            ' Salva o caminho do avatar no banco só se foi alterado
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
        ' Ativa a suavização máxima de serrilhado
        e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias
        e.Graphics.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic

        ' 🛠️ O TRUQUE: Trazemos o desenho levemente para dentro (começando em 1,1 e reduzindo -3 na largura/altura)
        ' Isso impede que a máscara de corte "coma" as bordas da linha azul
        Using caneta As New Pen(Color.FromArgb(0, 102, 204), 2)
            e.Graphics.DrawEllipse(caneta, 1, 1, PictureProfile.Width - 3, PictureProfile.Height - 3)
        End Using
    End Sub

    Private Sub NameUser_Click(sender As Object, e As EventArgs) Handles NameUser.Click

    End Sub
End Class