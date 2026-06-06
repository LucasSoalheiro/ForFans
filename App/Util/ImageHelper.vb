Imports System.IO

Public Class ImageHelper
    ''' <summary>
    ''' Carrega uma imagem de um arquivo sem travar o arquivo no disco.
    ''' </summary>
    Public Shared Function LoadImage(filePath As String) As Image
        Try
            If Not File.Exists(filePath) Then Return Nothing

            Dim bytes = File.ReadAllBytes(filePath)
            Dim ms As New MemoryStream(bytes)
            Return Image.FromStream(ms)
        Catch ex As Exception
            Return Nothing
        End Try
    End Function

    ''' <summary>
    ''' Define a imagem em um PictureBox de forma segura, descartando a anterior.
    ''' </summary>
    Public Shared Sub SetImage(pb As PictureBox, filePath As String, Optional mode As PictureBoxSizeMode = PictureBoxSizeMode.Zoom)
        Try
            Dim oldImage = pb.Image
            pb.Image = LoadImage(filePath)
            pb.SizeMode = mode
            If oldImage IsNot Nothing Then oldImage.Dispose()
        Catch ex As Exception
            ' Log ou ignore
        End Try
    End Sub

    ''' <summary>
    ''' Garante o descarte da imagem de um PictureBox.
    ''' </summary>
    Public Shared Sub ClearImage(pb As PictureBox)
        If pb.Image IsNot Nothing Then
            pb.Image.Dispose()
            pb.Image = Nothing
        End If
    End Sub
End Class
