using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week7_Interfaces
{
    abstract class BaseFile
    {
        public string Name { get; set; }

        public BaseFile(string name)
        {
            Name = name;
        }
    }
}
