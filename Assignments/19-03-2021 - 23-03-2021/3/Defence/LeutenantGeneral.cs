using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Defence
{
    class LeutenantGeneral : Private, ILeutenantGeneral
    {
        

        public List<Private> privateSoldiers { get ; set; }
        public LeutenantGeneral(string id, string FirstName, string LastName, double salary,List<Private> privateSoldiers) : base(id, FirstName, LastName, salary)
        {
            this.privateSoldiers = privateSoldiers;
        }
        public override string ToString()
        {
            string m = "";
            m += $"{base.ToString()}\nPrivates:\n";
            foreach (var p in privateSoldiers)
            {
                m += $"{p.ToString()}\n";
            }
            return m;
        }
    }
}
