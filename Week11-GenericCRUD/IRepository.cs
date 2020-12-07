using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week11_GenericCRUD
{
    interface IRepository<T>
    {
        void Create(T value);
        T Read(int id);
        void Update(T value);
        void Delete(int id);
    }
}
