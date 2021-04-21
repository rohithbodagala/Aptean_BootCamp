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
        public void printEmployeeDetails()
        {
            string m = MiddleName;
            string l = LastName;
            if (string.IsNullOrEmpty(m))
            {
                m = "-";
            }
            if (string.IsNullOrEmpty(l))
            {
                l = "-";
            }
            if (DateOfBirth == null) 
            {
                Console.WriteLine($"Employee First Name: {FirstName}\nEmployee Last Name: {l}\nEmployee Middle Name: {m}\nEmployee Date of Birth: -\nAge: -");
            }
            else
            {
                int age = (int)((DateTime.Now - DateOfBirth.GetValueOrDefault()).TotalDays / 365.242199);
                Console.WriteLine($"Employee First Name: {FirstName}\nEmployee Last Name: {l}\nEmployee Middle Name: {m}\nEmployee Date of Birth: {DateOfBirth.GetValueOrDefault().ToString("MM/dd/yyyy")}\nAge: {age}");
            }
                
        }
    }
}
