<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
<Global.System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1726")> _
Partial Class Category
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Category))
        Me.prdTab = New System.Windows.Forms.Panel()
        Me.backdrop = New System.Windows.Forms.Panel()
        Me.createCategoryFormPane = New System.Windows.Forms.Panel()
        Me.cancelAddUserBtn = New System.Windows.Forms.Button()
        Me.createCategoryBtn = New System.Windows.Forms.Button()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Panel19 = New System.Windows.Forms.Panel()
        Me.editCategoryNameField = New System.Windows.Forms.TextBox()
        Me.editCategoryFormPane = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.createCategoryName = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.searchFilterCategoryName = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.flowLayout = New System.Windows.Forms.FlowLayoutPanel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.noCategory = New System.Windows.Forms.Label()
        Me.updateBtn = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.deleteBtn = New System.Windows.Forms.Button()
        Me.prdTab.SuspendLayout()
        Me.backdrop.SuspendLayout()
        Me.createCategoryFormPane.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel19.SuspendLayout()
        Me.editCategoryFormPane.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.flowLayout.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'prdTab
        '
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
        Me.prdTab.Size = New System.Drawing.Size(1184, 761)
        Me.prdTab.TabIndex = 27
        '
        'backdrop
        '
        Me.backdrop.BackColor = System.Drawing.Color.AliceBlue
        Me.backdrop.Controls.Add(Me.createCategoryFormPane)
        Me.backdrop.Controls.Add(Me.editCategoryFormPane)
        Me.backdrop.Dock = System.Windows.Forms.DockStyle.Fill
        Me.backdrop.Location = New System.Drawing.Point(0, 0)
        Me.backdrop.Name = "backdrop"
        Me.backdrop.Size = New System.Drawing.Size(1184, 761)
        Me.backdrop.TabIndex = 54
        '
        'createCategoryFormPane
        '
        Me.createCategoryFormPane.BackColor = System.Drawing.Color.White
        Me.createCategoryFormPane.Controls.Add(Me.cancelAddUserBtn)
        Me.createCategoryFormPane.Controls.Add(Me.createCategoryBtn)
        Me.createCategoryFormPane.Controls.Add(Me.Label23)
        Me.createCategoryFormPane.Controls.Add(Me.PictureBox3)
        Me.createCategoryFormPane.Controls.Add(Me.Label24)
        Me.createCategoryFormPane.Controls.Add(Me.Label25)
        Me.createCategoryFormPane.Controls.Add(Me.Panel19)
        Me.createCategoryFormPane.Location = New System.Drawing.Point(392, 262)
        Me.createCategoryFormPane.Name = "createCategoryFormPane"
        Me.createCategoryFormPane.Size = New System.Drawing.Size(389, 243)
        Me.createCategoryFormPane.TabIndex = 23
        '
        'cancelAddUserBtn
        '
        Me.cancelAddUserBtn.BackColor = System.Drawing.Color.DarkGray
        Me.cancelAddUserBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.cancelAddUserBtn.CausesValidation = False
        Me.cancelAddUserBtn.FlatAppearance.BorderSize = 0
        Me.cancelAddUserBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(2, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.cancelAddUserBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cancelAddUserBtn.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cancelAddUserBtn.ForeColor = System.Drawing.Color.White
        Me.cancelAddUserBtn.Location = New System.Drawing.Point(177, 179)
        Me.cancelAddUserBtn.Name = "cancelAddUserBtn"
        Me.cancelAddUserBtn.Size = New System.Drawing.Size(89, 35)
        Me.cancelAddUserBtn.TabIndex = 15
        Me.cancelAddUserBtn.Text = "CANCEL"
        Me.cancelAddUserBtn.UseVisualStyleBackColor = False
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
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.ForeColor = System.Drawing.Color.DimGray
        Me.Label23.Location = New System.Drawing.Point(17, 47)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(162, 17)
        Me.Label23.TabIndex = 5
        Me.Label23.Text = "Creating new Category"
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(20, 16)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(26, 22)
        Me.PictureBox3.TabIndex = 4
        Me.PictureBox3.TabStop = False
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Century Gothic", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.ForeColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(2, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label24.Location = New System.Drawing.Point(49, 14)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(209, 28)
        Me.Label24.TabIndex = 2
        Me.Label24.Text = "Create Category"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.Location = New System.Drawing.Point(17, 85)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(48, 17)
        Me.Label25.TabIndex = 1
        Me.Label25.Text = "Name"
        '
        'Panel19
        '
        Me.Panel19.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Panel19.Controls.Add(Me.editCategoryNameField)
        Me.Panel19.Location = New System.Drawing.Point(17, 105)
        Me.Panel19.Name = "Panel19"
        Me.Panel19.Size = New System.Drawing.Size(361, 36)
        Me.Panel19.TabIndex = 16
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
        'editCategoryFormPane
        '
        Me.editCategoryFormPane.BackColor = System.Drawing.Color.White
        Me.editCategoryFormPane.Controls.Add(Me.Button1)
        Me.editCategoryFormPane.Controls.Add(Me.Button2)
        Me.editCategoryFormPane.Controls.Add(Me.Label5)
        Me.editCategoryFormPane.Controls.Add(Me.PictureBox1)
        Me.editCategoryFormPane.Controls.Add(Me.Label7)
        Me.editCategoryFormPane.Controls.Add(Me.Label9)
        Me.editCategoryFormPane.Controls.Add(Me.Panel4)
        Me.editCategoryFormPane.Location = New System.Drawing.Point(395, 262)
        Me.editCategoryFormPane.Name = "editCategoryFormPane"
        Me.editCategoryFormPane.Size = New System.Drawing.Size(389, 243)
        Me.editCategoryFormPane.TabIndex = 24
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.DarkGray
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Button1.CausesValidation = False
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(2, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(177, 179)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(89, 35)
        Me.Button1.TabIndex = 15
        Me.Button1.Text = "CANCEL"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(158, Byte), Integer))
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Button2.CausesValidation = False
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(2, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.White
        Me.Button2.Location = New System.Drawing.Point(283, 179)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(89, 35)
        Me.Button2.TabIndex = 14
        Me.Button2.Text = "UPDATE"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.DimGray
        Me.Label5.Location = New System.Drawing.Point(17, 47)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(166, 17)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Editing current Category"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(20, 16)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(26, 22)
        Me.PictureBox1.TabIndex = 4
        Me.PictureBox1.TabStop = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Century Gothic", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(2, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(49, 14)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(170, 28)
        Me.Label7.TabIndex = 2
        Me.Label7.Text = "Edit Category"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(17, 85)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(48, 17)
        Me.Label9.TabIndex = 1
        Me.Label9.Text = "Name"
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Panel4.Controls.Add(Me.TextBox1)
        Me.Panel4.Location = New System.Drawing.Point(17, 105)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(361, 36)
        Me.Panel4.TabIndex = 16
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox1.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.TextBox1.Location = New System.Drawing.Point(16, 9)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(329, 14)
        Me.TextBox1.TabIndex = 0
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.Label6.ForeColor = System.Drawing.Color.DimGray
        Me.Label6.Location = New System.Drawing.Point(60, 77)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(119, 17)
        Me.Label6.TabIndex = 22
        Me.Label6.Text = "List of Categories"
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
        Me.createCategoryName.Location = New System.Drawing.Point(1001, 66)
        Me.createCategoryName.Name = "createCategoryName"
        Me.createCategoryName.Size = New System.Drawing.Size(129, 35)
        Me.createCategoryName.TabIndex = 21
        Me.createCategoryName.Text = "CREATE"
        Me.createCategoryName.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.searchFilterCategoryName)
        Me.Panel2.Location = New System.Drawing.Point(833, 66)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(162, 36)
        Me.Panel2.TabIndex = 19
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
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.Label3.ForeColor = System.Drawing.Color.DimGray
        Me.Label3.Location = New System.Drawing.Point(125, 134)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(27, 17)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "No"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.Label2.ForeColor = System.Drawing.Color.DimGray
        Me.Label2.Location = New System.Drawing.Point(1011, 134)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(50, 17)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Action"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.Label8.ForeColor = System.Drawing.Color.DimGray
        Me.Label8.Location = New System.Drawing.Point(559, 134)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(69, 17)
        Me.Label8.TabIndex = 6
        Me.Label8.Text = "Category"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Red
        Me.Label4.Location = New System.Drawing.Point(53, 31)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(186, 38)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Categories"
        '
        'flowLayout
        '
        Me.flowLayout.BackColor = System.Drawing.Color.White
        Me.flowLayout.Controls.Add(Me.Panel1)
        Me.flowLayout.Location = New System.Drawing.Point(60, 154)
        Me.flowLayout.Name = "flowLayout"
        Me.flowLayout.Padding = New System.Windows.Forms.Padding(5)
        Me.flowLayout.Size = New System.Drawing.Size(1070, 500)
        Me.flowLayout.TabIndex = 2
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.noCategory)
        Me.Panel1.Controls.Add(Me.updateBtn)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.deleteBtn)
        Me.Panel1.Location = New System.Drawing.Point(8, 8)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1053, 58)
        Me.Panel1.TabIndex = 0
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
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.Label1.ForeColor = System.Drawing.Color.DimGray
        Me.Label1.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Label1.Location = New System.Drawing.Point(467, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(113, 17)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Category Name"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
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
        'Category
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1184, 761)
        Me.Controls.Add(Me.prdTab)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Category"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Category"
        Me.prdTab.ResumeLayout(False)
        Me.prdTab.PerformLayout()
        Me.backdrop.ResumeLayout(False)
        Me.createCategoryFormPane.ResumeLayout(False)
        Me.createCategoryFormPane.PerformLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel19.ResumeLayout(False)
        Me.Panel19.PerformLayout()
        Me.editCategoryFormPane.ResumeLayout(False)
        Me.editCategoryFormPane.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.flowLayout.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents prdTab As System.Windows.Forms.Panel
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents createCategoryName As System.Windows.Forms.Button
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents searchFilterCategoryName As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents flowLayout As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents noCategory As System.Windows.Forms.Label
    Friend WithEvents updateBtn As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents deleteBtn As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents createCategoryFormPane As System.Windows.Forms.Panel
    Friend WithEvents cancelAddUserBtn As System.Windows.Forms.Button
    Friend WithEvents createCategoryBtn As System.Windows.Forms.Button
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents Panel19 As System.Windows.Forms.Panel
    Friend WithEvents editCategoryNameField As System.Windows.Forms.TextBox
    Friend WithEvents backdrop As System.Windows.Forms.Panel
    Friend WithEvents editCategoryFormPane As System.Windows.Forms.Panel
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox

End Class
