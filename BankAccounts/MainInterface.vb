Public Class MainInterface

    Private Accounts() As BankAccount
    Private AccountInt As Integer

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()


        Me.AccountInt = 0

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        End

    End Sub
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click

        SetTextForTesting("One", "Two", "Three", "Four", "Five")

    End Sub

    Public Function SetTextForTesting(AccountHolder As String, AccountNumber As String, Balance As String, InterestRate As String, CountryOfOrigin As String)

        AccountNameInput.Text = AccountHolder
        AccountNumberInput.Text = AccountNumber
        BalanceInput.Text = Balance
        InterestRateInput.Text = InterestRate
        CountryOfOriginINput.Text = CountryOfOrigin

        Return Nothing
    End Function

    Public Function GetAccounts() As BankAccount()

        Return Me.Accounts

    End Function

    Public Function CreateAccount()

        Dim accountHolder As String = AccountNameInput.Text
        Dim accountNumber As String = AccountNumberInput.Text
        Dim interestRate As Double = CDbl(InterestRateInput.Text)
        Dim balance As Double = CDbl(BalanceInput.Text)
        Dim countryOfOrigin As String = CountryOfOriginINput.Text

        Dim NewBankAccount As New BankAccount(accountHolder, accountNumber, balance, interestRate, countryOfOrigin)
        NewBankAccount = Me.Accounts(Me.AccountInt)

        Return Nothing

    End Function

End Class