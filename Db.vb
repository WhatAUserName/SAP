'Public Class Db

'    Private Propert conn As New SqlClient.SqlConnection

'    Dim conn As New SqlClient.SqlConnection
'        conn.ConnectionString = "server=R3COM8;user id=sa;password=sqlpassword123;Database=sample

'    Public Sub New()
'        Try
'            conn.Open()
'            Dim stmt As String = "SELECT * FROM USERS AS u JOIN USERS_INFO AS ui ON u.id = ui.userId WHERE u.id = ui.userId"
'            Dim cmd As New SqlCommand(stmt, conn)

'            cmd.Parameters.AddWithValue("@username", username)
'            cmd.Parameters.AddWithValue("@password", password)
'            cmd.Parameters.AddWithValue("@name", fullName)
'            cmd.Parameters.AddWithValue("@gender", gender)
'            cmd.Parameters.AddWithValue("@occupation", occupation)
'            cmd.Parameters.AddWithValue("@dateOfBirth", dateOfBirth)
'            cmd.Parameters.AddWithValue("@isAgree", True)
'            cmd.ExecuteNonQuery()

'        Catch ex As Exception
'            MsgBox(ex.ToString())
'            MsgBox(ex.ToString(), MsgBoxStyle.Exclamation)
'        End Try
'    End Sub

'End Class
