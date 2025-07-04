<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Profile
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Profile))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.username = New System.Windows.Forms.Label()
        Me.gender = New System.Windows.Forms.Label()
        Me.Label = New System.Windows.Forms.Label()
        Me.occupation = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dateOfBirth = New System.Windows.Forms.Label()
        Me.lab = New System.Windows.Forms.Label()
        Me.userAddBtn = New System.Windows.Forms.Button()
        Me.changeProfilePic = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.occ = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.profPicModal = New System.Windows.Forms.Panel()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.pbMain = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.backdrop = New System.Windows.Forms.Panel()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.profPicModal.SuspendLayout()
        CType(Me.pbMain, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.backdrop.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.Label1.Location = New System.Drawing.Point(120, 226)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(71, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Username"
        '
        'username
        '
        Me.username.AutoSize = True
        Me.username.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.username.Location = New System.Drawing.Point(13, 12)
        Me.username.Name = "username"
        Me.username.Size = New System.Drawing.Size(0, 17)
        Me.username.TabIndex = 1
        '
        'gender
        '
        Me.gender.AutoSize = True
        Me.gender.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.gender.Location = New System.Drawing.Point(13, 9)
        Me.gender.Name = "gender"
        Me.gender.Size = New System.Drawing.Size(0, 17)
        Me.gender.TabIndex = 3
        '
        'Label
        '
        Me.Label.AutoSize = True
        Me.Label.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.Label.Location = New System.Drawing.Point(120, 314)
        Me.Label.Name = "Label"
        Me.Label.Size = New System.Drawing.Size(56, 17)
        Me.Label.TabIndex = 2
        Me.Label.Text = "Gender"
        '
        'occupation
        '
        Me.occupation.AutoSize = True
        Me.occupation.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.occupation.Location = New System.Drawing.Point(344, 420)
        Me.occupation.Name = "occupation"
        Me.occupation.Size = New System.Drawing.Size(0, 17)
        Me.occupation.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.Label3.Location = New System.Drawing.Point(120, 420)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(86, 17)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Occupation"
        '
        'dateOfBirth
        '
        Me.dateOfBirth.AutoSize = True
        Me.dateOfBirth.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.dateOfBirth.Location = New System.Drawing.Point(13, 9)
        Me.dateOfBirth.Name = "dateOfBirth"
        Me.dateOfBirth.Size = New System.Drawing.Size(0, 17)
        Me.dateOfBirth.TabIndex = 7
        '
        'lab
        '
        Me.lab.AutoSize = True
        Me.lab.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.lab.Location = New System.Drawing.Point(120, 526)
        Me.lab.Name = "lab"
        Me.lab.Size = New System.Drawing.Size(90, 17)
        Me.lab.TabIndex = 6
        Me.lab.Text = "Date Of Birth"
        '
        'userAddBtn
        '
        Me.userAddBtn.BackColor = System.Drawing.Color.DarkGray
        Me.userAddBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.userAddBtn.CausesValidation = False
        Me.userAddBtn.FlatAppearance.BorderSize = 0
        Me.userAddBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(2, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.userAddBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.userAddBtn.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.userAddBtn.ForeColor = System.Drawing.Color.White
        Me.userAddBtn.Location = New System.Drawing.Point(15, 12)
        Me.userAddBtn.Name = "userAddBtn"
        Me.userAddBtn.Size = New System.Drawing.Size(89, 35)
        Me.userAddBtn.TabIndex = 8
        Me.userAddBtn.Text = "BACK"
        Me.userAddBtn.UseVisualStyleBackColor = False
        '
        'changeProfilePic
        '
        Me.changeProfilePic.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(158, Byte), Integer))
        Me.changeProfilePic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.changeProfilePic.CausesValidation = False
        Me.changeProfilePic.FlatAppearance.BorderSize = 0
        Me.changeProfilePic.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(2, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.changeProfilePic.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.changeProfilePic.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.changeProfilePic.ForeColor = System.Drawing.Color.White
        Me.changeProfilePic.Location = New System.Drawing.Point(1005, 12)
        Me.changeProfilePic.Name = "changeProfilePic"
        Me.changeProfilePic.Size = New System.Drawing.Size(167, 35)
        Me.changeProfilePic.TabIndex = 9
        Me.changeProfilePic.Text = "Change Profile Picture"
        Me.changeProfilePic.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Panel1.Controls.Add(Me.gender)
        Me.Panel1.Location = New System.Drawing.Point(331, 310)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(549, 35)
        Me.Panel1.TabIndex = 10
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.ForeColor = System.Drawing.Color.DimGray
        Me.Label23.Location = New System.Drawing.Point(120, 153)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(162, 17)
        Me.Label23.TabIndex = 37
        Me.Label23.Text = "My Personal Information"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Century Gothic", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.Red
        Me.Label17.Location = New System.Drawing.Point(116, 106)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(110, 38)
        Me.Label17.TabIndex = 36
        Me.Label17.Text = "Profile"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Panel2.Controls.Add(Me.occ)
        Me.Panel2.Location = New System.Drawing.Point(331, 416)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(549, 35)
        Me.Panel2.TabIndex = 11
        '
        'occ
        '
        Me.occ.AutoSize = True
        Me.occ.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.occ.Location = New System.Drawing.Point(13, 9)
        Me.occ.Name = "occ"
        Me.occ.Size = New System.Drawing.Size(0, 17)
        Me.occ.TabIndex = 3
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Panel3.Controls.Add(Me.Label4)
        Me.Panel3.Controls.Add(Me.dateOfBirth)
        Me.Panel3.Location = New System.Drawing.Point(331, 518)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(549, 34)
        Me.Panel3.TabIndex = 38
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.Label4.Location = New System.Drawing.Point(13, 9)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(0, 17)
        Me.Label4.TabIndex = 3
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Panel4.Controls.Add(Me.Label5)
        Me.Panel4.Controls.Add(Me.Label6)
        Me.Panel4.Controls.Add(Me.username)
        Me.Panel4.Location = New System.Drawing.Point(331, 226)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(549, 37)
        Me.Panel4.TabIndex = 39
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.Label5.Location = New System.Drawing.Point(13, 8)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(0, 17)
        Me.Label5.TabIndex = 3
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.Label6.Location = New System.Drawing.Point(13, 8)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(0, 17)
        Me.Label6.TabIndex = 7
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "UploadImage"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.Label7.ForeColor = System.Drawing.Color.DarkGray
        Me.Label7.Location = New System.Drawing.Point(12, 735)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(51, 17)
        Me.Label7.TabIndex = 47
        Me.Label7.Text = "SAP V1"
        '
        'profPicModal
        '
        Me.profPicModal.BackColor = System.Drawing.Color.White
        Me.profPicModal.Controls.Add(Me.Button7)
        Me.profPicModal.Controls.Add(Me.Button9)
        Me.profPicModal.Controls.Add(Me.Label12)
        Me.profPicModal.Controls.Add(Me.Label11)
        Me.profPicModal.Controls.Add(Me.Label10)
        Me.profPicModal.Controls.Add(Me.Label9)
        Me.profPicModal.Controls.Add(Me.pbMain)
        Me.profPicModal.Controls.Add(Me.PictureBox2)
        Me.profPicModal.Controls.Add(Me.Label8)
        Me.profPicModal.Controls.Add(Me.PictureBox1)
        Me.profPicModal.Location = New System.Drawing.Point(365, 193)
        Me.profPicModal.Name = "profPicModal"
        Me.profPicModal.Size = New System.Drawing.Size(436, 428)
        Me.profPicModal.TabIndex = 41
        '
        'Button7
        '
        Me.Button7.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(158, Byte), Integer))
        Me.Button7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Button7.CausesValidation = False
        Me.Button7.FlatAppearance.BorderSize = 0
        Me.Button7.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(2, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button7.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button7.ForeColor = System.Drawing.Color.White
        Me.Button7.Location = New System.Drawing.Point(228, 356)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(172, 35)
        Me.Button7.TabIndex = 56
        Me.Button7.Text = "SAVE"
        Me.Button7.UseVisualStyleBackColor = False
        '
        'Button9
        '
        Me.Button9.BackColor = System.Drawing.Color.DarkGray
        Me.Button9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Button9.CausesValidation = False
        Me.Button9.FlatAppearance.BorderSize = 0
        Me.Button9.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(2, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button9.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button9.ForeColor = System.Drawing.Color.White
        Me.Button9.Location = New System.Drawing.Point(37, 356)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(173, 35)
        Me.Button9.TabIndex = 55
        Me.Button9.Text = "CANCEL"
        Me.Button9.UseVisualStyleBackColor = False
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.DimGray
        Me.Label12.Location = New System.Drawing.Point(320, 262)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(55, 17)
        Me.Label12.TabIndex = 53
        Me.Label12.Text = "Upload"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.DimGray
        Me.Label11.Location = New System.Drawing.Point(188, 262)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(61, 17)
        Me.Label11.TabIndex = 52
        Me.Label11.Text = "Person 2"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.DimGray
        Me.Label10.Location = New System.Drawing.Point(61, 262)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(61, 17)
        Me.Label10.TabIndex = 51
        Me.Label10.Text = "Person 1"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.DimGray
        Me.Label9.Location = New System.Drawing.Point(34, 80)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(309, 34)
        Me.Label9.TabIndex = 48
        Me.Label9.Text = "You can select your prefered preset pictures or " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Upload your own"
        '
        'pbMain
        '
        Me.pbMain.Image = CType(resources.GetObject("pbMain.Image"), System.Drawing.Image)
        Me.pbMain.Location = New System.Drawing.Point(295, 148)
        Me.pbMain.Name = "pbMain"
        Me.pbMain.Size = New System.Drawing.Size(105, 100)
        Me.pbMain.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbMain.TabIndex = 50
        Me.pbMain.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(166, 148)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(105, 100)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 49
        Me.PictureBox2.TabStop = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Century Gothic", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Red
        Me.Label8.Location = New System.Drawing.Point(30, 33)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(303, 38)
        Me.Label8.TabIndex = 48
        Me.Label8.Text = "Select your Picture"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(39, 148)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(105, 100)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'backdrop
        '
        Me.backdrop.BackColor = System.Drawing.Color.AliceBlue
        Me.backdrop.Controls.Add(Me.profPicModal)
        Me.backdrop.Dock = System.Windows.Forms.DockStyle.Fill
        Me.backdrop.Location = New System.Drawing.Point(0, 0)
        Me.backdrop.Name = "backdrop"
        Me.backdrop.Size = New System.Drawing.Size(1184, 761)
        Me.backdrop.TabIndex = 51
        '
        'Profile
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1184, 761)
        Me.Controls.Add(Me.backdrop)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Label23)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.changeProfilePic)
        Me.Controls.Add(Me.userAddBtn)
        Me.Controls.Add(Me.lab)
        Me.Controls.Add(Me.occupation)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "Profile"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "My Profile"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.profPicModal.ResumeLayout(False)
        Me.profPicModal.PerformLayout()
        CType(Me.pbMain, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.backdrop.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents username As System.Windows.Forms.Label
    Friend WithEvents gender As System.Windows.Forms.Label
    Friend WithEvents Label As System.Windows.Forms.Label
    Friend WithEvents occupation As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents dateOfBirth As System.Windows.Forms.Label
    Friend WithEvents lab As System.Windows.Forms.Label
    Friend WithEvents userAddBtn As System.Windows.Forms.Button
    Friend WithEvents changeProfilePic As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents occ As System.Windows.Forms.Label
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents profPicModal As System.Windows.Forms.Panel
    Friend WithEvents Button7 As System.Windows.Forms.Button
    Friend WithEvents Button9 As System.Windows.Forms.Button
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents pbMain As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents backdrop As System.Windows.Forms.Panel
End Class
