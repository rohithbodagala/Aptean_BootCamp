using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Defence
{
    class Spy : Soldier,ISpy
    {
       

        public string CodeNumber { get ; set; }
        public Spy(string id, string FirstName, string LastName,string CodeNumber): base(id, FirstName, LastName)
        {
            this.CodeNumber = CodeNumber;
        }
        public override string ToString()
        {
            return $"{base.ToString()} Code Number:{this.CodeNumber} ";
        }
    }
}
