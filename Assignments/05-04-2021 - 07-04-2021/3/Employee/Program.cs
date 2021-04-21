using System;

namespace Employee
{
    class Program
    {
        static void Main(string[] args)
        {
            string FirstName, LastName, MiddleName;
            int date, month, year;
            bool isdate, ismonth, isyear;
            DateTime? dob;
            Console.WriteLine("Enter First Name");
            FirstName = Console.ReadLine();
            Console.WriteLine("Enter Last Name");
            LastName= Console.ReadLine();
            Console.WriteLine("Enter Middle Name");
            MiddleName= Console.ReadLine();
            Console.WriteLine("Enter Date of birth");
            isdate=int.TryParse(Console.ReadLine(),out date);
            Console.WriteLine("Enter Month of birth");
            ismonth= int.TryParse(Console.ReadLine(),out month);
            Console.WriteLine("Enter Year of birth");
            isyear= int.TryParse(Console.ReadLine(),out year);
            if (string.IsNullOrEmpty(MiddleName))
            {
                MiddleName = null;
            }
            if (string.IsNullOrEmpty(LastName))
            {
                LastName = null;
            }
            if(!isyear || !ismonth || !isdate)
            {
                dob = null;
            }
            else
            {
                dob = new DateTime(year, month, date);
            }
            
            Employee emp = new Employee(FirstName, LastName, MiddleName,dob);
            emp.printEmployeeDetails();

        }
    }
}
