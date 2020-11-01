using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week7_Interfaces
{
    interface IStorable
    {
        void Load(string name);
        void Store(string name);
    }
}
