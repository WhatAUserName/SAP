﻿Imports System.Data.SqlClient

Public Class Profile

    Private _userSession As Session

    Public Sub New(userSession As Session)
        InitializeComponent()

        _userSession = userSession
    End Sub

    Private Sub Profile_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        profPicModal.Hide()
        backdrop.Hide()

        Me.username.Text = _userSession.Username
        Me.gender.Text = _userSession.Gender
        Me.occ.Text = _userSession.Occupation
        Me.dateOfBirth.Text = _userSession.DateOfBirth

    End Sub

    Private Sub userAddBtn_Click(sender As Object, e As EventArgs) Handles userAddBtn.Click
        Me.Hide()
        Dim dashboard As New Dashboard(_userSession)
        dashboard.Show()
    End Sub

    Private Sub changeProfilePic_Click(sender As Object, e As EventArgs) Handles changeProfilePic.Click
        profPicModal.Show()
        backdrop.Show()
    End Sub

    Private Sub Button9_Click_1(sender As Object, e As EventArgs) Handles Button9.Click
        profPicModal.Hide()
        backdrop.Hide()
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        Using ofd As New OpenFileDialog()
            ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp"
            If ofd.ShowDialog() = DialogResult.OK Then
                PictureBox3.Image = Image.FromFile(ofd.FileName)
                PictureBox3.Tag = ofd.FileName
            End If
        End Using
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click

        Dim imagePath As String = If(PictureBox3.Tag, "")

        _userSession.ProfImage = imagePath
        updateProfImage(imagePath)

    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        profPicModal.Hide()
        backdrop.Hide()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Dim imagePath As String = If(PictureBox3.Tag, "C:\Users\User\Downloads\logos\p-boy-1.jpg")

        _userSession.ProfImage = imagePath
        updateProfImage(imagePath)

    End Sub


    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Dim imagePath As String = If(PictureBox3.Tag, "C:\Users\User\Downloads\logos\p-girl-1.jpg")

        _userSession.ProfImage = imagePath
        updateProfImage(imagePath)
    End Sub

    Private Sub updateProfImage(imagePath As String)
        Dim conn As New SqlClient.SqlConnection
        conn.ConnectionString = "server=R3COM8;user id=sa;password=sqlpassword123;Database=sample;"
        Try
            conn.Open()
            Dim stmt As String = "UPDATE [dbo].[user_information] SET prof_image=@profImage WHERE userId=@id"
            Dim cmd As New SqlCommand(stmt, conn)
            cmd.Parameters.AddWithValue("@profImage", imagePath)
            cmd.Parameters.AddWithValue("@id", _userSession.UserId)

            cmd.ExecuteNonQuery()
            profPicModal.Hide()
            backdrop.Hide()

        Catch ex As Exception
            MsgBox(ex.ToString())
        End Try

        MessageBox.Show("User image Saved!")
    End Sub

End Class

