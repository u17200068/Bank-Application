Imports Microsoft.VisualBasic

Public Class User

    Private username As String
    Private fullname As String
    Private mobile_num As String
    Private dateOfBirth As String
    Private password As String
    Private ctr As Integer

    Public Sub setUsername(ByVal user_name)
        username = user_name
    End Sub

    Public Sub setFullname(ByVal full_name)
        fullname = full_name
    End Sub

    Public Sub setMobilenum(ByVal mobnum)
        mobile_num = mobnum
    End Sub

    Public Sub setDateofbirth(ByVal dob)
        dateOfBirth = dob
    End Sub

    Public Sub setPassword()
        password = Math.Ceiling(Rnd() * 20) * Math.Ceiling(Rnd() * 20) * Math.Ceiling(Rnd() * 20)
    End Sub

    Public Function getUsername() As String
        Return username
    End Function

    Public Function getFullname() As String
        Return fullname
    End Function

    Public Function getMobilenum() As String
        Return mobile_num
    End Function

    Public Function getDateofbirth() As String
        Return dateOfBirth
    End Function

    Public Function getPassword() As String
        Return password
    End Function

    Public Sub displayPassword()
        MsgBox("Your password is " & getPassword())
    End Sub
End Class
