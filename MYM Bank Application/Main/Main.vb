Public Class Main
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Timer1.Start()
        If Not Panel1.Height = 0 Then
            Me.Panel1.Height = 0
            Me.Timer1.Enabled = False
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Me.Panel1.Height = 469
        Me.Timer1.Stop()
    End Sub

    Private Sub Button6_MouseHover(sender As Object, e As EventArgs) Handles Button6.MouseHover
        Me.Button6.BackColor = Color.FromArgb(0, 216, 27, 96)
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.TextBox1.Text = "Hi, I'am Chatbot." & vbNewLine & "How may I help you?"
    End Sub

    Private Sub Button4_MouseHover(sender As Object, e As EventArgs) Handles Button4.MouseHover
        Me.Button4.BackColor = Color.FromArgb(0, 216, 27, 96)
    End Sub

    Private Sub Button5_MouseHover(sender As Object, e As EventArgs) Handles Button5.MouseHover
        Me.Button5.BackColor = Color.FromArgb(0, 216, 27, 96)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Debit.Show()
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs)
        Me.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Member.Show()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Bills.Show()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Transactions.Show()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Dim bill As Bills = New Bills
        Dim t1 As Transactions = New Transactions
        If TextBox2.Text.Contains("amount safe to spend") Or TextBox2.Text.Contains("Amount Safe to Spend") Or TextBox2.Text.Contains("Safe amount to spend") Or TextBox2.Text.Contains("amount that is safe to spend") Then
            Dim totalBills As Integer = bill.changeWaterBill + bill.changeIntBill + bill.changeRent + bill.changeElecBill
            TextBox3.AppendText("Amount safe to spend is: $" & (Sign_up.getUser(Sign_in.getActiveUserIndex).changeBalance - totalBills) & vbNewLine & vbNewLine)
        ElseIf TextBox2.Text.Contains("next salary") Or TextBox2.Text.Contains("Next Salary") Then
            TextBox3.AppendText(vbNewLine & vbNewLine & "Next salary date is: " & t1.changeNextSalary.ToString("yyyy-MM-dd") & vbNewLine & vbNewLine)
        ElseIf TextBox2.Text.Contains("hello") Or TextBox2.Text.Contains("hi") Or TextBox2.Text.Contains("Hi") Or TextBox2.Text.Contains("Hello") Then
            TextBox3.AppendText("Hello, feel free to ask me any questions" & vbNewLine & vbNewLine)
        Else
            TextBox3.AppendText(vbNewLine & vbNewLine & "Sorry, but I cannot comprehend the question" & vbNewLine & vbNewLine)
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Information.Show()
    End Sub
End Class
