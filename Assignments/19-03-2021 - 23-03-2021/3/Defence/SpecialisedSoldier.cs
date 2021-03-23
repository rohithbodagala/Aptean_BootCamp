using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Defence
{
    abstract class SpecialisedSoldier : Private, ISpecialisedSoldier
    {
        public string corps { get ; set; }
        public SpecialisedSoldier(string id, string FirstName, string LastName, double salary,string corps) : base(id, FirstName, LastName,salary)
        {
            this.corps = corps;
        }

        public override string ToString()
        {
            return $"{base.ToString()} \nCorps: {corps} ";
        }


    }
}
