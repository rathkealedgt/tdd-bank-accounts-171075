Public Class BankAccount

    Private accountHolder As String
    Private accountNumber As String
    Private balance As Double
    Private interestRate As Double
    Private countryOfOrigin As String


    Public Sub New(accountHolderInput As String, accountNumberInput As String, balanceInput As Double, interestRateInput As Double, countryOfOriginInput As String)

        Me.accountHolder = accountHolderInput
        Me.accountNumber = accountNumberInput
        Me.balance = balanceInput
        Me.interestRate = interestRateInput
        Me.countryOfOrigin = countryOfOriginInput

    End Sub
    Public Sub New(accountHolderInput As String, accountNumberInput As String, balanceInput As Double, interestRateInput As Double)

        Me.accountHolder = accountHolderInput
        Me.accountNumber = accountNumberInput
        Me.balance = balanceInput
        Me.interestRate = interestRateInput

    End Sub
    Public Sub New(accountHolderInput As String, accountNumberInput As String, balanceInput As Double)

        Me.accountHolder = accountHolderInput
        Me.accountNumber = accountNumberInput
        Me.balance = balanceInput

    End Sub

    Function GetAccountNumber()

        Return Me.accountNumber

    End Function

    Function GetAccountHolder()

        Return Me.accountHolder

    End Function

    Function GetBalance()

        Return Me.balance

    End Function

    Function GetInterestRate()

        Return Me.interestRate

    End Function

    Function GetCountryOfOrigin()

        Return Me.countryOfOrigin

    End Function

    Function SetInterestRate(interestRateInput As Double)

        Me.interestRate = interestRateInput

        Return Nothing

    End Function

    Function Deposit(depositInput As Double)

        Me.balance = Me.balance + depositInput

        Return Me.balance

    End Function

    Function Withdraw(withdrawInput As Double)

        Dim newBalance As Double

        newBalance = Me.balance - withdrawInput

        If newBalance <= 0 Then

            Return Me.balance

        Else

            Me.balance = newBalance

            Return Me.balance


        End If

    End Function

    Function ApplyInterestRate()

        Me.balance = Me.balance * ((Me.interestRate) * (1 / 12) + 1)

        Return Me.balance

    End Function

    Public Overrides Function ToString() As String
        Return (Me.accountHolder & vbCrLf &
                 Me.accountNumber & vbCrLf &
                 Me.countryOfOrigin & vbCrLf &
                 Me.balance & vbCrLf &
                 Me.interestRate * 100 & "%" & vbCrLf)
    End Function
End Class
