using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week4B
{
    class Transaction
    {
        public enum TransactionType { DEPOSIT, WITHDRAW};
        public decimal Amount { get; set; }
        public DateTime Timestamp { get; set; }
        public TransactionType Type { get; set; }

        public Transaction (decimal amount, TransactionType type)
        {
            Amount = amount;
            Type = type;
            Timestamp = DateTime.Now;
        }

        public override string ToString()
        {
            return $"{Timestamp} | {Type}: {Amount:C}";
        }
    }
}
