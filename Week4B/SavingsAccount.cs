using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week4B
{
    class SavingsAccount : BankAccount
    {
        public decimal InterestRate { get; private set; } = 0.017M;

        public SavingsAccount(Person owner) : base(owner)
        {

        }

        public override string ToString()
        {
            return "Savings Account: " + base.ToString();
        }
    }
}
