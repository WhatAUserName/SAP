Imports System.Security.Cryptography
Imports System.Text

Public Class PasswordHelper

    '###First implementation as of now
    Public Shared Function GenerateHashedPassword(rawData As String) As String
        Using sha256Hash As SHA256 = SHA256.Create()
            Dim bytes As Byte() = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(rawData))
            Dim builder As New StringBuilder()
            For Each b As Byte In bytes
                builder.Append(b.ToString("x2"))
            Next
            Return builder.ToString()
        End Using
    End Function


    '###Second Implementation, most secured way

    'Private Function GenerateSalt(ByVal nSalt As Integer) As String
    '    Dim saltBytes = New Byte(nSalt) {}

    '    Using provider = New RNGCryptoServiceProvider()
    '        provider.GetNonZeroBytes(saltBytes)
    '    End Using

    '    Return Convert.ToBase64String(saltBytes)
    'End Function

    'Private Function HashPassword(ByVal password As String, ByVal salt As String, ByVal nIterations As Integer, ByVal nHash As Integer) As String
    '    Dim saltBytes = Convert.FromBase64String(salt)

    '    Using rfc2898DeriveBytes = New Rfc2898DeriveBytes(password, saltBytes, nIterations)
    '        Return Convert.ToBase64String(rfc2898DeriveBytes.GetBytes(nHash))
    '    End Using
    'End Function

    'Private Function CryptographicEquals(a As String, b As String) As Boolean
    '    Dim aBytes = Convert.FromBase64String(a)
    '    Dim bBytes = Convert.FromBase64String(b)

    '    If aBytes.Length <> bBytes.Length Then Return False

    '    Dim result As Integer = 0
    '    For i As Integer = 0 To aBytes.Length - 1
    '        result = result Or (aBytes(i) Xor bBytes(i))
    '    Next

    '    Return result = 0
    'End Function

    'Public Function VerifyPassword(inputPassword As String, storedValue As String) As Boolean
    '    Dim parts = storedValue.Split(":"c)
    '    If parts.Length <> 2 Then Return False

    '    Dim storedSalt = parts(0)
    '    Dim storedHash = parts(1)

    '    Dim inputHash = HashPassword(inputPassword, storedSalt, 10101, 70)

    '    Return CryptographicEquals(storedHash, inputHash)
    'End Function

    'Public Function GenerateHashedPassword(password As String) As String
    '    Dim salt = GenerateSalt(70)
    '    Dim hash = HashPassword(password, salt, 10101, 70)
    '    Return salt & ":" & hash
    'End Function

End Class
