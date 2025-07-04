Imports System.Data.SqlClient

Public Class Validation

    Public Shared Function IsUserNameExists(userName As String) As Boolean
        Dim conn As New SqlClient.SqlConnection
        conn.ConnectionString = "server=R3COM8;user id=sa;password=sqlpassword123;Database=sample;"
        Try
            conn.Open()
            Dim stmt As String = "SELECT 1 FROM USERS WHERE username=@username"
            Dim cmd As New SqlCommand(stmt, conn)
            cmd.Parameters.AddWithValue("@username", userName)
            Dim reader = cmd.ExecuteReader()
            If reader.Read() Then
                Return True
            End If
        Catch ex As Exception
            MsgBox(ex.ToString(), MsgBoxStyle.Exclamation)
        End Try
        Return False
    End Function

    Public Shared Function IsEmpty(input As String) As Boolean
        Return String.IsNullOrEmpty(input)
    End Function
End Class
