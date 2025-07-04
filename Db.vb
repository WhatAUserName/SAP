Imports System.Data.SqlClient

Public Class Db

    Private Shared Property conn As New SqlClient.SqlConnection
    Private Shared Property stmt = "server=R3COM8;user id=sa;password=sqlpassword123;Database=sample"

    Public Sub New()
    End Sub

    Public Shared Function selectCmd(Optional columnName As String = "*", Optional tableName As String = "[dbo].[users]", Optional where As String = "") As SqlCommand
        Try
            conn.Open()
            Dim cmd As New SqlCommand("SELECT " & columnName & " FROM " & tableName & " " & where, conn)
            Return cmd
            Throw New Exception("Something wen't wrong while executing cmd")
        Catch ex As Exception
            'MsgBox(ex.ToString())
            Return Nothing
        End Try
    End Function



End Class
