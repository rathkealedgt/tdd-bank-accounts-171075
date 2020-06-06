Imports System.Text
Imports Microsoft.VisualStudio.TestTools.UnitTesting

<TestClass()> Public Class GUITests

    <TestMethod()> Public Sub TestCreateAccount()

        'arrange
        Dim accountHolder As String = "Baguette"
        Dim accountNumber As String = "GRFI 125155 12565342"
        Dim interestRate As String = "10"
        Dim balance As  String = "21412.53"
        Dim countryOfOrigin As String = "Nepal"
        Dim BF As New BankAccounts.MainInterface()

        BF.SetTextForTesting(accountHolder, accountNumber, balance, interestRate, countryOfOrigin)

        'act

        BF.CreateAccount()
        Dim TempAccount() As BankAccounts.BankAccount = BF.GetAccounts()

        'assert

        Assert.AreEqual(accountHolder, TempAccount(0).GetAccountHolder())
        Assert.AreEqual(accountNumber, TempAccount(0).GetAccountNumber())
        Assert.AreEqual(interestRate, TempAccount(0).GetInterestRate())
        Assert.AreEqual(balance, TempAccount(0).GetBalance())
        Assert.AreEqual(countryOfOrigin, TempAccount(0).GetCountryOfOrigin())


    End Sub

End Class