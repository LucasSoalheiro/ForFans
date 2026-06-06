Imports System.IO
Imports MySql.Data.MySqlClient

Public Class CreatorArea
    Inherits FormBase

    Private _fileUrl As String = ""
    Private _thumbnailUrl As String = ""
    Private _contentType As String = ""

    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub CreatorArea_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.sidebar.AccountName = SessionManager.UserName
        'Me.sidebar.ActualForm = Me
    End Sub


    Private ReadOnly _imageExtensions As String() = {".jpg", ".jpeg", ".png", ".gif"}

    Private Sub SelectFileBtn_Click(sender As Object, e As EventArgs) Handles SelectFileBtn.Click
        Using ofd As New OpenFileDialog()
            ofd.Filter = "Vídeos (*.mp4;*.avi;*.mov;*.mkv)|*.mp4;*.avi;*.mov;*.mkv|Imagens (*.jpg;*.jpeg;*.png;*.gif)|*.jpg;*.jpeg;*.png;*.gif|Todos os arquivos|*.*"
            ofd.Title = "Selecione uma imagem ou vídeo"

            If ofd.ShowDialog() <> DialogResult.OK Then Return

            Dim ext = Path.GetExtension(ofd.FileName).ToLower()
            _contentType = If(_imageExtensions.Contains(ext), "photo", "video")

            ' Limite de 5MB para fotos, 50MB para vídeos
            Dim maxBytes As Long = If(_contentType = "photo", 5 * 1024 * 1024, 50 * 1024 * 1024)
            If Not Validator.IsFileSizeValid(ofd.FileName, maxBytes) Then
                MessageBox.Show($"O arquivo é muito grande. Limite: {If(_contentType = "photo", "5MB", "50MB")}.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            _fileUrl = UploadFile(ofd.FileName)
            If String.IsNullOrEmpty(_fileUrl) Then Return

            If _contentType = "photo" Then
                ImageHelper.SetImage(picPreview, Path.Combine(Application.StartupPath, _fileUrl))
            End If
        End Using
    End Sub

    Private Sub ThumbnailBtn_Click(sender As Object, e As EventArgs) Handles ThumbnailBtn.Click
        Using ofd As New OpenFileDialog()
            ofd.Filter = "Imagens (*.jpg;*.jpeg;*.png;*.gif)|*.jpg;*.jpeg;*.png;*.gif"
            ofd.Title = "Selecione a thumbnail"

            If ofd.ShowDialog() <> DialogResult.OK Then Return

            ' Limite de 2MB para thumbnail
            If Not Validator.IsFileSizeValid(ofd.FileName, 2 * 1024 * 1024) Then
                MessageBox.Show("A thumbnail deve ter no máximo 2MB.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            _thumbnailUrl = UploadFile(ofd.FileName)
            If String.IsNullOrEmpty(_thumbnailUrl) Then Return

            ImageHelper.SetImage(picPreview, Path.Combine(Application.StartupPath, _thumbnailUrl))
        End Using
    End Sub

    Private Async Sub SaveBtn_Click(sender As Object, e As EventArgs) Handles SaveBtn.Click
        Dim title As String = txtTitle.Text.Trim()
        Dim description As String = txtDescription.Text.Trim()

        If String.IsNullOrEmpty(_fileUrl) Then
            MessageBox.Show("Selecione um arquivo primeiro!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        If String.IsNullOrWhiteSpace(title) Then
            MessageBox.Show("Informe o título!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        SaveBtn.Enabled = False
        Try
            Await CreateAsync("Content", New Dictionary(Of String, Object) From {
                {"creatorId", SessionManager.UserId},
                {"title", title},
                {"description", description},
                {"fileUrl", _fileUrl},
                {"thumbnailUrl", _thumbnailUrl},
                {"type", _contentType}
            })

            MessageBox.Show("Conteúdo salvo com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            LimparFormulario()
        Catch ex As Exception
            MessageBox.Show("Erro ao salvar conteúdo. Verifique sua conexão.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If Me.Visible Then SaveBtn.Enabled = True
        End Try
    End Sub

    Private Function UploadFile(localPath As String) As String
        Try
            Dim uploadsFolder = Path.Combine(Application.StartupPath, "uploads")
            If Not Directory.Exists(uploadsFolder) Then Directory.CreateDirectory(uploadsFolder)

            Dim fileName = $"{Guid.NewGuid()}{Path.GetExtension(localPath)}"
            Dim destPath = Path.Combine(uploadsFolder, fileName)

            File.Copy(localPath, destPath, True)
            Return $"uploads/{fileName}"
        Catch ex As Exception
            MessageBox.Show($"Erro ao fazer upload: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return ""
        End Try
    End Function

    Private Sub LimparFormulario()
        txtTitle.Clear()
        txtDescription.Clear()
        ImageHelper.ClearImage(picPreview)
        _fileUrl = ""
        _thumbnailUrl = ""
        _contentType = ""
    End Sub

    Protected Overrides Sub OnFormClosed(e As FormClosedEventArgs)
        ImageHelper.ClearImage(picPreview)
        MyBase.OnFormClosed(e)
    End Sub

    Private Sub KryptonLabel2_Click(sender As Object, e As EventArgs) Handles KryptonLabel2.Click

    End Sub
End Class
