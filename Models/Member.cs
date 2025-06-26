using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mange
{
    internal class Member:Person
    {
        public DateTime DateTime;
        public Member(int PersonId, string Name) : base(PersonId, Name)
        {
            this.DateTime = DateTime.Now;

        }
        public override void Displlay_Info()
        {
            base.Displlay_Info();
            Console.Write($"Date Time : {DateTime.ToString().PadRight(10)}");
        }
        public override string Get_Rule()
        {
            return "Member";
        }
    }
}
