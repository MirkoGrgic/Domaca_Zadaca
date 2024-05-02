using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.ZadacaEDukos
{
    public class BankAccount : IBankAccount
    {
        private decimal balance;

        public void MoneyDeposit(decimal amount)
        {
            if (amount <= 0)
            {
                throw new ArgumentException("Money amount must be greater than zero.");
            }

            balance += amount;
        }

        public void WithdrawalOfMoney(decimal amount)
        {
            if (amount <= 0 || amount > balance)
            {
                throw new ArgumentException("Invalid withdrawal amount.");
            }

            balance -= amount;
        }

        public decimal ShowAccountBalance()
        {
            return balance;
        }
    }
}
