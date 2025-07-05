Imports System.Data.SqlClient

Public Class Products
    Private productId As String

    Private Sub prdTab_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        flowLayout1.Controls.Clear()
        addProductForm.Hide()
        editProductForm.Hide()
        backdrop.Hide()
        populateProducts()

        Dim radius As Integer = 10
        Dim path As New Drawing2D.GraphicsPath()
        path.AddArc(0, 0, radius, radius, 180, 90)
        path.AddArc(Button7.Width - radius, 0, radius, radius, 270, 90)
        path.AddArc(Button7.Width - radius, Button7.Height - radius, radius, radius, 0, 90)
        path.AddArc(0, Button7.Height - radius, radius, radius, 90, 90)
        path.CloseAllFigures()
        Button7.Region = New Region(path)
    End Sub

    Private Sub populateProducts()
        flowLayout1.Controls.Clear()
        ' Populate Record PRODUCT
        Dim conn As New SqlClient.SqlConnection
        conn.ConnectionString = "server=R3COM8;user id=sa;password=sqlpassword123;Database=sample;"
        Try
            conn.Open()


            Dim query As String = "SELECT c.id AS categ_id, c.name AS categ_name, p.id As id, p.code As code, p.name As name, p.price As price, p.quantity As quantity, p.description As description FROM [dbo].[products] AS p INNER JOIN [dbo].[category] AS c ON p.categoryId = c.id"
            Dim cmd As New SqlCommand(query, conn)
            Dim reader = cmd.ExecuteReader()

            While reader.Read()
                renderComponent(reader)
            End While

        Catch ex As Exception
            MsgBox(ex.ToString())
            MsgBox("Something went wrong. Please try again later!")
            Return
        End Try
    End Sub

    Private Sub searchFilter_TextChanged(sender As Object, e As EventArgs) Handles searchFilter.TextChanged
        filterAndSorting()
    End Sub

    Private Sub sortingFilter_SelectedIndexChanged(sender As Object, e As EventArgs) Handles sortingFilter.SelectedIndexChanged
        filterAndSorting()
    End Sub

    Private Sub filterAndSorting()
        flowLayout1.Controls.Clear()

        Dim conn As New SqlClient.SqlConnection
        conn.ConnectionString = "server=R3COM8;user id=sa;password=sqlpassword123;Database=sample;"

        Dim filterQuery = "%" + searchFilter.Text + "%"

        Try
            conn.Open()
            Dim sort As String
            Select Case sortingFilter.Text
                Case "Category Asc"
                    sort = " ORDER BY c.name ASC"
                Case "Category Desc"
                    sort = "ORDER BY c.name DESC"
                Case "Code Asc"
                    sort = "ORDER BY p.code ASC"
                Case "Code Desc"
                    sort = "ORDER BY p.code DESC"
                Case "Name(Asc)"
                    sort = "ORDER BY p.name ASC"
                Case "Name(Desc)"
                    sort = "ORDER BY p.name DESC"
                Case "Price Asc"
                    sort = "ORDER BY p.price ASC"
                Case "Price Desc"
                    sort = "ORDER BY p.price DESC"
                Case Else
                    sort = ""
            End Select

            Dim query As String = "SELECT c.id AS categ_id, c.name AS categ_name, p.id As id, p.code As code, p.name As name, p.price As price, p.quantity As quantity, p.description As description FROM [dbo].[products] AS p LEFT JOIN [dbo].[category] AS c ON p.categoryId = c.id WHERE p.name LIKE @category OR p.code LIKE @code OR p.name LIKE @name OR p.price LIKE @price OR p.quantity LIKE @quantity OR p.description LIKE @description " & sort
            Dim cmd As New SqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@category", filterQuery)
            cmd.Parameters.AddWithValue("@code", filterQuery)
            cmd.Parameters.AddWithValue("@name", filterQuery)
            cmd.Parameters.AddWithValue("@price", filterQuery)
            cmd.Parameters.AddWithValue("@quantity", filterQuery)
            cmd.Parameters.AddWithValue("@description", filterQuery)

            Dim reader = cmd.ExecuteReader()

            While reader.Read()
                renderComponent(reader)
            End While
        Catch ex As Exception
            MsgBox(ex.ToString())
        End Try
    End Sub

    Public Sub renderComponent(reader As SqlDataReader)

        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Products))
        ' Creating new pane
        Dim productPane As New Panel()
        productPane.Width = 265
        productPane.Height = 478
        productPane.BackColor = Color.White

        ' Code label
        Dim code As New Label()
        code.Text = reader("code")
        code.Font = New Font("Century Gothic", 9.75, FontStyle.Bold)
        code.Location = New Point(197, 28)
        code.AutoEllipsis = True
        code.Size = New Size(45, 30)
        code.UseCompatibleTextRendering = True
        code.TextAlign = ContentAlignment.MiddleRight
        code.ForeColor = Color.DimGray

        Dim PictureBox1 = New System.Windows.Forms.PictureBox()
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        PictureBox1.Location = New System.Drawing.Point(14, 15)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New System.Drawing.Size(239, 232)

        'Category Label
        Dim categoryName As New Label()
        categoryName.Text = reader("categ_name")
        categoryName.Font = New Font("Century Gothic", 9.75)
        categoryName.Location = New Point(17, 253)
        categoryName.ForeColor = Color.DimGray
        categoryName.UseCompatibleTextRendering = True
        categoryName.TextAlign = ContentAlignment.MiddleLeft

        ' Name label
        Dim nameProd As New Label()
        nameProd.Text = reader("name")
        nameProd.Font = New Font("Century Gothic", 14.25, System.Drawing.FontStyle.Bold)
        nameProd.Location = New Point(13, 275)
        nameProd.AutoSize = True
        nameProd.ForeColor = Color.DimGray
        nameProd.UseCompatibleTextRendering = True
        nameProd.TextAlign = ContentAlignment.MiddleLeft

        ' Stocks label
        Dim Label8 As New Label()
        Label8.AutoSize = True
        Label8.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Label8.ForeColor = System.Drawing.Color.DimGray
        Label8.Location = New System.Drawing.Point(14, 311)
        Label8.Name = "Label8"
        Label8.Size = New System.Drawing.Size(14, 311)
        Label8.TabIndex = 5
        Label8.Text = "Stocks"


        ''Description Title Label (Undecided whether to add or not)
        'Dim Label7 As New Label()
        'Label7.AutoSize = True
        'Label7.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        'Label7.ForeColor = System.Drawing.Color.DimGray
        'Label7.Location = New System.Drawing.Point(14, 349)
        'Label7.Name = "Label7"
        'Label7.Size = New System.Drawing.Size(80, 17)
        'Label7.TabIndex = 4
        'Label7.Text = "Description"

        'Stocks label
        Dim stocks As New Label()
        stocks.Text = reader("quantity")
        stocks.Font = New Font("Century Gothic", 9.75, System.Drawing.FontStyle.Bold)
        stocks.AutoSize = True
        stocks.Location = New Point(68, 312)
        stocks.ForeColor = Color.DimGray

        ' Description label
        Dim description As New Label()
        description.Text = reader("description")
        description.Font = New Font("Century Gothic", 9.75)
        description.AutoSize = True
        description.Location = New Point(14, 375)
        description.ForeColor = Color.DimGray

        ' Unit Price Title Label
        Dim Label6 As New Label()
        Label6.AutoSize = True
        Label6.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Label6.ForeColor = System.Drawing.Color.DimGray
        Label6.Location = New System.Drawing.Point(186, 257)
        Label6.Name = "Label6"
        Label6.Size = New System.Drawing.Size(67, 17)
        Label6.TabIndex = 3
        Label6.Text = "Unit Price"

        ' Price label
        Dim price As New Label()
        price.Text = reader("price")
        price.Font = New Font("Century Gothic", 18, System.Drawing.FontStyle.Bold)
        price.Location = New Point(134, 274)
        price.Size = New Size(119, 36)
        price.UseCompatibleTextRendering = True
        price.TextAlign = ContentAlignment.MiddleRight
        price.ForeColor = Color.DimGray

        Dim editBtn = New System.Windows.Forms.Button()
        editBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(158, Byte), Integer), CType(CType(155, Byte), Integer), CType(CType(54, Byte), Integer))
        editBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        editBtn.CausesValidation = False
        editBtn.FlatAppearance.BorderSize = 0
        editBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(2, Byte), Integer), CType(CType(0, Byte), Integer))
        editBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        editBtn.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        editBtn.ForeColor = System.Drawing.Color.White
        editBtn.Location = New System.Drawing.Point(17, 429)
        editBtn.Name = "Button3"
        editBtn.Size = New System.Drawing.Size(114, 35)
        editBtn.TabIndex = 6
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
        deleteBtn.Location = New System.Drawing.Point(139, 429)
        deleteBtn.Name = "Button4"
        deleteBtn.Size = New System.Drawing.Size(114, 35)
        deleteBtn.TabIndex = 7
        deleteBtn.Text = "DELETE"
        deleteBtn.UseVisualStyleBackColor = False
        deleteBtn.Tag = reader("id")
        AddHandler deleteBtn.Click, AddressOf deleteBtn_Click

        ' Add controls to card
        productPane.Controls.Add(code)
        productPane.Controls.Add(PictureBox1)
        productPane.Controls.Add(categoryName)
        productPane.Controls.Add(nameProd)
        productPane.Controls.Add(stocks)
        productPane.Controls.Add(description)
        productPane.Controls.Add(price)
        productPane.Controls.Add(Label6)
        productPane.Controls.Add(Label8)
        productPane.Controls.Add(editBtn)
        productPane.Controls.Add(deleteBtn)

        ' Add card to FlowLayoutPanel
        flowLayout1.Controls.Add(productPane)

    End Sub

    Private Sub deleteBtn_Click(sender As Object, e As EventArgs)
        Dim btn As Button = CType(sender, Button)
        Dim productId As String = btn.Tag.ToString()

        Dim conn As New SqlClient.SqlConnection
        conn.ConnectionString = "server=R3COM8;user id=sa;password=sqlpassword123;Database=sample;"

        Try
            conn.Open()
            Dim stmt As String = "DELETE FROM [dbo].[products] WHERE id=@id"
            Dim cmd As New SqlCommand(stmt, conn)
            cmd.Parameters.AddWithValue("@id", productId.ToString())
            cmd.ExecuteNonQuery()

        Catch ex As Exception
            MsgBox(ex.ToString(), MsgBoxStyle.Exclamation)
        End Try
        populateProducts()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        backdrop.Show()
        addProductForm.Show()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim conn As New SqlClient.SqlConnection
        conn.ConnectionString = "server=R3COM8;user id=sa;password=sqlpassword123;Database=sample"

        Try
            conn.Open()
            Dim stmt As String = "INSERT INTO [dbo].[products] (code, name, price, quantity, description, categoryId) VALUES (@code, @name, @price, @quantity, @description, @categoryId)"
            Dim cmd As New SqlCommand(stmt, conn)

            cmd.Parameters.AddWithValue("@code", addCode.Text)
            cmd.Parameters.AddWithValue("@name", addName.Text)
            cmd.Parameters.AddWithValue("@price", CType(addPrice.Text, Decimal))
            cmd.Parameters.AddWithValue("@quantity", CType(addQty.Text, Integer))
            cmd.Parameters.AddWithValue("@description", addDescription.Text)
            cmd.Parameters.AddWithValue("@categoryId", 1)

            cmd.ExecuteNonQuery()

        Catch ex As Exception
            MsgBox(ex.ToString(), MsgBoxStyle.Exclamation)
        End Try
        backdrop.Hide()
        addProductForm.Hide()
        populateProducts()
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        backdrop.Hide()
        editProductForm.Hide()
    End Sub

    Private Sub updateBtn_Click(sender As Object, e As EventArgs) Handles updateBtn.Click
        Dim conn As New SqlClient.SqlConnection
        conn.ConnectionString = "server=R3COM8;user id=sa;password=sqlpassword123;Database=sample;"

        Try
            conn.Open()
            Dim stmt As String = "UPDATE [dbo].[products] SET code=@code, name=@name, price=@price, quantity=@quantity, description=@description WHERE id=@id"
            Dim cmd As New SqlCommand(stmt, conn)

            cmd.Parameters.AddWithValue("@code", editCode.Text)
            cmd.Parameters.AddWithValue("@name", editName.Text)
            cmd.Parameters.AddWithValue("@price", CType(editPrice.Text, Decimal))
            cmd.Parameters.AddWithValue("@quantity", CType(editQty.Text, Integer))
            cmd.Parameters.AddWithValue("@description", editDescription.Text)
            cmd.Parameters.AddWithValue("@id", productId)
            cmd.ExecuteNonQuery()

        Catch ex As Exception
            MsgBox(ex.ToString(), MsgBoxStyle.Exclamation)
        End Try
        backdrop.Hide()
        editProductForm.Hide()
        populateProducts()
    End Sub

    Private Sub editBtn_Click(sender As Object, e As EventArgs)
        backdrop.Show()
        editProductForm.Show()
        Dim btn As Button = CType(sender, Button)
        productId = btn.Tag.ToString()

        Dim conn As New SqlClient.SqlConnection
        conn.ConnectionString = "server=R3COM8;user id=sa;password=sqlpassword123;Database=sample;"
        Try
            conn.Open()
            Dim query As String = "SELECT * FROM [dbo].[products] AS p JOIN [dbo].[category] AS c ON p.categoryId = c.id WHERE p.id=@id"
            Dim cmd As New SqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@id", productId)
            Dim reader = cmd.ExecuteReader()
            While reader.Read()
                editCode.Text = reader("code")
                editName.Text = reader("name")
                editQty.Text = reader("quantity")
                editPrice.Text = reader("price")
                editDescription.Text = reader("description")
            End While

        Catch ex As Exception
            MsgBox("Something went wrong. Please try again later!")
        End Try

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Exporter.ExportToExcel()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        backdrop.Hide()
        addProductForm.Hide()
    End Sub

End Class
