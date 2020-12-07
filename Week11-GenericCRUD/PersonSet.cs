using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week11_GenericCRUD
{
    class PersonSet : IRepository<Person>
    {
        private List<Person> Persons { get; set; }

        public void Create(Person value)
        {
            Persons.Add(value);
        }

        public Person Read(int id)
        {
            int index = Persons.FindIndex(p => p.Id == id);
            if (index != -1)
                return Persons[index];
            return null;
        }

        public void Update(Person value)
        {
            int index = Persons.FindIndex(p => p.Id == value.Id);
            if (index != -1)
                Persons[index] = value;
        }

        public void Delete(int id)
        {
            int index = Persons.FindIndex(p => p.Id == id);
            if (index != -1)
                Persons.RemoveAt(index);
        }      
    }
}
