Public Class Information
    Private t1 As Transactions

    Property changeTransaction As Transactions
        Get
            changeTransaction = t1
        End Get
        Set(ByVal trans As Transactions)
            t1 = trans
        End Set
    End Property

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Sign_up.getUser(Sign_in.getActiveUserIndex).changePassword = TextBox1.Text
        Dim t1 As Transactions = New Transactions
        t1.changeUser = Sign_up.getUser(Sign_in.getActiveUserIndex)
        t1.changeNextSalary = DateTimePicker1.Value.Date
        Sign_up.getUser(0).changeBalance() = Val(TextBox3.Text.Remove(0, 1))
        Sign_up.getUser(Sign_in.getActiveUserIndex).changeCity = ComboBox1.Text
        MessageBox.Show("Information has been updated", "Update", MessageBoxButtons.OK)
    End Sub

End Class