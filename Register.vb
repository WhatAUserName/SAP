Imports System.Data.SqlClient

Public Class Register

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Me.Hide()
        Dim login As New Login()
        login.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim username = Me.regUsername.Text
        Dim password = PasswordHelper.GenerateHashedPassword(Me.regPass.Text)
        Dim fullName = Me.regFullname.Text
        Dim occupation = Me.regUserOccupation.Text
        Dim dateOfBirth = Convert.ToDateTime(Me.regDateOfBirth.Text)
        Dim isAgree = Me.regIsAgree.Checked
        Dim gender = ""

        Dim conn As New SqlClient.SqlConnection
        conn.ConnectionString = "server=R3COM8;user id=sa;password=sqlpassword123;Database=sample;"

        If Validation.IsUserNameExists(username) Then
            MsgBox("Username already Exists!", MsgBoxStyle.Exclamation)
            Return
        ElseIf Validation.IsEmpty(username) Then
            MsgBox("Please put a valid Username", MsgBoxStyle.Exclamation)
            Return
        ElseIf Validation.IsEmpty(password) Then
            MsgBox("Please put a valid Password", MsgBoxStyle.Exclamation)
            Return
        ElseIf Validation.IsEmpty(Me.regGender.Text) Then
            MsgBox("Please select your gender", MsgBoxStyle.Exclamation)
            Return
        ElseIf Validation.IsEmpty(occupation) Then
            MsgBox("Please put a valid Occupation", MsgBoxStyle.Exclamation)
            Return
        ElseIf Validation.IsEmpty(dateOfBirth) Then
            MsgBox("Please put a valid Date Of Birth", MsgBoxStyle.Exclamation)
            Return
        ElseIf isAgree.CompareTo(True) Then
            MsgBox("Please read and check our terms and condition before we proceed to register", MsgBoxStyle.Exclamation)
            Return
        Else
            Try
                conn.Open()
                Dim stmt As String = "DECLARE @UserID INT; INSERT INTO [dbo].[users] (username, password) VALUES (@username, @password); SET @UserID = SCOPE_IDENTITY(); INSERT INTO [dbo].[user_information] (name, gender, occupation, dateOfBirth, isAgree, userId) VALUES (@name, @gender, @occupation, @dateOfBirth, @isAgree, @UserID)"
                Dim cmd As New SqlCommand(stmt, conn)

                cmd.Parameters.AddWithValue("@username", username)
                cmd.Parameters.AddWithValue("@password", password)
                cmd.Parameters.AddWithValue("@name", fullName)
                cmd.Parameters.AddWithValue("@gender", gender)
                cmd.Parameters.AddWithValue("@occupation", occupation)
                cmd.Parameters.AddWithValue("@dateOfBirth", dateOfBirth)
                cmd.Parameters.AddWithValue("@isAgree", isAgree)
                cmd.ExecuteNonQuery()

                regUsername.Clear()
                regPass.Clear()
                regFullname.Clear()
                regUserOccupation.Text = ""
                regIsAgree.Checked = False

                MsgBox("User Registered Successfully, You can now login!", MsgBoxStyle.Information)
            Catch ex As Exception
                MsgBox(ex.ToString(), MsgBoxStyle.Exclamation)
                Return
            Finally
                conn.Close()
            End Try
        End If
    End Sub

End Class
