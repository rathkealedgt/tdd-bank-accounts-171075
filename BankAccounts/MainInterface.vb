Imports System.Text
Public Class MainInterface

    Private Accounts(4) As BankAccount
    Private AccountInt As Integer

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()


        Me.AccountInt = 0

    End Sub

    Private Sub BtnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click

        End

    End Sub


    Public Function SetTextForTesting(AccountHolder As String, AccountNumber As String, Balance As String, InterestRate As String, CountryOfOrigin As String)

        AccountNameInput.Text = AccountHolder
        AccountNumberInput.Text = AccountNumber
        BalanceInput.Text = Balance
        InterestRateInput.Text = InterestRate
        CountryOfOriginInput.Text = CountryOfOrigin

        Return Nothing
    End Function

    Public Function GetAccounts() As BankAccount()

        Return Me.Accounts

    End Function
    Private Sub BtnAddAccount_Click(sender As Object, e As EventArgs) Handles BtnAddAccount.Click

        Dim Feedback As String = "Account Added"
        Dim Title As String = "Success"

        Try

            Me.CreateAccount()

        Catch ex As Exception
            Title = ex.Message

            If ex.Message = "AccountHolderRequiredException" Then

                Feedback = "Please enter the account holder's name"
                AccountNameInput.Focus()



            ElseIf ex.Message = "AccountNumberRequiredException" Then

                Feedback = "Please enter the account number"
                AccountNumberInput.Focus()

            ElseIf ex.Message = "InterestRateRequiredException" Then

                Feedback = "Please enter the interest rate"
                InterestRateInput.Focus()


            ElseIf ex.Message = "BalanceRequiredException" Then

                Feedback = "Please enter the balance"
                BalanceInput.Focus()


            ElseIf ex.Message = "CountryOfOriginRequiredException" Then

                Feedback = "Please enter the country of origin"
                CountryOfOriginInput.Focus()


            ElseIf ex.Message = "MaximumNumAccountsReached" Then

                Feedback = "You have reached the maximum number of accounts"


            ElseIf ex.Message = "InvalidInterestRateDataTypeException" Then

                Feedback = "Please enter a number for the interest rate"
                InterestRateInput.Focus()


            ElseIf ex.Message = "InvalidBalanceDataTypeException" Then

                Feedback = "Please enter a number for the balance"
                BalanceInput.Focus()


            Else
                Title = "An Error Has Occourred"
                Feedback = ex.Message

            End If

        End Try

        MsgBox(Feedback, vbOKOnly, Title)

    End Sub

    Public Function CreateAccount()

        If AccountNameInput.Text = "" Then Throw New Exception("AccountHolderRequiredException")
        If AccountNumberInput.Text = "" Then Throw New Exception("AccountNumberRequiredException")
        If InterestRateInput.Text = "" Then Throw New Exception("InterestRateRequiredException")
        If BalanceInput.Text = "" Then Throw New Exception("BalanceRequiredException")
        If CountryOfOriginInput.Text = "" Then Throw New Exception("CountryOfOriginRequiredException")
        If Me.AccountInt >= 5 Then Throw New Exception("MaximumNumAccountsReached")
        If IsNumeric(InterestRateInput.Text) = False Then Throw New Exception("InvalidInterestRateDataTypeException")
        If IsNumeric(BalanceInput.Text) = False Then Throw New Exception("InvalidBalanceDataTypeException")

        Dim accountHolder As String = AccountNameInput.Text
        Dim accountNumber As String = AccountNumberInput.Text
        Dim countryOfOrigin As String = CountryOfOriginInput.Text
        Dim interestRate As Double = CDbl(InterestRateInput.Text)
        Dim balance As Double = CDbl(BalanceInput.Text)


        Dim NewBankAccount As New BankAccount(accountHolder, accountNumber, balance, interestRate, countryOfOrigin)
        Me.Accounts(Me.AccountInt) = NewBankAccount

        Me.AccountInt += 1

        Return Nothing

    End Function

    Private Sub btnPrintAllAccounts_Click(sender As Object, e As EventArgs) Handles btnPrintAllAccounts.Click

        Dim AllAccounts As New StringBuilder()


        For Each BA As BankAccount In Me.Accounts

            If BA Is Nothing Then Exit For

            AllAccounts.Append(BA.ToString())
            AllAccounts.Append(vbCrLf)

        Next

        TxtAccountList.Text = AllAccounts.ToString()


    End Sub

    Private Sub btnDeposit_Click(sender As Object, e As EventArgs) Handles btnDeposit.Click

        Dim depositInput As String
        Dim Message As String = "Please enter how much you want to Deposit"
        Dim Title As String = "Deposit"

        Dim Feedback As String = "You have deposited $" & depositInput
        Dim TitleFeedback As String = "Deposit"
        Dim isError As Boolean = True

        While isError = True

            Try

                depositInput = InputBox(Message, Title)

                Me.DepositCheck(depositInput)

            Catch Ex As Exception

                TitleFeedback = Ex.Message

                If Ex.Message = "InvalidDepositDataTypeException" Then

                    Feedback = "Please enter a number to withdraw funds"
                    MsgBox(Feedback, vbOKOnly, TitleFeedback)

                ElseIf Ex.Message = "DepositInputRequiredException" Then

                    Feedback = "Please enter a deposit amount"
                    MsgBox(Feedback, vbOKOnly, TitleFeedback)

                Else

                    Feedback = "An error has occoured"
                    MsgBox(Feedback, vbOKOnly, TitleFeedback)

                End If

            End Try

        End While

        MsgBox(Feedback, vbOKOnly, TitleFeedback)





    End Sub

    Public Function DepositCheck(DepositInput As String)

        If DepositInput = "" Then Throw New Exception("DepositInputRequiredException")
        If IsNumeric(DepositInput) = False Then Throw New Exception("InvalidDepositDataTypeException")

        Return Nothing

    End Function
End Class