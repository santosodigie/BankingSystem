using System;
using System.Collections.Generic;

public class Bank
{
    private List<Account> accounts = new List<Account>();
    private int nextAccountNumber = 1;

    public void CreateAccount(string accountHolderName, double initialBDeposit)
    {
        Account newAccount = new Account(nextAccountNumber++, accountHolderName, initialBDeposit);
        accounts.Add(newAccount);
        Console.WriteLine("Account created successfully.");
        newAccount.DisplayAccountDetails();
    }
    public Account FindAccount(int accountNumber)
    {
        return accounts.Find(account => account.AccountNumber == accountNumber);
    }
    public void TransferMoney(int fromAccountNumber, int toAccountNumber, double amount)
    {
        Account fromAccount = FindAccount(fromAccountNumber);
        Account toAccount = FindAccount(toAccountNumber);

        if (fromAccount != null && toAccount != null)
        {
            fromAccount.Withdraw(amount);
            toAccount.Deposit(amount);
            Console.WriteLine("Transfer completed successfully.");
        }
        else
        {
            Console.WriteLine("One or both accounts not found.");
        }
    }
}