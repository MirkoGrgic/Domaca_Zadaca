using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.ZadacaEDukos
{
    public abstract class Trasanction : ITransaction
    {
        protected string SendersAccountNumber { get; set; }
        protected string RecipientsAccountNumber { get; set; }
        protected decimal Amount { get; set; }
        protected DateTime DateTime { get; set; }
        protected string Description { get; set; }

        protected Trasanction(string sendersAccountNumber, string recipientsAccountNumber, decimal amount, DateTime dateTime, string description)
        {
            SendersAccountNumber = sendersAccountNumber;
            RecipientsAccountNumber = recipientsAccountNumber;
            Amount = amount;
            DateTime = dateTime;
            Description = description;
        }
        public virtual void Execute()
        {
            Console.WriteLine($"Executing transaction: {Description}");
            Console.WriteLine($"Amount: {Amount}, Date: {DateTime}");
        }
        public abstract void MakeTransaction();
        public abstract void ExecuteTransaction();
    }
}
