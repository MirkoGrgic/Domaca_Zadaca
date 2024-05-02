using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Xml.Linq;
using System.Security.Principal;
using static _1.ZadacaEDukos.Program;
using _1.ZadacaEDukos;

namespace _1.ZadacaEDukos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IBankAccount bankAccount = new BankAccount();
            User user = new User("Johnny", "Depp", 123456789, "123 Main St", "Anytown", "NY", "12345", "USA", bankAccount, 2500);
            Bank bank = new Bank();
            bank.AddUser(user);

            
            user.PrintDetails();

            
            Console.WriteLine($"Initial account balance: {user.ShowAccountBalance()}");

            
            bank.Deposit(user, 100);
            Console.WriteLine($"Account balance after deposit: {user.ShowAccountBalance()}");

            
            bank.Withdraw(user, 50);
            Console.WriteLine($"Account balance after withdrawal: {user.ShowAccountBalance()}");
        }
    }
}


