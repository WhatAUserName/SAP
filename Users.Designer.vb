<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Users
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Users))
        Me.Label30 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.userTable = New System.Windows.Forms.DataGridView()
        Me.userAddBtn = New System.Windows.Forms.Button()
        Me.addUserFormPane = New System.Windows.Forms.Panel()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Panel13 = New System.Windows.Forms.Panel()
        Me.addUserGender = New System.Windows.Forms.ComboBox()
        Me.Panel12 = New System.Windows.Forms.Panel()
        Me.addOccupation = New System.Windows.Forms.ComboBox()
        Me.editFullname = New System.Windows.Forms.Panel()
        Me.addUserFullname = New System.Windows.Forms.TextBox()
        Me.editPassword = New System.Windows.Forms.Panel()
        Me.addUserPassword = New System.Windows.Forms.TextBox()
        Me.cancelAddUserBtn = New System.Windows.Forms.Button()
        Me.addNewUserBtn = New System.Windows.Forms.Button()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.editUsername = New System.Windows.Forms.Panel()
        Me.addUserUsername = New System.Windows.Forms.TextBox()
        Me.Panel14 = New System.Windows.Forms.Panel()
        Me.addDateOfBirth = New System.Windows.Forms.DateTimePicker()
        Me.editUserFormPane = New System.Windows.Forms.Panel()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.Panel20 = New System.Windows.Forms.Panel()
        Me.editUserBirthday = New System.Windows.Forms.DateTimePicker()
        Me.Panel15 = New System.Windows.Forms.Panel()
        Me.editUserGender = New System.Windows.Forms.ComboBox()
        Me.Panel16 = New System.Windows.Forms.Panel()
        Me.editUserOccupation = New System.Windows.Forms.ComboBox()
        Me.Panel17 = New System.Windows.Forms.Panel()
        Me.editUserFullname = New System.Windows.Forms.TextBox()
        Me.Panel18 = New System.Windows.Forms.Panel()
        Me.editUserPassword = New System.Windows.Forms.TextBox()
        Me.cancelEditUserBtn = New System.Windows.Forms.Button()
        Me.editCurrentUserBtn = New System.Windows.Forms.Button()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Panel19 = New System.Windows.Forms.Panel()
        Me.editUserUsername = New System.Windows.Forms.TextBox()
        Me.deleteModal = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.Label = New System.Windows.Forms.Label()
        Me.usersTab = New System.Windows.Forms.Panel()
        CType(Me.userTable, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.addUserFormPane.SuspendLayout()
        Me.Panel13.SuspendLayout()
        Me.Panel12.SuspendLayout()
        Me.editFullname.SuspendLayout()
        Me.editPassword.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.editUsername.SuspendLayout()
        Me.Panel14.SuspendLayout()
        Me.editUserFormPane.SuspendLayout()
        Me.Panel20.SuspendLayout()
        Me.Panel15.SuspendLayout()
        Me.Panel16.SuspendLayout()
        Me.Panel17.SuspendLayout()
        Me.Panel18.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel19.SuspendLayout()
        Me.deleteModal.SuspendLayout()
        Me.usersTab.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label30.ForeColor = System.Drawing.SystemColors.MenuText
        Me.Label30.Location = New System.Drawing.Point(3, 611)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(292, 105)
        Me.Label30.TabIndex = 24
        Me.Label30.Text = resources.GetString("Label30.Text")
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Century Gothic", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.Red
        Me.Label17.Location = New System.Drawing.Point(48, 35)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(95, 38)
        Me.Label17.TabIndex = 0
        Me.Label17.Text = "Users"
        '
        'userTable
        '
        Me.userTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.userTable.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.userTable.BackgroundColor = System.Drawing.Color.AliceBlue
        Me.userTable.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.userTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.userTable.Location = New System.Drawing.Point(58, 89)
        Me.userTable.Name = "userTable"
        Me.userTable.Size = New System.Drawing.Size(796, 401)
        Me.userTable.TabIndex = 2
        '
        'userAddBtn
        '
        Me.userAddBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(158, Byte), Integer))
        Me.userAddBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.userAddBtn.CausesValidation = False
        Me.userAddBtn.FlatAppearance.BorderSize = 0
        Me.userAddBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(2, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.userAddBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.userAddBtn.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.userAddBtn.ForeColor = System.Drawing.Color.White
        Me.userAddBtn.Location = New System.Drawing.Point(765, 38)
        Me.userAddBtn.Name = "userAddBtn"
        Me.userAddBtn.Size = New System.Drawing.Size(89, 35)
        Me.userAddBtn.TabIndex = 3
        Me.userAddBtn.Text = "CREATE"
        Me.userAddBtn.UseVisualStyleBackColor = False
        '
        'addUserFormPane
        '
        Me.addUserFormPane.BackColor = System.Drawing.Color.White
        Me.addUserFormPane.Controls.Add(Me.Label26)
        Me.addUserFormPane.Controls.Add(Me.Panel13)
        Me.addUserFormPane.Controls.Add(Me.Panel12)
        Me.addUserFormPane.Controls.Add(Me.editFullname)
        Me.addUserFormPane.Controls.Add(Me.editPassword)
        Me.addUserFormPane.Controls.Add(Me.cancelAddUserBtn)
        Me.addUserFormPane.Controls.Add(Me.addNewUserBtn)
        Me.addUserFormPane.Controls.Add(Me.Label18)
        Me.addUserFormPane.Controls.Add(Me.Label16)
        Me.addUserFormPane.Controls.Add(Me.Label15)
        Me.addUserFormPane.Controls.Add(Me.Label14)
        Me.addUserFormPane.Controls.Add(Me.Label13)
        Me.addUserFormPane.Controls.Add(Me.PictureBox2)
        Me.addUserFormPane.Controls.Add(Me.Label2)
        Me.addUserFormPane.Controls.Add(Me.Label1)
        Me.addUserFormPane.Controls.Add(Me.editUsername)
        Me.addUserFormPane.Controls.Add(Me.Panel14)
        Me.addUserFormPane.Location = New System.Drawing.Point(281, 69)
        Me.addUserFormPane.Name = "addUserFormPane"
        Me.addUserFormPane.Size = New System.Drawing.Size(389, 580)
        Me.addUserFormPane.TabIndex = 6
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.Location = New System.Drawing.Point(17, 443)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(59, 17)
        Me.Label26.TabIndex = 23
        Me.Label26.Text = "Birthday"
        '
        'Panel13
        '
        Me.Panel13.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Panel13.Controls.Add(Me.addUserGender)
        Me.Panel13.Location = New System.Drawing.Point(17, 391)
        Me.Panel13.Name = "Panel13"
        Me.Panel13.Size = New System.Drawing.Size(361, 36)
        Me.Panel13.TabIndex = 20
        '
        'addUserGender
        '
        Me.addUserGender.BackColor = System.Drawing.Color.WhiteSmoke
        Me.addUserGender.Font = New System.Drawing.Font("Century Gothic", 8.25!)
        Me.addUserGender.FormattingEnabled = True
        Me.addUserGender.Items.AddRange(New Object() {"Male", "Female", "Others"})
        Me.addUserGender.Location = New System.Drawing.Point(0, 6)
        Me.addUserGender.Name = "addUserGender"
        Me.addUserGender.Size = New System.Drawing.Size(361, 24)
        Me.addUserGender.TabIndex = 27
        '
        'Panel12
        '
        Me.Panel12.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Panel12.Controls.Add(Me.addOccupation)
        Me.Panel12.Location = New System.Drawing.Point(17, 318)
        Me.Panel12.Name = "Panel12"
        Me.Panel12.Size = New System.Drawing.Size(361, 36)
        Me.Panel12.TabIndex = 19
        '
        'addOccupation
        '
        Me.addOccupation.BackColor = System.Drawing.Color.WhiteSmoke
        Me.addOccupation.Font = New System.Drawing.Font("Century Gothic", 8.25!)
        Me.addOccupation.FormattingEnabled = True
        Me.addOccupation.Items.AddRange(New Object() {"Delivery Helper", "It Support", "Data Encoder", "Programmer"})
        Me.addOccupation.Location = New System.Drawing.Point(0, 6)
        Me.addOccupation.Name = "addOccupation"
        Me.addOccupation.Size = New System.Drawing.Size(361, 24)
        Me.addOccupation.TabIndex = 28
        '
        'editFullname
        '
        Me.editFullname.BackColor = System.Drawing.Color.WhiteSmoke
        Me.editFullname.Controls.Add(Me.addUserFullname)
        Me.editFullname.Location = New System.Drawing.Point(17, 247)
        Me.editFullname.Name = "editFullname"
        Me.editFullname.Size = New System.Drawing.Size(361, 36)
        Me.editFullname.TabIndex = 18
        '
        'addUserFullname
        '
        Me.addUserFullname.BackColor = System.Drawing.Color.WhiteSmoke
        Me.addUserFullname.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.addUserFullname.Font = New System.Drawing.Font("Century Gothic", 8.25!)
        Me.addUserFullname.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.addUserFullname.Location = New System.Drawing.Point(16, 9)
        Me.addUserFullname.Name = "addUserFullname"
        Me.addUserFullname.Size = New System.Drawing.Size(329, 14)
        Me.addUserFullname.TabIndex = 0
        '
        'editPassword
        '
        Me.editPassword.BackColor = System.Drawing.Color.WhiteSmoke
        Me.editPassword.Controls.Add(Me.addUserPassword)
        Me.editPassword.Location = New System.Drawing.Point(17, 180)
        Me.editPassword.Name = "editPassword"
        Me.editPassword.Size = New System.Drawing.Size(361, 36)
        Me.editPassword.TabIndex = 17
        '
        'addUserPassword
        '
        Me.addUserPassword.BackColor = System.Drawing.Color.WhiteSmoke
        Me.addUserPassword.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.addUserPassword.Font = New System.Drawing.Font("Century Gothic", 8.25!)
        Me.addUserPassword.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.addUserPassword.Location = New System.Drawing.Point(16, 9)
        Me.addUserPassword.Name = "addUserPassword"
        Me.addUserPassword.Size = New System.Drawing.Size(329, 14)
        Me.addUserPassword.TabIndex = 0
        Me.addUserPassword.UseSystemPasswordChar = True
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
        Me.cancelAddUserBtn.Location = New System.Drawing.Point(183, 532)
        Me.cancelAddUserBtn.Name = "cancelAddUserBtn"
        Me.cancelAddUserBtn.Size = New System.Drawing.Size(89, 35)
        Me.cancelAddUserBtn.TabIndex = 15
        Me.cancelAddUserBtn.Text = "CANCEL"
        Me.cancelAddUserBtn.UseVisualStyleBackColor = False
        '
        'addNewUserBtn
        '
        Me.addNewUserBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(158, Byte), Integer))
        Me.addNewUserBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.addNewUserBtn.CausesValidation = False
        Me.addNewUserBtn.FlatAppearance.BorderSize = 0
        Me.addNewUserBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(2, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.addNewUserBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.addNewUserBtn.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.addNewUserBtn.ForeColor = System.Drawing.Color.White
        Me.addNewUserBtn.Location = New System.Drawing.Point(289, 532)
        Me.addNewUserBtn.Name = "addNewUserBtn"
        Me.addNewUserBtn.Size = New System.Drawing.Size(89, 35)
        Me.addNewUserBtn.TabIndex = 14
        Me.addNewUserBtn.Text = "ADD"
        Me.addNewUserBtn.UseVisualStyleBackColor = False
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(17, 369)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(56, 17)
        Me.Label18.TabIndex = 13
        Me.Label18.Text = "Gender"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(17, 298)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(86, 17)
        Me.Label16.TabIndex = 11
        Me.Label16.Text = "Occupation"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(17, 227)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(72, 17)
        Me.Label15.TabIndex = 9
        Me.Label15.Text = "Full Name"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(17, 156)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(69, 17)
        Me.Label14.TabIndex = 7
        Me.Label14.Text = "Password"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.DimGray
        Me.Label13.Location = New System.Drawing.Point(17, 47)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(126, 17)
        Me.Label13.TabIndex = 5
        Me.Label13.Text = "Creating new user"
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(20, 16)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(26, 22)
        Me.PictureBox2.TabIndex = 4
        Me.PictureBox2.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(2, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(49, 14)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(177, 28)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Add New User"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(17, 85)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(71, 17)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Username"
        '
        'editUsername
        '
        Me.editUsername.BackColor = System.Drawing.Color.WhiteSmoke
        Me.editUsername.Controls.Add(Me.addUserUsername)
        Me.editUsername.Location = New System.Drawing.Point(17, 105)
        Me.editUsername.Name = "editUsername"
        Me.editUsername.Size = New System.Drawing.Size(361, 36)
        Me.editUsername.TabIndex = 16
        '
        'addUserUsername
        '
        Me.addUserUsername.BackColor = System.Drawing.Color.WhiteSmoke
        Me.addUserUsername.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.addUserUsername.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.addUserUsername.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.addUserUsername.Location = New System.Drawing.Point(16, 9)
        Me.addUserUsername.Name = "addUserUsername"
        Me.addUserUsername.Size = New System.Drawing.Size(329, 14)
        Me.addUserUsername.TabIndex = 0
        '
        'Panel14
        '
        Me.Panel14.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Panel14.Controls.Add(Me.addDateOfBirth)
        Me.Panel14.Location = New System.Drawing.Point(17, 463)
        Me.Panel14.Name = "Panel14"
        Me.Panel14.Size = New System.Drawing.Size(361, 36)
        Me.Panel14.TabIndex = 22
        '
        'addDateOfBirth
        '
        Me.addDateOfBirth.CalendarForeColor = System.Drawing.Color.Black
        Me.addDateOfBirth.CalendarMonthBackground = System.Drawing.Color.Black
        Me.addDateOfBirth.CalendarTitleBackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.addDateOfBirth.CalendarTrailingForeColor = System.Drawing.SystemColors.ControlText
        Me.addDateOfBirth.Location = New System.Drawing.Point(13, 5)
        Me.addDateOfBirth.Name = "addDateOfBirth"
        Me.addDateOfBirth.Size = New System.Drawing.Size(334, 20)
        Me.addDateOfBirth.TabIndex = 21
        '
        'editUserFormPane
        '
        Me.editUserFormPane.BackColor = System.Drawing.Color.White
        Me.editUserFormPane.Controls.Add(Me.Label27)
        Me.editUserFormPane.Controls.Add(Me.Panel20)
        Me.editUserFormPane.Controls.Add(Me.Panel15)
        Me.editUserFormPane.Controls.Add(Me.Panel16)
        Me.editUserFormPane.Controls.Add(Me.Panel17)
        Me.editUserFormPane.Controls.Add(Me.Panel18)
        Me.editUserFormPane.Controls.Add(Me.cancelEditUserBtn)
        Me.editUserFormPane.Controls.Add(Me.editCurrentUserBtn)
        Me.editUserFormPane.Controls.Add(Me.Label19)
        Me.editUserFormPane.Controls.Add(Me.Label20)
        Me.editUserFormPane.Controls.Add(Me.Label21)
        Me.editUserFormPane.Controls.Add(Me.Label22)
        Me.editUserFormPane.Controls.Add(Me.Label23)
        Me.editUserFormPane.Controls.Add(Me.PictureBox3)
        Me.editUserFormPane.Controls.Add(Me.Label24)
        Me.editUserFormPane.Controls.Add(Me.Label25)
        Me.editUserFormPane.Controls.Add(Me.Panel19)
        Me.editUserFormPane.Location = New System.Drawing.Point(281, 72)
        Me.editUserFormPane.Name = "editUserFormPane"
        Me.editUserFormPane.Size = New System.Drawing.Size(389, 580)
        Me.editUserFormPane.TabIndex = 22
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.Location = New System.Drawing.Point(17, 453)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(59, 17)
        Me.Label27.TabIndex = 25
        Me.Label27.Text = "Birthday"
        '
        'Panel20
        '
        Me.Panel20.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Panel20.Controls.Add(Me.editUserBirthday)
        Me.Panel20.Location = New System.Drawing.Point(17, 473)
        Me.Panel20.Name = "Panel20"
        Me.Panel20.Size = New System.Drawing.Size(361, 36)
        Me.Panel20.TabIndex = 24
        '
        'editUserBirthday
        '
        Me.editUserBirthday.CalendarForeColor = System.Drawing.Color.Black
        Me.editUserBirthday.CalendarMonthBackground = System.Drawing.Color.Black
        Me.editUserBirthday.CalendarTitleBackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.editUserBirthday.CalendarTrailingForeColor = System.Drawing.SystemColors.ControlText
        Me.editUserBirthday.Location = New System.Drawing.Point(13, 5)
        Me.editUserBirthday.Name = "editUserBirthday"
        Me.editUserBirthday.Size = New System.Drawing.Size(334, 20)
        Me.editUserBirthday.TabIndex = 21
        '
        'Panel15
        '
        Me.Panel15.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Panel15.Controls.Add(Me.editUserGender)
        Me.Panel15.Location = New System.Drawing.Point(17, 391)
        Me.Panel15.Name = "Panel15"
        Me.Panel15.Size = New System.Drawing.Size(361, 36)
        Me.Panel15.TabIndex = 20
        '
        'editUserGender
        '
        Me.editUserGender.BackColor = System.Drawing.Color.WhiteSmoke
        Me.editUserGender.Font = New System.Drawing.Font("Century Gothic", 8.25!)
        Me.editUserGender.FormattingEnabled = True
        Me.editUserGender.Items.AddRange(New Object() {"Male", "Female", "Others"})
        Me.editUserGender.Location = New System.Drawing.Point(0, 6)
        Me.editUserGender.Name = "editUserGender"
        Me.editUserGender.Size = New System.Drawing.Size(361, 24)
        Me.editUserGender.TabIndex = 26
        '
        'Panel16
        '
        Me.Panel16.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Panel16.Controls.Add(Me.editUserOccupation)
        Me.Panel16.Location = New System.Drawing.Point(17, 318)
        Me.Panel16.Name = "Panel16"
        Me.Panel16.Size = New System.Drawing.Size(361, 36)
        Me.Panel16.TabIndex = 19
        '
        'editUserOccupation
        '
        Me.editUserOccupation.BackColor = System.Drawing.Color.WhiteSmoke
        Me.editUserOccupation.Font = New System.Drawing.Font("Century Gothic", 8.25!)
        Me.editUserOccupation.FormattingEnabled = True
        Me.editUserOccupation.Items.AddRange(New Object() {"Delivery Helper", "It Support", "Data Encoder", "Programmer"})
        Me.editUserOccupation.Location = New System.Drawing.Point(0, 6)
        Me.editUserOccupation.Name = "editUserOccupation"
        Me.editUserOccupation.Size = New System.Drawing.Size(361, 24)
        Me.editUserOccupation.TabIndex = 27
        '
        'Panel17
        '
        Me.Panel17.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Panel17.Controls.Add(Me.editUserFullname)
        Me.Panel17.Location = New System.Drawing.Point(17, 247)
        Me.Panel17.Name = "Panel17"
        Me.Panel17.Size = New System.Drawing.Size(361, 36)
        Me.Panel17.TabIndex = 18
        '
        'editUserFullname
        '
        Me.editUserFullname.BackColor = System.Drawing.Color.WhiteSmoke
        Me.editUserFullname.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.editUserFullname.Font = New System.Drawing.Font("Century Gothic", 8.25!)
        Me.editUserFullname.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.editUserFullname.Location = New System.Drawing.Point(16, 9)
        Me.editUserFullname.Name = "editUserFullname"
        Me.editUserFullname.Size = New System.Drawing.Size(329, 14)
        Me.editUserFullname.TabIndex = 0
        '
        'Panel18
        '
        Me.Panel18.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Panel18.Controls.Add(Me.editUserPassword)
        Me.Panel18.Location = New System.Drawing.Point(17, 180)
        Me.Panel18.Name = "Panel18"
        Me.Panel18.Size = New System.Drawing.Size(361, 36)
        Me.Panel18.TabIndex = 17
        '
        'editUserPassword
        '
        Me.editUserPassword.BackColor = System.Drawing.Color.WhiteSmoke
        Me.editUserPassword.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.editUserPassword.Font = New System.Drawing.Font("Century Gothic", 8.25!)
        Me.editUserPassword.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.editUserPassword.Location = New System.Drawing.Point(16, 9)
        Me.editUserPassword.Name = "editUserPassword"
        Me.editUserPassword.Size = New System.Drawing.Size(329, 14)
        Me.editUserPassword.TabIndex = 0
        Me.editUserPassword.UseSystemPasswordChar = True
        '
        'cancelEditUserBtn
        '
        Me.cancelEditUserBtn.BackColor = System.Drawing.Color.DarkGray
        Me.cancelEditUserBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.cancelEditUserBtn.CausesValidation = False
        Me.cancelEditUserBtn.FlatAppearance.BorderSize = 0
        Me.cancelEditUserBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(2, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.cancelEditUserBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cancelEditUserBtn.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cancelEditUserBtn.ForeColor = System.Drawing.Color.White
        Me.cancelEditUserBtn.Location = New System.Drawing.Point(183, 532)
        Me.cancelEditUserBtn.Name = "cancelEditUserBtn"
        Me.cancelEditUserBtn.Size = New System.Drawing.Size(89, 35)
        Me.cancelEditUserBtn.TabIndex = 15
        Me.cancelEditUserBtn.Text = "CANCEL"
        Me.cancelEditUserBtn.UseVisualStyleBackColor = False
        '
        'editCurrentUserBtn
        '
        Me.editCurrentUserBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(158, Byte), Integer), CType(CType(155, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.editCurrentUserBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.editCurrentUserBtn.CausesValidation = False
        Me.editCurrentUserBtn.FlatAppearance.BorderSize = 0
        Me.editCurrentUserBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(2, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.editCurrentUserBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.editCurrentUserBtn.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.editCurrentUserBtn.ForeColor = System.Drawing.Color.White
        Me.editCurrentUserBtn.Location = New System.Drawing.Point(289, 532)
        Me.editCurrentUserBtn.Name = "editCurrentUserBtn"
        Me.editCurrentUserBtn.Size = New System.Drawing.Size(89, 35)
        Me.editCurrentUserBtn.TabIndex = 14
        Me.editCurrentUserBtn.Text = "UPDATE"
        Me.editCurrentUserBtn.UseVisualStyleBackColor = False
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(17, 369)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(56, 17)
        Me.Label19.TabIndex = 13
        Me.Label19.Text = "Gender"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(17, 298)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(86, 17)
        Me.Label20.TabIndex = 11
        Me.Label20.Text = "Occupation"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(17, 227)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(72, 17)
        Me.Label21.TabIndex = 9
        Me.Label21.Text = "Full Name"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(17, 156)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(69, 17)
        Me.Label22.TabIndex = 7
        Me.Label22.Text = "Password"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.ForeColor = System.Drawing.Color.DimGray
        Me.Label23.Location = New System.Drawing.Point(17, 47)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(130, 17)
        Me.Label23.TabIndex = 5
        Me.Label23.Text = "Editing current user"
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
        Me.Label24.Size = New System.Drawing.Size(109, 28)
        Me.Label24.TabIndex = 2
        Me.Label24.Text = "Edit User"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.Location = New System.Drawing.Point(17, 85)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(71, 17)
        Me.Label25.TabIndex = 1
        Me.Label25.Text = "Username"
        '
        'Panel19
        '
        Me.Panel19.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Panel19.Controls.Add(Me.editUserUsername)
        Me.Panel19.Location = New System.Drawing.Point(17, 105)
        Me.Panel19.Name = "Panel19"
        Me.Panel19.Size = New System.Drawing.Size(361, 36)
        Me.Panel19.TabIndex = 16
        '
        'editUserUsername
        '
        Me.editUserUsername.BackColor = System.Drawing.Color.WhiteSmoke
        Me.editUserUsername.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.editUserUsername.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.editUserUsername.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.editUserUsername.Location = New System.Drawing.Point(16, 9)
        Me.editUserUsername.Name = "editUserUsername"
        Me.editUserUsername.Size = New System.Drawing.Size(329, 14)
        Me.editUserUsername.TabIndex = 0
        '
        'deleteModal
        '
        Me.deleteModal.BackColor = System.Drawing.Color.White
        Me.deleteModal.Controls.Add(Me.Button1)
        Me.deleteModal.Controls.Add(Me.Button2)
        Me.deleteModal.Controls.Add(Me.Label29)
        Me.deleteModal.Controls.Add(Me.Label28)
        Me.deleteModal.Controls.Add(Me.Label)
        Me.deleteModal.Location = New System.Drawing.Point(314, 244)
        Me.deleteModal.Name = "deleteModal"
        Me.deleteModal.Size = New System.Drawing.Size(323, 237)
        Me.deleteModal.TabIndex = 23
        Me.deleteModal.Visible = False
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
        Me.Button1.Location = New System.Drawing.Point(101, 186)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(89, 35)
        Me.Button1.TabIndex = 17
        Me.Button1.Text = "NO"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(2, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Button2.CausesValidation = False
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(2, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.White
        Me.Button2.Location = New System.Drawing.Point(207, 186)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(89, 35)
        Me.Button2.TabIndex = 16
        Me.Button2.Tag = "productId"
        Me.Button2.Text = "YES"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.Label29.ForeColor = System.Drawing.Color.DimGray
        Me.Label29.Location = New System.Drawing.Point(23, 102)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(242, 34)
        Me.Label29.TabIndex = 2
        Me.Label29.Text = "Are you sure you want to delete this " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "user?" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label28.ForeColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(2, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label28.Location = New System.Drawing.Point(24, 77)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(131, 19)
        Me.Label28.TabIndex = 1
        Me.Label28.Text = "Deletion of Data"
        '
        'Label
        '
        Me.Label.AutoSize = True
        Me.Label.Font = New System.Drawing.Font("Century Gothic", 18.0!, System.Drawing.FontStyle.Bold)
        Me.Label.ForeColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(2, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label.Location = New System.Drawing.Point(21, 34)
        Me.Label.Name = "Label"
        Me.Label.Size = New System.Drawing.Size(108, 28)
        Me.Label.TabIndex = 0
        Me.Label.Text = "Warning"
        '
        'usersTab
        '
        Me.usersTab.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.usersTab.BackColor = System.Drawing.Color.AliceBlue
        Me.usersTab.Controls.Add(Me.deleteModal)
        Me.usersTab.Controls.Add(Me.editUserFormPane)
        Me.usersTab.Controls.Add(Me.addUserFormPane)
        Me.usersTab.Controls.Add(Me.userAddBtn)
        Me.usersTab.Controls.Add(Me.userTable)
        Me.usersTab.Controls.Add(Me.Label17)
        Me.usersTab.Controls.Add(Me.Label30)
        Me.usersTab.Dock = System.Windows.Forms.DockStyle.Fill
        Me.usersTab.Location = New System.Drawing.Point(0, 0)
        Me.usersTab.Name = "usersTab"
        Me.usersTab.Size = New System.Drawing.Size(950, 725)
        Me.usersTab.TabIndex = 17
        '
        'Users
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Controls.Add(Me.usersTab)
        Me.Name = "Users"
        Me.Size = New System.Drawing.Size(950, 725)
        CType(Me.userTable, System.ComponentModel.ISupportInitialize).EndInit()
        Me.addUserFormPane.ResumeLayout(False)
        Me.addUserFormPane.PerformLayout()
        Me.Panel13.ResumeLayout(False)
        Me.Panel12.ResumeLayout(False)
        Me.editFullname.ResumeLayout(False)
        Me.editFullname.PerformLayout()
        Me.editPassword.ResumeLayout(False)
        Me.editPassword.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.editUsername.ResumeLayout(False)
        Me.editUsername.PerformLayout()
        Me.Panel14.ResumeLayout(False)
        Me.editUserFormPane.ResumeLayout(False)
        Me.editUserFormPane.PerformLayout()
        Me.Panel20.ResumeLayout(False)
        Me.Panel15.ResumeLayout(False)
        Me.Panel16.ResumeLayout(False)
        Me.Panel17.ResumeLayout(False)
        Me.Panel17.PerformLayout()
        Me.Panel18.ResumeLayout(False)
        Me.Panel18.PerformLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel19.ResumeLayout(False)
        Me.Panel19.PerformLayout()
        Me.deleteModal.ResumeLayout(False)
        Me.deleteModal.PerformLayout()
        Me.usersTab.ResumeLayout(False)
        Me.usersTab.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents userTable As System.Windows.Forms.DataGridView
    Friend WithEvents userAddBtn As System.Windows.Forms.Button
    Friend WithEvents addUserFormPane As System.Windows.Forms.Panel
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents Panel13 As System.Windows.Forms.Panel
    Friend WithEvents addUserGender As System.Windows.Forms.ComboBox
    Friend WithEvents Panel12 As System.Windows.Forms.Panel
    Friend WithEvents addOccupation As System.Windows.Forms.ComboBox
    Friend WithEvents editFullname As System.Windows.Forms.Panel
    Friend WithEvents addUserFullname As System.Windows.Forms.TextBox
    Friend WithEvents editPassword As System.Windows.Forms.Panel
    Friend WithEvents addUserPassword As System.Windows.Forms.TextBox
    Friend WithEvents cancelAddUserBtn As System.Windows.Forms.Button
    Friend WithEvents addNewUserBtn As System.Windows.Forms.Button
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents editUsername As System.Windows.Forms.Panel
    Friend WithEvents addUserUsername As System.Windows.Forms.TextBox
    Friend WithEvents Panel14 As System.Windows.Forms.Panel
    Friend WithEvents addDateOfBirth As System.Windows.Forms.DateTimePicker
    Friend WithEvents editUserFormPane As System.Windows.Forms.Panel
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents Panel20 As System.Windows.Forms.Panel
    Friend WithEvents editUserBirthday As System.Windows.Forms.DateTimePicker
    Friend WithEvents Panel15 As System.Windows.Forms.Panel
    Friend WithEvents editUserGender As System.Windows.Forms.ComboBox
    Friend WithEvents Panel16 As System.Windows.Forms.Panel
    Friend WithEvents editUserOccupation As System.Windows.Forms.ComboBox
    Friend WithEvents Panel17 As System.Windows.Forms.Panel
    Friend WithEvents editUserFullname As System.Windows.Forms.TextBox
    Friend WithEvents Panel18 As System.Windows.Forms.Panel
    Friend WithEvents editUserPassword As System.Windows.Forms.TextBox
    Friend WithEvents cancelEditUserBtn As System.Windows.Forms.Button
    Friend WithEvents editCurrentUserBtn As System.Windows.Forms.Button
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents Panel19 As System.Windows.Forms.Panel
    Friend WithEvents editUserUsername As System.Windows.Forms.TextBox
    Friend WithEvents deleteModal As System.Windows.Forms.Panel
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents Label As System.Windows.Forms.Label
    Friend WithEvents usersTab As System.Windows.Forms.Panel

End Class
