using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week4B
{
    class ChequingAccount : BankAccount
    {
        public decimal OverdraftFee { get; private set; } = 10M;

        public ChequingAccount(Person owner) : base(owner)
        {

        }

        public override string ToString()
        {
            return "Chequing Account: " + base.ToString();
        }
    }
}
