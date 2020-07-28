Public Class Subuser
    Inherits User

    Dim ParentUser As User
    Dim privelegeStatus As String
    Dim allowance As Integer

    Property changeAllowance As Integer
        Get
            changeAllowance = allowance
        End Get
        Set(ByVal money As Integer)
            allowance = money
        End Set
    End Property

    Property changeParentUser As User
        Get
            changeParentUser = ParentUser
        End Get
        Set(ByVal parent As User)
            ParentUser = parent
        End Set
    End Property

    Property changePrivelegeStatus() As String
        Get
            changePrivelegeStatus = privelegeStatus
        End Get
        Set(ByVal privStat As String)
            privelegeStatus = privStat
        End Set
    End Property
End Class
