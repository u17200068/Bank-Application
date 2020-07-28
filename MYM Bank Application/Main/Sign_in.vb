Public Class Sign_in
    Private users(10) As User
    Private Shared activeUserIndex As Integer
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Sign_up.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim username As String = TextBox1.Text
        Dim password As String = TextBox2.Text
        checkNameandPass(username, password)
    End Sub

    Private Sub checkNameandPass(ByVal username, ByVal password)

        If (Sign_up.getUser(0) Is Nothing And Sign_up.getUser(0) Is Nothing) Then
            MessageBox.Show("Please create an account before signing in", "Account not found", MessageBoxButtons.OK, MessageBoxIcon.Error)
            activeUserIndex = 0
        Else
            For count As Integer = 0 To 9
                If (Sign_up.getUser(count).changeUsername() = TextBox1.Text And Sign_up.getUser(count).changePassword = TextBox2.Text) Then
                    activeUserIndex = count
                    TextBox1.Text = ""
                    TextBox2.Text = ""
                    Main.Show()
                End If
            Next
        End If

        If (Sign_up.getUser(activeUserIndex) IsNot Nothing) Then
            If (Sign_up.getUser(activeUserIndex).changeUsername() <> TextBox1.Text And Sign_up.getUser(activeUserIndex).changePassword = TextBox2.Text) Then
                MessageBox.Show("Incorrect username provided", "False username", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
            If (Sign_up.getUser(activeUserIndex).changePassword() <> TextBox1.Text And Sign_up.getUser(activeUserIndex).changeUsername = TextBox1.Text) Then
                MessageBox.Show("Incorrect password provided", "False password", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If
    End Sub

    Public Function getActiveUserIndex() As Integer
        getActiveUserIndex = activeUserIndex
    End Function
End Class