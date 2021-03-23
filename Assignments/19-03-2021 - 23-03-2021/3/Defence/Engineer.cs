using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Defence
{
    class Engineer : SpecialisedSoldier, IEngineer
    {
      
        public List<Repair> repairs { get ; set; }
        public Engineer(string id, string FirstName, string LastName, double salary, string corps, List<Repair> repairs) : base(id, FirstName, LastName, salary, corps)
        {
            this.repairs = repairs;
        }
        public override string ToString()
        {
            string m = "";
            m += $"{base.ToString()}\nRepairs:\n";
            foreach (var repair in repairs)
            {
                m += $"{repair.ToString()}\n";
            }
            return m;
        }

    }
}
