using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.ZadacaEDukos
{
    public class Bank
    {
        private List<User> users;

        public Bank()
        {
            users = new List<User>();
        }
        public void AddUser(User user)
        {
            users.Add(user);
        }
        public void Deposit(User user, decimal amount)
        {
            user.MoneyDeposit(amount);
        }
        public void Withdraw(User user, decimal amount)
        {
            user.WithdrawalOfMoney(amount);
        }
        public decimal DisplayBalance(User user)
        {
            return user.ShowAccountBalance();
        }
    }
}
