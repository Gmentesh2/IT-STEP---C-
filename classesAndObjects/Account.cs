using System;

public class Account
    {
    private string _currency;
    private string _accountNumber;
    private decimal _balance;

    public Account( string currency, string accountNumber )
        {
        Currency = currency;
        AccountNumber = accountNumber; 
        Balance = 1500; 
        }

    public string AccountNumber
        {
        get { return _accountNumber; }
        private set
            {
            if (value.Length != 22)
                {
                throw new ArgumentOutOfRangeException("Account number must be 22 characters long");
                }
            _accountNumber = value; 
            }
        }

    public string Currency
        {
        get { return _currency; }
        private set
            {
            if (value.Length != 3)
                {
                throw new ArgumentException("Currency must be 3 characters long");
                }
            _currency = value; 
            }
        }

    public decimal Balance
        {
        get { return _balance; }
        private set
            {
            if (value < 0)
                {
                throw new ArgumentOutOfRangeException("Balance cannot be negative");
                }
            _balance = value; 
            }
        }

    public void Deposit( decimal amount )
        {
        if (amount <= 0)
            {
            throw new ArgumentException("Deposit must be positive");
            }
        Balance += amount; 
        Console.WriteLine($"{amount} {Currency} deposit and your balance is {Balance}");
        }

    public void Withdraw( decimal amount )
        {
        if (amount <= 0)
            {
            throw new ArgumentException("Withdrawal amount must be positive");
            }
        if (amount > Balance)
            {
            throw new ArgumentOutOfRangeException("Enter valid amount, your balance has insufficient funds");
            }

        Balance -= amount;
        Console.WriteLine($"You withdrew {amount} {Currency} and your remaining balance is {Balance} {Currency}");
        }

    public void Transfer( Account accountToTransfer, decimal amount )
        {
        Withdraw(amount);
        accountToTransfer.Deposit(amount);
        Console.WriteLine($"Transferred {amount} {Currency} to account {accountToTransfer.AccountNumber}");
        }
    }
