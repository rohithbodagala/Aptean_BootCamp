using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University
{
    class College
    {
        public string name, AddressLine1, AddressLine2;
        public List<Student> students;
        public College(string name,string AddressLine1,string AddressLine2,List<Student> students)
        {
            this.name = name;
            this.AddressLine1 = AddressLine1;
            this.AddressLine2 = AddressLine2;
            this.students = students;
        }
        public void printCollegeDetails()
        {
            Console.WriteLine($"College Name: {name}\nAddress Line1: {AddressLine1}\nAddress Line2: {AddressLine2}");


        }
    }
}
