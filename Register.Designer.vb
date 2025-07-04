<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
<Global.System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1726")> _
Partial Class Register
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Register))
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.regIsAgree = New System.Windows.Forms.CheckBox()
        Me.regUsername = New System.Windows.Forms.TextBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Panel18 = New System.Windows.Forms.Panel()
        Me.regPass = New System.Windows.Forms.TextBox()
        Me.Panel19 = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.regOccupation = New System.Windows.Forms.PictureBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel20 = New System.Windows.Forms.Panel()
        Me.regDateOfBirth = New System.Windows.Forms.DateTimePicker()
        Me.Panel15 = New System.Windows.Forms.Panel()
        Me.regGender = New System.Windows.Forms.ComboBox()
        Me.Panel16 = New System.Windows.Forms.Panel()
        Me.regUserOccupation = New System.Windows.Forms.ComboBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.regFullname = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel18.SuspendLayout()
        Me.Panel19.SuspendLayout()
        CType(Me.regOccupation, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel20.SuspendLayout()
        Me.Panel15.SuspendLayout()
        Me.Panel16.SuspendLayout()
        Me.SuspendLayout()
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.LinkLabel1.Location = New System.Drawing.Point(52, 667)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(49, 17)
        Me.LinkLabel1.TabIndex = 6
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Sign In"
        '
        'regIsAgree
        '
        Me.regIsAgree.AutoSize = True
        Me.regIsAgree.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.regIsAgree.Location = New System.Drawing.Point(49, 608)
        Me.regIsAgree.Name = "regIsAgree"
        Me.regIsAgree.Size = New System.Drawing.Size(296, 21)
        Me.regIsAgree.TabIndex = 15
        Me.regIsAgree.Text = "Do you agree to our Terms and Condition"
        Me.regIsAgree.UseVisualStyleBackColor = True
        '
        'regUsername
        '
        Me.regUsername.BackColor = System.Drawing.Color.WhiteSmoke
        Me.regUsername.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.regUsername.Font = New System.Drawing.Font("Century Gothic", 8.25!)
        Me.regUsername.Location = New System.Drawing.Point(17, 11)
        Me.regUsername.Name = "regUsername"
        Me.regUsername.Size = New System.Drawing.Size(444, 14)
        Me.regUsername.TabIndex = 1
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.ForeColor = System.Drawing.Color.DimGray
        Me.Label23.Location = New System.Drawing.Point(49, 87)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(175, 17)
        Me.Label23.TabIndex = 35
        Me.Label23.Text = "Creating your Information"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Century Gothic", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.Red
        Me.Label17.Location = New System.Drawing.Point(49, 39)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(139, 38)
        Me.Label17.TabIndex = 34
        Me.Label17.Text = "Register"
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(346, 39)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(183, 85)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 33
        Me.PictureBox2.TabStop = False
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(49, 210)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(69, 17)
        Me.Label22.TabIndex = 32
        Me.Label22.Text = "Password"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.Location = New System.Drawing.Point(49, 135)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(71, 17)
        Me.Label25.TabIndex = 31
        Me.Label25.Text = "Username"
        '
        'Panel18
        '
        Me.Panel18.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Panel18.Controls.Add(Me.regPass)
        Me.Panel18.Location = New System.Drawing.Point(49, 238)
        Me.Panel18.Name = "Panel18"
        Me.Panel18.Size = New System.Drawing.Size(479, 36)
        Me.Panel18.TabIndex = 30
        '
        'regPass
        '
        Me.regPass.BackColor = System.Drawing.Color.WhiteSmoke
        Me.regPass.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.regPass.Font = New System.Drawing.Font("Century Gothic", 8.25!)
        Me.regPass.Location = New System.Drawing.Point(17, 11)
        Me.regPass.Name = "regPass"
        Me.regPass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.regPass.Size = New System.Drawing.Size(444, 14)
        Me.regPass.TabIndex = 36
        Me.regPass.UseSystemPasswordChar = True
        '
        'Panel19
        '
        Me.Panel19.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Panel19.Controls.Add(Me.regUsername)
        Me.Panel19.Location = New System.Drawing.Point(49, 163)
        Me.Panel19.Name = "Panel19"
        Me.Panel19.Size = New System.Drawing.Size(479, 36)
        Me.Panel19.TabIndex = 29
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.DarkGray
        Me.Button1.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(297, 687)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(231, 45)
        Me.Button1.TabIndex = 27
        Me.Button1.Text = "&Reset"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(158, Byte), Integer))
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.Button2.ForeColor = System.Drawing.Color.White
        Me.Button2.Location = New System.Drawing.Point(52, 687)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(230, 45)
        Me.Button2.TabIndex = 26
        Me.Button2.Text = "&Register"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'regOccupation
        '
        Me.regOccupation.Dock = System.Windows.Forms.DockStyle.Right
        Me.regOccupation.Image = CType(resources.GetObject("regOccupation.Image"), System.Drawing.Image)
        Me.regOccupation.Location = New System.Drawing.Point(559, 0)
        Me.regOccupation.Name = "regOccupation"
        Me.regOccupation.Size = New System.Drawing.Size(625, 761)
        Me.regOccupation.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.regOccupation.TabIndex = 25
        Me.regOccupation.TabStop = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(49, 285)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(72, 17)
        Me.Label4.TabIndex = 37
        Me.Label4.Text = "Full Name"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Panel1.Controls.Add(Me.regFullname)
        Me.Panel1.Location = New System.Drawing.Point(49, 313)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(479, 36)
        Me.Panel1.TabIndex = 36
        '
        'Panel20
        '
        Me.Panel20.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Panel20.Controls.Add(Me.regDateOfBirth)
        Me.Panel20.Location = New System.Drawing.Point(49, 538)
        Me.Panel20.Name = "Panel20"
        Me.Panel20.Size = New System.Drawing.Size(477, 36)
        Me.Panel20.TabIndex = 43
        '
        'regDateOfBirth
        '
        Me.regDateOfBirth.CalendarForeColor = System.Drawing.Color.Black
        Me.regDateOfBirth.CalendarMonthBackground = System.Drawing.Color.Black
        Me.regDateOfBirth.CalendarTitleBackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.regDateOfBirth.CalendarTrailingForeColor = System.Drawing.SystemColors.ControlText
        Me.regDateOfBirth.Location = New System.Drawing.Point(3, 8)
        Me.regDateOfBirth.Name = "regDateOfBirth"
        Me.regDateOfBirth.Size = New System.Drawing.Size(474, 20)
        Me.regDateOfBirth.TabIndex = 21
        '
        'Panel15
        '
        Me.Panel15.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Panel15.Controls.Add(Me.regGender)
        Me.Panel15.Location = New System.Drawing.Point(49, 463)
        Me.Panel15.Name = "Panel15"
        Me.Panel15.Size = New System.Drawing.Size(477, 36)
        Me.Panel15.TabIndex = 42
        '
        'regGender
        '
        Me.regGender.BackColor = System.Drawing.Color.WhiteSmoke
        Me.regGender.Font = New System.Drawing.Font("Century Gothic", 8.25!)
        Me.regGender.FormattingEnabled = True
        Me.regGender.Items.AddRange(New Object() {"Male", "Female", "Others"})
        Me.regGender.Location = New System.Drawing.Point(0, 6)
        Me.regGender.Name = "regGender"
        Me.regGender.Size = New System.Drawing.Size(477, 24)
        Me.regGender.TabIndex = 26
        '
        'Panel16
        '
        Me.Panel16.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Panel16.Controls.Add(Me.regUserOccupation)
        Me.Panel16.Location = New System.Drawing.Point(49, 388)
        Me.Panel16.Name = "Panel16"
        Me.Panel16.Size = New System.Drawing.Size(477, 36)
        Me.Panel16.TabIndex = 41
        '
        'regUserOccupation
        '
        Me.regUserOccupation.BackColor = System.Drawing.Color.WhiteSmoke
        Me.regUserOccupation.Font = New System.Drawing.Font("Century Gothic", 8.25!)
        Me.regUserOccupation.FormattingEnabled = True
        Me.regUserOccupation.Items.AddRange(New Object() {"Delivery Helper", "It Support", "Data Encoder", "Programmer"})
        Me.regUserOccupation.Location = New System.Drawing.Point(0, 6)
        Me.regUserOccupation.Name = "regUserOccupation"
        Me.regUserOccupation.Size = New System.Drawing.Size(477, 24)
        Me.regUserOccupation.TabIndex = 27
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(49, 360)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(86, 17)
        Me.Label20.TabIndex = 39
        Me.Label20.Text = "Occupation"
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.Location = New System.Drawing.Point(49, 435)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(56, 17)
        Me.Label27.TabIndex = 44
        Me.Label27.Text = "Gender"
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(72, 687)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(85, 23)
        Me.Label1.TabIndex = 19
        Me.Label1.Text = "&Occupation"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(49, 510)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(59, 17)
        Me.Label2.TabIndex = 45
        Me.Label2.Text = "Birthday"
        '
        'regFullname
        '
        Me.regFullname.BackColor = System.Drawing.Color.WhiteSmoke
        Me.regFullname.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.regFullname.Font = New System.Drawing.Font("Century Gothic", 8.25!)
        Me.regFullname.Location = New System.Drawing.Point(17, 11)
        Me.regFullname.Name = "regFullname"
        Me.regFullname.Size = New System.Drawing.Size(444, 14)
        Me.regFullname.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.Label3.ForeColor = System.Drawing.Color.DarkGray
        Me.Label3.Location = New System.Drawing.Point(12, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(51, 17)
        Me.Label3.TabIndex = 46
        Me.Label3.Text = "SAP V1"
        '
        'Register
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1184, 761)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label27)
        Me.Controls.Add(Me.Panel20)
        Me.Controls.Add(Me.Panel15)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.Panel16)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label23)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.Label22)
        Me.Controls.Add(Me.Label25)
        Me.Controls.Add(Me.Panel18)
        Me.Controls.Add(Me.Panel19)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.regOccupation)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.regIsAgree)
        Me.Controls.Add(Me.LinkLabel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Register"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "+"
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel18.ResumeLayout(False)
        Me.Panel18.PerformLayout()
        Me.Panel19.ResumeLayout(False)
        Me.Panel19.PerformLayout()
        CType(Me.regOccupation, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel20.ResumeLayout(False)
        Me.Panel15.ResumeLayout(False)
        Me.Panel16.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LinkLabel1 As System.Windows.Forms.LinkLabel
    Friend WithEvents regIsAgree As System.Windows.Forms.CheckBox
    Friend WithEvents regUsername As System.Windows.Forms.TextBox
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents Panel18 As System.Windows.Forms.Panel
    Friend WithEvents Panel19 As System.Windows.Forms.Panel
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents regPass As System.Windows.Forms.TextBox
    Friend WithEvents regOccupation As System.Windows.Forms.PictureBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel20 As System.Windows.Forms.Panel
    Friend WithEvents regDateOfBirth As System.Windows.Forms.DateTimePicker
    Friend WithEvents Panel15 As System.Windows.Forms.Panel
    Friend WithEvents regGender As System.Windows.Forms.ComboBox
    Friend WithEvents Panel16 As System.Windows.Forms.Panel
    Friend WithEvents regUserOccupation As System.Windows.Forms.ComboBox
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents regFullname As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label

End Class
