Imports System.Data.SqlClient

Public Class Login

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        Dim conn As New SqlClient.SqlConnection
        Dim logUsername = Me.logUsername.Text
        Dim logPassword = Me.logPass.Text

        If String.IsNullOrWhiteSpace(logUsername) Or String.IsNullOrWhiteSpace(logPassword) Then
            MsgBox("Invalid Username or Password", MsgBoxStyle.Exclamation)
            Return
        End If

        logPassword = PasswordHelper.GenerateHashedPassword(logPassword)
        Try
            conn.ConnectionString = "server=R3COM8;user id=sa;password=sqlpassword123;Database=sample;"
            conn.Open()

            Dim query As String = "SELECT * FROM [dbo].[users] AS u JOIN [dbo].[user_information] AS ui ON u.id = ui.userId WHERE u.username=@username AND u.password=@password"
            Dim cmd As New SqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@username", logUsername)
            cmd.Parameters.AddWithValue("@password", logPassword)

            Dim reader = cmd.ExecuteReader()

            If reader.Read() And reader("username").Equals(logUsername) And reader("password").Equals(logPassword) Then
                Me.Hide()
                Dim userSession = New Session(reader("id"), reader("username"), reader("name"), reader("occupation"), reader("dateOfBirth"), reader("gender"), reader("prof_image"))

                Dim dashboard = New Dashboard(userSession)
                dashboard.Show()
            End If

        Catch ex As Exception
            MsgBox("Invalid Credentials!", MsgBoxStyle.Exclamation)
            Me.logUsername.Select()
            Me.logUsername.SelectAll()
            Me.logPass.Text = ""
        Finally
            conn.Close()
        End Try

    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Me.logUsername.Text = ""
        Me.logPass.Text = ""
    End Sub

    Private Sub SignUpLink_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles SignUpLink.LinkClicked
        Me.Hide()
        Dim register As New Register()
        register.Show()
    End Sub


End Class
