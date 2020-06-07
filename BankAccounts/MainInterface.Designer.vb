<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainInterface
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btnDeposit = New System.Windows.Forms.Button()
        Me.btnWithdraw = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.AccountNameInput = New System.Windows.Forms.TextBox()
        Me.AccountNumberInput = New System.Windows.Forms.TextBox()
        Me.BalanceInput = New System.Windows.Forms.TextBox()
        Me.CountryOfOriginInput = New System.Windows.Forms.TextBox()
        Me.InterestRateInput = New System.Windows.Forms.TextBox()
        Me.btnPrintAllAccounts = New System.Windows.Forms.Button()
        Me.BtnAddAccount = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.EventLog1 = New System.Diagnostics.EventLog()
        Me.TxtAccountList = New System.Windows.Forms.TextBox()
        CType(Me.EventLog1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnDeposit
        '
        Me.btnDeposit.Location = New System.Drawing.Point(355, 271)
        Me.btnDeposit.Margin = New System.Windows.Forms.Padding(2)
        Me.btnDeposit.Name = "btnDeposit"
        Me.btnDeposit.Size = New System.Drawing.Size(75, 61)
        Me.btnDeposit.TabIndex = 0
        Me.btnDeposit.Text = "Deposit Funds"
        Me.btnDeposit.UseVisualStyleBackColor = True
        '
        'btnWithdraw
        '
        Me.btnWithdraw.Location = New System.Drawing.Point(464, 271)
        Me.btnWithdraw.Margin = New System.Windows.Forms.Padding(2)
        Me.btnWithdraw.Name = "btnWithdraw"
        Me.btnWithdraw.Size = New System.Drawing.Size(75, 61)
        Me.btnWithdraw.TabIndex = 1
        Me.btnWithdraw.Text = "Withdraw Funds"
        Me.btnWithdraw.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(516, 10)
        Me.btnExit.Margin = New System.Windows.Forms.Padding(2)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 61)
        Me.btnExit.TabIndex = 2
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'AccountNameInput
        '
        Me.AccountNameInput.Location = New System.Drawing.Point(18, 67)
        Me.AccountNameInput.Margin = New System.Windows.Forms.Padding(2)
        Me.AccountNameInput.Name = "AccountNameInput"
        Me.AccountNameInput.Size = New System.Drawing.Size(203, 20)
        Me.AccountNameInput.TabIndex = 3
        '
        'AccountNumberInput
        '
        Me.AccountNumberInput.Location = New System.Drawing.Point(18, 110)
        Me.AccountNumberInput.Margin = New System.Windows.Forms.Padding(2)
        Me.AccountNumberInput.Name = "AccountNumberInput"
        Me.AccountNumberInput.Size = New System.Drawing.Size(203, 20)
        Me.AccountNumberInput.TabIndex = 4
        '
        'BalanceInput
        '
        Me.BalanceInput.Location = New System.Drawing.Point(18, 152)
        Me.BalanceInput.Margin = New System.Windows.Forms.Padding(2)
        Me.BalanceInput.Name = "BalanceInput"
        Me.BalanceInput.Size = New System.Drawing.Size(203, 20)
        Me.BalanceInput.TabIndex = 6
        '
        'CountryOfOriginInput
        '
        Me.CountryOfOriginInput.Location = New System.Drawing.Point(18, 248)
        Me.CountryOfOriginInput.Margin = New System.Windows.Forms.Padding(2)
        Me.CountryOfOriginInput.Name = "CountryOfOriginInput"
        Me.CountryOfOriginInput.Size = New System.Drawing.Size(203, 20)
        Me.CountryOfOriginInput.TabIndex = 8
        '
        'InterestRateInput
        '
        Me.InterestRateInput.Location = New System.Drawing.Point(18, 198)
        Me.InterestRateInput.Margin = New System.Windows.Forms.Padding(2)
        Me.InterestRateInput.Name = "InterestRateInput"
        Me.InterestRateInput.Size = New System.Drawing.Size(203, 20)
        Me.InterestRateInput.TabIndex = 7
        '
        'btnPrintAllAccounts
        '
        Me.btnPrintAllAccounts.Location = New System.Drawing.Point(251, 271)
        Me.btnPrintAllAccounts.Margin = New System.Windows.Forms.Padding(2)
        Me.btnPrintAllAccounts.Name = "btnPrintAllAccounts"
        Me.btnPrintAllAccounts.Size = New System.Drawing.Size(75, 61)
        Me.btnPrintAllAccounts.TabIndex = 9
        Me.btnPrintAllAccounts.Text = "Print Bank Accounts"
        Me.btnPrintAllAccounts.UseVisualStyleBackColor = True
        '
        'BtnAddAccount
        '
        Me.BtnAddAccount.Location = New System.Drawing.Point(18, 289)
        Me.BtnAddAccount.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnAddAccount.Name = "BtnAddAccount"
        Me.BtnAddAccount.Size = New System.Drawing.Size(85, 25)
        Me.BtnAddAccount.TabIndex = 10
        Me.BtnAddAccount.Text = "Add Account"
        Me.BtnAddAccount.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(41, 24)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(151, 13)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Bank Accont Information Input"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(16, 50)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(78, 13)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Account Name"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(16, 93)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(87, 13)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "Account Number"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(16, 136)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(46, 13)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "Balance"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(16, 182)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(68, 13)
        Me.Label5.TabIndex = 16
        Me.Label5.Text = "Interest Rate"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(16, 231)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(87, 13)
        Me.Label6.TabIndex = 17
        Me.Label6.Text = "Country Of Origin"
        '
        'EventLog1
        '
        Me.EventLog1.SynchronizingObject = Me
        '
        'TxtAccountList
        '
        Me.TxtAccountList.Location = New System.Drawing.Point(271, 12)
        Me.TxtAccountList.Multiline = True
        Me.TxtAccountList.Name = "TxtAccountList"
        Me.TxtAccountList.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TxtAccountList.Size = New System.Drawing.Size(228, 234)
        Me.TxtAccountList.TabIndex = 18
        '
        'MainInterface
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(600, 366)
        Me.Controls.Add(Me.TxtAccountList)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BtnAddAccount)
        Me.Controls.Add(Me.btnPrintAllAccounts)
        Me.Controls.Add(Me.CountryOfOriginInput)
        Me.Controls.Add(Me.InterestRateInput)
        Me.Controls.Add(Me.BalanceInput)
        Me.Controls.Add(Me.AccountNumberInput)
        Me.Controls.Add(Me.AccountNameInput)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnWithdraw)
        Me.Controls.Add(Me.btnDeposit)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "MainInterface"
        Me.Text = "MainInterface"
        CType(Me.EventLog1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnDeposit As Windows.Forms.Button
    Friend WithEvents btnWithdraw As Windows.Forms.Button
    Friend WithEvents btnExit As Windows.Forms.Button
    Friend WithEvents AccountNameInput As Windows.Forms.TextBox
    Friend WithEvents AccountNumberInput As Windows.Forms.TextBox
    Friend WithEvents BalanceInput As Windows.Forms.TextBox
    Friend WithEvents CountryOfOriginInput As Windows.Forms.TextBox
    Friend WithEvents InterestRateInput As Windows.Forms.TextBox
    Friend WithEvents btnPrintAllAccounts As Windows.Forms.Button
    Friend WithEvents BtnAddAccount As Windows.Forms.Button
    Friend WithEvents Label1 As Windows.Forms.Label
    Friend WithEvents Label2 As Windows.Forms.Label
    Friend WithEvents Label3 As Windows.Forms.Label
    Friend WithEvents Label4 As Windows.Forms.Label
    Friend WithEvents Label5 As Windows.Forms.Label
    Friend WithEvents Label6 As Windows.Forms.Label
    Friend WithEvents EventLog1 As EventLog
    Friend WithEvents TxtAccountList As Windows.Forms.TextBox
End Class
