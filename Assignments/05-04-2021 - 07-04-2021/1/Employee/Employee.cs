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
        public DateTime DateOfBirth;
        public Employee(string fname,string lname,string mname,DateTime dob)
        {
            FirstName = fname;
            LastName = lname;
            MiddleName = mname;
            DateOfBirth = dob;
        }
        public void printEmployeeDetails()
        {
            string t = MiddleName;
            if (t == null)
            {
                t = "-";
            }
            Console.WriteLine($"Employee First Name: {FirstName}\nEmployee Last Name: {LastName}\nEmployee Middle Name: {t}\nEmployee Date of Birth: {DateOfBirth.ToString("MM/dd/yyyy")}");
        }
    }
}
