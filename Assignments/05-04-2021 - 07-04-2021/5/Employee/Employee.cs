using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee
{
    public class Employee
    {
        public string FirstName, LastName, MiddleName;
        public DateTime? DateOfBirth;
        public Employee(string fname,string lname,string mname,DateTime? dob)
        {
            FirstName = fname;
            LastName = lname;
            MiddleName = mname;
            DateOfBirth = dob;
        }
        
    }
}
