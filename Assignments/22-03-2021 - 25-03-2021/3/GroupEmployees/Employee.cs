using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupEmployees
{
    class Employee
    {
        public int id;
        public string FirstName, SurName;
        public Employee(int id, string FirstName,string SurName)
        {
            this.id = id;
            this.FirstName = FirstName;
            this.SurName = SurName;
        }
        public override string ToString()
        {
            return $"FirstName: {FirstName}\tSurname: {SurName}";
        }
    }
}
