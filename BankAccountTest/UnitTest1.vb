Imports System.Text
Imports Microsoft.VisualStudio.TestTools.UnitTesting

<TestClass()> Public Class UnitTest1

    <TestMethod()> Public Sub constructorTest()

        'arrange

        Dim accountHolder As String = "Baguette"
        Dim accountNumber As String = "GRFI 125155 12565342"
        Dim interestRate As Double = 0.1
        Dim balance As Double = 21412.53
        Dim countryOfOrigin As String = "Nepal"

        'act

        Dim accountOne As New BankAccount(accountHolder, accountNumber, balance, interestRate, countryOfOrigin)
        Dim accountTwo As New BankAccount(accountHolder, accountNumber, balance, interestRate)
        Dim accountThree As New BankAccount(accountHolder, accountNumber, balance)

        'assert

        Assert.IsNotNull(accountOne)
        Assert.IsNotNull(accountTwo)
        Assert.IsNotNull(accountThree)

    End Sub

    <TestMethod()> Public Sub GetAccountNameTest()

        'arrange
        Dim accountHolder As String = "Baguette"
        Dim accountNumber As String = "GRFI 125155 12565342"
        Dim interestRate As Double = 0.1
        Dim balance As Double = 21412.53
        Dim countryOfOrigin As String = "Nepal"

        Dim accountOne As New BankAccount(accountHolder, accountNumber, balance, interestRate, countryOfOrigin)

        'act

        Dim name As String = accountOne.GetAccountHolder

        'assert

        Assert.AreEqual(Name, "Baguette")



    End Sub

    <TestMethod()> Public Sub GetAccountNumberTest()

        'arrange
        Dim accountHolder As String = "Baguette"
        Dim accountNumber As String = "GRFI 125155 12565342"
        Dim interestRate As Double = 0.1
        Dim balance As Double = 21412.53
        Dim countryOfOrigin As String = "Nepal"

        Dim accountOne As New BankAccount(accountHolder, accountNumber, balance, interestRate, countryOfOrigin)

        'act

        Dim number As String = accountOne.GetAccountNumber

        'assert

        Assert.AreEqual(number, "GRFI 125155 12565342")


    End Sub

    <TestMethod()> Public Sub GetInterestRateTest()

        'arrange
        Dim accountHolder As String = "Baguette"
        Dim accountNumber As String = "GRFI 125155 12565342"
        Dim interestRate As Double = 0.1
        Dim balance As Double = 21412.53
        Dim countryOfOrigin As String = "Nepal"

        Dim accountOne As New BankAccount(accountHolder, accountNumber, balance, interestRate, countryOfOrigin)

        'act

        Dim interest As Double = accountOne.GetInterestRate

        'assert

        Assert.AreEqual(interest, 0.1)


    End Sub

    <TestMethod()> Public Sub GetBalanceTest()

        'arrange
        Dim accountHolder As String = "Baguette"
        Dim accountNumber As String = "GRFI 125155 12565342"
        Dim interestRate As Double = 0.1
        Dim balance As Double = 21412.53
        Dim countryOfOrigin As String = "Nepal"

        Dim accountOne As New BankAccount(accountHolder, accountNumber, balance, interestRate, countryOfOrigin)

        'act

        Dim balancevalue As Double = accountOne.GetBalance

        'assert

        Assert.AreEqual(balance, 21412.53)


    End Sub

    <TestMethod()> Public Sub GetCountryOfOriginTest()

        'arrange
        Dim accountHolder As String = "Baguette"
        Dim accountNumber As String = "GRFI 125155 12565342"
        Dim interestRate As Double = 0.1
        Dim balance As Double = 21412.53
        Dim countryOfOrigin As String = "Nepal"

        Dim accountOne As New BankAccount(accountHolder, accountNumber, balance, interestRate, countryOfOrigin)

        'act

        Dim country As String = accountOne.GetCountryOfOrigin

        'assert

        Assert.AreEqual(country, "Nepal")


    End Sub

    <TestMethod()> Public Sub SetInterestRateTest()

        'arrange
        Dim accountHolder As String = "Baguette"
        Dim accountNumber As String = "GRFI 125155 12565342"
        Dim interestRate As Double = 0.1
        Dim balance As Double = 21412.53
        Dim countryOfOrigin As String = "Nepal"

        Dim accountOne As New BankAccount(accountHolder, accountNumber, balance, interestRate, countryOfOrigin)

        'act

        Dim interestRateInput As Double = 0.05

        accountOne.SetInterestRate(interestRateInput)

        'assert

        Assert.AreEqual(accountOne.GetInterestRate, 0.05)


    End Sub

    <TestMethod()> Public Sub ApplyInterestRateTest()

        'arrange
        Dim accountHolder As String = "Baguette"
        Dim accountNumber As String = "GRFI 125155 12565342"
        Dim interestRate As Double = 0.1
        Dim balance As Double = 21412.53
        Dim countryOfOrigin As String = "Nepal"

        Dim accountOne As New BankAccount(accountHolder, accountNumber, balance, interestRate, countryOfOrigin)

        Dim expectedOutput As Double = accountOne.GetBalance * ((accountOne.GetInterestRate * (1 / 12)) + 1)

        'act

        accountOne.ApplyInterestRate()

        'assert

        Assert.AreEqual(accountOne.GetBalance, expectedOutput)


    End Sub

    <TestMethod()> Public Sub DepositTest()

        'arrange
        Dim accountHolder As String = "Baguette"
        Dim accountNumber As String = "GRFI 125155 12565342"
        Dim interestRate As Double = 0.1
        Dim balance As Double = 21412.53
        Dim countryOfOrigin As String = "Nepal"

        Dim accountOne As New BankAccount(accountHolder, accountNumber, balance, interestRate, countryOfOrigin)

        Dim depositAmount As Double = 350.0
        Dim expectedOutput As Double = balance + depositAmount

        'act

        accountOne.Deposit(depositAmount)

        'assert

        Assert.AreEqual(accountOne.GetBalance, expectedOutput)


    End Sub

    <TestMethod()> Public Sub WithdrawTest()

        'arrange
        Dim accountHolder As String = "Baguette"
        Dim accountNumber As String = "GRFI 125155 12565342"
        Dim interestRate As Double = 0.1
        Dim balance As Double = 21412.53
        Dim countryOfOrigin As String = "Nepal"

        Dim accountOne As New BankAccount(accountHolder, accountNumber, balance, interestRate, countryOfOrigin)

        Dim withdrawAmount As Double = 350.0
        Dim expectedOutput As Double = balance - withdrawAmount

        'act

        accountOne.Withdraw(withdrawAmount)

        'assert

        Assert.AreEqual(accountOne.GetBalance, expectedOutput)


    End Sub

    <TestMethod()> Public Sub WithdrawOverdraftTest()

        'arrange
        Dim accountHolder As String = "Baguette"
        Dim accountNumber As String = "GRFI 125155 12565342"
        Dim interestRate As Double = 0.1
        Dim balance As Double = 21412.53
        Dim countryOfOrigin As String = "Nepal"

        Dim accountOne As New BankAccount(accountHolder, accountNumber, balance, interestRate, countryOfOrigin)

        Dim withdrawAmount As Double = 25000

        'act

        accountOne.Withdraw(withdrawAmount)

        'assert

        Assert.AreEqual(accountOne.GetBalance, balance)


    End Sub

    <TestMethod()> Public Sub ToStingTest()

        'arrange
        Dim accountHolder As String = "Baguette"
        Dim accountNumber As String = "GRFI 125155 12565342"
        Dim interestRate As Double = 0.01
        Dim balance As Double = 21412.53
        Dim countryOfOrigin As String = "Nepal"

        Dim accountOne As New BankAccount(accountHolder, accountNumber, balance, interestRate, countryOfOrigin)

        Dim expectedStringOutput As New StringBuilder()

        expectedStringOutput.Append("Baguette" & vbCrLf)
        expectedStringOutput.Append("GRFI 125155 12565342" & vbCrLf)
        expectedStringOutput.Append("Nepal" & vbCrLf)
        expectedStringOutput.Append("21412.53" & vbCrLf)
        expectedStringOutput.Append("1%")


        'act

        Dim actualString = accountOne.ToString()

        'assert

        Assert.AreEqual(actualString, expectedStringOutput.ToString())


    End Sub

End Class



