// See https://aka.ms/new-console-template for more information
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace BankAccount
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Input your wallet amount");
            int wallet = int.Parse(Console.ReadLine());
            Account account = new Account(1, 22000);
            SavingAccount savingAccount = new SavingAccount(1, 10000);
            CreditAccount creditAccount = new CreditAccount(1, 1000, -2000);
            string option = string.Empty;
            while(option != "0")
            {
                Console.Clear();
                option = mainMenu();
                switch(option)
                {
                    case "0":
                        break;
                    case "1":
                        wallet = Deposit(account, savingAccount, creditAccount, wallet);
                        break;
                    case "2":
                        wallet = Withdraw(account, savingAccount, creditAccount, wallet);
                        break;
                }
                pause();
            }
        }

        public static int Deposit(Account data, SavingAccount savingAccount, CreditAccount creditAccount, int wallet)
        {

            Console.Clear();
            Console.WriteLine($"You have {wallet} in your wallet currently");
            Console.WriteLine($"Current Bank Balance {data.Balance}\n\n");
            Console.WriteLine("how much would you like to deposit?");
            int amount = int.Parse(Console.ReadLine());
            data.Deposit(amount);
            return wallet -= amount;
        }
        public static int Withdraw(Account data, SavingAccount savingAccount, CreditAccount creditAccount, int wallet)
        {
            Console.WriteLine($"Current Bank Balance {data.Balance}");
            Console.WriteLine($"Current Saving Balance {savingAccount.Balance}");
            Console.WriteLine($"Current Credit {creditAccount.Balance} // {creditAccount.Credit}");
            string option = accountMenu();
            Console.Clear();
            Console.WriteLine($"You have {wallet} in your wallet currently");
            Console.WriteLine("how much would you like to withdraw?");
            int amount = int.Parse(Console.ReadLine());
            if (option == "1") { data.Withdraw(amount); }
            else if(option == "2") { savingAccount.Withdraw(amount); }
            else if( option == "3") { creditAccount.Withdraw(amount); }
            return wallet += amount;
        }

        public static string mainMenu()
        {
            string option;
            Console.WriteLine("|-- Bank Menu --|");
            Console.WriteLine("| 1. Deposit");
            Console.WriteLine("| 2. Withdraw");
            Console.WriteLine("| 0. Exit");
            Console.WriteLine($"|- {option = Console.ReadLine()}");
            return option;
        }

        public static string accountMenu()
        {
            string option;
            Console.WriteLine("  Which account are you using?");
            Console.WriteLine("| 1. Main Account");
            Console.WriteLine("| 2. Savings Account");
            Console.WriteLine("| 3. Credit Account");
            Console.WriteLine("| 0. Exit");
            return option = Console.ReadLine(); ;
        }

        public static void pause()
        {
            Console.WriteLine($"Press <Enter> to continue");
            while (Console.ReadKey().Key != ConsoleKey.Enter) { }
            Console.Clear();
        }
    }
}
