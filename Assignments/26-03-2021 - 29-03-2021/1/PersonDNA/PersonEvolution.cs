using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonDNA
{
    class PersonEvolution
    {
        public Person p;
        public char From, To;
        public PersonEvolution(Person p,char From,char To)
        {
            this.p = p;
            this.From = From;
            this.To = To;
        }
    }
}
