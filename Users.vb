Imports System.Data
Imports System.Data.SqlClient

Public Class Users
    Dim selectedId As Integer
    Private Property passwordHashed As String

    Private Sub usersTab_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'User Form
        addUserFormPane.Hide()
        editUserFormPane.Hide()
        deleteModal.Hide()

        PopulateUserData()
    End Sub

    Private Sub PopulateUserData()

        Using Table As New DataTable("Users")
            With Table
                .Columns.Add("Id", GetType(System.Int32))
                .Columns.Add("Username", GetType(System.String))
                .Columns.Add("Password", GetType(System.String))
                .Columns.Add("Name", GetType(System.String))
                .Columns.Add("Occupation", GetType(System.String))
                .Columns.Add("Birthday", GetType(System.DateTime))
                .Columns.Add("Gender", GetType(System.String))

                Dim Row As DataRow = Table.NewRow()

                Using conn As New SqlClient.SqlConnection
                    With conn
                        .ConnectionString = "server=R3COM8;user id=sa;password=sqlpassword123;Database=sample;"
                        Try
                            .Open()
                            Dim query As String = "SELECT * FROM [dbo].[users] AS u JOIN [dbo].[user_information] AS ui ON u.id = ui.userId"
                            Dim cmd As New SqlCommand(query, conn)
                            Dim reader = cmd.ExecuteReader()

                            While reader.Read()
                                Table.Rows.Add(reader("id"), reader("username"), reader("password"), reader("name"), reader("occupation"), reader("dateOfBirth"), reader("gender"))
                                passwordHashed = reader("password")
                                userTable.DataSource = Table
                            End While

                        Catch ex As Exception
                            MsgBox("Something went wrong. Please try again later!")
                        End Try
                    End With
                End Using
            End With
        End Using
    End Sub

    Private Sub editUserBtn_Click(sender As Object, e As EventArgs)
        editUserFormPane.Show()
    End Sub

    Private Sub cancelEditUserBtn_Click(sender As Object, e As EventArgs) Handles cancelEditUserBtn.Click
        editUserFormPane.Hide()
    End Sub

    'START of Add User Form
    Private Sub addNewUserBtn_Click(sender As Object, e As EventArgs) Handles addNewUserBtn.Click
        Dim username = addUserUsername.Text
        Dim password = addUserPassword.Text
        Dim fullName = addUserFullname.Text
        Dim occupation = addOccupation.Text
        Dim gender = addUserGender.Text
        Dim dateOfBirth = Convert.ToDateTime(addDateOfBirth.Text)

        Dim conn As New SqlClient.SqlConnection
        conn.ConnectionString = "server=R3COM8;user id=sa;password=sqlpassword123;Database=sample;"

        Try
            conn.Open()
            Dim stmt As String = "DECLARE @UserID INT; INSERT INTO [dbo].[users] (username, password) VALUES (@username, @password); SET @UserID = SCOPE_IDENTITY(); INSERT INTO [dbo].[user_information] (name, gender, occupation, dateOfBirth, isAgree, userId) VALUES (@name, @gender, @occupation, @dateOfBirth, @isAgree, @UserID)"
            Dim cmd As New SqlCommand(stmt, conn)

            password = PasswordHelper.GenerateHashedPassword(password)
            cmd.Parameters.AddWithValue("@username", username)
            cmd.Parameters.AddWithValue("@password", password)
            cmd.Parameters.AddWithValue("@name", fullName)
            cmd.Parameters.AddWithValue("@gender", gender)
            cmd.Parameters.AddWithValue("@occupation", occupation)
            cmd.Parameters.AddWithValue("@dateOfBirth", dateOfBirth)
            cmd.Parameters.AddWithValue("@isAgree", True)
            cmd.ExecuteNonQuery()

        Catch ex As Exception
            MsgBox(ex.ToString())
            MsgBox(ex.ToString(), MsgBoxStyle.Exclamation)
        End Try

        PopulateUserData()
        clearAddUserForm()
        closeAddUserForm()
    End Sub

    Private Sub userAddBtn_Click(sender As Object, e As EventArgs) Handles userAddBtn.Click
        addUserFormPane.Show()
    End Sub

    Private Sub closeAddUserForm()
        addUserFormPane.Hide()
    End Sub

    Private Sub clearEditUserForm()
        editUserUsername.Text = ""
        editUserPassword.Text = ""
        editUserFullname.Text = ""
        editUserOccupation.Text = ""
        editUserGender.Text = ""
        editUserBirthday.Text = ""

    End Sub
    Private Sub clearAddUserForm()
        addUserUsername.Text = ""
        addUserPassword.Text = ""
        addUserFullname.Text = ""
        addOccupation.Text = ""
        addUserGender.Text = ""
        addDateOfBirth.Text = ""
    End Sub

    Private Sub cancelAddUserBtn_Click(sender As Object, e As EventArgs) Handles cancelAddUserBtn.Click
        closeAddUserForm()
    End Sub

    'END of Edit User Form
    Private Sub editCurrentUserBtn_Click(sender As Object, e As EventArgs) Handles editCurrentUserBtn.Click

        Dim username = editUserUsername.Text
        Dim password = editUserPassword.Text
        Dim fullName = editUserFullname.Text
        Dim occupation = editUserOccupation.Text
        Dim gender = editUserGender.Text
        Dim dateOfBirth = Convert.ToDateTime(editUserBirthday.Text)

        Dim conn As New SqlClient.SqlConnection
        conn.ConnectionString = "server=R3COM8;user id=sa;password=sqlpassword123;Database=sample;"

        If Not password = passwordHashed Then
            password = PasswordHelper.GenerateHashedPassword(password)
        End If

        Try
            conn.Open()
            Dim stmt As String = "UPDATE [dbo].[users] SET username=@username, password=@password WHERE id=@id; UPDATE [dbo].[user_information] SET name=@name, dateOfBirth=@dateOfBirth, gender=@gender WHERE userId=@id;"
            Dim cmd As New SqlCommand(stmt, conn)

            cmd.Parameters.AddWithValue("@username", username)
            cmd.Parameters.AddWithValue("@password", password)
            cmd.Parameters.AddWithValue("@name", fullName)
            cmd.Parameters.AddWithValue("@occupation", occupation)
            cmd.Parameters.AddWithValue("@dateOfBirth", dateOfBirth)
            cmd.Parameters.AddWithValue("@gender", gender)
            cmd.Parameters.AddWithValue("@id", selectedId)

            cmd.ExecuteNonQuery()

        Catch ex As Exception
            MsgBox(ex.ToString(), MsgBoxStyle.Exclamation)
        End Try

        PopulateUserData()
        clearEditUserForm()
        editUserFormPane.Hide()
    End Sub

    Private Sub userTable_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles userTable.CellClick
        deleteModal.Hide()
        editUserFormPane.Show()
        If e.RowIndex >= 0 AndAlso e.ColumnIndex >= 0 Then
            Dim selectedRow As DataGridViewRow = userTable.Rows(e.RowIndex)
            Dim currObj = selectedRow.Cells(0).Value
            If Not IsDBNull(currObj) AndAlso currObj IsNot Nothing Then
                Dim currId As Integer = Convert.ToInt32(currObj)
                selectedId = currId
                editUserUsername.Text = selectedRow.Cells(1).Value.ToString()
                editUserPassword.Text = selectedRow.Cells(2).Value.ToString()
                editUserFullname.Text = selectedRow.Cells(3).Value.ToString()
                editUserOccupation.Text = selectedRow.Cells(4).Value.ToString()
                editUserBirthday.Text = Convert.ToDateTime(selectedRow.Cells(5).Value)
                editUserGender.Text = selectedRow.Cells(6).Value.ToString()
            End If
        End If
    End Sub

    Private Sub userTable_CellMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles userTable.CellMouseDoubleClick
        editUserFormPane.Hide()
        deleteModal.Show()
        If e.RowIndex >= 0 AndAlso e.ColumnIndex >= 0 Then
            selectedId = userTable.Rows(e.RowIndex).Cells(0).Value
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        deleteModal.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Dim conn As New SqlClient.SqlConnection
        conn.ConnectionString = "server=R3COM8;user id=sa;password=sqlpassword123;Database=sample;"

        Try
            conn.Open()
            Dim stmt As String = "DELETE FROM [dbo].[user_information] WHERE userId=@id; DELETE FROM [dbo].[users] WHERE id=@id"
            Dim cmd As New SqlCommand(stmt, conn)
            cmd.Parameters.AddWithValue("@id", selectedId)
            cmd.ExecuteNonQuery()

        Catch ex As Exception
            MsgBox(ex.ToString(), MsgBoxStyle.Exclamation)
        End Try

        deleteModal.Hide()
        PopulateUserData()
    End Sub


End Class
