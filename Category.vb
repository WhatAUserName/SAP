Imports System.Data.SqlClient

Public Class Category

    Private Property productId As Integer

    Private Sub prdTab_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        createCategoryFormPane.Hide()
        editCategoryFormPane.Hide()
        backdrop.Hide()
        flowLayout.Controls.Clear()
        populateCategories()
    End Sub

    Private Sub createCategoryName_Click(sender As Object, e As EventArgs) Handles createCategoryName.Click
        backdrop.Show()
        createCategoryFormPane.Show()
    End Sub

    Private Sub searchFilterCategoryName_TextChanged(sender As Object, e As EventArgs) Handles searchFilterCategoryName.TextChanged

        flowLayout.Controls.Clear()

        Dim conn As New SqlClient.SqlConnection
        conn.ConnectionString = "server=R3COM8;user id=sa;password=sqlpassword123;Database=sample;"

        Dim filterQuery = "%" + searchFilterCategoryName.Text + "%"

        Try
            conn.Open()
            Dim query As String = "SELECT * FROM [dbo].[category] WHERE name LIKE @name "
            Dim cmd As New SqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@name", filterQuery)

            Dim reader = cmd.ExecuteReader()
            Dim numberRow = 0
            While reader.Read()
                numberRow += 1
                renderComponent(reader, numberRow)
            End While
        Catch ex As Exception
            MsgBox(ex.ToString())
        End Try
    End Sub

    Private Sub editBtn_Click(sender As Object, e As EventArgs) Handles editBtn.Click
        Dim btn As Button = CType(sender, Button)
        productId = btn.Tag.ToString()

        backdrop.Show()
        editCategoryFormPane.Show()

        Dim conn As New SqlClient.SqlConnection
        conn.ConnectionString = "server=R3COM8;user id=sa;password=sqlpassword123;Database=sample;"
        Try
            conn.Open()
            Dim query As String = "SELECT * FROM [dbo].[category] WHERE id=@id"
            Dim cmd As New SqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@id", productId)

            Dim reader = cmd.ExecuteReader()
            While reader.Read()
                editCategoryName.Text = reader("name")
            End While

        Catch ex As Exception
            MsgBox("Something went wrong. Please try again later!")
        End Try
    End Sub

    Private Sub updateCategoryBtn_Click(sender As Object, e As EventArgs) Handles updateCategoryBtn.Click

        Dim conn As New SqlClient.SqlConnection
        conn.ConnectionString = "server=R3COM8;user id=sa;password=sqlpassword123;Database=sample;"

        Try
            conn.Open()
            Dim stmt As String = "UPDATE [dbo].[category] SET name=@name WHERE id=@id"
            Dim cmd As New SqlCommand(stmt, conn)
            cmd.Parameters.AddWithValue("@name", editCategoryName.Text)
            cmd.Parameters.AddWithValue("@id", productId)
            cmd.ExecuteNonQuery()
            editCategoryFormPane.Hide()
            backdrop.Hide()
            populateCategories()
        Catch ex As Exception
            MsgBox(ex.ToString())
            MsgBox("Something went wrong. Please try again later!")
        End Try
    End Sub

    Private Sub deleteBtn_Click(sender As Object, e As EventArgs) Handles deleteBtn.Click
        Dim btn As Button = CType(sender, Button)
        productId = btn.Tag.ToString()

        Try
            Dim conn As New SqlClient.SqlConnection
            conn.ConnectionString = "server=R3COM8;user id=sa;password=sqlpassword123;Database=sample;"
            conn.Open()
            Dim query As String = "DELETE FROM [dbo].[category] WHERE id=@id"
            Dim cmd As New SqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@id", productId)

            Dim reader = cmd.ExecuteReader()
            cmd.ExecuteNonQuery()


        Catch ex As Exception
            MsgBox("Something went wrong. Please try again later!")
        End Try
    End Sub

    Private Sub populateCategories()
        flowLayout.Controls.Clear()

        Dim conn As New SqlClient.SqlConnection
        conn.ConnectionString = "server=R3COM8;user id=sa;password=sqlpassword123;Database=sample;"

        Try
            conn.Open()
            Dim query As String = "SELECT * FROM [dbo].[category]"
            Dim cmd As New SqlCommand(query, conn)
            Dim reader = cmd.ExecuteReader()
            Dim numberRow = 0
            While reader.Read()
                numberRow += 1
                renderComponent(reader, numberRow)
            End While

        Catch ex As Exception
            MsgBox(ex.ToString())
            MsgBox("Something went wrong. Please try again later!")
        End Try

    End Sub

    Private Sub createCategoryBtn_Click(sender As Object, e As EventArgs)

        Dim conn As New SqlClient.SqlConnection
        conn.ConnectionString = "server=R3COM8;user id=sa;password=sqlpassword123;Database=sample;"

        Try
            conn.Open()
            Dim stmt As String = "INSERT INTO [dbo].[category] (name) VALUES (@name)"
            Dim cmd As New SqlCommand(stmt, conn)

            cmd.Parameters.AddWithValue("@name", editCategoryNameField.Text)
            cmd.ExecuteNonQuery()

            MsgBox("Category created Successfully!", MsgBoxStyle.Information)
            backdrop.Hide()
            createCategoryFormPane.Hide()
            populateCategories()

        Catch ex As Exception
            MsgBox(ex.ToString(), MsgBoxStyle.Exclamation)
        Finally
            conn.Close()
        End Try

    End Sub

    Private Sub renderComponent(reader As SqlDataReader, numberRow As Integer)

        Dim categPane As New Panel()
        categPane.Width = 1053
        categPane.Height = 58
        categPane.BackColor = Color.White


        Dim categNum As New Label()
        categNum.AutoSize = True
        categNum.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        categNum.ForeColor = System.Drawing.Color.DimGray
        categNum.Location = New System.Drawing.Point(62, 21)
        categNum.Size = New System.Drawing.Size(113, 17)
        categNum.TextAlign = ContentAlignment.MiddleCenter
        categNum.Text = numberRow.ToString()

        Dim categName As New Label()
        categName.AutoSize = True
        categName.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        categName.ForeColor = System.Drawing.Color.DimGray
        categName.Location = New System.Drawing.Point(500, 21)
        categName.Size = New System.Drawing.Size(113, 17)
        categName.TextAlign = ContentAlignment.MiddleCenter
        categName.Text = reader("name")

        Dim editBtn = New System.Windows.Forms.Button()
        editBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(158, Byte), Integer), CType(CType(155, Byte), Integer), CType(CType(54, Byte), Integer))
        editBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        editBtn.CausesValidation = False
        editBtn.FlatAppearance.BorderSize = 0
        editBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(2, Byte), Integer), CType(CType(0, Byte), Integer))
        editBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        editBtn.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        editBtn.ForeColor = System.Drawing.Color.White
        editBtn.Location = New System.Drawing.Point(893, 12)
        editBtn.Name = "Button3"
        editBtn.Size = New System.Drawing.Size(69, 35)
        editBtn.Text = "EDIT"
        editBtn.UseVisualStyleBackColor = False
        editBtn.Tag = reader("id")
        AddHandler editBtn.Click, AddressOf editBtn_Click

        Dim deleteBtn = New System.Windows.Forms.Button()
        deleteBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(2, Byte), Integer), CType(CType(0, Byte), Integer))
        deleteBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        deleteBtn.CausesValidation = False
        deleteBtn.FlatAppearance.BorderSize = 0
        deleteBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(2, Byte), Integer), CType(CType(0, Byte), Integer))
        deleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        deleteBtn.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        deleteBtn.ForeColor = System.Drawing.Color.White
        deleteBtn.Location = New System.Drawing.Point(968, 12)
        deleteBtn.Name = "Button4"
        deleteBtn.Size = New System.Drawing.Size(69, 35)
        deleteBtn.Text = "DELETE"
        deleteBtn.UseVisualStyleBackColor = False
        deleteBtn.Tag = reader("id")
        AddHandler deleteBtn.Click, AddressOf deleteBtn_Click

        categPane.Controls.Add(categNum)
        categPane.Controls.Add(categName)
        categPane.Controls.Add(editBtn)
        categPane.Controls.Add(deleteBtn)
        flowLayout.Controls.Add(categPane)
    End Sub


    Private Sub cancelAddCategoryBtn_Click(sender As Object, e As EventArgs) Handles cancelAddCategoryBtn.Click
        backdrop.Hide()
        createCategoryFormPane.Hide()
    End Sub

    Private Sub cancelEditCategBtn_Click(sender As Object, e As EventArgs) Handles cancelEditCategBtn.Click
        backdrop.Hide()
        editCategoryFormPane.Hide()
    End Sub
   
End Class
