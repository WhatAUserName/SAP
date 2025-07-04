Public Class Session
    Private Property _username As String
    Private Property _name As String
    Private Property _occupation As String
    Private Property _dateOfBirth As String
    Private Property _gender As String

    Public Sub New(username As String, name As String, occupation As String, dateOfBirth As String, gender As String)
        _username = username
        _name = name
        _occupation = occupation
        _dateOfBirth = dateOfBirth
        _gender = gender
    End Sub

    Public Sub reset()
        _username = ""
        _name = ""
        _occupation = ""
        _dateOfBirth = ""
        _gender = ""
    End Sub

    Public ReadOnly Property Username As String
        Get
            Return _username
        End Get
    End Property

    Public ReadOnly Property Name As String
        Get
            Return _name
        End Get
    End Property

    Public ReadOnly Property Occupation As String
        Get
            Return _occupation
        End Get
    End Property

    Public ReadOnly Property DateOfBirth As String
        Get
            Return _dateOfBirth
        End Get
    End Property

    Public ReadOnly Property Gender As String
        Get
            Return _gender
        End Get
    End Property
End Class
