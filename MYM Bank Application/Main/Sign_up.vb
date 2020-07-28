Public Class Sign_up
    Private Shared newUser(10) As User
    Private UsableChars() As String
    Private password As New Random
    Private CharsList = "A,B,C,D,E,F,G,H,I,J,K,0,1,2,3,4,5,6,7,8,9"
    Private Shared FinalPassword As String = ""
    Private Number As Integer
    Private Shared ctr As Integer

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        For count = 0 To 10
            newUser(count) = New User
        Next
        If checkNames(TextBox1.Text) = True Then
            newUser(ctr).changeUsername = TextBox1.Text
        Else
            MessageBox.Show("Please enter a valid Username", "Invalid username", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

        If checkNames(TextBox2.Text) = True Then
            newUser(ctr).changeFullname = TextBox2.Text
        Else
            MessageBox.Show("Please enter your name", "Name not provided", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

        If checkMobilenum(TextBox3.Text) = True Then
            newUser(ctr).changeMobilenum = TextBox3.Text
        Else
            MessageBox.Show("Please enter a valid UAE phone number", "Invalid number", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

        newUser(ctr).changeDateofbirth = DateTimePicker1.Value.Date

        If checkNames(TextBox1.Text) = True And checkNames(TextBox2.Text) = True And checkMobilenum(TextBox3.Text) = True Then
            newUser(ctr).changePassword = generateRandomPass()
            newUser(ctr).displayPassword()
        End If
        ctr += 1
    End Sub

    Public Function getUser(ByVal index As Integer) As User
        getUser = newUser(index)
    End Function

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged
        TextBox2.Text = System.Threading.Thread.CurrentThread.CurrentCulture.TextInfo.ToTitleCase(TextBox2.Text)
        TextBox2.Select(TextBox2.Text.Length, 0)
    End Sub

    Public Function generateRandomPass() As String
        UsableChars = Split(CharsList, ",")
        FinalPassword = ""
        Number = 0
        For i As Integer = 1 To 8
            Number = password.Next(0, 20)
            FinalPassword = FinalPassword + UsableChars(Number)
        Next
        generateRandomPass = FinalPassword
    End Function

    Public Function checkMobilenum(ByVal number As String) As Boolean
        If number.Length > 14 Or number.Length < 14 Then
            Return False
        Else
            Return True
        End If
    End Function

    Public Function checkNames(ByVal username As String) As Boolean
        If String.IsNullOrEmpty(username) Then
            checkNames = False
        Else
            checkNames = True
        End If
    End Function

    Public Property changeUser As User
        Get
            changeUser = newUser(ctr)
        End Get
        Set(user As User)
            newUser(ctr) = user
        End Set
    End Property


End Class