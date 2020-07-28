Public Class Transactions

    Private user As User
    Private Shared amtinBank As Integer
    Private Shared nextSalary As Date

    Property changeamtinBank
        Get
            changeamtinBank = amtinBank
        End Get
        Set(ByVal amt)
            amtinBank = CInt(amt)
        End Set
    End Property

    Property changeNextSalary As Date
        Get
            changeNextSalary = nextSalary
        End Get
        Set(ByVal salaryDate As Date)
            nextSalary = salaryDate
        End Set
    End Property

    Property changeUser As User
        Get
            changeUser = user
        End Get
        Set(ByVal newUser As User)
            user = newUser
        End Set
    End Property

    Public Sub checkAmtinBank()
        If changeamtinBank < 7000 Then
            MsgBox("Be careful, your balance is running low")
        End If
    End Sub

    Public Sub deposit(ByVal amt)
        amtinBank += amt
    End Sub

    Public Sub withdraw(ByVal amt)
        amtinBank -= amt
    End Sub

End Class
