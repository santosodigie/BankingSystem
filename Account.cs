using System;

public class Account
{
    //properties
    public int AccountNumber { get; private set; }
    public string AccountHolderName { get; private set; }
    public double Balance { get; private set; }
    //constructor
    public Account(int accountNumber, string accountHolderName, double initialBalance)
    {
        AccountNumber = accountNumber;
        AccountHolderName = accountHolderName;
        Balance = initialBalance;
    }

    public void Deposit(double amount)
    {
        if (amount > 0)
        {
            Balance += amount;
            Console.WriteLine($"You have deposited {amount} New Balance is {Balance}");
        }
        else
        {
            Console.WriteLine("Deposited amount must be positive");
        }
    }

    public void Withdraw(double amount)
    {
        if (amount > 0 && amount <= Balance)
        {
            Balance -= amount;
            Console.WriteLine($"You have withdrawn {amount}, your new Balance is {Balance}");
        }
        else
        {
            Console.WriteLine("Invalid withdrawal amount, please make sure you have enough funds!");
        }
    }
    public void DisplayAccountDetails()
    {
        Console.WriteLine($"Account Number: {AccountNumber}, Account Holder: {AccountHolderName}, Balance: {Balance}");
    }
}