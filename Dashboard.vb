Imports System.Drawing.Drawing2D
Imports System.Data
Imports System.Data.SqlClient

Public Class Dashboard

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

        profImage.Image = Image.FromFile(_userSession.ProfImage)

        
        mainPanel.Controls.Clear()

        Me.AutoScaleMode = AutoScaleMode.None
        Dim dashboard As New DashboardPage()
        dashboard.Dock = DockStyle.None
        dashboard.AutoScroll = False
        dashboard.Size = New Size(950, 725)
        mainPanel.Controls.Add(dashboard)

        username.Text = _userSession.Name
        homeTabPane.BackColor = Color.AliceBlue

    End Sub

    'START of Dashboard Pane
    Private Sub homeTabPane_Click(sender As Object, ByVal e As System.EventArgs) Handles homeTabPane.Click
        mainPanel.Controls.Clear()

        Dim dashboard As New DashboardPage()
        dashboard.Size = New System.Drawing.Size(950, 725)
        mainPanel.Controls.Add(dashboard)

        'Tab Color Styling
        homeTabPane.BackColor = Color.AliceBlue
        categoryTabPane.BackColor = Color.White
        userTabPane.BackColor = Color.White
        productsTabPane.BackColor = Color.White
    End Sub
    'END of Dashboard Pane

    'START of User Tab Pane
    Private Sub userTabPane_Click(sender As Object, ByVal e As EventArgs) Handles userTabPane.Click
        mainPanel.Controls.Clear()

        Dim users As New Users()
        users.Dock = DockStyle.Fill
        Users.BringToFront()
        users.Size = New System.Drawing.Size(950, 725)
        mainPanel.Controls.Add(users)

        'Tab Color Styling
        userTabPane.BackColor = Color.AliceBlue
        homeTabPane.BackColor = Color.White
        categoryTabPane.BackColor = Color.White
        productsTabPane.BackColor = Color.White
    End Sub
    'END of User Tab Pane


    'START of Products Tab Pane
    Private Sub productsTabPane_Click(sender As Object, ByVal e As System.EventArgs) Handles productsTabPane.Click

        mainPanel.Controls.Clear()

        Dim product As New Products()
        product.Dock = DockStyle.Fill
        product.BringToFront()
        product.Size = New System.Drawing.Size(950, 725)
        mainPanel.Controls.Add(product)

        'Tab Color Styling
        homeTabPane.BackColor = Color.White
        userTabPane.BackColor = Color.White
        productsTabPane.BackColor = Color.AliceBlue
        categoryTabPane.BackColor = Color.White

    End Sub
    'END of Products Tab Pane

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

    Public Sub PictureBox6_Click(sender As Object, e As EventArgs) Handles profImage.Click
        showProfilePage()
    End Sub

    Private Sub PictureBox10_Click(sender As Object, e As EventArgs) Handles PictureBox10.Click
        showProfilePage()
    End Sub

    Private Sub categoryTabPane_Click(sender As Object, e As EventArgs) Handles categoryTabPane.Click
     
        mainPanel.Controls.Clear()

        Dim category As New Category()
        category.Dock = DockStyle.Fill
        category.BringToFront()
        category.Size = New System.Drawing.Size(950, 725)
        category.AutoScroll = False
        mainPanel.Controls.Add(category)

        'Tab Color Styling
        homeTabPane.BackColor = Color.White
        userTabPane.BackColor = Color.White
        productsTabPane.BackColor = Color.White
        categoryTabPane.BackColor = Color.AliceBlue
    End Sub

End Class
