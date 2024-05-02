using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.ZadacaEDukos
{
    public class User : Person
    {
        private IBankAccount bankAccount;
        private decimal balance;

        public User(string firstName, string lastName, int oib, string address, string city, string region, string postalCode, string country, IBankAccount bankAccount, decimal initialBalance)
                    : base(firstName, lastName, oib, initialBalance, address, city, region, postalCode, country)
        {
            this.bankAccount = bankAccount;
            this.balance = initialBalance;
        }

        public void MoneyDeposit(decimal amount)
        {
            bankAccount.MoneyDeposit(amount);
            balance += amount;
        }

        public void WithdrawalOfMoney(decimal amount)
        {
            bankAccount.WithdrawalOfMoney(amount);
            balance -= amount;
        }

        public decimal ShowAccountBalance()
        {
            return balance;
        }

        public override void PrintDetails()
        {
            Console.WriteLine($"User Details:");
            base.PrintDetails();
            Console.WriteLine($"Balance: {ShowAccountBalance()}");
        }
    }
}
