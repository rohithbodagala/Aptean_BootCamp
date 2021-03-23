using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Defence
{
    class Private : Soldier,IPrivate
    {
        public double salary { get ; set; }
        public Private(string id,string FirstName,string LastName,double salary) : base(id,FirstName,LastName)
        {
            
            this.salary = salary;
        }
        public override string ToString()
        {
            return $"Name: {FirstName} {LastName}  Id:{id} Salary:{salary} ";
        }



    }
}
