using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week11_GenericCRUD
{
    class CarSet : IRepository<Car>
    {
        private List<Car> Cars { get; set; }

        public void Create(Car value)
        {
            Cars.Add(value);
        }

        public Car Read(int id)
        {
            int index = Cars.FindIndex(c => c.Id == id);
            if (index != -1)
                return Cars[index];
            return null;
        }

        public void Update(Car value)
        {
            int index = Cars.FindIndex(c => c.Id == value.Id);
            if (index != -1)
                Cars[index] = value;
        }

        public void Delete(int id)
        {
            int index = Cars.FindIndex(c => c.Id == id);
            if (index != -1)
                Cars.RemoveAt(index);
        } 
    }     
}
