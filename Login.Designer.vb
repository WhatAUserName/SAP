<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
<Global.System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1726")> _
Partial Class Login
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
    Friend WithEvents OK As System.Windows.Forms.Button
    Friend WithEvents Cancel As System.Windows.Forms.Button

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Login))
        Me.OK = New System.Windows.Forms.Button()
        Me.Cancel = New System.Windows.Forms.Button()
        Me.SignUpLink = New System.Windows.Forms.LinkLabel()
        Me.Panel19 = New System.Windows.Forms.Panel()
        Me.logUsername = New System.Windows.Forms.TextBox()
        Me.Panel18 = New System.Windows.Forms.Panel()
        Me.logPass = New System.Windows.Forms.TextBox()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel19.SuspendLayout()
        Me.Panel18.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'OK
        '
        Me.OK.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(158, Byte), Integer))
        Me.OK.FlatAppearance.BorderSize = 0
        Me.OK.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.OK.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.OK.ForeColor = System.Drawing.Color.White
        Me.OK.Location = New System.Drawing.Point(39, 552)
        Me.OK.Name = "OK"
        Me.OK.Size = New System.Drawing.Size(230, 45)
        Me.OK.TabIndex = 4
        Me.OK.Text = "&Login"
        Me.OK.UseVisualStyleBackColor = False
        '
        'Cancel
        '
        Me.Cancel.BackColor = System.Drawing.Color.DarkGray
        Me.Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Cancel.FlatAppearance.BorderSize = 0
        Me.Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Cancel.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.Cancel.ForeColor = System.Drawing.Color.White
        Me.Cancel.Location = New System.Drawing.Point(284, 552)
        Me.Cancel.Name = "Cancel"
        Me.Cancel.Size = New System.Drawing.Size(230, 45)
        Me.Cancel.TabIndex = 5
        Me.Cancel.Text = "&Reset"
        Me.Cancel.UseVisualStyleBackColor = False
        '
        'SignUpLink
        '
        Me.SignUpLink.AutoSize = True
        Me.SignUpLink.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.SignUpLink.Location = New System.Drawing.Point(39, 532)
        Me.SignUpLink.Name = "SignUpLink"
        Me.SignUpLink.Size = New System.Drawing.Size(55, 17)
        Me.SignUpLink.TabIndex = 7
        Me.SignUpLink.TabStop = True
        Me.SignUpLink.Text = "Sign Up"
        Me.SignUpLink.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Panel19
        '
        Me.Panel19.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Panel19.Controls.Add(Me.logUsername)
        Me.Panel19.Location = New System.Drawing.Point(37, 314)
        Me.Panel19.Name = "Panel19"
        Me.Panel19.Size = New System.Drawing.Size(479, 36)
        Me.Panel19.TabIndex = 17
        '
        'logUsername
        '
        Me.logUsername.BackColor = System.Drawing.Color.WhiteSmoke
        Me.logUsername.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.logUsername.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.logUsername.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.logUsername.Location = New System.Drawing.Point(16, 9)
        Me.logUsername.Name = "logUsername"
        Me.logUsername.Size = New System.Drawing.Size(444, 14)
        Me.logUsername.TabIndex = 0
        '
        'Panel18
        '
        Me.Panel18.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Panel18.Controls.Add(Me.logPass)
        Me.Panel18.Location = New System.Drawing.Point(37, 435)
        Me.Panel18.Name = "Panel18"
        Me.Panel18.Size = New System.Drawing.Size(479, 36)
        Me.Panel18.TabIndex = 18
        '
        'logPass
        '
        Me.logPass.BackColor = System.Drawing.Color.WhiteSmoke
        Me.logPass.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.logPass.Font = New System.Drawing.Font("Century Gothic", 8.25!)
        Me.logPass.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.logPass.Location = New System.Drawing.Point(16, 9)
        Me.logPass.Name = "logPass"
        Me.logPass.Size = New System.Drawing.Size(445, 14)
        Me.logPass.TabIndex = 0
        Me.logPass.UseSystemPasswordChar = True
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.Location = New System.Drawing.Point(37, 294)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(71, 17)
        Me.Label25.TabIndex = 19
        Me.Label25.Text = "Username"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(37, 415)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(69, 17)
        Me.Label22.TabIndex = 20
        Me.Label22.Text = "Password"
        '
        'PictureBox1
        '
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Right
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(559, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(625, 761)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 21
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(333, 182)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(183, 85)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 23
        Me.PictureBox2.TabStop = False
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Century Gothic", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.Red
        Me.Label17.Location = New System.Drawing.Point(33, 182)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(99, 38)
        Me.Label17.TabIndex = 24
        Me.Label17.Text = "Login"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.ForeColor = System.Drawing.Color.DimGray
        Me.Label23.Location = New System.Drawing.Point(36, 230)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(148, 17)
        Me.Label23.TabIndex = 25
        Me.Label23.Text = "Login your credentials"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.Label1.ForeColor = System.Drawing.Color.DarkGray
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 17)
        Me.Label1.TabIndex = 26
        Me.Label1.Text = "SAP V1"
        '
        'Login
        '
        Me.AcceptButton = Me.OK
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.CancelButton = Me.Cancel
        Me.ClientSize = New System.Drawing.Size(1184, 761)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label23)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label22)
        Me.Controls.Add(Me.Label25)
        Me.Controls.Add(Me.Panel18)
        Me.Controls.Add(Me.Panel19)
        Me.Controls.Add(Me.SignUpLink)
        Me.Controls.Add(Me.Cancel)
        Me.Controls.Add(Me.OK)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Login"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login"
        Me.Panel19.ResumeLayout(False)
        Me.Panel19.PerformLayout()
        Me.Panel18.ResumeLayout(False)
        Me.Panel18.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents SignUpLink As System.Windows.Forms.LinkLabel
    Friend WithEvents Panel19 As System.Windows.Forms.Panel
    Friend WithEvents logUsername As System.Windows.Forms.TextBox
    Friend WithEvents Panel18 As System.Windows.Forms.Panel
    Friend WithEvents logPass As System.Windows.Forms.TextBox
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label

End Class
