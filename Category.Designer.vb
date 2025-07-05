<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Category
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.flowLayout = New System.Windows.Forms.FlowLayoutPanel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.deleteBtn = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.updateBtn = New System.Windows.Forms.Button()
        Me.noCategory = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.editBtn = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.createCategoryName = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.prdTab = New System.Windows.Forms.Panel()
        Me.searchFilterCategoryName = New System.Windows.Forms.TextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.editCategoryFormPane = New System.Windows.Forms.Panel()
        Me.Panel13 = New System.Windows.Forms.Panel()
        Me.editCategoryName = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.PictureBox12 = New System.Windows.Forms.PictureBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.updateCategoryBtn = New System.Windows.Forms.Button()
        Me.cancelEditCategBtn = New System.Windows.Forms.Button()
        Me.createCategoryFormPane = New System.Windows.Forms.Panel()
        Me.Panel12 = New System.Windows.Forms.Panel()
        Me.editCategoryNameField = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.PictureBox6 = New System.Windows.Forms.PictureBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.createCategoryBtn = New System.Windows.Forms.Button()
        Me.cancelAddCategoryBtn = New System.Windows.Forms.Button()
        Me.backdrop = New System.Windows.Forms.Panel()
        Me.flowLayout.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.prdTab.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.editCategoryFormPane.SuspendLayout()
        Me.Panel13.SuspendLayout()
        CType(Me.PictureBox12, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.createCategoryFormPane.SuspendLayout()
        Me.Panel12.SuspendLayout()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.backdrop.SuspendLayout()
        Me.SuspendLayout()
        '
        'flowLayout
        '
        Me.flowLayout.AutoScroll = True
        Me.flowLayout.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.flowLayout.BackColor = System.Drawing.Color.White
        Me.flowLayout.Controls.Add(Me.Panel1)
        Me.flowLayout.Location = New System.Drawing.Point(49, 174)
        Me.flowLayout.Name = "flowLayout"
        Me.flowLayout.Padding = New System.Windows.Forms.Padding(5)
        Me.flowLayout.Size = New System.Drawing.Size(861, 500)
        Me.flowLayout.TabIndex = 2
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.editBtn)
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Controls.Add(Me.noCategory)
        Me.Panel1.Controls.Add(Me.updateBtn)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.deleteBtn)
        Me.Panel1.Location = New System.Drawing.Point(8, 8)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(845, 58)
        Me.Panel1.TabIndex = 0
        '
        'deleteBtn
        '
        Me.deleteBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(2, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.deleteBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.deleteBtn.CausesValidation = False
        Me.deleteBtn.FlatAppearance.BorderSize = 0
        Me.deleteBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(2, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.deleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.deleteBtn.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.deleteBtn.ForeColor = System.Drawing.Color.White
        Me.deleteBtn.Location = New System.Drawing.Point(968, 12)
        Me.deleteBtn.Name = "deleteBtn"
        Me.deleteBtn.Size = New System.Drawing.Size(69, 35)
        Me.deleteBtn.TabIndex = 8
        Me.deleteBtn.Text = "DELETE"
        Me.deleteBtn.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.Label1.ForeColor = System.Drawing.Color.DimGray
        Me.Label1.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Label1.Location = New System.Drawing.Point(339, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(113, 17)
        Me.Label1.TabIndex = 7
        Me.Label1.Tag = "categorName"
        Me.Label1.Text = "Category Name"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'updateBtn
        '
        Me.updateBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(158, Byte), Integer), CType(CType(155, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.updateBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.updateBtn.CausesValidation = False
        Me.updateBtn.FlatAppearance.BorderSize = 0
        Me.updateBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(2, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.updateBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.updateBtn.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.updateBtn.ForeColor = System.Drawing.Color.White
        Me.updateBtn.Location = New System.Drawing.Point(893, 12)
        Me.updateBtn.Name = "updateBtn"
        Me.updateBtn.Size = New System.Drawing.Size(69, 35)
        Me.updateBtn.TabIndex = 9
        Me.updateBtn.Text = "UPDATE"
        Me.updateBtn.UseVisualStyleBackColor = False
        '
        'noCategory
        '
        Me.noCategory.AutoSize = True
        Me.noCategory.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.noCategory.ForeColor = System.Drawing.Color.DimGray
        Me.noCategory.Location = New System.Drawing.Point(62, 21)
        Me.noCategory.Name = "noCategory"
        Me.noCategory.Size = New System.Drawing.Size(15, 17)
        Me.noCategory.TabIndex = 10
        Me.noCategory.Text = "1"
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(2, Byte), Integer))
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Button2.CausesValidation = False
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(2, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.White
        Me.Button2.Location = New System.Drawing.Point(738, 12)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(89, 35)
        Me.Button2.TabIndex = 29
        Me.Button2.Text = "DELETE"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'editBtn
        '
        Me.editBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(158, Byte), Integer), CType(CType(155, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.editBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.editBtn.CausesValidation = False
        Me.editBtn.FlatAppearance.BorderSize = 0
        Me.editBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(2, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.editBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.editBtn.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.editBtn.ForeColor = System.Drawing.Color.White
        Me.editBtn.Location = New System.Drawing.Point(632, 12)
        Me.editBtn.Name = "editBtn"
        Me.editBtn.Size = New System.Drawing.Size(89, 35)
        Me.editBtn.TabIndex = 30
        Me.editBtn.Text = "UPDATE"
        Me.editBtn.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Red
        Me.Label4.Location = New System.Drawing.Point(42, 51)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(186, 38)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Categories"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.Label8.ForeColor = System.Drawing.Color.DimGray
        Me.Label8.Location = New System.Drawing.Point(408, 145)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(69, 17)
        Me.Label8.TabIndex = 6
        Me.Label8.Text = "Category"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.Label2.ForeColor = System.Drawing.Color.DimGray
        Me.Label2.Location = New System.Drawing.Point(759, 145)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(50, 17)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Action"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.Label3.ForeColor = System.Drawing.Color.DimGray
        Me.Label3.Location = New System.Drawing.Point(114, 154)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(27, 17)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "No"
        '
        'createCategoryName
        '
        Me.createCategoryName.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(158, Byte), Integer))
        Me.createCategoryName.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.createCategoryName.CausesValidation = False
        Me.createCategoryName.FlatAppearance.BorderSize = 0
        Me.createCategoryName.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(2, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.createCategoryName.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.createCategoryName.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.createCategoryName.ForeColor = System.Drawing.Color.White
        Me.createCategoryName.Location = New System.Drawing.Point(773, 97)
        Me.createCategoryName.Name = "createCategoryName"
        Me.createCategoryName.Size = New System.Drawing.Size(129, 35)
        Me.createCategoryName.TabIndex = 21
        Me.createCategoryName.Text = "CREATE"
        Me.createCategoryName.UseVisualStyleBackColor = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.Label6.ForeColor = System.Drawing.Color.DimGray
        Me.Label6.Location = New System.Drawing.Point(49, 97)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(119, 17)
        Me.Label6.TabIndex = 22
        Me.Label6.Text = "List of Categories"
        '
        'prdTab
        '
        Me.prdTab.AutoSize = True
        Me.prdTab.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.prdTab.BackColor = System.Drawing.Color.AliceBlue
        Me.prdTab.Controls.Add(Me.backdrop)
        Me.prdTab.Controls.Add(Me.Label6)
        Me.prdTab.Controls.Add(Me.createCategoryName)
        Me.prdTab.Controls.Add(Me.Panel2)
        Me.prdTab.Controls.Add(Me.Label3)
        Me.prdTab.Controls.Add(Me.Label2)
        Me.prdTab.Controls.Add(Me.Label8)
        Me.prdTab.Controls.Add(Me.Label4)
        Me.prdTab.Controls.Add(Me.flowLayout)
        Me.prdTab.Dock = System.Windows.Forms.DockStyle.Fill
        Me.prdTab.Location = New System.Drawing.Point(0, 0)
        Me.prdTab.Name = "prdTab"
        Me.prdTab.Size = New System.Drawing.Size(950, 725)
        Me.prdTab.TabIndex = 29
        '
        'searchFilterCategoryName
        '
        Me.searchFilterCategoryName.BackColor = System.Drawing.Color.WhiteSmoke
        Me.searchFilterCategoryName.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.searchFilterCategoryName.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.searchFilterCategoryName.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.searchFilterCategoryName.Location = New System.Drawing.Point(10, 11)
        Me.searchFilterCategoryName.Name = "searchFilterCategoryName"
        Me.searchFilterCategoryName.Size = New System.Drawing.Size(143, 14)
        Me.searchFilterCategoryName.TabIndex = 0
        Me.searchFilterCategoryName.Tag = ""
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.searchFilterCategoryName)
        Me.Panel2.Location = New System.Drawing.Point(605, 97)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(162, 36)
        Me.Panel2.TabIndex = 19
        '
        'editCategoryFormPane
        '
        Me.editCategoryFormPane.BackColor = System.Drawing.Color.White
        Me.editCategoryFormPane.Controls.Add(Me.cancelEditCategBtn)
        Me.editCategoryFormPane.Controls.Add(Me.updateCategoryBtn)
        Me.editCategoryFormPane.Controls.Add(Me.Label14)
        Me.editCategoryFormPane.Controls.Add(Me.PictureBox12)
        Me.editCategoryFormPane.Controls.Add(Me.Label15)
        Me.editCategoryFormPane.Controls.Add(Me.Label16)
        Me.editCategoryFormPane.Controls.Add(Me.Panel13)
        Me.editCategoryFormPane.Location = New System.Drawing.Point(282, 241)
        Me.editCategoryFormPane.Name = "editCategoryFormPane"
        Me.editCategoryFormPane.Size = New System.Drawing.Size(389, 243)
        Me.editCategoryFormPane.TabIndex = 24
        '
        'Panel13
        '
        Me.Panel13.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Panel13.Controls.Add(Me.editCategoryName)
        Me.Panel13.Location = New System.Drawing.Point(17, 105)
        Me.Panel13.Name = "Panel13"
        Me.Panel13.Size = New System.Drawing.Size(361, 36)
        Me.Panel13.TabIndex = 16
        '
        'editCategoryName
        '
        Me.editCategoryName.BackColor = System.Drawing.Color.WhiteSmoke
        Me.editCategoryName.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.editCategoryName.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.editCategoryName.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.editCategoryName.Location = New System.Drawing.Point(16, 9)
        Me.editCategoryName.Name = "editCategoryName"
        Me.editCategoryName.Size = New System.Drawing.Size(329, 14)
        Me.editCategoryName.TabIndex = 0
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(17, 85)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(48, 17)
        Me.Label16.TabIndex = 1
        Me.Label16.Text = "Name"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Century Gothic", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(2, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label15.Location = New System.Drawing.Point(49, 14)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(170, 28)
        Me.Label15.TabIndex = 2
        Me.Label15.Text = "Edit Category"
        '
        'PictureBox12
        '
        Me.PictureBox12.Location = New System.Drawing.Point(20, 16)
        Me.PictureBox12.Name = "PictureBox12"
        Me.PictureBox12.Size = New System.Drawing.Size(26, 22)
        Me.PictureBox12.TabIndex = 4
        Me.PictureBox12.TabStop = False
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.DimGray
        Me.Label14.Location = New System.Drawing.Point(17, 47)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(166, 17)
        Me.Label14.TabIndex = 5
        Me.Label14.Text = "Editing current Category"
        '
        'updateCategoryBtn
        '
        Me.updateCategoryBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(158, Byte), Integer), CType(CType(155, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.updateCategoryBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.updateCategoryBtn.CausesValidation = False
        Me.updateCategoryBtn.FlatAppearance.BorderSize = 0
        Me.updateCategoryBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(2, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.updateCategoryBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.updateCategoryBtn.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.updateCategoryBtn.ForeColor = System.Drawing.Color.White
        Me.updateCategoryBtn.Location = New System.Drawing.Point(283, 179)
        Me.updateCategoryBtn.Name = "updateCategoryBtn"
        Me.updateCategoryBtn.Size = New System.Drawing.Size(89, 35)
        Me.updateCategoryBtn.TabIndex = 14
        Me.updateCategoryBtn.Text = "UPDATE"
        Me.updateCategoryBtn.UseVisualStyleBackColor = False
        '
        'cancelEditCategBtn
        '
        Me.cancelEditCategBtn.BackColor = System.Drawing.Color.DarkGray
        Me.cancelEditCategBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.cancelEditCategBtn.CausesValidation = False
        Me.cancelEditCategBtn.FlatAppearance.BorderSize = 0
        Me.cancelEditCategBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(2, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.cancelEditCategBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cancelEditCategBtn.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cancelEditCategBtn.ForeColor = System.Drawing.Color.White
        Me.cancelEditCategBtn.Location = New System.Drawing.Point(177, 179)
        Me.cancelEditCategBtn.Name = "cancelEditCategBtn"
        Me.cancelEditCategBtn.Size = New System.Drawing.Size(89, 35)
        Me.cancelEditCategBtn.TabIndex = 15
        Me.cancelEditCategBtn.Text = "CANCEL"
        Me.cancelEditCategBtn.UseVisualStyleBackColor = False
        '
        'createCategoryFormPane
        '
        Me.createCategoryFormPane.BackColor = System.Drawing.Color.White
        Me.createCategoryFormPane.Controls.Add(Me.cancelAddCategoryBtn)
        Me.createCategoryFormPane.Controls.Add(Me.createCategoryBtn)
        Me.createCategoryFormPane.Controls.Add(Me.Label5)
        Me.createCategoryFormPane.Controls.Add(Me.PictureBox6)
        Me.createCategoryFormPane.Controls.Add(Me.Label7)
        Me.createCategoryFormPane.Controls.Add(Me.Label13)
        Me.createCategoryFormPane.Controls.Add(Me.Panel12)
        Me.createCategoryFormPane.Location = New System.Drawing.Point(281, 241)
        Me.createCategoryFormPane.Name = "createCategoryFormPane"
        Me.createCategoryFormPane.Size = New System.Drawing.Size(389, 243)
        Me.createCategoryFormPane.TabIndex = 23
        '
        'Panel12
        '
        Me.Panel12.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Panel12.Controls.Add(Me.editCategoryNameField)
        Me.Panel12.Location = New System.Drawing.Point(17, 105)
        Me.Panel12.Name = "Panel12"
        Me.Panel12.Size = New System.Drawing.Size(361, 36)
        Me.Panel12.TabIndex = 16
        '
        'editCategoryNameField
        '
        Me.editCategoryNameField.BackColor = System.Drawing.Color.WhiteSmoke
        Me.editCategoryNameField.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.editCategoryNameField.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.editCategoryNameField.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.editCategoryNameField.Location = New System.Drawing.Point(16, 9)
        Me.editCategoryNameField.Name = "editCategoryNameField"
        Me.editCategoryNameField.Size = New System.Drawing.Size(329, 14)
        Me.editCategoryNameField.TabIndex = 0
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(17, 85)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(48, 17)
        Me.Label13.TabIndex = 1
        Me.Label13.Text = "Name"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Century Gothic", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(2, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(49, 14)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(209, 28)
        Me.Label7.TabIndex = 2
        Me.Label7.Text = "Create Category"
        '
        'PictureBox6
        '
        Me.PictureBox6.Location = New System.Drawing.Point(20, 16)
        Me.PictureBox6.Name = "PictureBox6"
        Me.PictureBox6.Size = New System.Drawing.Size(26, 22)
        Me.PictureBox6.TabIndex = 4
        Me.PictureBox6.TabStop = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.DimGray
        Me.Label5.Location = New System.Drawing.Point(17, 47)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(162, 17)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Creating new Category"
        '
        'createCategoryBtn
        '
        Me.createCategoryBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(158, Byte), Integer))
        Me.createCategoryBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.createCategoryBtn.CausesValidation = False
        Me.createCategoryBtn.FlatAppearance.BorderSize = 0
        Me.createCategoryBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(2, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.createCategoryBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.createCategoryBtn.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.createCategoryBtn.ForeColor = System.Drawing.Color.White
        Me.createCategoryBtn.Location = New System.Drawing.Point(283, 179)
        Me.createCategoryBtn.Name = "createCategoryBtn"
        Me.createCategoryBtn.Size = New System.Drawing.Size(89, 35)
        Me.createCategoryBtn.TabIndex = 14
        Me.createCategoryBtn.Text = "CREATE"
        Me.createCategoryBtn.UseVisualStyleBackColor = False
        '
        'cancelAddCategoryBtn
        '
        Me.cancelAddCategoryBtn.BackColor = System.Drawing.Color.DarkGray
        Me.cancelAddCategoryBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.cancelAddCategoryBtn.CausesValidation = False
        Me.cancelAddCategoryBtn.FlatAppearance.BorderSize = 0
        Me.cancelAddCategoryBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(2, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.cancelAddCategoryBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cancelAddCategoryBtn.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cancelAddCategoryBtn.ForeColor = System.Drawing.Color.White
        Me.cancelAddCategoryBtn.Location = New System.Drawing.Point(177, 179)
        Me.cancelAddCategoryBtn.Name = "cancelAddCategoryBtn"
        Me.cancelAddCategoryBtn.Size = New System.Drawing.Size(89, 35)
        Me.cancelAddCategoryBtn.TabIndex = 15
        Me.cancelAddCategoryBtn.Text = "CANCEL"
        Me.cancelAddCategoryBtn.UseVisualStyleBackColor = False
        '
        'backdrop
        '
        Me.backdrop.AutoSize = True
        Me.backdrop.BackColor = System.Drawing.Color.AliceBlue
        Me.backdrop.Controls.Add(Me.createCategoryFormPane)
        Me.backdrop.Controls.Add(Me.editCategoryFormPane)
        Me.backdrop.Dock = System.Windows.Forms.DockStyle.Fill
        Me.backdrop.Location = New System.Drawing.Point(0, 0)
        Me.backdrop.Name = "backdrop"
        Me.backdrop.Size = New System.Drawing.Size(950, 725)
        Me.backdrop.TabIndex = 79
        '
        'Category
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Controls.Add(Me.prdTab)
        Me.Name = "Category"
        Me.Size = New System.Drawing.Size(950, 725)
        Me.flowLayout.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.prdTab.ResumeLayout(False)
        Me.prdTab.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.editCategoryFormPane.ResumeLayout(False)
        Me.editCategoryFormPane.PerformLayout()
        Me.Panel13.ResumeLayout(False)
        Me.Panel13.PerformLayout()
        CType(Me.PictureBox12, System.ComponentModel.ISupportInitialize).EndInit()
        Me.createCategoryFormPane.ResumeLayout(False)
        Me.createCategoryFormPane.PerformLayout()
        Me.Panel12.ResumeLayout(False)
        Me.Panel12.PerformLayout()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        Me.backdrop.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents flowLayout As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents editBtn As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents noCategory As System.Windows.Forms.Label
    Friend WithEvents updateBtn As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents deleteBtn As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents createCategoryName As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents prdTab As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents searchFilterCategoryName As System.Windows.Forms.TextBox
    Friend WithEvents backdrop As System.Windows.Forms.Panel
    Friend WithEvents createCategoryFormPane As System.Windows.Forms.Panel
    Friend WithEvents cancelAddCategoryBtn As System.Windows.Forms.Button
    Friend WithEvents createCategoryBtn As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents PictureBox6 As System.Windows.Forms.PictureBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Panel12 As System.Windows.Forms.Panel
    Friend WithEvents editCategoryNameField As System.Windows.Forms.TextBox
    Friend WithEvents editCategoryFormPane As System.Windows.Forms.Panel
    Friend WithEvents cancelEditCategBtn As System.Windows.Forms.Button
    Friend WithEvents updateCategoryBtn As System.Windows.Forms.Button
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents PictureBox12 As System.Windows.Forms.PictureBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Panel13 As System.Windows.Forms.Panel
    Friend WithEvents editCategoryName As System.Windows.Forms.TextBox

End Class
