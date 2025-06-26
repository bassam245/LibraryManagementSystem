using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mange
{
    internal abstract class Person
    {
        public int PersonId;
        private string Name;
        public string name
        {
            get { return Name; }
            set { Name = value; }
        }
        public Person(int PersonId, string Name)
        {
            name = Name;
            this.PersonId = PersonId;
        }
        public abstract string Get_Rule();
        public virtual void Displlay_Info()
        {
            Console.WriteLine($"Name : {name.PadRight(10)}  || Id : {PersonId.ToString().PadRight(7)} || ");
        }

    }
}
