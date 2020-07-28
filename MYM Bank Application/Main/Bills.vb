Public Class Bills
    Private Shared elecBill As Double = 100
    Private Shared waterBill As Double = 200
    Private Shared internetBill As Double = 150
    Private Shared rent As Double = 670
    Private Shared monthlyPay As Double
    Private Shared payDate As Date = DateTime.Now.AddDays(30)

    Property changeElecBill As Double
        Get
            changeElecBill = elecBill
        End Get
        Set(ByVal ebill As Double)
            elecBill = ebill
        End Set
    End Property

    Property changeWaterBill As Double
        Get
            changeWaterBill = waterBill
        End Get
        Set(ByVal wbill As Double)
            waterBill = wbill
        End Set
    End Property

    Property changeIntBill As Double
        Get
            changeIntBill = internetBill
        End Get
        Set(ByVal ibill As Double)
            internetBill = ibill
        End Set
    End Property

    Property changeRent As Double
        Get
            changeRent = rent
        End Get
        Set(ByVal rentalAmt As Double)
            rent = rentalAmt
        End Set
    End Property

    Property changeMonthlyPay As Double
        Get
            changeMonthlyPay = monthlyPay
        End Get
        Set(ByVal mPay As Double)
            monthlyPay = mPay
        End Set
    End Property

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If RadioButton2.Checked = True Then
            If ComboBox1.Text = "Electricity bill" Then
                Transactions.withdraw(CInt(TextBox1.Text))
                TextBox3.Text = CStr("$" & (changeElecBill - CInt(TextBox1.Text)))
                changeElecBill = changeElecBill - CInt(TextBox1.Text)
            ElseIf ComboBox1.Text = "Water bill" Then
                Transactions.withdraw(Val(TextBox1.Text))
                TextBox2.Text = "$" & waterBill - CInt(TextBox1.Text)
                changeWaterBill = changeWaterBill - CInt(TextBox1.Text)
            ElseIf ComboBox1.Text = "Internet bill" Then
                Transactions.withdraw(CInt(TextBox1.Text))
                TextBox4.Text = "$" & internetBill - CInt(TextBox1.Text)
                changeIntBill = changeIntBill - CInt(TextBox1.Text)
            ElseIf ComboBox1.Text = "House Rent" Then
                Transactions.withdraw(CInt(TextBox1.Text))
                TextBox5.Text = "$" & rent - CInt(TextBox1.Text)
                changeRent = changeRent - CInt(TextBox1.Text)
            End If

        ElseIf RadioButton1.Checked = True Then
            If ComboBox1.Text = "Electricity bill" Then
                If ((payDate - DateTime.Now).TotalDays = 0) Then
                    Transactions.withdraw(CInt(TextBox1.Text))
                    TextBox3.Text = CStr("$" & (changeElecBill - CInt(TextBox1.Text)))
                    changeElecBill = changeElecBill - CInt(TextBox1.Text)
                End If
            ElseIf ComboBox1.Text = "Water bill" Then
                If ((payDate - DateTime.Now).TotalDays = 0) Then
                    Transactions.withdraw(Val(TextBox1.Text))
                    TextBox2.Text = "$" & waterBill - CInt(TextBox1.Text)
                    changeWaterBill = changeWaterBill - CInt(TextBox1.Text)
                End If
            ElseIf ComboBox1.Text = "Internet bill" Then
                If ((payDate - DateTime.Now).TotalDays = 0) Then
                    Transactions.withdraw(CInt(TextBox1.Text))
                    TextBox4.Text = "$" & internetBill - CInt(TextBox1.Text)
                    changeIntBill = changeIntBill - CInt(TextBox1.Text)
                End If
            ElseIf ComboBox1.Text = "House Rent" Then
                If ((payDate - DateTime.Now).TotalDays = 0) Then
                    Transactions.withdraw(CInt(TextBox1.Text))
                    TextBox5.Text = "$" & rent - CInt(TextBox1.Text)
                    changeRent = changeRent - CInt(TextBox1.Text)
                End If
            Else
                MsgBox("Monthly payment has been set")
            End If
        End If
    End Sub

    Private Sub Bills_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox2.Text = "$" & waterBill
        TextBox3.Text = "$" & elecBill
        TextBox4.Text = "$" & internetBill
        TextBox5.Text = "$" & rent
    End Sub
End Class
