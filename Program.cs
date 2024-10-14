using System;

class Program
{
    static void Main()
    {
        Bank bank = new Bank();
        bool exit = false;

        while (!exit)
        {
            Console.WriteLine("1. Create Account");
            Console.WriteLine("2. Deposit Money");
            Console.WriteLine("3. Withdraw Money");
            Console.WriteLine("4. Transfer Money");
            Console.WriteLine("5. View Account Details");
            Console.WriteLine("6. Exit");
            Console.Write("Choose an option: ");

            switch (Console.ReadLine())
            {
                case "1":
                    CreateAccount(bank);
                    break;
                case "2":
                    DepositMoney(bank);
                    break;
                case "3":
                    WithdrawMoney(bank);
                    break;
                case "4":
                    TransferMoney(bank);
                    break;
                case "5":
                    ViewAccountDetails(bank);
                    break;
                case "6":
                    exit = true;
                    break;
                default:
                    Console.WriteLine("Invalid option. Try again.");
                    break;
            }
        }
    }

    static void CreateAccount(Bank bank)
    {
        Console.Write("Enter account holder name: ");
        string name = Console.ReadLine();
        Console.Write("Enter initial deposit: ");
        double initialDeposit = double.Parse(Console.ReadLine());
        bank.CreateAccount(name, initialDeposit);
    }

    static void DepositMoney(Bank bank)
    {
        Console.Write("Enter account number: ");
        int accountNumber = int.Parse(Console.ReadLine());
        Console.Write("Enter amount to deposit: ");
        double amount = double.Parse(Console.ReadLine());
        Account account = bank.FindAccount(accountNumber);
        if (account != null)
        {
            account.Deposit(amount);
        }
        else
        {
            Console.WriteLine("Account not found.");
        }
    }

    static void WithdrawMoney(Bank bank)
    {
        Console.Write("Enter account number: ");
        int accountNumber = int.Parse(Console.ReadLine());
        Console.Write("Enter amount to withdraw: ");
        double amount = double.Parse(Console.ReadLine());
        Account account = bank.FindAccount(accountNumber);
        if (account != null)
        {
            account.Withdraw(amount);
        }
        else
        {
            Console.WriteLine("Account not found.");
        }
    }

    static void TransferMoney(Bank bank)
    {
        Console.Write("Enter the source account number: ");
        int fromAccountNumber = int.Parse(Console.ReadLine());
        Console.Write("Enter the destination account number: ");
        int toAccountNumber = int.Parse(Console.ReadLine());
        Console.Write("Enter amount to transfer: ");
        double amount = double.Parse(Console.ReadLine());
        bank.TransferMoney(fromAccountNumber, toAccountNumber, amount);
    }

    static void ViewAccountDetails(Bank bank)
    {
        Console.Write("Enter account number: ");
        int accountNumber = int.Parse(Console.ReadLine());
        Account account = bank.FindAccount(accountNumber);
        if (account != null)
        {
            account.DisplayAccountDetails();
        }
        else
        {
            Console.WriteLine("Account not found.");
        }
    }
}
