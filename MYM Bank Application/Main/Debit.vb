Public Class Debit
    Private debitAmount As Integer
    Private debitTitle As String
    Private debitMonthlyPay As Integer
    Private finalDate As Date

    Property changeAmount() As Integer
        Get
            changeAmount = debitAmount
        End Get
        Set(ByVal amount As Integer)
            debitAmount = amount
        End Set
    End Property

    Property changeTitle() As String
        Get
            changeTitle = debitTitle
        End Get
        Set(ByVal title As String)
            debitTitle = title
        End Set
    End Property

    Property changeMonthlyAmount() As Integer
        Get
            changeMonthlyAmount = debitMonthlyPay
        End Get
        Set(ByVal monthlyAmount As Integer)
            debitMonthlyPay = monthlyAmount
        End Set
    End Property

    Property changeFinalDate() As Date
        Get
            changeFinalDate = finalDate
        End Get
        Set(ByVal Fdate As Date)
            finalDate = Fdate
        End Set
    End Property

    Private Sub SubDebit_Click(sender As Object, e As EventArgs) Handles SubDebit.Click
        changeAmount = TextBox1.Text
        changeTitle = TextBox3.Text
        changeMonthlyAmount = TextBox2.Text
        changeFinalDate = DateTimePicker1.Value.Date
        Label1.Text = "$" & TextBox1.Text
        GroupBox1.Text = TextBox3.Text
    End Sub
End Class
