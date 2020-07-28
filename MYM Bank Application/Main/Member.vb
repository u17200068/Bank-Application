Public Class Member

    Private Shared subUserOne As Subuser
    Private Shared subUserTwo As Subuser
    Private Shared ctr As Integer
    Private Shared signUp As Sign_up = New Sign_up

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ctr += 1
        If ctr = 1 Then

            If signUp.checkNames(TextBox1.Text) = True Then
                subUserOne.changeUsername = TextBox1.Text
            Else
                MessageBox.Show("Please enter a valid Username", "Invalid username", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If

            If signUp.checkNames(TextBox2.Text) = True Then
                subUserOne.changeFullname = TextBox2.Text
            Else
                MessageBox.Show("Please enter your name", "Name not provided", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If

            If signUp.checkMobilenum(TextBox3.Text) = True Then
                subUserOne.changeMobilenum = TextBox3.Text
            Else
                MessageBox.Show("Please enter a valid UAE phone number", "Invalid number", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If

            subUserOne.changeDateofbirth = DateTimePicker1.Value.Date

            If signUp.checkNames(TextBox1.Text) = True And signUp.checkNames(TextBox2.Text) = True And signUp.checkMobilenum(TextBox3.Text) = True Then
                subUserOne.changePassword = signUp.generateRandomPass()
                subUserOne.displayPassword()
            End If

            Label11.Text = ComboBox1.Text + ":"
            subUserOne.changePrivelegeStatus = ComboBox1.Text
            Label10.Visible = True
            Label11.Visible = True
            Label10.Text = subUserOne.changeFullname
            Dim b1 As Birthday = New Birthday
            b1.changeBday = DateTimePicker1.Value.Date
            b1.changeUser() = subUserOne
            b1.birthdayNotification(subUserOne, subUserOne.changeDateofbirth)

        ElseIf ctr = 2 Then

            If signUp.checkNames(TextBox1.Text) = True Then
                subUserTwo.changeUsername = TextBox1.Text
            Else
                MessageBox.Show("Please enter a valid Username", "Invalid username", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If

            If signUp.checkNames(TextBox2.Text) = True Then
                subUserTwo.changeFullname = TextBox2.Text
            Else
                MessageBox.Show("Please enter your name", "Name not provided", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If

            If signUp.checkMobilenum(TextBox3.Text) = True Then
                subUserTwo.changeMobilenum = TextBox3.Text
            Else
                MessageBox.Show("Please enter a valid UAE phone number", "Invalid number", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If

            subUserTwo.changeDateofbirth = DateTimePicker1.Value.Date

            If signUp.checkNames(TextBox1.Text) = True And signUp.checkNames(TextBox2.Text) = True And signUp.checkMobilenum(TextBox3.Text) = True Then
                subUserTwo.changePassword = signUp.generateRandomPass()
                subUserTwo.displayPassword()
            End If

            Label13.Text = ComboBox1.Text + ":"
            subUserTwo.changePrivelegeStatus = ComboBox1.Text
            Label12.Visible = True
            Label13.Visible = True
            Label12.Text = subUserOne.changeFullname
            Dim b2 As Birthday = New Birthday
            b2.changeBday = DateTimePicker1.Value.Date
            b2.changeUser() = subUserTwo
            b2.birthdayNotification(subUserTwo, subUserTwo.changeDateofbirth)
        ElseIf ctr > 2 Then
            MessageBox.Show("Maximum 2 Child users per account", "Exceeding users", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged
        TextBox2.Text = System.Threading.Thread.CurrentThread.CurrentCulture.TextInfo.ToTitleCase(TextBox2.Text)
        TextBox2.Select(TextBox2.Text.Length, 0)
    End Sub

    Function getSubUserOne() As User
        getSubUserOne = subUserOne
    End Function

    Function getSubUserTwo() As User
        getSubUserTwo = subUserTwo
    End Function

    Private Sub Member_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        subUserOne = New Subuser
        subUserTwo = New Subuser
        subUserOne.changeParentUser = Sign_up.getUser(0)
        subUserTwo.changeParentUser = Sign_up.getUser(0)
        Dim user As Sign_up = New Sign_up
        Label9.Text = user.getUser(0).changeFullname.ToString
    End Sub
End Class