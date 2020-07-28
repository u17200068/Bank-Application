Public Class Birthday
    Private Shared bday As Date
    Private Shared user As Subuser

    Property changeBday As Date
        Get
            changeBday = bday
        End Get
        Set(ByVal birthday As Date)
            bday = birthday
        End Set
    End Property

    Property changeUser As Subuser
        Get
            changeUser = user
        End Get
        Set(ByVal newUser As Subuser)
            user = newUser
        End Set
    End Property

    Sub birthdayNotification(ByVal user As User, ByVal birthdayDate As Date)
        Dim days As Integer
        Dim current = New Date(Now.Year, bday.Month, bday.Day)
        days = (current - DateTime.Now).Days
        If days = 2 Or days = 1 Or days = 0 Then
            Dim Dialog As DialogResult
            Dialog = MessageBox.Show("This user's Birthday is in the next coming Days" & vbNewLine & "Would you like to send him a gift?", "Birthday Notification", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If Dialog = DialogResult.Yes Then
                Me.Show()
            End If
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If Date.Today = bday Then
            Transactions.changeUser() = user
            Transactions.deposit(Val(TextBox2.Text))
        End If
        MessageBox.Show("Amount will be sent to user on " & bday.ToString("dd/MM/yyyy"), "Gift submitted", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
End Class