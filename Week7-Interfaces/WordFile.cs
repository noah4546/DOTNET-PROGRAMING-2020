using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week7_Interfaces
{
    class WordFile : BaseFile, IPrintable, IStorable
    {
        public WordFile(string name) : base(name) { }

        public void Preview()
        {
            Console.WriteLine($"WordFile.Preview method for {Name}");
        }

        public void Print()
        {
            Console.WriteLine($"WordFile.Print method for {Name}");
        }

        public void Load(string name)
        {
            Console.WriteLine($"WordFile.Load method for {Name}");
        }

        public void Store(string name)
        {
            Console.WriteLine($"WordFile.Store method for {Name}");
        }
    }
}
