// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

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
    Console.WriteLine("Choose an option: ");

    switch (Console.ReadLine())
    {
        case "1":
            Console.Write("Enter account holder name: ");
            string name = Console.ReadLine();
            Console.Write("Enter initial deposit: ");
            double initialDeposit = double.Parse(Console.ReadLine());
            bank.CreateAccount(name, initialDeposit);
            break;
        case "2":
            break;
        case "3":
            break;
        case "4":
            break;
        case "5":
            break;
        case "6":
            exit = true;
            break;
        default:
            Console.WriteLine("Invalid option. Try again");
            break;
    }
}