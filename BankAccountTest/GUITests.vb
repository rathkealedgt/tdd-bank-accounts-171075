Imports System.Text
Imports Microsoft.VisualStudio.TestTools.UnitTesting

<TestClass()> Public Class GUITests

    <TestMethod()> Public Sub TestCreateAccount()

        'arrange
        Dim accountHolder As String = "Baguette"
        Dim accountNumber As String = "GRFI 125155 12565342"
        Dim interestRate As String = "10"
        Dim balance As String = "21412.53"
        Dim countryOfOrigin As String = "Nepal"
        Dim BF As New BankAccounts.MainInterface()

        BF.SetTextForTesting(accountHolder, accountNumber, balance, interestRate, countryOfOrigin)

        'act

        BF.CreateAccount()
        Dim TempAccount() As BankAccounts.BankAccount = BF.GetAccounts()

        'assert

        Assert.AreEqual(accountHolder, TempAccount(0).GetAccountHolder())
        Assert.AreEqual(accountNumber, TempAccount(0).GetAccountNumber())
        Assert.AreEqual(10.0, TempAccount(0).GetInterestRate())
        Assert.AreEqual(21412.53, TempAccount(0).GetBalance())
        Assert.AreEqual(countryOfOrigin, TempAccount(0).GetCountryOfOrigin())


    End Sub

    <TestMethod()> Public Sub TestEmptyAccountHolder()

        'arrange
        Dim accountHolder As String = ""
        Dim accountNumber As String = "GRFI 125155 12565342"
        Dim interestRate As String = "10"
        Dim balance As String = "21412.53"
        Dim countryOfOrigin As String = "Nepal"
        Dim BF As New BankAccounts.MainInterface()

        BF.SetTextForTesting(accountHolder, accountNumber, balance, interestRate, countryOfOrigin)

        'act

        Try

            BF.CreateAccount()
            Assert.Fail()

        Catch Ex As Exception

            'assert

            Assert.AreEqual("AccountHolderRequiredException", Ex.Message)

        End Try



    End Sub
    <TestMethod()> Public Sub TestEmptyAccountNumber()

        'arrange
        Dim accountHolder As String = "Baguette"
        Dim accountNumber As String = ""
        Dim interestRate As String = "10"
        Dim balance As String = "21412.53"
        Dim countryOfOrigin As String = "Nepal"
        Dim BF As New BankAccounts.MainInterface()

        BF.SetTextForTesting(accountHolder, accountNumber, balance, interestRate, countryOfOrigin)

        'act

        Try

            BF.CreateAccount()
            Assert.Fail()

        Catch Ex As Exception

            'assert

            Assert.AreEqual("AccountNumberRequiredException", Ex.Message)

        End Try

    End Sub

    <TestMethod()> Public Sub TestEmptyInterestRate()

        'arrange
        Dim accountHolder As String = "Baguette"
        Dim accountNumber As String = "GRFI 125155 12565342"
        Dim interestRate As String = ""
        Dim balance As String = "21412.53"
        Dim countryOfOrigin As String = "Nepal"
        Dim BF As New BankAccounts.MainInterface()

        BF.SetTextForTesting(accountHolder, accountNumber, balance, interestRate, countryOfOrigin)

        'act

        Try

            BF.CreateAccount()
            Assert.Fail()

        Catch Ex As Exception

            'assert

            Assert.AreEqual("InterestRateRequiredException", Ex.Message)

        End Try

    End Sub

    <TestMethod()> Public Sub TestEmptyBalance()

        'arrange
        Dim accountHolder As String = "Baguette"
        Dim accountNumber As String = "GRFI 125155 12565342"
        Dim interestRate As String = "10"
        Dim balance As String = ""
        Dim countryOfOrigin As String = "Nepal"
        Dim BF As New BankAccounts.MainInterface()

        BF.SetTextForTesting(accountHolder, accountNumber, balance, interestRate, countryOfOrigin)

        'act

        Try

            BF.CreateAccount()
            Assert.Fail()

        Catch Ex As Exception

            'assert

            Assert.AreEqual("BalanceRequiredException", Ex.Message)

        End Try

    End Sub

    <TestMethod()> Public Sub TestEmptyCountryOfOrigin()

        'arrange
        Dim accountHolder As String = "Baguette"
        Dim accountNumber As String = "GRFI 125155 12565342"
        Dim interestRate As String = "10"
        Dim balance As String = "21412.53"
        Dim countryOfOrigin As String = ""
        Dim BF As New BankAccounts.MainInterface()

        BF.SetTextForTesting(accountHolder, accountNumber, balance, interestRate, countryOfOrigin)

        'act

        Try

            BF.CreateAccount()
            Assert.Fail()

        Catch Ex As Exception

            'assert

            Assert.AreEqual("CountryOfOriginRequiredException", Ex.Message)

        End Try

    End Sub

    <TestMethod()> Public Sub TestInvalidBalanceDataType()

        'arrange
        Dim accountHolder As String = "Baguette"
        Dim accountNumber As String = "GRFI 125155 12565342"
        Dim interestRate As String = "10"
        Dim balance As String = "Test"
        Dim countryOfOrigin As String = "Nepal"
        Dim BF As New BankAccounts.MainInterface()

        BF.SetTextForTesting(accountHolder, accountNumber, balance, interestRate, countryOfOrigin)

        'act

        Try

            BF.CreateAccount()
            Assert.Fail()

        Catch Ex As Exception

            'assert

            Assert.AreEqual("InvalidBalanceDataTypeException", Ex.Message)

        End Try

    End Sub

    <TestMethod()> Public Sub TestInvalidInterestRateDataType()

        'arrange
        Dim accountHolder As String = "Baguette"
        Dim accountNumber As String = "GRFI 125155 12565342"
        Dim interestRate As String = "Test"
        Dim balance As String = "10000.00"
        Dim countryOfOrigin As String = "Nepal"
        Dim BF As New BankAccounts.MainInterface()

        BF.SetTextForTesting(accountHolder, accountNumber, balance, interestRate, countryOfOrigin)

        'act

        Try

            BF.CreateAccount()
            Assert.Fail()

        Catch Ex As Exception

            'assert

            Assert.AreEqual("InvalidInterestRateDataTypeException", Ex.Message)

        End Try

    End Sub

    <TestMethod()> Public Sub TestAddFiveAccounts()

        'arrange
        Dim accountHolder As String = "Baguette"
        Dim accountNumber As String = "GRFI 125155 12565342"
        Dim interestRate As String = "10"
        Dim balance As String = "21412.53"
        Dim countryOfOrigin As String = "Nepal"
        Dim BF As New BankAccounts.MainInterface()


        'act

        Try
            For counter As Integer = 0 To 4

                BF.SetTextForTesting(counter & "_" & accountHolder, accountNumber, balance, interestRate, countryOfOrigin)
                BF.CreateAccount()



            Next counter

        Catch Ex As Exception
            Assert.Fail()


        End Try

        'assert

        Dim tempAccounts() As BankAccounts.BankAccount = BF.GetAccounts()


        For Each BA In tempAccounts

            If BA Is Nothing Then Assert.Fail()

        Next



    End Sub

    <TestMethod()> Public Sub TestCannotAddSixAccounts()

        'arrange
        Dim accountHolder As String = "Baguette"
        Dim accountNumber As String = "GRFI 125155 12565342"
        Dim interestRate As String = "10"
        Dim balance As String = "21412.53"
        Dim countryOfOrigin As String = "Nepal"
        Dim BF As New BankAccounts.MainInterface()


        'act

        Try
            For counter As Integer = 0 To 5

                BF.SetTextForTesting(counter & "_" & accountHolder, accountNumber, balance, interestRate, countryOfOrigin)
                BF.CreateAccount()

            Next counter

            'assert

            Assert.Fail()


        Catch Ex As Exception

            Assert.AreEqual("MaximumNumAccountsReached", Ex.Message)


        End Try

    End Sub

    <TestMethod()> Public Sub TestDepositInputRequiredException()

        'arrange

        Dim BF As New BankAccounts.MainInterface()
        'act

        Try
            BF.DepositCheck("")

            'assert

            Assert.Fail()


        Catch Ex As Exception

            Assert.AreEqual("DepositInputRequiredException", Ex.Message)


        End Try

    End Sub

    <TestMethod()> Public Sub TestInvalidDepositDataTypeException()

        'arrange

        Dim BF As New BankAccounts.MainInterface()
        'act

        Try
            BF.DepositCheck("Test")

            'assert

            Assert.Fail()


        Catch Ex As Exception

            Assert.AreEqual("InvalidDepositDataTypeException", Ex.Message)


        End Try

    End Sub


End Class