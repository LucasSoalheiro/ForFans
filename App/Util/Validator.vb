Imports System.Text.RegularExpressions

Public Class Validator
    ''' <summary>
    ''' Valida se uma string é um e-mail válido.
    ''' </summary>
    Public Shared Function IsValidEmail(email As String) As Boolean
        If String.IsNullOrWhiteSpace(email) Then Return False
        Try
            ' Regex padrão para validação de e-mail
            Dim pattern As String = "^[^@\s]+@[^@\s]+\.[^@\s]+$"
            Return Regex.IsMatch(email, pattern, RegexOptions.IgnoreCase)
        Catch ex As Exception
            Return False
        End Try
    End Function

    ''' <summary>
    ''' Verifica se a senha atende aos requisitos mínimos.
    ''' </summary>
    Public Shared Function IsStrongPassword(password As String, Optional minLength As Integer = 6) As Boolean
        Return Not String.IsNullOrWhiteSpace(password) AndAlso password.Length >= minLength
    End Function

    ''' <summary>
    ''' Verifica se o arquivo está dentro do limite de tamanho em bytes.
    ''' </summary>
    Public Shared Function IsFileSizeValid(filePath As String, maxBytes As Long) As Boolean
        Try
            Dim info As New System.IO.FileInfo(filePath)
            Return info.Length <= maxBytes
        Catch ex As Exception
            Return False
        End Try
    End Function
End Class
