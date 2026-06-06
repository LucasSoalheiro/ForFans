Imports System.Security.Cryptography

Public Class PasswordHasher

    Public Shared Function HashPassword(password As String) As String
        Dim saltBytes(15) As Byte
        RandomNumberGenerator.Fill(saltBytes)

        Dim hashBytes As Byte() = Rfc2898DeriveBytes.Pbkdf2(password, saltBytes, 100000, HashAlgorithmName.SHA256, 32)

        Dim combinedBytes(47) As Byte
        Buffer.BlockCopy(saltBytes, 0, combinedBytes, 0, 16)
        Buffer.BlockCopy(hashBytes, 0, combinedBytes, 16, 32)

        Return Convert.ToBase64String(combinedBytes)
    End Function

    Public Shared Function VerifyPassword(password As String, storedHash As String) As Boolean
        Dim combinedBytes As Byte() = Convert.FromBase64String(storedHash)

        Dim saltBytes(15) As Byte
        Buffer.BlockCopy(combinedBytes, 0, saltBytes, 0, 16)

        Dim hashBytes As Byte() = Rfc2898DeriveBytes.Pbkdf2(password, saltBytes, 100000, HashAlgorithmName.SHA256, 32)

        For i As Integer = 0 To 31
            If combinedBytes(i + 16) <> hashBytes(i) Then Return False
        Next
        Return True
    End Function

End Class
