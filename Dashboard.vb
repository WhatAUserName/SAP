Imports System.Drawing.Drawing2D
Imports System.Data
Imports System.Data.SqlClient

Public Class Dashboard
    Dim selectedId As Integer
    Private Property passwordHashed As String

    Private Property _userSession As Session

    Public Sub New(userSession As Session)
        InitializeComponent()
        _userSession = userSession
    End Sub

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub

    Private Sub Dashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        usersTab.Hide()
        dashboardTab.Hide()

        'User Form
        addUserFormPane.Hide()
        editUserFormPane.Hide()
        deleteModal.Hide()

        AddHandler homeTabPane.Click, AddressOf homeTabPane_Click
        AddHandler userTabPane.Click, AddressOf userTabPane_Click
        AddHandler productsTabPane.Click, AddressOf productsTabPane_Click

        username.Text = _userSession.Name
        homeTabPane.BackColor = Color.AliceBlue
        PopulateUserData()
    End Sub

    'START of Dashboard Pane
    Private Sub homeTabPane_Click(sender As Object, ByVal e As System.EventArgs) Handles homeTabPane.Click
        usersTab.Hide()
        dashboardTab.Show()

        'Tab Color Styling
        homeTabPane.BackColor = Color.AliceBlue
        userTabPane.BackColor = Color.White
        productsTabPane.BackColor = Color.White
    End Sub
    'END of Dashboard Pane

    'START of User Tab Pane
    Private Sub userTabPane_Click(sender As Object, ByVal e As System.EventArgs) Handles userTabPane.Click
        dashboardTab.Hide()
        usersTab.Show()

        'Tab Color Styling
        homeTabPane.BackColor = Color.White
        userTabPane.BackColor = Color.AliceBlue
        productsTabPane.BackColor = Color.White
    End Sub
    'END of User Tab Pane

    'START of Products Tab Pane
    Private Sub productsTabPane_Click(sender As Object, ByVal e As System.EventArgs) Handles productsTabPane.Click
        dashboardTab.Hide()
        usersTab.Hide()
        Dim product As New Products()
        product.Show()

        'Tab Color Styling
        homeTabPane.BackColor = Color.White
        userTabPane.BackColor = Color.White
        productsTabPane.BackColor = Color.AliceBlue

    End Sub
    'END of Products Tab Pane


    Private Sub PopulateUserData()
        Dim Table As DataTable = New DataTable("Users")

        Table.Columns.Add("Id", GetType(System.Int32))
        Table.Columns.Add("Username", GetType(System.String))
        Table.Columns.Add("Password", GetType(System.String))
        Table.Columns.Add("Name", GetType(System.String))
        Table.Columns.Add("Occupation", GetType(System.String))
        Table.Columns.Add("Birthday", GetType(System.DateTime))
        Table.Columns.Add("Gender", GetType(System.String))

        Dim Row As DataRow = Table.NewRow()

        Dim conn As New SqlClient.SqlConnection
        conn.ConnectionString = "server=R3COM8;user id=sa;password=sqlpassword123;Database=sample;"
        Try
            conn.Open()
            Dim query As String = "SELECT * FROM [dbo].[users] AS u JOIN [dbo].[user_information] AS ui ON u.id = ui.userId"
            Dim cmd As New SqlCommand(query, conn)
            Dim reader = cmd.ExecuteReader()

            While reader.Read()
                Table.Rows.Add(reader("id"), reader("username"), reader("password"), reader("name"), reader("occupation"), reader("dateOfBirth"), reader("gender"))
                passwordHashed = reader("password")
                userTable.DataSource = Table
            End While

        Catch ex As Exception
            MsgBox(ex.ToString())
            MsgBox("Something went wrong. Please try again later!")
            Return
        End Try

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
            MsgBox(ex.ToString())
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
            MsgBox(ex.ToString())
            MsgBox(ex.ToString(), MsgBoxStyle.Exclamation)
        End Try

        deleteModal.Hide()
        PopulateUserData()
    End Sub

    Public Sub showProfilePage()
        Me.Hide()
        Dim currentUserProfile As New Profile(_userSession)
        currentUserProfile.Show()
    End Sub

    Private Sub logoutTabPane_Click(sender As Object, e As EventArgs) Handles logoutTabPane.Click
        _userSession = Nothing
        Me.Hide()
        Dim login As New Login()
        login.Show()

    End Sub
    Public Sub PictureBox6_Click(sender As Object, e As EventArgs) Handles PictureBox6.Click
        showProfilePage()
    End Sub

    Private Sub PictureBox10_Click(sender As Object, e As EventArgs) Handles PictureBox10.Click
        showProfilePage()
    End Sub


    'START of Products Pane
    'Private Sub productsTabPane_Click(sender As Object, e As EventArgs) Handles productsTabPane.Click
    '    dashboardTab.Hide()
    '    usersTab.Hide()
    '    productsTab.Show()

    '    ' Populate Record PRODUCT
    '    Dim conn As New SqlClient.SqlConnection
    '    conn.ConnectionString = "server=R3COM8;user id=sa;password=sqlpassword123;Database=sample;"
    '    Try
    '        conn.Open()
    '        Dim query As String = "SELECT * FROM [dbo].[products] AS p JOIN [dbo].[category] AS c ON p.categoryId = c.id"
    '        Dim cmd As New SqlCommand(query, conn)
    '        Dim reader = cmd.ExecuteReader()

    '        While reader.Read()

    '            'nameProd.Text = reader("name")
    '            'price.Text = reader("price")
    '            'quantity.Text = reader("quantity")
    '            'description.Text = reader("description")

    '            ' Create card panel
    '            Dim productPane As New Panel()
    '            productPane.Width = 259
    '            productPane.Height = 412
    '            productPane.BackColor = Color.White

    '            ' Code label
    '            Dim code As New Label()
    '            code.Text = reader("code")
    '            code.Font = New Font("Segoe UI", 10, FontStyle.Bold)
    '            code.AutoSize = True
    '            code.Location = New Point(188, 16)

    '            ' Add controls to card
    '            productPane.Controls.Add(code)

    '            ' Add card to FlowLayoutPanel
    '            FlowLayoutPanel1.Controls.Add(productPane)

    '        End While

    '    Catch ex As Exception
    '        MsgBox(ex.ToString())
    '        MsgBox("Something went wrong. Please try again later!")
    '        Return

    '    End Try

    '    ' Creating PRODUCT
    '    'Try
    '    '    conn.Open()
    '    '    Dim query As String = "SELECT * FROM [dbo].[products] AS p JOIN [dbo].[category] AS c ON p.id = c.categoryId"
    '    '    Dim cmd As New SqlCommand(query, conn)
    '    '    Dim reader = cmd.ExecuteReader()

    '    '    While reader.Read()
    '    '        code.Text = reader("code")
    '    '        prodName.Text = reader("name")
    '    '        price.Text = reader("price")
    '    '        quantity.Text = reader("quantity")
    '    '        description.Text = reader("description")
    '    '    End While

    '    'Catch ex As Exception
    '    '    MsgBox(ex.ToString())
    '    '    MsgBox("Something went wrong. Please try again later!")
    '    '    Return

    '    'End Try

    '    ' EDITING PRODUCT



    '    ' DELETING PRODUCT
    'End Sub
    'END of Products Pane

End Class
