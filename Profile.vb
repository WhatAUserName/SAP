Public Class Profile

    Private _userSession As Session

    Public Sub New(userSession As Session)
        InitializeComponent()

        _userSession = userSession
    End Sub

    Private Sub Profile_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        profPicModal.Hide()
        Me.username.Text = _userSession.Username
        Me.gender.Text = _userSession.Gender
        Me.occupation.Text = _userSession.Occupation
        Me.dateOfBirth.Text = _userSession.DateOfBirth
    End Sub

    Private Sub userAddBtn_Click(sender As Object, e As EventArgs) Handles userAddBtn.Click
        Me.Hide()
        Dim dashboard As New Dashboard(_userSession)
        dashboard.Show()
    End Sub

    Private Sub changeProfilePic_Click(sender As Object, e As EventArgs) Handles changeProfilePic.Click
        profPicModal.Show()
    End Sub

End Class

'Creating change profile
'Try
'            conn.Open()
'Dim stmt As String = "UPDATE [dbo].[user_information] SET profileImage=@profPic WHERE userId=@id;"
'Dim cmd As New SqlCommand(stmt, conn)

'            cmd.Parameters.AddWithValue("@profileImage", profPic)
'            cmd.Parameters.AddWithValue("@id", selectedId)

'            cmd.ExecuteNonQuery()

'        Catch ex As Exception
'            MsgBox(ex.ToString())
'            MsgBox(ex.ToString(), MsgBoxStyle.Exclamation)
'        End Try