using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Week4B.Transaction;

namespace Week4B
{
    class BankAccount
    {
        private static int number = 1000;
        public decimal Balance { get; private set; }
        public int Number { get; private set; }
        protected Person Owner { get; set; }
        public List<Transaction> Transactions { get; private set; }

        public BankAccount(Person owner)
        {
            Number = number++;
            Owner = owner;
            Transactions = new List<Transaction>();
        }

        public Transaction Deposit(decimal amount)
        {
            Transaction transaction = new Transaction(amount, TransactionType.DEPOSIT);
            Transactions.Add(transaction);
            Balance += amount;
            return transaction;
        }

        public Transaction Withdraw(decimal amount)
        {
            Transaction transaction = new Transaction(amount, TransactionType.WITHDRAW);
            Transactions.Add(transaction);
            Balance -= amount;
            return transaction;
        }

        public override string ToString()
        {
            return $"#{Number} | {Owner} | {Balance:C}";
        }
    }
}
