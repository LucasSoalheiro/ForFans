Imports System.IO
'C:\Users\User\source\repos\forfans\bin\Debug\net10.0-windows\uploads é caminho das imagens

Public Class CreatorArea
    Inherits FormBase

    Private _fileUrl As String = ""
    Private _thumbnailUrl As String = ""
    Private _contentType As String = ""

    Private Sub SelectFileBtn_Click(sender As Object, e As EventArgs) Handles SelectFileBtn.Click
        Using ofd As New OpenFileDialog()
            ofd.Filter = "Imagens (*.jpg;*.jpeg;*.png;*.gif)|*.jpg;*.jpeg;*.png;*.gif|" &
                         "Vídeos (*.mp4;*.avi;*.mov;*.mkv)|*.mp4;*.avi;*.mov;*.mkv|" &
                         "Todos os arquivos|*.*"
            ofd.Title = "Selecione uma imagem ou vídeo"

            If ofd.ShowDialog() = DialogResult.OK Then
                Dim ext = Path.GetExtension(ofd.FileName).ToLower()

                If ext = ".jpg" OrElse ext = ".jpeg" OrElse ext = ".png" OrElse ext = ".gif" Then
                    _contentType = "photo"
                Else
                    _contentType = "video"
                End If

                _fileUrl = UploadFile(ofd.FileName)

                lblFileName.Text = Path.GetFileName(ofd.FileName)
                lblType.Text = _contentType

                If _contentType = "photo" Then
                    Dim fullPath = Path.Combine(Application.StartupPath, _fileUrl)
                    picPreview.Image = Image.FromFile(fullPath)
                End If
            End If
        End Using
    End Sub

    Private Sub ThumbnailBtn_Click(sender As Object, e As EventArgs) Handles ThumbnailBtn.Click
        Using ofd As New OpenFileDialog()
            ofd.Filter = "Imagens (*.jpg;*.jpeg;*.png;*.gif)|*.jpg;*.jpeg;*.png;*.gif"
            ofd.Title = "Selecione a thumbnail"

            If ofd.ShowDialog() = DialogResult.OK Then
                _thumbnailUrl = UploadFile(ofd.FileName)

                Dim fullPath = Path.Combine(Application.StartupPath, _thumbnailUrl)
                picPreview.Image = Image.FromFile(fullPath)
            End If
        End Using
    End Sub


    Private Sub SaveBtn_Click(sender As Object, e As EventArgs) Handles SaveBtn.Click
        If String.IsNullOrEmpty(_fileUrl) Then
            MessageBox.Show("Selecione um arquivo primeiro!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        If String.IsNullOrWhiteSpace(txtTitle.Text) Then
            MessageBox.Show("Informe o título!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Try


            MessageBox.Show("Conteúdo salvo com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            LimparFormulario()

        Catch ex As Exception
            MessageBox.Show($"Erro ao salvar: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Function UploadFile(localPath As String) As String
        Dim uploadsFolder = Path.Combine(Application.StartupPath, "uploads")

        If Not Directory.Exists(uploadsFolder) Then
            Directory.CreateDirectory(uploadsFolder)
        End If

        Dim fileName = $"{Guid.NewGuid()}{Path.GetExtension(localPath)}"
        Dim destPath = Path.Combine(uploadsFolder, fileName)

        File.Copy(localPath, destPath)

        Return Path.Combine("uploads", fileName)
    End Function


    Private Sub LimparFormulario()
        txtTitle.Text = ""
        txtDescription.Text = ""
        lblFileName.Text = "Nenhum arquivo selecionado"
        lblType.Text = ""
        picPreview.Image = Nothing
        _fileUrl = ""
        _thumbnailUrl = ""
        _contentType = ""
    End Sub

End Class