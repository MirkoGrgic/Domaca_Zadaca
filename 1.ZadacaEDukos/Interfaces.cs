using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.ZadacaEDukos
{
    internal class Interfaces
    {
    }
    public interface IBankAccount
    {
        void MoneyDeposit(decimal amount);
        void WithdrawalOfMoney(decimal amount);
        decimal ShowAccountBalance();
    }

    public interface ITransaction
    {
        void MakeTransaction();
        void ExecuteTransaction();
    }
}
