using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week4B
{
    class Branch
    {
        private static int number = 1000;
        public List<BankAccount> Accounts { get; set; }
        public string Name { get; set; }
        public int BranchNumber { get; set; }

        public Branch(string name)
        {
            Name = name;
            BranchNumber = number++;
            Accounts = new List<BankAccount>();
        }

        internal BankAccount BankAccount
        {
            get => default;
            set
            {
            }
        }
    }
}
