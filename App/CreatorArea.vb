Imports System.IO

Public Class CreatorArea
    Inherits FormBase

    Private UserId As String
    Private _fileUrl As String = ""
    Private _thumbnailUrl As String = ""
    Private _contentType As String = ""

    Public Sub New(userId As String)
        InitializeComponent()
        Me.UserId = userId
    End Sub

    Private Async Sub CreatorArea_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.sidebar.UserId = UserId
        Me.sidebar.ActualForm = Me
        Dim user = Await ReadAsync("Users", $"id = {UserId}")
        Me.sidebar.AccountName = user("name").ToString()
    End Sub


    Private ReadOnly _imageExtensions As String() = {".jpg", ".jpeg", ".png", ".gif"}

    Private Sub SelectFileBtn_Click(sender As Object, e As EventArgs) Handles SelectFileBtn.Click
        Using ofd As New OpenFileDialog()

            ofd.Filter =
                "Imagens (*.jpg;*.jpeg;*.png;*.gif)|*.jpg;*.jpeg;*.png;*.gif|" &
                "Vídeos (*.mp4;*.avi;*.mov;*.mkv)|*.mp4;*.avi;*.mov;*.mkv|" &
                "Todos os arquivos|*.*"

            ofd.Title = "Selecione uma imagem ou vídeo"

            If ofd.ShowDialog() <> DialogResult.OK Then
                Return
            End If

            Dim ext = Path.GetExtension(ofd.FileName).ToLower()

            If _imageExtensions.Contains(ext) Then
                _contentType = "photo"
            Else
                _contentType = "video"
            End If

            _fileUrl = UploadFile(ofd.FileName)

            If String.IsNullOrEmpty(_fileUrl) Then
                Return
            End If


            If _contentType = "photo" Then
                Dim fullPath = Path.Combine(Application.StartupPath, _fileUrl.Replace("/", "\"))

                Try
                    LoadPreviewImage(fullPath)
                Catch ex As Exception
                    MessageBox.Show(
                        $"Erro ao carregar imagem: {ex.Message}",
                        "Erro",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    )
                End Try
            End If

        End Using
    End Sub

    Private Sub ThumbnailBtn_Click(sender As Object, e As EventArgs) Handles ThumbnailBtn.Click
        Using ofd As New OpenFileDialog()

            ofd.Filter =
                "Imagens (*.jpg;*.jpeg;*.png;*.gif)|*.jpg;*.jpeg;*.png;*.gif"

            ofd.Title = "Selecione a thumbnail"

            If ofd.ShowDialog() <> DialogResult.OK Then
                Return
            End If

            _thumbnailUrl = UploadFile(ofd.FileName)

            If String.IsNullOrEmpty(_thumbnailUrl) Then
                Return
            End If

            Dim fullPath = Path.Combine(Application.StartupPath, _thumbnailUrl.Replace("/", "\"))

            Try
                LoadPreviewImage(fullPath)
            Catch ex As Exception
                MessageBox.Show(
                    $"Erro ao carregar thumbnail: {ex.Message}",
                    "Erro",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                )
            End Try

        End Using
    End Sub

    Private Async Sub SaveBtn_Click(sender As Object, e As EventArgs) Handles SaveBtn.Click

        If String.IsNullOrEmpty(_fileUrl) Then
            MessageBox.Show(
                "Selecione um arquivo primeiro!",
                "Atenção",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning
            )
            Return
        End If

        If String.IsNullOrWhiteSpace(txtTitle.Text) Then
            MessageBox.Show(
                "Informe o título!",
                "Atenção",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning
            )
            Return
        End If

        ' Remova esta validação caso thumbnail não seja obrigatória
        If String.IsNullOrEmpty(_thumbnailUrl) Then
            MessageBox.Show(
                "Selecione uma thumbnail!",
                "Atenção",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning
            )
            Return
        End If

        Try

            MessageBox.Show(
                $"Arquivo: {_fileUrl}{vbCrLf}" &
                $"Thumbnail: {_thumbnailUrl}{vbCrLf}" &
                $"Tipo: {_contentType}",
                "Dados do Conteúdo"
            )

            Await CreateAsync("Content", New Dictionary(Of String, Object) From {
                {"creatorId", "1"},
                {"title", txtTitle.Text.Trim()},
                {"description", txtDescription.Text.Trim()},
                {"fileUrl", _fileUrl},
                {"thumbnailUrl", _thumbnailUrl},
                {"type", _contentType}
            })


            MessageBox.Show(
                "Conteúdo salvo com sucesso!",
                "Sucesso",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            )

            LimparFormulario()

        Catch ex As Exception

            MessageBox.Show(
                $"Erro ao salvar: {ex.Message}",
                "Erro",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
            )

        End Try

    End Sub

    Private Function UploadFile(localPath As String) As String

        Try

            Dim uploadsFolder =
                Path.Combine(Application.StartupPath, "uploads")

            If Not Directory.Exists(uploadsFolder) Then
                Directory.CreateDirectory(uploadsFolder)
            End If

            Dim fileName =
                $"{Guid.NewGuid()}{Path.GetExtension(localPath)}"

            Dim destPath =
                Path.Combine(uploadsFolder, fileName)

            File.Copy(localPath, destPath, True)

            Return $"uploads/{fileName}"

        Catch ex As Exception

            MessageBox.Show(
                $"Erro ao fazer upload: {ex.Message}",
                "Erro",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
            )

            Return ""

        End Try

    End Function

    Private Sub LoadPreviewImage(imagePath As String)

        If picPreview.Image IsNot Nothing Then
            picPreview.Image.Dispose()
            picPreview.Image = Nothing
        End If

        Using img As Image = Image.FromFile(imagePath)
            picPreview.Image = New Bitmap(img)
        End Using

    End Sub

    Private Sub LimparFormulario()

        txtTitle.Clear()
        txtDescription.Clear()


        If picPreview.Image IsNot Nothing Then
            picPreview.Image.Dispose()
            picPreview.Image = Nothing
        End If

        _fileUrl = ""
        _thumbnailUrl = ""
        _contentType = ""

    End Sub

    Protected Overrides Sub OnFormClosed(e As FormClosedEventArgs)

        If picPreview.Image IsNot Nothing Then
            picPreview.Image.Dispose()
            picPreview.Image = Nothing
        End If

        MyBase.OnFormClosed(e)

    End Sub

    Private Sub KryptonLabel2_Click(sender As Object, e As EventArgs) Handles KryptonLabel2.Click

    End Sub
End Class