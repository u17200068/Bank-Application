Imports Microsoft.VisualBasic
Public Class User

    Private Shared user_name As String = ""
    Private Shared full_name As String = ""
    Private Shared mobile_num As String = ""
    Private Shared dateOfBirth As Date
    Private Shared password As String = ""
    Private Shared city As String = ""
    Private Shared email As String = ""
    Private Shared ctr As Integer = 0
    Private Shared accountBalance As Integer = 7000

    Property changeCity() As String
        Get
            changeCity = city
        End Get
        Set(ByVal aCity As String)
            city = aCity
        End Set
    End Property

    Property changeBalance() As Integer
        Get
            changeBalance = accountBalance
        End Get
        Set(ByVal balance As Integer)
            accountBalance = balance
        End Set
    End Property

    Property changeUsername() As String
        Get
            changeUsername = user_name
        End Get
        Set(userName As String)
            user_name = userName
        End Set
    End Property

    Property changeFullname() As String
        Get
            changeFullname = full_name
        End Get
        Set(fullName As String)
            full_name = fullName
        End Set
    End Property

    Property changeMobilenum() As String
        Get
            changeMobilenum = mobile_num
        End Get
        Set(mobileNum As String)
            mobile_num = mobileNum
        End Set
    End Property

    Property changeDateofbirth() As String
        Get
            changeDateofbirth = dateOfBirth
        End Get
        Set(dob As String)
            dateOfBirth = dob
        End Set
    End Property

    Property changePassword() As String
        Get
            changePassword = password
        End Get
        Set(pass As String)
            password = pass
        End Set
    End Property

    Public Sub displayPassword()
        MessageBox.Show("Your password is " & password, "Password", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
    End Sub
End Class
